Public Class UC_reports
    Private Sub UC_reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If loggedUserType = "CBA Head" Then
            Dim users As New UCRPT_users
            attachControls(users, PNL_reportcontainer)
        Else
            Dim students As New UCRPT_students
            attachControls(students, PNL_reportcontainer)
            BTN_activities.Enabled = False
            BTN_products.Enabled = False
            BTN_users.Enabled = False
            BTN_stocks.Enabled = False
        End If
    End Sub

    Sub changeReport(UC)
        PNL_reportcontainer.Controls.Clear()
        attachControls(UC, PNL_reportcontainer)
    End Sub

    Private Sub BTN_users_Click(sender As Object, e As EventArgs) Handles BTN_users.Click
        Dim uc As New UCRPT_users
        changeReport(uc)
    End Sub

    Private Sub BTN_students_Click(sender As Object, e As EventArgs) Handles BTN_students.Click
        Dim uc As New UCRPT_students
        changeReport(uc)
    End Sub

    Private Sub BTN_products_Click(sender As Object, e As EventArgs) Handles BTN_products.Click
        Dim uc As New UCRPT_products
        changeReport(uc)
    End Sub

    Private Sub BTN_stocks_Click(sender As Object, e As EventArgs) Handles BTN_stocks.Click
        Dim uc As New UCRPT_stocks
        changeReport(uc)
    End Sub

    Private Sub BTN_transactions_Click(sender As Object, e As EventArgs) Handles BTN_transactions.Click
        Dim uc As New UCRPT_transactions
        changeReport(uc)
    End Sub

    Private Sub BTN_activities_Click(sender As Object, e As EventArgs) Handles BTN_activities.Click
        Dim uc As New UCRPT_activities
        changeReport(uc)
    End Sub
End Class
