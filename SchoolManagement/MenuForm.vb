Imports SchoolManagement.Form1
Public Class MenuForm
    Private Access As New DBControl

    Public Sub LoadMenus()
        Access.ExecQuery("SELECT MenuID AS [Menu ID], MenuName AS [Menu Name], MenuDetails AS [Menu Details],
                            MenuDate AS [Menu Date], DayOfWeek AS [Day] 
                            FROM Menu")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        dgvMenu.DataSource = Access.DBDT

        ' Autosize DGV column width
        dgvMenu.AutoResizeColumns()
        dgvMenu.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub MenuForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Menu Details"
        LoadMenus()
    End Sub

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    ' Form Theme Images
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackgroundImage = Nothing
        Me.BackColor = Color.LightGreen
    End Sub

    Private Sub BeigeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeigeToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.OrangesAndLemons
    End Sub

    Private Sub BlueGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueGreenToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.StrawberriesAndBlueberries
    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Grapes
    End Sub

    Private Sub OrangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.Orange
    End Sub

    ' DataGridView Colour Themes
    Private Sub DefaultToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem1.Click
        Me.dgvMenu.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub GreenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem1.Click
        Me.dgvMenu.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LimeGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimeGreenToolStripMenuItem.Click
        Me.dgvMenu.BackgroundColor = Color.LimeGreen
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvMenu.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem.Click
        Me.dgvMenu.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub SaveMenus()
        Access.AddParam("@mid", MenuLabel.Text)
        Access.AddParam("@mname", MenuNameBox.Text)
        Access.AddParam("@menudets", DetailsBox.Text)
        Access.AddParam("@mdate", MenuDate.Value.ToShortDateString)
        Access.AddParam("@dow", WeekDayBox.Text)

        Access.ExecQuery("INSERT INTO Menu(MenuID, MenuName, MenuDetails, MenuDate, DayOfWeek) " &
                         "VALUES (@mid, @mname, @menudets, @mdate, @dow); ")

        ' Reports and aborts any errors
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception) : Exit Sub
        End If
        ' Success Message 
        MsgBox("New Menu Added Successfully!", MsgBoxStyle.Information, "Success!")
        LoadMenus()
    End Sub

    ' Textbox Validation
    Private Sub TextBox_Validation(sender As Object, e As EventArgs) Handles MenuNameBox.TextChanged, DetailsBox.TextChanged,
            WeekDayBox.TextChanged
        If Not String.IsNullOrWhiteSpace(MenuNameBox.Text) And
                Not String.IsNullOrWhiteSpace(DetailsBox.Text) And
                Not String.IsNullOrWhiteSpace(WeekDayBox.Text) Then
            SaveAllBtn.Enabled = True
        End If
    End Sub

    Private Sub MenuNameBox_TextChanged(sender As Object, e As EventArgs) Handles MenuNameBox.TextChanged
        Dim Cyear As String = DateTime.Now.ToString("MMdd")
        Dim MenuNum As Integer
        Dim STotal As Integer
        STotal = dgvMenu.RowCount
        Try
            If Not String.IsNullOrWhiteSpace(MenuNameBox.Text) Then
                MenuNum = Cyear &
                    STotal = +1
                STotal.ToString("0000")
            End If

            Dim Cdigit As String = MenuNum
            Dim Total As Integer = 0
            For Each s As String In Cdigit
                Total += Convert.ToInt32(s)
                Cdigit = (Total Mod 10)
                If Cdigit > 0 Then
                    Cdigit = 10 - Cdigit
                End If
            Next

            MenuNum = Cyear & STotal.ToString & Cdigit.ToString
        Catch ex As Exception
            MsgBox("Error Generating Menu ID!", MsgBoxStyle.Critical, "Error!")
        End Try
        MenuLabel.Text = MenuNum.ToString
    End Sub

    ' Save Button
    Private Sub SaveAllBtn_Click(sender As Object, e As EventArgs) Handles SaveAllBtn.Click
        SaveMenus()
    End Sub

    ' Clear All Button
    Private Sub ClearAllBtn_Click(sender As Object, e As EventArgs) Handles ClearAllBtn.Click
        MenuLabel.Text = 0
        MenuNameBox.Text = ""
        DetailsBox.Text = ""
        MenuDate.Value = Date.Now
        WeekDayBox.Text = ""
        SaveAllBtn.Enabled = False
    End Sub

    ' Exit Button
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        EditMenu.Show()
    End Sub
End Class