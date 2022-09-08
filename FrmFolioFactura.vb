
Public Class FrmFolioFactura
    Dim Selection As Boolean = False

    Private Sub FrmFolioFactura_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                Close()
        End Select
    End Sub

    Private Sub FrmFolioFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Selection = False
        llena_grid()
    End Sub

    Private Sub llena_grid()
        DataGridView1.DataSource = DBModelo.GetFolios()

        load_layout_dgv_folios(DataGridView1)
    End Sub

    Private Sub DataGridView1_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim sTipoDoc As String = Trim(DataGridView1.Item(1, e.RowIndex).Value.ToString())
        Select Case sTipoDoc
            Case "FACTURAS"
                FrmFolioAME.CmbTipoDoc.SelectedIndex = 0
            Case "NOTAS DE CREDITO"
                FrmFolioAME.CmbTipoDoc.SelectedIndex = 1
            Case "PAGOS"
                FrmFolioAME.CmbTipoDoc.SelectedIndex = 2
        End Select
        FrmFolioAME.lblYear.Text = DataGridView1.Item(2, e.RowIndex).Value
        FrmFolioAME.TxtfolioIni.Text = DataGridView1.Item(3, e.RowIndex).Value
        FrmFolioAME.txtFilioFin.Text = DataGridView1.Item(4, e.RowIndex).Value
        FrmFolioAME.TxtFolioAct.Text = DataGridView1.Item(5, e.RowIndex).Value

        Selection = True
    End Sub

    Private Sub mBtnSearch_Click(sender As Object, e As EventArgs) Handles mBtnSearch.Click
        FrmFolioAME.TxtFolioAct.Visible = False
        FrmFolioAME.lblfolioactual.Visible = False


        FrmFolioAME.txtFilioFin.Text = ""
        FrmFolioAME.TxtFolioAct.Text = ""
        FrmFolioAME.TxtfolioIni.Text = ""
        FrmFolioAME.CmbTipoDoc.SelectedIndex = -1
        FrmFolioAME.lblYear.Text = CInt(Now.Date.Year)

        FrmFolioAME.ShowDialog()

        llena_grid()

        FrmFolioAME.TxtFolioAct.Visible = True
        FrmFolioAME.lblfolioactual.Visible = True
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Selection = False Then
            MsgBox("Favor de seleccionar una Factura", MsgBoxStyle.Information, "Folio Fiscales")
            Exit Sub
        End If

        FrmFolioAME.mBtnSave.Text = "Modificar"
        FrmFolioAME.ShowDialog()
        llena_grid()

        FrmFolioAME.TxtFolioAct.Visible = True
        FrmFolioAME.lblfolioactual.Visible = True
        FrmFolioAME.CmbTipoDoc.Enabled = True
        FrmFolioAME.txtFilioFin.Enabled = True
        FrmFolioAME.TxtfolioIni.Enabled = True
        Selection = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class