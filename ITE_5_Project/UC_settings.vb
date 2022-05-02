Public Class UC_settings
    Private Sub UC_settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim colleges As New UC_college
        attachControls(colleges, TAB_colleges)
    End Sub
End Class
