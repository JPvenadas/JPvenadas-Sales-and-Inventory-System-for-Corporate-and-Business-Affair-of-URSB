Public Class UCRPT_transactions
    Private Sub UCRPT_transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tbl_transactionsTableAdapter.Fill(Me.db_inventoryDataSet.tbl_transactions)
        RPTV_transactions.RefreshReport()
        RPTV_transactions.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub

    Private Sub BN_clear_Click(sender As Object, e As EventArgs) Handles BN_clear.Click
        Me.tbl_transactionsTableAdapter.Fill(Me.db_inventoryDataSet.tbl_transactions)
        RPTV_transactions.RefreshReport()
        TXT_studentID.Text = ""
        TXT_productID.Text = ""
        DT_enddate.Value = Date.Now
        DT_startdate.Value = Date.Now
    End Sub

    Private Sub BTN_productfilter_Click(sender As Object, e As EventArgs) Handles BTN_productfilter.Click
        Me.tbl_transactionsTableAdapter.FillByProduct(Me.db_inventoryDataSet.tbl_transactions, TXT_productID.Text)
        RPTV_transactions.RefreshReport()
        TXT_studentID.Text = ""
        DT_enddate.Value = Date.Now
        DT_startdate.Value = Date.Now
    End Sub

    Private Sub BTN_studentfilter_Click(sender As Object, e As EventArgs) Handles BTN_studentfilter.Click
        Me.tbl_transactionsTableAdapter.FillByStudent(Me.db_inventoryDataSet.tbl_transactions, TXT_studentID.Text)
        RPTV_transactions.RefreshReport()
        DT_enddate.Value = Date.Now
        DT_startdate.Value = Date.Now
        TXT_productID.Text = ""
    End Sub

    Private Sub BTN_datefilter_Click(sender As Object, e As EventArgs) Handles BTN_datefilter.Click
        Me.tbl_transactionsTableAdapter.FillByDate(Me.db_inventoryDataSet.tbl_transactions, DT_startdate.Value, DT_enddate.Value)
        RPTV_transactions.RefreshReport()
        TXT_productID.Text = ""
        TXT_studentID.Text = ""
    End Sub
End Class
