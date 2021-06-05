<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pagos_provee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pagos_provee))
        Me.Usuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.volverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbxaplicacion = New System.Windows.Forms.ComboBox()
        Me.cbxtpago = New System.Windows.Forms.ComboBox()
        Me.txtnit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbltpago = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtsecuencia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.cbxtcta = New System.Windows.Forms.ComboBox()
        Me.txtnocuenta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cbxtdoc = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdocaut = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtnoctaben = New System.Windows.Forms.TextBox()
        Me.cbxcban = New System.Windows.Forms.ComboBox()
        Me.cbxttran = New System.Windows.Forms.ComboBox()
        Me.txtnomben = New System.Windows.Forms.TextBox()
        Me.txtnitben = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.txtofentre = New System.Windows.Forms.TextBox()
        Me.txtref = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnmod = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnsend = New System.Windows.Forms.Button()
        Me.btnclean = New System.Windows.Forms.Button()
        Me.btnimport = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Usuario
        '
        Me.Usuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Usuario.MergeIndex = 0
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(59, 20)
        Me.Usuario.Text = "Usuario"
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministraciónToolStripMenuItem, Me.Usuario, Me.HerramientasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(780, 24)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedoresToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'cbxaplicacion
        '
        Me.cbxaplicacion.FormattingEnabled = True
        Me.cbxaplicacion.Items.AddRange(New Object() {"Inmediato"})
        Me.cbxaplicacion.Location = New System.Drawing.Point(77, 82)
        Me.cbxaplicacion.Name = "cbxaplicacion"
        Me.cbxaplicacion.Size = New System.Drawing.Size(139, 21)
        Me.cbxaplicacion.TabIndex = 8
        '
        'cbxtpago
        '
        Me.cbxtpago.FormattingEnabled = True
        Me.cbxtpago.Items.AddRange(New Object() {"", "Pago de Nómina", "Pago a Proveedores"})
        Me.cbxtpago.Location = New System.Drawing.Point(77, 46)
        Me.cbxtpago.Name = "cbxtpago"
        Me.cbxtpago.Size = New System.Drawing.Size(139, 21)
        Me.cbxtpago.TabIndex = 7
        '
        'txtnit
        '
        Me.txtnit.Location = New System.Drawing.Point(77, 13)
        Me.txtnit.Name = "txtnit"
        Me.txtnit.Size = New System.Drawing.Size(139, 20)
        Me.txtnit.TabIndex = 6
        Me.txtnit.Tag = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "*Secuencia:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "*Aplicación:"
        '
        'lbltpago
        '
        Me.lbltpago.AutoSize = True
        Me.lbltpago.Location = New System.Drawing.Point(12, 50)
        Me.lbltpago.Name = "lbltpago"
        Me.lbltpago.Size = New System.Drawing.Size(66, 13)
        Me.lbltpago.TabIndex = 1
        Me.lbltpago.Text = "*Tipo_Pago:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtsecuencia)
        Me.Panel1.Controls.Add(Me.cbxaplicacion)
        Me.Panel1.Controls.Add(Me.cbxtpago)
        Me.Panel1.Controls.Add(Me.txtnit)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lbltpago)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(229, 155)
        Me.Panel1.TabIndex = 20
        '
        'txtsecuencia
        '
        Me.txtsecuencia.Location = New System.Drawing.Point(77, 116)
        Me.txtsecuencia.Name = "txtsecuencia"
        Me.txtsecuencia.Size = New System.Drawing.Size(139, 20)
        Me.txtsecuencia.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "*Nit:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtdesc)
        Me.Panel2.Controls.Add(Me.cbxtcta)
        Me.Panel2.Controls.Add(Me.txtnocuenta)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(12, 188)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(229, 117)
        Me.Panel2.TabIndex = 21
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(80, 83)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(136, 20)
        Me.txtdesc.TabIndex = 5
        '
        'cbxtcta
        '
        Me.cbxtcta.FormattingEnabled = True
        Me.cbxtcta.Items.AddRange(New Object() {"", "Ahorros", "Corriente"})
        Me.cbxtcta.Location = New System.Drawing.Point(81, 48)
        Me.cbxtcta.Name = "cbxtcta"
        Me.cbxtcta.Size = New System.Drawing.Size(135, 21)
        Me.cbxtcta.TabIndex = 4
        '
        'txtnocuenta
        '
        Me.txtnocuenta.Location = New System.Drawing.Point(80, 15)
        Me.txtnocuenta.Name = "txtnocuenta"
        Me.txtnocuenta.Size = New System.Drawing.Size(136, 20)
        Me.txtnocuenta.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Descripción:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "*Tipo_Cuenta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "*No_Cuenta:"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.cbxtdoc)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txtdocaut)
        Me.Panel3.Controls.Add(Me.txtemail)
        Me.Panel3.Controls.Add(Me.txtnoctaben)
        Me.Panel3.Controls.Add(Me.cbxcban)
        Me.Panel3.Controls.Add(Me.cbxttran)
        Me.Panel3.Controls.Add(Me.txtnomben)
        Me.Panel3.Controls.Add(Me.txtnitben)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Location = New System.Drawing.Point(247, 27)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(279, 278)
        Me.Panel3.TabIndex = 22
        '
        'cbxtdoc
        '
        Me.cbxtdoc.FormattingEnabled = True
        Me.cbxtdoc.Items.AddRange(New Object() {"", "Cédula", "Cédula de Extranjería", "Nit", "Tarejta de Identidad", "Pasaporte"})
        Me.cbxtdoc.Location = New System.Drawing.Point(108, 43)
        Me.cbxtdoc.Name = "cbxtdoc"
        Me.cbxtdoc.Size = New System.Drawing.Size(158, 21)
        Me.cbxtdoc.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "*Tipo_Documento:"
        '
        'txtdocaut
        '
        Me.txtdocaut.Location = New System.Drawing.Point(108, 243)
        Me.txtdocaut.Name = "txtdocaut"
        Me.txtdocaut.Size = New System.Drawing.Size(158, 20)
        Me.txtdocaut.TabIndex = 15
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(47, 209)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(219, 20)
        Me.txtemail.TabIndex = 14
        '
        'txtnoctaben
        '
        Me.txtnoctaben.Location = New System.Drawing.Point(108, 174)
        Me.txtnoctaben.Name = "txtnoctaben"
        Me.txtnoctaben.Size = New System.Drawing.Size(158, 20)
        Me.txtnoctaben.TabIndex = 13
        '
        'cbxcban
        '
        Me.cbxcban.FormattingEnabled = True
        Me.cbxcban.Location = New System.Drawing.Point(81, 144)
        Me.cbxcban.Name = "cbxcban"
        Me.cbxcban.Size = New System.Drawing.Size(185, 21)
        Me.cbxcban.TabIndex = 12
        '
        'cbxttran
        '
        Me.cbxttran.FormattingEnabled = True
        Me.cbxttran.Items.AddRange(New Object() {"", "Abono a Cta de Ahorros", "Abono a Cta Corriente"})
        Me.cbxttran.Location = New System.Drawing.Point(108, 110)
        Me.cbxttran.Name = "cbxttran"
        Me.cbxttran.Size = New System.Drawing.Size(158, 21)
        Me.cbxttran.TabIndex = 11
        '
        'txtnomben
        '
        Me.txtnomben.Location = New System.Drawing.Point(62, 77)
        Me.txtnomben.Name = "txtnomben"
        Me.txtnomben.Size = New System.Drawing.Size(204, 20)
        Me.txtnomben.TabIndex = 10
        '
        'txtnitben
        '
        Me.txtnitben.Location = New System.Drawing.Point(108, 13)
        Me.txtnitben.Name = "txtnitben"
        Me.txtnitben.Size = New System.Drawing.Size(158, 20)
        Me.txtnitben.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 246)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Doc_Autorizado:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 214)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Email:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 181)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "*No_Cuenta:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 149)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "*Cod_Banco:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "*Tipo_Transacción:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Nombre:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "*Nit_Beneficiario:"
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(111, 68)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(110, 20)
        Me.txtvalor.TabIndex = 22
        '
        'txtofentre
        '
        Me.txtofentre.Location = New System.Drawing.Point(111, 42)
        Me.txtofentre.Name = "txtofentre"
        Me.txtofentre.Size = New System.Drawing.Size(110, 20)
        Me.txtofentre.TabIndex = 21
        '
        'txtref
        '
        Me.txtref.Location = New System.Drawing.Point(111, 13)
        Me.txtref.Name = "txtref"
        Me.txtref.Size = New System.Drawing.Size(110, 20)
        Me.txtref.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 13)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Referencia:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(14, 45)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 13)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Oficina_Entrega:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(14, 73)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 13)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "*Valor:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(13, 102)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(92, 13)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Fecha Aplicación:"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.dtpfecha)
        Me.Panel4.Controls.Add(Me.txtvalor)
        Me.Panel4.Controls.Add(Me.txtofentre)
        Me.Panel4.Controls.Add(Me.txtref)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Location = New System.Drawing.Point(533, 27)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(235, 130)
        Me.Panel4.TabIndex = 23
        '
        'dtpfecha
        '
        Me.dtpfecha.Location = New System.Drawing.Point(111, 97)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(109, 20)
        Me.dtpfecha.TabIndex = 23
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(37, 10)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(161, 35)
        Me.btnadd.TabIndex = 0
        Me.btnadd.Text = "Agregar"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.btnmod)
        Me.Panel5.Controls.Add(Me.btnnew)
        Me.Panel5.Controls.Add(Me.btnadd)
        Me.Panel5.Location = New System.Drawing.Point(534, 163)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(234, 142)
        Me.Panel5.TabIndex = 24
        '
        'btnmod
        '
        Me.btnmod.Location = New System.Drawing.Point(37, 92)
        Me.btnmod.Name = "btnmod"
        Me.btnmod.Size = New System.Drawing.Size(161, 35)
        Me.btnmod.TabIndex = 2
        Me.btnmod.Text = "Modificar"
        Me.btnmod.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Location = New System.Drawing.Point(37, 51)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(161, 35)
        Me.btnnew.TabIndex = 1
        Me.btnnew.Text = "Nuevo"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column5, Me.Column6, Me.Column7, Me.Column2, Me.Column3, Me.Column4, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16, Me.Column17, Me.Column18, Me.Column19})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 311)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(755, 150)
        Me.DataGridView1.TabIndex = 25
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nit Pagador"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 81
        '
        'Column5
        '
        Me.Column5.HeaderText = "Tipo Pago"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 75
        '
        'Column6
        '
        Me.Column6.HeaderText = "Aplicación"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 81
        '
        'Column7
        '
        Me.Column7.HeaderText = "Secuencia"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 83
        '
        'Column2
        '
        Me.Column2.HeaderText = "No Cuenta"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 77
        '
        'Column3
        '
        Me.Column3.HeaderText = "Tipo Cta"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 67
        '
        'Column4
        '
        Me.Column4.HeaderText = "Descripción"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 88
        '
        'Column8
        '
        Me.Column8.HeaderText = "Tipo Doc Beneficiario"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 123
        '
        'Column9
        '
        Me.Column9.HeaderText = "Nit Beneficiario"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 95
        '
        'Column10
        '
        Me.Column10.HeaderText = "Nombre Beneficiario"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 116
        '
        'Column11
        '
        Me.Column11.HeaderText = "Tipo Transaccion"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 105
        '
        'Column12
        '
        Me.Column12.HeaderText = "Codigo Banco"
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 91
        '
        'Column13
        '
        Me.Column13.HeaderText = "No Cta Beneficiario"
        Me.Column13.Name = "Column13"
        Me.Column13.Width = 113
        '
        'Column14
        '
        Me.Column14.HeaderText = "Email"
        Me.Column14.Name = "Column14"
        Me.Column14.Width = 57
        '
        'Column15
        '
        Me.Column15.HeaderText = "Doc Autorizado"
        Me.Column15.Name = "Column15"
        Me.Column15.Width = 96
        '
        'Column16
        '
        Me.Column16.HeaderText = "Referencia"
        Me.Column16.Name = "Column16"
        Me.Column16.Width = 84
        '
        'Column17
        '
        Me.Column17.HeaderText = "Oficina Entrega"
        Me.Column17.Name = "Column17"
        Me.Column17.Width = 96
        '
        'Column18
        '
        Me.Column18.HeaderText = "Valor Transaccion"
        Me.Column18.Name = "Column18"
        Me.Column18.Width = 108
        '
        'Column19
        '
        Me.Column19.HeaderText = "Fecha Aplicacion"
        Me.Column19.Name = "Column19"
        Me.Column19.Width = 105
        '
        'btnsend
        '
        Me.btnsend.Location = New System.Drawing.Point(520, 467)
        Me.btnsend.Name = "btnsend"
        Me.btnsend.Size = New System.Drawing.Size(216, 40)
        Me.btnsend.TabIndex = 28
        Me.btnsend.Text = "Exportar"
        Me.btnsend.UseVisualStyleBackColor = True
        '
        'btnclean
        '
        Me.btnclean.Location = New System.Drawing.Point(285, 467)
        Me.btnclean.Name = "btnclean"
        Me.btnclean.Size = New System.Drawing.Size(216, 40)
        Me.btnclean.TabIndex = 27
        Me.btnclean.Text = "Limpiar"
        Me.btnclean.UseVisualStyleBackColor = True
        '
        'btnimport
        '
        Me.btnimport.Location = New System.Drawing.Point(51, 467)
        Me.btnimport.Name = "btnimport"
        Me.btnimport.Size = New System.Drawing.Size(216, 40)
        Me.btnimport.TabIndex = 26
        Me.btnimport.Text = "Importar"
        Me.btnimport.UseVisualStyleBackColor = True
        '
        'Pagos_provee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 515)
        Me.Controls.Add(Me.btnsend)
        Me.Controls.Add(Me.btnclean)
        Me.Controls.Add(Me.btnimport)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pagos_provee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagos_proveedores"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Usuario As ToolStripMenuItem
    Friend WithEvents AdministraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents volverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents cbxaplicacion As ComboBox
    Friend WithEvents cbxtpago As ComboBox
    Friend WithEvents txtnit As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbltpago As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtsecuencia As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtdesc As TextBox
    Friend WithEvents cbxtcta As ComboBox
    Friend WithEvents txtnocuenta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtdocaut As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtnoctaben As TextBox
    Friend WithEvents cbxcban As ComboBox
    Friend WithEvents cbxttran As ComboBox
    Friend WithEvents txtnomben As TextBox
    Friend WithEvents txtnitben As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtvalor As TextBox
    Friend WithEvents txtofentre As TextBox
    Friend WithEvents txtref As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents btnadd As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnmod As Button
    Friend WithEvents btnnew As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents btnsend As Button
    Friend WithEvents btnclean As Button
    Friend WithEvents btnimport As Button
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cbxtdoc As ComboBox
    Friend WithEvents Label7 As Label
End Class
