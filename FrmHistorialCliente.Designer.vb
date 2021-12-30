<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHistorialCliente
    Inherits System.Windows.Forms.Form

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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ImgVentasB = New System.Windows.Forms.PictureBox()
        Me.ImgVentasA = New System.Windows.Forms.PictureBox()
        Me.ImgSalirB = New System.Windows.Forms.PictureBox()
        Me.ImgSalirA = New System.Windows.Forms.PictureBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.rdbCotizacion = New System.Windows.Forms.RadioButton()
        Me.rbtVentaPedido = New System.Windows.Forms.RadioButton()
        Me.rbtVenta = New System.Windows.Forms.RadioButton()
        Me.lblelejir = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.ImgBuscarB = New System.Windows.Forms.PictureBox()
        Me.ImgBuscarA = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ImgVentasB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgVentasA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSalirB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSalirA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgBuscarB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgBuscarA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.GroupBox1.Controls.Add(Me.ImgVentasB)
        Me.GroupBox1.Controls.Add(Me.ImgVentasA)
        Me.GroupBox1.Controls.Add(Me.ImgSalirB)
        Me.GroupBox1.Controls.Add(Me.ImgSalirA)
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Controls.Add(Me.LblTotal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.rdbCotizacion)
        Me.GroupBox1.Controls.Add(Me.rbtVentaPedido)
        Me.GroupBox1.Controls.Add(Me.rbtVenta)
        Me.GroupBox1.Controls.Add(Me.lblelejir)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtFechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtFechaInicial)
        Me.GroupBox1.Controls.Add(Me.ImgBuscarB)
        Me.GroupBox1.Controls.Add(Me.ImgBuscarA)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(868, 477)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ImgVentasB
        '
        Me.ImgVentasB.BackColor = System.Drawing.Color.Transparent
        Me.ImgVentasB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgVentasB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.salesrun
        Me.ImgVentasB.Location = New System.Drawing.Point(754, 28)
        Me.ImgVentasB.Name = "ImgVentasB"
        Me.ImgVentasB.Size = New System.Drawing.Size(44, 45)
        Me.ImgVentasB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgVentasB.TabIndex = 51
        Me.ImgVentasB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgVentasB, "Ver Ventas")
        Me.ImgVentasB.Visible = False
        '
        'ImgVentasA
        '
        Me.ImgVentasA.BackColor = System.Drawing.Color.Transparent
        Me.ImgVentasA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.salesrun
        Me.ImgVentasA.Location = New System.Drawing.Point(756, 32)
        Me.ImgVentasA.Name = "ImgVentasA"
        Me.ImgVentasA.Size = New System.Drawing.Size(40, 38)
        Me.ImgVentasA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgVentasA.TabIndex = 50
        Me.ImgVentasA.TabStop = False
        '
        'ImgSalirB
        '
        Me.ImgSalirB.BackColor = System.Drawing.Color.Transparent
        Me.ImgSalirB.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ImgSalirB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgSalirB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.btn_salir
        Me.ImgSalirB.Location = New System.Drawing.Point(730, 86)
        Me.ImgSalirB.Name = "ImgSalirB"
        Me.ImgSalirB.Size = New System.Drawing.Size(94, 35)
        Me.ImgSalirB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSalirB.TabIndex = 44
        Me.ImgSalirB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgSalirB, "Salir (Esc)")
        Me.ImgSalirB.Visible = False
        '
        'ImgSalirA
        '
        Me.ImgSalirA.BackColor = System.Drawing.Color.Transparent
        Me.ImgSalirA.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ImgSalirA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgSalirA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.btn_salir
        Me.ImgSalirA.Location = New System.Drawing.Point(733, 87)
        Me.ImgSalirA.Name = "ImgSalirA"
        Me.ImgSalirA.Size = New System.Drawing.Size(88, 31)
        Me.ImgSalirA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSalirA.TabIndex = 43
        Me.ImgSalirA.TabStop = False
        '
        'txtCliente
        '
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(137, 97)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(371, 26)
        Me.txtCliente.TabIndex = 29
        Me.txtCliente.Text = "PUBLICO GENERAL"
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(584, 441)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 32)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Total de Ventas: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(20, 128)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(824, 312)
        Me.DataGridView1.TabIndex = 26
        '
        'rdbCotizacion
        '
        Me.rdbCotizacion.AutoSize = True
        Me.rdbCotizacion.BackColor = System.Drawing.Color.Transparent
        Me.rdbCotizacion.Location = New System.Drawing.Point(563, 84)
        Me.rdbCotizacion.Name = "rdbCotizacion"
        Me.rdbCotizacion.Size = New System.Drawing.Size(111, 23)
        Me.rdbCotizacion.TabIndex = 25
        Me.rdbCotizacion.TabStop = True
        Me.rdbCotizacion.Text = "Cotizaciones"
        Me.rdbCotizacion.UseVisualStyleBackColor = False
        '
        'rbtVentaPedido
        '
        Me.rbtVentaPedido.AutoSize = True
        Me.rbtVentaPedido.BackColor = System.Drawing.Color.Transparent
        Me.rbtVentaPedido.Location = New System.Drawing.Point(563, 64)
        Me.rbtVentaPedido.Name = "rbtVentaPedido"
        Me.rbtVentaPedido.Size = New System.Drawing.Size(115, 23)
        Me.rbtVentaPedido.TabIndex = 24
        Me.rbtVentaPedido.TabStop = True
        Me.rbtVentaPedido.Text = "Venta Pedido"
        Me.rbtVentaPedido.UseVisualStyleBackColor = False
        '
        'rbtVenta
        '
        Me.rbtVenta.AutoSize = True
        Me.rbtVenta.BackColor = System.Drawing.Color.Transparent
        Me.rbtVenta.Location = New System.Drawing.Point(563, 43)
        Me.rbtVenta.Name = "rbtVenta"
        Me.rbtVenta.Size = New System.Drawing.Size(66, 23)
        Me.rbtVenta.TabIndex = 23
        Me.rbtVenta.TabStop = True
        Me.rbtVenta.Text = "Venta"
        Me.rbtVenta.UseVisualStyleBackColor = False
        '
        'lblelejir
        '
        Me.lblelejir.AutoSize = True
        Me.lblelejir.BackColor = System.Drawing.Color.Transparent
        Me.lblelejir.Location = New System.Drawing.Point(16, 99)
        Me.lblelejir.Name = "lblelejir"
        Me.lblelejir.Size = New System.Drawing.Size(118, 19)
        Me.lblelejir.TabIndex = 19
        Me.lblelejir.Text = "Elejir el Cliente:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(20, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 19)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Fecha Inicio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(170, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 19)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Fecha Final"
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFinal.Location = New System.Drawing.Point(174, 47)
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Size = New System.Drawing.Size(113, 26)
        Me.dtFechaFinal.TabIndex = 16
        '
        'dtFechaInicial
        '
        Me.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaInicial.Location = New System.Drawing.Point(24, 47)
        Me.dtFechaInicial.Name = "dtFechaInicial"
        Me.dtFechaInicial.Size = New System.Drawing.Size(110, 26)
        Me.dtFechaInicial.TabIndex = 15
        '
        'ImgBuscarB
        '
        Me.ImgBuscarB.BackColor = System.Drawing.Color.Transparent
        Me.ImgBuscarB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgBuscarB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Buscar
        Me.ImgBuscarB.Location = New System.Drawing.Point(368, 47)
        Me.ImgBuscarB.Name = "ImgBuscarB"
        Me.ImgBuscarB.Size = New System.Drawing.Size(106, 30)
        Me.ImgBuscarB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgBuscarB.TabIndex = 53
        Me.ImgBuscarB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgBuscarB, "Buscar (F2)")
        Me.ImgBuscarB.Visible = False
        '
        'ImgBuscarA
        '
        Me.ImgBuscarA.BackColor = System.Drawing.Color.Transparent
        Me.ImgBuscarA.Cursor = System.Windows.Forms.Cursors.Default
        Me.ImgBuscarA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Buscar
        Me.ImgBuscarA.Location = New System.Drawing.Point(370, 48)
        Me.ImgBuscarA.Name = "ImgBuscarA"
        Me.ImgBuscarA.Size = New System.Drawing.Size(101, 28)
        Me.ImgBuscarA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgBuscarA.TabIndex = 52
        Me.ImgBuscarA.TabStop = False
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
        Me.ClientSize = New System.Drawing.Size(889, 486)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmHistorialCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial del Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ImgVentasB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgVentasA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSalirB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSalirA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgBuscarB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgBuscarA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents rdbCotizacion As System.Windows.Forms.RadioButton
    Friend WithEvents rbtVentaPedido As System.Windows.Forms.RadioButton
    Friend WithEvents rbtVenta As System.Windows.Forms.RadioButton
    Friend WithEvents lblelejir As System.Windows.Forms.Label
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents ImgSalirB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgSalirA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgVentasB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgVentasA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgBuscarB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgBuscarA As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
