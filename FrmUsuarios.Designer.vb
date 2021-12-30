<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarios
    Inherits System.Windows.Forms.Form

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
        Me.ImgCrearNewB = New System.Windows.Forms.PictureBox()
        Me.ImgCrearNewA = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ImgSalirB = New System.Windows.Forms.PictureBox()
        Me.ImgSalirA = New System.Windows.Forms.PictureBox()
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
        Me.ImgEliminarB = New System.Windows.Forms.PictureBox()
        Me.ImgEliminarA = New System.Windows.Forms.PictureBox()
        Me.ImgGuardarA = New System.Windows.Forms.PictureBox()
        Me.ImgGuardarB = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ImgCrearNewB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgCrearNewA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSalirB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSalirA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgEliminarB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgEliminarA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgGuardarA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgGuardarB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.GroupBox1.Controls.Add(Me.lblA3)
        Me.GroupBox1.Controls.Add(Me.lblA2)
        Me.GroupBox1.Controls.Add(Me.lblA1)
        Me.GroupBox1.Controls.Add(Me.lblObligatorio)
        Me.GroupBox1.Controls.Add(Me.lblAsterisco)
        Me.GroupBox1.Controls.Add(Me.ImgCrearNewB)
        Me.GroupBox1.Controls.Add(Me.ImgCrearNewA)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.ImgSalirB)
        Me.GroupBox1.Controls.Add(Me.ImgSalirA)
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
        Me.GroupBox1.Controls.Add(Me.ImgGuardarB)
        Me.GroupBox1.Controls.Add(Me.ImgEliminarB)
        Me.GroupBox1.Controls.Add(Me.ImgEliminarA)
        Me.GroupBox1.Controls.Add(Me.ImgGuardarA)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(614, 423)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'lblA3
        '
        Me.lblA3.AutoSize = True
        Me.lblA3.BackColor = System.Drawing.Color.Transparent
        Me.lblA3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA3.ForeColor = System.Drawing.Color.Red
        Me.lblA3.Location = New System.Drawing.Point(375, 208)
        Me.lblA3.Name = "lblA3"
        Me.lblA3.Size = New System.Drawing.Size(17, 19)
        Me.lblA3.TabIndex = 81
        Me.lblA3.Text = "*"
        Me.lblA3.Visible = False
        '
        'lblA2
        '
        Me.lblA2.AutoSize = True
        Me.lblA2.BackColor = System.Drawing.Color.Transparent
        Me.lblA2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA2.ForeColor = System.Drawing.Color.Red
        Me.lblA2.Location = New System.Drawing.Point(375, 168)
        Me.lblA2.Name = "lblA2"
        Me.lblA2.Size = New System.Drawing.Size(17, 19)
        Me.lblA2.TabIndex = 80
        Me.lblA2.Text = "*"
        Me.lblA2.Visible = False
        '
        'lblA1
        '
        Me.lblA1.AutoSize = True
        Me.lblA1.BackColor = System.Drawing.Color.Transparent
        Me.lblA1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA1.ForeColor = System.Drawing.Color.Red
        Me.lblA1.Location = New System.Drawing.Point(375, 131)
        Me.lblA1.Name = "lblA1"
        Me.lblA1.Size = New System.Drawing.Size(17, 19)
        Me.lblA1.TabIndex = 79
        Me.lblA1.Text = "*"
        Me.lblA1.Visible = False
        '
        'lblObligatorio
        '
        Me.lblObligatorio.AutoSize = True
        Me.lblObligatorio.BackColor = System.Drawing.Color.Transparent
        Me.lblObligatorio.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObligatorio.ForeColor = System.Drawing.Color.Red
        Me.lblObligatorio.Location = New System.Drawing.Point(301, 37)
        Me.lblObligatorio.Name = "lblObligatorio"
        Me.lblObligatorio.Size = New System.Drawing.Size(96, 19)
        Me.lblObligatorio.TabIndex = 78
        Me.lblObligatorio.Text = "Obligatorio *"
        Me.lblObligatorio.Visible = False
        '
        'lblAsterisco
        '
        Me.lblAsterisco.AutoSize = True
        Me.lblAsterisco.BackColor = System.Drawing.Color.Transparent
        Me.lblAsterisco.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsterisco.ForeColor = System.Drawing.Color.Red
        Me.lblAsterisco.Location = New System.Drawing.Point(375, 103)
        Me.lblAsterisco.Name = "lblAsterisco"
        Me.lblAsterisco.Size = New System.Drawing.Size(17, 19)
        Me.lblAsterisco.TabIndex = 77
        Me.lblAsterisco.Text = "*"
        Me.lblAsterisco.Visible = False
        '
        'ImgCrearNewB
        '
        Me.ImgCrearNewB.BackColor = System.Drawing.Color.Transparent
        Me.ImgCrearNewB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgCrearNewB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.CrateNew
        Me.ImgCrearNewB.Location = New System.Drawing.Point(383, 246)
        Me.ImgCrearNewB.Name = "ImgCrearNewB"
        Me.ImgCrearNewB.Size = New System.Drawing.Size(186, 35)
        Me.ImgCrearNewB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgCrearNewB.TabIndex = 54
        Me.ImgCrearNewB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgCrearNewB, "Nuevo")
        Me.ImgCrearNewB.Visible = False
        '
        'ImgCrearNewA
        '
        Me.ImgCrearNewA.BackColor = System.Drawing.Color.Transparent
        Me.ImgCrearNewA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.CrateNew
        Me.ImgCrearNewA.Location = New System.Drawing.Point(392, 248)
        Me.ImgCrearNewA.Name = "ImgCrearNewA"
        Me.ImgCrearNewA.Size = New System.Drawing.Size(165, 31)
        Me.ImgCrearNewA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgCrearNewA.TabIndex = 53
        Me.ImgCrearNewA.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Contactsme
        Me.PictureBox1.Location = New System.Drawing.Point(437, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(81, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        '
        'ImgSalirB
        '
        Me.ImgSalirB.BackColor = System.Drawing.Color.Transparent
        Me.ImgSalirB.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ImgSalirB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgSalirB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.btn_salir
        Me.ImgSalirB.Location = New System.Drawing.Point(425, 359)
        Me.ImgSalirB.Name = "ImgSalirB"
        Me.ImgSalirB.Size = New System.Drawing.Size(94, 35)
        Me.ImgSalirB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSalirB.TabIndex = 56
        Me.ImgSalirB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgSalirB, "Salir (Esc)")
        Me.ImgSalirB.Visible = False
        '
        'ImgSalirA
        '
        Me.ImgSalirA.BackColor = System.Drawing.Color.Transparent
        Me.ImgSalirA.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ImgSalirA.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ImgSalirA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.btn_salir
        Me.ImgSalirA.Location = New System.Drawing.Point(428, 361)
        Me.ImgSalirA.Name = "ImgSalirA"
        Me.ImgSalirA.Size = New System.Drawing.Size(88, 31)
        Me.ImgSalirA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSalirA.TabIndex = 55
        Me.ImgSalirA.TabStop = False
        '
        'Lblempleado
        '
        Me.Lblempleado.AutoSize = True
        Me.Lblempleado.BackColor = System.Drawing.Color.Transparent
        Me.Lblempleado.Location = New System.Drawing.Point(446, 184)
        Me.Lblempleado.Name = "Lblempleado"
        Me.Lblempleado.Size = New System.Drawing.Size(99, 19)
        Me.Lblempleado.TabIndex = 19
        Me.Lblempleado.Text = "(E) Empleado"
        '
        'Lbladmin
        '
        Me.Lbladmin.BackColor = System.Drawing.Color.Transparent
        Me.Lbladmin.Location = New System.Drawing.Point(446, 167)
        Me.Lbladmin.Name = "Lbladmin"
        Me.Lbladmin.Size = New System.Drawing.Size(139, 24)
        Me.Lbladmin.TabIndex = 18
        Me.Lbladmin.Text = "(A) Administrador "
        '
        'Lblcontraseña
        '
        Me.Lblcontraseña.AutoSize = True
        Me.Lblcontraseña.BackColor = System.Drawing.Color.Transparent
        Me.Lblcontraseña.Location = New System.Drawing.Point(289, 134)
        Me.Lblcontraseña.Name = "Lblcontraseña"
        Me.Lblcontraseña.Size = New System.Drawing.Size(91, 19)
        Me.Lblcontraseña.TabIndex = 16
        Me.Lblcontraseña.Text = "Contraseña:"
        '
        'Lblprivilegios
        '
        Me.Lblprivilegios.AutoSize = True
        Me.Lblprivilegios.BackColor = System.Drawing.Color.Transparent
        Me.Lblprivilegios.Location = New System.Drawing.Point(294, 171)
        Me.Lblprivilegios.Name = "Lblprivilegios"
        Me.Lblprivilegios.Size = New System.Drawing.Size(84, 19)
        Me.Lblprivilegios.TabIndex = 15
        Me.Lblprivilegios.Text = "Privilegios:"
        '
        'Lblnombre
        '
        Me.Lblnombre.AutoSize = True
        Me.Lblnombre.BackColor = System.Drawing.Color.Transparent
        Me.Lblnombre.Location = New System.Drawing.Point(313, 211)
        Me.Lblnombre.Name = "Lblnombre"
        Me.Lblnombre.Size = New System.Drawing.Size(68, 19)
        Me.Lblnombre.TabIndex = 14
        Me.Lblnombre.Text = "Nombre:"
        '
        'Lblusuario
        '
        Me.Lblusuario.AutoSize = True
        Me.Lblusuario.BackColor = System.Drawing.Color.Transparent
        Me.Lblusuario.Location = New System.Drawing.Point(314, 106)
        Me.Lblusuario.Name = "Lblusuario"
        Me.Lblusuario.Size = New System.Drawing.Size(66, 19)
        Me.Lblusuario.TabIndex = 13
        Me.Lblusuario.Text = "Usuario:"
        '
        'cmbprivilegios
        '
        Me.cmbprivilegios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbprivilegios.FormattingEnabled = True
        Me.cmbprivilegios.Items.AddRange(New Object() {"A", "E"})
        Me.cmbprivilegios.Location = New System.Drawing.Point(393, 168)
        Me.cmbprivilegios.Name = "cmbprivilegios"
        Me.cmbprivilegios.Size = New System.Drawing.Size(50, 27)
        Me.cmbprivilegios.TabIndex = 5
        '
        'txtnombre
        '
        Me.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnombre.Location = New System.Drawing.Point(393, 208)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(174, 26)
        Me.txtnombre.TabIndex = 6
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Location = New System.Drawing.Point(393, 131)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontraseña.Size = New System.Drawing.Size(174, 26)
        Me.txtcontraseña.TabIndex = 4
        '
        'txtusuario
        '
        Me.txtusuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtusuario.Location = New System.Drawing.Point(393, 103)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(174, 26)
        Me.txtusuario.TabIndex = 3
        '
        'LstUsuarios
        '
        Me.LstUsuarios.FormattingEnabled = True
        Me.LstUsuarios.ItemHeight = 19
        Me.LstUsuarios.Location = New System.Drawing.Point(6, 10)
        Me.LstUsuarios.Name = "LstUsuarios"
        Me.LstUsuarios.Size = New System.Drawing.Size(261, 403)
        Me.LstUsuarios.TabIndex = 1
        '
        'ImgEliminarB
        '
        Me.ImgEliminarB.BackColor = System.Drawing.Color.Transparent
        Me.ImgEliminarB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgEliminarB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Eliminar123
        Me.ImgEliminarB.Location = New System.Drawing.Point(419, 308)
        Me.ImgEliminarB.Name = "ImgEliminarB"
        Me.ImgEliminarB.Size = New System.Drawing.Size(110, 35)
        Me.ImgEliminarB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgEliminarB.TabIndex = 76
        Me.ImgEliminarB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgEliminarB, "Eliminar")
        Me.ImgEliminarB.Visible = False
        '
        'ImgEliminarA
        '
        Me.ImgEliminarA.BackColor = System.Drawing.Color.Transparent
        Me.ImgEliminarA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Eliminar123
        Me.ImgEliminarA.Location = New System.Drawing.Point(424, 309)
        Me.ImgEliminarA.Name = "ImgEliminarA"
        Me.ImgEliminarA.Size = New System.Drawing.Size(100, 32)
        Me.ImgEliminarA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgEliminarA.TabIndex = 75
        Me.ImgEliminarA.TabStop = False
        '
        'ImgGuardarA
        '
        Me.ImgGuardarA.BackColor = System.Drawing.Color.Transparent
        Me.ImgGuardarA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.img_guardar
        Me.ImgGuardarA.Location = New System.Drawing.Point(300, 247)
        Me.ImgGuardarA.Name = "ImgGuardarA"
        Me.ImgGuardarA.Size = New System.Drawing.Size(35, 32)
        Me.ImgGuardarA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgGuardarA.TabIndex = 73
        Me.ImgGuardarA.TabStop = False
        Me.ImgGuardarA.Visible = False
        '
        'ImgGuardarB
        '
        Me.ImgGuardarB.BackColor = System.Drawing.Color.Transparent
        Me.ImgGuardarB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgGuardarB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.img_guardar
        Me.ImgGuardarB.Location = New System.Drawing.Point(297, 244)
        Me.ImgGuardarB.Name = "ImgGuardarB"
        Me.ImgGuardarB.Size = New System.Drawing.Size(41, 38)
        Me.ImgGuardarB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgGuardarB.TabIndex = 72
        Me.ImgGuardarB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgGuardarB, "Guardar")
        Me.ImgGuardarB.Visible = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(638, 429)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ImgCrearNewB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgCrearNewA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSalirB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSalirA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgEliminarB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgEliminarA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgGuardarA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgGuardarB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents ImgSalirB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgSalirA As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ImgGuardarB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgGuardarA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgEliminarB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgEliminarA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgCrearNewB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgCrearNewA As System.Windows.Forms.PictureBox
    Friend WithEvents lblA3 As System.Windows.Forms.Label
    Friend WithEvents lblA2 As System.Windows.Forms.Label
    Friend WithEvents lblA1 As System.Windows.Forms.Label
    Friend WithEvents lblObligatorio As System.Windows.Forms.Label
    Friend WithEvents lblAsterisco As System.Windows.Forms.Label
End Class
