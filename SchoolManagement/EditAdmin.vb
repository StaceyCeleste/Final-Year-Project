Imports SchoolManagement.Form1
Public Class EditAdmin
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

    Private Sub GetAdmin()
        Access.ExecQuery("SELECT * FROM AdminTeam")
        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub
        GetRecord()
    End Sub

    Private Sub GetRecord()
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        PersalNum.Text = r("PersalNum").ToString
        StaffIdBox.Text = r("StaffID").ToString
        StaffNameBox.Text = r("StaffName").ToString
        StaffSurnameBox.Text = r("StaffSurname").ToString
        StaffRankBox.Text = r("StaffRank").ToString
    End Sub

    Private Sub NextRecord(AddVal As Integer)
        CurrentRecord += AddVal
        If CurrentRecord > Access.DBDT.Rows.Count - 1 Then CurrentRecord = 0
        If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1
        GetRecord()
    End Sub

    Private Sub UpdateRecord()
        If String.IsNullOrEmpty(PersalNum.Text) Then Exit Sub

        Access.AddParam("@sid", StaffIdBox.Text)
        Access.AddParam("@sname", StaffNameBox.Text)
        Access.AddParam("@sur", StaffSurnameBox.Text)
        Access.AddParam("@srank", StaffRankBox.GetItemText(StaffRankBox.SelectedItem))
        Access.AddParam("@pnum", PersalNum.Text)

        Access.ExecQuery(" UPDATE AdminTeam " &
                         "SET StaffID = @sid, StaffName = @sname, StaffSurname = @sur, StaffRank = @srank " &
                         "WHERE PersalNum = @pnum")

        If NoErrors(True) = False Then Exit Sub

        GetAdmin()
        MsgBox("Admin Team Updated!", MsgBoxStyle.Information, "Success!")
    End Sub

    Private Sub EditAdmin_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Edit Admin Team"
        GetAdmin()
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
        AdminTeam.GridRefresh()
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