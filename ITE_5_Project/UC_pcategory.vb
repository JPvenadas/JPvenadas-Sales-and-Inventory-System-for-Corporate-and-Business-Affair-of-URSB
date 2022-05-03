Public Class UC_pcategory
    Private Sub UC_pcategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tbl_categoriesTableAdapter.Fill(Me.Db_inventoryDataSet.tbl_categories)
    End Sub

End Class
