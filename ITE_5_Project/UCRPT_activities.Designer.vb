<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCRPT_activities
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tbl_activitiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.db_inventoryDataSet = New ITE_5_Project.db_inventoryDataSet()
        Me.RPTV_activities = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MaterialCard8 = New MaterialSkin.Controls.MaterialCard()
        Me.TXT_username = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialCard13 = New MaterialSkin.Controls.MaterialCard()
        Me.DT_enddate = New System.Windows.Forms.DateTimePicker()
        Me.DT_startdate = New System.Windows.Forms.DateTimePicker()
        Me.dldkd = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.BTN_datefilter = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.BTN_userfilter = New MaterialSkin.Controls.MaterialButton()
        Me.BTN_clearstocksfilter = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbl_activitiesTableAdapter = New ITE_5_Project.db_inventoryDataSetTableAdapters.tbl_activitiesTableAdapter()
        CType(Me.tbl_activitiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.db_inventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialCard8.SuspendLayout()
        Me.MaterialCard13.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbl_activitiesBindingSource
        '
        Me.tbl_activitiesBindingSource.DataMember = "tbl_activities"
        Me.tbl_activitiesBindingSource.DataSource = Me.db_inventoryDataSet
        '
        'db_inventoryDataSet
        '
        Me.db_inventoryDataSet.DataSetName = "db_inventoryDataSet"
        Me.db_inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RPTV_activities
        '
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.tbl_activitiesBindingSource
        Me.RPTV_activities.LocalReport.DataSources.Add(ReportDataSource3)
        Me.RPTV_activities.LocalReport.ReportEmbeddedResource = "ITE_5_Project.RPT_activities.rdlc"
        Me.RPTV_activities.Location = New System.Drawing.Point(255, 12)
        Me.RPTV_activities.Name = "RPTV_activities"
        Me.RPTV_activities.ServerReport.BearerToken = Nothing
        Me.RPTV_activities.Size = New System.Drawing.Size(680, 506)
        Me.RPTV_activities.TabIndex = 5
        '
        'MaterialCard8
        '
        Me.MaterialCard8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard8.Controls.Add(Me.TXT_username)
        Me.MaterialCard8.Controls.Add(Me.MaterialCard13)
        Me.MaterialCard8.Controls.Add(Me.BTN_datefilter)
        Me.MaterialCard8.Controls.Add(Me.MaterialLabel9)
        Me.MaterialCard8.Controls.Add(Me.BTN_userfilter)
        Me.MaterialCard8.Controls.Add(Me.BTN_clearstocksfilter)
        Me.MaterialCard8.Controls.Add(Me.MaterialLabel4)
        Me.MaterialCard8.Depth = 0
        Me.MaterialCard8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard8.Location = New System.Drawing.Point(14, 12)
        Me.MaterialCard8.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard8.Name = "MaterialCard8"
        Me.MaterialCard8.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard8.Size = New System.Drawing.Size(228, 525)
        Me.MaterialCard8.TabIndex = 6
        '
        'TXT_username
        '
        Me.TXT_username.AnimateReadOnly = False
        Me.TXT_username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TXT_username.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXT_username.Depth = 0
        Me.TXT_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXT_username.HideSelection = True
        Me.TXT_username.Hint = "User Name"
        Me.TXT_username.LeadingIcon = Nothing
        Me.TXT_username.Location = New System.Drawing.Point(21, 60)
        Me.TXT_username.MaxLength = 32767
        Me.TXT_username.MouseState = MaterialSkin.MouseState.OUT
        Me.TXT_username.Name = "TXT_username"
        Me.TXT_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_username.PrefixSuffixText = Nothing
        Me.TXT_username.ReadOnly = False
        Me.TXT_username.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_username.SelectedText = ""
        Me.TXT_username.SelectionLength = 0
        Me.TXT_username.SelectionStart = 0
        Me.TXT_username.ShortcutsEnabled = True
        Me.TXT_username.Size = New System.Drawing.Size(178, 48)
        Me.TXT_username.TabIndex = 14
        Me.TXT_username.TabStop = False
        Me.TXT_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXT_username.TrailingIcon = Nothing
        Me.TXT_username.UseSystemPasswordChar = False
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
        Me.MaterialCard13.Location = New System.Drawing.Point(19, 199)
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
        Me.BTN_datefilter.Location = New System.Drawing.Point(21, 341)
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
        Me.MaterialLabel9.Location = New System.Drawing.Point(72, 174)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(82, 17)
        Me.MaterialLabel9.TabIndex = 9
        Me.MaterialLabel9.Text = "Activity Date"
        '
        'BTN_userfilter
        '
        Me.BTN_userfilter.AutoSize = False
        Me.BTN_userfilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_userfilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_userfilter.Depth = 0
        Me.BTN_userfilter.HighEmphasis = True
        Me.BTN_userfilter.Icon = Nothing
        Me.BTN_userfilter.Location = New System.Drawing.Point(17, 116)
        Me.BTN_userfilter.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_userfilter.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_userfilter.Name = "BTN_userfilter"
        Me.BTN_userfilter.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_userfilter.Size = New System.Drawing.Size(183, 36)
        Me.BTN_userfilter.TabIndex = 10
        Me.BTN_userfilter.Text = "Filter by user"
        Me.BTN_userfilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_userfilter.UseAccentColor = False
        Me.BTN_userfilter.UseVisualStyleBackColor = True
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
        'tbl_activitiesTableAdapter
        '
        Me.tbl_activitiesTableAdapter.ClearBeforeFill = True
        '
        'UCRPT_activities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.MaterialCard8)
        Me.Controls.Add(Me.RPTV_activities)
        Me.Name = "UCRPT_activities"
        Me.Size = New System.Drawing.Size(1039, 530)
        CType(Me.tbl_activitiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.db_inventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialCard8.ResumeLayout(False)
        Me.MaterialCard8.PerformLayout()
        Me.MaterialCard13.ResumeLayout(False)
        Me.MaterialCard13.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RPTV_activities As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MaterialCard8 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents TXT_username As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialCard13 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents DT_enddate As DateTimePicker
    Friend WithEvents DT_startdate As DateTimePicker
    Friend WithEvents dldkd As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents BTN_datefilter As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents BTN_userfilter As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BTN_clearstocksfilter As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbl_activitiesBindingSource As BindingSource
    Friend WithEvents db_inventoryDataSet As db_inventoryDataSet
    Friend WithEvents tbl_activitiesTableAdapter As db_inventoryDataSetTableAdapters.tbl_activitiesTableAdapter
End Class
