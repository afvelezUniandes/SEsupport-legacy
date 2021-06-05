Imports System.IO
Public Class Principal_usuario_req
    Private guardado As Boolean = False
    Dim funciones_generales As New Funciones_generales

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtprioridad, dtestado, dtmodulo, dttipo, dtusuario As New DataTable
        Dim consultas As New Querys_incidentes
        Usuario.Text = nombre
        'cargamos los pendientes
        pendientes()
        'cargamos los combobox
        Try
            dtprioridad = consultas.cons_prioridad()
            CmbPrioridad.DataSource = dtprioridad
            CmbPrioridad.DisplayMember = dtprioridad.Columns(1).ToString()
            CmbPrioridad.ValueMember = dtprioridad.Columns(0).ToString()

            dtestado = consultas.cons_estado("")
            CmbEstado.DataSource = dtestado
            CmbEstado.ValueMember = dtestado.Columns(0).ToString()
            CmbEstado.DisplayMember = dtestado.Columns(1).ToString()

            dtmodulo = consultas.cons_modulo()
            CmbModulo.DataSource = dtmodulo
            CmbModulo.ValueMember = dtmodulo.Columns(0).ToString()
            CmbModulo.DisplayMember = dtmodulo.Columns(1).ToString()

            dttipo = consultas.cons_tiporeq()
            Cmbtipo.DataSource = dttipo
            Cmbtipo.ValueMember = dttipo.Columns(0).ToString()
            Cmbtipo.DisplayMember = dttipo.Columns(1).ToString()

            If nivel < 2 Then
                dtusuario = consultas.cons_login(nombre)
                TecnicoToolStripMenuItem.Visible = False
                TecnicoToolStripMenuItem.Enabled = False
            Else
                dtusuario = consultas.cons_login("Sesupport")
            End If
            CmbUsuario.DataSource = dtusuario
            CmbUsuario.ValueMember = dtusuario.Columns(5).ToString()
            CmbUsuario.DisplayMember = dtusuario.Columns(1).ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ToolStripStatusLabel2.Text = nombre

        'inicializamos los combobox en "" y cargamos los pendientes que se tengan
        limpiar()

        'deshabilitamos que se pueda cambiar le usuario 
        If nivel < 2 Then
            CmbUsuario.Text = nombre
            CmbUsuario.Enabled = False
        Else
            CmbUsuario.Text = nombre
            CmbPrioridad.Focus()
        End If

        CmbEstado.Text = ""

        carpeta_temp = funciones_generales.random
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If CmbModulo.Text <> "" And CmbPrioridad.Text <> "" And Cmbtipo.Text <> "" And TxbDescripcion.Text <> "" Then
            Dim nuevo_req As New Querys_incidentes
            Try
                nuevo_req.nuevo_incidente(user, CmbModulo.SelectedValue.ToString(), CmbPrioridad.SelectedValue.ToString(), 1, Cmbtipo.SelectedValue.ToString(), Replace(TxbDescripcion.Text, "'", "{"))
                pendientes()

                enviar_correo_nuevo_req()

                MsgBox("Enviado correctamente", MsgBoxStyle.Information)
                guardado = True
                funciones_generales.renombrar_directorio_temp(user, ruta_adjunto_incidente & carpeta_temp, "inc_")
                funciones_generales.borrar_directorio_temp(ruta_adjunto_incidente & carpeta_temp)
                limpiar()
            Catch ex As Exception
                MsgBox("Error al enviar, intente nuevamente", MsgBoxStyle.Critical)
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Debe completar toda la información para poder generar el requerimiento", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub pendientes()
        Dim dt As New DataTable
        Dim consultar_pedientes As New Querys_incidentes
        Try
            dt = consultar_pedientes.cons_pendientes_usu(user)
            DgvPendientes.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub limpiar()
        CmbModulo.Text = ""
        CmbPrioridad.Text = ""
        Cmbtipo.Text = ""
        TxbDescripcion.Text = ""
        DgvPendientes.DataSource = Nothing
        pendientes()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        limpiar()
    End Sub


    Private Sub DgvPendientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPendientes.CellDoubleClick
        If (e.RowIndex >= 0) Then
            Editar_usuario_req.num_soporte = Me.DgvPendientes(1, e.RowIndex).Value.ToString()
            Editar_usuario_req.Show()
            Me.Enabled = False
        End If
    End Sub


    Private Sub CmbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEstado.SelectedIndexChanged
        Try
            DgvPendientes.DataSource = Nothing
            Dim dt As New DataTable
            Dim consultar_pedientes As New Querys_incidentes

            dt = consultar_pedientes.cons_pendientes_usu_estado(nombre, CmbEstado.SelectedValue.ToString())
            DgvPendientes.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub TecnicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TecnicoToolStripMenuItem.Click
        Dim dtper As New DataTable
        Dim nvp As Integer
        dtper = funciones_generales.cons_permisos(user, "1")
        For Each i As DataRow In dtper.Rows
            nvp = i(2).ToString
            If nvp = 2 Then
                Principal_tecnico_req.Show()
                Me.Close()
            End If
        Next
    End Sub

    Private Sub QuejasYNoConformidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuejasYNoConformidadesToolStripMenuItem.Click
        Inicio.Show()
        Me.Close()
    End Sub

    Private Sub BtnAdjuntar_Click(sender As Object, e As EventArgs) Handles BtnAdjuntar.Click
        Me.Enabled = False
        adjuntar.ruta_adjunto = ruta_adjunto_incidente & carpeta_temp
        adjuntar.Show()
    End Sub

    Private Sub Principal_usuario_req_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        funciones_generales.borrar_directorio_temp(ruta_adjunto_incidente & carpeta_temp)
    End Sub

    Private Sub AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AToolStripMenuItem.Click
        Me.Enabled = False
        Dim dtper As New DataTable
        Dim nvp As Integer
        dtper = funciones_generales.cons_permisos(user, "14")
        For Each i As DataRow In dtper.Rows
            nvp = i(2).ToString
            If nvp = 3 Or nvp = 2 Then
                ciclo_aprobacion.usuario = user
                ciclo_aprobacion.Show()
            End If
        Next
    End Sub

    Private Sub InformesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MsgBox("En Desarrollo")
    End Sub

    Private Sub enviar_correo_nuevo_req()
        Dim fechacreacion As Date = Date.Now
        fechacreacion = fechacreacion.ToString("dd/MM/yyyy")

        Dim dt_texto_correo, dt_numero_soporte As New DataTable
        Dim adjuntos As Boolean
        Dim adjunto As String
        adjuntos = funciones_generales.cons_directorio_vacio(ruta_adjunto_incidente & carpeta_temp)
        If adjuntos = True Then
            adjunto = "SI"
        Else
            adjunto = "NO"
        End If

        Dim consulta As New Querys_incidentes

        dt_numero_soporte = consulta.cons_numero_req(user)
        funciones_generales.envio_correo("soporte@santaelena.com.co", "Nuevo Soporte: " & dt_numero_soporte.Rows(0)(0).ToString(), 1, nombre, fechacreacion, TxbDescripcion.Text, CmbPrioridad.Text.ToString(), CmbModulo.Text.ToString(), Cmbtipo.Text.ToString(), adjunto, "")

    End Sub
End Class

