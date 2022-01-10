<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFolioAME
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
        Me.TxtFolioAct = New System.Windows.Forms.TextBox()
        Me.TxtfolioIni = New System.Windows.Forms.TextBox()
        Me.txtFilioFin = New System.Windows.Forms.TextBox()
        Me.lbldocumento = New System.Windows.Forms.Label()
        Me.lblinicial = New System.Windows.Forms.Label()
        Me.lblfinal = New System.Windows.Forms.Label()
        Me.lblfolioactual = New System.Windows.Forms.Label()
        Me.CmbTipoDoc = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ImgGuardarB = New System.Windows.Forms.PictureBox()
        Me.ImgGuardarA = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImgModificarB = New System.Windows.Forms.PictureBox()
        Me.ImgModificarA = New System.Windows.Forms.PictureBox()
        Me.ImgSalirB = New System.Windows.Forms.PictureBox()
        Me.ImgSalirA = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout
        CType(Me.ImgGuardarB,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ImgGuardarA,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ImgModificarB,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ImgModificarA,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ImgSalirB,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ImgSalirA,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'TxtFolioAct
        '
        Me.TxtFolioAct.Location = New System.Drawing.Point(183, 140)
        Me.TxtFolioAct.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtFolioAct.Name = "TxtFolioAct"
        Me.TxtFolioAct.Size = New System.Drawing.Size(240, 30)
        Me.TxtFolioAct.TabIndex = 1
        '
        'TxtfolioIni
        '
        Me.TxtfolioIni.Location = New System.Drawing.Point(183, 71)
        Me.TxtfolioIni.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtfolioIni.Name = "TxtfolioIni"
        Me.TxtfolioIni.Size = New System.Drawing.Size(240, 30)
        Me.TxtfolioIni.TabIndex = 2
        '
        'txtFilioFin
        '
        Me.txtFilioFin.Location = New System.Drawing.Point(183, 106)
        Me.txtFilioFin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFilioFin.Name = "txtFilioFin"
        Me.txtFilioFin.Size = New System.Drawing.Size(240, 30)
        Me.txtFilioFin.TabIndex = 3
        '
        'lbldocumento
        '
        Me.lbldocumento.AutoSize = true
        Me.lbldocumento.BackColor = System.Drawing.Color.Transparent
        Me.lbldocumento.Location = New System.Drawing.Point(12, 38)
        Me.lbldocumento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldocumento.Name = "lbldocumento"
        Me.lbldocumento.Size = New System.Drawing.Size(148, 23)
        Me.lbldocumento.TabIndex = 5
        Me.lbldocumento.Text = "Tipo Documento"
        '
        'lblinicial
        '
        Me.lblinicial.AutoSize = true
        Me.lblinicial.BackColor = System.Drawing.Color.Transparent
        Me.lblinicial.Location = New System.Drawing.Point(57, 75)
        Me.lblinicial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblinicial.Name = "lblinicial"
        Me.lblinicial.Size = New System.Drawing.Size(107, 23)
        Me.lblinicial.TabIndex = 6
        Me.lblinicial.Text = "Folio Inicial"
        '
        'lblfinal
        '
        Me.lblfinal.AutoSize = true
        Me.lblfinal.BackColor = System.Drawing.Color.Transparent
        Me.lblfinal.Location = New System.Drawing.Point(67, 110)
        Me.lblfinal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfinal.Name = "lblfinal"
        Me.lblfinal.Size = New System.Drawing.Size(97, 23)
        Me.lblfinal.TabIndex = 7
        Me.lblfinal.Text = "Folio Final"
        '
        'lblfolioactual
        '
        Me.lblfolioactual.AutoSize = true
        Me.lblfolioactual.BackColor = System.Drawing.Color.Transparent
        Me.lblfolioactual.Location = New System.Drawing.Point(55, 144)
        Me.lblfolioactual.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfolioactual.Name = "lblfolioactual"
        Me.lblfolioactual.Size = New System.Drawing.Size(110, 23)
        Me.lblfolioactual.TabIndex = 8
        Me.lblfolioactual.Text = "Folio Actual"
        '
        'CmbTipoDoc
        '
        Me.CmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipoDoc.FormattingEnabled = true
        Me.CmbTipoDoc.Items.AddRange(New Object() {"FACTURAS", "NOTAS DE CREDITO", "PAGOS"})
        Me.CmbTipoDoc.Location = New System.Drawing.Point(183, 34)
        Me.CmbTipoDoc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbTipoDoc.Name = "CmbTipoDoc"
        Me.CmbTipoDoc.Size = New System.Drawing.Size(240, 31)
        Me.CmbTipoDoc.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ImgGuardarB)
        Me.GroupBox1.Controls.Add(Me.ImgGuardarA)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtfolioIni)
        Me.GroupBox1.Controls.Add(Me.TxtFolioAct)
        Me.GroupBox1.Controls.Add(Me.txtFilioFin)
        Me.GroupBox1.Controls.Add(Me.lbldocumento)
        Me.GroupBox1.Controls.Add(Me.CmbTipoDoc)
        Me.GroupBox1.Controls.Add(Me.lblinicial)
        Me.GroupBox1.Controls.Add(Me.lblfolioactual)
        Me.GroupBox1.Controls.Add(Me.lblfinal)
        Me.GroupBox1.Controls.Add(Me.ImgModificarB)
        Me.GroupBox1.Controls.Add(Me.ImgModificarA)
        Me.GroupBox1.Controls.Add(Me.ImgSalirB)
        Me.GroupBox1.Controls.Add(Me.ImgSalirA)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 58)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(759, 183)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Folio Fiscales"
        '
        'ImgGuardarB
        '
        Me.ImgGuardarB.BackColor = System.Drawing.Color.Transparent
        Me.ImgGuardarB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgGuardarB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.img_guardar
        Me.ImgGuardarB.Location = New System.Drawing.Point(587, 59)
        Me.ImgGuardarB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ImgGuardarB.Name = "ImgGuardarB"
        Me.ImgGuardarB.Size = New System.Drawing.Size(55, 47)
        Me.ImgGuardarB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgGuardarB.TabIndex = 61
        Me.ImgGuardarB.TabStop = false
        Me.ToolTip1.SetToolTip(Me.ImgGuardarB, "Guardar Nuevo")
        Me.ImgGuardarB.Visible = false
        '
        'ImgGuardarA
        '
        Me.ImgGuardarA.BackColor = System.Drawing.Color.Transparent
        Me.ImgGuardarA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.img_guardar
        Me.ImgGuardarA.Location = New System.Drawing.Point(589, 62)
        Me.ImgGuardarA.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ImgGuardarA.Name = "ImgGuardarA"
        Me.ImgGuardarA.Size = New System.Drawing.Size(47, 39)
        Me.ImgGuardarA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgGuardarA.TabIndex = 60
        Me.ImgGuardarA.TabStop = false
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(427, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 23)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Label1"
        '
        'ImgModificarB
        '
        Me.ImgModificarB.BackColor = System.Drawing.Color.Transparent
        Me.ImgModificarB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgModificarB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.img_guardar
        Me.ImgModificarB.Location = New System.Drawing.Point(587, 59)
        Me.ImgModificarB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ImgModificarB.Name = "ImgModificarB"
        Me.ImgModificarB.Size = New System.Drawing.Size(55, 47)
        Me.ImgModificarB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgModificarB.TabIndex = 63
        Me.ImgModificarB.TabStop = false
        Me.ToolTip1.SetToolTip(Me.ImgModificarB, "Guardar Modificación")
        Me.ImgModificarB.Visible = false
        '
        'ImgModificarA
        '
        Me.ImgModificarA.BackColor = System.Drawing.Color.Transparent
        Me.ImgModificarA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.img_guardar
        Me.ImgModificarA.Location = New System.Drawing.Point(591, 63)
        Me.ImgModificarA.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ImgModificarA.Name = "ImgModificarA"
        Me.ImgModificarA.Size = New System.Drawing.Size(47, 39)
        Me.ImgModificarA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgModificarA.TabIndex = 62
        Me.ImgModificarA.TabStop = false
        Me.ImgModificarA.Visible = false
        '
        'ImgSalirB
        '
        Me.ImgSalirB.BackColor = System.Drawing.Color.Transparent
        Me.ImgSalirB.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ImgSalirB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgSalirB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.btn_salir
        Me.ImgSalirB.Location = New System.Drawing.Point(549, 129)
        Me.ImgSalirB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ImgSalirB.Name = "ImgSalirB"
        Me.ImgSalirB.Size = New System.Drawing.Size(125, 43)
        Me.ImgSalirB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSalirB.TabIndex = 52
        Me.ImgSalirB.TabStop = false
        Me.ToolTip1.SetToolTip(Me.ImgSalirB, "Salir (Esc)")
        Me.ImgSalirB.Visible = false
        '
        'ImgSalirA
        '
        Me.ImgSalirA.BackColor = System.Drawing.Color.Transparent
        Me.ImgSalirA.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ImgSalirA.Cursor = System.Windows.Forms.Cursors.Default
        Me.ImgSalirA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.btn_salir
        Me.ImgSalirA.Location = New System.Drawing.Point(553, 132)
        Me.ImgSalirA.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ImgSalirA.Name = "ImgSalirA"
        Me.ImgSalirA.Size = New System.Drawing.Size(117, 38)
        Me.ImgSalirA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSalirA.TabIndex = 51
        Me.ImgSalirA.TabStop = false
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'FrmFolioAME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(791, 287)
        Me.ControlBox = false
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = true
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = false
        Me.Name = "FrmFolioAME"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Text = "Folios Fiscales"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.ImgGuardarB,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ImgGuardarA,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ImgModificarB,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ImgModificarA,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ImgSalirB,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ImgSalirA,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents TxtFolioAct As System.Windows.Forms.TextBox
    Friend WithEvents TxtfolioIni As System.Windows.Forms.TextBox
    Friend WithEvents txtFilioFin As System.Windows.Forms.TextBox
    Friend WithEvents lbldocumento As System.Windows.Forms.Label
    Friend WithEvents lblinicial As System.Windows.Forms.Label
    Friend WithEvents lblfinal As System.Windows.Forms.Label
    Friend WithEvents lblfolioactual As System.Windows.Forms.Label
    Friend WithEvents CmbTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImgSalirB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgSalirA As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ImgGuardarB As System.Windows.Forms.PictureBox
    Friend WithEvents ImgGuardarA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgModificarA As System.Windows.Forms.PictureBox
    Friend WithEvents ImgModificarB As System.Windows.Forms.PictureBox
End Class
