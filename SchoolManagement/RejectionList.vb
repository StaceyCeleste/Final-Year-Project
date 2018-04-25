Imports SchoolManagement.Form1
Public Class RejectionList
    Private Access As New DBControl

    Private Sub RejectionList_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Rejection List"
        Grid_Refresh()
    End Sub

    Public Sub Grid_Refresh()

        Access.ExecQuery("SELECT RejectID AS [Rejection ID], TrackingNum AS [Tracking Number], StudentName AS [Name], 
                            StudentSurname AS Surname, Reason As [Reason for Rejection]
                               FROM RejectionList")

        dgvReject.DataSource = Access.DBDT

        ' Autosize DGV column width
        dgvReject.AutoResizeColumns()
        dgvReject.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells

    End Sub

    ' Form Theme Colours
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.LightGreen
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
        Me.dgvReject.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvReject.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvReject.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvReject.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvReject.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvReject.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvReject.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvReject.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvReject.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvReject.BackgroundColor = Color.Pink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvReject.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvReject.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvReject.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvReject.BackgroundColor = Color.White
    End Sub

    Private Sub AddRejectList()

        ' Adds Parameters
        Access.AddParam("@rejectid", RejectLabel.Text)
        Access.AddParam("@track", TrackNumBox.Text)
        Access.AddParam("@sname", NameBox.Text)
        Access.AddParam("@surname", SurnameBox.Text)
        Access.AddParam("@reason", ReasonBox.Text)

        Access.ExecQuery("INSERT INTO RejectionList (RejectID, TrackingNum, StudentName, StudentSurname, Reason) " &
            "VALUES (@rejectid, @track, @sname, @surname, @reason); ")

        ' Reports and aborts any errors
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception) : Exit Sub
        End If
        ' Success Message 
        MsgBox("Student Added To Rejection List Successfully!", MsgBoxStyle.Information, "Success")

        Me.Grid_Refresh()

    End Sub

    Private Sub ExitStripBtn_Click(sender As Object, e As EventArgs) Handles ExitStripBtn.Click
        Me.Close()
    End Sub

    Private Sub SurnameBox_TextChanged(sender As Object, e As EventArgs) Handles SurnameBox.TextChanged
        Dim cyear As String = DateTime.Now.ToString("yy")
        Dim Rnumber As Integer
        Dim Stotal As Integer
        Stotal = dgvReject.RowCount
        Try
            If Not String.IsNullOrWhiteSpace(SurnameBox.Text) Then
                Rnumber = cyear &
                    Stotal = +1
                Stotal.ToString("0000")
            End If

            Dim Cdigit As String = Rnumber
            Dim Total As Integer = 0
            For Each s As String In Cdigit
                Total += Convert.ToInt32(s)
                Cdigit = (Total Mod 10)
                If Cdigit > 0 Then
                    Cdigit = 10 - Cdigit
                End If
            Next

            Rnumber = cyear & Stotal.ToString & Cdigit.ToString
        Catch ex As Exception
            MsgBox("Error Generating Rejection ID!", MsgBoxStyle.Critical, "Error!")
        End Try
        RejectLabel.Text = Rnumber.ToString
    End Sub

    Private Sub TextBox_Validation(sender As Object, e As EventArgs) Handles TrackNumBox.TextChanged, NameBox.TextChanged,
            SurnameBox.TextChanged
        If Not String.IsNullOrWhiteSpace(TrackNumBox.Text) And
               Not String.IsNullOrWhiteSpace(NameBox.Text) And
           Not String.IsNullOrWhiteSpace(SurnameBox.Text) And
           Not String.IsNullOrWhiteSpace(ReasonBox.Text) Then
            SaveStrip.Enabled = True
        End If
    End Sub

    Private Sub ClearAllBtn_Click(sender As Object, e As EventArgs) Handles ClearAllBtn.Click
        RejectLabel.Text = 0
        TrackNumBox.Text = ""
        NameBox.Text = ""
        SurnameBox.Text = ""
        ReasonBox.Text = ""
        SaveStrip.Enabled = False
    End Sub

    Private Sub SaveStrip_Click(sender As Object, e As EventArgs) Handles SaveStrip.Click
        AddRejectList()
    End Sub
End Class