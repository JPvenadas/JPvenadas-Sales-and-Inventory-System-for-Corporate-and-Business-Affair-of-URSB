<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SUBFRM_edituser
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
        Me.TXT_username = New MaterialSkin.Controls.MaterialTextBox2()
        Me.TXT_loginName = New MaterialSkin.Controls.MaterialTextBox2()
        Me.TXT_password = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CHK_admin = New MaterialSkin.Controls.MaterialCheckbox()
        Me.BTN_changestatus = New MaterialSkin.Controls.MaterialButton()
        Me.BTN_save = New MaterialSkin.Controls.MaterialButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTN_back = New MaterialSkin.Controls.MaterialButton()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXT_username
        '
        Me.TXT_username.AnimateReadOnly = False
        Me.TXT_username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TXT_username.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXT_username.Depth = 0
        Me.TXT_username.Enabled = False
        Me.TXT_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_username.HideSelection = True
        Me.TXT_username.Hint = "Username"
        Me.TXT_username.LeadingIcon = Nothing
        Me.TXT_username.Location = New System.Drawing.Point(46, 200)
        Me.TXT_username.MaxLength = 32767
        Me.TXT_username.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_username.Name = "TXT_username"
        Me.TXT_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_username.PrefixSuffixText = Nothing
        Me.TXT_username.ReadOnly = False
        Me.TXT_username.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_username.SelectedText = ""
        Me.TXT_username.SelectionLength = 0
        Me.TXT_username.SelectionStart = 0
        Me.TXT_username.ShortcutsEnabled = True
        Me.TXT_username.Size = New System.Drawing.Size(405, 48)
        Me.TXT_username.TabIndex = 18
        Me.TXT_username.TabStop = False
        Me.TXT_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_username.TrailingIcon = Nothing
        Me.TXT_username.UseSystemPasswordChar = False
        '
        'TXT_loginName
        '
        Me.TXT_loginName.AnimateReadOnly = False
        Me.TXT_loginName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TXT_loginName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXT_loginName.Depth = 0
        Me.TXT_loginName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_loginName.HideSelection = True
        Me.TXT_loginName.Hint = "Login Name"
        Me.TXT_loginName.LeadingIcon = Nothing
        Me.TXT_loginName.Location = New System.Drawing.Point(46, 256)
        Me.TXT_loginName.MaxLength = 32767
        Me.TXT_loginName.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_loginName.Name = "TXT_loginName"
        Me.TXT_loginName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_loginName.PrefixSuffixText = Nothing
        Me.TXT_loginName.ReadOnly = False
        Me.TXT_loginName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_loginName.SelectedText = ""
        Me.TXT_loginName.SelectionLength = 0
        Me.TXT_loginName.SelectionStart = 0
        Me.TXT_loginName.ShortcutsEnabled = True
        Me.TXT_loginName.Size = New System.Drawing.Size(405, 48)
        Me.TXT_loginName.TabIndex = 19
        Me.TXT_loginName.TabStop = False
        Me.TXT_loginName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_loginName.TrailingIcon = Nothing
        Me.TXT_loginName.UseSystemPasswordChar = False
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
        Me.TXT_password.Location = New System.Drawing.Point(46, 313)
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
        Me.TXT_password.Size = New System.Drawing.Size(405, 48)
        Me.TXT_password.TabIndex = 17
        Me.TXT_password.TabStop = False
        Me.TXT_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_password.TrailingIcon = Nothing
        Me.TXT_password.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "View and Edit the information if neccessary"
        '
        'CHK_admin
        '
        Me.CHK_admin.AutoSize = True
        Me.CHK_admin.Depth = 0
        Me.CHK_admin.Location = New System.Drawing.Point(48, 375)
        Me.CHK_admin.Margin = New System.Windows.Forms.Padding(0)
        Me.CHK_admin.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.CHK_admin.MouseState = MaterialSkin.MouseState.HOVER
        Me.CHK_admin.Name = "CHK_admin"
        Me.CHK_admin.ReadOnly = False
        Me.CHK_admin.Ripple = True
        Me.CHK_admin.Size = New System.Drawing.Size(275, 37)
        Me.CHK_admin.TabIndex = 14
        Me.CHK_admin.Text = "With CBA Head/Admin priviledges"
        Me.CHK_admin.UseVisualStyleBackColor = True
        '
        'BTN_changestatus
        '
        Me.BTN_changestatus.AutoSize = False
        Me.BTN_changestatus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_changestatus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_changestatus.Depth = 0
        Me.BTN_changestatus.HighEmphasis = True
        Me.BTN_changestatus.Icon = Nothing
        Me.BTN_changestatus.Location = New System.Drawing.Point(242, 466)
        Me.BTN_changestatus.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_changestatus.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_changestatus.Name = "BTN_changestatus"
        Me.BTN_changestatus.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_changestatus.Size = New System.Drawing.Size(112, 47)
        Me.BTN_changestatus.TabIndex = 12
        Me.BTN_changestatus.Text = "Deactivate"
        Me.BTN_changestatus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.BTN_changestatus.UseAccentColor = False
        Me.BTN_changestatus.UseVisualStyleBackColor = True
        '
        'BTN_save
        '
        Me.BTN_save.AutoSize = False
        Me.BTN_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_save.Depth = 0
        Me.BTN_save.HighEmphasis = True
        Me.BTN_save.Icon = Nothing
        Me.BTN_save.Location = New System.Drawing.Point(362, 466)
        Me.BTN_save.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_save.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_save.Name = "BTN_save"
        Me.BTN_save.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_save.Size = New System.Drawing.Size(128, 47)
        Me.BTN_save.TabIndex = 13
        Me.BTN_save.Text = "Save"
        Me.BTN_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_save.UseAccentColor = False
        Me.BTN_save.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(194, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 29)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Edit user"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.ITE_5_Project.My.Resources.Resources.user
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(48, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(123, 114)
        Me.Panel1.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BTN_back)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(534, 37)
        Me.Panel2.TabIndex = 20
        '
        'BTN_back
        '
        Me.BTN_back.AutoSize = False
        Me.BTN_back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_back.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_back.Depth = 0
        Me.BTN_back.HighEmphasis = True
        Me.BTN_back.Icon = Nothing
        Me.BTN_back.Location = New System.Drawing.Point(471, 4)
        Me.BTN_back.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_back.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_back.Name = "BTN_back"
        Me.BTN_back.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_back.Size = New System.Drawing.Size(50, 27)
        Me.BTN_back.TabIndex = 9
        Me.BTN_back.Text = "X"
        Me.BTN_back.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_back.UseAccentColor = True
        Me.BTN_back.UseVisualStyleBackColor = True
        '
        'SUBFRM_edituser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 546)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TXT_username)
        Me.Controls.Add(Me.TXT_loginName)
        Me.Controls.Add(Me.TXT_password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CHK_admin)
        Me.Controls.Add(Me.BTN_changestatus)
        Me.Controls.Add(Me.BTN_save)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SUBFRM_edituser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUBFRM_edituser"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_username As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents TXT_loginName As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents TXT_password As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Label2 As Label
    Friend WithEvents CHK_admin As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents BTN_changestatus As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BTN_save As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BTN_back As MaterialSkin.Controls.MaterialButton
End Class
