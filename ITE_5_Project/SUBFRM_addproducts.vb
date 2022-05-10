Public Class SUBFRM_addproducts
    Private Sub BTN_back_Click(sender As Object, e As EventArgs) Handles BTN_back.Click
        Clear()
        Me.Close()
    End Sub
    Private Sub SUBFRM_addproducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        attachCategories()
    End Sub
    Private Sub BTN_clear_Click(sender As Object, e As EventArgs) Handles BTN_clear.Click
        Clear()
    End Sub

    Private Sub BTN_add_Click(sender As Object, e As EventArgs) Handles BTN_add.Click
        If TXT_productname.Text = "" Or CBO_category.Text = "" Or TXT_price.Text = "" Or TXT_stocks.Text = "" Then
            MsgBox("All fields are required", vbOKOnly + vbExclamation, "Registration Problem")
            Exit Sub
        End If
        addProduct()
    End Sub
    Sub Clear()
        TXT_productname.Text = ""
        TXT_stocks.Text = ""
        TXT_price.Text = ""
        attachCategories()
        CBO_category.Refresh()
    End Sub

    Sub attachCategories()
        GetProductCategory()
        CBO_category.Items.Clear()
        While dr.Read
            CBO_category.Items.Add(dr.GetString("ProductCategory"))
        End While
        con.Close()
    End Sub
    Sub RefreshData()
        FRM_mainmenu.TAB_products.Controls.Clear()
        Dim products As New UC_products
        products.Parent = FRM_mainmenu.TAB_products
        products.Dock = DockStyle.Fill
    End Sub

    Sub addProduct()
        openCon()
        cmd.CommandText = "insert into tbl_products(ProductName, ProductCategory, Price, Stocks) values(@pn,@pc,@p,@s)"
        With cmd.Parameters
            .Clear()
            .AddWithValue("pn", TXT_productname.Text)
            .AddWithValue("pc", CBO_category.Text)
            .AddWithValue("p", TXT_price.Text)
            .AddWithValue("s", TXT_stocks.Text)
        End With
        cmd.ExecuteNonQuery()
        con.Close()
        SaveActivity("Added a Product: " + TXT_productname.Text)
        RefreshData()
        Clear()
        Me.Close()
    End Sub

    Private Sub TXT_price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_price.KeyPress
        numberonly(e.KeyChar, e)
    End Sub

    Private Sub TXT_stocks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_stocks.KeyPress
        numberonly(e.KeyChar, e)
    End Sub

End Class