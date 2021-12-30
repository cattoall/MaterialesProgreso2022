Imports MySql.Data.MySqlClient

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
        txtventa.Enabled = False

        lblresto.Text = resto
        lv_fecha = DateTime.Now.ToShortDateString()


        'Me.BackColor = My.Settings.FormsBackColor
        'Me.lblresto.BackColor = My.Settings.FormsBackColor
        'Me.LblVenta.BackColor = My.Settings.FormsBackColor
        'Me.LblTotall.BackColor = My.Settings.FormsBackColor
        'Me.Lblobserbaciones.BackColor = My.Settings.FormsBackColor

        'Me.GroupBox1.ForeColor = My.Settings.FontForeColor
        'Me.GroupBox1.Font = My.Settings.FontStyle
        'Me.GroupBox2.ForeColor = My.Settings.FontForeColor
        'Me.GroupBox2.Font = My.Settings.FontStyle

        'Me.Cmdguardar.BackColor = My.Settings.FormsBackColor
        'Me.Cmdsalir.BackColor = My.Settings.FormsBackColor
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
        Sql1.Clear()
        Sql1.Append("UPDATE cobrar SET resto = ")
        Sql1.AppendFormat("{0} ", lv_resto)
        Sql1.Append("where n_remision = ")
        Sql1.AppendFormat("'{0}' ", txtventa.Text)
        Sql1.Append("and claveCliente = ")
        Sql1.AppendFormat("'{0}' ", idcliente)
        Sql1.Append("and tipoDocumento = ")
        Sql1.AppendFormat("'{0}' ", tipodoc)
        If Insertar_Registro(Sql1.ToString, DBConnected) = False Then
            MsgBox("Error al Actualizar registro en Tabla COBRAR", MsgBoxStyle.Information, "Generar Abono a Cuenta")
            Limpia_Variables_SQL_y_Cierra_Conexion()
            Exit Sub
        End If
        Limpia_Variables_SQL_y_Cierra_Conexion()
    End Sub

    Private Sub txttotal_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txttotal.KeyDown
        If e.KeyCode = Keys.Enter Then
            ImgAbonarB_Click(sender, e)
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

    Private Sub ImgSalirB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgSalirB.MouseLeave
        Me.ImgSalirA.Visible = True
        Me.ImgSalirB.Visible = False
    End Sub

    Private Sub ImgSalirA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgSalirA.MouseHover
        Me.ImgSalirB.Visible = True
        Me.ImgSalirA.Visible = False
    End Sub

    Private Sub ImgAbonarB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgAbonarB.MouseLeave
        Me.ImgAbonarA.Visible = True
        Me.ImgAbonarB.Visible = False
    End Sub

    Private Sub ImgAbonarA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgAbonarA.MouseHover
        Me.ImgAbonarB.Visible = True
        Me.ImgAbonarA.Visible = False
    End Sub

    Private Sub ImgSalirB_Click(sender As System.Object, e As System.EventArgs) Handles ImgSalirB.Click
        Me.Close()
        txttotal.Text = ""
        txttotal.SelectAll()
    End Sub

    Private Sub ImgAbonarB_Click(sender As System.Object, e As System.EventArgs) Handles ImgAbonarB.Click
        'resto = Trim(Replace(resto, "$", ""))
        'resto = Trim(Replace(resto, ",", ""))
        ''If txttotal.Text > resto Then
        '    MsgBox("El monto es Superior al Resto", MsgBoxStyle.Exclamation, "Mensaje de Informacion")
        '    txttotal.Focus()
        '    txttotal.SelectAll()
        '    Exit Sub
        'End If

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

        Sql1.Clear()
        Sql1.Append("INSERT INTO historial_pagos (fecha,numeroVenta,total,claveCliente,cliente,observaciones) values ( ")
        Sql1.AppendFormat("'{0}', ", lv_fecha)
        Sql1.AppendFormat("'{0}', ", txtventa.Text)
        Sql1.AppendFormat("'{0}', ", txttotal.Text)
        Sql1.AppendFormat("'{0}' ,", idcliente)
        Sql1.AppendFormat("'{0}' ,", cliente)
        Sql1.AppendFormat("'{0}' ", txtobservaciones.Text)
        Sql1.Append(" )")

        If Insertar_Registro(Sql1.ToString, DBConnected) = False Then
            MsgBox("Error al Insertar Registro en la Tabla HISTORIAL_PAGOS", MsgBoxStyle.Information, "Generar Abono a Cuenta")
            Limpia_Variables_SQL_y_Cierra_Conexion()
            Exit Sub
        End If
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
        Limpia_Variables_SQL_y_Cierra_Conexion()
        Me.Close()
        If ImprimeTicketAbono(cuenta, True, abono, DBConnected) = False Then
            MsgBox("Error al Generar la Impresión de la Cotización, favor de Re-Imprimir", MsgBoxStyle.Information)
            Limpia_Variables_SQL_y_Cierra_Conexion()
            Exit Sub
        End If
        'Frmimprimirticketvb.ShowDialog()
    End Sub
End Class