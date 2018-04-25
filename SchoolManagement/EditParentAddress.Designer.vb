<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditParentAddress
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditParentAddress))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.FirstBtn = New System.Windows.Forms.ToolStripButton()
        Me.PrevBtn = New System.Windows.Forms.ToolStripButton()
        Me.SaveBtn = New System.Windows.Forms.ToolStripButton()
        Me.NextBtn = New System.Windows.Forms.ToolStripButton()
        Me.LastBtn = New System.Windows.Forms.ToolStripButton()
        Me.ExitBtn = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ProvBox = New System.Windows.Forms.TextBox()
        Me.ParentID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PName = New System.Windows.Forms.Label()
        Me.PSurname = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CityBox = New System.Windows.Forms.TextBox()
        Me.SuburbBox = New System.Windows.Forms.TextBox()
        Me.AddressBox = New System.Windows.Forms.TextBox()
        Me.PCodeBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 36)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Edit Parent Details"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FirstBtn, Me.PrevBtn, Me.SaveBtn, Me.NextBtn, Me.LastBtn, Me.ExitBtn})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(379, 25)
        Me.ToolStrip1.TabIndex = 34
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'FirstBtn
        '
        Me.FirstBtn.Image = CType(resources.GetObject("FirstBtn.Image"), System.Drawing.Image)
        Me.FirstBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FirstBtn.Name = "FirstBtn"
        Me.FirstBtn.Size = New System.Drawing.Size(55, 22)
        Me.FirstBtn.Text = "&First"
        '
        'PrevBtn
        '
        Me.PrevBtn.Image = CType(resources.GetObject("PrevBtn.Image"), System.Drawing.Image)
        Me.PrevBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrevBtn.Name = "PrevBtn"
        Me.PrevBtn.Size = New System.Drawing.Size(81, 22)
        Me.PrevBtn.Text = "&Previous"
        '
        'SaveBtn
        '
        Me.SaveBtn.Image = CType(resources.GetObject("SaveBtn.Image"), System.Drawing.Image)
        Me.SaveBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(56, 22)
        Me.SaveBtn.Text = "&Save"
        '
        'NextBtn
        '
        Me.NextBtn.Image = CType(resources.GetObject("NextBtn.Image"), System.Drawing.Image)
        Me.NextBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.Size = New System.Drawing.Size(57, 22)
        Me.NextBtn.Text = "&Next"
        '
        'LastBtn
        '
        Me.LastBtn.Image = CType(resources.GetObject("LastBtn.Image"), System.Drawing.Image)
        Me.LastBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LastBtn.Name = "LastBtn"
        Me.LastBtn.Size = New System.Drawing.Size(53, 22)
        Me.LastBtn.Text = "&Last"
        '
        'ExitBtn
        '
        Me.ExitBtn.Image = CType(resources.GetObject("ExitBtn.Image"), System.Drawing.Image)
        Me.ExitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(51, 22)
        Me.ExitBtn.Text = "E&xit"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.ProvBox)
        Me.GroupBox2.Controls.Add(Me.ParentID)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.PName)
        Me.GroupBox2.Controls.Add(Me.PSurname)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.CityBox)
        Me.GroupBox2.Controls.Add(Me.SuburbBox)
        Me.GroupBox2.Controls.Add(Me.AddressBox)
        Me.GroupBox2.Controls.Add(Me.PCodeBox)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(22, 100)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(337, 272)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Physical Address"
        '
        'ProvBox
        '
        Me.ProvBox.Location = New System.Drawing.Point(109, 200)
        Me.ProvBox.Name = "ProvBox"
        Me.ProvBox.Size = New System.Drawing.Size(215, 22)
        Me.ProvBox.TabIndex = 26
        '
        'ParentID
        '
        Me.ParentID.AutoSize = True
        Me.ParentID.Location = New System.Drawing.Point(106, 31)
        Me.ParentID.Name = "ParentID"
        Me.ParentID.Size = New System.Drawing.Size(16, 16)
        Me.ParentID.TabIndex = 25
        Me.ParentID.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Parent ID:"
        '
        'PName
        '
        Me.PName.AutoSize = True
        Me.PName.Location = New System.Drawing.Point(106, 57)
        Me.PName.Name = "PName"
        Me.PName.Size = New System.Drawing.Size(16, 16)
        Me.PName.TabIndex = 22
        Me.PName.Text = "0"
        '
        'PSurname
        '
        Me.PSurname.AutoSize = True
        Me.PSurname.Location = New System.Drawing.Point(106, 85)
        Me.PSurname.Name = "PSurname"
        Me.PSurname.Size = New System.Drawing.Size(16, 16)
        Me.PSurname.TabIndex = 23
        Me.PSurname.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Surname:"
        '
        'CityBox
        '
        Me.CityBox.Location = New System.Drawing.Point(109, 172)
        Me.CityBox.Name = "CityBox"
        Me.CityBox.Size = New System.Drawing.Size(215, 22)
        Me.CityBox.TabIndex = 19
        '
        'SuburbBox
        '
        Me.SuburbBox.Location = New System.Drawing.Point(109, 144)
        Me.SuburbBox.Name = "SuburbBox"
        Me.SuburbBox.Size = New System.Drawing.Size(215, 22)
        Me.SuburbBox.TabIndex = 18
        '
        'AddressBox
        '
        Me.AddressBox.Location = New System.Drawing.Point(109, 116)
        Me.AddressBox.Name = "AddressBox"
        Me.AddressBox.Size = New System.Drawing.Size(215, 22)
        Me.AddressBox.TabIndex = 17
        '
        'PCodeBox
        '
        Me.PCodeBox.Location = New System.Drawing.Point(109, 228)
        Me.PCodeBox.Name = "PCodeBox"
        Me.PCodeBox.Size = New System.Drawing.Size(215, 22)
        Me.PCodeBox.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Address:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Suburb:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 172)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 16)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "City:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 203)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 16)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Province:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 231)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 16)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Postal Code:"
        '
        'EditParentAddress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumOrchid
        Me.ClientSize = New System.Drawing.Size(379, 391)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(395, 430)
        Me.MinimumSize = New System.Drawing.Size(395, 430)
        Me.Name = "EditParentAddress"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Parent Address"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents FirstBtn As ToolStripButton
    Friend WithEvents PrevBtn As ToolStripButton
    Friend WithEvents SaveBtn As ToolStripButton
    Friend WithEvents NextBtn As ToolStripButton
    Friend WithEvents LastBtn As ToolStripButton
    Friend WithEvents ExitBtn As ToolStripButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CityBox As TextBox
    Friend WithEvents SuburbBox As TextBox
    Friend WithEvents AddressBox As TextBox
    Friend WithEvents PCodeBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PName As Label
    Friend WithEvents PSurname As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ParentID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ProvBox As TextBox
End Class
