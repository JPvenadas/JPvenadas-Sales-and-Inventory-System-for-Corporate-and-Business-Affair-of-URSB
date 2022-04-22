<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SUBFRM_addstocks
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
        Me.Slider = New MaterialSkin.Controls.MaterialSlider()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.TXT_stocksno = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_currentstocks = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DATE_addeddate = New System.Windows.Forms.DateTimePicker()
        Me.BTN_addstock = New MaterialSkin.Controls.MaterialButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LBL_name = New System.Windows.Forms.Label()
        Me.LBL_id = New System.Windows.Forms.Label()
        Me.LBL_category = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.MaterialCard1.SuspendLayout()
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
        'Slider
        '
        Me.Slider.Depth = 0
        Me.Slider.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Slider.Location = New System.Drawing.Point(24, 181)
        Me.Slider.MouseState = MaterialSkin.MouseState.HOVER
        Me.Slider.Name = "Slider"
        Me.Slider.RangeMax = 200
        Me.Slider.ShowValue = False
        Me.Slider.Size = New System.Drawing.Size(417, 40)
        Me.Slider.TabIndex = 10
        Me.Slider.Text = ""
        Me.Slider.Value = 0
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.TXT_stocksno)
        Me.MaterialCard1.Controls.Add(Me.Label5)
        Me.MaterialCard1.Controls.Add(Me.TXT_currentstocks)
        Me.MaterialCard1.Controls.Add(Me.Label4)
        Me.MaterialCard1.Controls.Add(Me.Slider)
        Me.MaterialCard1.Controls.Add(Me.DATE_addeddate)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(40, 225)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(451, 238)
        Me.MaterialCard1.TabIndex = 11
        '
        'TXT_stocksno
        '
        Me.TXT_stocksno.AnimateReadOnly = False
        Me.TXT_stocksno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TXT_stocksno.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXT_stocksno.Depth = 0
        Me.TXT_stocksno.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_stocksno.HelperText = "Non-numeric inputs are not allowed"
        Me.TXT_stocksno.HideSelection = True
        Me.TXT_stocksno.Hint = "Number of Stocks to be added"
        Me.TXT_stocksno.LeadingIcon = Nothing
        Me.TXT_stocksno.Location = New System.Drawing.Point(35, 123)
        Me.TXT_stocksno.MaxLength = 32767
        Me.TXT_stocksno.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_stocksno.Name = "TXT_stocksno"
        Me.TXT_stocksno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_stocksno.PrefixSuffixText = Nothing
        Me.TXT_stocksno.ReadOnly = False
        Me.TXT_stocksno.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_stocksno.SelectedText = ""
        Me.TXT_stocksno.SelectionLength = 0
        Me.TXT_stocksno.SelectionStart = 0
        Me.TXT_stocksno.ShortcutsEnabled = True
        Me.TXT_stocksno.ShowAssistiveText = True
        Me.TXT_stocksno.Size = New System.Drawing.Size(382, 64)
        Me.TXT_stocksno.TabIndex = 17
        Me.TXT_stocksno.TabStop = False
        Me.TXT_stocksno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_stocksno.TrailingIcon = Nothing
        Me.TXT_stocksno.UseSystemPasswordChar = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(362, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Indicate the number of stocks to be added. (change the date if neccessary)"
        '
        'TXT_currentstocks
        '
        Me.TXT_currentstocks.AnimateReadOnly = False
        Me.TXT_currentstocks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TXT_currentstocks.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXT_currentstocks.Depth = 0
        Me.TXT_currentstocks.Enabled = False
        Me.TXT_currentstocks.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_currentstocks.HideSelection = True
        Me.TXT_currentstocks.Hint = "Current Stocks"
        Me.TXT_currentstocks.LeadingIcon = Nothing
        Me.TXT_currentstocks.Location = New System.Drawing.Point(35, 69)
        Me.TXT_currentstocks.MaxLength = 32767
        Me.TXT_currentstocks.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_currentstocks.Name = "TXT_currentstocks"
        Me.TXT_currentstocks.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_currentstocks.PrefixSuffixText = Nothing
        Me.TXT_currentstocks.ReadOnly = True
        Me.TXT_currentstocks.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_currentstocks.SelectedText = ""
        Me.TXT_currentstocks.SelectionLength = 0
        Me.TXT_currentstocks.SelectionStart = 0
        Me.TXT_currentstocks.ShortcutsEnabled = True
        Me.TXT_currentstocks.Size = New System.Drawing.Size(219, 48)
        Me.TXT_currentstocks.TabIndex = 14
        Me.TXT_currentstocks.TabStop = False
        Me.TXT_currentstocks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_currentstocks.TrailingIcon = Nothing
        Me.TXT_currentstocks.UseSystemPasswordChar = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(40, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 21)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Add additional stocks"
        '
        'DATE_addeddate
        '
        Me.DATE_addeddate.Checked = False
        Me.DATE_addeddate.CustomFormat = "yyyy/MM/dd"
        Me.DATE_addeddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DATE_addeddate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DATE_addeddate.Location = New System.Drawing.Point(292, 78)
        Me.DATE_addeddate.Name = "DATE_addeddate"
        Me.DATE_addeddate.Size = New System.Drawing.Size(125, 20)
        Me.DATE_addeddate.TabIndex = 12
        '
        'BTN_addstock
        '
        Me.BTN_addstock.AutoSize = False
        Me.BTN_addstock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_addstock.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_addstock.Depth = 0
        Me.BTN_addstock.HighEmphasis = True
        Me.BTN_addstock.Icon = Nothing
        Me.BTN_addstock.Location = New System.Drawing.Point(312, 483)
        Me.BTN_addstock.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_addstock.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_addstock.Name = "BTN_addstock"
        Me.BTN_addstock.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_addstock.Size = New System.Drawing.Size(176, 42)
        Me.BTN_addstock.TabIndex = 14
        Me.BTN_addstock.Text = "Add Stocks"
        Me.BTN_addstock.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_addstock.UseAccentColor = False
        Me.BTN_addstock.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.ITE_5_Project.My.Resources.Resources.stocks
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(55, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(204, 167)
        Me.Panel1.TabIndex = 15
        '
        'LBL_name
        '
        Me.LBL_name.AutoSize = True
        Me.LBL_name.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.LBL_name.Location = New System.Drawing.Point(271, 111)
        Me.LBL_name.Name = "LBL_name"
        Me.LBL_name.Size = New System.Drawing.Size(121, 21)
        Me.LBL_name.TabIndex = 16
        Me.LBL_name.Text = "Product Name"
        '
        'LBL_id
        '
        Me.LBL_id.AutoSize = True
        Me.LBL_id.Location = New System.Drawing.Point(273, 90)
        Me.LBL_id.Name = "LBL_id"
        Me.LBL_id.Size = New System.Drawing.Size(58, 13)
        Me.LBL_id.TabIndex = 16
        Me.LBL_id.Text = "Product ID"
        '
        'LBL_category
        '
        Me.LBL_category.AutoSize = True
        Me.LBL_category.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_category.Location = New System.Drawing.Point(273, 141)
        Me.LBL_category.Name = "LBL_category"
        Me.LBL_category.Size = New System.Drawing.Size(100, 15)
        Me.LBL_category.TabIndex = 16
        Me.LBL_category.Text = "Product Category"
        '
        'SUBFRM_addstocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(534, 546)
        Me.Controls.Add(Me.LBL_id)
        Me.Controls.Add(Me.LBL_category)
        Me.Controls.Add(Me.LBL_name)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTN_addstock)
        Me.Controls.Add(Me.MaterialCard1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SUBFRM_addstocks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUBFRM_addstocks"
        Me.Panel2.ResumeLayout(False)
        Me.MaterialCard1.ResumeLayout(False)
        Me.MaterialCard1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents BTN_back As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Slider As MaterialSkin.Controls.MaterialSlider
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents DATE_addeddate As DateTimePicker
    Friend WithEvents BTN_addstock As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_currentstocks As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LBL_name As Label
    Friend WithEvents LBL_id As Label
    Friend WithEvents LBL_category As Label
    Friend WithEvents TXT_stocksno As MaterialSkin.Controls.MaterialTextBox2
End Class
