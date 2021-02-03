Public Class frmSearchAccount
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Me.Close()
    End Sub
    Private Sub btnUpdateAccount_Click(sender As Object, e As EventArgs) Handles btnUpdateAccount.Click
        PasswordVerification(txtUpdatePassword, txtSearchConfirmPassword)
        Dim input() = {txtUpdateUsername.Text, txtUpdatePassword.Text, txtSearchConfirmPassword.Text}
        If (Required(input) = False) Then
            ErrorMessage("Please Fill up the Empty Information")
        Else
            Dim updateAccountSQL = "update tbl_accounts set username = '" & txtUpdateUsername.Text & "', password = '" & txtUpdatePassword.Text & "' where employee_id = '" & lblAccountID.Text & "'"
            SQLProcess(updateAccountSQL)
            Me.Close()
        End If
    End Sub

End Class