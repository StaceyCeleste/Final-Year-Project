Public Class EditHealthDept
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

    Public Sub GetHealth()
        Access.ExecQuery("SELECT * FROM HealthDept")
        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub
        GetRecord()
    End Sub

    Private Sub EditHealthDept_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Edit Health Department Details"
        GetHealth()
    End Sub

    Public Sub GetRecord()
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        HealthID.Text = r("ID").ToString
        TelBox.Text = r("Telephone").ToString
        FaxBox.Text = r("FaxNumber").ToString
        AddressBox.Text = r("Address").ToString
        SuburbBox.Text = r("Suburb").ToString
        PcodeBox.Text = r("PCode").ToString
        PostalBox.Text = r("PostalAddress").ToString
        EmailBox.Text = r("Email").ToString
    End Sub


    Private Sub NextRecord(AddVal As Integer)
        CurrentRecord += AddVal
        If CurrentRecord > Access.DBDT.Rows.Count - 1 Then CurrentRecord = 0
        If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1
        GetRecord()
    End Sub

    Private Sub UpdateRecord()
        If String.IsNullOrEmpty(HealthID.Text) Then Exit Sub

        Access.AddParam("@tel", TelBox.Text)
        Access.AddParam("@fax", FaxBox.Text)
        Access.AddParam("@addr", AddressBox.Text)
        Access.AddParam("@subb", SuburbBox.Text)
        Access.AddParam("@pcode", PcodeBox.Text)
        Access.AddParam("@postal", PostalBox.Text)
        Access.AddParam("@email", EmailBox.Text)
        Access.AddParam("@hlthid", HealthID.Text)

        Access.ExecQuery("UPDATE HealthDept " &
                         "SET Telephone = @tel, FaxNumber = @fax, [Address] = @addr, Suburb = @subb, PCode = @pcode, PostalAddress = @postal, Email = @email " &
                         "WHERE [ID] = @ehlthid")

        If NoErrors(True) = False Then Exit Sub

        GetHealth()
        MsgBox("Health Department Details Updated!", MsgBoxStyle.Information, "Success!")
        HealthDept.Gethealth()
        HealthDept.GetRecord()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        UpdateRecord()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

End Class