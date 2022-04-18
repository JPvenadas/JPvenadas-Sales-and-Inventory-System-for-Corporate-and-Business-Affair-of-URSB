<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SUBFRM_adduser
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_create = New MaterialSkin.Controls.MaterialButton()
        Me.CHK_admin = New MaterialSkin.Controls.MaterialCheckbox()
        Me.BTN_clear = New MaterialSkin.Controls.MaterialButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_password = New MaterialSkin.Controls.MaterialTextBox2()
        Me.TXT_cpassword = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTN_back = New MaterialSkin.Controls.MaterialButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TXT_loginName = New MaterialSkin.Controls.MaterialTextBox2()
        Me.TXT_username = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(207, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Add user"
        '
        'BTN_create
        '
        Me.BTN_create.AutoSize = False
        Me.BTN_create.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_create.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_create.Depth = 0
        Me.BTN_create.HighEmphasis = True
        Me.BTN_create.Icon = Nothing
        Me.BTN_create.Location = New System.Drawing.Point(309, 477)
        Me.BTN_create.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_create.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_create.Name = "BTN_create"
        Me.BTN_create.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_create.Size = New System.Drawing.Size(196, 47)
        Me.BTN_create.TabIndex = 4
        Me.BTN_create.Text = "Create User Account"
        Me.BTN_create.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_create.UseAccentColor = False
        Me.BTN_create.UseVisualStyleBackColor = True
        '
        'CHK_admin
        '
        Me.CHK_admin.AutoSize = True
        Me.CHK_admin.Depth = 0
        Me.CHK_admin.Location = New System.Drawing.Point(62, 406)
        Me.CHK_admin.Margin = New System.Windows.Forms.Padding(0)
        Me.CHK_admin.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.CHK_admin.MouseState = MaterialSkin.MouseState.HOVER
        Me.CHK_admin.Name = "CHK_admin"
        Me.CHK_admin.ReadOnly = False
        Me.CHK_admin.Ripple = True
        Me.CHK_admin.Size = New System.Drawing.Size(275, 37)
        Me.CHK_admin.TabIndex = 5
        Me.CHK_admin.Text = "With CBA Head/Admin priviledges"
        Me.CHK_admin.UseVisualStyleBackColor = True
        '
        'BTN_clear
        '
        Me.BTN_clear.AutoSize = False
        Me.BTN_clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_clear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_clear.Depth = 0
        Me.BTN_clear.HighEmphasis = True
        Me.BTN_clear.Icon = Nothing
        Me.BTN_clear.Location = New System.Drawing.Point(231, 477)
        Me.BTN_clear.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_clear.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_clear.Name = "BTN_clear"
        Me.BTN_clear.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_clear.Size = New System.Drawing.Size(70, 47)
        Me.BTN_clear.TabIndex = 4
        Me.BTN_clear.Text = "Clear"
        Me.BTN_clear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.BTN_clear.UseAccentColor = False
        Me.BTN_clear.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(209, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fill in the neccessary fields below"
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
        Me.TXT_password.Location = New System.Drawing.Point(59, 286)
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
        Me.TXT_password.TabIndex = 7
        Me.TXT_password.TabStop = False
        Me.TXT_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_password.TrailingIcon = Nothing
        Me.TXT_password.UseSystemPasswordChar = True
        '
        'TXT_cpassword
        '
        Me.TXT_cpassword.AnimateReadOnly = False
        Me.TXT_cpassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TXT_cpassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXT_cpassword.Depth = 0
        Me.TXT_cpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_cpassword.HideSelection = True
        Me.TXT_cpassword.Hint = "Confirm Password"
        Me.TXT_cpassword.LeadingIcon = Nothing
        Me.TXT_cpassword.Location = New System.Drawing.Point(59, 344)
        Me.TXT_cpassword.MaxLength = 32767
        Me.TXT_cpassword.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_cpassword.Name = "TXT_cpassword"
        Me.TXT_cpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TXT_cpassword.PrefixSuffixText = Nothing
        Me.TXT_cpassword.ReadOnly = False
        Me.TXT_cpassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_cpassword.SelectedText = ""
        Me.TXT_cpassword.SelectionLength = 0
        Me.TXT_cpassword.SelectionStart = 0
        Me.TXT_cpassword.ShortcutsEnabled = True
        Me.TXT_cpassword.Size = New System.Drawing.Size(405, 48)
        Me.TXT_cpassword.TabIndex = 7
        Me.TXT_cpassword.TabStop = False
        Me.TXT_cpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_cpassword.TrailingIcon = Nothing
        Me.TXT_cpassword.UseSystemPasswordChar = True
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
        Me.Panel2.TabIndex = 8
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
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.ITE_5_Project.My.Resources.Resources.user
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(61, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(123, 114)
        Me.Panel1.TabIndex = 0
        '
        'TXT_loginName
        '
        Me.TXT_loginName.AnimateReadOnly = False
        Me.TXT_loginName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TXT_loginName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXT_loginName.Depth = 0
        Me.TXT_loginName.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_loginName.HideSelection = True
        Me.TXT_loginName.Hint = "Login Name"
        Me.TXT_loginName.LeadingIcon = Nothing
        Me.TXT_loginName.Location = New System.Drawing.Point(59, 232)
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
        Me.TXT_loginName.TabIndex = 9
        Me.TXT_loginName.TabStop = False
        Me.TXT_loginName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_loginName.TrailingIcon = Nothing
        Me.TXT_loginName.UseSystemPasswordChar = False
        '
        'TXT_username
        '
        Me.TXT_username.AnimateReadOnly = False
        Me.TXT_username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TXT_username.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXT_username.Depth = 0
        Me.TXT_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_username.HideSelection = True
        Me.TXT_username.Hint = "Username"
        Me.TXT_username.LeadingIcon = Nothing
        Me.TXT_username.Location = New System.Drawing.Point(59, 178)
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
        Me.TXT_username.TabIndex = 9
        Me.TXT_username.TabStop = False
        Me.TXT_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_username.TrailingIcon = Nothing
        Me.TXT_username.UseSystemPasswordChar = False
        '
        'SUBFRM_adduser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(534, 546)
        Me.Controls.Add(Me.TXT_username)
        Me.Controls.Add(Me.TXT_loginName)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TXT_cpassword)
        Me.Controls.Add(Me.TXT_password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CHK_admin)
        Me.Controls.Add(Me.BTN_clear)
        Me.Controls.Add(Me.BTN_create)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SUBFRM_adduser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUBFRM_adduser"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_create As MaterialSkin.Controls.MaterialButton
    Friend WithEvents CHK_admin As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents BTN_clear As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_password As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents TXT_cpassword As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BTN_back As MaterialSkin.Controls.MaterialButton
    Friend WithEvents TXT_loginName As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents TXT_username As MaterialSkin.Controls.MaterialTextBox2
End Class
