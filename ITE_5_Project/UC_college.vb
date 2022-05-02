Public Class UC_college
    Private Sub UC_college_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Refreshdata()
    End Sub
    Sub Refreshdata()
        Me.Tbl_collegesTableAdapter.Fill(Me.Db_inventoryDataSet.tbl_colleges)
    End Sub
    Private Sub BTN_clear_Click(sender As Object, e As EventArgs) Handles BTN_clear.Click
        Clearinputs()
    End Sub
    Private Sub BTN_add_Click(sender As Object, e As EventArgs) Handles BTN_add.Click
        Enable()
        LBL_operation.Text = "Add a College"
    End Sub

    Private Sub BTN_save_Click(sender As Object, e As EventArgs) Handles BTN_save.Click
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
        If TXT_collegeID.Text = "" And TXT_collegeName.Text = "" Then
            MsgBox("All fields are required", vbOKOnly + vbExclamation, "Saving Error")
            Exit Sub
        End If
        AddCollege()
        Refreshdata()
    End Sub

    Private Sub DGV_products_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_colleges.CellClick
        Clearinputs()
        Dim row = DGV_colleges.Rows(e.RowIndex)
        TXT_collegeID = row.Cells(0).Value
        TXT_collegeName = row.Cells(1).Value
        Enable()
        LBL_operation.Text = "Edit a College"
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


End Class
