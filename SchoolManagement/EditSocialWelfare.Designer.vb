<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditSocialWelfare
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditSocialWelfare))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SaveBtn = New System.Windows.Forms.ToolStripButton()
        Me.ExitBtn = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.EmailBox = New System.Windows.Forms.TextBox()
        Me.PostalBox = New System.Windows.Forms.TextBox()
        Me.PCodeBox = New System.Windows.Forms.TextBox()
        Me.SuburbBox = New System.Windows.Forms.TextBox()
        Me.AddressBox = New System.Windows.Forms.TextBox()
        Me.FaxBox = New System.Windows.Forms.TextBox()
        Me.TelBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SocialID = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveBtn, Me.ExitBtn})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(573, 25)
        Me.ToolStrip1.TabIndex = 24
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'SaveBtn
        '
        Me.SaveBtn.Image = CType(resources.GetObject("SaveBtn.Image"), System.Drawing.Image)
        Me.SaveBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(56, 22)
        Me.SaveBtn.Text = "&Save"
        '
        'ExitBtn
        '
        Me.ExitBtn.Image = CType(resources.GetObject("ExitBtn.Image"), System.Drawing.Image)
        Me.ExitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(51, 22)
        Me.ExitBtn.Text = "E&xit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 36)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Social Welfare Details"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SocialID)
        Me.GroupBox1.Controls.Add(Me.EmailBox)
        Me.GroupBox1.Controls.Add(Me.PostalBox)
        Me.GroupBox1.Controls.Add(Me.PCodeBox)
        Me.GroupBox1.Controls.Add(Me.SuburbBox)
        Me.GroupBox1.Controls.Add(Me.AddressBox)
        Me.GroupBox1.Controls.Add(Me.FaxBox)
        Me.GroupBox1.Controls.Add(Me.TelBox)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(548, 320)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'EmailBox
        '
        Me.EmailBox.Location = New System.Drawing.Point(130, 280)
        Me.EmailBox.Name = "EmailBox"
        Me.EmailBox.Size = New System.Drawing.Size(377, 22)
        Me.EmailBox.TabIndex = 15
        '
        'PostalBox
        '
        Me.PostalBox.Location = New System.Drawing.Point(130, 244)
        Me.PostalBox.Name = "PostalBox"
        Me.PostalBox.Size = New System.Drawing.Size(377, 22)
        Me.PostalBox.TabIndex = 14
        '
        'PCodeBox
        '
        Me.PCodeBox.Location = New System.Drawing.Point(130, 209)
        Me.PCodeBox.Name = "PCodeBox"
        Me.PCodeBox.Size = New System.Drawing.Size(377, 22)
        Me.PCodeBox.TabIndex = 13
        '
        'SuburbBox
        '
        Me.SuburbBox.Location = New System.Drawing.Point(130, 173)
        Me.SuburbBox.Name = "SuburbBox"
        Me.SuburbBox.Size = New System.Drawing.Size(377, 22)
        Me.SuburbBox.TabIndex = 12
        '
        'AddressBox
        '
        Me.AddressBox.Location = New System.Drawing.Point(130, 133)
        Me.AddressBox.Name = "AddressBox"
        Me.AddressBox.Size = New System.Drawing.Size(377, 22)
        Me.AddressBox.TabIndex = 11
        '
        'FaxBox
        '
        Me.FaxBox.Location = New System.Drawing.Point(130, 98)
        Me.FaxBox.Name = "FaxBox"
        Me.FaxBox.Size = New System.Drawing.Size(377, 22)
        Me.FaxBox.TabIndex = 10
        '
        'TelBox
        '
        Me.TelBox.Location = New System.Drawing.Point(130, 62)
        Me.TelBox.Name = "TelBox"
        Me.TelBox.Size = New System.Drawing.Size(377, 22)
        Me.TelBox.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 283)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 16)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Email:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 247)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Postal Address:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Postal Code:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Suburb:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Fax Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Telephone:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID:"
        '
        'SocialID
        '
        Me.SocialID.AutoSize = True
        Me.SocialID.Location = New System.Drawing.Point(131, 28)
        Me.SocialID.Name = "SocialID"
        Me.SocialID.Size = New System.Drawing.Size(16, 16)
        Me.SocialID.TabIndex = 16
        Me.SocialID.Text = "0"
        '
        'EditSocialWelfare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Plum
        Me.ClientSize = New System.Drawing.Size(573, 407)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "EditSocialWelfare"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Social Welfare"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents SaveBtn As ToolStripButton
    Friend WithEvents ExitBtn As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents EmailBox As TextBox
    Friend WithEvents PostalBox As TextBox
    Friend WithEvents PCodeBox As TextBox
    Friend WithEvents SuburbBox As TextBox
    Friend WithEvents AddressBox As TextBox
    Friend WithEvents FaxBox As TextBox
    Friend WithEvents TelBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SocialID As Label
End Class
