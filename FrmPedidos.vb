Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class FrmPedidos

    Private Sub FrmPedidos_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub pedidos_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        bs.DataSource = Nothing
        bs2.DataSource = Nothing
        dt.Clear()
        dt2.Clear()
        With Me.DataGridView1
            ' alternar color de filas
            '.AlternatingRowsDefaultCellStyle.BackColor = My.Settings.BackColorAlt
            '.DefaultCellStyle.BackColor = My.Settings.BackColor
            '.DefaultCellStyle.Font = My.Settings.RowFont
            '.ColumnHeadersDefaultCellStyle.Font = My.Settings.HeaderFont
            ' Establecer el origen de datos para el DataGridview   
            .DataSource = bs
        End With

        With Me.DataGridView2
            ' alternar color de filas
            '.AlternatingRowsDefaultCellStyle.BackColor = My.Settings.BackColorAlt
            '.DefaultCellStyle.BackColor = My.Settings.BackColor
            '.DefaultCellStyle.Font = My.Settings.RowFont
            '.ColumnHeadersDefaultCellStyle.Font = My.Settings.HeaderFont
            ' Establecer el origen de datos para el DataGridview   
            .DataSource = bs2
        End With
        'Me.BackColor = My.Settings.FormsBackColor
        'Me.LblPedido.BackColor = My.Settings.FormsBackColor
        'Me.GroupBox1.ForeColor = My.Settings.FontForeColor
        'Me.GroupBox1.Font = My.Settings.FontStyle
        'Me.CmdRemision.BackColor = My.Settings.FormsBackColor
        'Me.CmdSalir.BackColor = My.Settings.FormsBackColor
        'Me.CmdVentas.BackColor = My.Settings.FormsBackColor
        'Me.CmdImprimir.BackColor = My.Settings.FormsBackColor
        'Me.CmdCancelar.BackColor = My.Settings.FormsBackColor
        dpinicio.Value = Now
        dpfinal.Value = Now
        LblPedido.Text = ""
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        LblPedido.Text = Me.DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        NoFactura = Me.DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        SQL = "SELECT * FROM ticket_pedido where folio = " & Me.DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value & ""

        'Carga Lista de Clasificaciones
        load_record_dgv2_pedido(SQL, Me.DataGridView2, DBConnected)

        'Aplica formato al DataGridView
        load_layout_dgv_ticket_pedido(Me.DataGridView2)
    End Sub

    Private Sub ImgSalirB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgSalirB.MouseLeave
        Me.ImgSalirA.Visible = True
        Me.ImgSalirB.Visible = False
    End Sub

    Private Sub ImgSalirA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgSalirA.MouseHover
        Me.ImgSalirB.Visible = True
        Me.ImgSalirA.Visible = False
    End Sub

    Private Sub ImgReImpB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgReImpB.MouseLeave
        Me.ImgReImpA.Visible = True
        Me.ImgReImpB.Visible = False
    End Sub

    Private Sub ImgReImpA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgReImpA.MouseHover
        Me.ImgReImpB.Visible = True
        Me.ImgReImpA.Visible = False
    End Sub

    Private Sub ImgCancelrarB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgCancelarB.MouseLeave
        Me.ImgCancelarA.Visible = True
        Me.ImgCancelarB.Visible = False
    End Sub

    Private Sub ImgCancelrarA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgCancelarA.MouseHover
        Me.ImgCancelarB.Visible = True
        Me.ImgCancelarA.Visible = False
    End Sub

    Private Sub ImgSalirB_Click_1(sender As System.Object, e As System.EventArgs) Handles ImgSalirB.Click
        Me.Close()
    End Sub

    Private Sub ImgReImpB_Click(sender As System.Object, e As System.EventArgs) Handles ImgReImpB.Click
        If LblPedido.Text <> "" Then
            Dim lv_result As Boolean = False
            If MsgBox("¿Deseas Imprimir el Pedido?", MsgBoxStyle.YesNo, "Re-Impresiones de Pedidos") = MsgBoxResult.Yes Then
                lv_result = True
            End If

            If ImprimeVenta(LblPedido.Text, lv_result, "PEDIDO", DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value, "0.00", DBConnected) = False Then
                MsgBox("Error al Generar la Impresión del Pedido", MsgBoxStyle.Information, "Re-Impresiones de Pedidos")
                Limpia_Variables_SQL_y_Cierra_Conexion()
                Exit Sub
            End If
        Else
            MsgBox("Favor de seleccionar una venta.", MsgBoxStyle.Critical, "Re-Impresiones de Pedidos")
        End If
        Limpia_Variables_SQL_y_Cierra_Conexion()
    End Sub

    Private Sub ImgCancelarB_Click(sender As System.Object, e As System.EventArgs) Handles ImgCancelarB.Click
        If LblPedido.Text <> "" Then
            Cancelar = 1
            FrmCancelarPedido.ShowDialog()
            Cancelar = ""
        Else
            MsgBox("Seleccione Un Pedido Para Cancelar", MsgBoxStyle.Critical, "Cancelar Pedido")
        End If
    End Sub

    Private Sub ImgVentasB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgVentasB.MouseLeave
        Me.ImgVentasA.Visible = True
        Me.ImgVentasB.Visible = False
    End Sub

    Private Sub ImgVentasA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgVentasA.MouseHover
        Me.ImgVentasA.Visible = False
        Me.ImgVentasB.Visible = True
    End Sub

    Private Sub ImgTicketB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgTicketB.MouseLeave
        Me.ImgTicketA.Visible = True
        Me.ImgTicketB.Visible = False
    End Sub

    Private Sub ImgTicketA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgTicketA.MouseHover
        Me.ImgTicketA.Visible = False
        Me.ImgTicketB.Visible = True
    End Sub

    Public Sub ImgVentasB_Click(sender As System.Object, e As System.EventArgs) Handles ImgVentasB.Click
        SQL = "SELECT * FROM venta_pedido where fecha  >= '" & Format(dpinicio.Value.Date, "yyyy-MM-dd") & "' and fecha <= '" & Format(dpfinal.Value.Date, "yyyy-MM-dd") & "' order by nticket, fecha asc"

        'Carga Lista de Clasificaciones
        load_record_dgv_pedido(SQL, Me.DataGridView1, DBConnected)

        'Aplica formato al DataGridView
        load_layout_dgv_pedido(Me.DataGridView1)
    End Sub

    Private Sub ImgTicketB_Click(sender As System.Object, e As System.EventArgs) Handles ImgTicketB.Click

        'Dim dt_tmp As DataTable

        'If DataGridView1.Rows.Count > 0 Then

        '    If CheckForm(FrmPuntoDeVenta) = False Then

        '        '  Informes
        '        MDIMain.ImgListProd.Visible = False
        '        MDIMain.ImgListCot.Visible = False
        '        MDIMain.ImgListDeu.Visible = False
        '        MDIMain.ImgListVent.Visible = False
        '        MDIMain.ImgListPreLin.Visible = False
        '        MDIMain.ImgHistorial.Visible = False
        '        MDIMain.ImgAjusteInv.Visible = False
        '        MDIMain.ImgClientePagos.Visible = False
        '        MDIMain.ImgConvertir.Visible = False
        '        MDIMain.ImgDevPedidos.Visible = False
        '        MDIMain.ImgDevTickets.Visible = False
        '        MDIMain.ImgNotas.Visible = False

        '        MDIMain.lblListProd.Visible = False
        '        MDIMain.lblListCot.Visible = False
        '        MDIMain.lblListCot2.Visible = False
        '        MDIMain.lblListDeu.Visible = False
        '        MDIMain.lblListVent.Visible = False
        '        MDIMain.lblListVent2.Visible = False
        '        MDIMain.lblListPreLin.Visible = False
        '        MDIMain.lblHistorial.Visible = False
        '        MDIMain.lblAjusteInv.Visible = False
        '        MDIMain.lblClientePagos.Visible = False
        '        MDIMain.lblConvertir.Visible = False
        '        MDIMain.lblDevPed.Visible = False
        '        MDIMain.lblDevTickets.Visible = False
        '        MDIMain.lblNotasCred.Visible = False

        '        FrmPuntoDeVenta.MdiParent = MDIMain
        '        FrmPuntoDeVenta.StartPosition = FormStartPosition.CenterParent
        '        SetFormName(FrmPuntoDeVenta, DBConnected)
        '        FrmPuntoDeVenta.Show()
        '    End If

        '    FrmPuntoDeVenta.txtDomicilio.Text = ""
        '    FrmPuntoDeVenta.txtCliente.Text = ""
        '    FrmPuntoDeVenta.DataGridView1.DataSource = Nothing
        '    FrmPuntoDeVenta.DataGridView1.Rows.Clear()

        '    Dim lv_granTotal As Double = 0
        '    Dim lv_granSubTotal As Double = 0
        '    Dim lv_granIVA As Double = 0
        '    Dim lv_granSubTotal_TasaCero As Double = 0
        '    Dim lv_granIVA_TasaCero As Double = 0
        '    Dim lv_granTotal_TasaCero As Double = 0
        '    For i = 0 To DataGridView2.Rows.Count - 1
        '        Dim row As String() = New String() {DataGridView2.Rows(i).Cells(2).Value,
        '                                            DataGridView2.Rows(i).Cells(9).Value,
        '                                            DataGridView2.Rows(i).Cells(1).Value,
        '                                            FormatCurrency(DataGridView2.Rows(i).Cells(3).Value),
        '                                            FormatCurrency(DataGridView2.Rows(i).Cells(5).Value),
        '                                            DataGridView2.Rows(i).Cells(6).Value,
        '                                            "0",
        '                                            FormatCurrency(DataGridView2.Rows(i).Cells(3).Value),
        '                                            FormatCurrency(DataGridView2.Rows(i).Cells(5).Value),
        '                                            FormatCurrency(DataGridView2.Rows(i).Cells(7).Value),
        '                                            FormatCurrency(DataGridView2.Rows(i).Cells(8).Value),
        '                                            DataGridView2.Rows(i).Cells(11).Value,
        '                                            DataGridView2.Rows(i).Cells(12).Value,
        '                                            DataGridView2.Rows(i).Cells(13).Value}
        '        FrmPuntoDeVenta.DataGridView1.Rows.Add(row)
        '        Dim lv_total As Double = DataGridView2.Rows(i).Cells(5).Value
        '        lv_granSubTotal = lv_granSubTotal + lv_total
        '        If DataGridView2.Rows(i).Cells(13).Value = 0 Then
        '            lv_granIVA = lv_granIVA + FormatNumber((lv_total * (FactorIVA - 1)), 2)
        '            lv_granTotal = lv_granTotal + FormatNumber((lv_total + (lv_total * (FactorIVA - 1))))
        '            gv_tasa_16 = True
        '        Else
        '            lv_granTotal = lv_granTotal + FormatNumber(lv_total, 2)
        '            lv_granTotal_TasaCero = lv_granTotal_TasaCero + FormatNumber(lv_total, 2)
        '            lv_granSubTotal_TasaCero = lv_granSubTotal_TasaCero + lv_total
        '            gv_tasa_0 = True
        '        End If
        '    Next
        '    FrmPuntoDeVenta.txtSubTotal.Text = Format(lv_granSubTotal, "###,###,##0.00")
        '    FrmPuntoDeVenta.txtIVA.Text = Format(lv_granIVA, "###,###,##0.00")
        '    FrmPuntoDeVenta.txtTotal.Text = Format(lv_granTotal, "###,###,##0.00")
        '    FrmPuntoDeVenta.txtSubTotalTasaCero.Text = Format(lv_granSubTotal_TasaCero, "###,###,##0.00")
        '    FrmPuntoDeVenta.txtIVATasaCero.Text = Format(lv_granIVA_TasaCero, "###,###,##0.00")
        '    FrmPuntoDeVenta.txtTotalTasaCero.Text = Format(lv_granTotal_TasaCero, "###,###,##0.00")

        '    FrmPuntoDeVenta.txtCliente.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(7).Value
        '    FrmPuntoDeVenta.txtIdCliente.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(8).Value

        '    FrmPuntoDeVenta.CmbDocto.SelectedItem = "TICKET"
        '    SQL = "SELECT calle,numero,colonia,ciudad,estado,cp,rfc  FROM clientes where clave= '" & DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(8).Value & "'"
        '    conn.Open()
        '    If conn.State = ConnectionState.Open Then
        '        myCommand = New MySqlCommand(SQL, conn)
        '        myAdapter.SelectCommand = myCommand
        '        dt_tmp = New DataTable
        '        dt_tmp.Clear()
        '        myAdapter.Fill(dt_tmp)
        '        If dt_tmp.Rows.Count > 0 Then
        '            FrmPuntoDeVenta.txtDomicilio.Text = dt_tmp.Rows(0)!calle & " #" & dt_tmp.Rows(0)!numero & " colonia " & dt_tmp.Rows(0)!colonia & " Ciudad " & dt_tmp.Rows(0)!ciudad & " " & dt_tmp.Rows(0)!estado & " codigo postal " & dt_tmp.Rows(0)!cp & " RFC " & dt_tmp.Rows(0)!rfc
        '        End If
        '    End If
        '    Limpia_Variables_SQL_y_Cierra_Conexion()
        '    Me.Close()
        '    EsCotizacion = True
        '    If DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(7).Value = "PUBLICO GENERAL" Then
        '        FrmPuntoDeVenta.CmbTipoVenta.Text = "CONTADO"
        '    Else
        '        FrmPuntoDeVenta.CmbTipoVenta.Text = "CREDITO"
        '    End If
        '    EsCotizacion = False
        'Else
        '    MsgBox("Favor De Seleccionar El Pedido", MsgBoxStyle.Critical, "Consulta y Reimpresion de Pedidos")
        '    Exit Sub
        'End If

        Dim dt_tmp As DataTable
        Dim lv_folio As Integer = 0
        Dim lv_folioactual As Integer = 0
        Dim nuevo = 0
        Dim lv_resto = 0
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("Favor de Generar Consulta", MsgBoxStyle.Information, "Convertir Pedido a Ticket")
            ImgVentasB.Focus()
            Exit Sub
        End If
        If LblPedido.Text = "" Then
            MsgBox("Favor de Seleccionar un Pedido", MsgBoxStyle.Information, "Convertir Pedido a Ticket")
            Exit Sub
        End If
        Dim folio_pedido As String = Me.DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value

        If Me.DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value = "CREDITO" Then
            Try
                SQL = "select * from cobrar where n_remision='" & folio_pedido & "' and tipoDocumento='PEDIDO'"
                conn.Open()
                If conn.State = ConnectionState.Open Then
                    myCommand = New SqlCommand(SQL, conn)
                    myAdapter.SelectCommand = myCommand
                    dt_tmp = New DataTable
                    dt_tmp.Clear()
                    myAdapter.Fill(dt_tmp)
                    If dt_tmp.Rows.Count > 0 Then
                        lv_resto = dt_tmp.Rows(0)!resto
                        If lv_resto > 0 Then
                            MsgBox("Pedido " & folio_pedido & " aún tiene Saldo Pendiente!", MsgBoxStyle.Information, "Convertir Pedido a Ticket")
                            Limpia_Variables_SQL_y_Cierra_Conexion()
                            Exit Sub
                        End If
                    End If
                End If
                Limpia_Variables_SQL_y_Cierra_Conexion()
            Catch ex As Exception
                MsgBox(ex.Message)
                Limpia_Variables_SQL_y_Cierra_Conexion()
            End Try
        End If

        Try
            SQL = "SELECt FolioActual FROM foliostickets where year = '" & Now.Year & "' and idterminal = '" & gv_terminal & "' and doctype='TICKET' "
            conn.Open()
            If conn.State = ConnectionState.Open Then
                myCommand = New SqlCommand(SQL, conn)
                myAdapter.SelectCommand = myCommand
                dt_tmp = New DataTable
                dt_tmp.Clear()
                myAdapter.Fill(dt_tmp)
                If dt_tmp.Rows.Count > 0 Then
                    lv_folio = dt_tmp.Rows(0)!FolioActual
                    lv_folioactual = Val(gv_terminal.ToString & Now.Year.ToString & lv_folio.ToString)
                Else
                    Sql1.Clear()
                    Sql1.Append("INSERT INTO FoliosTickets (Year,IdTerminal,DocType,FolioActual) values ( ")
                    Sql1.AppendFormat("'{0}', ", Now.Year)
                    Sql1.AppendFormat("'{0}', ", gv_terminal)
                    Sql1.AppendFormat("'{0}', ", "TICKET")
                    Sql1.AppendFormat("'{0}' ", 1)
                    Sql1.Append(" )")

                    If Insertar_Registro(Sql1.ToString, DBConnected) = False Then
                        MsgBox("Error", MsgBoxStyle.Critical)
                        Limpia_Variables_SQL_y_Cierra_Conexion()
                        Exit Sub
                    End If
                    lv_folio = 1
                    lv_folioactual = Val(gv_terminal.ToString & Now.Year.ToString & lv_folio.ToString)
                End If
            End If
            Limpia_Variables_SQL_y_Cierra_Conexion()
        Catch ex As Exception
            MsgBox(ex.Message)
            Limpia_Variables_SQL_y_Cierra_Conexion()
        End Try

        Sql1.Clear()
        Sql1.Append("INSERT INTO venta (nticket,fecha,subtotal,iva,total,tipo,usuario,cliente,idCliente,estado) values ( ")
        Sql1.AppendFormat("'{0}', ", lv_folioactual)
        Sql1.AppendFormat("'{0}', ", Format(DateTime.Today.Date, "yyyy-MM-dd"))
        Sql1.AppendFormat("'{0}', ", Me.DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value)
        Sql1.AppendFormat("'{0}', ", Me.DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value)
        Sql1.AppendFormat("'{0}', ", Me.DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value)
        Sql1.AppendFormat("'{0}', ", "CONTADO")
        Sql1.AppendFormat("'{0}', ", Me.DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value)
        Sql1.AppendFormat("'{0}', ", "PUBLICO GENERAL")
        Sql1.AppendFormat("'{0}', ", "0")
        Sql1.AppendFormat("'{0}' ", Me.DataGridView1.Item(9, DataGridView1.CurrentRow.Index).Value)
        Sql1.Append(" )")

        If Insertar_Registro(Sql1.ToString, DBConnected) = False Then
            MsgBox("Error al Insertar Registro en tabla VENTA", MsgBoxStyle.Critical, "Convertir Pedido a Ticket")
            Limpia_Variables_SQL_y_Cierra_Conexion()
            Exit Sub
        End If

        SQL = "SELECT * FROM ticket_pedido where folio = " & folio_pedido & ""
        conn.Open()
        If conn.State = ConnectionState.Open Then
            myCommand = New SqlCommand(SQL, conn)
            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myDs)
            For i = 0 To myDs.Tables(0).Rows.Count - 1
                Sql1.Clear()
                Sql1.Append("INSERT INTO ticket (folio,concepto,cantidad,precio,fecha,subtotal,clave_producto,precioCosto,subtotalCosto,idProducto,ClaveProducto,ClaveUnidad,TasaCero) values ( ")
                Sql1.AppendFormat("'{0}', ", lv_folioactual)
                Sql1.AppendFormat("'{0}', ", myDs.Tables(0).Rows(i)!concepto)
                Sql1.AppendFormat("'{0}', ", myDs.Tables(0).Rows(i)!cantidad)
                Sql1.AppendFormat("'{0}', ", myDs.Tables(0).Rows(i)!precio)
                Sql1.AppendFormat("'{0}', ", Format(DateTime.Today.Date, "yyyy-MM-dd"))
                Sql1.AppendFormat("'{0}', ", myDs.Tables(0).Rows(i)!subtotal)
                Sql1.AppendFormat("'{0}', ", myDs.Tables(0).Rows(i)!clave_producto)
                Sql1.AppendFormat("'{0}', ", myDs.Tables(0).Rows(i)!precioCosto)
                Sql1.AppendFormat("'{0}', ", myDs.Tables(0).Rows(i)!subtotalCosto)
                Sql1.AppendFormat("'{0}', ", myDs.Tables(0).Rows(i)!idProducto)
                Sql1.AppendFormat("'{0}', ", myDs.Tables(0).Rows(i)!ClaveProducto)
                Sql1.AppendFormat("'{0}', ", myDs.Tables(0).Rows(i)!ClaveUnidad)
                Sql1.AppendFormat("{0} ", myDs.Tables(0).Rows(i)!TasaCero)
                Sql1.Append(" )")
                If Insertar_Registro(Sql1.ToString, DBConnected) = False Then
                    MsgBox("Error al Insertar Registro en tabla TICKET", MsgBoxStyle.Critical, "Convertir Pedido a Ticket")
                    Limpia_Variables_SQL_y_Cierra_Conexion()
                    Exit Sub
                End If
            Next
        End If

        Limpia_Variables_SQL_y_Cierra_Conexion()

        MsgBox("Se generó el Ticket: ( " & lv_folioactual & " ), para el Pedido: ( " & folio_pedido & " )", MsgBoxStyle.Information, "Convertir Pedido a Ticket")

        '-------------------------------------------------------------------------------------------------

        Sql1.Clear()
        Sql1.Append("delete from venta_pedido where nticket= ")
        Sql1.AppendFormat("'{0}' ", folio_pedido)
        If Insertar_Registro(Sql1.ToString, DBConnected) = False Then
            MsgBox("Error al Eliminar Registro en tabla VENTA_PEDIDO", MsgBoxStyle.Critical, "Convertir Pedido a Ticket")
            Limpia_Variables_SQL_y_Cierra_Conexion()
            Exit Sub
        End If

        Sql1.Clear()
        Sql1.Append("delete from ticket_pedido where folio= ")
        Sql1.AppendFormat("'{0}' ", folio_pedido)
        If Insertar_Registro(Sql1.ToString, DBConnected) = False Then
            MsgBox("Error al Eliminar Registro en tabla TICKET_PEDIDO", MsgBoxStyle.Critical, "Convertir Pedido a Ticket")
            Limpia_Variables_SQL_y_Cierra_Conexion()
            Exit Sub
        End If

        If Me.DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value = "CREDITO" Then
            Sql1.Clear()
            Sql1.Append("delete from cobrar where n_remision=")
            Sql1.AppendFormat("'{0}' and ", folio_pedido)
            Sql1.Append("tipodocumento =")
            Sql1.AppendFormat("'{0}' ", "PEDIDO")
            If Insertar_Registro(Sql1.ToString, DBConnected) = False Then
                MsgBox("Error al Eliminar Registro en tabla COBRAR", MsgBoxStyle.Critical, "Convertir Pedido a Ticket")
                Limpia_Variables_SQL_y_Cierra_Conexion()
                Exit Sub
            End If
        End If

        Call ImgVentasB_Click(sender, e)

        lv_folio = lv_folio + 1
        Sql1.Clear()
        Sql1.Append("UPDATE FoliosTickets  SET FolioActual = ")
        Sql1.AppendFormat("'{0}' ", lv_folio)
        Sql1.Append("where year = ")
        Sql1.AppendFormat("'{0}' ", Now.Year.ToString)
        Sql1.Append("and idTerminal = ")
        Sql1.AppendFormat("'{0}' ", gv_terminal)
        Sql1.Append("and DocType = ")
        Sql1.AppendFormat("'{0}' ", "TICKET")

        If Insertar_Registro(Sql1.ToString, DBConnected) = False Then
            MsgBox("No se pudo Actualizar registro en la tabla FOLIOSTICKETS", MsgBoxStyle.Critical, "Convertir Pedido a Ticket")
            Limpia_Variables_SQL_y_Cierra_Conexion()
            Exit Sub
        End If

        Limpia_Variables_SQL_y_Cierra_Conexion()

        bs2.DataSource = Nothing
        dt2.Clear()
        With Me.DataGridView2
            .DataSource = bs2
        End With
        LblPedido.Text = " "
    End Sub
End Class