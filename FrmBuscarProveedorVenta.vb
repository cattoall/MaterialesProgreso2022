Public Class FrmBuscarProveedorVenta

    Private Sub LimpiarObjetos()
        MetroGrid1.Refresh()
        txtBusqueda.Clear()
    End Sub

    Private Sub FrmBuscarProveedorVenta_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                idProveedor = "0"
                LimpiarObjetos()
                Call btnSalir_Click(sender, e)
        End Select
    End Sub

    Private Sub FrmBuscarProveedorVenta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LimpiarObjetos()
    End Sub

    Private Sub txtBusqueda_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtBusqueda.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            refresh_data_dgv()
            MetroGrid1.Focus()
        End If
    End Sub

    Private Sub refresh_data_dgv()
        MetroGrid1.Refresh()
        Dim Proveedores As List(Of tblProveedor) = DBModelo.GetProveedorByDesc(txtBusqueda.Text)

        MetroGrid1.DataSource = Proveedores.ToList

        MetroGrid1.Columns(0).HeaderText = "ID"
        MetroGrid1.Columns(0).ReadOnly = True
        MetroGrid1.Columns(0).Width = 50

        MetroGrid1.Columns(1).HeaderText = "Razón Social"
        MetroGrid1.Columns(1).ReadOnly = True
        MetroGrid1.Columns(1).Width = 400

        MetroGrid1.Columns(2).HeaderText = "Domicilio"
        MetroGrid1.Columns(2).ReadOnly = True
        MetroGrid1.Columns(2).Width = 300

        MetroGrid1.Columns(3).HeaderText = "Número"
        MetroGrid1.Columns(3).ReadOnly = True
        MetroGrid1.Columns(3).Visible = False

        MetroGrid1.Columns(4).HeaderText = "Colonia"
        MetroGrid1.Columns(4).ReadOnly = True
        MetroGrid1.Columns(4).Visible = False

        MetroGrid1.Columns(5).HeaderText = "Ciudad"
        MetroGrid1.Columns(5).ReadOnly = True
        MetroGrid1.Columns(5).Visible = False

        MetroGrid1.Columns(6).HeaderText = "Estado"
        MetroGrid1.Columns(6).ReadOnly = True
        MetroGrid1.Columns(6).Visible = False

        MetroGrid1.Columns(7).HeaderText = "Código Postal"
        MetroGrid1.Columns(7).ReadOnly = True
        MetroGrid1.Columns(7).Visible = False

        MetroGrid1.Columns(8).HeaderText = "R.F.C."
        MetroGrid1.Columns(8).ReadOnly = True
        MetroGrid1.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        MetroGrid1.Columns(9).HeaderText = "Teléfono"
        MetroGrid1.Columns(9).ReadOnly = True
        MetroGrid1.Columns(9).Visible = False

        MetroGrid1.Columns(10).HeaderText = "Celular"
        MetroGrid1.Columns(10).ReadOnly = True
        MetroGrid1.Columns(10).Visible = False

        MetroGrid1.Columns(11).HeaderText = "Email"
        MetroGrid1.Columns(11).ReadOnly = True
        MetroGrid1.Columns(11).Visible = False

        MetroGrid1.Columns(12).HeaderText = "Contacto"
        MetroGrid1.Columns(12).ReadOnly = True
        MetroGrid1.Columns(12).Visible = False

        MetroGrid1.Columns(13).HeaderText = "Observaciones"
        MetroGrid1.Columns(13).ReadOnly = True
        MetroGrid1.Columns(13).Visible = False

    End Sub

    Private Sub get_selected_customer()
        idProveedor = MetroGrid1.Item(0, MetroGrid1.CurrentRow.Index).Value
        Select Case Buscar_Proveedores
            Case "PROVEEDORES"
                FrmHistoProveedores.txtCliente.Text = MetroGrid1.Item(1, MetroGrid1.CurrentRow.Index).Value
        End Select
        LimpiarObjetos()
        Close()
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        LimpiarObjetos()
        Close()
    End Sub

    Private Sub MetroGrid1_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MetroGrid1.CellDoubleClick
        get_selected_customer()
    End Sub

    Private Sub MetroGrid1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles MetroGrid1.KeyDown
        If e.KeyCode = Keys.Enter Then
            get_selected_customer()
            e.Handled = True
        End If
    End Sub
End Class