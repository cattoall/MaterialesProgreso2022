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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout
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
        Me.txtRazonSocial.CustomButton.Location = New System.Drawing.Point(820, 2)
        Me.txtRazonSocial.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRazonSocial.CustomButton.Name = ""
        Me.txtRazonSocial.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtRazonSocial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtRazonSocial.CustomButton.TabIndex = 1
        Me.txtRazonSocial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtRazonSocial.CustomButton.UseSelectable = true
        Me.txtRazonSocial.CustomButton.Visible = false
        Me.txtRazonSocial.Lines = New String(-1) {}
        Me.txtRazonSocial.Location = New System.Drawing.Point(31, 78)
        Me.txtRazonSocial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRazonSocial.MaxLength = 32767
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRazonSocial.PromptText = "Razón Social"
        Me.txtRazonSocial.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRazonSocial.SelectedText = ""
        Me.txtRazonSocial.SelectionLength = 0
        Me.txtRazonSocial.SelectionStart = 0
        Me.txtRazonSocial.ShortcutsEnabled = true
        Me.txtRazonSocial.Size = New System.Drawing.Size(641, 28)
        Me.txtRazonSocial.TabIndex = 72
        Me.txtRazonSocial.UseSelectable = true
        Me.txtRazonSocial.WaterMark = "Razón Social"
        Me.txtRazonSocial.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtRazonSocial.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDomicilio
        '
        Me.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtDomicilio.CustomButton.Image = Nothing
        Me.txtDomicilio.CustomButton.Location = New System.Drawing.Point(820, 2)
        Me.txtDomicilio.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDomicilio.CustomButton.Name = ""
        Me.txtDomicilio.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtDomicilio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDomicilio.CustomButton.TabIndex = 1
        Me.txtDomicilio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDomicilio.CustomButton.UseSelectable = true
        Me.txtDomicilio.CustomButton.Visible = false
        Me.txtDomicilio.Lines = New String(-1) {}
        Me.txtDomicilio.Location = New System.Drawing.Point(31, 113)
        Me.txtDomicilio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDomicilio.MaxLength = 32767
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDomicilio.PromptText = "Calle"
        Me.txtDomicilio.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDomicilio.SelectedText = ""
        Me.txtDomicilio.SelectionLength = 0
        Me.txtDomicilio.SelectionStart = 0
        Me.txtDomicilio.ShortcutsEnabled = true
        Me.txtDomicilio.Size = New System.Drawing.Size(641, 28)
        Me.txtDomicilio.TabIndex = 73
        Me.txtDomicilio.UseSelectable = true
        Me.txtDomicilio.WaterMark = "Calle"
        Me.txtDomicilio.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtDomicilio.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNumExterno
        '
        Me.txtNumExterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtNumExterno.CustomButton.Image = Nothing
        Me.txtNumExterno.CustomButton.Location = New System.Drawing.Point(89, 2)
        Me.txtNumExterno.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNumExterno.CustomButton.Name = ""
        Me.txtNumExterno.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtNumExterno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNumExterno.CustomButton.TabIndex = 1
        Me.txtNumExterno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNumExterno.CustomButton.UseSelectable = true
        Me.txtNumExterno.CustomButton.Visible = false
        Me.txtNumExterno.Lines = New String(-1) {}
        Me.txtNumExterno.Location = New System.Drawing.Point(31, 149)
        Me.txtNumExterno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNumExterno.MaxLength = 32767
        Me.txtNumExterno.Name = "txtNumExterno"
        Me.txtNumExterno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumExterno.PromptText = "No.Ext"
        Me.txtNumExterno.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumExterno.SelectedText = ""
        Me.txtNumExterno.SelectionLength = 0
        Me.txtNumExterno.SelectionStart = 0
        Me.txtNumExterno.ShortcutsEnabled = true
        Me.txtNumExterno.Size = New System.Drawing.Size(93, 28)
        Me.txtNumExterno.TabIndex = 74
        Me.txtNumExterno.UseSelectable = true
        Me.txtNumExterno.WaterMark = "No.Ext"
        Me.txtNumExterno.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtNumExterno.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtColonia
        '
        Me.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtColonia.CustomButton.Image = Nothing
        Me.txtColonia.CustomButton.Location = New System.Drawing.Point(535, 2)
        Me.txtColonia.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtColonia.CustomButton.Name = ""
        Me.txtColonia.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtColonia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtColonia.CustomButton.TabIndex = 1
        Me.txtColonia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtColonia.CustomButton.UseSelectable = true
        Me.txtColonia.CustomButton.Visible = false
        Me.txtColonia.Lines = New String(-1) {}
        Me.txtColonia.Location = New System.Drawing.Point(245, 149)
        Me.txtColonia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtColonia.MaxLength = 32767
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtColonia.PromptText = "Colonia"
        Me.txtColonia.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtColonia.SelectedText = ""
        Me.txtColonia.SelectionLength = 0
        Me.txtColonia.SelectionStart = 0
        Me.txtColonia.ShortcutsEnabled = true
        Me.txtColonia.Size = New System.Drawing.Size(427, 28)
        Me.txtColonia.TabIndex = 75
        Me.txtColonia.UseSelectable = true
        Me.txtColonia.WaterMark = "Colonia"
        Me.txtColonia.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtColonia.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCiudad
        '
        Me.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtCiudad.CustomButton.Image = Nothing
        Me.txtCiudad.CustomButton.Location = New System.Drawing.Point(303, 2)
        Me.txtCiudad.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCiudad.CustomButton.Name = ""
        Me.txtCiudad.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtCiudad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCiudad.CustomButton.TabIndex = 1
        Me.txtCiudad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCiudad.CustomButton.UseSelectable = true
        Me.txtCiudad.CustomButton.Visible = false
        Me.txtCiudad.Lines = New String(-1) {}
        Me.txtCiudad.Location = New System.Drawing.Point(31, 185)
        Me.txtCiudad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCiudad.MaxLength = 32767
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCiudad.PromptText = "Ciudad"
        Me.txtCiudad.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCiudad.SelectedText = ""
        Me.txtCiudad.SelectionLength = 0
        Me.txtCiudad.SelectionStart = 0
        Me.txtCiudad.ShortcutsEnabled = true
        Me.txtCiudad.Size = New System.Drawing.Size(253, 28)
        Me.txtCiudad.TabIndex = 76
        Me.txtCiudad.UseSelectable = true
        Me.txtCiudad.WaterMark = "Ciudad"
        Me.txtCiudad.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtCiudad.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtEstado
        '
        Me.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtEstado.CustomButton.Image = Nothing
        Me.txtEstado.CustomButton.Location = New System.Drawing.Point(303, 2)
        Me.txtEstado.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEstado.CustomButton.Name = ""
        Me.txtEstado.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtEstado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEstado.CustomButton.TabIndex = 1
        Me.txtEstado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEstado.CustomButton.UseSelectable = true
        Me.txtEstado.CustomButton.Visible = false
        Me.txtEstado.Lines = New String(-1) {}
        Me.txtEstado.Location = New System.Drawing.Point(419, 185)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEstado.MaxLength = 32767
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEstado.PromptText = "Estado"
        Me.txtEstado.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEstado.SelectedText = ""
        Me.txtEstado.SelectionLength = 0
        Me.txtEstado.SelectionStart = 0
        Me.txtEstado.ShortcutsEnabled = true
        Me.txtEstado.Size = New System.Drawing.Size(253, 28)
        Me.txtEstado.TabIndex = 77
        Me.txtEstado.UseSelectable = true
        Me.txtEstado.WaterMark = "Estado"
        Me.txtEstado.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtEstado.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtCodigoPostal.CustomButton.Image = Nothing
        Me.txtCodigoPostal.CustomButton.Location = New System.Drawing.Point(303, 2)
        Me.txtCodigoPostal.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCodigoPostal.CustomButton.Name = ""
        Me.txtCodigoPostal.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtCodigoPostal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCodigoPostal.CustomButton.TabIndex = 1
        Me.txtCodigoPostal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCodigoPostal.CustomButton.UseSelectable = true
        Me.txtCodigoPostal.CustomButton.Visible = false
        Me.txtCodigoPostal.Lines = New String(-1) {}
        Me.txtCodigoPostal.Location = New System.Drawing.Point(31, 220)
        Me.txtCodigoPostal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCodigoPostal.MaxLength = 32767
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodigoPostal.PromptText = "Código Postal"
        Me.txtCodigoPostal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCodigoPostal.SelectedText = ""
        Me.txtCodigoPostal.SelectionLength = 0
        Me.txtCodigoPostal.SelectionStart = 0
        Me.txtCodigoPostal.ShortcutsEnabled = true
        Me.txtCodigoPostal.Size = New System.Drawing.Size(253, 28)
        Me.txtCodigoPostal.TabIndex = 78
        Me.txtCodigoPostal.UseSelectable = true
        Me.txtCodigoPostal.WaterMark = "Código Postal"
        Me.txtCodigoPostal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtCodigoPostal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtRFC
        '
        Me.txtRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtRFC.CustomButton.Image = Nothing
        Me.txtRFC.CustomButton.Location = New System.Drawing.Point(303, 2)
        Me.txtRFC.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRFC.CustomButton.Name = ""
        Me.txtRFC.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtRFC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtRFC.CustomButton.TabIndex = 1
        Me.txtRFC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtRFC.CustomButton.UseSelectable = true
        Me.txtRFC.CustomButton.Visible = false
        Me.txtRFC.Lines = New String(-1) {}
        Me.txtRFC.Location = New System.Drawing.Point(419, 220)
        Me.txtRFC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRFC.MaxLength = 32767
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRFC.PromptText = "RFC"
        Me.txtRFC.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRFC.SelectedText = ""
        Me.txtRFC.SelectionLength = 0
        Me.txtRFC.SelectionStart = 0
        Me.txtRFC.ShortcutsEnabled = true
        Me.txtRFC.Size = New System.Drawing.Size(253, 28)
        Me.txtRFC.TabIndex = 79
        Me.txtRFC.UseSelectable = true
        Me.txtRFC.WaterMark = "RFC"
        Me.txtRFC.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtRFC.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtTelFijo
        '
        Me.txtTelFijo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtTelFijo.CustomButton.Image = Nothing
        Me.txtTelFijo.CustomButton.Location = New System.Drawing.Point(303, 2)
        Me.txtTelFijo.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTelFijo.CustomButton.Name = ""
        Me.txtTelFijo.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtTelFijo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTelFijo.CustomButton.TabIndex = 1
        Me.txtTelFijo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTelFijo.CustomButton.UseSelectable = true
        Me.txtTelFijo.CustomButton.Visible = false
        Me.txtTelFijo.Lines = New String(-1) {}
        Me.txtTelFijo.Location = New System.Drawing.Point(31, 256)
        Me.txtTelFijo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTelFijo.MaxLength = 32767
        Me.txtTelFijo.Name = "txtTelFijo"
        Me.txtTelFijo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelFijo.PromptText = "Teléfono Fijo"
        Me.txtTelFijo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTelFijo.SelectedText = ""
        Me.txtTelFijo.SelectionLength = 0
        Me.txtTelFijo.SelectionStart = 0
        Me.txtTelFijo.ShortcutsEnabled = true
        Me.txtTelFijo.Size = New System.Drawing.Size(253, 28)
        Me.txtTelFijo.TabIndex = 80
        Me.txtTelFijo.UseSelectable = true
        Me.txtTelFijo.WaterMark = "Teléfono Fijo"
        Me.txtTelFijo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtTelFijo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtMovil
        '
        Me.txtMovil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtMovil.CustomButton.Image = Nothing
        Me.txtMovil.CustomButton.Location = New System.Drawing.Point(303, 2)
        Me.txtMovil.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMovil.CustomButton.Name = ""
        Me.txtMovil.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtMovil.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMovil.CustomButton.TabIndex = 1
        Me.txtMovil.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMovil.CustomButton.UseSelectable = true
        Me.txtMovil.CustomButton.Visible = false
        Me.txtMovil.Lines = New String(-1) {}
        Me.txtMovil.Location = New System.Drawing.Point(419, 256)
        Me.txtMovil.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMovil.MaxLength = 32767
        Me.txtMovil.Name = "txtMovil"
        Me.txtMovil.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMovil.PromptText = "Celular"
        Me.txtMovil.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMovil.SelectedText = ""
        Me.txtMovil.SelectionLength = 0
        Me.txtMovil.SelectionStart = 0
        Me.txtMovil.ShortcutsEnabled = true
        Me.txtMovil.Size = New System.Drawing.Size(253, 28)
        Me.txtMovil.TabIndex = 81
        Me.txtMovil.UseSelectable = true
        Me.txtMovil.WaterMark = "Celular"
        Me.txtMovil.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtMovil.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtEmail.CustomButton.Image = Nothing
        Me.txtEmail.CustomButton.Location = New System.Drawing.Point(820, 2)
        Me.txtEmail.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmail.CustomButton.Name = ""
        Me.txtEmail.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmail.CustomButton.TabIndex = 1
        Me.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmail.CustomButton.UseSelectable = true
        Me.txtEmail.CustomButton.Visible = false
        Me.txtEmail.Lines = New String(-1) {}
        Me.txtEmail.Location = New System.Drawing.Point(31, 292)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmail.MaxLength = 32767
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PromptText = "Correo Electrónico"
        Me.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.SelectionLength = 0
        Me.txtEmail.SelectionStart = 0
        Me.txtEmail.ShortcutsEnabled = true
        Me.txtEmail.Size = New System.Drawing.Size(641, 28)
        Me.txtEmail.TabIndex = 82
        Me.txtEmail.UseSelectable = true
        Me.txtEmail.WaterMark = "Correo Electrónico"
        Me.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtContacto
        '
        Me.txtContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtContacto.CustomButton.Image = Nothing
        Me.txtContacto.CustomButton.Location = New System.Drawing.Point(820, 2)
        Me.txtContacto.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtContacto.CustomButton.Name = ""
        Me.txtContacto.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtContacto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtContacto.CustomButton.TabIndex = 1
        Me.txtContacto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtContacto.CustomButton.UseSelectable = true
        Me.txtContacto.CustomButton.Visible = false
        Me.txtContacto.Lines = New String(-1) {}
        Me.txtContacto.Location = New System.Drawing.Point(31, 327)
        Me.txtContacto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtContacto.MaxLength = 32767
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContacto.PromptText = "Persona de Contacto"
        Me.txtContacto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtContacto.SelectedText = ""
        Me.txtContacto.SelectionLength = 0
        Me.txtContacto.SelectionStart = 0
        Me.txtContacto.ShortcutsEnabled = true
        Me.txtContacto.Size = New System.Drawing.Size(641, 28)
        Me.txtContacto.TabIndex = 83
        Me.txtContacto.UseSelectable = true
        Me.txtContacto.WaterMark = "Persona de Contacto"
        Me.txtContacto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtContacto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtObs
        '
        Me.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtObs.CustomButton.Image = Nothing
        Me.txtObs.CustomButton.Location = New System.Drawing.Point(596, 2)
        Me.txtObs.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtObs.CustomButton.Name = ""
        Me.txtObs.CustomButton.Size = New System.Drawing.Size(255, 235)
        Me.txtObs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtObs.CustomButton.TabIndex = 1
        Me.txtObs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtObs.CustomButton.UseSelectable = true
        Me.txtObs.CustomButton.Visible = false
        Me.txtObs.Lines = New String(-1) {}
        Me.txtObs.Location = New System.Drawing.Point(31, 363)
        Me.txtObs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtObs.MaxLength = 32767
        Me.txtObs.Multiline = true
        Me.txtObs.Name = "txtObs"
        Me.txtObs.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtObs.PromptText = "Observaciones"
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtObs.SelectedText = ""
        Me.txtObs.SelectionLength = 0
        Me.txtObs.SelectionStart = 0
        Me.txtObs.ShortcutsEnabled = true
        Me.txtObs.Size = New System.Drawing.Size(641, 196)
        Me.txtObs.TabIndex = 84
        Me.txtObs.UseSelectable = true
        Me.txtObs.WaterMark = "Observaciones"
        Me.txtObs.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtObs.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.close_window_16px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(572, 569)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 87
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = true
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47,Byte),Integer), CType(CType(170,Byte),Integer), CType(CType(141,Byte),Integer))
        Me.btnSave.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.save_16px
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(31, 569)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 28)
        Me.btnSave.TabIndex = 88
        Me.btnSave.Text = "Guardar"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.UseVisualStyleBackColor = true
        '
        'FrmProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(705, 625)
        Me.ControlBox = false
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Button1)
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
        Me.KeyPreview = true
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = false
        Me.Name = "FrmProveedor"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Text = "Datos del Proveedor"
        Me.ResumeLayout(false)

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
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSave As Button
End Class
