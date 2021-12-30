Public Class FrmDescuentoGeneral
    Dim desc As Double

    Private Sub FrmDescuentoGeneral_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub FrmDescuentoGeneral_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblDesc.Text = mtbDesc.Value
    End Sub

    Private Sub lblEsc_Click(sender As System.Object, e As System.EventArgs) Handles lblEsc.Click
        Close()
    End Sub

    Private Sub mtbDesc_ValueChanged(sender As Object, e As EventArgs) Handles mtbDesc.ValueChanged
        lblDesc.Text = mtbDesc.Value & " %"
    End Sub

    Private Sub mlAplicar_Click(sender As Object, e As EventArgs) Handles mlAplicar.Click
        desc = CDbl(mtbDesc.Value)
        If desc > 30 Or desc < 0 Then
            desc = 0
        Else
            Dim lv_granSubTotal As Double = 0
            Dim lv_granIVA As Double = 0
            Dim lv_granTotal As Double = 0
            Dim lv_granSubTotal_TasaCero As Double = 0
            Dim lv_granIVA_TasaCero As Double = 0
            Dim lv_granTotal_TasaCero As Double = 0
            For i = 0 To FrmPuntoDeVenta.MetroGrid1.RowCount - 1
                Dim lv_col0 = FrmPuntoDeVenta.MetroGrid1.Rows(i).Cells(0).Value

                Dim lv_col3 = FrmPuntoDeVenta.MetroGrid1.Rows(i).Cells(3).Value

                FrmPuntoDeVenta.MetroGrid1.Rows(i).Cells(4).Value = CDbl(lv_col3) * CDbl(lv_col0)
                FrmPuntoDeVenta.MetroGrid1.Rows(i).Cells(6).Value = CDbl(desc)
                FrmPuntoDeVenta.MetroGrid1.Rows(i).Cells(7).Value = CDbl(lv_col3) - Math.Round((CDbl(lv_col3) * CDbl(desc) / 100), 2)
                FrmPuntoDeVenta.MetroGrid1.Rows(i).Cells(8).Value = FrmPuntoDeVenta.MetroGrid1.Rows(i).Cells(7).Value * CDbl(lv_col0)

                Dim lv_total = FrmPuntoDeVenta.MetroGrid1.Rows(i).Cells(8).Value
                lv_granSubTotal = lv_granSubTotal + lv_total
                If FrmPuntoDeVenta.MetroGrid1.Rows(i).Cells(13).Value = False Then
                    lv_granIVA = lv_granIVA + FormatNumber((lv_total * (FactorIVA - 1)), 2)
                    lv_granTotal = lv_granTotal + FormatNumber((lv_total + (lv_total * (FactorIVA - 1))))
                    gv_tasa_16 = True
                Else
                    lv_granTotal = lv_granTotal + FormatNumber(lv_total, 2)
                    lv_granTotal_TasaCero = lv_granTotal_TasaCero + FormatNumber(lv_total, 2)
                    lv_granSubTotal_TasaCero = lv_granSubTotal_TasaCero + lv_total
                    gv_tasa_0 = True
                End If
            Next
            FrmPuntoDeVenta.txtSubTotal.Text = Format(lv_granSubTotal, "###,###,##0.00")
            FrmPuntoDeVenta.txtIVA.Text = Format(lv_granIVA, "###,###,##0.00")
            FrmPuntoDeVenta.txtTotal.Text = Format(lv_granTotal, "0.00")
            FrmPuntoDeVenta.txtSubTotalTasaCero.Text = Format(lv_granSubTotal_TasaCero, "###,###,##0.00")
            FrmPuntoDeVenta.txtIVATasaCero.Text = Format(lv_granIVA_TasaCero, "###,###,##0.00")
            FrmPuntoDeVenta.txtTotalTasaCero.Text = Format(lv_granTotal_TasaCero, "0.00")
        End If
        Close()
    End Sub
End Class