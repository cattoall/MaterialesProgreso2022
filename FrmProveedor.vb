
Public Class FrmProveedor
    Public lv_idProveedor
    Public lv_ValorAnterior As String

    Private Sub FrmProveedor_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                LimpiarObjetos()
                Close()
        End Select
    End Sub

    Private Sub FrmClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtRazonSocial.Select()
    End Sub

    Private Sub txtRazonSocial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRazonSocial.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            txtDomicilio.Focus()
        End If
    End Sub

    Private Sub txtDomicilio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDomicilio.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            txtNumExterno.Focus()
        End If
    End Sub

    Private Sub txtNumExterno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumExterno.KeyPress
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
            txtContacto.Focus()
        End If
    End Sub

    Private Sub txtContacto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContacto.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            txtObs.Focus()
        End If
    End Sub

    Private Sub LimpiarObjetos()
        txtRazonSocial.Clear()
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
        txtContacto.Clear()
        txtObs.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) 
        LimpiarObjetos()
        Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) 
        Dim strProveedor As New tblProveedor

        If txtRazonSocial.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Favor de llenar el Campo Razón Social", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        If Add_Update = False Then
            strProveedor.razonSocial = txtRazonSocial.Text
            strProveedor.calle = txtDomicilio.Text
            strProveedor.numero = txtNumExterno.Text
            strProveedor.colonia = txtColonia.Text
            strProveedor.ciudad = txtCiudad.Text
            strProveedor.estado = txtEstado.Text
            strProveedor.cp = txtCodigoPostal.Text
            strProveedor.rfc = txtRFC.Text
            strProveedor.telefono = txtTelFijo.Text
            strProveedor.celular = txtMovil.Text
            strProveedor.correo = txtEmail.Text
            strProveedor.contacto = txtContacto.Text
            strProveedor.observaciones = txtObs.Text
            If DBModelo.InsertProveedor(strProveedor) Then
                MetroFramework.MetroMessageBox.Show(Me, "Proveedor creado correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Proveedor NO pudo ser creado.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            strProveedor = DBModelo.GetProveedor(lv_idProveedor)
            If Not IsNothing(strProveedor) Then
                strProveedor.clave = lv_idProveedor
                strProveedor.razonSocial = txtRazonSocial.Text
                strProveedor.calle = txtDomicilio.Text
                strProveedor.numero = txtNumExterno.Text
                strProveedor.colonia = txtColonia.Text
                strProveedor.ciudad = txtCiudad.Text
                strProveedor.estado = txtEstado.Text
                strProveedor.cp = txtCodigoPostal.Text
                strProveedor.rfc = txtRFC.Text
                strProveedor.telefono = txtTelFijo.Text
                strProveedor.celular = txtMovil.Text
                strProveedor.correo = txtEmail.Text
                strProveedor.contacto = txtContacto.Text
                strProveedor.observaciones = txtObs.Text

                If DBModelo.UpdateProveedor(strProveedor) Then
                    MetroFramework.MetroMessageBox.Show(Me, "Proveedor actualizado correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If lv_ValorAnterior <> txtRazonSocial.Text Then

                        If DBModelo.UpdateProveedor_Compras(txtRazonSocial.Text, lv_idProveedor) = False Then
                            MetroFramework.MetroMessageBox.Show(Me, "Proveedor NO pudo ser actualizado en la tabla de Compras.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If

                        If DBModelo.UpdateProveedor_OrdenCompra(txtRazonSocial.Text, lv_idProveedor) = False Then
                            MetroFramework.MetroMessageBox.Show(Me, "Proveedor NO pudo ser actualizado en la tabla de OrdenCompra.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If

                        If DBModelo.UpdateProveedor_HistorialPagos(txtRazonSocial.Text, lv_idProveedor) = False Then
                            MetroFramework.MetroMessageBox.Show(Me, "Proveedor NO pudo ser actualizado en la tabla de Historial_Pagos_Proveedores.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If

                        If DBModelo.UpdateProveedor_Pagar(txtRazonSocial.Text, lv_idProveedor) = False Then
                            MetroFramework.MetroMessageBox.Show(Me, "Proveedor NO pudo ser actualizado en la tabla de Pagar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If

                        If DBModelo.UpdateProveedor_Productos(txtRazonSocial.Text, lv_idProveedor) = False Then
                            MetroFramework.MetroMessageBox.Show(Me, "Proveedor NO pudo ser actualizado en la tabla de Productos.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If

                    End If
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "Proveedor NO pudo ser actualizado.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Proveedor NO encontrado en el sistema.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        FrmBuscarProveedores.txtBusqueda.Text = txtRazonSocial.Text
        Add_Update = False
        Material_Proveedores = txtRazonSocial.Text
        LimpiarObjetos()
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LimpiarObjetos()
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim strProveedor As New tblProveedor

        If txtRazonSocial.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Favor de llenar el Campo Razón Social", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        If Add_Update = False Then
            strProveedor.IdComp = CompanyCode
            strProveedor.razonSocial = txtRazonSocial.Text
            strProveedor.calle = txtDomicilio.Text
            strProveedor.numero = txtNumExterno.Text
            strProveedor.colonia = txtColonia.Text
            strProveedor.ciudad = txtCiudad.Text
            strProveedor.estado = txtEstado.Text
            strProveedor.cp = txtCodigoPostal.Text
            strProveedor.rfc = txtRFC.Text
            strProveedor.telefono = txtTelFijo.Text
            strProveedor.celular = txtMovil.Text
            strProveedor.correo = txtEmail.Text
            strProveedor.contacto = txtContacto.Text
            strProveedor.observaciones = txtObs.Text
            If DBModelo.InsertProveedor(strProveedor) Then
                MetroFramework.MetroMessageBox.Show(Me, "Proveedor creado correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Proveedor NO pudo ser creado.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            strProveedor = DBModelo.GetProveedor(lv_idProveedor)
            If Not IsNothing(strProveedor) Then
                strProveedor.clave = lv_idProveedor
                strProveedor.razonSocial = txtRazonSocial.Text
                strProveedor.calle = txtDomicilio.Text
                strProveedor.numero = txtNumExterno.Text
                strProveedor.colonia = txtColonia.Text
                strProveedor.ciudad = txtCiudad.Text
                strProveedor.estado = txtEstado.Text
                strProveedor.cp = txtCodigoPostal.Text
                strProveedor.rfc = txtRFC.Text
                strProveedor.telefono = txtTelFijo.Text
                strProveedor.celular = txtMovil.Text
                strProveedor.correo = txtEmail.Text
                strProveedor.contacto = txtContacto.Text
                strProveedor.observaciones = txtObs.Text

                If DBModelo.UpdateProveedor(strProveedor) Then
                    MetroFramework.MetroMessageBox.Show(Me, "Proveedor actualizado correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If lv_ValorAnterior <> txtRazonSocial.Text Then

                        If DBModelo.UpdateProveedor_Compras(txtRazonSocial.Text, lv_idProveedor) = False Then
                            MetroFramework.MetroMessageBox.Show(Me, "Proveedor NO pudo ser actualizado en la tabla de Compras.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If

                        If DBModelo.UpdateProveedor_OrdenCompra(txtRazonSocial.Text, lv_idProveedor) = False Then
                            MetroFramework.MetroMessageBox.Show(Me, "Proveedor NO pudo ser actualizado en la tabla de OrdenCompra.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If

                        If DBModelo.UpdateProveedor_HistorialPagos(txtRazonSocial.Text, lv_idProveedor) = False Then
                            MetroFramework.MetroMessageBox.Show(Me, "Proveedor NO pudo ser actualizado en la tabla de Historial_Pagos_Proveedores.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If

                        If DBModelo.UpdateProveedor_Pagar(txtRazonSocial.Text, lv_idProveedor) = False Then
                            MetroFramework.MetroMessageBox.Show(Me, "Proveedor NO pudo ser actualizado en la tabla de Pagar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If

                        If DBModelo.UpdateProveedor_Productos(txtRazonSocial.Text, lv_idProveedor) = False Then
                            MetroFramework.MetroMessageBox.Show(Me, "Proveedor NO pudo ser actualizado en la tabla de Productos.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If

                    End If
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "Proveedor NO pudo ser actualizado.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Proveedor NO encontrado en el sistema.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        FrmBuscarProveedores.txtBusqueda.Text = txtRazonSocial.Text
        Add_Update = False
        Material_Proveedores = txtRazonSocial.Text
        LimpiarObjetos()
        Close()
    End Sub
End Class