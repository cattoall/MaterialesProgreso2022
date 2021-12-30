Public Class MDIMain

    Private lv_strVariables As String

    Private Sub MDIMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TssDate.Text = Now.ToLongDateString
        TssTime.Text = Now.ToShortTimeString

        ReadConfigXML()

        Try
            If gv_terminal <> "01" Then
                ConfiguracionDelSistemaToolStripMenuItem.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If gv_smtp_correo = "" Then
            MsgBox("Falta crear la Variable SMTP_CORREO", MsgBoxStyle.Critical, "SMTP_CORREO")
            End
        End If

        If gv_smtp_pass = "" Then
            MsgBox("Falta crear la Variable SMTP_PASS", MsgBoxStyle.Critical, "SMTP_PASS")
            End
        End If

        If gv_cfdi_usuario = "" Then
            MsgBox("Falta crear la Variable CFDI_USUARIO", MsgBoxStyle.Critical, "CFDI_USUARIO")
            End
        End If

        If gv_cfdi_password = "" Then
            MsgBox("Falta crear la Variable CFDI_PASSWORD", MsgBoxStyle.Critical, "CFDI_PASSWORD")
            End
        End If

        If gv_cfdi_prd = "" Then
            MsgBox("Falta crear la Variable CFDI_PRD", MsgBoxStyle.Critical, "CFDI_PRD")
            End
        End If

        If gv_sat_cer = "" Then
            MsgBox("Falta crear la Variable SAT_CER", MsgBoxStyle.Critical, "SAT_CER")
            End
        End If

        If gv_sat_key = "" Then
            MsgBox("Falta crear la Variable SAT_KEY", MsgBoxStyle.Critical, "SAT_KEY")
            End
        End If

        If gv_sat_pass = "" Then
            MsgBox("Falta crear la Variable SAT_PASS", MsgBoxStyle.Critical, "SAT_PASS")
            End
        End If

        If gv_ConStringWendy = "" Then
            MsgBox("Falta crear la Variabl ConStringWendy", MsgBoxStyle.Critical, "ConStringWendy")
            End
        End If

        If gv_ConStringLibrada = "" Then
            MsgBox("Falta crear la Variabl ConStringLibrada", MsgBoxStyle.Critical, "ConStringLibrada")
            End
        End If

        If gv_ConStringSalvador = "" Then
            MsgBox("Falta crear la Variable ConStringSalvador", MsgBoxStyle.Critical, "ConStringSalvador")
            End
        End If

        If gv_Report_Path = "" Then
            MsgBox("Falta crear la Variable Report_Path", MsgBoxStyle.Critical, "Report_Path")
            End
        End If

        If gv_MySQLData = "" Then
            MsgBox("Falta crear la Variable MySQLData", MsgBoxStyle.Critical, "MySQLData")
            End
        End If

        If gv_MySQLBackUpPath = "" Then
            MsgBox("Falta crear la Variable MySQLBackUpPath", MsgBoxStyle.Critical, "MySQLBackUpPath")
            End
        End If

        If gv_MySQLDataWendy = "" Then
            MsgBox("Falta crear la Variable MySQLDataWendy", MsgBoxStyle.Critical, "MySQLDataWendy")
            End
        End If

        If gv_CDFI_XML_PATH = "" Then
            MsgBox("Falta crear la Variable CDFI_XML_PATH", MsgBoxStyle.Critical, "CDFI_XML_PATH")
            End
        End If

        If gv_RutaProceso = "" Then
            MsgBox("Falta crear la Variable RutaProceso", MsgBoxStyle.Critical, "RutaProceso")
            End
        End If

        If gv_MySQLDataLibrada = "" Then
            MsgBox("Falta crear la Variable MySQLDataLibrada", MsgBoxStyle.Critical, "MySQLDataLibrada")
            End
        End If

        If gv_SerieFacturaLibrada = "" Then
            MsgBox("Falta crear la Variable SerieFacturaLibrada", MsgBoxStyle.Critical, "SerieFacturaLibrada")
            End
        End If

        If gv_SerieNCLibrada = "" Then
            MsgBox("Falta crear la Variable SerieNCLibrada", MsgBoxStyle.Critical, "SerieNCLibrada")
            End
        End If

        If gv_SerieFacturaSalvador = "" Then
            MsgBox("Falta crear la Variable SerieFacturaSalvador", MsgBoxStyle.Critical, "SerieFacturaSalvador")
            End
        End If

        If gv_SerieNCSalvador = "" Then
            MsgBox("Falta crear la Variable SerieNCSalvador", MsgBoxStyle.Critical, "SerieNCSalvador")
            End
        End If

        If gv_MySQLDump_Path = "" Then
            MsgBox("Falta crear la Variable MySQLDump_Path", MsgBoxStyle.Critical, "MySQLDump_Path")
            End
        End If

        frmLogin.ShowDialog()
        frmLogin.Close()
        frmLogin.Dispose()
        TssDB.Text = "Conectado a Base de Datos: <- " & UCase(DBConnected) & " ->"
        FrmPuntoDeVenta.MdiParent = Me
        FrmPuntoDeVenta.StartPosition = FormStartPosition.CenterParent
        SetFormName(FrmPuntoDeVenta, DBConnected)
        FrmPuntoDeVenta.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim lv_backup_pathfile As String
        lv_backup_pathfile = "pv_salvador_" + Format(DateTime.Now.Day, "00") + "_" + Format(DateTime.Now.Month, "00") + "_" + Format(DateTime.Now.Year, "0000") + ".sql"
        GenerarBackUp(lv_backup_pathfile, 1)
        lv_backup_pathfile = "pv_librada_" + Format(DateTime.Now.Day, "00") + "_" + Format(DateTime.Now.Month, "00") + "_" + Format(DateTime.Now.Year, "0000") + ".sql"
        GenerarBackUp(lv_backup_pathfile, 2)
        lv_backup_pathfile = "pv_wendy_" + Format(DateTime.Now.Day, "00") + "_" + Format(DateTime.Now.Month, "00") + "_" + Format(DateTime.Now.Year, "0000") + ".sql"
        GenerarBackUp(lv_backup_pathfile, 3)
        End
    End Sub

    Private Sub ConfiguracionDelSistemaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConfiguracionDelSistemaToolStripMenuItem.Click
        'FrmPuntoDeVenta.Hide()
        FrmConfiguracion.ShowDialog()
        FrmConfiguracion.Close()
        FrmConfiguracion.Dispose()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        TssDate.Text = Now.ToLongDateString
        TssTime.Text = Now.ToShortTimeString
    End Sub

    Private Sub HistorialDeProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmHistoProveedores.ShowDialog()
        FrmHistoProveedores.Close()
        FrmHistoProveedores.Dispose()
    End Sub

    Private Sub ListadoDeOrdenesDeCompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmOrdenesCompra.ShowDialog()
        frmOrdenesCompra.Close()
        frmOrdenesCompra.Dispose()
    End Sub

    'Private Sub OtrasOperacionesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OtrasOperacionesToolStripMenuItem.Click
    '    FrmPuntoDeVenta.Hide()
    'End Sub

    'Private Sub TransaccionesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TransaccionesToolStripMenuItem.Click
    '    FrmPuntoDeVenta.Hide()
    'End Sub

    Private Sub PuntoDeVentaToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PuntoDeVentaToolStripMenuItem1.Click
        FrmPuntoDeVenta.MdiParent = Me
        FrmPuntoDeVenta.StartPosition = FormStartPosition.CenterParent
        SetFormName(FrmPuntoDeVenta, DBConnected)
        FrmPuntoDeVenta.Show()
    End Sub

    'Private Sub InformesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InformesToolStripMenuItem.Click
    '    FrmPuntoDeVenta.Hide()
    'End Sub

    'Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
    '    FrmPuntoDeVenta.Hide()
    'End Sub

    'Private Sub CatálogosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CatálogosToolStripMenuItem.Click
    '    FrmPuntoDeVenta.Hide()
    'End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        SetFormName(FrmBuscarClientes, DBConnected)
        FrmBuscarClientes.ShowDialog()
        FrmBuscarClientes.Close()
        FrmBuscarClientes.Dispose()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        SetFormName(FrmBuscarProveedores, DBConnected)
        FrmBuscarProveedores.ShowDialog()
        FrmBuscarProveedores.Close()
        FrmBuscarProveedores.Dispose()
    End Sub

    Private Sub FamiliasDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FamiliasDeProductosToolStripMenuItem.Click
        SetFormName(FrmBuscarFamilias, DBConnected)
        FrmBuscarFamilias.ShowDialog()
        FrmBuscarFamilias.Close()
        FrmBuscarFamilias.Dispose()
    End Sub

    Private Sub GruposDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GruposDeProductosToolStripMenuItem.Click
        SetFormName(FrmBuscarGrupos, DBConnected)
        FrmBuscarGrupos.ShowDialog()
        FrmBuscarGrupos.Close()
        FrmBuscarGrupos.Dispose()
    End Sub

    Private Sub LineasDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LineasDeProductosToolStripMenuItem.Click
        SetFormName(FrmBuscarLineas, DBConnected)
        FrmBuscarLineas.ShowDialog()
        FrmBuscarLineas.Close()
        FrmBuscarLineas.Dispose()
    End Sub

    Private Sub SubfamiliasDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubfamiliasDeProductosToolStripMenuItem.Click
        SetFormName(FrmBuscarSubFamilias, DBConnected)
        FrmBuscarSubFamilias.ShowDialog()
        FrmBuscarSubFamilias.Close()
        FrmBuscarSubFamilias.Dispose()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        SetFormName(FrmBuscarProductos, DBConnected)
        FrmBuscarProductos.ShowDialog()
        FrmBuscarProductos.Close()
        FrmBuscarProductos.Dispose()
    End Sub

    Private Sub UnidadesDeMedidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnidadesDeMedidaToolStripMenuItem.Click
        SetFormName(FrmBuscarUOM, DBConnected)
        FrmBuscarUOM.ShowDialog()
        FrmBuscarUOM.Close()
        FrmBuscarUOM.Dispose()
    End Sub

    Private Sub UsuariosDelSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosDelSistemaToolStripMenuItem.Click
        SetFormName(FrmUsuarios, DBConnected)
        FrmUsuarios.ShowDialog()
        FrmUsuarios.Close()
        FrmUsuarios.Dispose()
    End Sub

    Private Sub ListadoDeTicketsPorFacturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeTicketsPorFacturasToolStripMenuItem.Click
        SetFormName(FrmFacturasTickates, DBConnected)
        FrmFacturasTickates.ShowDialog()
        FrmFacturasTickates.Close()
        FrmFacturasTickates.Dispose()
    End Sub

    Private Sub ReimpresiónDeFacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReimpresiónDeFacturaToolStripMenuItem.Click
        SetFormName(FrmListadoNC, DBConnected)
        FrmListadoFacturas.ShowDialog()
        FrmListadoFacturas.Close()
        FrmListadoFacturas.Dispose()
    End Sub

    Private Sub RevisarFacturasConErroresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RevisarFacturasConErroresToolStripMenuItem.Click
        'SetFormName(frmFacturasErrores, DBConnected)
        'frmFacturasErrores.ShowDialog()
        'frmFacturasErrores.Close()
        'frmFacturasErrores.Dispose()
    End Sub

    Private Sub ConfiguraciónDeFoliosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraciónDeFoliosToolStripMenuItem.Click
        SetFormName(FrmFolioFactura, DBConnected)
        FrmFolioFactura.ShowDialog()
        FrmFolioFactura.Close()
        FrmFolioFactura.Dispose()
    End Sub

    Private Sub ReimpresionesDeNotasDeCréditoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReimpresionesDeNotasDeCréditoToolStripMenuItem.Click
        SetFormName(FrmListadoNC, DBConnected)
        FrmListadoNC.ShowDialog()
        FrmListadoNC.Close()
        FrmListadoNC.Dispose()
    End Sub

    Private Sub ListadoDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeProductosToolStripMenuItem.Click
        SetFormName(FrmListaProductos, DBConnected)
        FrmListaProductos.ShowDialog()
        FrmListaProductos.Close()
        FrmListaProductos.Dispose()
    End Sub

    Private Sub ListadoDeCotizacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeCotizacionesToolStripMenuItem.Click
        CotFlag = True
        SetFormName(FrmCotizaciones, DBConnected)
        FrmCotizaciones.ShowDialog()
        FrmCotizaciones.Close()
        FrmCotizaciones.Dispose()
        CotFlag = False
    End Sub

    Private Sub ListadoDeDeudoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeDeudoresToolStripMenuItem.Click
        SetFormName(FrmListadoDeudores, DBConnected)
        FrmListadoDeudores.ShowDialog()
        FrmListadoDeudores.Close()
        FrmListadoDeudores.Dispose()
    End Sub

    Private Sub ListadoDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeVentasToolStripMenuItem.Click
        SetFormName(FrmListadoVentas, DBConnected)
        FrmListadoVentas.ShowDialog()
        FrmListadoVentas.Close()
        FrmListadoVentas.Dispose()
    End Sub

    Private Sub ListadoDePreciosPorLineaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDePreciosPorLineaToolStripMenuItem.Click
        SetFormName(FrmListadoDePreciosPorLinea, DBConnected)
        FrmListadoDePreciosPorLinea.ShowDialog()
        FrmListadoDePreciosPorLinea.Close()
        FrmListadoDePreciosPorLinea.Dispose()
    End Sub

    Private Sub HistorialDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialDeClientesToolStripMenuItem.Click
        SetFormName(FrmHistorialCliente, DBConnected)
        FrmHistorialCliente.ShowDialog()
        FrmHistorialCliente.Close()
        FrmHistorialCliente.Dispose()
    End Sub

    Private Sub AjusteDeInventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjusteDeInventarioToolStripMenuItem.Click
        SetFormName(FrmAjusteDeInventario, DBConnected)
        FrmAjusteDeInventario.ShowDialog()
        FrmAjusteDeInventario.Close()
        FrmAjusteDeInventario.Dispose()
    End Sub

    Private Sub PagosDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosDeClientesToolStripMenuItem.Click
        SetFormName(FrmCuentasPorCobrar, DBConnected)
        FrmCuentasPorCobrar.ShowDialog()
        FrmCuentasPorCobrar.Close()
        FrmCuentasPorCobrar.Dispose()
    End Sub

    Private Sub ConvertirPedidoATicketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConvertirPedidoATicketToolStripMenuItem.Click
        SetFormName(FrmPedidos, DBConnected)
        FrmPedidos.ShowDialog()
        FrmPedidos.Close()
        FrmPedidos.Dispose()
    End Sub

    Private Sub DevoluciónDePedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevoluciónDePedidosToolStripMenuItem.Click
        SetFormName(FrmDevPedidos, DBConnected)
        FrmDevPedidos.ShowDialog()
        FrmDevPedidos.Close()
        FrmDevPedidos.Dispose()
    End Sub

    Private Sub DevoluciónDeTicketsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevoluciónDeTicketsToolStripMenuItem.Click
        SetFormName(FrmDevTickets, DBConnected)
        FrmDevTickets.ShowDialog()
        FrmDevTickets.Close()
        FrmDevTickets.Dispose()
    End Sub

    Private Sub NotasDeCréditoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotasDeCréditoToolStripMenuItem.Click
        SetFormName(FrmNotaDeCredito, DBConnected)
        FrmNotaDeCredito.ShowDialog()
        FrmNotaDeCredito.Close()
        FrmNotaDeCredito.Dispose()
    End Sub

    Private Sub GenerarRespaldoDeLaBaseDeDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarRespaldoDeLaBaseDeDatosToolStripMenuItem.Click
        Dim lv_backup_pathfile As String
        lv_backup_pathfile = "pv_salvador_" + Format(DateTime.Now.Day, "00") + "_" + Format(DateTime.Now.Month, "00") + "_" + Format(DateTime.Now.Year, "0000") + ".sql"
        GenerarBackUp(lv_backup_pathfile, 1)
        lv_backup_pathfile = "pv_librada_" + Format(DateTime.Now.Day, "00") + "_" + Format(DateTime.Now.Month, "00") + "_" + Format(DateTime.Now.Year, "0000") + ".sql"
        GenerarBackUp(lv_backup_pathfile, 2)
        lv_backup_pathfile = "pv_wendy_" + Format(DateTime.Now.Day, "00") + "_" + Format(DateTime.Now.Month, "00") + "_" + Format(DateTime.Now.Year, "0000") + ".sql"
        GenerarBackUp(lv_backup_pathfile, 3)
    End Sub

    Private Sub CorregirVentasACréditoConErroresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorregirVentasACréditoConErroresToolStripMenuItem.Click
        SetFormName(FrmListadoVentasError, DBConnected)
        FrmListadoVentasError.ShowDialog()
        FrmListadoVentasError.Close()
        FrmListadoVentasError.Dispose()
    End Sub
End Class
