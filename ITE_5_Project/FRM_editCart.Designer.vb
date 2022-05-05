<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_editCart
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
        Me.BTN_add = New MaterialSkin.Controls.MaterialButton()
        Me.BTN_clear = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialSlider1 = New MaterialSkin.Controls.MaterialSlider()
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
        'BTN_add
        '
        Me.BTN_add.AutoSize = False
        Me.BTN_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_add.Depth = 0
        Me.BTN_add.HighEmphasis = True
        Me.BTN_add.Icon = Nothing
        Me.BTN_add.Location = New System.Drawing.Point(369, 374)
        Me.BTN_add.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_add.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_add.Name = "BTN_add"
        Me.BTN_add.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_add.Size = New System.Drawing.Size(126, 45)
        Me.BTN_add.TabIndex = 15
        Me.BTN_add.Text = "Save"
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
        Me.BTN_clear.Location = New System.Drawing.Point(271, 374)
        Me.BTN_clear.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_clear.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_clear.Name = "BTN_clear"
        Me.BTN_clear.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_clear.Size = New System.Drawing.Size(94, 45)
        Me.BTN_clear.TabIndex = 16
        Me.BTN_clear.Text = "Remove"
        Me.BTN_clear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.BTN_clear.UseAccentColor = False
        Me.BTN_clear.UseVisualStyleBackColor = True
        '
        'MaterialSlider1
        '
        Me.MaterialSlider1.Depth = 0
        Me.MaterialSlider1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialSlider1.Location = New System.Drawing.Point(47, 285)
        Me.MaterialSlider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSlider1.Name = "MaterialSlider1"
        Me.MaterialSlider1.RangeMax = 50
        Me.MaterialSlider1.ShowValue = False
        Me.MaterialSlider1.Size = New System.Drawing.Size(430, 40)
        Me.MaterialSlider1.TabIndex = 17
        Me.MaterialSlider1.Text = ""
        Me.MaterialSlider1.Value = 0
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.ITE_5_Project.My.Resources.Resources.Product
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(47, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(214, 155)
        Me.Panel1.TabIndex = 18
        '
        'FRM_editCart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(534, 444)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MaterialSlider1)
        Me.Controls.Add(Me.BTN_clear)
        Me.Controls.Add(Me.BTN_add)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_editCart"
        Me.Text = "FRM_editCart"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents BTN_back As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BTN_add As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BTN_clear As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialSlider1 As MaterialSkin.Controls.MaterialSlider
    Friend WithEvents Panel1 As Panel
End Class
