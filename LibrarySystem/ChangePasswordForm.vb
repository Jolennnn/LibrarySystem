Imports System.Data.SqlClient

Public Class ChangePasswordForm
    Private Sub changeBtn_Click(sender As Object, e As EventArgs) Handles changeBtn.Click
        Dim query As String = "SELECT * FROM LoginTable WHERE id = 0"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                con.Open()
                Using reader = cmd.ExecuteReader()
                    cmd.Connection = con
                    Dim pass As String = ""
                    While reader.Read()
                        pass = reader.GetString(2)
                    End While
                    reader.Close()
                    If oldpassBox.Text = pass Then
                        If newpassBox.Text = confirmBox.Text Then
                            Dim query2 As String = "UPDATE [dbo].[LoginTable] SET [Password] = @password WHERE id = 0"
                            Using cmd2 As SqlCommand = New SqlCommand(query2, con)
                                cmd2.Parameters.AddWithValue("@password", newpassBox.Text)
                                cmd2.ExecuteNonQuery()
                            End Using
                            MsgBox("Password successfully changed.")
                            Me.Hide()
                            LoginForm.Show()
                        Else
                            MsgBox("New Password must match.")
                        End If
                    Else
                        MsgBox("Current Password does not match")
                    End If
                End Using
                con.Close()
            End Using
        End Using
    End Sub

    Private Sub ChangePasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        Label2.Parent = PictureBox1
        Label2.BackColor = Color.Transparent
        Label3.Parent = PictureBox1
        Label3.BackColor = Color.Transparent
    End Sub
End Class