Imports System.Data.SqlClient
Imports ZXing
Public Class EditBorrowerForm
    Dim oldID As Integer
    Private Sub EditBorrowerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        Label2.Parent = PictureBox1
        Label3.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        Label2.BackColor = Color.Transparent
        Label3.BackColor = Color.Transparent
        'fill textboxes with data
        oldID = BooksBorrowedForm.datacell
        'query datacell
        Dim query As String = "SELECT * from [dbo].[Student] WHERE idStudent=@id"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", oldID)
                con.Open()

                Dim ds As SqlDataReader = cmd.ExecuteReader()
                If ds.Read() Then
                    idtxt.Text = ds.GetInt32(0)
                    finestxt.Text = ds.GetInt32(1)
                    nametxt.Text = ds.GetString(2)

                End If

                con.Close()

            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
        PictureBox1.Image = writer.Write(nametxt.Text + "_" + idtxt.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'confirmation dialog box
        Dim result As DialogResult = MessageBox.Show("Do you want to update this borrower's information?", "Database Update Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("Changes unsaved.")
        ElseIf result = DialogResult.Yes Then
            'query update borrower
            Dim query2 As String = "UPDATE [dbo].[Student] SET [Name]=@name, [Fines]=@fines WHERE idStudent=@id"
            Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query2, con)
                    cmd.Parameters.AddWithValue("@id", Integer.Parse(oldID))
                    cmd.Parameters.AddWithValue("@name", nametxt.Text)
                    cmd.Parameters.AddWithValue("@fines", Integer.Parse(finestxt.Text))
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show("Changes saved.")
                    Module1.LoadBorrowers(BooksBorrowedForm.DataGridView1)
                End Using
            End Using

            'save QR
            'saving QR to file
            Dim savepath As String = My.Computer.FileSystem.SpecialDirectories.MyPictures & "\BorrowerQR\"
            Dim savefile As String = System.IO.Path.Combine(savepath, nametxt.Text + "_" + idtxt.Text + ".png")

            If (Not System.IO.Directory.Exists(savepath)) Then
                System.IO.Directory.CreateDirectory(savepath)
            End If

            PictureBox1.Image.Save(savefile, System.Drawing.Imaging.ImageFormat.Png)

            Me.Close()
        End If
    End Sub
End Class