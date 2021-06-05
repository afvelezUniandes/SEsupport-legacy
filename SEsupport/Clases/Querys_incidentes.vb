Public Class Querys_incidentes

    Private SQL As String
    Private dt As New DataTable
    Private connection As New connection

    Sub ingresar_observacion(idhist As String, observacion As String, usuario As String)
        SQL = "insert observaciones(idhist, fecha, observacion, usuario) " & _
              "values('" & idhist & "', getdate(), '" & observacion & "', '" & usuario & "')"
        connection.ejecutar_query(SQL)
    End Sub

    Function consultar_observacion(idhist As String)
        SQL = "select u.desc_usuario, convert(varchar,o.fecha,103) + ' ' + convert(varchar,o.fecha,108) fecha, o.observacion " & _
              "from observaciones o inner join usuario u on o.usuario = u.usuario " & _
              "where idhist = '" & idhist & "' " & _
              "order by fecha desc"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function
    Function cons_ciclo_aprobacion_usu(q_usuario As String) As DataTable
        SQL = "select * from vw_hist_ciclo_aprobacion where Usuario = '" & q_usuario & "' order by numero_soporte"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_ciclo_aprobacion_estado_usu(q_estado As String, q_usuario As String) As DataTable
        SQL = "select * from vw_hist_ciclo_aprobacion where Usuario = '" & q_usuario & "' and aprobado = '" & q_estado & "' order by numero_soporte"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_ciclo_aprobacion_inc(q_idhist As String) As DataTable
        SQL = "select * from vw_hist_ciclo_aprobacion where numero_soporte = '" & q_idhist & "' order by numero_soporte"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_numero_req(q_usuario As String) As DataTable
        SQL = "select max(idhist) from vw_hist_inc_req where usuario = '" & q_usuario & "'"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_tipo_aprobacion() As DataTable
        SQL = "select * from tipo_aprobacion where visible = 1"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_login(q_usuario As String) As DataTable
        If q_usuario = "Sesupport" Then
            SQL = "SELECT Contraseña, Desc_usuario, IdUsuario, Nivel, Tecnico, Usuario FROM Usuario"
        Else
            SQL = "SELECT Contraseña, Desc_usuario, IdUsuario, Nivel, Tecnico, Usuario FROM Usuario WHERE Usuario = '" & q_usuario & "'"
        End If
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_pendientes_usu(q_usuario As String) As DataTable
        SQL = "SELECT Desc_modulo, Idhist, calificacion, desc_estado, desc_prioridad, desc_tecnico, desc_tipo, desc_usuario, descripcion, fecha_entrega, " & _
              "fecha_generacion, fecha_sugerida, idestado, idmodulo, idprioridad, idtipo, observacion_cal, observacion_reabrir, sol_tecnico, sol_usuario, " & _
              "tecnico, usuario, idmotivo, desc_motivo FROM vw_hist_inc_req WHERE usuario = '" & q_usuario & "' ORDER BY fecha_generacion"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_pendientes_numero(q_numero As String) As DataTable
        SQL = "SELECT Desc_modulo, Idhist, calificacion, desc_estado, desc_prioridad, desc_tecnico, desc_tipo, desc_usuario, descripcion, fecha_entrega, " & _
              "fecha_generacion, fecha_sugerida, idestado, idmodulo, idprioridad, idtipo, observacion_cal, observacion_reabrir, sol_tecnico, sol_usuario, " & _
              "tecnico, usuario, idmotivo, desc_motivo FROM vw_hist_inc_req WHERE idhist = '" & q_numero & "' ORDER BY fecha_generacion"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_pendientes_usu_estado(q_usuario As String, q_estado As String) As DataTable
        SQL = "SELECT Desc_modulo, Idhist, calificacion, desc_estado, desc_prioridad, desc_tecnico, desc_tipo, desc_usuario, descripcion, fecha_entrega, " & _
              "fecha_generacion, fecha_sugerida, idestado, idmodulo, idprioridad, idtipo, observacion_cal, observacion_reabrir, sol_tecnico, sol_usuario, " & _
              "tecnico, usuario, idmotivo, desc_motivo FROM vw_hist_inc_req WHERE usuario = '" & q_usuario & "' and idestado = '" & q_estado & "' ORDER BY fecha_generacion"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_pendientes_usu_idhist(q_usuario As String, q_idhist As String) As DataTable
        SQL = "SELECT Desc_modulo, Idhist, calificacion, desc_estado, desc_prioridad, desc_tecnico, desc_tipo, desc_usuario, descripcion, fecha_entrega, " & _
              "fecha_generacion, fecha_sugerida, idestado, idmodulo, idprioridad, idtipo, observacion_cal, observacion_reabrir, sol_tecnico, sol_usuario, " & _
              "tecnico, usuario, idmotivo, desc_motivo FROM vw_hist_inc_req WHERE usuario = '" & q_usuario & "' and idhist = '" & q_idhist & "' ORDER BY fecha_generacion"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_pendientes_estado(q_estado As String) As DataTable
        SQL = "SELECT Desc_modulo, Idhist, calificacion, desc_estado, desc_prioridad, desc_tecnico, desc_tipo, desc_usuario, descripcion, fecha_entrega, " & _
              "fecha_generacion, fecha_sugerida, idestado, idmodulo, idprioridad, idtipo, observacion_cal, observacion_reabrir, sol_tecnico, sol_usuario, " & _
              "tecnico, usuario, idmotivo, desc_motivo FROM vw_hist_inc_req WHERE idestado = '" & q_estado & "' ORDER BY fecha_generacion"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_usuario(q_usuario As String) As DataTable
        If q_usuario = "" Then
            SQL = "Select * from usuario order by Desc_usuario"
        Else
            SQL = "Select * from usuario where usuario = '" & q_usuario & "'"
        End If
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_datosusuario(q_nombre As String) As DataTable
        SQL = "Select * from usuario where desc_usuario = '" & q_nombre & "'"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_accesos(q_acceso As String) As DataTable
        If q_acceso = "" Then
            SQL = "select idacceso, desc_acceso from Accesos order by idacceso"
        Else
            SQL = "select idacceso, desc_acceso from Accesos where idacceso = '" & q_acceso & "'"
        End If
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_empleado(q_cedula As String) As DataTable
        If q_cedula = "" Then
            SQL = "Select * from usuario"
        Else
            SQL = "Select * from empleados where cedula = '" & q_cedula & "'"
        End If
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_perming(q_usuario As String, q_tipopermiso As String) As DataTable

        SQL = "Select * from acceso_usuario where usuario = '" & q_usuario & "' And nivel_acceso = '" & q_tipopermiso & "' order by idacceso"

        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_prioridad() As DataTable
        SQL = "SELECT IdPrioridad, Desc_prioridad FROM Prioridad"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function
    Function cons_usuario2(q_usuario As String) As DataTable
        If q_usuario = "" Then
            SQL = "Select Mail,Factu from usuario"
        Else
            SQL = "Select Mail,Factu from usuario where usuario = '" & q_usuario & "'"
        End If
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_tecnico() As DataTable
        SQL = "Select * from usuario where tecnico = 1 and activo = '1' order by Desc_usuario"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function
    Function cons_estado(q_id As String) As DataTable
        If q_id = "" Then
            SQL = "SELECT IdEstado, Desc_estado FROM Estado"
        Else
            SQL = "SELECT IdEstado, Desc_estado FROM Estado where idestado = " & q_id
        End If
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_modulo() As DataTable
        SQL = "SELECT IdModulo, Desc_modulo FROM Modulo"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_tiporeq() As DataTable
        SQL = "SELECT Idtipo, Desc_tipo FROM tipo_req"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_motivo() As DataTable
        SQL = "SELECT Idmotivo, Desc_motivo from motivo"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_nivel(q_nivel As String) As DataTable
        If q_nivel = "" Then
            SQL = "SELECT Idnivel, Desc_nivel from nivel"
        Else
            SQL = "SELECT Idnivel, Desc_nivel from nivel where idnivel = " & q_nivel
        End If
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_com(q_id As String) As DataTable

        SQL = "SELECT factu from usuario where idusuario = " & q_id

        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Sub nuevo_incidente(q_usuario As String, q_idmodulo As String, q_idprioridad As String, q_idestado As String, q_idtipo As String, q_descripcion As String)
        SQL = "insert into hist_inc_req (Usuario, Idmodulo, Idprioridad, Idestado, Idtipo, descripcion, fecha_generacion) values " & _
                            "('" & q_usuario & "', '" & q_idmodulo & "', '" & q_idprioridad & "', '" & q_idestado & "', '" & q_idtipo & "', '" & q_descripcion & "', getdate())"
        connection.ejecutar_query(SQL)
    End Sub

    Sub reabrir_incidente(q_descripcion As String, q_idhist As String)
        SQL = "update hist_inc_req set idestado = 6, observacion_reabrir = '" & q_descripcion & "' where idhist = " & q_idhist
        connection.ejecutar_query(SQL)
    End Sub

    Sub reabrir_incidente_hist(q_idhist As String, q_tecnico As String, q_descripcion As String)
        SQL = "insert hist_reabrir select isnull(max(Idreabrir),0) + 1, " & q_idhist & ", '" & q_tecnico & "', '" & q_descripcion & "', getdate() " & _
              " from hist_reabrir"
        connection.ejecutar_query(SQL)
    End Sub

    Sub calificar_incidente(q_descripcion As String, q_calificacion As String, q_idhist As String)
        SQL = "update hist_inc_req set idestado = 4, observacion_cal = '" & q_descripcion & "', calificacion = " & q_calificacion & " where idhist = " & q_idhist
        connection.ejecutar_query(SQL)
    End Sub

    Sub actualiza_req(q_estado As String, q_usuario As String, q_idmodulo As String, q_idtipo As String, q_fecha_pactada As Date, q_idhist As String, q_idprioridad As String, q_idmotivo As String, q_tecnico As String, q_solusuario As String, q_soltecnico As String)
        If q_estado = 3 Then
            SQL = "update hist_inc_req set idestado = '" & q_estado & "', usuario = '" & q_usuario & "', idmodulo = '" & q_idmodulo & "', idtipo = '" & q_idtipo & "', idprioridad = '" & q_idprioridad & "', " & _
                  "idmotivo = '" & q_idmotivo & "', fecha_sugerida = convert(smalldatetime,'" & q_fecha_pactada & "',103), fecha_entrega = getdate(), tecnico = '" & q_tecnico & "', sol_usuario = '" & q_solusuario & "', " & _
                  "sol_tecnico = '" & q_soltecnico & "' where idhist = " & q_idhist
        Else
            SQL = "update hist_inc_req set idestado = '" & q_estado & "', usuario = '" & q_usuario & "', idmodulo = '" & q_idmodulo & "', idtipo = '" & q_idtipo & "', idprioridad = '" & q_idprioridad & "', " & _
                  "idmotivo = '" & q_idmotivo & "', fecha_sugerida = convert(smalldatetime,'" & q_fecha_pactada & "',103), tecnico = '" & q_tecnico & "', sol_usuario = '" & q_solusuario & "', " & _
                  "sol_tecnico = '" & q_soltecnico & "' where idhist = " & q_idhist
        End If
        connection.ejecutar_query(SQL)
    End Sub

    Sub actualiza_usu(q_usuario As String, q_contraseña As String, q_nombre As String, q_nivel As String, q_tecnico As String, q_mail As String)
        SQL = "update usuario set contraseña = '" & q_contraseña & "', desc_usuario = '" & q_nombre & "', nivel = '" & q_nivel & "', tecnico = '" & q_tecnico & "', '" & q_mail & "' " & _
              "where usuario = '" & q_usuario & "'"
        connection.ejecutar_query(SQL)
    End Sub

    Sub nuevo_usu(q_usuario As String, q_contraseña As String, q_nombre As String, q_nivel As String, q_mail As String, q_comp As String, q_est As String)
        SQL = "insert into usuario (idusuario, usuario, contraseña, desc_usuario, nivel, mail, factu, activo) values ((select max(idusuario) + 1 from usuario), '" & q_usuario & "', '" & q_contraseña & "', '" & q_nombre & "', '" & q_nivel & "', '" & q_mail & "', '" & q_comp & "', '" & q_est & "') "
        connection.ejecutar_query(SQL)
    End Sub

    Sub nuevo_ciclo_aprobacion(q_cicloant As String, q_idhist As String, q_aprobacion As String, q_justificacion As String, q_usuario As String)
        SQL = "insert into ciclo_aprobacion " & _
              "select isnull(max(idciclo),0) + 1, '" & q_cicloant & "', '" & q_idhist & "', '" & q_aprobacion & "', '" & q_justificacion & "', '" & q_usuario & "' " & _
              "from ciclo_aprobacion"
        connection.ejecutar_query(SQL)
    End Sub

    Sub actualizar_ciclo_aprobacion(q_idciclo As String, q_aprobacion As String, q_razon As String)
        SQL = "update ciclo_aprobacion set aprobacion = " & q_aprobacion & ", razon = '" & q_razon & "' where idciclo = " & q_idciclo
        connection.ejecutar_query(SQL)
    End Sub


End Class
