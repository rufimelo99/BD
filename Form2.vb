
Imports System.Data.SqlClient
Public Class Form2
    Public Property Usertlm As String
    Public Property UserName As String
    Dim CN As New SqlConnection("Data Source = " + "tcp:mednat.ieeta.pt\SQLSERVER,8101" + " ;" + "Initial Catalog = " + "p6g8" + "; uid = " + "p6g8" + ";" + "password = " + "1358054973@Bdd")

    Dim CMD As SqlCommand

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Bem vindo(a) " + UserName + "!"
        GetSaldoAtual()
        Try
            CN.Open()
        Catch ex As Exception
        End Try
    End Sub
    Private Function GetBudgetCLiente(ByVal Num_Telefone As String) As Decimal
        Try
            CN.Open()
        Catch ex As Exception
        End Try
        Dim budget As Decimal
        Dim sqlcmd As New SqlCommand("EXEC Get_Budget_Cliente @Num_Telefone='" + Num_Telefone + "';", CN)
        Dim reader2 As SqlDataReader
        reader2 = sqlcmd.ExecuteReader
        While reader2.Read
            budget = reader2.Item("BUDGET")

        End While
        reader2.Close()
        ' MsgBox(budget)
        Return budget


    End Function
    Private Function GetSaldoAtual()

        Dim Despesa_Atual As Decimal
        Despesa_Atual = 0
        Despesa_Atual = GetBudgetCLiente(Usertlm)
        Label5.Text = "Saldo: " + Despesa_Atual.ToString
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OBJ As New Form3
        OBJ.Usertlm = Usertlm
        OBJ.UserName = UserName
        OBJ.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim OBJ As New RealizarPedido

        OBJ.Usertlm = Usertlm
        OBJ.UserName = UserName
        OBJ.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button2.KeyPress

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim OBJ As New Login
        OBJ.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim OBJ As New Menu
        OBJ.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim OBJ As New AlterarDadosConta

        OBJ.Usertlm = Usertlm
        OBJ.UserName = UserName
        OBJ.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim OBJ As New CarregarSaldovb

        OBJ.Usertlm = Usertlm
        OBJ.UserName = UserName
        OBJ.Show()
        Me.Hide()
    End Sub
End Class