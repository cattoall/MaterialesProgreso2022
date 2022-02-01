Public Class FrmListadoNC

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

        'Me.BackColor = My.Settings.FormsBackColor
        'Me.GroupBox1.ForeColor = My.Settings.FontForeColor
        'Me.GroupBox1.Font = My.Settings.FontStyle
        'Me.CmdImprimir.BackColor = My.Settings.FormsBackColor
        'Me.CmdSalir.BackColor = My.Settings.FormsBackColor
        'Me.CmdVentas.BackColor = My.Settings.FormsBackColor
        'Me.CmdCancelar.BackColor = My.Settings.FormsBackColor
        'Me.CmdFacturaCFDI.BackColor = My.Settings.FormsBackColor
        'Me.LblNumTicket.BackColor = My.Settings.FormsBackColor
        'Me.LblTotal.BackColor = My.Settings.FormsBackColor
        dtFechaFinal.Value = Now
        dtFechaInicial.Value = Now
        LblNumTicket.Text = ""
        LblNumTicket.Visible = False
        LblTotal.Text = "$ 0.00"
        If gv_terminal = "01" Then
            mBtnXML.Visible = True
        Else
            mBtnXML.Visible = False
        End If
    End Sub

    Private Sub ImgSalirB_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ImgCancelarB_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ImgGenXmlB_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ImgCFDIB_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub DataGridConsulta_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridConsulta_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridConsulta.CellClick
        LblNumTicket.Visible = True
        LblTotal.Text = Format(Me.DataGridConsulta.Item(1, DataGridConsulta.CurrentRow.Index).Value, "$ ###,###,##0.00")
        LblNumTicket.Text = Me.DataGridConsulta.Item(0, DataGridConsulta.CurrentRow.Index).Value
        NoFactura = Me.DataGridConsulta.Item(0, DataGridConsulta.CurrentRow.Index).Value

        DataGridTikect.DataSource = DBModelo.GetNCDetalle(Me.DataGridConsulta.Item(0, DataGridConsulta.CurrentRow.Index).Value)

        'Aplica formato al DataGridView
        load_layout_dgv_ListaNC_i(Me.DataGridTikect)
    End Sub

    Private Sub mBtnSearch_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub mBtnExit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub mBtnCancel_Click(sender As Object, e As EventArgs) Handles mBtnCancel.Click
        If LblNumTicket.Text <> "" Then
            Cancelar = 4
            FrmCancelarPedido.ShowDialog()
            Cancelar = ""
        Else
            MsgBox("Seleccione Una Nota de Crédito Para Cancelar", MsgBoxStyle.Critical, "Cancelar Nota de Crédito")
        End If
    End Sub

    Private Sub mBtnPrint_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub mBtnXML_Click(sender As Object, e As EventArgs) Handles mBtnXML.Click
        If LblNumTicket.Text <> "" Then
            If MsgBox("¿Está seguro de generar el XML de Cancelación?", MsgBoxStyle.YesNo, "Generar XML Cancelación") = MsgBoxResult.Yes Then
                'CancelaNC_CFDI(CInt(LblNumTicket.Text), DBConnected)
                MsgBox("XML generado.", MsgBoxStyle.Information, "Generar XML Cancelación")
                'Call ImgVerFactB_Click(sender, e)
            End If
        Else
            MsgBox("Favor de Seleccionar la Nota de Crédito a Generar el XML Cancelación.", MsgBoxStyle.Critical, "Generar XML Cancelación")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If LblNumTicket.Text <> "" Then
            Dim NoFactura = DataGridConsulta.Item(0, DataGridConsulta.CurrentRow.Index).Value
            Dim FechaFactura = DataGridConsulta.Item(8, DataGridConsulta.CurrentRow.Index).Value
            Dim FolioFactura As String = gv_SerieNCSalvador & "-" & NoFactura & "_" & Format(FechaFactura, "yyyyMMdd") & "_CFDI"
            If ImprimeNotaDeCredito(NoFactura, FolioFactura, True) = False Then
                MsgBox("Hubo un error al Generar la Impresión de la Nota de Crédito", MsgBoxStyle.Critical, "Impresiones de Notas de Crédito")
            Else
                MsgBox("Re'Impresión de Nota de Credito Correctamente", MsgBoxStyle.Information, "Impresiones de Notas de Crédito")
            End If
        Else
            MsgBox("Favor de Seleccionar la Nota de Crédito a Re-Imprimir.", MsgBoxStyle.Critical, "Impresiones de Notas de Crédito")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridConsulta.DataSource = DBModelo.GetNCIntervalFacturas(Format(dtFechaInicial.Value.Date, "yyyy-MM-dd"), Format(dtFechaFinal.Value.Date, "yyyy-MM-dd"))

        'load_layout_dgv_ListaNC_H(Me.DataGridConsulta)

        For i = 0 To DataGridConsulta.RowCount - 1
            Select Case DataGridConsulta.Item(11, i).Value
                Case "0"
                    DataGridConsulta.Item(12, i).Value = "CLIENTE"
                Case "1"
                    DataGridConsulta.Item(12, i).Value = "MOSTRADOR"
            End Select
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
