Imports SchoolManagement.Form1
Public Class AddStaff
    Private Access As New DBControl

    Private Sub AddStaff_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Add New Staff Member"
    End Sub

    ' Form Theme Colours
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.IndianRed
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

    ' Textbox Validation
    Private Sub TextBox_Validation(sender As Object, e As EventArgs) Handles PersalNum.TextChanged, IDNum.TextChanged, StaffInitials.TextChanged,
            StaffName.TextChanged, StaffSecName.TextChanged, StaffSurname.TextChanged, StaffAddress.TextChanged, StaffSuburb.TextChanged,
            StaffCity.TextChanged, StaffCode.TextChanged, StaffHomeNum.TextChanged, StaffCellNum.TextChanged, StaffEmCont.TextChanged,
            StaffContName.TextChanged, StaffEmail.TextChanged
        If Not String.IsNullOrWhiteSpace(PersalNum.Text) And
                Not String.IsNullOrWhiteSpace(IDNum.Text) And
                Not String.IsNullOrWhiteSpace(StaffInitials.Text) And
                Not String.IsNullOrWhiteSpace(StaffName.Text) And
                Not String.IsNullOrWhiteSpace(StaffSecName.Text) And
                Not String.IsNullOrWhiteSpace(StaffSurname.Text) And
                Not String.IsNullOrWhiteSpace(StaffAddress.Text) And
                Not String.IsNullOrWhiteSpace(StaffSuburb.Text) And
                Not String.IsNullOrWhiteSpace(StaffCity.Text) And
                Not String.IsNullOrWhiteSpace(StaffCode.Text) And
                Not String.IsNullOrWhiteSpace(StaffHomeNum.Text) And
                Not String.IsNullOrWhiteSpace(StaffCellNum.Text) And
                Not String.IsNullOrWhiteSpace(StaffEmCont.Text) And
                Not String.IsNullOrWhiteSpace(StaffContName.Text) And
                Not String.IsNullOrWhiteSpace(StaffEmail.Text) Then
            SaveStrip.Enabled = True
        End If
    End Sub

    ' Save Staff Member Method
    Private Sub SaveStaff()
        ' Staff Details Table
        Access.AddParam("@pnum", PersalNum.Text)
        Access.AddParam("@idnum", IDNum.Text)
        If (MaleBtn.Checked = True) Then
            MaleBtn.Text = "Male"
            Access.AddParam("@gen", MaleBtn.Text)
        Else
            If (FemaleBtn.Checked = True) Then
                FemaleBtn.Text = "Female"
                Access.AddParam("@gen", FemaleBtn.Text)
            End If
        End If
        Access.AddParam("@init", StaffInitials.Text)
        Access.AddParam("@sname", StaffName.Text)
        Access.AddParam("@secname", StaffSecName.Text)
        Access.AddParam("@sur", StaffSurname.Text)
        Access.AddParam("@ethnic", StaffEthnicity.GetItemText(StaffEthnicity.SelectedItem))
        Access.AddParam("@bdate", Bdate.Value.ToShortDateString)
        Access.AddParam("@hdate", HireDate.Value.ToShortDateString)
        Access.AddParam("@occu", StaffOccupation.GetItemText(StaffOccupation.SelectedItem))
        Access.AddParam("@phase", PhaseBox.Text)

        Access.ExecQuery("INSERT INTO StaffDetails (PersalNum, IDNum, Gender, StaffInitials, StaffName, StaffSecName, StaffSurname, Ethnicity, BirthDate, HireDate, [Occupation], [Phase]) " &
                         "VALUES (@pnum, @idnum, @gen, @init, @sname, @secname, @sur, @ethnic, @bdate, @hdate, @occu, @phase); ")

        ' Staff Address Table
        Access.AddParam("@pnum", PersalNum.Text)
        Access.AddParam("@sname", StaffName.Text)
        Access.AddParam("@sur", StaffSurname.Text)
        Access.AddParam("@add", StaffAddress.Text)
        Access.AddParam("@subb", StaffSuburb.Text)
        Access.AddParam("@city", StaffCity.Text)
        Access.AddParam("@prov", StaffProvince.GetItemText(StaffProvince.SelectedItem))
        Access.AddParam("@pcode", StaffCode.Text)

        Access.ExecQuery("INSERT INTO StaffAddress (PersalNum, StaffName, StaffSurname, StaffAddress, StaffSuburb, StaffCity, StaffProvince, StaffPCode) " &
                         "VALUES (@pnum, @sname, @sur, @add, @subb, @city, @prov, @pcode); ")

        ' Staff Contact Table
        Access.AddParam("@pnum", PersalNum.Text)
        Access.AddParam("@sname", StaffName.Text)
        Access.AddParam("@sur", StaffSurname.Text)
        Access.AddParam("@hnum", StaffHomeNum.Text)
        Access.AddParam("@cnum", StaffCellNum.Text)
        Access.AddParam("@emcont", StaffEmCont.Text)
        Access.AddParam("@contname", StaffContName.Text)
        Access.AddParam("@email", StaffEmail.Text)

        Access.ExecQuery("INSERT INTO StaffContact (PersalNum, StaffName, StaffSurname, HomeNum, CellNum, EmContNum, ContactName, StaffEmail) " &
                         "VALUES (@pnum, @sname, @sur, @hnum, @cnum, @emcont, @contname, @email); ")

        ' Reports and aborts any errors 
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception) : Exit Sub
        End If
        ' Success Message 
        MsgBox("New Staff Member Added Successfully!", MsgBoxStyle.Information, "Success!")
        ExistingStaff.LoadStaffMembers()
    End Sub

    ' Save Button
    Private Sub SaveStrip_Click(sender As Object, e As EventArgs) Handles SaveStrip.Click
        SaveStaff()
    End Sub

    ' Clear Button
    Private Sub ClearStrip_Click(sender As Object, e As EventArgs) Handles ClearStrip.Click
        PersalNum.Text = ""
        IDNum.Text = ""
        MaleBtn.Checked = False
        FemaleBtn.Checked = False
        StaffInitials.Text = ""
        StaffName.Text = ""
        StaffSecName.Text = ""
        StaffSurname.Text = ""
        StaffEthnicity.SelectedIndex = -1
        Bdate.Value = Date.Now
        HireDate.Value = Date.Now
        StaffOccupation.SelectedIndex = -1
        PhaseBox.SelectedIndex = -1
        StaffAddress.Text = ""
        StaffSuburb.Text = ""
        StaffCity.Text = ""
        StaffProvince.SelectedIndex = -1
        StaffCode.Text = ""
        StaffHomeNum.Text = ""
        StaffCellNum.Text = ""
        StaffEmCont.Text = ""
        StaffContName.Text = ""
        StaffEmail.Text = ""
        SaveStrip.Enabled = False
    End Sub

    ' Close Button
    Private Sub ExitStrip_Click(sender As Object, e As EventArgs) Handles ExitStrip.Click
        Me.Close()
    End Sub

End Class