Imports SchoolManagement.Form1
Public Class Searches
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    ' Load Searches Method
    Private Sub LoadSearches()
        Access.ExecQuery("SELECT SearchID as [Search ID], SearchName AS [Search Name], SearchDate AS [Date], Details, SearchTeam AS [SearchTeam],
                            [Comments] FROM Searches")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        ' Fills DataGridView
        dgvSearches.DataSource = Access.DBDT

        ' Auto Resizes DataGridView Columns
        dgvSearches.AutoResizeColumns()
        dgvSearches.AutoSizeColumnsMode =
         DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub Searches_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Search Details"
        LoadSearches()
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
        Me.dgvSearches.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvSearches.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvSearches.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvSearches.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvSearches.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvSearches.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvSearches.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvSearches.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvSearches.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvSearches.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvSearches.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvSearches.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvSearches.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvSearches.BackgroundColor = Color.White
    End Sub

    ' Auto Generates Search ID
    Private Sub SearchName_TextChanged(sender As Object, e As EventArgs) Handles SearchName.TextChanged
        Dim SID As Integer
        Dim Cyear As String = DateTime.Now.ToString("yy")
        Dim STotal As Integer
        STotal = dgvSearches.Rows.Count
        Try
            If Not String.IsNullOrWhiteSpace(SearchName.Text) Then
                SID = Cyear &
                    STotal = +1
                STotal.ToString()
            End If
            SID = Cyear & STotal.ToString
        Catch ex As Exception
            MsgBox("Error Generating Search ID!", MsgBoxStyle.Critical, "Error!")
        End Try
        SearchID.Text = "SRCH" & SID.ToString
    End Sub

    ' Textbox Validation
    Private Sub DetailsBox_TextChanged(sender As Object, e As EventArgs) Handles DetailsBox.TextChanged, SearchName.TextChanged,
            TeamBox.TextChanged, CommentsBox.TextChanged
        If Not String.IsNullOrWhiteSpace(SearchName.Text) And
                Not String.IsNullOrWhiteSpace(DetailsBox.Text) And
                Not String.IsNullOrWhiteSpace(TeamBox.Text) And
                Not String.IsNullOrWhiteSpace(CommentsBox.Text) Then
            SaveBtn.Enabled = True
        End If
    End Sub

    ' Save Searches Method
    Private Sub SaveSearches()
        Access.AddParam("@sid", SearchID.Text)
        Access.AddParam("@sname", SearchName.Text)
        Access.AddParam("@sdate", SearchDate.Value.ToShortDateString)
        Access.AddParam("@dets", DetailsBox.Text)
        Access.AddParam("@team", TeamBox.Text)
        Access.AddParam("@coms", CommentsBox.Text)

        Access.ExecQuery("INSERT INTO Searches (SearchID, SearchName, SearchDate, Details, SearchTeam, [Comments]) " &
                         "VALUES (@sid, @sname, @sdate, @dets, @team, @coms); ")
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception)
        End If
        MsgBox("Search Details Added Syccessfully!", MsgBoxStyle.Information, "Success!")
        LoadSearches()
    End Sub

    ' Save Button
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        SaveSearches()
    End Sub

    ' Clear Button
    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        SearchID.Text = 0
        SearchName.Text = ""
        SearchDate.Value = Date.Now
        DetailsBox.Text = ""
        TeamBox.Text = ""
        CommentsBox.Text = ""
        SaveBtn.Enabled = False
    End Sub

    ' Exit Button
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class