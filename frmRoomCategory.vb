Public Class frmRoomCategory
    Dim rcname = ""
    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub frmRoomCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'display records to Data Grid View
        displayRecords("select CategoryName as Category from tbl_roomcategory", DGRoomCategory)
        displayRecords("select *from tbl_amenities", DGAmenities)
        'set the edit as false
        chckEnableRC.Checked = False
        chckEnabledAmen.Checked = False

        PanelAmenities.Visible = False

    End Sub
    Private Sub txtCategoryRoomSearch_KeyPress(sender As Object, e As EventArgs) Handles txtCategoryRoomSearch.KeyPress
        displayRecords("select CategoryName as Category from tbl_roomcategory where CategoryName like '%" & txtCategoryRoomSearch.text & "%'", DGRoomCategory)
    End Sub

    Private Sub DGRoomCategory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGRoomCategory.CellClick

        Try
            Dim i = e.RowIndex
            With DGRoomCategory
                txtRCName.Text = RoomCategory(txtRCPrice, txtRCServiceCharge, txtRCdescription, .Item(0, i).Value.ToString)
                rcname = .Item(0, i).Value.ToString
                GroupBox1.Enabled = False
                BunifuFlatButton1.Text = "UPDATE"
            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub chckEnableRC_OnChange(sender As Object, e As EventArgs) Handles chckEnableRC.OnChange
        If (chckEnableRC.Checked) Then
            GroupBox1.Enabled = True

        Else
            GroupBox1.Enabled = False
        End If
    End Sub


    Private Sub txtRCPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRCPrice.KeyPress, txtAmenFee.KeyPress
        e.Handled = NumberFormat(e)
    End Sub

    Private Sub txtRCServiceCharge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRCServiceCharge.KeyPress
        e.Handled = NumberFormat(e)
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim input() = {txtRCName.Text, txtRCPrice.Text, txtRCdescription.Text, txtRCServiceCharge.Text}

        If (Required(input) = False) Then
            ErrorMessage("Fill up all the information!")
        Else
            If (BunifuFlatButton1.Text.Equals("ADD")) Then  'INSERT
                Dim insertQUERY = "insert into tbl_roomcategory values (null,'" & txtRCName.Text & "','" & txtRCdescription.Text & "'," & txtRCPrice.Text & "," & txtRCServiceCharge.Text & ")"
                Dim tb() = {txtRCName, txtRCdescription, txtRCPrice, txtRCServiceCharge}
                ResetTextBox(tb)
                SQLProcess(insertQUERY)
                displayRecords("select CategoryName as Category from tbl_roomcategory", DGRoomCategory)
            Else    'UPDATE
                Dim updateSQL = "update tbl_roomcategory Set categoryName = '" & txtRCName.Text & "',price_per_day = " & txtRCPrice.Text & ",serviceCharge = " & txtRCServiceCharge.Text & ",description = '" & txtRCdescription.Text & "' where categoryName = '" & rcname & "'"
                SQLProcess(updateSQL)
                displayRecords("select CategoryName as Category from tbl_roomcategory", DGRoomCategory)
                chckEnableRC.Checked = False
                GroupBox1.Enabled = False
            End If

        End If



    End Sub

    Private Sub btnGotoAmenities_Click(sender As Object, e As EventArgs) Handles btnGotoAmenities.Click
        PanelRoomCategory.Visible = True
        PanelAmenities.Visible = True
    End Sub

    Private Sub btnGoToRC_Click(sender As Object, e As EventArgs) Handles btnGoToRC.Click

        PanelAmenities.Visible = False
        PanelRoomCategory.Visible = True

    End Sub

    Private Sub chckEnabledAmen_OnChange(sender As Object, e As EventArgs) Handles chckEnabledAmen.OnChange
        If (chckEnabledAmen.Checked) Then
            GroupBox2.Enabled = True

        Else
            GroupBox2.Enabled = False
        End If
    End Sub

    Private Sub DGAmenities_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGAmenities.CellClick

        Try
            
            Dim i = e.RowIndex
            With DGAmenities
                lblAmenID.Text = .Item(0, i).Value.ToString
                txtAmenName.Text = .Item(1, i).Value.ToString
                GroupBox2.Enabled = False
                btnAddAmenities.Text = "UPDATE"
            End With
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnAddAmenities_Click(sender As Object, e As EventArgs) Handles btnAddAmenities.Click
        Dim input() = {txtAmenName.Text}
        If (Required(input) = False) Then
            ErrorMessage("Please fill up the forms")
        Else
            If (btnAddAmenities.Text.Equals("ADD")) Then
                Dim addQUERY = "insert into tbl_amenities values (null,'" & txtAmenName.Text & "'," & txtAmenFee.Text & ")"
                SQLProcess(addQUERY)
                displayRecords("select *from tbl_amenities", DGAmenities)
                Dim tb() = {txtAmenName, txtAmenFee}
                ResetTextBox(tb)
            Else
                Dim updateQUERY = "update tbl_amenities set title = '" & txtAmenName.Text & "',fee = " & txtAmenFee.Text & " where amenities_id = " & lblAmenID.Text
                SQLProcess(updateQUERY)
                displayRecords("select *from tbl_amenities", DGAmenities)
            End If


        End If

    End Sub

End Class