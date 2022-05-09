<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCRPT_students
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
        Me.RPTV_students = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MaterialCard4 = New MaterialSkin.Controls.MaterialCard()
        Me.CBO_college = New MaterialSkin.Controls.MaterialComboBox()
        Me.CBO_course = New MaterialSkin.Controls.MaterialComboBox()
        Me.BTN_filterCollege = New MaterialSkin.Controls.MaterialButton()
        Me.BTN_FilterCourse = New MaterialSkin.Controls.MaterialButton()
        Me.BTN_clearStudentsFilter = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.db_inventoryDataSet = New ITE_5_Project.db_inventoryDataSet()
        Me.tbl_studentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_studentsTableAdapter = New ITE_5_Project.db_inventoryDataSetTableAdapters.tbl_studentsTableAdapter()
        Me.MaterialCard4.SuspendLayout()
        CType(Me.db_inventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_studentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RPTV_students
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tbl_studentsBindingSource
        Me.RPTV_students.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RPTV_students.LocalReport.ReportEmbeddedResource = "ITE_5_Project.RPT_students.rdlc"
        Me.RPTV_students.Location = New System.Drawing.Point(267, 12)
        Me.RPTV_students.Name = "RPTV_students"
        Me.RPTV_students.ServerReport.BearerToken = Nothing
        Me.RPTV_students.Size = New System.Drawing.Size(667, 506)
        Me.RPTV_students.TabIndex = 5
        '
        'MaterialCard4
        '
        Me.MaterialCard4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard4.Controls.Add(Me.CBO_college)
        Me.MaterialCard4.Controls.Add(Me.CBO_course)
        Me.MaterialCard4.Controls.Add(Me.BTN_filterCollege)
        Me.MaterialCard4.Controls.Add(Me.BTN_FilterCourse)
        Me.MaterialCard4.Controls.Add(Me.BTN_clearStudentsFilter)
        Me.MaterialCard4.Controls.Add(Me.MaterialLabel2)
        Me.MaterialCard4.Depth = 0
        Me.MaterialCard4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard4.Location = New System.Drawing.Point(22, 14)
        Me.MaterialCard4.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard4.Name = "MaterialCard4"
        Me.MaterialCard4.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard4.Size = New System.Drawing.Size(228, 502)
        Me.MaterialCard4.TabIndex = 6
        '
        'CBO_college
        '
        Me.CBO_college.AutoResize = False
        Me.CBO_college.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBO_college.Depth = 0
        Me.CBO_college.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CBO_college.DropDownHeight = 174
        Me.CBO_college.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_college.DropDownWidth = 121
        Me.CBO_college.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.CBO_college.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBO_college.FormattingEnabled = True
        Me.CBO_college.Hint = "College"
        Me.CBO_college.IntegralHeight = False
        Me.CBO_college.ItemHeight = 43
        Me.CBO_college.Location = New System.Drawing.Point(21, 51)
        Me.CBO_college.MaxDropDownItems = 4
        Me.CBO_college.MouseState = MaterialSkin.MouseState.OUT
        Me.CBO_college.Name = "CBO_college"
        Me.CBO_college.Size = New System.Drawing.Size(184, 49)
        Me.CBO_college.StartIndex = 0
        Me.CBO_college.TabIndex = 7
        '
        'CBO_course
        '
        Me.CBO_course.AutoResize = False
        Me.CBO_course.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBO_course.Depth = 0
        Me.CBO_course.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.CBO_course.DropDownHeight = 174
        Me.CBO_course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_course.DropDownWidth = 121
        Me.CBO_course.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.CBO_course.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBO_course.FormattingEnabled = True
        Me.CBO_course.Hint = "Course"
        Me.CBO_course.IntegralHeight = False
        Me.CBO_course.ItemHeight = 43
        Me.CBO_course.Location = New System.Drawing.Point(25, 154)
        Me.CBO_course.MaxDropDownItems = 4
        Me.CBO_course.MouseState = MaterialSkin.MouseState.OUT
        Me.CBO_course.Name = "CBO_course"
        Me.CBO_course.Size = New System.Drawing.Size(184, 49)
        Me.CBO_course.StartIndex = 0
        Me.CBO_course.TabIndex = 7
        '
        'BTN_filterCollege
        '
        Me.BTN_filterCollege.AutoSize = False
        Me.BTN_filterCollege.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_filterCollege.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_filterCollege.Depth = 0
        Me.BTN_filterCollege.HighEmphasis = True
        Me.BTN_filterCollege.Icon = Nothing
        Me.BTN_filterCollege.Location = New System.Drawing.Point(24, 109)
        Me.BTN_filterCollege.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_filterCollege.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_filterCollege.Name = "BTN_filterCollege"
        Me.BTN_filterCollege.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_filterCollege.Size = New System.Drawing.Size(181, 36)
        Me.BTN_filterCollege.TabIndex = 5
        Me.BTN_filterCollege.Text = "Filter by College"
        Me.BTN_filterCollege.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_filterCollege.UseAccentColor = False
        Me.BTN_filterCollege.UseVisualStyleBackColor = True
        '
        'BTN_FilterCourse
        '
        Me.BTN_FilterCourse.AutoSize = False
        Me.BTN_FilterCourse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_FilterCourse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_FilterCourse.Depth = 0
        Me.BTN_FilterCourse.HighEmphasis = True
        Me.BTN_FilterCourse.Icon = Nothing
        Me.BTN_FilterCourse.Location = New System.Drawing.Point(25, 212)
        Me.BTN_FilterCourse.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_FilterCourse.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_FilterCourse.Name = "BTN_FilterCourse"
        Me.BTN_FilterCourse.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_FilterCourse.Size = New System.Drawing.Size(181, 36)
        Me.BTN_FilterCourse.TabIndex = 5
        Me.BTN_FilterCourse.Text = "Filter by Course"
        Me.BTN_FilterCourse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BTN_FilterCourse.UseAccentColor = False
        Me.BTN_FilterCourse.UseVisualStyleBackColor = True
        '
        'BTN_clearStudentsFilter
        '
        Me.BTN_clearStudentsFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_clearStudentsFilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_clearStudentsFilter.Depth = 0
        Me.BTN_clearStudentsFilter.HighEmphasis = True
        Me.BTN_clearStudentsFilter.Icon = Nothing
        Me.BTN_clearStudentsFilter.Location = New System.Drawing.Point(153, 10)
        Me.BTN_clearStudentsFilter.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_clearStudentsFilter.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_clearStudentsFilter.Name = "BTN_clearStudentsFilter"
        Me.BTN_clearStudentsFilter.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_clearStudentsFilter.Size = New System.Drawing.Size(66, 36)
        Me.BTN_clearStudentsFilter.TabIndex = 6
        Me.BTN_clearStudentsFilter.Text = "Clear"
        Me.BTN_clearStudentsFilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.BTN_clearStudentsFilter.UseAccentColor = False
        Me.BTN_clearStudentsFilter.UseVisualStyleBackColor = True
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel2.HighEmphasis = True
        Me.MaterialLabel2.Location = New System.Drawing.Point(17, 14)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(57, 24)
        Me.MaterialLabel2.TabIndex = 1
        Me.MaterialLabel2.Text = "Filters"
        '
        'db_inventoryDataSet
        '
        Me.db_inventoryDataSet.DataSetName = "db_inventoryDataSet"
        Me.db_inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbl_studentsBindingSource
        '
        Me.tbl_studentsBindingSource.DataMember = "tbl_students"
        Me.tbl_studentsBindingSource.DataSource = Me.db_inventoryDataSet
        '
        'tbl_studentsTableAdapter
        '
        Me.tbl_studentsTableAdapter.ClearBeforeFill = True
        '
        'UCRPT_students
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.MaterialCard4)
        Me.Controls.Add(Me.RPTV_students)
        Me.Name = "UCRPT_students"
        Me.Size = New System.Drawing.Size(1039, 530)
        Me.MaterialCard4.ResumeLayout(False)
        Me.MaterialCard4.PerformLayout()
        CType(Me.db_inventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_studentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RPTV_students As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MaterialCard4 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents CBO_college As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents CBO_course As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents BTN_filterCollege As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BTN_FilterCourse As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BTN_clearStudentsFilter As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbl_studentsBindingSource As BindingSource
    Friend WithEvents db_inventoryDataSet As db_inventoryDataSet
    Friend WithEvents tbl_studentsTableAdapter As db_inventoryDataSetTableAdapters.tbl_studentsTableAdapter
End Class
