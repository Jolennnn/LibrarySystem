Imports System.Data.SqlClient
Public Class FinesConfirmationForm
    Private Sub Cancelbtn_Click(sender As Object, e As EventArgs) Handles Cancelbtn.Click
        Me.Close()

    End Sub

    Private Sub Paybtn_Click(sender As Object, e As EventArgs) Handles Paybtn.Click
        Dim query As String = "UPDATE [dbo].[BookBorrow] SET [date_returned] = @datetime, [Remarks] = @remark WHERE Book_BookId=@bookID"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@datetime", DateTime.Now)
                cmd.Parameters.AddWithValue("@remark", ReturnForm.TextBox1.Text)
                cmd.Parameters.AddWithValue("@bookID", Integer.Parse(ReturnForm.bookidlbl.Text))
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Sucessfully logged.")
                Me.Close()
            End Using
        End Using

        Module1.LoadBorrow(BooksBorrowedForm.DataGridView1)
        Me.Close()
        ReturnForm.Close()

    End Sub

    Private Sub Recordbtn_Click(sender As Object, e As EventArgs) Handles Recordbtn.Click
        'record fines

        Dim query As String = "UPDATE [dbo].[BookBorrow] SET [date_returned] = @datetime, [Remarks] = @remark WHERE Book_BookId=@bookID"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@datetime", DateTime.Now)
                cmd.Parameters.AddWithValue("@remark", ReturnForm.TextBox1.Text)
                cmd.Parameters.AddWithValue("@bookID", Integer.Parse(ReturnForm.bookidlbl.Text))
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using

        Dim query2 As String = "UPDATE [dbo].[Student] SET [Fines] = @fines WHERE idStudent = @studentID"
        Using con2 As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd2 As SqlCommand = New SqlCommand(query2, con2)
                cmd2.Parameters.AddWithValue("@fines", Integer.Parse(ReturnForm.fineslbl.Text))
                cmd2.Parameters.AddWithValue("@studentID", Integer.Parse(ReturnForm.idlbl.Text))
                con2.Open()
                cmd2.ExecuteNonQuery()
                con2.Close()
                MessageBox.Show("Sucessfully logged.")
            End Using
        End Using

        Module1.LoadBorrow(BooksBorrowedForm.DataGridView1)
        Me.Close()
        ReturnForm.Close()
    End Sub
End Class