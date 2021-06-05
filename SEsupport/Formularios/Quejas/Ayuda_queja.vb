Public Class Ayuda_queja


    Private Sub Ayuda_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Principal_usuario_queja.Enabled = True
    End Sub
End Class