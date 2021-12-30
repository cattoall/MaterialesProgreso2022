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

    Private Sub ConfiguraGrid(ByRef dv As DataGridView)
        dv.Columns(0).Visible = False

        dv.Columns(1).HeaderText = "Ticket"
        dv.Columns(1).ReadOnly = True
        dv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(1).Width = 60
        dv.Columns(1).DisplayIndex = 2

        dv.Columns(2).HeaderText = "Total"
        dv.Columns(2).ReadOnly = True
        dv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dv.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(2).DefaultCellStyle.Format = "$ ###,###,##0.00"
        dv.Columns(2).Width = 100
        dv.Columns(2).DisplayIndex = 5

        dv.Columns(3).HeaderText = "Venta"
        dv.Columns(3).ReadOnly = True
        dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(3).Width = 80
        dv.Columns(3).DisplayIndex = 3

        dv.Columns(4).HeaderText = "Limite"
        dv.Columns(4).ReadOnly = True
        dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(4).Width = 80
        dv.Columns(4).DisplayIndex = 4

        dv.Columns(5).HeaderText = "Cliente"
        dv.Columns(5).ReadOnly = True
        dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dv.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(5).Width = 200
        dv.Columns(5).DisplayIndex = 1

        dv.Columns(6).HeaderText = "Resto"
        dv.Columns(6).ReadOnly = True
        dv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dv.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(6).DefaultCellStyle.Format = "$ ###,###,##0.00"
        dv.Columns(6).Width = 100
        dv.Columns(6).DisplayIndex = 6

        dv.Columns(7).Visible = False

        dv.Columns(8).HeaderText = "Docto"
        dv.Columns(8).ReadOnly = True
        dv.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(8).Width = 70
        dv.Columns(8).DisplayIndex = 7

        dv.Columns(9).Visible = False

    End Sub

    Private Sub CmdGenerarReporte_Click(sender As Object, e As EventArgs) Handles CmdGenerarReporte.Click

        Dim tCobrar As List(Of tblCobrar) = DBModelo.GetCobrarByDates(Format(dtinicio.Value.Date, "yyyy-MM-dd"), Format(dtfinal.Value.Date, "yyyy-MM-dd"))

        DataGridView1.Refresh()
        DataGridView1.DataSource = tCobrar.ToList()

        ConfiguraGrid(DataGridView1)

        lbltotal.Text = 0
        For i = 0 To DataGridView1.RowCount - 1
            lbltotal.Text = CDbl(lbltotal.Text) + CDbl(DataGridView1.Item(2, i).Value)
        Next
        lbltotal.Text = FormatCurrency(lbltotal.Text, 2)
    End Sub

    Private Sub CmdSalir_Click(sender As Object, e As EventArgs) Handles CmdSalir.Click
        Close()
        Dispose()
    End Sub

    Private Sub CmdImprimir_Click(sender As Object, e As EventArgs) Handles CmdImprimir.Click
        'If DataGridView1.RowCount > 0 Then
        '    dt.TableName = "deudores"

        '    Dim lv_fecha_inicio As String = Format(dtinicio.Value, "dd/MM/yyyy")
        '    Dim lv_fecha_final As String = Format(dtfinal.Value, "dd/MM/yyyy")

        '    ' Format(, "dd/MM/yyyy")
        '    Dim p1 As New Microsoft.Reporting.WinForms.ReportParameter("fecha_venta", lv_fecha_inicio.ToString)
        '    Dim p2 As New Microsoft.Reporting.WinForms.ReportParameter("fecha_limite", lv_fecha_final.ToString)
        '    Dim p3 As New Microsoft.Reporting.WinForms.ReportParameter("suma_resto", lbltotal.Text)

        '    FrmImpDeudores.ReportViewer1.LocalReport.SetParameters(p1)
        '    FrmImpDeudores.ReportViewer1.LocalReport.SetParameters(p2)
        '    FrmImpDeudores.ReportViewer1.LocalReport.SetParameters(p3)
        '    FrmImpDeudores.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        '    FrmImpDeudores.ReportViewer1.LocalReport.DataSources.Clear()
        '    FrmImpDeudores.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        '    FrmImpDeudores.ShowDialog()
        'Else
        '    MsgBox("Favor de ver un Reporte de una Fecha", MsgBoxStyle.Information, "Listado de Deudores")
        '    Exit Sub
        'End If
    End Sub
End Class