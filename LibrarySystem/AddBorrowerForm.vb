Imports ZXing

Public Class AddBorrowerForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'encryption used

        'encrypting data

        'initialize barcode writer
        Dim writer As New BarcodeWriter
        writer.Format = BarcodeFormat.QR_CODE
        Dim options As New ZXing.Common.EncodingOptions

        'setting QR dimensions
        options.Width = 200
        options.Height = 200

        'write QR
        qrbox1.Image = writer.Write(name1.Text + "_" + id1.Text)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'query add borrower

        'saving QR to file
        Dim savepath As String = My.Computer.FileSystem.SpecialDirectories.MyPictures & "\BorrowerQR\"
        Dim savefile As String = System.IO.Path.Combine(savepath, name1.Text + "_" + id1.Text + ".png")

        If (Not System.IO.Directory.Exists(savepath)) Then
            System.IO.Directory.CreateDirectory(savepath)
        End If

        qrbox1.Image.Save(savefile, System.Drawing.Imaging.ImageFormat.Png)

        MessageBox.Show("User Added Successfully")
        Me.Close()

    End Sub

End Class