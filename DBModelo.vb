Imports System.Data.Entity
Imports System.Data.Entity.Validation
Imports System.Data.SqlClient

Public Class DBModelo

#Region "Seccion <<Login>>"
    Shared Function GetUser(ByVal User As String) As tblUsuarios
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblUsuarios.Where(Function(i) i.usuario1 = User).FirstOrDefault
        End Using
    End Function
#End Region

#Region "Seccion <<Proveedores>>"
    Shared Function GetProveedorAll() As List(Of tblProveedor)
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblProveedors.ToList()
        End Using
    End Function

    Shared Function GetProveedorByDesc(ByVal ProveedorDesc As String) As List(Of tblProveedor)
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblProveedors.Where(Function(i) i.razonSocial.Contains(ProveedorDesc)).ToList()
        End Using
    End Function

    Shared Function GetProveedor(ByVal IdProveedor As Integer) As tblProveedor
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblProveedors.Where(Function(i) i.clave = IdProveedor).FirstOrDefault
        End Using
    End Function

    Shared Function InsertProveedor(ByVal strProveedor As tblProveedor) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblProveedors.Add(strProveedor)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateProveedor(ByVal strProveedor As tblProveedor) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblProveedors.Attach(strProveedor)
                ctx.Entry(strProveedor).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateProveedor_Compras(ByVal RazonSocial_new As String, ByVal IdProveedor As Integer) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                Select Case DBConnected
                    Case "Wendy"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv].[compras] SET proveedor = {0} WHERE idproveedor = {1}", RazonSocial_new, IdProveedor)
                    Case "Librada"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_new].[compras] SET proveedor = {0} WHERE idproveedor = {1}", RazonSocial_new, IdProveedor)
                    Case "Salvador"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[compras] SET proveedor = {0} WHERE idproveedor = {1}", RazonSocial_new, IdProveedor)
                End Select
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateProveedor_OrdenCompra(ByVal RazonSocial_new As String, ByVal IdProveedor As Integer) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                Select Case DBConnected
                    Case "Wendy"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv].[ordencompra] SET proveedor = {0} WHERE idproveedor = {1}", RazonSocial_new, IdProveedor)
                    Case "Librada"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_new].[ordencompra] SET proveedor = {0} WHERE idproveedor = {1}", RazonSocial_new, IdProveedor)
                    Case "Salvador"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[ordencompra] SET proveedor = {0} WHERE idproveedor = {1}", RazonSocial_new, IdProveedor)
                End Select
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateProveedor_HistorialPagos(ByVal RazonSocial_new As String, ByVal IdProveedor As Integer) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                Select Case DBConnected
                    Case "Wendy"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv].[historial_pagos_proveedores] SET proveedor = {0} WHERE idproveedor = {1}", RazonSocial_new, IdProveedor)
                    Case "Librada"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_new].[historial_pagos_proveedores] SET proveedor = {0} WHERE idproveedor = {1}", RazonSocial_new, IdProveedor)
                    Case "Salvador"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[historial_pagos_proveedores] SET proveedor = {0} WHERE idproveedor = {1}", RazonSocial_new, IdProveedor)
                End Select
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateProveedor_Pagar(ByVal RazonSocial_new As String, ByVal IdProveedor As Integer) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                Select Case DBConnected
                    Case "Wendy"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv].[pagar] SET proveedor = {0} WHERE idproveedor = {1}", RazonSocial_new, IdProveedor)
                    Case "Librada"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_new].[pagar] SET proveedor = {0} WHERE idproveedor = {1}", RazonSocial_new, IdProveedor)
                    Case "Salvador"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[pagar] SET proveedor = {0} WHERE idproveedor = {1}", RazonSocial_new, IdProveedor)
                End Select
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateProveedor_Productos(ByVal RazonSocial_new As String, ByVal RazonSocial_old As String) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                Select Case DBConnected
                    Case "Wendy"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv].[productos] SET proveedor = {0} WHERE idproveedor = {1}", RazonSocial_new, idProveedor)
                    Case "Librada"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_new].[productos] SET proveedor = {0} WHERE idproveedor = {1}", RazonSocial_new, idProveedor)
                    Case "Salvador"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[productos] SET proveedor = {0} WHERE idproveedor = {1}", RazonSocial_new, idProveedor)
                End Select
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

#End Region

