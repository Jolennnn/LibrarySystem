Public Class BooksBorrowedForm
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
    End Sub
End Class