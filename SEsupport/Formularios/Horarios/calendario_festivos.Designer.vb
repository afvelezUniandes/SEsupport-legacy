<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calendario_festivos
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
        Me.LblAño = New System.Windows.Forms.Label()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.Calendario = New System.Windows.Forms.MonthCalendar()
        Me.DgvFestivo = New System.Windows.Forms.DataGridView()
        Me.TxbAño = New System.Windows.Forms.MaskedTextBox()
        CType(Me.DgvFestivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblAño
        '
        Me.LblAño.AutoSize = True
        Me.LblAño.Location = New System.Drawing.Point(14, 17)
        Me.LblAño.Name = "LblAño"
        Me.LblAño.Size = New System.Drawing.Size(26, 13)
        Me.LblAño.TabIndex = 0
        Me.LblAño.Text = "Año"
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Location = New System.Drawing.Point(117, 15)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtnConsultar.TabIndex = 2
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'Calendario
        '
        Me.Calendario.CalendarDimensions = New System.Drawing.Size(2, 2)
        Me.Calendario.FirstDayOfWeek = System.Windows.Forms.Day.Monday
        Me.Calendario.Location = New System.Drawing.Point(264, 52)
        Me.Calendario.MaxSelectionCount = 1
        Me.Calendario.Name = "Calendario"
        Me.Calendario.ShowTodayCircle = False
        Me.Calendario.TabIndex = 4
        '
        'DgvFestivo
        '
        Me.DgvFestivo.AllowUserToAddRows = False
        Me.DgvFestivo.AllowUserToDeleteRows = False
        Me.DgvFestivo.AllowUserToOrderColumns = True
        Me.DgvFestivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFestivo.Location = New System.Drawing.Point(12, 52)
        Me.DgvFestivo.Name = "DgvFestivo"
        Me.DgvFestivo.ReadOnly = True
        Me.DgvFestivo.Size = New System.Drawing.Size(240, 313)
        Me.DgvFestivo.TabIndex = 3
        '
        'TxbAño
        '
        Me.TxbAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbAño.Location = New System.Drawing.Point(47, 15)
        Me.TxbAño.Mask = "9999"
        Me.TxbAño.Name = "TxbAño"
        Me.TxbAño.Size = New System.Drawing.Size(52, 21)
        Me.TxbAño.TabIndex = 1
        '
        'calendario_festivos
        '
        Me.AcceptButton = Me.BtnConsultar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 385)
        Me.Controls.Add(Me.TxbAño)
        Me.Controls.Add(Me.DgvFestivo)
        Me.Controls.Add(Me.Calendario)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.LblAño)
        Me.Name = "calendario_festivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "calendario_festivos"
        CType(Me.DgvFestivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblAño As System.Windows.Forms.Label
    Friend WithEvents BtnConsultar As System.Windows.Forms.Button
    Friend WithEvents Calendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents DgvFestivo As System.Windows.Forms.DataGridView
    Friend WithEvents TxbAño As System.Windows.Forms.MaskedTextBox
End Class
