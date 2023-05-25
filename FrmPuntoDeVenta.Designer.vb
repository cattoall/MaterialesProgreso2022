<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPuntoDeVenta
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPuntoDeVenta))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnBuscarC = New System.Windows.Forms.Button()
        Me.btnBuscarP = New System.Windows.Forms.Button()
        Me.btnDescuento = New System.Windows.Forms.Button()
        Me.btnCobrar = New System.Windows.Forms.Button()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtTotalTasaCero = New MetroFramework.Controls.MetroTextBox()
        Me.txtIVATasaCero = New MetroFramework.Controls.MetroTextBox()
        Me.txtSubTotalTasaCero = New MetroFramework.Controls.MetroTextBox()
        Me.txtTotal = New MetroFramework.Controls.MetroTextBox()
        Me.txtIVA = New MetroFramework.Controls.MetroTextBox()
        Me.txtSubTotal = New MetroFramework.Controls.MetroTextBox()
        Me.CmbTipoVenta = New MetroFramework.Controls.MetroComboBox()
        Me.CmbDocto = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.lblIdCliente = New MetroFramework.Controls.MetroLabel()
        Me.txtIdCliente = New MetroFramework.Controls.MetroTextBox()
        Me.txtProducto = New MetroFramework.Controls.MetroTextBox()
        Me.txtDomicilio = New MetroFramework.Controls.MetroTextBox()
        Me.txtCliente = New MetroFramework.Controls.MetroTextBox()
        Me.ImgLogo = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Ctd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Código = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClvProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClvUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TasaCero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroPanel1.Controls.Add(Me.DataGridView1)
        Me.MetroPanel1.Controls.Add(Me.btnBuscarC)
        Me.MetroPanel1.Controls.Add(Me.btnBuscarP)
        Me.MetroPanel1.Controls.Add(Me.btnDescuento)
        Me.MetroPanel1.Controls.Add(Me.btnCobrar)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel6)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel7)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel8)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel1.Controls.Add(Me.txtTotalTasaCero)
        Me.MetroPanel1.Controls.Add(Me.txtIVATasaCero)
        Me.MetroPanel1.Controls.Add(Me.txtSubTotalTasaCero)
        Me.MetroPanel1.Controls.Add(Me.txtTotal)
        Me.MetroPanel1.Controls.Add(Me.txtIVA)
        Me.MetroPanel1.Controls.Add(Me.txtSubTotal)
        Me.MetroPanel1.Controls.Add(Me.CmbTipoVenta)
        Me.MetroPanel1.Controls.Add(Me.CmbDocto)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.Controls.Add(Me.lblIdCliente)
        Me.MetroPanel1.Controls.Add(Me.txtIdCliente)
        Me.MetroPanel1.Controls.Add(Me.txtProducto)
        Me.MetroPanel1.Controls.Add(Me.txtDomicilio)
        Me.MetroPanel1.Controls.Add(Me.txtCliente)
        Me.MetroPanel1.Controls.Add(Me.ImgLogo)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(23, 63)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(1210, 654)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ctd, Me.IdProducto, Me.Descripción, Me.PU, Me.SubTotal, Me.Código, Me.Desc, Me.PUDesc, Me.STDesc, Me.PreCost, Me.STCosto, Me.ClvProd, Me.ClvUnidad, Me.TasaCero})
        Me.DataGridView1.Location = New System.Drawing.Point(19, 227)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle17
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(1172, 311)
        Me.DataGridView1.TabIndex = 2
        '
        'btnBuscarC
        '
        Me.btnBuscarC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarC.Image = CType(resources.GetObject("btnBuscarC.Image"), System.Drawing.Image)
        Me.btnBuscarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarC.Location = New System.Drawing.Point(714, 24)
        Me.btnBuscarC.Name = "btnBuscarC"
        Me.btnBuscarC.Size = New System.Drawing.Size(75, 30)
        Me.btnBuscarC.TabIndex = 157
        Me.btnBuscarC.Text = "(F6)"
        Me.btnBuscarC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarC.UseVisualStyleBackColor = True
        '
        'btnBuscarP
        '
        Me.btnBuscarP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarP.Image = CType(resources.GetObject("btnBuscarP.Image"), System.Drawing.Image)
        Me.btnBuscarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarP.Location = New System.Drawing.Point(714, 168)
        Me.btnBuscarP.Name = "btnBuscarP"
        Me.btnBuscarP.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarP.TabIndex = 156
        Me.btnBuscarP.Text = "(F2)"
        Me.btnBuscarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarP.UseVisualStyleBackColor = True
        '
        'btnDescuento
        '
        Me.btnDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescuento.Image = CType(resources.GetObject("btnDescuento.Image"), System.Drawing.Image)
        Me.btnDescuento.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDescuento.Location = New System.Drawing.Point(985, 155)
        Me.btnDescuento.Name = "btnDescuento"
        Me.btnDescuento.Size = New System.Drawing.Size(100, 66)
        Me.btnDescuento.TabIndex = 5
        Me.btnDescuento.Text = "(F8)"
        Me.btnDescuento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDescuento.UseVisualStyleBackColor = True
        '
        'btnCobrar
        '
        Me.btnCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCobrar.Image = CType(resources.GetObject("btnCobrar.Image"), System.Drawing.Image)
        Me.btnCobrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCobrar.Location = New System.Drawing.Point(1091, 155)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(100, 66)
        Me.btnCobrar.TabIndex = 6
        Me.btnCobrar.Text = " (F9)"
        Me.btnCobrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCobrar.UseVisualStyleBackColor = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel6.Location = New System.Drawing.Point(621, 605)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(132, 25)
        Me.MetroLabel6.TabIndex = 153
        Me.MetroLabel6.Text = "Total Tasa 0%:"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel7.Location = New System.Drawing.Point(675, 576)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(78, 25)
        Me.MetroLabel7.TabIndex = 152
        Me.MetroLabel7.Text = "IVA 0%:"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel8.Location = New System.Drawing.Point(589, 547)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(164, 25)
        Me.MetroLabel8.TabIndex = 151
        Me.MetroLabel8.Text = "SubTotal Tasa 0%:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel5.Location = New System.Drawing.Point(962, 605)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(59, 25)
        Me.MetroLabel5.TabIndex = 150
        Me.MetroLabel5.Text = "Total:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel4.Location = New System.Drawing.Point(933, 576)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(88, 25)
        Me.MetroLabel4.TabIndex = 149
        Me.MetroLabel4.Text = "IVA 16%:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel3.Location = New System.Drawing.Point(930, 547)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(91, 25)
        Me.MetroLabel3.TabIndex = 148
        Me.MetroLabel3.Text = "SubTotal:"
        '
        'txtTotalTasaCero
        '
        '
        '
        '
        Me.txtTotalTasaCero.CustomButton.Image = Nothing
        Me.txtTotalTasaCero.CustomButton.Location = New System.Drawing.Point(107, 2)
        Me.txtTotalTasaCero.CustomButton.Name = ""
        Me.txtTotalTasaCero.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtTotalTasaCero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTotalTasaCero.CustomButton.TabIndex = 1
        Me.txtTotalTasaCero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTotalTasaCero.CustomButton.UseSelectable = True
        Me.txtTotalTasaCero.CustomButton.Visible = False
        Me.txtTotalTasaCero.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtTotalTasaCero.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtTotalTasaCero.Lines = New String() {"0.00"}
        Me.txtTotalTasaCero.Location = New System.Drawing.Point(764, 602)
        Me.txtTotalTasaCero.MaxLength = 32767
        Me.txtTotalTasaCero.Name = "txtTotalTasaCero"
        Me.txtTotalTasaCero.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalTasaCero.ReadOnly = True
        Me.txtTotalTasaCero.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTotalTasaCero.SelectedText = ""
        Me.txtTotalTasaCero.SelectionLength = 0
        Me.txtTotalTasaCero.SelectionStart = 0
        Me.txtTotalTasaCero.ShortcutsEnabled = True
        Me.txtTotalTasaCero.Size = New System.Drawing.Size(135, 30)
        Me.txtTotalTasaCero.TabIndex = 147
        Me.txtTotalTasaCero.Text = "0.00"
        Me.txtTotalTasaCero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalTasaCero.UseSelectable = True
        Me.txtTotalTasaCero.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTotalTasaCero.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtIVATasaCero
        '
        '
        '
        '
        Me.txtIVATasaCero.CustomButton.Image = Nothing
        Me.txtIVATasaCero.CustomButton.Location = New System.Drawing.Point(107, 2)
        Me.txtIVATasaCero.CustomButton.Name = ""
        Me.txtIVATasaCero.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtIVATasaCero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtIVATasaCero.CustomButton.TabIndex = 1
        Me.txtIVATasaCero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtIVATasaCero.CustomButton.UseSelectable = True
        Me.txtIVATasaCero.CustomButton.Visible = False
        Me.txtIVATasaCero.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtIVATasaCero.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtIVATasaCero.Lines = New String() {"0.00"}
        Me.txtIVATasaCero.Location = New System.Drawing.Point(764, 573)
        Me.txtIVATasaCero.MaxLength = 32767
        Me.txtIVATasaCero.Name = "txtIVATasaCero"
        Me.txtIVATasaCero.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIVATasaCero.ReadOnly = True
        Me.txtIVATasaCero.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIVATasaCero.SelectedText = ""
        Me.txtIVATasaCero.SelectionLength = 0
        Me.txtIVATasaCero.SelectionStart = 0
        Me.txtIVATasaCero.ShortcutsEnabled = True
        Me.txtIVATasaCero.Size = New System.Drawing.Size(135, 30)
        Me.txtIVATasaCero.TabIndex = 146
        Me.txtIVATasaCero.Text = "0.00"
        Me.txtIVATasaCero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIVATasaCero.UseSelectable = True
        Me.txtIVATasaCero.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtIVATasaCero.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtSubTotalTasaCero
        '
        '
        '
        '
        Me.txtSubTotalTasaCero.CustomButton.Image = Nothing
        Me.txtSubTotalTasaCero.CustomButton.Location = New System.Drawing.Point(107, 2)
        Me.txtSubTotalTasaCero.CustomButton.Name = ""
        Me.txtSubTotalTasaCero.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtSubTotalTasaCero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSubTotalTasaCero.CustomButton.TabIndex = 1
        Me.txtSubTotalTasaCero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSubTotalTasaCero.CustomButton.UseSelectable = True
        Me.txtSubTotalTasaCero.CustomButton.Visible = False
        Me.txtSubTotalTasaCero.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtSubTotalTasaCero.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtSubTotalTasaCero.Lines = New String() {"0.00"}
        Me.txtSubTotalTasaCero.Location = New System.Drawing.Point(764, 544)
        Me.txtSubTotalTasaCero.MaxLength = 32767
        Me.txtSubTotalTasaCero.Name = "txtSubTotalTasaCero"
        Me.txtSubTotalTasaCero.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubTotalTasaCero.ReadOnly = True
        Me.txtSubTotalTasaCero.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSubTotalTasaCero.SelectedText = ""
        Me.txtSubTotalTasaCero.SelectionLength = 0
        Me.txtSubTotalTasaCero.SelectionStart = 0
        Me.txtSubTotalTasaCero.ShortcutsEnabled = True
        Me.txtSubTotalTasaCero.Size = New System.Drawing.Size(135, 30)
        Me.txtSubTotalTasaCero.TabIndex = 145
        Me.txtSubTotalTasaCero.Text = "0.00"
        Me.txtSubTotalTasaCero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSubTotalTasaCero.UseSelectable = True
        Me.txtSubTotalTasaCero.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSubTotalTasaCero.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtTotal
        '
        '
        '
        '
        Me.txtTotal.CustomButton.Image = Nothing
        Me.txtTotal.CustomButton.Location = New System.Drawing.Point(136, 2)
        Me.txtTotal.CustomButton.Name = ""
        Me.txtTotal.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTotal.CustomButton.TabIndex = 1
        Me.txtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTotal.CustomButton.UseSelectable = True
        Me.txtTotal.CustomButton.Visible = False
        Me.txtTotal.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtTotal.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtTotal.Lines = New String() {"0.00"}
        Me.txtTotal.Location = New System.Drawing.Point(1027, 602)
        Me.txtTotal.MaxLength = 32767
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTotal.SelectedText = ""
        Me.txtTotal.SelectionLength = 0
        Me.txtTotal.SelectionStart = 0
        Me.txtTotal.ShortcutsEnabled = True
        Me.txtTotal.Size = New System.Drawing.Size(164, 30)
        Me.txtTotal.TabIndex = 144
        Me.txtTotal.Text = "0.00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotal.UseSelectable = True
        Me.txtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTotal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtIVA
        '
        '
        '
        '
        Me.txtIVA.CustomButton.Image = Nothing
        Me.txtIVA.CustomButton.Location = New System.Drawing.Point(136, 2)
        Me.txtIVA.CustomButton.Name = ""
        Me.txtIVA.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtIVA.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtIVA.CustomButton.TabIndex = 1
        Me.txtIVA.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtIVA.CustomButton.UseSelectable = True
        Me.txtIVA.CustomButton.Visible = False
        Me.txtIVA.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtIVA.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtIVA.Lines = New String() {"0.00"}
        Me.txtIVA.Location = New System.Drawing.Point(1027, 573)
        Me.txtIVA.MaxLength = 32767
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIVA.ReadOnly = True
        Me.txtIVA.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIVA.SelectedText = ""
        Me.txtIVA.SelectionLength = 0
        Me.txtIVA.SelectionStart = 0
        Me.txtIVA.ShortcutsEnabled = True
        Me.txtIVA.Size = New System.Drawing.Size(164, 30)
        Me.txtIVA.TabIndex = 143
        Me.txtIVA.Text = "0.00"
        Me.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIVA.UseSelectable = True
        Me.txtIVA.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtIVA.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtSubTotal
        '
        '
        '
        '
        Me.txtSubTotal.CustomButton.Image = Nothing
        Me.txtSubTotal.CustomButton.Location = New System.Drawing.Point(136, 2)
        Me.txtSubTotal.CustomButton.Name = ""
        Me.txtSubTotal.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtSubTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSubTotal.CustomButton.TabIndex = 1
        Me.txtSubTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSubTotal.CustomButton.UseSelectable = True
        Me.txtSubTotal.CustomButton.Visible = False
        Me.txtSubTotal.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtSubTotal.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtSubTotal.Lines = New String() {"0.00"}
        Me.txtSubTotal.Location = New System.Drawing.Point(1027, 544)
        Me.txtSubTotal.MaxLength = 32767
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSubTotal.SelectedText = ""
        Me.txtSubTotal.SelectionLength = 0
        Me.txtSubTotal.SelectionStart = 0
        Me.txtSubTotal.ShortcutsEnabled = True
        Me.txtSubTotal.Size = New System.Drawing.Size(164, 30)
        Me.txtSubTotal.TabIndex = 142
        Me.txtSubTotal.Text = "0.00"
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSubTotal.UseSelectable = True
        Me.txtSubTotal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSubTotal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'CmbTipoVenta
        '
        Me.CmbTipoVenta.FontSize = MetroFramework.MetroComboBoxSize.Tall
        Me.CmbTipoVenta.FontWeight = MetroFramework.MetroComboBoxWeight.Bold
        Me.CmbTipoVenta.FormattingEnabled = True
        Me.CmbTipoVenta.ItemHeight = 29
        Me.CmbTipoVenta.Items.AddRange(New Object() {"CONTADO", "CREDITO"})
        Me.CmbTipoVenta.Location = New System.Drawing.Point(1020, 65)
        Me.CmbTipoVenta.Name = "CmbTipoVenta"
        Me.CmbTipoVenta.PromptText = "Tipo de Venta"
        Me.CmbTipoVenta.Size = New System.Drawing.Size(171, 35)
        Me.CmbTipoVenta.TabIndex = 4
        Me.CmbTipoVenta.UseSelectable = True
        '
        'CmbDocto
        '
        Me.CmbDocto.FontSize = MetroFramework.MetroComboBoxSize.Tall
        Me.CmbDocto.FontWeight = MetroFramework.MetroComboBoxWeight.Bold
        Me.CmbDocto.FormattingEnabled = True
        Me.CmbDocto.ItemHeight = 29
        Me.CmbDocto.Items.AddRange(New Object() {"TICKET", "PEDIDO", "COTIZACION"})
        Me.CmbDocto.Location = New System.Drawing.Point(1020, 24)
        Me.CmbDocto.Name = "CmbDocto"
        Me.CmbDocto.PromptText = "Documento"
        Me.CmbDocto.Size = New System.Drawing.Size(171, 35)
        Me.CmbDocto.TabIndex = 3
        Me.CmbDocto.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.Location = New System.Drawing.Point(883, 70)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(135, 25)
        Me.MetroLabel2.TabIndex = 137
        Me.MetroLabel2.Text = "Tipo de Venta:"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(898, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(116, 25)
        Me.MetroLabel1.TabIndex = 136
        Me.MetroLabel1.Text = "Documento:"
        '
        'lblIdCliente
        '
        Me.lblIdCliente.AutoSize = True
        Me.lblIdCliente.Location = New System.Drawing.Point(865, 37)
        Me.lblIdCliente.Name = "lblIdCliente"
        Me.lblIdCliente.Size = New System.Drawing.Size(0, 0)
        Me.lblIdCliente.TabIndex = 135
        '
        'txtIdCliente
        '
        Me.txtIdCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtIdCliente.CustomButton.Image = Nothing
        Me.txtIdCliente.CustomButton.Location = New System.Drawing.Point(9, 1)
        Me.txtIdCliente.CustomButton.Name = ""
        Me.txtIdCliente.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtIdCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtIdCliente.CustomButton.TabIndex = 1
        Me.txtIdCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtIdCliente.CustomButton.UseSelectable = True
        Me.txtIdCliente.CustomButton.Visible = False
        Me.txtIdCliente.Enabled = False
        Me.txtIdCliente.Lines = New String(-1) {}
        Me.txtIdCliente.Location = New System.Drawing.Point(820, 24)
        Me.txtIdCliente.MaxLength = 32767
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdCliente.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIdCliente.SelectedText = ""
        Me.txtIdCliente.SelectionLength = 0
        Me.txtIdCliente.SelectionStart = 0
        Me.txtIdCliente.ShortcutsEnabled = True
        Me.txtIdCliente.Size = New System.Drawing.Size(31, 23)
        Me.txtIdCliente.TabIndex = 134
        Me.txtIdCliente.UseSelectable = True
        Me.txtIdCliente.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtIdCliente.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtProducto
        '
        Me.txtProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtProducto.CustomButton.Image = Nothing
        Me.txtProducto.CustomButton.Location = New System.Drawing.Point(458, 1)
        Me.txtProducto.CustomButton.Name = ""
        Me.txtProducto.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtProducto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtProducto.CustomButton.TabIndex = 1
        Me.txtProducto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtProducto.CustomButton.UseSelectable = True
        Me.txtProducto.CustomButton.Visible = False
        Me.txtProducto.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtProducto.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtProducto.Lines = New String(-1) {}
        Me.txtProducto.Location = New System.Drawing.Point(232, 168)
        Me.txtProducto.MaxLength = 32767
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProducto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtProducto.SelectedText = ""
        Me.txtProducto.SelectionLength = 0
        Me.txtProducto.SelectionStart = 0
        Me.txtProducto.ShortcutsEnabled = True
        Me.txtProducto.Size = New System.Drawing.Size(480, 23)
        Me.txtProducto.TabIndex = 1
        Me.txtProducto.UseSelectable = True
        Me.txtProducto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtProducto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDomicilio
        '
        Me.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtDomicilio.CustomButton.Image = Nothing
        Me.txtDomicilio.CustomButton.Location = New System.Drawing.Point(372, 1)
        Me.txtDomicilio.CustomButton.Name = ""
        Me.txtDomicilio.CustomButton.Size = New System.Drawing.Size(107, 107)
        Me.txtDomicilio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDomicilio.CustomButton.TabIndex = 1
        Me.txtDomicilio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDomicilio.CustomButton.UseSelectable = True
        Me.txtDomicilio.CustomButton.Visible = False
        Me.txtDomicilio.Enabled = False
        Me.txtDomicilio.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtDomicilio.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtDomicilio.Lines = New String(-1) {}
        Me.txtDomicilio.Location = New System.Drawing.Point(232, 53)
        Me.txtDomicilio.MaxLength = 32767
        Me.txtDomicilio.Multiline = True
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDomicilio.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDomicilio.SelectedText = ""
        Me.txtDomicilio.SelectionLength = 0
        Me.txtDomicilio.SelectionStart = 0
        Me.txtDomicilio.ShortcutsEnabled = True
        Me.txtDomicilio.Size = New System.Drawing.Size(480, 109)
        Me.txtDomicilio.TabIndex = 132
        Me.txtDomicilio.UseSelectable = True
        Me.txtDomicilio.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDomicilio.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCliente
        '
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtCliente.CustomButton.Image = Nothing
        Me.txtCliente.CustomButton.Location = New System.Drawing.Point(452, 2)
        Me.txtCliente.CustomButton.Name = ""
        Me.txtCliente.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCliente.CustomButton.TabIndex = 1
        Me.txtCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCliente.CustomButton.UseSelectable = True
        Me.txtCliente.CustomButton.Visible = False
        Me.txtCliente.Enabled = False
        Me.txtCliente.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtCliente.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtCliente.Lines = New String() {"PUBLICO GENERAL"}
        Me.txtCliente.Location = New System.Drawing.Point(232, 24)
        Me.txtCliente.MaxLength = 32767
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCliente.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCliente.SelectedText = ""
        Me.txtCliente.SelectionLength = 0
        Me.txtCliente.SelectionStart = 0
        Me.txtCliente.ShortcutsEnabled = True
        Me.txtCliente.Size = New System.Drawing.Size(480, 30)
        Me.txtCliente.TabIndex = 131
        Me.txtCliente.Text = "PUBLICO GENERAL"
        Me.txtCliente.UseSelectable = True
        Me.txtCliente.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCliente.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ImgLogo
        '
        Me.ImgLogo.BackColor = System.Drawing.Color.Transparent
        Me.ImgLogo.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.LOGOLINEALNO
        Me.ImgLogo.Location = New System.Drawing.Point(19, 24)
        Me.ImgLogo.Name = "ImgLogo"
        Me.ImgLogo.Size = New System.Drawing.Size(207, 197)
        Me.ImgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgLogo.TabIndex = 94
        Me.ImgLogo.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'Ctd
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ctd.DefaultCellStyle = DataGridViewCellStyle3
        Me.Ctd.HeaderText = "Ctd"
        Me.Ctd.Name = "Ctd"
        Me.Ctd.ReadOnly = True
        Me.Ctd.Width = 60
        '
        'IdProducto
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdProducto.DefaultCellStyle = DataGridViewCellStyle4
        Me.IdProducto.HeaderText = "IdProducto"
        Me.IdProducto.Name = "IdProducto"
        Me.IdProducto.ReadOnly = True
        Me.IdProducto.Visible = False
        '
        'Descripción
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripción.DefaultCellStyle = DataGridViewCellStyle5
        Me.Descripción.HeaderText = "Descripción"
        Me.Descripción.Name = "Descripción"
        Me.Descripción.ReadOnly = True
        Me.Descripción.Width = 350
        '
        'PU
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PU.DefaultCellStyle = DataGridViewCellStyle6
        Me.PU.HeaderText = "P.U."
        Me.PU.Name = "PU"
        Me.PU.ReadOnly = True
        Me.PU.Width = 120
        '
        'SubTotal
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTotal.DefaultCellStyle = DataGridViewCellStyle7
        Me.SubTotal.HeaderText = "SubTotal"
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.ReadOnly = True
        Me.SubTotal.Width = 120
        '
        'Código
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Código.DefaultCellStyle = DataGridViewCellStyle8
        Me.Código.HeaderText = "Código"
        Me.Código.Name = "Código"
        Me.Código.ReadOnly = True
        Me.Código.Width = 120
        '
        'Desc
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desc.DefaultCellStyle = DataGridViewCellStyle9
        Me.Desc.HeaderText = "(-%)"
        Me.Desc.Name = "Desc"
        Me.Desc.ReadOnly = True
        Me.Desc.Width = 120
        '
        'PUDesc
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PUDesc.DefaultCellStyle = DataGridViewCellStyle10
        Me.PUDesc.HeaderText = "P.U. (-%)"
        Me.PUDesc.Name = "PUDesc"
        Me.PUDesc.ReadOnly = True
        Me.PUDesc.Width = 120
        '
        'STDesc
        '
        Me.STDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STDesc.DefaultCellStyle = DataGridViewCellStyle11
        Me.STDesc.HeaderText = "S.T. (-%)"
        Me.STDesc.Name = "STDesc"
        Me.STDesc.ReadOnly = True
        '
        'PreCost
        '
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreCost.DefaultCellStyle = DataGridViewCellStyle12
        Me.PreCost.HeaderText = "PreCost"
        Me.PreCost.Name = "PreCost"
        Me.PreCost.ReadOnly = True
        Me.PreCost.Visible = False
        '
        'STCosto
        '
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STCosto.DefaultCellStyle = DataGridViewCellStyle13
        Me.STCosto.HeaderText = "STCosto"
        Me.STCosto.Name = "STCosto"
        Me.STCosto.ReadOnly = True
        Me.STCosto.Visible = False
        '
        'ClvProd
        '
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClvProd.DefaultCellStyle = DataGridViewCellStyle14
        Me.ClvProd.HeaderText = "ClvProd"
        Me.ClvProd.Name = "ClvProd"
        Me.ClvProd.ReadOnly = True
        Me.ClvProd.Visible = False
        '
        'ClvUnidad
        '
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClvUnidad.DefaultCellStyle = DataGridViewCellStyle15
        Me.ClvUnidad.HeaderText = "ClvUnidad"
        Me.ClvUnidad.Name = "ClvUnidad"
        Me.ClvUnidad.ReadOnly = True
        Me.ClvUnidad.Visible = False
        '
        'TasaCero
        '
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TasaCero.DefaultCellStyle = DataGridViewCellStyle16
        Me.TasaCero.HeaderText = "TasaCero"
        Me.TasaCero.Name = "TasaCero"
        Me.TasaCero.ReadOnly = True
        Me.TasaCero.Visible = False
        '
        'FrmPuntoDeVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1256, 740)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroPanel1)
        Me.KeyPreview = True
        Me.Name = "FrmPuntoDeVenta"
        Me.Text = "Punto de Venta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblTipoDeVetna As Label
    Friend WithEvents ImgLogo As PictureBox
    Friend WithEvents lblDocumento As Label
    Friend WithEvents txtCliente As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDomicilio As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtProducto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents CmbTipoVenta As MetroFramework.Controls.MetroComboBox
    Friend WithEvents CmbDocto As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtIdCliente As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblIdCliente As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTotalTasaCero As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtIVATasaCero As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSubTotalTasaCero As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTotal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtIVA As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSubTotal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnCobrar As Button
    Friend WithEvents btnDescuento As Button
    Friend WithEvents btnBuscarP As Button
    Friend WithEvents btnBuscarC As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Ctd As DataGridViewTextBoxColumn
    Friend WithEvents IdProducto As DataGridViewTextBoxColumn
    Friend WithEvents Descripción As DataGridViewTextBoxColumn
    Friend WithEvents PU As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
    Friend WithEvents Código As DataGridViewTextBoxColumn
    Friend WithEvents Desc As DataGridViewTextBoxColumn
    Friend WithEvents PUDesc As DataGridViewTextBoxColumn
    Friend WithEvents STDesc As DataGridViewTextBoxColumn
    Friend WithEvents PreCost As DataGridViewTextBoxColumn
    Friend WithEvents STCosto As DataGridViewTextBoxColumn
    Friend WithEvents ClvProd As DataGridViewTextBoxColumn
    Friend WithEvents ClvUnidad As DataGridViewTextBoxColumn
    Friend WithEvents TasaCero As DataGridViewTextBoxColumn
End Class
