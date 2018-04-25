Imports SchoolManagement.Form1
Public Class SchoolLeavers
    Private Accessor As New DBControl

    Private Sub SchoolLeavers_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - School Leavers"
        DGVLeavers_Refresh()
    End Sub

    Public Sub DGVLeavers_Refresh()

        Accessor.ExecQuery("SELECT TrackingNum AS [Tracking Number], DateOfExit AS [Date of Exit], StudentName AS [Student Name],
                            StudentSurname AS Surname, ExitReason AS [Reason for Exit]
                            FROM SchoolLeavers")

        dgvLeavers.DataSource = Accessor.DBDT

        ' Autosize DGV column width
        dgvLeavers.AutoResizeColumns()
        dgvLeavers.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells

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

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.BackColor = Color.LightGreen
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
        Me.dgvLeavers.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvLeavers.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvLeavers.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvLeavers.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvLeavers.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem1.Click
        Me.dgvLeavers.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvLeavers.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvLeavers.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvLeavers.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvLeavers.BackgroundColor = Color.Pink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvLeavers.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvLeavers.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvLeavers.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvLeavers.BackgroundColor = Color.White
    End Sub


    ' Validates TextBoxes - Ensures Data is Entered in TextBoxes Before Enabling Save Button
    Private Sub TextBox_Validation(sender As Object, e As EventArgs) Handles TrackBox.TextChanged, NameBox.TextChanged,
            SurnameBox.TextChanged, ExitBox.TextChanged

        If Not String.IsNullOrWhiteSpace(TrackBox.Text) And
                Not String.IsNullOrWhiteSpace(NameBox.Text) And
                Not String.IsNullOrWhiteSpace(SurnameBox.Text) And
                Not String.IsNullOrWhiteSpace(ExitBox.Text) Then
            Save.Enabled = True
        End If

    End Sub

    ' Private Sub Creates Save Button Method to be used with Save Button
    Private Sub AddSchoolLeavers()

        ' Adds Parameters
        Accessor.AddParam("@track", TrackBox.Text)
        Accessor.AddParam("@exitdate", ExitDate.Value.ToShortDateString)
        Accessor.AddParam("@fname", NameBox.Text)
        Accessor.AddParam("@surname", SurnameBox.Text)
        Accessor.AddParam("@exit", ExitBox.Text)

        Accessor.ExecQuery("INSERT INTO SchoolLeavers (TrackingNum, DateOfExit, StudentName, StudentSurname, ExitReason) " &
            "VALUES (@track, @exitdate, @fname, @surname, @exit); ")

        ' Reports and aborts any errors
        If Not String.IsNullOrEmpty(Accessor.Exception) Then
            MsgBox(Accessor.Exception) : Exit Sub
        End If
        ' Success Message 
        MsgBox("Student Added To School Leavers List Successfully!", MsgBoxStyle.Information, "Success!")

        Me.DGVLeavers_Refresh()

    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        AddSchoolLeavers()
    End Sub

    Private Sub ClearAll_Click(sender As Object, e As EventArgs) Handles ClearAll.Click
        TrackBox.Text = ""
        ExitDate.Value = Date.Now
        NameBox.Text = ""
        SurnameBox.Text = ""
        ExitBox.Text = ""
        Save.Enabled = False
    End Sub

    Private Sub ExitForm_Click(sender As Object, e As EventArgs) Handles ExitForm.Click
        Me.Close()
    End Sub
    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        EditSchoolLeavers.Show()
    End Sub

End Class