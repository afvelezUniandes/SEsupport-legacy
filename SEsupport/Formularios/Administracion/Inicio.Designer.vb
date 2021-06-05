<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.BtnQuejas = New System.Windows.Forms.Button()
        Me.BtnIncidentes = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearHorarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarHorariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoNovedadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministraciónToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalendarioFestivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.POSAdministrativoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgotadosposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.POSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SincronizadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContabilidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADMINGENERALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PERMISOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnInventario = New System.Windows.Forms.Button()
        Me.Btncodean = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnQuejas
        '
        Me.BtnQuejas.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuejas.Location = New System.Drawing.Point(306, 45)
        Me.BtnQuejas.Name = "BtnQuejas"
        Me.BtnQuejas.Size = New System.Drawing.Size(165, 66)
        Me.BtnQuejas.TabIndex = 1
        Me.BtnQuejas.Text = "QUEJAS Y NO CONFORMIDADES"
        Me.BtnQuejas.UseVisualStyleBackColor = True
        '
        'BtnIncidentes
        '
        Me.BtnIncidentes.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIncidentes.Location = New System.Drawing.Point(60, 45)
        Me.BtnIncidentes.Name = "BtnIncidentes"
        Me.BtnIncidentes.Size = New System.Drawing.Size(163, 66)
        Me.BtnIncidentes.TabIndex = 0
        Me.BtnIncidentes.Text = "INCIDENTES Y REQUERIMIENTOS"
        Me.BtnIncidentes.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministraciónToolStripMenuItem, Me.HorariosToolStripMenuItem, Me.POSAdministrativoToolStripMenuItem, Me.ContabilidadToolStripMenuItem, Me.ADMINGENERALToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(542, 27)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministraciónToolStripMenuItem
        '
        Me.AdministraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarUsuarioToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.AdministraciónToolStripMenuItem.Name = "AdministraciónToolStripMenuItem"
        Me.AdministraciónToolStripMenuItem.Size = New System.Drawing.Size(112, 23)
        Me.AdministraciónToolStripMenuItem.Text = "Administración"
        '
        'CambiarUsuarioToolStripMenuItem
        '
        Me.CambiarUsuarioToolStripMenuItem.Name = "CambiarUsuarioToolStripMenuItem"
        Me.CambiarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.CambiarUsuarioToolStripMenuItem.Text = "Cambiar Usuario"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'HorariosToolStripMenuItem
        '
        Me.HorariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearHorarioToolStripMenuItem, Me.ConsultarHorariosToolStripMenuItem, Me.IngresoNovedadesToolStripMenuItem, Me.AdministraciónToolStripMenuItem1})
        Me.HorariosToolStripMenuItem.Name = "HorariosToolStripMenuItem"
        Me.HorariosToolStripMenuItem.Size = New System.Drawing.Size(73, 23)
        Me.HorariosToolStripMenuItem.Text = "Horarios"
        '
        'CrearHorarioToolStripMenuItem
        '
        Me.CrearHorarioToolStripMenuItem.Name = "CrearHorarioToolStripMenuItem"
        Me.CrearHorarioToolStripMenuItem.Size = New System.Drawing.Size(196, 24)
        Me.CrearHorarioToolStripMenuItem.Text = "Crear Horario"
        '
        'ConsultarHorariosToolStripMenuItem
        '
        Me.ConsultarHorariosToolStripMenuItem.Name = "ConsultarHorariosToolStripMenuItem"
        Me.ConsultarHorariosToolStripMenuItem.Size = New System.Drawing.Size(196, 24)
        Me.ConsultarHorariosToolStripMenuItem.Text = "Consultar Horarios"
        '
        'IngresoNovedadesToolStripMenuItem
        '
        Me.IngresoNovedadesToolStripMenuItem.Name = "IngresoNovedadesToolStripMenuItem"
        Me.IngresoNovedadesToolStripMenuItem.Size = New System.Drawing.Size(196, 24)
        Me.IngresoNovedadesToolStripMenuItem.Text = "Ingreso Novedades"
        '
        'AdministraciónToolStripMenuItem1
        '
        Me.AdministraciónToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TurnosToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.AreasToolStripMenuItem, Me.CalendarioFestivosToolStripMenuItem})
        Me.AdministraciónToolStripMenuItem1.Name = "AdministraciónToolStripMenuItem1"
        Me.AdministraciónToolStripMenuItem1.Size = New System.Drawing.Size(196, 24)
        Me.AdministraciónToolStripMenuItem1.Text = "Administración"
        '
        'TurnosToolStripMenuItem
        '
        Me.TurnosToolStripMenuItem.Name = "TurnosToolStripMenuItem"
        Me.TurnosToolStripMenuItem.Size = New System.Drawing.Size(196, 24)
        Me.TurnosToolStripMenuItem.Text = "Turnos"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(196, 24)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'AreasToolStripMenuItem
        '
        Me.AreasToolStripMenuItem.Name = "AreasToolStripMenuItem"
        Me.AreasToolStripMenuItem.Size = New System.Drawing.Size(196, 24)
        Me.AreasToolStripMenuItem.Text = "Áreas"
        '
        'CalendarioFestivosToolStripMenuItem
        '
        Me.CalendarioFestivosToolStripMenuItem.Name = "CalendarioFestivosToolStripMenuItem"
        Me.CalendarioFestivosToolStripMenuItem.Size = New System.Drawing.Size(196, 24)
        Me.CalendarioFestivosToolStripMenuItem.Text = "Calendario Festivos"
        '
        'POSAdministrativoToolStripMenuItem
        '
        Me.POSAdministrativoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgotadosposToolStripMenuItem, Me.POSToolStripMenuItem, Me.SincronizadorToolStripMenuItem})
        Me.POSAdministrativoToolStripMenuItem.Name = "POSAdministrativoToolStripMenuItem"
        Me.POSAdministrativoToolStripMenuItem.Size = New System.Drawing.Size(140, 23)
        Me.POSAdministrativoToolStripMenuItem.Text = "POS Administrativo"
        '
        'AgotadosposToolStripMenuItem
        '
        Me.AgotadosposToolStripMenuItem.Name = "AgotadosposToolStripMenuItem"
        Me.AgotadosposToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.AgotadosposToolStripMenuItem.Text = "Agotados POS"
        '
        'POSToolStripMenuItem
        '
        Me.POSToolStripMenuItem.Name = "POSToolStripMenuItem"
        Me.POSToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.POSToolStripMenuItem.Text = "POS"
        '
        'SincronizadorToolStripMenuItem
        '
        Me.SincronizadorToolStripMenuItem.Name = "SincronizadorToolStripMenuItem"
        Me.SincronizadorToolStripMenuItem.Size = New System.Drawing.Size(167, 24)
        Me.SincronizadorToolStripMenuItem.Text = "Sincronizador"
        '
        'ContabilidadToolStripMenuItem
        '
        Me.ContabilidadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PagosToolStripMenuItem})
        Me.ContabilidadToolStripMenuItem.Name = "ContabilidadToolStripMenuItem"
        Me.ContabilidadToolStripMenuItem.Size = New System.Drawing.Size(98, 23)
        Me.ContabilidadToolStripMenuItem.Text = "Contabilidad"
        '
        'PagosToolStripMenuItem
        '
        Me.PagosToolStripMenuItem.Name = "PagosToolStripMenuItem"
        Me.PagosToolStripMenuItem.Size = New System.Drawing.Size(115, 24)
        Me.PagosToolStripMenuItem.Text = "Pagos"
        '
        'ADMINGENERALToolStripMenuItem
        '
        Me.ADMINGENERALToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.PERMISOSToolStripMenuItem})
        Me.ADMINGENERALToolStripMenuItem.Name = "ADMINGENERALToolStripMenuItem"
        Me.ADMINGENERALToolStripMenuItem.Size = New System.Drawing.Size(112, 23)
        Me.ADMINGENERALToolStripMenuItem.Text = "Admin General"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuarioToolStripMenuItem, Me.ToolStripMenuItem3})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(132, 24)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(203, 24)
        Me.UsuarioToolStripMenuItem.Text = "Crear Usuario"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(203, 24)
        Me.ToolStripMenuItem3.Text = "Cambiar Contraseña"
        '
        'PERMISOSToolStripMenuItem
        '
        Me.PERMISOSToolStripMenuItem.Name = "PERMISOSToolStripMenuItem"
        Me.PERMISOSToolStripMenuItem.Size = New System.Drawing.Size(132, 24)
        Me.PERMISOSToolStripMenuItem.Text = "Permisos"
        '
        'BtnInventario
        '
        Me.BtnInventario.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInventario.Location = New System.Drawing.Point(60, 134)
        Me.BtnInventario.Name = "BtnInventario"
        Me.BtnInventario.Size = New System.Drawing.Size(163, 66)
        Me.BtnInventario.TabIndex = 4
        Me.BtnInventario.Text = "INVENTARIOS SANTA ELENA"
        Me.BtnInventario.UseVisualStyleBackColor = True
        '
        'Btncodean
        '
        Me.Btncodean.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncodean.Location = New System.Drawing.Point(306, 134)
        Me.Btncodean.Name = "Btncodean"
        Me.Btncodean.Size = New System.Drawing.Size(163, 66)
        Me.Btncodean.TabIndex = 5
        Me.Btncodean.Text = "CODIGOS DE BARRAS"
        Me.Btncodean.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 214)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(542, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(542, 322)
        Me.Controls.Add(Me.Btncodean)
        Me.Controls.Add(Me.BtnInventario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnIncidentes)
        Me.Controls.Add(Me.BtnQuejas)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SEsupport - Inicio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnQuejas As System.Windows.Forms.Button
    Friend WithEvents BtnIncidentes As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdministraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnInventario As System.Windows.Forms.Button
    Friend WithEvents ADMINGENERALToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PERMISOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HorariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearHorarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarHorariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresoNovedadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministraciónToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AreasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalendarioFestivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents POSAdministrativoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btncodean As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ContabilidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents POSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SincronizadorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgotadosposToolStripMenuItem As ToolStripMenuItem
End Class
