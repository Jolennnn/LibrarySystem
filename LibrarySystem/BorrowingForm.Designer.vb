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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.borrowerName = New System.Windows.Forms.Label()
        Me.borrowerID = New System.Windows.Forms.Label()
        CType(Me.BookQRimg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowerQRimg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BookQRimg
        '
        Me.BookQRimg.Location = New System.Drawing.Point(665, 124)
        Me.BookQRimg.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BookQRimg.Name = "BookQRimg"
        Me.BookQRimg.Size = New System.Drawing.Size(289, 240)
        Me.BookQRimg.TabIndex = 0
        Me.BookQRimg.TabStop = False
        '
        'BorrowerQRimg
        '
        Me.BorrowerQRimg.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BorrowerQRimg.Location = New System.Drawing.Point(61, 124)
        Me.BorrowerQRimg.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BorrowerQRimg.Name = "BorrowerQRimg"
        Me.BorrowerQRimg.Size = New System.Drawing.Size(289, 240)
        Me.BorrowerQRimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BorrowerQRimg.TabIndex = 1
        Me.BorrowerQRimg.TabStop = False
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(94, 596)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(124, 46)
        Me.btnConfirm.TabIndex = 2
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(226, 596)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(124, 46)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(661, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Book Borrowed:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Borrower:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 467)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(82, 499)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ID:"
        '
        'btnScanBorrower
        '
        Me.btnScanBorrower.Location = New System.Drawing.Point(126, 383)
        Me.btnScanBorrower.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnScanBorrower.Name = "btnScanBorrower"
        Me.btnScanBorrower.Size = New System.Drawing.Size(163, 46)
        Me.btnScanBorrower.TabIndex = 2
        Me.btnScanBorrower.Text = "Scan Borrower QR"
        Me.btnScanBorrower.UseVisualStyleBackColor = True
        '
        'BtnScanBook
        '
        Me.BtnScanBook.Location = New System.Drawing.Point(733, 383)
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
        Me.Label9.Location = New System.Drawing.Point(661, 450)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 17)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Borrower:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(661, 482)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 17)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Borrower:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(661, 518)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 17)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Borrower:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(661, 553)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 17)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Borrower:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(661, 587)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 17)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Borrower:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(661, 625)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 17)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Borrower:"
        '
        'borrowerName
        '
        Me.borrowerName.AutoSize = True
        Me.borrowerName.Location = New System.Drawing.Point(126, 467)
        Me.borrowerName.Name = "borrowerName"
        Me.borrowerName.Size = New System.Drawing.Size(12, 17)
        Me.borrowerName.TabIndex = 5
        Me.borrowerName.Text = " "
        '
        'borrowerID
        '
        Me.borrowerID.AutoSize = True
        Me.borrowerID.Location = New System.Drawing.Point(126, 499)
        Me.borrowerID.Name = "borrowerID"
        Me.borrowerID.Size = New System.Drawing.Size(12, 17)
        Me.borrowerID.TabIndex = 5
        Me.borrowerID.Text = " "
        '
        'BorrowingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 662)
        Me.Controls.Add(Me.borrowerID)
        Me.Controls.Add(Me.borrowerName)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "BorrowingForm"
        Me.Text = "Borrow Book"
        CType(Me.BookQRimg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowerQRimg, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents borrowerName As Label
    Friend WithEvents borrowerID As Label
End Class
