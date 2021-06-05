<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ayuda_queja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ayuda_queja))
        Me.TxbAyuda = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TxbAyuda
        '
        Me.TxbAyuda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxbAyuda.Enabled = False
        Me.TxbAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbAyuda.Location = New System.Drawing.Point(0, 0)
        Me.TxbAyuda.Multiline = True
        Me.TxbAyuda.Name = "TxbAyuda"
        Me.TxbAyuda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxbAyuda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxbAyuda.Size = New System.Drawing.Size(726, 187)
        Me.TxbAyuda.TabIndex = 0
        Me.TxbAyuda.Text = resources.GetString("TxbAyuda.Text")
        '
        'Ayuda_queja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 187)
        Me.Controls.Add(Me.TxbAyuda)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ayuda_queja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ayuda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxbAyuda As System.Windows.Forms.TextBox
End Class
