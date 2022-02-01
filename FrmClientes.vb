Public Class FrmClientes
    Public lv_idCliente

    Private Sub FrmClientes_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                LimpiarVar()
                Close()
        End Select
    End Sub

    Private Sub FrmClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Add_Update = False Then
            LimpiarVar()
        End If
        txtNombre.Select()
    End Sub

    Private Sub LimpiarVar()
        txtNombre.Clear()
        txtApat.Clear()
        txtAmat.Clear()
        txtDomicilio.Clear()
        txtNumExterno.Clear()
        txtColonia.Clear()
        txtCiudad.Clear()
        txtEstado.Clear()
        txtCodigoPostal.Clear()
        txtRFC.Clear()
        txtTelFijo.Clear()
        txtMovil.Clear()
        txtEmail.Clear()
        txtCredito.Clear()
        txtLimite.Clear()
        CmbPrecio.SelectedIndex = -1
        txtObs.Clear()
        CmbTipo.SelectedIndex = -1
        cmbMetodoPago.SelectedIndex = -1
        txtCuenta.Clear()
        CmbBanco.SelectedIndex = -1
        CmbCredito.SelectedIndex = -1
        ChkTasaCero.Checked = False
        cmbFormaPago.SelectedIndex = -1
        cmbUsoCFDI.SelectedIndex = -1
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            txtApat.Focus()
        End If
    End Sub

    Private Sub txtApat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApat.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            txtAmat.Focus()
        End If
    End Sub

    Private Sub txtAmat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmat.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            txtDomicilio.Focus()
        End If
    End Sub

    Private Sub txtDomicilio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDomicilio.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            txtNumExterno.Focus()
        End If
    End Sub

    Private Sub txtNumExterno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            txtColonia.Focus()
        End If
    End Sub

    Private Sub txtColonia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtColonia.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            txtCiudad.Focus()
        End If
    End Sub

    Private Sub txtCiudad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCiudad.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            txtEstado.Focus()
        End If
    End Sub

    Private Sub txtEstado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEstado.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            txtCodigoPostal.Focus()
        End If
    End Sub

    Private Sub txtCodigoPostal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoPostal.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            txtRFC.Focus()
        End If
    End Sub

    Private Sub txtRFC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRFC.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            txtTelFijo.Focus()
        End If
    End Sub

    Private Sub txtTelFijo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelFijo.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            txtMovil.Focus()
        End If
    End Sub

    Private Sub txtMovil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMovil.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            txtEmail.Focus()
        End If
    End Sub

    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            txtCredito.Focus()
        End If
    End Sub

    Private Sub txtCredito_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCredito.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Return) Then
            txtLimite.Focus()
        End If
    End Sub

    Private Sub txtLimite_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLimite.KeyPress
        e.Handled = True
        If e.KeyChar <> "." Then 'Allow "."'s before checking for Numerics   
            If IsNumeric(e.KeyChar) Then
                e.Handled = False 'Check for Numerics   
            End If
            If Asc(e.KeyChar) = 8 Then
                e.Handled = False
            End If
        Else
            If e.KeyChar = "." And txtLimite.Text.Contains(".") Then e.KeyChar = "" 'Check for Duplicate and Create Null if Yes   
            e.Handled = False
        End If
    End Sub

    Private Sub CmbTipo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CmbTipo.SelectedIndexChanged
        If CmbTipo.Text = "CREDITO" Then
            CmbCredito.Visible = True
            CmbCredito.SelectedIndex = 4
        Else
            If CmbTipo.Text = "CONTADO" Then
                CmbCredito.Visible = False
            End If
        End If
    End Sub

    'Private Sub CmdMetPago_SelectionChangeCommitted(sender As Object, e As System.EventArgs)
    '    If cmbMetodoPago.Text <> "EFECTIVO" Then
    '        txtCuenta.Visible = True
    '        CmbBanco.Visible = True
    '        txtCuenta.Focus()
    '        CmbBanco.SelectedIndex = -1
    '    Else
    '        txtCuenta.Visible = False
    '        CmbBanco.Visible = False
    '        txtCuenta.Clear()
    '        CmbBanco.SelectedIndex = -1
    '    End If
    'End Sub

    Private Sub CmbTipo_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CmbTipo.SelectionChangeCommitted
        If CmbTipo.Text = "CREDITO" Then
            CmbCredito.Visible = True
        Else
            CmbCredito.Visible = False
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim lv_FormaPago() As String = Split(cmbFormaPago.Text, "-")
        Dim lv_MetodoPago() As String = Split(cmbMetodoPago.Text, "-")
        Dim lv_UsoCFDI() As String = Split(cmbUsoCFDI.Text, "-")
        Dim strCliente As New tblClientes

        If txtNombre.Text = "" Or txtLimite.Text = "" Or txtCredito.Text = "" Or CmbPrecio.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Campos Obligatorios para crear un Cliente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If Add_Update = False Then
            strCliente.nombre = txtNombre.Text
            strCliente.apat = txtApat.Text
            strCliente.amat = txtAmat.Text
            strCliente.calle = txtDomicilio.Text
            strCliente.numero = txtNumExterno.Text
            strCliente.colonia = txtColonia.Text
            strCliente.ciudad = txtCiudad.Text
            strCliente.estado = txtEstado.Text
            strCliente.cp = txtCodigoPostal.Text
            strCliente.rfc = txtRFC.Text
            strCliente.telefono = txtTelFijo.Text
            strCliente.celular = txtMovil.Text
            strCliente.correo = txtEmail.Text
            strCliente.observaciones = txtObs.Text
            strCliente.listaPrecios = CmbPrecio.Text
            strCliente.diasCredito = CInt(txtCredito.Text)
            strCliente.limiteCredito = CDbl(txtLimite.Text)
            strCliente.tipo_venta = CmbTipo.Text
            strCliente.codiciones = CmbCredito.Text
            strCliente.cuenta = txtCuenta.Text
            strCliente.banco = CmbBanco.Text
            If ChkTasaCero.Checked = True Then
                strCliente.tasa_cero = 1
            Else
                strCliente.tasa_cero = 0
            End If
            strCliente.FormaPago = lv_FormaPago(0)
            strCliente.metodopago = lv_MetodoPago(0)
            strCliente.UsoCFDI = lv_UsoCFDI(0)
            If DBModelo.InsertCliente(strCliente) Then
                MetroFramework.MetroMessageBox.Show(Me, "Cliente creado correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Cliente NO pudo ser creado.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            strCliente = DBModelo.GetCliente(lv_idCliente)
            If Not IsNothing(strCliente) Then
                strCliente.nombre = txtNombre.Text
                strCliente.apat = txtApat.Text
                strCliente.amat = txtAmat.Text
                strCliente.calle = txtDomicilio.Text
                strCliente.numero = txtNumExterno.Text
                strCliente.colonia = txtColonia.Text
                strCliente.ciudad = txtCiudad.Text
                strCliente.estado = txtEstado.Text
                strCliente.cp = txtCodigoPostal.Text
                strCliente.rfc = txtRFC.Text
                strCliente.telefono = txtTelFijo.Text
                strCliente.celular = txtMovil.Text
                strCliente.correo = txtEmail.Text
                strCliente.observaciones = txtObs.Text
                strCliente.listaPrecios = CmbPrecio.Text
                strCliente.diasCredito = CInt(txtCredito.Text)
                strCliente.limiteCredito = CDbl(txtLimite.Text)
                strCliente.tipo_venta = CmbTipo.Text
                strCliente.codiciones = CmbCredito.Text
                strCliente.cuenta = txtCuenta.Text
                strCliente.banco = CmbBanco.Text
                If ChkTasaCero.Checked = True Then
                    strCliente.tasa_cero = 1
                Else
                    strCliente.tasa_cero = 0
                End If
                strCliente.FormaPago = lv_FormaPago(0)
                strCliente.metodopago = lv_MetodoPago(0)
                strCliente.UsoCFDI = lv_UsoCFDI(0)
                If DBModelo.UpdateCliente(strCliente) Then
                    MetroFramework.MetroMessageBox.Show(Me, "Cliente actualizado correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If DBModelo.UpdateCliente_Cotizacion(txtNombre.Text & " " & txtApat.Text & " " & txtAmat.Text, lv_idCliente) = False Then
                        MetroFramework.MetroMessageBox.Show(Me, "Cliente NO pudo ser actualizado en la tabla de Cotizacion.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                    If DBModelo.UpdateCliente_Venta(txtNombre.Text & " " & txtApat.Text & " " & txtAmat.Text, lv_idCliente) = False Then
                        MetroFramework.MetroMessageBox.Show(Me, "Cliente NO pudo ser actualizado en la tabla de Venta.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                    If DBModelo.UpdateCliente_VentaPedido(txtNombre.Text & " " & txtApat.Text & " " & txtAmat.Text, lv_idCliente) = False Then
                        MetroFramework.MetroMessageBox.Show(Me, "Cliente NO pudo ser actualizado en la tabla de VentaPedido.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                    If DBModelo.UpdateCliente_Cobrar(txtNombre.Text & " " & txtApat.Text & " " & txtAmat.Text, lv_idCliente) = False Then
                        MetroFramework.MetroMessageBox.Show(Me, "Cliente NO pudo ser actualizado en la tabla de Cobrar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                    If DBModelo.UpdateCliente_HistorialPagos(txtNombre.Text & " " & txtApat.Text & " " & txtAmat.Text, lv_idCliente) = False Then
                        MetroFramework.MetroMessageBox.Show(Me, "Cliente NO pudo ser actualizado en la tabla de Historial_Pagos.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                    If DBModelo.UpdateCliente_FacturaTotal(txtNombre.Text & " " & txtApat.Text & " " & txtAmat.Text, lv_idCliente) = False Then
                        MetroFramework.MetroMessageBox.Show(Me, "Cliente NO pudo ser actualizado en la tabla de Factura_Total.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "Cliente NO pudo ser actualizado.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Cliente NO encontrado en el sistema.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        FrmBuscarClientes.txtBusqueda.Text = txtNombre.Text
        Add_Update = False
        LimpiarVar()
        Close()
    End Sub

    Private Sub btnEliminar_Click_1(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MetroFramework.MetroMessageBox.Show(Me, "¿Esta seguro que desea Eliminar este Cliente del Sistema?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim strCliente As tblClientes = DBModelo.GetCliente(lv_idCliente)
            If Not IsNothing(strCliente) Then
                If DBModelo.DeleteCliente(strCliente) Then
                    MetroFramework.MetroMessageBox.Show(Me, "Cliente: " & strCliente.nombre & " " & strCliente.apat & " " & strCliente.amat & " eliminaro correctamente!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FrmBuscarClientes.txtBusqueda.Text = txtNombre.Text
                    Add_Update = False
                    LimpiarVar()
                    Close()
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "No se pudo eliminar el Cliente: " & strCliente.nombre & " " & strCliente.apat & " " & strCliente.amat, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LimpiarVar()
        Close()
    End Sub
End Class