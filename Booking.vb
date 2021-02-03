Public Class Booking
    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'display to listbox
        'displayRecordsList("select booking_id from tbl_booking where booking_statusid = 1", listBookings)
        displayRecords("select r.door_number,br.checkinDate,br.checkoutDate from tbl_bookrooms br join tbl_rooms r using(room_id) where booking_id = '" & lblBookingID.Text & "' and bookroom_statusID = 3", DGRooms)
        'load to combobox
        loadToComboBox("select *from tbl_paymentmethod", cboPaymentMethod)
        loadToComboBox("select *from tbl_amenities", cboAmenities)
        If (btnCreateBooking.Text.Equals("ADD TO MY BOOK")) Then
            Dim btn As New DataGridViewButtonColumn()
            DGRooms.Columns.Add(btn)
            btn.HeaderText = "Action"
            btn.Text = "Remove"
            btn.Name = "btnRemove"
            btn.UseColumnTextForButtonValue = True
        End If

    End Sub

    Private Sub txtCustomerName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCustomerName.KeyPress
        e.Handled = StringFormat(e)
    End Sub

    Private Sub txtDownpayment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDownpayment.KeyPress, txtGuest.KeyPress, txtAmenPips.KeyPress
        e.Handled = NumberFormat(e)
    End Sub

    Private Sub Booking_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        displayRecords("select r.door_number,br.checkinDate,br.checkoutDate from tbl_bookrooms br join tbl_rooms r using(room_id) where booking_id = '" & lblBookingID.Text & "' and bookroom_statusID = 3", DGRooms)
        lblTotalRooms.Text = (DGRooms.Rows.Count - 1).ToString
        Dim returnee = recordCount("select *from tbl_transaction where booking_id = '" & lblBookingID.Text & "'") - 1
        If (returnee > 0) Then

        Else
            lblTotalAmount.Text = retrieveID("select IFNULL(sum((rc.price_per_day * br.days) + (rc.serviceCharge * (select count(room_id) from tbl_bookrooms where booking_id = '" & lblBookingID.Text & "'))),0) as total from tbl_bookrooms br join tbl_rooms r using(room_id) left join tbl_roomcategory rc using(roomcategory_id) where booking_id = '" & lblBookingID.Text & "';").ToString
        End If
        lblMaxCapacity.Text = retrieveID("select IFNULL(sum(r.max_capacity),0) as total from tbl_bookrooms br join tbl_rooms r using(room_id) left join tbl_roomcategory rc using(roomcategory_id) where booking_id = '" & lblBookingID.Text & "';").ToString
    End Sub



    Private Sub DGRooms_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGRooms.CellContentClick
        If e.ColumnIndex <> 3 Then
            If (btnCreateBooking.Text.Equals("ADD TO MY BOOK")) Then
                ErrorMessage("ROOM REMOVED!")
                Dim r = e.RowIndex
                Dim removeQuery = "delete from tbl_bookrooms where room_id = (select room_id from tbl_rooms where door_number = '" & DGRooms.Rows(r).Cells(1).Value & "');"
                Dim updateQUERY = "update tbl_booking set total_Amount = " & lblTotalAmount.Text & " where booking_id = '" & lblBookingID.Text & "'"
                SQLProcess(removeQuery)
                SQLProcess(updateQUERY)
                displayRecords("select r.door_number,br.checkinDate,br.checkoutDate from tbl_bookrooms br join tbl_rooms r using(room_id) where booking_id = '" & lblBookingID.Text & "' and bookroom_statusID = 3", DGRooms)
                lblTotalRooms.Text = (DGRooms.Rows.Count - 1).ToString
                lblTotalAmount.Text = retrieveID("select IFNULL(sum((rc.price_per_day * br.days) + (rc.serviceCharge * (select count(room_id) from tbl_bookrooms where booking_id = '" & lblBookingID.Text & "'))),0) as total from tbl_bookrooms br join tbl_rooms r using(room_id) left join tbl_roomcategory rc using(roomcategory_id) where booking_id = '" & lblBookingID.Text & "';").ToString
                lblMaxCapacity.Text = retrieveID("select IFNULL(sum(r.max_capacity),0) as total from tbl_bookrooms br join tbl_rooms r using(room_id) left join tbl_roomcategory rc using(roomcategory_id) where booking_id = '" & lblBookingID.Text & "';").ToString
            Else
                ErrorMessage("CHECK OUT")
                Dim updateBRQUERY = "update tbl_bookrooms set bookroom_statusID = 2 where booking_ID = '" & lblBookingID.Text & "'"
                SQLProcess(updateBRQUERY)
                displayRecords("select r.door_number,br.checkinDate,br.checkoutDate from tbl_bookrooms br join tbl_rooms r using(room_id) where booking_id = '" & lblBookingID.Text & "' and bookroom_statusID = 3", DGRooms)
            End If

        End If



    End Sub

    Private Sub btnCreateBooking_Click(sender As Object, e As EventArgs) Handles btnCreateBooking.Click
        Dim input() = {txtCustomerName.Text, txtDownpayment.Text}
        If (Required(input) = False) Then
            ErrorMessage("Please provide the following details!!!")
        Else
            If (btnCreateBooking.Text.Equals("ADD TO MY BOOK")) Then
                Dim customerQUERY = "insert into tbl_customer (customer_id,name) values ('C" & recordCount("select *from tbl_customer") & "','" & txtCustomerName.Text & "')"
                Dim bookingQUERY = "update tbl_booking set totalPersons = " & txtTotalPersons.Text & ",total_Amount = " & CInt(lblTotalAmount.Text) - CInt(txtDownpayment.Text) & ",customer_id = (select customer_id from tbl_customer where name ='" & txtCustomerName.Text & "'),booking_statusid = 1 where booking_id = '" & lblBookingID.Text & "'"
                Dim transQUERY = "insert into tbl_transaction values (null,'" & lblBookingID.Text & "'," & txtDownpayment.Text & ",now()," & cboPaymentMethod.SelectedValue.ToString & ")"
                SQLProcess(customerQUERY)
                SQLProcess(bookingQUERY)
                SQLProcess(transQUERY)
                Me.Hide()
                Rooms.ActiveForm.Hide()
            Else

                Dim bookingQUERY = "update tbl_booking set totalPersons = " & txtTotalPersons.Text & ",total_Amount = " & CInt(lblTotalAmount.Text) - CInt(txtDownpayment.Text) & ",customer_id = (select customer_id from tbl_customer where name ='" & txtCustomerName.Text & "'),booking_statusid = 1 where booking_id = '" & lblBookingID.Text & "'"
                Dim transQUERY = "insert into tbl_transaction values (null,'" & lblBookingID.Text & "'," & txtDownpayment.Text & ",now()," & cboPaymentMethod.SelectedValue.ToString & ")"
                SQLProcess(bookingQUERY)
                SQLProcess(transQUERY)
                Me.Hide()

            End If


        End If


    End Sub


    Private Sub txtTotalPersons_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotalPersons.KeyPress
        e.Handled = NumberFormat(e)
    End Sub

    Private Sub txtTotalPersons_Validated(sender As Object, e As EventArgs) Handles txtTotalPersons.Validated
        If (txtTotalPersons.Text = "") Then
            txtTotalPersons.Text = "0"

        End If

        Dim excess As Integer = CInt(txtTotalPersons.Text) - CInt(lblMaxCapacity.Text)
        If (excess > 0) Then
            lblTotalAmount.Text = CInt(lblTotalAmount.Text) + (excess * 100)

        End If

    End Sub

    Private Sub btnAddGuest_Click(sender As Object, e As EventArgs) Handles btnAddGuest.Click
        Dim input() = {txtGuest.Text}
        If (Required(input) = False) Then
            ErrorMessage("No guest!")
        Else
            lblTotalAmount.Text = CInt(lblTotalAmount.Text) + (Val(txtGuest.Text) * 100)
        End If

    End Sub

    Private Sub btnAddAmen_Click(sender As Object, e As EventArgs) Handles btnAddAmen.Click
        Dim input() = {txtAmenPips.Text}
        If (Required(input) = False) Then
            ErrorMessage("No Number!")
        Else
            Dim amount = retrieveID("select fee from tbl_amenities where amenities_id = " & cboAmenities.SelectedValue.ToString)
            lblTotalAmount.Text = CInt(lblTotalAmount.Text) + (Val(txtAmenPips.Text) * amount)
            Dim insertQUERY = "insert into tbl_additionalCharges values ('" & lblBookingID.Text & "'," & cboAmenities.SelectedValue.ToString & ",now())"
            SQLProcess(insertQUERY)
        End If
    End Sub
End Class