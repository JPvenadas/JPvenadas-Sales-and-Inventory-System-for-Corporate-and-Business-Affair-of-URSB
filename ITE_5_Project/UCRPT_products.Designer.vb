<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCRPT_products
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tbl_productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.db_inventoryDataSet = New ITE_5_Project.db_inventoryDataSet()
        Me.RPTV_products = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MaterialCard6 = New MaterialSkin.Controls.MaterialCard()
        Me.CBO_pcategory = New MaterialSkin.Controls.MaterialComboBox()
        Me.BTN_filter = New MaterialSkin.Controls.MaterialButton()
        Me.BTN_clear = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbl_productsTableAdapter = New ITE_5_Project.db_inventoryDataSetTableAdapters.tbl_productsTableAdapter()
        CType(Me.tbl_productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.db_inventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialCard6.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbl_productsBindingSource
        '
        Me.tbl_productsBindingSource.DataMember = "tbl_products"
        Me.tbl_productsBindingSource.DataSource = Me.db_inventoryDataSet
        '
        'db_inventoryDataSet
        '
        Me.db_inventoryDataSet.DataSetName = "db_inventoryDataSet"
        Me.db_inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RPTV_products
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.tbl_productsBindingSource
        Me.RPTV_products.LocalReport.DataSources.Add(ReportDataSource2)
        Me.RPTV_products.LocalReport.ReportEmbeddedResource = "ITE_5_Project.RPT_products.rdlc"
        Me.RPTV_products.Location = New System.Drawing.Point(252, 10)
        Me.RPTV_products.Name = "RPTV_products"
        Me.RPTV_products.ServerReport.BearerToken = Nothing
        Me.RPTV_products.Size = New System.Drawing.Size(680, 506)
        Me.RPTV_products.TabIndex = 4
        '
        'MaterialCard6
        '
        Me.MaterialCard6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard6.Controls.Add(Me.CBO_pcategory)
        Me.MaterialCard6.Controls.Add(Me.BTN_filter)
        Me.MaterialCard6.Controls.Add(Me.BTN_clear)
        Me.MaterialCard6.Controls.Add(Me.MaterialLabel3)
        Me.MaterialCard6.Depth = 0
        Me.MaterialCard6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard6.Location = New System.Drawing.Point(14, 10)
        Me.MaterialCard6.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard6.Name = "MaterialCard6"
        Me.MaterialCard6.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard6.Size = New System.Drawing.Size(228, 520)
        Me.MaterialCard6.TabIndex = 5
        '
        'CBO_pcategory
        '
        Me.CBO_pcategory.AutoResize = False
        Me.CBO_pcategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBO_pcategory.Depth = 0
        Me.CBO_pcategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CBO_pcategory.DropDownHeight = 174
        Me.CBO_pcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_pcategory.DropDownWidth = 121
        Me.CBO_pcategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.CBO_pcategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBO_pcategory.FormattingEnabled = True
        Me.CBO_pcategory.Hint = "Product Category"
        Me.CBO_pcategory.IntegralHeight = False
        Me.CBO_pcategory.ItemHeight = 43
        Me.CBO_pcategory.Location = New System.Drawing.Point(17, 54)
        Me.CBO_pcategory.MaxDropDownItems = 4
        Me.CBO_pcategory.MouseState = MaterialSkin.MouseState.OUT
        Me.CBO_pcategory.Name = "CBO_pcategory"
        Me.CBO_pcategory.Size = New System.Drawing.Size(184, 49)
        Me.CBO_pcategory.StartIndex = 0
        Me.CBO_pcategory.TabIndex = 8
        '
        'BTN_filter
        '
        Me.BTN_filter.AutoSize = False
        Me.BTN_filter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_filter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_filter.Depth = 0
        Me.BTN_filter.HighEmphasis = True
        Me.BTN_filter.Icon = Nothing
        Me.BTN_filter.Location = New System.Drawing.Point(35, 111)
        Me.BTN_filter.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_filter.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_filter.Name = "BTN_filter"
        Me.BTN_filter.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_filter.Size = New System.Drawing.Size(150, 36)
        Me.BTN_filter.TabIndex = 6
        Me.BTN_filter.Text = "Filter"
        Me.BTN_filter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_filter.UseAccentColor = False
        Me.BTN_filter.UseVisualStyleBackColor = True
        '
        'BTN_clear
        '
        Me.BTN_clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_clear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_clear.Depth = 0
        Me.BTN_clear.HighEmphasis = True
        Me.BTN_clear.Icon = Nothing
        Me.BTN_clear.Location = New System.Drawing.Point(146, 10)
        Me.BTN_clear.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_clear.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_clear.Name = "BTN_clear"
        Me.BTN_clear.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_clear.Size = New System.Drawing.Size(66, 36)
        Me.BTN_clear.TabIndex = 7
        Me.BTN_clear.Text = "Clear"
        Me.BTN_clear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.BTN_clear.UseAccentColor = False
        Me.BTN_clear.UseVisualStyleBackColor = True
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel3.HighEmphasis = True
        Me.MaterialLabel3.Location = New System.Drawing.Point(17, 13)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(57, 24)
        Me.MaterialLabel3.TabIndex = 5
        Me.MaterialLabel3.Text = "Filters"
        '
        'tbl_productsTableAdapter
        '
        Me.tbl_productsTableAdapter.ClearBeforeFill = True
        '
        'UCRPT_products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.MaterialCard6)
        Me.Controls.Add(Me.RPTV_products)
        Me.Name = "UCRPT_products"
        Me.Size = New System.Drawing.Size(1039, 530)
        CType(Me.tbl_productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.db_inventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialCard6.ResumeLayout(False)
        Me.MaterialCard6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RPTV_products As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MaterialCard6 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents CBO_pcategory As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents BTN_filter As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BTN_clear As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbl_productsBindingSource As BindingSource
    Friend WithEvents db_inventoryDataSet As db_inventoryDataSet
    Friend WithEvents tbl_productsTableAdapter As db_inventoryDataSetTableAdapters.tbl_productsTableAdapter
End Class
