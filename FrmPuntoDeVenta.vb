Public Class FrmPuntoDeVenta
    Dim input As String
    Dim msg As String
    Dim title As String
    Dim response As MsgBoxResult
    Dim coti As String
    Dim TipoDocumento As String

    Private Sub FrmPuntoDeVenta_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.F6
                If CmbTipoVenta.Text = "CREDITO" Or CmbDocto.Text = "COTIZACION" Then
                    Call lblBuscarC_Click(sender, e)
                End If
            Case Keys.F8
                Call lblDescuento_Click(sender, e)
            Case Keys.F3
                If MetroFramework.MetroMessageBox.Show(Me, "¿Estás seguro de crear una nueva venta?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    NuevaVenta()
                End If
            Case Keys.F2
                Call lblBuscarP_Click(sender, e)
            Case Keys.F9
                If MetroGrid1.Rows.Count > 0 Then
                    Call lblCobrar_Click(sender, e)
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "Ventan no puede ser realizada sin productos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
        End Select
    End Sub

    Private Sub NuevaVenta()
        CmbDocto.SelectedIndex = 0
        CmbTipoVenta.SelectedIndex = 0
        MetroGrid1.Refresh()
        MetroGrid1.Rows.Clear()
        MetroGrid1.ResumeLayout()
        txtProducto.Select()
        idClienteVenta = ""
        idTipoPrecioCliente = ""
        txtCliente.Text = "PUBLICO GENERAL"
        idClienteVenta = 0
        Error_Venta = False
        EsCotizacion = False
        gv_tasa_0 = False
        gv_tasa_16 = False
        TipoDocumento = ""
    End Sub

    Private Sub FrmPuntoDeVenta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtProducto.Select()
        MetroGrid1.ResumeLayout()
        MetroGrid1.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        MetroGrid1.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        MetroGrid1.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        MetroGrid1.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        MetroGrid1.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        MetroGrid1.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        MetroGrid1.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        MetroGrid1.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.WindowState = FormWindowState.Maximized
        NuevaVenta()

        txtSubTotal.Text = "0.00"
        txtIVA.Text = "0.00"
        txtTotal.Text = "0.00"
        txtSubTotalTasaCero.Text = "0.00"
        txtIVATasaCero.Text = "0.00"
        txtTotalTasaCero.Text = "0.00"
        CmbDocto.SelectedIndex = 0
        CmbTipoVenta.SelectedIndex = 0
        TipoDocumento = ""
    End Sub

    Private Sub FrmPuntoDeVenta_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        MetroPanel1.Left = (Me.Width / 2) - (MetroPanel1.Width / 2)
    End Sub

    Private Sub txtProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProducto.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Add_Record_to_DGV()
        End If
    End Sub

    Private Sub Add_Record_to_DGV()
        Dim lv_granSubTotal As Double = 0
        Dim lv_granIVA As Double = 0
        Dim lv_granTotal As Double = 0
        Dim lv_granSubTotal_TasaCero As Double = 0
        Dim lv_granIVA_TasaCero As Double = 0
        Dim lv_granTotal_TasaCero As Double = 0

        Dim strProducto As tblProductos = DBModelo.Get_PV_Producto(txtProducto.Text)
        If Not IsNothing(strProducto) Then
            If strProducto.ClaveProducto = "" Then
                MetroFramework.MetroMessageBox.Show(Me, "Producto: " & myDs.Tables(0).Rows(0)!descripcionProducto & " no tiene ClaveProducto SAT definido.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If strProducto.ClaveUnidad = "" Then
                MetroFramework.MetroMessageBox.Show(Me, "Producto: " & myDs.Tables(0).Rows(0)!descripcionProducto & " no tiene ClaveUnidad SAT definida.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If MetroGrid1.Rows.Count > 0 Then
                Dim intcount As Integer = 0
                For Each stRow As DataGridViewRow In MetroGrid1.Rows

                    If MetroGrid1.Rows(intcount).Cells(1).Value.ToString = strProducto.IdProducto Then
                        MetroGrid1.Rows(intcount).Cells(0).Value = MetroGrid1.Rows(intcount).Cells(0).Value + 1
                        MetroGrid1.Rows(intcount).Cells(3).Value = Trim(Replace(MetroGrid1.Rows(intcount).Cells(3).Value, "$", "")) ' / FactorIVA
                        MetroGrid1.Rows(intcount).Cells(9).Value = Trim(Replace(MetroGrid1.Rows(intcount).Cells(9).Value, "$", ""))
                        MetroGrid1.Rows(intcount).Cells(7).Value = Trim(Replace(MetroGrid1.Rows(intcount).Cells(7).Value, "$", "")) ' / FactorIVA

                        MetroGrid1.Rows(intcount).Cells(4).Value = MetroGrid1.Rows(intcount).Cells(3).Value * MetroGrid1.Rows(intcount).Cells(0).Value
                        MetroGrid1.Rows(intcount).Cells(10).Value = MetroGrid1.Rows(intcount).Cells(9).Value * MetroGrid1.Rows(intcount).Cells(0).Value
                        MetroGrid1.Rows(intcount).Cells(8).Value = MetroGrid1.Rows(intcount).Cells(7).Value * MetroGrid1.Rows(intcount).Cells(0).Value

                        txtProducto.Clear()
                        txtProducto.Select()
                        For i = 0 To MetroGrid1.RowCount - 1
                            MetroGrid1.Rows(i).Cells(8).Value = Trim(Replace(MetroGrid1.Rows(i).Cells(8).Value, "$", ""))
                            Dim lv_total As Double = MetroGrid1.Rows(i).Cells(8).Value
                            lv_granSubTotal = lv_granSubTotal + lv_total
                            If MetroGrid1.Rows(i).Cells(13).Value = False Then
                                lv_granIVA = lv_granIVA + FormatNumber((lv_total * (FactorIVA - 1)), 2)
                                lv_granTotal = lv_granTotal + FormatNumber((lv_total + (lv_total * (FactorIVA - 1))))
                                gv_tasa_16 = True
                            Else
                                lv_granTotal = lv_granTotal + FormatNumber(lv_total, 2)
                                lv_granTotal_TasaCero = lv_granTotal_TasaCero + FormatNumber(lv_total, 2)
                                lv_granSubTotal_TasaCero = lv_granSubTotal_TasaCero + lv_total
                                gv_tasa_0 = True
                            End If
                            MetroGrid1.Rows(i).Cells(8).Value = lv_total
                        Next
                        txtSubTotal.Text = Format(lv_granSubTotal, "###,###,##0.00")
                        txtIVA.Text = Format(lv_granIVA, "###,###,##0.00")
                        txtTotal.Text = Format(lv_granTotal, "###,###,##0.00")
                        txtSubTotalTasaCero.Text = Format(lv_granSubTotal_TasaCero, "###,###,##0.00")
                        txtIVATasaCero.Text = Format(lv_granIVA_TasaCero, "###,###,##0.00")
                        txtTotalTasaCero.Text = Format(lv_granTotal_TasaCero, "###,###,##0.00")
                        MetroGrid1.Rows(intcount).Cells(3).Value = CDbl(MetroGrid1.Rows(intcount).Cells(3).Value)
                        MetroGrid1.Rows(intcount).Cells(9).Value = CDbl(MetroGrid1.Rows(intcount).Cells(9).Value)
                        MetroGrid1.Rows(intcount).Cells(7).Value = CDbl(MetroGrid1.Rows(intcount).Cells(7).Value)
                        Exit Sub
                    End If
                    intcount += 1

                Next stRow

                add_record_datagrid(strProducto)
            Else
                add_record_datagrid(strProducto)
            End If

            For i = 0 To MetroGrid1.RowCount - 1
                MetroGrid1.Rows(i).Cells(8).Value = Trim(Replace(MetroGrid1.Rows(i).Cells(8).Value, "$", ""))
                Dim lv_total As Double = MetroGrid1.Rows(i).Cells(8).Value
                lv_granSubTotal = lv_granSubTotal + lv_total
                If MetroGrid1.Rows(i).Cells(13).Value = False Then
                    lv_granIVA = lv_granIVA + FormatNumber((lv_total * (FactorIVA - 1)), 2)
                    lv_granTotal = lv_granTotal + FormatNumber((lv_total + (lv_total * (FactorIVA - 1))))
                    gv_tasa_16 = True
                Else
                    lv_granTotal = lv_granTotal + FormatNumber(lv_total, 2)
                    lv_granTotal_TasaCero = lv_granTotal_TasaCero + FormatNumber(lv_total, 2)
                    lv_granSubTotal_TasaCero = lv_granSubTotal_TasaCero + lv_total
                    gv_tasa_0 = True
                End If
                MetroGrid1.Rows(i).Cells(8).Value = lv_total
            Next
            txtSubTotal.Text = Format(lv_granSubTotal, "###,###,##0.00")
            txtIVA.Text = Format(lv_granIVA, "###,###,##0.00")
            txtTotal.Text = Format(lv_granTotal, "###,###,##0.00")
            txtSubTotalTasaCero.Text = Format(lv_granSubTotal_TasaCero, "###,###,##0.00")
            txtIVATasaCero.Text = Format(lv_granIVA_TasaCero, "###,###,##0.00")
            txtTotalTasaCero.Text = Format(lv_granTotal_TasaCero, "###,###,##0.00")
            txtProducto.Clear()
            txtProducto.Select()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Articulo no existe en el Sistema.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub add_record_datagrid(ByVal strProducto As tblProductos)
        Select Case idTipoPrecioCliente
            Case "Precio Publico"
                Dim lv_pp1 As Double
                If strProducto.TasaCero = 0 Then
                    lv_pp1 = FormatNumber(strProducto.precioPublico / FactorIVA, 2)
                Else
                    lv_pp1 = FormatNumber(strProducto.precioPublico, 2)
                End If
                Dim row As String() = New String() {"1",
                                                    strProducto.IdProducto,
                                                    strProducto.descripcionProducto,
                                                    FormatNumber(lv_pp1, 2),
                                                    FormatNumber(lv_pp1, 2),
                                                    strProducto.clave,
                                                    "0",
                                                    FormatNumber(lv_pp1, 2),
                                                    FormatNumber(lv_pp1, 2),
                                                    strProducto.precioCosto,
                                                    strProducto.precioCosto,
                                                    strProducto.ClaveProducto,
                                                    strProducto.ClaveUnidad,
                                                    strProducto.TasaCero}
                MetroGrid1.Rows.Add(row)
            Case "Precio Público"
                Dim lv_pp2 As Double
                If strProducto.TasaCero = 0 Then
                    lv_pp2 = FormatNumber(strProducto.precioPublico / FactorIVA, 2)
                Else
                    lv_pp2 = FormatNumber(strProducto.precioPublico, 2)
                End If
                Dim row As String() = New String() {"1",
                                                    strProducto.IdProducto,
                                                    strProducto.descripcionProducto,
                                                    FormatNumber(lv_pp2, 2),
                                                    FormatNumber(lv_pp2, 2),
                                                    strProducto.clave,
                                                    "0",
                                                    FormatNumber(lv_pp2, 2),
                                                    FormatNumber(lv_pp2, 2),
                                                    strProducto.precioCosto,
                                                    strProducto.precioCosto,
                                                    strProducto.ClaveProducto,
                                                    strProducto.ClaveUnidad,
                                                    strProducto.TasaCero}
                MetroGrid1.Rows.Add(row)
            Case "Precio P1"
                Dim lv_ppp1 As Double
                If strProducto.TasaCero = 0 Then
                    lv_ppp1 = FormatNumber(strProducto.precioP1 / FactorIVA, 2)
                Else
                    lv_ppp1 = FormatNumber(strProducto.precioP1, 2)
                End If
                Dim row As String() = New String() {"1",
                                                    strProducto.IdProducto,
                                                    strProducto.descripcionProducto,
                                                    FormatNumber(lv_ppp1, 2),
                                                    FormatNumber(lv_ppp1, 2),
                                                    strProducto.clave,
                                                    "0",
                                                    FormatNumber(lv_ppp1, 2),
                                                    FormatNumber(lv_ppp1, 2),
                                                    strProducto.precioCosto,
                                                    strProducto.precioCosto,
                                                    strProducto.ClaveProducto,
                                                    strProducto.ClaveUnidad,
                                                    strProducto.TasaCero}
                MetroGrid1.Rows.Add(row)
            Case "Precio P2"
                Dim lv_ppp2 As Double
                If strProducto.TasaCero = 0 Then
                    lv_ppp2 = FormatNumber(strProducto.precioP2 / FactorIVA, 2)
                Else
                    lv_ppp2 = FormatNumber(strProducto.precioP2, 2)
                End If
                Dim row As String() = New String() {"1",
                                                    strProducto.IdProducto,
                                                    strProducto.descripcionProducto,
                                                    FormatNumber(lv_ppp2, 2),
                                                    FormatNumber(lv_ppp2, 2),
                                                    strProducto.clave,
                                                    "0",
                                                    FormatNumber(lv_ppp2, 2),
                                                    FormatNumber(lv_ppp2, 2),
                                                    strProducto.precioCosto,
                                                    strProducto.precioCosto,
                                                    strProducto.ClaveProducto,
                                                    strProducto.ClaveUnidad,
                                                    strProducto.TasaCero}
                MetroGrid1.Rows.Add(row)
            Case "Precio P3"
                Dim lv_ppp3 As Double
                If strProducto.TasaCero = 0 Then
                    lv_ppp3 = FormatNumber(strProducto.precioP3 / FactorIVA, 2)
                Else
                    lv_ppp3 = FormatNumber(strProducto.precioP3, 2)
                End If
                Dim row As String() = New String() {"1",
                                                    strProducto.IdProducto,
                                                    strProducto.descripcionProducto,
                                                    FormatNumber(lv_ppp3, 2),
                                                    FormatNumber(lv_ppp3, 2),
                                                    strProducto.clave,
                                                    "0",
                                                    FormatNumber(lv_ppp3, 2),
                                                    FormatNumber(lv_ppp3, 2),
                                                    strProducto.precioCosto,
                                                    strProducto.precioCosto,
                                                    strProducto.ClaveProducto,
                                                    strProducto.ClaveUnidad,
                                                    strProducto.TasaCero}
                MetroGrid1.Rows.Add(row)
            Case Else
                Dim lv_pp3 As Double
                If strProducto.TasaCero = 0 Then
                    lv_pp3 = FormatNumber(strProducto.precioPublico / FactorIVA, 2)
                Else
                    lv_pp3 = FormatNumber(strProducto.precioPublico, 2)
                End If
                Dim row As String() = New String() {"1",
                                                    strProducto.IdProducto,
                                                    strProducto.descripcionProducto,
                                                    FormatNumber(lv_pp3, 2),
                                                    FormatNumber(lv_pp3, 2),
                                                    strProducto.clave,
                                                    "0",
                                                    FormatNumber(lv_pp3, 2),
                                                    FormatNumber(lv_pp3, 2),
                                                    strProducto.precioCosto,
                                                    strProducto.precioCosto,
                                                    strProducto.ClaveProducto,
                                                    strProducto.ClaveUnidad,
                                                    strProducto.TasaCero}
                MetroGrid1.Rows.Add(row)
        End Select
    End Sub

    Private Sub MetroGrid1_KeyDown(sender As Object, e As KeyEventArgs) Handles MetroGrid1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Dim lv_granTotal As Double = 0
                If MetroGrid1.Item(0, MetroGrid1.CurrentRow.Index).Value > -1 Then
                    FrmDescuento.lblDescripcion.Text = MetroGrid1.Item(2, MetroGrid1.CurrentRow.Index).Value
                    FrmDescuento.NupCantidad.Text = MetroGrid1.Item(0, MetroGrid1.CurrentRow.Index).Value
                    FrmDescuento.NupPrecio.Text = Replace(MetroGrid1.Item(3, MetroGrid1.CurrentRow.Index).Value, "$", "")
                    FrmDescuento.NupDescuento.Text = MetroGrid1.Item(6, MetroGrid1.CurrentRow.Index).Value
                    FrmDescuento.ShowDialog()
                    txtProducto.Focus()
                    txtProducto.SelectAll()
                End If
            Else
                txtProducto.Focus()
                txtProducto.SelectAll()
            End If
        Catch ex As Exception
            txtProducto.Focus()
            txtProducto.SelectAll()
        End Try
    End Sub

    Private Sub Procesa_Pedido_Contado(ByVal nFolio As String, ByVal TasaCero As Boolean)
        If PagoContadoEfectuado = True Then
            Dim lv_subtotal = txtSubTotal.Text.ToString
            Dim lv_iva = txtIVA.Text.ToString
            Dim lv_total = txtTotal.Text.ToString
            Dim lv_subtotal_TasaCero = txtSubTotalTasaCero.Text.ToString
            Dim lv_iva_TasaCero = txtIVATasaCero.Text.ToString
            Dim lv_total_TasaCero = txtTotalTasaCero.Text.ToString
            Dim strVentaPedido As New tblVentaPedido
            Dim strTicketPedido As New tblTicketPedido

            lv_subtotal = Trim(lv_subtotal.Replace("$", ""))
            lv_subtotal = Trim(lv_subtotal.Replace(",", ""))
            lv_iva = Trim(lv_iva.Replace("$", ""))
            lv_iva = Trim(lv_iva.Replace(",", ""))
            lv_total = Trim(lv_total.Replace("$", ""))
            lv_total = Trim(lv_total.Replace(",", ""))
            lv_subtotal_TasaCero = Trim(lv_subtotal_TasaCero.Replace("$", ""))
            lv_subtotal_TasaCero = Trim(lv_subtotal_TasaCero.Replace(",", ""))
            lv_iva_TasaCero = Trim(lv_iva_TasaCero.Replace("$", ""))
            lv_iva_TasaCero = Trim(lv_iva_TasaCero.Replace(",", ""))
            lv_total_TasaCero = Trim(lv_total_TasaCero.Replace("$", ""))
            lv_total_TasaCero = Trim(lv_total_TasaCero.Replace(",", ""))
            lv_subtotal = Val(lv_subtotal) - Val(lv_subtotal_TasaCero)
            lv_subtotal = Trim(lv_subtotal)
            lv_total = Val(lv_total) - Val(lv_total_TasaCero)
            lv_total = Trim(lv_total)

            strVentaPedido.nticket = nFolio
            strVentaPedido.fecha = DateTime.Now.ToString("yyyy-MM-dd")
            If TasaCero = True Then
                strVentaPedido.SubTotal = lv_subtotal_TasaCero
                strVentaPedido.IVA = "0.00"
                strVentaPedido.total = lv_total_TasaCero
            ElseIf TasaCero = False Then
                strVentaPedido.SubTotal = lv_subtotal
                strVentaPedido.IVA = lv_iva
                strVentaPedido.total = lv_total
            End If
            strVentaPedido.tipo = "CONTADO"
            strVentaPedido.usuario = "Admin"
            strVentaPedido.cliente = txtCliente.Text
            strVentaPedido.idCliente = Val(idClienteVenta)
            strVentaPedido.estado = "VENDIDO"
            strVentaPedido.motivo = ""
            strVentaPedido.numeroFactura = ""
            If DBModelo.Insert_PV_VentaPedidos(strVentaPedido) = False Then
                MetroFramework.MetroMessageBox.Show(Me, "Error al Insertar en Tabla Venta_Pedido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Error_Venta = True
                Exit Sub
            End If

            For i = 0 To MetroGrid1.RowCount - 1
                Dim lv_pu = MetroGrid1.Rows(i).Cells(7).Value.ToString '3
                lv_pu = Trim(lv_pu.Replace("$", " "))
                lv_pu = Trim(lv_pu.Replace(",", " "))
                lv_pu = Trim(lv_pu.Replace(" ", ""))

                Dim lv_subtal = MetroGrid1.Rows(i).Cells(8).Value.ToString '3
                lv_subtal = Trim(lv_subtal.Replace("$", " "))
                lv_subtal = Trim(lv_subtal.Replace(",", " "))
                lv_subtal = Trim(lv_subtal.Replace(" ", ""))

                Dim lv_precosto = MetroGrid1.Rows(i).Cells(9).Value.ToString '9
                lv_precosto = Trim(lv_precosto.Replace("$", " "))
                lv_precosto = Trim(lv_precosto.Replace(",", " "))
                lv_precosto = Trim(lv_precosto.Replace(" ", ""))

                Dim lv_subcosto = MetroGrid1.Rows(i).Cells(10).Value.ToString
                lv_subcosto = Trim(lv_subcosto.Replace("$", " "))
                lv_subcosto = Trim(lv_subcosto.Replace(",", " "))
                lv_subcosto = Trim(lv_subcosto.Replace(" ", ""))

                Dim lv_precio_cantidad = (MetroGrid1.Rows(i).Cells(9).Value.ToString * MetroGrid1.Rows(i).Cells(0).Value.ToString)

                If TasaCero = True And MetroGrid1.Rows(i).Cells(13).Value = True Then
                ElseIf TasaCero = False And MetroGrid1.Rows(i).Cells(13).Value = False Then
                Else
                    GoTo SiguienteRegistro
                End If

                strTicketPedido.folio = nFolio
                strTicketPedido.concepto = MetroGrid1.Rows(i).Cells(2).Value.ToString
                strTicketPedido.cantidad = MetroGrid1.Rows(i).Cells(0).Value.ToString
                strTicketPedido.precio = lv_pu
                strTicketPedido.fecha = DateTime.Now.ToString("yyyy-MM-dd")
                strTicketPedido.subtotal = lv_subtal
                strTicketPedido.clave_producto = MetroGrid1.Rows(i).Cells(5).Value.ToString
                strTicketPedido.precioCosto = lv_precosto
                strTicketPedido.subtotalCosto = lv_precio_cantidad
                strTicketPedido.IdProducto = MetroGrid1.Rows(i).Cells(1).Value.ToString
                strTicketPedido.numeroFactura = ""
                strTicketPedido.ClaveProducto = MetroGrid1.Rows(i).Cells(11).Value.ToString
                strTicketPedido.ClaveUnidad = MetroGrid1.Rows(i).Cells(12).Value.ToString
                strTicketPedido.TasaCero = MetroGrid1.Rows(i).Cells(13).Value.ToString
                If DBModelo.Insert_PV_TicketPedidos(strTicketPedido) = False Then
                    MetroFramework.MetroMessageBox.Show(Me, "Error al Insertar en Tabla Ticket_Pedido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Error_Venta = True
                End If
SiguienteRegistro:
            Next
            MetroFramework.MetroMessageBox.Show(Me, "Pedido de Contado # " & nFolio & " generado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Error_Venta = True
        End If
    End Sub

    Private Sub Procesa_Ticket_Contado(ByVal nFolio As String, ByVal TasaCero As Boolean)
        If PagoContadoEfectuado = True Then
            Dim lv_subtotal = txtSubTotal.Text.ToString
            Dim lv_iva = txtIVA.Text.ToString
            Dim lv_total = txtTotal.Text.ToString
            Dim lv_subtotal_TasaCero = txtSubTotalTasaCero.Text.ToString
            Dim lv_iva_TasaCero = txtIVATasaCero.Text.ToString
            Dim lv_total_TasaCero = txtTotalTasaCero.Text.ToString
            Dim strVenta As New tblVenta
            Dim strTicket As New tblTicket


            lv_subtotal = Trim(lv_subtotal.Replace("$", ""))
            lv_subtotal = Trim(lv_subtotal.Replace(",", ""))
            lv_iva = Trim(lv_iva.Replace("$", ""))
            lv_iva = Trim(lv_iva.Replace(",", ""))
            lv_total = Trim(lv_total.Replace("$", ""))
            lv_total = Trim(lv_total.Replace(",", ""))
            lv_subtotal_TasaCero = Trim(lv_subtotal_TasaCero.Replace("$", ""))
            lv_subtotal_TasaCero = Trim(lv_subtotal_TasaCero.Replace(",", ""))
            lv_iva_TasaCero = Trim(lv_iva_TasaCero.Replace("$", ""))
            lv_iva_TasaCero = Trim(lv_iva_TasaCero.Replace(",", ""))
            lv_total_TasaCero = Trim(lv_total_TasaCero.Replace("$", ""))
            lv_total_TasaCero = Trim(lv_total_TasaCero.Replace(",", ""))
            lv_subtotal = Val(lv_subtotal) - Val(lv_subtotal_TasaCero)
            lv_subtotal = Trim(lv_subtotal)
            lv_total = Val(lv_total) - Val(lv_total_TasaCero)
            lv_total = Trim(lv_total)

            strVenta.nticket = nFolio
            strVenta.fecha = DateTime.Now.ToString("yyyy-MM-dd")
            If TasaCero = True Then
                strVenta.SubTotal = lv_subtotal_TasaCero
                strVenta.IVA = "0.00"
                strVenta.total = lv_total_TasaCero
            ElseIf TasaCero = False Then
                strVenta.SubTotal = lv_subtotal
                strVenta.IVA = lv_iva
                strVenta.total = lv_total
            End If
            strVenta.tipo = "CONTADO"
            strVenta.usuario = "Admin"
            strVenta.cliente = txtCliente.Text
            strVenta.idCliente = Val(idClienteVenta)
            strVenta.estado = "VENDIDO"
            strVenta.motivo = ""
            strVenta.numeroFactura = ""

            If DBModelo.Insert_PV_Venta(strVenta) = False Then
                MetroFramework.MetroMessageBox.Show(Me, "Error al Insertar en Tabla Venta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Error_Venta = True
                Exit Sub
            End If
            For i = 0 To MetroGrid1.RowCount - 1
                Dim lv_pu = MetroGrid1.Rows(i).Cells(7).Value.ToString '3
                lv_pu = Trim(lv_pu.Replace("$", " "))
                lv_pu = Trim(lv_pu.Replace(",", " "))
                lv_pu = Trim(lv_pu.Replace(" ", ""))

                Dim lv_subtal = MetroGrid1.Rows(i).Cells(8).Value.ToString '3
                lv_subtal = Trim(lv_subtal.Replace("$", " "))
                lv_subtal = Trim(lv_subtal.Replace(",", " "))
                lv_subtal = Trim(lv_subtal.Replace(" ", ""))

                Dim lv_precosto = MetroGrid1.Rows(i).Cells(9).Value.ToString '9
                lv_precosto = Trim(lv_precosto.Replace("$", " "))
                lv_precosto = Trim(lv_precosto.Replace(",", " "))
                lv_precosto = Trim(lv_precosto.Replace(" ", ""))

                Dim lv_subcosto = MetroGrid1.Rows(i).Cells(10).Value.ToString
                lv_subcosto = Trim(lv_subcosto.Replace("$", " "))
                lv_subcosto = Trim(lv_subcosto.Replace(",", " "))
                lv_subcosto = Trim(lv_subcosto.Replace(" ", ""))

                Dim lv_precio_cantidad = (MetroGrid1.Rows(i).Cells(9).Value.ToString * MetroGrid1.Rows(i).Cells(0).Value.ToString)
                If TasaCero = True And MetroGrid1.Rows(i).Cells(13).Value = True Then

                ElseIf TasaCero = False And MetroGrid1.Rows(i).Cells(13).Value = False Then

                Else
                    GoTo SiguienteRegistro
                End If

                strTicket.folio = nFolio
                strTicket.concepto = MetroGrid1.Rows(i).Cells(2).Value.ToString
                strTicket.cantidad = MetroGrid1.Rows(i).Cells(0).Value.ToString
                strTicket.precio = lv_pu
                strTicket.fecha = FormatDateTime(Now, DateFormat.ShortDate)
                strTicket.subtotal = lv_subtal
                strTicket.clave_producto = MetroGrid1.Rows(i).Cells(5).Value.ToString
                strTicket.precioCosto = lv_precosto
                strTicket.subtotalCosto = lv_precio_cantidad
                strTicket.IdProducto = MetroGrid1.Rows(i).Cells(1).Value.ToString
                strTicket.numeroFactura = ""
                strTicket.ClaveProducto = MetroGrid1.Rows(i).Cells(11).Value.ToString
                strTicket.ClaveUnidad = MetroGrid1.Rows(i).Cells(12).Value.ToString
                strTicket.TasaCero = MetroGrid1.Rows(i).Cells(13).Value.ToString

                If DBModelo.Insert_PV_Ticket(strTicket) = False Then
                    MetroFramework.MetroMessageBox.Show(Me, "Error al Insertar en Tabla Ticket", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Error_Venta = True
                    Exit Sub
                End If
SiguienteRegistro:
            Next
            MetroFramework.MetroMessageBox.Show(Me, "Ticket de Contado # " & nFolio & " generado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Error_Venta = True
        End If
    End Sub

    Private Function Limite_credito() As Boolean
        Dim lv_total = txtTotal.Text.ToString
        Dim lv_totalAdeudo As Double = 0
        Dim lv_limiteActual = 0

        Error_Limite_Credito = False
        idClienteVenta = txtIdCliente.Text
        If idClienteVenta = "0" Or idClienteVenta = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Favor de Seleccionar un Cliente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Console.WriteLine("Err 1")
            txtCliente.Focus()
            Error_Limite_Credito = True
        End If

        lv_totalAdeudo = DBModelo.Get_PV_Cliente_SUM(txtIdCliente.Text)
        Cliente_limite = DBModelo.Get_PV_Cliente_Limite(txtIdCliente.Text)

        lv_limiteActual = (Val(Cliente_limite) - Val(lv_totalAdeudo))

        If lv_total > lv_limiteActual Then
            MetroFramework.MetroMessageBox.Show(Me, "Se ha exedido el Límite de Crédito para este Cliente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Error_Limite_Credito = True
        End If
        Return Error_Limite_Credito
    End Function

    Private Sub Procesa_Pedido_Credito(ByVal nFolio As String, ByVal TasaCero As Boolean)
        Dim lv_subtotal = txtSubTotal.Text.ToString
        Dim lv_iva = txtIVA.Text.ToString
        Dim lv_total = txtTotal.Text.ToString
        Dim lv_subtotal_TasaCero = txtSubTotalTasaCero.Text.ToString
        Dim lv_iva_TasaCero = txtIVATasaCero.Text.ToString
        Dim lv_total_TasaCero = txtTotalTasaCero.Text.ToString
        Dim strVentaPedido As New tblVentaPedido
        Dim strTicketPedido As New tblTicketPedido

        lv_subtotal = Trim(lv_subtotal.Replace("$", ""))
        lv_subtotal = Trim(lv_subtotal.Replace(",", ""))
        lv_iva = Trim(lv_iva.Replace("$", ""))
        lv_iva = Trim(lv_iva.Replace(",", ""))
        lv_total = Trim(lv_total.Replace("$", ""))
        lv_total = Trim(lv_total.Replace(",", ""))
        lv_subtotal_TasaCero = Trim(lv_subtotal_TasaCero.Replace("$", ""))
        lv_subtotal_TasaCero = Trim(lv_subtotal_TasaCero.Replace(",", ""))
        lv_iva_TasaCero = Trim(lv_iva_TasaCero.Replace("$", ""))
        lv_iva_TasaCero = Trim(lv_iva_TasaCero.Replace(",", ""))
        lv_total_TasaCero = Trim(lv_total_TasaCero.Replace("$", ""))
        lv_total_TasaCero = Trim(lv_total_TasaCero.Replace(",", ""))
        lv_subtotal = Val(lv_subtotal) - Val(lv_subtotal_TasaCero)
        lv_subtotal = Trim(lv_subtotal)
        lv_total = Val(lv_total) - Val(lv_total_TasaCero)
        lv_total = Trim(lv_total)

        strVentaPedido.nticket = nFolio
        strVentaPedido.fecha = DateTime.Now.ToString("yyyy-MM-dd")
        If TasaCero = True Then
            strVentaPedido.SubTotal = lv_subtotal_TasaCero
            strVentaPedido.IVA = "0.00"
            strVentaPedido.total = lv_total_TasaCero
        ElseIf TasaCero = False Then
            strVentaPedido.SubTotal = lv_subtotal
            strVentaPedido.IVA = lv_iva
            strVentaPedido.total = lv_total
        End If
        strVentaPedido.tipo = "CREDITO"
        strVentaPedido.usuario = "Admin"
        strVentaPedido.cliente = txtCliente.Text
        strVentaPedido.idCliente = Val(idClienteVenta)
        strVentaPedido.estado = "VENDIDO"
        strVentaPedido.motivo = ""
        strVentaPedido.numeroFactura = ""
        If DBModelo.Insert_PV_VentaPedidos(strVentaPedido) = False Then
            MetroFramework.MetroMessageBox.Show(Me, "Error al Insertar en Tabla Venta_Pedido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Error_Venta = True
            Exit Sub
        End If

        For i = 0 To MetroGrid1.RowCount - 1
            Dim lv_pu = MetroGrid1.Rows(i).Cells(7).Value.ToString '3
            lv_pu = Trim(lv_pu.Replace("$", " "))
            lv_pu = Trim(lv_pu.Replace(",", " "))
            lv_pu = Trim(lv_pu.Replace(" ", ""))

            Dim lv_subtal = MetroGrid1.Rows(i).Cells(8).Value.ToString '3
            lv_subtal = Trim(lv_subtal.Replace("$", " "))
            lv_subtal = Trim(lv_subtal.Replace(",", " "))
            lv_subtal = Trim(lv_subtal.Replace(" ", ""))

            Dim lv_precosto = MetroGrid1.Rows(i).Cells(9).Value.ToString '9
            lv_precosto = Trim(lv_precosto.Replace("$", " "))
            lv_precosto = Trim(lv_precosto.Replace(",", " "))
            lv_precosto = Trim(lv_precosto.Replace(" ", ""))

            Dim lv_subcosto = MetroGrid1.Rows(i).Cells(10).Value.ToString
            lv_subcosto = Trim(lv_subcosto.Replace("$", " "))
            lv_subcosto = Trim(lv_subcosto.Replace(",", " "))
            lv_subcosto = Trim(lv_subcosto.Replace(" ", ""))

            Dim lv_precio_cantidad = (MetroGrid1.Rows(i).Cells(9).Value.ToString * MetroGrid1.Rows(i).Cells(0).Value.ToString)

            If TasaCero = True And MetroGrid1.Rows(i).Cells(13).Value = True Then
            ElseIf TasaCero = False And MetroGrid1.Rows(i).Cells(13).Value = False Then
            Else
                GoTo SiguienteRegistro
            End If

            strTicketPedido.folio = nFolio
            strTicketPedido.concepto = MetroGrid1.Rows(i).Cells(2).Value.ToString
            strTicketPedido.cantidad = MetroGrid1.Rows(i).Cells(0).Value.ToString
            strTicketPedido.precio = lv_pu
            strTicketPedido.fecha = DateTime.Now.ToString("yyyy-MM-dd")
            strTicketPedido.subtotal = lv_subtal
            strTicketPedido.clave_producto = MetroGrid1.Rows(i).Cells(5).Value.ToString
            strTicketPedido.precioCosto = lv_precosto
            strTicketPedido.subtotalCosto = lv_precio_cantidad
            strTicketPedido.IdProducto = MetroGrid1.Rows(i).Cells(1).Value.ToString
            strTicketPedido.numeroFactura = ""
            strTicketPedido.ClaveProducto = MetroGrid1.Rows(i).Cells(11).Value.ToString
            strTicketPedido.ClaveUnidad = MetroGrid1.Rows(i).Cells(12).Value.ToString
            strTicketPedido.TasaCero = MetroGrid1.Rows(i).Cells(13).Value.ToString
            If DBModelo.Insert_PV_TicketPedidos(strTicketPedido) = False Then
                MetroFramework.MetroMessageBox.Show(Me, "Error al Insertar en Tabla Ticket_Pedido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Error_Venta = True
            End If

SiguienteRegistro:
        Next

        Dim lv_fechaventa As String = Format(DateTime.Now.Date, "yyyy-MM-dd")
        Dim lv_fechalimite As String = Format(DateTime.Now.AddDays(Cliente_diasCredito), "yyyy-MM-dd")
        Dim strCobrar As New tblCobrar

        strCobrar.n_remision = nFolio
        If TasaCero = True Then
            strCobrar.total = lv_total_TasaCero
            strCobrar.resto = lv_total_TasaCero
        Else
            strCobrar.total = lv_total
            strCobrar.resto = lv_total
        End If
        strCobrar.fecha_venta = lv_fechaventa
        strCobrar.fecha_limite = lv_fechalimite
        strCobrar.cliente = txtCliente.Text
        strCobrar.claveCliente = idClienteVenta
        strCobrar.tipoDocumento = "PEDIDO"

        If DBModelo.Insert_PV_Cobrar(strCobrar) = False Then
            MetroFramework.MetroMessageBox.Show(Me, "Error al Insertar en Tabla Cobrar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Error_Venta = True
            Exit Sub
        End If

        MetroFramework.MetroMessageBox.Show(Me, "Pedido de Crédito # " & nFolio & " generado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtTotal.Text = Format("0", "0.00")

    End Sub

    Private Sub Procesa_Ticket_Credito(ByVal nFolio As String, ByVal TasaCero As Boolean)
        Console.WriteLine("AA 1")
        Dim lv_subtotal = txtSubTotal.Text.ToString
        Dim lv_iva = txtIVA.Text.ToString
        Dim lv_total = txtTotal.Text.ToString
        Dim lv_subtotal_TasaCero = txtSubTotalTasaCero.Text.ToString
        Dim lv_iva_TasaCero = txtIVATasaCero.Text.ToString
        Dim lv_total_TasaCero = txtTotalTasaCero.Text.ToString
        Dim strVenta As New tblVenta
        Dim strTicket As New tblTicket

        lv_subtotal = Trim(lv_subtotal.Replace("$", ""))
        lv_subtotal = Trim(lv_subtotal.Replace(",", ""))
        lv_iva = Trim(lv_iva.Replace("$", ""))
        lv_iva = Trim(lv_iva.Replace(",", ""))
        lv_total = Trim(lv_total.Replace("$", ""))
        lv_total = Trim(lv_total.Replace(",", ""))
        lv_subtotal_TasaCero = Trim(lv_subtotal_TasaCero.Replace("$", ""))
        lv_subtotal_TasaCero = Trim(lv_subtotal_TasaCero.Replace(",", ""))
        lv_iva_TasaCero = Trim(lv_iva_TasaCero.Replace("$", ""))
        lv_iva_TasaCero = Trim(lv_iva_TasaCero.Replace(",", ""))
        lv_total_TasaCero = Trim(lv_total_TasaCero.Replace("$", ""))
        lv_total_TasaCero = Trim(lv_total_TasaCero.Replace(",", ""))
        lv_subtotal = Val(lv_subtotal) - Val(lv_subtotal_TasaCero)
        lv_subtotal = Trim(lv_subtotal)
        lv_total = Val(lv_total) - Val(lv_total_TasaCero)
        lv_total = Trim(lv_total)

        Dim lv_totalAdeudo As Double = 0
        Dim lv_limiteActual = 0

        If idClienteVenta = "0" Or idClienteVenta = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Favor de Seleccionar un Cliente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Console.WriteLine("Err 2")
            txtCliente.Focus()
            Error_Venta = True
            Exit Sub
        End If

        lv_totalAdeudo = DBModelo.Get_PV_Cliente_SUM(txtIdCliente.Text)

        Cliente_limite = DBModelo.Get_PV_Cliente_Limite(txtIdCliente.Text)

        lv_limiteActual = (Val(Cliente_limite) - Val(lv_totalAdeudo))

        If lv_total > lv_limiteActual Then
            MetroFramework.MetroMessageBox.Show(Me, "Se ha exedido el Límite de Crédito para este Cliente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Error_Limite_Credito = True
            Error_Venta = True
            Exit Sub
        End If

        strVenta.nticket = nFolio
        strVenta.fecha = DateTime.Now.ToString("yyyy-MM-dd")
        If TasaCero = True Then
            strVenta.SubTotal = lv_subtotal_TasaCero
            strVenta.IVA = "0.00"
            strVenta.total = lv_total_TasaCero
        ElseIf TasaCero = False Then
            strVenta.SubTotal = lv_subtotal
            strVenta.IVA = lv_iva
            strVenta.total = lv_total
        End If
        strVenta.tipo = "CREDITO"
        strVenta.usuario = "Admin"
        strVenta.cliente = txtCliente.Text
        strVenta.idCliente = Val(idClienteVenta)
        strVenta.estado = "VENDIDO"
        strVenta.motivo = ""
        strVenta.numeroFactura = ""
        If DBModelo.Insert_PV_Venta(strVenta) = False Then
            MetroFramework.MetroMessageBox.Show(Me, "Error al Insertar en Tabla Venta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Error_Venta = True
            Exit Sub
        End If

        For i = 0 To MetroGrid1.RowCount - 1
            Dim lv_pu = MetroGrid1.Rows(i).Cells(7).Value.ToString '3
            lv_pu = Trim(lv_pu.Replace("$", " "))
            lv_pu = Trim(lv_pu.Replace(",", " "))
            lv_pu = Trim(lv_pu.Replace(" ", ""))

            Dim lv_subtal = MetroGrid1.Rows(i).Cells(8).Value.ToString '3
            lv_subtal = Trim(lv_subtal.Replace("$", " "))
            lv_subtal = Trim(lv_subtal.Replace(",", " "))
            lv_subtal = Trim(lv_subtal.Replace(" ", ""))

            Dim lv_precosto = MetroGrid1.Rows(i).Cells(9).Value.ToString '9
            lv_precosto = Trim(lv_precosto.Replace("$", " "))
            lv_precosto = Trim(lv_precosto.Replace(",", " "))
            lv_precosto = Trim(lv_precosto.Replace(" ", ""))

            Dim lv_subcosto = MetroGrid1.Rows(i).Cells(10).Value.ToString
            lv_subcosto = Trim(lv_subcosto.Replace("$", " "))
            lv_subcosto = Trim(lv_subcosto.Replace(",", " "))
            lv_subcosto = Trim(lv_subcosto.Replace(" ", ""))


            Dim lv_precio_cantidad = (MetroGrid1.Rows(i).Cells(9).Value.ToString * MetroGrid1.Rows(i).Cells(0).Value.ToString)
            Console.WriteLine(MetroGrid1.Rows(i).Cells(13).Value)
            If TasaCero = True And MetroGrid1.Rows(i).Cells(13).Value = True Then
            ElseIf TasaCero = False And MetroGrid1.Rows(i).Cells(13).Value = False Then
            Else
                GoTo SiguienteRegistro
            End If

            strTicket.folio = nFolio
            strTicket.concepto = MetroGrid1.Rows(i).Cells(2).Value
            strTicket.cantidad = CDbl(MetroGrid1.Rows(i).Cells(0).Value)
            strTicket.precio = lv_pu
            strTicket.fecha = DateTime.Now.ToString("yyyy-MM-dd")
            strTicket.subtotal = lv_subtal
            strTicket.clave_producto = MetroGrid1.Rows(i).Cells(5).Value
            strTicket.precioCosto = lv_precosto
            strTicket.subtotalCosto = lv_precio_cantidad
            strTicket.IdProducto = MetroGrid1.Rows(i).Cells(1).Value
            strTicket.numeroFactura = ""
            strTicket.ClaveProducto = MetroGrid1.Rows(i).Cells(11).Value
            strTicket.ClaveUnidad = MetroGrid1.Rows(i).Cells(12).Value
            strTicket.TasaCero = False
            If MetroGrid1.Rows(i).Cells(13).Value = True
                strTicket.TasaCero = True
            End If

            If DBModelo.Insert_PV_Ticket(strTicket) = False Then
                MetroFramework.MetroMessageBox.Show(Me, "Error al Insertar en Tabla Ticket", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Error_Venta = True
                Exit Sub    
            End If

SiguienteRegistro:
        Next

        Dim lv_fechaventa As String = Format(DateTime.Now.Date, "yyyy-MM-dd")
        Dim lv_fechalimite As String = Format(DateTime.Now.AddDays(Cliente_diasCredito), "yyyy-MM-dd")
        Dim strCobrar As New tblCobrar

        strCobrar.n_remision = nFolio
        If TasaCero = True Then
            strCobrar.total = lv_total_TasaCero
            strCobrar.resto = lv_total_TasaCero
        Else
            strCobrar.total = lv_total
            strCobrar.resto = lv_total
        End If
        strCobrar.fecha_venta = lv_fechaventa
        strCobrar.fecha_limite = lv_fechalimite
        strCobrar.cliente = txtCliente.Text
        strCobrar.claveCliente = idClienteVenta
        strCobrar.tipoDocumento = "TICKET"

        If DBModelo.Insert_PV_Cobrar(strCobrar) = False Then
            MetroFramework.MetroMessageBox.Show(Me, "Error al Insertar en Tabla Cobrar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Error_Venta = True
            Exit Sub
        End If

        MetroFramework.MetroMessageBox.Show(Me, "Ticket de Crédito # " & nFolio & " generado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub CmbTipoVenta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbTipoVenta.SelectedIndexChanged
        Select Case CmbTipoVenta.Text
            Case "CREDITO"
                If EsCotizacion = False Then
                    Call lblBuscarC_Click(sender, e)
                    If txtIdCliente.Text = "" Then
                        CmbTipoVenta.SelectedIndex = 0
                    End If
                End If
            Case "CONTADO"
                Contado()
        End Select
    End Sub

    Private Sub Contado()
        idClienteVenta = ""
        idTipoPrecioCliente = ""
        idClienteVenta = 0
        Error_Venta = False
        EsCotizacion = False
        txtCliente.Text = "PUBLICO GENERAL"
        txtIdCliente.Clear()
        txtDomicilio.Clear()
        txtProducto.Focus()
    End Sub

    Private Sub Procesa_Cotizacion(ByVal nFolio As String, ByVal TasaCero As Boolean)

        Dim lv_subtotal = txtSubTotal.Text.ToString
        Dim lv_iva = txtIVA.Text.ToString
        Dim lv_total = txtTotal.Text.ToString
        Dim lv_subtotal_TasaCero = txtSubTotalTasaCero.Text.ToString
        Dim lv_iva_TasaCero = txtIVATasaCero.Text.ToString
        Dim lv_total_TasaCero = txtTotalTasaCero.Text.ToString
        Dim strCotizacion As New tblCotizacion
        Dim strTicketCotizacion As New tblTicketCotiza

        lv_subtotal = Trim(lv_subtotal.Replace("$", ""))
        lv_subtotal = Trim(lv_subtotal.Replace(",", ""))
        lv_iva = Trim(lv_iva.Replace("$", ""))
        lv_iva = Trim(lv_iva.Replace(",", ""))
        lv_total = Trim(lv_total.Replace("$", ""))
        lv_total = Trim(lv_total.Replace(",", ""))
        lv_subtotal_TasaCero = Trim(lv_subtotal_TasaCero.Replace("$", ""))
        lv_subtotal_TasaCero = Trim(lv_subtotal_TasaCero.Replace(",", ""))
        lv_iva_TasaCero = Trim(lv_iva_TasaCero.Replace("$", ""))
        lv_iva_TasaCero = Trim(lv_iva_TasaCero.Replace(",", ""))
        lv_total_TasaCero = Trim(lv_total_TasaCero.Replace("$", ""))
        lv_total_TasaCero = Trim(lv_total_TasaCero.Replace(",", ""))
        lv_subtotal = Val(lv_subtotal) - Val(lv_subtotal_TasaCero)
        lv_subtotal = Trim(lv_subtotal)
        lv_total = Val(lv_total) - Val(lv_total_TasaCero)
        lv_total = Trim(lv_total)

        If idClienteVenta = "0" Then
            MetroFramework.MetroMessageBox.Show(Me, "Favor de Seleccionar un Cliente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MsgBox("Favor de Seleccionar un Cliente", MsgBoxStyle.Information, "Cotización")
            Console.WriteLine("Err 3")
            txtCliente.Focus()
            Error_Venta = True
            Exit Sub
        End If

        strCotizacion.nticket = nFolio
        strCotizacion.fecha = DateTime.Now.ToString("yyyy-MM-dd")
        If TasaCero = True Then
            strCotizacion.SubTotal = lv_subtotal_TasaCero
            strCotizacion.IVA = "0.00"
            strCotizacion.total = lv_total_TasaCero
        Else
            strCotizacion.SubTotal = lv_subtotal
            strCotizacion.IVA = lv_iva
            strCotizacion.total = lv_total
        End If
        strCotizacion.tipo = "CONTADO"
        strCotizacion.usuario = usuario
        strCotizacion.cliente = txtCliente.Text
        strCotizacion.idCliente = idClienteVenta
        strCotizacion.estado = "VENDIDO"
        strCotizacion.motivo = ""
        strCotizacion.numeroFactura = ""
        If DBModelo.Insert_PV_Cotizacion(strCotizacion) = False Then
            MetroFramework.MetroMessageBox.Show(Me, "Error al Insertar en Tabla Cotizacion", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Error_Venta = True
            Exit Sub
        End If

        For i = 0 To MetroGrid1.RowCount - 1
            Dim lv_pu = MetroGrid1.Rows(i).Cells(7).Value.ToString '3
            lv_pu = Trim(lv_pu.Replace("$", " "))
            lv_pu = Trim(lv_pu.Replace(",", " "))
            lv_pu = Trim(lv_pu.Replace(" ", ""))

            Dim lv_subtal = MetroGrid1.Rows(i).Cells(8).Value.ToString '3
            lv_subtal = Trim(lv_subtal.Replace("$", " "))
            lv_subtal = Trim(lv_subtal.Replace(",", " "))
            lv_subtal = Trim(lv_subtal.Replace(" ", ""))

            Dim lv_precosto = MetroGrid1.Rows(i).Cells(9).Value.ToString '9
            lv_precosto = Trim(lv_precosto.Replace("$", " "))
            lv_precosto = Trim(lv_precosto.Replace(",", " "))
            lv_precosto = Trim(lv_precosto.Replace(" ", ""))

            Dim lv_subcosto = MetroGrid1.Rows(i).Cells(10).Value.ToString
            lv_subcosto = Trim(lv_subcosto.Replace("$", " "))
            lv_subcosto = Trim(lv_subcosto.Replace(",", " "))
            lv_subcosto = Trim(lv_subcosto.Replace(" ", ""))

            Dim lv_precio_cantidad = (MetroGrid1.Rows(i).Cells(9).Value.ToString * MetroGrid1.Rows(i).Cells(0).Value.ToString)

            If TasaCero = True And MetroGrid1.Rows(i).Cells(13).Value = True Then
            ElseIf TasaCero = False And MetroGrid1.Rows(i).Cells(13).Value = False Then
            Else
                GoTo SiguienteRegistro
            End If

            strTicketCotizacion.folio = nFolio
            strTicketCotizacion.concepto = MetroGrid1.Rows(i).Cells(2).Value.ToString
            strTicketCotizacion.cantidad = MetroGrid1.Rows(i).Cells(0).Value.ToString
            strTicketCotizacion.precio = lv_pu
            strTicketCotizacion.fecha = DateTime.Now.ToString("yyyy-MM-dd")
            strTicketCotizacion.subtotal = lv_subtal
            strTicketCotizacion.clave_producto = MetroGrid1.Rows(i).Cells(5).Value.ToString
            strTicketCotizacion.precioCosto = lv_precosto
            strTicketCotizacion.subtotalCosto = lv_precio_cantidad
            strTicketCotizacion.IdProducto = MetroGrid1.Rows(i).Cells(1).Value.ToString
            strTicketCotizacion.ClaveProducto = MetroGrid1.Rows(i).Cells(11).Value.ToString
            strTicketCotizacion.ClaveUnidad = MetroGrid1.Rows(i).Cells(12).Value.ToString
            strTicketCotizacion.TasaCero = MetroGrid1.Rows(i).Cells(13).Value.ToString

            If DBModelo.Insert_PV_TicketCotizacion(strTicketCotizacion) = False Then
                MetroFramework.MetroMessageBox.Show(Me, "Error al Insertar en Tabla Ticket_Cotiza", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Error_Venta = True
                Exit Sub
            End If

SiguienteRegistro:
        Next

        MetroFramework.MetroMessageBox.Show(Me, "Cotizacion # " & nFolio & " generada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub CmbDocto_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CmbDocto.SelectedIndexChanged

        If CmbDocto.Text = "COTIZACION" Then
            CmbTipoVenta.SelectedIndex = 0
            CmbTipoVenta.Enabled = False
            Call lblBuscarC_Click(sender, e)
        End If

        If CmbDocto.Text = "PEDIDO" Then
            If CmbTipoVenta.Text = "CONTADO" Then
                If CotFlag = False Then
                    Contado()
                End If
            End If
            CmbTipoVenta.Enabled = True
        End If

        If CmbDocto.Text = "TICKET" Then
            If CmbTipoVenta.Text = "CONTADO" Then
                If CotFlag = False Then
                    Contado()
                End If
            End If
            CmbTipoVenta.Enabled = True
        End If
    End Sub

    Private Sub MetroGrid1_KeyUp(sender As Object, e As KeyEventArgs) Handles MetroGrid1.KeyUp
        Dim lv_granTotal As Double = 0
        Dim lv_granSubTotal As Double = 0
        Dim lv_granIVA As Double = 0
        Dim lv_granSubTotal_TasaCero As Double = 0
        Dim lv_granIVA_TasaCero As Double = 0
        Dim lv_granTotal_TasaCero As Double = 0
        If e.KeyCode = Keys.Delete Then
            For i = 0 To MetroGrid1.RowCount - 1
                MetroGrid1.Rows(i).Cells(8).Value = Trim(Replace(MetroGrid1.Rows(i).Cells(8).Value, "$", ""))
                Dim lv_total As Double = MetroGrid1.Rows(i).Cells(8).Value
                lv_granSubTotal = lv_granSubTotal + lv_total
                If MetroGrid1.Rows(i).Cells(13).Value = False Then
                    lv_granIVA = lv_granIVA + FormatNumber((lv_total * (FactorIVA - 1)), 2)
                    lv_granTotal = lv_granTotal + FormatNumber((lv_total + (lv_total * (FactorIVA - 1))))
                    gv_tasa_16 = True
                Else
                    lv_granTotal = lv_granTotal + FormatNumber(lv_total, 2)
                    lv_granTotal_TasaCero = lv_granTotal_TasaCero + FormatNumber(lv_total, 2)
                    lv_granSubTotal_TasaCero = lv_granSubTotal_TasaCero + lv_total
                    gv_tasa_0 = True
                End If
                MetroGrid1.Rows(i).Cells(8).Value = lv_total
            Next
            txtSubTotal.Text = Format(lv_granSubTotal, "###,###,##0.00")
            txtIVA.Text = Format(lv_granIVA, "###,###,##0.00")
            txtTotal.Text = Format(lv_granTotal, "###,###,##0.00")
            txtSubTotalTasaCero.Text = Format(lv_granSubTotal_TasaCero, "###,###,##0.00")
            txtIVATasaCero.Text = Format(lv_granIVA_TasaCero, "###,###,##0.00")
            txtTotalTasaCero.Text = Format(lv_granTotal_TasaCero, "###,###,##0.00")
        End If
    End Sub

    Private Sub MetroGrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellDoubleClick
        Try
            If MetroGrid1.Item(0, MetroGrid1.CurrentRow.Index).Value > -1 Then
                Dim lv_granTotal As Double = 0
                FrmDescuento.lblDescripcion.Text = MetroGrid1.Item(2, MetroGrid1.CurrentRow.Index).Value
                FrmDescuento.NupCantidad.Text = MetroGrid1.Item(0, MetroGrid1.CurrentRow.Index).Value
                FrmDescuento.NupPrecio.Text = Replace(MetroGrid1.Item(3, MetroGrid1.CurrentRow.Index).Value, "$", "")
                FrmDescuento.NupDescuento.Value = MetroGrid1.Item(6, MetroGrid1.CurrentRow.Index).Value
                SetFormName(FrmDescuento, DBConnected)
                FrmDescuento.ShowDialog()
                FrmDescuento.Close()
                FrmDescuento.Dispose()
                txtProducto.Focus()
                txtProducto.SelectAll()
            Else
                txtProducto.Focus()
                txtProducto.SelectAll()
            End If
        Catch ex As Exception
            txtProducto.Focus()
            txtProducto.SelectAll()
        End Try
    End Sub

    Private Sub CrearTicket(TasaCero As Boolean)
        Dim lv_folio As Integer = 0
        Dim lv_folioactual As Integer = 0
        Dim nuevo = 0
        Dim strFoliosTicket As New tblFoliosTicket

        Error_Limite_Credito = False
        Error_Venta = False
        idClienteVenta = txtIdCliente.Text

        lv_folio = DBModelo.Get_PV_FoliosTicketActual(Now.Year, gv_terminal, CmbDocto.Text)

        If lv_folio = 0 Then
            strFoliosTicket.Year = Now.Year
            strFoliosTicket.IdTerminal = gv_terminal
            strFoliosTicket.DocType = TipoDocumento
            strFoliosTicket.FolioActual = 1
            If DBModelo.Insert_PV_FoliosTicketActual(strFoliosTicket) Then
                lv_folio = 1
                lv_folioactual = Val(gv_terminal.ToString & Now.Year.ToString & lv_folio.ToString)
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Error al intentar Crear registro en FoliosTicket", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            lv_folioactual = Val(gv_terminal.ToString & Now.Year.ToString & lv_folio.ToString)
            strFoliosTicket = DBModelo.Get_PV_FoliosTicket(Now.Year, gv_terminal, CmbDocto.Text)
        End If

        Select Case TipoDocumento
            Case "PEDIDO"
                MetroFramework.MetroMessageBox.Show(Me, "N° Pedido a Generar: " & lv_folioactual, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case "TICKET"
                MetroFramework.MetroMessageBox.Show(Me, "N° Ticket a Generar: " & lv_folioactual, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case "COTIZACION"
                MetroFramework.MetroMessageBox.Show(Me, "N° Cotización a Generar: " & lv_folioactual, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select

        '---------------------------------------PEDIDO CONTADO----------------------------------------------------------------[]
        If TipoDocumento = "PEDIDO" And CmbTipoVenta.Text = "CONTADO" Then
            idClienteVenta = "0"
            Procesa_Pedido_Contado(lv_folioactual, TasaCero)
        End If
        '------------------------------------TICKET CONTADO-----------------------------------------------------------------------[]
        If TipoDocumento = "TICKET" And CmbTipoVenta.Text = "CONTADO" Then
            idClienteVenta = "0"
            Procesa_Ticket_Contado(lv_folioactual, TasaCero)
        End If
        '-----------------------------------------PEDIDO CREDITO--------------------------------------------------------------------
        If TipoDocumento = "PEDIDO" And CmbTipoVenta.Text = "CREDITO" Then
            Procesa_Pedido_Credito(lv_folioactual, TasaCero)
        End If
        '-----------------------------------------TICKET CREDITO--------------------------------------------------------------------
        If TipoDocumento = "TICKET" And CmbTipoVenta.Text = "CREDITO" Then
            Procesa_Ticket_Credito(lv_folioactual, TasaCero)
        End If
        '-----------------------------------------COTIZACION--------------------------------------------------------------------
        If TipoDocumento = "COTIZACION" Then
            Procesa_Cotizacion(lv_folioactual, TasaCero)
        End If

        If Error_Limite_Credito = False Then
            lv_folio = lv_folio + 1
            If Not IsNothing(strFoliosTicket) Then
                strFoliosTicket.FolioActual = lv_folio
                If DBModelo.Update_PV_FoliosTicketActual(strFoliosTicket) = False Then
                    MetroFramework.MetroMessageBox.Show(Me, "No se pudo Actualizar registro en la tabla FOLIOSTICKETS", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Error_Venta = False
                    Exit Sub
                End If
            End If

            If Error_Venta = False Then
                If TipoDocumento <> "COTIZACION" Then
                    For i = 0 To MetroGrid1.RowCount - 1
                        If DBModelo.Update_PV_Producto_Stock(CDbl(MetroGrid1.Rows(i).Cells(0).Value), CInt(MetroGrid1.Rows(i).Cells(1).Value)) = False Then
                            MetroFramework.MetroMessageBox.Show(Me, "No se pudo Actualizar Inventario en la tabla PRODUCTOS", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Error_Venta = False
                        End If
                    Next

                    If ImprimeVenta(lv_folioactual, True, CmbDocto.Text, PV_Contado_Paga, PV_Contado_Cambio, DBConnected) = False Then
                        MetroFramework.MetroMessageBox.Show(Me, "Error al Generar la Impresión de el Ticket/Pedido, favor de Re-Imprimir", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Call NuevaVenta()
                        Exit Sub
                    End If
                Else
                    If ImprimeCotizacion(lv_folioactual, True, CmbDocto.Text, DBConnected) = False Then
                        MetroFramework.MetroMessageBox.Show(Me, "Error al Generar la Impresión de la Cotización, favor de Re-Imprimir", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Call NuevaVenta()
                        Exit Sub
                    End If

                End If
            End If
        Else
            Error_Venta = False
            Error_Limite_Credito = False
        End If
    End Sub

    Private Sub lblBuscarP_Click(sender As Object, e As EventArgs) Handles lblBuscarP.Click
        SetFormName(FrmBuscarProductosPV, DBConnected)
        FrmBuscarProductosPV.ShowDialog()
        FrmBuscarProductosPV.Close()
        FrmBuscarProductosPV.Dispose()

        If AccionSalir = False Then
            Add_Record_to_DGV()
        End If
        txtProducto.Select()
    End Sub

    Private Sub lblBuscarC_Click(sender As Object, e As EventArgs) Handles lblBuscarC.Click
        If CmbTipoVenta.Text = "CREDITO" Then
            Buscar_Clientes = "VENTAS"
            Cliente_diasCredito = 0
            Cliente_limite = 0
            SetFormName(FrmBuscarClientesVentas, DBConnected)
            FrmBuscarClientesVentas.ShowDialog()
            FrmBuscarClientesVentas.Close()
            FrmBuscarClientesVentas.Dispose()
            txtProducto.Select()
        End If
        If CmbTipoVenta.Text = "CONTADO" And CmbDocto.Text = "COTIZACION" Then
            Buscar_Clientes = "VENTAS"
            Cliente_diasCredito = 0
            Cliente_limite = 0
            SetFormName(FrmBuscarClientesVentas, DBConnected)
            FrmBuscarClientesVentas.ShowDialog()
            FrmBuscarClientesVentas.Close()
            FrmBuscarClientesVentas.Dispose()
            txtProducto.Select()
        End If
    End Sub

    Private Sub lblDescuento_Click(sender As Object, e As EventArgs) Handles lblDescuento.Click
        If MetroGrid1.RowCount <> 0 Then
            FrmDescuentoGeneral.mtbDesc.Value = MetroGrid1.Item(6, MetroGrid1.CurrentRow.Index).Value
            FrmDescuentoGeneral.ShowDialog()
            FrmDescuentoGeneral.Close()
            FrmDescuentoGeneral.Dispose()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "No hay productos en la lista", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub lblCobrar_Click(sender As Object, e As EventArgs) Handles lblCobrar.Click
        PV_Contado_Cambio = ""
        PV_Contado_Paga = ""
        TipoDocumento = CmbDocto.Text
        If TipoDocumento = "COTIZACION" And CmbTipoVenta.Text = "CONTADO" And (txtIdCliente.Text = "0" Or txtIdCliente.Text = "") Then
            MetroFramework.MetroMessageBox.Show(Me, "Cliente es obligatorio para hacer una cotización, Favor de seleccionar un cliente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If MetroGrid1.RowCount <> 0 Then
            If CmbTipoVenta.Text = "CONTADO" Then
                If TipoDocumento <> "COTIZACION" Then
                    FrmCobrar.ShowDialog()
                    FrmCobrar.Close()
                    FrmCobrar.Dispose()
                    If PagoContadoEfectuado = False Then
                        Exit Sub
                    End If
                End If
            End If
            If CmbTipoVenta.Text = "CREDITO" Then
                If Limite_credito() = False Then
                    If gv_tasa_0 = True Then
                        CrearTicket(True)
                    End If
                    If gv_tasa_16 = True Then
                        CrearTicket(False)
                    End If
                    Call NuevaVenta()
                End If
            Else
                If gv_tasa_0 = True Then
                    CrearTicket(True)
                End If
                If gv_tasa_16 = True Then
                    CrearTicket(False)
                End If
                Call NuevaVenta()
            End If
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Ventan no puede ser realizada sin productos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class