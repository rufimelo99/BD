Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class Form3
    Public Property Usertlm As String
    Public Property UserName As String
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim tableHistorico As New DataTable("Historico")


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CN = New SqlConnection("Data Source = " + "tcp:mednat.ieeta.pt\SQLSERVER,8101" + " ;" + "Initial Catalog = " + "p6g8" + "; uid = " + "p6g8" + ";" + "password = " + "1358054973@Bdd")
        CN.Open()



        Dim sqlcmd As New SqlCommand("EXEC VerPedidosUser @numero_tlm=" + Usertlm + ";", CN)

        tableHistorico.Columns.Add("Número do Pedido", Type.GetType("System.String"))
        tableHistorico.Columns.Add("Nome do Hamburguer", Type.GetType("System.String"))
        tableHistorico.Columns.Add("Quantidade", Type.GetType("System.String"))
        tableHistorico.Columns.Add("Data", Type.GetType("System.String"))


        Dim reader As SqlDataReader
        reader = sqlcmd.ExecuteReader()
            While reader.Read()

            Dim No_Pedido As String = ""
            Dim Nome_Hamburguer As String = ""
            Dim Quantidade As String = ""
            Dim Data As String = ""

            No_Pedido += Convert.ToString(reader.Item("No_Pedido"))
            Nome_Hamburguer += Convert.ToString(reader.Item("Nome_Hamburguer"))
            Quantidade += Convert.ToString(reader.Item("Quantidade"))
            Data += Convert.ToString(reader.Item("Data_Pedido"))

            'MsgBox(“nome: ” + nome, MsgBoxStyle.OkOnly, “Log in Form”)
            'MsgBox(“pass: ” + pass, MsgBoxStyle.OkOnly, “Log in Form”)
            'MsgBox(“tlm: ” + tlm, MsgBoxStyle.OkOnly, “Log in Form”)

            tableHistorico.Rows.Add(No_Pedido, Nome_Hamburguer, Quantidade, Data)
        End While
        DataGridView1.DataSource = tableHistorico
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OBJ As New Form2
        OBJ.Usertlm = Usertlm
        OBJ.UserName = UserName
        OBJ.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim OBJ As New AvaliarPedido
        OBJ.Usertlm = Usertlm
        OBJ.UserName = UserName
        OBJ.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class