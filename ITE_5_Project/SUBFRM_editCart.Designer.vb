<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SUBFRM_editCart
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
        Me.BTN_save = New MaterialSkin.Controls.MaterialButton()
        Me.BTN_remove = New MaterialSkin.Controls.MaterialButton()
        Me.SLD_quantity = New MaterialSkin.Controls.MaterialSlider()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LBL_id = New System.Windows.Forms.Label()
        Me.LBL_price = New System.Windows.Forms.Label()
        Me.LBL_name = New System.Windows.Forms.Label()
        Me.MaterialCard6 = New MaterialSkin.Controls.MaterialCard()
        Me.LBL_totalPrice = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialCard7 = New MaterialSkin.Controls.MaterialCard()
        Me.TXT_quantity = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.MaterialCard6.SuspendLayout()
        Me.MaterialCard7.SuspendLayout()
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
        Me.Panel2.Size = New System.Drawing.Size(545, 37)
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
        Me.BTN_back.Location = New System.Drawing.Point(482, 4)
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
        'BTN_save
        '
        Me.BTN_save.AutoSize = False
        Me.BTN_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_save.Depth = 0
        Me.BTN_save.HighEmphasis = True
        Me.BTN_save.Icon = Nothing
        Me.BTN_save.Location = New System.Drawing.Point(306, 381)
        Me.BTN_save.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_save.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_save.Name = "BTN_save"
        Me.BTN_save.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_save.Size = New System.Drawing.Size(190, 45)
        Me.BTN_save.TabIndex = 15
        Me.BTN_save.Text = "Save"
        Me.BTN_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_save.UseAccentColor = False
        Me.BTN_save.UseVisualStyleBackColor = True
        '
        'BTN_remove
        '
        Me.BTN_remove.AutoSize = False
        Me.BTN_remove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_remove.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_remove.Depth = 0
        Me.BTN_remove.HighEmphasis = True
        Me.BTN_remove.Icon = Nothing
        Me.BTN_remove.Location = New System.Drawing.Point(216, 381)
        Me.BTN_remove.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_remove.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_remove.Name = "BTN_remove"
        Me.BTN_remove.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_remove.Size = New System.Drawing.Size(94, 45)
        Me.BTN_remove.TabIndex = 16
        Me.BTN_remove.Text = "Remove"
        Me.BTN_remove.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.BTN_remove.UseAccentColor = False
        Me.BTN_remove.UseVisualStyleBackColor = True
        '
        'SLD_quantity
        '
        Me.SLD_quantity.Depth = 0
        Me.SLD_quantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SLD_quantity.Location = New System.Drawing.Point(47, 249)
        Me.SLD_quantity.MouseState = MaterialSkin.MouseState.HOVER
        Me.SLD_quantity.Name = "SLD_quantity"
        Me.SLD_quantity.RangeMax = 50
        Me.SLD_quantity.ShowValue = False
        Me.SLD_quantity.Size = New System.Drawing.Size(347, 40)
        Me.SLD_quantity.TabIndex = 17
        Me.SLD_quantity.Text = ""
        Me.SLD_quantity.Value = 0
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.ITE_5_Project.My.Resources.Resources.Product
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(32, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(214, 155)
        Me.Panel1.TabIndex = 18
        '
        'LBL_id
        '
        Me.LBL_id.AutoSize = True
        Me.LBL_id.Location = New System.Drawing.Point(252, 113)
        Me.LBL_id.Name = "LBL_id"
        Me.LBL_id.Size = New System.Drawing.Size(58, 13)
        Me.LBL_id.TabIndex = 20
        Me.LBL_id.Text = "Product ID"
        '
        'LBL_price
        '
        Me.LBL_price.AutoSize = True
        Me.LBL_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_price.Location = New System.Drawing.Point(252, 164)
        Me.LBL_price.Name = "LBL_price"
        Me.LBL_price.Size = New System.Drawing.Size(35, 15)
        Me.LBL_price.TabIndex = 21
        Me.LBL_price.Text = "Price"
        '
        'LBL_name
        '
        Me.LBL_name.AutoSize = True
        Me.LBL_name.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.LBL_name.Location = New System.Drawing.Point(250, 134)
        Me.LBL_name.Name = "LBL_name"
        Me.LBL_name.Size = New System.Drawing.Size(121, 21)
        Me.LBL_name.TabIndex = 22
        Me.LBL_name.Text = "Product Name"
        '
        'MaterialCard6
        '
        Me.MaterialCard6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard6.Controls.Add(Me.LBL_totalPrice)
        Me.MaterialCard6.Controls.Add(Me.MaterialLabel5)
        Me.MaterialCard6.Depth = 0
        Me.MaterialCard6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard6.Location = New System.Drawing.Point(47, 306)
        Me.MaterialCard6.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard6.Name = "MaterialCard6"
        Me.MaterialCard6.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard6.Size = New System.Drawing.Size(436, 48)
        Me.MaterialCard6.TabIndex = 36
        '
        'LBL_totalPrice
        '
        Me.LBL_totalPrice.AutoSize = True
        Me.LBL_totalPrice.Depth = 0
        Me.LBL_totalPrice.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.LBL_totalPrice.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.LBL_totalPrice.Location = New System.Drawing.Point(136, 10)
        Me.LBL_totalPrice.MouseState = MaterialSkin.MouseState.HOVER
        Me.LBL_totalPrice.Name = "LBL_totalPrice"
        Me.LBL_totalPrice.Size = New System.Drawing.Size(40, 24)
        Me.LBL_totalPrice.TabIndex = 32
        Me.LBL_totalPrice.Text = "0.00"
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1
        Me.MaterialLabel5.Location = New System.Drawing.Point(20, 13)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(102, 19)
        Me.MaterialLabel5.TabIndex = 32
        Me.MaterialLabel5.Text = "Total Amount:"
        '
        'MaterialCard7
        '
        Me.MaterialCard7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard7.Controls.Add(Me.TXT_quantity)
        Me.MaterialCard7.Depth = 0
        Me.MaterialCard7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard7.Location = New System.Drawing.Point(397, 249)
        Me.MaterialCard7.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard7.Name = "MaterialCard7"
        Me.MaterialCard7.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard7.Size = New System.Drawing.Size(86, 38)
        Me.MaterialCard7.TabIndex = 35
        '
        'TXT_quantity
        '
        Me.TXT_quantity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_quantity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TXT_quantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_quantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXT_quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_quantity.Location = New System.Drawing.Point(14, 14)
        Me.TXT_quantity.Name = "TXT_quantity"
        Me.TXT_quantity.Size = New System.Drawing.Size(58, 17)
        Me.TXT_quantity.TabIndex = 0
        '
        'SUBFRM_editCart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(545, 488)
        Me.Controls.Add(Me.MaterialCard6)
        Me.Controls.Add(Me.MaterialCard7)
        Me.Controls.Add(Me.LBL_id)
        Me.Controls.Add(Me.LBL_price)
        Me.Controls.Add(Me.LBL_name)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SLD_quantity)
        Me.Controls.Add(Me.BTN_remove)
        Me.Controls.Add(Me.BTN_save)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SUBFRM_editCart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_editCart"
        Me.Panel2.ResumeLayout(False)
        Me.MaterialCard6.ResumeLayout(False)
        Me.MaterialCard6.PerformLayout()
        Me.MaterialCard7.ResumeLayout(False)
        Me.MaterialCard7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents BTN_back As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BTN_save As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BTN_remove As MaterialSkin.Controls.MaterialButton
    Friend WithEvents SLD_quantity As MaterialSkin.Controls.MaterialSlider
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LBL_id As Label
    Friend WithEvents LBL_price As Label
    Friend WithEvents LBL_name As Label
    Friend WithEvents MaterialCard6 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents LBL_totalPrice As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard7 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents TXT_quantity As TextBox
End Class
