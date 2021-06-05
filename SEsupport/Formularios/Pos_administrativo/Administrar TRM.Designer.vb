<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrar_TRM
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
        Me.LblSelMoneda = New System.Windows.Forms.Label()
        Me.CmbMoneda = New System.Windows.Forms.ComboBox()
        Me.DgvHistorico = New System.Windows.Forms.DataGridView()
        Me.Borrar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.LblNuevoValor = New System.Windows.Forms.Label()
        Me.LblFechaInicio = New System.Windows.Forms.Label()
        Me.LblFechaFin = New System.Windows.Forms.Label()
        Me.DtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxbValor = New System.Windows.Forms.TextBox()
        CType(Me.DgvHistorico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblSelMoneda
        '
        Me.LblSelMoneda.AutoSize = True
        Me.LblSelMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSelMoneda.Location = New System.Drawing.Point(6, 16)
        Me.LblSelMoneda.Name = "LblSelMoneda"
        Me.LblSelMoneda.Size = New System.Drawing.Size(167, 17)
        Me.LblSelMoneda.TabIndex = 0
        Me.LblSelMoneda.Text = "Seleccione la moneda"
        '
        'CmbMoneda
        '
        Me.CmbMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMoneda.FormattingEnabled = True
        Me.CmbMoneda.Location = New System.Drawing.Point(179, 13)
        Me.CmbMoneda.Name = "CmbMoneda"
        Me.CmbMoneda.Size = New System.Drawing.Size(163, 24)
        Me.CmbMoneda.TabIndex = 1
        '
        'DgvHistorico
        '
        Me.DgvHistorico.AllowUserToAddRows = False
        Me.DgvHistorico.AllowUserToDeleteRows = False
        Me.DgvHistorico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvHistorico.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Borrar})
        Me.DgvHistorico.Location = New System.Drawing.Point(9, 191)
        Me.DgvHistorico.Name = "DgvHistorico"
        Me.DgvHistorico.ReadOnly = True
        Me.DgvHistorico.Size = New System.Drawing.Size(722, 150)
        Me.DgvHistorico.TabIndex = 2
        '
        'Borrar
        '
        Me.Borrar.Frozen = True
        Me.Borrar.HeaderText = "Borrar"
        Me.Borrar.Name = "Borrar"
        Me.Borrar.ReadOnly = True
        Me.Borrar.Width = 41
        '
        'LblNuevoValor
        '
        Me.LblNuevoValor.AutoSize = True
        Me.LblNuevoValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNuevoValor.Location = New System.Drawing.Point(21, 25)
        Me.LblNuevoValor.Name = "LblNuevoValor"
        Me.LblNuevoValor.Size = New System.Drawing.Size(97, 17)
        Me.LblNuevoValor.TabIndex = 3
        Me.LblNuevoValor.Text = "Nuevo Valor"
        '
        'LblFechaInicio
        '
        Me.LblFechaInicio.AutoSize = True
        Me.LblFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaInicio.Location = New System.Drawing.Point(21, 54)
        Me.LblFechaInicio.Name = "LblFechaInicio"
        Me.LblFechaInicio.Size = New System.Drawing.Size(95, 17)
        Me.LblFechaInicio.TabIndex = 4
        Me.LblFechaInicio.Text = "Fecha Inicio"
        '
        'LblFechaFin
        '
        Me.LblFechaFin.AutoSize = True
        Me.LblFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaFin.Location = New System.Drawing.Point(359, 53)
        Me.LblFechaFin.Name = "LblFechaFin"
        Me.LblFechaFin.Size = New System.Drawing.Size(79, 17)
        Me.LblFechaFin.TabIndex = 5
        Me.LblFechaFin.Text = "Fecha Fin"
        '
        'DtpFechaIni
        '
        Me.DtpFechaIni.Location = New System.Drawing.Point(133, 50)
        Me.DtpFechaIni.Name = "DtpFechaIni"
        Me.DtpFechaIni.Size = New System.Drawing.Size(200, 20)
        Me.DtpFechaIni.TabIndex = 6
        '
        'DtpFechaFin
        '
        Me.DtpFechaFin.Location = New System.Drawing.Point(444, 50)
        Me.DtpFechaFin.Name = "DtpFechaFin"
        Me.DtpFechaFin.Size = New System.Drawing.Size(200, 20)
        Me.DtpFechaFin.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Controls.Add(Me.TxbValor)
        Me.GroupBox1.Controls.Add(Me.DtpFechaFin)
        Me.GroupBox1.Controls.Add(Me.DtpFechaIni)
        Me.GroupBox1.Controls.Add(Me.LblFechaFin)
        Me.GroupBox1.Controls.Add(Me.LblFechaInicio)
        Me.GroupBox1.Controls.Add(Me.LblNuevoValor)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(723, 137)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Valores"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(298, 83)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(116, 40)
        Me.BtnGuardar.TabIndex = 9
        Me.BtnGuardar.Text = "GUARDAR"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'TxbValor
        '
        Me.TxbValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbValor.Location = New System.Drawing.Point(133, 19)
        Me.TxbValor.Name = "TxbValor"
        Me.TxbValor.Size = New System.Drawing.Size(100, 23)
        Me.TxbValor.TabIndex = 8
        '
        'Administrar_TRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 353)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgvHistorico)
        Me.Controls.Add(Me.CmbMoneda)
        Me.Controls.Add(Me.LblSelMoneda)
        Me.Name = "Administrar_TRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar_TRM"
        CType(Me.DgvHistorico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblSelMoneda As System.Windows.Forms.Label
    Friend WithEvents CmbMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents DgvHistorico As System.Windows.Forms.DataGridView
    Friend WithEvents LblNuevoValor As System.Windows.Forms.Label
    Friend WithEvents LblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents LblFechaFin As System.Windows.Forms.Label
    Friend WithEvents DtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents TxbValor As System.Windows.Forms.TextBox
    Friend WithEvents Borrar As System.Windows.Forms.DataGridViewButtonColumn
End Class
