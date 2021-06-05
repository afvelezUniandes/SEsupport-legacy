<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adjuntar
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.DgvArchivos = New System.Windows.Forms.DataGridView()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Archivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ruta_completa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvArchivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(61, 195)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(101, 41)
        Me.BtnAgregar.TabIndex = 0
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(225, 195)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(96, 41)
        Me.BtnEliminar.TabIndex = 1
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'DgvArchivos
        '
        Me.DgvArchivos.AllowUserToAddRows = False
        Me.DgvArchivos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvArchivos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvArchivos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Check, Me.Archivo, Me.ruta_completa})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvArchivos.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvArchivos.Location = New System.Drawing.Point(12, 12)
        Me.DgvArchivos.Name = "DgvArchivos"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvArchivos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvArchivos.Size = New System.Drawing.Size(411, 150)
        Me.DgvArchivos.TabIndex = 2
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(13, 166)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(410, 23)
        Me.ProgressBar1.TabIndex = 3
        '
        'Check
        '
        Me.Check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Check.HeaderText = ""
        Me.Check.Name = "Check"
        Me.Check.Width = 5
        '
        'Archivo
        '
        Me.Archivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Archivo.HeaderText = "Archivo"
        Me.Archivo.Name = "Archivo"
        Me.Archivo.ReadOnly = True
        Me.Archivo.Width = 68
        '
        'ruta_completa
        '
        Me.ruta_completa.HeaderText = "ruta_completa"
        Me.ruta_completa.Name = "ruta_completa"
        Me.ruta_completa.ReadOnly = True
        Me.ruta_completa.Visible = False
        '
        'adjuntar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 243)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.DgvArchivos)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Name = "adjuntar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adjuntar"
        CType(Me.DgvArchivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents DgvArchivos As System.Windows.Forms.DataGridView
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Check As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Archivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ruta_completa As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
