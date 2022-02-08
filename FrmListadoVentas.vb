
Public Class FrmListadoVentas

    Private Sub ConfigurarGridDetalle(ByRef dv As DataGridView)
        dv.Columns(0).Visible = False
        dv.Columns(1).Visible = False
        dv.Columns(2).Visible = False

        dv.Columns(3).HeaderText = "IdProducto"
        dv.Columns(3).ReadOnly = True
        dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(4).HeaderText = "Descripcion"
        dv.Columns(4).ReadOnly = True
        dv.Columns(4).Width = 300
        dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dv.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(5).HeaderText = "Cantidad"
        dv.Columns(5).ReadOnly = True
        dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dv.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(6).HeaderText = "Precio Unitario"
        dv.Columns(6).ReadOnly = True
        dv.Columns(6).DefaultCellStyle.Format = "$ ###,###,##0.00"
        dv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dv.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(7).Visible = False

        dv.Columns(8).HeaderText = "Subtotal"
        dv.Columns(8).ReadOnly = True
        dv.Columns(8).DefaultCellStyle.Format = "$ ###,###,##0.00"
        dv.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dv.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(9).Visible = False
        dv.Columns(10).Visible = False
        dv.Columns(11).Visible = False

        dv.Columns(12).Visible = False

        dv.Columns(13).HeaderText = "ClaveProducto"
        dv.Columns(13).ReadOnly = True
        dv.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(13).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(14).HeaderText = "ClaveUnidad"
        dv.Columns(14).ReadOnly = True
        dv.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(14).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(15).Visible = False
    End Sub

    Private Sub FrmListadoVentas_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                Close()
                Dispose()
        End Select
    End Sub

    Private Sub FrmListadoVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridConsulta.Refresh()
        DataGridTikect.Refresh()

        dtFechaFinal.Value = Now
        dtFechaInicial.Value = Now
        LblNumTicket.Text = ""
        LblNumTicket.Visible = False
        LblTotal.Text = "$ 0.00"
    End Sub

    Private Sub CmdGenerarListado_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub ConfigurarGrid(ByRef dv As DataGridView)

        dv.Columns(0).Visible = False

        dv.Columns(1).HeaderText = "Venta"
        dv.Columns(1).ReadOnly = True
        dv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(1).DefaultCellStyle.Format = "#########"
        dv.Columns(1).Width = 100

        dv.Columns(2).HeaderText = "Fecha"
        dv.Columns(2).ReadOnly = True
        dv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(2).Width = 100

        dv.Columns(3).Visible = False
        dv.Columns(4).Visible = False

        dv.Columns(5).HeaderText = "Total"
        dv.Columns(5).ReadOnly = True
        dv.Columns(5).DefaultCellStyle.Format = "$ ###,###,##0.00"
        dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dv.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(6).HeaderText = "Tipo"
        dv.Columns(6).ReadOnly = True
        dv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(7).Visible = False

        dv.Columns(8).HeaderText = "Cliente"
        dv.Columns(8).ReadOnly = True
        dv.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dv.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(8).Width = 100

        dv.Columns(9).Visible = False

        dv.Columns(10).HeaderText = "Estado"
        dv.Columns(10).ReadOnly = True
        dv.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(10).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(11).HeaderText = "Motivo"
        dv.Columns(11).ReadOnly = True
        dv.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(11).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        dv.Columns(12).HeaderText = "No.Factura"
        dv.Columns(12).ReadOnly = True
        dv.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dv.Columns(12).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Private Sub CmdSalir_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub CmdCancelar_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub CmdImpresion_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub DataGridConsulta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridConsulta.CellClick
        LblNumTicket.Visible = True
        LblTotal.Text = Format(Me.DataGridConsulta.Item(5, DataGridConsulta.CurrentRow.Index).Value, "$ ###,###,###.00")
        LblNumTicket.Text = Me.DataGridConsulta.Item(1, DataGridConsulta.CurrentRow.Index).Value
        NoFactura = Me.DataGridConsulta.Item(1, DataGridConsulta.CurrentRow.Index).Value

        Dim tTickets As List(Of tblTicket) = DBModelo.Get_PV_TicketsDetalle(DataGridConsulta.Item(1, DataGridConsulta.CurrentRow.Index).Value)

        DataGridTikect.Refresh()
        DataGridTikect.DataSource = tTickets.ToList()

        ConfigurarGridDetalle(DataGridTikect)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        
        Dim tVentas As List(Of tblVenta) = DBModelo.Get_VentasByDate(Format(dtFechaInicial.Value.Date, "yyyy-MM-dd"), Format(dtFechaFinal.Value.Date, "yyyy-MM-dd"))

        DataGridConsulta.Refresh()
        DataGridConsulta.DataSource = tVentas.ToList()

        ConfigurarGrid(DataGridConsulta)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If LblNumTicket.Text <> "" Then
            If DataGridConsulta.Item(9, DataGridConsulta.CurrentRow.Index).Value = "VENDIDO" Then
                Cancelar = 2
                FrmCancelarPedido.ShowDialog()
                Cancelar = ""
                DataGridConsulta.Refresh()
                DataGridTikect.Refresh()
                Call CmdGenerarListado_Click(sender, e)
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Ticket " & LblNumTicket.Text & " ya está cancelado.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MsgBox("Seleccione Una Venta Para Cancelar", MsgBoxStyle.Critical, "Cancelar Venta")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If LblNumTicket.Text <> "" Then
            Dim lv_result As Boolean = False
            If MsgBox("¿Deseas Imprimir el Ticket?", MsgBoxStyle.YesNo, "Re-Impresiones de Tickets") = MsgBoxResult.Yes Then
                lv_result = True
            End If

            If ReImprimeVenta(LblNumTicket.Text, lv_result, "TICKET", DataGridConsulta.Item(2, DataGridConsulta.CurrentRow.Index).Value, "0.00") = False Then
                MsgBox("Error al Generar la Impresión del Ticket", MsgBoxStyle.Information, "Impresión de Ticket")
                Limpia_Variables_SQL_y_Cierra_Conexion()
                Exit Sub
            End If
        Else
            MsgBox("Favor de seleccionar una venta.", MsgBoxStyle.Critical, "Impresión de Ticket")
        End If
        Limpia_Variables_SQL_y_Cierra_Conexion()
    End Sub
End Class
