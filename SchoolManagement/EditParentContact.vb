Imports SchoolManagement.Form1
Public Class EditParentContact
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

    Private Sub GetParentContact()
        Access.ExecQuery("SELECT * FROM ParentContact")

        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub

        GetRecord()
    End Sub

    Private Sub EditParentContact_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Edit Parent Contact Details"
        GetParentContact()
    End Sub

    Private Sub GetRecord()
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        ParentID.Text = r("ParentID").ToString
        PName.Text = r("ParentName").ToString
        PSurname.Text = r("ParentSurname").ToString
        HomeNumBox.Text = r("HomeNum").ToString
        CellphoneBox.Text = r("Cellphone").ToString
        EmContBox.Text = r("EmergCont").ToString
        ContNameBox.Text = r("EmContName").ToString
        EmailBox.Text = r("Email").ToString
    End Sub

    Private Sub NextRecord(AddVal As Integer)
        CurrentRecord += AddVal
        If CurrentRecord > Access.DBDT.Rows.Count - 1 Then CurrentRecord = 0
        If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1
        GetRecord()
    End Sub

    Private Sub UpdateRecord()
        If String.IsNullOrEmpty(ParentID.Text) Then Exit Sub
        ' Parent Contact Table
        Access.AddParam("@hnum", HomeNumBox.Text)
        Access.AddParam("@cnum", CellphoneBox.Text)
        Access.AddParam("@ecnum", EmContBox.Text)
        Access.AddParam("@cname", ContNameBox.Text)
        Access.AddParam("@email", EmailBox.Text)
        Access.AddParam("pid", ParentID.Text)

        Access.ExecQuery("UPDATE ParentContact " &
                         "Set  HomeNum = @hnum, Cellphone = @cnum, EmergCont = @ecnum, EmContName = @cname, Email = @email " &
                         "WHERE ParentID = @pid")

        If NoErrors(True) = False Then Exit Sub
        GetParentContact()
        MsgBox("Parent Address Details Successfully Updated!", MsgBoxStyle.Information, "Success!")
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