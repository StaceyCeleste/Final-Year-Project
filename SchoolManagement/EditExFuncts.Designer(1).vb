<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditExFuncts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditExFuncts))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.FirstBtn = New System.Windows.Forms.ToolStripButton()
        Me.PrevBtn = New System.Windows.Forms.ToolStripButton()
        Me.SaveBtn = New System.Windows.Forms.ToolStripButton()
        Me.NextBtn = New System.Windows.Forms.ToolStripButton()
        Me.LastBtn = New System.Windows.Forms.ToolStripButton()
        Me.ExitBtn = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FunctID = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TimeBox = New System.Windows.Forms.TextBox()
        Me.DetailsBox = New System.Windows.Forms.RichTextBox()
        Me.DateBox = New System.Windows.Forms.DateTimePicker()
        Me.TypeBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.VenueBox = New System.Windows.Forms.TextBox()
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
        Me.ToolStrip1.Size = New System.Drawing.Size(412, 25)
        Me.ToolStrip1.TabIndex = 32
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
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(402, 36)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Edit External Functions"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.VenueBox)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.FunctID)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TimeBox)
        Me.GroupBox1.Controls.Add(Me.DetailsBox)
        Me.GroupBox1.Controls.Add(Me.DateBox)
        Me.GroupBox1.Controls.Add(Me.TypeBox)
        Me.GroupBox1.Controls.Add(Me.NameBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 318)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Function Details"
        '
        'FunctID
        '
        Me.FunctID.AutoSize = True
        Me.FunctID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FunctID.Cursor = System.Windows.Forms.Cursors.Default
        Me.FunctID.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.FunctID.Location = New System.Drawing.Point(129, 31)
        Me.FunctID.Name = "FunctID"
        Me.FunctID.Size = New System.Drawing.Size(18, 18)
        Me.FunctID.TabIndex = 23
        Me.FunctID.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 16)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "ID:"
        '
        'TimeBox
        '
        Me.TimeBox.Location = New System.Drawing.Point(127, 146)
        Me.TimeBox.Name = "TimeBox"
        Me.TimeBox.Size = New System.Drawing.Size(200, 22)
        Me.TimeBox.TabIndex = 21
        '
        'DetailsBox
        '
        Me.DetailsBox.Location = New System.Drawing.Point(127, 204)
        Me.DetailsBox.Name = "DetailsBox"
        Me.DetailsBox.Size = New System.Drawing.Size(243, 96)
        Me.DetailsBox.TabIndex = 11
        Me.DetailsBox.Text = ""
        '
        'DateBox
        '
        Me.DateBox.CustomFormat = "dd-MM-yyyy"
        Me.DateBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateBox.Location = New System.Drawing.Point(127, 118)
        Me.DateBox.Name = "DateBox"
        Me.DateBox.Size = New System.Drawing.Size(200, 22)
        Me.DateBox.TabIndex = 9
        '
        'TypeBox
        '
        Me.TypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TypeBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TypeBox.FormattingEnabled = True
        Me.TypeBox.Items.AddRange(New Object() {"Children's Party", "Conference", "Convention", "Dinner and Banquets", "End Year Party", "Fair", "Fairwell Party", "Fundraiser", "Gala", "Networking", "Seminars", "Staff Party", "Team Building", "Workshops"})
        Me.TypeBox.Location = New System.Drawing.Point(127, 88)
        Me.TypeBox.Name = "TypeBox"
        Me.TypeBox.Size = New System.Drawing.Size(200, 24)
        Me.TypeBox.Sorted = True
        Me.TypeBox.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Function Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Details:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Function Type:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Venue:"
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(127, 60)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(200, 22)
        Me.NameBox.TabIndex = 7
        '
        'VenueBox
        '
        Me.VenueBox.Location = New System.Drawing.Point(127, 174)
        Me.VenueBox.Name = "VenueBox"
        Me.VenueBox.Size = New System.Drawing.Size(200, 22)
        Me.VenueBox.TabIndex = 25
        '
        'EditExFuncts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(412, 406)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "EditExFuncts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit External Functions"
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
    Friend WithEvents FunctID As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TimeBox As TextBox
    Friend WithEvents DetailsBox As RichTextBox
    Friend WithEvents DateBox As DateTimePicker
    Friend WithEvents TypeBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents VenueBox As TextBox
    Friend WithEvents NameBox As TextBox
End Class
