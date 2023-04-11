
Public Class FrmBuscarFamilias
    Private lv_idFamilia As Integer
    Public lv_ValorAnterior As String

    Private Sub LimpiarObjetos()
        MetroGrid1.Refresh()
        txtFamilia.Clear()
    End Sub

    Private Sub FrmBuscarFamilias_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                LimpiarObjetos()
                Close()
        End Select
    End Sub

    Private Sub FrmBuscarFamilias_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LimpiarObjetos()
        txtBusqueda.Select()
        Add_Update = False
    End Sub

    Private Sub txtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusqueda.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            LimpiarObjetos()
            refresh_data_dgv()
        End If
    End Sub

    Private Sub refresh_data_dgv()
        MetroGrid1.Refresh()
        Dim familia As List(Of tblFamilia) = DBModelo.GetFamiliaByDesc(txtBusqueda.Text)

        MetroGrid1.DataSource = familia.ToList

        MetroGrid1.Columns(0).Visible = False

        MetroGrid1.Columns(1).HeaderText = "Id Familia"
        MetroGrid1.Columns(1).ReadOnly = True

        MetroGrid1.Columns(2).HeaderText = "Descripción"
        MetroGrid1.Columns(2).ReadOnly = True
        MetroGrid1.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

    End Sub

    Private Sub MetroGrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellDoubleClick
        Add_Update = True
        lv_idFamilia = CInt(MetroGrid1.Item(1, MetroGrid1.CurrentRow.Index).Value)
        txtFamilia.Text = CStr(MetroGrid1.Item(2, MetroGrid1.CurrentRow.Index).Value)
        lv_ValorAnterior = CStr(MetroGrid1.Item(2, MetroGrid1.CurrentRow.Index).Value)
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) 
        If txtFamilia.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Favor de llenar el Campo Nombre de Familia", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim strFamilia As New tblFamilia
        Select Case Add_Update
            Case True
                strFamilia = DBModelo.GetFamilia(lv_idFamilia)
                If Not IsNothing(strFamilia) Then
                    strFamilia.descripcion = txtFamilia.Text
                    If DBModelo.UpdateFamilia(strFamilia) Then
                        If lv_ValorAnterior <> txtFamilia.Text Then
                            If DBModelo.UpdateFamiliaProd(txtFamilia.Text, lv_ValorAnterior) Then
                                MetroFramework.MetroMessageBox.Show(Me, "Familia actualizada correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MetroFramework.MetroMessageBox.Show(Me, "Familia actualizada, Productos NO pudieron ser actualizados.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        Else
                            MetroFramework.MetroMessageBox.Show(Me, "Familia actualizada correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, "Familia NO pudo ser actualizada.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Case False
                strFamilia.IdComp = CompanyCode
                strFamilia.descripcion = txtFamilia.Text
                If DBModelo.InsertFamilia(strFamilia) Then
                    MetroFramework.MetroMessageBox.Show(Me, "Familia creada correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "Familia NO pudo ser creada.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
        End Select
        Add_Update = False
        Material_Familia = txtFamilia.Text
        txtBusqueda.Text = txtFamilia.Text
        LimpiarObjetos()
        refresh_data_dgv()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtFamilia.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Favor de llenar el Campo Nombre de Familia", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim strFamilia As New tblFamilia
        Select Case Add_Update
            Case True
                strFamilia = DBModelo.GetFamilia(lv_idFamilia)
                If Not IsNothing(strFamilia) Then
                    strFamilia.descripcion = txtFamilia.Text
                    If DBModelo.UpdateFamilia(strFamilia) Then
                        If lv_ValorAnterior <> txtFamilia.Text Then
                            If DBModelo.UpdateFamiliaProd(txtFamilia.Text, lv_ValorAnterior) Then
                                MetroFramework.MetroMessageBox.Show(Me, "Familia actualizada correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MetroFramework.MetroMessageBox.Show(Me, "Familia actualizada, Productos NO pudieron ser actualizados.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        Else
                            MetroFramework.MetroMessageBox.Show(Me, "Familia actualizada correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, "Familia NO pudo ser actualizada.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Case False
                strFamilia.IdComp = CompanyCode
                strFamilia.descripcion = txtFamilia.Text
                If DBModelo.InsertFamilia(strFamilia) Then
                    MetroFramework.MetroMessageBox.Show(Me, "Familia creada correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "Familia NO pudo ser creada.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
        End Select
        Add_Update = False
        Material_Familia = txtFamilia.Text
        txtBusqueda.Text = txtFamilia.Text
        LimpiarObjetos()
        refresh_data_dgv()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LimpiarObjetos()
        Close()
    End Sub
End Class