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
        Add_Update                          = True
        FrmProductos.Text                   = "Modificar Producto en el Sistema"
        FrmProductos.lv_idProducto          = MetroGrid1.Item(1,  MetroGrid1.CurrentRow.Index).Value
        FrmProductos.txtIdProducto.Text     = MetroGrid1.Item(1,  MetroGrid1.CurrentRow.Index).Value
        FrmProductos.txtCodigoBarras.Text   = MetroGrid1.Item(2,  MetroGrid1.CurrentRow.Index).Value
        FrmProductos.txtClave.Text          = MetroGrid1.Item(3,  MetroGrid1.CurrentRow.Index).Value
        FrmProductos.txtDescripcion.Text    = MetroGrid1.Item(4,  MetroGrid1.CurrentRow.Index).Value
        Material_Umedida                    = MetroGrid1.Item(5,  MetroGrid1.CurrentRow.Index).Value
        Material_Grupo                      = MetroGrid1.Item(7,  MetroGrid1.CurrentRow.Index).Value
        Material_Familia                    = MetroGrid1.Item(8,  MetroGrid1.CurrentRow.Index).Value
        Material_SubFam                     = MetroGrid1.Item(9,  MetroGrid1.CurrentRow.Index).Value
        Material_Linea                      = MetroGrid1.Item(10,  MetroGrid1.CurrentRow.Index).Value
        Material_Proveedores                = MetroGrid1.Item(11,  MetroGrid1.CurrentRow.Index).Value
        FrmProductos.CmbTipoVenta.Text      = MetroGrid1.Item(12, MetroGrid1.CurrentRow.Index).Value
        FrmProductos.txtDesc.Text           = MetroGrid1.Item(13, MetroGrid1.CurrentRow.Index).Value
        FrmProductos.txtPrecioLista.Text    = MetroGrid1.Item(14, MetroGrid1.CurrentRow.Index).Value
        FrmProductos.txtPrecioCosto.Text    = MetroGrid1.Item(15, MetroGrid1.CurrentRow.Index).Value
        FrmProductos.txtPrecioPublico.Text  = MetroGrid1.Item(16, MetroGrid1.CurrentRow.Index).Value
        FrmProductos.txtPrecioP1.Text       = MetroGrid1.Item(17, MetroGrid1.CurrentRow.Index).Value
        FrmProductos.txtPrecioP2.Text       = MetroGrid1.Item(18, MetroGrid1.CurrentRow.Index).Value
        FrmProductos.txtPrecioP3.Text       = MetroGrid1.Item(19, MetroGrid1.CurrentRow.Index).Value
        FrmProductos.txtStock.Text          = MetroGrid1.Item(20, MetroGrid1.CurrentRow.Index).Value

        If MetroGrid1.Item(21, MetroGrid1.CurrentRow.Index).Value = True Then
            FrmProductos.chkPrecioManual.Checked = True
        Else
            FrmProductos.chkPrecioManual.Checked = False
        End If

        If MetroGrid1.Item(23, MetroGrid1.CurrentRow.Index).Value = True Then
            FrmProductos.chkTC.Checked = True
        Else
            FrmProductos.chkTC.Checked = False
        End If

        FrmProductos.txtClaveProducto.Text = MetroGrid1.Item(25, MetroGrid1.CurrentRow.Index).Value
        FrmProductos.txtClaveUnidad.Text = MetroGrid1.Item(26, MetroGrid1.CurrentRow.Index).Value

        If MetroGrid1.Item(27, MetroGrid1.CurrentRow.Index).Value = True Then
            FrmProductos.chkTasaCero.Checked = True
        Else
            FrmProductos.chkTasaCero.Checked = False
        End If

        FrmProductos.txtClave.Enabled        = False
        FrmProductos.txtCodigoBarras.Enabled = False
        FrmProductos.ShowDialog()
        FrmProductos.Close()
        FrmProductos.Dispose()
        MetroGrid1.Refresh()
        refresh_data_dgv()
    End Sub

    Private Sub refresh_data_dgv()
        MetroGrid1.Refresh()

        If txtClave.Text <> "" Or txtCodigoBarras.Text <> "" Or txtDescripcion.Text <> "" Or txtFamilia.Text <> "" Or txtGrupo.Text <> "" Or txtLinea.Text <> "" Then
            Dim products As List(Of tblProductos) = DBModelo.GetProducts(txtDescripcion.Text, txtCodigoBarras.Text, txtClave.Text, txtGrupo.Text, txtFamilia.Text, txtLinea.Text)

            MetroGrid1.Refresh()
            MetroGrid1.DataSource = products.ToList

            MetroGrid1.Columns(0).HeaderText    = "IdComp"
            MetroGrid1.Columns(0).Visible       = False
            MetroGrid1.Columns(1).HeaderText    = "Id"
            MetroGrid1.Columns(1).Visible       = False
            MetroGrid1.Columns(2).HeaderText    = "CB"
            MetroGrid1.Columns(3).HeaderText    = "Clave"
            MetroGrid1.Columns(4).HeaderText    = "Descripción"
            MetroGrid1.Columns(5).HeaderText    = "UoM"
            MetroGrid1.Columns(6).Visible       = False
            MetroGrid1.Columns(7).HeaderText    = "Grupo"
            MetroGrid1.Columns(8).HeaderText    = "Familia"
            MetroGrid1.Columns(9).HeaderText    = "SubFamilia"
            MetroGrid1.Columns(9).Visible       = False
            MetroGrid1.Columns(10).HeaderText    = "Linea"
            MetroGrid1.Columns(11).HeaderText    = "Proveedor"
            MetroGrid1.Columns(11).Visible       = False
            MetroGrid1.Columns(12).HeaderText   = "TipoVenta"
            MetroGrid1.Columns(12).Visible      = False
            MetroGrid1.Columns(13).HeaderText   = "Descuento"
            MetroGrid1.Columns(14).HeaderText   = "PrecioLista"
            MetroGrid1.Columns(15).HeaderText   = "PrecioCosto"
            MetroGrid1.Columns(16).HeaderText   = "PrecioPublico"
            MetroGrid1.Columns(17).HeaderText   = "Precio P1"
            MetroGrid1.Columns(18).HeaderText   = "Precio P2"
            MetroGrid1.Columns(19).HeaderText   = "Precio P3"
            MetroGrid1.Columns(20).HeaderText   = "Stock"
            MetroGrid1.Columns(20).Visible      = False
            MetroGrid1.Columns(21).HeaderText   = "PrecioManual"
            MetroGrid1.Columns(22).HeaderText   = "Inventario"
            MetroGrid1.Columns(22).Visible      = False
            MetroGrid1.Columns(23).HeaderText   = "UsarTC"
            MetroGrid1.Columns(24).HeaderText   = "TC"
            MetroGrid1.Columns(25).HeaderText   = "ClaveProducto"
            MetroGrid1.Columns(26).HeaderText   = "ClaveUnidad"
            MetroGrid1.Columns(27).HeaderText   = "TasaCero"
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

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) 
        
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
        FrmProductos.Text = "Crear Producto"
        FrmProductos.lv_idProducto = "0"
        FrmProductos.txtIdProducto.Text = ""
        FrmProductos.txtCodigoBarras.Text = ""
        FrmProductos.txtClave.Text = ""
        FrmProductos.txtDescripcion.Text = MetroGrid1.Item(3, MetroGrid1.CurrentRow.Index).Value
        Material_Umedida = MetroGrid1.Item(4, MetroGrid1.CurrentRow.Index).Value
        Material_Grupo = MetroGrid1.Item(5, MetroGrid1.CurrentRow.Index).Value
        Material_Familia = MetroGrid1.Item(6, MetroGrid1.CurrentRow.Index).Value
        Material_SubFam = MetroGrid1.Item(7, MetroGrid1.CurrentRow.Index).Value
        Material_Linea = MetroGrid1.Item(8, MetroGrid1.CurrentRow.Index).Value
        Material_Proveedores = MetroGrid1.Item(9, MetroGrid1.CurrentRow.Index).Value
        FrmProductos.CmbTipoVenta.Text = MetroGrid1.Item(10, MetroGrid1.CurrentRow.Index).Value
        FrmProductos.txtDesc.Text = MetroGrid1.Item(11, MetroGrid1.CurrentRow.Index).Value
        If MetroGrid1.Item(19, MetroGrid1.CurrentRow.Index).Value = True Then
            FrmProductos.chkPrecioManual.Checked = True
        Else
            FrmProductos.chkPrecioManual.Checked = False
        End If
        If MetroGrid1.Item(21, MetroGrid1.CurrentRow.Index).Value = True Then
            FrmProductos.chkTC.Checked = True
        Else
            FrmProductos.chkTC.Checked = False
        End If

        FrmProductos.txtClaveProducto.Text = MetroGrid1.Item(23, MetroGrid1.CurrentRow.Index).Value
        FrmProductos.txtClaveUnidad.Text = MetroGrid1.Item(24, MetroGrid1.CurrentRow.Index).Value
        If MetroGrid1.Item(25, MetroGrid1.CurrentRow.Index).Value = True Then
            FrmProductos.chkTasaCero.Checked = True
        Else
            FrmProductos.chkTasaCero.Checked = False
        End If

        FrmProductos.ShowDialog()
        FrmProductos.Close()
        FrmProductos.Dispose()
        MetroGrid1.Refresh()
        refresh_data_dgv()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_Update = False
        FrmProductos.Text = "Crear Producto"
        Material_Familia = ""
        Material_Grupo = ""
        Material_Linea = ""
        Material_Proveedores = ""
        Material_SubFam = ""
        Material_Umedida = ""
        FrmProductos.txtClave.Enabled = True
        FrmProductos.txtCodigoBarras.Enabled = True

        FrmProductos.ShowDialog()
        FrmProductos.Close()
        FrmProductos.Dispose()
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