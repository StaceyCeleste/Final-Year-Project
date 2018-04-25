Imports SchoolManagement.Form1
Public Class LocalCouncillors
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub LoadCouncillors()
        Access.ExecQuery("SELECT CouncillorID AS [Councillor ID], FirstName AS [Name], Surname, Gender, CellNumber AS Cellphone,
                            HomeTel AS [Home Number], WorkTel AS [Work Number], FaxNumber AS [Fax Number], Email, WardNumber AS [Ward Number], Party
                            FROM LocalCouncillors")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        dgvCouncillors.DataSource = Access.DBDT
        dgvCouncillors.AutoResizeColumns()
        dgvCouncillors.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub LocalCouncillors_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Local Councillors"
        LoadCouncillors()
    End Sub

    ' Form Theme Colours
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.Plum
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
        Me.dgvCouncillors.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvCouncillors.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvCouncillors.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvCouncillors.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvCouncillors.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvCouncillors.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvCouncillors.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvCouncillors.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvCouncillors.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvCouncillors.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvCouncillors.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvCouncillors.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvCouncillors.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvCouncillors.BackgroundColor = Color.White
    End Sub

    Private Sub NameBox_TextChanged(sender As Object, e As EventArgs) Handles NameBox.TextChanged
        Dim CouncillorID As Integer
        Dim Cyear As String = DateTime.Now.ToString("yy")
        Dim CTotal As Integer
        CTotal = dgvCouncillors.Rows.Count + 1
        Try
            If Not String.IsNullOrWhiteSpace(NameBox.Text) Then
                CouncillorID = Cyear &
                    CTotal = CTotal + 1
                CTotal.ToString()
            End If
            CouncillorID = Cyear & CTotal.ToString
        Catch ex As Exception
            MsgBox("Error Generating Councillor ID!", MsgBoxStyle.Critical, "Error!")
        End Try
        CouncilID.Text = "CLR" & CouncillorID.ToString
    End Sub

    Private Sub TextBox_Validation(sender As Object, e As EventArgs) Handles SurnameBox.TextChanged, NameBox.TextChanged, WardBox.TextChanged,
            PartyBox.TextChanged, CellBox.TextChanged, HomeBox.TextChanged, WorkBox.TextChanged, FaxBox.TextChanged, EmailBox.TextChanged
        If Not String.IsNullOrWhiteSpace(NameBox.Text) And
                Not String.IsNullOrWhiteSpace(SurnameBox.Text) And
                Not String.IsNullOrWhiteSpace(WardBox.Text) And
                Not String.IsNullOrWhiteSpace(PartyBox.Text) And
                Not String.IsNullOrWhiteSpace(CellBox.Text) And
                Not String.IsNullOrWhiteSpace(CellBox.Text) And
                Not String.IsNullOrWhiteSpace(HomeBox.Text) And
                Not String.IsNullOrWhiteSpace(WorkBox.Text) And
                Not String.IsNullOrWhiteSpace(FaxBox.Text) And
                Not String.IsNullOrWhiteSpace(EmailBox.Text) Then
            SaveBtn.Enabled = True
        End If
    End Sub

    Private Sub SaveCouncillors()
        Access.AddParam("@cid", CouncilID.Text)
        Access.AddParam("@fname", NameBox.Text)
        Access.AddParam("@sur", SurnameBox.Text)
        If (MaleBtn.Checked = True) Then
            MaleBtn.Text = "Male"
            Access.AddParam("@gen", MaleBtn.Text)
        Else
            If (FemaleBtn.Checked - True) Then
                FemaleBtn.Text = "Female"
                Access.AddParam("@gen", FemaleBtn.Text)
            End If
        End If
        Access.AddParam("@cel", CellBox.Text)
        Access.AddParam("@home", HomeBox.Text)
        Access.AddParam("@work", WorkBox.Text)
        Access.AddParam("@fax", FaxBox.Text)
        Access.AddParam("@email", EmailBox.Text)
        Access.AddParam("@ward", WardBox.Text)
        Access.AddParam("@party", PartyBox.Text)

        Access.ExecQuery("INSERT INTO LocalCouncillors (CouncillorID, FirstName, Surname, Gender, CellNumber, HomeTel, WorkTel, FaxNumber, Email, WardNumber, Party) " &
                         "VALUES (@cid, @fname, @sur, @gen, @cel, @home, @work, @fax, @email, @ward, @party); ")
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception)
        End If
        MsgBox("Local Councillor Information Saved Successfully!", MsgBoxStyle.Information, "Success!")
        LoadCouncillors()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        SaveCouncillors()
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        CouncilID.Text = 0
        NameBox.Text = ""
        SurnameBox.Text = ""
        MaleBtn.Checked = False
        FemaleBtn.Checked = False
        CellBox.Text = ""
        HomeBox.Text = ""
        WorkBox.Text = ""
        FaxBox.Text = ""
        EmailBox.Text = ""
        WardBox.Text = ""
        PartyBox.Text = ""
        SaveBtn.Enabled = False
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class