<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookRoom
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateOut = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateIn = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BunifuFlatButton1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DateOut)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DateIn)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(478, 512)
        Me.Panel1.TabIndex = 0
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.LightSlateGray
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuFlatButton1.ButtonText = "SHOW ROOMS"
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
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(177, 197)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.LightSlateGray
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(241, 40)
        Me.BunifuFlatButton1.TabIndex = 12
        Me.BunifuFlatButton1.Text = "SHOW ROOMS"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Check out:"
        '
        'DateOut
        '
        Me.DateOut.BackColor = System.Drawing.Color.DarkRed
        Me.DateOut.BorderRadius = 0
        Me.DateOut.ForeColor = System.Drawing.Color.White
        Me.DateOut.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DateOut.FormatCustom = Nothing
        Me.DateOut.Location = New System.Drawing.Point(154, 108)
        Me.DateOut.Name = "DateOut"
        Me.DateOut.Size = New System.Drawing.Size(303, 36)
        Me.DateOut.TabIndex = 5
        Me.DateOut.Value = New Date(2019, 5, 12, 21, 1, 50, 175)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Check in:"
        '
        'DateIn
        '
        Me.DateIn.BackColor = System.Drawing.Color.DodgerBlue
        Me.DateIn.BorderRadius = 0
        Me.DateIn.ForeColor = System.Drawing.Color.White
        Me.DateIn.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DateIn.FormatCustom = Nothing
        Me.DateIn.Location = New System.Drawing.Point(154, 42)
        Me.DateIn.Name = "DateIn"
        Me.DateIn.Size = New System.Drawing.Size(303, 36)
        Me.DateIn.TabIndex = 1
        Me.DateIn.Value = New Date(2019, 5, 12, 21, 1, 50, 175)
        '
        'BookRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 511)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "BookRoom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BookRoom"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DateIn As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label3 As Label
    Friend WithEvents DateOut As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
End Class
