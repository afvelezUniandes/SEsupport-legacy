<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajuste_inventarios_diario
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
        Me.components = New System.ComponentModel.Container()
        Me.GboxConsInv = New System.Windows.Forms.GroupBox()
        Me.BtnActualizarSaldo = New System.Windows.Forms.Button()
        Me.BtnAjustes = New System.Windows.Forms.Button()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.LblBodega = New System.Windows.Forms.Label()
        Me.CmbBodega = New System.Windows.Forms.ComboBox()
        Me.DgvInventarios = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeleccionarTodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitarSelecciónTodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GboxBuscarRef = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxbBuscar = New System.Windows.Forms.TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.TxbTotalAjuste = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GboxConsInv.SuspendLayout()
        CType(Me.DgvInventarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GboxBuscarRef.SuspendLayout()
        Me.SuspendLayout()
        '
        'GboxConsInv
        '
        Me.GboxConsInv.Controls.Add(Me.BtnActualizarSaldo)
        Me.GboxConsInv.Controls.Add(Me.BtnAjustes)
        Me.GboxConsInv.Controls.Add(Me.BtnConsultar)
        Me.GboxConsInv.Controls.Add(Me.LblFecha)
        Me.GboxConsInv.Controls.Add(Me.DtpFecha)
        Me.GboxConsInv.Controls.Add(Me.LblBodega)
        Me.GboxConsInv.Controls.Add(Me.CmbBodega)
        Me.GboxConsInv.Location = New System.Drawing.Point(12, 19)
        Me.GboxConsInv.Name = "GboxConsInv"
        Me.GboxConsInv.Size = New System.Drawing.Size(632, 92)
        Me.GboxConsInv.TabIndex = 12
        Me.GboxConsInv.TabStop = False
        Me.GboxConsInv.Text = "Consultar Inventario"
        '
        'BtnActualizarSaldo
        '
        Me.BtnActualizarSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizarSaldo.Location = New System.Drawing.Point(242, 53)
        Me.BtnActualizarSaldo.Name = "BtnActualizarSaldo"
        Me.BtnActualizarSaldo.Size = New System.Drawing.Size(142, 33)
        Me.BtnActualizarSaldo.TabIndex = 9
        Me.BtnActualizarSaldo.Text = "Actualizar Saldo"
        Me.BtnActualizarSaldo.UseVisualStyleBackColor = True
        '
        'BtnAjustes
        '
        Me.BtnAjustes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAjustes.Location = New System.Drawing.Point(453, 53)
        Me.BtnAjustes.Name = "BtnAjustes"
        Me.BtnAjustes.Size = New System.Drawing.Size(142, 33)
        Me.BtnAjustes.TabIndex = 8
        Me.BtnAjustes.Text = "Generar Ajustes"
        Me.BtnAjustes.UseVisualStyleBackColor = True
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.Location = New System.Drawing.Point(49, 53)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(116, 33)
        Me.BtnConsultar.TabIndex = 7
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Location = New System.Drawing.Point(6, 32)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(37, 13)
        Me.LblFecha.TabIndex = 1
        Me.LblFecha.Text = "Fecha"
        '
        'DtpFecha
        '
        Me.DtpFecha.Location = New System.Drawing.Point(59, 26)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.DtpFecha.TabIndex = 0
        '
        'LblBodega
        '
        Me.LblBodega.AutoSize = True
        Me.LblBodega.Location = New System.Drawing.Point(282, 29)
        Me.LblBodega.Name = "LblBodega"
        Me.LblBodega.Size = New System.Drawing.Size(44, 13)
        Me.LblBodega.TabIndex = 6
        Me.LblBodega.Text = "Bodega"
        '
        'CmbBodega
        '
        Me.CmbBodega.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbBodega.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbBodega.FormattingEnabled = True
        Me.CmbBodega.Items.AddRange(New Object() {"Inventario Diario", "Inventario Fin de Mes"})
        Me.CmbBodega.Location = New System.Drawing.Point(332, 24)
        Me.CmbBodega.Name = "CmbBodega"
        Me.CmbBodega.Size = New System.Drawing.Size(294, 21)
        Me.CmbBodega.TabIndex = 5
        '
        'DgvInventarios
        '
        Me.DgvInventarios.AllowUserToAddRows = False
        Me.DgvInventarios.AllowUserToDeleteRows = False
        Me.DgvInventarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvInventarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvInventarios.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DgvInventarios.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DgvInventarios.Location = New System.Drawing.Point(0, 157)
        Me.DgvInventarios.Name = "DgvInventarios"
        Me.DgvInventarios.Size = New System.Drawing.Size(791, 436)
        Me.DgvInventarios.TabIndex = 11
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripSeparator1, Me.ExportarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(119, 54)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeleccionarTodosToolStripMenuItem, Me.QuitarSelecciónTodosToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(118, 22)
        Me.ToolStripMenuItem1.Text = "Selección"
        '
        'SeleccionarTodosToolStripMenuItem
        '
        Me.SeleccionarTodosToolStripMenuItem.Name = "SeleccionarTodosToolStripMenuItem"
        Me.SeleccionarTodosToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.SeleccionarTodosToolStripMenuItem.Text = "Seleccionar Todos"
        '
        'QuitarSelecciónTodosToolStripMenuItem
        '
        Me.QuitarSelecciónTodosToolStripMenuItem.Name = "QuitarSelecciónTodosToolStripMenuItem"
        Me.QuitarSelecciónTodosToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.QuitarSelecciónTodosToolStripMenuItem.Text = "Quitar Selección Todos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(115, 6)
        '
        'ExportarToolStripMenuItem
        '
        Me.ExportarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcelToolStripMenuItem})
        Me.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem"
        Me.ExportarToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ExportarToolStripMenuItem.Text = "Exportar"
        '
        'ExcelToolStripMenuItem
        '
        Me.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem"
        Me.ExcelToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.ExcelToolStripMenuItem.Text = "Excel"
        '
        'GboxBuscarRef
        '
        Me.GboxBuscarRef.Controls.Add(Me.BtnBuscar)
        Me.GboxBuscarRef.Controls.Add(Me.TxbBuscar)
        Me.GboxBuscarRef.Location = New System.Drawing.Point(645, 19)
        Me.GboxBuscarRef.Name = "GboxBuscarRef"
        Me.GboxBuscarRef.Size = New System.Drawing.Size(135, 92)
        Me.GboxBuscarRef.TabIndex = 13
        Me.GboxBuscarRef.TabStop = False
        Me.GboxBuscarRef.Text = "Buscar X Referencia"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(38, 52)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(66, 31)
        Me.BtnBuscar.TabIndex = 9
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxbBuscar
        '
        Me.TxbBuscar.Location = New System.Drawing.Point(10, 26)
        Me.TxbBuscar.Name = "TxbBuscar"
        Me.TxbBuscar.Size = New System.Drawing.Size(116, 20)
        Me.TxbBuscar.TabIndex = 1
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(27, 126)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(118, 13)
        Me.LblTotal.TabIndex = 14
        Me.LblTotal.Text = "Total Ajuste Inventarios"
        '
        'TxbTotalAjuste
        '
        Me.TxbTotalAjuste.Location = New System.Drawing.Point(151, 123)
        Me.TxbTotalAjuste.Name = "TxbTotalAjuste"
        Me.TxbTotalAjuste.Size = New System.Drawing.Size(100, 20)
        Me.TxbTotalAjuste.TabIndex = 15
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(268, 123)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(512, 23)
        Me.ProgressBar1.TabIndex = 16
        '
        'Ajuste_inventarios_diario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 593)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TxbTotalAjuste)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.GboxConsInv)
        Me.Controls.Add(Me.DgvInventarios)
        Me.Controls.Add(Me.GboxBuscarRef)
        Me.Name = "Ajuste_inventarios_diario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajuste_inventarios"
        Me.GboxConsInv.ResumeLayout(False)
        Me.GboxConsInv.PerformLayout()
        CType(Me.DgvInventarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GboxBuscarRef.ResumeLayout(False)
        Me.GboxBuscarRef.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GboxConsInv As System.Windows.Forms.GroupBox
    Friend WithEvents BtnConsultar As System.Windows.Forms.Button
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblBodega As System.Windows.Forms.Label
    Friend WithEvents CmbBodega As System.Windows.Forms.ComboBox
    Friend WithEvents DgvInventarios As System.Windows.Forms.DataGridView
    Friend WithEvents GboxBuscarRef As System.Windows.Forms.GroupBox
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents TxbBuscar As System.Windows.Forms.TextBox
    Friend WithEvents BtnAjustes As System.Windows.Forms.Button
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents TxbTotalAjuste As System.Windows.Forms.TextBox
    Friend WithEvents BtnActualizarSaldo As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeleccionarTodosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitarSelecciónTodosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExportarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
