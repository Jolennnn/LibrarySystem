Public Class ReportsForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        MainForm.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged, Button2.Click
        If ComboBox1.SelectedIndex = 0 Then
            studloghide()
            LoadBorrow(DataGridView1)
            changeBorrowHeaders()
            Button2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            studloghide()
            Button2.Visible = False
            'show materials borrowed
        ElseIf ComboBox1.SelectedIndex = 2 Then
            'show student logs
            studlogshow()
            'insert francis code (time span thingy)
            studlogspanshow()
            changeCompleteHeaders()
            Button2.Visible = True
        End If
    End Sub

    Private Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        Label2.Parent = PictureBox1
        Label2.BackColor = Color.Transparent
        Label3.Parent = PictureBox1
        Label3.BackColor = Color.Transparent
        Label4.Parent = PictureBox1
        Label4.BackColor = Color.Transparent
        ComboBox1.SelectedIndex = 0
        LoadBorrow(DataGridView1)
        changeBorrowHeaders()
        studloghide()
        Button2.Visible = False
    End Sub

    Private Sub studloghide()
        dtFrom.Hide()
        dtTo.Hide()
        Label2.Hide()
        Label3.Hide()
    End Sub

    Private Sub studlogshow()
        dtFrom.Show()
        dtTo.Show()
        Label2.Show()
        Label3.Show()
    End Sub

    Private Sub studlogspanshow()
        Module1.LoadSLTimespan(DataGridView1, dtFrom.Value, dtTo.Value)
    End Sub

    Private Sub changeBorrowHeaders()
        DataGridView1.Columns(0).HeaderText = "Book ID"
        DataGridView1.Columns(1).HeaderText = "Title"
        DataGridView1.Columns(2).HeaderText = "Student ID"
        DataGridView1.Columns(3).HeaderText = "Student Name"
        DataGridView1.Columns(4).HeaderText = "Date Borrowed"
        DataGridView1.Columns(5).HeaderText = "Date Returned"
        DataGridView1.Columns(6).HeaderText = "Remarks"
    End Sub

    Private Sub changeCompleteHeaders()
        DataGridView1.Columns(0).HeaderText = "Student ID"
        DataGridView1.Columns(1).HeaderText = "Name"
        DataGridView1.Columns(2).HeaderText = "Time Logged In"
        DataGridView1.Columns(3).HeaderText = "Time Logged Out"
        DataGridView1.Columns(4).HeaderText = "Remarks"
    End Sub
End Class