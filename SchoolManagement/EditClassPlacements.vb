Imports SchoolManagement.Form1
Public Class EditClassPlacements
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

    Private Sub GetPlacements()
        Access.ExecQuery("SELECT * FROM ClassPlacements")

        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub

        GetRecord()
    End Sub

    Private Sub EditClassPlacements_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Edit Class Placements"
        GetPlacements()
    End Sub

    Private Sub GetRecord()
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        IDLabel.Text = r("ID").ToString
        ClassID.Text = r("ClassID").ToString
        PhaseBox.Text = r("Phase").ToString
        StudentNameBox.Text = r("StudentName").ToString
    End Sub

    Private Sub NextRecord(AddVal As Integer)
        CurrentRecord += AddVal
        If CurrentRecord > Access.DBDT.Rows.Count - 1 Then CurrentRecord = 0
        If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1
        GetRecord()
    End Sub

    Private Sub UpdateRecord()
        If String.IsNullOrEmpty(ClassID.Text) Then Exit Sub

        Access.AddParam("@cid", ClassID.Text)
        Access.AddParam("@phse", PhaseBox.Text)
        Access.AddParam("@sname", StudentNameBox.Text)
        Access.AddParam("@idc", IDLabel.Text)

        Access.ExecQuery("UPDATE ClassPlacements " &
                         "SET ClassID = @cid, Phase = @phse, StudentName = @sname " &
                         "WHERE [ID] = @idc")

        If NoErrors(True) = False Then Exit Sub
        GetPlacements()
        MsgBox("Class Placements Successfully Updated!", MsgBoxStyle.Information, "Success!")
        ClassPlacement.LoadPlacements()
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