<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingreso_inventarios
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
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.DgvInventarios = New System.Windows.Forms.DataGridView()
        Me.CmbTipoInventario = New System.Windows.Forms.ComboBox()
        Me.LblTipoInventario = New System.Windows.Forms.Label()
        Me.LblBodega = New System.Windows.Forms.Label()
        Me.CmbBodega = New System.Windows.Forms.ComboBox()
        Me.GboxIngInv = New System.Windows.Forms.GroupBox()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarAjusteDeInventarioDiarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarAjusteDeInventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuejasYNoConformidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarInventarioAMensualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GboxBuscarRef = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxbBuscar = New System.Windows.Forms.TextBox()
        Me.CambiarInventarioADiarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarInventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Usuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.DgvInventarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GboxIngInv.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GboxBuscarRef.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DtpFecha
        '
        Me.DtpFecha.Location = New System.Drawing.Point(59, 26)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.DtpFecha.TabIndex = 0
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
        'DgvInventarios
        '
        Me.DgvInventarios.AllowUserToAddRows = False
        Me.DgvInventarios.AllowUserToDeleteRows = False
        Me.DgvInventarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvInventarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvInventarios.Location = New System.Drawing.Point(16, 125)
        Me.DgvInventarios.Name = "DgvInventarios"
        Me.DgvInventarios.Size = New System.Drawing.Size(768, 436)
        Me.DgvInventarios.TabIndex = 2
        '
        'CmbTipoInventario
        '
        Me.CmbTipoInventario.FormattingEnabled = True
        Me.CmbTipoInventario.Items.AddRange(New Object() {"Inventario Diario", "Inventario Fin de Mes"})
        Me.CmbTipoInventario.Location = New System.Drawing.Point(349, 29)
        Me.CmbTipoInventario.Name = "CmbTipoInventario"
        Me.CmbTipoInventario.Size = New System.Drawing.Size(147, 21)
        Me.CmbTipoInventario.TabIndex = 3
        '
        'LblTipoInventario
        '
        Me.LblTipoInventario.AutoSize = True
        Me.LblTipoInventario.Location = New System.Drawing.Point(265, 32)
        Me.LblTipoInventario.Name = "LblTipoInventario"
        Me.LblTipoInventario.Size = New System.Drawing.Size(78, 13)
        Me.LblTipoInventario.TabIndex = 4
        Me.LblTipoInventario.Text = "Tipo Inventario"
        '
        'LblBodega
        '
        Me.LblBodega.AutoSize = True
        Me.LblBodega.Location = New System.Drawing.Point(6, 58)
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
        Me.CmbBodega.Location = New System.Drawing.Point(56, 55)
        Me.CmbBodega.Name = "CmbBodega"
        Me.CmbBodega.Size = New System.Drawing.Size(440, 21)
        Me.CmbBodega.TabIndex = 5
        '
        'GboxIngInv
        '
        Me.GboxIngInv.Controls.Add(Me.BtnConsultar)
        Me.GboxIngInv.Controls.Add(Me.LblTipoInventario)
        Me.GboxIngInv.Controls.Add(Me.LblFecha)
        Me.GboxIngInv.Controls.Add(Me.CmbTipoInventario)
        Me.GboxIngInv.Controls.Add(Me.DtpFecha)
        Me.GboxIngInv.Controls.Add(Me.LblBodega)
        Me.GboxIngInv.Controls.Add(Me.CmbBodega)
        Me.GboxIngInv.Location = New System.Drawing.Point(16, 27)
        Me.GboxIngInv.Name = "GboxIngInv"
        Me.GboxIngInv.Size = New System.Drawing.Size(632, 92)
        Me.GboxIngInv.TabIndex = 7
        Me.GboxIngInv.TabStop = False
        Me.GboxIngInv.Text = "Ingresar Inventario"
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.Location = New System.Drawing.Point(504, 37)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(116, 33)
        Me.BtnConsultar.TabIndex = 7
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ImprimirToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.Usuario})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(792, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarAjusteDeInventarioDiarioToolStripMenuItem, Me.GenerarAjusteDeInventarioToolStripMenuItem, Me.QuejasYNoConformidadesToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(60, 20)
        Me.ToolStripMenuItem1.Text = "Archivo"
        '
        'GenerarAjusteDeInventarioDiarioToolStripMenuItem
        '
        Me.GenerarAjusteDeInventarioDiarioToolStripMenuItem.Name = "GenerarAjusteDeInventarioDiarioToolStripMenuItem"
        Me.GenerarAjusteDeInventarioDiarioToolStripMenuItem.Size = New System.Drawing.Size(283, 22)
        Me.GenerarAjusteDeInventarioDiarioToolStripMenuItem.Text = "Generar Ajuste de Inventario Diario"
        '
        'GenerarAjusteDeInventarioToolStripMenuItem
        '
        Me.GenerarAjusteDeInventarioToolStripMenuItem.Name = "GenerarAjusteDeInventarioToolStripMenuItem"
        Me.GenerarAjusteDeInventarioToolStripMenuItem.Size = New System.Drawing.Size(283, 22)
        Me.GenerarAjusteDeInventarioToolStripMenuItem.Text = "Generar Ajuste de Inventario Fin de Mes"
        '
        'QuejasYNoConformidadesToolStripMenuItem
        '
        Me.QuejasYNoConformidadesToolStripMenuItem.Name = "QuejasYNoConformidadesToolStripMenuItem"
        Me.QuejasYNoConformidadesToolStripMenuItem.Size = New System.Drawing.Size(283, 22)
        Me.QuejasYNoConformidadesToolStripMenuItem.Text = "Volver al Inicio"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarInventarioAMensualToolStripMenuItem, Me.CambiarInventarioADiarioToolStripMenuItem, Me.EliminarInventarioToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'CambiarInventarioAMensualToolStripMenuItem
        '
        Me.CambiarInventarioAMensualToolStripMenuItem.Name = "CambiarInventarioAMensualToolStripMenuItem"
        Me.CambiarInventarioAMensualToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.CambiarInventarioAMensualToolStripMenuItem.Text = "Cambiar inventario a Mensual"
        '
        'GboxBuscarRef
        '
        Me.GboxBuscarRef.Controls.Add(Me.BtnBuscar)
        Me.GboxBuscarRef.Controls.Add(Me.TxbBuscar)
        Me.GboxBuscarRef.Location = New System.Drawing.Point(649, 27)
        Me.GboxBuscarRef.Name = "GboxBuscarRef"
        Me.GboxBuscarRef.Size = New System.Drawing.Size(135, 92)
        Me.GboxBuscarRef.TabIndex = 10
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
        'CambiarInventarioADiarioToolStripMenuItem
        '
        Me.CambiarInventarioADiarioToolStripMenuItem.Name = "CambiarInventarioADiarioToolStripMenuItem"
        Me.CambiarInventarioADiarioToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.CambiarInventarioADiarioToolStripMenuItem.Text = "Cambiar inventario a Diario"
        '
        'EliminarInventarioToolStripMenuItem
        '
        Me.EliminarInventarioToolStripMenuItem.Name = "EliminarInventarioToolStripMenuItem"
        Me.EliminarInventarioToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.EliminarInventarioToolStripMenuItem.Text = "Eliminar inventario"
        '
        'Usuario
        '
        Me.Usuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Usuario.MergeIndex = 0
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(59, 20)
        Me.Usuario.Text = "Usuario"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 562)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(792, 22)
        Me.StatusStrip1.TabIndex = 26
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
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(20, 17)
        Me.ToolStripStatusLabel6.Text = "||"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(133, 17)
        Me.ToolStripStatusLabel7.Text = "ToolStripStatusLabel7"
        '
        'Ingreso_inventarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 584)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GboxBuscarRef)
        Me.Controls.Add(Me.GboxIngInv)
        Me.Controls.Add(Me.DgvInventarios)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Ingreso_inventarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso Inventarios"
        CType(Me.DgvInventarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GboxIngInv.ResumeLayout(False)
        Me.GboxIngInv.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GboxBuscarRef.ResumeLayout(False)
        Me.GboxBuscarRef.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Friend WithEvents DgvInventarios As System.Windows.Forms.DataGridView
    Friend WithEvents CmbTipoInventario As System.Windows.Forms.ComboBox
    Friend WithEvents LblTipoInventario As System.Windows.Forms.Label
    Friend WithEvents LblBodega As System.Windows.Forms.Label
    Friend WithEvents CmbBodega As System.Windows.Forms.ComboBox
    Friend WithEvents GboxIngInv As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuejasYNoConformidadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnConsultar As System.Windows.Forms.Button
    Friend WithEvents GboxBuscarRef As System.Windows.Forms.GroupBox
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents TxbBuscar As System.Windows.Forms.TextBox
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarAjusteDeInventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarAjusteDeInventarioDiarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarInventarioAMensualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarInventarioADiarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarInventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Usuario As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As ToolStripStatusLabel
End Class
