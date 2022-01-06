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
        'Me.CmdSalir.BackColor = My.Settings.FormsBackColor
        'Me.CmdVentas.BackColor = My.Settings.FormsBackColor

        dtFechaFinal.Value = Now
        dtFechaInicial.Value = Now

    End Sub

    Private Sub DataGridConsulta_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridConsulta.CellClick
        'SQL = " select * from venta where nticket in (SELECT distinct folio FROM facturas where n_factura = '" & Me.DataGridConsulta.Item(0, DataGridConsulta.CurrentRow.Index).Value & "')"
        'Carga Lista de Clasificaciones
        'load_record_dgv2(SQL, Me.DataGridTikect, DBConnected)

        'Aplica formato al DataGridView
        'load_layout_dgv_ListaTickets(Me.DataGridTikect)
        DataGridTikect.DataSource = DBModelo.GetVenta(Me.DataGridConsulta.Item(0, DataGridConsulta.CurrentRow.Index).Value)
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

    Private Sub ImgVerFactB_Click(sender As System.Object, e As System.EventArgs) Handles ImgVerFactB.Click
        Dim x As List(Of tblFacturaTotal) = DBModelo.GetIntervalFacturas(dtFechaInicial.Value.Date, dtFechaFinal.Value.Date)
        DataGridConsulta.DataSource = x
        'Carga Lista de Clasificaciones
        'load_record_dgv(SQL, Me.DataGridConsulta, DBConnected)

        'Aplica formato al DataGridView
        'load_layout_dgv_ListaFactura_H(Me.DataGridConsulta)
    End Sub
End Class