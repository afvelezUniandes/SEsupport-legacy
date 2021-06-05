Public Class Proveedores
    Dim funciones As New Funciones_generales
    Dim dtbanco As New DataTable
    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Usuario.Text = nombre
        Try
            dtbanco.Rows.InsertAt(dtbanco.NewRow(), 0)
            dtbanco = funciones.cons_banco("")
            cbxcban.DataSource = dtbanco
            cbxcban.DisplayMember = dtbanco.Columns(1).ToString()
            cbxcban.ValueMember = dtbanco.Columns(0).ToString()
            cbxcban.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtnitben_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnit.KeyPress
        Dim funciones_generales As New Funciones_generales
        Dim dtcliente As New DataTable
        Dim nit, d As String
        If (Asc(e.KeyChar) = 13) Then
            If (txtnit.Text = "") Then
                Label8.ForeColor = Color.Red
            Else
                Label8.ForeColor = Color.Black
                nit = txtnit.Text
                dtcliente = funciones_generales.cons_proveedor(nit)
                If dtcliente IsNot Nothing Then
                    If dtcliente.Rows.Count > 0 Then
                        d = txtnit.Text.Substring(Len(txtnit.Text) - 2)
                        txtrazon.Text = dtcliente.Rows(0)(0).ToString()
                        txtemail.Text = dtcliente.Rows(0)(1).ToString()
                        txtnomban.Text = dtcliente.Rows(0)(4).ToString
                        txtnocta.Text = dtcliente.Rows(0)(5).ToString()
                        cbxtcta.Text = dtcliente.Rows(0)(6).ToString()
                    End If
                End If
            End If
        End If
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "-" And Not txtnit.Text.IndexOf("-") Then
            e.Handled = True
        ElseIf e.KeyChar = "-" Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Solo se permite ingresar números y dígito de verificación", "Validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub




End Class