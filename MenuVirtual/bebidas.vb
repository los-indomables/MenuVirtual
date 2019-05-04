Public Class frmbebidas
    Dim bebida As New Bebida

    Private Sub frmbebidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bebida.actualizar(DGVBebida, "select nombre,precio  from bebidas  where tipo_id <> 11")
        DGVBebida.Columns(0).Width = 740

        bebida.actualizar(DGVCervezas, "select nombre,precio  from bebidas  where tipo_id = 11")
        DGVCervezas.Columns(0).Width = 740
    End Sub



    Private Sub DGVCervezas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCervezas.CellClick
        DGVBebida.ClearSelection()

    End Sub

    Private Sub DGVBebida_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVBebida.CellClick
        DGVCervezas.ClearSelection()
    End Sub

    Private Sub DGVBebida_Enter(sender As Object, e As EventArgs) Handles DGVBebida.Enter
        DGVCervezas.ClearSelection()
        DGVBebida.ClearSelection()
    End Sub

End Class