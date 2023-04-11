
Public Class FrmFolioAME
    Private Sub FrmFolioAME_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                TxtFolioAct.Enabled = True
                txtFilioFin.Enabled = True
                TxtfolioIni.Enabled = True
                TxtFolioAct.Enabled = True
                CmbTipoDoc.Enabled = True

                Limpiar_campos()
                Dispose()
                Close()
        End Select
    End Sub

    Private Sub Limpiar_campos()
        txtFilioFin.Clear()
        TxtfolioIni.Clear()
        TxtFolioAct.Clear()
        CmbTipoDoc.SelectedIndex = -1
    End Sub

    Private Sub TxtfolioIni_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtfolioIni.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txtFilioFin_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtFilioFin.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub TxtFolioAct_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFolioAct.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles mBtnSave.Click
        Dim newFolio As tblFolioFacturas = New tblFolioFacturas

        newFolio.IdComp = CompanyCode
        newFolio.TipoComprobante = CmbTipoDoc.Text
        newFolio.Year = CInt(lblYear.Text)
        newFolio.FolioInicial = CInt(TxtfolioIni.Text)
        newFolio.FolioFinal = CInt(txtFilioFin.Text)
        newFolio.FolioActual = CInt(TxtfolioIni.Text)

        If mBtnSave.Text = "Modificar" Then
            If DBModelo.UpdateFolioFacturas(newFolio) Then
                MsgBox("Folio actualizado correctamente.", MsgBoxStyle.Information, "Folios Facturas")
            Else
                MsgBox("Hubo error al actualizar el Folio.", MsgBoxStyle.Critical, "Folios Facturas")
            End If
        Else
            TxtFolioAct.Text = TxtfolioIni.Text
            newFolio.FolioActual = CInt(TxtFolioAct.Text)

            If CmbTipoDoc.SelectedIndex < 0 Or TxtfolioIni.Text = "" Or txtFilioFin.Text = "" Then
                MsgBox("Necesitas llenar todos los campos para poder guardar", MsgBoxStyle.Critical, "Folios Facturas")
                Exit Sub
            End If

            If DBModelo.InsertFolio(newFolio) Then
                Console.WriteLine("Se pudo")
            Else
                Console.WriteLine("No se pudo")
            End If
        End If
        Limpiar_campos()
        Dispose()
        Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
        Close()
    End Sub
End Class