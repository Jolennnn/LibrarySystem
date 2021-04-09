Imports System.Data.SqlClient

Public Class AddBookForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'add book query here
        Dim query As String = "INSERT INTO [dbo].[Book] ([Title], [ISBN], [YrPublish], [shelfNo], [idCategory]) VALUES(@Title, @ISBN, @YrPublish, @shelfNo, @idCategory)"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Title", titleBox.Text)
                cmd.Parameters.AddWithValue("@ISBN", isbnBox.Text)
                cmd.Parameters.AddWithValue("@YrPublish", yrBox.Text)
                cmd.Parameters.AddWithValue("@shelfNo", shelfBox.Text)
                cmd.Parameters.AddWithValue("@idCategory", categoryBox.Text)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Successfully added!")
                Module1.BindData(InventoryForm.DataGridView1)
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'add photo functionality
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Me.Close()
        InventoryForm.Show()
    End Sub
End Class