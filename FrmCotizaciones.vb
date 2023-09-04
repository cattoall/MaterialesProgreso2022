
Public Class FrmCotizaciones

    Private Sub FrmCotizaciones_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                Close()
                Dispose()
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt.Clear()
        dt2.Clear()
        dtinicio.Value = Now
        dtfinal.Value = Now
        lblcotizacion.Text = ""
        lblcotizacion.Visible = False
    End Sub

    Private Sub MetroGrid1_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MetroGrid1.CellClick
        lblcotizacion.Visible = True
        lblcotizacion.Text = CStr(MetroGrid1.Item(1, MetroGrid1.CurrentRow.Index).Value)

        MetroGrid2.Refresh()
        Dim CotizaDet As List(Of tblTicketCotiza) = DBModelo.GetCotizacionesDet(CInt(MetroGrid1.Item(1, MetroGrid1.CurrentRow.Index).Value))

        MetroGrid2.DataSource = CotizaDet.ToList

        MetroGrid2.Columns(0).Visible = False
        MetroGrid2.Columns(1).Visible = False
        MetroGrid2.Columns(2).Visible = False
        MetroGrid2.Columns(3).Visible = False

        MetroGrid2.Columns(4).HeaderText = "Descripcion"
        MetroGrid2.Columns(4).ReadOnly = True
        MetroGrid2.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        MetroGrid1.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        MetroGrid2.Columns(4).Width = 400

        MetroGrid2.Columns(5).HeaderText = "Ctd"
        MetroGrid2.Columns(5).ReadOnly = True
        MetroGrid2.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        MetroGrid1.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        MetroGrid2.Columns(5).Width = 60

        MetroGrid2.Columns(6).HeaderText = "Precio Unitario"
        MetroGrid2.Columns(6).ReadOnly = True
        MetroGrid2.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        MetroGrid1.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        MetroGrid2.Columns(6).DefaultCellStyle.Format = "$ ###,###,###.00"

        MetroGrid2.Columns(7).Visible = False

        MetroGrid2.Columns(8).HeaderText = "Subtotal"
        MetroGrid2.Columns(8).ReadOnly = True
        MetroGrid2.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        MetroGrid1.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        MetroGrid2.Columns(8).DefaultCellStyle.Format = "$ ###,###,###.00"

        MetroGrid2.Columns(9).HeaderText = "Código Barra "
        MetroGrid2.Columns(9).ReadOnly = True
        MetroGrid2.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        MetroGrid1.Columns(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        MetroGrid2.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        MetroGrid2.Columns(10).Visible = False
        MetroGrid2.Columns(11).Visible = False
        MetroGrid2.Columns(12).Visible = False
        MetroGrid2.Columns(13).Visible = False
        MetroGrid2.Columns(14).Visible = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        MetroGrid1.Refresh()
        Dim Cotiza As List(Of tblCotizacion) = DBModelo.GetCotizaciones(dtinicio.Value.Date, dtfinal.Value.Date)

        MetroGrid1.DataSource = Cotiza.ToList

        MetroGrid1.Columns(0).Visible = False

        MetroGrid1.Columns(1).HeaderText = "Ticket #"
        MetroGrid1.Columns(1).ReadOnly = True
        MetroGrid1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        MetroGrid1.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        MetroGrid1.Columns(1).Width = 70

        MetroGrid1.Columns(2).HeaderText = "Fecha"
        MetroGrid1.Columns(2).ReadOnly = True
        MetroGrid1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        MetroGrid1.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        MetroGrid1.Columns(3).Visible = False
        MetroGrid1.Columns(4).Visible = False

        MetroGrid1.Columns(5).HeaderText = "Total"
        MetroGrid1.Columns(5).ReadOnly = True
        MetroGrid1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        MetroGrid1.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        MetroGrid1.Columns(5).DefaultCellStyle.Format = "$ ###,###,###.00"

        MetroGrid1.Columns(6).Visible = False
        MetroGrid1.Columns(7).Visible = False

        MetroGrid1.Columns(8).HeaderText = "Cliente"
        MetroGrid1.Columns(8).ReadOnly = True
        MetroGrid1.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        MetroGrid1.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        MetroGrid1.Columns(8).Width = 300
        MetroGrid1.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        MetroGrid1.Columns(9).HeaderText = "IdCliente"
        MetroGrid1.Columns(9).ReadOnly = True
        MetroGrid1.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        MetroGrid1.Columns(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        MetroGrid1.Columns(10).Visible = False
        MetroGrid1.Columns(11).Visible = False
        MetroGrid1.Columns(12).Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lv_result As Boolean = False
        If lblcotizacion.Text <> "" Then
            If MsgBox("¿Deseas Imprimir la Cotización?", MsgBoxStyle.YesNo, "Impresiones de Cotizaciones") = MsgBoxResult.Yes Then
                lv_result = True
            End If

            If ImprimeCotizacion(lblcotizacion.Text, lv_result, "COTIZACION") = False Then
                MsgBox("Error al Generar la Impresión de la Cotización", MsgBoxStyle.Information, "Impresiones de Cotizaciones")
                Limpia_Variables_SQL_y_Cierra_Conexion()
                Exit Sub
            End If
        Else
            MsgBox("Favor De Seleccionar Una Cotización", MsgBoxStyle.Critical, "Consulta y Reimpresion de Cotizaciones")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MetroGrid1.Rows.Count > 0 Then

            If CheckForm(FrmPuntoDeVenta) = False Then
                FrmPuntoDeVenta.MdiParent = MDIMain
                FrmPuntoDeVenta.StartPosition = FormStartPosition.CenterParent
                FrmPuntoDeVenta.Show()
            End If

            FrmPuntoDeVenta.txtDomicilio.Text = ""
            FrmPuntoDeVenta.txtCliente.Text = ""
            FrmPuntoDeVenta.DataGridView1.DataSource = Nothing
            FrmPuntoDeVenta.DataGridView1.Rows.Clear()

            Dim lv_granTotal As Double = 0
            Dim lv_granSubTotal As Double = 0
            Dim lv_granIVA As Double = 0
            Dim lv_granSubTotal_TasaCero As Double = 0
            Dim lv_granIVA_TasaCero As Double = 0
            Dim lv_granTotal_TasaCero As Double = 0
            For i = 0 To MetroGrid2.Rows.Count - 1
                Dim row As String() = New String() {MetroGrid2.Rows(i).Cells(5).Value.ToString,
                                                    MetroGrid2.Rows(i).Cells(3).Value.ToString,
                                                    MetroGrid2.Rows(i).Cells(4).Value.ToString,
                                                    FormatNumber(MetroGrid2.Rows(i).Cells(6).Value, 6),
                                                    FormatNumber(MetroGrid2.Rows(i).Cells(8).Value, 6),
                                                    MetroGrid2.Rows(i).Cells(9).Value.ToString,
                                                    "0",
                                                    FormatNumber(MetroGrid2.Rows(i).Cells(6).Value, 6),
                                                    FormatNumber(MetroGrid2.Rows(i).Cells(8).Value, 6),
                                                    Format(MetroGrid2.Rows(i).Cells(10).Value, "###,###,##0.00"),
                                                    Format(MetroGrid2.Rows(i).Cells(11).Value, "###,###,##0.00"),
                                                    MetroGrid2.Rows(i).Cells(12).Value.ToString,
                                                    MetroGrid2.Rows(i).Cells(13).Value.ToString,
                                                    MetroGrid2.Rows(i).Cells(14).Value.ToString}
                FrmPuntoDeVenta.DataGridView1.Rows.Add(row)
                Dim lv_total As Double = CDbl(MetroGrid2.Rows(i).Cells(8).Value)
                lv_granSubTotal = lv_granSubTotal + lv_total
                If CBool(MetroGrid2.Rows(i).Cells(14).Value) = False Then
                    lv_granIVA = lv_granIVA + CDbl(FormatNumber(lv_total * (CDbl(FactorIVA) - 1), 10))
                    lv_granTotal = lv_granTotal + CDbl(FormatNumber(lv_total + (lv_total * (CDbl(FactorIVA) - 1))))
                    gv_tasa_16 = True
                Else
                    lv_granTotal = lv_granTotal + CDbl(FormatNumber(lv_total, 2))
                    lv_granTotal_TasaCero = lv_granTotal_TasaCero + CDbl(FormatNumber(lv_total, 2))
                    lv_granSubTotal_TasaCero = lv_granSubTotal_TasaCero + lv_total
                    gv_tasa_0 = True
                End If
            Next
            FrmPuntoDeVenta.txtSubTotal.Text = FormatNumber(lv_granSubTotal, 6)
            FrmPuntoDeVenta.txtIVA.Text = FormatNumber(lv_granIVA, 6)
            FrmPuntoDeVenta.txtTotal.Text = FormatNumber(lv_granTotal, 2)
            FrmPuntoDeVenta.txtSubTotalTasaCero.Text = FormatNumber(lv_granSubTotal_TasaCero, 6)
            FrmPuntoDeVenta.txtIVATasaCero.Text = FormatNumber(lv_granIVA_TasaCero, 6)
            FrmPuntoDeVenta.txtTotalTasaCero.Text = FormatNumber(lv_granTotal_TasaCero, 2)

            FrmPuntoDeVenta.txtCliente.Text = CStr(MetroGrid1.Rows(MetroGrid1.CurrentRow.Index).Cells(8).Value)
            FrmPuntoDeVenta.txtIdCliente.Text = CStr(MetroGrid1.Rows(MetroGrid1.CurrentRow.Index).Cells(9).Value)

            FrmPuntoDeVenta.CmbDocto.SelectedItem = "TICKET"
            Dim Cliente As tblClientes = DBModelo.GetCliente(CInt(MetroGrid1.Rows(MetroGrid1.CurrentRow.Index).Cells(9).Value))
            If IsNothing(Cliente) = False Then
                FrmPuntoDeVenta.txtDomicilio.Text = Cliente.calle & " #" & Cliente.numero & " colonia " & Cliente.colonia & " Ciudad " & Cliente.ciudad & " " & Cliente.estado & " codigo postal " & Cliente.cp & " RFC " & Cliente.rfc
            End If

            EsCotizacion = True
            FrmPuntoDeVenta.CmbTipoVenta.Text = "CREDITO"
            EsCotizacion = False
            Close()
        Else
            MsgBox("Favor De Seleccionar Una Cotización", MsgBoxStyle.Critical, "Consulta y Reimpresion de Cotizaciones")
            Exit Sub
        End If
    End Sub
End Class
