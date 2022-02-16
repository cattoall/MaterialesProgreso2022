<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNotaDeCredito
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
        Me.mBtnGenerate = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtUUID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Lbltipo = New MetroFramework.Controls.MetroLabel()
        Me.CmdTipoRelacion = New MetroFramework.Controls.MetroComboBox()
        Me.DGVDetalle = New MetroFramework.Controls.MetroGrid()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtPedido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DTPFecha = New MetroFramework.Controls.MetroDateTime()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNombre_C = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtStatus_C = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTipo_C = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTotal_C = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPedido_C = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Folio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaveP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaveProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaveUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mBtnGenerate)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtIVA)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtSubtotal)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtUUID)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Lbltipo)
        Me.GroupBox1.Controls.Add(Me.CmdTipoRelacion)
        Me.GroupBox1.Controls.Add(Me.DGVDetalle)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxtPedido)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(968, 597)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'mBtnGenerate
        '
        Me.mBtnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mBtnGenerate.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.mBtnGenerate.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.export_16px
        Me.mBtnGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mBtnGenerate.Location = New System.Drawing.Point(574, 532)
        Me.mBtnGenerate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.mBtnGenerate.Name = "mBtnGenerate"
        Me.mBtnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.mBtnGenerate.TabIndex = 80
        Me.mBtnGenerate.Text = "Generar"
        Me.mBtnGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mBtnGenerate.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.close_window_16px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(879, 19)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 79
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtIVA
        '
        Me.txtIVA.Enabled = False
        Me.txtIVA.Location = New System.Drawing.Point(814, 498)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Size = New System.Drawing.Size(134, 19)
        Me.txtIVA.TabIndex = 86
        Me.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(768, 505)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 13)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "IVA:"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Enabled = False
        Me.txtSubtotal.Location = New System.Drawing.Point(815, 466)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(134, 19)
        Me.txtSubtotal.TabIndex = 84
        Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(740, 473)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "Subtotal:"
        '
        'txtUUID
        '
        Me.txtUUID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUUID.Enabled = False
        Me.txtUUID.Location = New System.Drawing.Point(338, 16)
        Me.txtUUID.Name = "txtUUID"
        Me.txtUUID.Size = New System.Drawing.Size(375, 19)
        Me.txtUUID.TabIndex = 82
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(288, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "UUID"
        '
        'Lbltipo
        '
        Me.Lbltipo.AutoSize = True
        Me.Lbltipo.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Lbltipo.Location = New System.Drawing.Point(13, 470)
        Me.Lbltipo.Name = "Lbltipo"
        Me.Lbltipo.Size = New System.Drawing.Size(121, 19)
        Me.Lbltipo.TabIndex = 79
        Me.Lbltipo.Text = "Tipo de Relación"
        '
        'CmdTipoRelacion
        '
        Me.CmdTipoRelacion.FormattingEnabled = True
        Me.CmdTipoRelacion.ItemHeight = 23
        Me.CmdTipoRelacion.Location = New System.Drawing.Point(140, 466)
        Me.CmdTipoRelacion.Name = "CmdTipoRelacion"
        Me.CmdTipoRelacion.Size = New System.Drawing.Size(509, 29)
        Me.CmdTipoRelacion.TabIndex = 80
        Me.CmdTipoRelacion.UseSelectable = True
        '
        'DGVDetalle
        '
        Me.DGVDetalle.AllowUserToAddRows = False
        Me.DGVDetalle.AllowUserToDeleteRows = False
        Me.DGVDetalle.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DGVDetalle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVDetalle.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DGVDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.SubTotal, Me.Cantidad, Me.Folio, Me.ClaveP, Me.IVA, Me.ClaveProducto, Me.ClaveUnidad})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVDetalle.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVDetalle.EnableHeadersVisualStyles = False
        Me.DGVDetalle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DGVDetalle.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVDetalle.Location = New System.Drawing.Point(5, 154)
        Me.DGVDetalle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DGVDetalle.MultiSelect = False
        Me.DGVDetalle.Name = "DGVDetalle"
        Me.DGVDetalle.ReadOnly = True
        Me.DGVDetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGVDetalle.RowHeadersWidth = 51
        Me.DGVDetalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGVDetalle.RowTemplate.Height = 24
        Me.DGVDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVDetalle.ShowEditingIcon = False
        Me.DGVDetalle.Size = New System.Drawing.Size(949, 298)
        Me.DGVDetalle.TabIndex = 76
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(814, 530)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(134, 19)
        Me.txtTotal.TabIndex = 9
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(760, 537)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Total:"
        '
        'TxtPedido
        '
        Me.TxtPedido.Location = New System.Drawing.Point(87, 18)
        Me.TxtPedido.Name = "TxtPedido"
        Me.TxtPedido.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPedido.Size = New System.Drawing.Size(100, 19)
        Me.TxtPedido.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Factura:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DTPFecha)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TxtNombre_C)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtStatus_C)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtTipo_C)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtTotal_C)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtPedido_C)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(948, 106)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cabecera"
        '
        'DTPFecha
        '
        Me.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecha.Location = New System.Drawing.Point(272, 26)
        Me.DTPFecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DTPFecha.MinimumSize = New System.Drawing.Size(0, 29)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(106, 30)
        Me.DTPFecha.TabIndex = 87
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(576, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Label9"
        '
        'TxtNombre_C
        '
        Me.TxtNombre_C.Enabled = False
        Me.TxtNombre_C.Location = New System.Drawing.Point(88, 66)
        Me.TxtNombre_C.Name = "TxtNombre_C"
        Me.TxtNombre_C.Size = New System.Drawing.Size(482, 19)
        Me.TxtNombre_C.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(6, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Vendido a:"
        '
        'TxtStatus_C
        '
        Me.TxtStatus_C.Enabled = False
        Me.TxtStatus_C.Location = New System.Drawing.Point(835, 26)
        Me.TxtStatus_C.Name = "TxtStatus_C"
        Me.TxtStatus_C.Size = New System.Drawing.Size(108, 19)
        Me.TxtStatus_C.TabIndex = 11
        Me.TxtStatus_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(780, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Status:"
        '
        'TxtTipo_C
        '
        Me.TxtTipo_C.Enabled = False
        Me.TxtTipo_C.Location = New System.Drawing.Point(666, 26)
        Me.TxtTipo_C.Name = "TxtTipo_C"
        Me.TxtTipo_C.Size = New System.Drawing.Size(100, 19)
        Me.TxtTipo_C.TabIndex = 9
        Me.TxtTipo_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(595, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tipo Vta:"
        '
        'TxtTotal_C
        '
        Me.TxtTotal_C.Enabled = False
        Me.TxtTotal_C.Location = New System.Drawing.Point(470, 26)
        Me.TxtTotal_C.Name = "TxtTotal_C"
        Me.TxtTotal_C.Size = New System.Drawing.Size(100, 19)
        Me.TxtTotal_C.TabIndex = 7
        Me.TxtTotal_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(421, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(216, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha:"
        '
        'TxtPedido_C
        '
        Me.TxtPedido_C.Enabled = False
        Me.TxtPedido_C.Location = New System.Drawing.Point(87, 26)
        Me.TxtPedido_C.Name = "TxtPedido_C"
        Me.TxtPedido_C.Size = New System.Drawing.Size(100, 19)
        Me.TxtPedido_C.TabIndex = 3
        Me.TxtPedido_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(6, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Factura:"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "No. Factura"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "ID Producto"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Cantidad"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Descripción"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "Precio"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'SubTotal
        '
        Me.SubTotal.HeaderText = "SubTotal"
        Me.SubTotal.MinimumWidth = 6
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.ReadOnly = True
        Me.SubTotal.Visible = False
        Me.SubTotal.Width = 90
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Visible = False
        Me.Cantidad.Width = 92
        '
        'Folio
        '
        Me.Folio.HeaderText = "Folio"
        Me.Folio.MinimumWidth = 6
        Me.Folio.Name = "Folio"
        Me.Folio.ReadOnly = True
        Me.Folio.Visible = False
        Me.Folio.Width = 65
        '
        'ClaveP
        '
        Me.ClaveP.HeaderText = "ClaveP"
        Me.ClaveP.MinimumWidth = 6
        Me.ClaveP.Name = "ClaveP"
        Me.ClaveP.ReadOnly = True
        Me.ClaveP.Visible = False
        Me.ClaveP.Width = 76
        '
        'IVA
        '
        Me.IVA.HeaderText = "IVA"
        Me.IVA.MinimumWidth = 6
        Me.IVA.Name = "IVA"
        Me.IVA.ReadOnly = True
        Me.IVA.Visible = False
        Me.IVA.Width = 54
        '
        'ClaveProducto
        '
        Me.ClaveProducto.HeaderText = "ClaveProducto"
        Me.ClaveProducto.MinimumWidth = 6
        Me.ClaveProducto.Name = "ClaveProducto"
        Me.ClaveProducto.ReadOnly = True
        Me.ClaveProducto.Visible = False
        Me.ClaveProducto.Width = 128
        '
        'ClaveUnidad
        '
        Me.ClaveUnidad.HeaderText = "ClaveUnidad"
        Me.ClaveUnidad.MinimumWidth = 6
        Me.ClaveUnidad.Name = "ClaveUnidad"
        Me.ClaveUnidad.ReadOnly = True
        Me.ClaveUnidad.Visible = False
        Me.ClaveUnidad.Width = 116
        '
        'FrmNotaDeCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(992, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmNotaDeCredito"
        Me.Padding = New System.Windows.Forms.Padding(15, 60, 15, 16)
        Me.Text = "Notas de Crédito"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.DGVDetalle,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtPedido As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtPedido_C As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTotal_C As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTipo_C As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtStatus_C As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre_C As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DGVDetalle As MetroFramework.Controls.MetroGrid
    Friend WithEvents Lbltipo As MetroFramework.Controls.MetroLabel
    Friend WithEvents CmdTipoRelacion As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtUUID As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtIVA As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DTPFecha As MetroFramework.Controls.MetroDateTime
    Friend WithEvents mBtnGenerate As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Folio As DataGridViewTextBoxColumn
    Friend WithEvents ClaveP As DataGridViewTextBoxColumn
    Friend WithEvents IVA As DataGridViewTextBoxColumn
    Friend WithEvents ClaveProducto As DataGridViewTextBoxColumn
    Friend WithEvents ClaveUnidad As DataGridViewTextBoxColumn
End Class
