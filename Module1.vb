Imports System.IO
Imports System.Text
Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports FacturacionSDK
Imports System.Net.Mail
Imports System.IO.Packaging
Imports System.Reflection
Imports System.Xml
Imports System.Data.SqlClient

Module Module1
    Public conn As New SqlConnection
    Public connStr As String
    Public myCommand As New SqlCommand
    Public myAdapter As New SqlDataAdapter
    Public SQL As String
    Public SQL2 As String
    Public myDs As New DataSet
    Public Sql1 As New StringBuilder()
    Public DBConnected As String
    Public CompanyCode As String

    Public ClaveUnidad As String = ""
    Public FormaPago As String = ""
    Public MetodoPago As String = ""
    Public UsoCDFI As String = ""
    Public gv_SerieFactura As String = ""
    Public RegimenFiscal As String
    Public LugarExpedicion As String

    Public privilegios As String
    Public usuario As String
    Public fventa, flimite, buscar, buscar2, motivoTexto, nombreUsuario, mensaje, coloniaCliente As String
    Public Config_On_Off As Boolean = False
    Public Logotipo As String = ""
    Public Add_Update As Boolean = False
    Public Action_Clientes As String = ""
    Public Buscar_Clientes As String = ""
    Public Buscar_Proveedores As String = ""
    Public idClienteVenta As String = ""
    Public idProveedor As String = "0"
    Public ProductoID As String = "0"
    Public Inventariado As Boolean = False
    Public idTipoPrecioCliente As String = ""
    Public factorP1, factorP2, factorP3, factorPublico, factorCosto As Double
    Public factorP1_TL, factorP2_TL, factorP3_TL, factorPublico_TL, factorCosto_TL As Double
    Public PrecioP1_TL, PrecioP2_TL, PrecioP3_TL, PrecioPublico_TL, PrecioCosto_TL As Double
    Public precioUnit, precioDesc, precioEsp, precioCosto, precioLista, subtotalCosto, precioPublico, subtotal, descuento, cantidad As Double
    Public TipoCambio As Double
    Public GranTipoCambio As Double

    Public Nombre As String
    Public Propietario As String
    Public RFC As String
    Public Domicilio As String
    Public Colonia As String
    Public Telefono As String
    Public Ciudad As String
    Public FactorIVA As String

    Public PV_subtotal As Double
    Public PV_iva As Double
    Public PV_total As Double
    Public Cambio As String
    Public PV_Contado_Paga As String
    Public PV_Contado_Cambio As String

    Public Material_Grupo As String = ""
    Public Material_Familia As String = ""
    Public Material_Marca As String = ""
    Public Material_Linea As String = ""
    Public Material_SubFam As String = ""
    Public Material_Proveedores As String = ""
    Public Material_Umedida As String = ""

    Public cuenta As String
    Public venta As String
    Public abono As String
    Public resto As String
    Public resto_total As String
    Public abono_total As String
    Public cliente As String
    Public cliente_abono As String
    Public idcliente As String
    Public fecha As String
    Public fechaL As String
    Public tipodoc As String
    Public total As String
    Public precio_linea As String = ""
    Public total_nota As String
    Public InvocePrinterName As String = ""
    Public TicketPrinterName As String = ""
    Public Cliente_limite As Double = 0
    Public Cliente_diasCredito As Double = 0
    Public EsCotizacion As Boolean = False
    Public AccionSalir As Boolean = False

    ' Adaptador de datos sql   
    Private SqlDataAdapter As SqlDataAdapter
    Public dt As New DataTable()
    Public dt2 As New DataTable()
    Public dt3 As New DataTable()
    Public dt4 As New DataTable()
    Public dt5 As New DataTable()

    'BindingSource   
    Public WithEvents bs As New BindingSource
    Public WithEvents bs2 As New BindingSource
    Public WithEvents bs3 As New BindingSource
    Public WithEvents bs4 As New BindingSource
    Public WithEvents bs5 As New BindingSource
    ' flag   
    Private bEdit As Boolean
    Private m_currentPageIndex As Integer
    Private m_streams As IList(Of Stream)
    Private PDFFileName As String = ""
    Private PDFFolderName As String = ""
    Private DeleteFileNameEMF As String = ""
    Public Error_Venta As Boolean = False
    Public Error_Limite_Credito As Boolean = False
    Public PagoContadoEfectuado As Boolean = False
    Private PageCount As Integer = 0
    Public AbonoSeleccionado As Boolean = False

    Public idapro As String
    Public foliotipodoc As String
    Public folioyear As String
    Public folioini As String
    Public foliofin As String
    Public folioactual As String

    Const lv_enter = vbCrLf
    Dim lv_mensaje As String = ""
    Dim lv_exitoRet As Integer = 1
    Public CotFlag As Boolean = False
    Public Cancelar As String = ""
    Public NoFactura As String = ""
    Public FechaFactura As String = ""

    Public lv_backup_error As Integer = 0

    Public gv_tasa_0 As Boolean = False
    Public gv_tasa_16 As Boolean = False

    Public gv_cfdi_usuario As String = ""
    Public gv_cfdi_password As String = ""
    Public gv_cfdi_prd As String = ""
    Public gv_sat_cer As String = ""
    Public gv_sat_key As String = ""
    Public gv_sat_pass As String = ""
    Public gv_smtp_correo As String = ""
    Public gv_smtp_pass As String = ""
    Public gv_terminal As String = ""
    Public gv_ConStringWendy As String = ""
    Public gv_ConStringLibrada As String = ""
    Public gv_ConStringSalvador As String = ""
    Public gv_Report_Path As String = ""
    Public gv_MySQLData As String = ""
    Public gv_MySQLBackUpPath As String = ""
    Public gv_MySQLDataWendy As String = ""
    Public gv_CDFI_XML_PATH As String = ""
    Public gv_CDFI_XML_PATH_QR As String = ""
    Public gv_RutaProceso As String = ""
    Public gv_MySQLDataLibrada As String = ""
    Public gv_SerieFacturaLibrada As String = ""
    Public gv_SerieNCLibrada As String = ""
    Public gv_SerieFacturaSalvador As String = ""
    Public gv_SerieNCSalvador As String = ""
    Public gv_MySQLDump_Path As String = ""
    Public gv_Report_Path_FE As String = ""

    Public Sub ReadConfigXML()
        Dim appPath As String = My.Application.Info.DirectoryPath
        Dim lv_fieldnameXML As String = ""

        Dim readXML As New XmlTextReader(appPath & "\XMLConfig.xml")
        While readXML.Read()
            Select Case readXML.NodeType
                Case XmlNodeType.Element
                    lv_fieldnameXML = readXML.Name
                    Exit Select
                Case XmlNodeType.Text
                    Select Case lv_fieldnameXML
                        Case "Terminal"
                            gv_terminal = readXML.Value.ToString
                        Case "CDFI_XML_PATH"
                            gv_CDFI_XML_PATH = readXML.Value
                        Case "CDFI_XML_PATH_QR"
                            gv_CDFI_XML_PATH_QR = readXML.Value
                        Case "CFDI_PASSWORD"
                            gv_cfdi_password = readXML.Value
                        Case "CFDI_PRD"
                            gv_cfdi_prd = readXML.Value
                        Case "CFDI_USUARIO"
                            gv_cfdi_usuario = readXML.Value
                        Case "ConStringLibrada"
                            gv_ConStringLibrada = readXML.Value
                        Case "ConStringSalvador"
                            gv_ConStringSalvador = readXML.Value
                        Case "ConStringWendy"
                            gv_ConStringWendy = readXML.Value
                        Case "MySQLBackUpPath"
                            gv_MySQLBackUpPath = readXML.Value
                        Case "MySQLData"
                            gv_MySQLData = readXML.Value
                        Case "MySQLDataLibrada"
                            gv_MySQLDataLibrada = readXML.Value
                        Case "MySQLDataWendy"
                            gv_MySQLDataWendy = readXML.Value
                        Case "MySQLDump_Path"
                            gv_MySQLDump_Path = readXML.Value
                        Case "Report_Path"
                            gv_Report_Path = readXML.Value
                        Case "Report_Path_FE"
                            gv_Report_Path_FE = readXML.Value
                        Case "RutaProceso"
                            gv_RutaProceso = readXML.Value
                        Case "SAT_CER"
                            gv_sat_cer = readXML.Value
                        Case "SAT_KEY"
                            gv_sat_key = readXML.Value
                        Case "SAT_PASS"
                            gv_sat_pass = readXML.Value
                        Case "SerieFacturaLibrada"
                            gv_SerieFacturaLibrada = readXML.Value
                        Case "SerieFacturaSalvador"
                            gv_SerieFacturaSalvador = readXML.Value
                        Case "SerieNCLibrada"
                            gv_SerieNCLibrada = readXML.Value
                        Case "SerieNCSalvador"
                            gv_SerieNCSalvador = readXML.Value
                        Case "SMTP_CORREO"
                            gv_smtp_correo = readXML.Value
                        Case "SMTP_PASS"
                            gv_smtp_pass = readXML.Value
                    End Select
                    Exit Select
            End Select
        End While
    End Sub

    Public Sub Limpia_Variables_SQL()
        'myCommand.Dispose()
        'myAdapter.Dispose()
        myDs.Tables.Clear()
        myDs.Dispose()
        myDs.Clear()
    End Sub

    Public Sub Limpia_Variables_SQL_y_Cierra_Conexion()
        'myCommand.Dispose()
        'myAdapter.Dispose()
        myDs.Tables.Clear()
        myDs.Dispose()
        myDs.Clear()
        'conn.Close()
    End Sub

    Public Sub Llena_Variables(ByVal lv_foliotipodoc As String, ByVal lv_folioini As String, ByVal lv_foliofin As String, ByVal lv_folioactual As String, ByVal lv_folioyear As String)
        foliotipodoc = lv_foliotipodoc
        folioyear = lv_folioyear
        folioini = lv_folioini
        foliofin = lv_foliofin
        folioactual = lv_folioactual
    End Sub

    Public Sub load_record_dgv5(ByVal sql As String, ByVal dv As DataGridView, ByVal DB As String)
        'Try
        '    ' Inicializar el SqlDataAdapter indicandole el comando y el connection string  
        '    Select Case DB
        '        Case "Wendy"
        '            SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringWendy)
        '        Case "Librada"
        '            SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringLibrada)
        '        Case "Salvador"
        '            SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringSalvador)
        '    End Select

        '    Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)

        '    ' llenar el DataTable   
        '    dt5.Clear()
        '    dt5.Dispose()
        '    dt5.Reset()
        '    dt5 = New DataTable
        '    SqlDataAdapter.Fill(dt5)

        '    ' Enlazar el BindingSource con el datatable anterior   
        '    ' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''   
        '    bs5.DataSource = dt5

        '    With dv
        '        .Refresh()
        '        ' coloca el registro arriba de todo  
        '        If bs.Position > -1 Then
        '            .FirstDisplayedScrollingRowIndex = bs.Position
        '        End If
        '    End With

        '    bEdit = False

        'Catch exSql As SqlException
        '    MsgBox(exSql.Message.ToString, MsgBoxStyle.Critical)
        '    Limpia_Variables_SQL_y_Cierra_Conexion()
        'Catch ex As Exception
        '    MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        '    Limpia_Variables_SQL_y_Cierra_Conexion()
        'End Try
    End Sub

    Public Sub load_record_dgv_best(ByVal sql As String, ByVal dv As DataGridView, ByVal DB As String)
        'Try
        '    Dim Dts As New clsMySQL(DB)

        '    Dts.EjecutarSQLTable(sql, dt)

        '    Dts.Dispose()
        'Catch exSql As SqlException
        '    MsgBox(exSql.Message.ToString, MsgBoxStyle.Critical)
        '    Limpia_Variables_SQL_y_Cierra_Conexion()
        'Catch ex As Exception
        '    MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        '    Limpia_Variables_SQL_y_Cierra_Conexion()
        'End Try
    End Sub

    Public Sub load_record_dgv(ByVal sql As String, ByVal dv As DataGridView, ByVal DB As String)
        Try
            load_record_dgv_best(sql, dv, DB)

            ' Enlazar el BindingSource con el datatable anterior   
            ' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''   
            bs.DataSource = dt
            With dv
                .Refresh()
                ' coloca el registro arriba de todo  
                If bs.Position > -1 Then
                    .FirstDisplayedScrollingRowIndex = bs.Position
                End If
            End With

            bEdit = False

        Catch exSql As SqlException
            MsgBox(exSql.Message.ToString, MsgBoxStyle.Critical)
            Limpia_Variables_SQL_y_Cierra_Conexion()
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            Limpia_Variables_SQL_y_Cierra_Conexion()
        End Try
    End Sub

    Public Sub load_record_dgv_cxc(ByVal sql As String, ByVal dv As DataGridView, ByVal DB As String)
        Try
            ' Inicializar el SqlDataAdapter indicandole el comando y el connection string   
            Select Case DB
                Case "Wendy"
                    SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringWendy)
                Case "Librada"
                    SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringLibrada)
                Case "Salvador"
                    SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringSalvador)
            End Select

            Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)

            ' llenar el DataTable   
            dt3.Clear()
            dt3.Dispose()
            dt3.Reset()
            dt3 = New DataTable
            SqlDataAdapter.Fill(dt3)

            ' Enlazar el BindingSource con el datatable anterior   
            ' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''   
            bs3.DataSource = dt3

            With dv
                .Refresh()
                ' coloca el registro arriba de todo  
                If bs3.Position > -1 Then
                    .FirstDisplayedScrollingRowIndex = bs3.Position
                End If
            End With

            bEdit = False

        Catch exSql As SqlException
            MsgBox(exSql.Message.ToString, MsgBoxStyle.Critical)
            Limpia_Variables_SQL_y_Cierra_Conexion()
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            Limpia_Variables_SQL_y_Cierra_Conexion()
        End Try
    End Sub

    'Public Sub load_record_dgv1(ByVal sql As String, ByVal dv As DataGridView, ByVal DB As String)
    '    Try
    '        ' Inicializar el SqlDataAdapter indicandole el comando y el connection string   
    '        Select Case DB
    '            Case "Wendy"
    '                SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringWendy)
    '            Case "Librada"
    '                SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringLibrada)
    '            Case "Salvador"
    '                SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringSalvador)
    '        End Select

    '        Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)

    '        ' llenar el DataTable   
    '        dt.Clear()
    '        dt.Dispose()
    '        dt.Reset()
    '        dt = New DataTable
    '        SqlDataAdapter.Fill(dt)

    '        ' Enlazar el BindingSource con el datatable anterior   
    '        ' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''   
    '        bs.DataSource = dt

    '        With dv
    '            .Refresh()
    '            ' coloca el registro arriba de todo  
    '            If bs.Position > -1 Then
    '                .FirstDisplayedScrollingRowIndex = bs.Position
    '            End If
    '        End With

    '        bEdit = False

    '    Catch exSql As SqlException
    '        MsgBox(exSql.Message.ToString, MsgBoxStyle.Critical)
    '    Catch ex As Exception
    '        MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
    '    End Try
    'End Sub

    Public Sub load_record_dgv3(ByVal sql As String, ByVal dv As DataGridView, ByVal DB As String)
        Try
            ' Inicializar el SqlDataAdapter indicandole el comando y el connection string   
            Select Case DB
                Case "Wendy"
                    SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringWendy)
                Case "Librada"
                    SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringLibrada)
                Case "Salvador"
                    SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringSalvador)
            End Select

            Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)

            ' llenar el DataTable   
            dt4.Clear()
            dt4.Dispose()
            dt4.Reset()
            dt4 = New DataTable
            SqlDataAdapter.Fill(dt4)

            ' Enlazar el BindingSource con el datatable anterior   
            ' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''   
            bs4.DataSource = dt4

            With dv
                .Refresh()
                ' coloca el registro arriba de todo  
                If bs.Position > -1 Then
                    .FirstDisplayedScrollingRowIndex = bs.Position
                End If
            End With

            bEdit = False

        Catch exSql As SqlException
            MsgBox(exSql.Message.ToString, MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub load_layout_dgv_1(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "#Ticket"
            dv.Columns(0).ReadOnly = True
            dv.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dv.Columns(1).HeaderText = "Fecha"
            dv.Columns(1).ReadOnly = True
            dv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dv.Columns(2).HeaderText = "Total"
            dv.Columns(2).ReadOnly = True
            dv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(2).DefaultCellStyle.Format = "$ ###,###,###.00"

            dv.Columns(3).HeaderText = "Tipo"
            dv.Columns(3).ReadOnly = True
            dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


            dv.Columns(4).HeaderText = "Usuario"
            dv.Columns(4).ReadOnly = True
            dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(4).Visible = False

            dv.Columns(5).HeaderText = "Cliente"
            dv.Columns(5).ReadOnly = True
            dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(5).Visible = False

            dv.Columns(7).HeaderText = "Estado"
            dv.Columns(7).ReadOnly = True
            dv.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dv.Columns(8).HeaderText = "Motivo"
            dv.Columns(8).ReadOnly = True
            dv.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dv.Columns(9).HeaderText = "Numero de Factura"
            dv.Columns(9).ReadOnly = True
            dv.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub load_record_dgv2(ByVal sql As String, ByVal dv As DataGridView, ByVal DB As String)
        'Try
        '    ' Inicializar el SqlDataAdapter indicandole el comando y el connection string   
        '    Select Case DB
        '        Case "Wendy"
        '            SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringWendy)
        '        Case "Librada"
        '            SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringLibrada)
        '        Case "Salvador"
        '            SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringSalvador)
        '    End Select

        '    Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)

        '    ' llenar el DataTable   
        '    dt2.Clear()
        '    dt2.Dispose()
        '    dt2.Reset()
        '    dt2 = New DataTable
        '    SqlDataAdapter.Fill(dt2)

        '    ' Enlazar el BindingSource con el datatable anterior   
        '    ' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''   
        '    bs2.DataSource = dt2

        '    With dv
        '        .Refresh()
        '        ' coloca el registro arriba de todo  
        '        If bs2.Position > -1 Then
        '            .FirstDisplayedScrollingRowIndex = bs2.Position
        '        End If
        '    End With

        '    bEdit = False

        'Catch exSql As SqlException
        '    MsgBox(exSql.Message.ToString, MsgBoxStyle.Critical)
        'Catch ex As Exception
        '    MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        'End Try
    End Sub

    'Public Sub load_record_dgv2_cotizacion(ByVal sql As String, ByVal dv As DataGridView, ByVal DB As String)
    '    Try
    '        ' Inicializar el SqlDataAdapter indicandole el comando y el connection string   
    '        Select Case DB
    '            Case "Wendy"
    '                SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringWendy)
    '            Case "Librada"
    '                SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringLibrada)
    '            Case "Salvador"
    '                SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringSalvador)
    '        End Select

    '        Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)

    '        ' llenar el DataTable   
    '        dt2.Clear()
    '        dt2.Dispose()
    '        dt2.Reset()
    '        dt2 = New DataTable
    '        SqlDataAdapter.Fill(dt2)


    '        ' Enlazar el BindingSource con el datatable anterior   
    '        ' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''   
    '        bs2.DataSource = dt2

    '        With dv
    '            .Refresh()
    '            ' coloca el registro arriba de todo  
    '            If bs2.Position > -1 Then
    '                .FirstDisplayedScrollingRowIndex = bs2.Position
    '            End If
    '        End With

    '        bEdit = False

    '    Catch exSql As SqlException
    '        MsgBox(exSql.Message.ToString, MsgBoxStyle.Critical)
    '    Catch ex As Exception
    '        MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
    '    End Try
    'End Sub

    Public Sub load_record_dgv2_pedido(ByVal sql As String, ByVal dv As DataGridView, ByVal DB As String)
        Try
            ' Inicializar el SqlDataAdapter indicandole el comando y el connection string   
            Select Case DB
                Case "Wendy"
                    SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringWendy)
                Case "Librada"
                    SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringLibrada)
                Case "Salvador"
                    SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringSalvador)
            End Select

            Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)

            ' llenar el DataTable   
            dt2.Clear()
            dt2.Dispose()
            dt2.Reset()
            dt2 = New DataTable
            SqlDataAdapter.Fill(dt2)

            ' Enlazar el BindingSource con el datatable anterior   
            ' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''   
            bs2.DataSource = dt2

            With dv
                .Refresh()
                ' coloca el registro arriba de todo  
                If bs2.Position > -1 Then
                    .FirstDisplayedScrollingRowIndex = bs2.Position
                End If
            End With

            bEdit = False

        Catch exSql As SqlException
            MsgBox(exSql.Message.ToString, MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub load_record_dgv_pedido(ByVal sql As String, ByVal dv As DataGridView, ByVal DB As String)
        Try
            ' Inicializar el SqlDataAdapter indicandole el comando y el connection string   
            Select Case DB
                Case "Wendy"
                    SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringWendy)
                Case "Librada"
                    SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringLibrada)
                Case "Salvador"
                    SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringSalvador)
            End Select

            Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)

            ' llenar el DataTable   
            dt.Clear()
            dt.Dispose()
            dt.Reset()
            dt = New DataTable
            SqlDataAdapter.Fill(dt)

            ' Enlazar el BindingSource con el datatable anterior   
            ' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''   
            bs.DataSource = dt

            With dv
                .Refresh()
                ' coloca el registro arriba de todo  
                If bs.Position > -1 Then
                    .FirstDisplayedScrollingRowIndex = bs.Position
                End If
            End With

            bEdit = False

        Catch exSql As SqlException
            MsgBox(exSql.Message.ToString, MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub
    '---------------------------------------Folios--------------------------------------------------------
    Public Sub load_layout_dgv_folios(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "Tipo de Documento"
            dv.Columns(0).ReadOnly = True
            dv.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dv.Columns(0).Width = "200"

            dv.Columns(1).HeaderText = "Año"
            dv.Columns(1).ReadOnly = True
            dv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(1).Width = "50"

            dv.Columns(2).HeaderText = "Folio Inicial"
            dv.Columns(2).ReadOnly = True
            dv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dv.Columns(3).HeaderText = "Folio Final"
            dv.Columns(3).ReadOnly = True
            dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dv.Columns(4).HeaderText = "Folio Actual"
            dv.Columns(4).ReadOnly = True
            dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub load_layout_dgv_clientes(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "Id Cliente"
            dv.Columns(0).ReadOnly = True
            '            dv.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            dv.Columns(1).HeaderText = "Nombre"
            dv.Columns(1).ReadOnly = True
            '            dv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            dv.Columns(2).HeaderText = "Apellido Paterno"
            dv.Columns(2).ReadOnly = True
            '            dv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            dv.Columns(3).HeaderText = "Apellido Materno"
            dv.Columns(3).ReadOnly = True
            '            dv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            dv.Columns(4).Visible = False
            dv.Columns(5).Visible = False
            dv.Columns(6).Visible = False
            dv.Columns(7).Visible = False
            dv.Columns(8).Visible = False
            dv.Columns(9).Visible = False
            dv.Columns(10).HeaderText = "R.F.C."
            dv.Columns(10).ReadOnly = True
            dv.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dv.Columns(11).Visible = False
            dv.Columns(12).Visible = False
            dv.Columns(13).Visible = False
            dv.Columns(14).Visible = False
            dv.Columns(15).Visible = False
            dv.Columns(16).Visible = False
            dv.Columns(17).Visible = False
            '            dv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            Limpia_Variables_SQL_y_Cierra_Conexion()
        End Try
    End Sub

    Public Sub load_layout_dgv_proveedor(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "ID"
            dv.Columns(0).ReadOnly = True
            dv.Columns(0).Width = 50

            dv.Columns(1).HeaderText = "Razón Social"
            dv.Columns(1).ReadOnly = True
            dv.Columns(1).Width = 400

            dv.Columns(2).HeaderText = "Domicilio"
            dv.Columns(2).ReadOnly = True
            dv.Columns(2).Width = 300

            dv.Columns(3).HeaderText = "Número"
            dv.Columns(3).ReadOnly = True
            dv.Columns(3).Visible = False

            dv.Columns(4).HeaderText = "Colonia"
            dv.Columns(4).ReadOnly = True
            dv.Columns(4).Visible = False

            dv.Columns(5).HeaderText = "Ciudad"
            dv.Columns(5).ReadOnly = True
            dv.Columns(5).Visible = False

            dv.Columns(6).HeaderText = "Estado"
            dv.Columns(6).ReadOnly = True
            dv.Columns(6).Visible = False

            dv.Columns(7).HeaderText = "Código Postal"
            dv.Columns(7).ReadOnly = True
            dv.Columns(7).Visible = False

            dv.Columns(8).HeaderText = "R.F.C."
            dv.Columns(8).ReadOnly = True
            dv.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            dv.Columns(9).HeaderText = "Teléfono"
            dv.Columns(9).ReadOnly = True
            dv.Columns(9).Visible = False

            dv.Columns(10).HeaderText = "Celular"
            dv.Columns(10).ReadOnly = True
            dv.Columns(10).Visible = False

            dv.Columns(11).HeaderText = "Email"
            dv.Columns(11).ReadOnly = True
            dv.Columns(11).Visible = False

            dv.Columns(12).HeaderText = "Contacto"
            dv.Columns(12).ReadOnly = True
            dv.Columns(12).Visible = False

            dv.Columns(13).HeaderText = "Observaciones"
            dv.Columns(13).ReadOnly = True
            dv.Columns(13).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            Limpia_Variables_SQL_y_Cierra_Conexion()
        End Try
    End Sub

    Public Sub load_layout_dgv_proveedor_histo(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "Id Transaccion"
            dv.Columns(0).ReadOnly = True
            dv.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(0).Visible = False

            dv.Columns(1).HeaderText = "Fecha"
            dv.Columns(1).ReadOnly = True
            dv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dv.Columns(2).HeaderText = "Total"
            dv.Columns(2).ReadOnly = True
            dv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(2).DefaultCellStyle.Format = "$ ###,###,##0.00"

            dv.Columns(3).HeaderText = "Tipo"
            dv.Columns(3).ReadOnly = True
            dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(3).Visible = False

            dv.Columns(4).HeaderText = "Usuario"
            dv.Columns(4).ReadOnly = True
            dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(4).Visible = False

            dv.Columns(5).HeaderText = "Proveedor"
            dv.Columns(5).ReadOnly = True
            dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dv.Columns(5).Width = 300

            dv.Columns(6).HeaderText = "Id Proveedor"
            dv.Columns(6).ReadOnly = True
            dv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(6).Visible = False

            dv.Columns(7).HeaderText = "Estado"
            dv.Columns(7).ReadOnly = True
            dv.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dv.Columns(8).HeaderText = "Motivo"
            dv.Columns(8).ReadOnly = True
            dv.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            'dv.Columns(8).Visible = False

            dv.Columns(9).HeaderText = "N° Factura"
            dv.Columns(9).ReadOnly = True
            dv.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub load_layout_dgv_familias(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "Id Familia"
            dv.Columns(0).ReadOnly = True

            dv.Columns(1).HeaderText = "Descripción"
            dv.Columns(1).ReadOnly = True
            dv.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            Limpia_Variables_SQL_y_Cierra_Conexion()
        End Try
    End Sub

    Public Sub load_layout_dgv_lineas(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "Id Línea"
            dv.Columns(0).ReadOnly = True

            dv.Columns(1).HeaderText = "Descripción"
            dv.Columns(1).ReadOnly = True
            dv.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            Limpia_Variables_SQL_y_Cierra_Conexion()
        End Try
    End Sub

    Public Sub load_layout_dgv_subfamilias(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "Id SubFamilia"
            dv.Columns(0).ReadOnly = True

            dv.Columns(1).HeaderText = "Descripción"
            dv.Columns(1).ReadOnly = True
            dv.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            Limpia_Variables_SQL_y_Cierra_Conexion()
        End Try
    End Sub

    Public Sub load_layout_dgv_uom(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "Id UoM"
            dv.Columns(0).ReadOnly = True

            dv.Columns(1).HeaderText = "Descripción"
            dv.Columns(1).ReadOnly = True
            dv.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            Limpia_Variables_SQL_y_Cierra_Conexion()
        End Try
    End Sub

    Public Sub load_layout_dgv_grupos(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "Id Grupo"
            dv.Columns(0).ReadOnly = True

            dv.Columns(1).HeaderText = "Descripción"
            dv.Columns(1).ReadOnly = True

            dv.Columns(2).HeaderText = "Factor Costo"
            dv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(2).ReadOnly = True

            dv.Columns(3).HeaderText = "Factor Publico"
            dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(3).ReadOnly = True

            dv.Columns(4).HeaderText = "Factor P1"
            dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(4).ReadOnly = True

            dv.Columns(5).HeaderText = "Factor P2"
            dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(5).ReadOnly = True

            dv.Columns(6).HeaderText = "Factor P3"
            dv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(6).ReadOnly = True
            dv.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            Limpia_Variables_SQL_y_Cierra_Conexion()
        End Try
    End Sub

    Public Sub load_layout_dgv_productos(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "Id Prod."
            dv.Columns(0).ReadOnly = True

            dv.Columns(1).HeaderText = "C.B."
            dv.Columns(1).ReadOnly = True

            dv.Columns(2).HeaderText = "Clave"
            dv.Columns(2).ReadOnly = True

            dv.Columns(3).HeaderText = "Producto"
            dv.Columns(3).ReadOnly = True

            dv.Columns(4).HeaderText = "UoM"
            dv.Columns(4).ReadOnly = True

            dv.Columns(5).HeaderText = "Grupo"
            dv.Columns(5).ReadOnly = True

            dv.Columns(6).HeaderText = "Familia"
            dv.Columns(6).ReadOnly = True

            dv.Columns(7).HeaderText = "SubFamilia"
            dv.Columns(7).ReadOnly = True

            dv.Columns(8).HeaderText = "Línea"
            dv.Columns(8).ReadOnly = True

            dv.Columns(9).HeaderText = "Proveedor"
            dv.Columns(9).ReadOnly = True

            dv.Columns(10).HeaderText = "Tipo Venta"
            dv.Columns(10).ReadOnly = True

            dv.Columns(11).HeaderText = "Descuento"
            dv.Columns(11).ReadOnly = True
            dv.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(11).DefaultCellStyle.Format = "###,###,###.00 %"

            dv.Columns(12).HeaderText = "Precio Lista"
            dv.Columns(12).ReadOnly = True
            dv.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(12).DefaultCellStyle.Format = "$ ###,###,###.00"

            dv.Columns(13).HeaderText = "Precio Costo"
            dv.Columns(13).ReadOnly = True
            dv.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(13).DefaultCellStyle.Format = "$ ###,###,###.00"

            dv.Columns(14).HeaderText = "Precio Público"
            dv.Columns(14).ReadOnly = True
            dv.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(14).DefaultCellStyle.Format = "$ ###,###,###.00"

            dv.Columns(15).HeaderText = "Precio P1"
            dv.Columns(15).ReadOnly = True
            dv.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(15).DefaultCellStyle.Format = "$ ###,###,###.00"

            dv.Columns(16).HeaderText = "Precio P2"
            dv.Columns(16).ReadOnly = True
            dv.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(16).DefaultCellStyle.Format = "$ ###,###,###.00"

            dv.Columns(17).HeaderText = "Precio P3"
            dv.Columns(17).ReadOnly = True
            dv.Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(17).DefaultCellStyle.Format = "$ ###,###,###.00"

            dv.Columns(18).HeaderText = "Stock"
            dv.Columns(18).ReadOnly = True
            dv.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(18).DefaultCellStyle.Format = "###,###,###.00"

            dv.Columns(19).HeaderText = "Precio Manual"
            dv.Columns(19).ReadOnly = True
            'dv.Columns(19).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            Limpia_Variables_SQL_y_Cierra_Conexion()
        End Try
    End Sub

    Public Sub load_layout_dgv_ListaVenta_cotiza(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "Folio"
            dv.Columns(0).ReadOnly = True
            dv.Columns(0).Visible = False

            dv.Columns(1).HeaderText = "Ctd"
            dv.Columns(1).ReadOnly = True
            dv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(1).Width = 60

            dv.Columns(2).HeaderText = "Descripcion"
            dv.Columns(2).ReadOnly = True
            dv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dv.Columns(2).Width = 400

            dv.Columns(3).HeaderText = "Precio Unitario"
            dv.Columns(3).ReadOnly = True
            dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(3).DefaultCellStyle.Format = "$ ###,###,###.00"

            dv.Columns(4).HeaderText = "Subtotal"
            dv.Columns(4).ReadOnly = True
            dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(4).DefaultCellStyle.Format = "$ ###,###,###.00"

            dv.Columns(5).HeaderText = "Código Barra "
            dv.Columns(5).ReadOnly = True
            dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            dv.Columns(6).HeaderText = "IdProducto"
            dv.Columns(6).ReadOnly = True
            dv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(6).Visible = False
            dv.Columns(7).Visible = False
            dv.Columns(8).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub load_layout_dgv_ListaVenta_cotizacion(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "Ticket #"
            dv.Columns(0).ReadOnly = True
            dv.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(0).Width = 70

            dv.Columns(1).HeaderText = "Fecha"
            dv.Columns(1).ReadOnly = True
            dv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dv.Columns(2).HeaderText = "SubTotal"
            dv.Columns(2).ReadOnly = True
            dv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(2).DefaultCellStyle.Format = "$ ###,###,###.00"
            dv.Columns(2).Visible = False

            dv.Columns(3).HeaderText = "IVA"
            dv.Columns(3).ReadOnly = True
            dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(3).DefaultCellStyle.Format = "$ ###,###,###.00"
            dv.Columns(3).Visible = False

            dv.Columns(4).HeaderText = "Total"
            dv.Columns(4).ReadOnly = True
            dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(4).DefaultCellStyle.Format = "$ ###,###,###.00"

            dv.Columns(5).HeaderText = "Tipo"
            dv.Columns(5).ReadOnly = True
            dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(5).Visible = False

            dv.Columns(6).HeaderText = "Usuario"
            dv.Columns(6).ReadOnly = True
            dv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(6).Visible = False

            dv.Columns(7).HeaderText = "Cliente"
            dv.Columns(7).ReadOnly = True
            dv.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dv.Columns(7).Width = 300
            dv.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            dv.Columns(8).HeaderText = "IdCliente"
            dv.Columns(8).ReadOnly = True
            dv.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(8).Visible = True

            dv.Columns(9).HeaderText = "Estado"
            dv.Columns(9).ReadOnly = True
            dv.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(9).Visible = False

            dv.Columns(10).HeaderText = "Motivo"
            dv.Columns(10).ReadOnly = True
            dv.Columns(10).Visible = False

            dv.Columns(11).HeaderText = "Facturado"
            dv.Columns(11).ReadOnly = True
            dv.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(11).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub load_layout_dgv_lineas2(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "Clave"
            dv.Columns(0).ReadOnly = True
            dv.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(0).DefaultCellStyle.Format = "#########"
            dv.Columns(0).Width = 100

            dv.Columns(1).HeaderText = "Codigo de Barras"
            dv.Columns(1).ReadOnly = True
            dv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(1).Width = 100

            dv.Columns(2).HeaderText = "Descripcion"
            dv.Columns(2).ReadOnly = True
            dv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(2).DefaultCellStyle.Format = "$ ###,###,###.00"
            dv.Columns(2).Width = 130

            dv.Columns(3).HeaderText = "U.M."
            dv.Columns(3).ReadOnly = True
            dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(3).Width = 100

            dv.Columns(4).HeaderText = "Grupo"
            dv.Columns(4).ReadOnly = True
            dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(4).Visible = False
            dv.Columns(4).Width = 100

            dv.Columns(5).HeaderText = "Precio"
            dv.Columns(5).ReadOnly = True
            dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dv.Columns(5).Width = 300


        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub load_layout_dgv_ListaVenta_h(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "Venta"
            dv.Columns(0).ReadOnly = True
            dv.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(0).DefaultCellStyle.Format = "#########"
            dv.Columns(0).Width = 100

            dv.Columns(1).HeaderText = "Fecha"
            dv.Columns(1).ReadOnly = True
            dv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(1).Width = 100

            dv.Columns(2).HeaderText = "SubTotal"
            dv.Columns(2).ReadOnly = True
            dv.Columns(2).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(2).Visible = False

            dv.Columns(3).HeaderText = "IVA"
            dv.Columns(3).ReadOnly = True
            dv.Columns(3).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(3).Visible = False

            dv.Columns(4).HeaderText = "Total"
            dv.Columns(4).ReadOnly = True
            dv.Columns(4).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dv.Columns(5).HeaderText = "Tipo"
            dv.Columns(5).ReadOnly = True
            dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dv.Columns(6).HeaderText = "Usuario"
            dv.Columns(6).ReadOnly = True
            dv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(6).Visible = False

            dv.Columns(7).HeaderText = "Cliente"
            dv.Columns(7).ReadOnly = True
            dv.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(7).Width = 100

            dv.Columns(8).HeaderText = "IdCliente"
            dv.Columns(8).ReadOnly = True
            dv.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(8).Visible = False

            dv.Columns(9).HeaderText = "Estado"
            dv.Columns(9).ReadOnly = True
            dv.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dv.Columns(10).HeaderText = "Motivo"
            dv.Columns(10).ReadOnly = True

            dv.Columns(11).HeaderText = "#factura"
            dv.Columns(11).ReadOnly = True
            dv.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub load_layout_dgv_ListaFactura_H(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "Factura"
            dv.Columns(0).ReadOnly = True
            dv.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(0).DefaultCellStyle.Format = "#########"
            dv.Columns(0).Width = 70

            dv.Columns(1).HeaderText = "Total"
            dv.Columns(1).ReadOnly = True
            dv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(1).DefaultCellStyle.Format = "$ ###,###,###.00"
            dv.Columns(1).Width = 110

            dv.Columns(2).HeaderText = "Usuario"
            dv.Columns(2).ReadOnly = True
            dv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(2).Visible = False
            dv.Columns(2).Width = 100

            dv.Columns(3).HeaderText = "Tipo"
            dv.Columns(3).ReadOnly = True
            dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(3).Width = 100

            dv.Columns(4).HeaderText = "Cliente"
            dv.Columns(4).ReadOnly = True
            dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dv.Columns(4).Width = 400

            dv.Columns(5).HeaderText = "IdCliente"
            dv.Columns(5).ReadOnly = True
            dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dv.Columns(5).Visible = False
            dv.Columns(5).Width = 100

            dv.Columns(6).HeaderText = "Fecha Factura"
            dv.Columns(6).ReadOnly = True
            dv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(6).Width = 100

            dv.Columns(7).HeaderText = "Fecha Límite"
            dv.Columns(7).ReadOnly = True
            dv.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(7).Visible = False
            dv.Columns(7).Width = 100

            dv.Columns(8).HeaderText = "Condiciones"
            dv.Columns(8).ReadOnly = True
            dv.Columns(8).Visible = False
            dv.Columns(8).Width = 100

            dv.Columns(9).HeaderText = "Estado"
            dv.Columns(9).ReadOnly = True
            dv.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dv.Columns(9).Width = 100

            dv.Columns(10).HeaderText = "Observaciones"
            dv.Columns(10).ReadOnly = True
            dv.Columns(10).Width = 100

            dv.Columns(11).HeaderText = "Tipo Factura"
            dv.Columns(11).ReadOnly = True
            dv.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(11).Visible = False
            dv.Columns(11).Width = 150

            dv.Columns(12).HeaderText = "Tipo Factura"
            dv.Columns(12).ReadOnly = True
            dv.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(12).Width = 150

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub load_layout_dgv_ListaNC_H(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "Nota de Crédito"
            dv.Columns(0).ReadOnly = True
            dv.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(0).DefaultCellStyle.Format = "#########"
            dv.Columns(0).Width = 70

            dv.Columns(1).HeaderText = "Total"
            dv.Columns(1).ReadOnly = True
            dv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(1).DefaultCellStyle.Format = "$ ###,###,###.00"
            dv.Columns(1).Width = 110

            dv.Columns(2).HeaderText = "Usuario"
            dv.Columns(2).ReadOnly = True
            dv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(2).Visible = False
            dv.Columns(2).Width = 100

            dv.Columns(3).HeaderText = "Tipo"
            dv.Columns(3).ReadOnly = True
            dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(3).Width = 100

            dv.Columns(4).HeaderText = "Cliente"
            dv.Columns(4).ReadOnly = True
            dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dv.Columns(4).Width = 400

            dv.Columns(5).HeaderText = "IdCliente"
            dv.Columns(5).ReadOnly = True
            dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            dv.Columns(5).Visible = False
            dv.Columns(5).Width = 100

            dv.Columns(6).HeaderText = "Fecha NC"
            dv.Columns(6).ReadOnly = True
            dv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(6).Width = 100

            dv.Columns(7).HeaderText = "Fecha Límite"
            dv.Columns(7).ReadOnly = True
            dv.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(7).Visible = False
            dv.Columns(7).Width = 100

            dv.Columns(8).HeaderText = "Condiciones"
            dv.Columns(8).ReadOnly = True
            dv.Columns(8).Visible = False
            dv.Columns(8).Width = 100

            dv.Columns(9).HeaderText = "Estado"
            dv.Columns(9).ReadOnly = True
            dv.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dv.Columns(9).Width = 100

            dv.Columns(10).HeaderText = "Observaciones"
            dv.Columns(10).ReadOnly = True
            dv.Columns(10).Width = 100

            dv.Columns(11).HeaderText = "Tipo NC"
            dv.Columns(11).ReadOnly = True
            dv.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(11).Visible = False
            dv.Columns(11).Width = 150

            dv.Columns(12).HeaderText = "Tipo NC"
            dv.Columns(12).ReadOnly = True
            dv.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(12).Width = 150

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub load_layout_dgv_ListaVenta_i(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "Folio"
            dv.Columns(0).ReadOnly = True
            dv.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(0).Visible = False

            dv.Columns(1).HeaderText = "Descripcion"
            dv.Columns(1).ReadOnly = True
            dv.Columns(1).Width = 300

            dv.Columns(2).HeaderText = "Cantidad"
            dv.Columns(2).ReadOnly = True
            dv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dv.Columns(3).HeaderText = "Precio Unitario"
            dv.Columns(3).ReadOnly = True
            dv.Columns(3).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dv.Columns(4).HeaderText = "Fecha"
            dv.Columns(4).ReadOnly = True
            dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(4).Visible = False

            dv.Columns(5).HeaderText = "Subtotal"
            dv.Columns(5).ReadOnly = True
            dv.Columns(5).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dv.Columns(6).HeaderText = "Clave Producto"
            dv.Columns(6).ReadOnly = True
            dv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(6).Visible = False

            dv.Columns(7).HeaderText = "Precio Costo"
            dv.Columns(7).ReadOnly = True
            dv.Columns(7).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(7).Visible = False

            dv.Columns(8).HeaderText = "SubTotal Costo"
            dv.Columns(8).ReadOnly = True
            dv.Columns(8).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(8).Visible = False

            dv.Columns(9).HeaderText = "IdProducto"
            dv.Columns(9).ReadOnly = True
            dv.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dv.Columns(10).HeaderText = "Factura"
            dv.Columns(10).ReadOnly = True
            dv.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(10).Visible = False

            dv.Columns(11).HeaderText = "ClaveProducto"
            dv.Columns(11).ReadOnly = True
            dv.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dv.Columns(12).HeaderText = "ClaveUnidad"
            dv.Columns(12).ReadOnly = True
            dv.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dv.Columns(13).HeaderText = "TasaCero"
            dv.Columns(13).ReadOnly = True
            dv.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub load_layout_dgv_ListaFacturas_i(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "Factura"
            dv.Columns(0).ReadOnly = True
            dv.Columns(0).Visible = False


            dv.Columns(1).HeaderText = "Cantidad"
            dv.Columns(1).ReadOnly = True
            dv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(1).Width = 100

            dv.Columns(2).HeaderText = "Concepto"
            dv.Columns(2).ReadOnly = True
            dv.Columns(2).Width = 400

            dv.Columns(3).HeaderText = "Precio"
            dv.Columns(3).ReadOnly = True
            dv.Columns(3).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(3).Width = 120

            dv.Columns(4).HeaderText = "SubTotal"
            dv.Columns(4).ReadOnly = True
            dv.Columns(4).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(4).Width = 120

            dv.Columns(5).HeaderText = "Codigo de Barras"
            dv.Columns(5).ReadOnly = True
            dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(5).Width = 120

            dv.Columns(6).HeaderText = "Id Producto"
            dv.Columns(6).ReadOnly = True
            dv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(6).Visible = False

            dv.Columns(7).HeaderText = "Fecha"
            dv.Columns(7).ReadOnly = True
            dv.Columns(7).Visible = False

            dv.Columns(8).HeaderText = "Ticket"
            dv.Columns(8).ReadOnly = True
            dv.Columns(8).Visible = True
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub load_layout_dgv_ListaNC_i(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "Nota de Crédito"
            dv.Columns(0).ReadOnly = True
            dv.Columns(0).Visible = False


            dv.Columns(1).HeaderText = "Cantidad"
            dv.Columns(1).ReadOnly = True
            dv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(1).Width = 100

            dv.Columns(2).HeaderText = "Concepto"
            dv.Columns(2).ReadOnly = True
            dv.Columns(2).Width = 400

            dv.Columns(3).HeaderText = "Precio"
            dv.Columns(3).ReadOnly = True
            dv.Columns(3).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(3).Width = 120

            dv.Columns(4).HeaderText = "SubTotal"
            dv.Columns(4).ReadOnly = True
            dv.Columns(4).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(4).Width = 120

            dv.Columns(5).HeaderText = "Codigo de Barras"
            dv.Columns(5).ReadOnly = True
            dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(5).Width = 120

            dv.Columns(6).HeaderText = "Id Producto"
            dv.Columns(6).ReadOnly = True
            dv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(6).Visible = False

            dv.Columns(7).HeaderText = "Fecha"
            dv.Columns(7).ReadOnly = True
            dv.Columns(7).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub load_layout_dgv_ListaTickets(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "Ticket"
            dv.Columns(0).ReadOnly = True


            dv.Columns(1).HeaderText = "Fecha"
            dv.Columns(1).ReadOnly = True
            dv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


            dv.Columns(2).HeaderText = "Total"
            dv.Columns(2).ReadOnly = True
            dv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(2).DefaultCellStyle.Format = "$ ###,###,##0.00"

            dv.Columns(3).HeaderText = "Tipo"
            dv.Columns(3).ReadOnly = True
            dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dv.Columns(4).HeaderText = "Usuario"
            dv.Columns(4).ReadOnly = True
            dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dv.Columns(5).HeaderText = "Cliente"
            dv.Columns(5).ReadOnly = True
            dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dv.Columns(6).HeaderText = "Id Cliente"
            dv.Columns(6).ReadOnly = True
            dv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dv.Columns(7).HeaderText = "Estado"
            dv.Columns(7).ReadOnly = True
            dv.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dv.Columns(8).HeaderText = "Motivo"
            dv.Columns(8).ReadOnly = True
            dv.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dv.Columns(9).HeaderText = "Numero Factura"
            dv.Columns(9).ReadOnly = True
            dv.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub load_layout_dgv_ticket_pedido(ByVal dv As DataGridView)
        Try

            dv.Columns(0).HeaderText = "Folio"
            dv.Columns(0).ReadOnly = True
            dv.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(0).Visible = False

            dv.Columns(1).HeaderText = "Descripcion"
            dv.Columns(1).ReadOnly = True
            dv.Columns(1).Width = 300

            dv.Columns(2).HeaderText = "Cantidad"
            dv.Columns(2).ReadOnly = True
            dv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dv.Columns(3).HeaderText = "Precio Unitario"
            dv.Columns(3).ReadOnly = True
            dv.Columns(3).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dv.Columns(4).HeaderText = "Fecha"
            dv.Columns(4).ReadOnly = True
            dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(4).Visible = False

            dv.Columns(5).HeaderText = "Subtotal"
            dv.Columns(5).ReadOnly = True
            dv.Columns(5).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dv.Columns(6).HeaderText = "Clave Producto"
            dv.Columns(6).ReadOnly = True
            dv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(6).Visible = False

            dv.Columns(7).HeaderText = "Precio Costo"
            dv.Columns(7).ReadOnly = True
            dv.Columns(7).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(7).Visible = False

            dv.Columns(8).HeaderText = "SubTotal Costo"
            dv.Columns(8).ReadOnly = True
            dv.Columns(8).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(8).Visible = False

            dv.Columns(9).HeaderText = "IdProducto"
            dv.Columns(9).ReadOnly = True
            dv.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dv.Columns(10).HeaderText = "Factura"
            dv.Columns(10).ReadOnly = True
            dv.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(10).Visible = False

            dv.Columns(11).HeaderText = "ClaveProducto"
            dv.Columns(11).ReadOnly = True
            dv.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dv.Columns(12).HeaderText = "ClaveUnidad"
            dv.Columns(12).ReadOnly = True
            dv.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dv.Columns(13).HeaderText = "TasaCero"
            dv.Columns(13).ReadOnly = True
            dv.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub load_layout_dgv_pedido(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "#Venta"
            dv.Columns(0).ReadOnly = True
            dv.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dv.Columns(1).HeaderText = "Fecha"
            dv.Columns(1).ReadOnly = True
            dv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dv.Columns(2).HeaderText = "SubTotal"
            dv.Columns(2).ReadOnly = True
            dv.Columns(2).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(2).Visible = False

            dv.Columns(3).HeaderText = "IVA"
            dv.Columns(3).ReadOnly = True
            dv.Columns(3).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(3).Visible = False

            dv.Columns(4).HeaderText = "Total"
            dv.Columns(4).ReadOnly = True
            dv.Columns(4).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dv.Columns(5).HeaderText = "Tipo"
            dv.Columns(5).ReadOnly = True
            dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dv.Columns(6).HeaderText = "Usuario"
            dv.Columns(6).ReadOnly = True
            dv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(6).Visible = False

            dv.Columns(7).HeaderText = "Cliente"
            dv.Columns(7).ReadOnly = True
            dv.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(7).Width = 100

            dv.Columns(8).HeaderText = "IdCliente"
            dv.Columns(8).ReadOnly = True
            dv.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(8).Visible = False

            dv.Columns(9).HeaderText = "Estado"
            dv.Columns(9).ReadOnly = True
            dv.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dv.Columns(10).HeaderText = "Motivo"
            dv.Columns(10).ReadOnly = True

            dv.Columns(11).HeaderText = "#factura"
            dv.Columns(11).ReadOnly = True
            dv.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub load_layout_dgv_ListaVenta_Deudores(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "Cliente"
            dv.Columns(0).ReadOnly = True
            dv.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dv.Columns(0).Width = 300

            dv.Columns(1).HeaderText = "Ticket"
            dv.Columns(1).ReadOnly = True
            dv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(1).Width = 60

            dv.Columns(2).HeaderText = "Total"
            dv.Columns(2).ReadOnly = True
            dv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(2).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(2).Width = 100

            dv.Columns(3).HeaderText = "Resto"
            dv.Columns(3).ReadOnly = True
            dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(3).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(3).Width = 100

            dv.Columns(4).HeaderText = "Venta"
            dv.Columns(4).ReadOnly = True
            dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(4).Width = 100

            dv.Columns(5).HeaderText = "Limite"
            dv.Columns(5).ReadOnly = True
            dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(5).Width = 100

            dv.Columns(6).HeaderText = "Docto"
            dv.Columns(6).ReadOnly = True
            dv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dv.Columns(6).Width = 70
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub load_record_dgv2_ordenes(ByVal sql As String, ByVal dv As DataGridView, ByVal DB As String)
        Try
            ' Inicializar el SqlDataAdapter indicandole el comando y el connection string   
            Select Case DB
                Case "Wendy"
                    SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringWendy)
                Case "Librada"
                    SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringLibrada)
                Case "Salvador"
                    SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringSalvador)
            End Select

            Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)

            ' llenar el DataTable   
            dt2.Clear()
            dt2.Dispose()
            dt2.Reset()
            dt2 = New DataTable
            SqlDataAdapter.Fill(dt2)

            ' Enlazar el BindingSource con el datatable anterior   
            ' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''   
            bs2.DataSource = dt2

            With dv
                .Refresh()
                ' coloca el registro arriba de todo  
                If bs2.Position > -1 Then
                    .FirstDisplayedScrollingRowIndex = bs2.Position
                End If
            End With

            bEdit = False

        Catch exSql As SqlException
            MsgBox(exSql.Message.ToString, MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub load_record_dgv_ordenes(ByVal sql As String, ByVal dv As DataGridView, ByVal DB As String)
        Try
            ' Inicializar el SqlDataAdapter indicandole el comando y el connection string   
            Select Case DB
                Case "Wendy"
                    SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringWendy)
                Case "Librada"
                    SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringLibrada)
                Case "Salvador"
                    SqlDataAdapter = New SqlDataAdapter(sql, gv_ConStringSalvador)
            End Select

            Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)

            ' llenar el DataTable   
            dt.Clear()
            dt.Dispose()
            dt.Reset()
            dt = New DataTable
            SqlDataAdapter.Fill(dt)

            ' Enlazar el BindingSource con el datatable anterior   
            ' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''   
            bs.DataSource = dt

            With dv
                .Refresh()
                ' coloca el registro arriba de todo  
                If bs.Position > -1 Then
                    .FirstDisplayedScrollingRowIndex = bs.Position
                End If
            End With

            bEdit = False

        Catch exSql As SqlException
            MsgBox(exSql.Message.ToString, MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub load_layout_dgv_ordenes(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "#OC"
            dv.Columns(0).ReadOnly = True
            dv.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(0).Width = 100

            dv.Columns(1).HeaderText = "Fecha"
            dv.Columns(1).ReadOnly = True
            dv.Columns(1).Width = 100

            dv.Columns(2).HeaderText = "Proveedor"
            dv.Columns(2).ReadOnly = True
            dv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dv.Columns(2).Width = 400

            dv.Columns(3).HeaderText = "Id Proveedor"
            dv.Columns(3).ReadOnly = True
            dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(3).Visible = False
            dv.Columns(3).Width = 100

            dv.Columns(4).HeaderText = "Atencion Para"
            dv.Columns(4).ReadOnly = True
            dv.Columns(4).Width = 200



        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try

    End Sub

    Public Sub load_layout_dgv2_ordenes(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "folio"
            dv.Columns(0).ReadOnly = True
            dv.Columns(0).Visible = False

            dv.Columns(1).HeaderText = "Cantidad"
            dv.Columns(1).ReadOnly = True
            dv.Columns(1).Width = 100

            dv.Columns(2).HeaderText = "Descripcion"
            dv.Columns(2).ReadOnly = True
            dv.Columns(2).Width = 400

            dv.Columns(3).HeaderText = "Codigo de barra"
            dv.Columns(3).ReadOnly = True
            dv.Columns(3).Width = 200

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try

    End Sub

    Public Sub load_layout_dgv_cuentasxcobrar(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "Movimiento"
            dv.Columns(0).ReadOnly = True
            dv.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(0).Visible = False
            dv.Columns(0).Width = 100

            dv.Columns(1).HeaderText = "Venta"
            dv.Columns(1).ReadOnly = True
            dv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(1).Width = 110

            dv.Columns(2).HeaderText = "Total"
            dv.Columns(2).ReadOnly = True
            dv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(2).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(2).Width = 110

            dv.Columns(3).HeaderText = "Fecha Venta"
            dv.Columns(3).ReadOnly = True
            dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(3).Width = 110


            dv.Columns(4).HeaderText = "Fecha Límite"
            dv.Columns(4).ReadOnly = True
            dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(4).Width = 110

            dv.Columns(5).HeaderText = "Cliente"
            dv.Columns(5).ReadOnly = True
            dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dv.Columns(5).Width = 280

            dv.Columns(6).HeaderText = "Resto"
            dv.Columns(6).ReadOnly = True
            dv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(6).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(6).Width = 100

            dv.Columns(7).HeaderText = "Clave Cliente"
            dv.Columns(7).ReadOnly = True
            dv.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(7).Visible = False
            dv.Columns(7).Width = 100

            dv.Columns(8).HeaderText = "Tipo Doc."
            dv.Columns(8).ReadOnly = True
            dv.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(8).Width = 100

            dv.Columns(8).HeaderText = "Facturado"
            dv.Columns(8).ReadOnly = True
            dv.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(8).Width = 70
            dv.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub load_layout_dgv_cuentaxcobrar2(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "ID"
            dv.Columns(0).ReadOnly = True
            dv.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(0).Visible = False

            dv.Columns(1).HeaderText = "Fecha"
            dv.Columns(1).ReadOnly = True
            dv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(1).Width = 100

            dv.Columns(2).HeaderText = "Venta"
            dv.Columns(2).ReadOnly = True
            dv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(2).Width = 100

            dv.Columns(3).HeaderText = "Total"
            dv.Columns(3).ReadOnly = True
            dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(3).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(3).Width = 100

            dv.Columns(4).HeaderText = "Clave Cliente"
            dv.Columns(4).ReadOnly = True
            dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(4).Visible = False

            dv.Columns(5).HeaderText = "Cliente"
            dv.Columns(5).ReadOnly = True
            dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dv.Columns(5).Width = 300

            dv.Columns(6).HeaderText = "Observaciones"
            dv.Columns(6).ReadOnly = True
            dv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dv.Columns(6).Width = 200
            dv.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub load_layout_dgv_Listaproductos(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "Cod.Barras"
            dv.Columns(0).ReadOnly = True
            dv.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(0).Width = 100

            dv.Columns(1).HeaderText = "Clave"
            dv.Columns(1).ReadOnly = True
            dv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(1).Width = 100

            dv.Columns(2).HeaderText = "Descripción del Producto"
            dv.Columns(2).ReadOnly = True
            dv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dv.Columns(2).Width = 400

            dv.Columns(3).HeaderText = "UoM"
            dv.Columns(3).ReadOnly = True
            dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(3).Width = 100

            dv.Columns(4).HeaderText = "Público"
            dv.Columns(4).ReadOnly = True
            dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(4).Width = 100

            dv.Columns(5).HeaderText = "Precio P1"
            dv.Columns(5).ReadOnly = True
            dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(5).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(5).Width = 100

            dv.Columns(6).HeaderText = "Precio P2"
            dv.Columns(6).ReadOnly = True
            dv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(6).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(6).Width = 100

            dv.Columns(7).HeaderText = "Precio P3"
            dv.Columns(7).ReadOnly = True
            dv.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(7).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(7).Width = 100

            dv.Columns(8).HeaderText = "Stock"
            dv.Columns(8).ReadOnly = True
            dv.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(8).DefaultCellStyle.Format = "########0.00"
            dv.Columns(8).Width = 100

            dv.Columns(9).HeaderText = "Inv"
            dv.Columns(9).ReadOnly = True
            dv.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(9).DefaultCellStyle.Format = "########0.00"
            dv.Columns(9).Width = 70

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub load_layout_dgv_Listaproductos_todos(ByVal dv As DataGridView)
        Try
            dv.Columns(0).HeaderText = "Id Producto"
            dv.Columns(0).ReadOnly = True
            dv.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(0).Visible = False

            dv.Columns(1).HeaderText = "Cod.Barras"
            dv.Columns(1).ReadOnly = True
            dv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(1).Width = 100

            dv.Columns(2).HeaderText = "Clave"
            dv.Columns(2).ReadOnly = True
            dv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(2).Width = 100

            dv.Columns(3).HeaderText = "Descripción de Producto"
            dv.Columns(3).ReadOnly = True
            dv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dv.Columns(3).Width = 400

            dv.Columns(4).HeaderText = "UoM"
            dv.Columns(4).ReadOnly = True
            dv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(4).Width = 100

            dv.Columns(5).HeaderText = "Grupo"
            dv.Columns(5).ReadOnly = True
            dv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(5).Visible = False

            dv.Columns(6).HeaderText = "Familia"
            dv.Columns(6).ReadOnly = True
            dv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(6).Visible = False

            dv.Columns(7).HeaderText = "Sub Familia"
            dv.Columns(7).ReadOnly = True
            dv.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(7).Visible = False

            dv.Columns(8).HeaderText = "Linea"
            dv.Columns(8).ReadOnly = True
            dv.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(8).Visible = False

            dv.Columns(9).HeaderText = "Proveedor"
            dv.Columns(9).ReadOnly = True
            dv.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(9).Visible = False

            dv.Columns(10).HeaderText = "Tipo Venta"
            dv.Columns(10).ReadOnly = True
            dv.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(10).Visible = False

            dv.Columns(11).HeaderText = "Descuento"
            dv.Columns(11).ReadOnly = True
            dv.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(11).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(11).Visible = False

            dv.Columns(12).HeaderText = "Precio Lista"
            dv.Columns(12).ReadOnly = True
            dv.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(12).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(12).Visible = False

            dv.Columns(13).HeaderText = "Precio Costo"
            dv.Columns(13).ReadOnly = True
            dv.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(13).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(13).Visible = False

            dv.Columns(14).HeaderText = "Público"
            dv.Columns(14).ReadOnly = True
            dv.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(14).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(14).Width = 100

            dv.Columns(15).HeaderText = "Precio P1"
            dv.Columns(15).ReadOnly = True
            dv.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(15).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(15).Width = 100

            dv.Columns(16).HeaderText = "Precio P2"
            dv.Columns(16).ReadOnly = True
            dv.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(16).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(16).Width = 100

            dv.Columns(17).HeaderText = "Precio P3"
            dv.Columns(17).ReadOnly = True
            dv.Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(17).DefaultCellStyle.Format = "$ ###,###,##0.00"
            dv.Columns(17).Width = 100

            dv.Columns(18).HeaderText = "Stock"
            dv.Columns(18).ReadOnly = True
            dv.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dv.Columns(18).DefaultCellStyle.Format = "########0.00"
            dv.Columns(18).Width = 100

            dv.Columns(19).HeaderText = "Precio Manual"
            dv.Columns(19).ReadOnly = True
            dv.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(19).Visible = False

            dv.Columns(20).HeaderText = "Inv"
            dv.Columns(20).ReadOnly = True
            dv.Columns(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dv.Columns(20).Visible = True

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Function Dinero(ByVal Monto As Double, ByVal ncents As Integer, ByVal desmon As String, ByVal mn As Boolean)
        Dim nmonto As Double
        Dim acUnid(10) As String
        Dim acDecY(10) As String
        Dim acDec(10) As String
        Dim acCent(10) As String
        Dim acGrup(5) As String
        Dim acGrp1(5) As String
        Dim acEsp(10) As String
        Dim masmen As String
        Dim cRetVal As String
        Dim cCant As String
        Dim caux As String
        Dim naux1 As String
        Dim naux2 As String
        Dim naux3 As String
        Dim n As Integer
        Dim cCents As Double
        Dim sCents As String
        Dim lGrpFlg As Boolean
        Dim Moneda As String
        Moneda = desmon
        nmonto = Math.Abs(Math.Round(Monto, 2))
        masmen = IIf(Math.Round(Monto, 2) >= 0, "", "Menos ")
        acUnid(1) = "Un "
        acUnid(2) = "Dos "
        acUnid(3) = "Tres "
        acUnid(4) = "Cuatro "
        acUnid(5) = "Cinco "
        acUnid(6) = "Seis "
        acUnid(7) = "Siete "
        acUnid(8) = "Ocho "
        acUnid(9) = "Nueve "
        acDecY(1) = "Dieci"
        acDecY(2) = "Veinti"
        acDecY(3) = "Treinta y "
        acDecY(4) = "Cuarenta y "
        acDecY(5) = "Cincuenta y "
        acDecY(6) = "Sesenta y "
        acDecY(7) = "Setenta y "
        acDecY(8) = "Ochenta y "
        acDecY(9) = "Noventa y "
        acDec(1) = "Diez "
        acDec(2) = "Veinte "
        acDec(3) = "Treinta "
        acDec(4) = "Cuarenta "
        acDec(5) = "Cincuenta "
        acDec(6) = "Sesenta "
        acDec(7) = "Setenta "
        acDec(8) = "Ochenta "
        acDec(9) = "Noventa "
        acCent(1) = "Ciento "
        acCent(2) = "Doscientos "
        acCent(3) = "Trescientos "
        acCent(4) = "Cuatrocientos "
        acCent(5) = "Quinientos "
        acCent(6) = "Seiscientos "
        acCent(7) = "Setecientos "
        acCent(8) = "Ochocientos "
        acCent(9) = "Novecientos "
        acGrup(1) = "Billones "
        acGrup(2) = "Mil "
        acGrup(3) = "Millones "
        acGrup(4) = "Mil "
        acGrp1(1) = "Bill¢n "
        acGrp1(2) = "Mil "
        acGrp1(3) = "Mill¢n "
        acGrp1(4) = "Mil "
        acEsp(1) = "Once "
        acEsp(2) = "Doce "
        acEsp(3) = "Trece "
        acEsp(4) = "Catorce "
        acEsp(5) = "Quince "
        If Int(nmonto) = 0 Then
            cRetVal = "Cero "
        Else
            cCant = Format(Int(nmonto), "000000000000000")
            cRetVal = masmen
            For n = 0 To 4
                caux = Mid(cCant, 3 * n + 1, 3)
                If caux = "100" Then
                    cRetVal = cRetVal & "Cien "
                Else
                    naux1 = Asc(Left(caux, 1)) - 48
                    naux2 = Asc(Right(Left(caux, 2), 1)) - 48
                    naux3 = Asc(Right(caux, 1)) - 48
                    If naux1 <> 0 Then
                        cRetVal = cRetVal & acCent(naux1)
                    End If
                    If naux2 = 1 And (naux3 = 1 Or naux3 = 2 Or naux3 = 3 Or naux3 = 4 Or naux3 = 5) Then
                        cRetVal = cRetVal & acEsp(naux3)
                    Else
                        If naux3 = 0 Then
                            If naux2 <> 0 Then cRetVal = cRetVal & acDec(naux2)
                        Else
                            If naux2 <> 0 Then cRetVal = cRetVal & acDecY(naux2)
                        End If
                        cRetVal = cRetVal & acUnid(naux3)
                    End If
                End If
                If n < 4 Then
                    If caux = "000" Then
                        If lGrpFlg = True Then
                            cRetVal = cRetVal & acGrup(n + 1)
                            lGrpFlg = False
                        End If
                    Else
                        If cRetVal = "Un " Then
                            cRetVal = cRetVal & acGrp1(n + 1)
                        Else
                            cRetVal = cRetVal & acGrup(n + 1)
                        End If
                        lGrpFlg = (n = 1 Or n = 3)
                    End If
                End If
            Next
        End If
        cRetVal = UCase(Left(cRetVal, 1)) & LCase(Mid(cRetVal, 2))
        If ncents > 0 And ncents < 5 Then
            cCents = nmonto - Int(nmonto)
            sCents = Format(cCents * 100, "00")
            If Right(cRetVal, 4) = "l¢n " Or Right(cRetVal, 4) = "nes " Then cRetVal = cRetVal & "DE "
            cRetVal = cRetVal & Moneda & " "
            Select Case (ncents)
                Case 1 : cRetVal = cRetVal & sCents & "/100"
                Case 2 : cRetVal = cRetVal & " " & sCents & "/100"
                Case 3
                    If cCents = "00" Then
                        cRetVal = cRetVal & "Sin Centimos"
                    Else
                        cRetVal = cRetVal & "con " & sCents & " CENTIMOS"
                    End If
                Case 4
                    If cCents = "00" Then
                        cRetVal = cRetVal & "Sin Centavos"
                    Else
                        cRetVal = cRetVal & "con " & sCents & " CENTAVOS"
                    End If
            End Select
        Else
            cRetVal = cRetVal & Trim(cRetVal)
            If cRetVal = "Un " Then cRetVal = "Uno"
        End If
        ' Agregado de MN para el caso de moneda local
        If mn And (UCase(desmon) = "Peso" Or UCase(desmon) = "PESOS") Then cRetVal = cRetVal & " M.N."
        Dinero = cRetVal
    End Function

    'START ***********************************Imprimir ReportViewer directo a Impresora******************************************
    Private Function CreateStream(name As String, fileNameExtension As String, encoding As Encoding, mimeType As String, willSeek As Boolean) As Stream
        Dim stream As Stream = Nothing
        Dim bool1 As Boolean = IO.Directory.Exists(PDFFolderName)
        Try
            PDFFileName = Replace(PDFFileName, "/", "")
            PDFFileName = Replace(PDFFileName, """", "")
            If bool1 = True Then
                If fileNameExtension <> "pdf" Then
                    If m_streams.Count > 0 Then
                        If System.IO.File.Exists(PDFFolderName + "\" + PDFFileName + "_" + PageCount.ToString + "." + fileNameExtension) = False Then
                            stream = New FileStream(PDFFolderName + "\" + PDFFileName + "_" + PageCount.ToString + "." + fileNameExtension, FileMode.Create)
                            m_streams.Add(stream)
                        End If
                    Else
                        stream = New FileStream(PDFFolderName + "\" + PDFFileName + "_" + PageCount.ToString + "." + fileNameExtension, FileMode.Create)
                        m_streams.Add(stream)
                    End If
                Else
                    stream = New FileStream(PDFFolderName + "\" + PDFFileName + "_" + PageCount.ToString + "." + fileNameExtension, FileMode.Create)
                    m_streams.Add(stream)
                End If
            Else
                System.IO.Directory.CreateDirectory(PDFFolderName)
                If fileNameExtension <> "pdf" Then
                    If m_streams.Count > 0 Then
                        If System.IO.File.Exists(PDFFolderName + "\" + PDFFileName + "_" + PageCount.ToString + "." + fileNameExtension) = False Then
                            stream = New FileStream(PDFFolderName + "\" + PDFFileName + "_" + PageCount.ToString + "." + fileNameExtension, FileMode.Create)
                            m_streams.Add(stream)
                        End If
                    Else
                        stream = New FileStream(PDFFolderName + "\" + PDFFileName + "_" + PageCount.ToString + "." + fileNameExtension, FileMode.Create)
                        m_streams.Add(stream)
                    End If
                Else
                    stream = New FileStream(PDFFolderName + "\" + PDFFileName + "_" + PageCount.ToString + "." + fileNameExtension, FileMode.Create)
                    m_streams.Add(stream)
                End If
            End If

            If stream Is Nothing Then
                For Each stream In m_streams
                    'stream.Close()
                Next
            End If
            '            m_streams.Add(stream)
            If fileNameExtension = "EMF" Then
                DeleteFileNameEMF = PDFFolderName + "\" + PDFFileName
            End If
            PageCount = PageCount + 1
            Return stream
        Catch ex As Exception
            Return stream
        End Try
    End Function

    Private Sub Export2(report As LocalReport, i_type As String)
        Dim lv_filetype As String
        If i_type = "Pdf" Then
            lv_filetype = "PDF"
        Else
            lv_filetype = "EMF"
        End If

        Dim deviceInfo As String =
          "<DeviceInfo>" +
          "  <OutputFormat>" + lv_filetype + "</OutputFormat>" +
          "  <PageWidth>8.5in</PageWidth>" +
          "  <PageHeight>11in</PageHeight>" +
          "  <MarginTop>0.0in</MarginTop>" +
          "  <MarginLeft>0.0in</MarginLeft>" +
          "  <MarginRight>0.0in</MarginRight>" +
          "  <MarginBottom>0.0in</MarginBottom>" +
          "</DeviceInfo>"
        Dim warnings() As Warning = Nothing
        m_streams = New List(Of Stream)()
        If i_type = "Pdf" Then
            PageCount = 1
            report.Render("Pdf", deviceInfo, AddressOf CreateStream, warnings)
        Else
            PageCount = 1
            report.Render("Image", deviceInfo, AddressOf CreateStream, warnings)
        End If
        Dim stream As Stream
        For Each stream In m_streams
            stream.Position = 0
        Next
    End Sub

    Private Sub Export(report As LocalReport, i_type As String, i_doctype As String)
        Dim lv_filetype As String
        Dim lv_PaperWith As String
        Dim lv_PaperHeight As String
        Select Case i_doctype
            Case "VENTA"
                lv_PaperWith = "76mm"
                lv_PaperHeight = "297mm"
            Case Else
                lv_PaperWith = "8.5in"
                lv_PaperHeight = "11in"
        End Select
        If i_type = "Pdf" Then
            lv_filetype = "PDF"
        Else
            lv_filetype = "EMF"
        End If

        Dim deviceInfo As String =
          "<DeviceInfo>" +
          "  <OutputFormat>" + lv_filetype + "</OutputFormat>" +
          "  <PageWidth>" + lv_PaperWith + "</PageWidth>" +
          "  <PageHeight>" + lv_PaperHeight + "</PageHeight>" +
          "  <MarginTop>0.0in</MarginTop>" +
          "  <MarginLeft>0.0in</MarginLeft>" +
          "  <MarginRight>0.0in</MarginRight>" +
          "  <MarginBottom>0.0in</MarginBottom>" +
          "</DeviceInfo>"
        Dim warnings() As Warning = Nothing
        m_streams = New List(Of Stream)()
        If i_type = "Pdf" Then
            PageCount = 1
            report.Render("Pdf", deviceInfo, AddressOf CreateStream, warnings)
        Else
            PageCount = 1
            report.Render("Image", deviceInfo, AddressOf CreateStream, warnings)
        End If
        Dim stream As Stream
        For Each stream In m_streams
            stream.Position = 0
        Next
    End Sub

    Private Sub PrintPage(sender As Object, ev As PrintPageEventArgs)
        Dim pageImage As New Metafile(m_streams(m_currentPageIndex))
        ev.Graphics.DrawImage(pageImage, ev.PageBounds)

        m_currentPageIndex += 1
        ev.HasMorePages = (m_currentPageIndex < m_streams.Count)
    End Sub

    Private Sub Print(i_printer_name As String, i_copies As Integer)
        If m_streams Is Nothing Or m_streams.Count = 0 Then
            Return
        End If

        Dim printDoc As New PrintDocument()
        printDoc.PrinterSettings.PrinterName = i_printer_name
        If Not printDoc.PrinterSettings.IsValid Then
            Dim msg As String = String.Format("Can't find printer ""{0}"".", i_printer_name)
            Debug.WriteLine(msg)
            Return
        End If
        AddHandler printDoc.PrintPage, AddressOf PrintPage
        printDoc.PrinterSettings.Copies = i_copies

        printDoc.Print()
    End Sub

    Public Sub Print_Report(i_printer_name As String, i_report_object As LocalReport, i_copies As Integer, i_type As String, i_filename As String, i_foldername As String, i_doctype As String)
        If i_type = "Pdf" Then
            PDFFileName = i_filename
            PDFFolderName = i_foldername
            Export(i_report_object, i_type, i_doctype)
            If Not (m_streams Is Nothing) Then
                Dim stream As Stream
                For Each stream In m_streams
                    stream.Close()
                Next
                m_streams = Nothing
            End If
        Else
            PDFFileName = i_filename
            PDFFolderName = i_foldername
            Export(i_report_object, i_type, i_doctype)

            m_currentPageIndex = 0
            Print(i_printer_name, i_copies)
            If Not (m_streams Is Nothing) Then
                Dim stream As Stream
                For Each stream In m_streams
                    stream.Close()
                Next
                m_streams = Nothing
                If DeleteFileNameEMF <> "" Then
                    For i = 1 To PageCount - 1
                        System.IO.File.Delete(DeleteFileNameEMF + "_" + i.ToString + ".EMF")
                    Next
                End If
            End If
        End If
    End Sub
    'END ***********************************Imprimir ReportViewer directo a Impresora******************************************

    Public Function ImprimeFactura2(ByVal NumeroFactura As String, ByVal FolioFactura As String, ByVal Imprimir As Boolean) As Boolean

        Dim dt_detail As DataTable = New DataTable
        '---------Variables para reporte--------------
        Dim rep_FormadePago As String
        Dim rep_MetododePago As String
        Dim rep_UsoCFDI As String
        Dim rep_folio As String = FolioFactura
        Dim rep_direccion As String
        Dim rep_colonia As String
        Dim rep_cuidad As String

        '--------------------------------------------

        dt_detail.Columns.Add("cantidad", GetType(Integer))
        dt_detail.Columns.Add("unidad", GetType(String))
        dt_detail.Columns.Add("clave", GetType(String))
        dt_detail.Columns.Add("descripcion", GetType(String))
        dt_detail.Columns.Add("precio", GetType(Double))
        dt_detail.Columns.Add("subtotal", GetType(Double))
        dt_detail.Columns.Add("noidentificacion", GetType(String))
        dt_detail.Columns.Add("impuesto", GetType(String))
        dt_detail.Columns.Add("base", GetType(Double))
        dt_detail.Columns.Add("importe", GetType(Double))
        dt_detail.Columns.Add("tasaocuota", GetType(Double))

        dt_detail.TableName = "facturas"
        Try
            Dim Report As New LocalReport
            Dim ruta As String = gv_CDFI_XML_PATH
            Dim DS As New DataSet
            Dim dt_comprobante As DataTable = New DataTable

            ruta = ruta & rep_folio & ".xml"
            Dim fsReadXml As New System.IO.FileStream(ruta, System.IO.FileMode.Open)
            DS.ReadXml(fsReadXml)

            Dim lv_iva_total As Double = 0
            For i = 0 To DS.Tables("Concepto").Rows.Count - 1

                Dim dt_details_row As DataRow = dt_detail.NewRow()

                dt_details_row("cantidad") = CInt(DS.Tables("Concepto").Rows(i)("Cantidad"))
                dt_details_row("unidad") = DS.Tables("Concepto").Rows(i)("ClaveUnidad").ToString()
                dt_details_row("clave") = DS.Tables("Concepto").Rows(i)("ClaveProdServ").ToString()
                dt_details_row("noidentificacion") = DS.Tables("Concepto").Rows(i)("NoIdentificacion").ToString()
                dt_details_row("descripcion") = DS.Tables("Concepto").Rows(i)("Descripcion").ToString()
                dt_details_row("impuesto") = DS.Tables("Traslado").Rows(i)("Impuesto")
                dt_details_row("base") = CDbl(DS.Tables("Traslado").Rows(i)("Base"))
                dt_details_row("importe") = CDbl(DS.Tables("Traslado").Rows(i)("Importe"))
                dt_details_row("tasaocuota") = CDbl(DS.Tables("Traslado").Rows(i)("TasaOCuota")) * 100
                dt_details_row("precio") = CDbl(DS.Tables("Concepto").Rows(i)("ValorUnitario"))
                dt_details_row("subtotal") = CDbl(DS.Tables("Concepto").Rows(i)("Importe"))

                lv_iva_total = lv_iva_total + CDbl(DS.Tables("Traslado").Rows(i)("Importe"))
                dt_detail.Rows.Add(dt_details_row)

            Next

            rep_FormadePago = DS.Tables("Comprobante").Rows(0)("FormaPago").ToString()
            Dim wa_FormaDePago As tblFormaPago = DBModelo.GetFormaDePagoByKey(rep_FormadePago)
            rep_FormadePago = wa_FormaDePago.FormaPago

            rep_MetododePago = DS.Tables("Comprobante").Rows(0)("MetodoPago").ToString()
            Dim wa_MetodoDePago As tblMetodoPago = DBModelo.GetMetodoDePagoByKey(rep_MetododePago)
            rep_MetododePago = wa_MetodoDePago.MetodoPago

            rep_UsoCFDI = DS.Tables("Receptor").Rows(0)("UsoCFDI").ToString()
            Dim wa_UsoCFDI As tblUsoCFDI = DBModelo.GetUsoCFDIByKey(rep_UsoCFDI)
            rep_UsoCFDI = wa_UsoCFDI.UsoCFDI


            Dim wa_header As tblFacturaTotal = DBModelo.GetFacturaHeader(NumeroFactura)
            wa_header.UUID = DS.Tables("TimbreFiscalDigital").Rows(0)("UUID").ToString()
            If Not DBModelo.Update_PV_FacturaTotal(wa_header) Then
                MsgBox("Problemas al actualizar el UUID en la tabla FacturasTotal", MsgBoxStyle.Exclamation, "Actualización de UUID")
            End If
            Dim wa_cliente As tblClientes = DBModelo.GetCliente(wa_header.id_cliente)

            Dim lv_nombre As String = ""
            Dim lv_direccion As String = ""
            Dim lv_colonia As String = ""
            Dim lv_codigopostal As String = ""
            Dim lv_ciudad As String = ""
            Dim lv_rfc As String = ""


            If wa_cliente.nombre <> "" Or wa_cliente.apat <> "" Or wa_cliente.amat <> "" Then
                lv_nombre = wa_cliente.nombre & " " & wa_cliente.apat & " " & wa_cliente.amat
            End If

            If wa_cliente.calle <> "" Then
                lv_direccion = wa_cliente.calle
                If wa_cliente.numero <> "" Then
                    lv_direccion = lv_direccion & " #" & wa_cliente.numero
                End If
            Else
                lv_direccion = " "
            End If

            If wa_cliente.colonia <> "" Then
                lv_colonia = wa_cliente.colonia
            Else
                lv_colonia = " "
            End If

            If wa_cliente.cp <> "" Then
                lv_codigopostal = wa_cliente.cp
            Else
                lv_codigopostal = " "
            End If

            If wa_cliente.ciudad <> "" Then
                If wa_cliente.estado <> "" Then
                    lv_ciudad = wa_cliente.ciudad & ", " & wa_cliente.estado
                Else
                    lv_ciudad = wa_cliente.ciudad
                End If
            Else
                lv_ciudad = " "
            End If

            If wa_cliente.rfc <> "" Then
                lv_rfc = wa_cliente.rfc
            Else
                lv_rfc = " "
            End If

            rep_direccion = lv_direccion
            rep_cuidad = lv_ciudad
            rep_colonia = lv_colonia

            Dim lv_TipoDeComprobante As String = ""
            Select Case DS.Tables("Comprobante").Rows(0)("TipoDeComprobante").ToString()
                Case "I"
                    lv_TipoDeComprobante = "I-Ingreso"
                Case "E"
                    lv_TipoDeComprobante = "E-Egreso"
            End Select

            Dim p1 As New Microsoft.Reporting.WinForms.ReportParameter("RfcProvCertif", DS.Tables("TimbreFiscalDigital").Rows(0)("RfcProvCertif").ToString())
            Dim p2 As New Microsoft.Reporting.WinForms.ReportParameter("UUID", DS.Tables("TimbreFiscalDigital").Rows(0)("UUID").ToString())
            Dim p3 As New Microsoft.Reporting.WinForms.ReportParameter("TipoDeComprobante", lv_TipoDeComprobante)
            Dim p4 As New Microsoft.Reporting.WinForms.ReportParameter("NoCertificadoSAT", DS.Tables("TimbreFiscalDigital").Rows(0)("NoCertificadoSAT").ToString())
            Dim p5 As New Microsoft.Reporting.WinForms.ReportParameter("Image", "File:///" & gv_CDFI_XML_PATH_QR & rep_folio & ".png")
            Dim p6 As New Microsoft.Reporting.WinForms.ReportParameter("RFC", DS.Tables("Receptor").Rows(0)("RFC").ToString())
            Dim p7 As New Microsoft.Reporting.WinForms.ReportParameter("Serie", DS.Tables("Comprobante").Rows(0)("Serie").ToString())
            Dim p8 As New Microsoft.Reporting.WinForms.ReportParameter("FolioFactura", DS.Tables("Comprobante").Rows(0)("Folio").ToString())
            Dim p9 As New Microsoft.Reporting.WinForms.ReportParameter("Ciudad_RFC", rep_cuidad)
            Dim p10 As New Microsoft.Reporting.WinForms.ReportParameter("CP", DS.Tables("Comprobante").Rows(0)("LugarExpedicion").ToString())
            Dim p11 As New Microsoft.Reporting.WinForms.ReportParameter("Total", DS.Tables("Comprobante").Rows(0)("Total").ToString())
            Dim p12 As New Microsoft.Reporting.WinForms.ReportParameter("Direccion", rep_direccion)
            Dim p13 As New Microsoft.Reporting.WinForms.ReportParameter("FolioFiscal", DS.Tables("TimbreFiscalDigital").Rows(0)("UUID").ToString())
            Dim p14 As New Microsoft.Reporting.WinForms.ReportParameter("FechadeEmision", DS.Tables("Comprobante").Rows(0)("Fecha").ToString())
            Dim p15 As New Microsoft.Reporting.WinForms.ReportParameter("FechaTimbrado", DS.Tables("TimbreFiscalDigital").Rows(0)("FechaTimbrado").ToString())
            Dim p16 As New Microsoft.Reporting.WinForms.ReportParameter("SelloSAT", DS.Tables("TimbreFiscalDigital").Rows(0)("SelloSAT").ToString())
            Dim p17 As New Microsoft.Reporting.WinForms.ReportParameter("SelloCFD", DS.Tables("TimbreFiscalDigital").Rows(0)("SelloCFD").ToString())
            Dim p18 As New Microsoft.Reporting.WinForms.ReportParameter("Version", DS.Tables("TimbreFiscalDigital").Rows(0)("Version").ToString())
            Dim p19 As New Microsoft.Reporting.WinForms.ReportParameter("SubTotal", DS.Tables("Comprobante").Rows(0)("SubTotal").ToString())
            Dim p20 As New Microsoft.Reporting.WinForms.ReportParameter("UsodeCFDI", rep_UsoCFDI)
            Dim p21 As New Microsoft.Reporting.WinForms.ReportParameter("Nombre", DS.Tables("Receptor").Rows(0)("Nombre").ToString())
            Dim p22 As New Microsoft.Reporting.WinForms.ReportParameter("FormadePago", rep_FormadePago)
            Dim p23 As New Microsoft.Reporting.WinForms.ReportParameter("MetododePago", rep_MetododePago)
            Dim p24 As New Microsoft.Reporting.WinForms.ReportParameter("Colonia", rep_colonia)
            Dim p25 As New Microsoft.Reporting.WinForms.ReportParameter("CPReceptor", DS.Tables("Receptor").Rows(0)("Rfc").ToString())
            Dim p26 As New Microsoft.Reporting.WinForms.ReportParameter("IVA", lv_iva_total.ToString)

            Report.ReportPath = gv_Report_Path & "Report6.rdlc"
            Report.EnableExternalImages = True

            Report.SetParameters(p1)
            Report.SetParameters(p2)
            Report.SetParameters(p3)
            Report.SetParameters(p4)
            Report.SetParameters(p5)
            Report.SetParameters(p6)
            Report.SetParameters(p7)
            Report.SetParameters(p8)
            Report.SetParameters(p9)
            Report.SetParameters(p10)
            Report.SetParameters(p11)
            Report.SetParameters(p12)
            Report.SetParameters(p13)
            Report.SetParameters(p14)
            Report.SetParameters(p15)
            Report.SetParameters(p16)
            Report.SetParameters(p17)
            Report.SetParameters(p18)
            Report.SetParameters(p19)
            Report.SetParameters(p20)
            Report.SetParameters(p21)
            Report.SetParameters(p22)
            Report.SetParameters(p23)
            Report.SetParameters(p24)
            Report.SetParameters(p25)
            Report.SetParameters(p26)

            Report.DataSources.Clear()
            Report.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt_detail))
            fsReadXml.Close()

            ' Creación del PDF en base al Reporte previamente llenado
            Dim pdfContent As Byte() = Report.Render("PDF", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            Dim pdfPath As String = gv_CDFI_XML_PATH & rep_folio & ".pdf"
            Dim pdfFile As New System.IO.FileStream(pdfPath, System.IO.FileMode.Create)
            pdfFile.Write(pdfContent, 0, pdfContent.Length)
            pdfFile.Close()

            ' Creación del ZIP en base al XML y PDF generado anteriormente
            Dim zipPath As String = gv_CDFI_XML_PATH & rep_folio & ".zip" '"C:\TEMP\Compression\myzip.zip"
            If File.Exists(zipPath) Then
                File.Delete(zipPath)
            End If
            Dim zip As Package = ZipPackage.Open(zipPath, IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite)
            AddToArchive(zip, gv_CDFI_XML_PATH & FolioFactura & ".xml") '"C:\TEMP\Compression\Compress Me1.txt")
            AddToArchive(zip, gv_CDFI_XML_PATH & FolioFactura & ".pdf") '"C:\TEMP\Compression\Compress Me2.txt")
            zip.Close() 'Close the zip file

            If wa_cliente.correo <> "" Then

                'Envio de Archivo ZIP via Correo Electrónico
                Dim oSmtp As New SmtpClient()

                Dim oMail As New MailMessage()

                oSmtp.UseDefaultCredentials = False
                oSmtp.Credentials = New Net.NetworkCredential(gv_smtp_correo, gv_smtp_pass)
                oSmtp.Port = 587
                oSmtp.EnableSsl = True
                oSmtp.Host = "smtp.live.com"

                oMail = New MailMessage()

                ' Set sender email address, please change it to yours
                oMail.From = New MailAddress(gv_smtp_correo)

                ' Set recipient email address, please change it to yours
                oMail.To.Add("cat_to_all@hotmail.com")
                'oMail.CC.Add(gv_smtp_correo)

                ' Set email subject
                oMail.Subject = "Factura Electrónica Material Eléctrico Progreso"

                oMail.IsBodyHtml = True

                ' Set email body
                oMail.Body = ""
                oMail.Body = oMail.Body & "Estimado Cliente " & "J. Jesus Martinez Fuentes" & vbCrLf & vbCrLf
                oMail.Body = oMail.Body & "Por medio del presente Correo Electrónico, le hago la notificación y envío del comprobante fiscal" & vbCrLf
                oMail.Body = oMail.Body & "emitido por nuestra empresa Material Eléctrico Progreso." & vbCrLf
                oMail.Body = oMail.Body & "Anexo archivo ZIP que contiene un archivo XML y un archivo PDF." & vbCrLf & vbCrLf
                oMail.Body = oMail.Body & "Cualquier aclaración, favor de contactarnos. Lo puede hacer respondiendo a este correo." & vbCrLf & vbCrLf
                oMail.Body = oMail.Body & "ATTE:" & vbCrLf
                oMail.Body = oMail.Body & "Salvador Bautista Fuentes" & vbCrLf
                oMail.Body = oMail.Body & "Empresario" & vbCrLf

                Dim ct As Net.Mime.ContentType = New Net.Mime.ContentType("application/zip")
                Dim attachItem As Attachment = New Attachment(gv_CDFI_XML_PATH & FolioFactura & ".zip", ct)

                oMail.Attachments.Add(attachItem)

                Try
                    FrmCancelarPedido.Cursor = Cursors.WaitCursor
                    oSmtp.Send(oMail)
                    oSmtp.Dispose()
                    oMail.Dispose()
                    FrmCancelarPedido.Cursor = Cursors.Default
                    MsgBox("Correo Electrónico enviado correctamente!", vbInformation, "Envío de Correo Electrónico")
                Catch ep As Exception
                    FrmCancelarPedido.Cursor = Cursors.Default
                    oSmtp.Dispose()
                    oMail.Dispose()
                    MsgBox(ep.Message, vbCritical, "Error al enviar correo electrónico.")
                    Return False
                End Try
            End If

            If MsgBox("¿Requiere Factura Impresa?", vbYesNo, "Impresión de Factura") = vbYes Then
                Print_Report2(InvocePrinterName, Report, 1, "Image", FolioFactura, gv_CDFI_XML_PATH)
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ImprimeFactura Genera Reporte Local")
            Return False
        End Try
    End Function

    Public Sub Print_Report2(i_printer_name As String, i_report_object As LocalReport, i_copies As Integer, i_type As String, i_filename As String, i_foldername As String)
        If i_type = "Pdf" Then
            PDFFileName = i_filename
            PDFFolderName = i_foldername
            Export2(i_report_object, i_type)
            If Not (m_streams Is Nothing) Then
                Dim stream As Stream
                For Each stream In m_streams
                    stream.Close()
                Next
                m_streams = Nothing
            End If
        Else
            PDFFileName = i_filename
            PDFFolderName = i_foldername
            Export2(i_report_object, i_type)

            m_currentPageIndex = 0
            Print(i_printer_name, i_copies)
            If Not (m_streams Is Nothing) Then
                Dim stream As Stream
                For Each stream In m_streams
                    stream.Close()
                Next
                m_streams = Nothing
                If DeleteFileNameEMF <> "" Then
                    For i = 1 To PageCount - 1
                        System.IO.File.Delete(DeleteFileNameEMF + "_" + i.ToString + ".EMF")
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub AddToArchive(ByVal zip As Package,
                     ByVal fileToAdd As String)

        'Replace spaces with an underscore (_)
        Dim uriFileName As String = fileToAdd.Replace(" ", "_")

        'A Uri always starts with a forward slash "/"
        Dim zipUri As String = String.Concat("/",
               IO.Path.GetFileName(uriFileName))

        Dim partUri As New Uri(zipUri, UriKind.Relative)
        Dim contentType As String =
               Net.Mime.MediaTypeNames.Application.Zip

        'The PackagePart contains the information:
        ' Where to extract the file when it's extracted (partUri)
        ' The type of content stream (MIME type):  (contentType)
        ' The type of compression:  (CompressionOption.Normal)
        Dim pkgPart As PackagePart = zip.CreatePart(partUri,
               contentType, CompressionOption.Normal)

        'Read all of the bytes from the file to add to the zip file
        Dim bites As Byte() = File.ReadAllBytes(fileToAdd)

        'Compress and write the bytes to the zip file
        pkgPart.GetStream().Write(bites, 0, bites.Length)

    End Sub

    'Public Function ImprimeFactura(ByVal NumeroFactura As String, ByVal Imprimir As Boolean, ByVal DB As String) As Boolean
    '    Dim dt_header As DataTable = New DataTable
    '    Dim dt_detail As DataTable = New DataTable
    '    Dim dt_factura As DataTable = New DataTable
    '    Dim dt_cliente As DataTable = New DataTable
    '    Dim sql_header As String = "Select * from factura_total where n_factura = " & NumeroFactura
    '    Dim sql_detail As String = "select * from facturas where n_factura = " & NumeroFactura
    '    Dim sql_factura As String = "select * from foliosfacturas where foliofinal >= " & NumeroFactura & " and Activo <> 'X'"

    '    Try

    '        Select Case DB
    '            Case "Wendy"
    '                SqlDataAdapter = New SqlDataAdapter(sql_header, gv_ConStringWendy)
    '            Case "Librada"
    '                SqlDataAdapter = New SqlDataAdapter(sql_header, gv_ConStringLibrada)
    '            Case "Salvador"
    '                SqlDataAdapter = New SqlDataAdapter(sql_header, gv_ConStringSalvador)
    '        End Select


    '        Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)

    '        ' llenar el DataTable   
    '        dt_header.Clear()
    '        dt_header.Dispose()
    '        dt_header.Reset()
    '        dt_header = New DataTable
    '        SqlDataAdapter.Fill(dt_header)

    '    Catch exSql As SqlException
    '        Return False
    '    Catch ex As Exception
    '        Return False
    '    End Try

    '    Try
    '        Select Case DB
    '            Case "Wendy"
    '                SqlDataAdapter = New SqlDataAdapter(sql_detail, gv_ConStringWendy)
    '            Case "Librada"
    '                SqlDataAdapter = New SqlDataAdapter(sql_detail, gv_ConStringLibrada)
    '            Case "Salvador"
    '                SqlDataAdapter = New SqlDataAdapter(sql_detail, gv_ConStringSalvador)
    '        End Select

    '        Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)

    '        ' llenar el DataTable   
    '        dt_detail.Clear()
    '        dt_detail.Dispose()
    '        dt_detail.Reset()
    '        dt_detail = New DataTable
    '        SqlDataAdapter.Fill(dt_detail)

    '    Catch exSql As SqlException
    '        Return False
    '    Catch ex As Exception
    '        Return False
    '    End Try

    '    Try
    '        Select Case DB
    '            Case "Wendy"
    '                SqlDataAdapter = New SqlDataAdapter(sql_factura, gv_ConStringWendy)
    '            Case "Librada"
    '                SqlDataAdapter = New SqlDataAdapter(sql_factura, gv_ConStringLibrada)
    '            Case "Salvador"
    '                SqlDataAdapter = New SqlDataAdapter(sql_factura, gv_ConStringSalvador)
    '        End Select

    '        Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)

    '        ' llenar el DataTable   
    '        dt_factura.Clear()
    '        dt_factura.Dispose()
    '        dt_factura.Reset()
    '        dt_factura = New DataTable
    '        SqlDataAdapter.Fill(dt_factura)

    '    Catch exSql As SqlException
    '        MsgBox(exSql.Message, MsgBoxStyle.Critical, "ImprimeFactura dt_detail")
    '        Return False
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "ImprimeFactura dt_detail")
    '        Return False
    '    End Try

    '    Try
    '        Dim sql_cliente As String = "select * from clientes where clave = '" & dt_header.Rows(0)!id_cliente & "'"

    '        Select Case DB
    '            Case "Wendy"
    '                SqlDataAdapter = New SqlDataAdapter(sql_cliente, gv_ConStringWendy)
    '            Case "Librada"
    '                SqlDataAdapter = New SqlDataAdapter(sql_cliente, gv_ConStringLibrada)
    '            Case "Salvador"
    '                SqlDataAdapter = New SqlDataAdapter(sql_cliente, gv_ConStringSalvador)
    '        End Select

    '        Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)

    '        ' llenar el DataTable   
    '        dt_cliente.Clear()
    '        dt_cliente.Dispose()
    '        dt_cliente.Reset()
    '        dt_cliente = New DataTable
    '        SqlDataAdapter.Fill(dt_cliente)

    '    Catch exSql As SqlException
    '        Return False
    '    Catch ex As Exception
    '        Return False
    '    End Try
    '    Dim lv_nombre As String = ""
    '    Dim lv_direccion As String = ""
    '    Dim lv_colonia As String = ""
    '    Dim lv_codigopostal As String = ""
    '    Dim lv_ciudad As String = ""
    '    Dim lv_rfc As String = ""


    '    If dt_cliente.Rows.Count > 0 Then
    '        If dt_cliente.Rows(0)!nombre <> "" Or dt_cliente.Rows(0)!apat <> "" Or dt_cliente.Rows(0)!amat <> "" Then
    '            lv_nombre = dt_cliente.Rows(0)!nombre & " " & dt_cliente.Rows(0)!apat & " " & dt_cliente.Rows(0)!amat
    '        End If
    '        If dt_cliente.Rows(0)!calle <> "" Then
    '            lv_direccion = dt_cliente.Rows(0)!calle
    '            If dt_cliente.Rows(0)!numero <> "" Then
    '                lv_direccion = lv_direccion & " #" & dt_cliente.Rows(0)!numero
    '            End If
    '        Else
    '            lv_direccion = " "
    '        End If
    '        If dt_cliente.Rows(0)!colonia <> "" Then
    '            lv_colonia = dt_cliente.Rows(0)!colonia
    '        Else
    '            lv_colonia = " "
    '        End If
    '        If dt_cliente.Rows(0)!cp <> "" Then
    '            lv_codigopostal = dt_cliente.Rows(0)!cp
    '        Else
    '            lv_codigopostal = " "
    '        End If
    '        If dt_cliente.Rows(0)!ciudad <> "" Then
    '            If dt_cliente.Rows(0)!estado <> "" Then
    '                lv_ciudad = dt_cliente.Rows(0)!ciudad & ", " & dt_cliente.Rows(0)!estado
    '            Else
    '                lv_ciudad = dt_cliente.Rows(0)!ciudad
    '            End If
    '        Else
    '            lv_ciudad = " "
    '        End If
    '        If dt_cliente.Rows(0)!rfc <> "" Then
    '            lv_rfc = dt_cliente.Rows(0)!rfc
    '        Else
    '            lv_rfc = " "
    '        End If
    '    End If

    '    Dim Report As New LocalReport

    '    Try
    '        'If dt_header.Rows(0)!tipo_venta = "CONTADO" Then
    '        dt_detail.TableName = "facturas"
    '        Dim lv_factura As String = NumeroFactura
    '        Dim p1 As New Microsoft.Reporting.WinForms.ReportParameter("FolioFactura", lv_factura)

    '        Dim lv_fecha As String = Format(dt_header.Rows(0)!fecha_venta, "dd/MMM/yyyy")
    '        Dim p2 As New Microsoft.Reporting.WinForms.ReportParameter("FechaFactura", lv_fecha.ToUpper())
    '        Dim p3 As New Microsoft.Reporting.WinForms.ReportParameter("Nombre", lv_nombre.ToUpper())
    '        Dim p4 As New Microsoft.Reporting.WinForms.ReportParameter("Direccion", lv_direccion.ToUpper())
    '        Dim p5 As New Microsoft.Reporting.WinForms.ReportParameter("Ciudad_RFC", lv_ciudad.ToUpper())
    '        Dim p6 As New Microsoft.Reporting.WinForms.ReportParameter("RFC", lv_rfc.ToUpper())
    '        Dim p7 As New Microsoft.Reporting.WinForms.ReportParameter("Colonia", lv_colonia.ToUpper())
    '        Dim p8 As New Microsoft.Reporting.WinForms.ReportParameter("CP", lv_codigopostal.ToUpper())

    '        Dim lv_subtotal As String = dt_header.Rows(0)!total
    '        Dim p10 As New Microsoft.Reporting.WinForms.ReportParameter("SubTotal_1", lv_subtotal.ToUpper)

    '        Dim lv_iva As String = dt_header.Rows(0)!total * (FactorIVA - 1)
    '        Dim p11 As New Microsoft.Reporting.WinForms.ReportParameter("IVA", lv_iva.ToUpper)

    '        Dim lv_total As String = Val(lv_subtotal) + Val(lv_iva)
    '        Dim p12 As New Microsoft.Reporting.WinForms.ReportParameter("Total", lv_total.ToUpper)

    '        'dinero a letra'
    '        Dim lv_dinero As String = Dinero(lv_total, 2, "Pesos", True)
    '        Dim p9 As New Microsoft.Reporting.WinForms.ReportParameter("ImporteLetra", lv_dinero.ToUpper)

    '        Dim p13 As New Microsoft.Reporting.WinForms.ReportParameter("OrgCopiaFactura", "O R I G I N A L")

    '        Dim p19 As New Microsoft.Reporting.WinForms.ReportParameter("IdAprobacion", dt_factura.Rows(0)!IdAprobacion.ToString)
    '        Dim p15 As New Microsoft.Reporting.WinForms.ReportParameter("FolioInicial", dt_factura.Rows(0)!FolioInicial.ToString)
    '        Dim p16 As New Microsoft.Reporting.WinForms.ReportParameter("FolioFinal", dt_factura.Rows(0)!FolioFinal.ToString)
    '        Dim p17 As New Microsoft.Reporting.WinForms.ReportParameter("FechaInicial", Format(dt_factura.Rows(0)!FechaInicial, "dd/MM/yyyy"))
    '        Dim p18 As New Microsoft.Reporting.WinForms.ReportParameter("FechaFinal", Format(dt_factura.Rows(0)!FechaFinal, "dd/MM/yyyy"))

    '        Dim img As Byte() = dt_factura.Rows(0)!Imagen
    '        Dim ms As New System.IO.MemoryStream(img)
    '        Dim dir As New IO.DirectoryInfo("C:\Hologramas\")
    '        If dir.Exists = False Then
    '            System.IO.Directory.CreateDirectory("C:\Hologramas\")
    '        End If

    '        File.WriteAllBytes("C:\Hologramas\output.jpg", img)

    '        Dim p20 As New Microsoft.Reporting.WinForms.ReportParameter("Image", "File:///C:/Hologramas/output.jpg")

    '        Report.ReportPath = gv_Report_Path & "Report6.rdlc"
    '        Report.EnableExternalImages = True
    '        Report.SetParameters(p1)
    '        Report.SetParameters(p2)
    '        Report.SetParameters(p3)
    '        Report.SetParameters(p4)
    '        Report.SetParameters(p5)
    '        Report.SetParameters(p6)
    '        Report.SetParameters(p7)
    '        Report.SetParameters(p8)
    '        Report.SetParameters(p9)
    '        Report.SetParameters(p10)
    '        Report.SetParameters(p11)
    '        Report.SetParameters(p12)
    '        Report.SetParameters(p13)
    '        Report.SetParameters(p19)
    '        Report.SetParameters(p15)
    '        Report.SetParameters(p16)
    '        Report.SetParameters(p17)
    '        Report.SetParameters(p18)
    '        Report.SetParameters(p20)
    '        Report.DataSources.Clear()
    '        Report.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt_detail))

    '        Print_Report(InvocePrinterName, Report, 1, "Pdf", lv_factura + " (" + Trim(lv_nombre) + ") ORIGINAL", "C:\Facturas\" + Now.Year.ToString, "FACTURA")
    '        If Imprimir = True Then
    '            Print_Report(InvocePrinterName, Report, 1, "Image", lv_factura + " (" + Trim(lv_nombre) + ") ORIGINAL", "C:\Facturas\" + Now.Year.ToString, "FACTURA")
    '        End If

    '        Dim p14 As New Microsoft.Reporting.WinForms.ReportParameter("OrgCopiaFactura", "C O P I A")
    '        Report.SetParameters(p14)
    '        Print_Report(InvocePrinterName, Report, 1, "Pdf", lv_factura + " (" + Trim(lv_nombre) + ") COPIA", "C:\Facturas\" + Now.Year.ToString, "FACTURA")
    '        If Imprimir = True Then
    '            Print_Report(InvocePrinterName, Report, 1, "Image", lv_factura + " (" + Trim(lv_nombre) + ") COPIA", "C:\Facturas\" + Now.Year.ToString, "FACTURA")
    '        End If

    '        If dt_cliente.Rows(0)!correo <> "" Then
    '            If MsgBox("¿Enviar Factura por Correo Electrónico?", MsgBoxStyle.YesNo, "Correo Electrónico") = MsgBoxResult.Yes Then
    '                'If EnviarEmail("materialelectrico@hotmail.es", dt_cliente.Rows(0)!correo, "Factura", "Este correo es generado automáticamente por " + Nombre, "C:\Facturas\" + Now.Year.ToString + "\" + lv_factura + " (" + Trim(lv_nombre) + ") ORIGINAL_1.Pdf", "19720416") = True Then
    '                '    MsgBox("Correo Electrónico enviado correctamente.", MsgBoxStyle.Information, "Correo Electrónico")
    '                'Else
    '                '    MsgBox("Correo Electrónico no pudo ser enviado.", MsgBoxStyle.Critical, "Correo Electrónico")
    '                'End If
    '            End If
    '        End If

    '        'End If
    '        Return True
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return False
    '    End Try
    'End Function

    'Public Function ImprimeFactura_CFDI(ByVal NumeroFactura As Integer, ByVal DB As String) As Boolean
    '    Dim dt_header As DataTable = New DataTable
    '    Dim dt_detail As DataTable = New DataTable
    '    Dim dt_factura As DataTable = New DataTable
    '    Dim dt_cliente As DataTable = New DataTable
    '    Dim dt_productos As DataTable = New DataTable
    '    Dim sql_header As String = "Select * from factura_total where n_factura = " & NumeroFactura
    '    Dim sql_detail As String = "select * from facturas where n_factura = " & NumeroFactura
    '    Dim sql_factura As String = "select * from foliosfacturas where tipocomprobante = 'FACTURAS' and year = " & CInt(Now.Date.Year)

    '    Dim lv_documento_01 As String = ""
    '    Dim lv_cliente_02_bill_to As String = ""
    '    Dim lv_cliente_02_ship_to As String = ""
    '    Dim lv_concepto_04 As String = ""
    '    Dim lv_iva_10 As String = ""
    '    Try
    '        Select Case DB
    '            Case "Wendy"
    '                SqlDataAdapter = New SqlDataAdapter(sql_header, gv_ConStringWendy)
    '            Case "Librada"
    '                SqlDataAdapter = New SqlDataAdapter(sql_header, gv_ConStringLibrada)
    '            Case "Salvador"
    '                SqlDataAdapter = New SqlDataAdapter(sql_header, gv_ConStringSalvador)
    '        End Select

    '        Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)

    '        ' llenar el DataTable   
    '        dt_header.Clear()
    '        dt_header.Dispose()
    '        dt_header.Reset()
    '        dt_header = New DataTable
    '        SqlDataAdapter.Fill(dt_header)

    '    Catch exSql As SqlException
    '        MsgBox(exSql.Message, MsgBoxStyle.Critical, "ImprimeFactura dt_header")
    '        Return False
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "ImprimeFactura dt_header")
    '        Return False
    '    End Try

    '    Try
    '        Select Case DB
    '            Case "Wendy"
    '                SqlDataAdapter = New SqlDataAdapter(sql_detail, gv_ConStringWendy)
    '            Case "Librada"
    '                SqlDataAdapter = New SqlDataAdapter(sql_detail, gv_ConStringLibrada)
    '            Case "Salvador"
    '                SqlDataAdapter = New SqlDataAdapter(sql_detail, gv_ConStringSalvador)
    '        End Select

    '        Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)

    '        ' llenar el DataTable   
    '        dt_detail.Clear()
    '        dt_detail.Dispose()
    '        dt_detail.Reset()
    '        dt_detail = New DataTable
    '        SqlDataAdapter.Fill(dt_detail)

    '    Catch exSql As SqlException
    '        MsgBox(exSql.Message, MsgBoxStyle.Critical, "ImprimeFactura dt_detail")
    '        Return False
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "ImprimeFactura dt_detail")
    '        Return False
    '    End Try

    '    Try
    '        Select Case DB
    '            Case "Wendy"
    '                SqlDataAdapter = New SqlDataAdapter(sql_factura, gv_ConStringWendy)
    '            Case "Librada"
    '                SqlDataAdapter = New SqlDataAdapter(sql_factura, gv_ConStringLibrada)
    '            Case "Salvador"
    '                SqlDataAdapter = New SqlDataAdapter(sql_factura, gv_ConStringSalvador)
    '        End Select

    '        Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)

    '        ' llenar el DataTable   
    '        dt_factura.Clear()
    '        dt_factura.Dispose()
    '        dt_factura.Reset()
    '        dt_factura = New DataTable
    '        SqlDataAdapter.Fill(dt_factura)

    '    Catch exSql As SqlException
    '        MsgBox(exSql.Message, MsgBoxStyle.Critical, "ImprimeFactura dt_detail")
    '        Return False
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "ImprimeFactura dt_detail")
    '        Return False
    '    End Try

    '    Try
    '        Dim sql_cliente As String = "select * from clientes where clave = '" & dt_header.Rows(0)!id_cliente & "'"

    '        Select Case DB
    '            Case "Wendy"
    '                SqlDataAdapter = New SqlDataAdapter(sql_cliente, gv_ConStringWendy)
    '            Case "Librada"
    '                SqlDataAdapter = New SqlDataAdapter(sql_cliente, gv_ConStringLibrada)
    '            Case "Salvador"
    '                SqlDataAdapter = New SqlDataAdapter(sql_cliente, gv_ConStringSalvador)
    '        End Select

    '        Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)

    '        ' llenar el DataTable   
    '        dt_cliente.Clear()
    '        dt_cliente.Dispose()
    '        dt_cliente.Reset()
    '        dt_cliente = New DataTable
    '        SqlDataAdapter.Fill(dt_cliente)

    '    Catch exSql As SqlException
    '        MsgBox(exSql.Message, MsgBoxStyle.Critical, "ImprimeFactura dt_cliente")
    '        Return False
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "ImprimeFactura dt_detail")
    '        Return False
    '    End Try

    '    Dim lv_nombre As String = ""
    '    Dim lv_direccion As String = ""
    '    Dim lv_colonia As String = ""
    '    Dim lv_codigopostal As String = ""
    '    Dim lv_ciudad As String = ""
    '    Dim lv_rfc As String = ""

    '    Try
    '        If dt_cliente.Rows.Count > 0 Then
    '            If dt_cliente.Rows(0)!nombre <> "" Or dt_cliente.Rows(0)!apat <> "" Or dt_cliente.Rows(0)!amat <> "" Then
    '                lv_nombre = dt_cliente.Rows(0)!nombre & " " & dt_cliente.Rows(0)!apat & " " & dt_cliente.Rows(0)!amat
    '            End If
    '            If dt_cliente.Rows(0)!calle <> "" Then
    '                lv_direccion = dt_cliente.Rows(0)!calle
    '                If dt_cliente.Rows(0)!numero <> "" Then
    '                    lv_direccion = lv_direccion & " #" & dt_cliente.Rows(0)!numero
    '                End If
    '            Else
    '                lv_direccion = " "
    '            End If
    '            If dt_cliente.Rows(0)!colonia <> "" Then
    '                lv_colonia = dt_cliente.Rows(0)!colonia
    '            Else
    '                lv_colonia = " "
    '            End If
    '            If dt_cliente.Rows(0)!cp <> "" Then
    '                lv_codigopostal = dt_cliente.Rows(0)!cp
    '            Else
    '                lv_codigopostal = " "
    '            End If
    '            If dt_cliente.Rows(0)!ciudad <> "" Then
    '                If dt_cliente.Rows(0)!estado <> "" Then
    '                    lv_ciudad = dt_cliente.Rows(0)!ciudad & ", " & dt_cliente.Rows(0)!estado
    '                Else
    '                    lv_ciudad = dt_cliente.Rows(0)!ciudad
    '                End If
    '            Else
    '                lv_ciudad = " "
    '            End If
    '            If dt_cliente.Rows(0)!rfc <> "" Then
    '                lv_rfc = dt_cliente.Rows(0)!rfc
    '            Else
    '                lv_rfc = " "
    '            End If
    '            lv_cliente_02_bill_to = "<BILL_TO_CUSTOMER SEND_XML=""TRUE"" SEND_PDF=""TRUE"">" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<PARTY>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<PARTY_ID>" & dt_cliente.Rows(0)!clave & "</PARTY_ID>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<PARTY_NAME><![CDATA[" & lv_nombre & "]]></PARTY_NAME>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<PARTY_TYPE>" & "CUSTOMER" & "</PARTY_TYPE>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<JGZZ_FISCAL_CODE><![CDATA[" & lv_rfc & "]]></JGZZ_FISCAL_CODE>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<ADDRESS1><![CDATA[" & dt_cliente.Rows(0)!calle & "]]></ADDRESS1>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<ADDRESS2><![CDATA[" & dt_cliente.Rows(0)!numero & "]]></ADDRESS2>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<ADDRESS3>" & "" & "</ADDRESS3>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<ADDRESS4><![CDATA[" & lv_colonia & "]]></ADDRESS4>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<POSTAL_CODE>" & lv_codigopostal & "</POSTAL_CODE>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<CITY><![CDATA[" & lv_ciudad & "]]></CITY>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<STATE><![CDATA[" & dt_cliente.Rows(0)!estado & "]]></STATE>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<COUNTRY><![CDATA[" & "México" & "]]></COUNTRY>" & vbCrLf

    '            Select Case dt_header.Rows(0)!metodopago
    '                Case "EFECTIVO"
    '                    lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<METODO_PAGO>" & "1" & "</METODO_PAGO>" & vbCrLf
    '                Case "CHEQUE"
    '                    lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<METODO_PAGO>" & "2" & "</METODO_PAGO>" & vbCrLf
    '                Case "TRANSFERENCIA"
    '                    lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<METODO_PAGO>" & "3" & "</METODO_PAGO>" & vbCrLf
    '            End Select

    '            Select Case dt_header.Rows(0)!tipo_venta
    '                Case "CONTADO"
    '                    lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<COND_PAGO>" & "1" & "</COND_PAGO>" & vbCrLf
    '                Case "CREDITO"
    '                    lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<COND_PAGO>" & "2" & "</COND_PAGO>" & vbCrLf
    '            End Select

    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<DIAS_PAGO>" & "0" & "</DIAS_PAGO>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<LOCALIDAD>" & "0" & "</LOCALIDAD>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<REFERENCIA>" & "0" & "</REFERENCIA>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<EMAIL>" & dt_cliente.Rows(0)!correo & "</EMAIL>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<CODIGO_CLIENTE>" & dt_cliente.Rows(0)!clave & "</CODIGO_CLIENTE>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "</PARTY>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "</BILL_TO_CUSTOMER>"

    '            lv_cliente_02_ship_to = "<SHIP_TO_CUSTOMER>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<PARTY>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<PARTY_ID>" & dt_cliente.Rows(0)!clave & "</PARTY_ID>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<PARTY_NAME><![CDATA[" & lv_nombre & "]]></PARTY_NAME>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<PARTY_TYPE>" & "CUSTOMER" & "</PARTY_TYPE>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<JGZZ_FISCAL_CODE><![CDATA[" & lv_rfc & "]]></JGZZ_FISCAL_CODE>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<ADDRESS1><![CDATA[" & dt_cliente.Rows(0)!calle & "]]></ADDRESS1>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<ADDRESS2><![CDATA[" & dt_cliente.Rows(0)!numero & "]]></ADDRESS2>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<ADDRESS3>" & "" & "</ADDRESS3>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<ADDRESS4><![CDATA[" & lv_colonia & "]]></ADDRESS4>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<POSTAL_CODE>" & lv_codigopostal & "</POSTAL_CODE>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<CITY><![CDATA[" & lv_ciudad & "]]></CITY>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<STATE><![CDATA[" & dt_cliente.Rows(0)!estado & "]]></STATE>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<COUNTRY><![CDATA[" & "México" & "]]></COUNTRY>" & vbCrLf

    '            Select Case dt_header.Rows(0)!metodopago
    '                Case "EFECTIVO"
    '                    lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<METODO_PAGO>" & "1" & "</METODO_PAGO>" & vbCrLf
    '                Case "CHEQUE"
    '                    lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<METODO_PAGO>" & "2" & "</METODO_PAGO>" & vbCrLf
    '                Case "TRANSFERENCIA"
    '                    lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<METODO_PAGO>" & "3" & "</METODO_PAGO>" & vbCrLf
    '            End Select

    '            Select Case dt_header.Rows(0)!tipo_venta
    '                Case "CONTADO"
    '                    lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<COND_PAGO>" & "1" & "</COND_PAGO>" & vbCrLf
    '                Case "CREDITO"
    '                    lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<COND_PAGO>" & "2" & "</COND_PAGO>" & vbCrLf
    '            End Select

    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<DIAS_PAGO>" & "0" & "</DIAS_PAGO>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<CODIGO_CLIENTE>" & dt_cliente.Rows(0)!clave & "</CODIGO_CLIENTE>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "</PARTY>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "</SHIP_TO_CUSTOMER>"
    '        End If
    '    Catch exSql As SqlException
    '        MsgBox(exSql.Message, MsgBoxStyle.Critical, "ImprimeFactura Datos Cliente")
    '        Return False
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "ImprimeFactura Datos Cliente")
    '        Return False

    '    End Try

    '    Try
    '        Dim lv_factura As String = NumeroFactura
    '        Dim lv_fecha As String = Format(dt_header.Rows(0)!fecha_venta, "MM/dd/yyyy")
    '        Dim lv_time As String = Format(Now.TimeOfDay.Hours, "00") & ":" & Format(Now.TimeOfDay.Minutes, "00") & ":" & Format(Now.TimeOfDay.Seconds, "00")
    '        Dim lv_full_date As String = lv_fecha & " " & lv_time

    '        Dim lv_subtotal As String = dt_header.Rows(0)!total

    '        Dim lv_iva As String = dt_header.Rows(0)!total * (FactorIVA - 1)

    '        Dim lv_total As String = Val(lv_subtotal) + Val(lv_iva)

    '        lv_documento_01 = "<?xml version='1.0'  encoding='UTF-8' ?>" & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "<TRANSACTIONS>" & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "<TRANSACTION>" & vbCrLf
    '        Select Case DB
    '            Case "Wendy"
    '                lv_documento_01 = lv_documento_01 & "<SERIE>" & "XXX" & "</SERIE>" & vbCrLf
    '            Case "Librada"
    '                lv_documento_01 = lv_documento_01 & "<SERIE>" & gv_SerieFacturaLibrada & "</SERIE>" & vbCrLf
    '            Case "Salvador"
    '                lv_documento_01 = lv_documento_01 & "<SERIE>" & gv_SerieFacturaSalvador & "</SERIE>" & vbCrLf
    '        End Select
    '        lv_documento_01 = lv_documento_01 & "<TRX_NUMBER>" & NumeroFactura & "</TRX_NUMBER>" & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "<CUST_TRX_TYPE_ID>" & "1" & "</CUST_TRX_TYPE_ID>" & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "<TRX_DATE>" & lv_full_date & "</TRX_DATE>" & vbCrLf
    '        lv_documento_01 = lv_documento_01 & lv_cliente_02_bill_to & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "<TIPO_MONEDA>" & "MXN" & "</TIPO_MONEDA>" & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "<TASA_DE_CAMBIO>" & "1" & "</TASA_DE_CAMBIO>" & vbCrLf
    '        Select Case DB
    '            Case "Librada"
    '                lv_documento_01 = lv_documento_01 & "<SELLER_ID>" & "1120" & "</SELLER_ID>" & vbCrLf
    '            Case "Salvador"
    '                lv_documento_01 = lv_documento_01 & "<SELLER_ID>" & "631" & "</SELLER_ID>" & vbCrLf
    '        End Select
    '        lv_documento_01 = lv_documento_01 & "<BUYER_ID>" & dt_cliente.Rows(0)!clave & "</BUYER_ID>" & vbCrLf
    '        Select Case DB
    '            Case "Librada"
    '                lv_documento_01 = lv_documento_01 & "<SHIP_FROM>" & "1121" & "</SHIP_FROM>" & vbCrLf
    '            Case "Salvador"
    '                lv_documento_01 = lv_documento_01 & "<SHIP_FROM>" & "632" & "</SHIP_FROM>" & vbCrLf
    '        End Select
    '        lv_documento_01 = lv_documento_01 & "<SHIP_TO>" & dt_cliente.Rows(0)!clave & "</SHIP_TO>" & vbCrLf
    '        Select Case dt_header.Rows(0)!metodopago
    '            Case "EFECTIVO"
    '                lv_documento_01 = lv_documento_01 & "<ACCOUNT_NUMBER>" & "NO IDENTIFICADO" & "</ACCOUNT_NUMBER>" & vbCrLf
    '            Case Else
    '                If dt_header.Rows(0)!cuenta <> "" Then
    '                    lv_documento_01 = lv_documento_01 & "<ACCOUNT_NUMBER>" & dt_header.Rows(0)!cuenta & " (" & dt_header.Rows(0)!banco & ")</ACCOUNT_NUMBER>" & vbCrLf
    '                Else
    '                    lv_documento_01 = lv_documento_01 & "<ACCOUNT_NUMBER>" & "NO IDENTIFICADO" & "</ACCOUNT_NUMBER>" & vbCrLf
    '                End If
    '        End Select
    '        lv_documento_01 = lv_documento_01 & lv_cliente_02_ship_to & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "<PEDIDO>" & NumeroFactura & "</PEDIDO>" & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "<FECHA_PEDIDO>" & lv_full_date & "</FECHA_PEDIDO>" & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "<STATUS_FACTURA>" & "1" & "</STATUS_FACTURA>" & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "<FEC_VENC_FACT />" & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "<TRANSACTION_LINES>"

    '        lv_concepto_04 = ""
    '        For i = 0 To dt_detail.Rows.Count - 1
    '            Try

    '                Select Case DB
    '                    Case "Wendy"
    '                        SqlDataAdapter = New SqlDataAdapter("SELECT * FROM productos WHERE idProducto = " & dt_detail.Rows(i)!idProducto, gv_ConStringWendy)
    '                    Case "Librada"
    '                        SqlDataAdapter = New SqlDataAdapter("SELECT * FROM productos WHERE idProducto = " & dt_detail.Rows(i)!idProducto, gv_ConStringLibrada)
    '                    Case "Salvador"
    '                        SqlDataAdapter = New SqlDataAdapter("SELECT * FROM productos WHERE idProducto = " & dt_detail.Rows(i)!idProducto, gv_ConStringSalvador)
    '                End Select

    '                Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)

    '                ' llenar el DataTable   
    '                dt_productos.Clear()
    '                dt_productos.Dispose()
    '                dt_productos.Reset()
    '                dt_productos = New DataTable
    '                SqlDataAdapter.Fill(dt_productos)

    '            Catch exSql As SqlException
    '                MsgBox(exSql.Message, MsgBoxStyle.Critical, "ImprimeFactura dt_productos")
    '                Return False
    '            Catch ex As Exception
    '                MsgBox(ex.Message, MsgBoxStyle.Critical, "ImprimeFactura dt_productos")
    '                Return False
    '            End Try
    '            lv_concepto_04 = lv_concepto_04 & "<TRANSACTION_LINE>" & vbCrLf
    '            lv_concepto_04 = lv_concepto_04 & "<LINE_NUMBER>" & i + 1 & "</LINE_NUMBER>" & vbCrLf
    '            lv_concepto_04 = lv_concepto_04 & "<LINE_TYPE>" & "LINE" & "</LINE_TYPE>" & vbCrLf
    '            lv_concepto_04 = lv_concepto_04 & "<INVENTORY_ITEM_ID>" & dt_detail.Rows(i)!idProducto & "</INVENTORY_ITEM_ID>" & vbCrLf
    '            lv_concepto_04 = lv_concepto_04 & "<ITEM_EAN_NUMBER />" & vbCrLf
    '            lv_concepto_04 = lv_concepto_04 & "<SERIAL />" & vbCrLf
    '            lv_concepto_04 = lv_concepto_04 & "<DESCRIPTION><![CDATA[" & dt_detail.Rows(i)!descripcion & "]]></DESCRIPTION>" & vbCrLf
    '            lv_concepto_04 = lv_concepto_04 & "<QUANTITY_INVOICED>" & dt_detail.Rows(i)!cantidad & "</QUANTITY_INVOICED>" & vbCrLf
    '            lv_concepto_04 = lv_concepto_04 & "<QUANTITY_CREDITED>" & "</QUANTITY_CREDITED>" & vbCrLf
    '            lv_concepto_04 = lv_concepto_04 & "<UNIT_SELLING_PRICE>" & dt_detail.Rows(i)!precio & "</UNIT_SELLING_PRICE>" & vbCrLf

    '            If dt_productos.Rows.Count > 0 Then
    '                lv_concepto_04 = lv_concepto_04 & "<UOM_CODE>" & dt_productos.Rows(0)!unidadMedida & "</UOM_CODE>" & vbCrLf
    '            Else
    '                lv_concepto_04 = lv_concepto_04 & "<UOM_CODE>" & "PIEZA" & "</UOM_CODE>" & vbCrLf
    '            End If

    '            lv_concepto_04 = lv_concepto_04 & "<TAX_RATE>" & (FactorIVA - 1) * 100 & "</TAX_RATE>" & vbCrLf
    '            lv_concepto_04 = lv_concepto_04 & "<TAXABLE_AMOUNT>" & (dt_detail.Rows(i)!subtotal * (FactorIVA - 1)) & "</TAXABLE_AMOUNT>" & vbCrLf
    '            lv_concepto_04 = lv_concepto_04 & "<PRECIO_NETO>" & dt_detail.Rows(i)!subtotal & "</PRECIO_NETO>" & vbCrLf
    '            lv_concepto_04 = lv_concepto_04 & "<DESCUENTO/>" & vbCrLf
    '            lv_concepto_04 = lv_concepto_04 & "<VAT_TAX_ID>1</VAT_TAX_ID>" & vbCrLf
    '            lv_concepto_04 = lv_concepto_04 & "</TRANSACTION_LINE>" & vbCrLf

    '        Next i
    '        lv_documento_01 = lv_documento_01 & vbCrLf & lv_concepto_04
    '        lv_documento_01 = lv_documento_01 & "</TRANSACTION_LINES>" & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "<ADDENDA TYPE=""NONE""/>" & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "<COMPLEMENTO TYPE=""NONE"" />" & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "</TRANSACTION>" & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "</TRANSACTIONS>"

    '        Dim path As String = gv_CDFI_XML_PATH & "A-" & Format(NumeroFactura, "000000") & "_" & Format(Now.Year, "00") & Format(Now.Month, "00") & Format(Now.Day, "00") & "CFDI.xml"

    '        ' This text is added only once to the file. 
    '        If File.Exists(path) = False Then
    '            ' Create a file to write to. 
    '            File.WriteAllText(path, lv_documento_01)
    '        Else
    '            File.Delete(path)
    '            File.WriteAllText(path, lv_documento_01)
    '        End If
    '        Return True
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "ImprimeFactura Genera Reporte Local")
    '        Return False
    '    End Try

    'End Function

    Public Function PAC() As MFObject
        Dim p As MFObject = New MFObject("PAC")
        p("usuario") = gv_cfdi_usuario
        p("pass") = gv_cfdi_password
        p("produccion") = gv_cfdi_prd
        Return p
    End Function

    Public Function PAC2() As MFObject
        Dim p As MFObject = New MFObject("PAC")
        p("usuario") = gv_cfdi_usuario
        p("pass") = gv_cfdi_password
        Return p
    End Function

    Public Function Conf() As MFObject
        Dim con As MFObject = New MFObject("conf")
        con("cer") = gv_sat_cer
        con("key") = gv_sat_key
        con("pass") = gv_sat_pass
        Return con
    End Function

    'Public Function CancelaFactura_CFDI(ByVal NumeroFactura As Integer, ByVal DB As String) As Boolean
    '    Dim sdk As MFSDK = New MFSDK()
    '    Dim folio_timbre As String = "B-" & NumeroFactura & "_" & FechaFactura & "CFDI"
    '    Dim lv_path As String = My.Settings.CDFI_XML_PATH
    '    sdk.Iniciales.Add("cfdi", lv_path & folio_timbre & ".xml")
    '    sdk.Iniciales.Add("cancelar", "SI")
    '    sdk.AgregaObjeto(PAC())
    '    sdk.AgregaObjeto(Conf())

    '    Try
    '        Dim respuesta As SDKRespuesta = sdk.Timbrar("C:\sdk2\timbrar32.bat", lv_path, folio_timbre, False)
    '        Dim mensaje As String = String.Format("Código: {0}" + vbCrLf + "Mensaje: {1}", respuesta.Codigo_MF_Numero, respuesta.Codigo_MF_Texto)
    '        If respuesta.Codigo_MF_Numero = "0" Then
    '            MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.OK, If(respuesta.Codigo_MF_Numero = "0", MessageBoxIcon.Information, MessageBoxIcon.Warning))

    '            Dim dt_header As DataTable = New DataTable
    '            Dim dt_cliente As DataTable = New DataTable
    '            Dim sql_header As String = "Select * from factura_total where n_factura = " & NumeroFactura

    '            Try

    '                Select Case DB
    '                    Case "Wendy"
    '                        SqlDataAdapter = New SqlDataAdapter(sql_header, gv_ConStringWendy)
    '                    Case "Librada"
    '                        SqlDataAdapter = New SqlDataAdapter(sql_header, gv_ConStringLibrada)
    '                    Case "Salvador"
    '                        SqlDataAdapter = New SqlDataAdapter(sql_header, gv_ConStringSalvador)
    '                End Select


    '                Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)

    '                ' llenar el DataTable   
    '                dt_header.Clear()
    '                dt_header.Dispose()
    '                dt_header.Reset()
    '                dt_header = New DataTable
    '                SqlDataAdapter.Fill(dt_header)

    '            Catch exSql As SqlException
    '                Return False
    '            Catch ex As Exception
    '                Return False
    '            End Try

    '            Try
    '                Dim sql_cliente As String = "select * from clientes where clave = '" & dt_header.Rows(0)!id_cliente & "'"

    '                Select Case DB
    '                    Case "Wendy"
    '                        SqlDataAdapter = New SqlDataAdapter(sql_cliente, gv_ConStringWendy)
    '                    Case "Librada"
    '                        SqlDataAdapter = New SqlDataAdapter(sql_cliente, gv_ConStringLibrada)
    '                    Case "Salvador"
    '                        SqlDataAdapter = New SqlDataAdapter(sql_cliente, gv_ConStringSalvador)
    '                End Select

    '                Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)

    '                ' llenar el DataTable   
    '                dt_cliente.Clear()
    '                dt_cliente.Dispose()
    '                dt_cliente.Reset()
    '                dt_cliente = New DataTable
    '                SqlDataAdapter.Fill(dt_cliente)

    '            Catch exSql As SqlException
    '                Return False
    '            Catch ex As Exception
    '                Return False
    '            End Try

    '            If dt_cliente.Rows(0)!correo <> "" Then
    '                Dim lvBody As String = ""
    '                ' Set email body
    '                lvBody = ""
    '                lvBody = lvBody & "Estimado Cliente " & dt_cliente.Rows(0)!nombre & " " & dt_cliente.Rows(0)!apat & " " & dt_cliente.Rows(0)!amat & vbCrLf & vbCrLf
    '                lvBody = lvBody & "Por medio del presente Correo Electrónico, le hago la notificación de Cancelación del comprobante fiscal" & vbCrLf
    '                lvBody = lvBody & "emitido por nuestra empresa Material Eléctrico Progreso." & vbCrLf
    '                lvBody = lvBody & "Favor de accesar a su buzón tributario para aceptar dicha cancelación." & vbCrLf & vbCrLf
    '                lvBody = lvBody & "Cualquier aclaración, favor de contactarnos. Lo puede hacer respondiendo a este correo." & vbCrLf & vbCrLf
    '                lvBody = lvBody & "ATTE:" & vbCrLf
    '                lvBody = lvBody & "Salvador Bautista Fuentes" & vbCrLf
    '                lvBody = lvBody & "Empresario" & vbCrLf


    '                FrmCancelarPedido.Cursor = Cursors.WaitCursor
    '                If EnviarEmail(gv_smtp_correo, dt_cliente.Rows(0)!correo, "Cancelación de Factura " & folio_timbre, lvBody, "", gv_smtp_pass) Then
    '                    FrmCancelarPedido.Cursor = Cursors.Default
    '                    MsgBox("Correo Electrónico enviado correctamente!", vbInformation, "Envío de Correo Electrónico")
    '                    Return True
    '                Else
    '                    FrmCancelarPedido.Cursor = Cursors.Default
    '                    MsgBox("Error al momento de enviar el correo electrónico", vbCritical, "Error al enviar correo electrónico.")
    '                    Return False
    '                End If
    '            Else
    '                Return True
    '            End If
    '        Else
    '            MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.OK, If(respuesta.Codigo_MF_Numero = "0", MessageBoxIcon.Information, MessageBoxIcon.Error))
    '            Return False
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '        Return False
    '    End Try
    'End Function

    'Public Function CancelaNC_CFDI(ByVal NumeroFactura As Integer, ByVal DB As String) As Boolean
    '    Dim dt_header As DataTable = New DataTable
    '    Dim dt_detail As DataTable = New DataTable
    '    Dim dt_factura As DataTable = New DataTable
    '    Dim dt_cliente As DataTable = New DataTable
    '    Dim dt_productos As DataTable = New DataTable
    '    Dim sql_header As String = "Select * from nc where n_nc = " & NumeroFactura
    '    Dim sql_detail As String = "select * from nc_detalle where n_nc = " & NumeroFactura
    '    Dim sql_factura As String = "select * from foliosfacturas where tipocomprobante = 'NOTAS DE CREDITO' and year = " & CInt(Now.Date.Year)

    '    Dim lv_documento_01 As String = ""
    '    Dim lv_cliente_02_bill_to As String = ""
    '    Dim lv_cliente_02_ship_to As String = ""
    '    Dim lv_concepto_04 As String = ""
    '    Dim lv_iva_10 As String = ""
    '    Try
    '        Select Case DB
    '            Case "Wendy"
    '                SqlDataAdapter = New SqlDataAdapter(sql_header, gv_ConStringWendy)
    '            Case "Librada"
    '                SqlDataAdapter = New SqlDataAdapter(sql_header, gv_ConStringLibrada)
    '            Case "Salvador"
    '                SqlDataAdapter = New SqlDataAdapter(sql_header, gv_ConStringSalvador)
    '        End Select

    '        Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)

    '        ' llenar el DataTable   
    '        dt_header.Clear()
    '        dt_header.Dispose()
    '        dt_header.Reset()
    '        dt_header = New DataTable
    '        SqlDataAdapter.Fill(dt_header)

    '    Catch exSql As SqlException
    '        MsgBox(exSql.Message, MsgBoxStyle.Critical, "ImprimeNC dt_header")
    '        Return False
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "ImprimeNC dt_header")
    '        Return False
    '    End Try

    '    Try
    '        Select Case DB
    '            Case "Wendy"
    '                SqlDataAdapter = New SqlDataAdapter(sql_detail, gv_ConStringWendy)
    '            Case "Librada"
    '                SqlDataAdapter = New SqlDataAdapter(sql_detail, gv_ConStringLibrada)
    '            Case "Salvador"
    '                SqlDataAdapter = New SqlDataAdapter(sql_detail, gv_ConStringSalvador)
    '        End Select

    '        Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)

    '        ' llenar el DataTable   
    '        dt_detail.Clear()
    '        dt_detail.Dispose()
    '        dt_detail.Reset()
    '        dt_detail = New DataTable
    '        SqlDataAdapter.Fill(dt_detail)

    '    Catch exSql As SqlException
    '        MsgBox(exSql.Message, MsgBoxStyle.Critical, "ImprimeNC dt_detail")
    '        Return False
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "ImprimeNC dt_detail")
    '        Return False
    '    End Try

    '    Try
    '        Select Case DB
    '            Case "Wendy"
    '                SqlDataAdapter = New SqlDataAdapter(sql_factura, gv_ConStringWendy)
    '            Case "Librada"
    '                SqlDataAdapter = New SqlDataAdapter(sql_factura, gv_ConStringLibrada)
    '            Case "Salvador"
    '                SqlDataAdapter = New SqlDataAdapter(sql_factura, gv_ConStringSalvador)
    '        End Select

    '        Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)

    '        ' llenar el DataTable   
    '        dt_factura.Clear()
    '        dt_factura.Dispose()
    '        dt_factura.Reset()
    '        dt_factura = New DataTable
    '        SqlDataAdapter.Fill(dt_factura)

    '    Catch exSql As SqlException
    '        MsgBox(exSql.Message, MsgBoxStyle.Critical, "ImprimeNC dt_detail")
    '        Return False
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "ImprimeNC dt_detail")
    '        Return False
    '    End Try

    '    Try
    '        Dim sql_cliente As String = "select * from clientes where clave = '" & dt_header.Rows(0)!id_cliente & "'"
    '        Select Case DB
    '            Case "Wendy"
    '                SqlDataAdapter = New SqlDataAdapter(sql_cliente, gv_ConStringWendy)
    '            Case "Librada"
    '                SqlDataAdapter = New SqlDataAdapter(sql_cliente, gv_ConStringLibrada)
    '            Case "Salvador"
    '                SqlDataAdapter = New SqlDataAdapter(sql_cliente, gv_ConStringSalvador)
    '        End Select

    '        Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)

    '        ' llenar el DataTable   
    '        dt_cliente.Clear()
    '        dt_cliente.Dispose()
    '        dt_cliente.Reset()
    '        dt_cliente = New DataTable
    '        SqlDataAdapter.Fill(dt_cliente)

    '    Catch exSql As SqlException
    '        MsgBox(exSql.Message, MsgBoxStyle.Critical, "ImprimeNC dt_cliente")
    '        Return False
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "ImprimeNC dt_detail")
    '        Return False
    '    End Try

    '    Dim lv_nombre As String = ""
    '    Dim lv_direccion As String = ""
    '    Dim lv_colonia As String = ""
    '    Dim lv_codigopostal As String = ""
    '    Dim lv_ciudad As String = ""
    '    Dim lv_rfc As String = ""

    '    Try
    '        If dt_cliente.Rows.Count > 0 Then
    '            If dt_cliente.Rows(0)!nombre <> "" Or dt_cliente.Rows(0)!apat <> "" Or dt_cliente.Rows(0)!amat <> "" Then
    '                lv_nombre = dt_cliente.Rows(0)!nombre & " " & dt_cliente.Rows(0)!apat & " " & dt_cliente.Rows(0)!amat
    '            End If
    '            If dt_cliente.Rows(0)!calle <> "" Then
    '                lv_direccion = dt_cliente.Rows(0)!calle
    '                If dt_cliente.Rows(0)!numero <> "" Then
    '                    lv_direccion = lv_direccion & " #" & dt_cliente.Rows(0)!numero
    '                End If
    '            Else
    '                lv_direccion = " "
    '            End If
    '            If dt_cliente.Rows(0)!colonia <> "" Then
    '                lv_colonia = dt_cliente.Rows(0)!colonia
    '            Else
    '                lv_colonia = " "
    '            End If
    '            If dt_cliente.Rows(0)!cp <> "" Then
    '                lv_codigopostal = dt_cliente.Rows(0)!cp
    '            Else
    '                lv_codigopostal = " "
    '            End If
    '            If dt_cliente.Rows(0)!ciudad <> "" Then
    '                If dt_cliente.Rows(0)!estado <> "" Then
    '                    lv_ciudad = dt_cliente.Rows(0)!ciudad & ", " & dt_cliente.Rows(0)!estado
    '                Else
    '                    lv_ciudad = dt_cliente.Rows(0)!ciudad
    '                End If
    '            Else
    '                lv_ciudad = " "
    '            End If
    '            If dt_cliente.Rows(0)!rfc <> "" Then
    '                lv_rfc = dt_cliente.Rows(0)!rfc
    '            Else
    '                lv_rfc = " "
    '            End If
    '            lv_cliente_02_bill_to = "<BILL_TO_CUSTOMER SEND_XML=""TRUE"" SEND_PDF=""TRUE"">" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<PARTY>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<PARTY_ID>" & dt_cliente.Rows(0)!clave & "</PARTY_ID>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<PARTY_NAME><![CDATA[" & lv_nombre & "]]></PARTY_NAME>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<PARTY_TYPE>" & "CUSTOMER" & "</PARTY_TYPE>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<JGZZ_FISCAL_CODE><![CDATA[" & lv_rfc & "]]></JGZZ_FISCAL_CODE>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<ADDRESS1><![CDATA[" & dt_cliente.Rows(0)!calle & "]]></ADDRESS1>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<ADDRESS2><![CDATA[" & dt_cliente.Rows(0)!numero & "]]></ADDRESS2>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<ADDRESS3>" & "" & "</ADDRESS3>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<ADDRESS4><![CDATA[" & lv_colonia & "]]></ADDRESS4>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<POSTAL_CODE>" & lv_codigopostal & "</POSTAL_CODE>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<CITY><![CDATA[" & lv_ciudad & "]]></CITY>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<STATE><![CDATA[" & dt_cliente.Rows(0)!estado & "]]></STATE>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<COUNTRY><![CDATA[" & "México" & "]]></COUNTRY>" & vbCrLf

    '            Select Case dt_header.Rows(0)!metodopago
    '                Case "EFECTIVO"
    '                    lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<METODO_PAGO>" & "1" & "</METODO_PAGO>" & vbCrLf
    '                Case "CHEQUE"
    '                    lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<METODO_PAGO>" & "2" & "</METODO_PAGO>" & vbCrLf
    '                Case "TRANSFERENCIA"
    '                    lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<METODO_PAGO>" & "3" & "</METODO_PAGO>" & vbCrLf
    '            End Select

    '            Select Case dt_header.Rows(0)!tipo_venta
    '                Case "CONTADO"
    '                    lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<COND_PAGO>" & "1" & "</COND_PAGO>" & vbCrLf
    '                Case "CREDITO"
    '                    lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<COND_PAGO>" & "2" & "</COND_PAGO>" & vbCrLf
    '            End Select

    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<DIAS_PAGO>" & "0" & "</DIAS_PAGO>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<LOCALIDAD>" & "0" & "</LOCALIDAD>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<REFERENCIA>" & "0" & "</REFERENCIA>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<EMAIL>" & dt_cliente.Rows(0)!correo & "</EMAIL>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<CODIGO_CLIENTE>" & dt_cliente.Rows(0)!clave & "</CODIGO_CLIENTE>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "</PARTY>" & vbCrLf
    '            lv_cliente_02_bill_to = lv_cliente_02_bill_to & "</BILL_TO_CUSTOMER>"

    '            lv_cliente_02_ship_to = "<SHIP_TO_CUSTOMER>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<PARTY>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<PARTY_ID>" & dt_cliente.Rows(0)!clave & "</PARTY_ID>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<PARTY_NAME><![CDATA[" & lv_nombre & "]]></PARTY_NAME>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<PARTY_TYPE>" & "CUSTOMER" & "</PARTY_TYPE>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<JGZZ_FISCAL_CODE><![CDATA[" & lv_rfc & "]]></JGZZ_FISCAL_CODE>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<ADDRESS1><![CDATA[" & dt_cliente.Rows(0)!calle & "]]></ADDRESS1>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<ADDRESS2><![CDATA[" & dt_cliente.Rows(0)!numero & "]]></ADDRESS2>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<ADDRESS3>" & "" & "</ADDRESS3>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<ADDRESS4><![CDATA[" & lv_colonia & "]]></ADDRESS4>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<POSTAL_CODE>" & lv_codigopostal & "</POSTAL_CODE>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<CITY><![CDATA[" & lv_ciudad & "]]></CITY>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<STATE><![CDATA[" & dt_cliente.Rows(0)!estado & "]]></STATE>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<COUNTRY><![CDATA[" & "México" & "]]></COUNTRY>" & vbCrLf

    '            Select Case dt_header.Rows(0)!metodopago
    '                Case "EFECTIVO"
    '                    lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<METODO_PAGO>" & "1" & "</METODO_PAGO>" & vbCrLf
    '                Case "CHEQUE"
    '                    lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<METODO_PAGO>" & "2" & "</METODO_PAGO>" & vbCrLf
    '                Case "TRANSFERENCIA"
    '                    lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<METODO_PAGO>" & "3" & "</METODO_PAGO>" & vbCrLf
    '            End Select

    '            Select Case dt_header.Rows(0)!tipo_venta
    '                Case "CONTADO"
    '                    lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<COND_PAGO>" & "1" & "</COND_PAGO>" & vbCrLf
    '                Case "CREDITO"
    '                    lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<COND_PAGO>" & "2" & "</COND_PAGO>" & vbCrLf
    '            End Select

    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<DIAS_PAGO>" & "0" & "</DIAS_PAGO>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<CODIGO_CLIENTE>" & dt_cliente.Rows(0)!clave & "</CODIGO_CLIENTE>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "</PARTY>" & vbCrLf
    '            lv_cliente_02_ship_to = lv_cliente_02_ship_to & "</SHIP_TO_CUSTOMER>"
    '        End If
    '    Catch exSql As SqlException
    '        MsgBox(exSql.Message, MsgBoxStyle.Critical, "ImprimeNC Datos Cliente")
    '        Return False
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "ImprimeNC Datos Cliente")
    '        Return False

    '    End Try

    '    Try
    '        Dim lv_factura As String = NumeroFactura
    '        Dim lv_fecha As String = Format(dt_header.Rows(0)!fecha_venta, "MM/dd/yyyy")
    '        Dim lv_time As String = Format(Now.TimeOfDay.Hours, "00") & ":" & Format(Now.TimeOfDay.Minutes, "00") & ":" & Format(Now.TimeOfDay.Seconds, "00")
    '        Dim lv_full_date As String = lv_fecha & " " & lv_time

    '        Dim lv_subtotal As String = dt_header.Rows(0)!total

    '        Dim lv_iva As String = dt_header.Rows(0)!total * (FactorIVA - 1)

    '        Dim lv_total As String = Val(lv_subtotal) + Val(lv_iva)

    '        lv_documento_01 = "<?xml version='1.0'  encoding='UTF-8' ?>" & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "<TRANSACTIONS>" & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "<TRANSACTION>" & vbCrLf
    '        Select Case DB
    '            Case "Wendy"
    '                lv_documento_01 = lv_documento_01 & "<SERIE>" & "XXX" & "</SERIE>" & vbCrLf
    '            Case "Librada"
    '                lv_documento_01 = lv_documento_01 & "<SERIE>" & gv_SerieNCLibrada & "</SERIE>" & vbCrLf
    '            Case "Salvador"
    '                lv_documento_01 = lv_documento_01 & "<SERIE>" & gv_SerieNCSalvador & "</SERIE>" & vbCrLf
    '        End Select
    '        lv_documento_01 = lv_documento_01 & "<TRX_NUMBER>" & NumeroFactura & "</TRX_NUMBER>" & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "<CUST_TRX_TYPE_ID>" & "2" & "</CUST_TRX_TYPE_ID>" & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "<TRX_DATE>" & lv_full_date & "</TRX_DATE>" & vbCrLf
    '        lv_documento_01 = lv_documento_01 & lv_cliente_02_bill_to & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "<TIPO_MONEDA>" & "MXN" & "</TIPO_MONEDA>" & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "<TASA_DE_CAMBIO>" & "1" & "</TASA_DE_CAMBIO>" & vbCrLf
    '        Select Case DB
    '            Case "Librada"
    '                lv_documento_01 = lv_documento_01 & "<SELLER_ID>" & "1120" & "</SELLER_ID>" & vbCrLf
    '            Case "Salvador"
    '                lv_documento_01 = lv_documento_01 & "<SELLER_ID>" & "631" & "</SELLER_ID>" & vbCrLf
    '        End Select
    '        lv_documento_01 = lv_documento_01 & "<BUYER_ID>" & dt_cliente.Rows(0)!clave & "</BUYER_ID>" & vbCrLf
    '        Select Case DB
    '            Case "Librada"
    '                lv_documento_01 = lv_documento_01 & "<SHIP_FROM>" & "1121" & "</SHIP_FROM>" & vbCrLf
    '            Case "Salvador"
    '                lv_documento_01 = lv_documento_01 & "<SHIP_FROM>" & "632" & "</SHIP_FROM>" & vbCrLf
    '        End Select
    '        lv_documento_01 = lv_documento_01 & "<SHIP_TO>" & dt_cliente.Rows(0)!clave & "</SHIP_TO>" & vbCrLf
    '        Select Case dt_header.Rows(0)!metodopago
    '            Case "EFECTIVO"
    '                lv_documento_01 = lv_documento_01 & "<ACCOUNT_NUMBER>" & "NO IDENTIFICADO" & "</ACCOUNT_NUMBER>" & vbCrLf
    '            Case Else
    '                If dt_header.Rows(0)!cuenta <> "" Then
    '                    lv_documento_01 = lv_documento_01 & "<ACCOUNT_NUMBER>" & dt_header.Rows(0)!cuenta & " (" & dt_header.Rows(0)!banco & ")</ACCOUNT_NUMBER>" & vbCrLf
    '                Else
    '                    lv_documento_01 = lv_documento_01 & "<ACCOUNT_NUMBER>" & "NO IDENTIFICADO" & "</ACCOUNT_NUMBER>" & vbCrLf
    '                End If
    '        End Select
    '        lv_documento_01 = lv_documento_01 & lv_cliente_02_ship_to & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "<PEDIDO>" & NumeroFactura & "</PEDIDO>" & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "<FECHA_PEDIDO>" & lv_full_date & "</FECHA_PEDIDO>" & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "<STATUS_FACTURA>" & "0" & "</STATUS_FACTURA>" & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "<FEC_VENC_FACT />" & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "<TRANSACTION_LINES>"

    '        lv_concepto_04 = ""
    '        For i = 0 To dt_detail.Rows.Count - 1
    '            Try
    '                Select Case DB
    '                    Case "Wendy"
    '                        SqlDataAdapter = New SqlDataAdapter("SELECT * FROM productos WHERE idProducto = " & dt_detail.Rows(i)!idProducto, gv_ConStringWendy)
    '                    Case "Librada"
    '                        SqlDataAdapter = New SqlDataAdapter("SELECT * FROM productos WHERE idProducto = " & dt_detail.Rows(i)!idProducto, gv_ConStringLibrada)
    '                    Case "Salvador"
    '                        SqlDataAdapter = New SqlDataAdapter("SELECT * FROM productos WHERE idProducto = " & dt_detail.Rows(i)!idProducto, gv_ConStringSalvador)
    '                End Select

    '                Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)

    '                ' llenar el DataTable   
    '                dt_productos.Clear()
    '                dt_productos.Dispose()
    '                dt_productos.Reset()
    '                dt_productos = New DataTable
    '                SqlDataAdapter.Fill(dt_productos)

    '            Catch exSql As SqlException
    '                MsgBox(exSql.Message, MsgBoxStyle.Critical, "ImprimeNC dt_productos")
    '                Return False
    '            Catch ex As Exception
    '                MsgBox(ex.Message, MsgBoxStyle.Critical, "ImprimeNC dt_productos")
    '                Return False
    '            End Try
    '            lv_concepto_04 = lv_concepto_04 & "<TRANSACTION_LINE>" & vbCrLf
    '            lv_concepto_04 = lv_concepto_04 & "<LINE_NUMBER>" & i + 1 & "</LINE_NUMBER>" & vbCrLf
    '            lv_concepto_04 = lv_concepto_04 & "<LINE_TYPE>" & "LINE" & "</LINE_TYPE>" & vbCrLf
    '            lv_concepto_04 = lv_concepto_04 & "<INVENTORY_ITEM_ID>" & dt_detail.Rows(i)!idProducto & "</INVENTORY_ITEM_ID>" & vbCrLf
    '            lv_concepto_04 = lv_concepto_04 & "<ITEM_EAN_NUMBER />" & vbCrLf
    '            lv_concepto_04 = lv_concepto_04 & "<SERIAL />" & vbCrLf
    '            lv_concepto_04 = lv_concepto_04 & "<DESCRIPTION><![CDATA[" & dt_detail.Rows(i)!descripcion & "]]></DESCRIPTION>" & vbCrLf
    '            lv_concepto_04 = lv_concepto_04 & "<QUANTITY_INVOICED>" & dt_detail.Rows(i)!cantidad & "</QUANTITY_INVOICED>" & vbCrLf
    '            lv_concepto_04 = lv_concepto_04 & "<QUANTITY_CREDITED>" & "</QUANTITY_CREDITED>" & vbCrLf
    '            lv_concepto_04 = lv_concepto_04 & "<UNIT_SELLING_PRICE>" & dt_detail.Rows(i)!precio & "</UNIT_SELLING_PRICE>" & vbCrLf

    '            If dt_productos.Rows.Count > 0 Then
    '                lv_concepto_04 = lv_concepto_04 & "<UOM_CODE>" & dt_productos.Rows(0)!unidadMedida & "</UOM_CODE>" & vbCrLf
    '            Else
    '                lv_concepto_04 = lv_concepto_04 & "<UOM_CODE>" & "PIEZA" & "</UOM_CODE>" & vbCrLf
    '            End If

    '            lv_concepto_04 = lv_concepto_04 & "<TAX_RATE>" & (FactorIVA - 1) * 100 & "</TAX_RATE>" & vbCrLf
    '            lv_concepto_04 = lv_concepto_04 & "<TAXABLE_AMOUNT>" & (dt_detail.Rows(i)!subtotal * (FactorIVA - 1)) & "</TAXABLE_AMOUNT>" & vbCrLf
    '            lv_concepto_04 = lv_concepto_04 & "<PRECIO_NETO>" & dt_detail.Rows(i)!subtotal & "</PRECIO_NETO>" & vbCrLf
    '            lv_concepto_04 = lv_concepto_04 & "<DESCUENTO/>" & vbCrLf
    '            lv_concepto_04 = lv_concepto_04 & "<VAT_TAX_ID>1</VAT_TAX_ID>" & vbCrLf
    '            lv_concepto_04 = lv_concepto_04 & "</TRANSACTION_LINE>" & vbCrLf

    '        Next i
    '        lv_documento_01 = lv_documento_01 & vbCrLf & lv_concepto_04
    '        lv_documento_01 = lv_documento_01 & "</TRANSACTION_LINES>" & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "<ADDENDA TYPE=""NONE""/>" & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "<COMPLEMENTO TYPE=""NONE"" />" & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "</TRANSACTION>" & vbCrLf
    '        lv_documento_01 = lv_documento_01 & "</TRANSACTIONS>"

    '        Dim path As String = ""
    '        Select Case DB
    '            Case "Librada"
    '                path = gv_CDFI_XML_PATH & "C-" & Format(NumeroFactura, "000000") & "_" & Format(Now.Year, "00") & Format(Now.Month, "00") & Format(Now.Day, "00") & "(CANCELADA)_CFDI.xml"
    '            Case "Salvador"
    '                path = gv_CDFI_XML_PATH & "D-" & Format(NumeroFactura, "000000") & "_" & Format(Now.Year, "00") & Format(Now.Month, "00") & Format(Now.Day, "00") & "(CANCELADA)_CFDI.xml"
    '        End Select

    '        ' This text is added only once to the file. 
    '        If File.Exists(path) = False Then
    '            ' Create a file to write to. 
    '            File.WriteAllText(path, lv_documento_01)
    '        Else
    '            File.Delete(path)
    '            File.WriteAllText(path, lv_documento_01)
    '        End If
    '        Return True
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "ImprimeFactura Genera Reporte Local")
    '        Return False
    '    End Try

    'End Function

    Public Function ImprimeNotaDeCredito(ByVal NumeroFactura As String, ByVal FolioFactura As String, ByVal Imprimir As Boolean) As Boolean

        Dim dt_detail As DataTable = New DataTable
        '---------Variables para reporte--------------
        Dim rep_FormadePago As String
        Dim rep_TipoRelacion As String
        Dim rep_UUID_relacion As String
        Dim rep_MetododePago As String
        Dim rep_UsoCFDI As String
        Dim rep_folio As String = FolioFactura
        Dim rep_direccion As String
        Dim rep_colonia As String
        Dim rep_cuidad As String

        '--------------------------------------------

        dt_detail.Columns.Add("cantidad", GetType(Integer))
        dt_detail.Columns.Add("unidad", GetType(String))
        dt_detail.Columns.Add("clave", GetType(String))
        dt_detail.Columns.Add("descripcion", GetType(String))
        dt_detail.Columns.Add("precio", GetType(Double))
        dt_detail.Columns.Add("subtotal", GetType(Double))
        dt_detail.Columns.Add("noidentificacion", GetType(String))
        dt_detail.Columns.Add("impuesto", GetType(String))
        dt_detail.Columns.Add("base", GetType(Double))
        dt_detail.Columns.Add("importe", GetType(Double))
        dt_detail.Columns.Add("tasaocuota", GetType(Double))

        dt_detail.TableName = "facturas"
        Try
            Dim Report As New LocalReport
            Dim ruta As String = gv_CDFI_XML_PATH
            Dim DS As New DataSet
            Dim dt_comprobante As DataTable = New DataTable

            ruta = ruta & rep_folio & ".xml"
            Dim fsReadXml As New System.IO.FileStream(ruta, System.IO.FileMode.Open)
            DS.ReadXml(fsReadXml)

            Dim lv_iva_total As Double = 0
            For i = 0 To DS.Tables("Concepto").Rows.Count - 1

                Dim dt_details_row As DataRow = dt_detail.NewRow()

                dt_details_row("cantidad") = CInt(DS.Tables("Concepto").Rows(i)("Cantidad"))
                dt_details_row("unidad") = DS.Tables("Concepto").Rows(i)("ClaveUnidad").ToString()
                dt_details_row("clave") = DS.Tables("Concepto").Rows(i)("ClaveProdServ").ToString()
                dt_details_row("noidentificacion") = DS.Tables("Concepto").Rows(i)("NoIdentificacion").ToString()
                dt_details_row("descripcion") = DS.Tables("Concepto").Rows(i)("Descripcion").ToString()
                dt_details_row("impuesto") = DS.Tables("Traslado").Rows(i)("Impuesto")
                dt_details_row("base") = CDbl(DS.Tables("Traslado").Rows(i)("Base"))
                dt_details_row("importe") = CDbl(DS.Tables("Traslado").Rows(i)("Importe"))
                dt_details_row("tasaocuota") = CDbl(DS.Tables("Traslado").Rows(i)("TasaOCuota")) * 100
                dt_details_row("precio") = CDbl(DS.Tables("Concepto").Rows(i)("ValorUnitario"))
                dt_details_row("subtotal") = CDbl(DS.Tables("Concepto").Rows(i)("Importe"))

                lv_iva_total = lv_iva_total + CDbl(DS.Tables("Traslado").Rows(i)("Importe"))
                dt_detail.Rows.Add(dt_details_row)

            Next

            rep_FormadePago = DS.Tables("Comprobante").Rows(0)("FormaPago").ToString()
            Dim wa_FormaDePago As tblFormaPago = DBModelo.GetFormaDePagoByKey(rep_FormadePago)
            rep_FormadePago = wa_FormaDePago.FormaPago

            rep_TipoRelacion = DS.Tables("CfdiRelacionados").Rows(0)("TipoRelacion").ToString()
            Dim wa_TipoRelacion As tblTipoDeRelacion = DBModelo.GetTipoRelacion_ByKey(rep_TipoRelacion)
            rep_TipoRelacion = wa_TipoRelacion.TipoRelacion

            rep_MetododePago = DS.Tables("Comprobante").Rows(0)("MetodoPago").ToString()
            Dim wa_MetodoDePago As tblMetodoPago = DBModelo.GetMetodoDePagoByKey(rep_MetododePago)
            rep_MetododePago = wa_MetodoDePago.MetodoPago

            rep_UsoCFDI = DS.Tables("Receptor").Rows(0)("UsoCFDI").ToString()
            Dim wa_UsoCFDI As tblUsoCFDI = DBModelo.GetUsoCFDIByKey(rep_UsoCFDI)
            rep_UsoCFDI = wa_UsoCFDI.UsoCFDI

            ' Copia del GetFacturasHeader en Notas de Crédito, junto con el Ipdate_PV_Notas
            Dim wa_header As tblNC = DBModelo.GetNotaCreditoHeader(NumeroFactura)

            wa_header.UUID = DS.Tables("TimbreFiscalDigital").Rows(0)("UUID").ToString()

            rep_UUID_relacion = DS.Tables("CfdiRelacionado").Rows(0)("UUID").ToString()

            If Not DBModelo.Update_PV_NC(wa_header) Then
                MsgBox("Problemas al actualizar el UUID en la tabla NC", MsgBoxStyle.Exclamation, "Actualización de UUID")
            End If

            Dim wa_cliente As tblClientes = DBModelo.GetCliente(wa_header.id_cliente)

            Dim lv_nombre As String = ""
            Dim lv_direccion As String = ""
            Dim lv_colonia As String = ""
            Dim lv_codigopostal As String = ""
            Dim lv_ciudad As String = ""
            Dim lv_rfc As String = ""


            If wa_cliente.nombre <> "" Or wa_cliente.apat <> "" Or wa_cliente.amat <> "" Then
                lv_nombre = wa_cliente.nombre & " " & wa_cliente.apat & " " & wa_cliente.amat
            End If

            If wa_cliente.calle <> "" Then
                lv_direccion = wa_cliente.calle
                If wa_cliente.numero <> "" Then
                    lv_direccion = lv_direccion & " #" & wa_cliente.numero
                End If
            Else
                lv_direccion = " "
            End If

            If wa_cliente.colonia <> "" Then
                lv_colonia = wa_cliente.colonia
            Else
                lv_colonia = " "
            End If

            If wa_cliente.cp <> "" Then
                lv_codigopostal = wa_cliente.cp
            Else
                lv_codigopostal = " "
            End If

            If wa_cliente.ciudad <> "" Then
                If wa_cliente.estado <> "" Then
                    lv_ciudad = wa_cliente.ciudad & ", " & wa_cliente.estado
                Else
                    lv_ciudad = wa_cliente.ciudad
                End If
            Else
                lv_ciudad = " "
            End If

            If wa_cliente.rfc <> "" Then
                lv_rfc = wa_cliente.rfc
            Else
                lv_rfc = " "
            End If

            rep_direccion = lv_direccion
            rep_cuidad = lv_ciudad
            rep_colonia = lv_colonia

            Dim lv_TipoDeComprobante As String = ""
            Select Case DS.Tables("Comprobante").Rows(0)("TipoDeComprobante").ToString()
                Case "I"
                    lv_TipoDeComprobante = "I-Ingreso"
                Case "E"
                    lv_TipoDeComprobante = "E-Egreso"
            End Select

            Dim p1 As New Microsoft.Reporting.WinForms.ReportParameter("RfcProvCertif", DS.Tables("TimbreFiscalDigital").Rows(0)("RfcProvCertif").ToString())
            Dim p2 As New Microsoft.Reporting.WinForms.ReportParameter("UUID", DS.Tables("TimbreFiscalDigital").Rows(0)("UUID").ToString())
            Dim p3 As New Microsoft.Reporting.WinForms.ReportParameter("TipoDeComprobante", lv_TipoDeComprobante)
            Dim p4 As New Microsoft.Reporting.WinForms.ReportParameter("NoCertificadoSAT", DS.Tables("TimbreFiscalDigital").Rows(0)("NoCertificadoSAT").ToString())
            Dim p5 As New Microsoft.Reporting.WinForms.ReportParameter("Image", "File:///" & gv_CDFI_XML_PATH_QR & rep_folio & ".png")
            Dim p6 As New Microsoft.Reporting.WinForms.ReportParameter("RFC", DS.Tables("Receptor").Rows(0)("RFC").ToString())
            Dim p7 As New Microsoft.Reporting.WinForms.ReportParameter("Serie", DS.Tables("Comprobante").Rows(0)("Serie").ToString())
            Dim p8 As New Microsoft.Reporting.WinForms.ReportParameter("FolioFactura", DS.Tables("Comprobante").Rows(0)("Folio").ToString())
            Dim p9 As New Microsoft.Reporting.WinForms.ReportParameter("Ciudad_RFC", rep_cuidad)
            Dim p10 As New Microsoft.Reporting.WinForms.ReportParameter("CP", DS.Tables("Comprobante").Rows(0)("LugarExpedicion").ToString())
            Dim p11 As New Microsoft.Reporting.WinForms.ReportParameter("Total", DS.Tables("Comprobante").Rows(0)("Total").ToString())
            Dim p12 As New Microsoft.Reporting.WinForms.ReportParameter("Direccion", rep_direccion)
            Dim p13 As New Microsoft.Reporting.WinForms.ReportParameter("FolioFiscal", DS.Tables("TimbreFiscalDigital").Rows(0)("UUID").ToString())
            Dim p14 As New Microsoft.Reporting.WinForms.ReportParameter("FechadeEmision", DS.Tables("Comprobante").Rows(0)("Fecha").ToString())
            Dim p15 As New Microsoft.Reporting.WinForms.ReportParameter("FechaTimbrado", DS.Tables("TimbreFiscalDigital").Rows(0)("FechaTimbrado").ToString())
            Dim p16 As New Microsoft.Reporting.WinForms.ReportParameter("SelloSAT", DS.Tables("TimbreFiscalDigital").Rows(0)("SelloSAT").ToString())
            Dim p17 As New Microsoft.Reporting.WinForms.ReportParameter("SelloCFD", DS.Tables("TimbreFiscalDigital").Rows(0)("SelloCFD").ToString())
            Dim p18 As New Microsoft.Reporting.WinForms.ReportParameter("Version", DS.Tables("TimbreFiscalDigital").Rows(0)("Version").ToString())
            Dim p19 As New Microsoft.Reporting.WinForms.ReportParameter("SubTotal", DS.Tables("Comprobante").Rows(0)("SubTotal").ToString())
            Dim p20 As New Microsoft.Reporting.WinForms.ReportParameter("UsodeCFDI", rep_UsoCFDI)
            Dim p21 As New Microsoft.Reporting.WinForms.ReportParameter("Nombre", DS.Tables("Receptor").Rows(0)("Nombre").ToString())
            Dim p22 As New Microsoft.Reporting.WinForms.ReportParameter("FormadePago", rep_FormadePago)
            Dim p23 As New Microsoft.Reporting.WinForms.ReportParameter("MetododePago", rep_MetododePago)
            Dim p24 As New Microsoft.Reporting.WinForms.ReportParameter("Colonia", rep_colonia)
            Dim p25 As New Microsoft.Reporting.WinForms.ReportParameter("CPReceptor", DS.Tables("Receptor").Rows(0)("Rfc").ToString())
            Dim p26 As New Microsoft.Reporting.WinForms.ReportParameter("IVA", lv_iva_total.ToString)
            Dim p27 As New Microsoft.Reporting.WinForms.ReportParameter("TipoRelacion", rep_TipoRelacion)
            Dim p28 As New Microsoft.Reporting.WinForms.ReportParameter("UUID_Relacion", rep_UUID_relacion)

            Report.ReportPath = gv_Report_Path & "Report8.rdlc"
            Report.EnableExternalImages = True

            Report.SetParameters(p1)
            Report.SetParameters(p2)
            Report.SetParameters(p3)
            Report.SetParameters(p4)
            Report.SetParameters(p5)
            Report.SetParameters(p6)
            Report.SetParameters(p7)
            Report.SetParameters(p8)
            Report.SetParameters(p9)
            Report.SetParameters(p10)
            Report.SetParameters(p11)
            Report.SetParameters(p12)
            Report.SetParameters(p13)
            Report.SetParameters(p14)
            Report.SetParameters(p15)
            Report.SetParameters(p16)
            Report.SetParameters(p17)
            Report.SetParameters(p18)
            Report.SetParameters(p19)
            Report.SetParameters(p20)
            Report.SetParameters(p21)
            Report.SetParameters(p22)
            Report.SetParameters(p23)
            Report.SetParameters(p24)
            Report.SetParameters(p25)
            Report.SetParameters(p26)
            Report.SetParameters(p27)
            Report.SetParameters(p28)

            Report.DataSources.Clear()
            Report.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt_detail))
            fsReadXml.Close()

            ' Creación del PDF en base al Reporte previamente llenado
            Dim pdfContent As Byte() = Report.Render("PDF", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            Dim pdfPath As String = gv_CDFI_XML_PATH & rep_folio & ".pdf"
            Dim pdfFile As New System.IO.FileStream(pdfPath, System.IO.FileMode.Create)
            pdfFile.Write(pdfContent, 0, pdfContent.Length)
            pdfFile.Close()

            ' Creación del ZIP en base al XML y PDF generado anteriormente
            Dim zipPath As String = gv_CDFI_XML_PATH & rep_folio & ".zip" '"C:\TEMP\Compression\myzip.zip"
            If File.Exists(zipPath) Then
                File.Delete(zipPath)
            End If
            Dim zip As Package = ZipPackage.Open(zipPath, IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite)
            AddToArchive(zip, gv_CDFI_XML_PATH & FolioFactura & ".xml") '"C:\TEMP\Compression\Compress Me1.txt")
            AddToArchive(zip, gv_CDFI_XML_PATH & FolioFactura & ".pdf") '"C:\TEMP\Compression\Compress Me2.txt")
            zip.Close() 'Close the zip file

            If wa_cliente.correo <> "" Then

                'Envio de Archivo ZIP via Correo Electrónico
                Dim oSmtp As New SmtpClient()

                Dim oMail As New MailMessage()

                oSmtp.UseDefaultCredentials = False
                oSmtp.Credentials = New Net.NetworkCredential(gv_smtp_correo, gv_smtp_pass)
                oSmtp.Port = 587
                oSmtp.EnableSsl = True
                oSmtp.Host = "smtp.live.com"

                oMail = New MailMessage()

                ' Set sender email address, please change it to yours
                oMail.From = New MailAddress(gv_smtp_correo)

                ' Set recipient email address, please change it to yours
                oMail.To.Add("cat_to_all@hotmail.com")
                'oMail.CC.Add(gv_smtp_correo)

                ' Set email subject
                oMail.Subject = "Factura Electrónica Material Eléctrico Progreso"

                oMail.IsBodyHtml = True

                ' Set email body
                oMail.Body = ""
                oMail.Body = oMail.Body & "Estimado Cliente " & "J. Jesus Martinez Fuentes" & vbCrLf & vbCrLf
                oMail.Body = oMail.Body & "Por medio del presente Correo Electrónico, le hago la notificación y envío del comprobante fiscal" & vbCrLf
                oMail.Body = oMail.Body & "emitido por nuestra empresa Material Eléctrico Progreso." & vbCrLf
                oMail.Body = oMail.Body & "Anexo archivo ZIP que contiene un archivo XML y un archivo PDF." & vbCrLf & vbCrLf
                oMail.Body = oMail.Body & "Cualquier aclaración, favor de contactarnos. Lo puede hacer respondiendo a este correo." & vbCrLf & vbCrLf
                oMail.Body = oMail.Body & "ATTE:" & vbCrLf
                oMail.Body = oMail.Body & "Salvador Bautista Fuentes" & vbCrLf
                oMail.Body = oMail.Body & "Empresario" & vbCrLf

                Dim ct As Net.Mime.ContentType = New Net.Mime.ContentType("application/zip")
                Dim attachItem As Attachment = New Attachment(gv_CDFI_XML_PATH & FolioFactura & ".zip", ct)

                oMail.Attachments.Add(attachItem)

                Try
                    FrmCancelarPedido.Cursor = Cursors.WaitCursor
                    oSmtp.Send(oMail)
                    oSmtp.Dispose()
                    oMail.Dispose()
                    FrmCancelarPedido.Cursor = Cursors.Default
                    MsgBox("Correo Electrónico enviado correctamente!", vbInformation, "Envío de Correo Electrónico")
                Catch ep As Exception
                    FrmCancelarPedido.Cursor = Cursors.Default
                    oSmtp.Dispose()
                    oMail.Dispose()
                    MsgBox(ep.Message, vbCritical, "Error al enviar correo electrónico.")
                    Return False
                End Try
            End If

            If MsgBox("¿Requiere Factura Impresa?", vbYesNo, "Impresión de Factura") = vbYes Then
                Print_Report2(InvocePrinterName, Report, 1, "Image", FolioFactura, gv_CDFI_XML_PATH)
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ImprimeFactura Genera Reporte Local")
            Return False
        End Try
    End Function

    Public Function ImprimeNotaDeCredito_CFDI(ByVal NumeroFactura As Integer, ByVal DB As String) As Boolean
        Dim dt_header As List(Of tblNC) = New List(Of tblNC)
        Dim dt_detail As List(Of tblNcDetalle) = New List(Of tblNcDetalle)
        Dim dt_factura As List(Of tblFoliofacturas) = New List(Of tblFoliofacturas)
        Dim dt_cliente As List(Of tblClientes) = New List(Of tblClientes)
        Dim dt_productos As List(Of tblProductos) = New List(Of tblProductos)
        Dim sql_header As String = "Select * from nc where n_nc = " & NumeroFactura
        Dim sql_detail As String = "select * from nc_detalle where n_nc = " & NumeroFactura
        Dim sql_factura As String = "select * from foliosfacturas where tipocomprobante = 'NOTAS DE CREDITO' and year = " & CInt(Now.Date.Year)

        Dim lv_documento_01 As String = ""
        Dim lv_cliente_02_bill_to As String = ""
        Dim lv_cliente_02_ship_to As String = ""
        Dim lv_concepto_04 As String = ""
        Dim lv_iva_10 As String = ""
        Using ctx As New pv_salvadorEntities1
            dt_header = ctx.tblNCs.Where(Function(i) i.n_nc = NumeroFactura).ToList
            dt_detail = ctx.tblNcDetalles.Where(Function(i) i.n_nc = NumeroFactura).ToList
            Dim d As Int32 = CInt(Now.Date.Year)
            dt_factura = ctx.tblFoliofacturas.Where(Function(i) i.TipoComprobante = "NOTAS DE CREDITO" & i.Year = d).ToList
            'dt_cliente = ctx.tblClientes.Where(Function(i) i.clave = dt_header(0).id_cliente).ToList
        End Using
        'Try
        '    Select Case DB
        '        Case "Wendy"
        '            SqlDataAdapter = New SqlDataAdapter(sql_header, gv_ConStringWendy)
        '        Case "Librada"
        '            SqlDataAdapter = New SqlDataAdapter(sql_header, gv_ConStringLibrada)
        '        Case "Salvador"
        '            SqlDataAdapter = New SqlDataAdapter(sql_header, gv_ConStringSalvador)
        '    End Select
        '
        '    Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)
        '
        '    ' llenar el DataTable   
        '    dt_header.Clear()
        '    dt_header.Dispose()
        '    dt_header.Reset()
        '    dt_header = New DataTable
        '    SqlDataAdapter.Fill(dt_header)
        '
        'Catch exSql As SqlException
        '    MsgBox(exSql.Message, MsgBoxStyle.Critical, "ImprimeNotaDeCredito_CFDI dt_header")
        '    Return False
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "ImprimeNotaDeCredito_CFDI dt_header")
        '    Return False
        'End Try
        '
        'Try
        '    Select Case DB
        '        Case "Wendy"
        '            SqlDataAdapter = New SqlDataAdapter(sql_detail, gv_ConStringWendy)
        '        Case "Librada"
        '            SqlDataAdapter = New SqlDataAdapter(sql_detail, gv_ConStringLibrada)
        '        Case "Salvador"
        '            SqlDataAdapter = New SqlDataAdapter(sql_detail, gv_ConStringSalvador)
        '    End Select
        '
        '    Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)
        '
        '    ' llenar el DataTable   
        '    dt_detail.Clear()
        '    dt_detail.Dispose()
        '    dt_detail.Reset()
        '    dt_detail = New DataTable
        '    SqlDataAdapter.Fill(dt_detail)
        '
        'Catch exSql As SqlException
        '    MsgBox(exSql.Message, MsgBoxStyle.Critical, "ImprimeNotaDeCredito_CFDI dt_detail")
        '    Return False
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "ImprimeNotaDeCredito_CFDI dt_detail")
        '    Return False
        'End Try
        '
        'Try
        '    Select Case DB
        '        Case "Wendy"
        '            SqlDataAdapter = New SqlDataAdapter(sql_factura, gv_ConStringWendy)
        '        Case "Librada"
        '            SqlDataAdapter = New SqlDataAdapter(sql_factura, gv_ConStringLibrada)
        '        Case "Salvador"
        '            SqlDataAdapter = New SqlDataAdapter(sql_factura, gv_ConStringSalvador)
        '    End Select
        '
        '    Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)
        '
        '    ' llenar el DataTable   
        '    dt_factura.Clear()
        '    dt_factura.Dispose()
        '    dt_factura.Reset()
        '    dt_factura = New DataTable
        '    SqlDataAdapter.Fill(dt_factura)
        '
        'Catch exSql As SqlException
        '    MsgBox(exSql.Message, MsgBoxStyle.Critical, "ImprimeNotaDeCredito_CFDI dt_detail")
        '    Return False
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "ImprimeNotaDeCredito_CFDI dt_detail")
        '    Return False
        'End Try

        'Try
        '    Dim sql_cliente As String = "select * from clientes where clave = '" & dt_header.Rows(0)!id_cliente & "'"
        '
        '    Select Case DB
        '        Case "Wendy"
        '            SqlDataAdapter = New SqlDataAdapter(sql_cliente, gv_ConStringWendy)
        '        Case "Librada"
        '            SqlDataAdapter = New SqlDataAdapter(sql_cliente, gv_ConStringLibrada)
        '        Case "Salvador"
        '            SqlDataAdapter = New SqlDataAdapter(sql_cliente, gv_ConStringSalvador)
        '    End Select
        '
        '    Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)
        '
        '    ' llenar el DataTable   
        '    dt_cliente.Clear()
        '    dt_cliente.Dispose()
        '    dt_cliente.Reset()
        '    dt_cliente = New DataTable
        '    SqlDataAdapter.Fill(dt_cliente)
        '
        'Catch exSql As SqlException
        '    MsgBox(exSql.Message, MsgBoxStyle.Critical, "ImprimeNotaDeCredito_CFDI dt_cliente")
        '    Return False
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "ImprimeNotaDeCredito_CFDI dt_detail")
        '    Return False
        'End Try

        Dim lv_nombre As String = ""
        Dim lv_direccion As String = ""
        Dim lv_colonia As String = ""
        Dim lv_codigopostal As String = ""
        Dim lv_ciudad As String = ""
        Dim lv_rfc As String = ""

        Try
            If dt_cliente.LongCount > 0 Then
                If dt_cliente(0).nombre <> "" Or dt_cliente(0).apat <> "" Or dt_cliente(0).amat <> "" Then
                    lv_nombre = dt_cliente(0).nombre & " " & dt_cliente(0).apat & " " & dt_cliente(0).amat
                End If
                If dt_cliente(0).calle <> "" Then
                    lv_direccion = dt_cliente(0).calle
                    If dt_cliente(0).numero <> "" Then
                        lv_direccion = lv_direccion & " #" & dt_cliente(0).numero
                    End If
                Else
                    lv_direccion = " "
                End If
                If dt_cliente(0).colonia <> "" Then
                    lv_colonia = dt_cliente(0).colonia
                Else
                    lv_colonia = " "
                End If
                If dt_cliente(0).cp <> "" Then
                    lv_codigopostal = dt_cliente(0).cp
                Else
                    lv_codigopostal = " "
                End If
                If dt_cliente(0).ciudad <> "" Then
                    If dt_cliente(0).estado <> "" Then
                        lv_ciudad = dt_cliente(0).ciudad & ", " & dt_cliente(0).estado
                    Else
                        lv_ciudad = dt_cliente(0).ciudad
                    End If
                Else
                    lv_ciudad = " "
                End If
                If dt_cliente(0).rfc <> "" Then
                    lv_rfc = dt_cliente(0).rfc
                Else
                    lv_rfc = " "
                End If
                lv_cliente_02_bill_to = "<BILL_TO_CUSTOMER SEND_XML=""TRUE"" SEND_PDF=""TRUE"">" & vbCrLf
                lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<PARTY>" & vbCrLf
                lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<PARTY_ID>" & dt_cliente(0).clave & "</PARTY_ID>" & vbCrLf
                lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<PARTY_NAME><![CDATA[" & lv_nombre & "]]></PARTY_NAME>" & vbCrLf
                lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<PARTY_TYPE>" & "CUSTOMER" & "</PARTY_TYPE>" & vbCrLf
                lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<JGZZ_FISCAL_CODE><![CDATA[" & lv_rfc & "]]></JGZZ_FISCAL_CODE>" & vbCrLf
                lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<ADDRESS1><![CDATA[" & dt_cliente(0).calle & "]]></ADDRESS1>" & vbCrLf
                lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<ADDRESS2><![CDATA[" & dt_cliente(0).numero & "]]></ADDRESS2>" & vbCrLf
                lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<ADDRESS3>" & "" & "</ADDRESS3>" & vbCrLf
                lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<ADDRESS4><![CDATA[" & lv_colonia & "]]></ADDRESS4>" & vbCrLf
                lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<POSTAL_CODE>" & lv_codigopostal & "</POSTAL_CODE>" & vbCrLf
                lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<CITY><![CDATA[" & lv_ciudad & "]]></CITY>" & vbCrLf
                lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<STATE><![CDATA[" & dt_cliente(0).estado & "]]></STATE>" & vbCrLf
                lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<COUNTRY><![CDATA[" & "México" & "]]></COUNTRY>" & vbCrLf

                Select Case dt_header(0).metodopago
                    Case "EFECTIVO"
                        lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<METODO_PAGO>" & "1" & "</METODO_PAGO>" & vbCrLf
                    Case "CHEQUE"
                        lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<METODO_PAGO>" & "2" & "</METODO_PAGO>" & vbCrLf
                    Case "TRANSFERENCIA"
                        lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<METODO_PAGO>" & "3" & "</METODO_PAGO>" & vbCrLf
                End Select

                Select Case dt_header(0).tipo_venta
                    Case "CONTADO"
                        lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<COND_PAGO>" & "1" & "</COND_PAGO>" & vbCrLf
                    Case "CREDITO"
                        lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<COND_PAGO>" & "2" & "</COND_PAGO>" & vbCrLf
                End Select

                lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<DIAS_PAGO>" & "0" & "</DIAS_PAGO>" & vbCrLf
                lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<LOCALIDAD>" & "0" & "</LOCALIDAD>" & vbCrLf
                lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<REFERENCIA>" & "0" & "</REFERENCIA>" & vbCrLf
                lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<EMAIL>" & dt_cliente(0).correo & "</EMAIL>" & vbCrLf
                lv_cliente_02_bill_to = lv_cliente_02_bill_to & "<CODIGO_CLIENTE>" & dt_cliente(0).clave & "</CODIGO_CLIENTE>" & vbCrLf
                lv_cliente_02_bill_to = lv_cliente_02_bill_to & "</PARTY>" & vbCrLf
                lv_cliente_02_bill_to = lv_cliente_02_bill_to & "</BILL_TO_CUSTOMER>"

                lv_cliente_02_ship_to = "<SHIP_TO_CUSTOMER>" & vbCrLf
                lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<PARTY>" & vbCrLf
                lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<PARTY_ID>" & dt_cliente(0).clave & "</PARTY_ID>" & vbCrLf
                lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<PARTY_NAME><![CDATA[" & lv_nombre & "]]></PARTY_NAME>" & vbCrLf
                lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<PARTY_TYPE>" & "CUSTOMER" & "</PARTY_TYPE>" & vbCrLf
                lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<JGZZ_FISCAL_CODE><![CDATA[" & lv_rfc & "]]></JGZZ_FISCAL_CODE>" & vbCrLf
                lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<ADDRESS1><![CDATA[" & dt_cliente(0).calle & "]]></ADDRESS1>" & vbCrLf
                lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<ADDRESS2><![CDATA[" & dt_cliente(0).numero & "]]></ADDRESS2>" & vbCrLf
                lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<ADDRESS3>" & "" & "</ADDRESS3>" & vbCrLf
                lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<ADDRESS4><![CDATA[" & lv_colonia & "]]></ADDRESS4>" & vbCrLf
                lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<POSTAL_CODE>" & lv_codigopostal & "</POSTAL_CODE>" & vbCrLf
                lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<CITY><![CDATA[" & lv_ciudad & "]]></CITY>" & vbCrLf
                lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<STATE><![CDATA[" & dt_cliente(0).estado & "]]></STATE>" & vbCrLf
                lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<COUNTRY><![CDATA[" & "México" & "]]></COUNTRY>" & vbCrLf

                Select Case dt_header(0).metodopago
                    Case "EFECTIVO"
                        lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<METODO_PAGO>" & "1" & "</METODO_PAGO>" & vbCrLf
                    Case "CHEQUE"
                        lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<METODO_PAGO>" & "2" & "</METODO_PAGO>" & vbCrLf
                    Case "TRANSFERENCIA"
                        lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<METODO_PAGO>" & "3" & "</METODO_PAGO>" & vbCrLf
                End Select

                Select Case dt_header(0).tipo_venta
                    Case "CONTADO"
                        lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<COND_PAGO>" & "1" & "</COND_PAGO>" & vbCrLf
                    Case "CREDITO"
                        lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<COND_PAGO>" & "2" & "</COND_PAGO>" & vbCrLf
                End Select

                lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<DIAS_PAGO>" & "0" & "</DIAS_PAGO>" & vbCrLf
                lv_cliente_02_ship_to = lv_cliente_02_ship_to & "<CODIGO_CLIENTE>" & dt_cliente(0).clave & "</CODIGO_CLIENTE>" & vbCrLf
                lv_cliente_02_ship_to = lv_cliente_02_ship_to & "</PARTY>" & vbCrLf
                lv_cliente_02_ship_to = lv_cliente_02_ship_to & "</SHIP_TO_CUSTOMER>"
            End If
        Catch exSql As SqlException
            MsgBox(exSql.Message, MsgBoxStyle.Critical, "ImprimeNotaDeCredito_CFDI Datos Cliente")
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ImprimeNotaDeCredito_CFDI Datos Cliente")
            Return False

        End Try

        'Fuera del índice
        Try
            Dim lv_factura As String = NumeroFactura
            Dim lv_fecha As String = Format(dt_header(0).fecha_venta, "MM/dd/yyyy")
            Dim lv_time As String = Format(Now.TimeOfDay.Hours, "00") & ":" & Format(Now.TimeOfDay.Minutes, "00") & ":" & Format(Now.TimeOfDay.Seconds, "00")
            Dim lv_full_date As String = lv_fecha & " " & lv_time

            Dim lv_subtotal As String = dt_header(0).total

            Dim lv_iva As String = dt_header(0).total * (FactorIVA - 1)

            Dim lv_total As String = Val(lv_subtotal) + Val(lv_iva)

            lv_documento_01 = "<?xml version='1.0'  encoding='UTF-8' ?>" & vbCrLf
            lv_documento_01 = lv_documento_01 & "<TRANSACTIONS>" & vbCrLf
            lv_documento_01 = lv_documento_01 & "<TRANSACTION>" & vbCrLf

            Select Case DB
                Case "Wendy"
                    lv_documento_01 = lv_documento_01 & "<SERIE>" & "XXX" & "</SERIE>" & vbCrLf
                Case "Librada"
                    lv_documento_01 = lv_documento_01 & "<SERIE>" & gv_SerieNCLibrada & "</SERIE>" & vbCrLf
                Case "Salvador"
                    lv_documento_01 = lv_documento_01 & "<SERIE>" & gv_SerieNCSalvador & "</SERIE>" & vbCrLf
            End Select

            lv_documento_01 = lv_documento_01 & "<TRX_NUMBER>" & Format(NumeroFactura, "000000") & "</TRX_NUMBER>" & vbCrLf
            lv_documento_01 = lv_documento_01 & "<CUST_TRX_TYPE_ID>" & "2" & "</CUST_TRX_TYPE_ID>" & vbCrLf
            lv_documento_01 = lv_documento_01 & "<TRX_DATE>" & lv_full_date & "</TRX_DATE>" & vbCrLf
            lv_documento_01 = lv_documento_01 & lv_cliente_02_bill_to & vbCrLf
            lv_documento_01 = lv_documento_01 & "<TIPO_MONEDA>" & "MXN" & "</TIPO_MONEDA>" & vbCrLf
            lv_documento_01 = lv_documento_01 & "<TASA_DE_CAMBIO>" & "1" & "</TASA_DE_CAMBIO>" & vbCrLf

            Select Case DB
                Case "Wendy"
                    lv_documento_01 = lv_documento_01 & "<SELLER_ID></SELLER_ID>" & vbCrLf
                Case "Librada"
                    lv_documento_01 = lv_documento_01 & "<SELLER_ID>" & "1120" & "</SELLER_ID>" & vbCrLf
                Case "Salvador"
                    lv_documento_01 = lv_documento_01 & "<SELLER_ID>" & "631" & "</SELLER_ID>" & vbCrLf
            End Select
            'lv_documento_01 = lv_documento_01 & "<BUYER_ID>" & dt_cliente(0).clave & "</BUYER_ID>" & vbCrLf

            Select Case DB
                Case "Wendy"
                    lv_documento_01 = lv_documento_01 & "<SHIP_FROM></SHIP_FROM>" & vbCrLf
                Case "Librada"
                    lv_documento_01 = lv_documento_01 & "<SHIP_FROM>" & "1121" & "</SHIP_FROM>" & vbCrLf
                Case "Salvador"
                    lv_documento_01 = lv_documento_01 & "<SHIP_FROM>" & "632" & "</SHIP_FROM>" & vbCrLf
            End Select
            'lv_documento_01 = lv_documento_01 & "<SHIP_TO>" & dt_cliente(0).clave & "</SHIP_TO>" & vbCrLf
            lv_documento_01 = lv_documento_01 & "<ACCOUNT_NUMBER>" & "NO IDENTIFICADO" & "</ACCOUNT_NUMBER>" & vbCrLf
            lv_documento_01 = lv_documento_01 & lv_cliente_02_ship_to & vbCrLf
            lv_documento_01 = lv_documento_01 & "<PEDIDO>" & Format(NumeroFactura, "000000") & "</PEDIDO>" & vbCrLf
            lv_documento_01 = lv_documento_01 & "<FECHA_PEDIDO>" & lv_full_date & "</FECHA_PEDIDO>" & vbCrLf
            lv_documento_01 = lv_documento_01 & "<STATUS_FACTURA>" & "1" & "</STATUS_FACTURA>" & vbCrLf
            lv_documento_01 = lv_documento_01 & "<FEC_VENC_FACT />" & vbCrLf
            lv_documento_01 = lv_documento_01 & "<TRANSACTION_LINES>"

            lv_concepto_04 = ""

            For i = 0 To dt_detail.LongCount - 1
                Console.WriteLine("Largo: " & dt_detail.LongCount.ToString & "N: " & i.ToString)
                Using ctx As New pv_salvadorEntities1
                    'dt_productos = ctx.productos.Where(Function(ind) ind.IdProducto = dt_detail(0).idProducto).ToList
                    Console.WriteLine(dt_productos.LongCount.ToString)
                End Using
                'Try
                '    Select Case DB
                '        Case "Wendy"
                '            SqlDataAdapter = New SqlDataAdapter("SELECT * FROM productos WHERE idProducto = " & dt_detail(0).idProducto, gv_ConStringWendy)
                '        Case "Librada"
                '            SqlDataAdapter = New SqlDataAdapter("SELECT * FROM productos WHERE idProducto = " & dt_detail(0).idProducto, gv_ConStringLibrada)
                '        Case "Salvador"
                '            SqlDataAdapter = New SqlDataAdapter("SELECT * FROM productos WHERE idProducto = " & dt_detail(0).idProducto, gv_ConStringSalvador)
                '    End Select
                '
                '    Dim SqlCommandBuilder As New SqlCommandBuilder(SqlDataAdapter)
                '
                '    ' llenar el DataTable   
                '    dt_productos.Clear()
                '    dt_productos.Dispose()
                '    dt_productos.Reset()
                '    dt_productos = New DataTable
                '    SqlDataAdapter.Fill(dt_productos)
                '
                'Catch exSql As SqlException
                '    MsgBox(exSql.Message, MsgBoxStyle.Critical, "ImprimeFactura dt_productos")
                '    Return False
                'Catch ex As Exception
                '    MsgBox(ex.Message, MsgBoxStyle.Critical, "ImprimeFactura dt_productos")
                '    Return False
                'End Try
                lv_concepto_04 = lv_concepto_04 & "<TRANSACTION_LINE>" & vbCrLf
                lv_concepto_04 = lv_concepto_04 & "<LINE_NUMBER>" & i + 1 & "</LINE_NUMBER>" & vbCrLf
                lv_concepto_04 = lv_concepto_04 & "<LINE_TYPE>" & "LINE" & "</LINE_TYPE>" & vbCrLf
                lv_concepto_04 = lv_concepto_04 & "<INVENTORY_ITEM_ID>" & dt_detail(0).idProducto & "</INVENTORY_ITEM_ID>" & vbCrLf
                lv_concepto_04 = lv_concepto_04 & "<ITEM_EAN_NUMBER />" & vbCrLf
                lv_concepto_04 = lv_concepto_04 & "<SERIAL />" & vbCrLf
                lv_concepto_04 = lv_concepto_04 & "<DESCRIPTION><![CDATA[" & dt_detail(0).descripcion & "]]></DESCRIPTION>" & vbCrLf
                lv_concepto_04 = lv_concepto_04 & "<QUANTITY_INVOICED>" & dt_detail(0).cantidad.ToString & "</QUANTITY_INVOICED>" & vbCrLf
                lv_concepto_04 = lv_concepto_04 & "<QUANTITY_CREDITED>" & "</QUANTITY_CREDITED>" & vbCrLf
                lv_concepto_04 = lv_concepto_04 & "<UNIT_SELLING_PRICE>" & dt_detail(0).precio.ToString & "</UNIT_SELLING_PRICE>" & vbCrLf

                If dt_productos.LongCount > 0 Then
                    lv_concepto_04 = lv_concepto_04 & "<UOM_CODE>" & dt_productos(0).unidadMedida & "</UOM_CODE>" & vbCrLf
                Else
                    lv_concepto_04 = lv_concepto_04 & "<UOM_CODE>" & "PIEZA" & "</UOM_CODE>" & vbCrLf
                End If

                lv_concepto_04 = lv_concepto_04 & "<TAX_RATE>" & (FactorIVA - 1) * 100 & "</TAX_RATE>" & vbCrLf
                lv_concepto_04 = lv_concepto_04 & "<TAXABLE_AMOUNT>" & (dt_detail(0).subtotal * (FactorIVA - 1)).ToString & "</TAXABLE_AMOUNT>" & vbCrLf
                lv_concepto_04 = lv_concepto_04 & "<PRECIO_NETO>" & dt_detail(0).subtotal.ToString & "</PRECIO_NETO>" & vbCrLf
                lv_concepto_04 = lv_concepto_04 & "<DESCUENTO/>" & vbCrLf
                lv_concepto_04 = lv_concepto_04 & "<VAT_TAX_ID>1</VAT_TAX_ID>" & vbCrLf
                lv_concepto_04 = lv_concepto_04 & "</TRANSACTION_LINE>" & vbCrLf

            Next i
            lv_documento_01 = lv_documento_01 & vbCrLf & lv_concepto_04
            lv_documento_01 = lv_documento_01 & "</TRANSACTION_LINES>" & vbCrLf
            lv_documento_01 = lv_documento_01 & "<ADDENDA TYPE=""NONE""/>" & vbCrLf
            lv_documento_01 = lv_documento_01 & "<COMPLEMENTO TYPE=""NONE"" />" & vbCrLf
            lv_documento_01 = lv_documento_01 & "</TRANSACTION>" & vbCrLf
            lv_documento_01 = lv_documento_01 & "</TRANSACTIONS>"

            lv_documento_01.Replace("Ñ", "&#x00D1;")
            lv_documento_01.Replace("ñ", "&#x00F1;")
            lv_documento_01.Replace("°", "&#x00B0;")
            lv_documento_01.Replace("Á", "&#x00C1;")
            lv_documento_01.Replace("É", "&#x00C9;")
            lv_documento_01.Replace("Í", "&#x00CD;")
            lv_documento_01.Replace("Ó", "&#x00D3;")
            lv_documento_01.Replace("Ú", "&#x00DA;")
            lv_documento_01.Replace("á", "&#x00E1;")
            lv_documento_01.Replace("é", "&#x00E9;")
            lv_documento_01.Replace("í", "&#x00ED;")
            lv_documento_01.Replace("ó", "&#x00F3;")
            lv_documento_01.Replace("ú", "&#x00FA;")

            Dim path As String = ""
            Select Case DB
                Case "Wendy"
                    path = gv_CDFI_XML_PATH & "XXX-" & Format(NumeroFactura, "000000") & "_" & Format(Now.Year, "00") & Format(Now.Month, "00") & Format(Now.Day, "00") & "(A-" & Format(CInt(FrmNotaDeCredito.TxtPedido_C.Text), "000000") & ")_CFDI.xml"
                Case "Librada"
                    path = gv_CDFI_XML_PATH & "C-" & Format(NumeroFactura, "000000") & "_" & Format(Now.Year, "00") & Format(Now.Month, "00") & Format(Now.Day, "00") & "(A-" & Format(CInt(FrmNotaDeCredito.TxtPedido_C.Text), "000000") & ")_CFDI.xml"
                Case "Salvador"
                    path = gv_CDFI_XML_PATH & "D-" & Format(NumeroFactura, "000000") & "_" & Format(Now.Year, "00") & Format(Now.Month, "00") & Format(Now.Day, "00") & "(A-" & FrmNotaDeCredito.TxtPedido_C.Text & ")_CFDI.xml"
            End Select
            Console.WriteLine(path)
            ' This text is added only once to the file. 
            If File.Exists(path) = False Then
                ' Create a file to write to. 
                File.WriteAllText(path, lv_documento_01)
            Else
                File.Delete(path)
                File.WriteAllText(path, lv_documento_01)
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ImprimeNotaDeCredito_CFDI Genera Reporte Local")
            Return False
        End Try

    End Function

    Public Function DisplayNode(ByRef Nodes As MSXML2.IXMLDOMNodeList) As String
        Dim xNode As MSXML2.IXMLDOMNode
        For Each xNode In Nodes
            If xNode.parentNode.nodeName = "exito" Then
                If xNode.nodeValue = "0" Then
                    lv_mensaje = lv_mensaje & "Hubo un error." & lv_enter
                    lv_exitoRet = 0
                Else
                    lv_mensaje = lv_mensaje & "Factura generada correctamente en el Portal Web." & lv_enter
                    lv_exitoRet = 1
                End If
            End If
            If lv_exitoRet = 0 Then
                If xNode.parentNode.nodeName = "codigo" Then
                    lv_mensaje = lv_mensaje & "Codigo Error: " & xNode.nodeValue & lv_enter
                End If
                If xNode.parentNode.nodeName = "descripcion" Then
                    lv_mensaje = lv_mensaje & "Descripción: " & xNode.nodeValue & lv_enter
                End If
            End If
            If xNode.hasChildNodes Then
                DisplayNode(xNode.childNodes)
            End If
        Next xNode
        Return lv_mensaje
    End Function

    'Public Function Insertar_Registro(ByRef sql As String, ByVal DB As String) As Boolean
    '    Dim SQLConnection As SqlConnection = New SqlConnection

    '    SQLConnection = New SqlConnection()
    '    Select Case DB
    '        Case "Wendy"
    '            SQLConnection.ConnectionString = gv_ConStringWendy
    '        Case "Librada"
    '            SQLConnection.ConnectionString = gv_ConStringLibrada
    '        Case "Salvador"
    '            SQLConnection.ConnectionString = gv_ConStringSalvador
    '    End Select

    '    Dim sqlCommand As New SqlCommand
    '    Try
    '        SQLConnection.Open()
    '        sqlCommand.Connection = SQLConnection
    '        sqlCommand.CommandText = sql
    '        sqlCommand.ExecuteNonQuery()
    '        SQLConnection.Close()
    '        Return True
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function

    Public Function ConvertGenericListToDataTable(ByVal genericList As Object) As DataTable

        Dim dataTable As Data.DataTable = Nothing
        Dim listType As Type = genericList.GetType()

        If (listType.IsGenericType AndAlso (genericList IsNot Nothing)) Then

            '//determine the underlying type the List<> contains
            Dim elementType As Type = listType.GetGenericArguments()(0)

            '//create empty table -- give it a name in case
            '//it needs to be serialized
            dataTable = New Data.DataTable(elementType.Name + "List")

            '//define the table -- add a column for each public
            '//property or field
            Dim memberInfos As MemberInfo() = elementType.GetMembers(BindingFlags.Public Or BindingFlags.Instance)
            For Each memberInfo As MemberInfo In memberInfos

                If (memberInfo.MemberType = MemberTypes.Property) Then

                    Dim propertyInfo As PropertyInfo = CType(memberInfo, PropertyInfo)

                    If IsNullableType(propertyInfo.PropertyType) Then
                        dataTable.Columns.Add(propertyInfo.Name, New ComponentModel.NullableConverter(propertyInfo.PropertyType).UnderlyingType)
                    Else
                        dataTable.Columns.Add(propertyInfo.Name, propertyInfo.PropertyType)
                    End If
                ElseIf (memberInfo.MemberType = MemberTypes.Field) Then
                    Dim fieldInfo As FieldInfo = CType(memberInfo, FieldInfo)
                    dataTable.Columns.Add(fieldInfo.Name, fieldInfo.FieldType)
                End If
            Next

            '//populate the table
            Dim listData As IList = CType(genericList, IList)
            For Each record As Object In listData
                Dim index As Integer = 0
                Dim fieldValues(dataTable.Columns.Count - 1) As Object ' = CType(New Object(), Object())
                For Each columnData As Data.DataColumn In dataTable.Columns
                    Dim memberInfo As MemberInfo = elementType.GetMember(columnData.ColumnName)(0)
                    If memberInfo.MemberType = MemberTypes.Property Then
                        Dim propertyInfo As PropertyInfo = CType(memberInfo, PropertyInfo)
                        fieldValues(index) = propertyInfo.GetValue(record, Nothing)
                    ElseIf memberInfo.MemberType = MemberTypes.Field Then
                        Dim fieldInfo As FieldInfo = CType(memberInfo, FieldInfo)
                        fieldValues(index) = fieldInfo.GetValue(record)
                    End If
                    index += 1
                Next
                dataTable.Rows.Add(fieldValues)
            Next

        End If

        Return dataTable
    End Function

    Private Function IsNullableType(ByVal propertyType As Type) As Boolean

        Return (propertyType.IsGenericType) AndAlso (propertyType.GetGenericTypeDefinition() Is GetType(Nullable(Of )))

    End Function

    Public Function ImprimeVenta(ByVal NumeroVenta As String, ByVal Imprimir As Boolean, ByVal TipoVenta As String, ByVal Paga As String, ByVal Cambio As String) As Boolean
        Dim dt_header As DataTable = New DataTable
        Dim dt_detail As DataTable = New DataTable
        Dim dt_cliente As DataTable = New DataTable

        Dim header_ventapedido As New tblVentaPedido
        Dim header_ventapedido_t As New List(Of tblVentaPedido)
        Dim detail_ventapedido As New List(Of tblTicketPedido)

        Dim header_venta As New tblVenta
        Dim header_venta_t As New List(Of tblVenta)
        Dim detail_venta As New List(Of tblTicket)

        Dim strCliente As New tblClientes
        Dim tblClient As New List(Of tblClientes)

        Dim Report As New LocalReport

        dt_header.Clear()
        dt_header.Dispose()
        dt_header.Reset()
        dt_header = New DataTable

        dt_detail.Clear()
        dt_detail.Dispose()
        dt_detail.Reset()
        dt_detail = New DataTable

        dt_cliente.Clear()
        dt_cliente.Dispose()
        dt_cliente.Reset()
        dt_cliente = New DataTable

        header_ventapedido_t.Clear()
        header_venta_t.Clear()
        tblClient.Clear()

        Select Case TipoVenta
            Case "PEDIDO"
                header_ventapedido = DBModelo.Get_PV_PedidosHeader(NumeroVenta)
                If Not IsNothing(header_ventapedido) Then
                    header_ventapedido_t.Add(header_ventapedido)
                    dt_header = ConvertGenericListToDataTable(header_ventapedido_t)
                End If
                detail_ventapedido = DBModelo.Get_PV_PedidosDetalle(NumeroVenta)
                If Not IsNothing(detail_ventapedido) Then
                    dt_detail = ConvertGenericListToDataTable(detail_ventapedido)
                End If
            Case "TICKET"
                header_venta = DBModelo.Get_PV_TicketHeader(NumeroVenta)
                If Not IsNothing(header_venta) Then
                    header_venta_t.Add(header_venta)
                    dt_header = ConvertGenericListToDataTable(header_venta_t)
                End If
                detail_venta = DBModelo.Get_PV_TicketsDetalle(NumeroVenta)
                If Not IsNothing(detail_venta) Then
                    dt_detail = ConvertGenericListToDataTable(detail_venta)
                End If
        End Select

        Try
            Select Case dt_header.Rows(0)!tipo
                Case "CONTADO"
                    dt_detail.TableName = "ticket"
                    Dim p2 As New ReportParameter("Nombre", Nombre)
                    Dim p3 As New ReportParameter("Propietario", Propietario)
                    Dim p4 As New ReportParameter("RFC", RFC)
                    Dim p5 As New ReportParameter("Domicilio", Domicilio)
                    Dim p6 As New ReportParameter("Colonia", Colonia)
                    Dim p7 As New ReportParameter("Telefono", Telefono)
                    Dim p8 As New ReportParameter("Ciudad", Ciudad)

                    'obtener ticket'
                    Dim p9 As New ReportParameter("Ticket", NumeroVenta)

                    'obtener fecha'
                    Dim lv_fecha As String = dt_header.Rows(0)!fecha
                    Dim p10 As New ReportParameter("Fecha", lv_fecha.ToString)

                    'obtener total'
                    Dim lv_total As String = Format(dt_header.Rows(0)!total, "$ ###,###,###.00")
                    Dim p11 As New ReportParameter("Total", lv_total.ToString)

                    'obtener pago'
                    Dim lv_paga_tmp As Double = Paga
                    Dim lv_paga As String = Format(lv_paga_tmp, "$ ###,###,##0.00")
                    Dim p12 As New ReportParameter("Paga", lv_paga)

                    'dinero a letra'
                    Dim lv_dinero As String = Dinero(dt_header.Rows(0)!total, 2, "Pesos", True)
                    Dim p13 As New ReportParameter("Dinero", lv_dinero.ToUpper)

                    'usuario'
                    Dim lv_usuario As String = dt_header.Rows(0)!usuario
                    Dim p14 As New ReportParameter("Atendido", lv_usuario.ToString)

                    Dim p15 As New ReportParameter("TipoDocumento", TipoVenta)

                    Cambio = Replace(Cambio, "$", "")
                    Cambio = Replace(Cambio, " ", "")
                    Dim lv_cambio_tmp As Double = Cambio
                    Dim lv_cambio As String = Format(lv_cambio_tmp, "$ ###,###,##0.00")
                    Dim p16 As New ReportParameter("Cambio", lv_cambio.ToString)
                    Dim p17 As New ReportParameter("OriginalCopia", "ORIGINAL")

                    Dim lv_iva As String = Format(dt_header.Rows(0)!iva, "$ ###,###,###.00")
                    Dim p19 As New ReportParameter("IVA", lv_iva.ToString)

                    Report.ReportPath = gv_Report_Path & "Report2.rdlc"

                    Report.SetParameters(p2)
                    Report.SetParameters(p3)
                    Report.SetParameters(p4)
                    Report.SetParameters(p5)
                    Report.SetParameters(p6)
                    Report.SetParameters(p7)
                    Report.SetParameters(p8)
                    Report.SetParameters(p9)
                    Report.SetParameters(p10)
                    Report.SetParameters(p11)
                    Report.SetParameters(p12)
                    Report.SetParameters(p13)
                    Report.SetParameters(p14)
                    Report.SetParameters(p15)
                    Report.SetParameters(p16)
                    Report.SetParameters(p17)
                    Report.SetParameters(p19)

                    Report.DataSources.Clear()
                    Report.DataSources.Add(New ReportDataSource("DataSet1", dt_detail))
                    Print_Report(TicketPrinterName, Report, 1, "Pdf", NumeroVenta + "_" + dt_header.Rows(0)!tipo + "_ORIGINAL", "C:\Tickets\" + Now.Year.ToString, "VENTA")
                    If Imprimir = True Then
                        Print_Report(TicketPrinterName, Report, 1, "Image", NumeroVenta + "_" + dt_header.Rows(0)!tipo + "_ORIGINAL", "C:\Tickets\" + Now.Year.ToString, "VENTA")
                    End If

                    Dim p18 As New ReportParameter("OriginalCopia", "COPIA CLIENTE")
                    Report.SetParameters(p18)

                    Print_Report(TicketPrinterName, Report, 1, "Pdf", NumeroVenta + "_" + dt_header.Rows(0)!tipo + "_COPIA", "C:\Tickets\" + Now.Year.ToString, "VENTA")
                    If Imprimir = True Then
                        Print_Report(TicketPrinterName, Report, 1, "Image", NumeroVenta + "_" + dt_header.Rows(0)!tipo + "_COPIA", "C:\Tickets\" + Now.Year.ToString, "VENTA")
                    End If

                Case "CREDITO"

                    strCliente = DBModelo.GetCliente(dt_header.Rows(0)!idcliente)
                    If Not IsNothing(strCliente) Then
                        tblClient.Add(strCliente)
                        dt_cliente = ConvertGenericListToDataTable(tblClient)
                    End If

                    Dim lv_nombre As String = ""
                    Dim lv_direccion As String = ""
                    Dim lv_colonia As String = ""
                    Dim lv_codigopostal As String = ""
                    Dim lv_ciudad As String = ""
                    Dim lv_rfc As String = ""


                    If dt_cliente.Rows.Count > 0 Then
                        If dt_cliente.Rows(0)!nombre <> "" Or dt_cliente.Rows(0)!apat <> "" Or dt_cliente.Rows(0)!amat <> "" Then
                            lv_nombre = dt_cliente.Rows(0)!nombre & " " & dt_cliente.Rows(0)!apat & " " & dt_cliente.Rows(0)!amat
                        End If
                        If dt_cliente.Rows(0)!calle <> "" Then
                            lv_direccion = dt_cliente.Rows(0)!calle
                            If dt_cliente.Rows(0)!numero <> "" Then
                                lv_direccion = lv_direccion & " #" & dt_cliente.Rows(0)!numero
                            End If
                        Else
                            lv_direccion = " "
                        End If
                        If dt_cliente.Rows(0)!colonia <> "" Then
                            lv_colonia = dt_cliente.Rows(0)!colonia
                        Else
                            lv_colonia = " "
                        End If
                        If dt_cliente.Rows(0)!cp <> "" Then
                            lv_codigopostal = dt_cliente.Rows(0)!cp
                        Else
                            lv_codigopostal = " "
                        End If
                        If dt_cliente.Rows(0)!ciudad <> "" Then
                            lv_ciudad = dt_cliente.Rows(0)!ciudad
                        Else
                            lv_ciudad = " "
                        End If
                        If dt_cliente.Rows(0)!rfc <> "" Then
                            lv_rfc = dt_cliente.Rows(0)!rfc
                        Else
                            lv_rfc = " "
                        End If
                    End If
                    dt_detail.TableName = "ticket"
                    Dim p2 As New ReportParameter("Nombre", Nombre)
                    Dim p3 As New ReportParameter("Propietario", Propietario)
                    Dim p4 As New ReportParameter("RFC", RFC)
                    Dim p5 As New ReportParameter("Domicilio", Domicilio)
                    Dim p6 As New ReportParameter("Colonia", Colonia)
                    Dim p7 As New ReportParameter("Telefono", Telefono)
                    Dim p8 As New ReportParameter("Ciudad", Ciudad)

                    'obtener ticket'
                    Dim p9 As New ReportParameter("Ticket", NumeroVenta)

                    'obtener fecha'
                    Dim lv_fecha As String = dt_header.Rows(0)!fecha
                    Dim p10 As New ReportParameter("Fecha", lv_fecha.ToString)

                    'obtener total'
                    Dim lv_total As String = Format(dt_header.Rows(0)!total, "$ ###,###,##0.00")
                    Dim p11 As New ReportParameter("Total", lv_total.ToString)

                    Dim p12 As New ReportParameter("CopiaOriginal", "ORIGINAL")

                    'dinero a letra'
                    Dim lv_dinero As String = Dinero(dt_header.Rows(0)!total, 2, "Pesos", True)
                    Dim p13 As New ReportParameter("Dinero", lv_dinero.ToUpper)

                    'usuario'
                    Dim lv_usuario As String = dt_header.Rows(0)!usuario
                    Dim p14 As New ReportParameter("Atendido", lv_usuario.ToString)

                    Dim p15 As New ReportParameter("TipoDocumento", TipoVenta)

                    Dim p16 As New ReportParameter("Cliente", lv_nombre)

                    'obtener total'
                    Dim lv_iva As String = Format(dt_header.Rows(0)!iva, "$ ###,###,##0.00")
                    Dim p19 As New ReportParameter("IVA", lv_iva.ToString)

                    Dim lvDeuda As Double = DBModelo.Get_PV_Cliente_SUM(dt_header.Rows(0)!idcliente)

                    Dim p17 As New ReportParameter("Deuda", Format(lvDeuda, "$ ###,###,##0.00"))

                    Report.ReportPath = gv_Report_Path & "Report3.rdlc"

                    Report.SetParameters(p2)
                    Report.SetParameters(p3)
                    Report.SetParameters(p4)
                    Report.SetParameters(p5)
                    Report.SetParameters(p6)
                    Report.SetParameters(p7)
                    Report.SetParameters(p8)
                    Report.SetParameters(p9)
                    Report.SetParameters(p10)
                    Report.SetParameters(p11)
                    Report.SetParameters(p12)
                    Report.SetParameters(p13)
                    Report.SetParameters(p14)
                    Report.SetParameters(p15)
                    Report.SetParameters(p16)
                    Report.SetParameters(p17)
                    Report.SetParameters(p19)

                    Report.DataSources.Clear()
                    Report.DataSources.Add(New ReportDataSource("DataSet1", dt_detail))
                    Print_Report(TicketPrinterName, Report, 1, "Pdf", NumeroVenta + " " + dt_header.Rows(0)!tipo + " ORIGINAL", "C:\Tickets\" + Now.Year.ToString, "VENTA")
                    If Imprimir = True Then
                        Print_Report(TicketPrinterName, Report, 1, "Image", NumeroVenta + " " + dt_header.Rows(0)!tipo + " ORIGINAL", "C:\Tickets\" + Now.Year.ToString, "VENTA")
                    End If

                    Dim p18 As New ReportParameter("CopiaOriginal", "COPIA CLIENTE")
                    Report.SetParameters(p18)

                    Print_Report(TicketPrinterName, Report, 1, "Pdf", NumeroVenta + " " + dt_header.Rows(0)!tipo + " COPIA", "C:\Tickets\" + Now.Year.ToString, "VENTA")
                    If Imprimir = True Then
                        Print_Report(TicketPrinterName, Report, 1, "Image", NumeroVenta + " " + dt_header.Rows(0)!tipo + " COPIA", "C:\Tickets\" + Now.Year.ToString, "VENTA")
                    End If
            End Select

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function ReImprimeVenta(ByVal NumeroVenta As String, ByVal Imprimir As Boolean, ByVal TipoVenta As String, ByVal Paga As String, ByVal Cambio As String) As Boolean
        Dim dt_header As DataTable = New DataTable
        Dim dt_detail As DataTable = New DataTable
        Dim dt_cliente As DataTable = New DataTable

        Dim header_ventapedido As New tblVentaPedido
        Dim header_ventapedido_t As New List(Of tblVentaPedido)
        Dim detail_ventapedido As New List(Of tblTicketPedido)

        Dim header_venta As New tblVenta
        Dim header_venta_t As New List(Of tblVenta)
        Dim detail_venta As New List(Of tblTicket)

        Dim strCliente As New tblClientes
        Dim tblClient As New List(Of tblClientes)

        Dim Report As New LocalReport

        dt_header.Clear()
        dt_header.Dispose()
        dt_header.Reset()
        dt_header = New DataTable

        dt_detail.Clear()
        dt_detail.Dispose()
        dt_detail.Reset()
        dt_detail = New DataTable

        dt_cliente.Clear()
        dt_cliente.Dispose()
        dt_cliente.Reset()
        dt_cliente = New DataTable

        header_ventapedido_t.Clear()
        header_venta_t.Clear()
        tblClient.Clear()

        Select Case TipoVenta
            Case "PEDIDO"
                header_ventapedido = DBModelo.Get_PV_PedidosHeader(NumeroVenta)
                If Not IsNothing(header_ventapedido) Then
                    header_ventapedido_t.Add(header_ventapedido)
                    dt_header = ConvertGenericListToDataTable(header_ventapedido_t)
                End If
                detail_ventapedido = DBModelo.Get_PV_PedidosDetalle(NumeroVenta)
                If Not IsNothing(detail_ventapedido) Then
                    dt_detail = ConvertGenericListToDataTable(detail_ventapedido)
                End If
            Case "TICKET"
                header_venta = DBModelo.Get_PV_TicketHeader(NumeroVenta)
                If Not IsNothing(header_venta) Then
                    header_venta_t.Add(header_venta)
                    dt_header = ConvertGenericListToDataTable(header_venta_t)
                End If
                detail_venta = DBModelo.Get_PV_TicketsDetalle(NumeroVenta)
                If Not IsNothing(detail_venta) Then
                    dt_detail = ConvertGenericListToDataTable(detail_venta)
                End If
        End Select

        Try
            Select Case dt_header.Rows(0)!tipo
                Case "CONTADO"
                    dt_detail.TableName = "ticket"
                    Dim p2 As New ReportParameter("Nombre", Nombre)
                    Dim p3 As New ReportParameter("Propietario", Propietario)
                    Dim p4 As New ReportParameter("RFC", RFC)
                    Dim p5 As New ReportParameter("Domicilio", Domicilio)
                    Dim p6 As New ReportParameter("Colonia", Colonia)
                    Dim p7 As New ReportParameter("Telefono", Telefono)
                    Dim p8 As New ReportParameter("Ciudad", Ciudad)

                    'obtener ticket'
                    Dim p9 As New ReportParameter("Ticket", NumeroVenta)

                    'obtener fecha'
                    Dim lv_fecha As String = dt_header.Rows(0)!fecha
                    Dim p10 As New ReportParameter("Fecha", lv_fecha.ToString)

                    'obtener total'
                    Dim lv_total As String = Format(dt_header.Rows(0)!total, "$ ###,###,###.00")
                    Dim p11 As New ReportParameter("Total", lv_total.ToString)

                    'obtener pago'
                    Dim lv_paga_tmp As Double = "0.00"
                    Dim lv_paga As String = Format(lv_paga_tmp, "$ ###,###,##0.00")
                    Dim p12 As New ReportParameter("Paga", lv_paga)

                    'dinero a letra'
                    Dim lv_dinero As String = Dinero(dt_header.Rows(0)!total, 2, "Pesos", True)
                    Dim p13 As New ReportParameter("Dinero", lv_dinero.ToUpper)

                    'usuario'
                    Dim lv_usuario As String = dt_header.Rows(0)!usuario
                    Dim p14 As New ReportParameter("Atendido", lv_usuario.ToString)

                    Dim p15 As New ReportParameter("TipoDocumento", TipoVenta)

                    Dim lv_cambio_tmp As Double = "0.00"
                    Dim lv_cambio As String = Format(lv_cambio_tmp, "$ ###,###,##0.00")
                    Dim p16 As New ReportParameter("Cambio", lv_cambio.ToString)
                    Dim p17 As New ReportParameter("OriginalCopia", "ORIGINAL")

                    Dim lv_iva As String = Format(dt_header.Rows(0)!iva, "$ ###,###,###.00")
                    Dim p19 As New ReportParameter("IVA", lv_iva.ToString)

                    Report.ReportPath = gv_Report_Path & "Report2.rdlc"

                    Report.SetParameters(p2)
                    Report.SetParameters(p3)
                    Report.SetParameters(p4)
                    Report.SetParameters(p5)
                    Report.SetParameters(p6)
                    Report.SetParameters(p7)
                    Report.SetParameters(p8)
                    Report.SetParameters(p9)
                    Report.SetParameters(p10)
                    Report.SetParameters(p11)
                    Report.SetParameters(p12)
                    Report.SetParameters(p13)
                    Report.SetParameters(p14)
                    Report.SetParameters(p15)
                    Report.SetParameters(p16)
                    Report.SetParameters(p17)
                    Report.SetParameters(p19)

                    Report.DataSources.Clear()
                    Report.DataSources.Add(New ReportDataSource("DataSet1", dt_detail))

                    Dim p18 As New ReportParameter("OriginalCopia", "COPIA CLIENTE")
                    Report.SetParameters(p18)

                    Print_Report(TicketPrinterName, Report, 1, "Pdf", NumeroVenta + "_" + dt_header.Rows(0)!tipo + "_COPIA", "C:\Tickets\" + Now.Year.ToString, "VENTA")
                    If Imprimir = True Then
                        Print_Report(TicketPrinterName, Report, 1, "Image", NumeroVenta + "_" + dt_header.Rows(0)!tipo + "_COPIA", "C:\Tickets\" + Now.Year.ToString, "VENTA")
                    End If

                Case "CREDITO"

                    strCliente = DBModelo.GetCliente(dt_header.Rows(0)!idcliente)
                    If Not IsNothing(strCliente) Then
                        tblClient.Add(strCliente)
                        dt_cliente = ConvertGenericListToDataTable(tblClient)
                    End If

                    Dim lv_nombre As String = ""
                    Dim lv_direccion As String = ""
                    Dim lv_colonia As String = ""
                    Dim lv_codigopostal As String = ""
                    Dim lv_ciudad As String = ""
                    Dim lv_rfc As String = ""

                    If dt_cliente.Rows.Count > 0 Then
                        If dt_cliente.Rows(0)!nombre <> "" Or dt_cliente.Rows(0)!apat <> "" Or dt_cliente.Rows(0)!amat <> "" Then
                            lv_nombre = dt_cliente.Rows(0)!nombre & " " & dt_cliente.Rows(0)!apat & " " & dt_cliente.Rows(0)!amat
                        End If
                        If dt_cliente.Rows(0)!calle <> "" Then
                            lv_direccion = dt_cliente.Rows(0)!calle
                            If dt_cliente.Rows(0)!numero <> "" Then
                                lv_direccion = lv_direccion & " #" & dt_cliente.Rows(0)!numero
                            End If
                        Else
                            lv_direccion = " "
                        End If
                        If dt_cliente.Rows(0)!colonia <> "" Then
                            lv_colonia = dt_cliente.Rows(0)!colonia
                        Else
                            lv_colonia = " "
                        End If
                        If dt_cliente.Rows(0)!cp <> "" Then
                            lv_codigopostal = dt_cliente.Rows(0)!cp
                        Else
                            lv_codigopostal = " "
                        End If
                        If dt_cliente.Rows(0)!ciudad <> "" Then
                            lv_ciudad = dt_cliente.Rows(0)!ciudad
                        Else
                            lv_ciudad = " "
                        End If
                        If dt_cliente.Rows(0)!rfc <> "" Then
                            lv_rfc = dt_cliente.Rows(0)!rfc
                        Else
                            lv_rfc = " "
                        End If
                    End If
                    dt_detail.TableName = "ticket"
                    Dim p2 As New ReportParameter("Nombre", Nombre)
                    Dim p3 As New ReportParameter("Propietario", Propietario)
                    Dim p4 As New ReportParameter("RFC", RFC)
                    Dim p5 As New ReportParameter("Domicilio", Domicilio)
                    Dim p6 As New ReportParameter("Colonia", Colonia)
                    Dim p7 As New ReportParameter("Telefono", Telefono)
                    Dim p8 As New ReportParameter("Ciudad", Ciudad)

                    'obtener ticket'
                    Dim p9 As New ReportParameter("Ticket", NumeroVenta)

                    'obtener fecha'
                    Dim lv_fecha As String = dt_header.Rows(0)!fecha
                    Dim p10 As New ReportParameter("Fecha", lv_fecha.ToString)

                    'obtener total'
                    Dim lv_total As String = Format(dt_header.Rows(0)!total, "$ ###,###,##0.00")
                    Dim p11 As New ReportParameter("Total", lv_total.ToString)

                    Dim p12 As New ReportParameter("CopiaOriginal", "ORIGINAL")

                    'dinero a letra'
                    Dim lv_dinero As String = Dinero(dt_header.Rows(0)!total, 2, "Pesos", True)
                    Dim p13 As New ReportParameter("Dinero", lv_dinero.ToUpper)

                    'usuario'
                    Dim lv_usuario As String = dt_header.Rows(0)!usuario
                    Dim p14 As New ReportParameter("Atendido", lv_usuario.ToString)

                    Dim p15 As New ReportParameter("TipoDocumento", TipoVenta)

                    Dim p16 As New ReportParameter("Cliente", lv_nombre)

                    'obtener total'
                    Dim lv_iva As String = Format(dt_header.Rows(0)!iva, "$ ###,###,##0.00")
                    Dim p19 As New ReportParameter("IVA", lv_iva.ToString)

                    Dim lvDeuda As Double = DBModelo.Get_PV_Cliente_SUM(dt_header.Rows(0)!idcliente)

                    Dim p17 As New ReportParameter("Deuda", Format(lvDeuda, "$ ###,###,##0.00"))

                    Report.ReportPath = gv_Report_Path & "Report3.rdlc"

                    Report.SetParameters(p2)
                    Report.SetParameters(p3)
                    Report.SetParameters(p4)
                    Report.SetParameters(p5)
                    Report.SetParameters(p6)
                    Report.SetParameters(p7)
                    Report.SetParameters(p8)
                    Report.SetParameters(p9)
                    Report.SetParameters(p10)
                    Report.SetParameters(p11)
                    Report.SetParameters(p12)
                    Report.SetParameters(p13)
                    Report.SetParameters(p14)
                    Report.SetParameters(p15)
                    Report.SetParameters(p16)
                    Report.SetParameters(p17)
                    Report.SetParameters(p19)

                    Report.DataSources.Clear()
                    Report.DataSources.Add(New ReportDataSource("DataSet1", dt_detail))

                    Dim p18 As New ReportParameter("CopiaOriginal", "COPIA CLIENTE")
                    Report.SetParameters(p18)

                    Print_Report(TicketPrinterName, Report, 1, "Pdf", NumeroVenta + " " + dt_header.Rows(0)!tipo + " COPIA", "C:\Tickets\" + Now.Year.ToString, "VENTA")
                    If Imprimir = True Then
                        Print_Report(TicketPrinterName, Report, 1, "Image", NumeroVenta + " " + dt_header.Rows(0)!tipo + " COPIA", "C:\Tickets\" + Now.Year.ToString, "VENTA")
                    End If
            End Select

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function ImprimeCotizacion(ByVal NumeroVenta As String, ByVal Imprimir As Boolean, ByVal TipoVenta As String) As Boolean
        Dim dt_header As DataTable = New DataTable
        Dim dt_detail As DataTable = New DataTable
        Dim dt_cliente As DataTable = New DataTable

        Dim header As New tblCotizacion
        Dim header_t As New List(Of tblCotizacion)
        Dim detail As New List(Of tblTicketCotiza)

        Dim strCliente As New tblClientes
        Dim tblClient As New List(Of tblClientes)

        Dim lv_nombre As String = ""
        Dim lv_direccion As String = ""
        Dim lv_colonia As String = ""
        Dim lv_codigopostal As String = ""
        Dim lv_ciudad As String = ""
        Dim lv_rfc As String = ""
        Dim Report As New LocalReport

        dt_header.Clear()
        dt_header.Dispose()
        dt_header.Reset()

        dt_detail.Clear()
        dt_detail.Dispose()
        dt_detail.Reset()

        dt_cliente.Clear()
        dt_cliente.Dispose()
        dt_cliente.Reset()

        header_t.Clear()
        tblClient.Clear()

        header = DBModelo.Get_PV_CotizacionHeader(NumeroVenta)
        If Not IsNothing(header) Then
            header_t.Add(header)
            dt_header = ConvertGenericListToDataTable(header_t)
        End If
        detail = DBModelo.Get_PV_CotizacionDetalle(NumeroVenta)
        If Not IsNothing(detail) Then
            dt_detail = ConvertGenericListToDataTable(detail)
        End If

        strCliente = DBModelo.GetCliente(dt_header.Rows(0)!idcliente)
        If Not IsNothing(strCliente) Then
            tblClient.Add(strCliente)
            dt_cliente = ConvertGenericListToDataTable(tblClient)
        End If

        If dt_cliente.Rows.Count > 0 Then
            If dt_cliente.Rows(0)!nombre <> "" Or dt_cliente.Rows(0)!apat <> "" Or dt_cliente.Rows(0)!amat <> "" Then
                lv_nombre = dt_cliente.Rows(0)!nombre & " " & dt_cliente.Rows(0)!apat & " " & dt_cliente.Rows(0)!amat
            End If
            If dt_cliente.Rows(0)!calle <> "" Then
                lv_direccion = dt_cliente.Rows(0)!calle
                If dt_cliente.Rows(0)!numero <> "" Then
                    lv_direccion = lv_direccion & " #" & dt_cliente.Rows(0)!numero
                End If
            Else
                lv_direccion = " "
            End If
            If dt_cliente.Rows(0)!colonia <> "" Then
                lv_colonia = dt_cliente.Rows(0)!colonia
            Else
                lv_colonia = " "
            End If
            If dt_cliente.Rows(0)!cp <> "" Then
                lv_codigopostal = dt_cliente.Rows(0)!cp
            Else
                lv_codigopostal = " "
            End If
            If dt_cliente.Rows(0)!ciudad <> "" Then
                lv_ciudad = dt_cliente.Rows(0)!ciudad
            Else
                lv_ciudad = " "
            End If
            If dt_cliente.Rows(0)!rfc <> "" Then
                lv_rfc = dt_cliente.Rows(0)!rfc
            Else
                lv_rfc = " "
            End If
        End If

        Try
            Dim lv_iva_c As String = FormatCurrency(CDbl(dt_header.Rows(0)!iva), 2)
            Dim lv_total_c As String = FormatCurrency(CDbl(dt_header.Rows(0)!total), 2)

            dt_detail.TableName = "ticket_cotiza"
            Dim p2 As New ReportParameter("Nombre", Nombre)
            Dim p3 As New ReportParameter("Propietario", Propietario)
            Dim p4 As New ReportParameter("RFC", RFC)
            Dim p5 As New ReportParameter("Domicilio", Domicilio)
            Dim p6 As New ReportParameter("Colonia", Colonia)
            Dim p7 As New ReportParameter("Telefono", Telefono)
            Dim p8 As New ReportParameter("Cotizacion", NumeroVenta)
            Dim p9 As New ReportParameter("Fecha", Format(dt_header.Rows(0)!fecha, "dd/MM/yyyy"))
            Dim p10 As New ReportParameter("Nombrecliente", lv_nombre)
            Dim p11 As New ReportParameter("Domiciliocliente", lv_direccion + " " + lv_colonia + " " + lv_codigopostal)
            Dim p12 As New ReportParameter("cuidadcliente", lv_ciudad)
            Dim p13 As New ReportParameter("IVA", lv_iva_c)
            Dim p14 As New ReportParameter("TOTAL", lv_total_c)
            Dim lv_dinero As String = Dinero(dt_header.Rows(0)!total, 2, "Pesos", True)
            Dim p15 As New ReportParameter("dinero", lv_dinero.ToUpper)

            Report.ReportPath = gv_Report_Path & "Report1.rdlc"

            Report.SetParameters(p2)
            Report.SetParameters(p3)
            Report.SetParameters(p4)
            Report.SetParameters(p5)
            Report.SetParameters(p6)
            Report.SetParameters(p7)
            Report.SetParameters(p8)
            Report.SetParameters(p9)
            Report.SetParameters(p10)
            Report.SetParameters(p11)
            Report.SetParameters(p12)
            Report.SetParameters(p13)
            Report.SetParameters(p14)
            Report.SetParameters(p15)


            Report.DataSources.Clear()
            Report.DataSources.Add(New ReportDataSource("DataSet1", dt_detail))
            Print_Report(InvocePrinterName, Report, 1, "Pdf", NumeroVenta + " " + TipoVenta + " ORIGINAL", "C:\Cotizaciones\" + Now.Year.ToString, "COTIZACION")
            If Imprimir = True Then
                Print_Report(InvocePrinterName, Report, 1, "Image", NumeroVenta + " " + TipoVenta + " ORIGINAL", "C:\Cotizaciones\" + Now.Year.ToString, "COTIZACION")
            End If

            If dt_cliente.Rows(0)!correo <> "" Then
                If MsgBox("¿Enviar Cotización por Correo Electrónico?", MsgBoxStyle.YesNo, "Correo Electrónico") = MsgBoxResult.Yes Then
                    FrmCotizaciones.Cursor = Cursors.WaitCursor
                    If EnviarEmail("chavabautista@hotmail.com", dt_cliente.Rows(0)!correo, "Cotización", "Este correo es generado automáticamente por " + Nombre, "C:\Cotizaciones\" + Now.Year.ToString + "\" + NumeroVenta + " " + TipoVenta + " ORIGINAL_1.Pdf", "19720416") = True Then
                        FrmCotizaciones.Cursor = Cursors.Default
                        MsgBox("Correo Electrónico enviado correctamente.", MsgBoxStyle.Information, "Correo Electrónico")
                    Else
                        FrmCotizaciones.Cursor = Cursors.Default
                        MsgBox("Correo Electrónico no pudo ser enviado.", MsgBoxStyle.Critical, "Correo Electrónico")
                    End If
                    FrmCotizaciones.Cursor = Cursors.Default
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Return True
    End Function

    Public Function ImprimeProductosLista(ByVal Cliente As String, ByVal TipoPrecio As String, ByVal Linea As String, ByVal dt_detail As DataTable) As Boolean

        Try
            Dim Report As New LocalReport

            dt_detail.TableName = "ProductosLista"
            Dim p1 As New ReportParameter("Fecha", FormatDateTime(Now.Date, DateFormat.LongDate))
            Dim p2 As New ReportParameter("Hora", Format(Now.Hour, "00").ToString + ":" + Format(Now.Minute, "00").ToString + ":" + Format(Now.Second, "00").ToString + ":" + Format(Now.Millisecond, "00").ToString)
            Dim p3 As New ReportParameter("Precio", TipoPrecio)
            Dim p4 As New ReportParameter("Linea", Linea)

            Report.ReportPath = gv_Report_Path & "Report7.rdlc"

            Report.SetParameters(p1)
            Report.SetParameters(p2)
            Report.SetParameters(p3)
            Report.SetParameters(p4)

            Report.DataSources.Clear()
            Report.DataSources.Add(New ReportDataSource("DataSet1", dt_detail))
            Dim lv_filename As String = Format(Now.Date.Day, "00").ToString + Format(Now.Date.Month, "00").ToString + Format(Now.Date.Year, "0000").ToString + " " + Format(Now.Hour, "00").ToString + Format(Now.Minute, "00").ToString + Format(Now.Second, "00").ToString + Format(Now.Millisecond, "00").ToString + " ORIGINAL"
            Print_Report(InvocePrinterName, Report, 1, "Pdf", lv_filename, "C:\Listados\" + Now.Year.ToString, "LISTADOS")
            Print_Report(InvocePrinterName, Report, 1, "Image", lv_filename, "C:\Listados\" + Now.Year.ToString, "LISTADOS")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Return True
    End Function

    Public Function ConvertToDataTable(Of T)(ByVal list As IList(Of T)) As DataTable
        Dim table As New DataTable()
        Dim fields() As FieldInfo = GetType(T).GetFields()
        For Each field As FieldInfo In fields
            table.Columns.Add(field.Name, field.FieldType)
        Next
        For Each item As T In list
            Dim row As DataRow = table.NewRow()
            For Each field As FieldInfo In fields
                row(field.Name) = field.GetValue(item)
            Next
            table.Rows.Add(row)
        Next
        Return table
    End Function

    '-----------------------------------TICKET ABONOO------------------------------------------------------------------------
    Public Function ImprimeTicketAbono(ByVal NumeroTicket As String, ByVal Imprimir As Boolean, ByVal abono As String) As Boolean

        Dim dt_detail As DataTable = New DataTable

        Dim wCobrar As List(Of tblCobrar) = DBModelo.GetCobrarByIdCliente(idClienteVenta)

        ' llenar el DataTable   
        dt_detail.Clear()
        dt_detail.Dispose()
        dt_detail.Reset()
        dt_detail = New DataTable
        dt_detail = ConvertToDataTable(wCobrar)

        Try
            Dim Report As New LocalReport

            dt_detail.TableName = "cobrar"
            Dim p2 As New Microsoft.Reporting.WinForms.ReportParameter("Nombre", Nombre)
            Dim p3 As New Microsoft.Reporting.WinForms.ReportParameter("Propietario", Propietario)
            Dim p4 As New Microsoft.Reporting.WinForms.ReportParameter("RFC", RFC)
            Dim p5 As New Microsoft.Reporting.WinForms.ReportParameter("Domicilio", Domicilio)
            Dim p6 As New Microsoft.Reporting.WinForms.ReportParameter("Colonia", Colonia)
            Dim p7 As New Microsoft.Reporting.WinForms.ReportParameter("Telefono", Telefono)
            Dim p8 As New Microsoft.Reporting.WinForms.ReportParameter("Ciudad", Ciudad)
            Dim p9 As New Microsoft.Reporting.WinForms.ReportParameter("Fecha", DateTime.Now.ToShortDateString())


            Dim lv_dinero As String = Dinero(resto_total, 2, "Pesos", True)
            Dim p13 As New Microsoft.Reporting.WinForms.ReportParameter("Dinero", lv_dinero.ToUpper)

            Dim lv_abono As String = abono
            Dim p10 As New Microsoft.Reporting.WinForms.ReportParameter("abono", lv_abono)

            Dim lv_resto As String = resto_total
            Dim p11 As New Microsoft.Reporting.WinForms.ReportParameter("resto_total", lv_resto)

            Dim p12 As New Microsoft.Reporting.WinForms.ReportParameter("cuenta", NumeroTicket)

            Dim lv_cliente As String = cliente_abono
            Dim p14 As New Microsoft.Reporting.WinForms.ReportParameter("Cliente", lv_cliente)

            Dim lv_a As String = "admin"
            Dim p15 As New Microsoft.Reporting.WinForms.ReportParameter("Atendido", lv_a)

            Report.ReportPath = gv_Report_Path & "Report5.rdlc"

            Report.SetParameters(p2)
            Report.SetParameters(p3)
            Report.SetParameters(p4)
            Report.SetParameters(p5)
            Report.SetParameters(p6)
            Report.SetParameters(p7)
            Report.SetParameters(p8)
            Report.SetParameters(p9)
            Report.SetParameters(p10)
            Report.SetParameters(p11)
            Report.SetParameters(p12)
            Report.SetParameters(p13)
            Report.SetParameters(p14)
            Report.SetParameters(p15)


            Report.DataSources.Clear()
            Report.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt_detail))
            Dim lv_time As String = " " & Format(DateTime.Now.Hour, "00") & Format(DateTime.Now.Minute, "00") & Format(DateTime.Now.Second, "00")
            Print_Report(TicketPrinterName, Report, 1, "Pdf", NumeroTicket + " " + cliente_abono + lv_time, "C:\Abono\" + Now.Year.ToString, "VENTA")
            If Imprimir = True Then
                Print_Report(TicketPrinterName, Report, 1, "Image", NumeroTicket + " " + cliente_abono + lv_time, "C:\Abono\" + Now.Year.ToString, "VENTA")
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function ImprimeTicketAbonoWendy(ByVal NumeroTicket As String, ByVal Imprimir As Boolean, ByVal abono As String) As Boolean

        Dim dt_detail As DataTable = New DataTable

        Dim wCobrar As List(Of tblWCobrar) = DBModelo.GetCobrarByIdClienteWendy(idClienteVenta)
        Dim wConfiguracion As tblWConfiguracion = DBModelo.GetConfigurationWendy(gv_terminal)

        ' llenar el DataTable   
        dt_detail.Clear()
        dt_detail.Dispose()
        dt_detail.Reset()
        dt_detail = New DataTable
        dt_detail = ConvertToDataTable(wCobrar)

        Try
            Dim Report As New LocalReport

            dt_detail.TableName = "cobrar"
            Dim p2 As New Microsoft.Reporting.WinForms.ReportParameter("Nombre", wConfiguracion.nombreEmpresa)
            Dim p3 As New Microsoft.Reporting.WinForms.ReportParameter("Propietario", wConfiguracion.propietario)
            Dim p4 As New Microsoft.Reporting.WinForms.ReportParameter("RFC", wConfiguracion.rfcEmpresa)
            Dim p5 As New Microsoft.Reporting.WinForms.ReportParameter("Domicilio", wConfiguracion.direccionEmpresa)
            Dim p6 As New Microsoft.Reporting.WinForms.ReportParameter("Colonia", "Los Aguajes")
            Dim p7 As New Microsoft.Reporting.WinForms.ReportParameter("Telefono", wConfiguracion.telefonoEmpresa)
            Dim p8 As New Microsoft.Reporting.WinForms.ReportParameter("Ciudad", wConfiguracion.ciudadEmpresa)
            Dim p9 As New Microsoft.Reporting.WinForms.ReportParameter("Fecha", DateTime.Now.ToShortDateString())


            Dim lv_dinero As String = Dinero(resto_total, 2, "Pesos", True)
            Dim p13 As New Microsoft.Reporting.WinForms.ReportParameter("Dinero", lv_dinero.ToUpper)

            Dim lv_abono As String = abono
            Dim p10 As New Microsoft.Reporting.WinForms.ReportParameter("abono", lv_abono)

            Dim lv_resto As String = resto_total
            Dim p11 As New Microsoft.Reporting.WinForms.ReportParameter("resto_total", lv_resto)

            Dim p12 As New Microsoft.Reporting.WinForms.ReportParameter("cuenta", NumeroTicket)

            Dim lv_cliente As String = cliente_abono
            Dim p14 As New Microsoft.Reporting.WinForms.ReportParameter("Cliente", lv_cliente)

            Dim lv_a As String = "admin"
            Dim p15 As New Microsoft.Reporting.WinForms.ReportParameter("Atendido", lv_a)

            Report.ReportPath = gv_Report_Path & "Report5.rdlc"

            Report.SetParameters(p2)
            Report.SetParameters(p3)
            Report.SetParameters(p4)
            Report.SetParameters(p5)
            Report.SetParameters(p6)
            Report.SetParameters(p7)
            Report.SetParameters(p8)
            Report.SetParameters(p9)
            Report.SetParameters(p10)
            Report.SetParameters(p11)
            Report.SetParameters(p12)
            Report.SetParameters(p13)
            Report.SetParameters(p14)
            Report.SetParameters(p15)


            Report.DataSources.Clear()
            Report.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt_detail))
            Dim lv_time As String = " " & Format(DateTime.Now.Hour, "00") & Format(DateTime.Now.Minute, "00") & Format(DateTime.Now.Second, "00")
            Print_Report(TicketPrinterName, Report, 1, "Pdf", NumeroTicket + " " + cliente_abono + lv_time, "C:\Abono\" + Now.Year.ToString, "VENTA")
            If Imprimir = True Then
                Print_Report(TicketPrinterName, Report, 1, "Image", NumeroTicket + " " + cliente_abono + lv_time, "C:\Abono\" + Now.Year.ToString, "VENTA")
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Sub GenerarBackUp(ByVal FileName As String, ByVal Id As Integer)
        Try
            Dim startInfo As New ProcessStartInfo(gv_MySQLDump_Path)
            startInfo.WindowStyle = ProcessWindowStyle.Hidden
            startInfo.FileName = gv_MySQLDump_Path
            If Id = 1 Then
                startInfo.Arguments = gv_MySQLData + gv_MySQLBackUpPath + FileName
            End If
            If Id = 2 Then
                startInfo.Arguments = gv_MySQLDataLibrada + gv_MySQLBackUpPath + FileName
            End If
            If Id = 3 Then
                startInfo.Arguments = gv_MySQLDataWendy + gv_MySQLBackUpPath + FileName
            End If
            If Not Directory.Exists(gv_MySQLBackUpPath) Then
                Directory.CreateDirectory(gv_MySQLBackUpPath)
            End If
            Process.Start(startInfo)
        Catch ex As Exception
            lv_backup_error = 1
        End Try
    End Sub

    Public Function EnviarEmail(ByVal SendFrom As String, ByVal SendTo As String, ByVal Subject As String, ByVal Body As String, ByVal Filename As String, ByVal Password As String) As Boolean

        Dim AttachmentFile = New Attachment(Filename)
        Dim Smtp As SmtpClient = New SmtpClient("smtp.live.com")

        Dim myMessage As MailMessage

        Try
            Smtp.Port = "587"
            Smtp.UseDefaultCredentials = False
            Smtp.Credentials = New Net.NetworkCredential(SendFrom, Password)
            Smtp.EnableSsl = True
            myMessage = New MailMessage()
            With myMessage
                .To.Add(SendTo)
                .From = New MailAddress(SendFrom)
                .CC.Add(SendFrom)
                .Subject = Subject
                .Body = Body

                If File.Exists(Filename) Then
                    .Attachments.Add(AttachmentFile)
                End If

            End With

            Smtp.Send(myMessage)
            Return True
        Catch myexp As Exception
            Return False
            Throw myexp
        End Try
    End Function

    Public Function CheckForm(_form As Form) As Boolean

        For Each f As Form In Application.OpenForms
            If f.Name = _form.Name Then
                Return True
            End If
        Next
        Return False
    End Function
End Module
