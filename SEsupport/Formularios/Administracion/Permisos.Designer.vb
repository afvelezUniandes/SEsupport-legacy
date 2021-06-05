<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Permisos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Usuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.volverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CmbUsuario = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpermisos = New System.Windows.Forms.DataGridView()
        Me.Cmbtus = New System.Windows.Forms.ComboBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dtpermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Usuario
        '
        Me.Usuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Usuario.MergeIndex = 0
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(73, 24)
        Me.Usuario.Text = "Usuario"
        '
        'AdministraciónToolStripMenuItem
        '
        Me.AdministraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.volverToolStripMenuItem})
        Me.AdministraciónToolStripMenuItem.Name = "AdministraciónToolStripMenuItem"
        Me.AdministraciónToolStripMenuItem.Size = New System.Drawing.Size(123, 24)
        Me.AdministraciónToolStripMenuItem.Text = "Administración"
        '
        'volverToolStripMenuItem
        '
        Me.volverToolStripMenuItem.Name = "volverToolStripMenuItem"
        Me.volverToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.volverToolStripMenuItem.Text = "Volver al Inicio"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministraciónToolStripMenuItem, Me.Usuario})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(437, 28)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CmbUsuario
        '
        Me.CmbUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbUsuario.FormattingEnabled = True
        Me.CmbUsuario.Location = New System.Drawing.Point(37, 59)
        Me.CmbUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbUsuario.Name = "CmbUsuario"
        Me.CmbUsuario.Size = New System.Drawing.Size(355, 24)
        Me.CmbUsuario.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 39)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 87)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Tipo de Usuario"
        '
        'dtpermisos
        '
        Me.dtpermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtpermisos.Location = New System.Drawing.Point(36, 153)
        Me.dtpermisos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpermisos.Name = "dtpermisos"
        Me.dtpermisos.RowHeadersWidth = 51
        Me.dtpermisos.Size = New System.Drawing.Size(357, 332)
        Me.dtpermisos.TabIndex = 28
        '
        'Cmbtus
        '
        Me.Cmbtus.FormattingEnabled = True
        Me.Cmbtus.Location = New System.Drawing.Point(37, 107)
        Me.Cmbtus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cmbtus.Name = "Cmbtus"
        Me.Cmbtus.Size = New System.Drawing.Size(356, 24)
        Me.Cmbtus.TabIndex = 29
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(123, 496)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(185, 28)
        Me.BtnGuardar.TabIndex = 30
        Me.BtnGuardar.Text = "GUARDAR"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Permisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 539)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Cmbtus)
        Me.Controls.Add(Me.dtpermisos)
        Me.Controls.Add(Me.CmbUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Permisos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Permisos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dtpermisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Usuario As ToolStripMenuItem
    Friend WithEvents AdministraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents volverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CmbUsuario As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpermisos As DataGridView
    Friend WithEvents Cmbtus As ComboBox
    Friend WithEvents BtnGuardar As Button
End Class
