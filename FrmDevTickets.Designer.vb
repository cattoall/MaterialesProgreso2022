<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDevTickets
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmdGenerar = New System.Windows.Forms.Button()
        Me.DGVDetalle = New MetroFramework.Controls.MetroGrid()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtIVA_N = New System.Windows.Forms.TextBox()
        Me.txtSubTotal_N = New System.Windows.Forms.TextBox()
        Me.TxtTotal_N = New System.Windows.Forms.TextBox()
        Me.TxtPedido = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DTPFecha = New MetroFramework.Controls.MetroDateTime()
        Me.txtSubTotal_C = New System.Windows.Forms.TextBox()
        Me.Label9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.txtIVA_C = New System.Windows.Forms.TextBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.TxtNombre_C = New System.Windows.Forms.TextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.TxtStatus_C = New System.Windows.Forms.TextBox()
        Me.TxtTipo_C = New System.Windows.Forms.TextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtTotal_C = New System.Windows.Forms.TextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.TxtPedido_C = New System.Windows.Forms.TextBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout
        CType(Me.DGVDetalle,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox2.SuspendLayout
        Me.SuspendLayout
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmdGenerar)
        Me.GroupBox1.Controls.Add(Me.DGVDetalle)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.MetroLabel12)
        Me.GroupBox1.Controls.Add(Me.MetroLabel11)
        Me.GroupBox1.Controls.Add(Me.MetroLabel2)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Controls.Add(Me.txtIVA_N)
        Me.GroupBox1.Controls.Add(Me.txtSubTotal_N)
        Me.GroupBox1.Controls.Add(Me.TxtTotal_N)
        Me.GroupBox1.Controls.Add(Me.TxtPedido)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1316, 689)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = false
        '
        'CmdGenerar
        '
        Me.CmdGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CmdGenerar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.CmdGenerar.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.export_16px
        Me.CmdGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdGenerar.Location = New System.Drawing.Point(609, 624)
        Me.CmdGenerar.Name = "CmdGenerar"
        Me.CmdGenerar.Size = New System.Drawing.Size(99, 28)
        Me.CmdGenerar.TabIndex = 91
        Me.CmdGenerar.Text = "Generar"
        Me.CmdGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdGenerar.UseVisualStyleBackColor = true
        '
        'DGVDetalle
        '
        Me.DGVDetalle.AllowUserToAddRows = false
        Me.DGVDetalle.AllowUserToResizeRows = false
        Me.DGVDetalle.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.DGVDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DGVDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVDetalle.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVDetalle.EnableHeadersVisualStyles = false
        Me.DGVDetalle.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DGVDetalle.GridColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.DGVDetalle.Location = New System.Drawing.Point(8, 191)
        Me.DGVDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVDetalle.Name = "DGVDetalle"
        Me.DGVDetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVDetalle.RowHeadersWidth = 51
        Me.DGVDetalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGVDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVDetalle.Size = New System.Drawing.Size(1292, 396)
        Me.DGVDetalle.TabIndex = 64
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.close_window_16px
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(1206, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 28)
        Me.Button2.TabIndex = 90
        Me.Button2.Text = "Salir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = true
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = true
        Me.MetroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel12.Location = New System.Drawing.Point(425, 594)
        Me.MetroLabel12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(94, 20)
        Me.MetroLabel12.TabIndex = 61
        Me.MetroLabel12.Text = "Nuevo Total"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = true
        Me.MetroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel11.Location = New System.Drawing.Point(225, 594)
        Me.MetroLabel11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(84, 20)
        Me.MetroLabel11.TabIndex = 60
        Me.MetroLabel11.Text = "Nuevo IVA"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = true
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.Location = New System.Drawing.Point(21, 594)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(118, 20)
        Me.MetroLabel2.TabIndex = 59
        Me.MetroLabel2.Text = "Nuevo Subtotal"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = true
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(8, 20)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(80, 20)
        Me.MetroLabel1.TabIndex = 58
        Me.MetroLabel1.Text = "No. Ticket"
        '
        'txtIVA_N
        '
        Me.txtIVA_N.Enabled = false
        Me.txtIVA_N.Location = New System.Drawing.Point(225, 622)
        Me.txtIVA_N.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIVA_N.Name = "txtIVA_N"
        Me.txtIVA_N.Size = New System.Drawing.Size(177, 30)
        Me.txtIVA_N.TabIndex = 42
        Me.txtIVA_N.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal_N
        '
        Me.txtSubTotal_N.Enabled = false
        Me.txtSubTotal_N.Location = New System.Drawing.Point(21, 622)
        Me.txtSubTotal_N.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubTotal_N.Name = "txtSubTotal_N"
        Me.txtSubTotal_N.Size = New System.Drawing.Size(177, 30)
        Me.txtSubTotal_N.TabIndex = 40
        Me.txtSubTotal_N.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTotal_N
        '
        Me.TxtTotal_N.Enabled = false
        Me.TxtTotal_N.Location = New System.Drawing.Point(425, 622)
        Me.TxtTotal_N.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotal_N.Name = "TxtTotal_N"
        Me.TxtTotal_N.Size = New System.Drawing.Size(177, 30)
        Me.TxtTotal_N.TabIndex = 9
        Me.TxtTotal_N.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtPedido
        '
        Me.TxtPedido.Location = New System.Drawing.Point(127, 18)
        Me.TxtPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPedido.Name = "TxtPedido"
        Me.TxtPedido.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPedido.Size = New System.Drawing.Size(132, 30)
        Me.TxtPedido.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DTPFecha)
        Me.GroupBox2.Controls.Add(Me.txtSubTotal_C)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.MetroLabel9)
        Me.GroupBox2.Controls.Add(Me.txtIVA_C)
        Me.GroupBox2.Controls.Add(Me.MetroLabel8)
        Me.GroupBox2.Controls.Add(Me.TxtNombre_C)
        Me.GroupBox2.Controls.Add(Me.MetroLabel7)
        Me.GroupBox2.Controls.Add(Me.TxtStatus_C)
        Me.GroupBox2.Controls.Add(Me.TxtTipo_C)
        Me.GroupBox2.Controls.Add(Me.MetroLabel5)
        Me.GroupBox2.Controls.Add(Me.MetroLabel6)
        Me.GroupBox2.Controls.Add(Me.MetroLabel4)
        Me.GroupBox2.Controls.Add(Me.txtTotal_C)
        Me.GroupBox2.Controls.Add(Me.MetroLabel3)
        Me.GroupBox2.Controls.Add(Me.TxtPedido_C)
        Me.GroupBox2.Controls.Add(Me.MetroLabel10)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 53)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1292, 130)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Cabecera"
        '
        'DTPFecha
        '
        Me.DTPFecha.CustomFormat = "dd/MM/yyyy"
        Me.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFecha.Location = New System.Drawing.Point(360, 31)
        Me.DTPFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.DTPFecha.MinimumSize = New System.Drawing.Size(0, 30)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(147, 30)
        Me.DTPFecha.TabIndex = 68
        '
        'txtSubTotal_C
        '
        Me.txtSubTotal_C.Enabled = false
        Me.txtSubTotal_C.Location = New System.Drawing.Point(1151, 16)
        Me.txtSubTotal_C.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubTotal_C.Name = "txtSubTotal_C"
        Me.txtSubTotal_C.Size = New System.Drawing.Size(132, 30)
        Me.txtSubTotal_C.TabIndex = 18
        Me.txtSubTotal_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Label9.Location = New System.Drawing.Point(768, 85)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 20)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Label9"
        Me.Label9.Visible = false
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = true
        Me.MetroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel9.Location = New System.Drawing.Point(1087, 95)
        Me.MetroLabel9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(44, 20)
        Me.MetroLabel9.TabIndex = 67
        Me.MetroLabel9.Text = "Total"
        '
        'txtIVA_C
        '
        Me.txtIVA_C.Enabled = false
        Me.txtIVA_C.Location = New System.Drawing.Point(1151, 54)
        Me.txtIVA_C.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIVA_C.Name = "txtIVA_C"
        Me.txtIVA_C.Size = New System.Drawing.Size(132, 30)
        Me.txtIVA_C.TabIndex = 16
        Me.txtIVA_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = true
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel8.Location = New System.Drawing.Point(1101, 59)
        Me.MetroLabel8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(34, 20)
        Me.MetroLabel8.TabIndex = 66
        Me.MetroLabel8.Text = "IVA"
        '
        'TxtNombre_C
        '
        Me.TxtNombre_C.Enabled = false
        Me.TxtNombre_C.Location = New System.Drawing.Point(117, 81)
        Me.TxtNombre_C.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNombre_C.Name = "TxtNombre_C"
        Me.TxtNombre_C.Size = New System.Drawing.Size(641, 30)
        Me.TxtNombre_C.TabIndex = 13
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = true
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel7.Location = New System.Drawing.Point(1056, 22)
        Me.MetroLabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(68, 20)
        Me.MetroLabel7.TabIndex = 65
        Me.MetroLabel7.Text = "Subtotal"
        '
        'TxtStatus_C
        '
        Me.TxtStatus_C.Enabled = false
        Me.TxtStatus_C.Location = New System.Drawing.Point(837, 32)
        Me.TxtStatus_C.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStatus_C.Name = "TxtStatus_C"
        Me.TxtStatus_C.Size = New System.Drawing.Size(147, 30)
        Me.TxtStatus_C.TabIndex = 11
        Me.TxtStatus_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtTipo_C
        '
        Me.TxtTipo_C.Enabled = false
        Me.TxtTipo_C.Location = New System.Drawing.Point(611, 32)
        Me.TxtTipo_C.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTipo_C.Name = "TxtTipo_C"
        Me.TxtTipo_C.Size = New System.Drawing.Size(132, 30)
        Me.TxtTipo_C.TabIndex = 9
        Me.TxtTipo_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = true
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel5.Location = New System.Drawing.Point(764, 36)
        Me.MetroLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(53, 20)
        Me.MetroLabel5.TabIndex = 62
        Me.MetroLabel5.Text = "Status"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = true
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel6.Location = New System.Drawing.Point(13, 85)
        Me.MetroLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(78, 20)
        Me.MetroLabel6.TabIndex = 64
        Me.MetroLabel6.Text = "Vendido a"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = true
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel4.Location = New System.Drawing.Point(516, 36)
        Me.MetroLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(68, 20)
        Me.MetroLabel4.TabIndex = 61
        Me.MetroLabel4.Text = "Tipo Vta"
        '
        'txtTotal_C
        '
        Me.txtTotal_C.Enabled = false
        Me.txtTotal_C.Location = New System.Drawing.Point(1151, 91)
        Me.txtTotal_C.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotal_C.Name = "txtTotal_C"
        Me.txtTotal_C.Size = New System.Drawing.Size(132, 30)
        Me.txtTotal_C.TabIndex = 7
        Me.txtTotal_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = true
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel3.Location = New System.Drawing.Point(293, 36)
        Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(49, 20)
        Me.MetroLabel3.TabIndex = 60
        Me.MetroLabel3.Text = "Fecha"
        '
        'TxtPedido_C
        '
        Me.TxtPedido_C.Enabled = false
        Me.TxtPedido_C.Location = New System.Drawing.Point(131, 32)
        Me.TxtPedido_C.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPedido_C.Name = "TxtPedido_C"
        Me.TxtPedido_C.Size = New System.Drawing.Size(132, 30)
        Me.TxtPedido_C.TabIndex = 3
        Me.TxtPedido_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = true
        Me.MetroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel10.Location = New System.Drawing.Point(13, 36)
        Me.MetroLabel10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(80, 20)
        Me.MetroLabel10.TabIndex = 59
        Me.MetroLabel10.Text = "No. Ticket"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'FrmDevTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(1343, 795)
        Me.ControlBox = false
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = true
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = false
        Me.Name = "FrmDevTickets"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Text = "Devolución de Tickets"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.DGVDetalle,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtPedido As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtPedido_C As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal_C As System.Windows.Forms.TextBox
    Friend WithEvents TxtTipo_C As System.Windows.Forms.TextBox
    Friend WithEvents TxtStatus_C As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre_C As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotal_N As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtSubTotal_C As TextBox
    Friend WithEvents txtIVA_C As TextBox
    Friend WithEvents txtIVA_N As TextBox
    Friend WithEvents txtSubTotal_N As TextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents DGVDetalle As MetroFramework.Controls.MetroGrid
    Friend WithEvents DTPFecha As MetroFramework.Controls.MetroDateTime
    Friend WithEvents CmdGenerar As Button
    Friend WithEvents Button2 As Button
End Class
