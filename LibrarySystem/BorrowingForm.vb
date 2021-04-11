Imports System.Data.SqlClient
Public Class BorrowingForm
    Private Sub BorrowingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnScanBook_Click(sender As Object, e As EventArgs) Handles BtnScanBook.Click
        BookScanner.ShowDialog()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim bookIDnum As Integer
        Int32.tryparse(bookID.Text, bookIDnum)

        Dim query As String = "INSERT INTO [dbo].[BookBorrow] ([Book_BookId], [Student_IdStudent]) VALUES(@bookid, @borrowerid)"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@bookid", bookIDnum)
                cmd.Parameters.AddWithValue("@borrowerid", borrowerID.Text)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Sucessfully logged.")
                Module1.BindData(InventoryForm.DataGridView1)
            End Using
        End Using
    End Sub

    Private Sub btnScanBorrower_Click(sender As Object, e As EventArgs) Handles btnScanBorrower.Click
        BorrowerScanner.ShowDialog()
    End Sub
End Class