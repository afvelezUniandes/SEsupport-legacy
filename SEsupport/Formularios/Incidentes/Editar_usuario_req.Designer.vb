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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxbRazonReabrir = New System.Windows.Forms.TextBox()
        Me.LblRazonreabrir = New System.Windows.Forms.Label()
        Me.BtnNOSol = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxbIdTecnico = New System.Windows.Forms.TextBox()
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
        Me.LinkComentarios = New System.Windows.Forms.LinkLabel()
        Me.TxbIdUsuario = New System.Windows.Forms.TextBox()
        Me.LinkAprobacion = New System.Windows.Forms.LinkLabel()
        Me.LinkAdjuntos = New System.Windows.Forms.LinkLabel()
        Me.LblFechaEntrega = New System.Windows.Forms.Label()
        Me.MskFechaEntrega = New System.Windows.Forms.MaskedTextBox()
        Me.LblNumero = New System.Windows.Forms.Label()
        Me.TxbNumero = New System.Windows.Forms.TextBox()
        Me.LblFechaReq = New System.Windows.Forms.Label()
        Me.MskFechaReq = New System.Windows.Forms.MaskedTextBox()
        Me.TxbEstado = New System.Windows.Forms.TextBox()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.TxbDescripcion = New System.Windows.Forms.TextBox()
        Me.GbxComentarios = New System.Windows.Forms.GroupBox()
        Me.DgvComentarios = New System.Windows.Forms.DataGridView()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GbInfBasica.SuspendLayout()
        Me.GbxComentarios.SuspendLayout()
        CType(Me.DgvComentarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.TxbRazonReabrir)
        Me.GroupBox4.Controls.Add(Me.LblRazonreabrir)
        Me.GroupBox4.Controls.Add(Me.BtnNOSol)
        Me.GroupBox4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(472, 558)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(362, 195)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ABRIR SOPORTE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(58, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 30)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "El soporte se podrá reabrir si el soporte" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "estáfinalizado y no ha sido calificado" & _
    ""
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxbRazonReabrir
        '
        Me.TxbRazonReabrir.Enabled = False
        Me.TxbRazonReabrir.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbRazonReabrir.Location = New System.Drawing.Point(61, 62)
        Me.TxbRazonReabrir.Multiline = True
        Me.TxbRazonReabrir.Name = "TxbRazonReabrir"
        Me.TxbRazonReabrir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxbRazonReabrir.Size = New System.Drawing.Size(290, 93)
        Me.TxbRazonReabrir.TabIndex = 36
        '
        'LblRazonreabrir
        '
        Me.LblRazonreabrir.AutoSize = True
        Me.LblRazonreabrir.Location = New System.Drawing.Point(9, 101)
        Me.LblRazonreabrir.Name = "LblRazonreabrir"
        Me.LblRazonreabrir.Size = New System.Drawing.Size(50, 16)
        Me.LblRazonreabrir.TabIndex = 35
        Me.LblRazonreabrir.Text = "Razón"
        '
        'BtnNOSol
        '
        Me.BtnNOSol.BackColor = System.Drawing.Color.Peru
        Me.BtnNOSol.Enabled = False
        Me.BtnNOSol.Location = New System.Drawing.Point(127, 165)
        Me.BtnNOSol.Name = "BtnNOSol"
        Me.BtnNOSol.Size = New System.Drawing.Size(138, 31)
        Me.BtnNOSol.TabIndex = 33
        Me.BtnNOSol.Text = "No Solucionado"
        Me.BtnNOSol.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxbIdTecnico)
        Me.GroupBox3.Controls.Add(Me.TxbResponsable)
        Me.GroupBox3.Controls.Add(Me.LblFechaPac)
        Me.GroupBox3.Controls.Add(Me.MskFechaPac)
        Me.GroupBox3.Controls.Add(Me.LblResponsable)
        Me.GroupBox3.Controls.Add(Me.TxbObservaciones)
        Me.GroupBox3.Controls.Add(Me.LblObservaciones)
        Me.GroupBox3.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 216)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(828, 170)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "INFORMACIÓN RESPONSABLE"
        '
        'TxbIdTecnico
        '
        Me.TxbIdTecnico.Enabled = False
        Me.TxbIdTecnico.Location = New System.Drawing.Point(22, 122)
        Me.TxbIdTecnico.Name = "TxbIdTecnico"
        Me.TxbIdTecnico.Size = New System.Drawing.Size(65, 23)
        Me.TxbIdTecnico.TabIndex = 25
        Me.TxbIdTecnico.Visible = False
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
        Me.TxbObservaciones.Location = New System.Drawing.Point(116, 53)
        Me.TxbObservaciones.Multiline = True
        Me.TxbObservaciones.Name = "TxbObservaciones"
        Me.TxbObservaciones.ReadOnly = True
        Me.TxbObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxbObservaciones.Size = New System.Drawing.Size(701, 104)
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
        Me.GroupBox2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 558)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(446, 195)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CALIFICACIÓN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(56, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 30)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Califique de 1 a 5, siendo 1 la calificación mas baja " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y 5 la calificación mas a" & _
    "lta"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbCalificacion
        '
        Me.CmbCalificacion.Enabled = False
        Me.CmbCalificacion.FormattingEnabled = True
        Me.CmbCalificacion.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.CmbCalificacion.Location = New System.Drawing.Point(103, 59)
        Me.CmbCalificacion.Name = "CmbCalificacion"
        Me.CmbCalificacion.Size = New System.Drawing.Size(62, 24)
        Me.CmbCalificacion.TabIndex = 28
        '
        'BtnEnviar
        '
        Me.BtnEnviar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnEnviar.Enabled = False
        Me.BtnEnviar.Location = New System.Drawing.Point(130, 159)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(177, 26)
        Me.BtnEnviar.TabIndex = 23
        Me.BtnEnviar.Text = "Enviar Calificación"
        Me.BtnEnviar.UseVisualStyleBackColor = False
        '
        'LblRazon
        '
        Me.LblRazon.AutoSize = True
        Me.LblRazon.Location = New System.Drawing.Point(12, 112)
        Me.LblRazon.Name = "LblRazon"
        Me.LblRazon.Size = New System.Drawing.Size(50, 16)
        Me.LblRazon.TabIndex = 26
        Me.LblRazon.Text = "Razón"
        '
        'LblCalificacion
        '
        Me.LblCalificacion.AutoSize = True
        Me.LblCalificacion.Location = New System.Drawing.Point(10, 61)
        Me.LblCalificacion.Name = "LblCalificacion"
        Me.LblCalificacion.Size = New System.Drawing.Size(90, 16)
        Me.LblCalificacion.TabIndex = 22
        Me.LblCalificacion.Text = "Calificación"
        '
        'TxbRazon
        '
        Me.TxbRazon.Enabled = False
        Me.TxbRazon.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbRazon.Location = New System.Drawing.Point(103, 89)
        Me.TxbRazon.Multiline = True
        Me.TxbRazon.Name = "TxbRazon"
        Me.TxbRazon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxbRazon.Size = New System.Drawing.Size(337, 61)
        Me.TxbRazon.TabIndex = 27
        '
        'GbInfBasica
        '
        Me.GbInfBasica.Controls.Add(Me.LinkComentarios)
        Me.GbInfBasica.Controls.Add(Me.TxbIdUsuario)
        Me.GbInfBasica.Controls.Add(Me.LinkAprobacion)
        Me.GbInfBasica.Controls.Add(Me.LinkAdjuntos)
        Me.GbInfBasica.Controls.Add(Me.LblFechaEntrega)
        Me.GbInfBasica.Controls.Add(Me.MskFechaEntrega)
        Me.GbInfBasica.Controls.Add(Me.LblNumero)
        Me.GbInfBasica.Controls.Add(Me.TxbNumero)
        Me.GbInfBasica.Controls.Add(Me.LblFechaReq)
        Me.GbInfBasica.Controls.Add(Me.MskFechaReq)
        Me.GbInfBasica.Controls.Add(Me.TxbEstado)
        Me.GbInfBasica.Controls.Add(Me.LblEstado)
        Me.GbInfBasica.Controls.Add(Me.LblDescripcion)
        Me.GbInfBasica.Controls.Add(Me.TxbDescripcion)
        Me.GbInfBasica.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbInfBasica.Location = New System.Drawing.Point(6, 8)
        Me.GbInfBasica.Name = "GbInfBasica"
        Me.GbInfBasica.Size = New System.Drawing.Size(828, 203)
        Me.GbInfBasica.TabIndex = 35
        Me.GbInfBasica.TabStop = False
        Me.GbInfBasica.Text = "INFORMACION BASE"
        '
        'LinkComentarios
        '
        Me.LinkComentarios.AutoSize = True
        Me.LinkComentarios.Font = New System.Drawing.Font("Bookman Old Style", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkComentarios.Location = New System.Drawing.Point(12, 171)
        Me.LinkComentarios.Name = "LinkComentarios"
        Me.LinkComentarios.Size = New System.Drawing.Size(130, 18)
        Me.LinkComentarios.TabIndex = 39
        Me.LinkComentarios.TabStop = True
        Me.LinkComentarios.Text = "COMENTARIOS"
        '
        'TxbIdUsuario
        '
        Me.TxbIdUsuario.Enabled = False
        Me.TxbIdUsuario.Location = New System.Drawing.Point(13, 61)
        Me.TxbIdUsuario.Name = "TxbIdUsuario"
        Me.TxbIdUsuario.Size = New System.Drawing.Size(65, 23)
        Me.TxbIdUsuario.TabIndex = 24
        Me.TxbIdUsuario.Visible = False
        '
        'LinkAprobacion
        '
        Me.LinkAprobacion.AutoSize = True
        Me.LinkAprobacion.Font = New System.Drawing.Font("Bookman Old Style", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkAprobacion.Location = New System.Drawing.Point(696, 172)
        Me.LinkAprobacion.Name = "LinkAprobacion"
        Me.LinkAprobacion.Size = New System.Drawing.Size(115, 18)
        Me.LinkAprobacion.TabIndex = 23
        Me.LinkAprobacion.TabStop = True
        Me.LinkAprobacion.Text = "APROBACIÓN"
        '
        'LinkAdjuntos
        '
        Me.LinkAdjuntos.AutoSize = True
        Me.LinkAdjuntos.Font = New System.Drawing.Font("Bookman Old Style", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkAdjuntos.Location = New System.Drawing.Point(329, 172)
        Me.LinkAdjuntos.Name = "LinkAdjuntos"
        Me.LinkAdjuntos.Size = New System.Drawing.Size(184, 18)
        Me.LinkAdjuntos.TabIndex = 22
        Me.LinkAdjuntos.TabStop = True
        Me.LinkAdjuntos.Text = "ARCHIVOS ADJUNTOS"
        '
        'LblFechaEntrega
        '
        Me.LblFechaEntrega.AutoSize = True
        Me.LblFechaEntrega.Location = New System.Drawing.Point(591, 23)
        Me.LblFechaEntrega.Name = "LblFechaEntrega"
        Me.LblFechaEntrega.Size = New System.Drawing.Size(133, 18)
        Me.LblFechaEntrega.TabIndex = 20
        Me.LblFechaEntrega.Text = "Fecha Finalización"
        '
        'MskFechaEntrega
        '
        Me.MskFechaEntrega.BackColor = System.Drawing.Color.White
        Me.MskFechaEntrega.Location = New System.Drawing.Point(724, 19)
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
        Me.TxbNumero.Location = New System.Drawing.Point(71, 20)
        Me.TxbNumero.Name = "TxbNumero"
        Me.TxbNumero.ReadOnly = True
        Me.TxbNumero.Size = New System.Drawing.Size(79, 23)
        Me.TxbNumero.TabIndex = 1
        '
        'LblFechaReq
        '
        Me.LblFechaReq.AutoSize = True
        Me.LblFechaReq.Location = New System.Drawing.Point(338, 22)
        Me.LblFechaReq.Name = "LblFechaReq"
        Me.LblFechaReq.Size = New System.Drawing.Size(151, 18)
        Me.LblFechaReq.TabIndex = 8
        Me.LblFechaReq.Text = "Fecha Requerimiento"
        '
        'MskFechaReq
        '
        Me.MskFechaReq.BackColor = System.Drawing.Color.White
        Me.MskFechaReq.Location = New System.Drawing.Point(488, 19)
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
        Me.TxbEstado.Location = New System.Drawing.Point(215, 19)
        Me.TxbEstado.Name = "TxbEstado"
        Me.TxbEstado.ReadOnly = True
        Me.TxbEstado.Size = New System.Drawing.Size(104, 23)
        Me.TxbEstado.TabIndex = 19
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Location = New System.Drawing.Point(166, 22)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(50, 18)
        Me.LblEstado.TabIndex = 18
        Me.LblEstado.Text = "Estado"
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.Location = New System.Drawing.Point(7, 98)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(80, 18)
        Me.LblDescripcion.TabIndex = 6
        Me.LblDescripcion.Text = "Descipción"
        '
        'TxbDescripcion
        '
        Me.TxbDescripcion.BackColor = System.Drawing.Color.White
        Me.TxbDescripcion.Location = New System.Drawing.Point(92, 61)
        Me.TxbDescripcion.Multiline = True
        Me.TxbDescripcion.Name = "TxbDescripcion"
        Me.TxbDescripcion.ReadOnly = True
        Me.TxbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxbDescripcion.Size = New System.Drawing.Size(725, 95)
        Me.TxbDescripcion.TabIndex = 7
        '
        'GbxComentarios
        '
        Me.GbxComentarios.Controls.Add(Me.DgvComentarios)
        Me.GbxComentarios.Font = New System.Drawing.Font("Bookman Old Style", 9.75!)
        Me.GbxComentarios.Location = New System.Drawing.Point(6, 392)
        Me.GbxComentarios.Name = "GbxComentarios"
        Me.GbxComentarios.Size = New System.Drawing.Size(828, 160)
        Me.GbxComentarios.TabIndex = 39
        Me.GbxComentarios.TabStop = False
        Me.GbxComentarios.Text = "COMENTARIOS"
        '
        'DgvComentarios
        '
        Me.DgvComentarios.AllowUserToAddRows = False
        Me.DgvComentarios.AllowUserToDeleteRows = False
        Me.DgvComentarios.AllowUserToResizeColumns = False
        Me.DgvComentarios.AllowUserToResizeRows = False
        Me.DgvComentarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvComentarios.ColumnHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Bookman Old Style", 9.75!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvComentarios.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvComentarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvComentarios.Location = New System.Drawing.Point(3, 19)
        Me.DgvComentarios.Name = "DgvComentarios"
        Me.DgvComentarios.ReadOnly = True
        Me.DgvComentarios.Size = New System.Drawing.Size(822, 138)
        Me.DgvComentarios.TabIndex = 0
        '
        'Editar_usuario_req
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(841, 761)
        Me.Controls.Add(Me.GbxComentarios)
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
        Me.GbxComentarios.ResumeLayout(False)
        CType(Me.DgvComentarios, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LblFechaReq As System.Windows.Forms.Label
    Friend WithEvents MskFechaReq As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxbEstado As System.Windows.Forms.TextBox
    Friend WithEvents LblEstado As System.Windows.Forms.Label
    Friend WithEvents LblDescripcion As System.Windows.Forms.Label
    Friend WithEvents TxbDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents TxbRazonReabrir As System.Windows.Forms.TextBox
    Friend WithEvents LblRazonreabrir As System.Windows.Forms.Label
    Friend WithEvents LinkAdjuntos As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkAprobacion As System.Windows.Forms.LinkLabel
    Friend WithEvents TxbIdUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TxbIdTecnico As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LinkComentarios As System.Windows.Forms.LinkLabel
    Friend WithEvents GbxComentarios As System.Windows.Forms.GroupBox
    Friend WithEvents DgvComentarios As System.Windows.Forms.DataGridView
End Class
