<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePasswordForm
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
        Me.oldpassBox = New System.Windows.Forms.TextBox()
        Me.newpassBox = New System.Windows.Forms.TextBox()
        Me.newpassconfirmBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.changeBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'oldpassBox
        '
        Me.oldpassBox.Location = New System.Drawing.Point(212, 89)
        Me.oldpassBox.Name = "oldpassBox"
        Me.oldpassBox.Size = New System.Drawing.Size(100, 20)
        Me.oldpassBox.TabIndex = 0
        '
        'newpassBox
        '
        Me.newpassBox.Location = New System.Drawing.Point(212, 115)
        Me.newpassBox.Name = "newpassBox"
        Me.newpassBox.Size = New System.Drawing.Size(100, 20)
        Me.newpassBox.TabIndex = 1
        '
        'newpassconfirmBox
        '
        Me.newpassconfirmBox.Location = New System.Drawing.Point(212, 141)
        Me.newpassconfirmBox.Name = "newpassconfirmBox"
        Me.newpassconfirmBox.Size = New System.Drawing.Size(100, 20)
        Me.newpassconfirmBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Old Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "New Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Confirm New Password"
        '
        'changeBtn
        '
        Me.changeBtn.Location = New System.Drawing.Point(212, 167)
        Me.changeBtn.Name = "changeBtn"
        Me.changeBtn.Size = New System.Drawing.Size(100, 23)
        Me.changeBtn.TabIndex = 6
        Me.changeBtn.Text = "Change"
        Me.changeBtn.UseVisualStyleBackColor = True
        '
        'ChangePasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.changeBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.newpassconfirmBox)
        Me.Controls.Add(Me.newpassBox)
        Me.Controls.Add(Me.oldpassBox)
        Me.Name = "ChangePasswordForm"
        Me.Text = "ChangePasswordForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents oldpassBox As TextBox
    Friend WithEvents newpassBox As TextBox
    Friend WithEvents newpassconfirmBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents changeBtn As Button
End Class
