<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SUBFRM_viewproduct
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTN_back = New MaterialSkin.Controls.MaterialButton()
        Me.TXT_price = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.CBO_category = New MaterialSkin.Controls.MaterialComboBox()
        Me.BTN_revert = New MaterialSkin.Controls.MaterialButton()
        Me.BTN_save = New MaterialSkin.Controls.MaterialButton()
        Me.TXT_stocks = New MaterialSkin.Controls.MaterialTextBox2()
        Me.TXT_productname = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel2.TabIndex = 10
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
        'TXT_price
        '
        Me.TXT_price.AllowPromptAsInput = True
        Me.TXT_price.AnimateReadOnly = False
        Me.TXT_price.AsciiOnly = False
        Me.TXT_price.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TXT_price.BeepOnError = False
        Me.TXT_price.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.TXT_price.Depth = 0
        Me.TXT_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_price.HelperText = "Non-numeric input is not allowed"
        Me.TXT_price.HidePromptOnLeave = False
        Me.TXT_price.HideSelection = True
        Me.TXT_price.Hint = "Price"
        Me.TXT_price.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.TXT_price.LeadingIcon = Nothing
        Me.TXT_price.Location = New System.Drawing.Point(74, 320)
        Me.TXT_price.Mask = ""
        Me.TXT_price.MaxLength = 32767
        Me.TXT_price.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_price.Name = "TXT_price"
        Me.TXT_price.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_price.PrefixSuffixText = Nothing
        Me.TXT_price.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.TXT_price.ReadOnly = False
        Me.TXT_price.RejectInputOnFirstFailure = False
        Me.TXT_price.ResetOnPrompt = True
        Me.TXT_price.ResetOnSpace = True
        Me.TXT_price.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_price.SelectedText = ""
        Me.TXT_price.SelectionLength = 0
        Me.TXT_price.SelectionStart = 0
        Me.TXT_price.ShortcutsEnabled = True
        Me.TXT_price.ShowAssistiveText = True
        Me.TXT_price.Size = New System.Drawing.Size(378, 64)
        Me.TXT_price.SkipLiterals = True
        Me.TXT_price.TabIndex = 16
        Me.TXT_price.TabStop = False
        Me.TXT_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_price.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.TXT_price.TrailingIcon = Global.ITE_5_Project.My.Resources.Resources.Peso
        Me.TXT_price.UseSystemPasswordChar = False
        Me.TXT_price.ValidatingType = Nothing
        '
        'CBO_category
        '
        Me.CBO_category.AutoResize = False
        Me.CBO_category.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBO_category.Depth = 0
        Me.CBO_category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CBO_category.DropDownHeight = 174
        Me.CBO_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_category.DropDownWidth = 121
        Me.CBO_category.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.CBO_category.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBO_category.FormattingEnabled = True
        Me.CBO_category.Hint = "Product Category"
        Me.CBO_category.IntegralHeight = False
        Me.CBO_category.ItemHeight = 43
        Me.CBO_category.Location = New System.Drawing.Point(74, 260)
        Me.CBO_category.MaxDropDownItems = 4
        Me.CBO_category.MouseState = MaterialSkin.MouseState.OUT
        Me.CBO_category.Name = "CBO_category"
        Me.CBO_category.Size = New System.Drawing.Size(378, 49)
        Me.CBO_category.StartIndex = 0
        Me.CBO_category.TabIndex = 24
        '
        'BTN_revert
        '
        Me.BTN_revert.AutoSize = False
        Me.BTN_revert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_revert.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_revert.Depth = 0
        Me.BTN_revert.HighEmphasis = True
        Me.BTN_revert.Icon = Nothing
        Me.BTN_revert.Location = New System.Drawing.Point(270, 470)
        Me.BTN_revert.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_revert.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_revert.Name = "BTN_revert"
        Me.BTN_revert.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_revert.Size = New System.Drawing.Size(94, 45)
        Me.BTN_revert.TabIndex = 22
        Me.BTN_revert.Text = "Revert"
        Me.BTN_revert.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.BTN_revert.UseAccentColor = False
        Me.BTN_revert.UseVisualStyleBackColor = True
        '
        'BTN_save
        '
        Me.BTN_save.AutoSize = False
        Me.BTN_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_save.Depth = 0
        Me.BTN_save.HighEmphasis = True
        Me.BTN_save.Icon = Nothing
        Me.BTN_save.Location = New System.Drawing.Point(368, 470)
        Me.BTN_save.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_save.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_save.Name = "BTN_save"
        Me.BTN_save.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_save.Size = New System.Drawing.Size(126, 45)
        Me.BTN_save.TabIndex = 23
        Me.BTN_save.Text = "Save"
        Me.BTN_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_save.UseAccentColor = False
        Me.BTN_save.UseVisualStyleBackColor = True
        '
        'TXT_stocks
        '
        Me.TXT_stocks.AnimateReadOnly = False
        Me.TXT_stocks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TXT_stocks.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXT_stocks.Depth = 0
        Me.TXT_stocks.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_stocks.HelperText = "Non-numeric input is not allowed"
        Me.TXT_stocks.HideSelection = True
        Me.TXT_stocks.Hint = "Stocks"
        Me.TXT_stocks.LeadingIcon = Nothing
        Me.TXT_stocks.Location = New System.Drawing.Point(74, 383)
        Me.TXT_stocks.MaxLength = 32767
        Me.TXT_stocks.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_stocks.Name = "TXT_stocks"
        Me.TXT_stocks.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_stocks.PrefixSuffixText = Nothing
        Me.TXT_stocks.ReadOnly = False
        Me.TXT_stocks.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_stocks.SelectedText = ""
        Me.TXT_stocks.SelectionLength = 0
        Me.TXT_stocks.SelectionStart = 0
        Me.TXT_stocks.ShortcutsEnabled = True
        Me.TXT_stocks.ShowAssistiveText = True
        Me.TXT_stocks.Size = New System.Drawing.Size(378, 64)
        Me.TXT_stocks.TabIndex = 20
        Me.TXT_stocks.TabStop = False
        Me.TXT_stocks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_stocks.TrailingIcon = Nothing
        Me.TXT_stocks.UseSystemPasswordChar = False
        '
        'TXT_productname
        '
        Me.TXT_productname.AnimateReadOnly = False
        Me.TXT_productname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TXT_productname.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXT_productname.Depth = 0
        Me.TXT_productname.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_productname.HideSelection = True
        Me.TXT_productname.Hint = "Product Name"
        Me.TXT_productname.LeadingIcon = Nothing
        Me.TXT_productname.Location = New System.Drawing.Point(74, 200)
        Me.TXT_productname.MaxLength = 32767
        Me.TXT_productname.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_productname.Name = "TXT_productname"
        Me.TXT_productname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_productname.PrefixSuffixText = Nothing
        Me.TXT_productname.ReadOnly = False
        Me.TXT_productname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_productname.SelectedText = ""
        Me.TXT_productname.SelectionLength = 0
        Me.TXT_productname.SelectionStart = 0
        Me.TXT_productname.ShortcutsEnabled = True
        Me.TXT_productname.Size = New System.Drawing.Size(378, 48)
        Me.TXT_productname.TabIndex = 21
        Me.TXT_productname.TabStop = False
        Me.TXT_productname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_productname.TrailingIcon = Nothing
        Me.TXT_productname.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(263, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "You can view or edit the information below:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(261, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 29)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Edit a Product"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.ITE_5_Project.My.Resources.Resources.Product
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(41, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(214, 155)
        Me.Panel1.TabIndex = 17
        '
        'SUBFRM_viewproduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(534, 546)
        Me.Controls.Add(Me.TXT_price)
        Me.Controls.Add(Me.CBO_category)
        Me.Controls.Add(Me.BTN_revert)
        Me.Controls.Add(Me.BTN_save)
        Me.Controls.Add(Me.TXT_stocks)
        Me.Controls.Add(Me.TXT_productname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SUBFRM_viewproduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUBFRM_viewproduct"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents BTN_back As MaterialSkin.Controls.MaterialButton
    Friend WithEvents TXT_price As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents CBO_category As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents BTN_revert As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BTN_save As MaterialSkin.Controls.MaterialButton
    Friend WithEvents TXT_stocks As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents TXT_productname As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
