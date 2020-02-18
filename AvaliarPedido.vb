Imports System.Data.SqlClient

Public Class AvaliarPedido
    Public Property Usertlm As String
    Public Property UserName As String
    Dim CN As New SqlConnection("Data Source = " + "tcp:mednat.ieeta.pt\SQLSERVER,8101" + " ;" + "Initial Catalog = " + "p6g8" + "; uid = " + "p6g8" + ";" + "password = " + "1358054973@Bdd")
    Dim CMD As SqlCommand
    Private Sub AvaliarPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DomainUpDown1.SelectedIndex = 5
        Dim pedido As Integer
        Try
            CN.Open()
        Catch ex As Exception
        End Try
        ComboBox1.Text = "Select Hamburguer..."


        Dim sqlcmd As New SqlCommand("EXEC VerNumerosPedidosUser @numero_tlm=" + Usertlm + ";", CN)
        Try
            Dim reader As SqlDataReader
            reader = sqlcmd.ExecuteReader()
            While reader.Read()


                pedido = Convert.ToInt16(reader.Item("No_Pedido"))
                ComboBox1.Items.Add(pedido)
            End While
            reader.Close()
            Exit Try



        Catch ex As Exception
            Exit Try
        End Try


    End Sub

    Private Function CriarAvaliacao()
        Try
            CN.Open()
        Catch ex As Exception
        End Try
        Dim rating_escolhido As Integer
        rating_escolhido = DomainUpDown1.SelectedItem




        Try
            Dim sqlcmd2 As New SqlCommand("EXEC AdicionarAvaliacao @Nu_Pedido=" + ComboBox1.SelectedItem.ToString + ", @Comentario='" + TextBox1.Text.ToString + "';", CN)



            If sqlcmd2.ExecuteNonQuery() = 1 Then
                'MessageBox.Show("Data Updated")

            Else
                'MessageBox.Show("Data Not Updated")
            End If
        Catch ex As Exception

        End Try

        Try

            Dim sqlcmd As New SqlCommand("EXEC UpdateAvaliacao @Nu_Pedido=" + ComboBox1.SelectedItem.ToString + ", @Comentario='" + TextBox1.Text.ToString + "';", CN)



            If sqlcmd.ExecuteNonQuery() = 1 Then
                'MessageBox.Show("Data Updated")

            Else
                'MessageBox.Show("Data Not Updated")
            End If
        Catch ex As Exception

        End Try

    End Function

    Private Function AlterarRatingHamburguer(rating_escolhido As Integer)
        Try
            CN.Open()
        Catch ex As Exception
        End Try


        Try
            Dim sqlcmd3 As New SqlCommand("EXEC UpdateRatingHamburguer @Nu_Pedido=" + ComboBox1.SelectedItem.ToString + ", @Rating=" + rating_escolhido.ToString + ";", CN)



            If sqlcmd3.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Rating alterado")

            Else
                MessageBox.Show("Rating nao alterado")
            End If
        Catch ex As Exception
        End Try

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex > -1 Then
            Dim Comentario As String
            Comentario = TextBox1.Text.ToString
            Dim rating_escolhido As Integer
            rating_escolhido = DomainUpDown1.SelectedItem



            MsgBox("Rating: " + rating_escolhido.ToString)


            'Avaliar'

            CriarAvaliacao()
            AlterarRatingHamburguer(rating_escolhido)
        Else
            MsgBox("Parametros nao preenchidos")

        End If
        Me.Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            CN.Open()
        Catch ex As Exception
        End Try

        Dim comentario As String
        comentario = ""

        Try
            Dim sqlcmd4 As New SqlCommand("EXEC GetComentarioPedido @Nu_Pedido=" + ComboBox1.SelectedItem.ToString + ";", CN)

            Dim reader As SqlDataReader
            reader = sqlcmd4.ExecuteReader()
            While reader.Read()


                comentario = reader.Item("Comentario")
                MsgBox("Comentario anterior: " + comentario)
                TextBox1.Text = comentario


            End While
            reader.Close()



            If sqlcmd4.ExecuteNonQuery() = 1 Then


                MsgBox("devia dar")

            Else
            End If
        Catch ex As Exception
        End Try
    End Sub


End Class