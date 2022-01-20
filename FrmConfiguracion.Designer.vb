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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnTecnoLite = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtNombre.CustomButton.Image = Nothing
        Me.txtNombre.CustomButton.Location = New System.Drawing.Point(884, 2)
        Me.txtNombre.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombre.CustomButton.Name = ""
        Me.txtNombre.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNombre.CustomButton.TabIndex = 1
        Me.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNombre.CustomButton.UseSelectable = true
        Me.txtNombre.CustomButton.Visible = false
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(41, 132)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.PromptText = "Nombre"
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.SelectionLength = 0
        Me.txtNombre.SelectionStart = 0
        Me.txtNombre.ShortcutsEnabled = true
        Me.txtNombre.Size = New System.Drawing.Size(689, 28)
        Me.txtNombre.TabIndex = 20
        Me.txtNombre.UseSelectable = true
        Me.txtNombre.WaterMark = "Nombre"
        Me.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtNombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDireccion
        '
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtDireccion.CustomButton.Image = Nothing
        Me.txtDireccion.CustomButton.Location = New System.Drawing.Point(884, 2)
        Me.txtDireccion.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDireccion.CustomButton.Name = ""
        Me.txtDireccion.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtDireccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDireccion.CustomButton.TabIndex = 1
        Me.txtDireccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDireccion.CustomButton.UseSelectable = true
        Me.txtDireccion.CustomButton.Visible = false
        Me.txtDireccion.Lines = New String(-1) {}
        Me.txtDireccion.Location = New System.Drawing.Point(41, 167)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDireccion.MaxLength = 32767
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDireccion.PromptText = "Calle y Número Exterior"
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDireccion.SelectedText = ""
        Me.txtDireccion.SelectionLength = 0
        Me.txtDireccion.SelectionStart = 0
        Me.txtDireccion.ShortcutsEnabled = true
        Me.txtDireccion.Size = New System.Drawing.Size(689, 28)
        Me.txtDireccion.TabIndex = 21
        Me.txtDireccion.UseSelectable = true
        Me.txtDireccion.WaterMark = "Calle y Número Exterior"
        Me.txtDireccion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtDireccion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPropietario
        '
        Me.txtPropietario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtPropietario.CustomButton.Image = Nothing
        Me.txtPropietario.CustomButton.Location = New System.Drawing.Point(569, 2)
        Me.txtPropietario.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPropietario.CustomButton.Name = ""
        Me.txtPropietario.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtPropietario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPropietario.CustomButton.TabIndex = 1
        Me.txtPropietario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPropietario.CustomButton.UseSelectable = true
        Me.txtPropietario.CustomButton.Visible = false
        Me.txtPropietario.Lines = New String(-1) {}
        Me.txtPropietario.Location = New System.Drawing.Point(41, 203)
        Me.txtPropietario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPropietario.MaxLength = 32767
        Me.txtPropietario.Name = "txtPropietario"
        Me.txtPropietario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPropietario.PromptText = "Propietario"
        Me.txtPropietario.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPropietario.SelectedText = ""
        Me.txtPropietario.SelectionLength = 0
        Me.txtPropietario.SelectionStart = 0
        Me.txtPropietario.ShortcutsEnabled = true
        Me.txtPropietario.Size = New System.Drawing.Size(453, 28)
        Me.txtPropietario.TabIndex = 22
        Me.txtPropietario.UseSelectable = true
        Me.txtPropietario.WaterMark = "Propietario"
        Me.txtPropietario.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtPropietario.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtRFC
        '
        Me.txtRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtRFC.CustomButton.Image = Nothing
        Me.txtRFC.CustomButton.Location = New System.Drawing.Point(252, 2)
        Me.txtRFC.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRFC.CustomButton.Name = ""
        Me.txtRFC.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtRFC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtRFC.CustomButton.TabIndex = 1
        Me.txtRFC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtRFC.CustomButton.UseSelectable = true
        Me.txtRFC.CustomButton.Visible = false
        Me.txtRFC.Lines = New String(-1) {}
        Me.txtRFC.Location = New System.Drawing.Point(516, 203)
        Me.txtRFC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRFC.MaxLength = 32767
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRFC.PromptText = "R.F.C."
        Me.txtRFC.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRFC.SelectedText = ""
        Me.txtRFC.SelectionLength = 0
        Me.txtRFC.SelectionStart = 0
        Me.txtRFC.ShortcutsEnabled = true
        Me.txtRFC.Size = New System.Drawing.Size(215, 28)
        Me.txtRFC.TabIndex = 23
        Me.txtRFC.UseSelectable = true
        Me.txtRFC.WaterMark = "R.F.C."
        Me.txtRFC.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtRFC.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtColonia
        '
        Me.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtColonia.CustomButton.Image = Nothing
        Me.txtColonia.CustomButton.Location = New System.Drawing.Point(252, 2)
        Me.txtColonia.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtColonia.CustomButton.Name = ""
        Me.txtColonia.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtColonia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtColonia.CustomButton.TabIndex = 1
        Me.txtColonia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtColonia.CustomButton.UseSelectable = true
        Me.txtColonia.CustomButton.Visible = false
        Me.txtColonia.Lines = New String(-1) {}
        Me.txtColonia.Location = New System.Drawing.Point(41, 239)
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
        Me.txtColonia.Size = New System.Drawing.Size(215, 28)
        Me.txtColonia.TabIndex = 24
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
        Me.txtCiudad.CustomButton.Location = New System.Drawing.Point(252, 2)
        Me.txtCiudad.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCiudad.CustomButton.Name = ""
        Me.txtCiudad.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtCiudad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCiudad.CustomButton.TabIndex = 1
        Me.txtCiudad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCiudad.CustomButton.UseSelectable = true
        Me.txtCiudad.CustomButton.Visible = false
        Me.txtCiudad.Lines = New String(-1) {}
        Me.txtCiudad.Location = New System.Drawing.Point(280, 239)
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
        Me.txtCiudad.Size = New System.Drawing.Size(215, 28)
        Me.txtCiudad.TabIndex = 25
        Me.txtCiudad.UseSelectable = true
        Me.txtCiudad.WaterMark = "Ciudad"
        Me.txtCiudad.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtCiudad.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtTelefono
        '
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtTelefono.CustomButton.Image = Nothing
        Me.txtTelefono.CustomButton.Location = New System.Drawing.Point(252, 2)
        Me.txtTelefono.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTelefono.CustomButton.Name = ""
        Me.txtTelefono.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtTelefono.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTelefono.CustomButton.TabIndex = 1
        Me.txtTelefono.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTelefono.CustomButton.UseSelectable = true
        Me.txtTelefono.CustomButton.Visible = false
        Me.txtTelefono.Lines = New String(-1) {}
        Me.txtTelefono.Location = New System.Drawing.Point(516, 239)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTelefono.MaxLength = 32767
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefono.PromptText = "Teléfono"
        Me.txtTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTelefono.SelectedText = ""
        Me.txtTelefono.SelectionLength = 0
        Me.txtTelefono.SelectionStart = 0
        Me.txtTelefono.ShortcutsEnabled = true
        Me.txtTelefono.Size = New System.Drawing.Size(215, 28)
        Me.txtTelefono.TabIndex = 26
        Me.txtTelefono.UseSelectable = true
        Me.txtTelefono.WaterMark = "Teléfono"
        Me.txtTelefono.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtTelefono.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.Location = New System.Drawing.Point(41, 76)
        Me.MetroTile1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(688, 47)
        Me.MetroTile1.TabIndex = 27
        Me.MetroTile1.Text = "Empresa"
        Me.MetroTile1.UseSelectable = true
        '
        'txtTickets
        '
        Me.txtTickets.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtTickets.CustomButton.Image = Nothing
        Me.txtTickets.CustomButton.Location = New System.Drawing.Point(884, 2)
        Me.txtTickets.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTickets.CustomButton.Name = ""
        Me.txtTickets.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtTickets.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTickets.CustomButton.TabIndex = 1
        Me.txtTickets.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTickets.CustomButton.UseSelectable = true
        Me.txtTickets.CustomButton.Visible = false
        Me.txtTickets.Lines = New String(-1) {}
        Me.txtTickets.Location = New System.Drawing.Point(41, 347)
        Me.txtTickets.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTickets.MaxLength = 32767
        Me.txtTickets.Name = "txtTickets"
        Me.txtTickets.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTickets.PromptText = "Tickets"
        Me.txtTickets.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTickets.SelectedText = ""
        Me.txtTickets.SelectionLength = 0
        Me.txtTickets.SelectionStart = 0
        Me.txtTickets.ShortcutsEnabled = true
        Me.txtTickets.Size = New System.Drawing.Size(689, 28)
        Me.txtTickets.TabIndex = 28
        Me.txtTickets.UseSelectable = true
        Me.txtTickets.WaterMark = "Tickets"
        Me.txtTickets.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtTickets.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtFacturas
        '
        Me.txtFacturas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtFacturas.CustomButton.Image = Nothing
        Me.txtFacturas.CustomButton.Location = New System.Drawing.Point(884, 2)
        Me.txtFacturas.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFacturas.CustomButton.Name = ""
        Me.txtFacturas.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtFacturas.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFacturas.CustomButton.TabIndex = 1
        Me.txtFacturas.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFacturas.CustomButton.UseSelectable = true
        Me.txtFacturas.CustomButton.Visible = false
        Me.txtFacturas.Lines = New String(-1) {}
        Me.txtFacturas.Location = New System.Drawing.Point(41, 383)
        Me.txtFacturas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFacturas.MaxLength = 32767
        Me.txtFacturas.Name = "txtFacturas"
        Me.txtFacturas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFacturas.PromptText = "Facturas"
        Me.txtFacturas.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFacturas.SelectedText = ""
        Me.txtFacturas.SelectionLength = 0
        Me.txtFacturas.SelectionStart = 0
        Me.txtFacturas.ShortcutsEnabled = true
        Me.txtFacturas.Size = New System.Drawing.Size(689, 28)
        Me.txtFacturas.TabIndex = 29
        Me.txtFacturas.UseSelectable = true
        Me.txtFacturas.WaterMark = "Facturas"
        Me.txtFacturas.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtFacturas.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.Location = New System.Drawing.Point(41, 292)
        Me.MetroTile2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(688, 47)
        Me.MetroTile2.TabIndex = 30
        Me.MetroTile2.Text = "Impresoras"
        Me.MetroTile2.UseSelectable = true
        '
        'txtCajaChica
        '
        Me.txtCajaChica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtCajaChica.CustomButton.Image = Nothing
        Me.txtCajaChica.CustomButton.Location = New System.Drawing.Point(249, 2)
        Me.txtCajaChica.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCajaChica.CustomButton.Name = ""
        Me.txtCajaChica.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtCajaChica.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCajaChica.CustomButton.TabIndex = 1
        Me.txtCajaChica.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCajaChica.CustomButton.UseSelectable = true
        Me.txtCajaChica.CustomButton.Visible = false
        Me.txtCajaChica.Lines = New String() {"0.00"}
        Me.txtCajaChica.Location = New System.Drawing.Point(43, 517)
        Me.txtCajaChica.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCajaChica.MaxLength = 32767
        Me.txtCajaChica.Name = "txtCajaChica"
        Me.txtCajaChica.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCajaChica.PromptText = "0.00"
        Me.txtCajaChica.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCajaChica.SelectedText = ""
        Me.txtCajaChica.SelectionLength = 0
        Me.txtCajaChica.SelectionStart = 0
        Me.txtCajaChica.ShortcutsEnabled = true
        Me.txtCajaChica.Size = New System.Drawing.Size(213, 28)
        Me.txtCajaChica.TabIndex = 31
        Me.txtCajaChica.Text = "0.00"
        Me.txtCajaChica.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCajaChica.UseSelectable = true
        Me.txtCajaChica.WaterMark = "0.00"
        Me.txtCajaChica.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtCajaChica.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = true
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(43, 490)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(78, 20)
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
        Me.txtFactorIVA.CustomButton.Location = New System.Drawing.Point(249, 2)
        Me.txtFactorIVA.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFactorIVA.CustomButton.Name = ""
        Me.txtFactorIVA.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtFactorIVA.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFactorIVA.CustomButton.TabIndex = 1
        Me.txtFactorIVA.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFactorIVA.CustomButton.UseSelectable = true
        Me.txtFactorIVA.CustomButton.Visible = false
        Me.txtFactorIVA.Lines = New String() {"0.00"}
        Me.txtFactorIVA.Location = New System.Drawing.Point(280, 517)
        Me.txtFactorIVA.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFactorIVA.MaxLength = 32767
        Me.txtFactorIVA.Name = "txtFactorIVA"
        Me.txtFactorIVA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFactorIVA.PromptText = "0.00"
        Me.txtFactorIVA.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFactorIVA.SelectedText = ""
        Me.txtFactorIVA.SelectionLength = 0
        Me.txtFactorIVA.SelectionStart = 0
        Me.txtFactorIVA.ShortcutsEnabled = true
        Me.txtFactorIVA.Size = New System.Drawing.Size(213, 28)
        Me.txtFactorIVA.TabIndex = 33
        Me.txtFactorIVA.Text = "0.00"
        Me.txtFactorIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtFactorIVA.UseSelectable = true
        Me.txtFactorIVA.WaterMark = "0.00"
        Me.txtFactorIVA.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtFactorIVA.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = true
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(281, 490)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(85, 20)
        Me.MetroLabel2.TabIndex = 34
        Me.MetroLabel2.Text = "Factor I.V.A."
        '
        'MetroTile3
        '
        Me.MetroTile3.ActiveControl = Nothing
        Me.MetroTile3.Location = New System.Drawing.Point(43, 439)
        Me.MetroTile3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroTile3.Name = "MetroTile3"
        Me.MetroTile3.Size = New System.Drawing.Size(688, 47)
        Me.MetroTile3.TabIndex = 35
        Me.MetroTile3.Text = "Otras Configuraciones"
        Me.MetroTile3.UseSelectable = true
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = true
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(43, 561)
        Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(167, 20)
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
        Me.txtNumFacturas.CustomButton.Location = New System.Drawing.Point(249, 2)
        Me.txtNumFacturas.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNumFacturas.CustomButton.Name = ""
        Me.txtNumFacturas.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtNumFacturas.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNumFacturas.CustomButton.TabIndex = 1
        Me.txtNumFacturas.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNumFacturas.CustomButton.UseSelectable = true
        Me.txtNumFacturas.CustomButton.Visible = false
        Me.txtNumFacturas.Lines = New String() {"0"}
        Me.txtNumFacturas.Location = New System.Drawing.Point(43, 588)
        Me.txtNumFacturas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNumFacturas.MaxLength = 32767
        Me.txtNumFacturas.Name = "txtNumFacturas"
        Me.txtNumFacturas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumFacturas.PromptText = "0"
        Me.txtNumFacturas.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumFacturas.SelectedText = ""
        Me.txtNumFacturas.SelectionLength = 0
        Me.txtNumFacturas.SelectionStart = 0
        Me.txtNumFacturas.ShortcutsEnabled = true
        Me.txtNumFacturas.Size = New System.Drawing.Size(213, 28)
        Me.txtNumFacturas.TabIndex = 36
        Me.txtNumFacturas.Text = "0"
        Me.txtNumFacturas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNumFacturas.UseSelectable = true
        Me.txtNumFacturas.WaterMark = "0"
        Me.txtNumFacturas.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtNumFacturas.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = true
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(517, 490)
        Me.MetroLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(93, 20)
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
        Me.txtFolioFactura.CustomButton.Location = New System.Drawing.Point(249, 2)
        Me.txtFolioFactura.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFolioFactura.CustomButton.Name = ""
        Me.txtFolioFactura.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtFolioFactura.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFolioFactura.CustomButton.TabIndex = 1
        Me.txtFolioFactura.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFolioFactura.CustomButton.UseSelectable = true
        Me.txtFolioFactura.CustomButton.Visible = false
        Me.txtFolioFactura.Lines = New String() {"0"}
        Me.txtFolioFactura.Location = New System.Drawing.Point(517, 517)
        Me.txtFolioFactura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFolioFactura.MaxLength = 32767
        Me.txtFolioFactura.Name = "txtFolioFactura"
        Me.txtFolioFactura.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFolioFactura.PromptText = "0"
        Me.txtFolioFactura.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFolioFactura.SelectedText = ""
        Me.txtFolioFactura.SelectionLength = 0
        Me.txtFolioFactura.SelectionStart = 0
        Me.txtFolioFactura.ShortcutsEnabled = true
        Me.txtFolioFactura.Size = New System.Drawing.Size(213, 28)
        Me.txtFolioFactura.TabIndex = 38
        Me.txtFolioFactura.Text = "0"
        Me.txtFolioFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFolioFactura.UseSelectable = true
        Me.txtFolioFactura.WaterMark = "0"
        Me.txtFolioFactura.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtFolioFactura.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = true
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(281, 561)
        Me.MetroLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(116, 20)
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
        Me.txtTipoCambio.CustomButton.Location = New System.Drawing.Point(248, 2)
        Me.txtTipoCambio.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTipoCambio.CustomButton.Name = ""
        Me.txtTipoCambio.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtTipoCambio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTipoCambio.CustomButton.TabIndex = 1
        Me.txtTipoCambio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTipoCambio.CustomButton.UseSelectable = true
        Me.txtTipoCambio.CustomButton.Visible = false
        Me.txtTipoCambio.Lines = New String(-1) {}
        Me.txtTipoCambio.Location = New System.Drawing.Point(281, 588)
        Me.txtTipoCambio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTipoCambio.MaxLength = 32767
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTipoCambio.PromptText = "0.000000"
        Me.txtTipoCambio.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTipoCambio.SelectedText = ""
        Me.txtTipoCambio.SelectionLength = 0
        Me.txtTipoCambio.SelectionStart = 0
        Me.txtTipoCambio.ShortcutsEnabled = true
        Me.txtTipoCambio.Size = New System.Drawing.Size(212, 28)
        Me.txtTipoCambio.TabIndex = 40
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTipoCambio.UseSelectable = true
        Me.txtTipoCambio.WaterMark = "0.000000"
        Me.txtTipoCambio.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtTipoCambio.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.close_window_16px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(320, 677)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 85
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
        Me.btnSave.Location = New System.Drawing.Point(214, 677)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 28)
        Me.btnSave.TabIndex = 84
        Me.btnSave.Text = "Guardar"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.UseVisualStyleBackColor = true
        '
        'btnTecnoLite
        '
        Me.btnTecnoLite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTecnoLite.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnTecnoLite.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTecnoLite.Location = New System.Drawing.Point(517, 588)
        Me.btnTecnoLite.Name = "btnTecnoLite"
        Me.btnTecnoLite.Size = New System.Drawing.Size(212, 28)
        Me.btnTecnoLite.TabIndex = 86
        Me.btnTecnoLite.Text = "Afectar Precio TECNO LITE"
        Me.btnTecnoLite.UseVisualStyleBackColor = true
        '
        'FrmConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(768, 827)
        Me.ControlBox = false
        Me.Controls.Add(Me.btnTecnoLite)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSave)
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
        Me.KeyPreview = true
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = false
        Me.Name = "FrmConfiguracion"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configuracion del Sistema"
        Me.ResumeLayout(false)
        Me.PerformLayout

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
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnTecnoLite As Button
End Class
