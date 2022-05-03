Public Class UC_course
    Private Sub UC_course_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
        Attachcolleges()
    End Sub

    Private Sub BTN_add_Click(sender As Object, e As EventArgs) Handles BTN_add.Click
        Enable()
    End Sub
    Private Sub BTN_clear_Click(sender As Object, e As EventArgs) Handles BTN_clear.Click
        ClearInputs()
    End Sub

    Private Sub BTN_save_Click(sender As Object, e As EventArgs) Handles BTN_save.Click
        ErrorTrappingAdd()
    End Sub

    Sub Attachcolleges()
        CBO_college.Items.Clear()
        openCon()
        cmd.CommandText = "select * from tbl_colleges"
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        While dr.Read
            CBO_college.Items.Add(dr.GetString("CollegeID"))
        End While
        con.Close()
    End Sub
    Sub ClearInputs()
        TXT_courseID.Text = ""
        TXT_courseName.Text = ""
        Attachcolleges()
        CBO_college.Refresh()
    End Sub
    Sub Enable()
        ClearInputs()
        TXT_courseID.Enabled = True
        TXT_courseName.Enabled = True
        CBO_college.Enabled = True
        BTN_clear.Enabled = True
        BTN_save.Enabled = True
    End Sub

    Sub ErrorTrappingAdd()
        openCon()
        cmd.CommandText = "select * from tbl_courses where CourseID=@ID"
        With cmd.Parameters
            .Clear()
            .AddWithValue("ID", TXT_courseID.Text)
        End With
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            MsgBox("The Course is already on the list", vbOKOnly + vbExclamation, "Error Saving")
            TXT_courseID.Text = ""
            TXT_courseID.Focus()
            con.Close()
            Exit Sub
        End If
        con.Close()
        If TXT_courseID.Text = "" Or TXT_courseName.Text = "" Or CBO_college.Text = "" Then
            MsgBox("All fields are required", vbOKOnly + vbExclamation, "Error Saving")
            Exit Sub
        End If
        Addcourse()
        RefreshData()
    End Sub

    Sub Addcourse()
        openCon()
        cmd.CommandText = "insert into tbl_courses values(@ID,@name,@college)"
        With cmd.Parameters
            .Clear()
            .AddWithValue("ID", TXT_courseID.Text)
            .AddWithValue("name", TXT_courseName.Text)
            .AddWithValue("college", CBO_college.Text)
        End With
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Sub RefreshData()
        Me.Tbl_coursesTableAdapter.Fill(Me.Db_inventoryDataSet.tbl_courses)
    End Sub

End Class
