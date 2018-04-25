Imports SchoolManagement.Form1
Public Class EditSGBDets
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

    Private Sub GetMembers()
        Access.ExecQuery("SELECT * FROM SGBMemberDets")
        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub
        GetRecord()
    End Sub

    Private Sub EditSGBDets_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Edit SGB Member Details"
        GetMembers()
    End Sub

    Private Sub GetRecord()
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        MemberLabel.Text = r("MemberID").ToString
        NameBox.Text = r("SGBName").ToString
        SurnameBox.Text = r("SGBSurname").ToString
        RankBox.Text = r("SGBRank").ToString
    End Sub

    Private Sub NextRecord(AddVal As Integer)
        CurrentRecord += AddVal
        If CurrentRecord > Access.DBDT.Rows.Count - 1 Then CurrentRecord = 0
        If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1
        GetRecord()
    End Sub

    Private Sub UpdateRecord()
        If String.IsNullOrEmpty(MemberLabel.Text) Then Exit Sub

        Access.AddParam("@sname", NameBox.Text)
        Access.AddParam("@sur", SurnameBox.Text)
        Access.AddParam("@rnk", RankBox.GetItemText(RankBox.SelectedItem))
        Access.AddParam("@mem", MemberLabel.Text)

        Access.ExecQuery("UPDATE SGBMemberDets " &
                         "SET  SGBName = @sname, SGBSurname = @sur, SGBRank = @rnk " &
                         "WHERE MemberID = @mem")

        ' SGB Contact Table
        Access.AddParam("@sname", NameBox.Text)
        Access.AddParam("@sur", SurnameBox.Text)
        Access.AddParam("@mem", MemberLabel.Text)

        Access.ExecQuery("UPDATE SGBContact " &
                         "SET  SGBName = @sname, SGBSurname = @sur " &
                         "WHERE MemberID = @mem")

        If NoErrors(True) = False Then Exit Sub

        GetMembers()
        MsgBox("SGB Member Details Updated Successfully!", MsgBoxStyle.Information, "Success!")
        SGBMembers.LoadSGBMembers()
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