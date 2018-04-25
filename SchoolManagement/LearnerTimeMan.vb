Imports SchoolManagement.Form1
Public Class LearnerTimeMan
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    ' Loads Learner Time management Table in DataGridView
    Private Sub LoadTimeMan()
        Access.ExecQuery("SELECT [ID], LearnerName AS [Learner], ArrivalDate AS [Date], ArrivalTime AS [Time], Reason, Educator, HOD, Principal, [Comments]
                            FROM LTimeManagement")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        ' Fills DataGridView
        dgvTimeMan.DataSource = Access.DBDT

        ' Autosize DGV column width
        dgvTimeMan.AutoResizeColumns()
        dgvTimeMan.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    ' Loads All Students In Student ComboBox
    Public Sub LoadStudents()
        Access.ExecQuery("SELECT StuName + ' ' + StuSurname AS FullName FROM StuDetails")
        StudentBox.DataSource = Access.DBDT
        If Access.DBDT.Rows.Count > 0 Then
            StudentBox.DataSource = Access.DBDT
            StudentBox.ValueMember = "FullName"
            StudentBox.DisplayMember = "FullName"
        End If
    End Sub

    ' Loads Educators In Educators ComboBox
    Public Sub LoadEducators()
        Access.ExecQuery("SELECT StaffName + ' ' + StaffSurname AS StaffFullName FROM StaffDetails")
        EducatorBox.DataSource = Access.DBDT
        If Access.DBDT.Rows.Count > 0 Then
            EducatorBox.DataSource = Access.DBDT
            EducatorBox.ValueMember = "StaffFullName"
            EducatorBox.DisplayMember = "StaffFullName"
        End If
    End Sub

    Private Sub LearnerTimeMan_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Learner Time Management"
        LoadTimeMan()
        LoadStudents()
        LoadEducators()
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

    ' DataGridView Theme Colours
    Private Sub DefaultToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem1.Click
        Me.dgvTimeMan.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvTimeMan.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvTimeMan.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvTimeMan.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvTimeMan.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvTimeMan.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvTimeMan.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvTimeMan.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvTimeMan.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvTimeMan.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvTimeMan.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvTimeMan.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvTimeMan.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvTimeMan.BackgroundColor = Color.White
    End Sub

    ' Save Time Management Method
    Private Sub SaveTimeMan()
        Access.AddParam("@lname", StudentBox.Text)
        Access.AddParam("@adate", DateBox.Value.ToShortDateString)
        Access.AddParam("@atime", TimeBox.Value.ToShortTimeString)
        Access.AddParam("@reas", ReasonBox.Text)
        Access.AddParam("@edu", EducatorBox.GetItemText(EducatorBox.SelectedItem))
        Access.AddParam("@hod", HODbox.GetItemText(HODbox.SelectedItem))
        Access.AddParam("@princ", PrincipalBox.GetItemText(PrincipalBox.SelectedItem))
        Access.AddParam("@coms", CommentsBox.Text)

        Access.ExecQuery("INSERT INTO LTimeManagement (LearnerName, ArrivalDate, ArrivalTime, Reason, Educator, HOD, Principal, [Comments]) " &
                         "VALUES (@lname, @adate, @atime, @reas, @edu, @hod, @princ, @coms); ")
        ' Reports and aborts any errors 
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception) : Exit Sub
        End If
        ' Success Message 
        MsgBox("Learner Time Management Added Successfully!", MsgBoxStyle.Information, "Success!")
        LoadTimeMan()
    End Sub

    ' Save Button
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        SaveTimeMan()
    End Sub

    ' Clear Button
    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        StudentBox.SelectedIndex = -1
        DateBox.Value = Date.Now
        TimeBox.Value = Now
        ReasonBox.Text = ""
        EducatorBox.SelectedIndex = -1
        HODbox.SelectedIndex = -1
        PrincipalBox.SelectedIndex = -1
        CommentsBox.Text = ""
    End Sub

    ' Exit Button
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

End Class