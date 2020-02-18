Imports System.Data.SqlClient

Public Class Menu
    Dim CN As New SqlConnection("Data Source = " + "tcp:mednat.ieeta.pt\SQLSERVER,8101" + " ;" + "Initial Catalog = " + "p6g8" + "; uid = " + "p6g8" + ";" + "password = " + "1358054973@Bdd")
    Dim CMD As SqlCommand
    Dim tableMenu As New DataTable("Pedido")


    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nomeHamburguer As String = ""
        Dim PrecoHamburguer As String = ""
        Dim DescricaoHamburguer As String = ""
        Try
            CN.Open()
        Catch ex As Exception
        End Try

        tableMenu.Columns.Add("Hamburguer", Type.GetType("System.String"))
        tableMenu.Columns.Add("Preco", Type.GetType("System.String"))
        tableMenu.Columns.Add("Descricao", Type.GetType("System.String"))


        Dim sqlcmd As New SqlCommand("EXEC VerMenuHamburguers;", CN)
        Try
            Dim reader As SqlDataReader
            reader = sqlcmd.ExecuteReader()
            While reader.Read()


                nomeHamburguer = Convert.ToString(reader.Item("Nome_Hamburguer1"))
                PrecoHamburguer = Convert.ToString(reader.Item("Preco_Hamburguer"))
                DescricaoHamburguer = Convert.ToString(reader.Item("Descricao"))


                tableMenu.Rows.Add(nomeHamburguer, PrecoHamburguer, DescricaoHamburguer)
            End While

            Exit Try



        Catch ex As Exception

            Exit Try

        End Try

        DataGridView1.DataSource = tableMenu

    End Sub

End Class