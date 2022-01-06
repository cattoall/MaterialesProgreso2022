<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFolioFactura
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ImgSalirB = New System.Windows.Forms.PictureBox()
        Me.ImgSalirA = New System.Windows.Forms.PictureBox()
        Me.ImgNewB = New System.Windows.Forms.PictureBox()
        Me.ImgNewA = New System.Windows.Forms.PictureBox()
        Me.ImgModificarB = New System.Windows.Forms.PictureBox()
        Me.ImgModificarA = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox1.SuspendLayout
        CType(Me.ImgSalirB,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ImgSalirA,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ImgNewB,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ImgNewA,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ImgModificarB,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ImgModificarA,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = false
        Me.DataGridView1.AllowUserToDeleteRows = false
        Me.DataGridView1.AllowUserToResizeRows = false
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(224,Byte),Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(11, 148)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = false
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = true
        Me.DataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellErrors = false
        Me.DataGridView1.ShowCellToolTips = false
        Me.DataGridView1.ShowEditingIcon = false
        Me.DataGridView1.ShowRowErrors = false
        Me.DataGridView1.Size = New System.Drawing.Size(791, 197)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ImgSalirB)
        Me.GroupBox1.Controls.Add(Me.ImgSalirA)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.ImgNewB)
        Me.GroupBox1.Controls.Add(Me.ImgNewA)
        Me.GroupBox1.Controls.Add(Me.ImgModificarB)
        Me.GroupBox1.Controls.Add(Me.ImgModificarA)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 66)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(815, 374)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Folios Fiscales"
        '
        'ImgSalirB
        '
        Me.ImgSalirB.BackColor = System.Drawing.Color.Transparent
        Me.ImgSalirB.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ImgSalirB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgSalirB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.btn_salir
        Me.ImgSalirB.Location = New System.Drawing.Point(507, 69)
        Me.ImgSalirB.Margin = New System.Windows.Forms.Padding(4)
        Me.ImgSalirB.Name = "ImgSalirB"
        Me.ImgSalirB.Size = New System.Drawing.Size(125, 43)
        Me.ImgSalirB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSalirB.TabIndex = 50
        Me.ImgSalirB.TabStop = false
        Me.ToolTip1.SetToolTip(Me.ImgSalirB, "Salir (Esc) ")
        Me.ImgSalirB.Visible = false
        '
        'ImgSalirA
        '
        Me.ImgSalirA.BackColor = System.Drawing.Color.Transparent
        Me.ImgSalirA.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ImgSalirA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgSalirA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.btn_salir
        Me.ImgSalirA.Location = New System.Drawing.Point(511, 70)
        Me.ImgSalirA.Margin = New System.Windows.Forms.Padding(4)
        Me.ImgSalirA.Name = "ImgSalirA"
        Me.ImgSalirA.Size = New System.Drawing.Size(117, 38)
        Me.ImgSalirA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSalirA.TabIndex = 49
        Me.ImgSalirA.TabStop = false
        '
        'ImgNewB
        '
        Me.ImgNewB.BackColor = System.Drawing.Color.Transparent
        Me.ImgNewB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Nuevo
        Me.ImgNewB.Location = New System.Drawing.Point(40, 30)
        Me.ImgNewB.Margin = New System.Windows.Forms.Padding(4)
        Me.ImgNewB.Name = "ImgNewB"
        Me.ImgNewB.Size = New System.Drawing.Size(125, 107)
        Me.ImgNewB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgNewB.TabIndex = 52
        Me.ImgNewB.TabStop = false
        Me.ToolTip1.SetToolTip(Me.ImgNewB, "Nuevo Folio Fiscal")
        Me.ImgNewB.Visible = false
        '
        'ImgNewA
        '
        Me.ImgNewA.BackColor = System.Drawing.Color.Transparent
        Me.ImgNewA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Nuevo
        Me.ImgNewA.Location = New System.Drawing.Point(52, 38)
        Me.ImgNewA.Margin = New System.Windows.Forms.Padding(4)
        Me.ImgNewA.Name = "ImgNewA"
        Me.ImgNewA.Size = New System.Drawing.Size(104, 89)
        Me.ImgNewA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgNewA.TabIndex = 51
        Me.ImgNewA.TabStop = false
        '
        'ImgModificarB
        '
        Me.ImgModificarB.BackColor = System.Drawing.Color.Transparent
        Me.ImgModificarB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Modificar
        Me.ImgModificarB.Location = New System.Drawing.Point(220, 26)
        Me.ImgModificarB.Margin = New System.Windows.Forms.Padding(4)
        Me.ImgModificarB.Name = "ImgModificarB"
        Me.ImgModificarB.Size = New System.Drawing.Size(125, 107)
        Me.ImgModificarB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgModificarB.TabIndex = 54
        Me.ImgModificarB.TabStop = false
        Me.ToolTip1.SetToolTip(Me.ImgModificarB, "Modificar")
        Me.ImgModificarB.Visible = false
        '
        'ImgModificarA
        '
        Me.ImgModificarA.BackColor = System.Drawing.Color.Transparent
        Me.ImgModificarA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Modificar
        Me.ImgModificarA.Location = New System.Drawing.Point(232, 34)
        Me.ImgModificarA.Margin = New System.Windows.Forms.Padding(4)
        Me.ImgModificarA.Name = "ImgModificarA"
        Me.ImgModificarA.Size = New System.Drawing.Size(104, 89)
        Me.ImgModificarA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgModificarA.TabIndex = 53
        Me.ImgModificarA.TabStop = false
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'FrmFolioFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(836, 454)
        Me.ControlBox = false
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = true
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = false
        Me.Name = "FrmFolioFactura"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Text = "Folio Fiscales"
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox1.ResumeLayout(false)
        CType(Me.ImgSalirB,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ImgSalirA,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ImgNewB,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ImgNewA,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ImgModificarB,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ImgModificarA,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ImgSalirB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgSalirA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgNewA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgNewB As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ImgModificarB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgModificarA As System.Windows.Forms.PictureBox
End Class
