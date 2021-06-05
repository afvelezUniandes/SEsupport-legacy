Public Class Principal_usuario_req

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'cargamos los pendientes
        pendientes()

        'cargamos los combobox
        If nivel < 2 Then
            Me.UsuarioTableAdapter.FillByUsuario(Me.DsConsultas.Usuario, nombre)
        Else
            Me.UsuarioTableAdapter.Fill(Me.DsConsultas.Usuario)
        End If
        Me.Tipo_reqTableAdapter.Fill(Me.DsConsultas.tipo_req)
        Me.ModuloTableAdapter.FillbyModulo(Me.DsConsultas.Modulo)
        Me.PrioridadTableAdapter.FillbyPrioridad(Me.DsConsultas.Prioridad)
        Me.EstadoTableAdapter.Fill(Me.DsConsultas.Estado)
        ToolStripStatusLabel2.Text = nombre

        'inicializamos los combobox en ""
        limpiar()

        'deshabilitamos que se pueda cambiar le usuario 
        If nivel < 2 Then
            CmbUsuario.Enabled = False
        Else
            CmbUsuario.Text = ""
        End If

        'cargamos los pendientes que se tengan

    End Sub


    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Me.Enabled = False
        Usuarios.Show()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If CmbModulo.Text <> "" And CmbPrioridad.Text <> "" And Cmbtipo.Text <> "" And CmbUsuario.Text <> "" And TxbDescripcion.Text <> "" Then
            Dim nuevo_req As New Querys
            Try
                With nuevo_req
                    .usuario = CmbUsuario.SelectedValue.ToString()
                    .idmodulo = CmbModulo.SelectedValue.ToString()
                    .idprioridad = CmbPrioridad.SelectedValue.ToString()
                    .idestado = 1
                    .idtipo = Cmbtipo.SelectedValue.ToString()
                    .descripcion = Replace(TxbDescripcion.Text, "'", "{")

                    .nuevo_incidente()
                End With

                pendientes()
                MsgBox("Enviado correctamente", MsgBoxStyle.Information)
                limpiar()
            Catch ex As Exception
                MsgBox("Error al enviar, intente nuevamente", MsgBoxStyle.Critical)
            End Try
        Else
            MsgBox("Debe completar toda la información para poder generar el requerimiento", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub pendientes()
        Me.Vw_hist_inc_reqTableAdapter.FillByUsuario(Me.DsConsultas.vw_hist_inc_req, nombre)
    End Sub

    Private Sub limpiar()
        CmbModulo.Text = ""
        CmbPrioridad.Text = ""
        Cmbtipo.Text = ""
        TxbDescripcion.Text = ""
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        limpiar()
    End Sub


    Private Sub DgvPendientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPendientes.CellDoubleClick
        If e.RowIndex >= 0 Then
            Editar_usuario_req.num_soporte = Me.DgvPendientes(0, e.RowIndex).Value.ToString()
            Editar_usuario_req.Show()
            Me.Enabled = False
        End If
    End Sub


    Private Sub CmbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEstado.SelectedIndexChanged
        Try
            Me.Vw_hist_inc_reqTableAdapter.FillByusuario_estado(Me.DsConsultas.vw_hist_inc_req, nombre, CmbEstado.SelectedValue.ToString())
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub TecnicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TecnicoToolStripMenuItem.Click
        Principal_tecnico_req.Show()
        Me.Close()
    End Sub
End Class
