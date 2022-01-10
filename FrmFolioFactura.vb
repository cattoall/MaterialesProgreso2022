Imports MySql.Data.MySqlClient
Imports System.Text

Public Class FrmFolioFactura
    Dim folio As String
    Dim Selection As Boolean = False

    Private Sub FrmFolioFactura_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub FrmFolioFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Selection = False
        bs.DataSource = Nothing
        dt.Clear()

        With Me.DataGridView1
            ' alternar color de filas
            '.AlternatingRowsDefaultCellStyle.BackColor = My.Settings.BackColorAlt
            '.DefaultCellStyle.BackColor = My.Settings.BackColor
            '.DefaultCellStyle.Font = My.Settings.RowFont
            '.ColumnHeadersDefaultCellStyle.Font = My.Settings.HeaderFont
            ' Establecer el origen de datos para el DataGridview   
            .DataSource = bs
        End With

        llena_grid()

        'Me.BackColor = My.Settings.FormsBackColor
        'Me.GroupBox1.ForeColor = My.Settings.FontForeColor
        'Me.GroupBox1.Font = My.Settings.FontStyle
        'Me.CmdSalir.BackColor = My.Settings.FormsBackColor
        'Me.CmdModificar.BackColor = My.Settings.FormsBackColor
        'Me.CmdNuevo.BackColor = My.Settings.FormsBackColor

    End Sub

    Private Sub llena_grid()
        DataGridView1.DataSource = DBModelo.GetFolios()
        'SQL = "SELECT * FROM foliosfacturas"
        '
        ''Carga Lista de Clasificaciones
        'load_record_dgv(SQL, Me.DataGridView1, DBConnected)
        '
        ''Aplica formato al DataGridView
        load_layout_dgv_folios(Me.DataGridView1)
        '
        ' folio = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) 
        foliotipodoc = DataGridView1.Item(0, e.RowIndex).Value
        folioyear = DataGridView1.Item(1, e.RowIndex).Value
        folioini = DataGridView1.Item(2, e.RowIndex).Value
        foliofin = DataGridView1.Item(3, e.RowIndex).Value
        folioactual = DataGridView1.Item(4, e.RowIndex).Value
        Llena_Variables(foliotipodoc, folioini, foliofin, folioactual, folioyear)
        Selection = True
        Call btnEdit_Click(sender, e)
    End Sub

    Private Sub ImgSalirB_Click(sender As System.Object, e As System.EventArgs) Handles ImgSalirB.Click
        Me.Close()
    End Sub

    Private Sub ImgNewB_Click(sender As System.Object, e As System.EventArgs) 
        FrmFolioAME.ImgGuardarA.Visible = True
        FrmFolioAME.ImgModificarA.Visible = False
        FrmFolioAME.TxtFolioAct.Visible = False
        FrmFolioAME.lblfolioactual.Visible = False


        FrmFolioAME.txtFilioFin.Text = ""
        FrmFolioAME.TxtFolioAct.Text = ""
        FrmFolioAME.TxtfolioIni.Text = ""
        FrmFolioAME.CmbTipoDoc.Text = ""
        FrmFolioAME.Label1.Text = CInt(Now.Date.Year)

        Llena_Variables("", "", "", "", CInt(Now.Date.Year))
        SetFormName(FrmFolioAME, DBConnected)
        FrmFolioAME.ShowDialog()

        llena_grid()

        FrmFolioAME.ImgGuardarA.Visible = False
        FrmFolioAME.ImgModificarA.Visible = True
        FrmFolioAME.TxtFolioAct.Visible = True
        FrmFolioAME.lblfolioactual.Visible = True

    End Sub

    

    Private Sub DataGridView1_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        foliotipodoc = DataGridView1.Item(0, e.RowIndex).Value
        folioyear = DataGridView1.Item(1, e.RowIndex).Value
        folioini = DataGridView1.Item(2, e.RowIndex).Value
        foliofin = DataGridView1.Item(3, e.RowIndex).Value
        folioactual = DataGridView1.Item(4, e.RowIndex).Value
        Llena_Variables(foliotipodoc, folioini, foliofin, folioactual, folioyear)
        Selection = True
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        FrmFolioAME.ImgGuardarA.Visible = True
        FrmFolioAME.ImgModificarA.Visible = False
        FrmFolioAME.TxtFolioAct.Visible = False
        FrmFolioAME.lblfolioactual.Visible = False


        FrmFolioAME.txtFilioFin.Text = ""
        FrmFolioAME.TxtFolioAct.Text = ""
        FrmFolioAME.TxtfolioIni.Text = ""
        FrmFolioAME.CmbTipoDoc.Text = ""
        FrmFolioAME.Label1.Text = CInt(Now.Date.Year)

        Llena_Variables("", "", "", "", CInt(Now.Date.Year))
        SetFormName(FrmFolioAME, DBConnected)
        FrmFolioAME.ShowDialog()

        llena_grid()

        FrmFolioAME.ImgGuardarA.Visible = False
        FrmFolioAME.ImgModificarA.Visible = True
        FrmFolioAME.TxtFolioAct.Visible = True
        FrmFolioAME.lblfolioactual.Visible = True
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Selection = False Then
            MsgBox("Favor de seleccionar una Factura", MsgBoxStyle.Information, "Folio Fiscales")
            Exit Sub
        End If

        FrmFolioAME.ImgGuardarA.Visible = False
        FrmFolioAME.ImgModificarA.Visible = True
        FrmFolioAME.TxtFolioAct.Visible = True
        FrmFolioAME.lblfolioactual.Visible = True

        FrmFolioAME.CmbTipoDoc.Enabled = False
        FrmFolioAME.txtFilioFin.Enabled = False
        FrmFolioAME.TxtfolioIni.Enabled = False

        Select Case foliotipodoc
            Case "FACTURAS"
                FrmFolioAME.CmbTipoDoc.SelectedIndex = 0
            Case Else
                FrmFolioAME.CmbTipoDoc.SelectedIndex = 1
        End Select
        FrmFolioAME.TxtfolioIni.Text = folioini
        FrmFolioAME.txtFilioFin.Text = foliofin
        FrmFolioAME.TxtFolioAct.Text = folioactual
        FrmFolioAME.Label1.Text = folioyear
        SetFormName(FrmFolioAME, DBConnected)
        FrmFolioAME.ShowDialog()
        llena_grid()

        FrmFolioAME.ImgGuardarA.Visible = True
        FrmFolioAME.ImgModificarA.Visible = False
        FrmFolioAME.TxtFolioAct.Visible = False
        FrmFolioAME.lblfolioactual.Visible = False
        FrmFolioAME.CmbTipoDoc.Enabled = True
        FrmFolioAME.txtFilioFin.Enabled = True
        FrmFolioAME.TxtfolioIni.Enabled = True
        Selection = False
    End Sub
End Class