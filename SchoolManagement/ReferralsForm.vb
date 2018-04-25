Imports SchoolManagement.Form1
Public Class ReferralsForm
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub LoadReferrals()
        Access.ExecQuery("SELECT ReferralID AS [Referral ID], TrackingNum AS [Tracking Number],
                          StudentName AS [Student Name], StudentSurname AS [Student Surname], [Comments]
                            FROM ReferralsList")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        dgvReferrals.DataSource = Access.DBDT

        ' Autosize DGV column width
        dgvReferrals.AutoResizeColumns()
        dgvReferrals.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells

    End Sub

    Private Sub ReferralsForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Referrals List"
        LoadReferrals()
    End Sub

    ' Form Theme Colours
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.LightGreen
    End Sub

    Private Sub DarkRedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkRedToolStripMenuItem.Click
        Me.BackColor = Color.DarkRed
    End Sub

    Private Sub DarkVioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkVioletToolStripMenuItem.Click
        Me.BackColor = Color.DarkViolet
    End Sub

    Private Sub CornflowerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CornflowerBlueToolStripMenuItem.Click
        Me.BackColor = Color.CornflowerBlue
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
        Me.dgvReferrals.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvReferrals.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvReferrals.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvReferrals.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvReferrals.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvReferrals.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvReferrals.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvReferrals.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvReferrals.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvReferrals.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvReferrals.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvReferrals.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvReferrals.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvReferrals.BackgroundColor = Color.White
    End Sub

    Private Sub SaveReferrals()

        Access.AddParam("@track", TrackBox.Text)
        Access.AddParam("@sname", SNameBox.Text)
        Access.AddParam("@surname", SurnameBox.Text)
        Access.AddParam("@coms", CommentsBox.Text)

        Access.ExecQuery("INSERT INTO ReferralsList(TrackingNum, StudentName, StudentSurname, [Comments]) " &
                         "VALUES (@track, @sname, @surname, @coms)")

        ' Reports and aborts any errors
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception) : Exit Sub
        End If
        ' Success Message 
        MsgBox("New Referral Student Added Successfully!", MsgBoxStyle.Information, "Success!")
        LoadReferrals()
    End Sub

    Private Sub TextBox_Validation(sender As Object, e As EventArgs) Handles TrackBox.TextChanged, SNameBox.TextChanged,
            SurnameBox.TextChanged, CommentsBox.TextChanged
        If Not String.IsNullOrWhiteSpace(TrackBox.Text) And
               Not String.IsNullOrWhiteSpace(SNameBox.Text) And
                Not String.IsNullOrWhiteSpace(SurnameBox.Text) And
                Not String.IsNullOrWhiteSpace(CommentsBox.Text) Then
            SaveBtn.Enabled = True
        End If

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        SaveReferrals()
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        TrackBox.Text = ""
        SNameBox.Text = ""
        SurnameBox.Text = ""
        CommentsBox.Text = ""
        SaveBtn.Enabled = False
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

End Class