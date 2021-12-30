Public Class FrmGenerarAbono
    Dim lv_fecha As String

    Private Sub FrmGenerarAbono_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                Me.Close()
                txttotal.Text = ""
                txttotal.SelectAll()
        End Select
    End Sub
    Private Sub FrmGenerarAbono_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtventa.Text = venta

        lblresto.Text = resto
        lv_fecha = DateTime.Now.ToShortDateString()

        txttotal.Focus()
        RbnTotal.Checked = True
        Call RbnTotal_CheckedChanged(sender, e)
    End Sub

    Private Sub actualiza()
        Dim lv_resto As Double = 0
        total = Trim(Replace(total, "$", ""))
        total = Trim(Replace(total, ",", ""))
        total_nota = Trim(Replace(total_nota, "$", ""))
        total_nota = Trim(Replace(total_nota, ",", ""))
        lv_resto = (total - txttotal.Text)

        Dim w_cobrar As tblCobrar = DBModelo.Get_CobrarTipoDoc(Convert.ToInt32(txtventa.Text), tipodoc, idcliente)
        w_cobrar.resto = lv_resto

        If DBModelo.Update_Cobrar(w_cobrar) Then
        Else
            MsgBox("Error al Actualizar registro en Tabla COBRAR", MsgBoxStyle.Information, "Generar Abono a Cuenta")
            Exit Sub
        End If
    End Sub

    Private Sub txttotal_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txttotal.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmdCobrar_Click(sender, e)
        End If
    End Sub

    Private Sub txttotal_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txttotal.KeyPress
        e.Handled = True
        If e.KeyChar <> "." Then 'Allow "."'s before checking for Numerics   
            If IsNumeric(e.KeyChar) Then
                e.Handled = False 'Check for Numerics   
            End If
            If Asc(e.KeyChar) = 8 Then
                e.Handled = False
            End If
        Else
            If e.KeyChar = "." And txttotal.Text.Contains(".") Then e.KeyChar = "" 'Check for Duplicate and Create Null if Yes   
            e.Handled = False
        End If
    End Sub

    Private Sub RbnTotal_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbnTotal.CheckedChanged
        If RbnTotal.Checked = True Then
            txttotal.Text = resto
            txttotal.Text = Trim(Replace(txttotal.Text, "$", ""))
            txttotal.Text = Trim(Replace(txttotal.Text, ",", ""))
            txttotal.Enabled = False
        End If
    End Sub

    Private Sub RbnParcial_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbnParcial.CheckedChanged
        If RbnParcial.Checked = True Then
            txttotal.Text = "0.00"
            txttotal.Enabled = True
            txttotal.Focus()
            txttotal.SelectAll()
        End If
    End Sub

    Private Sub CmdCobrar_Click(sender As Object, e As EventArgs) Handles CmdCobrar.Click
        If IsNumeric(txttotal.Text) = False Then
            MsgBox("Introduce solo valores Numericos", MsgBoxStyle.Exclamation, "Mensaje de Informacion")
            txttotal.Text = ""
            txttotal.Focus()
            Exit Sub

        ElseIf txttotal.Text < 0 Then
            MsgBox("Introduce valor valido", MsgBoxStyle.Exclamation, "Mensaje de Informacion")
            txttotal.Text = ""
            txttotal.Focus()
            Exit Sub

        End If

        Dim motivo As String
        motivo = txtobservaciones.Text

        Dim theDate As Date = Now.Date
        lv_fecha = theDate.ToString("yyyy-MM-dd")

        Dim w_HistPago As tblHistorialPagos = New tblHistorialPagos

        w_HistPago.fecha = lv_fecha
        w_HistPago.numeroVenta = txtventa.Text
        w_HistPago.total = txttotal.Text
        w_HistPago.claveCliente = idcliente
        w_HistPago.cliente = cliente
        w_HistPago.observaciones = txtobservaciones.Text
        w_HistPago.tipoDocumento = tipodoc

        If DBModelo.InsertHistorialPago(w_HistPago) Then
            actualiza()
            MsgBox("Abono a Cuenta Generado Correctamente", MsgBoxStyle.Information, "Generar Abono a Cuenta")
            abono = txttotal.Text
            resto_total = resto_total - abono
            cuenta = txtventa.Text
            fecha = ""
            txtventa.Text = ""
            txttotal.Text = ""
            idcliente = ""
            cliente = ""
            txtobservaciones.Text = ""
            tipodoc = ""
            If ImprimeTicketAbono(cuenta, True, abono) = False Then
                MsgBox("Error al Generar la Impresión de la Cotización, favor de Re-Imprimir", MsgBoxStyle.Information)
                Exit Sub
            End If
            Call CmdSalir_Click(sender, e)
        Else
            MsgBox("Error al Insertar Registro en la Tabla HISTORIAL_PAGOS", MsgBoxStyle.Information, "Generar Abono a Cuenta")
            Exit Sub
        End If
    End Sub

    Private Sub CmdSalir_Click(sender As Object, e As EventArgs) Handles CmdSalir.Click
        txttotal.Text = ""
        txttotal.SelectAll()
        Me.Dispose()
        Me.Close()
    End Sub
End Class