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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.MaterialQR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowerQR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(68, 360)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(50, 334)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Name:"
        '
        'btnScanBorrower
        '
        Me.btnScanBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnScanBorrower.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScanBorrower.Location = New System.Drawing.Point(85, 266)
        Me.btnScanBorrower.Name = "btnScanBorrower"
        Me.btnScanBorrower.Size = New System.Drawing.Size(122, 37)
        Me.btnScanBorrower.TabIndex = 5
        Me.btnScanBorrower.Text = "Scan Borrower QR"
        Me.btnScanBorrower.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(380, 266)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 37)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Scan Material QR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(379, 334)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Title:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(322, 360)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Accession Num:"
        '
        'bnamelbl
        '
        Me.bnamelbl.AutoSize = True
        Me.bnamelbl.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnamelbl.ForeColor = System.Drawing.Color.White
        Me.bnamelbl.Location = New System.Drawing.Point(104, 334)
        Me.bnamelbl.Name = "bnamelbl"
        Me.bnamelbl.Size = New System.Drawing.Size(89, 16)
        Me.bnamelbl.TabIndex = 6
        Me.bnamelbl.Text = "Borrower Name"
        '
        'bidlbl
        '
        Me.bidlbl.AutoSize = True
        Me.bidlbl.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bidlbl.ForeColor = System.Drawing.Color.White
        Me.bidlbl.Location = New System.Drawing.Point(104, 360)
        Me.bidlbl.Name = "bidlbl"
        Me.bidlbl.Size = New System.Drawing.Size(70, 16)
        Me.bidlbl.TabIndex = 7
        Me.bidlbl.Text = "Borrower ID"
        '
        'mtitlelbl
        '
        Me.mtitlelbl.AutoSize = True
        Me.mtitlelbl.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtitlelbl.ForeColor = System.Drawing.Color.White
        Me.mtitlelbl.Location = New System.Drawing.Point(428, 334)
        Me.mtitlelbl.Name = "mtitlelbl"
        Me.mtitlelbl.Size = New System.Drawing.Size(74, 16)
        Me.mtitlelbl.TabIndex = 6
        Me.mtitlelbl.Text = "Material Title"
        '
        'midlbl
        '
        Me.midlbl.AutoSize = True
        Me.midlbl.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.midlbl.ForeColor = System.Drawing.Color.White
        Me.midlbl.Location = New System.Drawing.Point(428, 360)
        Me.midlbl.Name = "midlbl"
        Me.midlbl.Size = New System.Drawing.Size(63, 16)
        Me.midlbl.TabIndex = 7
        Me.midlbl.Text = "Material ID"
        '
        'btnconfirm
        '
        Me.btnconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconfirm.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconfirm.Location = New System.Drawing.Point(144, 396)
        Me.btnconfirm.Name = "btnconfirm"
        Me.btnconfirm.Size = New System.Drawing.Size(122, 37)
        Me.btnconfirm.TabIndex = 5
        Me.btnconfirm.Text = "Confirm"
        Me.btnconfirm.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(303, 396)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(122, 37)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'MaterialQR
        '
        Me.MaterialQR.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MaterialQR.Location = New System.Drawing.Point(369, 88)
        Me.MaterialQR.Name = "MaterialQR"
        Me.MaterialQR.Size = New System.Drawing.Size(150, 162)
        Me.MaterialQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MaterialQR.TabIndex = 2
        Me.MaterialQR.TabStop = False
        '
        'BorrowerQR
        '
        Me.BorrowerQR.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BorrowerQR.Location = New System.Drawing.Point(68, 88)
        Me.BorrowerQR.Name = "BorrowerQR"
        Me.BorrowerQR.Size = New System.Drawing.Size(150, 162)
        Me.BorrowerQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BorrowerQR.TabIndex = 1
        Me.BorrowerQR.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.LibrarySystem.My.Resources.Resources.IMG_3489
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(600, 441)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'MaterialBorrowingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 441)
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
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MaterialBorrowingForm"
        Me.Text = "MaterialBorrowingForm"
        CType(Me.MaterialQR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowerQR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
End Class
