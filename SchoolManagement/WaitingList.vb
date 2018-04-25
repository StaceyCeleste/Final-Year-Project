Imports SchoolManagement.Form1
Public Class WaitingList
    Private Accessor As New DBControl

    ' Fills DataGridView With Database Items when Form Loads
    Private Sub WaitingList_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Student Waiting List"
        WaitList_Refresh()
    End Sub

    ' Updates DataGridView
    Public Sub WaitList_Refresh()

        Accessor.ExecQuery("SELECT ListID AS [ID], TrackingNum AS [Tracking Number], RefNum AS [Reference Number],
                            AdminDate AS [Date], Gender, StuName AS [Name], StuSurname AS Surname, ParentName AS [Parent Name],
                            DateOfBirth AS [Birth Date], StudentAge AS Age, Telephone, Address, PrevSchool AS [Previous School]
                            FROM WaitingList")

        dgvWaitList.DataSource = Accessor.DBDT

        ' Autosize DGV column width
        dgvWaitList.AutoResizeColumns()
        dgvWaitList.AutoSizeColumnsMode =
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
        Me.dgvWaitList.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvWaitList.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvWaitList.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvWaitList.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvWaitList.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvWaitList.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvWaitList.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvWaitList.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvWaitList.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvWaitList.BackgroundColor = Color.Pink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvWaitList.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvWaitList.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvWaitList.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvWaitList.BackgroundColor = Color.White
    End Sub

    'Calculates Student's Age When Date of Birth is Entered
    Private Sub DOB_ValueChanged(sender As Object, e As EventArgs) Handles DOB.ValueChanged
        Dim dv1 As Date
        Dim dv2 As Date
        Dim Age As TimeSpan
        Dim diff As Double

        dv1 = Date.Now.ToShortDateString
        dv2 = Me.DOB.Value.ToShortDateString
        Age = (dv1 - dv2)
        diff = Age.Days
        Me.AgeLabel.Text = (Str(Int(diff / 365)) + " Years")
    End Sub

    ' TextBox Validation - Ensures Data Is Entered Into TextBoxes Before Enabling Save Button
    Private Sub TextBox_Validation(sender As Object, e As EventArgs) Handles TrackNum.TextChanged, RefNum.TextChanged,
             NameBox.TextChanged, SurnameBox.TextChanged, ParentBox.TextChanged, AgeLabel.TextChanged,
             TelBox.TextChanged, AddressBox.TextChanged, PrevSchool.TextChanged

        If Not String.IsNullOrWhiteSpace(TrackNum.Text) And
                Not String.IsNullOrWhiteSpace(RefNum.Text) And
                Not String.IsNullOrWhiteSpace(NameBox.Text) And
                Not String.IsNullOrWhiteSpace(SurnameBox.Text) And
                Not String.IsNullOrWhiteSpace(ParentBox.Text) And
                Not String.IsNullOrWhiteSpace(AgeLabel.Text) And
                Not String.IsNullOrWhiteSpace(TelBox.Text) And
                Not String.IsNullOrWhiteSpace(AddressBox.Text) And
                Not String.IsNullOrWhiteSpace(PrevSchool.Text) Then
            SaveButton.Enabled = True
        End If

    End Sub

    ' Private Sub Creates Save Button Method to be used with Save Button
    Private Sub AddWaitList()

        ' Adds Parameters
        Accessor.AddParam("@track", TrackNum.Text)
        Accessor.AddParam("@refnum", RefNum.Text)
        Accessor.AddParam("@adate", AdminDate.Value.ToShortDateString)

        If Male.Checked = True Then
            Male.Text = "Male"
            Accessor.AddParam("@gen", Male.Text)
        Else
            If Female.Checked = True Then
                Female.Text = "Female"
                Accessor.AddParam("@gen", Female.Text)
            End If
        End If

        Accessor.AddParam("@fname", NameBox.Text)
        Accessor.AddParam("@surname", SurnameBox.Text)

        Accessor.AddParam("@parent", ParentBox.Text)
        Accessor.AddParam("@dob", DOB.Value.ToShortDateString)
        Accessor.AddParam("@age", AgeLabel.Text)
        Accessor.AddParam("@tel", TelBox.Text)
        Accessor.AddParam("@address", AddressBox.Text)

        Accessor.AddParam("@prevsch", PrevSchool.Text)

        Accessor.ExecQuery("INSERT INTO WaitingList (TrackingNum, RefNum, AdminDate, Gender, StuName, StuSurname,
                            ParentName, DateOfBirth, StudentAge, Telephone, Address, PrevSchool) " &
            "VALUES (@track, @refnum, @adate, @gen, @fname, @surname, @parent, @dob, @age, @tel, @address, @prevsch); ")

        ' Reports and aborts any errors
        If Not String.IsNullOrEmpty(Accessor.Exception) Then
            MsgBox(Accessor.Exception) : Exit Sub
        End If
        ' Success Message 
        MsgBox("Student Added To Waiting List Successfully!", MsgBoxStyle.Information, "Success!")

        Me.WaitList_Refresh()

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        AddWaitList()
    End Sub

    ' Clear Button Clears All Data Entered
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

        TrackNum.Text = ""
        RefNum.Text = ""
        AdminDate.Value = Date.Now
        Male.Checked = False
        Female.Checked = False
        NameBox.Text = ""
        SurnameBox.Text = ""
        ParentBox.Text = ""
        DOB.Value = Date.Now
        AgeLabel.Text = 0
        TelBox.Text = ""
        AddressBox.Text = ""
        PrevSchool.Text = ""

        SaveButton.Enabled = False

    End Sub

    ' Exit Button Exits Form
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        DeleteWaitList.Show()
    End Sub
End Class