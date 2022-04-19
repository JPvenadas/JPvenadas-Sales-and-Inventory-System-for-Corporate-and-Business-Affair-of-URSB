<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_students
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TblstudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_inventoryDataSet = New ITE_5_Project.db_inventoryDataSet()
        Me.Tbl_studentsTableAdapter = New ITE_5_Project.db_inventoryDataSetTableAdapters.tbl_studentsTableAdapter()
        Me.BTN_add = New MaterialSkin.Controls.MaterialButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_search = New MaterialSkin.Controls.MaterialButton()
        Me.TXT_filter = New MaterialSkin.Controls.MaterialTextBox2()
        Me.DGV_students = New System.Windows.Forms.DataGridView()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddlenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CollegeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TblstudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_inventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_students, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblstudentsBindingSource
        '
        Me.TblstudentsBindingSource.DataMember = "tbl_students"
        Me.TblstudentsBindingSource.DataSource = Me.Db_inventoryDataSet
        '
        'Db_inventoryDataSet
        '
        Me.Db_inventoryDataSet.DataSetName = "db_inventoryDataSet"
        Me.Db_inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_studentsTableAdapter
        '
        Me.Tbl_studentsTableAdapter.ClearBeforeFill = True
        '
        'BTN_add
        '
        Me.BTN_add.AutoSize = False
        Me.BTN_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_add.Depth = 0
        Me.BTN_add.HighEmphasis = True
        Me.BTN_add.Icon = Nothing
        Me.BTN_add.Location = New System.Drawing.Point(22, 51)
        Me.BTN_add.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_add.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_add.Name = "BTN_add"
        Me.BTN_add.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_add.Size = New System.Drawing.Size(136, 48)
        Me.BTN_add.TabIndex = 11
        Me.BTN_add.Text = "+ Add Student"
        Me.BTN_add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_add.UseAccentColor = False
        Me.BTN_add.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(19, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(910, 30)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Manage all the Students that is Registered in the System. You can add new user by" &
    " clicking the add Button or edit existing user Accounts by double clicking the s" &
    "pecific " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "record in the table  "
        '
        'BTN_search
        '
        Me.BTN_search.AutoSize = False
        Me.BTN_search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_search.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_search.Depth = 0
        Me.BTN_search.HighEmphasis = True
        Me.BTN_search.Icon = Nothing
        Me.BTN_search.Location = New System.Drawing.Point(846, 50)
        Me.BTN_search.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_search.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_search.Name = "BTN_search"
        Me.BTN_search.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_search.Size = New System.Drawing.Size(128, 48)
        Me.BTN_search.TabIndex = 9
        Me.BTN_search.Text = "Search"
        Me.BTN_search.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_search.UseAccentColor = False
        Me.BTN_search.UseVisualStyleBackColor = True
        '
        'TXT_filter
        '
        Me.TXT_filter.AnimateReadOnly = False
        Me.TXT_filter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TXT_filter.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXT_filter.Depth = 0
        Me.TXT_filter.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_filter.HideSelection = True
        Me.TXT_filter.Hint = "Search a Student here"
        Me.TXT_filter.LeadingIcon = Nothing
        Me.TXT_filter.Location = New System.Drawing.Point(464, 51)
        Me.TXT_filter.MaxLength = 32767
        Me.TXT_filter.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_filter.Name = "TXT_filter"
        Me.TXT_filter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_filter.PrefixSuffixText = Nothing
        Me.TXT_filter.ReadOnly = False
        Me.TXT_filter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_filter.SelectedText = ""
        Me.TXT_filter.SelectionLength = 0
        Me.TXT_filter.SelectionStart = 0
        Me.TXT_filter.ShortcutsEnabled = True
        Me.TXT_filter.Size = New System.Drawing.Size(369, 48)
        Me.TXT_filter.TabIndex = 8
        Me.TXT_filter.TabStop = False
        Me.TXT_filter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_filter.TrailingIcon = Nothing
        Me.TXT_filter.UseSystemPasswordChar = False
        '
        'DGV_students
        '
        Me.DGV_students.AllowUserToAddRows = False
        Me.DGV_students.AllowUserToDeleteRows = False
        Me.DGV_students.AllowUserToResizeColumns = False
        Me.DGV_students.AllowUserToResizeRows = False
        Me.DGV_students.AutoGenerateColumns = False
        Me.DGV_students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_students.BackgroundColor = System.Drawing.Color.White
        Me.DGV_students.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_students.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.DGV_students.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_students.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_students.ColumnHeadersHeight = 50
        Me.DGV_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_students.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIDDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.MiddlenameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.CollegeDataGridViewTextBoxColumn, Me.CourseDataGridViewTextBoxColumn})
        Me.DGV_students.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_students.DataSource = Me.TblstudentsBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_students.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_students.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DGV_students.EnableHeadersVisualStyles = False
        Me.DGV_students.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGV_students.Location = New System.Drawing.Point(22, 118)
        Me.DGV_students.Name = "DGV_students"
        Me.DGV_students.ReadOnly = True
        Me.DGV_students.RowHeadersVisible = False
        Me.DGV_students.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV_students.RowTemplate.Height = 50
        Me.DGV_students.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_students.Size = New System.Drawing.Size(952, 404)
        Me.DGV_students.TabIndex = 7
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        Me.StudentIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MiddlenameDataGridViewTextBoxColumn
        '
        Me.MiddlenameDataGridViewTextBoxColumn.DataPropertyName = "Middlename"
        Me.MiddlenameDataGridViewTextBoxColumn.HeaderText = "Middlename"
        Me.MiddlenameDataGridViewTextBoxColumn.Name = "MiddlenameDataGridViewTextBoxColumn"
        Me.MiddlenameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "Lastname"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        Me.LastnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CollegeDataGridViewTextBoxColumn
        '
        Me.CollegeDataGridViewTextBoxColumn.DataPropertyName = "College"
        Me.CollegeDataGridViewTextBoxColumn.HeaderText = "College"
        Me.CollegeDataGridViewTextBoxColumn.Name = "CollegeDataGridViewTextBoxColumn"
        Me.CollegeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CourseDataGridViewTextBoxColumn
        '
        Me.CourseDataGridViewTextBoxColumn.DataPropertyName = "Course"
        Me.CourseDataGridViewTextBoxColumn.HeaderText = "Course"
        Me.CourseDataGridViewTextBoxColumn.Name = "CourseDataGridViewTextBoxColumn"
        Me.CourseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UC_students
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.BTN_add)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_search)
        Me.Controls.Add(Me.TXT_filter)
        Me.Controls.Add(Me.DGV_students)
        Me.Name = "UC_students"
        Me.Size = New System.Drawing.Size(1039, 537)
        CType(Me.TblstudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_inventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_students, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TblstudentsBindingSource As BindingSource
    Friend WithEvents Db_inventoryDataSet As db_inventoryDataSet
    Friend WithEvents Tbl_studentsTableAdapter As db_inventoryDataSetTableAdapters.tbl_studentsTableAdapter
    Friend WithEvents BTN_add As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_search As MaterialSkin.Controls.MaterialButton
    Friend WithEvents TXT_filter As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents DGV_students As DataGridView
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddlenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CollegeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
