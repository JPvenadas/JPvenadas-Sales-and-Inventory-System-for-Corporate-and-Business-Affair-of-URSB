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

    Private Sub BTN_search_Click(sender As Object, e As EventArgs) Handles BTN_search.Click
        If TXT_filter.Text = "" Then
            TblstudentsBindingSource.Filter = Nothing
        Else
            TblstudentsBindingSource.Filter = "(Convert(StudentID,'System.String')) LIKE '%" & TXT_filter.Text & "%' OR Firstname LIKE '%" & TXT_filter.Text & "%' OR Middlename LIKE '%" & TXT_filter.Text & "%' OR Lastname LIKE '%" & TXT_filter.Text & "%' OR College LIKE '%" & TXT_filter.Text & "%' OR Course LIKE '%" & TXT_filter.Text & "%' "
        End If

    End Sub
End Class
