Imports System.Data.SqlClient

Public Class InventoryForm
    Private Sub addMaterialBtn_Click(sender As Object, e As EventArgs) Handles addMaterialBtn.Click
        AddMaterial.Show()
        Me.Hide()
    End Sub

    Private Sub InventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        LoadBookInv(DataGridView1)
        invCategoryBox.SelectedIndex = 0
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub SearchBar_TextChanged(sender As Object, e As EventArgs) Handles SearchBar.TextChanged
        If invCategoryBox.SelectedIndex = 0 Then
            If SearchBar.Text <> "" Then
                Dim query As String = "SELECT Book.BookId, Book.Title, Book.Author, Book.ISBN, Book.YrPublish, Book.shelfNo, Category.categoryName FROM Book INNER JOIN Category ON Book.idCategory = Category.idCategory WHERE Book.Title LIKE '%" + SearchBar.Text + "%' OR Book.Author LIKE '%" + SearchBar.Text + "%' OR Book.ISBN LIKE '%" + SearchBar.Text + "%' OR Category.categoryName LIKE '%" + SearchBar.Text + "%' OR Book.YrPublish LIKE '%" + SearchBar.Text + "%'"
                Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
                    Using cmd As SqlCommand = New SqlCommand(query, con)
                        Using sda As New SqlDataAdapter()
                            cmd.Connection = con
                            sda.SelectCommand = cmd
                            Using dt As New DataTable()
                                sda.Fill(dt)
                                DataGridView1.DataSource = dt
                            End Using
                        End Using
                    End Using
                End Using
            Else
                LoadBookInv(DataGridView1)
            End If
        ElseIf invCategoryBox.SelectedIndex = 1 Then
            If SearchBar.Text <> "" Then
                Dim query As String = "SELECT * FROM LibraryMaterial WHERE AccessionNum LIKE '%" + SearchBar.Text + "%' OR Title LIKE '%" + SearchBar.Text + "%'"
                Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
                    Using cmd As SqlCommand = New SqlCommand(query, con)
                        Using sda As New SqlDataAdapter()
                            cmd.Connection = con
                            sda.SelectCommand = cmd
                            Using dt As New DataTable()
                                sda.Fill(dt)
                                DataGridView1.DataSource = dt
                            End Using
                        End Using
                    End Using
                End Using
            Else
                LoadMaterialInv(DataGridView1)
            End If
        End If

    End Sub

    Private Sub invCategoryBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles invCategoryBox.SelectedIndexChanged
        If invCategoryBox.SelectedIndex = 0 Then
            LoadBookInv(DataGridView1)
        ElseIf invCategoryBox.SelectedIndex = 1 Then
            LoadMaterialInv(DataGridView1)
        End If
    End Sub

    Private Sub AddBookBtn_Click(sender As Object, e As EventArgs) Handles AddBookBtn.Click
        AddBookForm.Show()
        Me.Hide()
    End Sub
End Class