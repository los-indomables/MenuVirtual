Public Class FormulariosHijos

    Sub Formulario(ByVal FormularioHijo As Object, panelhijo As Panel)
        If panelhijo.Controls.Count > 0 Then
            panelhijo.Controls.RemoveAt(0)
        End If
        Dim frmhijo As Form = TryCast(FormularioHijo, Form)
        frmhijo.TopLevel = False
        panelhijo.Controls.Add(frmhijo)
        frmhijo.Show()
    End Sub

End Class
