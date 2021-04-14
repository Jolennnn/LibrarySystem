Public Class BooksBorrowedForm
    Public datacell
    Private Sub btnBorrowBook_Click(sender As Object, e As EventArgs) Handles btnBorrowBook.Click
        BorrowingForm.ShowDialog()
    End Sub

    Private Sub btnDone_Click_1(sender As Object, e As EventArgs) Handles btnDone.Click
        MainForm.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AddBorrowerForm.ShowDialog()
    End Sub

    Private Sub BooksBorrowedForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBorrow(DataGridView1)
        FLMSLabel.Parent = PictureBox1
        LMSLabel.Parent = PictureBox1
        GroupBox1.Parent = PictureBox1
        PictureBox2.Parent = PictureBox1
        lblTitle.Parent = PictureBox1
        Label3.Parent = PictureBox1
        FLMSLabel.BackColor = Color.Transparent
        LMSLabel.BackColor = Color.Transparent
        PictureBox2.BackColor = Color.Transparent
        GroupBox1.BackColor = Color.Transparent
        lblTitle.BackColor = Color.Transparent
        Label3.BackColor = Color.Transparent

        Button6.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button6.Enabled = True

        LoadBorrowers(DataGridView1)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button6.Enabled = False
        LoadBorrow(DataGridView1)
    End Sub

    Private Sub btnReturnBook_Click(sender As Object, e As EventArgs) Handles btnReturnBook.Click
        ReturnForm.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim i = DataGridView1.CurrentRow.Index
        datacell = DataGridView1.Item(0, i).Value
        EditBorrowerForm.ShowDialog()
    End Sub
End Class