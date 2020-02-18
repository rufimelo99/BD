Imports System.Data.SqlClient

Public Class AlterarMenuvb
    Dim CN As New SqlConnection("Data Source = " + "tcp:mednat.ieeta.pt\SQLSERVER,8101" + " ;" + "Initial Catalog = " + "p6g8" + "; uid = " + "p6g8" + ";" + "password = " + "1358054973@Bdd")
    Dim CMD As SqlCommand
    Private Sub AlterarMenuvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nomeHamburguer As String = ""
        Try
            CN.Open()
        Catch ex As Exception
        End Try
        ComboBox1.Text = "Select Item..."
        ComboBox2.Text = "Select Item..."

        Dim sqlcmd As New SqlCommand("EXEC VerNomeHamburguers;", CN)
        Try
            Dim reader As SqlDataReader
            reader = sqlcmd.ExecuteReader()
            While reader.Read()


                nomeHamburguer += Convert.ToString(reader.Item("Nome_Hamburguer1"))
                ComboBox1.Items.Add(nomeHamburguer)
                ComboBox2.Items.Add(nomeHamburguer)
                nomeHamburguer = ""
            End While
            reader.Close()
            Exit Try



        Catch ex As Exception
            MsgBox(“Sorry Incorrect Username”, MsgBoxStyle.OkOnly, “Invalid”)
            nomeHamburguer = ""
            Exit Try
        End Try

    End Sub

    Private Sub Editar_Button_Click(sender As Object, e As EventArgs) Handles Editar_Button.Click
        If ComboBox1.SelectedIndex > -1 AndAlso
            Editar_Nome.Text <> "" AndAlso
            Editar_Preco.Text <> "" AndAlso
            Editar_Descricao.Text <> "" Then





            Dim sqlcmd As New SqlCommand("EXEC Editar_Hamburguer @Nome_Hamburguer1='" + ComboBox1.SelectedItem.ToString + "',@NovoNome_Hamburguer1='" + Editar_Nome.Text + "', @Preco_Hamburguer=" + Editar_Preco.Text + ", @Descricao='" + Editar_Descricao.Text.ToString + "';", CN)




            If sqlcmd.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Item Updated")
                Dim OBJ As New AdminMenu
                OBJ.Show()
                Dim OBJ2 As New Menu
                OBJ2.Show()
                Me.Hide()
            Else
                MessageBox.Show("Item Not Updated")
            End If

        Else
            MsgBox("Parametros nao preenchidos")

        End If
    End Sub



    Private Sub Editar_Preco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Editar_Preco.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If Me.Editar_Preco.Text.Contains(".") Then
                    If Me.Editar_Preco.Text.Split(".")(1).Length < 2 Then
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


    Private Sub Adicionar_Preco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Adicionar_Preco.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If Me.Adicionar_Preco.Text.Contains(".") Then
                    If Me.Adicionar_Preco.Text.Split(".")(1).Length < 2 Then
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

    Private Sub Adicionar_Button_Click(sender As Object, e As EventArgs) Handles Adicionar_Button.Click
        If Adicionar_Nome.Text <> "" AndAlso
                  Adicionar_Preco.Text <> "" AndAlso
                  Adicionar_Descricao.Text <> "" Then





            Dim sqlcmd2 As New SqlCommand("EXEC Adicionar_Hamburguer @Nome_Hamburguer1='" + Adicionar_Nome.Text + "', @Preco_Hamburguer=" + Adicionar_Preco.Text + ", @Descricao='" + Adicionar_Descricao.Text + "';", CN)




            If sqlcmd2.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Item Updated")
                Dim OBJ As New AdminMenu
                OBJ.Show()
                Dim OBJ2 As New Menu
                OBJ2.Show()
                Me.Hide()
            Else
                MessageBox.Show("Item Not Updated")
            End If

        Else
            MsgBox("Parametros nao preenchidos")

        End If
    End Sub

    Private Sub Apagar_Button_Click(sender As Object, e As EventArgs) Handles Apagar_Button.Click
        If ComboBox2.SelectedIndex > -1 Then





            Dim sqlcmd As New SqlCommand("EXEC Eliminar_Hamburguer @Nome_Hamburguer1='" + ComboBox2.SelectedItem.ToString + "';", CN)




            If sqlcmd.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Item Updated")
                Dim OBJ As New AdminMenu
                OBJ.Show()
                Dim OBJ2 As New Menu
                OBJ2.Show()
                Me.Hide()
            Else
                MessageBox.Show("Item Not Updated")
            End If

        Else
            MsgBox("Parametros nao preenchidos")

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim OBJ2 As New AdminMenu
        OBJ2.Show()
        Me.Hide()
    End Sub
End Class