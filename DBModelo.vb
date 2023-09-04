Imports System.Data.Entity
Imports System.Data.Entity.Validation
Imports System.Data.SqlClient

Public Class DBModelo

#Region "Seccion <<Login>>"
    Shared Function GetUser(ByVal User As String) As tblUsuarios
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblUsuarios.Where(Function(i) i.IdComp = CompanyCode And i.usuario1 = User).FirstOrDefault
        End Using
    End Function
#End Region

#Region "Seccion <<Proveedores>>"
    Shared Function GetProveedorAll() As List(Of tblProveedor)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblProveedors.Where(Function(i) i.IdComp = CompanyCode).OrderBy(Function(i) i.razonSocial).ToList()
        End Using
    End Function

    Shared Function GetProveedorByDesc(ByVal ProveedorDesc As String) As List(Of tblProveedor)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblProveedors.Where(Function(i) i.IdComp = CompanyCode And i.razonSocial.Contains(ProveedorDesc)).ToList()
        End Using
    End Function

    Shared Function GetProveedor(ByVal IdProveedor As Integer) As tblProveedor
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblProveedors.Where(Function(i) i.IdComp = CompanyCode And i.clave = IdProveedor).FirstOrDefault
        End Using
    End Function

    Shared Function InsertProveedor(ByVal strProveedor As tblProveedor) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
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
            Using ctx As New pvEntitiesSalvador()
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
            Using ctx As New pvEntitiesSalvador()
                ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[compras] SET proveedor = {0} WHERE IdComp = {2} and idproveedor = {1}", RazonSocial_new, IdProveedor, CompanyCode)
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateProveedor_OrdenCompra(ByVal RazonSocial_new As String, ByVal IdProveedor As Integer) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[ordencompra] SET proveedor = {0} WHERE IdComp = {2} and idproveedor = {1}", RazonSocial_new, IdProveedor, CompanyCode)
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateProveedor_HistorialPagos(ByVal RazonSocial_new As String, ByVal IdProveedor As Integer) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[historial_pagos_proveedores] SET proveedor = {0} WHERE IdComp = {2} and idproveedor = {1}", RazonSocial_new, IdProveedor, CompanyCode)
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateProveedor_Pagar(ByVal RazonSocial_new As String, ByVal IdProveedor As Integer) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[pagar] SET proveedor = {0} WHERE IdComp = {2} and idproveedor = {1}", RazonSocial_new, IdProveedor, CompanyCode)
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateProveedor_Productos(ByVal RazonSocial_new As String, ByVal IdProveedor As Integer) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[productos] SET proveedor = {0} WHERE IdComp = {2} and idproveedor = {1}", RazonSocial_new, IdProveedor, CompanyCode)
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

#End Region

#Region "Seccion <<Clientes>>"
    Shared Function GetClientesByNameApatAmat(ByVal Nombre As String) As List(Of tblClientes)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblClientes.Where(Function(i) i.IdComp = CompanyCode And
                                              i.nombre.Contains(Nombre) Or
                                              i.apat.Contains(Nombre) Or
                                              i.amat.Contains(Nombre)).ToList()
        End Using
    End Function

    Shared Function GetClientesByNameApatAmatWendy(ByVal Nombre As String) As List(Of tblWClientes)
        Using ctx As New pvEntitiesWendy()
            Return ctx.tblWClientes.Where(Function(i) i.IdComp = "01" And
                                              i.nombre.Contains(Nombre) Or
                                              i.apat.Contains(Nombre) Or
                                              i.amat.Contains(Nombre)).ToList()
        End Using
    End Function

    Shared Function GetCliente(ByVal IdCliente As Integer) As tblClientes
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblClientes.Where(Function(i) i.IdComp = CompanyCode And i.clave = IdCliente).FirstOrDefault
        End Using
    End Function

    Shared Function InsertCliente(ByVal strCliente As tblClientes) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
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
            Using ctx As New pvEntitiesSalvador()
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
            Using ctx As New pvEntitiesSalvador()
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
            Using ctx As New pvEntitiesSalvador()
                ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[cotizacion] SET Cliente = {0} WHERE IdComp = {2} and idcliente = {1}", NombreCompleto_new, IdCliente, CompanyCode)
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateCliente_Venta(ByVal NombreCompleto_new As String, ByVal IdCliente As Integer) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[venta] SET Cliente = {0} WHERE IdComp = {2} and idcliente = {1}", NombreCompleto_new, IdCliente, CompanyCode)
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateCliente_VentaPedido(ByVal NombreCompleto_new As String, ByVal IdCliente As Integer) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[venta_pedido] SET Cliente = {0} WHERE IdComp = {2} and idcliente = {1}", NombreCompleto_new, IdCliente, CompanyCode)
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateCliente_Cobrar(ByVal NombreCompleto_new As String, ByVal IdCliente As Integer) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[cobrar] SET Cliente = {0} WHERE IdComp = {2} and clavecliente = {1}", NombreCompleto_new, IdCliente, CompanyCode)
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateCliente_HistorialPagos(ByVal NombreCompleto_new As String, ByVal IdCliente As Integer) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[historial_pagos] SET Cliente = {0} WHERE IdComp = {2} and clavecliente = {1}", NombreCompleto_new, IdCliente, CompanyCode)
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateCliente_FacturaTotal(ByVal NombreCompleto_new As String, ByVal IdCliente As Integer) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[factura_total] SET Cliente = {0} WHERE IdComp = {2} and id_cliente = {1}", NombreCompleto_new, IdCliente, CompanyCode)
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

#End Region

