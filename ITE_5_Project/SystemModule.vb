Imports MySql.Data.MySqlClient
Module SystemModule
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand

    'Logged in User'
    Public loggedUserName
    Public loggedUserType
    Public clickedkey
    Public clickedkey2

    Public dr As MySqlDataReader
    Sub openCon()
        con.ConnectionString = My.Settings.db_inventoryConnectionString
        con.Open()
        cmd.Connection = con
    End Sub

    Sub exitsystem()
        Dim answer = MsgBox("Do you really want to exit", vbYesNo + vbQuestion, "Exit")
        If answer = vbYes Then
            End
        End If
    End Sub

    Sub attachControls(usercontrol, parentlocation)
        usercontrol.Parent = parentlocation
        usercontrol.Show()
        usercontrol.Dock = DockStyle.Fill
    End Sub

    Sub GetColleges()
        openCon()
        cmd.CommandText = "Select * from tbl_colleges"
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
    End Sub
    Sub GetProductCategory()
        openCon()
        cmd.CommandText = "Select * from tbl_categories"
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
    End Sub
    Sub GetCourses(college)
        openCon()
        cmd.CommandText = "Select * from tbl_courses where CollegeID=@college"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("college", college)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
    End Sub
    Sub numberonly(input, cmd)
        If Char.IsLetter(input) Then
            cmd.Handled = True
        End If
    End Sub
    Sub showDialogWithGray(FormToShow, FormParent)
        Dim background As New Form
        background.BackColor = Color.Black
        background.WindowState = FormWindowState.Maximized
        background.Opacity = 0.5D
        background.FormBorderStyle = FormBorderStyle.None
        background.Location = FormParent.Location
        background.Show()
        FormToShow.Owner = background
        FormToShow.ShowDialog()
        background.Dispose()
    End Sub
End Module
