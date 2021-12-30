<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProveedor
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtRazonSocial = New MetroFramework.Controls.MetroTextBox()
        Me.txtDomicilio = New MetroFramework.Controls.MetroTextBox()
        Me.txtNumExterno = New MetroFramework.Controls.MetroTextBox()
        Me.txtColonia = New MetroFramework.Controls.MetroTextBox()
        Me.txtCiudad = New MetroFramework.Controls.MetroTextBox()
        Me.txtEstado = New MetroFramework.Controls.MetroTextBox()
        Me.txtCodigoPostal = New MetroFramework.Controls.MetroTextBox()
        Me.txtRFC = New MetroFramework.Controls.MetroTextBox()
        Me.txtTelFijo = New MetroFramework.Controls.MetroTextBox()
        Me.txtMovil = New MetroFramework.Controls.MetroTextBox()
        Me.txtEmail = New MetroFramework.Controls.MetroTextBox()
        Me.txtContacto = New MetroFramework.Controls.MetroTextBox()
        Me.txtObs = New MetroFramework.Controls.MetroTextBox()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.btnSalir = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtRazonSocial.CustomButton.Image = Nothing
        Me.txtRazonSocial.CustomButton.Location = New System.Drawing.Point(459, 1)
        Me.txtRazonSocial.CustomButton.Name = ""
        Me.txtRazonSocial.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtRazonSocial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtRazonSocial.CustomButton.TabIndex = 1
        Me.txtRazonSocial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtRazonSocial.CustomButton.UseSelectable = True
        Me.txtRazonSocial.CustomButton.Visible = False
        Me.txtRazonSocial.Lines = New String(-1) {}
        Me.txtRazonSocial.Location = New System.Drawing.Point(23, 63)
        Me.txtRazonSocial.MaxLength = 32767
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRazonSocial.PromptText = "Razón Social"
        Me.txtRazonSocial.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRazonSocial.SelectedText = ""
        Me.txtRazonSocial.SelectionLength = 0
        Me.txtRazonSocial.SelectionStart = 0
        Me.txtRazonSocial.ShortcutsEnabled = True
        Me.txtRazonSocial.Size = New System.Drawing.Size(481, 23)
        Me.txtRazonSocial.TabIndex = 72
        Me.txtRazonSocial.UseSelectable = True
        Me.txtRazonSocial.WaterMark = "Razón Social"
        Me.txtRazonSocial.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtRazonSocial.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDomicilio
        '
        Me.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtDomicilio.CustomButton.Image = Nothing
        Me.txtDomicilio.CustomButton.Location = New System.Drawing.Point(459, 1)
        Me.txtDomicilio.CustomButton.Name = ""
        Me.txtDomicilio.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtDomicilio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDomicilio.CustomButton.TabIndex = 1
        Me.txtDomicilio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDomicilio.CustomButton.UseSelectable = True
        Me.txtDomicilio.CustomButton.Visible = False
        Me.txtDomicilio.Lines = New String(-1) {}
        Me.txtDomicilio.Location = New System.Drawing.Point(23, 92)
        Me.txtDomicilio.MaxLength = 32767
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDomicilio.PromptText = "Calle"
        Me.txtDomicilio.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDomicilio.SelectedText = ""
        Me.txtDomicilio.SelectionLength = 0
        Me.txtDomicilio.SelectionStart = 0
        Me.txtDomicilio.ShortcutsEnabled = True
        Me.txtDomicilio.Size = New System.Drawing.Size(481, 23)
        Me.txtDomicilio.TabIndex = 73
        Me.txtDomicilio.UseSelectable = True
        Me.txtDomicilio.WaterMark = "Calle"
        Me.txtDomicilio.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDomicilio.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNumExterno
        '
        Me.txtNumExterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtNumExterno.CustomButton.Image = Nothing
        Me.txtNumExterno.CustomButton.Location = New System.Drawing.Point(48, 1)
        Me.txtNumExterno.CustomButton.Name = ""
        Me.txtNumExterno.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNumExterno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNumExterno.CustomButton.TabIndex = 1
        Me.txtNumExterno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNumExterno.CustomButton.UseSelectable = True
        Me.txtNumExterno.CustomButton.Visible = False
        Me.txtNumExterno.Lines = New String(-1) {}
        Me.txtNumExterno.Location = New System.Drawing.Point(23, 121)
        Me.txtNumExterno.MaxLength = 32767
        Me.txtNumExterno.Name = "txtNumExterno"
        Me.txtNumExterno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumExterno.PromptText = "No.Ext"
        Me.txtNumExterno.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumExterno.SelectedText = ""
        Me.txtNumExterno.SelectionLength = 0
        Me.txtNumExterno.SelectionStart = 0
        Me.txtNumExterno.ShortcutsEnabled = True
        Me.txtNumExterno.Size = New System.Drawing.Size(70, 23)
        Me.txtNumExterno.TabIndex = 74
        Me.txtNumExterno.UseSelectable = True
        Me.txtNumExterno.WaterMark = "No.Ext"
        Me.txtNumExterno.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNumExterno.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtColonia
        '
        Me.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtColonia.CustomButton.Image = Nothing
        Me.txtColonia.CustomButton.Location = New System.Drawing.Point(298, 1)
        Me.txtColonia.CustomButton.Name = ""
        Me.txtColonia.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtColonia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtColonia.CustomButton.TabIndex = 1
        Me.txtColonia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtColonia.CustomButton.UseSelectable = True
        Me.txtColonia.CustomButton.Visible = False
        Me.txtColonia.Lines = New String(-1) {}
        Me.txtColonia.Location = New System.Drawing.Point(184, 121)
        Me.txtColonia.MaxLength = 32767
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtColonia.PromptText = "Colonia"
        Me.txtColonia.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtColonia.SelectedText = ""
        Me.txtColonia.SelectionLength = 0
        Me.txtColonia.SelectionStart = 0
        Me.txtColonia.ShortcutsEnabled = True
        Me.txtColonia.Size = New System.Drawing.Size(320, 23)
        Me.txtColonia.TabIndex = 75
        Me.txtColonia.UseSelectable = True
        Me.txtColonia.WaterMark = "Colonia"
        Me.txtColonia.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtColonia.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCiudad
        '
        Me.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtCiudad.CustomButton.Image = Nothing
        Me.txtCiudad.CustomButton.Location = New System.Drawing.Point(168, 1)
        Me.txtCiudad.CustomButton.Name = ""
        Me.txtCiudad.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCiudad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCiudad.CustomButton.TabIndex = 1
        Me.txtCiudad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCiudad.CustomButton.UseSelectable = True
        Me.txtCiudad.CustomButton.Visible = False
        Me.txtCiudad.Lines = New String(-1) {}
        Me.txtCiudad.Location = New System.Drawing.Point(23, 150)
        Me.txtCiudad.MaxLength = 32767
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCiudad.PromptText = "Ciudad"
        Me.txtCiudad.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCiudad.SelectedText = ""
        Me.txtCiudad.SelectionLength = 0
        Me.txtCiudad.SelectionStart = 0
        Me.txtCiudad.ShortcutsEnabled = True
        Me.txtCiudad.Size = New System.Drawing.Size(190, 23)
        Me.txtCiudad.TabIndex = 76
        Me.txtCiudad.UseSelectable = True
        Me.txtCiudad.WaterMark = "Ciudad"
        Me.txtCiudad.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCiudad.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtEstado
        '
        Me.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtEstado.CustomButton.Image = Nothing
        Me.txtEstado.CustomButton.Location = New System.Drawing.Point(168, 1)
        Me.txtEstado.CustomButton.Name = ""
        Me.txtEstado.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEstado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEstado.CustomButton.TabIndex = 1
        Me.txtEstado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEstado.CustomButton.UseSelectable = True
        Me.txtEstado.CustomButton.Visible = False
        Me.txtEstado.Lines = New String(-1) {}
        Me.txtEstado.Location = New System.Drawing.Point(314, 150)
        Me.txtEstado.MaxLength = 32767
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEstado.PromptText = "Estado"
        Me.txtEstado.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEstado.SelectedText = ""
        Me.txtEstado.SelectionLength = 0
        Me.txtEstado.SelectionStart = 0
        Me.txtEstado.ShortcutsEnabled = True
        Me.txtEstado.Size = New System.Drawing.Size(190, 23)
        Me.txtEstado.TabIndex = 77
        Me.txtEstado.UseSelectable = True
        Me.txtEstado.WaterMark = "Estado"
        Me.txtEstado.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEstado.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtCodigoPostal.CustomButton.Image = Nothing
        Me.txtCodigoPostal.CustomButton.Location = New System.Drawing.Point(168, 1)
        Me.txtCodigoPostal.CustomButton.Name = ""
        Me.txtCodigoPostal.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCodigoPostal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCodigoPostal.CustomButton.TabIndex = 1
        Me.txtCodigoPostal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCodigoPostal.CustomButton.UseSelectable = True
        Me.txtCodigoPostal.CustomButton.Visible = False
        Me.txtCodigoPostal.Lines = New String(-1) {}
        Me.txtCodigoPostal.Location = New System.Drawing.Point(23, 179)
        Me.txtCodigoPostal.MaxLength = 32767
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodigoPostal.PromptText = "Código Postal"
        Me.txtCodigoPostal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCodigoPostal.SelectedText = ""
        Me.txtCodigoPostal.SelectionLength = 0
        Me.txtCodigoPostal.SelectionStart = 0
        Me.txtCodigoPostal.ShortcutsEnabled = True
        Me.txtCodigoPostal.Size = New System.Drawing.Size(190, 23)
        Me.txtCodigoPostal.TabIndex = 78
        Me.txtCodigoPostal.UseSelectable = True
        Me.txtCodigoPostal.WaterMark = "Código Postal"
        Me.txtCodigoPostal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCodigoPostal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtRFC
        '
        Me.txtRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtRFC.CustomButton.Image = Nothing
        Me.txtRFC.CustomButton.Location = New System.Drawing.Point(168, 1)
        Me.txtRFC.CustomButton.Name = ""
        Me.txtRFC.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtRFC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtRFC.CustomButton.TabIndex = 1
        Me.txtRFC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtRFC.CustomButton.UseSelectable = True
        Me.txtRFC.CustomButton.Visible = False
        Me.txtRFC.Lines = New String(-1) {}
        Me.txtRFC.Location = New System.Drawing.Point(314, 179)
        Me.txtRFC.MaxLength = 32767
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRFC.PromptText = "RFC"
        Me.txtRFC.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRFC.SelectedText = ""
        Me.txtRFC.SelectionLength = 0
        Me.txtRFC.SelectionStart = 0
        Me.txtRFC.ShortcutsEnabled = True
        Me.txtRFC.Size = New System.Drawing.Size(190, 23)
        Me.txtRFC.TabIndex = 79
        Me.txtRFC.UseSelectable = True
        Me.txtRFC.WaterMark = "RFC"
        Me.txtRFC.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtRFC.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtTelFijo
        '
        Me.txtTelFijo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtTelFijo.CustomButton.Image = Nothing
        Me.txtTelFijo.CustomButton.Location = New System.Drawing.Point(168, 1)
        Me.txtTelFijo.CustomButton.Name = ""
        Me.txtTelFijo.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTelFijo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTelFijo.CustomButton.TabIndex = 1
        Me.txtTelFijo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTelFijo.CustomButton.UseSelectable = True
        Me.txtTelFijo.CustomButton.Visible = False
        Me.txtTelFijo.Lines = New String(-1) {}
        Me.txtTelFijo.Location = New System.Drawing.Point(23, 208)
        Me.txtTelFijo.MaxLength = 32767
        Me.txtTelFijo.Name = "txtTelFijo"
        Me.txtTelFijo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelFijo.PromptText = "Teléfono Fijo"
        Me.txtTelFijo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTelFijo.SelectedText = ""
        Me.txtTelFijo.SelectionLength = 0
        Me.txtTelFijo.SelectionStart = 0
        Me.txtTelFijo.ShortcutsEnabled = True
        Me.txtTelFijo.Size = New System.Drawing.Size(190, 23)
        Me.txtTelFijo.TabIndex = 80
        Me.txtTelFijo.UseSelectable = True
        Me.txtTelFijo.WaterMark = "Teléfono Fijo"
        Me.txtTelFijo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTelFijo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtMovil
        '
        Me.txtMovil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtMovil.CustomButton.Image = Nothing
        Me.txtMovil.CustomButton.Location = New System.Drawing.Point(168, 1)
        Me.txtMovil.CustomButton.Name = ""
        Me.txtMovil.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtMovil.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMovil.CustomButton.TabIndex = 1
        Me.txtMovil.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMovil.CustomButton.UseSelectable = True
        Me.txtMovil.CustomButton.Visible = False
        Me.txtMovil.Lines = New String(-1) {}
        Me.txtMovil.Location = New System.Drawing.Point(314, 208)
        Me.txtMovil.MaxLength = 32767
        Me.txtMovil.Name = "txtMovil"
        Me.txtMovil.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMovil.PromptText = "Celular"
        Me.txtMovil.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMovil.SelectedText = ""
        Me.txtMovil.SelectionLength = 0
        Me.txtMovil.SelectionStart = 0
        Me.txtMovil.ShortcutsEnabled = True
        Me.txtMovil.Size = New System.Drawing.Size(190, 23)
        Me.txtMovil.TabIndex = 81
        Me.txtMovil.UseSelectable = True
        Me.txtMovil.WaterMark = "Celular"
        Me.txtMovil.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMovil.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtEmail.CustomButton.Image = Nothing
        Me.txtEmail.CustomButton.Location = New System.Drawing.Point(459, 1)
        Me.txtEmail.CustomButton.Name = ""
        Me.txtEmail.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmail.CustomButton.TabIndex = 1
        Me.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmail.CustomButton.UseSelectable = True
        Me.txtEmail.CustomButton.Visible = False
        Me.txtEmail.Lines = New String(-1) {}
        Me.txtEmail.Location = New System.Drawing.Point(23, 237)
        Me.txtEmail.MaxLength = 32767
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PromptText = "Correo Electrónico"
        Me.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.SelectionLength = 0
        Me.txtEmail.SelectionStart = 0
        Me.txtEmail.ShortcutsEnabled = True
        Me.txtEmail.Size = New System.Drawing.Size(481, 23)
        Me.txtEmail.TabIndex = 82
        Me.txtEmail.UseSelectable = True
        Me.txtEmail.WaterMark = "Correo Electrónico"
        Me.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtContacto
        '
        Me.txtContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtContacto.CustomButton.Image = Nothing
        Me.txtContacto.CustomButton.Location = New System.Drawing.Point(459, 1)
        Me.txtContacto.CustomButton.Name = ""
        Me.txtContacto.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtContacto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtContacto.CustomButton.TabIndex = 1
        Me.txtContacto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtContacto.CustomButton.UseSelectable = True
        Me.txtContacto.CustomButton.Visible = False
        Me.txtContacto.Lines = New String(-1) {}
        Me.txtContacto.Location = New System.Drawing.Point(23, 266)
        Me.txtContacto.MaxLength = 32767
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContacto.PromptText = "Persona de Contacto"
        Me.txtContacto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtContacto.SelectedText = ""
        Me.txtContacto.SelectionLength = 0
        Me.txtContacto.SelectionStart = 0
        Me.txtContacto.ShortcutsEnabled = True
        Me.txtContacto.Size = New System.Drawing.Size(481, 23)
        Me.txtContacto.TabIndex = 83
        Me.txtContacto.UseSelectable = True
        Me.txtContacto.WaterMark = "Persona de Contacto"
        Me.txtContacto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtContacto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtObs
        '
        Me.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtObs.CustomButton.Image = Nothing
        Me.txtObs.CustomButton.Location = New System.Drawing.Point(323, 1)
        Me.txtObs.CustomButton.Name = ""
        Me.txtObs.CustomButton.Size = New System.Drawing.Size(157, 157)
        Me.txtObs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtObs.CustomButton.TabIndex = 1
        Me.txtObs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtObs.CustomButton.UseSelectable = True
        Me.txtObs.CustomButton.Visible = False
        Me.txtObs.Lines = New String(-1) {}
        Me.txtObs.Location = New System.Drawing.Point(23, 295)
        Me.txtObs.MaxLength = 32767
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtObs.PromptText = "Observaciones"
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtObs.SelectedText = ""
        Me.txtObs.SelectionLength = 0
        Me.txtObs.SelectionStart = 0
        Me.txtObs.ShortcutsEnabled = True
        Me.txtObs.Size = New System.Drawing.Size(481, 159)
        Me.txtObs.TabIndex = 84
        Me.txtObs.UseSelectable = True
        Me.txtObs.WaterMark = "Observaciones"
        Me.txtObs.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtObs.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(23, 462)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 85
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseSelectable = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(429, 462)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 86
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseSelectable = True
        '
        'FrmProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(529, 508)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.txtContacto)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtMovil)
        Me.Controls.Add(Me.txtTelFijo)
        Me.Controls.Add(Me.txtRFC)
        Me.Controls.Add(Me.txtCodigoPostal)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.txtCiudad)
        Me.Controls.Add(Me.txtColonia)
        Me.Controls.Add(Me.txtNumExterno)
        Me.Controls.Add(Me.txtDomicilio)
        Me.Controls.Add(Me.txtRazonSocial)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmProveedor"
        Me.Text = "Datos del Proveedor"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtRazonSocial As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDomicilio As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNumExterno As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtColonia As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCiudad As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtEstado As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCodigoPostal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtRFC As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTelFijo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMovil As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtContacto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtObs As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSalir As MetroFramework.Controls.MetroButton
End Class
