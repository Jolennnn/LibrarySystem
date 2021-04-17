Public Class ReportsForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged, Button2.Click
        If ComboBox1.SelectedIndex = 0 Then
            studloghide()
            LoadBorrow(DataGridView1)
        ElseIf ComboBox1.SelectedIndex = 1 Then
            studloghide()
            'show materials borrowed
        ElseIf ComboBox1.SelectedIndex = 2 Then
            'show student logs
            studlogshow()
            'insert francis code (time span thingy)
            studlogspanshow()

        End If
    End Sub

    Private Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent

        studloghide()
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

End Class