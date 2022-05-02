Public Class UC_college
    Private Sub UC_college_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Refreshdata()
    End Sub
    Sub Refreshdata()
        Me.Tbl_collegesTableAdapter.Fill(Me.Db_inventoryDataSet.tbl_colleges)
    End Sub

    Private Sub BTN_add_Click(sender As Object, e As EventArgs) Handles BTN_add.Click
        Enable()
        LBL_notif.Text = "Add a College"
    End Sub

    Sub Clearinputs()
        TXT_collegeID.Text = ""
        TXT_collegeName.Text = ""
    End Sub
    Sub Enable()
        Clearinputs()
        TXT_collegeName.Enabled = True
        TXT_collegeID.Enabled = True
        BTN_clear.Enabled = True
        BTN_save.Enabled = True
    End Sub
End Class
