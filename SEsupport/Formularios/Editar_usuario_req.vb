Public Class Editar_usuario_req

    Public num_soporte As String

    Private Sub Editar_usuario_req_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Vw_hist_inc_reqTableAdapter.FillByUsuario_numero(Me.DsConsultas.vw_hist_inc_req, nombre, num_soporte)
        cargar_datos()

        If Me.DsConsultas.vw_hist_inc_req.Rows(0)(8).ToString() = 3 Then
            CmbCalificacion.Enabled = True
            BtnEnviar.Enabled = True
            TxbRazon.Enabled = True
        End If

        'Valido el estado, si esta entregado permite reabrir el caso
        If Me.DsConsultas.vw_hist_inc_req.Rows(0)(7) = 3 Then
            BtnNOSol.Enabled = True
        Else
            BtnNOSol.Enabled = False
        End If

        CmbCalificacion.Text = ""

    End Sub

    Private Sub Editar_usuario_req_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Principal_usuario_req.Enabled = True
    End Sub

    Private Sub cargar_datos()
        TxbNumero.Text = num_soporte
        TxbUsuario.Text = Me.DsConsultas.vw_hist_inc_req.Rows(0)(2).ToString()
        TxbEstado.Text = Me.DsConsultas.vw_hist_inc_req.Rows(0)(8).ToString()
        TxbDescripcion.Text = Me.DsConsultas.vw_hist_inc_req.Rows(0)(11).ToString()
        MskFechaReq.Text = Me.DsConsultas.vw_hist_inc_req.Rows(0)(12).ToString()
        MskFechaEntrega.Text = Me.DsConsultas.vw_hist_inc_req.Rows(0)(13).ToString()
        MskFechaPac.Text = Me.DsConsultas.vw_hist_inc_req.Rows(0)(14).ToString()
        TxbResponsable.Text = Me.DsConsultas.vw_hist_inc_req.Rows(0)(16).ToString()
        CmbCalificacion.Text = Me.DsConsultas.vw_hist_inc_req.Rows(0)(17).ToString()
        TxbRazon.Text = Me.DsConsultas.vw_hist_inc_req.Rows(0)(18).ToString()
        TxbObservaciones.Text = Me.DsConsultas.vw_hist_inc_req.Rows(0)(19).ToString()
    End Sub

    Private Sub BtnNOSol_Click(sender As Object, e As EventArgs) Handles BtnNOSol.Click
        If TxbRazonReabrir.Text <> "" Then
            Dim querys As New Querys
            With querys
                .idhist = TxbNumero.Text
                .descripcion = TxbRazonReabrir.Text
                .reabrir_incidente()
            End With
            MsgBox("Se reabrió el caso, se enviará automáticamente un correo electrónico al técnico para que revise nuevamente", MsgBoxStyle.Information)
        Else
            MsgBox("Debe indicar el motivo por el cual se reabre el caso", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        If CmbCalificacion.Text <> "" And TxbRazon.Text <> "" Then
            Dim querys As New Querys
            With querys
                .idhist = TxbNumero.Text
                .descripcion = TxbRazon.Text
                .calificacion = CmbCalificacion.SelectedValue
                .calificar_incidente()
            End With
            MsgBox("Se envió la calificación", MsgBoxStyle.Information)
        Else
            MsgBox("se debe ingresar la calificación y la razón para poder continuar", MsgBoxStyle.Critical)
        End If
    End Sub
End Class