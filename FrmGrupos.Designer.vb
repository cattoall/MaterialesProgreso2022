<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGrupos
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
    <System.Diagnostics.DebuggerStepThrough()>
    <Obsolete>
    Private Sub InitializeComponent()
        Me.lblP3 = New System.Windows.Forms.Label()
        Me.lblP2 = New System.Windows.Forms.Label()
        Me.lblObligatorio = New System.Windows.Forms.Label()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtDescripcion = New MetroFramework.Controls.MetroTextBox()
        Me.txtFactorCosto = New MetroFramework.Controls.MetroTextBox()
        Me.txtFactorPublico = New MetroFramework.Controls.MetroTextBox()
        Me.txtFactorP1 = New MetroFramework.Controls.MetroTextBox()
        Me.txtFactorP2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtFactorP3 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSalir = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'lblP3
        '
        Me.lblP3.AutoSize = True
        Me.lblP3.BackColor = System.Drawing.Color.Transparent
        Me.lblP3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP3.ForeColor = System.Drawing.Color.Red
        Me.lblP3.Location = New System.Drawing.Point(156, 157)
        Me.lblP3.Name = "lblP3"
        Me.lblP3.Size = New System.Drawing.Size(17, 19)
        Me.lblP3.TabIndex = 100
        Me.lblP3.Text = "*"
        '
        'lblP2
        '
        Me.lblP2.AutoSize = True
        Me.lblP2.BackColor = System.Drawing.Color.Transparent
        Me.lblP2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2.ForeColor = System.Drawing.Color.Red
        Me.lblP2.Location = New System.Drawing.Point(156, 98)
        Me.lblP2.Name = "lblP2"
        Me.lblP2.Size = New System.Drawing.Size(17, 19)
        Me.lblP2.TabIndex = 99
        Me.lblP2.Text = "*"
        '
        'lblObligatorio
        '
        Me.lblObligatorio.AutoSize = True
        Me.lblObligatorio.BackColor = System.Drawing.Color.Transparent
        Me.lblObligatorio.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObligatorio.ForeColor = System.Drawing.Color.Red
        Me.lblObligatorio.Location = New System.Drawing.Point(295, 60)
        Me.lblObligatorio.Name = "lblObligatorio"
        Me.lblObligatorio.Size = New System.Drawing.Size(96, 19)
        Me.lblObligatorio.TabIndex = 96
        Me.lblObligatorio.Text = "Obligatorio *"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(48, 98)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(87, 19)
        Me.MetroLabel1.TabIndex = 101
        Me.MetroLabel1.Text = "Descripción"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.Location = New System.Drawing.Point(48, 128)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(93, 19)
        Me.MetroLabel2.TabIndex = 102
        Me.MetroLabel2.Text = "Factor Costo"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel3.Location = New System.Drawing.Point(48, 157)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(105, 19)
        Me.MetroLabel3.TabIndex = 103
        Me.MetroLabel3.Text = "Factor Público"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel4.Location = New System.Drawing.Point(48, 186)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel4.TabIndex = 104
        Me.MetroLabel4.Text = "Factor P1"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtDescripcion.CustomButton.Image = Nothing
        Me.txtDescripcion.CustomButton.Location = New System.Drawing.Point(292, 1)
        Me.txtDescripcion.CustomButton.Name = ""
        Me.txtDescripcion.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDescripcion.CustomButton.TabIndex = 1
        Me.txtDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDescripcion.CustomButton.UseSelectable = True
        Me.txtDescripcion.CustomButton.Visible = False
        Me.txtDescripcion.Lines = New String(-1) {}
        Me.txtDescripcion.Location = New System.Drawing.Point(175, 94)
        Me.txtDescripcion.MaxLength = 32767
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescripcion.SelectedText = ""
        Me.txtDescripcion.SelectionLength = 0
        Me.txtDescripcion.SelectionStart = 0
        Me.txtDescripcion.ShortcutsEnabled = True
        Me.txtDescripcion.Size = New System.Drawing.Size(314, 23)
        Me.txtDescripcion.TabIndex = 105
        Me.txtDescripcion.UseSelectable = True
        Me.txtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDescripcion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtFactorCosto
        '
        '
        '
        '
        Me.txtFactorCosto.CustomButton.Image = Nothing
        Me.txtFactorCosto.CustomButton.Location = New System.Drawing.Point(53, 1)
        Me.txtFactorCosto.CustomButton.Name = ""
        Me.txtFactorCosto.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtFactorCosto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFactorCosto.CustomButton.TabIndex = 1
        Me.txtFactorCosto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFactorCosto.CustomButton.UseSelectable = True
        Me.txtFactorCosto.CustomButton.Visible = False
        Me.txtFactorCosto.Lines = New String(-1) {}
        Me.txtFactorCosto.Location = New System.Drawing.Point(175, 124)
        Me.txtFactorCosto.MaxLength = 32767
        Me.txtFactorCosto.Name = "txtFactorCosto"
        Me.txtFactorCosto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFactorCosto.PromptText = "0.00"
        Me.txtFactorCosto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFactorCosto.SelectedText = ""
        Me.txtFactorCosto.SelectionLength = 0
        Me.txtFactorCosto.SelectionStart = 0
        Me.txtFactorCosto.ShortcutsEnabled = True
        Me.txtFactorCosto.Size = New System.Drawing.Size(75, 23)
        Me.txtFactorCosto.TabIndex = 106
        Me.txtFactorCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtFactorCosto.UseSelectable = True
        Me.txtFactorCosto.WaterMark = "0.00"
        Me.txtFactorCosto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFactorCosto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtFactorPublico
        '
        '
        '
        '
        Me.txtFactorPublico.CustomButton.Image = Nothing
        Me.txtFactorPublico.CustomButton.Location = New System.Drawing.Point(53, 1)
        Me.txtFactorPublico.CustomButton.Name = ""
        Me.txtFactorPublico.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtFactorPublico.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFactorPublico.CustomButton.TabIndex = 1
        Me.txtFactorPublico.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFactorPublico.CustomButton.UseSelectable = True
        Me.txtFactorPublico.CustomButton.Visible = False
        Me.txtFactorPublico.Lines = New String(-1) {}
        Me.txtFactorPublico.Location = New System.Drawing.Point(175, 153)
        Me.txtFactorPublico.MaxLength = 32767
        Me.txtFactorPublico.Name = "txtFactorPublico"
        Me.txtFactorPublico.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFactorPublico.PromptText = "0.00"
        Me.txtFactorPublico.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFactorPublico.SelectedText = ""
        Me.txtFactorPublico.SelectionLength = 0
        Me.txtFactorPublico.SelectionStart = 0
        Me.txtFactorPublico.ShortcutsEnabled = True
        Me.txtFactorPublico.Size = New System.Drawing.Size(75, 23)
        Me.txtFactorPublico.TabIndex = 107
        Me.txtFactorPublico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtFactorPublico.UseSelectable = True
        Me.txtFactorPublico.WaterMark = "0.00"
        Me.txtFactorPublico.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFactorPublico.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtFactorP1
        '
        '
        '
        '
        Me.txtFactorP1.CustomButton.Image = Nothing
        Me.txtFactorP1.CustomButton.Location = New System.Drawing.Point(53, 1)
        Me.txtFactorP1.CustomButton.Name = ""
        Me.txtFactorP1.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtFactorP1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFactorP1.CustomButton.TabIndex = 1
        Me.txtFactorP1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFactorP1.CustomButton.UseSelectable = True
        Me.txtFactorP1.CustomButton.Visible = False
        Me.txtFactorP1.Lines = New String(-1) {}
        Me.txtFactorP1.Location = New System.Drawing.Point(175, 182)
        Me.txtFactorP1.MaxLength = 32767
        Me.txtFactorP1.Name = "txtFactorP1"
        Me.txtFactorP1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFactorP1.PromptText = "0.00"
        Me.txtFactorP1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFactorP1.SelectedText = ""
        Me.txtFactorP1.SelectionLength = 0
        Me.txtFactorP1.SelectionStart = 0
        Me.txtFactorP1.ShortcutsEnabled = True
        Me.txtFactorP1.Size = New System.Drawing.Size(75, 23)
        Me.txtFactorP1.TabIndex = 108
        Me.txtFactorP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtFactorP1.UseSelectable = True
        Me.txtFactorP1.WaterMark = "0.00"
        Me.txtFactorP1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFactorP1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtFactorP2
        '
        '
        '
        '
        Me.txtFactorP2.CustomButton.Image = Nothing
        Me.txtFactorP2.CustomButton.Location = New System.Drawing.Point(53, 1)
        Me.txtFactorP2.CustomButton.Name = ""
        Me.txtFactorP2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtFactorP2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFactorP2.CustomButton.TabIndex = 1
        Me.txtFactorP2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFactorP2.CustomButton.UseSelectable = True
        Me.txtFactorP2.CustomButton.Visible = False
        Me.txtFactorP2.Lines = New String(-1) {}
        Me.txtFactorP2.Location = New System.Drawing.Point(177, 211)
        Me.txtFactorP2.MaxLength = 32767
        Me.txtFactorP2.Name = "txtFactorP2"
        Me.txtFactorP2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFactorP2.PromptText = "0.00"
        Me.txtFactorP2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFactorP2.SelectedText = ""
        Me.txtFactorP2.SelectionLength = 0
        Me.txtFactorP2.SelectionStart = 0
        Me.txtFactorP2.ShortcutsEnabled = True
        Me.txtFactorP2.Size = New System.Drawing.Size(75, 23)
        Me.txtFactorP2.TabIndex = 109
        Me.txtFactorP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtFactorP2.UseSelectable = True
        Me.txtFactorP2.WaterMark = "0.00"
        Me.txtFactorP2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFactorP2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtFactorP3
        '
        '
        '
        '
        Me.txtFactorP3.CustomButton.Image = Nothing
        Me.txtFactorP3.CustomButton.Location = New System.Drawing.Point(53, 1)
        Me.txtFactorP3.CustomButton.Name = ""
        Me.txtFactorP3.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtFactorP3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFactorP3.CustomButton.TabIndex = 1
        Me.txtFactorP3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFactorP3.CustomButton.UseSelectable = True
        Me.txtFactorP3.CustomButton.Visible = False
        Me.txtFactorP3.Lines = New String(-1) {}
        Me.txtFactorP3.Location = New System.Drawing.Point(177, 240)
        Me.txtFactorP3.MaxLength = 32767
        Me.txtFactorP3.Name = "txtFactorP3"
        Me.txtFactorP3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFactorP3.PromptText = "0.00"
        Me.txtFactorP3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFactorP3.SelectedText = ""
        Me.txtFactorP3.SelectionLength = 0
        Me.txtFactorP3.SelectionStart = 0
        Me.txtFactorP3.ShortcutsEnabled = True
        Me.txtFactorP3.Size = New System.Drawing.Size(75, 23)
        Me.txtFactorP3.TabIndex = 110
        Me.txtFactorP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtFactorP3.UseSelectable = True
        Me.txtFactorP3.WaterMark = "0.00"
        Me.txtFactorP3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFactorP3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel5.Location = New System.Drawing.Point(48, 215)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel5.TabIndex = 111
        Me.MetroLabel5.Text = "Factor P2"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel6.Location = New System.Drawing.Point(48, 244)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel6.TabIndex = 112
        Me.MetroLabel6.Text = "Factor P3"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(275, 128)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(185, 19)
        Me.MetroLabel7.TabIndex = 113
        Me.MetroLabel7.Text = "1 - 100 % Sobre el Precio Lista"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(275, 157)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(194, 19)
        Me.MetroLabel8.TabIndex = 114
        Me.MetroLabel8.Text = "1 - 100 % Sobre el Precio Costo"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(275, 186)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(203, 19)
        Me.MetroLabel9.TabIndex = 115
        Me.MetroLabel9.Text = "1 - 100 % Sobre el Precio Público"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(275, 215)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(203, 19)
        Me.MetroLabel10.TabIndex = 116
        Me.MetroLabel10.Text = "1 - 100 % Sobre el Precio Público"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(275, 244)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(203, 19)
        Me.MetroLabel11.TabIndex = 117
        Me.MetroLabel11.Text = "1 - 100 % Sobre el Precio Público"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(156, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 19)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(156, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 19)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(156, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 19)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "*"
        '
        'btnSalir
        '
        Me.btnSalir.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnSalir.Location = New System.Drawing.Point(325, 303)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(105, 40)
        Me.btnSalir.TabIndex = 121
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseSelectable = True
        '
        'btnGuardar
        '
        Me.btnGuardar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnGuardar.Location = New System.Drawing.Point(140, 303)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(105, 40)
        Me.btnGuardar.TabIndex = 122
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseSelectable = True
        '
        'FrmGrupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(547, 376)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.txtFactorP3)
        Me.Controls.Add(Me.txtFactorP2)
        Me.Controls.Add(Me.txtFactorP1)
        Me.Controls.Add(Me.txtFactorPublico)
        Me.Controls.Add(Me.txtFactorCosto)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.lblP3)
        Me.Controls.Add(Me.lblP2)
        Me.Controls.Add(Me.lblObligatorio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmGrupos"
        Me.Text = "Datos del Grupo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblP3 As Label
    Friend WithEvents lblP2 As Label
    Friend WithEvents lblObligatorio As Label
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDescripcion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtFactorCosto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtFactorPublico As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtFactorP1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtFactorP2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtFactorP3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSalir As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
End Class
