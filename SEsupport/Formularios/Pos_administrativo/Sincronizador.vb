Imports vb = Microsoft.VisualBasic
Imports System.Globalization
Public Class Sincronizador
    Dim consultas As New Querys_pos_administrativo
    Dim dt_pos As New DataTable
    Dim noter, ip, comp, fecin, fecfn As String
    Private Sub Sincronizador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt_pos = consultas.consultar_pos()
        dt_pos.Rows.InsertAt(dt_pos.NewRow(), 0)
        Cmbpos.DataSource = dt_pos
        Cmbpos.DisplayMember = dt_pos.Columns(0).ToString()
        Cmbpos.ValueMember = dt_pos.Columns(1).ToString()
        Cmbpos.SelectedIndex = -1
        Cmbpos.Text = ""
        Cmbterminal.Text = ""
        txtnofacturas.Text = ""
        If (Today.Day <> "1") Then
            dtpfechainicial.Value = CDate(Today.Date.Year & "/" & Today.Date.Month & "/" & Today.Day - 1)
            dtpfechafinal.Value = CDate(Today.Date.Year & "/" & Today.Date.Month & "/" & Today.Day - 1)
        End If
        dtpfechainicial.MaxDate = DateTime.Now.Date
        dtpfechafinal.MaxDate = DateTime.Now.Date
        Usuario.Text = nombre
    End Sub

    Private Sub volverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles volverToolStripMenuItem.Click
        Inicio.Show()
        Me.Close()
    End Sub

    Private Sub POSAdministrativoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles POSAdministrativoToolStripMenuItem.Click
        conexion_pos = ip
        Dim respuesta As Boolean = consultas.probar_conexion(conexion_pos)
        If respuesta = True Then
            Pos_Administrativo.Show()
        Else
            MsgBox("No se estableció conexión con el punto de Venta.  Intente nuevamente mas tarde.  En caso de persistir el problema comunicarse con el área de sistemas", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub TransmisorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransmisorToolStripMenuItem.Click
        Dim nofac, nf2 As String
        Dim opc As Integer

        nofac = InputBox("Ingrese el número de factura a sincronizar", "Transmisor", "")
        If (nofac <> "") Then
            opc = MsgBox("¿Desea indicar el numero final?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo)
            If opc = 6 Then
                nf2 = InputBox("Ingrese el número de factura final a sincronizar", "Transmisor", "")
                consultas.cambiar_exportado(ip, nofac, nf2)
            Else
                consultas.cambiar_exportado(ip, nofac, "")
            End If


            MsgBox("Se volvió a transmitir la factura. Esto se verá reflejado en GyG la próxima vez que el punto de venta sincronicé", MsgBoxStyle.Information)
        End If
        btnconsultar.Enabled = True
    End Sub

    Private Sub btnsincronizar_Click(sender As Object, e As EventArgs) Handles btnsincronizar.Click
        Dim factsin As New DataTable
        'dgvfacturas.Rows.RemoveAt(tf)
        For Each row As DataGridViewRow In dgvfacturas.Rows
            'colocamos el numero de factura en exportado 0
            consultas.cambiar_exportado(ip, row.Cells(0).Value.ToString(), "")
        Next
        MsgBox("Se volvieron a transmitir las facturas. Esto se vera reflejado en GyG la proxima vez que el punto de venta sincronice", MsgBoxStyle.Information)

        'limpiar tabla
        dgvfacturas.Rows.Clear()
        'consulta de factura sin sincronizar y agregamos las facturas sin sincronizar a la tabla
        factsin = facturas_nosincronizadas()
        btnconsultar.Enabled = True
    End Sub

    Private Sub dtpfechainicial_ValueChanged(sender As Object, e As EventArgs) Handles dtpfechainicial.ValueChanged
        btnconsultar.Enabled = True
        limpiar()
    End Sub

    Private Sub dtpfechafinal_ValueChanged(sender As Object, e As EventArgs) Handles dtpfechafinal.ValueChanged
        btnconsultar.Enabled = True
        limpiar()
    End Sub

    Private Sub Cmbpos_SelectedValueChanged(sender As Object, e As EventArgs) Handles Cmbpos.SelectedValueChanged
        Dim dterm As New DataTable
        If Cmbpos.SelectedIndex > 0 Then
            Dim posel, pos, nompos, term, ct, v() As String
            posel = Cmbpos.Text
            ip = ""
            nompos = ""
            comp = ""
            term = ""
            ct = ""
            Cmbterminal.Text = ""
            txtip.Text = ""
            For Each row As DataRow In dt_pos.Rows
                pos = CStr(row("Descripcion").ToString)
                If posel = pos Then
                    ip = Convert.ToString(CStr(row("IP").ToString))
                    nompos = Convert.ToString(CStr(row("Descripcion").ToString))
                    comp = Convert.ToString(CStr(row("Compania").ToString))
                    term = Convert.ToString(vb.Right(nompos, 5))
                End If
                Cmbterminal.Text = ""
            Next
            If (term = "Ter 1") Then
                noter = "TERMINAL 1"
                v = nompos.Split(" ")
                If (v(2).Substring(0, 3) = "Ter") Then
                    nompos = v(0).Substring(0, 6) + " " + v(1).Substring(0, 8)
                Else
                    nompos = v(0).Substring(0, v(0).Length) + " " + v(1).Substring(0, v(1).Length)
                    nompos = nompos + " " + v(2).Substring(0, v(2).Length)
                End If
                'consultar valor de la venta 
            Else
                If (term = "Ter 2") Then
                    noter = "TERMINAL 2"
                    nompos = vb.Left(nompos, 18)
                    v = nompos.Split(" ")
                    If (v(2).Substring(0, 2) = "T" Or v(2).Substring(0, 2) = "Te") Then
                        nompos = v(0).Substring(0, 6) + " " + v(1).Substring(0, 8)
                    End If
                Else
                    noter = "TERMINAL 1"
                End If
            End If
            If (comp <> "" And nompos <> "" And noter <> "") Then
                dterm = consultas.consultar_terminal(comp, nompos, noter)
                For Each row As DataRow In dterm.Rows
                    ct = row(0).ToString 'codigo terminal
                Next
                Cmbpos.Text = nompos
                Cmbterminal.Text = ct
                txtventapos.Text = ""
                txtventaserver.Text = ""
                txtdiferencia.Text = ""
                dgvfacturas.Rows.Clear()
                Dim respuesta As Boolean = consultas.probar_conexion(ip) ' probramos conexion del pos 
                If respuesta = False Then
                    MsgBox("No se estableció conexión con el punto de Venta, verifique la conexión e intente nuevamente. En caso de persistir el problema comunicarse con el área de sistemas", MsgBoxStyle.Critical)
                End If
            End If
        End If
        txtip.Text = ip
        btnconsultar.Enabled = True
    End Sub

    Private Sub limpiar()
        txtventapos.Text = ""
        txtventaserver.Text = ""
        txtdiferencia.Text = ""
    End Sub

    Private Sub btnconsultar_Click(sender As Object, e As EventArgs) Handles btnconsultar.Click
        limpiar()
        dgvfacturas.Rows.Clear()
        txtnofacturas.Text = "0"
        Dim ventap, ventasv, factsin As New DataTable
        Dim d1, d2 As Date
        Dim totalp, totals, df As String
        Dim vi(), vf(), v() As String
        d1 = dtpfechainicial.Value.Date
        d2 = dtpfechafinal.Value.Date
        totalp = ""
        totals = ""
        fecin = FormatDateTime(d1, DateFormat.ShortDate)
        vi = fecin.Split("/")
        fecin = vi(2).Substring(0, 4) + vi(1).Substring(0, 2) + vi(0).Substring(0, 2)
        If (d1 <> d2) Then
            fecfn = FormatDateTime(d2, DateFormat.ShortDate)
            vf = fecfn.Split("/")
            fecfn = vf(2).Substring(0, 4) + vf(1).Substring(0, 2) + vf(0).Substring(0, 2)
        Else
            fecfn = ""
        End If
        'consultamos las ventas en el POS
        ventap = consultas.consultar_ventapos(ip, fecin, fecfn)
        For Each row As DataRow In ventap.Rows
            totalp = row(0).ToString
        Next
        If (totalp = "") Then
            txtventapos.Text = "0"
            totalp = "0"
        Else
            v = totalp.Split(".")
            txtventapos.Text = v(0)
        End If
        'consultamos las ventas en el servidor
        ventasv = consultas.consultar_ventaserv(comp, Cmbterminal.Text, fecin, fecfn)
        For Each row As DataRow In ventasv.Rows
            totals = row(0).ToString
        Next
        If (totals = "") Then
            txtventaserver.Text = "0"
            totals = "0"
        Else
            v = totals.Split(".")
            txtventaserver.Text = v(0)
        End If
        df = totalp - totals
        txtdiferencia.Text = df
        If (df = 0) Then
            btnsincronizar.Enabled = False
        Else
            btnsincronizar.Enabled = True
        End If
        'consulta de factura sin sincronizar y agregamos las facturas sin sincronizar a la tabla
        facturas_nosincronizadas()
        txtnofacturas.Text = dgvfacturas.Rows.Count()
        btnconsultar.Enabled = False
    End Sub
    Public Function facturas_nosincronizadas()
        Dim factsin As New DataTable
        'consulta de factura sin sincronizar
        factsin = consultas.consultar_factnosin(comp, Cmbterminal.Text, fecin, fecfn, ip)
        'agregamos las facturas sin sincronizar a la tabla
        Dim fila As Integer = 0
        For Each row As DataRow In factsin.Rows
            dgvfacturas.Rows.Add()
            dgvfacturas.Rows(fila).Cells(0).Value = row.Item(0)
            dgvfacturas.Rows(fila).Cells(1).Value = row.Item(1)
            dgvfacturas.Rows(fila).Cells(2).Value = row.Item(2)
            dgvfacturas.Rows(fila).Cells(3).Value = row.Item(3)
            fila = fila + 1
        Next
        dgvfacturas.AllowUserToAddRows = False
        Return factsin
    End Function
End Class