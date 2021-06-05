Public Class Principal_usuario_queja

    Private guardado As Boolean = False
    Dim funciones_generales As New Funciones_generales
    Private Sub Principal_usuario_quej_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dttipoqueja, dtproducto, dttiposoporte As DataTable
        Dim consulta As New Querys_quejas

        Try
            dttipoqueja = consulta.cons_tipo_queja()
            dtproducto = consulta.cons_kardex()
            dttiposoporte = consulta.cons_tipo_soporte()

            CmbTipoQueja.DataSource = dttipoqueja
            CmbTipoQueja.DisplayMember = dttipoqueja.Columns(1).ToString()
            CmbTipoQueja.ValueMember = dttipoqueja.Columns(0).ToString()
            CmbTipoQueja.Text = ""

            CmbProducto.DataSource = dtproducto
            CmbProducto.DisplayMember = dtproducto.Columns(1).ToString()
            CmbProducto.ValueMember = dtproducto.Columns(0).ToString()
            CmbProducto.Text = "** SIN REFERENCIA **"

            CmbTipoSoporte.DataSource = dttiposoporte
            CmbTipoSoporte.DisplayMember = dttiposoporte.Columns(1).ToString()
            CmbTipoSoporte.ValueMember = dttiposoporte.Columns(0).ToString()
            CmbTipoSoporte.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        carpeta_temp = funciones_generales.random

        'cargamos el primer y ultimo dia del mes para el historico de quejas
        Dim rtn As New Date
        rtn = Date.Now
        DtmFechaInicial.Text = rtn.AddDays(-rtn.Day + 1)
        DtmFechaFinal.Text = rtn.AddDays(-rtn.Day + 1).AddMonths(1).AddDays(-1)

        'cargamos el historico de quejas
        cargar_historico_queja(DtmFechaInicial.Text, DtmFechaFinal.Text)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub VolverAlInicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAlInicioToolStripMenuItem.Click
        Inicio.Show()
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim ingresar As New Querys_quejas
        Dim producto As String = ""

        If CmbProducto.Text <> "" And TxbCliente.Text <> "" And TxbDescripcion.Text <> "" And TxbSugerencia.Text <> "" And CmbTipoQueja.SelectedValue.ToString() <> "" And CmbTipoSoporte.SelectedValue.ToString() <> "" Then
            Try
                ingresar.nueva_queja(nombre, CmbTipoQueja.SelectedValue.ToString(), CmbProducto.SelectedValue.ToString(), CmbTipoSoporte.SelectedValue.ToString(), TxbCliente.Text, TxbDescripcion.Text, TxbSugerencia.Text, DtmFecha.Text)
                MsgBox("La queja fue insertada correctamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                guardado = True
                funciones_generales.renombrar_directorio_temp(nombre, ruta_adjunto_queja & carpeta_temp, "que_")
                funciones_generales.borrar_directorio_temp(ruta_adjunto_queja & carpeta_temp)
                cargar_historico_queja(DtmFechaInicial.Text, DtmFechaFinal.Text)
                limpiar()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        Else
            MsgBox("Se deben completar los datos antes de ser envíada la queja y no conformidad", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub

    Sub limpiar()
        CmbProducto.Text = ""
        CmbTipoQueja.Text = ""
        CmbTipoSoporte.Text = ""
        TxbCliente.Text = ""
        TxbDescripcion.Text = ""
        TxbSugerencia.Text = ""
    End Sub

    Private Sub BtnAdjuntar_Click(sender As Object, e As EventArgs) Handles BtnAdjuntar.Click
        adjuntar.ruta_adjunto = ruta_adjunto_queja & carpeta_temp
        adjuntar.Show()
        Me.Enabled = False
    End Sub

    Private Sub Principal_usuario_queja_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        funciones_generales.borrar_directorio_temp(ruta_adjunto_queja & carpeta_temp)
    End Sub

    Private Sub TipoDeSoporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeSoporteToolStripMenuItem.Click
        Me.Enabled = False
        Ayuda_queja.Show()
    End Sub

    Sub cargar_historico_queja(fecha_inicial As Date, fecha_final As Date)
        Dim consultar As New Querys_quejas
        Dim dtconsulta As New DataTable
        Try
            dtconsulta = consultar.cons_hist_queja_usu_feini_fefin(nombre, fecha_inicial, fecha_final)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        DgvHistorico.DataSource = Nothing
        DgvHistorico.DataSource = dtconsulta
    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        cargar_historico_queja(DtmFechaInicial.Text, DtmFechaFinal.Text)
    End Sub

    Private Sub DgvHistorico_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvHistorico.CellDoubleClick
        If (e.RowIndex >= 0) Then
            Editar_usuario_queja.num_queja = Me.DgvHistorico(0, e.RowIndex).Value.ToString()
            Editar_usuario_queja.Show()
            Me.Enabled = False
        End If

    End Sub

    Private Sub DtmFecha_ValueChanged(sender As Object, e As EventArgs) Handles DtmFecha.ValueChanged

    End Sub

    Private Sub CmbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbProducto.SelectedIndexChanged

    End Sub
End Class
