Public Class BorrowingForm
    Private Sub BorrowingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnScanBook_Click(sender As Object, e As EventArgs) Handles BtnScanBook.Click

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

    End Sub

    Private Sub btnScanBorrower_Click(sender As Object, e As EventArgs) Handles btnScanBorrower.Click
        BorrowerReader.ShowDialog()
    End Sub
End Class