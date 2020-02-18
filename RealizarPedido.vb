Imports System.Data.SqlClient

Public Class RealizarPedido
    Public Property Usertlm As String
    Public Property UserName As String
    Public Pedidos_a_sair As New List(Of String)    'not used
    Dim CN As New SqlConnection("Data Source = " + "tcp:mednat.ieeta.pt\SQLSERVER,8101" + " ;" + "Initial Catalog = " + "p6g8" + "; uid = " + "p6g8" + ";" + "password = " + "1358054973@Bdd")
    Dim CMD As SqlCommand
    Dim tablePedido As New DataTable("Pedido")

    Private Sub RealizarPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetSaldoAtual()


        Dim nomeHamburguer As String = ""
        Try
            CN.Open()
        Catch ex As Exception
        End Try
        ComboBox1.Text = "Select Hamburguer..."
        tablePedido.Columns.Add("Hamburguer", Type.GetType("System.String"))
        tablePedido.Columns.Add("Quant.", Type.GetType("System.String"))
        tablePedido.Columns.Add("Preço", Type.GetType("System.String"))
        DataGridView1.DataSource = tablePedido

        Dim sqlcmd As New SqlCommand("EXEC VerNomeHamburguers;", CN)
        Try
            Dim reader As SqlDataReader
            reader = sqlcmd.ExecuteReader()
            While reader.Read()


                nomeHamburguer += Convert.ToString(reader.Item("Nome_Hamburguer1"))
                ComboBox1.Items.Add(nomeHamburguer)
                nomeHamburguer = ""
            End While
            reader.Close()
            Exit Try



        Catch ex As Exception

            nomeHamburguer = ""
            Exit Try
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex > -1 AndAlso
            TextBox1.Text <> "" Then
            Dim preco As Decimal

            preco = GetDespesaPedido_v2(ComboBox1.SelectedItem.ToString, TextBox1.Text)
            tablePedido.Rows.Add(ComboBox1.SelectedItem.ToString, TextBox1.Text, preco)


            MsgBox("Adicionado com Sucesso ao Carrinho")
            GetPrecoTotalAtual()
        Else
            MsgBox("Parametros nao preenchidos")

        End If
        DataGridView1.DataSource = tablePedido
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back AndAlso
                e.KeyChar <> "." AndAlso
                e.KeyChar <> "/" Then

            e.Handled = True



        End If

    End Sub

    Private Sub LimparPedido(sender As Object, e As EventArgs) Handles Button3.Click
        tablePedido.Clear()
        GetPrecoTotalAtual()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim OBJ As New Form2
        OBJ.Usertlm = Usertlm
        OBJ.UserName = UserName
        OBJ.Show()
        Me.Hide()
    End Sub

    Private Function GetNumeroAtualPedido() As String
        CN = New SqlConnection("Data Source = " + "tcp:mednat.ieeta.pt\SQLSERVER,8101" + " ;" + "Initial Catalog = " + "p6g8" + "; uid = " + "p6g8" + ";" + "password = " + "1358054973@Bdd")
        CN.Open()

        Dim pedido_atual As String
        pedido_atual = ""


        Dim sqlcmd As New SqlCommand("EXEC VerQuantidadePedidos;", CN)
        Dim reader2 As SqlDataReader
        reader2 = sqlcmd.ExecuteReader
        While reader2.Read
            pedido_atual = Convert.ToString(reader2.Item("toal_pedidos") + 1)



            'MsgBox(pedido_atual, MsgBoxStyle.OkOnly, “Log in Form”)

        End While
        reader2.Close()
        Return pedido_atual

    End Function

    Private Function GetDataAtual() As String

        Dim CurrentDateTime As String = DateTime.Now.ToString("yyyy-dd-MM")



        ' MsgBox(CurrentDateTime, MsgBoxStyle.OkOnly, “Log in Form”)


        Return CurrentDateTime

    End Function
    Private Function GetRandomCozinheiro() As Integer
        Try
            CN.Open()
        Catch ex As Exception
        End Try
        Dim total As String
        Dim YourArrayList As ArrayList = New ArrayList()
        Dim tamanhoArray As Integer
        Dim sqlcmd As New SqlCommand("EXEC Get_Cozinehiros_Ativos;", CN)
        Dim reader2 As SqlDataReader
        reader2 = sqlcmd.ExecuteReader
        While reader2.Read
            total = Convert.ToString(reader2.Item("ID_Cozinheiro"))
            tamanhoArray = YourArrayList.Count

            YourArrayList.Add(total)
        End While
        reader2.Close()


        Dim Rand As New Random()
        Dim Index As Integer = Rand.Next(0, YourArrayList.Count)
        Dim rnd As New Random

        Dim SelectedValue = YourArrayList(Index)


        Return SelectedValue


    End Function


    Private Function GetRandomFuncionario() As Integer
        Try
            CN.Open()
        Catch ex As Exception
        End Try
        Dim total As String
        Dim YourArrayList As ArrayList = New ArrayList()
        Dim tamanhoArray As Integer
        Dim sqlcmd As New SqlCommand("EXEC Get_Funcionarios_Ativos ;", CN)
        Dim reader2 As SqlDataReader
        reader2 = sqlcmd.ExecuteReader
        While reader2.Read
            total = Convert.ToString(reader2.Item("ID_Funcionario"))
            tamanhoArray = YourArrayList.Count

            YourArrayList.Add(total)
        End While
        reader2.Close()


        Dim Rand As New Random()
        Dim Index As Integer = Rand.Next(0, YourArrayList.Count)
        Dim rnd As New Random

        Dim SelectedValue = YourArrayList(Index)


        Return SelectedValue


    End Function


    Private Function GetDespesaPedido(ByVal Nu_Pedido As String) As Decimal
        Try
            CN.Open()
        Catch ex As Exception
        End Try
        Dim despesa As Decimal
        Dim sqlcmd As New SqlCommand("EXEC Get_Preco_Pedido @Nu_Pedido=" + Nu_Pedido + ";", CN)
        Dim reader2 As SqlDataReader
        reader2 = sqlcmd.ExecuteReader
        While reader2.Read
            despesa = reader2.Item("Total")

        End While
        reader2.Close()

        Return despesa


    End Function

    Private Function GetDespesaPedido_v2(ByVal Nome_Hamburguer1 As String, ByVal Quantidade As String) As Decimal
        Try
            CN.Open()
        Catch ex As Exception
        End Try
        Dim despesa As Decimal
        Dim sqlcmd As New SqlCommand("EXEC PrecoHamburguer @Nome_Hamburguer1=" + Nome_Hamburguer1 + ";", CN)
        Dim reader2 As SqlDataReader
        reader2 = sqlcmd.ExecuteReader
        While reader2.Read
            despesa = reader2.Item("Preco_Hamburguer")

        End While
        reader2.Close()

        Return despesa * Quantidade


    End Function

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
    Private Function GetPrecoTotalAtual()

        Dim Despesa_Atual As Decimal
        Despesa_Atual = 0
        For Each row As DataRow In tablePedido.Rows
            Despesa_Atual += Convert.ToDecimal(row(2))
        Next
        Total_preco.Text = "Total: " + Despesa_Atual.ToString
    End Function
    Private Function GetSaldoAtual()

        Dim Despesa_Atual As Decimal
        Despesa_Atual = 0
        Despesa_Atual = GetBudgetCLiente(Usertlm)
        Label5.Text = "Saldo: " + Despesa_Atual.ToString
    End Function

    Private Function EnviarHamburguer(ByVal CN As SqlConnection, ByVal No_Pedido As String, ByVal Nome_Hamburguer As String, ByVal Quantidade As Integer, ByVal Rating As Decimal, ByVal Data_Pedido As String, ByVal FuncionarioID As Integer, ByVal CozinheiroID As Integer)


        Try
            CN.Open()
        Catch ex As Exception
        End Try

        'Try
        Dim command1 As New SqlCommand("INSERT INTO PEDIDO (Num_Pedido,Num_Telefone_Cliente,Funcionario_ID,Cozinheiro_ID)
                                        VALUES(@Num_Pedido,@Num_Telefone_Cliente,@Funcionario_ID,@Cozinheiro_ID);", CN)

            command1.Parameters.Add("@Num_Pedido", SqlDbType.Int).Value = No_Pedido
            command1.Parameters.Add("@Num_Telefone_Cliente", SqlDbType.BigInt).Value = Usertlm
            command1.Parameters.Add("@Funcionario_ID", SqlDbType.Int).Value = FuncionarioID
            command1.Parameters.Add("@Cozinheiro_ID", SqlDbType.Int).Value = CozinheiroID

            If command1.ExecuteNonQuery() = 1 Then
            'MessageBox.Show("Data1 Updated")
            'MsgBox("Pedido Criado")
        Else
                'MessageBox.Show("Data1 Not Updated")
            End If



        Dim command As New SqlCommand("INSERT INTO HAMBURGUER_2 (No_Pedido,Nome_Hamburguer,Quantidade,Rating, Data_Pedido)
                                        VALUES(@No_Pedido,@Nome_Hamburguer,@Quantidade,@Rating,@Data_Pedido);", CN)

            command.Parameters.Add("@No_Pedido", SqlDbType.VarChar).Value = No_Pedido
            command.Parameters.Add("@Nome_Hamburguer", SqlDbType.VarChar).Value = Nome_Hamburguer
            command.Parameters.Add("@Quantidade", SqlDbType.Int).Value = Quantidade
            command.Parameters.Add("@Rating", SqlDbType.Decimal).Value = Rating
            command.Parameters.Add("@Data_Pedido", SqlDbType.VarChar).Value = Data_Pedido

            MsgBox(No_Pedido.ToString + Nome_Hamburguer + Quantidade.ToString + "-" + Data_Pedido)
        If command.ExecuteNonQuery() = 1 Then
            'MessageBox.Show("Data Updated")
            Pedidos_a_sair.Add(No_Pedido)
            'MsgBox("HAMBURGUER_2 Criado")
        Else
            'MessageBox.Show("Data Not Updated")
        End If
        'MessageBox.Show("Data Updated")
        'End Try
        'Catch ex As Exception

        '    MessageBox.Show("Data Not Updated")
        'End Try



    End Function




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim RandomCozinheiro As Integer
        Dim RandomFuncionario As Integer


        Dim nomeHamburguer As String = “”
        Dim QuantidadeHamburguer As Integer

        RandomFuncionario = GetRandomFuncionario()
        'MsgBox(RandomFuncionario, MsgBoxStyle.OkOnly, “Log in Form”)
        Dim Despesa_Total As Decimal

        For Each row As DataRow In tablePedido.Rows
            nomeHamburguer = Convert.ToString(row(0))
            QuantidadeHamburguer = Convert.ToInt32(row(1))
            Despesa_Total += GetDespesaPedido_v2(nomeHamburguer, QuantidadeHamburguer)
        Next

        Dim BudgetCliente As Decimal
        BudgetCliente = GetBudgetCLiente(Usertlm)

        MsgBox("Budget na conta: " + BudgetCliente.ToString)
        MsgBox("Despesa Total: " + Despesa_Total.ToString)



        If Despesa_Total < BudgetCliente Then

            Try
                CN.Open()
            Catch ex As Exception
            End Try

            Dim NovoBudget As Decimal
            NovoBudget = GetBudgetCLiente(Usertlm) - Despesa_Total
            MsgBox("Novo Budget: " + NovoBudget.ToString)
            Dim command1 As New SqlCommand("EXEC Set_Budget_Cliente @BUDGET=" + NovoBudget.ToString + ", @Num_Telefone=" + Usertlm + " ;", CN)
            For Each row As DataRow In tablePedido.Rows
                RandomCozinheiro = GetRandomCozinheiro()
                ' MsgBox(RandomCozinheiro, MsgBoxStyle.OkOnly, “Log in Form”)
                Dim pedidoAtual As String
                pedidoAtual = GetNumeroAtualPedido()
                Dim dataAtual As String
                dataAtual = GetDataAtual()
                nomeHamburguer = Convert.ToString(row(0))
                QuantidadeHamburguer = Convert.ToInt32(row(1))
                EnviarHamburguer(CN, pedidoAtual, nomeHamburguer, QuantidadeHamburguer, 5, dataAtual, RandomFuncionario, RandomCozinheiro)

            Next

            If command1.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Compra Efectuada")
                Dim OBJ As New Form2
                OBJ.Usertlm = Usertlm
                OBJ.UserName = UserName
                OBJ.Show()
                Me.Hide()
            Else
                MessageBox.Show("Algo correu mal")
            End If

        Else
            MsgBox("Nao tem saldo  suficiente")


        End If

    End Sub

End Class