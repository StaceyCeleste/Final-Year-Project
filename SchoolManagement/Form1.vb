Imports SchoolManagement.Form3
Public Class Form1
    Private Access As New DBControl
    Public Shared User As String
    Public Shared Authorisee As String
    Public Shared UserLevel As String

    Private CurrentRecord As Integer = 0

    ' Error Checking and Reporting
    Private Function NoErrors(Optional Report As Boolean = False) As Boolean
        If Not String.IsNullOrEmpty(Access.Exception) Then
            If Report = True Then MsgBox(Access.Exception)
            Return False
        Else
            Return True
        End If
    End Function

    ' Display Data Method
    Public Sub Display_Data()
        Dim dt As New DataTable("UserAcc")
        Dim rs As New OleDb.OleDbDataAdapter("Select * From UserAcc", DBCon)
        rs.Fill(dt)
        UserAccDataGrid.DataSource = dt
        UserAccDataGrid.Refresh()

        Label3.Text = dt.Rows.Count
        rs.Dispose()
        DBCon.Close()
    End Sub

    ' Create New Account Link Label
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display_Data()
        'LoadUser()
    End Sub

    Public Sub Login_Data()

        Dim dt As New DataTable("UserAcc")
            Dim rs As New OleDb.OleDbDataAdapter("Select * From UserAcc Where Username = '" & Uname.Text & "' And Pwd = '" & Upwd.Text & "' ", DBCon)
            rs.Fill(dt)
            UserAccDataGrid.DataSource = dt
            UserAccDataGrid.Refresh()
            Label3.Text = dt.Rows.Count
        rs.Dispose()

        Select Case (Label6.Text)
            Case "HOD"
                If Val(Label3.Text) = 1 Then
                    MsgBox("Successfully Logged In!")
                    Form3.BackupRestoreToolStripMenuItem.Enabled = False
                    Form3.ParentsToolStripMenuItem.Enabled = False
                    Form3.StaffToolStripMenuItem.Enabled = False
                    Form3.GovernanceToolStripMenuItem.Enabled = False
                    Form3.SafetyAndSecurityToolStripMenuItem.Enabled = False
                    Form3.StockToolStripMenuItem.Enabled = False
                    Form3.InfrastructureToolStripMenuItem.Enabled = False
                    Form3.TransportToolStripMenuItem1.Enabled = False
                    Form3.VehiclesToolStripMenuItem.Enabled = False
                    Form3.FinancesToolStripMenuItem.Enabled = False
                    Form3.ServiceProvidersToolStripMenuItem.Enabled = False
                    Form3.Show()
                    User = "Logged in As: " & Uname.Text.ToString
                    UserLevel = Uname.Text.ToString
                    UserLevel.ToString()
                    User.ToString()
                    Authorisee = Uname.Text.ToString
                    Authorisee.ToString()

                    Me.Close()
                Else
                    MsgBox("Unsuccessful Login!")
                End If

            Case "Stock Controller"
                If Val(Label3.Text) = 1 Then
                    MsgBox("Successfully Logged In!")
                    Form3.BackupRestoreToolStripMenuItem.Enabled = False
                    Form3.StudentToolStripMenuItem.Enabled = False
                    Form3.ParentsToolStripMenuItem.Enabled = False
                    Form3.StaffToolStripMenuItem.Enabled = False
                    Form3.GovernanceToolStripMenuItem.Enabled = False
                    Form3.ReportsToolStripMenuItem.Enabled = False
                    Form3.ExcursionsToolStripMenuItem1.Enabled = False
                    Form3.SportsAndExcursionsToolStripMenuItem.Enabled = False
                    Form3.SafetyAndSecurityToolStripMenuItem.Enabled = False
                    Form3.InfrastructureToolStripMenuItem.Enabled = False
                    Form3.TransportToolStripMenuItem1.Enabled = False
                    Form3.VehiclesToolStripMenuItem.Enabled = False
                    Form3.FinancesToolStripMenuItem.Enabled = False
                    Form3.FunctionsAndEventsToolStripMenuItem.Enabled = False
                    Form3.ServiceProvidersToolStripMenuItem.Enabled = False
                    Form3.Show()
                    User = "Logged in As: " & Uname.Text.ToString
                    UserLevel = Uname.Text.ToString
                    UserLevel.ToString()
                    User.ToString()
                    Authorisee = Uname.Text.ToString
                    Authorisee.ToString()

                    Me.Close()
                Else
                    MsgBox("Unsuccessful Login!")
                End If

            Case Else
                If Val(Label3.Text) = 1 Then
                    MsgBox("Successfully Logged In!")
                    Form3.Show()
                    User = "Logged in As: " & Uname.Text.ToString
                    UserLevel = Uname.Text.ToString
                    UserLevel.ToString()
                    User.ToString()
                    Authorisee = Uname.Text.ToString
                    Authorisee.ToString()
                    Me.Close()
                Else
                    MsgBox("Unsuccessful Login!")
                End If
        End Select
    End Sub

    Private Sub LoadUser()
        Access.ExecQuery("SELECT * FROM UserAcc WHERE Username= '" & Uname.Text & "' ")
        If NoErrors(True) = False OrElse Access.RecordCount < 1 Then Exit Sub
        GetRecord()
    End Sub

    Public Sub GetRecord()
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)
        Label4.Text = r("Username").ToString
        Label5.Text = r("Pwd").ToString
        Label6.Text = r("AccType").ToString
    End Sub

    ' Login Button
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Login_Data()
    End Sub

    ' Exit Button
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub Uname_TextChanged(sender As Object, e As EventArgs) Handles Uname.TextChanged
        If Not String.IsNullOrEmpty(Uname.Text) Then
            LoadUser()
        End If
    End Sub
End Class
