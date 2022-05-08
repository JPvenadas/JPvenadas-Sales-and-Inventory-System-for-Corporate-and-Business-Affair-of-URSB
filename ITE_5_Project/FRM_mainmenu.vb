Imports MaterialSkin
Public Class FRM_mainmenu
    Private Sub FRM_mainmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_inventoryDataSet.tbl_products' table. You can move, or remove it, as needed.
        Me.Tbl_productsTableAdapter.Fill(Me.Db_inventoryDataSet.tbl_products)

        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue900, Primary.Grey800, Primary.Blue500, Accent.Blue700, TextShade.WHITE)

        Dim home As New UC_home
        Dim users As New UC_users
        Dim students As New UC_students
        Dim products As New UC_products
        Dim stocks As New UC_stocks
        Dim reports As New UC_reports
        Dim settings As New UC_settings
        Dim transactions As New UC_transactions

        attachControls(home, TAB_home)
        attachControls(students, TAB_students)
        attachControls(reports, TAB_reports)
        attachControls(transactions, TAB_transaction)

        If loggedUserType = "CBA Head" Then
            attachControls(settings, TAB_settings)
            attachControls(stocks, TAB_stocks)
            attachControls(products, TAB_products)
            attachControls(users, TAB_user)
        End If
        If loggedUserType = "CBA Staff" Then
            MaterialTabControl1.TabPages.Remove(TAB_user)
            MaterialTabControl1.TabPages.Remove(TAB_products)
            MaterialTabControl1.TabPages.Remove(TAB_settings)
            MaterialTabControl1.TabPages.Remove(TAB_stocks)
        End If
    End Sub
    Private Sub BTN_logout_Click(sender As Object, e As EventArgs) Handles BTN_logout.Click
        Dim answer = MsgBox("Are you sure you want to log out your Account", vbYesNo + vbQuestion, "Logging Out")
        If answer = vbYes Then
            destination = "Login"
            FRM_Loading.Show()
            Me.Hide()
        End If
    End Sub
End Class