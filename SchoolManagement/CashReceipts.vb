Imports SchoolManagement.Form1
Public Class CashReceipts
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub LoadCRJ()
        Access.ExecQuery("SELECT [ID], ReceiptNo AS [Receipt No], ReceiptsMonth AS [Month], ReceiptsYear AS [Year], ReceiptDate AS [Date], 
                            [Details], [Sundry], SundryDets AS [Sundry Details], SchoolFees AS [School Fees], [Donations], [Excursions], 
                            [Fundraising], FundraisingDets AS [Fundraising Details], [Nutrition], [Subsidy], [Bank], 
                            BalanceForward AS [Balance Brought Forward], ReceiptsTotal AS [Total]
                            FROM CashReceipts")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        dgvCRJ.DataSource = Access.DBDT
        dgvCRJ.AutoResizeColumns()
        dgvCRJ.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub CashReceipts_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Cash Receipts Journal"
        LoadCRJ()
    End Sub

    ' Form Theme Colours
    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.RosyBrown
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
        Me.dgvCRJ.BackgroundColor = Color.DarkGray
    End Sub

    Private Sub CoralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoralToolStripMenuItem.Click
        Me.dgvCRJ.BackgroundColor = Color.Coral
    End Sub

    Private Sub DodgerBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodgerBlueToolStripMenuItem.Click
        Me.dgvCRJ.BackgroundColor = Color.DodgerBlue
    End Sub

    Private Sub GreyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyToolStripMenuItem.Click
        Me.dgvCRJ.BackgroundColor = Color.Gray
    End Sub

    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click
        Me.dgvCRJ.BackgroundColor = Color.LightBlue
    End Sub

    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click
        Me.dgvCRJ.BackgroundColor = Color.LightGreen
    End Sub

    Private Sub LightPinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightPinkToolStripMenuItem.Click
        Me.dgvCRJ.BackgroundColor = Color.LightPink
    End Sub

    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        Me.dgvCRJ.BackgroundColor = Color.OrangeRed
    End Sub

    Private Sub PeachToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeachToolStripMenuItem1.Click
        Me.dgvCRJ.BackgroundColor = Color.PeachPuff
    End Sub

    Private Sub PinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem1.Click
        Me.dgvCRJ.BackgroundColor = Color.Pink
    End Sub

    Private Sub PurpleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem1.Click
        Me.dgvCRJ.BackgroundColor = Color.Purple
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.dgvCRJ.BackgroundColor = Color.Red
    End Sub

    Private Sub VioletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VioletToolStripMenuItem.Click
        Me.dgvCRJ.BackgroundColor = Color.Violet
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.dgvCRJ.BackgroundColor = Color.White
    End Sub

    Private Sub ReceiptBox_TextChanged(sender As Object, e As EventArgs) Handles ReceiptBox.TextChanged, DetailsBox.TextChanged, BalanceBox.TextChanged,
            SundryBox.TextChanged, SundryDetsBox.TextChanged, FeesBox.TextChanged, DonationsBox.TextChanged, ExcursionBox.TextChanged,
            FundraisingBox.TextChanged, FundBox.TextChanged, NutritionBox.TextChanged, SubsidyBox.TextChanged, BankBox.TextChanged
        If Not String.IsNullOrWhiteSpace(ReceiptBox.Text) And
                Not String.IsNullOrWhiteSpace(DetailsBox.Text) And
                Not String.IsNullOrWhiteSpace(BalanceBox.Text) And
                Not String.IsNullOrWhiteSpace(SundryBox.Text) And
                Not String.IsNullOrWhiteSpace(SundryDetsBox.Text) And
                Not String.IsNullOrWhiteSpace(FeesBox.Text) And
                Not String.IsNullOrWhiteSpace(DonationsBox.Text) And
                Not String.IsNullOrWhiteSpace(ExcursionBox.Text) And
                Not String.IsNullOrWhiteSpace(FundraisingBox.Text) And
                Not String.IsNullOrWhiteSpace(FundBox.Text) And
                Not String.IsNullOrWhiteSpace(NutritionBox.Text) And
                Not String.IsNullOrWhiteSpace(SubsidyBox.Text) And
                Not String.IsNullOrWhiteSpace(BankBox.Text) Then
            SaveStripBtn.Enabled = True
        End If
    End Sub

    Private Sub BankBox_TextChanged(sender As Object, e As EventArgs) Handles BankBox.TextChanged
        Dim ReceiptTotal As Decimal = 0
        Dim bal As String = BalanceBox.Text
        Dim sun As String = SundryBox.Text
        Dim fee As String = FeesBox.Text
        Dim don As String = DonationsBox.Text
        Dim exc As String = ExcursionBox.Text
        Dim fun As String = FundraisingBox.Text
        Dim nutri As String = NutritionBox.Text
        Dim subs As String = SubsidyBox.Text
        Dim bnk As String = BankBox.Text
        If Not String.IsNullOrEmpty(BankBox.Text) Then
            Try
                ReceiptTotal = (Convert.ToDecimal(bal) + Convert.ToDecimal(sun) + Convert.ToDecimal(fee) + Convert.ToDecimal(don) + Convert.ToDecimal(exc) + Convert.ToDecimal(fun) + Convert.ToDecimal(nutri) + Convert.ToDecimal(subs) + Convert.ToDecimal(bnk))
                TotalLabel.Text = Decimal.Round(ReceiptTotal, 2)
            Catch ex As Exception
                MsgBox("Error Calculating Total", MsgBoxStyle.Critical, "Error!")
            End Try
        End If
    End Sub

    Private Sub ClearAllBtn_Click(sender As Object, e As EventArgs) Handles ClearAllBtn.Click
        ReceiptBox.Text = ""
        MonthBox.SelectedIndex = -1
        YearBox.SelectedIndex = -1
        DateBox.Value = Date.Now
        DetailsBox.Text = ""
        BalanceBox.Text = 0
        SundryBox.Text = 0
        SundryDetsBox.Text = ""
        FeesBox.Text = 0
        DonationsBox.Text = 0
        ExcursionBox.Text = 0
        FundraisingBox.Text = 0
        FundBox.Text = ""
        NutritionBox.Text = 0
        SubsidyBox.Text = 0
        BankBox.Text = 0
        TotalLabel.Text = 0
        SaveStripBtn.Enabled = False
    End Sub

    Private Sub SaveCRJ()
        Access.AddParam("rec", ReceiptBox.Text)
        Access.AddParam("mnth", MonthBox.GetItemText(MonthBox.SelectedItem))
        Access.AddParam("yr", YearBox.GetItemText(YearBox.SelectedItem))
        Access.AddParam("cdate", DateBox.Value.ToShortDateString)
        Access.AddParam("dets", DetailsBox.Text)
        Access.AddParam("sundets", SundryDetsBox.Text)
        Access.AddParam("sund", Convert.ToDecimal(SundryBox.Text))
        Access.AddParam("fees", Convert.ToDecimal(FeesBox.Text))
        Access.AddParam("dona", Convert.ToDecimal(DonationsBox.Text))
        Access.AddParam("excur", Convert.ToDecimal(ExcursionBox.Text))
        Access.AddParam("fund", FundBox.Text)
        Access.AddParam("fundr", Convert.ToDecimal(FundraisingBox.Text))
        Access.AddParam("nut", Convert.ToDecimal(NutritionBox.Text))
        Access.AddParam("subb", Convert.ToDecimal(SubsidyBox.Text))
        Access.AddParam("bnk", Convert.ToDecimal(BankBox.Text))
        Access.AddParam("baln", Convert.ToDecimal(BalanceBox.Text))
        Access.AddParam("tot", Convert.ToDecimal(TotalLabel.Text))

        Access.ExecQuery("INSERT INTO CashReceipts (ReceiptNo, ReceiptsMonth, ReceiptsYear, ReceiptDate, [Details], SundryDets, Sundry, SchoolFees, Donations, Excursions, FundraisingDets, Fundraising, Nutrition, Subsidy, Bank, BalanceForward, ReceiptsTotal) " &
                         "VALUES (@rec, @mnth, @yr, @cdate, @dets, @sundets, @sund, @fees, @dona, @excur, @fund, @fundr, @nut, @subb, @bnk, @bal, @tot); ")
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception)
        End If
        MsgBox("Receipt Added To CRJ Successfully!", MsgBoxStyle.Information, "Success!")
        LoadCRJ()
    End Sub

    Private Sub SaveStripBtn_Click(sender As Object, e As EventArgs) Handles SaveStripBtn.Click
        SaveCRJ()
    End Sub

    Private Sub ExitStripBtn_Click(sender As Object, e As EventArgs) Handles ExitStripBtn.Click
        Me.Close()
    End Sub
End Class