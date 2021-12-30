<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoVentas
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
        Me.DataGridTikect = New System.Windows.Forms.DataGridView()
        Me.ImgCancelarB = New System.Windows.Forms.PictureBox()
        Me.ImgCancelarA = New System.Windows.Forms.PictureBox()
        Me.ImgReImpB = New System.Windows.Forms.PictureBox()
        Me.ImgReImpA = New System.Windows.Forms.PictureBox()
        Me.ImgVentasB = New System.Windows.Forms.PictureBox()
        Me.ImgVentasA = New System.Windows.Forms.PictureBox()
        Me.ImgSalirB = New System.Windows.Forms.PictureBox()
        Me.ImgSalirA = New System.Windows.Forms.PictureBox()
        Me.LblTotalText = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.LblNumTicket = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridConsulta = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridTikect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgCancelarB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgCancelarA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgReImpB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgReImpA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgVentasB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgVentasA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSalirB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSalirA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.GroupBox1.Controls.Add(Me.DataGridTikect)
        Me.GroupBox1.Controls.Add(Me.ImgCancelarB)
        Me.GroupBox1.Controls.Add(Me.ImgCancelarA)
        Me.GroupBox1.Controls.Add(Me.ImgReImpB)
        Me.GroupBox1.Controls.Add(Me.ImgReImpA)
        Me.GroupBox1.Controls.Add(Me.ImgVentasB)
        Me.GroupBox1.Controls.Add(Me.ImgVentasA)
        Me.GroupBox1.Controls.Add(Me.ImgSalirB)
        Me.GroupBox1.Controls.Add(Me.ImgSalirA)
        Me.GroupBox1.Controls.Add(Me.LblTotalText)
        Me.GroupBox1.Controls.Add(Me.LblTotal)
        Me.GroupBox1.Controls.Add(Me.LblNumTicket)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtFechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtFechaInicial)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.DataGridConsulta)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(995, 500)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'DataGridTikect
        '
        Me.DataGridTikect.AllowUserToAddRows = False
        Me.DataGridTikect.AllowUserToDeleteRows = False
        Me.DataGridTikect.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridTikect.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridTikect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridTikect.Location = New System.Drawing.Point(15, 279)
        Me.DataGridTikect.Name = "DataGridTikect"
        Me.DataGridTikect.ReadOnly = True
        Me.DataGridTikect.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DataGridTikect.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridTikect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridTikect.ShowCellErrors = False
        Me.DataGridTikect.ShowCellToolTips = False
        Me.DataGridTikect.ShowEditingIcon = False
        Me.DataGridTikect.ShowRowErrors = False
        Me.DataGridTikect.Size = New System.Drawing.Size(962, 160)
        Me.DataGridTikect.TabIndex = 11
        '
        'ImgCancelarB
        '
        Me.ImgCancelarB.BackColor = System.Drawing.Color.Transparent
        Me.ImgCancelarB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgCancelarB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.btnCancelar
        Me.ImgCancelarB.Location = New System.Drawing.Point(273, 240)
        Me.ImgCancelarB.Name = "ImgCancelarB"
        Me.ImgCancelarB.Size = New System.Drawing.Size(91, 41)
        Me.ImgCancelarB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgCancelarB.TabIndex = 64
        Me.ImgCancelarB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgCancelarB, "Cancelar Venta")
        Me.ImgCancelarB.Visible = False
        '
        'ImgCancelarA
        '
        Me.ImgCancelarA.BackColor = System.Drawing.Color.Transparent
        Me.ImgCancelarA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.btnCancelar
        Me.ImgCancelarA.Location = New System.Drawing.Point(273, 241)
        Me.ImgCancelarA.Name = "ImgCancelarA"
        Me.ImgCancelarA.Size = New System.Drawing.Size(88, 38)
        Me.ImgCancelarA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgCancelarA.TabIndex = 63
        Me.ImgCancelarA.TabStop = False
        '
        'ImgReImpB
        '
        Me.ImgReImpB.BackColor = System.Drawing.Color.Transparent
        Me.ImgReImpB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgReImpB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Reimprimir
        Me.ImgReImpB.Location = New System.Drawing.Point(29, 445)
        Me.ImgReImpB.Name = "ImgReImpB"
        Me.ImgReImpB.Size = New System.Drawing.Size(46, 47)
        Me.ImgReImpB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgReImpB.TabIndex = 62
        Me.ImgReImpB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgReImpB, "Reimprimir Ticket")
        Me.ImgReImpB.Visible = False
        '
        'ImgReImpA
        '
        Me.ImgReImpA.BackColor = System.Drawing.Color.Transparent
        Me.ImgReImpA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Reimprimir
        Me.ImgReImpA.Location = New System.Drawing.Point(32, 448)
        Me.ImgReImpA.Name = "ImgReImpA"
        Me.ImgReImpA.Size = New System.Drawing.Size(40, 43)
        Me.ImgReImpA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgReImpA.TabIndex = 61
        Me.ImgReImpA.TabStop = False
        '
        'ImgVentasB
        '
        Me.ImgVentasB.BackColor = System.Drawing.Color.Transparent
        Me.ImgVentasB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgVentasB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.salesrun
        Me.ImgVentasB.Location = New System.Drawing.Point(283, 18)
        Me.ImgVentasB.Name = "ImgVentasB"
        Me.ImgVentasB.Size = New System.Drawing.Size(44, 45)
        Me.ImgVentasB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgVentasB.TabIndex = 57
        Me.ImgVentasB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgVentasB, "Ver Ventas")
        Me.ImgVentasB.Visible = False
        '
        'ImgVentasA
        '
        Me.ImgVentasA.BackColor = System.Drawing.Color.Transparent
        Me.ImgVentasA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.salesrun
        Me.ImgVentasA.Location = New System.Drawing.Point(284, 22)
        Me.ImgVentasA.Name = "ImgVentasA"
        Me.ImgVentasA.Size = New System.Drawing.Size(40, 38)
        Me.ImgVentasA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgVentasA.TabIndex = 56
        Me.ImgVentasA.TabStop = False
        '
        'ImgSalirB
        '
        Me.ImgSalirB.BackColor = System.Drawing.Color.Transparent
        Me.ImgSalirB.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ImgSalirB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgSalirB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.btn_salir
        Me.ImgSalirB.Location = New System.Drawing.Point(883, 20)
        Me.ImgSalirB.Name = "ImgSalirB"
        Me.ImgSalirB.Size = New System.Drawing.Size(94, 35)
        Me.ImgSalirB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSalirB.TabIndex = 46
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
        Me.ImgSalirA.Location = New System.Drawing.Point(886, 21)
        Me.ImgSalirA.Name = "ImgSalirA"
        Me.ImgSalirA.Size = New System.Drawing.Size(88, 31)
        Me.ImgSalirA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSalirA.TabIndex = 45
        Me.ImgSalirA.TabStop = False
        '
        'LblTotalText
        '
        Me.LblTotalText.AutoSize = True
        Me.LblTotalText.BackColor = System.Drawing.Color.Transparent
        Me.LblTotalText.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalText.Location = New System.Drawing.Point(774, 456)
        Me.LblTotalText.Name = "LblTotalText"
        Me.LblTotalText.Size = New System.Drawing.Size(57, 22)
        Me.LblTotalText.TabIndex = 39
        Me.LblTotalText.Text = "Total:"
        '
        'LblTotal
        '
        Me.LblTotal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblTotal.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(832, 456)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(145, 24)
        Me.LblTotal.TabIndex = 36
        Me.LblTotal.Text = "0.00"
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblNumTicket
        '
        Me.LblNumTicket.AutoSize = True
        Me.LblNumTicket.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblNumTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNumTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumTicket.ForeColor = System.Drawing.Color.Black
        Me.LblNumTicket.Location = New System.Drawing.Point(154, 249)
        Me.LblNumTicket.Name = "LblNumTicket"
        Me.LblNumTicket.Size = New System.Drawing.Size(2, 22)
        Me.LblNumTicket.TabIndex = 35
        Me.LblNumTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblNumTicket.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(12, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 19)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Fecha Inicial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(140, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 19)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Fecha Final"
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFinal.Location = New System.Drawing.Point(143, 36)
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Size = New System.Drawing.Size(116, 26)
        Me.dtFechaFinal.TabIndex = 29
        '
        'dtFechaInicial
        '
        Me.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaInicial.Location = New System.Drawing.Point(15, 36)
        Me.dtFechaInicial.Name = "dtFechaInicial"
        Me.dtFechaInicial.Size = New System.Drawing.Size(113, 26)
        Me.dtFechaInicial.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(14, 249)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Desglose de Ticket"
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
        Me.DataGridConsulta.Size = New System.Drawing.Size(962, 171)
        Me.DataGridConsulta.TabIndex = 10
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'FrmListadoVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(1019, 512)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmListadoVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta, Reimpresion y Cancelacion de Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridTikect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgCancelarB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgCancelarA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgReImpB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgReImpA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgVentasB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgVentasA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSalirB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSalirA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridTikect As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridConsulta As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents LblNumTicket As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblTotalText As System.Windows.Forms.Label
    Friend WithEvents ImgSalirB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgSalirA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgVentasB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgVentasA As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ImgReImpB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgReImpA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgCancelarB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgCancelarA As System.Windows.Forms.PictureBox

End Class
