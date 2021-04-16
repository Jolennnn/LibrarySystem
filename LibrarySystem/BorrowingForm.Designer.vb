<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowingForm
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
        Me.BookQRimg = New System.Windows.Forms.PictureBox()
        Me.BorrowerQRimg = New System.Windows.Forms.PictureBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnScanBorrower = New System.Windows.Forms.Button()
        Me.BtnScanBook = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.bookID = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.borrowerName = New System.Windows.Forms.Label()
        Me.borrowerID = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.title = New System.Windows.Forms.Label()
        Me.author = New System.Windows.Forms.Label()
        Me.isbn = New System.Windows.Forms.Label()
        Me.yrpub = New System.Windows.Forms.Label()
        Me.shelf = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.BookQRimg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowerQRimg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BookQRimg
        '
        Me.BookQRimg.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BookQRimg.Location = New System.Drawing.Point(120, 75)
        Me.BookQRimg.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BookQRimg.Name = "BookQRimg"
        Me.BookQRimg.Size = New System.Drawing.Size(200, 200)
        Me.BookQRimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BookQRimg.TabIndex = 0
        Me.BookQRimg.TabStop = False
        '
        'BorrowerQRimg
        '
        Me.BorrowerQRimg.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BorrowerQRimg.Location = New System.Drawing.Point(122, 75)
        Me.BorrowerQRimg.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BorrowerQRimg.Name = "BorrowerQRimg"
        Me.BorrowerQRimg.Size = New System.Drawing.Size(200, 200)
        Me.BorrowerQRimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BorrowerQRimg.TabIndex = 1
        Me.BorrowerQRimg.TabStop = False
        '
        'btnConfirm
        '
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(408, 602)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(124, 46)
        Me.btnConfirm.TabIndex = 2
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(540, 602)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(124, 46)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 466)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(83, 498)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ID:"
        '
        'btnScanBorrower
        '
        Me.btnScanBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScanBorrower.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScanBorrower.Location = New System.Drawing.Point(175, 383)
        Me.btnScanBorrower.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnScanBorrower.Name = "btnScanBorrower"
        Me.btnScanBorrower.Size = New System.Drawing.Size(163, 46)
        Me.btnScanBorrower.TabIndex = 2
        Me.btnScanBorrower.Text = "Scan Borrower QR"
        Me.btnScanBorrower.UseVisualStyleBackColor = True
        '
        'BtnScanBook
        '
        Me.BtnScanBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnScanBook.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnScanBook.Location = New System.Drawing.Point(732, 383)
        Me.BtnScanBook.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnScanBook.Name = "BtnScanBook"
        Me.BtnScanBook.Size = New System.Drawing.Size(155, 46)
        Me.BtnScanBook.TabIndex = 2
        Me.BtnScanBook.Text = "Scan Book QR"
        Me.BtnScanBook.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(173, 384)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 21)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Title:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(159, 410)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 21)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Author:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(171, 437)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 21)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "ISBN:"
        '
        'bookID
        '
        Me.bookID.AutoSize = True
        Me.bookID.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookID.Location = New System.Drawing.Point(221, 357)
        Me.bookID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.bookID.Name = "bookID"
        Me.bookID.Size = New System.Drawing.Size(14, 21)
        Me.bookID.TabIndex = 4
        Me.bookID.Text = " "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(105, 464)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 21)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Year Published:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(169, 486)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 21)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Shelf:"
        '
        'borrowerName
        '
        Me.borrowerName.AutoSize = True
        Me.borrowerName.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borrowerName.Location = New System.Drawing.Point(125, 466)
        Me.borrowerName.Name = "borrowerName"
        Me.borrowerName.Size = New System.Drawing.Size(14, 21)
        Me.borrowerName.TabIndex = 5
        Me.borrowerName.Text = " "
        '
        'borrowerID
        '
        Me.borrowerID.AutoSize = True
        Me.borrowerID.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borrowerID.Location = New System.Drawing.Point(125, 498)
        Me.borrowerID.Name = "borrowerID"
        Me.borrowerID.Size = New System.Drawing.Size(14, 21)
        Me.borrowerID.TabIndex = 5
        Me.borrowerID.Text = " "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(155, 357)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 21)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "BookID:"
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(221, 384)
        Me.title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(14, 21)
        Me.title.TabIndex = 4
        Me.title.Text = " "
        '
        'author
        '
        Me.author.AutoSize = True
        Me.author.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.author.Location = New System.Drawing.Point(221, 410)
        Me.author.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.author.Name = "author"
        Me.author.Size = New System.Drawing.Size(14, 21)
        Me.author.TabIndex = 4
        Me.author.Text = " "
        '
        'isbn
        '
        Me.isbn.AutoSize = True
        Me.isbn.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isbn.Location = New System.Drawing.Point(221, 437)
        Me.isbn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.isbn.Name = "isbn"
        Me.isbn.Size = New System.Drawing.Size(14, 21)
        Me.isbn.TabIndex = 4
        Me.isbn.Text = " "
        '
        'yrpub
        '
        Me.yrpub.AutoSize = True
        Me.yrpub.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yrpub.Location = New System.Drawing.Point(224, 464)
        Me.yrpub.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.yrpub.Name = "yrpub"
        Me.yrpub.Size = New System.Drawing.Size(14, 21)
        Me.yrpub.TabIndex = 4
        Me.yrpub.Text = " "
        '
        'shelf
        '
        Me.shelf.AutoSize = True
        Me.shelf.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shelf.Location = New System.Drawing.Point(224, 486)
        Me.shelf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.shelf.Name = "shelf"
        Me.shelf.Size = New System.Drawing.Size(14, 21)
        Me.shelf.TabIndex = 4
        Me.shelf.Text = " "
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.LibrarySystem.My.Resources.Resources.IMG_3489
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1027, 662)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BorrowerQRimg)
        Me.GroupBox1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(35, 76)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(451, 553)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Borrower"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.isbn)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.bookID)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.title)
        Me.GroupBox2.Controls.Add(Me.BookQRimg)
        Me.GroupBox2.Controls.Add(Me.author)
        Me.GroupBox2.Controls.Add(Me.shelf)
        Me.GroupBox2.Controls.Add(Me.yrpub)
        Me.GroupBox2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(584, 76)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(427, 553)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Book Borrowed"
        '
        'BorrowingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 662)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.borrowerID)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.borrowerName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnScanBorrower)
        Me.Controls.Add(Me.BtnScanBook)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "BorrowingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Borrow Book"
        CType(Me.BookQRimg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowerQRimg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BookQRimg As PictureBox
    Friend WithEvents BorrowerQRimg As PictureBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnScanBorrower As Button
    Friend WithEvents BtnScanBook As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents bookID As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents borrowerName As Label
    Friend WithEvents borrowerID As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents title As Label
    Friend WithEvents author As Label
    Friend WithEvents isbn As Label
    Friend WithEvents yrpub As Label
    Friend WithEvents shelf As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
