<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCuentasPorCobrar
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.CmdCliente = New System.Windows.Forms.Label()
        Me.btnBuscar = New MetroFramework.Controls.MetroButton()
        Me.TxtDomicilio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblresto = New System.Windows.Forms.Label()
        Me.lblabonado = New System.Windows.Forms.Label()
        Me.lblgrantotal = New System.Windows.Forms.Label()
        Me.Lblabono = New System.Windows.Forms.Label()
        Me.lblrest = New System.Windows.Forms.Label()
        Me.Lbltotal = New System.Windows.Forms.Label()
        Me.btnSalir = New MetroFramework.Controls.MetroButton()
        Me.btnCancelarAbono = New MetroFramework.Controls.MetroButton()
        Me.MetroTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.TabPage1)
        Me.MetroTabControl1.Controls.Add(Me.TabPage2)
        Me.MetroTabControl1.Location = New System.Drawing.Point(35, 166)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(1023, 481)
        Me.MetroTabControl1.TabIndex = 4
        Me.MetroTabControl1.UseSelectable = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1015, 439)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pendiente de Pago"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1009, 433)
        Me.DataGridView1.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnCancelarAbono)
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1015, 439)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Histórico de Pagos"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(0, 3)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(1015, 394)
        Me.DataGridView2.TabIndex = 2
        '
        'TxtCliente
        '
        Me.TxtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCliente.Enabled = False
        Me.TxtCliente.Location = New System.Drawing.Point(98, 70)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(399, 20)
        Me.TxtCliente.TabIndex = 31
        Me.TxtCliente.Text = "<PRESIONA F2 PARA SELECCIONAR UN CLIENTE>"
        '
        'CmdCliente
        '
        Me.CmdCliente.AutoSize = True
        Me.CmdCliente.BackColor = System.Drawing.Color.Transparent
        Me.CmdCliente.Location = New System.Drawing.Point(32, 73)
        Me.CmdCliente.Name = "CmdCliente"
        Me.CmdCliente.Size = New System.Drawing.Size(42, 13)
        Me.CmdCliente.TabIndex = 30
        Me.CmdCliente.Text = "Cliente:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(503, 67)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 32
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseSelectable = True
        '
        'TxtDomicilio
        '
        Me.TxtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDomicilio.Enabled = False
        Me.TxtDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDomicilio.Location = New System.Drawing.Point(98, 95)
        Me.TxtDomicilio.Multiline = True
        Me.TxtDomicilio.Name = "TxtDomicilio"
        Me.TxtDomicilio.Size = New System.Drawing.Size(399, 65)
        Me.TxtDomicilio.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(32, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Domicilio"
        '
        'lblresto
        '
        Me.lblresto.AutoSize = True
        Me.lblresto.BackColor = System.Drawing.Color.Transparent
        Me.lblresto.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresto.ForeColor = System.Drawing.Color.Red
        Me.lblresto.Location = New System.Drawing.Point(856, 139)
        Me.lblresto.Name = "lblresto"
        Me.lblresto.Size = New System.Drawing.Size(21, 24)
        Me.lblresto.TabIndex = 40
        Me.lblresto.Text = "0"
        '
        'lblabonado
        '
        Me.lblabonado.AutoSize = True
        Me.lblabonado.BackColor = System.Drawing.Color.Transparent
        Me.lblabonado.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblabonado.Location = New System.Drawing.Point(856, 103)
        Me.lblabonado.Name = "lblabonado"
        Me.lblabonado.Size = New System.Drawing.Size(21, 24)
        Me.lblabonado.TabIndex = 39
        Me.lblabonado.Text = "0"
        '
        'lblgrantotal
        '
        Me.lblgrantotal.AutoSize = True
        Me.lblgrantotal.BackColor = System.Drawing.Color.Transparent
        Me.lblgrantotal.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgrantotal.Location = New System.Drawing.Point(856, 67)
        Me.lblgrantotal.Name = "lblgrantotal"
        Me.lblgrantotal.Size = New System.Drawing.Size(21, 24)
        Me.lblgrantotal.TabIndex = 38
        Me.lblgrantotal.Text = "0"
        '
        'Lblabono
        '
        Me.Lblabono.AutoSize = True
        Me.Lblabono.BackColor = System.Drawing.Color.Transparent
        Me.Lblabono.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblabono.Location = New System.Drawing.Point(686, 103)
        Me.Lblabono.Name = "Lblabono"
        Me.Lblabono.Size = New System.Drawing.Size(147, 24)
        Me.Lblabono.TabIndex = 37
        Me.Lblabono.Text = "Total Abonado:"
        '
        'lblrest
        '
        Me.lblrest.AutoSize = True
        Me.lblrest.BackColor = System.Drawing.Color.Transparent
        Me.lblrest.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrest.ForeColor = System.Drawing.Color.Red
        Me.lblrest.Location = New System.Drawing.Point(765, 139)
        Me.lblrest.Name = "lblrest"
        Me.lblrest.Size = New System.Drawing.Size(68, 24)
        Me.lblrest.TabIndex = 36
        Me.lblrest.Text = "Resto:"
        '
        'Lbltotal
        '
        Me.Lbltotal.AutoSize = True
        Me.Lbltotal.BackColor = System.Drawing.Color.Transparent
        Me.Lbltotal.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltotal.Location = New System.Drawing.Point(720, 67)
        Me.Lbltotal.Name = "Lbltotal"
        Me.Lbltotal.Size = New System.Drawing.Size(113, 24)
        Me.Lbltotal.TabIndex = 35
        Me.Lbltotal.Text = "Gran Total:"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(503, 136)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 24)
        Me.btnSalir.TabIndex = 42
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseSelectable = True
        '
        'btnCancelarAbono
        '
        Me.btnCancelarAbono.Location = New System.Drawing.Point(448, 399)
        Me.btnCancelarAbono.Name = "btnCancelarAbono"
        Me.btnCancelarAbono.Size = New System.Drawing.Size(118, 38)
        Me.btnCancelarAbono.TabIndex = 42
        Me.btnCancelarAbono.Text = "Cancelar Abono"
        Me.btnCancelarAbono.UseSelectable = True
        '
        'FrmCuentasPorCobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PV_MaterialesElectricosProgreso.My.Resources.Resources.FondoLogin
        Me.ClientSize = New System.Drawing.Size(1107, 659)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblresto)
        Me.Controls.Add(Me.lblabonado)
        Me.Controls.Add(Me.lblgrantotal)
        Me.Controls.Add(Me.Lblabono)
        Me.Controls.Add(Me.lblrest)
        Me.Controls.Add(Me.Lbltotal)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.TxtDomicilio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.TxtCliente)
        Me.Controls.Add(Me.CmdCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmCuentasPorCobrar"
        Me.Text = "Cuentas por Cobrar (Clientes)"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TxtCliente As TextBox
    Friend WithEvents CmdCliente As Label
    Friend WithEvents btnBuscar As MetroFramework.Controls.MetroButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TxtDomicilio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblresto As Label
    Friend WithEvents lblabonado As Label
    Friend WithEvents lblgrantotal As Label
    Friend WithEvents Lblabono As Label
    Friend WithEvents lblrest As Label
    Friend WithEvents Lbltotal As Label
    Friend WithEvents btnSalir As MetroFramework.Controls.MetroButton
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btnCancelarAbono As MetroFramework.Controls.MetroButton
End Class
