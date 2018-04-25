Public Class Form2
    Private Access As New DBControl
    Private Sub CreateBtn_Click(sender As Object, e As EventArgs) Handles CreateBtn.Click
        If AdminPass.Text = "Karen@27041961" Then
            MsgBox("User Account Successfully Added!", MsgBoxStyle.Information, "Success")
            AddNewUser()
        Else
            MsgBox("Sorry, You Do Not Have Authorised Access To Add User Accounts!", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub AddNewUser()

        Access.AddParam("@user", TextBox1.Text)
        Access.AddParam("@passw", TextBox2.Text)
        Access.AddParam("@typ", TypeBox.GetItemText(TypeBox.SelectedItem))

        Access.ExecQuery("INSERT INTO UserAcc (Username, Pwd, AccType) " &
                         "VALUES (@user, @passw, @typ); ")

        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception) : Exit Sub
        End If
        ' Success Message 
        MsgBox("New User Successfully Added!")

    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TypeBox.SelectedIndex = -1
        AdminPass.Text = ""
    End Sub
End Class