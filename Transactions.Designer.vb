<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transactions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transactions))
        Me.Tabb = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DGTransactions = New System.Windows.Forms.DataGridView()
        Me.txtTransSearch = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGAdditionalCharge = New System.Windows.Forms.DataGridView()
        Me.Tabb.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.DGAdditionalCharge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tabb
        '
        Me.Tabb.Controls.Add(Me.TabPage1)
        Me.Tabb.Controls.Add(Me.TabPage2)
        Me.Tabb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tabb.Location = New System.Drawing.Point(27, 126)
        Me.Tabb.Name = "Tabb"
        Me.Tabb.SelectedIndex = 0
        Me.Tabb.Size = New System.Drawing.Size(830, 280)
        Me.Tabb.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.DGTransactions)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(822, 248)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Booking Transactions"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DGAdditionalCharge)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(822, 248)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Additional Charges"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DGTransactions
        '
        Me.DGTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTransactions.Location = New System.Drawing.Point(6, 6)
        Me.DGTransactions.Name = "DGTransactions"
        Me.DGTransactions.ReadOnly = True
        Me.DGTransactions.Size = New System.Drawing.Size(810, 242)
        Me.DGTransactions.TabIndex = 0
        '
        'txtTransSearch
        '
        Me.txtTransSearch.BackColor = System.Drawing.Color.Silver
        Me.txtTransSearch.BackgroundImage = CType(resources.GetObject("txtTransSearch.BackgroundImage"), System.Drawing.Image)
        Me.txtTransSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtTransSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtTransSearch.Icon = CType(resources.GetObject("txtTransSearch.Icon"), System.Drawing.Image)
        Me.txtTransSearch.Location = New System.Drawing.Point(27, 81)
        Me.txtTransSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTransSearch.Name = "txtTransSearch"
        Me.txtTransSearch.Size = New System.Drawing.Size(250, 38)
        Me.txtTransSearch.TabIndex = 1
        Me.txtTransSearch.text = ""
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.Label1)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.SkyBlue
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(883, 72)
        Me.BunifuGradientPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "My Transactions"
        '
        'DGAdditionalCharge
        '
        Me.DGAdditionalCharge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGAdditionalCharge.Location = New System.Drawing.Point(6, 3)
        Me.DGAdditionalCharge.Name = "DGAdditionalCharge"
        Me.DGAdditionalCharge.ReadOnly = True
        Me.DGAdditionalCharge.Size = New System.Drawing.Size(810, 242)
        Me.DGAdditionalCharge.TabIndex = 1
        '
        'Transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(881, 516)
        Me.Controls.Add(Me.Tabb)
        Me.Controls.Add(Me.txtTransSearch)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Name = "Transactions"
        Me.Text = "Transactions"
        Me.Tabb.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DGTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.DGAdditionalCharge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTransSearch As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents Tabb As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DGTransactions As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DGAdditionalCharge As DataGridView
End Class
