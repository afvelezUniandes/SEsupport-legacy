Public Class Editar_tecnico_req

    Public num_soporte As String
    Private Sub Editar_tecnico_req_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tipo_reqTableAdapter.Fill(Me.DsConsultas1.tipo_req)
        Me.TecnicoTableAdapter.Fill(Me.DsConsultas1.Tecnico)
        Me.Vw_hist_inc_reqTableAdapter.FillByUsuario_numero(Me.DsConsultas.vw_hist_inc_req, nombre, num_soporte)
        Me.UsuarioTableAdapter.Fill(Me.DsConsultas.Usuario)

        cargar_datos()
    End Sub

    Private Sub cargar_datos()
        TxbNumero.Text = num_soporte
        CmbUsuario.Text = Me.DsConsultas.vw_hist_inc_req.Rows(0)(2).ToString()
        TxbEstado.Text = Me.DsConsultas.vw_hist_inc_req.Rows(0)(8).ToString()
        TxbDescripcion.Text = Me.DsConsultas.vw_hist_inc_req.Rows(0)(11).ToString()
        MskFechaReq.Text = Me.DsConsultas.vw_hist_inc_req.Rows(0)(12).ToString()
        MskFechaEntrega.Text = Me.DsConsultas.vw_hist_inc_req.Rows(0)(13).ToString()
        DTPFechaPactada.Text = Me.DsConsultas.vw_hist_inc_req.Rows(0)(14).ToString()
        CmbTipo.Text = Me.DsConsultas.vw_hist_inc_req.Rows(0)(10).ToString()
        CmbResponsable.Text = Me.DsConsultas.vw_hist_inc_req.Rows(0)(16).ToString()
        TxbCalificacion.Text = Me.DsConsultas.vw_hist_inc_req.Rows(0)(17).ToString()
        TxbRazon.Text = Me.DsConsultas.vw_hist_inc_req.Rows(0)(18).ToString()
        TxbObservaciones.Text = Me.DsConsultas.vw_hist_inc_req.Rows(0)(19).ToString()
    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click

    End Sub
End Class