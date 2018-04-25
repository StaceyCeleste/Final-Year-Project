Imports SchoolManagement.Form1
Public Class TransferList

    Private Accessor As New DBControl

    Private Sub TransferList_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Transfers List"
        DGV_Refresh()
    End Sub

    Public Sub DGV_Refresh()

        Accessor.ExecQuery("SELECT TransferId AS [Transfer ID], RegDate AS [Registration Date], StuName AS [Name], 
        Surname, Gender, LastGrade As [Last Grade], InOrOut AS [In/Out], ReferringSchool As [Referring School], 
        ReceivingSchool AS [Receiving School], DateLeft AS [Date Left], TransferReason As [Reason for Transfer]
        FROM TransfersList")

        dgvTransfer.DataSource = Accessor.DBDT

        ' Autosize DGV column width
        dgvTransfer.AutoResizeColumns()
        dgvTransfer.AutoSizeColumnsMode =
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

    Private Sub PurpleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem.Click
        Me.BackColor = Color.MediumPurple
    End Sub

    Private Sub SilverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SilverToolStripMenuItem.Click
        Me.BackColor = Color.Silver
    End Sub

    Private Sub DefaultToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem1.Click
        Me.dgvTransfer.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvTransfer.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvTransfer.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvTransfer.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvTransfer.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvTransfer.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvTransfer.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvTransfer.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvTransfer.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem.Click
        Me.dgvTransfer.BackgroundColor = Color.Pink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvTransfer.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvTransfer.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvTransfer.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvTransfer.BackgroundColor = Color.White
    End Sub

    ' Validates Textboxes - ensures data is entered in before enabling the Save Button
    Private Sub TextBox_Validation(sender As Object, e As EventArgs) Handles NameBox.TextChanged,
            SurnameBox.TextChanged, GradeBox.TextChanged, InOutBox.TextChanged, TransReasonBox.TextChanged
        If Not String.IsNullOrWhiteSpace(RegDate.Text) And
              Not String.IsNullOrWhiteSpace(NameBox.Text) And
          Not String.IsNullOrWhiteSpace(SurnameBox.Text) And
          Not String.IsNullOrWhiteSpace(GradeBox.Text) And
          Not String.IsNullOrWhiteSpace(InOutBox.Text) And
          Not String.IsNullOrWhiteSpace(TransReasonBox.Text) Then
            SaveToolBtn.Enabled = True
        End If

    End Sub

    Private Sub SurnameBox_TextChanged(sender As Object, e As EventArgs) Handles SurnameBox.TextChanged
        Dim Cyear As String = DateTime.Now.ToString("yyy")
        Dim Tnumber As Integer
        Dim TItotal As Integer
        TItotal = dgvTransfer.RowCount

        Try
            If Not String.IsNullOrWhiteSpace(SurnameBox.Text) Then
                Tnumber = Cyear &
                    TItotal = +1
                TItotal.ToString("00")
            End If

            Dim Cdigit As String = Tnumber
            Dim Total As Integer = 0
            For Each s As String In Cdigit
                Total += Convert.ToInt32(s)
                Cdigit = (Total Mod 10)
                If Cdigit > 0 Then
                    Cdigit = 10 - Cdigit
                End If
            Next

            Tnumber = Cyear & TItotal.ToString & Cdigit.ToString
        Catch ex As Exception
            MsgBox("Error Generating Transfer ID", MsgBoxStyle.Critical, "Error!")
        End Try
        TransIdLabel.Text = Tnumber.ToString
    End Sub

    ' Private Sub Creates Save Button Method to be used with Save Button
    Private Sub AddTransferList()

        ' Adds Parameters
        Accessor.AddParam("@transid", TransIdLabel.Text)
        Accessor.AddParam("@reg", RegDate.Value.ToShortDateString)
        Accessor.AddParam("@fname", NameBox.Text)
        Accessor.AddParam("@surname", SurnameBox.Text)
        If MaleBtn.Checked = True Then
            MaleBtn.Text = "Male"
            Accessor.AddParam("@gen", MaleBtn.Text)
        Else
            If FemaleBtn.Checked = True Then
                FemaleBtn.Text = "Female"
                Accessor.AddParam("@gen", FemaleBtn.Text)
            End If
        End If
        Accessor.AddParam("@grade", GradeBox.Text)
        Accessor.AddParam("@inout", InOutBox.Text)
        Accessor.AddParam("@refsch", RefSchool.Text)
        Accessor.AddParam("@recsch", RecSchool.Text)
        Accessor.AddParam("@leftdate", DateLeft.Value.ToShortDateString)
        Accessor.AddParam("@reason", TransReasonBox.Text)

        Accessor.ExecQuery("INSERT INTO TransfersList (TransferId, RegDate, StuName, Surname, Gender,
                            LastGrade, InOrOut, ReferringSchool, ReceivingSchool, DateLeft, TransferReason) " &
            "VALUES (@transid, @reg, @fname, @surname, @gen, @grade, @inout, @refsch, @recsch, @leftdate, @reason); ")

        ' Reports and aborts any errors
        If Not String.IsNullOrEmpty(Accessor.Exception) Then
            MsgBox(Accessor.Exception) : Exit Sub
        End If
        ' Success Message 
        MsgBox("Student Added To Transfers List Successfully!", MsgBoxStyle.Information, "Success!")

        Me.DGV_Refresh()

    End Sub

    ' Clear Button clears all data entered and resets date to current date
    Private Sub ClearToolBtn_Click(sender As Object, e As EventArgs) Handles ClearToolBtn.Click
        TransIdLabel.Text = "0"
        RegDate.Value = Date.Now
        NameBox.Text = ""
        SurnameBox.Text = ""
        MaleBtn.Checked = False
        FemaleBtn.Checked = False
        GradeBox.Text = ""
        InOutBox.Text = ""
        RefSchool.Text = ""
        RecSchool.Text = ""
        DateLeft.Value = Date.Now
        TransReasonBox.Text = ""
        SaveToolBtn.Enabled = False
    End Sub

    ' Exit Button exits the window
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    ' Save Button calls AddTransferList() Method and saves all data to database
    Private Sub SaveToolBtn_Click(sender As Object, e As EventArgs) Handles SaveToolBtn.Click
        AddTransferList()
    End Sub
End Class