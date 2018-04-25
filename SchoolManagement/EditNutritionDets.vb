Imports SchoolManagement.Form1
Public Class EditNutritionDets
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

    Private Sub GetNutrition()
        Access.ExecQuery("SELECT * FROM Nutrition")

        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub

        GetRecord()
    End Sub

    Private Sub GetRecord()
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        NutriID.Text = r("NutritionID").ToString
        TrackNum.Text = r("TrackingNum").ToString
        NameBox.Text = r("ParticipantName").ToString
        RestrictBox.Text = r("Restrictions").ToString
        AllergiesBox.Text = r("FoodAllergies").ToString
        If (r("ParentalConsent").ToString = "Yes") Then
            YesBtn.Checked = True
        Else
            If (r("ParentalConsent").ToString = "No") Then
                NoBtn.Checked = True
            End If
        End If
        CommentsBox.Text = r("Comments").ToString
    End Sub

    Private Sub NextRecord(AddVal As Integer)
        CurrentRecord += AddVal
        If CurrentRecord > Access.DBDT.Rows.Count - 1 Then CurrentRecord = 0
        If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1
        GetRecord()
    End Sub

    Private Sub UpdateRecord()
        If String.IsNullOrEmpty(NutriID.Text) Then Exit Sub
        Access.AddParam("@track", TrackNum.Text)
        Access.AddParam("@pname", NameBox.Text)
        Access.AddParam("@restr", RestrictBox.Text)
        Access.AddParam("@fallerg", AllergiesBox.Text)

        If YesBtn.Checked = True Then
            YesBtn.Text = "Yes"
            Access.AddParam("@pcon", YesBtn.Text)
        Else
            If NoBtn.Checked = True Then
                NoBtn.Text = "No"
                Access.AddParam("@pcon", NoBtn.Text)
            End If
        End If

        Access.AddParam("@comm", CommentsBox.Text)

        Access.AddParam("@nid", NutriID.Text)

        Access.ExecQuery("UPDATE Nutrition " &
                         "SET TrackingNum = @track, ParticipantName = @pname, [Restrictions] = @restr, FoodAllergies = @fallerg, ParentalConsent = @pcon, [Comments] = @comm " &
                         "WHERE NutritionID = @nid")

        If NoErrors(True) = False Then Exit Sub
        GetNutrition()
        MsgBox("Nutrition Details Successfully Updated!", MsgBoxStyle.Information, "Success!")
        NutritionDets.LoadNutrition()
    End Sub

    Private Sub EditNutritionDets_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Edit Nutrition Details"
        GetNutrition()
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