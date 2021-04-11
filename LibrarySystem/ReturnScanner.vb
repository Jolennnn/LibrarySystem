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

        Dim flag = 0 'flag if user not found, or is not currently borrowing a book
        Dim studID As Integer
        Dim bookIDholder As Integer
        Dim borrowdate As DateTime

        studID = Integer.Parse(TextBox1.Text)

        'query Borrower ID in BookBorrowed table
        Dim query As String = "SELECT * from [dbo].[BookBorrow] WHERE Student_idStudent=@id AND date_returned IS NULL"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", studID)
                con.Open()

                Dim ds As SqlDataReader = cmd.ExecuteReader()
                If ds.Read() Then
                    bookIDholder = ds.GetInt32(1) 'for book name query
                    ReturnForm.bookidlbl.Text = bookIDholder
                    ReturnForm.idlbl.Text = ds.GetInt32(2) 'update id
                    borrowdate = ds.GetDateTime(3)
                Else
                    flag = 1 'not found
                End If

                con.Close()

            End Using
        End Using

        'query for borrower name
        Dim query2 As String = "SELECT Name from [dbo].[Student] WHERE idStudent=@id"
        Using con2 As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd2 As SqlCommand = New SqlCommand(query2, con2)
                cmd2.Parameters.AddWithValue("@id", studID)
                con2.Open()

                Dim ds2 As SqlDataReader = cmd2.ExecuteReader()
                If ds2.Read() Then
                    ReturnForm.namelbl.Text = ds2(0).ToString() 'update name
                End If

                con2.Close()

            End Using
        End Using

        'query book name
        Dim query3 As String = "SELECT Title from [dbo].[Book] WHERE BookId=@id"
        Using con3 As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd3 As SqlCommand = New SqlCommand(query3, con3)
                cmd3.Parameters.AddWithValue("@id", bookIDholder)
                con3.Open()

                Dim ds3 As SqlDataReader = cmd3.ExecuteReader()
                If ds3.Read() Then
                    ReturnForm.booklbl.Text = ds3(0).ToString() 'update book
                End If

                con3.Close()

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