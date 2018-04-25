<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LearnerTimeMan
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LearnerTimeMan))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StudentBox = New System.Windows.Forms.ComboBox()
        Me.TimeBox = New System.Windows.Forms.DateTimePicker()
        Me.DateBox = New System.Windows.Forms.DateTimePicker()
        Me.CommentsBox = New System.Windows.Forms.RichTextBox()
        Me.dgvTimeMan = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PrincipalBox = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.HODbox = New System.Windows.Forms.ComboBox()
        Me.ReasonBox = New System.Windows.Forms.RichTextBox()
        Me.EducatorBox = New System.Windows.Forms.ComboBox()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.FormThemesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CornflowerBlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarkRedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarkVioletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeepSkyBlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HotPinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IvoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightCoralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimeGreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeachToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurpleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SilverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridThemesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefaultToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DodgerBlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightBlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightGreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightPinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrangeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeachToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PinkToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurpleToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VioletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveBtn = New System.Windows.Forms.ToolStripButton()
        Me.ClearBtn = New System.Windows.Forms.ToolStripButton()
        Me.ExitBtn = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvTimeMan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1, Me.SaveBtn, Me.ClearBtn, Me.ExitBtn})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(779, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(170, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(444, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Learner Time Management"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Time of Arrival:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Reason for Latecoming:"
        '
        'StudentBox
        '
        Me.StudentBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StudentBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.StudentBox.FormattingEnabled = True
        Me.StudentBox.Location = New System.Drawing.Point(189, 29)
        Me.StudentBox.Name = "StudentBox"
        Me.StudentBox.Size = New System.Drawing.Size(213, 24)
        Me.StudentBox.Sorted = True
        Me.StudentBox.TabIndex = 10
        '
        'TimeBox
        '
        Me.TimeBox.CustomFormat = "HH:mm"
        Me.TimeBox.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.TimeBox.Location = New System.Drawing.Point(189, 87)
        Me.TimeBox.Name = "TimeBox"
        Me.TimeBox.Size = New System.Drawing.Size(139, 22)
        Me.TimeBox.TabIndex = 11
        '
        'DateBox
        '
        Me.DateBox.CustomFormat = "dd-MM-yyyy"
        Me.DateBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateBox.Location = New System.Drawing.Point(189, 59)
        Me.DateBox.Name = "DateBox"
        Me.DateBox.Size = New System.Drawing.Size(139, 22)
        Me.DateBox.TabIndex = 13
        '
        'CommentsBox
        '
        Me.CommentsBox.Location = New System.Drawing.Point(189, 115)
        Me.CommentsBox.Name = "CommentsBox"
        Me.CommentsBox.Size = New System.Drawing.Size(213, 96)
        Me.CommentsBox.TabIndex = 18
        Me.CommentsBox.Text = ""
        '
        'dgvTimeMan
        '
        Me.dgvTimeMan.BackgroundColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTimeMan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTimeMan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTimeMan.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTimeMan.Location = New System.Drawing.Point(12, 310)
        Me.dgvTimeMan.Name = "dgvTimeMan"
        Me.dgvTimeMan.Size = New System.Drawing.Size(755, 277)
        Me.dgvTimeMan.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.PrincipalBox)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.HODbox)
        Me.GroupBox1.Controls.Add(Me.ReasonBox)
        Me.GroupBox1.Controls.Add(Me.EducatorBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CommentsBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.StudentBox)
        Me.GroupBox1.Controls.Add(Me.TimeBox)
        Me.GroupBox1.Controls.Add(Me.DateBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(755, 229)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(430, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Educator:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(430, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "HOD:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(430, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Principal:"
        '
        'PrincipalBox
        '
        Me.PrincipalBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PrincipalBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PrincipalBox.FormattingEnabled = True
        Me.PrincipalBox.Items.AddRange(New Object() {"Mrs H K Fayers"})
        Me.PrincipalBox.Location = New System.Drawing.Point(520, 89)
        Me.PrincipalBox.Name = "PrincipalBox"
        Me.PrincipalBox.Size = New System.Drawing.Size(209, 24)
        Me.PrincipalBox.Sorted = True
        Me.PrincipalBox.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(430, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 16)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Comments:"
        '
        'HODbox
        '
        Me.HODbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HODbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HODbox.FormattingEnabled = True
        Me.HODbox.Items.AddRange(New Object() {"Mr Ramruthen", "Mrs Moonsamy", "Mrs Phillips"})
        Me.HODbox.Location = New System.Drawing.Point(520, 59)
        Me.HODbox.Name = "HODbox"
        Me.HODbox.Size = New System.Drawing.Size(209, 24)
        Me.HODbox.Sorted = True
        Me.HODbox.TabIndex = 25
        '
        'ReasonBox
        '
        Me.ReasonBox.Location = New System.Drawing.Point(520, 119)
        Me.ReasonBox.Name = "ReasonBox"
        Me.ReasonBox.Size = New System.Drawing.Size(209, 92)
        Me.ReasonBox.TabIndex = 23
        Me.ReasonBox.Text = ""
        '
        'EducatorBox
        '
        Me.EducatorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EducatorBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EducatorBox.FormattingEnabled = True
        Me.EducatorBox.Location = New System.Drawing.Point(520, 29)
        Me.EducatorBox.Name = "EducatorBox"
        Me.EducatorBox.Size = New System.Drawing.Size(209, 24)
        Me.EducatorBox.TabIndex = 24
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormThemesToolStripMenuItem, Me.GridThemesToolStripMenuItem})
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(88, 22)
        Me.ToolStripSplitButton1.Text = "&Themes"
        '
        'FormThemesToolStripMenuItem
        '
        Me.FormThemesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefaultToolStripMenuItem, Me.CornflowerBlueToolStripMenuItem, Me.DarkRedToolStripMenuItem, Me.DarkVioletToolStripMenuItem, Me.DeepSkyBlueToolStripMenuItem, Me.HotPinkToolStripMenuItem, Me.IvoryToolStripMenuItem, Me.LightCoralToolStripMenuItem, Me.LimeGreenToolStripMenuItem, Me.OrangeToolStripMenuItem, Me.PeachToolStripMenuItem, Me.PinkToolStripMenuItem, Me.PurpleToolStripMenuItem, Me.SilverToolStripMenuItem})
        Me.FormThemesToolStripMenuItem.Name = "FormThemesToolStripMenuItem"
        Me.FormThemesToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.FormThemesToolStripMenuItem.Text = "Form Themes"
        '
        'DefaultToolStripMenuItem
        '
        Me.DefaultToolStripMenuItem.Name = "DefaultToolStripMenuItem"
        Me.DefaultToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.DefaultToolStripMenuItem.Text = "Default"
        '
        'CornflowerBlueToolStripMenuItem
        '
        Me.CornflowerBlueToolStripMenuItem.Name = "CornflowerBlueToolStripMenuItem"
        Me.CornflowerBlueToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CornflowerBlueToolStripMenuItem.Text = "Cornflower Blue"
        '
        'DarkRedToolStripMenuItem
        '
        Me.DarkRedToolStripMenuItem.Name = "DarkRedToolStripMenuItem"
        Me.DarkRedToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.DarkRedToolStripMenuItem.Text = "Dark Red"
        '
        'DarkVioletToolStripMenuItem
        '
        Me.DarkVioletToolStripMenuItem.Name = "DarkVioletToolStripMenuItem"
        Me.DarkVioletToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.DarkVioletToolStripMenuItem.Text = "Dark Violet"
        '
        'DeepSkyBlueToolStripMenuItem
        '
        Me.DeepSkyBlueToolStripMenuItem.Name = "DeepSkyBlueToolStripMenuItem"
        Me.DeepSkyBlueToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.DeepSkyBlueToolStripMenuItem.Text = "Deep Sky Blue"
        '
        'HotPinkToolStripMenuItem
        '
        Me.HotPinkToolStripMenuItem.Name = "HotPinkToolStripMenuItem"
        Me.HotPinkToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.HotPinkToolStripMenuItem.Text = "Hot Pink"
        '
        'IvoryToolStripMenuItem
        '
        Me.IvoryToolStripMenuItem.Name = "IvoryToolStripMenuItem"
        Me.IvoryToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.IvoryToolStripMenuItem.Text = "Ivory"
        '
        'LightCoralToolStripMenuItem
        '
        Me.LightCoralToolStripMenuItem.Name = "LightCoralToolStripMenuItem"
        Me.LightCoralToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.LightCoralToolStripMenuItem.Text = "Light Coral"
        '
        'LimeGreenToolStripMenuItem
        '
        Me.LimeGreenToolStripMenuItem.Name = "LimeGreenToolStripMenuItem"
        Me.LimeGreenToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.LimeGreenToolStripMenuItem.Text = "Lime Green"
        '
        'OrangeToolStripMenuItem
        '
        Me.OrangeToolStripMenuItem.Name = "OrangeToolStripMenuItem"
        Me.OrangeToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.OrangeToolStripMenuItem.Text = "Orange"
        '
        'PeachToolStripMenuItem
        '
        Me.PeachToolStripMenuItem.Name = "PeachToolStripMenuItem"
        Me.PeachToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.PeachToolStripMenuItem.Text = "Peach"
        '
        'PinkToolStripMenuItem
        '
        Me.PinkToolStripMenuItem.Name = "PinkToolStripMenuItem"
        Me.PinkToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.PinkToolStripMenuItem.Text = "Pink"
        '
        'PurpleToolStripMenuItem
        '
        Me.PurpleToolStripMenuItem.Name = "PurpleToolStripMenuItem"
        Me.PurpleToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.PurpleToolStripMenuItem.Text = "Purple"
        '
        'SilverToolStripMenuItem
        '
        Me.SilverToolStripMenuItem.Name = "SilverToolStripMenuItem"
        Me.SilverToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.SilverToolStripMenuItem.Text = "Silver"
        '
        'GridThemesToolStripMenuItem
        '
        Me.GridThemesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefaultToolStripMenuItem1, Me.CoralToolStripMenuItem, Me.DodgerBlueToolStripMenuItem, Me.GreyToolStripMenuItem, Me.LightBlueToolStripMenuItem, Me.LightGreenToolStripMenuItem, Me.LightPinkToolStripMenuItem, Me.OrangeToolStripMenuItem1, Me.PeachToolStripMenuItem1, Me.PinkToolStripMenuItem1, Me.PurpleToolStripMenuItem1, Me.RedToolStripMenuItem, Me.VioletToolStripMenuItem, Me.WhiteToolStripMenuItem})
        Me.GridThemesToolStripMenuItem.Name = "GridThemesToolStripMenuItem"
        Me.GridThemesToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.GridThemesToolStripMenuItem.Text = "Grid Themes"
        '
        'DefaultToolStripMenuItem1
        '
        Me.DefaultToolStripMenuItem1.Name = "DefaultToolStripMenuItem1"
        Me.DefaultToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.DefaultToolStripMenuItem1.Text = "Default"
        '
        'CoralToolStripMenuItem
        '
        Me.CoralToolStripMenuItem.Name = "CoralToolStripMenuItem"
        Me.CoralToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.CoralToolStripMenuItem.Text = "Coral"
        '
        'DodgerBlueToolStripMenuItem
        '
        Me.DodgerBlueToolStripMenuItem.Name = "DodgerBlueToolStripMenuItem"
        Me.DodgerBlueToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.DodgerBlueToolStripMenuItem.Text = "Dodger Blue"
        '
        'GreyToolStripMenuItem
        '
        Me.GreyToolStripMenuItem.Name = "GreyToolStripMenuItem"
        Me.GreyToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.GreyToolStripMenuItem.Text = "Grey"
        '
        'LightBlueToolStripMenuItem
        '
        Me.LightBlueToolStripMenuItem.Name = "LightBlueToolStripMenuItem"
        Me.LightBlueToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.LightBlueToolStripMenuItem.Text = "Light Blue"
        '
        'LightGreenToolStripMenuItem
        '
        Me.LightGreenToolStripMenuItem.Name = "LightGreenToolStripMenuItem"
        Me.LightGreenToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.LightGreenToolStripMenuItem.Text = "Light Green"
        '
        'LightPinkToolStripMenuItem
        '
        Me.LightPinkToolStripMenuItem.Name = "LightPinkToolStripMenuItem"
        Me.LightPinkToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.LightPinkToolStripMenuItem.Text = "Light Pink"
        '
        'OrangeToolStripMenuItem1
        '
        Me.OrangeToolStripMenuItem1.Name = "OrangeToolStripMenuItem1"
        Me.OrangeToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.OrangeToolStripMenuItem1.Text = "Orange"
        '
        'PeachToolStripMenuItem1
        '
        Me.PeachToolStripMenuItem1.Name = "PeachToolStripMenuItem1"
        Me.PeachToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.PeachToolStripMenuItem1.Text = "Peach"
        '
        'PinkToolStripMenuItem1
        '
        Me.PinkToolStripMenuItem1.Name = "PinkToolStripMenuItem1"
        Me.PinkToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.PinkToolStripMenuItem1.Text = "Pink"
        '
        'PurpleToolStripMenuItem1
        '
        Me.PurpleToolStripMenuItem1.Name = "PurpleToolStripMenuItem1"
        Me.PurpleToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.PurpleToolStripMenuItem1.Text = "Purple"
        '
        'RedToolStripMenuItem
        '
        Me.RedToolStripMenuItem.Name = "RedToolStripMenuItem"
        Me.RedToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.RedToolStripMenuItem.Text = "Red"
        '
        'VioletToolStripMenuItem
        '
        Me.VioletToolStripMenuItem.Name = "VioletToolStripMenuItem"
        Me.VioletToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.VioletToolStripMenuItem.Text = "Violet"
        '
        'WhiteToolStripMenuItem
        '
        Me.WhiteToolStripMenuItem.Name = "WhiteToolStripMenuItem"
        Me.WhiteToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.WhiteToolStripMenuItem.Text = "White"
        '
        'SaveBtn
        '
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
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SchoolManagement.My.Resources.Resources.Time2
        Me.PictureBox1.Location = New System.Drawing.Point(100, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'LearnerTimeMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(779, 599)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvTimeMan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LearnerTimeMan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Learner Time Management"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvTimeMan, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents StudentBox As ComboBox
    Friend WithEvents TimeBox As DateTimePicker
    Friend WithEvents DateBox As DateTimePicker
    Friend WithEvents CommentsBox As RichTextBox
    Friend WithEvents dgvTimeMan As DataGridView
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents FormThemesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DefaultToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CornflowerBlueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DarkRedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DarkVioletToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeepSkyBlueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HotPinkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IvoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LightCoralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimeGreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrangeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PeachToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PinkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurpleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SilverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GridThemesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DefaultToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CoralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DodgerBlueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GreyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LightBlueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LightGreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LightPinkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrangeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PeachToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PinkToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PurpleToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VioletToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhiteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveBtn As ToolStripButton
    Friend WithEvents ClearBtn As ToolStripButton
    Friend WithEvents ExitBtn As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PrincipalBox As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents HODbox As ComboBox
    Friend WithEvents ReasonBox As RichTextBox
    Friend WithEvents EducatorBox As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
