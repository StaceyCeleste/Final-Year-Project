Imports SchoolManagement.Form1
Public Class EditParentDetails
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

    Private Sub GetParentDetails()
        Access.ExecQuery("SELECT * FROM ParentDetails")

        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub

        GetRecord()
    End Sub

    Private Sub EditParentDetails_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Edit Parent Details"
        GetParentDetails()
    End Sub

    Private Sub GetRecord()
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        ParentID.Text = r("ID").ToString
        InitialsBox.Text = r("ParentInitials").ToString
        PNameBox.Text = r("ParentName").ToString
        PSurnameBox.Text = r("ParentSurname").ToString
        OccupationBox.Text = r("Occupation").ToString
        StudentBox.Text = r("StudentName").ToString
        StudentNumBox.Text = r("StudentNum").ToString
    End Sub

    Private Sub NextRecord(AddVal As Integer)
        CurrentRecord += AddVal
        If CurrentRecord > Access.DBDT.Rows.Count - 1 Then CurrentRecord = 0
        If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1
        GetRecord()
    End Sub

    Private Sub UpdateRecord()
        If String.IsNullOrEmpty(ParentID.Text) Then Exit Sub
        ' Parent Details Table
        Access.AddParam("@init", InitialsBox.Text)
        Access.AddParam("@pname", PNameBox.Text)
        Access.AddParam("sur", PSurnameBox.Text)
        Access.AddParam("@occu", OccupationBox.Text)
        Access.AddParam("@sname", StudentBox.Text)
        Access.AddParam("@stunum", StudentNumBox.Text)
        Access.AddParam("pid", ParentID.Text)

        Access.ExecQuery("UPDATE ParentDetails " &
                         "Set  ParentInitials = @init, ParentName = @pname, ParentSurname = @sur, Occupation = @occu, StudentName = @sname, StudentNum = @stunum " &
                         "WHERE [ID] = @pid")

        'Parent Contact Table
        Access.AddParam("@pname", PNameBox.Text)
        Access.AddParam("sur", PSurnameBox.Text)
        Access.AddParam("pid", ParentID.Text)

        Access.ExecQuery("UPDATE ParentContact " &
                         "Set  ParentName = @pname, ParentSurname = @sur " &
                         "WHERE ParentID = @pid")

        ' Parent Address Table
        Access.AddParam("@pname", PNameBox.Text)
        Access.AddParam("sur", PSurnameBox.Text)
        Access.AddParam("pid", ParentID.Text)

        Access.ExecQuery("UPDATE ParentAddress " &
                         "Set  ParentName = @pname, ParentSurname = @sur " &
                         "WHERE ParentID = @pid")

        ' Interview Results Table
        Access.AddParam("@pname", PNameBox.Text)
        Access.AddParam("sur", PSurnameBox.Text)
        Access.AddParam("pid", ParentID.Text)

        Access.ExecQuery("UPDATE ParentInterviewResults " &
                         "Set  IntervieweeName = @pname, IntervieweeSurname = @sur " &
                         "WHERE ParentID = @pid")

        If NoErrors(True) = False Then Exit Sub
        GetParentDetails()
        MsgBox("Parent Details Successfully Updated!", MsgBoxStyle.Information, "Success!")
        CurrentParent.LoadParents()
        CurrentParent.LoadAddress()
        CurrentParent.LoadContacts()
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