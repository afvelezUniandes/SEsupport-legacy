Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class Querys_pos_administrativo

    Private dt As New DataTable
    Dim sql As String

    Sub ejecutar_query(sql As String, connection As String)
        Dim connectionstring As String = "Server=" + connection + ";Database=SEPos;User Id=sa;Password=123;Connection Timeout=0;"
        'Dim connectionstring As String = "Server=" + connection + ";Database=SEPos;User Id=sa;Password=82KPrz*53.;Connection Timeout=0;"
        Dim conexion As New SqlConnection(connectionstring)
        Dim modifica As New SqlCommand(sql, conexion)
        modifica.CommandTimeout = 0
        conexion.Open()
        modifica.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Function consultar_query(sql As String, connection As String) As DataTable
        Dim connectionstring As String = "Server=" + connection + ";Database=SEPos;User Id=sa;Password=123;Connection Timeout=0;"
        'Dim connectionstring As String = "Server=" + connection + ";Database=SEPos;User Id=sa;Password=82KPrz*53.;Connection Timeout=0;"
        Dim dt As New DataTable
        Try
            Dim conexion As New SqlConnection(connectionstring)
            Dim adapter As New SqlDataAdapter(sql, conexion)
            adapter.Fill(dt)
            Return dt
        Catch ex As Exception
            Return dt
        End Try
    End Function

    Function probar_conexion(connection As String) As Boolean
        Try
            Dim dtprueba As New DataTable
            sql = "select top 1 numero from factura_enc"
            Dim connectionstring As String = "Server=" + connection + "\sqlexpress;Database=SEPos;User Id=sa;Password=123;Connection Timeout=30;"
            'Dim connectionstring As String = "Server=" + connection + ";Database=SEPos;User Id=sa;Password=82KPrz*53.;Connection Timeout=30;"
            Dim conexion As New SqlConnection(connectionstring)
            Dim adapter As New SqlDataAdapter(sql, conexion)
            adapter.Fill(dtprueba)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Function consultar_pos()
        sql = "select * from stage.dbo.ip_pos where activo = 1 order by Descripcion"
        Dim conexion As New connection
        dt = conexion.consultar_query(sql)
        Return dt
    End Function
    Function consultar_datospos(ipos As String)
        sql = "select descripcion,compania from stage.dbo.ip_pos where ip = '" & ipos & "' "
        Dim conexion As New connection
        dt = conexion.consultar_query(sql)
        Return dt
    End Function

    Function consultar_terminal(compania As String, pos As String, term As String)
        sql = "select * from factu" + compania + "..terminales where pos = '" & pos & "' and noterminal = '" & term & "' "
        Dim conexion As New connection
        dt = conexion.consultar_query(sql)
        Return dt
    End Function

    Public Function consultar_ventapos(connection As String, fecin As String, fecfn As String)
        If (fecfn = "") Then
            sql = "select sum(total_pagado-total_devuelta) as total from sepos..factura_enc where convert (varchar, fecha,112) = '" & fecin & "' "
        Else
            sql = "select sum(total_pagado-total_devuelta) as total from sepos..factura_enc where convert (varchar, fecha,112) between '" & fecin & "' and '" & fecfn & "' "
        End If
        dt = consultar_query(sql, connection + "\sqlexpress")
        Return dt
    End Function

    Function consultar_ventaserv(compania As String, term As String, fecin As String, fecfn As String) As DataTable
        Try
            Dim venta As New DataTable
            If (fecfn = "") Then
                sql = "select sum(valor-devuelta) as Total from formaspago_2000 where terminal = '" & term & "' and convert (varchar, FECHACREACION, 112) = '" & fecin & "' "
            Else
                sql = "select sum(valor-devuelta) as Total from formaspago_2000 where terminal = '" & term & "' and convert (varchar, FECHACREACION, 112) between '" & fecin & "' and '" & fecfn & "' "
            End If
            Dim connectionstring As String = "Server=" + "pastse3" + ";Database=factu" + compania + ";User Id=sa;Password=82KPrz*53.;Connection Timeout=30;"
            Dim conexion As New SqlConnection(connectionstring)
            Dim adapter As New SqlDataAdapter(sql, conexion)
            adapter.Fill(venta)
            Return venta
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function consultar_clientes(c_idcliente As String, c_nitcliente As String, connection As String)
        If c_idcliente <> "" Then
            sql = "select * from clientes where id_cliente = '" & c_idcliente & "' "
        ElseIf c_nitcliente <> "" Then
            sql = "select * from clientes where nit = '" & c_nitcliente & "' "
        Else
            sql = "select *, nit + ' || ' + razon_social nombre_completo from clientes "
        End If
        dt = consultar_query(sql, connection + "\sqlexpress")
        Return dt
    End Function

    Public Function consultar_monedas(connection As String)
        sql = "select * from monedas"
        dt = consultar_query(sql, connection + "\sqlexpress")
        Return dt
    End Function

    Public Function consultar_parametros_grales(connection As String)
        sql = "select * from vw_parametros_grales"
        dt = consultar_query(sql, connection + "\sqlexpress")
        Return dt
    End Function

    Public Function consultar_forma_pago(c_numero As String, connection As String)
        If c_numero <> "" Then
            sql = "select cons_fp.codigo_forma_pago, cons_fp.valor_forma_pago, fp.desc_forma_pago " & _
                  "from formas_pago_factura cons_fp inner join formas_pago fp On cons_fp.codigo_forma_pago = fp.codigo_forma_pago " & _
                  "where cons_fp.numero = '" & c_numero & "'"
        Else
            sql = "select * from formas_pago"
        End If
        dt = consultar_query(sql, connection + "\sqlexpress")
        Return dt
    End Function

    Public Function consultar_kardex(c_referencia As String, c_nombre As String, connection As String)
        If c_referencia <> "" Then
            sql = "select * from kardex where visiblePOS = '1' and codigo_referencia = '" & c_referencia & "'"
        ElseIf c_nombre <> "" Then
            sql = "select * from kardex where visiblePOS = '1' and desc_referencia like '%" & c_nombre & "%'"
        Else

            sql = "select * from kardex where visiblePOS = '1'"
        End If
        dt = consultar_query(sql, connection + "\sqlexpress")
        Return dt
    End Function

    Public Function consultar_kardex_l_p(c_referencia As String, c_cod_lista_precios As String, connection As String)
        sql = "select * from lista_precios_ref where codigo_referencia = '" & c_referencia & "' and codigo_tipo_lista_precios = '" & c_cod_lista_precios & "'"
        dt = consultar_query(sql, connection + "\sqlexpress")
        Return dt
    End Function

    Public Function consultar_vw_trm_moneda_maxfecha(c_moneda As String, connection As String)
        sql = "select * from vw_trm_moneda_maxfecha where codigo_moneda = '" & c_moneda & "'"
        dt = consultar_query(sql, connection + "\sqlexpress")
        Return dt
    End Function

    Public Function consultar_hist_trm_moneda(c_moneda As String, connection As String)
        sql = "select m.codigo_moneda, simbolo, desc_moneda, valor_trm, fecha_inicio, fecha_fin, valor_minimo, valor_maximo " & _
              "from monedas m inner join monedas_trm t on m.codigo_moneda = t.codigo_moneda " & _
              "where m.codigo_moneda = '" & c_moneda & "' " & _
              "order by fecha_inicio"
        dt = consultar_query(sql, connection + "\sqlexpress")
        Return dt
    End Function

    Public Sub insertar_trm_moneda(connection As String, moneda As String, valor_trm As String, fecha_inicio As String, fecha_fin As String)
        sql = "insert monedas_trm(codigo_moneda, valor_trm, fecha_inicio, fecha_fin) " & _
              "values('" & moneda & "', '" & valor_trm & "' , '" & fecha_inicio & "', '" & fecha_fin & "')"
        ejecutar_query(sql, connection + "\sqlexpress")
    End Sub

    Public Function consultar_facturas_no_sinc(connection As String)
        sql = "select count(numero) from factura_enc where exportado = 0 "
        dt = consultar_query(sql, connection + "\sqlexpress")
        Return dt
    End Function

    Public Function consultar_factnosin(comp As String, term As String, fecha1 As String, fecha2 As String, connection As String)
        If fecha2 = "" Then
            sql = "select numero, fecha, valor, exportado from sepos..FACTURA_ENC Where NUMERO COLLATE Traditional_Spanish_CI_AS Not In(select NUMERO FROM PASTSE3.FACTU" + comp + ".DBO.FACTURA1_2000 WHERE TERMINAL = '" & term & "') And convert (varchar, fecha,112) = '" & fecha1 & "' "
        Else
            sql = "Select numero, fecha, valor, exportado From sepos..FACTURA_ENC Where NUMERO COLLATE Traditional_Spanish_CI_AS Not In(Select NUMERO FROM PASTSE3.FACTU" + comp + ".DBO.FACTURA1_2000 WHERE TERMINAL = '" & term & "') And convert (varchar, fecha,112) between '" & fecha1 & "' and '" & fecha2 & "' "
        End If
        dt = consultar_query(sql, connection + "\sqlexpress")
        Return dt
    End Function

    Public Function consultar_factura_enc(c_numero As String, connection As String)
        sql = "select * from factura_enc where numero = '" & c_numero & "'"
        dt = consultar_query(sql, connection + "\sqlexpress")
        Return dt
    End Function

    Public Function consultar_factura_det(c_numero As String, connection As String)
        sql = "select * from factura_det where numero = '" & c_numero & "'"
        dt = consultar_query(sql, connection + "\sqlexpress")
        Return dt
    End Function

    Public Function consultar_factura_anterior(c_numero As String, connection As String)
        If c_numero = "" Then
            sql = "select top 1 numero from factura_enc order by numero desc"
        Else
            sql = "select top 1 numero from factura_enc where numero < '" & c_numero & "' order by numero desc "
        End If
        dt = consultar_query(sql, connection + "\sqlexpress")
        Return dt
    End Function

    Public Function consultar_factura_siguiente(c_numero As String, connection As String)
        If c_numero = "" Then
            sql = "select top 1 numero from factura_enc order by numero asc"
        Else
            sql = "select top 1 numero from factura_enc where numero > '" & c_numero & "' order by numero asc "
        End If
        dt = consultar_query(sql, connection + "\sqlexpress")
        Return dt
    End Function

    Public Sub modificar_factura_enc(connection As String, numero As String, anulado As String, valor As String, iva As String, descuento As String, total_pagado As String, total_devuelta As String, codigo_moneda As String, observaciones As String)
        sql = "update factura_enc set anulado = '" & anulado & "', exportado = 0, valor = " & valor & ", iva = " & iva & ", descuento = " & descuento & ", total_pagado = " & total_pagado & ", total_devuelta = " & total_devuelta & ", codigo_moneda = '" & codigo_moneda & "', observaciones = '" & observaciones & "' " & _
              "where numero = '" & numero & "'"
        ejecutar_query(sql, connection + "\sqlexpress")
    End Sub

    Public Sub cambiar_exportado(connection As String, nofactu As String, nf2 As String)
        If nf2 = "" Then
            sql = "update factura_enc set exportado='0' where Numero='" & nofactu & "'"
        Else
            sql = "update factura_enc set exportado='0' where numero between '" & nofactu & "' and '" & nf2 & "'"
        End If
        ejecutar_query(sql, connection + "\sqlexpress")
    End Sub

    Public Sub modificar_factura_det(connection As String, numero As String, codigo_referencia As String, desc_referencia As String, valor_unitario As String, cantidad As String, descuento As String, porcentaje_tarifa_iva As String, anulado As String)
        sql = "insert factura_det(numero, codigo_referencia, desc_referencia, valor_unitario, cantidad, descuento, porcentaje_tarifa_iva, anulado) " & _
              "values('" & numero & "','" & codigo_referencia & "','" & desc_referencia & "','" & valor_unitario & "','" & cantidad & "','" & descuento & "','" & porcentaje_tarifa_iva & "','" & anulado & "')"
        ejecutar_query(sql, connection + "\sqlexpress")
    End Sub

    Public Sub modificar_formas_pago_factura(connection As String, numero As String, codigo_forma_pago As String, valor_forma_pago As String)
        sql = "insert formas_pago_factura(numero, codigo_forma_pago, valor_forma_pago) " & _
              "values('" & numero & "', '" & codigo_forma_pago & "', '" & valor_forma_pago & "')"
        ejecutar_query(sql, connection + "\sqlexpress")
    End Sub

    Public Sub borrar_factura(connection As String, numero As String)
        sql = "delete from formas_pago_factura where numero = '" & numero & "' " & _
              "delete from factura_det where numero = '" & numero & "' "
        ejecutar_query(sql, connection + "\sqlexpress")
    End Sub

    Public Sub borrar_TRM(connection As String, codigo_moneda As String, fecha_inicio As String, fecha_fin As String)
        sql = "delete from monedas_trm where codigo_moneda = '" & codigo_moneda & "' and fecha_inicio = '" & fecha_inicio & "' and fecha_fin = '" & fecha_fin & "'"
        ejecutar_query(sql, connection + "\sqlexpress")
    End Sub

    Function Insertar_log_factura(compania As String, fecha As String, pos As String, numero As String, referencia As String, cantidad As String, codigo_forma_pago As String, totalventa As String, valor_forma_pago As String, devuelta As String, usuario As String, equipo As String, accion As String) As Boolean
        Try
            Dim dtprueba As New DataTable
            sql = "insert factu" + compania + "..log_mod_factura(fecha_modificacion,pos,numero,referencia,cantidad,formapago,totalventa,valorpagado,devuelta,usuario,equipo,accion) " &
              "values('" & fecha & "','" & pos & "','" & numero & "','" & referencia & "','" & cantidad & "', '" & codigo_forma_pago & "', '" & totalventa & "', '" & valor_forma_pago & "', '" & devuelta & "', '" & usuario & "','" & equipo & "','" & accion & "')"
            'Dim connectionstring As String = "Server=" + "pastse3" + "\sqlexpress;Database=SEPos;User Id=sa;Password=123;Connection Timeout=30;"
            Dim connectionstring As String = "Server=" + "pastse3" + ";Database=factu" + compania + ";User Id=sa;Password=82KPrz*53.;Connection Timeout=30;"
            Dim conexion As New SqlConnection(connectionstring)
            Dim adapter As New SqlDataAdapter(sql, conexion)
            adapter.Fill(dtprueba)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
