Imports SchoolManagement.Form1
Public Class EditInternalFunct
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

    Private Sub GetFunctions()
        Access.ExecQuery("SELECT * FROM InternalFunctions")
        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub
        GetRecord()
    End Sub

    Private Sub EditInternalFunct_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Edit Internal Functions"
        GetFunctions()
    End Sub

    Private Sub GetRecord()
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        FunctID.Text = r("ID").ToString
        NameBox.Text = r("FunctionName").ToString
        TypeBox.Text = r("FunctionType").ToString
        DateBox.Value = r("FunctionDate").ToShortDateString
        TimeBox.Text = r("FunctionTime").ToString
        DetailsBox.Text = r("FunctionDetails").ToString
    End Sub

    Private Sub NextRecord(AddVal As Integer)
        CurrentRecord += AddVal
        If CurrentRecord > Access.DBDT.Rows.Count - 1 Then CurrentRecord = 0
        If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1
        GetRecord()
    End Sub

    Private Sub UpdateRecord()
        If String.IsNullOrEmpty(FunctID.Text) Then Exit Sub
        Access.AddParam("@fname", NameBox.Text)
        Access.AddParam("@ftype", TypeBox.GetItemText(TypeBox.SelectedItem))
        Access.AddParam("@fdate", DateBox.Value.ToShortDateString)
        Access.AddParam("@ftime", TimeBox.Text)
        Access.AddParam("@dets", DetailsBox.Text)
        Access.AddParam("@fid", FunctID.Text)


        Access.ExecQuery("UPDATE InternalFunctions " &
                         "SET  FunctionName = @fname, FunctionType = @ftype, FunctionDate = @fdate, FunctionTime = @ftime, FunctionDetails = @dets " &
                         "WHERE [ID] = @fid")

        If NoErrors(True) = False Then Exit Sub

        GetFunctions()
        MsgBox("Internal Function Details Updated Successfully!", MsgBoxStyle.Information, "Success!")
        InternalFunctions.LoadFunctions()
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