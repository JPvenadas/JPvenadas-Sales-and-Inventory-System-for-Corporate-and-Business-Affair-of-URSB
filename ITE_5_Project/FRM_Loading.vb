Public Class FRM_Loading
    Private Sub FRM_Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        ProgressBar.Value = 0
        If destination = "Menu" Then
            LBL_action.Text = "Logging in..."
        Else
            LBL_action.Text = "Logging out..."
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar.Value = ProgressBar.Value + 10
        LBL_percentage.Text = CStr(ProgressBar.Value) + "%"

        If ProgressBar.Value = 100 Then
            Timer1.Enabled = False
            If destination = "Menu" Then
                Dim form As New FRM_mainmenu
                form.Show()
            Else
                FRM_login.Show()
            End If
            Me.Close()
        End If
    End Sub


End Class