﻿Imports SchoolManagement.Form1
Public Class DonationsSponsors
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return NotEmpty(text)
    End Function

    Private Sub LoadDS()
        Access.ExecQuery("SELECT DonationsID AS [ID], DonationDate AS [Date], [DSType] AS [Donation or Sponsor], NatureOfDonation AS [Nature],
                                [Donator], DonationAmnt AS [Amount], DSDetails AS [Details]  
                                FROM DonationsSponsors")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        dgvDS.DataSource = Access.DBDT
        dgvDS.AutoResizeColumns()
        dgvDS.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub DonationsSponsors_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Donations and Sponsors"
        LoadDS()
    End Sub

    ' Form Theme Colours
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.RosyBrown
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
        Me.dgvDS.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvDS.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvDS.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvDS.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvDS.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvDS.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvDS.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvDS.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvDS.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvDS.BackgroundColor = Color.Pink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvDS.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvDS.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvDS.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvDS.BackgroundColor = Color.White
    End Sub

    Private Sub Textbox_Validation(sender As Object, e As EventArgs) Handles NatureBox.TextChanged, DSBox.TextChanged,
           AmountBox.TextChanged, DetailsBox.TextChanged
        If Not String.IsNullOrWhiteSpace(NatureBox.Text) And
                Not String.IsNullOrWhiteSpace(DSBox.Text) And
                Not String.IsNullOrWhiteSpace(AmountBox.Text) And
                Not String.IsNullOrWhiteSpace(DetailsBox.Text) Then
            SaveStripBtn.Enabled = True
        End If
    End Sub

    Private Sub SaveDS()
        Access.AddParam("@ddate", DateBox.Value.ToShortDateString)
        Access.AddParam("@dtype", TypeBox.GetItemText(TypeBox.SelectedItem))
        Access.AddParam("@nat", NatureBox.Text)
        Access.AddParam("@don", DSBox.Text)
        Access.AddParam("@amt", AmountBox.Text)
        Access.AddParam("@dets", DetailsBox.Text)

        Access.ExecQuery("INSERT INTO DonationsSponsors (DonationDate, DSType, NatureOfDonation, Donator, DonationAmnt, DSDetails) " &
                         "VALUES (@ddate, @dtype, @nat, @don, @amt, @dets); ")
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception)
        End If
        MsgBox("New Donation/Sponsor Added Successfully!", MsgBoxStyle.Information, "Success!")
        LoadDS()
    End Sub

    Private Sub SaveStripBtn_Click(sender As Object, e As EventArgs) Handles SaveStripBtn.Click
        SaveDS()
    End Sub

    Private Sub ClearAllBtn_Click(sender As Object, e As EventArgs) Handles ClearAllBtn.Click
        DateBox.Value = Date.Now
        TypeBox.SelectedIndex = -1
        NatureBox.Text = ""
        AmountBox.Text = "R"
        DSBox.Text = ""
        DetailsBox.Text = ""
        SaveStripBtn.Enabled = False
    End Sub

    Private Sub ExitStripBtn_Click(sender As Object, e As EventArgs) Handles ExitStripBtn.Click
        Me.Close()
    End Sub
End Class