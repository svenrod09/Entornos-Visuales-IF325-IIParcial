Public Class MenuClase
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        MenuEjemplo.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnArreglos_Click(sender As Object, e As EventArgs) Handles btnArreglos.Click
        frmArreglosVectores.Show()
    End Sub

    Private Sub btnLibretaAhorro_Click(sender As Object, e As EventArgs) Handles btnLibretaAhorro.Click
        frmLibretaAhorro.Show()
    End Sub

    Private Sub btnCrud_Click(sender As Object, e As EventArgs) Handles btnCrud.Click
        frmEstudiante.Show()
    End Sub
End Class