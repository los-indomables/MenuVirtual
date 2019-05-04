Public Class Opciones
    Private Sub Opciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim menu As New FrmMenu
        txtMesas.Text = menu.mesa
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim menu As New FrmMenu
        FrmMenu.mesa = txtMesas.Text
        Me.Close()
    End Sub
End Class