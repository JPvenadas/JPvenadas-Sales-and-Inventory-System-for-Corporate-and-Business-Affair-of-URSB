Public Class UC_home
    Private Sub UC_home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayProducts()
        SetUserInfo()
        RenewData()
    End Sub
    Private Sub UC_home_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        RenewData()
    End Sub
    Sub RenewData()
        GetProductCategories()
        GetTotal("select sum(Stocks) from tbl_products", LBL_products)
        GetTotal("select count(*) from tbl_students", LBL_students)
        GetTotal("select count(*) from tbl_users", LBL_users)
        LBL_greetings.Text = "Welcome to Sales and Inventory system, " + loggedUserName
        GenerateSales()
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
    Function GetMonthBefore(num)
        Dim before = Date.Now
        before = DateAdd("m", -num, before)
        Dim processeddate = Format(before, "dd-MM-yyyy")
        Return processeddate
    End Function
    Sub GenerateSales()
        Bar.Series("Series1").Points.Clear()
        For i = 0 To 11
            Dim dateinterval = GetMonthBefore(11 - i)
            Dim year = Format(CDate(dateinterval), "yyyy")
            Dim month = Format(CDate(dateinterval), "MM")
            Dim monthString = Format(CDate(dateinterval), "MMMM")
            openCon()
            cmd.CommandText = "select sum(TotalAmount), month(Date), year(Date) from tbl_transactions where year(Date) = @year and month(date) = @month group by month(Date), year(Date)"
            With cmd.Parameters
                .Clear()
                .AddWithValue("year", year)
                .AddWithValue("month", month)
            End With
            cmd.ExecuteNonQuery()
            dr = cmd.ExecuteReader
            While dr.Read
                Bar.Series("Series1").Points.AddXY(monthString, dr(0))
            End While
            If Not dr.HasRows Then
                Bar.Series("Series1").Points.AddXY(monthString, "0")
            End If
            con.Close()
        Next
    End Sub
End Class
