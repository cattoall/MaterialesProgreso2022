Imports System.Data.SqlClient

Public Class FrmHistoProveedores
    Private Sub CmdVerVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdVerVenta.Click
        If idProveedor = "0" Then
            MsgBox("Favor de Seleccionar un Proveedor, presiona F2", MsgBoxStyle.Information, "Historial de Proveedores")
            Exit Sub
        End If
        SQL = "SELECT idTransaccion, fecha, total, tipo, usuario,   proveedor, idProveedor, estado, motivo, numeroFactura FROM compras where idproveedor = " & idProveedor & " and   fecha  >= '" & Format(dtFechaInicial.Value.Date, "yyyy-MM-dd") & "' and fecha <= '" & Format(dtFechaFinal.Value.Date, "yyyy-MM-dd") & "'"

        'Carga Lista de Clasificaciones
        'load_record_dgv5(SQL, Me.DataGridView1, DBConnected)

        'Aplica formato al DataGridView
        load_layout_dgv_proveedor_histo(Me.DataGridView1)

        For i = 0 To DataGridView1.RowCount - 1
            Label2.Text = CStr(CDbl(Label2.Text) + CDbl(DataGridView1.Item(2, i).Value))
        Next
        Label2.Text = FormatCurrency(Label2.Text, 2)
    End Sub

    Private Sub FrmHistoProveedores_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.F2
                Call CmdProveedor_Click(sender, e)
            Case Keys.F9
                Call CmdVerVenta_Click(sender, e)
            Case Keys.F3
                Call CmdLimpiar_Click(sender, e)
            Case Keys.Escape
                Call CmdSalir_Click(sender, e)
        End Select
    End Sub

    Private Sub FrmHistoProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bs5.DataSource = Nothing
        dt5.Clear()
        Llena_Grupos()
        With Me.DataGridView1
            ' alternar color de filas
            '.AlternatingRowsDefaultCellStyle.BackColor = My.Settings.BackColorAlt
            '.DefaultCellStyle.BackColor = My.Settings.BackColor
            '.DefaultCellStyle.Font = My.Settings.RowFont
            '.ColumnHeadersDefaultCellStyle.Font = My.Settings.HeaderFont
            ' Establecer el origen de datos para el DataGridview   
            .DataSource = bs5
        End With

        txtCliente.Text = "RAZON SOCIAL"
        idProveedor = "0"
        dtFechaFinal.Value = Now
        dtFechaInicial.Value = Now
    End Sub

    Private Sub Llena_Grupos()
        Dim dt_tmp As DataTable
        Try
            SQL = "SELECT clave, razonSocial FROM proveedor order by razonsocial asc"
            conn.Open()
            If conn.State = ConnectionState.Open Then
                myCommand = New SqlCommand(SQL, conn)
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDs)
                dt_tmp = New DataTable
                dt_tmp.Clear()
                myAdapter.Fill(dt_tmp)
                'cmbElijeCliente.DataSource = dt_tmp
                'cmbElijeCliente.ValueMember = "clave"
                'cmbElijeCliente.DisplayMember = "razonSocial"

                Limpia_Variables_SQL_y_Cierra_Conexion()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Limpia_Variables_SQL_y_Cierra_Conexion()
        End Try
    End Sub

    Private Sub CmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSalir.Click
        Me.Close()
    End Sub

    Private Sub CmdProveedor_Click(sender As System.Object, e As System.EventArgs) Handles CmdProveedor.Click
        idProveedor = "0"
        Buscar_Proveedores = "PROVEEDORES"
        FrmBuscarProveedorVenta.ShowDialog()
        FrmBuscarProveedorVenta.Close()
        If idProveedor <> "0" Then
            Call CmdVerVenta_Click(sender, e)
        End If
    End Sub

    Private Sub CmdLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles CmdLimpiar.Click
        Label2.Text = "0.00"
        txtCliente.Text = "RAZON SOCIAL"
        dtFechaInicial.Value = DateTime.Today
        dtFechaFinal.Value = DateTime.Today

        bs5.DataSource = Nothing
        dt5.Clear()
        With Me.DataGridView1
            ' alternar color de filas
            '.AlternatingRowsDefaultCellStyle.BackColor = My.Settings.BackColorAlt
            '.DefaultCellStyle.BackColor = My.Settings.BackColor
            '.DefaultCellStyle.Font = My.Settings.RowFont
            '.ColumnHeadersDefaultCellStyle.Font = My.Settings.HeaderFont
            ' Establecer el origen de datos para el DataGridview   
            .DataSource = bs5
        End With
    End Sub
End Class