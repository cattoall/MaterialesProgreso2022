Public Class FrmListadoFacturas

    Private Sub FrmListadoFacturas_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub FrmListadoVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bs.DataSource = Nothing
        bs2.DataSource = Nothing
        dt.Clear()
        dt2.Clear()
        With Me.DataGridConsulta
            ' alternar color de filas
            '.AlternatingRowsDefaultCellStyle.BackColor = My.Settings.BackColorAlt
            '.DefaultCellStyle.BackColor = My.Settings.BackColor
            '.DefaultCellStyle.Font = My.Settings.RowFont
            '.ColumnHeadersDefaultCellStyle.Font = My.Settings.HeaderFont
            ' Establecer el origen de datos para el DataGridview   
            .DataSource = bs
        End With

        With Me.DataGridTikect
            ' alternar color de filas
            '.AlternatingRowsDefaultCellStyle.BackColor = My.Settings.BackColorAlt
            '.DefaultCellStyle.BackColor = My.Settings.BackColor
            '.DefaultCellStyle.Font = My.Settings.RowFont
            '.ColumnHeadersDefaultCellStyle.Font = My.Settings.HeaderFont
            ' Establecer el origen de datos para el DataGridview   
            .DataSource = bs2
        End With

        dtFechaFinal.Value = Now
        dtFechaInicial.Value = Now
        LblNumTicket.Text = ""
        LblNumTicket.Visible = False
        LblTotal.Text = "$ 0.00"
    End Sub

    Private Sub ImgSalirB_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub DataGridConsulta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridConsulta.CellClick
        Try
            LblNumTicket.Visible = True
            LblTotal.Text = Format(Me.DataGridConsulta.Item(4, DataGridConsulta.CurrentRow.Index).Value, "$ ###,###,##0.00")
            LblNumTicket.Text = CStr(Me.DataGridConsulta.Item(1, DataGridConsulta.CurrentRow.Index).Value)
            NoFactura = CStr(Me.DataGridConsulta.Item(1, DataGridConsulta.CurrentRow.Index).Value)
            FechaFactura = Format(Me.DataGridConsulta.Item(9, DataGridConsulta.CurrentRow.Index).Value, "yyyyMMdd")
            Dim nFactura As String = CStr(Me.DataGridConsulta.Item(1, DataGridConsulta.CurrentRow.Index).Value)
            DataGridTikect.DataSource = DBModelo.GetFacturaByN(nFactura)

            DataGridTikect.Columns(0).Visible = False
            DataGridTikect.Columns(1).HeaderText = "ID"
            DataGridTikect.Columns(2).HeaderText = "No. Factura"
            DataGridTikect.Columns(3).HeaderText = "Folio"
            DataGridTikect.Columns(4).HeaderText = "Id Producto"
            DataGridTikect.Columns(5).HeaderText = "Clave Producto"
            DataGridTikect.Columns(6).HeaderText = "Descripción"
            DataGridTikect.Columns(7).HeaderText = "Cantidad"
            DataGridTikect.Columns(8).HeaderText = "Fecha"
            DataGridTikect.Columns(9).HeaderText = "Subtotal"
            DataGridTikect.Columns(10).HeaderText = "IVA"
            DataGridTikect.Columns(11).HeaderText = "Precio"
            DataGridTikect.Columns(12).HeaderText = "Clave Producto"
            DataGridTikect.Columns(13).HeaderText = "Clave Unidad"
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.InnerException.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub mBtnGenerate_Click(sender As Object, e As EventArgs) Handles mBtnSearch.Click
        Try
            Dim x As List(Of tblFacturaTotal) = DBModelo.GetIntervalFacturas(dtFechaInicial.Value.Date.ToString("yyyy-MM-dd"), dtFechaFinal.Value.Date.ToString("yyyy-MM-dd"))
            DataGridConsulta.DataSource = x
            load_layout_dgv_ListaFactura_H(Me.DataGridConsulta)
            For i = 0 To DataGridConsulta.RowCount - 1
                Select Case DataGridConsulta.Item(14, i).Value.ToString
                    Case "0"
                        DataGridConsulta.Item(15, i).Value = "CLIENTE"
                    Case "1"
                        DataGridConsulta.Item(15, i).Value = "MOSTRADOR"
                End Select
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.InnerException.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles mBtnPrint.Click
        If LblNumTicket.Text <> "" Then
            Dim NoFactura As Integer = CInt(DataGridConsulta.Item(1, DataGridConsulta.CurrentRow.Index).Value)
            Dim FechaFactura = DataGridConsulta.Item(9, DataGridConsulta.CurrentRow.Index).Value
            Dim FolioFactura As String = gv_SerieFacturaSalvador & "-" & NoFactura & "_" & Format(FechaFactura, "yyyyMMdd") & "_CFDI"

            If ImprimeFactura2(CStr(NoFactura), FolioFactura, True) = False Then
                MsgBox("Hubo un error al Generar la Impresión de la Factura", MsgBoxStyle.Critical, "Impresiones de Facturas")
            Else
                MsgBox("Re'Impresión de Factura Correctamente", MsgBoxStyle.Information, "Impresiones de Facturas")
            End If
        Else
            MsgBox("Favor de Seleccionar la Factura a Re-Imprimir.", MsgBoxStyle.Critical, "Impresiones de Facturas")
        End If
    End Sub
End Class
