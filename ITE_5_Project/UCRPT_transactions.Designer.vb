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
        Me.tbl_transactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.db_inventoryDataSet = New ITE_5_Project.db_inventoryDataSet()
        Me.RPTV_transactions = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MaterialCard8 = New MaterialSkin.Controls.MaterialCard()
        Me.TXT_productID = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialCard13 = New MaterialSkin.Controls.MaterialCard()
        Me.DT_enddate = New System.Windows.Forms.DateTimePicker()
        Me.DT_startdate = New System.Windows.Forms.DateTimePicker()
        Me.dldkd = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.BTN_datefilter = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.BTN_productfilter = New MaterialSkin.Controls.MaterialButton()
        Me.BN_clear = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbl_transactionsTableAdapter = New ITE_5_Project.db_inventoryDataSetTableAdapters.tbl_transactionsTableAdapter()
        Me.TXT_studentID = New MaterialSkin.Controls.MaterialTextBox2()
        Me.BTN_studentfilter = New MaterialSkin.Controls.MaterialButton()
        CType(Me.tbl_transactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.db_inventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialCard8.SuspendLayout()
        Me.MaterialCard13.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbl_transactionsBindingSource
        '
        Me.tbl_transactionsBindingSource.DataMember = "tbl_transactions"
        Me.tbl_transactionsBindingSource.DataSource = Me.db_inventoryDataSet
        '
        'db_inventoryDataSet
        '
        Me.db_inventoryDataSet.DataSetName = "db_inventoryDataSet"
        Me.db_inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.MaterialCard8.Controls.Add(Me.TXT_studentID)
        Me.MaterialCard8.Controls.Add(Me.BTN_studentfilter)
        Me.MaterialCard8.Controls.Add(Me.TXT_productID)
        Me.MaterialCard8.Controls.Add(Me.MaterialCard13)
        Me.MaterialCard8.Controls.Add(Me.BTN_datefilter)
        Me.MaterialCard8.Controls.Add(Me.MaterialLabel9)
        Me.MaterialCard8.Controls.Add(Me.BTN_productfilter)
        Me.MaterialCard8.Controls.Add(Me.BN_clear)
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
        'TXT_productID
        '
        Me.TXT_productID.AnimateReadOnly = False
        Me.TXT_productID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TXT_productID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXT_productID.Depth = 0
        Me.TXT_productID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_productID.HideSelection = True
        Me.TXT_productID.Hint = "Product ID"
        Me.TXT_productID.LeadingIcon = Nothing
        Me.TXT_productID.Location = New System.Drawing.Point(21, 60)
        Me.TXT_productID.MaxLength = 32767
        Me.TXT_productID.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_productID.Name = "TXT_productID"
        Me.TXT_productID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_productID.PrefixSuffixText = Nothing
        Me.TXT_productID.ReadOnly = False
        Me.TXT_productID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_productID.SelectedText = ""
        Me.TXT_productID.SelectionLength = 0
        Me.TXT_productID.SelectionStart = 0
        Me.TXT_productID.ShortcutsEnabled = True
        Me.TXT_productID.Size = New System.Drawing.Size(178, 48)
        Me.TXT_productID.TabIndex = 14
        Me.TXT_productID.TabStop = False
        Me.TXT_productID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_productID.TrailingIcon = Nothing
        Me.TXT_productID.UseSystemPasswordChar = False
        '
        'MaterialCard13
        '
        Me.MaterialCard13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard13.Controls.Add(Me.DT_enddate)
        Me.MaterialCard13.Controls.Add(Me.DT_startdate)
        Me.MaterialCard13.Controls.Add(Me.dldkd)
        Me.MaterialCard13.Controls.Add(Me.MaterialLabel7)
        Me.MaterialCard13.Depth = 0
        Me.MaterialCard13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard13.Location = New System.Drawing.Point(19, 290)
        Me.MaterialCard13.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard13.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard13.Name = "MaterialCard13"
        Me.MaterialCard13.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard13.Size = New System.Drawing.Size(181, 127)
        Me.MaterialCard13.TabIndex = 13
        '
        'DT_enddate
        '
        Me.DT_enddate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_enddate.Location = New System.Drawing.Point(9, 85)
        Me.DT_enddate.Name = "DT_enddate"
        Me.DT_enddate.Size = New System.Drawing.Size(158, 20)
        Me.DT_enddate.TabIndex = 3
        '
        'DT_startdate
        '
        Me.DT_startdate.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.DT_startdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_startdate.Location = New System.Drawing.Point(11, 33)
        Me.DT_startdate.Name = "DT_startdate"
        Me.DT_startdate.Size = New System.Drawing.Size(153, 20)
        Me.DT_startdate.TabIndex = 2
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
        'BTN_datefilter
        '
        Me.BTN_datefilter.AutoSize = False
        Me.BTN_datefilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_datefilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_datefilter.Depth = 0
        Me.BTN_datefilter.HighEmphasis = True
        Me.BTN_datefilter.Icon = Nothing
        Me.BTN_datefilter.Location = New System.Drawing.Point(21, 432)
        Me.BTN_datefilter.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_datefilter.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_datefilter.Name = "BTN_datefilter"
        Me.BTN_datefilter.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_datefilter.Size = New System.Drawing.Size(179, 36)
        Me.BTN_datefilter.TabIndex = 10
        Me.BTN_datefilter.Text = "Filter by Date "
        Me.BTN_datefilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_datefilter.UseAccentColor = False
        Me.BTN_datefilter.UseVisualStyleBackColor = True
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.AutoSize = True
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2
        Me.MaterialLabel9.Location = New System.Drawing.Point(50, 265)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(111, 17)
        Me.MaterialLabel9.TabIndex = 9
        Me.MaterialLabel9.Text = "Transaction Date"
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
        'BN_clear
        '
        Me.BN_clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BN_clear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BN_clear.Depth = 0
        Me.BN_clear.HighEmphasis = True
        Me.BN_clear.Icon = Nothing
        Me.BN_clear.Location = New System.Drawing.Point(146, 15)
        Me.BN_clear.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BN_clear.MouseState = MaterialSkin.MouseState.HOVER
        Me.BN_clear.Name = "BN_clear"
        Me.BN_clear.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BN_clear.Size = New System.Drawing.Size(66, 36)
        Me.BN_clear.TabIndex = 11
        Me.BN_clear.Text = "Clear"
        Me.BN_clear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.BN_clear.UseAccentColor = False
        Me.BN_clear.UseVisualStyleBackColor = True
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
        'tbl_transactionsTableAdapter
        '
        Me.tbl_transactionsTableAdapter.ClearBeforeFill = True
        '
        'TXT_studentID
        '
        Me.TXT_studentID.AnimateReadOnly = False
        Me.TXT_studentID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TXT_studentID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXT_studentID.Depth = 0
        Me.TXT_studentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_studentID.HideSelection = True
        Me.TXT_studentID.Hint = "Student ID"
        Me.TXT_studentID.LeadingIcon = Nothing
        Me.TXT_studentID.Location = New System.Drawing.Point(20, 161)
        Me.TXT_studentID.MaxLength = 32767
        Me.TXT_studentID.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_studentID.Name = "TXT_studentID"
        Me.TXT_studentID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_studentID.PrefixSuffixText = Nothing
        Me.TXT_studentID.ReadOnly = False
        Me.TXT_studentID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_studentID.SelectedText = ""
        Me.TXT_studentID.SelectionLength = 0
        Me.TXT_studentID.SelectionStart = 0
        Me.TXT_studentID.ShortcutsEnabled = True
        Me.TXT_studentID.Size = New System.Drawing.Size(178, 48)
        Me.TXT_studentID.TabIndex = 16
        Me.TXT_studentID.TabStop = False
        Me.TXT_studentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_studentID.TrailingIcon = Nothing
        Me.TXT_studentID.UseSystemPasswordChar = False
        '
        'BTN_studentfilter
        '
        Me.BTN_studentfilter.AutoSize = False
        Me.BTN_studentfilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_studentfilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_studentfilter.Depth = 0
        Me.BTN_studentfilter.HighEmphasis = True
        Me.BTN_studentfilter.Icon = Nothing
        Me.BTN_studentfilter.Location = New System.Drawing.Point(16, 217)
        Me.BTN_studentfilter.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_studentfilter.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_studentfilter.Name = "BTN_studentfilter"
        Me.BTN_studentfilter.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_studentfilter.Size = New System.Drawing.Size(183, 36)
        Me.BTN_studentfilter.TabIndex = 15
        Me.BTN_studentfilter.Text = "Filter by Student"
        Me.BTN_studentfilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_studentfilter.UseAccentColor = False
        Me.BTN_studentfilter.UseVisualStyleBackColor = True
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
        CType(Me.tbl_transactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.db_inventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialCard8.ResumeLayout(False)
        Me.MaterialCard8.PerformLayout()
        Me.MaterialCard13.ResumeLayout(False)
        Me.MaterialCard13.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RPTV_transactions As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_transactionsBindingSource As BindingSource
    Friend WithEvents db_inventoryDataSet As db_inventoryDataSet
    Friend WithEvents MaterialCard8 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents TXT_productID As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialCard13 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents DT_enddate As DateTimePicker
    Friend WithEvents DT_startdate As DateTimePicker
    Friend WithEvents dldkd As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents BTN_datefilter As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents BTN_productfilter As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BN_clear As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbl_transactionsTableAdapter As db_inventoryDataSetTableAdapters.tbl_transactionsTableAdapter
    Friend WithEvents TXT_studentID As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents BTN_studentfilter As MaterialSkin.Controls.MaterialButton
End Class
