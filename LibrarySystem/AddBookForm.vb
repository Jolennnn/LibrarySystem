Imports System.Data.SqlClient

Public Class AddBookForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'add book query here
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            con.Open()
            BookTableAdapter1.AddBook(idBox.Text, titleBox.Text, isbnBox.Text, yrBox.Text, shelfBox.Text, categoryBox.Text)
            con.Close()
            MessageBox.Show("Successfully added!")
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