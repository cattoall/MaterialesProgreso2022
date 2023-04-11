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
        If idClientePago <> "" Then
            GetInvoicesByClient()
        End If

    End Sub

    Private Sub GetInvoicesByClient()
        Try
            Dim tFacturaTotal As List(Of tblFacturaTotal) = DBModelo.GetFacturasHeaderByIdClienteFechaVenta(idClientePago, Format(dtFechaInicial.Value.Date, "yyyy-MM-dd"), Format(dtFechaFinal.Value.Date, "yyyy-MM-dd"))

            DataGridView1.Rows.Clear()

            If (tFacturaTotal.Count <= 0) Then
                MsgBox("No existen facturas para este cliente", MsgBoxStyle.Critical, "Complemento de Pagos")
            Else
                For Each fRow In tFacturaTotal
                    If IsDBNull(fRow.fecha_venta) Then
                        fRow.fecha_venta = CDate("")
                    End If
                    If IsDBNull(fRow.n_factura) Then
                        fRow.n_factura = CDec("")
                    End If
                    If IsDBNull(fRow.total) Then
                        fRow.total = CDec("")
                    End If
                    If IsDBNull(fRow.tipo_venta) Then
                        fRow.tipo_venta = ""
                    End If
                    If IsDBNull(fRow.cliente) Then
                        fRow.cliente = ""
                    End If
                    If IsDBNull(fRow.codiciones) Then
                        fRow.codiciones = ""
                    End If
                    If IsDBNull(fRow.metodopago) Then
                        fRow.metodopago = ""
                    End If
                    If IsDBNull(fRow.FormaPago) Then
                        fRow.FormaPago = ""
                    End If
                    If IsDBNull(fRow.UsoCFDI) Then
                        fRow.UsoCFDI = ""
                    End If
                    If IsDBNull(fRow.UUID) Then
                        fRow.UUID = ""
                    End If
                    If IsDBNull(fRow.Cancelada) Then
                        fRow.Cancelada = 0
                    End If
                    If IsDBNull(fRow.ComproPago) Then
                        fRow.ComproPago = 0
                    End If

                    Dim textArray1 As String() = New String(15 - 1) {}
                    textArray1(0) = CStr(fRow.fecha_venta)
                    textArray1(1) = CStr(fRow.n_factura)
                    textArray1(2) = FormatNumber(fRow.total, 2)
                    textArray1(3) = fRow.tipo_venta
                    textArray1(4) = fRow.cliente
                    textArray1(5) = fRow.codiciones
                    textArray1(6) = fRow.metodopago
                    textArray1(7) = fRow.FormaPago
                    textArray1(8) = fRow.UsoCFDI
                    textArray1(9) = fRow.UUID
                    Select Case fRow.Cancelada
                        Case 0
                            textArray1(10) = Boolean.FalseString
                        Case 1
                            textArray1(10) = Boolean.TrueString
                    End Select
                    Select Case fRow.ComproPago
                        Case 0
                            textArray1(11) = Boolean.FalseString
                        Case 1
                            textArray1(11) = Boolean.TrueString
                    End Select
                    textArray1(12) = FormatNumber(fRow.subtotal, 2)
                    textArray1(13) = FormatNumber(fRow.iva, 2)
                    textArray1(14) = fRow.ObjetoImp
                    Dim values As String() = textArray1
                    DataGridView1.Rows.Add(values)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, Nothing)
        End Try
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Try
            Dim tFacturaTotal As List(Of tblFacturaTotal) = DBModelo.GetFacturasHeaderByIdClienteFechaVenta(idClientePago, Format(dtFechaInicial.Value.Date, "yyyy-MM-dd"), Format(dtFechaFinal.Value.Date, "yyyy-MM-dd"))

            DataGridView1.Rows.Clear()

            If chkCancelados.Checked And chkPagados.Checked Then
                For Each line In tFacturaTotal
                    If CBool(line.Cancelada) = True Then
                        tFacturaTotal.Remove(line)
                    End If
                Next

                For Each line In tFacturaTotal
                    If CBool(line.ComproPago) = True Then
                        tFacturaTotal.Remove(line)
                    End If
                Next
            End If

            If chkCancelados.Checked And chkPagados.Checked = False Then
                For Each line In tFacturaTotal
                    If CBool(line.Cancelada) = True Then
                        tFacturaTotal.Remove(line)
                    End If
                Next
            End If

            If chkCancelados.Checked = False And chkPagados.Checked Then
                For Each line In tFacturaTotal
                    If CBool(line.ComproPago) = True Then
                        tFacturaTotal.Remove(line)
                    End If
                Next
            End If

            If (tFacturaTotal.Count <= 0) Then
                MsgBox("No existen facturas para este cliente", MsgBoxStyle.Critical, "Complemento de Pagos")
            Else
                For Each fRow In tFacturaTotal
                    If IsDBNull(fRow.fecha_venta) Then
                        fRow.fecha_venta = CDate("")
                    End If
                    If IsDBNull(fRow.n_factura) Then
                        fRow.n_factura = CDec("")
                    End If
                    If IsDBNull(fRow.total) Then
                        fRow.total = CDec("")
                    End If
                    If IsDBNull(fRow.tipo_venta) Then
                        fRow.tipo_venta = ""
                    End If
                    If IsDBNull(fRow.cliente) Then
                        fRow.cliente = ""
                    End If
                    If IsDBNull(fRow.codiciones) Then
                        fRow.codiciones = ""
                    End If
                    If IsDBNull(fRow.metodopago) Then
                        fRow.metodopago = ""
                    End If
                    If IsDBNull(fRow.FormaPago) Then
                        fRow.FormaPago = ""
                    End If
                    If IsDBNull(fRow.UsoCFDI) Then
                        fRow.UsoCFDI = ""
                    End If
                    If IsDBNull(fRow.UUID) Then
                        fRow.UUID = ""
                    End If
                    If IsDBNull(fRow.Cancelada) Then
                        fRow.Cancelada = 0
                    End If
                    If IsDBNull(fRow.ComproPago) Then
                        fRow.ComproPago = 0
                    End If

                    Dim textArray1 As String() = New String(15 - 1) {}
                    textArray1(0) = CStr(fRow.fecha_venta)
                    textArray1(1) = CStr(fRow.n_factura)
                    textArray1(2) = FormatNumber(fRow.total, 2)
                    textArray1(3) = fRow.tipo_venta
                    textArray1(4) = fRow.cliente
                    textArray1(5) = fRow.codiciones
                    textArray1(6) = fRow.metodopago
                    textArray1(7) = fRow.FormaPago
                    textArray1(8) = fRow.UsoCFDI
                    textArray1(9) = fRow.UUID
                    Select Case fRow.Cancelada
                        Case 0
                            textArray1(10) = Boolean.FalseString
                        Case 1
                            textArray1(10) = Boolean.TrueString
                    End Select
                    Select Case fRow.ComproPago
                        Case 0
                            textArray1(11) = Boolean.FalseString
                        Case 1
                            textArray1(11) = Boolean.TrueString
                    End Select
                    textArray1(12) = FormatNumber(fRow.subtotal, 2)
                    textArray1(13) = FormatNumber(fRow.iva, 2)
                    textArray1(14) = fRow.ObjetoImp
                    Dim values As String() = textArray1
                    DataGridView1.Rows.Add(values)
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
            wFolioFacturas = DBModelo.GetFolioFactura("PAGOS", CStr(Now.Date.Year))

            If IsNothing(wFolioFacturas) Then
                MsgBox("No hay Folios Disponibles para Pagos", MsgBoxStyle.Critical, "Verificación de Folios Disponibles")
            Else
                folio = CStr(wFolioFacturas.FolioActual)
                folio_inicial = CStr(wFolioFacturas.FolioInicial)
                folio_final = CStr(wFolioFacturas.FolioFinal)

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
        ElseIf CBool(DataGridView1(11, DataGridView1.CurrentRow.Index).Value) = True Then
            MsgBox("La factura aun tiene el status Pagada, favor de cancelar el pago y posteriormente la factura.", MsgBoxStyle.Information, "Complemento de Pagos")
        ElseIf CBool(DataGridView1(10, DataGridView1.CurrentRow.Index).Value) = True Then
            MsgBox("La factura ya se encuentra cancelada.", MsgBoxStyle.Information, "Complemento de Pagos")
        ElseIf (rowCount = 1) Then
            frmCancelacion.NoFactura = CStr(DataGridView1(1, DataGridView1.CurrentRow.Index).Value)
            frmCancelacion.UUID_Cancelar = CStr(DataGridView1(9, DataGridView1.CurrentRow.Index).Value)
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
        ElseIf CBool(DataGridView1(11, DataGridView1.CurrentRow.Index).Value) = False Then
            MsgBox("La factura aun no tiene Complemento de Pago generado.", MsgBoxStyle.Information, "Complemento de Pagos")
        ElseIf CBool(DataGridView1(10, DataGridView1.CurrentRow.Index).Value) = True Then
            MsgBox("La factura ya se encuentra cancelada.", MsgBoxStyle.Information, "Complemento de Pagos")
        ElseIf (rowCount = 1) Then
            frmCancelacion.NoFactura = CStr(DataGridView1(1, DataGridView1.CurrentRow.Index).Value)
            Dim tComplementoPagoD As List(Of TblComplementoPagosD) = DBModelo.GetComplementoPagoD_ByFactura(frmCancelacion.NoFactura)
            If (tComplementoPagoD.Count > 0) Then
                frmCancelacion.NoPago = CStr(tComplementoPagoD.Item(0).n_pago)
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
        Dim amount As Decimal
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            amount = amount + CDec(DataGridView1(2, row.Index).Value)
        Next
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
                If CBool(DataGridView1(10, DataGridView1.CurrentRow.Index).Value) = True Then
                    MsgBox("Existen Facturas seleccionadas con Status Cancelada. Favor de excluir Facturas Canceladas.", MsgBoxStyle.Information, "Complemento de Pago")
                ElseIf CBool(DataGridView1(11, DataGridView1.CurrentRow.Index).Value) = True Then
                    MsgBox("Existen Facturas seleccionadas con Status Pagadas. Favor de excluir Facturas Pagadas.", MsgBoxStyle.Information, "Complemento de Pago")
                ElseIf (MsgBox(("¿Generar Complemento de Pago por " & Format(amount, "$ ###,###,###.00") & " MXN con Fecha del Pago " & Format(dtpFechaPago.Value, "dd-MM-yyyy") & "?"), MsgBoxStyle.YesNo, "Complemento de Pago") = MsgBoxResult.Yes) Then
                    GenerarComplementoPago(CStr(amount))
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
        strComplementoPagoH.n_pago = CInt(folio)
        strComplementoPagoH.total = CDec(totalFacturas)
        strComplementoPagoH.cliente = txtNombre.Text
        strComplementoPagoH.id_cliente = CInt(LblCliente.Text)
        strComplementoPagoH.fecha_pago = CDate(Format(Now, "yyyy-MM-dd"))
        strComplementoPagoH.formapago = CmdFormaPago.Text.Substring(0, 2)
        strComplementoPagoH.UsoCFDI = "CP01"
        strComplementoPagoH.Cancelado = 0
        strComplementoPagoH.UUID = ""

        If DBModelo.InsertComplementoPagoH(strComplementoPagoH) Then
            For Each row20 As DataGridViewRow In DataGridView1.SelectedRows
                Dim sComplementoPagoD As TblComplementoPagosD = New TblComplementoPagosD
                sComplementoPagoD.IdComp = CompanyCode
                sComplementoPagoD.n_pago = CInt(folio)
                sComplementoPagoD.n_factura = CInt(row20.Cells(1).Value)
                sComplementoPagoD.UUID = CStr(row20.Cells(9).Value)
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
            sdk.Iniciales.Add("cfdi", (gv_CDFI_XML_PATH & folio_timbre & ".xml"))
            sdk.Iniciales.Add("xml_debug", (gv_CDFI_XML_PATH & "sin_" & folio_timbre & ".xml"))
            sdk.Iniciales.Add("validacion_local", "NO")

            sdk.AgregaObjeto(PAC)
            sdk.AgregaObjeto(Conf)

            Dim FacHeader As New MFObject("factura")
            FacHeader("serie") = "P"
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
            FacReceptor("RegimenFiscalReceptor") = txtRFR.Text
            FacReceptor("DomicilioFiscalReceptor") = txtCP.Text

            Dim FacConceptos As New MFObject("conceptos")
            Dim FacConcepto As New MFObject("0")
            FacConcepto("ClaveProdServ") = "84111506"
            FacConcepto("ClaveUnidad") = "ACT"
            FacConcepto("Cantidad") = "1"
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
            Dim dBaseTotal16 As Decimal = 0
            Dim dBaseTotal0 As Decimal = 0
            Dim FacDoctoRelacionados As New MFObject("DoctoRelacionado")
            Dim iIndex As Integer = 0
            For Each row20 As DataGridViewRow In DataGridView1.SelectedRows
                Dim FacDoctoRelacionado As New MFObject(CStr(iIndex))
                Dim sPagado As String = Trim(CStr(row20.Cells(2).Value)).Replace(",", "")
                Dim sObjImp As String = row20.Cells(14).Value.ToString
                Dim sIVA As String = Trim(FormatNumber(CDec(sPagado) - (CDec(sPagado) / CDec(FactorIVA)), 6)).Replace(",", "")
                Dim sBase As String = Trim(FormatNumber(CDec(sPagado) - CDec(sIVA), 6)).Replace(",", "")

                FacDoctoRelacionado("IdDocumento") = CStr(row20.Cells(9).Value)
                FacDoctoRelacionado("Serie") = "B"
                FacDoctoRelacionado("Folio") = CStr(row20.Cells(1).Value)
                FacDoctoRelacionado("MonedaDR") = "MXN"
                FacDoctoRelacionado("NumParcialidad") = "1"
                FacDoctoRelacionado("ImpSaldoAnt") = sPagado
                FacDoctoRelacionado("ImpPagado") = sPagado
                FacDoctoRelacionado("ImpSaldoInsoluto") = "0.00"
                FacDoctoRelacionado("EquivalenciaDR") = "1"
                FacDoctoRelacionado("ObjetoImpDR") = sObjImp

                If sObjImp = "02" Then
                    Dim ImpuestosDR As New MFObject("ImpuestosDR.TrasladoDR")
                    Dim TrasladoDR_0 As New MFObject("0")

                    If CDec(sIVA) > CDec("0.00") Then
                        TrasladoDR_0("BaseDR") = sBase
                        TrasladoDR_0("ImpuestoDR") = "002"
                        TrasladoDR_0("TipoFactorDR") = "Tasa"
                        TrasladoDR_0("TasaOCuotaDR") = FormatNumber(CDbl(FactorIVA) - 1, 6)
                        TrasladoDR_0("ImporteDR") = sIVA
                        dBaseTotal16 = dBaseTotal16 + CDec(sBase)
                        dIVATotal = dIVATotal + CDec(sIVA)
                    Else
                        TrasladoDR_0("BaseDR") = sBase
                        TrasladoDR_0("ImpuestoDR") = "002"
                        TrasladoDR_0("TipoFactorDR") = "Tasa"
                        TrasladoDR_0("TasaOCuotaDR") = "0.000000"
                        TrasladoDR_0("ImporteDR") = "0.00"
                        dBaseTotal0 = dBaseTotal0 + CDec(sBase)
                    End If


                    ImpuestosDR.AgregaSubnodo(TrasladoDR_0)
                    FacDoctoRelacionado.AgregaSubnodo(ImpuestosDR)
                End If

                FacDoctoRelacionados.AgregaSubnodo(FacDoctoRelacionado)
                iIndex = iIndex + 1
            Next

            Dim lv_item As Integer = 0
            If dBaseTotal16 > CDec("0.00") Then
                Dim ImpuestosP As New MFObject("ImpuestosP.TrasladosP")
                Dim TrasladosP_0 As New MFObject(lv_item.ToString)

                TrasladosP_0("BaseP") = Trim(FormatNumber(dBaseTotal16, 6)).Replace(",", "")
                TrasladosP_0("TipoFactorP") = "Tasa"
                TrasladosP_0("ImpuestoP") = "002"
                TrasladosP_0("TasaOCuotaP") = FormatNumber(CDbl(FactorIVA) - 1, 6)
                TrasladosP_0("ImporteP") = dIVATotal.ToString()
                ImpuestosP.AgregaSubnodo(TrasladosP_0)
                FacPago.AgregaSubnodo(ImpuestosP)
                lv_item = lv_item + 1
            End If

            If dBaseTotal0 > CDec("0.00") Then
                Dim ImpuestosP As New MFObject("ImpuestosP.TrasladosP")
                Dim TrasladosP_0 As New MFObject(lv_item.ToString)

                TrasladosP_0("BaseP") = Trim(FormatNumber(dBaseTotal0, 6)).Replace(",", "")
                TrasladosP_0("TipoFactorP") = "Tasa"
                TrasladosP_0("ImpuestoP") = "002"
                TrasladosP_0("TasaOCuotaP") = "0.000000"
                TrasladosP_0("ImporteP") = "0.00"
                ImpuestosP.AgregaSubnodo(TrasladosP_0)
                FacPago.AgregaSubnodo(ImpuestosP)
            End If

            FacPago.AgregaSubnodo(FacDoctoRelacionados)

            FacPagos.AgregaSubnodo(FacPago)
            FacPagos20.AgregaSubnodo(FacPagos)
            Dim pTotales As New MFObject("Totales")
            If dBaseTotal16 > CDec("0.00") Then
                pTotales("TotalTrasladosImpuestoIVA16") = Trim(FormatNumber(dIVATotal, 2)).Replace(",", "")
                pTotales("TotalTrasladosBaseIVA16") = Trim(FormatNumber(dBaseTotal16, 2)).Replace(",", "")
            End If
            If dBaseTotal0 > CDec("0.00") Then
                pTotales("TotalTrasladosImpuestoIVA0") = "0.00"
                pTotales("TotalTrasladosBaseIVA0") = Trim(FormatNumber(dBaseTotal0, 2)).Replace(",", "")
            End If
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

                If Not CInt(respuesta.Codigo_MF_Numero) = 0 Then
                    PrBImprimiendo.Value = 100
                    MsgBox($"Código: {respuesta.Codigo_MF_Numero} Mensaje: {respuesta.Codigo_MF_Texto}", MsgBoxStyle.Critical, "Complemento de Pagos")
                    PrBImprimiendo.Value = 0
                Else
                    MsgBox(("Complemento de Pago " & folio_timbre & " Generado Correctamente"), MsgBoxStyle.Information, "Complemento de Pagos")
                    folio = CStr(CInt(folio) + 1)
                    wFolioFacturas.FolioActual = CType(folio, Integer?)
                    If DBModelo.Update_PV_FoliosNC_Actual(wFolioFacturas) Then
                        For Each row20 As DataGridViewRow In DataGridView1.SelectedRows
                            Dim sFacturaNo = row20.Cells(1).Value
                            Dim wFactura As tblFacturaTotal = DBModelo.GetFacturaHeader(CStr(sFacturaNo))
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