Imports ZXing
Imports System.Data.SqlClient

Public Class ReturnForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReturnScanner.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'if fines
        If Integer.Parse(fineslbl.Text) > 0 Then
            FinesConfirmationForm.ShowDialog()
        Else
            Dim query As String = "UPDATE [dbo].[BookBorrow] SET [date_returned] = @datetime, [Remarks] = @remark WHERE Book_BookId=@bookID"
            Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@datetime", DateTime.Now)
                    cmd.Parameters.AddWithValue("@remark", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@bookID", Integer.Parse(bookidlbl.Text))
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show("Sucessfully logged.")
                    Me.Close()
                End Using
            End Using

        End If

        Module1.LoadBorrow(BooksBorrowedForm.DataGridView1)
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class