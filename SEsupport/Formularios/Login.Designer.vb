<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class Login
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents TxbUser As System.Windows.Forms.TextBox
    Friend WithEvents TxbPassword As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.TxbUser = New System.Windows.Forms.TextBox()
        Me.TxbPassword = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.TxbAyuda = New System.Windows.Forms.TextBox()
        Me.LblMensaje = New System.Windows.Forms.Label()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(165, 193)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(172, 2)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Nombre de usuario"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(172, 44)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 7
        Me.PasswordLabel.Text = "&Contraseña"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxbUser
        '
        Me.TxbUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxbUser.Location = New System.Drawing.Point(174, 22)
        Me.TxbUser.Name = "TxbUser"
        Me.TxbUser.Size = New System.Drawing.Size(220, 20)
        Me.TxbUser.TabIndex = 1
        '
        'TxbPassword
        '
        Me.TxbPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TxbPassword.Location = New System.Drawing.Point(174, 64)
        Me.TxbPassword.Name = "TxbPassword"
        Me.TxbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxbPassword.ShortcutsEnabled = False
        Me.TxbPassword.Size = New System.Drawing.Size(220, 20)
        Me.TxbPassword.TabIndex = 2
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.OK.Location = New System.Drawing.Point(197, 165)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 3
        Me.OK.Text = "&Aceptar"
        Me.OK.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(300, 165)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 4
        Me.Cancel.Text = "&Cancelar"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'TxbAyuda
        '
        Me.TxbAyuda.BackColor = System.Drawing.Color.White
        Me.TxbAyuda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxbAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbAyuda.Location = New System.Drawing.Point(178, 93)
        Me.TxbAyuda.Multiline = True
        Me.TxbAyuda.Name = "TxbAyuda"
        Me.TxbAyuda.ReadOnly = True
        Me.TxbAyuda.Size = New System.Drawing.Size(214, 65)
        Me.TxbAyuda.TabIndex = 6
        Me.TxbAyuda.TabStop = False
        Me.TxbAyuda.Text = "Si tienes problemas para ingresar comunicarse con el área de soporte de sistemas " & _
    "en las extensiones 4601, 4602, 4603, 4600"
        Me.TxbAyuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblMensaje
        '
        Me.LblMensaje.AutoSize = True
        Me.LblMensaje.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMensaje.ForeColor = System.Drawing.Color.Red
        Me.LblMensaje.Location = New System.Drawing.Point(40, 199)
        Me.LblMensaje.Name = "LblMensaje"
        Me.LblMensaje.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblMensaje.Size = New System.Drawing.Size(331, 23)
        Me.LblMensaje.TabIndex = 8
        Me.LblMensaje.Text = "DELEITAMOS CON CARIÑO Y CALIDEZ"
        '
        'Login
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(401, 226)
        Me.Controls.Add(Me.LblMensaje)
        Me.Controls.Add(Me.TxbAyuda)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.TxbPassword)
        Me.Controls.Add(Me.TxbUser)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SEsupport - Login"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxbAyuda As System.Windows.Forms.TextBox
    Friend WithEvents LblMensaje As System.Windows.Forms.Label

End Class
