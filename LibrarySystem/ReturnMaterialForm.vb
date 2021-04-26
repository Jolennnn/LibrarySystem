Imports ZXing
Imports System.Data.SqlClient
Public Class ReturnMaterialForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReturnMaterialScanner.ShowDialog()
        idlbl.Visible = True
        namelbl.Visible = True
        midlbl.Visible = True
        mtitlelbl.Visible = True
        Button2.Enabled = True
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
        idlbl.Visible = False
        namelbl.Visible = False
        midlbl.Visible = False
        mtitlelbl.Visible = False
    End Sub


End Class