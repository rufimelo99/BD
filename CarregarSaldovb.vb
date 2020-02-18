Imports System.Data.SqlClient
Public Class CarregarSaldovb
    Public Property Usertlm As String
    Public Property UserName As String
    Dim CN As New SqlConnection("Data Source = " + "tcp:mednat.ieeta.pt\SQLSERVER,8101" + " ;" + "Initial Catalog = " + "p6g8" + "; uid = " + "p6g8" + ";" + "password = " + "1358054973@Bdd")
    Dim CMD As SqlCommand

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim OBJ As New Form2

        OBJ.Usertlm = Usertlm
        OBJ.UserName = UserName
        OBJ.Show()
        Me.Hide()
    End Sub

    Private Sub CarregarSaldovb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CN.Open()

        Catch ex As Exception
        End Try
        SALDO.Text = "Saldo: " + GetBudgetCLiente(Usertlm).ToString
    End Sub
    Private Function GetBudgetCLiente(ByVal Num_Telefone As String) As Decimal
        Try
            CN.Open()
        Catch ex As Exception
        End Try
        Dim budget As Decimal
        Dim sqlcmd As New SqlCommand("EXEC Get_Budget_Cliente @Num_Telefone=" + Num_Telefone + ";", CN)
        Dim reader2 As SqlDataReader
        reader2 = sqlcmd.ExecuteReader
        While reader2.Read
            budget = reader2.Item("BUDGET")

        End While
        reader2.Close()
        ' MsgBox(budget)
        Return budget


    End Function
    Private Function RemoverDinheiroMultibanco(ByVal Num_Cartao As String, ByVal CVV As String, ByVal BUDGET As String)
        Try
            CN.Open()
        Catch ex As Exception
        End Try
        Dim sqlcmd As New SqlCommand("EXEC SetBUdgetMultibanco @BUDGET=" + BUDGET + ", @Num_Cartao=" + Num_Cartao + ", @CVV=" + CVV + " ;", CN)

        If sqlcmd.ExecuteNonQuery() = 1 Then

            MsgBox("Transacção efetuada com sucesso 2")

        Else
            MessageBox.Show("Data1 Not Updated")
        End If

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            CN.Open()

        Catch ex As Exception
        End Try
        Dim sqlcmd2 As New SqlCommand("EXEC Get_DadosBancarios @CVV='" + CVV_INPUT.Text + "', @Num_Cartao='" + NUMERO_INPUT.Text + "';", CN)


        Dim reader As SqlDataReader
        reader = sqlcmd2.ExecuteReader()
        Dim saldo_banco As Decimal
        saldo_banco = 0
        While reader.Read()
            saldo_banco = Convert.ToDecimal(reader.Item("Saldo"))

        End While
        reader.Close()
        If saldo_banco <> 0 AndAlso Convert.ToDecimal(QUANTIA_INPUT.Text.ToString) <= Convert.ToDecimal(saldo_banco) Then



            Dim NovoBudget As Decimal
            NovoBudget = GetBudgetCLiente(Usertlm) + Convert.ToDecimal(QUANTIA_INPUT.Text.ToString)
            MsgBox("Novo Budget: " + NovoBudget.ToString)
            Dim command1 As New SqlCommand("EXEC Set_Budget_Cliente @BUDGET=" + NovoBudget.ToString + ", @Num_Telefone=" + Usertlm + " ;", CN)

            If command1.ExecuteNonQuery() = 1 Then

                MsgBox("Transacção efetuada com sucesso")

                Dim saldo_banco_atual As Decimal
                saldo_banco_atual = saldo_banco - Convert.ToDecimal(QUANTIA_INPUT.Text.ToString)
                RemoverDinheiroMultibanco(NUMERO_INPUT.Text, CVV_INPUT.Text, saldo_banco_atual.ToString)
                SALDO.Text = "Saldo: " + GetBudgetCLiente(Usertlm).ToString

            Else
                MessageBox.Show("Data1 Not Updated")
            End If


        Else

            MsgBox("Dados nao válidos")
        End If

    End Sub



    Private Sub QUANTIA_INPUT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QUANTIA_INPUT.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If Me.NUMERO_INPUT.Text.Contains(".") Then
                    If Me.NUMERO_INPUT.Text.Split(".")(1).Length < 2 Then
                        If Char.IsDigit(e.KeyChar) = False Then
                            e.Handled = True
                        End If
                    Else
                        e.Handled = True
                    End If
                End If
            Else
                e.Handled = True
            End If
        End If
    End Sub
End Class