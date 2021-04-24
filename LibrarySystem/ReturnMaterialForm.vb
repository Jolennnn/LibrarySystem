Imports ZXing
Imports System.Data.SqlClient
Public Class ReturnMaterialForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReturnMaterialScanner.ShowDialog()
        idlbl.Visible = True
        namelbl.Visible = True
        midlbl.Visible = True
        mtitlelbl.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim query As String = "UPDATE [dbo].[MaterialBorrow] SET [date_returned] = @datetime, [Remarks] = @remark WHERE LibraryMaterial_AccessionNUm=@id AND date_returned IS NULL"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@datetime", DateTime.Now)
                cmd.Parameters.AddWithValue("@remark", TextBox1.Text)
                cmd.Parameters.AddWithValue("@id", Integer.Parse(midlbl.Text))
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Sucessfully logged.")
                Me.Dispose()
            End Using
        End Using

        Module1.LoadMaterialUnreturned(BorrowMaterialMenu.DataGridView1)
        Me.Dispose()

    End Sub

    Private Sub ReturnMaterialForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox2
        Label1.BackColor = Color.Transparent
        Label3.Parent = PictureBox2
        Label3.BackColor = Color.Transparent
        Label6.Parent = PictureBox2
        Label6.BackColor = Color.Transparent
        Label2.Parent = PictureBox2
        Label2.BackColor = Color.Transparent
        Label5.Parent = PictureBox2
        Label5.BackColor = Color.Transparent
        idlbl.Parent = PictureBox2
        idlbl.BackColor = Color.Transparent
        namelbl.Parent = PictureBox2
        namelbl.BackColor = Color.Transparent
        midlbl.Parent = PictureBox2
        midlbl.BackColor = Color.Transparent
        mtitlelbl.Parent = PictureBox2
        mtitlelbl.BackColor = Color.Transparent

        idlbl.Visible = False
        namelbl.Visible = False
        midlbl.Visible = False
        mtitlelbl.Visible = False
    End Sub
End Class