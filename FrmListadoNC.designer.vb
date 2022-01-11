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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mBtnPrint = New MetroFramework.Controls.MetroButton()
        Me.mBtnXML = New MetroFramework.Controls.MetroButton()
        Me.mBtnCancel = New MetroFramework.Controls.MetroButton()
        Me.mBtnSearch = New MetroFramework.Controls.MetroButton()
        Me.dtFechaFinal = New MetroFramework.Controls.MetroDateTime()
        Me.dtFechaInicial = New MetroFramework.Controls.MetroDateTime()
        Me.mBtnExit = New MetroFramework.Controls.MetroButton()
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
        Me.GroupBox1.SuspendLayout
        CType(Me.DataGridTikect,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DataGridConsulta,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mBtnPrint)
        Me.GroupBox1.Controls.Add(Me.mBtnXML)
        Me.GroupBox1.Controls.Add(Me.mBtnCancel)
        Me.GroupBox1.Controls.Add(Me.mBtnSearch)
        Me.GroupBox1.Controls.Add(Me.dtFechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtFechaInicial)
        Me.GroupBox1.Controls.Add(Me.mBtnExit)
        Me.GroupBox1.Controls.Add(Me.DataGridTikect)
        Me.GroupBox1.Controls.Add(Me.DataGridConsulta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LblTotalText)
        Me.GroupBox1.Controls.Add(Me.LblTotal)
        Me.GroupBox1.Controls.Add(Me.LblNumTicket)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(995, 500)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = false
        '
        'mBtnPrint
        '
        Me.mBtnPrint.Location = New System.Drawing.Point(18, 466)
        Me.mBtnPrint.Name = "mBtnPrint"
        Me.mBtnPrint.Size = New System.Drawing.Size(75, 23)
        Me.mBtnPrint.TabIndex = 83
        Me.mBtnPrint.Text = "Imprimir"
        Me.mBtnPrint.UseSelectable = true
        '
        'mBtnXML
        '
        Me.mBtnXML.Location = New System.Drawing.Point(365, 255)
        Me.mBtnXML.Name = "mBtnXML"
        Me.mBtnXML.Size = New System.Drawing.Size(75, 23)
        Me.mBtnXML.TabIndex = 82
        Me.mBtnXML.Text = "XML"
        Me.mBtnXML.UseSelectable = true
        '
        'mBtnCancel
        '
        Me.mBtnCancel.Location = New System.Drawing.Point(284, 255)
        Me.mBtnCancel.Name = "mBtnCancel"
        Me.mBtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.mBtnCancel.TabIndex = 81
        Me.mBtnCancel.Text = "Cancelar"
        Me.mBtnCancel.UseSelectable = true
        '
        'mBtnSearch
        '
        Me.mBtnSearch.Location = New System.Drawing.Point(263, 44)
        Me.mBtnSearch.Name = "mBtnSearch"
        Me.mBtnSearch.Size = New System.Drawing.Size(75, 23)
        Me.mBtnSearch.TabIndex = 80
        Me.mBtnSearch.Text = "Buscar"
        Me.mBtnSearch.UseSelectable = true
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFinal.Location = New System.Drawing.Point(144, 37)
        Me.dtFechaFinal.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Size = New System.Drawing.Size(113, 30)
        Me.dtFechaFinal.TabIndex = 79
        '
        'dtFechaInicial
        '
        Me.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaInicial.Location = New System.Drawing.Point(15, 37)
        Me.dtFechaInicial.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtFechaInicial.Name = "dtFechaInicial"
        Me.dtFechaInicial.Size = New System.Drawing.Size(113, 30)
        Me.dtFechaInicial.TabIndex = 78
        '
        'mBtnExit
        '
        Me.mBtnExit.Location = New System.Drawing.Point(902, 44)
        Me.mBtnExit.Name = "mBtnExit"
        Me.mBtnExit.Size = New System.Drawing.Size(75, 23)
        Me.mBtnExit.TabIndex = 77
        Me.mBtnExit.Text = "Salir"
        Me.mBtnExit.UseSelectable = true
        '
        'DataGridTikect
        '
        Me.DataGridTikect.AllowUserToAddRows = false
        Me.DataGridTikect.AllowUserToDeleteRows = false
        Me.DataGridTikect.AllowUserToResizeRows = false
        Me.DataGridTikect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridTikect.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.DataGridTikect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridTikect.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridTikect.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridTikect.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridTikect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridTikect.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridTikect.EnableHeadersVisualStyles = false
        Me.DataGridTikect.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DataGridTikect.GridColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.DataGridTikect.Location = New System.Drawing.Point(15, 291)
        Me.DataGridTikect.Name = "DataGridTikect"
        Me.DataGridTikect.ReadOnly = true
        Me.DataGridTikect.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridTikect.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridTikect.RowHeadersWidth = 51
        Me.DataGridTikect.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridTikect.RowTemplate.Height = 24
        Me.DataGridTikect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridTikect.Size = New System.Drawing.Size(962, 155)
        Me.DataGridTikect.TabIndex = 76
        '
        'DataGridConsulta
        '
        Me.DataGridConsulta.AllowUserToAddRows = false
        Me.DataGridConsulta.AllowUserToDeleteRows = false
        Me.DataGridConsulta.AllowUserToResizeRows = false
        Me.DataGridConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridConsulta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.DataGridConsulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridConsulta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridConsulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridConsulta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridConsulta.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridConsulta.EnableHeadersVisualStyles = false
        Me.DataGridConsulta.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DataGridConsulta.GridColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.DataGridConsulta.Location = New System.Drawing.Point(15, 82)
        Me.DataGridConsulta.Name = "DataGridConsulta"
        Me.DataGridConsulta.ReadOnly = true
        Me.DataGridConsulta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridConsulta.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridConsulta.RowHeadersWidth = 51
        Me.DataGridConsulta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridConsulta.RowTemplate.Height = 24
        Me.DataGridConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridConsulta.Size = New System.Drawing.Size(962, 155)
        Me.DataGridConsulta.TabIndex = 75
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(64, 474)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(295, 23)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Reimprimir Nota de Crédito CFDI"
        '
        'LblTotalText
        '
        Me.LblTotalText.AutoSize = true
        Me.LblTotalText.BackColor = System.Drawing.Color.Transparent
        Me.LblTotalText.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LblTotalText.Location = New System.Drawing.Point(773, 467)
        Me.LblTotalText.Name = "LblTotalText"
        Me.LblTotalText.Size = New System.Drawing.Size(72, 26)
        Me.LblTotalText.TabIndex = 39
        Me.LblTotalText.Text = "Total:"
        '
        'LblTotal
        '
        Me.LblTotal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblTotal.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LblTotal.Location = New System.Drawing.Point(832, 466)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(145, 24)
        Me.LblTotal.TabIndex = 36
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblNumTicket
        '
        Me.LblNumTicket.AutoSize = true
        Me.LblNumTicket.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblNumTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNumTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LblNumTicket.Location = New System.Drawing.Point(154, 251)
        Me.LblNumTicket.Name = "LblNumTicket"
        Me.LblNumTicket.Size = New System.Drawing.Size(2, 27)
        Me.LblNumTicket.TabIndex = 35
        Me.LblNumTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(12, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 23)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Fecha Inicial"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(140, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 23)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Fecha Final"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(14, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 23)
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9!, 17!)
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
    Friend WithEvents mBtnPrint As MetroFramework.Controls.MetroButton
    Friend WithEvents mBtnXML As MetroFramework.Controls.MetroButton
    Friend WithEvents mBtnCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents mBtnSearch As MetroFramework.Controls.MetroButton
    Friend WithEvents dtFechaFinal As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtFechaInicial As MetroFramework.Controls.MetroDateTime
    Friend WithEvents mBtnExit As MetroFramework.Controls.MetroButton
End Class
