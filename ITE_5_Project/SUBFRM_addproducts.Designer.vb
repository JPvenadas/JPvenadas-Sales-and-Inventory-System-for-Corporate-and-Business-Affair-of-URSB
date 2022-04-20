<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SUBFRM_addproducts
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_productname = New MaterialSkin.Controls.MaterialTextBox2()
        Me.TXT_stocks = New MaterialSkin.Controls.MaterialTextBox2()
        Me.BTN_add = New MaterialSkin.Controls.MaterialButton()
        Me.BTN_clear = New MaterialSkin.Controls.MaterialButton()
        Me.CBO_category = New MaterialSkin.Controls.MaterialComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TXT_price = New MaterialSkin.Controls.MaterialTextBox()
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
        Me.Panel2.TabIndex = 9
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(254, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Fill in the information about the product"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(252, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 29)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Add a Product"
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
        Me.TXT_productname.Location = New System.Drawing.Point(65, 214)
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
        Me.TXT_productname.TabIndex = 13
        Me.TXT_productname.TabStop = False
        Me.TXT_productname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_productname.TrailingIcon = Nothing
        Me.TXT_productname.UseSystemPasswordChar = False
        '
        'TXT_stocks
        '
        Me.TXT_stocks.AnimateReadOnly = False
        Me.TXT_stocks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TXT_stocks.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXT_stocks.Depth = 0
        Me.TXT_stocks.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_stocks.HideSelection = True
        Me.TXT_stocks.Hint = "Stocks"
        Me.TXT_stocks.LeadingIcon = Nothing
        Me.TXT_stocks.Location = New System.Drawing.Point(65, 388)
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
        Me.TXT_stocks.Size = New System.Drawing.Size(378, 48)
        Me.TXT_stocks.TabIndex = 13
        Me.TXT_stocks.TabStop = False
        Me.TXT_stocks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_stocks.TrailingIcon = Nothing
        Me.TXT_stocks.UseSystemPasswordChar = False
        '
        'BTN_add
        '
        Me.BTN_add.AutoSize = False
        Me.BTN_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_add.Depth = 0
        Me.BTN_add.HighEmphasis = True
        Me.BTN_add.Icon = Nothing
        Me.BTN_add.Location = New System.Drawing.Point(359, 475)
        Me.BTN_add.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_add.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_add.Name = "BTN_add"
        Me.BTN_add.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_add.Size = New System.Drawing.Size(126, 45)
        Me.BTN_add.TabIndex = 14
        Me.BTN_add.Text = "Add"
        Me.BTN_add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_add.UseAccentColor = False
        Me.BTN_add.UseVisualStyleBackColor = True
        '
        'BTN_clear
        '
        Me.BTN_clear.AutoSize = False
        Me.BTN_clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_clear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_clear.Depth = 0
        Me.BTN_clear.HighEmphasis = True
        Me.BTN_clear.Icon = Nothing
        Me.BTN_clear.Location = New System.Drawing.Point(261, 475)
        Me.BTN_clear.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_clear.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_clear.Name = "BTN_clear"
        Me.BTN_clear.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_clear.Size = New System.Drawing.Size(94, 45)
        Me.BTN_clear.TabIndex = 14
        Me.BTN_clear.Text = "Clear"
        Me.BTN_clear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.BTN_clear.UseAccentColor = False
        Me.BTN_clear.UseVisualStyleBackColor = True
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
        Me.CBO_category.Location = New System.Drawing.Point(65, 271)
        Me.CBO_category.MaxDropDownItems = 4
        Me.CBO_category.MouseState = MaterialSkin.MouseState.OUT
        Me.CBO_category.Name = "CBO_category"
        Me.CBO_category.Size = New System.Drawing.Size(378, 49)
        Me.CBO_category.StartIndex = 0
        Me.CBO_category.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.ITE_5_Project.My.Resources.Resources.Product
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(32, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(214, 155)
        Me.Panel1.TabIndex = 10
        '
        'TXT_price
        '
        Me.TXT_price.AnimateReadOnly = False
        Me.TXT_price.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_price.Depth = 0
        Me.TXT_price.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_price.Hint = "Price"
        Me.TXT_price.LeadingIcon = Nothing
        Me.TXT_price.Location = New System.Drawing.Point(65, 329)
        Me.TXT_price.MaxLength = 50
        Me.TXT_price.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_price.Multiline = False
        Me.TXT_price.Name = "TXT_price"
        Me.TXT_price.Size = New System.Drawing.Size(378, 50)
        Me.TXT_price.TabIndex = 16
        Me.TXT_price.Text = ""
        Me.TXT_price.TrailingIcon = Global.ITE_5_Project.My.Resources.Resources.Peso
        '
        'SUBFRM_addproducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(534, 546)
        Me.Controls.Add(Me.TXT_price)
        Me.Controls.Add(Me.CBO_category)
        Me.Controls.Add(Me.BTN_clear)
        Me.Controls.Add(Me.BTN_add)
        Me.Controls.Add(Me.TXT_stocks)
        Me.Controls.Add(Me.TXT_productname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SUBFRM_addproducts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SUBFRM_addproducts"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents BTN_back As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_productname As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents TXT_stocks As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents BTN_add As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BTN_clear As MaterialSkin.Controls.MaterialButton
    Friend WithEvents CBO_category As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents TXT_price As MaterialSkin.Controls.MaterialTextBox
End Class
