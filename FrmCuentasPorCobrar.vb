﻿
Public Class FrmCuentasPorCobrar

    Private Sub FrmCuentasPorCobrar_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.F2
                'Call btnBuscar_Click(sender, e)
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub FrmCuentasPorCobrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Refresh()
        DataGridView2.Refresh()

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

        DataGridView1.Refresh()
        Dim tCobrar As List(Of tblCobrar) = DBModelo.GetCXC_ByIdCliente(CInt(idClienteVenta))

        DataGridView1.DataSource = tCobrar.ToList
        ConfiguraGridCobrar(DataGridView1)


        DataGridView2.Refresh()
        Dim tHistPagos As List(Of tblHistorialPagos) = DBModelo.GetHistorialPago_ByIdCliente(CInt(idClienteVenta))

        DataGridView2.DataSource = tHistPagos.ToList
        ConfiguraGridPagos(DataGridView2)

        lblgrantotal.Text = CStr(0)
        lblresto.Text = CStr(0)
        For i = 0 To DataGridView1.RowCount - 1
            lblgrantotal.Text = CStr(CDbl(lblgrantotal.Text) + CDbl(DataGridView1.Item(3, i).Value))
            lblresto.Text = CStr(CDbl(lblresto.Text) + CDbl(DataGridView1.Item(7, i).Value))
        Next
        lblgrantotal.Text = FormatCurrency(lblgrantotal.Text, 2)
        lblresto.Text = FormatCurrency(lblresto.Text, 2)

        resto_total = lblresto.Text

        lblabonado.Text = CStr(0)
        For i = 0 To DataGridView2.RowCount - 1
            lblabonado.Text = CStr(CDbl(lblabonado.Text) + CDbl(DataGridView2.Item(4, i).Value))
        Next
        lblabonado.Text = FormatCurrency(lblabonado.Text, 2)
    End Sub

    Private Sub ConfiguraGridPagos(ByVal dv As DataGridView)

        dv.Columns(0).Visible = False
        dv.Columns(1).Visible = False

        dv.Columns(2).HeaderText = "Fecha"
        dv.Columns(2).ReadOnly = True
        dv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(2).Width = 100

        dv.Columns(3).HeaderText = "Venta"
        dv.Columns(3).ReadOnly = True
        dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(3).Width = 100

        dv.Columns(4).HeaderText = "Total"
        dv.Columns(4).ReadOnly = True
        dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dv.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(4).DefaultCellStyle.Format = "$ ###,###,##0.00"
        dv.Columns(4).Width = 100

        dv.Columns(5).Visible = False

        dv.Columns(6).HeaderText = "Cliente"
        dv.Columns(6).ReadOnly = True
        dv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dv.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(6).Width = 300

        dv.Columns(7).HeaderText = "Observaciones"
        dv.Columns(7).ReadOnly = True
        dv.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(7).Width = 200

        dv.Columns(8).HeaderText = "TipoDoc"
        dv.Columns(8).ReadOnly = True
        dv.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub ConfiguraGridCobrar(ByVal dv As DataGridView)
        dv.Columns(0).Visible = False
        dv.Columns(1).Visible = False

        dv.Columns(2).HeaderText = "Venta"
        dv.Columns(2).ReadOnly = True
        dv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(2).Width = 110

        dv.Columns(3).HeaderText = "Total"
        dv.Columns(3).ReadOnly = True
        dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dv.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(3).DefaultCellStyle.Format = "$ ###,###,##0.00"
        dv.Columns(3).Width = 110

        dv.Columns(4).HeaderText = "Fecha Venta"
        dv.Columns(4).ReadOnly = True
        dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(4).Width = 110

        dv.Columns(5).HeaderText = "Fecha Límite"
        dv.Columns(5).ReadOnly = True
        dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(5).Width = 110

        dv.Columns(6).HeaderText = "Cliente"
        dv.Columns(6).ReadOnly = True
        dv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dv.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(6).Width = 280

        dv.Columns(7).HeaderText = "Resto"
        dv.Columns(7).ReadOnly = True
        dv.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dv.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(7).DefaultCellStyle.Format = "$ ###,###,##0.00"
        dv.Columns(7).Width = 100

        dv.Columns(8).Visible = False

        dv.Columns(9).HeaderText = "Tipo Doc."
        dv.Columns(9).ReadOnly = True
        dv.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(9).Width = 100

        dv.Columns(10).HeaderText = "Facturado"
        dv.Columns(10).ReadOnly = True
        dv.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(10).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(10).Width = 70
        dv.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub CancelarAbono()
        Dim lv_tmp As String = CStr(DataGridView2.Item(4, DataGridView2.CurrentRow.Index).Value)
        Dim lv_resto As Double = 0
        Dim lv_remision As String
        Dim lv_TipoDoc As String
        Dim lv_IdPago As Integer = CInt(DataGridView2.Rows(DataGridView2.CurrentRow.Index).Cells(1).Value)
        Dim Idcliente As Integer = CInt(DataGridView2.Item(5, DataGridView2.CurrentRow.Index).Value)

        lv_tmp = Trim(lv_tmp.Replace("$", ""))
        lv_tmp = Trim(lv_tmp.Replace(",", ""))

        lv_resto = CDbl(lv_tmp)

        lv_remision = CStr(DataGridView2.Item(3, DataGridView2.CurrentRow.Index).Value)
        lv_TipoDoc = CStr(DataGridView2.Item(8, DataGridView2.CurrentRow.Index).Value)

        Dim w_cobrar As tblCobrar = DBModelo.Get_CobrarTipoDoc(CInt(lv_remision), lv_TipoDoc, Idcliente)

        w_cobrar.resto = w_cobrar.resto + CDec(lv_resto)

        If DBModelo.Update_Cobrar(w_cobrar) = False Then
            MsgBox("No se pudo Actualizar registro en la tabla Cobrar", MsgBoxStyle.Critical, "Actualizar Tabla Cobrar")
            Error_Venta = False
            Exit Sub
        End If

        Dim w_histpagos As tblHistorialPagos = DBModelo.Get_HistorialPago(lv_IdPago)
        If DBModelo.DeleteHistorialPagos(w_histpagos) = False Then
            MsgBox("No se pudo Actualizar registro en la tabla Historial Pagos", MsgBoxStyle.Critical, "Actualizar Tabla Historial Pagos")
            Error_Venta = False
            Exit Sub
        End If

        MsgBox("El Abono Ha sido Cancelado!", MsgBoxStyle.Information, "Cancelar Abono")

        llenar_datagrid()
    End Sub

    Private Sub DataGridView1_CellDoubleClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        venta = CStr(DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value)
        resto = Format(DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value, "$ ###,###,##0.00")
        cliente = CStr(DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value)
        idcliente = CStr(DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value)
        fecha = Format(DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value, "yyyy-MM-dd")
        fechaL = Format(DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value, "yyyy-MM-dd")
        tipodoc = CStr(DataGridView1.Item(9, DataGridView1.CurrentRow.Index).Value)
        total = Format(DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value, "$ ###,###,##0.00")
        total_nota = Format(DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value, "$ ###,###,##0.00")
        abono_total = lblresto.Text
        cliente_abono = TxtCliente.Text
        'GC.Collect()
        FrmGenerarAbono.ShowDialog()
        llenar_datagrid()
    End Sub

    Private Sub DataGridView2_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        AbonoSeleccionado = True
    End Sub

    Private Sub DataGridView2_CellContentDoubleClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentDoubleClick
        AbonoSeleccionado = True
    End Sub

    Private Sub DataGridView2_CellContextMenuStripChanged_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContextMenuStripChanged
        AbonoSeleccionado = True
    End Sub

    Private Sub DataGridView2_CellDoubleClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        AbonoSeleccionado = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TxtCliente.Text = "<PRESIONA F2 PARA SELECCIONAR UN CLIENTE>"
        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()
        DataGridView1.Rows.Clear()
        DataGridView1.ResumeLayout()
        TxtDomicilio.Clear()
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Buscar_Clientes = "PAGOS"
        FrmBuscarClientesVentas.ShowDialog()
        FrmBuscarClientesVentas.Close()
        TxtCliente.Select()
        idTipoPrecioCliente = ""
        If idClienteVenta <> "0" Then
            llenar_datagrid()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case AbonoSeleccionado
            Case True
                CancelarAbono()
                AbonoSeleccionado = False
            Case False
                MsgBox("Favor de Seleccionar el Abono que desea Cancelar.", MsgBoxStyle.Information, "Cancelar Abono")
        End Select
    End Sub
End Class