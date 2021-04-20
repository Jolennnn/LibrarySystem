Public Class BorrowMaterialMenu
    Private Sub BorrowMaterialFormvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMaterialUnreturned(DataGridView1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        LoadMaterialHistory(DataGridView1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LoadMaterialUnreturned(DataGridView1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MaterialBorrowingForm.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReturnMaterialForm.ShowDialog()
    End Sub
End Class