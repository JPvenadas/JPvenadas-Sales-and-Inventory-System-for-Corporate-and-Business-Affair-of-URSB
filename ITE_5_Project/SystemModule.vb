Imports MySql.Data.MySqlClient

Module SystemModule
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand

    'Logged in User'
    Public loggedUserName
    Public loggedUserType

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

    Sub attachControls()
        Dim home As New UC_users
        home.Parent = FRM_mainmenu.TAB_user
        home.Show()
        home.Dock = DockStyle.Fill
    End Sub
End Module
