﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.idlbl = New System.Windows.Forms.Label()
        Me.booklbl = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.namelbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fineslbl = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bookidlbl = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(71, 24)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 117)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(80, 154)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 33)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Scan Borrower QR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(57, 220)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Borrower:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(27, 256)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Book Borrowed:"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(29, 349)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 45)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Return Book"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'idlbl
        '
        Me.idlbl.AutoSize = True
        Me.idlbl.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idlbl.ForeColor = System.Drawing.Color.White
        Me.idlbl.Location = New System.Drawing.Point(113, 204)
        Me.idlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.idlbl.Name = "idlbl"
        Me.idlbl.Size = New System.Drawing.Size(16, 14)
        Me.idlbl.TabIndex = 2
        Me.idlbl.Text = "id"
        '
        'booklbl
        '
        Me.booklbl.AutoSize = True
        Me.booklbl.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.booklbl.ForeColor = System.Drawing.Color.White
        Me.booklbl.Location = New System.Drawing.Point(113, 256)
        Me.booklbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.booklbl.Name = "booklbl"
        Me.booklbl.Size = New System.Drawing.Size(31, 14)
        Me.booklbl.TabIndex = 2
        Me.booklbl.Text = "book"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(130, 349)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 45)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'namelbl
        '
        Me.namelbl.AutoSize = True
        Me.namelbl.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namelbl.ForeColor = System.Drawing.Color.White
        Me.namelbl.Location = New System.Drawing.Point(113, 220)
        Me.namelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.namelbl.Name = "namelbl"
        Me.namelbl.Size = New System.Drawing.Size(34, 14)
        Me.namelbl.TabIndex = 2
        Me.namelbl.Text = "name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(44, 204)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Borrower ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(74, 270)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 14)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Fines:"
        '
        'fineslbl
        '
        Me.fineslbl.AutoSize = True
        Me.fineslbl.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fineslbl.ForeColor = System.Drawing.Color.White
        Me.fineslbl.Location = New System.Drawing.Point(113, 270)
        Me.fineslbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.fineslbl.Name = "fineslbl"
        Me.fineslbl.Size = New System.Drawing.Size(13, 14)
        Me.fineslbl.TabIndex = 2
        Me.fineslbl.Text = "0"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(116, 302)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(89, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(57, 305)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 14)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Remarks:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(61, 242)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 14)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Book ID:"
        '
        'bookidlbl
        '
        Me.bookidlbl.AutoSize = True
        Me.bookidlbl.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookidlbl.ForeColor = System.Drawing.Color.White
        Me.bookidlbl.Location = New System.Drawing.Point(113, 242)
        Me.bookidlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.bookidlbl.Name = "bookidlbl"
        Me.bookidlbl.Size = New System.Drawing.Size(46, 14)
        Me.bookidlbl.TabIndex = 2
        Me.bookidlbl.Text = "book_ID"
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.LibrarySystem.My.Resources.Resources.IMG_3489
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(275, 404)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'ReturnForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 404)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.fineslbl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bookidlbl)
        Me.Controls.Add(Me.booklbl)
        Me.Controls.Add(Me.namelbl)
        Me.Controls.Add(Me.idlbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ReturnForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Return Book"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents idlbl As Label
    Friend WithEvents booklbl As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents namelbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents fineslbl As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents bookidlbl As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
