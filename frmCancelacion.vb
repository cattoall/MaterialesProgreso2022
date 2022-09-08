
Public Class frmCancelacion
    Public NoFactura As String
    Public NoPago As String
    Public FechaFactura As String
    Public CancelaPago As Boolean
    Public UUID_Cancelar As String
    Public RFC_ReceptorCancelar As String

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If (CmbCancelarPedido.Text = "") Or (CmbCancelarPedido.Text = " ") Then
            MsgBox("Favor De Especificar El Motivo De Cancelación", MsgBoxStyle.Information, "Cancelar Factura")
            Exit Sub
        End If

        If CancelaFactura_CFDI(NoFactura, FechaFactura) Then
            If CancelaPago Then
                MsgBox(("Complemento de Pago " & NoPago & " Ha sido cancelado ante el SAT."), MsgBoxStyle.Information, "Cancelación de Complemento de Pago")
            Else
                MsgBox(("Factura " & NoFactura & " Ha sido cancelada ante el SAT."), MsgBoxStyle.Information, "Cancelación de Factura")
            End If
        Else
            If CancelaPago Then
                MsgBox(("Complemento de Pago " & NoPago & " No pudo ser cancelado ante el SAT."), MsgBoxStyle.Critical, "Cancelación de Complemento de Pago")
            Else
                MsgBox(("Factura " & NoFactura & " No pudo ser cancelada Electrónicamente ante el SAT."), MsgBoxStyle.Critical, "Cancelación de Factura")
            End If
        End If


        If CancelaPago Then
            Try
                Dim wFacturaTotal As tblFacturaTotal = DBModelo.GetFacturaHeader(NoFactura)
                If Not IsNothing(wFacturaTotal) Then
                    wFacturaTotal.ComproPago = 0
                    If DBModelo.Update_PV_FacturaTotal(wFacturaTotal) Then
                        Dim wComplementoH As tblComplementoPagosH = DBModelo.GetComplementoPagoH(NoPago)
                        If Not IsNothing(wComplementoH) Then
                            wComplementoH.Cancelado = 1
                            If DBModelo.Update_ComplementoPagoH(wComplementoH) Then
                                Dim tComplementoD As List(Of TblComplementoPagosD) = DBModelo.GetComplementoPagoD(NoPago)
                                If tComplementoD.Count > 0 Then
                                    For Each wComplementoD In tComplementoD
                                        wComplementoD.Cancelado = 1
                                        If Not DBModelo.Update_ComplementoPagoD(wComplementoD) Then
                                            MsgBox(("Error al cancelar linea del Complemento de Pago " & NoPago), MsgBoxStyle.Critical, "Cancelar Complemento de Pago")
                                            Exit Sub
                                        End If
                                    Next
                                    MsgBox(("Complemento de Pago " & NoPago & "cancelado en el sistema."), MsgBoxStyle.Exclamation, "Cancelar Complemento de Pago")
                                    Close()
                                Else
                                    MsgBox(("Error al cancelar linea del Complemento de Pago " & NoPago & ". No se encontró detalle del Complemento de Pago"), MsgBoxStyle.Critical, "Cancelar Complemento de Pago")
                                    Exit Sub
                                End If
                            End If
                        End If
                    Else

                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Cancelar Complemento de Pago")
                Close()
            End Try

        Else
            Try
                Dim bFlagTicket As Boolean = False
                Dim bFlagVenta As Boolean = False
                Dim wFacturaTotal As tblFacturaTotal = DBModelo.GetFacturaHeader(NoFactura)
                If Not IsNothing(wFacturaTotal) Then
                    wFacturaTotal.estado = "CANCELADO"
                    wFacturaTotal.observaciones = CmbCancelarPedido.Text
                    wFacturaTotal.Cancelada = 1
                    If DBModelo.Update_PV_FacturaTotal(wFacturaTotal) Then
                        Dim tTickets As List(Of tblTicket) = DBModelo.Get_TicketsByFactura(NoFactura)
                        If tTickets.Count > 0 Then
                            For Each wTicket In tTickets
                                wTicket.numeroFactura = ""
                                If Not DBModelo.Update_Tickets(wTicket) Then
                                    bFlagTicket = True
                                End If
                            Next
                        End If

                        If bFlagTicket = False Then
                            Dim tVentas As List(Of tblVenta) = DBModelo.Get_VentasByFactura(NoFactura)
                            If tVentas.Count > 0 Then
                                If tVentas.Count > 0 Then
                                    For Each wVentas In tVentas
                                        wVentas.numeroFactura = ""
                                        If Not DBModelo.Update_PV_Venta(wVentas) Then
                                            bFlagVenta = True
                                        End If
                                    Next
                                    If bFlagVenta Then
                                        MsgBox("Hubo errores al actualizar la tabla Ventas", MsgBoxStyle.Critical, "Cancelar Complemento de Pago")
                                    End If
                                End If
                            End If
                        Else
                            MsgBox("Hubo errores al actualizar la tabla Ticket", MsgBoxStyle.Critical, "Cancelar Complemento de Pago")
                        End If
                    End If

                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Cancelar Facturas")
                Close()
            End Try
        End If
    End Sub
End Class