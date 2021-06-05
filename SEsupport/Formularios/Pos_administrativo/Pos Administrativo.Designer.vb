<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pos_Administrativo
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pos_Administrativo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkAnulado = New System.Windows.Forms.CheckBox()
        Me.GbObservaciones = New System.Windows.Forms.GroupBox()
        Me.TxbObservaciones = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GbxMoneda = New System.Windows.Forms.GroupBox()
        Me.CmbMoneda = New System.Windows.Forms.ComboBox()
        Me.GbxNavegacion = New System.Windows.Forms.GroupBox()
        Me.BtnSiguiente = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnAtras = New System.Windows.Forms.Button()
        Me.GbxCambio = New System.Windows.Forms.GroupBox()
        Me.LblSimboloCambioext = New System.Windows.Forms.Label()
        Me.LblCambioMonedaExt = New System.Windows.Forms.Label()
        Me.LblCambioMonedaCol = New System.Windows.Forms.Label()
        Me.GbTotal = New System.Windows.Forms.GroupBox()
        Me.LblSimbolototalExt = New System.Windows.Forms.Label()
        Me.LblTotalVentaExt = New System.Windows.Forms.Label()
        Me.LblTotalVentaCol = New System.Windows.Forms.Label()
        Me.GbxRelPagosVenta = New System.Windows.Forms.GroupBox()
        Me.Txbtotal_subtotal = New System.Windows.Forms.TextBox()
        Me.LblTotal_subtotal = New System.Windows.Forms.Label()
        Me.TxbTotalIva = New System.Windows.Forms.TextBox()
        Me.LblTotalIva = New System.Windows.Forms.Label()
        Me.TxbValorFormaPago = New System.Windows.Forms.TextBox()
        Me.BtnGuardarPago = New System.Windows.Forms.Button()
        Me.LblValorFormaPago = New System.Windows.Forms.Label()
        Me.DgvFormaPago = New System.Windows.Forms.DataGridView()
        Me.borrar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cod_forma_pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Formapago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmbFormaPago = New System.Windows.Forms.ComboBox()
        Me.LblFormaPago = New System.Windows.Forms.Label()
        Me.GbRegistro = New System.Windows.Forms.GroupBox()
        Me.DgvReferencias = New System.Windows.Forms.DataGridView()
        Me.Referencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor_unitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totaliva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totaldescuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GbxNumero = New System.Windows.Forms.GroupBox()
        Me.TBFecha = New System.Windows.Forms.TextBox()
        Me.Txbnumero = New System.Windows.Forms.TextBox()
        Me.BtnNumero = New System.Windows.Forms.Button()
        Me.GbxCliente = New System.Windows.Forms.GroupBox()
        Me.CmbCliente = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarMonedaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformeFiscalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Usuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.Acciones = New System.Windows.Forms.GroupBox()
        Me.BtnGuardarCambio = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GbObservaciones.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GbxMoneda.SuspendLayout()
        Me.GbxNavegacion.SuspendLayout()
        Me.GbxCambio.SuspendLayout()
        Me.GbTotal.SuspendLayout()
        Me.GbxRelPagosVenta.SuspendLayout()
        CType(Me.DgvFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbRegistro.SuspendLayout()
        CType(Me.DgvReferencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbxNumero.SuspendLayout()
        Me.GbxCliente.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Acciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChkAnulado)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(913, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(103, 49)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Anulado"
        Me.GroupBox1.Visible = False
        '
        'ChkAnulado
        '
        Me.ChkAnulado.AutoSize = True
        Me.ChkAnulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ChkAnulado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ChkAnulado.Location = New System.Drawing.Point(4, 16)
        Me.ChkAnulado.Name = "ChkAnulado"
        Me.ChkAnulado.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkAnulado.Size = New System.Drawing.Size(87, 24)
        Me.ChkAnulado.TabIndex = 14
        Me.ChkAnulado.Text = "Anulado"
        Me.ChkAnulado.UseVisualStyleBackColor = True
        '
        'GbObservaciones
        '
        Me.GbObservaciones.Controls.Add(Me.TxbObservaciones)
        Me.GbObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GbObservaciones.Location = New System.Drawing.Point(18, 344)
        Me.GbObservaciones.Name = "GbObservaciones"
        Me.GbObservaciones.Size = New System.Drawing.Size(441, 84)
        Me.GbObservaciones.TabIndex = 22
        Me.GbObservaciones.TabStop = False
        Me.GbObservaciones.Text = "OBSERVACIONES"
        '
        'TxbObservaciones
        '
        Me.TxbObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TxbObservaciones.Location = New System.Drawing.Point(6, 17)
        Me.TxbObservaciones.MaxLength = 90
        Me.TxbObservaciones.Multiline = True
        Me.TxbObservaciones.Name = "TxbObservaciones"
        Me.TxbObservaciones.Size = New System.Drawing.Size(428, 58)
        Me.TxbObservaciones.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 670)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1016, 22)
        Me.StatusStrip1.TabIndex = 25
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(133, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(20, 17)
        Me.ToolStripStatusLabel2.Text = "||"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(133, 17)
        Me.ToolStripStatusLabel3.Text = "ToolStripStatusLabel3"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(20, 17)
        Me.ToolStripStatusLabel4.Text = "||"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(133, 17)
        Me.ToolStripStatusLabel5.Text = "ToolStripStatusLabel5"
        '
        'GbxMoneda
        '
        Me.GbxMoneda.Controls.Add(Me.CmbMoneda)
        Me.GbxMoneda.Location = New System.Drawing.Point(730, 29)
        Me.GbxMoneda.Name = "GbxMoneda"
        Me.GbxMoneda.Size = New System.Drawing.Size(181, 49)
        Me.GbxMoneda.TabIndex = 19
        Me.GbxMoneda.TabStop = False
        Me.GbxMoneda.Text = "MONEDA"
        '
        'CmbMoneda
        '
        Me.CmbMoneda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbMoneda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CmbMoneda.FormattingEnabled = True
        Me.CmbMoneda.Location = New System.Drawing.Point(6, 16)
        Me.CmbMoneda.Name = "CmbMoneda"
        Me.CmbMoneda.Size = New System.Drawing.Size(169, 24)
        Me.CmbMoneda.TabIndex = 10
        '
        'GbxNavegacion
        '
        Me.GbxNavegacion.BackColor = System.Drawing.SystemColors.Control
        Me.GbxNavegacion.Controls.Add(Me.BtnSiguiente)
        Me.GbxNavegacion.Controls.Add(Me.BtnLimpiar)
        Me.GbxNavegacion.Controls.Add(Me.BtnAtras)
        Me.GbxNavegacion.Location = New System.Drawing.Point(18, 587)
        Me.GbxNavegacion.Name = "GbxNavegacion"
        Me.GbxNavegacion.Size = New System.Drawing.Size(441, 82)
        Me.GbxNavegacion.TabIndex = 24
        Me.GbxNavegacion.TabStop = False
        Me.GbxNavegacion.Text = "Navegación"
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSiguiente.Location = New System.Drawing.Point(300, 18)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(121, 55)
        Me.BtnSiguiente.TabIndex = 2
        Me.BtnSiguiente.Text = "SIGUIENTE"
        Me.BtnSiguiente.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Location = New System.Drawing.Point(160, 18)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(121, 55)
        Me.BtnLimpiar.TabIndex = 1
        Me.BtnLimpiar.Text = "LIMPIAR"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnAtras
        '
        Me.BtnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAtras.Location = New System.Drawing.Point(21, 18)
        Me.BtnAtras.Name = "BtnAtras"
        Me.BtnAtras.Size = New System.Drawing.Size(121, 55)
        Me.BtnAtras.TabIndex = 0
        Me.BtnAtras.Text = "ATRAS"
        Me.BtnAtras.UseVisualStyleBackColor = True
        '
        'GbxCambio
        '
        Me.GbxCambio.Controls.Add(Me.LblSimboloCambioext)
        Me.GbxCambio.Controls.Add(Me.LblCambioMonedaExt)
        Me.GbxCambio.Controls.Add(Me.LblCambioMonedaCol)
        Me.GbxCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GbxCambio.Location = New System.Drawing.Point(18, 500)
        Me.GbxCambio.Name = "GbxCambio"
        Me.GbxCambio.Size = New System.Drawing.Size(441, 81)
        Me.GbxCambio.TabIndex = 23
        Me.GbxCambio.TabStop = False
        Me.GbxCambio.Text = "CAMBIO"
        '
        'LblSimboloCambioext
        '
        Me.LblSimboloCambioext.AutoSize = True
        Me.LblSimboloCambioext.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold)
        Me.LblSimboloCambioext.ForeColor = System.Drawing.Color.Red
        Me.LblSimboloCambioext.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblSimboloCambioext.Location = New System.Drawing.Point(209, 23)
        Me.LblSimboloCambioext.Name = "LblSimboloCambioext"
        Me.LblSimboloCambioext.Size = New System.Drawing.Size(42, 44)
        Me.LblSimboloCambioext.TabIndex = 2
        Me.LblSimboloCambioext.Text = "0"
        '
        'LblCambioMonedaExt
        '
        Me.LblCambioMonedaExt.AutoSize = True
        Me.LblCambioMonedaExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold)
        Me.LblCambioMonedaExt.ForeColor = System.Drawing.Color.Red
        Me.LblCambioMonedaExt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblCambioMonedaExt.Location = New System.Drawing.Point(292, 23)
        Me.LblCambioMonedaExt.Name = "LblCambioMonedaExt"
        Me.LblCambioMonedaExt.Size = New System.Drawing.Size(42, 44)
        Me.LblCambioMonedaExt.TabIndex = 1
        Me.LblCambioMonedaExt.Text = "0"
        '
        'LblCambioMonedaCol
        '
        Me.LblCambioMonedaCol.AutoSize = True
        Me.LblCambioMonedaCol.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold)
        Me.LblCambioMonedaCol.ForeColor = System.Drawing.Color.Red
        Me.LblCambioMonedaCol.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblCambioMonedaCol.Location = New System.Drawing.Point(13, 23)
        Me.LblCambioMonedaCol.Name = "LblCambioMonedaCol"
        Me.LblCambioMonedaCol.Size = New System.Drawing.Size(42, 44)
        Me.LblCambioMonedaCol.TabIndex = 0
        Me.LblCambioMonedaCol.Text = "0"
        '
        'GbTotal
        '
        Me.GbTotal.Controls.Add(Me.LblSimbolototalExt)
        Me.GbTotal.Controls.Add(Me.LblTotalVentaExt)
        Me.GbTotal.Controls.Add(Me.LblTotalVentaCol)
        Me.GbTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GbTotal.Location = New System.Drawing.Point(18, 428)
        Me.GbTotal.Name = "GbTotal"
        Me.GbTotal.Size = New System.Drawing.Size(441, 71)
        Me.GbTotal.TabIndex = 21
        Me.GbTotal.TabStop = False
        Me.GbTotal.Text = "TOTAL VENTA"
        '
        'LblSimbolototalExt
        '
        Me.LblSimbolototalExt.AutoSize = True
        Me.LblSimbolototalExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold)
        Me.LblSimbolototalExt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblSimbolototalExt.Location = New System.Drawing.Point(213, 20)
        Me.LblSimbolototalExt.Name = "LblSimbolototalExt"
        Me.LblSimbolototalExt.Size = New System.Drawing.Size(37, 39)
        Me.LblSimbolototalExt.TabIndex = 2
        Me.LblSimbolototalExt.Text = "0"
        '
        'LblTotalVentaExt
        '
        Me.LblTotalVentaExt.AutoSize = True
        Me.LblTotalVentaExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold)
        Me.LblTotalVentaExt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTotalVentaExt.Location = New System.Drawing.Point(293, 20)
        Me.LblTotalVentaExt.Name = "LblTotalVentaExt"
        Me.LblTotalVentaExt.Size = New System.Drawing.Size(37, 39)
        Me.LblTotalVentaExt.TabIndex = 1
        Me.LblTotalVentaExt.Text = "0"
        '
        'LblTotalVentaCol
        '
        Me.LblTotalVentaCol.AutoSize = True
        Me.LblTotalVentaCol.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold)
        Me.LblTotalVentaCol.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTotalVentaCol.Location = New System.Drawing.Point(13, 19)
        Me.LblTotalVentaCol.Name = "LblTotalVentaCol"
        Me.LblTotalVentaCol.Size = New System.Drawing.Size(37, 39)
        Me.LblTotalVentaCol.TabIndex = 0
        Me.LblTotalVentaCol.Text = "0"
        '
        'GbxRelPagosVenta
        '
        Me.GbxRelPagosVenta.Controls.Add(Me.Txbtotal_subtotal)
        Me.GbxRelPagosVenta.Controls.Add(Me.LblTotal_subtotal)
        Me.GbxRelPagosVenta.Controls.Add(Me.TxbTotalIva)
        Me.GbxRelPagosVenta.Controls.Add(Me.LblTotalIva)
        Me.GbxRelPagosVenta.Controls.Add(Me.TxbValorFormaPago)
        Me.GbxRelPagosVenta.Controls.Add(Me.BtnGuardarPago)
        Me.GbxRelPagosVenta.Controls.Add(Me.LblValorFormaPago)
        Me.GbxRelPagosVenta.Controls.Add(Me.DgvFormaPago)
        Me.GbxRelPagosVenta.Controls.Add(Me.CmbFormaPago)
        Me.GbxRelPagosVenta.Controls.Add(Me.LblFormaPago)
        Me.GbxRelPagosVenta.Location = New System.Drawing.Point(488, 344)
        Me.GbxRelPagosVenta.Name = "GbxRelPagosVenta"
        Me.GbxRelPagosVenta.Size = New System.Drawing.Size(516, 237)
        Me.GbxRelPagosVenta.TabIndex = 20
        Me.GbxRelPagosVenta.TabStop = False
        Me.GbxRelPagosVenta.Text = "RELACIÓN DE PAGOS DE ESTA VENTA"
        '
        'Txbtotal_subtotal
        '
        Me.Txbtotal_subtotal.Enabled = False
        Me.Txbtotal_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Txbtotal_subtotal.Location = New System.Drawing.Point(307, 52)
        Me.Txbtotal_subtotal.Multiline = True
        Me.Txbtotal_subtotal.Name = "Txbtotal_subtotal"
        Me.Txbtotal_subtotal.Size = New System.Drawing.Size(64, 24)
        Me.Txbtotal_subtotal.TabIndex = 11
        Me.Txbtotal_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblTotal_subtotal
        '
        Me.LblTotal_subtotal.AutoSize = True
        Me.LblTotal_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblTotal_subtotal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTotal_subtotal.Location = New System.Drawing.Point(251, 57)
        Me.LblTotal_subtotal.Name = "LblTotal_subtotal"
        Me.LblTotal_subtotal.Size = New System.Drawing.Size(54, 13)
        Me.LblTotal_subtotal.TabIndex = 10
        Me.LblTotal_subtotal.Text = "Subtotal"
        '
        'TxbTotalIva
        '
        Me.TxbTotalIva.Enabled = False
        Me.TxbTotalIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxbTotalIva.Location = New System.Drawing.Point(442, 54)
        Me.TxbTotalIva.Multiline = True
        Me.TxbTotalIva.Name = "TxbTotalIva"
        Me.TxbTotalIva.Size = New System.Drawing.Size(68, 22)
        Me.TxbTotalIva.TabIndex = 9
        Me.TxbTotalIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblTotalIva
        '
        Me.LblTotalIva.AutoSize = True
        Me.LblTotalIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LblTotalIva.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTotalIva.Location = New System.Drawing.Point(381, 57)
        Me.LblTotalIva.Name = "LblTotalIva"
        Me.LblTotalIva.Size = New System.Drawing.Size(58, 13)
        Me.LblTotalIva.TabIndex = 8
        Me.LblTotalIva.Text = "Total Iva"
        '
        'TxbValorFormaPago
        '
        Me.TxbValorFormaPago.AllowDrop = True
        Me.TxbValorFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbValorFormaPago.Location = New System.Drawing.Point(127, 51)
        Me.TxbValorFormaPago.MaxLength = 9
        Me.TxbValorFormaPago.Multiline = True
        Me.TxbValorFormaPago.Name = "TxbValorFormaPago"
        Me.TxbValorFormaPago.Size = New System.Drawing.Size(112, 24)
        Me.TxbValorFormaPago.TabIndex = 7
        Me.TxbValorFormaPago.UseSystemPasswordChar = True
        '
        'BtnGuardarPago
        '
        Me.BtnGuardarPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGuardarPago.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnGuardarPago.Location = New System.Drawing.Point(373, 15)
        Me.BtnGuardarPago.Name = "BtnGuardarPago"
        Me.BtnGuardarPago.Size = New System.Drawing.Size(125, 26)
        Me.BtnGuardarPago.TabIndex = 5
        Me.BtnGuardarPago.Text = "Guardar Pago"
        Me.BtnGuardarPago.UseVisualStyleBackColor = True
        '
        'LblValorFormaPago
        '
        Me.LblValorFormaPago.AutoSize = True
        Me.LblValorFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LblValorFormaPago.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblValorFormaPago.Location = New System.Drawing.Point(7, 60)
        Me.LblValorFormaPago.Name = "LblValorFormaPago"
        Me.LblValorFormaPago.Size = New System.Drawing.Size(46, 17)
        Me.LblValorFormaPago.TabIndex = 3
        Me.LblValorFormaPago.Text = "Valor"
        '
        'DgvFormaPago
        '
        Me.DgvFormaPago.AllowUserToAddRows = False
        Me.DgvFormaPago.AllowUserToDeleteRows = False
        Me.DgvFormaPago.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvFormaPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFormaPago.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.borrar, Me.cod_forma_pago, Me.Formapago, Me.valor})
        Me.DgvFormaPago.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DgvFormaPago.Location = New System.Drawing.Point(3, 98)
        Me.DgvFormaPago.Name = "DgvFormaPago"
        Me.DgvFormaPago.ReadOnly = True
        Me.DgvFormaPago.Size = New System.Drawing.Size(510, 136)
        Me.DgvFormaPago.TabIndex = 2
        '
        'borrar
        '
        Me.borrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.borrar.Frozen = True
        Me.borrar.HeaderText = "Borrar"
        Me.borrar.Name = "borrar"
        Me.borrar.ReadOnly = True
        Me.borrar.Width = 41
        '
        'cod_forma_pago
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod_forma_pago.DefaultCellStyle = DataGridViewCellStyle1
        Me.cod_forma_pago.Frozen = True
        Me.cod_forma_pago.HeaderText = "Codigo_forma_Pago"
        Me.cod_forma_pago.Name = "cod_forma_pago"
        Me.cod_forma_pago.ReadOnly = True
        Me.cod_forma_pago.Visible = False
        '
        'Formapago
        '
        Me.Formapago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Formapago.DefaultCellStyle = DataGridViewCellStyle2
        Me.Formapago.Frozen = True
        Me.Formapago.HeaderText = "Forma de Pago"
        Me.Formapago.Name = "Formapago"
        Me.Formapago.ReadOnly = True
        Me.Formapago.Width = 73
        '
        'valor
        '
        Me.valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.valor.DefaultCellStyle = DataGridViewCellStyle3
        Me.valor.Frozen = True
        Me.valor.HeaderText = "Valor"
        Me.valor.Name = "valor"
        Me.valor.ReadOnly = True
        Me.valor.Width = 56
        '
        'CmbFormaPago
        '
        Me.CmbFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.CmbFormaPago.FormattingEnabled = True
        Me.CmbFormaPago.Location = New System.Drawing.Point(127, 17)
        Me.CmbFormaPago.Name = "CmbFormaPago"
        Me.CmbFormaPago.Size = New System.Drawing.Size(223, 26)
        Me.CmbFormaPago.TabIndex = 1
        '
        'LblFormaPago
        '
        Me.LblFormaPago.AutoSize = True
        Me.LblFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LblFormaPago.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblFormaPago.Location = New System.Drawing.Point(3, 20)
        Me.LblFormaPago.Name = "LblFormaPago"
        Me.LblFormaPago.Size = New System.Drawing.Size(118, 17)
        Me.LblFormaPago.TabIndex = 0
        Me.LblFormaPago.Text = "Forma de Pago"
        '
        'GbRegistro
        '
        Me.GbRegistro.Controls.Add(Me.DgvReferencias)
        Me.GbRegistro.Location = New System.Drawing.Point(12, 85)
        Me.GbRegistro.Name = "GbRegistro"
        Me.GbRegistro.Size = New System.Drawing.Size(989, 251)
        Me.GbRegistro.TabIndex = 18
        Me.GbRegistro.TabStop = False
        Me.GbRegistro.Text = "FACTURA"
        '
        'DgvReferencias
        '
        Me.DgvReferencias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvReferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvReferencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Referencia, Me.Descripcion, Me.Cantidad, Me.valor_unitario, Me.iva, Me.totaliva, Me.descuento, Me.totaldescuento, Me.Subtotal})
        Me.DgvReferencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvReferencias.Location = New System.Drawing.Point(3, 16)
        Me.DgvReferencias.MultiSelect = False
        Me.DgvReferencias.Name = "DgvReferencias"
        Me.DgvReferencias.Size = New System.Drawing.Size(983, 232)
        Me.DgvReferencias.TabIndex = 1
        '
        'Referencia
        '
        Me.Referencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Referencia.DefaultCellStyle = DataGridViewCellStyle4
        Me.Referencia.Frozen = True
        Me.Referencia.HeaderText = "Referencia"
        Me.Referencia.Name = "Referencia"
        Me.Referencia.Width = 84
        '
        'Descripcion
        '
        Me.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Book Antiqua", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion.DefaultCellStyle = DataGridViewCellStyle5
        Me.Descripcion.Frozen = True
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 88
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Book Antiqua", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0"
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle6
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 74
        '
        'valor_unitario
        '
        Me.valor_unitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Book Antiqua", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = "0"
        Me.valor_unitario.DefaultCellStyle = DataGridViewCellStyle7
        Me.valor_unitario.HeaderText = "Valor Unitario"
        Me.valor_unitario.Name = "valor_unitario"
        Me.valor_unitario.ReadOnly = True
        Me.valor_unitario.Width = 95
        '
        'iva
        '
        Me.iva.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Book Antiqua", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.NullValue = "0"
        Me.iva.DefaultCellStyle = DataGridViewCellStyle8
        Me.iva.HeaderText = "% IVA"
        Me.iva.Name = "iva"
        Me.iva.ReadOnly = True
        Me.iva.Width = 60
        '
        'totaliva
        '
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Book Antiqua", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totaliva.DefaultCellStyle = DataGridViewCellStyle9
        Me.totaliva.HeaderText = "totaliva"
        Me.totaliva.Name = "totaliva"
        Me.totaliva.ReadOnly = True
        Me.totaliva.Visible = False
        '
        'descuento
        '
        Me.descuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Book Antiqua", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.NullValue = "0"
        Me.descuento.DefaultCellStyle = DataGridViewCellStyle10
        Me.descuento.HeaderText = "% Descuento"
        Me.descuento.Name = "descuento"
        Me.descuento.Width = 95
        '
        'totaldescuento
        '
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Book Antiqua", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totaldescuento.DefaultCellStyle = DataGridViewCellStyle11
        Me.totaldescuento.HeaderText = "totaldescuento"
        Me.totaldescuento.Name = "totaldescuento"
        Me.totaldescuento.ReadOnly = True
        Me.totaldescuento.Visible = False
        '
        'Subtotal
        '
        Me.Subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Book Antiqua", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.Format = "C2"
        DataGridViewCellStyle12.NullValue = "0"
        Me.Subtotal.DefaultCellStyle = DataGridViewCellStyle12
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        Me.Subtotal.Width = 71
        '
        'GbxNumero
        '
        Me.GbxNumero.Controls.Add(Me.TBFecha)
        Me.GbxNumero.Controls.Add(Me.Txbnumero)
        Me.GbxNumero.Controls.Add(Me.BtnNumero)
        Me.GbxNumero.Location = New System.Drawing.Point(12, 30)
        Me.GbxNumero.Name = "GbxNumero"
        Me.GbxNumero.Size = New System.Drawing.Size(393, 49)
        Me.GbxNumero.TabIndex = 17
        Me.GbxNumero.TabStop = False
        Me.GbxNumero.Text = "NÚMERO"
        '
        'TBFecha
        '
        Me.TBFecha.AllowDrop = True
        Me.TBFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBFecha.Location = New System.Drawing.Point(205, 17)
        Me.TBFecha.MaxLength = 9
        Me.TBFecha.Multiline = True
        Me.TBFecha.Name = "TBFecha"
        Me.TBFecha.Size = New System.Drawing.Size(181, 24)
        Me.TBFecha.TabIndex = 29
        Me.TBFecha.UseSystemPasswordChar = True
        '
        'Txbnumero
        '
        Me.Txbnumero.Font = New System.Drawing.Font("Book Antiqua", 12.0!)
        Me.Txbnumero.Location = New System.Drawing.Point(6, 17)
        Me.Txbnumero.MaxLength = 20
        Me.Txbnumero.Multiline = True
        Me.Txbnumero.Name = "Txbnumero"
        Me.Txbnumero.Size = New System.Drawing.Size(163, 24)
        Me.Txbnumero.TabIndex = 6
        '
        'BtnNumero
        '
        Me.BtnNumero.Image = CType(resources.GetObject("BtnNumero.Image"), System.Drawing.Image)
        Me.BtnNumero.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnNumero.Location = New System.Drawing.Point(175, 17)
        Me.BtnNumero.Name = "BtnNumero"
        Me.BtnNumero.Size = New System.Drawing.Size(24, 24)
        Me.BtnNumero.TabIndex = 4
        Me.BtnNumero.UseVisualStyleBackColor = True
        '
        'GbxCliente
        '
        Me.GbxCliente.Controls.Add(Me.CmbCliente)
        Me.GbxCliente.Location = New System.Drawing.Point(411, 30)
        Me.GbxCliente.Name = "GbxCliente"
        Me.GbxCliente.Size = New System.Drawing.Size(316, 49)
        Me.GbxCliente.TabIndex = 16
        Me.GbxCliente.TabStop = False
        Me.GbxCliente.Text = "CLIENTE"
        '
        'CmbCliente
        '
        Me.CmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.CmbCliente.FormattingEnabled = True
        Me.CmbCliente.Location = New System.Drawing.Point(6, 17)
        Me.CmbCliente.Name = "CmbCliente"
        Me.CmbCliente.Size = New System.Drawing.Size(304, 24)
        Me.CmbCliente.TabIndex = 7
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministracionToolStripMenuItem, Me.InformesToolStripMenuItem, Me.Usuario})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1016, 24)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministracionToolStripMenuItem
        '
        Me.AdministracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarMonedaToolStripMenuItem})
        Me.AdministracionToolStripMenuItem.Name = "AdministracionToolStripMenuItem"
        Me.AdministracionToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.AdministracionToolStripMenuItem.Text = "Administracion"
        '
        'ModificarMonedaToolStripMenuItem
        '
        Me.ModificarMonedaToolStripMenuItem.Name = "ModificarMonedaToolStripMenuItem"
        Me.ModificarMonedaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ModificarMonedaToolStripMenuItem.Text = "Actualizar TRM"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformeFiscalToolStripMenuItem})
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.InformesToolStripMenuItem.Text = "Informes"
        '
        'InformeFiscalToolStripMenuItem
        '
        Me.InformeFiscalToolStripMenuItem.Name = "InformeFiscalToolStripMenuItem"
        Me.InformeFiscalToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.InformeFiscalToolStripMenuItem.Text = "Informe Fiscal"
        '
        'Usuario
        '
        Me.Usuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Usuario.MergeIndex = 0
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(59, 20)
        Me.Usuario.Text = "Usuario"
        '
        'Acciones
        '
        Me.Acciones.Controls.Add(Me.BtnGuardarCambio)
        Me.Acciones.Controls.Add(Me.BtnCancelar)
        Me.Acciones.Controls.Add(Me.BtnModificar)
        Me.Acciones.Location = New System.Drawing.Point(488, 587)
        Me.Acciones.Name = "Acciones"
        Me.Acciones.Size = New System.Drawing.Size(512, 83)
        Me.Acciones.TabIndex = 28
        Me.Acciones.TabStop = False
        Me.Acciones.Text = "ACCIONES DE LA FACTURA"
        '
        'BtnGuardarCambio
        '
        Me.BtnGuardarCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardarCambio.Location = New System.Drawing.Point(374, 18)
        Me.BtnGuardarCambio.Name = "BtnGuardarCambio"
        Me.BtnGuardarCambio.Size = New System.Drawing.Size(121, 55)
        Me.BtnGuardarCambio.TabIndex = 3
        Me.BtnGuardarCambio.Text = "GUARDAR"
        Me.BtnGuardarCambio.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(199, 18)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(121, 55)
        Me.BtnCancelar.TabIndex = 2
        Me.BtnCancelar.Text = "CANCELAR"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Location = New System.Drawing.Point(29, 22)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(121, 55)
        Me.BtnModificar.TabIndex = 1
        Me.BtnModificar.Text = "MODIFICAR"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'Pos_Administrativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1016, 692)
        Me.Controls.Add(Me.Acciones)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GbObservaciones)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GbxMoneda)
        Me.Controls.Add(Me.GbxNavegacion)
        Me.Controls.Add(Me.GbxCambio)
        Me.Controls.Add(Me.GbTotal)
        Me.Controls.Add(Me.GbxRelPagosVenta)
        Me.Controls.Add(Me.GbRegistro)
        Me.Controls.Add(Me.GbxNumero)
        Me.Controls.Add(Me.GbxCliente)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Pos_Administrativo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pos Administrativo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GbObservaciones.ResumeLayout(False)
        Me.GbObservaciones.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GbxMoneda.ResumeLayout(False)
        Me.GbxNavegacion.ResumeLayout(False)
        Me.GbxCambio.ResumeLayout(False)
        Me.GbxCambio.PerformLayout()
        Me.GbTotal.ResumeLayout(False)
        Me.GbTotal.PerformLayout()
        Me.GbxRelPagosVenta.ResumeLayout(False)
        Me.GbxRelPagosVenta.PerformLayout()
        CType(Me.DgvFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbRegistro.ResumeLayout(False)
        CType(Me.DgvReferencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbxNumero.ResumeLayout(False)
        Me.GbxNumero.PerformLayout()
        Me.GbxCliente.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Acciones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkAnulado As System.Windows.Forms.CheckBox
    Friend WithEvents GbObservaciones As System.Windows.Forms.GroupBox
    Friend WithEvents TxbObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GbxMoneda As System.Windows.Forms.GroupBox
    Friend WithEvents CmbMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents GbxNavegacion As System.Windows.Forms.GroupBox
    Friend WithEvents GbxCambio As System.Windows.Forms.GroupBox
    Friend WithEvents LblSimboloCambioext As System.Windows.Forms.Label
    Friend WithEvents LblCambioMonedaExt As System.Windows.Forms.Label
    Friend WithEvents LblCambioMonedaCol As System.Windows.Forms.Label
    Friend WithEvents GbTotal As System.Windows.Forms.GroupBox
    Friend WithEvents LblSimbolototalExt As System.Windows.Forms.Label
    Friend WithEvents LblTotalVentaExt As System.Windows.Forms.Label
    Friend WithEvents LblTotalVentaCol As System.Windows.Forms.Label
    Friend WithEvents GbxRelPagosVenta As System.Windows.Forms.GroupBox
    Friend WithEvents Txbtotal_subtotal As System.Windows.Forms.TextBox
    Friend WithEvents LblTotal_subtotal As System.Windows.Forms.Label
    Friend WithEvents TxbTotalIva As System.Windows.Forms.TextBox
    Friend WithEvents LblTotalIva As System.Windows.Forms.Label
    Friend WithEvents TxbValorFormaPago As System.Windows.Forms.TextBox
    Friend WithEvents BtnGuardarPago As System.Windows.Forms.Button
    Friend WithEvents LblValorFormaPago As System.Windows.Forms.Label
    Friend WithEvents DgvFormaPago As System.Windows.Forms.DataGridView
    Friend WithEvents borrar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cod_forma_pago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Formapago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents valor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CmbFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents LblFormaPago As System.Windows.Forms.Label
    Friend WithEvents GbRegistro As System.Windows.Forms.GroupBox
    Friend WithEvents DgvReferencias As System.Windows.Forms.DataGridView
    Friend WithEvents Referencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents valor_unitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents iva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totaliva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totaldescuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GbxNumero As System.Windows.Forms.GroupBox
    Friend WithEvents Txbnumero As System.Windows.Forms.TextBox
    Friend WithEvents BtnNumero As System.Windows.Forms.Button
    Friend WithEvents GbxCliente As System.Windows.Forms.GroupBox
    Friend WithEvents CmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InformesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformeFiscalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnSiguiente As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents BtnAtras As System.Windows.Forms.Button
    Friend WithEvents AdministracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarMonedaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Acciones As System.Windows.Forms.GroupBox
    Friend WithEvents BtnGuardarCambio As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents TBFecha As System.Windows.Forms.TextBox
    Friend WithEvents Usuario As ToolStripMenuItem
End Class
