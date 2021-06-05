Imports System.IO
Public Class adjuntar

    Public ruta_adjunto As String
    Private Sub adjuntar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Directory.Exists(ruta_adjunto) Then
            actualizar_listado_archivos()
        Else
            Directory.CreateDirectory(ruta_adjunto)
        End If
    End Sub

    Private Sub adjuntar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Principal_usuario_req.Enabled = True
        Catch ex As Exception
        End Try

        Try
            Editar_usuario_req.Enabled = True
        Catch ex As Exception
        End Try

        Try
            Editar_tecnico_req.Enabled = True
        Catch ex As Exception
        End Try

        Try
            Principal_usuario_queja.Enabled = True
        Catch ex As Exception
        End Try

        Try
            Editar_usuario_queja.Enabled = True
        Catch ex As Exception
        End Try

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Title = "Seleccione el archivo a Adjuntar"

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            CopiaArchivoConProgreso(openFileDialog1.FileName, ruta_adjunto, openFileDialog1.SafeFileName)
        End If

        actualizar_listado_archivos()
    End Sub

    Sub CopiaArchivoConProgreso(ByVal path As String, ByVal path2 As String, ByVal mediafile As String)
        Dim fi As New IO.FileInfo(mediafile)
        Dim sr As New IO.FileStream(path, IO.FileMode.Open) 'lugar de origen        
        Dim sw As New IO.FileStream(path2 & "\" & mediafile, IO.FileMode.Create) 'lugar de destino       
        Dim len As Long = sr.Length - 1
        For i As Long = 0 To len
            sw.WriteByte(sr.ReadByte)
            If i Mod 1000 = 0 Then 'Actualiza con cada 1 kb copiado                
                ProgressBar1.Value = i * 100 / len
                Application.DoEvents()
            End If
        Next
        ProgressBar1.Value = 0
        sr.Close()
        sw.Close()
    End Sub

    Sub actualizar_listado_archivos()
        DgvArchivos.Rows.Clear()
        DgvArchivos.DataSource = Nothing

        Try
            For Each Archivo As String In My.Computer.FileSystem.GetFiles(ruta_adjunto, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                Dim nombre As String = My.Computer.FileSystem.GetName(Archivo)
                DgvArchivos.Rows.Add(False, nombre, Archivo)
            Next
            ' errores  
        Catch oe As Exception
            MsgBox(oe.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim i As Integer = MsgBox("Desea Eliminar los archivos seleccionados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If i = 6 Then
            For j As Integer = 0 To DgvArchivos.Rows.Count - 1
                If DgvArchivos.Rows(j).Cells(0).Value = True Then
                    My.Computer.FileSystem.DeleteFile(DgvArchivos.Rows(j).Cells(2).Value)
                End If
            Next
            actualizar_listado_archivos()
        End If
    End Sub

    Private Sub DgvArchivos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvArchivos.CellDoubleClick
        If (e.RowIndex >= 0) Then
            Try
                Process.Start(DgvArchivos(2, e.RowIndex).Value.ToString())
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try

        End If

    End Sub


End Class