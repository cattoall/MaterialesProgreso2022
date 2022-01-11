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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGVDetalle = New MetroFramework.Controls.MetroGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtTotal_N = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
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
        Me.TxtTotal_C = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPedido_C = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.mBtnExit = New MetroFramework.Controls.MetroButton()
        Me.mBtnGenerate = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout
        CType(Me.DGVDetalle,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox2.SuspendLayout
        Me.SuspendLayout
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mBtnGenerate)
        Me.GroupBox1.Controls.Add(Me.mBtnExit)
        Me.GroupBox1.Controls.Add(Me.DGVDetalle)
        Me.GroupBox1.Controls.Add(Me.TxtTotal_N)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxtPedido)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 64)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1291, 654)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = false
        '
        'DGVDetalle
        '
        Me.DGVDetalle.AllowUserToAddRows = false
        Me.DGVDetalle.AllowUserToDeleteRows = false
        Me.DGVDetalle.AllowUserToResizeRows = false
        Me.DGVDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVDetalle.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.DGVDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DGVDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGVDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVDetalle.DefaultCellStyle = DataGridViewCellStyle8
        Me.DGVDetalle.EnableHeadersVisualStyles = false
        Me.DGVDetalle.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DGVDetalle.GridColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.DGVDetalle.Location = New System.Drawing.Point(7, 190)
        Me.DGVDetalle.Name = "DGVDetalle"
        Me.DGVDetalle.ReadOnly = true
        Me.DGVDetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DGVDetalle.RowHeadersWidth = 51
        Me.DGVDetalle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGVDetalle.RowTemplate.Height = 24
        Me.DGVDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVDetalle.Size = New System.Drawing.Size(1265, 367)
        Me.DGVDetalle.TabIndex = 76
        '
        'Column1
        '
        Me.Column1.HeaderText = "No. Factura"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = true
        Me.Column1.Width = 95
        '
        'Column2
        '
        Me.Column2.HeaderText = "ID Producto"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = true
        Me.Column2.Width = 97
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cantidad"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = true
        Me.Column3.Width = 82
        '
        'Column4
        '
        Me.Column4.HeaderText = "Descripción"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = true
        Me.Column4.Width = 96
        '
        'Column5
        '
        Me.Column5.HeaderText = "Precio"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = true
        Me.Column5.Width = 67
        '
        'TxtTotal_N
        '
        Me.TxtTotal_N.Enabled = false
        Me.TxtTotal_N.Location = New System.Drawing.Point(589, 569)
        Me.TxtTotal_N.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotal_N.Name = "TxtTotal_N"
        Me.TxtTotal_N.Size = New System.Drawing.Size(177, 30)
        Me.TxtTotal_N.TabIndex = 9
        Me.TxtTotal_N.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(465, 572)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 23)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Nuevo Total:"
        '
        'TxtPedido
        '
        Me.TxtPedido.Location = New System.Drawing.Point(116, 22)
        Me.TxtPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPedido.Name = "TxtPedido"
        Me.TxtPedido.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtPedido.Size = New System.Drawing.Size(132, 30)
        Me.TxtPedido.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(8, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Factura:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TxtNombre_C)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtStatus_C)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtTipo_C)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtTotal_C)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.DTPFecha)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtPedido_C)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 53)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1264, 130)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Cabecera"
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(768, 85)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 23)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Label9"
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
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(8, 85)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 23)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Vendido a:"
        '
        'TxtStatus_C
        '
        Me.TxtStatus_C.Enabled = false
        Me.TxtStatus_C.Location = New System.Drawing.Point(1113, 32)
        Me.TxtStatus_C.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStatus_C.Name = "TxtStatus_C"
        Me.TxtStatus_C.Size = New System.Drawing.Size(143, 30)
        Me.TxtStatus_C.TabIndex = 11
        Me.TxtStatus_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(1040, 36)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Status:"
        '
        'TxtTipo_C
        '
        Me.TxtTipo_C.Enabled = false
        Me.TxtTipo_C.Location = New System.Drawing.Point(888, 32)
        Me.TxtTipo_C.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTipo_C.Name = "TxtTipo_C"
        Me.TxtTipo_C.Size = New System.Drawing.Size(132, 30)
        Me.TxtTipo_C.TabIndex = 9
        Me.TxtTipo_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(793, 36)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 23)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tipo Vta:"
        '
        'TxtTotal_C
        '
        Me.TxtTotal_C.Enabled = false
        Me.TxtTotal_C.Location = New System.Drawing.Point(627, 32)
        Me.TxtTotal_C.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotal_C.Name = "TxtTotal_C"
        Me.TxtTotal_C.Size = New System.Drawing.Size(132, 30)
        Me.TxtTotal_C.TabIndex = 7
        Me.TxtTotal_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(561, 36)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total:"
        '
        'DTPFecha
        '
        Me.DTPFecha.CustomFormat = "dd/MM/yyyy"
        Me.DTPFecha.Enabled = false
        Me.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFecha.Location = New System.Drawing.Point(364, 32)
        Me.DTPFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(140, 30)
        Me.DTPFecha.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(288, 36)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha:"
        '
        'TxtPedido_C
        '
        Me.TxtPedido_C.Enabled = false
        Me.TxtPedido_C.Location = New System.Drawing.Point(116, 32)
        Me.TxtPedido_C.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPedido_C.Name = "TxtPedido_C"
        Me.TxtPedido_C.Size = New System.Drawing.Size(132, 30)
        Me.TxtPedido_C.TabIndex = 3
        Me.TxtPedido_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(8, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 23)
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
        'mBtnExit
        '
        Me.mBtnExit.Location = New System.Drawing.Point(1189, 29)
        Me.mBtnExit.Name = "mBtnExit"
        Me.mBtnExit.Size = New System.Drawing.Size(75, 23)
        Me.mBtnExit.TabIndex = 77
        Me.mBtnExit.Text = "Salir"
        Me.mBtnExit.UseSelectable = true
        '
        'mBtnGenerate
        '
        Me.mBtnGenerate.Location = New System.Drawing.Point(635, 624)
        Me.mBtnGenerate.Name = "mBtnGenerate"
        Me.mBtnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.mBtnGenerate.TabIndex = 78
        Me.mBtnGenerate.Text = "Generar"
        Me.mBtnGenerate.UseSelectable = true
        '
        'FrmNotaDeCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(1323, 777)
        Me.ControlBox = false
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = true
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = false
        Me.Name = "FrmNotaDeCredito"
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
    Friend WithEvents DTPFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTipo_C As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtStatus_C As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre_C As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtTotal_N As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DGVDetalle As MetroFramework.Controls.MetroGrid
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents mBtnGenerate As MetroFramework.Controls.MetroButton
    Friend WithEvents mBtnExit As MetroFramework.Controls.MetroButton
End Class
