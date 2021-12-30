Public Class FrmDescuento
    Dim desc As Double

    Private Sub NupCantidad_GotFocus(sender As Object, e As System.EventArgs) Handles NupCantidad.GotFocus
        NupCantidad.Select(0, NupCantidad.Value.ToString.Length + 3)
    End Sub
    Private Sub NupCantidad_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles NupCantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            NupPrecio.Focus()
            NupPrecio.Select(0, NupPrecio.Value.ToString.Length + 3)
        End If
    End Sub
    Private Sub FrmDescuento_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub FrmDescuento_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        NupCantidad.Focus()
        NupCantidad.Select(0, NupCantidad.Value.ToString.Length + 3)
    End Sub

    Private Sub NupPrecio_GotFocus(sender As Object, e As System.EventArgs) Handles NupPrecio.GotFocus
        NupPrecio.Select(0, NupPrecio.Value.ToString.Length + 3)
    End Sub

    Private Sub NupPrecio_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles NupPrecio.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            NupDescuento.Focus()
        End If
    End Sub

    Private Sub NupDescuento_ValueChanged(sender As Object, e As EventArgs) Handles NupDescuento.ValueChanged
        lblDesc.Text = NupDescuento.Value & " %"
    End Sub

    Private Sub lblSalir_Click(sender As Object, e As EventArgs) Handles lblSalir.Click
        Close()
    End Sub

    Private Sub lblAplicar_Click(sender As Object, e As EventArgs) Handles lblAplicar.Click
        desc = CDbl(NupDescuento.Value)

        If desc > 30 Or desc < 0 Then
            NupDescuento.Focus()
            desc = 0
        Else
            If (Not IsNumeric(NupCantidad.Value)) Then
                NupCantidad.Value = 0.0
            End If

            If (Not IsNumeric(desc)) Then
                NupDescuento.Value = 0.0
            End If

            If (Not IsNumeric(NupPrecio.Value)) Then
                NupPrecio.Value = 0.0
            End If

            FrmPuntoDeVenta.MetroGrid1.Rows(FrmPuntoDeVenta.MetroGrid1.CurrentRow.Index).Cells(0).Value = NupCantidad.Value
            FrmPuntoDeVenta.MetroGrid1.Rows(FrmPuntoDeVenta.MetroGrid1.CurrentRow.Index).Cells(3).Value = CDbl(NupPrecio.Value)
            FrmPuntoDeVenta.MetroGrid1.Rows(FrmPuntoDeVenta.MetroGrid1.CurrentRow.Index).Cells(4).Value = FrmPuntoDeVenta.MetroGrid1.Rows(FrmPuntoDeVenta.MetroGrid1.CurrentRow.Index).Cells(3).Value * FrmPuntoDeVenta.MetroGrid1.Rows(FrmPuntoDeVenta.MetroGrid1.CurrentRow.Index).Cells(0).Value
            FrmPuntoDeVenta.MetroGrid1.Rows(FrmPuntoDeVenta.MetroGrid1.CurrentRow.Index).Cells(6).Value = CDbl(desc)
            FrmPuntoDeVenta.MetroGrid1.Rows(FrmPuntoDeVenta.MetroGrid1.CurrentRow.Index).Cells(7).Value = FrmPuntoDeVenta.MetroGrid1.Rows(FrmPuntoDeVenta.MetroGrid1.CurrentRow.Index).Cells(3).Value - Math.Round((FrmPuntoDeVenta.MetroGrid1.Rows(FrmPuntoDeVenta.MetroGrid1.CurrentRow.Index).Cells(3).Value * CDbl(desc) / 100), 2)
            FrmPuntoDeVenta.MetroGrid1.Rows(FrmPuntoDeVenta.MetroGrid1.CurrentRow.Index).Cells(8).Value = FrmPuntoDeVenta.MetroGrid1.Rows(FrmPuntoDeVenta.MetroGrid1.CurrentRow.Index).Cells(7).Value * FrmPuntoDeVenta.MetroGrid1.Rows(FrmPuntoDeVenta.MetroGrid1.CurrentRow.Index).Cells(0).Value
            FrmPuntoDeVenta.MetroGrid1.Rows(FrmPuntoDeVenta.MetroGrid1.CurrentRow.Index).Cells(3).Value = CDbl(NupPrecio.Value)

            Dim lv_granSubTotal As Double = 0
            Dim lv_granIVA As Double = 0
            Dim lv_granTotal As Double = 0
            Dim lv_granSubTotal_TasaCero As Double = 0
            Dim lv_granIVA_TasaCero As Double = 0
            Dim lv_granTotal_TasaCero As Double = 0
            For i = 0 To FrmPuntoDeVenta.MetroGrid1.RowCount - 1
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
            FrmPuntoDeVenta.txtSubTotal.Text = Format(lv_granSubTotal, "0.00")
            FrmPuntoDeVenta.txtIVA.Text = Format(lv_granIVA, "0.00")
            FrmPuntoDeVenta.txtTotal.Text = Format(lv_granTotal, "0.00")
            FrmPuntoDeVenta.txtSubTotalTasaCero.Text = Format(lv_granSubTotal_TasaCero, "0.00")
            FrmPuntoDeVenta.txtIVATasaCero.Text = Format(lv_granIVA_TasaCero, "0.00")
            FrmPuntoDeVenta.txtTotalTasaCero.Text = Format(lv_granTotal_TasaCero, "0.00")
            desc = 0
            NupCantidad.Focus()
            NupCantidad.Select(0, NupCantidad.Value.ToString.Length)
            Me.Close()
        End If

    End Sub
End Class