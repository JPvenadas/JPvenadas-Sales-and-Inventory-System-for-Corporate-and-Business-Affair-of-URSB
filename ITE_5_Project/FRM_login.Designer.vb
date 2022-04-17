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
        Me.TXT_password = New MaterialSkin.Controls.MaterialTextBox()
        Me.BTN_login = New MaterialSkin.Controls.MaterialButton()
        Me.SuspendLayout()
        '
        'TXT_username
        '
        Me.TXT_username.AnimateReadOnly = False
        Me.TXT_username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_username.Depth = 0
        Me.TXT_username.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_username.Hint = "Username"
        Me.TXT_username.LeadingIcon = Nothing
        Me.TXT_username.Location = New System.Drawing.Point(94, 131)
        Me.TXT_username.MaxLength = 50
        Me.TXT_username.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_username.Multiline = False
        Me.TXT_username.Name = "TXT_username"
        Me.TXT_username.Size = New System.Drawing.Size(231, 50)
        Me.TXT_username.TabIndex = 1
        Me.TXT_username.Text = ""
        Me.TXT_username.TrailingIcon = Nothing
        Me.TXT_username.UseAccent = False
        '
        'TXT_password
        '
        Me.TXT_password.AnimateReadOnly = False
        Me.TXT_password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_password.Depth = 0
        Me.TXT_password.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_password.Hint = "Password"
        Me.TXT_password.LeadingIcon = Nothing
        Me.TXT_password.Location = New System.Drawing.Point(94, 207)
        Me.TXT_password.MaxLength = 50
        Me.TXT_password.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_password.Multiline = False
        Me.TXT_password.Name = "TXT_password"
        Me.TXT_password.Size = New System.Drawing.Size(231, 50)
        Me.TXT_password.TabIndex = 2
        Me.TXT_password.Text = ""
        Me.TXT_password.TrailingIcon = Nothing
        Me.TXT_password.UseAccent = False
        '
        'BTN_login
        '
        Me.BTN_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_login.Depth = 0
        Me.BTN_login.HighEmphasis = True
        Me.BTN_login.Icon = Nothing
        Me.BTN_login.Location = New System.Drawing.Point(261, 271)
        Me.BTN_login.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_login.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_login.Name = "BTN_login"
        Me.BTN_login.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_login.Size = New System.Drawing.Size(64, 36)
        Me.BTN_login.TabIndex = 3
        Me.BTN_login.Text = "Login"
        Me.BTN_login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_login.UseAccentColor = False
        Me.BTN_login.UseVisualStyleBackColor = True
        '
        'FRM_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTN_login)
        Me.Controls.Add(Me.TXT_password)
        Me.Controls.Add(Me.TXT_username)
        Me.Name = "FRM_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_username As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents TXT_password As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents BTN_login As MaterialSkin.Controls.MaterialButton
End Class
