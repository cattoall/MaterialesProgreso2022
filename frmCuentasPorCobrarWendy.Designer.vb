<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuentasPorCobrarWendy
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblresto = New MetroFramework.Controls.MetroTile()
        Me.MetroTile4 = New MetroFramework.Controls.MetroTile()
        Me.lblabonado = New MetroFramework.Controls.MetroTile()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.lblgrantotal = New MetroFramework.Controls.MetroTile()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.TxtDomicilio = New System.Windows.Forms.TextBox()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New MetroFramework.Controls.MetroGrid()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New MetroFramework.Controls.MetroGrid()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblresto
        '
        Me.lblresto.ActiveControl = Nothing
        Me.lblresto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblresto.Location = New System.Drawing.Point(851, 126)
        Me.lblresto.Name = "lblresto"
        Me.lblresto.Size = New System.Drawing.Size(207, 51)
        Me.lblresto.TabIndex = 95
        Me.lblresto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblresto.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.lblresto.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.lblresto.UseCustomBackColor = True
        Me.lblresto.UseSelectable = True
        '
        'MetroTile4
        '
        Me.MetroTile4.ActiveControl = Nothing
        Me.MetroTile4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MetroTile4.Location = New System.Drawing.Point(683, 126)
        Me.MetroTile4.Name = "MetroTile4"
        Me.MetroTile4.Size = New System.Drawing.Size(150, 51)
        Me.MetroTile4.TabIndex = 94
        Me.MetroTile4.Text = "Deuda"
        Me.MetroTile4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile4.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.MetroTile4.UseCustomBackColor = True
        Me.MetroTile4.UseSelectable = True
        '
        'lblabonado
        '
        Me.lblabonado.ActiveControl = Nothing
        Me.lblabonado.BackColor = System.Drawing.Color.LimeGreen
        Me.lblabonado.Location = New System.Drawing.Point(851, 69)
        Me.lblabonado.Name = "lblabonado"
        Me.lblabonado.Size = New System.Drawing.Size(207, 51)
        Me.lblabonado.TabIndex = 93
        Me.lblabonado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblabonado.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.lblabonado.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.lblabonado.UseCustomBackColor = True
        Me.lblabonado.UseSelectable = True
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.BackColor = System.Drawing.Color.Green
        Me.MetroTile2.Location = New System.Drawing.Point(683, 69)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(150, 51)
        Me.MetroTile2.TabIndex = 92
        Me.MetroTile2.Text = "Total Abonado"
        Me.MetroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.MetroTile2.UseCustomBackColor = True
        Me.MetroTile2.UseSelectable = True
        '
        'lblgrantotal
        '
        Me.lblgrantotal.ActiveControl = Nothing
        Me.lblgrantotal.BackColor = System.Drawing.Color.LimeGreen
        Me.lblgrantotal.Location = New System.Drawing.Point(851, 12)
        Me.lblgrantotal.Name = "lblgrantotal"
        Me.lblgrantotal.Size = New System.Drawing.Size(207, 51)
        Me.lblgrantotal.TabIndex = 91
        Me.lblgrantotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblgrantotal.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.lblgrantotal.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.lblgrantotal.UseCustomBackColor = True
        Me.lblgrantotal.UseSelectable = True
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.BackColor = System.Drawing.Color.Green
        Me.MetroTile1.Location = New System.Drawing.Point(683, 12)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(150, 51)
        Me.MetroTile1.TabIndex = 90
        Me.MetroTile1.Text = "Gran Total"
        Me.MetroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.MetroTile1.UseCustomBackColor = True
        Me.MetroTile1.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.Location = New System.Drawing.Point(19, 94)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel2.TabIndex = 89
        Me.MetroLabel2.Text = "Domicilio"
        '
        'TxtDomicilio
        '
        Me.TxtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDomicilio.Enabled = False
        Me.TxtDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDomicilio.Location = New System.Drawing.Point(98, 94)
        Me.TxtDomicilio.Multiline = True
        Me.TxtDomicilio.Name = "TxtDomicilio"
        Me.TxtDomicilio.Size = New System.Drawing.Size(399, 65)
        Me.TxtDomicilio.TabIndex = 87
        '
        'TxtCliente
        '
        Me.TxtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCliente.Enabled = False
        Me.TxtCliente.Location = New System.Drawing.Point(98, 69)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(399, 20)
        Me.TxtCliente.TabIndex = 86
        Me.TxtCliente.Text = "<PRESIONA F2 PARA SELECCIONAR UN CLIENTE>"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DataGridView2.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(1015, 439)
        Me.DataGridView2.TabIndex = 44
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1015, 439)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Histórico de Pagos"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1015, 439)
        Me.DataGridView1.TabIndex = 44
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1015, 439)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pendiente de Pago"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(39, 69)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(55, 19)
        Me.MetroLabel1.TabIndex = 88
        Me.MetroLabel1.Text = "Cliente"
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.TabPage1)
        Me.MetroTabControl1.Controls.Add(Me.TabPage2)
        Me.MetroTabControl1.Location = New System.Drawing.Point(35, 165)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 1
        Me.MetroTabControl1.Size = New System.Drawing.Size(1023, 481)
        Me.MetroTabControl1.TabIndex = 85
        Me.MetroTabControl1.UseSelectable = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.trash_can_16px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(486, 620)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 23)
        Me.Button1.TabIndex = 98
        Me.Button1.Text = "Cancelar Abono"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.close_window_16px
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(502, 136)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 97
        Me.Button2.Text = "Salir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnAdd.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.search_16px
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.Location = New System.Drawing.Point(502, 66)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 96
        Me.btnAdd.Text = "Buscar"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmCuentasPorCobrarWendy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 658)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblresto)
        Me.Controls.Add(Me.MetroTile4)
        Me.Controls.Add(Me.lblabonado)
        Me.Controls.Add(Me.MetroTile2)
        Me.Controls.Add(Me.lblgrantotal)
        Me.Controls.Add(Me.MetroTile1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.TxtDomicilio)
        Me.Controls.Add(Me.TxtCliente)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Name = "frmCuentasPorCobrarWendy"
        Me.Text = "Cuentas por Cobrar (Clientes) - Wendy"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.MetroTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblresto As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile4 As MetroFramework.Controls.MetroTile
    Friend WithEvents lblabonado As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents lblgrantotal As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TxtDomicilio As TextBox
    Friend WithEvents TxtCliente As TextBox
    Friend WithEvents DataGridView2 As MetroFramework.Controls.MetroGrid
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents ToolTip1 As ToolTip
End Class
