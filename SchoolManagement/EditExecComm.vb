Imports SchoolManagement.Form1
Public Class EditExecComm
    Private Access As New DBControl

    Private CurrentRecord As Integer = 0

    ' Error Checking and Reporting
    Private Function NoErrors(Optional Report As Boolean = False) As Boolean
        If Not String.IsNullOrEmpty(Access.Exception) Then
            If Report = True Then MsgBox(Access.Exception)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub GetExec()
        Access.ExecQuery("SELECT * FROM SGBExecCom")
        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub
        GetRecord()
    End Sub

    Private Sub EditExecComm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Edit SGB Executive Committee"
        GetExec()
    End Sub

    Private Sub GetRecord()
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        CommitteeLabel.Text = r("CommitteeID").ToString
        MTypeBox.Text = r("MemberType").ToString
        NameBox.Text = r("ComName").ToString
        SurnameBox.Text = r("ComSurname").ToString
    End Sub

    Private Sub NextRecord(AddVal As Integer)
        CurrentRecord += AddVal
        If CurrentRecord > Access.DBDT.Rows.Count - 1 Then CurrentRecord = 0
        If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1
        GetRecord()
    End Sub

    Private Sub UpdateRecord()
        If String.IsNullOrEmpty(CommitteeLabel.Text) Then Exit Sub

        Access.AddParam("@mtype", MTypeBox.GetItemText(MTypeBox.SelectedItem))
        Access.AddParam("@cname", NameBox.Text)
        Access.AddParam("@sur", SurnameBox.Text)
        Access.AddParam("@comm", CommitteeLabel.Text)


        Access.ExecQuery("UPDATE SGBExecCom " &
                         "SET  MemberType = @mtype, ComName = @cname, ComSurname = @sur " &
                         "WHERE CommitteeID = @comm")

        If NoErrors(True) = False Then Exit Sub

        GetExec()
        MsgBox("SGB Contact Details Updated Successfully!", MsgBoxStyle.Information, "Success!")
        ExecCommittee.LoadExec()
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