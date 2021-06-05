Imports iTextSharp.text.pdf

Public Class Codigos
    Dim consulta_bd As New Querys_agotados
    Dim copias As Integer
    Private Sub btngenerar_Click_1(sender As Object, e As EventArgs) Handles btngenerar.Click
        Dim bcode As New Barcode128
        bcode.BarHeight = 60
        bcode.Code = txtean.Text
        bcode.GenerateChecksum = True
        bcode.CodeType = Barcode.CODE128
        Try
            Dim bm As New Bitmap(bcode.CreateDrawingImage(Color.Black, Color.White))
            Dim img As Image
            img = New Bitmap(bm.Width, bm.Height)
            Dim g As Graphics = Graphics.FromImage(img)
            g.FillRectangle(New SolidBrush(Color.White), 0, 0, bm.Width, bm.Height)
            g.DrawImage(bm, 0, 0)
            pbxbarras.Image = img
        Catch ex As Exception
            MsgBox("No se pudo crear el codigo de barras")
        End Try
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(pbxbarras.Width, pbxbarras.Height)

        If (copias = 1) Then
            pbxbarras.DrawToBitmap(bm, New Rectangle(5, 5, bm.Width, bm.Height))
            e.Graphics.DrawImage(bm, 5, 5) 'imprime imagen
        Else
            Dim x, y, ev, c As Integer
            y = 5
            ev = 15
            c = 0
            For rc As Integer = 1 To copias
                If (c = 0) Then
                    c = 1
                    x = 5
                    pbxbarras.DrawToBitmap(bm, New Rectangle(5, 5, bm.Width, bm.Height))
                    e.Graphics.DrawImage(bm, x * c, y)
                Else
                    x = pbxbarras.Width
                    pbxbarras.DrawToBitmap(bm, New Rectangle(5, 5, bm.Width, bm.Height))
                    e.Graphics.DrawImage(bm, x * c + ev, y) 'imprime imagen
                    c = c + 1
                    ev = ev + 10
                End If
            Next
        End If
    End Sub

    Private Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click
        Dim pr As Integer = MsgBox("Se van a imprimir las siguientes etiquetas. Asegurese de colocar el papel adecuado en la impresora. ¿Esta seguro de continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation)
        copias = 10
        If (pr = 6) Then
            PrintPreviewDialog1.Show() 'muestra la vista previa de impresion
        End If
    End Sub

    Private Sub txtean_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtean.KeyPress
        If (txtean.TextLength <= 13) Then
            If (Char.IsNumber(e.KeyChar)) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Codigos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Usuario.Text = nombre

        txtean.MaxLength = 13
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Inicio.Show()
        Me.Close()
    End Sub

    Private Sub txtreferencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtreferencia.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim dtproducto As New DataTable
            If (txtreferencia.Text <> "") Then
                dtproducto = consulta_bd.consultar_producto(txtreferencia.Text)
            Else
                txtreferencia.Focus()
            End If
            For Each row As DataRow In dtproducto.Rows
                txtdescripcion.Text = row.Item(1)
                txtean.Text = row.Item(2)
            Next
        End If
    End Sub
End Class