Public Class UCRPT_products
    Private Sub UCRPT_products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tbl_productsTableAdapter.Fill(Me.db_inventoryDataSet.tbl_products)
        RPTV_products.RefreshReport()
        RPTV_products.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub
End Class
