<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal_tecnico_req
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
        Me.DgvHistorico = New System.Windows.Forms.DataGridView()
        Me.IdhistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescusuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdmoduloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescmoduloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdprioridadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescprioridadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdestadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescestadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdtipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesctipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechageneracionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechasugeridaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaentregaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TecnicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesctecnicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalificacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacioncalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SolusuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoltecnicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservarcionreabrirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwhistincreqBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsConsultas = New SEsupport.DsConsultas()
        Me.Lblfiltro = New System.Windows.Forms.Label()
        Me.CmbFiltro = New System.Windows.Forms.ComboBox()
        Me.ReferenciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReferenciasTableAdapter = New SEsupport.DsConsultasTableAdapters.ReferenciasTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Vw_hist_inc_reqTableAdapter = New SEsupport.DsConsultasTableAdapters.vw_hist_inc_reqTableAdapter()
        CType(Me.DgvHistorico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwhistincreqBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReferenciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvHistorico
        '
        Me.DgvHistorico.AllowUserToAddRows = False
        Me.DgvHistorico.AllowUserToDeleteRows = False
        Me.DgvHistorico.AllowUserToOrderColumns = True
        Me.DgvHistorico.AutoGenerateColumns = False
        Me.DgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvHistorico.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdhistDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.DescusuarioDataGridViewTextBoxColumn, Me.IdmoduloDataGridViewTextBoxColumn, Me.DescmoduloDataGridViewTextBoxColumn, Me.IdprioridadDataGridViewTextBoxColumn, Me.DescprioridadDataGridViewTextBoxColumn, Me.IdestadoDataGridViewTextBoxColumn, Me.DescestadoDataGridViewTextBoxColumn, Me.IdtipoDataGridViewTextBoxColumn, Me.DesctipoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.FechageneracionDataGridViewTextBoxColumn, Me.FechasugeridaDataGridViewTextBoxColumn, Me.FechaentregaDataGridViewTextBoxColumn, Me.TecnicoDataGridViewTextBoxColumn, Me.DesctecnicoDataGridViewTextBoxColumn, Me.CalificacionDataGridViewTextBoxColumn, Me.ObservacioncalDataGridViewTextBoxColumn, Me.SolusuarioDataGridViewTextBoxColumn, Me.SoltecnicoDataGridViewTextBoxColumn, Me.ObservarcionreabrirDataGridViewTextBoxColumn})
        Me.DgvHistorico.DataSource = Me.VwhistincreqBindingSource
        Me.DgvHistorico.Location = New System.Drawing.Point(12, 83)
        Me.DgvHistorico.Name = "DgvHistorico"
        Me.DgvHistorico.ReadOnly = True
        Me.DgvHistorico.Size = New System.Drawing.Size(1044, 506)
        Me.DgvHistorico.TabIndex = 0
        '
        'IdhistDataGridViewTextBoxColumn
        '
        Me.IdhistDataGridViewTextBoxColumn.DataPropertyName = "Idhist"
        Me.IdhistDataGridViewTextBoxColumn.HeaderText = "Idhist"
        Me.IdhistDataGridViewTextBoxColumn.Name = "IdhistDataGridViewTextBoxColumn"
        Me.IdhistDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdhistDataGridViewTextBoxColumn.Visible = False
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsuarioDataGridViewTextBoxColumn.Visible = False
        '
        'DescusuarioDataGridViewTextBoxColumn
        '
        Me.DescusuarioDataGridViewTextBoxColumn.DataPropertyName = "desc_usuario"
        Me.DescusuarioDataGridViewTextBoxColumn.HeaderText = "desc_usuario"
        Me.DescusuarioDataGridViewTextBoxColumn.Name = "DescusuarioDataGridViewTextBoxColumn"
        Me.DescusuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdmoduloDataGridViewTextBoxColumn
        '
        Me.IdmoduloDataGridViewTextBoxColumn.DataPropertyName = "idmodulo"
        Me.IdmoduloDataGridViewTextBoxColumn.HeaderText = "idmodulo"
        Me.IdmoduloDataGridViewTextBoxColumn.Name = "IdmoduloDataGridViewTextBoxColumn"
        Me.IdmoduloDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdmoduloDataGridViewTextBoxColumn.Visible = False
        '
        'DescmoduloDataGridViewTextBoxColumn
        '
        Me.DescmoduloDataGridViewTextBoxColumn.DataPropertyName = "Desc_modulo"
        Me.DescmoduloDataGridViewTextBoxColumn.HeaderText = "Desc_modulo"
        Me.DescmoduloDataGridViewTextBoxColumn.Name = "DescmoduloDataGridViewTextBoxColumn"
        Me.DescmoduloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdprioridadDataGridViewTextBoxColumn
        '
        Me.IdprioridadDataGridViewTextBoxColumn.DataPropertyName = "idprioridad"
        Me.IdprioridadDataGridViewTextBoxColumn.HeaderText = "idprioridad"
        Me.IdprioridadDataGridViewTextBoxColumn.Name = "IdprioridadDataGridViewTextBoxColumn"
        Me.IdprioridadDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdprioridadDataGridViewTextBoxColumn.Visible = False
        '
        'DescprioridadDataGridViewTextBoxColumn
        '
        Me.DescprioridadDataGridViewTextBoxColumn.DataPropertyName = "desc_prioridad"
        Me.DescprioridadDataGridViewTextBoxColumn.HeaderText = "desc_prioridad"
        Me.DescprioridadDataGridViewTextBoxColumn.Name = "DescprioridadDataGridViewTextBoxColumn"
        Me.DescprioridadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdestadoDataGridViewTextBoxColumn
        '
        Me.IdestadoDataGridViewTextBoxColumn.DataPropertyName = "idestado"
        Me.IdestadoDataGridViewTextBoxColumn.HeaderText = "idestado"
        Me.IdestadoDataGridViewTextBoxColumn.Name = "IdestadoDataGridViewTextBoxColumn"
        Me.IdestadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdestadoDataGridViewTextBoxColumn.Visible = False
        '
        'DescestadoDataGridViewTextBoxColumn
        '
        Me.DescestadoDataGridViewTextBoxColumn.DataPropertyName = "desc_estado"
        Me.DescestadoDataGridViewTextBoxColumn.HeaderText = "desc_estado"
        Me.DescestadoDataGridViewTextBoxColumn.Name = "DescestadoDataGridViewTextBoxColumn"
        Me.DescestadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdtipoDataGridViewTextBoxColumn
        '
        Me.IdtipoDataGridViewTextBoxColumn.DataPropertyName = "idtipo"
        Me.IdtipoDataGridViewTextBoxColumn.HeaderText = "idtipo"
        Me.IdtipoDataGridViewTextBoxColumn.Name = "IdtipoDataGridViewTextBoxColumn"
        Me.IdtipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdtipoDataGridViewTextBoxColumn.Visible = False
        '
        'DesctipoDataGridViewTextBoxColumn
        '
        Me.DesctipoDataGridViewTextBoxColumn.DataPropertyName = "desc_tipo"
        Me.DesctipoDataGridViewTextBoxColumn.HeaderText = "desc_tipo"
        Me.DesctipoDataGridViewTextBoxColumn.Name = "DesctipoDataGridViewTextBoxColumn"
        Me.DesctipoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechageneracionDataGridViewTextBoxColumn
        '
        Me.FechageneracionDataGridViewTextBoxColumn.DataPropertyName = "fecha_generacion"
        Me.FechageneracionDataGridViewTextBoxColumn.HeaderText = "fecha_generacion"
        Me.FechageneracionDataGridViewTextBoxColumn.Name = "FechageneracionDataGridViewTextBoxColumn"
        Me.FechageneracionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechasugeridaDataGridViewTextBoxColumn
        '
        Me.FechasugeridaDataGridViewTextBoxColumn.DataPropertyName = "fecha_sugerida"
        Me.FechasugeridaDataGridViewTextBoxColumn.HeaderText = "fecha_sugerida"
        Me.FechasugeridaDataGridViewTextBoxColumn.Name = "FechasugeridaDataGridViewTextBoxColumn"
        Me.FechasugeridaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaentregaDataGridViewTextBoxColumn
        '
        Me.FechaentregaDataGridViewTextBoxColumn.DataPropertyName = "fecha_entrega"
        Me.FechaentregaDataGridViewTextBoxColumn.HeaderText = "fecha_entrega"
        Me.FechaentregaDataGridViewTextBoxColumn.Name = "FechaentregaDataGridViewTextBoxColumn"
        Me.FechaentregaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TecnicoDataGridViewTextBoxColumn
        '
        Me.TecnicoDataGridViewTextBoxColumn.DataPropertyName = "tecnico"
        Me.TecnicoDataGridViewTextBoxColumn.HeaderText = "tecnico"
        Me.TecnicoDataGridViewTextBoxColumn.Name = "TecnicoDataGridViewTextBoxColumn"
        Me.TecnicoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TecnicoDataGridViewTextBoxColumn.Visible = False
        '
        'DesctecnicoDataGridViewTextBoxColumn
        '
        Me.DesctecnicoDataGridViewTextBoxColumn.DataPropertyName = "desc_tecnico"
        Me.DesctecnicoDataGridViewTextBoxColumn.HeaderText = "desc_tecnico"
        Me.DesctecnicoDataGridViewTextBoxColumn.Name = "DesctecnicoDataGridViewTextBoxColumn"
        Me.DesctecnicoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CalificacionDataGridViewTextBoxColumn
        '
        Me.CalificacionDataGridViewTextBoxColumn.DataPropertyName = "calificacion"
        Me.CalificacionDataGridViewTextBoxColumn.HeaderText = "calificacion"
        Me.CalificacionDataGridViewTextBoxColumn.Name = "CalificacionDataGridViewTextBoxColumn"
        Me.CalificacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObservacioncalDataGridViewTextBoxColumn
        '
        Me.ObservacioncalDataGridViewTextBoxColumn.DataPropertyName = "observacion_cal"
        Me.ObservacioncalDataGridViewTextBoxColumn.HeaderText = "observacion_cal"
        Me.ObservacioncalDataGridViewTextBoxColumn.Name = "ObservacioncalDataGridViewTextBoxColumn"
        Me.ObservacioncalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SolusuarioDataGridViewTextBoxColumn
        '
        Me.SolusuarioDataGridViewTextBoxColumn.DataPropertyName = "sol_usuario"
        Me.SolusuarioDataGridViewTextBoxColumn.HeaderText = "sol_usuario"
        Me.SolusuarioDataGridViewTextBoxColumn.Name = "SolusuarioDataGridViewTextBoxColumn"
        Me.SolusuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SoltecnicoDataGridViewTextBoxColumn
        '
        Me.SoltecnicoDataGridViewTextBoxColumn.DataPropertyName = "sol_tecnico"
        Me.SoltecnicoDataGridViewTextBoxColumn.HeaderText = "sol_tecnico"
        Me.SoltecnicoDataGridViewTextBoxColumn.Name = "SoltecnicoDataGridViewTextBoxColumn"
        Me.SoltecnicoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObservarcionreabrirDataGridViewTextBoxColumn
        '
        Me.ObservarcionreabrirDataGridViewTextBoxColumn.DataPropertyName = "observarcion_reabrir"
        Me.ObservarcionreabrirDataGridViewTextBoxColumn.HeaderText = "observarcion_reabrir"
        Me.ObservarcionreabrirDataGridViewTextBoxColumn.Name = "ObservarcionreabrirDataGridViewTextBoxColumn"
        Me.ObservarcionreabrirDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VwhistincreqBindingSource
        '
        Me.VwhistincreqBindingSource.DataMember = "vw_hist_inc_req"
        Me.VwhistincreqBindingSource.DataSource = Me.DsConsultas
        '
        'DsConsultas
        '
        Me.DsConsultas.DataSetName = "DsConsultas"
        Me.DsConsultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Lblfiltro
        '
        Me.Lblfiltro.AutoSize = True
        Me.Lblfiltro.Location = New System.Drawing.Point(16, 15)
        Me.Lblfiltro.Name = "Lblfiltro"
        Me.Lblfiltro.Size = New System.Drawing.Size(29, 13)
        Me.Lblfiltro.TabIndex = 1
        Me.Lblfiltro.Text = "Filtro"
        '
        'CmbFiltro
        '
        Me.CmbFiltro.DataSource = Me.ReferenciasBindingSource
        Me.CmbFiltro.DisplayMember = "Desc_dato1"
        Me.CmbFiltro.FormattingEnabled = True
        Me.CmbFiltro.Location = New System.Drawing.Point(51, 12)
        Me.CmbFiltro.Name = "CmbFiltro"
        Me.CmbFiltro.Size = New System.Drawing.Size(135, 21)
        Me.CmbFiltro.TabIndex = 2
        Me.CmbFiltro.ValueMember = "Dato1"
        '
        'ReferenciasBindingSource
        '
        Me.ReferenciasBindingSource.DataMember = "Referencias"
        Me.ReferenciasBindingSource.DataSource = Me.DsConsultas
        '
        'ReferenciasTableAdapter
        '
        Me.ReferenciasTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(65, 44)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'Vw_hist_inc_reqTableAdapter
        '
        Me.Vw_hist_inc_reqTableAdapter.ClearBeforeFill = True
        '
        'Principal_tecnico_req
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 601)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbFiltro)
        Me.Controls.Add(Me.Lblfiltro)
        Me.Controls.Add(Me.DgvHistorico)
        Me.Name = "Principal_tecnico_req"
        Me.Text = "Principal_tecnico_req"
        CType(Me.DgvHistorico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwhistincreqBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReferenciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvHistorico As System.Windows.Forms.DataGridView
    Friend WithEvents Lblfiltro As System.Windows.Forms.Label
    Friend WithEvents CmbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents DsConsultas As SEsupport.DsConsultas
    Friend WithEvents ReferenciasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReferenciasTableAdapter As SEsupport.DsConsultasTableAdapters.ReferenciasTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents VwhistincreqBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vw_hist_inc_reqTableAdapter As SEsupport.DsConsultasTableAdapters.vw_hist_inc_reqTableAdapter
    Friend WithEvents IdhistDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescusuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdmoduloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescmoduloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdprioridadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescprioridadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdestadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescestadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdtipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesctipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechageneracionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechasugeridaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaentregaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TecnicoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesctecnicoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalificacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacioncalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SolusuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoltecnicoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservarcionreabrirDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
