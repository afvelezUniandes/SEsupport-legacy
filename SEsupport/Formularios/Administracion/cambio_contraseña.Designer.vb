<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cambio_contraseña
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
        Me.LblContraseñaAnt = New System.Windows.Forms.Label()
        Me.TxbContraseñaAnt = New System.Windows.Forms.TextBox()
        Me.TxbContraseñaNueva = New System.Windows.Forms.TextBox()
        Me.LblContraseñaNueva = New System.Windows.Forms.Label()
        Me.TxbRcontraseñaNueva = New System.Windows.Forms.TextBox()
        Me.LblRContraseñaNueva = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbUsuario = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'LblContraseñaAnt
        '
        Me.LblContraseñaAnt.AutoSize = True
        Me.LblContraseñaAnt.Location = New System.Drawing.Point(12, 57)
        Me.LblContraseñaAnt.Name = "LblContraseñaAnt"
        Me.LblContraseñaAnt.Size = New System.Drawing.Size(94, 13)
        Me.LblContraseñaAnt.TabIndex = 0
        Me.LblContraseñaAnt.Text = "Contraseña Actual"
        '
        'TxbContraseñaAnt
        '
        Me.TxbContraseñaAnt.Location = New System.Drawing.Point(161, 54)
        Me.TxbContraseñaAnt.Name = "TxbContraseñaAnt"
        Me.TxbContraseñaAnt.ShortcutsEnabled = False
        Me.TxbContraseñaAnt.Size = New System.Drawing.Size(120, 20)
        Me.TxbContraseñaAnt.TabIndex = 1
        Me.TxbContraseñaAnt.UseSystemPasswordChar = True
        '
        'TxbContraseñaNueva
        '
        Me.TxbContraseñaNueva.Location = New System.Drawing.Point(161, 88)
        Me.TxbContraseñaNueva.Name = "TxbContraseñaNueva"
        Me.TxbContraseñaNueva.ShortcutsEnabled = False
        Me.TxbContraseñaNueva.Size = New System.Drawing.Size(120, 20)
        Me.TxbContraseñaNueva.TabIndex = 3
        Me.TxbContraseñaNueva.UseSystemPasswordChar = True
        '
        'LblContraseñaNueva
        '
        Me.LblContraseñaNueva.AutoSize = True
        Me.LblContraseñaNueva.Location = New System.Drawing.Point(12, 91)
        Me.LblContraseñaNueva.Name = "LblContraseñaNueva"
        Me.LblContraseñaNueva.Size = New System.Drawing.Size(96, 13)
        Me.LblContraseñaNueva.TabIndex = 2
        Me.LblContraseñaNueva.Text = "Contraseña Nueva"
        '
        'TxbRcontraseñaNueva
        '
        Me.TxbRcontraseñaNueva.Location = New System.Drawing.Point(161, 118)
        Me.TxbRcontraseñaNueva.Name = "TxbRcontraseñaNueva"
        Me.TxbRcontraseñaNueva.ShortcutsEnabled = False
        Me.TxbRcontraseñaNueva.Size = New System.Drawing.Size(120, 20)
        Me.TxbRcontraseñaNueva.TabIndex = 5
        Me.TxbRcontraseñaNueva.UseSystemPasswordChar = True
        '
        'LblRContraseñaNueva
        '
        Me.LblRContraseñaNueva.AutoSize = True
        Me.LblRContraseñaNueva.Location = New System.Drawing.Point(12, 121)
        Me.LblRContraseñaNueva.Name = "LblRContraseñaNueva"
        Me.LblRContraseñaNueva.Size = New System.Drawing.Size(143, 13)
        Me.LblRContraseñaNueva.TabIndex = 4
        Me.LblRContraseñaNueva.Text = "Confirmar Contraseña Nueva"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(53, 158)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 6
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.Location = New System.Drawing.Point(161, 158)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 7
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Usuario"
        '
        'CmbUsuario
        '
        Me.CmbUsuario.FormattingEnabled = True
        Me.CmbUsuario.Location = New System.Drawing.Point(74, 20)
        Me.CmbUsuario.Name = "CmbUsuario"
        Me.CmbUsuario.Size = New System.Drawing.Size(207, 21)
        Me.CmbUsuario.TabIndex = 9
        '
        'cambio_contraseña
        '
        Me.AcceptButton = Me.BtnGuardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancelar
        Me.ClientSize = New System.Drawing.Size(303, 193)
        Me.Controls.Add(Me.CmbUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.TxbRcontraseñaNueva)
        Me.Controls.Add(Me.LblRContraseñaNueva)
        Me.Controls.Add(Me.TxbContraseñaNueva)
        Me.Controls.Add(Me.LblContraseñaNueva)
        Me.Controls.Add(Me.TxbContraseñaAnt)
        Me.Controls.Add(Me.LblContraseñaAnt)
        Me.Name = "cambio_contraseña"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cambio_contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblContraseñaAnt As System.Windows.Forms.Label
    Friend WithEvents TxbContraseñaAnt As System.Windows.Forms.TextBox
    Friend WithEvents TxbContraseñaNueva As System.Windows.Forms.TextBox
    Friend WithEvents LblContraseñaNueva As System.Windows.Forms.Label
    Friend WithEvents TxbRcontraseñaNueva As System.Windows.Forms.TextBox
    Friend WithEvents LblRContraseñaNueva As System.Windows.Forms.Label
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbUsuario As ComboBox
End Class
