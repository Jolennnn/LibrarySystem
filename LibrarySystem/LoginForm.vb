Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FLMSLabel.Parent = PictureBox1
        LMSLabel.Parent = PictureBox1
        PictureBox2.Parent = PictureBox1
        FLMSLabel.BackColor = Color.Transparent
        LMSLabel.BackColor = Color.Transparent
        PictureBox2.BackColor = Color.Transparent
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim max As Integer = 5000
        Dim rnd As New Random
        Dim rand As Integer = rnd.Next(10, max + 1)
        Dim i As Integer = 1
        Dim number(max - 1) As Integer

        For i = 0 To max - 1
            If number(i) = rand Then
                rand = rnd.Next(1, max + 1)
                i = -1
            ElseIf number(i) = 0 Then
                number(i) = rand
                rand = rnd.Next(1, max + 1)
                If i = max - 1 Then
                    Exit For
                End If
                i = -1
            End If
        Next
        Timer1.Interval = number(i)
        i += 1
        ChangeImage()
    End Sub

    Private Sub ChangeImage()
        Static Dim iImage1 As Integer
        Select Case iImage1
            Case 0
                PictureBox3.Visible = True
                PictureBox3.Image = Image.FromFile("images/pic1.jpg")
                iImage1 += 1
            Case 1
                PictureBox3.Visible = True
                PictureBox3.Image = Image.FromFile("images/pic2.jpg")
                iImage1 += 1
            Case 2
                PictureBox3.Visible = True
                PictureBox3.Image = Image.FromFile("images/pic3.jpg")
                iImage1 = 0
        End Select
    End Sub


End Class