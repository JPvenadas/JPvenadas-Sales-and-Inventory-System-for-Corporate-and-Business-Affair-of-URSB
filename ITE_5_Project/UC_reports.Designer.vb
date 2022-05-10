<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_reports
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
        Me.BTN_activities = New MaterialSkin.Controls.MaterialButton()
        Me.BTN_students = New MaterialSkin.Controls.MaterialButton()
        Me.BTN_products = New MaterialSkin.Controls.MaterialButton()
        Me.BTN_stocks = New MaterialSkin.Controls.MaterialButton()
        Me.BTN_transactions = New MaterialSkin.Controls.MaterialButton()
        Me.BTN_users = New MaterialSkin.Controls.MaterialButton()
        Me.PNL_reportcontainer = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'BTN_activities
        '
        Me.BTN_activities.AutoSize = False
        Me.BTN_activities.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_activities.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_activities.Depth = 0
        Me.BTN_activities.HighEmphasis = True
        Me.BTN_activities.Icon = Nothing
        Me.BTN_activities.Location = New System.Drawing.Point(665, 6)
        Me.BTN_activities.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_activities.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_activities.Name = "BTN_activities"
        Me.BTN_activities.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_activities.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_activities.Size = New System.Drawing.Size(122, 36)
        Me.BTN_activities.TabIndex = 6
        Me.BTN_activities.Text = "Activity logs"
        Me.BTN_activities.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.BTN_activities.UseAccentColor = False
        Me.BTN_activities.UseVisualStyleBackColor = True
        '
        'BTN_students
        '
        Me.BTN_students.AutoSize = False
        Me.BTN_students.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_students.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_students.Depth = 0
        Me.BTN_students.HighEmphasis = True
        Me.BTN_students.Icon = Nothing
        Me.BTN_students.Location = New System.Drawing.Point(144, 6)
        Me.BTN_students.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_students.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_students.Name = "BTN_students"
        Me.BTN_students.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_students.Size = New System.Drawing.Size(122, 36)
        Me.BTN_students.TabIndex = 2
        Me.BTN_students.Text = "Students"
        Me.BTN_students.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.BTN_students.UseAccentColor = False
        Me.BTN_students.UseVisualStyleBackColor = True
        '
        'BTN_products
        '
        Me.BTN_products.AutoSize = False
        Me.BTN_products.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_products.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_products.Depth = 0
        Me.BTN_products.HighEmphasis = True
        Me.BTN_products.Icon = Nothing
        Me.BTN_products.Location = New System.Drawing.Point(274, 6)
        Me.BTN_products.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_products.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_products.Name = "BTN_products"
        Me.BTN_products.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_products.Size = New System.Drawing.Size(122, 36)
        Me.BTN_products.TabIndex = 3
        Me.BTN_products.Text = "Products"
        Me.BTN_products.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.BTN_products.UseAccentColor = False
        Me.BTN_products.UseVisualStyleBackColor = True
        '
        'BTN_stocks
        '
        Me.BTN_stocks.AutoSize = False
        Me.BTN_stocks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_stocks.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_stocks.Depth = 0
        Me.BTN_stocks.HighEmphasis = True
        Me.BTN_stocks.Icon = Nothing
        Me.BTN_stocks.Location = New System.Drawing.Point(404, 6)
        Me.BTN_stocks.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_stocks.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_stocks.Name = "BTN_stocks"
        Me.BTN_stocks.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_stocks.Size = New System.Drawing.Size(122, 36)
        Me.BTN_stocks.TabIndex = 4
        Me.BTN_stocks.Text = "Stocks"
        Me.BTN_stocks.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.BTN_stocks.UseAccentColor = False
        Me.BTN_stocks.UseVisualStyleBackColor = True
        '
        'BTN_transactions
        '
        Me.BTN_transactions.AutoSize = False
        Me.BTN_transactions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_transactions.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_transactions.Depth = 0
        Me.BTN_transactions.HighEmphasis = True
        Me.BTN_transactions.Icon = Nothing
        Me.BTN_transactions.Location = New System.Drawing.Point(534, 6)
        Me.BTN_transactions.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_transactions.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_transactions.Name = "BTN_transactions"
        Me.BTN_transactions.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_transactions.Size = New System.Drawing.Size(122, 36)
        Me.BTN_transactions.TabIndex = 5
        Me.BTN_transactions.Text = "Transactions"
        Me.BTN_transactions.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.BTN_transactions.UseAccentColor = False
        Me.BTN_transactions.UseVisualStyleBackColor = True
        '
        'BTN_users
        '
        Me.BTN_users.AutoSize = False
        Me.BTN_users.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_users.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BTN_users.Depth = 0
        Me.BTN_users.HighEmphasis = True
        Me.BTN_users.Icon = Nothing
        Me.BTN_users.Location = New System.Drawing.Point(29, 6)
        Me.BTN_users.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BTN_users.MouseState = MaterialSkin.MouseState.HOVER
        Me.BTN_users.Name = "BTN_users"
        Me.BTN_users.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BTN_users.Size = New System.Drawing.Size(122, 36)
        Me.BTN_users.TabIndex = 1
        Me.BTN_users.Text = "Users"
        Me.BTN_users.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.BTN_users.UseAccentColor = False
        Me.BTN_users.UseVisualStyleBackColor = True
        '
        'PNL_reportcontainer
        '
        Me.PNL_reportcontainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PNL_reportcontainer.Location = New System.Drawing.Point(0, 51)
        Me.PNL_reportcontainer.Name = "PNL_reportcontainer"
        Me.PNL_reportcontainer.Size = New System.Drawing.Size(1039, 530)
        Me.PNL_reportcontainer.TabIndex = 1
        '
        'UC_reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PNL_reportcontainer)
        Me.Controls.Add(Me.BTN_users)
        Me.Controls.Add(Me.BTN_transactions)
        Me.Controls.Add(Me.BTN_stocks)
        Me.Controls.Add(Me.BTN_products)
        Me.Controls.Add(Me.BTN_students)
        Me.Controls.Add(Me.BTN_activities)
        Me.Name = "UC_reports"
        Me.Size = New System.Drawing.Size(1039, 581)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTN_activities As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BTN_students As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BTN_products As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BTN_stocks As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BTN_transactions As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BTN_users As MaterialSkin.Controls.MaterialButton
    Friend WithEvents PNL_reportcontainer As Panel
End Class
