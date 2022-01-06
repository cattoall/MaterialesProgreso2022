Public Class FrmBuscarMarcas
    Private lv_idMarca
    Public lv_ValorAnterior As String

    Private Sub txtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusqueda.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            LimpiarObjetos()
            refresh_data_dgv()
        End If
    End Sub

    Private Sub refresh_data_dgv()
        MetroGrid1.Refresh()
        Console.WriteLine(txtBusqueda.Text)
        Dim Marca As List(Of tblMarcas) = DBModelo.GetMarcaByDesc(txtBusqueda.Text)

        MetroGrid1.DataSource = Marca.ToList

        MetroGrid1.Columns(0).HeaderText = "Id Marca"
        MetroGrid1.Columns(0).ReadOnly = True

        MetroGrid1.Columns(1).HeaderText = "Descripción"
        MetroGrid1.Columns(1).ReadOnly = True
        MetroGrid1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

    End Sub

    Private Sub LimpiarObjetos()
        MetroGrid1.Refresh()
        txtMarca.Clear()
    End Sub

    Private Sub FrmBuscarMarcas_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                LimpiarObjetos()
                Close()
        End Select
    End Sub

    Private Sub FrmBuscarMarcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarObjetos()
        txtBusqueda.Select()
        Add_Update = False
    End Sub

    Private Sub MetroGrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellDoubleClick
        Add_Update = True
        lv_idMarca = MetroGrid1.Item(0, MetroGrid1.CurrentRow.Index).Value
        txtMarca.Text = MetroGrid1.Item(1, MetroGrid1.CurrentRow.Index).Value
        lv_ValorAnterior = MetroGrid1.Item(1, MetroGrid1.CurrentRow.Index).Value
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        LimpiarObjetos()
        Close()
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        If txtMarca.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Favor de llenar el Campo Nombre de Marca", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim strMarca As New tblMarcas
        Select Case Add_Update
            Case True
                strMarca = DBModelo.GetMarca(lv_idMarca)
                If Not IsNothing(strMarca) Then
                    strMarca.descripcion = txtMarca.Text
                    If DBModelo.UpdateMarca(strMarca) Then
                        If lv_ValorAnterior <> txtMarca.Text Then
                            If DBModelo.UpdateMarcaProd(txtMarca.Text, lv_ValorAnterior) Then
                                MetroFramework.MetroMessageBox.Show(Me, "Marca actualizada correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MetroFramework.MetroMessageBox.Show(Me, "Marca actualizada, Productos NO pudieron ser actualizados.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        Else
                            MetroFramework.MetroMessageBox.Show(Me, "Marca actualizada correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, "Marca NO pudo ser actualizada.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Case False
                strMarca.descripcion = txtMarca.Text
                If DBModelo.InsertMarca(strMarca) Then
                    MetroFramework.MetroMessageBox.Show(Me, "Marca creada correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "Marca NO pudo ser creada.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
        End Select
        Add_Update = False
        Material_Marca = txtMarca.Text
        txtBusqueda.Text = txtMarca.Text
        LimpiarObjetos()
        refresh_data_dgv()
    End Sub
End Class