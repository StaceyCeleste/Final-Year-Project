Imports SchoolManagement.Form1
Public Class InterviewResults
    Private Access As New DBControl

    Public Sub LoadInterviews()
        Access.ExecQuery("SELECT ParentID AS [Parent ID], InterviewDate AS [Interview Date], IntervieweeName AS [Name],
                    IntervieweeSurname AS Surname, InterviewDets AS [Interview Details]
                    FROM ParentInterviewResults")

        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        ' Fills DataGridView
        dgvInterview.DataSource = Access.DBDT

        ' Autosize DGV column width
        dgvInterview.AutoResizeColumns()
        dgvInterview.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub InterviewResults_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Parent Interview Results"
        LoadInterviews()
    End Sub

    ' Form Themes Colours
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.MediumOrchid
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
        Me.dgvInterview.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvInterview.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvInterview.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrayToolStripMenuItem.Click
        Me.dgvInterview.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvInterview.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvInterview.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvInterview.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvInterview.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvInterview.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvInterview.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvInterview.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvInterview.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvInterview.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvInterview.BackgroundColor = Color.White
    End Sub

    ' Textbox Validation
    Private Sub TextBox_Validation(sender As Object, e As EventArgs) Handles ParentID.TextChanged, PNameBox.TextChanged,
            PSurnameBox.TextChanged, ResultsBox.TextChanged
        If Not String.IsNullOrWhiteSpace(ParentID.Text) And
                Not String.IsNullOrWhiteSpace(PNameBox.Text) And
Not String.IsNullOrWhiteSpace(PSurnameBox.Text) And
Not String.IsNullOrWhiteSpace(ResultsBox.Text) Then
            SaveStrip.Enabled = True
        End If
    End Sub

    ' Save Interviews Method
    Private Sub SaveInterviews()
        ' Parent Interview Results Table
        Access.AddParam("@parid", ParentID.Text)
        Access.AddParam("@idate", InterviewDate.Value.ToShortDateString)
        Access.AddParam("@pname", PNameBox.Text)
        Access.AddParam("@psurname", PSurnameBox.Text)
        Access.AddParam("@interdets", ResultsBox.Text)

        Access.ExecQuery("INSERT INTO ParentInterviewResults (ParentID, InterviewDate, IntervieweeName, IntervieweeSurname, InterviewDets) " &
                         "VALUES (@parid, idate, pname, psurname, interdets); ")

        ' Reports and aborts any errors 
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception) : Exit Sub
        End If
        ' Success Message 
        MsgBox("Interview Results Added Successfully!", MsgBoxStyle.Information, "Success!")
        LoadInterviews()
    End Sub

    ' Save Button
    Private Sub SaveStrip_Click(sender As Object, e As EventArgs) Handles SaveStrip.Click
        SaveInterviews()
    End Sub

    ' Clear Button
    Private Sub ClearStrip_Click(sender As Object, e As EventArgs) Handles ClearStrip.Click
        ParentID.Text = ""
        PNameBox.Text = ""
        PSurnameBox.Text = ""
        InterviewDate.Value = Date.Now
        ResultsBox.Text = ""
        SaveStrip.Enabled = False
    End Sub

    ' Exit Button
    Private Sub ExitStrip_Click(sender As Object, e As EventArgs) Handles ExitStrip.Click
        Me.Close()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        EditInterviewResults.Show()
    End Sub
End Class