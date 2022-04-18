Imports MaterialSkin
Public Class FRM_mainmenu
    Private Sub FRM_mainmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue900, Primary.Grey800, Primary.Blue500, Accent.Blue700, TextShade.WHITE)

        Dim home As New UC_home
        Dim users As New UC_users
        Dim students As New UC_students
        Dim products As New UC_products
        Dim stocks As New UC_stocks
        Dim reports As New UC_stocks
        Dim settings As New UC_settings
        Dim transactions As New UC_transactions

        attachControls(home, TAB_home)
        attachControls(users, TAB_user)
        attachControls(students, TAB_students)
        attachControls(products, TAB_products)
        attachControls(stocks, TAB_stocks)
        attachControls(reports, TAB_reports)
        attachControls(settings, TAB_settings)
        attachControls(transactions, TAB_transaction)
    End Sub

End Class