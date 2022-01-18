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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.ContextMenuStrip1.SuspendLayout
        CType(Me.MetroGrid1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.MetroContextMenu1.SuspendLayout
        Me.SuspendLayout
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(127, 30)
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.copy
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(126, 26)
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
        Me.MetroGrid1.AllowUserToAddRows = false
        Me.MetroGrid1.AllowUserToDeleteRows = false
        Me.MetroGrid1.AllowUserToResizeRows = false
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid1.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer), CType(CType(136,Byte),Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle5
        Me.MetroGrid1.EnableHeadersVisualStyles = false
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(31, 215)
        Me.MetroGrid1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.ReadOnly = true
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(174,Byte),Integer), CType(CType(219,Byte),Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(198,Byte),Integer), CType(CType(247,Byte),Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer), CType(CType(17,Byte),Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.MetroGrid1.RowHeadersWidth = 51
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(1040, 460)
        Me.MetroGrid1.TabIndex = 64
        '
        'txtDescripcion
        '
        '
        '
        '
        Me.txtDescripcion.CustomButton.Image = Nothing
        Me.txtDescripcion.CustomButton.Location = New System.Drawing.Point(499, 2)
        Me.txtDescripcion.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescripcion.CustomButton.Name = ""
        Me.txtDescripcion.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDescripcion.CustomButton.TabIndex = 1
        Me.txtDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDescripcion.CustomButton.UseSelectable = true
        Me.txtDescripcion.CustomButton.Visible = false
        Me.txtDescripcion.Lines = New String(-1) {}
        Me.txtDescripcion.Location = New System.Drawing.Point(31, 94)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescripcion.MaxLength = 32767
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.PromptText = "Descripción"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescripcion.SelectedText = ""
        Me.txtDescripcion.SelectionLength = 0
        Me.txtDescripcion.SelectionStart = 0
        Me.txtDescripcion.ShortcutsEnabled = true
        Me.txtDescripcion.Size = New System.Drawing.Size(400, 28)
        Me.txtDescripcion.TabIndex = 65
        Me.txtDescripcion.UseSelectable = true
        Me.txtDescripcion.WaterMark = "Descripción"
        Me.txtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtDescripcion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCodigoBarras
        '
        '
        '
        '
        Me.txtCodigoBarras.CustomButton.Image = Nothing
        Me.txtCodigoBarras.CustomButton.Location = New System.Drawing.Point(499, 2)
        Me.txtCodigoBarras.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCodigoBarras.CustomButton.Name = ""
        Me.txtCodigoBarras.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtCodigoBarras.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCodigoBarras.CustomButton.TabIndex = 1
        Me.txtCodigoBarras.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCodigoBarras.CustomButton.UseSelectable = true
        Me.txtCodigoBarras.CustomButton.Visible = false
        Me.txtCodigoBarras.Lines = New String(-1) {}
        Me.txtCodigoBarras.Location = New System.Drawing.Point(31, 129)
        Me.txtCodigoBarras.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCodigoBarras.MaxLength = 32767
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodigoBarras.PromptText = "Código de Barras"
        Me.txtCodigoBarras.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCodigoBarras.SelectedText = ""
        Me.txtCodigoBarras.SelectionLength = 0
        Me.txtCodigoBarras.SelectionStart = 0
        Me.txtCodigoBarras.ShortcutsEnabled = true
        Me.txtCodigoBarras.Size = New System.Drawing.Size(400, 28)
        Me.txtCodigoBarras.TabIndex = 66
        Me.txtCodigoBarras.UseSelectable = true
        Me.txtCodigoBarras.WaterMark = "Código de Barras"
        Me.txtCodigoBarras.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtCodigoBarras.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtClave
        '
        '
        '
        '
        Me.txtClave.CustomButton.Image = Nothing
        Me.txtClave.CustomButton.Location = New System.Drawing.Point(499, 2)
        Me.txtClave.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtClave.CustomButton.Name = ""
        Me.txtClave.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtClave.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtClave.CustomButton.TabIndex = 1
        Me.txtClave.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtClave.CustomButton.UseSelectable = true
        Me.txtClave.CustomButton.Visible = false
        Me.txtClave.Lines = New String(-1) {}
        Me.txtClave.Location = New System.Drawing.Point(31, 165)
        Me.txtClave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtClave.MaxLength = 32767
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtClave.PromptText = "Clave"
        Me.txtClave.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtClave.SelectedText = ""
        Me.txtClave.SelectionLength = 0
        Me.txtClave.SelectionStart = 0
        Me.txtClave.ShortcutsEnabled = true
        Me.txtClave.Size = New System.Drawing.Size(400, 28)
        Me.txtClave.TabIndex = 67
        Me.txtClave.UseSelectable = true
        Me.txtClave.WaterMark = "Clave"
        Me.txtClave.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtClave.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtGrupo
        '
        '
        '
        '
        Me.txtGrupo.CustomButton.Image = Nothing
        Me.txtGrupo.CustomButton.Location = New System.Drawing.Point(499, 2)
        Me.txtGrupo.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtGrupo.CustomButton.Name = ""
        Me.txtGrupo.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtGrupo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtGrupo.CustomButton.TabIndex = 1
        Me.txtGrupo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtGrupo.CustomButton.UseSelectable = true
        Me.txtGrupo.CustomButton.Visible = false
        Me.txtGrupo.Lines = New String(-1) {}
        Me.txtGrupo.Location = New System.Drawing.Point(455, 94)
        Me.txtGrupo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtGrupo.MaxLength = 32767
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGrupo.PromptText = "Grupo"
        Me.txtGrupo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtGrupo.SelectedText = ""
        Me.txtGrupo.SelectionLength = 0
        Me.txtGrupo.SelectionStart = 0
        Me.txtGrupo.ShortcutsEnabled = true
        Me.txtGrupo.Size = New System.Drawing.Size(400, 28)
        Me.txtGrupo.TabIndex = 68
        Me.txtGrupo.UseSelectable = true
        Me.txtGrupo.WaterMark = "Grupo"
        Me.txtGrupo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtGrupo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtFamilia
        '
        '
        '
        '
        Me.txtFamilia.CustomButton.Image = Nothing
        Me.txtFamilia.CustomButton.Location = New System.Drawing.Point(499, 2)
        Me.txtFamilia.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFamilia.CustomButton.Name = ""
        Me.txtFamilia.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtFamilia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFamilia.CustomButton.TabIndex = 1
        Me.txtFamilia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFamilia.CustomButton.UseSelectable = true
        Me.txtFamilia.CustomButton.Visible = false
        Me.txtFamilia.Lines = New String(-1) {}
        Me.txtFamilia.Location = New System.Drawing.Point(455, 129)
        Me.txtFamilia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFamilia.MaxLength = 32767
        Me.txtFamilia.Name = "txtFamilia"
        Me.txtFamilia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFamilia.PromptText = "Familia"
        Me.txtFamilia.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFamilia.SelectedText = ""
        Me.txtFamilia.SelectionLength = 0
        Me.txtFamilia.SelectionStart = 0
        Me.txtFamilia.ShortcutsEnabled = true
        Me.txtFamilia.Size = New System.Drawing.Size(400, 28)
        Me.txtFamilia.TabIndex = 69
        Me.txtFamilia.UseSelectable = true
        Me.txtFamilia.WaterMark = "Familia"
        Me.txtFamilia.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtFamilia.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtLinea
        '
        '
        '
        '
        Me.txtLinea.CustomButton.Image = Nothing
        Me.txtLinea.CustomButton.Location = New System.Drawing.Point(499, 2)
        Me.txtLinea.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLinea.CustomButton.Name = ""
        Me.txtLinea.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtLinea.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLinea.CustomButton.TabIndex = 1
        Me.txtLinea.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLinea.CustomButton.UseSelectable = true
        Me.txtLinea.CustomButton.Visible = false
        Me.txtLinea.Lines = New String(-1) {}
        Me.txtLinea.Location = New System.Drawing.Point(455, 165)
        Me.txtLinea.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLinea.MaxLength = 32767
        Me.txtLinea.Name = "txtLinea"
        Me.txtLinea.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLinea.PromptText = "Linea"
        Me.txtLinea.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLinea.SelectedText = ""
        Me.txtLinea.SelectionLength = 0
        Me.txtLinea.SelectionStart = 0
        Me.txtLinea.ShortcutsEnabled = true
        Me.txtLinea.Size = New System.Drawing.Size(400, 28)
        Me.txtLinea.TabIndex = 70
        Me.txtLinea.UseSelectable = true
        Me.txtLinea.WaterMark = "Linea"
        Me.txtLinea.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtLinea.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroContextMenu1
        '
        Me.MetroContextMenu1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MetroContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarProductoToolStripMenuItem})
        Me.MetroContextMenu1.Name = "MetroContextMenu1"
        Me.MetroContextMenu1.Size = New System.Drawing.Size(191, 30)
        '
        'CopiarProductoToolStripMenuItem
        '
        Me.CopiarProductoToolStripMenuItem.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.copy
        Me.CopiarProductoToolStripMenuItem.Name = "CopiarProductoToolStripMenuItem"
        Me.CopiarProductoToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.CopiarProductoToolStripMenuItem.Text = "Copiar Producto"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.close_window_16px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(968, 94)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 81
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = true
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnAdd.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.add_16px
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.Location = New System.Drawing.Point(862, 94)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 28)
        Me.btnAdd.TabIndex = 80
        Me.btnAdd.Text = "Nuevo"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.UseVisualStyleBackColor = true
        '
        'FrmBuscarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(1101, 679)
        Me.ControlBox = false
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
        Me.KeyPreview = true
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = false
        Me.Name = "FrmBuscarProductos"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
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
