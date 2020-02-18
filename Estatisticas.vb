Public Class Estatisticas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OBJ As New PopularidadeHamburguers
        OBJ.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim OBJ As New RatingsCozinheirosEmpregados
        OBJ.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim OBJ As New DadosPedidos
        OBJ.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim OBJ As New Criticas
        OBJ.Show()
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim OBJ As New AdminMenu
        OBJ.Show()
        Me.Hide()
    End Sub
End Class