<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCancelarPedido
    'Inherits System.Windows.Forms.Form
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.CmbCancelarPedido = New MetroFramework.Controls.MetroComboBox()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.btnSalir = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(152, 72)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(192, 25)
        Me.MetroLabel1.TabIndex = 29
        Me.MetroLabel1.Text = "Motivo de Cancelación"
        '
        'CmbCancelarPedido
        '
        Me.CmbCancelarPedido.FormattingEnabled = True
        Me.CmbCancelarPedido.ItemHeight = 23
        Me.CmbCancelarPedido.Items.AddRange(New Object() {"CLIENTE ERRONEO", "DEVOLUCION", "ERROR EN PRECIO", "OTRO MOTIVO"})
        Me.CmbCancelarPedido.Location = New System.Drawing.Point(152, 112)
        Me.CmbCancelarPedido.Name = "CmbCancelarPedido"
        Me.CmbCancelarPedido.Size = New System.Drawing.Size(192, 29)
        Me.CmbCancelarPedido.TabIndex = 30
        Me.CmbCancelarPedido.UseSelectable = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(269, 161)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 31
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseSelectable = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(152, 161)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 32
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseSelectable = True
        '
        'FrmCancelarPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(488, 207)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.CmbCancelarPedido)
        Me.Controls.Add(Me.MetroLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmCancelarPedido"
        Me.Text = "Cancelación De Facturas, Ventas y Pedidos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents CmbCancelarPedido As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSalir As MetroFramework.Controls.MetroButton
End Class
