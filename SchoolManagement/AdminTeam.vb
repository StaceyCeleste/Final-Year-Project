Imports SchoolManagement.Form1
Public Class AdminTeam
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub AdminTeam_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Administrative Team"
        GridRefresh()
    End Sub

    Public Sub GridRefresh()

        Access.ExecQuery("SELECT PersalNum AS [Persal Number], StaffID AS [Staff ID], StaffName AS [Name], 
                            StaffSurname AS Surname, StaffRank AS Rank
                               FROM AdminTeam")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        dgvAdmin.DataSource = Access.DBDT

        ' Autosize DGV column width
        dgvAdmin.AutoResizeColumns()
        dgvAdmin.AutoSizeColumnsMode =
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
        Me.dgvAdmin.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvAdmin.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvAdmin.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvAdmin.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvAdmin.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvAdmin.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvAdmin.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvAdmin.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvAdmin.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvAdmin.BackgroundColor = Color.Pink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvAdmin.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvAdmin.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvAdmin.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvAdmin.BackgroundColor = Color.White
    End Sub

    Private Sub TextBox_Validation(sender As Object, e As EventArgs) Handles PersalBox.TextChanged, StaffIdBox.TextChanged,
            StaffNameBox.TextChanged, StaffSurnameBox.TextChanged, StaffRankBox.TextChanged
        If Not String.IsNullOrWhiteSpace(PersalBox.Text) And
                Not String.IsNullOrWhiteSpace(StaffIdBox.Text) And
            Not String.IsNullOrWhiteSpace(StaffNameBox.Text) And
            Not String.IsNullOrWhiteSpace(StaffSurnameBox.Text) Then
            SaveStripBtn.Enabled = True
        End If
    End Sub

    Private Sub ExitStripBtn_Click(sender As Object, e As EventArgs) Handles ExitStripBtn.Click
        Me.Close()
    End Sub

    Private Sub ClearAllBtn_Click(sender As Object, e As EventArgs) Handles ClearAllBtn.Click
        PersalBox.Text = ""
        StaffIdBox.Text = ""
        StaffNameBox.Text = ""
        StaffSurnameBox.Text = ""
        StaffRankBox.SelectedIndex = -1
        SaveStripBtn.Enabled = False
    End Sub

    Private Sub AddAdminTeam()
        ' Adds Parameters
        Access.AddParam("@persal", PersalBox.Text)
        Access.AddParam("@staffid", StaffIdBox.Text)
        Access.AddParam("@sname", StaffNameBox.Text)
        Access.AddParam("@surname", StaffSurnameBox.Text)
        Access.AddParam("@ranks", StaffRankBox.GetItemText(StaffRankBox.SelectedItem))

        Access.ExecQuery("INSERT INTO AdminTeam (PersalNum, StaffID, StaffName, StaffSurname, StaffRank) " &
            "values (@persal, @staffid, @sname, @surname, @ranks); ")

        ' Reports and aborts any errors
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception) : Exit Sub
        End If
        ' Success Message 
        MsgBox("New Admin Member Successfully Added!")

        Me.GridRefresh()

    End Sub

    Private Sub SaveStripBtn_Click(sender As Object, e As EventArgs) Handles SaveStripBtn.Click
        AddAdminTeam()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        EditAdmin.Show()
    End Sub
End Class