Public Class SUBFRM_adduser
    Private Sub BTN_back_Click(sender As Object, e As EventArgs) Handles BTN_back.Click
        clear()
        Me.Close()
    End Sub

    Private Sub BTN_create_Click(sender As Object, e As EventArgs) Handles BTN_create.Click
        If TXT_username.Text = "" Or TXT_password.Text = "" Or TXT_loginName.Text = "" Or TXT_cpassword.Text = "" Then
            MsgBox("All fields are required", vbOK + vbExclamation, "Sign in Error")
            Exit Sub
        ElseIf TXT_cpassword.Text <> TXT_password.Text Then
            MsgBox("Password doesn't match", vbOK + vbExclamation, "Sign in Error")
            TXT_password.Text = ""
            TXT_cpassword.Text = ""
            TXT_password.Focus()
            Exit Sub
        Else
            openCon()
            cmd.CommandText = "select * from tbl_users where Username=@un"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("un", TXT_username.Text)
            cmd.ExecuteNonQuery()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("Sorry, Username is already taken", vbOK + vbExclamation, "Sign in Error")
                TXT_username.Text = ""
                TXT_username.Focus()
                con.Close()
                Exit Sub
            End If
            con.Close()
        End If
        Adduser()
    End Sub

    Private Sub BTN_clear_Click(sender As Object, e As EventArgs) Handles BTN_clear.Click
        clear()
    End Sub

    Sub clear()
        TXT_cpassword.Text = ""
        TXT_loginName.Text = ""
        TXT_password.Text = ""
        TXT_username.Text = ""
        CHK_admin.Checked = False
    End Sub
    Function checkusertype()
        If CHK_admin.Checked = True Then
            Return "CBA Head"
        Else
            Return "CBA Staff"
        End If
    End Function
    Sub Refreshdata()
        FRM_mainmenu.TAB_user.Controls.Clear()
        Dim users As New UC_users
        users.Parent = FRM_mainmenu.TAB_user
        users.Dock = DockStyle.Fill
    End Sub

    Sub Adduser()
        openCon()
        cmd.CommandText = "insert into tbl_users values(@un,@pw,@ln,@ut,@as)"
        Dim param = cmd.Parameters
        param.Clear()
        param.AddWithValue("un", TXT_username.Text)
        param.AddWithValue("pw", TXT_password.Text)
        param.AddWithValue("ln", TXT_loginName.Text)
        param.AddWithValue("ut", checkusertype())
        param.AddWithValue("as", "Active")
        cmd.ExecuteNonQuery()
        con.Close()
        SaveActivity("Added a user with Username: " + TXT_username.Text)
        clear()
        Refreshdata()
        Me.Close()
    End Sub
End Class