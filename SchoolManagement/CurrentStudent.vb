Imports SchoolManagement.Form1
Public Class CurrentStudent
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub CurrentStudent_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Current Students"
        RefreshGrid()
    End Sub

    Public Sub RefreshGrid()
        ' Runs query
        Access.ExecQuery("SELECT TrackingNum As [Tracking Number], IDNum As [ID Number], t2.StudentNum As [Student Number],
            RegDate As [Registration Date], Gender, StuInitials As Initials, t1.StuName As [Name], StuSecName As [Second Name],
            t1.StuSurname As Surname, StuEthnicity As Ethnicity, StuBirthDate As [Birth Date], StuAge As Age, t2.StuCitizenship As Citizenship,
            t2.StuPrimLang As [Primary Language], t2.StuSecLang As [Secondary Language], t2.PrimDisability As [Primary Disability],
            t2.SecDisability As [Secondary Disability], t2.Weighting
            FROM StuDetails t1 INNER JOIN StuAdditional t2 ON t1.StudentNum = t2.StudentNum")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' Fills datagrid
        dgvData.DataSource = Access.DBDT

        ' Autosize DGV column width
        dgvData.AutoResizeColumns()
        dgvData.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells

        ' Calculates and Displays Total Students Weightings
        Dim Total As String = 0
        For i As Integer = 0 To dgvData.RowCount - 1
            Total += dgvData.Rows(i).Cells(17).Value
        Next
        TotalWeight.Text = Total

        ' Calculates and Displays row count - total number of students 
        TotalStudents.Text = dgvData.RowCount
    End Sub

    Private Sub StudentSurnameSearch(Surname As String)
        ' Adds Parameters and runs query 
        Access.AddParam("@surname", "%" & Surname & "%")
        Access.ExecQuery("SELECT TrackingNum As [Tracking Number], IDNum As [ID Number], t2.StudentNum As [Student Number],
            RegDate As [Registration Date], Gender, StuInitials As Initials, StuName As [Name], StuSecName As [Second Name],
            StuSurname As Surname, StuEthnicity As Ethnicity, StuBirthDate As [Birth Date], StuAge As Age, t2.StuCitizenship As Citizenship,
            t2.StuPrimLang As [Primary Language], t2.StuSecLang As [Secondary Language], t2.PrimDisability As [Primary Disability],
            t2.SecDisability As [Secondary Disability], t2.Weighting
            FROM StuDetails t1 INNER JOIN StuAdditional t2 ON t1.StudentNum = t2.StudentNum
            WHERE StuSurname LIKE @surname")

        ' Reports and Aborts on Errors
        If NotEmpty(Access.Exception) Then
            MsgBox(Access.Exception) : Exit Sub
        End If

        ' Fills DataGridView
        dgvData.DataSource = Access.DBDT

        ' Autosize DGV Column Width
        dgvData.AutoResizeColumns()
        dgvData.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells

    End Sub

    Private Sub StudentNameSearch(SName As String)
        ' Adds Parameters and runs query 
        Access.AddParam("@name", "%" & Name & "%")
        Access.ExecQuery("SELECT TrackingNum As [Tracking Number], IDNum As [ID Number], t2.StudentNum As [Student Number],
            RegDate As [Registration Date], Gender, StuInitials As Initials, StuName As [Name], StuSecName As [Second Name],
            StuSurname As Surname, StuEthnicity As Ethnicity, StuBirthDate As [Birth Date], StuAge As Age, t2.StuCitizenship As Citizenship,
            t2.StuPrimLang As [Primary Language], t2.StuSecLang As [Secondary Language], t2.PrimDisability As [Primary Disability],
            t2.SecDisability As [Secondary Disability], t2.Weighting
            FROM StuDetails t1 INNER JOIN StuAdditional t2 ON t1.StudentNum = t2.StudentNum
            WHERE StuName LIKE @name")

        ' Reports and Aborts on Errors
        If NotEmpty(Access.Exception) Then
            MsgBox(Access.Exception) : Exit Sub
        End If

        ' Fills DataGridView
        dgvData.DataSource = Access.DBDT

        ' Autosize DGV Column Width
        dgvData.AutoResizeColumns()
        dgvData.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells

    End Sub

    ' Search Student Button
    Private Sub SearchStudent_Click(sender As Object, e As EventArgs)
        StudentSurnameSearch(SearchBox.Text)
    End Sub

    ' Toolstrip Menu Theme Colours - DataGridView Themes
    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        Me.dgvData.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvData.BackgroundColor = Color.Coral
    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        Me.dgvData.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvData.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvData.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvData.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem.Click
        Me.dgvData.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem.Click
        Me.dgvData.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem.Click
        Me.dgvData.BackgroundColor = Color.Pink
    End Sub

    Private Sub PurpleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem.Click
        Me.dgvData.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvData.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem1.Click
        Me.dgvData.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvData.BackgroundColor = Color.White
    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        Me.dgvData.BackgroundColor = Color.DarkGray
    End Sub

    ' Toolstrip Menu Theme Colours - Form Colours
    Private Sub NormalToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem1.Click
        Me.BackColor = Color.LightGreen
    End Sub

    Private Sub BlueToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem1.Click
        Me.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub CoralToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem1.Click
        Me.BackColor = Color.LightCoral
    End Sub

    Private Sub GreenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem1.Click
        Me.BackColor = Color.LimeGreen
    End Sub

    Private Sub GreyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem1.Click
        Me.BackColor = Color.Silver
    End Sub

    Private Sub LightBlueToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem1.Click
        Me.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub LightPinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem1.Click
        Me.BackColor = Color.HotPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.BackColor = Color.Orange
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.BackColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.BackColor = Color.Pink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.BackColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem1.Click
        Me.BackColor = Color.DarkRed
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.BackColor = Color.DarkViolet
    End Sub

    Private Sub WhiteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem1.Click
        Me.BackColor = Color.Ivory
    End Sub

    ' Toolstrip Menu Exit Button
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    ' Student Address Button
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Access.ExecQuery("SELECT TrackingNum As [Tracking Number], StuName As [Name], StuSurname As Surname, StuAddress As Address,
                            StuSuburb As Suburb, StuCity As City, StuProvince As Province, StuPCode As [Postal Code], StuCountry As Country
                            FROM StuAddress")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' Fills DataGrid
        dgvData.DataSource = Access.DBDT

        ' Autosizes DGV Column Width
        dgvData.AutoResizeColumns()
        dgvData.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells

    End Sub

    'Toolstrip Menu Student Details Button
    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        RefreshGrid()
    End Sub

    ' Toolstrip Menu Student Contact Details Button
    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        ' Runs query
        Access.ExecQuery("SELECT StudentNum As [Student Number], StuName As [Name], StuSurname As Surname, 
                            StuEmergCont As [Emergency Contact Number], StuEmContName As [Emergency Contact Name],
                            StuHomeTel As [Home Number], StuCellTel As [Cellphone Number], StuEmail As Email
                            FROM StuContact")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' Fills DataGridView
        dgvData.DataSource = Access.DBDT

        ' Autosize DGV Column Width
        dgvData.AutoResizeColumns()
        dgvData.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells

    End Sub

    ' Toolstrip Menu Student Illnesses Button
    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        ' Runs query
        Access.ExecQuery("SELECT TrackingNum As [Tracking Number], StuName As [Name], StuSurname As Surname, 
                            IllnessName As Illness, Medication, Dosage 
                            FROM StuIllnesses")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        '  Fills datagrid
        dgvData.DataSource = Access.DBDT

        ' Autosize DGV Column Width
        dgvData.AutoResizeColumns()
        dgvData.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells

    End Sub

    ' Toolstrip Menu Add Student Form Button
    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Form4.Show()
    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        StudentSurnameSearch(SearchBox.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles NameSearch.TextChanged
        StudentNameSearch(NameSearch.Text)
    End Sub

End Class