Imports System.Data.SqlClient

Public Class BorrowHistoryForm
    Private Sub BorrowHistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'name label
        Dim query As String = "SELECT Name,Fines from [dbo].[Student] WHERE idStudent=@id"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", Integer.Parse(BooksBorrowedForm.datacell))
                con.Open()

                Dim ds As SqlDataReader = cmd.ExecuteReader()
                If ds.Read() Then
                    namelbl.Text = ds.GetString(0)
                    fineslbl.text = ds.GetInt32(1)
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
    End Sub
End Class