Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class PopularidadeHamburguers
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim tablePopularidade As New DataTable("Popularidade")
    Dim tableTotaisVendas As New DataTable("TotaisVendas")

    Private Sub PopularidadeHamburguers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CN = New SqlConnection("Data Source = " + "tcp:mednat.ieeta.pt\SQLSERVER,8101" + " ;" + "Initial Catalog = " + "p6g8" + "; uid = " + "p6g8" + ";" + "password = " + "1358054973@Bdd")
        CN.Open()



        Dim sqlcmd As New SqlCommand("EXEC Ver_Popularidade_Hamburguer  ;", CN)

        tablePopularidade.Columns.Add("Nome do Hamburguer", Type.GetType("System.String"))
        tablePopularidade.Columns.Add("Rating Médio", Type.GetType("System.String"))
        tablePopularidade.Columns.Add("Total Vendido", Type.GetType("System.String"))

        Dim reader As SqlDataReader
        reader = sqlcmd.ExecuteReader()
        While reader.Read()

            Dim Nome_Hamburguer As String = ""
            Dim Rating As String = ""
            Dim total As String = ""

            Nome_Hamburguer = Convert.ToString(reader.Item("Nome_Hamburguer"))
            Rating = Convert.ToString(reader.Item("avaliacao_media"))
            total = Convert.ToString(reader.Item("total"))

            'MsgBox(“nome: ” + nome, MsgBoxStyle.OkOnly, “Log in Form”)
            'MsgBox(“pass: ” + pass, MsgBoxStyle.OkOnly, “Log in Form”)
            'MsgBox(“tlm: ” + tlm, MsgBoxStyle.OkOnly, “Log in Form”)

            tablePopularidade.Rows.Add(Nome_Hamburguer, Rating, total)
        End While
        DataGridView1.DataSource = tablePopularidade
        reader.Close()




        Dim sqlcmd2 As New SqlCommand("EXEC Ver_Receitas;", CN)

        tableTotaisVendas.Columns.Add("Data", Type.GetType("System.String"))
        tableTotaisVendas.Columns.Add("Receita Total", Type.GetType("System.String"))

        Dim reader2 As SqlDataReader
        reader2 = sqlcmd2.ExecuteReader()
        While reader2.Read()

            Dim Data As String = ""
            Dim Receita As String = ""

            Data = Convert.ToString(reader2.Item("Data_Pedido"))
            Receita = Convert.ToString(reader2.Item("Receita"))

            tableTotaisVendas.Rows.Add(Data, Receita)
        End While
        DataGridView2.DataSource = tableTotaisVendas
        reader2.Close()

    End Sub


End Class