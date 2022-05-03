Public Class UC_course
    Private Sub UC_course_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tbl_coursesTableAdapter.Fill(Me.Db_inventoryDataSet.tbl_courses)
        Attachcolleges()
    End Sub

    Private Sub BTN_add_Click(sender As Object, e As EventArgs) Handles BTN_add.Click
        Enable()
    End Sub
    Private Sub BTN_clear_Click(sender As Object, e As EventArgs) Handles BTN_clear.Click
        ClearInputs()
    End Sub

    Sub Attachcolleges()
        openCon()
        cmd.CommandText = "select * from tbl_colleges"
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        While dr.Read
            CBO_college.Items.Add(dr.GetString("CollegeID"))

        End While
    End Sub
    Sub ClearInputs()
        TXT_courseID.Text = ""
        TXT_courseName.Text = ""
        Attachcolleges()
        CBO_college.Refresh()
    End Sub
    Sub Enable()
        ClearInputs()
        TXT_courseID.Enabled = True
        TXT_courseName.Enabled = True
        CBO_college.Enabled = True
        BTN_clear.Enabled = True
        BTN_save.Enabled = True
    End Sub


End Class
