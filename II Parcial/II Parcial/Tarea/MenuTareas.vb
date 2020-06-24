Public Class MenuTareas
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBolsaSolidaria.Click
        entregaBolsaSolidaria.Show()
    End Sub
End Class