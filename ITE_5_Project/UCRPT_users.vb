Public Class UCRPT_users
    Private Sub UCRPT_users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tbl_usersTableAdapter.Fill(Me.db_inventoryDataSet.tbl_users)
        Me.RPTV_users.RefreshReport()
        RPTV_users.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub
End Class
