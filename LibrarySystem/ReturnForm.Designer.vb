<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(95, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 144)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(106, 190)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 41)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Scan Borrower QR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 271)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Borrower:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 299)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Book Borrowed:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(46, 361)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 55)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Return Book"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(151, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Borrower:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(151, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Borrower:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(180, 361)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 55)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ReturnForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 449)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ReturnForm"
        Me.Text = "w"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
End Class
