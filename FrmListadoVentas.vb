Imports MySql.Data.MySqlClient

Public Class FrmListadoVentas

    Private Sub DataGridConsulta_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridConsulta.CellClick

        LblNumTicket.Visible = True
        LblTotal.Text = Format(Me.DataGridConsulta.Item(4, DataGridConsulta.CurrentRow.Index).Value, "$ ###,###,###.00")
        LblNumTicket.Text = Me.DataGridConsulta.Item(0, DataGridConsulta.CurrentRow.Index).Value
        NoFactura = Me.DataGridConsulta.Item(0, DataGridConsulta.CurrentRow.Index).Value
        SQL = "SELECT * FROM ticket where folio = " & Me.DataGridConsulta.Item(0, DataGridConsulta.CurrentRow.Index).Value

        'Carga Lista de Clasificaciones
        load_record_dgv2(SQL, Me.DataGridTikect, DBConnected)

        'Aplica formato al DataGridView
        load_layout_dgv_ListaVenta_i(Me.DataGridTikect)
    End Sub

    Private Sub FrmListadoVentas_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
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
        'Me.LblNumTicket.BackColor = My.Settings.FormsBackColor
        'Me.LblTotal.BackColor = My.Settings.FormsBackColor
        dtFechaFinal.Value = Now
        dtFechaInicial.Value = Now
        LblNumTicket.Text = ""
        LblNumTicket.Visible = False
        LblTotal.Text = "$ 0.00"
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

    Private Sub ImgVentasB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgVentasB.MouseLeave
        Me.ImgVentasA.Visible = True
        Me.ImgVentasB.Visible = False
    End Sub

    Private Sub ImgVentasA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgVentasA.MouseHover
        Me.ImgVentasA.Visible = False
        Me.ImgVentasB.Visible = True
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

    Public Sub ImgVentasB_Click(sender As System.Object, e As System.EventArgs) Handles ImgVentasB.Click
        SQL = "SELECT * FROM venta where  fecha  >= '" & Format(dtFechaInicial.Value.Date, "yyyy-MM-dd") & "' and fecha <= '" & Format(dtFechaFinal.Value.Date, "yyyy-MM-dd") & "' order by nticket, fecha asc"

        'Carga Lista de Clasificaciones
        load_record_dgv(SQL, Me.DataGridConsulta, DBConnected)

        'Aplica formato al DataGridView
        load_layout_dgv_ListaVenta_h(Me.DataGridConsulta)
    End Sub

    Private Sub ImgReImpB_Click(sender As System.Object, e As System.EventArgs) Handles ImgReImpB.Click
        If LblNumTicket.Text <> "" Then
            Dim lv_result As Boolean = False
            If MsgBox("¿Deseas Imprimir el Ticket?", MsgBoxStyle.YesNo, "Re-Impresiones de Tickets") = MsgBoxResult.Yes Then
                lv_result = True
            End If

            If ReImprimeVenta(LblNumTicket.Text, lv_result, "TICKET", DataGridConsulta.Item(2, DataGridConsulta.CurrentRow.Index).Value, "0.00", DBConnected) = False Then
                MsgBox("Error al Generar la Impresión del Ticket", MsgBoxStyle.Information, "Impresión de Ticket")
                Limpia_Variables_SQL_y_Cierra_Conexion()
                Exit Sub
            End If
        Else
            MsgBox("Favor de seleccionar una venta.", MsgBoxStyle.Critical, "Impresión de Ticket")
        End If
        Limpia_Variables_SQL_y_Cierra_Conexion()
    End Sub

    Private Sub ImgCancelarB_Click(sender As System.Object, e As System.EventArgs) Handles ImgCancelarB.Click
        If LblNumTicket.Text <> "" Then
            Cancelar = 2
            FrmCancelarPedido.ShowDialog()
            Cancelar = ""
        Else
            MsgBox("Seleccione Una Venta Para Cancelar", MsgBoxStyle.Critical, "Cancelar Venta")
        End If
    End Sub

End Class
