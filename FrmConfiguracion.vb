Public Class FrmConfiguracion
    Dim strCurrency As String = ""
    Dim acceptableKey As Boolean = False

    Private Sub FrmConfiguracion_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                LimpiarObjetos()
                Close()
        End Select
    End Sub

    Private Sub FrmConfiguracion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LimpiarObjetos()
        Dim strConfig As tblConfiguracion = DBModelo.GetConfiguration(gv_terminal)
        If Not IsNothing(strConfig) Then
            txtNombre.Text = strConfig.nombreEmpresa
            txtDireccion.Text = strConfig.direccionEmpresa
            txtColonia.Text = strConfig.localidadEmpresa
            txtTelefono.Text = strConfig.telefonoEmpresa
            txtCiudad.Text = strConfig.ciudadEmpresa
            txtRFC.Text = strConfig.rfcEmpresa
            txtPropietario.Text = strConfig.propietario
            txtFactorIVA.Text = strConfig.factorIVA
            txtCajaChica.Text = strConfig.cajaChica
            txtFolioFactura.Text = strConfig.folioFactura
            txtFacturas.Text = strConfig.InvoicePrinterName
            txtTickets.Text = strConfig.TicketPrinterName
            txtNumFacturas.Text = strConfig.impresiones
            txtTipoCambio.Text = strConfig.TipoCambio
            Config_On_Off = True
        Else
            MetroFramework.MetroMessageBox.Show(Me, "No Existe Configuración, Favor de Configurar ahora.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Config_On_Off = False
        End If
        txtNombre.Select()
    End Sub

    Private Sub txtCajaChica_GotFocus(sender As Object, e As System.EventArgs) Handles txtCajaChica.GotFocus
        acceptableKey = True
        strCurrency = ""
    End Sub

    Private Sub txtCajaChica_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCajaChica.KeyDown
        If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) OrElse (e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) OrElse e.KeyCode = Keys.Back Then
            acceptableKey = True
        Else
            acceptableKey = False
        End If
    End Sub

    Private Sub txtCajaChica_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCajaChica.KeyPress
        ' Check for the flag being set in the KeyDown event.
        If acceptableKey = False Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
            Return
        Else
            If e.KeyChar = Convert.ToChar(Keys.Back) Then
                If strCurrency.Length > 0 Then
                    strCurrency = strCurrency.Substring(0, strCurrency.Length - 1)
                End If
            Else
                strCurrency = strCurrency & e.KeyChar
            End If

            If strCurrency.Length = 0 Then
                txtCajaChica.Text = ""
            ElseIf strCurrency.Length = 1 Then
                txtCajaChica.Text = "0.0" & strCurrency
            ElseIf strCurrency.Length = 2 Then
                txtCajaChica.Text = "0." & strCurrency
            ElseIf strCurrency.Length > 2 Then
                txtCajaChica.Text = strCurrency.Substring(0, strCurrency.Length - 2) & "." & strCurrency.Substring(strCurrency.Length - 2)
            End If
            txtCajaChica.Select(txtCajaChica.Text.Length, 0)

        End If
        e.Handled = True
    End Sub

    Private Sub txtNumFacturas_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumFacturas.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtFactorIVA_GotFocus(sender As Object, e As System.EventArgs) Handles txtFactorIVA.GotFocus
        acceptableKey = True
        strCurrency = ""
        'txtFactorIVA.BackColor = My.Settings.BoxColor
    End Sub

    Private Sub txtFactorIVA_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFactorIVA.KeyDown
        If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) OrElse (e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) OrElse e.KeyCode = Keys.Back Then
            acceptableKey = True
        Else
            acceptableKey = False
        End If
    End Sub

    Private Sub txtFactorIVA_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtFactorIVA.KeyPress
        ' Check for the flag being set in the KeyDown event.
        If acceptableKey = False Then
            ' Stop the character from being entered into the control since it is non-numerical.
            e.Handled = True
            Return
        Else
            If e.KeyChar = Convert.ToChar(Keys.Back) Then
                If strCurrency.Length > 0 Then
                    strCurrency = strCurrency.Substring(0, strCurrency.Length - 1)
                End If
            Else
                strCurrency = strCurrency & e.KeyChar
            End If

            If strCurrency.Length = 0 Then
                txtFactorIVA.Text = ""
            ElseIf strCurrency.Length = 1 Then
                txtFactorIVA.Text = "0.0" & strCurrency
            ElseIf strCurrency.Length = 2 Then
                txtFactorIVA.Text = "0." & strCurrency
            ElseIf strCurrency.Length > 2 Then
                txtFactorIVA.Text = strCurrency.Substring(0, strCurrency.Length - 2) & "." & strCurrency.Substring(strCurrency.Length - 2)
            End If
            txtFactorIVA.Select(txtFactorIVA.Text.Length, 0)

        End If
        e.Handled = True
    End Sub

    Private Sub txtFolioFactura_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolioFactura.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub LimpiarObjetos()
        txtNombre.Clear()
        txtDireccion.Clear()
        txtColonia.Clear()
        txtTelefono.Clear()
        txtCiudad.Clear()
        txtRFC.Clear()
        txtPropietario.Clear()
        txtFactorIVA.Clear()
        txtCajaChica.Clear()
        txtFolioFactura.Clear()
        txtTickets.Clear()
        txtTipoCambio.Clear()
        TipoCambio = 0
        Config_On_Off = False
        strCurrency = ""
        acceptableKey = False
    End Sub

    Private Sub btnTecnoLite_Click(sender As System.Object, e As System.EventArgs) Handles btnTecnoLite.Click
        Dim l_updated As Boolean = True

        factorCosto_TL = 0
        factorPublico_TL = 0
        factorP1_TL = 0
        factorP2_TL = 0
        factorP3_TL = 0

        precioLista = 0
        PrecioCosto_TL = 0
        PrecioPublico_TL = 0
        PrecioP1_TL = 0
        PrecioP2_TL = 0
        PrecioP3_TL = 0

        Dim strGrp As tblGrupos = DBModelo.GetConfigGroupDesc("TECNO LITE")
        If Not IsNothing(strGrp) Then
            factorCosto_TL = strGrp.factorCosto
            factorPublico_TL = strGrp.factorPublico
            factorP1_TL = strGrp.factorP1
            factorP2_TL = strGrp.factorP2
            factorP3_TL = strGrp.factorP3

            Dim lstProductos As List(Of tblProductos) = DBModelo.GetConfigProducts(strGrp.descripcion, 1)
            If Not IsNothing(lstProductos) Then
                For Each strProductos In lstProductos
                    precioLista = 0
                    PrecioCosto_TL = 0
                    PrecioPublico_TL = 0
                    PrecioP1_TL = 0
                    PrecioP2_TL = 0
                    PrecioP3_TL = 0

                    precioLista = CDbl(strProductos.precioLista)
                    precioLista = precioLista * GranTipoCambio

                    'Precio Costo
                    PrecioCosto_TL = precioLista - (precioLista * (factorCosto_TL / 100))

                    'Precio Publico
                    PrecioPublico_TL = (PrecioCosto_TL / (factorPublico_TL / 100))

                    'Precio P1
                    PrecioP1_TL = (PrecioPublico_TL * (factorP1_TL / 100))

                    'Precio P2
                    PrecioP2_TL = (PrecioPublico_TL * (factorP2_TL / 100))

                    'Precio P3
                    PrecioP3_TL = (PrecioPublico_TL * (factorP3_TL / 100))

                    strProductos.precioCosto = Math.Round(CDbl(PrecioCosto_TL), 2)
                    strProductos.precioPublico = Math.Round(CDbl(PrecioPublico_TL), 2)
                    strProductos.precioP1 = Math.Round(CDbl(PrecioP1_TL), 2)
                    strProductos.precioP2 = Math.Round(CDbl(PrecioP2_TL), 2)
                    strProductos.precioP3 = Math.Round(CDbl(PrecioP3_TL), 2)
                    strProductos.TC = CDbl(GranTipoCambio)
                    If DBModelo.UpdateProductos(strProductos) = False Then
                        l_updated = False
                    End If
                Next
                If l_updated = True Then
                    btnTecnoLite.Visible = False
                    MetroFramework.MetroMessageBox.Show(Me, "Precios actualizados al Tipo de Cambio", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "Precios NO actualizados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MetroFramework.MetroMessageBox.Show(Me, "No existen productos asignados al grupo TECNO LITE", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Grupo TECNO LITE no existe en el sistema", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If l_updated = True Then
            btnTecnoLite.Visible = False
            MetroFramework.MetroMessageBox.Show(Me, "Precios actualizados al Tipo de Cambio", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Precios NO actualizados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim strConfig As tblConfiguracion = DBModelo.GetConfiguration(gv_terminal)
        If Not IsNothing(strConfig) Then
            strConfig.nombreEmpresa = txtNombre.Text
            strConfig.direccionEmpresa = txtDireccion.Text
            strConfig.localidadEmpresa = txtColonia.Text
            strConfig.telefonoEmpresa = txtTelefono.Text
            strConfig.ciudadEmpresa = txtCiudad.Text
            strConfig.rfcEmpresa = txtRFC.Text
            strConfig.propietario = txtPropietario.Text
            strConfig.factorIVA = txtFactorIVA.Text
            strConfig.cajaChica = txtCajaChica.Text
            strConfig.folioFactura = txtFolioFactura.Text
            strConfig.InvoicePrinterName = txtFacturas.Text
            strConfig.TicketPrinterName = txtTickets.Text
            strConfig.impresiones = txtNumFacturas.Text
            strConfig.TipoCambio = txtTipoCambio.Text
            If Config_On_Off = False Then
                If DBModelo.Insert_Configuracion(strConfig) Then
                    If TipoCambio <> txtTipoCambio.Text Then
                        btnTecnoLite.Visible = True
                        GranTipoCambio = txtTipoCambio.Text
                        TipoCambio = txtTipoCambio.Text
                    End If
                    TicketPrinterName = txtTickets.Text
                    InvocePrinterName = txtFacturas.Text
                    MetroFramework.MetroMessageBox.Show(Me, "Configuración creada correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "Error al insertar el registro.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                If DBModelo.Update_Configuracion(strConfig) Then
                    If TipoCambio <> txtTipoCambio.Text Then
                        btnTecnoLite.Visible = True
                        GranTipoCambio = txtTipoCambio.Text
                        TipoCambio = txtTipoCambio.Text
                    End If
                    TicketPrinterName = txtTickets.Text
                    InvocePrinterName = txtFacturas.Text
                    MetroFramework.MetroMessageBox.Show(Me, "Configuración actualizada correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "Error al modificar el registro.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        LimpiarObjetos()
        Close()
    End Sub
End Class