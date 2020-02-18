Imports System.Data.SqlClient
Public Class AlterarDadosConta
    Public Property Usertlm As String
    Public Property UserName As String
    Dim CN As New SqlConnection("Data Source = " + "tcp:mednat.ieeta.pt\SQLSERVER,8101" + " ;" + "Initial Catalog = " + "p6g8" + "; uid = " + "p6g8" + ";" + "password = " + "1358054973@Bdd")

    Dim CMD As SqlCommand

    Dim telefone As String = ""
    Dim name As String = ""
    Dim morada As String = ""
    Dim nif As String = ""
    Dim pass As String = ""

    Private Function GetUserPersonalData(ByVal CN As SqlConnection, ByVal num_tlm As String)
        Try
            CN.Open()
        Catch ex As Exception
        End Try
        Dim sqlcmd2 As New SqlCommand("select *
                                        from dbo.Get_Dados_Utilizador ('" + num_tlm + "');", CN)
        Dim reader2 As SqlDataReader
        reader2 = sqlcmd2.ExecuteReader
        While reader2.Read
            name = Convert.ToString(reader2.Item("Nome"))
            telefone = Convert.ToString(reader2.Item("Num_Telefone"))
            morada = Convert.ToString(reader2.Item("Morada"))
            nif = Convert.ToString(reader2.Item("NIF"))
            pass = Convert.ToString(reader2.Item("Pass"))

            nome_input.Text = name
            numero_input.Text = telefone
            morada_input.Text = morada
            nif_input.Text = nif
            'password_input.Text = pass
            'confirmar_password_input.Text = pass




            'MsgBox(name + telefone + morada + nif + pass, MsgBoxStyle.OkOnly, “Log in Form”)

        End While
        reader2.Close()


    End Function

    Private Function ChangeUserPersonalData(ByVal CN As SqlConnection, ByVal num_tlm As String)
        If password_input.Text = confirmar_password_input.Text Then
            If password_input.Text.Length > 3 Then

                Try
                    CN.Open()
                Catch ex As Exception
                End Try
                Dim command As New SqlCommand("EXEC AlterarDadosCliente @Morada='" + morada_input.Text.ToString + "', @Nome='" + nome_input.Text.ToString + "',@numero_tlm=" + Usertlm + ";", CN)




                Dim command2 As New SqlCommand("EXEC AlterarPass  @Pass='" + password_input.Text.ToString + "',@numero_tlm=" + Usertlm + ";", CN)





                If command.ExecuteNonQuery() = 1 AndAlso command2.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Data Updated")
                    Dim OBJ As New Form2
                    OBJ.Usertlm = Usertlm
                    OBJ.UserName = nome_input.Text.ToString
                    OBJ.Show()
                    Me.Hide()

                Else
                    MessageBox.Show("Data Not Updated")
                End If

            Else

                MessageBox.Show("Password demasiado pequena")


            End If

        Else
            MessageBox.Show("Passwords nao sao iguais")

        End If


    End Function



    Private Sub AlterarDadosConta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            CN.Open()

        Catch ex As Exception
        End Try
        GetUserPersonalData(CN, Usertlm)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            CN.Open()

        Catch ex As Exception
        End Try
        ChangeUserPersonalData(CN, Usertlm)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim OBJ As New Form2
        OBJ.Usertlm = Usertlm
        OBJ.UserName = UserName
        OBJ.Show()
        Me.Hide()
    End Sub
End Class