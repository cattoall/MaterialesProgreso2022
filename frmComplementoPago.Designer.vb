<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComplementoPago
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblPago = New MetroFramework.Controls.MetroLabel()
        Me.Label11 = New MetroFramework.Controls.MetroLabel()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.PrBImprimiendo = New System.Windows.Forms.ProgressBar()
        Me.Label12 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtRFR = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Label15 = New MetroFramework.Controls.MetroLabel()
        Me.txtCP = New MetroFramework.Controls.MetroTextBox()
        Me.TxtRFC = New MetroFramework.Controls.MetroTextBox()
        Me.txtColonia = New MetroFramework.Controls.MetroTextBox()
        Me.txtEstado = New MetroFramework.Controls.MetroTextBox()
        Me.txtCiudad = New MetroFramework.Controls.MetroTextBox()
        Me.txtEmail = New MetroFramework.Controls.MetroTextBox()
        Me.txtNumero = New MetroFramework.Controls.MetroTextBox()
        Me.txtDirecion = New MetroFramework.Controls.MetroTextBox()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.LblCliente = New MetroFramework.Controls.MetroLabel()
        Me.Label9 = New MetroFramework.Controls.MetroLabel()
        Me.Label7 = New MetroFramework.Controls.MetroLabel()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.Label8 = New MetroFramework.Controls.MetroLabel()
        Me.Label10 = New MetroFramework.Controls.MetroLabel()
        Me.Label13 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CmdFormaPago = New MetroFramework.Controls.MetroComboBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.CmdCancelarPago = New System.Windows.Forms.Button()
        Me.dtpFechaPago = New MetroFramework.Controls.MetroDateTime()
        Me.btnComproPago = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dtFechaInicial = New MetroFramework.Controls.MetroDateTime()
        Me.dtFechaFinal = New MetroFramework.Controls.MetroDateTime()
        Me.chkCancelados = New MetroFramework.Controls.MetroCheckBox()
        Me.chkPagados = New MetroFramework.Controls.MetroCheckBox()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.CmdLimpiar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New MetroFramework.Controls.MetroGrid()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Condiciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsoCFDI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UUID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.P = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObjImp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPago
        '
        Me.lblPago.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblPago.ForeColor = System.Drawing.Color.Black
        Me.lblPago.Location = New System.Drawing.Point(726, 11)
        Me.lblPago.Name = "lblPago"
        Me.lblPago.Size = New System.Drawing.Size(149, 17)
        Me.lblPago.TabIndex = 45
        Me.lblPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(10, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 19)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "e-Mail:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Nombre:"
        '
        'PrBImprimiendo
        '
        Me.PrBImprimiendo.Location = New System.Drawing.Point(29, 645)
        Me.PrBImprimiendo.Name = "PrBImprimiendo"
        Me.PrBImprimiendo.Size = New System.Drawing.Size(887, 23)
        Me.PrBImprimiendo.TabIndex = 61
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(6, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 19)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Forma de Pago:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtRFR)
        Me.GroupBox3.Controls.Add(Me.MetroLabel1)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtCP)
        Me.GroupBox3.Controls.Add(Me.TxtRFC)
        Me.GroupBox3.Controls.Add(Me.txtColonia)
        Me.GroupBox3.Controls.Add(Me.txtEstado)
        Me.GroupBox3.Controls.Add(Me.txtCiudad)
        Me.GroupBox3.Controls.Add(Me.txtEmail)
        Me.GroupBox3.Controls.Add(Me.txtNumero)
        Me.GroupBox3.Controls.Add(Me.txtDirecion)
        Me.GroupBox3.Controls.Add(Me.txtNombre)
        Me.GroupBox3.Controls.Add(Me.lblPago)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.LblCliente)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(29, 111)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(887, 152)
        Me.GroupBox3.TabIndex = 57
        Me.GroupBox3.TabStop = False
        '
        'txtRFR
        '
        '
        '
        '
        Me.txtRFR.CustomButton.Image = Nothing
        Me.txtRFR.CustomButton.Location = New System.Drawing.Point(185, 2)
        Me.txtRFR.CustomButton.Name = ""
        Me.txtRFR.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtRFR.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtRFR.CustomButton.TabIndex = 1
        Me.txtRFR.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtRFR.CustomButton.UseSelectable = True
        Me.txtRFR.CustomButton.Visible = False
        Me.txtRFR.Lines = New String(-1) {}
        Me.txtRFR.Location = New System.Drawing.Point(670, 119)
        Me.txtRFR.MaxLength = 32767
        Me.txtRFR.Name = "txtRFR"
        Me.txtRFR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRFR.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRFR.SelectedText = ""
        Me.txtRFR.SelectionLength = 0
        Me.txtRFR.SelectionStart = 0
        Me.txtRFR.ShortcutsEnabled = True
        Me.txtRFR.Size = New System.Drawing.Size(205, 22)
        Me.txtRFR.TabIndex = 98
        Me.txtRFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtRFR.UseSelectable = True
        Me.txtRFR.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtRFR.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel1.Location = New System.Drawing.Point(670, 97)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(112, 19)
        Me.MetroLabel1.TabIndex = 97
        Me.MetroLabel1.Text = "Régimen Fiscal:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(10, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 19)
        Me.Label15.TabIndex = 90
        Me.Label15.Text = "Cliente ID:"
        '
        'txtCP
        '
        '
        '
        '
        Me.txtCP.CustomButton.Image = Nothing
        Me.txtCP.CustomButton.Location = New System.Drawing.Point(96, 2)
        Me.txtCP.CustomButton.Name = ""
        Me.txtCP.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtCP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCP.CustomButton.TabIndex = 1
        Me.txtCP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCP.CustomButton.UseSelectable = True
        Me.txtCP.CustomButton.Visible = False
        Me.txtCP.Lines = New String(-1) {}
        Me.txtCP.Location = New System.Drawing.Point(759, 34)
        Me.txtCP.MaxLength = 32767
        Me.txtCP.Name = "txtCP"
        Me.txtCP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCP.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCP.SelectedText = ""
        Me.txtCP.SelectionLength = 0
        Me.txtCP.SelectionStart = 0
        Me.txtCP.ShortcutsEnabled = True
        Me.txtCP.Size = New System.Drawing.Size(116, 22)
        Me.txtCP.TabIndex = 96
        Me.txtCP.UseSelectable = True
        Me.txtCP.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCP.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'TxtRFC
        '
        '
        '
        '
        Me.TxtRFC.CustomButton.Image = Nothing
        Me.TxtRFC.CustomButton.Location = New System.Drawing.Point(132, 2)
        Me.TxtRFC.CustomButton.Name = ""
        Me.TxtRFC.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.TxtRFC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TxtRFC.CustomButton.TabIndex = 1
        Me.TxtRFC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TxtRFC.CustomButton.UseSelectable = True
        Me.TxtRFC.CustomButton.Visible = False
        Me.TxtRFC.Lines = New String(-1) {}
        Me.TxtRFC.Location = New System.Drawing.Point(723, 65)
        Me.TxtRFC.MaxLength = 32767
        Me.TxtRFC.Name = "TxtRFC"
        Me.TxtRFC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtRFC.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtRFC.SelectedText = ""
        Me.TxtRFC.SelectionLength = 0
        Me.TxtRFC.SelectionStart = 0
        Me.TxtRFC.ShortcutsEnabled = True
        Me.TxtRFC.Size = New System.Drawing.Size(152, 22)
        Me.TxtRFC.TabIndex = 95
        Me.TxtRFC.UseSelectable = True
        Me.TxtRFC.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TxtRFC.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtColonia
        '
        '
        '
        '
        Me.txtColonia.CustomButton.Image = Nothing
        Me.txtColonia.CustomButton.Location = New System.Drawing.Point(306, 2)
        Me.txtColonia.CustomButton.Name = ""
        Me.txtColonia.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtColonia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtColonia.CustomButton.TabIndex = 1
        Me.txtColonia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtColonia.CustomButton.UseSelectable = True
        Me.txtColonia.CustomButton.Visible = False
        Me.txtColonia.Lines = New String(-1) {}
        Me.txtColonia.Location = New System.Drawing.Point(317, 91)
        Me.txtColonia.MaxLength = 32767
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtColonia.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtColonia.SelectedText = ""
        Me.txtColonia.SelectionLength = 0
        Me.txtColonia.SelectionStart = 0
        Me.txtColonia.ShortcutsEnabled = True
        Me.txtColonia.Size = New System.Drawing.Size(326, 22)
        Me.txtColonia.TabIndex = 94
        Me.txtColonia.UseSelectable = True
        Me.txtColonia.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtColonia.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtEstado
        '
        '
        '
        '
        Me.txtEstado.CustomButton.Image = Nothing
        Me.txtEstado.CustomButton.Location = New System.Drawing.Point(145, 2)
        Me.txtEstado.CustomButton.Name = ""
        Me.txtEstado.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtEstado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEstado.CustomButton.TabIndex = 1
        Me.txtEstado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEstado.CustomButton.UseSelectable = True
        Me.txtEstado.CustomButton.Visible = False
        Me.txtEstado.Lines = New String(-1) {}
        Me.txtEstado.Location = New System.Drawing.Point(478, 62)
        Me.txtEstado.MaxLength = 32767
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEstado.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEstado.SelectedText = ""
        Me.txtEstado.SelectionLength = 0
        Me.txtEstado.SelectionStart = 0
        Me.txtEstado.ShortcutsEnabled = True
        Me.txtEstado.Size = New System.Drawing.Size(165, 22)
        Me.txtEstado.TabIndex = 93
        Me.txtEstado.UseSelectable = True
        Me.txtEstado.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEstado.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.txtCiudad.TabIndex = 92
        Me.txtCiudad.UseSelectable = True
        Me.txtCiudad.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCiudad.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.txtEmail.Location = New System.Drawing.Point(93, 119)
        Me.txtEmail.MaxLength = 32767
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.SelectionLength = 0
        Me.txtEmail.SelectionStart = 0
        Me.txtEmail.ShortcutsEnabled = True
        Me.txtEmail.Size = New System.Drawing.Size(550, 22)
        Me.txtEmail.TabIndex = 91
        Me.txtEmail.UseSelectable = True
        Me.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNumero
        '
        '
        '
        '
        Me.txtNumero.CustomButton.Image = Nothing
        Me.txtNumero.CustomButton.Location = New System.Drawing.Point(136, 2)
        Me.txtNumero.CustomButton.Name = ""
        Me.txtNumero.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtNumero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNumero.CustomButton.TabIndex = 1
        Me.txtNumero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNumero.CustomButton.UseSelectable = True
        Me.txtNumero.CustomButton.Visible = False
        Me.txtNumero.Lines = New String(-1) {}
        Me.txtNumero.Location = New System.Drawing.Point(93, 91)
        Me.txtNumero.MaxLength = 32767
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumero.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumero.SelectedText = ""
        Me.txtNumero.SelectionLength = 0
        Me.txtNumero.SelectionStart = 0
        Me.txtNumero.ShortcutsEnabled = True
        Me.txtNumero.Size = New System.Drawing.Size(156, 22)
        Me.txtNumero.TabIndex = 90
        Me.txtNumero.UseSelectable = True
        Me.txtNumero.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNumero.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDirecion
        '
        '
        '
        '
        Me.txtDirecion.CustomButton.Image = Nothing
        Me.txtDirecion.CustomButton.Location = New System.Drawing.Point(262, 2)
        Me.txtDirecion.CustomButton.Name = ""
        Me.txtDirecion.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtDirecion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDirecion.CustomButton.TabIndex = 1
        Me.txtDirecion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDirecion.CustomButton.UseSelectable = True
        Me.txtDirecion.CustomButton.Visible = False
        Me.txtDirecion.Lines = New String(-1) {}
        Me.txtDirecion.Location = New System.Drawing.Point(93, 62)
        Me.txtDirecion.MaxLength = 32767
        Me.txtDirecion.Name = "txtDirecion"
        Me.txtDirecion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDirecion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDirecion.SelectedText = ""
        Me.txtDirecion.SelectionLength = 0
        Me.txtDirecion.SelectionStart = 0
        Me.txtDirecion.ShortcutsEnabled = True
        Me.txtDirecion.Size = New System.Drawing.Size(282, 22)
        Me.txtDirecion.TabIndex = 89
        Me.txtDirecion.UseSelectable = True
        Me.txtDirecion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDirecion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNombre
        '
        '
        '
        '
        Me.txtNombre.CustomButton.Image = Nothing
        Me.txtNombre.CustomButton.Location = New System.Drawing.Point(262, 2)
        Me.txtNombre.CustomButton.Name = ""
        Me.txtNombre.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNombre.CustomButton.TabIndex = 1
        Me.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNombre.CustomButton.UseSelectable = True
        Me.txtNombre.CustomButton.Visible = False
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(93, 34)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.SelectionLength = 0
        Me.txtNombre.SelectionStart = 0
        Me.txtNombre.ShortcutsEnabled = True
        Me.txtNombre.Size = New System.Drawing.Size(282, 22)
        Me.txtNombre.TabIndex = 88
        Me.txtNombre.UseSelectable = True
        Me.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'LblCliente
        '
        Me.LblCliente.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.LblCliente.ForeColor = System.Drawing.Color.Black
        Me.LblCliente.Location = New System.Drawing.Point(92, 10)
        Me.LblCliente.Name = "LblCliente"
        Me.LblCliente.Size = New System.Drawing.Size(79, 20)
        Me.LblCliente.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(410, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 19)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Ciudad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(670, 65)
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
        Me.Label6.Location = New System.Drawing.Point(10, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 19)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "N° Ext.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(410, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 19)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Estado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(649, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 19)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Código Postal:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(249, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 19)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Colonia:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(10, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 19)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Dirección:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(642, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 19)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Fecha del Pago"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmdFormaPago)
        Me.GroupBox2.Controls.Add(Me.btnCancelar)
        Me.GroupBox2.Controls.Add(Me.CmdCancelarPago)
        Me.GroupBox2.Controls.Add(Me.dtpFechaPago)
        Me.GroupBox2.Controls.Add(Me.btnComproPago)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(29, 567)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(887, 85)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        '
        'CmdFormaPago
        '
        Me.CmdFormaPago.FormattingEnabled = True
        Me.CmdFormaPago.ItemHeight = 23
        Me.CmdFormaPago.Items.AddRange(New Object() {"01-Efectivo", "02-Cheque nominativo", "03-Transferencia electrónica de fondos", "04-Tarjeta de crédito", "05-Monedero electrónico", "06-Dinero electrónico", "08-Vales de despensa", "12-Dación en pago", "13-Pago por subrogación", "14-Pago por consignación", "15-Condonación", "17-Compensación", "23-Novación", "24-Confusión", "25-Remisión de deuda", "26-Prescripción o caducidad", "27-A satisfacción del acreedor", "28-Tarjeta de débito", "29-Tarjeta de servicios", "30-Aplicación de anticipos", "99-Por definir"})
        Me.CmdFormaPago.Location = New System.Drawing.Point(9, 42)
        Me.CmdFormaPago.Name = "CmdFormaPago"
        Me.CmdFormaPago.Size = New System.Drawing.Size(336, 29)
        Me.CmdFormaPago.TabIndex = 87
        Me.CmdFormaPago.UseSelectable = True
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnCancelar.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.export_16px
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.Location = New System.Drawing.Point(399, 46)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(118, 23)
        Me.btnCancelar.TabIndex = 86
        Me.btnCancelar.Text = "Cancelar Factura"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'CmdCancelarPago
        '
        Me.CmdCancelarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdCancelarPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCancelarPago.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.CmdCancelarPago.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.export_16px
        Me.CmdCancelarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdCancelarPago.Location = New System.Drawing.Point(538, 46)
        Me.CmdCancelarPago.Margin = New System.Windows.Forms.Padding(2)
        Me.CmdCancelarPago.Name = "CmdCancelarPago"
        Me.CmdCancelarPago.Size = New System.Drawing.Size(118, 23)
        Me.CmdCancelarPago.TabIndex = 85
        Me.CmdCancelarPago.Text = "Cancelar Pago"
        Me.CmdCancelarPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdCancelarPago.UseVisualStyleBackColor = True
        '
        'dtpFechaPago
        '
        Me.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPago.Location = New System.Drawing.Point(759, 12)
        Me.dtpFechaPago.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpFechaPago.Name = "dtpFechaPago"
        Me.dtpFechaPago.Size = New System.Drawing.Size(121, 29)
        Me.dtpFechaPago.TabIndex = 84
        '
        'btnComproPago
        '
        Me.btnComproPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComproPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComproPago.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnComproPago.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.export_16px
        Me.btnComproPago.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnComproPago.Location = New System.Drawing.Point(733, 46)
        Me.btnComproPago.Margin = New System.Windows.Forms.Padding(2)
        Me.btnComproPago.Name = "btnComproPago"
        Me.btnComproPago.Size = New System.Drawing.Size(149, 23)
        Me.btnComproPago.TabIndex = 83
        Me.btnComproPago.Text = "Generar Complemento"
        Me.btnComproPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnComproPago.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnBuscar.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.search_16px
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.Location = New System.Drawing.Point(38, 75)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(116, 23)
        Me.btnBuscar.TabIndex = 80
        Me.btnBuscar.Text = "F2 - Buscar Cliente"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dtFechaInicial
        '
        Me.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaInicial.Location = New System.Drawing.Point(207, 79)
        Me.dtFechaInicial.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtFechaInicial.Name = "dtFechaInicial"
        Me.dtFechaInicial.Size = New System.Drawing.Size(121, 29)
        Me.dtFechaInicial.TabIndex = 81
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFinal.Location = New System.Drawing.Point(346, 76)
        Me.dtFechaFinal.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Size = New System.Drawing.Size(121, 29)
        Me.dtFechaFinal.TabIndex = 82
        '
        'chkCancelados
        '
        Me.chkCancelados.AutoSize = True
        Me.chkCancelados.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold
        Me.chkCancelados.Location = New System.Drawing.Point(507, 75)
        Me.chkCancelados.Name = "chkCancelados"
        Me.chkCancelados.Size = New System.Drawing.Size(122, 15)
        Me.chkCancelados.TabIndex = 83
        Me.chkCancelados.Text = "Quitar Cancelados"
        Me.chkCancelados.UseSelectable = True
        '
        'chkPagados
        '
        Me.chkPagados.AutoSize = True
        Me.chkPagados.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold
        Me.chkPagados.Location = New System.Drawing.Point(507, 96)
        Me.chkPagados.Name = "chkPagados"
        Me.chkPagados.Size = New System.Drawing.Size(106, 15)
        Me.chkPagados.TabIndex = 84
        Me.chkPagados.Text = "Quitar Pagados"
        Me.chkPagados.UseSelectable = True
        '
        'btnMostrar
        '
        Me.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnMostrar.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.search_16px
        Me.btnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMostrar.Location = New System.Drawing.Point(659, 79)
        Me.btnMostrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(87, 23)
        Me.btnMostrar.TabIndex = 85
        Me.btnMostrar.Text = "Filtrar"
        Me.btnMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'CmdLimpiar
        '
        Me.CmdLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdLimpiar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.CmdLimpiar.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.update_16px
        Me.CmdLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdLimpiar.Location = New System.Drawing.Point(769, 79)
        Me.CmdLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.CmdLimpiar.Name = "CmdLimpiar"
        Me.CmdLimpiar.Size = New System.Drawing.Size(122, 23)
        Me.CmdLimpiar.TabIndex = 86
        Me.CmdLimpiar.Text = "F3 - Limpiar Datos"
        Me.CmdLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdLimpiar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.Factura, Me.Total, Me.TipoVenta, Me.Cliente, Me.Condiciones, Me.MP, Me.FP, Me.UsoCFDI, Me.UUID, Me.C, Me.P, Me.SubTotal, Me.IVA, Me.ObjImp})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(29, 266)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(887, 307)
        Me.DataGridView1.TabIndex = 87
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(218, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 19)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Fecha Inicial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(370, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 19)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Fecha Final"
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 80
        '
        'Factura
        '
        Me.Factura.HeaderText = "Factura"
        Me.Factura.Name = "Factura"
        Me.Factura.Width = 80
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'TipoVenta
        '
        Me.TipoVenta.HeaderText = "Tipo Venta"
        Me.TipoVenta.Name = "TipoVenta"
        Me.TipoVenta.Visible = False
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Visible = False
        Me.Cliente.Width = 300
        '
        'Condiciones
        '
        Me.Condiciones.HeaderText = "Condiciones"
        Me.Condiciones.Name = "Condiciones"
        Me.Condiciones.Visible = False
        '
        'MP
        '
        Me.MP.HeaderText = "MP"
        Me.MP.Name = "MP"
        Me.MP.Width = 35
        '
        'FP
        '
        Me.FP.HeaderText = "FP"
        Me.FP.Name = "FP"
        Me.FP.Width = 35
        '
        'UsoCFDI
        '
        Me.UsoCFDI.HeaderText = "UsoCFDI"
        Me.UsoCFDI.Name = "UsoCFDI"
        Me.UsoCFDI.Width = 60
        '
        'UUID
        '
        Me.UUID.HeaderText = "UUID"
        Me.UUID.Name = "UUID"
        Me.UUID.Width = 300
        '
        'C
        '
        Me.C.HeaderText = "C"
        Me.C.Name = "C"
        '
        'P
        '
        Me.P.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.P.HeaderText = "P"
        Me.P.Name = "P"
        '
        'SubTotal
        '
        Me.SubTotal.HeaderText = "SubTotal"
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.Visible = False
        '
        'IVA
        '
        Me.IVA.HeaderText = "IVA"
        Me.IVA.Name = "IVA"
        Me.IVA.Visible = False
        '
        'ObjImp
        '
        Me.ObjImp.HeaderText = "ObjImp"
        Me.ObjImp.Name = "ObjImp"
        Me.ObjImp.Visible = False
        '
        'frmComplementoPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(946, 693)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CmdLimpiar)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.chkPagados)
        Me.Controls.Add(Me.chkCancelados)
        Me.Controls.Add(Me.dtFechaFinal)
        Me.Controls.Add(Me.dtFechaInicial)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.PrBImprimiendo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmComplementoPago"
        Me.Text = "Complemento de Pago Electrónico"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPago As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents PrBImprimiendo As ProgressBar
    Friend WithEvents Label12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LblCliente As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dtFechaInicial As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtFechaFinal As MetroFramework.Controls.MetroDateTime
    Friend WithEvents chkCancelados As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkPagados As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents btnMostrar As Button
    Friend WithEvents CmdLimpiar As Button
    Friend WithEvents dtpFechaPago As MetroFramework.Controls.MetroDateTime
    Friend WithEvents btnComproPago As Button
    Friend WithEvents DataGridView1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCP As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TxtRFC As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtColonia As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtEstado As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCiudad As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNumero As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDirecion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents CmdCancelarPago As Button
    Friend WithEvents CmdFormaPago As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtRFR As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Factura As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents TipoVenta As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Condiciones As DataGridViewTextBoxColumn
    Friend WithEvents MP As DataGridViewTextBoxColumn
    Friend WithEvents FP As DataGridViewTextBoxColumn
    Friend WithEvents UsoCFDI As DataGridViewTextBoxColumn
    Friend WithEvents UUID As DataGridViewTextBoxColumn
    Friend WithEvents C As DataGridViewCheckBoxColumn
    Friend WithEvents P As DataGridViewCheckBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
    Friend WithEvents IVA As DataGridViewTextBoxColumn
    Friend WithEvents ObjImp As DataGridViewTextBoxColumn
End Class
