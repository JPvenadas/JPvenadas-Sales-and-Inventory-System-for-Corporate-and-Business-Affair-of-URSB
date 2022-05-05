Public Class UC_transactions
    Private Sub UC_transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Refreshdata()
    End Sub
    Sub Refreshdata()
        Me.Tbl_cartTableAdapter.Fill(Me.Db_inventoryDataSet.tbl_cart)
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

    Private Sub UC_transactions_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        FillAutoComplete(TXT_productName, "select ProductName from tbl_products")
        FillAutoComplete(TXT_productID, "select ProductID from tbl_products")
        FillAutoComplete(TXT_studentName, "select CONCAT(Firstname, ' ', Middlename, ' ',Lastname ) as StudentName from tbl_students")
        FillAutoComplete(TXT_studentID, "select StudentID from tbl_students")
    End Sub
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
            End If
            count = count + 1
        End While
        If count > 1 Then
            textbox.text = ""
            If textbox.Text = TXT_productName.Text Then
                LBL_price.Text = "0.00"
            End If
        ElseIf Not dr.HasRows Then
            textbox.text = ""
            If textbox.Text = TXT_productName.Text Then
                LBL_price.Text = "0.00"
            End If
        End If
        con.Close()
    End Sub

    Function Textmonitoring(textbox, column)
        If textbox.Text = "" Then
            Return ""
        Else
            Return ("where " + column + "=" + textbox.Text)
        End If
    End Function



    Private Sub TXT_productID_KeyUp(sender As Object, e As KeyEventArgs) Handles TXT_productID.KeyUp
        AutoInputValues(TXT_productName, ("Select ProductName, Price from tbl_products " + Textmonitoring(TXT_productID, "ProductID")))
    End Sub

    Private Sub TXT_studentID_KeyUp(sender As Object, e As KeyEventArgs) Handles TXT_studentID.KeyUp
        AutoInputValues(TXT_studentName, ("Select CONCAT(Firstname, ' ', Middlename, ' ',Lastname) from tbl_students " + Textmonitoring(TXT_studentID, "StudentID")))
    End Sub

    Private Sub TXT_productName_KeyUp(sender As Object, e As KeyEventArgs) Handles TXT_productName.KeyUp
        openCon()
        cmd.CommandText = "select ProductID, Price from tbl_products where ProductName=@pn"
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
            count = count + 1
        End While
        If count > 1 Then
            TXT_productID.Text = ""
            LBL_price.Text = "0.00"
        ElseIf Not dr.HasRows Then
            TXT_productID.Text = ""
            LBL_price.Text = "0.00"
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

    Private Sub TXT_studentID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_studentID.KeyPress
        numberonly(e.KeyChar, e)
    End Sub

    Private Sub TXT_productID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_productID.KeyPress
        numberonly(e.KeyChar, e)
    End Sub
End Class
