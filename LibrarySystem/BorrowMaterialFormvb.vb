Public Class BorrowMaterialFormvb
    Private Sub BorrowMaterialFormvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUnreturned(DataGridView1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        LoadMaterialHistory(DataGridView1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LoadUnreturned(DataGridView1)
    End Sub
End Class