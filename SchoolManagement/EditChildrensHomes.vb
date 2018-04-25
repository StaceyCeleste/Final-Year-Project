Imports SchoolManagement.Form1
Public Class EditChildrensHomes
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

    Private Sub GetHomes()
        Access.ExecQuery("SELECT * FROM ChildrensHomes")
        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub
        GetRecord()
    End Sub

    Private Sub EditChildrensHomes_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Edit Children's Homes Details"
        GetHomes()
    End Sub

    Private Sub GetRecord()
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        TrackBox.Text = r("TrackingNum").ToString
        HomeNameBox.Text = r("HomeName").ToString
        HomeAddBox.Text = r("HomeAddress").ToString
        HomeContBox.Text = r("HomeContact").ToString
        StudentBox.Text = r("StudentName").ToString
    End Sub

    Private Sub NextRecord(AddVal As Integer)
        CurrentRecord += AddVal
        If CurrentRecord > Access.DBDT.Rows.Count - 1 Then CurrentRecord = 0
        If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1
        GetRecord()
    End Sub

    Private Sub UpdateRecord()
        If String.IsNullOrEmpty(TrackBox.Text) Then Exit Sub

        Access.AddParam("@hname", HomeNameBox.Text)
        Access.AddParam("@addr", HomeAddBox.Text)
        Access.AddParam("@cont", HomeContBox.Text)
        Access.AddParam("@stud", StudentBox.Text)
        Access.AddParam("@track", TrackBox.Text)

        Access.ExecQuery("UPDATE ChildrensHomes " &
                         "SET  HomeName = @hname, HomeAddress = @addr, HomeContact = @cont, StudentName = @stud " &
                         "WHERE TrackingNum = @track")

        If NoErrors(True) = False Then Exit Sub

        GetHomes()
        MsgBox("Children's Homes Details Updated Successfully!", MsgBoxStyle.Information, "Success!")
        ChildrensHomes.LoadHomes()
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