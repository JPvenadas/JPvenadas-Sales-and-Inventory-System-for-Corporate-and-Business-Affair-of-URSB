<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_stocks
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TAB_addstocks = New System.Windows.Forms.TabPage()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.DGV_products = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StocksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblproductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_inventoryDataSet = New ITE_5_Project.db_inventoryDataSet()
        Me.BTN_search = New MaterialSkin.Controls.MaterialButton()
        Me.TXT_filter = New MaterialSkin.Controls.MaterialTextBox2()
        Me.TAB_stocksrecord = New System.Windows.Forms.TabPage()
        Me.DGV_stocks = New System.Windows.Forms.DataGridView()
        Me.StockIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddedStocksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblstocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_productsTableAdapter = New ITE_5_Project.db_inventoryDataSetTableAdapters.tbl_productsTableAdapter()
        Me.StockID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddedStocks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tbl_stocksTableAdapter = New ITE_5_Project.db_inventoryDataSetTableAdapters.tbl_stocksTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TAB_addstocks.SuspendLayout()
        Me.MaterialCard1.SuspendLayout()
        CType(Me.DGV_products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblproductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_inventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TAB_stocksrecord.SuspendLayout()
        CType(Me.DGV_stocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblstocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(595, 4)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(373, 32)
        Me.MaterialTabSelector1.TabIndex = 0
        Me.MaterialTabSelector1.TabIndicatorHeight = 1
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TAB_addstocks)
        Me.MaterialTabControl1.Controls.Add(Me.TAB_stocksrecord)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(3, 51)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Multiline = True
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(1033, 506)
        Me.MaterialTabControl1.TabIndex = 1
        '
        'TAB_addstocks
        '
        Me.TAB_addstocks.BackColor = System.Drawing.Color.White
        Me.TAB_addstocks.Controls.Add(Me.MaterialCard1)
        Me.TAB_addstocks.Controls.Add(Me.BTN_search)
        Me.TAB_addstocks.Controls.Add(Me.TXT_filter)
        Me.TAB_addstocks.ForeColor = System.Drawing.Color.Black
        Me.TAB_addstocks.Location = New System.Drawing.Point(4, 22)
        Me.TAB_addstocks.Name = "TAB_addstocks"
        Me.TAB_addstocks.Padding = New System.Windows.Forms.Padding(3)
        Me.TAB_addstocks.Size = New System.Drawing.Size(1025, 480)
        Me.TAB_addstocks.TabIndex = 0
        Me.TAB_addstocks.Text = "Add Stocks"
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.DGV_products)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(14, 68)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(959, 412)
        Me.MaterialCard1.TabIndex = 16
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
        Me.DGV_products.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.ProductCategoryDataGridViewTextBoxColumn, Me.StocksDataGridViewTextBoxColumn})
        Me.DGV_products.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_products.DataSource = Me.TblproductsBindingSource
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
        Me.DGV_products.Size = New System.Drawing.Size(931, 384)
        Me.DGV_products.TabIndex = 13
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
        'BTN_search
        '
        Me.BTN_search.AutoSize = False
        Me.BTN_search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_search.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_search.Depth = 0
        Me.BTN_search.HighEmphasis = True
        Me.BTN_search.Icon = Nothing
        Me.BTN_search.Location = New System.Drawing.Point(845, 6)
        Me.BTN_search.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_search.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_search.Name = "BTN_search"
        Me.BTN_search.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_search.Size = New System.Drawing.Size(128, 48)
        Me.BTN_search.TabIndex = 15
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
        Me.TXT_filter.Location = New System.Drawing.Point(288, 6)
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
        Me.TXT_filter.Size = New System.Drawing.Size(550, 48)
        Me.TXT_filter.TabIndex = 14
        Me.TXT_filter.TabStop = False
        Me.TXT_filter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_filter.TrailingIcon = Nothing
        Me.TXT_filter.UseSystemPasswordChar = False
        '
        'TAB_stocksrecord
        '
        Me.TAB_stocksrecord.Controls.Add(Me.DGV_stocks)
        Me.TAB_stocksrecord.Location = New System.Drawing.Point(4, 22)
        Me.TAB_stocksrecord.Name = "TAB_stocksrecord"
        Me.TAB_stocksrecord.Padding = New System.Windows.Forms.Padding(3)
        Me.TAB_stocksrecord.Size = New System.Drawing.Size(1025, 480)
        Me.TAB_stocksrecord.TabIndex = 1
        Me.TAB_stocksrecord.Text = "Stocks Record"
        Me.TAB_stocksrecord.UseVisualStyleBackColor = True
        '
        'DGV_stocks
        '
        Me.DGV_stocks.AllowUserToAddRows = False
        Me.DGV_stocks.AllowUserToDeleteRows = False
        Me.DGV_stocks.AllowUserToResizeColumns = False
        Me.DGV_stocks.AllowUserToResizeRows = False
        Me.DGV_stocks.AutoGenerateColumns = False
        Me.DGV_stocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_stocks.BackgroundColor = System.Drawing.Color.White
        Me.DGV_stocks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_stocks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.DGV_stocks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_stocks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_stocks.ColumnHeadersHeight = 50
        Me.DGV_stocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_stocks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StockIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn1, Me.AddedStocksDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn})
        Me.DGV_stocks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_stocks.DataSource = Me.TblstocksBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_stocks.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_stocks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DGV_stocks.EnableHeadersVisualStyles = False
        Me.DGV_stocks.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGV_stocks.Location = New System.Drawing.Point(16, 18)
        Me.DGV_stocks.Name = "DGV_stocks"
        Me.DGV_stocks.ReadOnly = True
        Me.DGV_stocks.RowHeadersVisible = False
        Me.DGV_stocks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV_stocks.RowTemplate.Height = 50
        Me.DGV_stocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_stocks.Size = New System.Drawing.Size(962, 456)
        Me.DGV_stocks.TabIndex = 14
        '
        'StockIDDataGridViewTextBoxColumn
        '
        Me.StockIDDataGridViewTextBoxColumn.DataPropertyName = "StockID"
        Me.StockIDDataGridViewTextBoxColumn.HeaderText = "StockID"
        Me.StockIDDataGridViewTextBoxColumn.Name = "StockIDDataGridViewTextBoxColumn"
        Me.StockIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductNameDataGridViewTextBoxColumn1
        '
        Me.ProductNameDataGridViewTextBoxColumn1.DataPropertyName = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn1.HeaderText = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn1.Name = "ProductNameDataGridViewTextBoxColumn1"
        Me.ProductNameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'AddedStocksDataGridViewTextBoxColumn
        '
        Me.AddedStocksDataGridViewTextBoxColumn.DataPropertyName = "AddedStocks"
        Me.AddedStocksDataGridViewTextBoxColumn.HeaderText = "AddedStocks"
        Me.AddedStocksDataGridViewTextBoxColumn.Name = "AddedStocksDataGridViewTextBoxColumn"
        Me.AddedStocksDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblstocksBindingSource
        '
        Me.TblstocksBindingSource.DataMember = "tbl_stocks"
        Me.TblstocksBindingSource.DataSource = Me.Db_inventoryDataSet
        '
        'Tbl_productsTableAdapter
        '
        Me.Tbl_productsTableAdapter.ClearBeforeFill = True
        '
        'StockID
        '
        Me.StockID.DataPropertyName = "StockID"
        Me.StockID.HeaderText = "StockID"
        Me.StockID.Name = "StockID"
        '
        'ProductName
        '
        Me.ProductName.DataPropertyName = "ProductName"
        Me.ProductName.HeaderText = "ProductName"
        Me.ProductName.Name = "ProductName"
        '
        'AddedStocks
        '
        Me.AddedStocks.DataPropertyName = "AddedStocks"
        Me.AddedStocks.HeaderText = "AddedStocks"
        Me.AddedStocks.Name = "AddedStocks"
        '
        'Tbl_stocksTableAdapter
        '
        Me.Tbl_stocksTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(19, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(552, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Add and View the Stocks in your system. You can add stocks by double clicking the" &
    " record in the table" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'UC_stocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Name = "UC_stocks"
        Me.Size = New System.Drawing.Size(1039, 537)
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TAB_addstocks.ResumeLayout(False)
        Me.MaterialCard1.ResumeLayout(False)
        CType(Me.DGV_products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblproductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_inventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TAB_stocksrecord.ResumeLayout(False)
        CType(Me.DGV_stocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblstocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TAB_addstocks As TabPage
    Friend WithEvents TAB_stocksrecord As TabPage
    Friend WithEvents DGV_products As DataGridView
    Friend WithEvents TblproductsBindingSource As BindingSource
    Friend WithEvents Db_inventoryDataSet As db_inventoryDataSet
    Friend WithEvents Tbl_productsTableAdapter As db_inventoryDataSetTableAdapters.tbl_productsTableAdapter
    Friend WithEvents DGV_stocks As DataGridView
    Friend WithEvents TblstocksBindingSource As BindingSource
    Friend WithEvents StockID As DataGridViewTextBoxColumn
    Friend WithEvents ProductName As DataGridViewTextBoxColumn
    Friend WithEvents AddedStocks As DataGridViewTextBoxColumn
    Friend WithEvents Tbl_stocksTableAdapter As db_inventoryDataSetTableAdapters.tbl_stocksTableAdapter
    Friend WithEvents BTN_search As MaterialSkin.Controls.MaterialButton
    Friend WithEvents TXT_filter As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Label1 As Label
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductCategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StocksDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AddedStocksDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
End Class
