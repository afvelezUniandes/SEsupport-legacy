Public Class Permisos
    Dim consultas As New Querys_incidentes
    Private ingreso As Boolean = False

    Private Sub Permisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim consulta As New Querys_inventarios
        Dim dtusu, dttus As New DataTable
        Usuario.Text = nombre
        If nivel = 2 Then
            Try
                dtusu = consultas.cons_usuario("")
                dttus = consultas.cons_nivel("")

                CmbUsuario.DataSource = dtusu
                CmbUsuario.DisplayMember = dtusu.Columns(3).ToString()
                CmbUsuario.ValueMember = dtusu.Columns(1).ToString()
                CmbUsuario.Text = ""

                Cmbtus.DataSource = dttus
                Cmbtus.DisplayMember = dttus.Columns(1).ToString()
                Cmbtus.ValueMember = dttus.Columns(0).ToString()
                Cmbtus.Text = ""

                cargaracceso()
                CmbUsuario.Focus()
                ingreso = True
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("No Cuenta con los permisos para realizar estos cambios", MsgBoxStyle.Information)
        End If
        ingreso = False
    End Sub

    Sub cargaracceso()
        Dim dtacceso As New DataTable
        dtacceso = consultas.cons_accesos("")
        Dim valido As New DataGridViewCheckBoxColumn()
        valido.Width = 50
        valido.HeaderText = ""
        Dim titulo As New DataGridViewTextBoxColumn()
        titulo.Width = 180
        titulo.HeaderText = "Formulario"
        Dim codigo As New DataGridViewTextBoxColumn()
        codigo.HeaderText = "ID"
        'codigo.Visible = False
        dtpermisos.Columns.Add(valido)
        dtpermisos.Columns.Add(titulo)
        dtpermisos.Columns.Add(codigo)
        For Each sg As DataRow In dtacceso.Rows
            Dim id, enc As String
            id = CStr(sg("idacceso"))
            enc = CStr(sg("desc_acceso"))
            'titulo.Name = enc
            dtpermisos.Rows.Add(False, enc, id)
        Next
        dtpermisos.AllowUserToAddRows = False
    End Sub

    Private Sub volverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles volverToolStripMenuItem.Click
        Inicio.Show()
        Me.Close()
    End Sub

    Sub limpiar()
        For i = 0 To dtpermisos.Rows.Count - 1
            dtpermisos.Rows.Item(i).Cells(0).Value = False
        Next
    End Sub

    Private Sub CmbUsuario_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles CmbUsuario.MouseDoubleClick
        MsgBox("seleccionaste algo", MsgBoxStyle.Information)
    End Sub

    Private Sub CmbUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbUsuario.SelectedIndexChanged
        limpiar()
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Cmbtus_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles Cmbtus.SelectedIndexChanged
        Dim dtperm, dttus As New DataTable
        Dim f, i As Integer
        If ingreso = False Then
            limpiar()
            Dim us, idp As String
            Dim tp As Int32
            Try
                If (CmbUsuario.Items.Count <> 0) Then
                    f = CmbUsuario.SelectedIndex().ToString()
                    If (f > 0) Then
                        us = CmbUsuario.SelectedValue.ToString()
                        tp = Cmbtus.SelectedIndex
                        If (tp.ToString.Equals("") Or tp <= 0) Then
                            MsgBox("Seleccione un tipo de usuario", MsgBoxStyle.Exclamation)
                        Else
                            i = 0
                            dtperm = consultas.cons_perming(us, tp)
                            For Each pf As DataRow In dtperm.Rows
                                idp = CStr(pf("idacceso")) 'idacceso de cada usuario

                                For i = 0 To dtpermisos.Rows.Count - 1
                                    If (idp = dtpermisos.Rows.Item(i).Cells(2).Value) Then
                                        dtpermisos.Rows.Item(i).Cells(0).Value = True
                                    End If
                                Next
                            Next
                        End If
                    End If
                Else
                    MsgBox("No se pudieron cargar los permisos asociados al usuario", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class