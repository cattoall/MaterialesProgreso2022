Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

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

    Private Sub ImgGenerarB_Click(sender As System.Object, e As System.EventArgs) Handles ImgGenerarB.Click

        Dim lv_notfound As Boolean = True

        If cmblineas.SelectedIndex <> 0 Then

            If RadioButton1.Checked = True And txtcliente.Text = "" Then
                MsgBox("Se Necesita Seleccionar un Cliente para Generar Listado", MsgBoxStyle.Critical, "Reporte de Productos por Linea")
                Exit Sub
            ElseIf RadioButton2.Checked = True And cmbprecio.Text = "" Then
                MsgBox("No hay tipo precio seleccionado", MsgBoxStyle.Critical, "Reporte de Productos por Linea")
                Exit Sub
            End If

            DataGridView1.Refresh()
            DataGridView1.Rows.Clear()
            DataGridView1.ResumeLayout()
            Limpia_Variables_SQL_y_Cierra_Conexion()

            If precio_linea = "" Then
                MsgBox("El Tipo de Precio esta vacío", MsgBoxStyle.Critical, "Reporte de Productos por Linea")
                Exit Sub
            End If

            Select Case precio_linea
                Case "Precio Público"
                    SQL = "SELECT clave, codigoBarras, descripcionProducto, unidadMedida, grupo, precioPublico as precio FROM productos WHERE linea = '" & cmblineas.Text & "'  "
                Case "Precio P1"
                    SQL = "SELECT clave, codigoBarras, descripcionProducto, unidadMedida, grupo, precioP1 as precio FROM productos WHERE linea = '" & cmblineas.Text & "'  "
                Case "Precio P2"
                    SQL = "SELECT clave, codigoBarras, descripcionProducto, unidadMedida, grupo, precioP2 as precio FROM productos WHERE linea = '" & cmblineas.Text & "'  "
                Case "Precio P3"
                    SQL = "SELECT clave, codigoBarras, descripcionProducto, unidadMedida, grupo, precioP3 as precio FROM productos WHERE linea = '" & cmblineas.Text & "'  "
                Case Else
                    MsgBox("No se encontró Tipo de Precio, favor de verificar.", MsgBoxStyle.Exclamation, "Reporte de Productos por Linea")
                    lv_notfound = False
            End Select
            If lv_notfound Then
                'Carga Lista de Clasificaciones
                load_record_dgv_best(SQL, Me.DataGridView1, DBConnected)


                If dt.Rows.Count = 0 Then
                    MsgBox("No hay Registros de Productos por Linea", MsgBoxStyle.Information, "Reporte de Productos por Linea")
                    Exit Sub
                End If

                For i = 0 To dt.Rows.Count - 1
                    Dim row As String() = New String() {dt.Rows(i)!clave, dt.Rows(i)!codigoBarras, dt.Rows(i)!descripcionproducto, dt.Rows(i)!unidadmedida, dt.Rows(i)!grupo, dt.Rows(i)!precio}
                    Me.DataGridView1.Rows.Add(row)

                    'Select Case precio_linea
                    '    Case "Precio Público"
                    '        Dim row As String() = New String() {dt.Rows(i)!clave, dt.Rows(i)!codigoBarras, dt.Rows(i)!descripcionproducto, dt.Rows(i)!unidadmedida, dt.Rows(i)!grupo, dt.Rows(i)!precioPublico}
                    '        Me.DataGridView1.Rows.Add(row)
                    '    Case "Precio P1"
                    '        Dim row As String() = New String() {dt.Rows(i)!clave, dt.Rows(i)!codigoBarras, dt.Rows(i)!descripcionproducto, dt.Rows(i)!unidadmedida, dt.Rows(i)!grupo, dt.Rows(i)!precioP1}
                    '        Me.DataGridView1.Rows.Add(row)
                    '    Case "Precio P2"
                    '        Dim row As String() = New String() {dt.Rows(i)!clave, dt.Rows(i)!codigoBarras, dt.Rows(i)!descripcionproducto, dt.Rows(i)!unidadmedida, dt.Rows(i)!grupo, dt.Rows(i)!precioP2}
                    '        Me.DataGridView1.Rows.Add(row)
                    '    Case "Precio P3"
                    '        Dim row As String() = New String() {dt.Rows(i)!clave, dt.Rows(i)!codigoBarras, dt.Rows(i)!descripcionproducto, dt.Rows(i)!unidadmedida, dt.Rows(i)!grupo, dt.Rows(i)!precioP3}
                    '        Me.DataGridView1.Rows.Add(row)
                    'End Select
                Next
            End If
        Else
            MsgBox("Seleccione la Linea para poder Generar un Reporte", MsgBoxStyle.Critical, "Reporte de Productos por Linea")
        End If
    End Sub

    Private Sub ImgBuscarB_Click(sender As System.Object, e As System.EventArgs) Handles ImgBuscarB.Click
        Buscar_Clientes = "LINEAS"
        SetFormName(FrmBuscarClientesVentas, DBConnected)
        FrmBuscarClientesVentas.ShowDialog()
        FrmBuscarClientesVentas.Close()
        Limpia_Variables_SQL_y_Cierra_Conexion()
    End Sub
End Class