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
    <System.Diagnostics.DebuggerStepThrough()>
    <Obsolete>
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
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtDescripcion.CustomButton.Image = Nothing
        Me.txtDescripcion.CustomButton.Location = New System.Drawing.Point(279, 1)
        Me.txtDescripcion.CustomButton.Name = ""
        Me.txtDescripcion.CustomButton.Size = New System.Drawing.Size(16, 17)
        Me.txtDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDescripcion.CustomButton.TabIndex = 1
        Me.txtDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDescripcion.CustomButton.UseSelectable = True
        Me.txtDescripcion.CustomButton.Visible = False
        Me.txtDescripcion.Lines = New String(-1) {}
        Me.txtDescripcion.Location = New System.Drawing.Point(159, 149)
        Me.txtDescripcion.MaxLength = 32767
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.PromptText = "Descripción"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescripcion.SelectedText = ""
        Me.txtDescripcion.SelectionLength = 0
        Me.txtDescripcion.SelectionStart = 0
        Me.txtDescripcion.ShortcutsEnabled = True
        Me.txtDescripcion.Size = New System.Drawing.Size(394, 23)
        Me.txtDescripcion.TabIndex = 102
        Me.txtDescripcion.UseSelectable = True
        Me.txtDescripcion.WaterMark = "Descripción"
        Me.txtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDescripcion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtClave
        '
        Me.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtClave.CustomButton.Image = Nothing
        Me.txtClave.CustomButton.Location = New System.Drawing.Point(107, 1)
        Me.txtClave.CustomButton.Name = ""
        Me.txtClave.CustomButton.Size = New System.Drawing.Size(16, 17)
        Me.txtClave.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtClave.CustomButton.TabIndex = 1
        Me.txtClave.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtClave.CustomButton.UseSelectable = True
        Me.txtClave.CustomButton.Visible = False
        Me.txtClave.Lines = New String(-1) {}
        Me.txtClave.Location = New System.Drawing.Point(159, 119)
        Me.txtClave.MaxLength = 32767
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtClave.PromptText = "Clave"
        Me.txtClave.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtClave.SelectedText = ""
        Me.txtClave.SelectionLength = 0
        Me.txtClave.SelectionStart = 0
        Me.txtClave.ShortcutsEnabled = True
        Me.txtClave.Size = New System.Drawing.Size(165, 23)
        Me.txtClave.TabIndex = 101
        Me.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtClave.UseSelectable = True
        Me.txtClave.WaterMark = "Clave"
        Me.txtClave.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtClave.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtCodigoBarras.CustomButton.Image = Nothing
        Me.txtCodigoBarras.CustomButton.Location = New System.Drawing.Point(107, 1)
        Me.txtCodigoBarras.CustomButton.Name = ""
        Me.txtCodigoBarras.CustomButton.Size = New System.Drawing.Size(16, 17)
        Me.txtCodigoBarras.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCodigoBarras.CustomButton.TabIndex = 1
        Me.txtCodigoBarras.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCodigoBarras.CustomButton.UseSelectable = True
        Me.txtCodigoBarras.CustomButton.Visible = False
        Me.txtCodigoBarras.Lines = New String(-1) {}
        Me.txtCodigoBarras.Location = New System.Drawing.Point(159, 89)
        Me.txtCodigoBarras.MaxLength = 32767
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodigoBarras.PromptText = "Código de Barras"
        Me.txtCodigoBarras.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCodigoBarras.SelectedText = ""
        Me.txtCodigoBarras.SelectionLength = 0
        Me.txtCodigoBarras.SelectionStart = 0
        Me.txtCodigoBarras.ShortcutsEnabled = True
        Me.txtCodigoBarras.Size = New System.Drawing.Size(165, 23)
        Me.txtCodigoBarras.TabIndex = 100
        Me.txtCodigoBarras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCodigoBarras.UseSelectable = True
        Me.txtCodigoBarras.WaterMark = "Código de Barras"
        Me.txtCodigoBarras.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCodigoBarras.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtIdProducto
        '
        '
        '
        '
        Me.txtIdProducto.CustomButton.Image = Nothing
        Me.txtIdProducto.CustomButton.Location = New System.Drawing.Point(44, 1)
        Me.txtIdProducto.CustomButton.Name = ""
        Me.txtIdProducto.CustomButton.Size = New System.Drawing.Size(16, 17)
        Me.txtIdProducto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtIdProducto.CustomButton.TabIndex = 1
        Me.txtIdProducto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtIdProducto.CustomButton.UseSelectable = True
        Me.txtIdProducto.CustomButton.Visible = False
        Me.txtIdProducto.Enabled = False
        Me.txtIdProducto.Lines = New String(-1) {}
        Me.txtIdProducto.Location = New System.Drawing.Point(159, 59)
        Me.txtIdProducto.MaxLength = 32767
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdProducto.PromptText = "0"
        Me.txtIdProducto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIdProducto.SelectedText = ""
        Me.txtIdProducto.SelectionLength = 0
        Me.txtIdProducto.SelectionStart = 0
        Me.txtIdProducto.ShortcutsEnabled = True
        Me.txtIdProducto.Size = New System.Drawing.Size(80, 23)
        Me.txtIdProducto.TabIndex = 99
        Me.txtIdProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtIdProducto.UseSelectable = True
        Me.txtIdProducto.WaterMark = "0"
        Me.txtIdProducto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtIdProducto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'CmbTipoVenta
        '
        Me.CmbTipoVenta.FormattingEnabled = True
        Me.CmbTipoVenta.ItemHeight = 23
        Me.CmbTipoVenta.Items.AddRange(New Object() {"PIEZA", "GRANEL"})
        Me.CmbTipoVenta.Location = New System.Drawing.Point(557, 252)
        Me.CmbTipoVenta.Name = "CmbTipoVenta"
        Me.CmbTipoVenta.PromptText = "Tipo Venta"
        Me.CmbTipoVenta.Size = New System.Drawing.Size(189, 29)
        Me.CmbTipoVenta.TabIndex = 97
        Me.CmbTipoVenta.UseSelectable = True
        '
        'CmbUnidad
        '
        Me.CmbUnidad.FormattingEnabled = True
        Me.CmbUnidad.ItemHeight = 23
        Me.CmbUnidad.Location = New System.Drawing.Point(649, 149)
        Me.CmbUnidad.Name = "CmbUnidad"
        Me.CmbUnidad.PromptText = "UoM"
        Me.CmbUnidad.Size = New System.Drawing.Size(97, 29)
        Me.CmbUnidad.TabIndex = 96
        Me.CmbUnidad.UseSelectable = True
        '
        'CmbLinea
        '
        Me.CmbLinea.FormattingEnabled = True
        Me.CmbLinea.ItemHeight = 23
        Me.CmbLinea.Location = New System.Drawing.Point(557, 218)
        Me.CmbLinea.Name = "CmbLinea"
        Me.CmbLinea.PromptText = "Lineas"
        Me.CmbLinea.Size = New System.Drawing.Size(189, 29)
        Me.CmbLinea.TabIndex = 95
        Me.CmbLinea.UseSelectable = True
        '
        'CmbFamilia
        '
        Me.CmbFamilia.FormattingEnabled = True
        Me.CmbFamilia.ItemHeight = 23
        Me.CmbFamilia.Location = New System.Drawing.Point(557, 184)
        Me.CmbFamilia.Name = "CmbFamilia"
        Me.CmbFamilia.PromptText = "Familias"
        Me.CmbFamilia.Size = New System.Drawing.Size(189, 29)
        Me.CmbFamilia.TabIndex = 94
        Me.CmbFamilia.UseSelectable = True
        '
        'CmbProveedor
        '
        Me.CmbProveedor.FormattingEnabled = True
        Me.CmbProveedor.ItemHeight = 23
        Me.CmbProveedor.Location = New System.Drawing.Point(159, 251)
        Me.CmbProveedor.Name = "CmbProveedor"
        Me.CmbProveedor.PromptText = "Proveedores"
        Me.CmbProveedor.Size = New System.Drawing.Size(286, 29)
        Me.CmbProveedor.TabIndex = 93
        Me.CmbProveedor.UseSelectable = True
        '
        'CmbSubFamilia
        '
        Me.CmbSubFamilia.FormattingEnabled = True
        Me.CmbSubFamilia.ItemHeight = 23
        Me.CmbSubFamilia.Location = New System.Drawing.Point(159, 215)
        Me.CmbSubFamilia.Name = "CmbSubFamilia"
        Me.CmbSubFamilia.PromptText = "SubFamilias"
        Me.CmbSubFamilia.Size = New System.Drawing.Size(189, 29)
        Me.CmbSubFamilia.TabIndex = 92
        Me.CmbSubFamilia.UseSelectable = True
        '
        'CmbGrupo
        '
        Me.CmbGrupo.FormattingEnabled = True
        Me.CmbGrupo.ItemHeight = 23
        Me.CmbGrupo.Location = New System.Drawing.Point(159, 179)
        Me.CmbGrupo.Name = "CmbGrupo"
        Me.CmbGrupo.PromptText = "Grupos"
        Me.CmbGrupo.Size = New System.Drawing.Size(189, 29)
        Me.CmbGrupo.TabIndex = 87
        Me.CmbGrupo.UseSelectable = True
        '
        'CmdLinea
        '
        Me.CmdLinea.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.add
        Me.CmdLinea.Location = New System.Drawing.Point(518, 223)
        Me.CmdLinea.Name = "CmdLinea"
        Me.CmdLinea.Size = New System.Drawing.Size(35, 23)
        Me.CmdLinea.TabIndex = 40
        Me.CmdLinea.UseVisualStyleBackColor = True
        '
        'CmdFamilia
        '
        Me.CmdFamilia.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.add
        Me.CmdFamilia.Location = New System.Drawing.Point(518, 187)
        Me.CmdFamilia.Name = "CmdFamilia"
        Me.CmdFamilia.Size = New System.Drawing.Size(35, 23)
        Me.CmdFamilia.TabIndex = 39
        Me.CmdFamilia.UseVisualStyleBackColor = True
        '
        'CmdProveedor
        '
        Me.CmdProveedor.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.add
        Me.CmdProveedor.Location = New System.Drawing.Point(121, 254)
        Me.CmdProveedor.Name = "CmdProveedor"
        Me.CmdProveedor.Size = New System.Drawing.Size(35, 23)
        Me.CmdProveedor.TabIndex = 38
        Me.CmdProveedor.UseVisualStyleBackColor = True
        '
        'CmdSubFam
        '
        Me.CmdSubFam.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.add
        Me.CmdSubFam.Location = New System.Drawing.Point(121, 218)
        Me.CmdSubFam.Name = "CmdSubFam"
        Me.CmdSubFam.Size = New System.Drawing.Size(35, 23)
        Me.CmdSubFam.TabIndex = 37
        Me.CmdSubFam.UseVisualStyleBackColor = True
        '
        'CmdAgrupo
        '
        Me.CmdAgrupo.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.add
        Me.CmdAgrupo.Location = New System.Drawing.Point(121, 182)
        Me.CmdAgrupo.Name = "CmdAgrupo"
        Me.CmdAgrupo.Size = New System.Drawing.Size(35, 23)
        Me.CmdAgrupo.TabIndex = 36
        Me.CmdAgrupo.UseVisualStyleBackColor = True
        '
        'txtPrecioP3
        '
        '
        '
        '
        Me.txtPrecioP3.CustomButton.Image = Nothing
        Me.txtPrecioP3.CustomButton.Location = New System.Drawing.Point(70, 1)
        Me.txtPrecioP3.CustomButton.Name = ""
        Me.txtPrecioP3.CustomButton.Size = New System.Drawing.Size(16, 17)
        Me.txtPrecioP3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrecioP3.CustomButton.TabIndex = 1
        Me.txtPrecioP3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrecioP3.CustomButton.UseSelectable = True
        Me.txtPrecioP3.CustomButton.Visible = False
        Me.txtPrecioP3.Lines = New String(-1) {}
        Me.txtPrecioP3.Location = New System.Drawing.Point(391, 458)
        Me.txtPrecioP3.MaxLength = 32767
        Me.txtPrecioP3.Name = "txtPrecioP3"
        Me.txtPrecioP3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrecioP3.PromptText = "0.00"
        Me.txtPrecioP3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrecioP3.SelectedText = ""
        Me.txtPrecioP3.SelectionLength = 0
        Me.txtPrecioP3.SelectionStart = 0
        Me.txtPrecioP3.ShortcutsEnabled = True
        Me.txtPrecioP3.Size = New System.Drawing.Size(115, 23)
        Me.txtPrecioP3.TabIndex = 103
        Me.txtPrecioP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPrecioP3.UseSelectable = True
        Me.txtPrecioP3.WaterMark = "0.00"
        Me.txtPrecioP3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPrecioP3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPrecioP2
        '
        '
        '
        '
        Me.txtPrecioP2.CustomButton.Image = Nothing
        Me.txtPrecioP2.CustomButton.Location = New System.Drawing.Point(70, 1)
        Me.txtPrecioP2.CustomButton.Name = ""
        Me.txtPrecioP2.CustomButton.Size = New System.Drawing.Size(16, 17)
        Me.txtPrecioP2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrecioP2.CustomButton.TabIndex = 1
        Me.txtPrecioP2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrecioP2.CustomButton.UseSelectable = True
        Me.txtPrecioP2.CustomButton.Visible = False
        Me.txtPrecioP2.Lines = New String(-1) {}
        Me.txtPrecioP2.Location = New System.Drawing.Point(391, 429)
        Me.txtPrecioP2.MaxLength = 32767
        Me.txtPrecioP2.Name = "txtPrecioP2"
        Me.txtPrecioP2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrecioP2.PromptText = "0.00"
        Me.txtPrecioP2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrecioP2.SelectedText = ""
        Me.txtPrecioP2.SelectionLength = 0
        Me.txtPrecioP2.SelectionStart = 0
        Me.txtPrecioP2.ShortcutsEnabled = True
        Me.txtPrecioP2.Size = New System.Drawing.Size(115, 23)
        Me.txtPrecioP2.TabIndex = 102
        Me.txtPrecioP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPrecioP2.UseSelectable = True
        Me.txtPrecioP2.WaterMark = "0.00"
        Me.txtPrecioP2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPrecioP2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPrecioP1
        '
        '
        '
        '
        Me.txtPrecioP1.CustomButton.Image = Nothing
        Me.txtPrecioP1.CustomButton.Location = New System.Drawing.Point(70, 1)
        Me.txtPrecioP1.CustomButton.Name = ""
        Me.txtPrecioP1.CustomButton.Size = New System.Drawing.Size(16, 17)
        Me.txtPrecioP1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrecioP1.CustomButton.TabIndex = 1
        Me.txtPrecioP1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrecioP1.CustomButton.UseSelectable = True
        Me.txtPrecioP1.CustomButton.Visible = False
        Me.txtPrecioP1.Lines = New String(-1) {}
        Me.txtPrecioP1.Location = New System.Drawing.Point(391, 400)
        Me.txtPrecioP1.MaxLength = 32767
        Me.txtPrecioP1.Name = "txtPrecioP1"
        Me.txtPrecioP1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrecioP1.PromptText = "0.00"
        Me.txtPrecioP1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrecioP1.SelectedText = ""
        Me.txtPrecioP1.SelectionLength = 0
        Me.txtPrecioP1.SelectionStart = 0
        Me.txtPrecioP1.ShortcutsEnabled = True
        Me.txtPrecioP1.Size = New System.Drawing.Size(115, 23)
        Me.txtPrecioP1.TabIndex = 101
        Me.txtPrecioP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPrecioP1.UseSelectable = True
        Me.txtPrecioP1.WaterMark = "0.00"
        Me.txtPrecioP1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPrecioP1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPrecioPublico
        '
        '
        '
        '
        Me.txtPrecioPublico.CustomButton.Image = Nothing
        Me.txtPrecioPublico.CustomButton.Location = New System.Drawing.Point(70, 1)
        Me.txtPrecioPublico.CustomButton.Name = ""
        Me.txtPrecioPublico.CustomButton.Size = New System.Drawing.Size(16, 17)
        Me.txtPrecioPublico.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrecioPublico.CustomButton.TabIndex = 1
        Me.txtPrecioPublico.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrecioPublico.CustomButton.UseSelectable = True
        Me.txtPrecioPublico.CustomButton.Visible = False
        Me.txtPrecioPublico.Lines = New String(-1) {}
        Me.txtPrecioPublico.Location = New System.Drawing.Point(132, 458)
        Me.txtPrecioPublico.MaxLength = 32767
        Me.txtPrecioPublico.Name = "txtPrecioPublico"
        Me.txtPrecioPublico.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrecioPublico.PromptText = "0.00"
        Me.txtPrecioPublico.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrecioPublico.SelectedText = ""
        Me.txtPrecioPublico.SelectionLength = 0
        Me.txtPrecioPublico.SelectionStart = 0
        Me.txtPrecioPublico.ShortcutsEnabled = True
        Me.txtPrecioPublico.Size = New System.Drawing.Size(115, 23)
        Me.txtPrecioPublico.TabIndex = 100
        Me.txtPrecioPublico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPrecioPublico.UseSelectable = True
        Me.txtPrecioPublico.WaterMark = "0.00"
        Me.txtPrecioPublico.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPrecioPublico.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPrecioCosto
        '
        '
        '
        '
        Me.txtPrecioCosto.CustomButton.Image = Nothing
        Me.txtPrecioCosto.CustomButton.Location = New System.Drawing.Point(70, 1)
        Me.txtPrecioCosto.CustomButton.Name = ""
        Me.txtPrecioCosto.CustomButton.Size = New System.Drawing.Size(16, 17)
        Me.txtPrecioCosto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrecioCosto.CustomButton.TabIndex = 1
        Me.txtPrecioCosto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrecioCosto.CustomButton.UseSelectable = True
        Me.txtPrecioCosto.CustomButton.Visible = False
        Me.txtPrecioCosto.Lines = New String(-1) {}
        Me.txtPrecioCosto.Location = New System.Drawing.Point(132, 429)
        Me.txtPrecioCosto.MaxLength = 32767
        Me.txtPrecioCosto.Name = "txtPrecioCosto"
        Me.txtPrecioCosto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrecioCosto.PromptText = "0.00"
        Me.txtPrecioCosto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrecioCosto.SelectedText = ""
        Me.txtPrecioCosto.SelectionLength = 0
        Me.txtPrecioCosto.SelectionStart = 0
        Me.txtPrecioCosto.ShortcutsEnabled = True
        Me.txtPrecioCosto.Size = New System.Drawing.Size(115, 23)
        Me.txtPrecioCosto.TabIndex = 99
        Me.txtPrecioCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPrecioCosto.UseSelectable = True
        Me.txtPrecioCosto.WaterMark = "0.00"
        Me.txtPrecioCosto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPrecioCosto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPrecioLista
        '
        '
        '
        '
        Me.txtPrecioLista.CustomButton.Image = Nothing
        Me.txtPrecioLista.CustomButton.Location = New System.Drawing.Point(70, 1)
        Me.txtPrecioLista.CustomButton.Name = ""
        Me.txtPrecioLista.CustomButton.Size = New System.Drawing.Size(16, 17)
        Me.txtPrecioLista.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrecioLista.CustomButton.TabIndex = 1
        Me.txtPrecioLista.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrecioLista.CustomButton.UseSelectable = True
        Me.txtPrecioLista.CustomButton.Visible = False
        Me.txtPrecioLista.Lines = New String(-1) {}
        Me.txtPrecioLista.Location = New System.Drawing.Point(132, 400)
        Me.txtPrecioLista.MaxLength = 32767
        Me.txtPrecioLista.Name = "txtPrecioLista"
        Me.txtPrecioLista.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrecioLista.PromptText = "0.00"
        Me.txtPrecioLista.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrecioLista.SelectedText = ""
        Me.txtPrecioLista.SelectionLength = 0
        Me.txtPrecioLista.SelectionStart = 0
        Me.txtPrecioLista.ShortcutsEnabled = True
        Me.txtPrecioLista.Size = New System.Drawing.Size(115, 23)
        Me.txtPrecioLista.TabIndex = 98
        Me.txtPrecioLista.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPrecioLista.UseSelectable = True
        Me.txtPrecioLista.WaterMark = "0.00"
        Me.txtPrecioLista.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPrecioLista.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.txtClaveProducto.CustomButton.Location = New System.Drawing.Point(107, 1)
        Me.txtClaveProducto.CustomButton.Name = ""
        Me.txtClaveProducto.CustomButton.Size = New System.Drawing.Size(16, 17)
        Me.txtClaveProducto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtClaveProducto.CustomButton.TabIndex = 1
        Me.txtClaveProducto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtClaveProducto.CustomButton.UseSelectable = True
        Me.txtClaveProducto.CustomButton.Visible = False
        Me.txtClaveProducto.Lines = New String(-1) {}
        Me.txtClaveProducto.Location = New System.Drawing.Point(159, 287)
        Me.txtClaveProducto.MaxLength = 32767
        Me.txtClaveProducto.Name = "txtClaveProducto"
        Me.txtClaveProducto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtClaveProducto.PromptText = "Clave Producto"
        Me.txtClaveProducto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtClaveProducto.SelectedText = ""
        Me.txtClaveProducto.SelectionLength = 0
        Me.txtClaveProducto.SelectionStart = 0
        Me.txtClaveProducto.ShortcutsEnabled = True
        Me.txtClaveProducto.Size = New System.Drawing.Size(165, 23)
        Me.txtClaveProducto.TabIndex = 103
        Me.txtClaveProducto.UseSelectable = True
        Me.txtClaveProducto.WaterMark = "Clave Producto"
        Me.txtClaveProducto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtClaveProducto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtClaveUnidad
        '
        Me.txtClaveUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtClaveUnidad.CustomButton.Image = Nothing
        Me.txtClaveUnidad.CustomButton.Location = New System.Drawing.Point(125, 1)
        Me.txtClaveUnidad.CustomButton.Name = ""
        Me.txtClaveUnidad.CustomButton.Size = New System.Drawing.Size(16, 17)
        Me.txtClaveUnidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtClaveUnidad.CustomButton.TabIndex = 1
        Me.txtClaveUnidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtClaveUnidad.CustomButton.UseSelectable = True
        Me.txtClaveUnidad.CustomButton.Visible = False
        Me.txtClaveUnidad.Enabled = False
        Me.txtClaveUnidad.Lines = New String(-1) {}
        Me.txtClaveUnidad.Location = New System.Drawing.Point(557, 286)
        Me.txtClaveUnidad.MaxLength = 32767
        Me.txtClaveUnidad.Name = "txtClaveUnidad"
        Me.txtClaveUnidad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtClaveUnidad.PromptText = "Clave Unidad"
        Me.txtClaveUnidad.ReadOnly = True
        Me.txtClaveUnidad.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtClaveUnidad.SelectedText = ""
        Me.txtClaveUnidad.SelectionLength = 0
        Me.txtClaveUnidad.SelectionStart = 0
        Me.txtClaveUnidad.ShortcutsEnabled = True
        Me.txtClaveUnidad.Size = New System.Drawing.Size(189, 23)
        Me.txtClaveUnidad.TabIndex = 104
        Me.txtClaveUnidad.UseSelectable = True
        Me.txtClaveUnidad.WaterMark = "Clave Unidad"
        Me.txtClaveUnidad.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtClaveUnidad.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDesc
        '
        '
        '
        '
        Me.txtDesc.CustomButton.Image = Nothing
        Me.txtDesc.CustomButton.Location = New System.Drawing.Point(44, 1)
        Me.txtDesc.CustomButton.Name = ""
        Me.txtDesc.CustomButton.Size = New System.Drawing.Size(16, 17)
        Me.txtDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDesc.CustomButton.TabIndex = 1
        Me.txtDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDesc.CustomButton.UseSelectable = True
        Me.txtDesc.CustomButton.Visible = False
        Me.txtDesc.Lines = New String() {"0"}
        Me.txtDesc.Location = New System.Drawing.Point(508, 119)
        Me.txtDesc.MaxLength = 32767
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDesc.PromptText = "0"
        Me.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDesc.SelectedText = ""
        Me.txtDesc.SelectionLength = 0
        Me.txtDesc.SelectionStart = 0
        Me.txtDesc.ShortcutsEnabled = True
        Me.txtDesc.Size = New System.Drawing.Size(80, 23)
        Me.txtDesc.TabIndex = 103
        Me.txtDesc.Text = "0"
        Me.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDesc.UseSelectable = True
        Me.txtDesc.WaterMark = "0"
        Me.txtDesc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDesc.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtStock
        '
        '
        '
        '
        Me.txtStock.CustomButton.Image = Nothing
        Me.txtStock.CustomButton.Location = New System.Drawing.Point(44, 1)
        Me.txtStock.CustomButton.Name = ""
        Me.txtStock.CustomButton.Size = New System.Drawing.Size(16, 17)
        Me.txtStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtStock.CustomButton.TabIndex = 1
        Me.txtStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtStock.CustomButton.UseSelectable = True
        Me.txtStock.CustomButton.Visible = False
        Me.txtStock.Lines = New String() {"0"}
        Me.txtStock.Location = New System.Drawing.Point(666, 119)
        Me.txtStock.MaxLength = 32767
        Me.txtStock.Name = "txtStock"
        Me.txtStock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStock.PromptText = "0"
        Me.txtStock.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtStock.SelectedText = ""
        Me.txtStock.SelectionLength = 0
        Me.txtStock.SelectionStart = 0
        Me.txtStock.ShortcutsEnabled = True
        Me.txtStock.Size = New System.Drawing.Size(80, 23)
        Me.txtStock.TabIndex = 104
        Me.txtStock.Text = "0"
        Me.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtStock.UseSelectable = True
        Me.txtStock.WaterMark = "0"
        Me.txtStock.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtStock.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'chkPrecioManual
        '
        Me.chkPrecioManual.AutoSize = True
        Me.chkPrecioManual.Location = New System.Drawing.Point(647, 63)
        Me.chkPrecioManual.Name = "chkPrecioManual"
        Me.chkPrecioManual.Size = New System.Drawing.Size(99, 15)
        Me.chkPrecioManual.TabIndex = 105
        Me.chkPrecioManual.Text = "Precio Manual"
        Me.chkPrecioManual.UseSelectable = True
        '
        'chkTasaCero
        '
        Me.chkTasaCero.AutoSize = True
        Me.chkTasaCero.Location = New System.Drawing.Point(647, 84)
        Me.chkTasaCero.Name = "chkTasaCero"
        Me.chkTasaCero.Size = New System.Drawing.Size(64, 15)
        Me.chkTasaCero.TabIndex = 106
        Me.chkTasaCero.Text = "Tasa 0%"
        Me.chkTasaCero.UseSelectable = True
        '
        'chkTC
        '
        Me.chkTC.AutoSize = True
        Me.chkTC.Location = New System.Drawing.Point(24, 379)
        Me.chkTC.Name = "chkTC"
        Me.chkTC.Size = New System.Drawing.Size(133, 15)
        Me.chkTC.TabIndex = 107
        Me.chkTC.Text = "Usar Tipo de Cambio"
        Me.chkTC.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(24, 63)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(81, 19)
        Me.MetroLabel1.TabIndex = 108
        Me.MetroLabel1.Text = "Id Producto"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(24, 93)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(114, 19)
        Me.MetroLabel2.TabIndex = 109
        Me.MetroLabel2.Text = "Código de Barras"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(24, 123)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(42, 19)
        Me.MetroLabel3.TabIndex = 110
        Me.MetroLabel3.Text = "Clave"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(24, 153)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(79, 19)
        Me.MetroLabel4.TabIndex = 111
        Me.MetroLabel4.Text = "Descripción"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(24, 189)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(48, 19)
        Me.MetroLabel5.TabIndex = 112
        Me.MetroLabel5.Text = "Grupo"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel6.Location = New System.Drawing.Point(23, 225)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(74, 19)
        Me.MetroLabel6.TabIndex = 113
        Me.MetroLabel6.Text = "SubFamilia"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel7.Location = New System.Drawing.Point(24, 261)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel7.TabIndex = 114
        Me.MetroLabel7.Text = "Proveedor"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel8.Location = New System.Drawing.Point(24, 291)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(102, 19)
        Me.MetroLabel8.TabIndex = 115
        Me.MetroLabel8.Text = "Clave Producto"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel9.Location = New System.Drawing.Point(462, 287)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(90, 19)
        Me.MetroLabel9.TabIndex = 116
        Me.MetroLabel9.Text = "Clave Unidad"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel10.Location = New System.Drawing.Point(462, 191)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel10.TabIndex = 117
        Me.MetroLabel10.Text = "Familia"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel11.Location = New System.Drawing.Point(462, 223)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel11.TabIndex = 118
        Me.MetroLabel11.Text = "Linea"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel12.Location = New System.Drawing.Point(591, 154)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(53, 19)
        Me.MetroLabel12.TabIndex = 119
        Me.MetroLabel12.Text = "Unidad"
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel13.Location = New System.Drawing.Point(462, 255)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(74, 19)
        Me.MetroLabel13.TabIndex = 120
        Me.MetroLabel13.Text = "Tipo Venta"
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel14.Location = New System.Drawing.Point(348, 119)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(154, 19)
        Me.MetroLabel14.TabIndex = 121
        Me.MetroLabel14.Text = "Descuento (0% - 100%)"
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel15.Location = New System.Drawing.Point(618, 119)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(42, 19)
        Me.MetroLabel15.TabIndex = 122
        Me.MetroLabel15.Text = "Stock"
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel16.Location = New System.Drawing.Point(24, 404)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel16.TabIndex = 123
        Me.MetroLabel16.Text = "Precio Lista"
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel17.Location = New System.Drawing.Point(24, 433)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel17.TabIndex = 124
        Me.MetroLabel17.Text = "Precio Costo"
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel18.Location = New System.Drawing.Point(24, 462)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(94, 19)
        Me.MetroLabel18.TabIndex = 125
        Me.MetroLabel18.Text = "Precio Público"
        '
        'MetroLabel19
        '
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel19.Location = New System.Drawing.Point(311, 404)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel19.TabIndex = 126
        Me.MetroLabel19.Text = "Precio P1"
        '
        'MetroLabel20
        '
        Me.MetroLabel20.AutoSize = True
        Me.MetroLabel20.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel20.Location = New System.Drawing.Point(311, 433)
        Me.MetroLabel20.Name = "MetroLabel20"
        Me.MetroLabel20.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel20.TabIndex = 127
        Me.MetroLabel20.Text = "Precio P2"
        '
        'MetroLabel21
        '
        Me.MetroLabel21.AutoSize = True
        Me.MetroLabel21.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel21.Location = New System.Drawing.Point(311, 462)
        Me.MetroLabel21.Name = "MetroLabel21"
        Me.MetroLabel21.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel21.TabIndex = 128
        Me.MetroLabel21.Text = "Precio P3"
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.Location = New System.Drawing.Point(24, 328)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(722, 45)
        Me.MetroTile1.TabIndex = 129
        Me.MetroTile1.Text = "Precios"
        Me.MetroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile1.UseSelectable = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.close_window_16px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(671, 462)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 131
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGuardar.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.save_16px
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(671, 407)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 130
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.ForeColor = System.Drawing.Color.Red
        Me.btnEliminar.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.trash_can_16px
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.Location = New System.Drawing.Point(671, 435)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 132
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'FrmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(766, 522)
        Me.ControlBox = False
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
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmProductos"
        Me.Text = "Datos del Producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
