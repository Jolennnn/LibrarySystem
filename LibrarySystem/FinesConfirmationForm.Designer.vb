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
        Me.SuspendLayout()
        '
        'Paybtn
        '
        Me.Paybtn.Location = New System.Drawing.Point(39, 108)
        Me.Paybtn.Name = "Paybtn"
        Me.Paybtn.Size = New System.Drawing.Size(75, 23)
        Me.Paybtn.TabIndex = 0
        Me.Paybtn.Text = "Pay"
        Me.Paybtn.UseVisualStyleBackColor = True
        '
        'Recordbtn
        '
        Me.Recordbtn.Location = New System.Drawing.Point(146, 108)
        Me.Recordbtn.Name = "Recordbtn"
        Me.Recordbtn.Size = New System.Drawing.Size(75, 23)
        Me.Recordbtn.TabIndex = 1
        Me.Recordbtn.Text = "Record"
        Me.Recordbtn.UseVisualStyleBackColor = True
        '
        'Cancelbtn
        '
        Me.Cancelbtn.Location = New System.Drawing.Point(257, 108)
        Me.Cancelbtn.Name = "Cancelbtn"
        Me.Cancelbtn.Size = New System.Drawing.Size(75, 23)
        Me.Cancelbtn.TabIndex = 2
        Me.Cancelbtn.Text = "Cancel"
        Me.Cancelbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select option for fines payment:"
        '
        'FinesConfirmationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 154)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancelbtn)
        Me.Controls.Add(Me.Recordbtn)
        Me.Controls.Add(Me.Paybtn)
        Me.Name = "FinesConfirmationForm"
        Me.Text = "Fines Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Paybtn As Button
    Friend WithEvents Recordbtn As Button
    Friend WithEvents Cancelbtn As Button
    Friend WithEvents Label1 As Label
End Class
