Option Explicit On
Public Class FrmBuscarClientes
    Private Sub LimpiarObjetos()
        MetroGrid1.Refresh()
        txtBusqueda.Clear()
    End Sub

    Private Sub FrmBuscarClientes_Disposed(sender As Object, e As System.EventArgs) Handles Me.Disposed
        LimpiarObjetos()
    End Sub

    Private Sub FrmBuscarClientes_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                LimpiarObjetos()
                Close()
        End Select
    End Sub

    Private Sub FrmBuscarClientes_Leave(sender As Object, e As System.EventArgs) Handles Me.Leave
        LimpiarObjetos()
    End Sub

    Private Sub FrmBuscarClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LimpiarObjetos()
        txtBusqueda.Select()
    End Sub

    Private Sub txtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusqueda.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            refresh_data_dgv()
            If dt.Rows.Count = 0 Then
                txtBusqueda.Focus()
                txtBusqueda.SelectAll()
            Else
                MetroGrid1.Focus()
            End If
        End If
    End Sub

    Private Sub refresh_data_dgv()
        MetroGrid1.Refresh()
        MetroGrid1.Rows.Clear()
        Dim Clientes As List(Of tblClientes) = DBModelo.GetClientesByNameApatAmat(txtBusqueda.Text)

        For Each row In Clientes
            Dim line As String() = New String() {
                                                    row.IdComp,
                                                    row.clave.ToString,
                                                    row.nombre,
                                                    row.apat,
                                                    row.amat,
                                                    row.calle,
                                                    row.numero,
                                                    row.colonia,
                                                    row.ciudad,
                                                    row.estado,
                                                    row.cp,
                                                    row.rfc,
                                                    row.telefono,
                                                    row.celular,
                                                    row.correo,
                                                    row.observaciones,
                                                    row.listaPrecios,
                                                    row.diasCredito.ToString,
                                                    row.limiteCredito.ToString,
                                                    row.tipo_venta,
                                                    row.metodopago,
                                                    row.codiciones,
                                                    row.cuenta,
                                                    row.banco,
                                                    row.tasa_cero.ToString,
                                                    row.FormaPago,
                                                    row.UsoCFDI,
                                                    row.RegimenFiscal
                                                    }
            MetroGrid1.Rows.Add(line)
        Next
    End Sub

    Private Sub MetroGrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellDoubleClick
        If MetroGrid1.RowCount > 0 Then
            Add_Update = True

            FrmClientes.Text = "Modificar Cliente"
            FrmClientes.lv_idCliente = CInt(MetroGrid1.Item(1, MetroGrid1.CurrentRow.Index).Value)
            FrmClientes.txtNombre.Text = CStr(MetroGrid1.Item(2, MetroGrid1.CurrentRow.Index).Value)
            FrmClientes.txtApat.Text = CStr(MetroGrid1.Item(3, MetroGrid1.CurrentRow.Index).Value)
            FrmClientes.txtAmat.Text = CStr(MetroGrid1.Item(4, MetroGrid1.CurrentRow.Index).Value)
            FrmClientes.txtDomicilio.Text = CStr(MetroGrid1.Item(5, MetroGrid1.CurrentRow.Index).Value)
            FrmClientes.txtNumExterno.Text = CStr(MetroGrid1.Item(6, MetroGrid1.CurrentRow.Index).Value)
            FrmClientes.txtColonia.Text = CStr(MetroGrid1.Item(7, MetroGrid1.CurrentRow.Index).Value)
            FrmClientes.txtCiudad.Text = CStr(MetroGrid1.Item(8, MetroGrid1.CurrentRow.Index).Value)
            FrmClientes.txtEstado.Text = CStr(MetroGrid1.Item(9, MetroGrid1.CurrentRow.Index).Value)
            FrmClientes.txtCodigoPostal.Text = CStr(MetroGrid1.Item(10, MetroGrid1.CurrentRow.Index).Value)
            FrmClientes.txtRFC.Text = CStr(MetroGrid1.Item(11, MetroGrid1.CurrentRow.Index).Value)
            FrmClientes.txtTelFijo.Text = CStr(MetroGrid1.Item(12, MetroGrid1.CurrentRow.Index).Value)
            FrmClientes.txtMovil.Text = CStr(MetroGrid1.Item(13, MetroGrid1.CurrentRow.Index).Value)
            FrmClientes.txtEmail.Text = CStr(MetroGrid1.Item(14, MetroGrid1.CurrentRow.Index).Value)
            FrmClientes.txtObs.Text = CStr(MetroGrid1.Item(15, MetroGrid1.CurrentRow.Index).Value)

            Select Case MetroGrid1.Item(16, MetroGrid1.CurrentRow.Index).Value.ToString
                Case "Precio Publico"
                    FrmClientes.CmbPrecio.SelectedIndex = 0
                Case "Precio Público"
                    FrmClientes.CmbPrecio.SelectedIndex = 0
                Case "Precio P1"
                    FrmClientes.CmbPrecio.SelectedIndex = 1
                Case "Precio P2"
                    FrmClientes.CmbPrecio.SelectedIndex = 2
                Case "Precio P3"
                    FrmClientes.CmbPrecio.SelectedIndex = 3
            End Select
            FrmClientes.txtCredito.Text = CStr(CInt(MetroGrid1.Item(17, MetroGrid1.CurrentRow.Index).Value))
            FrmClientes.txtLimite.Text = CStr(CDbl(MetroGrid1.Item(18, MetroGrid1.CurrentRow.Index).Value))

            If CStr(MetroGrid1.Item(19, MetroGrid1.CurrentRow.Index).Value) <> "" Then
                FrmClientes.CmbTipo.SelectedIndex = FrmClientes.CmbTipo.FindString(CStr(MetroGrid1.Item(19, MetroGrid1.CurrentRow.Index).Value))
            Else
                FrmClientes.CmbTipo.SelectedIndex = -1
            End If

            If Not IsDBNull(MetroGrid1.Item(20, MetroGrid1.CurrentRow.Index).Value) Then
                If CStr(MetroGrid1.Item(20, MetroGrid1.CurrentRow.Index).Value) <> "" Then
                    FrmClientes.cmbMetodoPago.SelectedIndex = FrmClientes.cmbMetodoPago.FindString(CStr(MetroGrid1.Item(20, MetroGrid1.CurrentRow.Index).Value))
                Else
                    FrmClientes.cmbMetodoPago.SelectedIndex = -1
                End If
            Else
                FrmClientes.cmbMetodoPago.SelectedIndex = -1
            End If

            If CStr(MetroGrid1.Item(21, MetroGrid1.CurrentRow.Index).Value) <> "" Then
                FrmClientes.CmbCredito.SelectedIndex = FrmClientes.CmbCredito.FindString(CStr(MetroGrid1.Item(21, MetroGrid1.CurrentRow.Index).Value))
            Else
                FrmClientes.CmbCredito.SelectedIndex = -1
            End If

            If CStr(MetroGrid1.Item(22, MetroGrid1.CurrentRow.Index).Value) <> "" Then
                FrmClientes.txtCuenta.Text = CStr(MetroGrid1.Item(22, MetroGrid1.CurrentRow.Index).Value)
            Else
                FrmClientes.txtCuenta.Clear()
            End If

            If CStr(MetroGrid1.Item(23, MetroGrid1.CurrentRow.Index).Value) <> "" Then
                FrmClientes.CmbBanco.SelectedIndex = FrmClientes.CmbBanco.FindString(CStr(MetroGrid1.Item(23, MetroGrid1.CurrentRow.Index).Value))
            Else
                FrmClientes.CmbBanco.SelectedIndex = -1
            End If
            If CInt(MetroGrid1.Item(24, MetroGrid1.CurrentRow.Index).Value) = 1 Then
                FrmClientes.ChkTasaCero.Checked = True
            Else
                FrmClientes.ChkTasaCero.Checked = False
            End If
            If Not IsDBNull(MetroGrid1.Item(25, MetroGrid1.CurrentRow.Index).Value) Then
                If CStr(MetroGrid1.Item(25, MetroGrid1.CurrentRow.Index).Value) <> "" Then
                    FrmClientes.cmbFormaPago.SelectedIndex = FrmClientes.cmbFormaPago.FindString(CStr(MetroGrid1.Item(25, MetroGrid1.CurrentRow.Index).Value))
                Else
                    FrmClientes.cmbFormaPago.SelectedIndex = -1
                End If
            Else
                FrmClientes.cmbFormaPago.SelectedIndex = -1
            End If

            If Not IsDBNull(MetroGrid1.Item(26, MetroGrid1.CurrentRow.Index).Value) Then
                If CStr(MetroGrid1.Item(26, MetroGrid1.CurrentRow.Index).Value) <> "" Then
                    FrmClientes.cmbUsoCFDI.SelectedIndex = FrmClientes.cmbUsoCFDI.FindString(CStr(MetroGrid1.Item(26, MetroGrid1.CurrentRow.Index).Value))
                Else
                    FrmClientes.cmbUsoCFDI.SelectedIndex = -1
                End If
            Else
                FrmClientes.cmbUsoCFDI.SelectedIndex = -1
            End If

            If Not IsDBNull(MetroGrid1.Item(27, MetroGrid1.CurrentRow.Index).Value) Then
                If CStr(MetroGrid1.Item(27, MetroGrid1.CurrentRow.Index).Value) <> "" Then
                    FrmClientes.cmbRegimen.SelectedIndex = FrmClientes.cmbRegimen.FindString(CStr(MetroGrid1.Item(27, MetroGrid1.CurrentRow.Index).Value))
                Else
                    FrmClientes.cmbRegimen.SelectedIndex = -1
                End If
            Else
                FrmClientes.cmbRegimen.SelectedIndex = -1
            End If

            FrmClientes.ShowDialog()
            FrmClientes.Close()
            LimpiarObjetos()
            refresh_data_dgv()
        Else
            txtBusqueda.Focus()
            txtBusqueda.SelectAll()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_Update = False
        FrmClientes.Text = "Crear Cliente"
        FrmClientes.ShowDialog()
        FrmClientes.Close()
        LimpiarObjetos()
        refresh_data_dgv()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LimpiarObjetos()
        Close()
    End Sub
End Class