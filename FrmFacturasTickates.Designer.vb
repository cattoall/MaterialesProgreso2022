<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacturasTickates
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
        Me.ImgVerFactB = New System.Windows.Forms.PictureBox()
        Me.ImgVerFactA = New System.Windows.Forms.PictureBox()
        Me.ImgSalirB = New System.Windows.Forms.PictureBox()
        Me.ImgSalirA = New System.Windows.Forms.PictureBox()
        Me.LblNumTicket = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridTikect = New System.Windows.Forms.DataGridView()
        Me.DataGridConsulta = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ImgVerFactB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgVerFactA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSalirB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSalirA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridTikect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.GroupBox1.Controls.Add(Me.ImgVerFactB)
        Me.GroupBox1.Controls.Add(Me.ImgVerFactA)
        Me.GroupBox1.Controls.Add(Me.ImgSalirB)
        Me.GroupBox1.Controls.Add(Me.ImgSalirA)
        Me.GroupBox1.Controls.Add(Me.LblNumTicket)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtFechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtFechaInicial)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.DataGridTikect)
        Me.GroupBox1.Controls.Add(Me.DataGridConsulta)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(984, 466)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'ImgVerFactB
        '
        Me.ImgVerFactB.BackColor = System.Drawing.Color.Transparent
        Me.ImgVerFactB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgVerFactB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.VerFacturasXxL
        Me.ImgVerFactB.Location = New System.Drawing.Point(282, 14)
        Me.ImgVerFactB.Name = "ImgVerFactB"
        Me.ImgVerFactB.Size = New System.Drawing.Size(54, 48)
        Me.ImgVerFactB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgVerFactB.TabIndex = 61
        Me.ImgVerFactB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgVerFactB, "Ver Facturas")
        Me.ImgVerFactB.Visible = False
        '
        'ImgVerFactA
        '
        Me.ImgVerFactA.BackColor = System.Drawing.Color.Transparent
        Me.ImgVerFactA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.VerFacturasXxL
        Me.ImgVerFactA.Location = New System.Drawing.Point(286, 19)
        Me.ImgVerFactA.Name = "ImgVerFactA"
        Me.ImgVerFactA.Size = New System.Drawing.Size(45, 39)
        Me.ImgVerFactA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgVerFactA.TabIndex = 60
        Me.ImgVerFactA.TabStop = False
        '
        'ImgSalirB
        '
        Me.ImgSalirB.BackColor = System.Drawing.Color.Transparent
        Me.ImgSalirB.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ImgSalirB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgSalirB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.btn_salir
        Me.ImgSalirB.Location = New System.Drawing.Point(874, 24)
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
        Me.ImgSalirA.Location = New System.Drawing.Point(877, 25)
        Me.ImgSalirA.Name = "ImgSalirA"
        Me.ImgSalirA.Size = New System.Drawing.Size(88, 31)
        Me.ImgSalirA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSalirA.TabIndex = 47
        Me.ImgSalirA.TabStop = False
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
        Me.Label8.Location = New System.Drawing.Point(14, 250)
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
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridTikect.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridTikect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridTikect.Location = New System.Drawing.Point(15, 273)
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
        Me.DataGridTikect.Size = New System.Drawing.Size(953, 186)
        Me.DataGridTikect.TabIndex = 11
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
        Me.DataGridConsulta.Size = New System.Drawing.Size(953, 177)
        Me.DataGridConsulta.TabIndex = 10
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'FrmFacturasTickates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(996, 473)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmFacturasTickates"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Tickates por Facturas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ImgVerFactB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgVerFactA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSalirB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSalirA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridTikect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblNumTicket As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridTikect As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridConsulta As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ImgSalirB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgSalirA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgVerFactB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgVerFactA As System.Windows.Forms.PictureBox
End Class
