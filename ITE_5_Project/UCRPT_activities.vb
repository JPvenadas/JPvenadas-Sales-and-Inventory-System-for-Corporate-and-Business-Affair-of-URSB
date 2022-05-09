Public Class UCRPT_activities
    Private Sub UCRPT_activities_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tbl_activitiesTableAdapter.Fill(Me.db_inventoryDataSet.tbl_activities)
        RPTV_activities.RefreshReport()
        RPTV_activities.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub
End Class
