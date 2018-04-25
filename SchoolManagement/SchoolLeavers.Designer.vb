<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SchoolLeavers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SchoolLeavers))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
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
        Me.LightGreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.LightGreenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightPinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrangeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeachToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PinkToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurpleToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VioletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Save = New System.Windows.Forms.ToolStripButton()
        Me.ClearAll = New System.Windows.Forms.ToolStripButton()
        Me.ExitForm = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ExitDate = New System.Windows.Forms.DateTimePicker()
        Me.TrackBox = New System.Windows.Forms.TextBox()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.SurnameBox = New System.Windows.Forms.TextBox()
        Me.ExitBox = New System.Windows.Forms.RichTextBox()
        Me.dgvLeavers = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.EditBtn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvLeavers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(171, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "School Leavers"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1, Me.EditBtn, Me.Save, Me.ClearAll, Me.ExitForm})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(579, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
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
        Me.FormThemesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefaultToolStripMenuItem, Me.CornflowerBlueToolStripMenuItem, Me.DarkRedToolStripMenuItem, Me.DarkVioletToolStripMenuItem, Me.DeepSkyBlueToolStripMenuItem, Me.HotPinkToolStripMenuItem, Me.IvoryToolStripMenuItem, Me.LightCoralToolStripMenuItem, Me.LightGreenToolStripMenuItem, Me.OrangeToolStripMenuItem, Me.PeachToolStripMenuItem, Me.PinkToolStripMenuItem, Me.PurpleToolStripMenuItem, Me.SilverToolStripMenuItem})
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
        'LightGreenToolStripMenuItem
        '
        Me.LightGreenToolStripMenuItem.Name = "LightGreenToolStripMenuItem"
        Me.LightGreenToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.LightGreenToolStripMenuItem.Text = "Light Green"
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
        Me.GridThemesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefaultToolStripMenuItem1, Me.CoralToolStripMenuItem, Me.DodgerBlueToolStripMenuItem, Me.GreyToolStripMenuItem, Me.LightBlueToolStripMenuItem, Me.LightGreenToolStripMenuItem1, Me.LightPinkToolStripMenuItem, Me.OrangeToolStripMenuItem1, Me.PeachToolStripMenuItem1, Me.PinkToolStripMenuItem1, Me.PurpleToolStripMenuItem1, Me.RedToolStripMenuItem, Me.VioletToolStripMenuItem, Me.WhiteToolStripMenuItem})
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
        'LightGreenToolStripMenuItem1
        '
        Me.LightGreenToolStripMenuItem1.Name = "LightGreenToolStripMenuItem1"
        Me.LightGreenToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.LightGreenToolStripMenuItem1.Text = "Light Green"
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
        'Save
        '
        Me.Save.Enabled = False
        Me.Save.Image = CType(resources.GetObject("Save.Image"), System.Drawing.Image)
        Me.Save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(56, 22)
        Me.Save.Text = "&Save"
        '
        'ClearAll
        '
        Me.ClearAll.Image = CType(resources.GetObject("ClearAll.Image"), System.Drawing.Image)
        Me.ClearAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearAll.Name = "ClearAll"
        Me.ClearAll.Size = New System.Drawing.Size(59, 22)
        Me.ClearAll.Text = "&Clear"
        '
        'ExitForm
        '
        Me.ExitForm.Image = CType(resources.GetObject("ExitForm.Image"), System.Drawing.Image)
        Me.ExitForm.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExitForm.Name = "ExitForm"
        Me.ExitForm.Size = New System.Drawing.Size(51, 22)
        Me.ExitForm.Text = "E&xit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tracking Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Date of Exit:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Student Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Surname:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Reason for Exit:"
        '
        'ExitDate
        '
        Me.ExitDate.CustomFormat = "yyyy-MM-dd"
        Me.ExitDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ExitDate.Location = New System.Drawing.Point(156, 43)
        Me.ExitDate.Name = "ExitDate"
        Me.ExitDate.Size = New System.Drawing.Size(155, 22)
        Me.ExitDate.TabIndex = 7
        '
        'TrackBox
        '
        Me.TrackBox.Location = New System.Drawing.Point(156, 17)
        Me.TrackBox.Name = "TrackBox"
        Me.TrackBox.Size = New System.Drawing.Size(155, 22)
        Me.TrackBox.TabIndex = 8
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(156, 71)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(216, 22)
        Me.NameBox.TabIndex = 9
        '
        'SurnameBox
        '
        Me.SurnameBox.Location = New System.Drawing.Point(156, 97)
        Me.SurnameBox.Name = "SurnameBox"
        Me.SurnameBox.Size = New System.Drawing.Size(216, 22)
        Me.SurnameBox.TabIndex = 10
        '
        'ExitBox
        '
        Me.ExitBox.Location = New System.Drawing.Point(156, 123)
        Me.ExitBox.Name = "ExitBox"
        Me.ExitBox.Size = New System.Drawing.Size(216, 77)
        Me.ExitBox.TabIndex = 12
        Me.ExitBox.Text = ""
        '
        'dgvLeavers
        '
        Me.dgvLeavers.AllowUserToAddRows = False
        Me.dgvLeavers.BackgroundColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLeavers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLeavers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLeavers.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLeavers.Location = New System.Drawing.Point(12, 284)
        Me.dgvLeavers.Name = "dgvLeavers"
        Me.dgvLeavers.Size = New System.Drawing.Size(555, 320)
        Me.dgvLeavers.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ExitBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.SurnameBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.NameBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TrackBox)
        Me.GroupBox1.Controls.Add(Me.ExitDate)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 211)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "School Leavers"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SchoolManagement.My.Resources.Resources.Grad1
        Me.PictureBox1.Location = New System.Drawing.Point(2, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 196)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(408, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(159, 211)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'EditBtn
        '
        Me.EditBtn.Image = CType(resources.GetObject("EditBtn.Image"), System.Drawing.Image)
        Me.EditBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(52, 22)
        Me.EditBtn.Text = "&Edit"
        '
        'SchoolLeavers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(579, 616)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvLeavers)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(595, 655)
        Me.MinimumSize = New System.Drawing.Size(595, 655)
        Me.Name = "SchoolLeavers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "School Leavers"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvLeavers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ExitDate As DateTimePicker
    Friend WithEvents TrackBox As TextBox
    Friend WithEvents NameBox As TextBox
    Friend WithEvents SurnameBox As TextBox
    Friend WithEvents ExitBox As RichTextBox
    Friend WithEvents dgvLeavers As DataGridView
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents FormThemesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DefaultToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CornflowerBlueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeepSkyBlueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HotPinkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IvoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LightCoralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LightGreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrangeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PeachToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PinkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurpleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SilverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DarkRedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Save As ToolStripButton
    Friend WithEvents ClearAll As ToolStripButton
    Friend WithEvents ExitForm As ToolStripButton
    Friend WithEvents DarkVioletToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GridThemesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DefaultToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CoralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DodgerBlueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GreyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LightBlueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LightGreenToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LightPinkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrangeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PeachToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PinkToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PurpleToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VioletToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhiteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents EditBtn As ToolStripButton
End Class
