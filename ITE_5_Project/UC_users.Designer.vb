<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_users
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGV_users = New System.Windows.Forms.DataGridView()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblusersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_inventoryDataSet = New ITE_5_Project.db_inventoryDataSet()
        Me.Tbl_usersTableAdapter = New ITE_5_Project.db_inventoryDataSetTableAdapters.tbl_usersTableAdapter()
        Me.TXT_filter = New MaterialSkin.Controls.MaterialTextBox2()
        Me.BTN_search = New MaterialSkin.Controls.MaterialButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_add = New MaterialSkin.Controls.MaterialButton()
        Me.CBO_type = New MaterialSkin.Controls.MaterialComboBox()
        CType(Me.DGV_users, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblusersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_inventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_users
        '
        Me.DGV_users.AllowUserToAddRows = False
        Me.DGV_users.AllowUserToDeleteRows = False
        Me.DGV_users.AllowUserToResizeColumns = False
        Me.DGV_users.AllowUserToResizeRows = False
        Me.DGV_users.AutoGenerateColumns = False
        Me.DGV_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_users.BackgroundColor = System.Drawing.Color.White
        Me.DGV_users.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_users.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.DGV_users.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_users.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_users.ColumnHeadersHeight = 50
        Me.DGV_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_users.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsernameDataGridViewTextBoxColumn, Me.LoginNameDataGridViewTextBoxColumn, Me.UserTypeDataGridViewTextBoxColumn, Me.AccountStatusDataGridViewTextBoxColumn})
        Me.DGV_users.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_users.DataSource = Me.TblusersBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_users.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_users.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DGV_users.EnableHeadersVisualStyles = False
        Me.DGV_users.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGV_users.Location = New System.Drawing.Point(22, 116)
        Me.DGV_users.Name = "DGV_users"
        Me.DGV_users.ReadOnly = True
        Me.DGV_users.RowHeadersVisible = False
        Me.DGV_users.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV_users.RowTemplate.Height = 50
        Me.DGV_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_users.Size = New System.Drawing.Size(952, 404)
        Me.DGV_users.TabIndex = 0
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LoginNameDataGridViewTextBoxColumn
        '
        Me.LoginNameDataGridViewTextBoxColumn.DataPropertyName = "LoginName"
        Me.LoginNameDataGridViewTextBoxColumn.HeaderText = "LoginName"
        Me.LoginNameDataGridViewTextBoxColumn.Name = "LoginNameDataGridViewTextBoxColumn"
        Me.LoginNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserTypeDataGridViewTextBoxColumn
        '
        Me.UserTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType"
        Me.UserTypeDataGridViewTextBoxColumn.HeaderText = "UserType"
        Me.UserTypeDataGridViewTextBoxColumn.Name = "UserTypeDataGridViewTextBoxColumn"
        Me.UserTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccountStatusDataGridViewTextBoxColumn
        '
        Me.AccountStatusDataGridViewTextBoxColumn.DataPropertyName = "AccountStatus"
        Me.AccountStatusDataGridViewTextBoxColumn.HeaderText = "AccountStatus"
        Me.AccountStatusDataGridViewTextBoxColumn.Name = "AccountStatusDataGridViewTextBoxColumn"
        Me.AccountStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblusersBindingSource
        '
        Me.TblusersBindingSource.DataMember = "tbl_users"
        Me.TblusersBindingSource.DataSource = Me.Db_inventoryDataSet
        '
        'Db_inventoryDataSet
        '
        Me.Db_inventoryDataSet.DataSetName = "db_inventoryDataSet"
        Me.Db_inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_usersTableAdapter
        '
        Me.Tbl_usersTableAdapter.ClearBeforeFill = True
        '
        'TXT_filter
        '
        Me.TXT_filter.AnimateReadOnly = False
        Me.TXT_filter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TXT_filter.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXT_filter.Depth = 0
        Me.TXT_filter.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_filter.HideSelection = True
        Me.TXT_filter.Hint = "Search a user here"
        Me.TXT_filter.LeadingIcon = Nothing
        Me.TXT_filter.Location = New System.Drawing.Point(468, 49)
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
        Me.TXT_filter.Size = New System.Drawing.Size(365, 48)
        Me.TXT_filter.TabIndex = 1
        Me.TXT_filter.TabStop = False
        Me.TXT_filter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_filter.TrailingIcon = Nothing
        Me.TXT_filter.UseSystemPasswordChar = False
        '
        'BTN_search
        '
        Me.BTN_search.AutoSize = False
        Me.BTN_search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_search.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_search.Depth = 0
        Me.BTN_search.HighEmphasis = True
        Me.BTN_search.Icon = Nothing
        Me.BTN_search.Location = New System.Drawing.Point(846, 48)
        Me.BTN_search.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_search.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_search.Name = "BTN_search"
        Me.BTN_search.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_search.Size = New System.Drawing.Size(128, 48)
        Me.BTN_search.TabIndex = 2
        Me.BTN_search.Text = "Search"
        Me.BTN_search.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_search.UseAccentColor = False
        Me.BTN_search.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(19, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(905, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Manage who can access the system. You can add new user by clicking the add Button" &
    " or Edit existing user Accounts by double clicking the specific record in the ta" &
    "ble  "
        '
        'BTN_add
        '
        Me.BTN_add.AutoSize = False
        Me.BTN_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_add.Depth = 0
        Me.BTN_add.HighEmphasis = True
        Me.BTN_add.Icon = Nothing
        Me.BTN_add.Location = New System.Drawing.Point(22, 49)
        Me.BTN_add.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_add.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_add.Name = "BTN_add"
        Me.BTN_add.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_add.Size = New System.Drawing.Size(136, 48)
        Me.BTN_add.TabIndex = 5
        Me.BTN_add.Text = "+ Add user"
        Me.BTN_add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_add.UseAccentColor = False
        Me.BTN_add.UseVisualStyleBackColor = True
        '
        'CBO_type
        '
        Me.CBO_type.AutoResize = False
        Me.CBO_type.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBO_type.Depth = 0
        Me.CBO_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CBO_type.DropDownHeight = 174
        Me.CBO_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_type.DropDownWidth = 121
        Me.CBO_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.CBO_type.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBO_type.Hint = "Status"
        Me.CBO_type.IntegralHeight = False
        Me.CBO_type.ItemHeight = 43
        Me.CBO_type.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.CBO_type.Location = New System.Drawing.Point(289, 47)
        Me.CBO_type.MaxDropDownItems = 4
        Me.CBO_type.MouseState = MaterialSkin.MouseState.OUT
        Me.CBO_type.Name = "CBO_type"
        Me.CBO_type.Size = New System.Drawing.Size(173, 49)
        Me.CBO_type.StartIndex = 0
        Me.CBO_type.TabIndex = 6
        '
        'UC_users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.CBO_type)
        Me.Controls.Add(Me.BTN_add)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_search)
        Me.Controls.Add(Me.TXT_filter)
        Me.Controls.Add(Me.DGV_users)
        Me.Name = "UC_users"
        Me.Size = New System.Drawing.Size(1039, 537)
        CType(Me.DGV_users, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblusersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_inventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_users As DataGridView
    Friend WithEvents TblusersBindingSource As BindingSource
    Friend WithEvents Db_inventoryDataSet As db_inventoryDataSet
    Friend WithEvents Tbl_usersTableAdapter As db_inventoryDataSetTableAdapters.tbl_usersTableAdapter
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoginNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccountStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TXT_filter As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents BTN_search As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_add As MaterialSkin.Controls.MaterialButton
    Friend WithEvents CBO_type As MaterialSkin.Controls.MaterialComboBox
End Class
