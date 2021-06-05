<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sincronizador
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvfacturas = New System.Windows.Forms.DataGridView()
        Me.nofactu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.exportado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtip = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnconsultar = New System.Windows.Forms.Button()
        Me.dtpfechafinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechainicial = New System.Windows.Forms.DateTimePicker()
        Me.Cmbterminal = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cmbpos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtdiferencia = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtventaserver = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtventapos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.POSAdministrativoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.volverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Usuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransmisorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnsincronizar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtnofacturas = New System.Windows.Forms.Label()
        CType(Me.dgvfacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(325, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Facturas sin Sincronizar"
        '
        'dgvfacturas
        '
        Me.dgvfacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvfacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nofactu, Me.fecha, Me.valor, Me.exportado})
        Me.dgvfacturas.Location = New System.Drawing.Point(12, 234)
        Me.dgvfacturas.Name = "dgvfacturas"
        Me.dgvfacturas.RowHeadersWidth = 51
        Me.dgvfacturas.Size = New System.Drawing.Size(717, 200)
        Me.dgvfacturas.TabIndex = 14
        '
        'nofactu
        '
        Me.nofactu.HeaderText = "Numero"
        Me.nofactu.MinimumWidth = 6
        Me.nofactu.Name = "nofactu"
        Me.nofactu.Width = 125
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.MinimumWidth = 6
        Me.fecha.Name = "fecha"
        Me.fecha.Width = 125
        '
        'valor
        '
        Me.valor.HeaderText = "Valor"
        Me.valor.MinimumWidth = 6
        Me.valor.Name = "valor"
        Me.valor.Width = 125
        '
        'exportado
        '
        Me.exportado.HeaderText = "Exportado"
        Me.exportado.MinimumWidth = 6
        Me.exportado.Name = "exportado"
        Me.exportado.Width = 125
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtip)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.btnconsultar)
        Me.Panel1.Controls.Add(Me.dtpfechafinal)
        Me.Panel1.Controls.Add(Me.dtpfechainicial)
        Me.Panel1.Controls.Add(Me.Cmbterminal)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Cmbpos)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(717, 92)
        Me.Panel1.TabIndex = 15
        '
        'txtip
        '
        Me.txtip.Enabled = False
        Me.txtip.Location = New System.Drawing.Point(479, 17)
        Me.txtip.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtip.Name = "txtip"
        Me.txtip.Size = New System.Drawing.Size(127, 20)
        Me.txtip.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(456, 18)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(17, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "IP"
        '
        'btnconsultar
        '
        Me.btnconsultar.Location = New System.Drawing.Point(625, 18)
        Me.btnconsultar.Name = "btnconsultar"
        Me.btnconsultar.Size = New System.Drawing.Size(75, 52)
        Me.btnconsultar.TabIndex = 17
        Me.btnconsultar.Text = "Consultar"
        Me.btnconsultar.UseVisualStyleBackColor = True
        '
        'dtpfechafinal
        '
        Me.dtpfechafinal.Location = New System.Drawing.Point(393, 51)
        Me.dtpfechafinal.Name = "dtpfechafinal"
        Me.dtpfechafinal.Size = New System.Drawing.Size(213, 20)
        Me.dtpfechafinal.TabIndex = 16
        '
        'dtpfechainicial
        '
        Me.dtpfechainicial.Location = New System.Drawing.Point(65, 51)
        Me.dtpfechainicial.Name = "dtpfechainicial"
        Me.dtpfechainicial.Size = New System.Drawing.Size(218, 20)
        Me.dtpfechainicial.TabIndex = 15
        '
        'Cmbterminal
        '
        Me.Cmbterminal.FormattingEnabled = True
        Me.Cmbterminal.Location = New System.Drawing.Point(368, 17)
        Me.Cmbterminal.Name = "Cmbterminal"
        Me.Cmbterminal.Size = New System.Drawing.Size(66, 21)
        Me.Cmbterminal.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(309, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Terminal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(312, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Fecha Final"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Fecha"
        '
        'Cmbpos
        '
        Me.Cmbpos.FormattingEnabled = True
        Me.Cmbpos.Location = New System.Drawing.Point(65, 15)
        Me.Cmbpos.Name = "Cmbpos"
        Me.Cmbpos.Size = New System.Drawing.Size(218, 21)
        Me.Cmbpos.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "POS"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txtdiferencia)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtventaserver)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtventapos)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(12, 130)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(717, 81)
        Me.Panel2.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(514, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "$"
        '
        'txtdiferencia
        '
        Me.txtdiferencia.Location = New System.Drawing.Point(533, 40)
        Me.txtdiferencia.Name = "txtdiferencia"
        Me.txtdiferencia.Size = New System.Drawing.Size(100, 20)
        Me.txtdiferencia.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(551, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Diferencia"
        '
        'txtventaserver
        '
        Me.txtventaserver.Location = New System.Drawing.Point(311, 40)
        Me.txtventaserver.Name = "txtventaserver"
        Me.txtventaserver.Size = New System.Drawing.Size(100, 20)
        Me.txtventaserver.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(292, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "$"
        '
        'txtventapos
        '
        Me.txtventapos.Location = New System.Drawing.Point(99, 42)
        Me.txtventapos.Name = "txtventapos"
        Me.txtventapos.Size = New System.Drawing.Size(100, 20)
        Me.txtventapos.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(80, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "$"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(312, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Ventas en Servidor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(110, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Ventas en POS"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministraciónToolStripMenuItem, Me.Usuario, Me.TransmisorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(742, 24)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministraciónToolStripMenuItem
        '
        Me.AdministraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.POSAdministrativoToolStripMenuItem, Me.volverToolStripMenuItem})
        Me.AdministraciónToolStripMenuItem.Name = "AdministraciónToolStripMenuItem"
        Me.AdministraciónToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.AdministraciónToolStripMenuItem.Text = "Administración"
        '
        'POSAdministrativoToolStripMenuItem
        '
        Me.POSAdministrativoToolStripMenuItem.Name = "POSAdministrativoToolStripMenuItem"
        Me.POSAdministrativoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.POSAdministrativoToolStripMenuItem.Text = "POS Administrativo"
        '
        'volverToolStripMenuItem
        '
        Me.volverToolStripMenuItem.Name = "volverToolStripMenuItem"
        Me.volverToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.volverToolStripMenuItem.Text = "Volver al Inicio"
        '
        'Usuario
        '
        Me.Usuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Usuario.MergeIndex = 0
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(59, 20)
        Me.Usuario.Text = "Usuario"
        '
        'TransmisorToolStripMenuItem
        '
        Me.TransmisorToolStripMenuItem.Name = "TransmisorToolStripMenuItem"
        Me.TransmisorToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.TransmisorToolStripMenuItem.Text = "Transmisor"
        '
        'btnsincronizar
        '
        Me.btnsincronizar.Location = New System.Drawing.Point(295, 448)
        Me.btnsincronizar.Name = "btnsincronizar"
        Me.btnsincronizar.Size = New System.Drawing.Size(194, 23)
        Me.btnsincronizar.TabIndex = 23
        Me.btnsincronizar.Text = "Sincronizar"
        Me.btnsincronizar.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 453)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Facturas sin sincronizar:"
        '
        'txtnofacturas
        '
        Me.txtnofacturas.AutoSize = True
        Me.txtnofacturas.Location = New System.Drawing.Point(133, 453)
        Me.txtnofacturas.Name = "txtnofacturas"
        Me.txtnofacturas.Size = New System.Drawing.Size(13, 13)
        Me.txtnofacturas.TabIndex = 25
        Me.txtnofacturas.Text = "0"
        '
        'Sincronizador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 483)
        Me.Controls.Add(Me.txtnofacturas)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnsincronizar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvfacturas)
        Me.Controls.Add(Me.Label8)
        Me.Name = "Sincronizador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sincronizador de Facturas"
        CType(Me.dgvfacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvfacturas As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Cmbpos As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtventaserver As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtventapos As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdiferencia As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Cmbterminal As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnconsultar As Button
    Friend WithEvents dtpfechafinal As DateTimePicker
    Friend WithEvents dtpfechainicial As DateTimePicker
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdministraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents volverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Usuario As ToolStripMenuItem
    Friend WithEvents nofactu As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents valor As DataGridViewTextBoxColumn
    Friend WithEvents exportado As DataGridViewTextBoxColumn
    Friend WithEvents btnsincronizar As Button
    Friend WithEvents POSAdministrativoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransmisorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label12 As Label
    Friend WithEvents txtnofacturas As Label
    Friend WithEvents txtip As TextBox
    Friend WithEvents Label13 As Label
End Class
