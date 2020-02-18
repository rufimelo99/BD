Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class Criticas
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim tableCriticas As New DataTable("Criticas")
    Private Sub Criticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CN = New SqlConnection("Data Source = " + "tcp:mednat.ieeta.pt\SQLSERVER,8101" + " ;" + "Initial Catalog = " + "p6g8" + "; uid = " + "p6g8" + ";" + "password = " + "1358054973@Bdd")
        CN.Open()



        Dim sqlcmd As New SqlCommand("EXEC Ver_Criticas;", CN)

        tableCriticas.Columns.Add("Numero do Pedido", Type.GetType("System.String"))
        tableCriticas.Columns.Add("Rating Médio", Type.GetType("System.String"))
        tableCriticas.Columns.Add("Comentario", Type.GetType("System.String"))

        Dim reader As SqlDataReader
        reader = sqlcmd.ExecuteReader()
        While reader.Read()

            Dim No_Pedido As String = ""
            Dim Rating As String = ""
            Dim Comentario As String = ""

            No_Pedido = Convert.ToString(reader.Item("No_Pedido"))
            Rating = Convert.ToString(reader.Item("Rating"))
            Comentario = Convert.ToString(reader.Item("Comentario"))

            'MsgBox(“nome: ” + nome, MsgBoxStyle.OkOnly, “Log in Form”)
            'MsgBox(“pass: ” + pass, MsgBoxStyle.OkOnly, “Log in Form”)
            'MsgBox(“tlm: ” + tlm, MsgBoxStyle.OkOnly, “Log in Form”)

            tableCriticas.Rows.Add(No_Pedido, Rating, Comentario)
        End While
        DataGridView1.DataSource = tableCriticas

        reader.Close()

    End Sub
End Class