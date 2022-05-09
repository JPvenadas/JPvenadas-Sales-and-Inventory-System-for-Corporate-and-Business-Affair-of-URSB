Public Class UCRPT_stocks
    Private Sub UCRPT_stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tbl_stocksTableAdapter.Fill(Me.db_inventoryDataSet.tbl_stocks)
        RPTV_stocks.RefreshReport()
        RPTV_stocks.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub
End Class
