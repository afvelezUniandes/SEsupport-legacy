Imports System
Imports System.Windows
Public Class Editar_tecnico_req

    Public num_soporte As String
    Private m_responsable, m_estado, comentario As String
    Dim funciones_generales As New Funciones_generales
    Dim consultar As New Querys_incidentes
    Private Sub Editar_tecnico_req_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dttiporeq, dttecnico, dthist, dtusuario, dtprioridad, dtmodulo, dtmotivo, dtestado As New DataTable
        'CmbUsuario.Enabled = False
        Try
            dttiporeq = consultar.cons_tiporeq()
            dttecnico = consultar.cons_tecnico()
            dtprioridad = consultar.cons_prioridad()
            dtmodulo = consultar.cons_modulo()
            dtmotivo = consultar.cons_motivo()
            dtusuario = consultar.cons_usuario("")
            dtestado = consultar.cons_estado("")
            dthist = consultar.cons_pendientes_numero(num_soporte)

            'llenamos los datos
            TxbNumero.Text = num_soporte
            TxbDescripcion.Text = dthist.Rows(0)(8).ToString()
            MskFechaReq.Text = dthist.Rows(0)(10).ToString()
            MskFechaEntrega.Text = dthist.Rows(0)(9).ToString()
            DTPFechaPactada.Text = dthist.Rows(0)(11).ToString()
            TxbCalificacion.Text = dthist.Rows(0)(2).ToString()
            TxbRazon.Text = dthist.Rows(0)(16).ToString()
            TxbObservaciones.Text = dthist.Rows(0)(19).ToString()


            CmbUsuario.DataSource = dtusuario
            CmbUsuario.DisplayMember = dtusuario.Columns(3).ToString()
            CmbUsuario.ValueMember = dtusuario.Columns(1).ToString()
            CmbUsuario.Text = dthist.Rows(0)(7).ToString()

            CmbTipo.DataSource = dttiporeq
            CmbTipo.DisplayMember = dttiporeq.Columns(1).ToString()
            CmbTipo.ValueMember = dttiporeq.Columns(0).ToString()
            CmbTipo.Text = dthist.Rows(0)(6).ToString()

            CmbResponsable.DataSource = dttecnico
            CmbResponsable.DisplayMember = dttecnico.Columns(3).ToString()
            CmbResponsable.ValueMember = dttecnico.Columns(1).ToString()
            CmbResponsable.Text = dthist.Rows(0)(5).ToString()
            m_responsable = dthist.Rows(0)(5).ToString()

            CmbPrioridad.DataSource = dtprioridad
            CmbPrioridad.DisplayMember = dtprioridad.Columns(1).ToString()
            CmbPrioridad.ValueMember = dtprioridad.Columns(0).ToString()
            CmbPrioridad.Text = dthist.Rows(0)(4).ToString()

            CmbModulo.DataSource = dtmodulo
            CmbModulo.DisplayMember = dtmodulo.Columns(1).ToString()
            CmbModulo.ValueMember = dtmodulo.Columns(0).ToString()
            CmbModulo.Text = dthist.Rows(0)(0).ToString()

            CmbMotivo.DataSource = dtmotivo
            CmbMotivo.DisplayMember = dtmotivo.Columns(1).ToString()
            CmbMotivo.ValueMember = dtmotivo.Columns(0).ToString()
            CmbMotivo.Text = dthist.Rows(0)(23).ToString()

            CmbEstado.DataSource = dtestado
            CmbEstado.DisplayMember = dtestado.Columns(1).ToString()
            CmbEstado.ValueMember = dtestado.Columns(0).ToString()
            CmbEstado.Text = dthist.Rows(0)(3).ToString()
            m_estado = dthist.Rows(0)(12).ToString()

            'valido si esta finalizado para bloquear modificacion
            If dthist.Rows(0)(12).ToString() = 3 Or dthist.Rows(0)(12).ToString() = 4 Then
                deshabilitar()
            End If

            If dthist.Rows(0)(12).ToString() = 5 Then
                CheckBComite.Checked = True
            End If

            TxbObservaciones.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        cargar_comentarios()
    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        Dim estado As Integer = 0

        If CheckBFinalizado.Checked = True Then
            estado = 3
        ElseIf CheckBComite.Checked = True Then
            estado = 5
        Else
            estado = CmbEstado.SelectedValue.ToString()
        End If

        Try
            If (CmbResponsable.SelectedIndex.ToString >= 0) Then
                consultar.actualiza_req(estado, CmbUsuario.SelectedValue.ToString(), CmbModulo.SelectedValue.ToString(), CmbTipo.SelectedValue.ToString(), DTPFechaPactada.Text, TxbNumero.Text, CmbPrioridad.SelectedValue.ToString(), CmbMotivo.SelectedValue.ToString(), CmbResponsable.SelectedValue.ToString(), TxbObservaciones.Text, TxbCSI.Text)

                If estado <> m_estado Then
                    enviar_correo(estado)
                End If

                MsgBox("Se actualizó correctamente la información", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                deshabilitar()
                Me.Close()
                Principal_tecnico_req.actualizar_pantalla()
            Else
                MsgBox("El requerimiento no ha sido asignado a una persona. Seleccione un responsable", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Sub deshabilitar()
        DTPFechaPactada.Enabled = False
        CmbResponsable.Enabled = False
        CmbTipo.Enabled = False
        CmbPrioridad.Enabled = False
        CmbModulo.Enabled = False
        CmbMotivo.Enabled = False
        TxbObservaciones.Enabled = False
        TxbCSI.Enabled = False
        CheckBComite.Enabled = False
        CheckBFinalizado.Enabled = False
        CmbUsuario.Enabled = False
        BtnEnviar.Enabled = False
    End Sub
    Private Sub Editar_tecnico_req_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Principal_tecnico_req.Enabled = True
    End Sub

    Private Sub LinkAdjuntos_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkAdjuntos.LinkClicked
        carpeta_temp = "inc_" & TxbNumero.Text
        Me.Enabled = False
        adjuntar.ruta_adjunto = ruta_adjunto_incidente & carpeta_temp
        adjuntar.Show()
    End Sub

    Private Sub LinkCicloAprobacion_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkCicloAprobacion.LinkClicked
        Me.Enabled = False
        ciclo_aprobacion.numero_incidente = TxbNumero.Text
        ciclo_aprobacion.descripcion = TxbDescripcion.Text
        ciclo_aprobacion.Show()
    End Sub

    Sub enviar_correo(tipo As String)
        Dim fechamodificacion As Date = Date.Now
        fechamodificacion = fechamodificacion.ToString("dd/MM/yyyy")

        Dim dt_texto_correo, dtestado, dtmail As New DataTable
        dtmail = consultar.cons_usuario(CmbUsuario.SelectedValue.ToString())
        If tipo <> 7 Then
            dtestado = consultar.cons_estado(tipo)
            funciones_generales.envio_correo(dtmail.Rows(0)(6).ToString(), "Cambio de estado, soporte número: " & TxbNumero.Text, 3, TxbNumero.Text, TxbDescripcion.Text, dtestado.Rows(0)(1).ToString(), TxbObservaciones.Text, fechamodificacion, "", "", "")
        Else
            funciones_generales.envio_correo(dtmail.Rows(0)(6).ToString(), "Se ingresó una nueva observación al soporte número: " & TxbNumero.Text, tipo, TxbNumero.Text, comentario, Date.Now.ToString("dd/MM/yyyy HH:mm"), "", "", "", "", "")
        End If

    End Sub

    Private Sub LinkComentarios_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkComentarios.LinkClicked
        Dim i As String = InputBox("INGRESE EL COMENTARIO", "")
        If i <> "" Then
            comentario = i
            consultar.ingresar_observacion(TxbNumero.Text, i, user)
            MsgBox("se ingresó correctamente el comentario")
            cargar_comentarios()
            enviar_correo(7)
        End If
    End Sub

    Sub cargar_comentarios()
        Dim dt As New DataTable
        dt = consultar.consultar_observacion(TxbNumero.Text)
        DgvComentarios.DataSource = Nothing
        DgvComentarios.DataSource = dt
        DgvComentarios.Columns(0).HeaderText = "USUARIO"
        DgvComentarios.Columns(1).HeaderText = "FECHA"
        DgvComentarios.Columns(2).HeaderText = "COMENTARIO"
        DgvComentarios.Columns(0).Width = 150
        DgvComentarios.Columns(1).Width = 150
        DgvComentarios.Columns(2).Width = DgvComentarios.Width - 350
        DgvComentarios.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DgvComentarios.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells)
    End Sub

    Private Sub TxbDescripcion_TextChanged(sender As Object, e As EventArgs) Handles TxbDescripcion.TextChanged

    End Sub
End Class