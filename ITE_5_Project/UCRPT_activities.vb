Public Class UCRPT_activities
    Private Sub UCRPT_activities_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tbl_activitiesTableAdapter.Fill(Me.db_inventoryDataSet.tbl_activities)
        RPTV_activities.RefreshReport()
        RPTV_activities.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub

    Private Sub BTN_clearstocksfilter_Click(sender As Object, e As EventArgs) Handles BTN_clearstocksfilter.Click
        Me.tbl_activitiesTableAdapter.Fill(Me.db_inventoryDataSet.tbl_activities)
        RPTV_activities.RefreshReport()
        TXT_username.Text = ""
        DT_enddate.Value = Date.Now
        DT_startdate.Value = Date.Now
    End Sub

    Private Sub BTN_userfilter_Click(sender As Object, e As EventArgs) Handles BTN_userfilter.Click
        Me.tbl_activitiesTableAdapter.FillByUser(Me.db_inventoryDataSet.tbl_activities, TXT_username.Text)
        RPTV_activities.RefreshReport()
        DT_enddate.Value = Date.Now
        DT_startdate.Value = Date.Now
    End Sub

    Private Sub BTN_datefilter_Click(sender As Object, e As EventArgs) Handles BTN_datefilter.Click
        Me.tbl_activitiesTableAdapter.FillByDate(Me.db_inventoryDataSet.tbl_activities, DT_startdate.Value, DT_enddate.Value)
        RPTV_activities.RefreshReport()
        TXT_username.Text = ""
    End Sub
End Class
