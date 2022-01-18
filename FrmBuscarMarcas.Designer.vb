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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtMarca = New MetroFramework.Controls.MetroTextBox()
        Me.txtBusqueda = New MetroFramework.Controls.MetroTextBox()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.MetroGrid1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'txtMarca
        '
        Me.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtMarca.CustomButton.Image = Nothing
        Me.txtMarca.CustomButton.Location = New System.Drawing.Point(557, 2)
        Me.txtMarca.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMarca.CustomButton.Name = ""
        Me.txtMarca.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtMarca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMarca.CustomButton.TabIndex = 1
        Me.txtMarca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMarca.CustomButton.UseSelectable = true
        Me.txtMarca.CustomButton.Visible = false
        Me.txtMarca.Lines = New String(-1) {}
        Me.txtMarca.Location = New System.Drawing.Point(704, 97)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMarca.MaxLength = 32767
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMarca.PromptText = "Nombre de la Marca"
        Me.txtMarca.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMarca.SelectedText = ""
        Me.txtMarca.SelectionLength = 0
        Me.txtMarca.SelectionStart = 0
        Me.txtMarca.ShortcutsEnabled = true
        Me.txtMarca.Size = New System.Drawing.Size(444, 28)
        Me.txtMarca.TabIndex = 9
        Me.txtMarca.UseSelectable = true
        Me.txtMarca.WaterMark = "Nombre de la Marca"
        Me.txtMarca.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtMarca.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtBusqueda
        '
        Me.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtBusqueda.CustomButton.Image = Nothing
        Me.txtBusqueda.CustomButton.Location = New System.Drawing.Point(557, 2)
        Me.txtBusqueda.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBusqueda.CustomButton.Name = ""
        Me.txtBusqueda.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtBusqueda.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBusqueda.CustomButton.TabIndex = 1
        Me.txtBusqueda.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBusqueda.CustomButton.UseSelectable = true
        Me.txtBusqueda.CustomButton.Visible = false
        Me.txtBusqueda.Lines = New String(-1) {}
        Me.txtBusqueda.Location = New System.Drawing.Point(19, 97)
        Me.txtBusqueda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBusqueda.MaxLength = 32767
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBusqueda.PromptText = "Buscar Marca"
        Me.txtBusqueda.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBusqueda.SelectedText = ""
        Me.txtBusqueda.SelectionLength = 0
        Me.txtBusqueda.SelectionStart = 0
        Me.txtBusqueda.ShortcutsEnabled = true
        Me.txtBusqueda.Size = New System.Drawing.Size(444, 28)
        Me.txtBusqueda.TabIndex = 8
        Me.txtBusqueda.UseSelectable = true
        Me.txtBusqueda.WaterMark = "Buscar Marca"
        Me.txtBusqueda.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtBusqueda.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = false
        Me.MetroGrid1.AllowUserToDeleteRows = false
        Me.MetroGrid1.AllowUserToResizeRows = false
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer))
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle17
        Me.MetroGrid1.EnableHeadersVisualStyles = false
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(19, 177)
        Me.MetroGrid1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.ReadOnly = true
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.MetroGrid1.RowHeadersWidth = 51
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(1129, 364)
        Me.MetroGrid1.TabIndex = 12
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47,Byte),Integer), CType(CType(170,Byte),Integer), CType(CType(141,Byte),Integer))
        Me.btnSave.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.save_16px
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(704, 132)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(149, 28)
        Me.btnSave.TabIndex = 79
        Me.btnSave.Text = "Crear / Modificar"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.UseVisualStyleBackColor = true
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.close_window_16px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(1048, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 81
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = true
        '
        'FrmBuscarMarcas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 604)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmBuscarMarcas"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
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
