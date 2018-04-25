Imports SchoolManagement.Form1
Public Class StockTakeRes
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub LoadResults()
        Access.ExecQuery("SELECT StockTakeID AS [StockTake ID], StockTakeDate AS [Date], Breakages, RedundantStock AS [Redundant Stock],
                                Losses, Results, [Comments] 
                                FROM StockTakeResults")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        dgvStockTake.DataSource = Access.DBDT
        dgvStockTake.AutoResizeColumns()
        dgvStockTake.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub StockTakeRes_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Stock Take Results"
        LoadResults()
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
        Me.dgvStockTake.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvStockTake.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvStockTake.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvStockTake.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvStockTake.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvStockTake.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvStockTake.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvStockTake.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvStockTake.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvStockTake.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvStockTake.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvStockTake.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvStockTake.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvStockTake.BackgroundColor = Color.White
    End Sub

    Private Sub Breakages_TextChanged(sender As Object, e As EventArgs) Handles Breakages.TextChanged
        Dim StockTakeID As Integer
        Dim Cyear As String = DateTime.Now.ToString("yy")
        Dim STotal As Integer
        STotal = dgvStockTake.Rows.Count + 1
        Try
            If Not String.IsNullOrWhiteSpace(Breakages.Text) Then
                StockTakeID = Cyear &
                    STotal = +1
                STotal.ToString()
            End If
            StockTakeID = Cyear & STotal.ToString
        Catch ex As Exception
            MsgBox("Error Generating Organisation ID!", MsgBoxStyle.Critical, "Error!")
        End Try
        STID.Text = "ST-" & StockTakeID.ToString
    End Sub

    Private Sub RedStock_TextChanged(sender As Object, e As EventArgs) Handles RedStock.TextChanged, Breakages.TextChanged,
        LossesBox.TextChanged, ResultsBox.TextChanged, CommentsBox.TextChanged
        If Not String.IsNullOrWhiteSpace(Breakages.Text) And
                Not String.IsNullOrWhiteSpace(RedStock.Text) And
                Not String.IsNullOrWhiteSpace(LossesBox.Text) And
                Not String.IsNullOrWhiteSpace(ResultsBox.Text) And
                Not String.IsNullOrWhiteSpace(CommentsBox.Text) Then
            SaveBtn.Enabled = True
        End If
    End Sub

    Private Sub SaveResults()
        Access.AddParam("@stid", STID.Text)
        Access.AddParam("@sdate", DateBox.Value.ToShortDateString)
        Access.AddParam("@brk", Breakages.Text)
        Access.AddParam("@rstock", RedStock.Text)
        Access.AddParam("@los", LossesBox.Text)
        Access.AddParam("@res", ResultsBox.Text)
        Access.AddParam("@comms", CommentsBox.Text)

        Access.ExecQuery("INSERT INTO  StockTakeResults (StockTakeID, StockTakeDate, Breakages, RedundantStock, Losses, Results, [Comments]) " &
                         "VALUES (@stid, @sdate, @brk, @rstock, @los, @res, @comms); ")
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception)
        End If
        MsgBox("Stock Take Results Recorded Successfully!", MsgBoxStyle.Information, "Success!")
        LoadResults()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        SaveResults()
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        STID.Text = 0
        DateBox.Value = Date.Now
        Breakages.Text = ""
        RedStock.Text = ""
        LossesBox.Text = ""
        ResultsBox.Text = ""
        CommentsBox.Text = ""
        SaveBtn.Enabled = False
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class