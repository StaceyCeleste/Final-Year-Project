Imports SchoolManagement.Form1
Public Class Drivers
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    ' Load Drivers Method
    Private Sub LoadDrivers()
        Access.ExecQuery("SELECT DriverID AS [Driver ID], DriverName AS Driver, Vehicle, VehicleRegPlate AS [Number Plate]
                        FROM Drivers")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        ' Loads Table in DGV
        dgvDrivers.DataSource = Access.DBDT

        ' Auto sizes columns
        dgvDrivers.AutoResizeColumns()
        dgvDrivers.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    ' Load Vehicles Method
    Private Sub LoadVehicles()
        Access.ExecQuery("SELECT VehicleMake + ' ' + VehicleModel AS Vehicles FROM Vehicles")
        VehicleName.DataSource = Access.DBDT
        If Access.DBDT.Rows.Count > 0 Then
            VehicleName.DataSource = Access.DBDT
            VehicleName.ValueMember = "Vehicles"
            VehicleName.DisplayMember = "Vehicles"
            VehicleName.SelectedIndex = -1
        End If
    End Sub

    Private Sub Drivers_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Drivers"
        LoadDrivers()
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
        Me.dgvDrivers.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvDrivers.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvDrivers.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvDrivers.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvDrivers.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvDrivers.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvDrivers.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvDrivers.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvDrivers.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvDrivers.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvDrivers.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvDrivers.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvDrivers.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvDrivers.BackgroundColor = Color.White
    End Sub

    ' Auto Generates Driver ID
    Private Sub DriverName_TextChanged(sender As Object, e As EventArgs) Handles DriverName.TextChanged
        Dim DriverID As Integer
        Dim Cyear As String = DateTime.Now.ToString("yy")
        Dim DTotal As Integer
        DTotal = dgvDrivers.Rows.Count
        Try
            If Not String.IsNullOrWhiteSpace(DriverName.Text) Then
                DriverID = Cyear &
                    DTotal = +1
                DTotal.ToString()
            End If
            DriverID = Cyear & DTotal.ToString
        Catch ex As Exception
            MsgBox("Error Generating Driver ID!", MsgBoxStyle.Critical, "Error!")
        End Try
        DriverIDLabel.Text = "DRV" & DriverID.ToString
    End Sub

    ' Textbox Validation
    Private Sub TextBox_Validation(sender As Object, e As EventArgs) Handles NumberPlate.TextChanged, DriverName.TextChanged
        If Not String.IsNullOrWhiteSpace(DriverName.Text) And
Not String.IsNullOrWhiteSpace(NumberPlate.Text) Then
            SaveTool.Enabled = True
        End If
    End Sub

    ' Save Drivers Method
    Private Sub SaveDrivers()
        Access.AddParam("@did", DriverIDLabel.Text)
        Access.AddParam("@dname", DriverName.Text)
        Access.AddParam("@veh", VehicleName.GetItemText(VehicleName.SelectedItem))
        Access.AddParam("@vehreg", NumberPlate.Text)

        Access.ExecQuery("INSERT INTO Drivers (DriverID, DriverName, Vehicle, VehicleRegPlate) " &
                         "VALUES (@did, @dname, @veh, @vehreg); ")
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception)
        End If
        MsgBox("New Driver Added Successfully!", MsgBoxStyle.Information, "Success!")
        LoadDrivers()
    End Sub

    ' Save Button
    Private Sub SaveTool_Click(sender As Object, e As EventArgs) Handles SaveTool.Click
        SaveDrivers()
    End Sub

    ' Clear Button
    Private Sub ClearTool_Click(sender As Object, e As EventArgs) Handles ClearTool.Click
        DriverIDLabel.Text = 0
        DriverName.Text = ""
        VehicleName.SelectedIndex = -1
        NumberPlate.Text = ""
        SaveTool.Enabled = False
    End Sub

    ' Exit Button
    Private Sub ExitTool_Click(sender As Object, e As EventArgs) Handles ExitTool.Click
        Me.Close()
    End Sub

End Class