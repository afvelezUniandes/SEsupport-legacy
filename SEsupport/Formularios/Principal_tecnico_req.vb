Public Class Principal_tecnico_req

    Private Sub Principal_tecnico_req_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Vw_hist_inc_reqTableAdapter.FillByusuario_estado(Me.DsConsultas.vw_hist_inc_req, nombre, 1)

        Me.ReferenciasTableAdapter.FillByIdReferencia(Me.DsConsultas.Referencias, "Filtro")
        CmbFiltro.Text = ""


    End Sub

    Private Sub CmbFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbFiltro.SelectedIndexChanged
        Me.ReferenciasTableAdapter.FillByIdReferencia(Me.DsConsultas.Referencias, "Filtro")
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvHistorico.CellDoubleClick
        If e.RowIndex >= 0 Then
            Editar_tecnico_req.num_soporte = Me.DgvHistorico(0, e.RowIndex).Value.ToString()
            Editar_tecnico_req.Show()
            Me.Enabled = False
        End If
    End Sub
End Class