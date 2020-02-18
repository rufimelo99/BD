Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class HistoricoEmpregados
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim tableFuncionarios As New DataTable("Funcionarios")
    Dim tableCozinheiros As New DataTable("Cozinheiros")

    Private Function LoadTabelas() As Integer
        tableFuncionarios.Clear()
        tableCozinheiros.Clear()
        CN = New SqlConnection("Data Source = " + "tcp:mednat.ieeta.pt\SQLSERVER,8101" + " ;" + "Initial Catalog = " + "p6g8" + "; uid = " + "p6g8" + ";" + "password = " + "1358054973@Bdd")

        Try

            CN.Open()
        Catch ex As Exception

        End Try

        Dim sqlcmd As New SqlCommand("EXEC Get_Funcionarios_Info ;", CN)

        Dim reader As SqlDataReader
        reader = sqlcmd.ExecuteReader()
        While reader.Read()

            Dim ID_Funcionario As String = ""
            Dim Nome As String = ""
            Dim Ativo As String = ""

            ID_Funcionario = Convert.ToString(reader.Item("ID_Funcionario"))
            Nome = Convert.ToString(reader.Item("Nome"))
            Ativo = Convert.ToString(reader.Item("Ativo"))

            If Ativo = True Then

                tableFuncionarios.Rows.Add(ID_Funcionario, Nome, "Sim")
            Else

                tableFuncionarios.Rows.Add(ID_Funcionario, Nome, "Não")
            End If
        End While
        DataGridView2.DataSource = tableFuncionarios

        reader.Close()

        Dim sqlcmd2 As New SqlCommand("EXEC Get_Cozinheiros_Info ;", CN)

        Dim reader2 As SqlDataReader
        reader2 = sqlcmd2.ExecuteReader()
        While reader2.Read()

            Dim ID_Cozinheiro As String = ""
            Dim Nome As String = ""
            Dim Ativo As String = ""

            ID_Cozinheiro = Convert.ToString(reader2.Item("ID_Cozinheiro"))
            Nome = Convert.ToString(reader2.Item("Nome"))
            Ativo = Convert.ToString(reader2.Item("Ativo"))

            If Ativo = True Then
                tableCozinheiros.Rows.Add(ID_Cozinheiro, Nome, "Sim")
            Else

                tableCozinheiros.Rows.Add(ID_Cozinheiro, Nome, "Não")
            End If

        End While
        DataGridView1.DataSource = tableCozinheiros

        reader2.Close()
    End Function


    Private Sub HistoricoEmpregados_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        tableFuncionarios.Columns.Add("ID", Type.GetType("System.String"))
        tableFuncionarios.Columns.Add("Nome", Type.GetType("System.String"))
        tableFuncionarios.Columns.Add("Ativo", Type.GetType("System.String"))
        tableCozinheiros.Columns.Add("ID", Type.GetType("System.String"))
        tableCozinheiros.Columns.Add("Nome", Type.GetType("System.String"))
        tableCozinheiros.Columns.Add("Ativo", Type.GetType("System.String"))
        LoadTabelas()
    End Sub

End Class