﻿Public Class UC_transactions
    Dim totalprice = 0
    Private Sub UC_transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Refreshdata()
    End Sub
    Private Sub BTN_add_Click(sender As Object, e As EventArgs) Handles BTN_add.Click
        If TXT_quantity.Text = "0" Or TXT_quantity.Text = "" Then
            MsgBox("Cannot add a product without Quantity", vbOKOnly + vbExclamation, "Transaction Problem")
            Exit Sub
        End If
        If TXT_studentID.Text = "" Or TXT_studentName.Text = "" Then
            MsgBox("Unidentified Student, Please make sure you input a valid customer", vbOKOnly + vbExclamation, "Transaction Problem")
            Exit Sub
        End If
        If TXT_productID.Text = "" Or TXT_productName.Text = "" Then
            MsgBox("Unidentified Product, Please make sure you input a valid Product", vbOKOnly + vbExclamation, "Transaction Problem")
            Exit Sub
        End If
        If Val(TXT_quantity.Text) > Val(LBL_stocks.Text) Then
            MsgBox("Not enough Stocks", vbOKOnly + vbExclamation, "Transaction Problem")
            Exit Sub
        End If
        addtocart()
        Refreshdata()
        enableStudent(False)
    End Sub
    Private Sub UC_transactions_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        FillAutoComplete(TXT_productName, "select ProductName from tbl_products")
        FillAutoComplete(TXT_productID, "select ProductID from tbl_products")
        FillAutoComplete(TXT_studentName, "select CONCAT(Firstname, ' ', Middlename, ' ',Lastname ) as StudentName from tbl_students")
        FillAutoComplete(TXT_studentID, "select StudentID from tbl_students")
    End Sub

    Function Textmonitoring(textbox, column)
        If textbox.Text = "" Then
            Return ""
        Else
            Return ("where " + column + "=" + textbox.Text)
        End If
    End Function
    Private Sub TXT_productID_KeyUp(sender As Object, e As KeyEventArgs) Handles TXT_productID.KeyUp
        AutoInputValues(TXT_productName, ("Select ProductName, Price, Stocks from tbl_products " + Textmonitoring(TXT_productID, "ProductID")))
    End Sub

    Private Sub TXT_studentID_KeyUp(sender As Object, e As KeyEventArgs) Handles TXT_studentID.KeyUp
        AutoInputValues(TXT_studentName, ("Select CONCAT(Firstname, ' ', Middlename, ' ',Lastname) from tbl_students " + Textmonitoring(TXT_studentID, "StudentID")))
    End Sub

    Private Sub TXT_studentID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_studentID.KeyPress
        numberonly(e.KeyChar, e)
    End Sub

    Private Sub TXT_productID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_productID.KeyPress
        numberonly(e.KeyChar, e)
    End Sub
    Private Sub TXT_quantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_quantity.KeyPress
        numberonly(e.KeyChar, e)
    End Sub
    Private Sub SLD_quantity_onValueChanged(sender As Object, newValue As Integer) Handles SLD_quantity.onValueChanged
        TXT_quantity.Text = SLD_quantity.Value
    End Sub

    Private Sub TXT_quantity_TextChanged(sender As Object, e As EventArgs) Handles TXT_quantity.TextChanged
        SLD_quantity.Value = Val(TXT_quantity.Text)
        totalprice = Val(TXT_quantity.Text) * Val(LBL_price.Text)
        LBL_totalPrice.Text = Format(totalprice, "#,###,##0.00")
    End Sub

    Private Sub LBL_price_TextChanged(sender As Object, e As EventArgs) Handles LBL_price.TextChanged, LBL_stocks.TextChanged
        totalprice = Val(TXT_quantity.Text) * Val(LBL_price.Text)
        LBL_totalPrice.Text = Format(totalprice, "#,###,##0.00")
    End Sub

    Private Sub TXT_productName_KeyUp(sender As Object, e As KeyEventArgs) Handles TXT_productName.KeyUp
        openCon()
        cmd.CommandText = "select ProductID, Price, Stocks from tbl_products where ProductName=@pn"
        With cmd.Parameters
            .Clear()
            .AddWithValue("pn", TXT_productName.Text)
        End With
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        Dim count = 0
        While dr.Read
            TXT_productID.Text = dr(0)
            LBL_price.Text = dr(1)
            LBL_stocks.Text = dr(2)
            count = count + 1
        End While
        If count > 1 Then
            TXT_productID.Text = ""
            LBL_price.Text = "0.00"
            LBL_stocks.Text = "0.00"
        ElseIf Not dr.HasRows Then
            TXT_productID.Text = ""
            LBL_price.Text = "0.00"
            LBL_stocks.Text = "0.00"
        End If
        con.Close()
    End Sub
    Private Sub TXT_studentName_KeyUp(sender As Object, e As KeyEventArgs) Handles TXT_studentName.KeyUp
        openCon()
        cmd.CommandText = "select StudentID from tbl_students where concat(Firstname, ' ', Middlename, ' ',Lastname ) = @sn"
        With cmd.Parameters
            .Clear()
            .AddWithValue("sn", TXT_studentName.Text)
        End With
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        Dim count = 0
        While dr.Read
            TXT_studentID.Text = dr(0)
            count = count + 1
        End While
        If count > 1 Then
            TXT_studentID.Text = ""
        ElseIf Not dr.HasRows Then
            TXT_studentID.Text = ""
        End If
        con.Close()
    End Sub

    'the codes bellow are important functions that is being called above
    Sub AutoInputValues(textbox, command)
        openCon()
        cmd.CommandText = command
        cmd.ExecuteScalar()
        dr = cmd.ExecuteReader
        Dim count = 0
        While dr.Read
            textbox.Text = dr(0)
            If textbox.text = TXT_productName.Text Then
                LBL_price.Text = dr(1)
                LBL_stocks.Text = dr(2)
            End If
            count = count + 1
        End While
        If count > 1 Then
            textbox.text = ""
            If textbox.Text = TXT_productName.Text Then
                LBL_price.Text = "0.00"
                LBL_stocks.Text = "0.00"
            End If
        ElseIf Not dr.HasRows Then
            textbox.text = ""
            If textbox.Text = TXT_productName.Text Then
                LBL_price.Text = "0.00"
                LBL_stocks.Text = "0.00"
            End If
        End If
        con.Close()
    End Sub
    Sub FillAutoComplete(textbox, command)
        openCon()
        cmd.CommandText = command
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        Dim collection As New AutoCompleteStringCollection
        While dr.Read()
            collection.Add(dr(0))
        End While
        textbox.AutoCompleteCustomSource = collection
        con.Close()
    End Sub

    Function GeneratenewId()
        openCon()
        cmd.CommandText = "select * from tbl_transactions"
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            con.Close()
            openCon()
            cmd.CommandText = "select max(TransactionID) from tbl_transactions"
            Dim ID = Convert.ToInt64(cmd.ExecuteScalar())
            con.Close()
            Return ID + 1
        Else
            con.Close()
            Return 1
        End If
    End Function
    Sub addtocart()
        Dim newId = GeneratenewId()
        openCon()
        cmd.CommandText = "insert into tbl_cart values(@tn,@SID,@FN,@PID,@PN,@Q,@P,@TA)"
        With cmd.Parameters
            .Clear()
            .AddWithValue("tn", newId)
            .AddWithValue("SID", TXT_studentID.Text)
            .AddWithValue("FN", TXT_studentName.Text)
            .AddWithValue("PID", TXT_productID.Text)
            .AddWithValue("PN", TXT_productName.Text)
            .AddWithValue("Q", TXT_quantity.Text)
            .AddWithValue("P", LBL_price.Text)
            .AddWithValue("TA", totalprice)
        End With
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Sub enableStudent(status)
        TXT_studentName.Enabled = status
        TXT_studentID.Enabled = status
    End Sub
    Sub Refreshdata()
        Me.Tbl_cartTableAdapter.Fill(Me.Db_inventoryDataSet.tbl_cart)
    End Sub

End Class
