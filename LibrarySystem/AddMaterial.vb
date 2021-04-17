Imports System.Data.SqlClient

Public Class AddMaterial
    Private Sub AddMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        Label2.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        Label2.BackColor = Color.Transparent
    End Sub

    Private Sub mAddBtn_Click(sender As Object, e As EventArgs) Handles mAddBtn.Click
        Dim query As String = "INSERT INTO [dbo].[LibraryMaterial] ([AccessionNum], [Title]) VALUES(@AccessionNum, @Title)"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@AccessionNum", accnumBox.Text)
                cmd.Parameters.AddWithValue("@Title", mtitleBox.Text)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Successfully added!")
                LoadMaterialInv(InventoryForm.DataGridView1)
            End Using
        End Using
        If InventoryForm.invCategoryBox.SelectedIndex = 0 Then
            LoadBookInv(InventoryForm.DataGridView1)
        ElseIf InventoryForm.invCategoryBox.SelectedIndex = 1 Then
            LoadMaterialInv(InventoryForm.DataGridView1)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        InventoryForm.Show()
    End Sub
End Class