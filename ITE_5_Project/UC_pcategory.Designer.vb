<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_pcategory
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBL_operation = New System.Windows.Forms.Label()
        Me.TXT_catID = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialCard4 = New MaterialSkin.Controls.MaterialCard()
        Me.DGV_pcategory = New System.Windows.Forms.DataGridView()
        Me.BTN_clear = New MaterialSkin.Controls.MaterialButton()
        Me.BTN_save = New MaterialSkin.Controls.MaterialButton()
        Me.BTN_add = New MaterialSkin.Controls.MaterialButton()
        Me.Db_inventoryDataSet = New ITE_5_Project.db_inventoryDataSet()
        Me.TblcategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_categoriesTableAdapter = New ITE_5_Project.db_inventoryDataSetTableAdapters.tbl_categoriesTableAdapter()
        Me.ProductCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialCard1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MaterialCard4.SuspendLayout()
        CType(Me.DGV_pcategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_inventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LBL_operation)
        Me.Panel1.Controls.Add(Me.TXT_catID)
        Me.Panel1.Location = New System.Drawing.Point(18, 98)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(435, 232)
        Me.Panel1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(19, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fill in the name of the Product Category"
        '
        'LBL_operation
        '
        Me.LBL_operation.AutoSize = True
        Me.LBL_operation.BackColor = System.Drawing.Color.Transparent
        Me.LBL_operation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_operation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBL_operation.Location = New System.Drawing.Point(19, 41)
        Me.LBL_operation.Name = "LBL_operation"
        Me.LBL_operation.Size = New System.Drawing.Size(200, 20)
        Me.LBL_operation.TabIndex = 2
        Me.LBL_operation.Text = "Add a Product Category"
        '
        'TXT_catID
        '
        Me.TXT_catID.AnimateReadOnly = False
        Me.TXT_catID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TXT_catID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXT_catID.Depth = 0
        Me.TXT_catID.Enabled = False
        Me.TXT_catID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_catID.HideSelection = True
        Me.TXT_catID.Hint = "Product Category"
        Me.TXT_catID.LeadingIcon = Nothing
        Me.TXT_catID.Location = New System.Drawing.Point(18, 112)
        Me.TXT_catID.MaxLength = 32767
        Me.TXT_catID.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_catID.Name = "TXT_catID"
        Me.TXT_catID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_catID.PrefixSuffixText = Nothing
        Me.TXT_catID.ReadOnly = False
        Me.TXT_catID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_catID.SelectedText = ""
        Me.TXT_catID.SelectionLength = 0
        Me.TXT_catID.SelectionStart = 0
        Me.TXT_catID.ShortcutsEnabled = True
        Me.TXT_catID.Size = New System.Drawing.Size(386, 48)
        Me.TXT_catID.TabIndex = 17
        Me.TXT_catID.TabStop = False
        Me.TXT_catID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_catID.TrailingIcon = Nothing
        Me.TXT_catID.UseSystemPasswordChar = False
        '
        'MaterialCard4
        '
        Me.MaterialCard4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard4.Controls.Add(Me.DGV_pcategory)
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
        'DGV_pcategory
        '
        Me.DGV_pcategory.AllowUserToAddRows = False
        Me.DGV_pcategory.AllowUserToDeleteRows = False
        Me.DGV_pcategory.AllowUserToResizeColumns = False
        Me.DGV_pcategory.AllowUserToResizeRows = False
        Me.DGV_pcategory.AutoGenerateColumns = False
        Me.DGV_pcategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_pcategory.BackgroundColor = System.Drawing.Color.White
        Me.DGV_pcategory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_pcategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.DGV_pcategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_pcategory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_pcategory.ColumnHeadersHeight = 50
        Me.DGV_pcategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_pcategory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductCategoryDataGridViewTextBoxColumn})
        Me.DGV_pcategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_pcategory.DataSource = Me.TblcategoriesBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_pcategory.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_pcategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_pcategory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DGV_pcategory.EnableHeadersVisualStyles = False
        Me.DGV_pcategory.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGV_pcategory.Location = New System.Drawing.Point(14, 14)
        Me.DGV_pcategory.Name = "DGV_pcategory"
        Me.DGV_pcategory.ReadOnly = True
        Me.DGV_pcategory.RowHeadersVisible = False
        Me.DGV_pcategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV_pcategory.RowTemplate.Height = 50
        Me.DGV_pcategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_pcategory.Size = New System.Drawing.Size(433, 364)
        Me.DGV_pcategory.TabIndex = 13
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
        Me.BTN_add.AutoSize = False
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
        Me.BTN_add.Size = New System.Drawing.Size(223, 36)
        Me.BTN_add.TabIndex = 14
        Me.BTN_add.Text = "+ Add a Product Category"
        Me.BTN_add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_add.UseAccentColor = False
        Me.BTN_add.UseVisualStyleBackColor = True
        '
        'Db_inventoryDataSet
        '
        Me.Db_inventoryDataSet.DataSetName = "db_inventoryDataSet"
        Me.Db_inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'UC_pcategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.MaterialCard1)
        Me.Name = "UC_pcategory"
        Me.Size = New System.Drawing.Size(964, 460)
        Me.MaterialCard1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MaterialCard4.ResumeLayout(False)
        CType(Me.DGV_pcategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_inventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LBL_operation As Label
    Friend WithEvents TXT_catID As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialCard4 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents DGV_pcategory As DataGridView
    Friend WithEvents ProductCategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TblcategoriesBindingSource As BindingSource
    Friend WithEvents Db_inventoryDataSet As db_inventoryDataSet
    Friend WithEvents BTN_clear As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BTN_save As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BTN_add As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Tbl_categoriesTableAdapter As db_inventoryDataSetTableAdapters.tbl_categoriesTableAdapter
End Class
