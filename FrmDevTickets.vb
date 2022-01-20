
Public Class FrmDevTickets
    Private Sub ConfigurarGridDetalle(ByRef dv As DataGridView)
        dv.Columns(0).Visible = False
        dv.Columns(1).Visible = False

        dv.Columns(2).HeaderText = "IdProducto"
        dv.Columns(2).ReadOnly = True
        dv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(3).HeaderText = "Descripcion"
        dv.Columns(3).ReadOnly = True
        dv.Columns(3).Width = 300
        dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dv.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(4).HeaderText = "Cantidad"
        dv.Columns(4).ReadOnly = False
        dv.Columns(4).DefaultCellStyle.Format = "###.00"
        dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dv.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(5).HeaderText = "Precio Unitario"
        dv.Columns(5).ReadOnly = True
        dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dv.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(6).Visible = False

        dv.Columns(7).HeaderText = "Subtotal"
        dv.Columns(7).ReadOnly = False
        dv.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dv.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(8).Visible = False
        dv.Columns(9).Visible = False
        dv.Columns(10).Visible = False
        dv.Columns(11).Visible = False

        dv.Columns(12).HeaderText = "ClaveProducto"
        dv.Columns(12).ReadOnly = True
        dv.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(12).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(13).HeaderText = "ClaveUnidad"
        dv.Columns(13).ReadOnly = True
        dv.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(13).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(14).Visible = False
    End Sub

    Private Sub TxtPedido_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxtPedido.KeyDown
        Dim Lv_pedido As String = TxtPedido.Text
        Dim lv_subtotal_c As Double = 0
        Dim lv_iva_c As Double = 0
        Dim lv_total_c As Double = 0

        If e.KeyCode = Keys.Enter Then
            If Lv_pedido = "" Then
                MsgBox("Favor De Proporcionar El Número De Ticket", MsgBoxStyle.Information, "Devolución de Tickets")
                Limpiar_objetos()
                TxtTotal_N.Text = Format(lv_total_c, "$ ###,###,##0.00")
                Exit Sub
            ElseIf Lv_pedido = " " Then
                Exit Sub
            End If

            Dim wVenta As tblVenta = DBModelo.Get_PV_TicketHeader(CDbl(Lv_pedido))
            If Not wVenta Is Nothing Then
                If wVenta.estado = "CANCELADO"
                    MsgBox("Este ticket ya ha sido devuelto", MsgBoxStyle.Information, "Devolución de Tickets")
                    Limpiar_objetos()
                    TxtTotal_N.Text = Format(lv_total_c, "$ ###,###,##0.00")
                    Exit Sub
                End If
                TxtPedido_C.Text = wVenta.nticket
                DTPFecha.Value = wVenta.fecha
                txtSubTotal_C.Text = wVenta.SubTotal
                txtIVA_C.Text = wVenta.IVA
                txtTotal_C.Text = wVenta.total
                TxtTipo_C.Text = wVenta.tipo
                TxtStatus_C.Text = wVenta.estado
                TxtNombre_C.Text = wVenta.cliente
                Label9.Visible = True
                Label9.Text = wVenta.idCliente

                Dim tTicket As List(Of tblTicket) = DBModelo.Get_PV_TicketsDetalle(wVenta.nticket)
                DGVDetalle.Refresh()
                DGVDetalle.DataSource = tTicket.ToList()

                ConfigurarGridDetalle(DGVDetalle)

                For i = 0 To tTicket.Count - 1
                    lv_subtotal_c = lv_subtotal_c + tTicket(i).subtotal
                Next i
                lv_iva_c = lv_subtotal_c * (FactorIVA - 1)
                lv_total_c = lv_subtotal_c + lv_iva_c
                txtSubTotal_N.Text = Format(lv_subtotal_c, "$ ###,###,##0.00")
                txtIVA_N.Text = Format(lv_iva_c, "$ ###,###,##0.00")
                TxtTotal_N.Text = Format(lv_total_c, "$ ###,###,##0.00")
                CmdGenerar.Enabled = True
            Else
                MsgBox("Ticket N°:" & Trim(Lv_pedido) & ", No existe ", MsgBoxStyle.Information, "Devolución de Tickets")
                Limpiar_objetos()
                TxtTotal_N.Text = Format(lv_total_c, "$ ###,###,##0.00")
                Label9.Visible = False
            End If
        End If
    End Sub

    Private Sub TxtPedido_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPedido.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub Limpiar_objetos()
        TxtPedido.Clear()
        TxtPedido_C.Clear()
        TxtNombre_C.Clear()
        TxtStatus_C.Clear()
        TxtTipo_C.Clear()
        txtSubTotal_C.Clear()
        txtIVA_C.Clear()
        txtTotal_C.Clear()
        txtSubTotal_N.Clear()
        txtIVA_N.Clear()
        TxtTotal_N.Clear()
        DTPFecha.Value = Now.Date
        Label9.Visible = False
        CmdGenerar.Enabled = False
        Dim tTicketPedido As List(Of tblTicketPedido) = New List(Of tblTicketPedido)
        DGVDetalle.Refresh()
        DGVDetalle.DataSource = tTicketPedido.ToList()
        TxtPedido.Focus()
        TxtPedido.Select()
    End Sub

    Private Sub FrmDevTickets_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                Call CmdSalir_Click(sender, e)
        End Select
    End Sub

    Private Sub FrmDevPedidos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Limpiar_objetos()
    End Sub

    Private Sub CmdSalir_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub CmdGenerar_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub DGVDetalle_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDetalle.CellValueChanged
        If e.ColumnIndex = 4 And e.RowIndex <> -1 Then
            Dim lv_cantidad As Double = DGVDetalle.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            Dim wTicketOrig As tblTicket = DBModelo.Get_PV_TicketsDetalleByFolioAndIdProducto(DGVDetalle.Rows(e.RowIndex).Cells(1).Value, DGVDetalle.Rows(e.RowIndex).Cells(2).Value)
            If lv_cantidad <= wTicketOrig.cantidad Then
                Dim lv_pu As Double = DGVDetalle.Rows(e.RowIndex).Cells(5).Value

                DGVDetalle.Rows(e.RowIndex).Cells(7).Value = CDec(lv_cantidad * lv_pu)

                Dim lv_subtotal_c As Double = 0
                Dim lv_iva_c As Double = 0
                Dim lv_total_c As Double = 0
                For i = 0 To DGVDetalle.Rows.Count - 1
                    lv_subtotal_c = lv_subtotal_c + DGVDetalle.Rows(i).Cells(7).Value
                Next i
                lv_iva_c = lv_subtotal_c * (FactorIVA - 1)
                lv_total_c = lv_subtotal_c + lv_iva_c
                txtSubTotal_N.Text = Format(lv_subtotal_c, "$ ###,###,##0.00")
                txtIVA_N.Text = Format(lv_iva_c, "$ ###,###,##0.00")
                TxtTotal_N.Text = Format(lv_total_c, "$ ###,###,##0.00")
                'DGVDetalle.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Format(lv_cantidad, "###0.00")
            Else
                MsgBox("Cantidad mayor a la Cantidad Original", MsgBoxStyle.Critical, "Favor de verificar")
                DGVDetalle.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Format(wTicketOrig.cantidad, "###0.00")
            End If
        End If
    End Sub

    Private Sub DGVDetalle_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DGVDetalle.RowsRemoved
        Dim lv_subtotal_c As Double = 0
        Dim lv_iva_c As Double = 0
        Dim lv_total_c As Double = 0
        For i = 0 To DGVDetalle.Rows.Count - 1
            lv_subtotal_c = lv_subtotal_c + DGVDetalle.Rows(i).Cells(7).Value
        Next i
        lv_iva_c = lv_subtotal_c * (FactorIVA - 1)
        lv_total_c = lv_subtotal_c + lv_iva_c
        txtSubTotal_N.Text = Format(lv_subtotal_c, "$ ###,###,##0.00")
        txtIVA_N.Text = Format(lv_iva_c, "$ ###,###,##0.00")
        TxtTotal_N.Text = Format(lv_total_c, "$ ###,###,##0.00")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CmdGenerar.Click
        'Validar que el ticket no tenga abonos realizados en caso de que sea Ticket a Crédito
        If TxtTipo_C.Text = "CREDITO" Then
            Dim wCobrar As tblCobrar = DBModelo.Get_CobrarTipoDoc(CDbl(TxtPedido_C.Text), "TICKET", CInt(Label9.Text))

            If Not wCobrar Is Nothing Then
                If wCobrar.resto <> wCobrar.total Then
                    MsgBox("Existen abonos a este Ticket en tabla HISTORIAL_PAGOS", MsgBoxStyle.Critical)
                    Error_Venta = False
                    Exit Sub
                End If
            End If
        End If

        ' Restauramos stock de todos los productos de este Ticket y eliminamos la linea
        Dim tTicket As List(Of tblTicket) = DBModelo.Get_PV_TicketsDetalle(CInt(TxtPedido.Text))
        If tTicket.Count > 0 Then
            For Each wTicket In tTicket
                Dim wProducto As tblProductos = DBModelo.GetProductById(wTicket.IdProducto)
                If Not wProducto Is Nothing Then
                    wProducto.stock = wProducto.stock + wTicket.cantidad
                    If DBModelo.UpdateProductos(wProducto) = False Then
                        MsgBox("No se pudo Actualizar Inventario en la tabla PRODUCTOS", MsgBoxStyle.Critical)
                        Error_Venta = False
                        Exit Sub
                    End If
                End If
                If DBModelo.DeleteTicket(wTicket) = False Then
                    MsgBox("No se pudo Eliminar el registro en TICKETS", MsgBoxStyle.Critical)
                    Error_Venta = False
                    Exit Sub
                End If
            Next
        End If

        'Actualizamos la cabecera los campos subtotal, iva y total acorde al nuevo calculo
        Dim wVenta As tblVenta = DBModelo.Get_PV_TicketHeader(CInt(TxtPedido.Text))
        If Not wVenta Is Nothing Then
            wVenta.SubTotal = Trim(Replace(Trim(Replace(txtSubTotal_N.Text, "$", "")), ",", ""))
            wVenta.IVA = Trim(Replace(Trim(Replace(txtIVA_N.Text, "$", "")), ",", ""))
            wVenta.total = Trim(Replace(Trim(Replace(TxtTotal_N.Text, "$", "")), ",", ""))
            wVenta.estado = "CANCELADO"
            wVenta.motivo = "DEVOLUCION-ADMIN"
            If DBModelo.Update_PV_Venta(wVenta) = False Then
                MsgBox("No se pudo Actualizar registros en la tabla VENTA", MsgBoxStyle.Critical)
                Error_Venta = False
                Exit Sub
            End If
        End If

        'Agregamos el nuevo detalle del ticket ya con las correcciones realizadas.
        For i = 0 To DGVDetalle.Rows.Count - 1
            Dim wTicket As tblTicket = New tblTicket

            wTicket.folio = DGVDetalle.Rows(i).Cells(1).Value.ToString
            wTicket.IdProducto = DGVDetalle.Rows(i).Cells(2).Value
            wTicket.concepto = DGVDetalle.Rows(i).Cells(3).Value.ToString
            wTicket.cantidad = CDec(DGVDetalle.Rows(i).Cells(4).Value)
            wTicket.precio = CDec(DGVDetalle.Rows(i).Cells(5).Value)
            wTicket.fecha = DGVDetalle.Rows(i).Cells(6).Value.ToString
            wTicket.subtotal = CDec(DGVDetalle.Rows(i).Cells(7).Value)
            wTicket.clave_producto = DGVDetalle.Rows(i).Cells(8).Value.ToString
            wTicket.precioCosto = CDec(DGVDetalle.Rows(i).Cells(9).Value)
            wTicket.subtotalCosto = CDec(DGVDetalle.Rows(i).Cells(10).Value)
            wTicket.numeroFactura = DGVDetalle.Rows(i).Cells(11).Value.ToString
            wTicket.ClaveProducto = DGVDetalle.Rows(i).Cells(12).Value.ToString
            wTicket.ClaveUnidad = DGVDetalle.Rows(i).Cells(13).Value.ToString
            wTicket.TasaCero = CBool(DGVDetalle.Rows(i).Cells(14).Value)

            If DBModelo.Insert_PV_Ticket(wTicket) = False Then
                MsgBox("No se pudo Insertar registros en la tabla TICKET", MsgBoxStyle.Critical)
                Error_Venta = False
                Exit Sub
            End If

            'Actualizamos Stock descontando las piezas correspondientes
            Dim wProducto As tblProductos = DBModelo.GetProductById(DGVDetalle.Rows(i).Cells(2).Value)
            If Not wProducto Is Nothing Then
                'wProducto.stock = wProducto.stock - CDec(DGVDetalle.Rows(i).Cells(4).Value)
                If DBModelo.UpdateProductos(wProducto) = False Then
                    MsgBox("No se pudo Actualizar Inventario en la tabla PRODUCTOS", MsgBoxStyle.Critical)
                    Error_Venta = False
                    Exit Sub
                End If
            End If

        Next i

        'Si el ticket es a CREDITO, solo se modificará si no hay abonos realizados
        If TxtTipo_C.Text = "CREDITO" Then
            Dim wCobrar As tblCobrar = DBModelo.Get_CobrarTipoDoc(CDbl(TxtPedido_C.Text), "TICKET", CInt(Label9.Text))

            If Not wCobrar Is Nothing Then
                If wCobrar.resto = wCobrar.total Then
                    wCobrar.resto = CDec(TxtTotal_N.Text)
                    wCobrar.total = CDec(TxtTotal_N.Text)
                    If DBModelo.Update_Cobrar(wCobrar) = False Then
                        MsgBox("No se pudo Actualizar registros en la tabla COBRAR", MsgBoxStyle.Critical)
                        Error_Venta = False
                        Exit Sub
                    End If
                End If
            End If
        End If

        Dim lv_result As Boolean = False
        If MsgBox("¿Deseas Imprimir el Ticket?", MsgBoxStyle.YesNo, "Re-Impresiones de Tickets") = MsgBoxResult.Yes Then
            lv_result = True
        End If

        If ReImprimeVenta(TxtPedido_C.Text, lv_result, "TICKET", Trim(Replace(Trim(Replace(TxtTotal_N.Text, "$", "")), ",", "")), "0.00", DBConnected) = False Then
            MsgBox("Error al Generar la Impresión del Ticket", MsgBoxStyle.Information)
            Exit Sub
        End If

        MsgBox("Devolución Terminada Correctamente", MsgBoxStyle.Information, "Devolución Terminada")
        Limpiar_objetos()
    End Sub
End Class