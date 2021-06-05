<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editar_usuario_queja
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
        Me.TxbNumero = New System.Windows.Forms.TextBox()
        Me.LblNumero = New System.Windows.Forms.Label()
        Me.BtnAdjuntar = New System.Windows.Forms.Button()
        Me.TxbCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.GBDatosBasicos.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBDatosBasicos
        '
        Me.GBDatosBasicos.Controls.Add(Me.TxbNumero)
        Me.GBDatosBasicos.Controls.Add(Me.LblNumero)
        Me.GBDatosBasicos.Controls.Add(Me.BtnAdjuntar)
        Me.GBDatosBasicos.Controls.Add(Me.TxbCliente)
        Me.GBDatosBasicos.Controls.Add(Me.Label1)
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
        Me.GBDatosBasicos.Location = New System.Drawing.Point(7, 8)
        Me.GBDatosBasicos.Name = "GBDatosBasicos"
        Me.GBDatosBasicos.Size = New System.Drawing.Size(733, 327)
        Me.GBDatosBasicos.TabIndex = 1
        Me.GBDatosBasicos.TabStop = False
        Me.GBDatosBasicos.Text = "Datos Básicos"
        '
        'TxbNumero
        '
        Me.TxbNumero.Location = New System.Drawing.Point(66, 26)
        Me.TxbNumero.Name = "TxbNumero"
        Me.TxbNumero.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxbNumero.Size = New System.Drawing.Size(92, 20)
        Me.TxbNumero.TabIndex = 18
        '
        'LblNumero
        '
        Me.LblNumero.AutoSize = True
        Me.LblNumero.Location = New System.Drawing.Point(16, 28)
        Me.LblNumero.Name = "LblNumero"
        Me.LblNumero.Size = New System.Drawing.Size(44, 13)
        Me.LblNumero.TabIndex = 17
        Me.LblNumero.Text = "Número"
        '
        'BtnAdjuntar
        '
        Me.BtnAdjuntar.Location = New System.Drawing.Point(308, 285)
        Me.BtnAdjuntar.Name = "BtnAdjuntar"
        Me.BtnAdjuntar.Size = New System.Drawing.Size(99, 36)
        Me.BtnAdjuntar.TabIndex = 16
        Me.BtnAdjuntar.Text = "Adjuntar"
        Me.BtnAdjuntar.UseVisualStyleBackColor = True
        '
        'TxbCliente
        '
        Me.TxbCliente.Location = New System.Drawing.Point(131, 53)
        Me.TxbCliente.Multiline = True
        Me.TxbCliente.Name = "TxbCliente"
        Me.TxbCliente.Size = New System.Drawing.Size(587, 25)
        Me.TxbCliente.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Cliente o proveedor"
        '
        'TxbSugerencia
        '
        Me.TxbSugerencia.Location = New System.Drawing.Point(84, 198)
        Me.TxbSugerencia.Multiline = True
        Me.TxbSugerencia.Name = "TxbSugerencia"
        Me.TxbSugerencia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxbSugerencia.Size = New System.Drawing.Size(638, 72)
        Me.TxbSugerencia.TabIndex = 11
        '
        'LblSugerencia
        '
        Me.LblSugerencia.AutoSize = True
        Me.LblSugerencia.Location = New System.Drawing.Point(15, 227)
        Me.LblSugerencia.Name = "LblSugerencia"
        Me.LblSugerencia.Size = New System.Drawing.Size(61, 13)
        Me.LblSugerencia.TabIndex = 10
        Me.LblSugerencia.Text = "Sugerencia"
        '
        'TxbDescripcion
        '
        Me.TxbDescripcion.Location = New System.Drawing.Point(84, 117)
        Me.TxbDescripcion.Multiline = True
        Me.TxbDescripcion.Name = "TxbDescripcion"
        Me.TxbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxbDescripcion.Size = New System.Drawing.Size(638, 75)
        Me.TxbDescripcion.TabIndex = 9
        '
        'LblDescripción
        '
        Me.LblDescripción.AutoSize = True
        Me.LblDescripción.Location = New System.Drawing.Point(15, 149)
        Me.LblDescripción.Name = "LblDescripción"
        Me.LblDescripción.Size = New System.Drawing.Size(63, 13)
        Me.LblDescripción.TabIndex = 8
        Me.LblDescripción.Text = "Descripción"
        '
        'CmbTipoSoporte
        '
        Me.CmbTipoSoporte.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbTipoSoporte.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbTipoSoporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTipoSoporte.FormattingEnabled = True
        Me.CmbTipoSoporte.Location = New System.Drawing.Point(518, 23)
        Me.CmbTipoSoporte.Name = "CmbTipoSoporte"
        Me.CmbTipoSoporte.Size = New System.Drawing.Size(200, 23)
        Me.CmbTipoSoporte.TabIndex = 7
        '
        'LblTipoSoporte
        '
        Me.LblTipoSoporte.AutoSize = True
        Me.LblTipoSoporte.Location = New System.Drawing.Point(435, 28)
        Me.LblTipoSoporte.Name = "LblTipoSoporte"
        Me.LblTipoSoporte.Size = New System.Drawing.Size(68, 13)
        Me.LblTipoSoporte.TabIndex = 6
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
        Me.CmbProducto.Size = New System.Drawing.Size(373, 23)
        Me.CmbProducto.TabIndex = 5
        '
        'LblProducto
        '
        Me.LblProducto.AutoSize = True
        Me.LblProducto.Location = New System.Drawing.Point(15, 91)
        Me.LblProducto.Name = "LblProducto"
        Me.LblProducto.Size = New System.Drawing.Size(50, 13)
        Me.LblProducto.TabIndex = 4
        Me.LblProducto.Text = "Producto"
        '
        'CmbTipoQueja
        '
        Me.CmbTipoQueja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTipoQueja.FormattingEnabled = True
        Me.CmbTipoQueja.Location = New System.Drawing.Point(518, 85)
        Me.CmbTipoQueja.Name = "CmbTipoQueja"
        Me.CmbTipoQueja.Size = New System.Drawing.Size(200, 23)
        Me.CmbTipoQueja.TabIndex = 3
        '
        'LblTipoQueja
        '
        Me.LblTipoQueja.AutoSize = True
        Me.LblTipoQueja.Location = New System.Drawing.Point(475, 91)
        Me.LblTipoQueja.Name = "LblTipoQueja"
        Me.LblTipoQueja.Size = New System.Drawing.Size(28, 13)
        Me.LblTipoQueja.TabIndex = 2
        Me.LblTipoQueja.Text = "Tipo"
        '
        'DtmFecha
        '
        Me.DtmFecha.Location = New System.Drawing.Point(207, 23)
        Me.DtmFecha.Name = "DtmFecha"
        Me.DtmFecha.Size = New System.Drawing.Size(200, 20)
        Me.DtmFecha.TabIndex = 1
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Location = New System.Drawing.Point(164, 28)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(37, 13)
        Me.LblFecha.TabIndex = 0
        Me.LblFecha.Text = "Fecha"
        '
        'Editar_usuario_queja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 343)
        Me.Controls.Add(Me.GBDatosBasicos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Editar_usuario_queja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar_usuario_queja"
        Me.GBDatosBasicos.ResumeLayout(False)
        Me.GBDatosBasicos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GBDatosBasicos As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAdjuntar As System.Windows.Forms.Button
    Friend WithEvents TxbCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxbSugerencia As System.Windows.Forms.TextBox
    Friend WithEvents LblSugerencia As System.Windows.Forms.Label
    Friend WithEvents CmbTipoSoporte As System.Windows.Forms.ComboBox
    Friend WithEvents LblTipoSoporte As System.Windows.Forms.Label
    Friend WithEvents CmbProducto As System.Windows.Forms.ComboBox
    Friend WithEvents LblProducto As System.Windows.Forms.Label
    Friend WithEvents CmbTipoQueja As System.Windows.Forms.ComboBox
    Friend WithEvents LblTipoQueja As System.Windows.Forms.Label
    Friend WithEvents DtmFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Friend WithEvents TxbNumero As System.Windows.Forms.TextBox
    Friend WithEvents LblNumero As System.Windows.Forms.Label
    Friend WithEvents TxbDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents LblDescripción As System.Windows.Forms.Label
End Class
