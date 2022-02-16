Public Class FrmBuscarGrupos
    Private Sub LimpiarObjetos()

    End Sub

    Private Sub FrmBuscarGrupos_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                MetroGrid1.Refresh()
                Close()
        End Select
    End Sub

    Private Sub FrmBuscarGrupos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtBusqueda.Select()
    End Sub

    Private Sub txtBusqueda_GotFocus(sender As Object, e As System.EventArgs) Handles txtBusqueda.GotFocus
        txtBusqueda.SelectAll()
    End Sub

    Private Sub txtBusqueda_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtBusqueda.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            refresh_data_dgv()
        End If
    End Sub

    Private Sub MetroGrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellDoubleClick
        Add_Update = True
        FrmGrupos.Text = "Modificar Grupo"

        FrmGrupos.lv_idGrupo            = MetroGrid1.Item(1, MetroGrid1.CurrentRow.Index).Value
        FrmGrupos.lv_ValorAnterior      = MetroGrid1.Item(2, MetroGrid1.CurrentRow.Index).Value
        FrmGrupos.txtDescripcion.Text   = MetroGrid1.Item(2, MetroGrid1.CurrentRow.Index).Value
        FrmGrupos.txtFactorCosto.Text   = MetroGrid1.Item(3, MetroGrid1.CurrentRow.Index).Value
        FrmGrupos.txtFactorPublico.Text = MetroGrid1.Item(4, MetroGrid1.CurrentRow.Index).Value
        FrmGrupos.txtFactorP1.Text      = MetroGrid1.Item(5, MetroGrid1.CurrentRow.Index).Value
        FrmGrupos.txtFactorP2.Text      = MetroGrid1.Item(6, MetroGrid1.CurrentRow.Index).Value
        FrmGrupos.txtFactorP3.Text      = MetroGrid1.Item(7, MetroGrid1.CurrentRow.Index).Value
        FrmGrupos.ShowDialog()
        FrmGrupos.Close()
        FrmGrupos.Dispose()
        MetroGrid1.Refresh()
        refresh_data_dgv()
    End Sub

    Private Sub refresh_data_dgv()
        Dim grps As List(Of tblGrupos) = DBModelo.GetGroupByDesc(txtBusqueda.Text)

        If IsNothing(grps) Then
            MetroFramework.MetroMessageBox.Show(Me, "No hay resultados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        MetroGrid1.Refresh()
        MetroGrid1.DataSource = grps.ToList

        MetroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        MetroGrid1.Columns(0).Visible = False

        Dim i As Int16 = 0

        For i = 0 To MetroGrid1.Columns.Count - 1 
            MetroGrid1.Columns(i).ReadOnly = True
            MetroGrid1.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next

        MetroGrid1.Columns(1).HeaderText = "Id"
        MetroGrid1.Columns(2).HeaderText = "Descripción"
        MetroGrid1.Columns(3).HeaderText = "Factor Costo"
        MetroGrid1.Columns(4).HeaderText = "Factor Público"
        MetroGrid1.Columns(5).HeaderText = "Factor P1"
        MetroGrid1.Columns(6).HeaderText = "Factor P2"
        MetroGrid1.Columns(7).HeaderText = "Factor P3"
    End Sub

    Private Sub ImgSalirB_Click(sender As System.Object, e As System.EventArgs)
        MetroGrid1.Refresh()
        Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        refresh_data_dgv()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Add_Update = False
        FrmGrupos.Text = "Crear Grupo"
        FrmGrupos.ShowDialog()
        FrmGrupos.Close()
        FrmGrupos.Dispose()
        MetroGrid1.Refresh()
        refresh_data_dgv()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class