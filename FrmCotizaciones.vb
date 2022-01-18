
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
        lblcotizacion.Text = Me.MetroGrid1.Item(0, MetroGrid1.CurrentRow.Index).Value

        MetroGrid2.Refresh()
        Dim CotizaDet As List(Of tblTicketCotiza) = DBModelo.GetCotizacionesDet(Me.MetroGrid1.Item(0, MetroGrid1.CurrentRow.Index).Value)

        MetroGrid2.DataSource = CotizaDet.ToList

        MetroGrid2.Columns(0).Visible = False
        MetroGrid2.Columns(1).Visible = False
        MetroGrid2.Columns(2).Visible = False

        MetroGrid2.Columns(3).HeaderText = "Descripcion"
        MetroGrid2.Columns(3).ReadOnly = True
        MetroGrid2.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        MetroGrid1.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        MetroGrid2.Columns(3).Width = 400

        MetroGrid2.Columns(4).HeaderText = "Ctd"
        MetroGrid2.Columns(4).ReadOnly = True
        MetroGrid2.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        MetroGrid1.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        MetroGrid2.Columns(4).Width = 60

        MetroGrid2.Columns(5).HeaderText = "Precio Unitario"
        MetroGrid2.Columns(5).ReadOnly = True
        MetroGrid2.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        MetroGrid1.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        MetroGrid2.Columns(5).DefaultCellStyle.Format = "$ ###,###,###.00"

        MetroGrid2.Columns(6).Visible = False

        MetroGrid2.Columns(7).HeaderText = "Subtotal"
        MetroGrid2.Columns(7).ReadOnly = True
        MetroGrid2.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        MetroGrid1.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        MetroGrid2.Columns(7).DefaultCellStyle.Format = "$ ###,###,###.00"

        MetroGrid2.Columns(8).HeaderText = "Código Barra "
        MetroGrid2.Columns(8).ReadOnly = True
        MetroGrid2.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        MetroGrid1.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        MetroGrid2.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        MetroGrid2.Columns(9).Visible = False
        MetroGrid2.Columns(9).Visible = False
        MetroGrid2.Columns(10).Visible = False
        MetroGrid2.Columns(11).Visible = False
        MetroGrid2.Columns(12).Visible = False
        MetroGrid2.Columns(13).Visible = False
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub btnMandarATicket_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        MetroGrid1.Refresh()
        Dim Cotiza As List(Of tblCotizacion) = DBModelo.GetCotizaciones(dtinicio.Value.Date, dtfinal.Value.Date)

        MetroGrid1.DataSource = Cotiza.ToList

        MetroGrid1.Columns(0).HeaderText = "Ticket #"
        MetroGrid1.Columns(0).ReadOnly = True
        MetroGrid1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        MetroGrid1.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        MetroGrid1.Columns(0).Width = 70

        MetroGrid1.Columns(1).HeaderText = "Fecha"
        MetroGrid1.Columns(1).ReadOnly = True
        MetroGrid1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        MetroGrid1.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        MetroGrid1.Columns(2).Visible = False
        MetroGrid1.Columns(3).Visible = False

        MetroGrid1.Columns(4).HeaderText = "Total"
        MetroGrid1.Columns(4).ReadOnly = True
        MetroGrid1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        MetroGrid1.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        MetroGrid1.Columns(4).DefaultCellStyle.Format = "$ ###,###,###.00"

        MetroGrid1.Columns(5).Visible = False
        MetroGrid1.Columns(6).Visible = False

        MetroGrid1.Columns(7).HeaderText = "Cliente"
        MetroGrid1.Columns(7).ReadOnly = True
        MetroGrid1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        MetroGrid1.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        MetroGrid1.Columns(7).Width = 300
        MetroGrid1.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        MetroGrid1.Columns(8).HeaderText = "IdCliente"
        MetroGrid1.Columns(8).ReadOnly = True
        MetroGrid1.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        MetroGrid1.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        MetroGrid1.Columns(9).Visible = False
        MetroGrid1.Columns(10).Visible = False
        MetroGrid1.Columns(11).Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lv_result As Boolean = False
        If lblcotizacion.Text <> "" Then
            If MsgBox("¿Deseas Imprimir la Cotización?", MsgBoxStyle.YesNo, "Impresiones de Cotizaciones") = MsgBoxResult.Yes Then
                lv_result = True
            End If

            If ImprimeCotizacion(lblcotizacion.Text, lv_result, "COTIZACION", DBConnected) = False Then
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
            FrmPuntoDeVenta.MetroGrid1.DataSource = Nothing
            FrmPuntoDeVenta.MetroGrid1.Rows.Clear()

            Dim lv_granTotal As Double = 0
            Dim lv_granSubTotal As Double = 0
            Dim lv_granIVA As Double = 0
            Dim lv_granSubTotal_TasaCero As Double = 0
            Dim lv_granIVA_TasaCero As Double = 0
            Dim lv_granTotal_TasaCero As Double = 0
            For i = 0 To MetroGrid2.Rows.Count - 1
                Dim row As String() = New String() {MetroGrid2.Rows(i).Cells(4).Value,
                                                    MetroGrid2.Rows(i).Cells(2).Value,
                                                    MetroGrid2.Rows(i).Cells(3).Value,
                                                    Format(MetroGrid2.Rows(i).Cells(5).Value, "###,###,##0.00"),
                                                    Format(MetroGrid2.Rows(i).Cells(7).Value, "###,###,##0.00"),
                                                    MetroGrid2.Rows(i).Cells(8).Value,
                                                    "0",
                                                    Format(MetroGrid2.Rows(i).Cells(5).Value, "###,###,##0.00"),
                                                    Format(MetroGrid2.Rows(i).Cells(7).Value, "###,###,##0.00"),
                                                    Format(MetroGrid2.Rows(i).Cells(9).Value, "###,###,##0.00"),
                                                    Format(MetroGrid2.Rows(i).Cells(10).Value, "###,###,##0.00"),
                                                    MetroGrid2.Rows(i).Cells(11).Value,
                                                    MetroGrid2.Rows(i).Cells(12).Value,
                                                    MetroGrid2.Rows(i).Cells(13).Value}
                FrmPuntoDeVenta.MetroGrid1.Rows.Add(row)
                Dim lv_total As Double = MetroGrid2.Rows(i).Cells(7).Value
                lv_granSubTotal = lv_granSubTotal + lv_total
                If MetroGrid2.Rows(i).Cells(13).Value = False Then
                    lv_granIVA = lv_granIVA + FormatNumber((lv_total * (FactorIVA - 1)), 2)
                    lv_granTotal = lv_granTotal + FormatNumber((lv_total + (lv_total * (FactorIVA - 1))))
                    gv_tasa_16 = True
                Else
                    lv_granTotal = lv_granTotal + FormatNumber(lv_total, 2)
                    lv_granTotal_TasaCero = lv_granTotal_TasaCero + FormatNumber(lv_total, 2)
                    lv_granSubTotal_TasaCero = lv_granSubTotal_TasaCero + lv_total
                    gv_tasa_0 = True
                End If
            Next
            FrmPuntoDeVenta.txtSubTotal.Text = Format(lv_granSubTotal, "###,###,##0.00")
            FrmPuntoDeVenta.txtIVA.Text = Format(lv_granIVA, "###,###,##0.00")
            FrmPuntoDeVenta.txtTotal.Text = Format(lv_granTotal, "###,###,##0.00")
            FrmPuntoDeVenta.txtSubTotalTasaCero.Text = Format(lv_granSubTotal_TasaCero, "###,###,##0.00")
            FrmPuntoDeVenta.txtIVATasaCero.Text = Format(lv_granIVA_TasaCero, "###,###,##0.00")
            FrmPuntoDeVenta.txtTotalTasaCero.Text = Format(lv_granTotal_TasaCero, "###,###,##0.00")

            FrmPuntoDeVenta.txtCliente.Text = MetroGrid1.Rows(MetroGrid1.CurrentRow.Index).Cells(7).Value
            FrmPuntoDeVenta.txtIdCliente.Text = MetroGrid1.Rows(MetroGrid1.CurrentRow.Index).Cells(8).Value

            FrmPuntoDeVenta.CmbDocto.SelectedItem = "PEDIDO"
            Dim Cliente As tblClientes = DBModelo.GetCliente(MetroGrid1.Rows(MetroGrid1.CurrentRow.Index).Cells(8).Value)
            If IsNothing(Cliente) = False Then
                FrmPuntoDeVenta.txtDomicilio.Text = Cliente.calle & " #" & Cliente.numero & " colonia " & Cliente.colonia & " Ciudad " & Cliente.ciudad & " " & Cliente.estado & " codigo postal " & Cliente.cp & " RFC " & Cliente.rfc
            End If

            EsCotizacion = True
            FrmPuntoDeVenta.CmbTipoVenta.Text = "CREDITO"
            EsCotizacion = False
            Close()
            Dispose()
        Else
            MsgBox("Favor De Seleccionar Una Cotización", MsgBoxStyle.Critical, "Consulta y Reimpresion de Cotizaciones")
            Exit Sub
        End If
    End Sub
End Class
