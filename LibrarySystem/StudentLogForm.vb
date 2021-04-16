Public Class StudentLogForm
    Public datacell, datacell2
    Private Sub LogsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        Label2.Parent = PictureBox1
        Label2.BackColor = Color.Transparent
        Label2.Text = DateString
        LoadcurrentSL(DataGridView1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        StudentLogInForm.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Module1.LoadStudentLogs(DataGridView1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i = DataGridView1.CurrentRow.Index
        datacell = DataGridView1.Item(0, i).Value
        datacell2 = DataGridView1.Item(2, i).Value
        StudentLogOutForm.ShowDialog()
    End Sub
End Class