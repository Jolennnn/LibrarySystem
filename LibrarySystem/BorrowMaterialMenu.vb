Public Class BorrowMaterialMenu
    Private Sub BorrowMaterialFormvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        LoadMaterialUnreturned(DataGridView1)
        changeMaterialHeaders()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        LoadMaterialHistory(DataGridView1)
        changeMaterialHeaders()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LoadMaterialUnreturned(DataGridView1)
        changeMaterialHeaders()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MaterialBorrowingForm.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReturnMaterialForm.ShowDialog()
    End Sub

    Private Sub changeMaterialHeaders()
        DataGridView1.Columns(0).HeaderText = "Accession ID"
        DataGridView1.Columns(1).HeaderText = "Title"
        DataGridView1.Columns(2).HeaderText = "Student ID"
        DataGridView1.Columns(3).HeaderText = "Student Name"
        DataGridView1.Columns(4).HeaderText = "Date Borrowed"
        DataGridView1.Columns(5).HeaderText = "Date Returned"
        DataGridView1.Columns(6).HeaderText = "Remarks"
    End Sub
End Class