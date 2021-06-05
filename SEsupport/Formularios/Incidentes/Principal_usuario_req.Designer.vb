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
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Usuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbIncyReq = New System.Windows.Forms.GroupBox()
        Me.BtnAdjuntar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxbDescripcion = New System.Windows.Forms.TextBox()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.Cmbtipo = New System.Windows.Forms.ComboBox()
        Me.LblTipoReq = New System.Windows.Forms.Label()
        Me.CmbUsuario = New System.Windows.Forms.ComboBox()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.CmbModulo = New System.Windows.Forms.ComboBox()
        Me.LblModulo = New System.Windows.Forms.Label()
        Me.CmbPrioridad = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DgvPendientes = New System.Windows.Forms.DataGridView()
        Me.Idhist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BbPendientes = New System.Windows.Forms.GroupBox()
        Me.CmbEstado = New System.Windows.Forms.ComboBox()
        Me.LblFiltro = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GbIncyReq.SuspendLayout()
        CType(Me.DgvPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BbPendientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 863)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1045, 26)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(108, 20)
        Me.ToolStripStatusLabel1.Text = "Usuario Activo:"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'AdministracoinToolStripMenuItem
        '
        Me.AdministracoinToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuejasYNoConformidadesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.AdministracoinToolStripMenuItem.Name = "AdministracoinToolStripMenuItem"
        Me.AdministracoinToolStripMenuItem.Size = New System.Drawing.Size(81, 27)
        Me.AdministracoinToolStripMenuItem.Text = "Archivo"
        '
        'QuejasYNoConformidadesToolStripMenuItem
        '
        Me.QuejasYNoConformidadesToolStripMenuItem.Name = "QuejasYNoConformidadesToolStripMenuItem"
        Me.QuejasYNoConformidadesToolStripMenuItem.Size = New System.Drawing.Size(204, 28)
        Me.QuejasYNoConformidadesToolStripMenuItem.Text = "Volver al inicio"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(204, 28)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(91, 27)
        Me.InformesToolStripMenuItem.Text = "Informes"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministracoinToolStripMenuItem, Me.AdministraciónToolStripMenuItem, Me.InformesToolStripMenuItem, Me.Usuario})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1045, 31)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministraciónToolStripMenuItem
        '
        Me.AdministraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TecnicoToolStripMenuItem, Me.AToolStripMenuItem})
        Me.AdministraciónToolStripMenuItem.Name = "AdministraciónToolStripMenuItem"
        Me.AdministraciónToolStripMenuItem.Size = New System.Drawing.Size(138, 27)
        Me.AdministraciónToolStripMenuItem.Text = "Administración"
        '
        'TecnicoToolStripMenuItem
        '
        Me.TecnicoToolStripMenuItem.Name = "TecnicoToolStripMenuItem"
        Me.TecnicoToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
        Me.TecnicoToolStripMenuItem.Text = "Tecnico"
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
        Me.AToolStripMenuItem.Text = "Aprobación"
        '
        'Usuario
        '
        Me.Usuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Usuario.MergeIndex = 0
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(82, 27)
        Me.Usuario.Text = "Usuario"
        '
        'GbIncyReq
        '
        Me.GbIncyReq.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GbIncyReq.Controls.Add(Me.BtnAdjuntar)
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
        Me.GbIncyReq.Location = New System.Drawing.Point(16, 41)
        Me.GbIncyReq.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GbIncyReq.Name = "GbIncyReq"
        Me.GbIncyReq.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GbIncyReq.Size = New System.Drawing.Size(1009, 345)
        Me.GbIncyReq.TabIndex = 6
        Me.GbIncyReq.TabStop = False
        Me.GbIncyReq.Text = "Incidentes y Requerimientos"
        '
        'BtnAdjuntar
        '
        Me.BtnAdjuntar.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdjuntar.Location = New System.Drawing.Point(472, 278)
        Me.BtnAdjuntar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnAdjuntar.Name = "BtnAdjuntar"
        Me.BtnAdjuntar.Size = New System.Drawing.Size(125, 44)
        Me.BtnAdjuntar.TabIndex = 22
        Me.BtnAdjuntar.Text = "Adjuntar"
        Me.BtnAdjuntar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(840, 278)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(125, 44)
        Me.BtnCancelar.TabIndex = 21
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(81, 278)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(125, 44)
        Me.BtnGuardar.TabIndex = 20
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'TxbDescripcion
        '
        Me.TxbDescripcion.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbDescripcion.Location = New System.Drawing.Point(124, 158)
        Me.TxbDescripcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxbDescripcion.Multiline = True
        Me.TxbDescripcion.Name = "TxbDescripcion"
        Me.TxbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxbDescripcion.Size = New System.Drawing.Size(840, 112)
        Me.TxbDescripcion.TabIndex = 19
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.Location = New System.Drawing.Point(8, 199)
        Me.LblDescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(110, 21)
        Me.LblDescripcion.TabIndex = 18
        Me.LblDescripcion.Text = "Descripción"
        '
        'Cmbtipo
        '
        Me.Cmbtipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Cmbtipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cmbtipo.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbtipo.FormattingEnabled = True
        Me.Cmbtipo.Location = New System.Drawing.Point(615, 36)
        Me.Cmbtipo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cmbtipo.Name = "Cmbtipo"
        Me.Cmbtipo.Size = New System.Drawing.Size(241, 28)
        Me.Cmbtipo.TabIndex = 17
        '
        'LblTipoReq
        '
        Me.LblTipoReq.AutoSize = True
        Me.LblTipoReq.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipoReq.Location = New System.Drawing.Point(412, 39)
        Me.LblTipoReq.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTipoReq.Name = "LblTipoReq"
        Me.LblTipoReq.Size = New System.Drawing.Size(176, 21)
        Me.LblTipoReq.TabIndex = 16
        Me.LblTipoReq.Text = "Tipo Requerimiento"
        '
        'CmbUsuario
        '
        Me.CmbUsuario.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbUsuario.FormattingEnabled = True
        Me.CmbUsuario.Location = New System.Drawing.Point(497, 85)
        Me.CmbUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbUsuario.Name = "CmbUsuario"
        Me.CmbUsuario.Size = New System.Drawing.Size(359, 28)
        Me.CmbUsuario.TabIndex = 15
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.Location = New System.Drawing.Point(409, 89)
        Me.LblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(76, 21)
        Me.LblUsuario.TabIndex = 14
        Me.LblUsuario.Text = "Usuario"
        '
        'CmbModulo
        '
        Me.CmbModulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbModulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbModulo.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbModulo.FormattingEnabled = True
        Me.CmbModulo.Location = New System.Drawing.Point(124, 85)
        Me.CmbModulo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbModulo.Name = "CmbModulo"
        Me.CmbModulo.Size = New System.Drawing.Size(237, 28)
        Me.CmbModulo.TabIndex = 13
        '
        'LblModulo
        '
        Me.LblModulo.AutoSize = True
        Me.LblModulo.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblModulo.Location = New System.Drawing.Point(8, 89)
        Me.LblModulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblModulo.Name = "LblModulo"
        Me.LblModulo.Size = New System.Drawing.Size(74, 21)
        Me.LblModulo.TabIndex = 12
        Me.LblModulo.Text = "Modulo"
        '
        'CmbPrioridad
        '
        Me.CmbPrioridad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbPrioridad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbPrioridad.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPrioridad.FormattingEnabled = True
        Me.CmbPrioridad.Location = New System.Drawing.Point(124, 42)
        Me.CmbPrioridad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbPrioridad.Name = "CmbPrioridad"
        Me.CmbPrioridad.Size = New System.Drawing.Size(237, 28)
        Me.CmbPrioridad.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 21)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Prioridad"
        '
        'DgvPendientes
        '
        Me.DgvPendientes.AllowUserToAddRows = False
        Me.DgvPendientes.AllowUserToDeleteRows = False
        Me.DgvPendientes.AllowUserToOrderColumns = True
        Me.DgvPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPendientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Idhist})
        Me.DgvPendientes.Location = New System.Drawing.Point(0, 103)
        Me.DgvPendientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DgvPendientes.MultiSelect = False
        Me.DgvPendientes.Name = "DgvPendientes"
        Me.DgvPendientes.ReadOnly = True
        Me.DgvPendientes.RowHeadersWidth = 51
        Me.DgvPendientes.Size = New System.Drawing.Size(1013, 319)
        Me.DgvPendientes.TabIndex = 8
        '
        'Idhist
        '
        Me.Idhist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Idhist.DataPropertyName = "Idhist"
        Me.Idhist.Frozen = True
        Me.Idhist.HeaderText = "Número"
        Me.Idhist.MinimumWidth = 6
        Me.Idhist.Name = "Idhist"
        Me.Idhist.ReadOnly = True
        Me.Idhist.Width = 107
        '
        'BbPendientes
        '
        Me.BbPendientes.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BbPendientes.Controls.Add(Me.CmbEstado)
        Me.BbPendientes.Controls.Add(Me.LblFiltro)
        Me.BbPendientes.Controls.Add(Me.DgvPendientes)
        Me.BbPendientes.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BbPendientes.Location = New System.Drawing.Point(16, 428)
        Me.BbPendientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BbPendientes.Name = "BbPendientes"
        Me.BbPendientes.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BbPendientes.Size = New System.Drawing.Size(1013, 430)
        Me.BbPendientes.TabIndex = 9
        Me.BbPendientes.TabStop = False
        Me.BbPendientes.Text = "Pendientes"
        '
        'CmbEstado
        '
        Me.CmbEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbEstado.DisplayMember = "IdEstado"
        Me.CmbEstado.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEstado.FormattingEnabled = True
        Me.CmbEstado.Location = New System.Drawing.Point(124, 39)
        Me.CmbEstado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbEstado.Name = "CmbEstado"
        Me.CmbEstado.Size = New System.Drawing.Size(201, 28)
        Me.CmbEstado.TabIndex = 12
        Me.CmbEstado.ValueMember = "IdEstado"
        '
        'LblFiltro
        '
        Me.LblFiltro.AutoSize = True
        Me.LblFiltro.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFiltro.Location = New System.Drawing.Point(8, 43)
        Me.LblFiltro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblFiltro.Name = "LblFiltro"
        Me.LblFiltro.Size = New System.Drawing.Size(54, 21)
        Me.LblFiltro.TabIndex = 19
        Me.LblFiltro.Text = "Filtro"
        '
        'Principal_usuario_req
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1045, 889)
        Me.Controls.Add(Me.BbPendientes)
        Me.Controls.Add(Me.GbIncyReq)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        CType(Me.DgvPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BbPendientes.ResumeLayout(False)
        Me.BbPendientes.PerformLayout()
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
    Friend WithEvents CmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents LblFiltro As System.Windows.Forms.Label
    Friend WithEvents Idhist As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TecnicoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnAdjuntar As System.Windows.Forms.Button
    Friend WithEvents AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Usuario As ToolStripMenuItem
End Class
