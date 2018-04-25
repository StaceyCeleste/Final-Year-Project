Imports SchoolManagement.Form1
Public Class SGBMembers
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    ' Load SGB Members Method
    Public Sub LoadSGBMembers()
        Access.ExecQuery("SELECT MemberID AS [Member ID], SGBName AS [Name], SGBSurname AS Surname, SGBRank AS [Rank]                            
                           FROM SGBMemberDets")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        ' Fills DataGridView
        dgvSGB.DataSource = Access.DBDT

        ' Autosize DGV column width
        dgvSGB.AutoResizeColumns()
        dgvSGB.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub SGBMembers_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " SGB Member Details"
        LoadSGBMembers()
    End Sub

    ' Form Theme Colours
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.MediumPurple
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
        Me.dgvSGB.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvSGB.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvSGB.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrayToolStripMenuItem.Click
        Me.dgvSGB.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvSGB.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvSGB.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvSGB.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvSGB.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvSGB.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvSGB.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvSGB.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvSGB.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvSGB.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvSGB.BackgroundColor = Color.White
    End Sub

    ' Auto Generates SGB Member ID When Text Is Entered Into The Textbox
    Private Sub NameBox_TextChanged(sender As Object, e As EventArgs) Handles NameBox.TextChanged
        Dim SgbMemberID As Integer
        Dim Cyear As String = DateTime.Now.ToString("yy")
        Dim SgbTotal As Integer
        SgbTotal = dgvSGB.RowCount
        Try
            If Not String.IsNullOrWhiteSpace(NameBox.Text) Then
                SgbMemberID = Cyear &
                    SgbTotal = +1
                SgbTotal.ToString("00")
            End If
            SgbMemberID = Cyear & SgbTotal.ToString
        Catch ex As Exception
            MsgBox("Error Generating SGB Men=mber ID!", MsgBoxStyle.Critical, "Error!")
        End Try
        MemberLabel.Text = "SGB-" & SgbMemberID.ToString
    End Sub

    ' Textbox Validation
    Private Sub TextBox_Validation(sender As Object, e As EventArgs) Handles NameBox.TextChanged, SurnameBox.TextChanged,
        HomeTelBox.TextChanged, CellphoneBox.TextChanged, EmContBox.TextChanged, ContactBox.TextChanged, EmailBox.TextChanged
        If Not String.IsNullOrWhiteSpace(NameBox.Text) And
Not String.IsNullOrWhiteSpace(SurnameBox.Text) And
Not String.IsNullOrWhiteSpace(HomeTelBox.Text) And
Not String.IsNullOrWhiteSpace(CellphoneBox.Text) And
Not String.IsNullOrWhiteSpace(EmContBox.Text) And
Not String.IsNullOrWhiteSpace(ContactBox.Text) And
Not String.IsNullOrWhiteSpace(EmailBox.Text) Then
            SaveStrip.Enabled = True
        End If
    End Sub

    ' Save New SGB Member Method
    Private Sub SaveSGB()
        ' SGB Member Details Table
        Access.AddParam("@memid", MemberLabel.Text)
        Access.AddParam("@sname", NameBox.Text)
        Access.AddParam("@sur", SurnameBox.Text)
        Access.AddParam("@rank", RankBox.GetItemText(RankBox.SelectedItem))

        Access.ExecQuery("INSERT INTO SGBMemberDets (MemberID, SGBName, SGBSurname, SGBRank) " &
                         "VALUES (@memid, @sname, @sur, @rank); ")

        ' SGB Contact Table
        Access.AddParam("@memid", MemberLabel.Text)
        Access.AddParam("@sname", NameBox.Text)
        Access.AddParam("@sur", SurnameBox.Text)
        Access.AddParam("@htel", HomeTelBox.Text)
        Access.AddParam("@ctel", CellphoneBox.Text)
        Access.AddParam("@ecnum", EmContBox.Text)
        Access.AddParam("@cname", ContactBox.Text)
        Access.AddParam("@email", EmailBox.Text)

        Access.ExecQuery("INSERT INTO SGBContact (MemberID, SGBName, SGBSurname, HomeTel, CellTel, EmContNum, ContactName, SGBEmail) " &
                         "VALUES (@memid, @sname, @sur, @htel, @ctel, @ecnum, @cname, @email); ")

        ' Reports and aborts any errors 
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception) : Exit Sub
        End If
        ' Success Message 
        MsgBox("New SGB Member Added Successfully!", MsgBoxStyle.Information, "Success!")
        LoadSGBMembers()
    End Sub

    ' Save Button
    Private Sub SaveStrip_Click(sender As Object, e As EventArgs) Handles SaveStrip.Click
        SaveSGB()
    End Sub

    ' Clear Button
    Private Sub ClearStrip_Click(sender As Object, e As EventArgs) Handles ClearStrip.Click
        MemberLabel.Text = 0
        NameBox.Text = ""
        SurnameBox.Text = ""
        RankBox.SelectedIndex = -1
        HomeTelBox.Text = ""
        CellphoneBox.Text = ""
        EmContBox.Text = ""
        ContactBox.Text = ""
        EmailBox.Text = ""
        SaveStrip.Enabled = False
    End Sub

    ' Exit Button
    Private Sub ExitStrip_Click(sender As Object, e As EventArgs) Handles ExitStrip.Click
        Me.Close()
    End Sub

    Private Sub DetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailsToolStripMenuItem.Click
        LoadSGBMembers()
    End Sub

    Public Sub LoadContact()
        Access.ExecQuery("SELECT MemberID AS [Member ID], SGBName AS [Name], SGBSurname AS Surname, HomeTel AS [Home Number], 
                            CellTel As Cellphone, EmContNum As [Emergency Contact], ContactName AS [Contact Person], SGBEmail AS Email
                            FROM SGBContact")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        ' Fills DataGridView
        dgvSGB.DataSource = Access.DBDT

        ' Autosize DGV column width
        dgvSGB.AutoResizeColumns()
        dgvSGB.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub ContactToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactToolStripMenuItem.Click
        LoadContact()
    End Sub

    Private Sub DetailsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DetailsToolStripMenuItem1.Click
        EditSGBDets.Show()
    End Sub

    Private Sub ContactToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ContactToolStripMenuItem1.Click
        EditSGBContact.Show()
    End Sub
End Class