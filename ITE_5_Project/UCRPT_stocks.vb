Public Class UCRPT_stocks
    Private Sub UCRPT_stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tbl_stocksTableAdapter.Fill(Me.db_inventoryDataSet.tbl_stocks)
        RPTV_stocks.RefreshReport()
        RPTV_stocks.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub

    Private Sub BTN_clear_Click(sender As Object, e As EventArgs) Handles BTN_clear.Click
        Me.tbl_stocksTableAdapter.Fill(Me.db_inventoryDataSet.tbl_stocks)
        RPTV_stocks.RefreshReport()
    End Sub

    Private Sub BTN_productfilter_Click(sender As Object, e As EventArgs) Handles BTN_productfilter.Click
        Me.tbl_stocksTableAdapter.FillByProduct(Me.db_inventoryDataSet.tbl_stocks, TXT_product.Text)
        RPTV_stocks.RefreshReport()
        DT_endDate.Value = Date.Now
        DT_startDate.Value = Date.Now
    End Sub
    Private Sub BTN_Datefilter_Click(sender As Object, e As EventArgs) Handles BTN_Datefilter.Click
        Me.tbl_stocksTableAdapter.FillByDate(Me.db_inventoryDataSet.tbl_stocks, DT_startDate.Value, DT_endDate.Value)
        RPTV_stocks.RefreshReport()
        TXT_product.Text = ""
    End Sub

    Private Sub TXT_product_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_product.KeyPress
        numberonly(e.KeyChar, e)
    End Sub
End Class
