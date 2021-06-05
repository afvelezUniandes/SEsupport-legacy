Imports System.Data
Imports System.Data.SqlClient
Public Class Querys_quejas
    Private SQL As String
    Private dt As New DataTable
    Private connection As New connection

    Function cons_hist_queja_usu_feini_fefin(q_usuario As String, q_fechaini As Date, q_fechafin As Date)
        SQL = "select * from vw_hist_quej_conf where usuario = '" & q_usuario & "' and fecha between '" & q_fechaini & "' and '" & q_fechafin & "'"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_hist_queja_usu_num(q_usuario As String, q_numero As String)
        SQL = "select * from vw_hist_quej_conf where usuario = '" & q_usuario & "' and idhist = '" & q_numero & "'"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_numero_que(q_usuario As String)
        SQL = "select max(idhist) from hist_quej_conf where usuario = '" & q_usuario & "'"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_tipo_queja()
        SQL = "select * from tipo_queja"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_tipo_soporte()
        SQL = "select * from tipo_soporte_queja"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_kardex()
        SQL = "select Referencia, nombre_producto from vw_kardex union all SELECT '999999', '** SIN REFERENCIA **'  order by nombre_producto"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Sub nueva_queja(q_usuario As String, q_tipoqueja As String, q_referencia As String, q_tiposoporte As String, q_cliente As String, q_descripcion As String, q_sugerencia As String, q_fecha As Date)
        SQL = "insert hist_quej_conf values('" & q_usuario & "', '" & q_tipoqueja & "', '" & Trim(q_referencia) & "', '" & q_tiposoporte & "', '" & q_cliente & "', '" & q_descripcion & "', " & _
              "'" & q_sugerencia & "', convert(smalldatetime,'" & q_fecha & "',103),  getdate())"
        connection.ejecutar_query(SQL)
    End Sub
   
End Class
