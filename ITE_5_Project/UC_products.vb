Public Class UC_products
    Private Sub UC_products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_inventoryDataSet.tbl_products' table. You can move, or remove it, as needed.
        Me.Tbl_productsTableAdapter.Fill(Me.Db_inventoryDataSet.tbl_products)
    End Sub
    Private Sub BTN_add_Click(sender As Object, e As EventArgs) Handles BTN_add.Click
        SUBFRM_addproducts.ShowDialog()
    End Sub
End Class
