<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio_pos_admin
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
        Me.DgvPos = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Pos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblCargando = New System.Windows.Forms.Label()
        CType(Me.DgvPos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvPos
        '
        Me.DgvPos.AllowUserToAddRows = False
        Me.DgvPos.AllowUserToDeleteRows = False
        Me.DgvPos.AllowUserToResizeRows = False
        Me.DgvPos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.DgvPos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar, Me.Pos, Me.Ip})
        Me.DgvPos.Location = New System.Drawing.Point(0, 12)
        Me.DgvPos.MultiSelect = False
        Me.DgvPos.Name = "DgvPos"
        Me.DgvPos.ReadOnly = True
        Me.DgvPos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DgvPos.Size = New System.Drawing.Size(511, 643)
        Me.DgvPos.TabIndex = 1
        '
        'Seleccionar
        '
        Me.Seleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Seleccionar.Frozen = True
        Me.Seleccionar.HeaderText = "SELECCIONAR"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.ReadOnly = True
        Me.Seleccionar.Width = 88
        '
        'Pos
        '
        Me.Pos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pos.DefaultCellStyle = DataGridViewCellStyle1
        Me.Pos.Frozen = True
        Me.Pos.HeaderText = "PUNTO DE VENTA"
        Me.Pos.Name = "Pos"
        Me.Pos.ReadOnly = True
        Me.Pos.Width = 116
        '
        'Ip
        '
        Me.Ip.Frozen = True
        Me.Ip.HeaderText = "IP"
        Me.Ip.Name = "Ip"
        Me.Ip.ReadOnly = True
        Me.Ip.Visible = False
        '
        'LblCargando
        '
        Me.LblCargando.AutoSize = True
        Me.LblCargando.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCargando.ForeColor = System.Drawing.Color.Red
        Me.LblCargando.Location = New System.Drawing.Point(96, 670)
        Me.LblCargando.Name = "LblCargando"
        Me.LblCargando.Size = New System.Drawing.Size(332, 17)
        Me.LblCargando.TabIndex = 2
        Me.LblCargando.Text = "CARGANDO EL POS... POR FAVOR ESPERE"
        '
        'Inicio_pos_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(511, 696)
        Me.Controls.Add(Me.LblCargando)
        Me.Controls.Add(Me.DgvPos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Inicio_pos_admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccionar el POS"
        CType(Me.DgvPos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvPos As System.Windows.Forms.DataGridView
    Friend WithEvents Seleccionar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Pos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LblCargando As System.Windows.Forms.Label
End Class
