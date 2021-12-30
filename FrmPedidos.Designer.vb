<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPedidos
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
        Me.lblVerVerntas = New System.Windows.Forms.Label()
        Me.lblReimprimirPedido = New System.Windows.Forms.Label()
        Me.ImgTicketB = New System.Windows.Forms.PictureBox()
        Me.ImgTicketA = New System.Windows.Forms.PictureBox()
        Me.ImgVentasB = New System.Windows.Forms.PictureBox()
        Me.ImgVentasA = New System.Windows.Forms.PictureBox()
        Me.ImgReImpB = New System.Windows.Forms.PictureBox()
        Me.ImgReImpA = New System.Windows.Forms.PictureBox()
        Me.LblPedido = New System.Windows.Forms.Label()
        Me.dpfinal = New System.Windows.Forms.DateTimePicker()
        Me.dpinicio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblticket = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ImgSalirB = New System.Windows.Forms.PictureBox()
        Me.ImgSalirA = New System.Windows.Forms.PictureBox()
        Me.ImgCancelarB = New System.Windows.Forms.PictureBox()
        Me.ImgCancelarA = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ImgTicketB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgTicketA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgVentasB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgVentasA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgReImpB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgReImpA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSalirB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSalirA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgCancelarB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgCancelarA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.GroupBox1.Controls.Add(Me.lblVerVerntas)
        Me.GroupBox1.Controls.Add(Me.lblReimprimirPedido)
        Me.GroupBox1.Controls.Add(Me.ImgTicketB)
        Me.GroupBox1.Controls.Add(Me.ImgTicketA)
        Me.GroupBox1.Controls.Add(Me.ImgVentasB)
        Me.GroupBox1.Controls.Add(Me.ImgVentasA)
        Me.GroupBox1.Controls.Add(Me.ImgReImpB)
        Me.GroupBox1.Controls.Add(Me.ImgReImpA)
        Me.GroupBox1.Controls.Add(Me.LblPedido)
        Me.GroupBox1.Controls.Add(Me.dpfinal)
        Me.GroupBox1.Controls.Add(Me.dpinicio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblticket)
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.ImgSalirB)
        Me.GroupBox1.Controls.Add(Me.ImgSalirA)
        Me.GroupBox1.Controls.Add(Me.ImgCancelarB)
        Me.GroupBox1.Controls.Add(Me.ImgCancelarA)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(942, 559)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblVerVerntas
        '
        Me.lblVerVerntas.AutoSize = True
        Me.lblVerVerntas.BackColor = System.Drawing.Color.Transparent
        Me.lblVerVerntas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblVerVerntas.Location = New System.Drawing.Point(504, 41)
        Me.lblVerVerntas.Name = "lblVerVerntas"
        Me.lblVerVerntas.Size = New System.Drawing.Size(83, 19)
        Me.lblVerVerntas.TabIndex = 53
        Me.lblVerVerntas.Text = "Ver Ventas"
        '
        'lblReimprimirPedido
        '
        Me.lblReimprimirPedido.AutoSize = True
        Me.lblReimprimirPedido.BackColor = System.Drawing.Color.Transparent
        Me.lblReimprimirPedido.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblReimprimirPedido.Location = New System.Drawing.Point(90, 531)
        Me.lblReimprimirPedido.Name = "lblReimprimirPedido"
        Me.lblReimprimirPedido.Size = New System.Drawing.Size(134, 19)
        Me.lblReimprimirPedido.TabIndex = 52
        Me.lblReimprimirPedido.Text = "Reimprimir Pedido"
        '
        'ImgTicketB
        '
        Me.ImgTicketB.BackColor = System.Drawing.Color.Transparent
        Me.ImgTicketB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgTicketB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.ticketgood
        Me.ImgTicketB.Location = New System.Drawing.Point(616, 16)
        Me.ImgTicketB.Name = "ImgTicketB"
        Me.ImgTicketB.Size = New System.Drawing.Size(111, 50)
        Me.ImgTicketB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgTicketB.TabIndex = 51
        Me.ImgTicketB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgTicketB, "Generar Ticket")
        Me.ImgTicketB.Visible = False
        '
        'ImgTicketA
        '
        Me.ImgTicketA.BackColor = System.Drawing.Color.Transparent
        Me.ImgTicketA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.ticketgood
        Me.ImgTicketA.Location = New System.Drawing.Point(619, 17)
        Me.ImgTicketA.Name = "ImgTicketA"
        Me.ImgTicketA.Size = New System.Drawing.Size(102, 47)
        Me.ImgTicketA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgTicketA.TabIndex = 50
        Me.ImgTicketA.TabStop = False
        '
        'ImgVentasB
        '
        Me.ImgVentasB.BackColor = System.Drawing.Color.Transparent
        Me.ImgVentasB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgVentasB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.salesrun
        Me.ImgVentasB.Location = New System.Drawing.Point(457, 18)
        Me.ImgVentasB.Name = "ImgVentasB"
        Me.ImgVentasB.Size = New System.Drawing.Size(44, 45)
        Me.ImgVentasB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgVentasB.TabIndex = 49
        Me.ImgVentasB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgVentasB, "Ver Ventas")
        Me.ImgVentasB.Visible = False
        '
        'ImgVentasA
        '
        Me.ImgVentasA.BackColor = System.Drawing.Color.Transparent
        Me.ImgVentasA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.salesrun
        Me.ImgVentasA.Location = New System.Drawing.Point(460, 22)
        Me.ImgVentasA.Name = "ImgVentasA"
        Me.ImgVentasA.Size = New System.Drawing.Size(40, 38)
        Me.ImgVentasA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgVentasA.TabIndex = 48
        Me.ImgVentasA.TabStop = False
        '
        'ImgReImpB
        '
        Me.ImgReImpB.BackColor = System.Drawing.Color.Transparent
        Me.ImgReImpB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgReImpB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Reimprimir
        Me.ImgReImpB.Location = New System.Drawing.Point(38, 503)
        Me.ImgReImpB.Name = "ImgReImpB"
        Me.ImgReImpB.Size = New System.Drawing.Size(46, 47)
        Me.ImgReImpB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgReImpB.TabIndex = 45
        Me.ImgReImpB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgReImpB, "Reimprimir Pedido")
        Me.ImgReImpB.Visible = False
        '
        'ImgReImpA
        '
        Me.ImgReImpA.BackColor = System.Drawing.Color.Transparent
        Me.ImgReImpA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Reimprimir
        Me.ImgReImpA.Location = New System.Drawing.Point(41, 506)
        Me.ImgReImpA.Name = "ImgReImpA"
        Me.ImgReImpA.Size = New System.Drawing.Size(40, 43)
        Me.ImgReImpA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgReImpA.TabIndex = 44
        Me.ImgReImpA.TabStop = False
        '
        'LblPedido
        '
        Me.LblPedido.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPedido.Location = New System.Drawing.Point(144, 278)
        Me.LblPedido.Name = "LblPedido"
        Me.LblPedido.Size = New System.Drawing.Size(115, 23)
        Me.LblPedido.TabIndex = 10
        Me.LblPedido.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'dpfinal
        '
        Me.dpfinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpfinal.Location = New System.Drawing.Point(148, 37)
        Me.dpfinal.Name = "dpfinal"
        Me.dpfinal.Size = New System.Drawing.Size(111, 26)
        Me.dpfinal.TabIndex = 6
        '
        'dpinicio
        '
        Me.dpinicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpinicio.Location = New System.Drawing.Point(6, 37)
        Me.dpinicio.Name = "dpinicio"
        Me.dpinicio.Size = New System.Drawing.Size(113, 26)
        Me.dpinicio.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(148, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha Final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha Inicio"
        '
        'lblticket
        '
        Me.lblticket.AutoSize = True
        Me.lblticket.BackColor = System.Drawing.Color.Transparent
        Me.lblticket.Location = New System.Drawing.Point(7, 283)
        Me.lblticket.Name = "lblticket"
        Me.lblticket.Size = New System.Drawing.Size(136, 19)
        Me.lblticket.TabIndex = 2
        Me.lblticket.Text = "Detalle del Pedido:"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(9, 311)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(927, 186)
        Me.DataGridView2.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeColumns = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 70)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(930, 197)
        Me.DataGridView1.TabIndex = 0
        '
        'ImgSalirB
        '
        Me.ImgSalirB.BackColor = System.Drawing.Color.Transparent
        Me.ImgSalirB.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ImgSalirB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgSalirB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.btn_salir
        Me.ImgSalirB.Location = New System.Drawing.Point(830, 22)
        Me.ImgSalirB.Name = "ImgSalirB"
        Me.ImgSalirB.Size = New System.Drawing.Size(94, 35)
        Me.ImgSalirB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSalirB.TabIndex = 42
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
        Me.ImgSalirA.Location = New System.Drawing.Point(833, 23)
        Me.ImgSalirA.Name = "ImgSalirA"
        Me.ImgSalirA.Size = New System.Drawing.Size(88, 31)
        Me.ImgSalirA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSalirA.TabIndex = 41
        Me.ImgSalirA.TabStop = False
        '
        'ImgCancelarB
        '
        Me.ImgCancelarB.BackColor = System.Drawing.Color.Transparent
        Me.ImgCancelarB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgCancelarB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.btnCancelar
        Me.ImgCancelarB.Location = New System.Drawing.Point(267, 272)
        Me.ImgCancelarB.Name = "ImgCancelarB"
        Me.ImgCancelarB.Size = New System.Drawing.Size(91, 41)
        Me.ImgCancelarB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgCancelarB.TabIndex = 47
        Me.ImgCancelarB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgCancelarB, "Cancelar Pedido")
        Me.ImgCancelarB.Visible = False
        '
        'ImgCancelarA
        '
        Me.ImgCancelarA.BackColor = System.Drawing.Color.Transparent
        Me.ImgCancelarA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.btnCancelar
        Me.ImgCancelarA.Location = New System.Drawing.Point(268, 273)
        Me.ImgCancelarA.Name = "ImgCancelarA"
        Me.ImgCancelarA.Size = New System.Drawing.Size(88, 38)
        Me.ImgCancelarA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgCancelarA.TabIndex = 46
        Me.ImgCancelarA.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'FrmPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(975, 565)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convertir Pedidos a Tickets"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ImgTicketB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgTicketA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgVentasB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgVentasA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgReImpB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgReImpA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSalirB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSalirA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgCancelarB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgCancelarA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents dpfinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dpinicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblticket As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents LblPedido As System.Windows.Forms.Label
    Friend WithEvents ImgSalirB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgSalirA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgReImpA As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ImgReImpB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgCancelarA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgCancelarB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgVentasB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgVentasA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgTicketA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgTicketB As System.Windows.Forms.PictureBox
    Friend WithEvents lblVerVerntas As System.Windows.Forms.Label
    Friend WithEvents lblReimprimirPedido As System.Windows.Forms.Label
End Class
