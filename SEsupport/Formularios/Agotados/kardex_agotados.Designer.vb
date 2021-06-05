<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kardex_agotados
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
        Me.GbBuscar = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxbBuscar = New System.Windows.Forms.TextBox()
        Me.RbNombre = New System.Windows.Forms.RadioButton()
        Me.RbCodigo = New System.Windows.Forms.RadioButton()
        Me.GbKardex = New System.Windows.Forms.GroupBox()
        Me.DgvKardex = New System.Windows.Forms.DataGridView()
        Me.seleccionar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GbBuscar.SuspendLayout()
        Me.GbKardex.SuspendLayout()
        CType(Me.DgvKardex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbBuscar
        '
        Me.GbBuscar.Controls.Add(Me.BtnBuscar)
        Me.GbBuscar.Controls.Add(Me.TxbBuscar)
        Me.GbBuscar.Controls.Add(Me.RbNombre)
        Me.GbBuscar.Controls.Add(Me.RbCodigo)
        Me.GbBuscar.Location = New System.Drawing.Point(12, 12)
        Me.GbBuscar.Name = "GbBuscar"
        Me.GbBuscar.Size = New System.Drawing.Size(438, 119)
        Me.GbBuscar.TabIndex = 5
        Me.GbBuscar.TabStop = False
        Me.GbBuscar.Text = "BUSCAR POR"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(157, 82)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(121, 31)
        Me.BtnBuscar.TabIndex = 3
        Me.BtnBuscar.Text = "BUSCAR"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxbBuscar
        '
        Me.TxbBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbBuscar.Location = New System.Drawing.Point(7, 53)
        Me.TxbBuscar.Name = "TxbBuscar"
        Me.TxbBuscar.Size = New System.Drawing.Size(423, 23)
        Me.TxbBuscar.TabIndex = 2
        '
        'RbNombre
        '
        Me.RbNombre.AutoSize = True
        Me.RbNombre.Checked = True
        Me.RbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNombre.Location = New System.Drawing.Point(281, 20)
        Me.RbNombre.Name = "RbNombre"
        Me.RbNombre.Size = New System.Drawing.Size(149, 21)
        Me.RbNombre.TabIndex = 1
        Me.RbNombre.TabStop = True
        Me.RbNombre.Text = "Nombre Referencia"
        Me.RbNombre.UseVisualStyleBackColor = True
        '
        'RbCodigo
        '
        Me.RbCodigo.AutoSize = True
        Me.RbCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbCodigo.Location = New System.Drawing.Point(7, 20)
        Me.RbCodigo.Name = "RbCodigo"
        Me.RbCodigo.Size = New System.Drawing.Size(143, 21)
        Me.RbCodigo.TabIndex = 0
        Me.RbCodigo.Text = "Código Referencia"
        Me.RbCodigo.UseVisualStyleBackColor = True
        '
        'GbKardex
        '
        Me.GbKardex.Controls.Add(Me.DgvKardex)
        Me.GbKardex.Location = New System.Drawing.Point(12, 137)
        Me.GbKardex.Name = "GbKardex"
        Me.GbKardex.Size = New System.Drawing.Size(441, 177)
        Me.GbKardex.TabIndex = 4
        Me.GbKardex.TabStop = False
        Me.GbKardex.Text = "KARDEX"
        '
        'DgvKardex
        '
        Me.DgvKardex.AllowUserToAddRows = False
        Me.DgvKardex.AllowUserToDeleteRows = False
        Me.DgvKardex.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvKardex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvKardex.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.seleccionar})
        Me.DgvKardex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvKardex.Location = New System.Drawing.Point(3, 16)
        Me.DgvKardex.Name = "DgvKardex"
        Me.DgvKardex.ReadOnly = True
        Me.DgvKardex.Size = New System.Drawing.Size(435, 158)
        Me.DgvKardex.TabIndex = 0
        '
        'seleccionar
        '
        Me.seleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.seleccionar.Frozen = True
        Me.seleccionar.HeaderText = "Sel."
        Me.seleccionar.Name = "seleccionar"
        Me.seleccionar.ReadOnly = True
        Me.seleccionar.Width = 31
        '
        'kardex_agotados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 325)
        Me.Controls.Add(Me.GbBuscar)
        Me.Controls.Add(Me.GbKardex)
        Me.Name = "kardex_agotados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "kardex_agotados"
        Me.TopMost = True
        Me.GbBuscar.ResumeLayout(False)
        Me.GbBuscar.PerformLayout()
        Me.GbKardex.ResumeLayout(False)
        CType(Me.DgvKardex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GbBuscar As System.Windows.Forms.GroupBox
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents TxbBuscar As System.Windows.Forms.TextBox
    Friend WithEvents RbNombre As System.Windows.Forms.RadioButton
    Friend WithEvents RbCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents GbKardex As System.Windows.Forms.GroupBox
    Friend WithEvents DgvKardex As System.Windows.Forms.DataGridView
    Friend WithEvents seleccionar As System.Windows.Forms.DataGridViewButtonColumn
End Class
