Public Class Rooms


    Private Sub AllButtons_Click(sender As Object, e As EventArgs) Handles btnRoom101.Click, btnRoom102.Click, btnRoom103.Click, BunifuFlatButton4.Click,
                                                            BunifuFlatButton5.Click, BunifuFlatButton6.Click, BunifuFlatButton7.Click, BunifuFlatButton8.Click,
                                                            BunifuFlatButton9.Click, BunifuFlatButton10.Click, BunifuFlatButton11.Click, BunifuFlatButton12.Click, BunifuFlatButton13.Click, BunifuFlatButton14.Click, BunifuFlatButton15.Click, BunifuFlatButton16.Click, BunifuFlatButton17.Click,
                                                            BunifuFlatButton18.Click, BunifuFlatButton19.Click, BunifuFlatButton20.Click, BunifuFlatButton21.Click, BunifuFlatButton22.Click, BunifuFlatButton23.Click, BunifuFlatButton24.Click, BunifuFlatButton25.Click, BunifuFlatButton26.Click, BunifuFlatButton27.Click,
                                                            BunifuFlatButton28.Click, BunifuFlatButton29.Click, BunifuFlatButton30.Click, BunifuFlatButton31.Click, BunifuFlatButton32.Click, BunifuFlatButton33.Click, BunifuFlatButton34.Click, BunifuFlatButton35.Click, BunifuFlatButton36.Click, BunifuFlatButton37.Click, BunifuFlatButton38.Click, BunifuFlatButton39.Click, BunifuFlatButton40.Click,
                                                            BunifuFlatButton41.Click, BunifuFlatButton42.Click, BunifuFlatButton43.Click, BunifuFlatButton44.Click, BunifuFlatButton45.Click, BunifuFlatButton46.Click, BunifuFlatButton47.Click, BunifuFlatButton48.Click
        '-------------------------syaro hahahaha one event handler for all buttons!!!-----------------------------------'
        Dim b As Bunifu.Framework.UI.BunifuFlatButton = DirectCast(sender, Bunifu.Framework.UI.BunifuFlatButton)
        ButtonHandler(b, lblIN, lblOUT)
        Dim btn() As Bunifu.Framework.UI.BunifuFlatButton = {btnRoom101, btnRoom102, btnRoom103, BunifuFlatButton4,
                                                            BunifuFlatButton5, BunifuFlatButton6, BunifuFlatButton7, BunifuFlatButton8,
                                                            BunifuFlatButton9, BunifuFlatButton10, BunifuFlatButton11, BunifuFlatButton12, BunifuFlatButton13, BunifuFlatButton14, BunifuFlatButton15, BunifuFlatButton16, BunifuFlatButton17,
                                                            BunifuFlatButton18, BunifuFlatButton19, BunifuFlatButton20, BunifuFlatButton21, BunifuFlatButton22, BunifuFlatButton23, BunifuFlatButton24, BunifuFlatButton25, BunifuFlatButton26, BunifuFlatButton27,
                                                            BunifuFlatButton28, BunifuFlatButton29, BunifuFlatButton30, BunifuFlatButton31, BunifuFlatButton32, BunifuFlatButton33, BunifuFlatButton34, BunifuFlatButton35, BunifuFlatButton36, BunifuFlatButton37, BunifuFlatButton38, BunifuFlatButton39, BunifuFlatButton40,
                                                            BunifuFlatButton41, BunifuFlatButton42, BunifuFlatButton43, BunifuFlatButton44, BunifuFlatButton45, BunifuFlatButton46, BunifuFlatButton47, BunifuFlatButton48}


        roomStatus(btn, "select door_number from tbl_rooms where room_id IN (select room_id from tbl_bookrooms where CheckinDate = '" & lblIN.Text & "' or checkoutDate = '" & lblOUT.Text & "')")
        roomStatusRepair(btn, "select door_number,roomstatus_ID from tbl_rooms")



    End Sub

    Private Sub Rooms_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim btn() As Bunifu.Framework.UI.BunifuFlatButton = {btnRoom101, btnRoom102, btnRoom103, BunifuFlatButton4,
                                                           BunifuFlatButton5, BunifuFlatButton6, BunifuFlatButton7, BunifuFlatButton8,
                                                           BunifuFlatButton9, BunifuFlatButton10, BunifuFlatButton11, BunifuFlatButton12, BunifuFlatButton13, BunifuFlatButton14, BunifuFlatButton15, BunifuFlatButton16, BunifuFlatButton17,
                                                           BunifuFlatButton18, BunifuFlatButton19, BunifuFlatButton20, BunifuFlatButton21, BunifuFlatButton22, BunifuFlatButton23, BunifuFlatButton24, BunifuFlatButton25, BunifuFlatButton26, BunifuFlatButton27,
                                                           BunifuFlatButton28, BunifuFlatButton29, BunifuFlatButton30, BunifuFlatButton31, BunifuFlatButton32, BunifuFlatButton33, BunifuFlatButton34, BunifuFlatButton35, BunifuFlatButton36, BunifuFlatButton37, BunifuFlatButton38, BunifuFlatButton39, BunifuFlatButton40,
                                                           BunifuFlatButton41, BunifuFlatButton42, BunifuFlatButton43, BunifuFlatButton44, BunifuFlatButton45, BunifuFlatButton46, BunifuFlatButton47, BunifuFlatButton48}

        roomStatus(btn, "select door_number from tbl_rooms where room_id IN (select room_id from tbl_bookrooms where (CheckinDate = '" & lblIN.Text & "' or checkoutDate = '" & lblOUT.Text & "') and bookroom_statusID = 3)")
        roomStatusRepair(btn, "select door_number,roomstatus_ID from tbl_rooms")
    End Sub
    Private Sub Rooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim btn() As Bunifu.Framework.UI.BunifuFlatButton = {btnRoom101, btnRoom102, btnRoom103, BunifuFlatButton4,
                                                            BunifuFlatButton5, BunifuFlatButton6, BunifuFlatButton7, BunifuFlatButton8,
                                                            BunifuFlatButton9, BunifuFlatButton10, BunifuFlatButton11, BunifuFlatButton12, BunifuFlatButton13, BunifuFlatButton14, BunifuFlatButton15, BunifuFlatButton16, BunifuFlatButton17,
                                                            BunifuFlatButton18, BunifuFlatButton19, BunifuFlatButton20, BunifuFlatButton21, BunifuFlatButton22, BunifuFlatButton23, BunifuFlatButton24, BunifuFlatButton25, BunifuFlatButton26, BunifuFlatButton27,
                                                            BunifuFlatButton28, BunifuFlatButton29, BunifuFlatButton30, BunifuFlatButton31, BunifuFlatButton32, BunifuFlatButton33, BunifuFlatButton34, BunifuFlatButton35, BunifuFlatButton36, BunifuFlatButton37, BunifuFlatButton38, BunifuFlatButton39, BunifuFlatButton40,
                                                            BunifuFlatButton41, BunifuFlatButton42, BunifuFlatButton43, BunifuFlatButton44, BunifuFlatButton45, BunifuFlatButton46, BunifuFlatButton47, BunifuFlatButton48}

        roomStatus(btn, "select door_number from tbl_rooms where room_id IN (select room_id from tbl_bookrooms where (CheckinDate = '" & lblIN.Text & "' or checkoutDate = '" & lblOUT.Text & "') and bookroom_statusID = 3)")
        roomStatusRepair(btn, "select door_number,roomstatus_ID from tbl_rooms")
    End Sub

End Class