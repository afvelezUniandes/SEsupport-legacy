Public Class Agotados

    Dim ingreso As Boolean = True
    Private pastse, mes As String
    Dim consulta_referencia As Boolean = False
    Dim consulta_bd As New Querys_agotados

    Private Sub Agotados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

       Dim dtconsulta As New DataTable
        dtconsulta = consulta_bd.consultar_usu_bodega(nombre, factu)

        CmbBodega.DataSource = dtconsulta
        CmbBodega.ValueMember = "bodega"
        CmbBodega.DisplayMember = "nombre2"
        CmbBodega.Text = ""
        ingreso = False
    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        DgvAgotados.Enabled = True
        consultar_fecha()
        Dim fecha_actual As String = Date.Now.ToString("yyyyMMdd")
        Dim fecha_consultada As String = DtpFechaAgotados.Value.ToString("yyyyMMdd")
        If fecha_actual - fecha_consultada > 1 Then
            DgvAgotados.Enabled = False
        End If
    End Sub
    Sub consultar_fecha()
        Dim dtconsulta As New DataTable
        dtconsulta = consulta_bd.consultar_agotados(factu, DtpFechaAgotados.Value.ToString("yyyyMMdd"), CmbBodega.SelectedValue.ToString())
        DgvAgotados.DataSource = dtconsulta
    End Sub

    Private Sub DgvAgotados_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvAgotados.CellValueChanged
        If consulta_referencia = False And ingreso = False And e.ColumnIndex = 1 Then
            Try
                Dim referencia As String = DgvAgotados.Rows(e.RowIndex).Cells("Referencia").Value.ToString()
                If e.ColumnIndex = 1 Then
                    If referencia = "+" Then
                        kardex_agotados.Show()
                        Return
                    Else
                        Dim consulta As New DataTable
                        consulta = consulta_bd.consultar_kardex(referencia, "", factu)
                        If consulta.Rows.Count > 0 Then
                            DgvAgotados.Rows(e.RowIndex).Cells("Descripcion").Value = consulta.Rows(0)("nombre_producto")
                            DgvAgotados.Rows(e.RowIndex).Cells("Bodega").Value = CmbBodega.SelectedValue.ToString()
                            DgvAgotados.Rows(e.RowIndex).Cells("Fecha").Value = DtpFechaAgotados.Value.ToString("dd/MM/yyyy")
                        Else
                            MsgBox("NO EXISTE LA REFERENCIA INGRESADA", MsgBoxStyle.Critical)
                            DgvAgotados.Rows(e.RowIndex).Cells("Referencia").Value = ""
                            DgvAgotados.Rows(e.RowIndex).Cells("Descripcion").Value = ""
                            DgvAgotados.Rows(e.RowIndex).Cells("Observaciones").Value = ""
                            DgvAgotados.Rows(e.RowIndex).Cells("Fecha").Value = ""
                        End If
                    End If
                End If
            Catch ex As Exception
                MsgBox("ERROR AL INGRESAR LA REFERENCIA, EL ERROR MOSTRADO ES EL SIGUIENTE: " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If verificar_datos() = True Then
            Dim fecha As Date = DtpFechaAgotados.Value
            Dim bodega As String = CmbBodega.SelectedValue.ToString()
            consulta_bd.borrar_agotados("", fecha.ToString("yyyyMMdd"), bodega, factu)
            For i = 0 To DgvAgotados.Rows.Count - 1
                Dim referencia As String = DgvAgotados.Rows(i).Cells("Referencia").Value
                Dim observaciones As String = DgvAgotados.Rows(i).Cells("Observaciones").Value
                Dim descripcion As String = DgvAgotados.Rows(i).Cells("Descripcion").Value

                If referencia <> "" Then
                    consulta_bd.ingresar_agotados(referencia, descripcion, bodega, observaciones, fecha.ToString("yyyyMMdd"), factu)
                End If
            Next
        Else
            MsgBox("El campo OBSERVACIONES es obligatorio. Complete los datos e intente nuevamente", MsgBoxStyle.Critical)
        End If
    End Sub

    Function verificar_datos() As Boolean
        For i = 0 To DgvAgotados.Rows.Count - 2
            If DgvAgotados.Rows(i).Cells("Observaciones").Value.ToString() = "" Or IsNothing(DgvAgotados.Rows(i).Cells("Observaciones").Value) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub DgvAgotados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvAgotados.CellContentClick
        If e.ColumnIndex = 0 Then
            Dim i As Integer = MsgBox("Este proceso no se puede reversar, desea continuar?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo)
            If i = 6 Then
                DgvAgotados.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        consultar_fecha()
    End Sub


    Private Sub VolverAlInicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAlInicioToolStripMenuItem.Click
        Inicio.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub DtpFechaAgotados_ValueChanged(sender As Object, e As EventArgs) Handles DtpFechaAgotados.ValueChanged

    End Sub

    Private Sub CmbBodega_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBodega.SelectedIndexChanged
        
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class