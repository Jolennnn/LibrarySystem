Imports System.Data.SqlClient

Public Class StudentLogInForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim inputarr As String() = TextBox1.Text.Split("_")

        Dim query As String = "INSERT INTO [dbo].[StudentLog] ([login], [id]) VALUES(@datetime, @borrowerid)"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@borrowerid", inputarr(1))
                cmd.Parameters.AddWithValue("@datetime", DateTime.Now)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Sucessfully logged.")
                Module1.LoadcurrentSL(StudentLogForm.DataGridView1)
                Me.Close()
            End Using
        End Using
    End Sub
End Class