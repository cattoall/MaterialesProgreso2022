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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.mBtnSave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'TxtFolioAct
        '
        Me.TxtFolioAct.Location = New System.Drawing.Point(183, 140)
        Me.TxtFolioAct.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtFolioAct.Name = "TxtFolioAct"
        Me.TxtFolioAct.Size = New System.Drawing.Size(240, 30)
        Me.TxtFolioAct.TabIndex = 1
        '
        'TxtfolioIni
        '
        Me.TxtfolioIni.Location = New System.Drawing.Point(183, 71)
        Me.TxtfolioIni.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtfolioIni.Name = "TxtfolioIni"
        Me.TxtfolioIni.Size = New System.Drawing.Size(240, 30)
        Me.TxtfolioIni.TabIndex = 2
        '
        'txtFilioFin
        '
        Me.txtFilioFin.Location = New System.Drawing.Point(183, 106)
        Me.txtFilioFin.Margin = New System.Windows.Forms.Padding(4)
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
        Me.CmbTipoDoc.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbTipoDoc.Name = "CmbTipoDoc"
        Me.CmbTipoDoc.Size = New System.Drawing.Size(240, 31)
        Me.CmbTipoDoc.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mBtnSave)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtfolioIni)
        Me.GroupBox1.Controls.Add(Me.TxtFolioAct)
        Me.GroupBox1.Controls.Add(Me.txtFilioFin)
        Me.GroupBox1.Controls.Add(Me.lbldocumento)
        Me.GroupBox1.Controls.Add(Me.CmbTipoDoc)
        Me.GroupBox1.Controls.Add(Me.lblinicial)
        Me.GroupBox1.Controls.Add(Me.lblfolioactual)
        Me.GroupBox1.Controls.Add(Me.lblfinal)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 58)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(759, 183)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Folio Fiscales"
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
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.close_window_16px
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(652, 143)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 82
        Me.Button2.Text = "Salir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = true
        '
        'mBtnSave
        '
        Me.mBtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mBtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.mBtnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47,Byte),Integer), CType(CType(170,Byte),Integer), CType(CType(141,Byte),Integer))
        Me.mBtnSave.Image = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.save_16px
        Me.mBtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mBtnSave.Location = New System.Drawing.Point(462, 140)
        Me.mBtnSave.Name = "mBtnSave"
        Me.mBtnSave.Size = New System.Drawing.Size(100, 28)
        Me.mBtnSave.TabIndex = 131
        Me.mBtnSave.Text = "Guardar"
        Me.mBtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mBtnSave.UseVisualStyleBackColor = true
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
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = false
        Me.Name = "FrmFolioAME"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button2 As Button
    Friend WithEvents mBtnSave As Button
End Class
