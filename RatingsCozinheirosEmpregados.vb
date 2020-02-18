Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class RatingsCozinheirosEmpregados
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim tableRatingsEmpregado As New DataTable("Empregados")
    Dim tableRatingsCozinheiro As New DataTable("Cozinheiro")
    Private Sub RatingsCozinheirosEmpregados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CN = New SqlConnection("Data Source = " + "tcp:mednat.ieeta.pt\SQLSERVER,8101" + " ;" + "Initial Catalog = " + "p6g8" + "; uid = " + "p6g8" + ";" + "password = " + "1358054973@Bdd")
        CN.Open()



        Dim sqlcmd As New SqlCommand("EXEC Ver_Ratings_Cozinheiro  ;", CN)

        tableRatingsCozinheiro.Columns.Add("ID", Type.GetType("System.String"))
        tableRatingsCozinheiro.Columns.Add("Rating Médio", Type.GetType("System.String"))

        Dim reader As SqlDataReader
        reader = sqlcmd.ExecuteReader()
        While reader.Read()

            Dim ID As String = ""
            Dim Rating As String = ""

            ID = Convert.ToString(reader.Item("Cozinheiro_ID"))
            Rating = Convert.ToString(reader.Item("Rating"))
            'MsgBox(“nome: ” + nome, MsgBoxStyle.OkOnly, “Log in Form”)
            'MsgBox(“pass: ” + pass, MsgBoxStyle.OkOnly, “Log in Form”)
            'MsgBox(“tlm: ” + tlm, MsgBoxStyle.OkOnly, “Log in Form”)

            tableRatingsCozinheiro.Rows.Add(ID, Rating)
        End While
        DataGridView1.DataSource = tableRatingsCozinheiro
        reader.Close()


        Dim sqlcmd2 As New SqlCommand("EXEC Ver_Ratings_Funcionario  ;", CN)

        tableRatingsEmpregado.Columns.Add("ID", Type.GetType("System.String"))
        tableRatingsEmpregado.Columns.Add("Rating Médio", Type.GetType("System.String"))

        Dim reader2 As SqlDataReader
        reader2 = sqlcmd2.ExecuteReader()
        While reader2.Read()

            Dim ID As String = ""
            Dim Rating As String = ""

            ID = Convert.ToString(reader2.Item("Funcionario_ID"))
            Rating = Convert.ToString(reader2.Item("Rating"))
            'MsgBox(“nome: ” + nome, MsgBoxStyle.OkOnly, “Log in Form”)
            'MsgBox(“pass: ” + pass, MsgBoxStyle.OkOnly, “Log in Form”)
            'MsgBox(“tlm: ” + tlm, MsgBoxStyle.OkOnly, “Log in Form”)

            tableRatingsEmpregado.Rows.Add(ID, Rating)
        End While
        DataGridView2.DataSource = tableRatingsEmpregado


        reader2.Close()





    End Sub
End Class