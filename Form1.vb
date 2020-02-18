Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.SqlClient

Public Class Login
    Public Telemovel_Utilizador As String
    Dim CN As New SqlConnection("Data Source = " + "tcp:mednat.ieeta.pt\SQLSERVER,8101" + " ;" + "Initial Catalog = " + "p6g8" + "; uid = " + "p6g8" + ";" + "password = " + "1358054973@Bdd")
    Dim CMD As SqlCommand


    ' Private Function CheckLoginValues(ByVal CN As SqlConnection, ByVal NomeUtilizador As String, ByVal PasswordUtilizador As String) As Boolean
    ' Return True
    '  End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CN.Open()
            If CN.State = ConnectionState.Open Then
                MsgBox("Successful connection to database " + CN.Database + " on the " +
                 CN.DataSource + " server", MsgBoxStyle.OkOnly, "Connection Test")
            End If
        Catch ex As Exception
            MsgBox("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR" +
            vbCrLf + ex.Message, MsgBoxStyle.Critical, "Connection Test")
        End Try

    End Sub


    Private Function GetUserName(ByVal CN As SqlConnection, ByVal num_tlm As String) As String
        Try
            CN.Open()
        Catch ex As Exception
        End Try
        Dim name As String = ""
        Dim sqlcmd2 As New SqlCommand("EXEC VerDadosUser @num_tlm=" + num_tlm + ";", CN)
        Dim reader2 As SqlDataReader
        reader2 = sqlcmd2.ExecuteReader
        While reader2.Read
            name = Convert.ToString(reader2.Item("Nome"))

        End While

        Return name
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Login_Login_Button.Click
        Try
            CN.Open()
        Catch ex As Exception
        End Try

        Dim nome As String = ""
        Dim tlm As String = ""
        Dim pass As String = ""
        Dim sqlcmd As New SqlCommand("EXEC VerDadosLogIn @Login_username_input=" + Login_username_input.Text.ToString + ";", CN)

        Try
            Dim reader As SqlDataReader
            reader = sqlcmd.ExecuteReader()

            While reader.Read()

                pass = Convert.ToString(reader.Item("Pass"))
                tlm = Convert.ToString(reader.Item("Persontlm"))
            End While


            If pass = Login_password_input.Text Then
                If Login_username_input.Text = "1111" Then 'administrador'
                    reader.Close()
                    MsgBox(“Log in Successfully!”, MsgBoxStyle.OkOnly, “Log in Form”)
                    Dim OBJ As New AdminMenu
                    OBJ.Show()
                    Me.Hide()



                Else    'cliente'

                    reader.Close()
                    MsgBox(“Log in Successfully!”, MsgBoxStyle.OkOnly, “Log in Form”)
                    Dim OBJ As New Form2
                    OBJ.Usertlm = tlm
                    nome = GetUserName(CN, tlm)
                    OBJ.UserName = nome
                    OBJ.Show()
                    Me.Hide()
                End If
            Else
                MsgBox(“Sorry Incorrect Password”, MsgBoxStyle.OkOnly, “Invalid”)

                Dim OBJ As New Login
                OBJ.Show()
                Me.Hide()
                Exit Try
            End If



        Catch ex As Exception
            MsgBox(“Sorry Incorrect Username”, MsgBoxStyle.OkOnly, “Invalid”)


            Dim OBJ As New Login
            OBJ.Show()
            Me.Hide()
            Exit Try

        End Try



    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OBJ As New CriarConta
        OBJ.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Label1.Parent = Me.PictureBox1


    End Sub
End Class
