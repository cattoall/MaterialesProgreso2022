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
    <System.Diagnostics.DebuggerStepThrough()>
    <Obsolete>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtDescripcion = New MetroFramework.Controls.MetroTextBox()
        Me.btnBuscar = New MetroFramework.Controls.MetroLink()
        Me.RbtnActual = New MetroFramework.Controls.MetroRadioButton()
        Me.RbtnAcumulativo = New MetroFramework.Controls.MetroRadioButton()
        Me.TxtStockActual = New MetroFramework.Controls.MetroTextBox()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.LblStock = New MetroFramework.Controls.MetroLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
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
        Me.txtDescripcion.CustomButton.Location = New System.Drawing.Point(567, 2)
        Me.txtDescripcion.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescripcion.CustomButton.Name = ""
        Me.txtDescripcion.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDescripcion.CustomButton.TabIndex = 1
        Me.txtDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDescripcion.CustomButton.UseSelectable = True
        Me.txtDescripcion.CustomButton.Visible = False
        Me.txtDescripcion.Lines = New String(-1) {}
        Me.txtDescripcion.Location = New System.Drawing.Point(31, 90)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescripcion.MaxLength = 32767
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.PromptText = "<PRESIONA F2 PARA SELECCIONAR UN PRODUCTO>"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescripcion.SelectedText = ""
        Me.txtDescripcion.SelectionLength = 0
        Me.txtDescripcion.SelectionStart = 0
        Me.txtDescripcion.ShortcutsEnabled = True
        Me.txtDescripcion.Size = New System.Drawing.Size(451, 28)
        Me.txtDescripcion.TabIndex = 2
        Me.txtDescripcion.UseSelectable = True
        Me.txtDescripcion.WaterMark = "<PRESIONA F2 PARA SELECCIONAR UN PRODUCTO>"
        Me.txtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDescripcion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(489, 90)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(89, 28)
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
        Me.RbtnActual.Location = New System.Drawing.Point(4, 10)
        Me.RbtnActual.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RbtnActual.Name = "RbtnActual"
        Me.RbtnActual.Size = New System.Drawing.Size(130, 17)
        Me.RbtnActual.TabIndex = 4
        Me.RbtnActual.TabStop = True
        Me.RbtnActual.Text = "Inventario Actual"
        Me.RbtnActual.UseSelectable = True
        '
        'RbtnAcumulativo
        '
        Me.RbtnAcumulativo.AutoSize = True
        Me.RbtnAcumulativo.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold
        Me.RbtnAcumulativo.Location = New System.Drawing.Point(335, 10)
        Me.RbtnAcumulativo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RbtnAcumulativo.Name = "RbtnAcumulativo"
        Me.RbtnAcumulativo.Size = New System.Drawing.Size(169, 17)
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
        Me.TxtStockActual.CustomButton.Location = New System.Drawing.Point(220, 2)
        Me.TxtStockActual.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtStockActual.CustomButton.Name = ""
        Me.TxtStockActual.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.TxtStockActual.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TxtStockActual.CustomButton.TabIndex = 1
        Me.TxtStockActual.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TxtStockActual.CustomButton.UseSelectable = True
        Me.TxtStockActual.CustomButton.Visible = False
        Me.TxtStockActual.Lines = New String(-1) {}
        Me.TxtStockActual.Location = New System.Drawing.Point(193, 235)
        Me.TxtStockActual.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtStockActual.MaxLength = 32767
        Me.TxtStockActual.Name = "TxtStockActual"
        Me.TxtStockActual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtStockActual.PromptText = "Stock Actual"
        Me.TxtStockActual.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtStockActual.SelectedText = ""
        Me.TxtStockActual.SelectionLength = 0
        Me.TxtStockActual.SelectionStart = 0
        Me.TxtStockActual.ShortcutsEnabled = True
        Me.TxtStockActual.Size = New System.Drawing.Size(191, 28)
        Me.TxtStockActual.TabIndex = 6
        Me.TxtStockActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtStockActual.UseSelectable = True
        Me.TxtStockActual.WaterMark = "Stock Actual"
        Me.TxtStockActual.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TxtStockActual.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.RbtnActual)
        Me.MetroPanel1.Controls.Add(Me.RbtnAcumulativo)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 12
        Me.MetroPanel1.Location = New System.Drawing.Point(31, 126)
        Me.MetroPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(548, 39)
        Me.MetroPanel1.TabIndex = 10
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 13
        '
        'LblStock
        '
        Me.LblStock.Location = New System.Drawing.Point(31, 187)
        Me.LblStock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(548, 28)
        Me.LblStock.TabIndex = 11
        Me.LblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.close_window_16px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(478, 306)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 87
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.save_16px
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(35, 306)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 28)
        Me.btnSave.TabIndex = 86
        Me.btnSave.Text = "Guardar"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.Location = New System.Drawing.Point(372, 306)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 28)
        Me.btnAdd.TabIndex = 88
        Me.btnAdd.Text = "Cancelar"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'FrmAjusteDeInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(619, 362)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.LblStock)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.TxtStockActual)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtDescripcion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "FrmAjusteDeInventario"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
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
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents LblStock As MetroFramework.Controls.MetroLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
End Class
