Imports ZXing
Public Class BorrowerReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim inputarr As String() = scan1.Text.Split("_")
        BorrowingForm.borrowerName.Text = inputarr(0)
        BorrowingForm.borrowerID.Text = inputarr(1)

        'display in BorrowerReader
        Dim writer As New BarcodeWriter
        writer.Format = BarcodeFormat.QR_CODE
        Dim options As New ZXing.Common.EncodingOptions

        'setting QR dimensions
        options.Width = 200
        options.Height = 200

        'write QR
        BorrowingForm.BorrowerQRimg.Image = writer.Write(scan1.Text)

        Me.Close()
    End Sub
End Class