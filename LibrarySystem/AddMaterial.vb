Imports System.Data.SqlClient
Imports ZXing

Public Class AddMaterial
    Private Sub AddMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        Label2.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        Label2.BackColor = Color.Transparent
    End Sub

    Private Sub mAddBtn_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim query As String = "INSERT INTO [dbo].[LibraryMaterial] ([AccessionNum], [Title]) VALUES(@AccessionNum, @Title)"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@AccessionNum", accnumBox.Text)
                cmd.Parameters.AddWithValue("@Title", mtitleBox.Text)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Successfully added!")
                LoadMaterialInv(InventoryForm.DataGridView1)
            End Using
        End Using
        If InventoryForm.invCategoryBox.SelectedIndex = 0 Then
            LoadBookInv(InventoryForm.DataGridView1)
        ElseIf InventoryForm.invCategoryBox.SelectedIndex = 1 Then
            LoadMaterialInv(InventoryForm.DataGridView1)
        End If
        'saving QR to file
        Dim savepath As String = My.Computer.FileSystem.SpecialDirectories.MyPictures & "\MaterialsQR\"
        Dim savefile As String = System.IO.Path.Combine(savepath, mtitleBox.Text + "_" + accnumBox.Text + ".png")

        If (Not System.IO.Directory.Exists(savepath)) Then
            System.IO.Directory.CreateDirectory(savepath)
        End If

        PictureBox2.Image.Save(savefile, System.Drawing.Imaging.ImageFormat.Png)

        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        InventoryForm.Show()
    End Sub

    Private Sub mQRbtn_Click(sender As Object, e As EventArgs) Handles mQRbtn.Click
        Dim flag As Integer
        'checking fields
        If System.Text.RegularExpressions.Regex.IsMatch(mtitleBox.Text, "^[a-zA-Z0-9\s]+$") Then
            flag += 1
        End If

        If System.Text.RegularExpressions.Regex.IsMatch(accnumBox.Text, "^[0-9]+$") Then
            flag += 1
        End If

        If flag = 2 Then
            'query if material exists
            Dim query As String = "SELECT * from [dbo].[LibraryMaterial] WHERE AccessionNum=@id"
            Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", Integer.Parse(accnumBox.Text))
                    con.Open()

                    Dim ds As SqlDataReader = cmd.ExecuteReader()
                    If ds.Read() Then
                        MessageBox.Show("Accession Number already in use.")
                    Else
                        'write barcode
                        'initialize barcode writer
                        Dim writer As New BarcodeWriter
                        writer.Format = BarcodeFormat.QR_CODE
                        Dim options As New ZXing.Common.EncodingOptions

                        'setting QR dimensions
                        options.Width = 200
                        options.Height = 200

                        'write QR
                        PictureBox2.Image = writer.Write(mtitleBox.Text + "_" + accnumBox.Text)
                    End If
                    con.Close()
                End Using
            End Using
        Else
            MessageBox.Show("Invalid input.")
        End If
    End Sub
End Class