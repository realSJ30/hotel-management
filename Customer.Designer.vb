<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ADD_CUSTOMER = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCreateCustomer = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.txtCustomerEmail = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtCustomerAddress = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtCustomerContact = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtCustomerNam = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UPDATE_CUSTOMER = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnUpdateEmployee = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.cboUpdatedGender = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSearchEmail = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtSearchCustContact = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtSearchCustAddress = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtSearchCustName = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSearchCustomer = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.DGCustomer = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.ADD_CUSTOMER.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.UPDATE_CUSTOMER.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ADD_CUSTOMER)
        Me.TabControl1.Controls.Add(Me.UPDATE_CUSTOMER)
        Me.TabControl1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(-2, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(427, 512)
        Me.TabControl1.TabIndex = 0
        '
        'ADD_CUSTOMER
        '
        Me.ADD_CUSTOMER.Controls.Add(Me.Panel1)
        Me.ADD_CUSTOMER.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADD_CUSTOMER.Location = New System.Drawing.Point(4, 28)
        Me.ADD_CUSTOMER.Name = "ADD_CUSTOMER"
        Me.ADD_CUSTOMER.Padding = New System.Windows.Forms.Padding(3)
        Me.ADD_CUSTOMER.Size = New System.Drawing.Size(419, 480)
        Me.ADD_CUSTOMER.TabIndex = 0
        Me.ADD_CUSTOMER.Text = "Add Customer"
        Me.ADD_CUSTOMER.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnCreateCustomer)
        Me.Panel1.Controls.Add(Me.cboGender)
        Me.Panel1.Controls.Add(Me.txtCustomerEmail)
        Me.Panel1.Controls.Add(Me.txtCustomerAddress)
        Me.Panel1.Controls.Add(Me.txtCustomerContact)
        Me.Panel1.Controls.Add(Me.txtCustomerNam)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(422, 486)
        Me.Panel1.TabIndex = 1
        '
        'btnCreateCustomer
        '
        Me.btnCreateCustomer.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCreateCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCreateCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCreateCustomer.BorderRadius = 0
        Me.btnCreateCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnCreateCustomer.ButtonText = "SUBMIT"
        Me.btnCreateCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreateCustomer.DisabledColor = System.Drawing.Color.Gray
        Me.btnCreateCustomer.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCreateCustomer.Iconimage = Nothing
        Me.btnCreateCustomer.Iconimage_right = Nothing
        Me.btnCreateCustomer.Iconimage_right_Selected = Nothing
        Me.btnCreateCustomer.Iconimage_Selected = Nothing
        Me.btnCreateCustomer.IconMarginLeft = 0
        Me.btnCreateCustomer.IconMarginRight = 0
        Me.btnCreateCustomer.IconRightVisible = False
        Me.btnCreateCustomer.IconRightZoom = 0R
        Me.btnCreateCustomer.IconVisible = False
        Me.btnCreateCustomer.IconZoom = 90.0R
        Me.btnCreateCustomer.IsTab = False
        Me.btnCreateCustomer.Location = New System.Drawing.Point(94, 416)
        Me.btnCreateCustomer.Name = "btnCreateCustomer"
        Me.btnCreateCustomer.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCreateCustomer.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnCreateCustomer.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCreateCustomer.selected = False
        Me.btnCreateCustomer.Size = New System.Drawing.Size(241, 40)
        Me.btnCreateCustomer.TabIndex = 11
        Me.btnCreateCustomer.Text = "SUBMIT"
        Me.btnCreateCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCreateCustomer.Textcolor = System.Drawing.Color.White
        Me.btnCreateCustomer.TextFont = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Location = New System.Drawing.Point(135, 244)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(113, 25)
        Me.cboGender.TabIndex = 10
        '
        'txtCustomerEmail
        '
        Me.txtCustomerEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustomerEmail.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCustomerEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCustomerEmail.HintForeColor = System.Drawing.Color.Empty
        Me.txtCustomerEmail.HintText = ""
        Me.txtCustomerEmail.isPassword = False
        Me.txtCustomerEmail.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtCustomerEmail.LineIdleColor = System.Drawing.Color.Gray
        Me.txtCustomerEmail.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtCustomerEmail.LineThickness = 3
        Me.txtCustomerEmail.Location = New System.Drawing.Point(137, 189)
        Me.txtCustomerEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerEmail.Name = "txtCustomerEmail"
        Me.txtCustomerEmail.Size = New System.Drawing.Size(207, 34)
        Me.txtCustomerEmail.TabIndex = 9
        Me.txtCustomerEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtCustomerAddress
        '
        Me.txtCustomerAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustomerAddress.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCustomerAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCustomerAddress.HintForeColor = System.Drawing.Color.Empty
        Me.txtCustomerAddress.HintText = ""
        Me.txtCustomerAddress.isPassword = False
        Me.txtCustomerAddress.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtCustomerAddress.LineIdleColor = System.Drawing.Color.Gray
        Me.txtCustomerAddress.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtCustomerAddress.LineThickness = 3
        Me.txtCustomerAddress.Location = New System.Drawing.Point(137, 147)
        Me.txtCustomerAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerAddress.Name = "txtCustomerAddress"
        Me.txtCustomerAddress.Size = New System.Drawing.Size(207, 34)
        Me.txtCustomerAddress.TabIndex = 8
        Me.txtCustomerAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtCustomerContact
        '
        Me.txtCustomerContact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustomerContact.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCustomerContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCustomerContact.HintForeColor = System.Drawing.Color.Empty
        Me.txtCustomerContact.HintText = ""
        Me.txtCustomerContact.isPassword = False
        Me.txtCustomerContact.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtCustomerContact.LineIdleColor = System.Drawing.Color.Gray
        Me.txtCustomerContact.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtCustomerContact.LineThickness = 3
        Me.txtCustomerContact.Location = New System.Drawing.Point(137, 100)
        Me.txtCustomerContact.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerContact.Name = "txtCustomerContact"
        Me.txtCustomerContact.Size = New System.Drawing.Size(207, 34)
        Me.txtCustomerContact.TabIndex = 7
        Me.txtCustomerContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtCustomerNam
        '
        Me.txtCustomerNam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustomerNam.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCustomerNam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCustomerNam.HintForeColor = System.Drawing.Color.Empty
        Me.txtCustomerNam.HintText = ""
        Me.txtCustomerNam.isPassword = False
        Me.txtCustomerNam.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtCustomerNam.LineIdleColor = System.Drawing.Color.Gray
        Me.txtCustomerNam.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtCustomerNam.LineThickness = 3
        Me.txtCustomerNam.Location = New System.Drawing.Point(137, 52)
        Me.txtCustomerNam.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerNam.Name = "txtCustomerNam"
        Me.txtCustomerNam.Size = New System.Drawing.Size(207, 34)
        Me.txtCustomerNam.TabIndex = 6
        Me.txtCustomerNam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Gender:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contact:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(294, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CUSTOMER FILL UP FORM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'UPDATE_CUSTOMER
        '
        Me.UPDATE_CUSTOMER.Controls.Add(Me.Panel2)
        Me.UPDATE_CUSTOMER.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UPDATE_CUSTOMER.Location = New System.Drawing.Point(4, 28)
        Me.UPDATE_CUSTOMER.Name = "UPDATE_CUSTOMER"
        Me.UPDATE_CUSTOMER.Padding = New System.Windows.Forms.Padding(3)
        Me.UPDATE_CUSTOMER.Size = New System.Drawing.Size(419, 480)
        Me.UPDATE_CUSTOMER.TabIndex = 1
        Me.UPDATE_CUSTOMER.Text = "Update Customer"
        Me.UPDATE_CUSTOMER.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblID)
        Me.Panel2.Controls.Add(Me.btnUpdateEmployee)
        Me.Panel2.Controls.Add(Me.cboUpdatedGender)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txtSearchEmail)
        Me.Panel2.Controls.Add(Me.txtSearchCustContact)
        Me.Panel2.Controls.Add(Me.txtSearchCustAddress)
        Me.Panel2.Controls.Add(Me.txtSearchCustName)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtSearchCustomer)
        Me.Panel2.Controls.Add(Me.DGCustomer)
        Me.Panel2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(5, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(411, 448)
        Me.Panel2.TabIndex = 0
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(27, 130)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(29, 16)
        Me.lblID.TabIndex = 15
        Me.lblID.Text = "N/a"
        Me.lblID.Visible = False
        '
        'btnUpdateEmployee
        '
        Me.btnUpdateEmployee.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnUpdateEmployee.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnUpdateEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdateEmployee.BorderRadius = 0
        Me.btnUpdateEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnUpdateEmployee.ButtonText = "SUBMIT"
        Me.btnUpdateEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateEmployee.DisabledColor = System.Drawing.Color.Gray
        Me.btnUpdateEmployee.Iconcolor = System.Drawing.Color.Transparent
        Me.btnUpdateEmployee.Iconimage = Nothing
        Me.btnUpdateEmployee.Iconimage_right = Nothing
        Me.btnUpdateEmployee.Iconimage_right_Selected = Nothing
        Me.btnUpdateEmployee.Iconimage_Selected = Nothing
        Me.btnUpdateEmployee.IconMarginLeft = 0
        Me.btnUpdateEmployee.IconMarginRight = 0
        Me.btnUpdateEmployee.IconRightVisible = False
        Me.btnUpdateEmployee.IconRightZoom = 0R
        Me.btnUpdateEmployee.IconVisible = False
        Me.btnUpdateEmployee.IconZoom = 90.0R
        Me.btnUpdateEmployee.IsTab = False
        Me.btnUpdateEmployee.Location = New System.Drawing.Point(25, 380)
        Me.btnUpdateEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdateEmployee.Name = "btnUpdateEmployee"
        Me.btnUpdateEmployee.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnUpdateEmployee.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnUpdateEmployee.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUpdateEmployee.selected = False
        Me.btnUpdateEmployee.Size = New System.Drawing.Size(360, 31)
        Me.btnUpdateEmployee.TabIndex = 14
        Me.btnUpdateEmployee.Text = "SUBMIT"
        Me.btnUpdateEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnUpdateEmployee.Textcolor = System.Drawing.Color.White
        Me.btnUpdateEmployee.TextFont = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cboUpdatedGender
        '
        Me.cboUpdatedGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUpdatedGender.FormattingEnabled = True
        Me.cboUpdatedGender.Location = New System.Drawing.Point(130, 302)
        Me.cboUpdatedGender.Name = "cboUpdatedGender"
        Me.cboUpdatedGender.Size = New System.Drawing.Size(178, 24)
        Me.cboUpdatedGender.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(27, 303)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 21)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Gender:"
        '
        'txtSearchEmail
        '
        Me.txtSearchEmail.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtSearchEmail.Location = New System.Drawing.Point(132, 259)
        Me.txtSearchEmail.Name = "txtSearchEmail"
        Me.txtSearchEmail.Size = New System.Drawing.Size(246, 21)
        Me.txtSearchEmail.TabIndex = 11
        '
        'txtSearchCustContact
        '
        Me.txtSearchCustContact.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtSearchCustContact.Location = New System.Drawing.Point(132, 223)
        Me.txtSearchCustContact.Name = "txtSearchCustContact"
        Me.txtSearchCustContact.Size = New System.Drawing.Size(246, 21)
        Me.txtSearchCustContact.TabIndex = 10
        '
        'txtSearchCustAddress
        '
        Me.txtSearchCustAddress.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtSearchCustAddress.Location = New System.Drawing.Point(132, 189)
        Me.txtSearchCustAddress.Name = "txtSearchCustAddress"
        Me.txtSearchCustAddress.Size = New System.Drawing.Size(246, 21)
        Me.txtSearchCustAddress.TabIndex = 9
        '
        'txtSearchCustName
        '
        Me.txtSearchCustName.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtSearchCustName.Location = New System.Drawing.Point(132, 156)
        Me.txtSearchCustName.Name = "txtSearchCustName"
        Me.txtSearchCustName.Size = New System.Drawing.Size(246, 21)
        Me.txtSearchCustName.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 262)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 21)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Email:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 21)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Contact:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 21)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Address:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 21)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Name:"
        '
        'txtSearchCustomer
        '
        Me.txtSearchCustomer.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtSearchCustomer.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchCustomer.Location = New System.Drawing.Point(31, 19)
        Me.txtSearchCustomer.Name = "txtSearchCustomer"
        Me.txtSearchCustomer.Size = New System.Drawing.Size(140, 23)
        Me.txtSearchCustomer.TabIndex = 3
        '
        'DGCustomer
        '
        Me.DGCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCustomer.Location = New System.Drawing.Point(31, 52)
        Me.DGCustomer.Name = "DGCustomer"
        Me.DGCustomer.Size = New System.Drawing.Size(347, 75)
        Me.DGCustomer.TabIndex = 2
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 507)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer"
        Me.TabControl1.ResumeLayout(False)
        Me.ADD_CUSTOMER.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.UPDATE_CUSTOMER.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DGCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ADD_CUSTOMER As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCreateCustomer As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents txtCustomerEmail As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtCustomerAddress As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtCustomerContact As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtCustomerNam As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents UPDATE_CUSTOMER As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnUpdateEmployee As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents cboUpdatedGender As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtSearchEmail As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtSearchCustContact As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtSearchCustAddress As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtSearchCustName As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSearchCustomer As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents DGCustomer As DataGridView
    Friend WithEvents lblID As Label
End Class
