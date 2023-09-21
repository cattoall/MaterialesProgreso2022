Imports FacturacionSDK
Imports Microsoft.VisualBasic.CompilerServices

Public Class FrmFacturacion
    Private lv_subtotal As String
    Private lv_IVA As String
    Private lv_nfactura As String
    Private folio_final As String
    Private folio_inicial As String
    Private lv_subtotal_ticket As Double
    Private lv_subtotal_ticket_no_tasa_cero As Double
    Private lv_iva_ticket As Double
    Private lv_total_ticket As Double
    Private sdk As MFSDK

    Private Sub limpiar()
        DataGridView1.Rows.Clear()
        DataGridView1.DataSource = Nothing
        TxtTikect.Focus()
        TxtTikect.Clear()
        TxtSubtotal.Text = "0.00"
        TxtIVA.Text = "0.00"
        TxtTotal.Text = "0.00"
        LblNRegistros.Text = Conversions.ToString(0)
        Dim i As Integer = (lv_ticket.Items.Count - 1)
        Do While (i >= 0)
            lv_ticket.Items.RemoveAt(i)
            i = (i + -1)
        Loop
        txtnombre.Clear()
        txtdirecion.Clear()
        txtcolonia.Clear()
        txtcp.Clear()
        txtestado.Clear()
        txtNumero.Clear()
        LblCliente.Text = ""
        TxtRFC.Clear()
        txtCiudad.Clear()
        txtEmail.Clear()
        txtRFR.Clear()
        CmbMetodoPago.SelectedIndex = -1
        lv_subtotal_ticket = 0
        lv_iva_ticket = 0
        lv_total_ticket = 0
        DateTimePicker1.Value = DateAndTime.Now.Date
        DateTimePicker2.Value = DateAndTime.Now.Date
        DateTimePicker3.Value = DateAndTime.Now.Date
        CbMostrador.Checked = False
        ChkTasaCero.Checked = False
        txtCuenta.Clear()
        CmdFormaPago.SelectedIndex = -1
        CmbBanco.SelectedIndex = -1
        CmbUsoCDFI.SelectedIndex = -1
        MetodoPago = ""
        FormaPago = ""
        UsoCDFI = ""
        ClaveUnidad = ""
    End Sub

    Private Sub TxtTikect_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtTikect.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            AgregarTicket_Click
            TxtTikect.Focus()
        End If
    End Sub

    Private Sub AgregarTicket_Click()
        lv_subtotal_ticket_no_tasa_cero = 0
        If IsNumeric(TxtTikect.Text) Then
            If TxtTikect.Text <> "" Then
                For i = 0 To lv_ticket.Items.Count - 1
                    If TxtTikect.Text = CStr(lv_ticket.Items(i)) Then
                        MsgBox(("Ticket " & TxtTikect.Text & " utilizado previamente."), MsgBoxStyle.Critical, "Validación de Tickets de Venta")
                        TxtTikect.Clear()
                        TxtTikect.Focus()
                        Exit Sub
                    Else
                        Dim wVenta As tblVenta = DBModelo.Get_PV_TicketHeader(CInt(TxtTikect.Text))
                        If Not wVenta Is Nothing Then
                            If wVenta.numeroFactura <> "" Then
                                MsgBox(("El Ticket " & Me.TxtTikect.Text & " ya está siento utilizado en una Factura."), MsgBoxStyle.Critical, "Validación de Tickets de Venta")
                                TxtTikect.Clear()
                                TxtTikect.Focus()
                                Exit Sub
                            End If
                        Else
                            MsgBox(("Ticket #: " & Me.TxtTikect.Text & " no existe en la base de datos"), MsgBoxStyle.ApplicationModal, Nothing)
                            TxtTikect.Clear()
                            TxtTikect.Focus()
                            Exit Sub
                        End If
                    End If
                Next
            Else
                MsgBox("Introduce Ticket de Venta Válido", MsgBoxStyle.Critical, "Validación de Tickets de Venta")
                TxtTikect.Focus()
                Exit Sub
            End If
        Else
            MsgBox("Introduce Ticket de Venta Válido", MsgBoxStyle.Critical, "Validación de Tickets de Venta")
            TxtTikect.Clear()
            TxtTikect.Focus()
            Exit Sub
        End If

        Dim d_subtotal_tmp As Decimal = CDec(TxtSubtotal.Text)
        Dim d_iva_tmp As Decimal = CDec(TxtIVA.Text)
        Dim d_total_tmp As Decimal = 0
        Dim tTicket As List(Of tblTicket) = DBModelo.Get_PV_TicketsDetalle(CInt(TxtTikect.Text))
        If tTicket.Count > 0 Then
            For Each wTicket In tTicket
                If wTicket.ClaveProducto.Equals("") Then
                    MsgBox("Falta definir ClaveProducto al Producto " & wTicket.clave_producto & " - " & wTicket.concepto, MsgBoxStyle.Critical, "Validación de Tickets de Venta")
                    Exit Sub
                End If
                If wTicket.ClaveUnidad.Equals("") Then
                    MsgBox("Falta definir ClaveUnidad al Producto " & wTicket.clave_producto & " - " & wTicket.concepto, MsgBoxStyle.Critical, "Validación de Tickets de Venta")
                    Exit Sub
                End If

                Dim row As String() = New String(15 - 1) {}
                row(0) = wTicket.folio
                row(1) = CStr(wTicket.cantidad)
                row(2) = wTicket.concepto
                row(3) = CStr(wTicket.precio)
                row(4) = CStr(Math.Round(CDec(wTicket.subtotal), 2))
                row(5) = CStr(wTicket.fecha)
                row(6) = CStr(wTicket.precioCosto)
                row(7) = CStr(wTicket.subtotalCosto)
                row(8) = wTicket.clave_producto
                row(9) = TxtFolio.Text
                row(10) = CStr(wTicket.IdProducto)
                row(11) = wTicket.ClaveProducto
                row(12) = wTicket.ClaveUnidad
                If wTicket.TasaCero = False Then
                    row(13) = "0"
                    row(14) = CStr(Math.Round(CDbl(((wTicket.subtotal * CDbl(FactorIVA)) - wTicket.subtotal)), 6))
                Else
                    row(13) = "1"
                    row(14) = CStr(wTicket.subtotal)
                End If
                Dim rowValues As String() = row
                DataGridView1.Rows.Add(rowValues)

                d_subtotal_tmp = d_subtotal_tmp + Math.Round(CDec(wTicket.subtotal), 2)
                If wTicket.TasaCero = False Then
                    d_iva_tmp = d_iva_tmp + Math.Round(CDec((wTicket.subtotal * CDbl(FactorIVA)) - wTicket.subtotal), 2)
                    d_total_tmp = d_subtotal_tmp + d_iva_tmp
                Else
                    d_iva_tmp = CDec("0.00")
                    d_total_tmp = d_subtotal_tmp
                End If
            Next

            TxtSubtotal.Text = CStr(d_subtotal_tmp)
            TxtIVA.Text = CStr(d_iva_tmp)
            TxtTotal.Text = CStr(d_total_tmp)
            LblNRegistros.Text = CStr(DataGridView1.Rows.Count)
            lv_ticket.Items.Add(TxtTikect.Text)
            TxtTikect.Clear()
            TxtTikect.Focus()
        Else
            MsgBox(("Ticket #: " & TxtTikect.Text & " no tiene detalle"), MsgBoxStyle.ApplicationModal, Nothing)
            TxtTikect.Clear()
            TxtTikect.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub CbMostrador_CheckStateChanged(sender As Object, e As EventArgs) Handles CbMostrador.CheckStateChanged
        If CbMostrador.CheckState <> CheckState.Checked Then
            GbTicket.Enabled = True
            DataGridView1.Rows.Clear()
            DataGridView1.DataSource = Nothing
            TxtTikect.Focus()
            TxtTikect.Text = ""
            TxtSubtotal.Text = CStr(CDbl(0))
            TxtIVA.Text = CStr(CDbl(0))
            TxtTotal.Text = CStr(CDbl(0))

            If lv_ticket.Items.Count > 0 Then
                For i = lv_ticket.Items.Count - 1 To 0
                    lv_ticket.Items.RemoveAt(i)
                    i = i - 1
                Next
            End If

            btnGenerarMostrador.Enabled = False
            DateTimePicker3.Enabled = False
            DateTimePicker3.Value = DateAndTime.Now
            CmbMetodoPago.SelectedIndex = -1
            CmdFormaPago.SelectedIndex = -1
            CmbCredito.SelectedIndex = -1
            CmbUsoCDFI.SelectedIndex = -1
        Else
            GbTicket.Enabled = False
            DataGridView1.Rows.Clear()
            DataGridView1.DataSource = Nothing
            TxtSubtotal.Text = CStr(CDbl(0))
            TxtIVA.Text = CStr(CDbl(0))
            CmbMetodoPago.SelectedIndex = 0
            TxtTotal.Text = CStr(CDbl(0))

            btnGenerarMostrador.Enabled = True
            DateTimePicker3.Enabled = True
            Dim wCliente As tblClientes = DBModelo.GetClienteByName("PUBLICO EN GENERAL")
            If Not wCliente Is Nothing Then
                txtnombre.Text = wCliente.nombre.ToUpper
                LblCliente.Text = CStr(wCliente.clave)
                txtEmail.Text = wCliente.correo.ToUpper
                txtdirecion.Text = wCliente.calle
                txtNumero.Text = wCliente.numero
                txtCiudad.Text = wCliente.ciudad
                txtestado.Text = wCliente.estado
                txtcolonia.Text = wCliente.colonia
                txtcp.Text = wCliente.cp
                TxtRFC.Text = wCliente.rfc
                txtRFR.Text = wCliente.RegimenFiscal
                CmbMetodoPago.SelectedIndex = 0
                CmdFormaPago.SelectedIndex = 0
                CmbCredito.SelectedIndex = 4
                CmbUsoCDFI.SelectedIndex = 23
                DateTimePicker3.Focus()
            End If
        End If
    End Sub

    Private Sub CmbMetodoPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMetodoPago.SelectedIndexChanged
        If CmbMetodoPago.Text.Contains("PPD") Then
            CmdFormaPago.SelectedIndex = CmdFormaPago.FindString("99")
        ElseIf CmbMetodoPago.Text.Contains("PUE") Then
            CmdFormaPago.SelectedIndex = 0
        Else
            CmdFormaPago.SelectedIndex = -1
        End If
    End Sub

    Private Sub CmbCredito_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCredito.SelectedIndexChanged
        If CmbCredito.Text = "8 DIAS DE CREDITO" Then
            DateTimePicker2.Value = DateTime.Now.AddDays(8)
        End If
        If CmbCredito.Text = "15 DIAS DE CREDITO" Then
            DateTimePicker2.Value = DateTime.Now.AddDays(15)
        End If
        If CmbCredito.Text = "21 DIAS DE CREDITO" Then
            DateTimePicker2.Value = DateTime.Now.AddDays(21)
        End If
        If CmbCredito.Text = "30 DIAS DE CREDITO" Then
            DateTimePicker2.Value = DateTime.Now.AddDays(30)
        End If
        If CmbCredito.Text = "PAGO A LA ENTREGA" Then
            DateTimePicker2.Value = DateTime.Now.AddDays(0)
        End If
    End Sub

    Public Function PAC() As MFObject
        Dim oPAC As New MFObject("PAC")
        oPAC("usuario") = gv_cfdi_usuario
        oPAC("pass") = gv_cfdi_password
        oPAC("produccion") = gv_cfdi_prd
        Return oPAC
    End Function

    Public Function PAC2() As MFObject
        Dim oPAC As New MFObject("PAC")
        oPAC("usuario") = gv_cfdi_usuario
        oPAC("pass") = gv_cfdi_password
        Return oPAC
    End Function

    Public Function Conf() As MFObject
        Dim oCONF As New MFObject("conf")
        oCONF("cer") = gv_sat_cer
        oCONF("key") = gv_sat_key
        oCONF("pass") = gv_sat_pass
        Return oCONF
    End Function

    Private Sub FrmFacturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim wFolioFacturas As tblFolioFacturas = DBModelo.GetFolioFactura("FACTURAS", CStr(Now.Year))
        If Not wFolioFacturas Is Nothing Then
            TxtFolio.Text = CStr(wFolioFacturas.FolioActual)
            folio_inicial = CStr(wFolioFacturas.FolioInicial)
            folio_final = CStr(wFolioFacturas.FolioFinal)
        Else
            Dim wFolioFacturas1 As tblFolioFacturas = New tblFolioFacturas()
            Dim wFolioFacturas2 As tblFolioFacturas = DBModelo.GetFolioFactura("FACTURAS", CStr(Now.Year - 1))
            wFolioFacturas1.IdComp = CompanyCode
            wFolioFacturas1.TipoComprobante = "FACTURAS"
            wFolioFacturas1.Year = Now.Year
            wFolioFacturas1.FolioInicial = wFolioFacturas2.FolioActual
            wFolioFacturas1.FolioFinal = wFolioFacturas2.FolioFinal
            wFolioFacturas1.FolioActual = wFolioFacturas2.FolioActual
            If DBModelo.Insert_PV_FoliosNC_Actual(wFolioFacturas1) = False Then
                MsgBox("Error al insertar registro en tabla FolioFactura", MsgBoxStyle.Critical, "Facturación")
                Exit Sub
            End If
            TxtFolio.Text = CStr(wFolioFacturas1.FolioActual)
            folio_inicial = CStr(wFolioFacturas1.FolioInicial)
            folio_final = CStr(wFolioFacturas1.FolioFinal)
        End If

        CmbCredito.Visible = True
        LblPlazo.Visible = True
        btnGenerarMostrador.Enabled = False
        DateTimePicker3.Enabled = False

        Llena_FormaDePago()
        Llena_MetodoDePago()
        Llena_UsoCFDI()
    End Sub

    Private Sub Llena_UsoCFDI()
        Dim UsoCFDI As List(Of tblUsoDeCFDI) = DBModelo.GetUsoCFDI_All

        If IsNothing(UsoCFDI) Then
            Exit Sub
        End If

        CmbUsoCDFI.DataSource = UsoCFDI
        CmbUsoCDFI.DisplayMember = "UsoCFDI"
        CmbUsoCDFI.ValueMember = "Id"
        CmbUsoCDFI.SelectedIndex = -1

    End Sub

    Private Sub Llena_MetodoDePago()
        Dim MetodoDePago As List(Of tblMetodoPago) = DBModelo.GetMetodoDePago_All

        If IsNothing(MetodoDePago) Then
            Exit Sub
        End If

        CmbMetodoPago.DataSource = MetodoDePago
        CmbMetodoPago.DisplayMember = "MetodoPago"
        CmbMetodoPago.ValueMember = "Id"
        CmbMetodoPago.SelectedIndex = -1
    End Sub

    Private Sub Llena_FormaDePago()
        Dim FormaDePago As List(Of tblFormaDePago) = DBModelo.GetFormaDePago_All

        If IsNothing(FormaDePago) Then
            Exit Sub
        End If

        CmdFormaPago.DataSource = FormaDePago
        CmdFormaPago.DisplayMember = "FormaPago"
        CmdFormaPago.ValueMember = "Id"
        CmdFormaPago.SelectedIndex = -1
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Buscar_Clientes = "FACTURAS"
        FrmBuscarClientesVentas.ShowDialog()
        FrmBuscarClientesVentas.Close()
        FrmBuscarClientesVentas.Dispose()
        TxtTikect.Select()
        LblCliente.Text = idClienteVenta
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub UpdateVentas()
        Dim tVentas As List(Of tblVenta) = DBModelo.GetVentasMostrador(Format(Me.DateTimePicker3.Value.Date, "yyyy-MM-dd"), 0, "", "VENDIDO")
        For Each wVentas In tVentas
            wVentas.SubTotal = wVentas.total / CDec(1.16)
            wVentas.IVA = wVentas.total - wVentas.SubTotal
            DBModelo.Update_PV_Venta(wVentas)
        Next
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnGenerarMostrador.Click
        If CbMostrador.Enabled Then
            UpdateVentas()
            Dim tVentas As List(Of tblVenta) = DBModelo.GetVentasMostrador(Format(Me.DateTimePicker3.Value.Date, "yyyy-MM-dd"), 0, "", "VENDIDO")
            DataGridView1.Rows.Clear()
            DataGridView1.Refresh()
            DataGridView1.DataSource = Nothing
            TxtSubtotal.Text = "0.00"
            TxtIVA.Text = "0.00"
            TxtTotal.Text = "0.00"
            Dim dSubTotal As Decimal = CDec("0.00")
            Dim dIVA As Decimal = CDec("0.00")
            Dim dTotal As Decimal = CDec("0.00")

            If tVentas.Count > 0 Then
                For Each wVentas In tVentas
                    Dim row As String() = New String(15 - 1) {}
                    row(0) = CStr(wVentas.nticket)
                    row(1) = "1"
                    row(2) = "TICKET DE VENTA: " & wVentas.nticket
                    row(3) = CStr(Math.Round(CDec(wVentas.SubTotal), 2))
                    row(4) = CStr(Math.Round(CDec(wVentas.SubTotal), 2))
                    row(5) = Format(DateTimePicker1.Value, "yyyy-MM-dd")
                    row(6) = "0.00"
                    row(7) = "0.00"
                    row(8) = "DIA"
                    row(9) = TxtFolio.Text
                    row(10) = "0"
                    row(11) = "01010101"
                    row(12) = "ACT"
                    If wVentas.IVA > 0.00 Then
                        row(13) = "0"
                    Else
                        row(13) = "1"
                    End If
                    row(14) = CStr(wVentas.IVA)
                    Dim rowValues As String() = row
                    DataGridView1.Rows.Add(rowValues)
                    dSubTotal = dSubTotal + Math.Round(CDec(wVentas.SubTotal), 2)
                    dIVA = dIVA + Math.Round(CDec(wVentas.IVA), 2)
                    dTotal = dTotal + Math.Round(CDec(wVentas.total), 2)
                Next
                TxtSubtotal.Text = dSubTotal.ToString
                TxtIVA.Text = dIVA.ToString
                TxtTotal.Text = dTotal.ToString
            Else
                MsgBox("No hay ventas registradas o pendientes por facturar para este día.", MsgBoxStyle.Critical, "Ventas de Mostrador")
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PrBImprimiendo.Visible = True
        PrBImprimiendo.Value = 0
        PrBImprimiendo.Step = 10
        If txtnombre.Text = "" Then
            MsgBox("Favor de especificar un Cliente.", MsgBoxStyle.Critical, Nothing)
            btnAdd.Focus()
        ElseIf txtdirecion.Text = "" Then
            MsgBox("Favor de especificar el Domicilio.", MsgBoxStyle.Critical, Nothing)
            btnAdd.Focus()
        ElseIf txtCiudad.Text = "" Then
            MsgBox("Favor de especificar la Ciudad.", MsgBoxStyle.Critical, Nothing)
            btnAdd.Focus()
        ElseIf txtestado.Text = "" Then
            MsgBox("Favor de especificar el Estado.", MsgBoxStyle.Critical, Nothing)
            btnAdd.Focus()
        ElseIf txtcolonia.Text = "" Then
            MsgBox("Favor de especificar la Colonia.", MsgBoxStyle.Critical, Nothing)
            btnAdd.Focus()
        ElseIf txtcp.Text = "" Then
            MsgBox("Favor de especificar el Código Postal.", MsgBoxStyle.Critical, Nothing)
            btnAdd.Focus()
        ElseIf TxtRFC.Text = "" Then
            MsgBox("Favor de especificar el RFC.", MsgBoxStyle.Critical, Nothing)
            btnAdd.Focus()
        ElseIf txtRFR.Text = "" Then
            MsgBox("Favor de especificar el Régimen Fiscal.", MsgBoxStyle.Critical, Nothing)
            btnAdd.Focus()
        ElseIf CmbMetodoPago.Text = "" Then
            MsgBox("Favor de especificar el Tipo de Pago", MsgBoxStyle.Critical, Nothing)
            CmbMetodoPago.Focus()
        ElseIf CmdFormaPago.Text = "" Then
            MsgBox("Favor de especificar el Método de Pago", MsgBoxStyle.Critical, Nothing)
            CmdFormaPago.Focus()
        ElseIf CmbUsoCDFI.Text = "" Then
            MsgBox("Favor de especificar el Uso del CFDI", MsgBoxStyle.Critical, Nothing)
            CmbUsoCDFI.Focus()
        ElseIf CmbCredito.Text = "" Then
            MsgBox("Favor de especificar el Plazo", MsgBoxStyle.Critical, Nothing)
            CmbCredito.Focus()
        ElseIf DataGridView1.RowCount = 0 Then
            MsgBox("No existen productos a Facturar", MsgBoxStyle.Critical, Nothing)
        Else
            Dim NoFactura As String = TxtFolio.Text
            Dim FolioFactura As String = gv_SerieFacturaSalvador & "-" & TxtFolio.Text & "_" & Format(DateTimePicker1.Value.Date, "yyyyMMdd") & "_CFDI"
            Dim SubTotalFactura As String = TxtSubtotal.Text
            PrBImprimiendo.Value = 10

            Dim wFacturaTotal As tblFacturaTotal = New tblFacturaTotal

            wFacturaTotal.IdComp = CompanyCode
            wFacturaTotal.n_factura = Decimal.Parse(NoFactura)
            wFacturaTotal.subtotal = Decimal.Parse(TxtSubtotal.Text)
            wFacturaTotal.iva = Decimal.Parse(TxtIVA.Text)
            wFacturaTotal.total = Decimal.Parse(TxtTotal.Text)
            wFacturaTotal.usuario = usuario
            If CmbMetodoPago.Text.Substring(0, 3) = "PUE" Then
                wFacturaTotal.codiciones = "PAGO DE CONTADO"
                wFacturaTotal.tipo_venta = "CONTADO"
            ElseIf CmbMetodoPago.Text.Substring(0, 3) = "PPD" Then
                wFacturaTotal.codiciones = CmbCredito.SelectedText.ToString
                wFacturaTotal.tipo_venta = "CREDITO"
            End If
            wFacturaTotal.cliente = txtnombre.Text
            wFacturaTotal.id_cliente = LblCliente.Text
            wFacturaTotal.fecha_venta = CDate(Format(DateTimePicker1.Value.Date, "yyyy-MM-dd"))
            wFacturaTotal.fecha_limite = CDate(Format(DateTimePicker2.Value.Date, "yyyy-MM-dd"))
            wFacturaTotal.estado = "VENDIDO"
            wFacturaTotal.observaciones = ""
            If CbMostrador.CheckState = CheckState.Checked Then
                wFacturaTotal.facturaDia = 1
            Else
                wFacturaTotal.facturaDia = 0
            End If
            wFacturaTotal.metodopago = CmbMetodoPago.Text.Substring(0, 3)
            wFacturaTotal.nc = ""
            wFacturaTotal.cuenta = txtCuenta.Text
            wFacturaTotal.banco = CmbBanco.Text
            wFacturaTotal.FormaPago = CmdFormaPago.Text.Substring(0, 2)
            wFacturaTotal.UsoCFDI = CmbUsoCDFI.Text.Substring(0, 3)
            wFacturaTotal.UUID = ""
            wFacturaTotal.Cancelada = 0
            wFacturaTotal.ComproPago = 0
            wFacturaTotal.pdf = ""
            wFacturaTotal.ObjetoImp = "02"

            If DBModelo.InsertFacturaTotal(wFacturaTotal) Then
                For i = 0 To DataGridView1.RowCount - 1
                    Dim wFactura As tblFactura = New tblFactura
                    wFactura.IdComp = CompanyCode
                    wFactura.n_factura = CLng(NoFactura)
                    wFactura.folio = DataGridView1.Rows(i).Cells(0).Value.ToString
                    wFactura.idProducto = CInt(DataGridView1.Rows(i).Cells(10).Value)
                    wFactura.clave_p = DataGridView1.Rows(i).Cells(8).Value.ToString
                    wFactura.descripcion = DataGridView1.Rows(i).Cells(2).Value.ToString
                    wFactura.cantidad = CDec(DataGridView1.Rows(i).Cells(1).Value)
                    wFactura.fecha = CDate(DataGridView1.Rows(i).Cells(5).Value)
                    wFactura.subtotal = Math.Round(CDec(DataGridView1.Rows(i).Cells(4).Value), 2)
                    wFactura.IVA = Math.Round(CDec(DataGridView1.Rows(i).Cells(14).Value), 2)
                    wFactura.precio = Math.Round(CDec(DataGridView1.Rows(i).Cells(3).Value), 2)
                    wFactura.ClaveProducto = DataGridView1.Rows(i).Cells(11).Value.ToString
                    wFactura.ClaveUnidad = DataGridView1.Rows(i).Cells(12).Value.ToString
                    If DBModelo.InsertFactura(wFactura) = False Then
                        MsgBox("Error al insertar registro en tabla Facturas (Detalle) - " & wFactura.clave_p & " - " & wFactura.descripcion, MsgBoxStyle.Critical, "Facturación")
                        Exit Sub
                    End If
                Next

                Dim wFolioFacturas As tblFolioFacturas = DBModelo.GetFolioFactura("FACTURAS", CStr(Now.Year))
                If Not wFolioFacturas Is Nothing Then
                    wFolioFacturas.IdComp = CompanyCode
                    wFolioFacturas.FolioActual = wFolioFacturas.FolioActual + 1
                    If DBModelo.UpdateFolioFacturas(wFolioFacturas) = False Then
                        MsgBox("Error al actualizar Folio Factura en tabla FolioFacturas", MsgBoxStyle.Critical, "Facturación")
                        Exit Sub
                    End If
                    TxtFolio.Text = CStr(wFolioFacturas.FolioActual)
                End If

                'Generación del archivo para envío electrónico al SAT
                sdk = New MFSDK
                sdk.Iniciales.Add("version_cfdi", "4.0")
                sdk.Iniciales.Add("MODOINI", "DIVISOR")
                sdk.Iniciales.Add("cfdi", (gv_CDFI_XML_PATH & FolioFactura & ".xml"))
                sdk.Iniciales.Add("xml_debug", (gv_CDFI_XML_PATH & "sin_" & FolioFactura & ".xml"))
                sdk.Iniciales.Add("remueve_acentos", "NO")
                sdk.Iniciales.Add("RESPUESTA_UTF8", "SI")
                sdk.Iniciales.Add("html_a_txt", "NO")

                sdk.AgregaObjeto(PAC)
                sdk.AgregaObjeto(Conf)

                Dim factura As New MFObject("factura")
                Dim subtotal As String = Trim(Trim(TxtSubtotal.Text.Replace("$", "")).Replace(",", ""))
                Dim total As String = Trim(Trim(TxtTotal.Text.Replace("$", "")).Replace(",", ""))

                factura("serie") = gv_SerieFacturaSalvador
                factura("folio") = NoFactura
                factura("fecha_expedicion") = Now.ToString("s")
                MetodoPago = CmbMetodoPago.Text
                factura("metodo_pago") = MetodoPago.Substring(0, 3)
                FormaPago = CmdFormaPago.Text
                factura("forma_pago") = FormaPago.Substring(0, 2)
                factura("condicionesDePago") = CmbCredito.Text
                factura("tipocomprobante") = "I"
                factura("moneda") = "MXN"
                factura("tipocambio") = "1"
                factura("LugarExpedicion") = LugarExpedicion
                factura("subtotal") = Trim(CStr(Math.Round(CDec(subtotal), 2)))
                factura("total") = Trim(CStr(Math.Round(CDec(total), 2)))
                factura("Exportacion") = "01"

                Dim emisor As New MFObject("emisor")
                emisor("rfc") = Trim(RFC.Replace("-", ""))
                emisor("nombre") = Propietario
                emisor("RegimenFiscal") = RegimenFiscal
                sdk.AgregaObjeto(emisor)

                Dim receptor As New MFObject("receptor")
                receptor("rfc") = TxtRFC.Text
                receptor("nombre") = txtnombre.Text
                If (UsoCDFI <> "") Then
                    receptor("UsoCFDI") = UsoCDFI
                Else
                    UsoCDFI = CmbUsoCDFI.Text
                    receptor("UsoCFDI") = UsoCDFI.Substring(0, 3)
                End If
                receptor("DomicilioFiscalReceptor") = txtcp.Text
                receptor("RegimenFiscalReceptor") = txtRFR.Text
                sdk.AgregaObjeto(receptor)

                Dim baseTotal16 As Decimal = 0
                Dim baseTotal0 As Decimal = 0
                Dim vImporteTotalIVA As Decimal = 0
                Dim oConceptos As New MFObject("conceptos")
                For i = 0 To DataGridView1.RowCount - 1
                    Dim vImporte As String = Trim(Trim(CStr(DataGridView1(4, i).Value)).Replace("$", "")).Replace(",", "")
                    Dim vValorUnitario As String = Trim(Trim(CStr(DataGridView1(3, i).Value)).Replace("$", "")).Replace(",", "")

                    Dim oLinea As New MFObject(i.ToString)
                    oLinea("ClaveProdServ") = DataGridView1(11, i).Value.ToString
                    oLinea("NoIdentificacion") = DataGridView1(10, i).Value.ToString
                    oLinea("Cantidad") = DataGridView1(1, i).Value.ToString
                    oLinea("ClaveUnidad") = DataGridView1(12, i).Value.ToString
                    oLinea("Descripcion") = DataGridView1(2, i).Value.ToString
                    oLinea("ValorUnitario") = vValorUnitario
                    oLinea("Importe") = Trim(CStr(Math.Round(CDec(vImporte), 2)))
                    oLinea("ObjetoImp") = "02"

                    If oLinea("ObjetoImp") = "02" Then
                        Dim oImpuestos As New MFObject("Impuestos")
                        Dim oTraslado As New MFObject("Traslados")
                        Dim oTraslados As New MFObject(i.ToString)
                        Dim vImporteTras As String = DataGridView1(14, i).Value.ToString
                        oTraslados("Base") = Trim(CStr(Math.Round(CDec(vImporte), 2)))
                        oTraslados("Impuesto") = "002"
                        If CBool(DataGridView1(13, i).Value) = False Then
                            baseTotal16 = baseTotal16 + Math.Round(CDec(vImporte), 2)
                            oTraslados("Importe") = Trim(CStr(Math.Round(CDec(vImporteTras), 2)))
                            oTraslados("TasaOCuota") = FormatNumber(CDbl(FactorIVA) - 1, 6)
                            vImporteTotalIVA = vImporteTotalIVA + Math.Round(CDec(vImporteTras), 2)
                        Else
                            baseTotal0 = baseTotal0 + Math.Round(CDec(vImporte), 2)
                            oTraslados("Importe") = "0.00"
                            oTraslados("TasaOCuota") = "0.000000"
                        End If
                        oTraslados("TipoFactor") = "Tasa"
                        oTraslado.AgregaSubnodo(oTraslados)
                        oImpuestos.AgregaSubnodo(oTraslado)
                        oLinea.AgregaSubnodo(oImpuestos)
                    End If
                    oConceptos.AgregaSubnodo(oLinea)
                Next
                sdk.AgregaObjeto(factura)

                If txtnombre.Text.Trim = "PUBLICO EN GENERAL" Then
                    Dim InformacionGlobal As New MFObject("InformacionGlobal")
                    InformacionGlobal("Periodicidad") = "01"
                    InformacionGlobal("Meses") = Format(DateTimePicker3.Value, "MM")
                    InformacionGlobal("Año") = Format(DateTimePicker3.Value, "yyyy")
                    sdk.AgregaObjeto(InformacionGlobal)
                End If

                sdk.AgregaObjeto(oConceptos)

                Dim oImpuestosTotales As New MFObject("impuestos")
                Dim lvItem As Integer = 0
                Dim itras As New MFObject("translados")

                oImpuestosTotales("TotalImpuestosTrasladados") = Trim(CStr(vImporteTotalIVA))
                If baseTotal0 > 0.00 Then
                    Dim itra0 As New MFObject(lvItem.ToString)
                    Dim basetotal0s As String = Trim(CStr(baseTotal0))
                    itra0("Base") = basetotal0s
                    itra0("Impuesto") = "002"
                    itra0("Importe") = "0.00"
                    itra0("TasaOCuota") = "0.000000"
                    itra0("TipoFactor") = "Tasa"
                    itras.AgregaSubnodo(itra0)
                    lvItem = lvItem + 1
                End If

                If baseTotal16 > 0.00 Then
                    Dim itra0 As New MFObject(lvItem.ToString)
                    Dim vImporteTotalIVAFormat As String = Trim(CStr(vImporteTotalIVA))
                    Dim baseTotal16s As String = Trim(CStr(baseTotal16))
                    itra0("Base") = baseTotal16s
                    itra0("Impuesto") = "002"
                    itra0("Importe") = vImporteTotalIVAFormat
                    itra0("TasaOCuota") = "0.160000"
                    itra0("TipoFactor") = "Tasa"
                    itras.AgregaSubnodo(itra0)
                End If
                oImpuestosTotales.AgregaSubnodo(itras)

                sdk.AgregaObjeto(oImpuestosTotales)

                'Timbra Factura
                Dim view As MetroFramework.Controls.MetroGrid
                Dim respuesta As SDKRespuesta = sdk.Timbrar("C:\sdk2\timbrar32.bat", gv_CDFI_XML_PATH, FolioFactura, False)
                If CInt(respuesta.Codigo_MF_Numero) = 0 Then
                    PrBImprimiendo.PerformStep()
                    MsgBox(("Factura " & gv_SerieFacturaSalvador & "-" & NoFactura & " Generada Correctamente"), MsgBoxStyle.Information, "Generació de Facturas")
                    ImprimeFactura2(NoFactura, FolioFactura, True)
                    For i = 0 To DataGridView1.RowCount - 1
                        Dim wVenta As tblVenta = DBModelo.Get_PV_TicketHeader(CInt(DataGridView1.Rows(i).Cells(0).Value))
                        wVenta.numeroFactura = NoFactura
                        If DBModelo.Update_PV_Venta(wVenta) = False Then
                            MsgBox(("Ticket " & DataGridView1.Rows(i).Cells(0).Value.ToString & " no pudo ser actualizado con el número de factura: " & NoFactura), MsgBoxStyle.Information, "Generació de Facturas")
                        End If
                    Next
                Else
                    PrBImprimiendo.Value = 100
                    MsgBox($"Código: {respuesta.Codigo_MF_Numero} Mensaje: {respuesta.Codigo_MF_Texto} Mensaje2: {respuesta.MensajeOriginalPacJSON}", MsgBoxStyle.Critical, Nothing)
                    view = DataGridView1
                    DataGridView1 = view

                    RollBackWork(NoFactura)
                End If
                PrBImprimiendo.Visible = False
                limpiar()
            Else
                MsgBox("Error al insertar registro en tabla Factura_Total (Cabecera)", MsgBoxStyle.Critical, "Facturación")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub RollBackWork(ByVal nFactura As String)
        Dim sFacErrorDet As String = ""
        Dim wFacturaTotal As tblFacturaTotal = DBModelo.GetFacturaHeader(nFactura)
        If Not IsNothing(wFacturaTotal) Then
            If DBModelo.DeleteFacturaTotal(wFacturaTotal) Then
                Dim tFacturasDet As List(Of tblFactura) = DBModelo.GetFacturaByN(nFactura)
                If tFacturasDet.Count > 0 Then
                    For Each rowDet As tblFactura In tFacturasDet
                        If DBModelo.DeleteFactura(rowDet) = False Then
                            sFacErrorDet = "X"
                        End If
                    Next
                End If
                If sFacErrorDet = "" Then
                    Dim wFolioFacturas As tblFolioFacturas = DBModelo.GetFolioFactura("FACTURAS", CStr(Now.Year))
                    If Not wFolioFacturas Is Nothing Then
                        wFolioFacturas.IdComp = CompanyCode
                        wFolioFacturas.FolioActual = wFolioFacturas.FolioActual - 1
                        If DBModelo.UpdateFolioFacturas(wFolioFacturas) Then
                            TxtFolio.Text = CStr(wFolioFacturas.FolioActual)
                        Else
                            MsgBox("Error al actualizar Folio Factura en tabla FolioFacturas", MsgBoxStyle.Critical, "RollBack Facturación")
                            Exit Sub
                        End If
                    End If
                Else
                    MsgBox("Error al eliminar detalle de Factura", MsgBoxStyle.Critical, "RollBack Facturación")
                End If
            Else
                MsgBox("Error al eliminar cabecera de Factura", MsgBoxStyle.Critical, "RollBack Facturación")
            End If
        End If

        For i = 0 To DataGridView1.RowCount - 1
            Dim wVenta As tblVenta = DBModelo.Get_PV_TicketHeader(CInt(DataGridView1.Rows(i).Cells(0).Value))
            wVenta.numeroFactura = ""
            If DBModelo.Update_PV_Venta(wVenta) = False Then
                MsgBox(("Ticket " & DataGridView1.Rows(i).Cells(0).Value.ToString & " no pudo ser actualizado."), MsgBoxStyle.Information, "RollBack Facturación")
            End If
        Next
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()
    End Sub

    Private Sub lv_ticket_DoubleClick(sender As Object, e As EventArgs) Handles lv_ticket.DoubleClick
        Dim lvTicket As String = lv_ticket.Items(lv_ticket.SelectedIndex).ToString
        lv_ticket.Items.RemoveAt(lv_ticket.SelectedIndex)

        TxtSubtotal.Text = "0.00"
        TxtIVA.Text = "0.00"
        TxtTotal.Text = "0.00"
        DataGridView1.Refresh()
        DataGridView1.Rows.Clear()

        Dim d_subtotal_tmp As Decimal = 0
        Dim d_iva_tmp As Decimal = 0
        Dim d_total_tmp As Decimal = 0

        For i = 0 To lv_ticket.Items.Count - 1
            Dim tTicket As List(Of tblTicket) = DBModelo.Get_PV_TicketsDetalle(CInt(lv_ticket.Items(i)))
            If tTicket.Count > 0 Then
                For Each wTicket In tTicket
                    If wTicket.ClaveProducto.Equals("") Then
                        MsgBox("Falta definir ClaveProducto al Producto " & wTicket.clave_producto & " - " & wTicket.concepto, MsgBoxStyle.Critical, "Validación de Tickets de Venta")
                        Exit Sub
                    End If
                    If wTicket.ClaveUnidad.Equals("") Then
                        MsgBox("Falta definir ClaveUnidad al Producto " & wTicket.clave_producto & " - " & wTicket.concepto, MsgBoxStyle.Critical, "Validación de Tickets de Venta")
                        Exit Sub
                    End If

                    Dim row As String() = New String(15 - 1) {}
                    row(0) = wTicket.folio
                    row(1) = CStr(wTicket.cantidad)
                    row(2) = wTicket.concepto
                    row(3) = CStr(wTicket.precio)
                    row(4) = CStr(Math.Round(CDec(wTicket.subtotal), 2))
                    row(5) = CStr(wTicket.fecha)
                    row(6) = CStr(wTicket.precioCosto)
                    row(7) = CStr(wTicket.subtotalCosto)
                    row(8) = wTicket.clave_producto
                    row(9) = TxtFolio.Text
                    row(10) = CStr(wTicket.IdProducto)
                    row(11) = wTicket.ClaveProducto
                    row(12) = wTicket.ClaveUnidad
                    If wTicket.TasaCero = False Then
                        row(13) = "0"
                        row(14) = CStr(Math.Round(CDbl(((wTicket.subtotal * CDbl(FactorIVA)) - wTicket.subtotal)), 6))
                    Else
                        row(13) = "1"
                        row(14) = CStr(wTicket.subtotal)
                    End If
                    Dim rowValues As String() = row
                    DataGridView1.Rows.Add(rowValues)

                    d_subtotal_tmp = d_subtotal_tmp + Math.Round(CDec(wTicket.subtotal), 2)
                    If wTicket.TasaCero = False Then
                        d_iva_tmp = d_iva_tmp + Math.Round(CDec((wTicket.subtotal * CDbl(FactorIVA)) - wTicket.subtotal), 2)
                        d_total_tmp = d_subtotal_tmp + d_iva_tmp
                    Else
                        d_iva_tmp = CDec("0.00")
                        d_total_tmp = d_subtotal_tmp
                    End If
                Next

                TxtSubtotal.Text = CStr(d_subtotal_tmp)
                TxtIVA.Text = CStr(d_iva_tmp)
                TxtTotal.Text = CStr(d_total_tmp)
                LblNRegistros.Text = CStr(DataGridView1.Rows.Count)
                TxtTikect.Clear()
                TxtTikect.Focus()
            Else
                MsgBox(("Ticket #: " & TxtTikect.Text & " no tiene detalle"), MsgBoxStyle.ApplicationModal, Nothing)
                TxtTikect.Clear()
                TxtTikect.Focus()
                Exit Sub
            End If
        Next
    End Sub
End Class