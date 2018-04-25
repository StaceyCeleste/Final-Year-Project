Imports SchoolManagement.Form1
Public Class ChildrensHomes
    Private Access As New DBControl

    ' NotEmpty Function to check for Errors
    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    ' Private Method to Display Childrens Homes Table in DataGridView
    Public Sub LoadHomes()

        Access.ExecQuery("SELECT TrackingNum AS [Tracking Number], HomeName AS [Home Name], HomeAddress AS [Home Address], 
                            HomeContact AS [Home Contact], StudentName AS [Student Name]
                            FROM ChildrensHomes")

        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        ' Fills DataGridView
        dgvHomes.DataSource = Access.DBDT

        ' Autosize DGV column width
        dgvHomes.AutoResizeColumns()
        dgvHomes.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells

    End Sub

    ' Private Method Loads and Displays Students Names and Surnames in ComboBox
    Private Sub LoadStudentCombo()
        Access.ExecQuery("Select StuName + ' ' + StuSurname AS FullName From StuDetails")

        StudentCombo.DataSource = Access.DBDT
        If Access.DBDT.Rows.Count > 0 Then
            StudentCombo.DataSource = Access.DBDT
            StudentCombo.ValueMember = "FullName"
            StudentCombo.DisplayMember = "FullName"
        End If

    End Sub

    Private Sub ChildrensHomes_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Children's Homes Information"
        LoadHomes()
        LoadStudentCombo()
    End Sub

    ' Form Theme Colours
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.LightGreen
    End Sub

    Private Sub CornflowerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CornflowerBlueToolStripMenuItem.Click
        Me.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub DarkRedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkRedToolStripMenuItem.Click
        Me.BackColor = Color.DarkRed
    End Sub

    Private Sub DarkVioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkVioletToolStripMenuItem.Click
        Me.BackColor = Color.DarkViolet
    End Sub

    Private Sub DeepSkyBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeepSkyBlueToolStripMenuItem.Click
        Me.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub HotPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HotPinkToolStripMenuItem.Click
        Me.BackColor = Color.HotPink
    End Sub

    Private Sub IvoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IvoryToolStripMenuItem.Click
        Me.BackColor = Color.Ivory
    End Sub

    Private Sub LightCoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightCoralToolStripMenuItem.Click
        Me.BackColor = Color.LightCoral
    End Sub

    Private Sub LimeGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimeGreenToolStripMenuItem.Click
        Me.BackColor = Color.LimeGreen
    End Sub

    Private Sub OrangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem.Click
        Me.BackColor = Color.Orange
    End Sub

    Private Sub PeachToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem.Click
        Me.BackColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem.Click
        Me.BackColor = Color.Pink
    End Sub

    Private Sub PurpleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem.Click
        Me.BackColor = Color.MediumPurple
    End Sub

    Private Sub SilverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SilverToolStripMenuItem.Click
        Me.BackColor = Color.Silver
    End Sub

    ' Grid Theme Colours
    Private Sub DefaultToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem1.Click
        Me.dgvHomes.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvHomes.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvHomes.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvHomes.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvHomes.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvHomes.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvHomes.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvHomes.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvHomes.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvHomes.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvHomes.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvHomes.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvHomes.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvHomes.BackgroundColor = Color.White
    End Sub

    ' TextBox Validation 
    Private Sub TextBox_Validation(sender As Object, e As EventArgs) Handles TrackBox.TextChanged, HomeNameBox.TextChanged,
            HomeAddBox.TextChanged, HomeContBox.TextChanged
        If Not String.IsNullOrWhiteSpace(TrackBox.Text) And
                        Not String.IsNullOrWhiteSpace(HomeNameBox.Text) And
                        Not String.IsNullOrWhiteSpace(HomeAddBox.Text) And
                        Not String.IsNullOrWhiteSpace(HomeContBox.Text) Then
            SaveTool.Enabled = True
        End If
    End Sub

    ' Save Children's Homes Details Method
    Private Sub SaveHomes()
        Access.AddParam("@track", TrackBox.Text)
        Access.AddParam("@hname", HomeNameBox.Text)
        Access.AddParam("@add", HomeAddBox.Text)
        Access.AddParam("@cont", HomeContBox.Text)
        Access.AddParam("@sname", StudentCombo.GetItemText(StudentCombo.SelectedItem))

        Access.ExecQuery("INSERT INTO ChildrensHomes (TrackingNum, HomeName, HomeAddress, HomeContact, StudentName) " &
                         "VALUES (@track, @hname, @add, @cont, @sname); ")

        ' Reports and aborts any errors
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception) : Exit Sub
        End If

        ' Success Message 
        MsgBox("New Children's Home Details Added Successfully!", MsgBoxStyle.Information, "Success!")
        LoadHomes()
    End Sub
    ' Save Button
    Private Sub SaveTool_Click(sender As Object, e As EventArgs) Handles SaveTool.Click
        SaveHomes()
    End Sub

    ' Clear Button - Resets Form
    Private Sub ClearTool_Click(sender As Object, e As EventArgs) Handles ClearTool.Click
        TrackBox.Text = ""
        HomeNameBox.Text = ""
        HomeAddBox.Text = ""
        HomeContBox.Text = ""
        StudentCombo.SelectedIndex = -1
        SaveTool.Enabled = False
    End Sub

    Private Sub ExitTool_Click(sender As Object, e As EventArgs) Handles ExitTool.Click
        Me.Close()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        EditChildrensHomes.Show()
    End Sub
End Class