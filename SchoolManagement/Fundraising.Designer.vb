<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fundraising
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fundraising))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.SaveStripBtn = New System.Windows.Forms.ToolStripButton()
        Me.ClearAllBtn = New System.Windows.Forms.ToolStripButton()
        Me.ExitStripBtn = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FundID = New System.Windows.Forms.Label()
        Me.DateBox = New System.Windows.Forms.DateTimePicker()
        Me.FundBox = New System.Windows.Forms.TextBox()
        Me.AmountBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvFund = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvFund, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1, Me.SaveStripBtn, Me.ClearAllBtn, Me.ExitStripBtn})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(426, 25)
        Me.ToolStrip1.TabIndex = 4
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
        'SaveStripBtn
        '
        Me.SaveStripBtn.Enabled = False
        Me.SaveStripBtn.Image = CType(resources.GetObject("SaveStripBtn.Image"), System.Drawing.Image)
        Me.SaveStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveStripBtn.Name = "SaveStripBtn"
        Me.SaveStripBtn.Size = New System.Drawing.Size(56, 22)
        Me.SaveStripBtn.Text = "&Save"
        '
        'ClearAllBtn
        '
        Me.ClearAllBtn.Image = CType(resources.GetObject("ClearAllBtn.Image"), System.Drawing.Image)
        Me.ClearAllBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearAllBtn.Name = "ClearAllBtn"
        Me.ClearAllBtn.Size = New System.Drawing.Size(59, 22)
        Me.ClearAllBtn.Text = "&Clear"
        '
        'ExitStripBtn
        '
        Me.ExitStripBtn.Image = CType(resources.GetObject("ExitStripBtn.Image"), System.Drawing.Image)
        Me.ExitStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExitStripBtn.Name = "ExitStripBtn"
        Me.ExitStripBtn.Size = New System.Drawing.Size(51, 22)
        Me.ExitStripBtn.Text = "E&xit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 36)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Fundraising"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fundraising ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fundraising Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Amount Collected:"
        '
        'FundID
        '
        Me.FundID.AutoSize = True
        Me.FundID.Location = New System.Drawing.Point(154, 28)
        Me.FundID.Name = "FundID"
        Me.FundID.Size = New System.Drawing.Size(16, 16)
        Me.FundID.TabIndex = 10
        Me.FundID.Text = "0"
        '
        'DateBox
        '
        Me.DateBox.CustomFormat = "dd-MM-yyyy"
        Me.DateBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateBox.Location = New System.Drawing.Point(151, 48)
        Me.DateBox.Name = "DateBox"
        Me.DateBox.Size = New System.Drawing.Size(200, 22)
        Me.DateBox.TabIndex = 11
        '
        'FundBox
        '
        Me.FundBox.Location = New System.Drawing.Point(150, 76)
        Me.FundBox.Name = "FundBox"
        Me.FundBox.Size = New System.Drawing.Size(200, 22)
        Me.FundBox.TabIndex = 12
        '
        'AmountBox
        '
        Me.AmountBox.Location = New System.Drawing.Point(151, 104)
        Me.AmountBox.Name = "AmountBox"
        Me.AmountBox.Size = New System.Drawing.Size(200, 22)
        Me.AmountBox.TabIndex = 13
        Me.AmountBox.Text = "R"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.AmountBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.FundBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DateBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.FundID)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(402, 146)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fundraising Details"
        '
        'dgvFund
        '
        Me.dgvFund.AllowUserToAddRows = False
        Me.dgvFund.BackgroundColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFund.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvFund.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFund.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvFund.Location = New System.Drawing.Point(12, 234)
        Me.dgvFund.Name = "dgvFund"
        Me.dgvFund.Size = New System.Drawing.Size(402, 155)
        Me.dgvFund.TabIndex = 15
        '
        'Fundraising
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(426, 401)
        Me.Controls.Add(Me.dgvFund)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Fundraising"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fundraising"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvFund, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents SaveStripBtn As ToolStripButton
    Friend WithEvents ClearAllBtn As ToolStripButton
    Friend WithEvents ExitStripBtn As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents FundID As Label
    Friend WithEvents DateBox As DateTimePicker
    Friend WithEvents FundBox As TextBox
    Friend WithEvents AmountBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvFund As DataGridView
End Class
