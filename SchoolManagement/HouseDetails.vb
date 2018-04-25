Imports SchoolManagement.Form1
Public Class HouseDetails
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub LoadHouseDets()
        Access.ExecQuery("SELECT HouseID AS [House ID], HouseName AS [House Name], HouseColour AS Colour, HouseDescription AS [Description]
                            FROM HouseDetails")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        ' Fills DataGridView
        dgvHouses.DataSource = Access.DBDT

        ' Resizes Columns
        dgvHouses.AutoResizeColumns()
        dgvHouses.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnMode.AllCells
    End Sub

    Private Sub HouseDetails_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Sports House Details"
        LoadHouseDets()
    End Sub

    ' Form Theme Colours
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.MediumSpringGreen
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
        Me.dgvHouses.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvHouses.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvHouses.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvHouses.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvHouses.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvHouses.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvHouses.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvHouses.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvHouses.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvHouses.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvHouses.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvHouses.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvHouses.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvHouses.BackgroundColor = Color.White
    End Sub

    ' Auto Generates House ID 
    Private Sub HNameBox_TextChanged(sender As Object, e As EventArgs) Handles HNameBox.TextChanged
        Dim HouseID As Integer
        Dim Cyear As String = DateTime.Now.ToString("yy")
        Dim HTotal As Integer
        HTotal = dgvHouses.RowCount
        Try
            If Not String.IsNullOrWhiteSpace(HNameBox.Text) Then
                HouseID = Cyear &
                    HTotal = +1
                HTotal.ToString()
            End If
            HouseID = Cyear & HTotal.ToString
        Catch ex As Exception
            MsgBox("Error Generating House ID!", MsgBoxStyle.Critical, "Error!")
        End Try
        HouseIDLabel.Text = "H" & HouseID.ToString
    End Sub

    ' Textbox Validation
    Private Sub ColourBox_TextChanged(sender As Object, e As EventArgs) Handles ColourBox.TextChanged, HNameBox.TextChanged, DescripBox.TextChanged
        If Not String.IsNullOrWhiteSpace(HNameBox.Text) And
                Not String.IsNullOrWhiteSpace(ColourBox.Text) And
                Not String.IsNullOrWhiteSpace(DescripBox.Text) Then
            SaveTool.Enabled = True
        End If
    End Sub

    ' Save House Details Method
    Private Sub SaveHouseDets()
        Access.AddParam("@hid", HouseIDLabel.Text)
        Access.AddParam("@hname", HNameBox.Text)
        Access.AddParam("@hcol", ColourBox.Text)
        Access.AddParam("@descrip", DescripBox.Text)

        Access.ExecQuery("INSERT INTO HouseDetails (HouseID, HouseName, HouseColour, HouseDescription) " &
                         "VALUES (@hid, @hname, @hcol, @descrip); ")
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception)
            Exit Sub
        End If
        MsgBox("New House Details Added Successfully!", MsgBoxStyle.Information, "Success!")
        LoadHouseDets()
    End Sub

    ' Save Button
    Private Sub SaveTool_Click(sender As Object, e As EventArgs) Handles SaveTool.Click
        SaveHouseDets()
    End Sub

    ' Clear Button
    Private Sub ClearTool_Click(sender As Object, e As EventArgs) Handles ClearTool.Click
        HouseIDLabel.Text = 0
        HNameBox.Text = ""
        ColourBox.Text = ""
        DescripBox.Text = ""
        SaveTool.Enabled = False
    End Sub

    ' Exit Button
    Private Sub ExitTool_Click(sender As Object, e As EventArgs) Handles ExitTool.Click
        Me.Close()
    End Sub
End Class