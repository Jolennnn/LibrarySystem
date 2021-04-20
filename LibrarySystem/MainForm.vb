Public Class MainForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BooksBorrowedButton.Click
        BooksBorrowedForm.Show()
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        InventoryForm.Show()
    End Sub

    Private Sub SomeFormName_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        LoginForm.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        LoginForm.clearText()
        LoginForm.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FLMSLabel.Parent = PictureBox1
        LMSLabel.Parent = PictureBox1
        PictureBox2.Parent = PictureBox1
        FLMSLabel.BackColor = Color.Transparent
        LMSLabel.BackColor = Color.Transparent
        PictureBox2.BackColor = Color.Transparent
        GroupBox1.Parent = PictureBox1
        GroupBox1.BackColor = Color.Transparent
    End Sub

    Private Sub ReservationsButton_Click(sender As Object, e As EventArgs) Handles ReportsButton.Click
        ReportsForm.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        StudentLogForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddBookForm.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        AddBorrowerForm.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BorrowingForm.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ReturnForm.ShowDialog()
    End Sub

    Private Sub matsborrowbtn_Click(sender As Object, e As EventArgs) Handles matsborrowbtn.Click
        BorrowMaterialMenu.ShowDialog()
    End Sub
End Class

