Imports SchoolManagement.Form1
Public Class EditMenu
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

    Private Sub GetMenu()
        Access.ExecQuery("SELECT * FROM Menu")
        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub
        GetRecord()
    End Sub

    Private Sub GetRecord()
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        MenuLabel.Text = r("MenuID").ToString
        MenuNameBox.Text = r("MenuName").ToString
        DetailsBox.Text = r("MenuDetails").ToString
        MenuDate.Text = r("MenuDate").ToString
        WeekDayBox.Text = r("DayOfWeek").ToString
    End Sub

    Private Sub NextRecord(AddVal As Integer)
        CurrentRecord += AddVal
        If CurrentRecord > Access.DBDT.Rows.Count - 1 Then CurrentRecord = 0
        If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1
        GetRecord()
    End Sub

    Private Sub UpdateRecord()
        If String.IsNullOrEmpty(MenuLabel.Text) Then Exit Sub

        Access.AddParam("@mname", MenuNameBox.Text)
        Access.AddParam("@dets", DetailsBox.Text)
        Access.AddParam("@mdate", MenuDate.Value.ToShortDateString)
        Access.AddParam("@wday", WeekDayBox.Text)
        Access.AddParam("@mid", MenuLabel.Text)

        Access.ExecQuery("UPDATE Menu " &
                         "SET MenuName = @mname, MenuDetails = @dets, MenuDate = @mdate, DayOfWeek = @wday " &
                         "WHERE MenuID = @mid")

        If NoErrors(True) = False Then Exit Sub

        GetMenu()
        MsgBox("Menu Item Updated!", MsgBoxStyle.Information, "Success!")
        MenuForm.LoadMenus()
    End Sub

    Private Sub EditMenu_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Edit Menus"
        GetMenu()
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
        MenuForm.LoadMenus()
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