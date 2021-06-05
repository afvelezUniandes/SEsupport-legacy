Public Class Querys_horario

    Private SQL As String
    Private dt As New DataTable
    Private connection As New connection

    Function cons_festivos_calendario(q_fechaini As String, q_fechafin As String, q_año As String)
        If (q_fechaini = "" And q_fechafin = "") Then
            SQL = "select convert(varchar,fecha,103) fecha from festivos_calendario where ano = '" & q_año & "'"
        Else
            SQL = "select convert(varchar,fecha,112) fecha from festivos_calendario " & _
                  "where fecha between '" & q_fechaini & "' and '" & q_fechafin & "'"
        End If
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Sub ins_festivos_calendario(q_año As String, q_fecha As String)
        SQL = "insert into festivos_calendario values('" & q_fecha & "', '" & q_año & "')"
        connection.ejecutar_query(SQL)
    End Sub

    Sub borrar_festivos_calendario(q_año As String, q_fecha As String)
        SQL = "delete from festivos_calendario where ano = '" & q_año & "' and fecha = '" & q_fecha & "'"
        connection.ejecutar_query(SQL)
    End Sub

    Function cons_areas(q_tipo_area As String) As DataTable
        SQL = "select * from areas where activo = 1 and id_tipo_area = '" & q_tipo_area & "'"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_tipo_area() As DataTable
        SQL = "select * from tipos_area where activo = 1 and id_tipo_area <> 0"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_turno(q_area As String) As DataTable
        SQL = "select id_turno, id_area, desc_turno, hora_inicio, hora_fin, activo, " & _
              "desc_turno + ' - ' + SUBSTRING(convert(varchar,hora_inicio),1,5) + ' - ' + SUBSTRING(convert(varchar,hora_fin),1,5) turno " & _
              "from turnos where activo = 1 and (id_area = '" & q_area & "' or id_area = '0')"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_empleado(q_tipo_area As String) As DataTable
        SQL = "select * from empleados where activo = 1 and id_tipo_area = '" & q_tipo_area & "'"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_horas_trabajadas(q_cedula As String, q_fechaini As Date, q_fechafin As Date)
        SQL = "select isnull(sum(case when datediff(HOUR,hora_inicio, hora_fin) < 0 then datediff(HOUR,hora_inicio, hora_fin) + 24 else datediff(HOUR,hora_inicio, hora_fin) end),0) diferencia " & _
              "from rel_turno_area_persona rel  " & _
              "where cedula = '" & q_cedula & "' and fecha_turno between '" & q_fechaini & "' and '" & q_fechafin & "' "
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Sub nuevo_horario(q_cedula As String, q_fecha As String, q_turno As String, q_area As String, q_usuario As String, q_hora_ini As String, q_hora_fin As String)
        SQL = "delete from rel_turno_area_persona " & _
             "where cedula = '" & q_cedula & "' and fecha_turno = convert(varchar,'" & q_fecha & "',121)"
        connection.ejecutar_query(SQL)

        SQL = "insert into rel_turno_area_persona (id_turno, id_area, hora_inicio, hora_fin, fecha_turno, cedula, usuario, fecha_creacion) " & _
              "values (dbo.turno_area_desc('" & q_turno & "', '" & q_area & "'), '" & q_area & "', '" & q_hora_ini & "', '" & q_hora_fin & "', '" & q_fecha & "', '" & q_cedula & "', '" & q_usuario & "', getdate())"
        connection.ejecutar_query(SQL)
    End Sub

    Function cons_horario(q_fechaini As String, q_fechafin As String)
        SQL = "execute cons_horario '" & q_fechaini & "', '" & q_fechafin & "'"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Sub borrar_turno(q_turno As String, q_area As String)
        SQL = "delete from turnos where turno = '" & q_turno & "' and area = '" & q_area & "'"
    End Sub

    Sub nuevo_turno()
        SQL = "insert into turnos "
    End Sub
End Class
