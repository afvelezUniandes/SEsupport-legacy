<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class seleccion_turno_horario
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
        Me.cmbturno = New System.Windows.Forms.ComboBox()
        Me.LblTurno = New System.Windows.Forms.Label()
        Me.LblHoraFin = New System.Windows.Forms.Label()
        Me.LblHoraInicio = New System.Windows.Forms.Label()
        Me.txbhorainicio = New System.Windows.Forms.MaskedTextBox()
        Me.txbhorafin = New System.Windows.Forms.MaskedTextBox()
        Me.BtnSeleccionar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbturno
        '
        Me.cmbturno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbturno.FormattingEnabled = True
        Me.cmbturno.Location = New System.Drawing.Point(46, 4)
        Me.cmbturno.Name = "cmbturno"
        Me.cmbturno.Size = New System.Drawing.Size(184, 23)
        Me.cmbturno.TabIndex = 0
        '
        'LblTurno
        '
        Me.LblTurno.AutoSize = True
        Me.LblTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTurno.Location = New System.Drawing.Point(2, 9)
        Me.LblTurno.Name = "LblTurno"
        Me.LblTurno.Size = New System.Drawing.Size(40, 13)
        Me.LblTurno.TabIndex = 1
        Me.LblTurno.Text = "Turno"
        '
        'LblHoraFin
        '
        Me.LblHoraFin.AutoSize = True
        Me.LblHoraFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHoraFin.Location = New System.Drawing.Point(124, 37)
        Me.LblHoraFin.Name = "LblHoraFin"
        Me.LblHoraFin.Size = New System.Drawing.Size(55, 13)
        Me.LblHoraFin.TabIndex = 3
        Me.LblHoraFin.Text = "Hora Fin"
        '
        'LblHoraInicio
        '
        Me.LblHoraInicio.AutoSize = True
        Me.LblHoraInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHoraInicio.Location = New System.Drawing.Point(2, 37)
        Me.LblHoraInicio.Name = "LblHoraInicio"
        Me.LblHoraInicio.Size = New System.Drawing.Size(69, 13)
        Me.LblHoraInicio.TabIndex = 5
        Me.LblHoraInicio.Text = "Hora Inicio"
        '
        'txbhorainicio
        '
        Me.txbhorainicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbhorainicio.Location = New System.Drawing.Point(72, 32)
        Me.txbhorainicio.Mask = "00:00"
        Me.txbhorainicio.Name = "txbhorainicio"
        Me.txbhorainicio.Size = New System.Drawing.Size(50, 21)
        Me.txbhorainicio.TabIndex = 6
        Me.txbhorainicio.ValidatingType = GetType(Date)
        '
        'txbhorafin
        '
        Me.txbhorafin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbhorafin.Location = New System.Drawing.Point(180, 33)
        Me.txbhorafin.Mask = "00:00"
        Me.txbhorafin.Name = "txbhorafin"
        Me.txbhorafin.Size = New System.Drawing.Size(50, 21)
        Me.txbhorafin.TabIndex = 7
        Me.txbhorafin.ValidatingType = GetType(Date)
        '
        'BtnSeleccionar
        '
        Me.BtnSeleccionar.Location = New System.Drawing.Point(79, 65)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(75, 23)
        Me.BtnSeleccionar.TabIndex = 8
        Me.BtnSeleccionar.Text = "Seleccionar"
        Me.BtnSeleccionar.UseVisualStyleBackColor = True
        '
        'seleccion_turno_horario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(233, 94)
        Me.Controls.Add(Me.BtnSeleccionar)
        Me.Controls.Add(Me.txbhorafin)
        Me.Controls.Add(Me.txbhorainicio)
        Me.Controls.Add(Me.LblHoraInicio)
        Me.Controls.Add(Me.LblHoraFin)
        Me.Controls.Add(Me.LblTurno)
        Me.Controls.Add(Me.cmbturno)
        Me.Name = "seleccion_turno_horario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "seleccion_turno_horario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbturno As System.Windows.Forms.ComboBox
    Friend WithEvents LblTurno As System.Windows.Forms.Label
    Friend WithEvents LblHoraFin As System.Windows.Forms.Label
    Friend WithEvents LblHoraInicio As System.Windows.Forms.Label
    Friend WithEvents txbhorainicio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txbhorafin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents BtnSeleccionar As System.Windows.Forms.Button
End Class
