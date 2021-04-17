<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowHistoryForm
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
        Me.namelbl = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.fineslbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.booklbl = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'namelbl
        '
        Me.namelbl.AutoSize = True
        Me.namelbl.Location = New System.Drawing.Point(50, 24)
        Me.namelbl.Name = "namelbl"
        Me.namelbl.Size = New System.Drawing.Size(106, 17)
        Me.namelbl.TabIndex = 0
        Me.namelbl.Text = "Borrower Name"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(37, 111)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(739, 327)
        Me.DataGridView1.TabIndex = 1
        '
        'fineslbl
        '
        Me.fineslbl.AutoSize = True
        Me.fineslbl.Location = New System.Drawing.Point(102, 65)
        Me.fineslbl.Name = "fineslbl"
        Me.fineslbl.Size = New System.Drawing.Size(38, 17)
        Me.fineslbl.TabIndex = 0
        Me.fineslbl.Text = "fines"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fines:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(567, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Books borrowed:"
        '
        'booklbl
        '
        Me.booklbl.AutoSize = True
        Me.booklbl.Location = New System.Drawing.Point(687, 65)
        Me.booklbl.Name = "booklbl"
        Me.booklbl.Size = New System.Drawing.Size(64, 17)
        Me.booklbl.TabIndex = 0
        Me.booklbl.Text = "booksies"
        '
        'BorrowHistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.booklbl)
        Me.Controls.Add(Me.fineslbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.namelbl)
        Me.Name = "BorrowHistoryForm"
        Me.Text = "BorrowHistoryForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents namelbl As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents fineslbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents booklbl As Label
End Class
