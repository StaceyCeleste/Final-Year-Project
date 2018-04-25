<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditStaffDets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditStaffDets))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.FirstBtn = New System.Windows.Forms.ToolStripButton()
        Me.PrevBtn = New System.Windows.Forms.ToolStripButton()
        Me.SaveBtn = New System.Windows.Forms.ToolStripButton()
        Me.NextBtn = New System.Windows.Forms.ToolStripButton()
        Me.LastBtn = New System.Windows.Forms.ToolStripButton()
        Me.ExitBtn = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PersalNum = New System.Windows.Forms.Label()
        Me.HireDate = New System.Windows.Forms.DateTimePicker()
        Me.Bdate = New System.Windows.Forms.DateTimePicker()
        Me.StaffSurname = New System.Windows.Forms.TextBox()
        Me.StaffSecName = New System.Windows.Forms.TextBox()
        Me.StaffName = New System.Windows.Forms.TextBox()
        Me.StaffInitials = New System.Windows.Forms.TextBox()
        Me.FemaleBtn = New System.Windows.Forms.RadioButton()
        Me.MaleBtn = New System.Windows.Forms.RadioButton()
        Me.IDNum = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EthnicBox = New System.Windows.Forms.TextBox()
        Me.OccupationBox = New System.Windows.Forms.TextBox()
        Me.PhaseBox = New System.Windows.Forms.TextBox()
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
        Me.ToolStrip1.Size = New System.Drawing.Size(389, 25)
        Me.ToolStrip1.TabIndex = 25
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
        Me.GroupBox1.Controls.Add(Me.PhaseBox)
        Me.GroupBox1.Controls.Add(Me.OccupationBox)
        Me.GroupBox1.Controls.Add(Me.EthnicBox)
        Me.GroupBox1.Controls.Add(Me.PersalNum)
        Me.GroupBox1.Controls.Add(Me.HireDate)
        Me.GroupBox1.Controls.Add(Me.Bdate)
        Me.GroupBox1.Controls.Add(Me.StaffSurname)
        Me.GroupBox1.Controls.Add(Me.StaffSecName)
        Me.GroupBox1.Controls.Add(Me.StaffName)
        Me.GroupBox1.Controls.Add(Me.StaffInitials)
        Me.GroupBox1.Controls.Add(Me.FemaleBtn)
        Me.GroupBox1.Controls.Add(Me.MaleBtn)
        Me.GroupBox1.Controls.Add(Me.IDNum)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 386)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Details"
        '
        'PersalNum
        '
        Me.PersalNum.AutoSize = True
        Me.PersalNum.Location = New System.Drawing.Point(129, 36)
        Me.PersalNum.Name = "PersalNum"
        Me.PersalNum.Size = New System.Drawing.Size(16, 16)
        Me.PersalNum.TabIndex = 25
        Me.PersalNum.Text = "0"
        '
        'HireDate
        '
        Me.HireDate.CustomFormat = "yyyy-MM-dd"
        Me.HireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.HireDate.Location = New System.Drawing.Point(127, 285)
        Me.HireDate.Name = "HireDate"
        Me.HireDate.Size = New System.Drawing.Size(201, 22)
        Me.HireDate.TabIndex = 24
        '
        'Bdate
        '
        Me.Bdate.CustomFormat = "yyyy-MM-dd"
        Me.Bdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Bdate.Location = New System.Drawing.Point(127, 257)
        Me.Bdate.Name = "Bdate"
        Me.Bdate.Size = New System.Drawing.Size(201, 22)
        Me.Bdate.TabIndex = 21
        '
        'StaffSurname
        '
        Me.StaffSurname.Location = New System.Drawing.Point(127, 199)
        Me.StaffSurname.Name = "StaffSurname"
        Me.StaffSurname.Size = New System.Drawing.Size(201, 22)
        Me.StaffSurname.TabIndex = 19
        '
        'StaffSecName
        '
        Me.StaffSecName.Location = New System.Drawing.Point(127, 171)
        Me.StaffSecName.Name = "StaffSecName"
        Me.StaffSecName.Size = New System.Drawing.Size(201, 22)
        Me.StaffSecName.TabIndex = 18
        '
        'StaffName
        '
        Me.StaffName.Location = New System.Drawing.Point(127, 143)
        Me.StaffName.Name = "StaffName"
        Me.StaffName.Size = New System.Drawing.Size(201, 22)
        Me.StaffName.TabIndex = 17
        '
        'StaffInitials
        '
        Me.StaffInitials.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.StaffInitials.Location = New System.Drawing.Point(127, 115)
        Me.StaffInitials.Name = "StaffInitials"
        Me.StaffInitials.Size = New System.Drawing.Size(60, 22)
        Me.StaffInitials.TabIndex = 16
        '
        'FemaleBtn
        '
        Me.FemaleBtn.AutoSize = True
        Me.FemaleBtn.Location = New System.Drawing.Point(193, 89)
        Me.FemaleBtn.Name = "FemaleBtn"
        Me.FemaleBtn.Size = New System.Drawing.Size(78, 20)
        Me.FemaleBtn.TabIndex = 15
        Me.FemaleBtn.TabStop = True
        Me.FemaleBtn.Text = "Female"
        Me.FemaleBtn.UseVisualStyleBackColor = True
        '
        'MaleBtn
        '
        Me.MaleBtn.AutoSize = True
        Me.MaleBtn.Location = New System.Drawing.Point(127, 89)
        Me.MaleBtn.Name = "MaleBtn"
        Me.MaleBtn.Size = New System.Drawing.Size(60, 20)
        Me.MaleBtn.TabIndex = 14
        Me.MaleBtn.TabStop = True
        Me.MaleBtn.Text = "Male"
        Me.MaleBtn.UseVisualStyleBackColor = True
        '
        'IDNum
        '
        Me.IDNum.Location = New System.Drawing.Point(127, 61)
        Me.IDNum.Name = "IDNum"
        Me.IDNum.Size = New System.Drawing.Size(201, 22)
        Me.IDNum.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 346)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 16)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Phase:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 316)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 16)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Occupation:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 290)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 16)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Hire Date:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 262)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Birth Date:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 16)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Ethnicity:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Surname:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Second Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "First Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Initials:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Gender:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ID Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Persal Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 36)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Edit Staff Details"
        '
        'EthnicBox
        '
        Me.EthnicBox.Location = New System.Drawing.Point(127, 227)
        Me.EthnicBox.Name = "EthnicBox"
        Me.EthnicBox.Size = New System.Drawing.Size(201, 22)
        Me.EthnicBox.TabIndex = 26
        '
        'OccupationBox
        '
        Me.OccupationBox.Location = New System.Drawing.Point(127, 313)
        Me.OccupationBox.Name = "OccupationBox"
        Me.OccupationBox.Size = New System.Drawing.Size(201, 22)
        Me.OccupationBox.TabIndex = 27
        '
        'PhaseBox
        '
        Me.PhaseBox.Location = New System.Drawing.Point(127, 341)
        Me.PhaseBox.Name = "PhaseBox"
        Me.PhaseBox.Size = New System.Drawing.Size(201, 22)
        Me.PhaseBox.TabIndex = 28
        '
        'EditStaffDets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(389, 478)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(405, 517)
        Me.MinimumSize = New System.Drawing.Size(405, 517)
        Me.Name = "EditStaffDets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Staff Details"
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents HireDate As DateTimePicker
    Friend WithEvents Bdate As DateTimePicker
    Friend WithEvents StaffSurname As TextBox
    Friend WithEvents StaffSecName As TextBox
    Friend WithEvents StaffName As TextBox
    Friend WithEvents StaffInitials As TextBox
    Friend WithEvents FemaleBtn As RadioButton
    Friend WithEvents MaleBtn As RadioButton
    Friend WithEvents IDNum As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PersalNum As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents EthnicBox As TextBox
    Friend WithEvents OccupationBox As TextBox
    Friend WithEvents PhaseBox As TextBox
End Class
