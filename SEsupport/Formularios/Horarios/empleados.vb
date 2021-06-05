Public Class empleados
    Private Sub empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dttipoarea As New DataTable
        Dim consultas As New Querys_horario

        dttipoarea = consultas.cons_tipo_area()
        cbxarea.DataSource = dttipoarea
        cbxarea.DisplayMember = dttipoarea.Columns(1).ToString()
        cbxarea.ValueMember = dttipoarea.Columns(0).ToString()
        cbxarea.Text = ""
    End Sub

    Private Sub txtcc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcc.KeyDown
        Dim dtempleado As New DataTable
        Dim consultas As New Querys_incidentes
        Dim reg As Int32
        If e.KeyCode = Keys.Enter Then
            Try
                If (txtcc.Text <> "") Then
                    dtempleado = consultas.cons_empleado(txtcc.Text)
                    reg = dtempleado.Rows.Count
                    If (reg > 0) Then
                        txtnombre.Text = dtempleado.Rows(0)(2).ToString()
                        txtapellido.Text = dtempleado.Rows(0)(3).ToString()
                        cbxarea.SelectedIndex = dtempleado.Rows(0)(4) - 1
                        If dtempleado.Rows(0)(5) = 0 Then
                            chkestado.Checked = False
                        Else
                            chkestado.Checked = True

                        End If
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtcc.Text = ""
        txtnombre.Text = ""
        txtapellido.Text = ""
        cbxarea.Text = ""
        chkestado.Checked = False
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

    End Sub
End Class