#Region "Seccion <<UnidadDeMedida>>"
    Shared Function GetUoMAll() As List(Of tblUnidades)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblUnidades.Where(Function(i) i.IdComp = CompanyCode).OrderBy(Function(i) i.descripcion).ToList()
        End Using
    End Function

    Shared Function GetUoMByDesc(ByVal UoMDesc As String) As List(Of tblUnidades)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblUnidades.Where(Function(i) i.IdComp = CompanyCode And i.descripcion.Contains(UoMDesc)).ToList()
        End Using
    End Function

    Shared Function GetUoM(ByVal IdUoM As Integer) As tblUnidades
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblUnidades.Where(Function(i) i.IdComp = CompanyCode And i.Clave = IdUoM).FirstOrDefault
        End Using
    End Function

    Shared Function InsertUoM(ByVal strUoM As tblUnidades) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
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
            Using ctx As New pvEntitiesSalvador()
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
            Using ctx As New pvEntitiesSalvador()
                ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[productos] SET unidadMedida = {0} WHERE IdComp = {2} and unidadMedida = {1}", UoM_new, UoM_old, CompanyCode)
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
            Using ctx As New pvEntitiesSalvador()
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
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblGrupos.Where(Function(i) i.IdComp = CompanyCode And i.descripcion = GroupDesc).FirstOrDefault
        End Using
    End Function

    Shared Function GetConfigProducts(ByVal Grupo As String, UsarTC As Integer) As List(Of tblProductos)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.productos.Where(Function(i) i.IdComp = CompanyCode And
                                                   CInt(i.grupo) = UsarTC And
                                                   CInt(i.UsarTC) = UsarTC).ToList()
        End Using
    End Function
    Shared Function GetConfiguration(ByVal IdTerminal As String) As tblConfiguracion
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblConfiguracions.Where(Function(i) i.IdComp = CompanyCode And i.IdTerminal = IdTerminal).FirstOrDefault
        End Using
    End Function

    Shared Function GetConfigurationWendy(ByVal IdTerminal As String) As tblWConfiguracion
        Using ctx As New pvEntitiesWendy()
            Return ctx.tblWConfiguracions.Where(Function(i) i.IdComp = "01" And i.IdTerminal = IdTerminal).FirstOrDefault
        End Using
    End Function

    Shared Function Insert_Configuracion(ByVal strConfig As tblConfiguracion) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
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
            Using ctx As New pvEntitiesSalvador()
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
        Using ctx As New pvEntitiesSalvador()
            Return ctx.productos.Where(Function(i) i.IdComp = CompanyCode And i.codigoBarras = CodigoBarras).FirstOrDefault
        End Using
    End Function

    Shared Function GetProductById(ByVal IdProducto As Integer) As tblProductos
        Using ctx As New pvEntitiesSalvador()
            Return ctx.productos.Where(Function(i) i.IdComp = CompanyCode And i.IdProducto = IdProducto).FirstOrDefault
        End Using
    End Function

    Shared Function GetProductByClave(ByVal Clave As String) As tblProductos
        Using ctx As New pvEntitiesSalvador()
            Return ctx.productos.Where(Function(i) i.IdComp = CompanyCode And i.clave = Clave).FirstOrDefault
        End Using
    End Function

    Shared Function GetProductByGrupo(ByVal IdGrupo As String) As List(Of tblProductos)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.productos.Where(Function(i) i.IdComp = CompanyCode And i.grupo = IdGrupo).ToList()
        End Using
    End Function

    Shared Function GetProducts(ByVal ProdDesc As String, ByVal ProdCB As String, ByVal ProdClave As String, ByVal ProdGrp As String, ByVal ProdFam As String, ByVal ProdLin As String) As List(Of tblProductos)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.productos.Where(Function(i) i.IdComp = CompanyCode And
                                              i.descripcionProducto.Contains(ProdDesc) And
                                              i.codigoBarras.Contains(ProdCB) And
                                              i.clave.Contains(ProdClave) And
                                              i.grupo.Contains(ProdGrp) And
                                              i.familia.Contains(ProdFam) And
                                              i.linea.Contains(ProdLin)).OrderBy(Function(i) i.descripcionProducto).ToList()
        End Using
    End Function

    Shared Function GetProducts(ByVal IdProducto As Integer) As tblProductos
        Using ctx As New pvEntitiesSalvador()
            Return ctx.productos.Where(Function(i) i.IdComp = CompanyCode And i.IdProducto = IdProducto).FirstOrDefault
        End Using
    End Function

    Shared Function GetProductsAll() As List(Of tblProductos)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.productos.Where(Function(i) i.IdComp = CompanyCode).ToList()
            'Return ctx.productos.OrderBy(Function(i) i.IdComp = CompanyCode And i.descripcionProducto).ToList()
        End Using
    End Function

    Shared Function InsertProductos(strProducto As tblProductos) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.productos.Add(strProducto)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateProductos(ByVal strProducto As tblProductos) As Boolean
        Console.WriteLine(strProducto.stock.ToString)
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.productos.Attach(strProducto)
                ctx.Entry(strProducto).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Shared Function DeleteProductos(ByVal strProducto As tblProductos) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
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
    Shared Function GetGroup(ByVal IdGrupo As Long) As tblGrupos
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblGrupos.Where(Function(i) i.IdComp = CompanyCode And i.clave = IdGrupo).FirstOrDefault
        End Using
    End Function

    Shared Function GetGroupByDesc(ByVal GroupDesc As String) As List(Of tblGrupos)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblGrupos.Where(Function(i) i.IdComp = CompanyCode And i.descripcion.Contains(GroupDesc)).ToList()
        End Using
    End Function

    Shared Function GetGroupsAll() As List(Of tblGrupos)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblGrupos.Where(Function(i) i.IdComp = CompanyCode).OrderBy(Function(i) i.descripcion).ToList()
        End Using
    End Function

    Shared Function InsertGrupos(ByVal strGrupo As tblGrupos) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
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
            Using ctx As New pvEntitiesSalvador()
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
        Using ctx As New pvEntitiesSalvador()
            ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[productos] SET grupo = {0} WHERE IdComp = {2} and grupo = {1}", newGrupo, oldGrupo, CompanyCode)
        End Using
    End Sub

    Shared Sub MassUpdateProductosPrecioCosto(ByVal factorCosto As Double, ByVal Grupo As String)
        Using ctx As New pvEntitiesSalvador()
            ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[productos] SET precioCosto = precioLista - (precioLista * {0}) WHERE IdComp = {2} and grupo = {1} and precioManual = 0", factorCosto, Grupo, CompanyCode)
        End Using
    End Sub

    Shared Sub MassUpdateProductosPrecioPublico(ByVal factorPublico As Double, ByVal Grupo As String)
        Using ctx As New pvEntitiesSalvador()
            ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[productos] SET precioPublico = (precioCosto / {0}) WHERE IdComp = {2} and grupo = {1} and precioManual = 0", factorPublico, Grupo, CompanyCode)
        End Using
    End Sub

    Shared Sub MassUpdateProductosPrecioP1(ByVal factorP1 As Double, ByVal Grupo As String)
        Using ctx As New pvEntitiesSalvador()
            ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[productos] SET precioP1 = (precioPublico / {0}) WHERE IdComp = {2} and grupo = {1} and precioManual = 0", factorP1, Grupo, CompanyCode)
        End Using
    End Sub

    Shared Sub MassUpdateProductosPrecioP2(ByVal factorP2 As Double, ByVal Grupo As String)
        Using ctx As New pvEntitiesSalvador()
            ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[productos] SET precioP2 = (precioPublico / {0}) WHERE IdComp = {2} and grupo = {1} and precioManual = 0", factorP2, Grupo, CompanyCode)
        End Using
    End Sub

    Shared Sub MassUpdateProductosPrecioP3(ByVal factorP3 As Double, ByVal Grupo As String)
        Using ctx As New pvEntitiesSalvador()
            ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[productos] SET precioP3 = (precioPublico / {0}) WHERE IdComp = {2} and grupo = {1} and precioManual = 0", factorP3, Grupo, CompanyCode)
        End Using
    End Sub
