Imports SchoolManagement.Form1
Public Class YearPlanner
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Public Sub LoadPlanner()
        Access.ExecQuery("SELECT [ID], PDate AS [Date], DayOfWeek AS [Day], [Activity], [Comments]
                            FROM YearPlanner")
        dgvPlanner.DataSource = Access.DBDT
        dgvPlanner.AutoResizeColumns()
        dgvPlanner.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub YearPlanner_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Year Planner"
        LoadPlanner()
    End Sub

    ' Form Theme Colours
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.PeachPuff
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
        Me.dgvPlanner.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvPlanner.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvPlanner.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvPlanner.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvPlanner.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvPlanner.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvPlanner.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvPlanner.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvPlanner.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvPlanner.BackgroundColor = Color.Pink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvPlanner.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvPlanner.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvPlanner.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvPlanner.BackgroundColor = Color.White
    End Sub


    Private Sub Textbox_Validation(sender As Object, e As EventArgs) Handles DayBox.TextChanged, ActivityBox.TextChanged, CommentsBox.TextChanged
        If Not String.IsNullOrWhiteSpace(DayBox.Text) And
                Not String.IsNullOrWhiteSpace(ActivityBox.Text) And
                Not String.IsNullOrWhiteSpace(CommentsBox.Text) Then
            SaveBtn.Enabled = True
        End If
    End Sub

    Private Sub SavePlanner()
        Access.AddParam("@pdate", DateBox.Value.ToShortDateString)
        Access.AddParam("@pday", DayBox.Text)
        Access.AddParam("@pactivity", ActivityBox.Text)
        Access.AddParam("@comms", CommentsBox.Text)

        Access.ExecQuery("INSERT INTO YearPlanner (PDate, DayOfWeek, [Activity], [Comments]) " &
                         "VALUES (@pdate, @pday, @pactivity, @comms); ")
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception)
        End If
        MsgBox("New Activity Added to Year Planner Successfully!", MsgBoxStyle.Information, "Success!")
        LoadPlanner()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        SavePlanner()
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        DateBox.Value = Date.Now
        DayBox.Text = ""
        ActivityBox.Text = ""
        CommentsBox.Text = ""
        SaveBtn.Enabled = False
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class