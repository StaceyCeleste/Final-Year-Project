Imports SchoolManagement.Form1
Public Class EducationDept
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

    Public Sub GetEducation()
        Access.ExecQuery("SELECT * FROM EducationDept")
        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub
        GetRecord()
    End Sub

    Private Sub EducationDept_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Education Department Details"
        GetEducation()
    End Sub

    Public Sub GetRecord()
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        EducationID.Text = r("ID").ToString
        TelBox.Text = r("Telephone").ToString
        FaxBox.Text = r("FaxNumber").ToString
        AddressBox.Text = r("Address").ToString
        SuburbBox.Text = r("Suburb").ToString
        PCodeBox.Text = r("Pcode").ToString
        PostalBox.Text = r("PostalAddress").ToString
        EmailBox.Text = r("Email").ToString
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        EditEducation.Show()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

End Class