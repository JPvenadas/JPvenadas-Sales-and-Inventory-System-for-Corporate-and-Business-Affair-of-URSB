<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_mainmenu
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_mainmenu))
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TAB_home = New System.Windows.Forms.TabPage()
        Me.TAB_user = New System.Windows.Forms.TabPage()
        Me.TAB_students = New System.Windows.Forms.TabPage()
        Me.TAB_products = New System.Windows.Forms.TabPage()
        Me.TAB_stocks = New System.Windows.Forms.TabPage()
        Me.TAB_transaction = New System.Windows.Forms.TabPage()
        Me.TAB_reports = New System.Windows.Forms.TabPage()
        Me.TAB_settings = New System.Windows.Forms.TabPage()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Db_inventoryDataSet = New ITE_5_Project.db_inventoryDataSet()
        Me.TblusersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_usersTableAdapter = New ITE_5_Project.db_inventoryDataSetTableAdapters.tbl_usersTableAdapter()
        Me.TblproductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_productsTableAdapter = New ITE_5_Project.db_inventoryDataSetTableAdapters.tbl_productsTableAdapter()
        Me.BTN_logout = New System.Windows.Forms.Button()
        Me.MaterialTabControl1.SuspendLayout()
        CType(Me.Db_inventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblusersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblproductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TAB_home)
        Me.MaterialTabControl1.Controls.Add(Me.TAB_user)
        Me.MaterialTabControl1.Controls.Add(Me.TAB_students)
        Me.MaterialTabControl1.Controls.Add(Me.TAB_products)
        Me.MaterialTabControl1.Controls.Add(Me.TAB_stocks)
        Me.MaterialTabControl1.Controls.Add(Me.TAB_transaction)
        Me.MaterialTabControl1.Controls.Add(Me.TAB_reports)
        Me.MaterialTabControl1.Controls.Add(Me.TAB_settings)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialTabControl1.ImageList = Me.ImageList1
        Me.MaterialTabControl1.Location = New System.Drawing.Point(0, 72)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Multiline = True
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.ShowToolTips = True
        Me.MaterialTabControl1.Size = New System.Drawing.Size(1056, 586)
        Me.MaterialTabControl1.TabIndex = 0
        '
        'TAB_home
        '
        Me.TAB_home.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TAB_home.ImageKey = "icons8-home-96.png"
        Me.TAB_home.Location = New System.Drawing.Point(4, 39)
        Me.TAB_home.Name = "TAB_home"
        Me.TAB_home.Padding = New System.Windows.Forms.Padding(3)
        Me.TAB_home.Size = New System.Drawing.Size(1048, 543)
        Me.TAB_home.TabIndex = 0
        Me.TAB_home.Text = "Home"
        Me.TAB_home.ToolTipText = "Home"
        Me.TAB_home.UseVisualStyleBackColor = True
        '
        'TAB_user
        '
        Me.TAB_user.ImageKey = "icons8-user-90.png"
        Me.TAB_user.Location = New System.Drawing.Point(4, 39)
        Me.TAB_user.Name = "TAB_user"
        Me.TAB_user.Padding = New System.Windows.Forms.Padding(3)
        Me.TAB_user.Size = New System.Drawing.Size(1048, 543)
        Me.TAB_user.TabIndex = 1
        Me.TAB_user.Text = "Users"
        Me.TAB_user.ToolTipText = "Students"
        Me.TAB_user.UseVisualStyleBackColor = True
        '
        'TAB_students
        '
        Me.TAB_students.ImageKey = "icons8-member-96.png"
        Me.TAB_students.Location = New System.Drawing.Point(4, 39)
        Me.TAB_students.Name = "TAB_students"
        Me.TAB_students.Size = New System.Drawing.Size(1048, 543)
        Me.TAB_students.TabIndex = 2
        Me.TAB_students.Text = "Students"
        Me.TAB_students.ToolTipText = "Students"
        Me.TAB_students.UseVisualStyleBackColor = True
        '
        'TAB_products
        '
        Me.TAB_products.ImageKey = "icons8-used-product-64.png"
        Me.TAB_products.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TAB_products.Location = New System.Drawing.Point(4, 39)
        Me.TAB_products.Name = "TAB_products"
        Me.TAB_products.Size = New System.Drawing.Size(1048, 543)
        Me.TAB_products.TabIndex = 3
        Me.TAB_products.Text = "Products"
        Me.TAB_products.ToolTipText = "Products"
        Me.TAB_products.UseVisualStyleBackColor = True
        '
        'TAB_stocks
        '
        Me.TAB_stocks.ImageKey = "icons8-hangar-60.png"
        Me.TAB_stocks.Location = New System.Drawing.Point(4, 39)
        Me.TAB_stocks.Name = "TAB_stocks"
        Me.TAB_stocks.Size = New System.Drawing.Size(1048, 543)
        Me.TAB_stocks.TabIndex = 4
        Me.TAB_stocks.Text = "Product Stocks"
        Me.TAB_stocks.ToolTipText = "Stocks"
        Me.TAB_stocks.UseVisualStyleBackColor = True
        '
        'TAB_transaction
        '
        Me.TAB_transaction.ImageKey = "icons8-shopping-cart-96.png"
        Me.TAB_transaction.Location = New System.Drawing.Point(4, 39)
        Me.TAB_transaction.Name = "TAB_transaction"
        Me.TAB_transaction.Size = New System.Drawing.Size(1048, 543)
        Me.TAB_transaction.TabIndex = 5
        Me.TAB_transaction.Text = "Transactions"
        Me.TAB_transaction.ToolTipText = "Sales Transaction"
        Me.TAB_transaction.UseVisualStyleBackColor = True
        '
        'TAB_reports
        '
        Me.TAB_reports.ImageKey = "icons8-shared-folder-50.png"
        Me.TAB_reports.Location = New System.Drawing.Point(4, 39)
        Me.TAB_reports.Name = "TAB_reports"
        Me.TAB_reports.Size = New System.Drawing.Size(1048, 543)
        Me.TAB_reports.TabIndex = 6
        Me.TAB_reports.Text = "Reports"
        Me.TAB_reports.ToolTipText = "Reports"
        Me.TAB_reports.UseVisualStyleBackColor = True
        '
        'TAB_settings
        '
        Me.TAB_settings.ImageKey = "icons8-settings-50.png"
        Me.TAB_settings.Location = New System.Drawing.Point(4, 39)
        Me.TAB_settings.Name = "TAB_settings"
        Me.TAB_settings.Size = New System.Drawing.Size(1048, 543)
        Me.TAB_settings.TabIndex = 7
        Me.TAB_settings.Text = "Settings"
        Me.TAB_settings.ToolTipText = "Settings"
        Me.TAB_settings.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icons8-settings-50.png")
        Me.ImageList1.Images.SetKeyName(1, "icons8-shopping-cart-96.png")
        Me.ImageList1.Images.SetKeyName(2, "icons8-used-product-64.png")
        Me.ImageList1.Images.SetKeyName(3, "icons8-shared-folder-50.png")
        Me.ImageList1.Images.SetKeyName(4, "icons8-member-96.png")
        Me.ImageList1.Images.SetKeyName(5, "icons8-home-96.png")
        Me.ImageList1.Images.SetKeyName(6, "icons8-user-90.png")
        Me.ImageList1.Images.SetKeyName(7, "icons8-hangar-60.png")
        Me.ImageList1.Images.SetKeyName(8, "icons8-member-96.png")
        '
        'Db_inventoryDataSet
        '
        Me.Db_inventoryDataSet.DataSetName = "db_inventoryDataSet"
        Me.Db_inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblusersBindingSource
        '
        Me.TblusersBindingSource.DataMember = "tbl_users"
        Me.TblusersBindingSource.DataSource = Me.Db_inventoryDataSet
        '
        'Tbl_usersTableAdapter
        '
        Me.Tbl_usersTableAdapter.ClearBeforeFill = True
        '
        'TblproductsBindingSource
        '
        Me.TblproductsBindingSource.DataMember = "tbl_products"
        Me.TblproductsBindingSource.DataSource = Me.Db_inventoryDataSet
        '
        'Tbl_productsTableAdapter
        '
        Me.Tbl_productsTableAdapter.ClearBeforeFill = True
        '
        'BTN_logout
        '
        Me.BTN_logout.BackColor = System.Drawing.Color.Transparent
        Me.BTN_logout.BackgroundImage = Global.ITE_5_Project.My.Resources.Resources.logout
        Me.BTN_logout.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTN_logout.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BTN_logout.Location = New System.Drawing.Point(969, 30)
        Me.BTN_logout.Name = "BTN_logout"
        Me.BTN_logout.Size = New System.Drawing.Size(80, 31)
        Me.BTN_logout.TabIndex = 1
        Me.BTN_logout.Text = "Logout"
        Me.BTN_logout.UseVisualStyleBackColor = False
        '
        'FRM_mainmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 661)
        Me.Controls.Add(Me.BTN_logout)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.DrawerShowIconsWhenHidden = True
        Me.DrawerTabControl = Me.MaterialTabControl1
        Me.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48
        Me.MaximumSize = New System.Drawing.Size(1059, 661)
        Me.Name = "FRM_mainmenu"
        Me.Padding = New System.Windows.Forms.Padding(0, 72, 3, 3)
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.MaterialTabControl1.ResumeLayout(False)
        CType(Me.Db_inventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblusersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblproductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TAB_home As TabPage
    Friend WithEvents TAB_user As TabPage
    Friend WithEvents TAB_students As TabPage
    Friend WithEvents TAB_stocks As TabPage
    Friend WithEvents TAB_transaction As TabPage
    Friend WithEvents TAB_reports As TabPage
    Friend WithEvents TAB_settings As TabPage
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Db_inventoryDataSet As db_inventoryDataSet
    Friend WithEvents TblusersBindingSource As BindingSource
    Friend WithEvents Tbl_usersTableAdapter As db_inventoryDataSetTableAdapters.tbl_usersTableAdapter
    Friend WithEvents TAB_products As TabPage
    Friend WithEvents TblproductsBindingSource As BindingSource
    Friend WithEvents Tbl_productsTableAdapter As db_inventoryDataSetTableAdapters.tbl_productsTableAdapter
    Friend WithEvents BTN_logout As Button
End Class
