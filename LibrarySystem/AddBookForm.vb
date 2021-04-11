Imports System.Data.SqlClient
Imports ZXing
Public Class AddBookForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'add book query here
        Dim query As String = "INSERT INTO [dbo].[Book] ([Title], [Author], [ISBN], [YrPublish], [shelfNo], [idCategory]) VALUES(@Title, @Author, @ISBN, @YrPublish, @shelfNo, @idCategory)"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Title", titleBox.Text)
                cmd.Parameters.AddWithValue("@Author", authorBox.Text)
                cmd.Parameters.AddWithValue("@ISBN", isbnBox.Text)
                cmd.Parameters.AddWithValue("@YrPublish", yrBox.Text)
                cmd.Parameters.AddWithValue("@shelfNo", shelfBox.Text)
                cmd.Parameters.AddWithValue("@idCategory", categoryBox.SelectedValue)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Successfully added!")
                Module1.BindData(InventoryForm.DataGridView1)
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'add photo functionality
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Me.Close()
        InventoryForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'query for last entry's id
        Dim QRID As Integer = -1
        Dim query As String = "SELECT BookId from [dbo].[Book] ORDER BY BookId DESC"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                con.Open()

                Dim ds As SqlDataReader = cmd.ExecuteReader()
                If ds.Read() Then
                    QRID = ds.GetInt32(0)
                Else
                    QRID = 0
                End If

                con.Close()

            End Using
        End Using

        'generate QR
        'initialize barcode writer
        Dim writer As New BarcodeWriter
        writer.Format = BarcodeFormat.QR_CODE
        Dim options As New ZXing.Common.EncodingOptions

        'setting QR dimensions
        options.Width = 200
        options.Height = 200

        'write QR
        Dim filename = (QRID + 1).ToString
        QRbox1.Image = writer.Write(filename)
        'save QR

        Dim savepath As String = My.Computer.FileSystem.SpecialDirectories.MyPictures & "\BookQR\"
        Dim savefile As String = System.IO.Path.Combine(savepath, filename + ".png")

        If (Not System.IO.Directory.Exists(savepath)) Then
            System.IO.Directory.CreateDirectory(savepath)
        End If

        QRbox1.Image.Save(savefile, System.Drawing.Imaging.ImageFormat.Png)
    Private Sub AddBookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("SELECT * from Category", con)
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()
        Try
            con.Open()
            adapter.SelectCommand = cmd
            adapter.Fill(ds)
            con.Close()
            categoryBox.DataSource = ds.Tables(0)
            categoryBox.ValueMember = "idCategory"
            categoryBox.DisplayMember = "categoryName"
        Catch ex As Exception
            MessageBox.Show("Failed.")
        End Try

    End Sub
End Class
