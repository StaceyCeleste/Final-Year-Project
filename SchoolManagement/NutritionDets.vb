Imports SchoolManagement.Form1
Public Class NutritionDets
    Private Access As New DBControl

    Public Sub LoadNutrition()
        Access.ExecQuery("SELECT NutritionID AS [Nutrition ID], TrackingNum AS [Tracking Number], ParticipantName AS [Student Name],
                           [Restrictions], FoodAllergies AS [Food Allergies], ParentalConsent AS [Parental Consent], [Comments]
                            FROM Nutrition")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        dgvNutrition.DataSource = Access.DBDT

        ' Autosize DGV column width
        dgvNutrition.AutoResizeColumns()
        dgvNutrition.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub NutritionDets_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Nutrition Details"
        LoadNutrition()
        LoadCombo()
    End Sub

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub LoadCombo()
        Access.ExecQuery("Select StuName + ' ' + StuSurname AS FullName From StuDetails")

        StudentNameCombo.DataSource = Access.DBDT
        If Access.DBDT.Rows.Count > 0 Then
            StudentNameCombo.DataSource = Access.DBDT
            StudentNameCombo.ValueMember = "FullName"
            StudentNameCombo.DisplayMember = "FullName"
        End If


    End Sub

    ' Form Theme Colours
    Private Sub GrapesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrapesToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Grapes
    End Sub

    Private Sub OrangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Orange
    End Sub

    Private Sub OrangesAndLemonsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrangesAndLemonsToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.OrangesAndLemons
    End Sub

    Private Sub StrawberriesAndBlueberriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StrawberriesAndBlueberriesToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.StrawberriesAndBlueberries
    End Sub

    Private Sub DefaultToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem1.Click
        Me.BackgroundImage = Nothing
        Me.BackColor = Color.LightGreen
    End Sub

    ' DataGridView Theme Colours
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.dgvNutrition.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        Me.dgvNutrition.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvNutrition.BackgroundColor = Color.Orange
    End Sub

    Private Sub PeachToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem.Click
        Me.dgvNutrition.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub LimeGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimeGreenToolStripMenuItem.Click
        Me.dgvNutrition.BackgroundColor = Color.Lime
    End Sub

    ' TextBox Validation - Enables Save Button
    Private Sub TextBox_Validation(sender As Object, e As EventArgs) Handles TrackBox.TextChanged, RestrictBox.TextChanged, AllergiesBox.TextChanged, CommentsBox.TextChanged
        If Not String.IsNullOrWhiteSpace(TrackBox.Text) And
                Not String.IsNullOrWhiteSpace(RestrictBox.Text) And
                Not String.IsNullOrWhiteSpace(AllergiesBox.Text) And
                Not String.IsNullOrWhiteSpace(CommentsBox.Text) Then
            SaveBtn.Enabled = True
        End If
    End Sub

    Private Sub AddNutrition()
        Access.AddParam("@track", TrackBox.Text)
        Access.AddParam("@pname", StudentNameCombo.GetItemText(StudentNameCombo.SelectedItem))
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

        Access.ExecQuery("INSERT INTO Nutrition (TrackingNum, ParticipantName, [Restrictions], FoodAllergies, ParentalConsent, [Comments]) " &
                                "VALUES (@track, @pname, @restr, @fallerg, [@pcon], [@comm]); ")

        ' Reports and aborts any errors
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception) : Exit Sub
        End If
        ' Success Message 
        MsgBox("New Nutrition Information Added Successfully!", MsgBoxStyle.Information, "Success!")
        LoadNutrition()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        AddNutrition()
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        TrackBox.Text = ""
        StudentNameCombo.SelectedIndex = -1
        RestrictBox.Text = ""
        AllergiesBox.Text = ""
        YesBtn.Checked = False
        NoBtn.Checked = False
        CommentsBox.Text = ""
        SaveBtn.Enabled = False
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        EditNutritionDets.Show()
    End Sub
End Class