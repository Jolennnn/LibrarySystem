Imports System.Data.SqlClient
Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FLMSLabel.Parent = PictureBox1
        LMSLabel.Parent = PictureBox1
        PictureBox2.Parent = PictureBox1
        Label1.Parent = PictureBox1
        Label2.Parent = PictureBox1
        FLMSLabel.BackColor = Color.Transparent
        LMSLabel.BackColor = Color.Transparent
        PictureBox2.BackColor = Color.Transparent
        Label1.BackColor = Color.Transparent
        Label2.BackColor = Color.Transparent
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'need to wrap input to prevent sql injection, thanks

        'query login table
        Dim query2 As String = "SELECT * FROM [dbo].[LoginTable] WHERE Username=@id AND Password=@pass"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query2, con)
                cmd.Parameters.AddWithValue("@id", UsernameBox.Text) 'PLEASE CHANGE AFTER
                cmd.Parameters.AddWithValue("@pass", PasswordBox.Text) 'PLEASE CHANGE AFTER
                con.Open()
                Dim ds As SqlDataReader = cmd.ExecuteReader()
                If ds.Read() Then
                    Me.Hide()
                    MainForm.Show()
                Else
                    MessageBox.Show("Heh.. Nice Try, kid.")
                End If
                con.Close()
            End Using
        End Using
    End Sub
End Class