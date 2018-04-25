Imports SchoolManagement.Form1
Public Class ExistingStaff
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Public Sub LoadStaffMembers()
        Access.ExecQuery("SELECT PersalNum AS [Persal Number], IDNum AS [ID Number], Gender, StaffInitials AS [Initials], StaffName AS [Name],
                            StaffSecName AS [Second Name], StaffSurname AS Surname, Ethnicity, BirthDate AS [Date of Birth],
                            HireDate AS [Hire Date], Occupation, Phase
                            FROM StaffDetails")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        ' Fills DataGridView
        dgvStaff.DataSource = Access.DBDT

        ' Autosize DGV column width
        dgvStaff.AutoResizeColumns()
        dgvStaff.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells

        ' Calculates Total Number of Staff Members
        TotalStaff.Text = dgvStaff.RowCount
    End Sub

    Private Sub ExistingStaff_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Current Staff Members"
        LoadStaffMembers()
    End Sub

    ' Form Theme Colours
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.IndianRed
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
        Me.dgvStaff.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvStaff.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvStaff.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrayToolStripMenuItem.Click
        Me.dgvStaff.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvStaff.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvStaff.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvStaff.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvStaff.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvStaff.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvStaff.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvStaff.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvStaff.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvStaff.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvStaff.BackgroundColor = Color.White
    End Sub

    ' Search Staff by Name
    Private Sub StaffNameSearch(SName As String)
        ' Adds Parameters and runs query 
        Access.AddParam("@name", "%" & Name & "%")
        Access.ExecQuery("SELECT PersalNum AS [Persal Number], IDNum AS [ID Number], Gender, StaffInitials AS [Initials], StaffName AS [Name],
                            StaffSecName AS [Second Name], StaffSurname AS Surname, Ethnicity, BirthDate AS [Date of Birth],
                            HireDate AS [Hire Date], Occupation, Phase
                            FROM StaffDetails")

        ' Reports and Aborts on Errors
        If NotEmpty(Access.Exception) Then
            MsgBox(Access.Exception) : Exit Sub
        End If

        ' Fills DataGridView
        dgvStaff.DataSource = Access.DBDT

        ' Autosize DGV Column Width
        dgvStaff.AutoResizeColumns()
        dgvStaff.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    ' Name search textbox
    Private Sub NameSearch_TextChanged(sender As Object, e As EventArgs) Handles NameSearch.TextChanged
        StaffNameSearch(NameSearch.Text)
    End Sub

    ' Search Staff by Surname
    Private Sub StaffSurnameSearch(Surname As String)
        ' Adds Parameters and runs query 
        Access.AddParam("@surname", "%" & Surname & "%")
        Access.ExecQuery("SELECT PersalNum AS [Persal Number], IDNum AS [ID Number], Gender, StaffInitials AS [Initials], StaffName AS [Name],
                            StaffSecName AS [Second Name], StaffSurname AS Surname, Ethnicity, BirthDate AS [Date of Birth],
                            HireDate AS [Hire Date], Occupation, Phase
                            FROM StaffDetails")

        ' Reports and Aborts on Errors
        If NotEmpty(Access.Exception) Then
            MsgBox(Access.Exception) : Exit Sub
        End If

        ' Fills DataGridView
        dgvStaff.DataSource = Access.DBDT

        ' Autosize DGV Column Width
        dgvStaff.AutoResizeColumns()
        dgvStaff.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    ' Surname Search Textbox
    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        StaffSurnameSearch(SearchBox.Text)
    End Sub

    ' Details Button
    Private Sub DetailsBtn_Click(sender As Object, e As EventArgs) Handles DetailsBtn.Click
        LoadStaffMembers()
    End Sub

    ' Load Address Method
    Public Sub LoadAddress()
        Access.ExecQuery("SELECT PersalNum AS [Persal Number], StaffName AS [Name], StaffSurname AS Surname, StaffAddress AS [Address], StaffSuburb AS Suburb, StaffCity AS City,
                            StaffProvince AS Province, StaffPCode AS [Postal Code]
                            FROM StaffAddress")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        dgvStaff.DataSource = Access.DBDT

        ' Autosizes DGV Column Width
        dgvStaff.AutoResizeColumns()
        dgvStaff.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    ' Address Button
    Private Sub AddressBtn_Click(sender As Object, e As EventArgs) Handles AddressBtn.Click
        LoadAddress()
    End Sub

    ' Load Contact Method
    Public Sub LoadContact()
        Access.ExecQuery("SELECT PersalNum AS [Persal Number], StaffName AS [Name], StaffSurname AS Surname, HomeNum AS [Home Number], CellNum AS [Cell Number],
                            EmContNum AS [Emergency Contact], ContactName AS [Contact Name], StaffEmail AS Email
                            FROM StaffContact")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        dgvStaff.DataSource = Access.DBDT

        ' Autosizes DGV Column Width
        dgvStaff.AutoResizeColumns()
        dgvStaff.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    ' Contact Button
    Private Sub ContactBtn_Click(sender As Object, e As EventArgs) Handles ContactBtn.Click
        LoadContact()
    End Sub

    ' Add New Staff Member Button
    Private Sub NewBtn_Click(sender As Object, e As EventArgs) Handles NewBtn.Click
        AddStaff.Show()
    End Sub

    ' Exit Button
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub StaffDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffDetailsToolStripMenuItem.Click
        EditStaffDets.Show()
    End Sub

    Private Sub ContactDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactDetailsToolStripMenuItem.Click
        EditStaffContact.Show()
    End Sub

    Private Sub AddressDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddressDetailsToolStripMenuItem.Click
        EditStaffAddress.Show()
    End Sub
End Class