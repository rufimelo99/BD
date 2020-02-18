Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class DadosPedidos
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim tablePedidos As New DataTable("Pedidos")

    Private Sub DadosPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CN = New SqlConnection("Data Source = " + "tcp:mednat.ieeta.pt\SQLSERVER,8101" + " ;" + "Initial Catalog = " + "p6g8" + "; uid = " + "p6g8" + ";" + "password = " + "1358054973@Bdd")
        CN.Open()



        Dim sqlcmd As New SqlCommand("EXEC Ver_Dados_Pedidos;", CN)

        tablePedidos.Columns.Add("Número do Pedido", Type.GetType("System.String"))
        tablePedidos.Columns.Add("Nome do Hamburguer", Type.GetType("System.String"))
        tablePedidos.Columns.Add("Quantidade", Type.GetType("System.String"))
        tablePedidos.Columns.Add("Data", Type.GetType("System.String"))
        tablePedidos.Columns.Add("Rating", Type.GetType("System.String"))
        tablePedidos.Columns.Add("Telefone do  Cliente", Type.GetType("System.String"))
        tablePedidos.Columns.Add("ID Funcionario", Type.GetType("System.String"))
        tablePedidos.Columns.Add("ID Cozinheiro", Type.GetType("System.String"))
        tablePedidos.Columns.Add("Descricao", Type.GetType("System.String"))
        tablePedidos.Columns.Add("Total", Type.GetType("System.String"))


        Dim reader As SqlDataReader
        reader = sqlcmd.ExecuteReader()
        While reader.Read()

            Dim No_Pedido As String = ""
            Dim Nome_Hamburguer As String = ""
            Dim Quantidade As String = ""
            Dim Data As String = ""
            Dim Rating As String = ""
            Dim TelefoneCliente As String = ""
            Dim IdFuncionario As String = ""
            Dim IdCozinheiro As String = ""
            Dim Descricao As String = ""
            Dim Total As String = ""

            No_Pedido += Convert.ToString(reader.Item("No_Pedido"))
            Nome_Hamburguer += Convert.ToString(reader.Item("Nome_Hamburguer"))
            Quantidade += Convert.ToString(reader.Item("Quantidade"))
            Data += Convert.ToString(reader.Item("Data_Pedido"))
            Rating += Convert.ToString(reader.Item("Rating"))
            TelefoneCliente += Convert.ToString(reader.Item("Num_Telefone_Cliente"))
            IdFuncionario += Convert.ToString(reader.Item("Funcionario_ID"))
            IdCozinheiro += Convert.ToString(reader.Item("Cozinheiro_ID"))
            Descricao += Convert.ToString(reader.Item("Descricao"))
            Total += Convert.ToString(reader.Item("Total"))


            tablePedidos.Rows.Add(No_Pedido, Nome_Hamburguer, Quantidade, Data, Rating, TelefoneCliente, IdFuncionario, IdCozinheiro, Descricao, Total)
        End While
        DataGridView1.DataSource = tablePedidos
        reader.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            CN.Open()
        Catch ex As Exception

        End Try

        Dim sqlcmd As New SqlCommand("Ver_Dados_Pedidos_porData @Data='" + TextBox1.Text.ToString + "';", CN)

        Dim newtablePedidos As New DataTable("Pedidos")
        Try

            newtablePedidos.Columns.Add("Número do Pedido", Type.GetType("System.String"))
            newtablePedidos.Columns.Add("Nome do Hamburguer", Type.GetType("System.String"))
            newtablePedidos.Columns.Add("Quantidade", Type.GetType("System.String"))
            newtablePedidos.Columns.Add("Data", Type.GetType("System.String"))
            newtablePedidos.Columns.Add("Rating", Type.GetType("System.String"))
            newtablePedidos.Columns.Add("Telefone do  Cliente", Type.GetType("System.String"))
            newtablePedidos.Columns.Add("ID Funcionario", Type.GetType("System.String"))
            newtablePedidos.Columns.Add("ID Cozinheiro", Type.GetType("System.String"))

            newtablePedidos.Columns.Add("Descricao", Type.GetType("System.String"))
            newtablePedidos.Columns.Add("Total", Type.GetType("System.String"))

            Dim reader As SqlDataReader
            reader = sqlcmd.ExecuteReader()
            While reader.Read()

                Dim No_Pedido As String = ""
                Dim Nome_Hamburguer As String = ""
                Dim Quantidade As String = ""
                Dim Data As String = ""
                Dim Rating As String = ""
                Dim TelefoneCliente As String = ""
                Dim IdFuncionario As String = ""
                Dim IdCozinheiro As String = ""

                Dim Descricao As String = ""
                Dim Total As String = ""

                No_Pedido += Convert.ToString(reader.Item("No_Pedido"))
                Nome_Hamburguer += Convert.ToString(reader.Item("Nome_Hamburguer"))
                Quantidade += Convert.ToString(reader.Item("Quantidade"))
                Data += Convert.ToString(reader.Item("Data_Pedido"))
                Rating += Convert.ToString(reader.Item("Rating"))
                TelefoneCliente += Convert.ToString(reader.Item("Num_Telefone_Cliente"))
                IdFuncionario += Convert.ToString(reader.Item("Funcionario_ID"))
                IdCozinheiro += Convert.ToString(reader.Item("Cozinheiro_ID"))
                Descricao += Convert.ToString(reader.Item("Descricao"))
                Total += Convert.ToString(reader.Item("Total"))


                newtablePedidos.Rows.Add(No_Pedido, Nome_Hamburguer, Quantidade, Data, Rating, TelefoneCliente, IdFuncionario, IdCozinheiro, Descricao, Total)
            End While
            DataGridView1.DataSource = newtablePedidos
            reader.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class