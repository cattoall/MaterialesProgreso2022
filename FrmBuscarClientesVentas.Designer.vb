<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBuscarClientesVentas
    'Inherits System.Windows.Forms.Form
    Inherits MetroFramework.Forms.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.btnSalir = New MetroFramework.Controls.MetroButton()
        Me.txtBusqueda = New MetroFramework.Controls.MetroTextBox()
        Me.IdComp_G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Paterno_G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Materno_G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calle_G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numero_G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colonia_G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ciudad_G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado_G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CP_G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RFC_G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono_G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Celular_G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo_G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones_G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListaPrecios_G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasCredito_G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LimiteCredito_G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoVenta_G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetodoPago_G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Condiciones_G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuenta_G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Banco_G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TasaCero_G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormaPago_G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsoCFDI_G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Regimen_G = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdComp_G, Me.ID_G, Me.Nombre_G, Me.Paterno_G, Me.Materno_G, Me.Calle_G, Me.Numero_G, Me.Colonia_G, Me.Ciudad_G, Me.Estado_G, Me.CP_G, Me.RFC_G, Me.Telefono_G, Me.Celular_G, Me.Correo_G, Me.Observaciones_G, Me.ListaPrecios_G, Me.DiasCredito_G, Me.LimiteCredito_G, Me.TipoVenta_G, Me.MetodoPago_G, Me.Condiciones_G, Me.Cuenta_G, Me.Banco_G, Me.TasaCero_G, Me.FormaPago_G, Me.UsoCFDI_G, Me.Regimen_G})
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
        Me.MetroGrid1.Location = New System.Drawing.Point(25, 91)
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
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(836, 375)
        Me.MetroGrid1.TabIndex = 14
        '
        'btnSalir
        '
        Me.btnSalir.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnSalir.Location = New System.Drawing.Point(747, 62)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(114, 23)
        Me.btnSalir.TabIndex = 78
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseSelectable = True
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
        Me.txtBusqueda.TabIndex = 77
        Me.txtBusqueda.UseSelectable = True
        Me.txtBusqueda.WaterMark = "Buscar por Nombre/Apellido Paterno/Apellido Materno"
        Me.txtBusqueda.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBusqueda.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'IdComp_G
        '
        Me.IdComp_G.HeaderText = "IdComp"
        Me.IdComp_G.Name = "IdComp_G"
        Me.IdComp_G.ReadOnly = True
        Me.IdComp_G.Visible = False
        '
        'ID_G
        '
        Me.ID_G.HeaderText = "ID"
        Me.ID_G.Name = "ID_G"
        Me.ID_G.ReadOnly = True
        Me.ID_G.Width = 40
        '
        'Nombre_G
        '
        Me.Nombre_G.HeaderText = "Nombre"
        Me.Nombre_G.Name = "Nombre_G"
        Me.Nombre_G.ReadOnly = True
        Me.Nombre_G.Width = 150
        '
        'Paterno_G
        '
        Me.Paterno_G.HeaderText = "Apellido Paterno"
        Me.Paterno_G.Name = "Paterno_G"
        Me.Paterno_G.ReadOnly = True
        Me.Paterno_G.Width = 150
        '
        'Materno_G
        '
        Me.Materno_G.HeaderText = "Apellido Materno"
        Me.Materno_G.Name = "Materno_G"
        Me.Materno_G.ReadOnly = True
        Me.Materno_G.Width = 150
        '
        'Calle_G
        '
        Me.Calle_G.HeaderText = "Calle"
        Me.Calle_G.Name = "Calle_G"
        Me.Calle_G.ReadOnly = True
        Me.Calle_G.Visible = False
        '
        'Numero_G
        '
        Me.Numero_G.HeaderText = "Numero"
        Me.Numero_G.Name = "Numero_G"
        Me.Numero_G.ReadOnly = True
        Me.Numero_G.Visible = False
        '
        'Colonia_G
        '
        Me.Colonia_G.HeaderText = "Colonia"
        Me.Colonia_G.Name = "Colonia_G"
        Me.Colonia_G.ReadOnly = True
        Me.Colonia_G.Visible = False
        '
        'Ciudad_G
        '
        Me.Ciudad_G.HeaderText = "Ciudad"
        Me.Ciudad_G.Name = "Ciudad_G"
        Me.Ciudad_G.ReadOnly = True
        Me.Ciudad_G.Visible = False
        '
        'Estado_G
        '
        Me.Estado_G.HeaderText = "Estado"
        Me.Estado_G.Name = "Estado_G"
        Me.Estado_G.ReadOnly = True
        Me.Estado_G.Visible = False
        '
        'CP_G
        '
        Me.CP_G.HeaderText = "CP"
        Me.CP_G.Name = "CP_G"
        Me.CP_G.ReadOnly = True
        Me.CP_G.Visible = False
        '
        'RFC_G
        '
        Me.RFC_G.HeaderText = "RFC"
        Me.RFC_G.Name = "RFC_G"
        Me.RFC_G.ReadOnly = True
        Me.RFC_G.Width = 80
        '
        'Telefono_G
        '
        Me.Telefono_G.HeaderText = "Telefono"
        Me.Telefono_G.Name = "Telefono_G"
        Me.Telefono_G.ReadOnly = True
        Me.Telefono_G.Visible = False
        '
        'Celular_G
        '
        Me.Celular_G.HeaderText = "Celular"
        Me.Celular_G.Name = "Celular_G"
        Me.Celular_G.ReadOnly = True
        Me.Celular_G.Visible = False
        '
        'Correo_G
        '
        Me.Correo_G.HeaderText = "Correo"
        Me.Correo_G.Name = "Correo_G"
        Me.Correo_G.ReadOnly = True
        Me.Correo_G.Visible = False
        '
        'Observaciones_G
        '
        Me.Observaciones_G.HeaderText = "Observaciones"
        Me.Observaciones_G.Name = "Observaciones_G"
        Me.Observaciones_G.ReadOnly = True
        '
        'ListaPrecios_G
        '
        Me.ListaPrecios_G.HeaderText = "ListaPrecios"
        Me.ListaPrecios_G.Name = "ListaPrecios_G"
        Me.ListaPrecios_G.ReadOnly = True
        Me.ListaPrecios_G.Visible = False
        '
        'DiasCredito_G
        '
        Me.DiasCredito_G.HeaderText = "DiasCredito"
        Me.DiasCredito_G.Name = "DiasCredito_G"
        Me.DiasCredito_G.ReadOnly = True
        Me.DiasCredito_G.Visible = False
        '
        'LimiteCredito_G
        '
        Me.LimiteCredito_G.HeaderText = "LimiteCredito"
        Me.LimiteCredito_G.Name = "LimiteCredito_G"
        Me.LimiteCredito_G.ReadOnly = True
        Me.LimiteCredito_G.Visible = False
        '
        'TipoVenta_G
        '
        Me.TipoVenta_G.HeaderText = "TipoVenta"
        Me.TipoVenta_G.Name = "TipoVenta_G"
        Me.TipoVenta_G.ReadOnly = True
        Me.TipoVenta_G.Visible = False
        '
        'MetodoPago_G
        '
        Me.MetodoPago_G.HeaderText = "MetodoPago"
        Me.MetodoPago_G.Name = "MetodoPago_G"
        Me.MetodoPago_G.ReadOnly = True
        Me.MetodoPago_G.Visible = False
        '
        'Condiciones_G
        '
        Me.Condiciones_G.HeaderText = "Condiciones"
        Me.Condiciones_G.Name = "Condiciones_G"
        Me.Condiciones_G.ReadOnly = True
        Me.Condiciones_G.Visible = False
        '
        'Cuenta_G
        '
        Me.Cuenta_G.HeaderText = "Cuenta"
        Me.Cuenta_G.Name = "Cuenta_G"
        Me.Cuenta_G.ReadOnly = True
        Me.Cuenta_G.Visible = False
        '
        'Banco_G
        '
        Me.Banco_G.HeaderText = "Banco"
        Me.Banco_G.Name = "Banco_G"
        Me.Banco_G.ReadOnly = True
        Me.Banco_G.Visible = False
        '
        'TasaCero_G
        '
        Me.TasaCero_G.HeaderText = "TasaCero"
        Me.TasaCero_G.Name = "TasaCero_G"
        Me.TasaCero_G.ReadOnly = True
        Me.TasaCero_G.Visible = False
        '
        'FormaPago_G
        '
        Me.FormaPago_G.HeaderText = "FormaPago"
        Me.FormaPago_G.Name = "FormaPago_G"
        Me.FormaPago_G.ReadOnly = True
        Me.FormaPago_G.Visible = False
        '
        'UsoCFDI_G
        '
        Me.UsoCFDI_G.HeaderText = "UsoCFDI"
        Me.UsoCFDI_G.Name = "UsoCFDI_G"
        Me.UsoCFDI_G.ReadOnly = True
        Me.UsoCFDI_G.Visible = False
        '
        'Regimen_G
        '
        Me.Regimen_G.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Regimen_G.HeaderText = "Régimen Fiscal"
        Me.Regimen_G.Name = "Regimen_G"
        Me.Regimen_G.ReadOnly = True
        '
        'FrmBuscarClientesVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(873, 478)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.MetroGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmBuscarClientesVentas"
        Me.Text = "Buscar Clientes"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents btnSalir As MetroFramework.Controls.MetroButton
    Friend WithEvents txtBusqueda As MetroFramework.Controls.MetroTextBox
    Friend WithEvents IdComp_G As DataGridViewTextBoxColumn
    Friend WithEvents ID_G As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_G As DataGridViewTextBoxColumn
    Friend WithEvents Paterno_G As DataGridViewTextBoxColumn
    Friend WithEvents Materno_G As DataGridViewTextBoxColumn
    Friend WithEvents Calle_G As DataGridViewTextBoxColumn
    Friend WithEvents Numero_G As DataGridViewTextBoxColumn
    Friend WithEvents Colonia_G As DataGridViewTextBoxColumn
    Friend WithEvents Ciudad_G As DataGridViewTextBoxColumn
    Friend WithEvents Estado_G As DataGridViewTextBoxColumn
    Friend WithEvents CP_G As DataGridViewTextBoxColumn
    Friend WithEvents RFC_G As DataGridViewTextBoxColumn
    Friend WithEvents Telefono_G As DataGridViewTextBoxColumn
    Friend WithEvents Celular_G As DataGridViewTextBoxColumn
    Friend WithEvents Correo_G As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones_G As DataGridViewTextBoxColumn
    Friend WithEvents ListaPrecios_G As DataGridViewTextBoxColumn
    Friend WithEvents DiasCredito_G As DataGridViewTextBoxColumn
    Friend WithEvents LimiteCredito_G As DataGridViewTextBoxColumn
    Friend WithEvents TipoVenta_G As DataGridViewTextBoxColumn
    Friend WithEvents MetodoPago_G As DataGridViewTextBoxColumn
    Friend WithEvents Condiciones_G As DataGridViewTextBoxColumn
    Friend WithEvents Cuenta_G As DataGridViewTextBoxColumn
    Friend WithEvents Banco_G As DataGridViewTextBoxColumn
    Friend WithEvents TasaCero_G As DataGridViewTextBoxColumn
    Friend WithEvents FormaPago_G As DataGridViewTextBoxColumn
    Friend WithEvents UsoCFDI_G As DataGridViewTextBoxColumn
    Friend WithEvents Regimen_G As DataGridViewTextBoxColumn
End Class
