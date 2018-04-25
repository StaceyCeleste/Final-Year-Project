Imports SchoolManagement.Form1
Public Class Parents
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub LoadParents()
        Access.ExecQuery("SELECT [ID], ParentInitials AS [Parent Initials], ParentName AS [Name], ParentSurname AS [Surname],
                            Occupation, StudentName AS [Student Name], StudentNum AS [Student Number]
                            FROM ParentDetails")

        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        ' Fills DataGridView
        dgvParents.DataSource = Access.DBDT

        ' Autosize DGV column width
        dgvParents.AutoResizeColumns()
        dgvParents.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub LoadStudents()
        Access.ExecQuery("Select StuName + ' ' + StuSurname AS FullName From StuDetails")

        StudentBox.DataSource = Access.DBDT
        If Access.DBDT.Rows.Count > 0 Then
            StudentBox.DataSource = Access.DBDT
            StudentBox.ValueMember = "FullName"
            StudentBox.DisplayMember = "FullName"
        End If
    End Sub

    Private Sub Parents_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Add New Parent"
        LoadParents()
        LoadStudents()
    End Sub

    ' Form Theme Colours
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.MediumOrchid
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
        Me.dgvParents.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvParents.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvParents.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvParents.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvParents.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvParents.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvParents.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvParents.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvParents.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvParents.BackgroundColor = Color.DeepPink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvParents.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvParents.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvParents.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvParents.BackgroundColor = Color.White
    End Sub

    ' Save New Parent Method
    Private Sub SaveParents()
        ' Parent Details Table
        Access.AddParam("@parid", ParentID.Text)
        Access.AddParam("@init", InitialsBox.Text)
        Access.AddParam("@pname", PNameBox.Text)
        Access.AddParam("@psurname", PSurnameBox.Text)
        Access.AddParam("@occu", OccupationBox.Text)
        Access.AddParam("@sname", StudentBox.Text)
        Access.AddParam("@snum", StudentNumBox.Text)

        Access.ExecQuery("INSERT INTO ParentDetails ([ID], ParentInitials, ParentName, ParentSurname, [Occupation], StudentName, StudentNum) " &
                         "VALUES (@parid, @init, @pname, @psurname, @occu, @sname, @snum); ")

        ' Parent Address Table
        Access.AddParam("@parid", ParentID.Text)
        Access.AddParam("@pname", PNameBox.Text)
        Access.AddParam("@psurname", PSurnameBox.Text)
        Access.AddParam("@add", AddressBox.Text)
        Access.AddParam("@sub", SuburbBox.Text)
        Access.AddParam("@city", CityBox.Text)
        Access.AddParam("@prov", ProvBox.Text)
        Access.AddParam("@pcode", PCodeBox.Text)

        Access.ExecQuery("INSERT INTO ParentAddress (ParentID, ParentName, ParentSurname, PhysicalAdd, Suburb, City, Province, PCode) " &
                         "VALUES (@parid, @pname, @psurname, @add, @sub, @city, @prov, @pcode); ")

        ' Parent Contact Details Table
        Access.AddParam("@parid", ParentID.Text)
        Access.AddParam("@pname", PNameBox.Text)
        Access.AddParam("@psurname", PSurnameBox.Text)
        Access.AddParam("@hnum", HomeNumBox.Text)
        Access.AddParam("@cel", CellphoneBox.Text)
        Access.AddParam("@emerg", EmContBox.Text)
        Access.AddParam("@cont", ContNameBox.Text)
        Access.AddParam("@email", EmailBox.Text)

        Access.ExecQuery("INSERT INTO ParentContact (ParentID, ParentName, ParentSurname, HomeNum, Cellphone, EmergCont, EmContName, Email) " &
                         "VALUES (@parid, @pname, @psurname, @hnum, @cel, @emerg, @cont, @email); ")

        ' Parent Interview Results Table
        Access.AddParam("@pid", ParentID.Text)
        Access.AddParam("@idate", InterviewDate.Value.ToShortDateString)
        Access.AddParam("@pname", PNameBox.Text)
        Access.AddParam("@psurname", PSurnameBox.Text)
        Access.AddParam("@interdets", ResultsBox.Text)

        Access.ExecQuery("INSERT INTO ParentInterviewResults (ParentID, InterviewDate, IntervieweeName, IntervieweeSurname, InterviewDets) " &
                         "VALUES (@pid, @idate, @pname, @psurname, @interdets); ")

        ' Reports and aborts any errors 
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception) : Exit Sub
        End If
        ' Success Message 
        MsgBox("New Parent Details Added Successfully!", MsgBoxStyle.Information, "Success!")
        LoadParents()
        CurrentParent.LoadParents()
        CurrentParent.LoadAddress()
        CurrentParent.LoadContacts()
        CurrentParent.LoadInterviews()
    End Sub

    ' TextBox Validation - Validates that data is entered and enables save button is textboxes are filled in 
    Private Sub TextBox_Validation(sender As Object, e As EventArgs) Handles InitialsBox.TextChanged, PNameBox.TextChanged, PSurnameBox.TextChanged,
            OccupationBox.TextChanged, StudentNumBox.TextChanged, HomeNumBox.TextChanged, CellphoneBox.TextChanged, EmContBox.TextChanged,
            ContNameBox.TextChanged, EmailBox.TextChanged, AddressBox.TextChanged, SuburbBox.TextChanged, CityBox.TextChanged,
        ProvBox.TextChanged, PCodeBox.TextChanged, ResultsBox.TextChanged
        If Not String.IsNullOrWhiteSpace(InitialsBox.Text) And
                Not String.IsNullOrWhiteSpace(PNameBox.Text) And
                Not String.IsNullOrWhiteSpace(PSurnameBox.Text) And
                Not String.IsNullOrWhiteSpace(OccupationBox.Text) And
                Not String.IsNullOrWhiteSpace(StudentNumBox.Text) And
                Not String.IsNullOrWhiteSpace(HomeNumBox.Text) And
                Not String.IsNullOrWhiteSpace(CellphoneBox.Text) And
                Not String.IsNullOrWhiteSpace(EmContBox.Text) And
                Not String.IsNullOrWhiteSpace(ContNameBox.Text) And
                Not String.IsNullOrWhiteSpace(EmailBox.Text) And
                Not String.IsNullOrWhiteSpace(AddressBox.Text) And
                Not String.IsNullOrWhiteSpace(SuburbBox.Text) And
                Not String.IsNullOrWhiteSpace(CityBox.Text) And
                Not String.IsNullOrWhiteSpace(ProvBox.Text) And
                Not String.IsNullOrWhiteSpace(PCodeBox.Text) And
                Not String.IsNullOrWhiteSpace(ResultsBox.Text) Then
            SaveBtn.Enabled = True
        End If
    End Sub

    Private Sub InitialsBox_TextChanged(sender As Object, e As EventArgs) Handles InitialsBox.TextChanged
        Dim NewId As Integer
        Dim Cyear As String = DateTime.Now.ToString("MMdd")
        Dim StuCount As Integer
        StuCount = dgvParents.RowCount

        Try
            If Not String.IsNullOrWhiteSpace(InitialsBox.Text) Then
                NewId = Cyear &
                    StuCount = +1
                StuCount.ToString("00")
            End If

            Dim Cdigit As String = NewId
            Dim Total As Integer = 0
            For Each s As String In Cdigit
                Total += Convert.ToInt32(s)
                Cdigit = (Total Mod 10)
                If Cdigit > 0 Then
                    Cdigit = 10 - Cdigit
                End If
            Next

            NewId = Cyear & StuCount.ToString & Cdigit.ToString
        Catch ex As Exception
            MsgBox("Error Generating Menu ID!", MsgBoxStyle.Critical, "Error!")
        End Try
        ParentID.Text = "PI" & NewId.ToString
    End Sub

    ' Save Button
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        SaveParents()
    End Sub

    ' Clear Button
    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        ParentID.Text = 0
        InitialsBox.Text = ""
        PNameBox.Text = ""
        PSurnameBox.Text = ""
        OccupationBox.Text = ""
        StudentBox.SelectedIndex = -1
        StudentNumBox.Text = ""
        AddressBox.Text = ""
        SuburbBox.Text = ""
        CityBox.Text = ""
        ProvBox.SelectedIndex = -1
        PCodeBox.Text = ""
        HomeNumBox.Text = ""
        CellphoneBox.Text = ""
        EmContBox.Text = ""
        ContNameBox.Text = ""
        EmailBox.Text = ""
        InterviewDate.Value = Date.Now
        ResultsBox.Text = ""
        SaveBtn.Enabled = False
    End Sub

    ' Exit Button
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

End Class