#Region "Seccion <<Clientes>>"
    Shared Function GetClientesByNameApatAmat(ByVal Nombre As String) As List(Of tblClientes)
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblClientes.Where(Function(i) i.nombre.Contains(Nombre) Or
                                              i.apat.Contains(Nombre) Or
                                              i.amat.Contains(Nombre)).ToList()
        End Using
    End Function

    Shared Function GetCliente(ByVal IdCliente As Integer) As tblClientes
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblClientes.Where(Function(i) i.clave = IdCliente).FirstOrDefault
        End Using
    End Function

    Shared Function InsertCliente(ByVal strCliente As tblClientes) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblClientes.Add(strCliente)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateCliente(ByVal strCliente As tblClientes) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblClientes.Attach(strCliente)
                ctx.Entry(strCliente).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function DeleteCliente(ByVal strCliente As tblClientes) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                If Not IsNothing(strCliente) Then
                    ctx.Entry(strCliente).State = EntityState.Deleted
                    ctx.SaveChanges()
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateCliente_Cotizacion(ByVal NombreCompleto_new As String, ByVal IdCliente As Integer) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                Select Case DBConnected
                    Case "Wendy"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv].[cotizacion] SET Cliente = {0} WHERE idcliente = {1}", NombreCompleto_new, IdCliente)
                    Case "Librada"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_new].[cotizacion] SET Cliente = {0} WHERE idcliente = {1}", NombreCompleto_new, IdCliente)
                    Case "Salvador"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[cotizacion] SET Cliente = {0} WHERE idcliente = {1}", NombreCompleto_new, IdCliente)
                End Select
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateCliente_Venta(ByVal NombreCompleto_new As String, ByVal IdCliente As Integer) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                Select Case DBConnected
                    Case "Wendy"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv].[venta] SET Cliente = {0} WHERE idcliente = {1}", NombreCompleto_new, IdCliente)
                    Case "Librada"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_new].[venta] SET Cliente = {0} WHERE idcliente = {1}", NombreCompleto_new, IdCliente)
                    Case "Salvador"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[venta] SET Cliente = {0} WHERE idcliente = {1}", NombreCompleto_new, IdCliente)
                End Select
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateCliente_VentaPedido(ByVal NombreCompleto_new As String, ByVal IdCliente As Integer) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                Select Case DBConnected
                    Case "Wendy"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv].[venta_pedido] SET Cliente = {0} WHERE idcliente = {1}", NombreCompleto_new, IdCliente)
                    Case "Librada"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_new].[venta_pedido] SET Cliente = {0} WHERE idcliente = {1}", NombreCompleto_new, IdCliente)
                    Case "Salvador"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[venta_pedido] SET Cliente = {0} WHERE idcliente = {1}", NombreCompleto_new, IdCliente)
                End Select
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateCliente_Cobrar(ByVal NombreCompleto_new As String, ByVal IdCliente As Integer) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                Select Case DBConnected
                    Case "Wendy"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv].[cobrar] SET Cliente = {0} WHERE clavecliente = {1}", NombreCompleto_new, IdCliente)
                    Case "Librada"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_new].[cobrar] SET Cliente = {0} WHERE clavecliente = {1}", NombreCompleto_new, IdCliente)
                    Case "Salvador"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[cobrar] SET Cliente = {0} WHERE clavecliente = {1}", NombreCompleto_new, IdCliente)
                End Select
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateCliente_HistorialPagos(ByVal NombreCompleto_new As String, ByVal IdCliente As Integer) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                Select Case DBConnected
                    Case "Wendy"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv].[historial_pagos] SET Cliente = {0} WHERE clavecliente = {1}", NombreCompleto_new, IdCliente)
                    Case "Librada"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_new].[historial_pagos] SET Cliente = {0} WHERE clavecliente = {1}", NombreCompleto_new, IdCliente)
                    Case "Salvador"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[historial_pagos] SET Cliente = {0} WHERE clavecliente = {1}", NombreCompleto_new, IdCliente)
                End Select
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateCliente_FacturaTotal(ByVal NombreCompleto_new As String, ByVal IdCliente As Integer) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                Select Case DBConnected
                    Case "Wendy"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv].[factura_total] SET Cliente = {0} WHERE id_cliente = {1}", NombreCompleto_new, IdCliente)
                    Case "Librada"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_new].[factura_total] SET Cliente = {0} WHERE id_cliente = {1}", NombreCompleto_new, IdCliente)
                    Case "Salvador"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[factura_total] SET Cliente = {0} WHERE id_cliente = {1}", NombreCompleto_new, IdCliente)
                End Select
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

