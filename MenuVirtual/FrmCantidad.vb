Public Class FrmCantidad
    Private Sub FrmCantidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero As Integer
        numero = txtCantidad.Text
        If numero < 10 Then
            numero = txtCantidad.Text
            txtCantidad.Text = numero + 1
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim numero As Integer
        numero = txtCantidad.Text
        If (numero > 0) Then
            txtCantidad.Text = numero - 1
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class