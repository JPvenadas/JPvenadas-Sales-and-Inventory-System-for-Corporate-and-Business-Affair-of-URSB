<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_settings
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TAB_colleges = New System.Windows.Forms.TabPage()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MaterialTextBox22 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialCard4 = New MaterialSkin.Controls.MaterialCard()
        Me.DGV_products = New System.Windows.Forms.DataGridView()
        Me.CollegeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CollegeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblcollegesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_inventoryDataSet = New ITE_5_Project.db_inventoryDataSet()
        Me.MaterialButton3 = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialButton2 = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        Me.TAB_courses = New System.Windows.Forms.TabPage()
        Me.MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        Me.TAB_categories = New System.Windows.Forms.TabPage()
        Me.MaterialCard3 = New MaterialSkin.Controls.MaterialCard()
        Me.LBL_settings = New System.Windows.Forms.Label()
        Me.Tbl_collegesTableAdapter = New ITE_5_Project.db_inventoryDataSetTableAdapters.tbl_collegesTableAdapter()
        Me.MaterialTextBox21 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.LBL_notif = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MaterialTextBox23 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBox24 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialCard5 = New MaterialSkin.Controls.MaterialCard()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MaterialButton4 = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialButton5 = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialButton6 = New MaterialSkin.Controls.MaterialButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MaterialTextBox25 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBox26 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialCard6 = New MaterialSkin.Controls.MaterialCard()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.MaterialButton7 = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialButton8 = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialButton9 = New MaterialSkin.Controls.MaterialButton()
        Me.TblcoursesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_coursesTableAdapter = New ITE_5_Project.db_inventoryDataSetTableAdapters.tbl_coursesTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CollegeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblcategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_categoriesTableAdapter = New ITE_5_Project.db_inventoryDataSetTableAdapters.tbl_categoriesTableAdapter()
        Me.ProductCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TAB_colleges.SuspendLayout()
        Me.MaterialCard1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MaterialCard4.SuspendLayout()
        CType(Me.DGV_products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcollegesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_inventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TAB_courses.SuspendLayout()
        Me.MaterialCard2.SuspendLayout()
        Me.TAB_categories.SuspendLayout()
        Me.MaterialCard3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MaterialCard5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.MaterialCard6.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcoursesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(13, 45)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(550, 31)
        Me.MaterialTabSelector1.TabIndex = 0
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TAB_colleges)
        Me.MaterialTabControl1.Controls.Add(Me.TAB_courses)
        Me.MaterialTabControl1.Controls.Add(Me.TAB_categories)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(13, 82)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Multiline = True
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(972, 486)
        Me.MaterialTabControl1.TabIndex = 1
        '
        'TAB_colleges
        '
        Me.TAB_colleges.BackColor = System.Drawing.Color.White
        Me.TAB_colleges.Controls.Add(Me.MaterialCard1)
        Me.TAB_colleges.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TAB_colleges.Location = New System.Drawing.Point(4, 22)
        Me.TAB_colleges.Name = "TAB_colleges"
        Me.TAB_colleges.Padding = New System.Windows.Forms.Padding(3)
        Me.TAB_colleges.Size = New System.Drawing.Size(964, 460)
        Me.TAB_colleges.TabIndex = 0
        Me.TAB_colleges.Text = "Colleges"
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.Panel1)
        Me.MaterialCard1.Controls.Add(Me.MaterialCard4)
        Me.MaterialCard1.Controls.Add(Me.MaterialButton3)
        Me.MaterialCard1.Controls.Add(Me.MaterialButton2)
        Me.MaterialCard1.Controls.Add(Me.MaterialButton1)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(10, 8)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(943, 438)
        Me.MaterialCard1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LBL_notif)
        Me.Panel1.Controls.Add(Me.MaterialTextBox21)
        Me.Panel1.Controls.Add(Me.MaterialTextBox22)
        Me.Panel1.Location = New System.Drawing.Point(17, 74)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(435, 290)
        Me.Panel1.TabIndex = 17
        '
        'MaterialTextBox22
        '
        Me.MaterialTextBox22.AnimateReadOnly = False
        Me.MaterialTextBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBox22.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBox22.Depth = 0
        Me.MaterialTextBox22.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBox22.HideSelection = True
        Me.MaterialTextBox22.Hint = "College name"
        Me.MaterialTextBox22.LeadingIcon = Nothing
        Me.MaterialTextBox22.Location = New System.Drawing.Point(22, 174)
        Me.MaterialTextBox22.MaxLength = 32767
        Me.MaterialTextBox22.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBox22.Name = "MaterialTextBox22"
        Me.MaterialTextBox22.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBox22.PrefixSuffixText = Nothing
        Me.MaterialTextBox22.ReadOnly = False
        Me.MaterialTextBox22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBox22.SelectedText = ""
        Me.MaterialTextBox22.SelectionLength = 0
        Me.MaterialTextBox22.SelectionStart = 0
        Me.MaterialTextBox22.ShortcutsEnabled = True
        Me.MaterialTextBox22.Size = New System.Drawing.Size(386, 48)
        Me.MaterialTextBox22.TabIndex = 16
        Me.MaterialTextBox22.TabStop = False
        Me.MaterialTextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBox22.TrailingIcon = Nothing
        Me.MaterialTextBox22.UseSystemPasswordChar = False
        '
        'MaterialCard4
        '
        Me.MaterialCard4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard4.Controls.Add(Me.DGV_products)
        Me.MaterialCard4.Depth = 0
        Me.MaterialCard4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard4.Location = New System.Drawing.Point(465, 17)
        Me.MaterialCard4.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard4.Name = "MaterialCard4"
        Me.MaterialCard4.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard4.Size = New System.Drawing.Size(461, 392)
        Me.MaterialCard4.TabIndex = 15
        '
        'DGV_products
        '
        Me.DGV_products.AllowUserToAddRows = False
        Me.DGV_products.AllowUserToDeleteRows = False
        Me.DGV_products.AllowUserToResizeColumns = False
        Me.DGV_products.AllowUserToResizeRows = False
        Me.DGV_products.AutoGenerateColumns = False
        Me.DGV_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_products.BackgroundColor = System.Drawing.Color.White
        Me.DGV_products.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_products.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.DGV_products.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_products.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_products.ColumnHeadersHeight = 50
        Me.DGV_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_products.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CollegeIDDataGridViewTextBoxColumn, Me.CollegeNameDataGridViewTextBoxColumn})
        Me.DGV_products.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_products.DataSource = Me.TblcollegesBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_products.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_products.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_products.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DGV_products.EnableHeadersVisualStyles = False
        Me.DGV_products.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGV_products.Location = New System.Drawing.Point(14, 14)
        Me.DGV_products.Name = "DGV_products"
        Me.DGV_products.ReadOnly = True
        Me.DGV_products.RowHeadersVisible = False
        Me.DGV_products.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV_products.RowTemplate.Height = 50
        Me.DGV_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_products.Size = New System.Drawing.Size(433, 364)
        Me.DGV_products.TabIndex = 13
        '
        'CollegeIDDataGridViewTextBoxColumn
        '
        Me.CollegeIDDataGridViewTextBoxColumn.DataPropertyName = "CollegeID"
        Me.CollegeIDDataGridViewTextBoxColumn.HeaderText = "CollegeID"
        Me.CollegeIDDataGridViewTextBoxColumn.Name = "CollegeIDDataGridViewTextBoxColumn"
        Me.CollegeIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CollegeNameDataGridViewTextBoxColumn
        '
        Me.CollegeNameDataGridViewTextBoxColumn.DataPropertyName = "CollegeName"
        Me.CollegeNameDataGridViewTextBoxColumn.HeaderText = "CollegeName"
        Me.CollegeNameDataGridViewTextBoxColumn.Name = "CollegeNameDataGridViewTextBoxColumn"
        Me.CollegeNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblcollegesBindingSource
        '
        Me.TblcollegesBindingSource.DataMember = "tbl_colleges"
        Me.TblcollegesBindingSource.DataSource = Me.Db_inventoryDataSet
        '
        'Db_inventoryDataSet
        '
        Me.Db_inventoryDataSet.DataSetName = "db_inventoryDataSet"
        Me.Db_inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MaterialButton3
        '
        Me.MaterialButton3.AutoSize = False
        Me.MaterialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton3.Depth = 0
        Me.MaterialButton3.HighEmphasis = True
        Me.MaterialButton3.Icon = Nothing
        Me.MaterialButton3.Location = New System.Drawing.Point(172, 373)
        Me.MaterialButton3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton3.Name = "MaterialButton3"
        Me.MaterialButton3.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton3.Size = New System.Drawing.Size(129, 36)
        Me.MaterialButton3.TabIndex = 14
        Me.MaterialButton3.Text = "Clear"
        Me.MaterialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton3.UseAccentColor = False
        Me.MaterialButton3.UseVisualStyleBackColor = True
        '
        'MaterialButton2
        '
        Me.MaterialButton2.AutoSize = False
        Me.MaterialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton2.Depth = 0
        Me.MaterialButton2.HighEmphasis = True
        Me.MaterialButton2.Icon = Nothing
        Me.MaterialButton2.Location = New System.Drawing.Point(318, 373)
        Me.MaterialButton2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton2.Name = "MaterialButton2"
        Me.MaterialButton2.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton2.Size = New System.Drawing.Size(129, 36)
        Me.MaterialButton2.TabIndex = 14
        Me.MaterialButton2.Text = "Save"
        Me.MaterialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton2.UseAccentColor = False
        Me.MaterialButton2.UseVisualStyleBackColor = True
        '
        'MaterialButton1
        '
        Me.MaterialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton1.Depth = 0
        Me.MaterialButton1.HighEmphasis = True
        Me.MaterialButton1.Icon = Nothing
        Me.MaterialButton1.Location = New System.Drawing.Point(18, 17)
        Me.MaterialButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton1.Name = "MaterialButton1"
        Me.MaterialButton1.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton1.Size = New System.Drawing.Size(129, 36)
        Me.MaterialButton1.TabIndex = 14
        Me.MaterialButton1.Text = "+ Add College"
        Me.MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton1.UseAccentColor = False
        Me.MaterialButton1.UseVisualStyleBackColor = True
        '
        'TAB_courses
        '
        Me.TAB_courses.BackColor = System.Drawing.Color.White
        Me.TAB_courses.Controls.Add(Me.MaterialCard2)
        Me.TAB_courses.Location = New System.Drawing.Point(4, 22)
        Me.TAB_courses.Name = "TAB_courses"
        Me.TAB_courses.Padding = New System.Windows.Forms.Padding(3)
        Me.TAB_courses.Size = New System.Drawing.Size(964, 460)
        Me.TAB_courses.TabIndex = 1
        Me.TAB_courses.Text = "Courses"
        '
        'MaterialCard2
        '
        Me.MaterialCard2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard2.Controls.Add(Me.Panel2)
        Me.MaterialCard2.Controls.Add(Me.MaterialCard5)
        Me.MaterialCard2.Controls.Add(Me.MaterialButton4)
        Me.MaterialCard2.Controls.Add(Me.MaterialButton5)
        Me.MaterialCard2.Controls.Add(Me.MaterialButton6)
        Me.MaterialCard2.Depth = 0
        Me.MaterialCard2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard2.Location = New System.Drawing.Point(11, 11)
        Me.MaterialCard2.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard2.Name = "MaterialCard2"
        Me.MaterialCard2.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.Size = New System.Drawing.Size(943, 438)
        Me.MaterialCard2.TabIndex = 1
        '
        'TAB_categories
        '
        Me.TAB_categories.BackColor = System.Drawing.Color.White
        Me.TAB_categories.Controls.Add(Me.MaterialCard3)
        Me.TAB_categories.Location = New System.Drawing.Point(4, 22)
        Me.TAB_categories.Name = "TAB_categories"
        Me.TAB_categories.Size = New System.Drawing.Size(964, 460)
        Me.TAB_categories.TabIndex = 2
        Me.TAB_categories.Text = "Product Categories"
        '
        'MaterialCard3
        '
        Me.MaterialCard3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard3.Controls.Add(Me.Panel3)
        Me.MaterialCard3.Controls.Add(Me.MaterialCard6)
        Me.MaterialCard3.Controls.Add(Me.MaterialButton7)
        Me.MaterialCard3.Controls.Add(Me.MaterialButton8)
        Me.MaterialCard3.Controls.Add(Me.MaterialButton9)
        Me.MaterialCard3.Depth = 0
        Me.MaterialCard3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard3.Location = New System.Drawing.Point(11, 11)
        Me.MaterialCard3.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard3.Name = "MaterialCard3"
        Me.MaterialCard3.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard3.Size = New System.Drawing.Size(943, 438)
        Me.MaterialCard3.TabIndex = 1
        '
        'LBL_settings
        '
        Me.LBL_settings.AutoSize = True
        Me.LBL_settings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_settings.Location = New System.Drawing.Point(22, 13)
        Me.LBL_settings.Name = "LBL_settings"
        Me.LBL_settings.Size = New System.Drawing.Size(76, 20)
        Me.LBL_settings.TabIndex = 2
        Me.LBL_settings.Text = "Settings"
        '
        'Tbl_collegesTableAdapter
        '
        Me.Tbl_collegesTableAdapter.ClearBeforeFill = True
        '
        'MaterialTextBox21
        '
        Me.MaterialTextBox21.AnimateReadOnly = False
        Me.MaterialTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBox21.Depth = 0
        Me.MaterialTextBox21.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBox21.HideSelection = True
        Me.MaterialTextBox21.Hint = "College ID"
        Me.MaterialTextBox21.LeadingIcon = Nothing
        Me.MaterialTextBox21.Location = New System.Drawing.Point(22, 112)
        Me.MaterialTextBox21.MaxLength = 32767
        Me.MaterialTextBox21.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBox21.Name = "MaterialTextBox21"
        Me.MaterialTextBox21.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBox21.PrefixSuffixText = Nothing
        Me.MaterialTextBox21.ReadOnly = False
        Me.MaterialTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBox21.SelectedText = ""
        Me.MaterialTextBox21.SelectionLength = 0
        Me.MaterialTextBox21.SelectionStart = 0
        Me.MaterialTextBox21.ShortcutsEnabled = True
        Me.MaterialTextBox21.Size = New System.Drawing.Size(386, 48)
        Me.MaterialTextBox21.TabIndex = 17
        Me.MaterialTextBox21.TabStop = False
        Me.MaterialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBox21.TrailingIcon = Nothing
        Me.MaterialTextBox21.UseSystemPasswordChar = False
        '
        'LBL_notif
        '
        Me.LBL_notif.AutoSize = True
        Me.LBL_notif.BackColor = System.Drawing.Color.Transparent
        Me.LBL_notif.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_notif.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBL_notif.Location = New System.Drawing.Point(29, 24)
        Me.LBL_notif.Name = "LBL_notif"
        Me.LBL_notif.Size = New System.Drawing.Size(121, 20)
        Me.LBL_notif.TabIndex = 2
        Me.LBL_notif.Text = "Add a College"
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.MaterialTextBox23)
        Me.Panel2.Controls.Add(Me.MaterialTextBox24)
        Me.Panel2.Location = New System.Drawing.Point(17, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(435, 290)
        Me.Panel2.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(29, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(255, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fill and supply the neccessary field below"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(29, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Add a College"
        '
        'MaterialTextBox23
        '
        Me.MaterialTextBox23.AnimateReadOnly = False
        Me.MaterialTextBox23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBox23.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBox23.Depth = 0
        Me.MaterialTextBox23.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBox23.HideSelection = True
        Me.MaterialTextBox23.Hint = "College ID"
        Me.MaterialTextBox23.LeadingIcon = Nothing
        Me.MaterialTextBox23.Location = New System.Drawing.Point(22, 112)
        Me.MaterialTextBox23.MaxLength = 32767
        Me.MaterialTextBox23.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBox23.Name = "MaterialTextBox23"
        Me.MaterialTextBox23.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBox23.PrefixSuffixText = Nothing
        Me.MaterialTextBox23.ReadOnly = False
        Me.MaterialTextBox23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBox23.SelectedText = ""
        Me.MaterialTextBox23.SelectionLength = 0
        Me.MaterialTextBox23.SelectionStart = 0
        Me.MaterialTextBox23.ShortcutsEnabled = True
        Me.MaterialTextBox23.Size = New System.Drawing.Size(386, 48)
        Me.MaterialTextBox23.TabIndex = 17
        Me.MaterialTextBox23.TabStop = False
        Me.MaterialTextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBox23.TrailingIcon = Nothing
        Me.MaterialTextBox23.UseSystemPasswordChar = False
        '
        'MaterialTextBox24
        '
        Me.MaterialTextBox24.AnimateReadOnly = False
        Me.MaterialTextBox24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBox24.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBox24.Depth = 0
        Me.MaterialTextBox24.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBox24.HideSelection = True
        Me.MaterialTextBox24.Hint = "College name"
        Me.MaterialTextBox24.LeadingIcon = Nothing
        Me.MaterialTextBox24.Location = New System.Drawing.Point(22, 174)
        Me.MaterialTextBox24.MaxLength = 32767
        Me.MaterialTextBox24.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBox24.Name = "MaterialTextBox24"
        Me.MaterialTextBox24.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBox24.PrefixSuffixText = Nothing
        Me.MaterialTextBox24.ReadOnly = False
        Me.MaterialTextBox24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBox24.SelectedText = ""
        Me.MaterialTextBox24.SelectionLength = 0
        Me.MaterialTextBox24.SelectionStart = 0
        Me.MaterialTextBox24.ShortcutsEnabled = True
        Me.MaterialTextBox24.Size = New System.Drawing.Size(386, 48)
        Me.MaterialTextBox24.TabIndex = 16
        Me.MaterialTextBox24.TabStop = False
        Me.MaterialTextBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBox24.TrailingIcon = Nothing
        Me.MaterialTextBox24.UseSystemPasswordChar = False
        '
        'MaterialCard5
        '
        Me.MaterialCard5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard5.Controls.Add(Me.DataGridView1)
        Me.MaterialCard5.Depth = 0
        Me.MaterialCard5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard5.Location = New System.Drawing.Point(465, 23)
        Me.MaterialCard5.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard5.Name = "MaterialCard5"
        Me.MaterialCard5.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard5.Size = New System.Drawing.Size(461, 392)
        Me.MaterialCard5.TabIndex = 21
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeight = 50
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.CourseName, Me.CollegeID})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.TblcoursesBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.Location = New System.Drawing.Point(14, 14)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridView1.RowTemplate.Height = 50
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(433, 364)
        Me.DataGridView1.TabIndex = 13
        '
        'MaterialButton4
        '
        Me.MaterialButton4.AutoSize = False
        Me.MaterialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton4.Depth = 0
        Me.MaterialButton4.HighEmphasis = True
        Me.MaterialButton4.Icon = Nothing
        Me.MaterialButton4.Location = New System.Drawing.Point(172, 379)
        Me.MaterialButton4.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton4.Name = "MaterialButton4"
        Me.MaterialButton4.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton4.Size = New System.Drawing.Size(129, 36)
        Me.MaterialButton4.TabIndex = 18
        Me.MaterialButton4.Text = "Clear"
        Me.MaterialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton4.UseAccentColor = False
        Me.MaterialButton4.UseVisualStyleBackColor = True
        '
        'MaterialButton5
        '
        Me.MaterialButton5.AutoSize = False
        Me.MaterialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton5.Depth = 0
        Me.MaterialButton5.HighEmphasis = True
        Me.MaterialButton5.Icon = Nothing
        Me.MaterialButton5.Location = New System.Drawing.Point(318, 379)
        Me.MaterialButton5.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton5.Name = "MaterialButton5"
        Me.MaterialButton5.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton5.Size = New System.Drawing.Size(129, 36)
        Me.MaterialButton5.TabIndex = 19
        Me.MaterialButton5.Text = "Save"
        Me.MaterialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton5.UseAccentColor = False
        Me.MaterialButton5.UseVisualStyleBackColor = True
        '
        'MaterialButton6
        '
        Me.MaterialButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton6.Depth = 0
        Me.MaterialButton6.HighEmphasis = True
        Me.MaterialButton6.Icon = Nothing
        Me.MaterialButton6.Location = New System.Drawing.Point(18, 23)
        Me.MaterialButton6.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton6.Name = "MaterialButton6"
        Me.MaterialButton6.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton6.Size = New System.Drawing.Size(129, 36)
        Me.MaterialButton6.TabIndex = 20
        Me.MaterialButton6.Text = "+ Add College"
        Me.MaterialButton6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton6.UseAccentColor = False
        Me.MaterialButton6.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.MaterialTextBox25)
        Me.Panel3.Controls.Add(Me.MaterialTextBox26)
        Me.Panel3.Location = New System.Drawing.Point(17, 80)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(435, 290)
        Me.Panel3.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(29, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(255, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Fill and supply the neccessary field below"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(29, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Add a College"
        '
        'MaterialTextBox25
        '
        Me.MaterialTextBox25.AnimateReadOnly = False
        Me.MaterialTextBox25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBox25.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBox25.Depth = 0
        Me.MaterialTextBox25.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBox25.HideSelection = True
        Me.MaterialTextBox25.Hint = "College ID"
        Me.MaterialTextBox25.LeadingIcon = Nothing
        Me.MaterialTextBox25.Location = New System.Drawing.Point(22, 112)
        Me.MaterialTextBox25.MaxLength = 32767
        Me.MaterialTextBox25.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBox25.Name = "MaterialTextBox25"
        Me.MaterialTextBox25.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBox25.PrefixSuffixText = Nothing
        Me.MaterialTextBox25.ReadOnly = False
        Me.MaterialTextBox25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBox25.SelectedText = ""
        Me.MaterialTextBox25.SelectionLength = 0
        Me.MaterialTextBox25.SelectionStart = 0
        Me.MaterialTextBox25.ShortcutsEnabled = True
        Me.MaterialTextBox25.Size = New System.Drawing.Size(386, 48)
        Me.MaterialTextBox25.TabIndex = 17
        Me.MaterialTextBox25.TabStop = False
        Me.MaterialTextBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBox25.TrailingIcon = Nothing
        Me.MaterialTextBox25.UseSystemPasswordChar = False
        '
        'MaterialTextBox26
        '
        Me.MaterialTextBox26.AnimateReadOnly = False
        Me.MaterialTextBox26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBox26.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBox26.Depth = 0
        Me.MaterialTextBox26.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBox26.HideSelection = True
        Me.MaterialTextBox26.Hint = "College name"
        Me.MaterialTextBox26.LeadingIcon = Nothing
        Me.MaterialTextBox26.Location = New System.Drawing.Point(22, 174)
        Me.MaterialTextBox26.MaxLength = 32767
        Me.MaterialTextBox26.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBox26.Name = "MaterialTextBox26"
        Me.MaterialTextBox26.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBox26.PrefixSuffixText = Nothing
        Me.MaterialTextBox26.ReadOnly = False
        Me.MaterialTextBox26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBox26.SelectedText = ""
        Me.MaterialTextBox26.SelectionLength = 0
        Me.MaterialTextBox26.SelectionStart = 0
        Me.MaterialTextBox26.ShortcutsEnabled = True
        Me.MaterialTextBox26.Size = New System.Drawing.Size(386, 48)
        Me.MaterialTextBox26.TabIndex = 16
        Me.MaterialTextBox26.TabStop = False
        Me.MaterialTextBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBox26.TrailingIcon = Nothing
        Me.MaterialTextBox26.UseSystemPasswordChar = False
        '
        'MaterialCard6
        '
        Me.MaterialCard6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard6.Controls.Add(Me.DataGridView2)
        Me.MaterialCard6.Depth = 0
        Me.MaterialCard6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard6.Location = New System.Drawing.Point(465, 23)
        Me.MaterialCard6.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard6.Name = "MaterialCard6"
        Me.MaterialCard6.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard6.Size = New System.Drawing.Size(461, 392)
        Me.MaterialCard6.TabIndex = 21
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.ColumnHeadersHeight = 50
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductCategoryDataGridViewTextBoxColumn})
        Me.DataGridView2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView2.DataSource = Me.TblcategoriesBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView2.Location = New System.Drawing.Point(14, 14)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataGridView2.RowTemplate.Height = 50
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(433, 364)
        Me.DataGridView2.TabIndex = 13
        '
        'MaterialButton7
        '
        Me.MaterialButton7.AutoSize = False
        Me.MaterialButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton7.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton7.Depth = 0
        Me.MaterialButton7.HighEmphasis = True
        Me.MaterialButton7.Icon = Nothing
        Me.MaterialButton7.Location = New System.Drawing.Point(172, 379)
        Me.MaterialButton7.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton7.Name = "MaterialButton7"
        Me.MaterialButton7.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton7.Size = New System.Drawing.Size(129, 36)
        Me.MaterialButton7.TabIndex = 18
        Me.MaterialButton7.Text = "Clear"
        Me.MaterialButton7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton7.UseAccentColor = False
        Me.MaterialButton7.UseVisualStyleBackColor = True
        '
        'MaterialButton8
        '
        Me.MaterialButton8.AutoSize = False
        Me.MaterialButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton8.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton8.Depth = 0
        Me.MaterialButton8.HighEmphasis = True
        Me.MaterialButton8.Icon = Nothing
        Me.MaterialButton8.Location = New System.Drawing.Point(318, 379)
        Me.MaterialButton8.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton8.Name = "MaterialButton8"
        Me.MaterialButton8.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton8.Size = New System.Drawing.Size(129, 36)
        Me.MaterialButton8.TabIndex = 19
        Me.MaterialButton8.Text = "Save"
        Me.MaterialButton8.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton8.UseAccentColor = False
        Me.MaterialButton8.UseVisualStyleBackColor = True
        '
        'MaterialButton9
        '
        Me.MaterialButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton9.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton9.Depth = 0
        Me.MaterialButton9.HighEmphasis = True
        Me.MaterialButton9.Icon = Nothing
        Me.MaterialButton9.Location = New System.Drawing.Point(18, 23)
        Me.MaterialButton9.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton9.Name = "MaterialButton9"
        Me.MaterialButton9.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton9.Size = New System.Drawing.Size(129, 36)
        Me.MaterialButton9.TabIndex = 20
        Me.MaterialButton9.Text = "+ Add College"
        Me.MaterialButton9.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton9.UseAccentColor = False
        Me.MaterialButton9.UseVisualStyleBackColor = True
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
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CollegeID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CollegeID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CourseName
        '
        Me.CourseName.DataPropertyName = "CourseName"
        Me.CourseName.HeaderText = "CourseName"
        Me.CourseName.Name = "CourseName"
        Me.CourseName.ReadOnly = True
        '
        'CollegeID
        '
        Me.CollegeID.DataPropertyName = "CollegeID"
        Me.CollegeID.HeaderText = "CollegeID"
        Me.CollegeID.Name = "CollegeID"
        Me.CollegeID.ReadOnly = True
        '
        'TblcategoriesBindingSource
        '
        Me.TblcategoriesBindingSource.DataMember = "tbl_categories"
        Me.TblcategoriesBindingSource.DataSource = Me.Db_inventoryDataSet
        '
        'Tbl_categoriesTableAdapter
        '
        Me.Tbl_categoriesTableAdapter.ClearBeforeFill = True
        '
        'ProductCategoryDataGridViewTextBoxColumn
        '
        Me.ProductCategoryDataGridViewTextBoxColumn.DataPropertyName = "ProductCategory"
        Me.ProductCategoryDataGridViewTextBoxColumn.HeaderText = "ProductCategory"
        Me.ProductCategoryDataGridViewTextBoxColumn.Name = "ProductCategoryDataGridViewTextBoxColumn"
        Me.ProductCategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UC_settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.LBL_settings)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Name = "UC_settings"
        Me.Size = New System.Drawing.Size(1039, 581)
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TAB_colleges.ResumeLayout(False)
        Me.MaterialCard1.ResumeLayout(False)
        Me.MaterialCard1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MaterialCard4.ResumeLayout(False)
        CType(Me.DGV_products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcollegesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_inventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TAB_courses.ResumeLayout(False)
        Me.MaterialCard2.ResumeLayout(False)
        Me.MaterialCard2.PerformLayout()
        Me.TAB_categories.ResumeLayout(False)
        Me.MaterialCard3.ResumeLayout(False)
        Me.MaterialCard3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MaterialCard5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.MaterialCard6.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcoursesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TAB_colleges As TabPage
    Friend WithEvents TAB_courses As TabPage
    Friend WithEvents TAB_categories As TabPage
    Friend WithEvents LBL_settings As Label
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard3 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents DGV_products As DataGridView
    Friend WithEvents CollegeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CollegeNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TblcollegesBindingSource As BindingSource
    Friend WithEvents Db_inventoryDataSet As db_inventoryDataSet
    Friend WithEvents Tbl_collegesTableAdapter As db_inventoryDataSetTableAdapters.tbl_collegesTableAdapter
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialButton3 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialButton2 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialCard4 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialTextBox22 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LBL_notif As Label
    Friend WithEvents MaterialTextBox21 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MaterialTextBox23 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBox24 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialCard5 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CourseName As DataGridViewTextBoxColumn
    Friend WithEvents CollegeID As DataGridViewTextBoxColumn
    Friend WithEvents TblcoursesBindingSource As BindingSource
    Friend WithEvents MaterialButton4 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialButton5 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialButton6 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents MaterialTextBox25 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBox26 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialCard6 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ProductCategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TblcategoriesBindingSource As BindingSource
    Friend WithEvents MaterialButton7 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialButton8 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialButton9 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Tbl_coursesTableAdapter As db_inventoryDataSetTableAdapters.tbl_coursesTableAdapter
    Friend WithEvents Tbl_categoriesTableAdapter As db_inventoryDataSetTableAdapters.tbl_categoriesTableAdapter
End Class
