<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SUBFRM_addstudents
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_back = New MaterialSkin.Controls.MaterialButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CBO_college = New MaterialSkin.Controls.MaterialComboBox()
        Me.CBO_course = New MaterialSkin.Controls.MaterialComboBox()
        Me.BTN_save = New MaterialSkin.Controls.MaterialButton()
        Me.BTN_clear = New MaterialSkin.Controls.MaterialButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_firstname = New MaterialSkin.Controls.MaterialTextBox()
        Me.TXT_midname = New MaterialSkin.Controls.MaterialTextBox()
        Me.TXT_lastname = New MaterialSkin.Controls.MaterialTextBox()
        Me.TXT_address = New MaterialSkin.Controls.MaterialTextBox()
        Me.TXT_contact = New MaterialSkin.Controls.MaterialTextBox()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.BTN_back)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(534, 37)
        Me.Panel2.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Add a Student"
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
        Me.Panel1.BackgroundImage = Global.ITE_5_Project.My.Resources.Resources._85_859280_the_majority_of_students_must_juggle_academic_financial
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(45, 97)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(146, 133)
        Me.Panel1.TabIndex = 10
        '
        'CBO_college
        '
        Me.CBO_college.AutoResize = False
        Me.CBO_college.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBO_college.Depth = 0
        Me.CBO_college.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CBO_college.DropDownHeight = 174
        Me.CBO_college.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_college.DropDownWidth = 121
        Me.CBO_college.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.CBO_college.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBO_college.FormattingEnabled = True
        Me.CBO_college.Hint = "College"
        Me.CBO_college.IntegralHeight = False
        Me.CBO_college.ItemHeight = 43
        Me.CBO_college.Location = New System.Drawing.Point(45, 251)
        Me.CBO_college.MaxDropDownItems = 4
        Me.CBO_college.MouseState = MaterialSkin.MouseState.OUT
        Me.CBO_college.Name = "CBO_college"
        Me.CBO_college.Size = New System.Drawing.Size(429, 49)
        Me.CBO_college.StartIndex = 0
        Me.CBO_college.TabIndex = 4
        '
        'CBO_course
        '
        Me.CBO_course.AutoResize = False
        Me.CBO_course.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBO_course.Depth = 0
        Me.CBO_course.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CBO_course.DropDownHeight = 174
        Me.CBO_course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_course.DropDownWidth = 121
        Me.CBO_course.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.CBO_course.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBO_course.FormattingEnabled = True
        Me.CBO_course.Hint = "Course"
        Me.CBO_course.IntegralHeight = False
        Me.CBO_course.ItemHeight = 43
        Me.CBO_course.Location = New System.Drawing.Point(45, 306)
        Me.CBO_course.MaxDropDownItems = 4
        Me.CBO_course.MouseState = MaterialSkin.MouseState.OUT
        Me.CBO_course.Name = "CBO_course"
        Me.CBO_course.Size = New System.Drawing.Size(429, 49)
        Me.CBO_course.StartIndex = 0
        Me.CBO_course.TabIndex = 5
        '
        'BTN_save
        '
        Me.BTN_save.AutoSize = False
        Me.BTN_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_save.Depth = 0
        Me.BTN_save.HighEmphasis = True
        Me.BTN_save.Icon = Nothing
        Me.BTN_save.Location = New System.Drawing.Point(378, 498)
        Me.BTN_save.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_save.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_save.Name = "BTN_save"
        Me.BTN_save.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_save.Size = New System.Drawing.Size(114, 36)
        Me.BTN_save.TabIndex = 8
        Me.BTN_save.Text = "Register"
        Me.BTN_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_save.UseAccentColor = False
        Me.BTN_save.UseVisualStyleBackColor = True
        '
        'BTN_clear
        '
        Me.BTN_clear.AutoSize = False
        Me.BTN_clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_clear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_clear.Depth = 0
        Me.BTN_clear.HighEmphasis = True
        Me.BTN_clear.Icon = Nothing
        Me.BTN_clear.Location = New System.Drawing.Point(304, 498)
        Me.BTN_clear.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_clear.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_clear.Name = "BTN_clear"
        Me.BTN_clear.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_clear.Size = New System.Drawing.Size(76, 36)
        Me.BTN_clear.TabIndex = 13
        Me.BTN_clear.Text = "Clear"
        Me.BTN_clear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.BTN_clear.UseAccentColor = False
        Me.BTN_clear.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(311, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Fill in the neccessary information below to add a student" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TXT_firstname
        '
        Me.TXT_firstname.AnimateReadOnly = False
        Me.TXT_firstname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_firstname.Depth = 0
        Me.TXT_firstname.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_firstname.Hint = "First Name"
        Me.TXT_firstname.LeadingIcon = Nothing
        Me.TXT_firstname.Location = New System.Drawing.Point(221, 83)
        Me.TXT_firstname.MaxLength = 50
        Me.TXT_firstname.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_firstname.Multiline = False
        Me.TXT_firstname.Name = "TXT_firstname"
        Me.TXT_firstname.Size = New System.Drawing.Size(253, 50)
        Me.TXT_firstname.TabIndex = 1
        Me.TXT_firstname.Text = ""
        Me.TXT_firstname.TrailingIcon = Nothing
        '
        'TXT_midname
        '
        Me.TXT_midname.AnimateReadOnly = False
        Me.TXT_midname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_midname.Depth = 0
        Me.TXT_midname.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_midname.Hint = "Middle Name"
        Me.TXT_midname.LeadingIcon = Nothing
        Me.TXT_midname.Location = New System.Drawing.Point(221, 137)
        Me.TXT_midname.MaxLength = 50
        Me.TXT_midname.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_midname.Multiline = False
        Me.TXT_midname.Name = "TXT_midname"
        Me.TXT_midname.Size = New System.Drawing.Size(253, 50)
        Me.TXT_midname.TabIndex = 2
        Me.TXT_midname.Text = ""
        Me.TXT_midname.TrailingIcon = Nothing
        '
        'TXT_lastname
        '
        Me.TXT_lastname.AnimateReadOnly = False
        Me.TXT_lastname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_lastname.Depth = 0
        Me.TXT_lastname.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_lastname.Hint = "Last Name"
        Me.TXT_lastname.LeadingIcon = Nothing
        Me.TXT_lastname.Location = New System.Drawing.Point(221, 193)
        Me.TXT_lastname.MaxLength = 50
        Me.TXT_lastname.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_lastname.Multiline = False
        Me.TXT_lastname.Name = "TXT_lastname"
        Me.TXT_lastname.Size = New System.Drawing.Size(253, 50)
        Me.TXT_lastname.TabIndex = 3
        Me.TXT_lastname.Text = ""
        Me.TXT_lastname.TrailingIcon = Nothing
        '
        'TXT_address
        '
        Me.TXT_address.AnimateReadOnly = False
        Me.TXT_address.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_address.Depth = 0
        Me.TXT_address.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_address.Hint = "Address"
        Me.TXT_address.LeadingIcon = Nothing
        Me.TXT_address.Location = New System.Drawing.Point(45, 361)
        Me.TXT_address.MaxLength = 50
        Me.TXT_address.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_address.Multiline = False
        Me.TXT_address.Name = "TXT_address"
        Me.TXT_address.Size = New System.Drawing.Size(429, 50)
        Me.TXT_address.TabIndex = 6
        Me.TXT_address.Text = ""
        Me.TXT_address.TrailingIcon = Nothing
        '
        'TXT_contact
        '
        Me.TXT_contact.AnimateReadOnly = False
        Me.TXT_contact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_contact.Depth = 0
        Me.TXT_contact.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_contact.Hint = "Contact Number"
        Me.TXT_contact.LeadingIcon = Nothing
        Me.TXT_contact.Location = New System.Drawing.Point(45, 417)
        Me.TXT_contact.MaxLength = 50
        Me.TXT_contact.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_contact.Multiline = False
        Me.TXT_contact.Name = "TXT_contact"
        Me.TXT_contact.Size = New System.Drawing.Size(429, 50)
        Me.TXT_contact.TabIndex = 7
        Me.TXT_contact.Text = ""
        Me.TXT_contact.TrailingIcon = Nothing
        '
        'SUBFRM_addstudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(534, 558)
        Me.Controls.Add(Me.TXT_contact)
        Me.Controls.Add(Me.TXT_address)
        Me.Controls.Add(Me.TXT_lastname)
        Me.Controls.Add(Me.TXT_midname)
        Me.Controls.Add(Me.TXT_firstname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTN_clear)
        Me.Controls.Add(Me.BTN_save)
        Me.Controls.Add(Me.CBO_course)
        Me.Controls.Add(Me.CBO_college)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SUBFRM_addstudents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUBFRM_addstudents"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents BTN_back As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CBO_college As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents CBO_course As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents BTN_save As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BTN_clear As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_firstname As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents TXT_midname As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents TXT_lastname As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents TXT_address As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents TXT_contact As MaterialSkin.Controls.MaterialTextBox
End Class
