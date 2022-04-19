Public Class SUBFRM_viewstudent
    Dim firstname, midname, lastname, college, course, address, contactno
    Private Sub SUBFRM_viewstudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        attachCollege()
        attachCourse()
        Getdata()
        attachinputs()
    End Sub

    Private Sub CBO_college_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_college.SelectedIndexChanged
        attachCourse()
        CBO_course.Text = course
    End Sub

    Private Sub BTN_save_Click(sender As Object, e As EventArgs) Handles BTN_save.Click
        If TXT_firstname.Text = "" Or TXT_lastname.Text = "" Or TXT_contact.Text = "" Or TXT_address.Text = "" Or CBO_course.Text = "" Or CBO_college.Text = "" Then
            MsgBox("All fields aside from Middle name are Required", vbOKOnly + vbExclamation, "Saving Error")
            Exit Sub
        End If
        updateData()
    End Sub

    Private Sub BTN_revert_Click(sender As Object, e As EventArgs) Handles BTN_revert.Click
        attachinputs()
    End Sub

    Private Sub BTN_back_Click(sender As Object, e As EventArgs) Handles BTN_back.Click
        Me.Close()
    End Sub

    Sub Getdata()
        openCon()
        cmd.CommandText = "select * from tbl_students where StudentID=@sid"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("sid", clickedkey)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        dr.Read()
        firstname = dr.GetString("Firstname")
        midname = dr.GetString("Middlename")
        lastname = dr.GetString("Lastname")
        college = dr.GetString("College")
        course = dr.GetString("Course")
        address = dr.GetString("Address")
        contactno = dr.GetString("ContactNo")
        con.Close()
    End Sub

    Sub attachinputs()
        TXT_firstname.Text = firstname
        TXT_midname.Text = midname
        TXT_lastname.Text = lastname
        CBO_college.Text = college
        CBO_course.Text = course
        TXT_address.Text = address
        TXT_contact.Text = contactno
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
    Sub updateData()
        openCon()
        cmd.CommandText = "update tbl_students set Firstname=@fn, Middlename=@mn, Lastname=@ln, College=@clg, Course=@crs, Address=@adr, ContactNo=@cn where StudentID=@un"
        With cmd.Parameters
            .Clear()
            .AddWithValue("fn", TXT_firstname.Text)
            .AddWithValue("mn", TXT_midname.Text)
            .AddWithValue("ln", TXT_lastname.Text)
            .AddWithValue("clg", CBO_college.Text)
            .AddWithValue("crs", CBO_course.Text)
            .AddWithValue("adr", TXT_address.Text)
            .AddWithValue("cn", TXT_contact.Text)
            .AddWithValue("un", clickedkey)
        End With
        cmd.ExecuteNonQuery()
        con.Close()
        Refreshdata()
        Me.Close()
    End Sub
    Sub Refreshdata()
        FRM_mainmenu.TAB_students.Controls.Clear()
        Dim Students As New UC_students
        Students.Parent = FRM_mainmenu.TAB_students
        Students.Dock = DockStyle.Fill
    End Sub
End Class