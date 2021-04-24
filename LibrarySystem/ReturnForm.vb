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
            Dim query As String = "UPDATE [dbo].[BookBorrow] SET [date_returned] = @datetime, [Remarks] = @remark WHERE Book_BookId=@bookID and date_returned IS NULL"
            Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@datetime", DateTime.Now)
                    cmd.Parameters.AddWithValue("@remark", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@bookID", Integer.Parse(bookidlbl.Text))
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show("Sucessfully logged.")
                    Me.Dispose()
                End Using
            End Using

        End If

        Module1.LoadBorrow(BooksBorrowedForm.DataGridView1)
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Dispose()
    End Sub

    Private Sub ReturnForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub ReturnForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox2
        Label1.BackColor = Color.Transparent
        Label3.Parent = PictureBox2
        Label3.BackColor = Color.Transparent
        Label6.Parent = PictureBox2
        Label6.BackColor = Color.Transparent
        Label2.Parent = PictureBox2
        Label2.BackColor = Color.Transparent
        Label4.Parent = PictureBox2
        Label4.BackColor = Color.Transparent
        idlbl.Parent = PictureBox2
        idlbl.BackColor = Color.Transparent
        namelbl.Parent = PictureBox2
        namelbl.BackColor = Color.Transparent
        bookidlbl.Parent = PictureBox2
        bookidlbl.BackColor = Color.Transparent
        booklbl.Parent = PictureBox2
        booklbl.BackColor = Color.Transparent
        fineslbl.Parent = PictureBox2
        fineslbl.BackColor = Color.Transparent
        Label5.Parent = PictureBox2
        Label5.BackColor = Color.Transparent
    End Sub
End Class