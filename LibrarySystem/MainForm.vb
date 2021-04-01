Public Class MainForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BooksBorrowedButton.Click
        BooksBorrowedForm.Show()
        Me.Hide()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        InventoryForm.Show()
        Me.Hide()
    End Sub
End Class

