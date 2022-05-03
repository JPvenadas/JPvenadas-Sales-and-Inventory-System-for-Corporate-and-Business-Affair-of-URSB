Public Class UC_settings
    Private Sub UC_settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim colleges As New UC_college
        attachControls(colleges, TAB_colleges)
        Dim courses As New UC_course
        attachControls(courses, TAB_courses)
        Dim pcategories As New UC_pcategory
        attachControls(pcategories, TAB_categories)
    End Sub
End Class