#End Region

#Region "Seccion <<UnidadDeMedida>>"
    Shared Function GetUoMAll() As List(Of tblUnidades)
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblUnidades.ToList()
        End Using
    End Function

    Shared Function GetUoMByDesc(ByVal UoMDesc As String) As List(Of tblUnidades)
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblUnidades.Where(Function(i) i.descripcion.Contains(UoMDesc)).ToList()
        End Using
    End Function

    Shared Function GetUoM(ByVal IdUoM As Integer) As tblUnidades
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblUnidades.Where(Function(i) i.idTransaccion = IdUoM).FirstOrDefault
        End Using
    End Function

    Shared Function InsertUoM(ByVal strUoM As tblUnidades) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblUnidades.Add(strUoM)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateUoM(ByVal strUoM As tblUnidades) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblUnidades.Attach(strUoM)
                ctx.Entry(strUoM).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateUoM_Productos(ByVal UoM_new As String, ByVal UoM_old As String) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                Select Case DBConnected
                    Case "Wendy"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv].[productos] SET unidadMedida = {0} WHERE unidadMedida = {1}", UoM_new, UoM_old)
                    Case "Librada"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_new].[productos] SET unidadMedida = {0} WHERE unidadMedida = {1}", UoM_new, UoM_old)
                    Case "Salvador"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[productos] SET unidadMedida = {0} WHERE unidadMedida = {1}", UoM_new, UoM_old)
                End Select
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

#End Region

#Region "Seccion <<Configuracion>>"

    Shared Function DataBaseBackUps(ByVal DataBaseName As String, ByVal FullFileName As String) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.Database.ExecuteSqlCommand("SP_DB_BACKUP @p0, @p1", New SqlParameter("@p0", DataBaseName), New SqlParameter("@p1", DataBaseName))

                'ctx.Database.SqlQuery("BACKUP DATABASE {0} TO DISK {1}", DataBaseName, FullFileName)
                'ctx.SP_DB_BACKUP(DataBaseName, FullFileName)
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Shared Function GetConfigGroupDesc(ByVal GroupDesc As String) As tblGrupos
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblGrupos.Where(Function(i) i.descripcion = GroupDesc).FirstOrDefault
        End Using
    End Function

    Shared Function GetConfigProducts(ByVal Grupo As String, UsarTC As Integer) As List(Of tblProductos)
        Using ctx As New pv_salvadorEntities1()
            Return ctx.productos.Where(Function(i) i.grupo = UsarTC And
                                                   i.UsarTC = UsarTC).ToList()
        End Using
    End Function
    Shared Function GetConfiguration(ByVal IdTerminal As String) As tblConfiguracion
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblConfiguracions.Where(Function(i) i.IdTerminal = IdTerminal).FirstOrDefault
        End Using
    End Function

    Shared Function Insert_Configuracion(ByVal strConfig As tblConfiguracion) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblConfiguracions.Add(strConfig)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Update_Configuracion(ByVal strConfig As tblConfiguracion) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblConfiguracions.Attach(strConfig)
                ctx.Entry(strConfig).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

#End Region

