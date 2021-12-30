Imports MySql.Data.MySqlClient

Public Class FrmHistorialCliente
    Private Sub FrmHistorialCliente_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.F2
                Call ImgBuscarB_Click(sender, e)
            Case Keys.Escape
                Me.Close()
                txtCliente.Text = ""
        End Select
    End Sub

    Private Sub FrmHistoCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bs4.DataSource = Nothing
        dt4.Clear()
        With Me.DataGridView1
            ' alternar color de filas
            '.AlternatingRowsDefaultCellStyle.BackColor = My.Settings.BackColorAlt
            '.DefaultCellStyle.BackColor = My.Settings.BackColor
            '.DefaultCellStyle.Font = My.Settings.RowFont
            '.ColumnHeadersDefaultCellStyle.Font = My.Settings.HeaderFont
            ' Establecer el origen de datos para el DataGridview   
            .DataSource = bs4
        End With

        'Me.BackColor = My.Settings.FormsBackColor
        'Me.lblelejir.BackColor = My.Settings.FormsBackColor
        'Me.GroupBox1.ForeColor = My.Settings.FontForeColor
        'Me.GroupBox1.Font = My.Settings.FontStyle
        'Me.txtCliente.BackColor = My.Settings.FormsBackColor
        'Me.CmdSalir.BackColor = My.Settings.FormsBackColor
        'Me.CmdVerVenta.BackColor = My.Settings.FormsBackColor
        'Me.CmdCliente.BackColor = My.Settings.FormsBackColor
        rbtVenta.Checked = True
        dtFechaFinal.Value = Now
        dtFechaInicial.Value = Now
        LblTotal.Text = "$0.00"
    End Sub

    Private Sub ImgSalirB_Click(sender As System.Object, e As System.EventArgs) Handles ImgSalirB.Click
        Me.Close()
        txtCliente.Text = ""
    End Sub

    Private Sub ImgSalirB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgSalirB.MouseLeave
        Me.ImgSalirA.Visible = True
        Me.ImgSalirB.Visible = False
    End Sub

    Private Sub ImgSalirA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgSalirA.MouseHover
        Me.ImgSalirB.Visible = True
        Me.ImgSalirA.Visible = False
    End Sub

    Private Sub ImgVentasB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgVentasB.MouseLeave
        Me.ImgVentasA.Visible = True
        Me.ImgVentasB.Visible = False
    End Sub

    Private Sub ImgVentasA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgVentasA.MouseHover
        Me.ImgVentasA.Visible = False
        Me.ImgVentasB.Visible = True
    End Sub

    Private Sub ImgBuscarB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgBuscarB.MouseLeave
        Me.ImgBuscarA.Visible = True
        Me.ImgBuscarB.Visible = False
    End Sub

    Private Sub ImgBuscarA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgBuscarA.MouseHover
        Me.ImgBuscarB.Visible = True
        Me.ImgBuscarA.Visible = False
    End Sub

    Private Sub ImgVentasB_Click(sender As System.Object, e As System.EventArgs) Handles ImgVentasB.Click

        LblTotal.Text = "$0.00"

        If rbtVenta.Checked = True Then
            SQL = "SELECT * FROM venta where idCliente = " & idClienteVenta & " and   fecha  >= '" & Format(dtFechaInicial.Value.Date, "yyyy-MM-dd") & "' and fecha <= '" & Format(dtFechaFinal.Value.Date, "yyyy-MM-dd") & "'"

        ElseIf rbtVentaPedido.Checked = True Then

            SQL = "SELECT * FROM venta_pedido where idCliente = " & idClienteVenta & " and   fecha  >= '" & Format(dtFechaInicial.Value.Date, "yyyy-MM-dd") & "' and fecha <= '" & Format(dtFechaFinal.Value.Date, "yyyy-MM-dd") & "'"

        ElseIf rdbCotizacion.Checked = True Then

            SQL = "SELECT * FROM cotizacion where idCliente = " & idClienteVenta & " and   fecha  >= '" & Format(dtFechaInicial.Value.Date, "yyyy-MM-dd") & "' and fecha <= '" & Format(dtFechaFinal.Value.Date, "yyyy-MM-dd") & "'"

        End If
        'Carga Lista de Clasificaciones
        load_record_dgv3(SQL, Me.DataGridView1, DBConnected)

        'Aplica formato al DataGridView
        load_layout_dgv_1(Me.DataGridView1)

        For i = 0 To DataGridView1.RowCount - 1
            LblTotal.Text = CDbl(LblTotal.Text) + CDbl(DataGridView1.Item(2, i).Value)
        Next
        LblTotal.Text = FormatCurrency(LblTotal.Text, 2)

    End Sub

    Private Sub ImgBuscarB_Click(sender As System.Object, e As System.EventArgs) Handles ImgBuscarB.Click
        Buscar_Clientes = "HISTORIAL"
        SetFormName(FrmBuscarClientesVentas, DBConnected)
        FrmBuscarClientesVentas.ShowDialog()
        FrmBuscarClientesVentas.Close()
        ImgVentasB.Select()
    End Sub
End Class