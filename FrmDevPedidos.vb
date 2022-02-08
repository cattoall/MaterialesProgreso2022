
Public Class FrmDevPedidos
    Private Sub ConfigurarGridDetalle(ByRef dv As DataGridView)
        dv.Columns(0).Visible = False
        dv.Columns(1).Visible = False
        dv.Columns(2).Visible = False

        dv.Columns(3).HeaderText = "IdProducto"
        dv.Columns(3).ReadOnly = True
        dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(4).HeaderText = "Descripcion"
        dv.Columns(4).ReadOnly = True
        dv.Columns(4).Width = 300
        dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dv.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(5).HeaderText = "Cantidad"
        dv.Columns(5).ReadOnly = False
        dv.Columns(5).DefaultCellStyle.Format = "###.00"
        dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dv.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(6).HeaderText = "Precio Unitario"
        dv.Columns(6).ReadOnly = True
        dv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dv.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(7).Visible = False

        dv.Columns(8).HeaderText = "Subtotal"
        dv.Columns(8).ReadOnly = False
        dv.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dv.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(9).Visible = False
        dv.Columns(10).Visible = False
        dv.Columns(11).Visible = False
        dv.Columns(12).Visible = False

        dv.Columns(13).HeaderText = "ClaveProducto"
        dv.Columns(13).ReadOnly = True
        dv.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(13).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(14).HeaderText = "ClaveUnidad"
        dv.Columns(14).ReadOnly = True
        dv.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(14).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(15).Visible = False
    End Sub

    Private Sub TxtPedido_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxtPedido.KeyDown
        Dim Lv_pedido As String = TxtPedido.Text
        Dim lv_subtotal_c As Double = 0
        Dim lv_iva_c As Double = 0
        Dim lv_total_c As Double = 0

        If e.KeyCode = Keys.Enter Then
            If Lv_pedido = "" Then
                MsgBox("Favor De Proporcionar El Número De Pedido", MsgBoxStyle.Information, "Devolución de Pedidos")
                Limpiar_objetos()
                TxtTotal_N.Text = Format(lv_total_c, "$ ###,###,##0.00")
                Exit Sub
            ElseIf Lv_pedido = " " Then
                Exit Sub
            End If

            Dim wVentaPedidos As tblVentaPedido = DBModelo.Get_PV_PedidosHeader(CDbl(Lv_pedido))
            If Not wVentaPedidos Is Nothing Then
                If wVentaPedidos.estado = "CANCELADO"
                    MsgBox("Esta Nota de Crédito ya ha sido cancelada", MsgBoxStyle.Information, "Devolución de Pedidos")
                    Limpiar_objetos()
                    TxtTotal_N.Text = Format(lv_total_c, "$ ###,###,##0.00")
                    Exit Sub
                End If
                TxtPedido_C.Text = wVentaPedidos.nticket
                DTPFecha.Value = wVentaPedidos.fecha
                txtSubTotal_C.Text = wVentaPedidos.SubTotal
                txtIVA_C.Text = wVentaPedidos.IVA
                txtTotal_C.Text = wVentaPedidos.total
                TxtTipo_C.Text = wVentaPedidos.tipo
                TxtStatus_C.Text = wVentaPedidos.estado
                TxtNombre_C.Text = wVentaPedidos.cliente
                Label9.Visible = True
                Label9.Text = wVentaPedidos.idCliente

                Dim tTicketPedido As List(Of tblTicketPedido) = DBModelo.Get_PV_PedidosDetalle(wVentaPedidos.nticket)
                DGVDetalle.Refresh()
                DGVDetalle.DataSource = tTicketPedido.ToList()

                ConfigurarGridDetalle(DGVDetalle)

                For i = 0 To tTicketPedido.Count - 1
                    lv_subtotal_c = lv_subtotal_c + tTicketPedido(i).subtotal
                Next i
                lv_iva_c = lv_subtotal_c * (FactorIVA - 1)
                lv_total_c = lv_subtotal_c + lv_iva_c
                txtSubTotal_N.Text = Format(lv_subtotal_c, "$ ###,###,##0.00")
                txtIVA_N.Text = Format(lv_iva_c, "$ ###,###,##0.00")
                TxtTotal_N.Text = Format(lv_total_c, "$ ###,###,##0.00")
                CmdGenerar.Enabled = True
            Else
                MsgBox("Pedido N°:" & Trim(Lv_pedido) & ", No existe ", MsgBoxStyle.Information, "Devolución de Pedidos")
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

    Private Sub FrmDevPedidos_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                Call CmdSalir_Click(sender, e)
        End Select
    End Sub

    Private Sub FrmDevPedidos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Limpiar_objetos()
    End Sub

    Private Sub CmdGenerar_Click(sender As Object, e As EventArgs) 

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

    Private Sub CmdSalir_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub DGVDetalle_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDetalle.CellValueChanged
        If e.ColumnIndex = 4 And e.RowIndex <> -1 Then
            Dim lv_cantidad As Double = DGVDetalle.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            Dim wTicketPedidoOrig As tblTicketPedido = DBModelo.Get_PV_PedidosDetalleByFolioAndIdProducto(DGVDetalle.Rows(e.RowIndex).Cells(1).Value, DGVDetalle.Rows(e.RowIndex).Cells(2).Value)
            If lv_cantidad <= wTicketPedidoOrig.cantidad Then
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
                DGVDetalle.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Format(wTicketPedidoOrig.cantidad, "###0.00")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CmdGenerar.Click
        
        'Validar que el pedido no tenga abonos realizados en caso de que sea Pedido a Crédito
        If TxtTipo_C.Text = "CREDITO" Then
            Dim wCobrar As tblCobrar = DBModelo.Get_CobrarTipoDoc(CDbl(TxtPedido_C.Text), "PEDIDO", CInt(Label9.Text))

            If Not wCobrar Is Nothing Then
                If wCobrar.resto <> wCobrar.total Then
                    MsgBox("Existen abonos a este Pedido en tabla HISTORIAL_PAGOS", MsgBoxStyle.Critical)
                    Error_Venta = False
                    Exit Sub
                End If
            End If
        End If

        ' Restauramos stock de todos los productos de este pedido y eliminamos la linea
        Console.WriteLine("CheckPoint 1")
        Dim tTicketPedidos As List(Of tblTicketPedido) = DBModelo.Get_PV_PedidosDetalle(CInt(TxtPedido.Text))
        If tTicketPedidos.Count > 0 Then
            For Each wTicketPedido In tTicketPedidos
                Dim wProducto As tblProductos = DBModelo.GetProductById(wTicketPedido.IdProducto)
                If Not wProducto Is Nothing Then
                    Console.WriteLine("CheckPoint 2")
                    wProducto.stock = wProducto.stock + wTicketPedido.cantidad
                    If DBModelo.UpdateProductos(wProducto) = False Then
                        MsgBox("No se pudo Actualizar Inventario en la tabla PRODUCTOS", MsgBoxStyle.Critical)
                        Error_Venta = False
                        Exit Sub
                    End If
                End If
                If DBModelo.DeleteTicketPedido(wTicketPedido) = False Then
                    MsgBox("No se pudo Eliminar el registro en TicketPedidos", MsgBoxStyle.Critical)
                    Error_Venta = False
                    Exit Sub
                End If
            Next
        End If

        'Actualizamos la cabecera los campos subtotal, iva y total acorde al nuevo calculo
        Dim wVentaPedido As tblVentaPedido = DBModelo.Get_PV_PedidosHeader(CInt(TxtPedido.Text))
        If Not wVentaPedido Is Nothing Then
            wVentaPedido.SubTotal = Trim(Replace(Trim(Replace(txtSubTotal_N.Text, "$", "")), ",", ""))
            wVentaPedido.IVA = Trim(Replace(Trim(Replace(txtIVA_N.Text, "$", "")), ",", ""))
            wVentaPedido.total = Trim(Replace(Trim(Replace(TxtTotal_N.Text, "$", "")), ",", ""))
            wVentaPedido.estado = "CANCELADO"
            wVentaPedido.motivo = "DEVOLUCION-ADMIN"
            If DBModelo.Update_PV_VentaPedidos(wVentaPedido) = False Then
                MsgBox("No se pudo Actualizar registros en la tabla VENTA_PEDIDO", MsgBoxStyle.Critical)
                Error_Venta = False
                Exit Sub
            End If
        End If

        'Agregamos el nuevo detalle del pedido ya con las correcciones realizadas.
        For i = 0 To DGVDetalle.Rows.Count - 1
            Dim wTicketPedido As tblTicketPedido = New tblTicketPedido

            wTicketPedido.IdComp            = CompanyCode
            wTicketPedido.folio             = DGVDetalle.Rows(i).Cells(2).Value.ToString
            wTicketPedido.IdProducto        = DGVDetalle.Rows(i).Cells(3).Value
            wTicketPedido.concepto          = DGVDetalle.Rows(i).Cells(4).Value.ToString
            wTicketPedido.cantidad          = CDec(DGVDetalle.Rows(i).Cells(5).Value)
            wTicketPedido.precio            = CDec(DGVDetalle.Rows(i).Cells(6).Value)
            wTicketPedido.fecha             = DGVDetalle.Rows(i).Cells(7).Value.ToString
            wTicketPedido.subtotal          = CDec(DGVDetalle.Rows(i).Cells(8).Value)
            wTicketPedido.clave_producto    = DGVDetalle.Rows(i).Cells(9).Value.ToString
            wTicketPedido.precioCosto       = CDec(DGVDetalle.Rows(i).Cells(10).Value)
            wTicketPedido.subtotalCosto     = CDec(DGVDetalle.Rows(i).Cells(11).Value)

            If DGVDetalle.Rows(i).Cells(12).Value Is Nothing Then
                wTicketPedido.numeroFactura = 0
            Else
                wTicketPedido.numeroFactura = DGVDetalle.Rows(i).Cells(12).Value.ToString
            End If
            wTicketPedido.ClaveProducto = DGVDetalle.Rows(i).Cells(13).Value.ToString
            wTicketPedido.ClaveUnidad = DGVDetalle.Rows(i).Cells(14).Value.ToString
            wTicketPedido.TasaCero = CBool(DGVDetalle.Rows(i).Cells(15).Value)

            If DBModelo.Insert_PV_TicketPedidos(wTicketPedido) = False Then
                MsgBox("No se pudo Insertar registros en la tabla TICKETPEDIDO", MsgBoxStyle.Critical)
                Error_Venta = False
                Exit Sub
            End If

            'Actualizamos Stock descontando las piezas correspondientes
            Dim wProducto As tblProductos = DBModelo.GetProductById(DGVDetalle.Rows(i).Cells(3).Value)
            If Not wProducto Is Nothing Then
                'wProducto.stock = wProducto.stock + CDec(DGVDetalle.Rows(i).Cells(4).Value)
                If DBModelo.UpdateProductos(wProducto) = False Then
                    MsgBox("No se pudo Actualizar Inventario en la tabla PRODUCTOS", MsgBoxStyle.Critical)
                    Error_Venta = False
                    Exit Sub
                End If
            End If

        Next i

        'Si el pedido es a CREDITO, solo se modificará si no hay abonos realizados
        If TxtTipo_C.Text = "CREDITO" Then
            Dim wCobrar As tblCobrar = DBModelo.Get_CobrarTipoDoc(CDbl(TxtPedido_C.Text), "PEDIDO", CInt(Label9.Text))

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
        If MsgBox("¿Deseas Imprimir el Pedido?", MsgBoxStyle.YesNo, "Re-Impresiones de Pedidos") = MsgBoxResult.Yes Then
            lv_result = True
        End If

        If ReImprimeVenta(TxtPedido_C.Text, lv_result, "PEDIDO", Trim(Replace(Trim(Replace(TxtTotal_N.Text, "$", "")), ",", "")), "0.00") = False Then
            MsgBox("Error al Generar la Impresión del Pedido", MsgBoxStyle.Information)
            Exit Sub
        End If

        MsgBox("Devolución Terminada Correctamente", MsgBoxStyle.Information, "Devolución Terminada")
        Limpiar_objetos()
    End Sub
End Class