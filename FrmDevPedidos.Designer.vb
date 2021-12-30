<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDevPedidos
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ImgGenerarB = New System.Windows.Forms.PictureBox()
        Me.DGVDetalle = New System.Windows.Forms.DataGridView()
        Me.FolioPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadOriginal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtPedido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNombre_C = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtStatus_C = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTipo_C = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPedido_C = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ImgSalirB = New System.Windows.Forms.PictureBox()
        Me.ImgSalirA = New System.Windows.Forms.PictureBox()
        Me.ImgGenerarA = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtSubTotal_C = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtIVA_C = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTotal_C = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIVA_N = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSubTotal_N = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtTotal_N = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ImgGenerarB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ImgSalirB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSalirA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgGenerarA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.GroupBox1.Controls.Add(Me.txtIVA_N)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtSubTotal_N)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TxtTotal_N)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ImgGenerarB)
        Me.GroupBox1.Controls.Add(Me.DGVDetalle)
        Me.GroupBox1.Controls.Add(Me.TxtPedido)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.ImgSalirB)
        Me.GroupBox1.Controls.Add(Me.ImgSalirA)
        Me.GroupBox1.Controls.Add(Me.ImgGenerarA)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(985, 562)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ImgGenerarB
        '
        Me.ImgGenerarB.BackColor = System.Drawing.Color.Transparent
        Me.ImgGenerarB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgGenerarB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Generar
        Me.ImgGenerarB.Location = New System.Drawing.Point(458, 517)
        Me.ImgGenerarB.Name = "ImgGenerarB"
        Me.ImgGenerarB.Size = New System.Drawing.Size(84, 39)
        Me.ImgGenerarB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgGenerarB.TabIndex = 40
        Me.ImgGenerarB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgGenerarB, "Generar Devolución")
        Me.ImgGenerarB.Visible = False
        '
        'DGVDetalle
        '
        Me.DGVDetalle.AllowUserToAddRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        Me.DGVDetalle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DGVDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FolioPedido, Me.IdProducto, Me.Cantidad, Me.Concepto, Me.PU, Me.Importe, Me.CantidadOriginal})
        Me.DGVDetalle.Location = New System.Drawing.Point(6, 158)
        Me.DGVDetalle.Name = "DGVDetalle"
        Me.DGVDetalle.RowHeadersVisible = False
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black
        Me.DGVDetalle.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.DGVDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVDetalle.ShowCellErrors = False
        Me.DGVDetalle.ShowCellToolTips = False
        Me.DGVDetalle.ShowEditingIcon = False
        Me.DGVDetalle.ShowRowErrors = False
        Me.DGVDetalle.Size = New System.Drawing.Size(963, 320)
        Me.DGVDetalle.TabIndex = 3
        '
        'FolioPedido
        '
        Me.FolioPedido.HeaderText = "Folio Pedido"
        Me.FolioPedido.Name = "FolioPedido"
        Me.FolioPedido.ReadOnly = True
        Me.FolioPedido.Visible = False
        '
        'IdProducto
        '
        Me.IdProducto.HeaderText = "IdProducto"
        Me.IdProducto.Name = "IdProducto"
        Me.IdProducto.ReadOnly = True
        Me.IdProducto.Visible = False
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 150
        '
        'Concepto
        '
        Me.Concepto.HeaderText = "Descripción"
        Me.Concepto.Name = "Concepto"
        Me.Concepto.ReadOnly = True
        Me.Concepto.Width = 400
        '
        'PU
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PU.DefaultCellStyle = DataGridViewCellStyle14
        Me.PU.HeaderText = "Precio Unitario"
        Me.PU.Name = "PU"
        Me.PU.ReadOnly = True
        Me.PU.Width = 150
        '
        'Importe
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Importe.DefaultCellStyle = DataGridViewCellStyle15
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        Me.Importe.Width = 150
        '
        'CantidadOriginal
        '
        Me.CantidadOriginal.HeaderText = "CantidadOriginal"
        Me.CantidadOriginal.Name = "CantidadOriginal"
        Me.CantidadOriginal.ReadOnly = True
        Me.CantidadOriginal.Visible = False
        '
        'TxtPedido
        '
        Me.TxtPedido.Location = New System.Drawing.Point(87, 15)
        Me.TxtPedido.Name = "TxtPedido"
        Me.TxtPedido.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPedido.Size = New System.Drawing.Size(100, 26)
        Me.TxtPedido.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "N° Pedido:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.GroupBox2.Controls.Add(Me.txtSubTotal_C)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtIVA_C)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtTotal_C)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TxtNombre_C)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtStatus_C)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtTipo_C)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.DTPFecha)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtPedido_C)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(963, 105)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cabecera"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(576, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 19)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Label9"
        Me.Label9.Visible = False
        '
        'TxtNombre_C
        '
        Me.TxtNombre_C.Enabled = False
        Me.TxtNombre_C.Location = New System.Drawing.Point(88, 66)
        Me.TxtNombre_C.Name = "TxtNombre_C"
        Me.TxtNombre_C.Size = New System.Drawing.Size(482, 26)
        Me.TxtNombre_C.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(6, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 19)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Vendido a:"
        '
        'TxtStatus_C
        '
        Me.TxtStatus_C.Enabled = False
        Me.TxtStatus_C.Location = New System.Drawing.Point(620, 26)
        Me.TxtStatus_C.Name = "TxtStatus_C"
        Me.TxtStatus_C.Size = New System.Drawing.Size(114, 26)
        Me.TxtStatus_C.TabIndex = 11
        Me.TxtStatus_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(563, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Status:"
        '
        'TxtTipo_C
        '
        Me.TxtTipo_C.Enabled = False
        Me.TxtTipo_C.Location = New System.Drawing.Point(460, 26)
        Me.TxtTipo_C.Name = "TxtTipo_C"
        Me.TxtTipo_C.Size = New System.Drawing.Size(100, 26)
        Me.TxtTipo_C.TabIndex = 9
        Me.TxtTipo_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(389, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tipo Vta:"
        '
        'DTPFecha
        '
        Me.DTPFecha.CustomFormat = "dd/MM/yyyy"
        Me.DTPFecha.Enabled = False
        Me.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFecha.Location = New System.Drawing.Point(273, 26)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(106, 26)
        Me.DTPFecha.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(216, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha:"
        '
        'TxtPedido_C
        '
        Me.TxtPedido_C.Enabled = False
        Me.TxtPedido_C.Location = New System.Drawing.Point(87, 26)
        Me.TxtPedido_C.Name = "TxtPedido_C"
        Me.TxtPedido_C.Size = New System.Drawing.Size(100, 26)
        Me.TxtPedido_C.TabIndex = 3
        Me.TxtPedido_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(6, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "N° Pedido:"
        '
        'ImgSalirB
        '
        Me.ImgSalirB.BackColor = System.Drawing.Color.Transparent
        Me.ImgSalirB.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ImgSalirB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgSalirB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.btn_salir
        Me.ImgSalirB.Location = New System.Drawing.Point(875, 17)
        Me.ImgSalirB.Name = "ImgSalirB"
        Me.ImgSalirB.Size = New System.Drawing.Size(94, 35)
        Me.ImgSalirB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSalirB.TabIndex = 38
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
        Me.ImgSalirA.Location = New System.Drawing.Point(878, 18)
        Me.ImgSalirA.Name = "ImgSalirA"
        Me.ImgSalirA.Size = New System.Drawing.Size(88, 31)
        Me.ImgSalirA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSalirA.TabIndex = 37
        Me.ImgSalirA.TabStop = False
        '
        'ImgGenerarA
        '
        Me.ImgGenerarA.BackColor = System.Drawing.Color.Transparent
        Me.ImgGenerarA.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ImgGenerarA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Generar
        Me.ImgGenerarA.Location = New System.Drawing.Point(459, 520)
        Me.ImgGenerarA.Name = "ImgGenerarA"
        Me.ImgGenerarA.Size = New System.Drawing.Size(81, 33)
        Me.ImgGenerarA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgGenerarA.TabIndex = 39
        Me.ImgGenerarA.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'txtSubTotal_C
        '
        Me.txtSubTotal_C.Enabled = False
        Me.txtSubTotal_C.Location = New System.Drawing.Point(857, 13)
        Me.txtSubTotal_C.Name = "txtSubTotal_C"
        Me.txtSubTotal_C.Size = New System.Drawing.Size(100, 26)
        Me.txtSubTotal_C.TabIndex = 24
        Me.txtSubTotal_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(783, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 19)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "SubTotal:"
        '
        'txtIVA_C
        '
        Me.txtIVA_C.Enabled = False
        Me.txtIVA_C.Location = New System.Drawing.Point(857, 44)
        Me.txtIVA_C.Name = "txtIVA_C"
        Me.txtIVA_C.Size = New System.Drawing.Size(100, 26)
        Me.txtIVA_C.TabIndex = 22
        Me.txtIVA_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(816, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 19)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "IVA:"
        '
        'txtTotal_C
        '
        Me.txtTotal_C.Enabled = False
        Me.txtTotal_C.Location = New System.Drawing.Point(857, 74)
        Me.txtTotal_C.Name = "txtTotal_C"
        Me.txtTotal_C.Size = New System.Drawing.Size(100, 26)
        Me.txtTotal_C.TabIndex = 20
        Me.txtTotal_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(808, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 19)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Total:"
        '
        'txtIVA_N
        '
        Me.txtIVA_N.Enabled = False
        Me.txtIVA_N.Location = New System.Drawing.Point(169, 505)
        Me.txtIVA_N.Name = "txtIVA_N"
        Me.txtIVA_N.Size = New System.Drawing.Size(134, 26)
        Me.txtIVA_N.TabIndex = 48
        Me.txtIVA_N.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(165, 483)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 19)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Nuevo IVA:"
        '
        'txtSubTotal_N
        '
        Me.txtSubTotal_N.Enabled = False
        Me.txtSubTotal_N.Location = New System.Drawing.Point(16, 505)
        Me.txtSubTotal_N.Name = "txtSubTotal_N"
        Me.txtSubTotal_N.Size = New System.Drawing.Size(134, 26)
        Me.txtSubTotal_N.TabIndex = 46
        Me.txtSubTotal_N.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(12, 483)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 19)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Nuevo SubTotal:"
        '
        'TxtTotal_N
        '
        Me.TxtTotal_N.Enabled = False
        Me.TxtTotal_N.Location = New System.Drawing.Point(319, 505)
        Me.TxtTotal_N.Name = "TxtTotal_N"
        Me.TxtTotal_N.Size = New System.Drawing.Size(134, 26)
        Me.TxtTotal_N.TabIndex = 44
        Me.TxtTotal_N.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(315, 483)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 19)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Nuevo Total:"
        '
        'FrmDevPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(1007, 577)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmDevPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Devolución de Pedidos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ImgGenerarB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ImgSalirB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSalirA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgGenerarA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtPedido As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtPedido_C As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTPFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTipo_C As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtStatus_C As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre_C As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DGVDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents FolioPedido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Concepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadOriginal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImgSalirB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgSalirA As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ImgGenerarA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgGenerarB As System.Windows.Forms.PictureBox
    Friend WithEvents txtSubTotal_C As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtIVA_C As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTotal_C As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIVA_N As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtSubTotal_N As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtTotal_N As TextBox
    Friend WithEvents Label8 As Label
End Class
