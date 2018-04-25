Imports SchoolManagement.Form1
Public Class EditClasses
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

    Private Sub GetClasses()
        Access.ExecQuery("SELECT * FROM Classes")

        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub

        GetRecord()
    End Sub

    Private Sub EditClasses_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Edit Class Information"
        GetClasses()
    End Sub

    Private Sub GetRecord()
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        ClassID.Text = r("ClassID").ToString
        ClassNameBox.Text = r("ClassName").ToString
        PhaseBox.Text = r("Phase").ToString
        EducatorBox.Text = r("TeacherName").ToString
    End Sub

    Private Sub NextRecord(AddVal As Integer)
        CurrentRecord += AddVal
        If CurrentRecord > Access.DBDT.Rows.Count - 1 Then CurrentRecord = 0
        If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1
        GetRecord()
    End Sub

    Private Sub UpdateRecord()
        If String.IsNullOrEmpty(ClassID.Text) Then Exit Sub

        Access.AddParam("@cnbox", ClassNameBox.Text)
        Access.AddParam("@phse", PhaseBox.Text)
        Access.AddParam("@edu", EducatorBox.Text)
        Access.AddParam("@cid", ClassID.Text)

        Access.ExecQuery("UPDATE Classes " &
                         "SET ClassName = @cnbox, Phase = @phse, TeacherName = @edu " &
                         "WHERE ClassID = @cid")

        If NoErrors(True) = False Then Exit Sub
        GetClasses()
        MsgBox("Class Information Successfully Updated!", MsgBoxStyle.Information, "Success!")
        Classes.ShowClasses()
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