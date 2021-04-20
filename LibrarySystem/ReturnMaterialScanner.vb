Imports System.Data.SqlClient
Imports ZXing
Public Class ReturnMaterialScanner
    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
        scanborrower()
    End Sub

    Private Sub scanborrower()
        Try
            Dim inputArr = TextBox1.Text.Split("_")
            Dim studID = Integer.Parse(inputArr(1))

            'query if borrower exists
            Dim query As String = "SELECT * from Student WHERE idStudent = @id and Name = @name"
            Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", studID)
                    cmd.Parameters.AddWithValue("@name", inputArr(0))
                    con.Open()

                    Dim ds As SqlDataReader = cmd.ExecuteReader()
                    If ds.Read() Then
                        'query Borrower ID in BookBorrowed table
                        Dim query2 As String = "SELECT LibraryMaterial_AccessionNum, Student_idStudent, LibraryMaterial.Title, Student.Name FROM MaterialBorrow INNER JOIN LibraryMaterial ON MaterialBorrow.LibraryMaterial_AccessionNum = LibraryMaterial.AccessionNum INNER JOIN Student ON MaterialBorrow.Student_idStudent = Student.idStudent  WHERE Student_idStudent=@id AND date_returned IS NULL"
                        Using con2 As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True")
                            Using cmd2 As SqlCommand = New SqlCommand(query2, con2)
                                cmd2.Parameters.AddWithValue("@id", (studID))
                                con2.Open()

                                Dim ds2 As SqlDataReader = cmd2.ExecuteReader()
                                If ds2.Read() Then
                                    ReturnMaterialForm.midlbl.Text = ds2.GetInt32(0)
                                    ReturnMaterialForm.idlbl.Text = ds2.GetInt32(1)
                                    ReturnMaterialForm.mtitlelbl.Text = ds2.GetString(2)
                                    ReturnMaterialForm.namelbl.Text = ds2.GetString(3)
                                    'display in ReturnForm
                                    Dim writer As New BarcodeWriter
                                    writer.Format = BarcodeFormat.QR_CODE
                                    Dim options As New ZXing.Common.EncodingOptions

                                    'setting QR dimensions
                                    options.Width = 200
                                    options.Height = 200

                                    'write QR
                                    ReturnMaterialForm.PictureBox1.Image = writer.Write(TextBox1.Text)
                                    Me.Dispose()
                                Else
                                    MessageBox.Show("No such record exists.")
                                End If

                                con2.Close()

                            End Using
                        End Using
                    Else
                        MessageBox.Show("Borrower does not exist.")
                    End If

                    con.Close()

                End Using
            End Using


        Catch ex As Exception
            MessageBox.Show("Incorrect Borrower QR.")
        End Try
    End Sub

    Private Sub ReturnMaterialScanner_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            scanborrower()
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        TextBox1.Clear()
    End Sub
End Class