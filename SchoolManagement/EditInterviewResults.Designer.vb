<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditInterviewResults
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditInterviewResults))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.FirstBtn = New System.Windows.Forms.ToolStripButton()
        Me.PrevBtn = New System.Windows.Forms.ToolStripButton()
        Me.SaveBtn = New System.Windows.Forms.ToolStripButton()
        Me.NextBtn = New System.Windows.Forms.ToolStripButton()
        Me.LastBtn = New System.Windows.Forms.ToolStripButton()
        Me.ExitBtn = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PNameBox = New System.Windows.Forms.Label()
        Me.PSurnameBox = New System.Windows.Forms.Label()
        Me.ParentID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.InterviewDate = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ResultsBox = New System.Windows.Forms.RichTextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(405, 36)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Edit Interview Results"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FirstBtn, Me.PrevBtn, Me.SaveBtn, Me.NextBtn, Me.LastBtn, Me.ExitBtn})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(574, 25)
        Me.ToolStrip1.TabIndex = 38
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.PNameBox)
        Me.GroupBox1.Controls.Add(Me.PSurnameBox)
        Me.GroupBox1.Controls.Add(Me.ParentID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.InterviewDate)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.ResultsBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(551, 135)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Interview Details"
        '
        'PNameBox
        '
        Me.PNameBox.AutoSize = True
        Me.PNameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PNameBox.Location = New System.Drawing.Point(122, 49)
        Me.PNameBox.Name = "PNameBox"
        Me.PNameBox.Size = New System.Drawing.Size(16, 16)
        Me.PNameBox.TabIndex = 30
        Me.PNameBox.Text = "0"
        '
        'PSurnameBox
        '
        Me.PSurnameBox.AutoSize = True
        Me.PSurnameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PSurnameBox.Location = New System.Drawing.Point(122, 75)
        Me.PSurnameBox.Name = "PSurnameBox"
        Me.PSurnameBox.Size = New System.Drawing.Size(16, 16)
        Me.PSurnameBox.TabIndex = 29
        Me.PSurnameBox.Text = "0"
        '
        'ParentID
        '
        Me.ParentID.AutoSize = True
        Me.ParentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParentID.Location = New System.Drawing.Point(122, 23)
        Me.ParentID.Name = "ParentID"
        Me.ParentID.Size = New System.Drawing.Size(16, 16)
        Me.ParentID.TabIndex = 28
        Me.ParentID.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Parent ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Surname:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Name:"
        '
        'InterviewDate
        '
        Me.InterviewDate.CustomFormat = "yyyy-MM-dd"
        Me.InterviewDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InterviewDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.InterviewDate.Location = New System.Drawing.Point(122, 100)
        Me.InterviewDate.Name = "InterviewDate"
        Me.InterviewDate.Size = New System.Drawing.Size(153, 22)
        Me.InterviewDate.TabIndex = 27
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(6, 105)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(110, 16)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "Interview Date:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(281, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(129, 16)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "Interview Results:"
        '
        'ResultsBox
        '
        Me.ResultsBox.Location = New System.Drawing.Point(416, 22)
        Me.ResultsBox.Name = "ResultsBox"
        Me.ResultsBox.Size = New System.Drawing.Size(129, 99)
        Me.ResultsBox.TabIndex = 25
        Me.ResultsBox.Text = ""
        '
        'EditInterviewResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumOrchid
        Me.ClientSize = New System.Drawing.Size(574, 236)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(590, 275)
        Me.MinimumSize = New System.Drawing.Size(590, 275)
        Me.Name = "EditInterviewResults"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Interview Results"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ParentID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents InterviewDate As DateTimePicker
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents ResultsBox As RichTextBox
    Friend WithEvents PNameBox As Label
    Friend WithEvents PSurnameBox As Label
End Class
