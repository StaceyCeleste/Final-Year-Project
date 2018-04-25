Imports SchoolManagement.Form1
Public Class BackupDB

    Private Sub BackupRestore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackupBtn.Enabled = False
    End Sub

    Private Sub BackupRestore_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Text = Form1.User & " - Backup Database"
    End Sub

    Private Sub BrowseBtn_Click(sender As Object, e As EventArgs) Handles BrowseBtn.Click
        Try
            'set the Title of a Openfolder Dialog Box 
            OFD.Title = "Please Select an MS Access Database File"
            'Set a specific Filter  and Index
            OFD.Filter = "MS Access Database Files (*.accdb)|*.accdb"
            OFD.FilterIndex = 1
            ' when the Browse Image button is click it will open the OpenfileDialog
            'this line of will check if the dialogresult selected is cancel then 
            If OFD.ShowDialog <> DialogResult.Cancel Then
                'Set the location
                txtLocation.Text = OFD.FileName
            End If
        Catch ex As Exception
            'catch some error that may occur
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtLocation_TextChanged(sender As Object, e As EventArgs) Handles txtLocation.TextChanged
        ' it Disable the two button when the location is empty else do the opposite
        If txtLocation.Text = "" Then
            BackupBtn.Enabled = False
        Else
            BackupBtn.Enabled = True
        End If
    End Sub

    Private Sub BackupBtn_Click(sender As Object, e As EventArgs) Handles BackupBtn.Click
        Try
            'call the SavefileDialog box
            SFD.ShowDialog()
            'Set the title
            SFD.Title = "Save File"
            'Set a specific filter
            SFD.Filter = "(*.mdb)|*.accdb"
            If SFD.ShowDialog = DialogResult.OK Then
                'set the destination of a file
                txtDestination.Text = SFD.FileName
                Dim portfolioPath As String = My.Application.Info.DirectoryPath
                'create a backup by using Filecopy Command to copy the file from  location to destination
                FileCopy(txtLocation.Text, txtDestination.Text)
                MsgBox("Database Backup Created Successfully!")
                'Reload the form
                Call BackupRestore_Load(sender, e)
                txtLocation.Text = Nothing
                txtDestination.Text = "Destination..."
            End If

        Catch ex As Exception
            'catch some error that may occur
            MsgBox(ex.Message)

        End Try
    End Sub

End Class