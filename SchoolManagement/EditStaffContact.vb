Imports SchoolManagement.Form1
Public Class EditStaffContact
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

    Private Sub GetStaffContact()
        Access.ExecQuery("SELECT * FROM StaffContact")

        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub

        GetRecord()
    End Sub

    Private Sub EditStaffContact_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Edit Staff Contact Details"
        GetStaffContact()
    End Sub

    Private Sub GetRecord()
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        PersalNum.Text = r("PersalNum").ToString
        StaffName.Text = r("StaffName").ToString
        StaffSurname.Text = r("StaffSurname").ToString
        StaffHomeNum.Text = r("HomeNum").ToString
        StaffCellNum.Text = r("CellNum").ToString
        StaffEmCont.Text = r("EmContNum").ToString
        StaffContName.Text = r("ContactName").ToString
        StaffEmail.Text = r("StaffEmail").ToString

    End Sub

    Private Sub NextRecord(AddVal As Integer)
        CurrentRecord += AddVal
        If CurrentRecord > Access.DBDT.Rows.Count - 1 Then CurrentRecord = 0
        If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1
        GetRecord()
    End Sub

    Private Sub UpdateRecord()
        If String.IsNullOrEmpty(PersalNum.Text) Then Exit Sub
        ' Staff Contacts Table
        Access.AddParam("@sname", StaffName.Text)
        Access.AddParam("@sur", StaffSurname.Text)
        Access.AddParam("@hnum", StaffHomeNum.Text)
        Access.AddParam("@cnum", StaffCellNum.Text)
        Access.AddParam("@ecnum", StaffEmCont.Text)
        Access.AddParam("@cname", StaffContName.Text)
        Access.AddParam("@email", StaffEmail.Text)
        Access.AddParam("@pnum", PersalNum.Text)

        Access.ExecQuery("UPDATE StaffContact " &
                         "SET  StaffName = @sname, StaffSurname = @sur, HomeNum = @hnum, CellNum = @cnum, EmContNum = @ecnum, ContactName = @cname, StaffEmail = @email " &
                         "WHERE PersalNum = @pnum")

        ' Staff Details Table
        Access.AddParam("@sname", StaffName.Text)
        Access.AddParam("@sur", StaffSurname.Text)
        Access.AddParam("@pnum", PersalNum.Text)

        Access.ExecQuery("UPDATE StaffDetails " &
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
        GetStaffContact()
        MsgBox("Staff Contact Details Successfully Updated!", MsgBoxStyle.Information, "Success!")
        ExistingStaff.LoadContact()
        ExistingStaff.LoadStaffMembers()
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