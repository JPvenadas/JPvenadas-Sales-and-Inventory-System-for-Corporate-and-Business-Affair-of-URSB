Public Class SUBFRM_edituser
    Dim oppositeStatus
    Dim param = cmd.Parameters
    Private Sub SUBFRM_edituser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
    End Sub

    Private Sub BTN_back_Click(sender As Object, e As EventArgs) Handles BTN_back.Click
        Me.Close()
    End Sub

    Private Sub BTN_changestatus_Click(sender As Object, e As EventArgs) Handles BTN_changestatus.Click
        EditStatus()
    End Sub

    Private Sub BTN_save_Click(sender As Object, e As EventArgs) Handles BTN_save.Click
        If TXT_loginName.Text = "" Or TXT_password.Text = "" Then
            MsgBox("Login Name and Password should not be empty", vbOK + vbExclamation, "Account Error")
        End If
        UpdateData()
    End Sub

    Sub GetData()
        openCon()
        cmd.CommandText = "Select * from tbl_users where Username=@un"
        param.Clear()
        param.AddWithValue("un", clickedkey)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        dr.Read()
        TXT_username.Text = dr.GetString("Username")
        TXT_password.Text = dr.GetString("Password")
        TXT_loginName.Text = dr.GetString("LoginName")
        Dim usertype = dr.GetString("UserType")
        Dim status = dr.GetString("AccountStatus")
        If usertype = "CBA Head" Then
            CHK_admin.Checked = True
        Else
            CHK_admin.Checked = False
        End If
        If status = "Active" Then
            BTN_changestatus.Text = "Deactivate"
            oppositeStatus = "Inactive"
        Else
            BTN_changestatus.Text = "Activate"
            oppositeStatus = "Active"
        End If
        con.Close()
    End Sub

    Sub EditStatus()
        openCon()
        cmd.CommandText = "update tbl_users set AccountStatus=@as where Username=@un"
        param.Clear()
        param.AddWithValue("as", oppositeStatus)
        param.AddWithValue("un", TXT_username.Text)
        cmd.ExecuteNonQuery()
        con.Close()
        RefreshData()
        Me.Close()
    End Sub
    Sub RefreshData()
        FRM_mainmenu.TAB_user.Controls.Clear()
        Dim users As New UC_users
        users.Parent = FRM_mainmenu.TAB_user
        users.Dock = DockStyle.Fill
    End Sub
    Sub UpdateData()
        openCon()
        cmd.CommandText = "update tbl_users set LoginName=@ln, UserType=@ut, Password=@pw where Username=@un"
        param.clear()
        If CHK_admin.Checked = True Then
            param.AddWithValue("ut", "CBA Head")
        Else
            param.AddWithValue("ut", "CBA Staff")
        End If
        param.AddWithValue("ln", TXT_loginName.Text)
        param.AddWithValue("pw", TXT_password.Text)
        param.AddWithValue("un", TXT_username.Text)
        cmd.ExecuteNonQuery()
        con.Close()
        RefreshData()
        Me.Close()
    End Sub

End Class