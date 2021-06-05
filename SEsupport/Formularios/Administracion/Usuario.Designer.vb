<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Me.CmbUsuario = New System.Windows.Forms.ComboBox()
        Me.LblUsuarios = New System.Windows.Forms.Label()
        Me.GBDatos = New System.Windows.Forms.GroupBox()
        Me.CmbComp = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxbMail = New System.Windows.Forms.TextBox()
        Me.LblMail = New System.Windows.Forms.Label()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.chkestado = New System.Windows.Forms.CheckBox()
        Me.TxbContraseña = New System.Windows.Forms.TextBox()
        Me.LblContraseña = New System.Windows.Forms.Label()
        Me.CmbNivel = New System.Windows.Forms.ComboBox()
        Me.LblNivel = New System.Windows.Forms.Label()
        Me.TxbNombre = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxbUsuario = New System.Windows.Forms.TextBox()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.Usuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.volverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GBDatos.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmbUsuario
        '
        Me.CmbUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbUsuario.FormattingEnabled = True
        Me.CmbUsuario.Location = New System.Drawing.Point(61, 39)
        Me.CmbUsuario.Name = "CmbUsuario"
        Me.CmbUsuario.Size = New System.Drawing.Size(313, 21)
        Me.CmbUsuario.TabIndex = 1
        '
        'LblUsuarios
        '
        Me.LblUsuarios.AutoSize = True
        Me.LblUsuarios.Location = New System.Drawing.Point(12, 42)
        Me.LblUsuarios.Name = "LblUsuarios"
        Me.LblUsuarios.Size = New System.Drawing.Size(43, 13)
        Me.LblUsuarios.TabIndex = 2
        Me.LblUsuarios.Text = "Usuario"
        '
        'GBDatos
        '
        Me.GBDatos.Controls.Add(Me.CmbComp)
        Me.GBDatos.Controls.Add(Me.Label1)
        Me.GBDatos.Controls.Add(Me.TxbMail)
        Me.GBDatos.Controls.Add(Me.LblMail)
        Me.GBDatos.Controls.Add(Me.btnnuevo)
        Me.GBDatos.Controls.Add(Me.chkestado)
        Me.GBDatos.Controls.Add(Me.TxbContraseña)
        Me.GBDatos.Controls.Add(Me.LblContraseña)
        Me.GBDatos.Controls.Add(Me.CmbNivel)
        Me.GBDatos.Controls.Add(Me.LblNivel)
        Me.GBDatos.Controls.Add(Me.TxbNombre)
        Me.GBDatos.Controls.Add(Me.LblNombre)
        Me.GBDatos.Controls.Add(Me.TxbUsuario)
        Me.GBDatos.Controls.Add(Me.LblUsuario)
        Me.GBDatos.Location = New System.Drawing.Point(16, 66)
        Me.GBDatos.Name = "GBDatos"
        Me.GBDatos.Size = New System.Drawing.Size(359, 194)
        Me.GBDatos.TabIndex = 3
        Me.GBDatos.TabStop = False
        Me.GBDatos.Text = "Datos"
        '
        'CmbComp
        '
        Me.CmbComp.FormattingEnabled = True
        Me.CmbComp.Items.AddRange(New Object() {"", "Factu01", "Factu02", "Factu54"})
        Me.CmbComp.Location = New System.Drawing.Point(93, 157)
        Me.CmbComp.Name = "CmbComp"
        Me.CmbComp.Size = New System.Drawing.Size(142, 21)
        Me.CmbComp.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Compañia"
        '
        'TxbMail
        '
        Me.TxbMail.Location = New System.Drawing.Point(93, 101)
        Me.TxbMail.Name = "TxbMail"
        Me.TxbMail.Size = New System.Drawing.Size(260, 20)
        Me.TxbMail.TabIndex = 11
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.Location = New System.Drawing.Point(11, 104)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(38, 13)
        Me.LblMail.TabIndex = 10
        Me.LblMail.Text = "Correo"
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(264, 21)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(76, 44)
        Me.btnnuevo.TabIndex = 9
        Me.btnnuevo.Text = "Activar nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'chkestado
        '
        Me.chkestado.AutoSize = True
        Me.chkestado.Location = New System.Drawing.Point(264, 130)
        Me.chkestado.Name = "chkestado"
        Me.chkestado.Size = New System.Drawing.Size(56, 17)
        Me.chkestado.TabIndex = 8
        Me.chkestado.Text = "Activo"
        Me.chkestado.UseVisualStyleBackColor = True
        '
        'TxbContraseña
        '
        Me.TxbContraseña.Location = New System.Drawing.Point(93, 49)
        Me.TxbContraseña.Name = "TxbContraseña"
        Me.TxbContraseña.Size = New System.Drawing.Size(142, 20)
        Me.TxbContraseña.TabIndex = 7
        '
        'LblContraseña
        '
        Me.LblContraseña.AutoSize = True
        Me.LblContraseña.Location = New System.Drawing.Point(11, 52)
        Me.LblContraseña.Name = "LblContraseña"
        Me.LblContraseña.Size = New System.Drawing.Size(61, 13)
        Me.LblContraseña.TabIndex = 6
        Me.LblContraseña.Text = "Contraseña"
        '
        'CmbNivel
        '
        Me.CmbNivel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbNivel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbNivel.FormattingEnabled = True
        Me.CmbNivel.Location = New System.Drawing.Point(93, 126)
        Me.CmbNivel.Name = "CmbNivel"
        Me.CmbNivel.Size = New System.Drawing.Size(142, 21)
        Me.CmbNivel.TabIndex = 5
        '
        'LblNivel
        '
        Me.LblNivel.AutoSize = True
        Me.LblNivel.Location = New System.Drawing.Point(11, 128)
        Me.LblNivel.Name = "LblNivel"
        Me.LblNivel.Size = New System.Drawing.Size(31, 13)
        Me.LblNivel.TabIndex = 4
        Me.LblNivel.Text = "Nivel"
        '
        'TxbNombre
        '
        Me.TxbNombre.Location = New System.Drawing.Point(93, 75)
        Me.TxbNombre.Name = "TxbNombre"
        Me.TxbNombre.Size = New System.Drawing.Size(260, 20)
        Me.TxbNombre.TabIndex = 3
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(11, 78)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 2
        Me.LblNombre.Text = "Nombre"
        '
        'TxbUsuario
        '
        Me.TxbUsuario.Enabled = False
        Me.TxbUsuario.Location = New System.Drawing.Point(93, 23)
        Me.TxbUsuario.Name = "TxbUsuario"
        Me.TxbUsuario.Size = New System.Drawing.Size(142, 20)
        Me.TxbUsuario.TabIndex = 1
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Location = New System.Drawing.Point(11, 26)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.LblUsuario.TabIndex = 0
        Me.LblUsuario.Text = "Usuario"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Location = New System.Drawing.Point(15, 266)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(89, 41)
        Me.BtnActualizar.TabIndex = 4
        Me.BtnActualizar.Text = "Guardar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Location = New System.Drawing.Point(279, 266)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(89, 41)
        Me.BtnLimpiar.TabIndex = 5
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
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
        Me.AdministraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PermisosToolStripMenuItem, Me.volverToolStripMenuItem})
        Me.AdministraciónToolStripMenuItem.Name = "AdministraciónToolStripMenuItem"
        Me.AdministraciónToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.AdministraciónToolStripMenuItem.Text = "Administración"
        '
        'PermisosToolStripMenuItem
        '
        Me.PermisosToolStripMenuItem.Name = "PermisosToolStripMenuItem"
        Me.PermisosToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PermisosToolStripMenuItem.Text = "Permisos"
        '
        'volverToolStripMenuItem
        '
        Me.volverToolStripMenuItem.Name = "volverToolStripMenuItem"
        Me.volverToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.volverToolStripMenuItem.Text = "Volver al Inicio"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministraciónToolStripMenuItem, Me.Usuario})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(387, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 318)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.GBDatos)
        Me.Controls.Add(Me.LblUsuarios)
        Me.Controls.Add(Me.CmbUsuario)
        Me.Name = "Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SEsupport - Usuarios"
        Me.GBDatos.ResumeLayout(False)
        Me.GBDatos.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IdUsuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContraseñaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescusuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NivelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CmbUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents LblUsuarios As System.Windows.Forms.Label
    Friend WithEvents GBDatos As System.Windows.Forms.GroupBox
    Friend WithEvents TxbNombre As System.Windows.Forms.TextBox
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents TxbUsuario As System.Windows.Forms.TextBox
    Friend WithEvents LblUsuario As System.Windows.Forms.Label
    Friend WithEvents CmbNivel As System.Windows.Forms.ComboBox
    Friend WithEvents LblNivel As System.Windows.Forms.Label
    Friend WithEvents chkestado As System.Windows.Forms.CheckBox
    Friend WithEvents TxbContraseña As System.Windows.Forms.TextBox
    Friend WithEvents LblContraseña As System.Windows.Forms.Label
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents TxbMail As System.Windows.Forms.TextBox
    Friend WithEvents LblMail As System.Windows.Forms.Label
    Friend WithEvents CmbComp As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Usuario As ToolStripMenuItem
    Friend WithEvents AdministraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PermisosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents volverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
