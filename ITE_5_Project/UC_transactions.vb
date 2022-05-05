Public Class UC_transactions
    Private Sub UC_transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Refreshdata()
        FillAutoComplete(TXT_productName, "select ProductName from tbl_products")
        FillAutoComplete(TXT_studentID, "select StudentID from tbl_students")
        FillAutoComplete(TXT_studentName, "select CONCAT(Firstname, ' ', Middlename, ' ',Lastname ) as StudentName from tbl_students")
        FillAutoComplete(TXT_productID, "select ProductID from tbl_products")
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
End Class
