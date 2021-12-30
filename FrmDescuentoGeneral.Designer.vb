<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDescuentoGeneral
    Inherits MetroFramework.Forms.MetroForm
    'Inherits System.Windows.Forms.Form

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
        Me.lblEsc = New MetroFramework.Controls.MetroLink()
        Me.mtbDesc = New MetroFramework.Controls.MetroTrackBar()
        Me.lblDesc = New MetroFramework.Controls.MetroLabel()
        Me.mlAplicar = New MetroFramework.Controls.MetroLink()
        Me.SuspendLayout()
        '
        'lblEsc
        '
        Me.lblEsc.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.lblEsc.ForeColor = System.Drawing.Color.Black
        Me.lblEsc.Location = New System.Drawing.Point(32, 145)
        Me.lblEsc.Name = "lblEsc"
        Me.lblEsc.Size = New System.Drawing.Size(63, 23)
        Me.lblEsc.TabIndex = 26
        Me.lblEsc.Text = "Salir"
        Me.lblEsc.UseCustomForeColor = True
        Me.lblEsc.UseSelectable = True
        '
        'mtbDesc
        '
        Me.mtbDesc.BackColor = System.Drawing.Color.Transparent
        Me.mtbDesc.Location = New System.Drawing.Point(32, 88)
        Me.mtbDesc.Maximum = 30
        Me.mtbDesc.Name = "mtbDesc"
        Me.mtbDesc.Size = New System.Drawing.Size(161, 23)
        Me.mtbDesc.TabIndex = 29
        Me.mtbDesc.Text = "MetroTrackBar1"
        Me.mtbDesc.Value = 0
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(203, 88)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(31, 19)
        Me.lblDesc.TabIndex = 30
        Me.lblDesc.Text = "0 %"
        Me.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mlAplicar
        '
        Me.mlAplicar.Location = New System.Drawing.Point(156, 145)
        Me.mlAplicar.Name = "mlAplicar"
        Me.mlAplicar.Size = New System.Drawing.Size(63, 23)
        Me.mlAplicar.TabIndex = 31
        Me.mlAplicar.Text = "Aplicar"
        Me.mlAplicar.UseCustomForeColor = True
        Me.mlAplicar.UseSelectable = True
        '
        'FrmDescuentoGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.lblEsc
        Me.ClientSize = New System.Drawing.Size(257, 181)
        Me.ControlBox = False
        Me.Controls.Add(Me.mlAplicar)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.mtbDesc)
        Me.Controls.Add(Me.lblEsc)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "FrmDescuentoGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Descuento General"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEsc As MetroFramework.Controls.MetroLink
    Friend WithEvents mtbDesc As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents lblDesc As MetroFramework.Controls.MetroLabel
    Friend WithEvents mlAplicar As MetroFramework.Controls.MetroLink
End Class
