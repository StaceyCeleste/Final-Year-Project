Imports SchoolManagement.ServiceHistory
Public Class ServiceHistory
    Private Access As New DBControl
    Public Shared RepairID As Integer

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Public Sub LoadElectrical()
        Access.ExecQuery("SELECT ElectID AS [Repair ID], Company, ItemRepaired AS [Item], RepairType AS [Type of Repair],
                        RepairDate AS [Date], [Details], RepairCost AS Cost
                        FROM Electrical")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        dgvHistory.DataSource = Access.DBDT
        dgvHistory.AutoResizeColumns()
        dgvHistory.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells
        RepairID = dgvHistory.Rows.Count
        RepairID.ToString()
    End Sub

    Private Sub ServiceHistory_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Electrical Service History"
        LoadElectrical()
    End Sub

    ' Form Theme Colours
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.MediumSlateBlue
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
        Me.dgvHistory.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvHistory.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvHistory.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvHistory.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvHistory.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvHistory.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvHistory.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvHistory.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvHistory.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvHistory.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvHistory.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvHistory.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvHistory.BackgroundColor = Color.Violet
    End Sub

    Public Sub ElectricalBtn_Click(sender As Object, e As EventArgs) Handles ElectricalBtn.Click
        LoadElectrical()
        Me.Text = Form1.User & " - Electrical Service History"
    End Sub

    Public Sub LoadEquip()
        Access.ExecQuery("SELECT EquipID AS [Repair ID], Company, ItemRepaired AS [Item], RepairType AS [Type of Repair],
                        RepairDate AS [Date], [Details], RepairCost AS Cost
                        FROM Equipment")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        dgvHistory.DataSource = Access.DBDT
        dgvHistory.AutoResizeColumns()
        dgvHistory.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub EquipBtn_Click(sender As Object, e As EventArgs) Handles EquipBtn.Click
        LoadEquip()
        Me.Text = Form1.User & " - Equipment Service History"
    End Sub

    Public Sub LoadPlumbing()
        Access.ExecQuery("SELECT PlumbID AS [Repair ID], Company, ItemRepaired AS [Item], RepairType AS [Type of Repair],
                        RepairDate AS [Date], [Details], RepairCost AS Cost
                        FROM Plumbing")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        dgvHistory.DataSource = Access.DBDT
        dgvHistory.AutoResizeColumns()
        dgvHistory.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub PlumbingBtn_Click(sender As Object, e As EventArgs) Handles PlumbingBtn.Click
        LoadPlumbing()
        Me.Text = Form1.User & " - Plumbing Service History"
    End Sub

    Public Sub LoadVehServices()
        Access.ExecQuery("SELECT ServiceID AS [Service ID], ServiceName AS [Name of Service], ServiceType AS [Type of Service],
                            Vehicle, Details, ServiceDate AS [Date], ServiceCost AS Cost
                            FROM VehicleServices")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        dgvHistory.DataSource = Access.DBDT
        dgvHistory.AutoResizeColumns()
        dgvHistory.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub VehiclesBtn_Click(sender As Object, e As EventArgs) Handles VehiclesBtn.Click
        LoadVehServices()
        Me.Text = Form1.User & " - Vehicles Service History"
    End Sub

    Public Sub LoadServiceCompanies()
        Access.ExecQuery("SELECT CompanyID AS [Company ID], Company, [Address], Suburb, PostalCode AS [Postal Code], Telephone, Email
                            FROM ServiceCompanies")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        dgvHistory.DataSource = Access.DBDT
        dgvHistory.AutoResizeColumns()
        dgvHistory.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub CompanyBtn_Click(sender As Object, e As EventArgs) Handles CompanyBtn.Click
        LoadServiceCompanies()
    End Sub

    Private Sub ServiceCompanyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiceCompanyToolStripMenuItem.Click
        ServiceCompanies.Show()
    End Sub

    Private Sub ServiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiceToolStripMenuItem.Click
        NewService.Show()
    End Sub

    Private Sub VehicleServiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VehicleServiceToolStripMenuItem.Click
        VehicleService.Show()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class