<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_transactions
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
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialCard6 = New MaterialSkin.Controls.MaterialCard()
        Me.LBL_totalPrice = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialCard5 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialLabel10 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialCard8 = New MaterialSkin.Controls.MaterialCard()
        Me.TXT_productID = New System.Windows.Forms.TextBox()
        Me.MaterialCard7 = New MaterialSkin.Controls.MaterialCard()
        Me.TXT_productName = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LBL_price = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.SLD_quantity = New MaterialSkin.Controls.MaterialSlider()
        Me.TXT_quantity = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialCard3 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialCard10 = New MaterialSkin.Controls.MaterialCard()
        Me.TXT_studentName = New System.Windows.Forms.TextBox()
        Me.MaterialCard9 = New MaterialSkin.Controls.MaterialCard()
        Me.TXT_studentID = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.BTN_add = New MaterialSkin.Controls.MaterialButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        Me.DGV_cart = New System.Windows.Forms.DataGridView()
        Me.TransactionIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblcartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_inventoryDataSet = New ITE_5_Project.db_inventoryDataSet()
        Me.MaterialCard4 = New MaterialSkin.Controls.MaterialCard()
        Me.BTN_cancel = New MaterialSkin.Controls.MaterialButton()
        Me.BTN_buy = New MaterialSkin.Controls.MaterialButton()
        Me.Tbl_cartTableAdapter = New ITE_5_Project.db_inventoryDataSetTableAdapters.tbl_cartTableAdapter()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialCard1.SuspendLayout()
        Me.MaterialCard6.SuspendLayout()
        Me.MaterialCard5.SuspendLayout()
        Me.MaterialCard8.SuspendLayout()
        Me.MaterialCard7.SuspendLayout()
        Me.MaterialCard3.SuspendLayout()
        Me.MaterialCard10.SuspendLayout()
        Me.MaterialCard9.SuspendLayout()
        Me.MaterialCard2.SuspendLayout()
        CType(Me.DGV_cart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_inventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialCard4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.MaterialCard6)
        Me.MaterialCard1.Controls.Add(Me.MaterialCard5)
        Me.MaterialCard1.Controls.Add(Me.MaterialCard3)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel1)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel2)
        Me.MaterialCard1.Controls.Add(Me.BTN_add)
        Me.MaterialCard1.Controls.Add(Me.Panel1)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(14, 29)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(491, 512)
        Me.MaterialCard1.TabIndex = 14
        '
        'MaterialCard6
        '
        Me.MaterialCard6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard6.Controls.Add(Me.LBL_totalPrice)
        Me.MaterialCard6.Controls.Add(Me.MaterialLabel5)
        Me.MaterialCard6.Depth = 0
        Me.MaterialCard6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard6.Location = New System.Drawing.Point(16, 451)
        Me.MaterialCard6.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard6.Name = "MaterialCard6"
        Me.MaterialCard6.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard6.Size = New System.Drawing.Size(221, 48)
        Me.MaterialCard6.TabIndex = 34
        '
        'LBL_totalPrice
        '
        Me.LBL_totalPrice.AutoSize = True
        Me.LBL_totalPrice.Depth = 0
        Me.LBL_totalPrice.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.LBL_totalPrice.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.LBL_totalPrice.Location = New System.Drawing.Point(114, 9)
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
        Me.MaterialLabel5.Size = New System.Drawing.Size(81, 19)
        Me.MaterialLabel5.TabIndex = 32
        Me.MaterialLabel5.Text = "Total Price:"
        '
        'MaterialCard5
        '
        Me.MaterialCard5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard5.Controls.Add(Me.MaterialLabel10)
        Me.MaterialCard5.Controls.Add(Me.MaterialLabel9)
        Me.MaterialCard5.Controls.Add(Me.MaterialCard8)
        Me.MaterialCard5.Controls.Add(Me.MaterialCard7)
        Me.MaterialCard5.Controls.Add(Me.Panel3)
        Me.MaterialCard5.Controls.Add(Me.LBL_price)
        Me.MaterialCard5.Controls.Add(Me.MaterialLabel4)
        Me.MaterialCard5.Controls.Add(Me.MaterialLabel3)
        Me.MaterialCard5.Controls.Add(Me.SLD_quantity)
        Me.MaterialCard5.Controls.Add(Me.TXT_quantity)
        Me.MaterialCard5.Depth = 0
        Me.MaterialCard5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard5.Location = New System.Drawing.Point(16, 212)
        Me.MaterialCard5.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard5.Name = "MaterialCard5"
        Me.MaterialCard5.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard5.Size = New System.Drawing.Size(459, 234)
        Me.MaterialCard5.TabIndex = 33
        '
        'MaterialLabel10
        '
        Me.MaterialLabel10.AutoSize = True
        Me.MaterialLabel10.Depth = 0
        Me.MaterialLabel10.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel10.Location = New System.Drawing.Point(123, 82)
        Me.MaterialLabel10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel10.Name = "MaterialLabel10"
        Me.MaterialLabel10.Size = New System.Drawing.Size(80, 14)
        Me.MaterialLabel10.TabIndex = 35
        Me.MaterialLabel10.Text = "Product Name"
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.AutoSize = True
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel9.Location = New System.Drawing.Point(120, 12)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(58, 14)
        Me.MaterialLabel9.TabIndex = 35
        Me.MaterialLabel9.Text = "Product ID"
        '
        'MaterialCard8
        '
        Me.MaterialCard8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard8.Controls.Add(Me.TXT_productID)
        Me.MaterialCard8.Depth = 0
        Me.MaterialCard8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard8.Location = New System.Drawing.Point(117, 32)
        Me.MaterialCard8.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard8.Name = "MaterialCard8"
        Me.MaterialCard8.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard8.Size = New System.Drawing.Size(312, 38)
        Me.MaterialCard8.TabIndex = 34
        '
        'TXT_productID
        '
        Me.TXT_productID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_productID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TXT_productID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_productID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXT_productID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_productID.Location = New System.Drawing.Point(14, 14)
        Me.TXT_productID.Name = "TXT_productID"
        Me.TXT_productID.Size = New System.Drawing.Size(284, 17)
        Me.TXT_productID.TabIndex = 0
        '
        'MaterialCard7
        '
        Me.MaterialCard7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard7.Controls.Add(Me.TXT_productName)
        Me.MaterialCard7.Depth = 0
        Me.MaterialCard7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard7.Location = New System.Drawing.Point(117, 102)
        Me.MaterialCard7.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard7.Name = "MaterialCard7"
        Me.MaterialCard7.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard7.Size = New System.Drawing.Size(312, 38)
        Me.MaterialCard7.TabIndex = 33
        '
        'TXT_productName
        '
        Me.TXT_productName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_productName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TXT_productName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_productName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXT_productName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_productName.Location = New System.Drawing.Point(14, 14)
        Me.TXT_productName.Name = "TXT_productName"
        Me.TXT_productName.Size = New System.Drawing.Size(284, 17)
        Me.TXT_productName.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.ITE_5_Project.My.Resources.Resources.Product
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(1, 39)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(112, 83)
        Me.Panel3.TabIndex = 21
        '
        'LBL_price
        '
        Me.LBL_price.AutoSize = True
        Me.LBL_price.Depth = 0
        Me.LBL_price.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.LBL_price.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2
        Me.LBL_price.Location = New System.Drawing.Point(163, 156)
        Me.LBL_price.MouseState = MaterialSkin.MouseState.HOVER
        Me.LBL_price.Name = "LBL_price"
        Me.LBL_price.Size = New System.Drawing.Size(29, 17)
        Me.LBL_price.TabIndex = 32
        Me.LBL_price.Text = "0.00"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2
        Me.MaterialLabel4.Location = New System.Drawing.Point(20, 175)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(55, 17)
        Me.MaterialLabel4.TabIndex = 32
        Me.MaterialLabel4.Text = "Quantity"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2
        Me.MaterialLabel3.Location = New System.Drawing.Point(121, 156)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(38, 17)
        Me.MaterialLabel3.TabIndex = 32
        Me.MaterialLabel3.Text = "Price: "
        '
        'SLD_quantity
        '
        Me.SLD_quantity.Depth = 0
        Me.SLD_quantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SLD_quantity.Location = New System.Drawing.Point(11, 188)
        Me.SLD_quantity.MouseState = MaterialSkin.MouseState.HOVER
        Me.SLD_quantity.Name = "SLD_quantity"
        Me.SLD_quantity.RangeMax = 50
        Me.SLD_quantity.ShowValue = False
        Me.SLD_quantity.Size = New System.Drawing.Size(350, 40)
        Me.SLD_quantity.TabIndex = 24
        Me.SLD_quantity.Text = ""
        Me.SLD_quantity.Value = 0
        '
        'TXT_quantity
        '
        Me.TXT_quantity.AnimateReadOnly = False
        Me.TXT_quantity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TXT_quantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXT_quantity.Depth = 0
        Me.TXT_quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_quantity.HideSelection = True
        Me.TXT_quantity.LeadingIcon = Nothing
        Me.TXT_quantity.Location = New System.Drawing.Point(364, 180)
        Me.TXT_quantity.MaxLength = 32767
        Me.TXT_quantity.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_quantity.Name = "TXT_quantity"
        Me.TXT_quantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_quantity.PrefixSuffixText = Nothing
        Me.TXT_quantity.ReadOnly = False
        Me.TXT_quantity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_quantity.SelectedText = ""
        Me.TXT_quantity.SelectionLength = 0
        Me.TXT_quantity.SelectionStart = 0
        Me.TXT_quantity.ShortcutsEnabled = True
        Me.TXT_quantity.Size = New System.Drawing.Size(60, 48)
        Me.TXT_quantity.TabIndex = 23
        Me.TXT_quantity.TabStop = False
        Me.TXT_quantity.Text = "0"
        Me.TXT_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_quantity.TrailingIcon = Nothing
        Me.TXT_quantity.UseSystemPasswordChar = False
        '
        'MaterialCard3
        '
        Me.MaterialCard3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard3.Controls.Add(Me.MaterialLabel8)
        Me.MaterialCard3.Controls.Add(Me.MaterialLabel7)
        Me.MaterialCard3.Controls.Add(Me.MaterialCard10)
        Me.MaterialCard3.Controls.Add(Me.MaterialCard9)
        Me.MaterialCard3.Controls.Add(Me.Panel2)
        Me.MaterialCard3.Depth = 0
        Me.MaterialCard3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard3.Location = New System.Drawing.Point(16, 32)
        Me.MaterialCard3.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard3.Name = "MaterialCard3"
        Me.MaterialCard3.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard3.Size = New System.Drawing.Size(459, 152)
        Me.MaterialCard3.TabIndex = 32
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.AutoSize = True
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel8.Location = New System.Drawing.Point(115, 75)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(79, 14)
        Me.MaterialLabel8.TabIndex = 35
        Me.MaterialLabel8.Text = "Student Name"
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel7.Location = New System.Drawing.Point(115, 9)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(57, 14)
        Me.MaterialLabel7.TabIndex = 35
        Me.MaterialLabel7.Text = "Student ID"
        '
        'MaterialCard10
        '
        Me.MaterialCard10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard10.Controls.Add(Me.TXT_studentName)
        Me.MaterialCard10.Depth = 0
        Me.MaterialCard10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard10.Location = New System.Drawing.Point(112, 94)
        Me.MaterialCard10.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard10.Name = "MaterialCard10"
        Me.MaterialCard10.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard10.Size = New System.Drawing.Size(312, 38)
        Me.MaterialCard10.TabIndex = 34
        '
        'TXT_studentName
        '
        Me.TXT_studentName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_studentName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TXT_studentName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_studentName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXT_studentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_studentName.Location = New System.Drawing.Point(14, 14)
        Me.TXT_studentName.Name = "TXT_studentName"
        Me.TXT_studentName.Size = New System.Drawing.Size(284, 17)
        Me.TXT_studentName.TabIndex = 0
        '
        'MaterialCard9
        '
        Me.MaterialCard9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard9.Controls.Add(Me.TXT_studentID)
        Me.MaterialCard9.Depth = 0
        Me.MaterialCard9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard9.Location = New System.Drawing.Point(112, 28)
        Me.MaterialCard9.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard9.Name = "MaterialCard9"
        Me.MaterialCard9.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard9.Size = New System.Drawing.Size(312, 38)
        Me.MaterialCard9.TabIndex = 34
        '
        'TXT_studentID
        '
        Me.TXT_studentID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_studentID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TXT_studentID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_studentID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXT_studentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_studentID.Location = New System.Drawing.Point(14, 14)
        Me.TXT_studentID.Name = "TXT_studentID"
        Me.TXT_studentID.Size = New System.Drawing.Size(284, 17)
        Me.TXT_studentID.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.ITE_5_Project.My.Resources.Resources.user
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(8, 21)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(88, 83)
        Me.Panel2.TabIndex = 21
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel1.Location = New System.Drawing.Point(24, 191)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(169, 14)
        Me.MaterialLabel1.TabIndex = 31
        Me.MaterialLabel1.Text = "Choose a product to be bought"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel2.Location = New System.Drawing.Point(24, 12)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(153, 14)
        Me.MaterialLabel2.TabIndex = 31
        Me.MaterialLabel2.Text = "Choose a Student Customer"
        '
        'BTN_add
        '
        Me.BTN_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_add.Depth = 0
        Me.BTN_add.HighEmphasis = True
        Me.BTN_add.Icon = Nothing
        Me.BTN_add.Location = New System.Drawing.Point(359, 456)
        Me.BTN_add.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_add.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_add.Name = "BTN_add"
        Me.BTN_add.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_add.Size = New System.Drawing.Size(114, 36)
        Me.BTN_add.TabIndex = 19
        Me.BTN_add.Text = "Add to Cart"
        Me.BTN_add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_add.UseAccentColor = False
        Me.BTN_add.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.ITE_5_Project.My.Resources.Resources.Product
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(16, 246)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(108, 83)
        Me.Panel1.TabIndex = 21
        '
        'MaterialCard2
        '
        Me.MaterialCard2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard2.Controls.Add(Me.DGV_cart)
        Me.MaterialCard2.Depth = 0
        Me.MaterialCard2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard2.Location = New System.Drawing.Point(517, 30)
        Me.MaterialCard2.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard2.Name = "MaterialCard2"
        Me.MaterialCard2.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.Size = New System.Drawing.Size(438, 414)
        Me.MaterialCard2.TabIndex = 15
        '
        'DGV_cart
        '
        Me.DGV_cart.AllowUserToAddRows = False
        Me.DGV_cart.AllowUserToDeleteRows = False
        Me.DGV_cart.AllowUserToResizeColumns = False
        Me.DGV_cart.AllowUserToResizeRows = False
        Me.DGV_cart.AutoGenerateColumns = False
        Me.DGV_cart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_cart.BackgroundColor = System.Drawing.Color.White
        Me.DGV_cart.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_cart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.DGV_cart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_cart.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_cart.ColumnHeadersHeight = 50
        Me.DGV_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_cart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransactionIDDataGridViewTextBoxColumn, Me.ProductIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.Price})
        Me.DGV_cart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_cart.DataSource = Me.TblcartBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_cart.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_cart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_cart.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DGV_cart.EnableHeadersVisualStyles = False
        Me.DGV_cart.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGV_cart.Location = New System.Drawing.Point(14, 14)
        Me.DGV_cart.Name = "DGV_cart"
        Me.DGV_cart.ReadOnly = True
        Me.DGV_cart.RowHeadersVisible = False
        Me.DGV_cart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV_cart.RowTemplate.Height = 50
        Me.DGV_cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_cart.Size = New System.Drawing.Size(410, 386)
        Me.DGV_cart.TabIndex = 13
        '
        'TransactionIDDataGridViewTextBoxColumn
        '
        Me.TransactionIDDataGridViewTextBoxColumn.DataPropertyName = "TransactionID"
        Me.TransactionIDDataGridViewTextBoxColumn.HeaderText = "TransactionID"
        Me.TransactionIDDataGridViewTextBoxColumn.Name = "TransactionIDDataGridViewTextBoxColumn"
        Me.TransactionIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.TransactionIDDataGridViewTextBoxColumn.Visible = False
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductIDDataGridViewTextBoxColumn.Visible = False
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Price
        '
        Me.Price.DataPropertyName = "Price"
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Visible = False
        '
        'TblcartBindingSource
        '
        Me.TblcartBindingSource.DataMember = "tbl_cart"
        Me.TblcartBindingSource.DataSource = Me.Db_inventoryDataSet
        '
        'Db_inventoryDataSet
        '
        Me.Db_inventoryDataSet.DataSetName = "db_inventoryDataSet"
        Me.Db_inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MaterialCard4
        '
        Me.MaterialCard4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard4.Controls.Add(Me.BTN_cancel)
        Me.MaterialCard4.Controls.Add(Me.BTN_buy)
        Me.MaterialCard4.Depth = 0
        Me.MaterialCard4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard4.Location = New System.Drawing.Point(517, 449)
        Me.MaterialCard4.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard4.Name = "MaterialCard4"
        Me.MaterialCard4.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard4.Size = New System.Drawing.Size(438, 79)
        Me.MaterialCard4.TabIndex = 17
        '
        'BTN_cancel
        '
        Me.BTN_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_cancel.Depth = 0
        Me.BTN_cancel.HighEmphasis = True
        Me.BTN_cancel.Icon = Nothing
        Me.BTN_cancel.Location = New System.Drawing.Point(216, 21)
        Me.BTN_cancel.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_cancel.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_cancel.Name = "BTN_cancel"
        Me.BTN_cancel.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_cancel.Size = New System.Drawing.Size(77, 36)
        Me.BTN_cancel.TabIndex = 19
        Me.BTN_cancel.Text = "Cancel"
        Me.BTN_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.BTN_cancel.UseAccentColor = False
        Me.BTN_cancel.UseVisualStyleBackColor = True
        '
        'BTN_buy
        '
        Me.BTN_buy.AutoSize = False
        Me.BTN_buy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_buy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_buy.Depth = 0
        Me.BTN_buy.HighEmphasis = True
        Me.BTN_buy.Icon = Nothing
        Me.BTN_buy.Location = New System.Drawing.Point(301, 21)
        Me.BTN_buy.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_buy.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_buy.Name = "BTN_buy"
        Me.BTN_buy.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_buy.Size = New System.Drawing.Size(115, 36)
        Me.BTN_buy.TabIndex = 19
        Me.BTN_buy.Text = "Buy"
        Me.BTN_buy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_buy.UseAccentColor = False
        Me.BTN_buy.UseVisualStyleBackColor = True
        '
        'Tbl_cartTableAdapter
        '
        Me.Tbl_cartTableAdapter.ClearBeforeFill = True
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel6.Location = New System.Drawing.Point(27, 9)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(296, 14)
        Me.MaterialLabel6.TabIndex = 31
        Me.MaterialLabel6.Text = "Process and Record the daily Transactions of Students"
        '
        'UC_transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.MaterialCard4)
        Me.Controls.Add(Me.MaterialCard2)
        Me.Controls.Add(Me.MaterialCard1)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Name = "UC_transactions"
        Me.Size = New System.Drawing.Size(1039, 581)
        Me.MaterialCard1.ResumeLayout(False)
        Me.MaterialCard1.PerformLayout()
        Me.MaterialCard6.ResumeLayout(False)
        Me.MaterialCard6.PerformLayout()
        Me.MaterialCard5.ResumeLayout(False)
        Me.MaterialCard5.PerformLayout()
        Me.MaterialCard8.ResumeLayout(False)
        Me.MaterialCard8.PerformLayout()
        Me.MaterialCard7.ResumeLayout(False)
        Me.MaterialCard7.PerformLayout()
        Me.MaterialCard3.ResumeLayout(False)
        Me.MaterialCard3.PerformLayout()
        Me.MaterialCard10.ResumeLayout(False)
        Me.MaterialCard10.PerformLayout()
        Me.MaterialCard9.ResumeLayout(False)
        Me.MaterialCard9.PerformLayout()
        Me.MaterialCard2.ResumeLayout(False)
        CType(Me.DGV_cart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_inventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialCard4.ResumeLayout(False)
        Me.MaterialCard4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard4 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents DGV_cart As DataGridView
    Friend WithEvents BTN_add As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BTN_cancel As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BTN_buy As MaterialSkin.Controls.MaterialButton
    Friend WithEvents TransactionIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents TblcartBindingSource As BindingSource
    Friend WithEvents Db_inventoryDataSet As db_inventoryDataSet
    Friend WithEvents Tbl_cartTableAdapter As db_inventoryDataSetTableAdapters.tbl_cartTableAdapter
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard3 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard5 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents TXT_quantity As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents SLD_quantity As MaterialSkin.Controls.MaterialSlider
    Friend WithEvents LBL_price As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard6 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents LBL_totalPrice As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TXT_productName As TextBox
    Friend WithEvents MaterialCard7 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard8 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents TXT_productID As TextBox
    Friend WithEvents MaterialCard10 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents TXT_studentName As TextBox
    Friend WithEvents MaterialCard9 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents TXT_studentID As TextBox
    Friend WithEvents MaterialLabel10 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
End Class
