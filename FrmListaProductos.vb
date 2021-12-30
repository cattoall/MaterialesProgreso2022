Imports System.Data.SqlClient

Public Class FrmListaProductos

    Private Sub FrmListaProductos_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
    Private Sub FrmListaProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bs.DataSource = Nothing
        bs2.DataSource = Nothing
        dt.Clear()
        dt2.Clear()
        Llena_grupos()
        With Me.DataGridView1
            ' alternar color de filas
            '.AlternatingRowsDefaultCellStyle.BackColor = My.Settings.BackColorAlt
            '.DefaultCellStyle.BackColor = My.Settings.BackColor
            '.DefaultCellStyle.Font = My.Settings.RowFont
            '.ColumnHeadersDefaultCellStyle.Font = My.Settings.HeaderFont
            ' Establecer el origen de datos para el DataGridview   
            .DataSource = bs
        End With
        'Me.BackColor = My.Settings.FormsBackColor

        'Me.GroupBox1.ForeColor = My.Settings.FontForeColor
        'Me.GroupBox1.Font = My.Settings.FontStyle
        'Me.CmdVertodo.BackColor = My.Settings.FormsBackColor
    End Sub

    Private Sub Llena_grupos()
        Dim dt_tmp As DataTable
        Try
            SQL = "SELECT clave, descripcion FROM grupos order by descripcion asc "
            conn.Open()
            If conn.State = ConnectionState.Open Then
                myCommand = New SqlCommand(SQL, conn)
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myDs)
                dt_tmp = New DataTable
                dt_tmp.Clear()
                myAdapter.Fill(dt_tmp)
                LstGrupo.DataSource = dt_tmp
                LstGrupo.ValueMember = "clave"
                LstGrupo.DisplayMember = "descripcion"
                Limpia_Variables_SQL_y_Cierra_Conexion()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Limpia_Variables_SQL_y_Cierra_Conexion()
        End Try
    End Sub

    Private Sub LstGrupo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstGrupo.Click
        SQL = "SELECT codigoBarras, clave, descripcionProducto, unidadMedida, precioPublico, precioP1, precioP2, precioP3, stock, Inventario FROM productos where grupo  = '" & LstGrupo.Text & "'"

        'Carga Lista de Clasificaciones
        load_record_dgv(SQL, Me.DataGridView1, DBConnected)

        'Aplica formato al DataGridView
        load_layout_dgv_Listaproductos(Me.DataGridView1)
    End Sub

    Private Sub ImgSalirB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgSalirB.MouseLeave
        Me.ImgSalirA.Visible = True
        Me.ImgSalirB.Visible = False
    End Sub

    Private Sub ImgSalirA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgSalirA.MouseHover
        Me.ImgSalirB.Visible = True
        Me.ImgSalirA.Visible = False
    End Sub

    Private Sub ImgVerProductosB_MouseLeave(sender As Object, e As System.EventArgs) Handles ImgVerProductosB.MouseLeave
        Me.ImgVerProductosA.Visible = True
        Me.ImgVerProductosB.Visible = False
    End Sub

    Private Sub ImgVerProductosA_MouseHover(sender As Object, e As System.EventArgs) Handles ImgVerProductosA.MouseHover
        Me.ImgVerProductosB.Visible = True
        Me.ImgVerProductosA.Visible = False
    End Sub

    Private Sub ImgSalirB_Click(sender As System.Object, e As System.EventArgs) Handles ImgSalirB.Click
        Me.Close()
    End Sub

    Private Sub ImgVerProductosB_Click(sender As System.Object, e As System.EventArgs) Handles ImgVerProductosB.Click
        SQL = "select * from productos"
        'Carga Lista de Clasificaciones
        load_record_dgv(SQL, Me.DataGridView1, DBConnected)

        'Aplica formato al DataGridView
        load_layout_dgv_Listaproductos_todos(Me.DataGridView1)
    End Sub
End Class