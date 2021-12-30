<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfiguracion
    'Inherits System.Windows.Forms.Form
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
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.txtDireccion = New MetroFramework.Controls.MetroTextBox()
        Me.txtPropietario = New MetroFramework.Controls.MetroTextBox()
        Me.txtRFC = New MetroFramework.Controls.MetroTextBox()
        Me.txtColonia = New MetroFramework.Controls.MetroTextBox()
        Me.txtCiudad = New MetroFramework.Controls.MetroTextBox()
        Me.txtTelefono = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.txtTickets = New MetroFramework.Controls.MetroTextBox()
        Me.txtFacturas = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.txtCajaChica = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtFactorIVA = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTile3 = New MetroFramework.Controls.MetroTile()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtNumFacturas = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtFolioFactura = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txtTipoCambio = New MetroFramework.Controls.MetroTextBox()
        Me.btnTecnoLite = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.btnSalir = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtNombre.CustomButton.Image = Nothing
        Me.txtNombre.CustomButton.Location = New System.Drawing.Point(495, 1)
        Me.txtNombre.CustomButton.Name = ""
        Me.txtNombre.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNombre.CustomButton.TabIndex = 1
        Me.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNombre.CustomButton.UseSelectable = True
        Me.txtNombre.CustomButton.Visible = False
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(31, 107)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.PromptText = "Nombre"
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.SelectionLength = 0
        Me.txtNombre.SelectionStart = 0
        Me.txtNombre.ShortcutsEnabled = True
        Me.txtNombre.Size = New System.Drawing.Size(517, 23)
        Me.txtNombre.TabIndex = 20
        Me.txtNombre.UseSelectable = True
        Me.txtNombre.WaterMark = "Nombre"
        Me.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDireccion
        '
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtDireccion.CustomButton.Image = Nothing
        Me.txtDireccion.CustomButton.Location = New System.Drawing.Point(495, 1)
        Me.txtDireccion.CustomButton.Name = ""
        Me.txtDireccion.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtDireccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDireccion.CustomButton.TabIndex = 1
        Me.txtDireccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDireccion.CustomButton.UseSelectable = True
        Me.txtDireccion.CustomButton.Visible = False
        Me.txtDireccion.Lines = New String(-1) {}
        Me.txtDireccion.Location = New System.Drawing.Point(31, 136)
        Me.txtDireccion.MaxLength = 32767
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDireccion.PromptText = "Calle y Número Exterior"
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDireccion.SelectedText = ""
        Me.txtDireccion.SelectionLength = 0
        Me.txtDireccion.SelectionStart = 0
        Me.txtDireccion.ShortcutsEnabled = True
        Me.txtDireccion.Size = New System.Drawing.Size(517, 23)
        Me.txtDireccion.TabIndex = 21
        Me.txtDireccion.UseSelectable = True
        Me.txtDireccion.WaterMark = "Calle y Número Exterior"
        Me.txtDireccion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDireccion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPropietario
        '
        Me.txtPropietario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtPropietario.CustomButton.Image = Nothing
        Me.txtPropietario.CustomButton.Location = New System.Drawing.Point(318, 1)
        Me.txtPropietario.CustomButton.Name = ""
        Me.txtPropietario.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPropietario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPropietario.CustomButton.TabIndex = 1
        Me.txtPropietario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPropietario.CustomButton.UseSelectable = True
        Me.txtPropietario.CustomButton.Visible = False
        Me.txtPropietario.Lines = New String(-1) {}
        Me.txtPropietario.Location = New System.Drawing.Point(31, 165)
        Me.txtPropietario.MaxLength = 32767
        Me.txtPropietario.Name = "txtPropietario"
        Me.txtPropietario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPropietario.PromptText = "Propietario"
        Me.txtPropietario.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPropietario.SelectedText = ""
        Me.txtPropietario.SelectionLength = 0
        Me.txtPropietario.SelectionStart = 0
        Me.txtPropietario.ShortcutsEnabled = True
        Me.txtPropietario.Size = New System.Drawing.Size(340, 23)
        Me.txtPropietario.TabIndex = 22
        Me.txtPropietario.UseSelectable = True
        Me.txtPropietario.WaterMark = "Propietario"
        Me.txtPropietario.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPropietario.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtRFC
        '
        Me.txtRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtRFC.CustomButton.Image = Nothing
        Me.txtRFC.CustomButton.Location = New System.Drawing.Point(139, 1)
        Me.txtRFC.CustomButton.Name = ""
        Me.txtRFC.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtRFC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtRFC.CustomButton.TabIndex = 1
        Me.txtRFC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtRFC.CustomButton.UseSelectable = True
        Me.txtRFC.CustomButton.Visible = False
        Me.txtRFC.Lines = New String(-1) {}
        Me.txtRFC.Location = New System.Drawing.Point(387, 165)
        Me.txtRFC.MaxLength = 32767
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRFC.PromptText = "R.F.C."
        Me.txtRFC.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRFC.SelectedText = ""
        Me.txtRFC.SelectionLength = 0
        Me.txtRFC.SelectionStart = 0
        Me.txtRFC.ShortcutsEnabled = True
        Me.txtRFC.Size = New System.Drawing.Size(161, 23)
        Me.txtRFC.TabIndex = 23
        Me.txtRFC.UseSelectable = True
        Me.txtRFC.WaterMark = "R.F.C."
        Me.txtRFC.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtRFC.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtColonia
        '
        Me.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtColonia.CustomButton.Image = Nothing
        Me.txtColonia.CustomButton.Location = New System.Drawing.Point(139, 1)
        Me.txtColonia.CustomButton.Name = ""
        Me.txtColonia.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtColonia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtColonia.CustomButton.TabIndex = 1
        Me.txtColonia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtColonia.CustomButton.UseSelectable = True
        Me.txtColonia.CustomButton.Visible = False
        Me.txtColonia.Lines = New String(-1) {}
        Me.txtColonia.Location = New System.Drawing.Point(31, 194)
        Me.txtColonia.MaxLength = 32767
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtColonia.PromptText = "Colonia"
        Me.txtColonia.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtColonia.SelectedText = ""
        Me.txtColonia.SelectionLength = 0
        Me.txtColonia.SelectionStart = 0
        Me.txtColonia.ShortcutsEnabled = True
        Me.txtColonia.Size = New System.Drawing.Size(161, 23)
        Me.txtColonia.TabIndex = 24
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
        Me.txtCiudad.CustomButton.Location = New System.Drawing.Point(139, 1)
        Me.txtCiudad.CustomButton.Name = ""
        Me.txtCiudad.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCiudad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCiudad.CustomButton.TabIndex = 1
        Me.txtCiudad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCiudad.CustomButton.UseSelectable = True
        Me.txtCiudad.CustomButton.Visible = False
        Me.txtCiudad.Lines = New String(-1) {}
        Me.txtCiudad.Location = New System.Drawing.Point(210, 194)
        Me.txtCiudad.MaxLength = 32767
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCiudad.PromptText = "Ciudad"
        Me.txtCiudad.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCiudad.SelectedText = ""
        Me.txtCiudad.SelectionLength = 0
        Me.txtCiudad.SelectionStart = 0
        Me.txtCiudad.ShortcutsEnabled = True
        Me.txtCiudad.Size = New System.Drawing.Size(161, 23)
        Me.txtCiudad.TabIndex = 25
        Me.txtCiudad.UseSelectable = True
        Me.txtCiudad.WaterMark = "Ciudad"
        Me.txtCiudad.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCiudad.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtTelefono
        '
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtTelefono.CustomButton.Image = Nothing
        Me.txtTelefono.CustomButton.Location = New System.Drawing.Point(139, 1)
        Me.txtTelefono.CustomButton.Name = ""
        Me.txtTelefono.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTelefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTelefono.CustomButton.TabIndex = 1
        Me.txtTelefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTelefono.CustomButton.UseSelectable = True
        Me.txtTelefono.CustomButton.Visible = False
        Me.txtTelefono.Lines = New String(-1) {}
        Me.txtTelefono.Location = New System.Drawing.Point(387, 194)
        Me.txtTelefono.MaxLength = 32767
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefono.PromptText = "Teléfono"
        Me.txtTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTelefono.SelectedText = ""
        Me.txtTelefono.SelectionLength = 0
        Me.txtTelefono.SelectionStart = 0
        Me.txtTelefono.ShortcutsEnabled = True
        Me.txtTelefono.Size = New System.Drawing.Size(161, 23)
        Me.txtTelefono.TabIndex = 26
        Me.txtTelefono.UseSelectable = True
        Me.txtTelefono.WaterMark = "Teléfono"
        Me.txtTelefono.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTelefono.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.Location = New System.Drawing.Point(31, 62)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(516, 38)
        Me.MetroTile1.TabIndex = 27
        Me.MetroTile1.Text = "Empresa"
        Me.MetroTile1.UseSelectable = True
        '
        'txtTickets
        '
        Me.txtTickets.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtTickets.CustomButton.Image = Nothing
        Me.txtTickets.CustomButton.Location = New System.Drawing.Point(495, 1)
        Me.txtTickets.CustomButton.Name = ""
        Me.txtTickets.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTickets.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTickets.CustomButton.TabIndex = 1
        Me.txtTickets.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTickets.CustomButton.UseSelectable = True
        Me.txtTickets.CustomButton.Visible = False
        Me.txtTickets.Lines = New String(-1) {}
        Me.txtTickets.Location = New System.Drawing.Point(31, 282)
        Me.txtTickets.MaxLength = 32767
        Me.txtTickets.Name = "txtTickets"
        Me.txtTickets.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTickets.PromptText = "Tickets"
        Me.txtTickets.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTickets.SelectedText = ""
        Me.txtTickets.SelectionLength = 0
        Me.txtTickets.SelectionStart = 0
        Me.txtTickets.ShortcutsEnabled = True
        Me.txtTickets.Size = New System.Drawing.Size(517, 23)
        Me.txtTickets.TabIndex = 28
        Me.txtTickets.UseSelectable = True
        Me.txtTickets.WaterMark = "Tickets"
        Me.txtTickets.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTickets.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtFacturas
        '
        Me.txtFacturas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtFacturas.CustomButton.Image = Nothing
        Me.txtFacturas.CustomButton.Location = New System.Drawing.Point(495, 1)
        Me.txtFacturas.CustomButton.Name = ""
        Me.txtFacturas.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtFacturas.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFacturas.CustomButton.TabIndex = 1
        Me.txtFacturas.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFacturas.CustomButton.UseSelectable = True
        Me.txtFacturas.CustomButton.Visible = False
        Me.txtFacturas.Lines = New String(-1) {}
        Me.txtFacturas.Location = New System.Drawing.Point(31, 311)
        Me.txtFacturas.MaxLength = 32767
        Me.txtFacturas.Name = "txtFacturas"
        Me.txtFacturas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFacturas.PromptText = "Facturas"
        Me.txtFacturas.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFacturas.SelectedText = ""
        Me.txtFacturas.SelectionLength = 0
        Me.txtFacturas.SelectionStart = 0
        Me.txtFacturas.ShortcutsEnabled = True
        Me.txtFacturas.Size = New System.Drawing.Size(517, 23)
        Me.txtFacturas.TabIndex = 29
        Me.txtFacturas.UseSelectable = True
        Me.txtFacturas.WaterMark = "Facturas"
        Me.txtFacturas.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFacturas.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.Location = New System.Drawing.Point(31, 237)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(516, 38)
        Me.MetroTile2.TabIndex = 30
        Me.MetroTile2.Text = "Impresoras"
        Me.MetroTile2.UseSelectable = True
        '
        'txtCajaChica
        '
        Me.txtCajaChica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtCajaChica.CustomButton.Image = Nothing
        Me.txtCajaChica.CustomButton.Location = New System.Drawing.Point(138, 1)
        Me.txtCajaChica.CustomButton.Name = ""
        Me.txtCajaChica.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCajaChica.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCajaChica.CustomButton.TabIndex = 1
        Me.txtCajaChica.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCajaChica.CustomButton.UseSelectable = True
        Me.txtCajaChica.CustomButton.Visible = False
        Me.txtCajaChica.Lines = New String() {"0.00"}
        Me.txtCajaChica.Location = New System.Drawing.Point(32, 420)
        Me.txtCajaChica.MaxLength = 32767
        Me.txtCajaChica.Name = "txtCajaChica"
        Me.txtCajaChica.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCajaChica.PromptText = "0.00"
        Me.txtCajaChica.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCajaChica.SelectedText = ""
        Me.txtCajaChica.SelectionLength = 0
        Me.txtCajaChica.SelectionStart = 0
        Me.txtCajaChica.ShortcutsEnabled = True
        Me.txtCajaChica.Size = New System.Drawing.Size(160, 23)
        Me.txtCajaChica.TabIndex = 31
        Me.txtCajaChica.Text = "0.00"
        Me.txtCajaChica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCajaChica.UseSelectable = True
        Me.txtCajaChica.WaterMark = "0.00"
        Me.txtCajaChica.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCajaChica.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(32, 398)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel1.TabIndex = 32
        Me.MetroLabel1.Text = "Caja Chica"
        '
        'txtFactorIVA
        '
        Me.txtFactorIVA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtFactorIVA.CustomButton.Image = Nothing
        Me.txtFactorIVA.CustomButton.Location = New System.Drawing.Point(138, 1)
        Me.txtFactorIVA.CustomButton.Name = ""
        Me.txtFactorIVA.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtFactorIVA.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFactorIVA.CustomButton.TabIndex = 1
        Me.txtFactorIVA.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFactorIVA.CustomButton.UseSelectable = True
        Me.txtFactorIVA.CustomButton.Visible = False
        Me.txtFactorIVA.Lines = New String() {"0.00"}
        Me.txtFactorIVA.Location = New System.Drawing.Point(210, 420)
        Me.txtFactorIVA.MaxLength = 32767
        Me.txtFactorIVA.Name = "txtFactorIVA"
        Me.txtFactorIVA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFactorIVA.PromptText = "0.00"
        Me.txtFactorIVA.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFactorIVA.SelectedText = ""
        Me.txtFactorIVA.SelectionLength = 0
        Me.txtFactorIVA.SelectionStart = 0
        Me.txtFactorIVA.ShortcutsEnabled = True
        Me.txtFactorIVA.Size = New System.Drawing.Size(160, 23)
        Me.txtFactorIVA.TabIndex = 33
        Me.txtFactorIVA.Text = "0.00"
        Me.txtFactorIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtFactorIVA.UseSelectable = True
        Me.txtFactorIVA.WaterMark = "0.00"
        Me.txtFactorIVA.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFactorIVA.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(211, 398)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(82, 19)
        Me.MetroLabel2.TabIndex = 34
        Me.MetroLabel2.Text = "Factor I.V.A."
        '
        'MetroTile3
        '
        Me.MetroTile3.ActiveControl = Nothing
        Me.MetroTile3.Location = New System.Drawing.Point(32, 357)
        Me.MetroTile3.Name = "MetroTile3"
        Me.MetroTile3.Size = New System.Drawing.Size(516, 38)
        Me.MetroTile3.TabIndex = 35
        Me.MetroTile3.Text = "Otras Configuraciones"
        Me.MetroTile3.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(32, 456)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(157, 19)
        Me.MetroLabel3.TabIndex = 37
        Me.MetroLabel3.Text = "Impresiones por Factura"
        '
        'txtNumFacturas
        '
        Me.txtNumFacturas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtNumFacturas.CustomButton.Image = Nothing
        Me.txtNumFacturas.CustomButton.Location = New System.Drawing.Point(138, 1)
        Me.txtNumFacturas.CustomButton.Name = ""
        Me.txtNumFacturas.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNumFacturas.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNumFacturas.CustomButton.TabIndex = 1
        Me.txtNumFacturas.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNumFacturas.CustomButton.UseSelectable = True
        Me.txtNumFacturas.CustomButton.Visible = False
        Me.txtNumFacturas.Lines = New String() {"0"}
        Me.txtNumFacturas.Location = New System.Drawing.Point(32, 478)
        Me.txtNumFacturas.MaxLength = 32767
        Me.txtNumFacturas.Name = "txtNumFacturas"
        Me.txtNumFacturas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumFacturas.PromptText = "0"
        Me.txtNumFacturas.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumFacturas.SelectedText = ""
        Me.txtNumFacturas.SelectionLength = 0
        Me.txtNumFacturas.SelectionStart = 0
        Me.txtNumFacturas.ShortcutsEnabled = True
        Me.txtNumFacturas.Size = New System.Drawing.Size(160, 23)
        Me.txtNumFacturas.TabIndex = 36
        Me.txtNumFacturas.Text = "0"
        Me.txtNumFacturas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNumFacturas.UseSelectable = True
        Me.txtNumFacturas.WaterMark = "0"
        Me.txtNumFacturas.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNumFacturas.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(388, 398)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(87, 19)
        Me.MetroLabel4.TabIndex = 39
        Me.MetroLabel4.Text = "Folio Factura"
        '
        'txtFolioFactura
        '
        Me.txtFolioFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtFolioFactura.CustomButton.Image = Nothing
        Me.txtFolioFactura.CustomButton.Location = New System.Drawing.Point(138, 1)
        Me.txtFolioFactura.CustomButton.Name = ""
        Me.txtFolioFactura.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtFolioFactura.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFolioFactura.CustomButton.TabIndex = 1
        Me.txtFolioFactura.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFolioFactura.CustomButton.UseSelectable = True
        Me.txtFolioFactura.CustomButton.Visible = False
        Me.txtFolioFactura.Lines = New String() {"0"}
        Me.txtFolioFactura.Location = New System.Drawing.Point(388, 420)
        Me.txtFolioFactura.MaxLength = 32767
        Me.txtFolioFactura.Name = "txtFolioFactura"
        Me.txtFolioFactura.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFolioFactura.PromptText = "0"
        Me.txtFolioFactura.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFolioFactura.SelectedText = ""
        Me.txtFolioFactura.SelectionLength = 0
        Me.txtFolioFactura.SelectionStart = 0
        Me.txtFolioFactura.ShortcutsEnabled = True
        Me.txtFolioFactura.Size = New System.Drawing.Size(160, 23)
        Me.txtFolioFactura.TabIndex = 38
        Me.txtFolioFactura.Text = "0"
        Me.txtFolioFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFolioFactura.UseSelectable = True
        Me.txtFolioFactura.WaterMark = "0"
        Me.txtFolioFactura.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFolioFactura.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(211, 456)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(105, 19)
        Me.MetroLabel5.TabIndex = 41
        Me.MetroLabel5.Text = "Tipo de Cambio"
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtTipoCambio.CustomButton.Image = Nothing
        Me.txtTipoCambio.CustomButton.Location = New System.Drawing.Point(137, 1)
        Me.txtTipoCambio.CustomButton.Name = ""
        Me.txtTipoCambio.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTipoCambio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTipoCambio.CustomButton.TabIndex = 1
        Me.txtTipoCambio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTipoCambio.CustomButton.UseSelectable = True
        Me.txtTipoCambio.CustomButton.Visible = False
        Me.txtTipoCambio.Lines = New String(-1) {}
        Me.txtTipoCambio.Location = New System.Drawing.Point(211, 478)
        Me.txtTipoCambio.MaxLength = 32767
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTipoCambio.PromptText = "0.000000"
        Me.txtTipoCambio.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTipoCambio.SelectedText = ""
        Me.txtTipoCambio.SelectionLength = 0
        Me.txtTipoCambio.SelectionStart = 0
        Me.txtTipoCambio.ShortcutsEnabled = True
        Me.txtTipoCambio.Size = New System.Drawing.Size(159, 23)
        Me.txtTipoCambio.TabIndex = 40
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTipoCambio.UseSelectable = True
        Me.txtTipoCambio.WaterMark = "0.000000"
        Me.txtTipoCambio.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTipoCambio.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnTecnoLite
        '
        Me.btnTecnoLite.Location = New System.Drawing.Point(387, 478)
        Me.btnTecnoLite.Name = "btnTecnoLite"
        Me.btnTecnoLite.Size = New System.Drawing.Size(161, 23)
        Me.btnTecnoLite.TabIndex = 42
        Me.btnTecnoLite.Text = "Afectar Precio TECNO LITE"
        Me.btnTecnoLite.UseSelectable = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(156, 550)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 43
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseSelectable = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(241, 550)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 44
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseSelectable = True
        '
        'FrmConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(576, 672)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnTecnoLite)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.txtTipoCambio)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.txtFolioFactura)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txtNumFacturas)
        Me.Controls.Add(Me.MetroTile3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.txtFactorIVA)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtCajaChica)
        Me.Controls.Add(Me.MetroTile2)
        Me.Controls.Add(Me.txtFacturas)
        Me.Controls.Add(Me.txtTickets)
        Me.Controls.Add(Me.MetroTile1)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtCiudad)
        Me.Controls.Add(Me.txtColonia)
        Me.Controls.Add(Me.txtRFC)
        Me.Controls.Add(Me.txtPropietario)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmConfiguracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configuracion del Sistema"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDireccion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPropietario As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtRFC As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtColonia As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCiudad As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTelefono As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents txtTickets As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtFacturas As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents txtCajaChica As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtFactorIVA As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTile3 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNumFacturas As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtFolioFactura As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTipoCambio As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnTecnoLite As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSalir As MetroFramework.Controls.MetroButton
End Class
