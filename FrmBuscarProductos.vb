Public Class FrmBuscarProductos
    Private Sub LimpiarObjetos()
        txtDescripcion.Clear()
        txtClave.Clear()
        txtCodigoBarras.Clear()
        txtFamilia.Clear()
        txtGrupo.Clear()
        txtLinea.Clear()

        MetroGrid1.Refresh()

    End Sub

    Private Sub FrmBuscarProductos_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                LimpiarObjetos()
                Close()
        End Select
    End Sub

    Private Sub FrmBuscarProductos_Leave(sender As Object, e As System.EventArgs) Handles Me.Leave
        LimpiarObjetos()
    End Sub

    Private Sub MetroGrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellDoubleClick
        Try
            Add_Update = True
            Dim oForm As New FrmProductos
            oForm.Text = "Modificar Producto en el Sistema"
            oForm.lv_idProducto = CLng(MetroGrid1.Item(1, MetroGrid1.CurrentRow.Index).Value)
            oForm.txtIdProducto.Text = CStr(MetroGrid1.Item(1, MetroGrid1.CurrentRow.Index).Value)
            oForm.txtCodigoBarras.Text = CStr(MetroGrid1.Item(2, MetroGrid1.CurrentRow.Index).Value)
            oForm.txtClave.Text = CStr(MetroGrid1.Item(3, MetroGrid1.CurrentRow.Index).Value)
            oForm.txtDescripcion.Text = CStr(MetroGrid1.Item(4, MetroGrid1.CurrentRow.Index).Value)
            Material_Umedida = CStr(MetroGrid1.Item(5, MetroGrid1.CurrentRow.Index).Value)
            Material_Marca = CStr(MetroGrid1.Item(6, MetroGrid1.CurrentRow.Index).Value)
            Material_Grupo = CStr(MetroGrid1.Item(7, MetroGrid1.CurrentRow.Index).Value)
            Material_Familia = CStr(MetroGrid1.Item(8, MetroGrid1.CurrentRow.Index).Value)
            Material_SubFam = CStr(MetroGrid1.Item(9, MetroGrid1.CurrentRow.Index).Value)
            Material_Linea = CStr(MetroGrid1.Item(10, MetroGrid1.CurrentRow.Index).Value)
            Material_Proveedores = CStr(MetroGrid1.Item(11, MetroGrid1.CurrentRow.Index).Value)
            oForm.CmbTipoVenta.Text = CStr(MetroGrid1.Item(12, MetroGrid1.CurrentRow.Index).Value)
            oForm.txtDesc.Text = CStr(MetroGrid1.Item(13, MetroGrid1.CurrentRow.Index).Value)
            oForm.txtPrecioLista.Text = CStr(MetroGrid1.Item(14, MetroGrid1.CurrentRow.Index).Value)
            oForm.txtPrecioCosto.Text = CStr(MetroGrid1.Item(15, MetroGrid1.CurrentRow.Index).Value)
            oForm.txtPrecioPublico.Text = CStr(MetroGrid1.Item(16, MetroGrid1.CurrentRow.Index).Value)
            oForm.txtPrecioP1.Text = CStr(MetroGrid1.Item(17, MetroGrid1.CurrentRow.Index).Value)
            oForm.txtPrecioP2.Text = CStr(MetroGrid1.Item(18, MetroGrid1.CurrentRow.Index).Value)
            oForm.txtPrecioP3.Text = CStr(MetroGrid1.Item(19, MetroGrid1.CurrentRow.Index).Value)
            oForm.txtStock.Text = CStr(MetroGrid1.Item(20, MetroGrid1.CurrentRow.Index).Value)
            If CBool(MetroGrid1.Item(21, MetroGrid1.CurrentRow.Index).Value) = True Then
                oForm.chkPrecioManual.Checked = True
            Else
                oForm.chkPrecioManual.Checked = False
            End If
            If CBool(MetroGrid1.Item(23, MetroGrid1.CurrentRow.Index).Value) = True Then
                oForm.chkTC.Checked = True
            Else
                oForm.chkTC.Checked = False
            End If
            oForm.txtClaveProducto.Text = CStr(MetroGrid1.Item(25, MetroGrid1.CurrentRow.Index).Value)
            oForm.txtClaveUnidad.Text = CStr(MetroGrid1.Item(26, MetroGrid1.CurrentRow.Index).Value)
            If CBool(MetroGrid1.Item(27, MetroGrid1.CurrentRow.Index).Value) = True Then
                oForm.chkTasaCero.Checked = True
            Else
                oForm.chkTasaCero.Checked = False
            End If
            oForm.txtClave.Enabled = False
            oForm.txtCodigoBarras.Enabled = False
            oForm.ShowDialog()
            oForm.Close()
            MetroGrid1.Refresh()
            refresh_data_dgv()
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.InnerException.Message)
        End Try

    End Sub

    Private Sub refresh_data_dgv()
        MetroGrid1.Refresh()

        If txtClave.Text <> "" Or txtCodigoBarras.Text <> "" Or txtDescripcion.Text <> "" Or txtFamilia.Text <> "" Or txtGrupo.Text <> "" Or txtLinea.Text <> "" Then
            Dim products As List(Of tblProductos) = DBModelo.GetProducts(txtDescripcion.Text, txtCodigoBarras.Text, txtClave.Text, txtGrupo.Text, txtFamilia.Text, txtLinea.Text)

            MetroGrid1.Refresh()
            MetroGrid1.DataSource = products.ToList

            MetroGrid1.Columns(0).HeaderText = "IdComp"
            MetroGrid1.Columns(0).Visible = False

            MetroGrid1.Columns(1).HeaderText = "Id"
            MetroGrid1.Columns(1).Visible = False

            MetroGrid1.Columns(2).HeaderText = "CB"

            MetroGrid1.Columns(3).HeaderText = "Clave"

            MetroGrid1.Columns(4).HeaderText = "Descripción"

            MetroGrid1.Columns(5).HeaderText = "UoM"

            MetroGrid1.Columns(6).Visible = False

            MetroGrid1.Columns(7).HeaderText = "Grupo"

            MetroGrid1.Columns(8).HeaderText = "Familia"

            MetroGrid1.Columns(9).HeaderText = "SubFamilia"
            MetroGrid1.Columns(9).Visible = False

            MetroGrid1.Columns(10).HeaderText = "Linea"

            MetroGrid1.Columns(11).HeaderText = "Proveedor"
            MetroGrid1.Columns(11).Visible = False

            MetroGrid1.Columns(12).HeaderText = "TipoVenta"
            MetroGrid1.Columns(12).Visible = False

            MetroGrid1.Columns(13).HeaderText = "Descuento"

            MetroGrid1.Columns(14).HeaderText = "PrecioLista"

            MetroGrid1.Columns(15).HeaderText = "PrecioCosto"

            MetroGrid1.Columns(16).HeaderText = "PrecioPublico"

            MetroGrid1.Columns(17).HeaderText = "Precio P1"

            MetroGrid1.Columns(18).HeaderText = "Precio P2"

            MetroGrid1.Columns(19).HeaderText = "Precio P3"

            MetroGrid1.Columns(20).HeaderText = "Stock"
            MetroGrid1.Columns(20).Visible = False

            MetroGrid1.Columns(21).HeaderText = "PrecioManual"

            MetroGrid1.Columns(22).HeaderText = "Inventario"
            MetroGrid1.Columns(22).Visible = False

            MetroGrid1.Columns(23).HeaderText = "UsarTC"

            MetroGrid1.Columns(24).HeaderText = "TC"

            MetroGrid1.Columns(25).HeaderText = "ClaveProducto"

            MetroGrid1.Columns(26).HeaderText = "ClaveUnidad"

            MetroGrid1.Columns(27).HeaderText = "TasaCero"
        End If
    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            refresh_data_dgv()
        End If
    End Sub

    Private Sub txtClave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtClave.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            refresh_data_dgv()
        End If
    End Sub

    Private Sub txtCodigoBarras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoBarras.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            refresh_data_dgv()
        End If
    End Sub

    Private Sub txtFamilia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFamilia.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            refresh_data_dgv()
        End If
    End Sub

    Private Sub txtGrupo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGrupo.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            refresh_data_dgv()
        End If
    End Sub

    Private Sub txtLinea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLinea.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            refresh_data_dgv()
        End If
    End Sub

    Private Sub FrmBuscarProductos_Load(sender As System.Object, e As EventArgs) Handles MyBase.Load
        LimpiarObjetos()
    End Sub

    Private Sub MetroGrid1_MouseUp(sender As Object, e As MouseEventArgs) Handles MetroGrid1.MouseUp
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            If MetroGrid1.RowCount > 0 Then
                MetroContextMenu1.Show(MetroGrid1, New Point(e.X, e.Y))
            End If
        End If
    End Sub

    Private Sub CopiarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarProductoToolStripMenuItem.Click
        Add_Update = False
        Dim oForm As New FrmProductos
        oForm.Text = "Crear Producto"
        oForm.lv_idProducto = CLng("0")
        oForm.txtIdProducto.Text = ""
        oForm.txtCodigoBarras.Text = ""
        oForm.txtClave.Text = ""
        oForm.txtDescripcion.Text = CStr(MetroGrid1.Item(4, MetroGrid1.CurrentRow.Index).Value)
        Material_Umedida = CStr(MetroGrid1.Item(5, MetroGrid1.CurrentRow.Index).Value)
        Material_Grupo = CStr(MetroGrid1.Item(7, MetroGrid1.CurrentRow.Index).Value)
        Material_Familia = CStr(MetroGrid1.Item(8, MetroGrid1.CurrentRow.Index).Value)
        Material_SubFam = CStr(MetroGrid1.Item(9, MetroGrid1.CurrentRow.Index).Value)
        Material_Linea = CStr(MetroGrid1.Item(10, MetroGrid1.CurrentRow.Index).Value)
        Material_Proveedores = CStr(MetroGrid1.Item(11, MetroGrid1.CurrentRow.Index).Value)
        oForm.CmbTipoVenta.Text = CStr(MetroGrid1.Item(12, MetroGrid1.CurrentRow.Index).Value)
        oForm.txtDesc.Text = CStr(MetroGrid1.Item(14, MetroGrid1.CurrentRow.Index).Value)
        If CBool(MetroGrid1.Item(21, MetroGrid1.CurrentRow.Index).Value) = True Then
            oForm.chkPrecioManual.Checked = True
        Else
            oForm.chkPrecioManual.Checked = False
        End If
        If CBool(MetroGrid1.Item(23, MetroGrid1.CurrentRow.Index).Value) = True Then
            oForm.chkTC.Checked = True
        Else
            oForm.chkTC.Checked = False
        End If

        oForm.txtClaveProducto.Text = CStr(MetroGrid1.Item(25, MetroGrid1.CurrentRow.Index).Value)
        oForm.txtClaveUnidad.Text = CStr(MetroGrid1.Item(26, MetroGrid1.CurrentRow.Index).Value)
        If CBool(MetroGrid1.Item(27, MetroGrid1.CurrentRow.Index).Value) = True Then
            oForm.chkTasaCero.Checked = True
        Else
            oForm.chkTasaCero.Checked = False
        End If

        oForm.ShowDialog()
        oForm.Close()
        MetroGrid1.Refresh()
        refresh_data_dgv()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_Update = False
        Dim oForm As New FrmProductos
        oForm.Text = "Crear Producto"
        Material_Familia = ""
        Material_Grupo = ""
        Material_Linea = ""
        Material_Proveedores = ""
        Material_SubFam = ""
        Material_Umedida = ""
        oForm.txtClave.Enabled = True
        oForm.txtCodigoBarras.Enabled = True

        oForm.ShowDialog()
        oForm.Close()
        If txtClave.Text <> "" Or txtCodigoBarras.Text <> "" Or txtDescripcion.Text <> "" Or txtFamilia.Text <> "" Or txtGrupo.Text <> "" Or txtLinea.Text <> "" Then
            MetroGrid1.Refresh()
            refresh_data_dgv()
        End If
        txtDescripcion.Focus()
        txtDescripcion.SelectAll()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LimpiarObjetos()
        Close()
    End Sub

End Class