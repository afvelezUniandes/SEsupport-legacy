Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class Querys
    
    Public SQL As String
    Public usuario, idmodulo, idprioridad, idestado, idtipo, descripcion, idhist, calificacion As String
    Public fecha_pactada As Date

    Private sConnectionString As String = "User ID=SEsupport;Password=SEsupport2013;Initial Catalog=SEsupport;Data Source=192.168.0.7\sqlexpress"
    Private objConn As New SqlConnection(sConnectionString)

    Sub nuevo_incidente()
        Dim SQL As String = "insert into hist_inc_req (Usuario, Idmodulo, Idprioridad, Idestado, Idtipo, descripcion, fecha_generacion) values " & _
                            "('" + usuario + "', '" + idmodulo + "', '" + idprioridad + "', '" + idestado + "', '" + idtipo + "', '" + descripcion + "', getdate())"
        ejecutar_query(SQL)
    End Sub

    Sub reabrir_incidente()
        Dim sql As String = "update hist_inc_req set estado = 6, observacion_reabrir = '" + descripcion + "' where idhist = " + idhist
        ejecutar_query(sql)
    End Sub

    Sub calificar_incidente()
        Dim sql As String = "update hist_inc_req set estado = 4, observacion_cal = '" + descripcion + "', calificacion = " + calificacion + " where idhist = " + idhist
        ejecutar_query(sql)
    End Sub
    Sub actualiza_req()
        Dim sql As String = "update hist_inc_req set estado = 2, usuario = '" + usuario + "', idmodulo = " + idmodulo + ", idtipo = '" + idtipo + "', " & _
                            "fecha_sugerida = '" + fecha_pactada + "' where idhist = " + idhist
    End Sub

    Sub ejecutar_query(ByVal SQL As String)
        objConn.Open()
        Dim objCmd As New SqlCommand(SQL, objConn)
        objCmd.ExecuteNonQuery()
        objConn.Close()
    End Sub



End Class
