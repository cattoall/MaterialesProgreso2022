
Imports MetroFramework.Controls

Public Class FrmHistorialCliente
    Private Sub FrmHistorialCliente_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.F2
                Call CmdBuscar_Click(sender, e)
            Case Keys.Escape
                Me.Close()
                txtCliente.Text = ""
        End Select
    End Sub

    Private Sub FrmHistoCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Refresh()
        rbtVenta.Checked = True
        dtFechaFinal.Value = Now
        dtFechaInicial.Value = Now
        LblTotal.Text = "$0.00"
    End Sub

    Private Sub CmdBuscar_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub CmdMostrar_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub ConfiguraGrid(ByVal dv As DataGridView)

        If rbtVenta.Checked = True Then
            dv.Columns(0).HeaderText = "Ticket"
        ElseIf rbtVentaPedido.Checked = True Then
            dv.Columns(0).HeaderText = "Pedido"
        ElseIf rdbCotizacion.Checked = True Then
            dv.Columns(0).HeaderText = "Cotización"
        End If
        dv.Columns(0).ReadOnly = True
        dv.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(1).HeaderText = "Fecha"
        dv.Columns(1).ReadOnly = True
        dv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(2).Visible = False
        dv.Columns(3).Visible = False

        dv.Columns(4).HeaderText = "Total"
        dv.Columns(4).ReadOnly = True
        dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dv.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(4).DefaultCellStyle.Format = "$ ###,###,###.00"

        dv.Columns(5).HeaderText = "Tipo"
        dv.Columns(5).ReadOnly = True
        dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(6).Visible = False
        dv.Columns(7).Visible = False
        dv.Columns(8).Visible = False

        dv.Columns(9).HeaderText = "Estado"
        dv.Columns(9).ReadOnly = True
        dv.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(10).HeaderText = "Motivo"
        dv.Columns(10).ReadOnly = True
        dv.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(10).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(11).HeaderText = "Numero de Factura"
        dv.Columns(11).ReadOnly = True
        dv.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(11).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub CmdSalir_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Buscar_Clientes = "HISTORIAL"
        FrmBuscarClientesVentas.ShowDialog()
        FrmBuscarClientesVentas.Close()
        CmdMostrar.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtCliente.Text = ""
        Close()
        Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CmdMostrar.Click
        
        If idClienteVenta = "0" Then
            MessageBox.Show("Favor de seleccionar un Cliente")
            CmdBuscar.Focus()
            Exit Sub
        End If

        LblTotal.Text = "$0.00"
        Dim tTickets As List(Of tblVenta)
        Dim tPedidos As List(Of tblVentaPedido)
        Dim tCotizaciones As List(Of tblCotizacion)
        DataGridView1.Refresh()

        If rbtVenta.Checked = True Then
            tTickets = DBModelo.Get_TicketsByDateIdCliente(Format(dtFechaInicial.Value.Date, "yyyy-MM-dd"), Format(dtFechaFinal.Value.Date, "yyyy-MM-dd"), idClienteVenta)
            DataGridView1.DataSource = tTickets.ToList()

        ElseIf rbtVentaPedido.Checked = True Then
            tPedidos = DBModelo.Get_PedidosByDateIdCliente(Format(dtFechaInicial.Value.Date, "yyyy-MM-dd"), Format(dtFechaFinal.Value.Date, "yyyy-MM-dd"), idClienteVenta)
            DataGridView1.DataSource = tPedidos.ToList()

        ElseIf rdbCotizacion.Checked = True Then
            tCotizaciones = DBModelo.Get_CotizacionesByDateIdCliente(Format(dtFechaInicial.Value.Date, "yyyy-MM-dd"), Format(dtFechaFinal.Value.Date, "yyyy-MM-dd"), idClienteVenta)
            DataGridView1.DataSource = tCotizaciones.ToList()

        End If

        ConfiguraGrid(DataGridView1)

        For i = 0 To DataGridView1.RowCount - 1
            LblTotal.Text = CDbl(LblTotal.Text) + CDbl(DataGridView1.Item(4, i).Value)
        Next
        LblTotal.Text = FormatCurrency(LblTotal.Text, 2)
    End Sub
End Class