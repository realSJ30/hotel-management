<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSignIn
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsername = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.EllipseForm = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.EllipseButton = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(328, 19)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 505)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(328, 19)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(29, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Get Started"
        '
        'txtUsername
        '
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUsername.HintForeColor = System.Drawing.Color.Empty
        Me.txtUsername.HintText = ""
        Me.txtUsername.isPassword = False
        Me.txtUsername.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtUsername.LineIdleColor = System.Drawing.Color.Black
        Me.txtUsername.LineMouseHoverColor = System.Drawing.Color.SlateGray
        Me.txtUsername.LineThickness = 4
        Me.txtUsername.Location = New System.Drawing.Point(33, 179)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(266, 26)
        Me.txtUsername.TabIndex = 3
        Me.txtUsername.Text = "Username"
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtPassword
        '
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPassword.HintForeColor = System.Drawing.Color.Empty
        Me.txtPassword.HintText = ""
        Me.txtPassword.isPassword = True
        Me.txtPassword.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtPassword.LineIdleColor = System.Drawing.Color.Black
        Me.txtPassword.LineMouseHoverColor = System.Drawing.Color.SlateGray
        Me.txtPassword.LineThickness = 4
        Me.txtPassword.Location = New System.Drawing.Point(33, 234)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(266, 26)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.Text = "Password"
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'EllipseForm
        '
        Me.EllipseForm.ElipseRadius = 10
        Me.EllipseForm.TargetControl = Me
        '
        'btnSignIn
        '
        Me.btnSignIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnSignIn.FlatAppearance.BorderSize = 0
        Me.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignIn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSignIn.Location = New System.Drawing.Point(88, 296)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(153, 29)
        Me.btnSignIn.TabIndex = 5
        Me.btnSignIn.Text = "Sign In"
        Me.btnSignIn.UseVisualStyleBackColor = False
        '
        'EllipseButton
        '
        Me.EllipseButton.ElipseRadius = 10
        Me.EllipseButton.TargetControl = Me.btnSignIn
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BunifuImageButton1.Image = Global.EDP_Project_Hotel_Management_.My.Resources.Resources.shutdown_26px
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(150, 450)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(33, 27)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 6
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'frmSignIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(328, 523)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.btnSignIn)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSignIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSignIn"
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents EllipseForm As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnSignIn As Button
    Friend WithEvents EllipseButton As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
End Class
