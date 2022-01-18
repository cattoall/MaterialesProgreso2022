Imports System.Data.SqlClient

Public Class FrmUsuarios

    Private Sub FrmUsuarios_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                Me.Close()
                txtcontraseña.Text = ""
                txtnombre.Text = ""
                txtusuario.Text = ""
        End Select
    End Sub

    Private Sub FrmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Llena_lista()

        Habilitar()
        txtcontraseña.Text = ""
        txtnombre.Text = ""
        txtusuario.Text = ""
        cmbprivilegios.SelectedIndex = -1
        Add_Update = False
        lblObligatorio.Visible = False
        lblAsterisco.Visible = False
        lblA1.Visible = False
        lblA2.Visible = False
        lblA3.Visible = False
        txtusuario.BackColor = Nothing
        txtcontraseña.BackColor = Nothing
        txtnombre.BackColor = Nothing
        txtusuario.Focus()
    End Sub

    Private Sub Habilitar()
        txtcontraseña.Enabled = True
        txtnombre.Enabled = True
        txtusuario.Enabled = True
        cmbprivilegios.Enabled = True
    End Sub

    Private Sub Llena_lista()
        LstUsuarios.Refresh()
        Dim Usuarios As List(Of tblUsuarios) = DBModelo.GetUsuariosAll()

        LstUsuarios.DataSource = Usuarios.ToList
        LstUsuarios.ValueMember = "usuario1"
        LstUsuarios.DisplayMember = "usuario1"
    End Sub

    Private Sub LstUsuarios_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstUsuarios.DoubleClick
        Dim Usuario As tblUsuarios = DBModelo.GetUsuario(LstUsuarios.SelectedValue.ToString)
        txtusuario.Text = Usuario.usuario1
        txtnombre.Text = Usuario.nombreEmpleado
        txtcontraseña.Text = Usuario.contrasena
        cmbprivilegios.Text = Usuario.privilegios
        Add_Update = True
        txtusuario.Enabled = False
        btnSave.Text = "Guardar"
    End Sub

    Private Sub txtusuario_GotFocus(sender As Object, e As System.EventArgs) Handles txtusuario.GotFocus
        'txtusuario.BackColor = My.Settings.BoxColor
        txtusuario.Focus()
        txtusuario.SelectAll()
    End Sub

    Private Sub txtusuario_LostFocus(sender As Object, e As System.EventArgs) Handles txtusuario.LostFocus
        txtusuario.BackColor = Color.Empty
    End Sub

    Private Sub txtcontraseña_GotFocus(sender As Object, e As System.EventArgs) Handles txtcontraseña.GotFocus
        'txtcontraseña.BackColor = My.Settings.BoxColor
        txtcontraseña.Focus()
        txtcontraseña.SelectAll()
    End Sub

    Private Sub txtcontraseña_LostFocus(sender As Object, e As System.EventArgs) Handles txtcontraseña.LostFocus
        txtcontraseña.BackColor = Color.Empty
    End Sub

    Private Sub cmbprivilegios_GotFocus(sender As Object, e As System.EventArgs) Handles cmbprivilegios.GotFocus
        'cmbprivilegios.BackColor = My.Settings.BoxColor
        cmbprivilegios.Focus()
        cmbprivilegios.SelectAll()
    End Sub

    Private Sub cmbprivilegios_LostFocus(sender As Object, e As System.EventArgs) Handles cmbprivilegios.LostFocus
        cmbprivilegios.BackColor = Color.Empty
    End Sub

    Private Sub txtnombre_GotFocus(sender As Object, e As System.EventArgs) Handles txtnombre.GotFocus
        'txtnombre.BackColor = My.Settings.BoxColor
        txtnombre.Focus()
        txtnombre.SelectAll()
    End Sub

    Private Sub txtnombre_LostFocus(sender As Object, e As System.EventArgs) Handles txtnombre.LostFocus
        txtnombre.BackColor = Color.Empty
    End Sub

    Private Sub Limpiar_Campos()
        txtusuario.Clear()
        txtcontraseña.Clear()
        txtnombre.Clear()
        cmbprivilegios.SelectedIndex = -1
    End Sub

    Private Sub CmdCrear_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub CmdEliminar_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub CmdSalir_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim strUsuario As New tblUsuarios

        If txtusuario.Text = "" Or txtcontraseña.Text = "" Or cmbprivilegios.Text = "" Or txtnombre.Text = "" Then
            MsgBox("Favor de llenar los campos Obligatorios", MsgBoxStyle.Exclamation, "Registrar Administradores/Usuarios")
            lblObligatorio.Visible = True
            lblAsterisco.Visible = True
            lblA1.Visible = True
            lblA2.Visible = True
            lblA3.Visible = True
            txtusuario.BackColor = Color.LightGray
            txtcontraseña.BackColor = Color.LightGray
            txtnombre.BackColor = Color.LightGray
            Exit Sub
        End If


        If txtcontraseña.Text = "" Then
            MessageBox.Show("Debes digitar la contraseña de usuario", "Registrar Administradores/Usuarios")
            txtcontraseña.Focus()
            Exit Sub

        ElseIf txtnombre.Text = "" Then
            MessageBox.Show("Debes digitar nombre de usuario", "Registrar Administradores/Usuarios")
            txtnombre.Focus()
            Exit Sub

        ElseIf cmbprivilegios.Text = "" And cmbprivilegios.Text <> "A" And cmbprivilegios.Text <> "E" Then
            MessageBox.Show("Debes selecionar el tipo de privilegios (A) o (E)", "Registrar Administradores/Usuarios")
            cmbprivilegios.Focus()
            Exit Sub
        End If

        If btnSave.Text = "Nuevo" Then
            strUsuario.usuario1 = txtusuario.Text
            strUsuario.contrasena = txtcontraseña.Text
            strUsuario.privilegios = cmbprivilegios.Text
            strUsuario.nombreEmpleado = txtnombre.Text

            If Not IsNothing(strUsuario) Then
                If DBModelo.InsertUsuario(strUsuario) Then
                    MetroFramework.MetroMessageBox.Show(Me, "Usuario creado correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "Usuario NO pudo ser creado.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If

            lblObligatorio.Visible = False
            lblAsterisco.Visible = False
            lblA1.Visible = False
            lblA2.Visible = False
            lblA3.Visible = False
            txtusuario.BackColor = Nothing
            txtcontraseña.BackColor = Nothing
            txtnombre.BackColor = Nothing
            Llena_lista()
            Limpiar_Campos()
        End If

        If btnSave.Text = "Guardar" Then
            If MsgBox("Seguro que desea modificar al Usuario (" & txtusuario.Text & ")?", MsgBoxStyle.YesNo, "Registrar Administradores/Usuarios") = MsgBoxResult.No Then
                Limpiar_Campos()
                Exit Sub
            End If

            strUsuario = DBModelo.GetUsuario(txtusuario.Text)

            strUsuario.usuario1 = txtusuario.Text
            strUsuario.contrasena = txtcontraseña.Text
            strUsuario.privilegios = cmbprivilegios.Text
            strUsuario.nombreEmpleado = txtnombre.Text

            If Not IsNothing(strUsuario) Then
                If DBModelo.UpdateUsuario(strUsuario) Then
                    MetroFramework.MetroMessageBox.Show(Me, "Usuario actualizado correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "Usuario NO pudo ser actualizado.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If

            lblObligatorio.Visible = False
            lblAsterisco.Visible = False
            lblA1.Visible = False
            lblA2.Visible = False
            lblA3.Visible = False
            txtusuario.BackColor = Nothing
            txtcontraseña.BackColor = Nothing
            txtnombre.BackColor = Nothing
            Llena_lista()
            Limpiar_Campos()
            btnSave.Text = "Nuevo"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Esta seguro que desea borrar al usuario (" & txtusuario.Text & ")?", MsgBoxStyle.YesNo, "Registrar Administradores/Usuarios") = MsgBoxResult.Yes Then
            Try
                Dim strUsuario As New tblUsuarios
                strUsuario = DBModelo.GetUsuario(txtusuario.Text)

                If Not IsNothing(strUsuario) Then
                    If DBModelo.DeleteUsuario(strUsuario) Then
                        MetroFramework.MetroMessageBox.Show(Me, "Usuario eliminado correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, "Usuario NO pudo ser eliminado.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If

                Limpiar_Campos()
                Llena_lista()
                lblObligatorio.Visible = False
                lblAsterisco.Visible = False
                lblA1.Visible = False
                lblA2.Visible = False
                lblA3.Visible = False
                txtusuario.BackColor = Nothing
                txtcontraseña.BackColor = Nothing
                txtnombre.BackColor = Nothing
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Limpiar_Campos()
            lblObligatorio.Visible = False
            lblAsterisco.Visible = False
            lblA1.Visible = False
            lblA2.Visible = False
            lblA3.Visible = False
            txtusuario.BackColor = Nothing
            txtcontraseña.BackColor = Nothing
            txtnombre.BackColor = Nothing
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        txtcontraseña.Text = ""
        txtnombre.Text = ""
        txtusuario.Text = ""
    End Sub
End Class