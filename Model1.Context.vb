﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.Core.Objects
Imports System.Linq

Partial Public Class pv_salvadorEntities1
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=pv_salvadorEntities1")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property tblClientes() As DbSet(Of tblClientes)
    Public Overridable Property tblCobrars() As DbSet(Of tblCobrar)
    Public Overridable Property TblComplementoPagosDs() As DbSet(Of TblComplementoPagosD)
    Public Overridable Property tblComplementoPagosHes() As DbSet(Of tblComplementoPagosH)
    Public Overridable Property tblCompras() As DbSet(Of tblCompra)
    Public Overridable Property tblConfiguracions() As DbSet(Of tblConfiguracion)
    Public Overridable Property tblCotizacions() As DbSet(Of tblCotizacion)
    Public Overridable Property tblFacturaTotals() As DbSet(Of tblFacturaTotal)
    Public Overridable Property tblFacturas() As DbSet(Of tblFactura)
    Public Overridable Property tblFamilias() As DbSet(Of tblFamilia)
    Public Overridable Property tblFolioFacturas() As DbSet(Of tblFolioFacturas)
    Public Overridable Property tblFoliosTickets() As DbSet(Of tblFoliosTicket)
    Public Overridable Property tblGrupos() As DbSet(Of tblGrupos)
    Public Overridable Property tblHistorialPagos() As DbSet(Of tblHistorialPagos)
    Public Overridable Property tblHistorialPagosProveedores() As DbSet(Of tblHistorialPagosProveedores)
    Public Overridable Property tblLineas() As DbSet(Of tblLinea)
    Public Overridable Property tblMarcas1() As DbSet(Of tblMarcas)
    Public Overridable Property tblNCs() As DbSet(Of tblNC)
    Public Overridable Property tblNcDetalles() As DbSet(Of tblNcDetalle)
    Public Overridable Property tblOrdenCompras() As DbSet(Of tblOrdenCompra)
    Public Overridable Property tblOrdenCompraDes() As DbSet(Of tblOrdenCompraDe)
    Public Overridable Property tblPagars() As DbSet(Of tblPagar)
    Public Overridable Property productos() As DbSet(Of tblProductos)
    Public Overridable Property tblProveedors() As DbSet(Of tblProveedor)
    Public Overridable Property tblSalidas() As DbSet(Of tblSalida)
    Public Overridable Property tblSubFamilias() As DbSet(Of tblSubFamilia)
    Public Overridable Property tblBancoes1() As DbSet(Of tblBanco)
    Public Overridable Property tblDiasCreditoes1() As DbSet(Of tblDiasCredito)
    Public Overridable Property tblFormaPagoes1() As DbSet(Of tblFormaPago)
    Public Overridable Property tblMetodoPagoes1() As DbSet(Of tblMetodoPago)
    Public Overridable Property tblParametroes1() As DbSet(Of tblParametro)
    Public Overridable Property tblTipoDeRelacions() As DbSet(Of tblTipoDeRelacion)
    Public Overridable Property tblUsoCFDIs1() As DbSet(Of tblUsoCFDI)
    Public Overridable Property tblTickets() As DbSet(Of tblTicket)
    Public Overridable Property tblTicketComs() As DbSet(Of tblTicketCom)
    Public Overridable Property tblTicketCotizas() As DbSet(Of tblTicketCotiza)
    Public Overridable Property tblTicketPedidoes() As DbSet(Of tblTicketPedido)
    Public Overridable Property tblUnidades() As DbSet(Of tblUnidades)
    Public Overridable Property tblUsuarios1() As DbSet(Of tblUsuarios)
    Public Overridable Property tblVentas() As DbSet(Of tblVenta)
    Public Overridable Property tblVentaPedidoes() As DbSet(Of tblVentaPedido)

    Public Overridable Function SP_DB_BACKUP(databaseName As String, fullPath As String) As Integer
        Dim databaseNameParameter As ObjectParameter = If(databaseName IsNot Nothing, New ObjectParameter("DatabaseName", databaseName), New ObjectParameter("DatabaseName", GetType(String)))

        Dim fullPathParameter As ObjectParameter = If(fullPath IsNot Nothing, New ObjectParameter("FullPath", fullPath), New ObjectParameter("FullPath", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("SP_DB_BACKUP", databaseNameParameter, fullPathParameter)
    End Function

End Class
