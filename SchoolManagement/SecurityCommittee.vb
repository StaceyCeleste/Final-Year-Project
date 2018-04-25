Imports SchoolManagement.Form1
Public Class SecurityCommittee
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    ' Load Committee Method
    Private Sub LoadCommittee()
        Access.ExecQuery("SELECT CommitteeID AS [Committee ID], MemberName AS [Member Name], Designation, HomeTel AS Telephone, Cellphone, Email
                            FROM SecurityCommittee")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' Fills DataGridView
        dgvCommittee.DataSource = Access.DBDT

        ' Auto sizes Columns
        dgvCommittee.AutoResizeColumns()
        dgvCommittee.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    ' Load Staff NAmes Committee
    Private Sub LoadStaff()
        Access.ExecQuery("SELECT StaffName + ' ' + StaffSurname AS FullName FROM StaffDetails")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        NameBox.DataSource = Access.DBDT
        If Access.DBDT.Rows.Count > 0 Then
            NameBox.DataSource = Access.DBDT
            NameBox.ValueMember = "FullName"
            NameBox.DisplayMember = "FullName"
            NameBox.SelectedIndex = -1
        End If
    End Sub

    Private Sub SecurityCommittee_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Security Committee"
        LoadStaff()
        LoadCommittee()
    End Sub

    ' Form Theme Colours
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.MediumSlateBlue
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
        Me.dgvCommittee.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvCommittee.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvCommittee.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvCommittee.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvCommittee.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvCommittee.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvCommittee.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvCommittee.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvCommittee.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvCommittee.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvCommittee.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvCommittee.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvCommittee.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvCommittee.BackgroundColor = Color.White
    End Sub

    ' Auto Generates Committee ID 
    Private Sub DesignationBox_TextChanged(sender As Object, e As EventArgs) Handles DesignationBox.TextChanged
        Dim ComID As Integer
        Dim Cyear As String = DateTime.Now.ToString("yy")
        Dim CTotal As Integer
        CTotal = dgvCommittee.Rows.Count
        Try
            If Not String.IsNullOrEmpty(DesignationBox.Text) Then
                ComID = Cyear &
                    CTotal = +1
                CTotal.ToString()
            End If
            ComID = Cyear & CTotal.ToString
        Catch ex As Exception
            MsgBox("Error Generating Committee ID!", MsgBoxStyle.Critical, "Error!")
        End Try
        CommitteeLabel.Text = "SEC" & ComID.ToString
    End Sub

    ' Textbox Validation
    Private Sub TelBox_TextChanged(sender As Object, e As EventArgs) Handles TelBox.TextChanged, DesignationBox.TextChanged,
            CellBox.TextChanged, EmailBox.TextChanged
        If Not String.IsNullOrWhiteSpace(DesignationBox.Text) And
                Not String.IsNullOrWhiteSpace(TelBox.Text) And
                Not String.IsNullOrWhiteSpace(CellBox.Text) And
                Not String.IsNullOrWhiteSpace(EmailBox.Text) Then
            SaveBtn.Enabled = True
        End If
    End Sub

    ' Save Security Committee Details
    Private Sub SaveSecurityCommittee()
        Access.AddParam("@cid", CommitteeLabel.Text)
        Access.AddParam("@mname", NameBox.GetItemText(NameBox.SelectedItem))
        Access.AddParam("@des", DesignationBox.Text)
        Access.AddParam("@htel", TelBox.Text)
        Access.AddParam("@cel", CellBox.Text)
        Access.AddParam("email", EmailBox.Text)

        Access.ExecQuery("INSERT INTO SecurityCommittee (CommitteeID, MemberName, Designation, HomeTel, Cellphone, Email) " &
                         "VALUES (@cid, @mname, @des, @htel, @cel, @email); ")
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception)
        End If
        MsgBox("New Committee Member Added Successfully!", MsgBoxStyle.Information, "Success!")
        LoadCommittee()
    End Sub

    ' Save Button
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        SaveSecurityCommittee()
    End Sub

    ' Clear Button
    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        CommitteeLabel.Text = 0
        NameBox.SelectedIndex = -1
        DesignationBox.Text = ""
        TelBox.Text = ""
        CellBox.Text = ""
        EmailBox.Text = ""
        SaveBtn.Enabled = False
    End Sub

    ' Exit Button
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class