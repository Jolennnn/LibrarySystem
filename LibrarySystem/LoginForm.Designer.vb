<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.UsernameBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PasswordBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FLMSLabel = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LMSLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameBox
        '
        Me.UsernameBox.Location = New System.Drawing.Point(337, 276)
        Me.UsernameBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UsernameBox.Multiline = True
        Me.UsernameBox.Name = "UsernameBox"
        Me.UsernameBox.Size = New System.Drawing.Size(167, 25)
        Me.UsernameBox.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.LibrarySystem.My.Resources.Resources.IMG_3489
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(733, 511)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(240, 276)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username:"
        '
        'PasswordBox
        '
        Me.PasswordBox.Location = New System.Drawing.Point(337, 311)
        Me.PasswordBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PasswordBox.Multiline = True
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordBox.Size = New System.Drawing.Size(167, 25)
        Me.PasswordBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(240, 311)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password:"
        '
        'FLMSLabel
        '
        Me.FLMSLabel.AutoSize = True
        Me.FLMSLabel.Font = New System.Drawing.Font("Bahnschrift Condensed", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FLMSLabel.ForeColor = System.Drawing.Color.White
        Me.FLMSLabel.Location = New System.Drawing.Point(232, 33)
        Me.FLMSLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FLMSLabel.Name = "FLMSLabel"
        Me.FLMSLabel.Size = New System.Drawing.Size(457, 53)
        Me.FLMSLabel.TabIndex = 3
        Me.FLMSLabel.Text = "Father Leoni Memorial School"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.LibrarySystem.My.Resources.Resources.FLMHS_1_
        Me.PictureBox2.Location = New System.Drawing.Point(47, 32)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(161, 149)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'LMSLabel
        '
        Me.LMSLabel.AutoSize = True
        Me.LMSLabel.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMSLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LMSLabel.Location = New System.Drawing.Point(232, 91)
        Me.LMSLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LMSLabel.Name = "LMSLabel"
        Me.LMSLabel.Size = New System.Drawing.Size(301, 36)
        Me.LMSLabel.TabIndex = 3
        Me.LMSLabel.Text = "Library Management System"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(337, 342)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 37)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Log In"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 511)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LMSLabel)
        Me.Controls.Add(Me.FLMSLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PasswordBox)
        Me.Controls.Add(Me.UsernameBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UsernameBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PasswordBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents FLMSLabel As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LMSLabel As Label
    Friend WithEvents Button1 As Button
End Class
