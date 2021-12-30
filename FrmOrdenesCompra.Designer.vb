<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenesCompra
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
        Me.Cmdreimprimir = New System.Windows.Forms.Button()
        Me.Lblorden = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ImgReImpB = New System.Windows.Forms.PictureBox()
        Me.ImgReImpA = New System.Windows.Forms.PictureBox()
        Me.ImgSalirB = New System.Windows.Forms.PictureBox()
        Me.ImgSalirA = New System.Windows.Forms.PictureBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Cmdverventa = New System.Windows.Forms.Button()
        Me.dpfinal = New System.Windows.Forms.DateTimePicker()
        Me.dpinicio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblticket = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ImgReImpB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgReImpA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSalirB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSalirA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cmdreimprimir
        '
        Me.Cmdreimprimir.Enabled = False
        Me.Cmdreimprimir.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.printer
        Me.Cmdreimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmdreimprimir.Location = New System.Drawing.Point(441, 21)
        Me.Cmdreimprimir.Name = "Cmdreimprimir"
        Me.Cmdreimprimir.Size = New System.Drawing.Size(129, 36)
        Me.Cmdreimprimir.TabIndex = 7
        Me.Cmdreimprimir.Text = "Reimprimir"
        Me.Cmdreimprimir.UseVisualStyleBackColor = True
        '
        'Lblorden
        '
        Me.Lblorden.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lblorden.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblorden.Location = New System.Drawing.Point(236, 346)
        Me.Lblorden.Name = "Lblorden"
        Me.Lblorden.Size = New System.Drawing.Size(132, 24)
        Me.Lblorden.TabIndex = 6
        Me.Lblorden.Text = "0"
        Me.Lblorden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.GroupBox1.Controls.Add(Me.ImgReImpB)
        Me.GroupBox1.Controls.Add(Me.ImgReImpA)
        Me.GroupBox1.Controls.Add(Me.ImgSalirB)
        Me.GroupBox1.Controls.Add(Me.ImgSalirA)
        Me.GroupBox1.Controls.Add(Me.Cmdreimprimir)
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Controls.Add(Me.Lblorden)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Cmdverventa)
        Me.GroupBox1.Controls.Add(Me.dpfinal)
        Me.GroupBox1.Controls.Add(Me.dpinicio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblticket)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(914, 562)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'ImgReImpB
        '
        Me.ImgReImpB.BackColor = System.Drawing.Color.Transparent
        Me.ImgReImpB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgReImpB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Reimprimir
        Me.ImgReImpB.Location = New System.Drawing.Point(666, 14)
        Me.ImgReImpB.Name = "ImgReImpB"
        Me.ImgReImpB.Size = New System.Drawing.Size(46, 47)
        Me.ImgReImpB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgReImpB.TabIndex = 64
        Me.ImgReImpB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgReImpB, "Reimprimir")
        Me.ImgReImpB.Visible = False
        '
        'ImgReImpA
        '
        Me.ImgReImpA.BackColor = System.Drawing.Color.Transparent
        Me.ImgReImpA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Reimprimir
        Me.ImgReImpA.Location = New System.Drawing.Point(669, 17)
        Me.ImgReImpA.Name = "ImgReImpA"
        Me.ImgReImpA.Size = New System.Drawing.Size(40, 43)
        Me.ImgReImpA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgReImpA.TabIndex = 63
        Me.ImgReImpA.TabStop = False
        '
        'ImgSalirB
        '
        Me.ImgSalirB.BackColor = System.Drawing.Color.Transparent
        Me.ImgSalirB.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ImgSalirB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgSalirB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.btn_salir
        Me.ImgSalirB.Location = New System.Drawing.Point(803, 16)
        Me.ImgSalirB.Name = "ImgSalirB"
        Me.ImgSalirB.Size = New System.Drawing.Size(94, 35)
        Me.ImgSalirB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSalirB.TabIndex = 48
        Me.ImgSalirB.TabStop = False
        Me.ImgSalirB.Visible = False
        '
        'ImgSalirA
        '
        Me.ImgSalirA.BackColor = System.Drawing.Color.Transparent
        Me.ImgSalirA.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ImgSalirA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgSalirA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.btn_salir
        Me.ImgSalirA.Location = New System.Drawing.Point(806, 17)
        Me.ImgSalirA.Name = "ImgSalirA"
        Me.ImgSalirA.Size = New System.Drawing.Size(88, 31)
        Me.ImgSalirA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSalirA.TabIndex = 47
        Me.ImgSalirA.TabStop = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 375)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.Size = New System.Drawing.Size(902, 182)
        Me.DataGridView2.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 64)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(902, 241)
        Me.DataGridView1.TabIndex = 9
        '
        'Cmdverventa
        '
        Me.Cmdverventa.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.report
        Me.Cmdverventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmdverventa.Location = New System.Drawing.Point(305, 21)
        Me.Cmdverventa.Name = "Cmdverventa"
        Me.Cmdverventa.Size = New System.Drawing.Size(130, 36)
        Me.Cmdverventa.TabIndex = 7
        Me.Cmdverventa.Text = "Ver Ventas"
        Me.Cmdverventa.UseVisualStyleBackColor = True
        '
        'dpfinal
        '
        Me.dpfinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpfinal.Location = New System.Drawing.Point(167, 37)
        Me.dpfinal.Name = "dpfinal"
        Me.dpfinal.Size = New System.Drawing.Size(113, 26)
        Me.dpfinal.TabIndex = 6
        '
        'dpinicio
        '
        Me.dpinicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpinicio.Location = New System.Drawing.Point(6, 37)
        Me.dpinicio.Name = "dpinicio"
        Me.dpinicio.Size = New System.Drawing.Size(111, 26)
        Me.dpinicio.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(167, 16)
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
        Me.lblticket.Location = New System.Drawing.Point(3, 349)
        Me.lblticket.Name = "lblticket"
        Me.lblticket.Size = New System.Drawing.Size(222, 19)
        Me.lblticket.TabIndex = 2
        Me.lblticket.Text = "Detalle de la Orden de Compra:"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'frmOrdenesCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(938, 573)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "frmOrdenesCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordenes de Compra"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ImgReImpB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgReImpA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSalirB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSalirA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Cmdreimprimir As System.Windows.Forms.Button
    Friend WithEvents Lblorden As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmdverventa As System.Windows.Forms.Button
    Friend WithEvents dpfinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dpinicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblticket As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents ImgSalirB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgSalirA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgReImpB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgReImpA As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
