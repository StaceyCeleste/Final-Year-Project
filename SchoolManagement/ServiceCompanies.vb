Imports SchoolManagement.Form1
Public Class ServiceCompanies
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub LoadCompanies()
        Access.ExecQuery("SELECT CompanyID AS [Company ID], Company, [Address], Suburb, PostalCode AS [Postal Code], Province, Telephone, Email
                            FROM ServiceCompanies")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        dgvCompanies.DataSource = Access.DBDT
        dgvCompanies.AutoResizeColumns()
        dgvCompanies.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub ServiceCompanies_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Service Companies"
        LoadCompanies()
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
        Me.dgvCompanies.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvCompanies.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvCompanies.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvCompanies.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvCompanies.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvCompanies.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvCompanies.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvCompanies.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvCompanies.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvCompanies.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvCompanies.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvCompanies.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvCompanies.BackgroundColor = Color.Violet
    End Sub

    Private Sub CompanyBox_TextChanged(sender As Object, e As EventArgs) Handles CompanyBox.TextChanged
        Dim CompanyID As Integer
        Dim Cyear As String = DateTime.Now.ToString("yyyy")
        Dim CTotal As Integer
        CTotal = dgvCompanies.Rows.Count
        Try
            If Not String.IsNullOrWhiteSpace(CompanyBox.Text) Then
                CompanyID = Cyear &
                    CTotal = +1
                CTotal.ToString()
            End If
            CompanyID = Cyear & CTotal.ToString
        Catch ex As Exception
            MsgBox("Error Generating Company ID!", MsgBoxStyle.Critical, "Error!")
        End Try
        CompID.Text = "COM-" & CompanyID.ToString
    End Sub

    Private Sub TextBox_Validation(sender As Object, e As EventArgs) Handles AddressBox.TextChanged, CompanyBox.TextChanged,
            SuburbBox.TextChanged, CodeBox.TextChanged, TelBox.TextChanged, EmailBox.TextChanged
        If Not String.IsNullOrWhiteSpace(CompanyBox.Text) And
                Not String.IsNullOrWhiteSpace(AddressBox.Text) And
                Not String.IsNullOrWhiteSpace(SuburbBox.Text) And
                Not String.IsNullOrWhiteSpace(CodeBox.Text) And
                Not String.IsNullOrWhiteSpace(TelBox.Text) And
                Not String.IsNullOrWhiteSpace(EmailBox.Text) Then
            SaveBtn.Enabled = True
        End If
    End Sub

    Private Sub SaveCompany()
        Access.AddParam("@cid", CompID.Text)
        Access.AddParam("@comp", CompanyBox.Text)
        Access.AddParam("@add", AddressBox.Text)
        Access.AddParam("@subb", SuburbBox.Text)
        Access.AddParam("@pcode", CodeBox.Text)
        Access.AddParam("@prov", ProvBox.GetItemText(ProvBox.SelectedItem))
        Access.AddParam("@tel", TelBox.Text)
        Access.AddParam("@email", EmailBox.Text)

        Access.ExecQuery("INSERT INTO ServiceCompanies (CompanyID, Company, [Address], Suburb, PostalCode, Province, Telephone, Email) " &
                         "VALUES (@cid, @comp, @add, @subb, @pcode, @prov, @tel, @email); ")
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception)
        End If
        MsgBox("New Service Company Added Successgully!", MsgBoxStyle.Information, "Success!")
        LoadCompanies()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        SaveCompany()
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        CompID.Text = 0
        CompanyBox.Text = ""
        AddressBox.Text = ""
        SuburbBox.Text = ""
        CodeBox.Text = ""
        ProvBox.SelectedIndex = -1
        TelBox.Text = ""
        EmailBox.Text = ""
        SaveBtn.Enabled = False
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class