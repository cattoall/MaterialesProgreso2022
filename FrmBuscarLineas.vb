Public Class FrmBuscarLineas
    Private lv_idLinea As Integer
    Public lv_ValorAnterior As String

    Private Sub LimpiarObjetos()
        MetroGrid1.Refresh()
        txtLinea.Clear()
    End Sub

    Private Sub FrmBuscarLineas_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                LimpiarObjetos()
                Close()
        End Select
    End Sub

    Private Sub FrmBuscarLineas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
        Dim linea As List(Of tblLinea) = DBModelo.GetLineaByDesc(txtBusqueda.Text)

        MetroGrid1.DataSource = linea.ToList

        MetroGrid1.Columns(0).Visible = False

        MetroGrid1.Columns(1).HeaderText = "Id Linea"
        MetroGrid1.Columns(1).ReadOnly = True

        MetroGrid1.Columns(2).HeaderText = "Descripción"
        MetroGrid1.Columns(2).ReadOnly = True
        MetroGrid1.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub MetroGrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellDoubleClick
        Add_Update = True
        lv_idLinea = CInt(MetroGrid1.Item(1, MetroGrid1.CurrentRow.Index).Value)
        txtLinea.Text = CStr(MetroGrid1.Item(2, MetroGrid1.CurrentRow.Index).Value)
        lv_ValorAnterior = CStr(MetroGrid1.Item(2, MetroGrid1.CurrentRow.Index).Value)
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs)
        Dim strLinea As New tblLinea

        If txtLinea.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Favor de llenar el Campo Nombre de Linea", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Select Case Add_Update
            Case True
                strLinea = DBModelo.GetLinea(lv_idLinea)
                If Not IsNothing(strLinea) Then
                    strLinea.descripcion = txtLinea.Text
                    If DBModelo.UpdateLinea(strLinea) Then
                        If lv_ValorAnterior <> txtLinea.Text Then
                            If DBModelo.UpdateLinea_Productos(txtLinea.Text, lv_ValorAnterior) Then
                                MetroFramework.MetroMessageBox.Show(Me, "Linea actualizada correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MetroFramework.MetroMessageBox.Show(Me, "Linea NO pudo ser actualizada.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            MetroFramework.MetroMessageBox.Show(Me, "Linea actualizada correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, "Linea NO pudo ser actualizada.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Case False
                strLinea.IdComp = CompanyCode
                strLinea.descripcion = txtLinea.Text
                If DBModelo.InsertLinea(strLinea) Then
                    MetroFramework.MetroMessageBox.Show(Me, "Linea creada correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "Linea NO pudo ser creada.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
        End Select
        Add_Update = False
        Material_Linea = txtLinea.Text
        txtBusqueda.Text = txtLinea.Text
        LimpiarObjetos()
        refresh_data_dgv()
        txtBusqueda.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim strLinea As New tblLinea

        If txtLinea.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Favor de llenar el Campo Nombre de Linea", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Select Case Add_Update
            Case True
                strLinea = DBModelo.GetLinea(lv_idLinea)
                If Not IsNothing(strLinea) Then
                    strLinea.descripcion = txtLinea.Text
                    If DBModelo.UpdateLinea(strLinea) Then
                        If lv_ValorAnterior <> txtLinea.Text Then
                            If DBModelo.UpdateLinea_Productos(txtLinea.Text, lv_ValorAnterior) Then
                                MetroFramework.MetroMessageBox.Show(Me, "Linea actualizada correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MetroFramework.MetroMessageBox.Show(Me, "Linea NO pudo ser actualizada.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            MetroFramework.MetroMessageBox.Show(Me, "Linea actualizada correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, "Linea NO pudo ser actualizada.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Case False
                strLinea.IdComp = CompanyCode
                strLinea.descripcion = txtLinea.Text
                If DBModelo.InsertLinea(strLinea) Then
                    MetroFramework.MetroMessageBox.Show(Me, "Linea creada correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "Linea NO pudo ser creada.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
        End Select
        Add_Update = False
        Material_Linea = txtLinea.Text
        txtBusqueda.Text = txtLinea.Text
        LimpiarObjetos()
        refresh_data_dgv()
        txtBusqueda.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LimpiarObjetos()
        Close()
    End Sub
End Class