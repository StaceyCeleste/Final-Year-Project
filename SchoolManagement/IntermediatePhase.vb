Imports SchoolManagement.Form1
Public Class IntermediatePhase
    Private Access As New DBControl
    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub LoadIntermediate()
        Access.ExecQuery("SELECT [ID], TrackingNum AS [Tracking Number], StudentName AS Student, IntYear AS [Year], IntTerm AS [Term],
                            Literacy, [Numeracy], LifeOrientation AS [Life Orientation], TotalMarks AS [Results]
                            FROM IntermediatePhase")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        dgvIntermediate.DataSource = Access.DBDT
        dgvIntermediate.AutoResizeColumns()
        dgvIntermediate.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub LoadStudents()
        Access.ExecQuery("SELECT StuName + ' ' + StuSurname AS FullName FROM StuDetails")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        StudentBox.DataSource = Access.DBDT
        If Access.DBDT.Rows.Count > 0 Then
            StudentBox.DataSource = Access.DBDT
            StudentBox.ValueMember = "FullName"
            StudentBox.DisplayMember = "FullName"
            StudentBox.SelectedIndex = -1
        End If
    End Sub

    Private Sub IntermediatePhase_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Junior Learner Records"
        LoadStudents()
        LoadIntermediate()
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
        Me.dgvIntermediate.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvIntermediate.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvIntermediate.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvIntermediate.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvIntermediate.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvIntermediate.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvIntermediate.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvIntermediate.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvIntermediate.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvIntermediate.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvIntermediate.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvIntermediate.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvIntermediate.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvIntermediate.BackgroundColor = Color.White
    End Sub

    Private Sub TrackBox_TextChanged(sender As Object, e As EventArgs) Handles TrackBox.TextChanged, LitBox.TextChanged, NumBox.TextChanged,
            LObox.TextChanged
        If Not String.IsNullOrWhiteSpace(TrackBox.Text) And
                Not String.IsNullOrWhiteSpace(LitBox.Text) And
                Not String.IsNullOrWhiteSpace(NumBox.Text) And
                Not String.IsNullOrWhiteSpace(LObox.Text) Then
            SaveAllBtn.Enabled = True
        End If
    End Sub

    Private Sub LObox_TextChanged(sender As Object, e As EventArgs) Handles LObox.TextChanged
        Dim TotalPercent As Decimal = 0
        Dim lit As String = LitBox.Text
        Dim num As String = NumBox.Text
        Dim lo As String = LObox.Text

        If Not String.IsNullOrEmpty(LObox.Text) Then
            Try
                TotalPercent = (Convert.ToDecimal(lit) + Convert.ToDecimal(num) + Convert.ToDecimal(lo)) / 3
                TotalLabel.Text = Decimal.Round(TotalPercent, 2)
            Catch ex As Exception
                MsgBox("Error Calculating Final Result!", MsgBoxStyle.Critical, "Error!")
            End Try
        End If
    End Sub

    Private Sub SaveIntermediate()
        Access.AddParam("@track", TrackBox.Text)
        Access.AddParam("@sname", StudentBox.GetItemText(StudentBox.SelectedItem))
        Access.AddParam("@iyear", YearBox.GetItemText(YearBox.SelectedItem))
        Access.AddParam("@iterm", TermBox.GetItemText(TermBox.SelectedItem))
        Access.AddParam("@lit", Convert.ToDecimal(LitBox.Text))
        Access.AddParam("@num", Convert.ToDecimal(NumBox.Text))
        Access.AddParam("@lor", Convert.ToDecimal(LObox.Text))
        Access.AddParam("@tmark", Convert.ToDecimal(TotalLabel.Text))

        Access.ExecQuery("INSERT INTO IntermediatePhase (TrackingNum, StudentName, IntYear, IntTerm, Literacy, [Numeracy], LifeOrientation, TotalMarks) " &
                         "VALUES (@track, @sname, @iyear, @iterm, @lit, @num, @lor, @tmark); ")
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception)
        End If
        MsgBox("Learner Record Saved Successfully!", MsgBoxStyle.Information, "Success!")
        LoadIntermediate()
    End Sub

    Private Sub SaveAllBtn_Click(sender As Object, e As EventArgs) Handles SaveAllBtn.Click
        SaveIntermediate()
    End Sub

    Private Sub ClearAllBtn_Click(sender As Object, e As EventArgs) Handles ClearAllBtn.Click
        TrackBox.Text = ""
        StudentBox.SelectedIndex = -1
        YearBox.SelectedIndex = -1
        TermBox.SelectedIndex = -1
        LitBox.Text = ""
        NumBox.Text = ""
        LObox.Text = ""
        TotalLabel.Text = 0
        SaveAllBtn.Enabled = False
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub JuniorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JuniorToolStripMenuItem.Click
        JuniorPhase.Show()
    End Sub

    Private Sub PrevocationalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrevocationalToolStripMenuItem.Click
        PrevocationalPhase.Show()
    End Sub
End Class