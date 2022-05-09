Public Class UC_pcategory
    Dim prevcat
    Private Sub UC_pcategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub
    Private Sub BTN_save_Click(sender As Object, e As EventArgs) Handles BTN_save.Click
        If LBL_operation.Text = "Add a Product Category" Then
            ErrorTrappingAdd()
        Else
            ErrorTrappingUpdate()
        End If
    End Sub
    Private Sub BTN_clear_Click(sender As Object, e As EventArgs) Handles BTN_clear.Click
        If BTN_clear.Text = "Delete" Then
            Dim answer = MsgBox(("Are you sure you want to delete the category, " + prevcat + " ?"), vbYesNo + vbQuestion, "Delete Product Category")
            If answer = vbYes Then
                Deletecategory()
                TXT_catID.Text = ""
            End If
        Else
            TXT_catID.Text = ""
        End If
    End Sub
    Private Sub BTN_add_Click(sender As Object, e As EventArgs) Handles BTN_add.Click
        Enable()
        LBL_operation.Text = "Add a Product Category"
        BTN_clear.Text = "Clear"
    End Sub
    Private Sub DGV_pcategory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_pcategory.CellClick
        Enable()
        Dim row = DGV_pcategory.Rows(e.RowIndex)
        TXT_catID.Text = row.Cells(0).Value
        prevcat = row.Cells(0).Value
        LBL_operation.Text = "Edit a Product Category"
        BTN_clear.Text = "Delete"
    End Sub
    Sub Enable()
        TXT_catID.Enabled = True
        BTN_clear.Enabled = True
        BTN_save.Enabled = True
        TXT_catID.Text = ""
    End Sub

    Sub ErrorTrappingAdd()
        If TXT_catID.Text = "" Then
            MsgBox("Input the Category Name", vbOKOnly + vbExclamation, "Error Saving")
            Exit Sub
        End If
        openCon()
        cmd.CommandText = "select * from tbl_categories where ProductCategory = @cat"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("cat", TXT_catID.Text)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            MsgBox("The Product Category is already listed", vbOKOnly + vbExclamation, "Error Saving")
            con.Close()
            Exit Sub
        End If
        con.Close()
        Addcategory()
    End Sub
    Sub ErrorTrappingUpdate()
        If TXT_catID.Text = "" Then
            MsgBox("Input the Category Name", vbOKOnly + vbExclamation, "Error Saving")
            Exit Sub
        End If
        openCon()
        cmd.CommandText = "select * from tbl_categories where ProductCategory = @cat"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("cat", TXT_catID.Text)
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            If dr(0) <> prevcat Then
                MsgBox("The Product Category is already on the list", vbOKOnly + vbExclamation, "Error Updating")
                TXT_catID.Text = prevcat
                con.Close()
                Exit Sub
            End If
        End If
        con.Close()
        Updatecategory()
    End Sub
    Sub Addcategory()
        openCon()
        cmd.CommandText = "insert into tbl_categories values(@cat)"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("cat", TXT_catID.Text)
        cmd.ExecuteNonQuery()
        con.Close()
        RefreshData()
        SaveActivity("Added a Product Category: " + TXT_catID.Text)
    End Sub
    Sub Updatecategory()
        openCon()
        cmd.CommandText = "Update tbl_categories set ProductCategory = @cat where ProductCategory = @prevcat"
        With cmd.Parameters
            .Clear()
            .AddWithValue("cat", TXT_catID.Text)
            .AddWithValue("prevcat", prevcat)
        End With
        cmd.ExecuteNonQuery()
        con.Close()
        RefreshData()
        SaveActivity("Updated a Product Category: " + prevcat + " to " + TXT_catID.Text)
    End Sub
    Sub Deletecategory()
        openCon()
        cmd.CommandText = "Delete from tbl_categories where ProductCategory = @cat"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("cat", prevcat)
        cmd.ExecuteNonQuery()
        con.Close()
        RefreshData()
        SaveActivity("Deleted a Product Category: " + prevcat)
    End Sub
    Sub RefreshData()
        Me.Tbl_categoriesTableAdapter.Fill(Me.Db_inventoryDataSet.tbl_categories)
    End Sub

End Class
