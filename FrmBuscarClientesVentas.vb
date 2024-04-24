Public Class FrmBuscarClientesVentas
    Private Sub LimpiarObjetos()
        MetroGrid1.Refresh()
        txtBusqueda.Clear()
    End Sub

    Private Sub FrmBuscarClientesVentas_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If txtBusqueda.Text = "" And MetroGrid1.RowCount = 0 Then
            idClienteVenta = CStr(0)
            Exit Sub
        End If

    End Sub

    Private Sub FrmBuscarClientesVentas_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                LimpiarObjetos()
                Close()
        End Select
    End Sub

    Private Sub FrmBuscarClientesVentas_Leave(sender As Object, e As System.EventArgs) Handles Me.Leave
        LimpiarObjetos()
    End Sub

    Private Sub FrmBuscarClientesVentas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtBusqueda.Select()
    End Sub

    Private Sub txtBusqueda_GotFocus(sender As Object, e As System.EventArgs) Handles txtBusqueda.GotFocus
        txtBusqueda.SelectAll()
    End Sub

    Private Sub txtBusqueda_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtBusqueda.KeyPress
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
        Dim Clientes As List(Of tblClientes)
        Dim ClientesWendy As List(Of tblWClientes)
        Select Case Buscar_Clientes
            Case "PAGOS_WENDY"
                ClientesWendy = DBModelo.GetClientesByNameApatAmatWendy(txtBusqueda.Text)
                For Each row In ClientesWendy
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
            Case "PAGOS_LIBRADA"
                Clientes = DBModelo.GetClientesByNameApatAmat(txtBusqueda.Text)
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
            Case Else
                Clientes = DBModelo.GetClientesByNameApatAmat(txtBusqueda.Text)
                For Each row In Clientes
                    If row.Bloqueado = 0 Then

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
                    End If
                Next
        End Select

    End Sub

    Private Sub get_selected_customer()

        If MetroGrid1.RowCount > 0 Then

            idClienteVenta = CStr(MetroGrid1.Item(1, MetroGrid1.CurrentRow.Index).Value)
            idClientePago = CStr(MetroGrid1.Item(1, MetroGrid1.CurrentRow.Index).Value)
            Select Case Buscar_Clientes
                Case "VENTAS"
                    FrmPuntoDeVenta.txtCliente.Text = CStr(MetroGrid1.Item(2, MetroGrid1.CurrentRow.Index).Value) & " " & CStr(MetroGrid1.Item(3, MetroGrid1.CurrentRow.Index).Value) & " " & CStr(MetroGrid1.Item(4, MetroGrid1.CurrentRow.Index).Value)
                    FrmPuntoDeVenta.txtDomicilio.Text = CStr(MetroGrid1.Item(5, MetroGrid1.CurrentRow.Index).Value) & " # " &
                                                        CStr(MetroGrid1.Item(6, MetroGrid1.CurrentRow.Index).Value) & " Colonia " &
                                                        CStr(MetroGrid1.Item(7, MetroGrid1.CurrentRow.Index).Value) & " Ciudad " &
                                                        CStr(MetroGrid1.Item(8, MetroGrid1.CurrentRow.Index).Value) & " Estado " &
                                                        CStr(MetroGrid1.Item(9, MetroGrid1.CurrentRow.Index).Value) & " Código Postal " &
                                                        CStr(MetroGrid1.Item(10, MetroGrid1.CurrentRow.Index).Value) & " R.F.C. " &
                                                        CStr(MetroGrid1.Item(11, MetroGrid1.CurrentRow.Index).Value)
                    Cliente_diasCredito = CDbl(MetroGrid1.Item(17, MetroGrid1.CurrentRow.Index).Value)
                    Cliente_limite = CDbl(MetroGrid1.Item(18, MetroGrid1.CurrentRow.Index).Value)
                    FrmPuntoDeVenta.txtIdCliente.Text = CStr(MetroGrid1.Item(1, MetroGrid1.CurrentRow.Index).Value)
                Case "PAGOS"
                    FrmCuentasPorCobrar.TxtCliente.Text = CStr(MetroGrid1.Item(2, MetroGrid1.CurrentRow.Index).Value) & " " & CStr(MetroGrid1.Item(3, MetroGrid1.CurrentRow.Index).Value) & " " & CStr(MetroGrid1.Item(4, MetroGrid1.CurrentRow.Index).Value)
                    FrmCuentasPorCobrar.TxtDomicilio.Text = CStr(MetroGrid1.Item(5, MetroGrid1.CurrentRow.Index).Value) & " # " &
                                                        CStr(MetroGrid1.Item(6, MetroGrid1.CurrentRow.Index).Value) & " Colonia " &
                                                        CStr(MetroGrid1.Item(7, MetroGrid1.CurrentRow.Index).Value) & " Ciudad " &
                                                        CStr(MetroGrid1.Item(8, MetroGrid1.CurrentRow.Index).Value) & " Estado " &
                                                        CStr(MetroGrid1.Item(9, MetroGrid1.CurrentRow.Index).Value) & " Código Postal " &
                                                        CStr(MetroGrid1.Item(10, MetroGrid1.CurrentRow.Index).Value) & " R.F.C. " &
                                                        CStr(MetroGrid1.Item(11, MetroGrid1.CurrentRow.Index).Value)
                    Cliente_diasCredito = CDbl(MetroGrid1.Item(17, MetroGrid1.CurrentRow.Index).Value)
                Case "PAGOS_WENDY"
                    FrmCuentasPorCobrar.TxtCliente.Text = CStr(MetroGrid1.Item(2, MetroGrid1.CurrentRow.Index).Value) & " " & CStr(MetroGrid1.Item(3, MetroGrid1.CurrentRow.Index).Value) & " " & CStr(MetroGrid1.Item(4, MetroGrid1.CurrentRow.Index).Value)
                    FrmCuentasPorCobrar.TxtDomicilio.Text = CStr(MetroGrid1.Item(5, MetroGrid1.CurrentRow.Index).Value) & " # " &
                                                        CStr(MetroGrid1.Item(6, MetroGrid1.CurrentRow.Index).Value) & " Colonia " &
                                                        CStr(MetroGrid1.Item(7, MetroGrid1.CurrentRow.Index).Value) & " Ciudad " &
                                                        CStr(MetroGrid1.Item(8, MetroGrid1.CurrentRow.Index).Value) & " Estado " &
                                                        CStr(MetroGrid1.Item(9, MetroGrid1.CurrentRow.Index).Value) & " Código Postal " &
                                                        CStr(MetroGrid1.Item(10, MetroGrid1.CurrentRow.Index).Value) & " R.F.C. " &
                                                        CStr(MetroGrid1.Item(11, MetroGrid1.CurrentRow.Index).Value)
                    Cliente_diasCredito = CDbl(MetroGrid1.Item(17, MetroGrid1.CurrentRow.Index).Value)
                Case "HISTORIAL"
                    FrmHistorialCliente.txtCliente.Text = CStr(MetroGrid1.Item(2, MetroGrid1.CurrentRow.Index).Value) & " " & CStr(MetroGrid1.Item(3, MetroGrid1.CurrentRow.Index).Value) & " " & CStr(MetroGrid1.Item(4, MetroGrid1.CurrentRow.Index).Value)

                Case "LINEAS"
                    FrmListadoDePreciosPorLinea.txtcliente.Text = CStr(MetroGrid1.Item(2, MetroGrid1.CurrentRow.Index).Value) & " " & CStr(MetroGrid1.Item(3, MetroGrid1.CurrentRow.Index).Value) & " " & CStr(MetroGrid1.Item(4, MetroGrid1.CurrentRow.Index).Value)
                    idClienteVenta = CStr(MetroGrid1.Item(1, MetroGrid1.CurrentRow.Index).Value)
                    precio_linea = CStr(MetroGrid1.Item(16, MetroGrid1.CurrentRow.Index).Value)
                Case "FACTURAS"
                    FrmFacturacion.txtnombre.Text = CStr(MetroGrid1.Item(2, MetroGrid1.CurrentRow.Index).Value) & " " & CStr(MetroGrid1.Item(3, MetroGrid1.CurrentRow.Index).Value) & " " & CStr(MetroGrid1.Item(4, MetroGrid1.CurrentRow.Index).Value)
                    FrmFacturacion.txtdirecion.Text = CStr(MetroGrid1.Item(5, MetroGrid1.CurrentRow.Index).Value)
                    FrmFacturacion.txtcolonia.Text = CStr(MetroGrid1.Item(7, MetroGrid1.CurrentRow.Index).Value)
                    FrmFacturacion.txtestado.Text = CStr(MetroGrid1.Item(9, MetroGrid1.CurrentRow.Index).Value)
                    FrmFacturacion.txtcp.Text = CStr(MetroGrid1.Item(10, MetroGrid1.CurrentRow.Index).Value)
                    FrmFacturacion.TxtRFC.Text = CStr(MetroGrid1.Item(11, MetroGrid1.CurrentRow.Index).Value)
                    FrmFacturacion.txtNumero.Text = CStr(MetroGrid1.Item(6, MetroGrid1.CurrentRow.Index).Value)
                    FrmFacturacion.txtCiudad.Text = CStr(MetroGrid1.Item(8, MetroGrid1.CurrentRow.Index).Value)
                    FrmFacturacion.txtEmail.Text = CStr(MetroGrid1.Item(14, MetroGrid1.CurrentRow.Index).Value)

                    If CStr(MetroGrid1.Item(21, MetroGrid1.CurrentRow.Index).Value) <> "" Then
                        FrmFacturacion.CmbCredito.SelectedIndex = FrmFacturacion.CmbCredito.FindString(CStr(MetroGrid1.Item(21, MetroGrid1.CurrentRow.Index).Value))
                    Else
                        FrmFacturacion.CmbCredito.SelectedIndex = -1
                    End If

                    If CStr(MetroGrid1.Item(22, MetroGrid1.CurrentRow.Index).Value) <> "" Then
                        FrmFacturacion.txtCuenta.Text = CStr(MetroGrid1.Item(22, MetroGrid1.CurrentRow.Index).Value)
                    Else
                        FrmFacturacion.txtCuenta.Clear()
                    End If

                    If CStr(MetroGrid1.Item(23, MetroGrid1.CurrentRow.Index).Value) <> "" Then
                        FrmFacturacion.CmbBanco.SelectedIndex = FrmFacturacion.CmbBanco.FindString(CStr(MetroGrid1.Item(23, MetroGrid1.CurrentRow.Index).Value))
                    Else
                        FrmFacturacion.CmbBanco.SelectedIndex = -1
                    End If

                    If CInt(MetroGrid1.Item(24, MetroGrid1.CurrentRow.Index).Value) = 1 Then
                        FrmFacturacion.ChkTasaCero.Checked = True
                    Else
                        FrmFacturacion.ChkTasaCero.Checked = False
                    End If

                    If CStr(MetroGrid1.Item(20, MetroGrid1.CurrentRow.Index).Value) <> "" Then
                        FrmFacturacion.CmbMetodoPago.SelectedIndex = FrmFacturacion.CmbMetodoPago.FindString(CStr(MetroGrid1.Item(20, MetroGrid1.CurrentRow.Index).Value))
                    Else
                        FrmFacturacion.CmbMetodoPago.SelectedIndex = -1
                    End If

                    If CStr(MetroGrid1.Item(25, MetroGrid1.CurrentRow.Index).Value) <> "" Then
                        FrmFacturacion.CmdFormaPago.SelectedIndex = FrmFacturacion.CmdFormaPago.FindString(CStr(MetroGrid1.Item(25, MetroGrid1.CurrentRow.Index).Value))
                    Else
                        FrmFacturacion.CmdFormaPago.SelectedIndex = -1
                    End If

                    If CStr(MetroGrid1.Item(26, MetroGrid1.CurrentRow.Index).Value) <> "" Then
                        FrmFacturacion.CmbUsoCDFI.SelectedIndex = FrmFacturacion.CmbUsoCDFI.FindString(CStr(MetroGrid1.Item(26, MetroGrid1.CurrentRow.Index).Value))
                    Else
                        FrmFacturacion.CmbUsoCDFI.SelectedIndex = -1
                    End If
                    UsoCDFI = CStr(MetroGrid1.Item(26, MetroGrid1.CurrentRow.Index).Value)
                    FrmFacturacion.txtRFR.Text = CStr(MetroGrid1.Item(27, MetroGrid1.CurrentRow.Index).Value)

                Case "COMPLEMENTO"
                    frmComplementoPago.txtNombre.Text = CStr(MetroGrid1.Item(2, MetroGrid1.CurrentRow.Index).Value) & " " & CStr(MetroGrid1.Item(3, MetroGrid1.CurrentRow.Index).Value) & " " & CStr(MetroGrid1.Item(4, MetroGrid1.CurrentRow.Index).Value)
                    frmComplementoPago.txtDirecion.Text = CStr(MetroGrid1.Item(5, MetroGrid1.CurrentRow.Index).Value)
                    frmComplementoPago.txtColonia.Text = CStr(MetroGrid1.Item(7, MetroGrid1.CurrentRow.Index).Value)
                    frmComplementoPago.txtEstado.Text = CStr(MetroGrid1.Item(9, MetroGrid1.CurrentRow.Index).Value)
                    frmComplementoPago.txtCP.Text = CStr(MetroGrid1.Item(10, MetroGrid1.CurrentRow.Index).Value)
                    frmComplementoPago.TxtRFC.Text = CStr(MetroGrid1.Item(11, MetroGrid1.CurrentRow.Index).Value)
                    frmComplementoPago.txtNumero.Text = CStr(MetroGrid1.Item(6, MetroGrid1.CurrentRow.Index).Value)
                    frmComplementoPago.txtCiudad.Text = CStr(MetroGrid1.Item(8, MetroGrid1.CurrentRow.Index).Value)
                    frmComplementoPago.txtEmail.Text = CStr(MetroGrid1.Item(14, MetroGrid1.CurrentRow.Index).Value)
                    If IsDBNull(MetroGrid1.Item(25, MetroGrid1.CurrentRow.Index).Value) Then
                        frmComplementoPago.CmdFormaPago.SelectedIndex = -1
                        gv_formapago = -1
                    ElseIf CStr(MetroGrid1.Item(25, MetroGrid1.CurrentRow.Index).Value) = "" Then
                        frmComplementoPago.CmdFormaPago.SelectedIndex = -1
                        gv_formapago = -1
                    Else
                        FormaPago = CStr(MetroGrid1.Item(25, MetroGrid1.CurrentRow.Index).Value)
                        frmComplementoPago.CmdFormaPago.SelectedIndex = frmComplementoPago.CmdFormaPago.FindString(CStr(MetroGrid1.Item(25, MetroGrid1.CurrentRow.Index).Value))
                        gv_formapago = frmComplementoPago.CmdFormaPago.SelectedIndex
                    End If
                    frmComplementoPago.txtRFR.Text = CStr(MetroGrid1.Item(27, MetroGrid1.CurrentRow.Index).Value)
            End Select
            idTipoPrecioCliente = CStr(MetroGrid1.Item(16, MetroGrid1.CurrentRow.Index).Value)
            idClientePago = CStr(MetroGrid1.Item(1, MetroGrid1.CurrentRow.Index).Value)
            MetroGrid1.Refresh()
            LimpiarObjetos()
            Close()
        Else
            txtBusqueda.Focus()
            txtBusqueda.SelectAll()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub MetroGrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellDoubleClick
        get_selected_customer()
    End Sub

    Private Sub MetroGrid1_KeyDown(sender As Object, e As KeyEventArgs) Handles MetroGrid1.KeyDown
        If e.KeyCode = Keys.Enter Then
            get_selected_customer()
            e.Handled = True
        End If
    End Sub
End Class