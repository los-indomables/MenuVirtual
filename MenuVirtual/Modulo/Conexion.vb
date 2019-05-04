Imports Dapper
Imports System.Data.SqlClient
Module Conexion
    Public Function Conectar() As IDbConnection
        Dim cn As String
        cn = "Data Source=.;Initial Catalog=cayaguanca;Integrated Security=True"
        Dim conexion As New SqlConnection(cn)
        Dim con As IDbConnection = conexion
        Return con
    End Function
End Module
