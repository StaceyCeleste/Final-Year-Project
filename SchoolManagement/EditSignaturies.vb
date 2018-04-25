Imports SchoolManagement.Form1
Public Class EditSignaturies
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

    Private Sub GetSignaturies()
        Access.ExecQuery("SELECT * FROM ActiveSignaturies")
        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub
        GetRecord()
    End Sub

    Private Sub EditSignaturies_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Edit Active Signaturies"
        GetSignaturies()
    End Sub

    Private Sub GetRecord()
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        IDLabel.Text = r("ID").ToString
        NameBox.Text = r("SigName").ToString
        SurnameBox.Text = r("SigSurname").ToString
        AuthoriseBox.Text = r("AuthorisedBy").ToString
    End Sub

    Private Sub NextRecord(AddVal As Integer)
        CurrentRecord += AddVal
        If CurrentRecord > Access.DBDT.Rows.Count - 1 Then CurrentRecord = 0
        If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1
        GetRecord()
    End Sub

    Private Sub UpdateRecord()
        If String.IsNullOrEmpty(IDLabel.Text) Then Exit Sub

        Access.AddParam("@sname", NameBox.Text)
        Access.AddParam("@sur", SurnameBox.Text)
        Access.AddParam("@aut", AuthoriseBox.Text)
        Access.AddParam("@sid", IDLabel.Text)

        Access.ExecQuery(" UPDATE ActiveSignaturies " &
                         "SET SigName = @sname, SigSurname = @sur, AuthorisedBy = @aut " &
                         "WHERE [ID] = @sid")

        If NoErrors(True) = False Then Exit Sub

        GetSignaturies()
        MsgBox("Active Signature Successfully Updated!", MsgBoxStyle.Information, "Success!")
        ActiveSignaturies.LoadSignaturies()
    End Sub

    Private Sub DeleteSignaturies()
        If String.IsNullOrEmpty(IDLabel.Text) Then Exit Sub
        Access.AddParam("@sid", IDLabel.Text)

        Access.ExecQuery("DELETE * FROM ActiveSignaturies " &
                         "WHERE [ID] = @sid ")

        If NoErrors(True) = False Then Exit Sub

        GetSignaturies()
        MsgBox("Active Signature Successfully Deleted!", MsgBoxStyle.Information, "Success!")
        ActiveSignaturies.LoadSignaturies()
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

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        DeleteSignaturies()
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