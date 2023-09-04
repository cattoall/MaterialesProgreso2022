
Imports System.Data.SqlClient

Public Class FrmClientesWendy
    Public lv_idCliente As Integer

    Private Sub CmdSalir_Click(sender As System.Object, e As System.EventArgs) Handles CmdSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Add_Update = False Then
            BtnEliminar.Visible = False
        Else
            BtnEliminar.Visible = True
        End If
        txtNombre.Select()
    End Sub

    Private Sub txtNombre_GotFocus(sender As Object, e As System.EventArgs) Handles txtNombre.GotFocus
        txtNombre.SelectAll()
    End Sub

    Private Sub txtNombre_LostFocus(sender As Object, e As System.EventArgs) Handles txtNombre.LostFocus
        txtNombre.BackColor = Color.Empty
    End Sub

    Private Sub txtNombre_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtApat_GotFocus(sender As Object, e As System.EventArgs) Handles txtApat.GotFocus
        txtApat.SelectAll()
    End Sub

    Private Sub txtApat_LostFocus(sender As Object, e As System.EventArgs) Handles txtApat.LostFocus
        txtApat.BackColor = Color.Empty
    End Sub

    Private Sub txtApat_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtApat.TextChanged

    End Sub

    Private Sub txtAmat_GotFocus(sender As Object, e As System.EventArgs) Handles txtAmat.GotFocus
        txtAmat.SelectAll()
    End Sub

    Private Sub txtAmat_LostFocus(sender As Object, e As System.EventArgs) Handles txtAmat.LostFocus
        txtAmat.BackColor = Color.Empty
    End Sub

    Private Sub txtAmat_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAmat.TextChanged

    End Sub

    Private Sub txtDomicilio_GotFocus(sender As Object, e As System.EventArgs) Handles txtDomicilio.GotFocus
        txtDomicilio.SelectAll()
    End Sub

    Private Sub txtDomicilio_LostFocus(sender As Object, e As System.EventArgs) Handles txtDomicilio.LostFocus
        txtDomicilio.BackColor = Color.Empty
    End Sub

    Private Sub txtDomicilio_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDomicilio.TextChanged

    End Sub

    Private Sub txtNumExterno_GotFocus(sender As Object, e As System.EventArgs) Handles txtNumExterno.GotFocus
        txtNumExterno.SelectAll()
    End Sub

    Private Sub txtNumExterno_LostFocus(sender As Object, e As System.EventArgs) Handles txtNumExterno.LostFocus
        txtNumExterno.BackColor = Color.Empty
    End Sub

    Private Sub txtNumExterno_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNumExterno.TextChanged

    End Sub

    Private Sub txtColonia_GotFocus(sender As Object, e As System.EventArgs) Handles txtColonia.GotFocus
        txtColonia.SelectAll()
    End Sub

    Private Sub txtColonia_LostFocus(sender As Object, e As System.EventArgs) Handles txtColonia.LostFocus
        txtColonia.BackColor = Color.Empty
    End Sub

    Private Sub txtColonia_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtColonia.TextChanged

    End Sub

    Private Sub txtCiudad_GotFocus(sender As Object, e As System.EventArgs) Handles txtCiudad.GotFocus
        txtCiudad.SelectAll()
    End Sub

    Private Sub txtCiudad_LostFocus(sender As Object, e As System.EventArgs) Handles txtCiudad.LostFocus
        txtCiudad.BackColor = Color.Empty
    End Sub

    Private Sub txtCiudad_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCiudad.TextChanged

    End Sub

    Private Sub txtEstado_GotFocus(sender As Object, e As System.EventArgs) Handles txtEstado.GotFocus
        txtEstado.SelectAll()
    End Sub

    Private Sub txtEstado_LostFocus(sender As Object, e As System.EventArgs) Handles txtEstado.LostFocus
        txtEstado.BackColor = Color.Empty
    End Sub

    Private Sub txtEstado_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEstado.TextChanged

    End Sub

    Private Sub txtCodigoPostal_GotFocus(sender As Object, e As System.EventArgs) Handles txtCodigoPostal.GotFocus
        txtCodigoPostal.SelectAll()
    End Sub

    Private Sub txtCodigoPostal_LostFocus(sender As Object, e As System.EventArgs) Handles txtCodigoPostal.LostFocus
        txtCodigoPostal.BackColor = Color.Empty
    End Sub

    Private Sub txtCodigoPostal_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCodigoPostal.TextChanged

    End Sub

    Private Sub txtRFC_GotFocus(sender As Object, e As System.EventArgs) Handles txtRFC.GotFocus
        txtRFC.SelectAll()
    End Sub

    Private Sub txtRFC_LostFocus(sender As Object, e As System.EventArgs) Handles txtRFC.LostFocus
        txtRFC.BackColor = Color.Empty
    End Sub

    Private Sub txtRFC_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtRFC.TextChanged

    End Sub

    Private Sub txtTelFijo_GotFocus(sender As Object, e As System.EventArgs) Handles txtTelFijo.GotFocus
        txtTelFijo.SelectAll()
    End Sub

    Private Sub txtTelFijo_LostFocus(sender As Object, e As System.EventArgs) Handles txtTelFijo.LostFocus
        txtTelFijo.BackColor = Color.Empty
    End Sub

    Private Sub txtTelFijo_MaskInputRejected(sender As System.Object, e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtTelFijo.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox1_GotFocus(sender As Object, e As System.EventArgs) Handles txtMovil.GotFocus
        txtMovil.SelectAll()
    End Sub

    Private Sub MaskedTextBox1_LostFocus(sender As Object, e As System.EventArgs) Handles txtMovil.LostFocus
        txtMovil.BackColor = Color.Empty
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As System.Object, e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtMovil.MaskInputRejected

    End Sub

    Private Sub txtEmail_GotFocus(sender As Object, e As System.EventArgs) Handles txtEmail.GotFocus
        txtEmail.SelectAll()
    End Sub

    Private Sub txtEmail_LostFocus(sender As Object, e As System.EventArgs) Handles txtEmail.LostFocus
        txtEmail.BackColor = Color.Empty
    End Sub

    Private Sub txtEmail_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub txtCredito_GotFocus(sender As Object, e As System.EventArgs) Handles txtCredito.GotFocus
        txtCredito.SelectAll()
    End Sub

    Private Sub txtCredito_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCredito.KeyDown
    End Sub

    Private Sub txtCredito_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCredito.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCredito_LostFocus(sender As Object, e As System.EventArgs) Handles txtCredito.LostFocus
        txtCredito.BackColor = Color.Empty
    End Sub

    Private Sub txtLimite_GotFocus(sender As Object, e As System.EventArgs) Handles txtLimite.GotFocus
        txtLimite.SelectAll()
    End Sub

    Private Sub txtLimite_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtLimite.KeyPress
        e.Handled = True
        If e.KeyChar <> "." Then 'Allow "."'s before checking for Numerics   
            If IsNumeric(e.KeyChar) Then
                e.Handled = False 'Check for Numerics   
            End If
            If Asc(e.KeyChar) = 8 Then
                e.Handled = False
            End If
        Else
            If e.KeyChar = "." And txtLimite.Text.Contains(".") Then e.KeyChar = CChar("") 'Check for Duplicate and Create Null if Yes   
            e.Handled = False
        End If
    End Sub

    Private Sub txtLimite_LostFocus(sender As Object, e As System.EventArgs) Handles txtLimite.LostFocus
        txtLimite.BackColor = Color.Empty
    End Sub

    Private Sub txtLimite_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtLimite.TextChanged

    End Sub

    Private Sub CmbPrecio_GotFocus(sender As Object, e As System.EventArgs) Handles CmbPrecio.GotFocus
        CmbPrecio.SelectAll()
    End Sub

    Private Sub CmbPrecio_LostFocus(sender As Object, e As System.EventArgs) Handles CmbPrecio.LostFocus
        CmbPrecio.BackColor = Color.Empty
    End Sub

    Private Sub CmbPrecio_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CmbPrecio.SelectedIndexChanged

    End Sub

    Private Sub txtObs_GotFocus(sender As Object, e As System.EventArgs) Handles txtObs.GotFocus
        txtObs.SelectAll()
    End Sub

    Private Sub txtObs_LostFocus(sender As Object, e As System.EventArgs) Handles txtObs.LostFocus
        txtObs.BackColor = Color.Empty
    End Sub

    Private Sub txtObs_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtObs.TextChanged

    End Sub

    Private Sub CmdGuardar_Click(sender As System.Object, e As System.EventArgs) Handles CmdGuardar.Click
        Try
            If Add_Update = False Then
                Sql1.Clear()
                Sql1.Append("INSERT INTO clientes (nombre, apat, amat, calle, numero, colonia, ciudad, estado,")
                Sql1.Append("cp, rfc, telefono, celular, correo, observaciones, listaprecios, diascredito, limitecredito) values ( ")
                Sql1.AppendFormat("'{0}', ", txtNombre.Text)
                Sql1.AppendFormat("'{0}', ", txtApat.Text)
                Sql1.AppendFormat("'{0}', ", txtAmat.Text)
                Sql1.AppendFormat("'{0}', ", txtDomicilio.Text)
                Sql1.AppendFormat("'{0}', ", txtNumExterno.Text)
                Sql1.AppendFormat("'{0}', ", txtColonia.Text)
                Sql1.AppendFormat("'{0}', ", txtCiudad.Text)
                Sql1.AppendFormat("'{0}', ", txtEstado.Text)
                Sql1.AppendFormat("'{0}', ", txtCodigoPostal.Text)
                Sql1.AppendFormat("'{0}', ", txtRFC.Text)
                Sql1.AppendFormat("'{0}', ", txtTelFijo.Text)
                Sql1.AppendFormat("'{0}', ", txtMovil.Text)
                Sql1.AppendFormat("'{0}', ", txtEmail.Text)
                Sql1.AppendFormat("'{0}', ", txtObs.Text)
                Sql1.AppendFormat("'{0}', ", CmbPrecio.Text)
                Sql1.AppendFormat("{0}, ", CInt(txtCredito.Text))
                Sql1.AppendFormat("{0} ", CDbl(txtLimite.Text))
                Sql1.Append(" )")
            Else
                Sql1.Clear()
                Sql1.Append("UPDATE clientes SET nombre = ")
                Sql1.AppendFormat("'{0}', ", txtNombre.Text)
                Sql1.Append("apat = ")
                Sql1.AppendFormat("'{0}', ", txtApat.Text)
                Sql1.Append("amat = ")
                Sql1.AppendFormat("'{0}', ", txtAmat.Text)
                Sql1.Append("calle = ")
                Sql1.AppendFormat("'{0}', ", txtDomicilio.Text)
                Sql1.Append("numero = ")
                Sql1.AppendFormat("'{0}', ", txtNumExterno.Text)
                Sql1.Append("colonia = ")
                Sql1.AppendFormat("'{0}', ", txtColonia.Text)
                Sql1.Append("ciudad = ")
                Sql1.AppendFormat("'{0}', ", txtCiudad.Text)
                Sql1.Append("estado = ")
                Sql1.AppendFormat("'{0}', ", txtEstado.Text)
                Sql1.Append("cp = ")
                Sql1.AppendFormat("'{0}', ", txtCodigoPostal.Text)
                Sql1.Append("rfc = ")
                Sql1.AppendFormat("'{0}', ", txtRFC.Text)
                Sql1.Append("telefono = ")
                Sql1.AppendFormat("'{0}', ", txtTelFijo.Text)
                Sql1.Append("celular = ")
                Sql1.AppendFormat("'{0}', ", txtMovil.Text)
                Sql1.Append("correo = ")
                Sql1.AppendFormat("'{0}', ", txtEmail.Text)
                Sql1.Append("observaciones = ")
                Sql1.AppendFormat("'{0}', ", txtObs.Text)
                Sql1.Append("listaprecios = ")
                Sql1.AppendFormat("'{0}', ", CmbPrecio.Text)
                Sql1.Append("diascredito = ")
                Sql1.AppendFormat("{0}, ", CInt(txtCredito.Text))
                Sql1.Append("limitecredito = ")
                Sql1.AppendFormat("{0} ", CDbl(txtLimite.Text))
                Sql1.Append("where clave = ")
                Sql1.AppendFormat("{0} ", lv_idCliente)
            End If
            conn.Open()
            If conn.State = ConnectionState.Open Then
                myCommand = New SqlCommand(Sql1.ToString, conn)
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDs)
                If Add_Update = False Then
                    MsgBox("Cliente creado correctamente.", MsgBoxStyle.Information)
                Else

                    Limpia_Variables_SQL()

                    Sql1.Clear()
                    Sql1.Append("UPDATE cotizacion SET Cliente = ")
                    Sql1.AppendFormat("'{0}' ", txtNombre.Text & " " & txtApat.Text & " " & txtAmat.Text)
                    Sql1.Append("where idcliente = ")
                    Sql1.AppendFormat("{0}", lv_idCliente)
                    myCommand = New SqlCommand(Sql1.ToString, conn)
                    myAdapter.SelectCommand = myCommand
                    myAdapter.Fill(myDs)

                    Limpia_Variables_SQL()

                    Sql1.Clear()
                    Sql1.Append("UPDATE venta SET Cliente = ")
                    Sql1.AppendFormat("'{0}' ", txtNombre.Text & " " & txtApat.Text & " " & txtAmat.Text)
                    Sql1.Append("where idcliente = ")
                    Sql1.AppendFormat("{0}", lv_idCliente)
                    myCommand = New SqlCommand(Sql1.ToString, conn)
                    myAdapter.SelectCommand = myCommand
                    myAdapter.Fill(myDs)

                    Limpia_Variables_SQL()

                    Sql1.Clear()
                    Sql1.Append("UPDATE venta_pedido SET Cliente = ")
                    Sql1.AppendFormat("'{0}' ", txtNombre.Text & " " & txtApat.Text & " " & txtAmat.Text)
                    Sql1.Append("where idcliente = ")
                    Sql1.AppendFormat("{0}", lv_idCliente)
                    myCommand = New SqlCommand(Sql1.ToString, conn)
                    myAdapter.SelectCommand = myCommand
                    myAdapter.Fill(myDs)

                    Limpia_Variables_SQL()

                    Sql1.Clear()
                    Sql1.Append("UPDATE cobrar SET Cliente = ")
                    Sql1.AppendFormat("'{0}' ", txtNombre.Text & " " & txtApat.Text & " " & txtAmat.Text)
                    Sql1.Append("where Clavecliente = ")
                    Sql1.AppendFormat("{0}", lv_idCliente)
                    myCommand = New SqlCommand(Sql1.ToString, conn)
                    myAdapter.SelectCommand = myCommand
                    myAdapter.Fill(myDs)

                    Limpia_Variables_SQL()

                    Sql1.Clear()
                    Sql1.Append("UPDATE historial_pagos SET Cliente = ")
                    Sql1.AppendFormat("'{0}' ", txtNombre.Text & " " & txtApat.Text & " " & txtAmat.Text)
                    Sql1.Append("where Clavecliente = ")
                    Sql1.AppendFormat("{0}", lv_idCliente)
                    myCommand = New SqlCommand(Sql1.ToString, conn)
                    myAdapter.SelectCommand = myCommand
                    myAdapter.Fill(myDs)

                    Sql1.Clear()
                    Sql1.Append("UPDATE factura_total SET Cliente = ")
                    Sql1.AppendFormat("'{0}' ", txtNombre.Text & " " & txtApat.Text & " " & txtAmat.Text)
                    Sql1.Append("where id_cliente = ")
                    Sql1.AppendFormat("{0}", lv_idCliente)
                    myCommand = New SqlCommand(Sql1.ToString, conn)
                    myAdapter.SelectCommand = myCommand
                    myAdapter.Fill(myDs)

                    MsgBox("Cliente actualizado correctamente.", MsgBoxStyle.Information)
                End If
                FrmBuscarClientes.txtBusqueda.Text = txtNombre.Text
                Limpia_Variables_SQL_y_Cierra_Conexion()
                Add_Update = False
                LimpiarObjetos()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Limpia_Variables_SQL_y_Cierra_Conexion()
        End Try
    End Sub
    Private Sub LimpiarObjetos()
        For Each ctrl As Control In Me.GroupBox1.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).SelectedIndex = -1
            End If
            If TypeOf ctrl Is MaskedTextBox Then
                CType(ctrl, MaskedTextBox).Text = String.Empty
            End If
        Next ctrl
    End Sub

    Private Sub txtCredito_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCredito.TextChanged

    End Sub

End Class