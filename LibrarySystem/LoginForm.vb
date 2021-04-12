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
        'If UsernameBox.Text = "library" And PasswordBox.Text = "admin" Then
        Me.Hide()
        MainForm.Show()
        MsgBox("Username and password to be edited")
        'Else
        'MsgBox("Username and password does not match.")
        'End If
    End Sub
End Class