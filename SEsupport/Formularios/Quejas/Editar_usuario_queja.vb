Public Class Editar_usuario_queja

    Public num_queja As String
    Private Sub Editar_usuario_queja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim consultas As New Querys_quejas
        Dim dtconsulta, dttiposoporte, dttipoqueja, dtreferencia As New DataTable

        dtconsulta = consultas.cons_hist_queja_usu_num(nombre, num_queja)
        DtmFecha.Text = dtconsulta.Rows(0)(12).ToString()

        Try
            dttipoqueja = consultas.cons_tipo_queja()
            dtreferencia = consultas.cons_kardex()
            dttiposoporte = consultas.cons_tipo_soporte()

            CmbTipoQueja.DataSource = dttipoqueja
            CmbTipoQueja.DisplayMember = dttipoqueja.Columns(1).ToString()
            CmbTipoQueja.ValueMember = dttipoqueja.Columns(0).ToString()
            CmbTipoQueja.Text = dtconsulta.Rows(0)(4).ToString()

            CmbProducto.DataSource = dtreferencia
            CmbProducto.DisplayMember = dtreferencia.Columns(1).ToString()
            CmbProducto.ValueMember = dtreferencia.Columns(0).ToString()
            CmbProducto.Text = dtconsulta.Rows(0)(6).ToString()

            CmbTipoSoporte.DataSource = dttiposoporte
            CmbTipoSoporte.DisplayMember = dttiposoporte.Columns(1).ToString()
            CmbTipoSoporte.ValueMember = dttiposoporte.Columns(0).ToString()
            CmbTipoSoporte.Text = dtconsulta.Rows(0)(8).ToString()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        TxbCliente.Text = dtconsulta.Rows(0)(9).ToString()
        TxbDescripcion.Text = dtconsulta.Rows(0)(10).ToString()
        TxbSugerencia.Text = dtconsulta.Rows(0)(11).ToString()
        TxbNumero.Text = num_queja

    End Sub

    Private Sub Editar_usuario_queja_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Principal_usuario_queja.Enabled = True
    End Sub

    Private Sub BtnAdjuntar_Click(sender As Object, e As EventArgs) Handles BtnAdjuntar.Click
        adjuntar.ruta_adjunto = ruta_adjunto_queja & num_queja
        adjuntar.Show()
        Me.Enabled = False
    End Sub
End Class