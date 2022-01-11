Public Class FrmFacturasTickates

    Private Sub FrmFacturasTickates_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub FrmFacturasTickates_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        bs.DataSource = Nothing
        bs2.DataSource = Nothing
        dt.Clear()
        dt2.Clear()
        With Me.MetroGrid1
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
        'Me.CmdSalir.BackColor = My.Settings.FormsBackColor
        'Me.CmdVentas.BackColor = My.Settings.FormsBackColor

        dtFechaFinal.Value = Now
        dtFechaInicial.Value = Now

    End Sub

    Private Sub ImgSalirB_Click(sender As System.Object, e As System.EventArgs) 
        Me.Close()
    End Sub

    Private Sub MetroGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellClick
        DataGridTikect.DataSource = DBModelo.GetVenta(Me.MetroGrid1.Item(0, MetroGrid1.CurrentRow.Index).Value)
        DataGridTikect.Columns(0).HeaderText = "No. Ticket"
        DataGridTikect.Columns(1).HeaderText = "Fecha"
        DataGridTikect.Columns(2).HeaderText = "SubTotal"
        DataGridTikect.Columns(3).HeaderText = "Tipo de Venta"
        DataGridTikect.Columns(4).HeaderText = "IVA"
        DataGridTikect.Columns(5).HeaderText = "Total"
        DataGridTikect.Columns(6).HeaderText = "Tipo de Pago"
        DataGridTikect.Columns(7).HeaderText = "Usuario"
        DataGridTikect.Columns(8).HeaderText = "Cliente"
        DataGridTikect.Columns(9).HeaderText = "ID Cliente"
        DataGridTikect.Columns(10).HeaderText = "Estado"
        DataGridTikect.Columns(11).HeaderText = "Motivo"
        DataGridTikect.Columns(11).HeaderText = "No. Factura"
    End Sub

    Private Sub mBtnExit_Click(sender As Object, e As EventArgs) Handles mBtnExit.Click
        Me.Close()
    End Sub

    Private Sub mBtnSearch_Click(sender As Object, e As EventArgs) Handles mBtnSearch.Click
        Dim x As List(Of tblFacturaTotal) = DBModelo.GetIntervalFacturas(dtFechaInicial.Value.Date, dtFechaFinal.Value.Date)
        MetroGrid1.DataSource = x
        Console.WriteLine(MetroGrid1.Columns.Count.ToString)
        MetroGrid1.Columns(0).HeaderText = "No. Factura"
        MetroGrid1.Columns(1).HeaderText = "Total"
        MetroGrid1.Columns(2).HeaderText = "Usuario"
        MetroGrid1.Columns(3).HeaderText = "Tipo de Venta"
        MetroGrid1.Columns(4).HeaderText = "Cliente"
        MetroGrid1.Columns(5).HeaderText = "ID Cliente"
        MetroGrid1.Columns(6).HeaderText = "Fecha de Venta"
        MetroGrid1.Columns(7).HeaderText = "Fecha Límite"
        MetroGrid1.Columns(8).HeaderText = "Condiciones"
        MetroGrid1.Columns(9).HeaderText = "Estado"
        MetroGrid1.Columns(10).HeaderText = "Observaciones"
        MetroGrid1.Columns(11).HeaderText = "Día De Factura"
        MetroGrid1.Columns(12).HeaderText = "Método de Pago"
        MetroGrid1.Columns(13).HeaderText = "nc"
        MetroGrid1.Columns(14).HeaderText = "Cuenta"
        MetroGrid1.Columns(15).HeaderText = "Banco"
        MetroGrid1.Columns(16).HeaderText = "Forma de Pago"
        MetroGrid1.Columns(17).HeaderText = "Uso de CFDI"
        MetroGrid1.Columns(18).HeaderText = "UUID"
        MetroGrid1.Columns(19).HeaderText = "Cancelada"
        MetroGrid1.Columns(20).HeaderText = "Comprobante de Pago"
        MetroGrid1.Columns(21).HeaderText = "PDF"
    End Sub
End Class