Public Class kardex_agotados

    Dim cons As New Querys_agotados

    Private Sub GbBuscar_Enter(sender As Object, e As EventArgs) Handles GbBuscar.Enter
        Me.AcceptButton = BtnBuscar
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        DgvKardex.DataSource = Nothing
        Dim consulta As New DataTable
        If RbNombre.Checked = True Then
            consulta = cons.consultar_kardex("", TxbBuscar.Text.ToString(), factu)
        Else
            consulta = cons.consultar_kardex(TxbBuscar.Text.ToString(), "", factu)
        End If
        DgvKardex.DataSource = consulta
    End Sub

    Private Sub DgvKardex_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvKardex.CellContentClick
        If e.ColumnIndex = 0 Then
            Dim fila As String = Agotados.DgvAgotados.CurrentRow.Index - 1
            Agotados.DgvAgotados.Rows(fila).Cells("Referencia").Value = DgvKardex.CurrentRow.Cells("referencia").Value
            Me.Close()
        End If
    End Sub

    Private Sub kardex_agotados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxbBuscar.Focus()
        'Try
        'Dim consulta As New DataTable
        'consulta = cons.consultar_kardex("", "", factu)
        'DgvKardex.DataSource = consulta
        'Catch ' ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        TxbBuscar.Focus()
        TxbBuscar.Select()
    End Sub
End Class