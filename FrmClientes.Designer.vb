<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientes
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
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.txtEmail = New MetroFramework.Controls.MetroTextBox()
        Me.txtMovil = New MetroFramework.Controls.MetroTextBox()
        Me.txtTelFijo = New MetroFramework.Controls.MetroTextBox()
        Me.txtRFC = New MetroFramework.Controls.MetroTextBox()
        Me.txtCodigoPostal = New MetroFramework.Controls.MetroTextBox()
        Me.txtEstado = New MetroFramework.Controls.MetroTextBox()
        Me.txtCiudad = New MetroFramework.Controls.MetroTextBox()
        Me.txtColonia = New MetroFramework.Controls.MetroTextBox()
        Me.txtNumExterno = New MetroFramework.Controls.MetroTextBox()
        Me.txtDomicilio = New MetroFramework.Controls.MetroTextBox()
        Me.txtAmat = New MetroFramework.Controls.MetroTextBox()
        Me.txtApat = New MetroFramework.Controls.MetroTextBox()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.CmbPrecio = New MetroFramework.Controls.MetroComboBox()
        Me.txtLimite = New MetroFramework.Controls.MetroTextBox()
        Me.txtCredito = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.ChkTasaCero = New MetroFramework.Controls.MetroCheckBox()
        Me.cmbUsoCFDI = New MetroFramework.Controls.MetroComboBox()
        Me.cmbMetodoPago = New MetroFramework.Controls.MetroComboBox()
        Me.cmbFormaPago = New MetroFramework.Controls.MetroComboBox()
        Me.txtCuenta = New MetroFramework.Controls.MetroTextBox()
        Me.CmbCredito = New MetroFramework.Controls.MetroComboBox()
        Me.CmbBanco = New MetroFramework.Controls.MetroComboBox()
        Me.CmbTipo = New MetroFramework.Controls.MetroComboBox()
        Me.MetroTabPage4 = New MetroFramework.Controls.MetroTabPage()
        Me.txtObs = New MetroFramework.Controls.MetroTextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MetroTabControl1.SuspendLayout
        Me.MetroTabPage1.SuspendLayout
        Me.MetroTabPage2.SuspendLayout
        Me.MetroTabPage3.SuspendLayout
        Me.MetroTabPage4.SuspendLayout
        Me.SuspendLayout
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage4)
        Me.MetroTabControl1.Location = New System.Drawing.Point(31, 78)
        Me.MetroTabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(668, 420)
        Me.MetroTabControl1.TabIndex = 73
        Me.MetroTabControl1.UseSelectable = true
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.txtEmail)
        Me.MetroTabPage1.Controls.Add(Me.txtMovil)
        Me.MetroTabPage1.Controls.Add(Me.txtTelFijo)
        Me.MetroTabPage1.Controls.Add(Me.txtRFC)
        Me.MetroTabPage1.Controls.Add(Me.txtCodigoPostal)
        Me.MetroTabPage1.Controls.Add(Me.txtEstado)
        Me.MetroTabPage1.Controls.Add(Me.txtCiudad)
        Me.MetroTabPage1.Controls.Add(Me.txtColonia)
        Me.MetroTabPage1.Controls.Add(Me.txtNumExterno)
        Me.MetroTabPage1.Controls.Add(Me.txtDomicilio)
        Me.MetroTabPage1.Controls.Add(Me.txtAmat)
        Me.MetroTabPage1.Controls.Add(Me.txtApat)
        Me.MetroTabPage1.Controls.Add(Me.txtNombre)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = true
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = false
        Me.MetroTabPage1.HorizontalScrollbarSize = 12
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(660, 378)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Datos Generales"
        Me.MetroTabPage1.VerticalScrollbarBarColor = true
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = false
        Me.MetroTabPage1.VerticalScrollbarSize = 13
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtEmail.CustomButton.Image = Nothing
        Me.txtEmail.CustomButton.Location = New System.Drawing.Point(621, 2)
        Me.txtEmail.CustomButton.Margin = New System.Windows.Forms.Padding(5)
        Me.txtEmail.CustomButton.Name = ""
        Me.txtEmail.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmail.CustomButton.TabIndex = 1
        Me.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmail.CustomButton.UseSelectable = true
        Me.txtEmail.CustomButton.Visible = false
        Me.txtEmail.Lines = New String(-1) {}
        Me.txtEmail.Location = New System.Drawing.Point(4, 322)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.MaxLength = 32767
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PromptText = "Correo Electrónico"
        Me.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.SelectionLength = 0
        Me.txtEmail.SelectionStart = 0
        Me.txtEmail.ShortcutsEnabled = true
        Me.txtEmail.Size = New System.Drawing.Size(647, 28)
        Me.txtEmail.TabIndex = 14
        Me.txtEmail.UseSelectable = true
        Me.txtEmail.WaterMark = "Correo Electrónico"
        Me.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtMovil
        '
        Me.txtMovil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtMovil.CustomButton.Image = Nothing
        Me.txtMovil.CustomButton.Location = New System.Drawing.Point(227, 2)
        Me.txtMovil.CustomButton.Margin = New System.Windows.Forms.Padding(5)
        Me.txtMovil.CustomButton.Name = ""
        Me.txtMovil.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtMovil.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMovil.CustomButton.TabIndex = 1
        Me.txtMovil.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMovil.CustomButton.UseSelectable = true
        Me.txtMovil.CustomButton.Visible = false
        Me.txtMovil.Lines = New String(-1) {}
        Me.txtMovil.Location = New System.Drawing.Point(393, 283)
        Me.txtMovil.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMovil.MaxLength = 32767
        Me.txtMovil.Name = "txtMovil"
        Me.txtMovil.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMovil.PromptText = "Celular"
        Me.txtMovil.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMovil.SelectedText = ""
        Me.txtMovil.SelectionLength = 0
        Me.txtMovil.SelectionStart = 0
        Me.txtMovil.ShortcutsEnabled = true
        Me.txtMovil.Size = New System.Drawing.Size(257, 32)
        Me.txtMovil.TabIndex = 13
        Me.txtMovil.UseSelectable = true
        Me.txtMovil.WaterMark = "Celular"
        Me.txtMovil.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtMovil.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtTelFijo
        '
        Me.txtTelFijo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtTelFijo.CustomButton.Image = Nothing
        Me.txtTelFijo.CustomButton.Location = New System.Drawing.Point(223, 2)
        Me.txtTelFijo.CustomButton.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTelFijo.CustomButton.Name = ""
        Me.txtTelFijo.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtTelFijo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTelFijo.CustomButton.TabIndex = 1
        Me.txtTelFijo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTelFijo.CustomButton.UseSelectable = true
        Me.txtTelFijo.CustomButton.Visible = false
        Me.txtTelFijo.Lines = New String(-1) {}
        Me.txtTelFijo.Location = New System.Drawing.Point(4, 283)
        Me.txtTelFijo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelFijo.MaxLength = 32767
        Me.txtTelFijo.Name = "txtTelFijo"
        Me.txtTelFijo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelFijo.PromptText = "Teléfono"
        Me.txtTelFijo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTelFijo.SelectedText = ""
        Me.txtTelFijo.SelectionLength = 0
        Me.txtTelFijo.SelectionStart = 0
        Me.txtTelFijo.ShortcutsEnabled = true
        Me.txtTelFijo.Size = New System.Drawing.Size(253, 32)
        Me.txtTelFijo.TabIndex = 12
        Me.txtTelFijo.UseSelectable = true
        Me.txtTelFijo.WaterMark = "Teléfono"
        Me.txtTelFijo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtTelFijo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtRFC
        '
        Me.txtRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtRFC.CustomButton.Image = Nothing
        Me.txtRFC.CustomButton.Location = New System.Drawing.Point(227, 2)
        Me.txtRFC.CustomButton.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRFC.CustomButton.Name = ""
        Me.txtRFC.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtRFC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtRFC.CustomButton.TabIndex = 1
        Me.txtRFC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtRFC.CustomButton.UseSelectable = true
        Me.txtRFC.CustomButton.Visible = false
        Me.txtRFC.Lines = New String(-1) {}
        Me.txtRFC.Location = New System.Drawing.Point(393, 244)
        Me.txtRFC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRFC.MaxLength = 32767
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRFC.PromptText = "R.F.C."
        Me.txtRFC.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRFC.SelectedText = ""
        Me.txtRFC.SelectionLength = 0
        Me.txtRFC.SelectionStart = 0
        Me.txtRFC.ShortcutsEnabled = true
        Me.txtRFC.Size = New System.Drawing.Size(257, 32)
        Me.txtRFC.TabIndex = 11
        Me.txtRFC.UseSelectable = true
        Me.txtRFC.WaterMark = "R.F.C."
        Me.txtRFC.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtRFC.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtCodigoPostal.CustomButton.Image = Nothing
        Me.txtCodigoPostal.CustomButton.Location = New System.Drawing.Point(223, 2)
        Me.txtCodigoPostal.CustomButton.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCodigoPostal.CustomButton.Name = ""
        Me.txtCodigoPostal.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtCodigoPostal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCodigoPostal.CustomButton.TabIndex = 1
        Me.txtCodigoPostal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCodigoPostal.CustomButton.UseSelectable = true
        Me.txtCodigoPostal.CustomButton.Visible = false
        Me.txtCodigoPostal.Lines = New String(-1) {}
        Me.txtCodigoPostal.Location = New System.Drawing.Point(4, 244)
        Me.txtCodigoPostal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigoPostal.MaxLength = 32767
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodigoPostal.PromptText = "Código Postal"
        Me.txtCodigoPostal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCodigoPostal.SelectedText = ""
        Me.txtCodigoPostal.SelectionLength = 0
        Me.txtCodigoPostal.SelectionStart = 0
        Me.txtCodigoPostal.ShortcutsEnabled = true
        Me.txtCodigoPostal.Size = New System.Drawing.Size(253, 32)
        Me.txtCodigoPostal.TabIndex = 10
        Me.txtCodigoPostal.UseSelectable = true
        Me.txtCodigoPostal.WaterMark = "Código Postal"
        Me.txtCodigoPostal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtCodigoPostal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtEstado
        '
        Me.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtEstado.CustomButton.Image = Nothing
        Me.txtEstado.CustomButton.Location = New System.Drawing.Point(227, 2)
        Me.txtEstado.CustomButton.Margin = New System.Windows.Forms.Padding(5)
        Me.txtEstado.CustomButton.Name = ""
        Me.txtEstado.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtEstado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEstado.CustomButton.TabIndex = 1
        Me.txtEstado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEstado.CustomButton.UseSelectable = true
        Me.txtEstado.CustomButton.Visible = false
        Me.txtEstado.Lines = New String(-1) {}
        Me.txtEstado.Location = New System.Drawing.Point(393, 204)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEstado.MaxLength = 32767
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEstado.PromptText = "Estado"
        Me.txtEstado.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEstado.SelectedText = ""
        Me.txtEstado.SelectionLength = 0
        Me.txtEstado.SelectionStart = 0
        Me.txtEstado.ShortcutsEnabled = true
        Me.txtEstado.Size = New System.Drawing.Size(257, 32)
        Me.txtEstado.TabIndex = 9
        Me.txtEstado.UseSelectable = true
        Me.txtEstado.WaterMark = "Estado"
        Me.txtEstado.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtEstado.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCiudad
        '
        Me.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtCiudad.CustomButton.Image = Nothing
        Me.txtCiudad.CustomButton.Location = New System.Drawing.Point(223, 2)
        Me.txtCiudad.CustomButton.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCiudad.CustomButton.Name = ""
        Me.txtCiudad.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtCiudad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCiudad.CustomButton.TabIndex = 1
        Me.txtCiudad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCiudad.CustomButton.UseSelectable = true
        Me.txtCiudad.CustomButton.Visible = false
        Me.txtCiudad.Lines = New String(-1) {}
        Me.txtCiudad.Location = New System.Drawing.Point(4, 204)
        Me.txtCiudad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCiudad.MaxLength = 32767
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCiudad.PromptText = "Ciudad"
        Me.txtCiudad.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCiudad.SelectedText = ""
        Me.txtCiudad.SelectionLength = 0
        Me.txtCiudad.SelectionStart = 0
        Me.txtCiudad.ShortcutsEnabled = true
        Me.txtCiudad.Size = New System.Drawing.Size(253, 32)
        Me.txtCiudad.TabIndex = 8
        Me.txtCiudad.UseSelectable = true
        Me.txtCiudad.WaterMark = "Ciudad"
        Me.txtCiudad.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtCiudad.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtColonia
        '
        Me.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtColonia.CustomButton.Image = Nothing
        Me.txtColonia.CustomButton.Location = New System.Drawing.Point(406, 2)
        Me.txtColonia.CustomButton.Margin = New System.Windows.Forms.Padding(5)
        Me.txtColonia.CustomButton.Name = ""
        Me.txtColonia.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtColonia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtColonia.CustomButton.TabIndex = 1
        Me.txtColonia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtColonia.CustomButton.UseSelectable = true
        Me.txtColonia.CustomButton.Visible = false
        Me.txtColonia.Lines = New String(-1) {}
        Me.txtColonia.Location = New System.Drawing.Point(215, 165)
        Me.txtColonia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtColonia.MaxLength = 32767
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtColonia.PromptText = "Colonia"
        Me.txtColonia.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtColonia.SelectedText = ""
        Me.txtColonia.SelectionLength = 0
        Me.txtColonia.SelectionStart = 0
        Me.txtColonia.ShortcutsEnabled = true
        Me.txtColonia.Size = New System.Drawing.Size(436, 32)
        Me.txtColonia.TabIndex = 7
        Me.txtColonia.UseSelectable = true
        Me.txtColonia.WaterMark = "Colonia"
        Me.txtColonia.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtColonia.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNumExterno
        '
        Me.txtNumExterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtNumExterno.CustomButton.Image = Nothing
        Me.txtNumExterno.CustomButton.Location = New System.Drawing.Point(63, 2)
        Me.txtNumExterno.CustomButton.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNumExterno.CustomButton.Name = ""
        Me.txtNumExterno.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtNumExterno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNumExterno.CustomButton.TabIndex = 1
        Me.txtNumExterno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNumExterno.CustomButton.UseSelectable = true
        Me.txtNumExterno.CustomButton.Visible = false
        Me.txtNumExterno.Lines = New String(-1) {}
        Me.txtNumExterno.Location = New System.Drawing.Point(4, 165)
        Me.txtNumExterno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumExterno.MaxLength = 32767
        Me.txtNumExterno.Name = "txtNumExterno"
        Me.txtNumExterno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumExterno.PromptText = "No.Ext"
        Me.txtNumExterno.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumExterno.SelectedText = ""
        Me.txtNumExterno.SelectionLength = 0
        Me.txtNumExterno.SelectionStart = 0
        Me.txtNumExterno.ShortcutsEnabled = true
        Me.txtNumExterno.Size = New System.Drawing.Size(93, 32)
        Me.txtNumExterno.TabIndex = 6
        Me.txtNumExterno.UseSelectable = true
        Me.txtNumExterno.WaterMark = "No.Ext"
        Me.txtNumExterno.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtNumExterno.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDomicilio
        '
        Me.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtDomicilio.CustomButton.Image = Nothing
        Me.txtDomicilio.CustomButton.Location = New System.Drawing.Point(621, 2)
        Me.txtDomicilio.CustomButton.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDomicilio.CustomButton.Name = ""
        Me.txtDomicilio.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtDomicilio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDomicilio.CustomButton.TabIndex = 1
        Me.txtDomicilio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDomicilio.CustomButton.UseSelectable = true
        Me.txtDomicilio.CustomButton.Visible = false
        Me.txtDomicilio.Lines = New String(-1) {}
        Me.txtDomicilio.Location = New System.Drawing.Point(4, 129)
        Me.txtDomicilio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDomicilio.MaxLength = 32767
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDomicilio.PromptText = "Calle"
        Me.txtDomicilio.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDomicilio.SelectedText = ""
        Me.txtDomicilio.SelectionLength = 0
        Me.txtDomicilio.SelectionStart = 0
        Me.txtDomicilio.ShortcutsEnabled = true
        Me.txtDomicilio.Size = New System.Drawing.Size(647, 28)
        Me.txtDomicilio.TabIndex = 5
        Me.txtDomicilio.UseSelectable = true
        Me.txtDomicilio.WaterMark = "Calle"
        Me.txtDomicilio.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtDomicilio.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtAmat
        '
        Me.txtAmat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtAmat.CustomButton.Image = Nothing
        Me.txtAmat.CustomButton.Location = New System.Drawing.Point(621, 2)
        Me.txtAmat.CustomButton.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAmat.CustomButton.Name = ""
        Me.txtAmat.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtAmat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAmat.CustomButton.TabIndex = 1
        Me.txtAmat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAmat.CustomButton.UseSelectable = true
        Me.txtAmat.CustomButton.Visible = false
        Me.txtAmat.Lines = New String(-1) {}
        Me.txtAmat.Location = New System.Drawing.Point(4, 94)
        Me.txtAmat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmat.MaxLength = 32767
        Me.txtAmat.Name = "txtAmat"
        Me.txtAmat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAmat.PromptText = "Apellido Materno"
        Me.txtAmat.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAmat.SelectedText = ""
        Me.txtAmat.SelectionLength = 0
        Me.txtAmat.SelectionStart = 0
        Me.txtAmat.ShortcutsEnabled = true
        Me.txtAmat.Size = New System.Drawing.Size(647, 28)
        Me.txtAmat.TabIndex = 4
        Me.txtAmat.UseSelectable = true
        Me.txtAmat.WaterMark = "Apellido Materno"
        Me.txtAmat.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtAmat.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtApat
        '
        Me.txtApat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtApat.CustomButton.Image = Nothing
        Me.txtApat.CustomButton.Location = New System.Drawing.Point(621, 2)
        Me.txtApat.CustomButton.Margin = New System.Windows.Forms.Padding(5)
        Me.txtApat.CustomButton.Name = ""
        Me.txtApat.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtApat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtApat.CustomButton.TabIndex = 1
        Me.txtApat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtApat.CustomButton.UseSelectable = true
        Me.txtApat.CustomButton.Visible = false
        Me.txtApat.Lines = New String(-1) {}
        Me.txtApat.Location = New System.Drawing.Point(4, 58)
        Me.txtApat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApat.MaxLength = 32767
        Me.txtApat.Name = "txtApat"
        Me.txtApat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtApat.PromptText = "Apellido Paterno"
        Me.txtApat.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtApat.SelectedText = ""
        Me.txtApat.SelectionLength = 0
        Me.txtApat.SelectionStart = 0
        Me.txtApat.ShortcutsEnabled = true
        Me.txtApat.Size = New System.Drawing.Size(647, 28)
        Me.txtApat.TabIndex = 3
        Me.txtApat.UseSelectable = true
        Me.txtApat.WaterMark = "Apellido Paterno"
        Me.txtApat.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtApat.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtNombre.CustomButton.Image = Nothing
        Me.txtNombre.CustomButton.Location = New System.Drawing.Point(621, 2)
        Me.txtNombre.CustomButton.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNombre.CustomButton.Name = ""
        Me.txtNombre.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNombre.CustomButton.TabIndex = 1
        Me.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNombre.CustomButton.UseSelectable = true
        Me.txtNombre.CustomButton.Visible = false
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(4, 22)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.PromptText = "Nombre"
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.SelectionLength = 0
        Me.txtNombre.SelectionStart = 0
        Me.txtNombre.ShortcutsEnabled = true
        Me.txtNombre.Size = New System.Drawing.Size(647, 28)
        Me.txtNombre.TabIndex = 2
        Me.txtNombre.UseSelectable = true
        Me.txtNombre.WaterMark = "Nombre"
        Me.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtNombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.CmbPrecio)
        Me.MetroTabPage2.Controls.Add(Me.txtLimite)
        Me.MetroTabPage2.Controls.Add(Me.txtCredito)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = true
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = false
        Me.MetroTabPage2.HorizontalScrollbarSize = 12
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(660, 378)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Condiciones de Pago"
        Me.MetroTabPage2.VerticalScrollbarBarColor = true
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = false
        Me.MetroTabPage2.VerticalScrollbarSize = 13
        '
        'CmbPrecio
        '
        Me.CmbPrecio.FormattingEnabled = true
        Me.CmbPrecio.ItemHeight = 23
        Me.CmbPrecio.Items.AddRange(New Object() {"Precio Público", "Precio P1", "Precio P2", "Precio P3"})
        Me.CmbPrecio.Location = New System.Drawing.Point(4, 102)
        Me.CmbPrecio.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbPrecio.Name = "CmbPrecio"
        Me.CmbPrecio.PromptText = "Lista de Precios"
        Me.CmbPrecio.Size = New System.Drawing.Size(255, 29)
        Me.CmbPrecio.TabIndex = 9
        Me.CmbPrecio.UseSelectable = true
        '
        'txtLimite
        '
        Me.txtLimite.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtLimite.CustomButton.Image = Nothing
        Me.txtLimite.CustomButton.Location = New System.Drawing.Point(119, 2)
        Me.txtLimite.CustomButton.Margin = New System.Windows.Forms.Padding(5)
        Me.txtLimite.CustomButton.Name = ""
        Me.txtLimite.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtLimite.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLimite.CustomButton.TabIndex = 1
        Me.txtLimite.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLimite.CustomButton.UseSelectable = true
        Me.txtLimite.CustomButton.Visible = false
        Me.txtLimite.Lines = New String(-1) {}
        Me.txtLimite.Location = New System.Drawing.Point(4, 63)
        Me.txtLimite.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLimite.MaxLength = 32767
        Me.txtLimite.Name = "txtLimite"
        Me.txtLimite.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLimite.PromptText = "Límite de Crédito"
        Me.txtLimite.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLimite.SelectedText = ""
        Me.txtLimite.SelectionLength = 0
        Me.txtLimite.SelectionStart = 0
        Me.txtLimite.ShortcutsEnabled = true
        Me.txtLimite.Size = New System.Drawing.Size(149, 32)
        Me.txtLimite.TabIndex = 8
        Me.txtLimite.UseSelectable = true
        Me.txtLimite.WaterMark = "Límite de Crédito"
        Me.txtLimite.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtLimite.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCredito
        '
        Me.txtCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtCredito.CustomButton.Image = Nothing
        Me.txtCredito.CustomButton.Location = New System.Drawing.Point(119, 2)
        Me.txtCredito.CustomButton.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCredito.CustomButton.Name = ""
        Me.txtCredito.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtCredito.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCredito.CustomButton.TabIndex = 1
        Me.txtCredito.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCredito.CustomButton.UseSelectable = true
        Me.txtCredito.CustomButton.Visible = false
        Me.txtCredito.Lines = New String(-1) {}
        Me.txtCredito.Location = New System.Drawing.Point(4, 23)
        Me.txtCredito.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCredito.MaxLength = 32767
        Me.txtCredito.Name = "txtCredito"
        Me.txtCredito.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCredito.PromptText = "Días de Crédito"
        Me.txtCredito.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCredito.SelectedText = ""
        Me.txtCredito.SelectionLength = 0
        Me.txtCredito.SelectionStart = 0
        Me.txtCredito.ShortcutsEnabled = true
        Me.txtCredito.Size = New System.Drawing.Size(149, 32)
        Me.txtCredito.TabIndex = 7
        Me.txtCredito.UseSelectable = true
        Me.txtCredito.WaterMark = "Días de Crédito"
        Me.txtCredito.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtCredito.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.Controls.Add(Me.ChkTasaCero)
        Me.MetroTabPage3.Controls.Add(Me.cmbUsoCFDI)
        Me.MetroTabPage3.Controls.Add(Me.cmbMetodoPago)
        Me.MetroTabPage3.Controls.Add(Me.cmbFormaPago)
        Me.MetroTabPage3.Controls.Add(Me.txtCuenta)
        Me.MetroTabPage3.Controls.Add(Me.CmbCredito)
        Me.MetroTabPage3.Controls.Add(Me.CmbBanco)
        Me.MetroTabPage3.Controls.Add(Me.CmbTipo)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = true
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = false
        Me.MetroTabPage3.HorizontalScrollbarSize = 12
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(660, 378)
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "Facturación"
        Me.MetroTabPage3.VerticalScrollbarBarColor = true
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = false
        Me.MetroTabPage3.VerticalScrollbarSize = 13
        '
        'ChkTasaCero
        '
        Me.ChkTasaCero.AutoSize = true
        Me.ChkTasaCero.Location = New System.Drawing.Point(511, 20)
        Me.ChkTasaCero.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkTasaCero.Name = "ChkTasaCero"
        Me.ChkTasaCero.Size = New System.Drawing.Size(118, 17)
        Me.ChkTasaCero.TabIndex = 9
        Me.ChkTasaCero.Text = "Factura Tasa 0%"
        Me.ChkTasaCero.UseSelectable = true
        '
        'cmbUsoCFDI
        '
        Me.cmbUsoCFDI.FormattingEnabled = true
        Me.cmbUsoCFDI.ItemHeight = 23
        Me.cmbUsoCFDI.Items.AddRange(New Object() {"G01-Adquisición de mercancías", "G02-Devoluciones, descuentos o bonificaciones", "G03-Gastos en general", "I01-Construcciones", "I02-Mobiliario y equipo de oficina por inversiones", "I03-Equipo de transporte", "I04-Equipo de cómputo y accesorios", "I05-Dados, troqueles, moldes, matrices y herramental", "I06-Comunicaciones telefónicas", "I07-Comunicaciones satelitales", "I08-Otra maquinaria y equipo", "D01-Honorarios médicos, dentales y gastos hospitalarios", "D02-Gastos médicos por incapacidad o discapacidad", "D03-Gastos funerales", "D04-Donativos", "D05-Intereses reales efectivamente pagados por créditos hipotecarios (casa habita"& _ 
                "ción)", "D06-Aportaciones voluntarias al SAR", "D07-Primas por seguros de gastos médicos", "D08-Gastos de transportación escolar obligatoria", "D09-Depósito de cuentas para el ahorro, primas que tengan como planes de pensione"& _ 
                "s", "D10-Pagos por servicios educativos (colegiaturas)", "P01-Por definir"})
        Me.cmbUsoCFDI.Location = New System.Drawing.Point(4, 311)
        Me.cmbUsoCFDI.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbUsoCFDI.Name = "cmbUsoCFDI"
        Me.cmbUsoCFDI.PromptText = "Uso del CFDI"
        Me.cmbUsoCFDI.Size = New System.Drawing.Size(648, 29)
        Me.cmbUsoCFDI.TabIndex = 8
        Me.cmbUsoCFDI.UseSelectable = true
        '
        'cmbMetodoPago
        '
        Me.cmbMetodoPago.FormattingEnabled = true
        Me.cmbMetodoPago.ItemHeight = 23
        Me.cmbMetodoPago.Items.AddRange(New Object() {"PUE-Pago en una sola exhibición", "PPD-Pago en parcialidades o diferido"})
        Me.cmbMetodoPago.Location = New System.Drawing.Point(4, 266)
        Me.cmbMetodoPago.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMetodoPago.Name = "cmbMetodoPago"
        Me.cmbMetodoPago.PromptText = "Método de Pago"
        Me.cmbMetodoPago.Size = New System.Drawing.Size(648, 29)
        Me.cmbMetodoPago.TabIndex = 7
        Me.cmbMetodoPago.UseSelectable = true
        '
        'cmbFormaPago
        '
        Me.cmbFormaPago.FormattingEnabled = true
        Me.cmbFormaPago.ItemHeight = 23
        Me.cmbFormaPago.Items.AddRange(New Object() {"01-Efectivo", "02-Cheque normativo", "03-Transferencia electrónica de fondos", "04-Tarjeta de crédito", "05-Monedero electrónico", "06-Dinero electrónico", "08-Vales de despensa", "12-Dación de pago", "13-Pago por subrogación", "14-Pago por consignación", "15-Condonación", "17-Compensación", "23-Novación", "24-Confusión", "25- Remisión de deuda", "26-Prescripción o caducidad", "27-A satisfación del acreedor", "28-Tarjeta de débito", "29-Tarjeta de servicios", "30-Aplicación de anticipos", "99-Por definir"})
        Me.cmbFormaPago.Location = New System.Drawing.Point(4, 223)
        Me.cmbFormaPago.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbFormaPago.Name = "cmbFormaPago"
        Me.cmbFormaPago.PromptText = "Forma de Pago"
        Me.cmbFormaPago.Size = New System.Drawing.Size(648, 29)
        Me.cmbFormaPago.TabIndex = 6
        Me.cmbFormaPago.UseSelectable = true
        '
        'txtCuenta
        '
        Me.txtCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtCuenta.CustomButton.Image = Nothing
        Me.txtCuenta.CustomButton.Location = New System.Drawing.Point(74, 2)
        Me.txtCuenta.CustomButton.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCuenta.CustomButton.Name = ""
        Me.txtCuenta.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtCuenta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCuenta.CustomButton.TabIndex = 1
        Me.txtCuenta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCuenta.CustomButton.UseSelectable = true
        Me.txtCuenta.CustomButton.Visible = false
        Me.txtCuenta.Lines = New String(-1) {}
        Me.txtCuenta.Location = New System.Drawing.Point(267, 68)
        Me.txtCuenta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCuenta.MaxLength = 32767
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCuenta.PromptText = "Cuenta"
        Me.txtCuenta.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCuenta.SelectedText = ""
        Me.txtCuenta.SelectionLength = 0
        Me.txtCuenta.SelectionStart = 0
        Me.txtCuenta.ShortcutsEnabled = true
        Me.txtCuenta.Size = New System.Drawing.Size(100, 28)
        Me.txtCuenta.TabIndex = 5
        Me.txtCuenta.UseSelectable = true
        Me.txtCuenta.WaterMark = "Cuenta"
        Me.txtCuenta.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtCuenta.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'CmbCredito
        '
        Me.CmbCredito.FormattingEnabled = true
        Me.CmbCredito.ItemHeight = 23
        Me.CmbCredito.Items.AddRange(New Object() {"8 DIAS DE CREDITO", "15 DIAS DE CREDITO", "21 DIAS DE CREDITO", "30 DIAS DE CREDITO", "PAGO A LA ENTREGA"})
        Me.CmbCredito.Location = New System.Drawing.Point(4, 106)
        Me.CmbCredito.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbCredito.Name = "CmbCredito"
        Me.CmbCredito.PromptText = "Plazo"
        Me.CmbCredito.Size = New System.Drawing.Size(253, 29)
        Me.CmbCredito.TabIndex = 4
        Me.CmbCredito.UseSelectable = true
        '
        'CmbBanco
        '
        Me.CmbBanco.FormattingEnabled = true
        Me.CmbBanco.ItemHeight = 23
        Me.CmbBanco.Items.AddRange(New Object() {"BBVA Bancomer", "Banamex", "HSBC", "Scotia Bank", "Banco del Bajio", "Santander Serfin", "Inbursa", "Banorte"})
        Me.CmbBanco.Location = New System.Drawing.Point(4, 63)
        Me.CmbBanco.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbBanco.Name = "CmbBanco"
        Me.CmbBanco.PromptText = "Banco"
        Me.CmbBanco.Size = New System.Drawing.Size(253, 29)
        Me.CmbBanco.TabIndex = 3
        Me.CmbBanco.UseSelectable = true
        '
        'CmbTipo
        '
        Me.CmbTipo.FormattingEnabled = true
        Me.CmbTipo.ItemHeight = 23
        Me.CmbTipo.Items.AddRange(New Object() {"CREDITO", "CONTADO"})
        Me.CmbTipo.Location = New System.Drawing.Point(4, 20)
        Me.CmbTipo.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.PromptText = "Tipo de Pago"
        Me.CmbTipo.Size = New System.Drawing.Size(253, 29)
        Me.CmbTipo.TabIndex = 2
        Me.CmbTipo.UseSelectable = true
        '
        'MetroTabPage4
        '
        Me.MetroTabPage4.Controls.Add(Me.txtObs)
        Me.MetroTabPage4.HorizontalScrollbarBarColor = true
        Me.MetroTabPage4.HorizontalScrollbarHighlightOnWheel = false
        Me.MetroTabPage4.HorizontalScrollbarSize = 12
        Me.MetroTabPage4.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage4.Margin = New System.Windows.Forms.Padding(4)
        Me.MetroTabPage4.Name = "MetroTabPage4"
        Me.MetroTabPage4.Size = New System.Drawing.Size(660, 378)
        Me.MetroTabPage4.TabIndex = 3
        Me.MetroTabPage4.Text = "Observaciones"
        Me.MetroTabPage4.VerticalScrollbarBarColor = true
        Me.MetroTabPage4.VerticalScrollbarHighlightOnWheel = false
        Me.MetroTabPage4.VerticalScrollbarSize = 13
        '
        'txtObs
        '
        Me.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtObs.CustomButton.Image = Nothing
        Me.txtObs.CustomButton.Location = New System.Drawing.Point(293, 2)
        Me.txtObs.CustomButton.Margin = New System.Windows.Forms.Padding(5)
        Me.txtObs.CustomButton.Name = ""
        Me.txtObs.CustomButton.Size = New System.Drawing.Size(353, 353)
        Me.txtObs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtObs.CustomButton.TabIndex = 1
        Me.txtObs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtObs.CustomButton.UseSelectable = true
        Me.txtObs.CustomButton.Visible = false
        Me.txtObs.Lines = New String(-1) {}
        Me.txtObs.Location = New System.Drawing.Point(4, 4)
        Me.txtObs.Margin = New System.Windows.Forms.Padding(4)
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
        Me.txtObs.Size = New System.Drawing.Size(649, 358)
        Me.txtObs.TabIndex = 2
        Me.txtObs.UseSelectable = true
        Me.txtObs.WaterMark = "Observaciones"
        Me.txtObs.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtObs.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47,Byte),Integer), CType(CType(170,Byte),Integer), CType(CType(141,Byte),Integer))
        Me.btnSave.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.save_16px
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(39, 500)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 28)
        Me.btnSave.TabIndex = 78
        Me.btnSave.Text = "Guardar"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.UseVisualStyleBackColor = true
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.ForeColor = System.Drawing.Color.Red
        Me.btnEliminar.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.trash_can_16px
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.Location = New System.Drawing.Point(145, 500)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 28)
        Me.btnEliminar.TabIndex = 79
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.UseVisualStyleBackColor = true
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.close_window_16px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(585, 500)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 80
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = true
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(728, 569)
        Me.ControlBox = false
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = true
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = false
        Me.Name = "FrmClientes"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Text = "Datos del Cliente"
        Me.MetroTabControl1.ResumeLayout(false)
        Me.MetroTabPage1.ResumeLayout(false)
        Me.MetroTabPage2.ResumeLayout(false)
        Me.MetroTabPage3.ResumeLayout(false)
        Me.MetroTabPage3.PerformLayout
        Me.MetroTabPage4.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage4 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents txtEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMovil As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTelFijo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtRFC As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCodigoPostal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtEstado As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCiudad As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtColonia As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNumExterno As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDomicilio As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAmat As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtApat As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents CmbPrecio As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtLimite As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCredito As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCuenta As MetroFramework.Controls.MetroTextBox
    Friend WithEvents CmbCredito As MetroFramework.Controls.MetroComboBox
    Friend WithEvents CmbBanco As MetroFramework.Controls.MetroComboBox
    Friend WithEvents CmbTipo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbFormaPago As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbMetodoPago As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbUsoCFDI As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ChkTasaCero As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents txtObs As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Button1 As Button
End Class
