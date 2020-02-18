Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class GerirFuncionarios
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim tableFuncionarios As New DataTable("Funcionarios")
    Dim tableCozinheiros As New DataTable("Cozinheiros")


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim OBJ As New AdminMenu
        OBJ.Show()
        Me.Hide()
    End Sub

    Private Sub GerirFuncionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tableFuncionarios.Columns.Add("ID", Type.GetType("System.String"))
        tableFuncionarios.Columns.Add("Nome", Type.GetType("System.String"))
        '  tableFuncionarios.Columns.Add("Ativo", Type.GetType("System.String"))
        tableCozinheiros.Columns.Add("ID", Type.GetType("System.String"))
        tableCozinheiros.Columns.Add("Nome", Type.GetType("System.String"))
        '  tableCozinheiros.Columns.Add("Ativo", Type.GetType("System.String"))

        LoadTabelas()

        Adicionar_Combo.Items.Add("Cozinheiro")
        Adicionar_Combo.Items.Add("Funcionário")

        Editar_Combo_Nome.Items.Add("Cozinheiro")
        Editar_Combo_Nome.Items.Add("Funcionário")

        Despedir_Combo_Nome.Items.Add("Cozinheiro")
        Despedir_Combo_Nome.Items.Add("Funcionário")


    End Sub
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

                tableFuncionarios.Rows.Add(ID_Funcionario, Nome)
                'tableFuncionarios.Rows.Add(ID_Funcionario, Nome, "Sim")
                '  Else

                '     tableFuncionarios.Rows.Add(ID_Funcionario, Nome, "Não")
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
                tableCozinheiros.Rows.Add(ID_Cozinheiro, Nome)
                '  tableCozinheiros.Rows.Add(ID_Cozinheiro, Nome, "Sim")
                '  Else

                ' tableCozinheiros.Rows.Add(ID_Cozinheiro, Nome, "Não")
            End If

        End While
        DataGridView1.DataSource = tableCozinheiros

        reader2.Close()
    End Function



    Private Function LoadEditar_FuncionarioID() 'LOAD DO COMBO BOX COM ID DE EDITAR, caso seja funcionario ou cozinheiro
        Editar_Combo_ID.Items.Clear()

        Try
            CN.Open()
        Catch ex As Exception
        End Try
        Dim ID_Funcionario As String

        Dim Ativo As String = ""
        Dim sqlcmd1 As New SqlCommand("EXEC Get_Funcionarios_Info ;", CN)
        Try
            Dim reader1 As SqlDataReader
            reader1 = sqlcmd1.ExecuteReader()
            While reader1.Read()


                ID_Funcionario = Convert.ToString(reader1.Item("ID_Funcionario"))
                Ativo = Convert.ToString(reader1.Item("Ativo"))
                If Ativo = True Then
                    Editar_Combo_ID.Items.Add(ID_Funcionario)
                End If


            End While
            reader1.Close()
            Exit Try



        Catch ex As Exception
            Exit Try
        End Try

    End Function

    Private Function LoadEditar_CozinheiroID()
        Editar_Combo_ID.Items.Clear()

        Try
            CN.Open()
        Catch ex As Exception
        End Try
        Dim ID_Funcionario As String

        Dim Ativo As String = ""

        Dim sqlcmd1 As New SqlCommand("EXEC Get_Cozinheiros_Info ;", CN)
        Try
            Dim reader1 As SqlDataReader
            reader1 = sqlcmd1.ExecuteReader()
            While reader1.Read()


                ID_Funcionario = Convert.ToString(reader1.Item("ID_Cozinheiro"))
                Ativo = Convert.ToString(reader1.Item("Ativo"))
                If Ativo = True Then

                    Editar_Combo_ID.Items.Add(ID_Funcionario)
                End If


            End While
            reader1.Close()
            Exit Try



        Catch ex As Exception
            Exit Try
        End Try

    End Function

    Private Sub Adicionar_Button_Click(sender As Object, e As EventArgs) Handles Adicionar_Button.Click
        If Adicionar_Combo.SelectedIndex > -1 AndAlso
            Adicionar_Nome.Text <> "" Then
            Dim Nome As String
            Nome = Adicionar_Nome.Text.ToString

            If Adicionar_Combo.SelectedIndex = 0 Then
                Dim ID_Novo_Cozinheiro As Integer
                Try
                    CN.Open()
                Catch ex As Exception
                End Try


                Dim sqlcmd1 As New SqlCommand("EXEC VerQuantidadeCozinheiros;", CN)
                Try
                    Dim reader1 As SqlDataReader
                    reader1 = sqlcmd1.ExecuteReader()
                    While reader1.Read()


                        ID_Novo_Cozinheiro = Convert.ToString(reader1.Item("total_cozinheiros") + 1)

                    End While
                    reader1.Close()
                    Exit Try



                Catch ex As Exception
                    Exit Try
                End Try




                Dim command1 As New SqlCommand("EXEC AdicionarCozinheiro @ID_Cozinheiro=" + ID_Novo_Cozinheiro.ToString + ", @Nome='" + Adicionar_Nome.Text.ToString + "';", CN)


                If command1.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Cozinheiro Adicionado")

                Else
                    MessageBox.Show("Data1 Not Updated")
                End If




            End If
            If Adicionar_Combo.SelectedIndex = 1 Then
                MsgBox("index 1: " + Adicionar_Combo.SelectedItem.ToString)
                Dim ID_Novo_Cozinheiro As Integer
                Try
                    CN.Open()
                Catch ex As Exception
                End Try


                Dim sqlcmd1 As New SqlCommand("EXEC VerQuantidadeFuncionarios;", CN)
                Try
                    Dim reader1 As SqlDataReader
                    reader1 = sqlcmd1.ExecuteReader()
                    While reader1.Read()


                        ID_Novo_Cozinheiro = Convert.ToString(reader1.Item("total_funcionarios") + 1)

                    End While
                    reader1.Close()
                    Exit Try



                Catch ex As Exception
                    Exit Try
                End Try




                Dim command1 As New SqlCommand("EXEC AdicionarFuncionario @ID_Funcionario=" + ID_Novo_Cozinheiro.ToString + ", @Nome='" + Adicionar_Nome.Text.ToString + "';", CN)


                If command1.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Funcionario Adicionado")

                Else
                    MessageBox.Show("Data1 Not Updated")
                End If



            End If


            'Avaliar'


            LoadTabelas()
        Else
            MsgBox("Dados nao preenchidos")

        End If

    End Sub

    Private Sub Editar_Combo_Nome_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Editar_Combo_Nome.SelectedIndexChanged
        If Editar_Combo_Nome.SelectedIndex = 0 Then
            LoadEditar_CozinheiroID()
        ElseIf Editar_Combo_Nome.SelectedIndex = 1 Then
            LoadEditar_FuncionarioID()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Editar_Combo_Nome.SelectedIndex > -1 AndAlso
                Editar_Combo_ID.SelectedIndex > -1 AndAlso
                     Editar_Nome.Text <> "" Then
            If Editar_Combo_Nome.SelectedIndex = 0 Then
                'Editar Cozinheiro'
                Dim ID_Novo_Cozinheiro As Integer
                Try
                    CN.Open()
                Catch ex As Exception
                End Try


                Dim sqlcmd1 As New SqlCommand("EXEC EditarCozinheiro @ID_Cozinheiro=" + Editar_Combo_ID.SelectedItem.ToString + ", @Nome='" + Editar_Nome.Text.ToString + "';", CN)



                If sqlcmd1.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Cozinheiro Editado")
                    LoadTabelas()

                Else
                    MessageBox.Show("Data1 Not Updated")
                End If


            End If
            If Editar_Combo_Nome.SelectedIndex = 1 Then

                Dim ID_Novo_Cozinheiro As Integer
                Try
                    CN.Open()
                Catch ex As Exception
                End Try


                Dim sqlcmd1 As New SqlCommand("EXEC EditarFuncionario @ID_Funcionario=" + Editar_Combo_ID.SelectedItem.ToString + ", @Nome='" + Editar_Nome.Text.ToString + "';", CN)



                If sqlcmd1.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Funcionario Editado")
                    LoadTabelas()

                Else
                    MessageBox.Show("Data1 Not Updated")
                End If



            End If
        End If
    End Sub

    Private Function LoadDespedir_FuncionarioID() 'LOAD DO COMBO BOX COM ID DE EDITAR, caso seja funcionario ou cozinheiro
        Despedir_Combo_ID.Items.Clear()

        Try
            CN.Open()
        Catch ex As Exception
        End Try
        Dim ID_Funcionario As String

        Dim sqlcmd1 As New SqlCommand("EXEC Get_Funcionarios_Ativos ;", CN)
        Try
            Dim reader1 As SqlDataReader
            reader1 = sqlcmd1.ExecuteReader()
            While reader1.Read()


                ID_Funcionario = Convert.ToString(reader1.Item("ID_Funcionario"))
                Despedir_Combo_ID.Items.Add(ID_Funcionario)

            End While
            reader1.Close()
            Exit Try



        Catch ex As Exception
            Exit Try
        End Try

    End Function

    Private Function LoadDespedir_CozinheiroID()
        Despedir_Combo_ID.Items.Clear()

        Try
            CN.Open()
        Catch ex As Exception
        End Try
        Dim ID_Funcionario As String

        Dim sqlcmd1 As New SqlCommand("EXEC Get_Cozinehiros_Ativos ;", CN)
        Try
            Dim reader1 As SqlDataReader
            reader1 = sqlcmd1.ExecuteReader()
            While reader1.Read()


                ID_Funcionario = Convert.ToString(reader1.Item("ID_Cozinheiro"))
                Despedir_Combo_ID.Items.Add(ID_Funcionario)

            End While
            reader1.Close()
            Exit Try



        Catch ex As Exception
            Exit Try
        End Try

    End Function

    Private Sub Despedir_Combo_Nome_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Despedir_Combo_Nome.SelectedIndexChanged
        If Despedir_Combo_Nome.SelectedIndex = 0 Then
            LoadDespedir_CozinheiroID()
        ElseIf Despedir_Combo_Nome.SelectedIndex = 1 Then
            LoadDespedir_FuncionarioID()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Despedir_Combo_Nome.SelectedIndex > -1 AndAlso
                  Despedir_Combo_ID.SelectedIndex > -1 Then
            If Despedir_Combo_Nome.SelectedIndex = 0 Then

                Try
                    CN.Open()
                Catch ex As Exception
                End Try


                Dim sqlcmd1 As New SqlCommand("EXEC DespedirCozinheiro @ID_Cozinheiro=" + Despedir_Combo_ID.SelectedItem.ToString + ";", CN)



                If sqlcmd1.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Cozinheiro Despedido")
                    LoadTabelas()

                Else
                    MessageBox.Show("Data1 Not Updated")
                End If

            ElseIf Despedir_Combo_Nome.SelectedIndex = 1 Then
                Try
                    CN.Open()
                Catch ex As Exception
                End Try


                Dim sqlcmd1 As New SqlCommand("EXEC DespedirFuncionario @ID_Funcionario=" + Despedir_Combo_ID.SelectedItem.ToString + ";", CN)



                If sqlcmd1.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Funcionario Despedido")
                    LoadTabelas()

                Else
                    MessageBox.Show("Data1 Not Updated")
                End If

            End If
        End If
    End Sub

    Private Sub HistoricoFuncionarios_Click(sender As Object, e As EventArgs) Handles HistoricoFuncionarios.Click
        Dim OBJ As New HistoricoEmpregados
        OBJ.Show()
    End Sub

    Private Sub Editar_Combo_ID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Editar_Combo_ID.SelectedIndexChanged

    End Sub
End Class