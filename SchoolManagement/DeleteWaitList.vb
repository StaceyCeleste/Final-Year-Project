Imports SchoolManagement.Form1
Public Class DeleteWaitList
    Private Access As New DBControl

    Private CurrentRecord As Integer = 0

    ' Error Checking and Reporting
    Private Function NoError(Optional Report As Boolean = False) As Boolean
        If Not String.IsNullOrEmpty(Access.Exception) Then
            If Report = True Then MsgBox(Access.Exception)
            Return False
        Else
            Return True
        End If
    End Function

    ' Error Checking and Reporting
    Private Function NoErrors(Optional Report As Boolean = False) As Boolean
        If Not String.IsNullOrEmpty(Access.Exception) Then
            If Report = True Then MsgBox(Access.Exception)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub GetWaitList()
        Access.ExecQuery("SELECT * FROM WaitingList")
        If NoError(True) = False OrElse Access.RecordCount < 1 Then Exit Sub
        GetRecord()
    End Sub

    Private Sub DeleteWaitList_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Delete Student"
        GetWaitList()
    End Sub

    Private Sub GetRecord()
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        IDBox2.Text = r("ListID").ToString
        TrackBox.Text = r("TrackingNum").ToString
        RefBox.Text = r("RefNum").ToString
        DateBox.Text = r("AdminDate").ToShortDateString
        GenderBox.Text = r("Gender").ToString
        NameBox.Text = r("StuName").ToString
        SurnameBox.Text = r("StuSurname").ToString
        ParentBox.Text = r("ParentName").ToString
        BirthBox.Text = r("DateOfBirth").ToShortDateString
        AgeBox.Text = r("StudentAge").ToString
        TelBox.Text = ("Telephone").ToString
        AddressBox.Text = ("Address").ToString
        SchoolBox.Text = ("PrevSchool").ToString
    End Sub

    Private Sub NextRecord(AddVal As Integer)
        CurrentRecord += AddVal
        If CurrentRecord > Access.DBDT.Rows.Count - 1 Then CurrentRecord = 0
        If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1
        GetRecord()
    End Sub

    Private Sub DeleteStudent()
        If String.IsNullOrEmpty(IDBox2.Text) Then Exit Sub
        Access.AddParam("@sid", IDBox2.Text)

        Access.ExecQuery("DELETE * FROM WaitingList " &
                         "WHERE ListID = @sid ")

        If NoErrors(True) = False Then Exit Sub

        GetWaitList()
        MsgBox("Student Delete off Waiting List!", MsgBoxStyle.Information, "Success!")
        WaitingList.WaitList_Refresh()
    End Sub

    Private Sub FirstBtn_Click(sender As Object, e As EventArgs) Handles FirstBtn.Click
        CurrentRecord = 0
        GetRecord()
    End Sub

    Private Sub PrevBtn_Click(sender As Object, e As EventArgs) Handles PrevBtn.Click
        NextRecord(-1)
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

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        DeleteStudent()
    End Sub
End Class