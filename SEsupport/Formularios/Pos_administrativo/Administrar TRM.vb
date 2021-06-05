Public Class Administrar_TRM

    Dim consultas_bd As New Querys_pos_administrativo
    Dim ingreso As Boolean = True
    Private Sub Administrar_TRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Pos_Administrativo.Enabled = True
    End Sub

    Private Sub Administrar_TRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GroupBox1.Enabled = False
        Dim consulta_monedas As New DataTable
        consulta_monedas = consultas_bd.consultar_monedas(conexion_pos)

        CmbMoneda.DataSource = consulta_monedas
        CmbMoneda.ValueMember = "codigo_moneda"
        CmbMoneda.DisplayMember = "desc_moneda"
        CmbMoneda.Text = ""
        ingreso = False
    End Sub

    Private Sub CmbMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMoneda.SelectedIndexChanged
        If ingreso = False Then
            GroupBox1.Enabled = True
            actualizar_dgv()
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim guardar As Boolean = False
        Dim dt_consulta As New DataTable
        dt_consulta = consultas_bd.consultar_vw_trm_moneda_maxfecha(CmbMoneda.SelectedValue.ToString(), conexion_pos)

        If dt_consulta.Rows.Count = 0 Then
            guardar = True
        Else
            If DtpFechaIni.Value > dt_consulta.Rows(0)("fecha_fin") Then
                guardar = True
            End If
        End If

        If guardar = True Then
            If TxbValor.Text <> "" And DtpFechaFin.Value.ToString("yyyyMMdd") >= DtpFechaIni.Value.ToString("yyyyMMdd") Then
                consultas_bd.insertar_trm_moneda(conexion_pos, CmbMoneda.SelectedValue.ToString(), TxbValor.Text, DtpFechaIni.Value.ToString("dd/MM/yyyy"), DtpFechaIni.Value.ToString("dd/MM/yyyy"))
                actualizar_dgv()
                MsgBox("se actualizó la TRM para esa moneda")
            Else
                MsgBox("No se encuentra la información diligenciada")
            End If
        Else
            MsgBox("La fecha inicial es menor a la maxima fecha final del historico, por favor corrija la fecha del nuevo TRM o elimine el anterior y vuelva a grabar de nuevo")
        End If
    End Sub

    Sub actualizar_dgv()
        Dim consulta_monedas As New DataTable
        consulta_monedas = consultas_bd.consultar_hist_trm_moneda(CmbMoneda.SelectedValue.ToString(), conexion_pos)
        DgvHistorico.DataSource = consulta_monedas
    End Sub

    Private Sub DgvHistorico_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvHistorico.CellContentClick
        If e.ColumnIndex = 0 Then
            Dim i As Integer = MsgBox("Confirmar borrar la TRM", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo)
            If i = 6 Then
                Dim codigo As String = DgvHistorico.Rows(e.RowIndex).Cells(1).Value.ToString()
                Dim fechaini As Date = DgvHistorico.Rows(e.RowIndex).Cells(5).Value.ToString()
                Dim fechafin As Date = DgvHistorico.Rows(e.RowIndex).Cells(6).Value.ToString()
                Try
                    consultas_bd.borrar_TRM(conexion_pos, codigo, fechaini.ToString("yyyyMMdd"), fechafin.ToString("yyyyMMdd"))
                    MsgBox("Se borro correctamente la TRM")
                    DgvHistorico.Rows.RemoveAt(e.RowIndex)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If
        End If
    End Sub
End Class