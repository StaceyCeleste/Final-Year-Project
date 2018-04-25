Imports SchoolManagement.Form1
Public Class StaffLeave
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    ' Load Staff Leave Method
    Private Sub LoadStaffLeave()
        Access.ExecQuery("SELECT LeaveID AS [Leave ID], StaffName AS [Name], StartDate AS [Start],
                            EndDate AS [End], [Comments]
                            FROM StaffLeave")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        ' Fills DataGridView
        dgvStaffLeave.DataSource = Access.DBDT

        ' Autosize DGV column width
        dgvStaffLeave.AutoResizeColumns()
        dgvStaffLeave.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    ' Load ComboBox Names
    Private Sub LoadCombo()
        Access.ExecQuery("SELECT StaffName + ' ' + StaffSurname AS FullName FROM StaffDetails")
        NameBox.DataSource = Access.DBDT
        If Access.DBDT.Rows.Count > 0 Then
            NameBox.DataSource = Access.DBDT
            NameBox.ValueMember = "FullName"
            NameBox.DisplayMember = "FullName"
        End If
    End Sub

    Private Sub StaffLeave_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " Staff Leave Register"
        LoadStaffLeave()
        LoadCombo()
    End Sub

    ' Form Theme Colours
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.IndianRed
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

    ' DataGridView Theme Colours
    Private Sub DefaultToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem1.Click
        Me.dgvStaffLeave.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvStaffLeave.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvStaffLeave.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrayToolStripMenuItem.Click
        Me.dgvStaffLeave.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvStaffLeave.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvStaffLeave.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvStaffLeave.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvStaffLeave.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvStaffLeave.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvStaffLeave.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvStaffLeave.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvStaffLeave.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvStaffLeave.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvStaffLeave.BackgroundColor = Color.White
    End Sub

    ' Textbox Validation
    Private Sub Textbox_Validation(sender As Object, e As EventArgs) Handles CommentsBox.TextChanged
        If Not String.IsNullOrWhiteSpace(NameBox.Text) And
                Not String.IsNullOrWhiteSpace(CommentsBox.Text) Then
            SaveTool.Enabled = True
        End If
    End Sub

    ' Add New Staff Leave Register Method
    Private Sub SaveLeaveReg()
        Access.AddParam("@sname", NameBox.GetItemText(NameBox.SelectedItem))
        Access.AddParam("@sdate", StartDate.Value.ToShortDateString)
        Access.AddParam("@edate", EndDate.Value.ToShortDateString)
        Access.AddParam("@coms", CommentsBox.Text)

        Access.ExecQuery("INSERT INTO StaffLeave (StaffName, StartDate, EndDate, [Comments]) " &
                         "VALUES (@sname, @sdate, @edate, @coms); ")
        ' Reports and aborts any errors 
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception) : Exit Sub
        End If
        ' Success Message 
        MsgBox("New Leave Register Added Successfully!", MsgBoxStyle.Information, "Success!")
        LoadStaffLeave()
    End Sub

    ' Save Button
    Private Sub SaveTool_Click(sender As Object, e As EventArgs) Handles SaveTool.Click
        SaveLeaveReg()
    End Sub

    ' Clear Button
    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        NameBox.SelectedIndex = -1
        StartDate.Value = Date.Now
        EndDate.Value = Date.Now
        CommentsBox.Text = ""
        SaveTool.Enabled = False
    End Sub

    ' Exit Button
    Private Sub ExitTool_Click(sender As Object, e As EventArgs) Handles ExitTool.Click
        Me.Close()
    End Sub
End Class