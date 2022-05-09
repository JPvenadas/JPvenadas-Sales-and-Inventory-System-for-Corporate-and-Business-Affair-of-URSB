<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCRPT_users
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.CBO_usertype = New MaterialSkin.Controls.MaterialComboBox()
        Me.BTN_filteruser = New MaterialSkin.Controls.MaterialButton()
        Me.BTN_clear = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.RPTV_users = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.db_inventoryDataSet = New ITE_5_Project.db_inventoryDataSet()
        Me.tbl_usersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_usersTableAdapter = New ITE_5_Project.db_inventoryDataSetTableAdapters.tbl_usersTableAdapter()
        Me.MaterialCard1.SuspendLayout()
        CType(Me.db_inventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_usersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.CBO_usertype)
        Me.MaterialCard1.Controls.Add(Me.BTN_filteruser)
        Me.MaterialCard1.Controls.Add(Me.BTN_clear)
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel1)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(14, 5)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(228, 506)
        Me.MaterialCard1.TabIndex = 2
        '
        'CBO_usertype
        '
        Me.CBO_usertype.AutoResize = False
        Me.CBO_usertype.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBO_usertype.Depth = 0
        Me.CBO_usertype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CBO_usertype.DropDownHeight = 174
        Me.CBO_usertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_usertype.DropDownWidth = 121
        Me.CBO_usertype.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.CBO_usertype.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBO_usertype.FormattingEnabled = True
        Me.CBO_usertype.Hint = "User Type"
        Me.CBO_usertype.IntegralHeight = False
        Me.CBO_usertype.ItemHeight = 43
        Me.CBO_usertype.Location = New System.Drawing.Point(17, 53)
        Me.CBO_usertype.MaxDropDownItems = 4
        Me.CBO_usertype.MouseState = MaterialSkin.MouseState.OUT
        Me.CBO_usertype.Name = "CBO_usertype"
        Me.CBO_usertype.Size = New System.Drawing.Size(184, 49)
        Me.CBO_usertype.StartIndex = 0
        Me.CBO_usertype.TabIndex = 4
        '
        'BTN_filteruser
        '
        Me.BTN_filteruser.AutoSize = False
        Me.BTN_filteruser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_filteruser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_filteruser.Depth = 0
        Me.BTN_filteruser.HighEmphasis = True
        Me.BTN_filteruser.Icon = Nothing
        Me.BTN_filteruser.Location = New System.Drawing.Point(35, 110)
        Me.BTN_filteruser.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_filteruser.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_filteruser.Name = "BTN_filteruser"
        Me.BTN_filteruser.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_filteruser.Size = New System.Drawing.Size(150, 36)
        Me.BTN_filteruser.TabIndex = 3
        Me.BTN_filteruser.Text = "Filter"
        Me.BTN_filteruser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_filteruser.UseAccentColor = False
        Me.BTN_filteruser.UseVisualStyleBackColor = True
        '
        'BTN_clear
        '
        Me.BTN_clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_clear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_clear.Depth = 0
        Me.BTN_clear.HighEmphasis = True
        Me.BTN_clear.Icon = Nothing
        Me.BTN_clear.Location = New System.Drawing.Point(146, 9)
        Me.BTN_clear.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_clear.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_clear.Name = "BTN_clear"
        Me.BTN_clear.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_clear.Size = New System.Drawing.Size(66, 36)
        Me.BTN_clear.TabIndex = 3
        Me.BTN_clear.Text = "Clear"
        Me.BTN_clear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.BTN_clear.UseAccentColor = False
        Me.BTN_clear.UseVisualStyleBackColor = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel1.HighEmphasis = True
        Me.MaterialLabel1.Location = New System.Drawing.Point(17, 12)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(57, 24)
        Me.MaterialLabel1.TabIndex = 1
        Me.MaterialLabel1.Text = "Filters"
        '
        'RPTV_users
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tbl_usersBindingSource
        Me.RPTV_users.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RPTV_users.LocalReport.ReportEmbeddedResource = "ITE_5_Project.RPT_users.rdlc"
        Me.RPTV_users.Location = New System.Drawing.Point(259, 5)
        Me.RPTV_users.Name = "RPTV_users"
        Me.RPTV_users.ServerReport.BearerToken = Nothing
        Me.RPTV_users.Size = New System.Drawing.Size(750, 506)
        Me.RPTV_users.TabIndex = 3
        '
        'db_inventoryDataSet
        '
        Me.db_inventoryDataSet.DataSetName = "db_inventoryDataSet"
        Me.db_inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbl_usersBindingSource
        '
        Me.tbl_usersBindingSource.DataMember = "tbl_users"
        Me.tbl_usersBindingSource.DataSource = Me.db_inventoryDataSet
        '
        'tbl_usersTableAdapter
        '
        Me.tbl_usersTableAdapter.ClearBeforeFill = True
        '
        'UCRPT_users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.RPTV_users)
        Me.Controls.Add(Me.MaterialCard1)
        Me.Name = "UCRPT_users"
        Me.Size = New System.Drawing.Size(1031, 525)
        Me.MaterialCard1.ResumeLayout(False)
        Me.MaterialCard1.PerformLayout()
        CType(Me.db_inventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_usersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents CBO_usertype As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents BTN_filteruser As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BTN_clear As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents RPTV_users As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_usersBindingSource As BindingSource
    Friend WithEvents db_inventoryDataSet As db_inventoryDataSet
    Friend WithEvents tbl_usersTableAdapter As db_inventoryDataSetTableAdapters.tbl_usersTableAdapter
End Class
