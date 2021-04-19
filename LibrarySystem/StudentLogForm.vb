Public Class StudentLogForm
    Public datacell, datacell2
    Private Sub LogsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Button5.Click
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        Label2.Parent = PictureBox1
        Label2.BackColor = Color.Transparent
        Label2.Text = DateString
        LoadcurrentSL(DataGridView1)
        changeStudentHeaders()
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
        changeCompleteHeaders()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i = DataGridView1.CurrentRow.Index
        datacell = DataGridView1.Item(0, i).Value
        datacell2 = DataGridView1.Item(2, i).Value
        StudentLogOutForm.ShowDialog()
    End Sub

    Private Sub changeCompleteHeaders()
        DataGridView1.Columns(0).HeaderText = "Student ID"
        DataGridView1.Columns(1).HeaderText = "Name"
        DataGridView1.Columns(2).HeaderText = "Time Logged In"
        DataGridView1.Columns(3).HeaderText = "Time Logged Out"
        DataGridView1.Columns(4).HeaderText = "Remarks"
    End Sub

    Private Sub changeStudentHeaders()
        DataGridView1.Columns(0).HeaderText = "Student ID"
        DataGridView1.Columns(1).HeaderText = "Name"
        DataGridView1.Columns(2).HeaderText = "Time Logged In"
        DataGridView1.Columns(3).HeaderText = "Remarks"
    End Sub
End Class