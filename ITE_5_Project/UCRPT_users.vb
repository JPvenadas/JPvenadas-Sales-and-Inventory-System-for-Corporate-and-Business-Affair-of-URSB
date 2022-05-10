Public Class UCRPT_users
    Private Sub UCRPT_users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tbl_usersTableAdapter.Fill(Me.db_inventoryDataSet.tbl_users)
        Me.RPTV_users.RefreshReport()
        RPTV_users.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        UsertypeItems()
    End Sub
    Sub UsertypeItems()
        CBO_usertype.Items.Clear()
        CBO_usertype.Items.Add("CBA Staff")
        CBO_usertype.Items.Add("CBA Head")
        CBO_usertype.Refresh()
    End Sub

    Private Sub BTN_clear_Click(sender As Object, e As EventArgs) Handles BTN_clear.Click
        UsertypeItems()
        Me.tbl_usersTableAdapter.Fill(Me.db_inventoryDataSet.tbl_users)
        Me.RPTV_users.RefreshReport()
    End Sub

    Private Sub BTN_filteruser_Click(sender As Object, e As EventArgs) Handles BTN_filteruser.Click
        Me.tbl_usersTableAdapter.FillByUserType(Me.db_inventoryDataSet.tbl_users, CBO_usertype.Text)
        Me.RPTV_users.RefreshReport()
    End Sub
End Class
