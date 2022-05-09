Public Class UC_reports
    Private Sub UC_reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim users As New UCRPT_users
        attachControls(users, TAB_RPT_users)
    End Sub
End Class
