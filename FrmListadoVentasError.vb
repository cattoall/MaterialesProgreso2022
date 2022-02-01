Imports System.Data.SqlClient

Public Class FrmListadoVentasError
    Dim lv_fechaventa As Date
    Dim lv_fechalimite As Date

    Private Sub DataGridConsulta_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridConsulta.CellClick

        LblTotal.Text = Format(Me.DataGridConsulta.Item(2, DataGridConsulta.CurrentRow.Index).Value, "$ ###,###,###.00")
        LblNumTicket.Text = Me.DataGridConsulta.Item(0, DataGridConsulta.CurrentRow.Index).Value

        SQL = "SELECT diasCredito FROM clientes where clave = " & Me.DataGridConsulta.Item(6, DataGridConsulta.CurrentRow.Index).Value
        conn.Open()
        If conn.State = ConnectionState.Open Then
            myCommand = New SqlCommand(SQL, conn)
            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myDs)
            If myDs.Tables(0).Rows.Count > 0 Then
                lv_fechaventa = Me.DataGridConsulta.Item(1, DataGridConsulta.CurrentRow.Index).Value
                lv_fechalimite = lv_fechaventa.AddDays(myDs.Tables(0).Rows(0)!diasCredito)
            End If
        End If
        Limpia_Variables_SQL_y_Cierra_Conexion()

        If RbtTicket.Checked = True Then
            SQL = "SELECT folio,cantidad,concepto,precio,subtotal,clave_producto,idProducto,fecha,precioCosto,subtotalCosto,numeroFactura FROM ticket where folio = " & Me.DataGridConsulta.Item(0, DataGridConsulta.CurrentRow.Index).Value
        End If
        If RbtPedidos.Checked = True Then
            SQL = "SELECT folio,cantidad,concepto,precio,subtotal,clave_producto,idProducto,fecha,precioCosto,subtotalCosto,numeroFactura FROM ticket_pedido where folio = " & Me.DataGridConsulta.Item(0, DataGridConsulta.CurrentRow.Index).Value
        End If

        'Carga Lista de Clasificaciones
        'load_record_dgv2(SQL, Me.DataGridConsulta1, DBConnected)

        'Aplica formato al DataGridView
        load_layout_dgv_ListaVenta_i(Me.DataGridConsulta1)
    End Sub

    Private Sub FrmListadoVentasError_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                PagoContadoEfectuado = False
                Me.Close()
        End Select
    End Sub

    Private Sub FrmListadoVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bs.DataSource = Nothing
        dt.Clear()
        With Me.DataGridConsulta
            ' alternar color de filas
            '.AlternatingRowsDefaultCellStyle.BackColor = My.Settings.BackColorAlt
            '.DefaultCellStyle.BackColor = My.Settings.BackColor
            '.DefaultCellStyle.Font = My.Settings.RowFont
            '.ColumnHeadersDefaultCellStyle.Font = My.Settings.HeaderFont
            ' Establecer el origen de datos para el DataGridview   
            .DataSource = bs
        End With

        bs2.DataSource = Nothing
        dt2.Clear()
        With Me.DataGridConsulta1
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
        'Me.CmdCorregir.BackColor = My.Settings.FormsBackColor
        'Me.LblNumTicket.BackColor = My.Settings.FormsBackColor
        'Me.LblTotal.BackColor = My.Settings.FormsBackColor
    End Sub

    Private Sub CmdSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
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

    Private Sub ImgCorregirB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgCorregirB.MouseLeave
        Me.ImgCorregirA.Visible = True
        Me.ImgCorregirB.Visible = False
    End Sub

    Private Sub ImgCorregirA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgCorregirA.MouseHover
        Me.ImgCorregirA.Visible = False
        Me.ImgCorregirB.Visible = True
    End Sub

    Private Sub ImgSalirB_Click(sender As System.Object, e As System.EventArgs) Handles ImgSalirB.Click
        Me.Close()
    End Sub

End Class
