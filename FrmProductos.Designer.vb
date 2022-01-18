<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductos
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
        Me.txtDescripcion = New MetroFramework.Controls.MetroTextBox()
        Me.txtClave = New MetroFramework.Controls.MetroTextBox()
        Me.txtCodigoBarras = New MetroFramework.Controls.MetroTextBox()
        Me.txtIdProducto = New MetroFramework.Controls.MetroTextBox()
        Me.CmbTipoVenta = New MetroFramework.Controls.MetroComboBox()
        Me.CmbUnidad = New MetroFramework.Controls.MetroComboBox()
        Me.CmbLinea = New MetroFramework.Controls.MetroComboBox()
        Me.CmbFamilia = New MetroFramework.Controls.MetroComboBox()
        Me.CmbProveedor = New MetroFramework.Controls.MetroComboBox()
        Me.CmbSubFamilia = New MetroFramework.Controls.MetroComboBox()
        Me.CmbGrupo = New MetroFramework.Controls.MetroComboBox()
        Me.CmdLinea = New System.Windows.Forms.Button()
        Me.CmdFamilia = New System.Windows.Forms.Button()
        Me.CmdProveedor = New System.Windows.Forms.Button()
        Me.CmdSubFam = New System.Windows.Forms.Button()
        Me.CmdAgrupo = New System.Windows.Forms.Button()
        Me.txtPrecioP3 = New MetroFramework.Controls.MetroTextBox()
        Me.txtPrecioP2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtPrecioP1 = New MetroFramework.Controls.MetroTextBox()
        Me.txtPrecioPublico = New MetroFramework.Controls.MetroTextBox()
        Me.txtPrecioCosto = New MetroFramework.Controls.MetroTextBox()
        Me.txtPrecioLista = New MetroFramework.Controls.MetroTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtClaveProducto = New MetroFramework.Controls.MetroTextBox()
        Me.txtClaveUnidad = New MetroFramework.Controls.MetroTextBox()
        Me.txtDesc = New MetroFramework.Controls.MetroTextBox()
        Me.txtStock = New MetroFramework.Controls.MetroTextBox()
        Me.chkPrecioManual = New MetroFramework.Controls.MetroCheckBox()
        Me.chkTasaCero = New MetroFramework.Controls.MetroCheckBox()
        Me.chkTC = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel20 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel21 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtDescripcion.CustomButton.Image = Nothing
        Me.txtDescripcion.CustomButton.Location = New System.Drawing.Point(665, 2)
        Me.txtDescripcion.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescripcion.CustomButton.Name = ""
        Me.txtDescripcion.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDescripcion.CustomButton.TabIndex = 1
        Me.txtDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDescripcion.CustomButton.UseSelectable = true
        Me.txtDescripcion.CustomButton.Visible = false
        Me.txtDescripcion.Lines = New String(-1) {}
        Me.txtDescripcion.Location = New System.Drawing.Point(212, 183)
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
        Me.txtDescripcion.Size = New System.Drawing.Size(525, 28)
        Me.txtDescripcion.TabIndex = 102
        Me.txtDescripcion.UseSelectable = true
        Me.txtDescripcion.WaterMark = "Descripción"
        Me.txtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtDescripcion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtClave
        '
        Me.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtClave.CustomButton.Image = Nothing
        Me.txtClave.CustomButton.Location = New System.Drawing.Point(259, 2)
        Me.txtClave.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtClave.CustomButton.Name = ""
        Me.txtClave.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtClave.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtClave.CustomButton.TabIndex = 1
        Me.txtClave.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtClave.CustomButton.UseSelectable = true
        Me.txtClave.CustomButton.Visible = false
        Me.txtClave.Lines = New String(-1) {}
        Me.txtClave.Location = New System.Drawing.Point(212, 146)
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
        Me.txtClave.Size = New System.Drawing.Size(220, 28)
        Me.txtClave.TabIndex = 101
        Me.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtClave.UseSelectable = true
        Me.txtClave.WaterMark = "Clave"
        Me.txtClave.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtClave.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtCodigoBarras.CustomButton.Image = Nothing
        Me.txtCodigoBarras.CustomButton.Location = New System.Drawing.Point(259, 2)
        Me.txtCodigoBarras.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCodigoBarras.CustomButton.Name = ""
        Me.txtCodigoBarras.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtCodigoBarras.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCodigoBarras.CustomButton.TabIndex = 1
        Me.txtCodigoBarras.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCodigoBarras.CustomButton.UseSelectable = true
        Me.txtCodigoBarras.CustomButton.Visible = false
        Me.txtCodigoBarras.Lines = New String(-1) {}
        Me.txtCodigoBarras.Location = New System.Drawing.Point(212, 110)
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
        Me.txtCodigoBarras.Size = New System.Drawing.Size(220, 28)
        Me.txtCodigoBarras.TabIndex = 100
        Me.txtCodigoBarras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCodigoBarras.UseSelectable = true
        Me.txtCodigoBarras.WaterMark = "Código de Barras"
        Me.txtCodigoBarras.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtCodigoBarras.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtIdProducto
        '
        '
        '
        '
        Me.txtIdProducto.CustomButton.Image = Nothing
        Me.txtIdProducto.CustomButton.Location = New System.Drawing.Point(108, 2)
        Me.txtIdProducto.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIdProducto.CustomButton.Name = ""
        Me.txtIdProducto.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtIdProducto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtIdProducto.CustomButton.TabIndex = 1
        Me.txtIdProducto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtIdProducto.CustomButton.UseSelectable = true
        Me.txtIdProducto.CustomButton.Visible = false
        Me.txtIdProducto.Enabled = false
        Me.txtIdProducto.Lines = New String(-1) {}
        Me.txtIdProducto.Location = New System.Drawing.Point(212, 73)
        Me.txtIdProducto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIdProducto.MaxLength = 32767
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdProducto.PromptText = "0"
        Me.txtIdProducto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIdProducto.SelectedText = ""
        Me.txtIdProducto.SelectionLength = 0
        Me.txtIdProducto.SelectionStart = 0
        Me.txtIdProducto.ShortcutsEnabled = true
        Me.txtIdProducto.Size = New System.Drawing.Size(107, 28)
        Me.txtIdProducto.TabIndex = 99
        Me.txtIdProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtIdProducto.UseSelectable = true
        Me.txtIdProducto.WaterMark = "0"
        Me.txtIdProducto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtIdProducto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'CmbTipoVenta
        '
        Me.CmbTipoVenta.FormattingEnabled = true
        Me.CmbTipoVenta.ItemHeight = 24
        Me.CmbTipoVenta.Items.AddRange(New Object() {"PIEZA", "GRANEL"})
        Me.CmbTipoVenta.Location = New System.Drawing.Point(743, 310)
        Me.CmbTipoVenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbTipoVenta.Name = "CmbTipoVenta"
        Me.CmbTipoVenta.PromptText = "Tipo Venta"
        Me.CmbTipoVenta.Size = New System.Drawing.Size(251, 30)
        Me.CmbTipoVenta.TabIndex = 97
        Me.CmbTipoVenta.UseSelectable = true
        '
        'CmbUnidad
        '
        Me.CmbUnidad.FormattingEnabled = true
        Me.CmbUnidad.ItemHeight = 24
        Me.CmbUnidad.Location = New System.Drawing.Point(865, 183)
        Me.CmbUnidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbUnidad.Name = "CmbUnidad"
        Me.CmbUnidad.PromptText = "UoM"
        Me.CmbUnidad.Size = New System.Drawing.Size(128, 30)
        Me.CmbUnidad.TabIndex = 96
        Me.CmbUnidad.UseSelectable = true
        '
        'CmbLinea
        '
        Me.CmbLinea.FormattingEnabled = true
        Me.CmbLinea.ItemHeight = 24
        Me.CmbLinea.Location = New System.Drawing.Point(743, 268)
        Me.CmbLinea.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbLinea.Name = "CmbLinea"
        Me.CmbLinea.PromptText = "Lineas"
        Me.CmbLinea.Size = New System.Drawing.Size(251, 30)
        Me.CmbLinea.TabIndex = 95
        Me.CmbLinea.UseSelectable = true
        '
        'CmbFamilia
        '
        Me.CmbFamilia.FormattingEnabled = true
        Me.CmbFamilia.ItemHeight = 24
        Me.CmbFamilia.Location = New System.Drawing.Point(743, 226)
        Me.CmbFamilia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbFamilia.Name = "CmbFamilia"
        Me.CmbFamilia.PromptText = "Familias"
        Me.CmbFamilia.Size = New System.Drawing.Size(251, 30)
        Me.CmbFamilia.TabIndex = 94
        Me.CmbFamilia.UseSelectable = true
        '
        'CmbProveedor
        '
        Me.CmbProveedor.FormattingEnabled = true
        Me.CmbProveedor.ItemHeight = 24
        Me.CmbProveedor.Location = New System.Drawing.Point(212, 309)
        Me.CmbProveedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbProveedor.Name = "CmbProveedor"
        Me.CmbProveedor.PromptText = "Proveedores"
        Me.CmbProveedor.Size = New System.Drawing.Size(380, 30)
        Me.CmbProveedor.TabIndex = 93
        Me.CmbProveedor.UseSelectable = true
        '
        'CmbSubFamilia
        '
        Me.CmbSubFamilia.FormattingEnabled = true
        Me.CmbSubFamilia.ItemHeight = 24
        Me.CmbSubFamilia.Location = New System.Drawing.Point(212, 265)
        Me.CmbSubFamilia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbSubFamilia.Name = "CmbSubFamilia"
        Me.CmbSubFamilia.PromptText = "SubFamilias"
        Me.CmbSubFamilia.Size = New System.Drawing.Size(251, 30)
        Me.CmbSubFamilia.TabIndex = 92
        Me.CmbSubFamilia.UseSelectable = true
        '
        'CmbGrupo
        '
        Me.CmbGrupo.FormattingEnabled = true
        Me.CmbGrupo.ItemHeight = 24
        Me.CmbGrupo.Location = New System.Drawing.Point(212, 220)
        Me.CmbGrupo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbGrupo.Name = "CmbGrupo"
        Me.CmbGrupo.PromptText = "Grupos"
        Me.CmbGrupo.Size = New System.Drawing.Size(251, 30)
        Me.CmbGrupo.TabIndex = 87
        Me.CmbGrupo.UseSelectable = true
        '
        'CmdLinea
        '
        Me.CmdLinea.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.add
        Me.CmdLinea.Location = New System.Drawing.Point(691, 274)
        Me.CmdLinea.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmdLinea.Name = "CmdLinea"
        Me.CmdLinea.Size = New System.Drawing.Size(47, 28)
        Me.CmdLinea.TabIndex = 40
        Me.CmdLinea.UseVisualStyleBackColor = true
        '
        'CmdFamilia
        '
        Me.CmdFamilia.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.add
        Me.CmdFamilia.Location = New System.Drawing.Point(691, 230)
        Me.CmdFamilia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmdFamilia.Name = "CmdFamilia"
        Me.CmdFamilia.Size = New System.Drawing.Size(47, 28)
        Me.CmdFamilia.TabIndex = 39
        Me.CmdFamilia.UseVisualStyleBackColor = true
        '
        'CmdProveedor
        '
        Me.CmdProveedor.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.add
        Me.CmdProveedor.Location = New System.Drawing.Point(161, 313)
        Me.CmdProveedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmdProveedor.Name = "CmdProveedor"
        Me.CmdProveedor.Size = New System.Drawing.Size(47, 28)
        Me.CmdProveedor.TabIndex = 38
        Me.CmdProveedor.UseVisualStyleBackColor = true
        '
        'CmdSubFam
        '
        Me.CmdSubFam.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.add
        Me.CmdSubFam.Location = New System.Drawing.Point(161, 268)
        Me.CmdSubFam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmdSubFam.Name = "CmdSubFam"
        Me.CmdSubFam.Size = New System.Drawing.Size(47, 28)
        Me.CmdSubFam.TabIndex = 37
        Me.CmdSubFam.UseVisualStyleBackColor = true
        '
        'CmdAgrupo
        '
        Me.CmdAgrupo.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.add
        Me.CmdAgrupo.Location = New System.Drawing.Point(161, 224)
        Me.CmdAgrupo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmdAgrupo.Name = "CmdAgrupo"
        Me.CmdAgrupo.Size = New System.Drawing.Size(47, 28)
        Me.CmdAgrupo.TabIndex = 36
        Me.CmdAgrupo.UseVisualStyleBackColor = true
        '
        'txtPrecioP3
        '
        '
        '
        '
        Me.txtPrecioP3.CustomButton.Image = Nothing
        Me.txtPrecioP3.CustomButton.Location = New System.Drawing.Point(169, 2)
        Me.txtPrecioP3.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrecioP3.CustomButton.Name = ""
        Me.txtPrecioP3.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtPrecioP3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrecioP3.CustomButton.TabIndex = 1
        Me.txtPrecioP3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrecioP3.CustomButton.UseSelectable = true
        Me.txtPrecioP3.CustomButton.Visible = false
        Me.txtPrecioP3.Lines = New String(-1) {}
        Me.txtPrecioP3.Location = New System.Drawing.Point(521, 564)
        Me.txtPrecioP3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrecioP3.MaxLength = 32767
        Me.txtPrecioP3.Name = "txtPrecioP3"
        Me.txtPrecioP3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrecioP3.PromptText = "0.00"
        Me.txtPrecioP3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrecioP3.SelectedText = ""
        Me.txtPrecioP3.SelectionLength = 0
        Me.txtPrecioP3.SelectionStart = 0
        Me.txtPrecioP3.ShortcutsEnabled = true
        Me.txtPrecioP3.Size = New System.Drawing.Size(153, 28)
        Me.txtPrecioP3.TabIndex = 103
        Me.txtPrecioP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPrecioP3.UseSelectable = true
        Me.txtPrecioP3.WaterMark = "0.00"
        Me.txtPrecioP3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtPrecioP3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPrecioP2
        '
        '
        '
        '
        Me.txtPrecioP2.CustomButton.Image = Nothing
        Me.txtPrecioP2.CustomButton.Location = New System.Drawing.Point(169, 2)
        Me.txtPrecioP2.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrecioP2.CustomButton.Name = ""
        Me.txtPrecioP2.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtPrecioP2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrecioP2.CustomButton.TabIndex = 1
        Me.txtPrecioP2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrecioP2.CustomButton.UseSelectable = true
        Me.txtPrecioP2.CustomButton.Visible = false
        Me.txtPrecioP2.Lines = New String(-1) {}
        Me.txtPrecioP2.Location = New System.Drawing.Point(521, 528)
        Me.txtPrecioP2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrecioP2.MaxLength = 32767
        Me.txtPrecioP2.Name = "txtPrecioP2"
        Me.txtPrecioP2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrecioP2.PromptText = "0.00"
        Me.txtPrecioP2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrecioP2.SelectedText = ""
        Me.txtPrecioP2.SelectionLength = 0
        Me.txtPrecioP2.SelectionStart = 0
        Me.txtPrecioP2.ShortcutsEnabled = true
        Me.txtPrecioP2.Size = New System.Drawing.Size(153, 28)
        Me.txtPrecioP2.TabIndex = 102
        Me.txtPrecioP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPrecioP2.UseSelectable = true
        Me.txtPrecioP2.WaterMark = "0.00"
        Me.txtPrecioP2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtPrecioP2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPrecioP1
        '
        '
        '
        '
        Me.txtPrecioP1.CustomButton.Image = Nothing
        Me.txtPrecioP1.CustomButton.Location = New System.Drawing.Point(169, 2)
        Me.txtPrecioP1.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrecioP1.CustomButton.Name = ""
        Me.txtPrecioP1.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtPrecioP1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrecioP1.CustomButton.TabIndex = 1
        Me.txtPrecioP1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrecioP1.CustomButton.UseSelectable = true
        Me.txtPrecioP1.CustomButton.Visible = false
        Me.txtPrecioP1.Lines = New String(-1) {}
        Me.txtPrecioP1.Location = New System.Drawing.Point(521, 492)
        Me.txtPrecioP1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrecioP1.MaxLength = 32767
        Me.txtPrecioP1.Name = "txtPrecioP1"
        Me.txtPrecioP1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrecioP1.PromptText = "0.00"
        Me.txtPrecioP1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrecioP1.SelectedText = ""
        Me.txtPrecioP1.SelectionLength = 0
        Me.txtPrecioP1.SelectionStart = 0
        Me.txtPrecioP1.ShortcutsEnabled = true
        Me.txtPrecioP1.Size = New System.Drawing.Size(153, 28)
        Me.txtPrecioP1.TabIndex = 101
        Me.txtPrecioP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPrecioP1.UseSelectable = true
        Me.txtPrecioP1.WaterMark = "0.00"
        Me.txtPrecioP1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtPrecioP1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPrecioPublico
        '
        '
        '
        '
        Me.txtPrecioPublico.CustomButton.Image = Nothing
        Me.txtPrecioPublico.CustomButton.Location = New System.Drawing.Point(169, 2)
        Me.txtPrecioPublico.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrecioPublico.CustomButton.Name = ""
        Me.txtPrecioPublico.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtPrecioPublico.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrecioPublico.CustomButton.TabIndex = 1
        Me.txtPrecioPublico.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrecioPublico.CustomButton.UseSelectable = true
        Me.txtPrecioPublico.CustomButton.Visible = false
        Me.txtPrecioPublico.Lines = New String(-1) {}
        Me.txtPrecioPublico.Location = New System.Drawing.Point(176, 564)
        Me.txtPrecioPublico.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrecioPublico.MaxLength = 32767
        Me.txtPrecioPublico.Name = "txtPrecioPublico"
        Me.txtPrecioPublico.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrecioPublico.PromptText = "0.00"
        Me.txtPrecioPublico.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrecioPublico.SelectedText = ""
        Me.txtPrecioPublico.SelectionLength = 0
        Me.txtPrecioPublico.SelectionStart = 0
        Me.txtPrecioPublico.ShortcutsEnabled = true
        Me.txtPrecioPublico.Size = New System.Drawing.Size(153, 28)
        Me.txtPrecioPublico.TabIndex = 100
        Me.txtPrecioPublico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPrecioPublico.UseSelectable = true
        Me.txtPrecioPublico.WaterMark = "0.00"
        Me.txtPrecioPublico.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtPrecioPublico.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPrecioCosto
        '
        '
        '
        '
        Me.txtPrecioCosto.CustomButton.Image = Nothing
        Me.txtPrecioCosto.CustomButton.Location = New System.Drawing.Point(169, 2)
        Me.txtPrecioCosto.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrecioCosto.CustomButton.Name = ""
        Me.txtPrecioCosto.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtPrecioCosto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrecioCosto.CustomButton.TabIndex = 1
        Me.txtPrecioCosto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrecioCosto.CustomButton.UseSelectable = true
        Me.txtPrecioCosto.CustomButton.Visible = false
        Me.txtPrecioCosto.Lines = New String(-1) {}
        Me.txtPrecioCosto.Location = New System.Drawing.Point(176, 528)
        Me.txtPrecioCosto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrecioCosto.MaxLength = 32767
        Me.txtPrecioCosto.Name = "txtPrecioCosto"
        Me.txtPrecioCosto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrecioCosto.PromptText = "0.00"
        Me.txtPrecioCosto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrecioCosto.SelectedText = ""
        Me.txtPrecioCosto.SelectionLength = 0
        Me.txtPrecioCosto.SelectionStart = 0
        Me.txtPrecioCosto.ShortcutsEnabled = true
        Me.txtPrecioCosto.Size = New System.Drawing.Size(153, 28)
        Me.txtPrecioCosto.TabIndex = 99
        Me.txtPrecioCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPrecioCosto.UseSelectable = true
        Me.txtPrecioCosto.WaterMark = "0.00"
        Me.txtPrecioCosto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtPrecioCosto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPrecioLista
        '
        '
        '
        '
        Me.txtPrecioLista.CustomButton.Image = Nothing
        Me.txtPrecioLista.CustomButton.Location = New System.Drawing.Point(169, 2)
        Me.txtPrecioLista.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrecioLista.CustomButton.Name = ""
        Me.txtPrecioLista.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtPrecioLista.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrecioLista.CustomButton.TabIndex = 1
        Me.txtPrecioLista.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrecioLista.CustomButton.UseSelectable = true
        Me.txtPrecioLista.CustomButton.Visible = false
        Me.txtPrecioLista.Lines = New String(-1) {}
        Me.txtPrecioLista.Location = New System.Drawing.Point(176, 492)
        Me.txtPrecioLista.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrecioLista.MaxLength = 32767
        Me.txtPrecioLista.Name = "txtPrecioLista"
        Me.txtPrecioLista.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrecioLista.PromptText = "0.00"
        Me.txtPrecioLista.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrecioLista.SelectedText = ""
        Me.txtPrecioLista.SelectionLength = 0
        Me.txtPrecioLista.SelectionStart = 0
        Me.txtPrecioLista.ShortcutsEnabled = true
        Me.txtPrecioLista.Size = New System.Drawing.Size(153, 28)
        Me.txtPrecioLista.TabIndex = 98
        Me.txtPrecioLista.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPrecioLista.UseSelectable = true
        Me.txtPrecioLista.WaterMark = "0.00"
        Me.txtPrecioLista.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtPrecioLista.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'txtClaveProducto
        '
        Me.txtClaveProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtClaveProducto.CustomButton.Image = Nothing
        Me.txtClaveProducto.CustomButton.Location = New System.Drawing.Point(259, 2)
        Me.txtClaveProducto.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtClaveProducto.CustomButton.Name = ""
        Me.txtClaveProducto.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtClaveProducto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtClaveProducto.CustomButton.TabIndex = 1
        Me.txtClaveProducto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtClaveProducto.CustomButton.UseSelectable = true
        Me.txtClaveProducto.CustomButton.Visible = false
        Me.txtClaveProducto.Lines = New String(-1) {}
        Me.txtClaveProducto.Location = New System.Drawing.Point(212, 353)
        Me.txtClaveProducto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtClaveProducto.MaxLength = 32767
        Me.txtClaveProducto.Name = "txtClaveProducto"
        Me.txtClaveProducto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtClaveProducto.PromptText = "Clave Producto"
        Me.txtClaveProducto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtClaveProducto.SelectedText = ""
        Me.txtClaveProducto.SelectionLength = 0
        Me.txtClaveProducto.SelectionStart = 0
        Me.txtClaveProducto.ShortcutsEnabled = true
        Me.txtClaveProducto.Size = New System.Drawing.Size(220, 28)
        Me.txtClaveProducto.TabIndex = 103
        Me.txtClaveProducto.UseSelectable = true
        Me.txtClaveProducto.WaterMark = "Clave Producto"
        Me.txtClaveProducto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtClaveProducto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtClaveUnidad
        '
        Me.txtClaveUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtClaveUnidad.CustomButton.Image = Nothing
        Me.txtClaveUnidad.CustomButton.Location = New System.Drawing.Point(301, 2)
        Me.txtClaveUnidad.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtClaveUnidad.CustomButton.Name = ""
        Me.txtClaveUnidad.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtClaveUnidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtClaveUnidad.CustomButton.TabIndex = 1
        Me.txtClaveUnidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtClaveUnidad.CustomButton.UseSelectable = true
        Me.txtClaveUnidad.CustomButton.Visible = false
        Me.txtClaveUnidad.Lines = New String(-1) {}
        Me.txtClaveUnidad.Location = New System.Drawing.Point(743, 352)
        Me.txtClaveUnidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtClaveUnidad.MaxLength = 32767
        Me.txtClaveUnidad.Name = "txtClaveUnidad"
        Me.txtClaveUnidad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtClaveUnidad.PromptText = "Clave Unidad"
        Me.txtClaveUnidad.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtClaveUnidad.SelectedText = ""
        Me.txtClaveUnidad.SelectionLength = 0
        Me.txtClaveUnidad.SelectionStart = 0
        Me.txtClaveUnidad.ShortcutsEnabled = true
        Me.txtClaveUnidad.Size = New System.Drawing.Size(252, 28)
        Me.txtClaveUnidad.TabIndex = 104
        Me.txtClaveUnidad.UseSelectable = true
        Me.txtClaveUnidad.WaterMark = "Clave Unidad"
        Me.txtClaveUnidad.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtClaveUnidad.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDesc
        '
        '
        '
        '
        Me.txtDesc.CustomButton.Image = Nothing
        Me.txtDesc.CustomButton.Location = New System.Drawing.Point(108, 2)
        Me.txtDesc.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDesc.CustomButton.Name = ""
        Me.txtDesc.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDesc.CustomButton.TabIndex = 1
        Me.txtDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDesc.CustomButton.UseSelectable = true
        Me.txtDesc.CustomButton.Visible = false
        Me.txtDesc.Lines = New String() {"0"}
        Me.txtDesc.Location = New System.Drawing.Point(677, 146)
        Me.txtDesc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDesc.MaxLength = 32767
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDesc.PromptText = "0"
        Me.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDesc.SelectedText = ""
        Me.txtDesc.SelectionLength = 0
        Me.txtDesc.SelectionStart = 0
        Me.txtDesc.ShortcutsEnabled = true
        Me.txtDesc.Size = New System.Drawing.Size(107, 28)
        Me.txtDesc.TabIndex = 103
        Me.txtDesc.Text = "0"
        Me.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDesc.UseSelectable = true
        Me.txtDesc.WaterMark = "0"
        Me.txtDesc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtDesc.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtStock
        '
        '
        '
        '
        Me.txtStock.CustomButton.Image = Nothing
        Me.txtStock.CustomButton.Location = New System.Drawing.Point(108, 2)
        Me.txtStock.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtStock.CustomButton.Name = ""
        Me.txtStock.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.txtStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtStock.CustomButton.TabIndex = 1
        Me.txtStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtStock.CustomButton.UseSelectable = true
        Me.txtStock.CustomButton.Visible = false
        Me.txtStock.Lines = New String() {"0"}
        Me.txtStock.Location = New System.Drawing.Point(888, 146)
        Me.txtStock.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtStock.MaxLength = 32767
        Me.txtStock.Name = "txtStock"
        Me.txtStock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStock.PromptText = "0"
        Me.txtStock.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtStock.SelectedText = ""
        Me.txtStock.SelectionLength = 0
        Me.txtStock.SelectionStart = 0
        Me.txtStock.ShortcutsEnabled = true
        Me.txtStock.Size = New System.Drawing.Size(107, 28)
        Me.txtStock.TabIndex = 104
        Me.txtStock.Text = "0"
        Me.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtStock.UseSelectable = true
        Me.txtStock.WaterMark = "0"
        Me.txtStock.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtStock.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'chkPrecioManual
        '
        Me.chkPrecioManual.AutoSize = true
        Me.chkPrecioManual.Location = New System.Drawing.Point(863, 78)
        Me.chkPrecioManual.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkPrecioManual.Name = "chkPrecioManual"
        Me.chkPrecioManual.Size = New System.Drawing.Size(107, 17)
        Me.chkPrecioManual.TabIndex = 105
        Me.chkPrecioManual.Text = "Precio Manual"
        Me.chkPrecioManual.UseSelectable = true
        '
        'chkTasaCero
        '
        Me.chkTasaCero.AutoSize = true
        Me.chkTasaCero.Location = New System.Drawing.Point(863, 103)
        Me.chkTasaCero.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkTasaCero.Name = "chkTasaCero"
        Me.chkTasaCero.Size = New System.Drawing.Size(72, 17)
        Me.chkTasaCero.TabIndex = 106
        Me.chkTasaCero.Text = "Tasa 0%"
        Me.chkTasaCero.UseSelectable = true
        '
        'chkTC
        '
        Me.chkTC.AutoSize = true
        Me.chkTC.Location = New System.Drawing.Point(32, 466)
        Me.chkTC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkTC.Name = "chkTC"
        Me.chkTC.Size = New System.Drawing.Size(149, 17)
        Me.chkTC.TabIndex = 107
        Me.chkTC.Text = "Usar Tipo de Cambio"
        Me.chkTC.UseSelectable = true
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = true
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(32, 78)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(86, 20)
        Me.MetroLabel1.TabIndex = 108
        Me.MetroLabel1.Text = "Id Producto"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = true
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(32, 114)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(124, 20)
        Me.MetroLabel2.TabIndex = 109
        Me.MetroLabel2.Text = "Código de Barras"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = true
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(32, 151)
        Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(45, 20)
        Me.MetroLabel3.TabIndex = 110
        Me.MetroLabel3.Text = "Clave"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = true
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(32, 188)
        Me.MetroLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(87, 20)
        Me.MetroLabel4.TabIndex = 111
        Me.MetroLabel4.Text = "Descripción"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = true
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(32, 233)
        Me.MetroLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(50, 20)
        Me.MetroLabel5.TabIndex = 112
        Me.MetroLabel5.Text = "Grupo"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = true
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel6.Location = New System.Drawing.Point(31, 277)
        Me.MetroLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(81, 20)
        Me.MetroLabel6.TabIndex = 113
        Me.MetroLabel6.Text = "SubFamilia"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = true
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel7.Location = New System.Drawing.Point(32, 321)
        Me.MetroLabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(77, 20)
        Me.MetroLabel7.TabIndex = 114
        Me.MetroLabel7.Text = "Proveedor"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = true
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel8.Location = New System.Drawing.Point(32, 358)
        Me.MetroLabel8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(109, 20)
        Me.MetroLabel8.TabIndex = 115
        Me.MetroLabel8.Text = "Clave Producto"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = true
        Me.MetroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel9.Location = New System.Drawing.Point(616, 353)
        Me.MetroLabel9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(97, 20)
        Me.MetroLabel9.TabIndex = 116
        Me.MetroLabel9.Text = "Clave Unidad"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = true
        Me.MetroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel10.Location = New System.Drawing.Point(616, 235)
        Me.MetroLabel10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(56, 20)
        Me.MetroLabel10.TabIndex = 117
        Me.MetroLabel10.Text = "Familia"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = true
        Me.MetroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel11.Location = New System.Drawing.Point(616, 274)
        Me.MetroLabel11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(44, 20)
        Me.MetroLabel11.TabIndex = 118
        Me.MetroLabel11.Text = "Linea"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = true
        Me.MetroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel12.Location = New System.Drawing.Point(788, 190)
        Me.MetroLabel12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(57, 20)
        Me.MetroLabel12.TabIndex = 119
        Me.MetroLabel12.Text = "Unidad"
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = true
        Me.MetroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel13.Location = New System.Drawing.Point(616, 314)
        Me.MetroLabel13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(80, 20)
        Me.MetroLabel13.TabIndex = 120
        Me.MetroLabel13.Text = "Tipo Venta"
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = true
        Me.MetroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel14.Location = New System.Drawing.Point(464, 146)
        Me.MetroLabel14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(163, 20)
        Me.MetroLabel14.TabIndex = 121
        Me.MetroLabel14.Text = "Descuento (0% - 100%)"
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = true
        Me.MetroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel15.Location = New System.Drawing.Point(824, 146)
        Me.MetroLabel15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(45, 20)
        Me.MetroLabel15.TabIndex = 122
        Me.MetroLabel15.Text = "Stock"
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = true
        Me.MetroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel16.Location = New System.Drawing.Point(32, 497)
        Me.MetroLabel16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(84, 20)
        Me.MetroLabel16.TabIndex = 123
        Me.MetroLabel16.Text = "Precio Lista"
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = true
        Me.MetroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel17.Location = New System.Drawing.Point(32, 533)
        Me.MetroLabel17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(92, 20)
        Me.MetroLabel17.TabIndex = 124
        Me.MetroLabel17.Text = "Precio Costo"
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = true
        Me.MetroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel18.Location = New System.Drawing.Point(32, 569)
        Me.MetroLabel18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(103, 20)
        Me.MetroLabel18.TabIndex = 125
        Me.MetroLabel18.Text = "Precio Público"
        '
        'MetroLabel19
        '
        Me.MetroLabel19.AutoSize = true
        Me.MetroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel19.Location = New System.Drawing.Point(415, 497)
        Me.MetroLabel19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(70, 20)
        Me.MetroLabel19.TabIndex = 126
        Me.MetroLabel19.Text = "Precio P1"
        '
        'MetroLabel20
        '
        Me.MetroLabel20.AutoSize = true
        Me.MetroLabel20.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel20.Location = New System.Drawing.Point(415, 533)
        Me.MetroLabel20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel20.Name = "MetroLabel20"
        Me.MetroLabel20.Size = New System.Drawing.Size(70, 20)
        Me.MetroLabel20.TabIndex = 127
        Me.MetroLabel20.Text = "Precio P2"
        '
        'MetroLabel21
        '
        Me.MetroLabel21.AutoSize = true
        Me.MetroLabel21.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel21.Location = New System.Drawing.Point(415, 569)
        Me.MetroLabel21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel21.Name = "MetroLabel21"
        Me.MetroLabel21.Size = New System.Drawing.Size(70, 20)
        Me.MetroLabel21.TabIndex = 128
        Me.MetroLabel21.Text = "Precio P3"
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.Location = New System.Drawing.Point(32, 404)
        Me.MetroTile1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(963, 55)
        Me.MetroTile1.TabIndex = 129
        Me.MetroTile1.Text = "Precios"
        Me.MetroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile1.UseSelectable = true
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.close_window_16px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(895, 569)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 131
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = true
        '
        'btnGuardar
        '
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47,Byte),Integer), CType(CType(170,Byte),Integer), CType(CType(141,Byte),Integer))
        Me.btnGuardar.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.save_16px
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(895, 501)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 28)
        Me.btnGuardar.TabIndex = 130
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.UseVisualStyleBackColor = true
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.ForeColor = System.Drawing.Color.Red
        Me.btnEliminar.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.trash_can_16px
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.Location = New System.Drawing.Point(895, 535)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 28)
        Me.btnEliminar.TabIndex = 132
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.UseVisualStyleBackColor = true
        '
        'FrmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(1021, 643)
        Me.ControlBox = false
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.MetroTile1)
        Me.Controls.Add(Me.MetroLabel21)
        Me.Controls.Add(Me.MetroLabel20)
        Me.Controls.Add(Me.MetroLabel19)
        Me.Controls.Add(Me.MetroLabel18)
        Me.Controls.Add(Me.MetroLabel17)
        Me.Controls.Add(Me.MetroLabel16)
        Me.Controls.Add(Me.MetroLabel15)
        Me.Controls.Add(Me.MetroLabel14)
        Me.Controls.Add(Me.MetroLabel13)
        Me.Controls.Add(Me.MetroLabel12)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.chkTC)
        Me.Controls.Add(Me.txtPrecioP3)
        Me.Controls.Add(Me.txtClaveUnidad)
        Me.Controls.Add(Me.txtPrecioP2)
        Me.Controls.Add(Me.txtPrecioP1)
        Me.Controls.Add(Me.txtPrecioPublico)
        Me.Controls.Add(Me.txtClaveProducto)
        Me.Controls.Add(Me.txtPrecioCosto)
        Me.Controls.Add(Me.txtPrecioLista)
        Me.Controls.Add(Me.chkTasaCero)
        Me.Controls.Add(Me.chkPrecioManual)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.CmbTipoVenta)
        Me.Controls.Add(Me.CmbUnidad)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.CmbLinea)
        Me.Controls.Add(Me.txtIdProducto)
        Me.Controls.Add(Me.CmbFamilia)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.CmdLinea)
        Me.Controls.Add(Me.txtCodigoBarras)
        Me.Controls.Add(Me.CmdFamilia)
        Me.Controls.Add(Me.CmbProveedor)
        Me.Controls.Add(Me.CmdAgrupo)
        Me.Controls.Add(Me.CmbSubFamilia)
        Me.Controls.Add(Me.CmdSubFam)
        Me.Controls.Add(Me.CmbGrupo)
        Me.Controls.Add(Me.CmdProveedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = true
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = false
        Me.Name = "FrmProductos"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Text = "Datos del Producto"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents CmdAgrupo As System.Windows.Forms.Button
    Friend WithEvents CmdSubFam As System.Windows.Forms.Button
    Friend WithEvents CmdLinea As System.Windows.Forms.Button
    Friend WithEvents CmdFamilia As System.Windows.Forms.Button
    Friend WithEvents CmdProveedor As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblObligatorio As System.Windows.Forms.Label
    Friend WithEvents lblAsterisco3 As System.Windows.Forms.Label
    Friend WithEvents lblAsterisco As System.Windows.Forms.Label
    Friend WithEvents lblAsterisco2 As System.Windows.Forms.Label
    Friend WithEvents lblAsterisco4 As System.Windows.Forms.Label
    Friend WithEvents lblAsterisco7 As System.Windows.Forms.Label
    Friend WithEvents lblAsterisco6 As System.Windows.Forms.Label
    Friend WithEvents lblAsterisco5 As System.Windows.Forms.Label
    Friend WithEvents lblAsterisco8 As System.Windows.Forms.Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents CmbGrupo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents CmbTipoVenta As MetroFramework.Controls.MetroComboBox
    Friend WithEvents CmbUnidad As MetroFramework.Controls.MetroComboBox
    Friend WithEvents CmbLinea As MetroFramework.Controls.MetroComboBox
    Friend WithEvents CmbFamilia As MetroFramework.Controls.MetroComboBox
    Friend WithEvents CmbProveedor As MetroFramework.Controls.MetroComboBox
    Friend WithEvents CmbSubFamilia As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtPrecioP3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPrecioP2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPrecioP1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPrecioPublico As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPrecioCosto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPrecioLista As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDescripcion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtClave As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCodigoBarras As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtIdProducto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtStock As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDesc As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtClaveUnidad As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtClaveProducto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel18 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel19 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel20 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel21 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents chkPrecioManual As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkTC As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkTasaCero As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEliminar As Button
End Class
