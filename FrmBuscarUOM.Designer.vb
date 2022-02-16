<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarUOM
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.txtBusqueda = New MetroFramework.Controls.MetroTextBox()
        Me.txtUOM = New MetroFramework.Controls.MetroTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.MetroGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(23, 121)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.ReadOnly = True
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.MetroGrid1.RowHeadersWidth = 51
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(847, 324)
        Me.MetroGrid1.TabIndex = 4
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
        Me.txtBusqueda.Location = New System.Drawing.Point(23, 63)
        Me.txtBusqueda.MaxLength = 32767
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBusqueda.PromptText = "Buscar Unidad de Medida"
        Me.txtBusqueda.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBusqueda.SelectedText = ""
        Me.txtBusqueda.SelectionLength = 0
        Me.txtBusqueda.SelectionStart = 0
        Me.txtBusqueda.ShortcutsEnabled = True
        Me.txtBusqueda.Size = New System.Drawing.Size(333, 23)
        Me.txtBusqueda.TabIndex = 5
        Me.txtBusqueda.UseSelectable = True
        Me.txtBusqueda.WaterMark = "Buscar Unidad de Medida"
        Me.txtBusqueda.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBusqueda.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtUOM
        '
        Me.txtUOM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtUOM.CustomButton.Image = Nothing
        Me.txtUOM.CustomButton.Location = New System.Drawing.Point(233, 1)
        Me.txtUOM.CustomButton.Name = ""
        Me.txtUOM.CustomButton.Size = New System.Drawing.Size(16, 17)
        Me.txtUOM.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUOM.CustomButton.TabIndex = 1
        Me.txtUOM.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUOM.CustomButton.UseSelectable = True
        Me.txtUOM.CustomButton.Visible = False
        Me.txtUOM.Lines = New String(-1) {}
        Me.txtUOM.Location = New System.Drawing.Point(537, 63)
        Me.txtUOM.MaxLength = 32767
        Me.txtUOM.Name = "txtUOM"
        Me.txtUOM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUOM.PromptText = "Nombre de la Unidad de Medida"
        Me.txtUOM.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUOM.SelectedText = ""
        Me.txtUOM.SelectionLength = 0
        Me.txtUOM.SelectionStart = 0
        Me.txtUOM.ShortcutsEnabled = True
        Me.txtUOM.Size = New System.Drawing.Size(333, 23)
        Me.txtUOM.TabIndex = 6
        Me.txtUOM.UseSelectable = True
        Me.txtUOM.WaterMark = "Nombre de la Unidad de Medida"
        Me.txtUOM.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUOM.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.close_window_16px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(795, 93)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 89
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
        Me.btnSave.Location = New System.Drawing.Point(537, 93)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 23)
        Me.btnSave.TabIndex = 88
        Me.btnSave.Text = "Crear / Modificar"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'FrmBuscarUOM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(882, 468)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtUOM)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.MetroGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmBuscarUOM"
        Me.Text = "Buscar/Agregar Unidades de Medidas"
        CType(Me.MetroGrid1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents txtBusqueda As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtUOM As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSave As Button
End Class
