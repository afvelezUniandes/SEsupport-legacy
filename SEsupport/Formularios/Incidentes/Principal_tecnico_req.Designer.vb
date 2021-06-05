<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal_tecnico_req
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
        Me.DgvHistorico = New System.Windows.Forms.DataGridView()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.CmbEstado = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoRequerimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FiltroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Usuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        CType(Me.DgvHistorico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvHistorico
        '
        Me.DgvHistorico.AllowUserToAddRows = False
        Me.DgvHistorico.AllowUserToDeleteRows = False
        Me.DgvHistorico.AllowUserToOrderColumns = True
        Me.DgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvHistorico.Location = New System.Drawing.Point(12, 67)
        Me.DgvHistorico.Name = "DgvHistorico"
        Me.DgvHistorico.ReadOnly = True
        Me.DgvHistorico.Size = New System.Drawing.Size(984, 651)
        Me.DgvHistorico.TabIndex = 0
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Location = New System.Drawing.Point(12, 36)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(40, 13)
        Me.LblEstado.TabIndex = 1
        Me.LblEstado.Text = "Estado"
        '
        'CmbEstado
        '
        Me.CmbEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbEstado.FormattingEnabled = True
        Me.CmbEstado.Location = New System.Drawing.Point(82, 33)
        Me.CmbEstado.Name = "CmbEstado"
        Me.CmbEstado.Size = New System.Drawing.Size(135, 21)
        Me.CmbEstado.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministraciónToolStripMenuItem, Me.FiltroToolStripMenuItem, Me.Usuario})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministraciónToolStripMenuItem
        '
        Me.AdministraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoRequerimientoToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.AdministraciónToolStripMenuItem.Name = "AdministraciónToolStripMenuItem"
        Me.AdministraciónToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.AdministraciónToolStripMenuItem.Text = "Administración"
        '
        'NuevoRequerimientoToolStripMenuItem
        '
        Me.NuevoRequerimientoToolStripMenuItem.Name = "NuevoRequerimientoToolStripMenuItem"
        Me.NuevoRequerimientoToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.NuevoRequerimientoToolStripMenuItem.Text = "Nuevo Requerimiento"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'FiltroToolStripMenuItem
        '
        Me.FiltroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstadoToolStripMenuItem})
        Me.FiltroToolStripMenuItem.Name = "FiltroToolStripMenuItem"
        Me.FiltroToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.FiltroToolStripMenuItem.Text = "Filtro"
        '
        'EstadoToolStripMenuItem
        '
        Me.EstadoToolStripMenuItem.Name = "EstadoToolStripMenuItem"
        Me.EstadoToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.EstadoToolStripMenuItem.Text = "Todos"
        '
        'Usuario
        '
        Me.Usuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Usuario.MergeIndex = 0
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(59, 20)
        Me.Usuario.Text = "Usuario"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(895, 33)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(101, 23)
        Me.BtnActualizar.TabIndex = 4
        Me.BtnActualizar.Text = "Actualizar (F9)"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'Principal_tecnico_req
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.CmbEstado)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.DgvHistorico)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal_tecnico_req"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal_tecnico_req"
        CType(Me.DgvHistorico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvHistorico As System.Windows.Forms.DataGridView
    Friend WithEvents LblEstado As System.Windows.Forms.Label
    Friend WithEvents CmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdministraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoRequerimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FiltroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents Usuario As ToolStripMenuItem
End Class
