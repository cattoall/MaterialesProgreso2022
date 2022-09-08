Imports FacturacionSDK

Public Class frmComplementoPago
    Private sdk As MFSDK
    Private folio As String
    Private folio_inicial As String
    Private folio_final As String
    Private folio_timbre As String
    Private wFolioFacturas As tblFolioFacturas

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Buscar_Clientes = "COMPLEMENTO"
        FrmBuscarClientesVentas.ShowDialog()
        FrmBuscarClientesVentas.Close()
        LblCliente.Text = idClientePago
        If (idClientePago <> "") Then
            GetInvoicesByClient()
        End If

    End Sub

    Private Sub GetInvoicesByClient()
        Try
            Dim tFacturaTotal As List(Of tblFacturaTotal) = DBModelo.GetFacturasHeaderByIdCliente(idClientePago)

            DataGridView1.Rows.Clear()

            If (tFacturaTotal.Count <= 0) Then
                MsgBox("No existen facturas para este cliente", MsgBoxStyle.Critical, "Complemento de Pagos")
            Else

                For i = 0 To tFacturaTotal.Count - 1
                    If IsDBNull(tFacturaTotal.Item(i).fecha_venta) Then
                        tFacturaTotal.Item(i).fecha_venta = ""
                    End If
                    If IsDBNull(tFacturaTotal.Item(i).n_factura) Then
                        tFacturaTotal.Item(i).n_factura = ""
                    End If
                    If IsDBNull(tFacturaTotal.Item(i).total) Then
                        tFacturaTotal.Item(i).total = ""
                    End If
                    If IsDBNull(tFacturaTotal.Item(i).tipo_venta) Then
                        tFacturaTotal.Item(i).tipo_venta = ""
                    End If
                    If IsDBNull(tFacturaTotal.Item(i).cliente) Then
                        tFacturaTotal.Item(i).cliente = ""
                    End If
                    If IsDBNull(tFacturaTotal.Item(i).codiciones) Then
                        tFacturaTotal.Item(i).codiciones = ""
                    End If
                    If IsDBNull(tFacturaTotal.Item(i).metodopago) Then
                        tFacturaTotal.Item(i).metodopago = ""
                    End If
                    If IsDBNull(tFacturaTotal.Item(i).FormaPago) Then
                        tFacturaTotal.Item(i).FormaPago = ""
                    End If
                    If IsDBNull(tFacturaTotal.Item(i).UsoCFDI) Then
                        tFacturaTotal.Item(i).UsoCFDI = ""
                    End If
                    If IsDBNull(tFacturaTotal.Item(i).UUID) Then
                        tFacturaTotal.Item(i).UUID = ""
                    End If
                    If IsDBNull(tFacturaTotal.Item(i).Cancelada) Then
                        tFacturaTotal.Item(i).Cancelada = 0
                    End If
                    If IsDBNull(tFacturaTotal.Item(i).ComproPago) Then
                        tFacturaTotal.Item(i).ComproPago = 0
                    End If

                    Dim textArray1 As String() = New String(15 - 1) {}
                    textArray1(0) = tFacturaTotal.Item(i).fecha_venta
                    textArray1(1) = tFacturaTotal.Item(i).n_factura
                    textArray1(2) = FormatNumber(tFacturaTotal.Item(i).total, 2)
                    textArray1(3) = tFacturaTotal.Item(i).tipo_venta
                    textArray1(4) = tFacturaTotal.Item(i).cliente
                    textArray1(5) = tFacturaTotal.Item(i).codiciones
                    textArray1(6) = tFacturaTotal.Item(i).metodopago
                    textArray1(7) = tFacturaTotal.Item(i).FormaPago
                    textArray1(8) = tFacturaTotal.Item(i).UsoCFDI
                    textArray1(9) = tFacturaTotal.Item(i).UUID
                    Select Case tFacturaTotal.Item(i).Cancelada
                        Case 0
                            textArray1(10) = Boolean.FalseString
                        Case 1
                            textArray1(10) = Boolean.TrueString
                    End Select
                    Select Case tFacturaTotal.Item(i).ComproPago
                        Case 0
                            textArray1(11) = Boolean.FalseString
                        Case 1
                            textArray1(11) = Boolean.TrueString
                    End Select
                    textArray1(12) = FormatNumber(tFacturaTotal.Item(i).subtotal, 2)
                    textArray1(13) = FormatNumber(tFacturaTotal.Item(i).iva, 2)
                    textArray1(14) = tFacturaTotal.Item(i).ObjetoImp
                    Dim values As String() = textArray1
                    DataGridView1.Rows.Add(values)
                    i += 1
                Next

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, Nothing)
        End Try
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Try
            Dim tFacturaTotal As List(Of tblFacturaTotal) = New List(Of tblFacturaTotal)

            DataGridView1.Rows.Clear()

            If chkCancelados.Checked And chkPagados.Checked Then
                tFacturaTotal = DBModelo.GetFacturasHeaderByIdClienteFechaVentaCanceladosPagados(idClientePago, Format(dtFechaInicial.Value.Date, "yyyy-MM-dd"), Format(dtFechaFinal.Value.Date, "yyyy-MM-dd"), "1", "1")
            End If

            If chkCancelados.Checked And chkPagados.Checked = False Then
                tFacturaTotal = DBModelo.GetFacturasHeaderByIdClienteFechaVentaCancelados(idClientePago, Format(dtFechaInicial.Value.Date, "yyyy-MM-dd"), Format(dtFechaFinal.Value.Date, "yyyy-MM-dd"), "1")
            End If

            If chkCancelados.Checked = False And chkPagados.Checked Then
                tFacturaTotal = DBModelo.GetFacturasHeaderByIdClienteFechaVentaPagados(idClientePago, Format(dtFechaInicial.Value.Date, "yyyy-MM-dd"), Format(dtFechaFinal.Value.Date, "yyyy-MM-dd"), "1")
            End If

            If chkCancelados.Checked = False And chkPagados.Checked = False Then
                tFacturaTotal = DBModelo.GetFacturasHeaderByIdClienteFechaVenta(idClientePago, Format(dtFechaInicial.Value.Date, "yyyy-MM-dd"), Format(dtFechaFinal.Value.Date, "yyyy-MM-dd"))
            End If


            If (tFacturaTotal.Count <= 0) Then
                MsgBox("No existen facturas para este cliente", MsgBoxStyle.Critical, "Complemento de Pagos")
            Else
                For i = 0 To tFacturaTotal.Count - 1
                    If IsDBNull(tFacturaTotal.Item(i).fecha_venta) Then
                        tFacturaTotal.Item(i).fecha_venta = ""
                    End If
                    If IsDBNull(tFacturaTotal.Item(i).n_factura) Then
                        tFacturaTotal.Item(i).n_factura = ""
                    End If
                    If IsDBNull(tFacturaTotal.Item(i).total) Then
                        tFacturaTotal.Item(i).total = ""
                    End If
                    If IsDBNull(tFacturaTotal.Item(i).tipo_venta) Then
                        tFacturaTotal.Item(i).tipo_venta = ""
                    End If
                    If IsDBNull(tFacturaTotal.Item(i).cliente) Then
                        tFacturaTotal.Item(i).cliente = ""
                    End If
                    If IsDBNull(tFacturaTotal.Item(i).codiciones) Then
                        tFacturaTotal.Item(i).codiciones = ""
                    End If
                    If IsDBNull(tFacturaTotal.Item(i).metodopago) Then
                        tFacturaTotal.Item(i).metodopago = ""
                    End If
                    If IsDBNull(tFacturaTotal.Item(i).FormaPago) Then
                        tFacturaTotal.Item(i).FormaPago = ""
                    End If
                    If IsDBNull(tFacturaTotal.Item(i).UsoCFDI) Then
                        tFacturaTotal.Item(i).UsoCFDI = ""
                    End If
                    If IsDBNull(tFacturaTotal.Item(i).UUID) Then
                        tFacturaTotal.Item(i).UUID = ""
                    End If
                    If IsDBNull(tFacturaTotal.Item(i).Cancelada) Then
                        tFacturaTotal.Item(i).Cancelada = 0
                    End If
                    If IsDBNull(tFacturaTotal.Item(i).ComproPago) Then
                        tFacturaTotal.Item(i).ComproPago = 0
                    End If

                    Dim textArray1 As String() = New String(15 - 1) {}
                    textArray1(0) = tFacturaTotal.Item(i).fecha_venta
                    textArray1(1) = tFacturaTotal.Item(i).n_factura
                    textArray1(2) = FormatNumber(tFacturaTotal.Item(i).total, 2)
                    textArray1(3) = tFacturaTotal.Item(i).tipo_venta
                    textArray1(4) = tFacturaTotal.Item(i).cliente
                    textArray1(5) = tFacturaTotal.Item(i).codiciones
                    textArray1(6) = tFacturaTotal.Item(i).metodopago
                    textArray1(7) = tFacturaTotal.Item(i).FormaPago
                    textArray1(8) = tFacturaTotal.Item(i).UsoCFDI
                    textArray1(9) = tFacturaTotal.Item(i).UUID
                    Select Case tFacturaTotal.Item(i).Cancelada
                        Case 0
                            textArray1(10) = Boolean.FalseString
                        Case 1
                            textArray1(10) = Boolean.TrueString
                    End Select
                    Select Case tFacturaTotal.Item(i).ComproPago
                        Case 0
                            textArray1(11) = Boolean.FalseString
                        Case 1
                            textArray1(11) = Boolean.TrueString
                    End Select
                    textArray1(12) = FormatNumber(tFacturaTotal.Item(i).subtotal, 2)
                    textArray1(13) = FormatNumber(tFacturaTotal.Item(i).iva, 2)
                    textArray1(14) = tFacturaTotal.Item(i).ObjetoImp
                    Dim values As String() = textArray1
                    DataGridView1.Rows.Add(values)
                    i += 1
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, Nothing)
        End Try

    End Sub

    Private Sub CmdLimpiar_Click(sender As Object, e As EventArgs) Handles CmdLimpiar.Click
        limpiar()
    End Sub

    Private Sub limpiar()
        DataGridView1.Rows.Clear()
        DataGridView1.DataSource = Nothing
        folio_final = ""
        folio_inicial = ""
        txtNombre.Clear()
        txtDirecion.Clear()
        txtColonia.Clear()
        txtCP.Clear()
        txtEstado.Clear()
        txtNumero.Clear()
        LblCliente.Text = ""
        TxtRFC.Clear()
        txtCiudad.Clear()
        txtEmail.Clear()
        txtRFR.Clear()
        CmdFormaPago.SelectedIndex = -1
        MetodoPago = ""
        FormaPago = ""
        UsoCDFI = ""
        ClaveUnidad = ""
    End Sub

    Private Sub frmComplementoPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrBImprimiendo.Visible = True
        PrBImprimiendo.Value = 0
        dtFechaFinal.Value = DateAndTime.Now
        dtFechaInicial.Value = DateAndTime.Now.AddDays(-30)
        Dim dataTable As New DataTable
        Try
            limpiar()
            wFolioFacturas = DBModelo.GetFolioFactura("PAGOS", Now.Date.Year)

            If IsNothing(wFolioFacturas) Then
                MsgBox("No hay Folios Disponibles para Pagos", MsgBoxStyle.Critical, "Verificación de Folios Disponibles")
            Else
                folio = wFolioFacturas.FolioActual
                folio_inicial = wFolioFacturas.FolioInicial
                folio_final = wFolioFacturas.FolioFinal

                lblPago.Text = ("Pago No.: P-" & folio)

                dtpFechaPago.Value = Now

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        frmCancelacion.NoFactura = ""
        frmCancelacion.NoPago = ""
        frmCancelacion.UUID_Cancelar = ""
        frmCancelacion.RFC_ReceptorCancelar = ""
        frmCancelacion.CancelaPago = False
        frmCancelacion.FechaFactura = ""

        Dim rowCount As Integer = Me.DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected)
        If (rowCount > 1) Then
            MsgBox("La cancelación es por factura, favor de solo seleccionar una Factura a cancelar.", MsgBoxStyle.Information, "Complemento de Pagos")
        ElseIf (rowCount = 0) Then
            MsgBox("No hay factura seleccionada para cancelar, favor de solo seleccionar la Factura a cancelar.", MsgBoxStyle.Information, "Complemento de Pagos")
        ElseIf DataGridView1(11, DataGridView1.CurrentRow.Index).Value = True Then
            MsgBox("La factura aun tiene el status Pagada, favor de cancelar el pago y posteriormente la factura.", MsgBoxStyle.Information, "Complemento de Pagos")
        ElseIf DataGridView1(10, DataGridView1.CurrentRow.Index).Value = True Then
            MsgBox("La factura ya se encuentra cancelada.", MsgBoxStyle.Information, "Complemento de Pagos")
        ElseIf (rowCount = 1) Then
            frmCancelacion.NoFactura = DataGridView1(1, DataGridView1.CurrentRow.Index).Value
            frmCancelacion.UUID_Cancelar = DataGridView1(9, DataGridView1.CurrentRow.Index).Value
            frmCancelacion.RFC_ReceptorCancelar = TxtRFC.Text
            frmCancelacion.CancelaPago = False
            frmCancelacion.FechaFactura = Format(DataGridView1(0, DataGridView1.CurrentRow.Index).Value, "yyyyMMdd")
            frmCancelacion.ShowDialog()
            btnMostrar_Click(sender, e)
        End If

    End Sub

    Private Sub CmdCancelarPago_Click(sender As Object, e As EventArgs) Handles CmdCancelarPago.Click
        frmCancelacion.NoFactura = ""
        frmCancelacion.NoPago = ""
        frmCancelacion.UUID_Cancelar = ""
        frmCancelacion.RFC_ReceptorCancelar = ""
        frmCancelacion.CancelaPago = False
        frmCancelacion.FechaFactura = ""
        Dim rowCount As Integer = DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected)
        If (rowCount > 1) Then
            MsgBox("La cancelación es por Factura, favor de solo seleccionar una Factura a cancelar.", MsgBoxStyle.Information, "Complemento de Pagos")
        ElseIf (rowCount = 0) Then
            MsgBox("No hay factura seleccionada para cancelar, favor de solo seleccionar la Factura a cancelar.", MsgBoxStyle.Information, "Complemento de Pagos")
        ElseIf DataGridView1(11, DataGridView1.CurrentRow.Index).Value = False Then
            MsgBox("La factura aun no tiene Complemento de Pago generado.", MsgBoxStyle.Information, "Complemento de Pagos")
        ElseIf DataGridView1(10, DataGridView1.CurrentRow.Index).Value = True Then
            MsgBox("La factura ya se encuentra cancelada.", MsgBoxStyle.Information, "Complemento de Pagos")
        ElseIf (rowCount = 1) Then
            frmCancelacion.NoFactura = DataGridView1(1, DataGridView1.CurrentRow.Index).Value
            Dim tComplementoPagoD As List(Of TblComplementoPagosD) = DBModelo.GetComplementoPagoD_ByFactura(frmCancelacion.NoFactura)
            If (tComplementoPagoD.Count > 0) Then
                frmCancelacion.NoPago = tComplementoPagoD.Item(0).n_pago
                frmCancelacion.UUID_Cancelar = tComplementoPagoD.Item(0).UUID
            Else
                MsgBox("El Complemento de Pago de la Factura no ha sido encontrado.", MsgBoxStyle.Information, "Complemento de Pagos")
                Exit Sub
            End If
            frmCancelacion.RFC_ReceptorCancelar = TxtRFC.Text
            frmCancelacion.CancelaPago = True
            frmCancelacion.FechaFactura = Format(DataGridView1(0, DataGridView1.CurrentRow.Index).Value, "yyyyMMdd")
            frmCancelacion.ShowDialog()
            btnMostrar_Click(sender, e)
        End If
    End Sub

    Private Sub btnComproPago_Click(sender As Object, e As EventArgs) Handles btnComproPago.Click
        Dim amount As Decimal = DataGridView1(2, DataGridView1.CurrentRow.Index).Value
        If (txtNombre.Text = "") Then
            MsgBox("Favor de especificar un Cliente.", MsgBoxStyle.Critical, "Complemento de Pago")
            btnBuscar.Focus()
            Cursor = Cursors.Default
        ElseIf (txtDirecion.Text = "") Then
            MsgBox("Favor de especificar el Domicilio.", MsgBoxStyle.Critical, "Complemento de Pago")
            btnBuscar.Focus()
            Cursor = Cursors.Default
        ElseIf (txtCiudad.Text = "") Then
            MsgBox("Favor de especificar la Ciudad.", MsgBoxStyle.Critical, "Complemento de Pago")
            btnBuscar.Focus()
            Cursor = Cursors.Default
        ElseIf (txtEstado.Text = "") Then
            MsgBox("Favor de especificar el Estado.", MsgBoxStyle.Critical, Nothing)
            btnBuscar.Focus()
            Cursor = Cursors.Default
        ElseIf (txtColonia.Text = "") Then
            MsgBox("Favor de especificar la Colonia.", MsgBoxStyle.Critical, "Complemento de Pago")
            btnBuscar.Focus()
            Cursor = Cursors.Default
        ElseIf (txtCP.Text = "") Then
            MsgBox("Favor de especificar el Código Postal.", MsgBoxStyle.Critical, "Complemento de Pago")
            btnBuscar.Focus()
            Cursor = Cursors.Default
        ElseIf (TxtRFC.Text = "") Then
            MsgBox("Favor de especificar el RFC.", MsgBoxStyle.Critical, "Complemento de Pago")
            btnBuscar.Focus()
            Cursor = Cursors.Default
        ElseIf (CmdFormaPago.Text = "") Then
            MsgBox("Favor de especificar el Método de Pago", MsgBoxStyle.Critical, "Complemento de Pago")
            CmdFormaPago.Focus()
            Cursor = Cursors.Default
        Else
            rep_FormadePago = ""
            rep_folio = ""
            rep_direccion = ""
            rep_cp = ""
            rep_cuidad = ""
            rep_colonia = ""
            rep_direccion = txtDirecion.Text
            If (txtNumero.Text <> "") Then
                rep_direccion = (rep_direccion & " # " & txtNumero.Text)
            End If
            rep_cp = txtCP.Text
            rep_cuidad = txtCiudad.Text
            rep_colonia = txtColonia.Text
            Dim rowCount As Integer = DataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected)
            If (rowCount = 0) Then
                MsgBox("No hay Factura(s) seleccionada(s) para generar Complemento de Pago.", MsgBoxStyle.Information, "Complemento de Pago")
            ElseIf (rowCount >= 1) Then
                If DataGridView1(10, DataGridView1.CurrentRow.Index).Value = True Then
                    MsgBox("Existen Facturas seleccionadas con Status Cancelada. Favor de excluir Facturas Canceladas.", MsgBoxStyle.Information, "Complemento de Pago")
                ElseIf DataGridView1(11, DataGridView1.CurrentRow.Index).Value = True Then
                    MsgBox("Existen Facturas seleccionadas con Status Pagadas. Favor de excluir Facturas Pagadas.", MsgBoxStyle.Information, "Complemento de Pago")
                ElseIf (MsgBox(("¿Generar Complemento de Pago por " & Format(amount, "$ ###,###,###.00") & " MXN con Fecha del Pago " & Format(dtpFechaPago.Value, "dd-MM-yyyy") & "?"), MsgBoxStyle.YesNo, "Complemento de Pago") = MsgBoxResult.Yes) Then
                    GenerarComplementoPago(amount)
                    GetInvoicesByClient()
                End If
            End If
        End If
    End Sub

    Private Sub GenerarComplementoPago(ByVal totalFacturas As String)
        PrBImprimiendo.Visible = True
        PrBImprimiendo.Value = 0
        PrBImprimiendo.Step = 10
        Dim strComplementoPagoH As tblComplementoPagosH = New tblComplementoPagosH
        strComplementoPagoH.IdComp = CompanyCode
        strComplementoPagoH.n_pago = folio
        strComplementoPagoH.total = totalFacturas
        strComplementoPagoH.cliente = txtNombre.Text
        strComplementoPagoH.id_cliente = LblCliente.Text
        strComplementoPagoH.fecha_pago = Format(Now, "yyyy-MM-dd")
        strComplementoPagoH.formapago = CmdFormaPago.Text.Substring(0, 2)
        strComplementoPagoH.UsoCFDI = "CP01"
        strComplementoPagoH.Cancelado = 0
        strComplementoPagoH.UUID = ""

        If DBModelo.InsertComplementoPagoH(strComplementoPagoH) Then
            For Each row20 As DataGridViewRow In DataGridView1.SelectedRows
                Dim sComplementoPagoD As TblComplementoPagosD = New TblComplementoPagosD
                sComplementoPagoD.IdComp = CompanyCode
                sComplementoPagoD.n_pago = folio
                sComplementoPagoD.n_factura = row20.Cells(1).Value
                sComplementoPagoD.UUID = row20.Cells(9).Value
                sComplementoPagoD.Cancelado = 0
                If DBModelo.InsertComplementoPagoD(sComplementoPagoD) = False Then
                    MsgBox(("Error al agregar detalle al Complemento de Pago " & folio), MsgBoxStyle.Critical, "Complemento de Pagos Detalle")
                    Exit Sub
                End If
            Next

            sdk = New MFSDK
            Dim FolioPago As String = folio
            folio_timbre = "P-" & folio & "_" & Format(Now, "yyyyMMdd") & "CFDI"
            sdk.Iniciales.Add("version_cfdi", "4.0")
            sdk.Iniciales.Add("complemento", "pagos20")
            sdk.Iniciales.Add("MODOINI", "DIVISOR")
            sdk.Iniciales.Add("remueve_acentos", "NO")
            sdk.Iniciales.Add("RESPUESTA_UTF8", "SI")
            sdk.Iniciales.Add("html_a_txt", "NO")
            sdk.Iniciales.Add("validacion_local", "NO")
            sdk.Iniciales.Add("cfdi", (gv_CDFI_XML_PATH & folio_timbre & ".xml"))
            sdk.Iniciales.Add("xml_debug", (gv_CDFI_XML_PATH & "sin_" & folio_timbre & ".xml"))

            sdk.AgregaObjeto(PAC)
            sdk.AgregaObjeto(Conf)

            Dim FacHeader As New MFObject("factura")
            FacHeader("Serie") = "P"
            FacHeader("folio") = folio
            FacHeader("fecha_expedicion") = Now.ToString("s")
            FacHeader("tipocomprobante") = "P"
            FacHeader("moneda") = "XXX"
            FacHeader("LugarExpedicion") = LugarExpedicion
            FacHeader("subtotal") = "0"
            FacHeader("total") = "0"
            FacHeader("Exportacion") = "01"

            Dim FacEmisor As New MFObject("emisor")
            FacEmisor("rfc") = Trim(RFC.Replace("-", ""))
            FacEmisor("nombre") = Propietario
            FacEmisor("RegimenFiscal") = RegimenFiscal

            Dim FacReceptor As New MFObject("receptor")
            FacReceptor("rfc") = TxtRFC.Text
            FacReceptor("nombre") = txtNombre.Text
            FacReceptor("UsoCFDI") = "CP01"
            FacReceptor("DomicilioFiscalReceptor") = txtCP.Text
            FacReceptor("RegimenFiscalReceptor") = txtRFR.Text

            Dim FacConceptos As New MFObject("conceptos")
            Dim FacConcepto As New MFObject("0")
            FacConcepto("ClaveProdServ") = "84111506"
            FacConcepto("Cantidad") = "1"
            FacConcepto("ClaveUnidad") = "ACT"
            FacConcepto("Descripcion") = "Pago"
            FacConcepto("ValorUnitario") = "0"
            FacConcepto("Importe") = "0"
            FacConcepto("ObjetoImp") = "01"
            FacConceptos.AgregaSubnodo(FacConcepto)

            Dim FacPagos20 As New MFObject("pagos20")
            Dim FacPagos As New MFObject("Pagos")
            Dim FacPago As New MFObject("0")
            Dim strFechaPago As String = dtpFechaPago.Value.ToString("yyyy-MM-dd")
            strFechaPago = strFechaPago & "T12:00:00"
            FacPago("FechaPago") = strFechaPago
            FacPago("FormaDePagoP") = CmdFormaPago.Text.Substring(0, 2)
            FacPago("MonedaP") = "MXN"
            FacPago("Monto") = totalFacturas
            FacPago("TipoCambioP") = "1"

            Dim dIVATotal As Decimal = 0
            Dim dExentoTotal As Decimal = 0
            For Each row20 As DataGridViewRow In DataGridView1.SelectedRows
                Dim FacDoctoRelacionados As New MFObject("DoctoRelacionado")
                Dim iIndex As Integer = 0
                Dim FacDoctoRelacionado As New MFObject(iIndex)
                Dim sPagado As String = Trim(row20.Cells(2).Value).Replace(",", "")
                Dim sObjImp As String = row20.Cells(14).Value.ToString
                Dim sIVA As String = Trim(row20.Cells(13).Value).Replace(",", "")

                FacDoctoRelacionado("IdDocumento") = row20.Cells(9).Value
                FacDoctoRelacionado("Serie") = "B"
                FacDoctoRelacionado("Folio") = row20.Cells(1).Value
                FacDoctoRelacionado("MonedaDR") = "MXN"
                FacDoctoRelacionado("NumParcialidad") = "1"
                FacDoctoRelacionado("ImpSaldoAnt") = sPagado
                FacDoctoRelacionado("ImpPagado") = sPagado
                FacDoctoRelacionado("ImpSaldoInsoluto") = "0.00"
                FacDoctoRelacionado("EquivalenciaDR") = "1"
                FacDoctoRelacionado("ObjetoImpDR") = sObjImp

                If sObjImp = "02" Then
                    Dim ImpuestosDR As New MFObject("ImpuestosDR")
                    Dim TrasladoDR As New MFObject("TrasladoDR")
                    Dim TrasladoDR_0 As New MFObject("0")

                    TrasladoDR_0("BaseDR") = Trim(FormatNumber((100 * CDec(sIVA)) / 16, 2)).Replace(",", "")
                    TrasladoDR_0("ImpuestoDR") = "002"
                    TrasladoDR_0("TipoFactorDR") = "Tasa"
                    TrasladoDR_0("TasaOCuotaDR") = FormatNumber(FactorIVA - 1, 6)
                    TrasladoDR_0("ImporteDR") = sIVA
                    dIVATotal = dIVATotal + CDec(sIVA)

                    TrasladoDR.AgregaSubnodo(TrasladoDR_0)
                    ImpuestosDR.AgregaSubnodo(TrasladoDR)
                    FacDoctoRelacionado.AgregaSubnodo(ImpuestosDR)
                Else
                    dExentoTotal = dExentoTotal + sPagado
                End If

                FacDoctoRelacionados.AgregaSubnodo(FacDoctoRelacionado)
                FacPago.AgregaSubnodo(FacDoctoRelacionados)
            Next

            If dIVATotal <> CDec("0.00") Then
                Dim ImpuestosP As New MFObject("ImpuestosP")
                Dim TrasladosP As New MFObject("TrasladosP")
                Dim TrasladosP_0 As New MFObject("0")

                TrasladosP_0("BaseP") = Trim(FormatNumber((100 * dIVATotal) / 16, 2)).Replace(",", "")
                TrasladosP_0("ImpuestoP") = "002"
                TrasladosP_0("TipoFactorP") = "Tasa"
                TrasladosP_0("TasaOCuotaP") = FormatNumber(FactorIVA - 1, 6)
                TrasladosP_0("ImporteP") = dIVATotal.ToString()

                TrasladosP.AgregaSubnodo(TrasladosP_0)
                ImpuestosP.AgregaSubnodo(TrasladosP)
                FacPago.AgregaSubnodo(ImpuestosP)
            End If

            FacPagos.AgregaSubnodo(FacPago)
            FacPagos20.AgregaSubnodo(FacPagos)
            Dim pTotales As New MFObject("Totales")
            pTotales("TotalTrasladosImpuestoIVA8") = "0.00"
            If dIVATotal <> CDec("0.00") Then
                pTotales("TotalTrasladosImpuestoIVA16") = dIVATotal.ToString
            Else
                pTotales("TotalTrasladosImpuestoIVA16") = "0.00"
            End If
            pTotales("TotalTrasladosImpuestoIVA0") = "0.00"
            If dExentoTotal <> CDec("0.00") Then
                pTotales("TotalTrasladosBaseIVAExento") = dExentoTotal.ToString
            Else
                pTotales("TotalTrasladosBaseIVAExento") = "0.00"
            End If
            pTotales("TotalTrasladosBaseIVA8") = "0.00"
            If dIVATotal <> CDec("0.00") Then
                pTotales("TotalTrasladosBaseIVA16") = Trim(FormatNumber((100 * dIVATotal) / 16, 2)).Replace(",", "")
            Else
                pTotales("TotalTrasladosBaseIVA16") = "0.00"
            End If
            pTotales("TotalTrasladosBaseIVA0") = "0.00"
            pTotales("TotalRetencionesIVA") = "0.00"
            pTotales("TotalRetencionesISR") = "0.00"
            pTotales("TotalRetencionesIEPS") = "0.00"
            pTotales("MontoTotalPagos") = totalFacturas

            FacPagos20.AgregaSubnodo(pTotales)

            sdk.AgregaObjeto(FacHeader)
            sdk.AgregaObjeto(FacEmisor)
            sdk.AgregaObjeto(FacReceptor)
            sdk.AgregaObjeto(FacConceptos)
            sdk.AgregaObjeto(FacPagos20)
            PrBImprimiendo.PerformStep()

            Try
                PrBImprimiendo.PerformStep()
                Dim respuesta As SDKRespuesta = sdk.Timbrar("C:\sdk2\timbrar32.bat", gv_CDFI_XML_PATH, folio_timbre, False)
                PrBImprimiendo.PerformStep()

                If Not respuesta.Codigo_MF_Numero = 0 Then
                    PrBImprimiendo.Value = 100
                    MsgBox($"Código: {respuesta.Codigo_MF_Numero} Mensaje: {respuesta.Codigo_MF_Texto}", MsgBoxStyle.Critical, "Complemento de Pagos")
                    PrBImprimiendo.Value = 0
                Else
                    MsgBox(("Complemento de Pago " & folio_timbre & " Generado Correctamente"), MsgBoxStyle.Information, "Complemento de Pagos")
                    folio = folio + 1
                    wFolioFacturas.FolioActual = folio
                    If DBModelo.Update_PV_FoliosNC_Actual(wFolioFacturas) Then
                        For Each row20 As DataGridViewRow In DataGridView1.SelectedRows
                            Dim sFacturaNo = row20.Cells(1).Value
                            Dim wFactura As tblFacturaTotal = DBModelo.GetFacturaHeader(sFacturaNo)
                            If Not IsNothing(wFactura) Then
                                wFactura.ComproPago = 1
                                wFactura.pdf = gv_CDFI_XML_PATH & folio_timbre & ".pdf"
                                If DBModelo.Update_PV_FacturaTotal(wFactura) Then
                                End If
                            End If
                        Next

                        lblPago.Text = ("Pago No.: P-" & folio)
                        ImprimePago(FolioPago, folio_timbre, True)
                        PrBImprimiendo.PerformStep()
                        PrBImprimiendo.Value = 0
                    End If
                End If

            Catch ex As Exception
                Cursor = Cursors.Default
                PrBImprimiendo.Value = 100
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Complemento de Pagos")
                PrBImprimiendo.Value = 0
            End Try
        Else
            MsgBox(("Complemento de Pago " & folio & " no pudo ser creado"), MsgBoxStyle.Critical, "Complemento de Pagos Cabecera")
        End If
    End Sub
End Class