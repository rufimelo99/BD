Imports System.Data.SqlClient
Public Class CriarConta
    Dim CN As New SqlConnection("Data Source = " + "tcp:mednat.ieeta.pt\SQLSERVER,8101" + " ;" + "Initial Catalog = " + "p6g8" + "; uid = " + "p6g8" + ";" + "password = " + "1358054973@Bdd")
    Dim CMD As SqlCommand

    Dim telefone As String = ""
    Dim name As String = ""
    Dim morada As String = ""
    Dim nif As String = ""
    Dim pass As String = ""

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim OBJ As New Login
        OBJ.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlcmd_verifi As New SqlCommand("EXEC VerDadosLogIn @Login_username_input=" + tlm_input.Text.ToString + ";", CN)
        Try
            CN.Open()
        Catch ex As Exception

        End Try

        Dim reader As SqlDataReader
            reader = sqlcmd_verifi.ExecuteReader()
        Dim pass As String
        Try

            While reader.Read()

                pass = Convert.ToString(reader.Item("Pass"))

            End While
            MsgBox("Conta já existente")
        Catch ex As Exception

            If password_input.Text = confirmar_password_input.Text Then
                If password_input.Text.Length > 3 Then

                    Try
                        CN.Open()
                    Catch ex1 As Exception
                    End Try





                    Dim command3 As New SqlCommand("EXEC CriarConta @Num_Telefone=" + tlm_input.Text.ToString + ", @NIF=" + nif_input.Text.ToString + ";", CN)

                    If command3.ExecuteNonQuery() = 1 Then
                        ' MessageBox.Show("cmm3 deu ")

                    Else
                        '   MessageBox.Show("cmmd3 nao deu")
                    End If

                    Dim command As New SqlCommand("EXEC AlterarDadosCliente @Morada='" + morada_input.Text.ToString + "', @Nome='" + nome_input.Text.ToString + "',@numero_tlm=" + tlm_input.Text + ";", CN)


                    Dim command2 As New SqlCommand("EXEC AlterarPass  @Pass='" + password_input.Text.ToString + "',@numero_tlm=4252393837;", CN)



                    If command.ExecuteNonQuery() = 1 AndAlso command2.ExecuteNonQuery() = 1 Then
                        MessageBox.Show("Data Updated")
                        Dim OBJ As New Login
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


        End Try
        reader.Close()




    End Sub
End Class