Public Class Editar_usuario_req

    Public num_soporte As String
    Dim funciones_generales As New Funciones_generales
    Dim querys As New Querys_incidentes
    Private comentario As String

    Private Sub Editar_usuario_req_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'llenamos la información
        Dim dtincidente As New DataTable
        dtincidente = querys.cons_pendientes_usu_idhist(nombre, num_soporte)
        TxbNumero.Text = num_soporte
        'TxbUsuario.Text = dtincidente.Rows(0)(7).ToString()
        TxbEstado.Text = dtincidente.Rows(0)(3).ToString()
        TxbDescripcion.Text = dtincidente.Rows(0)(8).ToString()
        MskFechaReq.Text = dtincidente.Rows(0)(10).ToString()
        MskFechaEntrega.Text = dtincidente.Rows(0)(9).ToString()
        MskFechaPac.Text = dtincidente.Rows(0)(11).ToString()
        TxbResponsable.Text = dtincidente.Rows(0)(5).ToString()
        CmbCalificacion.SelectedText = dtincidente.Rows(0)(2).ToString()
        TxbRazon.Text = dtincidente.Rows(0)(16).ToString()
        TxbObservaciones.Text = dtincidente.Rows(0)(19).ToString()
        TxbIdUsuario.Text = dtincidente.Rows(0)(21).ToString()
        TxbIdTecnico.Text = dtincidente.Rows(0)(20).ToString()

        'valido si el estado esta finalizado
        If dtincidente.Rows(0)(12).ToString() = 3 Then
            CmbCalificacion.Enabled = True
            TxbRazon.Enabled = True
            TxbRazonReabrir.Enabled = True
            BtnEnviar.Enabled = True
            BtnNOSol.Enabled = True
        End If

        'Valido el estado, si esta entregado permite reabrir el caso o calificarlo
        If dtincidente.Rows(0)(12).ToString() = 3 Then
            BtnNOSol.Enabled = True
            CmbCalificacion.Enabled = True
            BtnEnviar.Enabled = True
            TxbRazon.Enabled = True
        Else
            BtnNOSol.Enabled = False
            CmbCalificacion.Enabled = False
            BtnEnviar.Enabled = False
            TxbRazon.Enabled = False
        End If

        cargar_comentarios()
    End Sub

    Private Sub Editar_usuario_req_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        carpeta_temp = funciones_generales.random
        Principal_usuario_req.Enabled = True
    End Sub


    Private Sub BtnNOSol_Click(sender As Object, e As EventArgs) Handles BtnNOSol.Click
        If TxbRazonReabrir.Text <> "" Then
            Try
                querys.reabrir_incidente(TxbRazonReabrir.Text, TxbNumero.Text)
                querys.reabrir_incidente_hist(TxbNumero.Text, TxbIdTecnico.Text, TxbRazonReabrir.Text)
                enviar_correo("4")
                MsgBox("Se reabrió el caso, se enviará automáticamente un correo electrónico al técnico para que revise nuevamente", MsgBoxStyle.Information)
                CmbCalificacion.Enabled = False
                TxbRazon.Enabled = False
                TxbRazonReabrir.Enabled = False
                BtnEnviar.Enabled = False
                BtnNOSol.Enabled = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Debe indicar el motivo por el cual se reabre el caso", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        If CmbCalificacion.Text <> "" And TxbRazon.Text <> "" Then
            Try
                querys.calificar_incidente(TxbRazon.Text, CmbCalificacion.SelectedItem.ToString(), TxbNumero.Text)
                enviar_correo("2")
                MsgBox("Se envió la calificación", MsgBoxStyle.Information)
                CmbCalificacion.Enabled = False
                TxbRazon.Enabled = False
                TxbRazonReabrir.Enabled = False
                BtnEnviar.Enabled = False
                BtnNOSol.Enabled = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MsgBox("se debe ingresar la calificación y la razón para poder continuar", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub LinkAdjuntos_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkAdjuntos.LinkClicked
        carpeta_temp = "inc_" & TxbNumero.Text
        adjuntar.ruta_adjunto = ruta_adjunto_incidente & carpeta_temp
        adjuntar.Show()
        Me.Enabled = False
    End Sub

    Private Sub LinkAprobacion_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkAprobacion.LinkClicked
        Me.Enabled = False
        ciclo_aprobacion.numero_incidente = TxbNumero.Text
        ciclo_aprobacion.Show()
    End Sub

    Private Sub enviar_correo(tipo As String)
        Dim fechamodificacion As Date = Date.Now
        fechamodificacion = fechamodificacion.ToString("dd/MM/yyyy")

        Dim dt_texto_correo, dtcorreo As New DataTable

        dtcorreo = querys.cons_usuario(TxbIdTecnico.Text)

        If tipo = 2 Then 'calificado'
            funciones_generales.envio_correo(dtcorreo.Rows(0)(6).ToString(), "Soporte Calificado: " & TxbNumero.Text, tipo, TxbIdUsuario.Text.ToString(), fechamodificacion, CmbCalificacion.Text.ToString(), TxbRazonReabrir.Text.ToString(), "", "", "", "")
        ElseIf tipo = 4 Then 'reabrir'
            funciones_generales.envio_correo(dtcorreo.Rows(0)(6).ToString(), "SOPORTE REABIERTO: " & TxbNumero.Text, tipo, TxbIdUsuario.Text.ToString(), fechamodificacion, CmbCalificacion.Text.ToString(), TxbRazonReabrir.Text.ToString(), "", "", "", "")
        ElseIf tipo = 7 Then 'comentario'
            funciones_generales.envio_correo(dtcorreo.Rows(0)(6).ToString(), "Se ingresó una nueva observación al soporte número: " & TxbNumero.Text, tipo, TxbNumero.Text, comentario, Date.Now.ToString("dd/MM/yyyy HH:mm"), "", "", "", "", "")
        End If

    End Sub


    Private Sub LinkComentarios_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkComentarios.LinkClicked
        Dim i As String = InputBox("INGRESE EL COMENTARIO", "")
        If i <> "" Then
            comentario = i
            querys.ingresar_observacion(TxbNumero.Text, i, TxbIdUsuario.Text)
            MsgBox("se ingresó correctamente el comentario")
            cargar_comentarios()
            enviar_correo(7)
        End If

    End Sub

    Sub cargar_comentarios()
        Dim dt As New DataTable
        dt = querys.consultar_observacion(TxbNumero.Text)
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
End Class