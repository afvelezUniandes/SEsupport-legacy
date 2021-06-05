Public Class Pagos_provee
    Dim pos, ppago, ptap, pcta, ptd, ptt, pbc, tf As Integer
    Dim tp, ap, cta, cc, tt, bc, fecha As String
    Dim dtbanco As New DataTable
    Private Sub Pagos_provee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim funciones As New Funciones_generales
        Usuario.Text = nombre
        txtnit.Show()
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(3).Visible = False
        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(7).Visible = False
        DataGridView1.Columns(9).Visible = False
        DataGridView1.Columns(13).Visible = False
        DataGridView1.Columns(14).Visible = False
        DataGridView1.Columns(16).Visible = False
        cbxaplicacion.SelectedIndex = 0
        Try
            dtbanco.Rows.InsertAt(dtbanco.NewRow(), 0)
            dtbanco = funciones.cons_banco("")
            cbxcban.DataSource = dtbanco
            cbxcban.DisplayMember = dtbanco.Columns(1).ToString()
            cbxcban.ValueMember = dtbanco.Columns(0).ToString()
            cbxcban.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnimport.Click
        DataGridView1.Columns.Clear()
        importarExcel(DataGridView1)
        btnadd.Enabled = False
    End Sub
    Private Sub btnimpor_Click(sender As Object, e As EventArgs) Handles btnclean.Click
        Try
            DataGridView1.Rows.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        limpiar()
        tf = DataGridView1.RowCount()
    End Sub
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnsend.Click
        llenarExcel(DataGridView1)
    End Sub
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        tf = DataGridView1.RowCount()
        If (pos = 0) Then
            ppago = cbxtpago.SelectedIndex
            ptap = cbxaplicacion.SelectedIndex
            pcta = cbxtcta.SelectedIndex
            ptd = cbxtdoc.SelectedIndex
            ptt = cbxttran.SelectedIndex
            pbc = cbxcban.SelectedIndex
            tp = mtpago(ppago)
            ap = mtaplica(ptap)
            cta = mtcta(pcta)
            cc = mtdoc(ptd)
            tt = mttrans(ptt)
            bc = mtbanco(cbxcban.SelectedValue)
            Dim fc As Date
            fc = dtpfecha.Value
            fecha = Format(fc, "yyyy-MM-dd")
            If (txtnit.Text = "" Or cbxtpago.SelectedIndex.Equals("") Or cbxaplicacion.SelectedIndex.Equals("") Or txtsecuencia.Text = "" Or txtnoctaben.Text = "" Or cbxtcta.SelectedIndex.Equals("") Or cbxtdoc.SelectedIndex.Equals("") Or txtnitben.Text = "" Or cbxttran.SelectedIndex.Equals("") Or cbxcban.SelectedIndex.Equals("") Or txtnoctaben.Text = "" Or txtvalor.Text = "") Then
                MessageBox.Show("Hay campos obligatorios vacios", "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Me.DataGridView1.Rows.Add(txtnit.Text, tp, ap, txtsecuencia.Text, txtnocuenta.Text, cta, txtdesc.Text, cc,
                    txtnitben.Text, txtnomben.Text, tt, bc, txtnoctaben.Text, txtemail.Text, txtdocaut.Text,
                    txtref.Text, txtofentre.Text, txtvalor.Text, fecha)
            End If
        Else
            Me.DataGridView1(0, pos).Value = txtnit.Text
            Me.DataGridView1(0, pos).Value = tp
            Me.DataGridView1(0, pos).Value = ap
            Me.DataGridView1(0, pos).Value = txtsecuencia.Text
            Me.DataGridView1(0, pos).Value = txtnocuenta.Text
            Me.DataGridView1(0, pos).Value = cta
            Me.DataGridView1(0, pos).Value = txtdesc.Text
            Me.DataGridView1(0, pos).Value = cc
            Me.DataGridView1(0, pos).Value = txtnitben.Text
            Me.DataGridView1(0, pos).Value = txtnomben.Text
            Me.DataGridView1(0, pos).Value = tt
            Me.DataGridView1(0, pos).Value = bc
            Me.DataGridView1(0, pos).Value = txtnoctaben.Text
            Me.DataGridView1(0, pos).Value = txtemail.Text
            Me.DataGridView1(0, pos).Value = txtdocaut.Text
            Me.DataGridView1(0, pos).Value = txtref.Text
            Me.DataGridView1(0, pos).Value = txtofentre.Text
            Me.DataGridView1(0, pos).Value = txtvalor.Text
            Me.DataGridView1(0, pos).Value = fecha
        End If
        limpiar()
        btnadd.Enabled = False
        desactivar()
    End Sub
    Private Function mtpago(opp As Integer) As String
        Dim tp As String
        'aqui empieza 
        tp = ""
        Select Case opp
            Case 1
                tp = "225"
            Case 2
                tp = "220"
            Case Else
                If (tp = "") Then
                    MessageBox.Show("Seleccione un tipo de pago valido")
                End If
        End Select
        Return tp
        'aqui termina
    End Function
    Private Function mtaplica(opa As Integer) As String
        Dim ap As String
        ap = ""
        Select Case opa
            Case 0
                ap = "I"
            Case Else
                If (ap = "") Then
                    MessageBox.Show("Seleccione una aplicación valida")
                End If
        End Select
        Return ap
    End Function
    Private Function mtcta(opc As Integer) As String
        Dim cta As String
        cta = ""
        Select Case opc
            Case 1
                cta = "S"
            Case 2
                cta = "D"
            Case Else
                If (cta = "") Then
                    MessageBox.Show("Seleccione un tipo de cuenta valida")
                End If
        End Select
        Return cta
    End Function
    Private Function mtdoc(occ As Integer) As String
        Dim cc As String
        cc = ""
        Select Case occ
            Case 1
                cc = "1"
            Case 2
                cc = "2"
            Case 3
                cc = "3"
            Case 4
                cc = "4"
            Case 5
                cc = "5"
            Case Else
                If (cc = "") Then
                    MessageBox.Show("Seleccione un tipo de documento valido")
                End If
        End Select
        Return cc
    End Function
    Private Function mttrans(ott As Integer) As String
        Dim tt As String
        tt = ""
        Select Case ott
            Case 1
                tt = "37"
            Case 2
                tt = "27"
            Case Else
                If (tt = "") Then
                    MessageBox.Show("Seleccione un tipo de transacción valido")
                End If
        End Select
        Return tt
    End Function
    Private Function mtbanco(opb As Integer) As String
        Dim bc As String
        bc = ""
        If (opb.Equals("")) Then
            MessageBox.Show("Seleccione un banco")
        Else
            If (opb > 0 And opb < 10) Then
                bc = "0" + opb.ToString
            Else
                bc = opb
            End If
        End If
        Return bc
    End Function
    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        limpiar()
        rescolor()
        activar()
        btnadd.Enabled = True
        btnmod.Enabled = False
    End Sub
    Private Sub limpiar()
        txtnit.Text = ""
        cbxtpago.SelectedIndex = 0
        cbxaplicacion.SelectedIndex = 0
        txtsecuencia.Text = ""
        txtnocuenta.Text = ""
        cbxtcta.SelectedIndex = 0
        txtdesc.Text = ""
        cbxtdoc.SelectedIndex = 0
        txtnitben.Text = ""
        txtnomben.Text = ""
        cbxttran.SelectedIndex = 0
        cbxcban.Text = ""
        txtnoctaben.Text = ""
        txtemail.Text = ""
        txtdocaut.Text = ""
        txtref.Text = ""
        txtofentre.Text = ""
        txtvalor.Text = ""
        dtpfecha.Text = Now.ToLongDateString
    End Sub
    Private Sub desactivar()
        txtnit.Enabled = False
        cbxtpago.Enabled = False
        cbxaplicacion.Enabled = False
        txtsecuencia.Enabled = False
        txtnocuenta.Enabled = False
        cbxtcta.Enabled = False
        txtdesc.Enabled = False
        cbxtdoc.Enabled = False
        txtnitben.Enabled = False
        txtnomben.Enabled = False
        cbxttran.Enabled = False
        cbxcban.Enabled = False
        txtnoctaben.Enabled = False
        txtemail.Enabled = False
        txtdocaut.Enabled = False
        txtref.Enabled = False
        txtofentre.Enabled = False
        txtvalor.Enabled = False
    End Sub
    Private Sub activar()
        txtnit.Enabled = True
        cbxtpago.Enabled = True
        cbxaplicacion.Enabled = True
        txtsecuencia.Enabled = True
        txtnocuenta.Enabled = True
        cbxtcta.Enabled = True
        txtdesc.Enabled = True
        cbxtdoc.Enabled = True
        txtnitben.Enabled = True
        txtnomben.Enabled = True
        cbxttran.Enabled = True
        cbxcban.Enabled = True
        txtnoctaben.Enabled = True
        txtemail.Enabled = True
        txtdocaut.Enabled = True
        txtref.Enabled = True
        txtofentre.Enabled = True
        txtvalor.Enabled = True
    End Sub
    Private Sub rescolor()
        Label1.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label3.ForeColor = Color.Black
        Label4.ForeColor = Color.Black
        Label5.ForeColor = Color.Black
        Label7.ForeColor = Color.Black
        Label8.ForeColor = Color.Black
        Label10.ForeColor = Color.Black
        Label11.ForeColor = Color.Black
        Label12.ForeColor = Color.Black
        Label14.Text = "Doc_Autorizado:"
        Label14.ForeColor = Color.Black
        Label17.ForeColor = Color.Black
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Proveedores.Show()
    End Sub

    Private Sub txtnit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnit.KeyPress
        If (txtnit.Text = "") Then
            Label1.ForeColor = Color.Red
        Else
            Label1.ForeColor = Color.Black
        End If
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "-" And Not txtnit.Text.IndexOf("-") Then
            e.Handled = True
        ElseIf e.KeyChar = "-" Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Solo se permite ingresar números y dígito de verificación", "Validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub txtnitben_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnitben.KeyPress
        Dim funciones_generales As New Funciones_generales
        Dim dtcliente As New DataTable
        Dim nit As String
        If (Asc(e.KeyChar) = 13) Then
            If (txtnitben.Text = "") Then
                Label8.ForeColor = Color.Red
            Else
                Label8.ForeColor = Color.Black
                nit = txtnitben.Text
                dtcliente = funciones_generales.cons_cliente(nit)

                If dtcliente.Rows.Count > 0 Then
                    txtnomben.Text = dtcliente.Rows(0)(0).ToString()
                    txtemail.Text = dtcliente.Rows(0)(1).ToString()
                End If
            End If
        End If
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "-" And Not txtnit.Text.IndexOf("-") Then
            e.Handled = True
        ElseIf e.KeyChar = "-" Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Solo se permite ingresar números y dígito de verificación", "Validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub txtnomben_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnomben.KeyPress
        If (txtnomben.Text = "") Then
            Label9.ForeColor = Color.Red
        Else
            Label9.ForeColor = Color.Black
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Solo se permite ingresar letras y espacios", "Validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub txtnocuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnocuenta.KeyPress
        If (txtnocuenta.Text = "") Then
            Label2.ForeColor = Color.Red
        Else
            Label2.ForeColor = Color.Black
        End If
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Solo se permite ingresar números y dígito de verificación", "Validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub txtnoctaben_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnoctaben.KeyPress
        If (txtnoctaben.Text = "") Then
            Label12.ForeColor = Color.Red
        Else
            Label12.ForeColor = Color.Black
        End If
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Solo se permite ingresar números y dígito de verificación", "Validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub volverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles volverToolStripMenuItem.Click
        Inicio.Show()
        Me.Close()
    End Sub
    Private Sub Usuario_Click(sender As Object, e As EventArgs) Handles Usuario.Click
        Dim out As Integer = MsgBox("¿Desea cerrar su sesión y salir?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation)
        If (out = 6) Then
            Login.Show()
            Me.Close()
        End If
    End Sub
    Private Sub txtdocaut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdocaut.KeyPress
        If (txtdocaut.Text = "") Then
            Label14.ForeColor = Color.Red
        Else
            Label14.ForeColor = Color.Black
        End If
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Solo se permite ingresar números y dígito de verificación", "Validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub txtofentre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtofentre.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Solo se permite ingresar números y dígito de verificación", "Validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub txtvalor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtvalor.KeyPress
        If (txtvalor.Text = "") Then
            Label17.ForeColor = Color.Red
        Else
            Label17.ForeColor = Color.Black
        End If
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Solo se permite ingresar números y dígito de verificación", "Validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub txtofentre_TextChanged(sender As Object, e As EventArgs) Handles txtofentre.TextChanged
        If (txtdocaut.Text = "") Then
            txtofentre.Text = ""
            Label14.Text = "*Doc_Autorizado:"
            txtdocaut.Focus()
            Label14.ForeColor = Color.Red
        End If
    End Sub
    Private Sub btnmod_Click(sender As Object, e As EventArgs) Handles btnmod.Click
        activar()
        'DataGridView1.Rows.Clear()
        DataGridView1(0, pos).Value = txtnit.Text
        DataGridView1(1, pos).Value = tp
        DataGridView1(2, pos).Value = ap
        DataGridView1(3, pos).Value = txtsecuencia.Text
        DataGridView1(4, pos).Value = txtnocuenta.Text
        DataGridView1(5, pos).Value = cta
        DataGridView1(6, pos).Value = txtdesc.Text
        DataGridView1(7, pos).Value = cc
        DataGridView1(8, pos).Value = txtnitben.Text
        DataGridView1(9, pos).Value = txtnomben.Text
        DataGridView1(10, pos).Value = tt
        pbc = cbxcban.SelectedIndex
        DataGridView1(11, pos).Value = mtbanco(cbxcban.SelectedValue)
        DataGridView1(12, pos).Value = txtnoctaben.Text
        DataGridView1(13, pos).Value = txtemail.Text
        DataGridView1(14, pos).Value = txtdocaut.Text
        DataGridView1(15, pos).Value = txtref.Text
        DataGridView1(16, pos).Value = txtofentre.Text
        DataGridView1(17, pos).Value = txtvalor.Text
        Dim fc As Date
        fc = dtpfecha.Value
        fecha = Format(fc, "yyyy-MM-dd")
        DataGridView1(18, pos).Value = fecha
        btnmod.Enabled = False
        limpiar()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        pos = DataGridView1.CurrentRow.Index
        limpiar()
        txtnit.Text = DataGridView1(0, pos).Value
        txtsecuencia.Text = DataGridView1(3, pos).Value
        txtnocuenta.Text = DataGridView1(4, pos).Value
        If (DataGridView1(6, pos).Value.Equals("")) Then
        Else
            txtdesc.Text = ""
        End If
        txtnitben.Text = DataGridView1(8, pos).Value
        If (DataGridView1(9, pos).Value.Equals("")) Then
            txtnomben.Text = ""
        End If
        txtnoctaben.Text = DataGridView1(12, pos).Value
        If (DataGridView1(13, pos).Value.Equals("")) Then
            txtemail.Text = ""
        End If
        If (DataGridView1(14, pos).Value.Equals("")) Then
            txtdocaut.Text = ""
        End If
        If (DataGridView1(15, pos).Value.Equals("")) Then
            txtref.Text = ""
        End If
        If (DataGridView1(16, pos).Value.Equals("")) Then
            txtofentre.Text = ""
        End If
        txtvalor.Text = DataGridView1(17, pos).Value
        cbxtpago.SelectedIndex = ppago
        cbxaplicacion.SelectedIndex = ptap
        cbxtcta.SelectedIndex = pcta
        cbxtdoc.SelectedIndex = ptd
        cbxttran.SelectedIndex = ptt
        cbxcban.SelectedIndex = pbc
        btnmod.Enabled = True
        activar()
    End Sub
End Class