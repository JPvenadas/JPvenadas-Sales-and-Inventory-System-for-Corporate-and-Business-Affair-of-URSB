Public Class UC_students
    Private Sub UC_students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tbl_studentsTableAdapter.Fill(Me.Db_inventoryDataSet.tbl_students)
    End Sub


    Private Sub BTN_add_Click(sender As Object, e As EventArgs) Handles BTN_add.Click
        SUBFRM_addstudents.ShowDialog()
    End Sub

    Private Sub DGV_students_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_students.CellDoubleClick
        Dim row As New DataGridViewRow
        row = DGV_students.Rows(e.RowIndex)
        clickedkey = row.Cells(0).Value
        SUBFRM_viewstudent.ShowDialog()
    End Sub
End Class
