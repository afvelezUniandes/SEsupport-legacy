Public Class Inicio

    Private Sub BtnIncidentes_Click(sender As Object, e As EventArgs) Handles BtnIncidentes.Click
        If (nivel = 2) Then
            Principal_tecnico_req.Show()
            Me.Close()
        Else
            Principal_usuario_req.Show()
            Me.Close()
        End If
    End Sub

    Private Sub BtnQuejas_Click(sender As Object, e As EventArgs) Handles BtnQuejas.Click
        Principal_usuario_queja.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub BtnInventario_Click(sender As Object, e As EventArgs) Handles BtnInventario.Click
        Dim consultas As New Funciones_generales
        Dim dtpermiso As New DataTable
        Dim nvp As Integer
        If (nivel = 6) Then
            Ingreso_inventarios.Show()
            Me.Close()
        Else
            dtpermiso = consultas.cons_permisos(user, "4")
            For Each row As DataRow In dtpermiso.Rows
                nvp = row(2).ToString
                If nvp = 2 Or nvp = 3 Or nvp = 4 Then
                    Ajuste_inventarios.Show()
                    Me.Close()
                Else
                    Ingreso_inventarios.Show()
                    Me.Close()
                End If
            Next
        End If
    End Sub

    Sub bloqueos()
        'cuando se cree un nuevo boton se debe colocar en visible = false
        ADMINGENERALToolStripMenuItem.Visible = False
        POSAdministrativoToolStripMenuItem.Visible = False
        HorariosToolStripMenuItem.Visible = False
        BtnIncidentes.Visible = False
        BtnInventario.Visible = False
        BtnQuejas.Visible = False
        Btncodean.Visible = False
        ContabilidadToolStripMenuItem.Visible = False
        SincronizadorToolStripMenuItem.Visible = False
        UsuariosToolStripMenuItem.Visible = False
        PERMISOSToolStripMenuItem.Visible = False
        PagosToolStripMenuItem.Visible = False
        AgotadosposToolStripMenuItem.Visible = False
    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bloqueos() 'bloquea los menus y botones del inicio
        Dim consultas As New Funciones_generales
        Dim dtpermiso, dtper As New DataTable
        Dim nvp As Integer
        dtpermiso = consultas.cons_permisos(user, "")

        For Each row As DataRow In dtpermiso.Rows
            If "AdministraciónToolStripMenuItem" = row(4).ToString Then
                AdministraciónToolStripMenuItem.Visible = True
            End If

            If "BtnIncidentes" = row(4).ToString Then
                BtnIncidentes.Visible = True
            End If

            If "BtnQuejas" = row(4).ToString Then
                BtnQuejas.Visible = True
            End If

            If "BtnInventario" = row(4).ToString Then
                BtnInventario.Visible = True
            End If

            If "AgotadosposToolStripMenuItem" = row(4).ToString Then
                AgotadosposToolStripMenuItem.Visible = True
            End If

            If "POSAdministrativoToolStripMenuItem" = row(4).ToString Then
                POSAdministrativoToolStripMenuItem.Visible = True
            End If

            If "HorariosToolStripMenuItem" = row(4).ToString Then
                HorariosToolStripMenuItem.Visible = True
            End If

            If "Btncodean" = row(4).ToString Then
                Btncodean.Visible = True
            End If

            If "SincronizadorToolStripMenuItem" = row(4).ToString Then
                SincronizadorToolStripMenuItem.Visible = True
            End If

            If "ADMINGENERALToolStripMenuItem" = row(4).ToString Then
                ADMINGENERALToolStripMenuItem.Visible = True
            End If

            If "UsuariosToolStripMenuItem" = row(4).ToString Then
                UsuariosToolStripMenuItem.Visible = True
            End If

            If "PERMISOSToolStripMenuItem" = row(4).ToString Then
                PERMISOSToolStripMenuItem.Visible = True
            End If

            dtper = consultas.cons_permisos(user, "8")
            For Each i As DataRow In dtper.Rows
                nvp = i(2).ToString
                If nvp = 5 Then
                    If "ContabilidadToolStripMenuItem" = i(4).ToString Then
                        ContabilidadToolStripMenuItem.Visible = True
                    End If
                End If
            Next

            dtper = consultas.cons_permisos(user, "9")
            For Each i As DataRow In dtper.Rows
                nvp = i(2).ToString
                If nvp = 5 Then
                    If "PagosToolStripMenuItem" = i(4).ToString Then
                        PagosToolStripMenuItem.Visible = True
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub CrearHorarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearHorarioToolStripMenuItem.Click
        Crear_horario.Show()
    End Sub

    Private Sub CalendarioFestivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalendarioFestivosToolStripMenuItem.Click
        calendario_festivos.Show()
    End Sub

    Private Sub TurnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TurnosToolStripMenuItem.Click
        turnos.Show()
    End Sub

    Private Sub BtnAgotadosPOS_Click(sender As Object, e As EventArgs) Handles Btncodean.Click
        Codigos.Show()
        Me.Close()
    End Sub
    Private Sub PERMISOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PERMISOSToolStripMenuItem.Click
        Permisos.Show()
    End Sub
    Private Sub CambiarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarUsuarioToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub
    Private Sub CambiarContraseñaToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        cambio_contraseña.Show()
        Me.Enabled = False
    End Sub
    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click
        Usuarios.Show()
        Me.Close()
    End Sub
    Private Sub PagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosToolStripMenuItem.Click
        Pagos_provee.Show()
        Me.Close()
    End Sub
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        cambio_contraseña.Show()
    End Sub
    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Empleados.Show()
    End Sub
    Private Sub AreasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AreasToolStripMenuItem.Click
        Areas.Show()
    End Sub
    Private Sub POSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles POSToolStripMenuItem.Click
        Inicio_pos_admin.Show()
    End Sub
    Private Sub SincronizadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SincronizadorToolStripMenuItem.Click
        Sincronizador.Show()
        Me.Close()
    End Sub

    Private Sub POSAdministrativoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles POSAdministrativoToolStripMenuItem.Click
        If (nivel = 1) Then
            Inicio_pos_admin.Show()
        End If
    End Sub

    Private Sub AgotadosposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgotadosposToolStripMenuItem.Click
        Agotados.Show()
        Me.Close()
    End Sub
End Class