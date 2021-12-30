Imports MySql.Data.MySqlClient

Public Class FrmListadoDeudores

    Private Sub FrmListadoDeudores_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub FrmListadoDeudores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bs.DataSource = Nothing
        dt.Clear()
        With Me.DataGridView1
            ' alternar color de filas
            '.AlternatingRowsDefaultCellStyle.BackColor = My.Settings.BackColorAlt
            '.DefaultCellStyle.BackColor = My.Settings.BackColor
            '.DefaultCellStyle.Font = My.Settings.RowFont
            '.ColumnHeadersDefaultCellStyle.Font = My.Settings.HeaderFont
            ' Establecer el origen de datos para el DataGridview   
            .DataSource = bs
        End With

        'Me.BackColor = My.Settings.FormsBackColor
        'Me.lbltotal.BackColor = My.Settings.FormsBackColor
        'Me.GroupBox1.ForeColor = My.Settings.FontForeColor
        'Me.GroupBox1.Font = My.Settings.FontStyle
        'Me.CmdSalir.BackColor = My.Settings.FormsBackColor
        'Me.CmdVentas.BackColor = My.Settings.FormsBackColor
        'Me.CmdVerReporte.BackColor = My.Settings.FormsBackColor

        dtinicio.Value = Now
        dtfinal.Value = Now
        lbltotal.Text = "$ 0.00"

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

    Private Sub ImgReImpB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgReImpB.MouseLeave
        Me.ImgReImpA.Visible = True
        Me.ImgReImpB.Visible = False
    End Sub

    Private Sub ImgReImpA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgReImpA.MouseHover
        Me.ImgReImpB.Visible = True
        Me.ImgReImpA.Visible = False
    End Sub

    Private Sub ImgVerReporteB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgVerReporteB.MouseLeave
        Me.ImgVerReporteA.Visible = True
        Me.ImgVerReporteB.Visible = False
    End Sub

    Private Sub ImgVerReporteA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgVerReporteA.MouseHover
        Me.ImgVerReporteB.Visible = True
        Me.ImgVerReporteA.Visible = False
    End Sub

    Private Sub ImgVerReporteB_Click(sender As System.Object, e As System.EventArgs) Handles ImgVerReporteB.Click
        SQL = "SELECT cliente,n_remision, total,resto, fecha_venta, fecha_limite, tipoDocumento FROM cobrar where (fecha_limite between '" & Format(dtinicio.Value.Date, "yyyy-MM-dd") & "' and   '" & Format(dtfinal.Value.Date, "yyyy-MM-dd") & "') AND resto > 0"

        'Carga Lista de Clasificaciones
        load_record_dgv(SQL, Me.DataGridView1, DBConnected)

        'Aplica formato al DataGridView
        load_layout_dgv_ListaVenta_Deudores(Me.DataGridView1)

        lbltotal.Text = 0
        For i = 0 To DataGridView1.RowCount - 1
            lbltotal.Text = CDbl(lbltotal.Text) + CDbl(DataGridView1.Item(3, i).Value)
        Next
        lbltotal.Text = FormatCurrency(lbltotal.Text, 2)
    End Sub

    Private Sub ImgReImpB_Click(sender As System.Object, e As System.EventArgs) Handles ImgReImpB.Click
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