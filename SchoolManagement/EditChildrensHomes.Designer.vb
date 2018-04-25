<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditChildrensHomes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditChildrensHomes))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.FirstBtn = New System.Windows.Forms.ToolStripButton()
        Me.PrevBtn = New System.Windows.Forms.ToolStripButton()
        Me.SaveBtn = New System.Windows.Forms.ToolStripButton()
        Me.NextBtn = New System.Windows.Forms.ToolStripButton()
        Me.LastBtn = New System.Windows.Forms.ToolStripButton()
        Me.ExitBtn = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TrackBox = New System.Windows.Forms.Label()
        Me.StudentBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HomeAddBox = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.HomeContBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.HomeNameBox = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FirstBtn, Me.PrevBtn, Me.SaveBtn, Me.NextBtn, Me.LastBtn, Me.ExitBtn})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(420, 25)
        Me.ToolStrip1.TabIndex = 26
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 36)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Edit Children's Homes"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TrackBox)
        Me.GroupBox1.Controls.Add(Me.StudentBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.HomeAddBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.HomeContBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.HomeNameBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 238)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Children's Homes Details"
        '
        'TrackBox
        '
        Me.TrackBox.AutoSize = True
        Me.TrackBox.Location = New System.Drawing.Point(182, 34)
        Me.TrackBox.Name = "TrackBox"
        Me.TrackBox.Size = New System.Drawing.Size(16, 16)
        Me.TrackBox.TabIndex = 13
        Me.TrackBox.Text = "0"
        '
        'StudentBox
        '
        Me.StudentBox.Location = New System.Drawing.Point(180, 199)
        Me.StudentBox.Name = "StudentBox"
        Me.StudentBox.Size = New System.Drawing.Size(198, 22)
        Me.StudentBox.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tracking Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Home Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Home Address:"
        '
        'HomeAddBox
        '
        Me.HomeAddBox.Location = New System.Drawing.Point(180, 83)
        Me.HomeAddBox.Name = "HomeAddBox"
        Me.HomeAddBox.Size = New System.Drawing.Size(198, 82)
        Me.HomeAddBox.TabIndex = 11
        Me.HomeAddBox.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Home Contact Details:"
        '
        'HomeContBox
        '
        Me.HomeContBox.Location = New System.Drawing.Point(180, 171)
        Me.HomeContBox.Name = "HomeContBox"
        Me.HomeContBox.Size = New System.Drawing.Size(198, 22)
        Me.HomeContBox.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Student Name:"
        '
        'HomeNameBox
        '
        Me.HomeNameBox.Location = New System.Drawing.Point(180, 57)
        Me.HomeNameBox.Name = "HomeNameBox"
        Me.HomeNameBox.Size = New System.Drawing.Size(198, 22)
        Me.HomeNameBox.TabIndex = 8
        '
        'EditChildrensHomes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(420, 324)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "EditChildrensHomes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Childrens Homes"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents FirstBtn As ToolStripButton
    Friend WithEvents PrevBtn As ToolStripButton
    Friend WithEvents SaveBtn As ToolStripButton
    Friend WithEvents NextBtn As ToolStripButton
    Friend WithEvents LastBtn As ToolStripButton
    Friend WithEvents ExitBtn As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StudentBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents HomeAddBox As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents HomeContBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents HomeNameBox As TextBox
    Friend WithEvents TrackBox As Label
End Class
