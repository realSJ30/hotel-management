Public Class BookRoom
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        'MessageBox.Show(GetDate(DateIn.Value.ToString))

        If (CInt(Date.Compare(DateIn.Value, DateOut.Value)) = -1) Then 'means mas early and checkin kesa sa checkout which is tama

            Dim room As New Rooms
            Dim booking As New Booking
            'insert partial booking ID
            Dim bookingid = "B00" & recordCount("select *from tbl_booking")
            Dim partialQUERY = "insert into tbl_booking (booking_id) values ('" & bookingid & "')"
            SQLProcess(partialQUERY)
            room.lblIN.Text = GetDate(DateIn.Value.ToString)
            room.lblOUT.Text = GetDate(DateOut.Value.ToString)
            room.Show()
            booking.lblBookingID.Text = retrieveID("select booking_id from tbl_booking where booking_id = '" & bookingid.ToString & "'")
            booking.Show()
            Me.Hide()
        Else
            ErrorMessage("Invalid Details Check in must be earlier than Check out!!!")
        End If


    End Sub
End Class