Public Class FRM_login
    Private Sub BTN_login_Click(sender As Object, e As EventArgs) Handles BTN_login.Click
        If TXT_username.Text = "" Or TXT_password.Text = "" Then
            MsgBox("Please input your Username and Password", vbExclamation + vbOK, "Login Error")
            Exit Sub
        End If
        openCon()
        cmd.CommandText = "select * from tbl_users where Username=@un and Password=@pw and AccountStatus=@as"
        Dim param = cmd.Parameters
        cmd.Parameters.Clear()
        param.AddWithValue("un", TXT_username.Text)
        param.AddWithValue("pw", TXT_password.Text)
        param.AddWithValue("as", "Active")
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            loggedUserName = dr.GetString("LoginName")
            loggedUserType = dr.GetString("UserType")
            FRM_Loading.Show()
            Me.Close()
            con.Close()
        Else
            MsgBox("Username and Password not Registered", vbOK + vbExclamation, "Login Error")
        End If
        con.Close()
    End Sub

    Private Sub BTN_close_Click(sender As Object, e As EventArgs) Handles BTN_close.Click
        exitsystem()
    End Sub


End Class
