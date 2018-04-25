Imports SchoolManagement.Form1
Public Class TransportWaitingList
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub LoadWaitList()
        Access.ExecQuery("SELECT ListID AS [List ID], TrackingNum AS [Tracking Number], StudentName AS [Student Name],
                            Suburb, VehicleName AS Vehicle
                            FROM TransWaitList")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        dgvTransWaitList.DataSource = Access.DBDT

        dgvTransWaitList.AutoResizeColumns()
        dgvTransWaitList.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub LoadStudents()
        Access.ExecQuery("SELECT StuName + ' ' + StuSurname AS FullName FROM StuDetails")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        StudentBox.DataSource = Access.DBDT
        If Access.DBDT.Rows.Count > 0 Then
            StudentBox.DataSource = Access.DBDT
            StudentBox.ValueMember = "FullName"
            StudentBox.DisplayMember = "FullName"
            StudentBox.SelectedIndex = -1
        End If
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

    Private Sub TransportWaitingList_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Transport Waiting List"
        LoadWaitList()
        LoadStudents()
        LoadVehicles()
    End Sub

    ' Form Theme Colours
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.DarkTurquoise
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
        Me.dgvTransWaitList.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvTransWaitList.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvTransWaitList.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvTransWaitList.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvTransWaitList.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvTransWaitList.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvTransWaitList.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvTransWaitList.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvTransWaitList.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvTransWaitList.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvTransWaitList.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvTransWaitList.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvTransWaitList.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvTransWaitList.BackgroundColor = Color.White
    End Sub

    ' Auto Generates List ID 
    Private Sub TrackBox_TextChanged(sender As Object, e As EventArgs) Handles TrackBox.TextChanged
        Dim ListID As Integer
        Dim Cyear As String = DateTime.Now.ToString("yy")
        Dim TransTotal As Integer
        TransTotal = dgvTransWaitList.Rows.Count
        Try
            If Not String.IsNullOrWhiteSpace(TrackBox.Text) Then
                ListID = Cyear &
                    TransTotal = +1
                TransTotal.ToString()
            End If
            ListID = Cyear & TransTotal.ToString
        Catch ex As Exception
            MsgBox("Error Generating ID!", MsgBoxStyle.Critical, "Error!")
        End Try
        ListIDLabel.Text = "TWL" & ListID.ToString
    End Sub

    ' Textbox Validation
    Private Sub Textbox_Validation(sender As Object, e As EventArgs) Handles SuburbBox.TextChanged, TrackBox.TextChanged
        If Not String.IsNullOrWhiteSpace(TrackBox.Text) And
                Not String.IsNullOrWhiteSpace(SuburbBox.Text) Then
            SaveBtn.Enabled = True
        End If
    End Sub

    ' Save Student To Transport Waiting List Method
    Private Sub SaveTWL()
        Access.AddParam("@lid", ListIDLabel.Text)
        Access.AddParam("@track", TrackBox.Text)
        Access.AddParam("@sname", StudentBox.GetItemText(StudentBox.SelectedItem))
        Access.AddParam("@subb", SuburbBox.Text)
        Access.AddParam("@vname", VehicleBox.GetItemText(VehicleBox.SelectedItem))

        Access.ExecQuery("INSERT INTO TransWaitList (ListID, TrackingNum, StudentName, Suburb, VehicleName) " &
                         "VALUES (@lid, @track, @sname, @subb, @vname); ")
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception)
        End If
        MsgBox("Studdent Added To Transport Waiting List Successfully!", MsgBoxStyle.Information, "Success!")
        LoadWaitList()
    End Sub

    ' Save Button
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        SaveTWL()
    End Sub

    ' Clear Button
    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        ListIDLabel.Text = 0
        TrackBox.Text = ""
        StudentBox.SelectedIndex = -1
        SuburbBox.Text = ""
        VehicleBox.SelectedIndex = -1
        SaveBtn.Enabled = False
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class