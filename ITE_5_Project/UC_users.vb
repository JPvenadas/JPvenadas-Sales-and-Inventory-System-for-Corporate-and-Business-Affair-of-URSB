Public Class UC_users
    Private Sub UC_users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tbl_usersTableAdapter.Fill(Me.Db_inventoryDataSet.tbl_users)
        CBO_type.Text = "Active"
    End Sub


    Private Sub BTN_add_Click(sender As Object, e As EventArgs) Handles BTN_add.Click
        SUBFRM_adduser.ShowDialog()
    End Sub

    Private Sub DGV_users_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_users.CellDoubleClick
        Dim row As New DataGridViewRow
        row = DGV_users.Rows(e.RowIndex)
        clickedkey = row.Cells(0).Value
        SUBFRM_edituser.ShowDialog()
    End Sub

    Private Sub CBO_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_type.SelectedIndexChanged

        TblusersBindingSource.Filter = "AccountStatus = '" & CBO_type.Text & "' "
    End Sub

    Private Sub BTN_search_Click(sender As Object, e As EventArgs) Handles BTN_search.Click

        TblusersBindingSource.Filter = "Username LIKE '%" & TXT_filter.Text & "%' OR LoginName LIKE '%" & TXT_filter.Text & "%' "

    End Sub
End Class
