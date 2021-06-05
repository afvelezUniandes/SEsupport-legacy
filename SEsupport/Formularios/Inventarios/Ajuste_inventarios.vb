Public Class Ajuste_inventarios

    Dim funciones_generales As New Funciones_generales
    Private pastse, mes As String
    Private ingreso As Boolean = False
    Private carga As Boolean = False
    Private Sub Ajuste_inventarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim consulta As New Querys_inventarios
        Dim dtbodega As New DataTable
        Dim dtpermiso As New DataTable
        Dim nvp As Integer
        dtpermiso = funciones_generales.cons_permisos(user, "4")
        For Each row As DataRow In dtpermiso.Rows
            nvp = row(2).ToString
            If nvp = 1 Then
                HerramientasToolStripMenuItem.Visible = False
            End If
        Next
        Usuario.Text = nombre
        CambiarADiarioToolStripMenuItem.Enabled = False
        EliminarInventarioToolStripMenuItem.Enabled = False

        dtbodega = consulta.cons_bodega(factu, "")
        Usuario.Text = nombre
        'Usuario.BackColor = Color.LawnGreen
        CmbBodega.DataSource = dtbodega
        CmbBodega.DisplayMember = dtbodega.Columns(2).ToString()
        CmbBodega.ValueMember = dtbodega.Columns(0).ToString()
        CmbBodega.Text = ""
        BtnAjustes.Enabled = False
        ingreso = True
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 5
        ProgressBar1.Value = 0

    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        If (CmbBodega.Text = "") Then
            MsgBox("No has seleccionado una bodega", MsgBoxStyle.Information)
        Else
            consultar_conteo()
            CambiarADiarioToolStripMenuItem.Enabled = True
            EliminarInventarioToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub eliminar_inv() ' este es el que funciona y esta bueno
        Dim borrar, consultas As New Querys_inventarios
        Dim dtm As New DataTable
        Dim fecha, fechacr As Date
        Dim inv, nf As Integer
        Dim tin As String
        fecha = DtpFecha.Text
        dtm = consultas.buscardato(factu)
        inv = dtm.Rows.Count()
        nf = DgvInventarios.Rows.Count()
        If (nf > inv) Then 'nf es el conteo de la tabla de inventario diario, en caso de ser mayor al conteo del pdv indica que hicieron conteo mes
            tin = "mes"
        Else
            tin = "diario"
        End If
        'BtnRestablecer.Visible = True
        Dim cdm As Integer = MsgBox("¿Desea Eliminar el inventario?. Recuerde que este proceso no se puede revertir", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
        If (cdm = 6) Then
            fechacr = Date.Now
            borrar.del_inv(factu, mes, CmbBodega.SelectedValue.ToString(), tin, fecha.ToString("yyyyMMdd"), nombre, "inventario eliminado", fechacr.ToString("yyyyMMdd"))

            If (nf > 0) Then
                DgvInventarios.Columns.Clear()
                MsgBox("El inventario fue eliminado", MsgBoxStyle.Information)
                DgvInventarios.DataSource = Nothing
                TxbTotalAjuste.Text = 0
            End If
            nf = 0
            BtnAjustes.Enabled = False
        End If
        BtnAjustes.Enabled = False
        BtnConsultar.Enabled = True
        BtnActualizarSaldo.Enabled = False
        BtnAjustes.Enabled = False
        Lblci.Text = nf
    End Sub

    Private Sub cambiarxdiario()
        Dim borrar, consultas, actualizar As New Querys_inventarios
        Dim dtconsulta, dtvalorizado, dtm As New DataTable
        Dim fecha, fechacr As Date
        Dim inv, nf As Integer
        Dim ti As String
        fecha = DtpFecha.Text
        dtm = consultas.buscardato(factu)
        inv = dtm.Rows.Count()
        nf = DgvInventarios.Rows.Count()
        If (nf > inv) Then 'nf es el conteo de la tabla de inventario diario, en caso de ser mayor al conteo del pdv indica que hicieron conteo mes
            ti = "mes"
        Else
            ti = "diario"
        End If

        If (ti = "mes") Then
            Dim cdm As Integer = MsgBox("Actualmente se ha generado un inventario fin de mes; ¿Desea cambiar el inventario de fin de mes a diario?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation)

            If (cdm = 6) Then
                fechacr = Date.Now
                borrar.del_inv(factu, mes, CmbBodega.SelectedValue.ToString(), ti, fecha.ToString("yyyyMMdd"), nombre, "inventario modificado a diario", fechacr.ToString("yyyyMMdd"))
                consultas.eliminar_ref(CmbBodega.SelectedValue.ToString(), fecha.ToString("yyyyMMdd"), factu, mes)
                consultas.cons_cambiar(factu, CmbBodega.SelectedValue.ToString(), fecha.ToString("yyyyMMdd"), ti)
                dtconsulta = consultas.cons_conteo(CmbBodega.SelectedValue.ToString(), factu, pastse, mes, fecha.ToString("yyyyMMdd"))

                DgvInventarios.DataSource = Nothing
                DgvInventarios.Columns.Clear()
                DgvInventarios.DataSource = dtconsulta

                DgvInventarios.Columns(0).ReadOnly = True
                DgvInventarios.Columns(1).ReadOnly = True
                DgvInventarios.Columns(1).Frozen = True
                DgvInventarios.Columns(2).Frozen = True
                DgvInventarios.Columns(2).ReadOnly = True
                DgvInventarios.Columns(3).ReadOnly = True
                DgvInventarios.Columns(4).ReadOnly = True
                DgvInventarios.Columns(5).ReadOnly = True
                DgvInventarios.Columns(5).ReadOnly = False
                DgvInventarios.Columns(6).ReadOnly = True
                DgvInventarios.Columns(7).ReadOnly = True
                DgvInventarios.Columns(8).ReadOnly = True
                DgvInventarios.Columns(9).ReadOnly = True
                DgvInventarios.Columns(10).ReadOnly = True

                If Math.Floor((Date.Now - DtpFecha.Value).TotalDays) > 1 Then
                    DgvInventarios.ReadOnly = True
                End If
                consultas.actualiza_saldo(CmbBodega.SelectedValue.ToString(), factu, pastse, mes, fecha.ToString("yyyyMMdd"))
                consultar_conteo()
                modifica(DgvInventarios, nf)
                nf = DgvInventarios.Rows.Count()
                Lblci.Text = nf
                BtnAjustes.Enabled = False
                MsgBox("Cambio realizado con éxito, ahora el inventario es diario", MsgBoxStyle.Information)
                'BtnRestablecer.Visible = True
            Else
                'BtnRestablecer.Visible = True
            End If
        Else
            MsgBox("El inventario diario es del día: " + DtpFecha.Value.ToShortDateString + " y no se puede modificar", MsgBoxStyle.Information)
            BtnAjustes.Enabled = False
        End If
        BtnConsultar.Enabled = False
        'BtnRestablecer.Visible = False
        Lblci.Text = nf
    End Sub

    Private Sub modifica(DgvInventarios As DataGridView, nf As Integer)
        If carga = True Then

            Dim fecha As Date = DtpFecha.Text
            Dim actualizar As New Querys_inventarios
            Dim i, q As Integer

            q = DgvInventarios.Rows.Count()

            i = 0
            While (i < q)
                actualizar.modifica_inventario(CmbBodega.SelectedValue.ToString(), factu, pastse, mes, fecha.ToString("yyyyMMdd"), nombre, DgvInventarios.Rows(i).Cells(2).Value, DgvInventarios.Rows(i).Cells(4).Value)
                DgvInventarios.Rows(i).Cells("fecha_modificacion").Value = Date.Now
                DgvInventarios.Rows(i).Cells("usuario_modificacion").Value = nombre
                i = i + 1

            End While
            Dim dtvalorizado As New DataTable
            dtvalorizado = actualizar.cons_valorizado(CmbBodega.SelectedValue.ToString(), factu, pastse, mes, fecha.ToString("yyyyMMdd"))
            TxbTotalAjuste.Text = dtvalorizado.Rows(0)(0).ToString()

        End If
    End Sub

    Private Sub BtnAjustes_Click(sender As Object, e As EventArgs) Handles BtnAjustes.Click
        Dim cancelar As Boolean = False
        Dim r_ajuste As Integer = MsgBox("Recuerda que este proceso no se puede reversar; ¿Desea proseguir con el ajuste?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation)
        If r_ajuste = 6 Then
            Dim ajustar As New Querys_inventarios
            Dim fecha As Date = DtpFecha.Text
            ajustar.ajuste_inventarios(CmbBodega.SelectedValue.ToString(), factu, pastse, mes, fecha.ToString("yyyyMMdd"))
            consultar_conteo()
        Else
            cancelar = True
        End If

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim cambia As Boolean = False
        For i = 0 To DgvInventarios.RowCount - 1
            Dim valor As String = DgvInventarios.Rows(i).Cells(2).Value
            If valor = TxbBuscar.Text Then
                DgvInventarios.Rows(i).Selected = True
                DgvInventarios.CurrentCell = DgvInventarios.Rows(i).Cells(2)
                i = DgvInventarios.RowCount
                cambia = True
            End If
        Next
        If cambia = False Then
            MsgBox("No se encontró la referencia", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub TxbBuscar_Enter(sender As Object, e As EventArgs) Handles TxbBuscar.Enter
        Me.AcceptButton = BtnBuscar
    End Sub

    Private Sub DgvInventarios_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvInventarios.CellValueChanged
        If carga = True Then
            If DgvInventarios.Columns(e.ColumnIndex).HeaderText = "conteo" Then
                Dim fecha As Date = DtpFecha.Text
                Dim actualizar As New Querys_inventarios

                actualizar.modifica_inventario(CmbBodega.SelectedValue.ToString(), factu, pastse, mes, fecha.ToString("yyyyMMdd"), nombre, DgvInventarios.Rows(e.RowIndex).Cells("referencia").Value, DgvInventarios.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)

                DgvInventarios.Rows(e.RowIndex).Cells("fecha_modificacion").Value = Date.Now
                DgvInventarios.Rows(e.RowIndex).Cells("usuario_modificacion").Value = nombre

                Dim dtvalorizado As New DataTable
                dtvalorizado = actualizar.cons_valorizado(CmbBodega.SelectedValue.ToString(), factu, pastse, mes, fecha.ToString("yyyyMMdd"))
                TxbTotalAjuste.Text = dtvalorizado.Rows(0)(0).ToString()
            End If
        End If
    End Sub

    Private Sub CmbBodega_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBodega.SelectedIndexChanged
        If ingreso = True Then
            Dim consultas As New Querys_inventarios
            Dim dtpastse As DataTable
            dtpastse = consultas.cons_pastse_factu_bod(CmbBodega.Text.ToString())
            pastse = dtpastse.Rows(0)(4).ToString()
            factu = dtpastse.Rows(0)(3).ToString()
        End If
        BtnConsultar.Enabled = True
        DgvInventarios.Enabled = False
        'BtnEliminar.Visible = False
    End Sub

    Private Sub BtnActualizarSaldo_Click(sender As Object, e As EventArgs) Handles BtnActualizarSaldo.Click
        Dim consultar As New Querys_inventarios
        Dim fecha As Date = DtpFecha.Text
        consultar.actualiza_saldo(CmbBodega.SelectedValue.ToString(), factu, pastse, mes, fecha.ToString("yyyyMMdd"))
        consultar_conteo()
    End Sub

    Sub consultar_conteo()
        carga = False
        DgvInventarios.DataSource = Nothing

        Dim consultas As New Querys_inventarios
        Dim dtconsulta, dtvalorizado As New DataTable
        Dim fecha As Date = DtpFecha.Text

        Dim dtpastse As New DataTable
        mes = Year(DtpFecha.Text) * 100 + Month(DtpFecha.Text)
        dtpastse = consultas.cons_pastse(factu, CmbBodega.SelectedValue.ToString())
        pastse = dtpastse.Rows(0)(4).ToString()

        dtconsulta = consultas.cons_conteo(CmbBodega.SelectedValue.ToString(), factu, pastse, mes, fecha.ToString("yyyyMMdd"))
        dtvalorizado = consultas.cons_valorizado(CmbBodega.SelectedValue.ToString(), factu, pastse, mes, fecha.ToString("yyyyMMdd"))
        TxbTotalAjuste.Text = dtvalorizado.Rows(0)(0).ToString()

        If dtconsulta.Rows.Count() > 0 Then
            DgvInventarios.DataSource = Nothing
            DgvInventarios.DataSource = dtconsulta
            Lblci.Text = DgvInventarios.Rows.Count()
            'DgvInventarios.Columns.Clear()
            'DgvInventarios.Rows.Clear()


            'Dim columna_mes As New DataGridViewTextBoxColumn
            'With columna_mes
            '    .Name = "mes"
            '    .Visible = False
            '    .HeaderText = "Mes"
            '    .Frozen = True
            'End With
            'DgvInventarios.Columns.Add(columna_mes)

            'Dim columna_bodega As New DataGridViewTextBoxColumn
            'With columna_bodega
            '    .Name = "bodega"
            '    .ReadOnly = True
            '    .HeaderText = "Bodega"
            '    .Frozen = True
            'End With
            'DgvInventarios.Columns.Add(columna_bodega)

            'Dim columna_referencia As New DataGridViewTextBoxColumn
            'With columna_referencia
            '    .Name = "referencia"
            '    .ReadOnly = True
            '    .HeaderText = "Referencia"
            '    .Frozen = True
            'End With
            'DgvInventarios.Columns.Add(columna_referencia)

            'Dim columna_nombreprod As New DataGridViewTextBoxColumn
            'With columna_nombreprod
            '    .Name = "nombreprod"
            '    .ReadOnly = True
            '    .HeaderText = "Nombre Producto"
            '    .Frozen = True
            'End With
            'DgvInventarios.Columns.Add(columna_nombreprod)

            'Dim columna_conteo As New DataGridViewTextBoxColumn
            'With columna_conteo
            '    .Name = "conteo"
            '    .HeaderText = "Conteo"
            'End With
            'DgvInventarios.Columns.Add(columna_conteo)

            'Dim columna_saldo As New DataGridViewTextBoxColumn
            'With columna_saldo
            '    .Name = "saldo"
            '    .ReadOnly = True
            '    .HeaderText = "Saldo"
            'End With
            'DgvInventarios.Columns.Add(columna_saldo)

            'Dim columna_diferencia As New DataGridViewTextBoxColumn
            'With columna_diferencia
            '    .Name = "diferencia"
            '    .ReadOnly = True
            '    .HeaderText = "Diferencia"
            'End With
            'DgvInventarios.Columns.Add(columna_diferencia)

            'Dim columna_fechagen As New DataGridViewTextBoxColumn
            'With columna_fechagen
            '    .Name = "fechagen"
            '    .ReadOnly = True
            '    .HeaderText = "Fecha Generación"
            'End With
            'DgvInventarios.Columns.Add(columna_fechagen)

            'Dim columna_fechamod As New DataGridViewTextBoxColumn
            'With columna_fechamod
            '    .Name = "fechamod"
            '    .ReadOnly = True
            '    .HeaderText = "Fecha Modificación"
            'End With
            'DgvInventarios.Columns.Add(columna_fechamod)

            'Dim columna_usuariocrea As New DataGridViewTextBoxColumn
            'With columna_bodega
            '    .Name = "usuariocrea"
            '    .ReadOnly = True
            '    .HeaderText = "Usuario Creación"
            'End With
            'DgvInventarios.Columns.Add(columna_usuariocrea)

            'Dim columna_usuariomod As New DataGridViewTextBoxColumn
            'With columna_usuariomod
            '    .Name = "usuariomod"
            '    .ReadOnly = True
            '    .HeaderText = "Usuario Modificación"
            'End With
            'DgvInventarios.Columns.Add(columna_usuariomod)

            'Dim columna_ajuste As New DataGridViewTextBoxColumn
            'With columna_bodega
            '    .Name = "ajuste"
            '    .ReadOnly = True
            '    .HeaderText = "Ajuste"
            'End With
            'DgvInventarios.Columns.Add(columna_ajuste)

            'Dim columna_numeroajuste As New DataGridViewTextBoxColumn
            'With columna_numeroajuste
            '    .Name = "numeroajuste"
            '    .ReadOnly = True
            '    .HeaderText = "Numero Ajuste"
            'End With
            'DgvInventarios.Columns.Add(columna_numeroajuste)

            'Dim columna_check As New DataGridViewCheckBoxColumn()
            'With columna_check
            '    .Name = "Sel"
            '    .Frozen = True
            '    .DisplayIndex = 0
            'End With
            'DgvInventarios.Columns.Add(columna_check)

            'Dim cantidad As Integer = dtconsulta.Rows.Count() '* dtconsulta.Columns.Count()
            'ProgressBar1.Minimum = 0
            'ProgressBar1.Maximum = cantidad

            'For i = 0 To dtconsulta.Rows.Count - 1
            '    DgvInventarios.Rows.Add()
            '    For j = 0 To DgvInventarios.Columns.Count - 2
            '        DgvInventarios.Rows(i).Cells(j).Value = dtconsulta.Rows(i)(j).ToString()
            '    Next
            '    ProgressBar1.Value = ProgressBar1.Value + 1
            '    'Me.Refresh()
            '    Application.DoEvents()
            'Next
            'ProgressBar1.Value = 0
            BtnAjustes.Enabled = True
            'BtnRestablecer.Visible = True
            BtnActualizarSaldo.Enabled = True
            DgvInventarios.Enabled = True
            'BtnEliminar.Visible = True
        Else
            MsgBox("No se ha realizado inventario para ese día", MsgBoxStyle.Critical)
            'BtnRestablecer.Visible = False
            'BtnEliminar.Visible = False
            BtnActualizarSaldo.Enabled = False
            BtnAjustes.Enabled = False
            DgvInventarios.Enabled = False
        End If
        carga = True
    End Sub

    Private Sub SeleccionarTodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionarTodosToolStripMenuItem.Click
        Dim cantidad As Integer = DgvInventarios.Rows.Count()
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = cantidad
        For Each fila As DataGridViewRow In DgvInventarios.Rows
            fila.Cells("Sel.").Value = True
            ProgressBar1.Value = ProgressBar1.Value + 1
            'Me.Refresh()
            Application.DoEvents()
        Next
        ProgressBar1.Value = 0
    End Sub

    Private Sub QuitarSelecciónTodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitarSelecciónTodosToolStripMenuItem.Click
        Dim cantidad As Integer = DgvInventarios.Rows.Count()
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = cantidad
        For Each fila As DataGridViewRow In DgvInventarios.Rows
            fila.Cells("Sel.").Value = False
            ProgressBar1.Value = ProgressBar1.Value + 1
            'Me.Refresh()
            Application.DoEvents()
        Next
        ProgressBar1.Value = 0
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Login.Show()
        Me.Close()
    End Sub

    Private Sub DgvInventarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvInventarios.CellContentClick

    End Sub

    Private Sub Usuario_Click(sender As Object, e As EventArgs) Handles Usuario.Click
        Usuario.BackColor = Color.Orange
        Dim out As Integer = MsgBox("¿Desea cerrar su sesión y salir?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation)
        If (out = 6) Then
            Login.Show()
            Me.Close()
        Else
            Usuario.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub DtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles DtpFecha.ValueChanged
        DgvInventarios.DataSource = Nothing
        BtnConsultar.Enabled = True
        'BtnEliminar.Visible = False
        'BtnRestablecer.Visible = False
        Lblci.Text = ""
        TxbTotalAjuste.Text = ""
    End Sub

    Private Sub IngresarInventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarInventarioToolStripMenuItem.Click
        Dim consultas As New Funciones_generales
        Dim dtpermiso As New DataTable
        Dim nvp As Integer
        dtpermiso = consultas.cons_permisos(user, "4")
        For Each row As DataRow In dtpermiso.Rows
            nvp = row(2).ToString
            If nvp = 2 Or nvp = 3 Or nvp = 4 Then
                Ingreso_inventarios.Show()
                Me.Close()
            End If
        Next
    End Sub

    Private Sub QuejasYNoConformidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuejasYNoConformidadesToolStripMenuItem.Click
        Inicio.Show()
        'DgvInventarios.ClearSelection()
        factu = ""
        Me.Close()
    End Sub
End Class
