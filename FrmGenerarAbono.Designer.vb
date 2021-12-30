<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGenerarAbono
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
        Me.LblVenta = New System.Windows.Forms.Label()
        Me.Lblobserbaciones = New System.Windows.Forms.Label()
        Me.LblTotall = New System.Windows.Forms.Label()
        Me.txtventa = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtobservaciones = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblresto = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblAbonar = New System.Windows.Forms.Label()
        Me.ImgAbonarB = New System.Windows.Forms.PictureBox()
        Me.ImgAbonarA = New System.Windows.Forms.PictureBox()
        Me.ImgSalirB = New System.Windows.Forms.PictureBox()
        Me.ImgSalirA = New System.Windows.Forms.PictureBox()
        Me.RbnParcial = New System.Windows.Forms.RadioButton()
        Me.RbnTotal = New System.Windows.Forms.RadioButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ImgAbonarB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgAbonarA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSalirB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSalirA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblVenta
        '
        Me.LblVenta.AutoSize = True
        Me.LblVenta.BackColor = System.Drawing.Color.Transparent
        Me.LblVenta.Location = New System.Drawing.Point(165, 21)
        Me.LblVenta.Name = "LblVenta"
        Me.LblVenta.Size = New System.Drawing.Size(75, 19)
        Me.LblVenta.TabIndex = 0
        Me.LblVenta.Text = "N° Venta:"
        '
        'Lblobserbaciones
        '
        Me.Lblobserbaciones.AutoSize = True
        Me.Lblobserbaciones.BackColor = System.Drawing.Color.Transparent
        Me.Lblobserbaciones.Location = New System.Drawing.Point(11, 111)
        Me.Lblobserbaciones.Name = "Lblobserbaciones"
        Me.Lblobserbaciones.Size = New System.Drawing.Size(108, 19)
        Me.Lblobserbaciones.TabIndex = 2
        Me.Lblobserbaciones.Text = "Observaciones"
        '
        'LblTotall
        '
        Me.LblTotall.AutoSize = True
        Me.LblTotall.BackColor = System.Drawing.Color.Transparent
        Me.LblTotall.Location = New System.Drawing.Point(167, 53)
        Me.LblTotall.Name = "LblTotall"
        Me.LblTotall.Size = New System.Drawing.Size(73, 19)
        Me.LblTotall.TabIndex = 3
        Me.LblTotall.Text = "Abono:  $"
        '
        'txtventa
        '
        Me.txtventa.Location = New System.Drawing.Point(246, 18)
        Me.txtventa.Name = "txtventa"
        Me.txtventa.Size = New System.Drawing.Size(113, 26)
        Me.txtventa.TabIndex = 4
        Me.txtventa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(246, 53)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(113, 26)
        Me.txttotal.TabIndex = 5
        Me.txttotal.Text = "0.00"
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtobservaciones
        '
        Me.txtobservaciones.Location = New System.Drawing.Point(11, 142)
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Size = New System.Drawing.Size(280, 59)
        Me.txtobservaciones.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLoginSinRaya
        Me.GroupBox1.Controls.Add(Me.lblresto)
        Me.GroupBox1.Location = New System.Drawing.Point(390, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(167, 55)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Deuda de la Venta"
        '
        'lblresto
        '
        Me.lblresto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblresto.Location = New System.Drawing.Point(6, 23)
        Me.lblresto.Name = "lblresto"
        Me.lblresto.Size = New System.Drawing.Size(152, 23)
        Me.lblresto.TabIndex = 0
        Me.lblresto.Text = "0"
        Me.lblresto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLoginSinRaya
        Me.GroupBox2.Controls.Add(Me.lblAbonar)
        Me.GroupBox2.Controls.Add(Me.ImgAbonarB)
        Me.GroupBox2.Controls.Add(Me.ImgAbonarA)
        Me.GroupBox2.Controls.Add(Me.ImgSalirB)
        Me.GroupBox2.Controls.Add(Me.ImgSalirA)
        Me.GroupBox2.Controls.Add(Me.RbnParcial)
        Me.GroupBox2.Controls.Add(Me.RbnTotal)
        Me.GroupBox2.Controls.Add(Me.txttotal)
        Me.GroupBox2.Controls.Add(Me.LblVenta)
        Me.GroupBox2.Controls.Add(Me.Lblobserbaciones)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.LblTotall)
        Me.GroupBox2.Controls.Add(Me.txtobservaciones)
        Me.GroupBox2.Controls.Add(Me.txtventa)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(577, 214)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'lblAbonar
        '
        Me.lblAbonar.AutoSize = True
        Me.lblAbonar.BackColor = System.Drawing.Color.Transparent
        Me.lblAbonar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAbonar.Location = New System.Drawing.Point(349, 167)
        Me.lblAbonar.Name = "lblAbonar"
        Me.lblAbonar.Size = New System.Drawing.Size(58, 19)
        Me.lblAbonar.TabIndex = 39
        Me.lblAbonar.Text = "Abonar"
        '
        'ImgAbonarB
        '
        Me.ImgAbonarB.BackColor = System.Drawing.Color.Transparent
        Me.ImgAbonarB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgAbonarB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Bonar
        Me.ImgAbonarB.Location = New System.Drawing.Point(348, 105)
        Me.ImgAbonarB.Name = "ImgAbonarB"
        Me.ImgAbonarB.Size = New System.Drawing.Size(59, 62)
        Me.ImgAbonarB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgAbonarB.TabIndex = 38
        Me.ImgAbonarB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgAbonarB, "Abonar")
        Me.ImgAbonarB.Visible = False
        '
        'ImgAbonarA
        '
        Me.ImgAbonarA.BackColor = System.Drawing.Color.Transparent
        Me.ImgAbonarA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.Bonar
        Me.ImgAbonarA.Location = New System.Drawing.Point(351, 110)
        Me.ImgAbonarA.Name = "ImgAbonarA"
        Me.ImgAbonarA.Size = New System.Drawing.Size(52, 53)
        Me.ImgAbonarA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgAbonarA.TabIndex = 37
        Me.ImgAbonarA.TabStop = False
        '
        'ImgSalirB
        '
        Me.ImgSalirB.BackColor = System.Drawing.Color.Transparent
        Me.ImgSalirB.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ImgSalirB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgSalirB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.btn_salir
        Me.ImgSalirB.Location = New System.Drawing.Point(454, 166)
        Me.ImgSalirB.Name = "ImgSalirB"
        Me.ImgSalirB.Size = New System.Drawing.Size(94, 35)
        Me.ImgSalirB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSalirB.TabIndex = 36
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
        Me.ImgSalirA.Location = New System.Drawing.Point(457, 167)
        Me.ImgSalirA.Name = "ImgSalirA"
        Me.ImgSalirA.Size = New System.Drawing.Size(88, 31)
        Me.ImgSalirA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSalirA.TabIndex = 35
        Me.ImgSalirA.TabStop = False
        '
        'RbnParcial
        '
        Me.RbnParcial.AutoSize = True
        Me.RbnParcial.BackColor = System.Drawing.Color.Transparent
        Me.RbnParcial.Location = New System.Drawing.Point(11, 44)
        Me.RbnParcial.Name = "RbnParcial"
        Me.RbnParcial.Size = New System.Drawing.Size(120, 23)
        Me.RbnParcial.TabIndex = 13
        Me.RbnParcial.Text = "Abono Parcial"
        Me.RbnParcial.UseVisualStyleBackColor = False
        '
        'RbnTotal
        '
        Me.RbnTotal.AutoSize = True
        Me.RbnTotal.BackColor = System.Drawing.Color.Transparent
        Me.RbnTotal.Checked = True
        Me.RbnTotal.Location = New System.Drawing.Point(11, 18)
        Me.RbnTotal.Name = "RbnTotal"
        Me.RbnTotal.Size = New System.Drawing.Size(108, 23)
        Me.RbnTotal.TabIndex = 12
        Me.RbnTotal.TabStop = True
        Me.RbnTotal.Text = "Abono Total"
        Me.RbnTotal.UseVisualStyleBackColor = False
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(601, 238)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmGenerarAbono"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos del Abono"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ImgAbonarB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgAbonarA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSalirB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSalirA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents ImgSalirB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgSalirA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgAbonarA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgAbonarB As System.Windows.Forms.PictureBox
    Friend WithEvents lblAbonar As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
