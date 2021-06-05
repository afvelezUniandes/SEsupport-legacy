Public Class Pos_Administrativo
    Dim consulta_bd As New Querys_pos_administrativo
    Dim consultas As New Funciones_generales
    Dim dtpermiso As New DataTable
    Dim error_referencia As Boolean
    'variables de inicio de pos
    Dim tarifaiva, trm, totalventa, valor_fp, totaldevuelta As Double
    Dim lista_precios As Integer
    Dim limpiando, vf, consulta_referencia, permi, k, x As Boolean
    Dim bodega, terminal, clientenit, moneda, simbolo_trm, fpago, ref, refant, pos, can, cantan, cfpago, compania, fpant, nofactu, fecha As String
    Dim ingreso As Boolean = True
    Dim fec As DateTime = Date.Now

    Private Sub Pos_Administrativo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Configuracion regional y de idioma a español mexico.
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-mx")
        Dim dt_pos As New DataTable
        Usuario.Text = nombre
        limpiando = False
        consulta_referencia = False
        error_referencia = False
        refant = ""
        cantan = ""
        can = ""
        fpant = "01"
        k = False
        x = False
        'Dim consulta_clientes As New DataTable
        'consulta_clientes = consulta_bd.consultar_clientes("", "", conexion_pos)

        Dim consulta_monedas As New DataTable
        consulta_monedas = consulta_bd.consultar_monedas(conexion_pos)

        Dim consulta_gral As New DataTable
        consulta_gral = consulta_bd.consultar_parametros_grales(conexion_pos)

        Dim consulta_formas_pago As New DataTable
        consulta_formas_pago = consulta_bd.consultar_forma_pago("", conexion_pos)

        For Each consulta As DataRow In consulta_gral.Rows
            Select Case consulta.Item("id_parametro").ToString()
                Case 1
                    bodega = consulta.Item("valor").ToString()
                Case 2
                    terminal = consulta.Item("valor").ToString()
                Case 3
                    lista_precios = consulta.Item("valor").ToString()
                Case 4
                    tarifaiva = consulta.Item("desc_valor").ToString()
                Case 5
                    clientenit = consulta.Item("desc_valor").ToString()
                Case 6
                    moneda = consulta.Item("desc_valor").ToString()
            End Select
        Next

        'Me.CmbCliente.DataSource = consulta_clientes
        'Me.CmbCliente.DisplayMember = "nombre_completo"
        'Me.CmbCliente.ValueMember = "id_cliente"
        'Me.CmbCliente.Text = clientenit

        Me.CmbMoneda.DataSource = consulta_monedas
        Me.CmbMoneda.DisplayMember = "desc_moneda"
        Me.CmbMoneda.ValueMember = "codigo_moneda"
        Me.CmbMoneda.Text = moneda

        Me.CmbFormaPago.DataSource = consulta_formas_pago
        Me.CmbFormaPago.ValueMember = "codigo_forma_pago"
        Me.CmbFormaPago.DisplayMember = "desc_forma_pago"
        Me.CmbFormaPago.Text = ""

        LblCambioMonedaExt.Visible = False
        LblTotalVentaExt.Visible = False
        LblSimbolototalExt.Visible = False
        LblSimboloCambioext.Visible = False

        GbRegistro.Select()
        DgvReferencias.Select()
        DgvReferencias.Rows(0).Cells(0).Selected = True

        dt_pos = consulta_bd.consultar_datospos(conexion_pos)   'consultamos la informacion del pos
        pos = dt_pos.Rows(0)(0).ToString()  'capturo el nombre del pos
        compania = dt_pos.Rows(0)(1).ToString()  'capturo la compañia

        fecha = modificarfecha(fec)

        validar_fact_no_sincronizadas()
        limpiar()
        ingreso = False
        ToolStripStatusLabel5.Text = "USUARIO ACTIVO: " & nombre.ToUpper
        ToolStripStatusLabel1.Text = fecha
        TBFecha.Text = fecha
    End Sub

    Public Function modificarfecha(fec As DateTime)
        Dim str As String = fec
        Dim fcam As DateTime = Convert.ToDateTime(String.Format("{0:yyyy-MM-dd HH:mm:ss.fff}", str))
        fecha = Format(fcam, "yyyy-MM-dd HH:mm:ss.fff")
        Return fecha
    End Function

    Private Sub DgvReferencias_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvReferencias.CellValueChanged
        If consulta_referencia = False And ingreso = False Then
            Try
                Dim referencia As String = DgvReferencias.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
                ref = DgvReferencias.Rows(e.RowIndex).Cells(0).Value.ToString()
                If (DgvReferencias.Rows(e.RowIndex).Cells(2).Value Is Nothing) Then
                    DgvReferencias.Rows(e.RowIndex).Cells(2).Value = "1.00"
                End If
                can = DgvReferencias.Rows(e.RowIndex).Cells(2).Value.ToString()
                If e.ColumnIndex = 0 Then
                    If referencia = "+" Then
                        f_kardex_agotados.Show()
                        Return
                    Else
                        Dim consulta As New DataTable
                        consulta = consulta_bd.consultar_kardex(referencia, "", conexion_pos)
                        If consulta.Rows.Count > 0 Then
                            DgvReferencias.Rows(e.RowIndex).Cells("Descripcion").Value = consulta.Rows(0)("desc_referencia")
                            DgvReferencias.Rows(e.RowIndex).Cells("Cantidad").Value = 1
                            Dim tarifaivaespecial = consulta.Rows(0)("tarifa_iva_especial").ToString()
                            If tarifaivaespecial <> "" Then
                                DgvReferencias.Rows(e.RowIndex).Cells("iva").Value = tarifaivaespecial
                                tarifaivaespecial = Nothing
                            Else
                                DgvReferencias.Rows(e.RowIndex).Cells("iva").Value = tarifaiva
                            End If
                            Dim valor_unitario As New DataTable
                            valor_unitario = consulta_bd.consultar_kardex_l_p(referencia, lista_precios, conexion_pos)
                            Dim valor_uni As Double = 0
                            If valor_unitario.Rows.Count <> 0 Then
                                valor_uni = valor_unitario.Rows(0)("valor").ToString()
                            End If
                            DgvReferencias.Rows(e.RowIndex).Cells("valor_unitario").Value = valor_uni
                        Else
                            MsgBox("NO EXISTE LA REFERENCIA INGRESADA", MsgBoxStyle.Critical)
                            DgvReferencias.Rows(e.RowIndex).Cells("Referencia").Value = ""
                            DgvReferencias.Rows(e.RowIndex).Cells("Descripcion").Value = ""
                            DgvReferencias.Rows(e.RowIndex).Cells("Cantidad").Value = "1"
                            DgvReferencias.Rows(e.RowIndex).Cells("valor_unitario").Value = "0"
                            DgvReferencias.Rows(e.RowIndex).Cells("iva").Value = "0"
                            DgvReferencias.Rows(e.RowIndex).Cells("descuento").Value = "0"
                            DgvReferencias.Rows(e.RowIndex).Cells("subtotal").Value = "0"
                        End If
                    End If
                End If

                If e.ColumnIndex = 2 Or e.ColumnIndex = 3 Or e.ColumnIndex = 4 Or e.ColumnIndex = 6 Then
                    Dim valor As Double = Math.Round(DgvReferencias.Rows(e.RowIndex).Cells("Cantidad").Value * DgvReferencias.Rows(e.RowIndex).Cells("valor_unitario").Value, 2)
                    Dim valor_descuento As Double = Math.Round(valor * DgvReferencias.Rows(e.RowIndex).Cells("descuento").Value / 100, 2)
                    Dim valor_iva As Double = Math.Round((valor - valor_descuento) * DgvReferencias.Rows(e.RowIndex).Cells("iva").Value / 100, 2)
                    DgvReferencias.Rows(e.RowIndex).Cells("subtotal").Value = Math.Round(valor + valor_iva - valor_descuento, 0)

                    DgvReferencias.Rows(e.RowIndex).Cells("totaliva").Value = valor_iva
                    DgvReferencias.Rows(e.RowIndex).Cells("totaldescuento").Value = valor_descuento
                    Dim total = totalizar("subtotal") 'totalizamos
                    Dim totaliva = totalizar("totaliva")
                    TxbTotalIva.Text = Format(Math.Round(totaliva), "#,##0")
                    Txbtotal_subtotal.Text = Format(total - Math.Round(totaliva), "#,##0")
                End If

                If totalizar("totalpagado") = 0 Then
                    LblCambioMonedaCol.Text = 0
                    LblCambioMonedaExt.Text = 0
                Else
                    totalizar("formaspago")
                End If
            Catch ex As Exception
                MsgBox("ERROR AL INGRESAR LA REFERENCIA, EL ERROR MOSTRADO ES EL SIGUIENTE: " + ex.Message)
            End Try
            'reingreso_form = False
            k = True
        End If
    End Sub

    Private Function totalizar(tipo As String)
        Dim total As Double
        If tipo = "subtotal" Then 'totalizamos los cmabios en las referencias
            Dim resul = DgvReferencias.Rows.Cast(Of DataGridViewRow)().Sum(Function(x) Convert.ToDouble(x.Cells("subtotal").Value)) 'sumamos
            total = resul
            LblTotalVentaCol.Text = Format(CDbl(total), "#,##0")
            If CmbMoneda.SelectedIndex.ToString() <> 0 Then
                LblTotalVentaExt.Text = Format(Math.Round(CDbl(total / trm), 2), "#,##0.00")
            End If

        ElseIf tipo = "totaliva" Then 'totalizamos el iva
            Dim resul = DgvReferencias.Rows.Cast(Of DataGridViewRow)().Sum(Function(x) Convert.ToDouble(x.Cells("totaliva").Value)) 'sumamos
            total = resul
        ElseIf tipo = "totaldescuento" Then 'totalizamos el iva
            Dim resul = DgvReferencias.Rows.Cast(Of DataGridViewRow)().Sum(Function(x) Convert.ToDouble(x.Cells("totaldescuento").Value)) 'sumamos
            total = resul
        ElseIf tipo = "formaspago" Then 'totalizamos cambios en formaspago
            Dim resul = DgvFormaPago.Rows.Cast(Of DataGridViewRow)().Sum(Function(x) Convert.ToDouble(x.Cells("valor").Value)) 'sumamos
            total = resul
            If LblTotalVentaCol.Text = "" Then
                LblTotalVentaCol.Text = 0
            End If
            If CmbMoneda.SelectedIndex.ToString() = 0 Then
                LblCambioMonedaCol.Text = (total - CDbl(LblTotalVentaCol.Text)).ToString("C")
            Else
                LblCambioMonedaExt.Text = Format(Math.Round(CDbl((total - CDbl(LblTotalVentaExt.Text))), 2), "#,##0.00")
                LblCambioMonedaCol.Text = Format(CDbl(LblCambioMonedaExt.Text * trm), "#,##0")
            End If

        ElseIf tipo = "totalpagado" Then 'totalizamos el total pagado por el cliente
            Dim resul = DgvFormaPago.Rows.Cast(Of DataGridViewRow)().Sum(Function(x) Convert.ToDouble(x.Cells("valor").Value)) 'sumamos
            total = resul
        ElseIf tipo = "totalpagado_col" Then 'totalizamos el total pagado por el cliente
            Dim resul = DgvFormaPago.Rows.Cast(Of DataGridViewRow)().Sum(Function(x) Convert.ToDouble(x.Cells("valor").Value)) 'sumamos
            total = resul
            If CmbMoneda.SelectedIndex.ToString() <> 0 Then
                total = Math.Round(total * trm, 0)
            End If
        End If
        Return total
    End Function

    Private Sub BtnGuardarPago_Click(sender As Object, e As EventArgs) Handles BtnGuardarPago.Click
        Dim ing_guardar As Boolean = False
        For Each row As DataGridViewRow In DgvReferencias.Rows
            If row.Cells("Referencia").Value <> "" Then
                ing_guardar = True
            End If
        Next
        Dim encontrado As Boolean = False
        Dim total As Double
        BtnGuardarPago.Enabled = False
        If ing_guardar = True Then
            If TxbValorFormaPago.Text = "" And DgvFormaPago.Rows.Count = 0 Then
                MsgBox("No ha ingresado valor", MsgBoxStyle.Critical)
            Else
                For Each row As DataGridViewRow In DgvFormaPago.Rows 'en caso de que exista la forma de pago, la reemplaza
                    If row.Cells("cod_forma_pago").Value = CmbFormaPago.SelectedValue.ToString() And TxbValorFormaPago.Text <> "" Then
                        row.Cells("valor").Value = TxbValorFormaPago.Text
                        total = totalizar("formaspago")
                        encontrado = True
                    End If
                Next
                If encontrado = False And TxbValorFormaPago.Text <> "" Then
                    DgvFormaPago.Rows.Add()
                    DgvFormaPago.Rows(DgvFormaPago.Rows.Count - 1).Cells("cod_forma_pago").Value = CmbFormaPago.SelectedValue.ToString()
                    DgvFormaPago.Rows(DgvFormaPago.Rows.Count - 1).Cells("Formapago").Value = CmbFormaPago.Text.ToString()
                    DgvFormaPago.Rows(DgvFormaPago.Rows.Count - 1).Cells("valor").Value = TxbValorFormaPago.Text
                    total = totalizar("formaspago")
                    TxbValorFormaPago.Text = ""
                    CmbFormaPago.SelectedValue = 0
                    CmbFormaPago.SelectedItem = 0
                    CmbFormaPago.SelectedIndex = 0
                End If
            End If
        Else
            MsgBox("No existe ninguna referencia ingresada, primero debe ingresar las referencias para que se active el proceso de guardar el pago", MsgBoxStyle.Critical)
            TxbValorFormaPago.Text = ""
            GbRegistro.Select()
            DgvReferencias.Select()
            DgvReferencias.Rows(0).Cells(0).Selected = True
        End If
        BtnGuardarPago.Enabled = True

        TxbValorFormaPago.Text = ""
    End Sub

    Private Sub CmbMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMoneda.SelectedIndexChanged
        If consulta_referencia = False And ingreso = False Then
            Try
                If CmbMoneda.SelectedValue.ToString() = 1 Then
                    LblCambioMonedaExt.Visible = False
                    LblTotalVentaExt.Visible = False
                    LblSimboloCambioext.Visible = False
                    LblSimbolototalExt.Visible = False
                Else
                    LblCambioMonedaExt.Visible = True
                    LblTotalVentaExt.Visible = True
                    LblSimboloCambioext.Visible = True
                    LblSimbolototalExt.Visible = True

                    Dim consultatrm As New DataTable
                    consultatrm = consulta_bd.consultar_vw_trm_moneda_maxfecha(CmbMoneda.SelectedValue.ToString(), conexion_pos)
                    LblSimbolototalExt.Text = consultatrm.Rows(0)("simbolo")
                    LblSimboloCambioext.Text = consultatrm.Rows(0)("simbolo")
                    trm = consultatrm.Rows(0)("valor_trm")

                    LblTotalVentaExt.Text = Math.Round(CDbl(LblTotalVentaCol.Text) / trm, 2)
                    LblCambioMonedaExt.Text = Math.Round(CDbl(LblCambioMonedaCol.Text) / trm, 2)

                End If
                GbRegistro.Select()
                DgvReferencias.Select()
                DgvReferencias.Rows(0).Cells(0).Selected = True
            Catch ex As Exception
                MsgBox("No existe TRM para la moneda indicada", MsgBoxStyle.Critical)
                CmbMoneda.SelectedIndex = 0
            End Try
        End If
    End Sub

    Private Sub Pasar_a_formaspago()
        CmbFormaPago.SelectedItem = 1
        TxbValorFormaPago.Focus()
    End Sub

    Private Sub GbxRelPagosVenta_Enter(sender As Object, e As EventArgs) Handles GbxRelPagosVenta.Enter
        Me.AcceptButton = BtnGuardarPago
        GbxRelPagosVenta.ForeColor = Color.Red
    End Sub

    Private Sub GbxNumero_Enter(sender As Object, e As EventArgs) Handles GbxNumero.Enter
        Me.AcceptButton = BtnNumero
    End Sub

    Public Sub limpiar()
        limpiando = True
        Txbnumero.Text = ""
        TxbObservaciones.Text = ""
        GbTotal.Text = ""
        GbxCambio.Text = ""
        CmbCliente.Text = clientenit

        CmbFormaPago.SelectedValue = 0
        CmbFormaPago.SelectedItem = 0
        CmbFormaPago.SelectedIndex = 0

        CmbMoneda.Text = moneda
        TxbValorFormaPago.Text = ""

        DgvFormaPago.Rows.Clear()
        DgvReferencias.Rows.Clear()

        LblCambioMonedaExt.Visible = False
        LblTotalVentaExt.Visible = False
        LblSimbolototalExt.Visible = False
        LblSimboloCambioext.Visible = False

        TxbObservaciones.Enabled = False
        GbRegistro.Enabled = False
        GbTotal.Enabled = False
        GbxCambio.Enabled = False
        GbxMoneda.Enabled = False
        GbxRelPagosVenta.Enabled = False
        CmbFormaPago.Enabled = False
        TxbValorFormaPago.Enabled = False
        BtnGuardarPago.Enabled = False
        CmbCliente.Enabled = False
        ChkAnulado.Enabled = False

        BtnAtras.Enabled = True
        BtnLimpiar.Enabled = True
        BtnSiguiente.Enabled = True
        BtnModificar.Enabled = False
        BtnCancelar.Enabled = False
        BtnGuardarCambio.Enabled = False
        Txbnumero.Select()
        Txbnumero.Focus()

        limpiando = False

    End Sub

    Private Sub deshabilitar()
        BtnAtras.Enabled = True
        BtnLimpiar.Enabled = True
        BtnSiguiente.Enabled = True
        BtnModificar.Enabled = True
        BtnCancelar.Enabled = False
        BtnGuardarCambio.Enabled = False
        Txbnumero.Select()
        Txbnumero.Focus()
    End Sub

    Public Sub validar_fact_no_sincronizadas()
        Dim consulta_facturas As New DataTable
        consulta_facturas = consulta_bd.consultar_facturas_no_sinc(conexion_pos)
        ToolStripStatusLabel3.Text = "FACTURAS NO SINCRONIZADAS : " & consulta_facturas.Rows.Count()
        ToolStripStatusLabel3.ForeColor = Color.Blue
    End Sub

    Private Sub SincronizadorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Sincronizador.Show()
        Me.Close()
    End Sub

    Private Sub SEpos_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.F12 Then
            Pasar_a_formaspago()
        Else
            If e.KeyValue = Keys.Delete Then
                MsgBox("sos un putito!!!", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub DgvFormaPago_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvFormaPago.CellContentClick
        If e.ColumnIndex = 0 Then
            fpant = DgvFormaPago.Rows(0).Cells("cod_forma_pago").Value
            nofactu = Txbnumero.Text
            fecha = modificarfecha(fecha)
            vf = consulta_bd.Insertar_log_factura(compania, fecha, pos, nofactu.ToUpper, "", "", fpant, "", DgvFormaPago.Rows(0).Cells("valor").Value, "", nombre, My.Computer.Name, "Eliminacion")
            DgvFormaPago.Rows.RemoveAt(e.RowIndex)
            totalizar("formaspago")
            TxbValorFormaPago.Text = ""
            TxbValorFormaPago.Focus()
            k = False
            x = True
        End If
    End Sub

    Private Sub CmbFormaPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbFormaPago.SelectedIndexChanged
        TxbValorFormaPago.Text = ""
        TxbValorFormaPago.Focus()
    End Sub

    Private Sub BtnNumero_Click(sender As Object, e As EventArgs) Handles BtnNumero.Click
        If Txbnumero.Text = "" Then
            MsgBox("No has ingresado un número de factura a consultar", MsgBoxStyle.Critical)
        Else
            consultar_x_numero()
            permi = permuser()
            If (permi = True) Then
                BtnModificar.Enabled = True
            Else
                BtnModificar.Enabled = False
            End If
        End If
    End Sub

    Sub consultar_x_numero()

        consulta_referencia = True
        GbRegistro.Enabled = False
        GbTotal.Enabled = False
        GbxCambio.Enabled = False
        GbxMoneda.Enabled = False
        DgvFormaPago.Enabled = False
        CmbFormaPago.Enabled = False
        TxbValorFormaPago.Enabled = False
        BtnGuardarPago.Enabled = False
        TxbObservaciones.Enabled = False
        CmbCliente.Enabled = False
        ChkAnulado.Enabled = False
        TBFecha.Enabled = False

        DgvFormaPago.Rows.Clear()
        DgvReferencias.Rows.Clear()

        Dim consulta_enc As New DataTable
        consulta_enc = consulta_bd.consultar_factura_enc(Txbnumero.Text, conexion_pos)

        If consulta_enc.Rows.Count > 0 Then
            BtnModificar.Enabled = True

            Dim consulta_det As New DataTable
            consulta_det = consulta_bd.consultar_factura_det(Txbnumero.Text, conexion_pos)

            Dim consulta_fp As New DataTable
            consulta_fp = consulta_bd.consultar_forma_pago(Txbnumero.Text, conexion_pos)

            CmbCliente.SelectedValue = consulta_enc.Rows(0)("id_cliente")
            CmbMoneda.SelectedValue = consulta_enc.Rows(0)("codigo_moneda")
            fecha = consulta_enc.Rows(0)("fecha").ToString()
            TBFecha.Text = fecha
            Dim fila As Integer = 0
            For Each row As DataRow In consulta_det.Rows
                Dim subtotal As Double = row.Item("cantidad") * row.Item("valor_unitario")
                Dim totaldescuento As Double = subtotal * row.Item("descuento") / 100
                Dim totaliva As Double = (subtotal - totaldescuento) * row.Item("porcentaje_tarifa_iva") / 100
                DgvReferencias.Rows.Add()
                DgvReferencias.Rows(fila).Cells("Referencia").Value = row.Item("codigo_referencia")
                DgvReferencias.Rows(fila).Cells("Descripcion").Value = row.Item("desc_referencia")
                DgvReferencias.Rows(fila).Cells("Cantidad").Value = row.Item("cantidad")
                DgvReferencias.Rows(fila).Cells("valor_unitario").Value = row.Item("valor_unitario")
                DgvReferencias.Rows(fila).Cells("descuento").Value = row.Item("descuento")
                DgvReferencias.Rows(fila).Cells("totaldescuento").Value = totaldescuento
                DgvReferencias.Rows(fila).Cells("iva").Value = row.Item("porcentaje_tarifa_iva")
                DgvReferencias.Rows(fila).Cells("totaliva").Value = totaliva

                Dim valor As Double = Math.Round(DgvReferencias.Rows(fila).Cells("Cantidad").Value * DgvReferencias.Rows(fila).Cells("valor_unitario").Value, 2)
                Dim valor_descuento As Double = Math.Round(valor * DgvReferencias.Rows(fila).Cells("descuento").Value / 100, 2)
                Dim valor_iva As Double = Math.Round((valor - valor_descuento) * DgvReferencias.Rows(fila).Cells("iva").Value / 100, 2)
                DgvReferencias.Rows(fila).Cells("subtotal").Value = Math.Round(valor + valor_iva - valor_descuento, 0)

                fila = fila + 1
            Next

            fila = 0
            For Each row As DataRow In consulta_fp.Rows
                DgvFormaPago.Rows.Add()
                DgvFormaPago.Rows(fila).Cells("cod_forma_pago").Value = row.Item("codigo_forma_pago")
                DgvFormaPago.Rows(fila).Cells("formapago").Value = row.Item("desc_forma_pago")
                DgvFormaPago.Rows(fila).Cells("valor").Value = row.Item("valor_forma_pago")
                fila = fila + 1
            Next

            LblTotalVentaCol.Text = Format((consulta_enc.Rows(0)("valor") + consulta_enc.Rows(0)("iva") - consulta_enc.Rows(0)("descuento")), "#,##0")
            LblCambioMonedaCol.Text = Format((consulta_enc.Rows(0)("total_devuelta")), "#,##0")
            TxbObservaciones.Text = consulta_enc.Rows(0)("observaciones").ToString()
            If consulta_enc.Rows(0)("anulado") = 0 Then
                ChkAnulado.Checked = False
            Else
                ChkAnulado.Checked = True
            End If

            consulta_referencia = False
        Else
            MsgBox("Numero no encontrado", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub DgvReferencias_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DgvReferencias.RowsRemoved
        If limpiando = False Then
            Dim total = totalizar("subtotal") 'totalizamos
        End If
    End Sub

    Private Sub LblTotalVentaCol_TextChanged(sender As Object, e As EventArgs) Handles LblTotalVentaCol.TextChanged
        Dim total = totalizar("formaspago")
    End Sub

    Private Sub TxbValorFormaPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbValorFormaPago.KeyPress
        If CmbMoneda.SelectedIndex.ToString() = 0 Then
            Try
                Dim texto As String = TxbValorFormaPago.Text & e.KeyChar.ToString()

                TxbValorFormaPago.Text = Format(CDbl(texto), "#,##0")

                e.KeyChar = ""
                TxbValorFormaPago.Select(TxbValorFormaPago.Text.Length, 0)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub GbObservaciones_Enter(sender As Object, e As EventArgs) Handles GbObservaciones.Enter
        Me.AcceptButton = Nothing
    End Sub

    Private Sub GbxRelPagosVenta_Leave(sender As Object, e As EventArgs) Handles GbxRelPagosVenta.Leave
        GbxRelPagosVenta.ForeColor = Color.Black
    End Sub

    Private Sub BtnAtras_Click(sender As Object, e As EventArgs) Handles BtnAtras.Click
        Dim dt_consulta As DataTable
        dt_consulta = consulta_bd.consultar_factura_anterior(Txbnumero.Text, conexion_pos)
        Try
            Txbnumero.Text = dt_consulta.Rows(0)(0).ToString()
            consultar_x_numero()
        Catch ex As Exception
        End Try
        permi = permuser()
        If (permi = True) Then
            BtnModificar.Enabled = True
        Else
            BtnModificar.Enabled = False
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        limpiar()
    End Sub

    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click
        Dim dt_consulta As DataTable
        dt_consulta = consulta_bd.consultar_factura_siguiente(Txbnumero.Text, conexion_pos)
        Try
            Txbnumero.Text = dt_consulta.Rows(0)(0).ToString()
            consultar_x_numero()
        Catch ex As Exception
        End Try
        permi = permuser()
        If (permi = True) Then
            BtnModificar.Enabled = True
        Else
            BtnModificar.Enabled = False
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        TxbObservaciones.Enabled = True
        GbRegistro.Enabled = True
        GbTotal.Enabled = True
        GbxCambio.Enabled = True
        GbxMoneda.Enabled = True
        GbxRelPagosVenta.Enabled = True
        CmbFormaPago.Enabled = True
        TxbValorFormaPago.Enabled = True
        BtnGuardarPago.Enabled = True
        DgvFormaPago.Enabled = True
        CmbCliente.Enabled = True
        ChkAnulado.Enabled = True
        BtnAtras.Enabled = False
        BtnLimpiar.Enabled = False
        BtnSiguiente.Enabled = False
        BtnModificar.Enabled = False
        BtnCancelar.Enabled = True
        BtnGuardarCambio.Enabled = True
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim i As Integer = MsgBox("VA A CANCELAR EL PROCESO SIN GUARDAR CAMBIOS", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo)
        If i = 6 Then
            limpiar()
        End If
    End Sub

    Private Sub DgvReferencias_KeyDown(sender As Object, e As KeyEventArgs) Handles DgvReferencias.KeyDown
        Dim pa As Integer
        If (e.KeyCode = Keys.Delete) Then
            If (DgvReferencias.Rows.Count > 0) Then
                pa = DgvReferencias.CurrentRow.Index
                ref = DgvReferencias.Rows(pa).Cells(0).Value
                cantan = DgvReferencias.Rows(pa).Cells(2).Value
                If (DgvReferencias.Rows.Count <= 0) Then
                    DgvFormaPago.Rows.Clear()
                End If
                nofactu = Txbnumero.Text
                fecha = modificarfecha(fecha)
                consulta_bd.Insertar_log_factura(compania, fecha, pos, nofactu.ToUpper, ref, cantan, "", LblTotalVentaCol.Text, valor_fp.ToString, totaldevuelta, nombre, My.Computer.Name, "Eliminacion")
                vf = True
                k = False
                fpago = ""
            End If
        Else
            If (e.KeyCode = Keys.Enter) Then
                If (refant = "") Then
                    k = True
                Else
                    If (ref <> refant) Then
                        k = True
                    End If
                End If
            Else
                If (e.KeyCode = Keys.Right) Then
                    If (refant = "") Then
                        k = True
                    Else
                        If (ref <> refant) Then
                            k = True
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BtnGuardarCambio_Click(sender As Object, e As EventArgs) Handles BtnGuardarCambio.Click
        Dim dt_pos As New DataTable
        Dim valor As Double = CDbl(LblTotalVentaCol.Text)
        Dim totalventa As Double = CDbl(LblTotalVentaCol.Text)
        'Dim idcliente As Integer = CmbCliente.SelectedValue.ToString()            
        Dim totaliva As Double = Math.Round(totalizar("totaliva"), 2)
        Dim totaldescuento As Double = totalizar("totaldescuento")
        Dim totalpagado As Double = totalizar("totalpagado_col")
        Dim anulado As Integer

        If ChkAnulado.Checked = True Then
            anulado = 1
        Else
            anulado = 0
        End If
        totalventa = CDbl(LblTotalVentaCol.Text)
        valor = valor + totaldescuento - totaliva
        totaldevuelta = (totalpagado - totalventa)
        If (totaldevuelta < 0) Then
            MsgBox("El valor de la devuelta es erróneo. Verifique que el detalle de los productos este correcto.", MsgBoxStyle.Critical)
        Else
            Try
                'inserto encabezado
                consulta_bd.modificar_factura_enc(conexion_pos, Txbnumero.Text, anulado, valor, totaliva, totaldescuento, totalpagado, (totalpagado - totalventa), CmbMoneda.SelectedValue.ToString(), TxbObservaciones.Text)

                'borro el detalle y las formas de pago para insertar las nuevas
                consulta_bd.borrar_factura(conexion_pos, Txbnumero.Text)

                'inserto detalle
                For Each row As DataGridViewRow In DgvReferencias.Rows
                    If IsNumeric(row.Cells("Referencia").Value) = True Then
                        Dim descuento As Double
                        If IsNothing(row.Cells("descuento").Value) = True Then
                            descuento = 0
                        Else
                            descuento = row.Cells("descuento").Value.ToString()
                        End If
                        consulta_bd.modificar_factura_det(conexion_pos, Txbnumero.Text, row.Cells("Referencia").Value.ToString(), row.Cells("Descripcion").Value.ToString(), row.Cells("valor_unitario").Value.ToString(), row.Cells("Cantidad").Value.ToString(), descuento, row.Cells("iva").Value.ToString(), 0)
                    End If
                Next
                If (DgvReferencias.Rows.ToString.Equals("")) Then
                    MsgBox("La factura se encuentra vacia", MsgBoxStyle.Critical)
                Else
                    cfpago = DgvFormaPago.Rows.Count
                    If (cfpago <= 0) Then
                        MsgBox("La forma de pago no puede estar vacía. Seleccione una opción válida", MsgBoxStyle.Critical)
                    Else
                        'inserto formaspago
                        For Each row As DataGridViewRow In DgvFormaPago.Rows

                            If CmbMoneda.SelectedIndex.ToString() = 0 Then
                                valor_fp = row.Cells("valor").Value.ToString()
                            Else
                                valor_fp = Math.Round(CDbl(row.Cells("valor").Value.ToString()) * trm, 0)
                            End If
                            consulta_bd.modificar_formas_pago_factura(conexion_pos, Txbnumero.Text, row.Cells("cod_forma_pago").Value.ToString(), valor_fp)

                            fpago = row.Cells("cod_forma_pago").Value.ToString()
                        Next
                        'se inserta la modificacion en la tabla log
                        nofactu = Txbnumero.Text
                        fecha = modificarfecha(fecha)
                        If (k = False) Then
                            If (x = True) Then
                                vf = consulta_bd.Insertar_log_factura(compania, fecha, pos, nofactu.ToUpper, "", "", fpago, totalventa, valor_fp.ToString, totaldevuelta, nombre, My.Computer.Name, "Insercion")
                            End If
                        Else
                            If (ref <> refant) Then
                                If (x = False) Then
                                    vf = consulta_bd.Insertar_log_factura(compania, fecha, pos, nofactu.ToUpper, ref, can, fpago, totalventa, valor_fp.ToString, totaldevuelta, nombre, My.Computer.Name, "Insercion")
                                Else
                                    If (fpago = "01") Then
                                        vf = consulta_bd.Insertar_log_factura(compania, fecha, pos, nofactu.ToUpper, ref, can, "", "", "", "", nombre, My.Computer.Name, "Insercion")
                                    Else
                                    End If
                                End If
                            Else
                                vf = consulta_bd.Insertar_log_factura(compania, fecha, pos, nofactu.ToUpper, "", "", fpago, "", valor_fp.ToString, totaldevuelta, nombre, My.Computer.Name, "Insercion")
                            End If
                        End If
                        If (vf = True) Then
                            MsgBox("Se modificó correctamente la factura. Se vera reflejada en GyG la proxima vez que el punto de venta sincronice", MsgBoxStyle.Information)
                        Else
                            MsgBox("Los cambios fueron guardados pero con algunos errores", MsgBoxStyle.Critical)
                        End If
                        deshabilitar()
                    End If
                End If
            Catch ex As Exception
                MsgBox("SURGIO UN ERROR EN EL PROCESO DE GRABACION DE LA FACTURA. INTENTE NUEVAMENTE GRABAR, EN CASO DE VOLVER A GENERAR EL ERROR CIERRE EL POS Y VUELVALO A ABRIR.  EL ERROR ES: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
        refant = ""
        cantan = ""
        fpant = ""
    End Sub

    Public Function permuser()
        Dim per As Boolean = False
        dtpermiso = consultas.cons_permisos(user, "6")
        For Each row As DataRow In dtpermiso.Rows
            If dtpermiso.Rows(0)(2).ToString() = 2 Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub ModificarMonedaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarMonedaToolStripMenuItem.Click
        Me.Enabled = False
        Administrar_TRM.Show()
    End Sub
End Class