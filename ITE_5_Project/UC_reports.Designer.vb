<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_reports
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
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TAB_RPT_users = New System.Windows.Forms.TabPage()
        Me.TAB_RPT_students = New System.Windows.Forms.TabPage()
        Me.TAB_RPT_products = New System.Windows.Forms.TabPage()
        Me.TAB_RPT_stocks = New System.Windows.Forms.TabPage()
        Me.TAB_RPT_transactions = New System.Windows.Forms.TabPage()
        Me.TAB_RPT_others = New System.Windows.Forms.TabPage()
        Me.MaterialTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MaterialTabSelector1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 0)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(1039, 30)
        Me.MaterialTabSelector1.TabIndex = 0
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TAB_RPT_users)
        Me.MaterialTabControl1.Controls.Add(Me.TAB_RPT_students)
        Me.MaterialTabControl1.Controls.Add(Me.TAB_RPT_products)
        Me.MaterialTabControl1.Controls.Add(Me.TAB_RPT_stocks)
        Me.MaterialTabControl1.Controls.Add(Me.TAB_RPT_transactions)
        Me.MaterialTabControl1.Controls.Add(Me.TAB_RPT_others)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialTabControl1.Location = New System.Drawing.Point(0, 30)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Multiline = True
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(1039, 551)
        Me.MaterialTabControl1.TabIndex = 1
        '
        'TAB_RPT_users
        '
        Me.TAB_RPT_users.Location = New System.Drawing.Point(4, 22)
        Me.TAB_RPT_users.Name = "TAB_RPT_users"
        Me.TAB_RPT_users.Padding = New System.Windows.Forms.Padding(3)
        Me.TAB_RPT_users.Size = New System.Drawing.Size(1031, 525)
        Me.TAB_RPT_users.TabIndex = 0
        Me.TAB_RPT_users.Text = "Users"
        Me.TAB_RPT_users.UseVisualStyleBackColor = True
        '
        'TAB_RPT_students
        '
        Me.TAB_RPT_students.Location = New System.Drawing.Point(4, 22)
        Me.TAB_RPT_students.Name = "TAB_RPT_students"
        Me.TAB_RPT_students.Padding = New System.Windows.Forms.Padding(3)
        Me.TAB_RPT_students.Size = New System.Drawing.Size(1031, 525)
        Me.TAB_RPT_students.TabIndex = 1
        Me.TAB_RPT_students.Text = "Students"
        Me.TAB_RPT_students.UseVisualStyleBackColor = True
        '
        'TAB_RPT_products
        '
        Me.TAB_RPT_products.Location = New System.Drawing.Point(4, 22)
        Me.TAB_RPT_products.Name = "TAB_RPT_products"
        Me.TAB_RPT_products.Size = New System.Drawing.Size(1031, 525)
        Me.TAB_RPT_products.TabIndex = 2
        Me.TAB_RPT_products.Text = "Products"
        Me.TAB_RPT_products.UseVisualStyleBackColor = True
        '
        'TAB_RPT_stocks
        '
        Me.TAB_RPT_stocks.Location = New System.Drawing.Point(4, 22)
        Me.TAB_RPT_stocks.Name = "TAB_RPT_stocks"
        Me.TAB_RPT_stocks.Size = New System.Drawing.Size(1031, 525)
        Me.TAB_RPT_stocks.TabIndex = 3
        Me.TAB_RPT_stocks.Text = "Stocks"
        Me.TAB_RPT_stocks.UseVisualStyleBackColor = True
        '
        'TAB_RPT_transactions
        '
        Me.TAB_RPT_transactions.Location = New System.Drawing.Point(4, 22)
        Me.TAB_RPT_transactions.Name = "TAB_RPT_transactions"
        Me.TAB_RPT_transactions.Size = New System.Drawing.Size(1031, 525)
        Me.TAB_RPT_transactions.TabIndex = 4
        Me.TAB_RPT_transactions.Text = "Transactions"
        Me.TAB_RPT_transactions.UseVisualStyleBackColor = True
        '
        'TAB_RPT_others
        '
        Me.TAB_RPT_others.Location = New System.Drawing.Point(4, 22)
        Me.TAB_RPT_others.Name = "TAB_RPT_others"
        Me.TAB_RPT_others.Size = New System.Drawing.Size(1031, 525)
        Me.TAB_RPT_others.TabIndex = 5
        Me.TAB_RPT_others.Text = "Others"
        Me.TAB_RPT_others.UseVisualStyleBackColor = True
        '
        'UC_reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Name = "UC_reports"
        Me.Size = New System.Drawing.Size(1039, 581)
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TAB_RPT_users As TabPage
    Friend WithEvents TAB_RPT_students As TabPage
    Friend WithEvents TAB_RPT_products As TabPage
    Friend WithEvents TAB_RPT_stocks As TabPage
    Friend WithEvents TAB_RPT_transactions As TabPage
    Friend WithEvents TAB_RPT_others As TabPage
End Class
