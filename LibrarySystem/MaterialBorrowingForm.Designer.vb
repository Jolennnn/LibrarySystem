<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaterialBorrowingForm
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnScanBorrower = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bnamelbl = New System.Windows.Forms.Label()
        Me.bidlbl = New System.Windows.Forms.Label()
        Me.mtitlelbl = New System.Windows.Forms.Label()
        Me.midlbl = New System.Windows.Forms.Label()
        Me.btnconfirm = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.MaterialQR = New System.Windows.Forms.PictureBox()
        Me.BorrowerQR = New System.Windows.Forms.PictureBox()
        CType(Me.MaterialQR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowerQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(91, 443)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 411)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Name:"
        '
        'btnScanBorrower
        '
        Me.btnScanBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScanBorrower.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScanBorrower.Location = New System.Drawing.Point(113, 328)
        Me.btnScanBorrower.Margin = New System.Windows.Forms.Padding(4)
        Me.btnScanBorrower.Name = "btnScanBorrower"
        Me.btnScanBorrower.Size = New System.Drawing.Size(163, 46)
        Me.btnScanBorrower.TabIndex = 5
        Me.btnScanBorrower.Text = "Scan Borrower QR"
        Me.btnScanBorrower.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(507, 328)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 46)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Scan Material QR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(498, 411)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Title:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(430, 443)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Accession Num:"
        '
        'bnamelbl
        '
        Me.bnamelbl.AutoSize = True
        Me.bnamelbl.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnamelbl.Location = New System.Drawing.Point(138, 411)
        Me.bnamelbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.bnamelbl.Name = "bnamelbl"
        Me.bnamelbl.Size = New System.Drawing.Size(115, 21)
        Me.bnamelbl.TabIndex = 6
        Me.bnamelbl.Text = "Borrower Name"
        '
        'bidlbl
        '
        Me.bidlbl.AutoSize = True
        Me.bidlbl.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bidlbl.Location = New System.Drawing.Point(138, 443)
        Me.bidlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.bidlbl.Name = "bidlbl"
        Me.bidlbl.Size = New System.Drawing.Size(89, 21)
        Me.bidlbl.TabIndex = 7
        Me.bidlbl.Text = "Borrower ID"
        '
        'mtitlelbl
        '
        Me.mtitlelbl.AutoSize = True
        Me.mtitlelbl.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtitlelbl.Location = New System.Drawing.Point(571, 411)
        Me.mtitlelbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.mtitlelbl.Name = "mtitlelbl"
        Me.mtitlelbl.Size = New System.Drawing.Size(96, 21)
        Me.mtitlelbl.TabIndex = 6
        Me.mtitlelbl.Text = "Material Title"
        '
        'midlbl
        '
        Me.midlbl.AutoSize = True
        Me.midlbl.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.midlbl.Location = New System.Drawing.Point(571, 443)
        Me.midlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.midlbl.Name = "midlbl"
        Me.midlbl.Size = New System.Drawing.Size(81, 21)
        Me.midlbl.TabIndex = 7
        Me.midlbl.Text = "Material ID"
        '
        'btnconfirm
        '
        Me.btnconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconfirm.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconfirm.Location = New System.Drawing.Point(192, 495)
        Me.btnconfirm.Margin = New System.Windows.Forms.Padding(4)
        Me.btnconfirm.Name = "btnconfirm"
        Me.btnconfirm.Size = New System.Drawing.Size(163, 46)
        Me.btnconfirm.TabIndex = 5
        Me.btnconfirm.Text = "confirm"
        Me.btnconfirm.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(404, 495)
        Me.btncancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(163, 46)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'MaterialQR
        '
        Me.MaterialQR.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MaterialQR.Location = New System.Drawing.Point(492, 108)
        Me.MaterialQR.Margin = New System.Windows.Forms.Padding(4)
        Me.MaterialQR.Name = "MaterialQR"
        Me.MaterialQR.Size = New System.Drawing.Size(200, 200)
        Me.MaterialQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MaterialQR.TabIndex = 2
        Me.MaterialQR.TabStop = False
        '
        'BorrowerQR
        '
        Me.BorrowerQR.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BorrowerQR.Location = New System.Drawing.Point(91, 108)
        Me.BorrowerQR.Margin = New System.Windows.Forms.Padding(4)
        Me.BorrowerQR.Name = "BorrowerQR"
        Me.BorrowerQR.Size = New System.Drawing.Size(200, 200)
        Me.BorrowerQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BorrowerQR.TabIndex = 1
        Me.BorrowerQR.TabStop = False
        '
        'MaterialBorrowingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 543)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.midlbl)
        Me.Controls.Add(Me.bidlbl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mtitlelbl)
        Me.Controls.Add(Me.bnamelbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnconfirm)
        Me.Controls.Add(Me.btnScanBorrower)
        Me.Controls.Add(Me.MaterialQR)
        Me.Controls.Add(Me.BorrowerQR)
        Me.Name = "MaterialBorrowingForm"
        Me.Text = "MaterialBorrowingForm"
        CType(Me.MaterialQR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowerQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BorrowerQR As PictureBox
    Friend WithEvents MaterialQR As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnScanBorrower As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents bnamelbl As Label
    Friend WithEvents bidlbl As Label
    Friend WithEvents mtitlelbl As Label
    Friend WithEvents midlbl As Label
    Friend WithEvents btnconfirm As Button
    Friend WithEvents btncancel As Button
End Class
