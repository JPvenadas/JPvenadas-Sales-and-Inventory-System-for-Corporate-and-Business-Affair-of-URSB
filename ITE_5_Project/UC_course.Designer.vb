<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_course
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBL_operation = New System.Windows.Forms.Label()
        Me.TXT_courseID = New MaterialSkin.Controls.MaterialTextBox2()
        Me.TXT_courseName = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialCard4 = New MaterialSkin.Controls.MaterialCard()
        Me.DGV_courses = New System.Windows.Forms.DataGridView()
        Me.BTN_clear = New MaterialSkin.Controls.MaterialButton()
        Me.BTN_save = New MaterialSkin.Controls.MaterialButton()
        Me.BTN_add = New MaterialSkin.Controls.MaterialButton()
        Me.CBO_college = New MaterialSkin.Controls.MaterialComboBox()
        Me.Db_inventoryDataSet = New ITE_5_Project.db_inventoryDataSet()
        Me.TblcoursesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_coursesTableAdapter = New ITE_5_Project.db_inventoryDataSetTableAdapters.tbl_coursesTableAdapter()
        Me.CourseIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CollegeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialCard1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MaterialCard4.SuspendLayout()
        CType(Me.DGV_courses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_inventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcoursesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.Panel1)
        Me.MaterialCard1.Controls.Add(Me.MaterialCard4)
        Me.MaterialCard1.Controls.Add(Me.BTN_clear)
        Me.MaterialCard1.Controls.Add(Me.BTN_save)
        Me.MaterialCard1.Controls.Add(Me.BTN_add)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(11, 11)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(943, 438)
        Me.MaterialCard1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.CBO_college)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LBL_operation)
        Me.Panel1.Controls.Add(Me.TXT_courseID)
        Me.Panel1.Controls.Add(Me.TXT_courseName)
        Me.Panel1.Location = New System.Drawing.Point(17, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(435, 298)
        Me.Panel1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(29, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fill and supply the neccessary field below"
        '
        'LBL_operation
        '
        Me.LBL_operation.AutoSize = True
        Me.LBL_operation.BackColor = System.Drawing.Color.Transparent
        Me.LBL_operation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_operation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBL_operation.Location = New System.Drawing.Point(29, 24)
        Me.LBL_operation.Name = "LBL_operation"
        Me.LBL_operation.Size = New System.Drawing.Size(118, 20)
        Me.LBL_operation.TabIndex = 2
        Me.LBL_operation.Text = "Add a Course"
        '
        'TXT_courseID
        '
        Me.TXT_courseID.AnimateReadOnly = False
        Me.TXT_courseID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TXT_courseID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXT_courseID.Depth = 0
        Me.TXT_courseID.Enabled = False
        Me.TXT_courseID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_courseID.HideSelection = True
        Me.TXT_courseID.Hint = "Course ID"
        Me.TXT_courseID.LeadingIcon = Nothing
        Me.TXT_courseID.Location = New System.Drawing.Point(22, 89)
        Me.TXT_courseID.MaxLength = 32767
        Me.TXT_courseID.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_courseID.Name = "TXT_courseID"
        Me.TXT_courseID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_courseID.PrefixSuffixText = Nothing
        Me.TXT_courseID.ReadOnly = False
        Me.TXT_courseID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_courseID.SelectedText = ""
        Me.TXT_courseID.SelectionLength = 0
        Me.TXT_courseID.SelectionStart = 0
        Me.TXT_courseID.ShortcutsEnabled = True
        Me.TXT_courseID.Size = New System.Drawing.Size(386, 48)
        Me.TXT_courseID.TabIndex = 17
        Me.TXT_courseID.TabStop = False
        Me.TXT_courseID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_courseID.TrailingIcon = Nothing
        Me.TXT_courseID.UseSystemPasswordChar = False
        '
        'TXT_courseName
        '
        Me.TXT_courseName.AnimateReadOnly = False
        Me.TXT_courseName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TXT_courseName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXT_courseName.Depth = 0
        Me.TXT_courseName.Enabled = False
        Me.TXT_courseName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_courseName.HideSelection = True
        Me.TXT_courseName.Hint = "Course name"
        Me.TXT_courseName.LeadingIcon = Nothing
        Me.TXT_courseName.Location = New System.Drawing.Point(22, 150)
        Me.TXT_courseName.MaxLength = 32767
        Me.TXT_courseName.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_courseName.Name = "TXT_courseName"
        Me.TXT_courseName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_courseName.PrefixSuffixText = Nothing
        Me.TXT_courseName.ReadOnly = False
        Me.TXT_courseName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_courseName.SelectedText = ""
        Me.TXT_courseName.SelectionLength = 0
        Me.TXT_courseName.SelectionStart = 0
        Me.TXT_courseName.ShortcutsEnabled = True
        Me.TXT_courseName.Size = New System.Drawing.Size(386, 48)
        Me.TXT_courseName.TabIndex = 16
        Me.TXT_courseName.TabStop = False
        Me.TXT_courseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_courseName.TrailingIcon = Nothing
        Me.TXT_courseName.UseSystemPasswordChar = False
        '
        'MaterialCard4
        '
        Me.MaterialCard4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard4.Controls.Add(Me.DGV_courses)
        Me.MaterialCard4.Depth = 0
        Me.MaterialCard4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard4.Location = New System.Drawing.Point(465, 21)
        Me.MaterialCard4.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard4.Name = "MaterialCard4"
        Me.MaterialCard4.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard4.Size = New System.Drawing.Size(461, 392)
        Me.MaterialCard4.TabIndex = 15
        '
        'DGV_courses
        '
        Me.DGV_courses.AllowUserToAddRows = False
        Me.DGV_courses.AllowUserToDeleteRows = False
        Me.DGV_courses.AllowUserToResizeColumns = False
        Me.DGV_courses.AllowUserToResizeRows = False
        Me.DGV_courses.AutoGenerateColumns = False
        Me.DGV_courses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_courses.BackgroundColor = System.Drawing.Color.White
        Me.DGV_courses.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_courses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.DGV_courses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_courses.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DGV_courses.ColumnHeadersHeight = 50
        Me.DGV_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_courses.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CourseIDDataGridViewTextBoxColumn, Me.CourseNameDataGridViewTextBoxColumn, Me.CollegeIDDataGridViewTextBoxColumn})
        Me.DGV_courses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_courses.DataSource = Me.TblcoursesBindingSource
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_courses.DefaultCellStyle = DataGridViewCellStyle10
        Me.DGV_courses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_courses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DGV_courses.EnableHeadersVisualStyles = False
        Me.DGV_courses.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGV_courses.Location = New System.Drawing.Point(14, 14)
        Me.DGV_courses.Name = "DGV_courses"
        Me.DGV_courses.ReadOnly = True
        Me.DGV_courses.RowHeadersVisible = False
        Me.DGV_courses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV_courses.RowTemplate.Height = 50
        Me.DGV_courses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_courses.Size = New System.Drawing.Size(433, 364)
        Me.DGV_courses.TabIndex = 13
        '
        'BTN_clear
        '
        Me.BTN_clear.AutoSize = False
        Me.BTN_clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_clear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_clear.Depth = 0
        Me.BTN_clear.Enabled = False
        Me.BTN_clear.HighEmphasis = True
        Me.BTN_clear.Icon = Nothing
        Me.BTN_clear.Location = New System.Drawing.Point(172, 373)
        Me.BTN_clear.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_clear.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_clear.Name = "BTN_clear"
        Me.BTN_clear.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_clear.Size = New System.Drawing.Size(129, 36)
        Me.BTN_clear.TabIndex = 14
        Me.BTN_clear.Text = "Clear"
        Me.BTN_clear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_clear.UseAccentColor = False
        Me.BTN_clear.UseVisualStyleBackColor = True
        '
        'BTN_save
        '
        Me.BTN_save.AutoSize = False
        Me.BTN_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_save.Depth = 0
        Me.BTN_save.Enabled = False
        Me.BTN_save.HighEmphasis = True
        Me.BTN_save.Icon = Nothing
        Me.BTN_save.Location = New System.Drawing.Point(318, 373)
        Me.BTN_save.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_save.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_save.Name = "BTN_save"
        Me.BTN_save.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_save.Size = New System.Drawing.Size(129, 36)
        Me.BTN_save.TabIndex = 14
        Me.BTN_save.Text = "Save"
        Me.BTN_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_save.UseAccentColor = False
        Me.BTN_save.UseVisualStyleBackColor = True
        '
        'BTN_add
        '
        Me.BTN_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_add.Depth = 0
        Me.BTN_add.HighEmphasis = True
        Me.BTN_add.Icon = Nothing
        Me.BTN_add.Location = New System.Drawing.Point(18, 21)
        Me.BTN_add.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_add.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_add.Name = "BTN_add"
        Me.BTN_add.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_add.Size = New System.Drawing.Size(122, 36)
        Me.BTN_add.TabIndex = 14
        Me.BTN_add.Text = "+ Add Course"
        Me.BTN_add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_add.UseAccentColor = False
        Me.BTN_add.UseVisualStyleBackColor = True
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
        Me.CBO_college.Enabled = False
        Me.CBO_college.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.CBO_college.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBO_college.FormattingEnabled = True
        Me.CBO_college.Hint = "College"
        Me.CBO_college.IntegralHeight = False
        Me.CBO_college.ItemHeight = 43
        Me.CBO_college.Location = New System.Drawing.Point(22, 208)
        Me.CBO_college.MaxDropDownItems = 4
        Me.CBO_college.MouseState = MaterialSkin.MouseState.OUT
        Me.CBO_college.Name = "CBO_college"
        Me.CBO_college.Size = New System.Drawing.Size(386, 49)
        Me.CBO_college.StartIndex = 0
        Me.CBO_college.TabIndex = 18
        '
        'Db_inventoryDataSet
        '
        Me.Db_inventoryDataSet.DataSetName = "db_inventoryDataSet"
        Me.Db_inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblcoursesBindingSource
        '
        Me.TblcoursesBindingSource.DataMember = "tbl_courses"
        Me.TblcoursesBindingSource.DataSource = Me.Db_inventoryDataSet
        '
        'Tbl_coursesTableAdapter
        '
        Me.Tbl_coursesTableAdapter.ClearBeforeFill = True
        '
        'CourseIDDataGridViewTextBoxColumn
        '
        Me.CourseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID"
        Me.CourseIDDataGridViewTextBoxColumn.HeaderText = "CourseID"
        Me.CourseIDDataGridViewTextBoxColumn.Name = "CourseIDDataGridViewTextBoxColumn"
        Me.CourseIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CourseNameDataGridViewTextBoxColumn
        '
        Me.CourseNameDataGridViewTextBoxColumn.DataPropertyName = "CourseName"
        Me.CourseNameDataGridViewTextBoxColumn.HeaderText = "CourseName"
        Me.CourseNameDataGridViewTextBoxColumn.Name = "CourseNameDataGridViewTextBoxColumn"
        Me.CourseNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CollegeIDDataGridViewTextBoxColumn
        '
        Me.CollegeIDDataGridViewTextBoxColumn.DataPropertyName = "CollegeID"
        Me.CollegeIDDataGridViewTextBoxColumn.HeaderText = "CollegeID"
        Me.CollegeIDDataGridViewTextBoxColumn.Name = "CollegeIDDataGridViewTextBoxColumn"
        Me.CollegeIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UC_course
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.MaterialCard1)
        Me.Name = "UC_course"
        Me.Size = New System.Drawing.Size(964, 460)
        Me.MaterialCard1.ResumeLayout(False)
        Me.MaterialCard1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MaterialCard4.ResumeLayout(False)
        CType(Me.DGV_courses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_inventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcoursesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CBO_college As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LBL_operation As Label
    Friend WithEvents TXT_courseID As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents TXT_courseName As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialCard4 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents DGV_courses As DataGridView
    Friend WithEvents CourseIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CollegeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TblcoursesBindingSource As BindingSource
    Friend WithEvents Db_inventoryDataSet As db_inventoryDataSet
    Friend WithEvents BTN_clear As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BTN_save As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BTN_add As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Tbl_coursesTableAdapter As db_inventoryDataSetTableAdapters.tbl_coursesTableAdapter
End Class