#Region "Seccion <<Productos>>"
    Shared Function GetProductByCB(ByVal CodigoBarras As String) As tblProductos
        Using ctx As New pv_salvadorEntities1()
            Return ctx.productos.Where(Function(i) i.codigoBarras = CodigoBarras).FirstOrDefault
        End Using
    End Function

    Shared Function GetProductById(ByVal IdProducto As Integer) As tblProductos
        Using ctx As New pv_salvadorEntities1()
            Return ctx.productos.Where(Function(i) i.IdProducto = IdProducto).FirstOrDefault
        End Using
    End Function

    Shared Function GetProductByClave(ByVal Clave As String) As tblProductos
        Using ctx As New pv_salvadorEntities1()
            Return ctx.productos.Where(Function(i) i.clave = Clave).FirstOrDefault
        End Using
    End Function

    Shared Function GetProducts(ByVal ProdDesc As String, ByVal ProdCB As String, ByVal ProdClave As String, ByVal ProdGrp As String, ByVal ProdFam As String, ByVal ProdLin As String) As List(Of tblProductos)
        Using ctx As New pv_salvadorEntities1()
            Return ctx.productos.Where(Function(i) i.descripcionProducto.Contains(ProdDesc) And
                                              i.codigoBarras.Contains(ProdCB) And
                                              i.clave.Contains(ProdClave) And
                                              i.grupo.Contains(ProdGrp) And
                                              i.familia.Contains(ProdFam) And
                                              i.linea.Contains(ProdLin)).ToList()
        End Using
    End Function

    Shared Function GetProducts(ByVal IdProducto As Integer) As tblProductos
        Using ctx As New pv_salvadorEntities1()
            Return ctx.productos.Where(Function(i) i.IdProducto = IdProducto).FirstOrDefault
        End Using
    End Function

    Shared Function InsertProductos(strProducto As tblProductos) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.productos.Add(strProducto)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateProductos(ByVal strProducto As tblProductos) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.productos.Attach(strProducto)
                ctx.Entry(strProducto).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function DeleteProductos(ByVal strProducto As tblProductos) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                If Not IsNothing(strProducto) Then
                    ctx.Entry(strProducto).State = EntityState.Deleted
                    ctx.SaveChanges()
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#Region "Seccion <<Grupos>>"
    Shared Function GetGroup(ByVal IdGrupo As String) As tblGrupos
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblGrupos.Where(Function(i) i.clave = IdGrupo).FirstOrDefault
        End Using
    End Function

    Shared Function GetGroupByDesc(ByVal GroupDesc As String) As List(Of tblGrupos)
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblGrupos.Where(Function(i) i.descripcion.Contains(GroupDesc)).ToList()
        End Using
    End Function

    Shared Function GetGroupsAll() As List(Of tblGrupos)
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblGrupos.ToList()
        End Using
    End Function

    Shared Function InsertGrupos(ByVal strGrupo As tblGrupos) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblGrupos.Add(strGrupo)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateGrupos(ByVal strGrupo As tblGrupos) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblGrupos.Attach(strGrupo)
                ctx.Entry(strGrupo).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Sub UpdateGrupoProd(ByVal newGrupo As String, ByVal oldGrupo As String)
        Using ctx As New pv_salvadorEntities1()
            Select Case DBConnected
                Case "Wendy"
                    ctx.Database.ExecuteSqlCommand("UPDATE [pv].[productos] SET grupo = {0} WHERE grupo = {1}", newGrupo, oldGrupo)
                Case "Librada"
                    ctx.Database.ExecuteSqlCommand("UPDATE [pv_new].[productos] SET grupo = {0} WHERE grupo = {1}", newGrupo, oldGrupo)
                Case "Salvador"
                    ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[productos] SET grupo = {0} WHERE grupo = {1}", newGrupo, oldGrupo)
            End Select
        End Using
    End Sub

    Shared Sub MassUpdateProductosPrecioCosto(ByVal factorCosto As Double, ByVal Grupo As String)
        Using ctx As New pv_salvadorEntities1()
            Select Case DBConnected
                Case "Wendy"
                    ctx.Database.ExecuteSqlCommand("UPDATE [pv].[productos] SET precioCosto = precioLista - (precioLista * {0}) WHERE grupo = {1} and precioManual = 0", factorCosto, Grupo)
                Case "Librada"
                    ctx.Database.ExecuteSqlCommand("UPDATE [pv_new].[productos] SET precioCosto = precioLista - (precioLista * {0}) WHERE grupo = {1} and precioManual = 0", factorCosto, Grupo)
                Case "Salvador"
                    ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[productos] SET precioCosto = precioLista - (precioLista * {0}) WHERE grupo = {1} and precioManual = 0", factorCosto, Grupo)
            End Select
        End Using
    End Sub

    Shared Sub MassUpdateProductosPrecioPublico(ByVal factorPublico As Double, ByVal Grupo As String)
        Using ctx As New pv_salvadorEntities1()
            Select Case DBConnected
                Case "Wendy"
                    ctx.Database.ExecuteSqlCommand("UPDATE [pv].[productos] SET precioPublico = (precioCosto / {0}) WHERE grupo = {1} and precioManual = 0", factorPublico, Grupo)
                Case "Librada"
                    ctx.Database.ExecuteSqlCommand("UPDATE [pv_new].[productos] SET precioPublico = (precioCosto / {0}) WHERE grupo = {1} and precioManual = 0", factorPublico, Grupo)
                Case "Salvador"
                    ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[productos] SET precioPublico = (precioCosto / {0}) WHERE grupo = {1} and precioManual = 0", factorPublico, Grupo)
            End Select
        End Using
    End Sub

    Shared Sub MassUpdateProductosPrecioP1(ByVal factorP1 As Double, ByVal Grupo As String)
        Using ctx As New pv_salvadorEntities1()
            Select Case DBConnected
                Case "Wendy"
                    ctx.Database.ExecuteSqlCommand("UPDATE [pv].[productos] SET precioP1 = (precioPublico / {0}) WHERE grupo = {1} and precioManual = 0", factorP1, Grupo)
                Case "Librada"
                    ctx.Database.ExecuteSqlCommand("UPDATE [pv_new].[productos] SET precioP1 = (precioPublico / {0}) WHERE grupo = {1} and precioManual = 0", factorP1, Grupo)
                Case "Salvador"
                    ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[productos] SET precioP1 = (precioPublico / {0}) WHERE grupo = {1} and precioManual = 0", factorP1, Grupo)
            End Select
        End Using
    End Sub

    Shared Sub MassUpdateProductosPrecioP2(ByVal factorP2 As Double, ByVal Grupo As String)
        Using ctx As New pv_salvadorEntities1()
            Select Case DBConnected
                Case "Wendy"
                    ctx.Database.ExecuteSqlCommand("UPDATE [pv].[productos] SET precioP2 = (precioPublico / {0}) WHERE grupo = {1} and precioManual = 0", factorP2, Grupo)
                Case "Librada"
                    ctx.Database.ExecuteSqlCommand("UPDATE [pv_new].[productos] SET precioP2 = (precioPublico / {0}) WHERE grupo = {1} and precioManual = 0", factorP2, Grupo)
                Case "Salvador"
                    ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[productos] SET precioP2 = (precioPublico / {0}) WHERE grupo = {1} and precioManual = 0", factorP2, Grupo)
            End Select
        End Using
    End Sub

    Shared Sub MassUpdateProductosPrecioP3(ByVal factorP3 As Double, ByVal Grupo As String)
        Using ctx As New pv_salvadorEntities1()
            Select Case DBConnected
                Case "Wendy"
                    ctx.Database.ExecuteSqlCommand("UPDATE [pv].[productos] SET precioP3 = (precioPublico / {0}) WHERE grupo = {1} and precioManual = 0", factorP3, Grupo)
                Case "Librada"
                    ctx.Database.ExecuteSqlCommand("UPDATE [pv_new].[productos] SET precioP3 = (precioPublico / {0}) WHERE grupo = {1} and precioManual = 0", factorP3, Grupo)
                Case "Salvador"
                    ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[productos] SET precioP3 = (precioPublico / {0}) WHERE grupo = {1} and precioManual = 0", factorP3, Grupo)
            End Select
        End Using
    End Sub
