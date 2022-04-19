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
End Class