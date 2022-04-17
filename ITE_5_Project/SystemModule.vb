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


End Module
