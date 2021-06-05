<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal_usuario_req
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.AdministracoinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuejasYNoConformidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TecnicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbIncyReq = New System.Windows.Forms.GroupBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxbDescripcion = New System.Windows.Forms.TextBox()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.Cmbtipo = New System.Windows.Forms.ComboBox()
        Me.TiporeqBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsConsultas = New SEsupport.DsConsultas()
        Me.LblTipoReq = New System.Windows.Forms.Label()
        Me.CmbUsuario = New System.Windows.Forms.ComboBox()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.CmbModulo = New System.Windows.Forms.ComboBox()
        Me.ModuloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LblModulo = New System.Windows.Forms.Label()
        Me.CmbPrioridad = New System.Windows.Forms.ComboBox()
        Me.PrioridadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DgvPendientes = New System.Windows.Forms.DataGridView()
        Me.Idhist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescusuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdmoduloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescmoduloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdprioridadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescprioridadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdestadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescestadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdtipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesctipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechageneracionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechasugeridaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaentregaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TecnicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesctecnicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalificacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacioncalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SolusuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoltecnicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwhistincreqBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BbPendientes = New System.Windows.Forms.GroupBox()
        Me.CmbEstado = New System.Windows.Forms.ComboBox()
        Me.EstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LblFiltro = New System.Windows.Forms.Label()
        Me.PrioridadTableAdapter = New SEsupport.DsConsultasTableAdapters.PrioridadTableAdapter()
        Me.ModuloTableAdapter = New SEsupport.DsConsultasTableAdapters.ModuloTableAdapter()
        Me.Tipo_reqTableAdapter = New SEsupport.DsConsultasTableAdapters.tipo_reqTableAdapter()
        Me.UsuarioTableAdapter = New SEsupport.DsConsultasTableAdapters.UsuarioTableAdapter()
        Me.Vw_hist_inc_reqTableAdapter = New SEsupport.DsConsultasTableAdapters.vw_hist_inc_reqTableAdapter()
        Me.EstadoTableAdapter = New SEsupport.DsConsultasTableAdapters.EstadoTableAdapter()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GbIncyReq.SuspendLayout()
        CType(Me.TiporeqBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModuloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrioridadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwhistincreqBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BbPendientes.SuspendLayout()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 700)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(87, 17)
        Me.ToolStripStatusLabel1.Text = "Usuario Activo:"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'AdministracoinToolStripMenuItem
        '
        Me.AdministracoinToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuejasYNoConformidadesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.AdministracoinToolStripMenuItem.Name = "AdministracoinToolStripMenuItem"
        Me.AdministracoinToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.AdministracoinToolStripMenuItem.Text = "Archivo"
        '
        'QuejasYNoConformidadesToolStripMenuItem
        '
        Me.QuejasYNoConformidadesToolStripMenuItem.Name = "QuejasYNoConformidadesToolStripMenuItem"
        Me.QuejasYNoConformidadesToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.QuejasYNoConformidadesToolStripMenuItem.Text = "Volver al inicio"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.InformesToolStripMenuItem.Text = "Informes"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministracoinToolStripMenuItem, Me.AdministraciónToolStripMenuItem, Me.InformesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministraciónToolStripMenuItem
        '
        Me.AdministraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TecnicoToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.AdministraciónToolStripMenuItem.Name = "AdministraciónToolStripMenuItem"
        Me.AdministraciónToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.AdministraciónToolStripMenuItem.Text = "Administración"
        '
        'TecnicoToolStripMenuItem
        '
        Me.TecnicoToolStripMenuItem.Name = "TecnicoToolStripMenuItem"
        Me.TecnicoToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.TecnicoToolStripMenuItem.Text = "Tecnico"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'GbIncyReq
        '
        Me.GbIncyReq.Controls.Add(Me.BtnCancelar)
        Me.GbIncyReq.Controls.Add(Me.BtnGuardar)
        Me.GbIncyReq.Controls.Add(Me.TxbDescripcion)
        Me.GbIncyReq.Controls.Add(Me.LblDescripcion)
        Me.GbIncyReq.Controls.Add(Me.Cmbtipo)
        Me.GbIncyReq.Controls.Add(Me.LblTipoReq)
        Me.GbIncyReq.Controls.Add(Me.CmbUsuario)
        Me.GbIncyReq.Controls.Add(Me.LblUsuario)
        Me.GbIncyReq.Controls.Add(Me.CmbModulo)
        Me.GbIncyReq.Controls.Add(Me.LblModulo)
        Me.GbIncyReq.Controls.Add(Me.CmbPrioridad)
        Me.GbIncyReq.Controls.Add(Me.Label2)
        Me.GbIncyReq.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbIncyReq.Location = New System.Drawing.Point(12, 33)
        Me.GbIncyReq.Name = "GbIncyReq"
        Me.GbIncyReq.Size = New System.Drawing.Size(757, 280)
        Me.GbIncyReq.TabIndex = 6
        Me.GbIncyReq.TabStop = False
        Me.GbIncyReq.Text = "Incidentes y Requerimientos"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(423, 226)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(94, 36)
        Me.BtnCancelar.TabIndex = 21
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(262, 226)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(94, 36)
        Me.BtnGuardar.TabIndex = 20
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'TxbDescripcion
        '
        Me.TxbDescripcion.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbDescripcion.Location = New System.Drawing.Point(93, 128)
        Me.TxbDescripcion.Multiline = True
        Me.TxbDescripcion.Name = "TxbDescripcion"
        Me.TxbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxbDescripcion.Size = New System.Drawing.Size(631, 92)
        Me.TxbDescripcion.TabIndex = 19
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.Location = New System.Drawing.Point(6, 162)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(86, 18)
        Me.LblDescripcion.TabIndex = 18
        Me.LblDescripcion.Text = "Descripción"
        '
        'Cmbtipo
        '
        Me.Cmbtipo.DataSource = Me.TiporeqBindingSource
        Me.Cmbtipo.DisplayMember = "Desc_tipo"
        Me.Cmbtipo.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbtipo.FormattingEnabled = True
        Me.Cmbtipo.Location = New System.Drawing.Point(447, 29)
        Me.Cmbtipo.Name = "Cmbtipo"
        Me.Cmbtipo.Size = New System.Drawing.Size(182, 26)
        Me.Cmbtipo.TabIndex = 17
        Me.Cmbtipo.ValueMember = "Idtipo"
        '
        'TiporeqBindingSource
        '
        Me.TiporeqBindingSource.DataMember = "tipo_req"
        Me.TiporeqBindingSource.DataSource = Me.DsConsultas
        '
        'DsConsultas
        '
        Me.DsConsultas.DataSetName = "DsConsultas"
        Me.DsConsultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LblTipoReq
        '
        Me.LblTipoReq.AutoSize = True
        Me.LblTipoReq.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipoReq.Location = New System.Drawing.Point(295, 32)
        Me.LblTipoReq.Name = "LblTipoReq"
        Me.LblTipoReq.Size = New System.Drawing.Size(139, 18)
        Me.LblTipoReq.TabIndex = 16
        Me.LblTipoReq.Text = "Tipo Requerimiento"
        '
        'CmbUsuario
        '
        Me.CmbUsuario.DataSource = Me.UsuarioBindingSource
        Me.CmbUsuario.DisplayMember = "Desc_usuario"
        Me.CmbUsuario.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbUsuario.FormattingEnabled = True
        Me.CmbUsuario.Location = New System.Drawing.Point(359, 69)
        Me.CmbUsuario.Name = "CmbUsuario"
        Me.CmbUsuario.Size = New System.Drawing.Size(270, 26)
        Me.CmbUsuario.TabIndex = 15
        Me.CmbUsuario.ValueMember = "Usuario"
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.DsConsultas
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.Location = New System.Drawing.Point(293, 72)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(60, 18)
        Me.LblUsuario.TabIndex = 14
        Me.LblUsuario.Text = "Usuario"
        '
        'CmbModulo
        '
        Me.CmbModulo.DataSource = Me.ModuloBindingSource
        Me.CmbModulo.DisplayMember = "Desc_modulo"
        Me.CmbModulo.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbModulo.FormattingEnabled = True
        Me.CmbModulo.Location = New System.Drawing.Point(93, 69)
        Me.CmbModulo.Name = "CmbModulo"
        Me.CmbModulo.Size = New System.Drawing.Size(179, 26)
        Me.CmbModulo.TabIndex = 13
        Me.CmbModulo.ValueMember = "IdModulo"
        '
        'ModuloBindingSource
        '
        Me.ModuloBindingSource.DataMember = "Modulo"
        Me.ModuloBindingSource.DataSource = Me.DsConsultas
        '
        'LblModulo
        '
        Me.LblModulo.AutoSize = True
        Me.LblModulo.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblModulo.Location = New System.Drawing.Point(6, 72)
        Me.LblModulo.Name = "LblModulo"
        Me.LblModulo.Size = New System.Drawing.Size(54, 18)
        Me.LblModulo.TabIndex = 12
        Me.LblModulo.Text = "Modulo"
        '
        'CmbPrioridad
        '
        Me.CmbPrioridad.DataSource = Me.PrioridadBindingSource
        Me.CmbPrioridad.DisplayMember = "Desc_prioridad"
        Me.CmbPrioridad.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPrioridad.FormattingEnabled = True
        Me.CmbPrioridad.Location = New System.Drawing.Point(93, 34)
        Me.CmbPrioridad.Name = "CmbPrioridad"
        Me.CmbPrioridad.Size = New System.Drawing.Size(179, 26)
        Me.CmbPrioridad.TabIndex = 11
        Me.CmbPrioridad.ValueMember = "IdPrioridad"
        '
        'PrioridadBindingSource
        '
        Me.PrioridadBindingSource.DataMember = "Prioridad"
        Me.PrioridadBindingSource.DataSource = Me.DsConsultas
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Prioridad"
        '
        'DgvPendientes
        '
        Me.DgvPendientes.AllowUserToAddRows = False
        Me.DgvPendientes.AllowUserToDeleteRows = False
        Me.DgvPendientes.AllowUserToOrderColumns = True
        Me.DgvPendientes.AutoGenerateColumns = False
        Me.DgvPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPendientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Idhist, Me.UsuarioDataGridViewTextBoxColumn, Me.DescusuarioDataGridViewTextBoxColumn, Me.IdmoduloDataGridViewTextBoxColumn, Me.DescmoduloDataGridViewTextBoxColumn, Me.IdprioridadDataGridViewTextBoxColumn, Me.DescprioridadDataGridViewTextBoxColumn, Me.IdestadoDataGridViewTextBoxColumn, Me.DescestadoDataGridViewTextBoxColumn, Me.IdtipoDataGridViewTextBoxColumn, Me.DesctipoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.FechageneracionDataGridViewTextBoxColumn, Me.FechasugeridaDataGridViewTextBoxColumn, Me.FechaentregaDataGridViewTextBoxColumn, Me.TecnicoDataGridViewTextBoxColumn, Me.DesctecnicoDataGridViewTextBoxColumn, Me.CalificacionDataGridViewTextBoxColumn, Me.ObservacioncalDataGridViewTextBoxColumn, Me.SolusuarioDataGridViewTextBoxColumn, Me.SoltecnicoDataGridViewTextBoxColumn})
        Me.DgvPendientes.DataSource = Me.VwhistincreqBindingSource
        Me.DgvPendientes.Location = New System.Drawing.Point(0, 84)
        Me.DgvPendientes.MultiSelect = False
        Me.DgvPendientes.Name = "DgvPendientes"
        Me.DgvPendientes.ReadOnly = True
        Me.DgvPendientes.Size = New System.Drawing.Size(760, 259)
        Me.DgvPendientes.TabIndex = 8
        '
        'Idhist
        '
        Me.Idhist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Idhist.DataPropertyName = "Idhist"
        Me.Idhist.Frozen = True
        Me.Idhist.HeaderText = "Número"
        Me.Idhist.Name = "Idhist"
        Me.Idhist.ReadOnly = True
        Me.Idhist.Width = 86
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescusuarioDataGridViewTextBoxColumn
        '
        Me.DescusuarioDataGridViewTextBoxColumn.DataPropertyName = "desc_usuario"
        Me.DescusuarioDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.DescusuarioDataGridViewTextBoxColumn.Name = "DescusuarioDataGridViewTextBoxColumn"
        Me.DescusuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdmoduloDataGridViewTextBoxColumn
        '
        Me.IdmoduloDataGridViewTextBoxColumn.DataPropertyName = "idmodulo"
        Me.IdmoduloDataGridViewTextBoxColumn.HeaderText = "idmodulo"
        Me.IdmoduloDataGridViewTextBoxColumn.Name = "IdmoduloDataGridViewTextBoxColumn"
        Me.IdmoduloDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdmoduloDataGridViewTextBoxColumn.Visible = False
        '
        'DescmoduloDataGridViewTextBoxColumn
        '
        Me.DescmoduloDataGridViewTextBoxColumn.DataPropertyName = "Desc_modulo"
        Me.DescmoduloDataGridViewTextBoxColumn.HeaderText = "Módulo"
        Me.DescmoduloDataGridViewTextBoxColumn.Name = "DescmoduloDataGridViewTextBoxColumn"
        Me.DescmoduloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdprioridadDataGridViewTextBoxColumn
        '
        Me.IdprioridadDataGridViewTextBoxColumn.DataPropertyName = "idprioridad"
        Me.IdprioridadDataGridViewTextBoxColumn.HeaderText = "idprioridad"
        Me.IdprioridadDataGridViewTextBoxColumn.Name = "IdprioridadDataGridViewTextBoxColumn"
        Me.IdprioridadDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdprioridadDataGridViewTextBoxColumn.Visible = False
        '
        'DescprioridadDataGridViewTextBoxColumn
        '
        Me.DescprioridadDataGridViewTextBoxColumn.DataPropertyName = "desc_prioridad"
        Me.DescprioridadDataGridViewTextBoxColumn.HeaderText = "Prioridad"
        Me.DescprioridadDataGridViewTextBoxColumn.Name = "DescprioridadDataGridViewTextBoxColumn"
        Me.DescprioridadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdestadoDataGridViewTextBoxColumn
        '
        Me.IdestadoDataGridViewTextBoxColumn.DataPropertyName = "idestado"
        Me.IdestadoDataGridViewTextBoxColumn.HeaderText = "idestado"
        Me.IdestadoDataGridViewTextBoxColumn.Name = "IdestadoDataGridViewTextBoxColumn"
        Me.IdestadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdestadoDataGridViewTextBoxColumn.Visible = False
        '
        'DescestadoDataGridViewTextBoxColumn
        '
        Me.DescestadoDataGridViewTextBoxColumn.DataPropertyName = "desc_estado"
        Me.DescestadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.DescestadoDataGridViewTextBoxColumn.Name = "DescestadoDataGridViewTextBoxColumn"
        Me.DescestadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdtipoDataGridViewTextBoxColumn
        '
        Me.IdtipoDataGridViewTextBoxColumn.DataPropertyName = "idtipo"
        Me.IdtipoDataGridViewTextBoxColumn.HeaderText = "idtipo"
        Me.IdtipoDataGridViewTextBoxColumn.Name = "IdtipoDataGridViewTextBoxColumn"
        Me.IdtipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdtipoDataGridViewTextBoxColumn.Visible = False
        '
        'DesctipoDataGridViewTextBoxColumn
        '
        Me.DesctipoDataGridViewTextBoxColumn.DataPropertyName = "desc_tipo"
        Me.DesctipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.DesctipoDataGridViewTextBoxColumn.Name = "DesctipoDataGridViewTextBoxColumn"
        Me.DesctipoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechageneracionDataGridViewTextBoxColumn
        '
        Me.FechageneracionDataGridViewTextBoxColumn.DataPropertyName = "fecha_generacion"
        Me.FechageneracionDataGridViewTextBoxColumn.HeaderText = "Fecha Generación"
        Me.FechageneracionDataGridViewTextBoxColumn.Name = "FechageneracionDataGridViewTextBoxColumn"
        Me.FechageneracionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechasugeridaDataGridViewTextBoxColumn
        '
        Me.FechasugeridaDataGridViewTextBoxColumn.DataPropertyName = "fecha_sugerida"
        Me.FechasugeridaDataGridViewTextBoxColumn.HeaderText = "Fecha Sugerida"
        Me.FechasugeridaDataGridViewTextBoxColumn.Name = "FechasugeridaDataGridViewTextBoxColumn"
        Me.FechasugeridaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaentregaDataGridViewTextBoxColumn
        '
        Me.FechaentregaDataGridViewTextBoxColumn.DataPropertyName = "fecha_entrega"
        Me.FechaentregaDataGridViewTextBoxColumn.HeaderText = "Fecha Entrega"
        Me.FechaentregaDataGridViewTextBoxColumn.Name = "FechaentregaDataGridViewTextBoxColumn"
        Me.FechaentregaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TecnicoDataGridViewTextBoxColumn
        '
        Me.TecnicoDataGridViewTextBoxColumn.DataPropertyName = "tecnico"
        Me.TecnicoDataGridViewTextBoxColumn.HeaderText = "tecnico"
        Me.TecnicoDataGridViewTextBoxColumn.Name = "TecnicoDataGridViewTextBoxColumn"
        Me.TecnicoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TecnicoDataGridViewTextBoxColumn.Visible = False
        '
        'DesctecnicoDataGridViewTextBoxColumn
        '
        Me.DesctecnicoDataGridViewTextBoxColumn.DataPropertyName = "desc_tecnico"
        Me.DesctecnicoDataGridViewTextBoxColumn.HeaderText = "Técnico"
        Me.DesctecnicoDataGridViewTextBoxColumn.Name = "DesctecnicoDataGridViewTextBoxColumn"
        Me.DesctecnicoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CalificacionDataGridViewTextBoxColumn
        '
        Me.CalificacionDataGridViewTextBoxColumn.DataPropertyName = "calificacion"
        Me.CalificacionDataGridViewTextBoxColumn.HeaderText = "calificacion"
        Me.CalificacionDataGridViewTextBoxColumn.Name = "CalificacionDataGridViewTextBoxColumn"
        Me.CalificacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.CalificacionDataGridViewTextBoxColumn.Visible = False
        '
        'ObservacioncalDataGridViewTextBoxColumn
        '
        Me.ObservacioncalDataGridViewTextBoxColumn.DataPropertyName = "observacion_cal"
        Me.ObservacioncalDataGridViewTextBoxColumn.HeaderText = "observacion_cal"
        Me.ObservacioncalDataGridViewTextBoxColumn.Name = "ObservacioncalDataGridViewTextBoxColumn"
        Me.ObservacioncalDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObservacioncalDataGridViewTextBoxColumn.Visible = False
        '
        'SolusuarioDataGridViewTextBoxColumn
        '
        Me.SolusuarioDataGridViewTextBoxColumn.DataPropertyName = "sol_usuario"
        Me.SolusuarioDataGridViewTextBoxColumn.HeaderText = "sol_usuario"
        Me.SolusuarioDataGridViewTextBoxColumn.Name = "SolusuarioDataGridViewTextBoxColumn"
        Me.SolusuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.SolusuarioDataGridViewTextBoxColumn.Visible = False
        '
        'SoltecnicoDataGridViewTextBoxColumn
        '
        Me.SoltecnicoDataGridViewTextBoxColumn.DataPropertyName = "sol_tecnico"
        Me.SoltecnicoDataGridViewTextBoxColumn.HeaderText = "sol_tecnico"
        Me.SoltecnicoDataGridViewTextBoxColumn.Name = "SoltecnicoDataGridViewTextBoxColumn"
        Me.SoltecnicoDataGridViewTextBoxColumn.ReadOnly = True
        Me.SoltecnicoDataGridViewTextBoxColumn.Visible = False
        '
        'VwhistincreqBindingSource
        '
        Me.VwhistincreqBindingSource.DataMember = "vw_hist_inc_req"
        Me.VwhistincreqBindingSource.DataSource = Me.DsConsultas
        '
        'BbPendientes
        '
        Me.BbPendientes.Controls.Add(Me.CmbEstado)
        Me.BbPendientes.Controls.Add(Me.LblFiltro)
        Me.BbPendientes.Controls.Add(Me.DgvPendientes)
        Me.BbPendientes.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BbPendientes.Location = New System.Drawing.Point(12, 348)
        Me.BbPendientes.Name = "BbPendientes"
        Me.BbPendientes.Size = New System.Drawing.Size(760, 349)
        Me.BbPendientes.TabIndex = 9
        Me.BbPendientes.TabStop = False
        Me.BbPendientes.Text = "Pendientes"
        '
        'CmbEstado
        '
        Me.CmbEstado.DataSource = Me.EstadoBindingSource
        Me.CmbEstado.DisplayMember = "Desc_estado"
        Me.CmbEstado.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEstado.FormattingEnabled = True
        Me.CmbEstado.Location = New System.Drawing.Point(93, 32)
        Me.CmbEstado.Name = "CmbEstado"
        Me.CmbEstado.Size = New System.Drawing.Size(152, 26)
        Me.CmbEstado.TabIndex = 12
        Me.CmbEstado.ValueMember = "IdEstado"
        '
        'EstadoBindingSource
        '
        Me.EstadoBindingSource.DataMember = "Estado"
        Me.EstadoBindingSource.DataSource = Me.DsConsultas
        '
        'LblFiltro
        '
        Me.LblFiltro.AutoSize = True
        Me.LblFiltro.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFiltro.Location = New System.Drawing.Point(6, 35)
        Me.LblFiltro.Name = "LblFiltro"
        Me.LblFiltro.Size = New System.Drawing.Size(43, 18)
        Me.LblFiltro.TabIndex = 19
        Me.LblFiltro.Text = "Filtro"
        '
        'PrioridadTableAdapter
        '
        Me.PrioridadTableAdapter.ClearBeforeFill = True
        '
        'ModuloTableAdapter
        '
        Me.ModuloTableAdapter.ClearBeforeFill = True
        '
        'Tipo_reqTableAdapter
        '
        Me.Tipo_reqTableAdapter.ClearBeforeFill = True
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'Vw_hist_inc_reqTableAdapter
        '
        Me.Vw_hist_inc_reqTableAdapter.ClearBeforeFill = True
        '
        'EstadoTableAdapter
        '
        Me.EstadoTableAdapter.ClearBeforeFill = True
        '
        'Principal_usuario_req
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(784, 722)
        Me.Controls.Add(Me.BbPendientes)
        Me.Controls.Add(Me.GbIncyReq)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MaximizeBox = False
        Me.Name = "Principal_usuario_req"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal - SEsupport"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GbIncyReq.ResumeLayout(False)
        Me.GbIncyReq.PerformLayout()
        CType(Me.TiporeqBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModuloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrioridadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwhistincreqBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BbPendientes.ResumeLayout(False)
        Me.BbPendientes.PerformLayout()
        CType(Me.EstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AdministracoinToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdministraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuejasYNoConformidadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GbIncyReq As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents TxbDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents LblDescripcion As System.Windows.Forms.Label
    Friend WithEvents Cmbtipo As System.Windows.Forms.ComboBox
    Friend WithEvents LblTipoReq As System.Windows.Forms.Label
    Friend WithEvents CmbUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents LblUsuario As System.Windows.Forms.Label
    Friend WithEvents CmbModulo As System.Windows.Forms.ComboBox
    Friend WithEvents LblModulo As System.Windows.Forms.Label
    Friend WithEvents CmbPrioridad As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DgvPendientes As System.Windows.Forms.DataGridView
    Friend WithEvents BbPendientes As System.Windows.Forms.GroupBox
    Friend WithEvents DsConsultas As SEsupport.DsConsultas
    Friend WithEvents PrioridadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrioridadTableAdapter As SEsupport.DsConsultasTableAdapters.PrioridadTableAdapter
    Friend WithEvents ModuloBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ModuloTableAdapter As SEsupport.DsConsultasTableAdapters.ModuloTableAdapter
    Friend WithEvents TiporeqBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tipo_reqTableAdapter As SEsupport.DsConsultasTableAdapters.tipo_reqTableAdapter
    Friend WithEvents UsuarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuarioTableAdapter As SEsupport.DsConsultasTableAdapters.UsuarioTableAdapter
    Friend WithEvents VwhistincreqBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vw_hist_inc_reqTableAdapter As SEsupport.DsConsultasTableAdapters.vw_hist_inc_reqTableAdapter
    Friend WithEvents CmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents LblFiltro As System.Windows.Forms.Label
    Friend WithEvents EstadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstadoTableAdapter As SEsupport.DsConsultasTableAdapters.EstadoTableAdapter
    Friend WithEvents Idhist As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescusuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdmoduloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescmoduloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdprioridadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescprioridadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdestadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescestadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdtipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesctipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechageneracionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechasugeridaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaentregaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TecnicoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesctecnicoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalificacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacioncalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SolusuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoltecnicoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TecnicoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
