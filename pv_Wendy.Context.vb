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

Partial Public Class pvEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=pvEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property tblWClientes() As DbSet(Of tblWClientes)
    Public Overridable Property tblWCobrars() As DbSet(Of tblWCobrar)
    Public Overridable Property compras() As DbSet(Of compra)
    Public Overridable Property tblWConfiguracions() As DbSet(Of tblWConfiguracion)
    Public Overridable Property cotizacions() As DbSet(Of cotizacion)
    Public Overridable Property factura_total() As DbSet(Of factura_total)
    Public Overridable Property facturas() As DbSet(Of factura)
    Public Overridable Property familias() As DbSet(Of familia)
    Public Overridable Property foliosfacturas() As DbSet(Of foliosfactura)
    Public Overridable Property foliostickets() As DbSet(Of foliosticket)
    Public Overridable Property grupos() As DbSet(Of grupos)
    Public Overridable Property tblWHistorialPagos() As DbSet(Of tblWHistorialPagos)
    Public Overridable Property historial_pagos_proveedores() As DbSet(Of historial_pagos_proveedores)
    Public Overridable Property lineas() As DbSet(Of linea)
    Public Overridable Property marcas() As DbSet(Of marca)
    Public Overridable Property ncs() As DbSet(Of nc)
    Public Overridable Property nc_detalle() As DbSet(Of nc_detalle)
    Public Overridable Property ordencompras() As DbSet(Of ordencompra)
    Public Overridable Property ordencomprades() As DbSet(Of ordencomprade)
    Public Overridable Property pagars() As DbSet(Of pagar)
    Public Overridable Property productos() As DbSet(Of producto)
    Public Overridable Property proveedors() As DbSet(Of proveedor)
    Public Overridable Property salidas() As DbSet(Of salida)
    Public Overridable Property subfamilias() As DbSet(Of subfamilia)
    Public Overridable Property tickets() As DbSet(Of ticket)
    Public Overridable Property ticket_com() As DbSet(Of ticket_com)
    Public Overridable Property ticket_cotiza() As DbSet(Of ticket_cotiza)
    Public Overridable Property ticket_pedido() As DbSet(Of ticket_pedido)
    Public Overridable Property unidades() As DbSet(Of unidade)
    Public Overridable Property tblW_Usuarios() As DbSet(Of tblW_Usuarios)
    Public Overridable Property tblWVventas() As DbSet(Of tblWVventa)
    Public Overridable Property tblWVentasPedidos() As DbSet(Of tblWVentasPedidos)

End Class
