Public Class frmLogin
    Dim Admin As String = "Admin"
    Dim Cashier As String = "Cashier"
    Dim Clerk As String = "Clerk"

    Private Sub BTNCLEAR_Click(sender As Object, e As EventArgs) Handles BTNCLEAR.Click
        TXTUN.Text = ""
        TXTPW.Text = ""
        TXTUN.Focus()
    End Sub

    Private Sub BTNEXIT_Click(sender As Object, e As EventArgs) Handles BTNEXIT.Click
        Me.Close()
    End Sub

    Private Sub BTNLOGIN_Click(sender As Object, e As EventArgs) Handles BTNLOGIN.Click
        '*************Admin login*************
        OpenCon()
        cmd.CommandText = "Select * from tbl_login where Username = '" & TXTUN.Text & "' and Password = '" & TXTPW.Text & "' and Usertype = '" & Admin & "' "
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If (dr.HasRows) Then
            While dr.Read
                frmAdmin.LBLNAME.Text = dr("Login name")
                frmAdmin.LBLNAME2.Text = dr("Login name")
                frmAdmin.LBLTYPE.Text = dr("Usertype")
                frmAdmin.LBLTYPE2.Text = dr("Usertype")
            End While

            frmAdmin.Show()
            Me.Close()
            con.Close()
            Exit Sub
        End If
        con.Close()

        '*************Cashier login*************
        OpenCon()
        cmd.CommandText = "Select * from tbl_login where Username = '" & TXTUN.Text & "' and Password = '" & TXTPW.Text & "' and Usertype = '" & Cashier & "' "
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If (dr.HasRows) Then
            frmStaff.Show()
            Me.Close()
        Else
            MsgBox("Wrong username and password", vbOKOnly + vbCritical, "Error Login")
            TXTUN.Text = ""
            TXTPW.Text = ""
            TXTUN.Focus()
        End If
        con.Close()

        '*************Clerk login*************
        OpenCon()
        cmd.CommandText = "Select * from tbl_login where Username = '" & TXTUN.Text & "' and Password = '" & TXTPW.Text & "' and Usertype = '" & Clerk & "' "
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If (dr.HasRows) Then
            frmClerk.Show()
            Me.Close()
        Else
            MsgBox("Wrong username and password", vbOKOnly + vbCritical, "Error Login")
            TXTUN.Text = ""
            TXTPW.Text = ""
            TXTUN.Focus()
        End If
        con.Close()

    End Sub

    Private Sub CHKSHOWPW_CheckedChanged(sender As Object, e As EventArgs) Handles CHKSHOWPW.CheckedChanged
        If CHKSHOWPW.Checked = True Then
            TXTPW.UseSystemPasswordChar = False
        Else
            TXTPW.UseSystemPasswordChar = True
        End If
    End Sub
End Class
