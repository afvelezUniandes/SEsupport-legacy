<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbxtdoc = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtnocta = New System.Windows.Forms.TextBox()
        Me.cbxcban = New System.Windows.Forms.ComboBox()
        Me.txtrazon = New System.Windows.Forms.TextBox()
        Me.txtnit = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.volverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Usuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnomban = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxtcta = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cbxtcta)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtnomban)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbxtdoc)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtemail)
        Me.Panel1.Controls.Add(Me.txtnocta)
        Me.Panel1.Controls.Add(Me.cbxcban)
        Me.Panel1.Controls.Add(Me.txtrazon)
        Me.Panel1.Controls.Add(Me.txtnit)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(12, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(296, 260)
        Me.Panel1.TabIndex = 0
        '
        'cbxtdoc
        '
        Me.cbxtdoc.FormattingEnabled = True
        Me.cbxtdoc.Items.AddRange(New Object() {"", "Cédula", "Cédula de Extranjería", "Nit", "Tarejta de Identidad", "Pasaporte"})
        Me.cbxtdoc.Location = New System.Drawing.Point(118, 42)
        Me.cbxtdoc.Name = "cbxtdoc"
        Me.cbxtdoc.Size = New System.Drawing.Size(158, 21)
        Me.cbxtdoc.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "*Tipo_Documento:"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(57, 226)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(219, 20)
        Me.txtemail.TabIndex = 27
        '
        'txtnocta
        '
        Me.txtnocta.Location = New System.Drawing.Point(104, 166)
        Me.txtnocta.Name = "txtnocta"
        Me.txtnocta.Size = New System.Drawing.Size(172, 20)
        Me.txtnocta.TabIndex = 26
        '
        'cbxcban
        '
        Me.cbxcban.FormattingEnabled = True
        Me.cbxcban.Location = New System.Drawing.Point(91, 105)
        Me.cbxcban.Name = "cbxcban"
        Me.cbxcban.Size = New System.Drawing.Size(185, 21)
        Me.cbxcban.TabIndex = 25
        '
        'txtrazon
        '
        Me.txtrazon.Location = New System.Drawing.Point(72, 76)
        Me.txtrazon.Name = "txtrazon"
        Me.txtrazon.Size = New System.Drawing.Size(204, 20)
        Me.txtrazon.TabIndex = 24
        '
        'txtnit
        '
        Me.txtnit.Location = New System.Drawing.Point(118, 12)
        Me.txtnit.Name = "txtnit"
        Me.txtnit.Size = New System.Drawing.Size(158, 20)
        Me.txtnit.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 229)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Email:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 173)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "*No_Cuenta:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "*Cod_Banco:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Nombre:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "*Nit_Proveedor:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministraciónToolStripMenuItem, Me.Usuario})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(324, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministraciónToolStripMenuItem
        '
        Me.AdministraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.volverToolStripMenuItem})
        Me.AdministraciónToolStripMenuItem.Name = "AdministraciónToolStripMenuItem"
        Me.AdministraciónToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.AdministraciónToolStripMenuItem.Text = "Administración"
        '
        'volverToolStripMenuItem
        '
        Me.volverToolStripMenuItem.Name = "volverToolStripMenuItem"
        Me.volverToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.volverToolStripMenuItem.Text = "Volver al Inicio"
        '
        'Usuario
        '
        Me.Usuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Usuario.MergeIndex = 0
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(59, 20)
        Me.Usuario.Text = "Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Nombre_Banco:"
        '
        'txtnomban
        '
        Me.txtnomban.Location = New System.Drawing.Point(104, 136)
        Me.txtnomban.Name = "txtnomban"
        Me.txtnomban.Size = New System.Drawing.Size(172, 20)
        Me.txtnomban.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Tipo_Cuenta:"
        '
        'cbxtcta
        '
        Me.cbxtcta.FormattingEnabled = True
        Me.cbxtcta.Location = New System.Drawing.Point(104, 195)
        Me.cbxtcta.Name = "cbxtcta"
        Me.cbxtcta.Size = New System.Drawing.Size(172, 21)
        Me.cbxtcta.TabIndex = 33
        '
        'Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Proveedores"
        Me.Text = "Proveedores"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdministraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents volverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Usuario As ToolStripMenuItem
    Friend WithEvents cbxtdoc As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtnocta As TextBox
    Friend WithEvents cbxcban As ComboBox
    Friend WithEvents txtrazon As TextBox
    Friend WithEvents txtnit As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbxtcta As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnomban As TextBox
    Friend WithEvents Label1 As Label
End Class