#End Region

#Region "Seccion <<Marcas>>"
    Shared Function GetMarca(ByVal IdMarca As Integer) As tblMarcas
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblMarcas.Where(Function(i) i.IdComp = CompanyCode And i.Clave = IdMarca).FirstOrDefault
        End Using
    End Function

    Shared Function GetMarcaByDesc(ByVal MarDesc As String) As List(Of tblMarcas)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblMarcas.Where(Function(i) i.IdComp = CompanyCode And i.descripcion.Contains(MarDesc)).ToList()
        End Using
    End Function

    Shared Function GetMarcaAll() As List(Of tblMarcas)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblMarcas.Where(Function(i) i.IdComp = CompanyCode).ToList()
        End Using
    End Function

    Shared Function UpdateMarca(ByVal strMarca As tblMarcas) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.tblMarcas.Attach(strMarca)
                ctx.Entry(strMarca).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function InsertMarca(ByVal strMarca As tblMarcas) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.tblMarcas.Add(strMarca)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateMarcaProd(ByVal marca_new As String, ByVal marca_old As String) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[productos] SET marca = {0} WHERE IdComp = {2} and marca = {1}", marca_new, marca_old, CompanyCode)
            End Using
            Return True
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return False
        End Try
    End Function
#End Region

#Region "Seccion <<Familias>>"
    Shared Function GetFamilia(ByVal IdFamilia As Integer) As tblFamilia
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblFamilias.Where(Function(i) i.IdComp = CompanyCode And i.clave = IdFamilia).FirstOrDefault
        End Using
    End Function

    Shared Function GetFamiliaByDesc(ByVal FamDesc As String) As List(Of tblFamilia)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblFamilias.Where(Function(i) i.IdComp = CompanyCode And i.descripcion.Contains(FamDesc)).ToList()
        End Using
    End Function

    Shared Function GetFamiliaAll() As List(Of tblFamilia)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblFamilias.Where(Function(i) i.IdComp = CompanyCode).OrderBy(Function(i) i.descripcion).ToList()
        End Using
    End Function

    Shared Function UpdateFamilia(ByVal strFamilia As tblFamilia) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
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
            Using ctx As New pvEntitiesSalvador()
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
            Using ctx As New pvEntitiesSalvador()
                ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[productos] SET familia = {0} WHERE IdComp = {2} and familia = {1}", familia_new, familia_old, CompanyCode)
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#Region "Seccion <<SubFamilias>>"
    Shared Function GetSubFamiliaAll() As List(Of tblSubFamilia)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblSubFamilias.Where(Function(i) i.IdComp = CompanyCode).OrderBy(Function(i) i.descripcion).ToList()
        End Using
    End Function

    Shared Function GetSubFamiliaByDesc(ByVal SubFamDesc As String) As List(Of tblSubFamilia)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblSubFamilias.Where(Function(i) i.IdComp = CompanyCode And i.descripcion.Contains(SubFamDesc)).ToList()
        End Using
    End Function

    Shared Function GetSubFamilia(ByVal IdSubFamilia As Integer) As tblSubFamilia
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblSubFamilias.Where(Function(i) i.IdComp = CompanyCode And i.clave = IdSubFamilia).FirstOrDefault
        End Using
    End Function

    Shared Function UpdateSubfamilia(ByVal strSubFamilia As tblSubFamilia) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
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
            Using ctx As New pvEntitiesSalvador()
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
            Using ctx As New pvEntitiesSalvador()
                ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[productos] SET subfamilia = {0} WHERE IdComp = {2} and subfamilia = {1}", subfamilia_new, subfamilia_old, CompanyCode)
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#Region "Seccion <<Lineas>>"
    Shared Function GetLineaAll() As List(Of tblLinea)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblLineas.Where(Function(i) i.IdComp = CompanyCode).OrderBy(Function(i) i.descripcion).ToList()
        End Using
    End Function

    Shared Function GetLineaByDesc(ByVal LineaDesc As String) As List(Of tblLinea)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblLineas.Where(Function(i) i.IdComp = CompanyCode And i.descripcion.Contains(LineaDesc)).ToList()
        End Using
    End Function

    Shared Function GetLinea(ByVal IdLinea As Integer) As tblLinea
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblLineas.Where(Function(i) i.IdComp = CompanyCode And i.clave = IdLinea).FirstOrDefault
        End Using
    End Function

    Shared Function UpdateLinea(ByVal strLinea As tblLinea) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
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
            Using ctx As New pvEntitiesSalvador()
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
            Using ctx As New pvEntitiesSalvador()
                ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[productos] SET linea = {0} WHERE IdComp = {2} and linea = {1}", linea_new, linea_old, CompanyCode)
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
        Using ctx As New pvEntitiesSalvador()
            Return ctx.productos.Where(Function(i) i.IdComp = CompanyCode And
                                              i.clave.Equals(Clave_CodigoBarras) Or
                                              i.codigoBarras.Equals(Clave_CodigoBarras)).FirstOrDefault
        End Using
    End Function

    Shared Function Get_PV_Cliente_SUM(ByVal IdCliente As Integer) As Double
        Dim p_output As Double = 0
        Try
            Using ctx As New pvEntitiesSalvador()
                Dim rPagos As List(Of tblCobrar) = ctx.tblCobrars.Where(Function(i) i.IdComp = CompanyCode And CInt(i.claveCliente) = IdCliente).ToList()
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
            Using ctx As New pvEntitiesSalvador()
                Dim rCliente As tblClientes = ctx.tblClientes.Where(Function(i) i.IdComp = CompanyCode And i.clave = IdCliente).FirstOrDefault
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
            Using ctx As New pvEntitiesSalvador()
                Dim rFolio As tblFoliosTicket = ctx.tblFoliosTickets.Where(Function(i) i.IdComp = CompanyCode And i.Year = Año And i.IdTerminal = IdTerminal And i.DocType = TipoDocumento).FirstOrDefault
                If Not IsNothing(rFolio) Then
                    Return CInt(rFolio.FolioActual)
                Else
                    Return 0
                End If
            End Using
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Shared Function Get_PV_FoliosTicket(ByVal Año As Integer, ByVal IdTerminal As String, ByVal TipoDocumento As String) As tblFoliosTicket
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblFoliosTickets.Where(Function(i) i.IdComp = CompanyCode And i.Year = Año And i.IdTerminal = IdTerminal And i.DocType = TipoDocumento).FirstOrDefault
        End Using
    End Function

    Shared Function Insert_PV_FoliosTicketActual(ByVal strFolios As tblFoliosTicket) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
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
            Using ctx As New pvEntitiesSalvador()
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
            Using ctx As New pvEntitiesSalvador()
                ctx.Database.ExecuteSqlCommand("UPDATE [pv_salvador].[productos] SET stock = stock - {0} WHERE IdComp = {2} and IdProducto = {1}", Stock, IdProducto, CompanyCode)
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Insert_PV_VentaPedidos(ByVal strVentaPedidos As tblVentaPedido) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
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
            Using ctx As New pvEntitiesSalvador()
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
            Using ctx As New pvEntitiesSalvador()
                ctx.tblVentas.Attach(strVenta)
                ctx.Entry(strVenta).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Update_Tickets(ByVal strTicket As tblTicket) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.tblTickets.Attach(strTicket)
                ctx.Entry(strTicket).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Insert_PV_TicketPedidos(ByVal strTicketPedidos As tblTicketPedido) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
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
            Using ctx As New pvEntitiesSalvador()
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
            Using ctx As New pvEntitiesSalvador()
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
            Using ctx As New pvEntitiesSalvador()
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
            Using ctx As New pvEntitiesSalvador()
                ctx.tblCotizacions.Add(strCotizacion)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function

    Shared Function Insert_PV_TicketCotizacion(ByVal strTicketCotiza As tblTicketCotiza) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.tblTicketCotizas.Add(strTicketCotiza)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Get_PV_PedidosHeader(ByVal nPedido As Integer) As tblVentaPedido
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblVentaPedidoes.Where(Function(i) i.IdComp = CompanyCode And i.nticket = nPedido).FirstOrDefault
        End Using
    End Function

    Shared Function Get_PV_PedidosDetalle(ByVal nPedido As Integer) As List(Of tblTicketPedido)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblTicketPedidoes.Where(Function(i) i.IdComp = CompanyCode And CInt(i.folio) = nPedido).ToList()
        End Using
    End Function

    Shared Function Get_PV_PedidosDetalleByFolioAndIdProducto(ByVal nPedido As Integer, ByVal IdProducto As Integer) As tblTicketPedido
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblTicketPedidoes.Where(Function(i) i.IdComp = CompanyCode And CInt(i.folio) = nPedido And i.IdProducto = IdProducto).FirstOrDefault
        End Using
    End Function

    Shared Function Get_PV_TicketsDetalleByFolioAndIdProducto(ByVal nPedido As Integer, ByVal IdProducto As Integer) As tblTicket
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblTickets.Where(Function(i) i.IdComp = CompanyCode And CInt(i.folio) = nPedido And i.IdProducto = IdProducto).FirstOrDefault
        End Using
    End Function

    Shared Function Get_PV_TicketHeader(ByVal nTicket As Integer) As tblVenta
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblVentas.Where(Function(i) i.IdComp = CompanyCode And i.nticket = nTicket).FirstOrDefault
        End Using
    End Function

    Shared Function Get_PV_TicketsDetalle(ByVal nTicket As Integer) As List(Of tblTicket)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblTickets.Where(Function(i) i.IdComp = CompanyCode And CInt(i.folio) = nTicket).ToList()
        End Using
    End Function

    Shared Function Get_PV_CotizacionHeader(ByVal nTicket As Integer) As tblCotizacion
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblCotizacions.Where(Function(i) i.IdComp = CompanyCode And i.nticket = nTicket).FirstOrDefault
        End Using
    End Function

    Shared Function Get_PV_CotizacionDetalle(ByVal nTicket As Integer) As List(Of tblTicketCotiza)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblTicketCotizas.Where(Function(i) i.IdComp = CompanyCode And CInt(i.folio) = nTicket).ToList()
        End Using
    End Function

    Shared Function Get_VentasByDate(ByVal DateFrom As String, ByVal DateTo As String) As List(Of tblVenta)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblVentas.Where(Function(i) CBool(i.IdComp = CompanyCode And
                                               i.fecha >= CDate(DateFrom) And i.fecha <= CDate(DateTo))).ToList()
        End Using
    End Function

    Shared Function Get_VentasByFactura(ByVal NoFactura As String) As List(Of tblVenta)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblVentas.Where(Function(i) i.IdComp = CompanyCode And i.numeroFactura.Equals(NoFactura)).ToList()
        End Using
    End Function

    Shared Function Get_TicketsByDateIdCliente(ByVal DateFrom As String, ByVal DateTo As String, ByVal IdCliente As Integer) As List(Of tblVenta)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblVentas.Where(Function(i) CBool(i.IdComp = CompanyCode And
                                           i.fecha >= CType(DateFrom, Date?) And
                                           i.fecha <= CType(DateTo, Date?) And
                                           i.idCliente = IdCliente)).ToList()
        End Using
    End Function

    Shared Function Get_TicketsByFactura(ByVal NoFactura As String) As List(Of tblTicket)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblTickets.Where(Function(i) i.IdComp = CompanyCode And i.numeroFactura.Equals(NoFactura)).ToList()
        End Using
    End Function

    Shared Function Get_PedidosByDateIdCliente(ByVal DateFrom As String, ByVal DateTo As String, ByVal IdCliente As Integer) As List(Of tblVentaPedido)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblVentaPedidoes.Where(Function(i) CBool(i.IdComp = CompanyCode And
                                                  i.fecha >= CType(DateFrom, Date?) And
                                                  i.fecha <= CType(DateTo, Date?) And
                                                  i.idCliente = IdCliente)).ToList()
        End Using
    End Function

    Shared Function Get_CotizacionesByDateIdCliente(ByVal DateFrom As String, ByVal DateTo As String, ByVal IdCliente As Integer) As List(Of tblCotizacion)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblCotizacions.Where(Function(i) CBool(i.IdComp = CompanyCode And
                                                i.fecha >= CType(DateFrom, Date?) And
                                                i.fecha <= CType(DateTo, Date?) And
                                                i.idCliente = IdCliente)).ToList()
        End Using
    End Function

    Shared Function Get_PedidosByDate(ByVal DateFrom As String, ByVal DateTo As String) As List(Of tblVentaPedido)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblVentaPedidoes.Where(Function(i) CBool(i.IdComp = CompanyCode And
                                                  i.fecha >= CType(DateFrom, Date?) And
                                                  i.fecha <= CType(DateTo, Date?))).ToList()
        End Using
    End Function

    Shared Function DeleteVentaPedido(ByVal strVentaPedido As tblVentaPedido) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                If Not IsNothing(strVentaPedido) Then
                    ctx.Entry(strVentaPedido).State = EntityState.Deleted
                    ctx.SaveChanges()
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function DeleteTicketPedido(ByVal strTicketPedido As tblTicketPedido) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                If Not IsNothing(strTicketPedido) Then
                    ctx.Entry(strTicketPedido).State = EntityState.Deleted
                    ctx.SaveChanges()
                Else
                    Console.WriteLine("Is Nothing in DeleteTicketPedido")
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function DeleteTicket(ByVal strTicket As tblTicket) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                If Not IsNothing(strTicket) Then
                    ctx.Entry(strTicket).State = EntityState.Deleted
                    ctx.SaveChanges()
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


