<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NutritionDets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NutritionDets))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ThemesBtn = New System.Windows.Forms.ToolStripSplitButton()
        Me.FormThemesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefaultToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrangesAndLemonsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StrawberriesAndBlueberriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrapesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridThemesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimeGreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrangeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeachToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveBtn = New System.Windows.Forms.ToolStripButton()
        Me.ClearBtn = New System.Windows.Forms.ToolStripButton()
        Me.ExitBtn = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TrackBox = New System.Windows.Forms.TextBox()
        Me.RestrictBox = New System.Windows.Forms.TextBox()
        Me.AllergiesBox = New System.Windows.Forms.TextBox()
        Me.CommentsBox = New System.Windows.Forms.RichTextBox()
        Me.YesBtn = New System.Windows.Forms.RadioButton()
        Me.NoBtn = New System.Windows.Forms.RadioButton()
        Me.dgvNutrition = New System.Windows.Forms.DataGridView()
        Me.StudentNameCombo = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EditBtn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvNutrition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThemesBtn, Me.EditBtn, Me.SaveBtn, Me.ClearBtn, Me.ExitBtn})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(751, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ThemesBtn
        '
        Me.ThemesBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormThemesToolStripMenuItem, Me.GridThemesToolStripMenuItem})
        Me.ThemesBtn.Image = CType(resources.GetObject("ThemesBtn.Image"), System.Drawing.Image)
        Me.ThemesBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ThemesBtn.Name = "ThemesBtn"
        Me.ThemesBtn.Size = New System.Drawing.Size(88, 22)
        Me.ThemesBtn.Text = "&Themes"
        '
        'FormThemesToolStripMenuItem
        '
        Me.FormThemesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefaultToolStripMenuItem1, Me.OrangesAndLemonsToolStripMenuItem, Me.StrawberriesAndBlueberriesToolStripMenuItem, Me.GrapesToolStripMenuItem, Me.OrangeToolStripMenuItem})
        Me.FormThemesToolStripMenuItem.Name = "FormThemesToolStripMenuItem"
        Me.FormThemesToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.FormThemesToolStripMenuItem.Text = "Form Themes"
        '
        'DefaultToolStripMenuItem1
        '
        Me.DefaultToolStripMenuItem1.Name = "DefaultToolStripMenuItem1"
        Me.DefaultToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.DefaultToolStripMenuItem1.Text = "Default"
        '
        'OrangesAndLemonsToolStripMenuItem
        '
        Me.OrangesAndLemonsToolStripMenuItem.Name = "OrangesAndLemonsToolStripMenuItem"
        Me.OrangesAndLemonsToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.OrangesAndLemonsToolStripMenuItem.Text = "Beige"
        '
        'StrawberriesAndBlueberriesToolStripMenuItem
        '
        Me.StrawberriesAndBlueberriesToolStripMenuItem.Name = "StrawberriesAndBlueberriesToolStripMenuItem"
        Me.StrawberriesAndBlueberriesToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.StrawberriesAndBlueberriesToolStripMenuItem.Text = "Blue Green"
        '
        'GrapesToolStripMenuItem
        '
        Me.GrapesToolStripMenuItem.Name = "GrapesToolStripMenuItem"
        Me.GrapesToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.GrapesToolStripMenuItem.Text = "Green"
        '
        'OrangeToolStripMenuItem
        '
        Me.OrangeToolStripMenuItem.Name = "OrangeToolStripMenuItem"
        Me.OrangeToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.OrangeToolStripMenuItem.Text = "Orange"
        '
        'GridThemesToolStripMenuItem
        '
        Me.GridThemesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefaultToolStripMenuItem, Me.GreenToolStripMenuItem, Me.LimeGreenToolStripMenuItem, Me.OrangeToolStripMenuItem1, Me.PeachToolStripMenuItem})
        Me.GridThemesToolStripMenuItem.Name = "GridThemesToolStripMenuItem"
        Me.GridThemesToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.GridThemesToolStripMenuItem.Text = "Grid Themes"
        '
        'DefaultToolStripMenuItem
        '
        Me.DefaultToolStripMenuItem.Name = "DefaultToolStripMenuItem"
        Me.DefaultToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.DefaultToolStripMenuItem.Text = "Default"
        '
        'GreenToolStripMenuItem
        '
        Me.GreenToolStripMenuItem.Name = "GreenToolStripMenuItem"
        Me.GreenToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.GreenToolStripMenuItem.Text = "Green"
        '
        'LimeGreenToolStripMenuItem
        '
        Me.LimeGreenToolStripMenuItem.Name = "LimeGreenToolStripMenuItem"
        Me.LimeGreenToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.LimeGreenToolStripMenuItem.Text = "Lime Green"
        '
        'OrangeToolStripMenuItem1
        '
        Me.OrangeToolStripMenuItem1.Name = "OrangeToolStripMenuItem1"
        Me.OrangeToolStripMenuItem1.Size = New System.Drawing.Size(146, 22)
        Me.OrangeToolStripMenuItem1.Text = "Orange"
        '
        'PeachToolStripMenuItem
        '
        Me.PeachToolStripMenuItem.Name = "PeachToolStripMenuItem"
        Me.PeachToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.PeachToolStripMenuItem.Text = "Peach"
        '
        'SaveBtn
        '
        Me.SaveBtn.Enabled = False
        Me.SaveBtn.Image = CType(resources.GetObject("SaveBtn.Image"), System.Drawing.Image)
        Me.SaveBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(56, 22)
        Me.SaveBtn.Text = "&Save"
        '
        'ClearBtn
        '
        Me.ClearBtn.Image = CType(resources.GetObject("ClearBtn.Image"), System.Drawing.Image)
        Me.ClearBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(59, 22)
        Me.ClearBtn.Text = "&Clear"
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
        Me.Label1.Location = New System.Drawing.Point(248, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nutrition Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tracking Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Student Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Restrictions:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Food Allergies:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(358, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Parental Consent:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(358, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Comments:"
        '
        'TrackBox
        '
        Me.TrackBox.Location = New System.Drawing.Point(146, 24)
        Me.TrackBox.Name = "TrackBox"
        Me.TrackBox.Size = New System.Drawing.Size(201, 22)
        Me.TrackBox.TabIndex = 9
        '
        'RestrictBox
        '
        Me.RestrictBox.Location = New System.Drawing.Point(146, 77)
        Me.RestrictBox.Name = "RestrictBox"
        Me.RestrictBox.Size = New System.Drawing.Size(201, 22)
        Me.RestrictBox.TabIndex = 12
        '
        'AllergiesBox
        '
        Me.AllergiesBox.Location = New System.Drawing.Point(146, 103)
        Me.AllergiesBox.Name = "AllergiesBox"
        Me.AllergiesBox.Size = New System.Drawing.Size(201, 22)
        Me.AllergiesBox.TabIndex = 13
        '
        'CommentsBox
        '
        Me.CommentsBox.Location = New System.Drawing.Point(494, 49)
        Me.CommentsBox.Name = "CommentsBox"
        Me.CommentsBox.Size = New System.Drawing.Size(227, 74)
        Me.CommentsBox.TabIndex = 14
        Me.CommentsBox.Text = ""
        '
        'YesBtn
        '
        Me.YesBtn.AutoSize = True
        Me.YesBtn.BackColor = System.Drawing.Color.Transparent
        Me.YesBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YesBtn.Location = New System.Drawing.Point(494, 23)
        Me.YesBtn.Name = "YesBtn"
        Me.YesBtn.Size = New System.Drawing.Size(53, 20)
        Me.YesBtn.TabIndex = 15
        Me.YesBtn.TabStop = True
        Me.YesBtn.Text = "Yes"
        Me.YesBtn.UseVisualStyleBackColor = False
        '
        'NoBtn
        '
        Me.NoBtn.AutoSize = True
        Me.NoBtn.BackColor = System.Drawing.Color.Transparent
        Me.NoBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoBtn.Location = New System.Drawing.Point(553, 23)
        Me.NoBtn.Name = "NoBtn"
        Me.NoBtn.Size = New System.Drawing.Size(46, 20)
        Me.NoBtn.TabIndex = 16
        Me.NoBtn.TabStop = True
        Me.NoBtn.Text = "No"
        Me.NoBtn.UseVisualStyleBackColor = False
        '
        'dgvNutrition
        '
        Me.dgvNutrition.AllowUserToAddRows = False
        Me.dgvNutrition.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgvNutrition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNutrition.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvNutrition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvNutrition.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvNutrition.Location = New System.Drawing.Point(12, 243)
        Me.dgvNutrition.Name = "dgvNutrition"
        Me.dgvNutrition.Size = New System.Drawing.Size(727, 360)
        Me.dgvNutrition.TabIndex = 17
        '
        'StudentNameCombo
        '
        Me.StudentNameCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StudentNameCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.StudentNameCombo.FormattingEnabled = True
        Me.StudentNameCombo.Location = New System.Drawing.Point(146, 50)
        Me.StudentNameCombo.Name = "StudentNameCombo"
        Me.StudentNameCombo.Size = New System.Drawing.Size(201, 24)
        Me.StudentNameCombo.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.StudentNameCombo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.NoBtn)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.YesBtn)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.CommentsBox)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.AllergiesBox)
        Me.GroupBox1.Controls.Add(Me.TrackBox)
        Me.GroupBox1.Controls.Add(Me.RestrictBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(727, 140)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nutrition Details"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SchoolManagement.My.Resources.Resources.Nutrition1
        Me.PictureBox1.Location = New System.Drawing.Point(148, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'EditBtn
        '
        Me.EditBtn.Image = CType(resources.GetObject("EditBtn.Image"), System.Drawing.Image)
        Me.EditBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(52, 22)
        Me.EditBtn.Text = "&Edit"
        '
        'NutritionDets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(751, 615)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvNutrition)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NutritionDets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nutrition Details"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvNutrition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TrackBox As TextBox
    Friend WithEvents RestrictBox As TextBox
    Friend WithEvents AllergiesBox As TextBox
    Friend WithEvents CommentsBox As RichTextBox
    Friend WithEvents YesBtn As RadioButton
    Friend WithEvents NoBtn As RadioButton
    Friend WithEvents dgvNutrition As DataGridView
    Friend WithEvents ThemesBtn As ToolStripSplitButton
    Friend WithEvents FormThemesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GrapesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrangeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrangesAndLemonsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StrawberriesAndBlueberriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveBtn As ToolStripButton
    Friend WithEvents ClearBtn As ToolStripButton
    Friend WithEvents ExitBtn As ToolStripButton
    Friend WithEvents DefaultToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GridThemesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DefaultToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrangeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PeachToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimeGreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentNameCombo As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents EditBtn As ToolStripButton
End Class
