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
                Module1.LoadBookInv(InventoryForm.DataGridView1)
            End Using
        End Using

        'generate QR
        'query for last entry's id
        Dim QRID As Integer = -1
        Dim query2 As String = "SELECT BookId from [dbo].[Book] ORDER BY BookId DESC"
        Using con2 As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd2 As SqlCommand = New SqlCommand(query2, con2)
                con2.Open()

                Dim ds2 As SqlDataReader = cmd2.ExecuteReader()
                If ds2.Read() Then
                    QRID = ds2.GetInt32(0)
                Else
                    QRID = 0
                End If

                con2.Close()

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
        Dim filename = (QRID).ToString
        QRbox1.Image = writer.Write(filename)
        'save QR

        Dim savepath As String = My.Computer.FileSystem.SpecialDirectories.MyPictures & "\BookQR\"
        Dim savefile As String = System.IO.Path.Combine(savepath, filename + ".png")

        If (Not System.IO.Directory.Exists(savepath)) Then
            System.IO.Directory.CreateDirectory(savepath)
        End If

        QRbox1.Image.Save(savefile, System.Drawing.Imaging.ImageFormat.Png)

        If InventoryForm.invCategoryBox.SelectedIndex = 0 Then
            LoadBookInv(InventoryForm.DataGridView1)
        ElseIf InventoryForm.invCategoryBox.SelectedIndex = 1 Then
            LoadMaterialInv(InventoryForm.DataGridView1)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        'add photo functionality
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Me.Close()
        InventoryForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
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
        Button1.Enabled = True
    End Sub

    Private Sub AddBookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        Label7.Parent = PictureBox1
        Label3.Parent = PictureBox1
        Label4.Parent = PictureBox1
        Label5.Parent = PictureBox1
        Label6.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        Label7.BackColor = Color.Transparent
        Label3.BackColor = Color.Transparent
        Label4.BackColor = Color.Transparent
        Label5.BackColor = Color.Transparent
        Label6.BackColor = Color.Transparent
        Button1.Enabled = True

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
