Public Class UC_college
    Dim previousId
    Private Sub UC_college_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Refreshdata()
    End Sub
    Sub Refreshdata()
        Me.Tbl_collegesTableAdapter.Fill(Me.Db_inventoryDataSet.tbl_colleges)
    End Sub
    Private Sub BTN_clear_Click(sender As Object, e As EventArgs) Handles BTN_clear.Click
        If BTN_clear.Text = "Clear" Then
            Clearinputs()
        Else
            DeleteCollege()
            Clearinputs()
            Refreshdata()
            LBL_operation.Text = "Add a College"
            BTN_clear.Text = "Clear"
        End If
    End Sub
    Private Sub BTN_add_Click(sender As Object, e As EventArgs) Handles BTN_add.Click
        Enable()
        LBL_operation.Text = "Add a College"
        BTN_clear.Text = "Clear"
    End Sub

    Private Sub BTN_save_Click(sender As Object, e As EventArgs) Handles BTN_save.Click
        If LBL_operation.Text = "Add a College" Then
            ErrorTrappingadd()
        Else
            ErrorTrappingupdate()
        End If
    End Sub

    Private Sub DGV_products_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_colleges.CellClick
        Enable()
        Dim row = DGV_colleges.Rows(e.RowIndex)
        TXT_collegeID.Text = row.Cells(0).Value
        previousId = row.Cells(0).Value
        TXT_collegeName.Text = row.Cells(1).Value
        LBL_operation.Text = "Edit a College"
        BTN_clear.Text = "Delete"
    End Sub

    Sub Clearinputs()
        TXT_collegeID.Text = ""
        TXT_collegeName.Text = ""
    End Sub
    Sub Enable()
        Clearinputs()
        TXT_collegeName.Enabled = True
        TXT_collegeID.Enabled = True
        BTN_clear.Enabled = True
        BTN_save.Enabled = True
    End Sub
    Sub ErrorTrappingadd()
        openCon()
        cmd.CommandText = "select * from tbl_colleges where collegeID = @ID"
        With cmd.Parameters
            .Clear()
            .AddWithValue("ID", TXT_collegeID.Text)
        End With
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            MsgBox("The College Department is already on the list", vbOKOnly + vbExclamation, "Saving error")
            TXT_collegeID.Text = ""
            TXT_collegeName.Text = ""
            con.Close()
            Exit Sub
        End If
        con.Close()
        If TXT_collegeID.Text = "" Or TXT_collegeName.Text = "" Then
            MsgBox("All fields are required", vbOKOnly + vbExclamation, "Saving Error")
            Exit Sub
        End If
        AddCollege()
        Refreshdata()
    End Sub

    Sub ErrorTrappingupdate()
        openCon()
        cmd.CommandText = "select * from tbl_colleges where collegeID = @ID"
        With cmd.Parameters
            .Clear()
            .AddWithValue("ID", TXT_collegeID.Text)
        End With
        cmd.ExecuteNonQuery()

        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            If dr(0) <> previousId Then
                MsgBox("The College Department is already on the list", vbOKOnly + vbExclamation, "Updating Error")
                con.Close()
                Exit Sub
            End If
        End If
        con.Close()
        If TXT_collegeID.Text = "" Or TXT_collegeName.Text = "" Then
            MsgBox("All fields are required", vbOKOnly + vbExclamation, "Saving Error")
            Exit Sub
        End If
        UpdateCollege()
        Refreshdata()
    End Sub

    Sub AddCollege()
        openCon()
        cmd.CommandText = "Insert into tbl_colleges values(@id, @name)"
        With cmd.Parameters
            .Clear()
            .AddWithValue("id", TXT_collegeID.Text)
            .AddWithValue("name", TXT_collegeName.Text)
        End With
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Sub UpdateCollege()
        openCon()
        cmd.CommandText = "Update tbl_colleges set collegeID= @ID, collegeName = @name where collegeID = @prevID"
        With cmd.Parameters
            .Clear()
            .AddWithValue("ID", TXT_collegeID.Text)
            .AddWithValue("name", TXT_collegeName.Text)
            .AddWithValue("prevID", previousId)
        End With
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Sub DeleteCollege()
        openCon()
        cmd.CommandText = "delete from tbl_colleges where collegeID=@ID"
        With cmd.Parameters
            .Clear()
            .AddWithValue("ID", previousId)
        End With
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

End Class
