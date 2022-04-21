<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_products
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
        Me.BTN_add = New MaterialSkin.Controls.MaterialButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_search = New MaterialSkin.Controls.MaterialButton()
        Me.TXT_filter = New MaterialSkin.Controls.MaterialTextBox2()
        Me.DGV_products = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StocksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblproductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_inventoryDataSet = New ITE_5_Project.db_inventoryDataSet()
        Me.Tbl_productsTableAdapter = New ITE_5_Project.db_inventoryDataSetTableAdapters.tbl_productsTableAdapter()
        CType(Me.DGV_products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblproductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_inventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_add
        '
        Me.BTN_add.AutoSize = False
        Me.BTN_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_add.Depth = 0
        Me.BTN_add.HighEmphasis = True
        Me.BTN_add.Icon = Nothing
        Me.BTN_add.Location = New System.Drawing.Point(24, 58)
        Me.BTN_add.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_add.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_add.Name = "BTN_add"
        Me.BTN_add.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_add.Size = New System.Drawing.Size(136, 48)
        Me.BTN_add.TabIndex = 16
        Me.BTN_add.Text = "+ Add Products"
        Me.BTN_add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_add.UseAccentColor = False
        Me.BTN_add.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(21, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(854, 30)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Manage all the Products that is being sold. You can add new products by clicking " &
    "the add Button or edit existing user Accounts by double clicking the specific " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "record in the table  "
        '
        'BTN_search
        '
        Me.BTN_search.AutoSize = False
        Me.BTN_search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_search.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_search.Depth = 0
        Me.BTN_search.HighEmphasis = True
        Me.BTN_search.Icon = Nothing
        Me.BTN_search.Location = New System.Drawing.Point(848, 56)
        Me.BTN_search.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_search.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_search.Name = "BTN_search"
        Me.BTN_search.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_search.Size = New System.Drawing.Size(128, 48)
        Me.BTN_search.TabIndex = 14
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
        Me.TXT_filter.Hint = "Search a Product here"
        Me.TXT_filter.LeadingIcon = Nothing
        Me.TXT_filter.Location = New System.Drawing.Point(466, 57)
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
        Me.TXT_filter.TabIndex = 13
        Me.TXT_filter.TabStop = False
        Me.TXT_filter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_filter.TrailingIcon = Nothing
        Me.TXT_filter.UseSystemPasswordChar = False
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
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
        Me.DGV_products.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.ProductCategoryDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.StocksDataGridViewTextBoxColumn})
        Me.DGV_products.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_products.DataSource = Me.TblproductsBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_products.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_products.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DGV_products.EnableHeadersVisualStyles = False
        Me.DGV_products.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGV_products.Location = New System.Drawing.Point(24, 124)
        Me.DGV_products.Name = "DGV_products"
        Me.DGV_products.ReadOnly = True
        Me.DGV_products.RowHeadersVisible = False
        Me.DGV_products.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV_products.RowTemplate.Height = 50
        Me.DGV_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_products.Size = New System.Drawing.Size(952, 404)
        Me.DGV_products.TabIndex = 12
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductCategoryDataGridViewTextBoxColumn
        '
        Me.ProductCategoryDataGridViewTextBoxColumn.DataPropertyName = "ProductCategory"
        Me.ProductCategoryDataGridViewTextBoxColumn.HeaderText = "ProductCategory"
        Me.ProductCategoryDataGridViewTextBoxColumn.Name = "ProductCategoryDataGridViewTextBoxColumn"
        Me.ProductCategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StocksDataGridViewTextBoxColumn
        '
        Me.StocksDataGridViewTextBoxColumn.DataPropertyName = "Stocks"
        Me.StocksDataGridViewTextBoxColumn.HeaderText = "Stocks"
        Me.StocksDataGridViewTextBoxColumn.Name = "StocksDataGridViewTextBoxColumn"
        Me.StocksDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblproductsBindingSource
        '
        Me.TblproductsBindingSource.DataMember = "tbl_products"
        Me.TblproductsBindingSource.DataSource = Me.Db_inventoryDataSet
        '
        'Db_inventoryDataSet
        '
        Me.Db_inventoryDataSet.DataSetName = "db_inventoryDataSet"
        Me.Db_inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_productsTableAdapter
        '
        Me.Tbl_productsTableAdapter.ClearBeforeFill = True
        '
        'UC_products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.BTN_add)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_search)
        Me.Controls.Add(Me.TXT_filter)
        Me.Controls.Add(Me.DGV_products)
        Me.Name = "UC_products"
        Me.Size = New System.Drawing.Size(1039, 537)
        CType(Me.DGV_products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblproductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_inventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_add As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_search As MaterialSkin.Controls.MaterialButton
    Friend WithEvents TXT_filter As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents DGV_products As DataGridView
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductCategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StocksDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TblproductsBindingSource As BindingSource
    Friend WithEvents Db_inventoryDataSet As db_inventoryDataSet
    Friend WithEvents Tbl_productsTableAdapter As db_inventoryDataSetTableAdapters.tbl_productsTableAdapter
End Class
