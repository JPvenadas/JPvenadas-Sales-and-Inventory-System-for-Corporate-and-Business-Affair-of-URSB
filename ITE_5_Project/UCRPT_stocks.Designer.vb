<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCRPT_stocks
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
        Me.tbl_stocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.db_inventoryDataSet = New ITE_5_Project.db_inventoryDataSet()
        Me.RPTV_stocks = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MaterialCard8 = New MaterialSkin.Controls.MaterialCard()
        Me.TXT_product = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialCard13 = New MaterialSkin.Controls.MaterialCard()
        Me.DT_endDate = New System.Windows.Forms.DateTimePicker()
        Me.DT_startDate = New System.Windows.Forms.DateTimePicker()
        Me.dldkd = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.BTN_Datefilter = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.BTN_productfilter = New MaterialSkin.Controls.MaterialButton()
        Me.BTN_clear = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbl_stocksTableAdapter = New ITE_5_Project.db_inventoryDataSetTableAdapters.tbl_stocksTableAdapter()
        CType(Me.tbl_stocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.db_inventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialCard8.SuspendLayout()
        Me.MaterialCard13.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbl_stocksBindingSource
        '
        Me.tbl_stocksBindingSource.DataMember = "tbl_stocks"
        Me.tbl_stocksBindingSource.DataSource = Me.db_inventoryDataSet
        '
        'db_inventoryDataSet
        '
        Me.db_inventoryDataSet.DataSetName = "db_inventoryDataSet"
        Me.db_inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RPTV_stocks
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tbl_stocksBindingSource
        Me.RPTV_stocks.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RPTV_stocks.LocalReport.ReportEmbeddedResource = "ITE_5_Project.RPT_stocks.rdlc"
        Me.RPTV_stocks.Location = New System.Drawing.Point(249, 12)
        Me.RPTV_stocks.Name = "RPTV_stocks"
        Me.RPTV_stocks.ServerReport.BearerToken = Nothing
        Me.RPTV_stocks.Size = New System.Drawing.Size(680, 506)
        Me.RPTV_stocks.TabIndex = 5
        '
        'MaterialCard8
        '
        Me.MaterialCard8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard8.Controls.Add(Me.TXT_product)
        Me.MaterialCard8.Controls.Add(Me.MaterialCard13)
        Me.MaterialCard8.Controls.Add(Me.BTN_Datefilter)
        Me.MaterialCard8.Controls.Add(Me.MaterialLabel9)
        Me.MaterialCard8.Controls.Add(Me.BTN_productfilter)
        Me.MaterialCard8.Controls.Add(Me.BTN_clear)
        Me.MaterialCard8.Controls.Add(Me.MaterialLabel4)
        Me.MaterialCard8.Depth = 0
        Me.MaterialCard8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard8.Location = New System.Drawing.Point(13, 13)
        Me.MaterialCard8.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard8.Name = "MaterialCard8"
        Me.MaterialCard8.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard8.Size = New System.Drawing.Size(228, 503)
        Me.MaterialCard8.TabIndex = 6
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
        Me.MaterialCard13.Controls.Add(Me.DT_endDate)
        Me.MaterialCard13.Controls.Add(Me.DT_startDate)
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
        'DT_endDate
        '
        Me.DT_endDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_endDate.Location = New System.Drawing.Point(9, 85)
        Me.DT_endDate.Name = "DT_endDate"
        Me.DT_endDate.Size = New System.Drawing.Size(158, 20)
        Me.DT_endDate.TabIndex = 3
        '
        'DT_startDate
        '
        Me.DT_startDate.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.DT_startDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_startDate.Location = New System.Drawing.Point(11, 33)
        Me.DT_startDate.Name = "DT_startDate"
        Me.DT_startDate.Size = New System.Drawing.Size(153, 20)
        Me.DT_startDate.TabIndex = 2
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
        'BTN_Datefilter
        '
        Me.BTN_Datefilter.AutoSize = False
        Me.BTN_Datefilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_Datefilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_Datefilter.Depth = 0
        Me.BTN_Datefilter.HighEmphasis = True
        Me.BTN_Datefilter.Icon = Nothing
        Me.BTN_Datefilter.Location = New System.Drawing.Point(21, 341)
        Me.BTN_Datefilter.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_Datefilter.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_Datefilter.Name = "BTN_Datefilter"
        Me.BTN_Datefilter.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_Datefilter.Size = New System.Drawing.Size(179, 36)
        Me.BTN_Datefilter.TabIndex = 10
        Me.BTN_Datefilter.Text = "Filter by Date "
        Me.BTN_Datefilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_Datefilter.UseAccentColor = False
        Me.BTN_Datefilter.UseVisualStyleBackColor = True
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
        Me.BTN_productfilter.Text = "Filter by Product"
        Me.BTN_productfilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_productfilter.UseAccentColor = False
        Me.BTN_productfilter.UseVisualStyleBackColor = True
        '
        'BTN_clear
        '
        Me.BTN_clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_clear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_clear.Depth = 0
        Me.BTN_clear.HighEmphasis = True
        Me.BTN_clear.Icon = Nothing
        Me.BTN_clear.Location = New System.Drawing.Point(146, 15)
        Me.BTN_clear.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_clear.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_clear.Name = "BTN_clear"
        Me.BTN_clear.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_clear.Size = New System.Drawing.Size(66, 36)
        Me.BTN_clear.TabIndex = 11
        Me.BTN_clear.Text = "Clear"
        Me.BTN_clear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.BTN_clear.UseAccentColor = False
        Me.BTN_clear.UseVisualStyleBackColor = True
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
        'tbl_stocksTableAdapter
        '
        Me.tbl_stocksTableAdapter.ClearBeforeFill = True
        '
        'UCRPT_stocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.MaterialCard8)
        Me.Controls.Add(Me.RPTV_stocks)
        Me.Name = "UCRPT_stocks"
        Me.Size = New System.Drawing.Size(1039, 530)
        CType(Me.tbl_stocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.db_inventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialCard8.ResumeLayout(False)
        Me.MaterialCard8.PerformLayout()
        Me.MaterialCard13.ResumeLayout(False)
        Me.MaterialCard13.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RPTV_stocks As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MaterialCard8 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents TXT_product As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialCard13 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents DT_endDate As DateTimePicker
    Friend WithEvents DT_startDate As DateTimePicker
    Friend WithEvents dldkd As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents BTN_Datefilter As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents BTN_productfilter As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BTN_clear As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbl_stocksBindingSource As BindingSource
    Friend WithEvents db_inventoryDataSet As db_inventoryDataSet
    Friend WithEvents tbl_stocksTableAdapter As db_inventoryDataSetTableAdapters.tbl_stocksTableAdapter
End Class
