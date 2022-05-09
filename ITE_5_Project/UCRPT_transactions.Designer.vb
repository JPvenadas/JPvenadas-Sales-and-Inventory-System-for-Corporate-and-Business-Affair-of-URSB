<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCRPT_transactions
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
        Me.RPTV_transactions = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MaterialCard8 = New MaterialSkin.Controls.MaterialCard()
        Me.TXT_product = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialCard13 = New MaterialSkin.Controls.MaterialCard()
        Me.DT_endstocks = New System.Windows.Forms.DateTimePicker()
        Me.DT_startstocks = New System.Windows.Forms.DateTimePicker()
        Me.dldkd = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.BTN_stocksdatefilter = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.BTN_productfilter = New MaterialSkin.Controls.MaterialButton()
        Me.BTN_clearstocksfilter = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.db_inventoryDataSet = New ITE_5_Project.db_inventoryDataSet()
        Me.tbl_transactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_transactionsTableAdapter = New ITE_5_Project.db_inventoryDataSetTableAdapters.tbl_transactionsTableAdapter()
        Me.MaterialCard8.SuspendLayout()
        Me.MaterialCard13.SuspendLayout()
        CType(Me.db_inventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_transactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RPTV_transactions
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tbl_transactionsBindingSource
        Me.RPTV_transactions.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RPTV_transactions.LocalReport.ReportEmbeddedResource = "ITE_5_Project.RPT_transactions.rdlc"
        Me.RPTV_transactions.Location = New System.Drawing.Point(253, 13)
        Me.RPTV_transactions.Name = "RPTV_transactions"
        Me.RPTV_transactions.ServerReport.BearerToken = Nothing
        Me.RPTV_transactions.Size = New System.Drawing.Size(680, 506)
        Me.RPTV_transactions.TabIndex = 4
        '
        'MaterialCard8
        '
        Me.MaterialCard8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard8.Controls.Add(Me.TXT_product)
        Me.MaterialCard8.Controls.Add(Me.MaterialCard13)
        Me.MaterialCard8.Controls.Add(Me.BTN_stocksdatefilter)
        Me.MaterialCard8.Controls.Add(Me.MaterialLabel9)
        Me.MaterialCard8.Controls.Add(Me.BTN_productfilter)
        Me.MaterialCard8.Controls.Add(Me.BTN_clearstocksfilter)
        Me.MaterialCard8.Controls.Add(Me.MaterialLabel4)
        Me.MaterialCard8.Depth = 0
        Me.MaterialCard8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard8.Location = New System.Drawing.Point(14, 14)
        Me.MaterialCard8.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard8.Name = "MaterialCard8"
        Me.MaterialCard8.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard8.Size = New System.Drawing.Size(228, 525)
        Me.MaterialCard8.TabIndex = 5
        '
        'TXT_product
        '
        Me.TXT_product.AnimateReadOnly = False
        Me.TXT_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TXT_product.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXT_product.Depth = 0
        Me.TXT_product.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_product.HideSelection = True
        Me.TXT_product.Hint = "Product Name"
        Me.TXT_product.LeadingIcon = Nothing
        Me.TXT_product.Location = New System.Drawing.Point(21, 60)
        Me.TXT_product.MaxLength = 32767
        Me.TXT_product.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_product.Name = "TXT_product"
        Me.TXT_product.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_product.PrefixSuffixText = Nothing
        Me.TXT_product.ReadOnly = False
        Me.TXT_product.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_product.SelectedText = ""
        Me.TXT_product.SelectionLength = 0
        Me.TXT_product.SelectionStart = 0
        Me.TXT_product.ShortcutsEnabled = True
        Me.TXT_product.Size = New System.Drawing.Size(178, 48)
        Me.TXT_product.TabIndex = 14
        Me.TXT_product.TabStop = False
        Me.TXT_product.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_product.TrailingIcon = Nothing
        Me.TXT_product.UseSystemPasswordChar = False
        '
        'MaterialCard13
        '
        Me.MaterialCard13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard13.Controls.Add(Me.DT_endstocks)
        Me.MaterialCard13.Controls.Add(Me.DT_startstocks)
        Me.MaterialCard13.Controls.Add(Me.dldkd)
        Me.MaterialCard13.Controls.Add(Me.MaterialLabel7)
        Me.MaterialCard13.Depth = 0
        Me.MaterialCard13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard13.Location = New System.Drawing.Point(19, 199)
        Me.MaterialCard13.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard13.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard13.Name = "MaterialCard13"
        Me.MaterialCard13.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard13.Size = New System.Drawing.Size(181, 127)
        Me.MaterialCard13.TabIndex = 13
        '
        'DT_endstocks
        '
        Me.DT_endstocks.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_endstocks.Location = New System.Drawing.Point(9, 85)
        Me.DT_endstocks.Name = "DT_endstocks"
        Me.DT_endstocks.Size = New System.Drawing.Size(158, 20)
        Me.DT_endstocks.TabIndex = 3
        '
        'DT_startstocks
        '
        Me.DT_startstocks.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.DT_startstocks.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_startstocks.Location = New System.Drawing.Point(11, 33)
        Me.DT_startstocks.Name = "DT_startstocks"
        Me.DT_startstocks.Size = New System.Drawing.Size(153, 20)
        Me.DT_startstocks.TabIndex = 2
        '
        'dldkd
        '
        Me.dldkd.AutoSize = True
        Me.dldkd.Depth = 0
        Me.dldkd.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.dldkd.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2
        Me.dldkd.HighEmphasis = True
        Me.dldkd.Location = New System.Drawing.Point(53, 64)
        Me.dldkd.MouseState = MaterialSkin.MouseState.HOVER
        Me.dldkd.Name = "dldkd"
        Me.dldkd.Size = New System.Drawing.Size(58, 17)
        Me.dldkd.TabIndex = 9
        Me.dldkd.Text = "End Date"
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2
        Me.MaterialLabel7.HighEmphasis = True
        Me.MaterialLabel7.Location = New System.Drawing.Point(53, 12)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(65, 17)
        Me.MaterialLabel7.TabIndex = 9
        Me.MaterialLabel7.Text = "Start Date"
        '
        'BTN_stocksdatefilter
        '
        Me.BTN_stocksdatefilter.AutoSize = False
        Me.BTN_stocksdatefilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_stocksdatefilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_stocksdatefilter.Depth = 0
        Me.BTN_stocksdatefilter.HighEmphasis = True
        Me.BTN_stocksdatefilter.Icon = Nothing
        Me.BTN_stocksdatefilter.Location = New System.Drawing.Point(21, 341)
        Me.BTN_stocksdatefilter.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_stocksdatefilter.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_stocksdatefilter.Name = "BTN_stocksdatefilter"
        Me.BTN_stocksdatefilter.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_stocksdatefilter.Size = New System.Drawing.Size(179, 36)
        Me.BTN_stocksdatefilter.TabIndex = 10
        Me.BTN_stocksdatefilter.Text = "Filter by Date "
        Me.BTN_stocksdatefilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_stocksdatefilter.UseAccentColor = False
        Me.BTN_stocksdatefilter.UseVisualStyleBackColor = True
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.AutoSize = True
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2
        Me.MaterialLabel9.Location = New System.Drawing.Point(72, 174)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(75, 17)
        Me.MaterialLabel9.TabIndex = 9
        Me.MaterialLabel9.Text = "Date Added"
        '
        'BTN_productfilter
        '
        Me.BTN_productfilter.AutoSize = False
        Me.BTN_productfilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_productfilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_productfilter.Depth = 0
        Me.BTN_productfilter.HighEmphasis = True
        Me.BTN_productfilter.Icon = Nothing
        Me.BTN_productfilter.Location = New System.Drawing.Point(17, 116)
        Me.BTN_productfilter.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_productfilter.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_productfilter.Name = "BTN_productfilter"
        Me.BTN_productfilter.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_productfilter.Size = New System.Drawing.Size(183, 36)
        Me.BTN_productfilter.TabIndex = 10
        Me.BTN_productfilter.Text = "Filter by Product Name"
        Me.BTN_productfilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_productfilter.UseAccentColor = False
        Me.BTN_productfilter.UseVisualStyleBackColor = True
        '
        'BTN_clearstocksfilter
        '
        Me.BTN_clearstocksfilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_clearstocksfilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_clearstocksfilter.Depth = 0
        Me.BTN_clearstocksfilter.HighEmphasis = True
        Me.BTN_clearstocksfilter.Icon = Nothing
        Me.BTN_clearstocksfilter.Location = New System.Drawing.Point(146, 15)
        Me.BTN_clearstocksfilter.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_clearstocksfilter.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_clearstocksfilter.Name = "BTN_clearstocksfilter"
        Me.BTN_clearstocksfilter.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_clearstocksfilter.Size = New System.Drawing.Size(66, 36)
        Me.BTN_clearstocksfilter.TabIndex = 11
        Me.BTN_clearstocksfilter.Text = "Clear"
        Me.BTN_clearstocksfilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.BTN_clearstocksfilter.UseAccentColor = False
        Me.BTN_clearstocksfilter.UseVisualStyleBackColor = True
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel4.HighEmphasis = True
        Me.MaterialLabel4.Location = New System.Drawing.Point(17, 18)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(57, 24)
        Me.MaterialLabel4.TabIndex = 9
        Me.MaterialLabel4.Text = "Filters"
        '
        'db_inventoryDataSet
        '
        Me.db_inventoryDataSet.DataSetName = "db_inventoryDataSet"
        Me.db_inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbl_transactionsBindingSource
        '
        Me.tbl_transactionsBindingSource.DataMember = "tbl_transactions"
        Me.tbl_transactionsBindingSource.DataSource = Me.db_inventoryDataSet
        '
        'tbl_transactionsTableAdapter
        '
        Me.tbl_transactionsTableAdapter.ClearBeforeFill = True
        '
        'UCRPT_transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.MaterialCard8)
        Me.Controls.Add(Me.RPTV_transactions)
        Me.Name = "UCRPT_transactions"
        Me.Size = New System.Drawing.Size(1039, 530)
        Me.MaterialCard8.ResumeLayout(False)
        Me.MaterialCard8.PerformLayout()
        Me.MaterialCard13.ResumeLayout(False)
        Me.MaterialCard13.PerformLayout()
        CType(Me.db_inventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_transactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RPTV_transactions As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_transactionsBindingSource As BindingSource
    Friend WithEvents db_inventoryDataSet As db_inventoryDataSet
    Friend WithEvents MaterialCard8 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents TXT_product As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialCard13 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents DT_endstocks As DateTimePicker
    Friend WithEvents DT_startstocks As DateTimePicker
    Friend WithEvents dldkd As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents BTN_stocksdatefilter As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents BTN_productfilter As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BTN_clearstocksfilter As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbl_transactionsTableAdapter As db_inventoryDataSetTableAdapters.tbl_transactionsTableAdapter
End Class
