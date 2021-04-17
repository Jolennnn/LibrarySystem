<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryForm
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
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SearchBar = New System.Windows.Forms.TextBox()
        Me.AddBookBtn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.invCategoryBox = New System.Windows.Forms.ComboBox()
        Me.addMaterialBtn = New System.Windows.Forms.Button()
        Me.searchbyBox = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackBtn
        '
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackBtn.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtn.Location = New System.Drawing.Point(12, 21)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(45, 30)
        Me.BackBtn.TabIndex = 0
        Me.BackBtn.Text = "Back"
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(63, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Inventory"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 118)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(680, 294)
        Me.DataGridView1.TabIndex = 2
        '
        'SearchBar
        '
        Me.SearchBar.Location = New System.Drawing.Point(139, 80)
        Me.SearchBar.Name = "SearchBar"
        Me.SearchBar.Size = New System.Drawing.Size(553, 20)
        Me.SearchBar.TabIndex = 3
        '
        'AddBookBtn
        '
        Me.AddBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddBookBtn.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBookBtn.Location = New System.Drawing.Point(411, 21)
        Me.AddBookBtn.Name = "AddBookBtn"
        Me.AddBookBtn.Size = New System.Drawing.Size(75, 30)
        Me.AddBookBtn.TabIndex = 4
        Me.AddBookBtn.Text = "Add Book"
        Me.AddBookBtn.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(591, 21)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 30)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = " Delete Book"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.LibrarySystem.My.Resources.Resources.IMG_3489
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(714, 431)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'invCategoryBox
        '
        Me.invCategoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.invCategoryBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.invCategoryBox.FormattingEnabled = True
        Me.invCategoryBox.Items.AddRange(New Object() {"Books", "Materials"})
        Me.invCategoryBox.Location = New System.Drawing.Point(185, 27)
        Me.invCategoryBox.Name = "invCategoryBox"
        Me.invCategoryBox.Size = New System.Drawing.Size(121, 21)
        Me.invCategoryBox.TabIndex = 6
        '
        'addMaterialBtn
        '
        Me.addMaterialBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addMaterialBtn.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addMaterialBtn.Location = New System.Drawing.Point(492, 21)
        Me.addMaterialBtn.Name = "addMaterialBtn"
        Me.addMaterialBtn.Size = New System.Drawing.Size(93, 30)
        Me.addMaterialBtn.TabIndex = 4
        Me.addMaterialBtn.Text = "Add Material"
        Me.addMaterialBtn.UseVisualStyleBackColor = True
        '
        'searchbyBox
        '
        Me.searchbyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.searchbyBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchbyBox.FormattingEnabled = True
        Me.searchbyBox.Items.AddRange(New Object() {"Title", "Author", "Category"})
        Me.searchbyBox.Location = New System.Drawing.Point(12, 80)
        Me.searchbyBox.Name = "searchbyBox"
        Me.searchbyBox.Size = New System.Drawing.Size(121, 21)
        Me.searchbyBox.TabIndex = 7
        '
        'InventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 431)
        Me.Controls.Add(Me.searchbyBox)
        Me.Controls.Add(Me.invCategoryBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.addMaterialBtn)
        Me.Controls.Add(Me.AddBookBtn)
        Me.Controls.Add(Me.SearchBar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "InventoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SearchBar As TextBox
    Friend WithEvents AddBookBtn As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents invCategoryBox As ComboBox
    Friend WithEvents addMaterialBtn As Button
    Friend WithEvents searchbyBox As ComboBox
End Class
