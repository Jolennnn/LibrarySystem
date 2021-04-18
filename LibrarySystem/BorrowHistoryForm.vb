Imports System.Data.SqlClient

Public Class BorrowHistoryForm
    Private Sub BorrowHistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        namelbl.Parent = PictureBox1
        namelbl.BackColor = Color.Transparent
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        fineslbl.Parent = PictureBox1
        fineslbl.BackColor = Color.Transparent
        booklbl.Parent = PictureBox1
        booklbl.BackColor = Color.Transparent
        Label2.Parent = PictureBox1
        Label2.BackColor = Color.Transparent

        'name label
        Dim query As String = "SELECT Name,Fines from [dbo].[Student] WHERE idStudent=@id"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", Integer.Parse(BooksBorrowedForm.datacell))
                con.Open()

                Dim ds As SqlDataReader = cmd.ExecuteReader()
                If ds.Read() Then
                    namelbl.Text = ds.GetString(0)
                    fineslbl.Text = ds.GetInt32(1)
                End If

                con.Close()

            End Using
        End Using

        'book count
        Dim query2 As String = "SELECT COUNT(*) FROM BookBorrow WHERE Student_idStudent=@id"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query2, con)
                cmd.Parameters.AddWithValue("@id", Integer.Parse(BooksBorrowedForm.datacell))
                con.Open()

                Dim ds As SqlDataReader = cmd.ExecuteReader()
                If ds.Read() Then
                    booklbl.Text = ds.GetInt32(0)
                End If

                con.Close()

            End Using
        End Using

        'fill table
        Module1.LoadBorrowerHistory(DataGridView1, Integer.Parse(BooksBorrowedForm.datacell))
        changeBorrowHeaders()
    End Sub

    Private Sub changeBorrowHeaders()
        DataGridView1.Columns(0).HeaderText = "Book ID"
        DataGridView1.Columns(1).HeaderText = "Title"
        DataGridView1.Columns(2).HeaderText = "Student ID"
        DataGridView1.Columns(3).HeaderText = "Student Name"
        DataGridView1.Columns(4).HeaderText = "Date Borrowed"
        DataGridView1.Columns(5).HeaderText = "Date Returned"
        DataGridView1.Columns(6).HeaderText = "Remarks"
    End Sub
End Class