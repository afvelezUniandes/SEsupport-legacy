<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crear_horario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblEmpleado = New System.Windows.Forms.Label()
        Me.Cmbempleado = New System.Windows.Forms.ComboBox()
        Me.CmbArea = New System.Windows.Forms.ComboBox()
        Me.LblArea = New System.Windows.Forms.Label()
        Me.DgvHorario = New System.Windows.Forms.DataGridView()
        Me.LblFechaIni = New System.Windows.Forms.Label()
        Me.LblFechaFin = New System.Windows.Forms.Label()
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.BtnGenerarHorario = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnAgregarEmpleado = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CmbTipoArea = New System.Windows.Forms.ComboBox()
        Me.LblTipoArea = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxbAuxdescansospend = New System.Windows.Forms.TextBox()
        Me.TxbAuxHorasTrab = New System.Windows.Forms.TextBox()
        Me.BtnGuardarHorario = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxbDescansosPend = New System.Windows.Forms.TextBox()
        Me.TxbHorasTrab = New System.Windows.Forms.TextBox()
        Me.LblDescansos = New System.Windows.Forms.Label()
        Me.LblHoras = New System.Windows.Forms.Label()
        Me.BtnNuevoHorario = New System.Windows.Forms.Button()
        CType(Me.DgvHorario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblEmpleado
        '
        Me.LblEmpleado.AutoSize = True
        Me.LblEmpleado.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmpleado.Location = New System.Drawing.Point(18, 24)
        Me.LblEmpleado.Name = "LblEmpleado"
        Me.LblEmpleado.Size = New System.Drawing.Size(66, 16)
        Me.LblEmpleado.TabIndex = 4
        Me.LblEmpleado.Text = "Empleado"
        '
        'Cmbempleado
        '
        Me.Cmbempleado.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbempleado.FormattingEnabled = True
        Me.Cmbempleado.Location = New System.Drawing.Point(90, 21)
        Me.Cmbempleado.Name = "Cmbempleado"
        Me.Cmbempleado.Size = New System.Drawing.Size(401, 24)
        Me.Cmbempleado.TabIndex = 5
        '
        'CmbArea
        '
        Me.CmbArea.FormattingEnabled = True
        Me.CmbArea.Location = New System.Drawing.Point(133, 54)
        Me.CmbArea.Name = "CmbArea"
        Me.CmbArea.Size = New System.Drawing.Size(199, 24)
        Me.CmbArea.TabIndex = 7
        '
        'LblArea
        '
        Me.LblArea.AutoSize = True
        Me.LblArea.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblArea.Location = New System.Drawing.Point(18, 57)
        Me.LblArea.Name = "LblArea"
        Me.LblArea.Size = New System.Drawing.Size(109, 16)
        Me.LblArea.TabIndex = 6
        Me.LblArea.Text = "Punto Marcación"
        '
        'DgvHorario
        '
        Me.DgvHorario.AllowUserToAddRows = False
        Me.DgvHorario.AllowUserToDeleteRows = False
        Me.DgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvHorario.Location = New System.Drawing.Point(16, 231)
        Me.DgvHorario.Name = "DgvHorario"
        Me.DgvHorario.Size = New System.Drawing.Size(764, 301)
        Me.DgvHorario.TabIndex = 10
        '
        'LblFechaIni
        '
        Me.LblFechaIni.AutoSize = True
        Me.LblFechaIni.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaIni.Location = New System.Drawing.Point(10, 20)
        Me.LblFechaIni.Name = "LblFechaIni"
        Me.LblFechaIni.Size = New System.Drawing.Size(85, 16)
        Me.LblFechaIni.TabIndex = 11
        Me.LblFechaIni.Text = "Fecha Inicial"
        '
        'LblFechaFin
        '
        Me.LblFechaFin.AutoSize = True
        Me.LblFechaFin.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaFin.Location = New System.Drawing.Point(10, 42)
        Me.LblFechaFin.Name = "LblFechaFin"
        Me.LblFechaFin.Size = New System.Drawing.Size(77, 16)
        Me.LblFechaFin.TabIndex = 12
        Me.LblFechaFin.Text = "Fecha Final"
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaIni.Location = New System.Drawing.Point(102, 14)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(246, 22)
        Me.dtpFechaIni.TabIndex = 13
        '
        'DtpFechaFin
        '
        Me.DtpFechaFin.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFechaFin.Location = New System.Drawing.Point(102, 42)
        Me.DtpFechaFin.Name = "DtpFechaFin"
        Me.DtpFechaFin.Size = New System.Drawing.Size(246, 22)
        Me.DtpFechaFin.TabIndex = 14
        '
        'BtnGenerarHorario
        '
        Me.BtnGenerarHorario.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenerarHorario.Location = New System.Drawing.Point(103, 70)
        Me.BtnGenerarHorario.Name = "BtnGenerarHorario"
        Me.BtnGenerarHorario.Size = New System.Drawing.Size(164, 29)
        Me.BtnGenerarHorario.TabIndex = 15
        Me.BtnGenerarHorario.Text = "Generar Horario"
        Me.BtnGenerarHorario.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnGenerarHorario)
        Me.GroupBox1.Controls.Add(Me.DtpFechaFin)
        Me.GroupBox1.Controls.Add(Me.dtpFechaIni)
        Me.GroupBox1.Controls.Add(Me.LblFechaFin)
        Me.GroupBox1.Controls.Add(Me.LblFechaIni)
        Me.GroupBox1.Location = New System.Drawing.Point(408, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 105)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PASO 2"
        '
        'BtnAgregarEmpleado
        '
        Me.BtnAgregarEmpleado.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarEmpleado.Location = New System.Drawing.Point(167, 51)
        Me.BtnAgregarEmpleado.Name = "BtnAgregarEmpleado"
        Me.BtnAgregarEmpleado.Size = New System.Drawing.Size(141, 28)
        Me.BtnAgregarEmpleado.TabIndex = 17
        Me.BtnAgregarEmpleado.Text = "Agregar Empleado"
        Me.BtnAgregarEmpleado.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmbTipoArea)
        Me.GroupBox2.Controls.Add(Me.LblTipoArea)
        Me.GroupBox2.Controls.Add(Me.CmbArea)
        Me.GroupBox2.Controls.Add(Me.LblArea)
        Me.GroupBox2.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(16, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(367, 105)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PASO 1"
        '
        'CmbTipoArea
        '
        Me.CmbTipoArea.FormattingEnabled = True
        Me.CmbTipoArea.Location = New System.Drawing.Point(59, 19)
        Me.CmbTipoArea.Name = "CmbTipoArea"
        Me.CmbTipoArea.Size = New System.Drawing.Size(273, 24)
        Me.CmbTipoArea.TabIndex = 19
        '
        'LblTipoArea
        '
        Me.LblTipoArea.AutoSize = True
        Me.LblTipoArea.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipoArea.Location = New System.Drawing.Point(18, 22)
        Me.LblTipoArea.Name = "LblTipoArea"
        Me.LblTipoArea.Size = New System.Drawing.Size(35, 16)
        Me.LblTipoArea.TabIndex = 18
        Me.LblTipoArea.Text = "Área"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxbAuxdescansospend)
        Me.GroupBox3.Controls.Add(Me.TxbAuxHorasTrab)
        Me.GroupBox3.Controls.Add(Me.Cmbempleado)
        Me.GroupBox3.Controls.Add(Me.BtnAgregarEmpleado)
        Me.GroupBox3.Controls.Add(Me.LblEmpleado)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 132)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(508, 89)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PASO 3"
        '
        'TxbAuxdescansospend
        '
        Me.TxbAuxdescansospend.Enabled = False
        Me.TxbAuxdescansospend.Location = New System.Drawing.Point(437, 56)
        Me.TxbAuxdescansospend.Name = "TxbAuxdescansospend"
        Me.TxbAuxdescansospend.Size = New System.Drawing.Size(24, 20)
        Me.TxbAuxdescansospend.TabIndex = 19
        Me.TxbAuxdescansospend.Visible = False
        '
        'TxbAuxHorasTrab
        '
        Me.TxbAuxHorasTrab.Enabled = False
        Me.TxbAuxHorasTrab.Location = New System.Drawing.Point(467, 56)
        Me.TxbAuxHorasTrab.Name = "TxbAuxHorasTrab"
        Me.TxbAuxHorasTrab.Size = New System.Drawing.Size(24, 20)
        Me.TxbAuxHorasTrab.TabIndex = 18
        Me.TxbAuxHorasTrab.Visible = False
        '
        'BtnGuardarHorario
        '
        Me.BtnGuardarHorario.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardarHorario.Location = New System.Drawing.Point(12, 538)
        Me.BtnGuardarHorario.Name = "BtnGuardarHorario"
        Me.BtnGuardarHorario.Size = New System.Drawing.Size(141, 32)
        Me.BtnGuardarHorario.TabIndex = 19
        Me.BtnGuardarHorario.Text = "Guardar Horario"
        Me.BtnGuardarHorario.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxbDescansosPend)
        Me.GroupBox4.Controls.Add(Me.TxbHorasTrab)
        Me.GroupBox4.Controls.Add(Me.LblDescansos)
        Me.GroupBox4.Controls.Add(Me.LblHoras)
        Me.GroupBox4.Location = New System.Drawing.Point(543, 133)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(237, 87)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos Empleado"
        '
        'TxbDescansosPend
        '
        Me.TxbDescansosPend.Location = New System.Drawing.Point(139, 47)
        Me.TxbDescansosPend.Name = "TxbDescansosPend"
        Me.TxbDescansosPend.Size = New System.Drawing.Size(74, 20)
        Me.TxbDescansosPend.TabIndex = 3
        '
        'TxbHorasTrab
        '
        Me.TxbHorasTrab.Location = New System.Drawing.Point(139, 12)
        Me.TxbHorasTrab.Name = "TxbHorasTrab"
        Me.TxbHorasTrab.Size = New System.Drawing.Size(74, 20)
        Me.TxbHorasTrab.TabIndex = 2
        '
        'LblDescansos
        '
        Me.LblDescansos.AutoSize = True
        Me.LblDescansos.Location = New System.Drawing.Point(18, 50)
        Me.LblDescansos.Name = "LblDescansos"
        Me.LblDescansos.Size = New System.Drawing.Size(115, 13)
        Me.LblDescansos.TabIndex = 1
        Me.LblDescansos.Text = "Descansos pendientes"
        '
        'LblHoras
        '
        Me.LblHoras.AutoSize = True
        Me.LblHoras.Location = New System.Drawing.Point(18, 20)
        Me.LblHoras.Name = "LblHoras"
        Me.LblHoras.Size = New System.Drawing.Size(91, 13)
        Me.LblHoras.TabIndex = 0
        Me.LblHoras.Text = "Horas Trabajadas"
        '
        'BtnNuevoHorario
        '
        Me.BtnNuevoHorario.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevoHorario.Location = New System.Drawing.Point(639, 538)
        Me.BtnNuevoHorario.Name = "BtnNuevoHorario"
        Me.BtnNuevoHorario.Size = New System.Drawing.Size(141, 32)
        Me.BtnNuevoHorario.TabIndex = 21
        Me.BtnNuevoHorario.Text = "Nuevo Horario"
        Me.BtnNuevoHorario.UseVisualStyleBackColor = True
        '
        'Crear_horario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.BtnNuevoHorario)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.BtnGuardarHorario)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgvHorario)
        Me.Name = "Crear_horario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear_horario"
        CType(Me.DgvHorario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblEmpleado As System.Windows.Forms.Label
    Friend WithEvents Cmbempleado As System.Windows.Forms.ComboBox
    Friend WithEvents CmbArea As System.Windows.Forms.ComboBox
    Friend WithEvents LblArea As System.Windows.Forms.Label
    Friend WithEvents DgvHorario As System.Windows.Forms.DataGridView
    Friend WithEvents LblFechaIni As System.Windows.Forms.Label
    Friend WithEvents LblFechaFin As System.Windows.Forms.Label
    Friend WithEvents dtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnGenerarHorario As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAgregarEmpleado As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbTipoArea As System.Windows.Forms.ComboBox
    Friend WithEvents LblTipoArea As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnGuardarHorario As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents LblDescansos As System.Windows.Forms.Label
    Friend WithEvents LblHoras As System.Windows.Forms.Label
    Friend WithEvents TxbDescansosPend As System.Windows.Forms.TextBox
    Friend WithEvents TxbHorasTrab As System.Windows.Forms.TextBox
    Friend WithEvents TxbAuxHorasTrab As System.Windows.Forms.TextBox
    Friend WithEvents BtnNuevoHorario As System.Windows.Forms.Button
    Friend WithEvents TxbAuxdescansospend As System.Windows.Forms.TextBox
End Class
