<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHistoProveedores
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmdLimpiar = New System.Windows.Forms.Button()
        Me.CmdProveedor = New System.Windows.Forms.Button()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CmdSalir = New System.Windows.Forms.Button()
        Me.CmdVerVenta = New System.Windows.Forms.Button()
        Me.lblelejir = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmdLimpiar)
        Me.GroupBox1.Controls.Add(Me.CmdProveedor)
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.CmdSalir)
        Me.GroupBox1.Controls.Add(Me.CmdVerVenta)
        Me.GroupBox1.Controls.Add(Me.lblelejir)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtFechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtFechaInicial)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, -3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(868, 458)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'CmdLimpiar
        '
        Me.CmdLimpiar.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.page
        Me.CmdLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdLimpiar.Location = New System.Drawing.Point(743, 58)
        Me.CmdLimpiar.Name = "CmdLimpiar"
        Me.CmdLimpiar.Size = New System.Drawing.Size(119, 34)
        Me.CmdLimpiar.TabIndex = 33
        Me.CmdLimpiar.Text = "F3 Limpar"
        Me.CmdLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdLimpiar.UseVisualStyleBackColor = True
        '
        'CmdProveedor
        '
        Me.CmdProveedor.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.page_find
        Me.CmdProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdProveedor.Location = New System.Drawing.Point(528, 58)
        Me.CmdProveedor.Name = "CmdProveedor"
        Me.CmdProveedor.Size = New System.Drawing.Size(113, 34)
        Me.CmdProveedor.TabIndex = 32
        Me.CmdProveedor.Text = "F2 Buscar"
        Me.CmdProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdProveedor.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(136, 65)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(371, 22)
        Me.txtCliente.TabIndex = 31
        Me.txtCliente.Text = "RAZON SOCIAL"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(699, 410)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 32)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "0.00"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(525, 410)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 32)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Total de Ventas $"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(6, 95)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(856, 312)
        Me.DataGridView1.TabIndex = 26
        '
        'CmdSalir
        '
        Me.CmdSalir.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources._stop
        Me.CmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdSalir.Location = New System.Drawing.Point(743, 15)
        Me.CmdSalir.Name = "CmdSalir"
        Me.CmdSalir.Size = New System.Drawing.Size(119, 37)
        Me.CmdSalir.TabIndex = 22
        Me.CmdSalir.Text = "ESC Salir"
        Me.CmdSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdSalir.UseVisualStyleBackColor = True
        '
        'CmdVerVenta
        '
        Me.CmdVerVenta.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.book_next
        Me.CmdVerVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdVerVenta.Location = New System.Drawing.Point(528, 15)
        Me.CmdVerVenta.Name = "CmdVerVenta"
        Me.CmdVerVenta.Size = New System.Drawing.Size(113, 37)
        Me.CmdVerVenta.TabIndex = 21
        Me.CmdVerVenta.Text = "F9 Generar"
        Me.CmdVerVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdVerVenta.UseVisualStyleBackColor = True
        '
        'lblelejir
        '
        Me.lblelejir.AutoSize = True
        Me.lblelejir.Location = New System.Drawing.Point(17, 68)
        Me.lblelejir.Name = "lblelejir"
        Me.lblelejir.Size = New System.Drawing.Size(121, 16)
        Me.lblelejir.TabIndex = 19
        Me.lblelejir.Text = "Elejir Proveedor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Fecha Inicio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(231, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Fecha Final"
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFinal.Location = New System.Drawing.Point(326, 24)
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Size = New System.Drawing.Size(112, 22)
        Me.dtFechaFinal.TabIndex = 16
        '
        'dtFechaInicial
        '
        Me.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaInicial.Location = New System.Drawing.Point(111, 25)
        Me.dtFechaInicial.Name = "dtFechaInicial"
        Me.dtFechaInicial.Size = New System.Drawing.Size(114, 22)
        Me.dtFechaInicial.TabIndex = 15
        '
        'FrmHistoProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 452)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "FrmHistoProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial Proveedores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CmdSalir As System.Windows.Forms.Button
    Friend WithEvents CmdVerVenta As System.Windows.Forms.Button
    Friend WithEvents lblelejir As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmdProveedor As System.Windows.Forms.Button
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents CmdLimpiar As System.Windows.Forms.Button
End Class
