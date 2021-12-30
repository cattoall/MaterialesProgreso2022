Public Class FrmCancelarPedido
    Public Devolucion As String
    Dim ErrorPresio As String
    Dim ClienteErroneo As String

    Private Sub FrmCancelarPedido_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click

        Dim motivo As String

        If Cancelar = 1 Then

            If CmbCancelarPedido.Text = "" Or CmbCancelarPedido.Text = " " Then
                MetroFramework.MetroMessageBox.Show(Me, "Favor De Especificar El Motivo De Cancelación", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            motivo = CmbCancelarPedido.Text & "-" & usuario

            Try
                For i = 0 To FrmPedidos.DataGridView2.RowCount - 1
                    Dim strProducto As tblProductos = DBModelo.GetProductById(CInt(FrmPedidos.DataGridView2.Item(9, i).Value))
                    strProducto.stock = strProducto.stock + CDbl(FrmPedidos.DataGridView2.Item(2, i).Value)
                    If DBModelo.UpdateProductos(strProducto) = False Then
                        MetroFramework.MetroMessageBox.Show(Me, "Error al Actualizar en Tabla PRODUCTOS", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Next
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            Try
                Dim PedidoHeader As tblVentaPedido = DBModelo.Get_PV_PedidosHeader(NoFactura)
                PedidoHeader.estado = "CANCELADO"
                PedidoHeader.motivo = motivo

                If DBModelo.Update_PV_VentaPedidos(PedidoHeader) = False Then
                    MetroFramework.MetroMessageBox.Show(Me, "Error al Actualizar en Tabla VENTA_PEDIDO", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            If FrmPedidos.DataGridView1.Item(5, FrmPedidos.DataGridView1.CurrentRow.Index).Value = "CREDITO" Then
                Try
                    Dim strCobrar As tblCobrar = DBModelo.Get_CobrarTipoDoc(NoFactura, "PEDIDO")
                    strCobrar.resto = "0.00"

                    If DBModelo.Update_Cobrar(strCobrar) = False Then
                        MetroFramework.MetroMessageBox.Show(Me, "Error al Actualizar en Tabla COBRAR", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MetroFramework.MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End If

            MetroFramework.MetroMessageBox.Show(Me, "Pedido: " + NoFactura + " cancelado cerrectamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

            Call FrmPedidos.ImgVentasB_Click(sender, e)
            FrmPedidos.LblPedido.Text = ""
            NoFactura = ""
            Close()

        ElseIf Cancelar = 2 Then

            If CmbCancelarPedido.Text = "" Or CmbCancelarPedido.Text = " " Then
                MetroFramework.MetroMessageBox.Show(Me, "Favor De Especificar El Motivo De Cancelación", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If


            motivo = CmbCancelarPedido.Text & "-" & usuario

            Try

                For i = 0 To FrmListadoVentas.DataGridTikect.RowCount - 1
                    Dim strProducto As tblProductos = DBModelo.GetProductById(CInt(FrmListadoVentas.DataGridTikect.Item(9, i).Value))
                    strProducto.stock = strProducto.stock + CDbl(FrmListadoVentas.DataGridTikect.Item(2, i).Value)
                    If DBModelo.UpdateProductos(strProducto) = False Then
                        MetroFramework.MetroMessageBox.Show(Me, "Error al Actualizar en Tabla PRODUCTOS", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Next
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            Try
                Dim strVenta As tblVenta = DBModelo.Get_PV_TicketHeader(NoFactura)
                strVenta.estado = "CANCELADO"
                strVenta.motivo = motivo

                If DBModelo.Update_PV_Venta(strVenta) = False Then
                    MetroFramework.MetroMessageBox.Show(Me, "Error al Actualizar en Tabla VENTA", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            If FrmListadoVentas.DataGridConsulta.Item(5, FrmListadoVentas.DataGridConsulta.CurrentRow.Index).Value = "CREDITO" Then
                Try
                    Dim strCobrar As tblCobrar = DBModelo.Get_CobrarTipoDoc(NoFactura, "TICKET")
                    strCobrar.resto = "0.00"

                    If DBModelo.Update_Cobrar(strCobrar) = False Then
                        MetroFramework.MetroMessageBox.Show(Me, "Error al Actualizar en Tabla COBRAR", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MetroFramework.MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End If

            MetroFramework.MetroMessageBox.Show(Me, "Ticket: " + NoFactura + " cancelado cerrectamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

            Call FrmListadoVentas.ImgVentasB_Click(sender, e)

            FrmListadoVentas.LblNumTicket.Text = ""
            FrmListadoVentas.LblNumTicket.Visible = False
            FrmListadoVentas.LblTotal.Text = "$0.00"
            NoFactura = ""
            Close()


        ElseIf Cancelar = 3 Then


        ElseIf Cancelar = 4 Then

            If CmbCancelarPedido.Text = "" Or CmbCancelarPedido.Text = " " Then
                MetroFramework.MetroMessageBox.Show(Me, "Favor De Especificar El Motivo De Cancelación", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            motivo = CmbCancelarPedido.Text & "-" & usuario

            'Cambiar status en tabla Factura_Total
            Try
                Dim strNC As tblNC = DBModelo.Get_NotaDeCredito(NoFactura)
                strNC.estado = "CANCELADO"
                strNC.observaciones = motivo

                If DBModelo.Update_NotaDeCredito(strNC) = False Then
                    MetroFramework.MetroMessageBox.Show(Me, "Error al Actualizar en Tabla NC", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            CancelaNC_CFDI(CInt(NoFactura), DBConnected)

            MetroFramework.MetroMessageBox.Show(Me, "Nota de Crédito " & NoFactura & " Ha sido cancelada.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

            Call FrmListadoNC.ImgVerFactB_Click(sender, e)

            FrmListadoNC.LblNumTicket.Text = ""
            FrmListadoNC.LblNumTicket.Visible = False
            FrmListadoNC.LblTotal.Text = "$ 0.00"
            NoFactura = ""
            Close()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class