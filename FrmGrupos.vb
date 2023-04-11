Public Class FrmGrupos
    Public lv_idGrupo As Integer
    Public lv_ValorAnterior As String

    Private Sub FrmGrupos_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                Close()
        End Select
    End Sub

    Private Sub FrmGrupos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If Add_Update = False Then
            txtDescripcion.Clear()
            txtFactorCosto.Text = "0.00"
            txtFactorPublico.Text = "0.00"
            txtFactorP1.Text = "0.00"
            txtFactorP2.Text = "0.00"
            txtFactorP3.Text = "0.00"
            txtDescripcion.Select()
        End If
    End Sub

    Private Sub txtFactorCosto_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtFactorCosto.KeyPress
        Dim txt As MetroFramework.Controls.MetroTextBox = CType(sender, MetroFramework.Controls.MetroTextBox)
        If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
        If e.KeyChar = "." And txt.Text.IndexOf(".") = -1 Then e.Handled = False 'allow single decimal point
        If e.KeyChar = "-" And txt.SelectionStart = 0 Then e.Handled = False 'allow negative number
        'Enter key move to next control
        If e.KeyChar = Chr(13) Then
            GetNextControl(txt, True).Focus()
            'If only a decimal point is in the box clear TextBox
            If e.KeyChar = Chr(13) And txt.Text = "." Then txt.Clear()
            Exit Sub
        End If
        If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
    End Sub


    Private Sub txtFactorPublico_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtFactorPublico.KeyPress
        Dim txt As MetroFramework.Controls.MetroTextBox = CType(sender, MetroFramework.Controls.MetroTextBox)
        If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
        If e.KeyChar = "." And txt.Text.IndexOf(".") = -1 Then e.Handled = False 'allow single decimal point
        If e.KeyChar = "-" And txt.SelectionStart = 0 Then e.Handled = False 'allow negative number
        'Enter key move to next control
        If e.KeyChar = Chr(13) Then
            GetNextControl(txt, True).Focus()
            'If only a decimal point is in the box clear TextBox
            If e.KeyChar = Chr(13) And txt.Text = "." Then txt.Clear()
            Exit Sub
        End If
        If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
    End Sub

    Private Sub txtFactorP1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtFactorP1.KeyPress
        Dim txt As MetroFramework.Controls.MetroTextBox = CType(sender, MetroFramework.Controls.MetroTextBox)
        If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
        If e.KeyChar = "." And txt.Text.IndexOf(".") = -1 Then e.Handled = False 'allow single decimal point
        If e.KeyChar = "-" And txt.SelectionStart = 0 Then e.Handled = False 'allow negative number
        'Enter key move to next control
        If e.KeyChar = Chr(13) Then
            GetNextControl(txt, True).Focus()
            'If only a decimal point is in the box clear TextBox
            If e.KeyChar = Chr(13) And txt.Text = "." Then txt.Clear()
            Exit Sub
        End If
        If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
    End Sub

    Private Sub txtFactorP2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtFactorP2.KeyPress
        Dim txt As MetroFramework.Controls.MetroTextBox = CType(sender, MetroFramework.Controls.MetroTextBox)
        If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
        If e.KeyChar = "." And txt.Text.IndexOf(".") = -1 Then e.Handled = False 'allow single decimal point
        If e.KeyChar = "-" And txt.SelectionStart = 0 Then e.Handled = False 'allow negative number
        'Enter key move to next control
        If e.KeyChar = Chr(13) Then
            GetNextControl(txt, True).Focus()
            'If only a decimal point is in the box clear TextBox
            If e.KeyChar = Chr(13) And txt.Text = "." Then txt.Clear()
            Exit Sub
        End If
        If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
    End Sub

    Private Sub txtFactorP3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtFactorP3.KeyPress
        Dim txt As MetroFramework.Controls.MetroTextBox = CType(sender, MetroFramework.Controls.MetroTextBox)
        If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
        If e.KeyChar = "." And txt.Text.IndexOf(".") = -1 Then e.Handled = False 'allow single decimal point
        If e.KeyChar = "-" And txt.SelectionStart = 0 Then e.Handled = False 'allow negative number
        'Enter key move to next control
        If e.KeyChar = Chr(13) Then
            GetNextControl(txt, True).Focus()
            'If only a decimal point is in the box clear TextBox
            If e.KeyChar = Chr(13) And txt.Text = "." Then txt.Clear()
            Exit Sub
        End If
        If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
    End Sub

    Private Sub txtDescripcion_GotFocus(sender As Object, e As System.EventArgs) Handles txtDescripcion.GotFocus
        txtDescripcion.SelectAll()
    End Sub


    Private Sub txtFactorCosto_GotFocus(sender As Object, e As System.EventArgs) Handles txtFactorCosto.GotFocus
        txtFactorCosto.SelectAll()
    End Sub

    Private Sub txtFactorPublico_GotFocus(sender As Object, e As System.EventArgs) Handles txtFactorPublico.GotFocus
        txtFactorPublico.SelectAll()
    End Sub

    Private Sub txtFactorP3_GotFocus(sender As Object, e As System.EventArgs) Handles txtFactorP3.GotFocus
        txtFactorP3.SelectAll()
    End Sub

    Private Sub txtFactorP1_GotFocus(sender As Object, e As System.EventArgs) Handles txtFactorP1.GotFocus
        txtFactorP1.SelectAll()
    End Sub

    Private Sub txtFactorP2_GotFocus(sender As Object, e As System.EventArgs) Handles txtFactorP2.GotFocus
        txtFactorP2.SelectAll()
    End Sub

    Private Sub LimpiarObjetos()
        txtDescripcion.Clear()
        txtFactorCosto.Clear()
        txtFactorPublico.Clear()
        txtFactorP1.Clear()
        txtFactorP2.Clear()
        txtFactorP3.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtDescripcion.Text = "" Or txtFactorCosto.Text = "" Or txtFactorPublico.Text = "" Or txtFactorP1.Text = "" Or txtFactorP2.Text = "" Or txtFactorP3.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Campos Obligatorios para crear un Grupo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If CInt(txtFactorPublico.Text) < 1 Or CInt(txtFactorPublico.Text) > 100 Then
            MetroFramework.MetroMessageBox.Show(Me, "Porcentaje Invalido, favor de corregir el valor.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFactorPublico.SelectAll()
            Exit Sub
        End If

        If CInt(txtFactorP1.Text) < 1 Or CInt(txtFactorP1.Text) > 100 Then
            MetroFramework.MetroMessageBox.Show(Me, "Porcentaje Invalido, favor de corregir el valor.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFactorP1.SelectAll()
            Exit Sub
        End If

        If CInt(txtFactorP2.Text) < 1 Or CInt(txtFactorP2.Text) > 100 Then
            MetroFramework.MetroMessageBox.Show(Me, "Porcentaje Invalido, favor de corregir el valor.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFactorP2.SelectAll()
            Exit Sub
        End If

        If CInt(txtFactorP3.Text) < 1 Or CInt(txtFactorP3.Text) > 100 Then
            MetroFramework.MetroMessageBox.Show(Me, "Porcentaje Invalido, favor de corregir el valor.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFactorP3.SelectAll()
            Exit Sub
        End If

        Try
            Dim strGrupos As New tblGrupos
            If Add_Update = False Then
                strGrupos.IdComp = CompanyCode
                strGrupos.descripcion = txtDescripcion.Text
                strGrupos.factorCosto = CDec(txtFactorCosto.Text)
                strGrupos.factorPublico = CDec(txtFactorPublico.Text)
                strGrupos.factorP1 = CDec(txtFactorP1.Text)
                strGrupos.factorP2 = CDec(txtFactorP2.Text)
                strGrupos.factorP3 = CDec(txtFactorP3.Text)
                If DBModelo.InsertGrupos(strGrupos) Then
                    MetroFramework.MetroMessageBox.Show(Me, "Grupo creado correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "Grupo NO pudo ser creado.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                strGrupos = DBModelo.GetGroup(CInt(lv_idGrupo.ToString()))
                If Not IsNothing(strGrupos) Then
                    strGrupos.descripcion = txtDescripcion.Text
                    strGrupos.factorCosto = CDec(txtFactorCosto.Text)
                    strGrupos.factorPublico = CDec(txtFactorPublico.Text)
                    strGrupos.factorP1 = CDec(txtFactorP1.Text)
                    strGrupos.factorP2 = CDec(txtFactorP2.Text)
                    strGrupos.factorP3 = CDec(txtFactorP3.Text)
                    If DBModelo.UpdateGrupos(strGrupos) Then
                        If lv_ValorAnterior <> txtDescripcion.Text Then
                            DBModelo.UpdateGrupoProd(txtDescripcion.Text, lv_ValorAnterior)
                        End If

                        factorCosto = (CDbl(txtFactorCosto.Text) / 100)
                        factorPublico = CDbl(txtFactorPublico.Text) / 100
                        factorP1 = CDbl(txtFactorP1.Text) / 100
                        factorP2 = CDbl(txtFactorP2.Text) / 100
                        factorP3 = CDbl(txtFactorP3.Text) / 100

                        DBModelo.MassUpdateProductosPrecioCosto(factorCosto, txtDescripcion.Text)

                        DBModelo.MassUpdateProductosPrecioPublico(factorPublico, txtDescripcion.Text)

                        DBModelo.MassUpdateProductosPrecioP1(factorP1, txtDescripcion.Text)

                        DBModelo.MassUpdateProductosPrecioP2(factorP2, txtDescripcion.Text)

                        DBModelo.MassUpdateProductosPrecioP3(factorP3, txtDescripcion.Text)

                        MetroFramework.MetroMessageBox.Show(Me, "Grupo y Precios actualizados correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, "Grupo NO pudo ser actualizado.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    Console.WriteLine("No pasó nada")
                End If
            End If
            FrmBuscarGrupos.txtBusqueda.Text = txtDescripcion.Text
            Add_Update = False
            Material_Grupo = txtDescripcion.Text
            LimpiarObjetos()
            Close()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class