Public Class FrmMenu

    Private Sub FrmMenu_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize


    End Sub

    Private Sub BtnBebida_Click(sender As Object, e As EventArgs)
        Dim form As New frmbebidas
        form.MdiParent = Me
        form.Show()
        PnMenu.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnBebidas.Click
        Dim frmbebida As New frmbebidas
        frmbebida.TopLevel = False
        frmbebida.Parent = PnContenedor
        frmbebida.Show()
    End Sub

    Private Sub BtnComida_Click(sender As Object, e As EventArgs) Handles BtnComida.Click
        Dim frmComida As New Frmcomida
        frmComida.TopLevel = False
        frmComida.Parent = PnContenedor
        frmComida.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frmPostres As New FrmPostres
        frmPostres.TopLevel = False
        frmPostres.Parent = PnContenedor
        frmPostres.Show()
    End Sub
End Class
