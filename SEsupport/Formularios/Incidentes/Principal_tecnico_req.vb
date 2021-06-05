Public Class Principal_tecnico_req

    Private Sub Principal_tecnico_req_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim consulta As New Querys_incidentes
        Dim dtconsulta, dtestados As New DataTable

        Usuario.Text = nombre

        dtconsulta = consulta.cons_pendientes_estado(1)
        dtestados = consulta.cons_estado("")

        CmbEstado.DataSource = dtestados
        CmbEstado.DisplayMember = dtestados.Columns(1).ToString()
        CmbEstado.ValueMember = dtestados.Columns(0).ToString()

        DgvHistorico.DataSource = dtconsulta
        CmbEstado.Text = ""
    End Sub

    Private Sub CmbFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEstado.SelectedIndexChanged
        actualizar_pantalla()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvHistorico.CellDoubleClick
        If e.RowIndex >= 0 Then
            Editar_tecnico_req.num_soporte = Me.DgvHistorico(1, e.RowIndex).Value.ToString()
            Editar_tecnico_req.Show()
            Me.Enabled = False
        End If
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Me.Enabled = False
        Usuarios.Show()
    End Sub

    Private Sub Principal_tecnico_req_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.F9 Then
            actualizar_pantalla()
        End If
    End Sub

    Sub actualizar_pantalla()
        Dim consulta As New Querys_incidentes
        Dim dtconsulta As New DataTable

        DgvHistorico.DataSource = Nothing

        dtconsulta = consulta.cons_pendientes_estado(CmbEstado.SelectedValue.ToString())
        DgvHistorico.DataSource = dtconsulta
    End Sub

    Private Sub NuevoRequerimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoRequerimientoToolStripMenuItem.Click
        Principal_usuario_req.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Inicio.Show()
        Me.Close()
    End Sub

    Private Sub Usuario_Click(sender As Object, e As EventArgs) Handles Usuario.Click
        Dim out As Integer = MsgBox("¿Desea cerrar su sesión y salir?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation)
        If (out = 6) Then
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        actualizar_pantalla()
    End Sub
End Class