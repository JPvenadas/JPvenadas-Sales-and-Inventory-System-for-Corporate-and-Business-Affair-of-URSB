Public Class UC_settings
    Private Sub UC_settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_inventoryDataSet.tbl_colleges' table. You can move, or remove it, as needed.
        Me.Tbl_collegesTableAdapter.Fill(Me.Db_inventoryDataSet.tbl_colleges)
    End Sub


End Class
