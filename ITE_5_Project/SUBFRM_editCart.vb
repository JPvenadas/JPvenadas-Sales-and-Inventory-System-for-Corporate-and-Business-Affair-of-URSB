Public Class SUBFRM_editCart
    Dim totalprice, price, productId, initialquantity
    Private Sub SUBFRM_editCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Attachvalues()
    End Sub

    Sub Attachvalues()
        openCon()
        cmd.CommandText = "select * from tbl_cart where TransactionID=@ID and ProductID=@ID2"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("ID", clickedkey)
        cmd.Parameters.AddWithValue("ID2", clickedkey2)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        dr.Read()
        productId = dr.GetString("ProductID")
        LBL_id.Text = "Product ID: " + productId
        LBL_name.Text = dr.GetString("ProductName")
        price = Val(dr.GetString("Price"))
        LBL_price.Text = "Price: " + Format(price, "#,###,##0.00")
        initialquantity = Val(dr.GetString("Quantity"))
        TXT_quantity.Text = initialquantity
        LBL_totalPrice.Text = dr.GetString("TotalAmount")
        con.Close()
    End Sub

    Private Sub BTN_back_Click(sender As Object, e As EventArgs) Handles BTN_back.Click
        Me.Close()
    End Sub

    Private Sub SLD_quantity_onValueChanged(sender As Object, newValue As Integer) Handles SLD_quantity.onValueChanged
        TXT_quantity.Text = SLD_quantity.Value
    End Sub

    Private Sub TXT_quantity_TextChanged(sender As Object, e As EventArgs) Handles TXT_quantity.TextChanged
        SLD_quantity.Value = Val(TXT_quantity.Text)
        AddorSubtract()
        GetTotal()
    End Sub

    Private Sub BTN_remove_Click(sender As Object, e As EventArgs) Handles BTN_remove.Click
        openCon()
        cmd.CommandText = "delete from tbl_cart where ProductID = @ID"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("ID", productId)
        cmd.ExecuteNonQuery()
        con.Close()
        Me.Close()
        Refreshdata()
    End Sub

    Private Sub TXT_quantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_quantity.KeyPress
        numberonly(e.KeyChar, e)
    End Sub

    Private Sub BTN_save_Click(sender As Object, e As EventArgs) Handles BTN_save.Click

    End Sub

    Sub GetTotal()
        totalprice = price * Val(TXT_quantity.Text)
        LBL_totalPrice.Text = Format(totalprice, "#,###,##0.00")
    End Sub
    Sub Refreshdata()
        FRM_mainmenu.TAB_transaction.Controls.Clear()
        Dim transactions As New UC_transactions
        attachControls(transactions, FRM_mainmenu.TAB_transaction)
    End Sub

    Sub AddorSubtract()
        If Val(TXT_quantity.Text) < initialquantity Then
            BTN_save.Text = "Reduce Quantity"
        ElseIf Val(TXT_quantity.Text) = initialquantity Then
            BTN_save.Text = "No changes made"
        Else
            BTN_save.Text = "Increase Quantity"
        End If
    End Sub
End Class