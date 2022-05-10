Public Class SUBFRM_viewproduct
    Dim Product, category, price, stocks
    Private Sub SUBFRM_viewproduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Getdata()
        Getcategories()
        attachinputvalues()
    End Sub

    Private Sub BTN_back_Click(sender As Object, e As EventArgs) Handles BTN_back.Click
        Me.Close()
    End Sub

    Private Sub BTN_delete_Click(sender As Object, e As EventArgs) Handles BTN_delete.Click
        DeleteProduct()
    End Sub

    Private Sub BTN_save_Click(sender As Object, e As EventArgs) Handles BTN_save.Click
        If TXT_productname.Text = "" Or CBO_category.Text = "" Or TXT_price.Text = "" Or TXT_stocks.Text = "" Then
            MsgBox("All fields are Required", vbOKOnly + vbExclamation, "Error Saving")
            Exit Sub
        End If
        updateProduct()
    End Sub

    Sub Getdata()
        openCon()
        cmd.CommandText = "select * from tbl_products where ProductID=@id"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("id", clickedkey)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        dr.Read()
        Product = dr.GetString("ProductName")
        category = dr.GetString("ProductCategory")
        price = dr.GetString("Price")
        stocks = dr.GetString("stocks")
        con.Close()
    End Sub

    Sub Getcategories()
        openCon()
        cmd.CommandText = "select * from tbl_categories"
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        CBO_category.Items.Clear()
        While dr.Read
            CBO_category.Items.Add(dr.GetString("ProductCategory"))
        End While
        con.Close()
    End Sub

    Private Sub TXT_price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_price.KeyPress
        numberonly(e.KeyChar, e)
    End Sub

    Private Sub TXT_stocks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_stocks.KeyPress
        numberonly(e.KeyChar, e)
    End Sub

    Sub attachinputvalues()
        TXT_productname.Text = Product
        CBO_category.Text = category
        CBO_category.Refresh()
        TXT_stocks.Text = (stocks)
        TXT_price.Text = (price)
    End Sub
    Sub updateProduct()
        openCon()
        cmd.CommandText = "update tbl_products set ProductName=@pn, ProductCategory=@pc, Price=@p, Stocks=@s where ProductID=@id"
        With cmd.Parameters
            .Clear()
            .AddWithValue("pn", TXT_productname.Text)
            .AddWithValue("pc", CBO_category.Text)
            .AddWithValue("p", TXT_price.Text)
            .AddWithValue("s", TXT_stocks.Text)
            .AddWithValue("id", clickedkey)
        End With
        cmd.ExecuteNonQuery()
        con.Close()
        SaveActivity("Updated a product with ID: " + CStr(clickedkey))
        Refreshtable()
        Me.Close()
    End Sub
    Sub DeleteProduct()
        openCon()
        cmd.CommandText = "delete from tbl_products where ProductId = @ID"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("ID", clickedkey)
        cmd.ExecuteNonQuery()
        con.Close()
        SaveActivity("Deleted a Product with ID: " + CStr(clickedkey))
        Refreshtable()
        Me.Close()
    End Sub
    Sub Refreshtable()
        Dim uc As New UC_products
        FRM_mainmenu.TAB_products.Controls.Clear()
        uc.Parent = FRM_mainmenu.TAB_products
        uc.Dock = DockStyle.Fill
    End Sub
End Class