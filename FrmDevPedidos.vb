Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class FrmDevPedidos
    Private Sub TxtPedido_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TxtPedido.KeyDown
        Dim Lv_pedido As String = TxtPedido.Text
        Dim lv_subtotal_c As Double = 0
        Dim lv_iva_c As Double = 0
        Dim lv_total_c As Double = 0

        If e.KeyCode = Keys.Enter Then
            If Lv_pedido = "" Then
                MsgBox("Favor De Proporcionar El Número De Pedido", MsgBoxStyle.Information, "Devolución de Pedidos")
                Limpiar_objetos()
                TxtTotal_N.Text = Format(lv_total_c, "$ ###,###,##0.00")
                Exit Sub
            ElseIf Lv_pedido = " " Then
                Exit Sub
            End If

            Limpia_Variables_SQL_y_Cierra_Conexion()
            SQL = "SELECT * FROM venta_pedido where nticket = " & CDbl(Lv_pedido)
            conn.Open()
            If conn.State = ConnectionState.Open Then
                myCommand = New SqlCommand(SQL, conn)
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDs)
                If myDs.Tables(0).Rows.Count > 0 Then
                    TxtPedido_C.Text = myDs.Tables(0).Rows(0)!nticket
                    DTPFecha.Value = myDs.Tables(0).Rows(0)!fecha
                    txtTotal_C.Text = myDs.Tables(0).Rows(0)!total
                    TxtTipo_C.Text = myDs.Tables(0).Rows(0)!tipo
                    TxtStatus_C.Text = myDs.Tables(0).Rows(0)!estado
                    TxtNombre_C.Text = myDs.Tables(0).Rows(0)!cliente
                    Label9.Visible = True
                    Label9.Text = myDs.Tables(0).Rows(0)!idcliente
                    Limpia_Variables_SQL_y_Cierra_Conexion()
                    'MsgBox(DTPFecha.Value & "=" & Now.Date)
                    SQL = "SELECT * FROM ticket_pedido where folio = " & CDbl(Lv_pedido)
                    conn.Open()
                    If conn.State = ConnectionState.Open Then
                        myCommand = New SqlCommand(SQL, conn)
                        myAdapter.SelectCommand = myCommand
                        myAdapter.Fill(myDs)
                        DGVDetalle.Rows.Clear()
                        For i = 0 To myDs.Tables(0).Rows.Count - 1
                            Dim row As String() = New String() {myDs.Tables(0).Rows(i)!folio,
                                                                myDs.Tables(0).Rows(i)!idproducto,
                                                                Format(myDs.Tables(0).Rows(i)!cantidad, "###0.00"),
                                                                myDs.Tables(0).Rows(i)!concepto,
                                                                Format(myDs.Tables(0).Rows(i)!precio, "$ ###,###,##0.00"),
                                                                Format(myDs.Tables(0).Rows(i)!subtotal, "$ ###,###,##0.00"),
                                                                Format(myDs.Tables(0).Rows(i)!cantidad, "###0.00")}
                            DGVDetalle.Rows.Add(row)
                            lv_subtotal_c = lv_subtotal_c + myDs.Tables(0).Rows(i)!subtotal
                        Next i
                        lv_iva_c = lv_subtotal_c * (FactorIVA - 1)
                        lv_total_c = lv_subtotal_c + lv_iva_c
                        txtSubTotal_N.Text = Format(lv_subtotal_c, "$ ###,###,##0.00")
                        txtIVA_N.Text = Format(lv_iva_c, "$ ###,###,##0.00")
                        TxtTotal_N.Text = Format(lv_total_c, "$ ###,###,##0.00")
                        ImgGenerarA.Enabled = True
                    End If
                Else
                    MsgBox("Pedido N°:" & Trim(Lv_pedido) & ", No existe ", MsgBoxStyle.Information, "Devolución de Pedidos")
                    Limpia_Variables_SQL_y_Cierra_Conexion()
                    Limpiar_objetos()
                    TxtTotal_N.Text = Format(lv_total_c, "$ ###,###,##0.00")
                    Label9.Visible = False
                End If
            End If
        End If
    End Sub
    Private Sub TxtPedido_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPedido.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub DGVDetalle_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVDetalle.CellValueChanged
        If e.ColumnIndex = 2 And e.RowIndex <> -1 Then
            Dim lv_cantidad As Double = DGVDetalle.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            If lv_cantidad <= CDbl(DGVDetalle.Rows(e.RowIndex).Cells(6).Value) Then

                DGVDetalle.Rows(e.RowIndex).Cells(4).Value = Trim(Replace(DGVDetalle.Rows(e.RowIndex).Cells(4).Value, "$", ""))
                Dim lv_pu As Double = DGVDetalle.Rows(e.RowIndex).Cells(4).Value
                DGVDetalle.Rows(e.RowIndex).Cells(4).Value = Format(lv_pu, "$ ###,###,##0.00")

                DGVDetalle.Rows(e.RowIndex).Cells(5).Value = Format(lv_cantidad * lv_pu, "$ ###,###,##0.00")

                Dim lv_subtotal_c As Double = 0
                Dim lv_iva_c As Double = 0
                Dim lv_total_c As Double = 0
                For i = 0 To DGVDetalle.Rows.Count - 1
                    lv_subtotal_c = lv_subtotal_c + Trim(Replace(Trim(Replace(DGVDetalle.Rows(i).Cells(5).Value, "$", "")), ",", ""))
                Next i
                lv_iva_c = lv_subtotal_c * (FactorIVA - 1)
                lv_total_c = lv_subtotal_c + lv_iva_c
                txtSubTotal_N.Text = Format(lv_subtotal_c, "$ ###,###,##0.00")
                txtIVA_N.Text = Format(lv_iva_c, "$ ###,###,##0.00")
                TxtTotal_N.Text = Format(lv_total_c, "$ ###,###,##0.00")
                DGVDetalle.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Format(lv_cantidad, "###0.00")
            Else
                MsgBox("Cantidad mayor a la Cantidad Original", MsgBoxStyle.Critical, "Favor de verificar")
                DGVDetalle.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = DGVDetalle.Rows(e.RowIndex).Cells(6).Value
            End If
        End If
    End Sub

    Private Sub DGVDetalle_RowsRemoved(sender As Object, e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DGVDetalle.RowsRemoved
        Dim lv_subtotal_c As Double = 0
        Dim lv_iva_c As Double = 0
        Dim lv_total_c As Double = 0
        For i = 0 To DGVDetalle.Rows.Count - 1
            lv_subtotal_c = lv_subtotal_c + Trim(Replace(Trim(Replace(DGVDetalle.Rows(i).Cells(5).Value, "$", "")), ",", ""))
        Next i
        lv_iva_c = lv_subtotal_c * (FactorIVA - 1)
        lv_total_c = lv_subtotal_c + lv_iva_c
        txtSubTotal_N.Text = Format(lv_subtotal_c, "$ ###,###,##0.00")
        txtIVA_N.Text = Format(lv_iva_c, "$ ###,###,##0.00")
        TxtTotal_N.Text = Format(lv_total_c, "$ ###,###,##0.00")

    End Sub

    Private Sub Limpiar_objetos()
        TxtPedido.Clear()
        TxtPedido_C.Clear()
        TxtNombre_C.Clear()
        TxtStatus_C.Clear()
        TxtTipo_C.Clear()
        txtSubTotal_C.Clear()
        txtIVA_C.Clear()
        txtTotal_C.Clear()
        txtSubTotal_N.Clear()
        txtIVA_N.Clear()
        TxtTotal_N.Clear()
        DTPFecha.Value = Now.Date
        Label9.Visible = False
        ImgGenerarA.Enabled = False
        DGVDetalle.Refresh()
        DGVDetalle.Rows.Clear()
        DGVDetalle.ResumeLayout()
        TxtPedido.Focus()

    End Sub

    Private Sub FrmDevPedidos_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub FrmDevPedidos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Me.BackColor = My.Settings.FormsBackColor
        'Me.GroupBox1.ForeColor = My.Settings.FontForeColor
        'Me.GroupBox1.Font = My.Settings.FontStyle
        'Me.GroupBox2.ForeColor = My.Settings.FontForeColor
        'Me.GroupBox2.Font = My.Settings.FontStyle

        'BtnGenDev.BackColor = My.Settings.FormsBackColor
        'BtnGenDev.Font = My.Settings.FontStyle
        'BtnGenDev.ForeColor = My.Settings.FontForeColor

        Limpiar_objetos()
        Limpia_Variables_SQL_y_Cierra_Conexion()
    End Sub

    Private Sub ImgSalirB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgSalirB.MouseLeave
        Me.ImgSalirA.Visible = True
        Me.ImgSalirB.Visible = False
    End Sub

    Private Sub ImgSalirA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgSalirA.MouseHover
        Me.ImgSalirB.Visible = True
        Me.ImgSalirA.Visible = False
    End Sub

    Private Sub ImgGenerarB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgGenerarB.MouseLeave
        Me.ImgGenerarA.Visible = True
        Me.ImgGenerarB.Visible = False
    End Sub

    Private Sub ImgGenerarA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgGenerarA.MouseHover
        Me.ImgGenerarB.Visible = True
        Me.ImgGenerarA.Visible = False
    End Sub

    Private Sub ImgSalirB_Click(sender As System.Object, e As System.EventArgs) Handles ImgSalirB.Click
        Me.Close()
    End Sub

    Private Sub ImgGenerarB_Click(sender As System.Object, e As System.EventArgs) Handles ImgGenerarB.Click
        ''''''Actualizar Stock en Productos
        For i = 0 To myDs.Tables(0).Rows.Count - 1
            Sql1.Clear()
            Sql1.Append("UPDATE Productos  SET Stock = Stock + ")
            Sql1.AppendFormat("'{0}' ", myDs.Tables(0).Rows(i)!cantidad)
            Sql1.Append("where idProducto = ")
            Sql1.AppendFormat("'{0}' ", myDs.Tables(0).Rows(i)!idproducto)
            If Insertar_Registro(Sql1.ToString, DBConnected) = False Then
                MsgBox("No se pudo Actualizar Inventario en la tabla PRODUCTOS", MsgBoxStyle.Critical)
                Error_Venta = False
                Exit Sub
            End If
        Next i

        For i = 0 To DGVDetalle.Rows.Count - 1
            Sql1.Clear()
            Sql1.Append("UPDATE ticket_pedido  SET Cantidad = ")
            Sql1.AppendFormat("'{0}', ", DGVDetalle.Rows(i).Cells(2).Value)
            Sql1.Append("subtotal = ")
            Sql1.AppendFormat("'{0}', ", Trim(Replace(Trim(Replace(DGVDetalle.Rows(i).Cells(5).Value, "$", "")), ",", "")))
            Sql1.Append("numerofactura = ")
            Sql1.AppendFormat("'{0}' ", "XXXXX")
            Sql1.Append("where folio = ")
            Sql1.AppendFormat("'{0}' ", DGVDetalle.Rows(i).Cells(0).Value)
            Sql1.Append("and idProducto = ")
            Sql1.AppendFormat("'{0}' ", DGVDetalle.Rows(i).Cells(1).Value)
            If Insertar_Registro(Sql1.ToString, DBConnected) = False Then
                MsgBox("No se pudo Actualizar registros en la tabla TICKET_PEDIDO", MsgBoxStyle.Critical)
                Error_Venta = False
                Exit Sub
            End If
            Sql1.Clear()
            Sql1.Append("UPDATE Productos  SET Stock = Stock - ")
            Sql1.AppendFormat("'{0}' ", DGVDetalle.Rows(i).Cells(2).Value)
            Sql1.Append("where idProducto = ")
            Sql1.AppendFormat("'{0}' ", DGVDetalle.Rows(i).Cells(1).Value)
            If Insertar_Registro(Sql1.ToString, DBConnected) = False Then
                MsgBox("No se pudo Actualizar Inventario en la tabla PRODUCTOS", MsgBoxStyle.Critical)
                Error_Venta = False
                Exit Sub
            End If
        Next i

        Sql1.Clear()
        Sql1.Append("DELETE FROM ticket_pedido ")
        Sql1.Append("where folio = ")
        Sql1.AppendFormat("'{0}' ", TxtPedido_C.Text)
        Sql1.Append("and (numerofactura <> ")
        Sql1.AppendFormat("'{0}' ", "XXXXX")
        Sql1.Append("or numerofactura IS NULL)")
        If Insertar_Registro(Sql1.ToString, DBConnected) = False Then
            MsgBox("No se pudo Eliminar registros en la tabla TICKET_PEDIDO", MsgBoxStyle.Critical)
            Error_Venta = False
            Exit Sub
        End If

        Sql1.Clear()
        Sql1.Append("UPDATE ticket_pedido SET numerofactura = NULL ")
        Sql1.Append("where folio = ")
        Sql1.AppendFormat("'{0}' ", TxtPedido.Text)
        Sql1.Append("and numerofactura = ")
        Sql1.AppendFormat("'{0}' ", "XXXXX")
        If Insertar_Registro(Sql1.ToString, DBConnected) = False Then
            MsgBox("No se pudo Actualizar registros en la tabla TICKET_PEDIDO", MsgBoxStyle.Critical)
            Error_Venta = False
            Exit Sub
        End If

        Sql1.Clear()
        Sql1.Append("UPDATE venta_pedido SET subtotal = ")
        Sql1.AppendFormat("'{0}' ", Trim(Replace(Trim(Replace(txtSubTotal_N.Text, "$", "")), ",", "")))
        Sql1.Append(", iva = ")
        Sql1.AppendFormat("'{0}' ", Trim(Replace(Trim(Replace(txtIVA_N.Text, "$", "")), ",", "")))
        Sql1.Append(", total = ")
        Sql1.AppendFormat("'{0}' ", Trim(Replace(Trim(Replace(TxtTotal_N.Text, "$", "")), ",", "")))
        Sql1.Append("where nticket = ")
        Sql1.AppendFormat("'{0}' ", TxtPedido_C.Text)
        If Insertar_Registro(Sql1.ToString, DBConnected) = False Then
            MsgBox("No se pudo Actualizar registros en la tabla VENTA_PEDIDO", MsgBoxStyle.Critical)
            Error_Venta = False
            Exit Sub
        End If

        If TxtTipo_C.Text = "CREDITO" Then
            Limpia_Variables_SQL_y_Cierra_Conexion()
            SQL = "SELECT * FROM cobrar where n_remision = " & CDbl(TxtPedido_C.Text) & " and clavecliente = " & CInt(Label9.Text)
            conn.Open()
            If conn.State = ConnectionState.Open Then
                myCommand = New SqlCommand(SQL, conn)
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDs)
                If myDs.Tables(0).Rows.Count > 0 Then
                    If myDs.Tables(0).Rows(0)!resto = "0.00" Then
                        Dim lv_resto As Double = CDbl(Trim(Replace(Trim(Replace(TxtTotal_N.Text, "$", "")), ",", ""))) - CDbl(txtTotal_C.Text)
                        Dim theDate As Date = Now.Date
                        Dim lv_fecha As String = theDate.ToString("yyyy-MM-dd")

                        Sql1.Clear()
                        Sql1.Append("INSERT INTO historial_pagos (fecha,numeroVenta,total,claveCliente,cliente,observaciones) values ( ")
                        Sql1.AppendFormat("'{0}', ", lv_fecha)
                        Sql1.AppendFormat("'{0}', ", TxtPedido_C.Text)
                        Sql1.AppendFormat("'{0}', ", lv_resto)
                        Sql1.AppendFormat("'{0}' ,", Label9.Text)
                        Sql1.AppendFormat("'{0}' ,", TxtNombre_C.Text)
                        Sql1.AppendFormat("'{0}' ", "Ajuste por Devolución")
                        Sql1.Append(" )")

                        If Insertar_Registro(Sql1.ToString, DBConnected) = False Then
                            MsgBox("Error al Insertar Registro en la Tabla HISTORIAL_PAGOS", MsgBoxStyle.Information, "Generar Abono a Cuenta")
                            Limpia_Variables_SQL_y_Cierra_Conexion()
                            Exit Sub
                        End If

                        Sql1.Clear()
                        Sql1.Append("UPDATE cobrar SET total = ")
                        Sql1.AppendFormat("'{0}' ", Trim(Replace(Trim(Replace(TxtTotal_N.Text, "$", "")), ",", "")))
                        Sql1.Append("where n_remision = ")
                        Sql1.AppendFormat("'{0}' ", TxtPedido_C.Text)
                        Sql1.Append("and clavecliente = ")
                        Sql1.AppendFormat("'{0}' ", Label9.Text)
                        Sql1.Append("and tipoDocumento = ")
                        Sql1.AppendFormat("'{0}' ", "PEDIDO")
                        If Insertar_Registro(Sql1.ToString, DBConnected) = False Then
                            MsgBox("No se pudo Actualizar registros en la tabla COBRAR", MsgBoxStyle.Critical)
                            Error_Venta = False
                            Exit Sub
                        End If
                    Else
                        Dim lv_total As Double = CDbl(txtTotal_C.Text)
                        Dim lv_resto As Double = CDbl(myDs.Tables(0).Rows(0)!resto)
                        Dim lv_abonado As Double = lv_total - lv_resto
                        If (CDbl(TxtTotal_N.Text) - lv_abonado) < 0 Then
                            Dim theDate As Date = Now.Date
                            Dim lv_fecha As String = theDate.ToString("yyyy-MM-dd")

                            Sql1.Clear()
                            Sql1.Append("INSERT INTO historial_pagos (fecha,numeroVenta,total,claveCliente,cliente,observaciones) values ( ")
                            Sql1.AppendFormat("'{0}', ", lv_fecha)
                            Sql1.AppendFormat("'{0}', ", TxtPedido_C.Text)
                            Sql1.AppendFormat("'{0}', ", (CDbl(TxtTotal_N.Text) - lv_abonado))
                            Sql1.AppendFormat("'{0}' ,", Label9.Text)
                            Sql1.AppendFormat("'{0}' ,", TxtNombre_C.Text)
                            Sql1.AppendFormat("'{0}' ", "Ajuste por Devolución")
                            Sql1.Append(" )")

                            If Insertar_Registro(Sql1.ToString, DBConnected) = False Then
                                MsgBox("Error al Insertar Registro en la Tabla HISTORIAL_PAGOS", MsgBoxStyle.Information, "Generar Abono a Cuenta")
                                Limpia_Variables_SQL_y_Cierra_Conexion()
                                Exit Sub
                            End If

                            Sql1.Clear()
                            Sql1.Append("UPDATE cobrar SET total = ")
                            Sql1.AppendFormat("'{0}', ", Trim(Replace(Trim(Replace(TxtTotal_N.Text, "$", "")), ",", "")))
                            Sql1.Append("resto = ")
                            Sql1.AppendFormat("'{0}' ", "0")
                            Sql1.Append("where n_remision = ")
                            Sql1.AppendFormat("'{0}' ", TxtPedido_C.Text)
                            Sql1.Append("and clavecliente = ")
                            Sql1.AppendFormat("'{0}' ", Label9.Text)
                            Sql1.Append("and tipoDocumento = ")
                            Sql1.AppendFormat("'{0}' ", "PEDIDO")
                            If Insertar_Registro(Sql1.ToString, DBConnected) = False Then
                                MsgBox("No se pudo Actualizar registros en la tabla COBRAR", MsgBoxStyle.Critical)
                                Error_Venta = False
                                Exit Sub
                            End If
                        Else
                            Sql1.Clear()
                            Sql1.Append("UPDATE cobrar SET total = ")
                            Sql1.AppendFormat("'{0}', ", Trim(Replace(Trim(Replace(TxtTotal_N.Text, "$", "")), ",", "")))
                            Sql1.Append("resto = ")
                            Sql1.AppendFormat("'{0}' ", (CDbl(TxtTotal_N.Text) - lv_abonado))
                            Sql1.Append("where n_remision = ")
                            Sql1.AppendFormat("'{0}' ", TxtPedido_C.Text)
                            Sql1.Append("and clavecliente = ")
                            Sql1.AppendFormat("'{0}' ", Label9.Text)
                            Sql1.Append("and tipoDocumento = ")
                            Sql1.AppendFormat("'{0}' ", "PEDIDO")
                            If Insertar_Registro(Sql1.ToString, DBConnected) = False Then
                                MsgBox("No se pudo Actualizar registros en la tabla COBRAR", MsgBoxStyle.Critical)
                                Error_Venta = False
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            End If
        End If
        Dim lv_result As Boolean = False
        If MsgBox("¿Deseas Imprimir el Pedido?", MsgBoxStyle.YesNo, "Re-Impresiones de Pedidos") = MsgBoxResult.Yes Then
            lv_result = True
        End If

        If ReImprimeVenta(TxtPedido_C.Text, lv_result, "PEDIDO", Trim(Replace(Trim(Replace(TxtTotal_N.Text, "$", "")), ",", "")), "0.00", DBConnected) = False Then
            MsgBox("Error al Generar la Impresión del Pedido", MsgBoxStyle.Information)
            Limpia_Variables_SQL_y_Cierra_Conexion()
            Exit Sub
        End If

        MsgBox("Devolución Terminada Correctamente", MsgBoxStyle.Information, "Devolución Terminada")
        Limpiar_objetos()
        Limpia_Variables_SQL_y_Cierra_Conexion()
    End Sub
End Class