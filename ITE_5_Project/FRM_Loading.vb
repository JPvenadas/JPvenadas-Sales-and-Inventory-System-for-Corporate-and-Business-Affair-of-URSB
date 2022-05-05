Public Class FRM_Loading
    Private Sub FRM_Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar.Value = ProgressBar.Value + 10
        LBL_percentage.Text = CStr(ProgressBar.Value) + "%"
        If ProgressBar.Value = 100 Then
            Timer1.Enabled = False
            FRM_mainmenu.Show()
            Me.Close()

        End If
    End Sub


End Class