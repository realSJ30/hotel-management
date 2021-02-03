<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCreateBooking = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.lblTotalRooms = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.lblBookingID = New System.Windows.Forms.Label()
        Me.txtCustomerName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.txtDownpayment = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.DGRooms = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalPersons = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.lblMaxCapacity = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnAddGuest = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtGuest = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboAmenities = New System.Windows.Forms.ComboBox()
        Me.txtAmenPips = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnAddAmen = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DGRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Booking Form"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(561, 43)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Book ID:"
        '
        'btnCreateBooking
        '
        Me.btnCreateBooking.Activecolor = System.Drawing.Color.Transparent
        Me.btnCreateBooking.BackColor = System.Drawing.Color.Transparent
        Me.btnCreateBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCreateBooking.BorderRadius = 0
        Me.btnCreateBooking.ButtonText = "ADD TO MY BOOK"
        Me.btnCreateBooking.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreateBooking.DisabledColor = System.Drawing.Color.Gray
        Me.btnCreateBooking.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCreateBooking.Iconimage = Global.EDP_Project_Hotel_Management_.My.Resources.Resources.add_ticket_96px
        Me.btnCreateBooking.Iconimage_right = Nothing
        Me.btnCreateBooking.Iconimage_right_Selected = Nothing
        Me.btnCreateBooking.Iconimage_Selected = Nothing
        Me.btnCreateBooking.IconMarginLeft = 0
        Me.btnCreateBooking.IconMarginRight = 0
        Me.btnCreateBooking.IconRightVisible = True
        Me.btnCreateBooking.IconRightZoom = 0R
        Me.btnCreateBooking.IconVisible = True
        Me.btnCreateBooking.IconZoom = 90.0R
        Me.btnCreateBooking.IsTab = False
        Me.btnCreateBooking.Location = New System.Drawing.Point(114, 452)
        Me.btnCreateBooking.Name = "btnCreateBooking"
        Me.btnCreateBooking.Normalcolor = System.Drawing.Color.Transparent
        Me.btnCreateBooking.OnHovercolor = System.Drawing.Color.Transparent
        Me.btnCreateBooking.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnCreateBooking.selected = False
        Me.btnCreateBooking.Size = New System.Drawing.Size(199, 55)
        Me.btnCreateBooking.TabIndex = 4
        Me.btnCreateBooking.Text = "ADD TO MY BOOK"
        Me.btnCreateBooking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCreateBooking.Textcolor = System.Drawing.Color.DarkRed
        Me.btnCreateBooking.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total Rooms in Book:"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(44, 142)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(478, 10)
        Me.BunifuSeparator1.TabIndex = 6
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'lblTotalRooms
        '
        Me.lblTotalRooms.AutoSize = True
        Me.lblTotalRooms.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRooms.Location = New System.Drawing.Point(160, 192)
        Me.lblTotalRooms.Name = "lblTotalRooms"
        Me.lblTotalRooms.Size = New System.Drawing.Size(33, 17)
        Me.lblTotalRooms.TabIndex = 7
        Me.lblTotalRooms.Text = "N/A"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Room List"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Customer Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 327)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Total Amount:"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(146, 327)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(33, 17)
        Me.lblTotalAmount.TabIndex = 13
        Me.lblTotalAmount.Text = "N/A"
        '
        'lblBookingID
        '
        Me.lblBookingID.AutoSize = True
        Me.lblBookingID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookingID.Location = New System.Drawing.Point(111, 63)
        Me.lblBookingID.Name = "lblBookingID"
        Me.lblBookingID.Size = New System.Drawing.Size(33, 17)
        Me.lblBookingID.TabIndex = 14
        Me.lblBookingID.Text = "N/A"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustomerName.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCustomerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCustomerName.HintForeColor = System.Drawing.Color.Empty
        Me.txtCustomerName.HintText = ""
        Me.txtCustomerName.isPassword = False
        Me.txtCustomerName.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtCustomerName.LineIdleColor = System.Drawing.Color.Gray
        Me.txtCustomerName.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtCustomerName.LineThickness = 3
        Me.txtCustomerName.Location = New System.Drawing.Point(136, 96)
        Me.txtCustomerName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(226, 21)
        Me.txtCustomerName.TabIndex = 15
        Me.txtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Details:"
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoney.Location = New System.Drawing.Point(9, 367)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(105, 16)
        Me.lblMoney.TabIndex = 17
        Me.lblMoney.Text = "Downpayment:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 410)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 16)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Payment Method:"
        '
        'cboPaymentMethod
        '
        Me.cboPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPaymentMethod.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPaymentMethod.FormattingEnabled = True
        Me.cboPaymentMethod.Location = New System.Drawing.Point(145, 405)
        Me.cboPaymentMethod.Name = "cboPaymentMethod"
        Me.cboPaymentMethod.Size = New System.Drawing.Size(138, 25)
        Me.cboPaymentMethod.TabIndex = 19
        '
        'txtDownpayment
        '
        Me.txtDownpayment.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtDownpayment.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDownpayment.Location = New System.Drawing.Point(146, 364)
        Me.txtDownpayment.Name = "txtDownpayment"
        Me.txtDownpayment.Size = New System.Drawing.Size(136, 22)
        Me.txtDownpayment.TabIndex = 20
        '
        'DGRooms
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGRooms.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGRooms.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGRooms.Location = New System.Drawing.Point(133, 235)
        Me.DGRooms.Name = "DGRooms"
        Me.DGRooms.Size = New System.Drawing.Size(389, 76)
        Me.DGRooms.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(288, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Total Persons:"
        '
        'txtTotalPersons
        '
        Me.txtTotalPersons.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtTotalPersons.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPersons.Location = New System.Drawing.Point(390, 325)
        Me.txtTotalPersons.Name = "txtTotalPersons"
        Me.txtTotalPersons.Size = New System.Drawing.Size(132, 22)
        Me.txtTotalPersons.TabIndex = 23
        '
        'lblMaxCapacity
        '
        Me.lblMaxCapacity.AutoSize = True
        Me.lblMaxCapacity.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxCapacity.Location = New System.Drawing.Point(403, 192)
        Me.lblMaxCapacity.Name = "lblMaxCapacity"
        Me.lblMaxCapacity.Size = New System.Drawing.Size(33, 17)
        Me.lblMaxCapacity.TabIndex = 25
        Me.lblMaxCapacity.Text = "N/A"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(288, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 16)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Max Capacity:"
        '
        'btnAddGuest
        '
        Me.btnAddGuest.Location = New System.Drawing.Point(447, 370)
        Me.btnAddGuest.Name = "btnAddGuest"
        Me.btnAddGuest.Size = New System.Drawing.Size(75, 21)
        Me.btnAddGuest.TabIndex = 26
        Me.btnAddGuest.Text = "Add"
        Me.btnAddGuest.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(334, 373)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 16)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Guest:"
        '
        'txtGuest
        '
        Me.txtGuest.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtGuest.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuest.Location = New System.Drawing.Point(390, 370)
        Me.txtGuest.Name = "txtGuest"
        Me.txtGuest.Size = New System.Drawing.Size(46, 22)
        Me.txtGuest.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(289, 410)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 16)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Other Fee:"
        '
        'cboAmenities
        '
        Me.cboAmenities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAmenities.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAmenities.FormattingEnabled = True
        Me.cboAmenities.Location = New System.Drawing.Point(369, 405)
        Me.cboAmenities.Name = "cboAmenities"
        Me.cboAmenities.Size = New System.Drawing.Size(153, 25)
        Me.cboAmenities.TabIndex = 30
        '
        'txtAmenPips
        '
        Me.txtAmenPips.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtAmenPips.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmenPips.Location = New System.Drawing.Point(371, 436)
        Me.txtAmenPips.Name = "txtAmenPips"
        Me.txtAmenPips.Size = New System.Drawing.Size(46, 22)
        Me.txtAmenPips.TabIndex = 33
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(290, 440)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 16)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Per/Head:"
        '
        'btnAddAmen
        '
        Me.btnAddAmen.Location = New System.Drawing.Point(447, 436)
        Me.btnAddAmen.Name = "btnAddAmen"
        Me.btnAddAmen.Size = New System.Drawing.Size(75, 21)
        Me.btnAddAmen.TabIndex = 31
        Me.btnAddAmen.Text = "Add"
        Me.btnAddAmen.UseVisualStyleBackColor = True
        '
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 566)
        Me.Controls.Add(Me.txtAmenPips)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnAddAmen)
        Me.Controls.Add(Me.cboAmenities)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtGuest)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnAddGuest)
        Me.Controls.Add(Me.lblMaxCapacity)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTotalPersons)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DGRooms)
        Me.Controls.Add(Me.txtDownpayment)
        Me.Controls.Add(Me.cboPaymentMethod)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblMoney)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.lblBookingID)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTotalRooms)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCreateBooking)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Booking"
        Me.Text = "Booking"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGRooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCreateBooking As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents lblTotalRooms As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents lblBookingID As Label
    Friend WithEvents txtCustomerName As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblMoney As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cboPaymentMethod As ComboBox
    Friend WithEvents txtDownpayment As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents DGRooms As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotalPersons As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents lblMaxCapacity As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnAddGuest As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtGuest As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label11 As Label
    Friend WithEvents cboAmenities As ComboBox
    Friend WithEvents txtAmenPips As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnAddAmen As Button
End Class
