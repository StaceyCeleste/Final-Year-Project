Imports SchoolManagement.Form1
Public Class CodesOfSports
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    ' Loads Codes of Sports Table in DataGridView
    Private Sub LoadCodesOfSports()
        Access.ExecQuery("SELECT SportID AS [Sport ID], SportName AS [Name of Sport], SportDescription AS [Description], Coach
                           FROM CodesOfSports")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        ' Fills DataGridView
        dgvSports.DataSource = Access.DBDT

        ' Autosize DGV column width
        dgvSports.AutoResizeColumns()
        dgvSports.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    ' Loads All Staff Members in ComboBox
    Public Sub LoadCoaches()
        Access.ExecQuery("SELECT StaffName + ' ' + StaffSurname AS FullName FROM StaffDetails")
        CoachBox.DataSource = Access.DBDT
        If Access.DBDT.Rows.Count > 0 Then
            CoachBox.DataSource = Access.DBDT
            CoachBox.ValueMember = "FullName"
            CoachBox.DisplayMember = "FullName"
        End If
    End Sub

    Private Sub CodesOfSports_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Codes of Sports Details"
        LoadCodesOfSports()
        LoadCoaches()
    End Sub

    ' Form Theme Colours
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.MediumSpringGreen
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
        Me.dgvSports.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvSports.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvSports.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvSports.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvSports.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvSports.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvSports.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvSports.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvSports.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvSports.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvSports.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvSports.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvSports.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvSports.BackgroundColor = Color.White
    End Sub

    ' Auto Generates Sports ID
    Private Sub SNameBox_TextChanged(sender As Object, e As EventArgs) Handles SNameBox.TextChanged
        Dim SportsID As Integer
        Dim Cyear As String = DateTime.Now.ToString("yy")
        Dim STotal As Integer
        STotal = dgvSports.RowCount
        Try

            If Not String.IsNullOrWhiteSpace(SNameBox.Text) Then
                SportsID = Cyear &
                    STotal = +1
                STotal.ToString("00")

            End If
            SportsID = Cyear & STotal.ToString
        Catch ex As Exception
            MsgBox("Error Generating Sports ID!", MsgBoxStyle.Critical, "Error!")
        End Try
        SportID.Text = "SP" & SportsID.ToString
    End Sub

    ' Save Codes of Sports Method
    Private Sub SaveCodesOfSports()
        Access.AddParam("@sid", SportID.Text)
        Access.AddParam("@sname", SNameBox.Text)
        Access.AddParam("@descr", DescriptBox.Text)
        Access.AddParam("@coach", CoachBox.GetItemText(CoachBox.SelectedItem))

        Access.ExecQuery("INSERT INTO CodesOfSports (SportID, SportName, SportDescription, Coach) " &
                         "VALUES (@sid, @sname, @descr, @coach); ")
        ' Reports and aborts any errors 
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception) : Exit Sub
        End If
        ' Success Message 
        MsgBox("New Codes of Sports Added Successfully!", MsgBoxStyle.Information, "Success!")
        LoadCodesOfSports()
    End Sub

    ' Save Button
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        SaveCodesOfSports()
    End Sub

    ' Clear Button
    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        SportID.Text = 0
        SNameBox.Text = ""
        CoachBox.SelectedIndex = -1
        DescriptBox.Text = ""
    End Sub

    ' Exit Button
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    ' House Details Button
    Private Sub HousesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HousesToolStripMenuItem.Click
        HouseDetails.Show()
    End Sub

    ' Sports Events Button
    Private Sub SportsEventsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SportsEventsToolStripMenuItem.Click
        SportsEvents.Show()
    End Sub

    ' Sports Participants Button
    Private Sub ParticipantsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParticipantsToolStripMenuItem.Click
        SportsParticipants.Show()
    End Sub

End Class