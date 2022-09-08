<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCancelacion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CmbCancelarPedido = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CmbCancelarPedido
        '
        Me.CmbCancelarPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCancelarPedido.FormattingEnabled = True
        Me.CmbCancelarPedido.Items.AddRange(New Object() {"02 - Comprobante emitido con errores sin relación"})
        Me.CmbCancelarPedido.Location = New System.Drawing.Point(16, 48)
        Me.CmbCancelarPedido.Name = "CmbCancelarPedido"
        Me.CmbCancelarPedido.Size = New System.Drawing.Size(254, 21)
        Me.CmbCancelarPedido.TabIndex = 3
        Me.CmbCancelarPedido.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Especifique el Motivo de Cancelación"
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(12, 91)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(260, 31)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Continuar Cancelando..."
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmCancelacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 134)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbCancelarPedido)
        Me.Name = "frmCancelacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCancelacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbCancelarPedido As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelar As Button
End Class
