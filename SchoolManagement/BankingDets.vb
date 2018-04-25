Imports SchoolManagement.Form1
Public Class BankingDets
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

    Public Sub GetBankDets()
        Access.ExecQuery("SELECT * FROM BankingDets")
        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub
        GetRecord()
    End Sub

    Private Sub BankingDets_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Banking Details"
        GetBankDets()
    End Sub

    Public Sub GetRecord()
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        IDBox.Text = r("ID").ToString
        BankBox.Text = r("BankName").ToString
        AccountBox.Text = r("AccNum").ToString
        BranchBox.Text = r("BankBranch").ToString
        NumberBox.Text = r("BranchNum").ToString
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

End Class