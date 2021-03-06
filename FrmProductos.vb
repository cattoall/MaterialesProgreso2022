
Public Class FrmProductos
    Public lv_idProducto
    Private lv_flag_tmp As Boolean = False

    Private Sub FrmProductos_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                Close()
                LimpiarObjetos()
        End Select
    End Sub

    Private Sub FrmClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        chkTC.Text = "Tipo de Cambio (" & GranTipoCambio & ")"
        txtCodigoBarras.BackColor = Nothing
        txtClave.BackColor = Nothing
        txtDescripcion.BackColor = Nothing
        txtPrecioLista.BackColor = Nothing
        txtPrecioCosto.BackColor = Nothing

        txtCodigoBarras.Select()
        Precio_Manual_Check()
        Llena_Grupos()
        Llena_SubFamilias()
        Llena_Proveedores()
        Llena_Familias()
        Llena_Lineas()
        Llena_UoMs()
        CmbTipoVenta.SelectedIndex = 0
    End Sub

    Private Sub Llena_Grupos()
        Dim grps As List(Of tblGrupos) = DBModelo.GetGroupsAll

        If IsNothing(grps) Then
            Exit Sub
        End If

        CmbGrupo.DataSource    = grps
        CmbGrupo.DisplayMember = "descripcion"
        CmbGrupo.ValueMember   = "clave"
        CmbGrupo.SelectedIndex = -1

        'Material_Grupo = Material_Grupo.Trim
        If Material_Grupo <> "" Then
            CmbGrupo.SelectedValue = grps.Find(Function(f) f.descripcion = Material_Grupo).clave
        End If

        If Material_Grupo = "TECNO LITE" Then
            chkTC.Visible = True
        Else
            chkTC.Visible = False
        End If
    End Sub

    Private Sub Llena_SubFamilias()
        Dim subfam As List(Of tblSubFamilia) = DBModelo.GetSubFamiliaAll
        Dim i As Int16

        If IsNothing(subfam) Then
            Exit Sub
        End If

        CmbSubFamilia.DataSource = subfam
        CmbSubFamilia.DisplayMember = "descripcion"
        CmbSubFamilia.ValueMember = "clave"
        CmbSubFamilia.SelectedIndex = -1

        'Material_SubFam = Material_SubFam.Trim
        If Material_SubFam <> "" Then
            CmbSubFamilia.SelectedValue = subfam.Find(Function(f) f.descripcion = Material_SubFam).clave
        End If
    End Sub

    Private Sub Llena_Proveedores()
        Dim proveedor As List(Of tblProveedor) = DBModelo.GetProveedorAll

        If IsNothing(proveedor) Then
            Exit Sub
        End If

        CmbProveedor.DataSource = proveedor
        CmbProveedor.DisplayMember = "razonSocial"
        CmbProveedor.ValueMember = "clave"
        CmbProveedor.SelectedIndex = -1

        'Material_Proveedores = Material_Proveedores.Trim
        If Material_Proveedores <> "" Then
            CmbProveedor.SelectedValue = proveedor.Find(Function(f) f.razonSocial = Material_Proveedores).clave
        End If
    End Sub

    Private Sub Llena_Familias()
        Dim familia As List(Of tblFamilia) = DBModelo.GetFamiliaAll

        If IsNothing(familia) Then
            Exit Sub
        End If

        CmbFamilia.DataSource = familia
        CmbFamilia.DisplayMember = "descripcion"
        CmbFamilia.ValueMember = "clave"
        CmbFamilia.SelectedIndex = -1

        'Material_Familia = Material_Familia.Trim
        If Material_Familia <> "" Then
            CmbFamilia.SelectedValue = familia.Find(Function(f) f.descripcion = Material_Familia).clave
        End If

    End Sub

    Private Sub Llena_Lineas()
        Dim linea As List(Of tblLinea) = DBModelo.GetLineaAll

        If IsNothing(linea) Then
            Exit Sub
        End If

        CmbLinea.DataSource = linea
        CmbLinea.DisplayMember = "descripcion"
        CmbLinea.ValueMember = "clave"
        CmbLinea.SelectedIndex = -1

        'Material_Linea = Material_Linea.Trim
        If Material_Linea <> "" Then
            CmbLinea.SelectedValue = linea.Find(Function(f) f.descripcion = Material_Linea).clave
        End If

    End Sub

    Private Sub Llena_UoMs()
        Dim uom As List(Of tblUnidades) = DBModelo.GetUoMAll

        If IsNothing(uom) Then
            Exit Sub
        End If

        CmbUnidad.DataSource = uom
        CmbUnidad.DisplayMember = "descripcion"
        CmbUnidad.ValueMember = "Clave"
        CmbUnidad.SelectedIndex = -1

        'Material_Umedida = Material_Umedida.Trim
        If Material_Umedida <> "" Then
            CmbUnidad.SelectedValue = uom.Find(Function(f) f.descripcion = Material_Umedida).Clave
        End If
    End Sub

    Private Sub txtIdProducto_GotFocus(sender As Object, e As System.EventArgs) Handles txtIdProducto.GotFocus
        txtIdProducto.SelectAll()
    End Sub

    Private Sub txtCodigoBarras_GotFocus(sender As Object, e As System.EventArgs) Handles txtCodigoBarras.GotFocus
        txtCodigoBarras.SelectAll()
    End Sub

    Private Sub txtClave_GotFocus(sender As Object, e As System.EventArgs) Handles txtClave.GotFocus
        txtClave.SelectAll()
    End Sub

    Private Sub txtDescripcion_GotFocus(sender As Object, e As System.EventArgs) Handles txtDescripcion.GotFocus
        txtDescripcion.SelectAll()
    End Sub

    Private Sub CmbGrupo_GotFocus(sender As Object, e As EventArgs) Handles CmbGrupo.GotFocus
        CmbGrupo.SelectAll()
    End Sub

    Private Sub LimpiarObjetos()
        txtPrecioCosto.Clear()
        txtPrecioLista.Clear()
        txtPrecioPublico.Clear()
        txtPrecioP1.Clear()
        txtPrecioP2.Clear()
        txtPrecioP3.Clear()
        txtCodigoBarras.Clear()
        txtDescripcion.Clear()
        txtClave.Clear()
        txtStock.Text = "0"
    End Sub

    Private Sub txtPrecioLista_Click(sender As Object, e As System.EventArgs) Handles txtPrecioLista.Click
        txtPrecioLista.SelectAll()
    End Sub

    Private Sub txtPrecioLista_GotFocus(sender As Object, e As System.EventArgs) Handles txtPrecioLista.GotFocus
        txtPrecioLista.SelectAll()
    End Sub

    Private Sub txtPrecioLista_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioLista.KeyPress

        If CmbGrupo.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Favor de seleccionar un Grupo para poder hacer el Cálculo de Precios", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            CmbGrupo.Focus()
            e.Handled = False
            Exit Sub
        End If

        e.Handled = True
        If e.KeyChar <> "." Then 'Allow "."'s before checking for Numerics   
            If IsNumeric(e.KeyChar) Then e.Handled = False 'Check for Numerics   
        Else
            If e.KeyChar = "." And txtPrecioLista.Text.Contains(".") Then e.KeyChar = "" 'Check for Duplicate and Create Null if Yes   
            e.Handled = False
        End If
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            If chkPrecioManual.Checked = False Then
                Calcula_Precios()
                txtPrecioLista.Focus()
                txtPrecioLista.SelectAll()
            End If
        End If
    End Sub

    Private Function Checa_CodigoBarras() As Boolean
        Dim findProduct As tblProductos = DBModelo.GetProductByCB(txtCodigoBarras.Text)
        If IsNothing(findProduct) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function Checa_Clave() As Boolean
        Dim findProduct As tblProductos = DBModelo.GetProductByClave(txtClave.Text)
        If IsNothing(findProduct) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Calcula_Precios()
        Dim grp As tblGrupos = DBModelo.GetGroup(CmbGrupo.SelectedValue)

        If IsNothing(grp) Then
            Exit Sub
        End If

        factorCosto = grp.factorCosto
        factorPublico = grp.factorPublico
        factorP1 = grp.factorP1
        factorP2 = grp.factorP2
        factorP3 = grp.factorP3

        If txtPrecioLista.Text <> "" Then
            precioLista = CDbl(txtPrecioLista.Text)
        Else
            precioLista = "0.00"
        End If

        If chkTC.Checked = True Then
            precioLista = precioLista * GranTipoCambio
        End If

        'Precio Costo
        factorCosto = (factorCosto / 100)
        txtPrecioCosto.Text = Format(precioLista - (precioLista * factorCosto), "###,###,##0.00")
        precioCosto = CDbl(txtPrecioCosto.Text)

        'Precio Publico
        factorPublico = factorPublico / 100
        txtPrecioPublico.Text = Format(precioCosto / factorPublico, "###,###,##0.00")
        precioPublico = CDbl(txtPrecioPublico.Text)

        'Precio P1
        factorP1 = (factorP1 / 100)
        txtPrecioP1.Text = Format(precioPublico * factorP1, "###,###,##0.00")

        'Precio P2
        factorP2 = (factorP2 / 100)
        txtPrecioP2.Text = Format(precioPublico * factorP2, "###,###,##0.00")

        'Precio P3
        factorP3 = (factorP3 / 100)
        txtPrecioP3.Text = Format(precioPublico * factorP3, "###,###,##0.00")

    End Sub

    Private Sub txtPrecioCosto_Click(sender As Object, e As System.EventArgs) Handles txtPrecioCosto.Click
        txtPrecioCosto.SelectAll()
    End Sub

    Private Sub txtPrecioCosto_GotFocus(sender As Object, e As System.EventArgs) Handles txtPrecioCosto.GotFocus
        txtPrecioCosto.SelectAll()
    End Sub

    Private Sub txtPrecioCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioCosto.KeyPress
        e.Handled = True
        If e.KeyChar <> "." Then 'Allow "."'s before checking for Numerics   
            If IsNumeric(e.KeyChar) Then e.Handled = False 'Check for Numerics   
        Else
            If e.KeyChar = "." And txtPrecioCosto.Text.Contains(".") Then e.KeyChar = "" 'Check for Duplicate and Create Null if Yes   
            e.Handled = False
        End If
    End Sub

    Private Sub txtPrecioPublico_GotFocus(sender As Object, e As System.EventArgs) Handles txtPrecioPublico.GotFocus
        txtPrecioPublico.SelectAll()
    End Sub

    Private Sub txtPrecioPublico_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioPublico.KeyPress
        e.Handled = True
        If e.KeyChar <> "." Then 'Allow "."'s before checking for Numerics   
            If IsNumeric(e.KeyChar) Then e.Handled = False 'Check for Numerics   
        Else
            If e.KeyChar = "." And txtPrecioPublico.Text.Contains(".") Then e.KeyChar = "" 'Check for Duplicate and Create Null if Yes   
            e.Handled = False
        End If
    End Sub

    Private Sub txtPrecioP1_GotFocus(sender As Object, e As System.EventArgs) Handles txtPrecioP1.GotFocus
        txtPrecioP1.SelectAll()
    End Sub

    Private Sub txtPrecioP1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioP1.KeyPress
        e.Handled = True
        If e.KeyChar <> "." Then 'Allow "."'s before checking for Numerics   
            If IsNumeric(e.KeyChar) Then e.Handled = False 'Check for Numerics   
        Else
            If e.KeyChar = "." And txtPrecioP1.Text.Contains(".") Then e.KeyChar = "" 'Check for Duplicate and Create Null if Yes   
            e.Handled = False
        End If
    End Sub

    Private Sub txtPrecioP2_GotFocus(sender As Object, e As System.EventArgs) Handles txtPrecioP2.GotFocus
        txtPrecioP2.SelectAll()
    End Sub

    Private Sub txtPrecioP2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioP2.KeyPress
        e.Handled = True
        If e.KeyChar <> "." Then 'Allow "."'s before checking for Numerics   
            If IsNumeric(e.KeyChar) Then e.Handled = False 'Check for Numerics   
        Else
            If e.KeyChar = "." And txtPrecioP2.Text.Contains(".") Then e.KeyChar = "" 'Check for Duplicate and Create Null if Yes   
            e.Handled = False
        End If
    End Sub

    Private Sub txtPrecioP3_GotFocus(sender As Object, e As System.EventArgs) Handles txtPrecioP3.GotFocus
        txtPrecioP3.SelectAll()
    End Sub

    Private Sub txtPrecioP3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioP3.KeyPress
        e.Handled = True
        If e.KeyChar <> "." Then 'Allow "."'s before checking for Numerics   
            If IsNumeric(e.KeyChar) Then e.Handled = False 'Check for Numerics   
        Else
            If e.KeyChar = "." And txtPrecioP3.Text.Contains(".") Then e.KeyChar = "" 'Check for Duplicate and Create Null if Yes   
            e.Handled = False
        End If
    End Sub

    Private Sub CmbFamilia_GotFocus(sender As Object, e As System.EventArgs) Handles CmbFamilia.GotFocus
        CmbFamilia.SelectAll()
    End Sub

    Private Sub CmbLinea_GotFocus(sender As Object, e As System.EventArgs) Handles CmbLinea.GotFocus
        CmbLinea.SelectAll()
    End Sub

    Private Sub CmbProveedor_GotFocus(sender As Object, e As System.EventArgs) Handles CmbProveedor.GotFocus
        CmbProveedor.SelectAll()
    End Sub

    Private Sub CmbSubFamilia_GotFocus(sender As Object, e As System.EventArgs) Handles CmbSubFamilia.GotFocus
        CmbSubFamilia.SelectAll()
    End Sub

    Private Sub CmbTipoVenta_GotFocus(sender As Object, e As System.EventArgs) Handles CmbTipoVenta.GotFocus
        CmbTipoVenta.SelectAll()
    End Sub

    Private Sub CmbUnidad_GotFocus(sender As Object, e As System.EventArgs) Handles CmbUnidad.GotFocus
        CmbUnidad.SelectAll()
    End Sub

    Private Sub chkPrecioManual_Click(sender As Object, e As System.EventArgs) Handles chkPrecioManual.Click
        Precio_Manual_Check()
    End Sub

    Private Sub Precio_Manual_Check()
        If chkPrecioManual.Checked = True Then
            txtPrecioPublico.Enabled = True
            txtPrecioP1.Enabled = True
            txtPrecioP2.Enabled = True
            txtPrecioP3.Enabled = True
        Else
            txtPrecioPublico.Enabled = False
            txtPrecioP1.Enabled = False
            txtPrecioP2.Enabled = False
            txtPrecioP3.Enabled = False
        End If
    End Sub

    Private Sub txtDesc_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesc.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CmdAgrupo_Click(sender As System.Object, e As System.EventArgs) Handles CmdAgrupo.Click
        lv_flag_tmp = Add_Update
        Add_Update = False
        FrmGrupos.ShowDialog()
        FrmGrupos.Close()
        FrmGrupos.Dispose()
        Llena_Grupos()
        Add_Update = lv_flag_tmp
    End Sub

    Private Sub CmdSubFam_Click(sender As System.Object, e As System.EventArgs) Handles CmdSubFam.Click
        lv_flag_tmp = Add_Update
        Add_Update = False
        FrmBuscarSubFamilias.ShowDialog()
        FrmBuscarSubFamilias.Close()
        FrmBuscarSubFamilias.Dispose()
        Llena_SubFamilias()
        Add_Update = lv_flag_tmp
    End Sub

    Private Sub CmdProveedor_Click(sender As System.Object, e As System.EventArgs) Handles CmdProveedor.Click
        lv_flag_tmp = Add_Update
        Add_Update = False
        FrmBuscarProveedores.ShowDialog()
        FrmBuscarProveedores.Close()
        FrmBuscarProveedores.Dispose()
        Llena_Proveedores()
        Add_Update = lv_flag_tmp
    End Sub

    Private Sub CmdFamilia_Click(sender As System.Object, e As System.EventArgs) Handles CmdFamilia.Click
        lv_flag_tmp = Add_Update
        Add_Update = False
        FrmBuscarFamilias.ShowDialog()
        FrmBuscarFamilias.Close()
        FrmBuscarFamilias.Dispose()
        Llena_Familias()
        Add_Update = lv_flag_tmp
    End Sub

    Private Sub CmdLinea_Click(sender As System.Object, e As System.EventArgs) Handles CmdLinea.Click
        lv_flag_tmp = Add_Update
        Add_Update = False
        FrmBuscarLineas.ShowDialog()
        FrmBuscarLineas.Close()
        FrmBuscarLineas.Dispose()
        Llena_Lineas()
        Add_Update = lv_flag_tmp
    End Sub

    Private Sub CmbGrupo_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles CmbGrupo.SelectionChangeCommitted
        If CmbGrupo.Text = "TECNO LITE" Then
            chkTC.Visible = True
        Else
            chkTC.Visible = False
        End If
        Calcula_Precios()
    End Sub

    Private Sub chkTC_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkTC.CheckedChanged
        Calcula_Precios()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LimpiarObjetos()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim strProductos As tblProductos = DBModelo.GetProducts(CInt(txtIdProducto.Text))

        If DBModelo.DeleteProductos(StrProductos) Then
            MetroFramework.MetroMessageBox.Show(Me, "Producto: " & txtDescripcion.Text & " eliminaro correctamente!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarObjetos()
            Close()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "No se pudo eliminar el Producto: " & txtDescripcion.Text, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim lv_PrecioManual As Byte
        Dim lv_UsarTC As Integer
        Dim lv_TasaCero As Integer


        If txtPrecioPublico.Text = "0.00" Or txtPrecioP1.Text = "0.00" Or txtPrecioP2.Text = "0.00" Or txtPrecioP3.Text = "0.00" Then
            MetroFramework.MetroMessageBox.Show(Me, "Favor de precionar Enter en Precio Lista.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPrecioLista.Focus()
            txtPrecioLista.SelectAll()
            Exit Sub
        End If

        If txtPrecioLista.Text <= 0 Then
            MetroFramework.MetroMessageBox.Show(Me, "El valor de Precio Lista debe de ser mayor a 0.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPrecioLista.SelectAll()
            txtPrecioLista.Focus()
            Exit Sub
        End If

        If txtCodigoBarras.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Codigo de Barras vacio, favor de introducirlo.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCodigoBarras.SelectAll()
            txtCodigoBarras.Focus()
            Exit Sub
        End If

        If txtDescripcion.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Descripción del Producto vacia, favor de introducirla.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescripcion.SelectAll()
            txtDescripcion.Focus()
            Exit Sub
        End If

        If txtDesc.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Descuento vacio, favor de introducir al menos 0.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDesc.SelectAll()
            Exit Sub
        End If

        If txtDesc.Text > "100" Then
            MetroFramework.MetroMessageBox.Show(Me, "Descuento sobrepasa el 100%, favor de introducir valor de 0% a 100%.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDesc.SelectAll()
            txtDesc.Focus()
            Exit Sub
        End If


        If txtDescripcion.Text = "" Or txtPrecioCosto.Text <= 0 Or txtPrecioLista.Text <= 0 Or txtClave.Text = "" Or txtCodigoBarras.Text = "" Or CmbGrupo.Text = "" Or CmbTipoVenta.Text = "" Or CmbUnidad.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Campos Obligatorios para crear un Producto", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If txtClaveProducto.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Clave Producto vacio, favor de introducir el valor correspondiente al SAT.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtClaveProducto.SelectAll()
            Exit Sub
        End If

        If txtClaveUnidad.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Clave Unidad vacio, favor de introducir el valor correspondiente al SAT.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtClaveUnidad.SelectAll()
            Exit Sub
        End If

        'FrmBuscarProductos.txtDescripcion.Text = txtDescripcion.Text
        Select Case chkPrecioManual.Checked
            Case True
                lv_PrecioManual = 1
            Case False
                lv_PrecioManual = 0
        End Select

        Select Case chkTC.Checked
            Case True
                lv_UsarTC = 1
            Case False
                lv_UsarTC = 0
        End Select

        Select Case chkTasaCero.Checked
            Case True
                lv_TasaCero = 1
            Case False
                lv_TasaCero = 0
        End Select

        'Try
        Dim StrProductos As New tblProductos

        StrProductos.IdComp = CompanyCode
        StrProductos.codigoBarras = txtCodigoBarras.Text
        StrProductos.clave = txtClave.Text
        StrProductos.descripcionProducto = txtDescripcion.Text
        StrProductos.unidadMedida = CmbUnidad.Text
        StrProductos.marca = ""
        StrProductos.grupo = CmbGrupo.Text
        StrProductos.familia = CmbFamilia.Text
        StrProductos.subfamilia = CmbSubFamilia.Text
        StrProductos.linea = CmbLinea.Text
        StrProductos.proveedor = CmbProveedor.Text
        StrProductos.tipoVenta = CmbTipoVenta.Text
        StrProductos.descuento = CDbl(txtDesc.Text)
        StrProductos.precioLista = CDbl(txtPrecioLista.Text)
        StrProductos.precioCosto = CDbl(txtPrecioCosto.Text)
        StrProductos.precioPublico = CDbl(txtPrecioPublico.Text)
        StrProductos.precioP1 = CDbl(txtPrecioP1.Text)
        StrProductos.precioP2 = CDbl(txtPrecioP2.Text)
        StrProductos.precioP3 = CDbl(txtPrecioP3.Text)
        StrProductos.stock = CInt(txtStock.Text)
        StrProductos.precioManual = lv_PrecioManual
        StrProductos.Inventario = 0
        StrProductos.UsarTC = CInt(CInt(lv_UsarTC))
        StrProductos.TC = CInt(CDbl(GranTipoCambio))
        StrProductos.ClaveProducto = CInt(txtClaveProducto.Text)
        StrProductos.ClaveUnidad = txtClaveUnidad.Text
        StrProductos.TasaCero = CInt(lv_TasaCero)

        If Add_Update = False Then
            If Checa_CodigoBarras() = True Then
                MetroFramework.MetroMessageBox.Show(Me, "Código de Barras ya existe, favor de cambiarlo.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCodigoBarras.SelectAll()
                Exit Sub
            End If

            If Checa_Clave() = True Then
                MetroFramework.MetroMessageBox.Show(Me, "La Clave ya existe, favor de cambiarlo.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtClave.SelectAll()
                Exit Sub
            End If

            If DBModelo.InsertProductos(StrProductos) Then
                MetroFramework.MetroMessageBox.Show(Me, "Producto creado correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Producto NO pudo ser creado.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            StrProductos.IdProducto = lv_idProducto
            If DBModelo.UpdateProductos(StrProductos) Then
                MetroFramework.MetroMessageBox.Show(Me, "Producto actualizado correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Producto NO pudo ser actualizado.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Add_Update = False
        LimpiarObjetos()
        Close()
    End Sub
End Class