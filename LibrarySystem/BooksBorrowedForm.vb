Imports System.Data.SqlClient

Public Class BooksBorrowedForm
    Public datacell
    Private Sub btnBorrowBook_Click(sender As Object, e As EventArgs) Handles btnBorrowBook.Click
        BorrowingForm.ShowDialog()
    End Sub

    Private Sub btnDone_Click_1(sender As Object, e As EventArgs) Handles btnDone.Click
        MainForm.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AddBorrowerForm.ShowDialog()
    End Sub

    Private Sub BooksBorrowedForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBorrow(DataGridView1)
        changeBorrowHeaders()
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        FLMSLabel.Parent = PictureBox1
        LMSLabel.Parent = PictureBox1
        GroupBox1.Parent = PictureBox1
        PictureBox2.Parent = PictureBox1
        lblTitle.Parent = PictureBox1
        FLMSLabel.BackColor = Color.Transparent
        LMSLabel.BackColor = Color.Transparent
        PictureBox2.BackColor = Color.Transparent
        GroupBox1.BackColor = Color.Transparent
        lblTitle.BackColor = Color.Transparent

        Button6.Enabled = False
        btndeletestudent.Enabled = False
        bhistorybtn.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button6.Enabled = True
        bhistorybtn.Enabled = True
        btndeletestudent.Enabled = True

        LoadBorrowers(DataGridView1)
        changeStudentHeaders()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles borrowlogbtn.Click
        Button6.Enabled = False
        btndeletestudent.Enabled = False
        bhistorybtn.Enabled = False
        LoadBorrow(DataGridView1)
        changeBorrowHeaders()
    End Sub

    Private Sub btnReturnBook_Click(sender As Object, e As EventArgs) Handles btnReturnBook.Click
        ReturnForm.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim i = DataGridView1.CurrentRow.Index
        datacell = DataGridView1.Item(0, i).Value
        EditBorrowerForm.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button6.Enabled = False
        LoadOverdue(DataGridView1)
        changeBorrowHeaders()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles bhistorybtn.Click
        Dim i = DataGridView1.CurrentRow.Index
        datacell = DataGridView1.Item(0, i).Value
        BorrowHistoryForm.ShowDialog()
    End Sub

    Private Sub btndeletestudent_Click(sender As Object, e As EventArgs) Handles btndeletestudent.Click
        Dim i = DataGridView1.CurrentRow.Index
        datacell = DataGridView1.Item(0, i).Value
        Dim result As DialogResult = MessageBox.Show("Do you want to PERMANENTLY DELETE this borrower?", "Database Update Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            'query update borrower
            Dim query2 As String = "DELETE FROM [dbo].[Student] WHERE idStudent=@id"
            Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query2, con)
                    cmd.Parameters.AddWithValue("@id", Integer.Parse(datacell))
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show("Deleted borrower.")
                    Module1.LoadBorrowers(DataGridView1)
                End Using
            End Using
        End If
    End Sub

    Private Sub BooksBorrowedForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        MainForm.Show()
    End Sub

    Private Sub searchFunction()
        If btndeletestudent.Enabled = True Then
            'Search Student table
            Dim query As String = "SELECT * FROM Student WHERE idStudent=@id OR Name LIKE '%" + searchBar.Text + "%'"
            Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    Dim idnum As Integer
                    Integer.TryParse(searchBar.Text, idnum)
                    cmd.Parameters.AddWithValue("@id", idnum)
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
            'Search BookBorrow table
            Dim query As String = "SELECT Book_BookId, Book.Title, Student_idStudent, Student.Name, date_borrowed, date_returned, Remarks FROM BookBorrow INNER JOIN Book ON BookBorrow.Book_BookId = Book.BookId INNER JOIN Student ON BookBorrow.Student_idStudent = Student.idStudent WHERE Book.Title LIKE '%" + searchBar.Text + "%' OR Student.Name LIKE '%" + searchBar.Text + "%' OR Remarks LIKE '%" + searchBar.Text + "%'"
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
        End If
    End Sub

    Private Sub unreturnedbtn_Click(sender As Object, e As EventArgs) Handles unreturnedbtn.Click
        Button6.Enabled = False
        btndeletestudent.Enabled = False
        bhistorybtn.Enabled = False
        LoadUnreturned(DataGridView1)
        changeBorrowHeaders()
    End Sub

    Private Sub searchBar_TextChanged(sender As Object, e As EventArgs) Handles searchBar.TextChanged
        searchFunction()
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

    Private Sub changeStudentHeaders()
        DataGridView1.Columns(0).HeaderText = "Student ID"
        DataGridView1.Columns(0).HeaderText = "Fines"
        DataGridView1.Columns(0).HeaderText = "Student Name"
    End Sub
End Class