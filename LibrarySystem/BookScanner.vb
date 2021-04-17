Imports ZXing
Imports System.Data.SqlClient
Public Class BookScanner
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
    End Sub

    Private Sub scanBook()
        Try
            'check if book exists
            Dim query As String = "SELECT * from [dbo].[Book] WHERE BookId=@id"
            Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", Integer.Parse(TextBox1.Text))
                    con.Open()

                    Dim ds As SqlDataReader = cmd.ExecuteReader()
                    If ds.Read() Then
                        'filling info
                        BorrowingForm.bookID.Text = ds.GetInt32(0)
                        BorrowingForm.title.Text = ds.GetString(1)
                        BorrowingForm.author.Text = ds.GetString(2)
                        BorrowingForm.isbn.Text = ds.GetString(3)
                        BorrowingForm.yrpub.Text = ds.GetString(4)
                        BorrowingForm.shelf.Text = ds.GetInt32(5)

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
                    Else
                        MessageBox.Show("Incorrect Book QR.")
                    End If

                    con.Close()

                End Using
            End Using

            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show("Incorrect Book QR.")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        scanBook()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            scanBook()
        End If
    End Sub

    Private Sub BookScanner_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BookScanner_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
End Class