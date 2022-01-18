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

    Private Sub ImgSalirB_Click(sender As System.Object, e As System.EventArgs) 
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

    Private Sub ImgGuardarB_Click(sender As System.Object, e As System.EventArgs) 
        
    End Sub

    Private Sub ImgModificarB_Click(sender As System.Object, e As System.EventArgs) 
        
    End Sub

    Private Sub mBtnSave_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Function Update() 
        Dim SQL As String

        If TxtFolioAct.Text = "" Then
            Console.WriteLine(TxtFolioAct.Text)
            MsgBox("Necesitas llenar Folio Actual para Modificarlo", MsgBoxStyle.Critical, "Folios Fiscales")
            Return 0
        End If

        'SQL = "UPDATE foliosfacturas SET FolioInicial = @FolioInicial, FolioFinal = @FolioFinal, FolioActual = @FolioActual where TipoComprobante = @TipoComprobante and Year = @year"
        
        Dim newFolio As tblFoliofacturas = New tblFoliofacturas

        newFolio.TipoComprobante    = foliotipodoc
        newFolio.Year               = CInt(folioyear)
        newFolio.FolioInicial       = CInt(folioini)
        newFolio.FolioFinal         = CInt(foliofin)
        newFolio.FolioActual        = CInt(TxtFolioAct.Text)

        if DBModelo.UpdateFolioFacturas(newFolio) Then
            
        End If
        
        'If conn.State = ConnectionState.Open Then
        '    conn.Close()
        'End If
        'conn.Open()
        'myCommand.Parameters.Clear()
        'myCommand.Connection = conn
        'myCommand.CommandText = SQL
        'myCommand.Parameters.AddWithValue("@TipoComprobante", foliotipodoc)
        'myCommand.Parameters.AddWithValue("@year", CInt(folioyear))
        'myCommand.Parameters.AddWithValue("@FolioInicial", CInt(folioini))
        'myCommand.Parameters.AddWithValue("@FolioFinal", CInt(foliofin))
        'myCommand.Parameters.AddWithValue("@FolioActual", CInt(TxtFolioAct.Text))
        'myCommand.ExecuteNonQuery()
        'conn.Close()

        Llena_Variables(CmbTipoDoc.Text, TxtfolioIni.Text, txtFilioFin.Text, TxtFolioAct.Text, CInt(Label1.Text))
        Limpiar_campos()
        Me.Close()
    End Function

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles mBtnSave.Click
        If mBtnSave.Text = "Modificar"
            Update()

        Else
            lv_tipo = CmbTipoDoc.Text
            TxtFolioAct.Text = TxtfolioIni.Text
            Dim SQL As String

            If CmbTipoDoc.SelectedIndex < 0 Or TxtfolioIni.Text = "" Or txtFilioFin.Text = "" Then
                MsgBox("Necesitas llenar todos los campos para poder guardar", MsgBoxStyle.Critical, "Folios Fiscales")
                Exit Sub
            End If

            Try
            'SQL = "INSERT INTO foliosfacturas (TipoComprobante,Year,FolioInicial,FolioFinal,FolioActual) values (@TipoComprobante,@year,@FolioInicial,@FolioFinal,@FolioActual)"
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        
            Dim newFolio As tblFoliofacturas = New tblFoliofacturas

            newFolio.TipoComprobante    = CmbTipoDoc.Text
            newFolio.Year               = Label1.Text
            newFolio.FolioInicial       = CInt(TxtfolioIni.Text)
            newFolio.FolioFinal         = CInt(txtFilioFin.Text)
            newFolio.FolioActual        = CInt(TxtFolioAct.Text)

            if DBModelo.InsertFolio(newFolio) Then
                Console.WriteLine("Se pudo")
            Else
                Console.WriteLine("No se pudo")
            End If
            'conn.Open()
            'myCommand.Parameters.Clear()
            'myCommand.Connection = conn
            'myCommand.CommandText = SQL
            'myCommand.Parameters.AddWithValue("@TipoComprobante", CmbTipoDoc.Text)
            'myCommand.Parameters.AddWithValue("@year", CInt(Label1.Text))
            'myCommand.Parameters.AddWithValue("@FolioInicial", CInt(TxtfolioIni.Text))
            'myCommand.Parameters.AddWithValue("@FolioFinal", CInt(txtFilioFin.Text))
            'myCommand.Parameters.AddWithValue("@FolioActual", CInt(TxtFolioAct.Text))
            'myCommand.ExecuteNonQuery()
            'conn.Close()

            Llena_Variables(CmbTipoDoc.Text, TxtfolioIni.Text, txtFilioFin.Text, TxtFolioAct.Text, CInt(Label1.Text))
            Limpiar_campos()
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Folios Fiscales")
            End Try
        End If
        Me.Close()
    End Sub
End Class