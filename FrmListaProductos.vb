
Public Class FrmListaProductos

    Private Sub FrmListaProductos_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyValue
            Case Keys.Escape
                Close()
                Dispose()
        End Select
    End Sub

    Private Sub FrmListaProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Refresh()
        Llena_grupos()
    End Sub

    Private Sub Llena_grupos()

        Dim wGrupos As List(Of tblGrupos) = DBModelo.GetGroupsAll
        LstGrupo.Refresh()

        LstGrupo.DataSource = wGrupos.ToList
        LstGrupo.ValueMember = "clave"
        LstGrupo.DisplayMember = "descripcion"
    End Sub

    Private Sub LstGrupo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstGrupo.Click

        Dim tProductos As List(Of tblProductos) = DBModelo.GetProductByGrupo(LstGrupo.Text)

        DataGridView1.DataSource = tProductos.ToList()

        ConfiguraGrid()
    End Sub

    Private Sub ConfiguraGrid()
        DataGridView1.Columns(0).Visible = False

        DataGridView1.Columns(1).HeaderText = "Cod.Barras"
        DataGridView1.Columns(1).ReadOnly = True
        DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(1).Width = 70

        DataGridView1.Columns(2).HeaderText = "Clave"
        DataGridView1.Columns(2).ReadOnly = True
        DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(2).Width = 70

        DataGridView1.Columns(3).HeaderText = "Descripción del Producto"
        DataGridView1.Columns(3).ReadOnly = True
        DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridView1.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(3).Width = 300

        DataGridView1.Columns(4).HeaderText = "UoM"
        DataGridView1.Columns(4).ReadOnly = True
        DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(4).Width = 80

        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(6).Visible = False
        DataGridView1.Columns(7).Visible = False
        DataGridView1.Columns(8).Visible = False
        DataGridView1.Columns(9).Visible = False
        DataGridView1.Columns(10).Visible = False
        DataGridView1.Columns(11).Visible = False
        DataGridView1.Columns(12).Visible = False
        DataGridView1.Columns(13).Visible = False
        DataGridView1.Columns(14).Visible = False

        DataGridView1.Columns(15).HeaderText = "Público"
        DataGridView1.Columns(15).ReadOnly = True
        DataGridView1.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(15).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(15).Width = 100

        DataGridView1.Columns(16).Visible = False
        DataGridView1.Columns(17).Visible = False
        DataGridView1.Columns(18).Visible = False

        DataGridView1.Columns(19).HeaderText = "Stock"
        DataGridView1.Columns(19).ReadOnly = True
        DataGridView1.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(19).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(19).DefaultCellStyle.Format = "########0.00"
        DataGridView1.Columns(19).Width = 100

        DataGridView1.Columns(20).Visible = False
        DataGridView1.Columns(21).Visible = False

        DataGridView1.Columns(22).Visible = False
        DataGridView1.Columns(23).Visible = False
        DataGridView1.Columns(24).Visible = False
        DataGridView1.Columns(25).Visible = False
        DataGridView1.Columns(26).Visible = False

    End Sub

    Private Sub CmdVerTodosLosProductos_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub CmdSalir_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles CmdVerTodosLosProductos.Click
        Dim tProductos As List(Of tblProductos) = DBModelo.GetProductsAll

        DataGridView1.DataSource = tProductos.ToList()

        ConfiguraGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        Dispose()
    End Sub
End Class