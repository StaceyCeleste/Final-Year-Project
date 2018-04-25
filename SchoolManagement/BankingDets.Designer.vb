<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BankingDets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BankingDets))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IDBox = New System.Windows.Forms.Label()
        Me.NumberBox = New System.Windows.Forms.Label()
        Me.BranchBox = New System.Windows.Forms.Label()
        Me.BankBox = New System.Windows.Forms.Label()
        Me.AccountBox = New System.Windows.Forms.Label()
        Me.PrintBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 36)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Banking Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Bank:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Account Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Branch:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "BranchNumber"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.IDBox)
        Me.GroupBox1.Controls.Add(Me.NumberBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.BranchBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.BankBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.AccountBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(465, 187)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Banking Details"
        '
        'IDBox
        '
        Me.IDBox.AutoSize = True
        Me.IDBox.Location = New System.Drawing.Point(137, 30)
        Me.IDBox.Name = "IDBox"
        Me.IDBox.Size = New System.Drawing.Size(16, 16)
        Me.IDBox.TabIndex = 11
        Me.IDBox.Text = "0"
        '
        'NumberBox
        '
        Me.NumberBox.AutoSize = True
        Me.NumberBox.Location = New System.Drawing.Point(137, 155)
        Me.NumberBox.Name = "NumberBox"
        Me.NumberBox.Size = New System.Drawing.Size(16, 16)
        Me.NumberBox.TabIndex = 15
        Me.NumberBox.Text = "0"
        '
        'BranchBox
        '
        Me.BranchBox.AutoSize = True
        Me.BranchBox.Location = New System.Drawing.Point(137, 121)
        Me.BranchBox.Name = "BranchBox"
        Me.BranchBox.Size = New System.Drawing.Size(16, 16)
        Me.BranchBox.TabIndex = 14
        Me.BranchBox.Text = "0"
        '
        'BankBox
        '
        Me.BankBox.AutoSize = True
        Me.BankBox.Location = New System.Drawing.Point(137, 60)
        Me.BankBox.Name = "BankBox"
        Me.BankBox.Size = New System.Drawing.Size(16, 16)
        Me.BankBox.TabIndex = 12
        Me.BankBox.Text = "0"
        '
        'AccountBox
        '
        Me.AccountBox.AutoSize = True
        Me.AccountBox.Location = New System.Drawing.Point(137, 90)
        Me.AccountBox.Name = "AccountBox"
        Me.AccountBox.Size = New System.Drawing.Size(16, 16)
        Me.AccountBox.TabIndex = 13
        Me.AccountBox.Text = "0"
        '
        'PrintBtn
        '
        Me.PrintBtn.Location = New System.Drawing.Point(321, 256)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(75, 23)
        Me.PrintBtn.TabIndex = 12
        Me.PrintBtn.Text = "&Print"
        Me.PrintBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(402, 256)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(75, 23)
        Me.ExitBtn.TabIndex = 13
        Me.ExitBtn.Text = "E&xit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'BankingDets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(489, 291)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.PrintBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(505, 330)
        Me.MinimumSize = New System.Drawing.Size(505, 330)
        Me.Name = "BankingDets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Banking Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents IDBox As Label
    Friend WithEvents NumberBox As Label
    Friend WithEvents BranchBox As Label
    Friend WithEvents BankBox As Label
    Friend WithEvents AccountBox As Label
    Friend WithEvents PrintBtn As Button
    Friend WithEvents ExitBtn As Button
End Class
