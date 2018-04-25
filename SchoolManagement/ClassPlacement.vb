Imports SchoolManagement.Form1
Public Class ClassPlacement
    Private Access As New DBControl

    Private Sub ClassPlacement_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Class Placements"
        LoadCombo()
        LoadPlacements()
    End Sub

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Public Sub LoadPlacements()

        Access.ExecQuery("SELECT [ID], ClassID AS [Class ID], Phase, StudentName AS [Student Name]
                            FROM ClassPlacements")

        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        ' Fills DataGridView
        dgvPlacements.DataSource = Access.DBDT

        ' Autosize DGV column width
        dgvPlacements.AutoResizeColumns()
        dgvPlacements.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells

    End Sub

    Private Sub LoadCombo()
        Access.ExecQuery("Select * From Classes")

        ClassIDCombo.DataSource = Access.DBDT
        If Access.DBDT.Rows.Count > 0 Then
            ClassIDCombo.DataSource = Access.DBDT
            ClassIDCombo.ValueMember = "ClassID"
            ClassIDCombo.DisplayMember = "ClassID"
        End If

        Access.ExecQuery("Select StuName + ' ' + StuSurname AS FullName From StuDetails")

        StudentNameBox.DataSource = Access.DBDT
        If Access.DBDT.Rows.Count > 0 Then
            StudentNameBox.DataSource = Access.DBDT
            StudentNameBox.ValueMember = "FullName"
            StudentNameBox.DisplayMember = "FullName"
        End If

    End Sub

    ' Form Theme Colours -----------------------------------------------------------------------------------------------------------------
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

    ' DataGridView Theme Colours -----------------------------------------------------------------------------------------------------
    Private Sub DefaultToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem1.Click
        Me.dgvPlacements.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvPlacements.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvPlacements.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvPlacements.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvPlacements.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvPlacements.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvPlacements.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvPlacements.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvPlacements.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvPlacements.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvPlacements.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvPlacements.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvPlacements.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvPlacements.BackgroundColor = Color.White
    End Sub


    ' Save Class Placements Method
    Private Sub SavePlacements()
        Access.AddParam("@classid", ClassIDCombo.GetItemText(ClassIDCombo.SelectedItem))
        Access.AddParam("@phase", PhaseBox.GetItemText(PhaseBox.SelectedItem))
        Access.AddParam("@sname", StudentNameBox.GetItemText(StudentNameBox.SelectedItem))

        Access.ExecQuery("INSERT INTO ClassPlacements (ClassID, Phase, StudentName) " &
                         "VALUES (@classid, @phase, @sname); ")

        ' Reports and aborts any errors
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception) : Exit Sub
        End If
        ' Success Message 
        MsgBox("New Class Placements Added Successfully!", MsgBoxStyle.Information, "Success!")

        LoadPlacements()

    End Sub

    ' Save Button
    Private Sub SaveAllBtn_Click(sender As Object, e As EventArgs) Handles SaveAllBtn.Click
        SavePlacements()
    End Sub

    ' Clear All Button Clears All Textboxes and Resets ComboBoxes
    Private Sub ClearAllBtn_Click(sender As Object, e As EventArgs) Handles ClearAllBtn.Click
        ClassIDCombo.SelectedIndex = -1
        PhaseBox.SelectedIndex = -1
        StudentNameBox.SelectedIndex = -1
    End Sub

    ' Exit Button
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        EditClassPlacements.Show()
    End Sub
End Class