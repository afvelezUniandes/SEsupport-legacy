Public Class Inicio_pos_admin

    Dim consultas As New Querys_pos_administrativo
    Private Sub Inicio_pos_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblCargando.Visible = False
        Dim dt_pos As New DataTable

        dt_pos = consultas.consultar_pos()
        Dim total_rows As Integer = dt_pos.Rows.Count

        For i = 0 To total_rows - 1
            DgvPos.Rows.Add()
            Dim ultimo As Integer = DgvPos.Rows.Count - 1
            DgvPos.Rows(ultimo).Cells(1).Value = (dt_pos.Rows(i)(0).ToString()).ToUpper
            DgvPos.Rows(ultimo).Cells(2).Value = (dt_pos.Rows(i)(1).ToString()).ToUpper
        Next
    End Sub

    Private Sub DgvPos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPos.CellContentClick
        If e.ColumnIndex = 0 Then
            LblCargando.Text = "VERIFICANDO CONEXION CON EL PUNTO DE VENTA... POR FAVOR ESPERE"
            LblCargando.Visible = True
            Me.Refresh()
            Application.DoEvents()
            conexion_pos = DgvPos.Rows(e.RowIndex).Cells(2).Value.ToString()
            Dim respuesta As Boolean = consultas.probar_conexion(conexion_pos)
            If respuesta = True Then
                LblCargando.Text = "CARGANDO EL POS... POR FAVOR ESPERE"
                Me.Refresh()
                Application.DoEvents()
                Pos_Administrativo.Show()
                Me.Close()
            Else
                MsgBox("No se estableció conexión con el punto de Venta.  Intente nuevamente mas tarde.  En caso de persistir el problema comunicarse con el área de sistemas", MsgBoxStyle.Critical)
                LblCargando.Visible = False
            End If
        End If
    End Sub
End Class