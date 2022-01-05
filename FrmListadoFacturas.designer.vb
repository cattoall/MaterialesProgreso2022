<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoFacturas
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.DataGridTikect = New System.Windows.Forms.DataGridView()
        Me.DataGridConsulta = New System.Windows.Forms.DataGridView()
        Me.ImgVerFactB = New System.Windows.Forms.PictureBox()
        Me.ImgVerFactA = New System.Windows.Forms.PictureBox()
        Me.ImgCancelarB = New System.Windows.Forms.PictureBox()
        Me.ImgCancelarA = New System.Windows.Forms.PictureBox()
        Me.ImgCFDIB = New System.Windows.Forms.PictureBox()
        Me.ImgCFDIA = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ImgSalirB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSalirA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridTikect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgVerFactB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgVerFactA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgCancelarB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgCancelarA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgCFDIB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgCFDIA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
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
        Me.GroupBox1.Controls.Add(Me.DataGridTikect)
        Me.GroupBox1.Controls.Add(Me.DataGridConsulta)
        Me.GroupBox1.Controls.Add(Me.ImgVerFactB)
        Me.GroupBox1.Controls.Add(Me.ImgVerFactA)
        Me.GroupBox1.Controls.Add(Me.ImgCancelarB)
        Me.GroupBox1.Controls.Add(Me.ImgCancelarA)
        Me.GroupBox1.Controls.Add(Me.ImgCFDIB)
        Me.GroupBox1.Controls.Add(Me.ImgCFDIA)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(995, 500)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(64, 474)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 19)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Reimprimir Factura CFDI"
        '
        'ImgSalirB
        '
        Me.ImgSalirB.BackColor = System.Drawing.Color.Transparent
        Me.ImgSalirB.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ImgSalirB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgSalirB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.btn_salir
        Me.ImgSalirB.Location = New System.Drawing.Point(765, 24)
        Me.ImgSalirB.Name = "ImgSalirB"
        Me.ImgSalirB.Size = New System.Drawing.Size(94, 35)
        Me.ImgSalirB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSalirB.TabIndex = 48
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
        Me.ImgSalirA.Location = New System.Drawing.Point(886, 25)
        Me.ImgSalirA.Name = "ImgSalirA"
        Me.ImgSalirA.Size = New System.Drawing.Size(88, 31)
        Me.ImgSalirA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSalirA.TabIndex = 47
        Me.ImgSalirA.TabStop = False
        '
        'LblTotalText
        '
        Me.LblTotalText.AutoSize = True
        Me.LblTotalText.BackColor = System.Drawing.Color.Transparent
        Me.LblTotalText.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalText.Location = New System.Drawing.Point(773, 467)
        Me.LblTotalText.Name = "LblTotalText"
        Me.LblTotalText.Size = New System.Drawing.Size(57, 22)
        Me.LblTotalText.TabIndex = 39
        Me.LblTotalText.Text = "Total:"
        '
        'LblTotal
        '
        Me.LblTotal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblTotal.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(832, 466)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(145, 24)
        Me.LblTotal.TabIndex = 36
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblNumTicket
        '
        Me.LblNumTicket.AutoSize = True
        Me.LblNumTicket.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblNumTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNumTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumTicket.Location = New System.Drawing.Point(154, 251)
        Me.LblNumTicket.Name = "LblNumTicket"
        Me.LblNumTicket.Size = New System.Drawing.Size(2, 22)
        Me.LblNumTicket.TabIndex = 35
        Me.LblNumTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(12, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 19)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Fecha Inicial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(140, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 19)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Fecha Final"
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFinal.Location = New System.Drawing.Point(143, 37)
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Size = New System.Drawing.Size(116, 26)
        Me.dtFechaFinal.TabIndex = 29
        '
        'dtFechaInicial
        '
        Me.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaInicial.Location = New System.Drawing.Point(15, 37)
        Me.dtFechaInicial.Name = "dtFechaInicial"
        Me.dtFechaInicial.Size = New System.Drawing.Size(113, 26)
        Me.dtFechaInicial.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(14, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Desglose de Ticket"
        '
        'DataGridTikect
        '
        Me.DataGridTikect.AllowUserToAddRows = False
        Me.DataGridTikect.AllowUserToDeleteRows = False
        Me.DataGridTikect.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.DataGridTikect.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridTikect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridTikect.Location = New System.Drawing.Point(15, 280)
        Me.DataGridTikect.Name = "DataGridTikect"
        Me.DataGridTikect.ReadOnly = True
        Me.DataGridTikect.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.DataGridTikect.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridTikect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridTikect.ShowCellErrors = False
        Me.DataGridTikect.ShowCellToolTips = False
        Me.DataGridTikect.ShowEditingIcon = False
        Me.DataGridTikect.ShowRowErrors = False
        Me.DataGridTikect.Size = New System.Drawing.Size(962, 166)
        Me.DataGridTikect.TabIndex = 11
        '
        'DataGridConsulta
        '
        Me.DataGridConsulta.AllowUserToAddRows = False
        Me.DataGridConsulta.AllowUserToDeleteRows = False
        Me.DataGridConsulta.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        Me.DataGridConsulta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridConsulta.Location = New System.Drawing.Point(15, 65)
        Me.DataGridConsulta.MultiSelect = False
        Me.DataGridConsulta.Name = "DataGridConsulta"
        Me.DataGridConsulta.ReadOnly = True
        Me.DataGridConsulta.RowHeadersVisible = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        Me.DataGridConsulta.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridConsulta.ShowCellErrors = False
        Me.DataGridConsulta.ShowCellToolTips = False
        Me.DataGridConsulta.ShowEditingIcon = False
        Me.DataGridConsulta.ShowRowErrors = False
        Me.DataGridConsulta.Size = New System.Drawing.Size(962, 177)
        Me.DataGridConsulta.TabIndex = 10
        '
        'ImgVerFactB
        '
        Me.ImgVerFactB.BackColor = System.Drawing.Color.Transparent
        Me.ImgVerFactB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgVerFactB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.VerFacturasXxL
        Me.ImgVerFactB.Location = New System.Drawing.Point(285, 18)
        Me.ImgVerFactB.Name = "ImgVerFactB"
        Me.ImgVerFactB.Size = New System.Drawing.Size(54, 48)
        Me.ImgVerFactB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgVerFactB.TabIndex = 43
        Me.ImgVerFactB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgVerFactB, "Ver Facturas")
        Me.ImgVerFactB.Visible = False
        '
        'ImgVerFactA
        '
        Me.ImgVerFactA.BackColor = System.Drawing.Color.Transparent
        Me.ImgVerFactA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.VerFacturasXxL
        Me.ImgVerFactA.Location = New System.Drawing.Point(285, 22)
        Me.ImgVerFactA.Name = "ImgVerFactA"
        Me.ImgVerFactA.Size = New System.Drawing.Size(45, 39)
        Me.ImgVerFactA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgVerFactA.TabIndex = 42
        Me.ImgVerFactA.TabStop = False
        '
        'ImgCancelarB
        '
        Me.ImgCancelarB.BackColor = System.Drawing.Color.Transparent
        Me.ImgCancelarB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgCancelarB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.btnCancelar
        Me.ImgCancelarB.Location = New System.Drawing.Point(264, 241)
        Me.ImgCancelarB.Name = "ImgCancelarB"
        Me.ImgCancelarB.Size = New System.Drawing.Size(91, 41)
        Me.ImgCancelarB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgCancelarB.TabIndex = 66
        Me.ImgCancelarB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgCancelarB, "Cancelar Factura")
        Me.ImgCancelarB.Visible = False
        '
        'ImgCancelarA
        '
        Me.ImgCancelarA.BackColor = System.Drawing.Color.Transparent
        Me.ImgCancelarA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.btnCancelar
        Me.ImgCancelarA.Location = New System.Drawing.Point(267, 244)
        Me.ImgCancelarA.Name = "ImgCancelarA"
        Me.ImgCancelarA.Size = New System.Drawing.Size(88, 38)
        Me.ImgCancelarA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgCancelarA.TabIndex = 65
        Me.ImgCancelarA.TabStop = False
        '
        'ImgCFDIB
        '
        Me.ImgCFDIB.BackColor = System.Drawing.Color.Transparent
        Me.ImgCFDIB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgCFDIB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources._4318_aqua_icons_system_printer_s_
        Me.ImgCFDIB.Location = New System.Drawing.Point(18, 446)
        Me.ImgCFDIB.Name = "ImgCFDIB"
        Me.ImgCFDIB.Size = New System.Drawing.Size(46, 47)
        Me.ImgCFDIB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgCFDIB.TabIndex = 73
        Me.ImgCFDIB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgCFDIB, "Reimprimir Factura CFDI")
        Me.ImgCFDIB.Visible = False
        '
        'ImgCFDIA
        '
        Me.ImgCFDIA.BackColor = System.Drawing.Color.Transparent
        Me.ImgCFDIA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources._4318_aqua_icons_system_printer_s_
        Me.ImgCFDIA.Location = New System.Drawing.Point(18, 450)
        Me.ImgCFDIA.Name = "ImgCFDIA"
        Me.ImgCFDIA.Size = New System.Drawing.Size(40, 43)
        Me.ImgCFDIA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgCFDIA.TabIndex = 72
        Me.ImgCFDIA.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'FrmListadoFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 620)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmListadoFacturas"
        Me.Text = "Consulta, Reimpresion y Cancelacion de Facturas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ImgSalirB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSalirA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridTikect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgVerFactB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgVerFactA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgCancelarB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgCancelarA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgCFDIB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgCFDIA, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ImgVerFactA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgVerFactB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgSalirB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgSalirA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgCancelarB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgCancelarA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgCFDIA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgCFDIB As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