#End Region

#Region "Seccion <<Cobrar>>"
    Shared Function Get_CobrarTipoDoc(ByVal NoRemisión As Integer, ByVal TipoDocumento As String, ByVal IdCliente As Integer) As tblCobrar
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblCobrars.Where(Function(i) i.IdComp = CompanyCode And
                                            i.n_remision = NoRemisión And
                                            i.tipoDocumento = TipoDocumento And
                                            CInt(i.claveCliente) = IdCliente).FirstOrDefault
        End Using
    End Function

    Shared Function Get_CobrarTipoDocWendy(ByVal NoRemisión As Integer, ByVal TipoDocumento As String, ByVal IdCliente As Integer) As tblWCobrar
        Using ctx As New pvEntitiesWendy()
            Return ctx.tblWCobrars.Where(Function(i) i.IdComp = "01" And
                                             i.n_remision = NoRemisión And
                                             i.tipoDocumento = TipoDocumento And
                                             CInt(i.claveCliente) = IdCliente).FirstOrDefault
        End Using
    End Function

    Shared Function GetCobrarByDates(ByVal DateFrom As String, ByVal DateTo As String) As List(Of tblCobrar)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblCobrars.Where(Function(i) CBool(i.IdComp = CompanyCode And
                                            i.fecha_venta >= CType(DateFrom, Date?) And
                                            i.fecha_venta <= CType(DateTo, Date?) And
                                            i.resto <> 0)).ToList()
        End Using
    End Function

    Shared Function Update_Cobrar(ByVal strCobrar As tblCobrar) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.tblCobrars.Attach(strCobrar)
                ctx.Entry(strCobrar).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Shared Function Update_CobrarWendy(ByVal strCobrar As tblWCobrar) As Boolean
        Try
            Using ctx As New pvEntitiesWendy()
                ctx.tblWCobrars.Attach(strCobrar)
                ctx.Entry(strCobrar).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function DeleteCobrar(ByVal strCobrar As tblCobrar) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                If Not IsNothing(strCobrar) Then
                    ctx.Entry(strCobrar).State = EntityState.Deleted
                    ctx.SaveChanges()
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function GetCXC_ByIdCliente(ByVal IdCliente As Integer) As List(Of tblCobrar)
        Using ctx As New pvEntitiesSalvador()

            Dim tCobrar As List(Of tblCobrar) = ctx.tblCobrars.Where(Function(i) i.IdComp = CompanyCode And CInt(i.claveCliente) = IdCliente And i.resto <> 0).ToList()
            Dim numeroFactura As String

            For Each wCobrar In tCobrar
                If wCobrar.tipoDocumento = "TICKET" Then
                    numeroFactura = (From t1 In ctx.tblVentas
                                     Where t1.IdComp = CompanyCode And t1.nticket = wCobrar.n_remision
                                     Select New With {t1.numeroFactura}).First().numeroFactura
                    If numeroFactura = "" Then
                        wCobrar.facturado = 0
                    Else
                        If numeroFactura = "X" Then
                            wCobrar.facturado = 1
                        Else
                            wCobrar.facturado = Convert.ToInt32(numeroFactura)
                        End If
                    End If
                Else
                    numeroFactura = (From t1 In ctx.tblVentaPedidoes
                                     Where t1.IdComp = CompanyCode And t1.nticket = wCobrar.n_remision
                                     Select New With {t1.numeroFactura}).First().numeroFactura
                    If numeroFactura = "" Then
                        wCobrar.facturado = 0
                    Else
                        If numeroFactura = "X" Then
                            wCobrar.facturado = 1
                        Else
                            wCobrar.facturado = Convert.ToInt32(numeroFactura)
                        End If
                    End If
                End If

            Next

            Return tCobrar
        End Using
    End Function

    Shared Function GetCXC_ByIdClienteWendy(ByVal IdCliente As Integer) As List(Of tblWCobrar)
        Using ctx As New pvEntitiesWendy()

            Dim tCobrar As List(Of tblWCobrar) = ctx.tblWCobrars.Where(Function(i) i.IdComp = "01" And CInt(i.claveCliente) = IdCliente And i.resto <> 0).ToList()
            Dim numeroFactura As String

            For Each wCobrar In tCobrar
                If wCobrar.tipoDocumento = "TICKET" Then
                    numeroFactura = (From t1 In ctx.tblWVventas
                                     Where t1.IdComp = "01" And t1.nticket = wCobrar.n_remision
                                     Select New With {t1.numeroFactura}).First().numeroFactura
                    If numeroFactura = "" Then
                        wCobrar.facturado = 0
                    Else
                        If numeroFactura = "X" Then
                            wCobrar.facturado = 1
                        Else
                            wCobrar.facturado = Convert.ToInt32(numeroFactura)
                        End If
                    End If
                Else
                    numeroFactura = (From t1 In ctx.tblWVentasPedidos
                                     Where t1.IdComp = "01" And t1.nticket = wCobrar.n_remision
                                     Select New With {t1.numeroFactura}).First().numeroFactura
                    If numeroFactura = "" Then
                        wCobrar.facturado = 0
                    Else
                        If numeroFactura = "X" Then
                            wCobrar.facturado = 1
                        Else
                            wCobrar.facturado = Convert.ToInt32(numeroFactura)
                        End If
                    End If
                End If

            Next

            Return tCobrar
        End Using
    End Function

    Shared Function GetCobrarByIdCliente(ByVal IdCliente As Integer) As List(Of tblCobrar)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblCobrars.Where(Function(i) i.IdComp = CompanyCode And CInt(i.claveCliente) = IdCliente).ToList()
        End Using
    End Function

    Shared Function GetCobrarByIdClienteWendy(ByVal IdCliente As Integer) As List(Of tblWCobrar)
        Using ctx As New pvEntitiesWendy()
            Return ctx.tblWCobrars.Where(Function(i) i.IdComp = "01" And CInt(i.claveCliente) = IdCliente).ToList()
        End Using
    End Function

