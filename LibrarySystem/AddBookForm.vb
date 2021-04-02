Public Class AddBookForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'add book query here
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'add photo functionality
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Me.Close()
        InventoryForm.Show()
    End Sub
End Class