<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agotados
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
        Me.DgvAgotados = New System.Windows.Forms.DataGridView()
        Me.Borrar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DtpFechaAgotados = New System.Windows.Forms.DateTimePicker()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.CmbBodega = New System.Windows.Forms.ComboBox()
        Me.Lblbodega = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverAlInicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DgvAgotados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvAgotados
        '
        Me.DgvAgotados.AllowUserToDeleteRows = False
        Me.DgvAgotados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvAgotados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAgotados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Borrar})
        Me.DgvAgotados.Location = New System.Drawing.Point(12, 112)
        Me.DgvAgotados.Name = "DgvAgotados"
        Me.DgvAgotados.Size = New System.Drawing.Size(690, 379)
        Me.DgvAgotados.TabIndex = 0
        '
        'Borrar
        '
        Me.Borrar.Frozen = True
        Me.Borrar.HeaderText = "Borrar"
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Width = 41
        '
        'DtpFechaAgotados
        '
        Me.DtpFechaAgotados.Location = New System.Drawing.Point(88, 34)
        Me.DtpFechaAgotados.Name = "DtpFechaAgotados"
        Me.DtpFechaAgotados.Size = New System.Drawing.Size(200, 20)
        Me.DtpFechaAgotados.TabIndex = 1
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.Location = New System.Drawing.Point(13, 35)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(58, 17)
        Me.LblFecha.TabIndex = 2
        Me.LblFecha.Text = "FECHA"
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.Location = New System.Drawing.Point(328, 42)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(101, 44)
        Me.BtnConsultar.TabIndex = 3
        Me.BtnConsultar.Text = "CONSULTAR"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'CmbBodega
        '
        Me.CmbBodega.FormattingEnabled = True
        Me.CmbBodega.Items.AddRange(New Object() {"Inventario Diario", "Inventario Fin de Mes"})
        Me.CmbBodega.Location = New System.Drawing.Point(88, 75)
        Me.CmbBodega.Name = "CmbBodega"
        Me.CmbBodega.Size = New System.Drawing.Size(200, 21)
        Me.CmbBodega.TabIndex = 4
        '
        'Lblbodega
        '
        Me.Lblbodega.AutoSize = True
        Me.Lblbodega.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblbodega.Location = New System.Drawing.Point(13, 76)
        Me.Lblbodega.Name = "Lblbodega"
        Me.Lblbodega.Size = New System.Drawing.Size(73, 17)
        Me.Lblbodega.TabIndex = 5
        Me.Lblbodega.Text = "BODEGA"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(12, 502)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(187, 44)
        Me.BtnGuardar.TabIndex = 6
        Me.BtnGuardar.Text = "GUARDAR CAMBIOS"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(515, 502)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(187, 44)
        Me.BtnCancelar.TabIndex = 7
        Me.BtnCancelar.Text = "CANCELAR CAMBIOS"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministraciónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(714, 27)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministraciónToolStripMenuItem
        '
        Me.AdministraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverAlInicioToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.AdministraciónToolStripMenuItem.Name = "AdministraciónToolStripMenuItem"
        Me.AdministraciónToolStripMenuItem.Size = New System.Drawing.Size(67, 23)
        Me.AdministraciónToolStripMenuItem.Text = "Archivo"
        '
        'VolverAlInicioToolStripMenuItem
        '
        Me.VolverAlInicioToolStripMenuItem.Name = "VolverAlInicioToolStripMenuItem"
        Me.VolverAlInicioToolStripMenuItem.Size = New System.Drawing.Size(166, 24)
        Me.VolverAlInicioToolStripMenuItem.Text = "Volver al Inicio"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(166, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Agotados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 556)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Lblbodega)
        Me.Controls.Add(Me.CmbBodega)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.DtpFechaAgotados)
        Me.Controls.Add(Me.DgvAgotados)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Agotados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agotados"
        CType(Me.DgvAgotados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvAgotados As System.Windows.Forms.DataGridView
    Friend WithEvents DtpFechaAgotados As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Friend WithEvents BtnConsultar As System.Windows.Forms.Button
    Friend WithEvents CmbBodega As System.Windows.Forms.ComboBox
    Friend WithEvents Lblbodega As System.Windows.Forms.Label
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents Borrar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdministraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolverAlInicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
