Imports SchoolManagement.Form1
Imports SchoolManagement.ServiceHistory
Public Class NewService
    Private Access As New DBControl

    Private Sub NewService_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Add New Service Details"
    End Sub

    Private Function NotEmpty(text) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    ' Form Theme Colours
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.MediumSlateBlue
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

    Private Sub InvoiceBox_TextChanged(sender As Object, e As EventArgs) Handles InvoiceBox.TextChanged, CompanyBox.TextChanged,
            ItemBox.TextAlignChanged, DetailsBox.TextChanged, CostBox.TextChanged
        If Not String.IsNullOrWhiteSpace(InvoiceBox.Text) And
                Not String.IsNullOrWhiteSpace(CompanyBox.Text) And
                Not String.IsNullOrWhiteSpace(ItemBox.Text) And
                Not String.IsNullOrWhiteSpace(DetailsBox.Text) And
                Not String.IsNullOrWhiteSpace(CostBox.Text) Then
            SaveBtn.Enabled = True
        End If
    End Sub

    Private Sub SaveRepairs()
        Access.AddParam("@inv", InvoiceBox.Text)
        Access.AddParam("@comp", CompanyBox.Text)
        Access.AddParam("@irep", ItemBox.Text)
        Access.AddParam("@rtype", TypeBox.GetItemText(TypeBox.SelectedItem))
        Access.AddParam("@rdate", DateBox.Value.ToShortDateString)
        Access.AddParam("@dets", DetailsBox.Text)
        Access.AddParam("@cost", CostBox.Text)

        Select Case TypeBox.Text
            Case "Electrical"
                Access.ExecQuery("INSERT INTO Electrical (ElectID, Company, ItemRepaired, RepairType, RepairDate, Details, RepairCost) " &
                                 "VALUES (@inv, @comp, @irep, @rtype, @rdate, @dets, @cost); ")
                If Not String.IsNullOrEmpty(Access.Exception) Then
                    MsgBox(Access.Exception)
                End If
                MsgBox("Service Recorded Successfully!", MsgBoxStyle.Information, "Success!")
                ServiceHistory.LoadElectrical()

            Case "Equipment"
                Access.ExecQuery("INSERT INTO Equipment (EquipID, Company, ItemRepaired, RepairType, RepairDate, Details, RepairCost) " &
                                 "VALUES (@inv, @comp, @irep, @rtype, @rdate, @dets, @cost); ")
                If Not String.IsNullOrEmpty(Access.Exception) Then
                    MsgBox(Access.Exception)
                End If
                MsgBox("Service Recorded Successfully!", MsgBoxStyle.Information, "Success!")
                ServiceHistory.LoadEquip()

            Case Else
                Access.ExecQuery("INSERT INTO Plumbing (PlumbID, Company, ItemRepaired, RepairType, RepairDate, Details, RepairCost) " &
                                 "VALUES (@inv, @comp, @irep, @rtype, @rdate, @dets, @cost); ")
                If Not String.IsNullOrEmpty(Access.Exception) Then
                    MsgBox(Access.Exception)
                End If
                MsgBox("Service Recorded Successfully!", MsgBoxStyle.Information, "Success!")
                ServiceHistory.LoadPlumbing()
        End Select
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        SaveRepairs()
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        InvoiceBox.Text = ""
        CompanyBox.Text = ""
        ItemBox.Text = ""
        TypeBox.SelectedIndex = -1
        DateBox.Value = Date.Now
        DetailsBox.Text = ""
        CostBox.Text = "R"
        SaveBtn.Enabled = False
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class