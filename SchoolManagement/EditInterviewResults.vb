Imports SchoolManagement.Form1
Public Class EditInterviewResults
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

    Private Sub GetInterviewResults()
        Access.ExecQuery("SELECT * FROM ParentInterviewResults")

        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub

        GetRecord()
    End Sub

    Private Sub EditInterviewResults_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Edit Interview Results"
        GetInterviewResults()
    End Sub

    Private Sub GetRecord()
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        ParentID.Text = r("ParentID").ToString
        InterviewDate.Value = r("InterviewDate").ToString
        PNameBox.Text = r("IntervieweeName").ToString
        PSurnameBox.Text = r("IntervieweeSurname").ToString
        ResultsBox.Text = r("InterviewDets").ToString
    End Sub

    Private Sub NextRecord(AddVal As Integer)
        CurrentRecord += AddVal
        If CurrentRecord > Access.DBDT.Rows.Count - 1 Then CurrentRecord = 0
        If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1
        GetRecord()
    End Sub

    Private Sub UpdateRecord()
        If String.IsNullOrEmpty(ParentID.Text) Then Exit Sub
        ' Parent Interview Results Table
        Access.AddParam("@idate", InterviewDate.Value.ToShortDateString)
        'Access.AddParam("@pname", PNameBox.Text)
        'Access.AddParam("@sur", PSurnameBox.Text)
        Access.AddParam("@res", ResultsBox.Text)
        Access.AddParam("pid", ParentID.Text)

        Access.ExecQuery("UPDATE ParentInterviewResults " &
                         "Set  InterviewDate  = @idate, InterviewDets = @res " &
                         "WHERE ParentID = @pid")

        If NoErrors(True) = False Then Exit Sub
        GetInterviewResults()
        MsgBox("Parent Interview Results Successfully Updated!", MsgBoxStyle.Information, "Success!")
        InterviewResults.LoadInterviews()
        CurrentParent.LoadInterviews()
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