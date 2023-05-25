Option Explicit On
Public Class MDIMain

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

        If gv_smtp_server = "" Then
            MsgBox("Falta crear la Variable SMTP_SERVER", MsgBoxStyle.Critical, "SMTP_SERVER")
            End
        End If

        If gv_smtp_port = "" Then
            MsgBox("Falta crear la Variable SMTP_PORT", MsgBoxStyle.Critical, "SMTP_PORT")
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

        If gv_CDFI_XML_PATH_QR = "" Then
            MsgBox("Falta crear la Variable CDFI_XML_PATH_QR", MsgBoxStyle.Critical, "CDFI_XML_PATH_QR")
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

    Private Sub PuntoDeVentaToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PuntoDeVentaToolStripMenuItem1.Click
        FrmPuntoDeVenta.MdiParent = Me
        FrmPuntoDeVenta.StartPosition = FormStartPosition.CenterParent
        FrmPuntoDeVenta.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        FrmBuscarClientes.ShowDialog()
        FrmBuscarClientes.Close()
        FrmBuscarClientes.Dispose()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        FrmBuscarProveedores.ShowDialog()
        FrmBuscarProveedores.Close()
        FrmBuscarProveedores.Dispose()
    End Sub

    Private Sub FamiliasDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FamiliasDeProductosToolStripMenuItem.Click
        FrmBuscarFamilias.ShowDialog()
        FrmBuscarFamilias.Close()
        FrmBuscarFamilias.Dispose()
    End Sub

    Private Sub GruposDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GruposDeProductosToolStripMenuItem.Click
        FrmBuscarGrupos.ShowDialog()
        FrmBuscarGrupos.Close()
        FrmBuscarGrupos.Dispose()
    End Sub

    Private Sub LineasDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LineasDeProductosToolStripMenuItem.Click
        FrmBuscarLineas.ShowDialog()
        FrmBuscarLineas.Close()
        FrmBuscarLineas.Dispose()
    End Sub

    Private Sub SubfamiliasDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubfamiliasDeProductosToolStripMenuItem.Click
        FrmBuscarSubFamilias.ShowDialog()
        FrmBuscarSubFamilias.Close()
        FrmBuscarSubFamilias.Dispose()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        FrmBuscarProductos.ShowDialog()
        FrmBuscarProductos.Close()
        FrmBuscarProductos.Dispose()
    End Sub

    Private Sub UnidadesDeMedidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnidadesDeMedidaToolStripMenuItem.Click
        FrmBuscarUOM.ShowDialog()
        FrmBuscarUOM.Close()
        FrmBuscarUOM.Dispose()
    End Sub

    Private Sub UsuariosDelSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosDelSistemaToolStripMenuItem.Click
        FrmUsuarios.ShowDialog()
        FrmUsuarios.Close()
        FrmUsuarios.Dispose()
    End Sub

    Private Sub ListadoDeTicketsPorFacturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeTicketsPorFacturasToolStripMenuItem.Click
        FrmFacturasTickates.ShowDialog()
        FrmFacturasTickates.Close()
        FrmFacturasTickates.Dispose()
    End Sub

    Private Sub ConfiguraciónDeFoliosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraciónDeFoliosToolStripMenuItem.Click
        FrmFolioFactura.ShowDialog()
        FrmFolioFactura.Close()
        FrmFolioFactura.Dispose()
    End Sub

    Private Sub ListadoDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeProductosToolStripMenuItem.Click
        FrmListaProductos.ShowDialog()
        FrmListaProductos.Close()
        FrmListaProductos.Dispose()
    End Sub

    Private Sub ListadoDeCotizacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeCotizacionesToolStripMenuItem.Click
        CotFlag = True
        FrmCotizaciones.ShowDialog()
        FrmCotizaciones.Close()
        FrmCotizaciones.Dispose()
        CotFlag = False
    End Sub

    Private Sub ListadoDeDeudoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeDeudoresToolStripMenuItem.Click
        FrmListadoDeudores.ShowDialog()
        FrmListadoDeudores.Close()
        FrmListadoDeudores.Dispose()
    End Sub

    Private Sub ListadoDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeVentasToolStripMenuItem.Click
        FrmListadoVentas.Show()

        'FrmListadoVentas.ShowDialog()
        'FrmListadoVentas.Close()
        'FrmListadoVentas.Dispose()
    End Sub

    Private Sub ListadoDePreciosPorLineaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDePreciosPorLineaToolStripMenuItem.Click
        FrmListadoDePreciosPorLinea.ShowDialog()
        FrmListadoDePreciosPorLinea.Close()
        FrmListadoDePreciosPorLinea.Dispose()
    End Sub

    Private Sub HistorialDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialDeClientesToolStripMenuItem.Click
        FrmHistorialCliente.ShowDialog()
        FrmHistorialCliente.Close()
        FrmHistorialCliente.Dispose()
    End Sub

    Private Sub AjusteDeInventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjusteDeInventarioToolStripMenuItem.Click
        FrmAjusteDeInventario.ShowDialog()
        FrmAjusteDeInventario.Close()
        FrmAjusteDeInventario.Dispose()
    End Sub

    Private Sub PagosDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosDeClientesToolStripMenuItem.Click
        FrmCuentasPorCobrar.ShowDialog()
        FrmCuentasPorCobrar.Close()
        FrmCuentasPorCobrar.Dispose()
    End Sub

    Private Sub ConvertirPedidoATicketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConvertirPedidoATicketToolStripMenuItem.Click
        FrmPedidos.ShowDialog()
        FrmPedidos.Close()
        FrmPedidos.Dispose()
    End Sub

    Private Sub DevoluciónDePedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevoluciónDePedidosToolStripMenuItem.Click
        FrmDevPedidos.ShowDialog()
        FrmDevPedidos.Close()
        FrmDevPedidos.Dispose()
    End Sub

    Private Sub DevoluciónDeTicketsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevoluciónDeTicketsToolStripMenuItem.Click
        FrmDevTickets.Show()

        'FrmDevTickets.ShowDialog()
        'FrmDevTickets.Close()
        'FrmDevTickets.Dispose()
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
        FrmListadoVentasError.ShowDialog()
        FrmListadoVentasError.Close()
        FrmListadoVentasError.Dispose()
    End Sub

    Private Sub MarcasDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcasDeProductosToolStripMenuItem.Click
        FrmBuscarMarcas.ShowDialog()
        FrmBuscarMarcas.Close()
        FrmBuscarMarcas.Dispose()
    End Sub

    Private Sub FacturaciónToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FacturaciónToolStripMenuItem1.Click
        FrmFacturacion.Show()

        'FrmFacturacion.ShowDialog()
        'FrmFacturacion.Close()
        'FrmFacturacion.Dispose()
    End Sub

    Private Sub ReimpresiónDeFacturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReimpresiónDeFacturasToolStripMenuItem.Click
        FrmListadoFacturas.ShowDialog()
        FrmListadoFacturas.Close()
        FrmListadoFacturas.Dispose()
    End Sub

    Private Sub ReimpresiónDeNotasDeCréditoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReimpresiónDeNotasDeCréditoToolStripMenuItem.Click
        FrmListadoNC.ShowDialog()
        FrmListadoNC.Close()
        FrmListadoNC.Dispose()
    End Sub

    Private Sub NotasDeCréditoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NotasDeCréditoToolStripMenuItem1.Click
        FrmNotaDeCredito.ShowDialog()
        FrmNotaDeCredito.Close()
        FrmNotaDeCredito.Dispose()
    End Sub

    Private Sub CuentasPorCobrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentasPorCobrarToolStripMenuItem.Click
        frmCuentasPorCobrarWendy.ShowDialog()
        frmCuentasPorCobrarWendy.Close()
        frmCuentasPorCobrarWendy.Dispose()
    End Sub

    Private Sub ComplementoDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComplementoDePagoToolStripMenuItem.Click
        frmComplementoPago.ShowDialog()
        frmComplementoPago.Close()
        frmComplementoPago.Dispose()
    End Sub
End Class
