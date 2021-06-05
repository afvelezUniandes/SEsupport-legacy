Public Class calendario_festivos

    Dim DateSelected As Date = Nothing
    Private Sub calendario_festivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Calendario.datefr
        TxbAño.Focus()
        Calendario.Enabled = False

    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Dim consultar As New Querys_horario
        Dim dtconsulta As New DataTable

        dtconsulta = consultar.cons_festivos_calendario("", "", TxbAño.Text)

        DgvFestivo.Columns.Clear()
        DgvFestivo.Rows.Clear()

        Dim columna_eliminar As New DataGridViewButtonColumn
        With columna_eliminar
            .Name = "Eliminar"
            .HeaderText = "Eliminar"
            .Frozen = True
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        End With
        DgvFestivo.Columns.Add(columna_eliminar)

        Dim columna_fecha As New DataGridViewTextBoxColumn
        With columna_fecha
            .Name = "Fecha"
            .HeaderText = "Fecha"
            .Frozen = False
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .ReadOnly = True
        End With
        DgvFestivo.Columns.Add(columna_fecha)

        For i = 0 To dtconsulta.Rows.Count() - 1
            DgvFestivo.Rows.Add()
            DgvFestivo.Rows(i).Cells(1).Value = dtconsulta.Rows(i)(0).ToString()
        Next

        Calendario.Enabled = True
        BtnConsultar.Enabled = False
        TxbAño.Enabled = False
    End Sub

    Private Sub calendario_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Calendario.MouseDown
        If DateSelected.Equals(Calendario.SelectionStart) Then
            Dim ejecutar As New Querys_horario
            DgvFestivo.Rows.Add()
            DgvFestivo.Rows(DgvFestivo.Rows.Count() - 1).Cells(1).Value = Calendario.SelectionStart.ToString("dd/MM/yyyy")
            ejecutar.ins_festivos_calendario(TxbAño.Text, Calendario.SelectionStart.ToString("yyyyMMdd"))
            DateSelected = Nothing
            DgvFestivo.Sort(DgvFestivo.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        Else
            DateSelected = Calendario.SelectionRange.Start
        End If
    End Sub

    Private Sub DgvFestivo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvFestivo.CellContentClick
        If e.ColumnIndex = 0 Then
            Dim i As Integer = MsgBox("Por favor confirmar si desea elminiar la fecha del horario", MsgBoxStyle.YesNo)
            If i = 6 Then
                Dim ejecutar As New Querys_horario
                ejecutar.borrar_festivos_calendario(TxbAño.Text, CDate(DgvFestivo.Rows(e.RowIndex).Cells(1).Value).ToString("yyyyMMdd"))
                DgvFestivo.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

End Class