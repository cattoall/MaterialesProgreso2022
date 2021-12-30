
Public Class FrmNotaDeCredito
    Private FolioNC_Actual As Integer

    Private Sub TxtPedido_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxtPedido.KeyDown
        Dim Lv_pedido As String = TxtPedido.Text
        Dim lv_total_c As Double = 0

        If e.KeyCode = Keys.Enter Then
            If Lv_pedido = "" Then
                MetroFramework.MetroMessageBox.Show(Me, "Favor De Proporcionar El Número De Factura", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Limpiar_objetos()
                TxtTotal_N.Text = Format(lv_total_c, "$ ###,###,##0.00")
                Exit Sub
            ElseIf Lv_pedido = " " Then
                Exit Sub
            End If

            Dim strFacturaTotal As New factura_total
            strFacturaTotal = DBModelo.Get_PV_FacturaTotal(Lv_pedido)
            If Not IsNothing(strFacturaTotal) Then
                If strFacturaTotal.nc.Equals(" ") Then
                    TxtPedido_C.Text = strFacturaTotal.n_factura
                    DTPFecha.Value = strFacturaTotal.fecha_venta
                    TxtTotal_C.Text = strFacturaTotal.total
                    TxtTipo_C.Text = strFacturaTotal.tipo_venta
                    TxtStatus_C.Text = strFacturaTotal.estado
                    TxtNombre_C.Text = strFacturaTotal.cliente
                    Label9.Visible = True
                    Label9.Text = strFacturaTotal.id_cliente

                    Dim lt_Facturas As New List(Of factura)
                    lt_Facturas = DBModelo.Get_Facturas(CDbl(TxtPedido.Text))

                    For i = 0 To lt_Facturas.Count - 1
                        Dim row As String() = New String() {lt_Facturas(i).n_factura, lt_Facturas(i).idProducto, Format(lt_Facturas(i).cantidad, "###0.00"), lt_Facturas(i).descripcion, Format(lt_Facturas(i).precio, "$ ###,###,##0.00"), Format(lt_Facturas(i).subtotal, "$ ###,###,##0.00"), Format(lt_Facturas(i).cantidad, "###0.00"), lt_Facturas(i).folio, lt_Facturas(i).clave_p}
                        DGVDetalle.Rows.Add(row)
                        lv_total_c = lv_total_c + lt_Facturas(i).subtotal
                    Next i
                    TxtTotal_N.Text = Format(lv_total_c, "$ ###,###,##0.00")
                    ImgGenerarA.Enabled = True
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "Factura: " & Lv_pedido & " Ya Tiene Nota de Crédito Generada.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Limpiar_objetos()
                    TxtTotal_N.Text = Format(lv_total_c, "$ ###,###,##0.00")
                End If
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Factura N°:" & Trim(Lv_pedido) & ", No existe ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Limpiar_objetos()
                TxtTotal_N.Text = Format(lv_total_c, "$ ###,###,##0.00")
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

    Private Sub DGVDetalle_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVDetalle.CellValueChanged
        If e.ColumnIndex = 2 And e.RowIndex <> -1 Then
            Dim lv_cantidad As Double = DGVDetalle.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            If lv_cantidad <= CDbl(DGVDetalle.Rows(e.RowIndex).Cells(6).Value) Then

                DGVDetalle.Rows(e.RowIndex).Cells(4).Value = Trim(Replace(DGVDetalle.Rows(e.RowIndex).Cells(4).Value, "$", ""))
                Dim lv_pu As Double = DGVDetalle.Rows(e.RowIndex).Cells(4).Value
                DGVDetalle.Rows(e.RowIndex).Cells(4).Value = Format(lv_pu, "$ ###,###,##0.00")

                DGVDetalle.Rows(e.RowIndex).Cells(5).Value = Format(lv_cantidad * lv_pu, "$ ###,###,##0.00")

                Dim lv_total_c As Double = 0
                For i = 0 To DGVDetalle.Rows.Count - 1
                    lv_total_c = lv_total_c + Trim(Replace(Trim(Replace(DGVDetalle.Rows(i).Cells(5).Value, "$", "")), ",", ""))
                Next i
                TxtTotal_N.Text = Format(lv_total_c, "$ ###,###,##0.00")
                DGVDetalle.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Format(lv_cantidad, "###0.00")
            Else
                MsgBox("Cantidad mayor a la Cantidad Original", MsgBoxStyle.Critical, "Favor de verificar")
                DGVDetalle.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = DGVDetalle.Rows(e.RowIndex).Cells(6).Value
            End If
        End If
    End Sub

    Private Sub DGVDetalle_RowsRemoved(sender As Object, e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DGVDetalle.RowsRemoved
        Dim lv_total_c As Double = 0
        For i = 0 To DGVDetalle.Rows.Count - 1
            lv_total_c = lv_total_c + Trim(Replace(Trim(Replace(DGVDetalle.Rows(i).Cells(5).Value, "$", "")), ",", ""))
        Next i
        TxtTotal_N.Text = Format(lv_total_c, "$ ###,###,##0.00")
    End Sub

    Private Sub Limpiar_objetos()
        TxtPedido.Clear()
        TxtPedido_C.Clear()
        TxtNombre_C.Clear()
        TxtStatus_C.Clear()
        TxtTipo_C.Clear()
        TxtTotal_C.Clear()
        TxtTotal_N.Clear()
        DTPFecha.Value = Now.Date
        Label9.Visible = False
        ImgGenerarA.Enabled = False
        DGVDetalle.Refresh()
        DGVDetalle.Rows.Clear()
        DGVDetalle.ResumeLayout()
        TxtPedido.Focus()
    End Sub

    Private Sub FrmNotaDeCredito_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub FrmNotaDeCredito_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim lv_folio As Integer = 0
        Dim strFoliosNC As New foliosfactura

        lv_folio = DBModelo.Get_PV_FoliosNC_Actual(Now.Year, "NOTAS DE CREDITO")
        If lv_folio = 0 Then
            strFoliosNC.Year = Now.Year
            strFoliosNC.TipoComprobante = "NOTAS DE CREDITO"
            strFoliosNC.FolioActual = 1
            If DBModelo.Insert_PV_FoliosNC_Actual(strFoliosNC) Then
                lv_folio = 1
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Error al intentar Crear registro en FoliosFactura", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Else
            strFoliosNC = DBModelo.Get_PV_FoliosNC(Now.Year, "NOTAS DE CREDITO")
        End If


        FolioNC_Actual = lv_folio

        Limpiar_objetos()
    End Sub

    Private Sub ImgSalirB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgSalirB.MouseLeave
        Me.ImgSalirA.Visible = True
        Me.ImgSalirB.Visible = False
    End Sub

    Private Sub ImgSalirA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgSalirA.MouseHover
        Me.ImgSalirB.Visible = True
        Me.ImgSalirA.Visible = False
    End Sub

    Private Sub ImgGenerarB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgGenerarB.MouseLeave
        Me.ImgGenerarA.Visible = True
        Me.ImgGenerarB.Visible = False
    End Sub

    Private Sub ImgGenerarA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgGenerarA.MouseHover
        Me.ImgGenerarB.Visible = True
        Me.ImgGenerarA.Visible = False
    End Sub
    Private Sub ImgSalirB_Click(sender As System.Object, e As System.EventArgs) Handles ImgSalirB.Click
        Me.Close()
    End Sub

    Private Sub ImgGenerarB_Click(sender As System.Object, e As System.EventArgs) Handles ImgGenerarB.Click
        Dim strNC As New tblNC

        strNC.n_nc = FolioNC_Actual
        strNC.total = Trim(Replace(Trim(Replace(TxtTotal_N.Text, "$", "")), ",", ""))
        strNC.usuario = nombreUsuario
        strNC.tipo_venta = "CONTADO"
        strNC.cliente = TxtNombre_C.Text
        strNC.id_cliente = CInt(Label9.Text)
        strNC.fecha_venta = DateTime.Now
        strNC.fecha_limite = DateTime.Now
        strNC.codiciones = "PAGO DE CONTADO"
        strNC.estado = "VENDIDO"
        strNC.observaciones = "NC con referencia a Factura:" & TxtPedido_C.Text
        strNC.FolioFactura = TxtPedido_C.Text
        strNC.FormaPago = "01"

        If DBModelo.Insert_NC(strNC) = False Then
            MetroFramework.MetroMessageBox.Show(Me, "Error al Insertar Registro en la table NC", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim strNC_Detalle As New nc_detalle
            For i = 0 To DGVDetalle.Rows.Count - 1

                strNC_Detalle = New nc_detalle

                strNC_Detalle.n_nc = FolioNC_Actual
                strNC_Detalle.FolioFactura = TxtPedido_C.Text
                strNC_Detalle.folio = DGVDetalle.Rows(i).Cells(7).Value
                strNC_Detalle.idProducto = CLng(DGVDetalle.Rows(i).Cells(1).Value)
                strNC_Detalle.clave_p = DGVDetalle.Rows(i).Cells(8).Value
                strNC_Detalle.descripcion = DGVDetalle.Rows(i).Cells(3).Value
                strNC_Detalle.cantidad = DGVDetalle.Rows(i).Cells(2).Value
                strNC_Detalle.fecha = DateTime.Now
                strNC_Detalle.subtotal = Trim(Replace(Trim(Replace(DGVDetalle.Rows(i).Cells(5).Value, "$", "")), ",", ""))
                strNC_Detalle.precio = Trim(Replace(Trim(Replace(DGVDetalle.Rows(i).Cells(4).Value, "$", "")), ",", ""))
                If DBModelo.Insert_NC_Detalle(strNC_Detalle) = False Then
                    MetroFramework.MetroMessageBox.Show(Me, "Error al Insertar Registro en la table NC_DETALLE", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Next i
        End If

        MetroFramework.MetroMessageBox.Show(Me, "Nota de Credito con Folio C-" & Format(FolioNC_Actual, "000000") & ", creada correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim strFoliosNC As New foliosfactura
        strFoliosNC = DBModelo.Get_PV_FoliosNC(Now.Year, "NOTAS DE CREDITO")

        strFoliosNC.FolioActual = FolioNC_Actual + 1

        If DBModelo.Update_PV_FoliosNC_Actual(strFoliosNC) = False Then
            MetroFramework.MetroMessageBox.Show(Me, "Error al intentar Actualizar registro en FoliosFactura", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim strFacturaTotal As New factura_total
        strFacturaTotal = DBModelo.Get_PV_FacturaTotal(TxtPedido_C.Text)

        strFacturaTotal.nc = "X"

        If DBModelo.Update_PV_FacturaTotal(strFacturaTotal) = False Then
            MetroFramework.MetroMessageBox.Show(Me, "Error al intentar Actualizar registro en Factura_Total", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Error_Venta = False
            Exit Sub
        End If

        Dim lv_result As Boolean = False

        If ImprimeNotaDeCredito_CFDI(FolioNC_Actual, DBConnected) = False Then
            MetroFramework.MetroMessageBox.Show(Me, "Hubo un error al Generar la Impresión de la Nota de Crédito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Error_Venta = False
            Exit Sub
        End If

        MetroFramework.MetroMessageBox.Show(Me, "Devolución Terminada Correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Limpiar_objetos()
    End Sub
End Class