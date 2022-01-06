Imports MySql.Data.MySqlClient

Public Class FrmBuscarUOM
    Private lv_idUOM
    Public lv_ValorAnterior As String

    Private Sub LimpiarObjetos()
        MetroGrid1.Refresh()
        txtUOM.Clear()
    End Sub

    Private Sub FrmBuscarUOM_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                LimpiarObjetos()
                Close()
        End Select
    End Sub

    Private Sub FrmBuscarUOM_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LimpiarObjetos()
        txtBusqueda.Select()
        Add_Update = False
    End Sub

    Private Sub txtBusqueda_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtBusqueda.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            LimpiarObjetos()
            refresh_data_dgv()
        End If
    End Sub

    Private Sub refresh_data_dgv()
        MetroGrid1.Refresh()
        Dim UoM As List(Of tblUnidades) = DBModelo.GetUoMByDesc(txtBusqueda.Text)

        MetroGrid1.DataSource = UoM.ToList

        MetroGrid1.Columns(0).HeaderText = "Id UoM"
        MetroGrid1.Columns(0).ReadOnly = True

        MetroGrid1.Columns(1).HeaderText = "Descripción"
        MetroGrid1.Columns(1).ReadOnly = True
        MetroGrid1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub MetroGrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellDoubleClick
        Add_Update = True
        lv_idUOM = MetroGrid1.Item(0, MetroGrid1.CurrentRow.Index).Value
        txtUOM.Text = MetroGrid1.Item(1, MetroGrid1.CurrentRow.Index).Value
        lv_ValorAnterior = MetroGrid1.Item(1, MetroGrid1.CurrentRow.Index).Value
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        LimpiarObjetos()
        Close()
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        If txtUOM.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Favor de llenar el Campo Nombre de la Unidad de Medida", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim strUoM As New tblUnidades
        Select Case Add_Update
            Case True
                strUoM = DBModelo.GetUoM(lv_idUOM)
                If Not IsNothing(strUoM) Then
                    strUoM.descripcion = txtUOM.Text
                    If DBModelo.UpdateUoM(strUoM) Then
                        If lv_ValorAnterior <> txtUOM.Text Then
                            If DBModelo.UpdateUoM_Productos(txtUOM.Text, lv_ValorAnterior) Then
                                MetroFramework.MetroMessageBox.Show(Me, "Unidad de Medida actualizada correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MetroFramework.MetroMessageBox.Show(Me, "Unidad de Medida actualizada, Productos NO pudieron ser actualizados.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        Else
                            MetroFramework.MetroMessageBox.Show(Me, "Unidad de Medida actualizada correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, "Unidad de Medida NO pudo ser actualizada.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Case False
                strUoM.descripcion = txtUOM.Text
                If DBModelo.InsertUoM(strUoM) Then
                    MetroFramework.MetroMessageBox.Show(Me, "Unidad de Medida creada correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "Unidad de Medida NO pudo ser creada.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
        End Select
        Add_Update = False
        LimpiarObjetos()
        refresh_data_dgv()
    End Sub
End Class