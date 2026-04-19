<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label5 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TXTUN = New TextBox()
        TXTPW = New TextBox()
        BTNLOGIN = New Button()
        BTNCLEAR = New Button()
        BTNEXIT = New Button()
        CHKSHOWPW = New CheckBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.RoyalBlue
        Panel1.Controls.Add(Label5)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(500, 65)
        Panel1.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(12, 14)
        Label5.Name = "Label5"
        Label5.Size = New Size(165, 32)
        Label5.TabIndex = 1
        Label5.Text = "System Login"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.RoyalBlue
        Label1.Location = New Point(89, 95)
        Label1.Name = "Label1"
        Label1.Size = New Size(305, 30)
        Label1.TabIndex = 1
        Label1.Text = "MADRONIO GROCERY STORE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(138, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(201, 21)
        Label2.TabIndex = 1
        Label2.Text = "Sales and Inventory System"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label3.Location = New Point(37, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 20)
        Label3.TabIndex = 1
        Label3.Text = "Username"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label4.Location = New Point(35, 227)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 1
        Label4.Text = "Password"
        ' 
        ' TXTUN
        ' 
        TXTUN.ForeColor = Color.DimGray
        TXTUN.Location = New Point(38, 191)
        TXTUN.Name = "TXTUN"
        TXTUN.Size = New Size(414, 29)
        TXTUN.TabIndex = 1
        TXTUN.Text = "Enter Username"
        ' 
        ' TXTPW
        ' 
        TXTPW.ForeColor = Color.DimGray
        TXTPW.Location = New Point(38, 255)
        TXTPW.Name = "TXTPW"
        TXTPW.Size = New Size(414, 29)
        TXTPW.TabIndex = 2
        TXTPW.Text = "Enter Password"
        ' 
        ' BTNLOGIN
        ' 
        BTNLOGIN.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        BTNLOGIN.Location = New Point(35, 342)
        BTNLOGIN.Name = "BTNLOGIN"
        BTNLOGIN.Size = New Size(123, 46)
        BTNLOGIN.TabIndex = 4
        BTNLOGIN.Text = "Login"
        BTNLOGIN.UseVisualStyleBackColor = True
        ' 
        ' BTNCLEAR
        ' 
        BTNCLEAR.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        BTNCLEAR.Location = New Point(181, 342)
        BTNCLEAR.Name = "BTNCLEAR"
        BTNCLEAR.Size = New Size(123, 46)
        BTNCLEAR.TabIndex = 5
        BTNCLEAR.Text = "Clear"
        BTNCLEAR.UseVisualStyleBackColor = True
        ' 
        ' BTNEXIT
        ' 
        BTNEXIT.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        BTNEXIT.Location = New Point(327, 342)
        BTNEXIT.Name = "BTNEXIT"
        BTNEXIT.Size = New Size(123, 46)
        BTNEXIT.TabIndex = 6
        BTNEXIT.Text = "Exit"
        BTNEXIT.UseVisualStyleBackColor = True
        ' 
        ' CHKSHOWPW
        ' 
        CHKSHOWPW.AutoSize = True
        CHKSHOWPW.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        CHKSHOWPW.Location = New Point(41, 291)
        CHKSHOWPW.Name = "CHKSHOWPW"
        CHKSHOWPW.Size = New Size(154, 24)
        CHKSHOWPW.TabIndex = 3
        CHKSHOWPW.Text = "Show Password"
        CHKSHOWPW.UseVisualStyleBackColor = True
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(500, 400)
        Controls.Add(CHKSHOWPW)
        Controls.Add(BTNEXIT)
        Controls.Add(BTNCLEAR)
        Controls.Add(BTNLOGIN)
        Controls.Add(TXTPW)
        Controls.Add(TXTUN)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTUN As TextBox
    Friend WithEvents TXTPW As TextBox
    Friend WithEvents BTNLOGIN As Button
    Friend WithEvents BTNCLEAR As Button
    Friend WithEvents BTNEXIT As Button
    Friend WithEvents CHKSHOWPW As CheckBox

End Class
