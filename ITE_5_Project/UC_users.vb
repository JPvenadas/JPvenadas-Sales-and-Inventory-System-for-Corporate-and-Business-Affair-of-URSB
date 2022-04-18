Public Class UC_users
    Private Sub UC_users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tbl_usersTableAdapter.Fill(Me.Db_inventoryDataSet.tbl_users)

    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick

    End Sub

    Private Sub BTN_add_Click(sender As Object, e As EventArgs) Handles BTN_add.Click
        SUBFRM_adduser.ShowDialog()
    End Sub
End Class
