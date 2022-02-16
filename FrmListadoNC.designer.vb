<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoNC
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.mBtnXML = New MetroFramework.Controls.MetroButton()
        Me.mBtnCancel = New MetroFramework.Controls.MetroButton()
        Me.dtFechaFinal = New MetroFramework.Controls.MetroDateTime()
        Me.dtFechaInicial = New MetroFramework.Controls.MetroDateTime()
        Me.DataGridTikect = New MetroFramework.Controls.MetroGrid()
        Me.DataGridConsulta = New MetroFramework.Controls.MetroGrid()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblTotalText = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.LblNumTicket = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridTikect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.mBtnXML)
        Me.GroupBox1.Controls.Add(Me.mBtnCancel)
        Me.GroupBox1.Controls.Add(Me.dtFechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtFechaInicial)
        Me.GroupBox1.Controls.Add(Me.DataGridTikect)
        Me.GroupBox1.Controls.Add(Me.DataGridConsulta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LblTotalText)
        Me.GroupBox1.Controls.Add(Me.LblTotal)
        Me.GroupBox1.Controls.Add(Me.LblNumTicket)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(995, 500)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.print_16px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(15, 462)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 86
        Me.Button1.Text = "Imprimir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.search_16px
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(263, 37)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 30)
        Me.Button2.TabIndex = 85
        Me.Button2.Text = "Buscar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.close_window_16px
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(877, 40)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 28)
        Me.Button3.TabIndex = 84
        Me.Button3.Text = "Salir"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'mBtnXML
        '
        Me.mBtnXML.Location = New System.Drawing.Point(365, 255)
        Me.mBtnXML.Name = "mBtnXML"
        Me.mBtnXML.Size = New System.Drawing.Size(75, 23)
        Me.mBtnXML.TabIndex = 82
        Me.mBtnXML.Text = "XML"
        Me.mBtnXML.UseSelectable = True
        '
        'mBtnCancel
        '
        Me.mBtnCancel.Location = New System.Drawing.Point(284, 255)
        Me.mBtnCancel.Name = "mBtnCancel"
        Me.mBtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.mBtnCancel.TabIndex = 81
        Me.mBtnCancel.Text = "Cancelar"
        Me.mBtnCancel.UseSelectable = True
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFinal.Location = New System.Drawing.Point(144, 37)
        Me.dtFechaFinal.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Size = New System.Drawing.Size(113, 30)
        Me.dtFechaFinal.TabIndex = 79
        '
        'dtFechaInicial
        '
        Me.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaInicial.Location = New System.Drawing.Point(15, 37)
        Me.dtFechaInicial.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtFechaInicial.Name = "dtFechaInicial"
        Me.dtFechaInicial.Size = New System.Drawing.Size(113, 30)
        Me.dtFechaInicial.TabIndex = 78
        '
        'DataGridTikect
        '
        Me.DataGridTikect.AllowUserToAddRows = False
        Me.DataGridTikect.AllowUserToDeleteRows = False
        Me.DataGridTikect.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridTikect.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridTikect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridTikect.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridTikect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridTikect.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridTikect.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridTikect.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridTikect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridTikect.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridTikect.EnableHeadersVisualStyles = False
        Me.DataGridTikect.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DataGridTikect.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridTikect.Location = New System.Drawing.Point(15, 291)
        Me.DataGridTikect.Name = "DataGridTikect"
        Me.DataGridTikect.ReadOnly = True
        Me.DataGridTikect.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridTikect.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridTikect.RowHeadersWidth = 51
        Me.DataGridTikect.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridTikect.RowTemplate.Height = 24
        Me.DataGridTikect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridTikect.Size = New System.Drawing.Size(962, 155)
        Me.DataGridTikect.TabIndex = 76
        '
        'DataGridConsulta
        '
        Me.DataGridConsulta.AllowUserToAddRows = False
        Me.DataGridConsulta.AllowUserToDeleteRows = False
        Me.DataGridConsulta.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.DataGridConsulta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridConsulta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridConsulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridConsulta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridConsulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridConsulta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridConsulta.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridConsulta.EnableHeadersVisualStyles = False
        Me.DataGridConsulta.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DataGridConsulta.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridConsulta.Location = New System.Drawing.Point(15, 82)
        Me.DataGridConsulta.Name = "DataGridConsulta"
        Me.DataGridConsulta.ReadOnly = True
        Me.DataGridConsulta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridConsulta.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridConsulta.RowHeadersWidth = 51
        Me.DataGridConsulta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridConsulta.RowTemplate.Height = 24
        Me.DataGridConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridConsulta.Size = New System.Drawing.Size(962, 155)
        Me.DataGridConsulta.TabIndex = 75
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(64, 474)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Reimprimir Nota de Crédito CFDI"
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
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Fecha Inicial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(140, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Fecha Final"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(14, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Desglose de Ticket"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'FrmListadoNC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(1019, 578)
        Me.ControlBox = false
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = true
        Me.MaximizeBox = false
        Me.Name = "FrmListadoNC"
        Me.Text = "Consulta, Reimpresion y Cancelacion de Notas de Crédito"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.DataGridTikect,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataGridConsulta,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents LblNumTicket As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblTotalText As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridConsulta As MetroFramework.Controls.MetroGrid
    Friend WithEvents DataGridTikect As MetroFramework.Controls.MetroGrid
    Friend WithEvents mBtnXML As MetroFramework.Controls.MetroButton
    Friend WithEvents mBtnCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents dtFechaFinal As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtFechaInicial As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
