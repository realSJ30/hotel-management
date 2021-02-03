Public Class frmMainMenu


    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'PanelMain.BackColor() = Color.FromArgb(210, Color.White)    'transparency sa menu background
        'Connection Established
        dbConnection()

        'ComboBox
        loadToComboBox("select *from tbl_gender", cboGender)
        loadToComboBox("select *from tbl_employeetype", cboTypeofEmployee)
        loadToComboBox("select *from tbl_employeestatus", cboSearchStatus)
        loadToComboBox("select *from tbl_roomcategory", cboRoomCategory)
        loadToComboBox("select *from tbl_roomstatus", cboRoomStatus)
        'DataGridViews
        displayRecords("select *from employee_Info", DGEmployee)
        displayRecords("select *from room_info", DGRooms)
        displayRecords("select *from booking_info where status = 'Partial'", DGBOOKING)
        Dim btn As New DataGridViewButtonColumn()
        DGBOOKING.Columns.Add(btn)
        btn.HeaderText = "Action"
        btn.Text = "Remove"
        btn.Name = "btnCheckB"
        btn.UseColumnTextForButtonValue = True


    End Sub

    Private Sub btnSubmitEmployee_Click(sender As Object, e As EventArgs) Handles btnSubmitEmployee.Click
        Dim ID = IDGenerator(cboTypeofEmployee)
        Dim input() As String = {txtFirstName.Text,
                                 txtLastName.Text,
                                 txtAddress.Text,
                                 txtEmail.Text,
                                 txtUsername.Text,
                                 txtPassword.Text,
                                 txtConfirmPass.Text}
        If (Required(input) = False) Then
            ErrorMessage("Please Fill up the Empty Information")
        Else
            'insert to employee
            Dim employeeQUERY = "insert into tbl_employee values (@id,@firstname,@lastname,@contact,@address,@email,@gender,@employeetype,@employeestatus)"
            Dim Employeeval() = {"@id", "@firstname", "@lastname", "@contact", "@address", "@email", "@gender", "@employeetype", "@employeestatus"}
            Dim Employeevalue() = {ID,
                           txtFirstName.Text,
                           txtLastName.Text,
                           txtContact.Text,
                           txtAddress.Text,
                           txtEmail.Text,
                           cboGender.SelectedValue.ToString,
                           cboTypeofEmployee.SelectedValue.ToString,
                           "1"}
            SQLProcess(employeeQUERY, Employeeval, Employeevalue)

            'insert to accounts
            Dim accountsQUERY = "insert into tbl_accounts values (@id,@username,@password)"
            Dim accountVal = {"@id", "@username", "@password"}
            Dim accountValue() = {ID, txtUsername.Text, txtPassword.Text}
            SQLProcess(accountsQUERY, accountVal, accountValue)
            Dim tb() As Object = {txtFirstName, txtLastName, txtContact, txtAddress, txtEmail, txtUsername, txtPassword, txtConfirmPass}
            ResetTextBox(tb)
        End If
    End Sub

    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        e.Handled = StringFormat(e)
    End Sub
    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        e.Handled = StringFormat(e)
    End Sub

    Private Sub txtEmail_Validated(sender As Object, e As EventArgs) Handles txtEmail.Validated
        EmailVerification(txtEmail)
    End Sub
    Private Sub txtContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContact.KeyPress
        e.Handled = NumberFormat(e)
    End Sub
    Private Sub txtConfirmPass_Validated(sender As Object, e As EventArgs) Handles txtConfirmPass.Validated
        PasswordVerification(txtPassword, txtConfirmPass)
    End Sub

    Private Sub btnViewEmployee_Click(sender As Object, e As EventArgs) Handles btnViewEmployee.Click
        Dim tb() As Object = {txtFirstName, txtLastName, txtContact, txtAddress, txtEmail, txtUsername, txtPassword, txtConfirmPass}
        ResetTextBox(tb)
        'radiobuttons
        rdioActive.Checked = False
        rdioAll.Checked = False
        rdioDeactivated.Checked = False

        PanelViewEmployee.Visible = True
        'PanelAddEmployee.Visible = True - -libog ang panel viewing dria dapita
        'Load to DataGrid View and Employees
        'DataGridViews
        displayRecords("select *from employee_Info", DGEmployee)


    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        Dim tb() As Object = {txtSearchFname, txtSearchLname, txtSearchAddress, txtSearchContact, txtSearchEmail, lblSearchEmployeeID}
        ResetTextBox(tb)
        PanelAddEmployee.Visible = True
        PanelViewEmployee.Visible = False



    End Sub

    Private Sub txtSearchEmployee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchEmployee.KeyPress
        Dim filteredQUERY = "select * from Employee_Info where ID like '%" & txtSearchEmployee.Text & "%' or Firstname like '%" & txtSearchEmployee.Text & "%' or Lastname like '%" & txtSearchEmployee.Text &
                            "%' or contact like '%" & txtSearchEmployee.Text & "%' or address like '%" & txtSearchEmployee.Text & "%' or email like '%" & txtSearchEmployee.Text & "%' or gender like '%" & txtSearchEmployee.Text & "%' or Rank like '%" & txtSearchEmployee.Text & "%' or Status like '%" & txtSearchEmployee.Text & "%'"
        displayRecords(filteredQUERY, DGEmployee)
    End Sub
    Private Sub txtSearchEmployee_Enter(sender As Object, e As EventArgs) Handles txtSearchEmployee.Enter
        txtSearchEmployee.Text = ""
    End Sub

    Private Sub txtSearchEmployee_Leave(sender As Object, e As EventArgs) Handles txtSearchEmployee.Leave
        txtSearchEmployee.Text = "Search"
    End Sub

    Private Sub DGEmployee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGEmployee.CellClick
        Try
            Dim i = e.RowIndex
            With DGEmployee
                lblSearchEmployeeID.Text = .Item(0, i).Value
                txtSearchFname.Text = .Item(1, i).Value
                txtSearchLname.Text = .Item(2, i).Value
                txtSearchContact.Text = .Item(3, i).Value
                txtSearchAddress.Text = .Item(4, i).Value
                txtSearchEmail.Text = .Item(5, i).Value
                cboSearchStatus.Text = .Item(8, i).Value
            End With

        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtSearchFname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchFname.KeyPress
        e.Handled = StringFormat(e)
    End Sub
    Private Sub txtSearchLname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchLname.KeyPress
        e.Handled = StringFormat(e)
    End Sub
    Private Sub txtSearchContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchContact.KeyPress
        e.Handled = NumberFormat(e)
    End Sub
    Private Sub txtSearchEmail_Validated(sender As Object, e As EventArgs) Handles txtSearchEmail.Validated
        EmailVerification(txtSearchEmail)
    End Sub

    Private Sub btnUpdateEmployee_Click(sender As Object, e As EventArgs) Handles btnUpdateEmployee.Click
        'Updates employee
        Dim val() = {"@fname", "@lname", "@address", "@contact", "@email", "status", "@id"}
        Dim input() As String = {txtSearchFname.Text,
                                 txtSearchLname.Text,
                                 txtSearchAddress.Text,
                                 txtSearchContact.Text,
                                 txtSearchEmail.Text,
                                 cboSearchStatus.SelectedValue.ToString,
                                 lblSearchEmployeeID.Text}
        If (Required(input) = False) Then
            ErrorMessage("Please Fill up the Empty Information")

        Else
            Dim updateQUERY = "update tbl_employee set Firstname = '" & txtSearchFname.Text & "',Lastname = '" & txtSearchLname.Text & "',address = '" & txtSearchAddress.Text & "',contact = '" & txtSearchContact.Text & "',email = '" & txtSearchEmail.Text & "',employeestatus_id = " & cboSearchStatus.SelectedValue.ToString & " where employee_id = '" & lblSearchEmployeeID.Text & "'"
            'SQLProcess(updateQUERY, val, input)
            SQLProcess(updateQUERY)
            Dim tb() As Object = {txtSearchFname, txtSearchLname, txtSearchAddress, txtSearchContact, txtSearchEmail, lblSearchEmployeeID}
            ResetTextBox(tb)
            displayRecords("select *from employee_Info", DGEmployee)
        End If



    End Sub

    Private Sub btnShowAccountEmployee_Click(sender As Object, e As EventArgs) Handles btnShowAccountEmployee.Click
        If Not (txtSearchFname.Text = "") Then
            Dim accountForm As New frmSearchAccount
            displayRecords2("select username from tbl_accounts where employee_id = '" & lblSearchEmployeeID.Text & "'", accountForm.txtUpdateUsername)
            accountForm.lblAccountID.Text = lblSearchEmployeeID.Text
            accountForm.ShowDialog()
        Else
            ErrorMessage("Please Choose an Employee!")
        End If

    End Sub

    Private Sub rdioActive_CheckedChanged(sender As Object, e As EventArgs) Handles rdioActive.CheckedChanged
        displayRecords("select *from employee_info where status = 'Actived'", DGEmployee)
    End Sub

    Private Sub rdioDeactivated_CheckedChanged(sender As Object, e As EventArgs) Handles rdioDeactivated.CheckedChanged
        displayRecords("select *from employee_info where status = 'Deactivated'", DGEmployee)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdioAll.CheckedChanged
        displayRecords("select *from employee_info", DGEmployee)
    End Sub

    Private Sub btnSideEmployee_Click(sender As Object, e As EventArgs) Handles btnSideEmployee.Click
        lblOccupiedCount.Visible = False
        PanelEmployee.Visible = True
        PanelBooking.Visible = False
    End Sub

    Private Sub btnSideRooms_Click(sender As Object, e As EventArgs) Handles btnSideRooms.Click
        PanelEmployee.Visible = True
        lblOccupiedCount.Visible = True
        PanelRoomInfo.Visible = False
        PanelBooking.Visible = False
    End Sub



    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Dim br As New BookRoom
        br.Show()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Dim rc As New frmRoomCategory
        rc.ShowDialog()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        PanelRoomInfo.Visible = True
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        PanelRoomInfo.Visible = False
    End Sub

    Private Sub txtRoomCapacity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRoomCapacity.KeyPress
        e.Handled = NumberFormat(e)
    End Sub

    Private Sub DGRooms_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGRooms.CellClick
        Try
            Dim i = e.RowIndex
            With DGRooms
                lblRoomName.Text = .Item(0, i).Value
                txtRoomCapacity.Text = .Item(1, i).Value
                cboRoomCategory.Text = .Item(2, i).Value
                cboRoomStatus.Text = .Item(3, i).Value
            End With

        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtSearchRoom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchRoom.KeyPress
        displayRecords("select *from room_info where door like '%" & txtSearchRoom.Text & "%' or Capacity like '%" & txtSearchRoom.Text & "%' or category like '%" & txtSearchRoom.Text & "%'", DGRooms)

    End Sub

    Private Sub BunifuFlatButton49_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton49.Click
        Dim input() = {txtRoomCapacity.Text}

        If (Required(input) = False) Then
            ErrorMessage("Nothing to Update")
        Else
            Dim updateSQL = "update tbl_rooms set Max_capacity = " & txtRoomCapacity.Text & ", roomCategory_ID = " & cboRoomCategory.SelectedValue.ToString & ",roomStatus_ID = " & cboRoomStatus.SelectedValue.ToString & " where door_number = '" & lblRoomName.Text & "'"
            SQLProcess(updateSQL)
            lblRoomName.Text = "N/A"
            txtRoomCapacity.Text = ""
            displayRecords("select *from room_info", DGRooms)
        End If


    End Sub

    Private Sub btnSideBookings_Click(sender As Object, e As EventArgs) Handles btnSideBookings.Click
        PanelBooking.Visible = True
        PanelRoomInfo.Visible = False
        PanelEmployee.Visible = True
    End Sub
    Private Sub txtSearchBook_KeyPress(sender As Object, e As EventArgs) Handles txtSearchBook.KeyPress
        If (chckALL.Checked = True) Then
            displayRecords("select *from booking_info where ID like '%" & txtSearchBook.text & "%' or dateissued like '%" & txtSearchBook.text & "%' or totalpersons like '%" & txtSearchBook.text & "%' or balance like '%" & txtSearchBook.text & "%' or name like '%" & txtSearchBook.text & "%' or status like '%" & txtSearchBook.text & "%'", DGBOOKING)
        ElseIf (chckALL.Checked = False) Then
            displayRecords("select *from booking_infoPartial where ID like '%" & txtSearchBook.text & "%' or dateissued like '%" & txtSearchBook.text & "%' or totalpersons like '%" & txtSearchBook.text & "%' or balance like '%" & txtSearchBook.text & "%' or name like '%" & txtSearchBook.text & "%' or status like '%" & txtSearchBook.text & "%' and status = 'Partial'", DGBOOKING)
        End If



    End Sub

    Private Sub chckALL_CheckedChanged(sender As Object, e As EventArgs) Handles chckALL.CheckedChanged
        If (chckALL.Checked = True) Then
            displayRecords("select *from booking_info", DGBOOKING)
        Else
            displayRecords("select *from booking_infoPartial", DGBOOKING)
        End If
    End Sub



    Private Sub frmMainMenu_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        displayRecords("select *from booking_info where status = 'Partial'", DGBOOKING)
        lblBookingID.Text = ""
        lblTotalPerons.Text = ""
        lblCustomerName.Text = ""
        lblBalance.Text = ""

    End Sub

    Private Sub DGBOOKING_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGBOOKING.CellContentClick
        If (e.ColumnIndex = 0) Then
            'puede na icheckout ang room
            'ErrorMessage("CheckOUT") condition for checking out
            Dim i = e.RowIndex

            With DGBOOKING
                lblBookingID.Text = .Item(1, i).Value
                lblTotalPerons.Text = .Item(3, i).Value
                lblCustomerName.Text = .Item(5, i).Value
                lblBalance.Text = .Item(4, i).Value
            End With
            If (Val(lblBalance.Text) > 0) Then
                ErrorMessage("Unable to Remove! There is still a balance Pending!!!")
            Else
                Dim updateBookQuery = "update tbl_booking set booking_statusID = 2 where booking_id = '" & lblBookingID.Text & "';"
                SQLProcess(updateBookQuery)
                displayRecords("select *from booking_info where status = 'Partial'", DGBOOKING)
            End If
        End If
    End Sub

    Private Sub DGBOOKING_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGBOOKING.CellClick
        If Not (e.ColumnIndex = 0) Then
            Dim i = e.RowIndex

            With DGBOOKING
                lblBookingID.Text = .Item(1, i).Value
                lblTotalPerons.Text = .Item(3, i).Value
                lblCustomerName.Text = .Item(5, i).Value
                lblBalance.Text = .Item(4, i).Value
            End With
            Dim booking As New Booking
            booking.lblBookingID.Text = lblBookingID.Text
            booking.txtCustomerName.Text = lblCustomerName.Text
            booking.lblTotalAmount.Text = lblBalance.Text
            booking.txtTotalPersons.Text = lblTotalPerons.Text
            booking.txtTotalPersons.Enabled = False
            booking.txtCustomerName.Enabled = False
            booking.lblMoney.Text = "Amount:"
            booking.btnCreateBooking.Text = "UPDATE"
            Dim btn As New DataGridViewButtonColumn()
            booking.DGRooms.Columns.Add(btn)
            btn.HeaderText = "Action"
            btn.Text = "Check out"
            btn.Name = "btnRemove"
            btn.UseColumnTextForButtonValue = True
            booking.ShowDialog()

        End If

    End Sub

    Private Sub btnSideCustomer_Click(sender As Object, e As EventArgs) Handles btnSideCustomer.Click
        Dim cust As New Customer
        cust.ShowDialog()
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Dim trans As New Transactions
        trans.Show()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim sign As New frmSignIn
        sign.Show()
        Me.Hide()

    End Sub
End Class