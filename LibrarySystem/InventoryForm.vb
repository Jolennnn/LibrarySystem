Public Class InventoryForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles AddBookBtn.Click
        AddBookForm.Show()
        Me.Hide()
    End Sub

    Private Sub InventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Me.Hide()
        MainForm.Show()
    End Sub
End Class