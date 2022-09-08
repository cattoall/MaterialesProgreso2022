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
        Me.mBtnSave = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
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
        Me.GroupBox1.Controls.Add(Me.mBtnSave)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.lblYear)
        Me.GroupBox1.Controls.Add(Me.TxtfolioIni)
        Me.GroupBox1.Controls.Add(Me.TxtFolioAct)
        Me.GroupBox1.Controls.Add(Me.txtFilioFin)
        Me.GroupBox1.Controls.Add(Me.lbldocumento)
        Me.GroupBox1.Controls.Add(Me.CmbTipoDoc)
        Me.GroupBox1.Controls.Add(Me.lblinicial)
        Me.GroupBox1.Controls.Add(Me.lblfolioactual)
        Me.GroupBox1.Controls.Add(Me.lblfinal)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 149)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Folio Fiscales"
        '
        'mBtnSave
        '
        Me.mBtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mBtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mBtnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.mBtnSave.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.save_16px
        Me.mBtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mBtnSave.Location = New System.Drawing.Point(346, 114)
        Me.mBtnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.mBtnSave.Name = "mBtnSave"
        Me.mBtnSave.Size = New System.Drawing.Size(75, 23)
        Me.mBtnSave.TabIndex = 131
        Me.mBtnSave.Text = "Guardar"
        Me.mBtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mBtnSave.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Red
        Me.btnSalir.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.close_window_16px
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.Location = New System.Drawing.Point(489, 116)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 82
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.BackColor = System.Drawing.Color.Transparent
        Me.lblYear.Location = New System.Drawing.Point(320, 31)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(36, 19)
        Me.lblYear.TabIndex = 27
        Me.lblYear.Text = "Año"
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
        Me.ClientSize = New System.Drawing.Size(593, 233)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmFolioAME"
        Me.Text = "Folios Fiscales"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
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
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnSalir As Button
    Friend WithEvents mBtnSave As Button
End Class
