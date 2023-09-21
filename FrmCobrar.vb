Public Class FrmCobrar
    Dim lv_monto As Double = 0
    Dim lv_pago As Double = 0

    Private Sub FrmCobrar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                PagoContadoEfectuado = False
                Close()
        End Select
    End Sub

    Private Sub FrmCobrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PagoContadoEfectuado = False
        Dim lv_monto_venta As String = ""
        lv_monto_venta = FrmPuntoDeVenta.txtTotal.Text
        lv_monto_venta = Trim(lv_monto_venta.Replace("$", ""))
        lv_monto_venta = Trim(lv_monto_venta.Replace(" ", ""))
        lblmontoventa.Text = lv_monto_venta
        txtPago.SelectAll()
        txtPago.Clear()
        lblcambio.Text = "0.00"
    End Sub

    Private Sub txtPago_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPago.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnPagar_Click(sender, e)
        End If
    End Sub

    Private Sub txtPago_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPago.KeyPress
        e.Handled = True
        If e.KeyChar <> "." Then 'Allow "."'s before checking for Numerics   
            If IsNumeric(e.KeyChar) Then
                e.Handled = False 'Check for Numerics   
            End If
            If Asc(e.KeyChar) = 8 Then
                e.Handled = False
            End If
        Else
            If e.KeyChar = "." And txtPago.Text.Contains(".") Then e.KeyChar = CChar("") 'Check for Duplicate and Create Null if Yes   
            e.Handled = False
        End If
    End Sub

    Private Sub txtPago_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPago.TextChanged
        lv_monto = Val(Replace(lblmontoventa.Text, ",", ""))
        lv_pago = Val(txtPago.Text)

        If lv_monto > 0 Then
            lblcambio.Text = CStr(Math.Abs(lv_monto - lv_pago))
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        PagoContadoEfectuado = False
        Close()
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        Try
            lv_monto = Val(Replace(lblmontoventa.Text, ",", ""))
            lv_pago = Val(txtPago.Text)

            Dim lv_resultado As Double = 0
            If lv_pago >= lv_monto Then
                txtPago.SelectAll()
                lv_resultado = lv_pago - lv_monto
                lblcambio.Text = CStr(lv_resultado)
                Cambio = lblcambio.Text
                PV_Contado_Cambio = lblcambio.Text
                PV_Contado_Paga = CStr(lv_pago)
                PagoContadoEfectuado = True
                Close()
            ElseIf lv_pago < lv_monto Then
                MetroFramework.MetroMessageBox.Show(Me, "Monto de Venta no esta cubierto en su totalidad.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPago.Focus()
                txtPago.SelectAll()
                PV_Contado_Cambio = ""
                PV_Contado_Paga = ""
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class