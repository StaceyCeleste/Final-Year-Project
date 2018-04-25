Imports SchoolManagement.Form1
Public Class ReligiousOrgs
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub LoadOrganisations()
        Access.ExecQuery("SELECT OrgID AS [Organisation ID], OrganisationType AS [Organisation Type], OrgName AS [Name of Organisation],
                            [Address], Suburb, PCode AS [Postal Code], TelNumber AS Telephone, AltTelNumber AS [Alternate Number],
                            ContactPerson AS [Contact Person], Email
                            FROM ReligiousOrgs")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        dgvOrganisations.DataSource = Access.DBDT
        dgvOrganisations.AutoResizeColumns()
        dgvOrganisations.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub ReligiousOrgs_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Religious Organisations"
        LoadOrganisations()
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
        Me.dgvOrganisations.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvOrganisations.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvOrganisations.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvOrganisations.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvOrganisations.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvOrganisations.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvOrganisations.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvOrganisations.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvOrganisations.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvOrganisations.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvOrganisations.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvOrganisations.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvOrganisations.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvOrganisations.BackgroundColor = Color.White
    End Sub

    Private Sub NameBox_TextChanged(sender As Object, e As EventArgs) Handles NameBox.TextChanged
        Dim OrgID As Integer
        Dim Cyear As String = DateTime.Now.ToString("yy")
        Dim OTotal As Integer
        OTotal = dgvOrganisations.Rows.Count + 1
        Try
            If Not String.IsNullOrWhiteSpace(NameBox.Text) Then
                OrgID = Cyear &
                    OTotal = +1
                OTotal.ToString()
            End If
            OrgID = Cyear & OTotal.ToString
        Catch ex As Exception
            MsgBox("Error Generating Organisation ID!", MsgBoxStyle.Critical, "Error!")
        End Try
        OrganID.Text = "R-Org" & OrgID.ToString
    End Sub

    Private Sub Textbox_validation(sender As Object, e As EventArgs) Handles AddressBox.TextChanged, NameBox.TextChanged, SuburbBox.TextChanged,
            CodeBox.TextChanged, TelBox.TextChanged, AltNumBox.TextChanged, ContactBox.TextChanged, EmailBox.TextChanged
        If Not String.IsNullOrWhiteSpace(NameBox.Text) And
            Not String.IsNullOrWhiteSpace(AddressBox.Text) And
            Not String.IsNullOrWhiteSpace(SuburbBox.Text) And
            Not String.IsNullOrWhiteSpace(CodeBox.Text) And
            Not String.IsNullOrWhiteSpace(TelBox.Text) And
            Not String.IsNullOrWhiteSpace(AltNumBox.Text) And
            Not String.IsNullOrWhiteSpace(ContactBox.Text) And
            Not String.IsNullOrWhiteSpace(EmailBox.Text) Then
            SaveBtn.Enabled = True
        End If
    End Sub

    Private Sub SaveOrgs()
        Access.AddParam("@oid", OrganID.Text)
        Access.AddParam("@otype", TypeBox.GetItemText(TypeBox.SelectedItem))
        Access.AddParam("@oname", NameBox.Text)
        Access.AddParam("@add", AddressBox.Text)
        Access.AddParam("@subb", SuburbBox.Text)
        Access.AddParam("@pcode", CodeBox.Text)
        Access.AddParam("@tel", TelBox.Text)
        Access.AddParam("@alt", AltNumBox.Text)
        Access.AddParam("@cpers", ContactBox.Text)
        Access.AddParam("@email", EmailBox.Text)

        Access.ExecQuery("INSERT INTO ReligiousOrgs (OrgID, OrganisationType, OrgName, [Address], Suburb, PCode, TelNumber, AltTelNumber, ContactPerson, Email) " &
                         "VALUES (@oid, @otype, @oname, @add, @subb, @pcode, @tel, @alt, @cpers, @email); ")
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception)
        End If
        MsgBox("Religious Organisation Added Successfully!", MsgBoxStyle.Information, "Success!")
        LoadOrganisations()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        SaveOrgs()
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        OrganID.Text = "0"
        TypeBox.SelectedIndex = -1
        NameBox.Text = ""
        AddressBox.Text = ""
        SuburbBox.Text = ""
        CodeBox.Text = ""
        TelBox.Text = ""
        AltNumBox.Text = ""
        ContactBox.Text = ""
        EmailBox.Text = ""
        SaveBtn.Enabled = False
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class