﻿
Public Class FrmPedidos

    Private Sub FrmPedidos_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                Close()
                Dispose()
        End Select
    End Sub

    Private Sub pedidos_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        DataGridView1.Refresh()
        DataGridView2.Refresh()
        dpinicio.Value = Now
        dpfinal.Value = Now
        LblPedido.Text = ""
    End Sub

    Private Sub CmdVerPedidos_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub ConfiguraGridHeader(ByVal dv As DataGridView)
        
        dv.Columns(0).Visible = False
        
        dv.Columns(1).HeaderText = "Pedido"
        dv.Columns(1).ReadOnly = True
        dv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(2).HeaderText = "Fecha"
        dv.Columns(2).ReadOnly = True
        dv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(3).Visible = False
        dv.Columns(4).Visible = False

        dv.Columns(5).HeaderText = "Total"
        dv.Columns(5).ReadOnly = True
        dv.Columns(5).DefaultCellStyle.Format = "$ ###,###,##0.00"
        dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dv.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(6).HeaderText = "Tipo"
        dv.Columns(6).ReadOnly = True
        dv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(7).Visible = False

        dv.Columns(8).HeaderText = "Cliente"
        dv.Columns(8).ReadOnly = True
        dv.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dv.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(8).Width = 100

        dv.Columns(9).Visible = False

        dv.Columns(10).HeaderText = "Estado"
        dv.Columns(10).ReadOnly = True
        dv.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(10).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(11).HeaderText = "Motivo"
        dv.Columns(11).ReadOnly = True
        dv.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(11).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(12).HeaderText = "#factura"
        dv.Columns(12).ReadOnly = True
        dv.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(12).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub CmdGenerarTicket_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub CmdSalir_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub CmdCancelarPedido_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub CmdReimprimirPedido_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        LblPedido.Text = CStr(DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value)
        NoFactura = CStr(DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value)

        Dim tPedidosDetails As List(Of tblTicketPedido) = DBModelo.Get_PV_PedidosDetalle(CInt(NoFactura))
        DataGridView2.Refresh()
        DataGridView2.DataSource = tPedidosDetails.ToList()
        ConfiguraGridDetail(DataGridView2)
    End Sub

    Private Sub ConfiguraGridDetail(ByVal dv As DataGridView)
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
        dv.Columns(5).ReadOnly = True
        dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dv.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(6).HeaderText = "Precio Unitario"
        dv.Columns(6).ReadOnly = True
        dv.Columns(6).DefaultCellStyle.Format = "$ ###,###,##0.00"
        dv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dv.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(7).Visible = False

        dv.Columns(8).HeaderText = "Subtotal"
        dv.Columns(8).ReadOnly = True
        dv.Columns(8).DefaultCellStyle.Format = "$ ###,###,##0.00"
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
        Dispose()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles CmdVerPedidos.Click
        Dim tPedidosHeader As List(Of tblVentaPedido) = DBModelo.Get_PedidosByDate(Format(dpinicio.Value.Date, "yyyy-MM-dd"), Format(dpfinal.Value.Date, "yyyy-MM-dd"))
        DataGridView1.Refresh()
        DataGridView1.DataSource = tPedidosHeader.ToList()

        ConfiguraGridHeader(DataGridView1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lv_folio As Integer = 0
        Dim lv_folioactual As Integer = 0
        Dim nuevo = 0
        Dim lv_resto = 0
        Dim lIdCliente As Integer = CInt(DataGridView1.Item(9, DataGridView1.CurrentRow.Index).Value)
        Dim wFoliosTicket As tblFoliosTicket = New tblFoliosTicket

        If DataGridView1.Rows.Count = 0 Then
            MsgBox("Favor de Generar Consulta", MsgBoxStyle.Information, "Convertir Pedido a Ticket")
            CmdVerPedidos.Focus()
            Exit Sub
        End If

        If LblPedido.Text = "" Then
            MsgBox("Favor de Seleccionar un Pedido", MsgBoxStyle.Information, "Convertir Pedido a Ticket")
            Exit Sub
        End If

        Dim folio_pedido As String = CStr(DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value)

        If CStr(DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value) = "CREDITO" Then
            Dim wCobrar As tblCobrar = DBModelo.Get_CobrarTipoDoc(CInt(folio_pedido), "PEDIDO", lIdCliente)
            lv_resto = CInt(wCobrar.resto)
            If lv_resto > 0 Then
                MsgBox("Pedido " & folio_pedido & " aún tiene Saldo Pendiente!", MsgBoxStyle.Information, "Convertir Pedido a Ticket")
                Limpia_Variables_SQL_y_Cierra_Conexion()
                Exit Sub
            End If
        End If

        lv_folio = DBModelo.Get_PV_FoliosTicketActual(Now.Year, gv_terminal, "TICKET")

        If lv_folio = 0 Then
            wFoliosTicket.IdComp = CompanyCode
            wFoliosTicket.Year = Now.Year
            wFoliosTicket.IdTerminal = gv_terminal
            wFoliosTicket.DocType = "TICKET"
            wFoliosTicket.FolioActual = CStr(1)
            If DBModelo.Insert_PV_FoliosTicketActual(wFoliosTicket) Then
                lv_folio = 1
                lv_folioactual = CInt(gv_terminal & Now.Year & lv_folio)
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Error al intentar Crear registro en FoliosTicket", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            lv_folioactual = CInt(gv_terminal & Now.Year & lv_folio)
            wFoliosTicket = DBModelo.Get_PV_FoliosTicket(Now.Year, gv_terminal, "TICKET")
        End If

        Dim strVenta As New tblVenta
        Dim strTicket As New tblTicket

        strVenta.IdComp = CompanyCode
        strVenta.nticket = lv_folioactual
        strVenta.fecha = CType(Date.Now.ToString("yyyy-MM-dd"), Date?)
        strVenta.SubTotal = CDec(DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value)
        strVenta.IVA = CDec(DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value)
        strVenta.total = CDec(DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value)
        strVenta.tipo = "CONTADO"
        strVenta.usuario = CStr(DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value)
        strVenta.cliente = "PUBLICO GENERAL"
        strVenta.idCliente = 0
        strVenta.estado = CStr(DataGridView1.Item(10, DataGridView1.CurrentRow.Index).Value)
        strVenta.motivo = ""
        strVenta.numeroFactura = ""

        If DBModelo.Insert_PV_Venta(strVenta) = False Then
            MetroFramework.MetroMessageBox.Show(Me, "Error al Insertar en Tabla Venta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Error_Venta = True
            Exit Sub
        End If

        Dim tTicketPedido As List(Of tblTicketPedido) = DBModelo.Get_PV_PedidosDetalle(CInt(folio_pedido))

        For Each wTicketPedido In tTicketPedido
            strTicket.IdComp = CompanyCode
            strTicket.folio = CStr(lv_folioactual)
            strTicket.concepto = wTicketPedido.concepto
            strTicket.cantidad = wTicketPedido.cantidad
            strTicket.precio = wTicketPedido.precio
            strTicket.fecha = wTicketPedido.fecha
            strTicket.subtotal = wTicketPedido.subtotal
            strTicket.clave_producto = wTicketPedido.clave_producto
            strTicket.precioCosto = wTicketPedido.precioCosto
            strTicket.subtotalCosto = wTicketPedido.subtotalCosto
            strTicket.IdProducto = wTicketPedido.IdProducto
            strTicket.numeroFactura = wTicketPedido.numeroFactura
            strTicket.ClaveProducto = wTicketPedido.ClaveProducto
            strTicket.ClaveUnidad = wTicketPedido.ClaveUnidad
            strTicket.TasaCero = wTicketPedido.TasaCero

            If DBModelo.Insert_PV_Ticket(strTicket) = False Then
                MetroFramework.MetroMessageBox.Show(Me, "Error al Insertar en Tabla Ticket", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Error_Venta = True
                Exit Sub
            End If
        Next

        MsgBox("Se generó el Ticket: ( " & lv_folioactual & " ), para el Pedido: ( " & folio_pedido & " )", MsgBoxStyle.Information, "Convertir Pedido a Ticket")

        Dim wVentaPedido As tblVentaPedido = DBModelo.Get_PV_PedidosHeader(CInt(folio_pedido))
        If DBModelo.DeleteVentaPedido(wVentaPedido) = False Then
            MsgBox("Error al Eliminar Registro en tabla VENTA_PEDIDO", MsgBoxStyle.Critical, "Convertir Pedido a Ticket")
            Exit Sub
        End If

        Dim tTicketPedidos As List(Of tblTicketPedido) = DBModelo.Get_PV_PedidosDetalle(CInt(folio_pedido))
        For Each wTicPed In tTicketPedidos
            If DBModelo.DeleteTicketPedido(wTicPed) = False Then
                MsgBox("Error al Eliminar Registro en tabla VENTA_PEDIDO", MsgBoxStyle.Critical, "Convertir Pedido a Ticket")
                Exit Sub
            End If
        Next

        If CStr(DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value) = "CREDITO" Then
            Dim wCobrar As tblCobrar = DBModelo.Get_CobrarTipoDoc(CInt(folio_pedido), "PEDIDO", lIdCliente)
            If DBModelo.DeleteCobrar(wCobrar) = False Then
                MsgBox("Error al Eliminar Registro en tabla COBRAR", MsgBoxStyle.Critical, "Convertir Pedido a Ticket")
                Exit Sub
            End If
        End If

        lv_folio = lv_folio + 1
        If Not IsNothing(wFoliosTicket) Then
            wFoliosTicket.FolioActual = CStr(lv_folio)
            If DBModelo.Update_PV_FoliosTicketActual(wFoliosTicket) = False Then
                MetroFramework.MetroMessageBox.Show(Me, "No se pudo Actualizar registro en la tabla FOLIOSTICKETS", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Error_Venta = False
                Exit Sub
            End If
        End If

        Call CmdVerPedidos_Click(sender, e)

        LblPedido.Text = " "
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If LblPedido.Text <> "" Then
            Cancelar = CStr(1)
            FrmCancelarPedido.ShowDialog()
            Cancelar = ""
            CmdVerPedidos_Click(sender, e)
        Else
            MsgBox("Seleccione Un Pedido Para Cancelar", MsgBoxStyle.Critical, "Cancelar Pedido")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If LblPedido.Text <> "" Then
            Dim lv_result As Boolean = False
            If MsgBox("¿Deseas Imprimir el Pedido?", MsgBoxStyle.YesNo, "Re-Impresiones de Pedidos") = MsgBoxResult.Yes Then
                lv_result = True
            End If

            If ImprimeVenta(LblPedido.Text, lv_result, "PEDIDO", CStr(DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value), "0.00") = False Then
                MsgBox("Error al Generar la Impresión del Pedido", MsgBoxStyle.Information, "Re-Impresiones de Pedidos")
                Limpia_Variables_SQL_y_Cierra_Conexion()
                Exit Sub
            End If
        Else
            MsgBox("Favor de seleccionar una venta.", MsgBoxStyle.Critical, "Re-Impresiones de Pedidos")
        End If
        Limpia_Variables_SQL_y_Cierra_Conexion()
    End Sub
End Class