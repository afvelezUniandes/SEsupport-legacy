Public Class cambio_contraseña
    Dim passact As String
    Dim idusu As Int32
    Private ingreso As Boolean
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim dtconsulta As New DataTable
        Dim consultas As New Funciones_generales

        Try
            dtconsulta = consultas.cons_datosusuario(idusu)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If TxbContraseñaAnt.Text <> "" And TxbContraseñaNueva.Text <> "" And TxbRcontraseñaNueva.Text <> "" Then
            If TxbContraseñaAnt.Text <> dtconsulta.Rows(0)(0).ToString() Then
                'If (TxbContraseñaAnt.Text <> passact) Then 'passact: es la contraseña anterior
                MsgBox("La contraseña actual no es valida, intente nuevamente", MsgBoxStyle.Critical)
            Else
                If TxbContraseñaNueva.Text <> TxbRcontraseñaNueva.Text Then
                    MsgBox("La contraseña nueva y la confirmación no corresponden", MsgBoxStyle.Critical)
                Else
                    Try
                        consultas.cambiar_contraseña(idusu, TxbContraseñaNueva.Text)
                        MsgBox("Contraseña cambiada correctamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
        Else
            MsgBox("Se deben diligenciar todos los campos", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub cambio_contraseña_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Inicio.Enabled = True
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub cambio_contraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ingreso = True
        Dim dtusuario As New DataTable
        Dim consultas As New Querys_incidentes
        Try
            dtusuario = consultas.cons_usuario("")
            CmbUsuario.DataSource = dtusuario
            CmbUsuario.DisplayMember = dtusuario.Columns(3).ToString()
            CmbUsuario.ValueMember = dtusuario.Columns(1).ToString()
            CmbUsuario.Text = ""
            CmbUsuario.Select()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ingreso = False
    End Sub

    Private Sub CmbUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbUsuario.SelectedIndexChanged
        If ingreso = False Then
            limpiar()
            Dim dtusuario As New DataTable
            Dim consultas As New Querys_incidentes
            Try
                dtusuario = consultas.cons_usuario(CmbUsuario.SelectedValue.ToString())
                If (dtusuario Is Nothing) Then
                    idusu = 0
                End If
                idusu = dtusuario.Rows(0)(0).ToString()
                passact = dtusuario.Rows(0)(2).ToString()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Sub limpiar()
        CmbUsuario.Text = ""
        TxbContraseñaAnt.Text = ""
        TxbContraseñaNueva.Text = ""
        TxbRcontraseñaNueva.Text = ""
    End Sub

End Class