<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PoliceDets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PoliceDets))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PostalBox = New System.Windows.Forms.Label()
        Me.PcodeBox = New System.Windows.Forms.Label()
        Me.SuburbBox = New System.Windows.Forms.Label()
        Me.EmailBox = New System.Windows.Forms.Label()
        Me.AddressBox = New System.Windows.Forms.Label()
        Me.FaxBox = New System.Windows.Forms.Label()
        Me.TelBox = New System.Windows.Forms.Label()
        Me.PoliceID = New System.Windows.Forms.Label()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(163, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Police Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telephone:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fax:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Address:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Suburb:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Postal Code:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 236)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Postal Address:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 269)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Email:"
        '
        'PostalBox
        '
        Me.PostalBox.AutoSize = True
        Me.PostalBox.Location = New System.Drawing.Point(130, 236)
        Me.PostalBox.Name = "PostalBox"
        Me.PostalBox.Size = New System.Drawing.Size(16, 16)
        Me.PostalBox.TabIndex = 9
        Me.PostalBox.Text = "0"
        '
        'PcodeBox
        '
        Me.PcodeBox.AutoSize = True
        Me.PcodeBox.Location = New System.Drawing.Point(130, 202)
        Me.PcodeBox.Name = "PcodeBox"
        Me.PcodeBox.Size = New System.Drawing.Size(16, 16)
        Me.PcodeBox.TabIndex = 10
        Me.PcodeBox.Text = "0"
        '
        'SuburbBox
        '
        Me.SuburbBox.AutoSize = True
        Me.SuburbBox.Location = New System.Drawing.Point(130, 169)
        Me.SuburbBox.Name = "SuburbBox"
        Me.SuburbBox.Size = New System.Drawing.Size(16, 16)
        Me.SuburbBox.TabIndex = 11
        Me.SuburbBox.Text = "0"
        '
        'EmailBox
        '
        Me.EmailBox.AutoSize = True
        Me.EmailBox.Location = New System.Drawing.Point(130, 269)
        Me.EmailBox.Name = "EmailBox"
        Me.EmailBox.Size = New System.Drawing.Size(16, 16)
        Me.EmailBox.TabIndex = 12
        Me.EmailBox.Text = "0"
        '
        'AddressBox
        '
        Me.AddressBox.AutoSize = True
        Me.AddressBox.Location = New System.Drawing.Point(130, 135)
        Me.AddressBox.Name = "AddressBox"
        Me.AddressBox.Size = New System.Drawing.Size(16, 16)
        Me.AddressBox.TabIndex = 13
        Me.AddressBox.Text = "0"
        '
        'FaxBox
        '
        Me.FaxBox.AutoSize = True
        Me.FaxBox.Location = New System.Drawing.Point(130, 101)
        Me.FaxBox.Name = "FaxBox"
        Me.FaxBox.Size = New System.Drawing.Size(16, 16)
        Me.FaxBox.TabIndex = 14
        Me.FaxBox.Text = "0"
        '
        'TelBox
        '
        Me.TelBox.AutoSize = True
        Me.TelBox.Location = New System.Drawing.Point(130, 66)
        Me.TelBox.Name = "TelBox"
        Me.TelBox.Size = New System.Drawing.Size(16, 16)
        Me.TelBox.TabIndex = 15
        Me.TelBox.Text = "0"
        '
        'PoliceID
        '
        Me.PoliceID.AutoSize = True
        Me.PoliceID.Location = New System.Drawing.Point(130, 32)
        Me.PoliceID.Name = "PoliceID"
        Me.PoliceID.Size = New System.Drawing.Size(16, 16)
        Me.PoliceID.TabIndex = 16
        Me.PoliceID.Text = "0"
        '
        'EditBtn
        '
        Me.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.EditBtn.Location = New System.Drawing.Point(293, 384)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(75, 23)
        Me.EditBtn.TabIndex = 17
        Me.EditBtn.Text = "&Edit"
        Me.EditBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ExitBtn.Location = New System.Drawing.Point(374, 384)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(75, 23)
        Me.ExitBtn.TabIndex = 18
        Me.ExitBtn.Text = "E&xit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PoliceID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TelBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.FaxBox)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.AddressBox)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.EmailBox)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.SuburbBox)
        Me.GroupBox1.Controls.Add(Me.PostalBox)
        Me.GroupBox1.Controls.Add(Me.PcodeBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(437, 298)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SchoolManagement.My.Resources.Resources.Police1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.SchoolManagement.My.Resources.Resources.Police2
        Me.PictureBox2.Location = New System.Drawing.Point(83, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(65, 69)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'PoliceDets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Plum
        Me.ClientSize = New System.Drawing.Size(461, 419)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EditBtn)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(477, 458)
        Me.MinimumSize = New System.Drawing.Size(477, 458)
        Me.Name = "PoliceDets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Police Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PostalBox As Label
    Friend WithEvents PcodeBox As Label
    Friend WithEvents SuburbBox As Label
    Friend WithEvents EmailBox As Label
    Friend WithEvents AddressBox As Label
    Friend WithEvents FaxBox As Label
    Friend WithEvents TelBox As Label
    Friend WithEvents PoliceID As Label
    Friend WithEvents EditBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
