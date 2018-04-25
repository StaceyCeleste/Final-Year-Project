Imports SchoolManagement.Form1
Public Class PrevocationalPhase
    Private Access As New DBControl
    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub LoadPrevoc()
        Access.ExecQuery("SELECT [ID], TrackingNum AS [Tracking Number], StudentName AS Student, PreYear AS [Year], PreTerm AS [Term],
                            Hospitality, Gardening, ArtsAndCrafts AS [Arts and Crafts], WoodWork AS [Wood Work], VehWash AS [Vehicle Washing], 
                            NeedleWork AS [Needle Work], BeadWork AS [Bead Work], TotalMarks AS [Results]
                            FROM PrevocPhase")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        dgvPrevoc.DataSource = Access.DBDT
        dgvPrevoc.AutoResizeColumns()
        dgvPrevoc.AutoSizeColumnsMode =
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

    Private Sub PrevocationalPhase_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Prevocational Phase Learner Records"
        LoadStudents()
        LoadPrevoc()
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
        Me.dgvPrevoc.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvPrevoc.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvPrevoc.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvPrevoc.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvPrevoc.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvPrevoc.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvPrevoc.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvPrevoc.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvPrevoc.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvPrevoc.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvPrevoc.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvPrevoc.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvPrevoc.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvPrevoc.BackgroundColor = Color.White
    End Sub

    Private Sub Textbox_Validation(sender As Object, e As EventArgs) Handles TrackBox.TextChanged, HospBox.TextChanged, GardenBox.TextChanged,
            ACbox.TextChanged, WWbox.TextChanged, VWbox.TextChanged, NWbox.TextChanged, BWbox.TextChanged
        If Not String.IsNullOrWhiteSpace(TrackBox.Text) And
                Not String.IsNullOrWhiteSpace(HospBox.Text) And
                Not String.IsNullOrWhiteSpace(GardenBox.Text) And
                Not String.IsNullOrWhiteSpace(ACbox.Text) And
                Not String.IsNullOrWhiteSpace(WWbox.Text) And
                Not String.IsNullOrWhiteSpace(VWbox.Text) And
                Not String.IsNullOrWhiteSpace(NWbox.Text) And
                Not String.IsNullOrWhiteSpace(BWbox.Text) Then
            SaveAllBtn.Enabled = True
        End If
    End Sub

    Private Sub BWbox_TextChanged(sender As Object, e As EventArgs) Handles BWbox.TextChanged
        Dim TotalPercent As Decimal = 0
        Dim hosp As String = HospBox.Text
        Dim gard As String = GardenBox.Text
        Dim ac As String = ACbox.Text
        Dim ww As String = WWbox.Text
        Dim vw As String = VWbox.Text
        Dim nw As String = NWbox.Text
        Dim bw As String = BWbox.Text
        If Not String.IsNullOrEmpty(BWbox.Text) Then
            Try
                TotalPercent = (Convert.ToDecimal(hosp) + Convert.ToDecimal(gard) + Convert.ToDecimal(ac) + Convert.ToDecimal(ww) + Convert.ToDecimal(vw) + Convert.ToDecimal(nw) + Convert.ToDecimal(bw)) / 7
                TotalLabel.Text = Decimal.Round(TotalPercent, 2)
            Catch ex As Exception
                MsgBox("Error Calculating Final Result!", MsgBoxStyle.Critical, "Error!")
            End Try
        End If
    End Sub

    Private Sub SavePrevoc()
        Access.AddParam("@track", TrackBox.Text)
        Access.AddParam("@sname", StudentBox.GetItemText(StudentBox.SelectedItem))
        Access.AddParam("@pyear", YearBox.GetItemText(YearBox.SelectedItem))
        Access.AddParam("@pterm", TermBox.GetItemText(TermBox.SelectedItem))
        Access.AddParam("@hosp", Convert.ToDecimal(HospBox.Text))
        Access.AddParam("@gar", Convert.ToDecimal(GardenBox.Text))
        Access.AddParam("@ac", Convert.ToDecimal(ACbox.Text))
        Access.AddParam("@ww", Convert.ToDecimal(WWbox.Text))
        Access.AddParam("@vw", Convert.ToDecimal(VWbox.Text))
        Access.AddParam("@nw", Convert.ToDecimal(NWbox.Text))
        Access.AddParam("@bw", Convert.ToDecimal(BWbox.Text))
        Access.AddParam("@tmark", Convert.ToDecimal(TotalLabel.Text))

        Access.ExecQuery("INSERT INTO PrevocPhase (TrackingNum, StudentName, PreYear, PreTerm, Hospitality, Gardening, ArtsAndCrafts, WoodWork, VehWash, NeedleWork, BeadWork, TotalMarks) " &
                         "VALUES (@track, @sname, @pyear, @pterm, @hosp, @gar, @ac, @ww, @vw, @nw, @bw, @tmark); ")

        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception)
        End If
        MsgBox("Learner Record Saved Successfully!", MsgBoxStyle.Information, "Success!")
        LoadPrevoc()
    End Sub

    Private Sub SaveAllBtn_Click(sender As Object, e As EventArgs) Handles SaveAllBtn.Click
        SavePrevoc()
    End Sub

    Private Sub ClearAllBtn_Click(sender As Object, e As EventArgs) Handles ClearAllBtn.Click
        TrackBox.Text = ""
        StudentBox.SelectedIndex = -1
        YearBox.SelectedIndex = -1
        TermBox.SelectedIndex = -1
        HospBox.Text = ""
        GardenBox.Text = ""
        ACbox.Text = ""
        WWbox.Text = ""
        VWbox.Text = ""
        NWbox.Text = ""
        BWbox.Text = ""
        TotalLabel.Text = 0
        SaveAllBtn.Enabled = False
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub IntermediateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntermediateToolStripMenuItem.Click
        IntermediatePhase.Show()
    End Sub

    Private Sub JuniorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JuniorToolStripMenuItem.Click
        JuniorPhase.Show()
    End Sub
End Class