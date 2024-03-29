﻿
Public Class FrmBuscarSubFamilias
    Private lv_idSubFamilia As Integer
    Public lv_ValorAnterior As String

    Private Sub LimpiarObjetos()
        txtBusqueda.Clear()
        txtSubFamilia.Clear()
        Add_Update = False
    End Sub

    Private Sub FrmBuscarSubFamilias_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                MetroGrid1.Refresh()
                LimpiarObjetos()
                Close()
        End Select
    End Sub

    Private Sub FrmBuscarSubFamilias_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LimpiarObjetos()
        txtBusqueda.Select()
        Add_Update = False
    End Sub

    Private Sub txtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusqueda.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            refresh_data_dgv()
            LimpiarObjetos()
        End If
    End Sub

    Private Sub refresh_data_dgv()
        MetroGrid1.Refresh()
        Dim subfamilia As List(Of tblSubFamilia) = DBModelo.GetSubFamiliaByDesc(txtBusqueda.Text)

        MetroGrid1.DataSource = subfamilia.ToList

        MetroGrid1.Columns(0).Visible = False

        MetroGrid1.Columns(1).HeaderText = "Id SubFamilia"
        MetroGrid1.Columns(1).ReadOnly = True

        MetroGrid1.Columns(2).HeaderText = "Descripción"
        MetroGrid1.Columns(2).ReadOnly = True
        MetroGrid1.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub MetroGrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellDoubleClick
        Add_Update = True
        lv_idSubFamilia = CInt(MetroGrid1.Item(1, MetroGrid1.CurrentRow.Index).Value)
        txtSubFamilia.Text = CStr(MetroGrid1.Item(2, MetroGrid1.CurrentRow.Index).Value)
        lv_ValorAnterior = CStr(MetroGrid1.Item(2, MetroGrid1.CurrentRow.Index).Value)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtSubFamilia.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Favor de llenar el Campo Nombre de SubFamilia", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim strSubFamilia As New tblSubFamilia
        Select Case Add_Update
            Case True
                strSubFamilia = DBModelo.GetSubFamilia(lv_idSubFamilia)
                If Not IsNothing(strSubFamilia) Then
                    strSubFamilia.descripcion = txtSubFamilia.Text
                    If DBModelo.UpdateSubfamilia(strSubFamilia) Then
                        If lv_ValorAnterior <> txtSubFamilia.Text Then
                            If DBModelo.UpdateSubfamiliaProd(txtSubFamilia.Text, lv_ValorAnterior) Then
                                MetroFramework.MetroMessageBox.Show(Me, "SubFamilia actualizada correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MetroFramework.MetroMessageBox.Show(Me, "SubFamilia actualizada, Productos NO pudieron ser actualizados.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        Else
                            MetroFramework.MetroMessageBox.Show(Me, "SubFamilia actualizada correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, "SubFamilia NO pudo ser actualizada.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Case False
                strSubFamilia.IdComp = CompanyCode
                strSubFamilia.descripcion = txtSubFamilia.Text
                If DBModelo.InsertSubfamilia(strSubFamilia) Then
                    MetroFramework.MetroMessageBox.Show(Me, "SubFamilia creada correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "SubFamilia NO pudo ser creada.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
        End Select
        Add_Update = False
        Material_SubFam = txtSubFamilia.Text
        txtBusqueda.Text = txtSubFamilia.Text
        MetroGrid1.Refresh()
        refresh_data_dgv()
        txtBusqueda.Focus()
        LimpiarObjetos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MetroGrid1.Refresh()
        LimpiarObjetos()
        Close()
    End Sub
End Class