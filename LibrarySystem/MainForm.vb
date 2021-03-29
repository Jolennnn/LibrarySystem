Public Class MainForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BooksBorrowedForm.Show()
        Me.Hide()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        Label2.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        Label2.BackColor = Color.Transparent
        PictureBox2.Parent = PictureBox1
        PictureBox2.BackColor = Color.Transparent
    End Sub


End Class

