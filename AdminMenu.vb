Public Class AdminMenu
    Private Sub AdminMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OBJ As New Estatisticas
        OBJ.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim OBJ As New AlterarMenuvb
        OBJ.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim OBJ As New Login
        OBJ.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim OBJ As New GerirFuncionarios
        OBJ.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim OBJ As New AdminGerirContas
        OBJ.Show()
        Me.Hide()
    End Sub
End Class