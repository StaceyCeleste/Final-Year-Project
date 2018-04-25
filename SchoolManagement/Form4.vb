Imports SchoolManagement.Form1
Public Class Form4
    Private Access As New DBControl

    Private Sub Form4_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Add New Student"
    End Sub

    ' Toolstrip Menu Code - Theme Colours -----------------------------------------------------------------------------------
    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        Me.BackColor = Color.LightGreen
    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        Me.BackColor = Color.DodgerBlue
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.BackColor = Color.Coral
    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        Me.BackColor = Color.LightGreen
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.BackColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.BackColor = Color.SkyBlue
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.BackColor = Color.LightPink
    End Sub

    Private Sub PeachToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem.Click
        Me.BackColor = Color.PeachPuff
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.BackColor = Color.Violet
    End Sub

    Private Sub YellowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YellowToolStripMenuItem.Click
        Me.BackColor = Color.Yellow
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.BackColor = Color.White
    End Sub

    ' Toolstrip Menu Exit Button -------------------------------------------------------------------------------------------
    Private Sub ExitFormBtn_Click(sender As Object, e As EventArgs) Handles ExitFormBtn.Click
        Me.Close()
    End Sub

    Private Sub BirthDate_ValueChanged(sender As Object, e As EventArgs) Handles BirthDate.ValueChanged
        Dim dv1 As Date
        Dim dv2 As Date
        Dim Age As TimeSpan
        Dim diff As Double

        dv1 = Me.RegDate.Value.ToShortDateString
        dv2 = Me.BirthDate.Value.ToShortDateString
        Age = (dv1 - dv2)
        diff = Age.Days
        Me.AgeCalc.Text = (Str(Int(diff / 365)) + " Years")
    End Sub

    ' Selected ComboBox Item Calculation - Auto Calculates Student Weighting and Displays in WeightCal Label
    Private Sub PrimDisCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PrimDisCombo.SelectedIndexChanged
        Dim Num As Integer
        Num = 1

        Select Case PrimDisCombo.Text
            Case "Autism"
                WeightCalc.Text = 1 * 6
            Case "Visual Impairment"
                WeightCalc.Text = 1 * 5
            Case "Conduct Disorder"
                WeightCalc.Text = 1 * 5
            Case "Physical Impairment"
                WeightCalc.Text = 1 * 4
            Case "Intellectual Impairment"
                WeightCalc.Text = 1 * 3
            Case "Attention Deficit Disorder"
                WeightCalc.Text = 1 * 2
            Case "Cerebral Palsy"
                WeightCalc.Text = 1 * 4
            Case "Epilepsy"
                WeightCalc.Text = 1 * 3
            Case "Hard of Hearing"
                WeightCalc.Text = 1 * 5

            Case Else
                WeightCalc.Text = 1 * 3
        End Select
    End Sub

    ' Data Validation - Ensures Values typed in Textboxes before user Saves Data
    Private Sub TextBox_Validation(sender As Object, e As EventArgs) Handles TrackNum.TextChanged, IDNum.TextChanged, StuInit.TextChanged, StuName.TextChanged,
            StuSecName.TextChanged, StuSurname.TextChanged, CitizenBox.TextChanged, StuAddress.TextChanged, StuSuburb.TextChanged, StuCity.TextChanged,
            StuPCode.TextChanged, StuCountry.TextChanged, StuHomeTel.TextChanged, StuCellTel.TextChanged, StuEmergNum.TextChanged, StuEmergCont.TextChanged,
            StuEmail.TextChanged
        If Not String.IsNullOrWhiteSpace(TrackNum.Text) And
                Not String.IsNullOrWhiteSpace(IDNum.Text) And
                Not String.IsNullOrWhiteSpace(StuInit.Text) And
                Not String.IsNullOrWhiteSpace(StuName.Text) And
                Not String.IsNullOrWhiteSpace(StuSecName.Text) And
                Not String.IsNullOrWhiteSpace(StuSurname.Text) And
                Not String.IsNullOrWhiteSpace(CitizenBox.Text) And
                Not String.IsNullOrWhiteSpace(StuAddress.Text) And
                Not String.IsNullOrWhiteSpace(StuSuburb.Text) And
                Not String.IsNullOrWhiteSpace(StuCity.Text) And
                Not String.IsNullOrWhiteSpace(StuPCode.Text) And
                Not String.IsNullOrWhiteSpace(StuCountry.Text) And
                Not String.IsNullOrWhiteSpace(StuHomeTel.Text) And
                Not String.IsNullOrWhiteSpace(StuCellTel.Text) And
                Not String.IsNullOrWhiteSpace(StuEmergNum.Text) And
                Not String.IsNullOrWhiteSpace(StuEmergCont.Text) And
                Not String.IsNullOrWhiteSpace(StuEmail.Text) Then
            SaveDataToolStripBtn.Enabled = True
        End If
    End Sub

    ' Code to Add Data entered on Form to Database
    Private Sub AddStudent()

        ' Adds parameters 

        ' Student Details Table
        Access.AddParam("@track", TrackNum.Text)
        Access.AddParam("@idnumb", IDNum.Text)
        Access.AddParam("@stunumb", StuNum.Text)
        Access.AddParam("@rdate", RegDate.Value.ToShortDateString)
        If MaleBtn.Checked = True Then
            MaleBtn.Text = "Male"
            Access.AddParam("@gen", MaleBtn.Text)
        Else
            If FemaleBtn.Checked = True Then
                FemaleBtn.Text = "Female"
                Access.AddParam("@gen", FemaleBtn.Text)
            End If
        End If
        Access.AddParam("@init", StuInit.Text)
        Access.AddParam("@name", StuName.Text)
        Access.AddParam("@secname", StuSecName.Text)
        Access.AddParam("@surname", StuSurname.Text)
        Access.AddParam("@ethnic", EthnicityBox.GetItemText(EthnicityBox.SelectedItem))
        Access.AddParam("@bdate", BirthDate.Value.ToShortDateString)
        Access.AddParam("@age", AgeCalc.Text)

        ' Executes Insert Command
        Access.ExecQuery("INSERT INTO StuDetails (TrackingNum, IDNum, StudentNum, RegDate, Gender, StuInitials, StuName, StuSecName, StuSurname, StuEthnicity, StuBirthDate, StuAge) " &
                         "VALUES (@track, @idnumb, @stunumb, @rdate, @gen, @init, @name, @secname, @surname,  @ethnic, @bdate, @age); ")

        ' StuAdditional Table
        Access.AddParam("@stunumb", StuNum.Text)
        Access.AddParam("@name", StuName.Text)
        Access.AddParam("@surname", StuSurname.Text)
        Access.AddParam("@citiz", CitizenBox.Text)
        Access.AddParam("@primlang", PrimLangCombo.GetItemText(PrimLangCombo.SelectedItem))
        Access.AddParam("@seclang", SecLangCombo.GetItemText(SecLangCombo.SelectedItem))
        Access.AddParam("@primdis", PrimDisCombo.GetItemText(PrimDisCombo.SelectedItem))
        Access.AddParam("@secdis", SecDisCombo.GetItemText(SecDisCombo.SelectedItem))
        Access.AddParam("@weight", WeightCalc.Text)

        Access.ExecQuery("INSERT INTO StuAdditional (StudentNum, StuName, StuSurname, StuCitizenship, StuPrimLang, StuSecLang, PrimDisability, SecDisability, Weighting) " &
            "VALUES (@stunumb, @name, @surname, @citiz, @primlang, @seclang, @primdis, @secdis, @weight); ")

        ' Student Address Table
        Access.AddParam("@track", TrackNum.Text)
        Access.AddParam("@name", StuName.Text)
        Access.AddParam("@surname", StuSurname.Text)
        Access.AddParam("@add", StuAddress.Text)
        Access.AddParam("@subb", StuSuburb.Text)
        Access.AddParam("@city", StuCity.Text)
        Access.AddParam("@prov", ProvCombo.GetItemText(ProvCombo.SelectedItem))
        Access.AddParam("@pcode", StuPCode.Text)
        Access.AddParam("@country", StuCountry.Text)

        Access.ExecQuery("INSERT INTO StuAddress (TrackingNum, StuName, StuSurname, StuAddress, StuSuburb, StuCity, StuProvince, StuPCode, StuCountry) " &
                          "VALUES (@track, @name, @surname, @add, @subb, @city, @prov, @pcode, @country); ")

        ' Student Contact Table
        Access.AddParam("@stunumb", StuNum.Text)
        Access.AddParam("@name", StuName.Text)
        Access.AddParam("@surname", StuSurname.Text)
        Access.AddParam("@home", StuHomeTel.Text)
        Access.AddParam("@cel", StuCellTel.Text)
        Access.AddParam("@telemerg", StuEmergNum.Text)
        Access.AddParam("@emergcont", StuEmergCont.Text)
        Access.AddParam("@email", StuEmail.Text)

        Access.ExecQuery("INSERT INTO StuContact (StudentNum, StuName, StuSurname, StuHomeTel, StuCellTel, StuEmergCont, StuEmContName, StuEmail) " &
                          "VALUES (@stunumb, @name, @surname, @home, @cel, @email, @telemerg, @emergcont); ")

        ' Student Illnesses
        Access.AddParam("@track", TrackNum.Text)
        Access.AddParam("@name", StuName.Text)
        Access.AddParam("@surname", StuSurname.Text)
        Access.AddParam("@illname", ChronIll.Text)
        Access.AddParam("@meds", Medication.Text)
        Access.AddParam("@dosage", Dosage.Text)

        Access.ExecQuery("INSERT INTO StuIllnesses (TrackingNum, StuName, StuSurname, IllnessName, Medication, Dosage) " &
            "VALUES (@track, @name, @surname, @illname, @meds, @dosage); ")

        ' Reports and aborts any errors
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception) : Exit Sub
        End If
        ' Success Message 
        MsgBox("Student Successfully Added!", MsgBoxStyle.Information, "Success!")

        CurrentStudent.RefreshGrid()

    End Sub

    ' Toolstrip Menu Save Button
    Private Sub SaveDataToolStripBtn_Click(sender As Object, e As EventArgs) Handles SaveDataToolStripBtn.Click
        AddStudent()
    End Sub

    ' Clear Button Clears All Textboxes and ComboBoxes and Disabled Save Button
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        TrackNum.Text = ""
        IDNum.Text = ""
        StuNum.Text = ""
        StuInit.Text = ""
        StuName.Text = ""
        StuSecName.Text = ""
        StuSurname.Text = ""
        EthnicityBox.SelectedIndex = -1
        BirthDate.Value = Date.Now
        AgeCalc.Text = ""
        PrimLangCombo.SelectedIndex = -1
        SecLangCombo.SelectedIndex = -1
        PrimDisCombo.SelectedIndex = -1
        SecDisCombo.SelectedIndex = -1
        CitizenBox.Text = ""
        StuAddress.Text = ""
        StuSuburb.Text = ""
        StuCity.Text = ""
        ProvCombo.SelectedIndex = -1
        StuPCode.Text = ""
        StuCountry.Text = ""
        StuHomeTel.Text = ""
        StuCellTel.Text = ""
        StuEmergNum.Text = ""
        StuEmergCont.Text = ""
        StuEmail.Text = ""
        ChronIll.Text = ""
        Medication.Text = ""
        Dosage.Text = ""
        SaveDataToolStripBtn.Enabled = False
    End Sub

End Class