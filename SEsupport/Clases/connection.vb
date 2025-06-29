Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb


Public Class connection
    Private dt As New DataTable
    Private connectionstring As String = ""

    Sub ejecutar_query(sql As String)
        Dim conexion As New SqlConnection(connectionstring)
        Dim modifica As New SqlCommand(sql, conexion)
        modifica.CommandTimeout = 0
        conexion.Open()
        modifica.ExecuteNonQuery()
        conexion.Close()
    End Sub


    Function consultar_query(sql As String) As DataTable
        Dim dt As New DataTable
        Dim conexion As New SqlConnection(connectionstring)
        Dim adapter As New SqlDataAdapter(sql, conexion)
        Try
            adapter.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return dt
        End Try
    End Function

End Class
