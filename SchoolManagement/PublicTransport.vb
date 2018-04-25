Imports SchoolManagement.Form1
Public Class PublicTransport
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub LoadPublicTrans()
        Access.ExecQuery("SELECT PubTransID AS [Transport ID], StudentName AS [Student Name], Suburb, TransportType AS [Transport Type]
                            FROM PublicTransport")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        dgvPublic.DataSource = Access.DBDT
        If Access.DBDT.Rows.Count > 0 Then
            dgvPublic.AutoResizeColumns()
            dgvPublic.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells
        End If
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

    Private Sub PublicTransport_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Public Transport Details"
        LoadPublicTrans()
        LoadStudents()
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
        Me.dgvPublic.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvPublic.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvPublic.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvPublic.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvPublic.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvPublic.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvPublic.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvPublic.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvPublic.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvPublic.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvPublic.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvPublic.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvPublic.BackgroundColor = Color.Violet
    End Sub

    Private Sub SuburbBox_TextChanged(sender As Object, e As EventArgs) Handles SuburbBox.TextChanged
        Dim PubTransportID As Integer
        Dim Cyear As String = DateTime.Now.ToString("yyyy")
        Dim PTtotal As Integer
        PTtotal = dgvPublic.Rows.Count
        Try
            If Not String.IsNullOrWhiteSpace(SuburbBox.Text) Then
                PubTransportID = Cyear &
                    PTtotal = +1
                PTtotal.ToString()
            End If
            PubTransportID = Cyear & PTtotal.ToString
        Catch ex As Exception
            MsgBox("Error Generating Public Transport ID!", MsgBoxStyle.Critical, "Error!")
        End Try
        TransID.Text = "PUB-" & PubTransportID.ToString
        SaveBtn.Enabled = True
    End Sub

    Private Sub SavePublic()
        Access.AddParam("ptid", TransID.Text)
        Access.AddParam("@sname", StudentBox.GetItemText(StudentBox.SelectedItem))
        Access.AddParam("@subb", SuburbBox.Text)
        Access.AddParam("@ttype", TypeBox.GetItemText(TypeBox.SelectedItem))

        Access.ExecQuery("INSERT INTO PublicTransport (PubTransID, StudentName, Suburb, TransportType) " &
                         "VALUES (@ptid, @sname, @subb, @ttype); ")
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception)
        End If
        MsgBox("Student Added To Public Transport List Successfully!", MsgBoxStyle.Information, "Success!")
        LoadPublicTrans()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        SavePublic()
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        TransID.Text = 0
        StudentBox.SelectedIndex = -1
        SuburbBox.Text = ""
        TypeBox.SelectedIndex = -1
        SaveBtn.Enabled = False
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class