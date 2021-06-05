Public Class Usuarios
    Dim contraseña, desc_usuario, nivel As String
    Private ingreso As Boolean
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ingreso = True
        Dim dtusuario, dtnivel As New DataTable
        Dim consultas As New Querys_incidentes
        Usuario.Text = nombre
        Try
            dtusuario = consultas.cons_usuario("")
            dtnivel = consultas.cons_nivel("")

            CmbUsuario.DataSource = dtusuario
            CmbUsuario.DisplayMember = dtusuario.Columns(3).ToString()
            CmbUsuario.ValueMember = dtusuario.Columns(1).ToString()
            CmbUsuario.Text = ""

            CmbNivel.DataSource = dtnivel
            CmbNivel.DisplayMember = dtnivel.Columns(1).ToString()
            CmbNivel.ValueMember = dtnivel.Columns(0).ToString()
            CmbNivel.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ingreso = False
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs)
        Dim actualizar As New Querys_incidentes
    End Sub

    Private Sub Usuarios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Principal_tecnico_req.Enabled = True
    End Sub

    Private Sub CmbUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbUsuario.SelectedIndexChanged
        If ingreso = False Then
            limpiar()

            Dim dtusuario, dtnivel As New DataTable
            Dim consultas As New Querys_incidentes
            Try
                dtusuario = consultas.cons_usuario(CmbUsuario.SelectedValue.ToString())
                dtnivel = consultas.cons_nivel(dtusuario.Rows(0)(4).ToString())
                TxbUsuario.Text = dtusuario.Rows(0)(1).ToString()
                TxbContraseña.Text = dtusuario.Rows(0)(2).ToString()
                TxbNombre.Text = dtusuario.Rows(0)(3).ToString()
                TxbMail.Text = dtusuario.Rows(0)(6).ToString()
                CmbComp.Text = dtusuario.Rows(0)(7).ToString()
                CmbNivel.SelectedText = dtnivel.Rows(0)(1).ToString()
                If dtusuario.Rows(0)(8) = 0 Then
                    chkestado.Checked = False
                Else
                    chkestado.Checked = True
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub

    Sub limpiar()
        CmbUsuario.Text = ""
        TxbUsuario.Text = ""
        TxbContraseña.Text = ""
        TxbNombre.Text = ""
        TxbMail.Text = ""
        CmbNivel.Text = ""
        CmbComp.Text = ""
        chkestado.Checked = False
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim dtusuario As New DataTable
        Dim actualizar As New Querys_incidentes
        Dim confirmar, act, com As String

        dtusuario = actualizar.cons_usuario(TxbUsuario.Text)

        If chkestado.Checked = True Then
            act = 1
        Else
            act = 0
        End If

        If (CmbComp.SelectedIndex <= 0) Then
            com = ""
        Else
            com = CmbComp.SelectedItem
        End If

        If dtusuario.Rows.Count > 0 Then
            confirmar = MsgBox("Se actualizará el usuario: " + TxbNombre.Text, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo)
            If confirmar = 6 Then
                Try
                    dtusuario.Rows(0)(3) = TxbNombre.Text
                    dtusuario.Rows(0)(4) = CmbNivel.SelectedText
                    dtusuario.Rows(0)(6) = TxbMail.Text
                    dtusuario.Rows(0)(7) = CmbComp.Text
                    If chkestado.Checked = True Then
                        dtusuario.Rows(0)(8) = "1"
                    Else
                        dtusuario.Rows(0)(8) = "0"
                    End If

                    'actualizar.actualiza_usu(TxbUsuario.Text, TxbContraseña.Text, TxbNombre.Text, CmbNivel.SelectedValue.ToString(), TxbMail.Text, com, act)
                    actualizar.actualiza_usu(TxbUsuario.Text, dtusuario.Rows(0)(3).ToString, dtusuario.Rows(0)(4).ToString, dtusuario.Rows(0)(6).ToString, dtusuario.Rows(0)(7).ToString, dtusuario.Rows(0)(8).ToString)
                    MsgBox("Se actualizó correctamente el usuario", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                    limpiar()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            confirmar = MsgBox("Se creará un nuevo usuario: " + TxbContraseña.Text, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo)
            If confirmar = 6 Then
                If TxbUsuario.Text <> "" And TxbContraseña.Text <> "" And TxbNombre.Text <> "" And CmbNivel.Text <> "" Then
                    Try
                        actualizar.nuevo_usu(TxbUsuario.Text, TxbNombre.Text, TxbContraseña.Text, CmbNivel.SelectedValue.ToString(), TxbMail.Text, com, act)
                        MsgBox("Se insertó correctamente el usuario", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                        limpiar()
                        btnnuevo.Enabled = False
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    MsgBox("Se debe completar la información antes de poder ser grabada")
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        TxbUsuario.Enabled = True
        TxbContraseña.Enabled = True
        limpiar()
        TxbUsuario.Select()
    End Sub
    Private Sub volverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles volverToolStripMenuItem.Click
        Inicio.Show()
        Me.Close()
    End Sub

    Private Sub PermisosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermisosToolStripMenuItem.Click
        Permisos.Show()
        Me.Enabled = False
    End Sub

    Private Sub CmbNivel_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class