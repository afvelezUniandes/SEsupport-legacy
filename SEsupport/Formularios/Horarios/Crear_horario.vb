Public Class Crear_horario
    Private crear_empleado As Boolean = False
    Private ingreso As Boolean = True
    Private dtturno As New DataTable
    Private Sub Crear_horario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'lleno el tipo de area 
        GroupBox1.Enabled = False
        GroupBox3.Enabled = False

        Dim dttipoarea As New DataTable
        Dim consultas As New Querys_horario

        dttipoarea = consultas.cons_tipo_area()
        CmbTipoArea.DataSource = dttipoarea
        CmbTipoArea.DisplayMember = dttipoarea.Columns(1).ToString()
        CmbTipoArea.ValueMember = dttipoarea.Columns(0).ToString()
        CmbTipoArea.Text = ""

        DgvHorario.EnableHeadersVisualStyles = False ' deshabilito los efectos visuales del datagridview

        seleccion_turno_horario.Show()
        seleccion_turno_horario.Visible = False
    End Sub

    Private Sub BtnAgregarEmpleado_Click(sender As Object, e As EventArgs) Handles BtnAgregarEmpleado.Click
        crear_empleado = True
        'adiciono el empleado al datagridview
        DgvHorario.Rows.Add()

        DgvHorario.Rows(DgvHorario.Rows.Count - 1).Cells(1).Value = Cmbempleado.SelectedValue.ToString()
        DgvHorario.Rows(DgvHorario.Rows.Count - 1).Cells(2).Value = Cmbempleado.Text.ToString()

        'ingreso los descansos que se deben a la fecha


        'ingreso los turnos a las columnas con fechas en el datagridview
        

        crear_empleado = False
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
    End Sub

    Private Sub BtnGenerarHorario_Click(sender As Object, e As EventArgs) Handles BtnGenerarHorario.Click
        crear_empleado = True
        Dim consultas As New Querys_horario
        Dim dtfestivos As New DataTable


       'de acuerdo a las fechas se crean las columnas del datagrivdiew
        Dim fecha_ini As Date = dtpFechaIni.Value
        Dim fecha_fin As Date = DtpFechaFin.Value

        dtturno = consultas.cons_turno(CmbArea.SelectedValue.ToString())
        dtfestivos = consultas.cons_festivos_calendario(fecha_ini.ToString("yyyyMMdd"), fecha_fin.ToString("yyyyMMdd"), "")

        DgvHorario.Columns.Clear()
        DgvHorario.Rows.Clear()

        Dim columna_eliminar As New DataGridViewButtonColumn
        With columna_eliminar
            .Name = "Eliminar"
            .HeaderText = "Eliminar"
            .Frozen = True
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader            
        End With       
        DgvHorario.Columns.Add(columna_eliminar)

        Dim columna_cedula As New DataGridViewTextBoxColumn
        With columna_cedula
            .Name = "Cedula"
            .HeaderText = "Cédula"
            .Frozen = True
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            .ReadOnly = True
        End With
        DgvHorario.Columns.Add(columna_cedula)

        Dim columna_nombre As New DataGridViewTextBoxColumn
        With columna_nombre
            .Name = "Nombre"
            .HeaderText = "Nombre"
            .Frozen = True
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            .ReadOnly = True
        End With        
        DgvHorario.Columns.Add(columna_nombre)

        'While fecha_ini.ToString("yyyyMMdd") <= fecha_fin.ToString("yyyyMMdd") 'DateAdd(DateInterval.Day, 1, fecha_fin)
        '    Dim columnas_dias As New DataGridViewComboBoxColumn()
        '    With columnas_dias
        '        .Name = WeekdayName(Weekday(fecha_ini))
        '        .DataSource = dtturno
        '        .DisplayMember = dtturno.Columns(6).ToString()
        '        .ValueMember = dtturno.Columns(0).ToString()
        '        .HeaderText = WeekdayName(Weekday(fecha_ini)) + ", " + fecha_ini.ToString("dd-MM-yyyy")
        '        .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        '    End With
        '    DgvHorario.Columns.Add(columnas_dias)

        '    DgvHorario.AutoGenerateColumns = False

        '    fecha_ini = DateAdd(DateInterval.Day, 1, fecha_ini)
        'End While

        While fecha_ini.ToString("yyyyMMdd") <= fecha_fin.ToString("yyyyMMdd")
            Dim columnas_dias As New DataGridViewTextBoxColumn()
            With columnas_dias
                .Name = WeekdayName(Weekday(fecha_ini))
                .HeaderText = WeekdayName(Weekday(fecha_ini)) + ", " + fecha_ini.ToString("dd-MM-yyyy")
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                If Weekday(fecha_ini) = 1 Then
                    .DefaultCellStyle.BackColor = Color.CornflowerBlue
                End If
                If dtfestivos.Rows.Count > 0 Then
                    For i = 0 To dtfestivos.Rows.Count - 1
                        If fecha_ini.ToString("yyyyMMdd") = dtfestivos.Rows(i)(1).ToString() Then
                            .DefaultCellStyle.BackColor = Color.CornflowerBlue
                        End If
                    Next
                End If
            End With
            DgvHorario.Columns.Add(columnas_dias)

            DgvHorario.AutoGenerateColumns = False

            fecha_ini = DateAdd(DateInterval.Day, 1, fecha_ini)
        End While

        GroupBox3.Enabled = True
        cons_rel_usu_fecha()

        crear_empleado = False
    End Sub

    Private Sub CmbTipoArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTipoArea.SelectedIndexChanged
        'lleno el combobox de las areas
        Dim dtarea As New DataTable
        Dim consultas As New Querys_horario

        Try
            dtarea = consultas.cons_areas(CmbTipoArea.SelectedValue.ToString())
            CmbArea.DataSource = dtarea
            CmbArea.DisplayMember = dtarea.Columns(2).ToString()
            CmbArea.ValueMember = dtarea.Columns(0).ToString()
            CmbArea.Text = ""
        Catch ex As Exception

        End Try
                
    End Sub

    Private Sub CmbArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbArea.SelectedIndexChanged
        'lleno el combobox de los empleados
        Dim dtempleado As New DataTable
        Dim consultas As New Querys_horario

        Try
            dtempleado = consultas.cons_empleado(CmbTipoArea.SelectedValue.ToString())
            Cmbempleado.DataSource = dtempleado
            Cmbempleado.DisplayMember = dtempleado.Columns(1).ToString()
            Cmbempleado.ValueMember = dtempleado.Columns(0).ToString()
            Cmbempleado.Text = ""

            GroupBox1.Enabled = True
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub DgvHorario_CellTextChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvHorario.CellValueChanged ', DgvHorario.CellEndEdit
        If crear_empleado = False Then
            cons_horas_trabajadas(DgvHorario.Rows(e.RowIndex).Cells(1).Value.ToString())
        End If
    End Sub

    Sub cons_horas_trabajadas(cedula As String)
        Dim numerohoras As Integer = 0

        Try
            For j = 0 To DgvHorario.Rows.Count - 1

                Dim cedula_comparar As String = DgvHorario.Rows(j).Cells(1).Value.ToString()
                If cedula = cedula_comparar Then
                    For i = 3 To DgvHorario.Columns.Count - 1
                        Dim horas As String = DgvHorario.Rows(j).Cells(i).FormattedValue
                        Dim hora_inicial, hora_final As DateTime
                        hora_inicial = horas.Substring(horas.IndexOf("-") + 2, 5)
                        hora_final = horas.Substring(horas.LastIndexOf("-") + 2, 5)
                        If hora_inicial < hora_final Then
                            numerohoras = numerohoras + DateDiff(DateInterval.Hour, hora_inicial, hora_final)
                        Else
                            numerohoras = numerohoras + (DateDiff(DateInterval.Hour, hora_inicial, hora_final) + 24)
                        End If
                    Next
                End If
            Next
        Catch ex As Exception

        End Try

        TxbHorasTrab.Text = numerohoras + TxbAuxHorasTrab.Text
    End Sub


    Private Sub DgvHorario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvHorario.CellContentClick
        'If e.ColumnIndex = 0 Then
        ' Dim i As Integer = MsgBox("Por favor confirmar si desea elminiar el trabajador del horario", MsgBoxStyle.YesNo)
        ' If i = 6 Then
        ' DgvHorario.Rows.RemoveAt(e.RowIndex)
        ' End If
        ' End If
    End Sub

    Private Sub Cmbempleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbempleado.SelectedIndexChanged
        
        Dim consultas As New Querys_horario
        Dim dthoras, dtdescansos As New DataTable

        Try
            dthoras = consultas.cons_horas_trabajadas(Cmbempleado.SelectedValue.ToString(), dtpFechaIni.Text, DtpFechaFin.Text)
            dtdescansos = consultas.cons_horas_trabajadas(Cmbempleado.SelectedValue.ToString(), dtpFechaIni.Text, DtpFechaFin.Text)

            TxbAuxHorasTrab.Text = dthoras.Rows(0)(0).ToString()
            TxbHorasTrab.Text = TxbAuxHorasTrab.Text
        Catch ex As Exception

        End Try
        

    End Sub

    Private Sub BtnGuardarHorario_Click(sender As Object, e As EventArgs) Handles BtnGuardarHorario.Click
        Dim ingresar As New Querys_horario


        For i = 0 To DgvHorario.Rows.Count - 1
            Dim cedula As String = DgvHorario.Rows(i).Cells(1).Value.ToString()            
            For j = 3 To DgvHorario.Columns.Count - 1
                Dim fecha As String = DgvHorario.Columns.Item(j).HeaderText.ToString()
                fecha = fecha.Substring(fecha.IndexOf(",") + 2)
                Dim aux As String = DgvHorario.Rows(i).Cells(j).Value.ToString()
                Dim turno As String = Trim(aux.Substring(0, aux.IndexOf("-") - 1))
                Dim hora_inicial As String = Trim(aux.Substring(aux.IndexOf("-") + 2, 5))
                Dim hora_final As String = Trim(aux.Substring(aux.LastIndexOf("-") + 2, 5))
                ingresar.nuevo_horario(cedula, fecha, turno, CmbArea.SelectedValue.ToString(), nombre, hora_inicial, hora_final)
            Next
        Next
    End Sub

    Private Sub cons_rel_usu_fecha()
        Dim consultas As New Querys_horario
        Dim dtconsulta As New DataTable
        Dim fechainicial As Date = dtpFechaIni.Value
        Dim fechafinal As Date = DtpFechaFin.Value

        dtconsulta = consultas.cons_horario(fechainicial.ToString("yyyyMMdd"), fechafinal.ToString("yyyyMMdd"))

        If dtconsulta.Rows.Count > 0 Then
            For i = 0 To dtconsulta.Rows.Count - 1
                DgvHorario.Rows.Add()
                DgvHorario.Rows(i).Cells(1).Value = dtconsulta.Rows(i)(0).ToString()
                DgvHorario.Rows(i).Cells(2).Value = dtconsulta.Rows(i)(1).ToString()
                For j = 3 To DgvHorario.Columns.Count - 1
                    Dim fecha As String = DgvHorario.Columns.Item(j).HeaderText.ToString()
                    fecha = fecha.Substring(fecha.IndexOf(",") + 2)
                    Dim fechaaux As Date = fecha
                    fecha = fechaaux.ToString("yyyyMMdd")
                    If (dtconsulta.Columns.Item(j).ColumnName.ToString() = fecha) And (dtconsulta.Rows(i)(j).ToString() <> "") Then
                        Try
                            DgvHorario.Rows(i).Cells.Item(j).Value = dtconsulta.Rows(i).Item(j)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try

                    End If
                Next
            Next
        End If


    End Sub

    Private Sub BtnNuevoHorario_Click(sender As Object, e As EventArgs) Handles BtnNuevoHorario.Click
        Dim i As Integer = MsgBox("Antes de continuar por favor guarde el horario a traves del Botón 'Guardar Horario', ¿desea continuar de todas maneras?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo)
        If i = 6 Then
            DgvHorario.Columns.Clear()
            DgvHorario.Rows.Clear()
            CmbArea.DataSource = Nothing
            Cmbempleado.DataSource = Nothing
            CmbTipoArea.Text = ""
            GroupBox2.Enabled = True
            GroupBox1.Enabled = False
            GroupBox3.Enabled = False
        End If
        
    End Sub

    Private Sub DgvHorario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvHorario.CellClick
        If e.ColumnIndex >= 3 Then

            'dtturno.Rows.Add("-1", "-1", "-1", "-1", "-1", "0", "Descanso")
            Try
                seleccion_turno_horario.Close()
            Catch ex As Exception

            End Try

            seleccion_turno_horario.Show()
            seleccion_turno_horario.carga_inicial = True
            With seleccion_turno_horario.cmbturno
                .DataSource = dtturno
                .DisplayMember = dtturno.Columns(6).ToString()
                .ValueMember = dtturno.Columns(0).ToString()
                .Text = ""
            End With
            seleccion_turno_horario.carga_inicial = False
            seleccion_turno_horario.row = e.RowIndex
            seleccion_turno_horario.column = e.ColumnIndex
            If DgvHorario.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> "" Then
                seleccion_turno_horario.cmbturno.Text = DgvHorario.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            End If
        End If
    End Sub

    Private Sub Crear_horario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        seleccion_turno_horario.Close()
    End Sub

End Class