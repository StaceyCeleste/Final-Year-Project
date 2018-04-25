Imports SchoolManagement.Form1
Public Class EditParentAddress
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

    Private Sub GetParentAddress()
        Access.ExecQuery("SELECT * FROM ParentAddress")

        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub

        GetRecord()
    End Sub

    Private Sub EditParentAddress_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Edit Parent Address Details"
        GetParentAddress()
    End Sub

    Private Sub GetRecord()
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        ParentID.Text = r("ParentID").ToString
        PName.Text = r("ParentName").ToString
        PSurname.Text = r("ParentSurname").ToString
        AddressBox.Text = r("PhysicalAdd").ToString
        SuburbBox.Text = r("Suburb").ToString
        CityBox.Text = r("City").ToString
        ProvBox.Text = r("Province").ToString
        PCodeBox.Text = r("PCode").ToString
    End Sub

    Private Sub NextRecord(AddVal As Integer)
        CurrentRecord += AddVal
        If CurrentRecord > Access.DBDT.Rows.Count - 1 Then CurrentRecord = 0
        If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1
        GetRecord()
    End Sub

    Private Sub UpdateRecord()
        If String.IsNullOrEmpty(ParentID.Text) Then Exit Sub
        ' Parent Address Table
        Access.AddParam("pname", PName.Text)
        Access.AddParam("@sur", PSurname.Text)
        Access.AddParam("@addr", AddressBox.Text)
        Access.AddParam("@subb", SuburbBox.Text)
        Access.AddParam("@city", CityBox.Text)
        Access.AddParam("@prov", ProvBox.Text)
        Access.AddParam("@pcode", PCodeBox.Text)
        Access.AddParam("pid", ParentID.Text)

        Access.ExecQuery("UPDATE ParentAddress " &
                         "Set ParentName = @pname, ParentSurname = @sur, PhysicalAdd = @addr, Suburb = @subb, City = @city, Province = @prov, PCode = @pcode " &
                         "WHERE ParentID = @pid")

        If NoErrors(True) = False Then Exit Sub
        GetParentAddress()
        MsgBox("Parent Address Details Successfully Updated!", MsgBoxStyle.Information, "Success!")
        CurrentParent.LoadAddress()
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