
Public Class FrmCuentasPorCobrar

    Private Sub FrmCuentasPorCobrar_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.F2
                Call btnBuscar_Click(sender, e)
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub FrmCuentasPorCobrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bs.DataSource = Nothing
        bs2.DataSource = Nothing
        bs3.DataSource = Nothing
        dt.Clear()
        dt2.Clear()
        dt3.Clear()
        With Me.DataGridView1
            .DataSource = bs3
        End With

        With Me.DataGridView2
            .DataSource = bs2
        End With

        lblabonado.Text = "0"
        lblgrantotal.Text = "0"
        lblresto.Text = "0"
        TxtCliente.Text = "<PRESIONA F2 PARA SELECCIONAR UN CLIENTE>"
        TxtDomicilio.Text = ""
        MetroTabControl1.SelectedIndex = 0
    End Sub

    Private Sub cmbnombre_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs)
        llenar_datagrid()
    End Sub

    Private Sub llenar_datagrid()
        Dim lv_dbselected As String = String.Empty
        Select Case DBConnected
            Case "Wendy"
                lv_dbselected = "pv"
            Case "Librada"
                lv_dbselected = "pv_new"
            Case "Salvador"
                lv_dbselected = "pv_salvador"
        End Select

        SQL = "SELECT *, CASE WHEN tipoDocumento = 'TICKET' THEN (Select numeroFactura from [" & lv_dbselected & "].[venta] where nticket = n_remision) ELSE (Select numeroFactura from [" & lv_dbselected & "].[venta_pedido] where nticket = n_remision) END AS Facturado FROM [" & lv_dbselected & "].[cobrar] where claveCliente= '" & idClienteVenta & "' and  resto <> 0 order by n_remision, fecha_venta desc "

        'Carga Lista de Clasificaciones
        load_record_dgv_cxc(SQL, Me.DataGridView1, DBConnected)

        'Aplica formato al DataGridView
        load_layout_dgv_cuentasxcobrar(Me.DataGridView1)

        For i = 0 To DataGridView1.RowCount - 1

        Next

        SQL2 = "SELECT * FROM [" & lv_dbselected & "].[historial_pagos] where claveCliente = '" & idClienteVenta & "' order by fecha asc"

        'Carga Lista de Clasificaciones
        load_record_dgv2(SQL2, Me.DataGridView2, DBConnected)

        'Aplica formato al DataGridView
        load_layout_dgv_cuentaxcobrar2(Me.DataGridView2)

        lblgrantotal.Text = 0
        lblresto.Text = 0
        For i = 0 To DataGridView1.RowCount - 1
            lblgrantotal.Text = CDbl(lblgrantotal.Text) + CDbl(DataGridView1.Item(2, i).Value)
            lblresto.Text = CDbl(lblresto.Text) + CDbl(DataGridView1.Item(6, i).Value)
        Next
        lblgrantotal.Text = FormatCurrency(lblgrantotal.Text, 2)
        lblresto.Text = FormatCurrency(lblresto.Text, 2)

        resto_total = lblresto.Text

        lblabonado.Text = 0
        For i = 0 To DataGridView2.RowCount - 1
            lblabonado.Text = CDbl(lblabonado.Text) + CDbl(DataGridView2.Item(3, i).Value)
        Next
        lblabonado.Text = FormatCurrency(lblabonado.Text, 2)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        venta = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        resto = Format(DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value, "$ ###,###,##0.00")
        cliente = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value
        idcliente = DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value
        fecha = Format(DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value, "yyyy-MM-dd")
        fechaL = Format(DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value, "yyyy-MM-dd")
        tipodoc = DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value
        total = Format(DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value, "$ ###,###,##0.00")
        total_nota = Format(DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value, "$ ###,###,##0.00")
        abono_total = lblresto.Text
        cliente_abono = TxtCliente.Text
        SetFormName(FrmGenerarAbono, DBConnected)
        FrmGenerarAbono.ShowDialog()
        llenar_datagrid()
    End Sub

    Private Sub CancelarAbono()
        Dim lv_tmp As String = DataGridView2.Item(3, DataGridView2.CurrentRow.Index).Value
        Dim lv_resto As Double = 0
        Dim lv_remision As String
        lv_tmp = Trim(lv_tmp.Replace("$", ""))
        lv_tmp = Trim(lv_tmp.Replace(",", ""))

        lv_resto = lv_tmp
        lv_remision = DataGridView2.Rows(DataGridView2.CurrentRow.Index).Cells(2).Value

        Sql1.Clear()
        Sql1.Append("UPDATE cobrar SET resto = resto + ")
        Sql1.AppendFormat("{0} ", lv_resto)
        Sql1.Append("where n_remision = ")
        Sql1.AppendFormat("{0} ", lv_remision)
        Sql1.Append("and claveCliente = ")
        Sql1.AppendFormat("{0} ", CInt(DataGridView2.Rows(DataGridView2.CurrentRow.Index).Cells(4).Value))
        If Insertar_Registro(Sql1.ToString, DBConnected) = False Then
            MsgBox("No se pudo Actualizar registro en la tabla Cobrar", MsgBoxStyle.Critical, "Actualizar Tabla Cobrar")
            Error_Venta = False
            Exit Sub
        End If

        Sql1.Clear()
        Sql1.Append("delete from historial_pagos where id= ")
        Sql1.AppendFormat("{0} ", DataGridView2.Rows(DataGridView2.CurrentRow.Index).Cells(0).Value)
        If Insertar_Registro(Sql1.ToString, DBConnected) = False Then
            MsgBox("No se pudo Actualizar registro en la tabla Cobrar", MsgBoxStyle.Critical, "Actualizar Tabla Cobrar")
            Error_Venta = False
            Exit Sub
        End If

        MsgBox("El Abono Ha sido Cancelado!", MsgBoxStyle.Information, "Cancelar Abono")

        llenar_datagrid()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        AbonoSeleccionado = True
    End Sub

    Private Sub DataGridView2_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentDoubleClick
        AbonoSeleccionado = True
    End Sub

    Private Sub DataGridView2_CellContextMenuStripChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContextMenuStripChanged
        AbonoSeleccionado = True
    End Sub

    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        AbonoSeleccionado = True
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Buscar_Clientes = "PAGOS"
        SetFormName(FrmBuscarClientesVentas, DBConnected)
        FrmBuscarClientesVentas.ShowDialog()
        FrmBuscarClientesVentas.Close()
        TxtCliente.Select()
        idTipoPrecioCliente = ""
        If idClienteVenta <> "0" Then
            llenar_datagrid()
        End If
    End Sub

    Private Sub btnCancelarAbono_Click(sender As Object, e As EventArgs)
        Select Case AbonoSeleccionado
            Case True
                CancelarAbono()
                AbonoSeleccionado = False
            Case False
                MsgBox("Favor de Seleccionar el Abono que desea Cancelar.", MsgBoxStyle.Information, "Cancelar Abono")
        End Select
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        TxtCliente.Text = "<PRESIONA F2 PARA SELECCIONAR UN CLIENTE>"
        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()
        DataGridView1.Rows.Clear()
        DataGridView1.ResumeLayout()
        TxtDomicilio.Clear()
        Me.Close()
    End Sub
End Class