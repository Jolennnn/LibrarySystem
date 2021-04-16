Imports ZXing
Imports System.Data.SqlClient
Public Class BookScanner
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'display in BorrowerReader
        Dim writer As New BarcodeWriter
        writer.Format = BarcodeFormat.QR_CODE
        Dim options As New ZXing.Common.EncodingOptions

        'setting QR dimensions
        options.Width = 200
        options.Height = 200

        'write QR
        BorrowingForm.BookQRimg.Image = writer.Write(TextBox1.Text)
        BorrowingForm.bookID.Text = TextBox1.Text

        'query database
        Dim query As String = "SELECT * from [dbo].[Book] WHERE BookId=@id"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", Integer.Parse(TextBox1.Text))
                con.Open()

                Dim ds As SqlDataReader = cmd.ExecuteReader()
                If ds.Read() Then
                    BorrowingForm.bookID.Text = ds.GetInt32(0)
                    BorrowingForm.title.Text = ds.GetString(1)
                    BorrowingForm.author.Text = ds.GetString(2)
                    BorrowingForm.isbn.Text = ds.GetString(3)
                    BorrowingForm.yrpub.Text = ds.GetString(4)
                    BorrowingForm.shelf.Text = ds.GetInt32(5)
                End If

                con.Close()

            End Using
        End Using

        Me.Close()
    End Sub
End Class