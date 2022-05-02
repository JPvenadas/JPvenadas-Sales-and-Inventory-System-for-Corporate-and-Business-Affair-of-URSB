<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_settings
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
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TAB_colleges = New System.Windows.Forms.TabPage()
        Me.TAB_courses = New System.Windows.Forms.TabPage()
        Me.TAB_categories = New System.Windows.Forms.TabPage()
        Me.TblcategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LBL_settings = New System.Windows.Forms.Label()
        Me.Tbl_categoriesTableAdapter = New ITE_5_Project.db_inventoryDataSetTableAdapters.tbl_categoriesTableAdapter()
        Me.MaterialTabControl1.SuspendLayout()
        CType(Me.TblcategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(13, 45)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(550, 31)
        Me.MaterialTabSelector1.TabIndex = 0
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TAB_colleges)
        Me.MaterialTabControl1.Controls.Add(Me.TAB_courses)
        Me.MaterialTabControl1.Controls.Add(Me.TAB_categories)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(13, 82)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Multiline = True
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(972, 486)
        Me.MaterialTabControl1.TabIndex = 1
        '
        'TAB_colleges
        '
        Me.TAB_colleges.BackColor = System.Drawing.Color.White
        Me.TAB_colleges.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TAB_colleges.Location = New System.Drawing.Point(4, 22)
        Me.TAB_colleges.Name = "TAB_colleges"
        Me.TAB_colleges.Padding = New System.Windows.Forms.Padding(3)
        Me.TAB_colleges.Size = New System.Drawing.Size(964, 460)
        Me.TAB_colleges.TabIndex = 0
        Me.TAB_colleges.Text = "Colleges"
        '
        'TAB_courses
        '
        Me.TAB_courses.BackColor = System.Drawing.Color.White
        Me.TAB_courses.Location = New System.Drawing.Point(4, 22)
        Me.TAB_courses.Name = "TAB_courses"
        Me.TAB_courses.Padding = New System.Windows.Forms.Padding(3)
        Me.TAB_courses.Size = New System.Drawing.Size(964, 460)
        Me.TAB_courses.TabIndex = 1
        Me.TAB_courses.Text = "Courses"
        '
        'TAB_categories
        '
        Me.TAB_categories.BackColor = System.Drawing.Color.White
        Me.TAB_categories.Location = New System.Drawing.Point(4, 22)
        Me.TAB_categories.Name = "TAB_categories"
        Me.TAB_categories.Size = New System.Drawing.Size(964, 460)
        Me.TAB_categories.TabIndex = 2
        Me.TAB_categories.Text = "Product Categories"
        '
        'LBL_settings
        '
        Me.LBL_settings.AutoSize = True
        Me.LBL_settings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_settings.Location = New System.Drawing.Point(22, 13)
        Me.LBL_settings.Name = "LBL_settings"
        Me.LBL_settings.Size = New System.Drawing.Size(76, 20)
        Me.LBL_settings.TabIndex = 2
        Me.LBL_settings.Text = "Settings"
        '
        'Tbl_categoriesTableAdapter
        '
        Me.Tbl_categoriesTableAdapter.ClearBeforeFill = True
        '
        'UC_settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.LBL_settings)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Name = "UC_settings"
        Me.Size = New System.Drawing.Size(1039, 581)
        Me.MaterialTabControl1.ResumeLayout(False)
        CType(Me.TblcategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TAB_colleges As TabPage
    Friend WithEvents TAB_courses As TabPage
    Friend WithEvents TAB_categories As TabPage
    Friend WithEvents LBL_settings As Label
    Friend WithEvents TblcategoriesBindingSource As BindingSource
    Friend WithEvents Tbl_categoriesTableAdapter As db_inventoryDataSetTableAdapters.tbl_categoriesTableAdapter
End Class
