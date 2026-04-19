<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCUserMngm
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Panel1 = New Panel()
        Panel2 = New Panel()
        CBUSERTYPE = New ComboBox()
        BTNCANCEL = New Button()
        BTNDELETE = New Button()
        BTNEDIT = New Button()
        BTNSAVE = New Button()
        BTNADD = New Button()
        TXTCONFIRMPW = New TextBox()
        Label2 = New Label()
        TXTPASSWORD = New TextBox()
        Label6 = New Label()
        Label1 = New Label()
        TXTLOGIN = New TextBox()
        Label4 = New Label()
        TXTUNAME = New TextBox()
        Label3 = New Label()
        Panel4 = New Panel()
        Label5 = New Label()
        Panel3 = New Panel()
        DGVUSERACCOUNT = New DataGridView()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DGVUSERACCOUNT, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(14, 14)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(985, 339)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(CBUSERTYPE)
        Panel2.Controls.Add(BTNCANCEL)
        Panel2.Controls.Add(BTNDELETE)
        Panel2.Controls.Add(BTNEDIT)
        Panel2.Controls.Add(BTNSAVE)
        Panel2.Controls.Add(BTNADD)
        Panel2.Controls.Add(TXTCONFIRMPW)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(TXTPASSWORD)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(TXTLOGIN)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(TXTUNAME)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Panel4)
        Panel2.Location = New Point(14, 14)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(985, 370)
        Panel2.TabIndex = 0
        ' 
        ' CBUSERTYPE
        ' 
        CBUSERTYPE.Enabled = False
        CBUSERTYPE.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CBUSERTYPE.ForeColor = Color.DimGray
        CBUSERTYPE.FormattingEnabled = True
        CBUSERTYPE.Location = New Point(517, 174)
        CBUSERTYPE.Name = "CBUSERTYPE"
        CBUSERTYPE.Size = New Size(414, 29)
        CBUSERTYPE.TabIndex = 5
        ' 
        ' BTNCANCEL
        ' 
        BTNCANCEL.Enabled = False
        BTNCANCEL.FlatAppearance.BorderColor = Color.DarkGray
        BTNCANCEL.FlatStyle = FlatStyle.Flat
        BTNCANCEL.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        BTNCANCEL.Location = New Point(566, 296)
        BTNCANCEL.Name = "BTNCANCEL"
        BTNCANCEL.Size = New Size(117, 53)
        BTNCANCEL.TabIndex = 10
        BTNCANCEL.Text = "Cancel"
        BTNCANCEL.UseVisualStyleBackColor = True
        ' 
        ' BTNDELETE
        ' 
        BTNDELETE.BackColor = Color.Red
        BTNDELETE.FlatAppearance.BorderSize = 0
        BTNDELETE.FlatStyle = FlatStyle.Flat
        BTNDELETE.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        BTNDELETE.ForeColor = Color.White
        BTNDELETE.Image = My.Resources.Resources.Delete
        BTNDELETE.Location = New Point(434, 296)
        BTNDELETE.Name = "BTNDELETE"
        BTNDELETE.Size = New Size(117, 53)
        BTNDELETE.TabIndex = 9
        BTNDELETE.Text = "Delete"
        BTNDELETE.TextImageRelation = TextImageRelation.ImageBeforeText
        BTNDELETE.UseVisualStyleBackColor = False
        ' 
        ' BTNEDIT
        ' 
        BTNEDIT.FlatAppearance.BorderColor = Color.DarkGray
        BTNEDIT.FlatStyle = FlatStyle.Flat
        BTNEDIT.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        BTNEDIT.Location = New Point(302, 296)
        BTNEDIT.Name = "BTNEDIT"
        BTNEDIT.Size = New Size(117, 53)
        BTNEDIT.TabIndex = 8
        BTNEDIT.Text = "Edit"
        BTNEDIT.UseVisualStyleBackColor = True
        ' 
        ' BTNSAVE
        ' 
        BTNSAVE.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        BTNSAVE.Enabled = False
        BTNSAVE.FlatAppearance.BorderSize = 0
        BTNSAVE.FlatStyle = FlatStyle.Flat
        BTNSAVE.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        BTNSAVE.ForeColor = Color.White
        BTNSAVE.Image = My.Resources.Resources.Save
        BTNSAVE.Location = New Point(170, 296)
        BTNSAVE.Name = "BTNSAVE"
        BTNSAVE.Size = New Size(117, 53)
        BTNSAVE.TabIndex = 7
        BTNSAVE.Text = "Save"
        BTNSAVE.TextImageRelation = TextImageRelation.ImageBeforeText
        BTNSAVE.UseVisualStyleBackColor = False
        ' 
        ' BTNADD
        ' 
        BTNADD.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BTNADD.FlatAppearance.BorderSize = 0
        BTNADD.FlatStyle = FlatStyle.Flat
        BTNADD.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        BTNADD.ForeColor = Color.White
        BTNADD.Image = My.Resources.Resources.Add
        BTNADD.Location = New Point(38, 296)
        BTNADD.Name = "BTNADD"
        BTNADD.Size = New Size(117, 53)
        BTNADD.TabIndex = 6
        BTNADD.Text = "Add"
        BTNADD.TextImageRelation = TextImageRelation.ImageBeforeText
        BTNADD.UseVisualStyleBackColor = False
        ' 
        ' TXTCONFIRMPW
        ' 
        TXTCONFIRMPW.BackColor = Color.WhiteSmoke
        TXTCONFIRMPW.BorderStyle = BorderStyle.FixedSingle
        TXTCONFIRMPW.Enabled = False
        TXTCONFIRMPW.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TXTCONFIRMPW.ForeColor = Color.DimGray
        TXTCONFIRMPW.Location = New Point(38, 243)
        TXTCONFIRMPW.Name = "TXTCONFIRMPW"
        TXTCONFIRMPW.PasswordChar = "*"c
        TXTCONFIRMPW.Size = New Size(414, 29)
        TXTCONFIRMPW.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label2.Location = New Point(34, 220)
        Label2.Name = "Label2"
        Label2.Size = New Size(153, 20)
        Label2.TabIndex = 3
        Label2.Text = "Confirm Password"
        ' 
        ' TXTPASSWORD
        ' 
        TXTPASSWORD.BackColor = Color.WhiteSmoke
        TXTPASSWORD.BorderStyle = BorderStyle.FixedSingle
        TXTPASSWORD.Enabled = False
        TXTPASSWORD.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TXTPASSWORD.ForeColor = Color.DimGray
        TXTPASSWORD.Location = New Point(38, 174)
        TXTPASSWORD.Name = "TXTPASSWORD"
        TXTPASSWORD.PasswordChar = "*"c
        TXTPASSWORD.Size = New Size(414, 29)
        TXTPASSWORD.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label6.Location = New Point(514, 151)
        Label6.Name = "Label6"
        Label6.Size = New Size(90, 20)
        Label6.TabIndex = 3
        Label6.Text = "User Type"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label1.Location = New Point(34, 151)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 20)
        Label1.TabIndex = 3
        Label1.Text = "Password"
        ' 
        ' TXTLOGIN
        ' 
        TXTLOGIN.BackColor = Color.WhiteSmoke
        TXTLOGIN.BorderStyle = BorderStyle.FixedSingle
        TXTLOGIN.Enabled = False
        TXTLOGIN.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TXTLOGIN.ForeColor = Color.DimGray
        TXTLOGIN.Location = New Point(517, 110)
        TXTLOGIN.Name = "TXTLOGIN"
        TXTLOGIN.Size = New Size(414, 29)
        TXTLOGIN.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label4.Location = New Point(514, 87)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 20)
        Label4.TabIndex = 3
        Label4.Text = "Login Name"
        ' 
        ' TXTUNAME
        ' 
        TXTUNAME.BackColor = Color.WhiteSmoke
        TXTUNAME.BorderStyle = BorderStyle.FixedSingle
        TXTUNAME.Enabled = False
        TXTUNAME.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TXTUNAME.ForeColor = Color.DimGray
        TXTUNAME.Location = New Point(38, 110)
        TXTUNAME.Name = "TXTUNAME"
        TXTUNAME.Size = New Size(414, 29)
        TXTUNAME.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label3.Location = New Point(34, 87)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 20)
        Label3.TabIndex = 3
        Label3.Text = "Username"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.RoyalBlue
        Panel4.Controls.Add(Label5)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(985, 57)
        Panel4.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(14, 12)
        Label5.Name = "Label5"
        Label5.Size = New Size(280, 30)
        Label5.TabIndex = 2
        Label5.Text = "User Account Management"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(DGVUSERACCOUNT)
        Panel3.Location = New Point(14, 399)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(985, 215)
        Panel3.TabIndex = 0
        ' 
        ' DGVUSERACCOUNT
        ' 
        DGVUSERACCOUNT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVUSERACCOUNT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVUSERACCOUNT.Location = New Point(14, 13)
        DGVUSERACCOUNT.Name = "DGVUSERACCOUNT"
        DGVUSERACCOUNT.Size = New Size(956, 189)
        DGVUSERACCOUNT.TabIndex = 0
        ' 
        ' UCUserMngm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "UCUserMngm"
        Size = New Size(1016, 636)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        CType(DGVUSERACCOUNT, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTUNAME As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTCONFIRMPW As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTPASSWORD As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTLOGIN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BTNCANCEL As Button
    Friend WithEvents BTNDELETE As Button
    Friend WithEvents BTNEDIT As Button
    Friend WithEvents BTNSAVE As Button
    Friend WithEvents BTNADD As Button
    Friend WithEvents DGVUSERACCOUNT As DataGridView
    Friend WithEvents CBUSERTYPE As ComboBox

End Class
