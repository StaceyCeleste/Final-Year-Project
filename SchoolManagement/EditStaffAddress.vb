Imports SchoolManagement.Form1
Public Class EditStaffAddress
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

    Private Sub GetStaffAddress()
        Access.ExecQuery("SELECT * FROM StaffAddress")

        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub

        GetRecord()
    End Sub

    Private Sub EditStaffAddress_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Edit Staff Address Details"
        GetStaffAddress()
    End Sub

    Private Sub GetRecord()
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        PersalNum.Text = r("PersalNum").ToString
        StaffName.Text = r("StaffName").ToString
        StaffSurname.Text = r("StaffSurname").ToString
        StaffAddress.Text = r("StaffAddress").ToString
        StaffSuburb.Text = r("StaffSuburb").ToString
        StaffCity.Text = r("StaffCity").ToString
        ProvBox.Text = r("StaffProvince").ToString
        StaffCode.Text = r("StaffPCode").ToString
    End Sub

    Private Sub NextRecord(AddVal As Integer)
        CurrentRecord += AddVal
        If CurrentRecord > Access.DBDT.Rows.Count - 1 Then CurrentRecord = 0
        If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1
        GetRecord()
    End Sub

    Private Sub UpdateRecord()
        If String.IsNullOrEmpty(PersalNum.Text) Then Exit Sub
        ' Staff Address Table
        Access.AddParam("@sname", StaffName.Text)
        Access.AddParam("@sur", StaffSurname.Text)
        Access.AddParam("@addr", StaffAddress.Text)
        Access.AddParam("@subb", StaffSuburb.Text)
        Access.AddParam("@city", StaffCity.Text)
        Access.AddParam("@prov", ProvBox.Text)
        Access.AddParam("@pcode", StaffCode.Text)
        Access.AddParam("@pnum", PersalNum.Text)

        Access.ExecQuery("UPDATE StaffAddress " &
                         "SET  StaffName = @sname, StaffSurname = @sur,  StaffAddress = @addr, StaffSuburb = @subb, StaffCity = @city, StaffProvince = @prov, StaffPCode = @pcode " &
                         "WHERE PersalNum = @pnum")

        ' Staff Details Table
        Access.AddParam("@sname", StaffName.Text)
        Access.AddParam("@sur", StaffSurname.Text)
        Access.AddParam("@pnum", PersalNum.Text)

        Access.ExecQuery("UPDATE StaffDetails " &
                         "SET StaffName = @sname, StaffSurname = @sur " &
                         "WHERE PersalNum = @pnum")

        ' Staff Contact Table
        Access.AddParam("@sname", StaffName.Text)
        Access.AddParam("@sur", StaffSurname.Text)
        Access.AddParam("@pnum", PersalNum.Text)

        Access.ExecQuery("UPDATE StaffContact " &
                         "SET StaffName = @sname, StaffSurname = @sur " &
                         "WHERE PersalNum = @pnum")

        If NoErrors(True) = False Then Exit Sub
        GetStaffAddress()
        MsgBox("Staff Contact Details Successfully Updated!", MsgBoxStyle.Information, "Success!")
        ExistingStaff.LoadAddress()
        ExistingStaff.LoadContact()
        ExistingStaff.LoadStaffMembers()
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