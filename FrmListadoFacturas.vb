Imports MySql.Data.MySqlClient

Public Class FrmListadoFacturas

    Private Sub FrmListadoFacturas_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub FrmListadoVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bs.DataSource = Nothing
        bs2.DataSource = Nothing
        dt.Clear()
        dt2.Clear()
        With Me.DataGridConsulta
            ' alternar color de filas
            '.AlternatingRowsDefaultCellStyle.BackColor = My.Settings.BackColorAlt
            '.DefaultCellStyle.BackColor = My.Settings.BackColor
            '.DefaultCellStyle.Font = My.Settings.RowFont
            '.ColumnHeadersDefaultCellStyle.Font = My.Settings.HeaderFont
            ' Establecer el origen de datos para el DataGridview   
            .DataSource = bs
        End With

        With Me.DataGridTikect
            ' alternar color de filas
            '.AlternatingRowsDefaultCellStyle.BackColor = My.Settings.BackColorAlt
            '.DefaultCellStyle.BackColor = My.Settings.BackColor
            '.DefaultCellStyle.Font = My.Settings.RowFont
            '.ColumnHeadersDefaultCellStyle.Font = My.Settings.HeaderFont
            ' Establecer el origen de datos para el DataGridview   
            .DataSource = bs2
        End With

        'Me.BackColor = My.Settings.FormsBackColor
        'Me.GroupBox1.ForeColor = My.Settings.FontForeColor
        'Me.GroupBox1.Font = My.Settings.FontStyle
        'Me.CmdImprimir.BackColor = My.Settings.FormsBackColor
        'Me.CmdSalir.BackColor = My.Settings.FormsBackColor
        'Me.CmdVentas.BackColor = My.Settings.FormsBackColor
        'Me.CmdCancelar.BackColor = My.Settings.FormsBackColor
        'Me.CmdFacturaCFDI.BackColor = My.Settings.FormsBackColor
        'Me.LblNumTicket.BackColor = My.Settings.FormsBackColor
        'Me.LblTotal.BackColor = My.Settings.FormsBackColor
        dtFechaFinal.Value = Now
        dtFechaInicial.Value = Now
        LblNumTicket.Text = ""
        LblNumTicket.Visible = False
        LblTotal.Text = "$ 0.00"
    End Sub

    Private Sub ImgCFDIB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgCFDIB.MouseLeave
        Me.ImgCFDIA.Visible = True
        Me.ImgCFDIB.Visible = False
    End Sub

    Private Sub ImgCFDIA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgCFDIA.MouseHover
        Me.ImgCFDIB.Visible = True
        Me.ImgCFDIA.Visible = False
    End Sub

    Private Sub ImgCancelrarB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgCancelarB.MouseLeave
        Me.ImgCancelarA.Visible = True
        Me.ImgCancelarB.Visible = False
    End Sub

    Private Sub ImgCancelrarA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgCancelarA.MouseHover
        Me.ImgCancelarB.Visible = True
        Me.ImgCancelarA.Visible = False
    End Sub

    Private Sub ImgVerFactA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgVerFactA.MouseHover
        Me.ImgVerFactA.Visible = False
        Me.ImgVerFactB.Visible = True
    End Sub

    Private Sub ImgVerFactB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgVerFactB.MouseLeave
        Me.ImgVerFactA.Visible = True
        Me.ImgVerFactB.Visible = False
    End Sub

    Private Sub ImgSalirB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgSalirB.MouseLeave
        Me.ImgSalirA.Visible = True
        Me.ImgSalirB.Visible = False
    End Sub

    Private Sub ImgSalirA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgSalirA.MouseHover
        Me.ImgSalirB.Visible = True
        Me.ImgSalirA.Visible = False
    End Sub

    Private Sub ImgSalirB_Click(sender As System.Object, e As System.EventArgs) Handles ImgSalirB.Click
        Me.Close()
    End Sub

    Public Sub ImgVerFactB_Click(sender As System.Object, e As System.EventArgs) Handles ImgVerFactB.Click
        Dim x As List(Of tblFacturaTotal) = DBModelo.GetIntervalFacturas(dtFechaInicial.Value.Date, dtFechaFinal.Value.Date)
        DataGridConsulta.DataSource = x
        'SQL = "SELECT *, usuario FROM factura_total where  fecha_venta  >= '" & Format(dtFechaInicial.Value.Date, "yyyy-MM-dd") & "' and fecha_venta <= '" & Format(dtFechaFinal.Value.Date, "yyyy-MM-dd") & "' order by n_factura, fecha_venta asc"
        '
        ''Carga Lista de Clasificaciones
        'load_record_dgv(SQL, Me.DataGridConsulta, DBConnected)
        '
        ''Aplica formato al DataGridView
        load_layout_dgv_ListaFactura_H(Me.DataGridConsulta)
        '
        For i = 0 To DataGridConsulta.RowCount - 1
            Select Case DataGridConsulta.Item(11, i).Value
                Case "0"
                    DataGridConsulta.Item(12, i).Value = "CLIENTE"
                Case "1"
                    DataGridConsulta.Item(12, i).Value = "MOSTRADOR"
            End Select
        Next
    End Sub

    Private Sub ImgCancelarB_Click(sender As System.Object, e As System.EventArgs) Handles ImgCancelarB.Click
        If LblNumTicket.Text <> "" Then
            Cancelar = 3
            FrmCancelarPedido.ShowDialog()
            Cancelar = ""
        Else
            MsgBox("Seleccione Una Venta Para Cancelar", MsgBoxStyle.Critical, "Cancelar Venta")
        End If
    End Sub

    'Private Sub ImgGenXmlB_Click(sender As System.Object, e As System.EventArgs) Handles ImgGenXmlB.Click
    '    If LblNumTicket.Text <> "" Then
    '        If MsgBox("¿Está seguro de generar el XML de Cancelación?", MsgBoxStyle.YesNo, "Generar XML Cancelación") = MsgBoxResult.Yes Then
    '            CancelaFactura_CFDI(CInt(LblNumTicket.Text), DBConnected)
    '            MsgBox("XML generado.", MsgBoxStyle.Information, "Generar XML Cancelación")
    '            Call ImgVerFactB_Click(sender, e)
    '        End If
    '    Else
    '        MsgBox("Favor de Seleccionar la Factura a Generar el XML Cancelación.", MsgBoxStyle.Critical, "Generar XML Cancelación")
    '    End If
    'End Sub

    Private Sub ImgReImpB_Click(sender As System.Object, e As System.EventArgs)
        'Dim lv_result As Boolean = False
        'If LblNumTicket.Text <> "" Then
        '    If MsgBox("¿Deseas Imprimir la Factura?", MsgBoxStyle.YesNo, "Impresiones de Facturas") = MsgBoxResult.Yes Then
        '        lv_result = True
        '    End If
        '    If ImprimeFactura(DataGridConsulta.Item(0, DataGridConsulta.CurrentRow.Index).Value, lv_result) = False Then
        '        MsgBox("Hubo un error al Generar la Impresión de la Factura", MsgBoxStyle.Critical, "Impresiones de Facturas")
        '    Else
        '        MsgBox("Re'Impresión de Factura Correctamente", MsgBoxStyle.Information, "Impresiones de Facturas")
        '    End If
        'Else
        '    MsgBox("Favor de Seleccionar la Factura a Re-Imprimir.", MsgBoxStyle.Information, "Impresiones de Facturas")
        'End If
    End Sub

    Private Sub ImgCFDIB_Click(sender As System.Object, e As System.EventArgs) Handles ImgCFDIB.Click
        If LblNumTicket.Text <> "" Then
            If ImprimeFactura2(DataGridConsulta.Item(1, DataGridConsulta.CurrentRow.Index).Value, DataGridConsulta.Item(2, DataGridConsulta.CurrentRow.Index).Value, True) = False Then
                MsgBox("Hubo un error al Generar la Impresión de la Factura", MsgBoxStyle.Critical, "Impresiones de Facturas")
            Else
                MsgBox("Re'Impresión de Factura Correctamente", MsgBoxStyle.Information, "Impresiones de Facturas")
            End If
        Else
            MsgBox("Favor de Seleccionar la Factura a Re-Imprimir.", MsgBoxStyle.Critical, "Impresiones de Facturas")
        End If
    End Sub

    Private Sub ImgVerFactA_Click(sender As System.Object, e As System.EventArgs) Handles ImgVerFactA.Click

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub DataGridConsulta_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) 

    End Sub

    Private Sub DataGridConsulta_CellContextMenuStripChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) 

    End Sub

    Private Sub DataGridConsulta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridConsulta.CellClick
        LblNumTicket.Visible = True
        LblTotal.Text = Format(Me.DataGridConsulta.Item(1, DataGridConsulta.CurrentRow.Index).Value, "$ ###,###,##0.00")
        LblNumTicket.Text = Me.DataGridConsulta.Item(0, DataGridConsulta.CurrentRow.Index).Value
        NoFactura = Me.DataGridConsulta.Item(0, DataGridConsulta.CurrentRow.Index).Value
        FechaFactura = Format(Me.DataGridConsulta.Item(6, DataGridConsulta.CurrentRow.Index).Value, "yyyyMMdd")
        'SQL = "SELECT n_factura,cantidad,descripcion,precio,subtotal,clave_p,idProducto,fecha,folio FROM facturas where n_factura = " & Me.DataGridConsulta.Item(0, DataGridConsulta.CurrentRow.Index).Value
        Dim nFactura As String = Me.DataGridConsulta.Item(0, DataGridConsulta.CurrentRow.Index).Value
        DataGridTikect.DataSource = DBModelo.GetFacturaByN(nFactura)
        'Carga Lista de Clasificaciones
        'load_record_dgv2(SQL, Me.DataGridTikect, DBConnected)
        
        'Aplica formato al DataGridView
        'load_layout_dgv_ListaFacturas_i(Me.DataGridTikect)
    End Sub
End Class
