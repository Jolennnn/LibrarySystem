Imports ZXing
Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class ReturnScanner
    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
        scanBorrower()
    End Sub

    Private Sub ReturnScanner_Closing(sender As Object, e As CancelEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub ReturnScanner_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            scanBorrower()
        End If
    End Sub

    Private Sub scanBorrower()
        Try
            Dim inputArr = TextBox1.Text.Split("_")
            Dim studID = Integer.Parse(inputArr(1))
            Dim borrowdate

            'query if borrower exists
            Dim query As String = "SELECT * from Student WHERE idStudent = @id and Name = @name"
            Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", studID)
                    cmd.Parameters.AddWithValue("@name", inputArr(0))
                    con.Open()

                    Dim ds As SqlDataReader = cmd.ExecuteReader()
                    If ds.Read() Then
                        'query Borrower ID in BookBorrowed table
                        Dim query2 As String = "SELECT Book_BookId, Student_idStudent, date_borrowed , Book.Title, Student.Name FROM BookBorrow INNER JOIN Book ON BookBorrow.Book_BookId = Book.BookId INNER JOIN Student ON BookBorrow.Student_idStudent = Student.idStudent  WHERE Student_idStudent=@id AND date_returned IS NULL"
                        Using con2 As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
                            Using cmd2 As SqlCommand = New SqlCommand(query2, con2)
                                cmd2.Parameters.AddWithValue("@id", (studID))
                                con2.Open()

                                Dim ds2 As SqlDataReader = cmd2.ExecuteReader()
                                If ds2.Read() Then
                                    ReturnForm.bookidlbl.Text = ds2.GetInt32(0)
                                    ReturnForm.idlbl.Text = ds2.GetInt32(1)
                                    borrowdate = ds2.GetDateTime(2)
                                    ReturnForm.booklbl.Text = ds2.GetString(3)
                                    ReturnForm.namelbl.Text = ds2.GetString(4)
                                    'display in ReturnForm
                                    Dim writer As New BarcodeWriter
                                    writer.Format = BarcodeFormat.QR_CODE
                                    Dim options As New ZXing.Common.EncodingOptions

                                    'setting QR dimensions
                                    options.Width = 200
                                    options.Height = 200

                                    'write QR
                                    ReturnForm.PictureBox1.Image = writer.Write(TextBox1.Text)

                                    'count fines
                                    Dim daydiff = DateDiff("d", borrowdate, DateTime.Now)
                                    If daydiff > 7 Then
                                        ReturnForm.fineslbl.Text = (daydiff - 7) * 5
                                    End If
                                    Me.Dispose()
                                Else
                                    MessageBox.Show("No such record exists.")
                                End If

                                con2.Close()

                            End Using
                        End Using
                    Else
                        MessageBox.Show("Borrower does not exist.")
                    End If

                    con.Close()

                End Using
            End Using


        Catch ex As Exception
            MessageBox.Show("Incorrect Borrower QR.")
        End Try
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        TextBox1.Clear()
    End Sub

End Class