Public Class ChangePasswordForm
    Private Sub changeBtn_Click(sender As Object, e As EventArgs) Handles changeBtn.Click
        Dim query As String = "SELECT Password FROM LoginTable WHERE id = 0"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                con.Open()
                Using reader = cmd.ExecuteReader()
                    cmd.Connection = con
                    Dim pass As String = ""
                    While reader.Read()
                        pass = reader.GetString(2)
                    End While
                    If oldpassBox.Text = pass And newpassBox.Text = confirmBox.Text Then

                    Else
                        MsgBox("Does not match.")
                    End If
                End Using
                con.Close()
            End Using
        End Using
    End Sub
End Class