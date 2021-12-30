<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientesWendy
    Inherits System.Windows.Forms.Form

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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.CmbPrecio = New System.Windows.Forms.ComboBox()
        Me.txtLimite = New System.Windows.Forms.TextBox()
        Me.txtCredito = New System.Windows.Forms.TextBox()
        Me.txtMovil = New System.Windows.Forms.MaskedTextBox()
        Me.txtTelFijo = New System.Windows.Forms.MaskedTextBox()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.txtCodigoPostal = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.txtNumExterno = New System.Windows.Forms.TextBox()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.txtAmat = New System.Windows.Forms.TextBox()
        Me.txtApat = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmdSalir = New System.Windows.Forms.Button()
        Me.CmdGuardar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtObs)
        Me.GroupBox1.Controls.Add(Me.CmbPrecio)
        Me.GroupBox1.Controls.Add(Me.txtLimite)
        Me.GroupBox1.Controls.Add(Me.txtCredito)
        Me.GroupBox1.Controls.Add(Me.txtMovil)
        Me.GroupBox1.Controls.Add(Me.txtTelFijo)
        Me.GroupBox1.Controls.Add(Me.txtRFC)
        Me.GroupBox1.Controls.Add(Me.txtCodigoPostal)
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.txtCiudad)
        Me.GroupBox1.Controls.Add(Me.txtColonia)
        Me.GroupBox1.Controls.Add(Me.txtNumExterno)
        Me.GroupBox1.Controls.Add(Me.txtDomicilio)
        Me.GroupBox1.Controls.Add(Me.txtAmat)
        Me.GroupBox1.Controls.Add(Me.txtApat)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(673, 481)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Cliente"
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmail.Location = New System.Drawing.Point(162, 268)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(485, 22)
        Me.txtEmail.TabIndex = 12
        '
        'txtObs
        '
        Me.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObs.Location = New System.Drawing.Point(162, 354)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(481, 109)
        Me.txtObs.TabIndex = 16
        '
        'CmbPrecio
        '
        Me.CmbPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrecio.FormattingEnabled = True
        Me.CmbPrecio.Items.AddRange(New Object() {"Precio Público", "Precio P1", "Precio P2", "Precio P3"})
        Me.CmbPrecio.Location = New System.Drawing.Point(162, 324)
        Me.CmbPrecio.Name = "CmbPrecio"
        Me.CmbPrecio.Size = New System.Drawing.Size(189, 24)
        Me.CmbPrecio.TabIndex = 15
        '
        'txtLimite
        '
        Me.txtLimite.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLimite.Location = New System.Drawing.Point(372, 296)
        Me.txtLimite.Name = "txtLimite"
        Me.txtLimite.Size = New System.Drawing.Size(139, 22)
        Me.txtLimite.TabIndex = 14
        Me.txtLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCredito
        '
        Me.txtCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCredito.Location = New System.Drawing.Point(162, 296)
        Me.txtCredito.Name = "txtCredito"
        Me.txtCredito.Size = New System.Drawing.Size(70, 22)
        Me.txtCredito.TabIndex = 13
        Me.txtCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMovil
        '
        Me.txtMovil.Location = New System.Drawing.Point(454, 240)
        Me.txtMovil.Mask = "(999)000-0000"
        Me.txtMovil.Name = "txtMovil"
        Me.txtMovil.Size = New System.Drawing.Size(193, 22)
        Me.txtMovil.TabIndex = 11
        Me.txtMovil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTelFijo
        '
        Me.txtTelFijo.Location = New System.Drawing.Point(162, 240)
        Me.txtTelFijo.Mask = "(999)000-0000"
        Me.txtTelFijo.Name = "txtTelFijo"
        Me.txtTelFijo.Size = New System.Drawing.Size(190, 22)
        Me.txtTelFijo.TabIndex = 10
        Me.txtTelFijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRFC
        '
        Me.txtRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRFC.Location = New System.Drawing.Point(454, 212)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(193, 22)
        Me.txtRFC.TabIndex = 9
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoPostal.Location = New System.Drawing.Point(162, 212)
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Size = New System.Drawing.Size(190, 22)
        Me.txtCodigoPostal.TabIndex = 8
        '
        'txtEstado
        '
        Me.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstado.Location = New System.Drawing.Point(454, 184)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(193, 22)
        Me.txtEstado.TabIndex = 7
        '
        'txtCiudad
        '
        Me.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCiudad.Location = New System.Drawing.Point(162, 184)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(190, 22)
        Me.txtCiudad.TabIndex = 6
        '
        'txtColonia
        '
        Me.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtColonia.Location = New System.Drawing.Point(320, 156)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(327, 22)
        Me.txtColonia.TabIndex = 5
        '
        'txtNumExterno
        '
        Me.txtNumExterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumExterno.Location = New System.Drawing.Point(162, 156)
        Me.txtNumExterno.Name = "txtNumExterno"
        Me.txtNumExterno.Size = New System.Drawing.Size(70, 22)
        Me.txtNumExterno.TabIndex = 4
        Me.txtNumExterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDomicilio
        '
        Me.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDomicilio.Location = New System.Drawing.Point(162, 128)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(485, 22)
        Me.txtDomicilio.TabIndex = 3
        '
        'txtAmat
        '
        Me.txtAmat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAmat.Location = New System.Drawing.Point(162, 100)
        Me.txtAmat.Name = "txtAmat"
        Me.txtAmat.Size = New System.Drawing.Size(485, 22)
        Me.txtAmat.TabIndex = 2
        '
        'txtApat
        '
        Me.txtApat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApat.Location = New System.Drawing.Point(162, 72)
        Me.txtApat.Name = "txtApat"
        Me.txtApat.Size = New System.Drawing.Size(485, 22)
        Me.txtApat.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(162, 44)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(485, 22)
        Me.txtNombre.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(234, 299)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(129, 16)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Límite de Crédito:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(23, 299)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(120, 16)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Días de Crédito:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(24, 326)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(116, 16)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Lista de Precio:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(24, 354)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(117, 16)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Observaciones:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(24, 271)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 16)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "E-mail:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(387, 243)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 16)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Celular:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 243)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 16)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Teléfono Fijo:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(406, 215)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 16)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "RFC:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 215)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Código Postal:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(387, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Estado:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Ciudad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(249, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Colonia:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Número Exterior:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Domicilio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido Materno:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido Paterno:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'CmdSalir
        '
        Me.CmdSalir.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.action_stop
        Me.CmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdSalir.Location = New System.Drawing.Point(428, 499)
        Me.CmdSalir.Name = "CmdSalir"
        Me.CmdSalir.Size = New System.Drawing.Size(111, 27)
        Me.CmdSalir.TabIndex = 18
        Me.CmdSalir.Text = "Salir"
        Me.CmdSalir.UseVisualStyleBackColor = True
        '
        'CmdGuardar
        '
        Me.CmdGuardar.Enabled = False
        Me.CmdGuardar.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.action_save
        Me.CmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdGuardar.Location = New System.Drawing.Point(194, 499)
        Me.CmdGuardar.Name = "CmdGuardar"
        Me.CmdGuardar.Size = New System.Drawing.Size(111, 27)
        Me.CmdGuardar.TabIndex = 17
        Me.CmdGuardar.Text = "Guardar"
        Me.CmdGuardar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Enabled = False
        Me.BtnEliminar.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.basket_delete
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(311, 499)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(111, 27)
        Me.BtnEliminar.TabIndex = 19
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'FrmClientesWendy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 534)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CmdSalir)
        Me.Controls.Add(Me.CmdGuardar)
        Me.Name = "FrmClientesWendy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos del Cliente Wendy"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CmdSalir As System.Windows.Forms.Button
    Friend WithEvents CmdGuardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMovil As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtTelFijo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtRFC As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoPostal As System.Windows.Forms.TextBox
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents txtCiudad As System.Windows.Forms.TextBox
    Friend WithEvents txtColonia As System.Windows.Forms.TextBox
    Friend WithEvents txtNumExterno As System.Windows.Forms.TextBox
    Friend WithEvents txtDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents txtAmat As System.Windows.Forms.TextBox
    Friend WithEvents txtApat As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtLimite As System.Windows.Forms.TextBox
    Friend WithEvents txtCredito As System.Windows.Forms.TextBox
    Friend WithEvents CmbPrecio As System.Windows.Forms.ComboBox
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
End Class
