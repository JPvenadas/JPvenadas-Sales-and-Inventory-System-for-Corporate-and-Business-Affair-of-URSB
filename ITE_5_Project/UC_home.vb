Public Class UC_home
    Private Sub UC_home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayProducts()
        SetUserInfo()
        GetProductCategories()
        GetTotal("select sum(Stocks) from tbl_products", LBL_products)
        GetTotal("select count(*) from tbl_students", LBL_students)
        GetTotal("select count(*) from tbl_users", LBL_users)
        LBL_greetings.Text = "Welcome to Sales and Inventory system, " + loggedUserName
    End Sub
    Sub DisplayProducts()
        openCon()
        cmd.CommandText = "select * from tbl_products order by ProductName"
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        While dr.Read
            LST_products.Items.Add(New MaterialSkin.MaterialListBoxItem(dr.GetString("ProductName")))
        End While
        con.Close()
    End Sub
    Sub SetUserInfo()
        LBL_username.Text = loggedUserName
        LBL_usertype.Text = loggedUserType
    End Sub
    Sub GetTotal(command, label)
        openCon()
        cmd.CommandText = command
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        dr.Read()
        Dim value = dr(0)
        con.Close()
        label.Text = value
    End Sub
    Sub GetProductCategories()
        openCon()
        cmd.CommandText = "select sum(Stocks), B.ProductCategory from tbl_products as A inner join tbl_categories as B on A.ProductCategory = B.ProductCategory group by B.ProductCategory"
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        Pie.Series("Series1").Points.Clear()
        While dr.Read
            Pie.Series("Series1").Points.AddXY(dr.GetString("ProductCategory"), dr.GetString("sum(Stocks)"))
        End While
        con.Close()
    End Sub

    Private Sub UC_home_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        GetProductCategories()
        GetTotal("select sum(Stocks) from tbl_products", LBL_products)
        GetTotal("select count(*) from tbl_students", LBL_students)
        GetTotal("select count(*) from tbl_users", LBL_users)
        LBL_greetings.Text = "Welcome to Sales and Inventory system, " + loggedUserName
    End Sub
End Class
