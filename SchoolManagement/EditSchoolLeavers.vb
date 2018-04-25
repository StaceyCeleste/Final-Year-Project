Imports SchoolManagement.Form1
Public Class EditSchoolLeavers
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

    Private Sub GetLeavers()
        Access.ExecQuery("SELECT * FROM SchoolLeavers")

        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub

        GetRecord()
    End Sub

    Private Sub EditSchoolLeavers_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Edit School Leavers"
        GetLeavers()
    End Sub

    Private Sub GetRecord()
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        TrackBox.Text = r("TrackingNum").ToString
        ExitDate.Text = r("DateOfExit").ToString
        StudentName.Text = r("StudentName").ToString
        SurnameBox.Text = r("StudentSurname").ToString
        ExitBox.Text = r("ExitReason").ToString
    End Sub

    Private Sub NextRecord(AddVal As Integer)
        CurrentRecord += AddVal
        If CurrentRecord > Access.DBDT.Rows.Count - 1 Then CurrentRecord = 0
        If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1
        GetRecord()
    End Sub

    Private Sub UpdateRecord()
        If String.IsNullOrEmpty(TrackBox.Text) Then Exit Sub

        Access.AddParam("@exitd", ExitDate.Value.ToShortDateString)
        Access.AddParam("@sname", StudentName.Text)
        Access.AddParam("@sur", SurnameBox.Text)
        Access.AddParam("@exitr", ExitBox.Text)
        Access.AddParam("@track", TrackBox.Text)

        Access.ExecQuery("UPDATE SchoolLeavers " &
                         "SET DateOfExit = @exitd, StudentName = @sname, StudentSurname = @sur, ExitReason = @exitr " &
                         "WHERE TrackingNum = @track")

        If NoErrors(True) = False Then Exit Sub
        GetLeavers()
        MsgBox("School Leavers Successfully Updated!", MsgBoxStyle.Information, "Success!")
        SchoolLeavers.DGVLeavers_Refresh()
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