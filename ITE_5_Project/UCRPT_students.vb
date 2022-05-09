Public Class UCRPT_students
    Private Sub UCRPT_students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tbl_studentsTableAdapter.Fill(Me.db_inventoryDataSet.tbl_students)
        RPTV_students.RefreshReport()
        RPTV_students.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub
End Class
