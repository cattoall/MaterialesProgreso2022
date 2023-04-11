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
        Dim Clientes As List(Of tblClientes)
        Dim ClientesWendy As List(Of tblWClientes)
        Select Case Buscar_Clientes
            Case "PAGOS_WENDY"
                ClientesWendy = DBModelo.GetClientesByNameApatAmatWendy(txtBusqueda.Text)
                MetroGrid1.DataSource = ClientesWendy.ToList

            Case "PAGOS_LIBRADA"
                Clientes = DBModelo.GetClientesByNameApatAmat(txtBusqueda.Text)
                MetroGrid1.DataSource = Clientes.ToList

            Case Else
                Clientes = DBModelo.GetClientesByNameApatAmat(txtBusqueda.Text)
                MetroGrid1.DataSource = Clientes.ToList

        End Select

        MetroGrid1.Columns(0).HeaderText = "IdComp"
        MetroGrid1.Columns(0).ReadOnly = True
        MetroGrid1.Columns(0).Width = 50
        MetroGrid1.Columns(0).Visible = False

        MetroGrid1.Columns(1).HeaderText = "ID"
        MetroGrid1.Columns(1).ReadOnly = True
        MetroGrid1.Columns(1).Width = 50

        MetroGrid1.Columns(2).HeaderText = "Nombre"
        MetroGrid1.Columns(2).ReadOnly = True
        MetroGrid1.Columns(2).Width = 150

        MetroGrid1.Columns(3).HeaderText = "Apellido Paterno"
        MetroGrid1.Columns(3).ReadOnly = True
        MetroGrid1.Columns(3).Width = 150

        MetroGrid1.Columns(4).HeaderText = "Apellido Materno"
        MetroGrid1.Columns(4).ReadOnly = True
        MetroGrid1.Columns(4).Width = 150

        MetroGrid1.Columns(11).HeaderText = "R.F.C."
        MetroGrid1.Columns(11).ReadOnly = True

        MetroGrid1.Columns(27).HeaderText = "Régimen Fiscal"
        MetroGrid1.Columns(27).ReadOnly = True
        MetroGrid1.Columns(27).Visible = True

        MetroGrid1.Columns(15).HeaderText = "Observaciones"
        MetroGrid1.Columns(15).ReadOnly = True
        MetroGrid1.Columns(15).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        MetroGrid1.Columns(5).HeaderText = "Domicilio"
        MetroGrid1.Columns(5).ReadOnly = True
        MetroGrid1.Columns(5).Visible = False

        MetroGrid1.Columns(6).HeaderText = "Número"
        MetroGrid1.Columns(6).ReadOnly = True
        MetroGrid1.Columns(6).Visible = False

        MetroGrid1.Columns(7).HeaderText = "Colonia"
        MetroGrid1.Columns(7).ReadOnly = True
        MetroGrid1.Columns(7).Visible = False

        MetroGrid1.Columns(8).HeaderText = "Ciudad"
        MetroGrid1.Columns(8).ReadOnly = True
        MetroGrid1.Columns(8).Visible = False

        MetroGrid1.Columns(9).HeaderText = "Estado"
        MetroGrid1.Columns(9).ReadOnly = True
        MetroGrid1.Columns(9).Visible = False

        MetroGrid1.Columns(10).HeaderText = "Código Postal"
        MetroGrid1.Columns(10).ReadOnly = True
        MetroGrid1.Columns(10).Visible = False

        MetroGrid1.Columns(12).HeaderText = "Teléfono"
        MetroGrid1.Columns(12).ReadOnly = True
        MetroGrid1.Columns(12).Visible = False

        MetroGrid1.Columns(13).HeaderText = "Celular"
        MetroGrid1.Columns(13).ReadOnly = True
        MetroGrid1.Columns(13).Visible = False

        MetroGrid1.Columns(14).HeaderText = "Correo"
        MetroGrid1.Columns(14).ReadOnly = True
        MetroGrid1.Columns(14).Visible = False

        MetroGrid1.Columns(16).HeaderText = "Lista Precios"
        MetroGrid1.Columns(16).ReadOnly = True
        MetroGrid1.Columns(16).Visible = False

        MetroGrid1.Columns(17).HeaderText = "Días Crédito"
        MetroGrid1.Columns(17).ReadOnly = True
        MetroGrid1.Columns(17).Visible = False

        MetroGrid1.Columns(18).HeaderText = "Límite Crédito"
        MetroGrid1.Columns(18).ReadOnly = True
        MetroGrid1.Columns(18).Visible = False

        MetroGrid1.Columns(19).HeaderText = "Tipo Venta"
        MetroGrid1.Columns(19).ReadOnly = True
        MetroGrid1.Columns(19).Visible = False

        MetroGrid1.Columns(20).HeaderText = "Método Pago"
        MetroGrid1.Columns(20).ReadOnly = True
        MetroGrid1.Columns(20).Visible = False

        MetroGrid1.Columns(21).HeaderText = "Condiciones"
        MetroGrid1.Columns(21).ReadOnly = True
        MetroGrid1.Columns(21).Visible = False

        MetroGrid1.Columns(22).HeaderText = "Cuenta"
        MetroGrid1.Columns(22).ReadOnly = True
        MetroGrid1.Columns(22).Visible = False

        MetroGrid1.Columns(23).HeaderText = "Banco"
        MetroGrid1.Columns(23).ReadOnly = True
        MetroGrid1.Columns(23).Visible = False

        MetroGrid1.Columns(24).HeaderText = "Tasa Cero"
        MetroGrid1.Columns(24).ReadOnly = True
        MetroGrid1.Columns(24).Visible = False

        MetroGrid1.Columns(25).HeaderText = "Forma Pago"
        MetroGrid1.Columns(25).ReadOnly = True
        MetroGrid1.Columns(25).Visible = False

        MetroGrid1.Columns(26).HeaderText = "Uso CFDI"
        MetroGrid1.Columns(26).ReadOnly = True
        MetroGrid1.Columns(26).Visible = False

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