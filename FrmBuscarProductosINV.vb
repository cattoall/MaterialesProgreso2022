﻿
Public Class FrmBuscarProductosINV
    Private Sub LimpiarObjetos()

    End Sub

    Private Sub FrmBuscarProductosINV_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                MetroGrid1.Refresh()
                AccionSalir = True
                Close()
        End Select
    End Sub

    Private Sub FrmBuscarProductos_Leave(sender As Object, e As System.EventArgs) Handles Me.Leave
        LimpiarObjetos()
    End Sub


    Private Sub refresh_data_dgv()
        If txtDescripcion.Text <> "" Then

            MetroGrid1.Refresh()

            Dim products As List(Of tblProductos) = DBModelo.GetProducts(txtDescripcion.Text, "", "", "", "", "")

            MetroGrid1.Refresh()
            MetroGrid1.DataSource = products.ToList

            MetroGridLayout()

        Else
            MetroFramework.MetroMessageBox.Show(Me, "Especifica una descripción del producto a buscar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescripcion.Select()
        End If
    End Sub

    Private Sub MetroGridLayout()
        MetroGrid1.Columns(0).Visible = False
        MetroGrid1.Columns(1).HeaderText = "Id"
        MetroGrid1.Columns(1).Visible = False
        MetroGrid1.Columns(2).HeaderText = "CB"
        MetroGrid1.Columns(3).HeaderText = "Clave"
        MetroGrid1.Columns(4).HeaderText = "Descripción"
        MetroGrid1.Columns(5).HeaderText = "UoM"
        MetroGrid1.Columns(6).HeaderText = "Grupo"
        MetroGrid1.Columns(7).HeaderText = "Familia"
        MetroGrid1.Columns(8).HeaderText = "SubFamilia"
        MetroGrid1.Columns(8).Visible = False
        MetroGrid1.Columns(9).HeaderText = "Linea"
        MetroGrid1.Columns(10).HeaderText = "Proveedor"
        MetroGrid1.Columns(10).Visible = False
        MetroGrid1.Columns(11).HeaderText = "TipoVenta"
        MetroGrid1.Columns(11).Visible = False
        MetroGrid1.Columns(12).HeaderText = "Descuento"
        MetroGrid1.Columns(13).HeaderText = "PrecioLista"
        MetroGrid1.Columns(14).HeaderText = "PrecioCosto"
        MetroGrid1.Columns(15).HeaderText = "PrecioPublico"
        MetroGrid1.Columns(16).HeaderText = "Precio P1"
        MetroGrid1.Columns(17).HeaderText = "Precio P2"
        MetroGrid1.Columns(18).HeaderText = "Precio P3"
        MetroGrid1.Columns(19).HeaderText = "Stock"
        MetroGrid1.Columns(19).Visible = False
        MetroGrid1.Columns(20).HeaderText = "PrecioManual"
        MetroGrid1.Columns(21).HeaderText = "Inventario"
        MetroGrid1.Columns(21).Visible = False
        MetroGrid1.Columns(22).HeaderText = "UsarTC"
        MetroGrid1.Columns(23).HeaderText = "TC"
        MetroGrid1.Columns(24).HeaderText = "ClaveProducto"
        MetroGrid1.Columns(25).HeaderText = "ClaveUnidad"
        MetroGrid1.Columns(26).HeaderText = "TasaCero"
    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            refresh_data_dgv()
            MetroGrid1.Focus()
        End If
    End Sub

    Private Sub FrmBuscarProductos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtDescripcion.Select()
        Llena_Grupos()
    End Sub

    Private Sub Llena_Grupos()
        Dim grps As List(Of tblGrupos) = DBModelo.GetGroupsAll

        If IsNothing(grps) Then
            Exit Sub
        End If

        LstGrupos.DataSource = grps
        LstGrupos.DisplayMember = "descripcion"
        LstGrupos.ValueMember = "clave"
    End Sub

    Private Sub LstGrupos_Click(sender As Object, e As System.EventArgs) Handles LstGrupos.Click
        MetroGrid1.Refresh()

        Dim products As List(Of tblProductos) = DBModelo.GetProducts("", "", "", LstGrupos.Text, "", "")

        MetroGrid1.Refresh()
        MetroGrid1.DataSource = products.ToList

        MetroGridLayout()
    End Sub

    Private Sub MetroGrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellDoubleClick
        get_selected_product()
    End Sub

    Private Sub MetroGrid1_KeyDown(sender As Object, e As KeyEventArgs) Handles MetroGrid1.KeyDown
        If e.KeyCode = Keys.Enter Then
            get_selected_product()
            e.Handled = True
        End If
    End Sub

    Private Sub get_selected_product()
        If MetroGrid1.RowCount > 0 Then
            Add_Update = True
            If CStr(MetroGrid1.Item(4, MetroGrid1.CurrentRow.Index).Value) <> "" Then
                FrmAjusteDeInventario.txtDescripcion.Text = CStr(MetroGrid1.Item(4, MetroGrid1.CurrentRow.Index).Value)
            ElseIf CStr(MetroGrid1.Item(4, MetroGrid1.CurrentRow.Index).Value) <> "" Then
                FrmAjusteDeInventario.txtDescripcion.Text = CStr(MetroGrid1.Item(5, MetroGrid1.CurrentRow.Index).Value)
            End If
            ProductoID = CStr(MetroGrid1.Item(1, MetroGrid1.CurrentRow.Index).Value)
            If CBool(MetroGrid1.Item(21, MetroGrid1.CurrentRow.Index).Value) = False Then
                Inventariado = False
            Else
                Inventariado = True
            End If
            MetroGrid1.Refresh()
            AccionSalir = False
            Close()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        MetroGrid1.Refresh()
        AccionSalir = True
        Close()
    End Sub
End Class