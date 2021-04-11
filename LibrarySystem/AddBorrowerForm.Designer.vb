<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBorrowerForm
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.name1 = New System.Windows.Forms.TextBox()
        Me.id1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.qrbox1 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.qrbox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(121, 413)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(258, 413)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 40)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'name1
        '
        Me.name1.Location = New System.Drawing.Point(120, 37)
        Me.name1.Name = "name1"
        Me.name1.Size = New System.Drawing.Size(279, 22)
        Me.name1.TabIndex = 1
        '
        'id1
        '
        Me.id1.Location = New System.Drawing.Point(120, 78)
        Me.id1.Name = "id1"
        Me.id1.Size = New System.Drawing.Size(279, 22)
        Me.id1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID Number:"
        '
        'qrbox1
        '
        Me.qrbox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.qrbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.qrbox1.Location = New System.Drawing.Point(144, 136)
        Me.qrbox1.Name = "qrbox1"
        Me.qrbox1.Size = New System.Drawing.Size(200, 200)
        Me.qrbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.qrbox1.TabIndex = 3
        Me.qrbox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(179, 353)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 24)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Generate QR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'AddBorrowerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 474)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.qrbox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.id1)
        Me.Controls.Add(Me.name1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "AddBorrowerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Borrower"
        CType(Me.qrbox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents name1 As TextBox
    Friend WithEvents id1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents qrbox1 As PictureBox
    Friend WithEvents Button4 As Button
End Class
