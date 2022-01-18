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
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.lblnoregistros = New MetroFramework.Controls.MetroLabel()
        Me.LblNRegistros = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox6 = New MetroFramework.Controls.MetroPanel()
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
        Me.ChkTasaCero = New MetroFramework.Controls.MetroCheckBox()
        Me.Label14 = New MetroFramework.Controls.MetroLabel()
        Me.Label13 = New MetroFramework.Controls.MetroLabel()
        Me.btnUpdateUUID = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnGenerarMostrador = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.GroupBox4.SuspendLayout
        Me.GroupBox6.SuspendLayout
        Me.GbTicket.SuspendLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'CmbBanco
        '
        Me.CmbBanco.ItemHeight = 24
        Me.CmbBanco.Items.AddRange(New Object() {"BBVA Bancomer", "Banamex", "HSBC", "Scotia Bank", "Banco del Bajio", "Santander Serfin", "Inbursa", "Banorte"})
        Me.CmbBanco.Location = New System.Drawing.Point(1007, 104)
        Me.CmbBanco.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbBanco.Name = "CmbBanco"
        Me.CmbBanco.Size = New System.Drawing.Size(215, 30)
        Me.CmbBanco.TabIndex = 56
        Me.CmbBanco.UseSelectable = true
        Me.CmbBanco.Visible = false
        '
        'txtCuenta
        '
        '
        '
        '
        Me.txtCuenta.CustomButton.Image = Nothing
        Me.txtCuenta.CustomButton.Location = New System.Drawing.Point(64, 1)
        Me.txtCuenta.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCuenta.CustomButton.Name = ""
        Me.txtCuenta.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtCuenta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCuenta.CustomButton.TabIndex = 1
        Me.txtCuenta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCuenta.CustomButton.UseSelectable = true
        Me.txtCuenta.CustomButton.Visible = false
        Me.txtCuenta.Lines = New String(-1) {}
        Me.txtCuenta.Location = New System.Drawing.Point(824, 104)
        Me.txtCuenta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCuenta.MaxLength = 4
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCuenta.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCuenta.SelectedText = ""
        Me.txtCuenta.SelectionLength = 0
        Me.txtCuenta.SelectionStart = 0
        Me.txtCuenta.ShortcutsEnabled = true
        Me.txtCuenta.Size = New System.Drawing.Size(88, 25)
        Me.txtCuenta.TabIndex = 57
        Me.txtCuenta.UseSelectable = true
        Me.txtCuenta.Visible = false
        Me.txtCuenta.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtCuenta.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.GroupBox3.Enabled = false
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.HorizontalScrollbarBarColor = true
        Me.GroupBox3.HorizontalScrollbarHighlightOnWheel = false
        Me.GroupBox3.HorizontalScrollbarSize = 12
        Me.GroupBox3.Location = New System.Drawing.Point(39, 142)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1183, 202)
        Me.GroupBox3.TabIndex = 61
        Me.GroupBox3.VerticalScrollbarBarColor = true
        Me.GroupBox3.VerticalScrollbarHighlightOnWheel = false
        Me.GroupBox3.VerticalScrollbarSize = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(16, 146)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 20)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "e-Mail:"
        '
        'txtEmail
        '
        '
        '
        '
        Me.txtEmail.CustomButton.Image = Nothing
        Me.txtEmail.CustomButton.Location = New System.Drawing.Point(707, 1)
        Me.txtEmail.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.CustomButton.Name = ""
        Me.txtEmail.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmail.CustomButton.TabIndex = 1
        Me.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmail.CustomButton.UseSelectable = true
        Me.txtEmail.CustomButton.Visible = false
        Me.txtEmail.Lines = New String(-1) {}
        Me.txtEmail.Location = New System.Drawing.Point(124, 143)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.MaxLength = 32767
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.SelectionLength = 0
        Me.txtEmail.SelectionStart = 0
        Me.txtEmail.ShortcutsEnabled = true
        Me.txtEmail.Size = New System.Drawing.Size(733, 27)
        Me.txtEmail.TabIndex = 43
        Me.txtEmail.UseSelectable = true
        Me.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Nombre:"
        '
        'LblCliente
        '
        Me.LblCliente.AutoSize = true
        Me.LblCliente.Location = New System.Drawing.Point(131, 18)
        Me.LblCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCliente.Name = "LblCliente"
        Me.LblCliente.Size = New System.Drawing.Size(0, 0)
        Me.LblCliente.TabIndex = 41
        '
        'Label15
        '
        Me.Label15.AutoSize = true
        Me.Label15.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(16, 18)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 20)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Cliente ID:"
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(543, 46)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 20)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Ciudad:"
        '
        'txtCiudad
        '
        '
        '
        '
        Me.txtCiudad.CustomButton.Image = Nothing
        Me.txtCiudad.CustomButton.Location = New System.Drawing.Point(194, 1)
        Me.txtCiudad.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCiudad.CustomButton.Name = ""
        Me.txtCiudad.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtCiudad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCiudad.CustomButton.TabIndex = 1
        Me.txtCiudad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCiudad.CustomButton.UseSelectable = true
        Me.txtCiudad.CustomButton.Visible = false
        Me.txtCiudad.Lines = New String(-1) {}
        Me.txtCiudad.Location = New System.Drawing.Point(637, 42)
        Me.txtCiudad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCiudad.MaxLength = 32767
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCiudad.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCiudad.SelectedText = ""
        Me.txtCiudad.SelectionLength = 0
        Me.txtCiudad.SelectionStart = 0
        Me.txtCiudad.ShortcutsEnabled = true
        Me.txtCiudad.Size = New System.Drawing.Size(220, 27)
        Me.txtCiudad.TabIndex = 38
        Me.txtCiudad.UseSelectable = true
        Me.txtCiudad.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtCiudad.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'TxtRFC
        '
        '
        '
        '
        Me.TxtRFC.CustomButton.Image = Nothing
        Me.TxtRFC.CustomButton.Location = New System.Drawing.Point(167, 1)
        Me.TxtRFC.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRFC.CustomButton.Name = ""
        Me.TxtRFC.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.TxtRFC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TxtRFC.CustomButton.TabIndex = 1
        Me.TxtRFC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TxtRFC.CustomButton.UseSelectable = true
        Me.TxtRFC.CustomButton.Visible = false
        Me.TxtRFC.Lines = New String(-1) {}
        Me.TxtRFC.Location = New System.Drawing.Point(973, 108)
        Me.TxtRFC.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRFC.MaxLength = 32767
        Me.TxtRFC.Name = "TxtRFC"
        Me.TxtRFC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtRFC.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtRFC.SelectedText = ""
        Me.TxtRFC.SelectionLength = 0
        Me.TxtRFC.SelectionStart = 0
        Me.TxtRFC.ShortcutsEnabled = true
        Me.TxtRFC.Size = New System.Drawing.Size(193, 27)
        Me.TxtRFC.TabIndex = 37
        Me.TxtRFC.UseSelectable = true
        Me.TxtRFC.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.TxtRFC.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(893, 112)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 20)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "R.F.C.:"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(16, 112)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 20)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "N° Ext.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(543, 80)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Estado:"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(881, 47)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 20)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Código Postal:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(340, 113)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Colonia:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Dirección:"
        '
        'txtNumero
        '
        '
        '
        '
        Me.txtNumero.CustomButton.Image = Nothing
        Me.txtNumero.CustomButton.Location = New System.Drawing.Point(117, 1)
        Me.txtNumero.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumero.CustomButton.Name = ""
        Me.txtNumero.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtNumero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNumero.CustomButton.TabIndex = 1
        Me.txtNumero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNumero.CustomButton.UseSelectable = true
        Me.txtNumero.CustomButton.Visible = false
        Me.txtNumero.Lines = New String(-1) {}
        Me.txtNumero.Location = New System.Drawing.Point(124, 108)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumero.MaxLength = 32767
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumero.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumero.SelectedText = ""
        Me.txtNumero.SelectionLength = 0
        Me.txtNumero.SelectionStart = 0
        Me.txtNumero.ShortcutsEnabled = true
        Me.txtNumero.Size = New System.Drawing.Size(143, 27)
        Me.txtNumero.TabIndex = 29
        Me.txtNumero.UseSelectable = true
        Me.txtNumero.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtNumero.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtnombre
        '
        '
        '
        '
        Me.txtnombre.CustomButton.Image = Nothing
        Me.txtnombre.CustomButton.Location = New System.Drawing.Point(350, 1)
        Me.txtnombre.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnombre.CustomButton.Name = ""
        Me.txtnombre.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtnombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtnombre.CustomButton.TabIndex = 1
        Me.txtnombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtnombre.CustomButton.UseSelectable = true
        Me.txtnombre.CustomButton.Visible = false
        Me.txtnombre.Lines = New String(-1) {}
        Me.txtnombre.Location = New System.Drawing.Point(124, 44)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnombre.MaxLength = 32767
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtnombre.SelectedText = ""
        Me.txtnombre.SelectionLength = 0
        Me.txtnombre.SelectionStart = 0
        Me.txtnombre.ShortcutsEnabled = true
        Me.txtnombre.Size = New System.Drawing.Size(376, 27)
        Me.txtnombre.TabIndex = 28
        Me.txtnombre.UseSelectable = true
        Me.txtnombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtnombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtestado
        '
        '
        '
        '
        Me.txtestado.CustomButton.Image = Nothing
        Me.txtestado.CustomButton.Location = New System.Drawing.Point(194, 1)
        Me.txtestado.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtestado.CustomButton.Name = ""
        Me.txtestado.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtestado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtestado.CustomButton.TabIndex = 1
        Me.txtestado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtestado.CustomButton.UseSelectable = true
        Me.txtestado.CustomButton.Visible = false
        Me.txtestado.Lines = New String(-1) {}
        Me.txtestado.Location = New System.Drawing.Point(637, 76)
        Me.txtestado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtestado.MaxLength = 32767
        Me.txtestado.Name = "txtestado"
        Me.txtestado.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtestado.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtestado.SelectedText = ""
        Me.txtestado.SelectionLength = 0
        Me.txtestado.SelectionStart = 0
        Me.txtestado.ShortcutsEnabled = true
        Me.txtestado.Size = New System.Drawing.Size(220, 27)
        Me.txtestado.TabIndex = 24
        Me.txtestado.UseSelectable = true
        Me.txtestado.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtestado.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtcp
        '
        '
        '
        '
        Me.txtcp.CustomButton.Image = Nothing
        Me.txtcp.CustomButton.Location = New System.Drawing.Point(109, 1)
        Me.txtcp.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcp.CustomButton.Name = ""
        Me.txtcp.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtcp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtcp.CustomButton.TabIndex = 1
        Me.txtcp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtcp.CustomButton.UseSelectable = true
        Me.txtcp.CustomButton.Visible = false
        Me.txtcp.Lines = New String(-1) {}
        Me.txtcp.Location = New System.Drawing.Point(1032, 44)
        Me.txtcp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcp.MaxLength = 32767
        Me.txtcp.Name = "txtcp"
        Me.txtcp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcp.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtcp.SelectedText = ""
        Me.txtcp.SelectionLength = 0
        Me.txtcp.SelectionStart = 0
        Me.txtcp.ShortcutsEnabled = true
        Me.txtcp.Size = New System.Drawing.Size(135, 27)
        Me.txtcp.TabIndex = 25
        Me.txtcp.UseSelectable = true
        Me.txtcp.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtcp.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtcolonia
        '
        '
        '
        '
        Me.txtcolonia.CustomButton.Image = Nothing
        Me.txtcolonia.CustomButton.Location = New System.Drawing.Point(397, 1)
        Me.txtcolonia.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcolonia.CustomButton.Name = ""
        Me.txtcolonia.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtcolonia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtcolonia.CustomButton.TabIndex = 1
        Me.txtcolonia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtcolonia.CustomButton.UseSelectable = true
        Me.txtcolonia.CustomButton.Visible = false
        Me.txtcolonia.Lines = New String(-1) {}
        Me.txtcolonia.Location = New System.Drawing.Point(435, 111)
        Me.txtcolonia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcolonia.MaxLength = 32767
        Me.txtcolonia.Name = "txtcolonia"
        Me.txtcolonia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcolonia.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtcolonia.SelectedText = ""
        Me.txtcolonia.SelectionLength = 0
        Me.txtcolonia.SelectionStart = 0
        Me.txtcolonia.ShortcutsEnabled = true
        Me.txtcolonia.Size = New System.Drawing.Size(423, 27)
        Me.txtcolonia.TabIndex = 26
        Me.txtcolonia.UseSelectable = true
        Me.txtcolonia.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtcolonia.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtdirecion
        '
        '
        '
        '
        Me.txtdirecion.CustomButton.Image = Nothing
        Me.txtdirecion.CustomButton.Location = New System.Drawing.Point(350, 1)
        Me.txtdirecion.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdirecion.CustomButton.Name = ""
        Me.txtdirecion.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtdirecion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtdirecion.CustomButton.TabIndex = 1
        Me.txtdirecion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtdirecion.CustomButton.UseSelectable = true
        Me.txtdirecion.CustomButton.Visible = false
        Me.txtdirecion.Lines = New String(-1) {}
        Me.txtdirecion.Location = New System.Drawing.Point(124, 76)
        Me.txtdirecion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdirecion.MaxLength = 32767
        Me.txtdirecion.Name = "txtdirecion"
        Me.txtdirecion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdirecion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtdirecion.SelectedText = ""
        Me.txtdirecion.SelectionLength = 0
        Me.txtdirecion.SelectionStart = 0
        Me.txtdirecion.ShortcutsEnabled = true
        Me.txtdirecion.Size = New System.Drawing.Size(376, 27)
        Me.txtdirecion.TabIndex = 27
        Me.txtdirecion.UseSelectable = true
        Me.txtdirecion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtdirecion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.GroupBox2.HorizontalScrollbarBarColor = true
        Me.GroupBox2.HorizontalScrollbarHighlightOnWheel = false
        Me.GroupBox2.HorizontalScrollbarSize = 12
        Me.GroupBox2.Location = New System.Drawing.Point(39, 351)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1183, 166)
        Me.GroupBox2.TabIndex = 62
        Me.GroupBox2.VerticalScrollbarBarColor = true
        Me.GroupBox2.VerticalScrollbarHighlightOnWheel = false
        Me.GroupBox2.VerticalScrollbarSize = 13
        '
        'LblPlazo
        '
        Me.LblPlazo.AutoSize = true
        Me.LblPlazo.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LblPlazo.Location = New System.Drawing.Point(24, 84)
        Me.LblPlazo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPlazo.Name = "LblPlazo"
        Me.LblPlazo.Size = New System.Drawing.Size(50, 20)
        Me.LblPlazo.TabIndex = 44
        Me.LblPlazo.Text = "Plazo:"
        '
        'CmbCredito
        '
        Me.CmbCredito.FormattingEnabled = true
        Me.CmbCredito.ItemHeight = 24
        Me.CmbCredito.Items.AddRange(New Object() {"8 DIAS DE CREDITO", "15 DIAS DE CREDITO", "21 DIAS DE CREDITO", "30 DIAS DE CREDITO", "PAGO A LA ENTREGA"})
        Me.CmbCredito.Location = New System.Drawing.Point(25, 111)
        Me.CmbCredito.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbCredito.Name = "CmbCredito"
        Me.CmbCredito.Size = New System.Drawing.Size(357, 30)
        Me.CmbCredito.TabIndex = 45
        Me.CmbCredito.UseSelectable = true
        '
        'Lbltipo
        '
        Me.Lbltipo.AutoSize = true
        Me.Lbltipo.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Lbltipo.Location = New System.Drawing.Point(20, 14)
        Me.Lbltipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbltipo.Name = "Lbltipo"
        Me.Lbltipo.Size = New System.Drawing.Size(107, 20)
        Me.Lbltipo.TabIndex = 2
        Me.Lbltipo.Text = "Metodo Pago:"
        '
        'LblFechaLim
        '
        Me.LblFechaLim.AutoSize = true
        Me.LblFechaLim.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LblFechaLim.Location = New System.Drawing.Point(864, 62)
        Me.LblFechaLim.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblFechaLim.Name = "LblFechaLim"
        Me.LblFechaLim.Size = New System.Drawing.Size(101, 20)
        Me.LblFechaLim.TabIndex = 3
        Me.LblFechaLim.Text = "Fecha Limite:"
        '
        'LblFechaFac
        '
        Me.LblFechaFac.AutoSize = true
        Me.LblFechaFac.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LblFechaFac.Location = New System.Drawing.Point(853, 20)
        Me.LblFechaFac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblFechaFac.Name = "LblFechaFac"
        Me.LblFechaFac.Size = New System.Drawing.Size(109, 20)
        Me.LblFechaFac.TabIndex = 4
        Me.LblFechaFac.Text = "Fecha Factura:"
        '
        'CmbMetodoPago
        '
        Me.CmbMetodoPago.FormattingEnabled = true
        Me.CmbMetodoPago.ItemHeight = 24
        Me.CmbMetodoPago.Location = New System.Drawing.Point(27, 42)
        Me.CmbMetodoPago.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbMetodoPago.Name = "CmbMetodoPago"
        Me.CmbMetodoPago.Size = New System.Drawing.Size(356, 30)
        Me.CmbMetodoPago.TabIndex = 5
        Me.CmbMetodoPago.UseSelectable = true
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(999, 14)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.MinimumSize = New System.Drawing.Size(0, 30)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(160, 30)
        Me.DateTimePicker1.TabIndex = 6
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(999, 57)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker2.MinimumSize = New System.Drawing.Size(0, 30)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(160, 30)
        Me.DateTimePicker2.TabIndex = 7
        '
        'CmdFormaPago
        '
        Me.CmdFormaPago.FormattingEnabled = true
        Me.CmdFormaPago.ItemHeight = 24
        Me.CmdFormaPago.Location = New System.Drawing.Point(396, 42)
        Me.CmdFormaPago.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdFormaPago.Name = "CmdFormaPago"
        Me.CmdFormaPago.Size = New System.Drawing.Size(447, 30)
        Me.CmdFormaPago.TabIndex = 34
        Me.CmdFormaPago.UseSelectable = true
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label12.Location = New System.Drawing.Point(392, 14)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 20)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Forma de Pago:"
        '
        'Label17
        '
        Me.Label17.AutoSize = true
        Me.Label17.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label17.Location = New System.Drawing.Point(396, 84)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 20)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Uso del CFDI:"
        '
        'CmbUsoCDFI
        '
        Me.CmbUsoCDFI.FormattingEnabled = true
        Me.CmbUsoCDFI.ItemHeight = 24
        Me.CmbUsoCDFI.Location = New System.Drawing.Point(399, 111)
        Me.CmbUsoCDFI.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbUsoCDFI.Name = "CmbUsoCDFI"
        Me.CmbUsoCDFI.Size = New System.Drawing.Size(760, 30)
        Me.CmbUsoCDFI.TabIndex = 43
        Me.CmbUsoCDFI.UseSelectable = true
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.lblnoregistros)
        Me.GroupBox4.Controls.Add(Me.LblNRegistros)
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
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox4.HorizontalScrollbarBarColor = true
        Me.GroupBox4.HorizontalScrollbarHighlightOnWheel = false
        Me.GroupBox4.HorizontalScrollbarSize = 12
        Me.GroupBox4.Location = New System.Drawing.Point(39, 524)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1183, 503)
        Me.GroupBox4.TabIndex = 63
        Me.GroupBox4.VerticalScrollbarBarColor = true
        Me.GroupBox4.VerticalScrollbarHighlightOnWheel = false
        Me.GroupBox4.VerticalScrollbarSize = 13
        '
        'lblnoregistros
        '
        Me.lblnoregistros.AutoSize = true
        Me.lblnoregistros.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblnoregistros.Location = New System.Drawing.Point(840, 30)
        Me.lblnoregistros.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnoregistros.Name = "lblnoregistros"
        Me.lblnoregistros.Size = New System.Drawing.Size(167, 20)
        Me.lblnoregistros.TabIndex = 30
        Me.lblnoregistros.Text = "N° Partidas a Facturar:"
        '
        'LblNRegistros
        '
        Me.LblNRegistros.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.LblNRegistros.Location = New System.Drawing.Point(1067, 26)
        Me.LblNRegistros.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNRegistros.Name = "LblNRegistros"
        Me.LblNRegistros.Size = New System.Drawing.Size(108, 28)
        Me.LblNRegistros.TabIndex = 29
        Me.LblNRegistros.Text = "0"
        Me.LblNRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnGenerarMostrador)
        Me.GroupBox6.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox6.Controls.Add(Me.CbMostrador)
        Me.GroupBox6.HorizontalScrollbarBarColor = true
        Me.GroupBox6.HorizontalScrollbarHighlightOnWheel = false
        Me.GroupBox6.HorizontalScrollbarSize = 12
        Me.GroupBox6.Location = New System.Drawing.Point(251, 314)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(243, 154)
        Me.GroupBox6.TabIndex = 24
        Me.GroupBox6.VerticalScrollbarBarColor = true
        Me.GroupBox6.VerticalScrollbarHighlightOnWheel = false
        Me.GroupBox6.VerticalScrollbarSize = 13
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(25, 49)
        Me.DateTimePicker3.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker3.MinimumSize = New System.Drawing.Size(0, 30)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(192, 30)
        Me.DateTimePicker3.TabIndex = 29
        '
        'CbMostrador
        '
        Me.CbMostrador.AutoSize = true
        Me.CbMostrador.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold
        Me.CbMostrador.Location = New System.Drawing.Point(8, 17)
        Me.CbMostrador.Margin = New System.Windows.Forms.Padding(4)
        Me.CbMostrador.Name = "CbMostrador"
        Me.CbMostrador.Size = New System.Drawing.Size(137, 17)
        Me.CbMostrador.TabIndex = 27
        Me.CbMostrador.Text = "Factura Mostrador"
        Me.CbMostrador.UseSelectable = true
        '
        'GbTicket
        '
        Me.GbTicket.Controls.Add(Me.lv_ticket)
        Me.GbTicket.Controls.Add(Me.Label10)
        Me.GbTicket.Controls.Add(Me.TxtTikect)
        Me.GbTicket.HorizontalScrollbarBarColor = true
        Me.GbTicket.HorizontalScrollbarHighlightOnWheel = false
        Me.GbTicket.HorizontalScrollbarSize = 12
        Me.GbTicket.Location = New System.Drawing.Point(15, 314)
        Me.GbTicket.Margin = New System.Windows.Forms.Padding(4)
        Me.GbTicket.Name = "GbTicket"
        Me.GbTicket.Size = New System.Drawing.Size(228, 186)
        Me.GbTicket.TabIndex = 23
        Me.GbTicket.VerticalScrollbarBarColor = true
        Me.GbTicket.VerticalScrollbarHighlightOnWheel = false
        Me.GbTicket.VerticalScrollbarSize = 13
        '
        'lv_ticket
        '
        Me.lv_ticket.FormattingEnabled = true
        Me.lv_ticket.ItemHeight = 20
        Me.lv_ticket.Location = New System.Drawing.Point(9, 54)
        Me.lv_ticket.Margin = New System.Windows.Forms.Padding(4)
        Me.lv_ticket.Name = "lv_ticket"
        Me.lv_ticket.Size = New System.Drawing.Size(204, 104)
        Me.lv_ticket.TabIndex = 31
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label10.Location = New System.Drawing.Point(5, 23)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 20)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Ticket"
        '
        'TxtTikect
        '
        '
        '
        '
        Me.TxtTikect.CustomButton.Image = Nothing
        Me.TxtTikect.CustomButton.Location = New System.Drawing.Point(107, 1)
        Me.TxtTikect.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTikect.CustomButton.Name = ""
        Me.TxtTikect.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.TxtTikect.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TxtTikect.CustomButton.TabIndex = 1
        Me.TxtTikect.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TxtTikect.CustomButton.UseSelectable = true
        Me.TxtTikect.CustomButton.Visible = false
        Me.TxtTikect.Lines = New String(-1) {}
        Me.TxtTikect.Location = New System.Drawing.Point(81, 20)
        Me.TxtTikect.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTikect.MaxLength = 32767
        Me.TxtTikect.Name = "TxtTikect"
        Me.TxtTikect.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtTikect.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtTikect.SelectedText = ""
        Me.TxtTikect.SelectionLength = 0
        Me.TxtTikect.SelectionStart = 0
        Me.TxtTikect.ShortcutsEnabled = true
        Me.TxtTikect.Size = New System.Drawing.Size(133, 27)
        Me.TxtTikect.TabIndex = 25
        Me.TxtTikect.UseSelectable = true
        Me.TxtTikect.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.TxtTikect.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'TxtSubtotal
        '
        '
        '
        '
        Me.TxtSubtotal.CustomButton.Image = Nothing
        Me.TxtSubtotal.CustomButton.Location = New System.Drawing.Point(133, 1)
        Me.TxtSubtotal.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSubtotal.CustomButton.Name = ""
        Me.TxtSubtotal.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.TxtSubtotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TxtSubtotal.CustomButton.TabIndex = 1
        Me.TxtSubtotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TxtSubtotal.CustomButton.UseSelectable = true
        Me.TxtSubtotal.CustomButton.Visible = false
        Me.TxtSubtotal.Enabled = false
        Me.TxtSubtotal.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TxtSubtotal.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.TxtSubtotal.Lines = New String() {"0.0000"}
        Me.TxtSubtotal.Location = New System.Drawing.Point(513, 348)
        Me.TxtSubtotal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSubtotal.MaxLength = 32767
        Me.TxtSubtotal.Name = "TxtSubtotal"
        Me.TxtSubtotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSubtotal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtSubtotal.SelectedText = ""
        Me.TxtSubtotal.SelectionLength = 0
        Me.TxtSubtotal.SelectionStart = 0
        Me.TxtSubtotal.ShortcutsEnabled = true
        Me.TxtSubtotal.Size = New System.Drawing.Size(159, 27)
        Me.TxtSubtotal.TabIndex = 22
        Me.TxtSubtotal.Text = "0.0000"
        Me.TxtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtSubtotal.UseSelectable = true
        Me.TxtSubtotal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.TxtSubtotal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'TxtIVA
        '
        '
        '
        '
        Me.TxtIVA.CustomButton.Image = Nothing
        Me.TxtIVA.CustomButton.Location = New System.Drawing.Point(135, 1)
        Me.TxtIVA.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIVA.CustomButton.Name = ""
        Me.TxtIVA.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.TxtIVA.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TxtIVA.CustomButton.TabIndex = 1
        Me.TxtIVA.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TxtIVA.CustomButton.UseSelectable = true
        Me.TxtIVA.CustomButton.Visible = false
        Me.TxtIVA.Enabled = false
        Me.TxtIVA.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TxtIVA.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.TxtIVA.Lines = New String() {"0.0000"}
        Me.TxtIVA.Location = New System.Drawing.Point(760, 348)
        Me.TxtIVA.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIVA.MaxLength = 32767
        Me.TxtIVA.Name = "TxtIVA"
        Me.TxtIVA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtIVA.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtIVA.SelectedText = ""
        Me.TxtIVA.SelectionLength = 0
        Me.TxtIVA.SelectionStart = 0
        Me.TxtIVA.ShortcutsEnabled = true
        Me.TxtIVA.Size = New System.Drawing.Size(161, 27)
        Me.TxtIVA.TabIndex = 21
        Me.TxtIVA.Text = "0.0000"
        Me.TxtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtIVA.UseSelectable = true
        Me.TxtIVA.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.TxtIVA.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'TxtTotal
        '
        '
        '
        '
        Me.TxtTotal.CustomButton.Image = Nothing
        Me.TxtTotal.CustomButton.Location = New System.Drawing.Point(135, 1)
        Me.TxtTotal.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotal.CustomButton.Name = ""
        Me.TxtTotal.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.TxtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TxtTotal.CustomButton.TabIndex = 1
        Me.TxtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TxtTotal.CustomButton.UseSelectable = true
        Me.TxtTotal.CustomButton.Visible = false
        Me.TxtTotal.Enabled = false
        Me.TxtTotal.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.TxtTotal.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.TxtTotal.Lines = New String() {"0.0000"}
        Me.TxtTotal.Location = New System.Drawing.Point(1005, 348)
        Me.TxtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotal.MaxLength = 32767
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtTotal.SelectedText = ""
        Me.TxtTotal.SelectionLength = 0
        Me.TxtTotal.SelectionStart = 0
        Me.TxtTotal.ShortcutsEnabled = true
        Me.TxtTotal.Size = New System.Drawing.Size(161, 27)
        Me.TxtTotal.TabIndex = 20
        Me.TxtTotal.Text = "0.0000"
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTotal.UseSelectable = true
        Me.TxtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.TxtTotal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'TxtFolio
        '
        '
        '
        '
        Me.TxtFolio.CustomButton.Image = Nothing
        Me.TxtFolio.CustomButton.Location = New System.Drawing.Point(107, 1)
        Me.TxtFolio.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtFolio.CustomButton.Name = ""
        Me.TxtFolio.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.TxtFolio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TxtFolio.CustomButton.TabIndex = 1
        Me.TxtFolio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TxtFolio.CustomButton.UseSelectable = true
        Me.TxtFolio.CustomButton.Visible = false
        Me.TxtFolio.Enabled = false
        Me.TxtFolio.Lines = New String(-1) {}
        Me.TxtFolio.Location = New System.Drawing.Point(556, 23)
        Me.TxtFolio.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtFolio.MaxLength = 32767
        Me.TxtFolio.Name = "TxtFolio"
        Me.TxtFolio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtFolio.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtFolio.SelectedText = ""
        Me.TxtFolio.SelectionLength = 0
        Me.TxtFolio.SelectionStart = 0
        Me.TxtFolio.ShortcutsEnabled = true
        Me.TxtFolio.Size = New System.Drawing.Size(133, 27)
        Me.TxtFolio.TabIndex = 1
        Me.TxtFolio.UseSelectable = true
        Me.TxtFolio.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.TxtFolio.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'LblFolio
        '
        Me.LblFolio.AutoSize = true
        Me.LblFolio.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LblFolio.Location = New System.Drawing.Point(411, 26)
        Me.LblFolio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblFolio.Name = "LblFolio"
        Me.LblFolio.Size = New System.Drawing.Size(103, 20)
        Me.LblFolio.TabIndex = 0
        Me.LblFolio.Text = "Folio Factura:"
        '
        'LblSubTotal
        '
        Me.LblSubTotal.AutoSize = true
        Me.LblSubTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LblSubTotal.Location = New System.Drawing.Point(513, 318)
        Me.LblSubTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSubTotal.Name = "LblSubTotal"
        Me.LblSubTotal.Size = New System.Drawing.Size(80, 20)
        Me.LblSubTotal.TabIndex = 19
        Me.LblSubTotal.Text = "Sub-Total:"
        '
        'LblIVA
        '
        Me.LblIVA.AutoSize = true
        Me.LblIVA.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LblIVA.Location = New System.Drawing.Point(760, 318)
        Me.LblIVA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblIVA.Name = "LblIVA"
        Me.LblIVA.Size = New System.Drawing.Size(49, 20)
        Me.LblIVA.TabIndex = 18
        Me.LblIVA.Text = "I.V.A.:"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label8.Location = New System.Drawing.Point(1005, 314)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "TOTAL:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = false
        Me.DataGridView1.AllowUserToDeleteRows = false
        Me.DataGridView1.AllowUserToResizeRows = false
        DataGridViewCellStyle33.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle33.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle33
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
        DataGridViewCellStyle34.Font = New System.Drawing.Font("Segoe UI Semibold", 12!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle34.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle34
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.foliio, Me.Cantidad, Me.Descripcion, Me.Precio, Me.Subtotal, Me.Fecha, Me.precioCosto, Me.subtotalCosto, Me.IdProducto, Me.numeroFactura, Me.Id_Producto, Me.Clave_Producto, Me.Clave_Unidad, Me.TasaCero, Me.IVA})
        DataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle38.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle38.Font = New System.Drawing.Font("Segoe UI Semibold", 12!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer))
        DataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle38
        Me.DataGridView1.EnableHeadersVisualStyles = false
        Me.DataGridView1.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(13, 62)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = false
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = true
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle39.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle39
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle40.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle40.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle40
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = false
        Me.DataGridView1.Size = New System.Drawing.Size(1161, 245)
        Me.DataGridView1.TabIndex = 0
        '
        'foliio
        '
        Me.foliio.HeaderText = "folio"
        Me.foliio.MinimumWidth = 6
        Me.foliio.Name = "foliio"
        Me.foliio.ReadOnly = true
        Me.foliio.Visible = false
        Me.foliio.Width = 85
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle35
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = true
        Me.Cantidad.Width = 119
        '
        'Descripcion
        '
        Me.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Descripcion.HeaderText = "Concepto"
        Me.Descripcion.MinimumWidth = 6
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = true
        '
        'Precio
        '
        Me.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle36.NullValue = Nothing
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle36
        Me.Precio.HeaderText = "Precio Unitario"
        Me.Precio.MinimumWidth = 6
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = true
        Me.Precio.Width = 173
        '
        'Subtotal
        '
        Me.Subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle37.NullValue = Nothing
        Me.Subtotal.DefaultCellStyle = DataGridViewCellStyle37
        Me.Subtotal.HeaderText = "Importe"
        Me.Subtotal.MinimumWidth = 6
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = true
        Me.Subtotal.Width = 113
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.MinimumWidth = 6
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = true
        Me.Fecha.Visible = false
        Me.Fecha.Width = 85
        '
        'precioCosto
        '
        Me.precioCosto.HeaderText = "precioCosto"
        Me.precioCosto.MinimumWidth = 6
        Me.precioCosto.Name = "precioCosto"
        Me.precioCosto.ReadOnly = true
        Me.precioCosto.Visible = false
        Me.precioCosto.Width = 125
        '
        'subtotalCosto
        '
        Me.subtotalCosto.HeaderText = "subtotalCosto"
        Me.subtotalCosto.MinimumWidth = 6
        Me.subtotalCosto.Name = "subtotalCosto"
        Me.subtotalCosto.ReadOnly = true
        Me.subtotalCosto.Visible = false
        Me.subtotalCosto.Width = 125
        '
        'IdProducto
        '
        Me.IdProducto.HeaderText = "clave_producto"
        Me.IdProducto.MinimumWidth = 6
        Me.IdProducto.Name = "IdProducto"
        Me.IdProducto.ReadOnly = true
        Me.IdProducto.Visible = false
        Me.IdProducto.Width = 125
        '
        'numeroFactura
        '
        Me.numeroFactura.HeaderText = "numeroFactura"
        Me.numeroFactura.MinimumWidth = 6
        Me.numeroFactura.Name = "numeroFactura"
        Me.numeroFactura.ReadOnly = true
        Me.numeroFactura.Visible = false
        Me.numeroFactura.Width = 125
        '
        'Id_Producto
        '
        Me.Id_Producto.HeaderText = "Id_Producto"
        Me.Id_Producto.MinimumWidth = 6
        Me.Id_Producto.Name = "Id_Producto"
        Me.Id_Producto.ReadOnly = true
        Me.Id_Producto.Visible = false
        Me.Id_Producto.Width = 85
        '
        'Clave_Producto
        '
        Me.Clave_Producto.HeaderText = "ClaveProducto"
        Me.Clave_Producto.MinimumWidth = 6
        Me.Clave_Producto.Name = "Clave_Producto"
        Me.Clave_Producto.ReadOnly = true
        Me.Clave_Producto.Visible = false
        Me.Clave_Producto.Width = 125
        '
        'Clave_Unidad
        '
        Me.Clave_Unidad.HeaderText = "ClaveUnidad"
        Me.Clave_Unidad.MinimumWidth = 6
        Me.Clave_Unidad.Name = "Clave_Unidad"
        Me.Clave_Unidad.ReadOnly = true
        Me.Clave_Unidad.Visible = false
        Me.Clave_Unidad.Width = 125
        '
        'TasaCero
        '
        Me.TasaCero.HeaderText = "TasaCero"
        Me.TasaCero.MinimumWidth = 6
        Me.TasaCero.Name = "TasaCero"
        Me.TasaCero.ReadOnly = true
        Me.TasaCero.Visible = false
        Me.TasaCero.Width = 125
        '
        'IVA
        '
        Me.IVA.HeaderText = "iva"
        Me.IVA.MinimumWidth = 6
        Me.IVA.Name = "IVA"
        Me.IVA.ReadOnly = true
        Me.IVA.Visible = false
        Me.IVA.Width = 125
        '
        'PrBImprimiendo
        '
        Me.PrBImprimiendo.Location = New System.Drawing.Point(39, 1035)
        Me.PrBImprimiendo.Margin = New System.Windows.Forms.Padding(4)
        Me.PrBImprimiendo.Name = "PrBImprimiendo"
        Me.PrBImprimiendo.Size = New System.Drawing.Size(1183, 22)
        Me.PrBImprimiendo.TabIndex = 64
        Me.PrBImprimiendo.UseWaitCursor = true
        Me.PrBImprimiendo.Visible = false
        '
        'ChkTasaCero
        '
        Me.ChkTasaCero.AutoSize = true
        Me.ChkTasaCero.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold
        Me.ChkTasaCero.Location = New System.Drawing.Point(577, 109)
        Me.ChkTasaCero.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkTasaCero.Name = "ChkTasaCero"
        Me.ChkTasaCero.Size = New System.Drawing.Size(122, 17)
        Me.ChkTasaCero.TabIndex = 66
        Me.ChkTasaCero.Text = "Factura Tasa 0%"
        Me.ChkTasaCero.UseSelectable = true
        Me.ChkTasaCero.Visible = false
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label14.Location = New System.Drawing.Point(932, 106)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 20)
        Me.Label14.TabIndex = 67
        Me.Label14.Text = "Banco"
        Me.Label14.Visible = false
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label13.Location = New System.Drawing.Point(731, 106)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 20)
        Me.Label13.TabIndex = 68
        Me.Label13.Text = "4 Dig. Cta.:"
        Me.Label13.Visible = false
        '
        'btnUpdateUUID
        '
        Me.btnUpdateUUID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateUUID.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnUpdateUUID.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.update_16px
        Me.btnUpdateUUID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdateUUID.Location = New System.Drawing.Point(199, 75)
        Me.btnUpdateUUID.Name = "btnUpdateUUID"
        Me.btnUpdateUUID.Size = New System.Drawing.Size(140, 28)
        Me.btnUpdateUUID.TabIndex = 81
        Me.btnUpdateUUID.Text = "Actualizar UUID"
        Me.btnUpdateUUID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateUUID.UseVisualStyleBackColor = true
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.close_window_16px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(1122, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 80
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = true
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnAdd.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.search_16px
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.Location = New System.Drawing.Point(39, 75)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(154, 28)
        Me.btnAdd.TabIndex = 79
        Me.btnAdd.Text = "F2 - Buscar Cliente"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.UseVisualStyleBackColor = true
        '
        'btnGenerarMostrador
        '
        Me.btnGenerarMostrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerarMostrador.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnGenerarMostrador.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnGenerarMostrador.Location = New System.Drawing.Point(25, 113)
        Me.btnGenerarMostrador.Name = "btnGenerarMostrador"
        Me.btnGenerarMostrador.Size = New System.Drawing.Size(192, 28)
        Me.btnGenerarMostrador.TabIndex = 82
        Me.btnGenerarMostrador.Text = "Generar"
        Me.btnGenerarMostrador.UseVisualStyleBackColor = true
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.export_16px
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(1005, 427)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(162, 28)
        Me.Button3.TabIndex = 82
        Me.Button3.Text = "Generar Factura"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = true
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.update_16px
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(13, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(162, 28)
        Me.Button2.TabIndex = 83
        Me.Button2.Text = "F3 - Limpiar Datos"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = true
        '
        'FrmFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 1086)
        Me.Controls.Add(Me.btnUpdateUUID)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ChkTasaCero)
        Me.Controls.Add(Me.PrBImprimiendo)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.CmbBanco)
        Me.Controls.Add(Me.txtCuenta)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmFacturacion"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Text = "Facturaciòn"
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox3.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.GroupBox4.ResumeLayout(false)
        Me.GroupBox4.PerformLayout
        Me.GroupBox6.ResumeLayout(false)
        Me.GroupBox6.PerformLayout
        Me.GbTicket.ResumeLayout(false)
        Me.GbTicket.PerformLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
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
    Friend WithEvents lblnoregistros As MetroFramework.Controls.MetroLabel
    Friend WithEvents LblNRegistros As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox6 As MetroFramework.Controls.MetroPanel
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
    Friend WithEvents ChkTasaCero As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Label14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents CmbBanco As MetroFramework.Controls.MetroComboBox
    Friend WithEvents CmbUsoCDFI As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdateUUID As Button
    Friend WithEvents btnGenerarMostrador As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
