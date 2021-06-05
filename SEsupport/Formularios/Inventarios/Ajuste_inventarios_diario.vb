Public Class Ajuste_inventarios_diario

    Dim funciones_generales As New Funciones_generales
    Private pastse, mes As String
    Private ingreso As Boolean = False
    Private carga As Boolean = False
    Private Sub Ajuste_inventarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim consulta As New Querys_inventarios
        Dim dtbodega As New DataTable

        dtbodega = consulta.cons_bodega(factu, "")

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
        consultar_conteo()
    End Sub

    Private Sub BtnAjustes_Click(sender As Object, e As EventArgs) Handles BtnAjustes.Click
        Dim ajustar As New Querys_inventarios
        Dim fecha As Date = DtpFecha.Text
        ajustar.ajuste_inventarios(CmbBodega.SelectedValue.ToString(), factu, pastse, mes, fecha.ToString("yyyyMMdd"))
        consultar_conteo()
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
            If DgvInventarios.Columns(e.ColumnIndex).HeaderText = "Conteo" Then
                Dim fecha As Date = DtpFecha.Text
                Dim actualizar As New Querys_inventarios

                actualizar.modifica_inventario(CmbBodega.SelectedValue.ToString(), factu, pastse, mes, fecha.ToString("yyyyMMdd"), nombre, DgvInventarios.Rows(e.RowIndex).Cells("referencia").Value, DgvInventarios.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)

                DgvInventarios.Rows(e.RowIndex).Cells("fechamod").Value = Date.Now
                DgvInventarios.Rows(e.RowIndex).Cells("usuariomod").Value = nombre

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
        Else
            MsgBox("No se ha realizado inventario para ese día", MsgBoxStyle.Critical)
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

    Private Sub TxbTotalAjuste_TextChanged(sender As Object, e As EventArgs) Handles TxbTotalAjuste.TextChanged

    End Sub
End Class
