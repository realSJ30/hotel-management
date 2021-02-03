Module ErrorTrap

    'letters lang iaccept na function
    Public Function StringFormat(ByVal e As KeyPressEventArgs)
        Dim go As Boolean
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                go = True
            Else
                go = False
            End If
        End If
        Return go
    End Function
    'numbers lg iaccept
    Public Function NumberFormat(ByVal e As KeyPressEventArgs)
        Dim go As Boolean
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890-"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                go = True
            Else
                go = False
            End If
        End If
        Return go
    End Function
    'email error trap
    Public Sub EmailVerification(ByVal text As Object)
        Dim allowedemails() As String = {"@gmail.com", "@yahoo.com", "@ymail.com", "@google.com", "@rocketmail.com"}
        Dim contains = 0
        For i As Integer = 0 To allowedemails.Length - 1
            If (text.Text.Contains(allowedemails(i))) Then
                contains += 1
            End If
        Next
        If Not contains > 0 Then
            MessageBox.Show("Invalid Email Address")
            text.Text = ""
        End If
    End Sub
    'All textbox must be filled
    Public Function Required(ByVal inputarray() As String)
        Dim empty = 0

        For i As Integer = 0 To inputarray.Length - 1
            If (inputarray(i) = "") Then
                empty += 1
            End If
        Next
        If (empty > 0) Then
            Return False
        Else
            Return True
        End If
    End Function
    'Password Confirmation
    Public Sub PasswordVerification(ByVal password As TextBox, ByVal confirm As TextBox)
        If Not (password.Text = confirm.Text) Then
            MessageBox.Show("Password Do not Match!!!")
            password.Text = ""
            confirm.Text = ""
        End If


    End Sub
    'Resets the textBoxes
    Public Sub ResetTextBox(ByVal tb() As Object)
        For i As Integer = 0 To tb.Length - 1
            tb(i).ResetText()
        Next

    End Sub
    'sets the object editable to false or true
    Public Sub EditableObject(ByVal price As TextBox, ByVal cf As TextBox, ByVal desc As RichTextBox, ByVal edit As Boolean)
        price.Enabled = edit
        cf.Enabled = edit
        desc.Enabled = edit
    End Sub
    'sets the DG cell width

    Public Function GetDate(ByVal dt As String)
        Return Strings.Left(dt, 10)
    End Function
    Public Sub ButtonHandler(ByVal btn As Bunifu.Framework.UI.BunifuFlatButton, ByVal lblin As Label, ByVal lblout As Label)
        If (btn.Normalcolor.ToString = "Color [Maroon]") Then
            ErrorMessage("Room is not available!")
        ElseIf (btn.Normalcolor.ToString = "Color [Blue]") Then
            ErrorMessage("Room is on Repair!")
        Else
            ErrorMessage("Available!")
            Dim bookingid As String = "B00" & recordCount("select *from tbl_booking") - 1
            Dim days As Integer = CInt(Strings.Left(lblout.Text, 2)) - CInt(Strings.Left(lblin.Text, 2))
            Dim insertBR = "insert into tbl_bookrooms values ('" & bookingid & "',(select room_id from tbl_rooms where door_number = '" & btn.Text & "'),'" & lblin.Text & "','" & lblout.Text & "'," & days & ",3)"
            SQLProcess(insertBR)



        End If
    End Sub

End Module
