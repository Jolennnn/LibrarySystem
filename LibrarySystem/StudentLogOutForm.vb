Imports System.Data.SqlClient
Public Class StudentLogOutForm
    Dim studID As Integer
    Dim logindate As DateTime
    Private Sub StudentLogOutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        studID = StudentLogForm.datacell
        logindate = StudentLogForm.datacell2
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim query2 As String = "UPDATE [dbo].[StudentLog] SET [logout]=@dt, [remarks]=@r WHERE id=@id AND login=@logint"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query2, con)
                cmd.Parameters.AddWithValue("@dt", DateTime.Now)
                cmd.Parameters.AddWithValue("@r", TextBox1.Text)
                cmd.Parameters.AddWithValue("@id", studID)
                cmd.Parameters.AddWithValue("@logint", logindate)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Module1.LoadBorrowers(BooksBorrowedForm.DataGridView1)
            End Using
        End Using
        Module1.LoadcurrentSL(StudentLogForm.DataGridView1)
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


End Class