Public Class UCUserMngm
    Private Sub UCUserMngm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmAdmin.LBLPAGE.Text = "User Management"
        TXTLOGIN.Focus()

        CBUSERTYPE.Items.Clear()
        CBUSERTYPE.Items.Add("Admin")
        CBUSERTYPE.Items.Add("Cashier")
        CBUSERTYPE.Items.Add("Staff")

        FUNCTION_REFRESH()
    End Sub

    Private Sub FUNCTION_ENABLED()
        TXTUNAME.Enabled = True
        TXTPASSWORD.Enabled = True
        TXTCONFIRMPW.Enabled = True
        TXTLOGIN.Enabled = True
        CBUSERTYPE.Enabled = True

        BTNADD.Enabled = False
        BTNEDIT.Enabled = False
        BTNDELETE.Enabled = False
        BTNSAVE.Enabled = True
        BTNCANCEL.Enabled = True
    End Sub

    Private Sub FUNCTION_DISABLED()
        TXTUNAME.Enabled = False
        TXTPASSWORD.Enabled = False
        TXTCONFIRMPW.Enabled = False
        TXTLOGIN.Enabled = False
        CBUSERTYPE.Enabled = False

        BTNADD.Enabled = True
        BTNEDIT.Enabled = True
        BTNDELETE.Enabled = True
        BTNSAVE.Enabled = False
        BTNCANCEL.Enabled = False
    End Sub

    Private Sub FUNCTION_CLEAR()
        TXTUNAME.Text = ""
        TXTPASSWORD.Text = ""
        TXTCONFIRMPW.Text = ""
        TXTLOGIN.Text = ""
        CBUSERTYPE.Text = ""
    End Sub


    Private Sub FUNCTION_REFRESH()
        OpenCon()
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM tbl_login"
        dr = cmd.ExecuteReader

        Dim dt As New DataTable()
        dt.Load(dr)

        DGVUSERACCOUNT.DataSource = dt

        dr.Close()
        con.Close()
    End Sub

    Private Sub BTNADD_Click(sender As Object, e As EventArgs) Handles BTNADD.Click
        FUNCTION_ENABLED()
        FUNCTION_CLEAR()
    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click
        '**********Error Trapping - Require Field************
        If TXTUNAME.Text = "" Or TXTPASSWORD.Text = "" Or TXTCONFIRMPW.Text = "" Or TXTLOGIN.Text = "" Or CBUSERTYPE.Text = "" Then
            MsgBox("All fields are required", vbOKOnly + vbCritical, "Error Saving")
            Exit Sub
        End If

        '**********Error Trapping - same pw and cpw************
        If TXTPASSWORD.Text <> TXTCONFIRMPW.Text Then
            MsgBox("Password did not match", vbOKOnly + vbCritical, "Error Saving")
            TXTPASSWORD.Focus()
            TXTPASSWORD.Text = ""
            TXTCONFIRMPW.Text = ""
            Exit Sub
        End If

        '**********Error Trapping - username already exist************
        If TXTUNAME.Text <> "" Then
            OpenCon()
            cmd.CommandText = "Select * from tbl_login where username = '" & TXTUNAME.Text & "' "
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("The username already exist", vbOKOnly + vbCritical, "Error Saving")
                TXTUNAME.Text = ""
                TXTUNAME.Focus()
                con.Close()
                Exit Sub
            End If
            con.Close()
        End If

        '********** SAVE CODE **************
        OpenCon()
        cmd.CommandText = "insert into tbl_login values (@un, @pw, @ln, @ut)"
        With cmd.Parameters
            .Clear()
            .AddWithValue("un", TXTUNAME.Text)
            .AddWithValue("pw", TXTPASSWORD.Text)
            .AddWithValue("ln", TXTLOGIN.Text)
            .AddWithValue("ut", CBUSERTYPE.Text)
        End With
        cmd.ExecuteNonQuery()
        con.Close()

        MsgBox("New Account has been created", vbOKOnly + vbInformation, "Saving Successful")
        FUNCTION_DISABLED()
        FUNCTION_CLEAR()
        FUNCTION_REFRESH()
    End Sub

    Private Sub DGVUSERACCOUNT_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVUSERACCOUNT.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DGVUSERACCOUNT.Rows(e.RowIndex)
            TXTUNAME.Text = row.Cells(0).Value.ToString()
            TXTPASSWORD.Text = row.Cells(1).Value.ToString()
            TXTCONFIRMPW.Text = row.Cells(1).Value.ToString()
            TXTLOGIN.Text = row.Cells(2).Value.ToString()
            CBUSERTYPE.Text = row.Cells(3).Value.ToString()
        End If
    End Sub

    Private Sub BTNEDIT_Click(sender As Object, e As EventArgs) Handles BTNEDIT.Click
        If TXTUNAME.Text = "" Then
            MsgBox("Please select a record to be edited first", vbOKOnly + vbCritical, "Error Editing")
        Else
            FUNCTION_ENABLED()
            TXTUNAME.Enabled = False
        End If
    End Sub

    Private Sub BTNDELETE_Click(sender As Object, e As EventArgs) Handles BTNDELETE.Click
        If TXTUNAME.Text = "" Then
            MsgBox("Please select a record to be deleted", vbOKOnly + vbCritical, "Error Deleting")
            Exit Sub
        End If

        If MsgBox("Are you sure you want to delete this data?", vbYesNo + vbQuestion, "Confirm Delete") = vbYes Then
            OpenCon()
            cmd.CommandText = "delete from tbl_login where username = '" & TXTUNAME.Text & "' "
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Record has been deleted", vbOKOnly + vbInformation, "Record Deleted")
            FUNCTION_CLEAR()
            FUNCTION_REFRESH()
        End If
    End Sub

    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCEL.Click
        FUNCTION_CLEAR()
        FUNCTION_DISABLED()
    End Sub

    Private Sub DGVUSERACCOUNT_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGVUSERACCOUNT.CellFormatting
        If DGVUSERACCOUNT.Columns(e.ColumnIndex).Name.ToLower = "password" Then
            If e.Value IsNot Nothing Then
                e.Value = New String("*"c, e.Value.ToString().Length)
            End If
        End If
    End Sub

    Private Sub CBUSERTYPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBUSERTYPE.SelectedIndexChanged

    End Sub
End Class
