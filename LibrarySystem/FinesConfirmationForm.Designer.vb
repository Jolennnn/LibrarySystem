<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinesConfirmationForm
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
        Me.Paybtn = New System.Windows.Forms.Button()
        Me.Recordbtn = New System.Windows.Forms.Button()
        Me.Cancelbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Paybtn
        '
        Me.Paybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Paybtn.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Paybtn.Location = New System.Drawing.Point(29, 88)
        Me.Paybtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Paybtn.Name = "Paybtn"
        Me.Paybtn.Size = New System.Drawing.Size(58, 26)
        Me.Paybtn.TabIndex = 0
        Me.Paybtn.Text = "Pay"
        Me.Paybtn.UseVisualStyleBackColor = True
        '
        'Recordbtn
        '
        Me.Recordbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Recordbtn.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Recordbtn.Location = New System.Drawing.Point(110, 88)
        Me.Recordbtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Recordbtn.Name = "Recordbtn"
        Me.Recordbtn.Size = New System.Drawing.Size(58, 26)
        Me.Recordbtn.TabIndex = 1
        Me.Recordbtn.Text = "Record"
        Me.Recordbtn.UseVisualStyleBackColor = True
        '
        'Cancelbtn
        '
        Me.Cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancelbtn.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelbtn.Location = New System.Drawing.Point(193, 88)
        Me.Cancelbtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Cancelbtn.Name = "Cancelbtn"
        Me.Cancelbtn.Size = New System.Drawing.Size(65, 26)
        Me.Cancelbtn.TabIndex = 2
        Me.Cancelbtn.Text = "Cancel"
        Me.Cancelbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(29, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select option for fines payment:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.LibrarySystem.My.Resources.Resources.IMG_3489
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(273, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'FinesConfirmationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 130)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancelbtn)
        Me.Controls.Add(Me.Recordbtn)
        Me.Controls.Add(Me.Paybtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FinesConfirmationForm"
        Me.Text = "Fines Payment"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Paybtn As Button
    Friend WithEvents Recordbtn As Button
    Friend WithEvents Cancelbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
