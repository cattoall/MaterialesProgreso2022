<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacturacion
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmdUpdateUUID = New MetroFramework.Controls.MetroButton()
        Me.CmdSalir = New MetroFramework.Controls.MetroButton()
        Me.CmbBanco = New MetroFramework.Controls.MetroComboBox()
        Me.txtCuenta = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox3 = New MetroFramework.Controls.MetroPanel()
        Me.Label11 = New MetroFramework.Controls.MetroLabel()
        Me.txtEmail = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.LblCliente = New MetroFramework.Controls.MetroLabel()
        Me.Label15 = New MetroFramework.Controls.MetroLabel()
        Me.Label9 = New MetroFramework.Controls.MetroLabel()
        Me.txtCiudad = New MetroFramework.Controls.MetroTextBox()
        Me.TxtRFC = New MetroFramework.Controls.MetroTextBox()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.txtNumero = New MetroFramework.Controls.MetroTextBox()
        Me.txtnombre = New MetroFramework.Controls.MetroTextBox()
        Me.txtestado = New MetroFramework.Controls.MetroTextBox()
        Me.txtcp = New MetroFramework.Controls.MetroTextBox()
        Me.txtcolonia = New MetroFramework.Controls.MetroTextBox()
        Me.txtdirecion = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox2 = New MetroFramework.Controls.MetroPanel()
        Me.LblPlazo = New MetroFramework.Controls.MetroLabel()
        Me.CmbCredito = New MetroFramework.Controls.MetroComboBox()
        Me.Lbltipo = New MetroFramework.Controls.MetroLabel()
        Me.LblFechaLim = New MetroFramework.Controls.MetroLabel()
        Me.LblFechaFac = New MetroFramework.Controls.MetroLabel()
        Me.CmbMetodoPago = New MetroFramework.Controls.MetroComboBox()
        Me.DateTimePicker1 = New MetroFramework.Controls.MetroDateTime()
        Me.DateTimePicker2 = New MetroFramework.Controls.MetroDateTime()
        Me.CmdFormaPago = New MetroFramework.Controls.MetroComboBox()
        Me.Label12 = New MetroFramework.Controls.MetroLabel()
        Me.Label17 = New MetroFramework.Controls.MetroLabel()
        Me.CmbUsoCDFI = New MetroFramework.Controls.MetroComboBox()
        Me.GroupBox4 = New MetroFramework.Controls.MetroPanel()
        Me.Btn_cfdi3_3 = New MetroFramework.Controls.MetroButton()
        Me.lblnoregistros = New MetroFramework.Controls.MetroLabel()
        Me.LblNRegistros = New MetroFramework.Controls.MetroLabel()
        Me.CmdFactura = New MetroFramework.Controls.MetroButton()
        Me.CmdLimpiar = New MetroFramework.Controls.MetroButton()
        Me.GroupBox6 = New MetroFramework.Controls.MetroPanel()
        Me.CmdGenerarMostrador = New MetroFramework.Controls.MetroButton()
        Me.DateTimePicker3 = New MetroFramework.Controls.MetroDateTime()
        Me.CbMostrador = New MetroFramework.Controls.MetroCheckBox()
        Me.GbTicket = New MetroFramework.Controls.MetroPanel()
        Me.lv_ticket = New System.Windows.Forms.ListBox()
        Me.Label10 = New MetroFramework.Controls.MetroLabel()
        Me.TxtTikect = New MetroFramework.Controls.MetroTextBox()
        Me.TxtSubtotal = New MetroFramework.Controls.MetroTextBox()
        Me.TxtIVA = New MetroFramework.Controls.MetroTextBox()
        Me.TxtTotal = New MetroFramework.Controls.MetroTextBox()
        Me.TxtFolio = New MetroFramework.Controls.MetroTextBox()
        Me.LblFolio = New MetroFramework.Controls.MetroLabel()
        Me.LblSubTotal = New MetroFramework.Controls.MetroLabel()
        Me.LblIVA = New MetroFramework.Controls.MetroLabel()
        Me.Label8 = New MetroFramework.Controls.MetroLabel()
        Me.DataGridView1 = New MetroFramework.Controls.MetroGrid()
        Me.foliio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotalCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numeroFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clave_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clave_Unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TasaCero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrBImprimiendo = New MetroFramework.Controls.MetroProgressBar()
        Me.CmdBuscar = New MetroFramework.Controls.MetroButton()
        Me.ChkTasaCero = New MetroFramework.Controls.MetroCheckBox()
        Me.Label14 = New MetroFramework.Controls.MetroLabel()
        Me.Label13 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GbTicket.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdUpdateUUID
        '
        Me.cmdUpdateUUID.Location = New System.Drawing.Point(631, 16)
        Me.cmdUpdateUUID.Name = "cmdUpdateUUID"
        Me.cmdUpdateUUID.Size = New System.Drawing.Size(133, 30)
        Me.cmdUpdateUUID.TabIndex = 60
        Me.cmdUpdateUUID.Text = "Actualizar UUID"
        Me.cmdUpdateUUID.UseSelectable = True
        Me.cmdUpdateUUID.Visible = False
        '
        'CmdSalir
        '
        Me.CmdSalir.Location = New System.Drawing.Point(783, 63)
        Me.CmdSalir.Name = "CmdSalir"
        Me.CmdSalir.Size = New System.Drawing.Size(133, 30)
        Me.CmdSalir.TabIndex = 52
        Me.CmdSalir.Text = "ESC - Salir"
        Me.CmdSalir.UseSelectable = True
        '
        'CmbBanco
        '
        Me.CmbBanco.ItemHeight = 23
        Me.CmbBanco.Items.AddRange(New Object() {"BBVA Bancomer", "Banamex", "HSBC", "Scotia Bank", "Banco del Bajio", "Santander Serfin", "Inbursa", "Banorte"})
        Me.CmbBanco.Location = New System.Drawing.Point(617, 63)
        Me.CmbBanco.Name = "CmbBanco"
        Me.CmbBanco.Size = New System.Drawing.Size(162, 29)
        Me.CmbBanco.TabIndex = 56
        Me.CmbBanco.UseSelectable = True
        Me.CmbBanco.Visible = False
        '
        'txtCuenta
        '
        '
        '
        '
        Me.txtCuenta.CustomButton.Image = Nothing
        Me.txtCuenta.CustomButton.Location = New System.Drawing.Point(48, 2)
        Me.txtCuenta.CustomButton.Name = ""
        Me.txtCuenta.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtCuenta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCuenta.CustomButton.TabIndex = 1
        Me.txtCuenta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCuenta.CustomButton.UseSelectable = True
        Me.txtCuenta.CustomButton.Visible = False
        Me.txtCuenta.Lines = New String(-1) {}
        Me.txtCuenta.Location = New System.Drawing.Point(480, 63)
        Me.txtCuenta.MaxLength = 4
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCuenta.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCuenta.SelectedText = ""
        Me.txtCuenta.SelectionLength = 0
        Me.txtCuenta.SelectionStart = 0
        Me.txtCuenta.ShortcutsEnabled = True
        Me.txtCuenta.Size = New System.Drawing.Size(66, 20)
        Me.txtCuenta.TabIndex = 57
        Me.txtCuenta.UseSelectable = True
        Me.txtCuenta.Visible = False
        Me.txtCuenta.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCuenta.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtEmail)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.LblCliente)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtCiudad)
        Me.GroupBox3.Controls.Add(Me.TxtRFC)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtNumero)
        Me.GroupBox3.Controls.Add(Me.txtnombre)
        Me.GroupBox3.Controls.Add(Me.txtestado)
        Me.GroupBox3.Controls.Add(Me.txtcp)
        Me.GroupBox3.Controls.Add(Me.txtcolonia)
        Me.GroupBox3.Controls.Add(Me.txtdirecion)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.HorizontalScrollbarBarColor = True
        Me.GroupBox3.HorizontalScrollbarHighlightOnWheel = False
        Me.GroupBox3.HorizontalScrollbarSize = 10
        Me.GroupBox3.Location = New System.Drawing.Point(29, 115)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(887, 164)
        Me.GroupBox3.TabIndex = 61
        Me.GroupBox3.VerticalScrollbarBarColor = True
        Me.GroupBox3.VerticalScrollbarHighlightOnWheel = False
        Me.GroupBox3.VerticalScrollbarSize = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(12, 119)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 19)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "e-Mail:"
        '
        'txtEmail
        '
        '
        '
        '
        Me.txtEmail.CustomButton.Image = Nothing
        Me.txtEmail.CustomButton.Location = New System.Drawing.Point(530, 2)
        Me.txtEmail.CustomButton.Name = ""
        Me.txtEmail.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmail.CustomButton.TabIndex = 1
        Me.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmail.CustomButton.UseSelectable = True
        Me.txtEmail.CustomButton.Visible = False
        Me.txtEmail.Lines = New String(-1) {}
        Me.txtEmail.Location = New System.Drawing.Point(93, 116)
        Me.txtEmail.MaxLength = 32767
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.SelectionLength = 0
        Me.txtEmail.SelectionStart = 0
        Me.txtEmail.ShortcutsEnabled = True
        Me.txtEmail.Size = New System.Drawing.Size(550, 22)
        Me.txtEmail.TabIndex = 43
        Me.txtEmail.UseSelectable = True
        Me.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Nombre:"
        '
        'LblCliente
        '
        Me.LblCliente.AutoSize = True
        Me.LblCliente.Location = New System.Drawing.Point(98, 15)
        Me.LblCliente.Name = "LblCliente"
        Me.LblCliente.Size = New System.Drawing.Size(0, 0)
        Me.LblCliente.TabIndex = 41
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(12, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 19)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Cliente ID:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(407, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 19)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Ciudad:"
        '
        'txtCiudad
        '
        '
        '
        '
        Me.txtCiudad.CustomButton.Image = Nothing
        Me.txtCiudad.CustomButton.Location = New System.Drawing.Point(145, 2)
        Me.txtCiudad.CustomButton.Name = ""
        Me.txtCiudad.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtCiudad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCiudad.CustomButton.TabIndex = 1
        Me.txtCiudad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCiudad.CustomButton.UseSelectable = True
        Me.txtCiudad.CustomButton.Visible = False
        Me.txtCiudad.Lines = New String(-1) {}
        Me.txtCiudad.Location = New System.Drawing.Point(478, 34)
        Me.txtCiudad.MaxLength = 32767
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCiudad.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCiudad.SelectedText = ""
        Me.txtCiudad.SelectionLength = 0
        Me.txtCiudad.SelectionStart = 0
        Me.txtCiudad.ShortcutsEnabled = True
        Me.txtCiudad.Size = New System.Drawing.Size(165, 22)
        Me.txtCiudad.TabIndex = 38
        Me.txtCiudad.UseSelectable = True
        Me.txtCiudad.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCiudad.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'TxtRFC
        '
        '
        '
        '
        Me.TxtRFC.CustomButton.Image = Nothing
        Me.TxtRFC.CustomButton.Location = New System.Drawing.Point(125, 2)
        Me.TxtRFC.CustomButton.Name = ""
        Me.TxtRFC.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.TxtRFC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TxtRFC.CustomButton.TabIndex = 1
        Me.TxtRFC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TxtRFC.CustomButton.UseSelectable = True
        Me.TxtRFC.CustomButton.Visible = False
        Me.TxtRFC.Lines = New String(-1) {}
        Me.TxtRFC.Location = New System.Drawing.Point(730, 88)
        Me.TxtRFC.MaxLength = 32767
        Me.TxtRFC.Name = "TxtRFC"
        Me.TxtRFC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtRFC.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtRFC.SelectedText = ""
        Me.TxtRFC.SelectionLength = 0
        Me.TxtRFC.SelectionStart = 0
        Me.TxtRFC.ShortcutsEnabled = True
        Me.TxtRFC.Size = New System.Drawing.Size(145, 22)
        Me.TxtRFC.TabIndex = 37
        Me.TxtRFC.UseSelectable = True
        Me.TxtRFC.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TxtRFC.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(670, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 19)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "R.F.C.:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 19)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "N° Ext.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(407, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 19)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Estado:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(661, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 19)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Código Postal:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(255, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 19)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Colonia:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 19)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Dirección:"
        '
        'txtNumero
        '
        '
        '
        '
        Me.txtNumero.CustomButton.Image = Nothing
        Me.txtNumero.CustomButton.Location = New System.Drawing.Point(87, 2)
        Me.txtNumero.CustomButton.Name = ""
        Me.txtNumero.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtNumero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNumero.CustomButton.TabIndex = 1
        Me.txtNumero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNumero.CustomButton.UseSelectable = True
        Me.txtNumero.CustomButton.Visible = False
        Me.txtNumero.Lines = New String(-1) {}
        Me.txtNumero.Location = New System.Drawing.Point(93, 88)
        Me.txtNumero.MaxLength = 32767
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumero.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumero.SelectedText = ""
        Me.txtNumero.SelectionLength = 0
        Me.txtNumero.SelectionStart = 0
        Me.txtNumero.ShortcutsEnabled = True
        Me.txtNumero.Size = New System.Drawing.Size(107, 22)
        Me.txtNumero.TabIndex = 29
        Me.txtNumero.UseSelectable = True
        Me.txtNumero.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNumero.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtnombre
        '
        '
        '
        '
        Me.txtnombre.CustomButton.Image = Nothing
        Me.txtnombre.CustomButton.Location = New System.Drawing.Point(262, 2)
        Me.txtnombre.CustomButton.Name = ""
        Me.txtnombre.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtnombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtnombre.CustomButton.TabIndex = 1
        Me.txtnombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtnombre.CustomButton.UseSelectable = True
        Me.txtnombre.CustomButton.Visible = False
        Me.txtnombre.Lines = New String(-1) {}
        Me.txtnombre.Location = New System.Drawing.Point(93, 36)
        Me.txtnombre.MaxLength = 32767
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtnombre.SelectedText = ""
        Me.txtnombre.SelectionLength = 0
        Me.txtnombre.SelectionStart = 0
        Me.txtnombre.ShortcutsEnabled = True
        Me.txtnombre.Size = New System.Drawing.Size(282, 22)
        Me.txtnombre.TabIndex = 28
        Me.txtnombre.UseSelectable = True
        Me.txtnombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtnombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtestado
        '
        '
        '
        '
        Me.txtestado.CustomButton.Image = Nothing
        Me.txtestado.CustomButton.Location = New System.Drawing.Point(145, 2)
        Me.txtestado.CustomButton.Name = ""
        Me.txtestado.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtestado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtestado.CustomButton.TabIndex = 1
        Me.txtestado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtestado.CustomButton.UseSelectable = True
        Me.txtestado.CustomButton.Visible = False
        Me.txtestado.Lines = New String(-1) {}
        Me.txtestado.Location = New System.Drawing.Point(478, 62)
        Me.txtestado.MaxLength = 32767
        Me.txtestado.Name = "txtestado"
        Me.txtestado.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtestado.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtestado.SelectedText = ""
        Me.txtestado.SelectionLength = 0
        Me.txtestado.SelectionStart = 0
        Me.txtestado.ShortcutsEnabled = True
        Me.txtestado.Size = New System.Drawing.Size(165, 22)
        Me.txtestado.TabIndex = 24
        Me.txtestado.UseSelectable = True
        Me.txtestado.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtestado.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtcp
        '
        '
        '
        '
        Me.txtcp.CustomButton.Image = Nothing
        Me.txtcp.CustomButton.Location = New System.Drawing.Point(81, 2)
        Me.txtcp.CustomButton.Name = ""
        Me.txtcp.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtcp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtcp.CustomButton.TabIndex = 1
        Me.txtcp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtcp.CustomButton.UseSelectable = True
        Me.txtcp.CustomButton.Visible = False
        Me.txtcp.Lines = New String(-1) {}
        Me.txtcp.Location = New System.Drawing.Point(774, 36)
        Me.txtcp.MaxLength = 32767
        Me.txtcp.Name = "txtcp"
        Me.txtcp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcp.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtcp.SelectedText = ""
        Me.txtcp.SelectionLength = 0
        Me.txtcp.SelectionStart = 0
        Me.txtcp.ShortcutsEnabled = True
        Me.txtcp.Size = New System.Drawing.Size(101, 22)
        Me.txtcp.TabIndex = 25
        Me.txtcp.UseSelectable = True
        Me.txtcp.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtcp.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtcolonia
        '
        '
        '
        '
        Me.txtcolonia.CustomButton.Image = Nothing
        Me.txtcolonia.CustomButton.Location = New System.Drawing.Point(297, 2)
        Me.txtcolonia.CustomButton.Name = ""
        Me.txtcolonia.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtcolonia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtcolonia.CustomButton.TabIndex = 1
        Me.txtcolonia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtcolonia.CustomButton.UseSelectable = True
        Me.txtcolonia.CustomButton.Visible = False
        Me.txtcolonia.Lines = New String(-1) {}
        Me.txtcolonia.Location = New System.Drawing.Point(326, 90)
        Me.txtcolonia.MaxLength = 32767
        Me.txtcolonia.Name = "txtcolonia"
        Me.txtcolonia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcolonia.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtcolonia.SelectedText = ""
        Me.txtcolonia.SelectionLength = 0
        Me.txtcolonia.SelectionStart = 0
        Me.txtcolonia.ShortcutsEnabled = True
        Me.txtcolonia.Size = New System.Drawing.Size(317, 22)
        Me.txtcolonia.TabIndex = 26
        Me.txtcolonia.UseSelectable = True
        Me.txtcolonia.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtcolonia.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtdirecion
        '
        '
        '
        '
        Me.txtdirecion.CustomButton.Image = Nothing
        Me.txtdirecion.CustomButton.Location = New System.Drawing.Point(262, 2)
        Me.txtdirecion.CustomButton.Name = ""
        Me.txtdirecion.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtdirecion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtdirecion.CustomButton.TabIndex = 1
        Me.txtdirecion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtdirecion.CustomButton.UseSelectable = True
        Me.txtdirecion.CustomButton.Visible = False
        Me.txtdirecion.Lines = New String(-1) {}
        Me.txtdirecion.Location = New System.Drawing.Point(93, 62)
        Me.txtdirecion.MaxLength = 32767
        Me.txtdirecion.Name = "txtdirecion"
        Me.txtdirecion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdirecion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtdirecion.SelectedText = ""
        Me.txtdirecion.SelectionLength = 0
        Me.txtdirecion.SelectionStart = 0
        Me.txtdirecion.ShortcutsEnabled = True
        Me.txtdirecion.Size = New System.Drawing.Size(282, 22)
        Me.txtdirecion.TabIndex = 27
        Me.txtdirecion.UseSelectable = True
        Me.txtdirecion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtdirecion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblPlazo)
        Me.GroupBox2.Controls.Add(Me.CmbCredito)
        Me.GroupBox2.Controls.Add(Me.Lbltipo)
        Me.GroupBox2.Controls.Add(Me.LblFechaLim)
        Me.GroupBox2.Controls.Add(Me.LblFechaFac)
        Me.GroupBox2.Controls.Add(Me.CmbMetodoPago)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.CmdFormaPago)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.CmbUsoCDFI)
        Me.GroupBox2.HorizontalScrollbarBarColor = True
        Me.GroupBox2.HorizontalScrollbarHighlightOnWheel = False
        Me.GroupBox2.HorizontalScrollbarSize = 10
        Me.GroupBox2.Location = New System.Drawing.Point(29, 285)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(887, 135)
        Me.GroupBox2.TabIndex = 62
        Me.GroupBox2.VerticalScrollbarBarColor = True
        Me.GroupBox2.VerticalScrollbarHighlightOnWheel = False
        Me.GroupBox2.VerticalScrollbarSize = 10
        '
        'LblPlazo
        '
        Me.LblPlazo.AutoSize = True
        Me.LblPlazo.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LblPlazo.Location = New System.Drawing.Point(18, 68)
        Me.LblPlazo.Name = "LblPlazo"
        Me.LblPlazo.Size = New System.Drawing.Size(50, 19)
        Me.LblPlazo.TabIndex = 44
        Me.LblPlazo.Text = "Plazo:"
        '
        'CmbCredito
        '
        Me.CmbCredito.FormattingEnabled = True
        Me.CmbCredito.ItemHeight = 23
        Me.CmbCredito.Items.AddRange(New Object() {"8 DIAS DE CREDITO", "15 DIAS DE CREDITO", "21 DIAS DE CREDITO", "30 DIAS DE CREDITO", "PAGO A LA ENTREGA"})
        Me.CmbCredito.Location = New System.Drawing.Point(19, 90)
        Me.CmbCredito.Name = "CmbCredito"
        Me.CmbCredito.Size = New System.Drawing.Size(269, 29)
        Me.CmbCredito.TabIndex = 45
        Me.CmbCredito.UseSelectable = True
        '
        'Lbltipo
        '
        Me.Lbltipo.AutoSize = True
        Me.Lbltipo.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Lbltipo.Location = New System.Drawing.Point(15, 11)
        Me.Lbltipo.Name = "Lbltipo"
        Me.Lbltipo.Size = New System.Drawing.Size(105, 19)
        Me.Lbltipo.TabIndex = 2
        Me.Lbltipo.Text = "Metodo Pago:"
        '
        'LblFechaLim
        '
        Me.LblFechaLim.AutoSize = True
        Me.LblFechaLim.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LblFechaLim.Location = New System.Drawing.Point(648, 50)
        Me.LblFechaLim.Name = "LblFechaLim"
        Me.LblFechaLim.Size = New System.Drawing.Size(96, 19)
        Me.LblFechaLim.TabIndex = 3
        Me.LblFechaLim.Text = "Fecha Limite:"
        '
        'LblFechaFac
        '
        Me.LblFechaFac.AutoSize = True
        Me.LblFechaFac.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LblFechaFac.Location = New System.Drawing.Point(640, 16)
        Me.LblFechaFac.Name = "LblFechaFac"
        Me.LblFechaFac.Size = New System.Drawing.Size(104, 19)
        Me.LblFechaFac.TabIndex = 4
        Me.LblFechaFac.Text = "Fecha Factura:"
        '
        'CmbMetodoPago
        '
        Me.CmbMetodoPago.FormattingEnabled = True
        Me.CmbMetodoPago.ItemHeight = 23
        Me.CmbMetodoPago.Items.AddRange(New Object() {"PUE-Pago en una sola exhibición", "PPD-Pago en parcialidades o diferido"})
        Me.CmbMetodoPago.Location = New System.Drawing.Point(20, 34)
        Me.CmbMetodoPago.Name = "CmbMetodoPago"
        Me.CmbMetodoPago.Size = New System.Drawing.Size(268, 29)
        Me.CmbMetodoPago.TabIndex = 5
        Me.CmbMetodoPago.UseSelectable = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(749, 11)
        Me.DateTimePicker1.MinimumSize = New System.Drawing.Size(0, 29)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(121, 29)
        Me.DateTimePicker1.TabIndex = 6
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(749, 46)
        Me.DateTimePicker2.MinimumSize = New System.Drawing.Size(0, 29)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(121, 29)
        Me.DateTimePicker2.TabIndex = 7
        '
        'CmdFormaPago
        '
        Me.CmdFormaPago.FormattingEnabled = True
        Me.CmdFormaPago.ItemHeight = 23
        Me.CmdFormaPago.Items.AddRange(New Object() {"01-Efectivo", "02-Cheque nominativo", "03-Transferencia electrónica de fondos", "04-Tarjeta de crédito", "05-Monedero electrónico", "06-Dinero electrónico", "08-Vales de despensa", "12-Dación en pago", "13-Pago por subrogación", "14-Pago por consignación", "15-Condonación", "17-Compensación", "23-Novación", "24-Confusión", "25-Remisión de deuda", "26-Prescripción o caducidad", "27-A satisfacción del acreedor", "28-Tarjeta de débito", "29-Tarjeta de servicios", "30-Aplicación de anticipos", "99-Por definir"})
        Me.CmdFormaPago.Location = New System.Drawing.Point(297, 34)
        Me.CmdFormaPago.Name = "CmdFormaPago"
        Me.CmdFormaPago.Size = New System.Drawing.Size(336, 29)
        Me.CmdFormaPago.TabIndex = 34
        Me.CmdFormaPago.UseSelectable = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label12.Location = New System.Drawing.Point(294, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 19)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Forma de Pago:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label17.Location = New System.Drawing.Point(297, 68)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 19)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Uso del CFDI:"
        '
        'CmbUsoCDFI
        '
        Me.CmbUsoCDFI.FormattingEnabled = True
        Me.CmbUsoCDFI.ItemHeight = 23
        Me.CmbUsoCDFI.Items.AddRange(New Object() {"G01-Adquisición de mercancias", "G02-Devoluciones, descuentos o bonificaciones", "G03-Gastos en general", "I01-Construcciones", "I02-Mobilario y equipo de oficina por inversiones", "I03-Equipo de transporte", "I04-Equipo de computo y accesorios", "I05-Dados, troqueles, moldes, matrices y herramental", "I06-Comunicaciones telefónicas", "I07-Comunicaciones satelitales", "I08-Otra maquinaria y equipo", "D01-Honorarios médicos, dentales y gastos hospitalarios", "D02-Gastos médicos por incapacidad o discapacidad", "D03-Gastos funerales", "D04-Donativos", "D05-Intereses reales efectivamente pagados por créditos hipotecarios (casa habita" &
                "ción)", "D06-Aportaciones voluntarias al SAR", "D07-Primas por seguros de gastos médicos", "D08-Gastos de transportación escolar obligatoria", "D09-Depósitos en cuentas para el ahorro, primas que tengan como base planes de pe" &
                "nsiones", "D10-Pagos por servicios educativos (colegiaturas)", "P01-Por definir"})
        Me.CmbUsoCDFI.Location = New System.Drawing.Point(299, 90)
        Me.CmbUsoCDFI.Name = "CmbUsoCDFI"
        Me.CmbUsoCDFI.Size = New System.Drawing.Size(571, 29)
        Me.CmbUsoCDFI.TabIndex = 43
        Me.CmbUsoCDFI.UseSelectable = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Btn_cfdi3_3)
        Me.GroupBox4.Controls.Add(Me.lblnoregistros)
        Me.GroupBox4.Controls.Add(Me.LblNRegistros)
        Me.GroupBox4.Controls.Add(Me.CmdFactura)
        Me.GroupBox4.Controls.Add(Me.CmdLimpiar)
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Controls.Add(Me.GbTicket)
        Me.GroupBox4.Controls.Add(Me.TxtSubtotal)
        Me.GroupBox4.Controls.Add(Me.TxtIVA)
        Me.GroupBox4.Controls.Add(Me.TxtTotal)
        Me.GroupBox4.Controls.Add(Me.TxtFolio)
        Me.GroupBox4.Controls.Add(Me.LblFolio)
        Me.GroupBox4.Controls.Add(Me.LblSubTotal)
        Me.GroupBox4.Controls.Add(Me.LblIVA)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.HorizontalScrollbarBarColor = True
        Me.GroupBox4.HorizontalScrollbarHighlightOnWheel = False
        Me.GroupBox4.HorizontalScrollbarSize = 10
        Me.GroupBox4.Location = New System.Drawing.Point(29, 426)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(887, 409)
        Me.GroupBox4.TabIndex = 63
        Me.GroupBox4.VerticalScrollbarBarColor = True
        Me.GroupBox4.VerticalScrollbarHighlightOnWheel = False
        Me.GroupBox4.VerticalScrollbarSize = 10
        '
        'Btn_cfdi3_3
        '
        Me.Btn_cfdi3_3.Location = New System.Drawing.Point(749, 328)
        Me.Btn_cfdi3_3.Name = "Btn_cfdi3_3"
        Me.Btn_cfdi3_3.Size = New System.Drawing.Size(127, 31)
        Me.Btn_cfdi3_3.TabIndex = 32
        Me.Btn_cfdi3_3.Text = "F9-Generar Factura"
        Me.Btn_cfdi3_3.UseSelectable = True
        '
        'lblnoregistros
        '
        Me.lblnoregistros.AutoSize = True
        Me.lblnoregistros.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblnoregistros.Location = New System.Drawing.Point(630, 24)
        Me.lblnoregistros.Name = "lblnoregistros"
        Me.lblnoregistros.Size = New System.Drawing.Size(160, 19)
        Me.lblnoregistros.TabIndex = 30
        Me.lblnoregistros.Text = "N° Partidas a Facturar:"
        '
        'LblNRegistros
        '
        Me.LblNRegistros.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.LblNRegistros.Location = New System.Drawing.Point(800, 21)
        Me.LblNRegistros.Name = "LblNRegistros"
        Me.LblNRegistros.Size = New System.Drawing.Size(81, 23)
        Me.LblNRegistros.TabIndex = 29
        Me.LblNRegistros.Text = "0"
        Me.LblNRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmdFactura
        '
        Me.CmdFactura.Location = New System.Drawing.Point(435, 340)
        Me.CmdFactura.Name = "CmdFactura"
        Me.CmdFactura.Size = New System.Drawing.Size(182, 30)
        Me.CmdFactura.TabIndex = 28
        Me.CmdFactura.Text = "F9 - Generar Factura"
        Me.CmdFactura.UseSelectable = True
        Me.CmdFactura.Visible = False
        '
        'CmdLimpiar
        '
        Me.CmdLimpiar.Location = New System.Drawing.Point(10, 15)
        Me.CmdLimpiar.Name = "CmdLimpiar"
        Me.CmdLimpiar.Size = New System.Drawing.Size(174, 30)
        Me.CmdLimpiar.TabIndex = 27
        Me.CmdLimpiar.Text = "F3 - Limpiar Datos"
        Me.CmdLimpiar.UseSelectable = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CmdGenerarMostrador)
        Me.GroupBox6.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox6.Controls.Add(Me.CbMostrador)
        Me.GroupBox6.HorizontalScrollbarBarColor = True
        Me.GroupBox6.HorizontalScrollbarHighlightOnWheel = False
        Me.GroupBox6.HorizontalScrollbarSize = 10
        Me.GroupBox6.Location = New System.Drawing.Point(188, 255)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(182, 125)
        Me.GroupBox6.TabIndex = 24
        Me.GroupBox6.VerticalScrollbarBarColor = True
        Me.GroupBox6.VerticalScrollbarHighlightOnWheel = False
        Me.GroupBox6.VerticalScrollbarSize = 10
        '
        'CmdGenerarMostrador
        '
        Me.CmdGenerarMostrador.Location = New System.Drawing.Point(33, 85)
        Me.CmdGenerarMostrador.Name = "CmdGenerarMostrador"
        Me.CmdGenerarMostrador.Size = New System.Drawing.Size(116, 30)
        Me.CmdGenerarMostrador.TabIndex = 26
        Me.CmdGenerarMostrador.Text = "Generar"
        Me.CmdGenerarMostrador.UseSelectable = True
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(19, 40)
        Me.DateTimePicker3.MinimumSize = New System.Drawing.Size(4, 29)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(145, 29)
        Me.DateTimePicker3.TabIndex = 29
        '
        'CbMostrador
        '
        Me.CbMostrador.AutoSize = True
        Me.CbMostrador.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold
        Me.CbMostrador.Location = New System.Drawing.Point(6, 14)
        Me.CbMostrador.Name = "CbMostrador"
        Me.CbMostrador.Size = New System.Drawing.Size(125, 15)
        Me.CbMostrador.TabIndex = 27
        Me.CbMostrador.Text = "Factura Mostrador"
        Me.CbMostrador.UseSelectable = True
        '
        'GbTicket
        '
        Me.GbTicket.Controls.Add(Me.lv_ticket)
        Me.GbTicket.Controls.Add(Me.Label10)
        Me.GbTicket.Controls.Add(Me.TxtTikect)
        Me.GbTicket.HorizontalScrollbarBarColor = True
        Me.GbTicket.HorizontalScrollbarHighlightOnWheel = False
        Me.GbTicket.HorizontalScrollbarSize = 10
        Me.GbTicket.Location = New System.Drawing.Point(11, 255)
        Me.GbTicket.Name = "GbTicket"
        Me.GbTicket.Size = New System.Drawing.Size(171, 151)
        Me.GbTicket.TabIndex = 23
        Me.GbTicket.VerticalScrollbarBarColor = True
        Me.GbTicket.VerticalScrollbarHighlightOnWheel = False
        Me.GbTicket.VerticalScrollbarSize = 10
        '
        'lv_ticket
        '
        Me.lv_ticket.FormattingEnabled = True
        Me.lv_ticket.ItemHeight = 16
        Me.lv_ticket.Location = New System.Drawing.Point(7, 44)
        Me.lv_ticket.Name = "lv_ticket"
        Me.lv_ticket.Size = New System.Drawing.Size(154, 100)
        Me.lv_ticket.TabIndex = 31
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label10.Location = New System.Drawing.Point(4, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 19)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Ticket"
        '
        'TxtTikect
        '
        '
        '
        '
        Me.TxtTikect.CustomButton.Image = Nothing
        Me.TxtTikect.CustomButton.Location = New System.Drawing.Point(80, 2)
        Me.TxtTikect.CustomButton.Name = ""
        Me.TxtTikect.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.TxtTikect.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TxtTikect.CustomButton.TabIndex = 1
        Me.TxtTikect.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TxtTikect.CustomButton.UseSelectable = True
        Me.TxtTikect.CustomButton.Visible = False
        Me.TxtTikect.Lines = New String(-1) {}
        Me.TxtTikect.Location = New System.Drawing.Point(61, 16)
        Me.TxtTikect.MaxLength = 32767
        Me.TxtTikect.Name = "TxtTikect"
        Me.TxtTikect.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtTikect.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtTikect.SelectedText = ""
        Me.TxtTikect.SelectionLength = 0
        Me.TxtTikect.SelectionStart = 0
        Me.TxtTikect.ShortcutsEnabled = True
        Me.TxtTikect.Size = New System.Drawing.Size(100, 22)
        Me.TxtTikect.TabIndex = 25
        Me.TxtTikect.UseSelectable = True
        Me.TxtTikect.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TxtTikect.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'TxtSubtotal
        '
        '
        '
        '
        Me.TxtSubtotal.CustomButton.Image = Nothing
        Me.TxtSubtotal.CustomButton.Location = New System.Drawing.Point(101, 2)
        Me.TxtSubtotal.CustomButton.Name = ""
        Me.TxtSubtotal.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.TxtSubtotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TxtSubtotal.CustomButton.TabIndex = 1
        Me.TxtSubtotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TxtSubtotal.CustomButton.UseSelectable = True
        Me.TxtSubtotal.CustomButton.Visible = False
        Me.TxtSubtotal.Enabled = False
        Me.TxtSubtotal.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TxtSubtotal.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.TxtSubtotal.Lines = New String() {"0.0000"}
        Me.TxtSubtotal.Location = New System.Drawing.Point(385, 283)
        Me.TxtSubtotal.MaxLength = 32767
        Me.TxtSubtotal.Name = "TxtSubtotal"
        Me.TxtSubtotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSubtotal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtSubtotal.SelectedText = ""
        Me.TxtSubtotal.SelectionLength = 0
        Me.TxtSubtotal.SelectionStart = 0
        Me.TxtSubtotal.ShortcutsEnabled = True
        Me.TxtSubtotal.Size = New System.Drawing.Size(119, 22)
        Me.TxtSubtotal.TabIndex = 22
        Me.TxtSubtotal.Text = "0.0000"
        Me.TxtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtSubtotal.UseSelectable = True
        Me.TxtSubtotal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TxtSubtotal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'TxtIVA
        '
        '
        '
        '
        Me.TxtIVA.CustomButton.Image = Nothing
        Me.TxtIVA.CustomButton.Location = New System.Drawing.Point(101, 2)
        Me.TxtIVA.CustomButton.Name = ""
        Me.TxtIVA.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.TxtIVA.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TxtIVA.CustomButton.TabIndex = 1
        Me.TxtIVA.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TxtIVA.CustomButton.UseSelectable = True
        Me.TxtIVA.CustomButton.Visible = False
        Me.TxtIVA.Enabled = False
        Me.TxtIVA.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TxtIVA.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.TxtIVA.Lines = New String() {"0.0000"}
        Me.TxtIVA.Location = New System.Drawing.Point(570, 283)
        Me.TxtIVA.MaxLength = 32767
        Me.TxtIVA.Name = "TxtIVA"
        Me.TxtIVA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtIVA.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtIVA.SelectedText = ""
        Me.TxtIVA.SelectionLength = 0
        Me.TxtIVA.SelectionStart = 0
        Me.TxtIVA.ShortcutsEnabled = True
        Me.TxtIVA.Size = New System.Drawing.Size(121, 22)
        Me.TxtIVA.TabIndex = 21
        Me.TxtIVA.Text = "0.0000"
        Me.TxtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtIVA.UseSelectable = True
        Me.TxtIVA.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TxtIVA.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'TxtTotal
        '
        '
        '
        '
        Me.TxtTotal.CustomButton.Image = Nothing
        Me.TxtTotal.CustomButton.Location = New System.Drawing.Point(101, 2)
        Me.TxtTotal.CustomButton.Name = ""
        Me.TxtTotal.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.TxtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TxtTotal.CustomButton.TabIndex = 1
        Me.TxtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TxtTotal.CustomButton.UseSelectable = True
        Me.TxtTotal.CustomButton.Visible = False
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TxtTotal.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.TxtTotal.Lines = New String() {"0.0000"}
        Me.TxtTotal.Location = New System.Drawing.Point(754, 283)
        Me.TxtTotal.MaxLength = 32767
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtTotal.SelectedText = ""
        Me.TxtTotal.SelectionLength = 0
        Me.TxtTotal.SelectionStart = 0
        Me.TxtTotal.ShortcutsEnabled = True
        Me.TxtTotal.Size = New System.Drawing.Size(121, 22)
        Me.TxtTotal.TabIndex = 20
        Me.TxtTotal.Text = "0.0000"
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTotal.UseSelectable = True
        Me.TxtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TxtTotal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'TxtFolio
        '
        '
        '
        '
        Me.TxtFolio.CustomButton.Image = Nothing
        Me.TxtFolio.CustomButton.Location = New System.Drawing.Point(80, 2)
        Me.TxtFolio.CustomButton.Name = ""
        Me.TxtFolio.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.TxtFolio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TxtFolio.CustomButton.TabIndex = 1
        Me.TxtFolio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TxtFolio.CustomButton.UseSelectable = True
        Me.TxtFolio.CustomButton.Visible = False
        Me.TxtFolio.Enabled = False
        Me.TxtFolio.Lines = New String(-1) {}
        Me.TxtFolio.Location = New System.Drawing.Point(417, 19)
        Me.TxtFolio.MaxLength = 32767
        Me.TxtFolio.Name = "TxtFolio"
        Me.TxtFolio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtFolio.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtFolio.SelectedText = ""
        Me.TxtFolio.SelectionLength = 0
        Me.TxtFolio.SelectionStart = 0
        Me.TxtFolio.ShortcutsEnabled = True
        Me.TxtFolio.Size = New System.Drawing.Size(100, 22)
        Me.TxtFolio.TabIndex = 1
        Me.TxtFolio.UseSelectable = True
        Me.TxtFolio.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TxtFolio.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'LblFolio
        '
        Me.LblFolio.AutoSize = True
        Me.LblFolio.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LblFolio.Location = New System.Drawing.Point(308, 21)
        Me.LblFolio.Name = "LblFolio"
        Me.LblFolio.Size = New System.Drawing.Size(99, 19)
        Me.LblFolio.TabIndex = 0
        Me.LblFolio.Text = "Folio Factura:"
        '
        'LblSubTotal
        '
        Me.LblSubTotal.AutoSize = True
        Me.LblSubTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LblSubTotal.Location = New System.Drawing.Point(385, 258)
        Me.LblSubTotal.Name = "LblSubTotal"
        Me.LblSubTotal.Size = New System.Drawing.Size(77, 19)
        Me.LblSubTotal.TabIndex = 19
        Me.LblSubTotal.Text = "Sub-Total:"
        '
        'LblIVA
        '
        Me.LblIVA.AutoSize = True
        Me.LblIVA.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LblIVA.Location = New System.Drawing.Point(570, 258)
        Me.LblIVA.Name = "LblIVA"
        Me.LblIVA.Size = New System.Drawing.Size(47, 19)
        Me.LblIVA.TabIndex = 18
        Me.LblIVA.Text = "I.V.A.:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label8.Location = New System.Drawing.Point(754, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "TOTAL:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.foliio, Me.Cantidad, Me.Descripcion, Me.Precio, Me.Subtotal, Me.Fecha, Me.precioCosto, Me.subtotalCosto, Me.IdProducto, Me.numeroFactura, Me.Id_Producto, Me.Clave_Producto, Me.Clave_Unidad, Me.TasaCero, Me.IVA})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(10, 50)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(871, 199)
        Me.DataGridView1.TabIndex = 0
        '
        'foliio
        '
        Me.foliio.HeaderText = "folio"
        Me.foliio.Name = "foliio"
        Me.foliio.ReadOnly = True
        Me.foliio.Visible = False
        Me.foliio.Width = 85
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle11
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 98
        '
        'Descripcion
        '
        Me.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Descripcion.HeaderText = "Concepto"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.NullValue = Nothing
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle12
        Me.Precio.HeaderText = "Precio Unitario"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 129
        '
        'Subtotal
        '
        Me.Subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.NullValue = Nothing
        Me.Subtotal.DefaultCellStyle = DataGridViewCellStyle13
        Me.Subtotal.HeaderText = "Importe"
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        Me.Subtotal.Width = 93
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Visible = False
        Me.Fecha.Width = 85
        '
        'precioCosto
        '
        Me.precioCosto.HeaderText = "precioCosto"
        Me.precioCosto.Name = "precioCosto"
        Me.precioCosto.ReadOnly = True
        Me.precioCosto.Visible = False
        '
        'subtotalCosto
        '
        Me.subtotalCosto.HeaderText = "subtotalCosto"
        Me.subtotalCosto.Name = "subtotalCosto"
        Me.subtotalCosto.ReadOnly = True
        Me.subtotalCosto.Visible = False
        '
        'IdProducto
        '
        Me.IdProducto.HeaderText = "clave_producto"
        Me.IdProducto.Name = "IdProducto"
        Me.IdProducto.ReadOnly = True
        Me.IdProducto.Visible = False
        '
        'numeroFactura
        '
        Me.numeroFactura.HeaderText = "numeroFactura"
        Me.numeroFactura.Name = "numeroFactura"
        Me.numeroFactura.ReadOnly = True
        Me.numeroFactura.Visible = False
        '
        'Id_Producto
        '
        Me.Id_Producto.HeaderText = "Id_Producto"
        Me.Id_Producto.Name = "Id_Producto"
        Me.Id_Producto.ReadOnly = True
        Me.Id_Producto.Visible = False
        Me.Id_Producto.Width = 85
        '
        'Clave_Producto
        '
        Me.Clave_Producto.HeaderText = "ClaveProducto"
        Me.Clave_Producto.Name = "Clave_Producto"
        Me.Clave_Producto.ReadOnly = True
        Me.Clave_Producto.Visible = False
        '
        'Clave_Unidad
        '
        Me.Clave_Unidad.HeaderText = "ClaveUnidad"
        Me.Clave_Unidad.Name = "Clave_Unidad"
        Me.Clave_Unidad.ReadOnly = True
        Me.Clave_Unidad.Visible = False
        '
        'TasaCero
        '
        Me.TasaCero.HeaderText = "TasaCero"
        Me.TasaCero.Name = "TasaCero"
        Me.TasaCero.ReadOnly = True
        Me.TasaCero.Visible = False
        '
        'IVA
        '
        Me.IVA.HeaderText = "iva"
        Me.IVA.Name = "IVA"
        Me.IVA.ReadOnly = True
        Me.IVA.Visible = False
        '
        'PrBImprimiendo
        '
        Me.PrBImprimiendo.Location = New System.Drawing.Point(29, 841)
        Me.PrBImprimiendo.Name = "PrBImprimiendo"
        Me.PrBImprimiendo.Size = New System.Drawing.Size(887, 18)
        Me.PrBImprimiendo.TabIndex = 64
        Me.PrBImprimiendo.UseWaitCursor = True
        Me.PrBImprimiendo.Visible = False
        '
        'CmdBuscar
        '
        Me.CmdBuscar.Location = New System.Drawing.Point(29, 70)
        Me.CmdBuscar.Name = "CmdBuscar"
        Me.CmdBuscar.Size = New System.Drawing.Size(137, 39)
        Me.CmdBuscar.TabIndex = 65
        Me.CmdBuscar.Text = "F2 - Buscar Cliente"
        Me.CmdBuscar.UseSelectable = True
        '
        'ChkTasaCero
        '
        Me.ChkTasaCero.AutoSize = True
        Me.ChkTasaCero.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold
        Me.ChkTasaCero.Location = New System.Drawing.Point(488, 31)
        Me.ChkTasaCero.Name = "ChkTasaCero"
        Me.ChkTasaCero.Size = New System.Drawing.Size(110, 15)
        Me.ChkTasaCero.TabIndex = 66
        Me.ChkTasaCero.Text = "Factura Tasa 0%"
        Me.ChkTasaCero.UseSelectable = True
        Me.ChkTasaCero.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label14.Location = New System.Drawing.Point(561, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 19)
        Me.Label14.TabIndex = 67
        Me.Label14.Text = "Banco"
        Me.Label14.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label13.Location = New System.Drawing.Point(392, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 19)
        Me.Label13.TabIndex = 68
        Me.Label13.Text = "4 Dig. Cta.:"
        Me.Label13.Visible = False
        '
        'FrmFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 882)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ChkTasaCero)
        Me.Controls.Add(Me.CmdBuscar)
        Me.Controls.Add(Me.PrBImprimiendo)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cmdUpdateUUID)
        Me.Controls.Add(Me.CmdSalir)
        Me.Controls.Add(Me.CmbBanco)
        Me.Controls.Add(Me.txtCuenta)
        Me.Name = "FrmFacturacion"
        Me.Text = "Facturaciòn"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GbTicket.ResumeLayout(False)
        Me.GbTicket.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdUpdateUUID As MetroFramework.Controls.MetroButton
    Friend WithEvents CmdSalir As MetroFramework.Controls.MetroButton
    Friend WithEvents txtCuenta As MetroFramework.Controls.MetroTextBox
    Friend WithEvents GroupBox3 As MetroFramework.Controls.MetroPanel
    Friend WithEvents Label11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents LblCliente As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCiudad As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TxtRFC As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNumero As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtnombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtestado As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtcp As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtcolonia As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtdirecion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents GroupBox2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents LblPlazo As MetroFramework.Controls.MetroLabel
    Friend WithEvents CmbCredito As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Lbltipo As MetroFramework.Controls.MetroLabel
    Friend WithEvents LblFechaLim As MetroFramework.Controls.MetroLabel
    Friend WithEvents LblFechaFac As MetroFramework.Controls.MetroLabel
    Friend WithEvents CmbMetodoPago As MetroFramework.Controls.MetroComboBox
    Friend WithEvents DateTimePicker1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents DateTimePicker2 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents CmdFormaPago As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox4 As MetroFramework.Controls.MetroPanel
    Friend WithEvents Btn_cfdi3_3 As MetroFramework.Controls.MetroButton
    Friend WithEvents lblnoregistros As MetroFramework.Controls.MetroLabel
    Friend WithEvents LblNRegistros As MetroFramework.Controls.MetroLabel
    Friend WithEvents CmdFactura As MetroFramework.Controls.MetroButton
    Friend WithEvents CmdLimpiar As MetroFramework.Controls.MetroButton
    Friend WithEvents GroupBox6 As MetroFramework.Controls.MetroPanel
    Friend WithEvents CmdGenerarMostrador As MetroFramework.Controls.MetroButton
    Friend WithEvents DateTimePicker3 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents CbMostrador As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents GbTicket As MetroFramework.Controls.MetroPanel
    Friend WithEvents lv_ticket As ListBox
    Friend WithEvents Label10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TxtTikect As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TxtSubtotal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TxtIVA As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TxtTotal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TxtFolio As MetroFramework.Controls.MetroTextBox
    Friend WithEvents LblFolio As MetroFramework.Controls.MetroLabel
    Friend WithEvents LblSubTotal As MetroFramework.Controls.MetroLabel
    Friend WithEvents LblIVA As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents DataGridView1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents foliio As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents precioCosto As DataGridViewTextBoxColumn
    Friend WithEvents subtotalCosto As DataGridViewTextBoxColumn
    Friend WithEvents IdProducto As DataGridViewTextBoxColumn
    Friend WithEvents numeroFactura As DataGridViewTextBoxColumn
    Friend WithEvents Id_Producto As DataGridViewTextBoxColumn
    Friend WithEvents Clave_Producto As DataGridViewTextBoxColumn
    Friend WithEvents Clave_Unidad As DataGridViewTextBoxColumn
    Friend WithEvents TasaCero As DataGridViewTextBoxColumn
    Friend WithEvents IVA As DataGridViewTextBoxColumn
    Friend WithEvents PrBImprimiendo As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents CmdBuscar As MetroFramework.Controls.MetroButton
    Friend WithEvents ChkTasaCero As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Label14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents CmbBanco As MetroFramework.Controls.MetroComboBox
    Friend WithEvents CmbUsoCDFI As MetroFramework.Controls.MetroComboBox
End Class
