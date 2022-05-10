Public Class SUBFRM_addstocks
    Private Sub BTN_back_Click(sender As Object, e As EventArgs) Handles BTN_back.Click
        Clear()
        Me.Close()
    End Sub
    Private Sub SUBFRM_addstocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getdata()
    End Sub
    Private Sub MaterialSlider1_onValueChanged(sender As Object, newValue As Integer) Handles Slider.onValueChanged
        TXT_stocksno.Text = Slider.Value
    End Sub
    Private Sub TXT_stocksno_TextChanged(sender As Object, e As EventArgs) Handles TXT_stocksno.TextChanged
        Slider.Value = Val(TXT_stocksno.Text)
    End Sub
    Private Sub TXT_stocksno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_stocksno.KeyPress
        numberonly(e.KeyChar, e)
        If TXT_stocksno.Text.Count = 8 And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub BTN_addstock_Click(sender As Object, e As EventArgs) Handles BTN_addstock.Click
        If TXT_stocksno.Text = "" Or TXT_stocksno.Text = "0" Then
            MsgBox("No stocks to be added", vbOKOnly + vbExclamation, "Error adding")
            Exit Sub
        End If
        recordstocks()
        updatestocks()
        Clear()
        Refreshtables()
        Me.Close()
    End Sub
    Sub getdata()
        openCon()
        cmd.CommandText = "select * from tbl_products where ProductID = @id"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("id", clickedkey)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        dr.Read()
        LBL_id.Text = "Product ID: " + CStr(clickedkey)
        LBL_name.Text = dr.GetString("ProductName")
        LBL_category.Text = dr.GetString("ProductCategory")
        TXT_currentstocks.Text = dr.GetString("Stocks")
        con.Close()
    End Sub
    Sub Clear()
        Slider.Value = 0
        TXT_stocksno.Text = ""
    End Sub

    Sub recordstocks()
        openCon()
        cmd.CommandText = "insert into tbl_stocks(ProductID, ProductName, AddedStocks, Date) values(@id,@pn,@as,@d)"
        With cmd.Parameters
            .Clear()
            .AddWithValue("id", clickedkey)
            .AddWithValue("pn", LBL_name.Text)
            .AddWithValue("as", TXT_stocksno.Text)
            .AddWithValue("d", DATE_addeddate.Value)
        End With
        cmd.ExecuteNonQuery()
        con.Close()
        SaveActivity("Added Stocks to a Product with ID: " + CStr(clickedkey))
    End Sub
    Sub updatestocks()
        Dim totalstocks = Val(TXT_stocksno.Text) + Val(TXT_currentstocks.Text)
        openCon()
        cmd.CommandText = "update tbl_products set Stocks=@s where ProductID=@id"
        With cmd.Parameters
            .Clear()
            .AddWithValue("s", totalstocks)
            .AddWithValue("id", clickedkey)
        End With
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Sub Refreshtables()
        Dim uc As New UC_stocks
        FRM_mainmenu.TAB_stocks.Controls.Clear()
        uc.Parent = FRM_mainmenu.TAB_stocks
        uc.Dock = DockStyle.Fill
    End Sub
End Class