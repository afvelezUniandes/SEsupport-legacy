<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal_usuario_queja
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
        Me.GBDatosBasicos = New System.Windows.Forms.GroupBox()
        Me.BtnAdjuntar = New System.Windows.Forms.Button()
        Me.TxbCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxbSugerencia = New System.Windows.Forms.TextBox()
        Me.LblSugerencia = New System.Windows.Forms.Label()
        Me.TxbDescripcion = New System.Windows.Forms.TextBox()
        Me.LblDescripción = New System.Windows.Forms.Label()
        Me.CmbTipoSoporte = New System.Windows.Forms.ComboBox()
        Me.LblTipoSoporte = New System.Windows.Forms.Label()
        Me.CmbProducto = New System.Windows.Forms.ComboBox()
        Me.LblProducto = New System.Windows.Forms.Label()
        Me.CmbTipoQueja = New System.Windows.Forms.ComboBox()
        Me.LblTipoQueja = New System.Windows.Forms.Label()
        Me.DtmFecha = New System.Windows.Forms.DateTimePicker()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverAlInicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeSoporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvHistorico = New System.Windows.Forms.DataGridView()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.DtmFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.LblFechaFinal = New System.Windows.Forms.Label()
        Me.DtmFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.LblFechaInicial = New System.Windows.Forms.Label()
        Me.GBDatosBasicos.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvHistorico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBDatosBasicos
        '
        Me.GBDatosBasicos.Controls.Add(Me.BtnAdjuntar)
        Me.GBDatosBasicos.Controls.Add(Me.TxbCliente)
        Me.GBDatosBasicos.Controls.Add(Me.Label1)
        Me.GBDatosBasicos.Controls.Add(Me.BtnLimpiar)
        Me.GBDatosBasicos.Controls.Add(Me.BtnGuardar)
        Me.GBDatosBasicos.Controls.Add(Me.TxbSugerencia)
        Me.GBDatosBasicos.Controls.Add(Me.LblSugerencia)
        Me.GBDatosBasicos.Controls.Add(Me.TxbDescripcion)
        Me.GBDatosBasicos.Controls.Add(Me.LblDescripción)
        Me.GBDatosBasicos.Controls.Add(Me.CmbTipoSoporte)
        Me.GBDatosBasicos.Controls.Add(Me.LblTipoSoporte)
        Me.GBDatosBasicos.Controls.Add(Me.CmbProducto)
        Me.GBDatosBasicos.Controls.Add(Me.LblProducto)
        Me.GBDatosBasicos.Controls.Add(Me.CmbTipoQueja)
        Me.GBDatosBasicos.Controls.Add(Me.LblTipoQueja)
        Me.GBDatosBasicos.Controls.Add(Me.DtmFecha)
        Me.GBDatosBasicos.Controls.Add(Me.LblFecha)
        Me.GBDatosBasicos.Location = New System.Drawing.Point(12, 29)
        Me.GBDatosBasicos.Name = "GBDatosBasicos"
        Me.GBDatosBasicos.Size = New System.Drawing.Size(760, 327)
        Me.GBDatosBasicos.TabIndex = 0
        Me.GBDatosBasicos.TabStop = False
        Me.GBDatosBasicos.Text = "Datos Básicos"
        '
        'BtnAdjuntar
        '
        Me.BtnAdjuntar.Location = New System.Drawing.Point(318, 279)
        Me.BtnAdjuntar.Name = "BtnAdjuntar"
        Me.BtnAdjuntar.Size = New System.Drawing.Size(99, 36)
        Me.BtnAdjuntar.TabIndex = 17
        Me.BtnAdjuntar.Text = "Adjuntar"
        Me.BtnAdjuntar.UseVisualStyleBackColor = True
        '
        'TxbCliente
        '
        Me.TxbCliente.Location = New System.Drawing.Point(131, 53)
        Me.TxbCliente.Multiline = True
        Me.TxbCliente.Name = "TxbCliente"
        Me.TxbCliente.Size = New System.Drawing.Size(587, 25)
        Me.TxbCliente.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cliente o proveedor"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(576, 280)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(104, 36)
        Me.BtnLimpiar.TabIndex = 18
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(84, 279)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(99, 36)
        Me.BtnGuardar.TabIndex = 16
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'TxbSugerencia
        '
        Me.TxbSugerencia.Location = New System.Drawing.Point(84, 198)
        Me.TxbSugerencia.Multiline = True
        Me.TxbSugerencia.Name = "TxbSugerencia"
        Me.TxbSugerencia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxbSugerencia.Size = New System.Drawing.Size(638, 72)
        Me.TxbSugerencia.TabIndex = 15
        '
        'LblSugerencia
        '
        Me.LblSugerencia.AutoSize = True
        Me.LblSugerencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSugerencia.Location = New System.Drawing.Point(10, 227)
        Me.LblSugerencia.Name = "LblSugerencia"
        Me.LblSugerencia.Size = New System.Drawing.Size(71, 13)
        Me.LblSugerencia.TabIndex = 14
        Me.LblSugerencia.Text = "Sugerencia"
        '
        'TxbDescripcion
        '
        Me.TxbDescripcion.Location = New System.Drawing.Point(84, 117)
        Me.TxbDescripcion.Multiline = True
        Me.TxbDescripcion.Name = "TxbDescripcion"
        Me.TxbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxbDescripcion.Size = New System.Drawing.Size(638, 75)
        Me.TxbDescripcion.TabIndex = 13
        '
        'LblDescripción
        '
        Me.LblDescripción.AutoSize = True
        Me.LblDescripción.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripción.Location = New System.Drawing.Point(7, 150)
        Me.LblDescripción.Name = "LblDescripción"
        Me.LblDescripción.Size = New System.Drawing.Size(74, 13)
        Me.LblDescripción.TabIndex = 12
        Me.LblDescripción.Text = "Descripción"
        '
        'CmbTipoSoporte
        '
        Me.CmbTipoSoporte.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbTipoSoporte.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbTipoSoporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTipoSoporte.FormattingEnabled = True
        Me.CmbTipoSoporte.Location = New System.Drawing.Point(457, 24)
        Me.CmbTipoSoporte.Name = "CmbTipoSoporte"
        Me.CmbTipoSoporte.Size = New System.Drawing.Size(261, 23)
        Me.CmbTipoSoporte.TabIndex = 4
        '
        'LblTipoSoporte
        '
        Me.LblTipoSoporte.AutoSize = True
        Me.LblTipoSoporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipoSoporte.Location = New System.Drawing.Point(371, 29)
        Me.LblTipoSoporte.Name = "LblTipoSoporte"
        Me.LblTipoSoporte.Size = New System.Drawing.Size(80, 13)
        Me.LblTipoSoporte.TabIndex = 3
        Me.LblTipoSoporte.Text = "Tipo Soporte"
        '
        'CmbProducto
        '
        Me.CmbProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbProducto.FormattingEnabled = True
        Me.CmbProducto.Location = New System.Drawing.Point(84, 85)
        Me.CmbProducto.Name = "CmbProducto"
        Me.CmbProducto.Size = New System.Drawing.Size(477, 23)
        Me.CmbProducto.TabIndex = 8
        '
        'LblProducto
        '
        Me.LblProducto.AutoSize = True
        Me.LblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProducto.Location = New System.Drawing.Point(10, 90)
        Me.LblProducto.Name = "LblProducto"
        Me.LblProducto.Size = New System.Drawing.Size(58, 13)
        Me.LblProducto.TabIndex = 7
        Me.LblProducto.Text = "Producto"
        '
        'CmbTipoQueja
        '
        Me.CmbTipoQueja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTipoQueja.FormattingEnabled = True
        Me.CmbTipoQueja.Location = New System.Drawing.Point(605, 85)
        Me.CmbTipoQueja.Name = "CmbTipoQueja"
        Me.CmbTipoQueja.Size = New System.Drawing.Size(113, 23)
        Me.CmbTipoQueja.TabIndex = 11
        '
        'LblTipoQueja
        '
        Me.LblTipoQueja.AutoSize = True
        Me.LblTipoQueja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipoQueja.Location = New System.Drawing.Point(567, 90)
        Me.LblTipoQueja.Name = "LblTipoQueja"
        Me.LblTipoQueja.Size = New System.Drawing.Size(32, 13)
        Me.LblTipoQueja.TabIndex = 10
        Me.LblTipoQueja.Text = "Tipo"
        '
        'DtmFecha
        '
        Me.DtmFecha.Location = New System.Drawing.Point(84, 23)
        Me.DtmFecha.Name = "DtmFecha"
        Me.DtmFecha.Size = New System.Drawing.Size(200, 20)
        Me.DtmFecha.TabIndex = 2
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.Location = New System.Drawing.Point(10, 29)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(42, 13)
        Me.LblFecha.TabIndex = 1
        Me.LblFecha.Text = "Fecha"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverAlInicioToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ArchivoToolStripMenuItem.Text = "ARCHIVO"
        '
        'VolverAlInicioToolStripMenuItem
        '
        Me.VolverAlInicioToolStripMenuItem.Name = "VolverAlInicioToolStripMenuItem"
        Me.VolverAlInicioToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.VolverAlInicioToolStripMenuItem.Text = "Volver al Inicio"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipoDeSoporteToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "AYUDA"
        '
        'TipoDeSoporteToolStripMenuItem
        '
        Me.TipoDeSoporteToolStripMenuItem.Name = "TipoDeSoporteToolStripMenuItem"
        Me.TipoDeSoporteToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.TipoDeSoporteToolStripMenuItem.Text = "Tipo de soporte"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvHistorico)
        Me.GroupBox1.Controls.Add(Me.BtnConsultar)
        Me.GroupBox1.Controls.Add(Me.DtmFechaFinal)
        Me.GroupBox1.Controls.Add(Me.LblFechaFinal)
        Me.GroupBox1.Controls.Add(Me.DtmFechaInicial)
        Me.GroupBox1.Controls.Add(Me.LblFechaInicial)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 362)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(760, 250)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Histórico Quejas"
        '
        'DgvHistorico
        '
        Me.DgvHistorico.AllowUserToAddRows = False
        Me.DgvHistorico.AllowUserToDeleteRows = False
        Me.DgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvHistorico.Location = New System.Drawing.Point(10, 52)
        Me.DgvHistorico.Name = "DgvHistorico"
        Me.DgvHistorico.ReadOnly = True
        Me.DgvHistorico.Size = New System.Drawing.Size(744, 192)
        Me.DgvHistorico.TabIndex = 25
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Location = New System.Drawing.Point(605, 21)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(95, 23)
        Me.BtnConsultar.TabIndex = 24
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'DtmFechaFinal
        '
        Me.DtmFechaFinal.Location = New System.Drawing.Point(379, 20)
        Me.DtmFechaFinal.Name = "DtmFechaFinal"
        Me.DtmFechaFinal.Size = New System.Drawing.Size(200, 20)
        Me.DtmFechaFinal.TabIndex = 23
        '
        'LblFechaFinal
        '
        Me.LblFechaFinal.AutoSize = True
        Me.LblFechaFinal.Location = New System.Drawing.Point(306, 26)
        Me.LblFechaFinal.Name = "LblFechaFinal"
        Me.LblFechaFinal.Size = New System.Drawing.Size(62, 13)
        Me.LblFechaFinal.TabIndex = 22
        Me.LblFechaFinal.Text = "Fecha Final"
        '
        'DtmFechaInicial
        '
        Me.DtmFechaInicial.Location = New System.Drawing.Point(80, 20)
        Me.DtmFechaInicial.Name = "DtmFechaInicial"
        Me.DtmFechaInicial.Size = New System.Drawing.Size(200, 20)
        Me.DtmFechaInicial.TabIndex = 21
        '
        'LblFechaInicial
        '
        Me.LblFechaInicial.AutoSize = True
        Me.LblFechaInicial.Location = New System.Drawing.Point(7, 26)
        Me.LblFechaInicial.Name = "LblFechaInicial"
        Me.LblFechaInicial.Size = New System.Drawing.Size(67, 13)
        Me.LblFechaInicial.TabIndex = 20
        Me.LblFechaInicial.Text = "Fecha Inicial"
        '
        'Principal_usuario_queja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(784, 624)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBDatosBasicos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal_usuario_queja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal Quejas y No Conformidades"
        Me.GBDatosBasicos.ResumeLayout(False)
        Me.GBDatosBasicos.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvHistorico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBDatosBasicos As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolverAlInicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DtmFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Friend WithEvents LblTipoQueja As System.Windows.Forms.Label
    Friend WithEvents CmbTipoQueja As System.Windows.Forms.ComboBox
    Friend WithEvents CmbProducto As System.Windows.Forms.ComboBox
    Friend WithEvents LblProducto As System.Windows.Forms.Label
    Friend WithEvents CmbTipoSoporte As System.Windows.Forms.ComboBox
    Friend WithEvents LblTipoSoporte As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents TxbSugerencia As System.Windows.Forms.TextBox
    Friend WithEvents LblSugerencia As System.Windows.Forms.Label
    Friend WithEvents TxbDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents LblDescripción As System.Windows.Forms.Label
    Friend WithEvents TxbCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnAdjuntar As System.Windows.Forms.Button
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoDeSoporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DgvHistorico As System.Windows.Forms.DataGridView
    Friend WithEvents BtnConsultar As System.Windows.Forms.Button
    Friend WithEvents DtmFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFechaFinal As System.Windows.Forms.Label
    Friend WithEvents DtmFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFechaInicial As System.Windows.Forms.Label
End Class