#End Region

#Region "Seccion <<Familias>>"
    Shared Function GetFamilia(ByVal IdFamilia As Integer) As tblFamilia
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblFamilias.Where(Function(i) i.clave = IdFamilia).FirstOrDefault
        End Using
    End Function

    Shared Function GetFamiliaByDesc(ByVal FamDesc As String) As List(Of tblFamilia)
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblFamilias.Where(Function(i) i.descripcion.Contains(FamDesc)).ToList()
        End Using
    End Function

    Shared Function GetFamiliaAll() As List(Of tblFamilia)
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblFamilias.ToList()
        End Using
    End Function

    Shared Function UpdateFamilia(ByVal strFamilia As tblFamilia) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblFamilias.Attach(strFamilia)
                ctx.Entry(strFamilia).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function InsertFamilia(ByVal strFamilia As tblFamilia) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblFamilias.Add(strFamilia)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateFamiliaProd(ByVal familia_new As String, ByVal familia_old As String) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                Select Case DBConnected
                    Case "Wendy"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv].[productos] SET familia = {0} WHERE familia = {1}", familia_new, familia_old)
                    Case "Librada"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_new].[productos] SET familia = {0} WHERE familia = {1}", familia_new, familia_old)
                    Case "Salvador"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[productos] SET familia = {0} WHERE familia = {1}", familia_new, familia_old)
                End Select
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#Region "Seccion <<SubFamilias>>"
    Shared Function GetSubFamiliaAll() As List(Of tblSubFamilia)
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblSubFamilias.ToList()
        End Using
    End Function

    Shared Function GetSubFamiliaByDesc(ByVal SubFamDesc As String) As List(Of tblSubFamilia)
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblSubFamilias.Where(Function(i) i.descripcion.Contains(SubFamDesc)).ToList()
        End Using
    End Function

    Shared Function GetSubFamilia(ByVal IdSubFamilia As Integer) As tblSubFamilia
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblSubFamilias.Where(Function(i) i.clave = IdSubFamilia).FirstOrDefault
        End Using
    End Function

    Shared Function UpdateSubfamilia(ByVal strSubFamilia As tblSubFamilia) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblSubFamilias.Attach(strSubFamilia)
                ctx.Entry(strSubFamilia).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function InsertSubfamilia(ByVal strSubFamilia As tblSubFamilia) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblSubFamilias.Add(strSubFamilia)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateSubfamiliaProd(ByVal subfamilia_new As String, ByVal subfamilia_old As String) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                Select Case DBConnected
                    Case "Wendy"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv].[productos] SET subfamilia = {0} WHERE subfamilia = {1}", subfamilia_new, subfamilia_old)
                    Case "Librada"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_new].[productos] SET subfamilia = {0} WHERE subfamilia = {1}", subfamilia_new, subfamilia_old)
                    Case "Salvador"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[productos] SET subfamilia = {0} WHERE subfamilia = {1}", subfamilia_new, subfamilia_old)
                End Select
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#Region "Seccion <<Lineas>>"
    Shared Function GetLineaAll() As List(Of tblLinea)
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblLineas.ToList()
        End Using
    End Function

    Shared Function GetLineaByDesc(ByVal LineaDesc As String) As List(Of tblLinea)
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblLineas.Where(Function(i) i.descripcion.Contains(LineaDesc)).ToList()
        End Using
    End Function

    Shared Function GetLinea(ByVal IdLinea As Integer) As tblLinea
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblLineas.Where(Function(i) i.clave = IdLinea).FirstOrDefault
        End Using
    End Function

    Shared Function UpdateLinea(ByVal strLinea As tblLinea) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblLineas.Attach(strLinea)
                ctx.Entry(strLinea).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function InsertLinea(ByVal strLinea As tblLinea) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblLineas.Add(strLinea)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateLinea_Productos(ByVal linea_new As String, ByVal linea_old As String) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                Select Case DBConnected
                    Case "Wendy"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv].[productos] SET linea = {0} WHERE linea = {1}", linea_new, linea_old)
                    Case "Librada"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_new].[productos] SET linea = {0} WHERE linea = {1}", linea_new, linea_old)
                    Case "Salvador"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[productos] SET linea = {0} WHERE linea = {1}", linea_new, linea_old)
                End Select
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#Region "Seccion <<Ajuste de Inventario>>"

