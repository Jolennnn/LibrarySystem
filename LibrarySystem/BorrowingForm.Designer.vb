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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.BookQRimg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowerQRimg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BookQRimg
        '
        Me.BookQRimg.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BookQRimg.Location = New System.Drawing.Point(460, 101)
        Me.BookQRimg.Name = "BookQRimg"
        Me.BookQRimg.Size = New System.Drawing.Size(289, 240)
        Me.BookQRimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BookQRimg.TabIndex = 0
        Me.BookQRimg.TabStop = False
        '
        'BorrowerQRimg
        '
        Me.BorrowerQRimg.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BorrowerQRimg.Location = New System.Drawing.Point(46, 101)
        Me.BorrowerQRimg.Name = "BorrowerQRimg"
        Me.BorrowerQRimg.Size = New System.Drawing.Size(289, 240)
        Me.BorrowerQRimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BorrowerQRimg.TabIndex = 1
        Me.BorrowerQRimg.TabStop = False
        '
        'btnConfirm
        '
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(70, 484)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(93, 37)
        Me.btnConfirm.TabIndex = 2
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(170, 484)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(93, 37)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(455, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Book Borrowed:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(41, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Borrower:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 379)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 405)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ID:"
        '
        'btnScanBorrower
        '
        Me.btnScanBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScanBorrower.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScanBorrower.Location = New System.Drawing.Point(131, 311)
        Me.btnScanBorrower.Name = "btnScanBorrower"
        Me.btnScanBorrower.Size = New System.Drawing.Size(122, 37)
        Me.btnScanBorrower.TabIndex = 2
        Me.btnScanBorrower.Text = "Scan Borrower QR"
        Me.btnScanBorrower.UseVisualStyleBackColor = True
        '
        'BtnScanBook
        '
        Me.BtnScanBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnScanBook.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnScanBook.Location = New System.Drawing.Point(549, 311)
        Me.BtnScanBook.Name = "BtnScanBook"
        Me.BtnScanBook.Size = New System.Drawing.Size(116, 37)
        Me.BtnScanBook.TabIndex = 2
        Me.BtnScanBook.Text = "Scan Book QR"
        Me.BtnScanBook.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(568, 393)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Title:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(557, 414)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Author:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(566, 436)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "ISBN:"
        '
        'bookID
        '
        Me.bookID.AutoSize = True
        Me.bookID.Location = New System.Drawing.Point(604, 371)
        Me.bookID.Name = "bookID"
        Me.bookID.Size = New System.Drawing.Size(46, 13)
        Me.bookID.TabIndex = 4
        Me.bookID.Text = "BookID:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(517, 458)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Year Published:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(565, 476)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Shelf:"
        '
        'borrowerName
        '
        Me.borrowerName.AutoSize = True
        Me.borrowerName.Location = New System.Drawing.Point(94, 379)
        Me.borrowerName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.borrowerName.Name = "borrowerName"
        Me.borrowerName.Size = New System.Drawing.Size(10, 13)
        Me.borrowerName.TabIndex = 5
        Me.borrowerName.Text = " "
        '
        'borrowerID
        '
        Me.borrowerID.AutoSize = True
        Me.borrowerID.Location = New System.Drawing.Point(94, 405)
        Me.borrowerID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.borrowerID.Name = "borrowerID"
        Me.borrowerID.Size = New System.Drawing.Size(10, 13)
        Me.borrowerID.TabIndex = 5
        Me.borrowerID.Text = " "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(546, 497)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Category:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(554, 371)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "BookID:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(604, 393)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "BookID:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(604, 414)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "BookID:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(604, 436)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "BookID:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(606, 458)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "BookID:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(606, 476)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 13)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "BookID:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(606, 497)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 13)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "BookID:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.LibrarySystem.My.Resources.Resources.IMG_3489
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(770, 538)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'BorrowingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 538)
        Me.Controls.Add(Me.borrowerID)
        Me.Controls.Add(Me.borrowerName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.bookID)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnScanBorrower)
        Me.Controls.Add(Me.BtnScanBook)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.BorrowerQRimg)
        Me.Controls.Add(Me.BookQRimg)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "BorrowingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Borrow Book"
        CType(Me.BookQRimg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowerQRimg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BookQRimg As PictureBox
    Friend WithEvents BorrowerQRimg As PictureBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
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
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
