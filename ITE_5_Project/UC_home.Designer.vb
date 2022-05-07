<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_home
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_home))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialCard6 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialCard7 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialCard8 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialCard3 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialCard4 = New MaterialSkin.Controls.MaterialCard()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBL_username = New System.Windows.Forms.Label()
        Me.LBL_usertype = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.LBL_students = New System.Windows.Forms.Label()
        Me.LBL_products = New System.Windows.Forms.Label()
        Me.LBL_users = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.LST_products = New MaterialSkin.Controls.MaterialListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LBL_greetings = New System.Windows.Forms.Label()
        Me.MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.MaterialCard1.SuspendLayout()
        Me.MaterialCard2.SuspendLayout()
        Me.MaterialCard6.SuspendLayout()
        Me.MaterialCard7.SuspendLayout()
        Me.MaterialCard8.SuspendLayout()
        Me.MaterialCard3.SuspendLayout()
        Me.MaterialCard4.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(375, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(602, 218)
        Me.Panel1.TabIndex = 0
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.LBL_greetings)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(14, 9)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(901, 41)
        Me.MaterialCard1.TabIndex = 1
        '
        'MaterialCard2
        '
        Me.MaterialCard2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard2.Controls.Add(Me.LBL_students)
        Me.MaterialCard2.Controls.Add(Me.Panel8)
        Me.MaterialCard2.Controls.Add(Me.Panel5)
        Me.MaterialCard2.Depth = 0
        Me.MaterialCard2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard2.Location = New System.Drawing.Point(379, 286)
        Me.MaterialCard2.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard2.Name = "MaterialCard2"
        Me.MaterialCard2.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.Size = New System.Drawing.Size(185, 94)
        Me.MaterialCard2.TabIndex = 2
        '
        'MaterialCard6
        '
        Me.MaterialCard6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard6.Controls.Add(Me.LBL_usertype)
        Me.MaterialCard6.Controls.Add(Me.LBL_username)
        Me.MaterialCard6.Controls.Add(Me.Panel4)
        Me.MaterialCard6.Depth = 0
        Me.MaterialCard6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard6.Location = New System.Drawing.Point(14, 58)
        Me.MaterialCard6.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard6.Name = "MaterialCard6"
        Me.MaterialCard6.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard6.Size = New System.Drawing.Size(344, 102)
        Me.MaterialCard6.TabIndex = 3
        '
        'MaterialCard7
        '
        Me.MaterialCard7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard7.Controls.Add(Me.Label10)
        Me.MaterialCard7.Controls.Add(Me.LST_products)
        Me.MaterialCard7.Controls.Add(Me.Chart2)
        Me.MaterialCard7.Depth = 0
        Me.MaterialCard7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard7.Location = New System.Drawing.Point(14, 175)
        Me.MaterialCard7.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard7.Name = "MaterialCard7"
        Me.MaterialCard7.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard7.Size = New System.Drawing.Size(344, 368)
        Me.MaterialCard7.TabIndex = 3
        '
        'MaterialCard8
        '
        Me.MaterialCard8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard8.Controls.Add(Me.Chart1)
        Me.MaterialCard8.Depth = 0
        Me.MaterialCard8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard8.Location = New System.Drawing.Point(375, 396)
        Me.MaterialCard8.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard8.Name = "MaterialCard8"
        Me.MaterialCard8.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard8.Size = New System.Drawing.Size(602, 147)
        Me.MaterialCard8.TabIndex = 4
        '
        'MaterialCard3
        '
        Me.MaterialCard3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard3.Controls.Add(Me.LBL_products)
        Me.MaterialCard3.Controls.Add(Me.Panel9)
        Me.MaterialCard3.Controls.Add(Me.Panel6)
        Me.MaterialCard3.Depth = 0
        Me.MaterialCard3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard3.Location = New System.Drawing.Point(581, 286)
        Me.MaterialCard3.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard3.Name = "MaterialCard3"
        Me.MaterialCard3.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard3.Size = New System.Drawing.Size(189, 94)
        Me.MaterialCard3.TabIndex = 2
        '
        'MaterialCard4
        '
        Me.MaterialCard4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard4.Controls.Add(Me.LBL_users)
        Me.MaterialCard4.Controls.Add(Me.Panel10)
        Me.MaterialCard4.Controls.Add(Me.Panel7)
        Me.MaterialCard4.Depth = 0
        Me.MaterialCard4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard4.Location = New System.Drawing.Point(788, 286)
        Me.MaterialCard4.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard4.Name = "MaterialCard4"
        Me.MaterialCard4.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard4.Size = New System.Drawing.Size(189, 94)
        Me.MaterialCard4.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(53, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sales and Inventory System" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for Corporate and Business affairs" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LBL_username
        '
        Me.LBL_username.AutoSize = True
        Me.LBL_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.LBL_username.Location = New System.Drawing.Point(140, 28)
        Me.LBL_username.Name = "LBL_username"
        Me.LBL_username.Size = New System.Drawing.Size(91, 20)
        Me.LBL_username.TabIndex = 2
        Me.LBL_username.Text = "Username"
        '
        'LBL_usertype
        '
        Me.LBL_usertype.AutoSize = True
        Me.LBL_usertype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_usertype.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBL_usertype.Location = New System.Drawing.Point(140, 56)
        Me.LBL_usertype.Name = "LBL_usertype"
        Me.LBL_usertype.Size = New System.Drawing.Size(71, 15)
        Me.LBL_usertype.TabIndex = 2
        Me.LBL_usertype.Text = "User Type"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Location = New System.Drawing.Point(0, 46)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(185, 48)
        Me.Panel8.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Label8)
        Me.Panel9.Location = New System.Drawing.Point(0, 46)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(189, 47)
        Me.Panel9.TabIndex = 2
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel10.Controls.Add(Me.Label9)
        Me.Panel10.Location = New System.Drawing.Point(0, 47)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(189, 47)
        Me.Panel10.TabIndex = 3
        '
        'LBL_students
        '
        Me.LBL_students.AutoSize = True
        Me.LBL_students.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_students.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.LBL_students.Location = New System.Drawing.Point(8, 19)
        Me.LBL_students.Name = "LBL_students"
        Me.LBL_students.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LBL_students.Size = New System.Drawing.Size(19, 20)
        Me.LBL_students.TabIndex = 3
        Me.LBL_students.Text = "0"
        '
        'LBL_products
        '
        Me.LBL_products.AutoSize = True
        Me.LBL_products.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_products.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.LBL_products.Location = New System.Drawing.Point(8, 19)
        Me.LBL_products.Name = "LBL_products"
        Me.LBL_products.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LBL_products.Size = New System.Drawing.Size(19, 20)
        Me.LBL_products.TabIndex = 3
        Me.LBL_products.Text = "0"
        '
        'LBL_users
        '
        Me.LBL_users.AutoSize = True
        Me.LBL_users.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_users.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.LBL_users.Location = New System.Drawing.Point(15, 19)
        Me.LBL_users.Name = "LBL_users"
        Me.LBL_users.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LBL_users.Size = New System.Drawing.Size(19, 20)
        Me.LBL_users.TabIndex = 4
        Me.LBL_users.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(12, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 15)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Registered Students"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(17, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 15)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Product Stocks"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(12, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 15)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Number of Users"
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(14, 14)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(574, 119)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Chart2
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend1)
        Me.Chart2.Location = New System.Drawing.Point(17, 17)
        Me.Chart2.Name = "Chart2"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart2.Series.Add(Series1)
        Me.Chart2.Size = New System.Drawing.Size(302, 133)
        Me.Chart2.TabIndex = 0
        Me.Chart2.Text = "Chart2"
        '
        'LST_products
        '
        Me.LST_products.BackColor = System.Drawing.Color.White
        Me.LST_products.BorderColor = System.Drawing.Color.Silver
        Me.LST_products.Density = MaterialSkin.Controls.MaterialListBox.MaterialItemDensity.[Default]
        Me.LST_products.Depth = 0
        Me.LST_products.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LST_products.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.LST_products.Location = New System.Drawing.Point(14, 198)
        Me.LST_products.MouseState = MaterialSkin.MouseState.HOVER
        Me.LST_products.Name = "LST_products"
        Me.LST_products.SelectedIndex = -1
        Me.LST_products.SelectedItem = Nothing
        Me.LST_products.Size = New System.Drawing.Size(316, 156)
        Me.LST_products.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(17, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 15)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Products"
        '
        'LBL_greetings
        '
        Me.LBL_greetings.AutoSize = True
        Me.LBL_greetings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_greetings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBL_greetings.Location = New System.Drawing.Point(14, 12)
        Me.LBL_greetings.Name = "LBL_greetings"
        Me.LBL_greetings.Size = New System.Drawing.Size(69, 15)
        Me.LBL_greetings.TabIndex = 4
        Me.LBL_greetings.Text = "Greetings"
        '
        'MaterialButton1
        '
        Me.MaterialButton1.AutoSize = False
        Me.MaterialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton1.Depth = 0
        Me.MaterialButton1.HighEmphasis = True
        Me.MaterialButton1.Icon = CType(resources.GetObject("MaterialButton1.Icon"), System.Drawing.Image)
        Me.MaterialButton1.Location = New System.Drawing.Point(931, 13)
        Me.MaterialButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton1.Name = "MaterialButton1"
        Me.MaterialButton1.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton1.Size = New System.Drawing.Size(41, 36)
        Me.MaterialButton1.TabIndex = 5
        Me.MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton1.UseAccentColor = False
        Me.MaterialButton1.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Location = New System.Drawing.Point(46, 18)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(72, 66)
        Me.Panel4.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.BackgroundImage = Global.ITE_5_Project.My.Resources.Resources.Rectangle_286
        Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel7.Location = New System.Drawing.Point(134, -2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(56, 52)
        Me.Panel7.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.BackgroundImage = Global.ITE_5_Project.My.Resources.Resources.Rectangle_275_removebg_preview
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Location = New System.Drawing.Point(129, -3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(64, 52)
        Me.Panel6.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImage = Global.ITE_5_Project.My.Resources.Resources.Rectangle_287_removebg_preview
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Location = New System.Drawing.Point(127, -4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(64, 52)
        Me.Panel5.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.ITE_5_Project.My.Resources.Resources.Logo
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(16, 143)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(34, 43)
        Me.Panel3.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.ITE_5_Project.My.Resources.Resources.Wallpaper
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(274, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(328, 218)
        Me.Panel2.TabIndex = 0
        '
        'UC_home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.MaterialButton1)
        Me.Controls.Add(Me.MaterialCard8)
        Me.Controls.Add(Me.MaterialCard7)
        Me.Controls.Add(Me.MaterialCard6)
        Me.Controls.Add(Me.MaterialCard4)
        Me.Controls.Add(Me.MaterialCard3)
        Me.Controls.Add(Me.MaterialCard2)
        Me.Controls.Add(Me.MaterialCard1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UC_home"
        Me.Size = New System.Drawing.Size(1048, 543)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MaterialCard1.ResumeLayout(False)
        Me.MaterialCard1.PerformLayout()
        Me.MaterialCard2.ResumeLayout(False)
        Me.MaterialCard2.PerformLayout()
        Me.MaterialCard6.ResumeLayout(False)
        Me.MaterialCard6.PerformLayout()
        Me.MaterialCard7.ResumeLayout(False)
        Me.MaterialCard7.PerformLayout()
        Me.MaterialCard8.ResumeLayout(False)
        Me.MaterialCard3.ResumeLayout(False)
        Me.MaterialCard3.PerformLayout()
        Me.MaterialCard4.ResumeLayout(False)
        Me.MaterialCard4.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard6 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard7 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard8 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MaterialCard3 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard4 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LBL_usertype As Label
    Friend WithEvents LBL_username As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents LBL_students As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LBL_products As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LBL_users As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label10 As Label
    Friend WithEvents LST_products As MaterialSkin.Controls.MaterialListBox
    Friend WithEvents LBL_greetings As Label
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
End Class