#End Region

#Region "Seccion <<Punto de Venta>>"
    Shared Function Get_PV_Producto(ByVal Clave_CodigoBarras As String) As tblProductos
        Using ctx As New pv_salvadorEntities1()
            Return ctx.productos.Where(Function(i) i.clave.Contains(Clave_CodigoBarras) Or
                                              i.codigoBarras.Contains(Clave_CodigoBarras)).FirstOrDefault
        End Using
    End Function

    Shared Function Get_PV_Cliente_SUM(ByVal IdCliente As Integer) As Double
        Dim p_output As Double = 0
        Try
            Using ctx As New pv_salvadorEntities1()
                Dim rPagos As List(Of tblCobrar) = ctx.tblCobrars.Where(Function(i) i.claveCliente = IdCliente).ToList()
                For rP = 0 To rPagos.Count - 1
                    p_output = p_output + rPagos(rP).resto
                Next
                Return p_output
            End Using
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Shared Function Get_PV_Cliente_Limite(ByVal IdCliente As Integer) As Double
        Try
            Using ctx As New pv_salvadorEntities1()
                Dim rCliente As tblClientes = ctx.tblClientes.Where(Function(i) i.clave = IdCliente).FirstOrDefault
                If Not IsNothing(rCliente) Then
                    Return rCliente.limiteCredito
                Else
                    Return 0
                End If
            End Using
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Shared Function Get_PV_FoliosTicketActual(ByVal Año As Integer, ByVal IdTerminal As String, ByVal TipoDocumento As String) As Integer
        Try
            Using ctx As New pv_salvadorEntities1()
                Dim rFolio As tblFoliosTicket = ctx.tblFoliosTickets.Where(Function(i) i.Year = Año And i.IdTerminal = IdTerminal And i.DocType = TipoDocumento).FirstOrDefault
                If Not IsNothing(rFolio) Then
                    Return rFolio.FolioActual
                Else
                    Return 0
                End If
            End Using
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Shared Function Get_PV_FoliosTicket(ByVal Año As Integer, ByVal IdTerminal As String, ByVal TipoDocumento As String) As tblFoliosTicket
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblFoliosTickets.Where(Function(i) i.Year = Año And i.IdTerminal = IdTerminal And i.DocType = TipoDocumento).FirstOrDefault
        End Using
    End Function

    Shared Function Insert_PV_FoliosTicketActual(ByVal strFolios As tblFoliosTicket) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblFoliosTickets.Add(strFolios)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Update_PV_FoliosTicketActual(ByVal strFolios As tblFoliosTicket) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblFoliosTickets.Attach(strFolios)
                ctx.Entry(strFolios).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Update_PV_Producto_Stock(ByVal Stock As Double, ByVal IdProducto As Integer) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                Select Case DBConnected
                    Case "Wendy"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv].[productos] SET stock = stock - {0} WHERE IdProducto = {1}", Stock, IdProducto)
                    Case "Librada"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_new].[productos] SET stock = stock - {0} WHERE IdProducto = {1}", Stock, IdProducto)
                    Case "Salvador"
                        ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[productos] SET stock = stock - {0} WHERE IdProducto = {1}", Stock, IdProducto)
                End Select
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Insert_PV_VentaPedidos(ByVal strVentaPedidos As tblVentaPedido) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblVentaPedidoes.Add(strVentaPedidos)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Update_PV_VentaPedidos(ByVal strVentaPedidos As tblVentaPedido) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblVentaPedidoes.Attach(strVentaPedidos)
                ctx.Entry(strVentaPedidos).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Update_PV_Venta(ByVal strVenta As tblVenta) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblVentas.Attach(strVenta)
                ctx.Entry(strVenta).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Insert_PV_TicketPedidos(ByVal strTicketPedidos As tblTicketPedido) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblTicketPedidoes.Add(strTicketPedidos)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Insert_PV_Venta(ByVal strVenta As tblVenta) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblVentas.Add(strVenta)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Insert_PV_Ticket(ByVal strTicket As tblTicket) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblTickets.Add(strTicket)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Insert_PV_Cobrar(ByVal strCobrar As tblCobrar) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblCobrars.Add(strCobrar)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Insert_PV_Cotizacion(ByVal strCotizacion As tblCotizacion) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblCotizacions.Add(strCotizacion)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Insert_PV_TicketCotizacion(ByVal strTicketCotiza As tblTicketCotiza) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblTicketCotizas.Add(strTicketCotiza)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Get_PV_PedidosHeader(ByVal nPedido As Integer) As tblVentaPedido
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblVentaPedidoes.Where(Function(i) i.nticket = nPedido).FirstOrDefault
        End Using
    End Function

    Shared Function Get_PV_PedidosDetalle(ByVal nPedido As Integer) As List(Of tblTicketPedido)
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblTicketPedidoes.Where(Function(i) i.folio = nPedido).ToList()
        End Using
    End Function

    Shared Function Get_PV_TicketHeader(ByVal nTicket As Integer) As tblVenta
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblVentas.Where(Function(i) i.nticket = nTicket).FirstOrDefault
        End Using
    End Function

    Shared Function Get_PV_TicketsDetalle(ByVal nTicket As Integer) As List(Of tblTicket)
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblTickets.Where(Function(i) i.folio = nTicket).ToList()
        End Using
    End Function

    Shared Function Get_PV_CotizacionHeader(ByVal nTicket As Integer) As tblCotizacion
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblCotizacions.Where(Function(i) i.nticket = nTicket).FirstOrDefault
        End Using
    End Function

    Shared Function Get_PV_CotizacionDetalle(ByVal nTicket As Integer) As List(Of tblTicketCotiza)
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblTicketCotizas.Where(Function(i) i.folio = nTicket).ToList()
        End Using
    End Function

