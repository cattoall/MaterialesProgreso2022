Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class clsMySQL
    Private myConexion As New SqlConnection
    Private myComando As New SqlCommand

    Public Sub New(ByVal dbName As String)
        Try
            Select Case dbName
                Case "Wendy"
                    DBConnected = "Wendy"
                    myConexion.ConnectionString = gv_ConStringWendy
                Case "Librada"
                    DBConnected = "Librada"
                    myConexion.ConnectionString = gv_ConStringLibrada
                Case "Salvador"
                    DBConnected = "Salvador"
                    myConexion.ConnectionString = gv_ConStringSalvador
            End Select
            myConexion.Open()
            myComando.Connection = myConexion
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error - clsMySQL Sub New Method")
        End Try
    End Sub

    Public Function EjecutarSQL(ByVal SentenciaSQL As String, Optional ByVal Parametros As List(Of SqlParameter) = Nothing) As Boolean
        Try
            Dim transaction As SqlTransaction = myConexion.BeginTransaction()
            myComando = New SqlCommand(SentenciaSQL, myConexion)
            If (Parametros IsNot Nothing) Then
                For Each p As SqlParameter In Parametros
                    myComando.Parameters.Add(p)
                Next
            End If
            myAdapter.SelectCommand = myComando
            myAdapter.Fill(myDs)
            transaction.Commit()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error - clsMySQL Sub EjecutarSQL Method")
            Return False
        End Try
    End Function

    Public Function EjecutarSQLTable(ByVal SentenciaSQL As String, ByRef tblResult As DataTable) As Boolean
        Try
            Dim transaction As SqlTransaction = myConexion.BeginTransaction()
            myAdapter = New SqlDataAdapter(SentenciaSQL, myConexion)
            tblResult.Clear()
            tblResult.Dispose()
            tblResult.Reset()
            tblResult = New DataTable
            myAdapter.Fill(tblResult)
            transaction.Commit()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error - clsMySQL Sub EjecutarSQLTable Method")
            Return False
        End Try
    End Function

    Public Sub Clear()
        Try
            myComando.Dispose()
            myDs.Tables.Clear()
            myDs.Dispose()
            myDs.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error - clsMySQL Sub Dispose Method")
        End Try
    End Sub

    Public Sub Dispose()
        Try
            myConexion.Close()
            myConexion.Dispose()
            myComando.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error - clsMySQL Sub Dispose Method")
        End Try
    End Sub

End Class

