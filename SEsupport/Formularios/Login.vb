Imports System
Imports System.Text
Imports System.Collections
Imports System.Net
Imports System.IO

Public Class Login

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim usuario, contraseña As String
        Dim funciones_generales As New Funciones_generales
        Dim dt As New DataTable

        usuario = TxbUser.Text
        contraseña = TxbPassword.Text
        user = TxbUser.Text
        dt = funciones_generales.cons_login(usuario)
        If (dt.Rows.Count <= 0) Then
            MsgBox("Usuario y/o contraseña invalido. Verifica tus datos o comunicate con el administrador del sistema.", MsgBoxStyle.Critical)
        Else
            nombre = dt.Rows(0)(1).ToString
            If dt.Rows.Count > 0 Then
                If contraseña = dt.Rows(0)(0).ToString() Then
                    nivel = dt.Rows(0)(3).ToString()

                    If nivel = 0 Then
                        MsgBox("Usuario deshabilitado, por favor validar con el usuario administrador del programa", MsgBoxStyle.Information)
                    Else
                        factu = dt.Rows(0)(6).ToString()
                        Inicio.Show()
                        Me.Close()
                    End If
                Else
                    MsgBox("Ingreso incorrecto, intente nuevamente", MsgBoxStyle.Critical)
                    TxbPassword.Text = ""
                End If
            Else
                MsgBox("Ingreso incorrecto, intente nuevamente", MsgBoxStyle.Critical)
                TxbPassword.Text = ""
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxbUser.Focus()
        TxbUser.Text = Environment.UserName.ToString()
        equipo = Environment.MachineName

        'TxbIP.Text = Miip()

    End Sub

    'Private Function Miip() As String
    '    Dim ip2 As String = ""
    '    Dim Host As String
    '    Host = Dns.GetHostName
    '    Dim ip As IPHostEntry = Dns.GetHostEntry(Host)
    '    Try
    '        Return ip.AddressList(1).ToString()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return ip.AddressList(0).ToString()
    '    End Try
    '    Return ip2

    'End Function



End Class
