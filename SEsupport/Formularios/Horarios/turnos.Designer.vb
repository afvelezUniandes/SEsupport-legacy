<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class turnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(turnos))
        Me.Lblarea = New System.Windows.Forms.Label()
        Me.cmbArea = New System.Windows.Forms.ComboBox()
        Me.Lblturno = New System.Windows.Forms.Label()
        Me.Cmbturno = New System.Windows.Forms.ComboBox()
        Me.LblHoraini = New System.Windows.Forms.Label()
        Me.LblHoraFin = New System.Windows.Forms.Label()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.txbhoraini = New System.Windows.Forms.MaskedTextBox()
        Me.txbhorafin = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lblarea
        '
        Me.Lblarea.AutoSize = True
        Me.Lblarea.Location = New System.Drawing.Point(22, 40)
        Me.Lblarea.Name = "Lblarea"
        Me.Lblarea.Size = New System.Drawing.Size(29, 13)
        Me.Lblarea.TabIndex = 0
        Me.Lblarea.Text = "Area"
        '
        'cmbArea
        '
        Me.cmbArea.FormattingEnabled = True
        Me.cmbArea.Location = New System.Drawing.Point(74, 40)
        Me.cmbArea.Name = "cmbArea"
        Me.cmbArea.Size = New System.Drawing.Size(121, 21)
        Me.cmbArea.TabIndex = 1
        '
        'Lblturno
        '
        Me.Lblturno.AutoSize = True
        Me.Lblturno.Location = New System.Drawing.Point(16, 72)
        Me.Lblturno.Name = "Lblturno"
        Me.Lblturno.Size = New System.Drawing.Size(35, 13)
        Me.Lblturno.TabIndex = 2
        Me.Lblturno.Text = "Turno"
        '
        'Cmbturno
        '
        Me.Cmbturno.FormattingEnabled = True
        Me.Cmbturno.Location = New System.Drawing.Point(57, 69)
        Me.Cmbturno.Name = "Cmbturno"
        Me.Cmbturno.Size = New System.Drawing.Size(121, 21)
        Me.Cmbturno.TabIndex = 3
        '
        'LblHoraini
        '
        Me.LblHoraini.AutoSize = True
        Me.LblHoraini.Location = New System.Drawing.Point(16, 131)
        Me.LblHoraini.Name = "LblHoraini"
        Me.LblHoraini.Size = New System.Drawing.Size(60, 13)
        Me.LblHoraini.TabIndex = 4
        Me.LblHoraini.Text = "Hora Inicial"
        '
        'LblHoraFin
        '
        Me.LblHoraFin.AutoSize = True
        Me.LblHoraFin.Location = New System.Drawing.Point(16, 169)
        Me.LblHoraFin.Name = "LblHoraFin"
        Me.LblHoraFin.Size = New System.Drawing.Size(55, 13)
        Me.LblHoraFin.TabIndex = 5
        Me.LblHoraFin.Text = "Hora Final"
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.Location = New System.Drawing.Point(16, 102)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.LblDescripcion.TabIndex = 7
        Me.LblDescripcion.Text = "Descripcion"
        '
        'txbhoraini
        '
        Me.txbhoraini.Location = New System.Drawing.Point(95, 131)
        Me.txbhoraini.Mask = "00:00"
        Me.txbhoraini.Name = "txbhoraini"
        Me.txbhoraini.Size = New System.Drawing.Size(46, 20)
        Me.txbhoraini.TabIndex = 8
        Me.txbhoraini.ValidatingType = GetType(Date)
        '
        'txbhorafin
        '
        Me.txbhorafin.Location = New System.Drawing.Point(95, 162)
        Me.txbhorafin.Mask = "00:00"
        Me.txbhorafin.Name = "txbhorafin"
        Me.txbhorafin.Size = New System.Drawing.Size(46, 20)
        Me.txbhorafin.TabIndex = 9
        Me.txbhorafin.ValidatingType = GetType(Date)
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(95, 102)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(251, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(375, 37)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(62, 34)
        Me.ToolStripButton1.Text = "Nuevo"
        Me.ToolStripButton1.ToolTipText = "Nuevo Turno"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(70, 34)
        Me.ToolStripButton2.Text = "Eliminar"
        '
        'turnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 203)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txbhorafin)
        Me.Controls.Add(Me.txbhoraini)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.LblHoraFin)
        Me.Controls.Add(Me.LblHoraini)
        Me.Controls.Add(Me.Cmbturno)
        Me.Controls.Add(Me.Lblturno)
        Me.Controls.Add(Me.cmbArea)
        Me.Controls.Add(Me.Lblarea)
        Me.Name = "turnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "turnos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lblarea As System.Windows.Forms.Label
    Friend WithEvents cmbArea As System.Windows.Forms.ComboBox
    Friend WithEvents Lblturno As System.Windows.Forms.Label
    Friend WithEvents Cmbturno As System.Windows.Forms.ComboBox
    Friend WithEvents LblHoraini As System.Windows.Forms.Label
    Friend WithEvents LblHoraFin As System.Windows.Forms.Label
    Friend WithEvents LblDescripcion As System.Windows.Forms.Label
    Friend WithEvents txbhoraini As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txbhorafin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
End Class
