Imports SchoolManagement.Form1
Public Class EditStaffDets
    Private Access As New DBControl

    Private CurrentRecord As Integer = 0

    Private Function NoErrors(Optional Report As Boolean = False) As Boolean
        If Not String.IsNullOrEmpty(Access.Exception) Then
            If Report = True Then MsgBox(Access.Exception)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub GetStaffDetails()
        Access.ExecQuery("SELECT * FROM StaffDetails")

        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub

        GetRecord()
    End Sub

    Private Sub EditStaffDets_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Edit Staff Details"
        GetStaffDetails()
    End Sub

    Private Sub GetRecord()
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        PersalNum.Text = r("PersalNum").ToString
        IDNum.Text = r("IDNum").ToString
        If (r("Gender").ToString = "Male") Then
            MaleBtn.Checked = True
        Else
            If (r("Gender").ToString = "Female") Then
                FemaleBtn.Checked = True
            End If
        End If
        StaffInitials.Text = r("StaffInitials").ToString
        StaffName.Text = r("StaffName").ToString
        StaffSecName.Text = r("StaffSecName").ToString
        StaffSurname.Text = r("StaffSurname").ToString
        EthnicBox.Text = r("Ethnicity").ToString
        Bdate.Value = r("BirthDate").ToString
        HireDate.Value = r("HireDate").ToString
        OccupationBox.Text = r("Occupation").ToString
        PhaseBox.Text = r("Phase").ToString
    End Sub

    Private Sub NextRecord(AddVal As Integer)
        CurrentRecord += AddVal
        If CurrentRecord > Access.DBDT.Rows.Count - 1 Then CurrentRecord = 0
        If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1
        GetRecord()
    End Sub

    Private Sub UpdateRecord()
        If String.IsNullOrEmpty(PersalNum.Text) Then Exit Sub
        ' Staff Details Table
        Access.AddParam("@idn", IDNum.Text)
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
        Access.AddParam("@ssname", StaffSecName.Text)
        Access.AddParam("@sur", StaffSurname.Text)
        Access.AddParam("@ethnic", EthnicBox.Text)
        Access.AddParam("@bdate", Bdate.Value.ToShortDateString)
        Access.AddParam("@hdate", HireDate.Value.ToShortDateString)
        Access.AddParam("@occu", OccupationBox.Text)
        Access.AddParam("@phse", PhaseBox.Text)
        Access.AddParam("@pnum", PersalNum.Text)

        Access.ExecQuery("UPDATE StaffDetails " &
                         "SET IDNum = @idn, Gender = @gen, StaffInitials = @init, StaffName = @sname, StaffSecName = @ssname, StaffSurname = @sur, Ethnicity = @ethnic, BirthDate = @bdate, HireDate = @hdate, Occupation = @occu, Phase = @phse " &
                         "WHERE PersalNum = @pnum")

        ' Staff Contact Table
        Access.AddParam("@sname", StaffName.Text)
        Access.AddParam("@sur", StaffSurname.Text)
        Access.AddParam("@pnum", PersalNum.Text)

        Access.ExecQuery("UPDATE StaffContact " &
                         "SET StaffName = @sname, StaffSurname = @sur " &
                         "WHERE PersalNum = @pnum")

        ' Staff Address Table
        Access.AddParam("@sname", StaffName.Text)
        Access.AddParam("@sur", StaffSurname.Text)
        Access.AddParam("@pnum", PersalNum.Text)

        Access.ExecQuery("UPDATE StaffAddress " &
                         "SET StaffName = @sname, StaffSurname = @sur " &
                         "WHERE PersalNum = @pnum")

        If NoErrors(True) = False Then Exit Sub
        GetStaffDetails()
        MsgBox("Staff Details Successfully Updated!", MsgBoxStyle.Information, "Success!")
        ExistingStaff.LoadStaffMembers()
        ExistingStaff.LoadContact()
        ExistingStaff.LoadAddress()
    End Sub

    Private Sub FirstBtn_Click(sender As Object, e As EventArgs) Handles FirstBtn.Click
        CurrentRecord = 0
        GetRecord()
    End Sub

    Private Sub PrevBtn_Click(sender As Object, e As EventArgs) Handles PrevBtn.Click
        NextRecord(-1)
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        UpdateRecord()
    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        NextRecord(1)
    End Sub

    Private Sub LastBtn_Click(sender As Object, e As EventArgs) Handles LastBtn.Click
        CurrentRecord = Access.DBDT.Rows.Count - 1
        GetRecord()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

End Class