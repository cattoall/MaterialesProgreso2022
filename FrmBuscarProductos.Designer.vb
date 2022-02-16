<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarProductos
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.txtDescripcion = New MetroFramework.Controls.MetroTextBox()
        Me.txtCodigoBarras = New MetroFramework.Controls.MetroTextBox()
        Me.txtClave = New MetroFramework.Controls.MetroTextBox()
        Me.txtGrupo = New MetroFramework.Controls.MetroTextBox()
        Me.txtFamilia = New MetroFramework.Controls.MetroTextBox()
        Me.txtLinea = New MetroFramework.Controls.MetroTextBox()
        Me.MetroContextMenu1 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.CopiarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroContextMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(114, 30)
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.copy
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(113, 26)
        Me.AToolStripMenuItem.Text = "Copiar"
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
        Me.MetroGrid1.ContextMenuStrip = Me.ContextMenuStrip1
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
        Me.MetroGrid1.Location = New System.Drawing.Point(23, 175)
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
        Me.MetroGrid1.Size = New System.Drawing.Size(780, 374)
        Me.MetroGrid1.TabIndex = 64
        '
        'txtDescripcion
        '
        '
        '
        '
        Me.txtDescripcion.CustomButton.Image = Nothing
        Me.txtDescripcion.CustomButton.Location = New System.Drawing.Point(208, 1)
        Me.txtDescripcion.CustomButton.Name = ""
        Me.txtDescripcion.CustomButton.Size = New System.Drawing.Size(16, 17)
        Me.txtDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDescripcion.CustomButton.TabIndex = 1
        Me.txtDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDescripcion.CustomButton.UseSelectable = True
        Me.txtDescripcion.CustomButton.Visible = False
        Me.txtDescripcion.Lines = New String(-1) {}
        Me.txtDescripcion.Location = New System.Drawing.Point(23, 76)
        Me.txtDescripcion.MaxLength = 32767
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.PromptText = "Descripción"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescripcion.SelectedText = ""
        Me.txtDescripcion.SelectionLength = 0
        Me.txtDescripcion.SelectionStart = 0
        Me.txtDescripcion.ShortcutsEnabled = True
        Me.txtDescripcion.Size = New System.Drawing.Size(300, 23)
        Me.txtDescripcion.TabIndex = 65
        Me.txtDescripcion.UseSelectable = True
        Me.txtDescripcion.WaterMark = "Descripción"
        Me.txtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDescripcion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCodigoBarras
        '
        '
        '
        '
        Me.txtCodigoBarras.CustomButton.Image = Nothing
        Me.txtCodigoBarras.CustomButton.Location = New System.Drawing.Point(208, 1)
        Me.txtCodigoBarras.CustomButton.Name = ""
        Me.txtCodigoBarras.CustomButton.Size = New System.Drawing.Size(16, 17)
        Me.txtCodigoBarras.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCodigoBarras.CustomButton.TabIndex = 1
        Me.txtCodigoBarras.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCodigoBarras.CustomButton.UseSelectable = True
        Me.txtCodigoBarras.CustomButton.Visible = False
        Me.txtCodigoBarras.Lines = New String(-1) {}
        Me.txtCodigoBarras.Location = New System.Drawing.Point(23, 105)
        Me.txtCodigoBarras.MaxLength = 32767
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodigoBarras.PromptText = "Código de Barras"
        Me.txtCodigoBarras.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCodigoBarras.SelectedText = ""
        Me.txtCodigoBarras.SelectionLength = 0
        Me.txtCodigoBarras.SelectionStart = 0
        Me.txtCodigoBarras.ShortcutsEnabled = True
        Me.txtCodigoBarras.Size = New System.Drawing.Size(300, 23)
        Me.txtCodigoBarras.TabIndex = 66
        Me.txtCodigoBarras.UseSelectable = True
        Me.txtCodigoBarras.WaterMark = "Código de Barras"
        Me.txtCodigoBarras.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCodigoBarras.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtClave
        '
        '
        '
        '
        Me.txtClave.CustomButton.Image = Nothing
        Me.txtClave.CustomButton.Location = New System.Drawing.Point(208, 1)
        Me.txtClave.CustomButton.Name = ""
        Me.txtClave.CustomButton.Size = New System.Drawing.Size(16, 17)
        Me.txtClave.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtClave.CustomButton.TabIndex = 1
        Me.txtClave.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtClave.CustomButton.UseSelectable = True
        Me.txtClave.CustomButton.Visible = False
        Me.txtClave.Lines = New String(-1) {}
        Me.txtClave.Location = New System.Drawing.Point(23, 134)
        Me.txtClave.MaxLength = 32767
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtClave.PromptText = "Clave"
        Me.txtClave.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtClave.SelectedText = ""
        Me.txtClave.SelectionLength = 0
        Me.txtClave.SelectionStart = 0
        Me.txtClave.ShortcutsEnabled = True
        Me.txtClave.Size = New System.Drawing.Size(300, 23)
        Me.txtClave.TabIndex = 67
        Me.txtClave.UseSelectable = True
        Me.txtClave.WaterMark = "Clave"
        Me.txtClave.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtClave.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtGrupo
        '
        '
        '
        '
        Me.txtGrupo.CustomButton.Image = Nothing
        Me.txtGrupo.CustomButton.Location = New System.Drawing.Point(208, 1)
        Me.txtGrupo.CustomButton.Name = ""
        Me.txtGrupo.CustomButton.Size = New System.Drawing.Size(16, 17)
        Me.txtGrupo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtGrupo.CustomButton.TabIndex = 1
        Me.txtGrupo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtGrupo.CustomButton.UseSelectable = True
        Me.txtGrupo.CustomButton.Visible = False
        Me.txtGrupo.Lines = New String(-1) {}
        Me.txtGrupo.Location = New System.Drawing.Point(341, 76)
        Me.txtGrupo.MaxLength = 32767
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGrupo.PromptText = "Grupo"
        Me.txtGrupo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtGrupo.SelectedText = ""
        Me.txtGrupo.SelectionLength = 0
        Me.txtGrupo.SelectionStart = 0
        Me.txtGrupo.ShortcutsEnabled = True
        Me.txtGrupo.Size = New System.Drawing.Size(300, 23)
        Me.txtGrupo.TabIndex = 68
        Me.txtGrupo.UseSelectable = True
        Me.txtGrupo.WaterMark = "Grupo"
        Me.txtGrupo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtGrupo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtFamilia
        '
        '
        '
        '
        Me.txtFamilia.CustomButton.Image = Nothing
        Me.txtFamilia.CustomButton.Location = New System.Drawing.Point(208, 1)
        Me.txtFamilia.CustomButton.Name = ""
        Me.txtFamilia.CustomButton.Size = New System.Drawing.Size(16, 17)
        Me.txtFamilia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFamilia.CustomButton.TabIndex = 1
        Me.txtFamilia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFamilia.CustomButton.UseSelectable = True
        Me.txtFamilia.CustomButton.Visible = False
        Me.txtFamilia.Lines = New String(-1) {}
        Me.txtFamilia.Location = New System.Drawing.Point(341, 105)
        Me.txtFamilia.MaxLength = 32767
        Me.txtFamilia.Name = "txtFamilia"
        Me.txtFamilia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFamilia.PromptText = "Familia"
        Me.txtFamilia.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFamilia.SelectedText = ""
        Me.txtFamilia.SelectionLength = 0
        Me.txtFamilia.SelectionStart = 0
        Me.txtFamilia.ShortcutsEnabled = True
        Me.txtFamilia.Size = New System.Drawing.Size(300, 23)
        Me.txtFamilia.TabIndex = 69
        Me.txtFamilia.UseSelectable = True
        Me.txtFamilia.WaterMark = "Familia"
        Me.txtFamilia.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFamilia.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtLinea
        '
        '
        '
        '
        Me.txtLinea.CustomButton.Image = Nothing
        Me.txtLinea.CustomButton.Location = New System.Drawing.Point(208, 1)
        Me.txtLinea.CustomButton.Name = ""
        Me.txtLinea.CustomButton.Size = New System.Drawing.Size(16, 17)
        Me.txtLinea.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLinea.CustomButton.TabIndex = 1
        Me.txtLinea.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLinea.CustomButton.UseSelectable = True
        Me.txtLinea.CustomButton.Visible = False
        Me.txtLinea.Lines = New String(-1) {}
        Me.txtLinea.Location = New System.Drawing.Point(341, 134)
        Me.txtLinea.MaxLength = 32767
        Me.txtLinea.Name = "txtLinea"
        Me.txtLinea.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLinea.PromptText = "Linea"
        Me.txtLinea.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLinea.SelectedText = ""
        Me.txtLinea.SelectionLength = 0
        Me.txtLinea.SelectionStart = 0
        Me.txtLinea.ShortcutsEnabled = True
        Me.txtLinea.Size = New System.Drawing.Size(300, 23)
        Me.txtLinea.TabIndex = 70
        Me.txtLinea.UseSelectable = True
        Me.txtLinea.WaterMark = "Linea"
        Me.txtLinea.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLinea.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroContextMenu1
        '
        Me.MetroContextMenu1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MetroContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarProductoToolStripMenuItem})
        Me.MetroContextMenu1.Name = "MetroContextMenu1"
        Me.MetroContextMenu1.Size = New System.Drawing.Size(166, 30)
        '
        'CopiarProductoToolStripMenuItem
        '
        Me.CopiarProductoToolStripMenuItem.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.copy
        Me.CopiarProductoToolStripMenuItem.Name = "CopiarProductoToolStripMenuItem"
        Me.CopiarProductoToolStripMenuItem.Size = New System.Drawing.Size(165, 26)
        Me.CopiarProductoToolStripMenuItem.Text = "Copiar Producto"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.close_window_16px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(726, 76)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 81
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnAdd.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.add_16px
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.Location = New System.Drawing.Point(646, 76)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 80
        Me.btnAdd.Text = "Nuevo"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'FrmBuscarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(826, 552)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtLinea)
        Me.Controls.Add(Me.txtFamilia)
        Me.Controls.Add(Me.txtGrupo)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.txtCodigoBarras)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.MetroGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmBuscarProductos"
        Me.Text = "Buscar Productos"
        Me.ContextMenuStrip1.ResumeLayout(false)
        CType(Me.MetroGrid1,System.ComponentModel.ISupportInitialize).EndInit
        Me.MetroContextMenu1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents txtDescripcion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCodigoBarras As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtClave As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtGrupo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtFamilia As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtLinea As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroContextMenu1 As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents CopiarProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents btnAdd As Button
End Class
