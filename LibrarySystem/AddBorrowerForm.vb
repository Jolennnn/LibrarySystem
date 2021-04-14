Imports ZXing
Imports System.Data.SqlClient
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
        Dim idnum As Integer
        Int32.TryParse(id1.Text, idnum)
        Dim query As String = "INSERT INTO [dbo].[Student] ([idStudent], [Name], [Fines]) VALUES(@id, @name, 0)"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", idnum)
                cmd.Parameters.AddWithValue("@name", name1.Text)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Successfully added. QR codes can be found in MyPictures folder.")
                Module1.BindData(InventoryForm.DataGridView1)
            End Using
        End Using

        'saving QR to file
        Dim savepath As String = My.Computer.FileSystem.SpecialDirectories.MyPictures & "\BorrowerQR\"
        Dim savefile As String = System.IO.Path.Combine(savepath, name1.Text + "_" + id1.Text + ".png")

        If (Not System.IO.Directory.Exists(savepath)) Then
            System.IO.Directory.CreateDirectory(savepath)
        End If

        qrbox1.Image.Save(savefile, System.Drawing.Imaging.ImageFormat.Png)

        Me.Close()

    End Sub

    Private Sub AddBorrowerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        Label2.Parent = PictureBox1
        Label2.BackColor = Color.Transparent
    End Sub
End Class