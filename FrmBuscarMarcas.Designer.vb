<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarMarcas
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtMarca = New MetroFramework.Controls.MetroTextBox()
        Me.txtBusqueda = New MetroFramework.Controls.MetroTextBox()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMarca
        '
        Me.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtMarca.CustomButton.Image = Nothing
        Me.txtMarca.CustomButton.Location = New System.Drawing.Point(233, 1)
        Me.txtMarca.CustomButton.Name = ""
        Me.txtMarca.CustomButton.Size = New System.Drawing.Size(16, 17)
        Me.txtMarca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMarca.CustomButton.TabIndex = 1
        Me.txtMarca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMarca.CustomButton.UseSelectable = True
        Me.txtMarca.CustomButton.Visible = False
        Me.txtMarca.Lines = New String(-1) {}
        Me.txtMarca.Location = New System.Drawing.Point(528, 79)
        Me.txtMarca.MaxLength = 32767
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMarca.PromptText = "Nombre de la Marca"
        Me.txtMarca.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMarca.SelectedText = ""
        Me.txtMarca.SelectionLength = 0
        Me.txtMarca.SelectionStart = 0
        Me.txtMarca.ShortcutsEnabled = True
        Me.txtMarca.Size = New System.Drawing.Size(333, 23)
        Me.txtMarca.TabIndex = 9
        Me.txtMarca.UseSelectable = True
        Me.txtMarca.WaterMark = "Nombre de la Marca"
        Me.txtMarca.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMarca.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtBusqueda
        '
        Me.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtBusqueda.CustomButton.Image = Nothing
        Me.txtBusqueda.CustomButton.Location = New System.Drawing.Point(233, 1)
        Me.txtBusqueda.CustomButton.Name = ""
        Me.txtBusqueda.CustomButton.Size = New System.Drawing.Size(16, 17)
        Me.txtBusqueda.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBusqueda.CustomButton.TabIndex = 1
        Me.txtBusqueda.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBusqueda.CustomButton.UseSelectable = True
        Me.txtBusqueda.CustomButton.Visible = False
        Me.txtBusqueda.Lines = New String(-1) {}
        Me.txtBusqueda.Location = New System.Drawing.Point(14, 79)
        Me.txtBusqueda.MaxLength = 32767
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBusqueda.PromptText = "Buscar Marca"
        Me.txtBusqueda.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBusqueda.SelectedText = ""
        Me.txtBusqueda.SelectionLength = 0
        Me.txtBusqueda.SelectionStart = 0
        Me.txtBusqueda.ShortcutsEnabled = True
        Me.txtBusqueda.Size = New System.Drawing.Size(333, 23)
        Me.txtBusqueda.TabIndex = 8
        Me.txtBusqueda.UseSelectable = True
        Me.txtBusqueda.WaterMark = "Buscar Marca"
        Me.txtBusqueda.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBusqueda.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.MetroGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle7
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(14, 144)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.ReadOnly = True
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.MetroGrid1.RowHeadersWidth = 51
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(847, 296)
        Me.MetroGrid1.TabIndex = 12
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.save_16px
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(528, 107)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 23)
        Me.btnSave.TabIndex = 79
        Me.btnSave.Text = "Crear / Modificar"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.close_window_16px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(786, 107)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 81
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmBuscarMarcas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(898, 491)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Name = "FrmBuscarMarcas"
        Me.Text = "Buscar/Agregar Marcas"
        CType(Me.MetroGrid1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents txtMarca As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBusqueda As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents btnSave As Button
    Friend WithEvents Button1 As Button
End Class
