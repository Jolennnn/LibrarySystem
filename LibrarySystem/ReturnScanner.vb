Imports ZXing
Imports System.Data.SqlClient
Public Class ReturnScanner
    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click

        'display in ReturnForm
        Dim writer As New BarcodeWriter
        writer.Format = BarcodeFormat.QR_CODE
        Dim options As New ZXing.Common.EncodingOptions

        'setting QR dimensions
        options.Width = 200
        options.Height = 200

        'write QR
        ReturnForm.PictureBox1.Image = writer.Write(TextBox1.Text)

        'filling in data
        Dim borrowdate As DateTime
        Dim studID = Integer.Parse(TextBox1.Text)
        ReturnForm.idlbl.Text = TextBox1.Text


        'query Borrower ID in BookBorrowed table
        Dim query As String = "SELECT Book_BookId, Student_idStudent, date_borrowed , Book.Title, Student.Name FROM BookBorrow INNER JOIN Book ON BookBorrow.Book_BookId = Book.BookId INNER JOIN Student ON BookBorrow.Student_idStudent = Student.idStudent  WHERE Student_idStudent=@id AND date_returned IS NULL"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", (studID))
                con.Open()

                Dim ds As SqlDataReader = cmd.ExecuteReader()
                If ds.Read() Then
                    ReturnForm.bookidlbl.Text = ds.GetInt32(0)
                    ReturnForm.idlbl.Text = ds.GetInt32(1)
                    borrowdate = ds.GetDateTime(2)
                    ReturnForm.booklbl.Text = ds.GetString(3)
                    ReturnForm.namelbl.Text = ds.GetString(4)
                Else
                    MessageBox.Show("No such record exists.")
                End If

                con.Close()

            End Using
        End Using

        'count fines
        Dim daydiff = DateDiff("d", borrowdate, DateTime.Now)
        If daydiff > 7 Then
            ReturnForm.fineslbl.Text = (daydiff - 7) * 5
        End If
        Me.Close()

    End Sub
End Class