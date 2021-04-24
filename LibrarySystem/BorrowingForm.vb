Imports System.Data.SqlClient
Public Class BorrowingForm

    Private Sub BorrowingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.LoadBorrow(BooksBorrowedForm.DataGridView1)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub BtnScanBook_Click(sender As Object, e As EventArgs) Handles BtnScanBook.Click
        BookScanner.ShowDialog()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        Try
            'query if borrower unreturned
            Dim query As String = "SELECT * from [dbo].[BookBorrow] WHERE Student_idStudent=@id AND date_returned IS NULL"
            Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", Integer.Parse(borrowerID.Text))
                    con.Open()

                    Dim ds As SqlDataReader = cmd.ExecuteReader()
                    If ds.Read() Then
                        MessageBox.Show("Borrower has unreturned book.")
                    Else
                        'query if book is borrowed
                        Dim query2 As String = "SELECT Student_idStudent, Student.Name FROM [dbo].[BookBorrow] INNER JOIN Student ON BookBorrow.Student_idStudent = Student.idStudent WHERE Book_BookId=@id AND date_returned IS NULL"
                        Using con2 As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
                            Using cmd2 As SqlCommand = New SqlCommand(query2, con2)
                                cmd2.Parameters.AddWithValue("@id", Integer.Parse(bookID.Text))
                                con2.Open()

                                Dim ds2 As SqlDataReader = cmd2.ExecuteReader()
                                If ds2.Read() Then
                                    Dim bID = ds2.GetInt32(0)
                                    Dim bName = ds2.GetString(1)
                                    MessageBox.Show("Book is currently borrowed by ID: " + bID.ToString + " Name: " + bName)
                                Else
                                    Dim bookIDnum As Integer
                                    bookIDnum = Integer.Parse(bookID.Text)

                                    Dim query3 As String = "INSERT INTO [dbo].[BookBorrow] ([Book_BookId], [Student_IdStudent], [date_borrowed]) VALUES(@bookid, @borrowerid, @datetime)"
                                    Using con3 As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
                                        Using cmd3 As SqlCommand = New SqlCommand(query3, con3)
                                            cmd3.Parameters.AddWithValue("@bookid", bookIDnum)
                                            cmd3.Parameters.AddWithValue("@borrowerid", borrowerID.Text)
                                            cmd3.Parameters.AddWithValue("@datetime", DateTime.Now)
                                            con3.Open()
                                            cmd3.ExecuteNonQuery()
                                            con3.Close()
                                            MessageBox.Show("Sucessfully logged.")
                                            Module1.LoadBorrow(BooksBorrowedForm.DataGridView1)
                                            Me.Close()
                                        End Using
                                    End Using
                                End If

                                con2.Close()

                            End Using
                        End Using
                    End If

                    con.Close()

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Invalid input.")
        End Try
    End Sub

    Private Sub btnScanBorrower_Click(sender As Object, e As EventArgs) Handles btnScanBorrower.Click
        BorrowerScanner.ShowDialog()
    End Sub

    Private Sub BorrowingForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub


End Class