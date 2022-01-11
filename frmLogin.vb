Imports MySql.Data.MySqlClient

Public Class frmLogin

    Private Sub frmLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cmbSistema.SelectedIndex = cmbSistema.FindString("Salvador")
        txtUsuario.Select()
        txtUsuario.Focus()
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As System.EventArgs) Handles txtPassword.GotFocus
        txtPassword.SelectAll()
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Me.btnEntrar_Click(sender, e)
        End If
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As System.EventArgs) Handles txtPassword.LostFocus
        txtPassword.BackColor = Color.Empty
    End Sub

    Private Sub txtUsuario_GotFocus(sender As Object, e As System.EventArgs) Handles txtUsuario.GotFocus
        txtUsuario.SelectAll()
    End Sub

    Private Sub txtUsuario_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Me.txtPassword.Focus()
        End If
    End Sub

    Private Sub txtUsuario_LostFocus(sender As Object, e As System.EventArgs) Handles txtUsuario.LostFocus
        txtUsuario.BackColor = Color.Empty
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Try
            If gv_terminal = "" Then
                MetroFramework.MetroMessageBox.Show(Me, "Falta crear la Variable de Ambiente de Windows (Terminal)", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            DBConnected = cmbSistema.Text


            'Select Case cmbSistema.Text
            '    Case "Wendy"
            '        connStr = gv_ConStringWendy
            '        DBConnected = "[pv]."
            '    Case "Librada"
            '        connStr = gv_ConStringLibrada
            '        DBConnected = "[pv_new]."
            '    Case "Salvador"
            '        connStr = gv_ConStringSalvador
            '        DBConnected = "[pv_salvador]."
            'End Select

            Dim usr As tblUsuarios = DBModelo.GetUser(txtUsuario.Text)

            If IsNothing(usr) Then
                MetroFramework.MetroMessageBox.Show(Me, "Usuario no existe en el sistema, favor de verificar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUsuario.Focus()
                txtUsuario.SelectAll()
                Exit Sub
            ElseIf usr.contrasena <> txtPassword.Text Then
                MetroFramework.MetroMessageBox.Show(Me, "Contraseña incorrecta, favor de verificar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUsuario.Focus()
                txtUsuario.SelectAll()
                Exit Sub
            Else
                privilegios = usr.privilegios
                usuario = usr.usuario1
                nombreUsuario = usr.nombreEmpleado

                Dim conf As tblConfiguracion = DBModelo.GetConfiguration(gv_terminal)
                If IsNothing(conf) Then
                    MetroFramework.MetroMessageBox.Show(Me, "Terminal (" & gv_terminal & ") no existe en el sistema, favor de verificar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtUsuario.Focus()
                    txtUsuario.SelectAll()
                    Exit Sub
                Else
                    Nombre = conf.nombreEmpresa
                    Propietario = conf.propietario
                    RFC = conf.rfcEmpresa
                    Domicilio = conf.direccionEmpresa
                    Colonia = conf.localidadEmpresa
                    Telefono = conf.telefonoEmpresa
                    Ciudad = conf.ciudadEmpresa
                    FactorIVA = conf.factorIVA
                    InvocePrinterName = conf.InvoicePrinterName
                    TicketPrinterName = conf.TicketPrinterName
                    GranTipoCambio = conf.TipoCambio
                    FactorIVA = conf.factorIVA

                    lv_backup_error = 0
                    Dim lv_backup_pathfile As String
                    lv_backup_pathfile = gv_MySQLBackUpPath + "pv_salvador_" + Format(DateTime.Now.Day, "00") + "_" + Format(DateTime.Now.Month, "00") + "_" + Format(DateTime.Now.Year, "0000") + ".bak"
                    lv_backup_error = 0
                    txtUsuario.Text = ""
                    txtPassword.Text = ""
                    Close()
                End If
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lblCancelar_Click(sender As Object, e As EventArgs) Handles lblCancelar.Click
        End
    End Sub

End Class