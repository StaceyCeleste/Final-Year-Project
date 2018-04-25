Imports SchoolManagement.Form1
Public Class CurrentParent
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Public Sub LoadParents()
        Access.ExecQuery("SELECT [ID], ParentInitials AS [Parent Initials], ParentName AS [Name], ParentSurname AS [Surname],
                            Occupation, StudentName AS [Student Name], StudentNum AS [Student Number]
                            FROM ParentDetails")

        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        ' Fills DataGridView
        dgvParentInfo.DataSource = Access.DBDT

        ' Autosize DGV column width
        dgvParentInfo.AutoResizeColumns()
        dgvParentInfo.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub CurrentParent_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Current Parents"
        LoadParents()
    End Sub

    ' Form Theme Colours
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.MediumOrchid
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
        Me.BackColor = Color.Pink
    End Sub

    Private Sub SilverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SilverToolStripMenuItem.Click
        Me.BackColor = Color.Silver
    End Sub

    ' DataGridView Theme Colours
    Private Sub DefaultToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem1.Click
        Me.dgvParentInfo.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvParentInfo.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvParentInfo.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvParentInfo.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvParentInfo.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvParentInfo.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvParentInfo.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvParentInfo.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvParentInfo.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvParentInfo.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvParentInfo.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvParentInfo.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvParentInfo.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvParentInfo.BackgroundColor = Color.White
    End Sub

    ' Load Parent Details Method
    Private Sub LoadDetails()
        Access.ExecQuery("SELECT [ID], ParentInitials AS [Parent Initials], ParentName AS [Name], ParentSurname AS [Surname],
                            Occupation, StudentName AS [Student Name], StudentNum AS [Student Number]
                            FROM ParentDetails")

        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        ' Fills DataGridView
        dgvParentInfo.DataSource = Access.DBDT

        ' Autosize DGV column width
        dgvParentInfo.AutoResizeColumns()
        dgvParentInfo.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    ' Details Button
    Private Sub DetailsBtn_Click(sender As Object, e As EventArgs) Handles DetailsBtn.Click
        LoadDetails()
    End Sub

    ' Load Parent Address Details Method
    Public Sub LoadAddress()
        Access.ExecQuery("SELECT ParentID AS [Parent ID], ParentName AS [Name], ParentSurname AS Surname, PhysicalAdd AS [Address],
                            Suburb, City, Province, PCode AS [Postal Code]
                            FROM ParentAddress")

        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        ' Fills DataGridView
        dgvParentInfo.DataSource = Access.DBDT

        ' Autosize DGV column width
        dgvParentInfo.AutoResizeColumns()
        dgvParentInfo.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    ' Address Button
    Private Sub AddressBtn_Click(sender As Object, e As EventArgs) Handles AddressBtn.Click
        LoadAddress()
    End Sub

    ' Load Parent Contact Details Method
    Public Sub LoadContacts()
        Access.ExecQuery("SELECT ParentID AS [Parent ID], ParentName AS [Name], ParentSurname AS Surname, HomeNum AS [Home Number],
                            [Cellphone], EmergCont AS [Emergency Contact], EmContName AS [Contact Name], [Email]
                                FROM ParentContact")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        ' Fills DataGridView
        dgvParentInfo.DataSource = Access.DBDT

        ' Autosize DGV column width
        dgvParentInfo.AutoResizeColumns()
        dgvParentInfo.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    ' Contact Button
    Private Sub ContactBtn_Click(sender As Object, e As EventArgs) Handles ContactBtn.Click
        LoadContacts()
    End Sub

    ' Load Interview Results Method
    Public Sub LoadInterviews()
        Access.ExecQuery("SELECT ParentID AS [ID], InterviewDate AS [Interview Date], IntervieweeName AS [Name],
                    IntervieweeSurname AS Surname, InterviewDets AS [Interview Details]
                    FROM ParentInterviewResults")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        ' Fills DataGridView
        dgvParentInfo.DataSource = Access.DBDT

        ' Autosize DGV column width
        dgvParentInfo.AutoResizeColumns()
        dgvParentInfo.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    ' Interviews Button
    Private Sub InterviewBtn_Click(sender As Object, e As EventArgs) Handles InterviewBtn.Click
        LoadInterviews()
    End Sub

    ' Add New Parents Button
    Private Sub NewBtn_Click(sender As Object, e As EventArgs) Handles NewBtn.Click
        Parents.Show()
    End Sub

    ' Exit Button
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Me.Close()
    End Sub

    Private Sub ParentDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParentDetailsToolStripMenuItem.Click
        EditParentDetails.Show()
    End Sub

    Private Sub ContactDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactDetailsToolStripMenuItem.Click
        EditParentContact.Show()
    End Sub

    Private Sub InterviewResultsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InterviewResultsToolStripMenuItem.Click
        EditInterviewResults.Show()
    End Sub

    Private Sub AddressDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddressDetailsToolStripMenuItem.Click
        EditParentAddress.Show()
    End Sub
End Class