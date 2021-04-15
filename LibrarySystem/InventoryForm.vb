Public Class InventoryForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles AddBookBtn.Click, Button1.Click
        AddBookForm.Show()
        Me.Hide()
    End Sub

    Private Sub InventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        LoadBookInv(DataGridView1)
        searchbyBox.SelectedIndex = 0
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub SearchBar_TextChanged(sender As Object, e As EventArgs) Handles SearchBar.TextChanged
        LoadBookInv(DataGridView1)
        Dim searchBy As String
        Dim dt As DataTable = DataGridView1.DataSource
        If SearchBar.Text <> "" Then
            If searchbyBox.Text = "Title" Then
                searchBy = "Title"
            End If
            Dim filter As String = String.Format("{0} Like '{1}*'", searchBy, SearchBar.Text)
            Dim filteredRows As DataRow() = dt.Select(filter)
            If filteredRows.Length() <> 0 Then
                DataGridView1.DataSource = filteredRows.CopyToDataTable()
            Else
                dt.Clear()
                DataGridView1.DataSource = dt
            End If
        Else
            LoadBookInv(DataGridView1)
        End If

    End Sub
End Class