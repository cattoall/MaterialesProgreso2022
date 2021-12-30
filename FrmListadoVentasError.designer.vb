<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoVentasError
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblVerVentas = New System.Windows.Forms.Label()
        Me.lblCorregir = New System.Windows.Forms.Label()
        Me.RbtPedidos = New System.Windows.Forms.RadioButton()
        Me.RbtTicket = New System.Windows.Forms.RadioButton()
        Me.LblTotalText = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.LblNumTicket = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridConsulta1 = New System.Windows.Forms.DataGridView()
        Me.DataGridConsulta = New System.Windows.Forms.DataGridView()
        Me.ImgSalirB = New System.Windows.Forms.PictureBox()
        Me.ImgSalirA = New System.Windows.Forms.PictureBox()
        Me.ImgVentasB = New System.Windows.Forms.PictureBox()
        Me.ImgVentasA = New System.Windows.Forms.PictureBox()
        Me.ImgCorregirB = New System.Windows.Forms.PictureBox()
        Me.ImgCorregirA = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridConsulta1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSalirB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSalirA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgVentasB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgVentasA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgCorregirB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgCorregirA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.GroupBox1.Controls.Add(Me.lblVerVentas)
        Me.GroupBox1.Controls.Add(Me.lblCorregir)
        Me.GroupBox1.Controls.Add(Me.RbtPedidos)
        Me.GroupBox1.Controls.Add(Me.RbtTicket)
        Me.GroupBox1.Controls.Add(Me.LblTotalText)
        Me.GroupBox1.Controls.Add(Me.LblTotal)
        Me.GroupBox1.Controls.Add(Me.LblNumTicket)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.DataGridConsulta1)
        Me.GroupBox1.Controls.Add(Me.DataGridConsulta)
        Me.GroupBox1.Controls.Add(Me.ImgSalirB)
        Me.GroupBox1.Controls.Add(Me.ImgSalirA)
        Me.GroupBox1.Controls.Add(Me.ImgVentasB)
        Me.GroupBox1.Controls.Add(Me.ImgVentasA)
        Me.GroupBox1.Controls.Add(Me.ImgCorregirB)
        Me.GroupBox1.Controls.Add(Me.ImgCorregirA)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(995, 488)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'lblVerVentas
        '
        Me.lblVerVentas.AutoSize = True
        Me.lblVerVentas.BackColor = System.Drawing.Color.Transparent
        Me.lblVerVentas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblVerVentas.Location = New System.Drawing.Point(163, 40)
        Me.lblVerVentas.Name = "lblVerVentas"
        Me.lblVerVentas.Size = New System.Drawing.Size(83, 19)
        Me.lblVerVentas.TabIndex = 50
        Me.lblVerVentas.Text = "Ver Ventas"
        '
        'lblCorregir
        '
        Me.lblCorregir.AutoSize = True
        Me.lblCorregir.BackColor = System.Drawing.Color.Transparent
        Me.lblCorregir.ForeColor = System.Drawing.Color.White
        Me.lblCorregir.Location = New System.Drawing.Point(79, 464)
        Me.lblCorregir.Name = "lblCorregir"
        Me.lblCorregir.Size = New System.Drawing.Size(66, 19)
        Me.lblCorregir.TabIndex = 49
        Me.lblCorregir.Text = "Corregir"
        '
        'RbtPedidos
        '
        Me.RbtPedidos.AutoSize = True
        Me.RbtPedidos.BackColor = System.Drawing.Color.Transparent
        Me.RbtPedidos.Location = New System.Drawing.Point(17, 39)
        Me.RbtPedidos.Name = "RbtPedidos"
        Me.RbtPedidos.Size = New System.Drawing.Size(79, 23)
        Me.RbtPedidos.TabIndex = 41
        Me.RbtPedidos.Text = "Pedidos"
        Me.RbtPedidos.UseVisualStyleBackColor = False
        '
        'RbtTicket
        '
        Me.RbtTicket.AutoSize = True
        Me.RbtTicket.BackColor = System.Drawing.Color.Transparent
        Me.RbtTicket.Checked = True
        Me.RbtTicket.Location = New System.Drawing.Point(17, 13)
        Me.RbtTicket.Name = "RbtTicket"
        Me.RbtTicket.Size = New System.Drawing.Size(77, 23)
        Me.RbtTicket.TabIndex = 40
        Me.RbtTicket.TabStop = True
        Me.RbtTicket.Text = "Tickets"
        Me.RbtTicket.UseVisualStyleBackColor = False
        '
        'LblTotalText
        '
        Me.LblTotalText.AutoSize = True
        Me.LblTotalText.BackColor = System.Drawing.Color.Transparent
        Me.LblTotalText.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalText.Location = New System.Drawing.Point(796, 454)
        Me.LblTotalText.Name = "LblTotalText"
        Me.LblTotalText.Size = New System.Drawing.Size(48, 19)
        Me.LblTotalText.TabIndex = 39
        Me.LblTotalText.Text = "Total:"
        '
        'LblTotal
        '
        Me.LblTotal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(850, 451)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(127, 24)
        Me.LblTotal.TabIndex = 36
        Me.LblTotal.Text = "0.00"
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblNumTicket
        '
        Me.LblNumTicket.AutoSize = True
        Me.LblNumTicket.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.LblNumTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumTicket.Location = New System.Drawing.Point(175, 250)
        Me.LblNumTicket.Name = "LblNumTicket"
        Me.LblNumTicket.Size = New System.Drawing.Size(0, 20)
        Me.LblNumTicket.TabIndex = 35
        Me.LblNumTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(14, 250)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Desglose de Ticket"
        '
        'DataGridConsulta1
        '
        Me.DataGridConsulta1.AllowUserToAddRows = False
        Me.DataGridConsulta1.AllowUserToDeleteRows = False
        Me.DataGridConsulta1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridConsulta1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridConsulta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridConsulta1.Location = New System.Drawing.Point(15, 273)
        Me.DataGridConsulta1.Name = "DataGridConsulta1"
        Me.DataGridConsulta1.ReadOnly = True
        Me.DataGridConsulta1.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DataGridConsulta1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridConsulta1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridConsulta1.ShowCellErrors = False
        Me.DataGridConsulta1.ShowCellToolTips = False
        Me.DataGridConsulta1.ShowEditingIcon = False
        Me.DataGridConsulta1.ShowRowErrors = False
        Me.DataGridConsulta1.Size = New System.Drawing.Size(962, 166)
        Me.DataGridConsulta1.TabIndex = 11
        '
        'DataGridConsulta
        '
        Me.DataGridConsulta.AllowUserToAddRows = False
        Me.DataGridConsulta.AllowUserToDeleteRows = False
        Me.DataGridConsulta.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.DataGridConsulta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridConsulta.Location = New System.Drawing.Point(15, 65)
        Me.DataGridConsulta.MultiSelect = False
        Me.DataGridConsulta.Name = "DataGridConsulta"
        Me.DataGridConsulta.ReadOnly = True
        Me.DataGridConsulta.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.DataGridConsulta.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridConsulta.ShowCellErrors = False
        Me.DataGridConsulta.ShowCellToolTips = False
        Me.DataGridConsulta.ShowEditingIcon = False
        Me.DataGridConsulta.ShowRowErrors = False
        Me.DataGridConsulta.Size = New System.Drawing.Size(962, 177)
        Me.DataGridConsulta.TabIndex = 10
        '
        'ImgSalirB
        '
        Me.ImgSalirB.BackColor = System.Drawing.Color.Transparent
        Me.ImgSalirB.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ImgSalirB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgSalirB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.btn_salir
        Me.ImgSalirB.Location = New System.Drawing.Point(885, 20)
        Me.ImgSalirB.Name = "ImgSalirB"
        Me.ImgSalirB.Size = New System.Drawing.Size(91, 36)
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
        Me.ImgSalirA.Location = New System.Drawing.Point(887, 21)
        Me.ImgSalirA.Name = "ImgSalirA"
        Me.ImgSalirA.Size = New System.Drawing.Size(87, 32)
        Me.ImgSalirA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSalirA.TabIndex = 43
        Me.ImgSalirA.TabStop = False
        '
        'ImgVentasB
        '
        Me.ImgVentasB.BackColor = System.Drawing.Color.Transparent
        Me.ImgVentasB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgVentasB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.salesrun
        Me.ImgVentasB.Location = New System.Drawing.Point(119, 16)
        Me.ImgVentasB.Name = "ImgVentasB"
        Me.ImgVentasB.Size = New System.Drawing.Size(44, 45)
        Me.ImgVentasB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgVentasB.TabIndex = 46
        Me.ImgVentasB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgVentasB, "Ver Ventas")
        Me.ImgVentasB.Visible = False
        '
        'ImgVentasA
        '
        Me.ImgVentasA.BackColor = System.Drawing.Color.Transparent
        Me.ImgVentasA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.salesrun
        Me.ImgVentasA.Location = New System.Drawing.Point(122, 20)
        Me.ImgVentasA.Name = "ImgVentasA"
        Me.ImgVentasA.Size = New System.Drawing.Size(40, 38)
        Me.ImgVentasA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgVentasA.TabIndex = 45
        Me.ImgVentasA.TabStop = False
        '
        'ImgCorregirB
        '
        Me.ImgCorregirB.BackColor = System.Drawing.Color.Transparent
        Me.ImgCorregirB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgCorregirB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Corregir
        Me.ImgCorregirB.Location = New System.Drawing.Point(39, 440)
        Me.ImgCorregirB.Name = "ImgCorregirB"
        Me.ImgCorregirB.Size = New System.Drawing.Size(39, 47)
        Me.ImgCorregirB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgCorregirB.TabIndex = 48
        Me.ImgCorregirB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgCorregirB, "Corregir")
        Me.ImgCorregirB.Visible = False
        '
        'ImgCorregirA
        '
        Me.ImgCorregirA.BackColor = System.Drawing.Color.Transparent
        Me.ImgCorregirA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Corregir
        Me.ImgCorregirA.Location = New System.Drawing.Point(41, 445)
        Me.ImgCorregirA.Name = "ImgCorregirA"
        Me.ImgCorregirA.Size = New System.Drawing.Size(34, 40)
        Me.ImgCorregirA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgCorregirA.TabIndex = 47
        Me.ImgCorregirA.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'FrmListadoVentasError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(1019, 496)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmListadoVentasError"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Ventas de Credito con Errores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridConsulta1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSalirB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSalirA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgVentasB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgVentasA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgCorregirB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgCorregirA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridConsulta1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridConsulta As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents LblNumTicket As System.Windows.Forms.Label
    Friend WithEvents LblTotalText As System.Windows.Forms.Label
    Friend WithEvents RbtPedidos As System.Windows.Forms.RadioButton
    Friend WithEvents RbtTicket As System.Windows.Forms.RadioButton
    Friend WithEvents ImgSalirB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgSalirA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgVentasA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgVentasB As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ImgCorregirA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgCorregirB As System.Windows.Forms.PictureBox
    Friend WithEvents lblCorregir As System.Windows.Forms.Label
    Friend WithEvents lblVerVentas As System.Windows.Forms.Label

End Class
