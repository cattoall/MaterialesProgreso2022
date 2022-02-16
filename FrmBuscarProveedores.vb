Public Class FrmBuscarProveedores
    Private Sub LimpiarObjetos()
        MetroGrid1.Refresh()
        txtBusqueda.Clear()
    End Sub

    Private Sub FrmBuscarProveedores_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                LimpiarObjetos()
                Close()
        End Select
    End Sub

    Private Sub FrmBuscarProveedores_Leave(sender As Object, e As System.EventArgs) Handles Me.Leave
        LimpiarObjetos()
    End Sub

    Private Sub txtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusqueda.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            refresh_data_dgv()
        End If
    End Sub

    Private Sub refresh_data_dgv()
        MetroGrid1.Refresh()
        Dim Proveedores As List(Of tblProveedor) = DBModelo.GetProveedorByDesc(txtBusqueda.Text)

        MetroGrid1.DataSource = Proveedores.ToList
        MetroGrid1.Columns(0).Visible = False

        Dim i As Int16 = 0

        For i = 0 To MetroGrid1.Columns.Count - 1 
            MetroGrid1.Columns(i).ReadOnly = True
            'MetroGrid1.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next

        MetroGrid1.Columns(1).HeaderText = "ID"
        MetroGrid1.Columns(1).Width = 50

        MetroGrid1.Columns(2).HeaderText = "Razón Social"
        MetroGrid1.Columns(2).Width = 300

        MetroGrid1.Columns(3).HeaderText = "Domicilio"
        MetroGrid1.Columns(3).Width = 200

        MetroGrid1.Columns(9).HeaderText = "R.F.C."
        MetroGrid1.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        MetroGrid1.Columns(4).HeaderText = "Número"
        MetroGrid1.Columns(4).Visible = False

        MetroGrid1.Columns(5).HeaderText = "Colonia"
        MetroGrid1.Columns(5).Visible = False

        MetroGrid1.Columns(6).HeaderText = "Ciudad"
        MetroGrid1.Columns(6).Visible = False

        MetroGrid1.Columns(7).HeaderText = "Estado"
        MetroGrid1.Columns(7).Visible = False

        MetroGrid1.Columns(8).HeaderText = "Código Postal"
        MetroGrid1.Columns(8).Visible = False

        MetroGrid1.Columns(10).HeaderText = "Teléfono"
        MetroGrid1.Columns(10).Visible = False

        MetroGrid1.Columns(11).HeaderText = "Celular"
        MetroGrid1.Columns(11).Visible = False

        MetroGrid1.Columns(12).HeaderText = "Email"
        MetroGrid1.Columns(12).Visible = False

        MetroGrid1.Columns(13).HeaderText = "Contacto"
        MetroGrid1.Columns(13).Visible = False

        MetroGrid1.Columns(14).HeaderText = "Observaciones"
        MetroGrid1.Columns(14).Visible = False
    End Sub

    Private Sub MetroGrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellDoubleClick
        Add_Update = True
        FrmProveedor.Text = "Modificar Proveedor"

        FrmProveedor.lv_idProveedor         = MetroGrid1.Item(1, MetroGrid1.CurrentRow.Index).Value
        FrmProveedor.txtRazonSocial.Text    = MetroGrid1.Item(2, MetroGrid1.CurrentRow.Index).Value
        FrmProveedor.lv_ValorAnterior       = MetroGrid1.Item(2, MetroGrid1.CurrentRow.Index).Value
        FrmProveedor.txtDomicilio.Text      = MetroGrid1.Item(3, MetroGrid1.CurrentRow.Index).Value
        FrmProveedor.txtNumExterno.Text     = MetroGrid1.Item(4, MetroGrid1.CurrentRow.Index).Value
        FrmProveedor.txtColonia.Text        = MetroGrid1.Item(5, MetroGrid1.CurrentRow.Index).Value
        FrmProveedor.txtCiudad.Text         = MetroGrid1.Item(6, MetroGrid1.CurrentRow.Index).Value
        FrmProveedor.txtEstado.Text         = MetroGrid1.Item(7, MetroGrid1.CurrentRow.Index).Value
        FrmProveedor.txtCodigoPostal.Text   = MetroGrid1.Item(8, MetroGrid1.CurrentRow.Index).Value
        FrmProveedor.txtRFC.Text            = MetroGrid1.Item(9, MetroGrid1.CurrentRow.Index).Value
        FrmProveedor.txtTelFijo.Text        = MetroGrid1.Item(10, MetroGrid1.CurrentRow.Index).Value
        FrmProveedor.txtMovil.Text          = MetroGrid1.Item(11, MetroGrid1.CurrentRow.Index).Value
        FrmProveedor.txtEmail.Text          = MetroGrid1.Item(12, MetroGrid1.CurrentRow.Index).Value
        FrmProveedor.txtContacto.Text       = MetroGrid1.Item(13, MetroGrid1.CurrentRow.Index).Value
        FrmProveedor.txtObs.Text            = MetroGrid1.Item(14, MetroGrid1.CurrentRow.Index).Value

        FrmProveedor.ShowDialog()
        FrmProveedor.Close()
        FrmProveedor.Dispose()
        LimpiarObjetos()
        refresh_data_dgv()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) 
        LimpiarObjetos()
        Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) 
        Add_Update = False
        FrmProveedor.Text = "Crear Proveedor"
        FrmProveedor.ShowDialog()
        FrmProveedor.Close()
        FrmProveedor.Dispose()
        LimpiarObjetos()
        refresh_data_dgv()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add_Update = False
        FrmProveedor.Text = "Crear Proveedor"
        FrmProveedor.ShowDialog()
        FrmProveedor.Close()
        FrmProveedor.Dispose()
        LimpiarObjetos()
        refresh_data_dgv()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LimpiarObjetos()
        Close()
    End Sub
End Class