<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchAccount))
        Me.frmSearchedAccount = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnUpdateAccount = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtUpdatePassword = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtUpdateUsername = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtSearchConfirmPassword = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAccountID = New System.Windows.Forms.Label()
        Me.frmSearchedAccount.SuspendLayout()
        Me.SuspendLayout()
        '
        'frmSearchedAccount
        '
        Me.frmSearchedAccount.BackgroundImage = CType(resources.GetObject("frmSearchedAccount.BackgroundImage"), System.Drawing.Image)
        Me.frmSearchedAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.frmSearchedAccount.Controls.Add(Me.lblAccountID)
        Me.frmSearchedAccount.Controls.Add(Me.txtSearchConfirmPassword)
        Me.frmSearchedAccount.Controls.Add(Me.Label3)
        Me.frmSearchedAccount.Controls.Add(Me.BunifuFlatButton1)
        Me.frmSearchedAccount.Controls.Add(Me.btnUpdateAccount)
        Me.frmSearchedAccount.Controls.Add(Me.txtUpdatePassword)
        Me.frmSearchedAccount.Controls.Add(Me.txtUpdateUsername)
        Me.frmSearchedAccount.Controls.Add(Me.Label2)
        Me.frmSearchedAccount.Controls.Add(Me.Label1)
        Me.frmSearchedAccount.GradientBottomLeft = System.Drawing.Color.SkyBlue
        Me.frmSearchedAccount.GradientBottomRight = System.Drawing.Color.Maroon
        Me.frmSearchedAccount.GradientTopLeft = System.Drawing.Color.White
        Me.frmSearchedAccount.GradientTopRight = System.Drawing.Color.White
        Me.frmSearchedAccount.Location = New System.Drawing.Point(0, 0)
        Me.frmSearchedAccount.Name = "frmSearchedAccount"
        Me.frmSearchedAccount.Quality = 10
        Me.frmSearchedAccount.Size = New System.Drawing.Size(436, 260)
        Me.frmSearchedAccount.TabIndex = 0
        '
        'btnUpdateAccount
        '
        Me.btnUpdateAccount.Activecolor = System.Drawing.Color.Maroon
        Me.btnUpdateAccount.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdateAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdateAccount.BorderRadius = 0
        Me.btnUpdateAccount.ButtonText = "Update"
        Me.btnUpdateAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateAccount.DisabledColor = System.Drawing.Color.Gray
        Me.btnUpdateAccount.Iconcolor = System.Drawing.Color.Transparent
        Me.btnUpdateAccount.Iconimage = Global.EDP_Project_Hotel_Management_.My.Resources.Resources.update
        Me.btnUpdateAccount.Iconimage_right = Nothing
        Me.btnUpdateAccount.Iconimage_right_Selected = Nothing
        Me.btnUpdateAccount.Iconimage_Selected = Nothing
        Me.btnUpdateAccount.IconMarginLeft = 0
        Me.btnUpdateAccount.IconMarginRight = 0
        Me.btnUpdateAccount.IconRightVisible = True
        Me.btnUpdateAccount.IconRightZoom = 0R
        Me.btnUpdateAccount.IconVisible = True
        Me.btnUpdateAccount.IconZoom = 90.0R
        Me.btnUpdateAccount.IsTab = False
        Me.btnUpdateAccount.Location = New System.Drawing.Point(50, 204)
        Me.btnUpdateAccount.Name = "btnUpdateAccount"
        Me.btnUpdateAccount.Normalcolor = System.Drawing.Color.Transparent
        Me.btnUpdateAccount.OnHovercolor = System.Drawing.Color.Maroon
        Me.btnUpdateAccount.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUpdateAccount.selected = False
        Me.btnUpdateAccount.Size = New System.Drawing.Size(138, 39)
        Me.btnUpdateAccount.TabIndex = 4
        Me.btnUpdateAccount.Text = "Update"
        Me.btnUpdateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnUpdateAccount.Textcolor = System.Drawing.Color.Black
        Me.btnUpdateAccount.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtUpdatePassword
        '
        Me.txtUpdatePassword.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtUpdatePassword.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdatePassword.Location = New System.Drawing.Point(149, 85)
        Me.txtUpdatePassword.Name = "txtUpdatePassword"
        Me.txtUpdatePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUpdatePassword.Size = New System.Drawing.Size(189, 22)
        Me.txtUpdatePassword.TabIndex = 3
        '
        'txtUpdateUsername
        '
        Me.txtUpdateUsername.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtUpdateUsername.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateUsername.Location = New System.Drawing.Point(149, 44)
        Me.txtUpdateUsername.Name = "txtUpdateUsername"
        Me.txtUpdateUsername.Size = New System.Drawing.Size(189, 22)
        Me.txtUpdateUsername.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.Maroon
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Cancel"
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
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(248, 204)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.Maroon
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(138, 39)
        Me.BunifuFlatButton1.TabIndex = 5
        Me.BunifuFlatButton1.Text = "Cancel"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtSearchConfirmPassword
        '
        Me.txtSearchConfirmPassword.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtSearchConfirmPassword.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchConfirmPassword.Location = New System.Drawing.Point(149, 129)
        Me.txtSearchConfirmPassword.Name = "txtSearchConfirmPassword"
        Me.txtSearchConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSearchConfirmPassword.Size = New System.Drawing.Size(189, 22)
        Me.txtSearchConfirmPassword.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Confirm:"
        '
        'lblAccountID
        '
        Me.lblAccountID.AutoSize = True
        Me.lblAccountID.BackColor = System.Drawing.Color.Transparent
        Me.lblAccountID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountID.Location = New System.Drawing.Point(41, 9)
        Me.lblAccountID.Name = "lblAccountID"
        Me.lblAccountID.Size = New System.Drawing.Size(24, 19)
        Me.lblAccountID.TabIndex = 8
        Me.lblAccountID.Text = "ID"
        Me.lblAccountID.Visible = False
        '
        'frmSearchAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 260)
        Me.Controls.Add(Me.frmSearchedAccount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSearchAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSearchAccount"
        Me.frmSearchedAccount.ResumeLayout(False)
        Me.frmSearchedAccount.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents frmSearchedAccount As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUpdateAccount As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtUpdatePassword As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtUpdateUsername As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtSearchConfirmPassword As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAccountID As Label
End Class
