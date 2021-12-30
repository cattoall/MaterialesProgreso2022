<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFolioAME
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
        Me.GroupBox1.SuspendLayout()
        CType(Me.ImgGuardarB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgGuardarA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgModificarB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgModificarA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSalirB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgSalirA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtFolioAct
        '
        Me.TxtFolioAct.Location = New System.Drawing.Point(137, 114)
        Me.TxtFolioAct.Name = "TxtFolioAct"
        Me.TxtFolioAct.Size = New System.Drawing.Size(181, 26)
        Me.TxtFolioAct.TabIndex = 1
        '
        'TxtfolioIni
        '
        Me.TxtfolioIni.Location = New System.Drawing.Point(137, 58)
        Me.TxtfolioIni.Name = "TxtfolioIni"
        Me.TxtfolioIni.Size = New System.Drawing.Size(181, 26)
        Me.TxtfolioIni.TabIndex = 2
        '
        'txtFilioFin
        '
        Me.txtFilioFin.Location = New System.Drawing.Point(137, 86)
        Me.txtFilioFin.Name = "txtFilioFin"
        Me.txtFilioFin.Size = New System.Drawing.Size(181, 26)
        Me.txtFilioFin.TabIndex = 3
        '
        'lbldocumento
        '
        Me.lbldocumento.AutoSize = True
        Me.lbldocumento.BackColor = System.Drawing.Color.Transparent
        Me.lbldocumento.Location = New System.Drawing.Point(9, 31)
        Me.lbldocumento.Name = "lbldocumento"
        Me.lbldocumento.Size = New System.Drawing.Size(119, 19)
        Me.lbldocumento.TabIndex = 5
        Me.lbldocumento.Text = "Tipo Documento"
        '
        'lblinicial
        '
        Me.lblinicial.AutoSize = True
        Me.lblinicial.BackColor = System.Drawing.Color.Transparent
        Me.lblinicial.Location = New System.Drawing.Point(43, 61)
        Me.lblinicial.Name = "lblinicial"
        Me.lblinicial.Size = New System.Drawing.Size(87, 19)
        Me.lblinicial.TabIndex = 6
        Me.lblinicial.Text = "Folio Inicial"
        '
        'lblfinal
        '
        Me.lblfinal.AutoSize = True
        Me.lblfinal.BackColor = System.Drawing.Color.Transparent
        Me.lblfinal.Location = New System.Drawing.Point(50, 89)
        Me.lblfinal.Name = "lblfinal"
        Me.lblfinal.Size = New System.Drawing.Size(79, 19)
        Me.lblfinal.TabIndex = 7
        Me.lblfinal.Text = "Folio Final"
        '
        'lblfolioactual
        '
        Me.lblfolioactual.AutoSize = True
        Me.lblfolioactual.BackColor = System.Drawing.Color.Transparent
        Me.lblfolioactual.Location = New System.Drawing.Point(41, 117)
        Me.lblfolioactual.Name = "lblfolioactual"
        Me.lblfolioactual.Size = New System.Drawing.Size(88, 19)
        Me.lblfolioactual.TabIndex = 8
        Me.lblfolioactual.Text = "Folio Actual"
        '
        'CmbTipoDoc
        '
        Me.CmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipoDoc.FormattingEnabled = True
        Me.CmbTipoDoc.Items.AddRange(New Object() {"FACTURAS", "NOTAS DE CREDITO", "PAGOS"})
        Me.CmbTipoDoc.Location = New System.Drawing.Point(137, 28)
        Me.CmbTipoDoc.Name = "CmbTipoDoc"
        Me.CmbTipoDoc.Size = New System.Drawing.Size(181, 27)
        Me.CmbTipoDoc.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
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
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 149)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Folio Fiscales"
        '
        'ImgGuardarB
        '
        Me.ImgGuardarB.BackColor = System.Drawing.Color.Transparent
        Me.ImgGuardarB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgGuardarB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.img_guardar
        Me.ImgGuardarB.Location = New System.Drawing.Point(440, 48)
        Me.ImgGuardarB.Name = "ImgGuardarB"
        Me.ImgGuardarB.Size = New System.Drawing.Size(41, 38)
        Me.ImgGuardarB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgGuardarB.TabIndex = 61
        Me.ImgGuardarB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgGuardarB, "Guardar Nuevo")
        Me.ImgGuardarB.Visible = False
        '
        'ImgGuardarA
        '
        Me.ImgGuardarA.BackColor = System.Drawing.Color.Transparent
        Me.ImgGuardarA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.img_guardar
        Me.ImgGuardarA.Location = New System.Drawing.Point(442, 50)
        Me.ImgGuardarA.Name = "ImgGuardarA"
        Me.ImgGuardarA.Size = New System.Drawing.Size(35, 32)
        Me.ImgGuardarA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgGuardarA.TabIndex = 60
        Me.ImgGuardarA.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(320, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 19)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Label1"
        '
        'ImgModificarB
        '
        Me.ImgModificarB.BackColor = System.Drawing.Color.Transparent
        Me.ImgModificarB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgModificarB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.img_guardar
        Me.ImgModificarB.Location = New System.Drawing.Point(440, 48)
        Me.ImgModificarB.Name = "ImgModificarB"
        Me.ImgModificarB.Size = New System.Drawing.Size(41, 38)
        Me.ImgModificarB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgModificarB.TabIndex = 63
        Me.ImgModificarB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgModificarB, "Guardar Modificación")
        Me.ImgModificarB.Visible = False
        '
        'ImgModificarA
        '
        Me.ImgModificarA.BackColor = System.Drawing.Color.Transparent
        Me.ImgModificarA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.img_guardar
        Me.ImgModificarA.Location = New System.Drawing.Point(443, 51)
        Me.ImgModificarA.Name = "ImgModificarA"
        Me.ImgModificarA.Size = New System.Drawing.Size(35, 32)
        Me.ImgModificarA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgModificarA.TabIndex = 62
        Me.ImgModificarA.TabStop = False
        Me.ImgModificarA.Visible = False
        '
        'ImgSalirB
        '
        Me.ImgSalirB.BackColor = System.Drawing.Color.Transparent
        Me.ImgSalirB.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ImgSalirB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgSalirB.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.btn_salir
        Me.ImgSalirB.Location = New System.Drawing.Point(412, 105)
        Me.ImgSalirB.Name = "ImgSalirB"
        Me.ImgSalirB.Size = New System.Drawing.Size(94, 35)
        Me.ImgSalirB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSalirB.TabIndex = 52
        Me.ImgSalirB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgSalirB, "Salir (Esc)")
        Me.ImgSalirB.Visible = False
        '
        'ImgSalirA
        '
        Me.ImgSalirA.BackColor = System.Drawing.Color.Transparent
        Me.ImgSalirA.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ImgSalirA.Cursor = System.Windows.Forms.Cursors.Default
        Me.ImgSalirA.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.btn_salir
        Me.ImgSalirA.Location = New System.Drawing.Point(415, 107)
        Me.ImgSalirA.Name = "ImgSalirA"
        Me.ImgSalirA.Size = New System.Drawing.Size(88, 31)
        Me.ImgSalirA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgSalirA.TabIndex = 51
        Me.ImgSalirA.TabStop = False
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(593, 164)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmFolioAME"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Folios Fiscales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ImgGuardarB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgGuardarA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgModificarB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgModificarA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSalirB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgSalirA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
