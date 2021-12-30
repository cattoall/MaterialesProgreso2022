<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDescuento
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
        Me.NupPrecio = New System.Windows.Forms.NumericUpDown()
        Me.NupCantidad = New System.Windows.Forms.NumericUpDown()
        Me.NupDescuento = New MetroFramework.Controls.MetroTrackBar()
        Me.lblDescripcion = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.lblSalir = New MetroFramework.Controls.MetroLink()
        Me.lblAplicar = New MetroFramework.Controls.MetroLink()
        Me.lblDesc = New MetroFramework.Controls.MetroLabel()
        CType(Me.NupPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NupCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NupPrecio
        '
        Me.NupPrecio.AccessibleDescription = ""
        Me.NupPrecio.DecimalPlaces = 2
        Me.NupPrecio.Increment = New Decimal(New Integer() {50, 0, 0, 131072})
        Me.NupPrecio.Location = New System.Drawing.Point(205, 140)
        Me.NupPrecio.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.NupPrecio.Name = "NupPrecio"
        Me.NupPrecio.Size = New System.Drawing.Size(135, 20)
        Me.NupPrecio.TabIndex = 1
        Me.NupPrecio.Tag = ""
        Me.NupPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NupCantidad
        '
        Me.NupCantidad.DecimalPlaces = 2
        Me.NupCantidad.Increment = New Decimal(New Integer() {50, 0, 0, 131072})
        Me.NupCantidad.Location = New System.Drawing.Point(205, 99)
        Me.NupCantidad.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.NupCantidad.Name = "NupCantidad"
        Me.NupCantidad.Size = New System.Drawing.Size(135, 20)
        Me.NupCantidad.TabIndex = 0
        Me.NupCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NupDescuento
        '
        Me.NupDescuento.BackColor = System.Drawing.Color.Transparent
        Me.NupDescuento.Location = New System.Drawing.Point(205, 181)
        Me.NupDescuento.Maximum = 30
        Me.NupDescuento.Name = "NupDescuento"
        Me.NupDescuento.Size = New System.Drawing.Size(104, 23)
        Me.NupDescuento.TabIndex = 22
        Me.NupDescuento.Value = 0
        '
        'lblDescripcion
        '
        Me.lblDescripcion.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblDescripcion.Location = New System.Drawing.Point(23, 60)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(389, 23)
        Me.lblDescripcion.TabIndex = 23
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(114, 99)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel1.TabIndex = 24
        Me.MetroLabel1.Text = "Cantidad:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.Location = New System.Drawing.Point(114, 140)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel2.TabIndex = 25
        Me.MetroLabel2.Text = "Precio:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel3.Location = New System.Drawing.Point(114, 181)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(82, 19)
        Me.MetroLabel3.TabIndex = 26
        Me.MetroLabel3.Text = "Descuento:"
        '
        'lblSalir
        '
        Me.lblSalir.Location = New System.Drawing.Point(23, 216)
        Me.lblSalir.Name = "lblSalir"
        Me.lblSalir.Size = New System.Drawing.Size(75, 23)
        Me.lblSalir.TabIndex = 27
        Me.lblSalir.Text = "Salir"
        Me.lblSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSalir.UseCustomForeColor = True
        Me.lblSalir.UseSelectable = True
        '
        'lblAplicar
        '
        Me.lblAplicar.Location = New System.Drawing.Point(337, 216)
        Me.lblAplicar.Name = "lblAplicar"
        Me.lblAplicar.Size = New System.Drawing.Size(75, 23)
        Me.lblAplicar.TabIndex = 28
        Me.lblAplicar.Text = "Aplicar"
        Me.lblAplicar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblAplicar.UseCustomForeColor = True
        Me.lblAplicar.UseSelectable = True
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(309, 181)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(31, 19)
        Me.lblDesc.TabIndex = 29
        Me.lblDesc.Text = "0 %"
        Me.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmDescuento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(441, 267)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblAplicar)
        Me.Controls.Add(Me.lblSalir)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.NupPrecio)
        Me.Controls.Add(Me.NupDescuento)
        Me.Controls.Add(Me.NupCantidad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmDescuento"
        Me.Text = "Descuento Individual"
        CType(Me.NupPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NupCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NupCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents NupPrecio As System.Windows.Forms.NumericUpDown
    Friend WithEvents NupDescuento As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents lblDescripcion As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblSalir As MetroFramework.Controls.MetroLink
    Friend WithEvents lblAplicar As MetroFramework.Controls.MetroLink
    Friend WithEvents lblDesc As MetroFramework.Controls.MetroLabel
End Class
