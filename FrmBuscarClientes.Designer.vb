<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarClientes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.txtBusqueda = New MetroFramework.Controls.MetroTextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IdComp_G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Paterno_G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Materno_G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calle_G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numero_G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colonia_G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ciudad_G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado_G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CP_G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RFC_G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono_G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Celular_G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo_G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones_G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListaPrecios_G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasCredito_G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LimiteCredito_G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoVenta_G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetodoPago_G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Condiciones_G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuenta_G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Banco_G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TasaCero_G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormaPago_G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsoCFDI_G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegimenFiscal_G1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bloqueo = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdComp_G1, Me.ID_G1, Me.Nombre_G1, Me.Paterno_G1, Me.Materno_G1, Me.Calle_G1, Me.Numero_G1, Me.Colonia_G1, Me.Ciudad_G1, Me.Estado_G1, Me.CP_G1, Me.RFC_G1, Me.Telefono_G1, Me.Celular_G1, Me.Correo_G1, Me.Observaciones_G1, Me.ListaPrecios_G1, Me.DiasCredito_G1, Me.LimiteCredito_G1, Me.TipoVenta_G1, Me.MetodoPago_G1, Me.Condiciones_G1, Me.Cuenta_G1, Me.Banco_G1, Me.TasaCero_G1, Me.FormaPago_G1, Me.UsoCFDI_G1, Me.RegimenFiscal_G1, Me.Bloqueo})
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
        Me.MetroGrid1.Location = New System.Drawing.Point(23, 91)
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
        Me.MetroGrid1.Size = New System.Drawing.Size(836, 364)
        Me.MetroGrid1.TabIndex = 4
        '
        'txtBusqueda
        '
        Me.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtBusqueda.CustomButton.Image = Nothing
        Me.txtBusqueda.CustomButton.Location = New System.Drawing.Point(312, 1)
        Me.txtBusqueda.CustomButton.Name = ""
        Me.txtBusqueda.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBusqueda.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBusqueda.CustomButton.TabIndex = 1
        Me.txtBusqueda.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBusqueda.CustomButton.UseSelectable = True
        Me.txtBusqueda.CustomButton.Visible = False
        Me.txtBusqueda.Lines = New String(-1) {}
        Me.txtBusqueda.Location = New System.Drawing.Point(23, 62)
        Me.txtBusqueda.MaxLength = 32767
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBusqueda.PromptText = "Buscar por Nombre/Apellido Paterno/Apellido Materno"
        Me.txtBusqueda.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBusqueda.SelectedText = ""
        Me.txtBusqueda.SelectionLength = 0
        Me.txtBusqueda.SelectionStart = 0
        Me.txtBusqueda.ShortcutsEnabled = True
        Me.txtBusqueda.Size = New System.Drawing.Size(334, 23)
        Me.txtBusqueda.TabIndex = 5
        Me.txtBusqueda.UseSelectable = True
        Me.txtBusqueda.WaterMark = "Buscar por Nombre/Apellido Paterno/Apellido Materno"
        Me.txtBusqueda.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBusqueda.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnAdd.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.add_16px
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.Location = New System.Drawing.Point(362, 62)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 77
        Me.btnAdd.Text = "Nuevo"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.close_window_16px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(784, 62)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 78
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IdComp_G1
        '
        Me.IdComp_G1.HeaderText = "IdComp"
        Me.IdComp_G1.Name = "IdComp_G1"
        Me.IdComp_G1.ReadOnly = True
        Me.IdComp_G1.Visible = False
        '
        'ID_G1
        '
        Me.ID_G1.HeaderText = "ID"
        Me.ID_G1.Name = "ID_G1"
        Me.ID_G1.ReadOnly = True
        Me.ID_G1.Width = 40
        '
        'Nombre_G1
        '
        Me.Nombre_G1.HeaderText = "Nombre"
        Me.Nombre_G1.Name = "Nombre_G1"
        Me.Nombre_G1.ReadOnly = True
        Me.Nombre_G1.Width = 150
        '
        'Paterno_G1
        '
        Me.Paterno_G1.HeaderText = "Apellido Paterno"
        Me.Paterno_G1.Name = "Paterno_G1"
        Me.Paterno_G1.ReadOnly = True
        Me.Paterno_G1.Width = 150
        '
        'Materno_G1
        '
        Me.Materno_G1.HeaderText = "Apellido Materno"
        Me.Materno_G1.Name = "Materno_G1"
        Me.Materno_G1.ReadOnly = True
        Me.Materno_G1.Width = 150
        '
        'Calle_G1
        '
        Me.Calle_G1.HeaderText = "Calle"
        Me.Calle_G1.Name = "Calle_G1"
        Me.Calle_G1.ReadOnly = True
        Me.Calle_G1.Visible = False
        '
        'Numero_G1
        '
        Me.Numero_G1.HeaderText = "Numero"
        Me.Numero_G1.Name = "Numero_G1"
        Me.Numero_G1.ReadOnly = True
        Me.Numero_G1.Visible = False
        '
        'Colonia_G1
        '
        Me.Colonia_G1.HeaderText = "Colonia"
        Me.Colonia_G1.Name = "Colonia_G1"
        Me.Colonia_G1.ReadOnly = True
        Me.Colonia_G1.Visible = False
        '
        'Ciudad_G1
        '
        Me.Ciudad_G1.HeaderText = "Ciudad"
        Me.Ciudad_G1.Name = "Ciudad_G1"
        Me.Ciudad_G1.ReadOnly = True
        Me.Ciudad_G1.Visible = False
        '
        'Estado_G1
        '
        Me.Estado_G1.HeaderText = "Estado"
        Me.Estado_G1.Name = "Estado_G1"
        Me.Estado_G1.ReadOnly = True
        Me.Estado_G1.Visible = False
        '
        'CP_G1
        '
        Me.CP_G1.HeaderText = "CP"
        Me.CP_G1.Name = "CP_G1"
        Me.CP_G1.ReadOnly = True
        Me.CP_G1.Visible = False
        '
        'RFC_G1
        '
        Me.RFC_G1.HeaderText = "RFC"
        Me.RFC_G1.Name = "RFC_G1"
        Me.RFC_G1.ReadOnly = True
        Me.RFC_G1.Width = 80
        '
        'Telefono_G1
        '
        Me.Telefono_G1.HeaderText = "Telefono"
        Me.Telefono_G1.Name = "Telefono_G1"
        Me.Telefono_G1.ReadOnly = True
        Me.Telefono_G1.Visible = False
        '
        'Celular_G1
        '
        Me.Celular_G1.HeaderText = "Celular"
        Me.Celular_G1.Name = "Celular_G1"
        Me.Celular_G1.ReadOnly = True
        Me.Celular_G1.Visible = False
        '
        'Correo_G1
        '
        Me.Correo_G1.HeaderText = "Correo"
        Me.Correo_G1.Name = "Correo_G1"
        Me.Correo_G1.ReadOnly = True
        Me.Correo_G1.Visible = False
        '
        'Observaciones_G1
        '
        Me.Observaciones_G1.HeaderText = "Observaciones"
        Me.Observaciones_G1.Name = "Observaciones_G1"
        Me.Observaciones_G1.ReadOnly = True
        '
        'ListaPrecios_G1
        '
        Me.ListaPrecios_G1.HeaderText = "ListaPrecios"
        Me.ListaPrecios_G1.Name = "ListaPrecios_G1"
        Me.ListaPrecios_G1.ReadOnly = True
        Me.ListaPrecios_G1.Visible = False
        '
        'DiasCredito_G1
        '
        Me.DiasCredito_G1.HeaderText = "DiasCredito"
        Me.DiasCredito_G1.Name = "DiasCredito_G1"
        Me.DiasCredito_G1.ReadOnly = True
        Me.DiasCredito_G1.Visible = False
        '
        'LimiteCredito_G1
        '
        Me.LimiteCredito_G1.HeaderText = "LimiteCredito"
        Me.LimiteCredito_G1.Name = "LimiteCredito_G1"
        Me.LimiteCredito_G1.ReadOnly = True
        Me.LimiteCredito_G1.Visible = False
        '
        'TipoVenta_G1
        '
        Me.TipoVenta_G1.HeaderText = "TipoVenta"
        Me.TipoVenta_G1.Name = "TipoVenta_G1"
        Me.TipoVenta_G1.ReadOnly = True
        Me.TipoVenta_G1.Visible = False
        '
        'MetodoPago_G1
        '
        Me.MetodoPago_G1.HeaderText = "MetodoPago"
        Me.MetodoPago_G1.Name = "MetodoPago_G1"
        Me.MetodoPago_G1.ReadOnly = True
        Me.MetodoPago_G1.Visible = False
        '
        'Condiciones_G1
        '
        Me.Condiciones_G1.HeaderText = "Condiciones"
        Me.Condiciones_G1.Name = "Condiciones_G1"
        Me.Condiciones_G1.ReadOnly = True
        Me.Condiciones_G1.Visible = False
        '
        'Cuenta_G1
        '
        Me.Cuenta_G1.HeaderText = "Cuenta"
        Me.Cuenta_G1.Name = "Cuenta_G1"
        Me.Cuenta_G1.ReadOnly = True
        Me.Cuenta_G1.Visible = False
        '
        'Banco_G1
        '
        Me.Banco_G1.HeaderText = "Banco"
        Me.Banco_G1.Name = "Banco_G1"
        Me.Banco_G1.ReadOnly = True
        Me.Banco_G1.Visible = False
        '
        'TasaCero_G1
        '
        Me.TasaCero_G1.HeaderText = "TasaCero"
        Me.TasaCero_G1.Name = "TasaCero_G1"
        Me.TasaCero_G1.ReadOnly = True
        Me.TasaCero_G1.Visible = False
        '
        'FormaPago_G1
        '
        Me.FormaPago_G1.HeaderText = "FormaPago"
        Me.FormaPago_G1.Name = "FormaPago_G1"
        Me.FormaPago_G1.ReadOnly = True
        Me.FormaPago_G1.Visible = False
        '
        'UsoCFDI_G1
        '
        Me.UsoCFDI_G1.HeaderText = "UsoCFDI"
        Me.UsoCFDI_G1.Name = "UsoCFDI_G1"
        Me.UsoCFDI_G1.ReadOnly = True
        Me.UsoCFDI_G1.Visible = False
        '
        'RegimenFiscal_G1
        '
        Me.RegimenFiscal_G1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RegimenFiscal_G1.HeaderText = "Régimen Fiscal"
        Me.RegimenFiscal_G1.Name = "RegimenFiscal_G1"
        Me.RegimenFiscal_G1.ReadOnly = True
        '
        'Bloqueo
        '
        Me.Bloqueo.HeaderText = "Bloqueo"
        Me.Bloqueo.Name = "Bloqueo"
        Me.Bloqueo.ReadOnly = True
        Me.Bloqueo.Visible = False
        '
        'FrmBuscarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(882, 478)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.MetroGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmBuscarClientes"
        Me.Text = "Buscar Clientes"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents txtBusqueda As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents IdComp_G1 As DataGridViewTextBoxColumn
    Friend WithEvents ID_G1 As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_G1 As DataGridViewTextBoxColumn
    Friend WithEvents Paterno_G1 As DataGridViewTextBoxColumn
    Friend WithEvents Materno_G1 As DataGridViewTextBoxColumn
    Friend WithEvents Calle_G1 As DataGridViewTextBoxColumn
    Friend WithEvents Numero_G1 As DataGridViewTextBoxColumn
    Friend WithEvents Colonia_G1 As DataGridViewTextBoxColumn
    Friend WithEvents Ciudad_G1 As DataGridViewTextBoxColumn
    Friend WithEvents Estado_G1 As DataGridViewTextBoxColumn
    Friend WithEvents CP_G1 As DataGridViewTextBoxColumn
    Friend WithEvents RFC_G1 As DataGridViewTextBoxColumn
    Friend WithEvents Telefono_G1 As DataGridViewTextBoxColumn
    Friend WithEvents Celular_G1 As DataGridViewTextBoxColumn
    Friend WithEvents Correo_G1 As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones_G1 As DataGridViewTextBoxColumn
    Friend WithEvents ListaPrecios_G1 As DataGridViewTextBoxColumn
    Friend WithEvents DiasCredito_G1 As DataGridViewTextBoxColumn
    Friend WithEvents LimiteCredito_G1 As DataGridViewTextBoxColumn
    Friend WithEvents TipoVenta_G1 As DataGridViewTextBoxColumn
    Friend WithEvents MetodoPago_G1 As DataGridViewTextBoxColumn
    Friend WithEvents Condiciones_G1 As DataGridViewTextBoxColumn
    Friend WithEvents Cuenta_G1 As DataGridViewTextBoxColumn
    Friend WithEvents Banco_G1 As DataGridViewTextBoxColumn
    Friend WithEvents TasaCero_G1 As DataGridViewTextBoxColumn
    Friend WithEvents FormaPago_G1 As DataGridViewTextBoxColumn
    Friend WithEvents UsoCFDI_G1 As DataGridViewTextBoxColumn
    Friend WithEvents RegimenFiscal_G1 As DataGridViewTextBoxColumn
    Friend WithEvents Bloqueo As DataGridViewTextBoxColumn
End Class
