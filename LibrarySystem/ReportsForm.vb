Public Class ReportsForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            LoadBorrow(DataGridView1)
        ElseIf ComboBox1.SelectedIndex = 1 Then
            'show materials borrowed
        ElseIf ComboBox1.SelectedIndex = 2 Then
            'show student logs
            'insert francis code (time span thingy)
        End If
    End Sub

    Private Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
    End Sub
End Class