#End Region

#Region "Seccion <<HistorialPagos>>"
    Shared Function InsertHistorialPago(ByVal strHistPago As tblHistorialPagos) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.tblHistorialPagos.Add(strHistPago)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Shared Function InsertHistorialPagoWendy(ByVal strHistPago As tblWHistorialPagos) As Boolean
        Try
            Using ctx As New pvEntitiesWendy()
                ctx.tblWHistorialPagos.Add(strHistPago)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Get_HistorialPago(ByVal IdPago As Integer) As tblHistorialPagos
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblHistorialPagos.Where(Function(i) i.IdComp = CompanyCode And i.Id = IdPago).FirstOrDefault
        End Using
    End Function
    Shared Function Get_HistorialPagoWendy(ByVal IdPago As Integer) As tblWHistorialPagos
        Using ctx As New pvEntitiesWendy()
            Return ctx.tblWHistorialPagos.Where(Function(i) i.IdComp = "01" And i.Id = IdPago).FirstOrDefault
        End Using
    End Function

    Shared Function GetHistorialPago_ByIdCliente(ByVal IdCliente As Integer) As List(Of tblHistorialPagos)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblHistorialPagos.Where(Function(i) i.IdComp = CompanyCode And CInt(i.claveCliente) = IdCliente).ToList()
        End Using
    End Function

    Shared Function GetHistorialPago_ByIdClienteWendy(ByVal IdCliente As Integer) As List(Of tblWHistorialPagos)
        Using ctx As New pvEntitiesWendy()
            Return ctx.tblWHistorialPagos.Where(Function(i) i.IdComp = "01" And CInt(i.claveCliente) = IdCliente).ToList()
        End Using
    End Function

    Shared Function DeleteHistorialPagos(ByVal strHistPago As tblHistorialPagos) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                If Not IsNothing(strHistPago) Then
                    ctx.Entry(strHistPago).State = EntityState.Deleted
                    ctx.SaveChanges()
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Shared Function DeleteHistorialPagosWendy(ByVal strHistPago As tblWHistorialPagos) As Boolean
        Try
            Using ctx As New pvEntitiesWendy()
                If Not IsNothing(strHistPago) Then
                    ctx.Entry(strHistPago).State = EntityState.Deleted
                    ctx.SaveChanges()
                End If
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
            Using ctx As New pvEntitiesSalvador()
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
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Insert_NC_Detalle(ByVal strNC_Detalle As tblNcDetalle) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.tblNcDetalles.Add(strNC_Detalle)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Get_NotaDeCredito(ByVal NC As Integer) As tblNC
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblNCs.Where(Function(i) i.IdComp = CompanyCode And i.n_nc = NC).FirstOrDefault
        End Using
    End Function

    Shared Function Get_Facturas(ByVal NumeroFactura As Integer) As List(Of tblFactura)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblFacturas.Where(Function(i) i.IdComp = CompanyCode And i.n_factura = NumeroFactura).ToList()
        End Using
    End Function

    Shared Function Update_NotaDeCredito(ByVal strNC As tblNC) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
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
            Using ctx As New pvEntitiesSalvador()
                Dim rFolio As tblFolioFacturas = ctx.tblFolioFacturas.Where(Function(i) i.IdComp = CompanyCode And i.Year = Año And i.TipoComprobante = TipoDocumento).FirstOrDefault
                If Not IsNothing(rFolio) Then
                    Return CInt(rFolio.FolioActual)
                Else
                    Return 0
                End If
            End Using
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Shared Function Insert_PV_FoliosNC_Actual(ByVal strFolios As tblFoliofacturas) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.tblFoliofacturas.Add(strFolios)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Update_PV_FoliosNC_Actual(ByVal strFolios As tblFoliofacturas) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.tblFoliofacturas.Attach(strFolios)
                ctx.Entry(strFolios).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Get_PV_FoliosNC(ByVal Año As Integer, ByVal TipoDocumento As String) As tblFoliofacturas
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblFolioFacturas.Where(Function(i) i.IdComp = CompanyCode And i.Year = Año And i.TipoComprobante = TipoDocumento).FirstOrDefault
        End Using
    End Function

    Shared Function Get_PV_FacturaTotal(ByVal NumeroFactura As String) As tblFacturaTotal
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblFacturaTotals.Where(Function(i) i.IdComp = CompanyCode And i.n_factura = CDec(NumeroFactura)).FirstOrDefault
        End Using
    End Function

    Shared Function Update_PV_FacturaTotal(ByVal strFacturaTotal As tblFacturaTotal) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.tblFacturaTotals.Attach(strFacturaTotal)
                ctx.Entry(strFacturaTotal).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Update_ComplementoPagoH(ByVal strComplementoPagoH As tblComplementoPagosH) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.tblComplementoPagosHes.Attach(strComplementoPagoH)
                ctx.Entry(strComplementoPagoH).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Update_ComplementoPagoD(ByVal strComplementoPagoD As TblComplementoPagosD) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.TblComplementoPagosDs.Attach(strComplementoPagoD)
                ctx.Entry(strComplementoPagoD).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function Update_PV_NC(ByVal strNC As tblNC) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.tblNCs.Attach(strNC)
                ctx.Entry(strNC).State = EntityState.Modified
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
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblCotizacions.Where(Function(i) CBool(i.fecha >= DateFrom And i.fecha <= DateTo)).ToList()
        End Using
    End Function

    Shared Function GetCotizacionesDet(ByVal Folio As Integer) As List(Of tblTicketCotiza)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblTicketCotizas.Where(Function(i) CInt(i.folio) = Folio).ToList()
        End Using
    End Function
