<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editar_usuario_req
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnNOSol = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxbResponsable = New System.Windows.Forms.TextBox()
        Me.LblFechaPac = New System.Windows.Forms.Label()
        Me.MskFechaPac = New System.Windows.Forms.MaskedTextBox()
        Me.LblResponsable = New System.Windows.Forms.Label()
        Me.TxbObservaciones = New System.Windows.Forms.TextBox()
        Me.LblObservaciones = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbCalificacion = New System.Windows.Forms.ComboBox()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.LblRazon = New System.Windows.Forms.Label()
        Me.LblCalificacion = New System.Windows.Forms.Label()
        Me.TxbRazon = New System.Windows.Forms.TextBox()
        Me.GbInfBasica = New System.Windows.Forms.GroupBox()
        Me.LblFechaEntrega = New System.Windows.Forms.Label()
        Me.MskFechaEntrega = New System.Windows.Forms.MaskedTextBox()
        Me.LblNumero = New System.Windows.Forms.Label()
        Me.TxbNumero = New System.Windows.Forms.TextBox()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.TxbUsuario = New System.Windows.Forms.TextBox()
        Me.LblFechaReq = New System.Windows.Forms.Label()
        Me.MskFechaReq = New System.Windows.Forms.MaskedTextBox()
        Me.TxbEstado = New System.Windows.Forms.TextBox()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.TxbDescripcion = New System.Windows.Forms.TextBox()
        Me.DsConsultas = New SEsupport.DsConsultas()
        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_hist_inc_reqTableAdapter = New SEsupport.DsConsultasTableAdapters.vw_hist_inc_reqTableAdapter()
        Me.LblRazonreabrir = New System.Windows.Forms.Label()
        Me.TxbRazonReabrir = New System.Windows.Forms.TextBox()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GbInfBasica.SuspendLayout()
        CType(Me.DsConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxbRazonReabrir)
        Me.GroupBox4.Controls.Add(Me.LblRazonreabrir)
        Me.GroupBox4.Controls.Add(Me.BtnNOSol)
        Me.GroupBox4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(514, 262)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(360, 170)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ABRIR SOPORTE"
        '
        'BtnNOSol
        '
        Me.BtnNOSol.BackColor = System.Drawing.Color.Peru
        Me.BtnNOSol.Enabled = False
        Me.BtnNOSol.Location = New System.Drawing.Point(114, 122)
        Me.BtnNOSol.Name = "BtnNOSol"
        Me.BtnNOSol.Size = New System.Drawing.Size(138, 31)
        Me.BtnNOSol.TabIndex = 33
        Me.BtnNOSol.Text = "No Solucionado"
        Me.BtnNOSol.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxbResponsable)
        Me.GroupBox3.Controls.Add(Me.LblFechaPac)
        Me.GroupBox3.Controls.Add(Me.MskFechaPac)
        Me.GroupBox3.Controls.Add(Me.LblResponsable)
        Me.GroupBox3.Controls.Add(Me.TxbObservaciones)
        Me.GroupBox3.Controls.Add(Me.LblObservaciones)
        Me.GroupBox3.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 262)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(495, 170)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "INFORMACIÓN RESPONSABLE"
        '
        'TxbResponsable
        '
        Me.TxbResponsable.BackColor = System.Drawing.Color.White
        Me.TxbResponsable.Location = New System.Drawing.Point(330, 19)
        Me.TxbResponsable.Name = "TxbResponsable"
        Me.TxbResponsable.ReadOnly = True
        Me.TxbResponsable.Size = New System.Drawing.Size(155, 23)
        Me.TxbResponsable.TabIndex = 23
        '
        'LblFechaPac
        '
        Me.LblFechaPac.AutoSize = True
        Me.LblFechaPac.Location = New System.Drawing.Point(6, 22)
        Me.LblFechaPac.Name = "LblFechaPac"
        Me.LblFechaPac.Size = New System.Drawing.Size(109, 18)
        Me.LblFechaPac.TabIndex = 12
        Me.LblFechaPac.Text = "Fecha Solución"
        '
        'MskFechaPac
        '
        Me.MskFechaPac.BackColor = System.Drawing.Color.White
        Me.MskFechaPac.Location = New System.Drawing.Point(121, 19)
        Me.MskFechaPac.Mask = "00/00/0000"
        Me.MskFechaPac.Name = "MskFechaPac"
        Me.MskFechaPac.ReadOnly = True
        Me.MskFechaPac.Size = New System.Drawing.Size(98, 23)
        Me.MskFechaPac.TabIndex = 13
        Me.MskFechaPac.ValidatingType = GetType(Date)
        '
        'LblResponsable
        '
        Me.LblResponsable.AutoSize = True
        Me.LblResponsable.Location = New System.Drawing.Point(235, 22)
        Me.LblResponsable.Name = "LblResponsable"
        Me.LblResponsable.Size = New System.Drawing.Size(89, 18)
        Me.LblResponsable.TabIndex = 14
        Me.LblResponsable.Text = "Responsable"
        '
        'TxbObservaciones
        '
        Me.TxbObservaciones.BackColor = System.Drawing.Color.White
        Me.TxbObservaciones.Location = New System.Drawing.Point(116, 50)
        Me.TxbObservaciones.Multiline = True
        Me.TxbObservaciones.Name = "TxbObservaciones"
        Me.TxbObservaciones.ReadOnly = True
        Me.TxbObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxbObservaciones.Size = New System.Drawing.Size(369, 114)
        Me.TxbObservaciones.TabIndex = 21
        '
        'LblObservaciones
        '
        Me.LblObservaciones.AutoSize = True
        Me.LblObservaciones.Location = New System.Drawing.Point(11, 93)
        Me.LblObservaciones.Name = "LblObservaciones"
        Me.LblObservaciones.Size = New System.Drawing.Size(104, 18)
        Me.LblObservaciones.TabIndex = 20
        Me.LblObservaciones.Text = "Observaciones" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.CmbCalificacion)
        Me.GroupBox2.Controls.Add(Me.BtnEnviar)
        Me.GroupBox2.Controls.Add(Me.LblRazon)
        Me.GroupBox2.Controls.Add(Me.LblCalificacion)
        Me.GroupBox2.Controls.Add(Me.TxbRazon)
        Me.GroupBox2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(514, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 239)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CALIFICACIÓN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(33, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 30)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Califique de 1 a 5, siendo 1 la calificación mas baja" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y 5 la calificación mas al" & _
    "ta"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbCalificacion
        '
        Me.CmbCalificacion.Enabled = False
        Me.CmbCalificacion.FormattingEnabled = True
        Me.CmbCalificacion.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.CmbCalificacion.Location = New System.Drawing.Point(103, 70)
        Me.CmbCalificacion.Name = "CmbCalificacion"
        Me.CmbCalificacion.Size = New System.Drawing.Size(92, 26)
        Me.CmbCalificacion.TabIndex = 28
        '
        'BtnEnviar
        '
        Me.BtnEnviar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnEnviar.Enabled = False
        Me.BtnEnviar.Location = New System.Drawing.Point(103, 188)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(177, 26)
        Me.BtnEnviar.TabIndex = 23
        Me.BtnEnviar.Text = "Enviar Calificación"
        Me.BtnEnviar.UseVisualStyleBackColor = False
        '
        'LblRazon
        '
        Me.LblRazon.AutoSize = True
        Me.LblRazon.Location = New System.Drawing.Point(12, 124)
        Me.LblRazon.Name = "LblRazon"
        Me.LblRazon.Size = New System.Drawing.Size(47, 18)
        Me.LblRazon.TabIndex = 26
        Me.LblRazon.Text = "Razón"
        '
        'LblCalificacion
        '
        Me.LblCalificacion.AutoSize = True
        Me.LblCalificacion.Location = New System.Drawing.Point(10, 78)
        Me.LblCalificacion.Name = "LblCalificacion"
        Me.LblCalificacion.Size = New System.Drawing.Size(87, 18)
        Me.LblCalificacion.TabIndex = 22
        Me.LblCalificacion.Text = "Calificación"
        '
        'TxbRazon
        '
        Me.TxbRazon.Enabled = False
        Me.TxbRazon.Location = New System.Drawing.Point(74, 112)
        Me.TxbRazon.Multiline = True
        Me.TxbRazon.Name = "TxbRazon"
        Me.TxbRazon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxbRazon.Size = New System.Drawing.Size(271, 61)
        Me.TxbRazon.TabIndex = 27
        '
        'GbInfBasica
        '
        Me.GbInfBasica.Controls.Add(Me.LblFechaEntrega)
        Me.GbInfBasica.Controls.Add(Me.MskFechaEntrega)
        Me.GbInfBasica.Controls.Add(Me.LblNumero)
        Me.GbInfBasica.Controls.Add(Me.TxbNumero)
        Me.GbInfBasica.Controls.Add(Me.LblUsuario)
        Me.GbInfBasica.Controls.Add(Me.TxbUsuario)
        Me.GbInfBasica.Controls.Add(Me.LblFechaReq)
        Me.GbInfBasica.Controls.Add(Me.MskFechaReq)
        Me.GbInfBasica.Controls.Add(Me.TxbEstado)
        Me.GbInfBasica.Controls.Add(Me.LblEstado)
        Me.GbInfBasica.Controls.Add(Me.LblDescripcion)
        Me.GbInfBasica.Controls.Add(Me.TxbDescripcion)
        Me.GbInfBasica.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbInfBasica.Location = New System.Drawing.Point(6, 8)
        Me.GbInfBasica.Name = "GbInfBasica"
        Me.GbInfBasica.Size = New System.Drawing.Size(495, 239)
        Me.GbInfBasica.TabIndex = 35
        Me.GbInfBasica.TabStop = False
        Me.GbInfBasica.Text = "INFORMACION BASE"
        '
        'LblFechaEntrega
        '
        Me.LblFechaEntrega.AutoSize = True
        Me.LblFechaEntrega.Location = New System.Drawing.Point(235, 52)
        Me.LblFechaEntrega.Name = "LblFechaEntrega"
        Me.LblFechaEntrega.Size = New System.Drawing.Size(133, 18)
        Me.LblFechaEntrega.TabIndex = 20
        Me.LblFechaEntrega.Text = "Fecha Finalización"
        '
        'MskFechaEntrega
        '
        Me.MskFechaEntrega.BackColor = System.Drawing.Color.White
        Me.MskFechaEntrega.Location = New System.Drawing.Point(392, 52)
        Me.MskFechaEntrega.Mask = "00/00/0000"
        Me.MskFechaEntrega.Name = "MskFechaEntrega"
        Me.MskFechaEntrega.ReadOnly = True
        Me.MskFechaEntrega.Size = New System.Drawing.Size(93, 23)
        Me.MskFechaEntrega.TabIndex = 21
        Me.MskFechaEntrega.ValidatingType = GetType(Date)
        '
        'LblNumero
        '
        Me.LblNumero.AutoSize = True
        Me.LblNumero.Location = New System.Drawing.Point(6, 23)
        Me.LblNumero.Name = "LblNumero"
        Me.LblNumero.Size = New System.Drawing.Size(61, 18)
        Me.LblNumero.TabIndex = 0
        Me.LblNumero.Text = "Número"
        '
        'TxbNumero
        '
        Me.TxbNumero.BackColor = System.Drawing.Color.White
        Me.TxbNumero.Location = New System.Drawing.Point(78, 20)
        Me.TxbNumero.Name = "TxbNumero"
        Me.TxbNumero.ReadOnly = True
        Me.TxbNumero.Size = New System.Drawing.Size(79, 23)
        Me.TxbNumero.TabIndex = 1
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Location = New System.Drawing.Point(6, 52)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(60, 18)
        Me.LblUsuario.TabIndex = 4
        Me.LblUsuario.Text = "Usuario"
        '
        'TxbUsuario
        '
        Me.TxbUsuario.BackColor = System.Drawing.Color.White
        Me.TxbUsuario.Location = New System.Drawing.Point(78, 49)
        Me.TxbUsuario.Name = "TxbUsuario"
        Me.TxbUsuario.ReadOnly = True
        Me.TxbUsuario.Size = New System.Drawing.Size(151, 23)
        Me.TxbUsuario.TabIndex = 5
        '
        'LblFechaReq
        '
        Me.LblFechaReq.AutoSize = True
        Me.LblFechaReq.Location = New System.Drawing.Point(235, 24)
        Me.LblFechaReq.Name = "LblFechaReq"
        Me.LblFechaReq.Size = New System.Drawing.Size(151, 18)
        Me.LblFechaReq.TabIndex = 8
        Me.LblFechaReq.Text = "Fecha Requerimiento"
        '
        'MskFechaReq
        '
        Me.MskFechaReq.BackColor = System.Drawing.Color.White
        Me.MskFechaReq.Location = New System.Drawing.Point(392, 22)
        Me.MskFechaReq.Mask = "00/00/0000"
        Me.MskFechaReq.Name = "MskFechaReq"
        Me.MskFechaReq.ReadOnly = True
        Me.MskFechaReq.Size = New System.Drawing.Size(93, 23)
        Me.MskFechaReq.TabIndex = 9
        Me.MskFechaReq.ValidatingType = GetType(Date)
        '
        'TxbEstado
        '
        Me.TxbEstado.BackColor = System.Drawing.Color.White
        Me.TxbEstado.Location = New System.Drawing.Point(78, 79)
        Me.TxbEstado.Name = "TxbEstado"
        Me.TxbEstado.ReadOnly = True
        Me.TxbEstado.Size = New System.Drawing.Size(151, 23)
        Me.TxbEstado.TabIndex = 19
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Location = New System.Drawing.Point(7, 82)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(50, 18)
        Me.LblEstado.TabIndex = 18
        Me.LblEstado.Text = "Estado"
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.Location = New System.Drawing.Point(7, 155)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(80, 18)
        Me.LblDescripcion.TabIndex = 6
        Me.LblDescripcion.Text = "Descipción"
        '
        'TxbDescripcion
        '
        Me.TxbDescripcion.BackColor = System.Drawing.Color.White
        Me.TxbDescripcion.Location = New System.Drawing.Point(92, 112)
        Me.TxbDescripcion.Multiline = True
        Me.TxbDescripcion.Name = "TxbDescripcion"
        Me.TxbDescripcion.ReadOnly = True
        Me.TxbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxbDescripcion.Size = New System.Drawing.Size(393, 121)
        Me.TxbDescripcion.TabIndex = 7
        '
        'DsConsultas
        '
        Me.DsConsultas.DataSetName = "DsConsultas"
        Me.DsConsultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource
        '
        Me.BindingSource.DataMember = "vw_hist_inc_req"
        Me.BindingSource.DataSource = Me.DsConsultas
        '
        'Vw_hist_inc_reqTableAdapter
        '
        Me.Vw_hist_inc_reqTableAdapter.ClearBeforeFill = True
        '
        'LblRazonreabrir
        '
        Me.LblRazonreabrir.AutoSize = True
        Me.LblRazonreabrir.Location = New System.Drawing.Point(6, 53)
        Me.LblRazonreabrir.Name = "LblRazonreabrir"
        Me.LblRazonreabrir.Size = New System.Drawing.Size(47, 18)
        Me.LblRazonreabrir.TabIndex = 35
        Me.LblRazonreabrir.Text = "Razón"
        '
        'TxbRazonReabrir
        '
        Me.TxbRazonReabrir.Enabled = False
        Me.TxbRazonReabrir.Location = New System.Drawing.Point(59, 22)
        Me.TxbRazonReabrir.Multiline = True
        Me.TxbRazonReabrir.Name = "TxbRazonReabrir"
        Me.TxbRazonReabrir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxbRazonReabrir.Size = New System.Drawing.Size(271, 83)
        Me.TxbRazonReabrir.TabIndex = 36
        '
        'Editar_usuario_req
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(882, 444)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GbInfBasica)
        Me.Name = "Editar_usuario_req"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SEsupport - Editar Requerimiento"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GbInfBasica.ResumeLayout(False)
        Me.GbInfBasica.PerformLayout()
        CType(Me.DsConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnNOSol As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxbResponsable As System.Windows.Forms.TextBox
    Friend WithEvents LblFechaPac As System.Windows.Forms.Label
    Friend WithEvents MskFechaPac As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LblResponsable As System.Windows.Forms.Label
    Friend WithEvents TxbObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents LblObservaciones As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbCalificacion As System.Windows.Forms.ComboBox
    Friend WithEvents BtnEnviar As System.Windows.Forms.Button
    Friend WithEvents LblRazon As System.Windows.Forms.Label
    Friend WithEvents LblCalificacion As System.Windows.Forms.Label
    Friend WithEvents TxbRazon As System.Windows.Forms.TextBox
    Friend WithEvents GbInfBasica As System.Windows.Forms.GroupBox
    Friend WithEvents LblFechaEntrega As System.Windows.Forms.Label
    Friend WithEvents MskFechaEntrega As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LblNumero As System.Windows.Forms.Label
    Friend WithEvents TxbNumero As System.Windows.Forms.TextBox
    Friend WithEvents LblUsuario As System.Windows.Forms.Label
    Friend WithEvents TxbUsuario As System.Windows.Forms.TextBox
    Friend WithEvents LblFechaReq As System.Windows.Forms.Label
    Friend WithEvents MskFechaReq As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxbEstado As System.Windows.Forms.TextBox
    Friend WithEvents LblEstado As System.Windows.Forms.Label
    Friend WithEvents LblDescripcion As System.Windows.Forms.Label
    Friend WithEvents TxbDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents DsConsultas As SEsupport.DsConsultas
    Friend WithEvents BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vw_hist_inc_reqTableAdapter As SEsupport.DsConsultasTableAdapters.vw_hist_inc_reqTableAdapter
    Friend WithEvents TxbRazonReabrir As System.Windows.Forms.TextBox
    Friend WithEvents LblRazonreabrir As System.Windows.Forms.Label
End Class
