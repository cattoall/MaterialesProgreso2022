Public Class FrmListadoDeudores

    Private Sub FrmListadoDeudores_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                Close()
                Dispose()
        End Select
    End Sub

    Private Sub FrmListadoDeudores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Refresh()

        dtinicio.Value = Now
        dtfinal.Value = Now
        lbltotal.Text = "$ 0.00"
    End Sub

    Private Sub ConfiguraGrid(ByRef dv As MetroFramework.Controls.MetroGrid)
        dv.Columns(0).Visible = False
        dv.Columns(1).Visible = False

        dv.Columns(1).HeaderText = "ID"
        dv.Columns(2).HeaderText = "No. Remisión"
        dv.Columns(3).HeaderText = "Total"
        dv.Columns(4).HeaderText = "Fecha de Venta"
        dv.Columns(5).HeaderText = "Fecha Límite"
        dv.Columns(6).HeaderText = "Cliente"
        dv.Columns(7).HeaderText = "Resto"
        dv.Columns(8).HeaderText = "Clave Cliente"
        dv.Columns(9).HeaderText = "Tipo Documento"
        dv.Columns(10).HeaderText = "Facturado"


        'dv.Columns(1).ReadOnly = True
        'dv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dv.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dv.Columns(1).Width = 60
        'dv.Columns(1).DisplayIndex = 2
        '
        'dv.Columns(2).ReadOnly = True
        'dv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'dv.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dv.Columns(2).DefaultCellStyle.Format = "$ ###,###,##0.00"
        'dv.Columns(2).Width = 100
        'dv.Columns(2).DisplayIndex = 5
        '
        'dv.Columns(3).ReadOnly = True
        'dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dv.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dv.Columns(3).Width = 80
        'dv.Columns(3).DisplayIndex = 3
        '
        'dv.Columns(4).ReadOnly = True
        'dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dv.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dv.Columns(4).Width = 80
        'dv.Columns(4).DisplayIndex = 4
        '
        'dv.Columns(5).ReadOnly = True
        'dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'dv.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dv.Columns(5).Width = 200
        'dv.Columns(5).DisplayIndex = 1
        '
        'dv.Columns(6).ReadOnly = True
        'dv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'dv.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dv.Columns(6).DefaultCellStyle.Format = "$ ###,###,##0.00"
        'dv.Columns(6).Width = 100
        'dv.Columns(6).DisplayIndex = 6
        '
        ''dv.Columns(7).Visible = False
        '
        'dv.Columns(7).ReadOnly = True
        'dv.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dv.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        'dv.Columns(7).Width = 70
        'dv.Columns(7).DisplayIndex = 7

        'dv.Columns(9).Visible = False

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        
        Dim tCobrar As List(Of tblCobrar) = DBModelo.GetCobrarByDates(Format(dtinicio.Value.Date, "yyyy-MM-dd"), Format(dtfinal.Value.Date, "yyyy-MM-dd"))

        DataGridView1.Refresh()
        DataGridView1.DataSource = tCobrar

        ConfiguraGrid(DataGridView1)

        lbltotal.Text = CStr(0)
        For i = 0 To DataGridView1.RowCount - 1
            lbltotal.Text = CStr(CDbl(lbltotal.Text) + CDbl(DataGridView1.Item(2, i).Value))
        Next
        lbltotal.Text = FormatCurrency(lbltotal.Text, 2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
        Dispose()
    End Sub
End Class