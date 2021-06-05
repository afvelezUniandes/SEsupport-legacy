<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Codigos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Codigos))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pbxbarras = New System.Windows.Forms.PictureBox()
        Me.btngenerar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtean = New System.Windows.Forms.TextBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtreferencia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Usuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpresiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnimprimir = New System.Windows.Forms.Button()
        Me.ConfiguraciónEtiquetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.pbxbarras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(129, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Codigo de Barras"
        '
        'pbxbarras
        '
        Me.pbxbarras.BackColor = System.Drawing.Color.White
        Me.pbxbarras.Location = New System.Drawing.Point(113, 37)
        Me.pbxbarras.Name = "pbxbarras"
        Me.pbxbarras.Size = New System.Drawing.Size(120, 60)
        Me.pbxbarras.TabIndex = 9
        Me.pbxbarras.TabStop = False
        '
        'btngenerar
        '
        Me.btngenerar.Location = New System.Drawing.Point(91, 294)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(75, 23)
        Me.btngenerar.TabIndex = 10
        Me.btngenerar.Text = "Generar"
        Me.btngenerar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtean)
        Me.Panel1.Controls.Add(Me.txtdescripcion)
        Me.Panel1.Controls.Add(Me.txtreferencia)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(24, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 126)
        Me.Panel1.TabIndex = 11
        '
        'txtean
        '
        Me.txtean.Location = New System.Drawing.Point(106, 83)
        Me.txtean.Name = "txtean"
        Me.txtean.Size = New System.Drawing.Size(204, 20)
        Me.txtean.TabIndex = 14
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(106, 53)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(204, 20)
        Me.txtdescripcion.TabIndex = 13
        '
        'txtreferencia
        '
        Me.txtreferencia.Location = New System.Drawing.Point(106, 23)
        Me.txtreferencia.Name = "txtreferencia"
        Me.txtreferencia.Size = New System.Drawing.Size(63, 20)
        Me.txtreferencia.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Codigo EAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Referencia"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.pbxbarras)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(24, 168)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(340, 120)
        Me.Panel2.TabIndex = 12
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministraciónToolStripMenuItem, Me.Usuario, Me.HerramientasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(398, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministraciónToolStripMenuItem
        '
        Me.AdministraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.AdministraciónToolStripMenuItem.Name = "AdministraciónToolStripMenuItem"
        Me.AdministraciónToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.AdministraciónToolStripMenuItem.Text = "Administración"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Usuario
        '
        Me.Usuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Usuario.MergeIndex = 0
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(59, 20)
        Me.Usuario.Text = "Usuario"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImpresiónToolStripMenuItem, Me.ConfiguraciónEtiquetaToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'ImpresiónToolStripMenuItem
        '
        Me.ImpresiónToolStripMenuItem.Name = "ImpresiónToolStripMenuItem"
        Me.ImpresiónToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ImpresiónToolStripMenuItem.Text = "Impresión"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'btnimprimir
        '
        Me.btnimprimir.Location = New System.Drawing.Point(203, 294)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnimprimir.TabIndex = 14
        Me.btnimprimir.Text = "Imprimir"
        Me.btnimprimir.UseVisualStyleBackColor = True
        '
        'ConfiguraciónEtiquetaToolStripMenuItem
        '
        Me.ConfiguraciónEtiquetaToolStripMenuItem.Name = "ConfiguraciónEtiquetaToolStripMenuItem"
        Me.ConfiguraciónEtiquetaToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ConfiguraciónEtiquetaToolStripMenuItem.Text = "Configuración etiqueta"
        '
        'Codigos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 328)
        Me.Controls.Add(Me.btnimprimir)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btngenerar)
        Me.Name = "Codigos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generador de Codigos de Barras"
        CType(Me.pbxbarras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents pbxbarras As PictureBox
    Friend WithEvents btngenerar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtean As TextBox
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents txtreferencia As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdministraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Usuario As ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImpresiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents btnimprimir As Button
    Friend WithEvents ConfiguraciónEtiquetaToolStripMenuItem As ToolStripMenuItem
End Class
