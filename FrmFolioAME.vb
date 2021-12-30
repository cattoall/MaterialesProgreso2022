Imports MySql.Data.MySqlClient
Imports System.Text

Public Class FrmFolioAME
    Dim lv_tipo As String

    Private Sub FrmFolioAME_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                TxtFolioAct.Enabled = True
                txtFilioFin.Enabled = True
                TxtfolioIni.Enabled = True
                TxtFolioAct.Enabled = True
                CmbTipoDoc.Enabled = True

                Limpiar_campos()

                Me.Close()
        End Select
    End Sub

    Private Sub FrmFolioAME_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.BackColor = My.Settings.FormsBackColor
        'Me.lbldocumento.BackColor = My.Settings.FormsBackColor
        'Me.lblfinal.BackColor = My.Settings.FormsBackColor
        'Me.lblfolioactual.BackColor = My.Settings.FormsBackColor
        'Me.lblinicial.BackColor = My.Settings.FormsBackColor
        'Me.GroupBox1.ForeColor = My.Settings.FontForeColor
        'Me.GroupBox1.Font = My.Settings.FontStyle
        'Me.CmdSalir.BackColor = My.Settings.FormsBackColor
        'Me.CmdGuardar.BackColor = My.Settings.FormsBackColor
        'Me.CmdModificar.BackColor = My.Settings.FormsBackColor
    End Sub

    Private Sub Limpiar_campos()
        txtFilioFin.Clear()
        TxtfolioIni.Clear()
        TxtFolioAct.Clear()
        CmbTipoDoc.SelectedIndex = -1
    End Sub

    Private Sub ImgGuardarB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgGuardarB.MouseLeave
        Me.ImgGuardarA.Visible = True
        Me.ImgGuardarB.Visible = False
    End Sub

    Private Sub ImgGuardarA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgGuardarA.MouseHover
        Me.ImgGuardarB.Visible = True
        Me.ImgGuardarA.Visible = False
    End Sub

    Private Sub ImgModificarB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgModificarB.MouseLeave
        Me.ImgModificarA.Visible = True
        Me.ImgModificarB.Visible = False
    End Sub

    Private Sub ImgModificarA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgModificarA.MouseHover
        Me.ImgModificarB.Visible = True
        Me.ImgModificarA.Visible = False
    End Sub

    Private Sub ImgSalirB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgSalirB.MouseLeave
        Me.ImgSalirA.Visible = True
        Me.ImgSalirB.Visible = False
    End Sub

    Private Sub ImgSalirA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgSalirA.MouseHover
        Me.ImgSalirB.Visible = True
        Me.ImgSalirA.Visible = False
    End Sub

    Private Sub ImgSalirB_Click(sender As System.Object, e As System.EventArgs) Handles ImgSalirB.Click
        TxtFolioAct.Enabled = True
        txtFilioFin.Enabled = True
        TxtfolioIni.Enabled = True
        TxtFolioAct.Enabled = True
        CmbTipoDoc.Enabled = True

        Limpiar_campos()

        Me.Close()
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

    Private Sub ImgGuardarB_Click(sender As System.Object, e As System.EventArgs) Handles ImgGuardarB.Click
        lv_tipo = CmbTipoDoc.Text
        TxtFolioAct.Text = TxtfolioIni.Text
        Dim SQL As String

        If CmbTipoDoc.SelectedIndex < 0 Or TxtfolioIni.Text = "" Or txtFilioFin.Text = "" Then
            MsgBox("Necesitas llenar todos los campos para poder guardar", MsgBoxStyle.Critical, "Folios Fiscales")
            Exit Sub
        End If

        Try
        SQL = "INSERT INTO foliosfacturas (TipoComprobante,Year,FolioInicial,FolioFinal,FolioActual) values (@TipoComprobante,@year,@FolioInicial,@FolioFinal,@FolioActual)"
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        myCommand.Parameters.Clear()
        myCommand.Connection = conn
        myCommand.CommandText = SQL
        myCommand.Parameters.AddWithValue("@TipoComprobante", CmbTipoDoc.Text)
        myCommand.Parameters.AddWithValue("@year", CInt(Label1.Text))
        myCommand.Parameters.AddWithValue("@FolioInicial", CInt(TxtfolioIni.Text))
        myCommand.Parameters.AddWithValue("@FolioFinal", CInt(txtFilioFin.Text))
        myCommand.Parameters.AddWithValue("@FolioActual", CInt(TxtFolioAct.Text))
        myCommand.ExecuteNonQuery()
        conn.Close()

        Llena_Variables(CmbTipoDoc.Text, TxtfolioIni.Text, txtFilioFin.Text, TxtFolioAct.Text, CInt(Label1.Text))
        Limpiar_campos()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Folios Fiscales")
        End Try
    End Sub

    Private Sub ImgModificarB_Click(sender As System.Object, e As System.EventArgs) Handles ImgModificarB.Click
        Dim SQL As String

        If TxtFolioAct.Text = "" Then
            MsgBox("Necesitas llenar Folio Actual para Modificarlo", MsgBoxStyle.Critical, "Folios Fiscales")
            Exit Sub
        End If

        SQL = "UPDATE foliosfacturas SET FolioInicial = @FolioInicial, FolioFinal = @FolioFinal, FolioActual = @FolioActual where TipoComprobante = @TipoComprobante and Year = @year"
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        myCommand.Parameters.Clear()
        myCommand.Connection = conn
        myCommand.CommandText = SQL
        myCommand.Parameters.AddWithValue("@TipoComprobante", foliotipodoc)
        myCommand.Parameters.AddWithValue("@year", CInt(folioyear))
        myCommand.Parameters.AddWithValue("@FolioInicial", CInt(folioini))
        myCommand.Parameters.AddWithValue("@FolioFinal", CInt(foliofin))
        myCommand.Parameters.AddWithValue("@FolioActual", CInt(TxtFolioAct.Text))
        myCommand.ExecuteNonQuery()
        conn.Close()

        Llena_Variables(CmbTipoDoc.Text, TxtfolioIni.Text, txtFilioFin.Text, TxtFolioAct.Text, CInt(Label1.Text))
        Limpiar_campos()
        Me.Close()
    End Sub
End Class