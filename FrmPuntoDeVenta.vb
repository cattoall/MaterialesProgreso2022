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
                    Call btnBuscarC_Click(sender, e)
                End If
            Case Keys.F8
                Call btnDescuento_Click(sender, e)
            Case Keys.F3
                If MetroFramework.MetroMessageBox.Show(Me, "¿Estás seguro de crear una nueva venta?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    NuevaVenta()
                End If
            Case Keys.F2
                Call btnBuscarP_Click(sender, e)
            Case Keys.F9
                If DataGridView1.Rows.Count > 0 Then
                    Call btnCobrar_Click(sender, e)
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "Ventan no puede ser realizada sin productos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
        End Select
    End Sub

    Private Sub NuevaVenta()
        CmbDocto.SelectedIndex = 0
        CmbTipoVenta.SelectedIndex = 0
        DataGridView1.Refresh()
        DataGridView1.Rows.Clear()
        DataGridView1.ResumeLayout()
        txtProducto.Select()
        idClienteVenta = ""
        idTipoPrecioCliente = ""
        txtCliente.Text = "PUBLICO GENERAL"
        idClienteVenta = CStr(0)
        Error_Venta = False
        EsCotizacion = False
        gv_tasa_0 = False
        gv_tasa_16 = False
        TipoDocumento = ""
        txtSubTotal.Clear()
        txtSubTotalTasaCero.Clear()
        txtIVA.Clear()
        txtIVATasaCero.Clear()
        txtTotal.Clear()
        txtTotalTasaCero.Clear()
    End Sub

    Private Sub FrmPuntoDeVenta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtProducto.Select()
        DataGridView1.ResumeLayout()
        DataGridView1.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridView1.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
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
        MetroPanel1.Left = CInt((Width / 2) - (MetroPanel1.Width / 2))
    End Sub

    Private Sub txtProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProducto.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Add_Record_to_DGV()
        End If
    End Sub

    Private Sub Add_Record_to_DGV()
        Dim strProducto As tblProductos = DBModelo.Get_PV_Producto(txtProducto.Text)
        If Not IsNothing(strProducto) Then
            If strProducto.ClaveProducto = "" Then
                MetroFramework.MetroMessageBox.Show(Me, "Producto: " & strProducto.descripcionProducto & " no tiene ClaveProducto SAT definido.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If strProducto.ClaveUnidad = "" Then
                MetroFramework.MetroMessageBox.Show(Me, "Producto: " & strProducto.descripcionProducto & " no tiene ClaveUnidad SAT definida.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If DataGridView1.Rows.Count > 0 Then
                Dim intcount As Integer = 0
                For Each stRow As DataGridViewRow In DataGridView1.Rows
                    If CLng(stRow.Cells(1).Value) = strProducto.IdProducto Then
                        stRow.Cells(0).Value = CInt(stRow.Cells(0).Value) + 1
                        stRow.Cells(3).Value = Trim(Replace(CStr(stRow.Cells(3).Value), "$", "")) ' / FactorIVA
                        stRow.Cells(9).Value = Trim(Replace(CStr(stRow.Cells(9).Value), "$", ""))
                        stRow.Cells(7).Value = Trim(Replace(CStr(stRow.Cells(7).Value), "$", "")) ' / FactorIVA

                        stRow.Cells(4).Value = CDec(stRow.Cells(3).Value) * CDec(stRow.Cells(0).Value)
                        stRow.Cells(10).Value = CDec(stRow.Cells(9).Value) * CDec(stRow.Cells(0).Value)
                        stRow.Cells(8).Value = CDec(stRow.Cells(7).Value) * CDec(stRow.Cells(0).Value)

                        actualizaTotales()
                        Exit Sub
                    End If
                    intcount += 1

                Next stRow

                add_record_datagrid(strProducto)
            Else
                add_record_datagrid(strProducto)
            End If

            actualizaTotales()

            txtProducto.Clear()
            txtProducto.Select()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Articulo no existe en el Sistema.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub actualizaTotales()
        Dim lv_granSubTotal As Double = 0
        Dim lv_granIVA As Double = 0
        Dim lv_IVA As Double = 0
        Dim lv_granTotal As Double = 0
        Dim lv_granSubTotal_TasaCero As Double = 0
        Dim lv_granIVA_TasaCero As Double = 0
        Dim lv_granTotal_TasaCero As Double = 0

        txtProducto.Clear()
        txtProducto.Select()
        For Each lc_stRow As DataGridViewRow In DataGridView1.Rows
            lc_stRow.Cells(8).Value = Trim(Replace(CStr(lc_stRow.Cells(8).Value), "$", ""))
            Dim lv_total As Double = CDbl(lc_stRow.Cells(8).Value)
            lv_granSubTotal = lv_granSubTotal + lv_total
            If CBool(lc_stRow.Cells(13).Value) = False Then
                lv_IVA = CDbl(FormatNumber(lv_total * (CDbl(FactorIVA) - 1), 10))
                lv_granIVA = lv_granIVA + lv_IVA
                lv_granTotal = lv_granTotal + lv_total + lv_IVA
                gv_tasa_16 = True
            Else
                lv_granTotal = lv_granTotal + CDbl(lv_total)
                lv_granSubTotal_TasaCero = lv_granSubTotal_TasaCero + lv_total
                lv_granTotal_TasaCero = lv_granTotal_TasaCero + lv_total
                gv_tasa_0 = True
            End If
            lc_stRow.Cells(8).Value = lv_total
        Next

        txtSubTotal.Text = FormatNumber(lv_granSubTotal, 6)
        txtIVA.Text = FormatNumber(lv_granIVA, 6)
        txtTotal.Text = FormatNumber(lv_granTotal, 2)
        txtSubTotalTasaCero.Text = FormatNumber(lv_granSubTotal_TasaCero, 6)
        txtIVATasaCero.Text = FormatNumber(lv_granIVA_TasaCero, 6)
        txtTotalTasaCero.Text = FormatNumber(lv_granTotal_TasaCero, 2)

    End Sub

    Private Sub add_record_datagrid(ByVal strProducto As tblProductos)
        Select Case idTipoPrecioCliente
            Case "Precio Publico"
                Dim lv_pp1 As Double
                If strProducto.TasaCero = CBool(0) Then
                    lv_pp1 = CDbl(FormatNumber(CDbl(strProducto.precioPublico) / CDbl(FactorIVA), 6))
                Else
                    lv_pp1 = CDbl(FormatNumber(strProducto.precioPublico, 6))
                End If
                Dim row As String() = New String() {"1",
                                                    strProducto.IdProducto.ToString,
                                                    strProducto.descripcionProducto,
                                                    FormatNumber(lv_pp1, 6),
                                                    FormatNumber(lv_pp1, 6),
                                                    strProducto.clave,
                                                    "0",
                                                    FormatNumber(lv_pp1, 6),
                                                    FormatNumber(lv_pp1, 6),
                                                    strProducto.precioCosto.ToString,
                                                    strProducto.precioCosto.ToString,
                                                    strProducto.ClaveProducto,
                                                    strProducto.ClaveUnidad,
                                                    strProducto.TasaCero.ToString}
                DataGridView1.Rows.Add(row)
            Case "Precio Público"
                Dim lv_pp2 As Double
                If strProducto.TasaCero = CBool(0) Then
                    lv_pp2 = CDbl(FormatNumber(CDbl(strProducto.precioPublico) / CDbl(FactorIVA), 6))
                Else
                    lv_pp2 = CDbl(FormatNumber(strProducto.precioPublico, 6))
                End If
                Dim row As String() = New String() {"1",
                                                    strProducto.IdProducto.ToString,
                                                    strProducto.descripcionProducto,
                                                    FormatNumber(lv_pp2, 6),
                                                    FormatNumber(lv_pp2, 6),
                                                    strProducto.clave,
                                                    "0",
                                                    FormatNumber(lv_pp2, 6),
                                                    FormatNumber(lv_pp2, 6),
                                                    strProducto.precioCosto.ToString,
                                                    strProducto.precioCosto.ToString,
                                                    strProducto.ClaveProducto,
                                                    strProducto.ClaveUnidad,
                                                    strProducto.TasaCero.ToString}
                DataGridView1.Rows.Add(row)
            Case "Precio P1"
                Dim lv_ppp1 As Double
                If strProducto.TasaCero = CBool(0) Then
                    lv_ppp1 = CDbl(FormatNumber(CDbl(strProducto.precioP1) / CDbl(FactorIVA), 6))
                Else
                    lv_ppp1 = CDbl(FormatNumber(strProducto.precioP1, 6))
                End If
                Dim row As String() = New String() {"1",
                                                    strProducto.IdProducto.ToString,
                                                    strProducto.descripcionProducto,
                                                    FormatNumber(lv_ppp1, 6),
                                                    FormatNumber(lv_ppp1, 6),
                                                    strProducto.clave,
                                                    "0",
                                                    FormatNumber(lv_ppp1, 6),
                                                    FormatNumber(lv_ppp1, 6),
                                                    strProducto.precioCosto.ToString,
                                                    strProducto.precioCosto.ToString,
                                                    strProducto.ClaveProducto,
                                                    strProducto.ClaveUnidad,
                                                    strProducto.TasaCero.ToString}
                DataGridView1.Rows.Add(row)
            Case "Precio P2"
                Dim lv_ppp2 As Double
                If strProducto.TasaCero = CBool(0) Then
                    lv_ppp2 = CDbl(FormatNumber(CDbl(strProducto.precioP2) / CDbl(FactorIVA), 6))
                Else
                    lv_ppp2 = CDbl(FormatNumber(strProducto.precioP2, 6))
                End If
                Dim row As String() = New String() {"1",
                                                    strProducto.IdProducto.ToString,
                                                    strProducto.descripcionProducto,
                                                    FormatNumber(lv_ppp2, 6),
                                                    FormatNumber(lv_ppp2, 6),
                                                    strProducto.clave,
                                                    "0",
                                                    FormatNumber(lv_ppp2, 6),
                                                    FormatNumber(lv_ppp2, 6),
                                                    strProducto.precioCosto.ToString,
                                                    strProducto.precioCosto.ToString,
                                                    strProducto.ClaveProducto,
                                                    strProducto.ClaveUnidad,
                                                    strProducto.TasaCero.ToString}
                DataGridView1.Rows.Add(row)
            Case "Precio P3"
                Dim lv_ppp3 As Double
                If strProducto.TasaCero = CBool(0) Then
                    lv_ppp3 = CDbl(FormatNumber(CDbl(strProducto.precioP3) / CDbl(FactorIVA), 6))
                Else
                    lv_ppp3 = CDbl(FormatNumber(strProducto.precioP3, 6))
                End If
                Dim row As String() = New String() {"1",
                                                    strProducto.IdProducto.ToString,
                                                    strProducto.descripcionProducto,
                                                    FormatNumber(lv_ppp3, 6),
                                                    FormatNumber(lv_ppp3, 6),
                                                    strProducto.clave,
                                                    "0",
                                                    FormatNumber(lv_ppp3, 6),
                                                    FormatNumber(lv_ppp3, 6),
                                                    strProducto.precioCosto.ToString,
                                                    strProducto.precioCosto.ToString,
                                                    strProducto.ClaveProducto,
                                                    strProducto.ClaveUnidad,
                                                    strProducto.TasaCero.ToString}
                DataGridView1.Rows.Add(row)
            Case Else
                Dim lv_pp3 As Double
                If strProducto.TasaCero = CBool(0) Then
                    lv_pp3 = CDbl(FormatNumber(CDbl(strProducto.precioPublico) / CDbl(FactorIVA), 6))
                Else
                    lv_pp3 = CDbl(FormatNumber(strProducto.precioPublico, 6))
                End If
                Dim row As String() = New String() {"1",
                                                    strProducto.IdProducto.ToString,
                                                    strProducto.descripcionProducto,
                                                    FormatNumber(lv_pp3, 6),
                                                    FormatNumber(lv_pp3, 6),
                                                    strProducto.clave,
                                                    "0",
                                                    FormatNumber(lv_pp3, 6),
                                                    FormatNumber(lv_pp3, 6),
                                                    strProducto.precioCosto.ToString,
                                                    strProducto.precioCosto.ToString,
                                                    strProducto.ClaveProducto,
                                                    strProducto.ClaveUnidad,
                                                    strProducto.TasaCero.ToString}
                DataGridView1.Rows.Add(row)
        End Select
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Dim lv_granTotal As Double = 0
                If CDbl(DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value) > 0 Then
                    Dim oFormDescuento As New FrmDescuento
                    oFormDescuento.lblDescripcion.Text = CStr(DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value)
                    oFormDescuento.NupCantidad.Text = CStr(DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value)
                    oFormDescuento.NupPrecio.Text = Replace(CStr(DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value), "$", "")
                    oFormDescuento.txtPorcentaje.Text = CStr(DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value)
                    oFormDescuento.ShowDialog()
                    txtProducto.Focus()
                    txtProducto.SelectAll()
                    oFormDescuento.Close()
                End If
            End If
        Catch ex As Exception
            txtProducto.Focus()
            txtProducto.SelectAll()
        End Try
    End Sub

    Private Sub Procesa_Pedido_Contado(ByVal nFolio As String, ByVal TasaCero As Boolean)
        If PagoContadoEfectuado = True Then
            Dim lv_subtotal = FormatNumber(txtSubTotal.Text, 6)
            Dim lv_iva = FormatNumber(txtIVA.Text, 6)
            Dim lv_total = FormatNumber(txtTotal.Text, 2)
            Dim lv_subtotal_TasaCero = FormatNumber(txtSubTotalTasaCero.Text, 6)
            Dim lv_iva_TasaCero = FormatNumber(txtIVATasaCero.Text, 6)
            Dim lv_total_TasaCero = FormatNumber(txtTotalTasaCero.Text, 2)
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
            lv_subtotal = CStr(CDbl(lv_subtotal) - CDbl(lv_subtotal_TasaCero))
            lv_subtotal = Trim(lv_subtotal)
            lv_total = CStr(CDbl(lv_total) - CDbl(lv_total_TasaCero))
            lv_total = Trim(lv_total)

            strVentaPedido.IdComp = CompanyCode
            strVentaPedido.nticket = CLng(nFolio)
            strVentaPedido.fecha = CDate(Date.Now.ToString("yyyy-MM-dd"))
            If TasaCero = True Then
                strVentaPedido.SubTotal = CDec(lv_subtotal_TasaCero)
                strVentaPedido.IVA = CDec("0.00")
                strVentaPedido.total = CDec(lv_total_TasaCero)
            ElseIf TasaCero = False Then
                strVentaPedido.SubTotal = CDec(lv_subtotal)
                strVentaPedido.IVA = CDec(lv_iva)
                strVentaPedido.total = CDec(lv_total)
            End If
            strVentaPedido.tipo = "CONTADO"
            strVentaPedido.usuario = "Admin"
            strVentaPedido.cliente = txtCliente.Text
            strVentaPedido.idCliente = CLng(idClienteVenta)
            strVentaPedido.estado = "VENDIDO"
            strVentaPedido.motivo = ""
            strVentaPedido.numeroFactura = ""
            If DBModelo.Insert_PV_VentaPedidos(strVentaPedido) = False Then
                MetroFramework.MetroMessageBox.Show(Me, "Error al Insertar en Tabla Venta_Pedido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Error_Venta = True
                Exit Sub
            End If

            For i = 0 To DataGridView1.RowCount - 1
                Dim lv_pu = DataGridView1.Rows(i).Cells(7).Value.ToString '3
                lv_pu = Trim(lv_pu.Replace("$", " "))
                lv_pu = Trim(lv_pu.Replace(",", " "))
                lv_pu = Trim(lv_pu.Replace(" ", ""))

                Dim lv_subtal = DataGridView1.Rows(i).Cells(8).Value.ToString '3
                lv_subtal = Trim(lv_subtal.Replace("$", " "))
                lv_subtal = Trim(lv_subtal.Replace(",", " "))
                lv_subtal = Trim(lv_subtal.Replace(" ", ""))

                Dim lv_precosto = DataGridView1.Rows(i).Cells(9).Value.ToString '9
                lv_precosto = Trim(lv_precosto.Replace("$", " "))
                lv_precosto = Trim(lv_precosto.Replace(",", " "))
                lv_precosto = Trim(lv_precosto.Replace(" ", ""))

                Dim lv_subcosto = DataGridView1.Rows(i).Cells(10).Value.ToString
                lv_subcosto = Trim(lv_subcosto.Replace("$", " "))
                lv_subcosto = Trim(lv_subcosto.Replace(",", " "))
                lv_subcosto = Trim(lv_subcosto.Replace(" ", ""))

                Dim lv_precio_cantidad As Double = CDbl(DataGridView1.Rows(i).Cells(9).Value) * CDbl(DataGridView1.Rows(i).Cells(0).Value)

                If TasaCero = True And CBool(DataGridView1.Rows(i).Cells(13).Value) = True Then
                ElseIf TasaCero = False And CBool(DataGridView1.Rows(i).Cells(13).Value) = False Then
                Else
                    GoTo SiguienteRegistro
                End If

                strTicketPedido.IdComp = CompanyCode
                strTicketPedido.folio = nFolio
                strTicketPedido.concepto = CStr(DataGridView1.Rows(i).Cells(2).Value)
                strTicketPedido.cantidad = CDec(DataGridView1.Rows(i).Cells(0).Value)
                strTicketPedido.precio = CDec(lv_pu)
                strTicketPedido.fecha = CDate(Date.Now.ToString("yyyy-MM-dd"))
                strTicketPedido.subtotal = CDec(lv_subtal)
                strTicketPedido.clave_producto = CStr(DataGridView1.Rows(i).Cells(5).Value)
                strTicketPedido.precioCosto = CDec(lv_precosto)
                strTicketPedido.subtotalCosto = CDec(lv_precio_cantidad)
                strTicketPedido.IdProducto = CLng(DataGridView1.Rows(i).Cells(1).Value)
                strTicketPedido.numeroFactura = ""
                strTicketPedido.ClaveProducto = CStr(DataGridView1.Rows(i).Cells(11).Value)
                strTicketPedido.ClaveUnidad = CStr(DataGridView1.Rows(i).Cells(12).Value)
                strTicketPedido.TasaCero = CBool(DataGridView1.Rows(i).Cells(13).Value)
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
            Dim lv_subtotal = FormatNumber(txtSubTotal.Text, 6)
            Dim lv_iva = FormatNumber(txtIVA.Text, 6)
            Dim lv_total = FormatNumber(txtTotal.Text, 2)
            Dim lv_subtotal_TasaCero = FormatNumber(txtSubTotalTasaCero.Text, 6)
            Dim lv_iva_TasaCero = FormatNumber(txtIVATasaCero.Text, 6)
            Dim lv_total_TasaCero = FormatNumber(txtTotalTasaCero.Text, 2)
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
            lv_subtotal = CStr(CDbl(lv_subtotal) - CDbl(lv_subtotal_TasaCero))
            lv_subtotal = Trim(lv_subtotal)
            lv_total = CStr(CDbl(lv_total) - CDbl(lv_total_TasaCero))
            lv_total = Trim(lv_total)

            strVenta.IdComp = CompanyCode
            strVenta.nticket = CLng(nFolio)
            strVenta.fecha = CDate(Date.Now.ToString("yyyy-MM-dd"))
            If TasaCero = True Then
                strVenta.SubTotal = CDec(lv_subtotal_TasaCero)
                strVenta.IVA = CDec("0.00")
                strVenta.total = CDec(lv_total_TasaCero)
            ElseIf TasaCero = False Then
                strVenta.SubTotal = CDec(lv_subtotal)
                strVenta.IVA = CDec(lv_iva)
                strVenta.total = CDec(lv_total)
            End If
            strVenta.tipo = "CONTADO"
            strVenta.usuario = "Admin"
            strVenta.cliente = txtCliente.Text
            strVenta.idCliente = CLng(idClienteVenta)
            strVenta.estado = "VENDIDO"
            strVenta.motivo = ""
            strVenta.numeroFactura = ""

            If DBModelo.Insert_PV_Venta(strVenta) = False Then
                MetroFramework.MetroMessageBox.Show(Me, "Error al Insertar en Tabla Venta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Error_Venta = True
                Exit Sub
            End If
            For i = 0 To DataGridView1.RowCount - 1
                Dim lv_pu = DataGridView1.Rows(i).Cells(7).Value.ToString '3
                lv_pu = Trim(lv_pu.Replace("$", " "))
                lv_pu = Trim(lv_pu.Replace(",", " "))
                lv_pu = Trim(lv_pu.Replace(" ", ""))

                Dim lv_subtal = DataGridView1.Rows(i).Cells(8).Value.ToString '3
                lv_subtal = Trim(lv_subtal.Replace("$", " "))
                lv_subtal = Trim(lv_subtal.Replace(",", " "))
                lv_subtal = Trim(lv_subtal.Replace(" ", ""))

                Dim lv_precosto = DataGridView1.Rows(i).Cells(9).Value.ToString '9
                lv_precosto = Trim(lv_precosto.Replace("$", " "))
                lv_precosto = Trim(lv_precosto.Replace(",", " "))
                lv_precosto = Trim(lv_precosto.Replace(" ", ""))

                Dim lv_subcosto = DataGridView1.Rows(i).Cells(10).Value.ToString
                lv_subcosto = Trim(lv_subcosto.Replace("$", " "))
                lv_subcosto = Trim(lv_subcosto.Replace(",", " "))
                lv_subcosto = Trim(lv_subcosto.Replace(" ", ""))

                Dim lv_precio_cantidad As Double = CDbl(DataGridView1.Rows(i).Cells(9).Value) * CDbl(DataGridView1.Rows(i).Cells(0).Value)
                If TasaCero = True And CBool(DataGridView1.Rows(i).Cells(13).Value) = True Then

                ElseIf TasaCero = False And CBool(DataGridView1.Rows(i).Cells(13).Value) = False Then

                Else
                    GoTo SiguienteRegistro
                End If

                strTicket.IdComp = CompanyCode
                strTicket.folio = nFolio
                strTicket.concepto = CStr(DataGridView1.Rows(i).Cells(2).Value)
                strTicket.cantidad = CDec(DataGridView1.Rows(i).Cells(0).Value)
                strTicket.precio = CDec(lv_pu)
                strTicket.fecha = CDate(FormatDateTime(Now, DateFormat.ShortDate))
                strTicket.subtotal = CDec(lv_subtal)
                strTicket.clave_producto = DataGridView1.Rows(i).Cells(5).Value.ToString
                strTicket.precioCosto = CDec(lv_precosto)
                strTicket.subtotalCosto = CDec(lv_precio_cantidad)
                strTicket.IdProducto = CLng(DataGridView1.Rows(i).Cells(1).Value)
                strTicket.numeroFactura = ""
                strTicket.ClaveProducto = CStr(DataGridView1.Rows(i).Cells(11).Value)
                strTicket.ClaveUnidad = CStr(DataGridView1.Rows(i).Cells(12).Value)
                strTicket.TasaCero = CBool(DataGridView1.Rows(i).Cells(13).Value)

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
        Dim lv_total As Double = CDbl(txtTotal.Text)
        Dim lv_totalAdeudo As Double = 0
        Dim lv_limiteActual As Double = 0

        Error_Limite_Credito = False
        idClienteVenta = txtIdCliente.Text
        If idClienteVenta = "0" Or idClienteVenta = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Favor de Seleccionar un Cliente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Console.WriteLine("Err 1")
            txtCliente.Focus()
            Error_Limite_Credito = True
        End If

        lv_totalAdeudo = DBModelo.Get_PV_Cliente_SUM(CInt(txtIdCliente.Text))
        Cliente_limite = DBModelo.Get_PV_Cliente_Limite(CInt(txtIdCliente.Text))

        lv_limiteActual = Cliente_limite - lv_totalAdeudo

        If lv_total > lv_limiteActual Then
            MetroFramework.MetroMessageBox.Show(Me, "Se ha exedido el Límite de Crédito para este Cliente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Error_Limite_Credito = True
        End If
        Return Error_Limite_Credito
    End Function

    Private Sub Procesa_Pedido_Credito(ByVal nFolio As String, ByVal TasaCero As Boolean)
        Dim lv_subtotal = FormatNumber(txtSubTotal.Text, 6)
        Dim lv_iva = FormatNumber(txtIVA.Text, 6)
        Dim lv_total = FormatNumber(txtTotal.Text, 2)
        Dim lv_subtotal_TasaCero = FormatNumber(txtSubTotalTasaCero.Text, 6)
        Dim lv_iva_TasaCero = FormatNumber(txtIVATasaCero.Text, 6)
        Dim lv_total_TasaCero = FormatNumber(txtTotalTasaCero.Text, 2)
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
        lv_subtotal = CStr(CDbl(lv_subtotal) - CDbl(lv_subtotal_TasaCero))
        lv_subtotal = Trim(lv_subtotal)
        lv_total = CStr(CDbl(lv_total) - CDbl(lv_total_TasaCero))
        lv_total = Trim(lv_total)

        strVentaPedido.IdComp = CompanyCode
        strVentaPedido.nticket = CLng(nFolio)
        strVentaPedido.fecha = CDate(Date.Now.ToString("yyyy-MM-dd"))
        If TasaCero = True Then
            strVentaPedido.SubTotal = CDec(lv_subtotal_TasaCero)
            strVentaPedido.IVA = CDec("0.00")
            strVentaPedido.total = CDec(lv_total_TasaCero)
        ElseIf TasaCero = False Then
            strVentaPedido.SubTotal = CDec(lv_subtotal)
            strVentaPedido.IVA = CDec(lv_iva)
            strVentaPedido.total = CDec(lv_total)
        End If
        strVentaPedido.tipo = "CREDITO"
        strVentaPedido.usuario = "Admin"
        strVentaPedido.cliente = txtCliente.Text
        strVentaPedido.idCliente = CLng(idClienteVenta)
        strVentaPedido.estado = "VENDIDO"
        strVentaPedido.motivo = ""
        strVentaPedido.numeroFactura = ""
        If DBModelo.Insert_PV_VentaPedidos(strVentaPedido) = False Then
            MetroFramework.MetroMessageBox.Show(Me, "Error al Insertar en Tabla Venta_Pedido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Error_Venta = True
            Exit Sub
        End If

        For i = 0 To DataGridView1.RowCount - 1
            Dim lv_pu = DataGridView1.Rows(i).Cells(7).Value.ToString '3
            lv_pu = Trim(lv_pu.Replace("$", " "))
            lv_pu = Trim(lv_pu.Replace(",", " "))
            lv_pu = Trim(lv_pu.Replace(" ", ""))

            Dim lv_subtal = DataGridView1.Rows(i).Cells(8).Value.ToString '3
            lv_subtal = Trim(lv_subtal.Replace("$", " "))
            lv_subtal = Trim(lv_subtal.Replace(",", " "))
            lv_subtal = Trim(lv_subtal.Replace(" ", ""))

            Dim lv_precosto = DataGridView1.Rows(i).Cells(9).Value.ToString '9
            lv_precosto = Trim(lv_precosto.Replace("$", " "))
            lv_precosto = Trim(lv_precosto.Replace(",", " "))
            lv_precosto = Trim(lv_precosto.Replace(" ", ""))

            Dim lv_subcosto = DataGridView1.Rows(i).Cells(10).Value.ToString
            lv_subcosto = Trim(lv_subcosto.Replace("$", " "))
            lv_subcosto = Trim(lv_subcosto.Replace(",", " "))
            lv_subcosto = Trim(lv_subcosto.Replace(" ", ""))

            Dim lv_precio_cantidad As Double = CDbl(DataGridView1.Rows(i).Cells(9).Value) * CDbl(DataGridView1.Rows(i).Cells(0).Value)

            If TasaCero = True And CBool(DataGridView1.Rows(i).Cells(13).Value) = True Then
            ElseIf TasaCero = False And CBool(DataGridView1.Rows(i).Cells(13).Value) = False Then
            Else
                GoTo SiguienteRegistro
            End If

            strTicketPedido.IdComp = CompanyCode
            strTicketPedido.folio = nFolio
            strTicketPedido.concepto = DataGridView1.Rows(i).Cells(2).Value.ToString
            strTicketPedido.cantidad = CDec(DataGridView1.Rows(i).Cells(0).Value)
            strTicketPedido.precio = CDec(lv_pu)
            strTicketPedido.fecha = CDate(Date.Now.ToString("yyyy-MM-dd"))
            strTicketPedido.subtotal = CDec(lv_subtal)
            strTicketPedido.clave_producto = DataGridView1.Rows(i).Cells(5).Value.ToString
            strTicketPedido.precioCosto = CDec(lv_precosto)
            strTicketPedido.subtotalCosto = CDec(lv_precio_cantidad)
            strTicketPedido.IdProducto = CLng(DataGridView1.Rows(i).Cells(1).Value)
            strTicketPedido.numeroFactura = ""
            strTicketPedido.ClaveProducto = CStr(DataGridView1.Rows(i).Cells(11).Value)
            strTicketPedido.ClaveUnidad = CStr(DataGridView1.Rows(i).Cells(12).Value)
            strTicketPedido.TasaCero = CBool(DataGridView1.Rows(i).Cells(13).Value)
            If DBModelo.Insert_PV_TicketPedidos(strTicketPedido) = False Then
                MetroFramework.MetroMessageBox.Show(Me, "Error al Insertar en Tabla Ticket_Pedido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Error_Venta = True
            End If

SiguienteRegistro:
        Next

        Dim lv_fechaventa As String = Format(DateTime.Now.Date, "yyyy-MM-dd")
        Dim lv_fechalimite As String = Format(DateTime.Now.AddDays(Cliente_diasCredito), "yyyy-MM-dd")
        Dim strCobrar As New tblCobrar

        strCobrar.IdComp = CompanyCode
        strCobrar.n_remision = CLng(nFolio)
        If TasaCero = True Then
            strCobrar.total = CDec(lv_total_TasaCero)
            strCobrar.resto = CDec(lv_total_TasaCero)
        Else
            strCobrar.total = CDec(lv_total)
            strCobrar.resto = CDec(lv_total)
        End If
        strCobrar.fecha_venta = CDate(lv_fechaventa)
        strCobrar.fecha_limite = CDate(lv_fechalimite)
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
        Dim lv_subtotal = FormatNumber(txtSubTotal.Text, 6)
        Dim lv_iva = FormatNumber(txtIVA.Text, 6)
        Dim lv_total = FormatNumber(txtTotal.Text, 2)
        Dim lv_subtotal_TasaCero = FormatNumber(txtSubTotalTasaCero.Text, 6)
        Dim lv_iva_TasaCero = FormatNumber(txtIVATasaCero.Text, 6)
        Dim lv_total_TasaCero = FormatNumber(txtTotalTasaCero.Text, 2)
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
        lv_subtotal = CStr(CDbl(lv_subtotal) - CDbl(lv_subtotal_TasaCero))
        lv_subtotal = Trim(lv_subtotal)
        lv_total = CStr(CDbl(lv_total) - CDbl(lv_total_TasaCero))
        lv_total = Trim(lv_total)

        Dim lv_totalAdeudo As Double = 0
        Dim lv_limiteActual As Double = 0

        If idClienteVenta = "0" Or idClienteVenta = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Favor de Seleccionar un Cliente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Console.WriteLine("Err 2")
            txtCliente.Focus()
            Error_Venta = True
            Exit Sub
        End If

        lv_totalAdeudo = DBModelo.Get_PV_Cliente_SUM(CInt(txtIdCliente.Text))

        Cliente_limite = DBModelo.Get_PV_Cliente_Limite(CInt(txtIdCliente.Text))

        lv_limiteActual = Cliente_limite - lv_totalAdeudo

        If CDbl(lv_total) > lv_limiteActual Then
            MetroFramework.MetroMessageBox.Show(Me, "Se ha exedido el Límite de Crédito para este Cliente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Error_Limite_Credito = True
            Error_Venta = True
            Exit Sub
        End If

        strVenta.IdComp = CompanyCode
        strVenta.nticket = CLng(nFolio)
        strVenta.fecha = CDate(Date.Now.ToString("yyyy-MM-dd"))
        If TasaCero = True Then
            strVenta.SubTotal = CDec(lv_subtotal_TasaCero)
            strVenta.IVA = CDec("0.00")
            strVenta.total = CDec(lv_total_TasaCero)
        ElseIf TasaCero = False Then
            strVenta.SubTotal = CDec(lv_subtotal)
            strVenta.IVA = CDec(lv_iva)
            strVenta.total = CDec(lv_total)
        End If
        strVenta.tipo = "CREDITO"
        strVenta.usuario = "Admin"
        strVenta.cliente = txtCliente.Text
        strVenta.idCliente = CLng(idClienteVenta)
        strVenta.estado = "VENDIDO"
        strVenta.motivo = ""
        strVenta.numeroFactura = ""
        If DBModelo.Insert_PV_Venta(strVenta) = False Then
            MetroFramework.MetroMessageBox.Show(Me, "Error al Insertar en Tabla Venta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Error_Venta = True
            Exit Sub
        End If

        For i = 0 To DataGridView1.RowCount - 1
            Dim lv_pu = DataGridView1.Rows(i).Cells(7).Value.ToString '3
            lv_pu = Trim(lv_pu.Replace("$", " "))
            lv_pu = Trim(lv_pu.Replace(",", " "))
            lv_pu = Trim(lv_pu.Replace(" ", ""))

            Dim lv_subtal = DataGridView1.Rows(i).Cells(8).Value.ToString '3
            lv_subtal = Trim(lv_subtal.Replace("$", " "))
            lv_subtal = Trim(lv_subtal.Replace(",", " "))
            lv_subtal = Trim(lv_subtal.Replace(" ", ""))

            Dim lv_precosto = DataGridView1.Rows(i).Cells(9).Value.ToString '9
            lv_precosto = Trim(lv_precosto.Replace("$", " "))
            lv_precosto = Trim(lv_precosto.Replace(",", " "))
            lv_precosto = Trim(lv_precosto.Replace(" ", ""))

            Dim lv_subcosto = DataGridView1.Rows(i).Cells(10).Value.ToString
            lv_subcosto = Trim(lv_subcosto.Replace("$", " "))
            lv_subcosto = Trim(lv_subcosto.Replace(",", " "))
            lv_subcosto = Trim(lv_subcosto.Replace(" ", ""))


            Dim lv_precio_cantidad As Double = CDbl(DataGridView1.Rows(i).Cells(9).Value) * CDbl(DataGridView1.Rows(i).Cells(0).Value)
            If TasaCero = True And CBool(DataGridView1.Rows(i).Cells(13).Value) = True Then
            ElseIf TasaCero = False And CBool(DataGridView1.Rows(i).Cells(13).Value) = False Then
            Else
                GoTo SiguienteRegistro
            End If

            strTicket.IdComp = CompanyCode
            strTicket.folio = nFolio
            strTicket.concepto = CStr(DataGridView1.Rows(i).Cells(2).Value)
            strTicket.cantidad = CDec(DataGridView1.Rows(i).Cells(0).Value)
            strTicket.precio = CDec(lv_pu)
            strTicket.fecha = CDate(Date.Now.ToString("yyyy-MM-dd"))
            strTicket.subtotal = CDec(lv_subtal)
            strTicket.clave_producto = CStr(DataGridView1.Rows(i).Cells(5).Value)
            strTicket.precioCosto = CDec(lv_precosto)
            strTicket.subtotalCosto = CDec(lv_precio_cantidad)
            strTicket.IdProducto = CLng(DataGridView1.Rows(i).Cells(1).Value)
            strTicket.numeroFactura = ""
            strTicket.ClaveProducto = CStr(DataGridView1.Rows(i).Cells(11).Value)
            strTicket.ClaveUnidad = CStr(DataGridView1.Rows(i).Cells(12).Value)
            strTicket.TasaCero = False
            If CBool(DataGridView1.Rows(i).Cells(13).Value) = True Then
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

        strCobrar.IdComp = CompanyCode
        strCobrar.n_remision = CLng(nFolio)
        If TasaCero = True Then
            strCobrar.total = CDec(lv_total_TasaCero)
            strCobrar.resto = CDec(lv_total_TasaCero)
        Else
            strCobrar.total = CDec(lv_total)
            strCobrar.resto = CDec(lv_total)
        End If
        strCobrar.fecha_venta = CDate(lv_fechaventa)
        strCobrar.fecha_limite = CDate(lv_fechalimite)
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
                    Call btnBuscarC_Click(sender, e)
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
        idClienteVenta = CStr(0)
        Error_Venta = False
        EsCotizacion = False
        txtCliente.Text = "PUBLICO GENERAL"
        txtIdCliente.Clear()
        txtDomicilio.Clear()
        txtProducto.Focus()
    End Sub

    Private Sub Procesa_Cotizacion(ByVal nFolio As String, ByVal TasaCero As Boolean)

        Dim lv_subtotal = FormatNumber(txtSubTotal.Text, 6)
        Dim lv_iva = FormatNumber(txtIVA.Text, 6)
        Dim lv_total = FormatNumber(txtTotal.Text, 2)
        Dim lv_subtotal_TasaCero = FormatNumber(txtSubTotalTasaCero.Text, 6)
        Dim lv_iva_TasaCero = FormatNumber(txtIVATasaCero.Text, 6)
        Dim lv_total_TasaCero = FormatNumber(txtTotalTasaCero.Text, 2)
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
        lv_subtotal = CStr(CDbl(lv_subtotal) - CDbl(lv_subtotal_TasaCero))
        lv_subtotal = Trim(lv_subtotal)
        lv_total = CStr(CDbl(lv_total) - CDbl(lv_total_TasaCero))
        lv_total = Trim(lv_total)

        If idClienteVenta = "0" Then
            MetroFramework.MetroMessageBox.Show(Me, "Favor de Seleccionar un Cliente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MsgBox("Favor de Seleccionar un Cliente", MsgBoxStyle.Information, "Cotización")
            Console.WriteLine("Err 3")
            txtCliente.Focus()
            Error_Venta = True
            Exit Sub
        End If

        strCotizacion.IdComp = CompanyCode
        strCotizacion.nticket = CLng(nFolio)
        strCotizacion.fecha = Date.Now
        If TasaCero = True Then
            strCotizacion.SubTotal = CDec(lv_subtotal_TasaCero)
            strCotizacion.IVA = CDec("0.00")
            strCotizacion.total = CDec(lv_total_TasaCero)
        Else
            strCotizacion.SubTotal = CDec(lv_subtotal)
            strCotizacion.IVA = CDec(lv_iva)
            strCotizacion.total = CDec(lv_total)
        End If
        strCotizacion.tipo = "CONTADO"
        strCotizacion.usuario = usuario
        strCotizacion.cliente = txtCliente.Text
        strCotizacion.idCliente = CLng(idClienteVenta)
        strCotizacion.estado = "VENDIDO"
        strCotizacion.motivo = ""
        strCotizacion.numeroFactura = ""
        If DBModelo.Insert_PV_Cotizacion(strCotizacion) = False Then
            MetroFramework.MetroMessageBox.Show(Me, "Error al Insertar en Tabla Cotizacion", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Error_Venta = True
            Exit Sub
        End If

        For i = 0 To DataGridView1.RowCount - 1
            Dim lv_pu = DataGridView1.Rows(i).Cells(7).Value.ToString '3
            lv_pu = Trim(lv_pu.Replace("$", " "))
            lv_pu = Trim(lv_pu.Replace(",", " "))
            lv_pu = Trim(lv_pu.Replace(" ", ""))

            Dim lv_subtal = DataGridView1.Rows(i).Cells(8).Value.ToString '3
            lv_subtal = Trim(lv_subtal.Replace("$", " "))
            lv_subtal = Trim(lv_subtal.Replace(",", " "))
            lv_subtal = Trim(lv_subtal.Replace(" ", ""))

            Dim lv_precosto = DataGridView1.Rows(i).Cells(9).Value.ToString '9
            lv_precosto = Trim(lv_precosto.Replace("$", " "))
            lv_precosto = Trim(lv_precosto.Replace(",", " "))
            lv_precosto = Trim(lv_precosto.Replace(" ", ""))

            Dim lv_subcosto = DataGridView1.Rows(i).Cells(10).Value.ToString
            lv_subcosto = Trim(lv_subcosto.Replace("$", " "))
            lv_subcosto = Trim(lv_subcosto.Replace(",", " "))
            lv_subcosto = Trim(lv_subcosto.Replace(" ", ""))

            Dim lv_precio_cantidad As Double = CDbl(DataGridView1.Rows(i).Cells(9).Value) * CDbl(DataGridView1.Rows(i).Cells(0).Value)

            If TasaCero = True And CBool(DataGridView1.Rows(i).Cells(13).Value) = True Then
            ElseIf TasaCero = False And CBool(DataGridView1.Rows(i).Cells(13).Value) = False Then
            Else
                GoTo SiguienteRegistro
            End If

            strTicketCotizacion.IdComp = CompanyCode
            strTicketCotizacion.folio = nFolio
            strTicketCotizacion.concepto = DataGridView1.Rows(i).Cells(2).Value.ToString
            strTicketCotizacion.cantidad = CDec(DataGridView1.Rows(i).Cells(0).Value)
            strTicketCotizacion.precio = CDec(lv_pu)
            strTicketCotizacion.fecha = CDate(Date.Now.ToString("yyyy-MM-dd"))
            strTicketCotizacion.subtotal = CDec(lv_subtal)
            strTicketCotizacion.clave_producto = DataGridView1.Rows(i).Cells(5).Value.ToString
            strTicketCotizacion.precioCosto = CDec(lv_precosto)
            strTicketCotizacion.subtotalCosto = CDec(lv_precio_cantidad)
            strTicketCotizacion.IdProducto = CLng(DataGridView1.Rows(i).Cells(1).Value)
            strTicketCotizacion.ClaveProducto = CStr(DataGridView1.Rows(i).Cells(11).Value)
            strTicketCotizacion.ClaveUnidad = CStr(DataGridView1.Rows(i).Cells(12).Value)
            strTicketCotizacion.TasaCero = CBool(DataGridView1.Rows(i).Cells(13).Value)

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
            Call btnBuscarC_Click(sender, e)
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

    Private Sub DataGridView1_KeyUp(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyUp
        Dim lv_granTotal As Double = 0
        Dim lv_granSubTotal As Double = 0
        Dim lv_granIVA As Double = 0
        Dim lv_granSubTotal_TasaCero As Double = 0
        Dim lv_granIVA_TasaCero As Double = 0
        Dim lv_granTotal_TasaCero As Double = 0
        If e.KeyCode = Keys.Delete Then
            For i = 0 To DataGridView1.RowCount - 1
                DataGridView1.Rows(i).Cells(8).Value = Trim(Replace(CStr(DataGridView1.Rows(i).Cells(8).Value), "$", ""))
                Dim lv_total As Double = CDbl(DataGridView1.Rows(i).Cells(8).Value)
                lv_granSubTotal = lv_granSubTotal + lv_total
                If CBool(DataGridView1.Rows(i).Cells(13).Value) = False Then
                    lv_granIVA = lv_granIVA + CDbl(FormatNumber(lv_total * (CDbl(FactorIVA) - 1), 2))
                    lv_granTotal = lv_granTotal + CDbl(FormatNumber(lv_total + (lv_total * (CDbl(FactorIVA) - 1))))
                    gv_tasa_16 = True
                Else
                    lv_granTotal = lv_granTotal + CDbl(FormatNumber(lv_total, 2))
                    lv_granTotal_TasaCero = lv_granTotal_TasaCero + CDbl(FormatNumber(lv_total, 2))
                    lv_granSubTotal_TasaCero = lv_granSubTotal_TasaCero + lv_total
                    gv_tasa_0 = True
                End If
                DataGridView1.Rows(i).Cells(8).Value = lv_total
            Next
            txtSubTotal.Text = Format(lv_granSubTotal, "###,###,##0.00")
            txtIVA.Text = Format(lv_granIVA, "###,###,##0.00")
            txtTotal.Text = Format(lv_granTotal, "###,###,##0.00")
            txtSubTotalTasaCero.Text = Format(lv_granSubTotal_TasaCero, "###,###,##0.00")
            txtIVATasaCero.Text = Format(lv_granIVA_TasaCero, "###,###,##0.00")
            txtTotalTasaCero.Text = Format(lv_granTotal_TasaCero, "###,###,##0.00")
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            If CInt(DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value) > 0 Then
                Dim lv_granTotal As Double = 0
                FrmDescuento.lblDescripcion.Text = CStr(DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value)
                FrmDescuento.NupCantidad.Text = CStr(DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value)
                FrmDescuento.NupPrecio.Text = Replace(CStr(DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value), "$", "")
                FrmDescuento.txtPorcentaje.Text = CStr(DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value)
                FrmDescuento.ShowDialog()
                FrmDescuento.Close()
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
            strFoliosTicket.IdComp = CompanyCode
            strFoliosTicket.Year = Now.Year
            strFoliosTicket.IdTerminal = gv_terminal
            strFoliosTicket.DocType = TipoDocumento
            strFoliosTicket.FolioActual = CStr(1)
            If DBModelo.Insert_PV_FoliosTicketActual(strFoliosTicket) Then
                lv_folio = 1
                lv_folioactual = CInt(gv_terminal & Now.Year & lv_folio)
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Error al intentar Crear registro en FoliosTicket", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            lv_folioactual = CInt(gv_terminal & Now.Year & lv_folio)
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
            Procesa_Pedido_Contado(CStr(lv_folioactual), TasaCero)
        End If
        '------------------------------------TICKET CONTADO-----------------------------------------------------------------------[]
        If TipoDocumento = "TICKET" And CmbTipoVenta.Text = "CONTADO" Then
            idClienteVenta = "0"
            Procesa_Ticket_Contado(CStr(lv_folioactual), TasaCero)
        End If
        '-----------------------------------------PEDIDO CREDITO--------------------------------------------------------------------
        If TipoDocumento = "PEDIDO" And CmbTipoVenta.Text = "CREDITO" Then
            Procesa_Pedido_Credito(CStr(lv_folioactual), TasaCero)
        End If
        '-----------------------------------------TICKET CREDITO--------------------------------------------------------------------
        If TipoDocumento = "TICKET" And CmbTipoVenta.Text = "CREDITO" Then
            Procesa_Ticket_Credito(CStr(lv_folioactual), TasaCero)
        End If
        '-----------------------------------------COTIZACION--------------------------------------------------------------------
        If TipoDocumento = "COTIZACION" Then
            Procesa_Cotizacion(CStr(lv_folioactual), TasaCero)
        End If

        If Error_Limite_Credito = False Then
            lv_folio = lv_folio + 1
            If Not IsNothing(strFoliosTicket) Then
                strFoliosTicket.FolioActual = CStr(lv_folio)
                If DBModelo.Update_PV_FoliosTicketActual(strFoliosTicket) = False Then
                    MetroFramework.MetroMessageBox.Show(Me, "No se pudo Actualizar registro en la tabla FOLIOSTICKETS", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Error_Venta = False
                    Exit Sub
                End If
            End If

            If Error_Venta = False Then
                If TipoDocumento <> "COTIZACION" Then
                    For i = 0 To DataGridView1.RowCount - 1
                        If DBModelo.Update_PV_Producto_Stock(CDbl(DataGridView1.Rows(i).Cells(0).Value), CInt(DataGridView1.Rows(i).Cells(1).Value)) = False Then
                            MetroFramework.MetroMessageBox.Show(Me, "No se pudo Actualizar Inventario en la tabla PRODUCTOS", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Error_Venta = False
                        End If
                    Next

                    If ImprimeVenta(CStr(lv_folioactual), True, CmbDocto.Text, PV_Contado_Paga, PV_Contado_Cambio) = False Then
                        MetroFramework.MetroMessageBox.Show(Me, "Error al Generar la Impresión de el Ticket/Pedido, favor de Re-Imprimir", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Call NuevaVenta()
                        Exit Sub
                    End If
                Else
                    If ImprimeCotizacion(CStr(lv_folioactual), True, CmbDocto.Text) = False Then
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

    Private Sub btnCobrar_Click(sender As Object, e As EventArgs) Handles btnCobrar.Click
        PV_Contado_Cambio = ""
        PV_Contado_Paga = ""
        TipoDocumento = CmbDocto.Text
        If TipoDocumento = "COTIZACION" And CmbTipoVenta.Text = "CONTADO" And (txtIdCliente.Text = "0" Or txtIdCliente.Text = "") Then
            MetroFramework.MetroMessageBox.Show(Me, "Cliente es obligatorio para hacer una cotización, Favor de seleccionar un cliente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If DataGridView1.RowCount <> 0 Then
            If CmbTipoVenta.Text = "CONTADO" Then
                If TipoDocumento <> "COTIZACION" Then
                    Dim oForm As New FrmCobrar
                    oForm.ShowDialog()
                    oForm.Close()
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

    Private Sub btnDescuento_Click(sender As Object, e As EventArgs) Handles btnDescuento.Click
        If DataGridView1.RowCount <> 0 Then
            Dim oForm As New FrmDescuentoGeneral
            oForm.txtPorcentaje.Text = CStr(DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value)
            oForm.ShowDialog()
            oForm.Close()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "No hay productos en la lista", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnBuscarP_Click(sender As Object, e As EventArgs) Handles btnBuscarP.Click
        Dim oForm As New FrmBuscarProductosPV
        oForm.ShowDialog()
        oForm.Close()

        If AccionSalir = False Then
            Add_Record_to_DGV()
        End If
        txtProducto.Select()
    End Sub

    Private Sub btnBuscarC_Click(sender As Object, e As EventArgs) Handles btnBuscarC.Click
        If CmbTipoVenta.Text = "CREDITO" Then
            Buscar_Clientes = "VENTAS"
            Cliente_diasCredito = 0
            Cliente_limite = 0
            Dim oForm As New FrmBuscarClientesVentas
            oForm.ShowDialog()
            oForm.Close()
            txtProducto.Select()
        End If
        If CmbTipoVenta.Text = "CONTADO" And CmbDocto.Text = "COTIZACION" Then
            Buscar_Clientes = "VENTAS"
            Cliente_diasCredito = 0
            Cliente_limite = 0
            Dim oForm As New FrmBuscarClientesVentas
            oForm.ShowDialog()
            oForm.Close()
            txtProducto.Select()
        End If
    End Sub
End Class