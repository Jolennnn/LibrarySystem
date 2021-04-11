Public Class LogsForm
    Private Sub LogsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MainForm.Show()
    End Sub
End Class