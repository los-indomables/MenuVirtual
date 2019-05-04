Imports System.Data.SqlClient
Public Class ComidaRapida
    Public Sub actualizar(db As DataGridView, querry As String)
        Dim con As New SqlConnection(My.Settings.Conexion)
        Dim comando As New SqlCommand(querry, con)
        Try
            Dim da As New SqlDataAdapter(comando)
            Dim ds As New DataSet
            da.Fill(ds, "Comida")
            db.DataSource = ds.Tables("Comida")

        Catch ex As Exception
        End Try
    End Sub
End Class
