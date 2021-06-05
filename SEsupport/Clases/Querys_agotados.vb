Public Class Querys_agotados
    Private SQL As String
    Private dt As New DataTable
    Private connection As New connection

    Public Function consultar_agotados(factu As String, fecha As String, bodega As String) As DataTable
        SQL = "select * from " & factu & ".dbo.se_agotados_pos " & _
              "where fecha = '" & fecha & "' and bodega = '" & bodega & "'"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Public Function consultar_usu_bodega(c_usuario As String, factu As String) As DataTable
        SQL = "select R.USUARIO, r.bodega, V.NOMBRE, V.NOMBRE2 " & _
              "from sesupport.dbo.Rel_Usu_bodega r inner join SESUPPORT.DBO.vw_bodegas v on r.bodega = v.bodega " & _
              "where usuario = '" & c_usuario & "' AND FACTU = '" & factu & "' and servidor = 'pastse3'"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Public Function consultar_kardex(c_referencia As String, c_nombre As String, factu As String) As DataTable
        If c_referencia <> "" Then
            SQL = "select referencia, ltrim(rtrim(nombre_producto)) nombre_producto from " & factu & ".dbo.kardex where visiblePOS = '1' and referencia = '" & c_referencia & "'"
        ElseIf c_nombre <> "" Then
            SQL = "select referencia, ltrim(rtrim(nombre_producto)) nombre_producto from " & factu & ".dbo.kardex where visiblePOS = '1' and nombre_producto like '%" & c_nombre & "%'"
        Else
            SQL = "select referencia, ltrim(rtrim(nombre_producto)) nombre_producto from " & factu & ".dbo.kardex where visiblePOS = '1'"
        End If
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Public Sub borrar_agotados(referencia As String, fecha As String, bodega As String, factu As String)
        If referencia = "" Then
            SQL = "delete from " & factu & ".dbo.se_agotados_pos where fecha = '" & fecha & "' and bodega = '" & bodega & "'"
        Else
            SQL = "delete from " & factu & ".dbo.se_agotados_pos where referencia = '" & referencia & "' and fecha = '" & fecha & "'"
        End If
        connection.ejecutar_query(SQL)
    End Sub

    Public Sub ingresar_agotados(referencia As String, descripcion As String, bodega As String, observaciones As String, fecha As String, factu As String)
        SQL = "insert " & factu & ".dbo.se_agotados_pos(referencia, descripcion, bodega, observaciones, fecha) " & _
              "values('" & referencia & "', '" & descripcion & "', '" & bodega & "', '" & observaciones & "', '" & fecha & "')"
        connection.ejecutar_query(SQL)
    End Sub
    Public Function consultar_producto(ref As String) As DataTable
        SQL = "select referencia,nombre_producto,CODBARRAS from factu01..kardex where referencia = '" & ref & "' "
        dt = connection.consultar_query(SQL)
        Return dt
    End Function
End Class
