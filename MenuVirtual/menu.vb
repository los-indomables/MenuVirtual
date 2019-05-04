Public Class FrmMenu
    Public mesa As Integer
    Dim frmCo As FrmComentar

    Dim hijos As New FormulariosHijos
    Private Sub BtnBebida_Click(sender As Object, e As EventArgs) Handles BtnBebidas.Click
        hijos.Formulario(New frmbebidas, PnContenedor)

    End Sub

    Private Sub BtnComida_Click(sender As Object, e As EventArgs) Handles BtnComida.Click
        hijos.Formulario(New Frmcomida, PnContenedor)
    End Sub

    Private Sub BtnPostres_Click(sender As Object, e As EventArgs) Handles BtnPostres.Click
        hijos.Formulario(New FrmPostres, PnContenedor)
    End Sub

    Private Sub BtnComentario_Click(sender As Object, e As EventArgs) Handles BtnComentario.Click

        If (frmCo Is Nothing) Then
            frmCo = New FrmComentar
            frmCo.Show()
        ElseIf frmCo.isDisposed Then
            frmCo = New FrmComentar
            frmCo.Show()
        Else
            frmCo.WindowState = FormWindowState.Normal
            frmCo.Activate()
        End If
    End Sub

    Private Sub PnContenedor_Paint(sender As Object, e As PaintEventArgs) Handles PnContenedor.Paint

    End Sub

    Private Sub BtnMesero_Click(sender As Object, e As EventArgs) Handles BtnMesero.Click

    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAjuste_Click(sender As Object, e As EventArgs) Handles btnAjuste.Click
        Dim opcion As New Opciones
        opcion.ShowDialog()
    End Sub

    Private Sub BtnOrden_Click(sender As Object, e As EventArgs) Handles BtnOrden.Click
        Dim orden As New FrmOrden
        hijos.Formulario(New FrmOrden, PnContenedor)
    End Sub
End Class
