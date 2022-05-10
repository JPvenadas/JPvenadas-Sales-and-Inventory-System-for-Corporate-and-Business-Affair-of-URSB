Public Class UCRPT_products
    Private Sub UCRPT_products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tbl_productsTableAdapter.Fill(Me.db_inventoryDataSet.tbl_products)
        RPTV_products.RefreshReport()
        ProductCategoryItems()
        RPTV_products.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub
    Sub ProductCategoryItems()
        CBO_pcategory.Items.Clear()
        openCon()
        cmd.CommandText = "select * from tbl_categories"
        dr = cmd.ExecuteReader
        While dr.Read
            CBO_pcategory.Items.Add(dr(0))
        End While
        con.Close()
        CBO_pcategory.Refresh()
    End Sub

    Private Sub BTN_clear_Click(sender As Object, e As EventArgs) Handles BTN_clear.Click
        Me.tbl_productsTableAdapter.Fill(Me.db_inventoryDataSet.tbl_products)
        RPTV_products.RefreshReport()
        ProductCategoryItems()
    End Sub

    Private Sub BTN_filter_Click(sender As Object, e As EventArgs) Handles BTN_filter.Click
        Me.tbl_productsTableAdapter.FillByCategory(Me.db_inventoryDataSet.tbl_products, CBO_pcategory.Text)
        RPTV_products.RefreshReport()
    End Sub
End Class
