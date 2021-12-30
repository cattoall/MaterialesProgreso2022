<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoDePreciosPorLinea
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
        Me.cmblineas = New System.Windows.Forms.ComboBox()
        Me.lbllinea = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbprecio = New System.Windows.Forms.ComboBox()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.ImgBuscarB = New System.Windows.Forms.PictureBox()
        Me.ImgBuscarA = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigodeBarras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ImgGenerarB = New System.Windows.Forms.PictureBox()
        Me.ImgGenerarA = New System.Windows.Forms.PictureBox()
        Me.ImgReImpB = New System.Windows.Forms.PictureBox()
        Me.ImgReImpA = New System.Windows.Forms.PictureBox()
        Me.ImgSalirB = New System.Windows.Forms.PictureBox()
        Me.ImgSalirA = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ImgBuscarB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgBuscarA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ImgGenerarB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgGenerarA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgReImpB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgReImpA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSalirB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSalirA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmblineas
        '
        Me.cmblineas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblineas.FormattingEnabled = True
        Me.cmblineas.Location = New System.Drawing.Point(58, 15)
        Me.cmblineas.Name = "cmblineas"
        Me.cmblineas.Size = New System.Drawing.Size(151, 27)
        Me.cmblineas.TabIndex = 0
        '
        'lbllinea
        '
        Me.lbllinea.AutoSize = True
        Me.lbllinea.BackColor = System.Drawing.Color.Transparent
        Me.lbllinea.Location = New System.Drawing.Point(6, 18)
        Me.lbllinea.Name = "lbllinea"
        Me.lbllinea.Size = New System.Drawing.Size(47, 19)
        Me.lbllinea.TabIndex = 1
        Me.lbllinea.Text = "Linea"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.GroupBox1.Controls.Add(Me.cmbprecio)
        Me.GroupBox1.Controls.Add(Me.txtcliente)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.cmblineas)
        Me.GroupBox1.Controls.Add(Me.lbllinea)
        Me.GroupBox1.Controls.Add(Me.ImgBuscarB)
        Me.GroupBox1.Controls.Add(Me.ImgBuscarA)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(666, 83)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'cmbprecio
        '
        Me.cmbprecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmbprecio.FormattingEnabled = True
        Me.cmbprecio.Items.AddRange(New Object() {"Precio Público", "Precio P1", "Precio P2", "Precio P3"})
        Me.cmbprecio.Location = New System.Drawing.Point(526, 47)
        Me.cmbprecio.Name = "cmbprecio"
        Me.cmbprecio.Size = New System.Drawing.Size(130, 24)
        Me.cmbprecio.TabIndex = 5
        '
        'txtcliente
        '
        Me.txtcliente.Enabled = False
        Me.txtcliente.Location = New System.Drawing.Point(86, 49)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(213, 26)
        Me.txtcliente.TabIndex = 4
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Location = New System.Drawing.Point(458, 50)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(69, 23)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Precio"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 50)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(75, 23)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Cliente"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'ImgBuscarB
        '
        Me.ImgBuscarB.BackColor = System.Drawing.Color.Transparent
        Me.ImgBuscarB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgBuscarB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Buscar
        Me.ImgBuscarB.Location = New System.Drawing.Point(323, 45)
        Me.ImgBuscarB.Name = "ImgBuscarB"
        Me.ImgBuscarB.Size = New System.Drawing.Size(106, 30)
        Me.ImgBuscarB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgBuscarB.TabIndex = 41
        Me.ImgBuscarB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgBuscarB, "Buscar (F2)")
        Me.ImgBuscarB.Visible = False
        '
        'ImgBuscarA
        '
        Me.ImgBuscarA.BackColor = System.Drawing.Color.Transparent
        Me.ImgBuscarA.Cursor = System.Windows.Forms.Cursors.Default
        Me.ImgBuscarA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Buscar
        Me.ImgBuscarA.Location = New System.Drawing.Point(325, 46)
        Me.ImgBuscarA.Name = "ImgBuscarA"
        Me.ImgBuscarA.Size = New System.Drawing.Size(101, 28)
        Me.ImgBuscarA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgBuscarA.TabIndex = 40
        Me.ImgBuscarA.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Clave, Me.CodigodeBarras, Me.Descripcion, Me.UM, Me.Grupo, Me.Precio})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 120)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(808, 262)
        Me.DataGridView1.TabIndex = 3
        '
        'Clave
        '
        Me.Clave.HeaderText = "Clave"
        Me.Clave.Name = "Clave"
        Me.Clave.ReadOnly = True
        '
        'CodigodeBarras
        '
        Me.CodigodeBarras.HeaderText = "CB"
        Me.CodigodeBarras.Name = "CodigodeBarras"
        Me.CodigodeBarras.ReadOnly = True
        Me.CodigodeBarras.ToolTipText = "Código de Barras"
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 250
        '
        'UM
        '
        Me.UM.HeaderText = "U.M."
        Me.UM.Name = "UM"
        Me.UM.ReadOnly = True
        Me.UM.ToolTipText = "Unidad de Medida"
        '
        'Grupo
        '
        Me.Grupo.HeaderText = "Grupo"
        Me.Grupo.Name = "Grupo"
        Me.Grupo.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.GroupBox2.Controls.Add(Me.ImgGenerarB)
        Me.GroupBox2.Controls.Add(Me.ImgGenerarA)
        Me.GroupBox2.Controls.Add(Me.ImgReImpB)
        Me.GroupBox2.Controls.Add(Me.ImgReImpA)
        Me.GroupBox2.Controls.Add(Me.ImgSalirB)
        Me.GroupBox2.Controls.Add(Me.ImgSalirA)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(826, 443)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'ImgGenerarB
        '
        Me.ImgGenerarB.BackColor = System.Drawing.Color.Transparent
        Me.ImgGenerarB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgGenerarB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Generar
        Me.ImgGenerarB.Location = New System.Drawing.Point(722, 22)
        Me.ImgGenerarB.Name = "ImgGenerarB"
        Me.ImgGenerarB.Size = New System.Drawing.Size(84, 39)
        Me.ImgGenerarB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgGenerarB.TabIndex = 44
        Me.ImgGenerarB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgGenerarB, "Generar Reporte")
        Me.ImgGenerarB.Visible = False
        '
        'ImgGenerarA
        '
        Me.ImgGenerarA.BackColor = System.Drawing.Color.Transparent
        Me.ImgGenerarA.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ImgGenerarA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Generar
        Me.ImgGenerarA.Location = New System.Drawing.Point(723, 25)
        Me.ImgGenerarA.Name = "ImgGenerarA"
        Me.ImgGenerarA.Size = New System.Drawing.Size(81, 33)
        Me.ImgGenerarA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgGenerarA.TabIndex = 43
        Me.ImgGenerarA.TabStop = False
        '
        'ImgReImpB
        '
        Me.ImgReImpB.BackColor = System.Drawing.Color.Transparent
        Me.ImgReImpB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgReImpB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Reimprimir
        Me.ImgReImpB.Location = New System.Drawing.Point(398, 388)
        Me.ImgReImpB.Name = "ImgReImpB"
        Me.ImgReImpB.Size = New System.Drawing.Size(46, 47)
        Me.ImgReImpB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgReImpB.TabIndex = 64
        Me.ImgReImpB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgReImpB, "Imprimir")
        Me.ImgReImpB.Visible = False
        '
        'ImgReImpA
        '
        Me.ImgReImpA.BackColor = System.Drawing.Color.Transparent
        Me.ImgReImpA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Reimprimir
        Me.ImgReImpA.Location = New System.Drawing.Point(401, 391)
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
        Me.ImgSalirB.Location = New System.Drawing.Point(716, 66)
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
        Me.ImgSalirA.Location = New System.Drawing.Point(719, 67)
        Me.ImgSalirA.Name = "ImgSalirA"
        Me.ImgSalirA.Size = New System.Drawing.Size(88, 31)
        Me.ImgSalirA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSalirA.TabIndex = 47
        Me.ImgSalirA.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'FrmListadoDePreciosPorLinea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(851, 455)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmListadoDePreciosPorLinea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Productos por Linea"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ImgBuscarB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgBuscarA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ImgGenerarB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgGenerarA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgReImpB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgReImpA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSalirB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSalirA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmblineas As System.Windows.Forms.ComboBox
    Friend WithEvents lbllinea As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents cmbprecio As System.Windows.Forms.ComboBox
    Friend WithEvents txtcliente As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Clave As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigodeBarras As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Grupo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImgSalirB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgSalirA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgReImpB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgReImpA As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ImgGenerarB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgGenerarA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgBuscarB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgBuscarA As System.Windows.Forms.PictureBox
End Class
