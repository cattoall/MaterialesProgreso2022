<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHistorialCliente
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmdMostrar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New MetroFramework.Controls.MetroGrid()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtCliente = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.rdbCotizacion = New MetroFramework.Controls.MetroRadioButton()
        Me.rbtVentaPedido = New MetroFramework.Controls.MetroRadioButton()
        Me.rbtVenta = New MetroFramework.Controls.MetroRadioButton()
        Me.dtFechaFinal = New MetroFramework.Controls.MetroDateTime()
        Me.dtFechaInicial = New MetroFramework.Controls.MetroDateTime()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmdMostrar)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmdBuscar)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.MetroLabel4)
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Controls.Add(Me.MetroLabel3)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Controls.Add(Me.rdbCotizacion)
        Me.GroupBox1.Controls.Add(Me.rbtVentaPedido)
        Me.GroupBox1.Controls.Add(Me.rbtVenta)
        Me.GroupBox1.Controls.Add(Me.dtFechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtFechaInicial)
        Me.GroupBox1.Controls.Add(Me.LblTotal)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(868, 477)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CmdMostrar
        '
        Me.CmdMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdMostrar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.CmdMostrar.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.search_16px
        Me.CmdMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdMostrar.Location = New System.Drawing.Point(747, 22)
        Me.CmdMostrar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CmdMostrar.Name = "CmdMostrar"
        Me.CmdMostrar.Size = New System.Drawing.Size(97, 23)
        Me.CmdMostrar.TabIndex = 84
        Me.CmdMostrar.Text = "Mostrar Ventas"
        Me.CmdMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdMostrar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.close_window_16px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(769, 98)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 24)
        Me.Button1.TabIndex = 83
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdBuscar
        '
        Me.cmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cmdBuscar.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.search_16px
        Me.cmdBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdBuscar.Location = New System.Drawing.Point(479, 99)
        Me.cmdBuscar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 23)
        Me.cmdBuscar.TabIndex = 82
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
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
        Me.DataGridView1.Location = New System.Drawing.Point(24, 128)
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
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(820, 315)
        Me.DataGridView1.TabIndex = 67
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel4.Location = New System.Drawing.Point(583, 449)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(110, 19)
        Me.MetroLabel4.TabIndex = 66
        Me.MetroLabel4.Text = "Total de Ventas"
        '
        'txtCliente
        '
        '
        '
        '
        Me.txtCliente.CustomButton.Image = Nothing
        Me.txtCliente.CustomButton.Location = New System.Drawing.Point(218, 1)
        Me.txtCliente.CustomButton.Name = ""
        Me.txtCliente.CustomButton.Size = New System.Drawing.Size(16, 17)
        Me.txtCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCliente.CustomButton.TabIndex = 1
        Me.txtCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCliente.CustomButton.UseSelectable = True
        Me.txtCliente.CustomButton.Visible = False
        Me.txtCliente.Lines = New String() {"PUBLICO GENERAL"}
        Me.txtCliente.Location = New System.Drawing.Point(162, 99)
        Me.txtCliente.MaxLength = 32767
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCliente.SelectedText = ""
        Me.txtCliente.SelectionLength = 0
        Me.txtCliente.SelectionStart = 0
        Me.txtCliente.ShortcutsEnabled = True
        Me.txtCliente.Size = New System.Drawing.Size(312, 23)
        Me.txtCliente.TabIndex = 65
        Me.txtCliente.Text = "PUBLICO GENERAL"
        Me.txtCliente.UseSelectable = True
        Me.txtCliente.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCliente.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel3.Location = New System.Drawing.Point(20, 97)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(136, 19)
        Me.MetroLabel3.TabIndex = 64
        Me.MetroLabel3.Text = "Seleccionar Cliente"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.Location = New System.Drawing.Point(174, 26)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(82, 19)
        Me.MetroLabel2.TabIndex = 63
        Me.MetroLabel2.Text = "Fecha Final"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(24, 26)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(87, 19)
        Me.MetroLabel1.TabIndex = 62
        Me.MetroLabel1.Text = "Fecha Inicio"
        '
        'rdbCotizacion
        '
        Me.rdbCotizacion.AutoSize = True
        Me.rdbCotizacion.Location = New System.Drawing.Point(563, 65)
        Me.rdbCotizacion.Name = "rdbCotizacion"
        Me.rdbCotizacion.Size = New System.Drawing.Size(90, 15)
        Me.rdbCotizacion.TabIndex = 61
        Me.rdbCotizacion.Text = "Cotizaciones"
        Me.rdbCotizacion.UseSelectable = True
        '
        'rbtVentaPedido
        '
        Me.rbtVentaPedido.AutoSize = True
        Me.rbtVentaPedido.Location = New System.Drawing.Point(563, 43)
        Me.rbtVentaPedido.Name = "rbtVentaPedido"
        Me.rbtVentaPedido.Size = New System.Drawing.Size(65, 15)
        Me.rbtVentaPedido.TabIndex = 60
        Me.rbtVentaPedido.Text = "Pedidos"
        Me.rbtVentaPedido.UseSelectable = True
        '
        'rbtVenta
        '
        Me.rbtVenta.AutoSize = True
        Me.rbtVenta.Location = New System.Drawing.Point(563, 22)
        Me.rbtVenta.Name = "rbtVenta"
        Me.rbtVenta.Size = New System.Drawing.Size(59, 15)
        Me.rbtVenta.TabIndex = 59
        Me.rbtVenta.Text = "Tickets"
        Me.rbtVenta.UseSelectable = True
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.CustomFormat = "dd/MM/yyyy"
        Me.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFechaFinal.Location = New System.Drawing.Point(174, 48)
        Me.dtFechaFinal.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Size = New System.Drawing.Size(104, 30)
        Me.dtFechaFinal.TabIndex = 55
        '
        'dtFechaInicial
        '
        Me.dtFechaInicial.CustomFormat = "dd/MM/yyyy"
        Me.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFechaInicial.Location = New System.Drawing.Point(24, 48)
        Me.dtFechaInicial.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtFechaInicial.Name = "dtFechaInicial"
        Me.dtFechaInicial.Size = New System.Drawing.Size(104, 30)
        Me.dtFechaInicial.TabIndex = 54
        '
        'LblTotal
        '
        Me.LblTotal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(699, 446)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(145, 22)
        Me.LblTotal.TabIndex = 28
        Me.LblTotal.Text = "0.00"
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'FrmHistorialCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(889, 555)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmHistorialCliente"
        Me.Text = "Historial del Cliente"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents dtFechaFinal As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtFechaInicial As MetroFramework.Controls.MetroDateTime
    Friend WithEvents rdbCotizacion As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbtVentaPedido As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbtVenta As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCliente As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents DataGridView1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents Button1 As Button
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents CmdMostrar As Button
End Class
