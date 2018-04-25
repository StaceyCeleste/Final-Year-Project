Imports SchoolManagement.Form1
Public Class VehicleService
    Private Access As New DBControl

    Private Function NotEmpty(text) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub LoadVehServ()
        Access.ExecQuery("SELECT ServiceID AS [Service ID], ServiceName AS [Name of Service], ServiceType AS [Type of Service],
                            Vehicle, Details, ServiceDate AS [Date], ServiceCost AS Cost
                            FROM VehicleServices")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        dgvVehicles.DataSource = Access.DBDT
        dgvVehicles.AutoResizeColumns()
        dgvVehicles.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub LoadVehicles()
        Access.ExecQuery("SELECT VehicleID + '-' + VehicleMake AS Vehicle FROM Vehicles")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        VehicleBox.DataSource = Access.DBDT
        If Access.DBDT.Rows.Count > 0 Then
            VehicleBox.DataSource = Access.DBDT
            VehicleBox.ValueMember = "Vehicle"
            VehicleBox.DisplayMember = "Vehicle"
            VehicleBox.SelectedIndex = -1
        End If
    End Sub

    Private Sub VehicleService_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Add New Vehicle Service"
        LoadVehServ()
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
        Me.dgvVehicles.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvVehicles.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvVehicles.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvVehicles.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvVehicles.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvVehicles.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvVehicles.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvVehicles.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvVehicles.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvVehicles.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvVehicles.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvVehicles.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvVehicles.BackgroundColor = Color.Violet
    End Sub

    Private Sub ServiceName_TextChanged(sender As Object, e As EventArgs) Handles ServiceName.TextChanged
        Dim ServiceID As Integer
        Dim Cyear As String = DateTime.Now.ToString("yyyy")
        Dim VSTotal As Integer
        VSTotal = dgvVehicles.Rows.Count + 1
        Try
            If Not String.IsNullOrWhiteSpace(ServiceName.Text) Then
                ServiceID = Cyear &
                    VSTotal = +1
                VSTotal.ToString()
            End If
            ServiceID = Cyear & VSTotal.ToString
        Catch ex As Exception
            MsgBox("Error Generating Service ID!", MsgBoxStyle.Critical, "Error!")
        End Try
        ServID.Text = "VSERV" & ServiceID.ToString
    End Sub

    Private Sub ServiceType_TextChanged(sender As Object, e As EventArgs) Handles ServiceType.TextChanged, ServiceName.TextChanged,
    DetailsBox.TextChanged, CostBox.TextChanged
        If Not String.IsNullOrWhiteSpace(ServiceName.Text) And
                Not String.IsNullOrWhiteSpace(ServiceType.Text) And
                Not String.IsNullOrWhiteSpace(DetailsBox.Text) And
                Not String.IsNullOrWhiteSpace(CostBox.Text) Then
            SaveBtn.Enabled = True
        End If
    End Sub

    Private Sub SaveService()
        Access.AddParam("@sid", ServID.Text)
        Access.AddParam("@sname", ServiceName.Text)
        Access.AddParam("@stype", ServiceType.Text)
        Access.AddParam("@veh", VehicleBox.GetItemText(VehicleBox.SelectedItem))
        Access.AddParam("@dets", DetailsBox.Text)
        Access.AddParam("@sdate", DateBox.Value.ToShortDateString)
        Access.AddParam("@cost", CostBox.Text)

        Access.ExecQuery("INSERT INTO VehicleServices (ServiceID, ServiceName, ServiceType, Vehicle, Details, ServiceDate, ServiceCost) " &
                         "VALUES (@sid, @sname, @stype, @veh, @dets, @sdate, @cost); ")
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception)
        End If
        MsgBox("Vehicle Service Details Added Successfully!", MsgBoxStyle.Information, "Success!")
        LoadVehServ()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        SaveService()
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        ServID.Text = 0
        ServiceName.Text = ""
        ServiceType.Text = ""
        VehicleBox.SelectedIndex = -1
        DetailsBox.Text = ""
        DateBox.Value = Date.Now
        CostBox.Text = ""
        SaveBtn.Enabled = False
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class