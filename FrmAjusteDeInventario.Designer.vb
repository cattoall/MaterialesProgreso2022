<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAjusteDeInventario
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
        Me.txtDescripcion = New MetroFramework.Controls.MetroTextBox()
        Me.btnBuscar = New MetroFramework.Controls.MetroLink()
        Me.RbtnActual = New MetroFramework.Controls.MetroRadioButton()
        Me.RbtnAcumulativo = New MetroFramework.Controls.MetroRadioButton()
        Me.TxtStockActual = New MetroFramework.Controls.MetroTextBox()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        Me.btnSalir = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.LblStock = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtDescripcion.CustomButton.Image = Nothing
        Me.txtDescripcion.CustomButton.Location = New System.Drawing.Point(389, 1)
        Me.txtDescripcion.CustomButton.Name = ""
        Me.txtDescripcion.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDescripcion.CustomButton.TabIndex = 1
        Me.txtDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDescripcion.CustomButton.UseSelectable = True
        Me.txtDescripcion.CustomButton.Visible = False
        Me.txtDescripcion.Lines = New String(-1) {}
        Me.txtDescripcion.Location = New System.Drawing.Point(23, 73)
        Me.txtDescripcion.MaxLength = 32767
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.PromptText = "<PRESIONA F2 PARA SELECCIONAR UN PRODUCTO>"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescripcion.SelectedText = ""
        Me.txtDescripcion.SelectionLength = 0
        Me.txtDescripcion.SelectionStart = 0
        Me.txtDescripcion.ShortcutsEnabled = True
        Me.txtDescripcion.Size = New System.Drawing.Size(338, 23)
        Me.txtDescripcion.TabIndex = 2
        Me.txtDescripcion.UseSelectable = True
        Me.txtDescripcion.WaterMark = "<PRESIONA F2 PARA SELECCIONAR UN PRODUCTO>"
        Me.txtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDescripcion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(367, 73)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(67, 23)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseCustomForeColor = True
        Me.btnBuscar.UseSelectable = True
        '
        'RbtnActual
        '
        Me.RbtnActual.AutoSize = True
        Me.RbtnActual.Checked = True
        Me.RbtnActual.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold
        Me.RbtnActual.Location = New System.Drawing.Point(3, 8)
        Me.RbtnActual.Name = "RbtnActual"
        Me.RbtnActual.Size = New System.Drawing.Size(119, 15)
        Me.RbtnActual.TabIndex = 4
        Me.RbtnActual.TabStop = True
        Me.RbtnActual.Text = "Inventario Actual"
        Me.RbtnActual.UseSelectable = True
        '
        'RbtnAcumulativo
        '
        Me.RbtnAcumulativo.AutoSize = True
        Me.RbtnAcumulativo.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold
        Me.RbtnAcumulativo.Location = New System.Drawing.Point(251, 8)
        Me.RbtnAcumulativo.Name = "RbtnAcumulativo"
        Me.RbtnAcumulativo.Size = New System.Drawing.Size(154, 15)
        Me.RbtnAcumulativo.TabIndex = 5
        Me.RbtnAcumulativo.Text = "Inventario Acumulativo"
        Me.RbtnAcumulativo.UseSelectable = True
        '
        'TxtStockActual
        '
        Me.TxtStockActual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.TxtStockActual.CustomButton.Image = Nothing
        Me.TxtStockActual.CustomButton.Location = New System.Drawing.Point(121, 1)
        Me.TxtStockActual.CustomButton.Name = ""
        Me.TxtStockActual.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.TxtStockActual.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TxtStockActual.CustomButton.TabIndex = 1
        Me.TxtStockActual.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TxtStockActual.CustomButton.UseSelectable = True
        Me.TxtStockActual.CustomButton.Visible = False
        Me.TxtStockActual.Lines = New String(-1) {}
        Me.TxtStockActual.Location = New System.Drawing.Point(145, 191)
        Me.TxtStockActual.MaxLength = 32767
        Me.TxtStockActual.Name = "TxtStockActual"
        Me.TxtStockActual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtStockActual.PromptText = "Stock Actual"
        Me.TxtStockActual.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtStockActual.SelectedText = ""
        Me.TxtStockActual.SelectionLength = 0
        Me.TxtStockActual.SelectionStart = 0
        Me.TxtStockActual.ShortcutsEnabled = True
        Me.TxtStockActual.Size = New System.Drawing.Size(143, 23)
        Me.TxtStockActual.TabIndex = 6
        Me.TxtStockActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtStockActual.UseSelectable = True
        Me.TxtStockActual.WaterMark = "Stock Actual"
        Me.TxtStockActual.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TxtStockActual.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(23, 244)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseSelectable = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(191, 244)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseSelectable = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(359, 244)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseSelectable = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.RbtnActual)
        Me.MetroPanel1.Controls.Add(Me.RbtnAcumulativo)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(23, 102)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(411, 32)
        Me.MetroPanel1.TabIndex = 10
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'LblStock
        '
        Me.LblStock.Location = New System.Drawing.Point(23, 152)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(411, 23)
        Me.LblStock.TabIndex = 11
        Me.LblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmAjusteDeInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(464, 294)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblStock)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.TxtStockActual)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtDescripcion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmAjusteDeInventario"
        Me.Text = "Ajuste de Inventario"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtDescripcion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnBuscar As MetroFramework.Controls.MetroLink
    Friend WithEvents RbtnActual As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents RbtnAcumulativo As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents TxtStockActual As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSalir As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents LblStock As MetroFramework.Controls.MetroLabel
End Class
