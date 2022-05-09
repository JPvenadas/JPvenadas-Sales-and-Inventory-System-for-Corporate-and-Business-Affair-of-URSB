Public Class UCRPT_transactions
    Private Sub UCRPT_transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tbl_transactionsTableAdapter.Fill(Me.db_inventoryDataSet.tbl_transactions)
        RPTV_transactions.RefreshReport()
        RPTV_transactions.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub
End Class
