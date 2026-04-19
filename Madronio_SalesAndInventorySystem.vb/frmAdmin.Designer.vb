<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label2 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        BTNLOGOUT = New Button()
        BTNSETTINGS = New Button()
        BTNSALES = New Button()
        BTNPRODUCTS = New Button()
        BTNREPORTS = New Button()
        BTNCUSTOMERPROF = New Button()
        BTNUSER = New Button()
        BTNADDSTOCKS = New Button()
        BTNDASHBOARD = New Button()
        LBLTYPE = New Label()
        LBLNAME = New Label()
        Label3 = New Label()
        Panel2 = New Panel()
        Label6 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Panel3 = New Panel()
        LBLPAGE = New Label()
        Label9 = New Label()
        PNLMAIN = New Panel()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLight
        Label2.Location = New Point(13, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 17)
        Label2.TabIndex = 2
        Label2.Text = "Grocery Store System"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.RoyalBlue
        Label1.Location = New Point(8, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 37)
        Label1.TabIndex = 3
        Label1.Text = "MADRONIO"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Indigo
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(BTNLOGOUT)
        Panel1.Controls.Add(BTNSETTINGS)
        Panel1.Controls.Add(BTNSALES)
        Panel1.Controls.Add(BTNPRODUCTS)
        Panel1.Controls.Add(BTNREPORTS)
        Panel1.Controls.Add(BTNCUSTOMERPROF)
        Panel1.Controls.Add(BTNUSER)
        Panel1.Controls.Add(BTNADDSTOCKS)
        Panel1.Controls.Add(BTNDASHBOARD)
        Panel1.Controls.Add(LBLTYPE)
        Panel1.Controls.Add(LBLNAME)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label11)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(233, 786)
        Panel1.TabIndex = 4
        ' 
        ' BTNLOGOUT
        ' 
        BTNLOGOUT.FlatAppearance.BorderColor = Color.White
        BTNLOGOUT.FlatAppearance.BorderSize = 0
        BTNLOGOUT.FlatAppearance.MouseDownBackColor = Color.DarkBlue
        BTNLOGOUT.FlatStyle = FlatStyle.Flat
        BTNLOGOUT.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BTNLOGOUT.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        BTNLOGOUT.Image = My.Resources.Resources.Logout
        BTNLOGOUT.ImageAlign = ContentAlignment.MiddleLeft
        BTNLOGOUT.Location = New Point(-4, 732)
        BTNLOGOUT.Name = "BTNLOGOUT"
        BTNLOGOUT.Padding = New Padding(13, 0, 0, 0)
        BTNLOGOUT.Size = New Size(243, 51)
        BTNLOGOUT.TabIndex = 4
        BTNLOGOUT.Text = "Logout"
        BTNLOGOUT.TextAlign = ContentAlignment.MiddleLeft
        BTNLOGOUT.TextImageRelation = TextImageRelation.ImageBeforeText
        BTNLOGOUT.UseVisualStyleBackColor = True
        ' 
        ' BTNSETTINGS
        ' 
        BTNSETTINGS.FlatAppearance.BorderColor = Color.White
        BTNSETTINGS.FlatAppearance.BorderSize = 0
        BTNSETTINGS.FlatAppearance.MouseDownBackColor = Color.DarkBlue
        BTNSETTINGS.FlatStyle = FlatStyle.Flat
        BTNSETTINGS.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BTNSETTINGS.ForeColor = Color.White
        BTNSETTINGS.Image = My.Resources.Resources.Settings
        BTNSETTINGS.ImageAlign = ContentAlignment.MiddleLeft
        BTNSETTINGS.Location = New Point(-2, 566)
        BTNSETTINGS.Name = "BTNSETTINGS"
        BTNSETTINGS.Padding = New Padding(10, 0, 0, 0)
        BTNSETTINGS.Size = New Size(243, 51)
        BTNSETTINGS.TabIndex = 4
        BTNSETTINGS.Text = "Settings"
        BTNSETTINGS.TextAlign = ContentAlignment.MiddleLeft
        BTNSETTINGS.TextImageRelation = TextImageRelation.ImageBeforeText
        BTNSETTINGS.UseVisualStyleBackColor = True
        ' 
        ' BTNSALES
        ' 
        BTNSALES.FlatAppearance.BorderColor = Color.White
        BTNSALES.FlatAppearance.BorderSize = 0
        BTNSALES.FlatAppearance.MouseDownBackColor = Color.DarkBlue
        BTNSALES.FlatStyle = FlatStyle.Flat
        BTNSALES.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BTNSALES.ForeColor = Color.White
        BTNSALES.Image = My.Resources.Resources.Sales_Revenue_Icon
        BTNSALES.ImageAlign = ContentAlignment.MiddleLeft
        BTNSALES.Location = New Point(-1, 452)
        BTNSALES.Name = "BTNSALES"
        BTNSALES.Padding = New Padding(10, 0, 0, 0)
        BTNSALES.Size = New Size(243, 51)
        BTNSALES.TabIndex = 4
        BTNSALES.Text = "Sales Transaction"
        BTNSALES.TextAlign = ContentAlignment.MiddleLeft
        BTNSALES.TextImageRelation = TextImageRelation.ImageBeforeText
        BTNSALES.UseVisualStyleBackColor = True
        ' 
        ' BTNPRODUCTS
        ' 
        BTNPRODUCTS.FlatAppearance.BorderColor = Color.White
        BTNPRODUCTS.FlatAppearance.BorderSize = 0
        BTNPRODUCTS.FlatAppearance.MouseDownBackColor = Color.DarkBlue
        BTNPRODUCTS.FlatStyle = FlatStyle.Flat
        BTNPRODUCTS.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BTNPRODUCTS.ForeColor = Color.White
        BTNPRODUCTS.Image = My.Resources.Resources.Products
        BTNPRODUCTS.ImageAlign = ContentAlignment.MiddleLeft
        BTNPRODUCTS.Location = New Point(-1, 281)
        BTNPRODUCTS.Name = "BTNPRODUCTS"
        BTNPRODUCTS.Padding = New Padding(10, 0, 0, 0)
        BTNPRODUCTS.Size = New Size(243, 51)
        BTNPRODUCTS.TabIndex = 4
        BTNPRODUCTS.Text = "Products"
        BTNPRODUCTS.TextImageRelation = TextImageRelation.ImageBeforeText
        BTNPRODUCTS.UseVisualStyleBackColor = True
        ' 
        ' BTNREPORTS
        ' 
        BTNREPORTS.FlatAppearance.BorderColor = Color.White
        BTNREPORTS.FlatAppearance.BorderSize = 0
        BTNREPORTS.FlatAppearance.MouseDownBackColor = Color.DarkBlue
        BTNREPORTS.FlatStyle = FlatStyle.Flat
        BTNREPORTS.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BTNREPORTS.ForeColor = Color.White
        BTNREPORTS.Image = My.Resources.Resources.Reports
        BTNREPORTS.ImageAlign = ContentAlignment.MiddleLeft
        BTNREPORTS.Location = New Point(-1, 509)
        BTNREPORTS.Name = "BTNREPORTS"
        BTNREPORTS.Padding = New Padding(10, 0, 0, 0)
        BTNREPORTS.Size = New Size(243, 51)
        BTNREPORTS.TabIndex = 4
        BTNREPORTS.Text = "Reports"
        BTNREPORTS.TextAlign = ContentAlignment.MiddleLeft
        BTNREPORTS.TextImageRelation = TextImageRelation.ImageBeforeText
        BTNREPORTS.UseVisualStyleBackColor = True
        ' 
        ' BTNCUSTOMERPROF
        ' 
        BTNCUSTOMERPROF.FlatAppearance.BorderColor = Color.White
        BTNCUSTOMERPROF.FlatAppearance.BorderSize = 0
        BTNCUSTOMERPROF.FlatAppearance.MouseDownBackColor = Color.DarkBlue
        BTNCUSTOMERPROF.FlatStyle = FlatStyle.Flat
        BTNCUSTOMERPROF.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BTNCUSTOMERPROF.ForeColor = Color.White
        BTNCUSTOMERPROF.Image = My.Resources.Resources.Customer_Profile
        BTNCUSTOMERPROF.ImageAlign = ContentAlignment.MiddleLeft
        BTNCUSTOMERPROF.Location = New Point(0, 395)
        BTNCUSTOMERPROF.Name = "BTNCUSTOMERPROF"
        BTNCUSTOMERPROF.Padding = New Padding(10, 0, 0, 0)
        BTNCUSTOMERPROF.Size = New Size(243, 51)
        BTNCUSTOMERPROF.TabIndex = 4
        BTNCUSTOMERPROF.Text = "Customer Profile"
        BTNCUSTOMERPROF.TextAlign = ContentAlignment.MiddleLeft
        BTNCUSTOMERPROF.TextImageRelation = TextImageRelation.ImageBeforeText
        BTNCUSTOMERPROF.UseVisualStyleBackColor = True
        ' 
        ' BTNUSER
        ' 
        BTNUSER.FlatAppearance.BorderColor = Color.White
        BTNUSER.FlatAppearance.BorderSize = 0
        BTNUSER.FlatAppearance.MouseDownBackColor = Color.DarkBlue
        BTNUSER.FlatStyle = FlatStyle.Flat
        BTNUSER.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BTNUSER.ForeColor = Color.White
        BTNUSER.Image = My.Resources.Resources.People
        BTNUSER.ImageAlign = ContentAlignment.MiddleLeft
        BTNUSER.Location = New Point(0, 224)
        BTNUSER.Name = "BTNUSER"
        BTNUSER.Padding = New Padding(10, 0, 0, 0)
        BTNUSER.Size = New Size(243, 51)
        BTNUSER.TabIndex = 4
        BTNUSER.Text = "User Account"
        BTNUSER.TextAlign = ContentAlignment.MiddleLeft
        BTNUSER.TextImageRelation = TextImageRelation.ImageBeforeText
        BTNUSER.UseVisualStyleBackColor = True
        ' 
        ' BTNADDSTOCKS
        ' 
        BTNADDSTOCKS.FlatAppearance.BorderColor = Color.White
        BTNADDSTOCKS.FlatAppearance.BorderSize = 0
        BTNADDSTOCKS.FlatAppearance.MouseDownBackColor = Color.DarkBlue
        BTNADDSTOCKS.FlatStyle = FlatStyle.Flat
        BTNADDSTOCKS.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BTNADDSTOCKS.ForeColor = Color.White
        BTNADDSTOCKS.Image = My.Resources.Resources.Add__Stock
        BTNADDSTOCKS.ImageAlign = ContentAlignment.MiddleLeft
        BTNADDSTOCKS.Location = New Point(0, 338)
        BTNADDSTOCKS.Name = "BTNADDSTOCKS"
        BTNADDSTOCKS.Padding = New Padding(10, 0, 0, 0)
        BTNADDSTOCKS.Size = New Size(243, 51)
        BTNADDSTOCKS.TabIndex = 4
        BTNADDSTOCKS.Text = "Add Stock"
        BTNADDSTOCKS.TextAlign = ContentAlignment.MiddleLeft
        BTNADDSTOCKS.TextImageRelation = TextImageRelation.ImageBeforeText
        BTNADDSTOCKS.UseVisualStyleBackColor = True
        ' 
        ' BTNDASHBOARD
        ' 
        BTNDASHBOARD.FlatAppearance.BorderColor = Color.White
        BTNDASHBOARD.FlatAppearance.BorderSize = 0
        BTNDASHBOARD.FlatAppearance.MouseDownBackColor = Color.DarkBlue
        BTNDASHBOARD.FlatStyle = FlatStyle.Flat
        BTNDASHBOARD.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BTNDASHBOARD.ForeColor = Color.White
        BTNDASHBOARD.Image = My.Resources.Resources.Dashboard
        BTNDASHBOARD.ImageAlign = ContentAlignment.MiddleLeft
        BTNDASHBOARD.Location = New Point(0, 167)
        BTNDASHBOARD.Name = "BTNDASHBOARD"
        BTNDASHBOARD.Padding = New Padding(10, 0, 0, 0)
        BTNDASHBOARD.Size = New Size(243, 51)
        BTNDASHBOARD.TabIndex = 4
        BTNDASHBOARD.Text = "Dashboard"
        BTNDASHBOARD.TextAlign = ContentAlignment.MiddleLeft
        BTNDASHBOARD.TextImageRelation = TextImageRelation.ImageBeforeText
        BTNDASHBOARD.UseVisualStyleBackColor = True
        ' 
        ' LBLTYPE
        ' 
        LBLTYPE.AutoSize = True
        LBLTYPE.ForeColor = Color.White
        LBLTYPE.Location = New Point(13, 124)
        LBLTYPE.Name = "LBLTYPE"
        LBLTYPE.Size = New Size(43, 15)
        LBLTYPE.TabIndex = 2
        LBLTYPE.Text = "Admin"
        ' 
        ' LBLNAME
        ' 
        LBLNAME.AutoSize = True
        LBLNAME.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LBLNAME.ForeColor = SystemColors.ButtonHighlight
        LBLNAME.Location = New Point(12, 105)
        LBLNAME.Name = "LBLNAME"
        LBLNAME.Size = New Size(116, 21)
        LBLNAME.TabIndex = 2
        LBLNAME.Text = "Administrator"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ControlLight
        Label3.Location = New Point(13, 89)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 17)
        Label3.TabIndex = 2
        Label3.Text = "Loged in as:"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.RoyalBlue
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label8)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(233, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1047, 79)
        Panel2.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(969, 29)
        Label6.Name = "Label6"
        Label6.Size = New Size(12, 17)
        Label6.TabIndex = 4
        Label6.Text = "|"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(987, 29)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 17)
        Label4.TabIndex = 3
        Label4.Text = "Admin"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(15, 14)
        Label5.Name = "Label5"
        Label5.Size = New Size(348, 32)
        Label5.TabIndex = 1
        Label5.Text = "MADRONIO GROCERY STORE"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(875, 30)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 17)
        Label7.TabIndex = 2
        Label7.Text = "Administrator"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ControlLight
        Label8.Location = New Point(19, 46)
        Label8.Name = "Label8"
        Label8.Size = New Size(177, 17)
        Label8.TabIndex = 2
        Label8.Text = "Sales and Inventory System"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ControlLight
        Panel3.Controls.Add(LBLPAGE)
        Panel3.Controls.Add(Label9)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(233, 79)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1047, 35)
        Panel3.TabIndex = 6
        ' 
        ' LBLPAGE
        ' 
        LBLPAGE.AutoSize = True
        LBLPAGE.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LBLPAGE.ForeColor = Color.Black
        LBLPAGE.Location = New Point(79, 8)
        LBLPAGE.Name = "LBLPAGE"
        LBLPAGE.Size = New Size(55, 17)
        LBLPAGE.TabIndex = 2
        LBLPAGE.Text = "Reports"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.DimGray
        Label9.Location = New Point(19, 9)
        Label9.Name = "Label9"
        Label9.Size = New Size(54, 17)
        Label9.TabIndex = 2
        Label9.Text = "Home /"
        ' 
        ' PNLMAIN
        ' 
        PNLMAIN.BackColor = Color.DarkGray
        PNLMAIN.Location = New Point(252, 135)
        PNLMAIN.Name = "PNLMAIN"
        PNLMAIN.Size = New Size(1016, 636)
        PNLMAIN.TabIndex = 8
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ControlLight
        Label10.Location = New Point(-12, 63)
        Label10.Name = "Label10"
        Label10.Size = New Size(258, 17)
        Label10.TabIndex = 5
        Label10.Text = "__________________________________________________"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = SystemColors.ControlLight
        Label11.Location = New Point(-15, 137)
        Label11.Name = "Label11"
        Label11.Size = New Size(258, 17)
        Label11.TabIndex = 6
        Label11.Text = "__________________________________________________"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = SystemColors.ControlLight
        Label12.Location = New Point(-15, 712)
        Label12.Name = "Label12"
        Label12.Size = New Size(258, 17)
        Label12.TabIndex = 7
        Label12.Text = "__________________________________________________"
        ' 
        ' frmAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1280, 786)
        Controls.Add(PNLMAIN)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmAdmin"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents BTNDASHBOARD As Button
    Friend WithEvents LBLTYPE As Label
    Friend WithEvents LBLNAME As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BTNLOGOUT As Button
    Friend WithEvents BTNSETTINGS As Button
    Friend WithEvents BTNSALES As Button
    Friend WithEvents BTNPRODUCTS As Button
    Friend WithEvents BTNREPORTS As Button
    Friend WithEvents BTNCUSTOMERPROF As Button
    Friend WithEvents BTNUSER As Button
    Friend WithEvents BTNADDSTOCKS As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LBLPAGE As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PNLMAIN As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
End Class
