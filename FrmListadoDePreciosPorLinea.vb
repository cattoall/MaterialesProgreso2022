Imports System.Data.SqlClient

Public Class FrmListadoDePreciosPorLinea
    Private Sub FrmListadoDePreciosPorLinea_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                Me.Close()
            Case Keys.F2
                If RadioButton1.Checked = True Then
                    Buscar_Clientes = "LINEAS"
                    FrmBuscarClientesVentas.ShowDialog()
                    FrmBuscarClientesVentas.Close()
                    Limpia_Variables_SQL_y_Cierra_Conexion()
                Else
                    MsgBox("Selecciona la Opción Cliente para Acceder", MsgBoxStyle.Critical, "Reporte de Productos por Linea")
                End If
        End Select
    End Sub

    Private Sub FrmListadoDePreciosPorLinea_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Me.BackColor = My.Settings.FormsBackColor
        'Me.GroupBox1.ForeColor = My.Settings.FontForeColor
        'Me.GroupBox1.Font = My.Settings.FontStyle
        'Me.GroupBox2.ForeColor = My.Settings.FontForeColor
        'Me.GroupBox2.Font = My.Settings.FontStyle

        'CmdCliente.Font = My.Settings.FontStyle
        'CmdCliente.ForeColor = My.Settings.FontForeColor
        'CmdCliente.BackColor = My.Settings.FormsBackColor
        'BtnBuscar.Font = My.Settings.FontStyle
        'BtnBuscar.ForeColor = My.Settings.FontForeColor
        'BtnBuscar.BackColor = My.Settings.FormsBackColor

        'CmdImprimir.Font = My.Settings.FontStyle
        'CmdImprimir.ForeColor = My.Settings.FontForeColor
        'CmdImprimir.BackColor = My.Settings.FormsBackColor

        Llena_Lineas()
        RadioButton1.Checked = True
        ImgBuscarA.Enabled = True
        cmbprecio.Visible = False
        precio_linea = ""
        txtcliente.Text = ""
        DataGridView1.Refresh()
        DataGridView1.Rows.Clear()
        DataGridView1.ResumeLayout()
        Limpia_Variables_SQL_y_Cierra_Conexion()
    End Sub
    Private Sub Llena_Lineas()
        Dim dt_tmp As DataTable
        Try
            SQL = "SELECT * from lineas order by descripcion asc"
            conn.Open()
            If conn.State = ConnectionState.Open Then
                myCommand = New SqlCommand(SQL, conn)
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDs)
                dt_tmp = New DataTable
                dt_tmp.Clear()
                myAdapter.Fill(dt_tmp)
                cmblineas.DataSource = dt_tmp
                cmblineas.DisplayMember = "descripcion"
                cmblineas.ValueMember = "clave"

                cmblineas.SelectedIndex = -1

                Dim row As DataRow = dt_tmp.Select("descripcion = '" & Material_Linea & "'").FirstOrDefault()
                If Not row Is Nothing Then
                    cmblineas.SelectedValue = row.Item("clave")
                End If
                Limpia_Variables_SQL_y_Cierra_Conexion()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Limpia_Variables_SQL_y_Cierra_Conexion()
        End Try
    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As System.EventArgs) Handles RadioButton1.Click
        cmbprecio.SelectedIndex = -1
        cmbprecio.Enabled = False
        txtcliente.Enabled = False
        ImgBuscarA.Enabled = True
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As System.EventArgs) Handles RadioButton2.Click
        txtcliente.Enabled = False
        ImgBuscarA.Enabled = False
        cmbprecio.Enabled = True
        cmbprecio.Visible = True
        txtcliente.Clear()
    End Sub

    Private Sub cmbprecio_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles cmbprecio.SelectionChangeCommitted
        precio_linea = cmbprecio.Text
    End Sub

    Private Sub ImgSalirB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgSalirB.MouseLeave
        Me.ImgSalirA.Visible = True
        Me.ImgSalirB.Visible = False
    End Sub

    Private Sub ImgSalirA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgSalirA.MouseHover
        Me.ImgSalirB.Visible = True
        Me.ImgSalirA.Visible = False
    End Sub

    Private Sub ImgReImpB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgReImpB.MouseLeave
        Me.ImgReImpA.Visible = True
        Me.ImgReImpB.Visible = False
    End Sub

    Private Sub ImgReImpA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgReImpA.MouseHover
        Me.ImgReImpB.Visible = True
        Me.ImgReImpA.Visible = False
    End Sub

    Private Sub ImgGenerarB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgGenerarB.MouseLeave
        Me.ImgGenerarA.Visible = True
        Me.ImgGenerarB.Visible = False
    End Sub

    Private Sub ImgGenerarA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgGenerarA.MouseHover
        Me.ImgGenerarB.Visible = True
        Me.ImgGenerarA.Visible = False
    End Sub

    Private Sub ImgBuscarB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgBuscarB.MouseLeave
        Me.ImgBuscarA.Visible = True
        Me.ImgBuscarB.Visible = False
    End Sub

    Private Sub ImgBuscarA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgBuscarA.MouseHover
        Me.ImgBuscarB.Visible = True
        Me.ImgBuscarA.Visible = False
    End Sub

    Private Sub ImgSalirB_Click(sender As System.Object, e As System.EventArgs) Handles ImgSalirB.Click
        Me.Close()
    End Sub

    Private Sub ImgReImpB_Click(sender As System.Object, e As System.EventArgs) Handles ImgReImpB.Click
        If DataGridView1.RowCount > 0 Then
            ImprimeProductosLista(txtcliente.Text, precio_linea, cmblineas.Text, dt)
        Else
            MsgBox("No existen datos para generar la Impresión", MsgBoxStyle.Critical, "Reporte de Productos por Linea")
        End If
    End Sub

End Class