<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRoomCategory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRoomCategory))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGotoAmenities = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtRCServiceCharge = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRCPrice = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRCdescription = New System.Windows.Forms.RichTextBox()
        Me.txtRCName = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DGRoomCategory = New System.Windows.Forms.DataGridView()
        Me.txtCategoryRoomSearch = New Bunifu.Framework.UI.BunifuTextbox()
        Me.chckEnableRC = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.PanelRoomCategory = New System.Windows.Forms.Panel()
        Me.PanelAmenities = New System.Windows.Forms.Panel()
        Me.lblAmenID = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAddAmenities = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtAmenName = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chckEnabledAmen = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.txtSearchAmenities = New Bunifu.Framework.UI.BunifuTextbox()
        Me.DGAmenities = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnGoToRC = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAmenFee = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGRoomCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRoomCategory.SuspendLayout()
        Me.PanelAmenities.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGAmenities, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.btnGotoAmenities)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(533, 57)
        Me.Panel1.TabIndex = 0
        '
        'btnGotoAmenities
        '
        Me.btnGotoAmenities.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnGotoAmenities.BackColor = System.Drawing.Color.Transparent
        Me.btnGotoAmenities.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGotoAmenities.BorderRadius = 0
        Me.btnGotoAmenities.ButtonText = "Amenities >"
        Me.btnGotoAmenities.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGotoAmenities.DisabledColor = System.Drawing.Color.Gray
        Me.btnGotoAmenities.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGotoAmenities.Iconcolor = System.Drawing.Color.Transparent
        Me.btnGotoAmenities.Iconimage = Nothing
        Me.btnGotoAmenities.Iconimage_right = Nothing
        Me.btnGotoAmenities.Iconimage_right_Selected = Nothing
        Me.btnGotoAmenities.Iconimage_Selected = Nothing
        Me.btnGotoAmenities.IconMarginLeft = 0
        Me.btnGotoAmenities.IconMarginRight = 0
        Me.btnGotoAmenities.IconRightVisible = True
        Me.btnGotoAmenities.IconRightZoom = 0R
        Me.btnGotoAmenities.IconVisible = True
        Me.btnGotoAmenities.IconZoom = 90.0R
        Me.btnGotoAmenities.IsTab = False
        Me.btnGotoAmenities.Location = New System.Drawing.Point(411, 17)
        Me.btnGotoAmenities.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGotoAmenities.Name = "btnGotoAmenities"
        Me.btnGotoAmenities.Normalcolor = System.Drawing.Color.Transparent
        Me.btnGotoAmenities.OnHovercolor = System.Drawing.Color.Transparent
        Me.btnGotoAmenities.OnHoverTextColor = System.Drawing.Color.DarkRed
        Me.btnGotoAmenities.selected = False
        Me.btnGotoAmenities.Size = New System.Drawing.Size(110, 25)
        Me.btnGotoAmenities.TabIndex = 1
        Me.btnGotoAmenities.Text = "Amenities >"
        Me.btnGotoAmenities.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGotoAmenities.Textcolor = System.Drawing.Color.Black
        Me.btnGotoAmenities.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Location = New System.Drawing.Point(19, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Room Category"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BunifuFlatButton1)
        Me.GroupBox1.Controls.Add(Me.txtRCServiceCharge)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtRCPrice)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtRCdescription)
        Me.GroupBox1.Controls.Add(Me.txtRCName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(236, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 390)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Category Details"
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.DimGray
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "ADD"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(33, 307)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.DimGray
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.Black
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Yellow
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(235, 25)
        Me.BunifuFlatButton1.TabIndex = 8
        Me.BunifuFlatButton1.Text = "ADD"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtRCServiceCharge
        '
        Me.txtRCServiceCharge.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtRCServiceCharge.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRCServiceCharge.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtRCServiceCharge.BorderThickness = 3
        Me.txtRCServiceCharge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRCServiceCharge.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtRCServiceCharge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRCServiceCharge.isPassword = False
        Me.txtRCServiceCharge.Location = New System.Drawing.Point(131, 250)
        Me.txtRCServiceCharge.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRCServiceCharge.Name = "txtRCServiceCharge"
        Me.txtRCServiceCharge.Size = New System.Drawing.Size(146, 33)
        Me.txtRCServiceCharge.TabIndex = 7
        Me.txtRCServiceCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label5.Location = New System.Drawing.Point(11, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Service Charge:"
        '
        'txtRCPrice
        '
        Me.txtRCPrice.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtRCPrice.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRCPrice.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtRCPrice.BorderThickness = 3
        Me.txtRCPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRCPrice.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtRCPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRCPrice.isPassword = False
        Me.txtRCPrice.Location = New System.Drawing.Point(131, 209)
        Me.txtRCPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRCPrice.Name = "txtRCPrice"
        Me.txtRCPrice.Size = New System.Drawing.Size(146, 33)
        Me.txtRCPrice.TabIndex = 5
        Me.txtRCPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label4.Location = New System.Drawing.Point(11, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Price/Day:"
        '
        'txtRCdescription
        '
        Me.txtRCdescription.Location = New System.Drawing.Point(14, 141)
        Me.txtRCdescription.Name = "txtRCdescription"
        Me.txtRCdescription.Size = New System.Drawing.Size(267, 57)
        Me.txtRCdescription.TabIndex = 3
        Me.txtRCdescription.Text = ""
        '
        'txtRCName
        '
        Me.txtRCName.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtRCName.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRCName.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtRCName.BorderThickness = 3
        Me.txtRCName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRCName.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtRCName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRCName.isPassword = False
        Me.txtRCName.Location = New System.Drawing.Point(131, 35)
        Me.txtRCName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRCName.Name = "txtRCName"
        Me.txtRCName.Size = New System.Drawing.Size(146, 33)
        Me.txtRCName.TabIndex = 0
        Me.txtRCName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label2.Location = New System.Drawing.Point(7, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Category Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label3.Location = New System.Drawing.Point(11, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Description:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label6.Location = New System.Drawing.Point(50, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Enable Editing"
        '
        'DGRoomCategory
        '
        Me.DGRoomCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGRoomCategory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGRoomCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGRoomCategory.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGRoomCategory.Location = New System.Drawing.Point(12, 109)
        Me.DGRoomCategory.Name = "DGRoomCategory"
        Me.DGRoomCategory.ReadOnly = True
        Me.DGRoomCategory.RowHeadersVisible = False
        Me.DGRoomCategory.RowHeadersWidth = 80
        Me.DGRoomCategory.Size = New System.Drawing.Size(216, 109)
        Me.DGRoomCategory.TabIndex = 3
        '
        'txtCategoryRoomSearch
        '
        Me.txtCategoryRoomSearch.BackColor = System.Drawing.Color.Silver
        Me.txtCategoryRoomSearch.BackgroundImage = CType(resources.GetObject("txtCategoryRoomSearch.BackgroundImage"), System.Drawing.Image)
        Me.txtCategoryRoomSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtCategoryRoomSearch.ForeColor = System.Drawing.Color.Black
        Me.txtCategoryRoomSearch.Icon = CType(resources.GetObject("txtCategoryRoomSearch.Icon"), System.Drawing.Image)
        Me.txtCategoryRoomSearch.Location = New System.Drawing.Point(12, 74)
        Me.txtCategoryRoomSearch.Name = "txtCategoryRoomSearch"
        Me.txtCategoryRoomSearch.Size = New System.Drawing.Size(174, 29)
        Me.txtCategoryRoomSearch.TabIndex = 4
        Me.txtCategoryRoomSearch.text = ""
        '
        'chckEnableRC
        '
        Me.chckEnableRC.BackColor = System.Drawing.Color.Green
        Me.chckEnableRC.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chckEnableRC.Checked = True
        Me.chckEnableRC.CheckedOnColor = System.Drawing.Color.Green
        Me.chckEnableRC.ForeColor = System.Drawing.Color.White
        Me.chckEnableRC.Location = New System.Drawing.Point(24, 229)
        Me.chckEnableRC.Name = "chckEnableRC"
        Me.chckEnableRC.Size = New System.Drawing.Size(20, 20)
        Me.chckEnableRC.TabIndex = 5
        '
        'PanelRoomCategory
        '
        Me.PanelRoomCategory.AutoScroll = True
        Me.PanelRoomCategory.Controls.Add(Me.PanelAmenities)
        Me.PanelRoomCategory.Controls.Add(Me.chckEnableRC)
        Me.PanelRoomCategory.Controls.Add(Me.txtCategoryRoomSearch)
        Me.PanelRoomCategory.Controls.Add(Me.DGRoomCategory)
        Me.PanelRoomCategory.Controls.Add(Me.Label6)
        Me.PanelRoomCategory.Controls.Add(Me.GroupBox1)
        Me.PanelRoomCategory.Controls.Add(Me.Panel1)
        Me.PanelRoomCategory.Location = New System.Drawing.Point(0, 0)
        Me.PanelRoomCategory.Name = "PanelRoomCategory"
        Me.PanelRoomCategory.Size = New System.Drawing.Size(532, 476)
        Me.PanelRoomCategory.TabIndex = 0
        '
        'PanelAmenities
        '
        Me.PanelAmenities.Controls.Add(Me.lblAmenID)
        Me.PanelAmenities.Controls.Add(Me.GroupBox2)
        Me.PanelAmenities.Controls.Add(Me.chckEnabledAmen)
        Me.PanelAmenities.Controls.Add(Me.txtSearchAmenities)
        Me.PanelAmenities.Controls.Add(Me.DGAmenities)
        Me.PanelAmenities.Controls.Add(Me.Label8)
        Me.PanelAmenities.Controls.Add(Me.Panel2)
        Me.PanelAmenities.Location = New System.Drawing.Point(1, 0)
        Me.PanelAmenities.Name = "PanelAmenities"
        Me.PanelAmenities.Size = New System.Drawing.Size(528, 473)
        Me.PanelAmenities.TabIndex = 7
        '
        'lblAmenID
        '
        Me.lblAmenID.AutoSize = True
        Me.lblAmenID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmenID.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblAmenID.Location = New System.Drawing.Point(246, 203)
        Me.lblAmenID.Name = "lblAmenID"
        Me.lblAmenID.Size = New System.Drawing.Size(33, 17)
        Me.lblAmenID.TabIndex = 12
        Me.lblAmenID.Text = "N/A"
        Me.lblAmenID.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtAmenFee)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.btnAddAmenities)
        Me.GroupBox2.Controls.Add(Me.txtAmenName)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(219, 231)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(284, 188)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Details"
        '
        'btnAddAmenities
        '
        Me.btnAddAmenities.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnAddAmenities.BackColor = System.Drawing.Color.DimGray
        Me.btnAddAmenities.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddAmenities.BorderRadius = 0
        Me.btnAddAmenities.ButtonText = "ADD"
        Me.btnAddAmenities.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddAmenities.DisabledColor = System.Drawing.Color.Gray
        Me.btnAddAmenities.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAddAmenities.Iconimage = Nothing
        Me.btnAddAmenities.Iconimage_right = Nothing
        Me.btnAddAmenities.Iconimage_right_Selected = Nothing
        Me.btnAddAmenities.Iconimage_Selected = Nothing
        Me.btnAddAmenities.IconMarginLeft = 0
        Me.btnAddAmenities.IconMarginRight = 0
        Me.btnAddAmenities.IconRightVisible = True
        Me.btnAddAmenities.IconRightZoom = 0R
        Me.btnAddAmenities.IconVisible = True
        Me.btnAddAmenities.IconZoom = 90.0R
        Me.btnAddAmenities.IsTab = False
        Me.btnAddAmenities.Location = New System.Drawing.Point(26, 134)
        Me.btnAddAmenities.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddAmenities.Name = "btnAddAmenities"
        Me.btnAddAmenities.Normalcolor = System.Drawing.Color.DimGray
        Me.btnAddAmenities.OnHovercolor = System.Drawing.Color.Black
        Me.btnAddAmenities.OnHoverTextColor = System.Drawing.Color.Yellow
        Me.btnAddAmenities.selected = False
        Me.btnAddAmenities.Size = New System.Drawing.Size(235, 25)
        Me.btnAddAmenities.TabIndex = 8
        Me.btnAddAmenities.Text = "ADD"
        Me.btnAddAmenities.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAddAmenities.Textcolor = System.Drawing.Color.Black
        Me.btnAddAmenities.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtAmenName
        '
        Me.txtAmenName.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtAmenName.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAmenName.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtAmenName.BorderThickness = 3
        Me.txtAmenName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAmenName.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtAmenName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAmenName.isPassword = False
        Me.txtAmenName.Location = New System.Drawing.Point(78, 35)
        Me.txtAmenName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmenName.Name = "txtAmenName"
        Me.txtAmenName.Size = New System.Drawing.Size(146, 33)
        Me.txtAmenName.TabIndex = 0
        Me.txtAmenName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label11.Location = New System.Drawing.Point(7, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 17)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Type:"
        '
        'chckEnabledAmen
        '
        Me.chckEnabledAmen.BackColor = System.Drawing.Color.Green
        Me.chckEnabledAmen.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chckEnabledAmen.Checked = True
        Me.chckEnabledAmen.CheckedOnColor = System.Drawing.Color.Green
        Me.chckEnabledAmen.ForeColor = System.Drawing.Color.White
        Me.chckEnabledAmen.Location = New System.Drawing.Point(32, 229)
        Me.chckEnabledAmen.Name = "chckEnabledAmen"
        Me.chckEnabledAmen.Size = New System.Drawing.Size(20, 20)
        Me.chckEnabledAmen.TabIndex = 9
        '
        'txtSearchAmenities
        '
        Me.txtSearchAmenities.BackColor = System.Drawing.Color.Silver
        Me.txtSearchAmenities.BackgroundImage = CType(resources.GetObject("txtSearchAmenities.BackgroundImage"), System.Drawing.Image)
        Me.txtSearchAmenities.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtSearchAmenities.ForeColor = System.Drawing.Color.Black
        Me.txtSearchAmenities.Icon = CType(resources.GetObject("txtSearchAmenities.Icon"), System.Drawing.Image)
        Me.txtSearchAmenities.Location = New System.Drawing.Point(20, 74)
        Me.txtSearchAmenities.Name = "txtSearchAmenities"
        Me.txtSearchAmenities.Size = New System.Drawing.Size(174, 29)
        Me.txtSearchAmenities.TabIndex = 8
        Me.txtSearchAmenities.text = ""
        '
        'DGAmenities
        '
        Me.DGAmenities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGAmenities.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGAmenities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGAmenities.DefaultCellStyle = DataGridViewCellStyle8
        Me.DGAmenities.Location = New System.Drawing.Point(20, 109)
        Me.DGAmenities.Name = "DGAmenities"
        Me.DGAmenities.ReadOnly = True
        Me.DGAmenities.RowHeadersVisible = False
        Me.DGAmenities.RowHeadersWidth = 80
        Me.DGAmenities.Size = New System.Drawing.Size(216, 109)
        Me.DGAmenities.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label8.Location = New System.Drawing.Point(58, 231)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Enable Editing"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel2.Controls.Add(Me.btnGoToRC)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(522, 53)
        Me.Panel2.TabIndex = 0
        '
        'btnGoToRC
        '
        Me.btnGoToRC.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnGoToRC.BackColor = System.Drawing.Color.Transparent
        Me.btnGoToRC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGoToRC.BorderRadius = 0
        Me.btnGoToRC.ButtonText = "< Room Category"
        Me.btnGoToRC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGoToRC.DisabledColor = System.Drawing.Color.Gray
        Me.btnGoToRC.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoToRC.Iconcolor = System.Drawing.Color.Transparent
        Me.btnGoToRC.Iconimage = Nothing
        Me.btnGoToRC.Iconimage_right = Nothing
        Me.btnGoToRC.Iconimage_right_Selected = Nothing
        Me.btnGoToRC.Iconimage_Selected = Nothing
        Me.btnGoToRC.IconMarginLeft = 0
        Me.btnGoToRC.IconMarginRight = 0
        Me.btnGoToRC.IconRightVisible = True
        Me.btnGoToRC.IconRightZoom = 0R
        Me.btnGoToRC.IconVisible = True
        Me.btnGoToRC.IconZoom = 90.0R
        Me.btnGoToRC.IsTab = False
        Me.btnGoToRC.Location = New System.Drawing.Point(363, 13)
        Me.btnGoToRC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGoToRC.Name = "btnGoToRC"
        Me.btnGoToRC.Normalcolor = System.Drawing.Color.Transparent
        Me.btnGoToRC.OnHovercolor = System.Drawing.Color.Transparent
        Me.btnGoToRC.OnHoverTextColor = System.Drawing.Color.DarkRed
        Me.btnGoToRC.selected = False
        Me.btnGoToRC.Size = New System.Drawing.Size(147, 25)
        Me.btnGoToRC.TabIndex = 3
        Me.btnGoToRC.Text = "< Room Category"
        Me.btnGoToRC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGoToRC.Textcolor = System.Drawing.Color.Black
        Me.btnGoToRC.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label7.Location = New System.Drawing.Point(8, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 23)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Amenities"
        '
        'txtAmenFee
        '
        Me.txtAmenFee.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtAmenFee.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAmenFee.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtAmenFee.BorderThickness = 3
        Me.txtAmenFee.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAmenFee.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtAmenFee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAmenFee.isPassword = False
        Me.txtAmenFee.Location = New System.Drawing.Point(78, 74)
        Me.txtAmenFee.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmenFee.Name = "txtAmenFee"
        Me.txtAmenFee.Size = New System.Drawing.Size(146, 33)
        Me.txtAmenFee.TabIndex = 9
        Me.txtAmenFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label9.Location = New System.Drawing.Point(13, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 17)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Fee:"
        '
        'frmRoomCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 476)
        Me.Controls.Add(Me.PanelRoomCategory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmRoomCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Category"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGRoomCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRoomCategory.ResumeLayout(False)
        Me.PanelRoomCategory.PerformLayout()
        Me.PanelAmenities.ResumeLayout(False)
        Me.PanelAmenities.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGAmenities, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtRCServiceCharge As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRCPrice As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRCdescription As RichTextBox
    Friend WithEvents txtRCName As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DGRoomCategory As DataGridView
    Friend WithEvents txtCategoryRoomSearch As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents chckEnableRC As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents PanelRoomCategory As Panel
    Friend WithEvents btnGotoAmenities As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PanelAmenities As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnGoToRC As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label7 As Label
    Friend WithEvents chckEnabledAmen As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents txtSearchAmenities As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents DGAmenities As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAddAmenities As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtAmenName As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label11 As Label
    Friend WithEvents lblAmenID As Label
    Friend WithEvents txtAmenFee As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label9 As Label
End Class
