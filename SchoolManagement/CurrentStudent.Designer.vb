<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CurrentStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CurrentStudent))
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TotalWeight = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TotalStudents = New System.Windows.Forms.Label()
        Me.NameSearch = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.GridThemesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightBlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightPinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeachToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurpleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VioletToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormThemesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightBlueToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightPinkToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhiteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoralToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrangeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeachToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PinkToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurpleToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VioletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CmdSave = New System.Windows.Forms.ToolStripSplitButton()
        Me.EditStudentDets = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddressDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicalDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchBox
        '
        Me.SearchBox.Location = New System.Drawing.Point(195, 49)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(200, 22)
        Me.SearchBox.TabIndex = 1
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvData.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvData.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvData.Location = New System.Drawing.Point(12, 217)
        Me.dgvData.Name = "dgvData"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvData.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvData.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvData.Size = New System.Drawing.Size(671, 414)
        Me.dgvData.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.CmdSave, Me.ToolStripPrint, Me.ToolStripButton4, Me.ToolStripButton3, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripButton7, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(695, 25)
        Me.ToolStrip1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(195, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 36)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Current Students"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Search by Surname:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Total Student Weighting:"
        '
        'TotalWeight
        '
        Me.TotalWeight.AutoSize = True
        Me.TotalWeight.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalWeight.Location = New System.Drawing.Point(192, 79)
        Me.TotalWeight.Name = "TotalWeight"
        Me.TotalWeight.Size = New System.Drawing.Size(18, 17)
        Me.TotalWeight.TabIndex = 8
        Me.TotalWeight.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Total Students:"
        '
        'TotalStudents
        '
        Me.TotalStudents.AutoSize = True
        Me.TotalStudents.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalStudents.Location = New System.Drawing.Point(192, 105)
        Me.TotalStudents.Name = "TotalStudents"
        Me.TotalStudents.Size = New System.Drawing.Size(18, 17)
        Me.TotalStudents.TabIndex = 10
        Me.TotalStudents.Text = "0"
        '
        'NameSearch
        '
        Me.NameSearch.Location = New System.Drawing.Point(195, 21)
        Me.NameSearch.Name = "NameSearch"
        Me.NameSearch.Size = New System.Drawing.Size(200, 22)
        Me.NameSearch.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 22)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Search by Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TotalStudents)
        Me.GroupBox1.Controls.Add(Me.SearchBox)
        Me.GroupBox1.Controls.Add(Me.TotalWeight)
        Me.GroupBox1.Controls.Add(Me.NameSearch)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(407, 137)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(425, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 137)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SchoolManagement.My.Resources.Resources.Student1
        Me.PictureBox1.Location = New System.Drawing.Point(6, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(123, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormThemesToolStripMenuItem, Me.GridThemesToolStripMenuItem})
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(80, 22)
        Me.ToolStripButton1.Text = "Themes"
        '
        'GridThemesToolStripMenuItem
        '
        Me.GridThemesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NormalToolStripMenuItem, Me.BlueToolStripMenuItem, Me.CoralToolStripMenuItem, Me.GreyToolStripMenuItem, Me.LightBlueToolStripMenuItem, Me.GreenToolStripMenuItem, Me.LightPinkToolStripMenuItem, Me.OrangeToolStripMenuItem, Me.PeachToolStripMenuItem, Me.PinkToolStripMenuItem, Me.PurpleToolStripMenuItem, Me.RedToolStripMenuItem, Me.VioletToolStripMenuItem1, Me.WhiteToolStripMenuItem})
        Me.GridThemesToolStripMenuItem.Name = "GridThemesToolStripMenuItem"
        Me.GridThemesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GridThemesToolStripMenuItem.Text = "Grid Themes"
        '
        'NormalToolStripMenuItem
        '
        Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        Me.NormalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NormalToolStripMenuItem.Text = "Default"
        '
        'BlueToolStripMenuItem
        '
        Me.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        Me.BlueToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BlueToolStripMenuItem.Text = "Dodger Blue"
        '
        'CoralToolStripMenuItem
        '
        Me.CoralToolStripMenuItem.Name = "CoralToolStripMenuItem"
        Me.CoralToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CoralToolStripMenuItem.Text = "Coral"
        '
        'GreyToolStripMenuItem
        '
        Me.GreyToolStripMenuItem.Name = "GreyToolStripMenuItem"
        Me.GreyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GreyToolStripMenuItem.Text = "Grey"
        '
        'LightBlueToolStripMenuItem
        '
        Me.LightBlueToolStripMenuItem.Name = "LightBlueToolStripMenuItem"
        Me.LightBlueToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LightBlueToolStripMenuItem.Text = "Light Blue"
        '
        'GreenToolStripMenuItem
        '
        Me.GreenToolStripMenuItem.Name = "GreenToolStripMenuItem"
        Me.GreenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GreenToolStripMenuItem.Text = "Light Green"
        '
        'LightPinkToolStripMenuItem
        '
        Me.LightPinkToolStripMenuItem.Name = "LightPinkToolStripMenuItem"
        Me.LightPinkToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LightPinkToolStripMenuItem.Text = "Light Pink"
        '
        'OrangeToolStripMenuItem
        '
        Me.OrangeToolStripMenuItem.Name = "OrangeToolStripMenuItem"
        Me.OrangeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OrangeToolStripMenuItem.Text = "Orange"
        '
        'PeachToolStripMenuItem
        '
        Me.PeachToolStripMenuItem.Name = "PeachToolStripMenuItem"
        Me.PeachToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PeachToolStripMenuItem.Text = "Peach"
        '
        'PinkToolStripMenuItem
        '
        Me.PinkToolStripMenuItem.Name = "PinkToolStripMenuItem"
        Me.PinkToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PinkToolStripMenuItem.Text = "Pink"
        '
        'PurpleToolStripMenuItem
        '
        Me.PurpleToolStripMenuItem.Name = "PurpleToolStripMenuItem"
        Me.PurpleToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PurpleToolStripMenuItem.Text = "Purple"
        '
        'RedToolStripMenuItem
        '
        Me.RedToolStripMenuItem.Name = "RedToolStripMenuItem"
        Me.RedToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RedToolStripMenuItem.Text = "Red"
        '
        'VioletToolStripMenuItem1
        '
        Me.VioletToolStripMenuItem1.Name = "VioletToolStripMenuItem1"
        Me.VioletToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.VioletToolStripMenuItem1.Text = "Violet"
        '
        'WhiteToolStripMenuItem
        '
        Me.WhiteToolStripMenuItem.Name = "WhiteToolStripMenuItem"
        Me.WhiteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.WhiteToolStripMenuItem.Text = "White"
        '
        'FormThemesToolStripMenuItem
        '
        Me.FormThemesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NormalToolStripMenuItem1, Me.LightBlueToolStripMenuItem1, Me.BlueToolStripMenuItem1, Me.LightPinkToolStripMenuItem1, Me.WhiteToolStripMenuItem1, Me.CoralToolStripMenuItem1, Me.GreenToolStripMenuItem1, Me.OrangeToolStripMenuItem1, Me.PeachToolStripMenuItem1, Me.PinkToolStripMenuItem1, Me.PurpleToolStripMenuItem1, Me.RedToolStripMenuItem1, Me.GreyToolStripMenuItem1, Me.VioletToolStripMenuItem})
        Me.FormThemesToolStripMenuItem.Name = "FormThemesToolStripMenuItem"
        Me.FormThemesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FormThemesToolStripMenuItem.Text = "Form Themes"
        '
        'NormalToolStripMenuItem1
        '
        Me.NormalToolStripMenuItem1.Name = "NormalToolStripMenuItem1"
        Me.NormalToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.NormalToolStripMenuItem1.Text = "Default"
        '
        'LightBlueToolStripMenuItem1
        '
        Me.LightBlueToolStripMenuItem1.Name = "LightBlueToolStripMenuItem1"
        Me.LightBlueToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.LightBlueToolStripMenuItem1.Text = "Cornflower Blue"
        '
        'BlueToolStripMenuItem1
        '
        Me.BlueToolStripMenuItem1.Name = "BlueToolStripMenuItem1"
        Me.BlueToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.BlueToolStripMenuItem1.Text = "Deep Sky Blue"
        '
        'LightPinkToolStripMenuItem1
        '
        Me.LightPinkToolStripMenuItem1.Name = "LightPinkToolStripMenuItem1"
        Me.LightPinkToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.LightPinkToolStripMenuItem1.Text = "Hot Pink"
        '
        'WhiteToolStripMenuItem1
        '
        Me.WhiteToolStripMenuItem1.Name = "WhiteToolStripMenuItem1"
        Me.WhiteToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.WhiteToolStripMenuItem1.Text = "Ivory"
        '
        'CoralToolStripMenuItem1
        '
        Me.CoralToolStripMenuItem1.Name = "CoralToolStripMenuItem1"
        Me.CoralToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.CoralToolStripMenuItem1.Text = "Light Coral"
        '
        'GreenToolStripMenuItem1
        '
        Me.GreenToolStripMenuItem1.Name = "GreenToolStripMenuItem1"
        Me.GreenToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.GreenToolStripMenuItem1.Text = "Lime Green"
        '
        'OrangeToolStripMenuItem1
        '
        Me.OrangeToolStripMenuItem1.Name = "OrangeToolStripMenuItem1"
        Me.OrangeToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.OrangeToolStripMenuItem1.Text = "Orange"
        '
        'PeachToolStripMenuItem1
        '
        Me.PeachToolStripMenuItem1.Name = "PeachToolStripMenuItem1"
        Me.PeachToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.PeachToolStripMenuItem1.Text = "Peach"
        '
        'PinkToolStripMenuItem1
        '
        Me.PinkToolStripMenuItem1.Name = "PinkToolStripMenuItem1"
        Me.PinkToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.PinkToolStripMenuItem1.Text = "Pink"
        '
        'PurpleToolStripMenuItem1
        '
        Me.PurpleToolStripMenuItem1.Name = "PurpleToolStripMenuItem1"
        Me.PurpleToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.PurpleToolStripMenuItem1.Text = "Purple"
        '
        'RedToolStripMenuItem1
        '
        Me.RedToolStripMenuItem1.Name = "RedToolStripMenuItem1"
        Me.RedToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.RedToolStripMenuItem1.Text = "Dark Red"
        '
        'GreyToolStripMenuItem1
        '
        Me.GreyToolStripMenuItem1.Name = "GreyToolStripMenuItem1"
        Me.GreyToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.GreyToolStripMenuItem1.Text = "Silver"
        '
        'VioletToolStripMenuItem
        '
        Me.VioletToolStripMenuItem.Name = "VioletToolStripMenuItem"
        Me.VioletToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.VioletToolStripMenuItem.Text = "Dark Violet"
        '
        'CmdSave
        '
        Me.CmdSave.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditStudentDets, Me.AddressDetailsToolStripMenuItem, Me.ContactDetailsToolStripMenuItem, Me.MedicalDetailsToolStripMenuItem})
        Me.CmdSave.Image = CType(resources.GetObject("CmdSave.Image"), System.Drawing.Image)
        Me.CmdSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmdSave.Name = "CmdSave"
        Me.CmdSave.Size = New System.Drawing.Size(60, 22)
        Me.CmdSave.Text = "Edit"
        '
        'EditStudentDets
        '
        Me.EditStudentDets.Name = "EditStudentDets"
        Me.EditStudentDets.Size = New System.Drawing.Size(160, 22)
        Me.EditStudentDets.Text = "Student Details"
        '
        'AddressDetailsToolStripMenuItem
        '
        Me.AddressDetailsToolStripMenuItem.Name = "AddressDetailsToolStripMenuItem"
        Me.AddressDetailsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AddressDetailsToolStripMenuItem.Text = "Address Details"
        '
        'ContactDetailsToolStripMenuItem
        '
        Me.ContactDetailsToolStripMenuItem.Name = "ContactDetailsToolStripMenuItem"
        Me.ContactDetailsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ContactDetailsToolStripMenuItem.Text = "Contact Details"
        '
        'MedicalDetailsToolStripMenuItem
        '
        Me.MedicalDetailsToolStripMenuItem.Name = "MedicalDetailsToolStripMenuItem"
        Me.MedicalDetailsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.MedicalDetailsToolStripMenuItem.Text = "Medical Details"
        '
        'ToolStripPrint
        '
        Me.ToolStripPrint.Image = CType(resources.GetObject("ToolStripPrint.Image"), System.Drawing.Image)
        Me.ToolStripPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripPrint.Name = "ToolStripPrint"
        Me.ToolStripPrint.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripPrint.Text = "Print"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(65, 22)
        Me.ToolStripButton4.Text = "Details"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(71, 22)
        Me.ToolStripButton3.Text = "Address"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(70, 22)
        Me.ToolStripButton5.Text = "Contact"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(70, 22)
        Me.ToolStripButton6.Text = "Medical"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(101, 22)
        Me.ToolStripButton7.Text = "New Student"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripButton2.Text = "Exit"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SchoolManagement.My.Resources.Resources.Students1
        Me.PictureBox2.Location = New System.Drawing.Point(129, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(123, 119)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'CurrentStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(695, 643)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(715, 686)
        Me.MinimumSize = New System.Drawing.Size(715, 670)
        Me.Name = "CurrentStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CurrentStudent"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripDropDownButton
    Friend WithEvents GridThemesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CoralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GreyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LightBlueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LightPinkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrangeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PeachToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PinkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurpleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VioletToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents WhiteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormThemesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CoralToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GreyToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LightBlueToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LightPinkToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OrangeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PeachToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PinkToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PurpleToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VioletToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhiteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NormalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NormalToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TotalWeight As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TotalStudents As Label
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripPrint As ToolStripButton
    Friend WithEvents NameSearch As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CmdSave As ToolStripSplitButton
    Friend WithEvents EditStudentDets As ToolStripMenuItem
    Friend WithEvents AddressDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicalDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
