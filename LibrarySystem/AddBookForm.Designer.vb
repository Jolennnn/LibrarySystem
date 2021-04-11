<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddBookForm
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.titleBox = New System.Windows.Forms.TextBox()
        Me.authorBox = New System.Windows.Forms.TextBox()
        Me.isbnBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.yrBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.shelfBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.categoryBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.BookDataSet1 = New LibrarySystem.BookDataSet()
        Me.BookTableAdapter1 = New LibrarySystem.BookDataSetTableAdapters.BookTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.QRbox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QRbox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(201, 323)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 52)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add book"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'titleBox
        '
        Me.titleBox.Location = New System.Drawing.Point(215, 68)
        Me.titleBox.Margin = New System.Windows.Forms.Padding(4)
        Me.titleBox.Name = "titleBox"
        Me.titleBox.Size = New System.Drawing.Size(132, 22)
        Me.titleBox.TabIndex = 1
        '
        'authorBox
        '
        Me.authorBox.Location = New System.Drawing.Point(215, 98)
        Me.authorBox.Margin = New System.Windows.Forms.Padding(4)
        Me.authorBox.Name = "authorBox"
        Me.authorBox.Size = New System.Drawing.Size(132, 22)
        Me.authorBox.TabIndex = 1
        '
        'isbnBox
        '
        Me.isbnBox.Location = New System.Drawing.Point(215, 130)
        Me.isbnBox.Margin = New System.Windows.Forms.Padding(4)
        Me.isbnBox.Name = "isbnBox"
        Me.isbnBox.Size = New System.Drawing.Size(132, 22)
        Me.isbnBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Book Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 134)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ISBN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 166)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Year Published"
        '
        'yrBox
        '
        Me.yrBox.Location = New System.Drawing.Point(215, 162)
        Me.yrBox.Margin = New System.Windows.Forms.Padding(4)
        Me.yrBox.Name = "yrBox"
        Me.yrBox.Size = New System.Drawing.Size(132, 22)
        Me.yrBox.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(73, 198)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Shelf Number"
        '
        'shelfBox
        '
        Me.shelfBox.Location = New System.Drawing.Point(215, 194)
        Me.shelfBox.Margin = New System.Windows.Forms.Padding(4)
        Me.shelfBox.Name = "shelfBox"
        Me.shelfBox.Size = New System.Drawing.Size(132, 22)
        Me.shelfBox.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(73, 230)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Category"
        '
        'categoryBox
        '
        Me.categoryBox.Location = New System.Drawing.Point(215, 226)
        Me.categoryBox.Margin = New System.Windows.Forms.Padding(4)
        Me.categoryBox.Name = "categoryBox"
        Me.categoryBox.Size = New System.Drawing.Size(132, 22)
        Me.categoryBox.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(73, 102)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Author"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.LibrarySystem.My.Resources.Resources.IMG_3489
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1065, 398)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(844, 271)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Add photo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(755, 46)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(271, 217)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'BackBtn
        '
        Me.BackBtn.Location = New System.Drawing.Point(24, 15)
        Me.BackBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(100, 28)
        Me.BackBtn.TabIndex = 6
        Me.BackBtn.Text = "Back"
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'BookDataSet1
        '
        Me.BookDataSet1.DataSetName = "BookDataSet"
        Me.BookDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookTableAdapter1
        '
        Me.BookTableAdapter1.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(548, 271)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 28)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "GenerateQR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'QRbox1
        '
        Me.QRbox1.Location = New System.Drawing.Point(467, 46)
        Me.QRbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.QRbox1.Name = "QRbox1"
        Me.QRbox1.Size = New System.Drawing.Size(271, 217)
        Me.QRbox1.TabIndex = 5
        Me.QRbox1.TabStop = False
        '
        'AddBookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 398)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.QRbox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.categoryBox)
        Me.Controls.Add(Me.shelfBox)
        Me.Controls.Add(Me.yrBox)
        Me.Controls.Add(Me.isbnBox)
        Me.Controls.Add(Me.authorBox)
        Me.Controls.Add(Me.titleBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddBookForm"
        Me.Text = "AddBookForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QRbox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents titleBox As TextBox
    Friend WithEvents authorBox As TextBox
    Friend WithEvents isbnBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents yrBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents shelfBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents categoryBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BackBtn As Button
    Friend WithEvents BookDataSet1 As BookDataSet
    Friend WithEvents BookTableAdapter1 As BookDataSetTableAdapters.BookTableAdapter
    Friend WithEvents Button3 As Button
    Friend WithEvents QRbox1 As PictureBox
End Class
