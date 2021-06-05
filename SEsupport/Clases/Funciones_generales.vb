Imports System.IO

Public Class Funciones_generales

    Private SQL As String
    Private dt As New DataTable
    Private connection As New connection
    Function random()
        Dim rand As New Random(DateTime.Now.Millisecond)

        Dim numero As Int32 = rand.Next(100, 1000)
        Dim letra As Char = Convert.ToChar(rand.Next(97, 122))

        Return letra & numero
    End Function

    Function cons_login(q_usuario As String) As DataTable
        If q_usuario = "Sesupport" Then
            SQL = "SELECT Contraseña, Desc_usuario, IdUsuario, Nivel, Tecnico, Usuario, factu FROM Usuario"
        Else
            SQL = "SELECT Contraseña, Desc_usuario, IdUsuario, Nivel, Tecnico, Usuario, factu FROM Usuario WHERE Usuario = '" & q_usuario & "'"
        End If
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_datosusuario(q_id As Int32) As DataTable

        SQL = "SELECT Contraseña, IdUsuario FROM Usuario WHERE idusuario = '" & q_id & "'"

        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Sub cambiar_contraseña(q_usuario As String, q_contraseña As String)
        SQL = "Update usuario set contraseña = '" & q_contraseña & "' where usuario = '" & q_usuario & "'"
        connection.ejecutar_query(SQL)
    End Sub

    Sub renombrar_directorio_temp(q_usuario As String, q_ruta As String, q_prefijo As String)
        Dim dtconsulta As New DataTable
        If q_prefijo = "inc_" Then
            Dim consultar As New Querys_incidentes
            dtconsulta = consultar.cons_numero_req(q_usuario)
        ElseIf q_prefijo = "que_" Then
            Dim consultar As New Querys_quejas
            dtconsulta = consultar.cons_numero_que(q_usuario)
        End If

        Try
            My.Computer.FileSystem.RenameDirectory(q_ruta, q_prefijo & dtconsulta.Rows(0)(0).ToString())
        Catch ex As Exception
        End Try
    End Sub

    Sub borrar_directorio_temp(q_ruta As String)
        Try
            If Directory.Exists(q_ruta) Then
                My.Computer.FileSystem.DeleteDirectory(q_ruta, FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function cons_directorio_vacio(q_ruta As String) As Boolean
        Try
            Dim ficheros() As String
            ficheros = Directory.GetFiles(q_ruta)
            If Not (ficheros.Length > 0) Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try        
    End Function

    Sub envio_correo(q_destinatario As String, q_asunto As String, q_id As Integer, q_aux1 As String, q_aux2 As String, q_aux3 As String, q_aux4 As String, q_aux5 As String, q_aux6 As String, q_aux7 As String, q_aux8 As String)
        SQL = "execute sp_envia_correos '" & q_destinatario & "', '" & q_asunto & "', null, 'HTML', 'Sesupport', " & q_id & ", '" & q_aux1 & "', '" & q_aux2 & "', '" & q_aux3 & "', '" & q_aux4 & "', '" & q_aux5 & "', '" & q_aux6 & "', '" & q_aux7 & "', '" & q_aux8 & "'"
        connection.ejecutar_query(SQL)
    End Sub

    Function cons_permisos(q_usuario As String, q_id As String) As DataTable
        If q_id = "" Then
            SQL = "execute cons_permisos '" & q_usuario & "', '' "
        Else
            SQL = "execute cons_permisos '" & q_usuario & "', '" & q_id & "'"
        End If
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_aprobador() As DataTable
        SQL = "select * from Usuario u inner join Acceso_usuario a on u.Usuario = a.Usuario where a.Idacceso = '14' and (a.nivel_acceso = '3' or a.nivel_acceso = '2')"
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_banco(q_cban As String) As DataTable
        If q_cban = "" Then
            SQL = "Select * from factu01..bancos"
        Else
            SQL = "Select banco, nombre from factu01..bancos where cedula = '" & q_cban & "'"
        End If
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_cliente(q_cliente As String) As DataTable
        If q_cliente = "" Then
            SQL = "SELECT razon_social, email FROM factu01..clientes"
        Else
            SQL = "SELECT razon_social, email FROM factu01..clientes WHERE nit = '" & q_cliente & "'"
        End If
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

    Function cons_proveedor(q_nit As String) As DataTable
        If (q_nit <> "") Then
            SQL = "SELECT razon_social,email,banco,cuentabanco,nombrebanco,numerocuenta,tipo FROM factu01..proveedores where nit = '" & q_nit & "'"
        End If
        dt = connection.consultar_query(SQL)
        Return dt
    End Function

End Class
