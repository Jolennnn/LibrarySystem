Imports System.Data.SqlClient
Imports ZXing
Public Class MaterialBorrowingForm
    Private Sub btnScanBorrower_Click(sender As Object, e As EventArgs) Handles btnScanBorrower.Click
        M_BorrowerScannerForm.ShowDialog()
        bnamelbl.Visible = True
        bidlbl.Visible = True
    End Sub

    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click

        Try
            'query if material is borrowed
            Dim query2 As String = "SELECT Student_idStudent, Student.Name FROM [dbo].[MaterialBorrow] INNER JOIN Student ON MaterialBorrow.Student_idStudent = Student.idStudent WHERE LibraryMaterial_AccessionNum=@id AND date_returned IS NULL"
            Using con2 As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
                Using cmd2 As SqlCommand = New SqlCommand(query2, con2)
                    cmd2.Parameters.AddWithValue("@id", Integer.Parse(midlbl.Text))
                    con2.Open()

                    Dim ds2 As SqlDataReader = cmd2.ExecuteReader()
                    If ds2.Read() Then
                        Dim bID = ds2.GetInt32(0)
                        Dim bName = ds2.GetString(1)
                        MessageBox.Show("This material is currently borrowed by ID: " + bID.ToString + " Name: " + bName)
                    Else
                        Dim mIDnum As Integer
                        mIDnum = Integer.Parse(midlbl.Text)

                        Dim query3 As String = "INSERT INTO [dbo].[MaterialBorrow] ([LibraryMaterial_AccessionNum], [Student_IdStudent], [date_borrowed]) VALUES(@mid, @borrowerid, @datetime)"
                        Using con3 As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
                            Using cmd3 As SqlCommand = New SqlCommand(query3, con3)
                                cmd3.Parameters.AddWithValue("@mid", mIDnum)
                                cmd3.Parameters.AddWithValue("@borrowerid", bidlbl.Text)
                                cmd3.Parameters.AddWithValue("@datetime", DateTime.Now)
                                con3.Open()
                                cmd3.ExecuteNonQuery()
                                con3.Close()
                                MessageBox.Show("Sucessfully logged.")
                                Module1.LoadMaterialUnreturned(BorrowMaterialMenu.DataGridView1)
                                Me.Close()
                            End Using
                        End Using
                    End If

                    con2.Close()

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Invalid input.")
        End Try
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Dispose()
    End Sub

    Private Sub MaterialBorrowingForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MaterialScanner.ShowDialog()
        midlbl.Visible = True
        mtitlelbl.Visible = True
    End Sub

    Private Sub MaterialBorrowingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bnamelbl.Visible = False
        bidlbl.Visible = False
        mtitlelbl.Visible = False
        midlbl.Visible = False
    End Sub


End Class