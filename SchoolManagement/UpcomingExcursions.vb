Imports SchoolManagement.Form1
Public Class UpcomingExcursions
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub LoadUpcomingEx()
        Access.ExecQuery("SELECT ExcursionID AS [Excursion ID], Venue, ExDate AS [Date], VenueAddress AS [Address], Suburb,
                            PCode AS [Postal Code], Telephone, Email, [Comments]
                            FROM UpcomingExcursions")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        ' Fills DataGridView
        dgvEx.DataSource = Access.DBDT

        ' Autosize DGV column width
        dgvEx.AutoResizeColumns()
        dgvEx.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub UpcomingExcursions_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Upcoming Excursions"
        LoadUpcomingEx()
    End Sub

    ' Form Theme Colours
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.SandyBrown
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
        Me.dgvEx.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvEx.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvEx.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvEx.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvEx.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvEx.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvEx.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvEx.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvEx.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvEx.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvEx.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvEx.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvEx.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvEx.BackgroundColor = Color.White
    End Sub

    ' Auto Generates Excursion ID When User Enters Text in Venue Textbox
    Private Sub VenueBox_TextChanged(sender As Object, e As EventArgs) Handles VenueBox.TextChanged
        Dim ExcursionID As Integer
        Dim Cyear As String = DateTime.Now.ToString("yy")
        Dim ETotal As Integer
        ETotal = dgvEx.RowCount
        Try
            If Not String.IsNullOrWhiteSpace(VenueBox.Text) Then
                ExcursionID = Cyear &
                    ETotal = +1
                ETotal.ToString("0000")
            End If
            ExcursionID = Cyear & ETotal.ToString
        Catch ex As Exception
            MsgBox("Error Generating Excursion ID!", MsgBoxStyle.Critical, "Error!")
        End Try
        ExID.Text = "EXCUR-" & ExcursionID.ToString
    End Sub

    ' Textbox Validation
    Private Sub Textbox_Validation(sender As Object, e As EventArgs) Handles AddressBox.TextChanged, VenueBox.TextChanged,
            SuburbBox.TextChanged, CodeBox.TextChanged, TelBox.TextChanged, EmailBox.TextChanged, CommentsBox.TextChanged
        If Not String.IsNullOrWhiteSpace(VenueBox.Text) And
                Not String.IsNullOrWhiteSpace(AddressBox.Text) And
                Not String.IsNullOrWhiteSpace(SuburbBox.Text) And
                Not String.IsNullOrWhiteSpace(CodeBox.Text) And
                Not String.IsNullOrWhiteSpace(TelBox.Text) And
                Not String.IsNullOrWhiteSpace(EmailBox.Text) And
               Not String.IsNullOrWhiteSpace(CommentsBox.Text) Then
            SaveBtn.Enabled = True
        End If
    End Sub

    ' Save Upcoming Excursions Method
    Private Sub SaveUpcomingEx()
        ' Upcoming Excursions Table
        Access.AddParam("@exid", ExID.Text)
        Access.AddParam("@ven", VenueBox.Text)
        Access.AddParam("@xdate", ExDate.Value.ToShortDateString)
        Access.AddParam("@addr", AddressBox.Text)
        Access.AddParam("@subb", SuburbBox.Text)
        Access.AddParam("@pcode", CodeBox.Text)
        Access.AddParam("@tel", TelBox.Text)
        Access.AddParam("@em", EmailBox.Text)
        Access.AddParam("@comms", CommentsBox.Text)

        Access.ExecQuery("INSERT INTO UpcomingExcursions (ExcursionID, Venue, ExDate, VenueAddress, Suburb, PCode, Telephone, Email, [Comments]) " &
                         "VALUES (@exid, @ven, @xdate, @addr, @subb, @pcode, @tel, @em, @comms); ")
        ' Reports and aborts any errors 
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception) : Exit Sub
        End If
        ' Success Message 
        MsgBox("New Excursion Details Added Successfully!", MsgBoxStyle.Information, "Success!")
        LoadUpcomingEx()
        Excursions.LoadVenues()
    End Sub

    ' Save Button
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        SaveUpcomingEx()
    End Sub

    ' Clear Button, Resets Form
    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        ExID.Text = 0
        VenueBox.Text = ""
        ExDate.Value = Date.Now
        AddressBox.Text = ""
        SuburbBox.Text = ""
        CodeBox.Text = ""
        TelBox.Text = ""
        EmailBox.Text = ""
        CommentsBox.Text = ""
        SaveBtn.Enabled = False
    End Sub

    ' Exit Button
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class