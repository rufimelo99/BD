Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class AdminGerirContas
    Dim CN As New SqlConnection("Data Source = " + "tcp:mednat.ieeta.pt\SQLSERVER,8101" + " ;" + "Initial Catalog = " + "p6g8" + "; uid = " + "p6g8" + ";" + "password = " + "1358054973@Bdd")
    Dim CMD As SqlCommand
    Dim tableContas As New DataTable("Contas")



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim OBJ As New AdminMenu
        OBJ.Show()
        Me.Hide()
    End Sub

    Private Sub AdminGerirContas_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        tableContas.Columns.Add("Telefone", Type.GetType("System.String"))
        tableContas.Columns.Add("Morada", Type.GetType("System.String"))
        tableContas.Columns.Add("Nome", Type.GetType("System.String"))
        tableContas.Columns.Add("NIF", Type.GetType("System.String"))
        tableContas.Columns.Add("Budget", Type.GetType("System.String"))
        tableContas.Columns.Add("Pass", Type.GetType("System.String"))
        LoadTabelas()
    End Sub
    Private Function LoadTabelas() As Integer
        tableContas.Clear()
        ComboBox1.Items.Clear()
        CN = New SqlConnection("Data Source = " + "tcp:mednat.ieeta.pt\SQLSERVER,8101" + " ;" + "Initial Catalog = " + "p6g8" + "; uid = " + "p6g8" + ";" + "password = " + "1358054973@Bdd")

        Try

            CN.Open()
        Catch ex As Exception

        End Try

        Dim sqlcmd As New SqlCommand("EXEC Get_Info_Todos_Clientes ;", CN)

        Dim reader As SqlDataReader
        reader = sqlcmd.ExecuteReader()
        While reader.Read()

            Dim Num_Telefone As String = ""
            Dim Morada As String = ""
            Dim Nome As String = ""
            Dim NIF As String = ""
            Dim Budget As String = ""
            Dim Pass As String = ""

            Num_Telefone = Convert.ToString(reader.Item("Num_Telefone"))
            Morada = Convert.ToString(reader.Item("Morada"))
            Nome = Convert.ToString(reader.Item("Nome"))
            NIF = Convert.ToString(reader.Item("NIF"))
            Budget = Convert.ToString(reader.Item("BUDGET"))
            Pass = Convert.ToString(reader.Item("Pass"))

            ComboBox1.Items.Add(Num_Telefone)
            tableContas.Rows.Add(Num_Telefone, Morada, Nome, NIF, Budget, Pass)
        End While
        DataGridView1.DataSource = tableContas

        reader.Close()

    End Function

    Private Function LoadInfoCliente(num_tlm As String)

        Dim telefone As String = ""
        Dim name As String = ""
        Dim morada As String = ""
        Dim nif As String = ""
        Dim pass As String = ""
        Dim Budget As String = ""


        Try

            CN.Open()
        Catch ex As Exception

        End Try

        Dim sqlcmd As New SqlCommand("select *
                                        from dbo.Get_Dados_Utilizador ('" + num_tlm + "');", CN)

        Dim reader As SqlDataReader
        reader = sqlcmd.ExecuteReader()
        While reader.Read()



            telefone = Convert.ToString(reader.Item("Num_Telefone"))
            morada = Convert.ToString(reader.Item("Morada"))
            name = Convert.ToString(reader.Item("Nome"))
            nif = Convert.ToString(reader.Item("NIF"))
            Budget = Convert.ToString(reader.Item("BUDGET"))
            pass = Convert.ToString(reader.Item("Pass"))




            nome_input.Text = name
            morada_input.Text = morada

        End While


        reader.Close()
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If password_input.Text = confirmar_password_input.Text Then
            If Saldo_input.Text.Length > 0 Then
                If ComboBox1.SelectedIndex > -1 Then
                    If password_input.Text.Length > 3 Then

                        Try
                            CN.Open()
                        Catch ex As Exception
                        End Try
                        Dim command As New SqlCommand("EXEC AlterarDadosCliente @Morada='" + morada_input.Text.ToString + "', @Nome='" + nome_input.Text.ToString + "',@numero_tlm=" + ComboBox1.SelectedItem.ToString + ";", CN)




                        Dim command2 As New SqlCommand("EXEC AlterarPass  @Pass='" + password_input.Text.ToString + "',@numero_tlm=" + ComboBox1.SelectedItem.ToString + ";", CN)

                        Dim command3 As New SqlCommand("EXEC Set_Budget_Cliente @BUDGET= " + TextBox1.Text + " , @Num_Telefone=" + ComboBox1.SelectedItem.ToString + ";", CN)

                        If command.ExecuteNonQuery() = 1 AndAlso command2.ExecuteNonQuery() = 1 AndAlso command3.ExecuteNonQuery() = 1 Then
                            MessageBox.Show("Data Updated")
                            LoadTabelas()

                        Else
                            MessageBox.Show("Data Not Updated")
                        End If

                    Else

                        MessageBox.Show("Password demasiado pequena")


                    End If

                Else
                    MessageBox.Show("Numero de telemovel nao selecionado")
                End If
            Else
                MessageBox.Show("Saldo nao inserido")
            End If


        Else
            MessageBox.Show("Passwords nao sao iguais")

        End If
    End Sub


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If Me.TextBox1.Text.Contains(".") Then
                    If Me.TextBox1.Text.Split(".")(1).Length < 2 Then
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