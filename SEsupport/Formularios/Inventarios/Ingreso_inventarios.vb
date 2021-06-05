Imports vb = Microsoft.VisualBasic
Public Class Ingreso_inventarios
    Dim consulta As New Querys_inventarios
    Dim funciones_generales As New Funciones_generales
    Private pastse, mes, tipo, nu, tinv As String
    Private Sub Ingreso_inventarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerarAjusteDeInventarioToolStripMenuItem.Visible = False
        GenerarAjusteDeInventarioDiarioToolStripMenuItem.Visible = False
        Dim consulta As New Querys_inventarios
        Dim dtbodega, dtpermisoajuste As New DataTable
        Dim fecha As String
        Usuario.Text = nombre
        nu = vb.Left(nombre, 3)
        If (nu.Equals("Pos") Or nu.Equals("POS")) Then
            dtbodega = consulta.cons_bodega(factu, user)
        Else
            dtbodega = consulta.cons_bodega(factu, "")
        End If
        dtpermisoajuste = funciones_generales.cons_permisos(nombre, 4)

        If dtpermisoajuste.Rows.Count > 0 Then
            If dtpermisoajuste.Rows(0)(2).ToString() >= 1 Then
                GenerarAjusteDeInventarioToolStripMenuItem.Visible = True

            End If
        End If

        Dim nvp As Integer
        Dim consultas As New Funciones_generales
        Dim dtper As New DataTable
        dtper = consultas.cons_permisos(user, "3")
        For Each i As DataRow In dtper.Rows
            nvp = i(2).ToString
            If nvp = 2 Or nvp = 4 Then
                EliminarInventarioToolStripMenuItem.Visible = True
            Else
                EliminarInventarioToolStripMenuItem.Visible = False
            End If
        Next

        CmbBodega.DataSource = dtbodega
        CmbBodega.DisplayMember = dtbodega.Columns(2).ToString()
        CmbBodega.ValueMember = dtbodega.Columns(0).ToString()
        CmbBodega.Text = ""

        ToolStripStatusLabel5.Text = "USUARIO ACTIVO: " & nombre.ToUpper
        fecha = modificarfecha(Date.Now)
        ToolStripStatusLabel1.Text = fecha
        ToolStripStatusLabel3.Text = "Inventario: "
        ToolStripStatusLabel7.Text = "Unidades: "
    End Sub

    Public Function modificarfecha(fec As DateTime)
        Dim str As String = fec
        Dim fecha As String
        Dim fcam As DateTime = Convert.ToDateTime(String.Format("{0:dd-MM-aaaa HH:mm:ss}", str))
        fecha = Format(fcam, "yyyy-MM-dd HH:mm:ss.fff")
        Return fecha
    End Function

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        DgvInventarios.DataSource = Nothing

        Dim cancelar As Boolean = False
        Dim consultas As New Querys_inventarios
        Dim dtconsulta, dtpastse As New DataTable
        Dim fecha As Date = DtpFecha.Text
        mes = Year(DtpFecha.Text) * 100 + Month(DtpFecha.Text)
        'si es un administrativo 
        If (nu <> ("Pos") Or nu <> ("POS")) Then
            Dim dt_comp As New DataTable
            Dim vp(), nop As String
            vp = CmbBodega.Text.Split(" ")
            nop = vp(4)
            For i As Integer = 5 To vp.Length - 1
                nop = nop + " " + vp(i)
            Next
            dt_comp = consulta.cons_compania(nop)  'consultamos la compañia del pos
            factu = dt_comp.Rows(0)(0).ToString()  'capturo la compañia
        End If
        dtpastse = consultas.cons_pastse(factu, CmbBodega.SelectedValue.ToString())
        pastse = dtpastse.Rows(0)(4).ToString()
        dtconsulta = consultas.cons_conteo(CmbBodega.SelectedValue.ToString(), factu, pastse, mes, fecha.ToString("yyyyMMdd"))
        If dtconsulta.Rows.Count() = 0 Then
            If (CmbTipoInventario.Text.Equals("")) Then
                MsgBox("Seleccione un tipo de inventario para generar", MsgBoxStyle.Critical)
            Else
                Dim respuesta As Integer = MsgBox("Desea Ingresar el " & CmbTipoInventario.Text.ToString() & " ?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation)
                If respuesta = 6 Then
                    If CmbTipoInventario.SelectedIndex = 0 Then
                        tipo = "dia"
                        consultas.nuevo_inventario(CmbBodega.SelectedValue.ToString(), factu, pastse, mes, fecha.ToString("yyyyMMdd"), tipo, nombre)
                        ToolStripStatusLabel3.Text = "Inventario del " & tipo.ToUpper
                    Else
                        tipo = "mes"
                        consultas.nuevo_inventario(CmbBodega.SelectedValue.ToString(), factu, pastse, mes, fecha.ToString("yyyyMMdd"), tipo, nombre)
                        ToolStripStatusLabel3.Text = "Inventario de " & tipo.ToUpper
                    End If

                    dtconsulta = consultas.cons_conteo(CmbBodega.SelectedValue.ToString(), factu, pastse, mes, fecha.ToString("yyyyMMdd"))
                Else
                    cancelar = True
                End If
            End If

        End If

        If cancelar = False Then
            DgvInventarios.DataSource = dtconsulta
            DgvInventarios.Columns(0).Visible = False
            DgvInventarios.Columns(1).ReadOnly = True
            DgvInventarios.Columns(1).Frozen = True
            DgvInventarios.Columns(2).Frozen = True
            DgvInventarios.Columns(2).ReadOnly = True
            DgvInventarios.Columns(3).ReadOnly = True
            DgvInventarios.Columns(5).Visible = False
            DgvInventarios.Columns(6).Visible = False
            DgvInventarios.Columns(7).ReadOnly = True
            DgvInventarios.Columns(8).ReadOnly = True
            DgvInventarios.Columns(9).ReadOnly = True

            If Math.Floor((Date.Now - DtpFecha.Value).TotalDays) > 1 Then
                DgvInventarios.ReadOnly = True
            End If
        End If
        ToolStripStatusLabel7.Text = "Unidades: " & DgvInventarios.Rows.Count()

        If (DgvInventarios.Rows.Count() > 1000) Then
            ToolStripStatusLabel3.Text = "Inventario mensual"
            tinv = "Mensual"
        Else
            ToolStripStatusLabel3.Text = "Inventario diario"
            tinv = "Diario"
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
        If e.ColumnIndex = 4 Then
            Dim fecha As Date = DtpFecha.Text
            Dim actualizar As New Querys_inventarios
            Dim cantidad As Double

            cantidad = DgvInventarios.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            'MsgBox(cantidad)
            actualizar.modifica_inventario(CmbBodega.SelectedValue.ToString(), factu, pastse, mes, fecha.ToString("yyyyMMdd"), nombre, DgvInventarios.Rows(e.RowIndex).Cells("referencia").Value, cantidad)

            DgvInventarios.Rows(e.RowIndex).Cells("fecha_modificacion").Value = Date.Now
            DgvInventarios.Rows(e.RowIndex).Cells("usuario_modificacion").Value = nombre
        End If
    End Sub

    Private Sub CmbBodega_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBodega.SelectedIndexChanged

    End Sub

    Private Sub GenerarAjusteDeInventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarAjusteDeInventarioToolStripMenuItem.Click
        Ajuste_inventarios.Show()
        Me.Close()
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        Dim fecha As Date = DtpFecha.Text
        Impresion_Inventario.i_fecha103 = DtpFecha.Text
        Impresion_Inventario.i_mes = mes
        Impresion_Inventario.i_bodega = CmbBodega.SelectedValue.ToString()
        Impresion_Inventario.i_factu = factu
        Impresion_Inventario.i_fecha = fecha.ToString("yyyyMMdd")
        Impresion_Inventario.i_pastse = pastse
        Impresion_Inventario.Show()
    End Sub

    Private Sub Principal_usuario_req_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        funciones_generales.borrar_directorio_temp(ruta_adjunto_incidente & carpeta_temp)
    End Sub

    Private Sub CambiarInventarioADiarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarInventarioADiarioToolStripMenuItem.Click
        Dim consultas As New Querys_inventarios
        Dim dtaux, dtconsulta As New DataTable
        Dim cancelar As Boolean = False
        'Dim referencia, cantidad As String
        Dim fecha As Date = DtpFecha.Text
        If (tinv.Equals("Mensual")) Then
            'validamos que se haya cargado el inventario
            If (DgvInventarios.Rows.Count > 0) Then

                Dim respuesta As Integer = MsgBox("Desea cambiar el inventario a diario?. Recuerde que perdera toda la información ingresada y debera realizar nuevamente el registro. ", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation)
                If respuesta = 6 Then

                    'copiamos la tabla actual a una temporal
                    'agregamos las columnas
                    'For Each column As DataGridViewColumn In DgvInventarios.Columns
                    '    dtaux.Columns.Add(column.HeaderText, column.ValueType)
                    'Next
                    'agregamos las filas
                    'For Each row As DataGridViewRow In DgvInventarios.Rows
                    '    dtaux.Rows.Add()
                    '    For Each cell As DataGridViewCell In row.Cells
                    '        If (cell.ColumnIndex = 7) Then
                    '            Dim fi As DateTime = dtaux.Rows(row.Index)(cell.ColumnIndex).ToString()
                    '            dtaux.Rows(row.Index)(cell.ColumnIndex) = DateTime.Parse(fi)
                    '        End If

                    '        dtaux.Rows(dtaux.Rows.Count - 1)(cell.ColumnIndex) = cell.Value.ToString()
                    '    Next
                    'Next
                    'borramos la tabla actual
                    consulta.borrar_inv(factu, CmbBodega.SelectedValue.ToString(), mes, fecha.ToString("yyyyMMdd"))
                    DgvInventarios.DataSource = ""
                    ToolStripStatusLabel7.Text = "Unidades: " & DgvInventarios.Rows.Count()
                    'agregamos nuevamente las referencias correspondientes
                    consulta.nuevo_inventario(CmbBodega.SelectedValue.ToString(), factu, pastse, mes, fecha.ToString("yyyyMMdd"), tipo, nombre)
                    'le ponemos el valor ingresado a las referencias

                    'recorrer tabla nueva, coger referencia de dtaux comprar referencia. al encontrarla poner cantidad
                    'For Each tem As DataRow In dtaux.Rows
                    '    referencia = tem("referencia").ToString()
                    '    cantidad = tem("conteo").ToString
                    '    For Each row As DataGridViewRow In DgvInventarios.Rows
                    '        If referencia = row.Cells("referencia").Value Then
                    '            row.Cells.Item("cantidad").Value = cantidad
                    '        End If
                    '    Next
                    'Next
                    'borramos la tabla auxiliar

                    dtconsulta = consultas.cons_conteo(CmbBodega.SelectedValue.ToString(), factu, pastse, mes, fecha.ToString("yyyyMMdd"))

                    If cancelar = False Then
                        DgvInventarios.DataSource = dtconsulta
                        DgvInventarios.Columns(0).Visible = False
                        DgvInventarios.Columns(1).ReadOnly = True
                        DgvInventarios.Columns(1).Frozen = True
                        DgvInventarios.Columns(2).Frozen = True
                        DgvInventarios.Columns(2).ReadOnly = True
                        DgvInventarios.Columns(3).ReadOnly = True
                        DgvInventarios.Columns(5).Visible = False
                        DgvInventarios.Columns(6).Visible = False
                        DgvInventarios.Columns(7).ReadOnly = True
                        DgvInventarios.Columns(8).ReadOnly = True
                        DgvInventarios.Columns(9).ReadOnly = True

                        If Math.Floor((Date.Now - DtpFecha.Value).TotalDays) > 1 Then
                            DgvInventarios.ReadOnly = True
                        End If
                    End If
                    ToolStripStatusLabel7.Text = "Unidades: " & DgvInventarios.Rows.Count()
                    ToolStripStatusLabel3.Text = "Inventario diario"
                    tinv = "Diario"
                End If
            Else
                    MsgBox("No se ha cargado un inventario", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("El inventario no se puede cambiar porque ya es diario", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub EliminarInventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarInventarioToolStripMenuItem.Click
        Dim fecha As Date = DtpFecha.Text
        Dim respuesta As Integer = MsgBox("Esta seguro de eliminar el inventario?. Una vez que lo haga, este proceso no se podrá reversar.", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation)
        If respuesta = 6 Then
            consulta.borrar_inv(factu, CmbBodega.SelectedValue.ToString(), mes, fecha.ToString("yyyyMMdd"))
            MsgBox("Inventario eliminado con éxito", MsgBoxStyle.Exclamation)
            'DgvInventarios.Rows.Clear()
            DgvInventarios.DataSource = ""

        End If
    End Sub
    Private Sub GenerarAjusteDeInventarioDiarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarAjusteDeInventarioDiarioToolStripMenuItem.Click
        Ajuste_inventarios_diario.Show()
        Me.Close()
    End Sub

    Private Sub QuejasYNoConformidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuejasYNoConformidadesToolStripMenuItem.Click
        Inicio.Show()
        Me.Close()
    End Sub

    Private Sub CambiarInventarioAMensualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarInventarioAMensualToolStripMenuItem.Click
        Dim i As Integer = MsgBox("POR FAVOR CONFIRMAR EL CAMBIO A REALIZAR.   EL PROCESO NO SE PUEDE DETENER NI DEVOLVERSE A INVENTARIO DIARIO.", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation)
        If i = 6 Then
            Dim consultas As New Querys_inventarios
            Dim fecha As Date = DtpFecha.Text
            consultas.cambia_tipo_inventario(CmbBodega.SelectedValue.ToString(), factu, pastse, mes, fecha.ToString("yyyyMMdd"), "dia", nombre)
            Dim dtconsulta As New DataTable
            dtconsulta = consultas.cons_conteo(CmbBodega.SelectedValue.ToString(), factu, pastse, mes, fecha.ToString("yyyyMMdd"))
            DgvInventarios.Columns.Clear()
            DgvInventarios.DataSource = dtconsulta
            DgvInventarios.Columns(0).Visible = False
            DgvInventarios.Columns(1).ReadOnly = True
            DgvInventarios.Columns(1).Frozen = True
            DgvInventarios.Columns(2).Frozen = True
            DgvInventarios.Columns(2).ReadOnly = True
            DgvInventarios.Columns(3).ReadOnly = True
            DgvInventarios.Columns(5).Visible = False
            DgvInventarios.Columns(6).Visible = False
            DgvInventarios.Columns(7).ReadOnly = True
            DgvInventarios.Columns(8).ReadOnly = True
            DgvInventarios.Columns(9).ReadOnly = True

            If Math.Floor((Date.Now - DtpFecha.Value).TotalDays) > 1 Then
                DgvInventarios.ReadOnly = True
            End If

            MsgBox("Finalizó el proceso")
            ToolStripStatusLabel7.Text = "Unidades: " & DgvInventarios.Rows.Count()
            ToolStripStatusLabel3.Text = "Inventario mensual"
            tinv = "Mensual"
        End If
    End Sub
End Class