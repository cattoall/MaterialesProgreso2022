<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarios
    Inherits MetroFramework.Forms.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblA3 = New System.Windows.Forms.Label()
        Me.lblA2 = New System.Windows.Forms.Label()
        Me.lblA1 = New System.Windows.Forms.Label()
        Me.lblObligatorio = New System.Windows.Forms.Label()
        Me.lblAsterisco = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lblempleado = New System.Windows.Forms.Label()
        Me.Lbladmin = New System.Windows.Forms.Label()
        Me.Lblcontraseña = New System.Windows.Forms.Label()
        Me.Lblprivilegios = New System.Windows.Forms.Label()
        Me.Lblnombre = New System.Windows.Forms.Label()
        Me.Lblusuario = New System.Windows.Forms.Label()
        Me.cmbprivilegios = New System.Windows.Forms.ComboBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.LstUsuarios = New System.Windows.Forms.ListBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.lblA3)
        Me.GroupBox1.Controls.Add(Me.lblA2)
        Me.GroupBox1.Controls.Add(Me.lblA1)
        Me.GroupBox1.Controls.Add(Me.lblObligatorio)
        Me.GroupBox1.Controls.Add(Me.lblAsterisco)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Lblempleado)
        Me.GroupBox1.Controls.Add(Me.Lbladmin)
        Me.GroupBox1.Controls.Add(Me.Lblcontraseña)
        Me.GroupBox1.Controls.Add(Me.Lblprivilegios)
        Me.GroupBox1.Controls.Add(Me.Lblnombre)
        Me.GroupBox1.Controls.Add(Me.Lblusuario)
        Me.GroupBox1.Controls.Add(Me.cmbprivilegios)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.txtcontraseña)
        Me.GroupBox1.Controls.Add(Me.txtusuario)
        Me.GroupBox1.Controls.Add(Me.LstUsuarios)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 76)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(819, 521)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = false
        '
        'lblA3
        '
        Me.lblA3.AutoSize = true
        Me.lblA3.BackColor = System.Drawing.Color.Transparent
        Me.lblA3.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblA3.ForeColor = System.Drawing.Color.Red
        Me.lblA3.Location = New System.Drawing.Point(500, 256)
        Me.lblA3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblA3.Name = "lblA3"
        Me.lblA3.Size = New System.Drawing.Size(20, 23)
        Me.lblA3.TabIndex = 81
        Me.lblA3.Text = "*"
        Me.lblA3.Visible = false
        '
        'lblA2
        '
        Me.lblA2.AutoSize = true
        Me.lblA2.BackColor = System.Drawing.Color.Transparent
        Me.lblA2.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblA2.ForeColor = System.Drawing.Color.Red
        Me.lblA2.Location = New System.Drawing.Point(500, 207)
        Me.lblA2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblA2.Name = "lblA2"
        Me.lblA2.Size = New System.Drawing.Size(20, 23)
        Me.lblA2.TabIndex = 80
        Me.lblA2.Text = "*"
        Me.lblA2.Visible = false
        '
        'lblA1
        '
        Me.lblA1.AutoSize = true
        Me.lblA1.BackColor = System.Drawing.Color.Transparent
        Me.lblA1.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblA1.ForeColor = System.Drawing.Color.Red
        Me.lblA1.Location = New System.Drawing.Point(500, 161)
        Me.lblA1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblA1.Name = "lblA1"
        Me.lblA1.Size = New System.Drawing.Size(20, 23)
        Me.lblA1.TabIndex = 79
        Me.lblA1.Text = "*"
        Me.lblA1.Visible = false
        '
        'lblObligatorio
        '
        Me.lblObligatorio.AutoSize = true
        Me.lblObligatorio.BackColor = System.Drawing.Color.Transparent
        Me.lblObligatorio.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblObligatorio.ForeColor = System.Drawing.Color.Red
        Me.lblObligatorio.Location = New System.Drawing.Point(401, 46)
        Me.lblObligatorio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblObligatorio.Name = "lblObligatorio"
        Me.lblObligatorio.Size = New System.Drawing.Size(121, 23)
        Me.lblObligatorio.TabIndex = 78
        Me.lblObligatorio.Text = "Obligatorio *"
        Me.lblObligatorio.Visible = false
        '
        'lblAsterisco
        '
        Me.lblAsterisco.AutoSize = true
        Me.lblAsterisco.BackColor = System.Drawing.Color.Transparent
        Me.lblAsterisco.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblAsterisco.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisco.Location = New System.Drawing.Point(500, 127)
        Me.lblAsterisco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAsterisco.Name = "lblAsterisco"
        Me.lblAsterisco.Size = New System.Drawing.Size(20, 23)
        Me.lblAsterisco.TabIndex = 77
        Me.lblAsterisco.Text = "*"
        Me.lblAsterisco.Visible = false
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Contactsme
        Me.PictureBox1.Location = New System.Drawing.Point(583, 20)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = false
        '
        'Lblempleado
        '
        Me.Lblempleado.AutoSize = true
        Me.Lblempleado.BackColor = System.Drawing.Color.Transparent
        Me.Lblempleado.Location = New System.Drawing.Point(595, 226)
        Me.Lblempleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblempleado.Name = "Lblempleado"
        Me.Lblempleado.Size = New System.Drawing.Size(125, 23)
        Me.Lblempleado.TabIndex = 19
        Me.Lblempleado.Text = "(E) Empleado"
        '
        'Lbladmin
        '
        Me.Lbladmin.BackColor = System.Drawing.Color.Transparent
        Me.Lbladmin.Location = New System.Drawing.Point(595, 206)
        Me.Lbladmin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbladmin.Name = "Lbladmin"
        Me.Lbladmin.Size = New System.Drawing.Size(185, 30)
        Me.Lbladmin.TabIndex = 18
        Me.Lbladmin.Text = "(A) Administrador "
        '
        'Lblcontraseña
        '
        Me.Lblcontraseña.AutoSize = true
        Me.Lblcontraseña.BackColor = System.Drawing.Color.Transparent
        Me.Lblcontraseña.Location = New System.Drawing.Point(385, 165)
        Me.Lblcontraseña.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblcontraseña.Name = "Lblcontraseña"
        Me.Lblcontraseña.Size = New System.Drawing.Size(115, 23)
        Me.Lblcontraseña.TabIndex = 16
        Me.Lblcontraseña.Text = "Contraseña:"
        '
        'Lblprivilegios
        '
        Me.Lblprivilegios.AutoSize = true
        Me.Lblprivilegios.BackColor = System.Drawing.Color.Transparent
        Me.Lblprivilegios.Location = New System.Drawing.Point(392, 210)
        Me.Lblprivilegios.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblprivilegios.Name = "Lblprivilegios"
        Me.Lblprivilegios.Size = New System.Drawing.Size(105, 23)
        Me.Lblprivilegios.TabIndex = 15
        Me.Lblprivilegios.Text = "Privilegios:"
        '
        'Lblnombre
        '
        Me.Lblnombre.AutoSize = true
        Me.Lblnombre.BackColor = System.Drawing.Color.Transparent
        Me.Lblnombre.Location = New System.Drawing.Point(417, 260)
        Me.Lblnombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblnombre.Name = "Lblnombre"
        Me.Lblnombre.Size = New System.Drawing.Size(84, 23)
        Me.Lblnombre.TabIndex = 14
        Me.Lblnombre.Text = "Nombre:"
        '
        'Lblusuario
        '
        Me.Lblusuario.AutoSize = true
        Me.Lblusuario.BackColor = System.Drawing.Color.Transparent
        Me.Lblusuario.Location = New System.Drawing.Point(419, 130)
        Me.Lblusuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblusuario.Name = "Lblusuario"
        Me.Lblusuario.Size = New System.Drawing.Size(82, 23)
        Me.Lblusuario.TabIndex = 13
        Me.Lblusuario.Text = "Usuario:"
        '
        'cmbprivilegios
        '
        Me.cmbprivilegios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbprivilegios.FormattingEnabled = true
        Me.cmbprivilegios.Items.AddRange(New Object() {"A", "E"})
        Me.cmbprivilegios.Location = New System.Drawing.Point(524, 207)
        Me.cmbprivilegios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbprivilegios.Name = "cmbprivilegios"
        Me.cmbprivilegios.Size = New System.Drawing.Size(65, 31)
        Me.cmbprivilegios.TabIndex = 5
        '
        'txtnombre
        '
        Me.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnombre.Location = New System.Drawing.Point(524, 256)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(231, 30)
        Me.txtnombre.TabIndex = 6
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Location = New System.Drawing.Point(524, 161)
        Me.txtcontraseña.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontraseña.Size = New System.Drawing.Size(231, 30)
        Me.txtcontraseña.TabIndex = 4
        '
        'txtusuario
        '
        Me.txtusuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtusuario.Location = New System.Drawing.Point(524, 127)
        Me.txtusuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(231, 30)
        Me.txtusuario.TabIndex = 3
        '
        'LstUsuarios
        '
        Me.LstUsuarios.FormattingEnabled = true
        Me.LstUsuarios.ItemHeight = 23
        Me.LstUsuarios.Location = New System.Drawing.Point(8, 12)
        Me.LstUsuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LstUsuarios.Name = "LstUsuarios"
        Me.LstUsuarios.Size = New System.Drawing.Size(347, 487)
        Me.LstUsuarios.TabIndex = 1
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.trash_can_16px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(655, 325)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 86
        Me.Button1.Text = "Eliminar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = true
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47,Byte),Integer), CType(CType(170,Byte),Integer), CType(CType(141,Byte),Integer))
        Me.btnSave.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.save_16px
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(655, 291)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 28)
        Me.btnSave.TabIndex = 85
        Me.btnSave.Text = "Nuevo"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.UseVisualStyleBackColor = true
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.close_window_16px
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(655, 359)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 87
        Me.Button2.Text = "Salir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = true
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(851, 634)
        Me.ControlBox = false
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = true
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = false
        Me.Name = "FrmUsuarios"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Text = "Usuarios"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LstUsuarios As System.Windows.Forms.ListBox
    Friend WithEvents Lblcontraseña As System.Windows.Forms.Label
    Friend WithEvents Lblprivilegios As System.Windows.Forms.Label
    Friend WithEvents Lblnombre As System.Windows.Forms.Label
    Friend WithEvents Lblusuario As System.Windows.Forms.Label
    Friend WithEvents cmbprivilegios As System.Windows.Forms.ComboBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtcontraseña As System.Windows.Forms.TextBox
    Friend WithEvents txtusuario As System.Windows.Forms.TextBox
    Friend WithEvents Lblempleado As System.Windows.Forms.Label
    Friend WithEvents Lbladmin As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblA3 As System.Windows.Forms.Label
    Friend WithEvents lblA2 As System.Windows.Forms.Label
    Friend WithEvents lblA1 As System.Windows.Forms.Label
    Friend WithEvents lblObligatorio As System.Windows.Forms.Label
    Friend WithEvents lblAsterisco As System.Windows.Forms.Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSave As Button
End Class
