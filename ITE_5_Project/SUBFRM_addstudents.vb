Public Class SUBFRM_addstudents
    Private Sub BTN_back_Click(sender As Object, e As EventArgs) Handles BTN_back.Click
        Clear()
        Me.Close()
    End Sub

    Private Sub SUBFRM_addstudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        attachCollege()
    End Sub

    Private Sub CBO_college_Leave(sender As Object, e As EventArgs) Handles CBO_college.Leave
        attachCourse()
    End Sub

    Private Sub BTN_clear_Click(sender As Object, e As EventArgs) Handles BTN_clear.Click
        Clear()
    End Sub

    Private Sub BTN_save_Click(sender As Object, e As EventArgs) Handles BTN_save.Click
        If TXT_firstname.Text = "" Or TXT_lastname.Text = "" Or CBO_college.Text = "" Or CBO_course.Text = "" Or TXT_address.Text = "" Or TXT_contact.Text = "" Then
            MsgBox("All fields are required, aside from Middle name", vbOKOnly + vbExclamation, "Registration Error")
            Exit Sub
        End If
        AddStudents()
    End Sub

    Sub Clear()
        TXT_firstname.Text = ""
        TXT_lastname.Text = ""
        TXT_midname.Text = ""
        TXT_contact.Text = ""
        TXT_address.Text = ""
        attachCollege()
        attachCourse()
        CBO_college.Refresh()
        CBO_course.Refresh()
    End Sub
    Sub attachCollege()
        GetColleges()
        CBO_college.Items.Clear()
        While dr.Read
            Dim college = dr.GetString("CollegeID")
            CBO_college.Items.Add(college)
        End While
        con.Close()
    End Sub
    Sub attachCourse()
        GetCourses(CBO_college.Text)
        CBO_course.Items.Clear()
        While dr.Read
            Dim course = dr.GetString("CourseID")
            CBO_course.Items.Add(course)
        End While
        con.Close()
    End Sub

    Sub AddStudents()
        openCon()
        cmd.CommandText = "insert into tbl_students(Firstname,Middlename,Lastname,College,Course,Address,ContactNo) values(@fn,@mn,@ln,@clg,@crs,@Adr,@cn)"
        cmd.Parameters.Clear()
        With cmd.Parameters
            .AddWithValue("fn", TXT_firstname.Text)
            .AddWithValue("mn", TXT_midname.Text)
            .AddWithValue("ln", TXT_lastname.Text)
            .AddWithValue("clg", CBO_college.Text)
            .AddWithValue("crs", CBO_course.Text)
            .AddWithValue("adr", TXT_address.Text)
            .AddWithValue("cn", TXT_contact.Text)
        End With
        cmd.ExecuteNonQuery()
        con.Close()
        Refreshdata()
        Clear()
        Me.Close()
    End Sub

    Sub Refreshdata()
        FRM_mainmenu.TAB_students.Controls.Clear()
        Dim Students As New UC_students
        Students.Parent = FRM_mainmenu.TAB_students
        Students.Dock = DockStyle.Fill
    End Sub


End Class