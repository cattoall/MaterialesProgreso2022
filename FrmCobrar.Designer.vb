<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCobrar
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
        Me.lblmontoventa = New MetroFramework.Controls.MetroTextBox()
        Me.lblcambio = New MetroFramework.Controls.MetroTextBox()
        Me.txtPago = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.btnSalir = New MetroFramework.Controls.MetroLink()
        Me.btnPagar = New MetroFramework.Controls.MetroLink()
        Me.SuspendLayout()
        '
        'lblmontoventa
        '
        Me.lblmontoventa.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.lblmontoventa.CustomButton.Image = Nothing
        Me.lblmontoventa.CustomButton.Location = New System.Drawing.Point(115, 1)
        Me.lblmontoventa.CustomButton.Name = ""
        Me.lblmontoventa.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.lblmontoventa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.lblmontoventa.CustomButton.TabIndex = 1
        Me.lblmontoventa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.lblmontoventa.CustomButton.UseSelectable = True
        Me.lblmontoventa.CustomButton.Visible = False
        Me.lblmontoventa.Enabled = False
        Me.lblmontoventa.Lines = New String(-1) {}
        Me.lblmontoventa.Location = New System.Drawing.Point(129, 81)
        Me.lblmontoventa.MaxLength = 32767
        Me.lblmontoventa.Name = "lblmontoventa"
        Me.lblmontoventa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblmontoventa.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.lblmontoventa.SelectedText = ""
        Me.lblmontoventa.SelectionLength = 0
        Me.lblmontoventa.SelectionStart = 0
        Me.lblmontoventa.ShortcutsEnabled = True
        Me.lblmontoventa.Size = New System.Drawing.Size(137, 23)
        Me.lblmontoventa.TabIndex = 37
        Me.lblmontoventa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lblmontoventa.UseCustomBackColor = True
        Me.lblmontoventa.UseSelectable = True
        Me.lblmontoventa.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblmontoventa.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblcambio
        '
        Me.lblcambio.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.lblcambio.CustomButton.Image = Nothing
        Me.lblcambio.CustomButton.Location = New System.Drawing.Point(115, 1)
        Me.lblcambio.CustomButton.Name = ""
        Me.lblcambio.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.lblcambio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.lblcambio.CustomButton.TabIndex = 1
        Me.lblcambio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.lblcambio.CustomButton.UseSelectable = True
        Me.lblcambio.CustomButton.Visible = False
        Me.lblcambio.Enabled = False
        Me.lblcambio.Lines = New String(-1) {}
        Me.lblcambio.Location = New System.Drawing.Point(129, 139)
        Me.lblcambio.MaxLength = 32767
        Me.lblcambio.Name = "lblcambio"
        Me.lblcambio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblcambio.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.lblcambio.SelectedText = ""
        Me.lblcambio.SelectionLength = 0
        Me.lblcambio.SelectionStart = 0
        Me.lblcambio.ShortcutsEnabled = True
        Me.lblcambio.Size = New System.Drawing.Size(137, 23)
        Me.lblcambio.TabIndex = 38
        Me.lblcambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.lblcambio.UseCustomBackColor = True
        Me.lblcambio.UseSelectable = True
        Me.lblcambio.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.lblcambio.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPago
        '
        '
        '
        '
        Me.txtPago.CustomButton.Image = Nothing
        Me.txtPago.CustomButton.Location = New System.Drawing.Point(115, 1)
        Me.txtPago.CustomButton.Name = ""
        Me.txtPago.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPago.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPago.CustomButton.TabIndex = 1
        Me.txtPago.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPago.CustomButton.UseSelectable = True
        Me.txtPago.CustomButton.Visible = False
        Me.txtPago.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtPago.Lines = New String() {"0.00"}
        Me.txtPago.Location = New System.Drawing.Point(129, 110)
        Me.txtPago.MaxLength = 32767
        Me.txtPago.Name = "txtPago"
        Me.txtPago.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPago.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPago.SelectedText = ""
        Me.txtPago.SelectionLength = 0
        Me.txtPago.SelectionStart = 0
        Me.txtPago.ShortcutsEnabled = True
        Me.txtPago.Size = New System.Drawing.Size(137, 23)
        Me.txtPago.TabIndex = 39
        Me.txtPago.Text = "0.00"
        Me.txtPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPago.UseSelectable = True
        Me.txtPago.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPago.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(41, 81)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(82, 15)
        Me.MetroLabel1.TabIndex = 40
        Me.MetroLabel1.Text = "Total Venta: $"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.Location = New System.Drawing.Point(76, 110)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(47, 15)
        Me.MetroLabel2.TabIndex = 41
        Me.MetroLabel2.Text = "Pago: $"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel3.Location = New System.Drawing.Point(62, 139)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(61, 15)
        Me.MetroLabel3.TabIndex = 42
        Me.MetroLabel3.Text = "Cambio: $"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(41, 185)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 43
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.UseCustomForeColor = True
        Me.btnSalir.UseSelectable = True
        '
        'btnPagar
        '
        Me.btnPagar.Location = New System.Drawing.Point(191, 185)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(75, 23)
        Me.btnPagar.TabIndex = 44
        Me.btnPagar.Text = "Pagar"
        Me.btnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPagar.UseCustomForeColor = True
        Me.btnPagar.UseSelectable = True
        '
        'FrmCobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(303, 241)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPagar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtPago)
        Me.Controls.Add(Me.lblcambio)
        Me.Controls.Add(Me.lblmontoventa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmCobrar"
        Me.Text = "Pago Venta de Contado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblmontoventa As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblcambio As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPago As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnSalir As MetroFramework.Controls.MetroLink
    Friend WithEvents btnPagar As MetroFramework.Controls.MetroLink
End Class
