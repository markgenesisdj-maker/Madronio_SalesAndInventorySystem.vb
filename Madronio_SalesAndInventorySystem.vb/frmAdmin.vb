Public Class frmAdmin
    Private Sub BTNDASHBOARD_Click(sender As Object, e As EventArgs) Handles BTNDASHBOARD.Click

    End Sub

    Private Sub BTNLOGOUT_Click(sender As Object, e As EventArgs) Handles BTNLOGOUT.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub BTNUSER_Click(sender As Object, e As EventArgs) Handles BTNUSER.Click
        PNLMAIN.Controls.Clear()
        Dim useraccount As New UCUserMngm()
        useraccount.Parent = PNLMAIN
        useraccount.Show()
        useraccount.Dock = DockStyle.Fill
    End Sub
End Class