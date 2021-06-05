<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editar_tecnico_req
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LinkComentarios = New System.Windows.Forms.LinkLabel()
        Me.LinkCicloAprobacion = New System.Windows.Forms.LinkLabel()
        Me.LinkAdjuntos = New System.Windows.Forms.LinkLabel()
        Me.CmbMotivo = New System.Windows.Forms.ComboBox()
        Me.LblMotivo = New System.Windows.Forms.Label()
        Me.CmbModulo = New System.Windows.Forms.ComboBox()
        Me.LblModulo = New System.Windows.Forms.Label()
        Me.CmbPrioridad = New System.Windows.Forms.ComboBox()
        Me.LblPrioridad = New System.Windows.Forms.Label()
        Me.DTPFechaPactada = New System.Windows.Forms.DateTimePicker()
        Me.CheckBComite = New System.Windows.Forms.CheckBox()
        Me.CmbResponsable = New System.Windows.Forms.ComboBox()
        Me.CmbTipo = New System.Windows.Forms.ComboBox()
        Me.TxbCSI = New System.Windows.Forms.TextBox()
        Me.LblCsi = New System.Windows.Forms.Label()
        Me.LblTipo = New System.Windows.Forms.Label()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.CheckBFinalizado = New System.Windows.Forms.CheckBox()
        Me.LblFechaPac = New System.Windows.Forms.Label()
        Me.LblResponsable = New System.Windows.Forms.Label()
        Me.TxbObservaciones = New System.Windows.Forms.TextBox()
        Me.LblObservaciones = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblRazon = New System.Windows.Forms.Label()
        Me.LblCalificacion = New System.Windows.Forms.Label()
        Me.TxbRazon = New System.Windows.Forms.TextBox()
        Me.TxbCalificacion = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbEstado = New System.Windows.Forms.ComboBox()
        Me.CmbUsuario = New System.Windows.Forms.ComboBox()
        Me.LblFechaEntrega = New System.Windows.Forms.Label()
        Me.MskFechaEntrega = New System.Windows.Forms.MaskedTextBox()
        Me.LblNumSoporte = New System.Windows.Forms.Label()
        Me.TxbNumero = New System.Windows.Forms.TextBox()
        Me.LblUSuario = New System.Windows.Forms.Label()
        Me.LblFechaReq = New System.Windows.Forms.Label()
        Me.MskFechaReq = New System.Windows.Forms.MaskedTextBox()
        Me.LblFechaSug = New System.Windows.Forms.Label()
        Me.MskFechaSug = New System.Windows.Forms.MaskedTextBox()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.TxbDescripcion = New System.Windows.Forms.TextBox()
        Me.GbxComentarios = New System.Windows.Forms.GroupBox()
        Me.DgvComentarios = New System.Windows.Forms.DataGridView()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GbxComentarios.SuspendLayout()
        CType(Me.DgvComentarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LinkComentarios)
        Me.GroupBox3.Controls.Add(Me.LinkCicloAprobacion)
        Me.GroupBox3.Controls.Add(Me.LinkAdjuntos)
        Me.GroupBox3.Controls.Add(Me.CmbMotivo)
        Me.GroupBox3.Controls.Add(Me.LblMotivo)
        Me.GroupBox3.Controls.Add(Me.CmbModulo)
        Me.GroupBox3.Controls.Add(Me.LblModulo)
        Me.GroupBox3.Controls.Add(Me.CmbPrioridad)
        Me.GroupBox3.Controls.Add(Me.LblPrioridad)
        Me.GroupBox3.Controls.Add(Me.DTPFechaPactada)
        Me.GroupBox3.Controls.Add(Me.CheckBComite)
        Me.GroupBox3.Controls.Add(Me.CmbResponsable)
        Me.GroupBox3.Controls.Add(Me.CmbTipo)
        Me.GroupBox3.Controls.Add(Me.TxbCSI)
        Me.GroupBox3.Controls.Add(Me.LblCsi)
        Me.GroupBox3.Controls.Add(Me.LblTipo)
        Me.GroupBox3.Controls.Add(Me.BtnEnviar)
        Me.GroupBox3.Controls.Add(Me.CheckBFinalizado)
        Me.GroupBox3.Controls.Add(Me.LblFechaPac)
        Me.GroupBox3.Controls.Add(Me.LblResponsable)
        Me.GroupBox3.Controls.Add(Me.TxbObservaciones)
        Me.GroupBox3.Controls.Add(Me.LblObservaciones)
        Me.GroupBox3.Location = New System.Drawing.Point(420, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(418, 476)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "INFORMACIÓN A EDITAR"
        '
        'LinkComentarios
        '
        Me.LinkComentarios.AutoSize = True
        Me.LinkComentarios.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkComentarios.Location = New System.Drawing.Point(10, 196)
        Me.LinkComentarios.Name = "LinkComentarios"
        Me.LinkComentarios.Size = New System.Drawing.Size(110, 17)
        Me.LinkComentarios.TabIndex = 46
        Me.LinkComentarios.TabStop = True
        Me.LinkComentarios.Text = "COMENTARIOS"
        '
        'LinkCicloAprobacion
        '
        Me.LinkCicloAprobacion.AutoSize = True
        Me.LinkCicloAprobacion.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkCicloAprobacion.Location = New System.Drawing.Point(304, 195)
        Me.LinkCicloAprobacion.Name = "LinkCicloAprobacion"
        Me.LinkCicloAprobacion.Size = New System.Drawing.Size(102, 17)
        Me.LinkCicloAprobacion.TabIndex = 9
        Me.LinkCicloAprobacion.TabStop = True
        Me.LinkCicloAprobacion.Text = "APROBACIÓN"
        '
        'LinkAdjuntos
        '
        Me.LinkAdjuntos.AutoSize = True
        Me.LinkAdjuntos.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkAdjuntos.Location = New System.Drawing.Point(140, 196)
        Me.LinkAdjuntos.Name = "LinkAdjuntos"
        Me.LinkAdjuntos.Size = New System.Drawing.Size(142, 17)
        Me.LinkAdjuntos.TabIndex = 8
        Me.LinkAdjuntos.TabStop = True
        Me.LinkAdjuntos.Text = "ARCHIVO ADJUNTO"
        '
        'CmbMotivo
        '
        Me.CmbMotivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbMotivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbMotivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMotivo.FormattingEnabled = True
        Me.CmbMotivo.Location = New System.Drawing.Point(109, 160)
        Me.CmbMotivo.Name = "CmbMotivo"
        Me.CmbMotivo.Size = New System.Drawing.Size(215, 23)
        Me.CmbMotivo.TabIndex = 7
        '
        'LblMotivo
        '
        Me.LblMotivo.AutoSize = True
        Me.LblMotivo.Location = New System.Drawing.Point(17, 163)
        Me.LblMotivo.Name = "LblMotivo"
        Me.LblMotivo.Size = New System.Drawing.Size(39, 13)
        Me.LblMotivo.TabIndex = 45
        Me.LblMotivo.Text = "Motivo"
        '
        'CmbModulo
        '
        Me.CmbModulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbModulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbModulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbModulo.FormattingEnabled = True
        Me.CmbModulo.Location = New System.Drawing.Point(110, 132)
        Me.CmbModulo.Name = "CmbModulo"
        Me.CmbModulo.Size = New System.Drawing.Size(215, 23)
        Me.CmbModulo.TabIndex = 6
        '
        'LblModulo
        '
        Me.LblModulo.AutoSize = True
        Me.LblModulo.Location = New System.Drawing.Point(18, 135)
        Me.LblModulo.Name = "LblModulo"
        Me.LblModulo.Size = New System.Drawing.Size(42, 13)
        Me.LblModulo.TabIndex = 43
        Me.LblModulo.Text = "Módulo"
        '
        'CmbPrioridad
        '
        Me.CmbPrioridad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbPrioridad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbPrioridad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbPrioridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPrioridad.FormattingEnabled = True
        Me.CmbPrioridad.Location = New System.Drawing.Point(110, 105)
        Me.CmbPrioridad.Name = "CmbPrioridad"
        Me.CmbPrioridad.Size = New System.Drawing.Size(215, 23)
        Me.CmbPrioridad.TabIndex = 5
        '
        'LblPrioridad
        '
        Me.LblPrioridad.AutoSize = True
        Me.LblPrioridad.Location = New System.Drawing.Point(18, 108)
        Me.LblPrioridad.Name = "LblPrioridad"
        Me.LblPrioridad.Size = New System.Drawing.Size(48, 13)
        Me.LblPrioridad.TabIndex = 41
        Me.LblPrioridad.Text = "Prioridad"
        '
        'DTPFechaPactada
        '
        Me.DTPFechaPactada.Location = New System.Drawing.Point(109, 25)
        Me.DTPFechaPactada.Name = "DTPFechaPactada"
        Me.DTPFechaPactada.Size = New System.Drawing.Size(215, 20)
        Me.DTPFechaPactada.TabIndex = 40
        '
        'CheckBComite
        '
        Me.CheckBComite.AutoSize = True
        Me.CheckBComite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBComite.ForeColor = System.Drawing.Color.Black
        Me.CheckBComite.Location = New System.Drawing.Point(241, 406)
        Me.CheckBComite.Name = "CheckBComite"
        Me.CheckBComite.Size = New System.Drawing.Size(64, 17)
        Me.CheckBComite.TabIndex = 39
        Me.CheckBComite.Text = "Comité"
        Me.CheckBComite.UseVisualStyleBackColor = True
        '
        'CmbResponsable
        '
        Me.CmbResponsable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbResponsable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbResponsable.FormattingEnabled = True
        Me.CmbResponsable.Location = New System.Drawing.Point(109, 52)
        Me.CmbResponsable.Name = "CmbResponsable"
        Me.CmbResponsable.Size = New System.Drawing.Size(215, 23)
        Me.CmbResponsable.TabIndex = 3
        '
        'CmbTipo
        '
        Me.CmbTipo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTipo.FormattingEnabled = True
        Me.CmbTipo.Location = New System.Drawing.Point(109, 79)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.Size = New System.Drawing.Size(215, 23)
        Me.CmbTipo.TabIndex = 4
        '
        'TxbCSI
        '
        Me.TxbCSI.Location = New System.Drawing.Point(109, 313)
        Me.TxbCSI.Multiline = True
        Me.TxbCSI.Name = "TxbCSI"
        Me.TxbCSI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxbCSI.Size = New System.Drawing.Size(292, 79)
        Me.TxbCSI.TabIndex = 2
        '
        'LblCsi
        '
        Me.LblCsi.AutoSize = True
        Me.LblCsi.Location = New System.Drawing.Point(17, 348)
        Me.LblCsi.Name = "LblCsi"
        Me.LblCsi.Size = New System.Drawing.Size(65, 13)
        Me.LblCsi.TabIndex = 22
        Me.LblCsi.Text = "Para el Area"
        '
        'LblTipo
        '
        Me.LblTipo.AutoSize = True
        Me.LblTipo.Location = New System.Drawing.Point(17, 82)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(68, 13)
        Me.LblTipo.TabIndex = 20
        Me.LblTipo.Text = "Tipo Soporte"
        '
        'BtnEnviar
        '
        Me.BtnEnviar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnviar.Location = New System.Drawing.Point(127, 439)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(177, 26)
        Me.BtnEnviar.TabIndex = 37
        Me.BtnEnviar.Text = "Confirmar y Enviar"
        Me.BtnEnviar.UseVisualStyleBackColor = False
        '
        'CheckBFinalizado
        '
        Me.CheckBFinalizado.AutoSize = True
        Me.CheckBFinalizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBFinalizado.Location = New System.Drawing.Point(20, 404)
        Me.CheckBFinalizado.Name = "CheckBFinalizado"
        Me.CheckBFinalizado.Size = New System.Drawing.Size(168, 19)
        Me.CheckBFinalizado.TabIndex = 36
        Me.CheckBFinalizado.Text = "Requerimiento Finalizado"
        Me.CheckBFinalizado.UseVisualStyleBackColor = True
        '
        'LblFechaPac
        '
        Me.LblFechaPac.AutoSize = True
        Me.LblFechaPac.Location = New System.Drawing.Point(17, 25)
        Me.LblFechaPac.Name = "LblFechaPac"
        Me.LblFechaPac.Size = New System.Drawing.Size(80, 13)
        Me.LblFechaPac.TabIndex = 15
        Me.LblFechaPac.Text = "Fecha Pactada"
        '
        'LblResponsable
        '
        Me.LblResponsable.AutoSize = True
        Me.LblResponsable.Location = New System.Drawing.Point(17, 55)
        Me.LblResponsable.Name = "LblResponsable"
        Me.LblResponsable.Size = New System.Drawing.Size(69, 13)
        Me.LblResponsable.TabIndex = 16
        Me.LblResponsable.Text = "Responsable"
        '
        'TxbObservaciones
        '
        Me.TxbObservaciones.Location = New System.Drawing.Point(109, 223)
        Me.TxbObservaciones.Multiline = True
        Me.TxbObservaciones.Name = "TxbObservaciones"
        Me.TxbObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxbObservaciones.Size = New System.Drawing.Size(292, 79)
        Me.TxbObservaciones.TabIndex = 1
        '
        'LblObservaciones
        '
        Me.LblObservaciones.AutoSize = True
        Me.LblObservaciones.Location = New System.Drawing.Point(17, 256)
        Me.LblObservaciones.Name = "LblObservaciones"
        Me.LblObservaciones.Size = New System.Drawing.Size(78, 13)
        Me.LblObservaciones.TabIndex = 21
        Me.LblObservaciones.Text = "Observaciones"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblRazon)
        Me.GroupBox2.Controls.Add(Me.LblCalificacion)
        Me.GroupBox2.Controls.Add(Me.TxbRazon)
        Me.GroupBox2.Controls.Add(Me.TxbCalificacion)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 385)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(404, 103)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CALIFICACIÓN"
        '
        'LblRazon
        '
        Me.LblRazon.AutoSize = True
        Me.LblRazon.Location = New System.Drawing.Point(10, 62)
        Me.LblRazon.Name = "LblRazon"
        Me.LblRazon.Size = New System.Drawing.Size(38, 13)
        Me.LblRazon.TabIndex = 25
        Me.LblRazon.Text = "Razón"
        '
        'LblCalificacion
        '
        Me.LblCalificacion.AutoSize = True
        Me.LblCalificacion.Location = New System.Drawing.Point(9, 21)
        Me.LblCalificacion.Name = "LblCalificacion"
        Me.LblCalificacion.Size = New System.Drawing.Size(61, 13)
        Me.LblCalificacion.TabIndex = 23
        Me.LblCalificacion.Text = "Calificación"
        '
        'TxbRazon
        '
        Me.TxbRazon.Location = New System.Drawing.Point(76, 44)
        Me.TxbRazon.Multiline = True
        Me.TxbRazon.Name = "TxbRazon"
        Me.TxbRazon.ReadOnly = True
        Me.TxbRazon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxbRazon.Size = New System.Drawing.Size(221, 47)
        Me.TxbRazon.TabIndex = 26
        Me.TxbRazon.TabStop = False
        '
        'TxbCalificacion
        '
        Me.TxbCalificacion.Location = New System.Drawing.Point(76, 18)
        Me.TxbCalificacion.Name = "TxbCalificacion"
        Me.TxbCalificacion.ReadOnly = True
        Me.TxbCalificacion.Size = New System.Drawing.Size(128, 20)
        Me.TxbCalificacion.TabIndex = 24
        Me.TxbCalificacion.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbEstado)
        Me.GroupBox1.Controls.Add(Me.CmbUsuario)
        Me.GroupBox1.Controls.Add(Me.LblFechaEntrega)
        Me.GroupBox1.Controls.Add(Me.MskFechaEntrega)
        Me.GroupBox1.Controls.Add(Me.LblNumSoporte)
        Me.GroupBox1.Controls.Add(Me.TxbNumero)
        Me.GroupBox1.Controls.Add(Me.LblUSuario)
        Me.GroupBox1.Controls.Add(Me.LblFechaReq)
        Me.GroupBox1.Controls.Add(Me.MskFechaReq)
        Me.GroupBox1.Controls.Add(Me.LblFechaSug)
        Me.GroupBox1.Controls.Add(Me.MskFechaSug)
        Me.GroupBox1.Controls.Add(Me.LblEstado)
        Me.GroupBox1.Controls.Add(Me.LblDescripcion)
        Me.GroupBox1.Controls.Add(Me.TxbDescripcion)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 357)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMACION BASE"
        '
        'CmbEstado
        '
        Me.CmbEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbEstado.BackColor = System.Drawing.SystemColors.Control
        Me.CmbEstado.Enabled = False
        Me.CmbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEstado.FormattingEnabled = True
        Me.CmbEstado.Location = New System.Drawing.Point(316, 122)
        Me.CmbEstado.Name = "CmbEstado"
        Me.CmbEstado.Size = New System.Drawing.Size(79, 23)
        Me.CmbEstado.TabIndex = 51
        '
        'CmbUsuario
        '
        Me.CmbUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbUsuario.FormattingEnabled = True
        Me.CmbUsuario.Location = New System.Drawing.Point(126, 53)
        Me.CmbUsuario.Name = "CmbUsuario"
        Me.CmbUsuario.Size = New System.Drawing.Size(269, 23)
        Me.CmbUsuario.TabIndex = 10
        Me.CmbUsuario.TabStop = False
        '
        'LblFechaEntrega
        '
        Me.LblFechaEntrega.AutoSize = True
        Me.LblFechaEntrega.Location = New System.Drawing.Point(10, 132)
        Me.LblFechaEntrega.Name = "LblFechaEntrega"
        Me.LblFechaEntrega.Size = New System.Drawing.Size(89, 13)
        Me.LblFechaEntrega.TabIndex = 7
        Me.LblFechaEntrega.Text = "Fecha Entregada"
        '
        'MskFechaEntrega
        '
        Me.MskFechaEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskFechaEntrega.Location = New System.Drawing.Point(126, 128)
        Me.MskFechaEntrega.Mask = "00/00/0000"
        Me.MskFechaEntrega.Name = "MskFechaEntrega"
        Me.MskFechaEntrega.ReadOnly = True
        Me.MskFechaEntrega.Size = New System.Drawing.Size(79, 21)
        Me.MskFechaEntrega.TabIndex = 8
        Me.MskFechaEntrega.TabStop = False
        Me.MskFechaEntrega.ValidatingType = GetType(Date)
        '
        'LblNumSoporte
        '
        Me.LblNumSoporte.AutoSize = True
        Me.LblNumSoporte.Location = New System.Drawing.Point(10, 25)
        Me.LblNumSoporte.Name = "LblNumSoporte"
        Me.LblNumSoporte.Size = New System.Drawing.Size(99, 13)
        Me.LblNumSoporte.TabIndex = 0
        Me.LblNumSoporte.Text = "Número de Soporte"
        '
        'TxbNumero
        '
        Me.TxbNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbNumero.Location = New System.Drawing.Point(126, 19)
        Me.TxbNumero.Name = "TxbNumero"
        Me.TxbNumero.ReadOnly = True
        Me.TxbNumero.Size = New System.Drawing.Size(102, 21)
        Me.TxbNumero.TabIndex = 11
        Me.TxbNumero.TabStop = False
        '
        'LblUSuario
        '
        Me.LblUSuario.AutoSize = True
        Me.LblUSuario.Location = New System.Drawing.Point(10, 61)
        Me.LblUSuario.Name = "LblUSuario"
        Me.LblUSuario.Size = New System.Drawing.Size(43, 13)
        Me.LblUSuario.TabIndex = 2
        Me.LblUSuario.Text = "Usuario"
        '
        'LblFechaReq
        '
        Me.LblFechaReq.AutoSize = True
        Me.LblFechaReq.Location = New System.Drawing.Point(10, 94)
        Me.LblFechaReq.Name = "LblFechaReq"
        Me.LblFechaReq.Size = New System.Drawing.Size(108, 13)
        Me.LblFechaReq.TabIndex = 3
        Me.LblFechaReq.Text = "Fecha Requerimiento"
        '
        'MskFechaReq
        '
        Me.MskFechaReq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskFechaReq.Location = New System.Drawing.Point(126, 91)
        Me.MskFechaReq.Mask = "00/00/0000"
        Me.MskFechaReq.Name = "MskFechaReq"
        Me.MskFechaReq.ReadOnly = True
        Me.MskFechaReq.Size = New System.Drawing.Size(79, 21)
        Me.MskFechaReq.TabIndex = 4
        Me.MskFechaReq.TabStop = False
        Me.MskFechaReq.ValidatingType = GetType(Date)
        '
        'LblFechaSug
        '
        Me.LblFechaSug.AutoSize = True
        Me.LblFechaSug.Location = New System.Drawing.Point(221, 94)
        Me.LblFechaSug.Name = "LblFechaSug"
        Me.LblFechaSug.Size = New System.Drawing.Size(82, 13)
        Me.LblFechaSug.TabIndex = 5
        Me.LblFechaSug.Text = "Fecha Sugerida"
        '
        'MskFechaSug
        '
        Me.MskFechaSug.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskFechaSug.Location = New System.Drawing.Point(316, 90)
        Me.MskFechaSug.Mask = "00/00/0000"
        Me.MskFechaSug.Name = "MskFechaSug"
        Me.MskFechaSug.ReadOnly = True
        Me.MskFechaSug.Size = New System.Drawing.Size(79, 21)
        Me.MskFechaSug.TabIndex = 6
        Me.MskFechaSug.TabStop = False
        Me.MskFechaSug.ValidatingType = GetType(Date)
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Location = New System.Drawing.Point(221, 130)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(40, 13)
        Me.LblEstado.TabIndex = 9
        Me.LblEstado.Text = "Estado"
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.Location = New System.Drawing.Point(10, 235)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(60, 13)
        Me.LblDescripcion.TabIndex = 13
        Me.LblDescripcion.Text = "Descipción"
        '
        'TxbDescripcion
        '
        Me.TxbDescripcion.Location = New System.Drawing.Point(76, 162)
        Me.TxbDescripcion.Multiline = True
        Me.TxbDescripcion.Name = "TxbDescripcion"
        Me.TxbDescripcion.ReadOnly = True
        Me.TxbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxbDescripcion.Size = New System.Drawing.Size(319, 164)
        Me.TxbDescripcion.TabIndex = 14
        Me.TxbDescripcion.TabStop = False
        '
        'GbxComentarios
        '
        Me.GbxComentarios.Controls.Add(Me.DgvComentarios)
        Me.GbxComentarios.Font = New System.Drawing.Font("Bookman Old Style", 9.75!)
        Me.GbxComentarios.Location = New System.Drawing.Point(10, 494)
        Me.GbxComentarios.Name = "GbxComentarios"
        Me.GbxComentarios.Size = New System.Drawing.Size(828, 160)
        Me.GbxComentarios.TabIndex = 40
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvComentarios.DefaultCellStyle = DataGridViewCellStyle1
        Me.DgvComentarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvComentarios.Location = New System.Drawing.Point(3, 19)
        Me.DgvComentarios.Name = "DgvComentarios"
        Me.DgvComentarios.ReadOnly = True
        Me.DgvComentarios.Size = New System.Drawing.Size(822, 138)
        Me.DgvComentarios.TabIndex = 0
        '
        'Editar_tecnico_req
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(845, 666)
        Me.Controls.Add(Me.GbxComentarios)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Editar_tecnico_req"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SEsupport - Editar Requerimiento"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GbxComentarios.ResumeLayout(False)
        CType(Me.DgvComentarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBComite As System.Windows.Forms.CheckBox
    Friend WithEvents CmbResponsable As System.Windows.Forms.ComboBox
    Friend WithEvents CmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents TxbCSI As System.Windows.Forms.TextBox
    Friend WithEvents LblCsi As System.Windows.Forms.Label
    Friend WithEvents LblTipo As System.Windows.Forms.Label
    Friend WithEvents BtnEnviar As System.Windows.Forms.Button
    Friend WithEvents CheckBFinalizado As System.Windows.Forms.CheckBox
    Friend WithEvents LblFechaPac As System.Windows.Forms.Label
    Friend WithEvents LblResponsable As System.Windows.Forms.Label
    Friend WithEvents TxbObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents LblObservaciones As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LblRazon As System.Windows.Forms.Label
    Friend WithEvents LblCalificacion As System.Windows.Forms.Label
    Friend WithEvents TxbRazon As System.Windows.Forms.TextBox
    Friend WithEvents TxbCalificacion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents LblFechaEntrega As System.Windows.Forms.Label
    Friend WithEvents MskFechaEntrega As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LblNumSoporte As System.Windows.Forms.Label
    Friend WithEvents TxbNumero As System.Windows.Forms.TextBox
    Friend WithEvents LblUSuario As System.Windows.Forms.Label
    Friend WithEvents LblFechaReq As System.Windows.Forms.Label
    Friend WithEvents MskFechaReq As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LblFechaSug As System.Windows.Forms.Label
    Friend WithEvents MskFechaSug As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LblEstado As System.Windows.Forms.Label
    Friend WithEvents LblDescripcion As System.Windows.Forms.Label
    Friend WithEvents TxbDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents DTPFechaPactada As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbPrioridad As System.Windows.Forms.ComboBox
    Friend WithEvents LblPrioridad As System.Windows.Forms.Label
    Friend WithEvents CmbModulo As System.Windows.Forms.ComboBox
    Friend WithEvents LblModulo As System.Windows.Forms.Label
    Friend WithEvents CmbMotivo As System.Windows.Forms.ComboBox
    Friend WithEvents LblMotivo As System.Windows.Forms.Label
    Friend WithEvents CmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents LinkAdjuntos As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkCicloAprobacion As System.Windows.Forms.LinkLabel
    Friend WithEvents GbxComentarios As System.Windows.Forms.GroupBox
    Friend WithEvents DgvComentarios As System.Windows.Forms.DataGridView
    Friend WithEvents LinkComentarios As System.Windows.Forms.LinkLabel
End Class
