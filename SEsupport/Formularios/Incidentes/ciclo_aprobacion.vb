Public Class ciclo_aprobacion

    Public numero_incidente, descripcion As String
    Private p_idciclo, p_cicloant, p_aprobado, p_justificacion As String
    Public usuario As String
    Dim funciones_generales As New Funciones_generales
    Private Sub ciclo_aprobacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtconsulta, dtusuario, dttipoaprobacion As New DataTable
        Dim consulta As New Querys_incidentes

        limpiar()

        If usuario = "" Then
            TxbIdHist.Text = numero_incidente
            TxbDescripcion.Text = descripcion
        End If

        dtusuario = funciones_generales.cons_aprobador()
        CmbNuevoAprobador.DataSource = dtusuario
        CmbNuevoAprobador.DisplayMember = dtusuario.Columns(3).ToString()
        CmbNuevoAprobador.ValueMember = dtusuario.Columns(3).ToString()
        CmbNuevoAprobador.Text = ""

        dttipoaprobacion = consulta.cons_tipo_aprobacion()
        CmbTipoAprobacion.DataSource = dttipoaprobacion
        CmbTipoAprobacion.DisplayMember = dttipoaprobacion.Columns(1).ToString()
        CmbTipoAprobacion.ValueMember = dttipoaprobacion.Columns(0).ToString()
        CmbTipoAprobacion.Text = ""

        actualizar_datagridview()
    End Sub

    Private Sub ciclo_aprobacion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Principal_usuario_req.Enabled = True
        Catch ex As Exception
        End Try

        Try
            Editar_usuario_req.Enabled = True
        Catch ex As Exception
        End Try

        Try
            Editar_tecnico_req.Enabled = True
        Catch ex As Exception
        End Try

        Try
            Principal_usuario_queja.Enabled = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnNuevoAprobador_Click(sender As Object, e As EventArgs) Handles BtnNuevoAprobador.Click
        If CmbNuevoAprobador.Text <> "" And TxbJustificacionCambio.Text <> "" Then
            Dim cambiar As New Querys_incidentes
            Dim dtconsulta, dtusuario As New DataTable
            Try
                Dim id As Double
                If TxbIdHist.Text = "" Then
                    id = 0
                Else
                    id = TxbIdHist.Text
                End If
                dtconsulta = cambiar.cons_ciclo_aprobacion_inc(id)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            dtusuario = cambiar.cons_datosusuario(CmbNuevoAprobador.SelectedValue.ToString())

            If dtconsulta.Rows.Count > 0 Then
                cambiar.actualizar_ciclo_aprobacion(p_idciclo, 3, TxbJustificacionCambio.Text)
            End If
            Try
                cambiar.nuevo_ciclo_aprobacion(p_idciclo, numero_incidente, "", "", dtusuario.Rows(0)(1).ToString())
                enviar_correo("5")
                MsgBox("Se ingreso correctamente el nuevo aprobador", MsgBoxStyle.Information)

                actualizar_datagridview()
                limpiar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Debe completar los datos del nuevo usuario y la justificación del cambio", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If CmbTipoAprobacion.Text <> "" And TxbAprobado.Text <> "" And TxbIdHist.Text <> "" Then
            Dim cambiar As New Querys_incidentes
            Try
                cambiar.actualizar_ciclo_aprobacion(p_idciclo, CmbTipoAprobacion.SelectedValue.ToString(), TxbAprobado.Text)
                enviar_correo("6")
                MsgBox("Aprobado correctamente", MsgBoxStyle.Information)

                actualizar_datagridview()
                limpiar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            
        Else
            MsgBox("Se deben completar los campos aprobación y justificación", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub DgvCicloAprobacion_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCicloAprobacion.CellDoubleClick
        limpiar()
        If (e.RowIndex >= 0) Then
            numero_incidente = DgvCicloAprobacion(2, e.RowIndex).Value.ToString()
            p_aprobado = DgvCicloAprobacion(3, e.RowIndex).Value.ToString()
            p_cicloant = DgvCicloAprobacion(1, e.RowIndex).Value.ToString()
            p_idciclo = DgvCicloAprobacion(0, e.RowIndex).Value.ToString()
            p_justificacion = DgvCicloAprobacion(4, e.RowIndex).Value.ToString()
            TxbIdHist.Text = numero_incidente
            TxbDescripcion.Text = DgvCicloAprobacion(9, e.RowIndex).Value.ToString()

            'If DgvCicloAprobacion(6, e.RowIndex).Value.ToString() = nombre Then
            If p_aprobado = 0 Then
                    If DgvCicloAprobacion.Rows.Count > 0 Then
                        BtnCancelar.Enabled = True
                        BtnGuardar.Enabled = True
                        CmbTipoAprobacion.Enabled = True
                        TxbAprobado.Enabled = True
                    End If
                    CmbNuevoAprobador.Enabled = True
                    TxbJustificacionCambio.Enabled = True
                    BtnNuevoAprobador.Enabled = True
                End If
            'End If
        End If
    End Sub

    Sub limpiar()
        CmbNuevoAprobador.Text = ""
        CmbTipoAprobacion.Text = ""
        TxbAprobado.Text = ""
        TxbIdHist.Text = ""
        TxbJustificacionCambio.Text = ""
        TxbDescripcion.Text = ""

        If DgvCicloAprobacion.Rows.Count() > 0 Then
            CmbNuevoAprobador.Enabled = False
            TxbJustificacionCambio.Enabled = False
            BtnNuevoAprobador.Enabled = False
        End If

        CmbTipoAprobacion.Enabled = False
        TxbAprobado.Enabled = False
        BtnCancelar.Enabled = False
        BtnGuardar.Enabled = False

    End Sub

    Sub actualizar_datagridview()
        Dim dtconsulta As New DataTable
        Dim consulta As New Querys_incidentes

        Try
            If usuario <> "" Then
                dtconsulta = consulta.cons_ciclo_aprobacion_usu(usuario)
            Else
                dtconsulta = consulta.cons_ciclo_aprobacion_inc(numero_incidente)
            End If

            DgvCicloAprobacion.DataSource = dtconsulta

            DgvCicloAprobacion.Columns(3).Visible = False
            DgvCicloAprobacion.Columns(5).Visible = False

            DgvCicloAprobacion.AutoResizeColumns()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub actualizar_datagridview_filtros(filtro As String)
        Dim dtconsulta As New DataTable
        Dim consulta As New Querys_incidentes

        Try
            If filtro = 0 Then
                dtconsulta = consulta.cons_ciclo_aprobacion_estado_usu("", usuario)
            ElseIf filtro = 1 Then
                dtconsulta = consulta.cons_ciclo_aprobacion_estado_usu("1", usuario)
            ElseIf filtro = 2 Then
                dtconsulta = consulta.cons_ciclo_aprobacion_estado_usu("2", usuario)
            ElseIf filtro = 3 Then
                dtconsulta = consulta.cons_ciclo_aprobacion_estado_usu("3", usuario)
            End If

            DgvCicloAprobacion.DataSource = dtconsulta

            DgvCicloAprobacion.Columns(3).Visible = False
            DgvCicloAprobacion.Columns(5).Visible = False

            DgvCicloAprobacion.AutoResizeColumns()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        limpiar()
    End Sub

    Sub enviar_correo(tipo As String)

        Dim fechamodificacion As Date = Date.Now
        fechamodificacion = fechamodificacion.ToString("dd/MM/yyyy")

        Dim dttecnico, dt_texto_correo, dtcorreo As New DataTable
        Dim consultas As New Querys_incidentes

        If tipo = 5 Then 'nuevo ciclo'
            dtcorreo = consultas.cons_usuario(CmbNuevoAprobador.SelectedValue.ToString())
            funciones_generales.envio_correo(dtcorreo.Rows(0)(6).ToString(), "Requerimiento de aprobación número: " & TxbIdHist.Text, tipo, TxbIdHist.Text, TxbDescripcion.Text, TxbJustificacionCambio.Text, fechamodificacion, "", "", "", "")
        ElseIf tipo = 6 Then 'finaliza ciclo'
            dttecnico = consultas.cons_pendientes_numero(TxbIdHist.Text)
            dtcorreo = consultas.cons_usuario(dttecnico.Rows(0)(20).ToString())
            funciones_generales.envio_correo(dtcorreo.Rows(0)(6).ToString(), "Finalización ciclo aprobación número: " & TxbIdHist.Text, tipo, TxbIdHist.Text, TxbDescripcion.Text, CmbTipoAprobacion.Text.ToString(), TxbAprobado.Text, fechamodificacion, "", "", "")
        End If
    End Sub

    Private Sub SinAprobacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SinAprobacionToolStripMenuItem.Click
        actualizar_datagridview_filtros("0") '0 = sin aprobación
    End Sub

    Private Sub NumeroDeIncidenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NumeroDeIncidenteToolStripMenuItem.Click
        actualizar_datagridview_filtros("1") '1 = aprobado
    End Sub

    Private Sub NoAprobadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoAprobadoToolStripMenuItem.Click
        actualizar_datagridview_filtros("2") '2 = no aprobado
    End Sub

    Private Sub NoAlAlcanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoAlAlcanceToolStripMenuItem.Click
        actualizar_datagridview_filtros("3") '3 = no al alcance
    End Sub

    Private Sub TxbDescripcion_TextChanged(sender As Object, e As EventArgs) Handles TxbDescripcion.TextChanged

    End Sub

    Private Sub DgvCicloAprobacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCicloAprobacion.CellContentClick

    End Sub
End Class