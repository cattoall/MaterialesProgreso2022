<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGenerarAbono
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
        Me.LblVenta = New System.Windows.Forms.Label()
        Me.Lblobserbaciones = New System.Windows.Forms.Label()
        Me.LblTotall = New System.Windows.Forms.Label()
        Me.txtventa = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtobservaciones = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblresto = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblAbonar = New System.Windows.Forms.Label()
        Me.RbnParcial = New System.Windows.Forms.RadioButton()
        Me.RbnTotal = New System.Windows.Forms.RadioButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.SuspendLayout
        '
        'LblVenta
        '
        Me.LblVenta.AutoSize = true
        Me.LblVenta.BackColor = System.Drawing.Color.Transparent
        Me.LblVenta.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold)
        Me.LblVenta.Location = New System.Drawing.Point(401, 38)
        Me.LblVenta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblVenta.Name = "LblVenta"
        Me.LblVenta.Size = New System.Drawing.Size(93, 23)
        Me.LblVenta.TabIndex = 0
        Me.LblVenta.Text = "N° Venta:"
        '
        'Lblobserbaciones
        '
        Me.Lblobserbaciones.AutoSize = true
        Me.Lblobserbaciones.BackColor = System.Drawing.Color.Transparent
        Me.Lblobserbaciones.Location = New System.Drawing.Point(15, 148)
        Me.Lblobserbaciones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblobserbaciones.Name = "Lblobserbaciones"
        Me.Lblobserbaciones.Size = New System.Drawing.Size(134, 23)
        Me.Lblobserbaciones.TabIndex = 2
        Me.Lblobserbaciones.Text = "Observaciones"
        '
        'LblTotall
        '
        Me.LblTotall.AutoSize = true
        Me.LblTotall.BackColor = System.Drawing.Color.Transparent
        Me.LblTotall.Location = New System.Drawing.Point(223, 65)
        Me.LblTotall.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTotall.Name = "LblTotall"
        Me.LblTotall.Size = New System.Drawing.Size(91, 23)
        Me.LblTotall.TabIndex = 3
        Me.LblTotall.Text = "Abono:  $"
        '
        'txtventa
        '
        Me.txtventa.Enabled = false
        Me.txtventa.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold)
        Me.txtventa.Location = New System.Drawing.Point(407, 65)
        Me.txtventa.Margin = New System.Windows.Forms.Padding(4)
        Me.txtventa.Name = "txtventa"
        Me.txtventa.Size = New System.Drawing.Size(149, 30)
        Me.txtventa.TabIndex = 4
        Me.txtventa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(328, 65)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(149, 30)
        Me.txttotal.TabIndex = 5
        Me.txttotal.Text = "0.00"
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtobservaciones
        '
        Me.txtobservaciones.Location = New System.Drawing.Point(15, 175)
        Me.txtobservaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.txtobservaciones.Multiline = true
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Size = New System.Drawing.Size(581, 72)
        Me.txtobservaciones.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblresto)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(565, 37)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(223, 68)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Deuda de la Venta"
        '
        'lblresto
        '
        Me.lblresto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblresto.Location = New System.Drawing.Point(8, 28)
        Me.lblresto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblresto.Name = "lblresto"
        Me.lblresto.Size = New System.Drawing.Size(203, 28)
        Me.lblresto.TabIndex = 0
        Me.lblresto.Text = "0"
        Me.lblresto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.lblAbonar)
        Me.GroupBox2.Controls.Add(Me.RbnParcial)
        Me.GroupBox2.Controls.Add(Me.RbnTotal)
        Me.GroupBox2.Controls.Add(Me.txttotal)
        Me.GroupBox2.Controls.Add(Me.Lblobserbaciones)
        Me.GroupBox2.Controls.Add(Me.LblTotall)
        Me.GroupBox2.Controls.Add(Me.txtobservaciones)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(19, 112)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(769, 263)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = false
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.close_window_16px
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(603, 219)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 28)
        Me.Button2.TabIndex = 85
        Me.Button2.Text = "Salir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = true
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnAdd.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.coin_in_hand_32px
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.Location = New System.Drawing.Point(328, 140)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(151, 28)
        Me.btnAdd.TabIndex = 84
        Me.btnAdd.Text = "Realizar Cobro"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.UseVisualStyleBackColor = true
        '
        'lblAbonar
        '
        Me.lblAbonar.AutoSize = true
        Me.lblAbonar.BackColor = System.Drawing.Color.Transparent
        Me.lblAbonar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAbonar.Location = New System.Drawing.Point(465, 206)
        Me.lblAbonar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAbonar.Name = "lblAbonar"
        Me.lblAbonar.Size = New System.Drawing.Size(72, 23)
        Me.lblAbonar.TabIndex = 39
        Me.lblAbonar.Text = "Abonar"
        '
        'RbnParcial
        '
        Me.RbnParcial.AutoSize = true
        Me.RbnParcial.BackColor = System.Drawing.Color.Transparent
        Me.RbnParcial.Location = New System.Drawing.Point(15, 63)
        Me.RbnParcial.Margin = New System.Windows.Forms.Padding(4)
        Me.RbnParcial.Name = "RbnParcial"
        Me.RbnParcial.Size = New System.Drawing.Size(149, 27)
        Me.RbnParcial.TabIndex = 13
        Me.RbnParcial.Text = "Abono Parcial"
        Me.RbnParcial.UseVisualStyleBackColor = false
        '
        'RbnTotal
        '
        Me.RbnTotal.AutoSize = true
        Me.RbnTotal.BackColor = System.Drawing.Color.Transparent
        Me.RbnTotal.Checked = true
        Me.RbnTotal.Location = New System.Drawing.Point(15, 22)
        Me.RbnTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.RbnTotal.Name = "RbnTotal"
        Me.RbnTotal.Size = New System.Drawing.Size(133, 27)
        Me.RbnTotal.TabIndex = 12
        Me.RbnTotal.TabStop = true
        Me.RbnTotal.Text = "Abono Total"
        Me.RbnTotal.UseVisualStyleBackColor = false
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'FrmGenerarAbono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(801, 389)
        Me.ControlBox = false
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtventa)
        Me.Controls.Add(Me.LblVenta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = true
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = false
        Me.Name = "FrmGenerarAbono"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Text = "Datos del Abono"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents LblVenta As System.Windows.Forms.Label
    Friend WithEvents Lblobserbaciones As System.Windows.Forms.Label
    Friend WithEvents LblTotall As System.Windows.Forms.Label
    Friend WithEvents txtventa As System.Windows.Forms.TextBox
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents txtobservaciones As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblresto As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RbnParcial As System.Windows.Forms.RadioButton
    Friend WithEvents RbnTotal As System.Windows.Forms.RadioButton
    Friend WithEvents lblAbonar As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button2 As Button
    Friend WithEvents btnAdd As Button
End Class
