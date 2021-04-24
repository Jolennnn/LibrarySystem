Imports ZXing
Imports System.Data.SqlClient
Public Class AddBorrowerForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles QRgenbtn.Click
        Dim flag As Integer
        'checking fields
        If System.Text.RegularExpressions.Regex.IsMatch(name1.Text, "^[a-zA-Z0-9\s]+$") Then
            flag += 1
        End If

        If System.Text.RegularExpressions.Regex.IsMatch(id1.Text, "^[0-9]+$") Then
            flag += 1
        End If

        If flag = 2 Then
            'query if borrower exists
            Dim query As String = "SELECT * from [dbo].[Student] WHERE idStudent=@id"
            Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", Integer.Parse(id1.Text))
                    con.Open()

                    Dim ds As SqlDataReader = cmd.ExecuteReader()
                    If ds.Read() Then
                        MessageBox.Show("ID already exists.")
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
                        qrbox1.Image = writer.Write(name1.Text + "_" + id1.Text)
                        Button1.Enabled = True
                    End If
                    con.Close()
                End Using
            End Using
        Else
            MessageBox.Show("Invalid input.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addBorrower()
    End Sub

    Private Sub AddBorrowerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        Label2.Parent = PictureBox1
        Label2.BackColor = Color.Transparent
        Button1.Enabled = False
    End Sub

    Private Sub AddBorrowerForm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            addBorrower()
        End If
    End Sub

    Private Sub addBorrower()

        Dim idnum As Integer
        Int32.TryParse(id1.Text, idnum)
        'query add borrower
        Dim query2 As String = "INSERT INTO [dbo].[Student] ([idStudent], [Name], [Fines]) VALUES(@id, @name, 0)"
        Using con2 As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd2 As SqlCommand = New SqlCommand(query2, con2)
                cmd2.Parameters.AddWithValue("@id", idnum)
                cmd2.Parameters.AddWithValue("@name", name1.Text)

                con2.Open()
                cmd2.ExecuteNonQuery()
                con2.Close()
            End Using
        End Using

        MessageBox.Show("Successfully added. QR codes can be found in MyPictures folder.")
        Module1.LoadBookInv(InventoryForm.DataGridView1)
        'saving QR to file
        Dim savepath As String = My.Computer.FileSystem.SpecialDirectories.MyPictures & "\BorrowerQR\"
        Dim savefile As String = System.IO.Path.Combine(savepath, name1.Text + "_" + id1.Text + ".png")

        If (Not System.IO.Directory.Exists(savepath)) Then
            System.IO.Directory.CreateDirectory(savepath)
        End If

        qrbox1.Image.Save(savefile, System.Drawing.Imaging.ImageFormat.Png)

        Me.Dispose()

    End Sub

    Private Sub AddBorrowerForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
End Class