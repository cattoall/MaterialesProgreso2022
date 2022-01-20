Public Class FrmAjusteDeInventario
    Dim strProducto As New tblProductos

    Private Sub LimpiarObjetos()
        RbtnActual.Checked = True
        RbtnActual.Enabled = False
        RbtnAcumulativo.Enabled = False
        TxtStockActual.Clear()
        txtDescripcion.Clear()
        LblStock.Text = ""
    End Sub

    Private Sub FrmAjusteDeInventario_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyValue
            Case Keys.F2
                Call btnBuscar_Click(sender, e)
            Case Keys.Escape
                AccionSalir = True
                Close()
        End Select
    End Sub

    Private Sub FrmBuscarProductos_Leave(sender As Object, e As System.EventArgs) Handles MyBase.Leave
        LimpiarObjetos()
    End Sub

    Private Sub FrmAjusteDeInventario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LimpiarObjetos()
    End Sub

    Private Sub TxtStockActual_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtStockActual.KeyPress
        e.Handled = True
        If e.KeyChar <> "." Then 'Allow "."'s before checking for Numerics   
            If IsNumeric(e.KeyChar) Then
                e.Handled = False 'Check for Numerics   
            End If
            If Asc(e.KeyChar) = 8 Then
                e.Handled = False
            End If
        Else
            If e.KeyChar = "." And TxtStockActual.Text.Contains(".") Then e.KeyChar = "" 'Check for Duplicate and Create Null if Yes   
            e.Handled = False
        End If
    End Sub

    Private Sub RbtnActual_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbtnActual.CheckedChanged
        If RbtnActual.Checked = True Then
            LblStock.Text = "0.00 +"
            TxtStockActual.Text = "0.00"
            TxtStockActual.Focus()
            TxtStockActual.SelectAll()
        End If

        If RbtnAcumulativo.Checked = True Then
            strProducto = DBModelo.GetProducts(ProductoID)
            If Not IsNothing(strProducto) Then
                TxtStockActual.Text = strProducto.stock
            End If
            LblStock.Text = Format(CDbl(TxtStockActual.Text), "###,###,##0.00") & " +"
            TxtStockActual.Text = "0.00"
            TxtStockActual.Focus()
            TxtStockActual.SelectAll()
        End If
    End Sub

    Private Sub RbtnAcumulativo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RbtnAcumulativo.CheckedChanged
        If RbtnActual.Checked = True Then
            LblStock.Text = "0.00 +"
            TxtStockActual.Text = "0.00"
            TxtStockActual.Focus()
            TxtStockActual.SelectAll()
        End If

        If RbtnAcumulativo.Checked = True Then
            strProducto = DBModelo.GetProducts(ProductoID)
            If Not IsNothing(strProducto) Then
                TxtStockActual.Text = strProducto.stock
            End If
            LblStock.Text = Format(CDbl(TxtStockActual.Text), "###,###,##0.00") & " +"
            TxtStockActual.Text = "0.00"
            TxtStockActual.Focus()
            TxtStockActual.SelectAll()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        AccionSalir = False
        Inventariado = False
        FrmBuscarProductosINV.ShowDialog()
        FrmBuscarProductosINV.Close()
        FrmBuscarProductosINV.Dispose()

        If AccionSalir = False Then
            RbtnActual.Enabled = True
            RbtnAcumulativo.Enabled = True
            If Inventariado = False Then
                RbtnActual.Checked = True
            Else
                RbtnAcumulativo.Checked = True
            End If
            If RbtnActual.Checked = True Then
                LblStock.Text = "0.00 +"
                TxtStockActual.Text = "0.00"
            End If

            If RbtnAcumulativo.Checked = True Then
                strProducto = DBModelo.GetProducts(ProductoID)
                If Not IsNothing(strProducto) Then
                    TxtStockActual.Text = strProducto.stock
                End If

                LblStock.Text = Format(CDbl(TxtStockActual.Text), "###,###,##0.00") & " +"
                TxtStockActual.Text = "0.00"
            End If
            TxtStockActual.Focus()
            TxtStockActual.SelectAll()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LimpiarObjetos()
        AccionSalir = True
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If RbtnActual.Checked = True Then
            strProducto.stock = CDbl(TxtStockActual.Text)
        End If

        If RbtnAcumulativo.Checked = True Then
            strProducto.stock = strProducto.stock + CDbl(TxtStockActual.Text)
        End If

        If DBModelo.UpdateProductos(strProducto) = False Then
            MetroFramework.MetroMessageBox.Show(Me, "Inventario NO pudo ser Actualizado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Inventario Actualizado Correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        LimpiarObjetos()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        LimpiarObjetos()
    End Sub
End Class