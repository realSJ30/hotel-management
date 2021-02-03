Public Class frmSignIn
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    'LOAD FORM
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
    End Sub

    'BUTTONS
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        End
    End Sub
    'PANEL DRAG 
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
        mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top

    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
        End If

    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub
    'TEXTBOX PLACEHOLDER
    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter
        If (txtUsername.Text = "Username") Then
            txtUsername.Text = ""
        End If
    End Sub
    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If (txtUsername.Text = "") Then
            txtUsername.Text = "Username"
        End If
    End Sub
    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If (txtPassword.Text = "Password") Then
            txtPassword.Text = ""
        End If
    End Sub
    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If (txtPassword.Text = "") Then
            txtPassword.Text = "Password"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Dim id = retrieveID("select employee_id from tbl_accounts where username = '" & txtUsername.Text & "' and password = '" & txtPassword.Text & "'")
        Dim user = retrieveID("select username from tbl_accounts where username = '" & txtUsername.Text & "'")
        Dim pass = retrieveID("select username from tbl_accounts where password = '" & txtPassword.Text & "'")
        Dim verify() = {user.ToString, pass.ToString}
        If (Required(verify) = False) Then
            ErrorMessage("Login Failure")
        Else
            Dim menu As New frmMainMenu
            menu.lblEmployeeName.Text = retrieveID("select FirstName from employee_info where ID = '" & id & "'")
            menu.lblEmployeeType.Text = retrieveID("select Rank from employee_info where ID = '" & id & "'")
            If (Strings.Left(id, 1).Equals("R")) Then
                menu.btnSideEmployee.Visible = False
            Else
                menu.btnSideEmployee.Visible = True
            End If
            menu.Show()
            Me.Close()
        End If

    End Sub
End Class
