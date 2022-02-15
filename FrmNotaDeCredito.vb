
Imports FacturacionSDK

Public Class FrmNotaDeCredito
    Private FolioNC_Actual As Integer
    Dim strFacturaTotal As New tblFacturaTotal
    Private sdk As MFSDK

    Private Sub TxtPedido_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxtPedido.KeyDown
        Dim Lv_pedido As String = TxtPedido.Text
        Dim lv_subtotal_c As Double = 0
        Dim lv_iva_c As Double = 0
        Dim lv_total_c As Double = 0

        If e.KeyCode = Keys.Enter Then
            If Lv_pedido = "" Then
                MetroFramework.MetroMessageBox.Show(Me, "Favor De Proporcionar El Número De Factura", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Limpiar_objetos()
                txtTotal.Text = Format(lv_total_c, "###,###,##0.00")
                Exit Sub
            ElseIf Lv_pedido = " " Then
                Exit Sub
            End If


            strFacturaTotal = DBModelo.Get_PV_FacturaTotal(Lv_pedido)
            If Not IsNothing(strFacturaTotal) Then
                'If strFacturaTotal.nc.Equals(" ") Then
                TxtPedido_C.Text = strFacturaTotal.n_factura
                    DTPFecha.Value = strFacturaTotal.fecha_venta
                    TxtTotal_C.Text = strFacturaTotal.total
                    TxtTipo_C.Text = strFacturaTotal.tipo_venta
                    TxtStatus_C.Text = strFacturaTotal.estado
                    TxtNombre_C.Text = strFacturaTotal.cliente
                    Label9.Visible = True
                    Label9.Text = strFacturaTotal.id_cliente
                    txtUUID.Text = strFacturaTotal.UUID

                    Dim lt_Facturas As New List(Of tblFactura)
                    lt_Facturas = DBModelo.Get_Facturas(CDbl(TxtPedido.Text))

                    For i = 0 To lt_Facturas.Count - 1
                        Dim row As String() = New String() {lt_Facturas(i).n_factura,
                            lt_Facturas(i).idProducto,
                            Format(lt_Facturas(i).cantidad, "###0.00"),
                            lt_Facturas(i).descripcion,
                            Format(lt_Facturas(i).precio, "###,###,##0.00"),
                            Format(lt_Facturas(i).subtotal, "###,###,##0.00"),
                            Format(lt_Facturas(i).cantidad, "###0.00"),
                            lt_Facturas(i).folio,
                            lt_Facturas(i).clave_p,
                            lt_Facturas(i).IVA,
                            lt_Facturas(i).ClaveProducto,
                            lt_Facturas(i).ClaveUnidad}
                        DGVDetalle.Rows.Add(row)
                        lv_subtotal_c = lv_subtotal_c + lt_Facturas(i).subtotal
                        lv_iva_c = lv_iva_c + lt_Facturas(i).IVA
                    Next i
                    txtSubtotal.Text = Format(lv_subtotal_c, "###,###,##0.00")
                    txtIVA.Text = Format(lv_iva_c, "###,###,##0.00")
                    lv_total_c = lv_subtotal_c + lv_iva_c
                    txtTotal.Text = Format(lv_total_c, "###,###,##0.00")
                    mBtnGenerate.Enabled = True
                'Else
                '    MetroFramework.MetroMessageBox.Show(Me, "Factura: " & Lv_pedido & " Ya Tiene Nota de Crédito Generada.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    Limpiar_objetos()
                '    txtTotal.Text = Format(lv_total_c, "###,###,##0.00")
                'End If
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Factura N°:" & Trim(Lv_pedido) & ", No existe ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Limpiar_objetos()
                txtTotal.Text = Format(lv_total_c, "###,###,##0.00")
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

    Private Sub DGVDetalle_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        If e.ColumnIndex = 2 And e.RowIndex <> -1 Then
            Dim lv_cantidad As Double = DGVDetalle.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            If lv_cantidad <= CDbl(DGVDetalle.Rows(e.RowIndex).Cells(6).Value) Then

                DGVDetalle.Rows(e.RowIndex).Cells(4).Value = Trim(Replace(DGVDetalle.Rows(e.RowIndex).Cells(4).Value, "$", ""))
                Dim lv_pu As Double = DGVDetalle.Rows(e.RowIndex).Cells(4).Value
                DGVDetalle.Rows(e.RowIndex).Cells(4).Value = Format(lv_pu, "###,###,##0.00")

                DGVDetalle.Rows(e.RowIndex).Cells(5).Value = Format(lv_cantidad * lv_pu, "###,###,##0.00")

                Dim lv_total_c As Double = 0
                For i = 0 To DGVDetalle.Rows.Count - 1
                    lv_total_c = lv_total_c + Trim(Replace(Trim(Replace(DGVDetalle.Rows(i).Cells(5).Value, "$", "")), ",", ""))
                Next i
                txtTotal.Text = Format(lv_total_c, "###,###,##0.00")
                DGVDetalle.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Format(lv_cantidad, "###0.00")
            Else
                MsgBox("Cantidad mayor a la Cantidad Original", MsgBoxStyle.Critical, "Favor de verificar")
                DGVDetalle.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = DGVDetalle.Rows(e.RowIndex).Cells(6).Value
            End If
        End If
    End Sub

    Private Sub DGVDetalle_RowsRemoved(sender As Object, e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs)
        Dim lv_total_c As Double = 0
        For i = 0 To DGVDetalle.Rows.Count - 1
            lv_total_c = lv_total_c + Trim(Replace(Trim(Replace(DGVDetalle.Rows(i).Cells(5).Value, "$", "")), ",", ""))
        Next i
        txtTotal.Text = Format(lv_total_c, "###,###,##0.00")
    End Sub

    Private Sub Limpiar_objetos()
        TxtPedido.Clear()
        TxtPedido_C.Clear()
        TxtNombre_C.Clear()
        TxtStatus_C.Clear()
        TxtTipo_C.Clear()
        TxtTotal_C.Clear()
        txtTotal.Clear()
        DTPFecha.Value = Now.Date
        Label9.Visible = False
        mBtnGenerate.Enabled = False
        DGVDetalle.Refresh()
        DGVDetalle.Rows.Clear()
        DGVDetalle.ResumeLayout()
        TxtPedido.Focus()
        CmdTipoRelacion.SelectedIndex = -1
        txtUUID.Clear()
        txtSubtotal.Clear()
        txtIVA.Clear()
    End Sub

    Private Sub FrmNotaDeCredito_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub FrmNotaDeCredito_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim lv_folio As Integer = 0
        Dim strFoliosNC As New tblFoliofacturas

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

        Llenar_TipoRelacion()
        Limpiar_objetos()
    End Sub

    Private Sub Llenar_TipoRelacion()
        Dim TipoRelacion As List(Of tblTipoDeRelacion) = DBModelo.GetTipoRelacion_All

        If IsNothing(TipoRelacion) Then
            Exit Sub
        End If

        CmdTipoRelacion.DataSource = TipoRelacion
        CmdTipoRelacion.DisplayMember = "TipoRelacion"
        CmdTipoRelacion.ValueMember = "Id"
        CmdTipoRelacion.SelectedIndex = -1
    End Sub

    Private Sub ImgSalirB_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ImgGenerarB_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub mBtnGenerate_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub mBtnExit_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles mBtnGenerate.Click
        Dim strNC As New tblNC
        If String.IsNullOrEmpty(CmdTipoRelacion.Text) Then
            MsgBox("Favor de seleccionar un Tipo de Relación", MsgBoxStyle.Critical, "Seleccionar Tipo de Relacion")
            Exit Sub
        End If

        Dim NoFactura As String = FolioNC_Actual
        Dim FolioFactura As String = gv_SerieNCSalvador & "-" & FolioNC_Actual & "_" & Format(Date.Now, "yyyyMMdd") & "_CFDI"

        Dim lv_Subtotal As String = Trim(txtSubtotal.Text.Replace(",", ""))
        Dim lv_IVA As String = Trim(txtIVA.Text.Replace(",", ""))
        Dim lv_Total As String = Trim(txtTotal.Text.Replace(",", ""))

        strNC.IdComp = CompanyCode
        strNC.n_nc = CDec(FolioNC_Actual)
        strNC.SubTotal = CDec(lv_Subtotal)
        strNC.IVA = CDec(lv_IVA)
        strNC.total = CDec(lv_Total)
        strNC.usuario = nombreUsuario
        strNC.tipo_venta = strFacturaTotal.tipo_venta
        strNC.cliente = TxtNombre_C.Text
        strNC.id_cliente = CInt(Label9.Text)
        strNC.fecha_venta = DateTime.Now
        strNC.fecha_limite = DateTime.Now
        strNC.codiciones = strFacturaTotal.codiciones
        strNC.estado = "VENDIDO"
        strNC.observaciones = "NC con referencia a Factura:" & TxtPedido_C.Text
        strNC.FolioFactura = TxtPedido_C.Text
        strNC.FormaPago = strFacturaTotal.FormaPago
        strNC.metodopago = strFacturaTotal.metodopago
        strNC.UsoCFDI = strFacturaTotal.UsoCFDI

        If DBModelo.Insert_NC(strNC) = False Then
            MetroFramework.MetroMessageBox.Show(Me, "Error al Insertar Registro en la table NC", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim strNC_Detalle As New tblNcDetalle
            For i = 0 To DGVDetalle.Rows.Count - 1

                strNC_Detalle = New tblNcDetalle

                strNC_Detalle.IdComp = CompanyCode
                strNC_Detalle.n_nc = CLng(FolioNC_Actual)
                strNC_Detalle.FolioFactura = TxtPedido_C.Text
                strNC_Detalle.folio = DGVDetalle.Rows(i).Cells(7).Value.ToString
                strNC_Detalle.idProducto = CLng(DGVDetalle.Rows(i).Cells(1).Value)
                strNC_Detalle.clave_p = DGVDetalle.Rows(i).Cells(8).Value
                strNC_Detalle.descripcion = DGVDetalle.Rows(i).Cells(3).Value
                strNC_Detalle.cantidad = CDec(DGVDetalle.Rows(i).Cells(2).Value)
                strNC_Detalle.fecha = DateTime.Now
                strNC_Detalle.subtotal = CDec(DGVDetalle.Rows(i).Cells(5).Value)
                strNC_Detalle.precio = CDec(DGVDetalle.Rows(i).Cells(4).Value)
                strNC_Detalle.IVA = CDec(DGVDetalle.Rows(i).Cells(9).Value)
                strNC_Detalle.ClaveProducto = DGVDetalle.Rows(i).Cells(10).Value
                strNC_Detalle.ClaveUnidad = DGVDetalle.Rows(i).Cells(11).Value
                If DBModelo.Insert_NC_Detalle(strNC_Detalle) = False Then
                    MetroFramework.MetroMessageBox.Show(Me, "Error al Insertar Registro en la table NC_DETALLE", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Next i
        End If

        'strFacturaTotal.nc = FolioNC_Actual
        strFacturaTotal.nc = "X"

        If DBModelo.Update_PV_FacturaTotal(strFacturaTotal) = False Then
            MetroFramework.MetroMessageBox.Show(Me, "Error al intentar Actualizar registro en Factura_Total", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Error_Venta = False
            Exit Sub
        End If

        Dim strFoliosNC As New tblFoliofacturas
        strFoliosNC = DBModelo.Get_PV_FoliosNC(Now.Year, "NOTAS DE CREDITO")

        strFoliosNC.IdComp = CompanyCode
        strFoliosNC.FolioActual = FolioNC_Actual + 1

        If DBModelo.Update_PV_FoliosNC_Actual(strFoliosNC) = False Then
            MetroFramework.MetroMessageBox.Show(Me, "Error al intentar Actualizar registro en FoliosFactura", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        MetroFramework.MetroMessageBox.Show(Me, "Nota de Credito con Folio " & gv_SerieNCSalvador & "-" & Format(FolioNC_Actual, "000000") & ", creada correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        'Generación del archivo para envío electrónico al SAT
        sdk = New MFSDK
        sdk.Iniciales.Add("version_cfdi", "3.3")
        sdk.Iniciales.Add("MODOINI", "DIVISOR")
        sdk.Iniciales.Add("cfdi", (gv_CDFI_XML_PATH & FolioFactura & ".xml"))
        sdk.Iniciales.Add("xml_debug", (gv_CDFI_XML_PATH & "sin_" & FolioFactura & ".xml"))
        sdk.Iniciales.Add("remueve_acentos", "NO")
        sdk.Iniciales.Add("RESPUESTA_UTF8", "SI")
        sdk.Iniciales.Add("html_a_txt", "NO")

        sdk.AgregaObjeto(PAC)
        sdk.AgregaObjeto(Conf)

        Dim factura As New MFObject("factura")
        Dim subtotal As String = Trim(txtSubtotal.Text.Replace(",", ""))
        Dim total As String = Trim(txtTotal.Text.Replace(",", ""))

        factura("serie") = gv_SerieNCSalvador
        factura("folio") = CDbl(NoFactura)
        factura("fecha_expedicion") = Now.ToString("s")
        factura("metodo_pago") = strFacturaTotal.metodopago
        factura("forma_pago") = strFacturaTotal.FormaPago
        'factura("condicionesDePago") = strFacturaTotal.codiciones
        factura("tipocomprobante") = "E"
        factura("moneda") = "MXN"
        factura("tipocambio") = "1"
        factura("LugarExpedicion") = LugarExpedicion
        factura("RegimenFiscal") = RegimenFiscal
        factura("subtotal") = subtotal
        factura("total") = total

        Dim emisor As New MFObject("emisor")
        emisor("rfc") = Trim(RFC.Replace("-", ""))
        emisor("nombre") = Propietario
        emisor("RegimenFiscal") = RegimenFiscal
        sdk.AgregaObjeto(emisor)

        Dim wa_cliente As tblClientes = DBModelo.GetCliente(strFacturaTotal.id_cliente)
        Dim receptor As New MFObject("receptor")
        receptor("rfc") = wa_cliente.rfc
        receptor("nombre") = TxtNombre_C.Text
        If (UsoCDFI <> "") Then
            receptor("UsoCFDI") = UsoCDFI
        Else
            receptor("UsoCFDI") = strFacturaTotal.UsoCFDI
        End If
        sdk.AgregaObjeto(receptor)

        Dim oConceptos As New MFObject("conceptos")
        For i = 0 To DGVDetalle.RowCount - 1
            Dim vImporte As String = Trim(Trim(DGVDetalle(5, i).Value).Replace("$", "")).Replace(",", "").ToString
            Dim vValorUnitario As String = Trim(Trim(DGVDetalle(4, i).Value).Replace("$", "")).Replace(",", "").ToString

            Dim oLinea As New MFObject(i.ToString)
            oLinea("ClaveProdServ") = DGVDetalle(10, i).Value.ToString
            oLinea("NoIdentificacion") = DGVDetalle(8, i).Value.ToString
            oLinea("Cantidad") = DGVDetalle(2, i).Value.ToString
            oLinea("ClaveUnidad") = DGVDetalle(11, i).Value.ToString
            oLinea("Descripcion") = DGVDetalle(3, i).Value.ToString
            oLinea("ValorUnitario") = vValorUnitario
            oLinea("Importe") = vImporte


            Dim oImpuestos As New MFObject("Impuestos")
            Dim oTraslado As New MFObject("Traslados")
            Dim oTraslados As New MFObject(i.ToString)
            oTraslados("Base") = vImporte
            Dim vImporteTras As String = DGVDetalle(9, i).Value.ToString
            oTraslados("Importe") = vImporteTras
            oTraslados("Impuesto") = "002"
            oTraslados("TasaOCuota") = FormatNumber(FactorIVA - 1, 6)
            oTraslados("TipoFactor") = "Tasa"
            oTraslado.AgregaSubnodo(oTraslados)
            oImpuestos.AgregaSubnodo(oTraslado)
            oLinea.AgregaSubnodo(oImpuestos)
            oConceptos.AgregaSubnodo(oLinea)
        Next
        sdk.AgregaObjeto(factura)
        sdk.AgregaObjeto(oConceptos)

        Dim oImpuestosTotales As New MFObject("impuestos")
        Dim vImporteTotalIVA As String = (total - subtotal).ToString

        oImpuestosTotales("TotalImpuestosTrasladados") = Trim(vImporteTotalIVA.Replace(",", ""))

        Dim itras As New MFObject("translados")
        Dim itra0 As New MFObject("0")
        Dim vImporteTotalIVAFormat As String = FormatNumber(vImporteTotalIVA, 2)
        itra0("Impuesto") = "002"
        itra0("Importe") = Trim(vImporteTotalIVAFormat.Replace(",", ""))
        itra0("TasaOCuota") = FormatNumber((FactorIVA - 1), 6)
        itra0("TipoFactor") = "Tasa"
        itras.AgregaSubnodo(itra0)
        oImpuestosTotales.AgregaSubnodo(itras)

        sdk.AgregaObjeto(oImpuestosTotales)

        Dim oCFDIRelacionados As New MFObject("CfdisRelacionados")
        Dim TipoRelacion = CmdTipoRelacion.Text
        oCFDIRelacionados("TipoRelacion") = TipoRelacion.Substring(0, 2)

        Dim iCFDI0 As New MFObject("UUID")

        iCFDI0("0") = txtUUID.Text
        oCFDIRelacionados.AgregaSubnodo(iCFDI0)
        sdk.AgregaObjeto(oCFDIRelacionados)

        'Timbra Factura
        Dim view As DataGridView
        Dim respuesta As SDKRespuesta = sdk.Timbrar("C:\sdk2\timbrar32.bat", gv_CDFI_XML_PATH, FolioFactura, False)
        If respuesta.Codigo_MF_Numero = 0 Then
            MsgBox(("Nota de Crédito " & gv_SerieNCSalvador & "-" & NoFactura & " Generada Correctamente"), MsgBoxStyle.Information, "Generación de Nota de Crédito")
            ImprimeNotaDeCredito(NoFactura, FolioFactura, True)
        Else
            MsgBox($"Código: {respuesta.Codigo_MF_Numero} Mensaje: {respuesta.Codigo_MF_Texto}", MsgBoxStyle.Critical, Nothing)
            view = DGVDetalle
            DGVDetalle = view
            'If Not Me.Rollback_full(Conversions.ToString(CDbl((Conversions.ToDouble(str2) - 1))), View) Then
            '    Interaction.MsgBox("No se pudo deshacer/eliminar la factura creada", MsgBoxStyle.ApplicationModal, Nothing)
            'End If
            'Me.TxtFolio.Text = Conversions.ToString(CDbl((Conversions.ToDouble(str2) - 1)))
        End If
        'limpiar()


        'If ImprimeNotaDeCredito_CFDI(FolioNC_Actual, DBConnected) = False Then
        '    MetroFramework.MetroMessageBox.Show(Me, "Hubo un error al Generar la Impresión de la Nota de Crédito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Error_Venta = False
        '    Exit Sub
        'End If

        MetroFramework.MetroMessageBox.Show(Me, "Devolución Terminada Correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Limpiar_objetos()
    End Sub
End Class