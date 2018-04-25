Imports SchoolManagement.Form1
Public Class SportsParticipants
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    ' Loads Sports Events Table in DataGridView
    Private Sub LoadParticipants()
        Access.ExecQuery("SELECT TrackingNum AS [Tracking Number], ParticipantName AS [Student Name], HouseName AS [House Name]
                            FROM SportsParticipants")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        ' Fills DataGridView
        dgvParticipants.DataSource = Access.DBDT

        ' Autosize DGV column width
        dgvParticipants.AutoResizeColumns()
        dgvParticipants.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub LoadStudents()
        Access.ExecQuery("SELECT StuName + ' ' + StuSurname AS FullName FROM StuDetails")
        NameBox.DataSource = Access.DBDT
        If Access.DBDT.Rows.Count > 0 Then
            NameBox.DataSource = Access.DBDT
            NameBox.ValueMember = "FullName"
            NameBox.DisplayMember = "FullName"
            NameBox.SelectedIndex = -1
        End If
    End Sub

    Private Sub LoadHouses()
        Access.ExecQuery("SELECT * FROM HouseDetails")
        HouseBox.DataSource = Access.DBDT
        If Access.DBDT.Rows.Count > 0 Then
            NameBox.DataSource = Access.DBDT
            NameBox.ValueMember = "HouseName"
            NameBox.DisplayMember = "HouseName"
            HouseBox.SelectedIndex = -1
        End If
    End Sub

    Private Sub SportsParticipants_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " Sports Participants Details"
        LoadParticipants()
        LoadStudents()
        LoadHouses()
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
        Me.dgvParticipants.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvParticipants.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvParticipants.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvParticipants.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvParticipants.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvParticipants.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvParticipants.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvParticipants.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvParticipants.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvParticipants.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvParticipants.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvParticipants.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvParticipants.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvParticipants.BackgroundColor = Color.White
    End Sub

    Private Sub TrackBox_TextChanged(sender As Object, e As EventArgs) Handles TrackBox.TextChanged, NameBox.TextChanged, HouseBox.TextChanged
        If Not String.IsNullOrWhiteSpace(TrackBox.Text) And
                Not String.IsNullOrWhiteSpace(NameBox.Text) And
                Not String.IsNullOrWhiteSpace(HouseBox.Text) Then
            SaveStrip.Enabled = True
        End If
    End Sub
    ' Save Participants Method
    Private Sub SaveParticipants()
        Access.AddParam("@track", TrackBox.Text)
        Access.AddParam("@pname", NameBox.GetItemText(NameBox.SelectedIndex))
        Access.AddParam("@hname", HouseBox.GetItemText(HouseBox.SelectedIndex))

        Access.ExecQuery("INSERT INTO SportsParticipants (TrackingNum, ParticipantName, HouseName) " &
                         "VALUES (@track, @pname, @hname); ")
        ' Reports and aborts any errors 
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception) : Exit Sub
        End If
        ' Success Message 
        MsgBox("New Participant Added Successfully!", MsgBoxStyle.Information, "Success!")
        LoadParticipants()
    End Sub

    ' Save Button
    Private Sub SaveStrip_Click(sender As Object, e As EventArgs) Handles SaveStrip.Click
        SaveParticipants()
    End Sub

    ' Clear Button
    Private Sub ClearStrip_Click(sender As Object, e As EventArgs) Handles ClearStrip.Click
        TrackBox.Text = ""
        NameBox.SelectedIndex = -1
        HouseBox.SelectedIndex = -1
        SaveStrip.Enabled = False
    End Sub

    ' Exit Button
    Private Sub ExitStrip_Click(sender As Object, e As EventArgs) Handles ExitStrip.Click
        Me.Close()
    End Sub

End Class