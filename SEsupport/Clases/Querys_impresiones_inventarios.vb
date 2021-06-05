Public Class Querys_impresiones_inventarios

    Private SQL As String
    Private dt As New DataTable
    Private connection As New connection

    Function cons_encabezado(q_pastse As String, q_factu As String) As DataTable
        SQL = "execute imp_encabezado_inventario '" & q_pastse & "', ' " & q_factu & "'"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_conteo(q_bodega As String, q_factu As String, q_pastse As String, q_mes As String, q_fecha As String)
        SQL = "execute cons_conteo '" & q_pastse & "','" & q_factu & "','" & q_bodega & "','" & q_mes & "', '" & q_fecha & "'"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

End Class
