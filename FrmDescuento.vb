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
            txtPorcentaje.Focus()
        End If
    End Sub

    Private Sub txtPorcentaje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPorcentaje.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtPorcentaje_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPorcentaje.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnAplicar_Click(sender, e)
        End If
    End Sub

    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        desc = CDbl(txtPorcentaje.Text)

        If desc > 30 Or desc < 0 Then
            txtPorcentaje.Focus()
            desc = 0
        Else
            If (Not IsNumeric(NupCantidad.Value)) Then
                NupCantidad.Value = CDec(0.0)
            End If

            If (Not IsNumeric(desc)) Then
                txtPorcentaje.Text = CStr(0)
            End If

            If (Not IsNumeric(NupPrecio.Value)) Then
                NupPrecio.Value = CDec(0.0)
            End If

            FrmPuntoDeVenta.DataGridView1.Rows(FrmPuntoDeVenta.DataGridView1.CurrentRow.Index).Cells(0).Value = NupCantidad.Value
            FrmPuntoDeVenta.DataGridView1.Rows(FrmPuntoDeVenta.DataGridView1.CurrentRow.Index).Cells(3).Value = CDbl(NupPrecio.Value)
            FrmPuntoDeVenta.DataGridView1.Rows(FrmPuntoDeVenta.DataGridView1.CurrentRow.Index).Cells(4).Value = CDbl(FrmPuntoDeVenta.DataGridView1.Rows(FrmPuntoDeVenta.DataGridView1.CurrentRow.Index).Cells(3).Value) * CDbl(FrmPuntoDeVenta.DataGridView1.Rows(FrmPuntoDeVenta.DataGridView1.CurrentRow.Index).Cells(0).Value)
            FrmPuntoDeVenta.DataGridView1.Rows(FrmPuntoDeVenta.DataGridView1.CurrentRow.Index).Cells(6).Value = desc
            FrmPuntoDeVenta.DataGridView1.Rows(FrmPuntoDeVenta.DataGridView1.CurrentRow.Index).Cells(7).Value = CDbl(FrmPuntoDeVenta.DataGridView1.Rows(FrmPuntoDeVenta.DataGridView1.CurrentRow.Index).Cells(3).Value) - Math.Round(CDbl(FrmPuntoDeVenta.DataGridView1.Rows(FrmPuntoDeVenta.DataGridView1.CurrentRow.Index).Cells(3).Value) * CDbl(desc) / 100, 2)
            FrmPuntoDeVenta.DataGridView1.Rows(FrmPuntoDeVenta.DataGridView1.CurrentRow.Index).Cells(8).Value = CDbl(FrmPuntoDeVenta.DataGridView1.Rows(FrmPuntoDeVenta.DataGridView1.CurrentRow.Index).Cells(7).Value) * CDbl(FrmPuntoDeVenta.DataGridView1.Rows(FrmPuntoDeVenta.DataGridView1.CurrentRow.Index).Cells(0).Value)
            FrmPuntoDeVenta.DataGridView1.Rows(FrmPuntoDeVenta.DataGridView1.CurrentRow.Index).Cells(3).Value = CDbl(NupPrecio.Value)

            Dim lv_granSubTotal As Double = 0
            Dim lv_granIVA As Double = 0
            Dim lv_granTotal As Double = 0
            Dim lv_granSubTotal_TasaCero As Double = 0
            Dim lv_granIVA_TasaCero As Double = 0
            Dim lv_granTotal_TasaCero As Double = 0
            For i = 0 To FrmPuntoDeVenta.DataGridView1.RowCount - 1
                Dim lv_total As Double = CDbl(FrmPuntoDeVenta.DataGridView1.Rows(i).Cells(8).Value)
                lv_granSubTotal = lv_granSubTotal + lv_total
                If CBool(FrmPuntoDeVenta.DataGridView1.Rows(i).Cells(13).Value) = False Then
                    lv_granIVA = lv_granIVA + CDbl(FormatNumber(lv_total * (CDbl(FactorIVA) - 1), 10))
                    lv_granTotal = lv_granTotal + CDbl(FormatNumber(lv_total + (lv_total * (CDbl(FactorIVA) - 1))))
                    gv_tasa_16 = True
                Else
                    lv_granTotal = lv_granTotal + CDbl(lv_total)
                    lv_granTotal_TasaCero = lv_granTotal_TasaCero + CDbl(lv_total)
                    lv_granSubTotal_TasaCero = lv_granSubTotal_TasaCero + lv_total
                    gv_tasa_0 = True
                End If
            Next
            FrmPuntoDeVenta.txtSubTotal.Text = FormatNumber(lv_granSubTotal, 6)
            FrmPuntoDeVenta.txtIVA.Text = FormatNumber(lv_granIVA, 6)
            FrmPuntoDeVenta.txtTotal.Text = FormatNumber(lv_granTotal, 2)
            FrmPuntoDeVenta.txtSubTotalTasaCero.Text = FormatNumber(lv_granSubTotal_TasaCero, 6)
            FrmPuntoDeVenta.txtIVATasaCero.Text = FormatNumber(lv_granIVA_TasaCero, 6)
            FrmPuntoDeVenta.txtTotalTasaCero.Text = FormatNumber(lv_granTotal_TasaCero, 2)
            desc = 0
            NupCantidad.Focus()
            NupCantidad.Select(0, NupCantidad.Value.ToString.Length)
            Close()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class