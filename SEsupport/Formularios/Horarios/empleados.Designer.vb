<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empleados
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
        Me.chkestado = New System.Windows.Forms.CheckBox()
        Me.cbxarea = New System.Windows.Forms.ComboBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtcc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkestado
        '
        Me.chkestado.AutoSize = True
        Me.chkestado.Location = New System.Drawing.Point(174, 161)
        Me.chkestado.Name = "chkestado"
        Me.chkestado.Size = New System.Drawing.Size(56, 17)
        Me.chkestado.TabIndex = 9
        Me.chkestado.Text = "Activo"
        Me.chkestado.UseVisualStyleBackColor = True
        '
        'cbxarea
        '
        Me.cbxarea.FormattingEnabled = True
        Me.cbxarea.Location = New System.Drawing.Point(127, 124)
        Me.cbxarea.Name = "cbxarea"
        Me.cbxarea.Size = New System.Drawing.Size(155, 21)
        Me.cbxarea.TabIndex = 8
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(126, 88)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(156, 20)
        Me.txtapellido.TabIndex = 7
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(126, 53)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(156, 20)
        Me.txtnombre.TabIndex = 6
        '
        'txtcc
        '
        Me.txtcc.Location = New System.Drawing.Point(126, 20)
        Me.txtcc.Name = "txtcc"
        Me.txtcc.Size = New System.Drawing.Size(156, 20)
        Me.txtcc.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Area"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cedula:"
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(188, 249)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 5
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(65, 249)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnnuevo.TabIndex = 4
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.chkestado)
        Me.Panel1.Controls.Add(Me.cbxarea)
        Me.Panel1.Controls.Add(Me.txtapellido)
        Me.Panel1.Controls.Add(Me.txtnombre)
        Me.Panel1.Controls.Add(Me.txtcc)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(13, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(316, 200)
        Me.Panel1.TabIndex = 3
        '
        'empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 298)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "empleados"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents chkestado As CheckBox
    Friend WithEvents cbxarea As ComboBox
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtcc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents Panel1 As Panel
End Class
