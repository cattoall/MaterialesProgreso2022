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
    <System.Diagnostics.DebuggerStepThrough()>
    <Obsolete>
    Private Sub InitializeComponent()
        Me.txtPorcentaje = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnAplicar = New MetroFramework.Controls.MetroButton()
        Me.btnSalir = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txtPorcentaje
        '
        '
        '
        '
        Me.txtPorcentaje.CustomButton.Image = Nothing
        Me.txtPorcentaje.CustomButton.Location = New System.Drawing.Point(97, 1)
        Me.txtPorcentaje.CustomButton.Name = ""
        Me.txtPorcentaje.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPorcentaje.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPorcentaje.CustomButton.TabIndex = 1
        Me.txtPorcentaje.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPorcentaje.CustomButton.UseSelectable = True
        Me.txtPorcentaje.CustomButton.Visible = False
        Me.txtPorcentaje.Lines = New String(-1) {}
        Me.txtPorcentaje.Location = New System.Drawing.Point(61, 80)
        Me.txtPorcentaje.MaxLength = 2
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPorcentaje.PromptText = "Del 0 al 30%"
        Me.txtPorcentaje.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPorcentaje.SelectedText = ""
        Me.txtPorcentaje.SelectionLength = 0
        Me.txtPorcentaje.SelectionStart = 0
        Me.txtPorcentaje.ShortcutsEnabled = True
        Me.txtPorcentaje.Size = New System.Drawing.Size(119, 23)
        Me.txtPorcentaje.TabIndex = 33
        Me.txtPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPorcentaje.UseSelectable = True
        Me.txtPorcentaje.WaterMark = "Del 0 al 30%"
        Me.txtPorcentaje.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPorcentaje.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(176, 80)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(20, 19)
        Me.MetroLabel1.TabIndex = 32
        Me.MetroLabel1.Text = "%"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAplicar
        '
        Me.btnAplicar.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnAplicar.Location = New System.Drawing.Point(170, 138)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(64, 30)
        Me.btnAplicar.TabIndex = 34
        Me.btnAplicar.Text = "Aplicar"
        Me.btnAplicar.UseSelectable = True
        '
        'btnSalir
        '
        Me.btnSalir.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnSalir.Location = New System.Drawing.Point(23, 138)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(64, 30)
        Me.btnSalir.TabIndex = 35
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseSelectable = True
        '
        'FrmDescuentoGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 181)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.txtPorcentaje)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "FrmDescuentoGeneral"
        Me.Text = "Descuento General"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPorcentaje As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnAplicar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSalir As MetroFramework.Controls.MetroButton
End Class
