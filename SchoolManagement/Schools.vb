﻿Imports SchoolManagement.Form1
Public Class Schools
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub LoadSchools()
        Access.ExecQuery("SELECT SchoolID AS [School ID], SchoolName AS School, Principal, [Address], Suburb, PCode AS [Postal Code],
                            TelNumber AS Telephone, FaxNumber AS [Fax Number], Email
                            FROM Schools")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        dgvSchools.DataSource = Access.DBDT
        dgvSchools.AutoResizeColumns()
        dgvSchools.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub Schools_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Schools"
        LoadSchools()
    End Sub

    ' Form Theme Colours
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.Plum
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
        Me.dgvSchools.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvSchools.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvSchools.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvSchools.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvSchools.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvSchools.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvSchools.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvSchools.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvSchools.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvSchools.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvSchools.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvSchools.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvSchools.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvSchools.BackgroundColor = Color.White
    End Sub

    Private Sub SchoolBox_TextChanged(sender As Object, e As EventArgs) Handles SchoolBox.TextChanged
        Dim SchID As Integer
        Dim Cyear As String = DateTime.Now.ToString("yy")
        Dim STotal As Integer
        STotal = dgvSchools.Rows.Count + 1
        Try
            If Not String.IsNullOrWhiteSpace(SchoolBox.Text) Then
                SchID = Cyear &
                    STotal = +1
                STotal.ToString()
            End If
            SchID = Cyear & STotal.ToString
        Catch ex As Exception
            MsgBox("Error Generating Organisation ID!", MsgBoxStyle.Critical, "Error!")
        End Try
        SchoolID.Text = "SCH-" & SchID.ToString
    End Sub

    Private Sub Textbox_Validation(sender As Object, e As EventArgs) Handles PrincipalBox.TextChanged, SchoolBox.TextChanged,
            AddressBox.TextChanged, SuburbBox.TextChanged, CodeBox.TextChanged, TelBox.TextChanged, FaxBox.TextChanged, EmailBox.TextChanged
        If Not String.IsNullOrWhiteSpace(SchoolBox.Text) And
                Not String.IsNullOrWhiteSpace(PrincipalBox.Text) And
                Not String.IsNullOrWhiteSpace(AddressBox.Text) And
               Not String.IsNullOrWhiteSpace(SuburbBox.Text) And
               Not String.IsNullOrWhiteSpace(CodeBox.Text) And
               Not String.IsNullOrWhiteSpace(TelBox.Text) And
               Not String.IsNullOrWhiteSpace(FaxBox.Text) And
               Not String.IsNullOrWhiteSpace(EmailBox.Text) Then
            SaveBtn.Enabled = True
        End If
    End Sub

    Private Sub SaveSchools()
        Access.AddParam("@sid", SchoolID.Text)
        Access.AddParam("@sname", SchoolBox.Text)
        Access.AddParam("@princ", PrincipalBox.Text)
        Access.AddParam("@add", AddressBox.Text)
        Access.AddParam("@sub", SuburbBox.Text)
        Access.AddParam("@pcode", CodeBox.Text)
        Access.AddParam("@tel", TelBox.Text)
        Access.AddParam("@fax", FaxBox.Text)
        Access.AddParam("@email", EmailBox.Text)

        Access.ExecQuery("INSERT INTO Schools (SchoolID, SchoolName, Principal, [Address], Suburb, PCode, TelNumber, FaxNumber, Email) " &
                         "VALUES (@sid, @sname, @princ, @add, @sub, @pcode, @tel, @fax, @email); ")
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception)
        End If
        MsgBox("School Information Added Successfully!", MsgBoxStyle.Information, "Success!")
        LoadSchools()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        SaveSchools()
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        SchoolID.Text = 0
        SchoolBox.Text = ""
        PrincipalBox.Text = ""
        AddressBox.Text = ""
        SuburbBox.Text = ""
        CodeBox.Text = ""
        TelBox.Text = ""
        FaxBox.Text = ""
        EmailBox.Text = ""
        SaveBtn.Enabled = False
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class