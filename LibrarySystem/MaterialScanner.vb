Imports System.Data.SqlClient
Imports ZXing

Class MaterialScanner
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        scanBorrower()
    End Sub
    Private Sub scanBorrower()
        Try
            'read String
            Dim inputarr As String() = scan1.Text.Split("_")
            'query if borrower exists
            Dim query As String = "SELECT * from [dbo].[LibraryMaterial] WHERE AccessionNum=@id and Title=@name"
            Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", inputarr(1))
                    cmd.Parameters.AddWithValue("@name", inputarr(0))
                    con.Open()

                    Dim ds As SqlDataReader = cmd.ExecuteReader()
                    If ds.Read() Then
                        MaterialBorrowingForm.mtitlelbl.Text = inputarr(0)
                        MaterialBorrowingForm.midlbl.Text = inputarr(1)
                        'display in BorrowerReader
                        Dim writer As New BarcodeWriter
                        writer.Format = BarcodeFormat.QR_CODE
                        Dim options As New ZXing.Common.EncodingOptions

                        'setting QR dimensions
                        options.Width = 200
                        options.Height = 200

                        'write QR
                        MaterialBorrowingForm.MaterialQR.Image = writer.Write(scan1.Text)
                        Me.Dispose()
                    Else
                        MessageBox.Show("Incorrect Material QR.")
                    End If

                    con.Close()

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Incorrect Material QR.")
        End Try
    End Sub
    Private Sub scan1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles scan1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            scanBorrower()
        End If
    End Sub

    Private Sub BorrowerScanner_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        scan1.Clear()
    End Sub
End Class