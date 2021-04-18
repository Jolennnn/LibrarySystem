<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BooksBorrowedForm
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
        Me.btnBorrowBook = New System.Windows.Forms.Button()
        Me.searchBar = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnReturnBook = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bhistorybtn = New System.Windows.Forms.Button()
        Me.btndeletestudent = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.borrowlogbtn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LMSLabel = New System.Windows.Forms.Label()
        Me.FLMSLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.unreturnedbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBorrowBook
        '
        Me.btnBorrowBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrowBook.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrowBook.Location = New System.Drawing.Point(682, 172)
        Me.btnBorrowBook.Name = "btnBorrowBook"
        Me.btnBorrowBook.Size = New System.Drawing.Size(123, 59)
        Me.btnBorrowBook.TabIndex = 2
        Me.btnBorrowBook.Text = "Borrow Book"
        Me.btnBorrowBook.UseVisualStyleBackColor = True
        '
        'searchBar
        '
        Me.searchBar.Location = New System.Drawing.Point(83, 158)
        Me.searchBar.Name = "searchBar"
        Me.searchBar.Size = New System.Drawing.Size(564, 20)
        Me.searchBar.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 184)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(632, 429)
        Me.DataGridView1.TabIndex = 4
        '
        'btnDone
        '
        Me.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDone.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.Location = New System.Drawing.Point(743, 572)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(123, 31)
        Me.btnDone.TabIndex = 2
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnReturnBook
        '
        Me.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnBook.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnBook.Location = New System.Drawing.Point(811, 172)
        Me.btnReturnBook.Name = "btnReturnBook"
        Me.btnReturnBook.Size = New System.Drawing.Size(123, 59)
        Me.btnReturnBook.TabIndex = 2
        Me.btnReturnBook.Text = "Return Book"
        Me.btnReturnBook.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(10, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 59)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Borrowers"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(15, 113)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(272, 33)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "Current Borrowed Books"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(682, 238)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(252, 41)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Overdue Books"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bhistorybtn)
        Me.GroupBox1.Controls.Add(Me.btndeletestudent)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(664, 375)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 179)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Borrowers"
        '
        'bhistorybtn
        '
        Me.bhistorybtn.BackColor = System.Drawing.Color.White
        Me.bhistorybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bhistorybtn.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bhistorybtn.Location = New System.Drawing.Point(10, 102)
        Me.bhistorybtn.Name = "bhistorybtn"
        Me.bhistorybtn.Size = New System.Drawing.Size(123, 59)
        Me.bhistorybtn.TabIndex = 2
        Me.bhistorybtn.Text = "Borrower History"
        Me.bhistorybtn.UseVisualStyleBackColor = False
        '
        'btndeletestudent
        '
        Me.btndeletestudent.BackColor = System.Drawing.Color.White
        Me.btndeletestudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeletestudent.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeletestudent.Location = New System.Drawing.Point(149, 123)
        Me.btndeletestudent.Name = "btndeletestudent"
        Me.btndeletestudent.Size = New System.Drawing.Size(123, 39)
        Me.btndeletestudent.TabIndex = 2
        Me.btndeletestudent.Text = "Delete"
        Me.btndeletestudent.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(149, 77)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(123, 39)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Edit"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(149, 31)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(123, 39)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'borrowlogbtn
        '
        Me.borrowlogbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.borrowlogbtn.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borrowlogbtn.Location = New System.Drawing.Point(682, 328)
        Me.borrowlogbtn.Name = "borrowlogbtn"
        Me.borrowlogbtn.Size = New System.Drawing.Size(252, 36)
        Me.borrowlogbtn.TabIndex = 2
        Me.borrowlogbtn.Text = "Borrow History"
        Me.borrowlogbtn.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.LibrarySystem.My.Resources.Resources.FLMHS_1_
        Me.PictureBox2.Location = New System.Drawing.Point(21, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(101, 97)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'LMSLabel
        '
        Me.LMSLabel.AutoSize = True
        Me.LMSLabel.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMSLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LMSLabel.Location = New System.Drawing.Point(140, 59)
        Me.LMSLabel.Name = "LMSLabel"
        Me.LMSLabel.Size = New System.Drawing.Size(242, 29)
        Me.LMSLabel.TabIndex = 11
        Me.LMSLabel.Text = "Library Management System"
        '
        'FLMSLabel
        '
        Me.FLMSLabel.AutoSize = True
        Me.FLMSLabel.Font = New System.Drawing.Font("Bahnschrift Condensed", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FLMSLabel.ForeColor = System.Drawing.Color.White
        Me.FLMSLabel.Location = New System.Drawing.Point(140, 12)
        Me.FLMSLabel.Name = "FLMSLabel"
        Me.FLMSLabel.Size = New System.Drawing.Size(362, 42)
        Me.FLMSLabel.TabIndex = 12
        Me.FLMSLabel.Text = "Father Leoni Memorial School"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.LibrarySystem.My.Resources.Resources.IMG_3489
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(967, 677)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'unreturnedbtn
        '
        Me.unreturnedbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.unreturnedbtn.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unreturnedbtn.Location = New System.Drawing.Point(682, 286)
        Me.unreturnedbtn.Name = "unreturnedbtn"
        Me.unreturnedbtn.Size = New System.Drawing.Size(252, 36)
        Me.unreturnedbtn.TabIndex = 2
        Me.unreturnedbtn.Text = "Unreturned Books"
        Me.unreturnedbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Search:"
        '
        'BooksBorrowedForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 677)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LMSLabel)
        Me.Controls.Add(Me.FLMSLabel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.searchBar)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.unreturnedbtn)
        Me.Controls.Add(Me.borrowlogbtn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnReturnBook)
        Me.Controls.Add(Me.btnBorrowBook)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "BooksBorrowedForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book Borrowing"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBorrowBook As Button
    Friend WithEvents searchBar As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnDone As Button
    Friend WithEvents btnReturnBook As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents borrowlogbtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LMSLabel As Label
    Friend WithEvents FLMSLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bhistorybtn As Button
    Friend WithEvents btndeletestudent As Button
    Friend WithEvents unreturnedbtn As Button
    Friend WithEvents Label1 As Label
End Class