#End Region

#Region "Seccion <<Usuarios>>"
    Shared Function GetUsuariosAll() As List(Of tblUsuarios)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblUsuarios.Where(Function(i) i.IdComp = CompanyCode).ToList()
        End Using
    End Function

    Shared Function GetUsuario(ByVal Usuario As String) As tblUsuarios
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblUsuarios.Where(Function(i) i.IdComp = CompanyCode And i.usuario1 = Usuario).FirstOrDefault
        End Using
    End Function

    Shared Function InsertUsuario(ByVal strUsuario As tblUsuarios) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.tblUsuarios.Add(strUsuario)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function UpdateUsuario(ByVal strUsuario As tblUsuarios) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.tblUsuarios.Attach(strUsuario)
                ctx.Entry(strUsuario).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function DeleteUsuario(ByVal strUsuario As tblUsuarios) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                If Not IsNothing(strUsuario) Then
                    ctx.Entry(strUsuario).State = EntityState.Deleted
                    ctx.SaveChanges()
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

#End Region

#Region "Seccion <<Facturación>>"
    Shared Function GetVentasMostrador(ByVal sFecha As String, ByVal iIdCliente As Integer, ByVal sNumeroFactura As String, ByVal sEstado As String) As List(Of tblVenta)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblVentas.Where(Function(i) CBool(i.IdComp = CompanyCode And
                                           i.fecha = CDate(sFecha) And
                                           i.idCliente = iIdCliente And
                                           i.numeroFactura = sNumeroFactura And
                                           i.estado = sEstado)).ToList()
        End Using
    End Function

    Shared Function GetClienteByName(ByVal Nombre As String) As tblClientes
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblClientes.Where(Function(i) i.IdComp = CompanyCode And i.nombre.Contains(Nombre)).FirstOrDefault()
        End Using
    End Function

    Shared Function InsertFacturaTotal(ByVal strFacturaTotal As tblFacturaTotal) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.tblFacturaTotals.Add(strFacturaTotal)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function DeleteFacturaTotal(ByVal strFacturaTotal As tblFacturaTotal) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                If Not IsNothing(strFacturaTotal) Then
                    ctx.Entry(strFacturaTotal).State = EntityState.Deleted
                    ctx.SaveChanges()
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function InsertComplementoPagoH(ByVal strComplementoH As tblComplementoPagosH) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.tblComplementoPagosHes.Add(strComplementoH)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function

    Shared Function InsertComplementoPagoD(ByVal strComplementoD As TblComplementoPagosD) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.TblComplementoPagosDs.Add(strComplementoD)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function InsertFactura(ByVal strFactura As tblFactura) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.tblFacturas.Add(strFactura)
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function DeleteFactura(ByVal strFactura As tblFactura) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                If Not IsNothing(strFactura) Then
                    ctx.Entry(strFactura).State = EntityState.Deleted
                    ctx.SaveChanges()
                End If
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Shared Function GetFolioFactura(ByVal TipoComprobante As String, ByVal Year As String) As tblFoliofacturas
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblFolioFacturas.Where(Function(i) i.IdComp = CompanyCode And i.TipoComprobante = TipoComprobante And i.Year = CInt(Year)).FirstOrDefault()
        End Using
    End Function

    Shared Function UpdateFolioFacturas(ByVal strFolioFacturas As tblFoliofacturas) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.tblFoliofacturas.Attach(strFolioFacturas)
                ctx.Entry(strFolioFacturas).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function GetIntervalFacturas(ByVal startDate As String, ByVal endDate As String) As List(Of tblFacturaTotal)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblFacturaTotals.Where(Function(i) i.IdComp = CompanyCode And i.fecha_venta >= CDate(startDate) And i.fecha_venta <= CDate(endDate)).ToList
        End Using
    End Function

    Shared Function GetNCIntervalFacturas(ByVal startDate As String, ByVal endDate As String) As List(Of tblNC)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblNCs.Where(Function(i) i.IdComp = CompanyCode And i.fecha_venta >= CDate(startDate) And i.fecha_venta <= CDate(endDate)).ToList
        End Using
    End Function

    Shared Function GetFacturaByN(ByVal nFactura As String) As List(Of tblFactura)
        Using ctx As New pvEntitiesSalvador
            Return ctx.tblFacturas.Where(Function(i) i.IdComp = CompanyCode And i.n_factura = CLng(nFactura)).ToList
        End Using
    End Function

    Shared Function GetFacturasHeaderByIdCliente(ByVal IdCliente As String) As List(Of tblFacturaTotal)
        Using ctx As New pvEntitiesSalvador
            Return ctx.tblFacturaTotals.Where(Function(i) i.IdComp = CompanyCode And i.id_cliente = IdCliente).ToList
        End Using
    End Function

    Shared Function GetFacturasHeaderByIdClienteFechaVenta(ByVal IdCliente As String, ByVal FechaVentaFrom As String, ByVal FechaVentaTo As String) As List(Of tblFacturaTotal)
        Using ctx As New pvEntitiesSalvador
            Return ctx.tblFacturaTotals.Where(Function(i) i.IdComp = CompanyCode And
                                                  i.id_cliente = IdCliente And
                                                  i.fecha_venta >= CDate(FechaVentaFrom) And
                                                  i.fecha_venta <= CDate(FechaVentaTo)).ToList
        End Using
    End Function

    Shared Function GetFacturasHeaderByIdClienteFechaVentaCancelados(ByVal IdCliente As String, ByVal FechaVentaFrom As String, ByVal FechaVentaTo As String, ByVal Cancelados As Boolean) As List(Of tblFacturaTotal)
        Using ctx As New pvEntitiesSalvador
            Return ctx.tblFacturaTotals.Where(Function(i) i.IdComp = CompanyCode And
                                                  i.id_cliente = IdCliente And
                                                  i.fecha_venta >= CDate(FechaVentaFrom) And
                                                  i.fecha_venta <= CDate(FechaVentaTo)).ToList
            'Return ctx.tblFacturaTotals.Where(Function(i) i.IdComp = CompanyCode And
            '                                      i.id_cliente = IdCliente And
            '                                      i.fecha_venta >= CDate(FechaVentaFrom) And
            '                                      i.fecha_venta <= CDate(FechaVentaTo) And
            '                                      CBool(i.Cancelada) = Cancelados).ToList
        End Using
    End Function

    Shared Function GetFacturasHeaderByIdClienteFechaVentaPagados(ByVal IdCliente As String, ByVal FechaVentaFrom As String, ByVal FechaVentaTo As String, ByVal Pagados As Boolean) As List(Of tblFacturaTotal)
        Using ctx As New pvEntitiesSalvador
            Return ctx.tblFacturaTotals.Where(Function(i) i.IdComp = CompanyCode And
                                                  i.id_cliente = IdCliente And
                                                  i.fecha_venta >= CDate(FechaVentaFrom) And
                                                  i.fecha_venta <= CDate(FechaVentaTo)).ToList
            'Return ctx.tblFacturaTotals.Where(Function(i) i.IdComp = CompanyCode And
            '                                      i.id_cliente = IdCliente And
            '                                      i.fecha_venta >= CDate(FechaVentaFrom) And
            '                                      i.fecha_venta <= CDate(FechaVentaTo) And
            '                                      CBool(i.ComproPago) = Pagados).ToList
        End Using
    End Function

    Shared Function GetFacturasHeaderByIdClienteFechaVentaCanceladosPagados(ByVal IdCliente As String, ByVal FechaVentaFrom As String, ByVal FechaVentaTo As String, ByVal Cancelados As Boolean, ByVal Pagados As Boolean) As List(Of tblFacturaTotal)
        Using ctx As New pvEntitiesSalvador
            Return ctx.tblFacturaTotals.Where(Function(i) i.IdComp = CompanyCode And
                                                  i.id_cliente = IdCliente And
                                                  i.fecha_venta >= CDate(FechaVentaFrom) And
                                                  i.fecha_venta <= CDate(FechaVentaTo)).ToList
            'Return ctx.tblFacturaTotals.Where(Function(i) i.IdComp = CompanyCode And
            '                                      i.id_cliente = IdCliente And
            '                                      i.fecha_venta >= CDate(FechaVentaFrom) And
            '                                      i.fecha_venta <= CDate(FechaVentaTo) And
            '                                      CBool(i.Cancelada) = Cancelados And
            '                                      CBool(i.ComproPago) = Pagados).ToList
        End Using
    End Function

    Shared Function GetVenta(ByVal nFactura As String) As List(Of tblVenta)
        Using ctx As New pvEntitiesSalvador()
            Dim facturas As List(Of tblFactura) = GetFacturaByN(nFactura)
            Dim r As List(Of tblVenta) = New List(Of tblVenta)
            Dim nFolios As List(Of String) = New List(Of String)
            Dim ind As Long
            Dim iTo As Long = facturas.LongCount - 1
            For ind = 0 To iTo
                Dim folio As String = facturas(CInt(ind)).folio
                If nFolios.Contains(folio) Then

                Else
                    Dim temp As List(Of tblVenta) = ctx.tblVentas.Where(Function(i) i.IdComp = CompanyCode And i.nticket = CLng(folio)).ToList
                    Dim inde As Long
                    Dim iToe As Long = temp.LongCount - 1
                    For inde = 0 To iToe
                        r.Add(temp(CInt(inde)))
                    Next
                    nFolios.Add(folio)
                End If
            Next
            Return r
        End Using
    End Function

    Shared Function GetFolios() As List(Of tblFoliofacturas)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblFolioFacturas.Where(Function(i) i.IdComp = CompanyCode).ToList
        End Using
    End Function

    Shared Function InsertFolio(ByVal nFolio As tblFoliofacturas) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador
                ctx.tblFoliofacturas.Add(nFolio)
                ctx.SaveChanges()
                Return True
            End Using
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return False
        End Try
    End Function

    Shared Function GetNCDetalle(ByVal n_nc As Long) As List(Of tblNcDetalle)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblNcDetalles.Where(Function(i) i.IdComp = CompanyCode And i.n_nc = n_nc).ToList
        End Using
    End Function

    Shared Function GetFormaDePagoByKey(ByVal FormaDePagoKey As String) As tblFormaDePago
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblFormaDePagoes.Where(Function(i) i.IdComp = CompanyCode And i.FormaPago.Contains(FormaDePagoKey)).FirstOrDefault
        End Using
    End Function
    Shared Function GetRegimenFiscalByKey(ByVal RegimenFiscalKey As String) As tblregimenfiscal
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblregimenfiscals.Where(Function(i) i.Clave.Equals(RegimenFiscalKey)).FirstOrDefault
        End Using
    End Function

    Shared Function GetFormaDePago_All() As List(Of tblFormaDePago)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblFormaDePagoes.Where(Function(i) i.IdComp = CompanyCode).ToList()
        End Using
    End Function

    Shared Function GetMetodoDePagoByKey(ByVal MetodoDePagoKey As String) As tblmetodopago
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblmetodopagoes.Where(Function(i) i.IdComp = CompanyCode And i.MetodoPago.Contains(MetodoDePagoKey)).FirstOrDefault
        End Using
    End Function

    Shared Function GetMetodoDePago_All() As List(Of tblmetodopago)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblmetodopagoes.Where(Function(i) i.IdComp = CompanyCode).ToList()
        End Using
    End Function

    Shared Function GetTipoRelacion_All() As List(Of tblTipoDeRelacion)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblTipoDeRelacions.Where(Function(i) i.IdComp = CompanyCode).ToList()
        End Using
    End Function

    Shared Function GetTipoRelacion_ByKey(ByVal keyTipo As String) As tblTipoDeRelacion
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblTipoDeRelacions.Where(Function(i) i.IdComp = CompanyCode And i.TipoRelacion.Contains(keyTipo)).FirstOrDefault
        End Using
    End Function

    Shared Function GetUsoCFDIByKey(ByVal UsoCFDIKey As String) As tblUsoDeCFDI
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblUsoDeCFDIs.Where(Function(i) i.IdComp = CompanyCode And i.UsoCFDI.Contains(UsoCFDIKey)).FirstOrDefault
        End Using
    End Function

    Shared Function GetUsoCFDI_All() As List(Of tblUsoDeCFDI)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblUsoDeCFDIs.Where(Function(i) i.IdComp = CompanyCode).ToList()
        End Using
    End Function

    Shared Function GetFacturaHeader(ByVal NumeroFactura As String) As tblFacturaTotal
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblFacturaTotals.Where(Function(i) i.IdComp = CompanyCode And i.n_factura.Equals(CDec(NumeroFactura))).FirstOrDefault
        End Using
    End Function

    Shared Function GetComplementoPagoH(ByVal NoPago As String) As tblComplementoPagosH
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblComplementoPagosHes.Where(Function(i) i.IdComp = CompanyCode And i.n_pago.Equals(CInt(NoPago))).FirstOrDefault
        End Using
    End Function

    Shared Function UpdateComplementoPagoH(ByVal strComplementoH As tblComplementoPagosH) As Boolean
        Try
            Using ctx As New pvEntitiesSalvador()
                ctx.tblComplementoPagosHes.Attach(strComplementoH)
                ctx.Entry(strComplementoH).State = EntityState.Modified
                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Shared Function GetComplementoPagoD(ByVal NoPago As String) As List(Of TblComplementoPagosD)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.TblComplementoPagosDs.Where(Function(i) i.IdComp = CompanyCode And i.n_pago.Equals(CDec(NoPago))).ToList()
        End Using
    End Function

    Shared Function GetComplementoPagoD_ByFactura(ByVal NoFactura As String) As List(Of TblComplementoPagosD)
        Using ctx As New pvEntitiesSalvador()
            Return ctx.TblComplementoPagosDs.Where(Function(i) i.IdComp = CompanyCode And i.n_factura.Equals(CInt(NoFactura))).ToList()
        End Using
    End Function

    Shared Function GetNotaCreditoHeader(ByVal NumeroNota As String) As tblNC
        Using ctx As New pvEntitiesSalvador()
            Return ctx.tblNCs.Where(Function(i) i.IdComp = CompanyCode And i.n_nc = CDec(NumeroNota)).FirstOrDefault
        End Using
    End Function

#End Region

End Class
