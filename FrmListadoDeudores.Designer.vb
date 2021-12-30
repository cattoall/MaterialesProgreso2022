<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoDeudores
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ImgReImpB = New System.Windows.Forms.PictureBox()
        Me.ImgReImpA = New System.Windows.Forms.PictureBox()
        Me.ImgSalirB = New System.Windows.Forms.PictureBox()
        Me.ImgSalirA = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtfinal = New System.Windows.Forms.DateTimePicker()
        Me.dtinicio = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ImgVerReporteA = New System.Windows.Forms.PictureBox()
        Me.ImgVerReporteB = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ImgReImpB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgReImpA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSalirB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSalirA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgVerReporteA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgVerReporteB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.GroupBox1.Controls.Add(Me.ImgReImpB)
        Me.GroupBox1.Controls.Add(Me.ImgReImpA)
        Me.GroupBox1.Controls.Add(Me.ImgSalirB)
        Me.GroupBox1.Controls.Add(Me.ImgSalirA)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lbltotal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtfinal)
        Me.GroupBox1.Controls.Add(Me.dtinicio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.ImgVerReporteA)
        Me.GroupBox1.Controls.Add(Me.ImgVerReporteB)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(883, 440)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'ImgReImpB
        '
        Me.ImgReImpB.BackColor = System.Drawing.Color.Transparent
        Me.ImgReImpB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgReImpB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Reimprimir
        Me.ImgReImpB.Location = New System.Drawing.Point(18, 389)
        Me.ImgReImpB.Name = "ImgReImpB"
        Me.ImgReImpB.Size = New System.Drawing.Size(46, 47)
        Me.ImgReImpB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgReImpB.TabIndex = 62
        Me.ImgReImpB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgReImpB, "Imprimir Reporte")
        Me.ImgReImpB.Visible = False
        '
        'ImgReImpA
        '
        Me.ImgReImpA.BackColor = System.Drawing.Color.Transparent
        Me.ImgReImpA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Reimprimir
        Me.ImgReImpA.Location = New System.Drawing.Point(21, 392)
        Me.ImgReImpA.Name = "ImgReImpA"
        Me.ImgReImpA.Size = New System.Drawing.Size(40, 43)
        Me.ImgReImpA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgReImpA.TabIndex = 61
        Me.ImgReImpA.TabStop = False
        '
        'ImgSalirB
        '
        Me.ImgSalirB.BackColor = System.Drawing.Color.Transparent
        Me.ImgSalirB.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ImgSalirB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgSalirB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.btn_salir
        Me.ImgSalirB.Location = New System.Drawing.Point(776, 26)
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
        Me.ImgSalirA.Location = New System.Drawing.Point(779, 27)
        Me.ImgSalirA.Name = "ImgSalirA"
        Me.ImgSalirA.Size = New System.Drawing.Size(88, 31)
        Me.ImgSalirA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSalirA.TabIndex = 45
        Me.ImgSalirA.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(685, 407)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 22)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Total:"
        '
        'lbltotal
        '
        Me.lbltotal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbltotal.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(745, 405)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(132, 24)
        Me.lbltotal.TabIndex = 18
        Me.lbltotal.Text = "0.00"
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(156, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha Final"
        '
        'dtfinal
        '
        Me.dtfinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfinal.Location = New System.Drawing.Point(156, 40)
        Me.dtfinal.Name = "dtfinal"
        Me.dtfinal.Size = New System.Drawing.Size(114, 26)
        Me.dtfinal.TabIndex = 5
        '
        'dtinicio
        '
        Me.dtinicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtinicio.Location = New System.Drawing.Point(18, 40)
        Me.dtinicio.Name = "dtinicio"
        Me.dtinicio.Size = New System.Drawing.Size(118, 26)
        Me.dtinicio.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(18, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha Inicio"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 74)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(871, 312)
        Me.DataGridView1.TabIndex = 0
        '
        'ImgVerReporteA
        '
        Me.ImgVerReporteA.BackColor = System.Drawing.Color.Transparent
        Me.ImgVerReporteA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.verreportes
        Me.ImgVerReporteA.Location = New System.Drawing.Point(306, 13)
        Me.ImgVerReporteA.Name = "ImgVerReporteA"
        Me.ImgVerReporteA.Size = New System.Drawing.Size(49, 57)
        Me.ImgVerReporteA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgVerReporteA.TabIndex = 63
        Me.ImgVerReporteA.TabStop = False
        '
        'ImgVerReporteB
        '
        Me.ImgVerReporteB.BackColor = System.Drawing.Color.Transparent
        Me.ImgVerReporteB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgVerReporteB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.verreportes
        Me.ImgVerReporteB.Location = New System.Drawing.Point(303, 10)
        Me.ImgVerReporteB.Name = "ImgVerReporteB"
        Me.ImgVerReporteB.Size = New System.Drawing.Size(54, 61)
        Me.ImgVerReporteB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgVerReporteB.TabIndex = 64
        Me.ImgVerReporteB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgVerReporteB, "Ver Reporte")
        Me.ImgVerReporteB.Visible = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'FrmListadoDeudores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(907, 458)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmListadoDeudores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Deudores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ImgReImpB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgReImpA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSalirB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSalirA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgVerReporteA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgVerReporteB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtfinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtinicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ImgSalirB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgSalirA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgReImpB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgReImpA As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ImgVerReporteA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgVerReporteB As System.Windows.Forms.PictureBox
End Class
