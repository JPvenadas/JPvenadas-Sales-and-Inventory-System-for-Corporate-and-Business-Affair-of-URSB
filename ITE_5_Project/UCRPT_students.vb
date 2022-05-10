Public Class UCRPT_students
    Private Sub UCRPT_students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tbl_studentsTableAdapter.Fill(Me.db_inventoryDataSet.tbl_students)
        RPTV_students.RefreshReport()
        RPTV_students.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        CollegeItems()
        CourseItems()
    End Sub
    Sub CollegeItems()
        CBO_college.Items.Clear()
        openCon()
        cmd.CommandText = "select CollegeID from tbl_colleges"
        dr = cmd.ExecuteReader
        While dr.Read
            CBO_college.Items.Add(dr(0))
        End While
        con.Close()
        CBO_college.Refresh()
    End Sub
    Sub CourseItems()
        CBO_course.Items.Clear()
        openCon()
        cmd.CommandText = "select CourseID from tbl_courses"
        dr = cmd.ExecuteReader
        While dr.Read
            CBO_course.Items.Add(dr(0))
        End While
        con.Close()
        CBO_college.Refresh()
    End Sub


    Private Sub BTN_filterCollege_Click(sender As Object, e As EventArgs) Handles BTN_filterCollege.Click
        Me.tbl_studentsTableAdapter.FillByCollege(Me.db_inventoryDataSet.tbl_students, CBO_college.Text)
        RPTV_students.RefreshReport()
        CourseItems()
    End Sub

    Private Sub BTN_FilterCourse_Click(sender As Object, e As EventArgs) Handles BTN_FilterCourse.Click
        Me.tbl_studentsTableAdapter.FillByCourse(Me.db_inventoryDataSet.tbl_students, CBO_course.Text)
        RPTV_students.RefreshReport()
        CollegeItems()
    End Sub

    Private Sub BTN_clear_Click(sender As Object, e As EventArgs) Handles BTN_clear.Click
        Me.tbl_studentsTableAdapter.Fill(Me.db_inventoryDataSet.tbl_students)
        RPTV_students.RefreshReport()
        CollegeItems()
        CourseItems()
    End Sub
End Class
