Imports SchoolManagement.Form1
Public Class EditFireDept
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

    Public Sub GetFireDept()
        Access.ExecQuery("SELECT * FROM FireDept")
        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub
        GetRecord()
    End Sub

    Private Sub EditFireDept_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Edit Fire Department Details"
        GetFireDept()
    End Sub

    Public Sub GetRecord()
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        FireID.Text = r("ID").ToString
        TelBox.Text = r("Telephone").ToString
        EmailBox.Text = r("Email").ToString
    End Sub

    Private Sub NextRecord(AddVal As Integer)
        CurrentRecord += AddVal
        If CurrentRecord > Access.DBDT.Rows.Count - 1 Then CurrentRecord = 0
        If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1
        GetRecord()
    End Sub

    Private Sub UpdateRecord()
        If String.IsNullOrEmpty(FireID.Text) Then Exit Sub

        Access.AddParam("@tel", TelBox.Text)
        Access.AddParam("@email", EmailBox.Text)
        Access.AddParam("@fid", FireID.Text)

        Access.ExecQuery("UPDATE FireDept " &
                         "SET  Telephone = @tel, Email = @email " &
                         "WHERE [ID] = @fid")

        If NoErrors(True) = False Then Exit Sub

        GetFireDept()
        MsgBox("Fire Department Details Updated!", MsgBoxStyle.Information, "Success!")
        FireDept.GetFireDept()
        FireDept.GetRecord()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        UpdateRecord()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

End Class