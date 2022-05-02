<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_college
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBL_operation = New System.Windows.Forms.Label()
        Me.TXT_collegeID = New MaterialSkin.Controls.MaterialTextBox2()
        Me.TXT_collegeName = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialCard4 = New MaterialSkin.Controls.MaterialCard()
        Me.DGV_colleges = New System.Windows.Forms.DataGridView()
        Me.CollegeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CollegeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblcollegesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_inventoryDataSet = New ITE_5_Project.db_inventoryDataSet()
        Me.BTN_clear = New MaterialSkin.Controls.MaterialButton()
        Me.BTN_save = New MaterialSkin.Controls.MaterialButton()
        Me.BTN_add = New MaterialSkin.Controls.MaterialButton()
        Me.Tbl_collegesTableAdapter = New ITE_5_Project.db_inventoryDataSetTableAdapters.tbl_collegesTableAdapter()
        Me.MaterialCard1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MaterialCard4.SuspendLayout()
        CType(Me.DGV_colleges, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcollegesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_inventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MaterialCard1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LBL_operation)
        Me.Panel1.Controls.Add(Me.TXT_collegeID)
        Me.Panel1.Controls.Add(Me.TXT_collegeName)
        Me.Panel1.Location = New System.Drawing.Point(17, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(435, 273)
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
        Me.LBL_operation.Size = New System.Drawing.Size(121, 20)
        Me.LBL_operation.TabIndex = 2
        Me.LBL_operation.Text = "Add a College"
        '
        'TXT_collegeID
        '
        Me.TXT_collegeID.AnimateReadOnly = False
        Me.TXT_collegeID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TXT_collegeID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXT_collegeID.Depth = 0
        Me.TXT_collegeID.Enabled = False
        Me.TXT_collegeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_collegeID.HideSelection = True
        Me.TXT_collegeID.Hint = "College ID"
        Me.TXT_collegeID.LeadingIcon = Nothing
        Me.TXT_collegeID.Location = New System.Drawing.Point(22, 112)
        Me.TXT_collegeID.MaxLength = 32767
        Me.TXT_collegeID.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_collegeID.Name = "TXT_collegeID"
        Me.TXT_collegeID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_collegeID.PrefixSuffixText = Nothing
        Me.TXT_collegeID.ReadOnly = False
        Me.TXT_collegeID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_collegeID.SelectedText = ""
        Me.TXT_collegeID.SelectionLength = 0
        Me.TXT_collegeID.SelectionStart = 0
        Me.TXT_collegeID.ShortcutsEnabled = True
        Me.TXT_collegeID.Size = New System.Drawing.Size(386, 48)
        Me.TXT_collegeID.TabIndex = 17
        Me.TXT_collegeID.TabStop = False
        Me.TXT_collegeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_collegeID.TrailingIcon = Nothing
        Me.TXT_collegeID.UseSystemPasswordChar = False
        '
        'TXT_collegeName
        '
        Me.TXT_collegeName.AnimateReadOnly = False
        Me.TXT_collegeName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TXT_collegeName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXT_collegeName.Depth = 0
        Me.TXT_collegeName.Enabled = False
        Me.TXT_collegeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_collegeName.HideSelection = True
        Me.TXT_collegeName.Hint = "College name"
        Me.TXT_collegeName.LeadingIcon = Nothing
        Me.TXT_collegeName.Location = New System.Drawing.Point(22, 174)
        Me.TXT_collegeName.MaxLength = 32767
        Me.TXT_collegeName.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_collegeName.Name = "TXT_collegeName"
        Me.TXT_collegeName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_collegeName.PrefixSuffixText = Nothing
        Me.TXT_collegeName.ReadOnly = False
        Me.TXT_collegeName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_collegeName.SelectedText = ""
        Me.TXT_collegeName.SelectionLength = 0
        Me.TXT_collegeName.SelectionStart = 0
        Me.TXT_collegeName.ShortcutsEnabled = True
        Me.TXT_collegeName.Size = New System.Drawing.Size(386, 48)
        Me.TXT_collegeName.TabIndex = 16
        Me.TXT_collegeName.TabStop = False
        Me.TXT_collegeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_collegeName.TrailingIcon = Nothing
        Me.TXT_collegeName.UseSystemPasswordChar = False
        '
        'MaterialCard4
        '
        Me.MaterialCard4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard4.Controls.Add(Me.DGV_colleges)
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
        'DGV_colleges
        '
        Me.DGV_colleges.AllowUserToAddRows = False
        Me.DGV_colleges.AllowUserToDeleteRows = False
        Me.DGV_colleges.AllowUserToResizeColumns = False
        Me.DGV_colleges.AllowUserToResizeRows = False
        Me.DGV_colleges.AutoGenerateColumns = False
        Me.DGV_colleges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_colleges.BackgroundColor = System.Drawing.Color.White
        Me.DGV_colleges.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_colleges.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.DGV_colleges.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_colleges.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_colleges.ColumnHeadersHeight = 50
        Me.DGV_colleges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_colleges.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CollegeIDDataGridViewTextBoxColumn, Me.CollegeNameDataGridViewTextBoxColumn})
        Me.DGV_colleges.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_colleges.DataSource = Me.TblcollegesBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_colleges.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_colleges.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_colleges.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DGV_colleges.EnableHeadersVisualStyles = False
        Me.DGV_colleges.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGV_colleges.Location = New System.Drawing.Point(14, 14)
        Me.DGV_colleges.Name = "DGV_colleges"
        Me.DGV_colleges.ReadOnly = True
        Me.DGV_colleges.RowHeadersVisible = False
        Me.DGV_colleges.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV_colleges.RowTemplate.Height = 50
        Me.DGV_colleges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_colleges.Size = New System.Drawing.Size(433, 364)
        Me.DGV_colleges.TabIndex = 13
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
        Me.BTN_add.Size = New System.Drawing.Size(129, 36)
        Me.BTN_add.TabIndex = 14
        Me.BTN_add.Text = "+ Add College"
        Me.BTN_add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_add.UseAccentColor = False
        Me.BTN_add.UseVisualStyleBackColor = True
        '
        'Tbl_collegesTableAdapter
        '
        Me.Tbl_collegesTableAdapter.ClearBeforeFill = True
        '
        'UC_college
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.MaterialCard1)
        Me.Name = "UC_college"
        Me.Size = New System.Drawing.Size(964, 460)
        Me.MaterialCard1.ResumeLayout(False)
        Me.MaterialCard1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MaterialCard4.ResumeLayout(False)
        CType(Me.DGV_colleges, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcollegesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_inventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LBL_operation As Label
    Friend WithEvents TXT_collegeID As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents TXT_collegeName As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialCard4 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents DGV_colleges As DataGridView
    Friend WithEvents BTN_clear As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BTN_save As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BTN_add As MaterialSkin.Controls.MaterialButton
    Friend WithEvents CollegeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CollegeNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TblcollegesBindingSource As BindingSource
    Friend WithEvents Db_inventoryDataSet As db_inventoryDataSet
    Friend WithEvents Tbl_collegesTableAdapter As db_inventoryDataSetTableAdapters.tbl_collegesTableAdapter
End Class
