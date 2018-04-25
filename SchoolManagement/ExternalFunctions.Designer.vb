<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExternalFunctions
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExternalFunctions))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TimeBox = New System.Windows.Forms.TextBox()
        Me.DetailsBox = New System.Windows.Forms.RichTextBox()
        Me.DateBox = New System.Windows.Forms.DateTimePicker()
        Me.TypeBox = New System.Windows.Forms.ComboBox()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvFunctions = New System.Windows.Forms.DataGridView()
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
        Me.EditBtn = New System.Windows.Forms.ToolStripButton()
        Me.SaveBtn = New System.Windows.Forms.ToolStripButton()
        Me.ClearBtn = New System.Windows.Forms.ToolStripButton()
        Me.ExitBtn = New System.Windows.Forms.ToolStripButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.VenueBox = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvFunctions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1, Me.EditBtn, Me.SaveBtn, Me.ClearBtn, Me.ExitBtn})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(414, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 36)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "External Functions"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.VenueBox)
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 285)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Function Details"
        '
        'TimeBox
        '
        Me.TimeBox.Location = New System.Drawing.Point(127, 116)
        Me.TimeBox.Name = "TimeBox"
        Me.TimeBox.Size = New System.Drawing.Size(200, 22)
        Me.TimeBox.TabIndex = 21
        '
        'DetailsBox
        '
        Me.DetailsBox.Location = New System.Drawing.Point(127, 174)
        Me.DetailsBox.Name = "DetailsBox"
        Me.DetailsBox.Size = New System.Drawing.Size(243, 96)
        Me.DetailsBox.TabIndex = 11
        Me.DetailsBox.Text = ""
        '
        'DateBox
        '
        Me.DateBox.CustomFormat = "dd-MM-yyyy"
        Me.DateBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateBox.Location = New System.Drawing.Point(127, 88)
        Me.DateBox.Name = "DateBox"
        Me.DateBox.Size = New System.Drawing.Size(200, 22)
        Me.DateBox.TabIndex = 9
        '
        'TypeBox
        '
        Me.TypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TypeBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TypeBox.FormattingEnabled = True
        Me.TypeBox.Items.AddRange(New Object() {"Children's Party", "Conference", "Convention", "Dinner and Banquets", "End Year Party", "Fair", "Farewell Party", "Fundraiser", "Gala", "Networking", "Seminars", "Staff Party", "Team Building", "Workshops"})
        Me.TypeBox.Location = New System.Drawing.Point(127, 58)
        Me.TypeBox.Name = "TypeBox"
        Me.TypeBox.Size = New System.Drawing.Size(200, 24)
        Me.TypeBox.Sorted = True
        Me.TypeBox.TabIndex = 20
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(127, 30)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(200, 22)
        Me.NameBox.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Function Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Details:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Function Type:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Date:"
        '
        'dgvFunctions
        '
        Me.dgvFunctions.AllowUserToAddRows = False
        Me.dgvFunctions.BackgroundColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFunctions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvFunctions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFunctions.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvFunctions.Location = New System.Drawing.Point(12, 382)
        Me.dgvFunctions.Name = "dgvFunctions"
        Me.dgvFunctions.Size = New System.Drawing.Size(389, 188)
        Me.dgvFunctions.TabIndex = 9
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
        'EditBtn
        '
        Me.EditBtn.Image = CType(resources.GetObject("EditBtn.Image"), System.Drawing.Image)
        Me.EditBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(52, 22)
        Me.EditBtn.Text = "&Edit"
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Venue:"
        '
        'VenueBox
        '
        Me.VenueBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.VenueBox.FormattingEnabled = True
        Me.VenueBox.Location = New System.Drawing.Point(127, 144)
        Me.VenueBox.Name = "VenueBox"
        Me.VenueBox.Size = New System.Drawing.Size(200, 24)
        Me.VenueBox.TabIndex = 23
        '
        'ExternalFunctions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(414, 582)
        Me.Controls.Add(Me.dgvFunctions)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(430, 621)
        Me.MinimumSize = New System.Drawing.Size(430, 621)
        Me.Name = "ExternalFunctions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "External Functions"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvFunctions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
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
    Friend WithEvents EditBtn As ToolStripButton
    Friend WithEvents SaveBtn As ToolStripButton
    Friend WithEvents ClearBtn As ToolStripButton
    Friend WithEvents ExitBtn As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TimeBox As TextBox
    Friend WithEvents DetailsBox As RichTextBox
    Friend WithEvents DateBox As DateTimePicker
    Friend WithEvents TypeBox As ComboBox
    Friend WithEvents NameBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvFunctions As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents VenueBox As ComboBox
End Class
