﻿Imports SchoolManagement.Form1
Public Class AssetReg
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub LoadAssets()
        Access.ExecQuery("SELECT StockID AS [Stock ID], StockName AS [Stock Name], PurchaseDate AS [Date of Purchase], 
                                PurchasePrice AS Price, PurchaseLocation AS [Location]
                                FROM StockRegister")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        dgvAssets.DataSource = Access.DBDT
        dgvAssets.AutoResizeColumns()
        dgvAssets.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub AssetReg_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Asset Register"
        LoadAssets()
    End Sub

    ' Form Theme Colours
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.Orange
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
        Me.dgvAssets.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvAssets.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvAssets.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvAssets.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvAssets.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvAssets.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvAssets.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvAssets.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvAssets.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvAssets.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvAssets.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvAssets.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvAssets.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvAssets.BackgroundColor = Color.White
    End Sub

    Private Sub AssetBox_TextChanged(sender As Object, e As EventArgs) Handles AssetBox.TextChanged
        Dim AssID As Integer
        Dim Cyear As String = DateTime.Now.ToString("yy")
        Dim ATotal As Integer
        ATotal = dgvAssets.Rows.Count + 1
        Try
            If Not String.IsNullOrWhiteSpace(AssetBox.Text) Then
                AssID = Cyear &
                    ATotal = +1
                ATotal.ToString()
            End If
            AssID = Cyear & ATotal.ToString
        Catch ex As Exception
            MsgBox("Error Generating Organisation ID!", MsgBoxStyle.Critical, "Error!")
        End Try
        AssetID.Text = "AST-" & AssID.ToString
    End Sub

    Private Sub Textbox_Validation(sender As Object, e As EventArgs) Handles PriceBox.TextChanged, AssetBox.TextChanged, LocationBox.TextChanged
        If Not String.IsNullOrWhiteSpace(AssetBox.Text) And
                Not String.IsNullOrWhiteSpace(PriceBox.Text) And
                Not String.IsNullOrWhiteSpace(LocationBox.Text) Then
            SaveBtn.Enabled = True
        End If
    End Sub

    Private Sub SaveAssets()
        Access.AddParam("@sid", AssetID.Text)
        Access.AddParam("@sname", AssetBox.Text)
        Access.AddParam("@pdate", DateBox.Value.ToShortDateString)
        Access.AddParam("@price", PriceBox.Text)
        Access.AddParam("@loc", LocationBox.Text)

        Access.ExecQuery("INSERT INTO  StockRegister (AssetID, AssetName, PurchaseDate, PurchasePrice, PurchaseLocation) " &
                         "VALUES (@sid, @sname, @pdate, @price, @loc); ")
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception)
        End If
        MsgBox("Asset Information Added Successfully!", MsgBoxStyle.Information, "Success!")
        LoadAssets()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        SaveAssets()
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        AssetID.Text = 0
        AssetBox.Text = ""
        DateBox.Value = Date.Now
        PriceBox.Text = "R"
        LocationBox.Text = ""
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class