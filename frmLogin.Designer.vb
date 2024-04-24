<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits MetroFramework.Forms.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    <Obsolete>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.cmbSistema = New MetroFramework.Controls.MetroComboBox()
        Me.txtUsuario = New MetroFramework.Controls.MetroTextBox()
        Me.txtPassword = New MetroFramework.Controls.MetroTextBox()
        Me.btnEntrar = New MetroFramework.Controls.MetroButton()
        Me.lblCancelar = New MetroFramework.Controls.MetroLink()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbSistema
        '
        Me.cmbSistema.FontWeight = MetroFramework.MetroComboBoxWeight.Bold
        Me.cmbSistema.FormattingEnabled = True
        Me.cmbSistema.ItemHeight = 23
        Me.cmbSistema.Items.AddRange(New Object() {"Wendy", "Librada", "Salvador"})
        Me.cmbSistema.Location = New System.Drawing.Point(97, 85)
        Me.cmbSistema.Name = "cmbSistema"
        Me.cmbSistema.Size = New System.Drawing.Size(205, 29)
        Me.cmbSistema.TabIndex = 28
        Me.cmbSistema.UseSelectable = True
        '
        'txtUsuario
        '
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtUsuario.CustomButton.Image = Nothing
        Me.txtUsuario.CustomButton.Location = New System.Drawing.Point(179, 2)
        Me.txtUsuario.CustomButton.Name = ""
        Me.txtUsuario.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUsuario.CustomButton.TabIndex = 1
        Me.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUsuario.CustomButton.UseSelectable = True
        Me.txtUsuario.CustomButton.Visible = False
        Me.txtUsuario.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtUsuario.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtUsuario.Lines = New String() {"ADMIN"}
        Me.txtUsuario.Location = New System.Drawing.Point(97, 128)
        Me.txtUsuario.MaxLength = 32767
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsuario.PromptText = "Usuario"
        Me.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUsuario.SelectedText = ""
        Me.txtUsuario.SelectionLength = 0
        Me.txtUsuario.SelectionStart = 0
        Me.txtUsuario.ShortcutsEnabled = True
        Me.txtUsuario.Size = New System.Drawing.Size(205, 28)
        Me.txtUsuario.TabIndex = 29
        Me.txtUsuario.Text = "ADMIN"
        Me.txtUsuario.UseSelectable = True
        Me.txtUsuario.WaterMark = "Usuario"
        Me.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUsuario.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPassword
        '
        '
        '
        '
        Me.txtPassword.CustomButton.Image = Nothing
        Me.txtPassword.CustomButton.Location = New System.Drawing.Point(178, 2)
        Me.txtPassword.CustomButton.Name = ""
        Me.txtPassword.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPassword.CustomButton.TabIndex = 1
        Me.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPassword.CustomButton.UseSelectable = True
        Me.txtPassword.CustomButton.Visible = False
        Me.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtPassword.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtPassword.Lines = New String() {"admin"}
        Me.txtPassword.Location = New System.Drawing.Point(97, 169)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PromptText = "Contraseña"
        Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.ShortcutsEnabled = True
        Me.txtPassword.Size = New System.Drawing.Size(204, 28)
        Me.txtPassword.TabIndex = 30
        Me.txtPassword.Text = "admin"
        Me.txtPassword.UseSelectable = True
        Me.txtPassword.WaterMark = "Contraseña"
        Me.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPassword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.Color.Transparent
        Me.btnEntrar.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnEntrar.Location = New System.Drawing.Point(152, 220)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(81, 23)
        Me.btnEntrar.TabIndex = 32
        Me.btnEntrar.Text = "ENTRAR"
        Me.btnEntrar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEntrar.UseSelectable = True
        '
        'lblCancelar
        '
        Me.lblCancelar.ForeColor = System.Drawing.Color.Blue
        Me.lblCancelar.Location = New System.Drawing.Point(147, 263)
        Me.lblCancelar.Name = "lblCancelar"
        Me.lblCancelar.Size = New System.Drawing.Size(91, 23)
        Me.lblCancelar.TabIndex = 34
        Me.lblCancelar.Text = "Cancelar (Esc)"
        Me.lblCancelar.UseCustomForeColor = True
        Me.lblCancelar.UseSelectable = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLoginInterno
        Me.PictureBox1.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.database1
        Me.PictureBox1.Location = New System.Drawing.Point(56, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLoginInterno
        Me.PictureBox6.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.user1
        Me.PictureBox6.Location = New System.Drawing.Point(56, 125)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox6.TabIndex = 22
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLoginInterno
        Me.PictureBox7.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources._private
        Me.PictureBox7.Location = New System.Drawing.Point(56, 167)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox7.TabIndex = 23
        Me.PictureBox7.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 320)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.lblCancelar)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.cmbSistema)
        Me.Controls.Add(Me.PictureBox7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.Text = "Acceso al Sistema"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbSistema As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtUsuario As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnEntrar As MetroFramework.Controls.MetroButton
    Friend WithEvents lblCancelar As MetroFramework.Controls.MetroLink
    Friend WithEvents PictureBox1 As PictureBox
End Class
