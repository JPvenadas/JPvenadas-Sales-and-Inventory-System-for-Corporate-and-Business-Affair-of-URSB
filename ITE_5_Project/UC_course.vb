Public Class UC_course
    Dim prevId
    Private Sub UC_course_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub

    Private Sub BTN_add_Click(sender As Object, e As EventArgs) Handles BTN_add.Click
        Enable()
        LBL_operation.Text = "Add a Course"
        BTN_clear.Text = "Clear"
    End Sub
    Private Sub BTN_clear_Click(sender As Object, e As EventArgs) Handles BTN_clear.Click
        If LBL_operation.Text = "Add a Course" Then
            ClearInputs()
        Else
            Dim answer = MsgBox(("Are you sure you want to delete the course, " + prevId + " ?"), vbYesNo + vbQuestion, "Delete Course")
            If answer = vbYes Then
                Deletecourse()
                ClearInputs()
                BTN_clear.Text = "Clear"
                LBL_operation.Text = "Add a Course"
            End If
        End If
    End Sub

    Private Sub BTN_save_Click(sender As Object, e As EventArgs) Handles BTN_save.Click
        If LBL_operation.Text = "Add a Course" Then
            ErrorTrappingAdd()
        Else
            ErrorTrappingUpdate()
        End If
    End Sub
    Private Sub DGV_courses_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_courses.CellClick
        Enable()
        Dim row = DGV_courses.Rows(e.RowIndex)
        TXT_courseID.Text = row.Cells(0).Value
        prevId = row.Cells(0).Value
        TXT_courseName.Text = row.Cells(1).Value
        CBO_college.Text = row.Cells(2).Value
        CBO_college.Refresh()
        LBL_operation.Text = "Edit a Course"
        BTN_clear.Text = "Delete"
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
    End Sub

    Sub ErrorTrappingUpdate()
        If TXT_courseID.Text = "" Or TXT_courseName.Text = "" Or CBO_college.Text = "" Then
            MsgBox("All fields are required", vbOKOnly + vbExclamation, "Saving Error")
            Exit Sub
        End If
        openCon()
        cmd.CommandText = "select * from tbl_courses where CourseID = @ID"
        With cmd.Parameters
            .Clear()
            .AddWithValue("ID", TXT_courseID.Text)
        End With
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            If dr(0) <> prevId Then
                MsgBox("The Course Is already On the list", vbOKOnly + vbExclamation, "Error Saving")
                TXT_courseID.Text = prevId
                con.Close()
                Exit Sub
            End If
        End If
        con.Close()
        UpdateCourse()
    End Sub
    Sub UpdateCourse()
        openCon()
        cmd.CommandText = "update tbl_courses set CourseID = @ID, CourseName = @name, CollegeID = @clg where CourseId = @previd"
        With cmd.Parameters
            .Clear()
            .AddWithValue("ID", TXT_courseID.Text)
            .AddWithValue("name", TXT_courseName.Text)
            .AddWithValue("clg", CBO_college.Text)
            .AddWithValue("previd", prevId)
        End With
        cmd.ExecuteNonQuery()
        con.Close()
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
        RefreshData()
    End Sub
    Sub Deletecourse()
        openCon()
        cmd.CommandText = "delete from tbl_courses where courseID = @ID"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("ID", prevId)
        cmd.ExecuteNonQuery()
        con.Close()
        RefreshData()
    End Sub
    Sub RefreshData()
        Me.Tbl_coursesTableAdapter.Fill(Me.Db_inventoryDataSet.tbl_courses)
    End Sub

    Private Sub CBO_college_Enter(sender As Object, e As EventArgs) Handles CBO_college.Enter
        Attachcolleges()
    End Sub
End Class
