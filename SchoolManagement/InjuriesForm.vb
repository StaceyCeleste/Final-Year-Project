Imports SchoolManagement.Form1
Public Class InjuriesForm
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    ' Load Injuries Table
    Private Sub LoadInjuries()
        Access.ExecQuery("SELECT InjuryID AS [Injury ID], StudentName AS [Student Name], InjuryDate AS [Date], InjuryTime AS [Time],
                            InjuryType AS [Type of Injury], InjuryDescription AS [Description of Injury], AttendingPerson AS [Attending Person]
                            FROM Injuries")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' Fills DataGridView
        dgvInjuries.DataSource = Access.DBDT

        ' Resizes Columns
        dgvInjuries.AutoResizeColumns()
        dgvInjuries.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    ' Load Students Names in StudentBox
    Private Sub LoadStudents()
        Access.ExecQuery("SELECT StuName + ' ' + StuSurname AS FullName FROM StuDetails")
        StudentBox.DataSource = Access.DBDT
        If Access.DBDT.Rows.Count > 0 Then
            StudentBox.DataSource = Access.DBDT
            StudentBox.ValueMember = "FullName"
            StudentBox.DisplayMember = "FullName"
            StudentBox.SelectedIndex = -1
        End If
    End Sub

    ' Load Staff Names in StaffBox
    Private Sub LoadStaffMembers()
        Access.ExecQuery("SELECT StaffName + ' ' + StaffSurname AS StaffMember FROM StaffDetails")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        StaffBox.DataSource = Access.DBDT
        If Access.DBDT.Rows.Count > 0 Then
            StaffBox.DataSource = Access.DBDT
            StaffBox.ValueMember = "StaffMember"
            StaffBox.DisplayMember = "StaffMember"
            StaffBox.SelectedIndex = -1
        End If
    End Sub

    Private Sub InjuriesForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Student Injury Details"
        LoadInjuries()
        LoadStudents()
        LoadStaffMembers()
    End Sub

    ' Form Theme Colours
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.LightBlue
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
        Me.dgvInjuries.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvInjuries.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvInjuries.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvInjuries.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvInjuries.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvInjuries.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvInjuries.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvInjuries.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvInjuries.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvInjuries.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvInjuries.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvInjuries.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvInjuries.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvInjuries.BackgroundColor = Color.White
    End Sub

    ' Auto Generates Injury ID
    Private Sub DescripBox_TextChanged(sender As Object, e As EventArgs) Handles DescripBox.TextChanged
        Dim InjID As Integer
        Dim Cyear As String = DateTime.Now.ToString("yy")
        Dim ITotal As Integer
        ITotal = dgvInjuries.Rows.Count
        Try
            If Not String.IsNullOrWhiteSpace(DescripBox.Text) Then
                InjID = Cyear &
                    ITotal = +1
                ITotal.ToString()
            End If
            InjID = Cyear & ITotal.ToString
        Catch ex As Exception
            MsgBox(Access.Exception)
        End Try
        InjuryIDLabel.Text = "INJ-" & InjID.ToString
        SaveBtn.Enabled = True
    End Sub

    ' Save Injury Information Method
    Private Sub SaveInjuries()
        Access.AddParam("@iid", InjuryIDLabel.Text)
        Access.AddParam("@sname", StudentBox.GetItemText(StudentBox.SelectedItem))
        Access.AddParam("idate", DateBox.Value.ToShortDateString)
        Access.AddParam("@itime", TimeBox.Value.ToShortTimeString)
        Access.AddParam("@itype", InjuryBox.GetItemText(InjuryBox.SelectedItem))
        Access.AddParam("@des", DescripBox.Text)
        Access.AddParam("@pers", StaffBox.GetItemText(StaffBox.SelectedItem))

        Access.ExecQuery("INSERT INTO Injuries (InjuryID, StudentName, InjuryDate, InjuryTime, InjuryType, InjuryDescription, AttendingPerson) " &
                         "VALUES (@iid, @sname, @idate, @itime, @itype, @des, @pers); ")
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception)
        End If
        MsgBox("Student Injury Added Successfully!", MsgBoxStyle.Information, "Success!")
        LoadInjuries()
    End Sub

    ' Save Button
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        SaveInjuries()
    End Sub

    ' Clear Button
    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        InjuryIDLabel.Text = 0
        StudentBox.SelectedIndex = -1
        DateBox.Value = Date.Now
        TimeBox.Value = Now
        InjuryBox.SelectedIndex = -1
        DescripBox.Text = ""
        StaffBox.SelectedIndex = -1
        SaveBtn.Enabled = False
    End Sub

    ' Close Button
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class