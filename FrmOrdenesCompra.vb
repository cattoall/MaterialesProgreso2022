Imports MySql.Data.MySqlClient

Public Class frmOrdenesCompra

    Private Sub frmOrdenesCompra_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub OrdenesCompra_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
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
        'Me.Lblorden.BackColor = My.Settings.FormsBackColor
        'Me.GroupBox1.ForeColor = My.Settings.FontForeColor
        'Me.GroupBox1.Font = My.Settings.FontStyle
        'Me.Cmdreimprimir.BackColor = My.Settings.FormsBackColor
        'Me.CmdSalir.BackColor = My.Settings.FormsBackColor
        'Me.Cmdverventa.BackColor = My.Settings.FormsBackColor

        dpinicio.Value = Now
        dpfinal.Value = Now

    End Sub

    Private Sub Cmdverventa_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Cmdverventa.Click
        SQL = "SELECT * FROM ordencompra where fechaoc  >= '" & Format(dpinicio.Value.Date, "yyyy-MM-dd") & "' and fechaoc <= '" & Format(dpfinal.Value.Date, "yyyy-MM-dd") & "' order by ncompra, fechaoc asc"

        'Carga Lista de Clasificaciones
        load_record_dgv_ordenes(SQL, Me.DataGridView1, DBConnected)

        'Aplica formato al DataGridView
        load_layout_dgv_ordenes(Me.DataGridView1)
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As System.EventArgs) Handles DataGridView1.Click
        Lblorden.Text = Me.DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        SQL = "SELECT folio, cantidad, concepto, codigo FROM ordencomprades where folio = " & Me.DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value

        'Carga Lista de Clasificaciones
        load_record_dgv2_ordenes(SQL, Me.DataGridView2, DBConnected)

        'Aplica formato al DataGridView
        load_layout_dgv2_ordenes(Me.DataGridView2)
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

    Private Sub ImgSalirB_Click(sender As System.Object, e As System.EventArgs) Handles ImgSalirB.Click
        Me.Close()
    End Sub

    Private Sub Cmdreimprimir_Click(sender As System.Object, e As System.EventArgs) Handles Cmdreimprimir.Click

    End Sub
End Class