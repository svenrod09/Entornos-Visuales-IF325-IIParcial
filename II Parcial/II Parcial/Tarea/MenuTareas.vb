Public Class MenuTareas
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBolsaSolidaria.Click
        entregaBolsaSolidaria.Show()
    End Sub

    Private Sub btnParImpar_Click(sender As Object, e As EventArgs) Handles btnParImpar.Click
        ParesImpares.Show()
    End Sub

    Private Sub btnRegistroProductos_Click(sender As Object, e As EventArgs) Handles btnRegistroProductos.Click
        RegistroProductos.Show()
    End Sub

    Private Sub btnFactura_Click(sender As Object, e As EventArgs) Handles btnFactura.Click
        facturaSencilla.Show()
    End Sub

    Private Sub btnOperaciones_Click(sender As Object, e As EventArgs) Handles btnOperaciones.Click
        operacionesConPotenciaYRaiz.Show()
    End Sub
End Class