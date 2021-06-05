<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ciclo_aprobacion
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
        Me.DgvCicloAprobacion = New System.Windows.Forms.DataGridView()
        Me.LblJustificacion = New System.Windows.Forms.Label()
        Me.TxbAprobado = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.LblAprobación = New System.Windows.Forms.Label()
        Me.CmbTipoAprobacion = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxbDescripcion = New System.Windows.Forms.TextBox()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.TxbIdHist = New System.Windows.Forms.TextBox()
        Me.LblIdciclo = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CmbNuevoAprobador = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnNuevoAprobador = New System.Windows.Forms.Button()
        Me.TxbJustificacionCambio = New System.Windows.Forms.TextBox()
        Me.LblJustificacionCambio = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FiltrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SinAprobacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NumeroDeIncidenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoAprobadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoAlAlcanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DgvCicloAprobacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvCicloAprobacion
        '
        Me.DgvCicloAprobacion.AllowUserToAddRows = False
        Me.DgvCicloAprobacion.AllowUserToDeleteRows = False
        Me.DgvCicloAprobacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCicloAprobacion.Location = New System.Drawing.Point(12, 27)
        Me.DgvCicloAprobacion.Name = "DgvCicloAprobacion"
        Me.DgvCicloAprobacion.ReadOnly = True
        Me.DgvCicloAprobacion.Size = New System.Drawing.Size(760, 173)
        Me.DgvCicloAprobacion.TabIndex = 0
        '
        'LblJustificacion
        '
        Me.LblJustificacion.AutoSize = True
        Me.LblJustificacion.Location = New System.Drawing.Point(6, 113)
        Me.LblJustificacion.Name = "LblJustificacion"
        Me.LblJustificacion.Size = New System.Drawing.Size(65, 13)
        Me.LblJustificacion.TabIndex = 3
        Me.LblJustificacion.Text = "Justificación"
        '
        'TxbAprobado
        '
        Me.TxbAprobado.Location = New System.Drawing.Point(77, 101)
        Me.TxbAprobado.Multiline = True
        Me.TxbAprobado.Name = "TxbAprobado"
        Me.TxbAprobado.Size = New System.Drawing.Size(667, 40)
        Me.TxbAprobado.TabIndex = 2
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(10, 150)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(115, 36)
        Me.BtnGuardar.TabIndex = 4
        Me.BtnGuardar.Text = "GUARDAR"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(542, 150)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(115, 36)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.Text = "CANCELAR"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'LblAprobación
        '
        Me.LblAprobación.AutoSize = True
        Me.LblAprobación.Location = New System.Drawing.Point(7, 65)
        Me.LblAprobación.Name = "LblAprobación"
        Me.LblAprobación.Size = New System.Drawing.Size(61, 13)
        Me.LblAprobación.TabIndex = 6
        Me.LblAprobación.Text = "Aprobación"
        '
        'CmbTipoAprobacion
        '
        Me.CmbTipoAprobacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbTipoAprobacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbTipoAprobacion.FormattingEnabled = True
        Me.CmbTipoAprobacion.Items.AddRange(New Object() {"SI", "NO"})
        Me.CmbTipoAprobacion.Location = New System.Drawing.Point(74, 65)
        Me.CmbTipoAprobacion.Name = "CmbTipoAprobacion"
        Me.CmbTipoAprobacion.Size = New System.Drawing.Size(138, 21)
        Me.CmbTipoAprobacion.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxbDescripcion)
        Me.GroupBox1.Controls.Add(Me.LblDescripcion)
        Me.GroupBox1.Controls.Add(Me.TxbIdHist)
        Me.GroupBox1.Controls.Add(Me.LblIdciclo)
        Me.GroupBox1.Controls.Add(Me.CmbTipoAprobacion)
        Me.GroupBox1.Controls.Add(Me.LblAprobación)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Controls.Add(Me.TxbAprobado)
        Me.GroupBox1.Controls.Add(Me.LblJustificacion)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 206)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(760, 192)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Aprobación"
        '
        'TxbDescripcion
        '
        Me.TxbDescripcion.BackColor = System.Drawing.SystemColors.Menu
        Me.TxbDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbDescripcion.Location = New System.Drawing.Point(242, 18)
        Me.TxbDescripcion.Multiline = True
        Me.TxbDescripcion.Name = "TxbDescripcion"
        Me.TxbDescripcion.ReadOnly = True
        Me.TxbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxbDescripcion.Size = New System.Drawing.Size(502, 68)
        Me.TxbDescripcion.TabIndex = 10
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.Location = New System.Drawing.Point(173, 21)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.LblDescripcion.TabIndex = 11
        Me.LblDescripcion.Text = "Descripcion"
        '
        'TxbIdHist
        '
        Me.TxbIdHist.BackColor = System.Drawing.SystemColors.Menu
        Me.TxbIdHist.Enabled = False
        Me.TxbIdHist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbIdHist.ForeColor = System.Drawing.Color.Red
        Me.TxbIdHist.Location = New System.Drawing.Point(74, 18)
        Me.TxbIdHist.Name = "TxbIdHist"
        Me.TxbIdHist.Size = New System.Drawing.Size(71, 23)
        Me.TxbIdHist.TabIndex = 9
        '
        'LblIdciclo
        '
        Me.LblIdciclo.AutoSize = True
        Me.LblIdciclo.Location = New System.Drawing.Point(6, 21)
        Me.LblIdciclo.Name = "LblIdciclo"
        Me.LblIdciclo.Size = New System.Drawing.Size(53, 13)
        Me.LblIdciclo.TabIndex = 8
        Me.LblIdciclo.Text = "Num. Inc."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmbNuevoAprobador)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.BtnNuevoAprobador)
        Me.GroupBox2.Controls.Add(Me.TxbJustificacionCambio)
        Me.GroupBox2.Controls.Add(Me.LblJustificacionCambio)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 404)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(760, 146)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cambio Aprobador"
        '
        'CmbNuevoAprobador
        '
        Me.CmbNuevoAprobador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbNuevoAprobador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbNuevoAprobador.FormattingEnabled = True
        Me.CmbNuevoAprobador.Location = New System.Drawing.Point(77, 20)
        Me.CmbNuevoAprobador.Name = "CmbNuevoAprobador"
        Me.CmbNuevoAprobador.Size = New System.Drawing.Size(344, 21)
        Me.CmbNuevoAprobador.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Usuario"
        '
        'BtnNuevoAprobador
        '
        Me.BtnNuevoAprobador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevoAprobador.Location = New System.Drawing.Point(10, 101)
        Me.BtnNuevoAprobador.Name = "BtnNuevoAprobador"
        Me.BtnNuevoAprobador.Size = New System.Drawing.Size(115, 36)
        Me.BtnNuevoAprobador.TabIndex = 4
        Me.BtnNuevoAprobador.Text = "CAMBIAR"
        Me.BtnNuevoAprobador.UseVisualStyleBackColor = True
        '
        'TxbJustificacionCambio
        '
        Me.TxbJustificacionCambio.Location = New System.Drawing.Point(77, 55)
        Me.TxbJustificacionCambio.Multiline = True
        Me.TxbJustificacionCambio.Name = "TxbJustificacionCambio"
        Me.TxbJustificacionCambio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxbJustificacionCambio.Size = New System.Drawing.Size(667, 40)
        Me.TxbJustificacionCambio.TabIndex = 2
        '
        'LblJustificacionCambio
        '
        Me.LblJustificacionCambio.AutoSize = True
        Me.LblJustificacionCambio.Location = New System.Drawing.Point(6, 58)
        Me.LblJustificacionCambio.Name = "LblJustificacionCambio"
        Me.LblJustificacionCambio.Size = New System.Drawing.Size(65, 13)
        Me.LblJustificacionCambio.TabIndex = 3
        Me.LblJustificacionCambio.Text = "Justificación"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FiltrosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FiltrosToolStripMenuItem
        '
        Me.FiltrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SinAprobacionToolStripMenuItem, Me.NumeroDeIncidenteToolStripMenuItem, Me.NoAprobadoToolStripMenuItem, Me.NoAlAlcanceToolStripMenuItem})
        Me.FiltrosToolStripMenuItem.Name = "FiltrosToolStripMenuItem"
        Me.FiltrosToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.FiltrosToolStripMenuItem.Text = "Filtros"
        '
        'SinAprobacionToolStripMenuItem
        '
        Me.SinAprobacionToolStripMenuItem.Name = "SinAprobacionToolStripMenuItem"
        Me.SinAprobacionToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.SinAprobacionToolStripMenuItem.Text = "Sin Aprobacion"
        '
        'NumeroDeIncidenteToolStripMenuItem
        '
        Me.NumeroDeIncidenteToolStripMenuItem.Name = "NumeroDeIncidenteToolStripMenuItem"
        Me.NumeroDeIncidenteToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.NumeroDeIncidenteToolStripMenuItem.Text = "Aprobado"
        '
        'NoAprobadoToolStripMenuItem
        '
        Me.NoAprobadoToolStripMenuItem.Name = "NoAprobadoToolStripMenuItem"
        Me.NoAprobadoToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.NoAprobadoToolStripMenuItem.Text = "No Aprobado"
        '
        'NoAlAlcanceToolStripMenuItem
        '
        Me.NoAlAlcanceToolStripMenuItem.Name = "NoAlAlcanceToolStripMenuItem"
        Me.NoAlAlcanceToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.NoAlAlcanceToolStripMenuItem.Text = "No Al Alcance"
        '
        'ciclo_aprobacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgvCicloAprobacion)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ciclo_aprobacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SeAprobacion"
        CType(Me.DgvCicloAprobacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvCicloAprobacion As System.Windows.Forms.DataGridView
    Friend WithEvents LblJustificacion As System.Windows.Forms.Label
    Friend WithEvents TxbAprobado As System.Windows.Forms.TextBox
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents LblAprobación As System.Windows.Forms.Label
    Friend WithEvents CmbTipoAprobacion As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbNuevoAprobador As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnNuevoAprobador As System.Windows.Forms.Button
    Friend WithEvents TxbJustificacionCambio As System.Windows.Forms.TextBox
    Friend WithEvents LblJustificacionCambio As System.Windows.Forms.Label
    Friend WithEvents TxbIdHist As System.Windows.Forms.TextBox
    Friend WithEvents LblIdciclo As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FiltrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NumeroDeIncidenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SinAprobacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoAprobadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoAlAlcanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TxbDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents LblDescripcion As System.Windows.Forms.Label
End Class
