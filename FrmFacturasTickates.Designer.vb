<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacturasTickates
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
        Me.GroupBox1.SuspendLayout
        CType(Me.ImgVerFactB,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ImgVerFactA,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ImgSalirB,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ImgSalirA,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DataGridTikect,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DataGridConsulta,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 62)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1312, 593)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = false
        '
        'ImgVerFactB
        '
        Me.ImgVerFactB.BackColor = System.Drawing.Color.Transparent
        Me.ImgVerFactB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgVerFactB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.VerFacturasXxL
        Me.ImgVerFactB.Location = New System.Drawing.Point(376, 17)
        Me.ImgVerFactB.Margin = New System.Windows.Forms.Padding(4)
        Me.ImgVerFactB.Name = "ImgVerFactB"
        Me.ImgVerFactB.Size = New System.Drawing.Size(72, 59)
        Me.ImgVerFactB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgVerFactB.TabIndex = 61
        Me.ImgVerFactB.TabStop = false
        Me.ToolTip1.SetToolTip(Me.ImgVerFactB, "Ver Facturas")
        Me.ImgVerFactB.Visible = false
        '
        'ImgVerFactA
        '
        Me.ImgVerFactA.BackColor = System.Drawing.Color.Transparent
        Me.ImgVerFactA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.VerFacturasXxL
        Me.ImgVerFactA.Location = New System.Drawing.Point(381, 23)
        Me.ImgVerFactA.Margin = New System.Windows.Forms.Padding(4)
        Me.ImgVerFactA.Name = "ImgVerFactA"
        Me.ImgVerFactA.Size = New System.Drawing.Size(60, 48)
        Me.ImgVerFactA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgVerFactA.TabIndex = 60
        Me.ImgVerFactA.TabStop = false
        '
        'ImgSalirB
        '
        Me.ImgSalirB.BackColor = System.Drawing.Color.Transparent
        Me.ImgSalirB.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ImgSalirB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgSalirB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.btn_salir
        Me.ImgSalirB.Location = New System.Drawing.Point(1165, 30)
        Me.ImgSalirB.Margin = New System.Windows.Forms.Padding(4)
        Me.ImgSalirB.Name = "ImgSalirB"
        Me.ImgSalirB.Size = New System.Drawing.Size(125, 43)
        Me.ImgSalirB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSalirB.TabIndex = 48
        Me.ImgSalirB.TabStop = false
        Me.ToolTip1.SetToolTip(Me.ImgSalirB, "Salir (Esc)")
        Me.ImgSalirB.Visible = false
        '
        'ImgSalirA
        '
        Me.ImgSalirA.BackColor = System.Drawing.Color.Transparent
        Me.ImgSalirA.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ImgSalirA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgSalirA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.btn_salir
        Me.ImgSalirA.Location = New System.Drawing.Point(1169, 31)
        Me.ImgSalirA.Margin = New System.Windows.Forms.Padding(4)
        Me.ImgSalirA.Name = "ImgSalirA"
        Me.ImgSalirA.Size = New System.Drawing.Size(117, 38)
        Me.ImgSalirA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSalirA.TabIndex = 47
        Me.ImgSalirA.TabStop = false
        '
        'LblNumTicket
        '
        Me.LblNumTicket.AutoSize = true
        Me.LblNumTicket.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.LblNumTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LblNumTicket.Location = New System.Drawing.Point(233, 308)
        Me.LblNumTicket.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNumTicket.Name = "LblNumTicket"
        Me.LblNumTicket.Size = New System.Drawing.Size(0, 25)
        Me.LblNumTicket.TabIndex = 35
        Me.LblNumTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(16, 22)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 23)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Fecha Inicial"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(187, 22)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 23)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Fecha Final"
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFinal.Location = New System.Drawing.Point(191, 46)
        Me.dtFechaFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Size = New System.Drawing.Size(153, 30)
        Me.dtFechaFinal.TabIndex = 29
        '
        'dtFechaInicial
        '
        Me.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaInicial.Location = New System.Drawing.Point(20, 46)
        Me.dtFechaInicial.Margin = New System.Windows.Forms.Padding(4)
        Me.dtFechaInicial.Name = "dtFechaInicial"
        Me.dtFechaInicial.Size = New System.Drawing.Size(149, 30)
        Me.dtFechaInicial.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(19, 308)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 23)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Desglose de Ticket"
        '
        'DataGridTikect
        '
        Me.DataGridTikect.AllowUserToAddRows = false
        Me.DataGridTikect.AllowUserToDeleteRows = false
        Me.DataGridTikect.AllowUserToResizeRows = false
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridTikect.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridTikect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridTikect.Location = New System.Drawing.Point(20, 336)
        Me.DataGridTikect.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridTikect.Name = "DataGridTikect"
        Me.DataGridTikect.ReadOnly = true
        Me.DataGridTikect.RowHeadersVisible = false
        Me.DataGridTikect.RowHeadersWidth = 51
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DataGridTikect.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridTikect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridTikect.ShowCellErrors = false
        Me.DataGridTikect.ShowCellToolTips = false
        Me.DataGridTikect.ShowEditingIcon = false
        Me.DataGridTikect.ShowRowErrors = false
        Me.DataGridTikect.Size = New System.Drawing.Size(1271, 229)
        Me.DataGridTikect.TabIndex = 11
        '
        'DataGridConsulta
        '
        Me.DataGridConsulta.AllowUserToAddRows = false
        Me.DataGridConsulta.AllowUserToDeleteRows = false
        Me.DataGridConsulta.AllowUserToResizeRows = false
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.DataGridConsulta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridConsulta.Location = New System.Drawing.Point(20, 80)
        Me.DataGridConsulta.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridConsulta.MultiSelect = false
        Me.DataGridConsulta.Name = "DataGridConsulta"
        Me.DataGridConsulta.ReadOnly = true
        Me.DataGridConsulta.RowHeadersVisible = false
        Me.DataGridConsulta.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.DataGridConsulta.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridConsulta.ShowCellErrors = false
        Me.DataGridConsulta.ShowCellToolTips = false
        Me.DataGridConsulta.ShowEditingIcon = false
        Me.DataGridConsulta.ShowRowErrors = false
        Me.DataGridConsulta.Size = New System.Drawing.Size(1271, 218)
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(1328, 684)
        Me.ControlBox = false
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = true
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = false
        Me.Name = "FrmFacturasTickates"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Text = "Listado de Tickates por Facturas"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.ImgVerFactB,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ImgVerFactA,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ImgSalirB,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ImgSalirA,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataGridTikect,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataGridConsulta,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

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
