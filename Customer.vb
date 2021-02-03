Public Class Customer
    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadToComboBox("select *from tbl_gender", cboGender)
        loadToComboBox("select *from tbl_gender", cboUpdatedGender)
        displayRecords("select *from customer_info", DGCustomer)
    End Sub

    Private Sub txtCustomerNam_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = StringFormat(e)
    End Sub

    Private Sub txtCustomerContact_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = NumberFormat(e)
    End Sub

    Private Sub txtCustomerAddress_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = StringFormat(e)
    End Sub

    Private Sub txtCustomerEmail_Validated(sender As Object, e As EventArgs)
        EmailVerification(txtCustomerEmail)
    End Sub

    Private Sub txtSearchCustomer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchCustomer.KeyPress
        displayRecords("select *from customer_info where ID like '%" & txtSearchCustomer.Text & "%' or Name like '%" & txtSearchCustomer.Text & "%' or Address like '%" & txtSearchCustomer.Text & "%' or Contact like '%" & txtSearchCustomer.Text & "%' or Email like '%" & txtSearchCustomer.Text & "%' or Gender like '%" & txtSearchCustomer.Text & "%'", DGCustomer)
    End Sub

    Private Sub txtSearchCustName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchCustName.KeyPress, txtCustomerAddress.KeyPress
        e.Handled = StringFormat(e)
    End Sub

    Private Sub txtSearchCustContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchCustContact.KeyPress
        e.Handled = NumberFormat(e)
    End Sub

    Private Sub txtSearchEmail_Validated(sender As Object, e As EventArgs) Handles txtSearchEmail.Validated
        EmailVerification(txtSearchEmail)
    End Sub

    Private Sub DGCustomer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCustomer.CellClick
        Dim i = e.RowIndex
        With DGCustomer
            lblID.Text = .Item(0, i).Value.ToString
            txtSearchCustName.Text = .Item(1, i).Value.ToString
            txtSearchCustAddress.Text = .Item(2, i).Value.ToString
            txtSearchCustContact.Text = .Item(3, i).Value.ToString
            txtSearchEmail.Text = .Item(4, i).Value.ToString
            cboGender.Text = .Item(5, i).Value.ToString
        End With

    End Sub

    Private Sub btnUpdateEmployee_Click(sender As Object, e As EventArgs) Handles btnUpdateEmployee.Click
        Dim updateQuery = "update tbl_customer set name = '" & txtSearchCustName.Text & "',address = '" & txtSearchCustAddress.Text & "', contact = " & txtSearchCustContact.Text & ", email = '" & txtCustomerEmail.Text & "', gender_id = " & cboGender.SelectedValue.ToString & ""
        SQLProcess(updateQuery)
        displayRecords("select *from customer_info", DGCustomer)
        Dim tb() = {txtSearchCustContact, txtSearchCustAddress, txtSearchCustName, txtSearchEmail}
    End Sub

    Private Sub btnCreateCustomer_Click(sender As Object, e As EventArgs) Handles btnCreateCustomer.Click
        Dim id = "C" & recordCount("select customer_id from tbl_customer").ToString
        Dim inp() = {"@customerID", "@customer_name", "@address", "@contact", "@points", "@email", "@gender"}
        Dim input() = {id, txtCustomerNam.Text, txtCustomerAddress.Text, txtCustomerContact.Text, "0", txtCustomerEmail.Text, cboGender.SelectedValue.ToString}
        If (Required(input) = False) Then
            ErrorMessage("Please Fill up the Empty Information")
        Else
            Dim insertSQL = "insert into tbl_customer values (@customerID,@customer_name,@address,@contact,@points,@email,@gender)"
            'MessageBox.Show(id)
            SQLProcess(insertSQL, inp, input)
            Me.Close()
        End If
    End Sub
End Class