Public Class seleccion_turno_horario
    Public carga_inicial As Boolean
    Public row, column As Integer
    Private Sub cmbturno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbturno.SelectedIndexChanged
        Try
            If carga_inicial = False Then
                Dim textoaux As String = cmbturno.Text.ToString()

                txbhorainicio.Text = textoaux.Substring(textoaux.IndexOf("-") + 2, 5)
                txbhorafin.Text = textoaux.Substring(textoaux.LastIndexOf("-") + 2, 5)

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub seleccion_turno_horario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        txbhorafin.Text = ""
        txbhorainicio.Text = ""
    End Sub

    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click
        Dim aux As String = cmbturno.Text.ToString()
        Crear_horario.DgvHorario.Rows(row).Cells(column).Value = Trim(aux.Substring(0, aux.IndexOf("-") - 1)) & " - " & txbhorainicio.Text & " - " & txbhorafin.Text
        Me.Close()
    End Sub
End Class