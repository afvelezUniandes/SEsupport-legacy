Public Class Querys_inventarios
    Private SQL As String
    Private dt As New DataTable
    Private connection As New connection

    Function cons_bodega(q_factu As String, q_usuario As String) As DataTable
        If q_usuario = "" Then
            If q_factu = "" Then
                SQL = "SELECT ltrim(rtrim(bodega)) bodega, ltrim(rtrim(nombre)) nombre, ltrim(rtrim(nombre2)) nombre2, ltrim(rtrim(factu)) factu, ltrim(rtrim(servidor)) servidor " & _
                      "FROM vw_bodegas ORDER BY FACTU"
            Else
                SQL = "SELECT ltrim(rtrim(bodega)) bodega, ltrim(rtrim(nombre)) nombre, ltrim(rtrim(nombre2)) nombre2, ltrim(rtrim(factu)) factu, ltrim(rtrim(servidor)) servidor " & _
                      "FROM vw_bodegas where factu = '" & q_factu & "' ORDER BY FACTU"
            End If
        Else
            SQL = "SELECT ltrim(rtrim(b.bodega)) bodega, ltrim(rtrim(nombre)) nombre, ltrim(rtrim(nombre2)) nombre2, ltrim(rtrim(factu)) factu, ltrim(rtrim(servidor)) servidor " & _
                  "FROM vw_bodegas b inner join rel_usu_bodega rel on b.bodega = rel.bodega where factu = '" & q_factu & "' and rel.usuario = '" & q_usuario & "' ORDER BY FACTU"
        End If
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function borrar_inv(q_factu As String, q_bodega As String, q_mes As String, q_fecha As String)
        SQL = "delete from " & q_factu & "..SE_conteo_inventarios where mes = '" & q_mes & "' and convert (varchar, fecha_generacion,112) = '" & q_fecha & "' and bodega = '" & q_bodega & "'"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_compania(q_nom As String)
        SQL = "select factu from vw_bodegas where nombre like '" & q_nom & "' "
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_pastse(q_factu As String, q_bodega As String)
        SQL = "select * from vw_bodegas where factu = '" & q_factu & "' and bodega = '" & q_bodega & "'"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_pastse_factu_bod(q_nombre As String)
        SQL = "select * from vw_bodegas where nombre2 = '" & q_nombre & "'"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_conteo(q_bodega As String, q_factu As String, q_pastse As String, q_mes As String, q_fecha As String)
        SQL = "execute cons_conteo '" & q_pastse & "','" & q_factu & "','" & q_bodega & "','" & q_mes & "', '" & q_fecha & "'"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_tipus()
        SQL = "execute cons_usuarios"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_valorizado(q_bodega As String, q_factu As String, q_pastse As String, q_mes As String, q_fecha As String)
        SQL = "execute valor_conteo_referencia '" & q_pastse & "','" & q_factu & "','" & q_bodega & "','" & q_mes & "', '" & q_fecha & "', 1"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_cambiar(q_factu As String, q_bodega As String, q_fecha As String, q_tipo As String)
        SQL = "execute cam_inv '" & q_factu & "', '" & q_bodega & "', '" & q_fecha & "', '" & q_tipo & "'"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function
    Function buscardato(q_factu As String)
        SQL = "execute cant_inv '" & q_factu & "'"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Sub del_inv(q_factu As String, q_mes As String, q_bodega As String, q_tin As String, q_fecha As String, q_usuario As String, q_accion As String, q_fecr As String)
        SQL = "execute llenar_log '" & q_factu & "', '" & q_mes & "', '" & q_bodega & "','" & q_tin & "', '" & q_fecha & "', '" & q_usuario & "','" & q_accion & "','" & q_fecr & "'"
        connection.ejecutar_query(SQL)
    End Sub

    Sub eliminar_ref(q_bodega As String, q_fecha As String, q_factu As String, q_mes As String)
        SQL = "execute borrar_inv '" & q_factu & "', '" & q_bodega & "', '" & q_fecha & "', '" & q_mes & "'"
        connection.ejecutar_query(SQL)
    End Sub

    Sub nuevo_inventario(q_bodega As String, q_factu As String, q_pastse As String, q_mes As String, q_fecha As String, q_tipo As String, q_usuario As String)
        SQL = "execute ins_nuevo_conteo '" & q_pastse & "','" & q_factu & "','" & q_bodega & "','" & q_mes & "', '" & q_fecha & "', '" & q_tipo & "', '" & q_usuario & "'"
        connection.ejecutar_query(SQL)
    End Sub

    Sub modifica_inventario(q_bodega As String, q_factu As String, q_pastse As String, q_mes As String, q_fecha As String, q_usuario As String, q_referencia As String, q_conteo As Double)
        SQL = "execute mod_conteo '" & q_pastse & "','" & q_factu & "','" & q_bodega & "', '" & q_referencia & "', '" & q_mes & "', '" & q_fecha & "', '" & q_conteo & "', '" & q_usuario & "'"
        connection.ejecutar_query(SQL)
    End Sub

    Sub ajuste_inventarios(q_bodega As String, q_factu As String, q_pastse As String, q_mes As String, q_fecha As String)
        SQL = "execute generar_ajuste_inv '" & q_bodega & "', '" & q_factu & "', '" & q_pastse & "', '" & q_mes & "', '" & q_fecha & "'"
        connection.ejecutar_query(SQL)
    End Sub

    Sub actualiza_saldo(q_bodega As String, q_factu As String, q_pastse As String, q_mes As String, q_fecha As String)
        SQL = "execute se_act_teorico_ajuste_inv '" & q_bodega & "', '" & q_factu & "', '" & q_pastse & "', '" & q_mes & "', '" & q_fecha & "'"
        connection.ejecutar_query(SQL)
    End Sub

    Sub cambia_tipo_inventario(q_bodega As String, q_factu As String, q_pastse As String, q_mes As String, q_fecha As String, q_tipo As String, q_usuario As String)
        SQL = "execute mod_tipo_conteo '" & q_pastse & "','" & q_factu & "','" & q_bodega & "','" & q_mes & "', '" & q_fecha & "', '" & q_tipo & "', '" & q_usuario & "'"
        connection.ejecutar_query(SQL)
    End Sub
    Friend Function cons_cambiar(factu As String, v1 As String, v2 As String) As DataTable
        Throw New NotImplementedException()
    End Function
End Class

