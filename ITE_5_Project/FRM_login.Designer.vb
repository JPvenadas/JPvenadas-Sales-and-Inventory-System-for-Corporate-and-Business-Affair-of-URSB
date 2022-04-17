<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_login
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
        Me.TXT_username = New MaterialSkin.Controls.MaterialTextBox()
        Me.BTN_login = New MaterialSkin.Controls.MaterialButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BTN_close = New MaterialSkin.Controls.MaterialButton()
        Me.TXT_password = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXT_username
        '
        Me.TXT_username.AnimateReadOnly = False
        Me.TXT_username.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TXT_username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_username.Depth = 0
        Me.TXT_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_username.Hint = "Username"
        Me.TXT_username.LeadingIcon = Nothing
        Me.TXT_username.Location = New System.Drawing.Point(627, 308)
        Me.TXT_username.MaxLength = 50
        Me.TXT_username.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_username.Multiline = False
        Me.TXT_username.Name = "TXT_username"
        Me.TXT_username.Size = New System.Drawing.Size(354, 50)
        Me.TXT_username.TabIndex = 1
        Me.TXT_username.Text = ""
        Me.TXT_username.TrailingIcon = Nothing
        Me.TXT_username.UseAccent = False
        '
        'BTN_login
        '
        Me.BTN_login.AutoSize = False
        Me.BTN_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_login.Depth = 0
        Me.BTN_login.HighEmphasis = True
        Me.BTN_login.Icon = Nothing
        Me.BTN_login.Location = New System.Drawing.Point(628, 452)
        Me.BTN_login.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_login.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_login.Name = "BTN_login"
        Me.BTN_login.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_login.Size = New System.Drawing.Size(354, 49)
        Me.BTN_login.TabIndex = 3
        Me.BTN_login.Text = "Login"
        Me.BTN_login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_login.UseAccentColor = False
        Me.BTN_login.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft JhengHei UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(619, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 41)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Login"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(630, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Welcome User!"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(633, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(322, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Keep track of what’s in stock with inventory software"
        '
        'BTN_close
        '
        Me.BTN_close.AutoSize = False
        Me.BTN_close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_close.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense
        Me.BTN_close.Depth = 0
        Me.BTN_close.DrawShadows = False
        Me.BTN_close.HighEmphasis = False
        Me.BTN_close.Icon = Nothing
        Me.BTN_close.Location = New System.Drawing.Point(1001, 13)
        Me.BTN_close.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_close.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_close.Name = "BTN_close"
        Me.BTN_close.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_close.Size = New System.Drawing.Size(45, 32)
        Me.BTN_close.TabIndex = 10
        Me.BTN_close.Text = "X"
        Me.BTN_close.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined
        Me.BTN_close.UseAccentColor = False
        Me.BTN_close.UseVisualStyleBackColor = True
        '
        'TXT_password
        '
        Me.TXT_password.AnimateReadOnly = False
        Me.TXT_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TXT_password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXT_password.Depth = 0
        Me.TXT_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_password.HideSelection = True
        Me.TXT_password.Hint = "Password"
        Me.TXT_password.LeadingIcon = Nothing
        Me.TXT_password.Location = New System.Drawing.Point(626, 381)
        Me.TXT_password.MaxLength = 32767
        Me.TXT_password.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_password.Name = "TXT_password"
        Me.TXT_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TXT_password.PrefixSuffixText = Nothing
        Me.TXT_password.ReadOnly = False
        Me.TXT_password.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_password.SelectedText = ""
        Me.TXT_password.SelectionLength = 0
        Me.TXT_password.SelectionStart = 0
        Me.TXT_password.ShortcutsEnabled = True
        Me.TXT_password.Size = New System.Drawing.Size(355, 48)
        Me.TXT_password.TabIndex = 11
        Me.TXT_password.TabStop = False
        Me.TXT_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_password.TrailingIcon = Nothing
        Me.TXT_password.UseAccent = False
        Me.TXT_password.UseSystemPasswordChar = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel2.BackgroundImage = Global.ITE_5_Project.My.Resources.Resources._2a585b3cbbe437f9b0ddc6d020743031
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(552, 661)
        Me.Panel2.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(69, 613)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 14)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Binangonan, Rizal"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft JhengHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(69, 593)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 14)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "University of Rizal System"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.ITE_5_Project.My.Resources.Resources.download_removebg_preview
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(30, 588)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(33, 43)
        Me.Panel1.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft JhengHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(46, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(317, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "for Corporate and Business Affair"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft JhengHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(46, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(266, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Sales and Inventory System "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(42, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(264, 47)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Welcome To..."
        '
        'FRM_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1059, 661)
        Me.Controls.Add(Me.TXT_password)
        Me.Controls.Add(Me.BTN_close)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXT_username)
        Me.Controls.Add(Me.BTN_login)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_username As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents BTN_login As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_close As MaterialSkin.Controls.MaterialButton
    Friend WithEvents TXT_password As MaterialSkin.Controls.MaterialTextBox2
End Class
