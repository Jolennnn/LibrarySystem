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
        LinkLabel1.Parent = PictureBox1
        LinkLabel1.BackColor = Color.Transparent
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'query login table
        Dim query As String = "SELECT * FROM LoginTable WHERE id = 0"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                con.Open()
                Using reader = cmd.ExecuteReader()
                    cmd.Connection = con
                    Dim user As String = ""
                    Dim pass As String = ""
                    While reader.Read()
                        user = reader.GetString(1)
                        pass = reader.GetString(2)
                    End While
                    If UsernameBox.Text = user And PasswordBox.Text = pass Then
                        Me.Hide()
                        MainForm.Show()
                        clearText()
                    Else
                        MsgBox("Username and Password does not match.")
                    End If
                End Using
                con.Close()
            End Using
        End Using
    End Sub

    Public Sub clearText()
        UsernameBox.Clear()
        PasswordBox.Clear()
    End Sub

    Private Sub changepassBtn_Click(sender As Object, e As EventArgs)
        Me.Hide()
        ChangePasswordForm.Show()
    End Sub

    Private Sub FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)
        Application.Exit()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        ChangePasswordForm.Show()
        clearText()
    End Sub
End Class