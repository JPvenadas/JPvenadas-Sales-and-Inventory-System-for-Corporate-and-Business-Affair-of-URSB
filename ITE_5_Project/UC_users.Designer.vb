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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGV_users = New System.Windows.Forms.DataGridView()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblusersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_inventoryDataSet = New ITE_5_Project.db_inventoryDataSet()
        Me.Tbl_usersTableAdapter = New ITE_5_Project.db_inventoryDataSetTableAdapters.tbl_usersTableAdapter()
        Me.MaterialTextBox21 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.BTN_search = New MaterialSkin.Controls.MaterialButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaterialCheckbox1 = New MaterialSkin.Controls.MaterialCheckbox()
        Me.BTN_add = New MaterialSkin.Controls.MaterialButton()
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_users.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_users.ColumnHeadersHeight = 50
        Me.DGV_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_users.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsernameDataGridViewTextBoxColumn, Me.LoginNameDataGridViewTextBoxColumn, Me.UserTypeDataGridViewTextBoxColumn, Me.AccountStatusDataGridViewTextBoxColumn})
        Me.DGV_users.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_users.DataSource = Me.TblusersBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_users.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_users.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DGV_users.EnableHeadersVisualStyles = False
        Me.DGV_users.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGV_users.Location = New System.Drawing.Point(22, 125)
        Me.DGV_users.Name = "DGV_users"
        Me.DGV_users.ReadOnly = True
        Me.DGV_users.RowHeadersVisible = False
        Me.DGV_users.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV_users.RowTemplate.Height = 50
        Me.DGV_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_users.Size = New System.Drawing.Size(952, 385)
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
        'MaterialTextBox21
        '
        Me.MaterialTextBox21.AnimateReadOnly = False
        Me.MaterialTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBox21.Depth = 0
        Me.MaterialTextBox21.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBox21.HideSelection = True
        Me.MaterialTextBox21.Hint = "Search a user here"
        Me.MaterialTextBox21.LeadingIcon = Nothing
        Me.MaterialTextBox21.Location = New System.Drawing.Point(437, 58)
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
        Me.MaterialTextBox21.Size = New System.Drawing.Size(396, 48)
        Me.MaterialTextBox21.TabIndex = 1
        Me.MaterialTextBox21.TabStop = False
        Me.MaterialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBox21.TrailingIcon = Nothing
        Me.MaterialTextBox21.UseSystemPasswordChar = False
        '
        'BTN_search
        '
        Me.BTN_search.AutoSize = False
        Me.BTN_search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_search.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_search.Depth = 0
        Me.BTN_search.HighEmphasis = True
        Me.BTN_search.Icon = Nothing
        Me.BTN_search.Location = New System.Drawing.Point(846, 57)
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
        Me.Label1.Location = New System.Drawing.Point(19, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(905, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Manage who can access the system. You can add new user by clicking the add Button" &
    " or Edit existing user Accounts by double clicking the specific record in the ta" &
    "ble  "
        '
        'MaterialCheckbox1
        '
        Me.MaterialCheckbox1.AutoSize = True
        Me.MaterialCheckbox1.Depth = 0
        Me.MaterialCheckbox1.Location = New System.Drawing.Point(337, 64)
        Me.MaterialCheckbox1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckbox1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckbox1.Name = "MaterialCheckbox1"
        Me.MaterialCheckbox1.ReadOnly = False
        Me.MaterialCheckbox1.Ripple = True
        Me.MaterialCheckbox1.Size = New System.Drawing.Size(78, 37)
        Me.MaterialCheckbox1.TabIndex = 4
        Me.MaterialCheckbox1.Text = "Active"
        Me.MaterialCheckbox1.UseVisualStyleBackColor = True
        '
        'BTN_add
        '
        Me.BTN_add.AutoSize = False
        Me.BTN_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_add.Depth = 0
        Me.BTN_add.HighEmphasis = True
        Me.BTN_add.Icon = Nothing
        Me.BTN_add.Location = New System.Drawing.Point(22, 58)
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
        'UC_users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.BTN_add)
        Me.Controls.Add(Me.MaterialCheckbox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_search)
        Me.Controls.Add(Me.MaterialTextBox21)
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
    Friend WithEvents MaterialTextBox21 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents BTN_search As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Label1 As Label
    Friend WithEvents MaterialCheckbox1 As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents BTN_add As MaterialSkin.Controls.MaterialButton
End Class
