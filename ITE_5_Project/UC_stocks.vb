Public Class UC_stocks
    Private Sub UC_stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tbl_productsTableAdapter.Fill(Me.Db_inventoryDataSet.tbl_products)
        Me.Tbl_stocksTableAdapter.Fill(Me.Db_inventoryDataSet.tbl_stocks)

    End Sub
    Private Sub BTN_search_Click(sender As Object, e As EventArgs) Handles BTN_search.Click
        If TXT_filter.Text = "" Then
            TblproductsBindingSource.Filter = Nothing
        Else
            TblproductsBindingSource.Filter = "(Convert(ProductID,'System.String')) LIKE '%" & TXT_filter.Text & "%' OR ProductName LIKE '%" & TXT_filter.Text & "%' OR ProductCategory LIKE '%" & TXT_filter.Text & "%' "
        End If
    End Sub
    Private Sub DGV_products_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_products.CellDoubleClick
        Dim row = DGV_products.Rows(e.RowIndex)
        clickedkey = row.Cells(0).Value
        SUBFRM_addstocks.ShowDialog()
    End Sub

End Class
