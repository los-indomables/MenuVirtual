Public Class Frmcomida
    Dim comida As New ComidaRapida

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnHamburguesas.Click
        DGVComida.Columns.Clear()
        comida.actualizar(DGVComida, "Select nombre,descripcion,'$'+CONVERT(varchar,cast(((precio))as money),8)precio from comidas where Tipo_id = 4")
        DGVComida.Columns(0).Width = 300
        DGVComida.Columns(1).Width = 500
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnSandwiches.Click
        DGVComida.Columns.Clear()
        comida.actualizar(DGVComida, "Select nombre,descripcion,'$'+CONVERT(varchar,cast(((precio))as money),8)precio from comidas where Tipo_id = 3")
        DGVComida.Columns(0).Width = 300
        DGVComida.Columns(1).Width = 500
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnInfantil.Click
        DGVComida.Columns.Clear()
        comida.actualizar(DGVComida, "Select nombre,descripcion,'$'+CONVERT(varchar,cast(((precio))as money),8)precio from comidas where Tipo_id = 2")
        DGVComida.Columns(0).Width = 300
        DGVComida.Columns(1).Width = 500
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnEnsaladas.Click
        DGVComida.Columns.Clear()
        comida.actualizar(DGVComida, "Select nombre,descripcion,'$'+CONVERT(varchar,cast(((precio))as money),8)precio from comidas where Tipo_id = 9")
        DGVComida.Columns(0).Width = 300
        DGVComida.Columns(1).Width = 500
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnMariscos.Click
        DGVComida.Columns.Clear()
        comida.actualizar(DGVComida, "Select nombre,descripcion,'$'+CONVERT(varchar,cast(((precio))as money),8)precio from comidas where Tipo_id = 5")
        DGVComida.Columns(0).Width = 300
        DGVComida.Columns(1).Width = 500
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BtnPollos.Click
        DGVComida.Columns.Clear()
        comida.actualizar(DGVComida, "Select nombre,descripcion,'$'+CONVERT(varchar,cast(((precio))as money),8)precio from comidas where Tipo_id = 7")
        DGVComida.Columns(0).Width = 300
        DGVComida.Columns(1).Width = 500
    End Sub

    Private Sub Frmcomida_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs)
        Dim cantidad As New FrmCantidad

        cantidad.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        DGVComida.Columns.Clear()
        comida.actualizar(DGVComida, "Select nombre,descripcion,'$'+CONVERT(varchar,cast(((precio))as money),8)precio from comidas where Tipo_id = 6")
        DGVComida.Columns(0).Width = 300
        DGVComida.Columns(1).Width = 500
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles BtnCarnes.Click
        DGVComida.Columns.Clear()
        comida.actualizar(DGVComida, "Select nombre,descripcion,'$'+CONVERT(varchar,cast(((precio))as money),8)precio from comidas where Tipo_id = 8")
        DGVComida.Columns(0).Width = 300
        DGVComida.Columns(1).Width = 500
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles btnAntojitos.Click
        DGVComida.Columns.Clear()
        comida.actualizar(DGVComida, "Select nombre,'$'+CONVERT(varchar,cast(((precio))as money),8)precio from comidas where Tipo_id = 1")
        DGVComida.Columns(0).Width = 740

    End Sub
End Class