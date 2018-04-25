Imports SchoolManagement.Form1
Public Class VehicleDetails
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    ' Load Accidents Log Table Method
    Private Sub LoadVehicles()
        Access.ExecQuery("SELECT  VehicleID AS [Vehicle ID], VehicleRegPlate AS [Number Plate], VehicleMake AS [Make], VehicleModel AS [Model],
                            VehicleType AS [Type], VehicleColour AS Colour
                            FROM Vehicles")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        dgvDetails.DataSource = Access.DBDT
        dgvDetails.AutoResizeColumns()
        dgvDetails.AutoSizeRowsMode =
            DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub VehicleDetails_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Vehicle Details"
        LoadVehicles()
    End Sub

    ' Form Theme Colours
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.DodgerBlue
    End Sub

    Private Sub CornflowerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CornflowerBlueToolStripMenuItem.Click
        Me.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub DarkRedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkRedToolStripMenuItem.Click
        Me.BackColor = Color.DarkRed
    End Sub

    Private Sub DarkVioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkVioletToolStripMenuItem.Click
        Me.BackColor = Color.DarkViolet
    End Sub

    Private Sub DeepSkyBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeepSkyBlueToolStripMenuItem.Click
        Me.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub HotPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HotPinkToolStripMenuItem.Click
        Me.BackColor = Color.HotPink
    End Sub

    Private Sub IvoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IvoryToolStripMenuItem.Click
        Me.BackColor = Color.Ivory
    End Sub

    Private Sub LightCoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightCoralToolStripMenuItem.Click
        Me.BackColor = Color.LightCoral
    End Sub

    Private Sub LimeGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimeGreenToolStripMenuItem.Click
        Me.BackColor = Color.LimeGreen
    End Sub

    Private Sub OrangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem.Click
        Me.BackColor = Color.Orange
    End Sub

    Private Sub PeachToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem.Click
        Me.BackColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem.Click
        Me.BackColor = Color.Pink
    End Sub

    Private Sub PurpleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem.Click
        Me.BackColor = Color.MediumPurple
    End Sub

    Private Sub SilverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SilverToolStripMenuItem.Click
        Me.BackColor = Color.Silver
    End Sub

    ' DataGridView Theme Colours
    Private Sub DefaultToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem1.Click
        Me.dgvDetails.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvDetails.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvDetails.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvDetails.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvDetails.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvDetails.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvDetails.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvDetails.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvDetails.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvDetails.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvDetails.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvDetails.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvDetails.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvDetails.BackgroundColor = Color.White
    End Sub

    ' Auto Generate Accident ID
    Private Sub NumberPlate_TextChanged(sender As Object, e As EventArgs) Handles NumberPlate.TextChanged
        Dim AccidentID As Integer
        Dim Cyear As String = DateTime.Now.ToString("yy")
        Dim ATotal As Integer
        ATotal = dgvDetails.Rows.Count
        Try
            If Not String.IsNullOrWhiteSpace(NumberPlate.Text) Then
                AccidentID = Cyear &
                    ATotal = +1
                ATotal.ToString()
            End If
            AccidentID = Cyear & ATotal.ToString
        Catch ex As Exception
            MsgBox("Error Generating Accident ID!", MsgBoxStyle.Critical, "Error!")
        End Try
        VehID.Text = "VEH" & AccidentID.ToString
    End Sub

    ' Textbox Validation
    Private Sub Textbox_Validation(sender As Object, e As EventArgs) Handles NumberPlate.TextChanged, VehModel.TextChanged
        If Not String.IsNullOrWhiteSpace(NumberPlate.Text) And
                Not String.IsNullOrWhiteSpace(VehMake.Text) And
                            Not String.IsNullOrWhiteSpace(VehModel.Text) And
               Not String.IsNullOrWhiteSpace(ColourBox.Text) Then
            SaveBtn.Enabled = True
        End If
    End Sub

    ' Save New Vehicles Method
    Private Sub SaveVehicles()
        Access.AddParam("@vid", VehID.Text)
        Access.AddParam("@vrp", NumberPlate.Text)
        Access.AddParam("@vmake", VehMake.Text)
        Access.AddParam("@vmodel", VehModel.Text)
        Access.AddParam("@vtype", VehType.GetItemText(VehType.SelectedItem))
        Access.AddParam("@vcol", ColourBox.Text)

        Access.ExecQuery("INSERT INTO Vehicles (VehicleID, VehicleRegPlate, VehicleMake, VehicleModel, VehicleType, VehicleColour) " &
                         "VALUES (@vid, @vrp, @vmake, @vmodel, @vtype, @vcol); ")
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception)
        End If
        MsgBox("New Vehicle Added Successfully!", MsgBoxStyle.Information, "Success!")
        LoadVehicles()
    End Sub

    ' Save Button
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        SaveVehicles()
    End Sub

    ' Clear Button
    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        VehID.Text = 0
        NumberPlate.Text = ""
        VehMake.Text = ""
        VehModel.Text = ""
        VehType.SelectedIndex = -1
        ColourBox.Text = ""
        SaveBtn.Enabled = False
    End Sub

    ' Exit Button
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class