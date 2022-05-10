Public Class UC_products
    Private Sub UC_products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_inventoryDataSet.tbl_products' table. You can move, or remove it, as needed.
        Me.Tbl_productsTableAdapter.Fill(Me.Db_inventoryDataSet.tbl_products)
    End Sub
    Private Sub BTN_add_Click(sender As Object, e As EventArgs) Handles BTN_add.Click
        showDialogWithGray(SUBFRM_addproducts, FRM_mainmenu)
    End Sub

    Private Sub DGV_products_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_products.CellDoubleClick
        Dim row = DGV_products.Rows(e.RowIndex)
        clickedkey = row.Cells(0).Value
        showDialogWithGray(SUBFRM_viewproduct, FRM_mainmenu)
    End Sub

    Private Sub BTN_search_Click(sender As Object, e As EventArgs) Handles BTN_search.Click
        If TXT_filter.Text = "" Then
            TblproductsBindingSource.Filter = Nothing
        Else
            TblproductsBindingSource.Filter = "(Convert(ProductID,'System.String')) LIKE '%" & TXT_filter.Text & "%' OR ProductName LIKE '%" & TXT_filter.Text & "%' OR ProductCategory LIKE '%" & TXT_filter.Text & "%' "
        End If
    End Sub

    Private Sub UC_products_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        'TODO: This line of code loads data into the 'Db_inventoryDataSet.tbl_products' table. You can move, or remove it, as needed.
        Me.Tbl_productsTableAdapter.Fill(Me.Db_inventoryDataSet.tbl_products)
    End Sub

End Class
