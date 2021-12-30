Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

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
        bs.DataSource = Nothing
        bs2.DataSource = Nothing
        dt.Clear()
        dt2.Clear()
        Llena_lista()
        deshabilitar()


        ImgEliminarA.Visible = False
        ImgGuardarA.Visible = False


        txtcontraseña.Text = ""
        txtnombre.Text = ""
        txtusuario.Text = ""
        cmbprivilegios.SelectedIndex = -1

        lblObligatorio.Visible = False
        lblAsterisco.Visible = False
        lblA1.Visible = False
        lblA2.Visible = False
        lblA3.Visible = False
        txtusuario.BackColor = Nothing
        txtcontraseña.BackColor = Nothing
        txtnombre.BackColor = Nothing

        'Me.BackColor = My.Settings.FormsBackColor
        'Me.LstUsuarios.BackColor = My.Settings.FormsBackColor
        'Me.Lblcontraseña.BackColor = My.Settings.FormsBackColor
        'Me.Lblempleado.BackColor = My.Settings.FormsBackColor
        'Me.Lblnombre.BackColor = My.Settings.FormsBackColor
        'Me.Lblprivilegios.BackColor = My.Settings.FormsBackColor
        'Me.Lblusuario.BackColor = My.Settings.FormsBackColor

        'Me.GroupBox1.ForeColor = My.Settings.FontForeColor
        'Me.GroupBox1.Font = My.Settings.FontStyle
        'Me.cmbprivilegios.BackColor = My.Settings.FormsBackColor
        'Me.CmdEliminar.BackColor = My.Settings.FormsBackColor
        'Me.CmdGuardarModificacion.BackColor = My.Settings.FormsBackColor
        'Me.CmdNuevo.BackColor = My.Settings.FormsBackColor
        'Me.CmdSalir.BackColor = My.Settings.FormsBackColor
        Limpia_Variables_SQL_y_Cierra_Conexion()
    End Sub

    Private Sub deshabilitar()
        txtcontraseña.Enabled = False
        txtnombre.Enabled = False
        txtusuario.Enabled = False
        cmbprivilegios.Enabled = False
    End Sub

    Private Sub Habilitar()
        txtcontraseña.Enabled = True
        txtnombre.Enabled = True
        txtusuario.Enabled = True
        cmbprivilegios.Enabled = True
    End Sub

    Private Sub Llena_lista()
        Dim dt_tmp As DataTable
        Try
            SQL = "SELECT * FROM usuarios order by usuario asc "
            conn.Open()
            If conn.State = ConnectionState.Open Then
                myCommand = New SqlCommand(SQL, conn)
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDs)
                dt_tmp = New DataTable
                dt_tmp.Clear()
                myAdapter.Fill(dt_tmp)
                LstUsuarios.DataSource = dt_tmp
                LstUsuarios.ValueMember = "usuario"
                LstUsuarios.DisplayMember = "usuario"
                Limpia_Variables_SQL_y_Cierra_Conexion()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Limpia_Variables_SQL_y_Cierra_Conexion()
        End Try
    End Sub

    Private Sub LstUsuarios_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstUsuarios.DoubleClick
        Dim dt_tmp As DataTable
        Try
            SQL = "SELECT * FROM usuarios where usuario = '" & LstUsuarios.SelectedValue & "' "
            conn.Open()
            If conn.State = ConnectionState.Open Then
                myCommand = New SqlCommand(SQL, conn)
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDs)
                dt_tmp = New DataTable
                dt_tmp.Clear()
                myAdapter.Fill(dt_tmp)
                If dt_tmp.Rows.Count > 0 Then
                    txtusuario.Text = dt_tmp.Rows(0)!usuario
                    txtnombre.Text = dt_tmp.Rows(0)!nombreEmpleado
                    txtcontraseña.Text = dt_tmp.Rows(0)!contrasena
                    cmbprivilegios.Text = dt_tmp.Rows(0)!privilegios
                    Add_Update = False
                    Limpia_Variables_SQL_y_Cierra_Conexion()
                End If
            End If
            ImgEliminarA.Visible = True
            ImgGuardarA.Visible = True
            Habilitar()
            txtusuario.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
            Limpia_Variables_SQL_y_Cierra_Conexion()
        End Try
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

    Private Sub ImgSalirB_Click(sender As System.Object, e As System.EventArgs) Handles ImgSalirB.Click
        Me.Close()
        txtcontraseña.Text = ""
        txtnombre.Text = ""
        txtusuario.Text = ""
    End Sub

    Private Sub ImgSalirB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgSalirB.MouseLeave
        Me.ImgSalirA.Visible = True
        Me.ImgSalirB.Visible = False
    End Sub

    Private Sub ImgSalirA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgSalirA.MouseHover
        Me.ImgSalirB.Visible = True
        Me.ImgSalirA.Visible = False
    End Sub

    Private Sub ImgEliminarB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgEliminarB.MouseLeave
        Me.ImgEliminarA.Visible = True
        Me.ImgEliminarB.Visible = False
    End Sub

    Private Sub ImgEliminarA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgEliminarA.MouseHover
        Me.ImgEliminarB.Visible = True
        Me.ImgEliminarA.Visible = False
    End Sub

    Private Sub ImgCrearNewB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgCrearNewB.MouseLeave
        Me.ImgCrearNewA.Visible = True
        Me.ImgCrearNewB.Visible = False
    End Sub

    Private Sub ImgCrearNewA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgCrearNewA.MouseHover
        Me.ImgCrearNewB.Visible = True
        Me.ImgCrearNewA.Visible = False
    End Sub

    Private Sub ImgGuardarB_Click(sender As System.Object, e As System.EventArgs) Handles ImgGuardarB.Click

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

        If Add_Update = False Then
            If MsgBox("Seguro que desea modificar al Usuario (" & txtusuario.Text & ")?", MsgBoxStyle.YesNo, "Registrar Administradores/Usuarios") = MsgBoxResult.No Then
                Limpiar_Campos()
                deshabilitar()
                Exit Sub
            End If
        End If
        If Add_Update = False Then
            Sql1.Clear()
            Sql1.Append("UPDATE usuarios SET usuario = ")
            Sql1.AppendFormat("'{0}', ", txtusuario.Text)
            Sql1.Append("contrasena = ")
            Sql1.AppendFormat("'{0}', ", txtcontraseña.Text)
            Sql1.Append("privilegios = ")
            Sql1.AppendFormat("'{0}', ", cmbprivilegios.Text)
            Sql1.Append("nombreEmpleado = ")
            Sql1.AppendFormat("'{0}' ", txtnombre.Text)
            Sql1.Append("where usuario = ")
            Sql1.AppendFormat("'{0}' ", txtusuario.Text)
        ElseIf Add_Update = True Then
            Sql1.Clear()
            Sql1.Append("INSERT INTO usuarios (usuario,contrasena,privilegios,nombreEmpleado) values ( ")
            Sql1.AppendFormat("'{0}', ", txtusuario.Text)
            Sql1.AppendFormat("'{0}', ", txtcontraseña.Text)
            Sql1.AppendFormat("'{0}', ", cmbprivilegios.Text)
            Sql1.AppendFormat("'{0}' ", txtnombre.Text)
            Sql1.Append(" )")
        End If
        conn.Open()
        If conn.State = ConnectionState.Open Then
            myCommand = New SqlCommand(Sql1.ToString, conn)
            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myDs)
            Limpia_Variables_SQL_y_Cierra_Conexion()
        End If
        MsgBox("Usuario u Administrador Creado Correctamente", MsgBoxStyle.Information, "Registrar Administradores/Usuarios")
        ImgEliminarA.Visible = False
        ImgGuardarA.Visible = False
        lblObligatorio.Visible = False
        lblAsterisco.Visible = False
        lblA1.Visible = False
        lblA2.Visible = False
        lblA3.Visible = False
        txtusuario.BackColor = Nothing
        txtcontraseña.BackColor = Nothing
        txtnombre.BackColor = Nothing
        deshabilitar()
        Llena_lista()
        Limpiar_Campos()
        Limpia_Variables_SQL_y_Cierra_Conexion()
    End Sub

    Private Sub ImgEliminarB_Click(sender As System.Object, e As System.EventArgs) Handles ImgEliminarB.Click
        If MsgBox("Esta seguro que desea borrar al usuario (" & txtusuario.Text & ")?", MsgBoxStyle.YesNo, "Registrar Administradores/Usuarios") = MsgBoxResult.Yes Then
            Try

                Sql1.Clear()
                Sql1.Append("DELETE from usuarios where usuario = ")
                Sql1.AppendFormat("'{0}' ", txtusuario.Text)

                conn.Open()
                If conn.State = ConnectionState.Open Then
                    myCommand = New SqlCommand(Sql1.ToString, conn)
                    myAdapter.SelectCommand = myCommand
                    myAdapter.Fill(myDs)
                    Limpia_Variables_SQL_y_Cierra_Conexion()
                End If

                Limpiar_Campos()
                deshabilitar()
                Llena_lista()
                Limpia_Variables_SQL_y_Cierra_Conexion()
                ImgEliminarA.Visible = False
                ImgGuardarA.Visible = False
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
                Limpia_Variables_SQL_y_Cierra_Conexion()
            End Try
        Else
            Limpiar_Campos()
            deshabilitar()
            lblObligatorio.Visible = False
            lblAsterisco.Visible = False
            lblA1.Visible = False
            lblA2.Visible = False
            lblA3.Visible = False
            txtusuario.BackColor = Nothing
            txtcontraseña.BackColor = Nothing
            txtnombre.BackColor = Nothing
            ImgEliminarA.Visible = False
            ImgGuardarA.Visible = False
        End If
    End Sub

    Private Sub ImgCrearNewB_Click(sender As System.Object, e As System.EventArgs) Handles ImgCrearNewB.Click
        Habilitar()
        ImgGuardarA.Visible = True
        ImgEliminarA.Visible = False
        txtcontraseña.Text = ""
        txtnombre.Text = ""
        txtusuario.Text = ""
        cmbprivilegios.Text = ""
        Add_Update = True
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

    Private Sub ImgGuardarB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgGuardarB.MouseLeave
        Me.ImgGuardarA.Visible = True
        Me.ImgGuardarB.Visible = False
    End Sub

    Private Sub ImgGuardarA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgGuardarA.MouseHover
        Me.ImgGuardarB.Visible = True
        Me.ImgGuardarA.Visible = False
    End Sub
End Class