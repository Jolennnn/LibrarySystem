<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.SummaryReportButton = New System.Windows.Forms.Button()
        Me.BooksBorrowedButton = New System.Windows.Forms.Button()
        Me.ReservationsButton = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SummaryReportButton
        '
        Me.SummaryReportButton.Location = New System.Drawing.Point(-5, 112)
        Me.SummaryReportButton.Name = "SummaryReportButton"
        Me.SummaryReportButton.Size = New System.Drawing.Size(160, 58)
        Me.SummaryReportButton.TabIndex = 0
        Me.SummaryReportButton.Text = "Summary Report"
        Me.SummaryReportButton.UseVisualStyleBackColor = True
        '
        'BooksBorrowedButton
        '
        Me.BooksBorrowedButton.Location = New System.Drawing.Point(-5, 176)
        Me.BooksBorrowedButton.Name = "BooksBorrowedButton"
        Me.BooksBorrowedButton.Size = New System.Drawing.Size(160, 58)
        Me.BooksBorrowedButton.TabIndex = 0
        Me.BooksBorrowedButton.Text = "Books Borrowed"
        Me.BooksBorrowedButton.UseVisualStyleBackColor = True
        '
        'ReservationsButton
        '
        Me.ReservationsButton.Location = New System.Drawing.Point(-5, 240)
        Me.ReservationsButton.Name = "ReservationsButton"
        Me.ReservationsButton.Size = New System.Drawing.Size(160, 58)
        Me.ReservationsButton.TabIndex = 0
        Me.ReservationsButton.Text = "Reservations"
        Me.ReservationsButton.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(-5, 304)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(160, 58)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Inventory"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(-5, 368)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(160, 58)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Logs"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(625, 467)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "Log out"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(191, 112)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(509, 20)
        Me.TextBox1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(746, 542)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(746, 542)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ReservationsButton)
        Me.Controls.Add(Me.BooksBorrowedButton)
        Me.Controls.Add(Me.SummaryReportButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MainForm"
        Me.Text = "Father Leoni Memorial School"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SummaryReportButton As Button
    Friend WithEvents BooksBorrowedButton As Button
    Friend WithEvents ReservationsButton As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