#End Region

#Region "Seccion <<Cobrar>>"
    Shared Function Get_CobrarTipoDoc(ByVal NoRemisión As Integer, ByVal TipoDocumento As String) As tblCobrar
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblCobrars.Where(Function(i) i.n_remision = NoRemisión And i.tipoDocumento = TipoDocumento).FirstOrDefault
        End Using
    End Function

    Shared Function Update_Cobrar(ByVal strCobrar As tblCobrar) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblCobrars.Attach(strCobrar)
                ctx.Entry(strCobrar).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

#End Region

#Region "Sección <<Nota de Crédito>>"

    Shared Function Insert_NC(ByVal strNC As tblNC) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblNCs.Add(strNC)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex2 As DbEntityValidationException
            For Each a In ex2.EntityValidationErrors
                For Each b In a.ValidationErrors
                    Dim st1 As String = b.PropertyName
                    Dim st2 As String = b.ErrorMessage
                Next
            Next
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Insert_NC_Detalle(ByVal strNC_Detalle As nc_detalle) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.nc_detalle.Add(strNC_Detalle)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Get_NotaDeCredito(ByVal NC As Integer) As tblNC
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblNCs.Where(Function(i) i.n_nc = NC).FirstOrDefault
        End Using
    End Function

    Shared Function Get_Facturas(ByVal NumeroFactura As Integer) As List(Of factura)
        Using ctx As New pv_salvadorEntities1()
            Return ctx.facturas.Where(Function(i) i.n_factura = NumeroFactura).ToList()
        End Using
    End Function

    Shared Function Update_NotaDeCredito(ByVal strNC As tblNC) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.tblNCs.Attach(strNC)
                ctx.Entry(strNC).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Get_PV_FoliosNC_Actual(ByVal Año As Integer, ByVal TipoDocumento As String) As Integer
        Try
            Using ctx As New pv_salvadorEntities1()
                Dim rFolio As foliosfactura = ctx.foliosfacturas.Where(Function(i) i.Year = Año And i.TipoComprobante = TipoDocumento).FirstOrDefault
                If Not IsNothing(rFolio) Then
                    Return rFolio.FolioActual
                Else
                    Return 0
                End If
            End Using
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Shared Function Insert_PV_FoliosNC_Actual(ByVal strFolios As foliosfactura) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.foliosfacturas.Add(strFolios)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Update_PV_FoliosNC_Actual(ByVal strFolios As foliosfactura) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.foliosfacturas.Attach(strFolios)
                ctx.Entry(strFolios).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Get_PV_FoliosNC(ByVal Año As Integer, ByVal TipoDocumento As String) As foliosfactura
        Using ctx As New pv_salvadorEntities1()
            Return ctx.foliosfacturas.Where(Function(i) i.Year = Año And i.TipoComprobante = TipoDocumento).FirstOrDefault
        End Using
    End Function

    Shared Function Get_PV_FacturaTotal(ByVal NumeroFactura As String) As factura_total
        Using ctx As New pv_salvadorEntities1()
            Return ctx.factura_total.Where(Function(i) i.n_factura = NumeroFactura).FirstOrDefault
        End Using
    End Function

    Shared Function Update_PV_FacturaTotal(ByVal strFacturaTotal As factura_total) As Boolean
        Try
            Using ctx As New pv_salvadorEntities1()
                ctx.factura_total.Attach(strFacturaTotal)
                ctx.Entry(strFacturaTotal).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


#End Region

#Region "Seccion <<Convertir Cotizaciones>>"
    Shared Function GetCotizaciones(ByVal DateFrom As Date, ByVal DateTo As Date) As List(Of tblCotizacion)
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblCotizacions.Where(Function(i) i.fecha >= DateFrom And i.fecha <= DateTo).ToList()
        End Using
    End Function

    Shared Function GetCotizacionesDet(ByVal Folio As Integer) As List(Of tblTicketCotiza)
        Using ctx As New pv_salvadorEntities1()
            Return ctx.tblTicketCotizas.Where(Function(i) i.folio = Folio).ToList()
        End Using
    End Function
#End Region

End Class
